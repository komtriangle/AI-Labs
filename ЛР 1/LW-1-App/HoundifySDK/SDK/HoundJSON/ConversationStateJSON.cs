/* file "ConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ConversationStateJSON : JSONBase
  {
    private string contents;
    public ConversationStateJSON()
      {
      }
    public override void write_as_json(JSONHandler handler)
      {
        JSONParse.parse_json_value(contents, "Compact Representation of ConversationStateJSON", handler);
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        JSONParse.parse_json_value(contents, "Compact Representation of ConversationStateJSON", handler);
      }
    public static ConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ConversationStateJSON result = new ConversationStateJSON();
        StringWriter stream = new StringWriter();
        JSONStreamWriter writer = new JSONStreamWriter(stream, JSONWriter.whitespace_style.WHITESPACE_NONE);
        json_value.write(writer);
        result.contents = stream.ToString();
        return result;
      }
    public static ConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
    public static ConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ConversationStateJSON result = new ConversationStateJSON();
        StringWriter stream = new StringWriter();
        JSONStreamWriter writer = new JSONStreamWriter(stream, JSONWriter.whitespace_style.WHITESPACE_NONE);
        if (allow_incomplete || allow_unpolished)
            json_value.write_partial_as_json(writer);
        else
            json_value.write_as_json(writer);
        result.contents = stream.ToString();
        return result;
      }
    public static ConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
    public static ConversationStateJSON from_text(string text, bool ignore_extras)
      {
        ConversationStateJSON result = new ConversationStateJSON();
        StringWriter stream = new StringWriter();
        JSONStreamWriter writer = new JSONStreamWriter(stream, JSONWriter.whitespace_style.WHITESPACE_NONE);
        JSONParse.parse_json_value(text, "Text for ConversationStateJSON", writer);
        result.contents = stream.ToString();
        return result;
      }
    public static ConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ConversationStateJSON result = new ConversationStateJSON();
        StringWriter stream = new StringWriter();
        JSONStreamWriter writer = new JSONStreamWriter(stream, JSONWriter.whitespace_style.WHITESPACE_NONE);
        JSONParse.parse_json_value(fp, file_name, writer);
        result.contents = stream.ToString();
        return result;
      }
    public abstract class Generator : JSONWriter
      {
        protected Generator(bool ignore_extras) : base(JSONWriter.whitespace_style.WHITESPACE_NONE)
          {
            result = new ConversationStateJSON();
          }
        protected override void send_raw_text(string text)
          {
            result.contents += text;
            handle_result(result);
          }
        protected virtual string get_what()
          {
            return "value of type ConversationStateJSON";
          }
        protected abstract void handle_result(ConversationStateJSON new_result);
        public ConversationStateJSON result;
        public void set_what(string what)
          {
          }
        public override void reset()
          {
            result = new ConversationStateJSON();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ConversationStateJSON  result)
          {
//@@@            Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public HoldingGenerator(String what, bool ignore_extras) : base(ignore_extras)
          {
            have_value = false;
            base.set_what(what);
          }

        public HoldingGenerator(String what) : base(false)
          {
            have_value = false;
            base.set_what(what);
          }

        public override void reset()
          {
            have_value = false;
            base.reset();
          }

        public bool have_value;
        public ConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ConversationStateJSON  result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(HoldingArrayGenerator init_top, bool ignore_extras) : base(ignore_extras)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<ConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ConversationStateJSON>();
        have_value = false;
      }

    public void set_allow_incomplete(bool new_allow_incomplete)
      {
        element_handler.set_allow_incomplete(new_allow_incomplete);
      }

    public void set_allow_unpolished(bool new_allow_unpolished)
      {
        element_handler.set_allow_unpolished(new_allow_unpolished);
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<ConversationStateJSON> value;
  };
  };
