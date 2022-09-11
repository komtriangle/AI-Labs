/* file "Fetch.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */

using System;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Net.Security;
using System.Diagnostics;


public class Fetch
  {
    private GoldenRetriever golden_retriever;
    private static readonly string default_user_agent = "GoldenRetriever/1.0";
    private static readonly string user_agent_key = "User-Agent";
    private static readonly string http_prefix = "http://";
    private static readonly string https_prefix = "https://";
    private static readonly string script_prefix = "script://";

    private static void error(string format, params Object[] arguments)
      {
        GoldenRetriever.error(format, arguments);
      }

    public Fetch(string init_url)
      {
        golden_retriever = new GoldenRetriever();
        user_agent = default_user_agent;
        use_proxy = false;
        proxy_user_agent = null;
        proxy_parameters = new List<pair>();
        proxy_parameter_index = new Dictionary<string, int>();
        incremental_handler = null;
        incremental_state = incremental_state_type.IS_START;
        incremental_buffer_data = new byte[10];
        incremental_buffer_used = 0;
        Debug.Assert(init_url != null);
        url = init_url;

        writer = null;
        reader = null;

        timeout_seconds = default_timeout_seconds;

        parameters = new List<pair>();
        parameter_index = new Dictionary<string, int>();
      }

    public void setUserAgent(string new_user_agent)
      {
        Debug.Assert(user_agent != null);

        Debug.Assert(new_user_agent != null);
        user_agent = new_user_agent;
      }

    public void setParameter(string key, string value)
      {
        Debug.Assert(key != null);
        Debug.Assert(value != null);

        string lower_key = key.ToLower();
        if (lower_key.Equals(user_agent_key))
          {
            setUserAgent(value);
            return;
          }

        Debug.Assert(value != null);

        if (parameter_index.ContainsKey(lower_key))
          {
            int existing_index = parameter_index[lower_key];
            Debug.Assert(existing_index < parameters.Count);
            parameters[existing_index].value = value;
            return;
          }

        Debug.Assert(lower_key != null);
        int index = parameters.Count;
        pair new_element = new pair();
        new_element.key = key;
        new_element.value = value;
        parameters.Add(new_element);
        parameter_index.Add(lower_key, index);
      }

    public void setBasicAuthentication(string username, string password)
      {
        setParameter("Authorization", "Basic " +
                new string(Base64.base64_encode(
                        Encoding.UTF8.GetBytes(username + ":" + password))));
      }

    public void setTimeoutSeconds(double new_timeout_seconds)
      {
        timeout_seconds = new_timeout_seconds;
      }

    public void setProxyServer(string new_proxy_server, int port)
      {
        use_proxy = true;
        proxy_server = new_proxy_server;
        proxy_port = port;
      }

    public void setProxyUserAgent(string new_user_agent)
      {
        Debug.Assert(new_user_agent != null);
        proxy_user_agent = new_user_agent;
      }

    public void setProxyParameter(string key, string value)
      {
        Debug.Assert(key != null);
        Debug.Assert(value != null);

        string lower_key = key.ToLower();
        if (lower_key.Equals(user_agent_key))
          {
            setProxyUserAgent(value);
            return;
          }

        Debug.Assert(value != null);

        if (proxy_parameter_index.ContainsKey(lower_key))
          {
            int found_index = proxy_parameter_index[lower_key];
            Debug.Assert(found_index < proxy_parameters.Count);
            proxy_parameters[found_index].value = value;
            return;
          }

        Debug.Assert(lower_key != null);
        int index = proxy_parameters.Count;
        pair new_element = new pair();
        new_element.key = key;
        new_element.value = value;
        proxy_parameters.Add(new_element);
        proxy_parameter_index.Add(lower_key, index);
      }

    public enum Method
      {
        OPTIONS,
        GET,
        HEAD,
        POST,
        PUT,
        DELETE,
        TRACE,
        CONNECT
      };

    public FetchResult get(Method method)
      {
        SimpleFetchResult result = new SimpleFetchResult();
        SimpleFetchHandler handler = new SimpleFetchHandler(result);
        get(handler, method);
        return result;
      }

    public FetchResult get()
      {
        return get(Method.GET);
      }

    public void get(FetchHandler handler, Method method)
      {
        string method_name;
        switch (method)
          {
            case Method.OPTIONS:
                method_name = "OPTIONS";
                break;
            case Method.GET:
                method_name = "GET";
                break;
            case Method.HEAD:
                method_name = "HEAD";
                break;
            case Method.POST:
                method_name = "POST";
                break;
            case Method.PUT:
                method_name = "PUT";
                break;
            case Method.DELETE:
                method_name = "DELETE";
                break;
            case Method.TRACE:
                method_name = "TRACE";
                break;
            case Method.CONNECT:
                method_name = "CONNECT";
                break;
            default:
                Debug.Assert(false);
                method_name = null;
                break;
          }
        doHeader(method_name);
        Debug.Assert(reader != null);
        Debug.Assert(writer != null);
        writer.close();
        writer = null;
        handleReply(handler);
      }

    public void get(FetchHandler handler)
      {
        get(handler, Method.GET);
      }

    public FetchResult post(int contentByteCount, byte[] contentBytes)
      {
        SimpleFetchResult result = new SimpleFetchResult();
        SimpleFetchHandler handler = new SimpleFetchHandler(result);
        post(contentByteCount, contentBytes, handler);
        return result;
      }

    public void post(int contentByteCount, byte[] contentBytes,
                     FetchHandler handler)
      {
        setParameter("Content-Length", string.Format("{0}", contentByteCount));
        doHeader("POST");
        Debug.Assert(reader != null);
        Debug.Assert(writer != null);
        writer.write(contentBytes, contentByteCount);
        writer.close();
        writer = null;
        handleReply(handler);
      }

    private Thread result_thread;

    private class ResultThread
      {
        private Fetch fetch;
        private FetchHandler handler;
        private HTTPRawReader reader;
        public Exception exception;
        public ResultThread(Fetch init_fetch, FetchHandler init_handler,
                            HTTPRawReader init_reader)
          {
            fetch = init_fetch;
            handler = init_handler;
            reader = init_reader;
            exception = null;
          }
        public void run()
          {
            if (handler == null)
                return;
            try
              {
                byte[] buffer = new byte[2560];
                while (true)
                  {
                    int actual = reader.read_bytes(buffer, 2560);
                    Debug.Assert(actual <= 2560);
                    if (actual <= 0)
                        break;
                    fetch.handle_incremental_bytes(actual, buffer);
                  }
              }
            catch (Exception e1)
              {
                exception = e1;
              }
          }
      };

    public void startPost(string method, FetchHandler handler)
      {
        incremental_handler = handler;
        setParameter("Transfer-Encoding", "chunked");
        doHeader(method);
        Debug.Assert(reader != null);
        Debug.Assert(writer != null);
        result_thread = new Thread(
                new ThreadStart(new ResultThread(this, handler, reader).run));
        result_thread.Start();
      }
    public void startPost(string method)
      {
        startPost(method, null);
      }
    public void startPost()
      {
        startPost("POST");
      }

    public void continuePost(int contentByteCount, byte[] contentBytes)
      {
        if (contentByteCount == 0)
            return;
        writer.write(string.Format("{0:x}\r\n", contentByteCount));
        writer.write(contentBytes, contentByteCount);
        writer.write("\r\n");
      }

    public FetchResult finishPost()
      {
        SimpleFetchResult result = new SimpleFetchResult();
        SimpleFetchHandler handler = new SimpleFetchHandler(result);
        finishPost(handler);
        return result;
      }

    public void finishPost(FetchHandler handler)
      {
        Debug.Assert((incremental_handler == null) ||
                     (incremental_handler == handler));
        writer.write("0\r\n\r\n");
        writer.close();
        writer = null;
        result_thread.Join();
        if (incremental_handler == null)
          {
            handleReply(handler);
          }
        else
          {
            incremental_handler.handleContentEnd();
            reader.close();
          }
      }

    public static FetchResult get(string url, string user_agent,
                                  double timeout_seconds, Method method)
      {
        Fetch fetch = new Fetch(url);
        if (user_agent != null)
            fetch.setUserAgent(user_agent);
        fetch.setTimeoutSeconds(timeout_seconds);
        return fetch.get(method);
      }
    public static FetchResult get(string url, string user_agent,
                                  double timeout_seconds)
      {
        return get(url, user_agent, timeout_seconds, Method.GET);
      }
    public static FetchResult get(string url, string user_agent)
      {
        return get(url, user_agent, default_timeout_seconds);
      }
    public static FetchResult get(string url)
      {
        return get(url, null);
      }

    public static void get(FetchHandler handler, string url, string user_agent,
                           double timeout_seconds, Method method)
      {
        Fetch fetch = new Fetch(url);
        if (user_agent != null)
            fetch.setUserAgent(user_agent);
        fetch.setTimeoutSeconds(timeout_seconds);
        fetch.get(handler, method);
      }
    public static void get(FetchHandler handler, string url, string user_agent,
                           double timeout_seconds)
      {
        get(handler, url, user_agent, timeout_seconds, Method.GET);
      }
    public static void get(FetchHandler handler, string url, string user_agent)
      {
        get(handler, url, user_agent, default_timeout_seconds);
      }
    public static void get(FetchHandler handler, string url)
      {
        get(handler, url, null);
      }

    public static FetchResult post(int contentByteCount, byte[] contentBytes,
            string url, string user_agent, double timeout_seconds)
      {
        Fetch fetch = new Fetch(url);
        if (user_agent != null)
            fetch.setUserAgent(user_agent);
        fetch.setTimeoutSeconds(timeout_seconds);
        return fetch.post(contentByteCount, contentBytes);
      }
    public static FetchResult post(int contentByteCount, byte[] contentBytes,
                                   string url, string user_agent)
      {
        return post(contentByteCount, contentBytes, url, user_agent,
                    default_timeout_seconds);
      }
    public static FetchResult post(int contentByteCount, byte[] contentBytes,
                                   string url)
      {
        return post(contentByteCount, contentBytes, url, null);
      }

    public static void post(int contentByteCount, byte[] contentBytes,
            FetchHandler handler, string url, string user_agent,
            double timeout_seconds)
      {
        Fetch fetch = new Fetch(url);
        if (user_agent != null)
            fetch.setUserAgent(user_agent);
        fetch.setTimeoutSeconds(timeout_seconds);
        fetch.post(contentByteCount, contentBytes, handler);
      }
    public static void post(int contentByteCount, byte[] contentBytes,
                            FetchHandler handler, string url, string user_agent)
      {
        post(contentByteCount, contentBytes, handler, url, user_agent,
             default_timeout_seconds);
      }
    public static void post(int contentByteCount, byte[] contentBytes,
                            FetchHandler handler, string url)
      {
        post(contentByteCount, contentBytes, handler, url, null);
      }

    public static HTTPRawWriter openRaw(string url, string method)
      {
        Fetch fetch = new Fetch(url);

        fetch.doPreHeader(method);
        Debug.Assert(fetch.reader != null);
        Debug.Assert(fetch.writer != null);

        URLInfo url_info = parseURL(url);

        fetch.writer.write(method);
        fetch.writer.write(" ");
        if (url_info.path_length == 0)
          {
            fetch.writer.write("/");
          }
        else
          {
            fetch.writer.write(
                    url.Substring(url_info.path_start, url_info.path_length));
          }
        fetch.writer.write(" HTTP/1.1\r\n");

        fetch.writer.write("Host: ");
        fetch.writer.write(
                url.Substring(url_info.host_start, url_info.host_length));
        fetch.writer.write("\r\n");

        return fetch.writer;
      }

    public class URLInfo
      {
        public int host_start;
        public int host_length;
        public int port;
        public int path_start;
        public int path_length;
        public bool is_ssl;
        public bool is_script;
      }
    public static URLInfo parseURL(string url)
      {
        Debug.Assert(url != null);

        URLInfo result = new URLInfo();
        int follow;
        if (url.StartsWith(http_prefix))
          {
            result.is_ssl = false;
            result.is_script = false;
            follow = http_prefix.Length;
          }
        else if (url.StartsWith(https_prefix))
          {
            result.is_ssl = true;
            result.is_script = false;
            follow = https_prefix.Length;
          }
        else if (url.StartsWith(script_prefix))
          {
            result.is_script = true;
            follow = script_prefix.Length;
          }
        else
          {
            throw new Exception("URL prefix not recognized.");
          }

        result.host_start = follow;
        while (true)
          {
            if (url.Length == follow)
              {
                result.host_length = follow - result.host_start;
                if (!result.is_script)
                    result.port = (result.is_ssl ? 443 : 80);
                result.path_start = follow;
                result.path_length = 0;
                return result;
              }
            if (url[follow] == ':')
              {
                result.host_length = follow - result.host_start;
                ++follow;
                int local_port = 0;
                while ((url.Length > follow) && (url[follow] != '/'))
                  {
                    char this_char = url[follow];
                    int digit;
                    if ((this_char >= '0') && (this_char <= '9'))
                        digit = this_char - '0';
                    else
                        throw new Exception("Bad URL: non-digit in port.");
                    if (local_port >= (((1 << 16) - digit) / 10))
                        throw new Exception("Overflow in port number.");
                    local_port = ((local_port * 10) + digit);
                    ++follow;
                  }
                result.port = local_port;
                break;
              }
            if ((url.Length > follow) && (url[follow] == '/'))
              {
                result.host_length = follow - result.host_start;
                if (!result.is_script)
                    result.port = (result.is_ssl ? 443 : 80);
                break;
              }
            ++follow;
          }

        result.path_start = follow;
        result.path_length = url.Length - follow;
        return result;
      }

    private static readonly double default_timeout_seconds = 10;

    private string url;
    private string user_agent;
    private HTTPRawWriter writer;
    private HTTPRawReader reader;
    private double timeout_seconds;
    private bool use_proxy;
    private string proxy_server;
    private int proxy_port;
    private string proxy_user_agent;
    private List<pair> proxy_parameters;
    private Dictionary<string, int> proxy_parameter_index;
    private FetchHandler incremental_handler;
    private enum incremental_state_type
      {
        IS_START,
        IS_HEADERS,
        IS_BODY,
        IS_CHUNK_COUNT
      };
    private incremental_state_type incremental_state;
    private byte[] incremental_buffer_data;
    private int incremental_buffer_used;
    private int chunk_count_remaining;

    private class pair
      {
        public string key;
        public string value;
      };
    private List<pair> parameters;
    private Dictionary<string, int> parameter_index;
    private static long save_file_counter = 0;

    private void doHeader(string method)
      {
        doPreHeader(method);
        Debug.Assert(reader != null);
        Debug.Assert(writer != null);

        URLInfo url_info = parseURL(url);

        writer.write(method);
        writer.write(" ");
        if (use_proxy && !(url_info.is_ssl))
          {
            writer.write(url.Substring(url_info.host_start,
                    (url_info.path_start - url_info.host_start) +
                    url_info.path_length));
          }
        else if (url_info.path_length == 0)
          {
            writer.write("/");
          }
        else
          {
            writer.write(
                    url.Substring(url_info.path_start, url_info.path_length));
          }
        writer.write(" HTTP/1.1\r\n");

        writer.write("Host: ");
        writer.write(url.Substring(url_info.host_start, url_info.host_length));
        writer.write("\r\n");

        writer.write(user_agent_key);
        writer.write(": ");
        writer.write(user_agent);
        writer.write("\r\n");

        int param_count = parameters.Count;
        for (int param_num = 0; param_num < param_count; ++param_num)
          {
            writer.write(parameters[param_num].key);
            writer.write(": ");
            writer.write(parameters[param_num].value);
            writer.write("\r\n");
          }

        writer.write("\r\n");
      }

    private class FetchStreamWriter : HTTPRawWriter
      {
        private Stream stream;
        private HTTPRawReader reader;

        public FetchStreamWriter(Stream init_stream, HTTPRawReader init_reader)
          {
            stream = init_stream;
            reader = init_reader;
            Debug.Assert(reader != null);
          }

        public override void write(string to_write)
          {
            byte[] bytes = Encoding.UTF8.GetBytes(to_write);
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();
          }
        public override void write(byte[] to_write, int byte_count)
          {
            stream.Write(to_write, 0, byte_count);
            stream.Flush();
          }
        public override int read(byte[] buffer, int byte_count)
          {
            return reader.read_bytes(buffer, byte_count);
          }
        public override void close()
          {
          }
      };

    private class ScriptReader : HTTPStreamReader
      {
        private Process child;

        public ScriptReader(Process init_child) :
                base(init_child.StandardOutput.BaseStream)
          {
            child = init_child;
          }

        public override void check_for_errors()
          {
            child.WaitForExit();
            if (child.ExitCode != 0)
              {
                int script_status = child.ExitCode;
                error("Script died with exit status {0}.", script_status);
              }
          }
      };

    private void doPreHeader(string method)
      {
        if (!(FetchEnable.fetches_are_enabled()))
          {
            Console.Error.Write(
                    "ERROR: An attempt was made to hit an external API " +
                    "(URL {0}) while such hits were disabled because {1}.\n",
                    url, FetchEnable.fetch_disable_reason());
            Environment.Exit(1);
          }

        URLInfo url_info = parseURL(url);

        if (url_info.is_script)
          {
            int token_count = 1;
            int follow = url_info.host_start;
            while (follow < url_info.path_start + url_info.path_length)
              {
                if (((url[follow] == ' ') || (url[follow] == '@')) &&
                    ((follow == url.Length) || (url[follow + 1] != ' ') ||
                     (url[follow + 1] != '@')))
                  {
                    ++token_count;
                  }
                ++follow;
              }
            string file_name = "";
            string arguments = "";
            int start = url_info.host_start;
            int arg_num = 1;
            int follow_buffer = start;
            while (follow_buffer <
                   (url_info.path_start + url_info.path_length))
              {
                if ((url[follow_buffer] == ' ') || (url[follow_buffer] == '@'))
                  {
                    string this_arg =
                            url.Substring(start, follow_buffer - start);
                    if (arg_num == 1)
                      {
                        file_name = this_arg;
                      }
                    else if (arg_num == 2)
                      {
                        arguments = this_arg;
                      }
                    else
                      {
                        arguments += " ";
                        arguments += this_arg;
                      }
                    if ((follow_buffer == url.Length) ||
                        (url[follow_buffer + 1] != ' ') ||
                        (url[follow_buffer + 1] != '@'))
                      {
                        start = follow_buffer + 1;
                        ++arg_num;
                      }
                  }
                ++follow_buffer;
              }
            Debug.Assert(arg_num == token_count);
            string final_arg = url.Substring(start, follow_buffer - start);
            if (arg_num == 1)
              {
                file_name = final_arg;
              }
            else if (arg_num == 2)
              {
                arguments = final_arg;
              }
            else
              {
                arguments += " ";
                arguments += final_arg;
              }

            Process child = new Process
              {
                StartInfo = new ProcessStartInfo
                  {
                    FileName = file_name,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                  }
              };
            child.Start();
            reader = new ScriptReader(child);

            writer = new FetchStreamWriter(child.StandardInput.BaseStream,
                                           reader);

            doSaveResponsesSetup();

            return;
          }

        if (Environment.GetEnvironmentVariable(
                    "GOLDEN_RETRIEVER_SHOW_REAL_URL_HITS") != null)
          {
            Console.Error.Write("Golden Retriever hitting `{0}'.\n", url);
          }

        string final_hostname =
                url.Substring(url_info.host_start, url_info.host_length);
        string hostname = (use_proxy ? proxy_server : final_hostname);
        int port_to_use = (use_proxy ? proxy_port : url_info.port);

        NetworkStream stream = new TcpClient(hostname, port_to_use).GetStream();
        if (url_info.is_ssl)
          {
            if (use_proxy)
              {
                HTTPStreamReader proxy_reader = new HTTPStreamReader(stream, 1);
                FetchStreamWriter proxy_writer =
                        new FetchStreamWriter(stream, proxy_reader);
                proxy_writer.write("CONNECT ");
                proxy_writer.write(final_hostname);
                proxy_writer.write(":" + url_info.port);
                proxy_writer.write(" HTTP/1.1\r\n");
                proxy_writer.write(user_agent_key);
                proxy_writer.write(": ");
                proxy_writer.write(
                        (proxy_user_agent != null) ? proxy_user_agent :
                         user_agent);
                proxy_writer.write("\r\n");
                int param_count = proxy_parameters.Count;
                for (int param_num = 0; param_num < param_count; ++param_num)
                  {
                    proxy_writer.write(proxy_parameters[param_num].key);
                    proxy_writer.write(": ");
                    proxy_writer.write(proxy_parameters[param_num].value);
                    proxy_writer.write("\r\n");
                  }
                proxy_writer.write("\r\n");

                string first_line = proxy_reader.readLine();
                string[] first_components = first_line.Split(new Char[]{' '});
                if (first_components.Length < 3)
                  {
                    throw new Exception(
                            "Bad first line from proxy server: `" + first_line +
                            "'.");
                  }
                if (!(first_components[1].Equals("200")))
                  {
                    string message = "Proxy returned status code ";
                    message += first_components[1];
                    message += ":";
                    for (int num = 2; num < first_components.Length; ++num)
                        message += " " + first_components[num];
                    message += ".";
                    throw new Exception(message);
                  }

                while (true)
                  {
                    string next_line = proxy_reader.readLine();
                    if (next_line.Equals("") || next_line.Equals("\r"))
                        break;
                  }
              }
            SslStream ssl_stream = new SslStream(stream);
            ssl_stream.AuthenticateAsClient(final_hostname);
            reader = new HTTPStreamReader(ssl_stream);
            writer =
                    new FetchStreamWriter(ssl_stream, reader);
          }
        else
          {
            reader = new HTTPStreamReader(stream);
            writer = new FetchStreamWriter(stream, reader);
          }

        doSaveResponsesSetup();
      }

    private class SaveReader : HTTPRawReader
      {
        private HTTPRawReader next;
        private FileStream save_stream;
        private StreamWriter save_writer;

        public SaveReader(HTTPRawReader init_next, string url)
          {
            Debug.Assert(init_next != null);
            Debug.Assert(url != null);

            next = init_next;

            string prefix = Environment.GetEnvironmentVariable(
                    "GOLDEN_RETRIEVER_SAVE_PREFIX");
            ++save_file_counter;
            string save_file_name =
                    prefix + DateTime.UtcNow.ToString("_yyyy_MM_dd_HH_mm_ss") +
                    string.Format("_{0:4}.txt", save_file_counter);
            try
              {
                save_stream = new FileStream(save_file_name, FileMode.Create);
                save_writer = new StreamWriter(save_stream);
              }
            catch (Exception e1)
              {
                Console.Error.Write(
                        "Warning: Failed trying to open save file {0}: {1}.\n",
                        save_file_name, e1.Message);
                save_stream = null;
              }
            try
              {
                FileStream catalog_stream = new FileStream(
                        Environment.GetEnvironmentVariable(
                                "GOLDEN_RETRIEVER_SAVE_CATALOG"),
                        FileMode.Create);
                new StreamWriter(catalog_stream).Write(
                        "  [\"{0}\", \"{1}\"],\n", url, save_file_name);
                catalog_stream.Close();
              }
            catch (Exception e1)
              {
                Console.Error.Write(
                        "Warning: Failed trying to open save catalog file " +
                        "{0}: {1}.\n",
                        Environment.GetEnvironmentVariable(
                                "GOLDEN_RETRIEVER_SAVE_CATALOG"), e1.Message);
              }
          }

        public string readLine()
          {
            string result = next.readLine();
            if (save_writer != null)
                save_writer.Write("{0}\n", result);
            return result;
          }
        public int read_bytes(byte[] buffer, int byte_count)
          {
            int result = next.read_bytes(buffer, byte_count);
            if ((save_stream != null) && (result > 0))
                save_stream.Write(buffer, 0, result);
            return result;
          }
        public void check_for_errors()
          {
            next.check_for_errors();
          }
        public void close()
          {
            next.close();
            if (save_stream != null)
              {
                save_stream.Close();
                save_stream = null;
              }
          }
      };

    private void doSaveResponsesSetup()
      {
        Debug.Assert(reader != null);

        if ((Environment.GetEnvironmentVariable(
                     "GOLDEN_RETRIEVER_SAVE_PREFIX") != null) &&
            (Environment.GetEnvironmentVariable(
                     "GOLDEN_RETRIEVER_SAVE_CATALOG") != null))
          {
            reader = new SaveReader(reader, url);
          }
      }

    private void handleReply(FetchHandler handler)
      {
        Debug.Assert(reader != null);

        handle_first_line(reader.readLine(), handler);
        golden_retriever.handleParametersAndBody(handler, reader);
        reader.close();
      }

    private void handle_content(byte[] data, int start_index, int byte_count)
      {
        if (start_index == 0)
          {
            incremental_handler.handleContent(byte_count, data);
          }
        else
          {
            byte[] sub_array = new byte[byte_count];
            Array.Copy(data, start_index, sub_array, 0, byte_count);
            incremental_handler.handleContent(byte_count, sub_array);
          }
      }

    public void handle_incremental_bytes(int count, byte[] data)
      {
        Debug.Assert(incremental_handler != null);

        int count_left = count;
        int data_left = 0;
        while (count_left > 0)
          {
            switch (incremental_state)
              {
                case incremental_state_type.IS_START:
                  {
                    goto case incremental_state_type.IS_HEADERS;
                  }
                case incremental_state_type.IS_HEADERS:
                  {
                    int follow = data_left;
                    int remainder = count_left;
                    while ((remainder > 0) && (data[follow] != '\n'))
                      {
                        ++follow;
                        --remainder;
                      }
                    if (remainder > 0)
                      {
                        int line_count;
                        byte[] line_bytes;
                        int line_start;
                        string line;
                        if (incremental_buffer_used > 0)
                          {
                            int new_count =
                                    incremental_buffer_used +
                                    (count_left - remainder);
                            if (new_count > incremental_buffer_data.Length)
                              {
                                byte[] new_buffer =
                                        new byte[(new_count * 2) + 3];
                                Array.Copy(incremental_buffer_data, 0,
                                        new_buffer, 0, incremental_buffer_used);
                                incremental_buffer_data = new_buffer;
                              }
                            Debug.Assert(new_count <=
                                         incremental_buffer_data.Length);
                            Array.Copy(data, data_left, incremental_buffer_data,
                                    incremental_buffer_used,
                                    (count_left - remainder));
                            incremental_buffer_used += (count_left - remainder);
                            line_count = incremental_buffer_used;
                            line_bytes = incremental_buffer_data;
                            line_start = 0;
                            incremental_buffer_used = 0;
                          }
                        else
                          {
                            line_count = follow - data_left;
                            line_bytes = data;
                            line_start = data_left;
                          }
                        if ((line_count > 0) &&
                            (line_bytes[line_start + (line_count - 1)] == '\r'))
                          {
                            --line_count;
                          }
                        line = Encoding.UTF8.GetString(line_bytes, line_start,
                                                       line_count);
                        if (line_count == 0)
                          {
                            incremental_handler.handleHeaderDone();
                            if (golden_retriever.chunked)
                              {
                                chunk_count_remaining = 0;
                                incremental_state =
                                        incremental_state_type.IS_CHUNK_COUNT;
                              }
                            else
                              {
                                incremental_state =
                                        incremental_state_type.IS_BODY;
                              }
                          }
                        else if (incremental_state ==
                                 incremental_state_type.IS_START)
                          {
                            handle_first_line(line, incremental_handler);
                            incremental_state =
                                    incremental_state_type.IS_HEADERS;
                          }
                        else
                          {
                            golden_retriever.handle_header_line(line,
                                    incremental_handler);
                          }
                        data_left = follow + 1;
                        count_left = remainder - 1;
                        continue;
                      }

                    if (incremental_buffer_used + count_left >
                        incremental_buffer_data.Length)
                      {
                        byte[] new_buffer = new byte[
                                ((incremental_buffer_used + count_left) * 2) +
                                3];
                        Array.Copy(incremental_buffer_data, 0, new_buffer, 0,
                                   incremental_buffer_used);
                        incremental_buffer_data = new_buffer;
                      }
                    Debug.Assert(incremental_buffer_used + count_left <=
                                 incremental_buffer_data.Length);
                    Array.Copy(data, data_left, incremental_buffer_data,
                               incremental_buffer_used, count_left);
                    incremental_buffer_used += count_left;
                    return;
                  }
                case incremental_state_type.IS_BODY:
                  {
                    if (!golden_retriever.chunked)
                      {
                        handle_content(data, data_left, count_left);
                        return;
                      }
                    if (chunk_count_remaining > count_left)
                      {
                        chunk_count_remaining -= count_left;
                        handle_content(data, data_left, count_left);
                        return;
                      }
                    handle_content(data, data_left, chunk_count_remaining);
                    data_left += chunk_count_remaining;
                    count_left -= chunk_count_remaining;
                    chunk_count_remaining = 0;
                    incremental_state = incremental_state_type.IS_CHUNK_COUNT;
                    continue;
                  }
                case incremental_state_type.IS_CHUNK_COUNT:
                  {
                    Debug.Assert(golden_retriever.chunked);
                    switch (data[data_left])
                      {
                        case (byte)'\n':
                            incremental_state = incremental_state_type.IS_BODY;
                            break;
                        case (byte)'0':
                            goto case (byte)'9';
                        case (byte)'1':
                            goto case (byte)'9';
                        case (byte)'2':
                            goto case (byte)'9';
                        case (byte)'3':
                            goto case (byte)'9';
                        case (byte)'4':
                            goto case (byte)'9';
                        case (byte)'5':
                            goto case (byte)'9';
                        case (byte)'6':
                            goto case (byte)'9';
                        case (byte)'7':
                            goto case (byte)'9';
                        case (byte)'8':
                            goto case (byte)'9';
                        case (byte)'9':
                            chunk_count_remaining *= 16;
                            chunk_count_remaining += data[data_left] - '0';
                            break;
                        case (byte)'a':
                            goto case (byte)'f';
                        case (byte)'b':
                            goto case (byte)'f';
                        case (byte)'c':
                            goto case (byte)'f';
                        case (byte)'d':
                            goto case (byte)'f';
                        case (byte)'e':
                            goto case (byte)'f';
                        case (byte)'f':
                            chunk_count_remaining *= 16;
                            chunk_count_remaining +=
                                    (data[data_left] - 'a') + 0xa;
                            break;
                        case (byte)'A':
                            goto case (byte)'F';
                        case (byte)'B':
                            goto case (byte)'F';
                        case (byte)'C':
                            goto case (byte)'F';
                        case (byte)'D':
                            goto case (byte)'F';
                        case (byte)'E':
                            goto case (byte)'F';
                        case (byte)'F':
                            chunk_count_remaining *= 16;
                            chunk_count_remaining +=
                                    (data[data_left] - 'A') + 0xa;
                            break;
                        default:
                            break;
                      }
                    ++data_left;
                    --count_left;
                    continue;
                  }
                default:
                  {
                    Debug.Assert(false);
                    break;
                  }
              }
          }
      }

    private void handle_first_line(string first_line, FetchHandler handler)
      {
        int follow = 0;
        while ((follow >= first_line.Length) || (first_line[follow] != ' '))
          {
            if (follow >= first_line.Length)
              {
                reader.check_for_errors();
                error("Bad first line in response: {0}.", first_line);
              }
            ++follow;
          }
        handler.handleHTTPVersion(first_line.Substring(0, follow));
        ++follow;
        int code = 0;
        for (int num = 0; num < 3; ++num)
          {
            if ((follow >= first_line.Length) || (first_line[follow] < '0') ||
                (first_line[follow] > '9'))
              {
                throw new Exception("Bad first line in response.");
              }
            code = ((code * 10) + (first_line[follow] - '0'));
            ++follow;
          }
        handler.handleStatusCode(code);
        golden_retriever.have_content_length = (code == 204);
        if ((follow >= first_line.Length) || (first_line[follow] != ' '))
            throw new Exception("Bad first line in response.");
        ++follow;
        handler.handleReasonPhrase(first_line.Substring(follow));
      }

    private class SimpleFetchResult : FetchResult
      {
        private int status_code;
        private string reason_phrase;
        private string http_version;
        private List<pair> parameters;
        private Dictionary<string, int> parameter_index;
        private MemoryStream content_stream;
        private byte[] content_array;
        private int content_position;

        public SimpleFetchResult()
          {
            status_code = 0;
            reason_phrase = null;
            http_version = null;
            parameters = new List<pair>();
            parameter_index = new Dictionary<string, int>();
            content_stream = new MemoryStream();
            content_position = 0;
          }

        public int statusCode()  { return status_code; }
        public string reasonPhrase()  { return reason_phrase; }
        public string httpVersion()  { return http_version; }
        public int parameterCount()  { return parameters.Count; }
        public string parameterKey(int paramNum)
          {
            Debug.Assert(paramNum < parameters.Count);
            return parameters[paramNum].key;
          }
        public string parameterValue(int paramNum)
          {
            Debug.Assert(paramNum < parameters.Count);
            return parameters[paramNum].value;
          }
        public string parameterLookup(string key)
          {
            if (!(parameter_index.ContainsKey(key)))
                return null;
            int index = parameter_index[key];
            Debug.Assert(index < parameters.Count);
            Debug.Assert(parameters[index].key.Equals(key));
            return parameters[index].value;
          }
        public byte[] contentBytes()  { return content_array; }
        public int readContent(byte[] buffer, int minBytes, int maxBytes)
          {
            if (content_position + minBytes > content_array.Length)
              {
                throw new Exception(
                        "An attempt was made to read beyond the end of the " +
                        "FetchResult content.");
              }
            int result =
                    ((content_position + maxBytes <= content_array.Length) ?
                     maxBytes : content_array.Length - content_position);
            if (result > 0)
              {
                Array.Copy(content_array, content_position, buffer, 0, result);
                content_position += result;
              }
            return result;
          }
        public bool contentDone()
          { return content_position == content_array.Length; }

        public void setStatusCode(int new_status_code)
          { status_code = new_status_code; }
        public void setReasonPhrase(string new_reason_phrase)
          {
            reason_phrase = new_reason_phrase;
          }
        public void setHTTPVersion(string new_http_version)
          {
            http_version = new_http_version;
          }
        public void setParameter(string key, string value)
          {
            Debug.Assert(key != null);
            Debug.Assert(value != null);

            if (parameter_index.ContainsKey(key))
              {
                int existing_index = parameter_index[key];
                Debug.Assert(existing_index < parameters.Count);
                parameters[existing_index].value = value;
                return;
              }

            int index = parameters.Count;
            pair new_element = new pair();
            new_element.key = key;
            new_element.value = value;
            parameters.Add(new_element);
            parameter_index.Add(key, index);
          }
        public void makeContentSpace(int byte_count)
          { content_stream = new MemoryStream(byte_count); }
        public void addContent(int byte_count, byte[] bytes)
          {
            content_stream.Write(bytes, 0, byte_count);
          }
        public void finalizeContent()
          {
            content_array = content_stream.ToArray();
          }
      };

    private class SimpleFetchHandler : FetchHandler
      {
        public SimpleFetchHandler(SimpleFetchResult init_result)
          {
            result = init_result;
          }

        public override void handleStatusCode(int code)
          { result.setStatusCode(code); }
        public override void handleReasonPhrase(string message)
          { result.setReasonPhrase(message); }
        public override void handleHTTPVersion(string version)
          { result.setHTTPVersion(version); }
        public override void handleParameter(string key, string value)
          { result.setParameter(key, value); }
        public override void handleContentByteCount(int byteCount)
          { result.makeContentSpace(byteCount); }
        public override void handleContent(int byteCount, byte[] bytes)
          { result.addContent(byteCount, bytes); }
        public override void handleContentEnd()  { result.finalizeContent(); }

        private SimpleFetchResult result;
      };
  };
