/* file "CiscoSparkClientDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CiscoSparkClientDataJSON : JSONBase
  {
    private bool flagHasReserveRoomSuggestion;
    private CiscoSparkReserveRoomSuggestionClientDataJSON  storeReserveRoomSuggestion;
    private bool flagHasRoomAvailability;
    private List< CiscoSparkRoomAvailabilityItemJSON  > storeRoomAvailability;
    private bool flagHasRoomDetails;
    private List< CiscoSparkRoomDetailJSON  > storeRoomDetails;
    private bool flagHasDeviceIPAddress;
    private string storeDeviceIPAddress;
    private bool flagHasSoftwareVersion;
    private string storeSoftwareVersion;
    private bool flagHasDeviceTargetIdentifiers;
    private List< string > storeDeviceTargetIdentifiers;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONReserveRoomSuggestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CiscoSparkReserveRoomSuggestionClientDataJSON convert_classy = CiscoSparkReserveRoomSuggestionClientDataJSON.from_json(json_value, ignore_extras, true);
        setReserveRoomSuggestion(convert_classy);
      }


    private void  fromJSONRoomAvailability(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RoomAvailability of CiscoSparkClientDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field RoomAvailability of CiscoSparkClientDataJSON has too few elements.");
        List< CiscoSparkRoomAvailabilityItemJSON  > vector_RoomAvailability1 = new List< CiscoSparkRoomAvailabilityItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CiscoSparkRoomAvailabilityItemJSON convert_classy = CiscoSparkRoomAvailabilityItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RoomAvailability1.Add(convert_classy);
          }
        Debug.Assert(vector_RoomAvailability1.Count >= 1);
        initRoomAvailability();
        for (int num1 = 0; num1 < vector_RoomAvailability1.Count; ++num1)
            appendRoomAvailability(vector_RoomAvailability1[num1]);
        for (int num1 = 0; num1 < vector_RoomAvailability1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRoomDetails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RoomDetails of CiscoSparkClientDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CiscoSparkRoomDetailJSON  > vector_RoomDetails1 = new List< CiscoSparkRoomDetailJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CiscoSparkRoomDetailJSON convert_classy = CiscoSparkRoomDetailJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RoomDetails1.Add(convert_classy);
          }
        initRoomDetails();
        for (int num2 = 0; num2 < vector_RoomDetails1.Count; ++num2)
            appendRoomDetails(vector_RoomDetails1[num2]);
        for (int num1 = 0; num1 < vector_RoomDetails1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDeviceIPAddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DeviceIPAddress of CiscoSparkClientDataJSON is not a string.");
        setDeviceIPAddress(json_string.getData());
      }


    private void  fromJSONSoftwareVersion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SoftwareVersion of CiscoSparkClientDataJSON is not a string.");
        setSoftwareVersion(json_string.getData());
      }


    private void  fromJSONDeviceTargetIdentifiers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DeviceTargetIdentifiers of CiscoSparkClientDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_DeviceTargetIdentifiers1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field DeviceTargetIdentifiers of CiscoSparkClientDataJSON is not a string.");
            vector_DeviceTargetIdentifiers1.Add(json_string.getData());
          }
        initDeviceTargetIdentifiers();
        for (int num3 = 0; num3 < vector_DeviceTargetIdentifiers1.Count; ++num3)
            appendDeviceTargetIdentifiers(vector_DeviceTargetIdentifiers1[num3]);
        for (int num1 = 0; num1 < vector_DeviceTargetIdentifiers1.Count; ++num1)
          {
          }
      }


    public CiscoSparkClientDataJSON()
      {
        flagHasReserveRoomSuggestion = false;
        flagHasRoomAvailability = false;
        flagHasRoomDetails = false;
        flagHasDeviceIPAddress = false;
        flagHasSoftwareVersion = false;
        flagHasDeviceTargetIdentifiers = false;
        storeRoomAvailability = new List< CiscoSparkRoomAvailabilityItemJSON  >();
        storeRoomDetails = new List< CiscoSparkRoomDetailJSON  >();
        storeDeviceTargetIdentifiers = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasReserveRoomSuggestion()
      {
        return flagHasReserveRoomSuggestion;
      }

    public CiscoSparkReserveRoomSuggestionClientDataJSON   getReserveRoomSuggestion()
      {
        Debug.Assert(flagHasReserveRoomSuggestion);
        return storeReserveRoomSuggestion;
      }

    public bool  hasRoomAvailability()
      {
        return flagHasRoomAvailability;
      }

    public int  countOfRoomAvailability()
      {
        Debug.Assert(flagHasRoomAvailability);
        return storeRoomAvailability.Count;
      }

    public CiscoSparkRoomAvailabilityItemJSON   elementOfRoomAvailability(int element_num)
      {
        Debug.Assert(flagHasRoomAvailability);
        return storeRoomAvailability[element_num];
      }

    public List< CiscoSparkRoomAvailabilityItemJSON  >  getRoomAvailability()
      {
        Debug.Assert(flagHasRoomAvailability);
        return storeRoomAvailability;
      }

    public bool  hasRoomDetails()
      {
        return flagHasRoomDetails;
      }

    public int  countOfRoomDetails()
      {
        return storeRoomDetails.Count;
      }

    public CiscoSparkRoomDetailJSON   elementOfRoomDetails(int element_num)
      {
        return storeRoomDetails[element_num];
      }

    public List< CiscoSparkRoomDetailJSON  >  getRoomDetails()
      {
        return storeRoomDetails;
      }

    public bool  hasDeviceIPAddress()
      {
        return flagHasDeviceIPAddress;
      }

    public string  getDeviceIPAddress()
      {
        Debug.Assert(flagHasDeviceIPAddress);
        return storeDeviceIPAddress;
      }

    public bool  hasSoftwareVersion()
      {
        return flagHasSoftwareVersion;
      }

    public string  getSoftwareVersion()
      {
        Debug.Assert(flagHasSoftwareVersion);
        return storeSoftwareVersion;
      }

    public bool  hasDeviceTargetIdentifiers()
      {
        return flagHasDeviceTargetIdentifiers;
      }

    public int  countOfDeviceTargetIdentifiers()
      {
        return storeDeviceTargetIdentifiers.Count;
      }

    public string  elementOfDeviceTargetIdentifiers(int element_num)
      {
        return storeDeviceTargetIdentifiers[element_num];
      }

    public List< string >  getDeviceTargetIdentifiers()
      {
        return storeDeviceTargetIdentifiers;
      }


    public virtual int extraCiscoSparkClientDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCiscoSparkClientDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCiscoSparkClientDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCiscoSparkClientDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setReserveRoomSuggestion(CiscoSparkReserveRoomSuggestionClientDataJSON  new_value)
      {
        if (flagHasReserveRoomSuggestion)
          {
          }
        flagHasReserveRoomSuggestion = true;
        storeReserveRoomSuggestion = new_value;
      }
    public void unsetReserveRoomSuggestion()
      {
        if (flagHasReserveRoomSuggestion)
          {
          }
        flagHasReserveRoomSuggestion = false;
      }
    public void initRoomAvailability()
      {
        if (flagHasRoomAvailability)
          {
            for (int num1 = 0; num1 < storeRoomAvailability.Count; ++num1)
              {
              }
          }
        flagHasRoomAvailability = true;
        storeRoomAvailability.Clear();
      }
    public void appendRoomAvailability(CiscoSparkRoomAvailabilityItemJSON  to_append)
      {
        if (!flagHasRoomAvailability)
          {
            flagHasRoomAvailability = true;
            storeRoomAvailability.Clear();
          }
        Debug.Assert(flagHasRoomAvailability);
        storeRoomAvailability.Add(to_append);
      }
    public void unsetRoomAvailability()
      {
        if (flagHasRoomAvailability)
          {
            for (int num2 = 0; num2 < storeRoomAvailability.Count; ++num2)
              {
              }
          }
        flagHasRoomAvailability = false;
        storeRoomAvailability.Clear();
      }
    public void initRoomDetails()
      {
        if (flagHasRoomDetails)
          {
            for (int num3 = 0; num3 < storeRoomDetails.Count; ++num3)
              {
              }
          }
        flagHasRoomDetails = true;
        storeRoomDetails.Clear();
      }
    public void appendRoomDetails(CiscoSparkRoomDetailJSON  to_append)
      {
        if (!flagHasRoomDetails)
          {
            flagHasRoomDetails = true;
            storeRoomDetails.Clear();
          }
        Debug.Assert(flagHasRoomDetails);
        storeRoomDetails.Add(to_append);
      }
    public void unsetRoomDetails()
      {
        if (flagHasRoomDetails)
          {
            for (int num4 = 0; num4 < storeRoomDetails.Count; ++num4)
              {
              }
          }
        flagHasRoomDetails = false;
        storeRoomDetails.Clear();
      }
    public void setDeviceIPAddress(string new_value)
      {
        flagHasDeviceIPAddress = true;
        storeDeviceIPAddress = new_value;
      }
    public void unsetDeviceIPAddress()
      {
        flagHasDeviceIPAddress = false;
      }
    public void setSoftwareVersion(string new_value)
      {
        flagHasSoftwareVersion = true;
        storeSoftwareVersion = new_value;
      }
    public void unsetSoftwareVersion()
      {
        flagHasSoftwareVersion = false;
      }
    public void initDeviceTargetIdentifiers()
      {
        flagHasDeviceTargetIdentifiers = true;
        storeDeviceTargetIdentifiers.Clear();
      }
    public void appendDeviceTargetIdentifiers(string to_append)
      {
        if (!flagHasDeviceTargetIdentifiers)
          {
            flagHasDeviceTargetIdentifiers = true;
            storeDeviceTargetIdentifiers.Clear();
          }
        Debug.Assert(flagHasDeviceTargetIdentifiers);
        storeDeviceTargetIdentifiers.Add(to_append);
      }
    public void unsetDeviceTargetIdentifiers()
      {
        flagHasDeviceTargetIdentifiers = false;
        storeDeviceTargetIdentifiers.Clear();
      }

    public virtual void extraCiscoSparkClientDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCiscoSparkClientDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCiscoSparkClientDataLookup(key);
        if (old_field == null)
          {
            extraCiscoSparkClientDataAppendPair(key, new_component);
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
        if (flagHasReserveRoomSuggestion)
          {
            handler.start_pair("ReserveRoomSuggestion");
            if (partial_allowed)
                storeReserveRoomSuggestion.write_partial_as_json(handler);
            else
                storeReserveRoomSuggestion.write_as_json(handler);
          }
        if (flagHasRoomAvailability)
          {
            handler.start_pair("RoomAvailability");
            Debug.Assert(storeRoomAvailability.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeRoomAvailability.Count; ++num1)
              {
                if (partial_allowed)
                    storeRoomAvailability[num1].write_partial_as_json(handler);
                else
                    storeRoomAvailability[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRoomDetails)
          {
            handler.start_pair("RoomDetails");
            handler.start_array();
            for (int num2 = 0; num2 < storeRoomDetails.Count; ++num2)
              {
                if (partial_allowed)
                    storeRoomDetails[num2].write_partial_as_json(handler);
                else
                    storeRoomDetails[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDeviceIPAddress)
          {
            handler.start_pair("DeviceIPAddress");
            handler.string_value(storeDeviceIPAddress);
          }
        if (flagHasSoftwareVersion)
          {
            handler.start_pair("SoftwareVersion");
            handler.string_value(storeSoftwareVersion);
          }
        if (flagHasDeviceTargetIdentifiers)
          {
            handler.start_pair("DeviceTargetIdentifiers");
            handler.start_array();
            for (int num3 = 0; num3 < storeDeviceTargetIdentifiers.Count; ++num3)
              {
                handler.string_value(storeDeviceTargetIdentifiers[num3]);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static CiscoSparkClientDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CiscoSparkClientDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkClientData", ignore_extras);
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
    public static CiscoSparkClientDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CiscoSparkClientDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CiscoSparkClientDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkClientData", ignore_extras);
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
    public static CiscoSparkClientDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CiscoSparkClientDataJSON from_text(string text, bool ignore_extras)
      {
        CiscoSparkClientDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkClientData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CiscoSparkClientDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CiscoSparkClientDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CiscoSparkClientDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkClientData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private CiscoSparkReserveRoomSuggestionClientDataJSON.HoldingGenerator fieldGeneratorReserveRoomSuggestion;
        private CiscoSparkRoomAvailabilityItemJSON.HoldingArrayGenerator fieldGeneratorRoomAvailability;
        private CiscoSparkRoomDetailJSON.HoldingArrayGenerator fieldGeneratorRoomDetails;
        private JSONHoldingStringGenerator fieldGeneratorDeviceIPAddress;
        private JSONHoldingStringGenerator fieldGeneratorSoftwareVersion;
        private JSONHoldingStringArrayGenerator fieldGeneratorDeviceTargetIdentifiers;
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
            CiscoSparkClientDataJSON result = new CiscoSparkClientDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCiscoSparkClientDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CiscoSparkClientDataJSON result)
          {
            if (fieldGeneratorReserveRoomSuggestion.have_value)
              {
                result.setReserveRoomSuggestion(fieldGeneratorReserveRoomSuggestion.value);
                fieldGeneratorReserveRoomSuggestion.have_value = false;
              }
            if (fieldGeneratorRoomAvailability.have_value)
              {
                result.initRoomAvailability();
                int count = fieldGeneratorRoomAvailability.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRoomAvailability(fieldGeneratorRoomAvailability.value[num]);
                  }
                fieldGeneratorRoomAvailability.value.Clear();
                fieldGeneratorRoomAvailability.have_value = false;
              }
            if (fieldGeneratorRoomDetails.have_value)
              {
                result.initRoomDetails();
                int count = fieldGeneratorRoomDetails.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRoomDetails(fieldGeneratorRoomDetails.value[num]);
                  }
                fieldGeneratorRoomDetails.value.Clear();
                fieldGeneratorRoomDetails.have_value = false;
              }
            if (fieldGeneratorDeviceIPAddress.have_value)
              {
                result.setDeviceIPAddress(fieldGeneratorDeviceIPAddress.value);
                fieldGeneratorDeviceIPAddress.have_value = false;
              }
            if (fieldGeneratorSoftwareVersion.have_value)
              {
                result.setSoftwareVersion(fieldGeneratorSoftwareVersion.value);
                fieldGeneratorSoftwareVersion.have_value = false;
              }
            if (fieldGeneratorDeviceTargetIdentifiers.have_value)
              {
                result.initDeviceTargetIdentifiers();
                int count = fieldGeneratorDeviceTargetIdentifiers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDeviceTargetIdentifiers(fieldGeneratorDeviceTargetIdentifiers.value[num]);
                  }
                fieldGeneratorDeviceTargetIdentifiers.value.Clear();
                fieldGeneratorDeviceTargetIdentifiers.have_value = false;
              }
          }
        protected abstract void handle_result(CiscoSparkClientDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "evice", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 7, "PAddress", 0, 8, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorDeviceIPAddress;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "argetIdentifiers", 0, 16, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorDeviceTargetIdentifiers;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "serveRoomSuggestion", 0, 19, false) == 0) && (field_name.Length == 21))
                                return fieldGeneratorReserveRoomSuggestion;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "om", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 5, "vailability", 0, 11, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorRoomAvailability;
                                        break;
                                    case 'D':
                                        if ((String.Compare(field_name, 5, "etails", 0, 6, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorRoomDetails;
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
                case 'S':
                    if ((String.Compare(field_name, 1, "oftwareVersion", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorSoftwareVersion;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorReserveRoomSuggestion = new CiscoSparkReserveRoomSuggestionClientDataJSON.HoldingGenerator("field \"ReserveRoomSuggestion\" of the CiscoSparkClientData class", ignore_extras);
            fieldGeneratorRoomAvailability = new CiscoSparkRoomAvailabilityItemJSON.HoldingArrayGenerator("field \"RoomAvailability\" of the CiscoSparkClientData class", ignore_extras);
            fieldGeneratorRoomDetails = new CiscoSparkRoomDetailJSON.HoldingArrayGenerator("field \"RoomDetails\" of the CiscoSparkClientData class", ignore_extras);
            fieldGeneratorDeviceIPAddress = new JSONHoldingStringGenerator("field \"DeviceIPAddress\" of the CiscoSparkClientData class");
            fieldGeneratorSoftwareVersion = new JSONHoldingStringGenerator("field \"SoftwareVersion\" of the CiscoSparkClientData class");
            fieldGeneratorDeviceTargetIdentifiers = new JSONHoldingStringArrayGenerator("field \"DeviceTargetIdentifiers\" of the CiscoSparkClientData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CiscoSparkClientData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorReserveRoomSuggestion = new CiscoSparkReserveRoomSuggestionClientDataJSON.HoldingGenerator("field \"ReserveRoomSuggestion\" of the CiscoSparkClientData class", false);
            fieldGeneratorRoomAvailability = new CiscoSparkRoomAvailabilityItemJSON.HoldingArrayGenerator("field \"RoomAvailability\" of the CiscoSparkClientData class", false);
            fieldGeneratorRoomDetails = new CiscoSparkRoomDetailJSON.HoldingArrayGenerator("field \"RoomDetails\" of the CiscoSparkClientData class", false);
            fieldGeneratorDeviceIPAddress = new JSONHoldingStringGenerator("field \"DeviceIPAddress\" of the CiscoSparkClientData class");
            fieldGeneratorSoftwareVersion = new JSONHoldingStringGenerator("field \"SoftwareVersion\" of the CiscoSparkClientData class");
            fieldGeneratorDeviceTargetIdentifiers = new JSONHoldingStringArrayGenerator("field \"DeviceTargetIdentifiers\" of the CiscoSparkClientData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CiscoSparkClientData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorReserveRoomSuggestion.reset();
            fieldGeneratorRoomAvailability.reset();
            fieldGeneratorRoomDetails.reset();
            fieldGeneratorDeviceIPAddress.reset();
            fieldGeneratorSoftwareVersion.reset();
            fieldGeneratorDeviceTargetIdentifiers.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorReserveRoomSuggestion.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRoomAvailability.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRoomDetails.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorReserveRoomSuggestion.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRoomAvailability.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRoomDetails.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CiscoSparkClientDataJSON  result)
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
        public CiscoSparkClientDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CiscoSparkClientDataJSON  result)
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
    protected virtual void handle_result(List<CiscoSparkClientDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CiscoSparkClientDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CiscoSparkClientDataJSON>();
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
    public List<CiscoSparkClientDataJSON> value;
  };
  };
