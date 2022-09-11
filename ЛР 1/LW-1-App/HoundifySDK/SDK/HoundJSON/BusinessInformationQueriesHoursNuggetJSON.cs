/* file "BusinessInformationQueriesHoursNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BusinessInformationQueriesHoursNuggetJSON : BusinessInformationQueriesNuggetJSON
  {
    public enum TypeOpenStatusKnownValues
      {
        OpenStatus_OpenAffirmative,
        OpenStatus_OpenNegative,
        OpenStatus_ClosedAffirmative,
        OpenStatus_ClosedNegative,
        OpenStatus__none
      };
    public struct TypeOpenStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeOpenStatusKnownValues list_value;
      };

    public static TypeOpenStatusKnownValues  stringToOpenStatus(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if (String.Compare(chars, 1, "losed", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'A':
                            if ((String.Compare(chars, 7, "ffirmative", 0, 10, false) == 0) && (chars.Length == 17))
                                return TypeOpenStatusKnownValues.OpenStatus_ClosedAffirmative;
                            break;
                        case 'N':
                            if ((String.Compare(chars, 7, "egative", 0, 7, false) == 0) && (chars.Length == 14))
                                return TypeOpenStatusKnownValues.OpenStatus_ClosedNegative;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if (String.Compare(chars, 1, "pen", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'A':
                            if ((String.Compare(chars, 5, "ffirmative", 0, 10, false) == 0) && (chars.Length == 15))
                                return TypeOpenStatusKnownValues.OpenStatus_OpenAffirmative;
                            break;
                        case 'N':
                            if ((String.Compare(chars, 5, "egative", 0, 7, false) == 0) && (chars.Length == 12))
                                return TypeOpenStatusKnownValues.OpenStatus_OpenNegative;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeOpenStatusKnownValues.OpenStatus__none;
      }

    public static string  stringFromOpenStatus(TypeOpenStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeOpenStatusKnownValues.OpenStatus_OpenAffirmative:
                return "OpenAffirmative";
            case TypeOpenStatusKnownValues.OpenStatus_OpenNegative:
                return "OpenNegative";
            case TypeOpenStatusKnownValues.OpenStatus_ClosedAffirmative:
                return "ClosedAffirmative";
            case TypeOpenStatusKnownValues.OpenStatus_ClosedNegative:
                return "ClosedNegative";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasOpenStatus;
    private TypeOpenStatus storeOpenStatus;
    private bool flagHasReferencedDateTime;
    private DateTimeSpecJSON  storeReferencedDateTime;
    private bool flagHasHours;
    private BusinessInformationDataWeeklyHoursJSON  storeHours;
    private bool flagHasHoursGroups;
    private List< BusinessInformationQueriesDaysListJSON  > storeHoursGroups;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraOpenStatusToJSON()
      {
        JSONStringValue generated_string_OpenStatus;
        if (!(storeOpenStatus.in_known_list))
          {
        generated_string_OpenStatus = new JSONStringValue(storeOpenStatus.string_value);
          }
        else
          {
        switch (storeOpenStatus.list_value)
          {
            case TypeOpenStatusKnownValues.OpenStatus_OpenAffirmative:
                generated_string_OpenStatus = new JSONStringValue("OpenAffirmative");
                break;
            case TypeOpenStatusKnownValues.OpenStatus_OpenNegative:
                generated_string_OpenStatus = new JSONStringValue("OpenNegative");
                break;
            case TypeOpenStatusKnownValues.OpenStatus_ClosedAffirmative:
                generated_string_OpenStatus = new JSONStringValue("ClosedAffirmative");
                break;
            case TypeOpenStatusKnownValues.OpenStatus_ClosedNegative:
                generated_string_OpenStatus = new JSONStringValue("ClosedNegative");
                break;
            default:
                Debug.Assert(false);
                generated_string_OpenStatus = null;
                break;
          }
          }
        return generated_string_OpenStatus;
      }

    private JSONValue  extraReferencedDateTimeToJSON()
      {
        JSONValueHandler handler_ReferencedDateTime = new JSONValueHandler();
        storeReferencedDateTime.write_as_json(handler_ReferencedDateTime);
        return handler_ReferencedDateTime.result;
      }

    private JSONValue  extraHoursToJSON()
      {
        JSONValueHandler handler_Hours = new JSONValueHandler();
        storeHours.write_as_json(handler_Hours);
        return handler_Hours.result;
      }

    private JSONValue  extraHoursGroupsToJSON()
      {
        JSONArrayValue generated_array_1_HoursGroups = new JSONArrayValue();
        for (int num1 = 0; num1 < storeHoursGroups.Count; ++num1)
          {
            JSONValueHandler handler_HoursGroups = new JSONValueHandler();
            storeHoursGroups[num1].write_as_json(handler_HoursGroups);
            generated_array_1_HoursGroups.appendComponent(handler_HoursGroups.result);
          }
        return generated_array_1_HoursGroups;
      }


    private void  fromJSONOpenStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OpenStatus of BusinessInformationQueriesHoursNuggetJSON is not a string.");
        TypeOpenStatus the_open_enum = new TypeOpenStatus();
        switch (json_string.getData()[0])
          {
            case 'C':
                if (String.Compare(json_string.getData(), 1, "losed", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 7, "ffirmative", 0, 10, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeOpenStatusKnownValues.OpenStatus_ClosedAffirmative;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'N':
                            if ((String.Compare(json_string.getData(), 7, "egative", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeOpenStatusKnownValues.OpenStatus_ClosedNegative;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if (String.Compare(json_string.getData(), 1, "pen", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 5, "ffirmative", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeOpenStatusKnownValues.OpenStatus_OpenAffirmative;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'N':
                            if ((String.Compare(json_string.getData(), 5, "egative", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeOpenStatusKnownValues.OpenStatus_OpenNegative;
                                    goto open_enum_is_done;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setOpenStatus(the_open_enum);
      }


    private void  fromJSONReferencedDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setReferencedDateTime(convert_classy);
      }


    private void  fromJSONHours(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BusinessInformationDataWeeklyHoursJSON convert_classy = BusinessInformationDataWeeklyHoursJSON.from_json(json_value, ignore_extras, true);
        setHours(convert_classy);
      }


    private void  fromJSONHoursGroups(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HoursGroups of BusinessInformationQueriesHoursNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BusinessInformationQueriesDaysListJSON  > vector_HoursGroups1 = new List< BusinessInformationQueriesDaysListJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BusinessInformationQueriesDaysListJSON convert_classy = BusinessInformationQueriesDaysListJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_HoursGroups1.Add(convert_classy);
          }
        initHoursGroups();
        for (int num1 = 0; num1 < vector_HoursGroups1.Count; ++num1)
            appendHoursGroups(vector_HoursGroups1[num1]);
        for (int num1 = 0; num1 < vector_HoursGroups1.Count; ++num1)
          {
          }
      }


    public BusinessInformationQueriesHoursNuggetJSON()
      {
        flagHasOpenStatus = false;
        flagHasReferencedDateTime = false;
        flagHasHours = false;
        flagHasHoursGroups = false;
        storeHoursGroups = new List< BusinessInformationQueriesDaysListJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getBusinessInformationQueriesNuggetKind()
      {
        return "Hours";
      }

    public bool  hasOpenStatus()
      {
        return flagHasOpenStatus;
      }

    public TypeOpenStatus  getOpenStatus()
      {
        Debug.Assert(flagHasOpenStatus);
        return storeOpenStatus;
      }

    public string  getOpenStatusAsString()
      {
        TypeOpenStatus result = getOpenStatus();
        if (result.in_known_list)
            return stringFromOpenStatus(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasReferencedDateTime()
      {
        return flagHasReferencedDateTime;
      }

    public DateTimeSpecJSON   getReferencedDateTime()
      {
        Debug.Assert(flagHasReferencedDateTime);
        return storeReferencedDateTime;
      }

    public bool  hasHours()
      {
        return flagHasHours;
      }

    public BusinessInformationDataWeeklyHoursJSON   getHours()
      {
        Debug.Assert(flagHasHours);
        return storeHours;
      }

    public bool  hasHoursGroups()
      {
        return flagHasHoursGroups;
      }

    public int  countOfHoursGroups()
      {
        Debug.Assert(flagHasHoursGroups);
        return storeHoursGroups.Count;
      }

    public BusinessInformationQueriesDaysListJSON   elementOfHoursGroups(int element_num)
      {
        Debug.Assert(flagHasHoursGroups);
        return storeHoursGroups[element_num];
      }

    public List< BusinessInformationQueriesDaysListJSON  >  getHoursGroups()
      {
        Debug.Assert(flagHasHoursGroups);
        return storeHoursGroups;
      }


    public virtual int extraBusinessInformationQueriesHoursNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBusinessInformationQueriesHoursNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBusinessInformationQueriesHoursNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBusinessInformationQueriesHoursNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraBusinessInformationQueriesNuggetComponentCount()
      {
        int result = 0;
        if (flagHasOpenStatus)
            ++result;
        if (flagHasReferencedDateTime)
            ++result;
        if (flagHasHours)
            ++result;
        if (flagHasHoursGroups)
            ++result;
        result += extraBusinessInformationQueriesHoursNuggetComponentCount();
        return result;
      }
    public override string extraBusinessInformationQueriesNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasOpenStatus)
          {
            if (remainder == 0)
                return "OpenStatus";
            --remainder;
          }
        if (flagHasReferencedDateTime)
          {
            if (remainder == 0)
                return "ReferencedDateTime";
            --remainder;
          }
        if (flagHasHours)
          {
            if (remainder == 0)
                return "Hours";
            --remainder;
          }
        if (flagHasHoursGroups)
          {
            if (remainder == 0)
                return "HoursGroups";
            --remainder;
          }
        return extraBusinessInformationQueriesHoursNuggetComponentKey(remainder);
      }
    public override JSONValue extraBusinessInformationQueriesNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasOpenStatus)
          {
            if (remainder == 0)
                return extraOpenStatusToJSON();
            --remainder;
          }
        if (flagHasReferencedDateTime)
          {
            if (remainder == 0)
                return extraReferencedDateTimeToJSON();
            --remainder;
          }
        if (flagHasHours)
          {
            if (remainder == 0)
                return extraHoursToJSON();
            --remainder;
          }
        if (flagHasHoursGroups)
          {
            if (remainder == 0)
                return extraHoursGroupsToJSON();
            --remainder;
          }
        return extraBusinessInformationQueriesHoursNuggetComponentValue(remainder);
      }
    public override JSONValue extraBusinessInformationQueriesNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'H':
                if (String.Compare(field_name, 1, "ours", 0, 4, false) == 0)
                  {
                    if (field_name.Length == 5)
                      {
                        return (flagHasHours ? extraHoursToJSON() : null);
                      }
                    switch (field_name[5])
                      {
                        case 'G':
                            if ((String.Compare(field_name, 6, "roups", 0, 5, false) == 0) && (field_name.Length == 11))
                                return (flagHasHoursGroups ? extraHoursGroupsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "penStatus", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasOpenStatus ? extraOpenStatusToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "eferencedDateTime", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasReferencedDateTime ? extraReferencedDateTimeToJSON() : null);
                break;
            default:
                break;
          }
        return extraBusinessInformationQueriesHoursNuggetLookup(field_name);
      }

    public void setOpenStatus(TypeOpenStatus new_value)
      {
        flagHasOpenStatus = true;
        storeOpenStatus = new_value;
      }
    public void setOpenStatus(string chars)
      {
        TypeOpenStatusKnownValues known = stringToOpenStatus(chars);
        TypeOpenStatus new_value = new TypeOpenStatus();
        if (known == TypeOpenStatusKnownValues.OpenStatus__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setOpenStatus(new_value);
      }
    public void setOpenStatus(TypeOpenStatusKnownValues new_value)
      {
        TypeOpenStatus new_full_value = new TypeOpenStatus();
        Debug.Assert(new_value != TypeOpenStatusKnownValues.OpenStatus__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setOpenStatus(new_full_value);
      }
    public void unsetOpenStatus()
      {
        flagHasOpenStatus = false;
      }
    public void setReferencedDateTime(DateTimeSpecJSON  new_value)
      {
        if (flagHasReferencedDateTime)
          {
          }
        flagHasReferencedDateTime = true;
        storeReferencedDateTime = new_value;
      }
    public void unsetReferencedDateTime()
      {
        if (flagHasReferencedDateTime)
          {
          }
        flagHasReferencedDateTime = false;
      }
    public void setHours(BusinessInformationDataWeeklyHoursJSON  new_value)
      {
        if (flagHasHours)
          {
          }
        flagHasHours = true;
        storeHours = new_value;
      }
    public void unsetHours()
      {
        if (flagHasHours)
          {
          }
        flagHasHours = false;
      }
    public void initHoursGroups()
      {
        if (flagHasHoursGroups)
          {
            for (int num1 = 0; num1 < storeHoursGroups.Count; ++num1)
              {
              }
          }
        flagHasHoursGroups = true;
        storeHoursGroups.Clear();
      }
    public void appendHoursGroups(BusinessInformationQueriesDaysListJSON  to_append)
      {
        if (!flagHasHoursGroups)
          {
            flagHasHoursGroups = true;
            storeHoursGroups.Clear();
          }
        Debug.Assert(flagHasHoursGroups);
        storeHoursGroups.Add(to_append);
      }
    public void unsetHoursGroups()
      {
        if (flagHasHoursGroups)
          {
            for (int num2 = 0; num2 < storeHoursGroups.Count; ++num2)
              {
              }
          }
        flagHasHoursGroups = false;
        storeHoursGroups.Clear();
      }

    public virtual void extraBusinessInformationQueriesHoursNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBusinessInformationQueriesHoursNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBusinessInformationQueriesHoursNuggetLookup(key);
        if (old_field == null)
          {
            extraBusinessInformationQueriesHoursNuggetAppendPair(key, new_component);
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
    public override void extraBusinessInformationQueriesNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'H':
                if (String.Compare(key, 1, "ours", 0, 4, false) == 0)
                  {
                    if (key.Length == 5)
                      {
                        {
                        fromJSONHours(new_component, false);
                        return;
                        }
                      }
                    switch (key[5])
                      {
                        case 'G':
                            if ((String.Compare(key, 6, "roups", 0, 5, false) == 0) && (key.Length == 11))
                                {
                                fromJSONHoursGroups(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if ((String.Compare(key, 1, "penStatus", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONOpenStatus(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "eferencedDateTime", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONReferencedDateTime(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBusinessInformationQueriesHoursNuggetAppendPair(key, new_component);
      }
    public override void extraBusinessInformationQueriesNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'H':
                if (String.Compare(key, 1, "ours", 0, 4, false) == 0)
                  {
                    if (key.Length == 5)
                      {
                        {
                        fromJSONHours(new_component, false);
                        return;
                        }
                      }
                    switch (key[5])
                      {
                        case 'G':
                            if ((String.Compare(key, 6, "roups", 0, 5, false) == 0) && (key.Length == 11))
                                {
                                fromJSONHoursGroups(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if ((String.Compare(key, 1, "penStatus", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONOpenStatus(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "eferencedDateTime", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONReferencedDateTime(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBusinessInformationQueriesHoursNuggetSetField(key, new_component);
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
        if (flagHasOpenStatus)
          {
            handler.start_pair("OpenStatus");
            if (storeOpenStatus.in_known_list)
              {
                switch (storeOpenStatus.list_value)
                  {
                    case TypeOpenStatusKnownValues.OpenStatus_OpenAffirmative:
                        handler.string_value("OpenAffirmative");
                        break;
                    case TypeOpenStatusKnownValues.OpenStatus_OpenNegative:
                        handler.string_value("OpenNegative");
                        break;
                    case TypeOpenStatusKnownValues.OpenStatus_ClosedAffirmative:
                        handler.string_value("ClosedAffirmative");
                        break;
                    case TypeOpenStatusKnownValues.OpenStatus_ClosedNegative:
                        handler.string_value("ClosedNegative");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeOpenStatus.string_value);
              }
          }
        if (flagHasReferencedDateTime)
          {
            handler.start_pair("ReferencedDateTime");
            if (partial_allowed)
                storeReferencedDateTime.write_partial_as_json(handler);
            else
                storeReferencedDateTime.write_as_json(handler);
          }
        if (flagHasHours)
          {
            handler.start_pair("Hours");
            if (partial_allowed)
                storeHours.write_partial_as_json(handler);
            else
                storeHours.write_as_json(handler);
          }
        if (flagHasHoursGroups)
          {
            handler.start_pair("HoursGroups");
            handler.start_array();
            for (int num1 = 0; num1 < storeHoursGroups.Count; ++num1)
              {
                if (partial_allowed)
                    storeHoursGroups[num1].write_partial_as_json(handler);
                else
                    storeHoursGroups[num1].write_as_json(handler);
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
        return null;
      }

    public static new BusinessInformationQueriesHoursNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationQueriesHoursNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesHoursNugget", ignore_extras);
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
    public static new BusinessInformationQueriesHoursNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BusinessInformationQueriesHoursNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationQueriesHoursNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesHoursNugget", ignore_extras);
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
    public static new BusinessInformationQueriesHoursNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BusinessInformationQueriesHoursNuggetJSON from_text(string text, bool ignore_extras)
      {
        BusinessInformationQueriesHoursNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesHoursNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BusinessInformationQueriesHoursNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new BusinessInformationQueriesHoursNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BusinessInformationQueriesHoursNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesHoursNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : BusinessInformationQueriesNuggetJSON.Generator
      {
    private abstract class FieldGeneratorOpenStatus : JSONStringGenerator
          {
            protected FieldGeneratorOpenStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorOpenStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeOpenStatusKnownValues known = stringToOpenStatus(result);
                TypeOpenStatus new_value = new TypeOpenStatus();
                if (known == TypeOpenStatusKnownValues.OpenStatus__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeOpenStatus result);
          };
    private class FieldHoldingGeneratorOpenStatus : FieldGeneratorOpenStatus
  {
    protected override void handle_result(TypeOpenStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorOpenStatus(String what)
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
    public TypeOpenStatus value;
  };
    private class FieldHoldingArrayGeneratorOpenStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorOpenStatus
      {
        private FieldHoldingArrayGeneratorOpenStatus top;

        protected override void handle_result(TypeOpenStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorOpenStatus init_top)
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
    protected virtual void handle_result(List<TypeOpenStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorOpenStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOpenStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorOpenStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOpenStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeOpenStatus> value;
  };
        private FieldHoldingGeneratorOpenStatus fieldGeneratorOpenStatus;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorReferencedDateTime;
        private BusinessInformationDataWeeklyHoursJSON.HoldingGenerator fieldGeneratorHours;
        private BusinessInformationQueriesDaysListJSON.HoldingArrayGenerator fieldGeneratorHoursGroups;
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
            if (!(getBusinessInformationQueriesNuggetJSONKey().Equals("Hours")))
                throw new Exception("The key field has a value other than `Hours'.");
            BusinessInformationQueriesHoursNuggetJSON result = new BusinessInformationQueriesHoursNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBusinessInformationQueriesHoursNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(BusinessInformationQueriesNuggetJSON new_result)
          {
            handle_result((BusinessInformationQueriesHoursNuggetJSON )new_result);
          }
        protected void finish(BusinessInformationQueriesHoursNuggetJSON result)
          {
            if (fieldGeneratorOpenStatus.have_value)
              {
                result.setOpenStatus(fieldGeneratorOpenStatus.value);
                fieldGeneratorOpenStatus.have_value = false;
              }
            if (fieldGeneratorReferencedDateTime.have_value)
              {
                result.setReferencedDateTime(fieldGeneratorReferencedDateTime.value);
                fieldGeneratorReferencedDateTime.have_value = false;
              }
            if (fieldGeneratorHours.have_value)
              {
                result.setHours(fieldGeneratorHours.value);
                fieldGeneratorHours.have_value = false;
              }
            if (fieldGeneratorHoursGroups.have_value)
              {
                result.initHoursGroups();
                int count = fieldGeneratorHoursGroups.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHoursGroups(fieldGeneratorHoursGroups.value[num]);
                  }
                fieldGeneratorHoursGroups.value.Clear();
                fieldGeneratorHoursGroups.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(BusinessInformationQueriesHoursNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'H':
                    if (String.Compare(field_name, 1, "ours", 0, 4, false) == 0)
                      {
                        if (field_name.Length == 5)
                          {
                            return fieldGeneratorHours;
                          }
                        switch (field_name[5])
                          {
                            case 'G':
                                if ((String.Compare(field_name, 6, "roups", 0, 5, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorHoursGroups;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "penStatus", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorOpenStatus;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eferencedDateTime", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorReferencedDateTime;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorOpenStatus = new FieldHoldingGeneratorOpenStatus("field \"OpenStatus\" of the BusinessInformationQueriesHoursNugget class");
            fieldGeneratorReferencedDateTime = new DateTimeSpecJSON.HoldingGenerator("field \"ReferencedDateTime\" of the BusinessInformationQueriesHoursNugget class", ignore_extras);
            fieldGeneratorHours = new BusinessInformationDataWeeklyHoursJSON.HoldingGenerator("field \"Hours\" of the BusinessInformationQueriesHoursNugget class", ignore_extras);
            fieldGeneratorHoursGroups = new BusinessInformationQueriesDaysListJSON.HoldingArrayGenerator("field \"HoursGroups\" of the BusinessInformationQueriesHoursNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BusinessInformationQueriesHoursNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorOpenStatus = new FieldHoldingGeneratorOpenStatus("field \"OpenStatus\" of the BusinessInformationQueriesHoursNugget class");
            fieldGeneratorReferencedDateTime = new DateTimeSpecJSON.HoldingGenerator("field \"ReferencedDateTime\" of the BusinessInformationQueriesHoursNugget class", false);
            fieldGeneratorHours = new BusinessInformationDataWeeklyHoursJSON.HoldingGenerator("field \"Hours\" of the BusinessInformationQueriesHoursNugget class", false);
            fieldGeneratorHoursGroups = new BusinessInformationQueriesDaysListJSON.HoldingArrayGenerator("field \"HoursGroups\" of the BusinessInformationQueriesHoursNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BusinessInformationQueriesHoursNugget class");
          }

        public override void reset()
          {
            fieldGeneratorOpenStatus.reset();
            fieldGeneratorReferencedDateTime.reset();
            fieldGeneratorHours.reset();
            fieldGeneratorHoursGroups.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(BusinessInformationQueriesHoursNuggetJSON  result)
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
        public BusinessInformationQueriesHoursNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BusinessInformationQueriesHoursNuggetJSON  result)
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
    protected virtual void handle_result(List<BusinessInformationQueriesHoursNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BusinessInformationQueriesHoursNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BusinessInformationQueriesHoursNuggetJSON>();
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
    public List<BusinessInformationQueriesHoursNuggetJSON> value;
  };
  };
