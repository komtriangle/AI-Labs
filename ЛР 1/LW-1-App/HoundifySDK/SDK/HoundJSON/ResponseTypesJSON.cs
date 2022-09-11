/* file "ResponseTypesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ResponseTypesJSON : JSONBase
  {
    private bool flagHasSpokenShort;
    private string storeSpokenShort;
    private bool flagHasSpokenLong;
    private string storeSpokenLong;
    private bool flagHasWrittenShort;
    private string storeWrittenShort;
    private bool flagHasWrittenLong;
    private string storeWrittenLong;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSpokenShort(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenShort of ResponseTypesJSON is not a string.");
        setSpokenShort(json_string.getData());
      }


    private void  fromJSONSpokenLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenLong of ResponseTypesJSON is not a string.");
        setSpokenLong(json_string.getData());
      }


    private void  fromJSONWrittenShort(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenShort of ResponseTypesJSON is not a string.");
        setWrittenShort(json_string.getData());
      }


    private void  fromJSONWrittenLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenLong of ResponseTypesJSON is not a string.");
        setWrittenLong(json_string.getData());
      }


    public ResponseTypesJSON()
      {
        flagHasSpokenShort = false;
        flagHasSpokenLong = false;
        flagHasWrittenShort = false;
        flagHasWrittenLong = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSpokenShort()
      {
        return flagHasSpokenShort;
      }

    public string  getSpokenShort()
      {
        Debug.Assert(flagHasSpokenShort);
        return storeSpokenShort;
      }

    public bool  hasSpokenLong()
      {
        return flagHasSpokenLong;
      }

    public string  getSpokenLong()
      {
        Debug.Assert(flagHasSpokenLong);
        return storeSpokenLong;
      }

    public bool  hasWrittenShort()
      {
        return flagHasWrittenShort;
      }

    public string  getWrittenShort()
      {
        Debug.Assert(flagHasWrittenShort);
        return storeWrittenShort;
      }

    public bool  hasWrittenLong()
      {
        return flagHasWrittenLong;
      }

    public string  getWrittenLong()
      {
        Debug.Assert(flagHasWrittenLong);
        return storeWrittenLong;
      }


    public virtual int extraResponseTypesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraResponseTypesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraResponseTypesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraResponseTypesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSpokenShort(string new_value)
      {
        flagHasSpokenShort = true;
        storeSpokenShort = new_value;
      }
    public void unsetSpokenShort()
      {
        flagHasSpokenShort = false;
      }
    public void setSpokenLong(string new_value)
      {
        flagHasSpokenLong = true;
        storeSpokenLong = new_value;
      }
    public void unsetSpokenLong()
      {
        flagHasSpokenLong = false;
      }
    public void setWrittenShort(string new_value)
      {
        flagHasWrittenShort = true;
        storeWrittenShort = new_value;
      }
    public void unsetWrittenShort()
      {
        flagHasWrittenShort = false;
      }
    public void setWrittenLong(string new_value)
      {
        flagHasWrittenLong = true;
        storeWrittenLong = new_value;
      }
    public void unsetWrittenLong()
      {
        flagHasWrittenLong = false;
      }

    public virtual void extraResponseTypesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraResponseTypesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraResponseTypesLookup(key);
        if (old_field == null)
          {
            extraResponseTypesAppendPair(key, new_component);
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
        if (flagHasSpokenShort)
          {
            handler.start_pair("SpokenShort");
            handler.string_value(storeSpokenShort);
          }
        if (flagHasSpokenLong)
          {
            handler.start_pair("SpokenLong");
            handler.string_value(storeSpokenLong);
          }
        if (flagHasWrittenShort)
          {
            handler.start_pair("WrittenShort");
            handler.string_value(storeWrittenShort);
          }
        if (flagHasWrittenLong)
          {
            handler.start_pair("WrittenLong");
            handler.string_value(storeWrittenLong);
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

    public static ResponseTypesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ResponseTypesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ResponseTypes", ignore_extras);
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
    public static ResponseTypesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ResponseTypesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ResponseTypesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ResponseTypes", ignore_extras);
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
    public static ResponseTypesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ResponseTypesJSON from_text(string text, bool ignore_extras)
      {
        ResponseTypesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ResponseTypes", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ResponseTypesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ResponseTypesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ResponseTypesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ResponseTypes", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSpokenShort;
        private JSONHoldingStringGenerator fieldGeneratorSpokenLong;
        private JSONHoldingStringGenerator fieldGeneratorWrittenShort;
        private JSONHoldingStringGenerator fieldGeneratorWrittenLong;
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
            ResponseTypesJSON result = new ResponseTypesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraResponseTypesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ResponseTypesJSON result)
          {
            if (fieldGeneratorSpokenShort.have_value)
              {
                result.setSpokenShort(fieldGeneratorSpokenShort.value);
                fieldGeneratorSpokenShort.have_value = false;
              }
            if (fieldGeneratorSpokenLong.have_value)
              {
                result.setSpokenLong(fieldGeneratorSpokenLong.value);
                fieldGeneratorSpokenLong.have_value = false;
              }
            if (fieldGeneratorWrittenShort.have_value)
              {
                result.setWrittenShort(fieldGeneratorWrittenShort.value);
                fieldGeneratorWrittenShort.have_value = false;
              }
            if (fieldGeneratorWrittenLong.have_value)
              {
                result.setWrittenLong(fieldGeneratorWrittenLong.value);
                fieldGeneratorWrittenLong.have_value = false;
              }
          }
        protected abstract void handle_result(ResponseTypesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if (String.Compare(field_name, 1, "poken", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 7, "ong", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorSpokenLong;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 7, "hort", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorSpokenShort;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "ritten", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 8, "ong", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorWrittenLong;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 8, "hort", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorWrittenShort;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSpokenShort = new JSONHoldingStringGenerator("field \"SpokenShort\" of the ResponseTypes class");
            fieldGeneratorSpokenLong = new JSONHoldingStringGenerator("field \"SpokenLong\" of the ResponseTypes class");
            fieldGeneratorWrittenShort = new JSONHoldingStringGenerator("field \"WrittenShort\" of the ResponseTypes class");
            fieldGeneratorWrittenLong = new JSONHoldingStringGenerator("field \"WrittenLong\" of the ResponseTypes class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ResponseTypes class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpokenShort = new JSONHoldingStringGenerator("field \"SpokenShort\" of the ResponseTypes class");
            fieldGeneratorSpokenLong = new JSONHoldingStringGenerator("field \"SpokenLong\" of the ResponseTypes class");
            fieldGeneratorWrittenShort = new JSONHoldingStringGenerator("field \"WrittenShort\" of the ResponseTypes class");
            fieldGeneratorWrittenLong = new JSONHoldingStringGenerator("field \"WrittenLong\" of the ResponseTypes class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ResponseTypes class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpokenShort.reset();
            fieldGeneratorSpokenLong.reset();
            fieldGeneratorWrittenShort.reset();
            fieldGeneratorWrittenLong.reset();
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
        protected override void handle_result(ResponseTypesJSON  result)
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
        public ResponseTypesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ResponseTypesJSON  result)
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
    protected virtual void handle_result(List<ResponseTypesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ResponseTypesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ResponseTypesJSON>();
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
    public List<ResponseTypesJSON> value;
  };
  };
