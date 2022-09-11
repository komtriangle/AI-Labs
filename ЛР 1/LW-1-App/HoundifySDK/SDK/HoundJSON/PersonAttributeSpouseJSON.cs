/* file "PersonAttributeSpouseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PersonAttributeSpouseJSON : PersonAttributePersonJSON
  {
    public enum TypePreviousSpouseSex
      {
        PreviousSpouseSex_Female,
        PreviousSpouseSex_Male
      };

    public static TypePreviousSpouseSex  stringToPreviousSpouseSex(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "emale", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypePreviousSpouseSex.PreviousSpouseSex_Female;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "ale", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypePreviousSpouseSex.PreviousSpouseSex_Male;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `PreviousSpouseSex' is not one of the legal values.");
      }

    public static string  stringFromPreviousSpouseSex(TypePreviousSpouseSex the_enum)
      {
        switch (the_enum)
          {
            case TypePreviousSpouseSex.PreviousSpouseSex_Female:
                return "Female";
            case TypePreviousSpouseSex.PreviousSpouseSex_Male:
                return "Male";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasRecentMarriageStartTime;
    private DateAndOrTimeJSON  storeRecentMarriageStartTime;
    private bool flagHasRecentMarriageEndTime;
    private DateAndOrTimeJSON  storeRecentMarriageEndTime;
    private bool flagHasPreviousSpouseName;
    private string storePreviousSpouseName;
    private bool flagHasPreviousSpouseSex;
    private TypePreviousSpouseSex storePreviousSpouseSex;
    private bool flagHasIsDead;
    private bool storeIsDead;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRecentMarriageStartTimeToJSON()
      {
        JSONValueHandler handler_RecentMarriageStartTime = new JSONValueHandler();
        storeRecentMarriageStartTime.write_as_json(handler_RecentMarriageStartTime);
        return handler_RecentMarriageStartTime.result;
      }

    private JSONValue  extraRecentMarriageEndTimeToJSON()
      {
        JSONValueHandler handler_RecentMarriageEndTime = new JSONValueHandler();
        storeRecentMarriageEndTime.write_as_json(handler_RecentMarriageEndTime);
        return handler_RecentMarriageEndTime.result;
      }

    private JSONValue  extraPreviousSpouseNameToJSON()
      {
        JSONStringValue generated_string_PreviousSpouseName = new JSONStringValue(storePreviousSpouseName);
        return generated_string_PreviousSpouseName;
      }

    private JSONValue  extraPreviousSpouseSexToJSON()
      {
        JSONStringValue generated_string_PreviousSpouseSex;
        switch (storePreviousSpouseSex)
          {
            case TypePreviousSpouseSex.PreviousSpouseSex_Female:
                generated_string_PreviousSpouseSex = new JSONStringValue("Female");
                break;
            case TypePreviousSpouseSex.PreviousSpouseSex_Male:
                generated_string_PreviousSpouseSex = new JSONStringValue("Male");
                break;
            default:
                Debug.Assert(false);
                generated_string_PreviousSpouseSex = null;
                break;
          }
        return generated_string_PreviousSpouseSex;
      }

    private JSONValue  extraIsDeadToJSON()
      {
        JSONValue generated_boolean_IsDead = (storeIsDead ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsDead;
      }


    private void  fromJSONRecentMarriageStartTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setRecentMarriageStartTime(convert_classy);
      }


    private void  fromJSONRecentMarriageEndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setRecentMarriageEndTime(convert_classy);
      }


    private void  fromJSONPreviousSpouseName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PreviousSpouseName of PersonAttributeSpouseJSON is not a string.");
        setPreviousSpouseName(json_string.getData());
      }


    private void  fromJSONPreviousSpouseSex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PreviousSpouseSex of PersonAttributeSpouseJSON is not a string.");
        TypePreviousSpouseSex the_enum;
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "emale", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypePreviousSpouseSex.PreviousSpouseSex_Female;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ale", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypePreviousSpouseSex.PreviousSpouseSex_Male;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field PreviousSpouseSex of PersonAttributeSpouseJSON is not one of the legal strings.");
      enum_is_done:;
        setPreviousSpouseSex(the_enum);
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
                throw new Exception("The value for field IsDead of PersonAttributeSpouseJSON is not true for false.");
              }
          }
        setIsDead(the_bool);
      }


    public PersonAttributeSpouseJSON()
      {
        flagHasRecentMarriageStartTime = false;
        flagHasRecentMarriageEndTime = false;
        flagHasPreviousSpouseName = false;
        flagHasPreviousSpouseSex = false;
        flagHasIsDead = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPersonAttribute()
      {
        return "Spouse";
      }

    public bool  hasRecentMarriageStartTime()
      {
        return flagHasRecentMarriageStartTime;
      }

    public DateAndOrTimeJSON   getRecentMarriageStartTime()
      {
        Debug.Assert(flagHasRecentMarriageStartTime);
        return storeRecentMarriageStartTime;
      }

    public bool  hasRecentMarriageEndTime()
      {
        return flagHasRecentMarriageEndTime;
      }

    public DateAndOrTimeJSON   getRecentMarriageEndTime()
      {
        Debug.Assert(flagHasRecentMarriageEndTime);
        return storeRecentMarriageEndTime;
      }

    public bool  hasPreviousSpouseName()
      {
        return flagHasPreviousSpouseName;
      }

    public string  getPreviousSpouseName()
      {
        Debug.Assert(flagHasPreviousSpouseName);
        return storePreviousSpouseName;
      }

    public bool  hasPreviousSpouseSex()
      {
        return flagHasPreviousSpouseSex;
      }

    public TypePreviousSpouseSex  getPreviousSpouseSex()
      {
        Debug.Assert(flagHasPreviousSpouseSex);
        return storePreviousSpouseSex;
      }

    public string  getPreviousSpouseSexAsString()
      {
        return stringFromPreviousSpouseSex(getPreviousSpouseSex());
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


    public virtual int extraPersonAttributeSpouseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPersonAttributeSpouseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPersonAttributeSpouseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPersonAttributeSpouseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPersonAttributePersonComponentCount()
      {
        int result = 0;
        if (flagHasRecentMarriageStartTime)
            ++result;
        if (flagHasRecentMarriageEndTime)
            ++result;
        if (flagHasPreviousSpouseName)
            ++result;
        if (flagHasPreviousSpouseSex)
            ++result;
        if (flagHasIsDead)
            ++result;
        result += extraPersonAttributeSpouseComponentCount();
        return result;
      }
    public override string extraPersonAttributePersonComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRecentMarriageStartTime)
          {
            if (remainder == 0)
                return "RecentMarriageStartTime";
            --remainder;
          }
        if (flagHasRecentMarriageEndTime)
          {
            if (remainder == 0)
                return "RecentMarriageEndTime";
            --remainder;
          }
        if (flagHasPreviousSpouseName)
          {
            if (remainder == 0)
                return "PreviousSpouseName";
            --remainder;
          }
        if (flagHasPreviousSpouseSex)
          {
            if (remainder == 0)
                return "PreviousSpouseSex";
            --remainder;
          }
        if (flagHasIsDead)
          {
            if (remainder == 0)
                return "IsDead";
            --remainder;
          }
        return extraPersonAttributeSpouseComponentKey(remainder);
      }
    public override JSONValue extraPersonAttributePersonComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRecentMarriageStartTime)
          {
            if (remainder == 0)
                return extraRecentMarriageStartTimeToJSON();
            --remainder;
          }
        if (flagHasRecentMarriageEndTime)
          {
            if (remainder == 0)
                return extraRecentMarriageEndTimeToJSON();
            --remainder;
          }
        if (flagHasPreviousSpouseName)
          {
            if (remainder == 0)
                return extraPreviousSpouseNameToJSON();
            --remainder;
          }
        if (flagHasPreviousSpouseSex)
          {
            if (remainder == 0)
                return extraPreviousSpouseSexToJSON();
            --remainder;
          }
        if (flagHasIsDead)
          {
            if (remainder == 0)
                return extraIsDeadToJSON();
            --remainder;
          }
        return extraPersonAttributeSpouseComponentValue(remainder);
      }
    public override JSONValue extraPersonAttributePersonLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "sDead", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasIsDead ? extraIsDeadToJSON() : null);
                break;
            case 'P':
                if (String.Compare(field_name, 1, "reviousSpouse", 0, 13, false) == 0)
                  {
                    switch (field_name[14])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 15, "ame", 0, 3, false) == 0) && (field_name.Length == 18))
                                return (flagHasPreviousSpouseName ? extraPreviousSpouseNameToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 15, "ex", 0, 2, false) == 0) && (field_name.Length == 17))
                                return (flagHasPreviousSpouseSex ? extraPreviousSpouseSexToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(field_name, 1, "ecentMarriage", 0, 13, false) == 0)
                  {
                    switch (field_name[14])
                      {
                        case 'E':
                            if ((String.Compare(field_name, 15, "ndTime", 0, 6, false) == 0) && (field_name.Length == 21))
                                return (flagHasRecentMarriageEndTime ? extraRecentMarriageEndTimeToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 15, "tartTime", 0, 8, false) == 0) && (field_name.Length == 23))
                                return (flagHasRecentMarriageStartTime ? extraRecentMarriageStartTimeToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraPersonAttributeSpouseLookup(field_name);
      }

    public void setRecentMarriageStartTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasRecentMarriageStartTime)
          {
          }
        flagHasRecentMarriageStartTime = true;
        storeRecentMarriageStartTime = new_value;
      }
    public void unsetRecentMarriageStartTime()
      {
        if (flagHasRecentMarriageStartTime)
          {
          }
        flagHasRecentMarriageStartTime = false;
      }
    public void setRecentMarriageEndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasRecentMarriageEndTime)
          {
          }
        flagHasRecentMarriageEndTime = true;
        storeRecentMarriageEndTime = new_value;
      }
    public void unsetRecentMarriageEndTime()
      {
        if (flagHasRecentMarriageEndTime)
          {
          }
        flagHasRecentMarriageEndTime = false;
      }
    public void setPreviousSpouseName(string new_value)
      {
        flagHasPreviousSpouseName = true;
        storePreviousSpouseName = new_value;
      }
    public void unsetPreviousSpouseName()
      {
        flagHasPreviousSpouseName = false;
      }
    public void setPreviousSpouseSex(TypePreviousSpouseSex new_value)
      {
        flagHasPreviousSpouseSex = true;
        storePreviousSpouseSex = new_value;
      }
    public void setPreviousSpouseSex(string chars)
      {
        setPreviousSpouseSex(stringToPreviousSpouseSex(chars));
      }
    public void unsetPreviousSpouseSex()
      {
        flagHasPreviousSpouseSex = false;
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

    public virtual void extraPersonAttributeSpouseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPersonAttributeSpouseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPersonAttributeSpouseLookup(key);
        if (old_field == null)
          {
            extraPersonAttributeSpouseAppendPair(key, new_component);
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
    public override void extraPersonAttributePersonAppendPair(string key, JSONValue new_component)
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
            case 'P':
                if (String.Compare(key, 1, "reviousSpouse", 0, 13, false) == 0)
                  {
                    switch (key[14])
                      {
                        case 'N':
                            if ((String.Compare(key, 15, "ame", 0, 3, false) == 0) && (key.Length == 18))
                                {
                                fromJSONPreviousSpouseName(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 15, "ex", 0, 2, false) == 0) && (key.Length == 17))
                                {
                                fromJSONPreviousSpouseSex(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(key, 1, "ecentMarriage", 0, 13, false) == 0)
                  {
                    switch (key[14])
                      {
                        case 'E':
                            if ((String.Compare(key, 15, "ndTime", 0, 6, false) == 0) && (key.Length == 21))
                                {
                                fromJSONRecentMarriageEndTime(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 15, "tartTime", 0, 8, false) == 0) && (key.Length == 23))
                                {
                                fromJSONRecentMarriageStartTime(new_component, false);
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
        extraPersonAttributeSpouseAppendPair(key, new_component);
      }
    public override void extraPersonAttributePersonSetField(string key, JSONValue new_component)
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
            case 'P':
                if (String.Compare(key, 1, "reviousSpouse", 0, 13, false) == 0)
                  {
                    switch (key[14])
                      {
                        case 'N':
                            if ((String.Compare(key, 15, "ame", 0, 3, false) == 0) && (key.Length == 18))
                                {
                                fromJSONPreviousSpouseName(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 15, "ex", 0, 2, false) == 0) && (key.Length == 17))
                                {
                                fromJSONPreviousSpouseSex(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(key, 1, "ecentMarriage", 0, 13, false) == 0)
                  {
                    switch (key[14])
                      {
                        case 'E':
                            if ((String.Compare(key, 15, "ndTime", 0, 6, false) == 0) && (key.Length == 21))
                                {
                                fromJSONRecentMarriageEndTime(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 15, "tartTime", 0, 8, false) == 0) && (key.Length == 23))
                                {
                                fromJSONRecentMarriageStartTime(new_component, false);
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
        extraPersonAttributeSpouseSetField(key, new_component);
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
        if (flagHasRecentMarriageStartTime)
          {
            handler.start_pair("RecentMarriageStartTime");
            if (partial_allowed)
                storeRecentMarriageStartTime.write_partial_as_json(handler);
            else
                storeRecentMarriageStartTime.write_as_json(handler);
          }
        if (flagHasRecentMarriageEndTime)
          {
            handler.start_pair("RecentMarriageEndTime");
            if (partial_allowed)
                storeRecentMarriageEndTime.write_partial_as_json(handler);
            else
                storeRecentMarriageEndTime.write_as_json(handler);
          }
        if (flagHasPreviousSpouseName)
          {
            handler.start_pair("PreviousSpouseName");
            handler.string_value(storePreviousSpouseName);
          }
        if (flagHasPreviousSpouseSex)
          {
            handler.start_pair("PreviousSpouseSex");
            switch (storePreviousSpouseSex)
              {
                case TypePreviousSpouseSex.PreviousSpouseSex_Female:
                    handler.string_value("Female");
                    break;
                case TypePreviousSpouseSex.PreviousSpouseSex_Male:
                    handler.string_value("Male");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasIsDead)
          {
            handler.start_pair("IsDead");
            handler.boolean_value(storeIsDead);
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

    public static new PersonAttributeSpouseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeSpouseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSpouse", ignore_extras);
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
    public static new PersonAttributeSpouseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonAttributeSpouseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeSpouseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSpouse", ignore_extras);
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
    public static new PersonAttributeSpouseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonAttributeSpouseJSON from_text(string text, bool ignore_extras)
      {
        PersonAttributeSpouseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSpouse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonAttributeSpouseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PersonAttributeSpouseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonAttributeSpouseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSpouse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PersonAttributePersonJSON.Generator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorRecentMarriageStartTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorRecentMarriageEndTime;
        private JSONHoldingStringGenerator fieldGeneratorPreviousSpouseName;
    private abstract class FieldGeneratorPreviousSpouseSex : JSONStringGenerator
          {
            protected FieldGeneratorPreviousSpouseSex(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorPreviousSpouseSex()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToPreviousSpouseSex(result));
              }
            protected abstract void handle_result(TypePreviousSpouseSex result);
          };
    private class FieldHoldingGeneratorPreviousSpouseSex : FieldGeneratorPreviousSpouseSex
  {
    protected override void handle_result(TypePreviousSpouseSex result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorPreviousSpouseSex(String what)
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
    public TypePreviousSpouseSex value;
  };
    private class FieldHoldingArrayGeneratorPreviousSpouseSex : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPreviousSpouseSex
      {
        private FieldHoldingArrayGeneratorPreviousSpouseSex top;

        protected override void handle_result(TypePreviousSpouseSex result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPreviousSpouseSex init_top)
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
    protected virtual void handle_result(List<TypePreviousSpouseSex> result)
      {
      }

    public FieldHoldingArrayGeneratorPreviousSpouseSex(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePreviousSpouseSex>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPreviousSpouseSex()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePreviousSpouseSex>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePreviousSpouseSex> value;
  };
        private FieldHoldingGeneratorPreviousSpouseSex fieldGeneratorPreviousSpouseSex;
        private JSONHoldingBooleanGenerator fieldGeneratorIsDead;
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
            if (!(getPersonAttributePersonJSONKey().Equals("Spouse")))
                throw new Exception("The key field has a value other than `Spouse'.");
            PersonAttributeSpouseJSON result = new PersonAttributeSpouseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonAttributeSpouseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PersonAttributePersonJSON new_result)
          {
            handle_result((PersonAttributeSpouseJSON )new_result);
          }
        protected void finish(PersonAttributeSpouseJSON result)
          {
            if (fieldGeneratorRecentMarriageStartTime.have_value)
              {
                result.setRecentMarriageStartTime(fieldGeneratorRecentMarriageStartTime.value);
                fieldGeneratorRecentMarriageStartTime.have_value = false;
              }
            if (fieldGeneratorRecentMarriageEndTime.have_value)
              {
                result.setRecentMarriageEndTime(fieldGeneratorRecentMarriageEndTime.value);
                fieldGeneratorRecentMarriageEndTime.have_value = false;
              }
            if (fieldGeneratorPreviousSpouseName.have_value)
              {
                result.setPreviousSpouseName(fieldGeneratorPreviousSpouseName.value);
                fieldGeneratorPreviousSpouseName.have_value = false;
              }
            if (fieldGeneratorPreviousSpouseSex.have_value)
              {
                result.setPreviousSpouseSex(fieldGeneratorPreviousSpouseSex.value);
                fieldGeneratorPreviousSpouseSex.have_value = false;
              }
            if (fieldGeneratorIsDead.have_value)
              {
                result.setIsDead(fieldGeneratorIsDead.value);
                fieldGeneratorIsDead.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(PersonAttributeSpouseJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "sDead", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorIsDead;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "reviousSpouse", 0, 13, false) == 0)
                      {
                        switch (field_name[14])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 15, "ame", 0, 3, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorPreviousSpouseName;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 15, "ex", 0, 2, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorPreviousSpouseSex;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "ecentMarriage", 0, 13, false) == 0)
                      {
                        switch (field_name[14])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 15, "ndTime", 0, 6, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorRecentMarriageEndTime;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 15, "tartTime", 0, 8, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorRecentMarriageStartTime;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRecentMarriageStartTime = new DateAndOrTimeJSON.HoldingGenerator("field \"RecentMarriageStartTime\" of the PersonAttributeSpouse class", ignore_extras);
            fieldGeneratorRecentMarriageEndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"RecentMarriageEndTime\" of the PersonAttributeSpouse class", ignore_extras);
            fieldGeneratorPreviousSpouseName = new JSONHoldingStringGenerator("field \"PreviousSpouseName\" of the PersonAttributeSpouse class");
            fieldGeneratorPreviousSpouseSex = new FieldHoldingGeneratorPreviousSpouseSex("field \"PreviousSpouseSex\" of the PersonAttributeSpouse class");
            fieldGeneratorIsDead = new JSONHoldingBooleanGenerator("field \"IsDead\" of the PersonAttributeSpouse class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PersonAttributeSpouse class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRecentMarriageStartTime = new DateAndOrTimeJSON.HoldingGenerator("field \"RecentMarriageStartTime\" of the PersonAttributeSpouse class", false);
            fieldGeneratorRecentMarriageEndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"RecentMarriageEndTime\" of the PersonAttributeSpouse class", false);
            fieldGeneratorPreviousSpouseName = new JSONHoldingStringGenerator("field \"PreviousSpouseName\" of the PersonAttributeSpouse class");
            fieldGeneratorPreviousSpouseSex = new FieldHoldingGeneratorPreviousSpouseSex("field \"PreviousSpouseSex\" of the PersonAttributeSpouse class");
            fieldGeneratorIsDead = new JSONHoldingBooleanGenerator("field \"IsDead\" of the PersonAttributeSpouse class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PersonAttributeSpouse class");
          }

        public override void reset()
          {
            fieldGeneratorRecentMarriageStartTime.reset();
            fieldGeneratorRecentMarriageEndTime.reset();
            fieldGeneratorPreviousSpouseName.reset();
            fieldGeneratorPreviousSpouseSex.reset();
            fieldGeneratorIsDead.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonAttributeSpouseJSON  result)
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
        public PersonAttributeSpouseJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonAttributeSpouseJSON  result)
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
    protected virtual void handle_result(List<PersonAttributeSpouseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonAttributeSpouseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonAttributeSpouseJSON>();
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
    public List<PersonAttributeSpouseJSON> value;
  };
  };
