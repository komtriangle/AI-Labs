/* file "ThirdPartyCalendarModifyEventInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ThirdPartyCalendarModifyEventInformationNuggetJSON : ThirdPartyCalendarInformationNuggetJSON
  {
    public enum TypeChangedFieldsKnownValues
      {
        ChangedFields_Title,
        ChangedFields_StartDateTime,
        ChangedFields_EndDateTime,
        ChangedFields_Location,
        ChangedFields_AddAttendees,
        ChangedFields_RemoveAttendees,
        ChangedFields_SelfAttendeeStatus,
        ChangedFields__none
      };
    public struct TypeChangedFields
      {
        public bool in_known_list;
        public string string_value;
        public TypeChangedFieldsKnownValues list_value;
      };

    public static TypeChangedFieldsKnownValues  stringToChangedFields(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ddAttendees", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeChangedFieldsKnownValues.ChangedFields_AddAttendees;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "ndDateTime", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeChangedFieldsKnownValues.ChangedFields_EndDateTime;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ocation", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeChangedFieldsKnownValues.ChangedFields_Location;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "emoveAttendees", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeChangedFieldsKnownValues.ChangedFields_RemoveAttendees;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "lfAttendeeStatus", 0, 16, false) == 0) && (chars.Length == 18))
                            return TypeChangedFieldsKnownValues.ChangedFields_SelfAttendeeStatus;
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "artDateTime", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeChangedFieldsKnownValues.ChangedFields_StartDateTime;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "itle", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeChangedFieldsKnownValues.ChangedFields_Title;
                break;
            default:
                break;
          }
        return TypeChangedFieldsKnownValues.ChangedFields__none;
      }

    public static string  stringFromChangedFields(TypeChangedFieldsKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeChangedFieldsKnownValues.ChangedFields_Title:
                return "Title";
            case TypeChangedFieldsKnownValues.ChangedFields_StartDateTime:
                return "StartDateTime";
            case TypeChangedFieldsKnownValues.ChangedFields_EndDateTime:
                return "EndDateTime";
            case TypeChangedFieldsKnownValues.ChangedFields_Location:
                return "Location";
            case TypeChangedFieldsKnownValues.ChangedFields_AddAttendees:
                return "AddAttendees";
            case TypeChangedFieldsKnownValues.ChangedFields_RemoveAttendees:
                return "RemoveAttendees";
            case TypeChangedFieldsKnownValues.ChangedFields_SelfAttendeeStatus:
                return "SelfAttendeeStatus";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasEvent;
    private ThirdPartyCalendarEventJSON  storeEvent;
    private bool flagHasChangedFields;
    private List< TypeChangedFields > storeChangedFields;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraEventToJSON()
      {
        JSONValueHandler handler_Event = new JSONValueHandler();
        storeEvent.write_as_json(handler_Event);
        return handler_Event.result;
      }

    private JSONValue  extraChangedFieldsToJSON()
      {
        JSONArrayValue generated_array_1_ChangedFields = new JSONArrayValue();
        for (int num1 = 0; num1 < storeChangedFields.Count; ++num1)
          {
            JSONStringValue generated_string_ChangedFields;
            if (!(storeChangedFields[num1].in_known_list))
              {
            generated_string_ChangedFields = new JSONStringValue(storeChangedFields[num1].string_value);
              }
            else
              {
            switch (storeChangedFields[num1].list_value)
              {
                case TypeChangedFieldsKnownValues.ChangedFields_Title:
                    generated_string_ChangedFields = new JSONStringValue("Title");
                    break;
                case TypeChangedFieldsKnownValues.ChangedFields_StartDateTime:
                    generated_string_ChangedFields = new JSONStringValue("StartDateTime");
                    break;
                case TypeChangedFieldsKnownValues.ChangedFields_EndDateTime:
                    generated_string_ChangedFields = new JSONStringValue("EndDateTime");
                    break;
                case TypeChangedFieldsKnownValues.ChangedFields_Location:
                    generated_string_ChangedFields = new JSONStringValue("Location");
                    break;
                case TypeChangedFieldsKnownValues.ChangedFields_AddAttendees:
                    generated_string_ChangedFields = new JSONStringValue("AddAttendees");
                    break;
                case TypeChangedFieldsKnownValues.ChangedFields_RemoveAttendees:
                    generated_string_ChangedFields = new JSONStringValue("RemoveAttendees");
                    break;
                case TypeChangedFieldsKnownValues.ChangedFields_SelfAttendeeStatus:
                    generated_string_ChangedFields = new JSONStringValue("SelfAttendeeStatus");
                    break;
                default:
                    Debug.Assert(false);
                    generated_string_ChangedFields = null;
                    break;
              }
              }
            generated_array_1_ChangedFields.appendComponent(generated_string_ChangedFields);
          }
        return generated_array_1_ChangedFields;
      }


    private void  fromJSONEvent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ThirdPartyCalendarEventJSON convert_classy = ThirdPartyCalendarEventJSON.from_json(json_value, ignore_extras, true);
        setEvent(convert_classy);
      }


    private void  fromJSONChangedFields(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ChangedFields of ThirdPartyCalendarModifyEventInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ChangedFields of ThirdPartyCalendarModifyEventInformationNuggetJSON has too few elements.");
        List< TypeChangedFields > vector_ChangedFields1 = new List< TypeChangedFields >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ChangedFields of ThirdPartyCalendarModifyEventInformationNuggetJSON is not a string.");
            TypeChangedFields the_open_enum = new TypeChangedFields();
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "ddAttendees", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeChangedFieldsKnownValues.ChangedFields_AddAttendees;
                            goto open_enum_is_done;
                          }
                    break;
                case 'E':
                    if ((String.Compare(json_string.getData(), 1, "ndDateTime", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeChangedFieldsKnownValues.ChangedFields_EndDateTime;
                            goto open_enum_is_done;
                          }
                    break;
                case 'L':
                    if ((String.Compare(json_string.getData(), 1, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeChangedFieldsKnownValues.ChangedFields_Location;
                            goto open_enum_is_done;
                          }
                    break;
                case 'R':
                    if ((String.Compare(json_string.getData(), 1, "emoveAttendees", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeChangedFieldsKnownValues.ChangedFields_RemoveAttendees;
                            goto open_enum_is_done;
                          }
                    break;
                case 'S':
                    switch (json_string.getData()[1])
                      {
                        case 'e':
                            if ((String.Compare(json_string.getData(), 2, "lfAttendeeStatus", 0, 16, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeChangedFieldsKnownValues.ChangedFields_SelfAttendeeStatus;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 't':
                            if ((String.Compare(json_string.getData(), 2, "artDateTime", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeChangedFieldsKnownValues.ChangedFields_StartDateTime;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(json_string.getData(), 1, "itle", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeChangedFieldsKnownValues.ChangedFields_Title;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            vector_ChangedFields1.Add(the_open_enum);
          }
        Debug.Assert(vector_ChangedFields1.Count >= 1);
        initChangedFields();
        for (int num1 = 0; num1 < vector_ChangedFields1.Count; ++num1)
            appendChangedFields(vector_ChangedFields1[num1]);
        for (int num1 = 0; num1 < vector_ChangedFields1.Count; ++num1)
          {
          }
      }


    public ThirdPartyCalendarModifyEventInformationNuggetJSON()
      {
        flagHasEvent = false;
        flagHasChangedFields = false;
        storeChangedFields = new List< TypeChangedFields >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyCalendarInformationNuggetType()
      {
        return "ThirdPartyCalendarModifyEventInformationNugget";
      }

    public bool  hasEvent()
      {
        return flagHasEvent;
      }

    public ThirdPartyCalendarEventJSON   getEvent()
      {
        Debug.Assert(flagHasEvent);
        return storeEvent;
      }

    public bool  hasChangedFields()
      {
        return flagHasChangedFields;
      }

    public int  countOfChangedFields()
      {
        Debug.Assert(flagHasChangedFields);
        return storeChangedFields.Count;
      }

    public TypeChangedFields  elementOfChangedFields(int element_num)
      {
        Debug.Assert(flagHasChangedFields);
        return storeChangedFields[element_num];
      }

    public List< TypeChangedFields >  getChangedFields()
      {
        Debug.Assert(flagHasChangedFields);
        return storeChangedFields;
      }


    public virtual int extraThirdPartyCalendarModifyEventInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraThirdPartyCalendarModifyEventInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarModifyEventInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraThirdPartyCalendarModifyEventInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraThirdPartyCalendarInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasEvent)
            ++result;
        if (flagHasChangedFields)
            ++result;
        result += extraThirdPartyCalendarModifyEventInformationNuggetComponentCount();
        return result;
      }
    public override string extraThirdPartyCalendarInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasEvent)
          {
            if (remainder == 0)
                return "Event";
            --remainder;
          }
        if (flagHasChangedFields)
          {
            if (remainder == 0)
                return "ChangedFields";
            --remainder;
          }
        return extraThirdPartyCalendarModifyEventInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasEvent)
          {
            if (remainder == 0)
                return extraEventToJSON();
            --remainder;
          }
        if (flagHasChangedFields)
          {
            if (remainder == 0)
                return extraChangedFieldsToJSON();
            --remainder;
          }
        return extraThirdPartyCalendarModifyEventInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraThirdPartyCalendarInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "hangedFields", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasChangedFields ? extraChangedFieldsToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "vent", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasEvent ? extraEventToJSON() : null);
                break;
            default:
                break;
          }
        return extraThirdPartyCalendarModifyEventInformationNuggetLookup(field_name);
      }

    public void setEvent(ThirdPartyCalendarEventJSON  new_value)
      {
        if (flagHasEvent)
          {
          }
        flagHasEvent = true;
        storeEvent = new_value;
      }
    public void unsetEvent()
      {
        if (flagHasEvent)
          {
          }
        flagHasEvent = false;
      }
    public void initChangedFields()
      {
        flagHasChangedFields = true;
        storeChangedFields.Clear();
      }
    public void appendChangedFields(TypeChangedFields to_append)
      {
        if (!flagHasChangedFields)
          {
            flagHasChangedFields = true;
            storeChangedFields.Clear();
          }
        Debug.Assert(flagHasChangedFields);
        storeChangedFields.Add(to_append);
      }
    public void appendChangedFields(string chars)
      {
        TypeChangedFieldsKnownValues known = stringToChangedFields(chars);
        TypeChangedFields new_value = new TypeChangedFields();
        if (known == TypeChangedFieldsKnownValues.ChangedFields__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendChangedFields(new_value);
      }
    public void appendChangedFields(TypeChangedFieldsKnownValues new_value)
      {
        TypeChangedFields new_full_value = new TypeChangedFields();
        Debug.Assert(new_value != TypeChangedFieldsKnownValues.ChangedFields__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        appendChangedFields(new_full_value);
      }
    public void unsetChangedFields()
      {
        flagHasChangedFields = false;
        storeChangedFields.Clear();
      }

    public virtual void extraThirdPartyCalendarModifyEventInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraThirdPartyCalendarModifyEventInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraThirdPartyCalendarModifyEventInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraThirdPartyCalendarModifyEventInformationNuggetAppendPair(key, new_component);
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
    public override void extraThirdPartyCalendarInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hangedFields", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONChangedFields(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "vent", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEvent(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraThirdPartyCalendarModifyEventInformationNuggetAppendPair(key, new_component);
      }
    public override void extraThirdPartyCalendarInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hangedFields", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONChangedFields(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "vent", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEvent(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraThirdPartyCalendarModifyEventInformationNuggetSetField(key, new_component);
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
        if (flagHasEvent)
          {
            handler.start_pair("Event");
            if (partial_allowed)
                storeEvent.write_partial_as_json(handler);
            else
                storeEvent.write_as_json(handler);
          }
        if (flagHasChangedFields)
          {
            handler.start_pair("ChangedFields");
            Debug.Assert(storeChangedFields.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeChangedFields.Count; ++num1)
              {
                if (storeChangedFields[num1].in_known_list)
                  {
                    switch (storeChangedFields[num1].list_value)
                      {
                        case TypeChangedFieldsKnownValues.ChangedFields_Title:
                            handler.string_value("Title");
                            break;
                        case TypeChangedFieldsKnownValues.ChangedFields_StartDateTime:
                            handler.string_value("StartDateTime");
                            break;
                        case TypeChangedFieldsKnownValues.ChangedFields_EndDateTime:
                            handler.string_value("EndDateTime");
                            break;
                        case TypeChangedFieldsKnownValues.ChangedFields_Location:
                            handler.string_value("Location");
                            break;
                        case TypeChangedFieldsKnownValues.ChangedFields_AddAttendees:
                            handler.string_value("AddAttendees");
                            break;
                        case TypeChangedFieldsKnownValues.ChangedFields_RemoveAttendees:
                            handler.string_value("RemoveAttendees");
                            break;
                        case TypeChangedFieldsKnownValues.ChangedFields_SelfAttendeeStatus:
                            handler.string_value("SelfAttendeeStatus");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeChangedFields[num1].string_value);
                  }
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

    public static new ThirdPartyCalendarModifyEventInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarModifyEventInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarModifyEventInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarModifyEventInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarModifyEventInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ThirdPartyCalendarModifyEventInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarModifyEventInformationNugget", ignore_extras);
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
    public static new ThirdPartyCalendarModifyEventInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ThirdPartyCalendarModifyEventInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ThirdPartyCalendarModifyEventInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarModifyEventInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ThirdPartyCalendarModifyEventInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ThirdPartyCalendarModifyEventInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ThirdPartyCalendarModifyEventInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ThirdPartyCalendarModifyEventInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ThirdPartyCalendarInformationNuggetJSON.Generator
      {
        private ThirdPartyCalendarEventJSON.HoldingGenerator fieldGeneratorEvent;
    private abstract class FieldGeneratorChangedFields : JSONStringGenerator
          {
            protected FieldGeneratorChangedFields(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorChangedFields()
              {
              }
            protected override void handle_result(string result)
              {
                TypeChangedFieldsKnownValues known = stringToChangedFields(result);
                TypeChangedFields new_value = new TypeChangedFields();
                if (known == TypeChangedFieldsKnownValues.ChangedFields__none)
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
            protected abstract void handle_result(TypeChangedFields result);
          };
    private class FieldHoldingGeneratorChangedFields : FieldGeneratorChangedFields
  {
    protected override void handle_result(TypeChangedFields result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorChangedFields(String what)
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
    public TypeChangedFields value;
  };
    private class FieldHoldingArrayGeneratorChangedFields : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorChangedFields
      {
        private FieldHoldingArrayGeneratorChangedFields top;

        protected override void handle_result(TypeChangedFields result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorChangedFields init_top)
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
    protected virtual void handle_result(List<TypeChangedFields> result)
      {
      }

    public FieldHoldingArrayGeneratorChangedFields(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeChangedFields>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorChangedFields()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeChangedFields>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeChangedFields> value;
  };
        private FieldHoldingArrayGeneratorChangedFields fieldGeneratorChangedFields;
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
            if (!(getThirdPartyCalendarInformationNuggetJSONKey().Equals("ThirdPartyCalendarModifyEventInformationNugget")))
                throw new Exception("The key field has a value other than `ThirdPartyCalendarModifyEventInformationNugget'.");
            ThirdPartyCalendarModifyEventInformationNuggetJSON result = new ThirdPartyCalendarModifyEventInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraThirdPartyCalendarModifyEventInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ThirdPartyCalendarInformationNuggetJSON new_result)
          {
            handle_result((ThirdPartyCalendarModifyEventInformationNuggetJSON )new_result);
          }
        protected void finish(ThirdPartyCalendarModifyEventInformationNuggetJSON result)
          {
            if (fieldGeneratorEvent.have_value)
              {
                result.setEvent(fieldGeneratorEvent.value);
                fieldGeneratorEvent.have_value = false;
              }
            if (fieldGeneratorChangedFields.have_value)
              {
                result.initChangedFields();
                int count = fieldGeneratorChangedFields.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendChangedFields(fieldGeneratorChangedFields.value[num]);
                  }
                fieldGeneratorChangedFields.value.Clear();
                fieldGeneratorChangedFields.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ThirdPartyCalendarModifyEventInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hangedFields", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorChangedFields;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "vent", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorEvent;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorEvent = new ThirdPartyCalendarEventJSON.HoldingGenerator("field \"Event\" of the ThirdPartyCalendarModifyEventInformationNugget class", ignore_extras);
            fieldGeneratorChangedFields = new FieldHoldingArrayGeneratorChangedFields("field \"ChangedFields\" of the ThirdPartyCalendarModifyEventInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ThirdPartyCalendarModifyEventInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorEvent = new ThirdPartyCalendarEventJSON.HoldingGenerator("field \"Event\" of the ThirdPartyCalendarModifyEventInformationNugget class", false);
            fieldGeneratorChangedFields = new FieldHoldingArrayGeneratorChangedFields("field \"ChangedFields\" of the ThirdPartyCalendarModifyEventInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ThirdPartyCalendarModifyEventInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorEvent.reset();
            fieldGeneratorChangedFields.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ThirdPartyCalendarModifyEventInformationNuggetJSON  result)
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
        public ThirdPartyCalendarModifyEventInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ThirdPartyCalendarModifyEventInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ThirdPartyCalendarModifyEventInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ThirdPartyCalendarModifyEventInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ThirdPartyCalendarModifyEventInformationNuggetJSON>();
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
    public List<ThirdPartyCalendarModifyEventInformationNuggetJSON> value;
  };
  };
