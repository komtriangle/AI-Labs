/* file "BuildingNumberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class BuildingNumberJSON : JSONBase
  {
    private bool flagHasSpoken;
    private string storeSpoken;
    private bool flagHasWritten;
    private string storeWritten;


    private void  fromJSONSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Spoken of BuildingNumberJSON is not a string.");
        setSpoken(json_string.getData());
      }


    private void  fromJSONWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Written of BuildingNumberJSON is not a string.");
        setWritten(json_string.getData());
      }


    public BuildingNumberJSON()
      {
        flagHasSpoken = false;
        flagHasWritten = false;
      }

    public abstract string getKind();
    public bool  hasSpoken()
      {
        return flagHasSpoken;
      }

    public string  getSpoken()
      {
        Debug.Assert(flagHasSpoken);
        return storeSpoken;
      }

    public bool  hasWritten()
      {
        return flagHasWritten;
      }

    public string  getWritten()
      {
        Debug.Assert(flagHasWritten);
        return storeWritten;
      }


    public abstract int extraBuildingNumberComponentCount();
    public abstract string extraBuildingNumberComponentKey(int component_num);
    public abstract JSONValue extraBuildingNumberComponentValue(int component_num);
    public abstract JSONValue extraBuildingNumberLookup(string field_name);

    public void setSpoken(string new_value)
      {
        flagHasSpoken = true;
        storeSpoken = new_value;
      }
    public void unsetSpoken()
      {
        flagHasSpoken = false;
      }
    public void setWritten(string new_value)
      {
        flagHasWritten = true;
        storeWritten = new_value;
      }
    public void unsetWritten()
      {
        flagHasWritten = false;
      }

    public abstract void extraBuildingNumberAppendPair(string key, JSONValue new_component);
    public abstract void extraBuildingNumberSetField(string key, JSONValue new_component);

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
        handler.pair("Kind", getKind());
        Debug.Assert(partial_allowed || flagHasSpoken);
        if (flagHasSpoken)
          {
            handler.start_pair("Spoken");
            handler.string_value(storeSpoken);
          }
        Debug.Assert(partial_allowed || flagHasWritten);
        if (flagHasWritten)
          {
            handler.start_pair("Written");
            handler.string_value(storeWritten);
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
        if ((!allow_unpolished) && !(hasSpoken()))
          {
            return "When parsing the object for %what%, the \"Spoken\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasWritten()))
          {
            return "When parsing the object for %what%, the \"Written\" field was missing.";
          }
        return null;
      }

    public static BuildingNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BuildingNumber", ignore_extras);
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
    public static BuildingNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BuildingNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BuildingNumber", ignore_extras);
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
    public static BuildingNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BuildingNumberJSON from_text(string text, bool ignore_extras)
      {
        BuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BuildingNumber", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BuildingNumberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BuildingNumberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BuildingNumber", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSpoken;
        private JSONHoldingStringGenerator fieldGeneratorWritten;
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
                throw new Exception("The `Kind' field is missing.");
            BuildingNumberJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBuildingNumberAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getBuildingNumberJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `Kind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(BuildingNumberJSON result)
          {
            if (fieldGeneratorSpoken.have_value)
              {
                result.setSpoken(fieldGeneratorSpoken.value);
                fieldGeneratorSpoken.have_value = false;
              }
            else if ((!(result.hasSpoken())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Spoken\" field was missing.");
              }
            if (fieldGeneratorWritten.have_value)
              {
                result.setWritten(fieldGeneratorWritten.value);
                fieldGeneratorWritten.have_value = false;
              }
            else if ((!(result.hasWritten())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Written\" field was missing.");
              }
          }
        protected abstract void handle_result(BuildingNumberJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'K':
                    if ((String.Compare(field_name, 1, "ind", 0, 3, false) == 0) && (field_name.Length == 4))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "poken", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSpoken;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "ritten", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorWritten;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSpoken = new JSONHoldingStringGenerator("field \"Spoken\" of the BuildingNumber class");
            fieldGeneratorWritten = new JSONHoldingStringGenerator("field \"Written\" of the BuildingNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"Kind\" of the BuildingNumber class");
            set_what("the BuildingNumber class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpoken = new JSONHoldingStringGenerator("field \"Spoken\" of the BuildingNumber class");
            fieldGeneratorWritten = new JSONHoldingStringGenerator("field \"Written\" of the BuildingNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"Kind\" of the BuildingNumber class");
            set_what("the BuildingNumber class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpoken.reset();
            fieldGeneratorWritten.reset();
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
        protected override void handle_result(BuildingNumberJSON  result)
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
        public BuildingNumberJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BuildingNumberJSON  result)
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
    protected virtual void handle_result(List<BuildingNumberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BuildingNumberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BuildingNumberJSON>();
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
    public List<BuildingNumberJSON> value;
  };
    class GenericBuildingNumberJSON : BuildingNumberJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericBuildingNumberJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getKind()  { return key; }
        public override int extraBuildingNumberComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraBuildingNumberComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraBuildingNumberComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraBuildingNumberLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraBuildingNumberAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraBuildingNumberSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraBuildingNumberLookup(key);
            if (old_field == null)
              {
                extraBuildingNumberAppendPair(key, new_component);
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
    public static BuildingNumberJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "F", 0, 1, false) == 0)
      {
        switch (key[1])
          {
            case 'i':
                if (String.Compare(key, 2, "niteInteger", 0, 11, false) == 0)
                  {
                    if (key.Length == 13)
                      {
                        return new FiniteIntegerBuildingNumberJSON();
                      }
                    switch (key[13])
                      {
                        case 'D':
                            if (String.Compare(key, 14, "ashFiniteInteger", 0, 16, false) == 0)
                              {
                                if (key.Length == 30)
                                  {
                                    return new FiniteIntegerDashFiniteIntegerBuildingNumberJSON();
                                  }
                                switch (key[30])
                                  {
                                    case 'P':
                                        if ((String.Compare(key, 31, "lusFraction", 0, 11, false) == 0) && (key.Length == 42))
                                            return new FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON();
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'P':
                            if ((String.Compare(key, 14, "lusFraction", 0, 11, false) == 0) && (key.Length == 25))
                                return new FiniteIntegerPlusFractionBuildingNumberJSON();
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'u':
                if ((String.Compare(key, 2, "llStringBuildingNumber", 0, 22, false) == 0) && (key.Length == 24))
                    return new FullStringBuildingNumberJSON();
                break;
            default:
                break;
          }
      }

        return new GenericBuildingNumberJSON(key);
      }
  };
