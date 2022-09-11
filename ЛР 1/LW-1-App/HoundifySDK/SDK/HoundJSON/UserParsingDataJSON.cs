/* file "UserParsingDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserParsingDataJSON : JSONBase
  {
    private bool flagHasWhatUserCallsUs;
    private string storeWhatUserCallsUs;
    private bool flagHasRealmData;
    private JSONObjectValue  storeRealmData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONWhatUserCallsUs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WhatUserCallsUs of UserParsingDataJSON is not a string.");
        setWhatUserCallsUs(json_string.getData());
      }


    private void  fromJSONRealmData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field RealmData of UserParsingDataJSON is not an object.");
        setRealmData(json_value.object_value());
      }


    public UserParsingDataJSON()
      {
        flagHasWhatUserCallsUs = false;
        flagHasRealmData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasWhatUserCallsUs()
      {
        return flagHasWhatUserCallsUs;
      }

    public string  getWhatUserCallsUs()
      {
        Debug.Assert(flagHasWhatUserCallsUs);
        return storeWhatUserCallsUs;
      }

    public bool  hasRealmData()
      {
        return flagHasRealmData;
      }

    public JSONObjectValue   getRealmData()
      {
        Debug.Assert(flagHasRealmData);
        return storeRealmData;
      }


    public virtual int extraUserParsingDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserParsingDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserParsingDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserParsingDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setWhatUserCallsUs(string new_value)
      {
        flagHasWhatUserCallsUs = true;
        storeWhatUserCallsUs = new_value;
      }
    public void unsetWhatUserCallsUs()
      {
        flagHasWhatUserCallsUs = false;
      }
    public void setRealmData(JSONObjectValue  new_value)
      {
        if (flagHasRealmData)
          {
          }
        flagHasRealmData = true;
        storeRealmData = new_value;
      }
    public void unsetRealmData()
      {
        if (flagHasRealmData)
          {
          }
        flagHasRealmData = false;
      }

    public virtual void extraUserParsingDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserParsingDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserParsingDataLookup(key);
        if (old_field == null)
          {
            extraUserParsingDataAppendPair(key, new_component);
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
        if (flagHasWhatUserCallsUs)
          {
            handler.start_pair("WhatUserCallsUs");
            handler.string_value(storeWhatUserCallsUs);
          }
        if (flagHasRealmData)
          {
            handler.start_pair("RealmData");
            storeRealmData.write(handler);
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

    public static UserParsingDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserParsingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserParsingData", ignore_extras);
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
    public static UserParsingDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserParsingDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserParsingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserParsingData", ignore_extras);
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
    public static UserParsingDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserParsingDataJSON from_text(string text, bool ignore_extras)
      {
        UserParsingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserParsingData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserParsingDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UserParsingDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserParsingDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserParsingData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorWhatUserCallsUs;
        private JSONHoldingObjectValueGenerator fieldGeneratorRealmData;
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
            UserParsingDataJSON result = new UserParsingDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserParsingDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UserParsingDataJSON result)
          {
            if (fieldGeneratorWhatUserCallsUs.have_value)
              {
                result.setWhatUserCallsUs(fieldGeneratorWhatUserCallsUs.value);
                fieldGeneratorWhatUserCallsUs.have_value = false;
              }
            if (fieldGeneratorRealmData.have_value)
              {
                result.setRealmData(fieldGeneratorRealmData.value);
                fieldGeneratorRealmData.have_value = false;
              }
          }
        protected abstract void handle_result(UserParsingDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'R':
                    if ((String.Compare(field_name, 1, "ealmData", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorRealmData;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "hatUserCallsUs", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorWhatUserCallsUs;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorWhatUserCallsUs = new JSONHoldingStringGenerator("field \"WhatUserCallsUs\" of the UserParsingData class");
            fieldGeneratorRealmData = new JSONHoldingObjectValueGenerator("field \"RealmData\" of the UserParsingData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserParsingData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorWhatUserCallsUs = new JSONHoldingStringGenerator("field \"WhatUserCallsUs\" of the UserParsingData class");
            fieldGeneratorRealmData = new JSONHoldingObjectValueGenerator("field \"RealmData\" of the UserParsingData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserParsingData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorWhatUserCallsUs.reset();
            fieldGeneratorRealmData.reset();
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
        protected override void handle_result(UserParsingDataJSON  result)
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
        public UserParsingDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserParsingDataJSON  result)
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
    protected virtual void handle_result(List<UserParsingDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserParsingDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserParsingDataJSON>();
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
    public List<UserParsingDataJSON> value;
  };
  };
