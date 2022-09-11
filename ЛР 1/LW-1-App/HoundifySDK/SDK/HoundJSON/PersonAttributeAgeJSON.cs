/* file "PersonAttributeAgeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PersonAttributeAgeJSON : PersonAttributeAmountJSON
  {
    private bool flagHasParameters;
    private PersonAttributeAgeParametersJSON  storeParameters;
    private bool flagHasIsAtDeath;
    private bool storeIsAtDeath;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraParametersToJSON()
      {
        JSONValueHandler handler_Parameters = new JSONValueHandler();
        storeParameters.write_as_json(handler_Parameters);
        return handler_Parameters.result;
      }

    private JSONValue  extraIsAtDeathToJSON()
      {
        JSONValue generated_boolean_IsAtDeath = (storeIsAtDeath ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsAtDeath;
      }


    private void  fromJSONParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PersonAttributeAgeParametersJSON convert_classy = PersonAttributeAgeParametersJSON.from_json(json_value, ignore_extras, true);
        setParameters(convert_classy);
      }


    private void  fromJSONIsAtDeath(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsAtDeath of PersonAttributeAgeJSON is not true for false.");
              }
          }
        setIsAtDeath(the_bool);
      }


    public PersonAttributeAgeJSON()
      {
        flagHasParameters = false;
        flagHasIsAtDeath = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPersonAttribute()
      {
        return "Age";
      }

    public bool  hasParameters()
      {
        return flagHasParameters;
      }

    public PersonAttributeAgeParametersJSON   getParameters()
      {
        Debug.Assert(flagHasParameters);
        return storeParameters;
      }

    public bool  hasIsAtDeath()
      {
        return flagHasIsAtDeath;
      }

    public bool  getIsAtDeath()
      {
        Debug.Assert(flagHasIsAtDeath);
        return storeIsAtDeath;
      }


    public virtual int extraPersonAttributeAgeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPersonAttributeAgeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPersonAttributeAgeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPersonAttributeAgeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPersonAttributeAmountComponentCount()
      {
        int result = 0;
        if (flagHasParameters)
            ++result;
        if (flagHasIsAtDeath)
            ++result;
        result += extraPersonAttributeAgeComponentCount();
        return result;
      }
    public override string extraPersonAttributeAmountComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasParameters)
          {
            if (remainder == 0)
                return "Parameters";
            --remainder;
          }
        if (flagHasIsAtDeath)
          {
            if (remainder == 0)
                return "IsAtDeath";
            --remainder;
          }
        return extraPersonAttributeAgeComponentKey(remainder);
      }
    public override JSONValue extraPersonAttributeAmountComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasParameters)
          {
            if (remainder == 0)
                return extraParametersToJSON();
            --remainder;
          }
        if (flagHasIsAtDeath)
          {
            if (remainder == 0)
                return extraIsAtDeathToJSON();
            --remainder;
          }
        return extraPersonAttributeAgeComponentValue(remainder);
      }
    public override JSONValue extraPersonAttributeAmountLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "sAtDeath", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasIsAtDeath ? extraIsAtDeathToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "arameters", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasParameters ? extraParametersToJSON() : null);
                break;
            default:
                break;
          }
        return extraPersonAttributeAgeLookup(field_name);
      }

    public void setParameters(PersonAttributeAgeParametersJSON  new_value)
      {
        if (flagHasParameters)
          {
          }
        flagHasParameters = true;
        storeParameters = new_value;
      }
    public void unsetParameters()
      {
        if (flagHasParameters)
          {
          }
        flagHasParameters = false;
      }
    public void setIsAtDeath(bool new_value)
      {
        flagHasIsAtDeath = true;
        storeIsAtDeath = new_value;
      }
    public void unsetIsAtDeath()
      {
        flagHasIsAtDeath = false;
      }

    public virtual void extraPersonAttributeAgeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPersonAttributeAgeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPersonAttributeAgeLookup(key);
        if (old_field == null)
          {
            extraPersonAttributeAgeAppendPair(key, new_component);
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
    public override void extraPersonAttributeAmountAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "sAtDeath", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONIsAtDeath(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "arameters", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONParameters(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraPersonAttributeAgeAppendPair(key, new_component);
      }
    public override void extraPersonAttributeAmountSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "sAtDeath", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONIsAtDeath(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "arameters", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONParameters(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraPersonAttributeAgeSetField(key, new_component);
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
        if (flagHasParameters)
          {
            handler.start_pair("Parameters");
            if (partial_allowed)
                storeParameters.write_partial_as_json(handler);
            else
                storeParameters.write_as_json(handler);
          }
        if (flagHasIsAtDeath)
          {
            handler.start_pair("IsAtDeath");
            handler.boolean_value(storeIsAtDeath);
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
        return null;
      }

    public static new PersonAttributeAgeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeAgeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeAge", ignore_extras);
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
    public static new PersonAttributeAgeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonAttributeAgeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeAgeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeAge", ignore_extras);
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
    public static new PersonAttributeAgeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonAttributeAgeJSON from_text(string text, bool ignore_extras)
      {
        PersonAttributeAgeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeAge", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonAttributeAgeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PersonAttributeAgeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonAttributeAgeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeAge", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PersonAttributeAmountJSON.Generator
      {
        private PersonAttributeAgeParametersJSON.HoldingGenerator fieldGeneratorParameters;
        private JSONHoldingBooleanGenerator fieldGeneratorIsAtDeath;
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
            if (!(getPersonAttributeAmountJSONKey().Equals("Age")))
                throw new Exception("The key field has a value other than `Age'.");
            PersonAttributeAgeJSON result = new PersonAttributeAgeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonAttributeAgeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PersonAttributeAmountJSON new_result)
          {
            handle_result((PersonAttributeAgeJSON )new_result);
          }
        protected void finish(PersonAttributeAgeJSON result)
          {
            if (fieldGeneratorParameters.have_value)
              {
                result.setParameters(fieldGeneratorParameters.value);
                fieldGeneratorParameters.have_value = false;
              }
            if (fieldGeneratorIsAtDeath.have_value)
              {
                result.setIsAtDeath(fieldGeneratorIsAtDeath.value);
                fieldGeneratorIsAtDeath.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(PersonAttributeAgeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "sAtDeath", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorIsAtDeath;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "arameters", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorParameters;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorParameters = new PersonAttributeAgeParametersJSON.HoldingGenerator("field \"Parameters\" of the PersonAttributeAge class", ignore_extras);
            fieldGeneratorIsAtDeath = new JSONHoldingBooleanGenerator("field \"IsAtDeath\" of the PersonAttributeAge class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PersonAttributeAge class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorParameters = new PersonAttributeAgeParametersJSON.HoldingGenerator("field \"Parameters\" of the PersonAttributeAge class", false);
            fieldGeneratorIsAtDeath = new JSONHoldingBooleanGenerator("field \"IsAtDeath\" of the PersonAttributeAge class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PersonAttributeAge class");
          }

        public override void reset()
          {
            fieldGeneratorParameters.reset();
            fieldGeneratorIsAtDeath.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonAttributeAgeJSON  result)
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
        public PersonAttributeAgeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonAttributeAgeJSON  result)
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
    protected virtual void handle_result(List<PersonAttributeAgeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonAttributeAgeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonAttributeAgeJSON>();
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
    public List<PersonAttributeAgeJSON> value;
  };
  };
