/* file "OneInstalledAppJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class OneInstalledAppJSON : JSONBase
  {
    private bool flagHasAppName;
    private string storeAppName;
    private bool flagHasAliases;
    private List< string > storeAliases;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONAppName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AppName of OneInstalledAppJSON is not a string.");
        setAppName(json_string.getData());
      }


    private void  fromJSONAliases(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Aliases of OneInstalledAppJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Aliases1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Aliases of OneInstalledAppJSON is not a string.");
            vector_Aliases1.Add(json_string.getData());
          }
        initAliases();
        for (int num1 = 0; num1 < vector_Aliases1.Count; ++num1)
            appendAliases(vector_Aliases1[num1]);
        for (int num1 = 0; num1 < vector_Aliases1.Count; ++num1)
          {
          }
      }


    public OneInstalledAppJSON()
      {
        flagHasAppName = false;
        flagHasAliases = false;
        storeAliases = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasAppName()
      {
        return flagHasAppName;
      }

    public string  getAppName()
      {
        Debug.Assert(flagHasAppName);
        return storeAppName;
      }

    public bool  hasAliases()
      {
        return flagHasAliases;
      }

    public int  countOfAliases()
      {
        Debug.Assert(flagHasAliases);
        return storeAliases.Count;
      }

    public string  elementOfAliases(int element_num)
      {
        Debug.Assert(flagHasAliases);
        return storeAliases[element_num];
      }

    public List< string >  getAliases()
      {
        Debug.Assert(flagHasAliases);
        return storeAliases;
      }


    public virtual int extraOneInstalledAppComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOneInstalledAppComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOneInstalledAppComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOneInstalledAppLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setAppName(string new_value)
      {
        flagHasAppName = true;
        storeAppName = new_value;
      }
    public void unsetAppName()
      {
        flagHasAppName = false;
      }
    public void initAliases()
      {
        flagHasAliases = true;
        storeAliases.Clear();
      }
    public void appendAliases(string to_append)
      {
        if (!flagHasAliases)
          {
            flagHasAliases = true;
            storeAliases.Clear();
          }
        Debug.Assert(flagHasAliases);
        storeAliases.Add(to_append);
      }
    public void unsetAliases()
      {
        flagHasAliases = false;
        storeAliases.Clear();
      }

    public virtual void extraOneInstalledAppAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOneInstalledAppSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOneInstalledAppLookup(key);
        if (old_field == null)
          {
            extraOneInstalledAppAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAppName);
        if (flagHasAppName)
          {
            handler.start_pair("AppName");
            handler.string_value(storeAppName);
          }
        if (flagHasAliases)
          {
            handler.start_pair("Aliases");
            handler.start_array();
            for (int num1 = 0; num1 < storeAliases.Count; ++num1)
              {
                handler.string_value(storeAliases[num1]);
              }
            handler.finish_array();
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
        if (!(hasAppName()))
          {
            return "When parsing the object for %what%, the \"AppName\" field was missing.";
          }
        return null;
      }

    public static OneInstalledAppJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OneInstalledAppJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OneInstalledApp", ignore_extras);
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
    public static OneInstalledAppJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OneInstalledAppJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OneInstalledAppJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OneInstalledApp", ignore_extras);
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
    public static OneInstalledAppJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OneInstalledAppJSON from_text(string text, bool ignore_extras)
      {
        OneInstalledAppJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OneInstalledApp", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OneInstalledAppJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OneInstalledAppJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OneInstalledAppJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OneInstalledApp", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorAppName;
        private JSONHoldingStringArrayGenerator fieldGeneratorAliases;
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
            OneInstalledAppJSON result = new OneInstalledAppJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOneInstalledAppAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OneInstalledAppJSON result)
          {
            if (fieldGeneratorAppName.have_value)
              {
                result.setAppName(fieldGeneratorAppName.value);
                fieldGeneratorAppName.have_value = false;
              }
            else if ((!(result.hasAppName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AppName\" field was missing.");
              }
            if (fieldGeneratorAliases.have_value)
              {
                result.initAliases();
                int count = fieldGeneratorAliases.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAliases(fieldGeneratorAliases.value[num]);
                  }
                fieldGeneratorAliases.value.Clear();
                fieldGeneratorAliases.have_value = false;
              }
          }
        protected abstract void handle_result(OneInstalledAppJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "A", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'l':
                        if ((String.Compare(field_name, 2, "iases", 0, 5, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorAliases;
                        break;
                    case 'p':
                        if ((String.Compare(field_name, 2, "pName", 0, 5, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorAppName;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAppName = new JSONHoldingStringGenerator("field \"AppName\" of the OneInstalledApp class");
            fieldGeneratorAliases = new JSONHoldingStringArrayGenerator("field \"Aliases\" of the OneInstalledApp class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OneInstalledApp class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAppName = new JSONHoldingStringGenerator("field \"AppName\" of the OneInstalledApp class");
            fieldGeneratorAliases = new JSONHoldingStringArrayGenerator("field \"Aliases\" of the OneInstalledApp class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OneInstalledApp class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAppName.reset();
            fieldGeneratorAliases.reset();
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
        protected override void handle_result(OneInstalledAppJSON  result)
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
        public OneInstalledAppJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OneInstalledAppJSON  result)
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
    protected virtual void handle_result(List<OneInstalledAppJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OneInstalledAppJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OneInstalledAppJSON>();
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
    public List<OneInstalledAppJSON> value;
  };
  };
