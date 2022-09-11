/* file "DialNumberCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DialNumberCommandJSON : PhoneCommandJSON
  {
    private bool flagHasNumber;
    private string storeNumber;
    private bool flagHasNumberDerivation;
    private DerivationJSON  storeNumberDerivation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNumberToJSON()
      {
        JSONStringValue generated_string_Number = new JSONStringValue(storeNumber);
        return generated_string_Number;
      }

    private JSONValue  extraNumberDerivationToJSON()
      {
        JSONValueHandler handler_NumberDerivation = new JSONValueHandler();
        storeNumberDerivation.write_as_json(handler_NumberDerivation);
        return handler_NumberDerivation.result;
      }


    private void  fromJSONNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Number of DialNumberCommandJSON is not a string.");
        setNumber(json_string.getData());
      }


    private void  fromJSONNumberDerivation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DerivationJSON convert_classy = DerivationJSON.from_json(json_value, ignore_extras, true);
        setNumberDerivation(convert_classy);
      }


    public DialNumberCommandJSON()
      {
        flagHasNumber = false;
        flagHasNumberDerivation = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPhoneCommandKind()
      {
        return "DialNumber";
      }

    public bool  hasNumber()
      {
        return flagHasNumber;
      }

    public string  getNumber()
      {
        Debug.Assert(flagHasNumber);
        return storeNumber;
      }

    public bool  hasNumberDerivation()
      {
        return flagHasNumberDerivation;
      }

    public DerivationJSON   getNumberDerivation()
      {
        Debug.Assert(flagHasNumberDerivation);
        return storeNumberDerivation;
      }


    public virtual int extraDialNumberCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDialNumberCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDialNumberCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDialNumberCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPhoneCommandComponentCount()
      {
        int result = 0;
        if (flagHasNumber)
            ++result;
        if (flagHasNumberDerivation)
            ++result;
        result += extraDialNumberCommandComponentCount();
        return result;
      }
    public override string extraPhoneCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumber)
          {
            if (remainder == 0)
                return "Number";
            --remainder;
          }
        if (flagHasNumberDerivation)
          {
            if (remainder == 0)
                return "NumberDerivation";
            --remainder;
          }
        return extraDialNumberCommandComponentKey(remainder);
      }
    public override JSONValue extraPhoneCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumber)
          {
            if (remainder == 0)
                return extraNumberToJSON();
            --remainder;
          }
        if (flagHasNumberDerivation)
          {
            if (remainder == 0)
                return extraNumberDerivationToJSON();
            --remainder;
          }
        return extraDialNumberCommandComponentValue(remainder);
      }
    public override JSONValue extraPhoneCommandLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "Number", 0, 6, false) == 0)
          {
            if (field_name.Length == 6)
              {
                return (flagHasNumber ? extraNumberToJSON() : null);
              }
            switch (field_name[6])
              {
                case 'D':
                    if ((String.Compare(field_name, 7, "erivation", 0, 9, false) == 0) && (field_name.Length == 16))
                        return (flagHasNumberDerivation ? extraNumberDerivationToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraDialNumberCommandLookup(field_name);
      }

    public void setNumber(string new_value)
      {
        flagHasNumber = true;
        storeNumber = new_value;
      }
    public void unsetNumber()
      {
        flagHasNumber = false;
      }
    public void setNumberDerivation(DerivationJSON  new_value)
      {
        if (flagHasNumberDerivation)
          {
          }
        flagHasNumberDerivation = true;
        storeNumberDerivation = new_value;
      }
    public void unsetNumberDerivation()
      {
        if (flagHasNumberDerivation)
          {
          }
        flagHasNumberDerivation = false;
      }

    public virtual void extraDialNumberCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDialNumberCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDialNumberCommandLookup(key);
        if (old_field == null)
          {
            extraDialNumberCommandAppendPair(key, new_component);
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
    public override void extraPhoneCommandAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Number", 0, 6, false) == 0)
          {
            if (key.Length == 6)
              {
                {
                fromJSONNumber(new_component, false);
                return;
                }
              }
            switch (key[6])
              {
                case 'D':
                    if ((String.Compare(key, 7, "erivation", 0, 9, false) == 0) && (key.Length == 16))
                        {
                        fromJSONNumberDerivation(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraDialNumberCommandAppendPair(key, new_component);
      }
    public override void extraPhoneCommandSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Number", 0, 6, false) == 0)
          {
            if (key.Length == 6)
              {
                {
                fromJSONNumber(new_component, false);
                return;
                }
              }
            switch (key[6])
              {
                case 'D':
                    if ((String.Compare(key, 7, "erivation", 0, 9, false) == 0) && (key.Length == 16))
                        {
                        fromJSONNumberDerivation(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraDialNumberCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNumber);
        if (flagHasNumber)
          {
            handler.start_pair("Number");
            handler.string_value(storeNumber);
          }
        Debug.Assert(partial_allowed || flagHasNumberDerivation);
        if (flagHasNumberDerivation)
          {
            handler.start_pair("NumberDerivation");
            if (partial_allowed)
                storeNumberDerivation.write_partial_as_json(handler);
            else
                storeNumberDerivation.write_as_json(handler);
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
        if (!(hasNumber()))
          {
            return "When parsing the object for %what%, the \"Number\" field was missing.";
          }
        if (!(hasNumberDerivation()))
          {
            return "When parsing the object for %what%, the \"NumberDerivation\" field was missing.";
          }
        return null;
      }

    public static new DialNumberCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DialNumberCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DialNumberCommand", ignore_extras);
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
    public static new DialNumberCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DialNumberCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DialNumberCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DialNumberCommand", ignore_extras);
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
    public static new DialNumberCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DialNumberCommandJSON from_text(string text, bool ignore_extras)
      {
        DialNumberCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DialNumberCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DialNumberCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DialNumberCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DialNumberCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DialNumberCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PhoneCommandJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorNumber;
        private DerivationJSON.HoldingGenerator fieldGeneratorNumberDerivation;
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
            if (!(getPhoneCommandJSONKey().Equals("DialNumber")))
                throw new Exception("The key field has a value other than `DialNumber'.");
            DialNumberCommandJSON result = new DialNumberCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDialNumberCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PhoneCommandJSON new_result)
          {
            handle_result((DialNumberCommandJSON )new_result);
          }
        protected void finish(DialNumberCommandJSON result)
          {
            if (fieldGeneratorNumber.have_value)
              {
                result.setNumber(fieldGeneratorNumber.value);
                fieldGeneratorNumber.have_value = false;
              }
            else if ((!(result.hasNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Number\" field was missing.");
              }
            if (fieldGeneratorNumberDerivation.have_value)
              {
                result.setNumberDerivation(fieldGeneratorNumberDerivation.value);
                fieldGeneratorNumberDerivation.have_value = false;
              }
            else if ((!(result.hasNumberDerivation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NumberDerivation\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(DialNumberCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Number", 0, 6, false) == 0)
              {
                if (field_name.Length == 6)
                  {
                    return fieldGeneratorNumber;
                  }
                switch (field_name[6])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 7, "erivation", 0, 9, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorNumberDerivation;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the DialNumberCommand class");
            fieldGeneratorNumberDerivation = new DerivationJSON.HoldingGenerator("field \"NumberDerivation\" of the DialNumberCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DialNumberCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the DialNumberCommand class");
            fieldGeneratorNumberDerivation = new DerivationJSON.HoldingGenerator("field \"NumberDerivation\" of the DialNumberCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DialNumberCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNumber.reset();
            fieldGeneratorNumberDerivation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DialNumberCommandJSON  result)
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
        public DialNumberCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DialNumberCommandJSON  result)
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
    protected virtual void handle_result(List<DialNumberCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DialNumberCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DialNumberCommandJSON>();
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
    public List<DialNumberCommandJSON> value;
  };
  };
