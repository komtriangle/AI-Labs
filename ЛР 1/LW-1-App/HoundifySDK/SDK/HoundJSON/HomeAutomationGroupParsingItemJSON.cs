/* file "HomeAutomationGroupParsingItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationGroupParsingItemJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasActualNames;
    private List< string > storeActualNames;
    private bool flagHasSpokenPrefix;
    private string storeSpokenPrefix;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of HomeAutomationGroupParsingItemJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONActualNames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ActualNames of HomeAutomationGroupParsingItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ActualNames of HomeAutomationGroupParsingItemJSON has too few elements.");
        List< string > vector_ActualNames1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ActualNames of HomeAutomationGroupParsingItemJSON is not a string.");
            vector_ActualNames1.Add(json_string.getData());
          }
        Debug.Assert(vector_ActualNames1.Count >= 1);
        initActualNames();
        for (int num1 = 0; num1 < vector_ActualNames1.Count; ++num1)
            appendActualNames(vector_ActualNames1[num1]);
        for (int num1 = 0; num1 < vector_ActualNames1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpokenPrefix(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenPrefix of HomeAutomationGroupParsingItemJSON is not a string.");
        setSpokenPrefix(json_string.getData());
      }


    public HomeAutomationGroupParsingItemJSON()
      {
        flagHasName = false;
        flagHasActualNames = false;
        flagHasSpokenPrefix = false;
        storeActualNames = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasActualNames()
      {
        return flagHasActualNames;
      }

    public int  countOfActualNames()
      {
        Debug.Assert(flagHasActualNames);
        return storeActualNames.Count;
      }

    public string  elementOfActualNames(int element_num)
      {
        Debug.Assert(flagHasActualNames);
        return storeActualNames[element_num];
      }

    public List< string >  getActualNames()
      {
        Debug.Assert(flagHasActualNames);
        return storeActualNames;
      }

    public bool  hasSpokenPrefix()
      {
        return flagHasSpokenPrefix;
      }

    public string  getSpokenPrefix()
      {
        Debug.Assert(flagHasSpokenPrefix);
        return storeSpokenPrefix;
      }


    public virtual int extraHomeAutomationGroupParsingItemComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationGroupParsingItemComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationGroupParsingItemComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationGroupParsingItemLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void initActualNames()
      {
        flagHasActualNames = true;
        storeActualNames.Clear();
      }
    public void appendActualNames(string to_append)
      {
        if (!flagHasActualNames)
          {
            flagHasActualNames = true;
            storeActualNames.Clear();
          }
        Debug.Assert(flagHasActualNames);
        storeActualNames.Add(to_append);
      }
    public void unsetActualNames()
      {
        flagHasActualNames = false;
        storeActualNames.Clear();
      }
    public void setSpokenPrefix(string new_value)
      {
        flagHasSpokenPrefix = true;
        storeSpokenPrefix = new_value;
      }
    public void unsetSpokenPrefix()
      {
        flagHasSpokenPrefix = false;
      }

    public virtual void extraHomeAutomationGroupParsingItemAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationGroupParsingItemSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationGroupParsingItemLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationGroupParsingItemAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasActualNames)
          {
            handler.start_pair("ActualNames");
            Debug.Assert(storeActualNames.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeActualNames.Count; ++num1)
              {
                handler.string_value(storeActualNames[num1]);
              }
            handler.finish_array();
          }
        if (flagHasSpokenPrefix)
          {
            handler.start_pair("SpokenPrefix");
            handler.string_value(storeSpokenPrefix);
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        return null;
      }

    public static HomeAutomationGroupParsingItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationGroupParsingItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationGroupParsingItem", ignore_extras);
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
    public static HomeAutomationGroupParsingItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationGroupParsingItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationGroupParsingItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationGroupParsingItem", ignore_extras);
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
    public static HomeAutomationGroupParsingItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationGroupParsingItemJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationGroupParsingItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationGroupParsingItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationGroupParsingItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationGroupParsingItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationGroupParsingItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationGroupParsingItem", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringArrayGenerator fieldGeneratorActualNames;
        private JSONHoldingStringGenerator fieldGeneratorSpokenPrefix;
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
            HomeAutomationGroupParsingItemJSON result = new HomeAutomationGroupParsingItemJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationGroupParsingItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationGroupParsingItemJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorActualNames.have_value)
              {
                result.initActualNames();
                int count = fieldGeneratorActualNames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendActualNames(fieldGeneratorActualNames.value[num]);
                  }
                fieldGeneratorActualNames.value.Clear();
                fieldGeneratorActualNames.have_value = false;
              }
            if (fieldGeneratorSpokenPrefix.have_value)
              {
                result.setSpokenPrefix(fieldGeneratorSpokenPrefix.value);
                fieldGeneratorSpokenPrefix.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationGroupParsingItemJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ctualNames", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorActualNames;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenPrefix", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorSpokenPrefix;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HomeAutomationGroupParsingItem class");
            fieldGeneratorActualNames = new JSONHoldingStringArrayGenerator("field \"ActualNames\" of the HomeAutomationGroupParsingItem class");
            fieldGeneratorSpokenPrefix = new JSONHoldingStringGenerator("field \"SpokenPrefix\" of the HomeAutomationGroupParsingItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationGroupParsingItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HomeAutomationGroupParsingItem class");
            fieldGeneratorActualNames = new JSONHoldingStringArrayGenerator("field \"ActualNames\" of the HomeAutomationGroupParsingItem class");
            fieldGeneratorSpokenPrefix = new JSONHoldingStringGenerator("field \"SpokenPrefix\" of the HomeAutomationGroupParsingItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationGroupParsingItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorActualNames.reset();
            fieldGeneratorSpokenPrefix.reset();
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
        protected override void handle_result(HomeAutomationGroupParsingItemJSON  result)
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
        public HomeAutomationGroupParsingItemJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationGroupParsingItemJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationGroupParsingItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationGroupParsingItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationGroupParsingItemJSON>();
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
    public List<HomeAutomationGroupParsingItemJSON> value;
  };
  };
