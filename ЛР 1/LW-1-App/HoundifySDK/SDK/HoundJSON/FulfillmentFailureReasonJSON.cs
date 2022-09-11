/* file "FulfillmentFailureReasonJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FulfillmentFailureReasonJSON : JSONBase
  {
    public enum TypeFulfillmentTypeKnownValues
      {
        FulfillmentType_TerrestrialRadio,
        FulfillmentType_TerrestrialDABRadio,
        FulfillmentType_TerrestrialFMRadio,
        FulfillmentType_TerrestrialFMRDSRadio,
        FulfillmentType_TerrestrialAMRadio,
        FulfillmentType_Internet,
        FulfillmentType_Satellite,
        FulfillmentType_All,
        FulfillmentType__none
      };
    public struct TypeFulfillmentType
      {
        public bool in_known_list;
        public string string_value;
        public TypeFulfillmentTypeKnownValues list_value;
      };

    public static TypeFulfillmentTypeKnownValues  stringToFulfillmentType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ll", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeFulfillmentTypeKnownValues.FulfillmentType_All;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nternet", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeFulfillmentTypeKnownValues.FulfillmentType_Internet;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "atellite", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeFulfillmentTypeKnownValues.FulfillmentType_Satellite;
                break;
            case 'T':
                if (String.Compare(chars, 1, "errestrial", 0, 10, false) == 0)
                  {
                    switch (chars[11])
                      {
                        case 'A':
                            if ((String.Compare(chars, 12, "MRadio", 0, 6, false) == 0) && (chars.Length == 18))
                                return TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialAMRadio;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 12, "ABRadio", 0, 7, false) == 0) && (chars.Length == 19))
                                return TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialDABRadio;
                            break;
                        case 'F':
                            if (String.Compare(chars, 12, "MR", 0, 2, false) == 0)
                              {
                                switch (chars[14])
                                  {
                                    case 'D':
                                        if ((String.Compare(chars, 15, "SRadio", 0, 6, false) == 0) && (chars.Length == 21))
                                            return TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialFMRDSRadio;
                                        break;
                                    case 'a':
                                        if ((String.Compare(chars, 15, "dio", 0, 3, false) == 0) && (chars.Length == 18))
                                            return TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialFMRadio;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if ((String.Compare(chars, 12, "adio", 0, 4, false) == 0) && (chars.Length == 16))
                                return TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialRadio;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeFulfillmentTypeKnownValues.FulfillmentType__none;
      }

    public static string  stringFromFulfillmentType(TypeFulfillmentTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialRadio:
                return "TerrestrialRadio";
            case TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialDABRadio:
                return "TerrestrialDABRadio";
            case TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialFMRadio:
                return "TerrestrialFMRadio";
            case TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialFMRDSRadio:
                return "TerrestrialFMRDSRadio";
            case TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialAMRadio:
                return "TerrestrialAMRadio";
            case TypeFulfillmentTypeKnownValues.FulfillmentType_Internet:
                return "Internet";
            case TypeFulfillmentTypeKnownValues.FulfillmentType_Satellite:
                return "Satellite";
            case TypeFulfillmentTypeKnownValues.FulfillmentType_All:
                return "All";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeReasonKnownValues
      {
        Reason_OutOfRange,
        Reason_MayNot,
        Reason_MayNotBecauseLocation,
        Reason_StreamAudioNotActivated,
        Reason_ClientLocationUnknown,
        Reason_NoStationOfSpecifiedGenreAvailable,
        Reason__none
      };
    public struct TypeReason
      {
        public bool in_known_list;
        public string string_value;
        public TypeReasonKnownValues list_value;
      };

    public static TypeReasonKnownValues  stringToReason(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "lientLocationUnknown", 0, 20, false) == 0) && (chars.Length == 21))
                    return TypeReasonKnownValues.Reason_ClientLocationUnknown;
                break;
            case 'M':
                if (String.Compare(chars, 1, "ayNot", 0, 5, false) == 0)
                  {
                    if (chars.Length == 6)
                      {
                        return TypeReasonKnownValues.Reason_MayNot;
                      }
                    switch (chars[6])
                      {
                        case 'B':
                            if ((String.Compare(chars, 7, "ecauseLocation", 0, 14, false) == 0) && (chars.Length == 21))
                                return TypeReasonKnownValues.Reason_MayNotBecauseLocation;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(chars, 1, "oStationOfSpecifiedGenreAvailable", 0, 33, false) == 0) && (chars.Length == 34))
                    return TypeReasonKnownValues.Reason_NoStationOfSpecifiedGenreAvailable;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "utOfRange", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeReasonKnownValues.Reason_OutOfRange;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "treamAudioNotActivated", 0, 22, false) == 0) && (chars.Length == 23))
                    return TypeReasonKnownValues.Reason_StreamAudioNotActivated;
                break;
            default:
                break;
          }
        return TypeReasonKnownValues.Reason__none;
      }

    public static string  stringFromReason(TypeReasonKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeReasonKnownValues.Reason_OutOfRange:
                return "OutOfRange";
            case TypeReasonKnownValues.Reason_MayNot:
                return "MayNot";
            case TypeReasonKnownValues.Reason_MayNotBecauseLocation:
                return "MayNotBecauseLocation";
            case TypeReasonKnownValues.Reason_StreamAudioNotActivated:
                return "StreamAudioNotActivated";
            case TypeReasonKnownValues.Reason_ClientLocationUnknown:
                return "ClientLocationUnknown";
            case TypeReasonKnownValues.Reason_NoStationOfSpecifiedGenreAvailable:
                return "NoStationOfSpecifiedGenreAvailable";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFulfillmentType;
    private TypeFulfillmentType storeFulfillmentType;
    private bool flagHasReason;
    private TypeReason storeReason;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFulfillmentType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FulfillmentType of FulfillmentFailureReasonJSON is not a string.");
        TypeFulfillmentType the_open_enum = new TypeFulfillmentType();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ll", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFulfillmentTypeKnownValues.FulfillmentType_All;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nternet", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFulfillmentTypeKnownValues.FulfillmentType_Internet;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "atellite", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFulfillmentTypeKnownValues.FulfillmentType_Satellite;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if (String.Compare(json_string.getData(), 1, "errestrial", 0, 10, false) == 0)
                  {
                    switch (json_string.getData()[11])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 12, "MRadio", 0, 6, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialAMRadio;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 12, "ABRadio", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialDABRadio;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'F':
                            if (String.Compare(json_string.getData(), 12, "MR", 0, 2, false) == 0)
                              {
                                switch (json_string.getData()[14])
                                  {
                                    case 'D':
                                        if ((String.Compare(json_string.getData(), 15, "SRadio", 0, 6, false) == 0) && (json_string.getData().Length == 21))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialFMRDSRadio;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'a':
                                        if ((String.Compare(json_string.getData(), 15, "dio", 0, 3, false) == 0) && (json_string.getData().Length == 18))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialFMRadio;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if ((String.Compare(json_string.getData(), 12, "adio", 0, 4, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialRadio;
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
        setFulfillmentType(the_open_enum);
      }


    private void  fromJSONReason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Reason of FulfillmentFailureReasonJSON is not a string.");
        TypeReason the_open_enum = new TypeReason();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "lientLocationUnknown", 0, 20, false) == 0) && (json_string.getData().Length == 21))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeReasonKnownValues.Reason_ClientLocationUnknown;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if (String.Compare(json_string.getData(), 1, "ayNot", 0, 5, false) == 0)
                  {
                    if (json_string.getData().Length == 6)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeReasonKnownValues.Reason_MayNot;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[6])
                      {
                        case 'B':
                            if ((String.Compare(json_string.getData(), 7, "ecauseLocation", 0, 14, false) == 0) && (json_string.getData().Length == 21))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeReasonKnownValues.Reason_MayNotBecauseLocation;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "oStationOfSpecifiedGenreAvailable", 0, 33, false) == 0) && (json_string.getData().Length == 34))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeReasonKnownValues.Reason_NoStationOfSpecifiedGenreAvailable;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "utOfRange", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeReasonKnownValues.Reason_OutOfRange;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "treamAudioNotActivated", 0, 22, false) == 0) && (json_string.getData().Length == 23))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeReasonKnownValues.Reason_StreamAudioNotActivated;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setReason(the_open_enum);
      }


    public FulfillmentFailureReasonJSON()
      {
        flagHasFulfillmentType = false;
        flagHasReason = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFulfillmentType()
      {
        return flagHasFulfillmentType;
      }

    public TypeFulfillmentType  getFulfillmentType()
      {
        Debug.Assert(flagHasFulfillmentType);
        return storeFulfillmentType;
      }

    public string  getFulfillmentTypeAsString()
      {
        TypeFulfillmentType result = getFulfillmentType();
        if (result.in_known_list)
            return stringFromFulfillmentType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasReason()
      {
        return flagHasReason;
      }

    public TypeReason  getReason()
      {
        Debug.Assert(flagHasReason);
        return storeReason;
      }

    public string  getReasonAsString()
      {
        TypeReason result = getReason();
        if (result.in_known_list)
            return stringFromReason(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraFulfillmentFailureReasonComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFulfillmentFailureReasonComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFulfillmentFailureReasonComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFulfillmentFailureReasonLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFulfillmentType(TypeFulfillmentType new_value)
      {
        flagHasFulfillmentType = true;
        storeFulfillmentType = new_value;
      }
    public void setFulfillmentType(string chars)
      {
        TypeFulfillmentTypeKnownValues known = stringToFulfillmentType(chars);
        TypeFulfillmentType new_value = new TypeFulfillmentType();
        if (known == TypeFulfillmentTypeKnownValues.FulfillmentType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setFulfillmentType(new_value);
      }
    public void setFulfillmentType(TypeFulfillmentTypeKnownValues new_value)
      {
        TypeFulfillmentType new_full_value = new TypeFulfillmentType();
        Debug.Assert(new_value != TypeFulfillmentTypeKnownValues.FulfillmentType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setFulfillmentType(new_full_value);
      }
    public void unsetFulfillmentType()
      {
        flagHasFulfillmentType = false;
      }
    public void setReason(TypeReason new_value)
      {
        flagHasReason = true;
        storeReason = new_value;
      }
    public void setReason(string chars)
      {
        TypeReasonKnownValues known = stringToReason(chars);
        TypeReason new_value = new TypeReason();
        if (known == TypeReasonKnownValues.Reason__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setReason(new_value);
      }
    public void setReason(TypeReasonKnownValues new_value)
      {
        TypeReason new_full_value = new TypeReason();
        Debug.Assert(new_value != TypeReasonKnownValues.Reason__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setReason(new_full_value);
      }
    public void unsetReason()
      {
        flagHasReason = false;
      }

    public virtual void extraFulfillmentFailureReasonAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFulfillmentFailureReasonSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFulfillmentFailureReasonLookup(key);
        if (old_field == null)
          {
            extraFulfillmentFailureReasonAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFulfillmentType);
        if (flagHasFulfillmentType)
          {
            handler.start_pair("FulfillmentType");
            if (storeFulfillmentType.in_known_list)
              {
                switch (storeFulfillmentType.list_value)
                  {
                    case TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialRadio:
                        handler.string_value("TerrestrialRadio");
                        break;
                    case TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialDABRadio:
                        handler.string_value("TerrestrialDABRadio");
                        break;
                    case TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialFMRadio:
                        handler.string_value("TerrestrialFMRadio");
                        break;
                    case TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialFMRDSRadio:
                        handler.string_value("TerrestrialFMRDSRadio");
                        break;
                    case TypeFulfillmentTypeKnownValues.FulfillmentType_TerrestrialAMRadio:
                        handler.string_value("TerrestrialAMRadio");
                        break;
                    case TypeFulfillmentTypeKnownValues.FulfillmentType_Internet:
                        handler.string_value("Internet");
                        break;
                    case TypeFulfillmentTypeKnownValues.FulfillmentType_Satellite:
                        handler.string_value("Satellite");
                        break;
                    case TypeFulfillmentTypeKnownValues.FulfillmentType_All:
                        handler.string_value("All");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeFulfillmentType.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasReason);
        if (flagHasReason)
          {
            handler.start_pair("Reason");
            if (storeReason.in_known_list)
              {
                switch (storeReason.list_value)
                  {
                    case TypeReasonKnownValues.Reason_OutOfRange:
                        handler.string_value("OutOfRange");
                        break;
                    case TypeReasonKnownValues.Reason_MayNot:
                        handler.string_value("MayNot");
                        break;
                    case TypeReasonKnownValues.Reason_MayNotBecauseLocation:
                        handler.string_value("MayNotBecauseLocation");
                        break;
                    case TypeReasonKnownValues.Reason_StreamAudioNotActivated:
                        handler.string_value("StreamAudioNotActivated");
                        break;
                    case TypeReasonKnownValues.Reason_ClientLocationUnknown:
                        handler.string_value("ClientLocationUnknown");
                        break;
                    case TypeReasonKnownValues.Reason_NoStationOfSpecifiedGenreAvailable:
                        handler.string_value("NoStationOfSpecifiedGenreAvailable");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeReason.string_value);
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
        if (!(hasFulfillmentType()))
          {
            return "When parsing the object for %what%, the \"FulfillmentType\" field was missing.";
          }
        if (!(hasReason()))
          {
            return "When parsing the object for %what%, the \"Reason\" field was missing.";
          }
        return null;
      }

    public static FulfillmentFailureReasonJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FulfillmentFailureReasonJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FulfillmentFailureReason", ignore_extras);
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
    public static FulfillmentFailureReasonJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FulfillmentFailureReasonJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FulfillmentFailureReasonJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FulfillmentFailureReason", ignore_extras);
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
    public static FulfillmentFailureReasonJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FulfillmentFailureReasonJSON from_text(string text, bool ignore_extras)
      {
        FulfillmentFailureReasonJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FulfillmentFailureReason", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FulfillmentFailureReasonJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FulfillmentFailureReasonJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FulfillmentFailureReasonJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FulfillmentFailureReason", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorFulfillmentType : JSONStringGenerator
          {
            protected FieldGeneratorFulfillmentType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFulfillmentType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeFulfillmentTypeKnownValues known = stringToFulfillmentType(result);
                TypeFulfillmentType new_value = new TypeFulfillmentType();
                if (known == TypeFulfillmentTypeKnownValues.FulfillmentType__none)
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
            protected abstract void handle_result(TypeFulfillmentType result);
          };
    private class FieldHoldingGeneratorFulfillmentType : FieldGeneratorFulfillmentType
  {
    protected override void handle_result(TypeFulfillmentType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFulfillmentType(String what)
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
    public TypeFulfillmentType value;
  };
    private class FieldHoldingArrayGeneratorFulfillmentType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFulfillmentType
      {
        private FieldHoldingArrayGeneratorFulfillmentType top;

        protected override void handle_result(TypeFulfillmentType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFulfillmentType init_top)
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
    protected virtual void handle_result(List<TypeFulfillmentType> result)
      {
      }

    public FieldHoldingArrayGeneratorFulfillmentType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFulfillmentType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFulfillmentType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFulfillmentType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFulfillmentType> value;
  };
        private FieldHoldingGeneratorFulfillmentType fieldGeneratorFulfillmentType;
    private abstract class FieldGeneratorReason : JSONStringGenerator
          {
            protected FieldGeneratorReason(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorReason()
              {
              }
            protected override void handle_result(string result)
              {
                TypeReasonKnownValues known = stringToReason(result);
                TypeReason new_value = new TypeReason();
                if (known == TypeReasonKnownValues.Reason__none)
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
            protected abstract void handle_result(TypeReason result);
          };
    private class FieldHoldingGeneratorReason : FieldGeneratorReason
  {
    protected override void handle_result(TypeReason result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorReason(String what)
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
    public TypeReason value;
  };
    private class FieldHoldingArrayGeneratorReason : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorReason
      {
        private FieldHoldingArrayGeneratorReason top;

        protected override void handle_result(TypeReason result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorReason init_top)
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
    protected virtual void handle_result(List<TypeReason> result)
      {
      }

    public FieldHoldingArrayGeneratorReason(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeReason>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorReason()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeReason>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeReason> value;
  };
        private FieldHoldingGeneratorReason fieldGeneratorReason;
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
            FulfillmentFailureReasonJSON result = new FulfillmentFailureReasonJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFulfillmentFailureReasonAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FulfillmentFailureReasonJSON result)
          {
            if (fieldGeneratorFulfillmentType.have_value)
              {
                result.setFulfillmentType(fieldGeneratorFulfillmentType.value);
                fieldGeneratorFulfillmentType.have_value = false;
              }
            else if ((!(result.hasFulfillmentType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FulfillmentType\" field was missing.");
              }
            if (fieldGeneratorReason.have_value)
              {
                result.setReason(fieldGeneratorReason.value);
                fieldGeneratorReason.have_value = false;
              }
            else if ((!(result.hasReason())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Reason\" field was missing.");
              }
          }
        protected abstract void handle_result(FulfillmentFailureReasonJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "ulfillmentType", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorFulfillmentType;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eason", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorReason;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFulfillmentType = new FieldHoldingGeneratorFulfillmentType("field \"FulfillmentType\" of the FulfillmentFailureReason class");
            fieldGeneratorReason = new FieldHoldingGeneratorReason("field \"Reason\" of the FulfillmentFailureReason class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FulfillmentFailureReason class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFulfillmentType = new FieldHoldingGeneratorFulfillmentType("field \"FulfillmentType\" of the FulfillmentFailureReason class");
            fieldGeneratorReason = new FieldHoldingGeneratorReason("field \"Reason\" of the FulfillmentFailureReason class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FulfillmentFailureReason class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFulfillmentType.reset();
            fieldGeneratorReason.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FulfillmentFailureReasonJSON  result)
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
        public FulfillmentFailureReasonJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FulfillmentFailureReasonJSON  result)
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
    protected virtual void handle_result(List<FulfillmentFailureReasonJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FulfillmentFailureReasonJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FulfillmentFailureReasonJSON>();
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
    public List<FulfillmentFailureReasonJSON> value;
  };
  };
