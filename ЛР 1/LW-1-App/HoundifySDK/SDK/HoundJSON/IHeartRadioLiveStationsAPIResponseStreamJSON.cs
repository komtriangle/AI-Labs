/* file "IHeartRadioLiveStationsAPIResponseStreamJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class IHeartRadioLiveStationsAPIResponseStreamJSON : JSONBase
  {
    private bool flagHashls_stream;
    private string storehls_stream;
    private bool flagHasshoutcast_stream;
    private string storeshoutcast_stream;
    private bool flagHaspls_stream;
    private string storepls_stream;
    private bool flagHassecure_hls_stream;
    private string storesecure_hls_stream;
    private bool flagHassecure_shoutcast_stream;
    private string storesecure_shoutcast_stream;
    private bool flagHassecure_pls_stream;
    private string storesecure_pls_stream;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONhls_stream(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field hls_stream of IHeartRadioLiveStationsAPIResponseStreamJSON is not a string.");
        sethls_stream(json_string.getData());
      }


    private void  fromJSONshoutcast_stream(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field shoutcast_stream of IHeartRadioLiveStationsAPIResponseStreamJSON is not a string.");
        setshoutcast_stream(json_string.getData());
      }


    private void  fromJSONpls_stream(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field pls_stream of IHeartRadioLiveStationsAPIResponseStreamJSON is not a string.");
        setpls_stream(json_string.getData());
      }


    private void  fromJSONsecure_hls_stream(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field secure_hls_stream of IHeartRadioLiveStationsAPIResponseStreamJSON is not a string.");
        setsecure_hls_stream(json_string.getData());
      }


    private void  fromJSONsecure_shoutcast_stream(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field secure_shoutcast_stream of IHeartRadioLiveStationsAPIResponseStreamJSON is not a string.");
        setsecure_shoutcast_stream(json_string.getData());
      }


    private void  fromJSONsecure_pls_stream(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field secure_pls_stream of IHeartRadioLiveStationsAPIResponseStreamJSON is not a string.");
        setsecure_pls_stream(json_string.getData());
      }


    public IHeartRadioLiveStationsAPIResponseStreamJSON()
      {
        flagHashls_stream = false;
        flagHasshoutcast_stream = false;
        flagHaspls_stream = false;
        flagHassecure_hls_stream = false;
        flagHassecure_shoutcast_stream = false;
        flagHassecure_pls_stream = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hashls_stream()
      {
        return flagHashls_stream;
      }

    public string  gethls_stream()
      {
        Debug.Assert(flagHashls_stream);
        return storehls_stream;
      }

    public bool  hasshoutcast_stream()
      {
        return flagHasshoutcast_stream;
      }

    public string  getshoutcast_stream()
      {
        Debug.Assert(flagHasshoutcast_stream);
        return storeshoutcast_stream;
      }

    public bool  haspls_stream()
      {
        return flagHaspls_stream;
      }

    public string  getpls_stream()
      {
        Debug.Assert(flagHaspls_stream);
        return storepls_stream;
      }

    public bool  hassecure_hls_stream()
      {
        return flagHassecure_hls_stream;
      }

    public string  getsecure_hls_stream()
      {
        Debug.Assert(flagHassecure_hls_stream);
        return storesecure_hls_stream;
      }

    public bool  hassecure_shoutcast_stream()
      {
        return flagHassecure_shoutcast_stream;
      }

    public string  getsecure_shoutcast_stream()
      {
        Debug.Assert(flagHassecure_shoutcast_stream);
        return storesecure_shoutcast_stream;
      }

    public bool  hassecure_pls_stream()
      {
        return flagHassecure_pls_stream;
      }

    public string  getsecure_pls_stream()
      {
        Debug.Assert(flagHassecure_pls_stream);
        return storesecure_pls_stream;
      }


    public virtual int extraIHeartRadioLiveStationsAPIResponseStreamComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioLiveStationsAPIResponseStreamComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioLiveStationsAPIResponseStreamComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioLiveStationsAPIResponseStreamLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void sethls_stream(string new_value)
      {
        flagHashls_stream = true;
        storehls_stream = new_value;
      }
    public void unsethls_stream()
      {
        flagHashls_stream = false;
      }
    public void setshoutcast_stream(string new_value)
      {
        flagHasshoutcast_stream = true;
        storeshoutcast_stream = new_value;
      }
    public void unsetshoutcast_stream()
      {
        flagHasshoutcast_stream = false;
      }
    public void setpls_stream(string new_value)
      {
        flagHaspls_stream = true;
        storepls_stream = new_value;
      }
    public void unsetpls_stream()
      {
        flagHaspls_stream = false;
      }
    public void setsecure_hls_stream(string new_value)
      {
        flagHassecure_hls_stream = true;
        storesecure_hls_stream = new_value;
      }
    public void unsetsecure_hls_stream()
      {
        flagHassecure_hls_stream = false;
      }
    public void setsecure_shoutcast_stream(string new_value)
      {
        flagHassecure_shoutcast_stream = true;
        storesecure_shoutcast_stream = new_value;
      }
    public void unsetsecure_shoutcast_stream()
      {
        flagHassecure_shoutcast_stream = false;
      }
    public void setsecure_pls_stream(string new_value)
      {
        flagHassecure_pls_stream = true;
        storesecure_pls_stream = new_value;
      }
    public void unsetsecure_pls_stream()
      {
        flagHassecure_pls_stream = false;
      }

    public virtual void extraIHeartRadioLiveStationsAPIResponseStreamAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioLiveStationsAPIResponseStreamSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioLiveStationsAPIResponseStreamLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioLiveStationsAPIResponseStreamAppendPair(key, new_component);
          }
        else
          {
            int count = extraKeys.Count;
            Debug.Assert(count == extraValues.Count);
            for (int num = 0; num < count; ++num)
              {
                if (extraKeys[num].Equals( key))
                  {
                    extraValues[num] = new_component;
                    break;
                  }
              }
            extraIndex.Add(key, new_component);
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        if (flagHashls_stream)
          {
            handler.start_pair("hls_stream");
            handler.string_value(storehls_stream);
          }
        if (flagHasshoutcast_stream)
          {
            handler.start_pair("shoutcast_stream");
            handler.string_value(storeshoutcast_stream);
          }
        if (flagHaspls_stream)
          {
            handler.start_pair("pls_stream");
            handler.string_value(storepls_stream);
          }
        if (flagHassecure_hls_stream)
          {
            handler.start_pair("secure_hls_stream");
            handler.string_value(storesecure_hls_stream);
          }
        if (flagHassecure_shoutcast_stream)
          {
            handler.start_pair("secure_shoutcast_stream");
            handler.string_value(storesecure_shoutcast_stream);
          }
        if (flagHassecure_pls_stream)
          {
            handler.start_pair("secure_pls_stream");
            handler.string_value(storesecure_pls_stream);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static IHeartRadioLiveStationsAPIResponseStreamJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioLiveStationsAPIResponseStreamJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioLiveStationsAPIResponseStream", ignore_extras);
            generator.set_allow_incomplete(allow_incomplete);
            generator.set_allow_unpolished(allow_unpolished);
            if (allow_incomplete || allow_unpolished)
                json_value.write(generator);
            else
                json_value.write(generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioLiveStationsAPIResponseStreamJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioLiveStationsAPIResponseStreamJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioLiveStationsAPIResponseStreamJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioLiveStationsAPIResponseStream", ignore_extras);
            generator.set_allow_incomplete(allow_incomplete);
            generator.set_allow_unpolished(allow_unpolished);
            if (allow_incomplete || allow_unpolished)
                json_value.write_partial_as_json(generator);
            else
                json_value.write_as_json(generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioLiveStationsAPIResponseStreamJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioLiveStationsAPIResponseStreamJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioLiveStationsAPIResponseStreamJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioLiveStationsAPIResponseStream", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioLiveStationsAPIResponseStreamJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioLiveStationsAPIResponseStreamJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioLiveStationsAPIResponseStreamJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioLiveStationsAPIResponseStream", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorhls_stream;
        private JSONHoldingStringGenerator fieldGeneratorshoutcast_stream;
        private JSONHoldingStringGenerator fieldGeneratorpls_stream;
        private JSONHoldingStringGenerator fieldGeneratorsecure_hls_stream;
        private JSONHoldingStringGenerator fieldGeneratorsecure_shoutcast_stream;
        private JSONHoldingStringGenerator fieldGeneratorsecure_pls_stream;
        private class UnknownFieldGenerator : JSONValueHandler
          {
            public bool ignore;
            public List<string> field_names;
            public List<JSONValue > field_values;
            public Dictionary<string, JSONValue > index;
            public UnknownFieldGenerator(bool init_ignore)
              {
                ignore = init_ignore;
                field_names = new List<string>();
                field_values = new List<JSONValue >();
            index = new Dictionary<string, JSONValue >();
              }

            protected override void new_value(JSONValue item)
              {
                if (ignore)
                    return;
                Debug.Assert(field_names.Count == (field_values.Count + 1));
                index.Add(field_names[field_values.Count], item);
                field_values.Add(item);
              }
            public override void reset()
              {
                field_names.Clear();
                field_values.Clear();
            index = new Dictionary<string, JSONValue >();
              }
          };
        private UnknownFieldGenerator unknownFieldGenerator;

        protected bool allow_incomplete;

        protected bool allow_unpolished;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            Debug.Assert(unknownFieldGenerator.field_names.Count ==
                   unknownFieldGenerator.field_values.Count);
            if (unknownFieldGenerator.ignore)
              {
                Debug.Assert(unknownFieldGenerator.field_names.Count == 0);
              }
            else
              {
                unknownFieldGenerator.field_names.Add(field_name);
              }
            return unknownFieldGenerator;
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            IHeartRadioLiveStationsAPIResponseStreamJSON result = new IHeartRadioLiveStationsAPIResponseStreamJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioLiveStationsAPIResponseStreamAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioLiveStationsAPIResponseStreamJSON result)
          {
            if (fieldGeneratorhls_stream.have_value)
              {
                result.sethls_stream(fieldGeneratorhls_stream.value);
                fieldGeneratorhls_stream.have_value = false;
              }
            if (fieldGeneratorshoutcast_stream.have_value)
              {
                result.setshoutcast_stream(fieldGeneratorshoutcast_stream.value);
                fieldGeneratorshoutcast_stream.have_value = false;
              }
            if (fieldGeneratorpls_stream.have_value)
              {
                result.setpls_stream(fieldGeneratorpls_stream.value);
                fieldGeneratorpls_stream.have_value = false;
              }
            if (fieldGeneratorsecure_hls_stream.have_value)
              {
                result.setsecure_hls_stream(fieldGeneratorsecure_hls_stream.value);
                fieldGeneratorsecure_hls_stream.have_value = false;
              }
            if (fieldGeneratorsecure_shoutcast_stream.have_value)
              {
                result.setsecure_shoutcast_stream(fieldGeneratorsecure_shoutcast_stream.value);
                fieldGeneratorsecure_shoutcast_stream.have_value = false;
              }
            if (fieldGeneratorsecure_pls_stream.have_value)
              {
                result.setsecure_pls_stream(fieldGeneratorsecure_pls_stream.value);
                fieldGeneratorsecure_pls_stream.have_value = false;
              }
          }
        protected abstract void handle_result(IHeartRadioLiveStationsAPIResponseStreamJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'h':
                    if ((String.Compare(field_name, 1, "ls_stream", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorhls_stream;
                    break;
                case 'p':
                    if ((String.Compare(field_name, 1, "ls_stream", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorpls_stream;
                    break;
                case 's':
                    switch (field_name[1])
                      {
                        case 'e':
                            if (String.Compare(field_name, 2, "cure_", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'h':
                                        if ((String.Compare(field_name, 8, "ls_stream", 0, 9, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorsecure_hls_stream;
                                        break;
                                    case 'p':
                                        if ((String.Compare(field_name, 8, "ls_stream", 0, 9, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorsecure_pls_stream;
                                        break;
                                    case 's':
                                        if ((String.Compare(field_name, 8, "houtcast_stream", 0, 15, false) == 0) && (field_name.Length == 23))
                                            return fieldGeneratorsecure_shoutcast_stream;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'h':
                            if ((String.Compare(field_name, 2, "outcast_stream", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorshoutcast_stream;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorhls_stream = new JSONHoldingStringGenerator("field \"hls_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            fieldGeneratorshoutcast_stream = new JSONHoldingStringGenerator("field \"shoutcast_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            fieldGeneratorpls_stream = new JSONHoldingStringGenerator("field \"pls_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            fieldGeneratorsecure_hls_stream = new JSONHoldingStringGenerator("field \"secure_hls_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            fieldGeneratorsecure_shoutcast_stream = new JSONHoldingStringGenerator("field \"secure_shoutcast_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            fieldGeneratorsecure_pls_stream = new JSONHoldingStringGenerator("field \"secure_pls_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioLiveStationsAPIResponseStream class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorhls_stream = new JSONHoldingStringGenerator("field \"hls_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            fieldGeneratorshoutcast_stream = new JSONHoldingStringGenerator("field \"shoutcast_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            fieldGeneratorpls_stream = new JSONHoldingStringGenerator("field \"pls_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            fieldGeneratorsecure_hls_stream = new JSONHoldingStringGenerator("field \"secure_hls_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            fieldGeneratorsecure_shoutcast_stream = new JSONHoldingStringGenerator("field \"secure_shoutcast_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            fieldGeneratorsecure_pls_stream = new JSONHoldingStringGenerator("field \"secure_pls_stream\" of the IHeartRadioLiveStationsAPIResponseStream class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioLiveStationsAPIResponseStream class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorhls_stream.reset();
            fieldGeneratorshoutcast_stream.reset();
            fieldGeneratorpls_stream.reset();
            fieldGeneratorsecure_hls_stream.reset();
            fieldGeneratorsecure_shoutcast_stream.reset();
            fieldGeneratorsecure_pls_stream.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioLiveStationsAPIResponseStreamJSON  result)
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
        public IHeartRadioLiveStationsAPIResponseStreamJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioLiveStationsAPIResponseStreamJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioLiveStationsAPIResponseStreamJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioLiveStationsAPIResponseStreamJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioLiveStationsAPIResponseStreamJSON>();
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
    public List<IHeartRadioLiveStationsAPIResponseStreamJSON> value;
  };
  };
