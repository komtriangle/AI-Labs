/* file "LabeledPhoneNumberPropertyJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class LabeledPhoneNumberPropertyJSON : PropertyJSON
  {
    private bool flagHasLabel;
    private string storeLabel;
    private bool flagHasAliasLabels;
    private List< string > storeAliasLabels;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraLabelToJSON()
      {
        JSONStringValue generated_string_Label = new JSONStringValue(storeLabel);
        return generated_string_Label;
      }

    private JSONValue  extraAliasLabelsToJSON()
      {
        JSONArrayValue generated_array_1_AliasLabels = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAliasLabels.Count; ++num1)
          {
            JSONStringValue generated_string_AliasLabels = new JSONStringValue(storeAliasLabels[num1]);
            generated_array_1_AliasLabels.appendComponent(generated_string_AliasLabels);
          }
        return generated_array_1_AliasLabels;
      }


    private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Label of LabeledPhoneNumberPropertyJSON is not a string.");
        setLabel(json_string.getData());
      }


    private void  fromJSONAliasLabels(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AliasLabels of LabeledPhoneNumberPropertyJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_AliasLabels1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field AliasLabels of LabeledPhoneNumberPropertyJSON is not a string.");
            vector_AliasLabels1.Add(json_string.getData());
          }
        initAliasLabels();
        for (int num1 = 0; num1 < vector_AliasLabels1.Count; ++num1)
            appendAliasLabels(vector_AliasLabels1[num1]);
        for (int num1 = 0; num1 < vector_AliasLabels1.Count; ++num1)
          {
          }
      }


    public LabeledPhoneNumberPropertyJSON()
      {
        flagHasLabel = false;
        flagHasAliasLabels = false;
        storeAliasLabels = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPropertyKind()
      {
        return "LabeledPhoneNumber";
      }

    public bool  hasLabel()
      {
        return flagHasLabel;
      }

    public string  getLabel()
      {
        Debug.Assert(flagHasLabel);
        return storeLabel;
      }

    public bool  hasAliasLabels()
      {
        return flagHasAliasLabels;
      }

    public int  countOfAliasLabels()
      {
        Debug.Assert(flagHasAliasLabels);
        return storeAliasLabels.Count;
      }

    public string  elementOfAliasLabels(int element_num)
      {
        Debug.Assert(flagHasAliasLabels);
        return storeAliasLabels[element_num];
      }

    public List< string >  getAliasLabels()
      {
        Debug.Assert(flagHasAliasLabels);
        return storeAliasLabels;
      }


    public virtual int extraLabeledPhoneNumberPropertyComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLabeledPhoneNumberPropertyComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLabeledPhoneNumberPropertyComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLabeledPhoneNumberPropertyLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPropertyComponentCount()
      {
        int result = 0;
        if (flagHasLabel)
            ++result;
        if (flagHasAliasLabels)
            ++result;
        result += extraLabeledPhoneNumberPropertyComponentCount();
        return result;
      }
    public override string extraPropertyComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasLabel)
          {
            if (remainder == 0)
                return "Label";
            --remainder;
          }
        if (flagHasAliasLabels)
          {
            if (remainder == 0)
                return "AliasLabels";
            --remainder;
          }
        return extraLabeledPhoneNumberPropertyComponentKey(remainder);
      }
    public override JSONValue extraPropertyComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasLabel)
          {
            if (remainder == 0)
                return extraLabelToJSON();
            --remainder;
          }
        if (flagHasAliasLabels)
          {
            if (remainder == 0)
                return extraAliasLabelsToJSON();
            --remainder;
          }
        return extraLabeledPhoneNumberPropertyComponentValue(remainder);
      }
    public override JSONValue extraPropertyLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "liasLabels", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasAliasLabels ? extraAliasLabelsToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasLabel ? extraLabelToJSON() : null);
                break;
            default:
                break;
          }
        return extraLabeledPhoneNumberPropertyLookup(field_name);
      }

    public void setLabel(string new_value)
      {
        flagHasLabel = true;
        storeLabel = new_value;
      }
    public void unsetLabel()
      {
        flagHasLabel = false;
      }
    public void initAliasLabels()
      {
        flagHasAliasLabels = true;
        storeAliasLabels.Clear();
      }
    public void appendAliasLabels(string to_append)
      {
        if (!flagHasAliasLabels)
          {
            flagHasAliasLabels = true;
            storeAliasLabels.Clear();
          }
        Debug.Assert(flagHasAliasLabels);
        storeAliasLabels.Add(to_append);
      }
    public void unsetAliasLabels()
      {
        flagHasAliasLabels = false;
        storeAliasLabels.Clear();
      }

    public virtual void extraLabeledPhoneNumberPropertyAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLabeledPhoneNumberPropertySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLabeledPhoneNumberPropertyLookup(key);
        if (old_field == null)
          {
            extraLabeledPhoneNumberPropertyAppendPair(key, new_component);
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
    public override void extraPropertyAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "liasLabels", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAliasLabels(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "abel", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONLabel(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraLabeledPhoneNumberPropertyAppendPair(key, new_component);
      }
    public override void extraPropertySetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "liasLabels", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAliasLabels(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "abel", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONLabel(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraLabeledPhoneNumberPropertySetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasLabel);
        if (flagHasLabel)
          {
            handler.start_pair("Label");
            handler.string_value(storeLabel);
          }
        if (flagHasAliasLabels)
          {
            handler.start_pair("AliasLabels");
            handler.start_array();
            for (int num1 = 0; num1 < storeAliasLabels.Count; ++num1)
              {
                handler.string_value(storeAliasLabels[num1]);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasLabel()))
          {
            return "When parsing the object for %what%, the \"Label\" field was missing.";
          }
        return null;
      }

    public static new LabeledPhoneNumberPropertyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LabeledPhoneNumberPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LabeledPhoneNumberProperty", ignore_extras);
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
    public static new LabeledPhoneNumberPropertyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LabeledPhoneNumberPropertyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LabeledPhoneNumberPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LabeledPhoneNumberProperty", ignore_extras);
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
    public static new LabeledPhoneNumberPropertyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LabeledPhoneNumberPropertyJSON from_text(string text, bool ignore_extras)
      {
        LabeledPhoneNumberPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LabeledPhoneNumberProperty", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LabeledPhoneNumberPropertyJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new LabeledPhoneNumberPropertyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LabeledPhoneNumberPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LabeledPhoneNumberProperty", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PropertyJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorLabel;
        private JSONHoldingStringArrayGenerator fieldGeneratorAliasLabels;
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
            if (!(getPropertyJSONKey().Equals("LabeledPhoneNumber")))
                throw new Exception("The key field has a value other than `LabeledPhoneNumber'.");
            LabeledPhoneNumberPropertyJSON result = new LabeledPhoneNumberPropertyJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLabeledPhoneNumberPropertyAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PropertyJSON new_result)
          {
            handle_result((LabeledPhoneNumberPropertyJSON )new_result);
          }
        protected void finish(LabeledPhoneNumberPropertyJSON result)
          {
            if (fieldGeneratorLabel.have_value)
              {
                result.setLabel(fieldGeneratorLabel.value);
                fieldGeneratorLabel.have_value = false;
              }
            else if ((!(result.hasLabel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Label\" field was missing.");
              }
            if (fieldGeneratorAliasLabels.have_value)
              {
                result.initAliasLabels();
                int count = fieldGeneratorAliasLabels.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAliasLabels(fieldGeneratorAliasLabels.value[num]);
                  }
                fieldGeneratorAliasLabels.value.Clear();
                fieldGeneratorAliasLabels.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(LabeledPhoneNumberPropertyJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "liasLabels", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAliasLabels;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorLabel;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the LabeledPhoneNumberProperty class");
            fieldGeneratorAliasLabels = new JSONHoldingStringArrayGenerator("field \"AliasLabels\" of the LabeledPhoneNumberProperty class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LabeledPhoneNumberProperty class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the LabeledPhoneNumberProperty class");
            fieldGeneratorAliasLabels = new JSONHoldingStringArrayGenerator("field \"AliasLabels\" of the LabeledPhoneNumberProperty class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LabeledPhoneNumberProperty class");
          }

        public override void reset()
          {
            fieldGeneratorLabel.reset();
            fieldGeneratorAliasLabels.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(LabeledPhoneNumberPropertyJSON  result)
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
        public LabeledPhoneNumberPropertyJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LabeledPhoneNumberPropertyJSON  result)
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
    protected virtual void handle_result(List<LabeledPhoneNumberPropertyJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LabeledPhoneNumberPropertyJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LabeledPhoneNumberPropertyJSON>();
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
    public List<LabeledPhoneNumberPropertyJSON> value;
  };
  };
