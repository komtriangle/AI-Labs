/* file "DisplayCalendarItemsCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DisplayCalendarItemsCommandJSON : CalendarCommandJSON
  {
    public enum TypeSelfAttendeeStatus
      {
        SelfAttendeeStatus_None,
        SelfAttendeeStatus_Accepted,
        SelfAttendeeStatus_Declined,
        SelfAttendeeStatus_Invited,
        SelfAttendeeStatus_Tentative
      };

    public static TypeSelfAttendeeStatus  stringToSelfAttendeeStatus(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ccepted", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "eclined", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nvited", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_None;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "entative", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `SelfAttendeeStatus' is not one of the legal values.");
      }

    public static string  stringFromSelfAttendeeStatus(TypeSelfAttendeeStatus the_enum)
      {
        switch (the_enum)
          {
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_None:
                return "None";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted:
                return "Accepted";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined:
                return "Declined";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited:
                return "Invited";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative:
                return "Tentative";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeNativeDataJSON : JSONBase
      {
        public enum TypeSelfAttendeeStatus
          {
            SelfAttendeeStatus_None,
            SelfAttendeeStatus_Accepted,
            SelfAttendeeStatus_Declined,
            SelfAttendeeStatus_Invited,
            SelfAttendeeStatus_Tentative
          };

        public static TypeSelfAttendeeStatus  stringToSelfAttendeeStatus(string chars)
          {
            switch (chars[0])
              {
                case 'A':
                    if ((String.Compare(chars, 1, "ccepted", 0, 7, false) == 0) && (chars.Length == 8))
                        return TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted;
                    break;
                case 'D':
                    if ((String.Compare(chars, 1, "eclined", 0, 7, false) == 0) && (chars.Length == 8))
                        return TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined;
                    break;
                case 'I':
                    if ((String.Compare(chars, 1, "nvited", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited;
                    break;
                case 'N':
                    if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeSelfAttendeeStatus.SelfAttendeeStatus_None;
                    break;
                case 'T':
                    if ((String.Compare(chars, 1, "entative", 0, 8, false) == 0) && (chars.Length == 9))
                        return TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `SelfAttendeeStatus' is not one of the legal values.");
          }

        public static string  stringFromSelfAttendeeStatus(TypeSelfAttendeeStatus the_enum)
          {
            switch (the_enum)
              {
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_None:
                    return "None";
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted:
                    return "Accepted";
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined:
                    return "Declined";
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited:
                    return "Invited";
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative:
                    return "Tentative";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasItemType;
        private string storeItemType;
        private bool flagHasExactTitle;
        private string storeExactTitle;
        private bool flagHasPartialTitle;
        private string storePartialTitle;
        private bool flagHasExactLocation;
        private string storeExactLocation;
        private bool flagHasPartialLocation;
        private string storePartialLocation;
        private bool flagHasLocationSpecifier;
        private CalendarLocationJSON  storeLocationSpecifier;
        private bool flagHasStartStart;
        private DateAndOrTimeJSON  storeStartStart;
        private bool flagHasEndStart;
        private DateAndOrTimeJSON  storeEndStart;
        private bool flagHasStartEnd;
        private DateAndOrTimeJSON  storeStartEnd;
        private bool flagHasEndEnd;
        private DateAndOrTimeJSON  storeEndEnd;
        private bool flagHasAttendees;
        private List< string > storeAttendees;
        private bool flagHasSelfAttendeeStatus;
        private TypeSelfAttendeeStatus storeSelfAttendeeStatus;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONItemType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ItemType of TypeNativeDataJSON is not a string.");
            setItemType(json_string.getData());
          }


        private void  fromJSONExactTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ExactTitle of TypeNativeDataJSON is not a string.");
            setExactTitle(json_string.getData());
          }


        private void  fromJSONPartialTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PartialTitle of TypeNativeDataJSON is not a string.");
            setPartialTitle(json_string.getData());
          }


        private void  fromJSONExactLocation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ExactLocation of TypeNativeDataJSON is not a string.");
            setExactLocation(json_string.getData());
          }


        private void  fromJSONPartialLocation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PartialLocation of TypeNativeDataJSON is not a string.");
            setPartialLocation(json_string.getData());
          }


        private void  fromJSONLocationSpecifier(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
            setLocationSpecifier(convert_classy);
          }


        private void  fromJSONStartStart(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setStartStart(convert_classy);
          }


        private void  fromJSONEndStart(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setEndStart(convert_classy);
          }


        private void  fromJSONStartEnd(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setStartEnd(convert_classy);
          }


        private void  fromJSONEndEnd(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setEndEnd(convert_classy);
          }


        private void  fromJSONAttendees(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Attendees of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< string > vector_Attendees1 = new List< string >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONStringValue json_string = json_array1.component(num1).string_value();
                if (json_string == null)
                    throw new Exception("The value for an element of field Attendees of TypeNativeDataJSON is not a string.");
                vector_Attendees1.Add(json_string.getData());
              }
            initAttendees();
            for (int num1 = 0; num1 < vector_Attendees1.Count; ++num1)
                appendAttendees(vector_Attendees1[num1]);
            for (int num1 = 0; num1 < vector_Attendees1.Count; ++num1)
              {
              }
          }


        private void  fromJSONSelfAttendeeStatus(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SelfAttendeeStatus of TypeNativeDataJSON is not a string.");
            TypeSelfAttendeeStatus the_enum;
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "ccepted", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted;
                            goto enum_is_done;
                          }
                    break;
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "eclined", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined;
                            goto enum_is_done;
                          }
                    break;
                case 'I':
                    if ((String.Compare(json_string.getData(), 1, "nvited", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited;
                            goto enum_is_done;
                          }
                    break;
                case 'N':
                    if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_None;
                            goto enum_is_done;
                          }
                    break;
                case 'T':
                    if ((String.Compare(json_string.getData(), 1, "entative", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field SelfAttendeeStatus of TypeNativeDataJSON is not one of the legal strings.");
          enum_is_done:;
            setSelfAttendeeStatus(the_enum);
          }


        public TypeNativeDataJSON()
          {
            flagHasItemType = false;
            flagHasExactTitle = false;
            flagHasPartialTitle = false;
            flagHasExactLocation = false;
            flagHasPartialLocation = false;
            flagHasLocationSpecifier = false;
            flagHasStartStart = false;
            flagHasEndStart = false;
            flagHasStartEnd = false;
            flagHasEndEnd = false;
            flagHasAttendees = false;
            flagHasSelfAttendeeStatus = false;
            storeAttendees = new List< string >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasItemType()
          {
            return flagHasItemType;
          }

        public string  getItemType()
          {
            Debug.Assert(flagHasItemType);
            return storeItemType;
          }

        public bool  hasExactTitle()
          {
            return flagHasExactTitle;
          }

        public string  getExactTitle()
          {
            Debug.Assert(flagHasExactTitle);
            return storeExactTitle;
          }

        public bool  hasPartialTitle()
          {
            return flagHasPartialTitle;
          }

        public string  getPartialTitle()
          {
            Debug.Assert(flagHasPartialTitle);
            return storePartialTitle;
          }

        public bool  hasExactLocation()
          {
            return flagHasExactLocation;
          }

        public string  getExactLocation()
          {
            Debug.Assert(flagHasExactLocation);
            return storeExactLocation;
          }

        public bool  hasPartialLocation()
          {
            return flagHasPartialLocation;
          }

        public string  getPartialLocation()
          {
            Debug.Assert(flagHasPartialLocation);
            return storePartialLocation;
          }

        public bool  hasLocationSpecifier()
          {
            return flagHasLocationSpecifier;
          }

        public CalendarLocationJSON   getLocationSpecifier()
          {
            Debug.Assert(flagHasLocationSpecifier);
            return storeLocationSpecifier;
          }

        public bool  hasStartStart()
          {
            return flagHasStartStart;
          }

        public DateAndOrTimeJSON   getStartStart()
          {
            Debug.Assert(flagHasStartStart);
            return storeStartStart;
          }

        public bool  hasEndStart()
          {
            return flagHasEndStart;
          }

        public DateAndOrTimeJSON   getEndStart()
          {
            Debug.Assert(flagHasEndStart);
            return storeEndStart;
          }

        public bool  hasStartEnd()
          {
            return flagHasStartEnd;
          }

        public DateAndOrTimeJSON   getStartEnd()
          {
            Debug.Assert(flagHasStartEnd);
            return storeStartEnd;
          }

        public bool  hasEndEnd()
          {
            return flagHasEndEnd;
          }

        public DateAndOrTimeJSON   getEndEnd()
          {
            Debug.Assert(flagHasEndEnd);
            return storeEndEnd;
          }

        public bool  hasAttendees()
          {
            return flagHasAttendees;
          }

        public int  countOfAttendees()
          {
            Debug.Assert(flagHasAttendees);
            return storeAttendees.Count;
          }

        public string  elementOfAttendees(int element_num)
          {
            Debug.Assert(flagHasAttendees);
            return storeAttendees[element_num];
          }

        public List< string >  getAttendees()
          {
            Debug.Assert(flagHasAttendees);
            return storeAttendees;
          }

        public bool  hasSelfAttendeeStatus()
          {
            return flagHasSelfAttendeeStatus;
          }

        public TypeSelfAttendeeStatus  getSelfAttendeeStatus()
          {
            Debug.Assert(flagHasSelfAttendeeStatus);
            return storeSelfAttendeeStatus;
          }

        public string  getSelfAttendeeStatusAsString()
          {
            return stringFromSelfAttendeeStatus(getSelfAttendeeStatus());
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setItemType(string new_value)
          {
            flagHasItemType = true;
            storeItemType = new_value;
          }
        public void unsetItemType()
          {
            flagHasItemType = false;
          }
        public void setExactTitle(string new_value)
          {
            flagHasExactTitle = true;
            storeExactTitle = new_value;
          }
        public void unsetExactTitle()
          {
            flagHasExactTitle = false;
          }
        public void setPartialTitle(string new_value)
          {
            flagHasPartialTitle = true;
            storePartialTitle = new_value;
          }
        public void unsetPartialTitle()
          {
            flagHasPartialTitle = false;
          }
        public void setExactLocation(string new_value)
          {
            flagHasExactLocation = true;
            storeExactLocation = new_value;
          }
        public void unsetExactLocation()
          {
            flagHasExactLocation = false;
          }
        public void setPartialLocation(string new_value)
          {
            flagHasPartialLocation = true;
            storePartialLocation = new_value;
          }
        public void unsetPartialLocation()
          {
            flagHasPartialLocation = false;
          }
        public void setLocationSpecifier(CalendarLocationJSON  new_value)
          {
            if (flagHasLocationSpecifier)
              {
              }
            flagHasLocationSpecifier = true;
            storeLocationSpecifier = new_value;
          }
        public void unsetLocationSpecifier()
          {
            if (flagHasLocationSpecifier)
              {
              }
            flagHasLocationSpecifier = false;
          }
        public void setStartStart(DateAndOrTimeJSON  new_value)
          {
            if (flagHasStartStart)
              {
              }
            flagHasStartStart = true;
            storeStartStart = new_value;
          }
        public void unsetStartStart()
          {
            if (flagHasStartStart)
              {
              }
            flagHasStartStart = false;
          }
        public void setEndStart(DateAndOrTimeJSON  new_value)
          {
            if (flagHasEndStart)
              {
              }
            flagHasEndStart = true;
            storeEndStart = new_value;
          }
        public void unsetEndStart()
          {
            if (flagHasEndStart)
              {
              }
            flagHasEndStart = false;
          }
        public void setStartEnd(DateAndOrTimeJSON  new_value)
          {
            if (flagHasStartEnd)
              {
              }
            flagHasStartEnd = true;
            storeStartEnd = new_value;
          }
        public void unsetStartEnd()
          {
            if (flagHasStartEnd)
              {
              }
            flagHasStartEnd = false;
          }
        public void setEndEnd(DateAndOrTimeJSON  new_value)
          {
            if (flagHasEndEnd)
              {
              }
            flagHasEndEnd = true;
            storeEndEnd = new_value;
          }
        public void unsetEndEnd()
          {
            if (flagHasEndEnd)
              {
              }
            flagHasEndEnd = false;
          }
        public void initAttendees()
          {
            flagHasAttendees = true;
            storeAttendees.Clear();
          }
        public void appendAttendees(string to_append)
          {
            if (!flagHasAttendees)
              {
                flagHasAttendees = true;
                storeAttendees.Clear();
              }
            Debug.Assert(flagHasAttendees);
            storeAttendees.Add(to_append);
          }
        public void unsetAttendees()
          {
            flagHasAttendees = false;
            storeAttendees.Clear();
          }
        public void setSelfAttendeeStatus(TypeSelfAttendeeStatus new_value)
          {
            flagHasSelfAttendeeStatus = true;
            storeSelfAttendeeStatus = new_value;
          }
        public void setSelfAttendeeStatus(string chars)
          {
            setSelfAttendeeStatus(stringToSelfAttendeeStatus(chars));
          }
        public void unsetSelfAttendeeStatus()
          {
            flagHasSelfAttendeeStatus = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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

        public virtual void write_fields_as_json(JSONHandler handler)
          {
            write_fields_as_json(handler, false);
          }

        public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
          {
            Debug.Assert(partial_allowed || flagHasItemType);
            if (flagHasItemType)
              {
                handler.start_pair("ItemType");
                handler.string_value(storeItemType);
              }
            Debug.Assert(partial_allowed || flagHasExactTitle);
            if (flagHasExactTitle)
              {
                handler.start_pair("ExactTitle");
                handler.string_value(storeExactTitle);
              }
            Debug.Assert(partial_allowed || flagHasPartialTitle);
            if (flagHasPartialTitle)
              {
                handler.start_pair("PartialTitle");
                handler.string_value(storePartialTitle);
              }
            Debug.Assert(partial_allowed || flagHasExactLocation);
            if (flagHasExactLocation)
              {
                handler.start_pair("ExactLocation");
                handler.string_value(storeExactLocation);
              }
            Debug.Assert(partial_allowed || flagHasPartialLocation);
            if (flagHasPartialLocation)
              {
                handler.start_pair("PartialLocation");
                handler.string_value(storePartialLocation);
              }
            if (flagHasLocationSpecifier)
              {
                handler.start_pair("LocationSpecifier");
                if (partial_allowed)
                    storeLocationSpecifier.write_partial_as_json(handler);
                else
                    storeLocationSpecifier.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasStartStart);
            if (flagHasStartStart)
              {
                handler.start_pair("StartStart");
                if (partial_allowed)
                    storeStartStart.write_partial_as_json(handler);
                else
                    storeStartStart.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasEndStart);
            if (flagHasEndStart)
              {
                handler.start_pair("EndStart");
                if (partial_allowed)
                    storeEndStart.write_partial_as_json(handler);
                else
                    storeEndStart.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasStartEnd);
            if (flagHasStartEnd)
              {
                handler.start_pair("StartEnd");
                if (partial_allowed)
                    storeStartEnd.write_partial_as_json(handler);
                else
                    storeStartEnd.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasEndEnd);
            if (flagHasEndEnd)
              {
                handler.start_pair("EndEnd");
                if (partial_allowed)
                    storeEndEnd.write_partial_as_json(handler);
                else
                    storeEndEnd.write_as_json(handler);
              }
            if (flagHasAttendees)
              {
                handler.start_pair("Attendees");
                handler.start_array();
                for (int num1 = 0; num1 < storeAttendees.Count; ++num1)
                  {
                    handler.string_value(storeAttendees[num1]);
                  }
                handler.finish_array();
              }
            if (flagHasSelfAttendeeStatus)
              {
                handler.start_pair("SelfAttendeeStatus");
                switch (storeSelfAttendeeStatus)
                  {
                    case TypeSelfAttendeeStatus.SelfAttendeeStatus_None:
                        handler.string_value("None");
                        break;
                    case TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted:
                        handler.string_value("Accepted");
                        break;
                    case TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined:
                        handler.string_value("Declined");
                        break;
                    case TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited:
                        handler.string_value("Invited");
                        break;
                    case TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative:
                        handler.string_value("Tentative");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
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
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasItemType()))
              {
                return "When parsing the object for %what%, the \"ItemType\" field was missing.";
              }
            if (!(hasExactTitle()))
              {
                return "When parsing the object for %what%, the \"ExactTitle\" field was missing.";
              }
            if (!(hasPartialTitle()))
              {
                return "When parsing the object for %what%, the \"PartialTitle\" field was missing.";
              }
            if (!(hasExactLocation()))
              {
                return "When parsing the object for %what%, the \"ExactLocation\" field was missing.";
              }
            if (!(hasPartialLocation()))
              {
                return "When parsing the object for %what%, the \"PartialLocation\" field was missing.";
              }
            if (!(hasStartStart()))
              {
                return "When parsing the object for %what%, the \"StartStart\" field was missing.";
              }
            if (!(hasEndStart()))
              {
                return "When parsing the object for %what%, the \"EndStart\" field was missing.";
              }
            if (!(hasStartEnd()))
              {
                return "When parsing the object for %what%, the \"StartEnd\" field was missing.";
              }
            if (!(hasEndEnd()))
              {
                return "When parsing the object for %what%, the \"EndEnd\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorItemType;
            private JSONHoldingStringGenerator fieldGeneratorExactTitle;
            private JSONHoldingStringGenerator fieldGeneratorPartialTitle;
            private JSONHoldingStringGenerator fieldGeneratorExactLocation;
            private JSONHoldingStringGenerator fieldGeneratorPartialLocation;
            private CalendarLocationJSON.HoldingGenerator fieldGeneratorLocationSpecifier;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartStart;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndStart;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartEnd;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndEnd;
            private JSONHoldingStringArrayGenerator fieldGeneratorAttendees;
        private abstract class FieldGeneratorSelfAttendeeStatus : JSONStringGenerator
              {
                protected FieldGeneratorSelfAttendeeStatus(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorSelfAttendeeStatus()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToSelfAttendeeStatus(result));
                  }
                protected abstract void handle_result(TypeSelfAttendeeStatus result);
              };
        private class FieldHoldingGeneratorSelfAttendeeStatus : FieldGeneratorSelfAttendeeStatus
      {
        protected override void handle_result(TypeSelfAttendeeStatus result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorSelfAttendeeStatus(String what)
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
        public TypeSelfAttendeeStatus value;
      };
        private class FieldHoldingArrayGeneratorSelfAttendeeStatus : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorSelfAttendeeStatus
          {
            private FieldHoldingArrayGeneratorSelfAttendeeStatus top;

            protected override void handle_result(TypeSelfAttendeeStatus result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorSelfAttendeeStatus init_top)
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
        protected virtual void handle_result(List<TypeSelfAttendeeStatus> result)
          {
          }

        public FieldHoldingArrayGeneratorSelfAttendeeStatus(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeSelfAttendeeStatus>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorSelfAttendeeStatus()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeSelfAttendeeStatus>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeSelfAttendeeStatus> value;
      };
            private FieldHoldingGeneratorSelfAttendeeStatus fieldGeneratorSelfAttendeeStatus;
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

            protected bool allow_incomplete;

            protected bool allow_unpolished;

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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorItemType.have_value)
                  {
                    result.setItemType(fieldGeneratorItemType.value);
                    fieldGeneratorItemType.have_value = false;
                  }
                else if ((!(result.hasItemType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ItemType\" field was missing.");
                  }
                if (fieldGeneratorExactTitle.have_value)
                  {
                    result.setExactTitle(fieldGeneratorExactTitle.value);
                    fieldGeneratorExactTitle.have_value = false;
                  }
                else if ((!(result.hasExactTitle())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ExactTitle\" field was missing.");
                  }
                if (fieldGeneratorPartialTitle.have_value)
                  {
                    result.setPartialTitle(fieldGeneratorPartialTitle.value);
                    fieldGeneratorPartialTitle.have_value = false;
                  }
                else if ((!(result.hasPartialTitle())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"PartialTitle\" field was missing.");
                  }
                if (fieldGeneratorExactLocation.have_value)
                  {
                    result.setExactLocation(fieldGeneratorExactLocation.value);
                    fieldGeneratorExactLocation.have_value = false;
                  }
                else if ((!(result.hasExactLocation())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ExactLocation\" field was missing.");
                  }
                if (fieldGeneratorPartialLocation.have_value)
                  {
                    result.setPartialLocation(fieldGeneratorPartialLocation.value);
                    fieldGeneratorPartialLocation.have_value = false;
                  }
                else if ((!(result.hasPartialLocation())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"PartialLocation\" field was missing.");
                  }
                if (fieldGeneratorLocationSpecifier.have_value)
                  {
                    result.setLocationSpecifier(fieldGeneratorLocationSpecifier.value);
                    fieldGeneratorLocationSpecifier.have_value = false;
                  }
                if (fieldGeneratorStartStart.have_value)
                  {
                    result.setStartStart(fieldGeneratorStartStart.value);
                    fieldGeneratorStartStart.have_value = false;
                  }
                else if ((!(result.hasStartStart())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartStart\" field was missing.");
                  }
                if (fieldGeneratorEndStart.have_value)
                  {
                    result.setEndStart(fieldGeneratorEndStart.value);
                    fieldGeneratorEndStart.have_value = false;
                  }
                else if ((!(result.hasEndStart())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndStart\" field was missing.");
                  }
                if (fieldGeneratorStartEnd.have_value)
                  {
                    result.setStartEnd(fieldGeneratorStartEnd.value);
                    fieldGeneratorStartEnd.have_value = false;
                  }
                else if ((!(result.hasStartEnd())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartEnd\" field was missing.");
                  }
                if (fieldGeneratorEndEnd.have_value)
                  {
                    result.setEndEnd(fieldGeneratorEndEnd.value);
                    fieldGeneratorEndEnd.have_value = false;
                  }
                else if ((!(result.hasEndEnd())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndEnd\" field was missing.");
                  }
                if (fieldGeneratorAttendees.have_value)
                  {
                    result.initAttendees();
                    int count = fieldGeneratorAttendees.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendAttendees(fieldGeneratorAttendees.value[num]);
                      }
                    fieldGeneratorAttendees.value.Clear();
                    fieldGeneratorAttendees.have_value = false;
                  }
                if (fieldGeneratorSelfAttendeeStatus.have_value)
                  {
                    result.setSelfAttendeeStatus(fieldGeneratorSelfAttendeeStatus.value);
                    fieldGeneratorSelfAttendeeStatus.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "ttendees", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorAttendees;
                        break;
                    case 'E':
                        switch (field_name[1])
                          {
                            case 'n':
                                if (String.Compare(field_name, 2, "d", 0, 1, false) == 0)
                                  {
                                    switch (field_name[3])
                                      {
                                        case 'E':
                                            if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                                return fieldGeneratorEndEnd;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 4, "tart", 0, 4, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorEndStart;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'x':
                                if (String.Compare(field_name, 2, "act", 0, 3, false) == 0)
                                  {
                                    switch (field_name[5])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 6, "ocation", 0, 7, false) == 0) && (field_name.Length == 13))
                                                return fieldGeneratorExactLocation;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 6, "itle", 0, 4, false) == 0) && (field_name.Length == 10))
                                                return fieldGeneratorExactTitle;
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
                    case 'I':
                        if ((String.Compare(field_name, 1, "temType", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorItemType;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "ocationSpecifier", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorLocationSpecifier;
                        break;
                    case 'P':
                        if (String.Compare(field_name, 1, "artial", 0, 6, false) == 0)
                          {
                            switch (field_name[7])
                              {
                                case 'L':
                                    if ((String.Compare(field_name, 8, "ocation", 0, 7, false) == 0) && (field_name.Length == 15))
                                        return fieldGeneratorPartialLocation;
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 8, "itle", 0, 4, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorPartialTitle;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 2, "lfAttendeeStatus", 0, 16, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorSelfAttendeeStatus;
                                break;
                            case 't':
                                if (String.Compare(field_name, 2, "art", 0, 3, false) == 0)
                                  {
                                    switch (field_name[5])
                                      {
                                        case 'E':
                                            if ((String.Compare(field_name, 6, "nd", 0, 2, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorStartEnd;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 6, "tart", 0, 4, false) == 0) && (field_name.Length == 10))
                                                return fieldGeneratorStartStart;
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
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorItemType = new JSONHoldingStringGenerator("field \"ItemType\" of the TypeNativeData class");
                fieldGeneratorExactTitle = new JSONHoldingStringGenerator("field \"ExactTitle\" of the TypeNativeData class");
                fieldGeneratorPartialTitle = new JSONHoldingStringGenerator("field \"PartialTitle\" of the TypeNativeData class");
                fieldGeneratorExactLocation = new JSONHoldingStringGenerator("field \"ExactLocation\" of the TypeNativeData class");
                fieldGeneratorPartialLocation = new JSONHoldingStringGenerator("field \"PartialLocation\" of the TypeNativeData class");
                fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorStartStart = new DateAndOrTimeJSON.HoldingGenerator("field \"StartStart\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorEndStart = new DateAndOrTimeJSON.HoldingGenerator("field \"EndStart\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorStartEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"StartEnd\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorEndEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"EndEnd\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorAttendees = new JSONHoldingStringArrayGenerator("field \"Attendees\" of the TypeNativeData class");
                fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorItemType = new JSONHoldingStringGenerator("field \"ItemType\" of the TypeNativeData class");
                fieldGeneratorExactTitle = new JSONHoldingStringGenerator("field \"ExactTitle\" of the TypeNativeData class");
                fieldGeneratorPartialTitle = new JSONHoldingStringGenerator("field \"PartialTitle\" of the TypeNativeData class");
                fieldGeneratorExactLocation = new JSONHoldingStringGenerator("field \"ExactLocation\" of the TypeNativeData class");
                fieldGeneratorPartialLocation = new JSONHoldingStringGenerator("field \"PartialLocation\" of the TypeNativeData class");
                fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the TypeNativeData class", false);
                fieldGeneratorStartStart = new DateAndOrTimeJSON.HoldingGenerator("field \"StartStart\" of the TypeNativeData class", false);
                fieldGeneratorEndStart = new DateAndOrTimeJSON.HoldingGenerator("field \"EndStart\" of the TypeNativeData class", false);
                fieldGeneratorStartEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"StartEnd\" of the TypeNativeData class", false);
                fieldGeneratorEndEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"EndEnd\" of the TypeNativeData class", false);
                fieldGeneratorAttendees = new JSONHoldingStringArrayGenerator("field \"Attendees\" of the TypeNativeData class");
                fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorItemType.reset();
                fieldGeneratorExactTitle.reset();
                fieldGeneratorPartialTitle.reset();
                fieldGeneratorExactLocation.reset();
                fieldGeneratorPartialLocation.reset();
                fieldGeneratorLocationSpecifier.reset();
                fieldGeneratorStartStart.reset();
                fieldGeneratorEndStart.reset();
                fieldGeneratorStartEnd.reset();
                fieldGeneratorEndEnd.reset();
                fieldGeneratorAttendees.reset();
                fieldGeneratorSelfAttendeeStatus.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorLocationSpecifier.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorStartStart.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorEndStart.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorStartEnd.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorEndEnd.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorLocationSpecifier.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorStartStart.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorEndStart.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorStartEnd.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorEndEnd.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasUserRequest;
    private CalendarUserRequestJSON  storeUserRequest;
    private bool flagHasItemType;
    private string storeItemType;
    private bool flagHasExactTitle;
    private string storeExactTitle;
    private bool flagHasPartialTitle;
    private string storePartialTitle;
    private bool flagHasExactLocation;
    private string storeExactLocation;
    private bool flagHasPartialLocation;
    private string storePartialLocation;
    private bool flagHasLocationSpecifier;
    private CalendarLocationJSON  storeLocationSpecifier;
    private bool flagHasStartStart;
    private DateAndOrTimeJSON  storeStartStart;
    private bool flagHasEndStart;
    private DateAndOrTimeJSON  storeEndStart;
    private bool flagHasStartEnd;
    private DateAndOrTimeJSON  storeStartEnd;
    private bool flagHasEndEnd;
    private DateAndOrTimeJSON  storeEndEnd;
    private bool flagHasAttendees;
    private List< string > storeAttendees;
    private bool flagHasSelfAttendeeStatus;
    private TypeSelfAttendeeStatus storeSelfAttendeeStatus;
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUserRequestToJSON()
      {
        JSONValueHandler handler_UserRequest = new JSONValueHandler();
        storeUserRequest.write_as_json(handler_UserRequest);
        return handler_UserRequest.result;
      }

    private JSONValue  extraItemTypeToJSON()
      {
        JSONStringValue generated_string_ItemType = new JSONStringValue(storeItemType);
        return generated_string_ItemType;
      }

    private JSONValue  extraExactTitleToJSON()
      {
        JSONStringValue generated_string_ExactTitle = new JSONStringValue(storeExactTitle);
        return generated_string_ExactTitle;
      }

    private JSONValue  extraPartialTitleToJSON()
      {
        JSONStringValue generated_string_PartialTitle = new JSONStringValue(storePartialTitle);
        return generated_string_PartialTitle;
      }

    private JSONValue  extraExactLocationToJSON()
      {
        JSONStringValue generated_string_ExactLocation = new JSONStringValue(storeExactLocation);
        return generated_string_ExactLocation;
      }

    private JSONValue  extraPartialLocationToJSON()
      {
        JSONStringValue generated_string_PartialLocation = new JSONStringValue(storePartialLocation);
        return generated_string_PartialLocation;
      }

    private JSONValue  extraLocationSpecifierToJSON()
      {
        JSONValueHandler handler_LocationSpecifier = new JSONValueHandler();
        storeLocationSpecifier.write_as_json(handler_LocationSpecifier);
        return handler_LocationSpecifier.result;
      }

    private JSONValue  extraStartStartToJSON()
      {
        JSONValueHandler handler_StartStart = new JSONValueHandler();
        storeStartStart.write_as_json(handler_StartStart);
        return handler_StartStart.result;
      }

    private JSONValue  extraEndStartToJSON()
      {
        JSONValueHandler handler_EndStart = new JSONValueHandler();
        storeEndStart.write_as_json(handler_EndStart);
        return handler_EndStart.result;
      }

    private JSONValue  extraStartEndToJSON()
      {
        JSONValueHandler handler_StartEnd = new JSONValueHandler();
        storeStartEnd.write_as_json(handler_StartEnd);
        return handler_StartEnd.result;
      }

    private JSONValue  extraEndEndToJSON()
      {
        JSONValueHandler handler_EndEnd = new JSONValueHandler();
        storeEndEnd.write_as_json(handler_EndEnd);
        return handler_EndEnd.result;
      }

    private JSONValue  extraAttendeesToJSON()
      {
        JSONArrayValue generated_array_1_Attendees = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAttendees.Count; ++num1)
          {
            JSONStringValue generated_string_Attendees = new JSONStringValue(storeAttendees[num1]);
            generated_array_1_Attendees.appendComponent(generated_string_Attendees);
          }
        return generated_array_1_Attendees;
      }

    private JSONValue  extraSelfAttendeeStatusToJSON()
      {
        JSONStringValue generated_string_SelfAttendeeStatus;
        switch (storeSelfAttendeeStatus)
          {
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_None:
                generated_string_SelfAttendeeStatus = new JSONStringValue("None");
                break;
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted:
                generated_string_SelfAttendeeStatus = new JSONStringValue("Accepted");
                break;
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined:
                generated_string_SelfAttendeeStatus = new JSONStringValue("Declined");
                break;
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited:
                generated_string_SelfAttendeeStatus = new JSONStringValue("Invited");
                break;
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative:
                generated_string_SelfAttendeeStatus = new JSONStringValue("Tentative");
                break;
            default:
                Debug.Assert(false);
                generated_string_SelfAttendeeStatus = null;
                break;
          }
        return generated_string_SelfAttendeeStatus;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONUserRequest(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarUserRequestJSON convert_classy = CalendarUserRequestJSON.from_json(json_value, ignore_extras, true);
        setUserRequest(convert_classy);
      }


    private void  fromJSONItemType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ItemType of DisplayCalendarItemsCommandJSON is not a string.");
        setItemType(json_string.getData());
      }


    private void  fromJSONExactTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExactTitle of DisplayCalendarItemsCommandJSON is not a string.");
        setExactTitle(json_string.getData());
      }


    private void  fromJSONPartialTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PartialTitle of DisplayCalendarItemsCommandJSON is not a string.");
        setPartialTitle(json_string.getData());
      }


    private void  fromJSONExactLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExactLocation of DisplayCalendarItemsCommandJSON is not a string.");
        setExactLocation(json_string.getData());
      }


    private void  fromJSONPartialLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PartialLocation of DisplayCalendarItemsCommandJSON is not a string.");
        setPartialLocation(json_string.getData());
      }


    private void  fromJSONLocationSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
        setLocationSpecifier(convert_classy);
      }


    private void  fromJSONStartStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartStart(convert_classy);
      }


    private void  fromJSONEndStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndStart(convert_classy);
      }


    private void  fromJSONStartEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartEnd(convert_classy);
      }


    private void  fromJSONEndEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndEnd(convert_classy);
      }


    private void  fromJSONAttendees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Attendees of DisplayCalendarItemsCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Attendees1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Attendees of DisplayCalendarItemsCommandJSON is not a string.");
            vector_Attendees1.Add(json_string.getData());
          }
        initAttendees();
        for (int num2 = 0; num2 < vector_Attendees1.Count; ++num2)
            appendAttendees(vector_Attendees1[num2]);
        for (int num1 = 0; num1 < vector_Attendees1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSelfAttendeeStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SelfAttendeeStatus of DisplayCalendarItemsCommandJSON is not a string.");
        TypeSelfAttendeeStatus the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ccepted", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "eclined", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nvited", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_None;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "entative", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field SelfAttendeeStatus of DisplayCalendarItemsCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setSelfAttendeeStatus(the_enum);
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public DisplayCalendarItemsCommandJSON()
      {
        flagHasUserRequest = false;
        flagHasItemType = false;
        flagHasExactTitle = false;
        flagHasPartialTitle = false;
        flagHasExactLocation = false;
        flagHasPartialLocation = false;
        flagHasLocationSpecifier = false;
        flagHasStartStart = false;
        flagHasEndStart = false;
        flagHasStartEnd = false;
        flagHasEndEnd = false;
        flagHasAttendees = false;
        flagHasSelfAttendeeStatus = false;
        flagHasNativeData = false;
        storeAttendees = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCalendarCommandKind()
      {
        return "DisplayItems";
      }

    public bool  hasUserRequest()
      {
        return flagHasUserRequest;
      }

    public CalendarUserRequestJSON   getUserRequest()
      {
        Debug.Assert(flagHasUserRequest);
        return storeUserRequest;
      }

    public bool  hasItemType()
      {
        return flagHasItemType;
      }

    public string  getItemType()
      {
        Debug.Assert(flagHasItemType);
        return storeItemType;
      }

    public bool  hasExactTitle()
      {
        return flagHasExactTitle;
      }

    public string  getExactTitle()
      {
        Debug.Assert(flagHasExactTitle);
        return storeExactTitle;
      }

    public bool  hasPartialTitle()
      {
        return flagHasPartialTitle;
      }

    public string  getPartialTitle()
      {
        Debug.Assert(flagHasPartialTitle);
        return storePartialTitle;
      }

    public bool  hasExactLocation()
      {
        return flagHasExactLocation;
      }

    public string  getExactLocation()
      {
        Debug.Assert(flagHasExactLocation);
        return storeExactLocation;
      }

    public bool  hasPartialLocation()
      {
        return flagHasPartialLocation;
      }

    public string  getPartialLocation()
      {
        Debug.Assert(flagHasPartialLocation);
        return storePartialLocation;
      }

    public bool  hasLocationSpecifier()
      {
        return flagHasLocationSpecifier;
      }

    public CalendarLocationJSON   getLocationSpecifier()
      {
        Debug.Assert(flagHasLocationSpecifier);
        return storeLocationSpecifier;
      }

    public bool  hasStartStart()
      {
        return flagHasStartStart;
      }

    public DateAndOrTimeJSON   getStartStart()
      {
        Debug.Assert(flagHasStartStart);
        return storeStartStart;
      }

    public bool  hasEndStart()
      {
        return flagHasEndStart;
      }

    public DateAndOrTimeJSON   getEndStart()
      {
        Debug.Assert(flagHasEndStart);
        return storeEndStart;
      }

    public bool  hasStartEnd()
      {
        return flagHasStartEnd;
      }

    public DateAndOrTimeJSON   getStartEnd()
      {
        Debug.Assert(flagHasStartEnd);
        return storeStartEnd;
      }

    public bool  hasEndEnd()
      {
        return flagHasEndEnd;
      }

    public DateAndOrTimeJSON   getEndEnd()
      {
        Debug.Assert(flagHasEndEnd);
        return storeEndEnd;
      }

    public bool  hasAttendees()
      {
        return flagHasAttendees;
      }

    public int  countOfAttendees()
      {
        Debug.Assert(flagHasAttendees);
        return storeAttendees.Count;
      }

    public string  elementOfAttendees(int element_num)
      {
        Debug.Assert(flagHasAttendees);
        return storeAttendees[element_num];
      }

    public List< string >  getAttendees()
      {
        Debug.Assert(flagHasAttendees);
        return storeAttendees;
      }

    public bool  hasSelfAttendeeStatus()
      {
        return flagHasSelfAttendeeStatus;
      }

    public TypeSelfAttendeeStatus  getSelfAttendeeStatus()
      {
        Debug.Assert(flagHasSelfAttendeeStatus);
        return storeSelfAttendeeStatus;
      }

    public string  getSelfAttendeeStatusAsString()
      {
        return stringFromSelfAttendeeStatus(getSelfAttendeeStatus());
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public virtual int extraDisplayCalendarItemsCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDisplayCalendarItemsCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDisplayCalendarItemsCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDisplayCalendarItemsCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCalendarCommandComponentCount()
      {
        int result = 0;
        if (flagHasUserRequest)
            ++result;
        if (flagHasItemType)
            ++result;
        if (flagHasExactTitle)
            ++result;
        if (flagHasPartialTitle)
            ++result;
        if (flagHasExactLocation)
            ++result;
        if (flagHasPartialLocation)
            ++result;
        if (flagHasLocationSpecifier)
            ++result;
        if (flagHasStartStart)
            ++result;
        if (flagHasEndStart)
            ++result;
        if (flagHasStartEnd)
            ++result;
        if (flagHasEndEnd)
            ++result;
        if (flagHasAttendees)
            ++result;
        if (flagHasSelfAttendeeStatus)
            ++result;
        if (flagHasNativeData)
            ++result;
        result += extraDisplayCalendarItemsCommandComponentCount();
        return result;
      }
    public override string extraCalendarCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserRequest)
          {
            if (remainder == 0)
                return "UserRequest";
            --remainder;
          }
        if (flagHasItemType)
          {
            if (remainder == 0)
                return "ItemType";
            --remainder;
          }
        if (flagHasExactTitle)
          {
            if (remainder == 0)
                return "ExactTitle";
            --remainder;
          }
        if (flagHasPartialTitle)
          {
            if (remainder == 0)
                return "PartialTitle";
            --remainder;
          }
        if (flagHasExactLocation)
          {
            if (remainder == 0)
                return "ExactLocation";
            --remainder;
          }
        if (flagHasPartialLocation)
          {
            if (remainder == 0)
                return "PartialLocation";
            --remainder;
          }
        if (flagHasLocationSpecifier)
          {
            if (remainder == 0)
                return "LocationSpecifier";
            --remainder;
          }
        if (flagHasStartStart)
          {
            if (remainder == 0)
                return "StartStart";
            --remainder;
          }
        if (flagHasEndStart)
          {
            if (remainder == 0)
                return "EndStart";
            --remainder;
          }
        if (flagHasStartEnd)
          {
            if (remainder == 0)
                return "StartEnd";
            --remainder;
          }
        if (flagHasEndEnd)
          {
            if (remainder == 0)
                return "EndEnd";
            --remainder;
          }
        if (flagHasAttendees)
          {
            if (remainder == 0)
                return "Attendees";
            --remainder;
          }
        if (flagHasSelfAttendeeStatus)
          {
            if (remainder == 0)
                return "SelfAttendeeStatus";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraDisplayCalendarItemsCommandComponentKey(remainder);
      }
    public override JSONValue extraCalendarCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserRequest)
          {
            if (remainder == 0)
                return extraUserRequestToJSON();
            --remainder;
          }
        if (flagHasItemType)
          {
            if (remainder == 0)
                return extraItemTypeToJSON();
            --remainder;
          }
        if (flagHasExactTitle)
          {
            if (remainder == 0)
                return extraExactTitleToJSON();
            --remainder;
          }
        if (flagHasPartialTitle)
          {
            if (remainder == 0)
                return extraPartialTitleToJSON();
            --remainder;
          }
        if (flagHasExactLocation)
          {
            if (remainder == 0)
                return extraExactLocationToJSON();
            --remainder;
          }
        if (flagHasPartialLocation)
          {
            if (remainder == 0)
                return extraPartialLocationToJSON();
            --remainder;
          }
        if (flagHasLocationSpecifier)
          {
            if (remainder == 0)
                return extraLocationSpecifierToJSON();
            --remainder;
          }
        if (flagHasStartStart)
          {
            if (remainder == 0)
                return extraStartStartToJSON();
            --remainder;
          }
        if (flagHasEndStart)
          {
            if (remainder == 0)
                return extraEndStartToJSON();
            --remainder;
          }
        if (flagHasStartEnd)
          {
            if (remainder == 0)
                return extraStartEndToJSON();
            --remainder;
          }
        if (flagHasEndEnd)
          {
            if (remainder == 0)
                return extraEndEndToJSON();
            --remainder;
          }
        if (flagHasAttendees)
          {
            if (remainder == 0)
                return extraAttendeesToJSON();
            --remainder;
          }
        if (flagHasSelfAttendeeStatus)
          {
            if (remainder == 0)
                return extraSelfAttendeeStatusToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraDisplayCalendarItemsCommandComponentValue(remainder);
      }
    public override JSONValue extraCalendarCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ttendees", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasAttendees ? extraAttendeesToJSON() : null);
                break;
            case 'E':
                switch (field_name[1])
                  {
                    case 'n':
                        if (String.Compare(field_name, 2, "d", 0, 1, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                        return (flagHasEndEnd ? extraEndEndToJSON() : null);
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 4, "tart", 0, 4, false) == 0) && (field_name.Length == 8))
                                        return (flagHasEndStart ? extraEndStartToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'x':
                        if (String.Compare(field_name, 2, "act", 0, 3, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'L':
                                    if ((String.Compare(field_name, 6, "ocation", 0, 7, false) == 0) && (field_name.Length == 13))
                                        return (flagHasExactLocation ? extraExactLocationToJSON() : null);
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 6, "itle", 0, 4, false) == 0) && (field_name.Length == 10))
                                        return (flagHasExactTitle ? extraExactTitleToJSON() : null);
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
            case 'I':
                if ((String.Compare(field_name, 1, "temType", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasItemType ? extraItemTypeToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocationSpecifier", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasLocationSpecifier ? extraLocationSpecifierToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNativeData ? extraNativeDataToJSON() : null);
                break;
            case 'P':
                if (String.Compare(field_name, 1, "artial", 0, 6, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'L':
                            if ((String.Compare(field_name, 8, "ocation", 0, 7, false) == 0) && (field_name.Length == 15))
                                return (flagHasPartialLocation ? extraPartialLocationToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 8, "itle", 0, 4, false) == 0) && (field_name.Length == 12))
                                return (flagHasPartialTitle ? extraPartialTitleToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 'e':
                        if ((String.Compare(field_name, 2, "lfAttendeeStatus", 0, 16, false) == 0) && (field_name.Length == 18))
                            return (flagHasSelfAttendeeStatus ? extraSelfAttendeeStatusToJSON() : null);
                        break;
                    case 't':
                        if (String.Compare(field_name, 2, "art", 0, 3, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 6, "nd", 0, 2, false) == 0) && (field_name.Length == 8))
                                        return (flagHasStartEnd ? extraStartEndToJSON() : null);
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 6, "tart", 0, 4, false) == 0) && (field_name.Length == 10))
                                        return (flagHasStartStart ? extraStartStartToJSON() : null);
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
            case 'U':
                if ((String.Compare(field_name, 1, "serRequest", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasUserRequest ? extraUserRequestToJSON() : null);
                break;
            default:
                break;
          }
        return extraDisplayCalendarItemsCommandLookup(field_name);
      }

    public void setUserRequest(CalendarUserRequestJSON  new_value)
      {
        if (flagHasUserRequest)
          {
          }
        flagHasUserRequest = true;
        storeUserRequest = new_value;
      }
    public void unsetUserRequest()
      {
        if (flagHasUserRequest)
          {
          }
        flagHasUserRequest = false;
      }
    public void setItemType(string new_value)
      {
        flagHasItemType = true;
        storeItemType = new_value;
      }
    public void unsetItemType()
      {
        flagHasItemType = false;
      }
    public void setExactTitle(string new_value)
      {
        flagHasExactTitle = true;
        storeExactTitle = new_value;
      }
    public void unsetExactTitle()
      {
        flagHasExactTitle = false;
      }
    public void setPartialTitle(string new_value)
      {
        flagHasPartialTitle = true;
        storePartialTitle = new_value;
      }
    public void unsetPartialTitle()
      {
        flagHasPartialTitle = false;
      }
    public void setExactLocation(string new_value)
      {
        flagHasExactLocation = true;
        storeExactLocation = new_value;
      }
    public void unsetExactLocation()
      {
        flagHasExactLocation = false;
      }
    public void setPartialLocation(string new_value)
      {
        flagHasPartialLocation = true;
        storePartialLocation = new_value;
      }
    public void unsetPartialLocation()
      {
        flagHasPartialLocation = false;
      }
    public void setLocationSpecifier(CalendarLocationJSON  new_value)
      {
        if (flagHasLocationSpecifier)
          {
          }
        flagHasLocationSpecifier = true;
        storeLocationSpecifier = new_value;
      }
    public void unsetLocationSpecifier()
      {
        if (flagHasLocationSpecifier)
          {
          }
        flagHasLocationSpecifier = false;
      }
    public void setStartStart(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartStart)
          {
          }
        flagHasStartStart = true;
        storeStartStart = new_value;
      }
    public void unsetStartStart()
      {
        if (flagHasStartStart)
          {
          }
        flagHasStartStart = false;
      }
    public void setEndStart(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndStart)
          {
          }
        flagHasEndStart = true;
        storeEndStart = new_value;
      }
    public void unsetEndStart()
      {
        if (flagHasEndStart)
          {
          }
        flagHasEndStart = false;
      }
    public void setStartEnd(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartEnd)
          {
          }
        flagHasStartEnd = true;
        storeStartEnd = new_value;
      }
    public void unsetStartEnd()
      {
        if (flagHasStartEnd)
          {
          }
        flagHasStartEnd = false;
      }
    public void setEndEnd(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndEnd)
          {
          }
        flagHasEndEnd = true;
        storeEndEnd = new_value;
      }
    public void unsetEndEnd()
      {
        if (flagHasEndEnd)
          {
          }
        flagHasEndEnd = false;
      }
    public void initAttendees()
      {
        flagHasAttendees = true;
        storeAttendees.Clear();
      }
    public void appendAttendees(string to_append)
      {
        if (!flagHasAttendees)
          {
            flagHasAttendees = true;
            storeAttendees.Clear();
          }
        Debug.Assert(flagHasAttendees);
        storeAttendees.Add(to_append);
      }
    public void unsetAttendees()
      {
        flagHasAttendees = false;
        storeAttendees.Clear();
      }
    public void setSelfAttendeeStatus(TypeSelfAttendeeStatus new_value)
      {
        flagHasSelfAttendeeStatus = true;
        storeSelfAttendeeStatus = new_value;
      }
    public void setSelfAttendeeStatus(string chars)
      {
        setSelfAttendeeStatus(stringToSelfAttendeeStatus(chars));
      }
    public void unsetSelfAttendeeStatus()
      {
        flagHasSelfAttendeeStatus = false;
      }
    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public virtual void extraDisplayCalendarItemsCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDisplayCalendarItemsCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDisplayCalendarItemsCommandLookup(key);
        if (old_field == null)
          {
            extraDisplayCalendarItemsCommandAppendPair(key, new_component);
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
    public override void extraCalendarCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttendees", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONAttendees(new_component, false);
                    return;
                    }
                break;
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if (String.Compare(key, 2, "d", 0, 1, false) == 0)
                          {
                            switch (key[3])
                              {
                                case 'E':
                                    if ((String.Compare(key, 4, "nd", 0, 2, false) == 0) && (key.Length == 6))
                                        {
                                        fromJSONEndEnd(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 4, "tart", 0, 4, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONEndStart(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'x':
                        if (String.Compare(key, 2, "act", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'L':
                                    if ((String.Compare(key, 6, "ocation", 0, 7, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONExactLocation(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 6, "itle", 0, 4, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONExactTitle(new_component, false);
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
            case 'I':
                if ((String.Compare(key, 1, "temType", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONItemType(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocationSpecifier", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONLocationSpecifier(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "artial", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'L':
                            if ((String.Compare(key, 8, "ocation", 0, 7, false) == 0) && (key.Length == 15))
                                {
                                fromJSONPartialLocation(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 8, "itle", 0, 4, false) == 0) && (key.Length == 12))
                                {
                                fromJSONPartialTitle(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "lfAttendeeStatus", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONSelfAttendeeStatus(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if (String.Compare(key, 2, "art", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'E':
                                    if ((String.Compare(key, 6, "nd", 0, 2, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONStartEnd(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 6, "tart", 0, 4, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONStartStart(new_component, false);
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
            case 'U':
                if ((String.Compare(key, 1, "serRequest", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONUserRequest(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDisplayCalendarItemsCommandAppendPair(key, new_component);
      }
    public override void extraCalendarCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttendees", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONAttendees(new_component, false);
                    return;
                    }
                break;
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if (String.Compare(key, 2, "d", 0, 1, false) == 0)
                          {
                            switch (key[3])
                              {
                                case 'E':
                                    if ((String.Compare(key, 4, "nd", 0, 2, false) == 0) && (key.Length == 6))
                                        {
                                        fromJSONEndEnd(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 4, "tart", 0, 4, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONEndStart(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'x':
                        if (String.Compare(key, 2, "act", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'L':
                                    if ((String.Compare(key, 6, "ocation", 0, 7, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONExactLocation(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 6, "itle", 0, 4, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONExactTitle(new_component, false);
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
            case 'I':
                if ((String.Compare(key, 1, "temType", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONItemType(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocationSpecifier", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONLocationSpecifier(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "artial", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'L':
                            if ((String.Compare(key, 8, "ocation", 0, 7, false) == 0) && (key.Length == 15))
                                {
                                fromJSONPartialLocation(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 8, "itle", 0, 4, false) == 0) && (key.Length == 12))
                                {
                                fromJSONPartialTitle(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "lfAttendeeStatus", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONSelfAttendeeStatus(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if (String.Compare(key, 2, "art", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'E':
                                    if ((String.Compare(key, 6, "nd", 0, 2, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONStartEnd(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 6, "tart", 0, 4, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONStartStart(new_component, false);
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
            case 'U':
                if ((String.Compare(key, 1, "serRequest", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONUserRequest(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDisplayCalendarItemsCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUserRequest);
        if (flagHasUserRequest)
          {
            handler.start_pair("UserRequest");
            if (partial_allowed)
                storeUserRequest.write_partial_as_json(handler);
            else
                storeUserRequest.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasItemType);
        if (flagHasItemType)
          {
            handler.start_pair("ItemType");
            handler.string_value(storeItemType);
          }
        Debug.Assert(partial_allowed || flagHasExactTitle);
        if (flagHasExactTitle)
          {
            handler.start_pair("ExactTitle");
            handler.string_value(storeExactTitle);
          }
        Debug.Assert(partial_allowed || flagHasPartialTitle);
        if (flagHasPartialTitle)
          {
            handler.start_pair("PartialTitle");
            handler.string_value(storePartialTitle);
          }
        Debug.Assert(partial_allowed || flagHasExactLocation);
        if (flagHasExactLocation)
          {
            handler.start_pair("ExactLocation");
            handler.string_value(storeExactLocation);
          }
        Debug.Assert(partial_allowed || flagHasPartialLocation);
        if (flagHasPartialLocation)
          {
            handler.start_pair("PartialLocation");
            handler.string_value(storePartialLocation);
          }
        if (flagHasLocationSpecifier)
          {
            handler.start_pair("LocationSpecifier");
            if (partial_allowed)
                storeLocationSpecifier.write_partial_as_json(handler);
            else
                storeLocationSpecifier.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStartStart);
        if (flagHasStartStart)
          {
            handler.start_pair("StartStart");
            if (partial_allowed)
                storeStartStart.write_partial_as_json(handler);
            else
                storeStartStart.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndStart);
        if (flagHasEndStart)
          {
            handler.start_pair("EndStart");
            if (partial_allowed)
                storeEndStart.write_partial_as_json(handler);
            else
                storeEndStart.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStartEnd);
        if (flagHasStartEnd)
          {
            handler.start_pair("StartEnd");
            if (partial_allowed)
                storeStartEnd.write_partial_as_json(handler);
            else
                storeStartEnd.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndEnd);
        if (flagHasEndEnd)
          {
            handler.start_pair("EndEnd");
            if (partial_allowed)
                storeEndEnd.write_partial_as_json(handler);
            else
                storeEndEnd.write_as_json(handler);
          }
        if (flagHasAttendees)
          {
            handler.start_pair("Attendees");
            handler.start_array();
            for (int num1 = 0; num1 < storeAttendees.Count; ++num1)
              {
                handler.string_value(storeAttendees[num1]);
              }
            handler.finish_array();
          }
        if (flagHasSelfAttendeeStatus)
          {
            handler.start_pair("SelfAttendeeStatus");
            switch (storeSelfAttendeeStatus)
              {
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_None:
                    handler.string_value("None");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted:
                    handler.string_value("Accepted");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined:
                    handler.string_value("Declined");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited:
                    handler.string_value("Invited");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative:
                    handler.string_value("Tentative");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
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
        if (!(hasUserRequest()))
          {
            return "When parsing the object for %what%, the \"UserRequest\" field was missing.";
          }
        if (!(hasItemType()))
          {
            return "When parsing the object for %what%, the \"ItemType\" field was missing.";
          }
        if (!(hasExactTitle()))
          {
            return "When parsing the object for %what%, the \"ExactTitle\" field was missing.";
          }
        if (!(hasPartialTitle()))
          {
            return "When parsing the object for %what%, the \"PartialTitle\" field was missing.";
          }
        if (!(hasExactLocation()))
          {
            return "When parsing the object for %what%, the \"ExactLocation\" field was missing.";
          }
        if (!(hasPartialLocation()))
          {
            return "When parsing the object for %what%, the \"PartialLocation\" field was missing.";
          }
        if (!(hasStartStart()))
          {
            return "When parsing the object for %what%, the \"StartStart\" field was missing.";
          }
        if (!(hasEndStart()))
          {
            return "When parsing the object for %what%, the \"EndStart\" field was missing.";
          }
        if (!(hasStartEnd()))
          {
            return "When parsing the object for %what%, the \"StartEnd\" field was missing.";
          }
        if (!(hasEndEnd()))
          {
            return "When parsing the object for %what%, the \"EndEnd\" field was missing.";
          }
        return null;
      }

    public static new DisplayCalendarItemsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisplayCalendarItemsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayCalendarItemsCommand", ignore_extras);
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
    public static new DisplayCalendarItemsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisplayCalendarItemsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisplayCalendarItemsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayCalendarItemsCommand", ignore_extras);
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
    public static new DisplayCalendarItemsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisplayCalendarItemsCommandJSON from_text(string text, bool ignore_extras)
      {
        DisplayCalendarItemsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayCalendarItemsCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DisplayCalendarItemsCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DisplayCalendarItemsCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DisplayCalendarItemsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayCalendarItemsCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CalendarCommandJSON.Generator
      {
        private CalendarUserRequestJSON.HoldingGenerator fieldGeneratorUserRequest;
        private JSONHoldingStringGenerator fieldGeneratorItemType;
        private JSONHoldingStringGenerator fieldGeneratorExactTitle;
        private JSONHoldingStringGenerator fieldGeneratorPartialTitle;
        private JSONHoldingStringGenerator fieldGeneratorExactLocation;
        private JSONHoldingStringGenerator fieldGeneratorPartialLocation;
        private CalendarLocationJSON.HoldingGenerator fieldGeneratorLocationSpecifier;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartStart;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndStart;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartEnd;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndEnd;
        private JSONHoldingStringArrayGenerator fieldGeneratorAttendees;
    private abstract class FieldGeneratorSelfAttendeeStatus : JSONStringGenerator
          {
            protected FieldGeneratorSelfAttendeeStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSelfAttendeeStatus()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSelfAttendeeStatus(result));
              }
            protected abstract void handle_result(TypeSelfAttendeeStatus result);
          };
    private class FieldHoldingGeneratorSelfAttendeeStatus : FieldGeneratorSelfAttendeeStatus
  {
    protected override void handle_result(TypeSelfAttendeeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSelfAttendeeStatus(String what)
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
    public TypeSelfAttendeeStatus value;
  };
    private class FieldHoldingArrayGeneratorSelfAttendeeStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSelfAttendeeStatus
      {
        private FieldHoldingArrayGeneratorSelfAttendeeStatus top;

        protected override void handle_result(TypeSelfAttendeeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSelfAttendeeStatus init_top)
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
    protected virtual void handle_result(List<TypeSelfAttendeeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorSelfAttendeeStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSelfAttendeeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSelfAttendeeStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSelfAttendeeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSelfAttendeeStatus> value;
  };
        private FieldHoldingGeneratorSelfAttendeeStatus fieldGeneratorSelfAttendeeStatus;
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
            if (!(getCalendarCommandJSONKey().Equals("DisplayItems")))
                throw new Exception("The key field has a value other than `DisplayItems'.");
            DisplayCalendarItemsCommandJSON result = new DisplayCalendarItemsCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDisplayCalendarItemsCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CalendarCommandJSON new_result)
          {
            handle_result((DisplayCalendarItemsCommandJSON )new_result);
          }
        protected void finish(DisplayCalendarItemsCommandJSON result)
          {
            if (fieldGeneratorUserRequest.have_value)
              {
                result.setUserRequest(fieldGeneratorUserRequest.value);
                fieldGeneratorUserRequest.have_value = false;
              }
            else if ((!(result.hasUserRequest())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UserRequest\" field was missing.");
              }
            if (fieldGeneratorItemType.have_value)
              {
                result.setItemType(fieldGeneratorItemType.value);
                fieldGeneratorItemType.have_value = false;
              }
            else if ((!(result.hasItemType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ItemType\" field was missing.");
              }
            if (fieldGeneratorExactTitle.have_value)
              {
                result.setExactTitle(fieldGeneratorExactTitle.value);
                fieldGeneratorExactTitle.have_value = false;
              }
            else if ((!(result.hasExactTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExactTitle\" field was missing.");
              }
            if (fieldGeneratorPartialTitle.have_value)
              {
                result.setPartialTitle(fieldGeneratorPartialTitle.value);
                fieldGeneratorPartialTitle.have_value = false;
              }
            else if ((!(result.hasPartialTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PartialTitle\" field was missing.");
              }
            if (fieldGeneratorExactLocation.have_value)
              {
                result.setExactLocation(fieldGeneratorExactLocation.value);
                fieldGeneratorExactLocation.have_value = false;
              }
            else if ((!(result.hasExactLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExactLocation\" field was missing.");
              }
            if (fieldGeneratorPartialLocation.have_value)
              {
                result.setPartialLocation(fieldGeneratorPartialLocation.value);
                fieldGeneratorPartialLocation.have_value = false;
              }
            else if ((!(result.hasPartialLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PartialLocation\" field was missing.");
              }
            if (fieldGeneratorLocationSpecifier.have_value)
              {
                result.setLocationSpecifier(fieldGeneratorLocationSpecifier.value);
                fieldGeneratorLocationSpecifier.have_value = false;
              }
            if (fieldGeneratorStartStart.have_value)
              {
                result.setStartStart(fieldGeneratorStartStart.value);
                fieldGeneratorStartStart.have_value = false;
              }
            else if ((!(result.hasStartStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartStart\" field was missing.");
              }
            if (fieldGeneratorEndStart.have_value)
              {
                result.setEndStart(fieldGeneratorEndStart.value);
                fieldGeneratorEndStart.have_value = false;
              }
            else if ((!(result.hasEndStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndStart\" field was missing.");
              }
            if (fieldGeneratorStartEnd.have_value)
              {
                result.setStartEnd(fieldGeneratorStartEnd.value);
                fieldGeneratorStartEnd.have_value = false;
              }
            else if ((!(result.hasStartEnd())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartEnd\" field was missing.");
              }
            if (fieldGeneratorEndEnd.have_value)
              {
                result.setEndEnd(fieldGeneratorEndEnd.value);
                fieldGeneratorEndEnd.have_value = false;
              }
            else if ((!(result.hasEndEnd())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndEnd\" field was missing.");
              }
            if (fieldGeneratorAttendees.have_value)
              {
                result.initAttendees();
                int count = fieldGeneratorAttendees.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAttendees(fieldGeneratorAttendees.value[num]);
                  }
                fieldGeneratorAttendees.value.Clear();
                fieldGeneratorAttendees.have_value = false;
              }
            if (fieldGeneratorSelfAttendeeStatus.have_value)
              {
                result.setSelfAttendeeStatus(fieldGeneratorSelfAttendeeStatus.value);
                fieldGeneratorSelfAttendeeStatus.have_value = false;
              }
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(DisplayCalendarItemsCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttendees", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorAttendees;
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if (String.Compare(field_name, 2, "d", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorEndEnd;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 4, "tart", 0, 4, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorEndStart;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'x':
                            if (String.Compare(field_name, 2, "act", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'L':
                                        if ((String.Compare(field_name, 6, "ocation", 0, 7, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorExactLocation;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 6, "itle", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorExactTitle;
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
                case 'I':
                    if ((String.Compare(field_name, 1, "temType", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorItemType;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocationSpecifier", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorLocationSpecifier;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNativeData;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "artial", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 8, "ocation", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorPartialLocation;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "itle", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorPartialTitle;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "lfAttendeeStatus", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorSelfAttendeeStatus;
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "art", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 6, "nd", 0, 2, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorStartEnd;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 6, "tart", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorStartStart;
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
                case 'U':
                    if ((String.Compare(field_name, 1, "serRequest", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorUserRequest;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUserRequest = new CalendarUserRequestJSON.HoldingGenerator("field \"UserRequest\" of the DisplayCalendarItemsCommand class", ignore_extras);
            fieldGeneratorItemType = new JSONHoldingStringGenerator("field \"ItemType\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorExactTitle = new JSONHoldingStringGenerator("field \"ExactTitle\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorPartialTitle = new JSONHoldingStringGenerator("field \"PartialTitle\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorExactLocation = new JSONHoldingStringGenerator("field \"ExactLocation\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorPartialLocation = new JSONHoldingStringGenerator("field \"PartialLocation\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the DisplayCalendarItemsCommand class", ignore_extras);
            fieldGeneratorStartStart = new DateAndOrTimeJSON.HoldingGenerator("field \"StartStart\" of the DisplayCalendarItemsCommand class", ignore_extras);
            fieldGeneratorEndStart = new DateAndOrTimeJSON.HoldingGenerator("field \"EndStart\" of the DisplayCalendarItemsCommand class", ignore_extras);
            fieldGeneratorStartEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"StartEnd\" of the DisplayCalendarItemsCommand class", ignore_extras);
            fieldGeneratorEndEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"EndEnd\" of the DisplayCalendarItemsCommand class", ignore_extras);
            fieldGeneratorAttendees = new JSONHoldingStringArrayGenerator("field \"Attendees\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the DisplayCalendarItemsCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DisplayCalendarItemsCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUserRequest = new CalendarUserRequestJSON.HoldingGenerator("field \"UserRequest\" of the DisplayCalendarItemsCommand class", false);
            fieldGeneratorItemType = new JSONHoldingStringGenerator("field \"ItemType\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorExactTitle = new JSONHoldingStringGenerator("field \"ExactTitle\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorPartialTitle = new JSONHoldingStringGenerator("field \"PartialTitle\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorExactLocation = new JSONHoldingStringGenerator("field \"ExactLocation\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorPartialLocation = new JSONHoldingStringGenerator("field \"PartialLocation\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the DisplayCalendarItemsCommand class", false);
            fieldGeneratorStartStart = new DateAndOrTimeJSON.HoldingGenerator("field \"StartStart\" of the DisplayCalendarItemsCommand class", false);
            fieldGeneratorEndStart = new DateAndOrTimeJSON.HoldingGenerator("field \"EndStart\" of the DisplayCalendarItemsCommand class", false);
            fieldGeneratorStartEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"StartEnd\" of the DisplayCalendarItemsCommand class", false);
            fieldGeneratorEndEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"EndEnd\" of the DisplayCalendarItemsCommand class", false);
            fieldGeneratorAttendees = new JSONHoldingStringArrayGenerator("field \"Attendees\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the DisplayCalendarItemsCommand class");
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the DisplayCalendarItemsCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DisplayCalendarItemsCommand class");
          }

        public override void reset()
          {
            fieldGeneratorUserRequest.reset();
            fieldGeneratorItemType.reset();
            fieldGeneratorExactTitle.reset();
            fieldGeneratorPartialTitle.reset();
            fieldGeneratorExactLocation.reset();
            fieldGeneratorPartialLocation.reset();
            fieldGeneratorLocationSpecifier.reset();
            fieldGeneratorStartStart.reset();
            fieldGeneratorEndStart.reset();
            fieldGeneratorStartEnd.reset();
            fieldGeneratorEndEnd.reset();
            fieldGeneratorAttendees.reset();
            fieldGeneratorSelfAttendeeStatus.reset();
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DisplayCalendarItemsCommandJSON  result)
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
        public DisplayCalendarItemsCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DisplayCalendarItemsCommandJSON  result)
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
    protected virtual void handle_result(List<DisplayCalendarItemsCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DisplayCalendarItemsCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DisplayCalendarItemsCommandJSON>();
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
    public List<DisplayCalendarItemsCommandJSON> value;
  };
  };
