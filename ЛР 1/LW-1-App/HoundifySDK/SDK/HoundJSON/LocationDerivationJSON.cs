/* file "LocationDerivationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class LocationDerivationJSON : JSONBase
  {
    private bool flagHasSpokenForm;
    private string storeSpokenForm;
    private bool flagHasWrittenForm;
    private string storeWrittenForm;


    private void  fromJSONSpokenForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenForm of LocationDerivationJSON is not a string.");
        setSpokenForm(json_string.getData());
      }


    private void  fromJSONWrittenForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenForm of LocationDerivationJSON is not a string.");
        setWrittenForm(json_string.getData());
      }


    public LocationDerivationJSON()
      {
        flagHasSpokenForm = false;
        flagHasWrittenForm = false;
      }

    public abstract string getLocationDerivationKind();
    public bool  hasSpokenForm()
      {
        return flagHasSpokenForm;
      }

    public string  getSpokenForm()
      {
        Debug.Assert(flagHasSpokenForm);
        return storeSpokenForm;
      }

    public bool  hasWrittenForm()
      {
        return flagHasWrittenForm;
      }

    public string  getWrittenForm()
      {
        Debug.Assert(flagHasWrittenForm);
        return storeWrittenForm;
      }


    public abstract int extraLocationDerivationComponentCount();
    public abstract string extraLocationDerivationComponentKey(int component_num);
    public abstract JSONValue extraLocationDerivationComponentValue(int component_num);
    public abstract JSONValue extraLocationDerivationLookup(string field_name);

    public void setSpokenForm(string new_value)
      {
        flagHasSpokenForm = true;
        storeSpokenForm = new_value;
      }
    public void unsetSpokenForm()
      {
        flagHasSpokenForm = false;
      }
    public void setWrittenForm(string new_value)
      {
        flagHasWrittenForm = true;
        storeWrittenForm = new_value;
      }
    public void unsetWrittenForm()
      {
        flagHasWrittenForm = false;
      }

    public abstract void extraLocationDerivationAppendPair(string key, JSONValue new_component);
    public abstract void extraLocationDerivationSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("LocationDerivationKind", getLocationDerivationKind());
        if (flagHasSpokenForm)
          {
            handler.start_pair("SpokenForm");
            handler.string_value(storeSpokenForm);
          }
        if (flagHasWrittenForm)
          {
            handler.start_pair("WrittenForm");
            handler.string_value(storeWrittenForm);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static LocationDerivationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocationDerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocationDerivation", ignore_extras);
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
    public static LocationDerivationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocationDerivationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocationDerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocationDerivation", ignore_extras);
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
    public static LocationDerivationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocationDerivationJSON from_text(string text, bool ignore_extras)
      {
        LocationDerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocationDerivation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LocationDerivationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static LocationDerivationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LocationDerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocationDerivation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSpokenForm;
        private JSONHoldingStringGenerator fieldGeneratorWrittenForm;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `LocationDerivationKind' field is missing.");
            LocationDerivationJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLocationDerivationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getLocationDerivationJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `LocationDerivationKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(LocationDerivationJSON result)
          {
            if (fieldGeneratorSpokenForm.have_value)
              {
                result.setSpokenForm(fieldGeneratorSpokenForm.value);
                fieldGeneratorSpokenForm.have_value = false;
              }
            if (fieldGeneratorWrittenForm.have_value)
              {
                result.setWrittenForm(fieldGeneratorWrittenForm.value);
                fieldGeneratorWrittenForm.have_value = false;
              }
          }
        protected abstract void handle_result(LocationDerivationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "ocationDerivationKind", 0, 21, false) == 0) && (field_name.Length == 22))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenForm", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSpokenForm;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenForm", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorWrittenForm;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSpokenForm = new JSONHoldingStringGenerator("field \"SpokenForm\" of the LocationDerivation class");
            fieldGeneratorWrittenForm = new JSONHoldingStringGenerator("field \"WrittenForm\" of the LocationDerivation class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"LocationDerivationKind\" of the LocationDerivation class");
            set_what("the LocationDerivation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpokenForm = new JSONHoldingStringGenerator("field \"SpokenForm\" of the LocationDerivation class");
            fieldGeneratorWrittenForm = new JSONHoldingStringGenerator("field \"WrittenForm\" of the LocationDerivation class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"LocationDerivationKind\" of the LocationDerivation class");
            set_what("the LocationDerivation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpokenForm.reset();
            fieldGeneratorWrittenForm.reset();
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
        protected override void handle_result(LocationDerivationJSON  result)
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
        public LocationDerivationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LocationDerivationJSON  result)
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
    protected virtual void handle_result(List<LocationDerivationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LocationDerivationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LocationDerivationJSON>();
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
    public List<LocationDerivationJSON> value;
  };
    class GenericLocationDerivationJSON : LocationDerivationJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericLocationDerivationJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getLocationDerivationKind()  { return key; }
        public override int extraLocationDerivationComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraLocationDerivationComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraLocationDerivationComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraLocationDerivationLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraLocationDerivationAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraLocationDerivationSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraLocationDerivationLookup(key);
            if (old_field == null)
              {
                extraLocationDerivationAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static LocationDerivationJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if ((String.Compare(key, 0, "LocalSearch", 0, 11, false) == 0) && (key.Length == 11))
        return new LocalSearchLocationDerivationJSON();

        return new GenericLocationDerivationJSON(key);
      }
  };
