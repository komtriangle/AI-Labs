/* file "UnknownChemicalElementGroupQueryInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UnknownChemicalElementGroupQueryInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasGroupNumber;
    private BigInteger storeGroupNumber;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraGroupNumberToJSON()
      {
        JSONIntegerValue generated_integer_GroupNumber = new JSONIntegerValue(storeGroupNumber);
        return generated_integer_GroupNumber;
      }


    private void  fromJSONGroupNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GroupNumber of UnknownChemicalElementGroupQueryInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GroupNumber of UnknownChemicalElementGroupQueryInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGroupNumber(extracted_integer);
      }


    public UnknownChemicalElementGroupQueryInformationNuggetJSON()
      {
        flagHasGroupNumber = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "UnknownChemicalElementGroupQueryInformationNugget";
      }

    public bool  hasGroupNumber()
      {
        return flagHasGroupNumber;
      }

    public BigInteger  getGroupNumber()
      {
        Debug.Assert(flagHasGroupNumber);
        return storeGroupNumber;
      }


    public virtual int extraUnknownChemicalElementGroupQueryInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUnknownChemicalElementGroupQueryInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUnknownChemicalElementGroupQueryInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUnknownChemicalElementGroupQueryInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasGroupNumber)
            ++result;
        result += extraUnknownChemicalElementGroupQueryInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasGroupNumber)
          {
            if (remainder == 0)
                return "GroupNumber";
            --remainder;
          }
        return extraUnknownChemicalElementGroupQueryInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasGroupNumber)
          {
            if (remainder == 0)
                return extraGroupNumberToJSON();
            --remainder;
          }
        return extraUnknownChemicalElementGroupQueryInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "GroupNumber", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasGroupNumber ? extraGroupNumberToJSON() : null);
        return extraUnknownChemicalElementGroupQueryInformationNuggetLookup(field_name);
      }

    public void setGroupNumber(BigInteger new_value)
      {
        flagHasGroupNumber = true;
        storeGroupNumber = new_value;
      }
    public void unsetGroupNumber()
      {
        flagHasGroupNumber = false;
      }

    public virtual void extraUnknownChemicalElementGroupQueryInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUnknownChemicalElementGroupQueryInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUnknownChemicalElementGroupQueryInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraUnknownChemicalElementGroupQueryInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "GroupNumber", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONGroupNumber(new_component, false);
            return;
            }
        extraUnknownChemicalElementGroupQueryInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "GroupNumber", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONGroupNumber(new_component, false);
            return;
            }
        extraUnknownChemicalElementGroupQueryInformationNuggetSetField(key, new_component);
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
        if (flagHasGroupNumber)
          {
            handler.start_pair("GroupNumber");
            handler.number_value(storeGroupNumber);
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

    public static new UnknownChemicalElementGroupQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnknownChemicalElementGroupQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnknownChemicalElementGroupQueryInformationNugget", ignore_extras);
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
    public static new UnknownChemicalElementGroupQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UnknownChemicalElementGroupQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnknownChemicalElementGroupQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnknownChemicalElementGroupQueryInformationNugget", ignore_extras);
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
    public static new UnknownChemicalElementGroupQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UnknownChemicalElementGroupQueryInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        UnknownChemicalElementGroupQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnknownChemicalElementGroupQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UnknownChemicalElementGroupQueryInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UnknownChemicalElementGroupQueryInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UnknownChemicalElementGroupQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnknownChemicalElementGroupQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private class FieldHoldingGeneratorGroupNumber : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorGroupNumber(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorGroupNumber : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorGroupNumber(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorGroupNumber fieldGeneratorGroupNumber;
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
            if (!(getInformationNuggetJSONKey().Equals("UnknownChemicalElementGroupQueryInformationNugget")))
                throw new Exception("The key field has a value other than `UnknownChemicalElementGroupQueryInformationNugget'.");
            UnknownChemicalElementGroupQueryInformationNuggetJSON result = new UnknownChemicalElementGroupQueryInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUnknownChemicalElementGroupQueryInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((UnknownChemicalElementGroupQueryInformationNuggetJSON )new_result);
          }
        protected void finish(UnknownChemicalElementGroupQueryInformationNuggetJSON result)
          {
            if (fieldGeneratorGroupNumber.have_value)
              {
                result.setGroupNumber(fieldGeneratorGroupNumber.value);
                fieldGeneratorGroupNumber.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(UnknownChemicalElementGroupQueryInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "GroupNumber", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorGroupNumber;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorGroupNumber = new FieldHoldingGeneratorGroupNumber("field \"GroupNumber\" of the UnknownChemicalElementGroupQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UnknownChemicalElementGroupQueryInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorGroupNumber = new FieldHoldingGeneratorGroupNumber("field \"GroupNumber\" of the UnknownChemicalElementGroupQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UnknownChemicalElementGroupQueryInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorGroupNumber.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UnknownChemicalElementGroupQueryInformationNuggetJSON  result)
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
        public UnknownChemicalElementGroupQueryInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UnknownChemicalElementGroupQueryInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<UnknownChemicalElementGroupQueryInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UnknownChemicalElementGroupQueryInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UnknownChemicalElementGroupQueryInformationNuggetJSON>();
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
    public List<UnknownChemicalElementGroupQueryInformationNuggetJSON> value;
  };
  };
