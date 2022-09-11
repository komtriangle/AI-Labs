/* file "PersonAttributeHeightJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PersonAttributeHeightJSON : PersonAttributeAmountJSON
  {
    private bool flagHasIsDead;
    private bool storeIsDead;
    private bool flagHasUnit;
    private UnitOfMeasureJSON  storeUnit;
    private bool flagHasTime;
    private DateAndOrTimeJSON  storeTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraIsDeadToJSON()
      {
        JSONValue generated_boolean_IsDead = (storeIsDead ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsDead;
      }

    private JSONValue  extraUnitToJSON()
      {
        JSONValueHandler handler_Unit = new JSONValueHandler();
        storeUnit.write_as_json(handler_Unit);
        return handler_Unit.result;
      }

    private JSONValue  extraTimeToJSON()
      {
        JSONValueHandler handler_Time = new JSONValueHandler();
        storeTime.write_as_json(handler_Time);
        return handler_Time.result;
      }


    private void  fromJSONIsDead(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsDead of PersonAttributeHeightJSON is not true for false.");
              }
          }
        setIsDead(the_bool);
      }


    private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UnitOfMeasureJSON convert_classy = UnitOfMeasureJSON.from_json(json_value, ignore_extras, true);
        setUnit(convert_classy);
      }


    private void  fromJSONTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setTime(convert_classy);
      }


    public PersonAttributeHeightJSON()
      {
        flagHasIsDead = false;
        flagHasUnit = false;
        flagHasTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPersonAttribute()
      {
        return "Height";
      }

    public bool  hasIsDead()
      {
        return flagHasIsDead;
      }

    public bool  getIsDead()
      {
        Debug.Assert(flagHasIsDead);
        return storeIsDead;
      }

    public bool  hasUnit()
      {
        return flagHasUnit;
      }

    public UnitOfMeasureJSON   getUnit()
      {
        Debug.Assert(flagHasUnit);
        return storeUnit;
      }

    public UnitOfMeasureJSON.TypeValue  getUnitValue()
      {
        return getUnit().getValue();
      }

    public string  getUnitAsString()
      {
        return getUnit().getValueAsString();
      }

    public bool  hasTime()
      {
        return flagHasTime;
      }

    public DateAndOrTimeJSON   getTime()
      {
        Debug.Assert(flagHasTime);
        return storeTime;
      }


    public virtual int extraPersonAttributeHeightComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPersonAttributeHeightComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPersonAttributeHeightComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPersonAttributeHeightLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPersonAttributeAmountComponentCount()
      {
        int result = 0;
        if (flagHasIsDead)
            ++result;
        if (flagHasUnit)
            ++result;
        if (flagHasTime)
            ++result;
        result += extraPersonAttributeHeightComponentCount();
        return result;
      }
    public override string extraPersonAttributeAmountComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasIsDead)
          {
            if (remainder == 0)
                return "IsDead";
            --remainder;
          }
        if (flagHasUnit)
          {
            if (remainder == 0)
                return "Unit";
            --remainder;
          }
        if (flagHasTime)
          {
            if (remainder == 0)
                return "Time";
            --remainder;
          }
        return extraPersonAttributeHeightComponentKey(remainder);
      }
    public override JSONValue extraPersonAttributeAmountComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasIsDead)
          {
            if (remainder == 0)
                return extraIsDeadToJSON();
            --remainder;
          }
        if (flagHasUnit)
          {
            if (remainder == 0)
                return extraUnitToJSON();
            --remainder;
          }
        if (flagHasTime)
          {
            if (remainder == 0)
                return extraTimeToJSON();
            --remainder;
          }
        return extraPersonAttributeHeightComponentValue(remainder);
      }
    public override JSONValue extraPersonAttributeAmountLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "sDead", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasIsDead ? extraIsDeadToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "ime", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasTime ? extraTimeToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasUnit ? extraUnitToJSON() : null);
                break;
            default:
                break;
          }
        return extraPersonAttributeHeightLookup(field_name);
      }

    public void setIsDead(bool new_value)
      {
        flagHasIsDead = true;
        storeIsDead = new_value;
      }
    public void unsetIsDead()
      {
        flagHasIsDead = false;
      }
    public void setUnit(UnitOfMeasureJSON  new_value)
      {
        if (flagHasUnit)
          {
          }
        flagHasUnit = true;
        storeUnit = new_value;
      }
    public void setUnit(UnitOfMeasureJSON.TypeValue new_value)
      {
        setUnit(new UnitOfMeasureJSON(new_value));
      }
    public void setUnit(string chars)
      {
        UnitOfMeasureJSON.TypeValueKnownValues known = UnitOfMeasureJSON.stringToValue(chars);
        UnitOfMeasureJSON.TypeValue new_value = new UnitOfMeasureJSON.TypeValue();
        if (known == UnitOfMeasureJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setUnit(new_value);
      }
    public void unsetUnit()
      {
        if (flagHasUnit)
          {
          }
        flagHasUnit = false;
      }
    public void setTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasTime)
          {
          }
        flagHasTime = true;
        storeTime = new_value;
      }
    public void unsetTime()
      {
        if (flagHasTime)
          {
          }
        flagHasTime = false;
      }

    public virtual void extraPersonAttributeHeightAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPersonAttributeHeightSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPersonAttributeHeightLookup(key);
        if (old_field == null)
          {
            extraPersonAttributeHeightAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "sDead", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONIsDead(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "ime", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONTime(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "nit", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONUnit(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraPersonAttributeHeightAppendPair(key, new_component);
      }
    public override void extraPersonAttributeAmountSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "sDead", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONIsDead(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "ime", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONTime(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "nit", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONUnit(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraPersonAttributeHeightSetField(key, new_component);
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
        if (flagHasIsDead)
          {
            handler.start_pair("IsDead");
            handler.boolean_value(storeIsDead);
          }
        if (flagHasUnit)
          {
            handler.start_pair("Unit");
            if (partial_allowed)
                storeUnit.write_partial_as_json(handler);
            else
                storeUnit.write_as_json(handler);
          }
        if (flagHasTime)
          {
            handler.start_pair("Time");
            if (partial_allowed)
                storeTime.write_partial_as_json(handler);
            else
                storeTime.write_as_json(handler);
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

    public static new PersonAttributeHeightJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeHeightJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeHeight", ignore_extras);
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
    public static new PersonAttributeHeightJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonAttributeHeightJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeHeightJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeHeight", ignore_extras);
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
    public static new PersonAttributeHeightJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonAttributeHeightJSON from_text(string text, bool ignore_extras)
      {
        PersonAttributeHeightJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeHeight", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonAttributeHeightJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PersonAttributeHeightJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonAttributeHeightJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeHeight", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PersonAttributeAmountJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorIsDead;
        private UnitOfMeasureJSON.HoldingGenerator fieldGeneratorUnit;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorTime;
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
            if (!(getPersonAttributeAmountJSONKey().Equals("Height")))
                throw new Exception("The key field has a value other than `Height'.");
            PersonAttributeHeightJSON result = new PersonAttributeHeightJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonAttributeHeightAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PersonAttributeAmountJSON new_result)
          {
            handle_result((PersonAttributeHeightJSON )new_result);
          }
        protected void finish(PersonAttributeHeightJSON result)
          {
            if (fieldGeneratorIsDead.have_value)
              {
                result.setIsDead(fieldGeneratorIsDead.value);
                fieldGeneratorIsDead.have_value = false;
              }
            if (fieldGeneratorUnit.have_value)
              {
                result.setUnit(fieldGeneratorUnit.value);
                fieldGeneratorUnit.have_value = false;
              }
            if (fieldGeneratorTime.have_value)
              {
                result.setTime(fieldGeneratorTime.value);
                fieldGeneratorTime.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(PersonAttributeHeightJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "sDead", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorIsDead;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ime", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorTime;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorUnit;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorIsDead = new JSONHoldingBooleanGenerator("field \"IsDead\" of the PersonAttributeHeight class");
            fieldGeneratorUnit = new UnitOfMeasureJSON.HoldingGenerator("field \"Unit\" of the PersonAttributeHeight class", ignore_extras);
            fieldGeneratorTime = new DateAndOrTimeJSON.HoldingGenerator("field \"Time\" of the PersonAttributeHeight class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PersonAttributeHeight class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorIsDead = new JSONHoldingBooleanGenerator("field \"IsDead\" of the PersonAttributeHeight class");
            fieldGeneratorUnit = new UnitOfMeasureJSON.HoldingGenerator("field \"Unit\" of the PersonAttributeHeight class", false);
            fieldGeneratorTime = new DateAndOrTimeJSON.HoldingGenerator("field \"Time\" of the PersonAttributeHeight class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PersonAttributeHeight class");
          }

        public override void reset()
          {
            fieldGeneratorIsDead.reset();
            fieldGeneratorUnit.reset();
            fieldGeneratorTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonAttributeHeightJSON  result)
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
        public PersonAttributeHeightJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonAttributeHeightJSON  result)
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
    protected virtual void handle_result(List<PersonAttributeHeightJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonAttributeHeightJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonAttributeHeightJSON>();
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
    public List<PersonAttributeHeightJSON> value;
  };
  };
