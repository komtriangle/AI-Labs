/* file "MoonPhaseAtTimeInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MoonPhaseAtTimeInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    private bool flagHasDateTimeSpec;
    private DateTimeSpecJSON  storeDateTimeSpec;
    private bool flagHasMoonPhasePct;
    private sbyte storeMoonPhasePct;
    private bool flagHasMoonPhase;
    private string storeMoonPhase;
    private bool flagHasRequestedDateTimeInThePast;
    private bool storeRequestedDateTimeInThePast;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDateTimeSpecToJSON()
      {
        JSONValueHandler handler_DateTimeSpec = new JSONValueHandler();
        storeDateTimeSpec.write_as_json(handler_DateTimeSpec);
        return handler_DateTimeSpec.result;
      }

    private JSONValue  extraMoonPhasePctToJSON()
      {
        JSONIntegerValue generated_integer_MoonPhasePct = new JSONIntegerValue(storeMoonPhasePct);
        return generated_integer_MoonPhasePct;
      }

    private JSONValue  extraMoonPhaseToJSON()
      {
        JSONStringValue generated_string_MoonPhase = new JSONStringValue(storeMoonPhase);
        return generated_string_MoonPhase;
      }

    private JSONValue  extraRequestedDateTimeInThePastToJSON()
      {
        JSONValue generated_boolean_RequestedDateTimeInThePast = (storeRequestedDateTimeInThePast ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestedDateTimeInThePast;
      }


    private void  fromJSONDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateTimeSpec(convert_classy);
      }


    private void  fromJSONMoonPhasePct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MoonPhasePct of MoonPhaseAtTimeInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MoonPhasePct of MoonPhaseAtTimeInformationNuggetJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setMoonPhasePct(extracted_integer);
      }


    private void  fromJSONMoonPhase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MoonPhase of MoonPhaseAtTimeInformationNuggetJSON is not a string.");
        setMoonPhase(json_string.getData());
      }


    private void  fromJSONRequestedDateTimeInThePast(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestedDateTimeInThePast of MoonPhaseAtTimeInformationNuggetJSON is not true for false.");
              }
          }
        setRequestedDateTimeInThePast(the_bool);
      }


    public MoonPhaseAtTimeInformationNuggetJSON()
      {
        flagHasDateTimeSpec = false;
        flagHasMoonPhasePct = false;
        flagHasMoonPhase = false;
        flagHasRequestedDateTimeInThePast = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "MoonPhaseAtTime";
      }

    public bool  hasDateTimeSpec()
      {
        return flagHasDateTimeSpec;
      }

    public DateTimeSpecJSON   getDateTimeSpec()
      {
        Debug.Assert(flagHasDateTimeSpec);
        return storeDateTimeSpec;
      }

    public bool  hasMoonPhasePct()
      {
        return flagHasMoonPhasePct;
      }

    public sbyte  getMoonPhasePct()
      {
        Debug.Assert(flagHasMoonPhasePct);
        return storeMoonPhasePct;
      }

    public bool  hasMoonPhase()
      {
        return flagHasMoonPhase;
      }

    public string  getMoonPhase()
      {
        Debug.Assert(flagHasMoonPhase);
        return storeMoonPhase;
      }

    public bool  hasRequestedDateTimeInThePast()
      {
        return flagHasRequestedDateTimeInThePast;
      }

    public bool  getRequestedDateTimeInThePast()
      {
        Debug.Assert(flagHasRequestedDateTimeInThePast);
        return storeRequestedDateTimeInThePast;
      }


    public virtual int extraMoonPhaseAtTimeInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMoonPhaseAtTimeInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMoonPhaseAtTimeInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMoonPhaseAtTimeInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasDateTimeSpec)
            ++result;
        if (flagHasMoonPhasePct)
            ++result;
        if (flagHasMoonPhase)
            ++result;
        if (flagHasRequestedDateTimeInThePast)
            ++result;
        result += extraMoonPhaseAtTimeInformationNuggetComponentCount();
        return result;
      }
    public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDateTimeSpec)
          {
            if (remainder == 0)
                return "DateTimeSpec";
            --remainder;
          }
        if (flagHasMoonPhasePct)
          {
            if (remainder == 0)
                return "MoonPhasePct";
            --remainder;
          }
        if (flagHasMoonPhase)
          {
            if (remainder == 0)
                return "MoonPhase";
            --remainder;
          }
        if (flagHasRequestedDateTimeInThePast)
          {
            if (remainder == 0)
                return "RequestedDateTimeInThePast";
            --remainder;
          }
        return extraMoonPhaseAtTimeInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDateTimeSpec)
          {
            if (remainder == 0)
                return extraDateTimeSpecToJSON();
            --remainder;
          }
        if (flagHasMoonPhasePct)
          {
            if (remainder == 0)
                return extraMoonPhasePctToJSON();
            --remainder;
          }
        if (flagHasMoonPhase)
          {
            if (remainder == 0)
                return extraMoonPhaseToJSON();
            --remainder;
          }
        if (flagHasRequestedDateTimeInThePast)
          {
            if (remainder == 0)
                return extraRequestedDateTimeInThePastToJSON();
            --remainder;
          }
        return extraMoonPhaseAtTimeInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "ateTimeSpec", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasDateTimeSpec ? extraDateTimeSpecToJSON() : null);
                break;
            case 'M':
                if (String.Compare(field_name, 1, "oonPhase", 0, 8, false) == 0)
                  {
                    if (field_name.Length == 9)
                      {
                        return (flagHasMoonPhase ? extraMoonPhaseToJSON() : null);
                      }
                    switch (field_name[9])
                      {
                        case 'P':
                            if ((String.Compare(field_name, 10, "ct", 0, 2, false) == 0) && (field_name.Length == 12))
                                return (flagHasMoonPhasePct ? extraMoonPhasePctToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equestedDateTimeInThePast", 0, 25, false) == 0) && (field_name.Length == 26))
                    return (flagHasRequestedDateTimeInThePast ? extraRequestedDateTimeInThePastToJSON() : null);
                break;
            default:
                break;
          }
        return extraMoonPhaseAtTimeInformationNuggetLookup(field_name);
      }

    public void setDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasDateTimeSpec)
          {
          }
        flagHasDateTimeSpec = true;
        storeDateTimeSpec = new_value;
      }
    public void unsetDateTimeSpec()
      {
        if (flagHasDateTimeSpec)
          {
          }
        flagHasDateTimeSpec = false;
      }
    public void setMoonPhasePct(sbyte new_value)
      {
        flagHasMoonPhasePct = true;
        if (new_value < 0)
            throw new Exception("The value for field MoonPhasePct of MoonPhaseAtTimeInformationNuggetJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field MoonPhasePct of MoonPhaseAtTimeInformationNuggetJSON is greater than the upper bound (100) for that field.");
        storeMoonPhasePct = new_value;
      }
    public void unsetMoonPhasePct()
      {
        flagHasMoonPhasePct = false;
      }
    public void setMoonPhase(string new_value)
      {
        flagHasMoonPhase = true;
        storeMoonPhase = new_value;
      }
    public void unsetMoonPhase()
      {
        flagHasMoonPhase = false;
      }
    public void setRequestedDateTimeInThePast(bool new_value)
      {
        flagHasRequestedDateTimeInThePast = true;
        storeRequestedDateTimeInThePast = new_value;
      }
    public void unsetRequestedDateTimeInThePast()
      {
        flagHasRequestedDateTimeInThePast = false;
      }

    public virtual void extraMoonPhaseAtTimeInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMoonPhaseAtTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMoonPhaseAtTimeInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraMoonPhaseAtTimeInformationNuggetAppendPair(key, new_component);
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
    public override void extraDateAndTimeInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ateTimeSpec", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONDateTimeSpec(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "oonPhase", 0, 8, false) == 0)
                  {
                    if (key.Length == 9)
                      {
                        {
                        fromJSONMoonPhase(new_component, false);
                        return;
                        }
                      }
                    switch (key[9])
                      {
                        case 'P':
                            if ((String.Compare(key, 10, "ct", 0, 2, false) == 0) && (key.Length == 12))
                                {
                                fromJSONMoonPhasePct(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedDateTimeInThePast", 0, 25, false) == 0) && (key.Length == 26))
                    {
                    fromJSONRequestedDateTimeInThePast(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMoonPhaseAtTimeInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ateTimeSpec", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONDateTimeSpec(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "oonPhase", 0, 8, false) == 0)
                  {
                    if (key.Length == 9)
                      {
                        {
                        fromJSONMoonPhase(new_component, false);
                        return;
                        }
                      }
                    switch (key[9])
                      {
                        case 'P':
                            if ((String.Compare(key, 10, "ct", 0, 2, false) == 0) && (key.Length == 12))
                                {
                                fromJSONMoonPhasePct(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedDateTimeInThePast", 0, 25, false) == 0) && (key.Length == 26))
                    {
                    fromJSONRequestedDateTimeInThePast(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMoonPhaseAtTimeInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDateTimeSpec);
        if (flagHasDateTimeSpec)
          {
            handler.start_pair("DateTimeSpec");
            if (partial_allowed)
                storeDateTimeSpec.write_partial_as_json(handler);
            else
                storeDateTimeSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasMoonPhasePct);
        if (flagHasMoonPhasePct)
          {
            handler.start_pair("MoonPhasePct");
            handler.number_value(storeMoonPhasePct);
          }
        Debug.Assert(partial_allowed || flagHasMoonPhase);
        if (flagHasMoonPhase)
          {
            handler.start_pair("MoonPhase");
            handler.string_value(storeMoonPhase);
          }
        Debug.Assert(partial_allowed || flagHasRequestedDateTimeInThePast);
        if (flagHasRequestedDateTimeInThePast)
          {
            handler.start_pair("RequestedDateTimeInThePast");
            handler.boolean_value(storeRequestedDateTimeInThePast);
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
        if (!(hasDateTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DateTimeSpec\" field was missing.";
          }
        if (!(hasMoonPhasePct()))
          {
            return "When parsing the object for %what%, the \"MoonPhasePct\" field was missing.";
          }
        if (!(hasMoonPhase()))
          {
            return "When parsing the object for %what%, the \"MoonPhase\" field was missing.";
          }
        if (!(hasRequestedDateTimeInThePast()))
          {
            return "When parsing the object for %what%, the \"RequestedDateTimeInThePast\" field was missing.";
          }
        return null;
      }

    public static new MoonPhaseAtTimeInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MoonPhaseAtTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MoonPhaseAtTimeInformationNugget", ignore_extras);
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
    public static new MoonPhaseAtTimeInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MoonPhaseAtTimeInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MoonPhaseAtTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MoonPhaseAtTimeInformationNugget", ignore_extras);
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
    public static new MoonPhaseAtTimeInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MoonPhaseAtTimeInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        MoonPhaseAtTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MoonPhaseAtTimeInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MoonPhaseAtTimeInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MoonPhaseAtTimeInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MoonPhaseAtTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MoonPhaseAtTimeInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorDateTimeSpec;
    private class FieldHoldingGeneratorMoonPhasePct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorMoonPhasePct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorMoonPhasePct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorMoonPhasePct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorMoonPhasePct fieldGeneratorMoonPhasePct;
        private JSONHoldingStringGenerator fieldGeneratorMoonPhase;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestedDateTimeInThePast;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("MoonPhaseAtTime")))
                throw new Exception("The key field has a value other than `MoonPhaseAtTime'.");
            MoonPhaseAtTimeInformationNuggetJSON result = new MoonPhaseAtTimeInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMoonPhaseAtTimeInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((MoonPhaseAtTimeInformationNuggetJSON )new_result);
          }
        protected void finish(MoonPhaseAtTimeInformationNuggetJSON result)
          {
            if (fieldGeneratorDateTimeSpec.have_value)
              {
                result.setDateTimeSpec(fieldGeneratorDateTimeSpec.value);
                fieldGeneratorDateTimeSpec.have_value = false;
              }
            else if ((!(result.hasDateTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateTimeSpec\" field was missing.");
              }
            if (fieldGeneratorMoonPhasePct.have_value)
              {
                result.setMoonPhasePct((sbyte)(fieldGeneratorMoonPhasePct.value));
                fieldGeneratorMoonPhasePct.have_value = false;
              }
            else if ((!(result.hasMoonPhasePct())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MoonPhasePct\" field was missing.");
              }
            if (fieldGeneratorMoonPhase.have_value)
              {
                result.setMoonPhase(fieldGeneratorMoonPhase.value);
                fieldGeneratorMoonPhase.have_value = false;
              }
            else if ((!(result.hasMoonPhase())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MoonPhase\" field was missing.");
              }
            if (fieldGeneratorRequestedDateTimeInThePast.have_value)
              {
                result.setRequestedDateTimeInThePast(fieldGeneratorRequestedDateTimeInThePast.value);
                fieldGeneratorRequestedDateTimeInThePast.have_value = false;
              }
            else if ((!(result.hasRequestedDateTimeInThePast())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedDateTimeInThePast\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MoonPhaseAtTimeInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ateTimeSpec", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorDateTimeSpec;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "oonPhase", 0, 8, false) == 0)
                      {
                        if (field_name.Length == 9)
                          {
                            return fieldGeneratorMoonPhase;
                          }
                        switch (field_name[9])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 10, "ct", 0, 2, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorMoonPhasePct;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedDateTimeInThePast", 0, 25, false) == 0) && (field_name.Length == 26))
                        return fieldGeneratorRequestedDateTimeInThePast;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"DateTimeSpec\" of the MoonPhaseAtTimeInformationNugget class", ignore_extras);
            fieldGeneratorMoonPhasePct = new FieldHoldingGeneratorMoonPhasePct("field \"MoonPhasePct\" of the MoonPhaseAtTimeInformationNugget class");
            fieldGeneratorMoonPhase = new JSONHoldingStringGenerator("field \"MoonPhase\" of the MoonPhaseAtTimeInformationNugget class");
            fieldGeneratorRequestedDateTimeInThePast = new JSONHoldingBooleanGenerator("field \"RequestedDateTimeInThePast\" of the MoonPhaseAtTimeInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MoonPhaseAtTimeInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"DateTimeSpec\" of the MoonPhaseAtTimeInformationNugget class", false);
            fieldGeneratorMoonPhasePct = new FieldHoldingGeneratorMoonPhasePct("field \"MoonPhasePct\" of the MoonPhaseAtTimeInformationNugget class");
            fieldGeneratorMoonPhase = new JSONHoldingStringGenerator("field \"MoonPhase\" of the MoonPhaseAtTimeInformationNugget class");
            fieldGeneratorRequestedDateTimeInThePast = new JSONHoldingBooleanGenerator("field \"RequestedDateTimeInThePast\" of the MoonPhaseAtTimeInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MoonPhaseAtTimeInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorDateTimeSpec.reset();
            fieldGeneratorMoonPhasePct.reset();
            fieldGeneratorMoonPhase.reset();
            fieldGeneratorRequestedDateTimeInThePast.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MoonPhaseAtTimeInformationNuggetJSON  result)
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
        public MoonPhaseAtTimeInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MoonPhaseAtTimeInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<MoonPhaseAtTimeInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MoonPhaseAtTimeInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MoonPhaseAtTimeInformationNuggetJSON>();
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
    public List<MoonPhaseAtTimeInformationNuggetJSON> value;
  };
  };
