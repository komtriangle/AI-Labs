/* file "FullStringBuildingNumberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FullStringBuildingNumberJSON : BuildingNumberJSON
  {
    private bool flagHasBuildingNumber;
    private BigInteger storeBuildingNumber;
    private bool flagHasFullBuildingNumberString;
    private string storeFullBuildingNumberString;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraBuildingNumberToJSON()
      {
        JSONIntegerValue generated_integer_BuildingNumber = new JSONIntegerValue(storeBuildingNumber);
        return generated_integer_BuildingNumber;
      }

    private JSONValue  extraFullBuildingNumberStringToJSON()
      {
        JSONStringValue generated_string_FullBuildingNumberString = new JSONStringValue(storeFullBuildingNumberString);
        return generated_string_FullBuildingNumberString;
      }


    private void  fromJSONBuildingNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field BuildingNumber of FullStringBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field BuildingNumber of FullStringBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setBuildingNumber(extracted_integer);
      }


    private void  fromJSONFullBuildingNumberString(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FullBuildingNumberString of FullStringBuildingNumberJSON is not a string.");
        setFullBuildingNumberString(json_string.getData());
      }


    public FullStringBuildingNumberJSON()
      {
        flagHasBuildingNumber = false;
        flagHasFullBuildingNumberString = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getKind()
      {
        return "FullStringBuildingNumber";
      }

    public bool  hasBuildingNumber()
      {
        return flagHasBuildingNumber;
      }

    public BigInteger  getBuildingNumber()
      {
        Debug.Assert(flagHasBuildingNumber);
        return storeBuildingNumber;
      }

    public bool  hasFullBuildingNumberString()
      {
        return flagHasFullBuildingNumberString;
      }

    public string  getFullBuildingNumberString()
      {
        Debug.Assert(flagHasFullBuildingNumberString);
        return storeFullBuildingNumberString;
      }


    public virtual int extraFullStringBuildingNumberComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFullStringBuildingNumberComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFullStringBuildingNumberComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFullStringBuildingNumberLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraBuildingNumberComponentCount()
      {
        int result = 0;
        if (flagHasBuildingNumber)
            ++result;
        if (flagHasFullBuildingNumberString)
            ++result;
        result += extraFullStringBuildingNumberComponentCount();
        return result;
      }
    public override string extraBuildingNumberComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasBuildingNumber)
          {
            if (remainder == 0)
                return "BuildingNumber";
            --remainder;
          }
        if (flagHasFullBuildingNumberString)
          {
            if (remainder == 0)
                return "FullBuildingNumberString";
            --remainder;
          }
        return extraFullStringBuildingNumberComponentKey(remainder);
      }
    public override JSONValue extraBuildingNumberComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasBuildingNumber)
          {
            if (remainder == 0)
                return extraBuildingNumberToJSON();
            --remainder;
          }
        if (flagHasFullBuildingNumberString)
          {
            if (remainder == 0)
                return extraFullBuildingNumberStringToJSON();
            --remainder;
          }
        return extraFullStringBuildingNumberComponentValue(remainder);
      }
    public override JSONValue extraBuildingNumberLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'B':
                if ((String.Compare(field_name, 1, "uildingNumber", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasBuildingNumber ? extraBuildingNumberToJSON() : null);
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "ullBuildingNumberString", 0, 23, false) == 0) && (field_name.Length == 24))
                    return (flagHasFullBuildingNumberString ? extraFullBuildingNumberStringToJSON() : null);
                break;
            default:
                break;
          }
        return extraFullStringBuildingNumberLookup(field_name);
      }

    public void setBuildingNumber(BigInteger new_value)
      {
        flagHasBuildingNumber = true;
        storeBuildingNumber = new_value;
      }
    public void unsetBuildingNumber()
      {
        flagHasBuildingNumber = false;
      }
    public void setFullBuildingNumberString(string new_value)
      {
        flagHasFullBuildingNumberString = true;
        storeFullBuildingNumberString = new_value;
      }
    public void unsetFullBuildingNumberString()
      {
        flagHasFullBuildingNumberString = false;
      }

    public virtual void extraFullStringBuildingNumberAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFullStringBuildingNumberSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFullStringBuildingNumberLookup(key);
        if (old_field == null)
          {
            extraFullStringBuildingNumberAppendPair(key, new_component);
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
    public override void extraBuildingNumberAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "uildingNumber", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONBuildingNumber(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ullBuildingNumberString", 0, 23, false) == 0) && (key.Length == 24))
                    {
                    fromJSONFullBuildingNumberString(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFullStringBuildingNumberAppendPair(key, new_component);
      }
    public override void extraBuildingNumberSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "uildingNumber", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONBuildingNumber(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ullBuildingNumberString", 0, 23, false) == 0) && (key.Length == 24))
                    {
                    fromJSONFullBuildingNumberString(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFullStringBuildingNumberSetField(key, new_component);
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
        if (flagHasBuildingNumber)
          {
            handler.start_pair("BuildingNumber");
            handler.number_value(storeBuildingNumber);
          }
        Debug.Assert(partial_allowed || flagHasFullBuildingNumberString);
        if (flagHasFullBuildingNumberString)
          {
            handler.start_pair("FullBuildingNumberString");
            handler.string_value(storeFullBuildingNumberString);
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
        if (!(hasFullBuildingNumberString()))
          {
            return "When parsing the object for %what%, the \"FullBuildingNumberString\" field was missing.";
          }
        return null;
      }

    public static new FullStringBuildingNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FullStringBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FullStringBuildingNumber", ignore_extras);
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
    public static new FullStringBuildingNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FullStringBuildingNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FullStringBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FullStringBuildingNumber", ignore_extras);
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
    public static new FullStringBuildingNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FullStringBuildingNumberJSON from_text(string text, bool ignore_extras)
      {
        FullStringBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FullStringBuildingNumber", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FullStringBuildingNumberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FullStringBuildingNumberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FullStringBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FullStringBuildingNumber", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : BuildingNumberJSON.Generator
      {
    private class FieldHoldingGeneratorBuildingNumber : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorBuildingNumber(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorBuildingNumber : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorBuildingNumber(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorBuildingNumber fieldGeneratorBuildingNumber;
        private JSONHoldingStringGenerator fieldGeneratorFullBuildingNumberString;
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
            if (!(getBuildingNumberJSONKey().Equals("FullStringBuildingNumber")))
                throw new Exception("The key field has a value other than `FullStringBuildingNumber'.");
            FullStringBuildingNumberJSON result = new FullStringBuildingNumberJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFullStringBuildingNumberAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(BuildingNumberJSON new_result)
          {
            handle_result((FullStringBuildingNumberJSON )new_result);
          }
        protected void finish(FullStringBuildingNumberJSON result)
          {
            if (fieldGeneratorBuildingNumber.have_value)
              {
                result.setBuildingNumber(fieldGeneratorBuildingNumber.value);
                fieldGeneratorBuildingNumber.have_value = false;
              }
            if (fieldGeneratorFullBuildingNumberString.have_value)
              {
                result.setFullBuildingNumberString(fieldGeneratorFullBuildingNumberString.value);
                fieldGeneratorFullBuildingNumberString.have_value = false;
              }
            else if ((!(result.hasFullBuildingNumberString())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FullBuildingNumberString\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(FullStringBuildingNumberJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "uildingNumber", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorBuildingNumber;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ullBuildingNumberString", 0, 23, false) == 0) && (field_name.Length == 24))
                        return fieldGeneratorFullBuildingNumberString;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorBuildingNumber = new FieldHoldingGeneratorBuildingNumber("field \"BuildingNumber\" of the FullStringBuildingNumber class");
            fieldGeneratorFullBuildingNumberString = new JSONHoldingStringGenerator("field \"FullBuildingNumberString\" of the FullStringBuildingNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FullStringBuildingNumber class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorBuildingNumber = new FieldHoldingGeneratorBuildingNumber("field \"BuildingNumber\" of the FullStringBuildingNumber class");
            fieldGeneratorFullBuildingNumberString = new JSONHoldingStringGenerator("field \"FullBuildingNumberString\" of the FullStringBuildingNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FullStringBuildingNumber class");
          }

        public override void reset()
          {
            fieldGeneratorBuildingNumber.reset();
            fieldGeneratorFullBuildingNumberString.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FullStringBuildingNumberJSON  result)
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
        public FullStringBuildingNumberJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FullStringBuildingNumberJSON  result)
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
    protected virtual void handle_result(List<FullStringBuildingNumberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FullStringBuildingNumberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FullStringBuildingNumberJSON>();
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
    public List<FullStringBuildingNumberJSON> value;
  };
  };
