/* file "CustomASREnhancementReadDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CustomASREnhancementReadDataJSON : JSONBase
  {
    private bool flagHasGrammarName;
    private string storeGrammarName;
    private bool flagHasIsGlobal;
    private bool storeIsGlobal;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONGrammarName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field GrammarName of CustomASREnhancementReadDataJSON is not a string.");
        setGrammarName(json_string.getData());
      }


    private void  fromJSONIsGlobal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IsGlobal of CustomASREnhancementReadDataJSON is not true for false.");
              }
          }
        setIsGlobal(the_bool);
      }


    public CustomASREnhancementReadDataJSON()
      {
        flagHasGrammarName = false;
        flagHasIsGlobal = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasGrammarName()
      {
        return flagHasGrammarName;
      }

    public string  getGrammarName()
      {
        Debug.Assert(flagHasGrammarName);
        return storeGrammarName;
      }

    public bool  hasIsGlobal()
      {
        return flagHasIsGlobal;
      }

    public bool  getIsGlobal()
      {
        Debug.Assert(flagHasIsGlobal);
        return storeIsGlobal;
      }


    public virtual int extraCustomASREnhancementReadDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCustomASREnhancementReadDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCustomASREnhancementReadDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCustomASREnhancementReadDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setGrammarName(string new_value)
      {
        flagHasGrammarName = true;
        storeGrammarName = new_value;
      }
    public void unsetGrammarName()
      {
        flagHasGrammarName = false;
      }
    public void setIsGlobal(bool new_value)
      {
        flagHasIsGlobal = true;
        storeIsGlobal = new_value;
      }
    public void unsetIsGlobal()
      {
        flagHasIsGlobal = false;
      }

    public virtual void extraCustomASREnhancementReadDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCustomASREnhancementReadDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCustomASREnhancementReadDataLookup(key);
        if (old_field == null)
          {
            extraCustomASREnhancementReadDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasGrammarName);
        if (flagHasGrammarName)
          {
            handler.start_pair("GrammarName");
            handler.string_value(storeGrammarName);
          }
        Debug.Assert(partial_allowed || flagHasIsGlobal);
        if (flagHasIsGlobal)
          {
            handler.start_pair("IsGlobal");
            handler.boolean_value(storeIsGlobal);
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
        if (!(hasGrammarName()))
          {
            return "When parsing the object for %what%, the \"GrammarName\" field was missing.";
          }
        if (!(hasIsGlobal()))
          {
            return "When parsing the object for %what%, the \"IsGlobal\" field was missing.";
          }
        return null;
      }

    public static CustomASREnhancementReadDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CustomASREnhancementReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomASREnhancementReadData", ignore_extras);
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
    public static CustomASREnhancementReadDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CustomASREnhancementReadDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CustomASREnhancementReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomASREnhancementReadData", ignore_extras);
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
    public static CustomASREnhancementReadDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CustomASREnhancementReadDataJSON from_text(string text, bool ignore_extras)
      {
        CustomASREnhancementReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomASREnhancementReadData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CustomASREnhancementReadDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CustomASREnhancementReadDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CustomASREnhancementReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomASREnhancementReadData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorGrammarName;
        private JSONHoldingBooleanGenerator fieldGeneratorIsGlobal;
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
            CustomASREnhancementReadDataJSON result = new CustomASREnhancementReadDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCustomASREnhancementReadDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CustomASREnhancementReadDataJSON result)
          {
            if (fieldGeneratorGrammarName.have_value)
              {
                result.setGrammarName(fieldGeneratorGrammarName.value);
                fieldGeneratorGrammarName.have_value = false;
              }
            else if ((!(result.hasGrammarName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"GrammarName\" field was missing.");
              }
            if (fieldGeneratorIsGlobal.have_value)
              {
                result.setIsGlobal(fieldGeneratorIsGlobal.value);
                fieldGeneratorIsGlobal.have_value = false;
              }
            else if ((!(result.hasIsGlobal())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsGlobal\" field was missing.");
              }
          }
        protected abstract void handle_result(CustomASREnhancementReadDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'G':
                    if ((String.Compare(field_name, 1, "rammarName", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorGrammarName;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sGlobal", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorIsGlobal;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorGrammarName = new JSONHoldingStringGenerator("field \"GrammarName\" of the CustomASREnhancementReadData class");
            fieldGeneratorIsGlobal = new JSONHoldingBooleanGenerator("field \"IsGlobal\" of the CustomASREnhancementReadData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CustomASREnhancementReadData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorGrammarName = new JSONHoldingStringGenerator("field \"GrammarName\" of the CustomASREnhancementReadData class");
            fieldGeneratorIsGlobal = new JSONHoldingBooleanGenerator("field \"IsGlobal\" of the CustomASREnhancementReadData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CustomASREnhancementReadData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorGrammarName.reset();
            fieldGeneratorIsGlobal.reset();
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
        protected override void handle_result(CustomASREnhancementReadDataJSON  result)
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
        public CustomASREnhancementReadDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CustomASREnhancementReadDataJSON  result)
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
    protected virtual void handle_result(List<CustomASREnhancementReadDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CustomASREnhancementReadDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CustomASREnhancementReadDataJSON>();
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
    public List<CustomASREnhancementReadDataJSON> value;
  };
  };
