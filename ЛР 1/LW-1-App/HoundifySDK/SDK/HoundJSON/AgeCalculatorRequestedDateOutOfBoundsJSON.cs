/* file "AgeCalculatorRequestedDateOutOfBoundsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AgeCalculatorRequestedDateOutOfBoundsJSON : CommandErrorJSON
  {
    public enum TypeDatesSpecified
      {
        DatesSpecified_Both,
        DatesSpecified_Born,
        DatesSpecified_Destination,
        DatesSpecified_None
      };

    public static TypeDatesSpecified  stringToDatesSpecified(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if (String.Compare(chars, 1, "o", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'r':
                            if ((String.Compare(chars, 3, "n", 0, 1, false) == 0) && (chars.Length == 4))
                                return TypeDatesSpecified.DatesSpecified_Born;
                            break;
                        case 't':
                            if ((String.Compare(chars, 3, "h", 0, 1, false) == 0) && (chars.Length == 4))
                                return TypeDatesSpecified.DatesSpecified_Both;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                if ((String.Compare(chars, 1, "estination", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeDatesSpecified.DatesSpecified_Destination;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeDatesSpecified.DatesSpecified_None;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `DatesSpecified' is not one of the legal values.");
      }

    public static string  stringFromDatesSpecified(TypeDatesSpecified the_enum)
      {
        switch (the_enum)
          {
            case TypeDatesSpecified.DatesSpecified_Both:
                return "Both";
            case TypeDatesSpecified.DatesSpecified_Born:
                return "Born";
            case TypeDatesSpecified.DatesSpecified_Destination:
                return "Destination";
            case TypeDatesSpecified.DatesSpecified_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDestinationIsNow;
    private bool storeDestinationIsNow;
    private bool flagHasDestinationIsToday;
    private bool storeDestinationIsToday;
    private bool flagHasDatesSpecified;
    private TypeDatesSpecified storeDatesSpecified;
    private bool flagHasPerspective;
    private AgeCalculatorPerspectiveJSON  storePerspective;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDestinationIsNowToJSON()
      {
        JSONValue generated_boolean_DestinationIsNow = (storeDestinationIsNow ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DestinationIsNow;
      }

    private JSONValue  extraDestinationIsTodayToJSON()
      {
        JSONValue generated_boolean_DestinationIsToday = (storeDestinationIsToday ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DestinationIsToday;
      }

    private JSONValue  extraDatesSpecifiedToJSON()
      {
        JSONStringValue generated_string_DatesSpecified;
        switch (storeDatesSpecified)
          {
            case TypeDatesSpecified.DatesSpecified_Both:
                generated_string_DatesSpecified = new JSONStringValue("Both");
                break;
            case TypeDatesSpecified.DatesSpecified_Born:
                generated_string_DatesSpecified = new JSONStringValue("Born");
                break;
            case TypeDatesSpecified.DatesSpecified_Destination:
                generated_string_DatesSpecified = new JSONStringValue("Destination");
                break;
            case TypeDatesSpecified.DatesSpecified_None:
                generated_string_DatesSpecified = new JSONStringValue("None");
                break;
            default:
                Debug.Assert(false);
                generated_string_DatesSpecified = null;
                break;
          }
        return generated_string_DatesSpecified;
      }

    private JSONValue  extraPerspectiveToJSON()
      {
        JSONValueHandler handler_Perspective = new JSONValueHandler();
        storePerspective.write_as_json(handler_Perspective);
        return handler_Perspective.result;
      }


    private void  fromJSONDestinationIsNow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DestinationIsNow of AgeCalculatorRequestedDateOutOfBoundsJSON is not true for false.");
              }
          }
        setDestinationIsNow(the_bool);
      }


    private void  fromJSONDestinationIsToday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DestinationIsToday of AgeCalculatorRequestedDateOutOfBoundsJSON is not true for false.");
              }
          }
        setDestinationIsToday(the_bool);
      }


    private void  fromJSONDatesSpecified(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DatesSpecified of AgeCalculatorRequestedDateOutOfBoundsJSON is not a string.");
        TypeDatesSpecified the_enum;
        switch (json_string.getData()[0])
          {
            case 'B':
                if (String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'r':
                            if ((String.Compare(json_string.getData(), 3, "n", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_enum = TypeDatesSpecified.DatesSpecified_Born;
                                    goto enum_is_done;
                                  }
                            break;
                        case 't':
                            if ((String.Compare(json_string.getData(), 3, "h", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_enum = TypeDatesSpecified.DatesSpecified_Both;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "estination", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeDatesSpecified.DatesSpecified_Destination;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeDatesSpecified.DatesSpecified_None;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field DatesSpecified of AgeCalculatorRequestedDateOutOfBoundsJSON is not one of the legal strings.");
      enum_is_done:;
        setDatesSpecified(the_enum);
      }


    private void  fromJSONPerspective(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AgeCalculatorPerspectiveJSON convert_classy = AgeCalculatorPerspectiveJSON.from_json(json_value, ignore_extras, true);
        setPerspective(convert_classy);
      }


    public AgeCalculatorRequestedDateOutOfBoundsJSON()
      {
        flagHasDestinationIsNow = false;
        flagHasDestinationIsToday = false;
        flagHasDatesSpecified = false;
        flagHasPerspective = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getErrorType()
      {
        return "AgeCalculatorRequestedDateOutOfBounds";
      }

    public bool  hasDestinationIsNow()
      {
        return flagHasDestinationIsNow;
      }

    public bool  getDestinationIsNow()
      {
        Debug.Assert(flagHasDestinationIsNow);
        return storeDestinationIsNow;
      }

    public bool  hasDestinationIsToday()
      {
        return flagHasDestinationIsToday;
      }

    public bool  getDestinationIsToday()
      {
        Debug.Assert(flagHasDestinationIsToday);
        return storeDestinationIsToday;
      }

    public bool  hasDatesSpecified()
      {
        return flagHasDatesSpecified;
      }

    public TypeDatesSpecified  getDatesSpecified()
      {
        Debug.Assert(flagHasDatesSpecified);
        return storeDatesSpecified;
      }

    public string  getDatesSpecifiedAsString()
      {
        return stringFromDatesSpecified(getDatesSpecified());
      }

    public bool  hasPerspective()
      {
        return flagHasPerspective;
      }

    public AgeCalculatorPerspectiveJSON   getPerspective()
      {
        Debug.Assert(flagHasPerspective);
        return storePerspective;
      }

    public AgeCalculatorPerspectiveJSON.TypeValue  getPerspectiveValue()
      {
        return getPerspective().getValue();
      }

    public string  getPerspectiveAsString()
      {
        return getPerspective().getValueAsString();
      }


    public virtual int extraAgeCalculatorRequestedDateOutOfBoundsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAgeCalculatorRequestedDateOutOfBoundsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAgeCalculatorRequestedDateOutOfBoundsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAgeCalculatorRequestedDateOutOfBoundsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandErrorComponentCount()
      {
        int result = 0;
        if (flagHasDestinationIsNow)
            ++result;
        if (flagHasDestinationIsToday)
            ++result;
        if (flagHasDatesSpecified)
            ++result;
        if (flagHasPerspective)
            ++result;
        result += extraAgeCalculatorRequestedDateOutOfBoundsComponentCount();
        return result;
      }
    public override string extraCommandErrorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDestinationIsNow)
          {
            if (remainder == 0)
                return "DestinationIsNow";
            --remainder;
          }
        if (flagHasDestinationIsToday)
          {
            if (remainder == 0)
                return "DestinationIsToday";
            --remainder;
          }
        if (flagHasDatesSpecified)
          {
            if (remainder == 0)
                return "DatesSpecified";
            --remainder;
          }
        if (flagHasPerspective)
          {
            if (remainder == 0)
                return "Perspective";
            --remainder;
          }
        return extraAgeCalculatorRequestedDateOutOfBoundsComponentKey(remainder);
      }
    public override JSONValue extraCommandErrorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDestinationIsNow)
          {
            if (remainder == 0)
                return extraDestinationIsNowToJSON();
            --remainder;
          }
        if (flagHasDestinationIsToday)
          {
            if (remainder == 0)
                return extraDestinationIsTodayToJSON();
            --remainder;
          }
        if (flagHasDatesSpecified)
          {
            if (remainder == 0)
                return extraDatesSpecifiedToJSON();
            --remainder;
          }
        if (flagHasPerspective)
          {
            if (remainder == 0)
                return extraPerspectiveToJSON();
            --remainder;
          }
        return extraAgeCalculatorRequestedDateOutOfBoundsComponentValue(remainder);
      }
    public override JSONValue extraCommandErrorLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "tesSpecified", 0, 12, false) == 0) && (field_name.Length == 14))
                            return (flagHasDatesSpecified ? extraDatesSpecifiedToJSON() : null);
                        break;
                    case 'e':
                        if (String.Compare(field_name, 2, "stinationIs", 0, 11, false) == 0)
                          {
                            switch (field_name[13])
                              {
                                case 'N':
                                    if ((String.Compare(field_name, 14, "ow", 0, 2, false) == 0) && (field_name.Length == 16))
                                        return (flagHasDestinationIsNow ? extraDestinationIsNowToJSON() : null);
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 14, "oday", 0, 4, false) == 0) && (field_name.Length == 18))
                                        return (flagHasDestinationIsToday ? extraDestinationIsTodayToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "erspective", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasPerspective ? extraPerspectiveToJSON() : null);
                break;
            default:
                break;
          }
        return extraAgeCalculatorRequestedDateOutOfBoundsLookup(field_name);
      }

    public void setDestinationIsNow(bool new_value)
      {
        flagHasDestinationIsNow = true;
        storeDestinationIsNow = new_value;
      }
    public void unsetDestinationIsNow()
      {
        flagHasDestinationIsNow = false;
      }
    public void setDestinationIsToday(bool new_value)
      {
        flagHasDestinationIsToday = true;
        storeDestinationIsToday = new_value;
      }
    public void unsetDestinationIsToday()
      {
        flagHasDestinationIsToday = false;
      }
    public void setDatesSpecified(TypeDatesSpecified new_value)
      {
        flagHasDatesSpecified = true;
        storeDatesSpecified = new_value;
      }
    public void setDatesSpecified(string chars)
      {
        setDatesSpecified(stringToDatesSpecified(chars));
      }
    public void unsetDatesSpecified()
      {
        flagHasDatesSpecified = false;
      }
    public void setPerspective(AgeCalculatorPerspectiveJSON  new_value)
      {
        if (flagHasPerspective)
          {
          }
        flagHasPerspective = true;
        storePerspective = new_value;
      }
    public void setPerspective(AgeCalculatorPerspectiveJSON.TypeValue new_value)
      {
        setPerspective(new AgeCalculatorPerspectiveJSON(new_value));
      }
    public void setPerspective(string chars)
      {
        setPerspective(new AgeCalculatorPerspectiveJSON(chars));
      }
    public void unsetPerspective()
      {
        if (flagHasPerspective)
          {
          }
        flagHasPerspective = false;
      }

    public virtual void extraAgeCalculatorRequestedDateOutOfBoundsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAgeCalculatorRequestedDateOutOfBoundsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAgeCalculatorRequestedDateOutOfBoundsLookup(key);
        if (old_field == null)
          {
            extraAgeCalculatorRequestedDateOutOfBoundsAppendPair(key, new_component);
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
    public override void extraCommandErrorAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tesSpecified", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONDatesSpecified(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if (String.Compare(key, 2, "stinationIs", 0, 11, false) == 0)
                          {
                            switch (key[13])
                              {
                                case 'N':
                                    if ((String.Compare(key, 14, "ow", 0, 2, false) == 0) && (key.Length == 16))
                                        {
                                        fromJSONDestinationIsNow(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 14, "oday", 0, 4, false) == 0) && (key.Length == 18))
                                        {
                                        fromJSONDestinationIsToday(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                if ((String.Compare(key, 1, "erspective", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONPerspective(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAgeCalculatorRequestedDateOutOfBoundsAppendPair(key, new_component);
      }
    public override void extraCommandErrorSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tesSpecified", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONDatesSpecified(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if (String.Compare(key, 2, "stinationIs", 0, 11, false) == 0)
                          {
                            switch (key[13])
                              {
                                case 'N':
                                    if ((String.Compare(key, 14, "ow", 0, 2, false) == 0) && (key.Length == 16))
                                        {
                                        fromJSONDestinationIsNow(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 14, "oday", 0, 4, false) == 0) && (key.Length == 18))
                                        {
                                        fromJSONDestinationIsToday(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                if ((String.Compare(key, 1, "erspective", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONPerspective(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAgeCalculatorRequestedDateOutOfBoundsSetField(key, new_component);
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
        if (flagHasDestinationIsNow)
          {
            handler.start_pair("DestinationIsNow");
            handler.boolean_value(storeDestinationIsNow);
          }
        if (flagHasDestinationIsToday)
          {
            handler.start_pair("DestinationIsToday");
            handler.boolean_value(storeDestinationIsToday);
          }
        if (flagHasDatesSpecified)
          {
            handler.start_pair("DatesSpecified");
            switch (storeDatesSpecified)
              {
                case TypeDatesSpecified.DatesSpecified_Both:
                    handler.string_value("Both");
                    break;
                case TypeDatesSpecified.DatesSpecified_Born:
                    handler.string_value("Born");
                    break;
                case TypeDatesSpecified.DatesSpecified_Destination:
                    handler.string_value("Destination");
                    break;
                case TypeDatesSpecified.DatesSpecified_None:
                    handler.string_value("None");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasPerspective)
          {
            handler.start_pair("Perspective");
            if (partial_allowed)
                storePerspective.write_partial_as_json(handler);
            else
                storePerspective.write_as_json(handler);
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

    public static new AgeCalculatorRequestedDateOutOfBoundsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AgeCalculatorRequestedDateOutOfBoundsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorRequestedDateOutOfBounds", ignore_extras);
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
    public static new AgeCalculatorRequestedDateOutOfBoundsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AgeCalculatorRequestedDateOutOfBoundsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AgeCalculatorRequestedDateOutOfBoundsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorRequestedDateOutOfBounds", ignore_extras);
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
    public static new AgeCalculatorRequestedDateOutOfBoundsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AgeCalculatorRequestedDateOutOfBoundsJSON from_text(string text, bool ignore_extras)
      {
        AgeCalculatorRequestedDateOutOfBoundsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorRequestedDateOutOfBounds", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AgeCalculatorRequestedDateOutOfBoundsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AgeCalculatorRequestedDateOutOfBoundsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AgeCalculatorRequestedDateOutOfBoundsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorRequestedDateOutOfBounds", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandErrorJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorDestinationIsNow;
        private JSONHoldingBooleanGenerator fieldGeneratorDestinationIsToday;
    private abstract class FieldGeneratorDatesSpecified : JSONStringGenerator
          {
            protected FieldGeneratorDatesSpecified(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDatesSpecified()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToDatesSpecified(result));
              }
            protected abstract void handle_result(TypeDatesSpecified result);
          };
    private class FieldHoldingGeneratorDatesSpecified : FieldGeneratorDatesSpecified
  {
    protected override void handle_result(TypeDatesSpecified result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDatesSpecified(String what)
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
    public TypeDatesSpecified value;
  };
    private class FieldHoldingArrayGeneratorDatesSpecified : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDatesSpecified
      {
        private FieldHoldingArrayGeneratorDatesSpecified top;

        protected override void handle_result(TypeDatesSpecified result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDatesSpecified init_top)
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
    protected virtual void handle_result(List<TypeDatesSpecified> result)
      {
      }

    public FieldHoldingArrayGeneratorDatesSpecified(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDatesSpecified>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDatesSpecified()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDatesSpecified>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDatesSpecified> value;
  };
        private FieldHoldingGeneratorDatesSpecified fieldGeneratorDatesSpecified;
        private AgeCalculatorPerspectiveJSON.HoldingGenerator fieldGeneratorPerspective;
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
            if (!(getCommandErrorJSONKey().Equals("AgeCalculatorRequestedDateOutOfBounds")))
                throw new Exception("The key field has a value other than `AgeCalculatorRequestedDateOutOfBounds'.");
            AgeCalculatorRequestedDateOutOfBoundsJSON result = new AgeCalculatorRequestedDateOutOfBoundsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAgeCalculatorRequestedDateOutOfBoundsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandErrorJSON new_result)
          {
            handle_result((AgeCalculatorRequestedDateOutOfBoundsJSON )new_result);
          }
        protected void finish(AgeCalculatorRequestedDateOutOfBoundsJSON result)
          {
            if (fieldGeneratorDestinationIsNow.have_value)
              {
                result.setDestinationIsNow(fieldGeneratorDestinationIsNow.value);
                fieldGeneratorDestinationIsNow.have_value = false;
              }
            if (fieldGeneratorDestinationIsToday.have_value)
              {
                result.setDestinationIsToday(fieldGeneratorDestinationIsToday.value);
                fieldGeneratorDestinationIsToday.have_value = false;
              }
            if (fieldGeneratorDatesSpecified.have_value)
              {
                result.setDatesSpecified(fieldGeneratorDatesSpecified.value);
                fieldGeneratorDatesSpecified.have_value = false;
              }
            if (fieldGeneratorPerspective.have_value)
              {
                result.setPerspective(fieldGeneratorPerspective.value);
                fieldGeneratorPerspective.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(AgeCalculatorRequestedDateOutOfBoundsJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tesSpecified", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorDatesSpecified;
                            break;
                        case 'e':
                            if (String.Compare(field_name, 2, "stinationIs", 0, 11, false) == 0)
                              {
                                switch (field_name[13])
                                  {
                                    case 'N':
                                        if ((String.Compare(field_name, 14, "ow", 0, 2, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorDestinationIsNow;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 14, "oday", 0, 4, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorDestinationIsToday;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "erspective", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorPerspective;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDestinationIsNow = new JSONHoldingBooleanGenerator("field \"DestinationIsNow\" of the AgeCalculatorRequestedDateOutOfBounds class");
            fieldGeneratorDestinationIsToday = new JSONHoldingBooleanGenerator("field \"DestinationIsToday\" of the AgeCalculatorRequestedDateOutOfBounds class");
            fieldGeneratorDatesSpecified = new FieldHoldingGeneratorDatesSpecified("field \"DatesSpecified\" of the AgeCalculatorRequestedDateOutOfBounds class");
            fieldGeneratorPerspective = new AgeCalculatorPerspectiveJSON.HoldingGenerator("field \"Perspective\" of the AgeCalculatorRequestedDateOutOfBounds class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AgeCalculatorRequestedDateOutOfBounds class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDestinationIsNow = new JSONHoldingBooleanGenerator("field \"DestinationIsNow\" of the AgeCalculatorRequestedDateOutOfBounds class");
            fieldGeneratorDestinationIsToday = new JSONHoldingBooleanGenerator("field \"DestinationIsToday\" of the AgeCalculatorRequestedDateOutOfBounds class");
            fieldGeneratorDatesSpecified = new FieldHoldingGeneratorDatesSpecified("field \"DatesSpecified\" of the AgeCalculatorRequestedDateOutOfBounds class");
            fieldGeneratorPerspective = new AgeCalculatorPerspectiveJSON.HoldingGenerator("field \"Perspective\" of the AgeCalculatorRequestedDateOutOfBounds class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AgeCalculatorRequestedDateOutOfBounds class");
          }

        public override void reset()
          {
            fieldGeneratorDestinationIsNow.reset();
            fieldGeneratorDestinationIsToday.reset();
            fieldGeneratorDatesSpecified.reset();
            fieldGeneratorPerspective.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AgeCalculatorRequestedDateOutOfBoundsJSON  result)
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
        public AgeCalculatorRequestedDateOutOfBoundsJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AgeCalculatorRequestedDateOutOfBoundsJSON  result)
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
    protected virtual void handle_result(List<AgeCalculatorRequestedDateOutOfBoundsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AgeCalculatorRequestedDateOutOfBoundsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AgeCalculatorRequestedDateOutOfBoundsJSON>();
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
    public List<AgeCalculatorRequestedDateOutOfBoundsJSON> value;
  };
  };
