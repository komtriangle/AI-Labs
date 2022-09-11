/* file "StationPlayIHeartRadioCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class StationPlayIHeartRadioCommandJSON : IHeartRadioCommandJSON
  {
    private bool flagHasStations;
    private List< RadioStationJSON  > storeStations;
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private bool flagHasStationIndicesToPlay;
    private List< BigInteger > storeStationIndicesToPlay;
    private bool flagHasUserRequestedQueryInfo;
    private IHeartRadioQueryInfoJSON  storeUserRequestedQueryInfo;
    private bool flagHasIHeartRadioUserIdentificationData;
    private IHeartMediaUserIdentificationDataJSON  storeIHeartRadioUserIdentificationData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraStationsToJSON()
      {
        JSONArrayValue generated_array_1_Stations = new JSONArrayValue();
        for (int num1 = 0; num1 < storeStations.Count; ++num1)
          {
            JSONValueHandler handler_Stations = new JSONValueHandler();
            storeStations[num1].write_as_json(handler_Stations);
            generated_array_1_Stations.appendComponent(handler_Stations.result);
          }
        return generated_array_1_Stations;
      }

    private JSONValue  extraAttributionToJSON()
      {
        JSONValueHandler handler_Attribution = new JSONValueHandler();
        storeAttribution.write_as_json(handler_Attribution);
        return handler_Attribution.result;
      }

    private JSONValue  extraStationIndicesToPlayToJSON()
      {
        JSONArrayValue generated_array_2_StationIndicesToPlay = new JSONArrayValue();
        for (int num2 = 0; num2 < storeStationIndicesToPlay.Count; ++num2)
          {
            JSONIntegerValue generated_integer_StationIndicesToPlay = new JSONIntegerValue(storeStationIndicesToPlay[num2]);
            generated_array_2_StationIndicesToPlay.appendComponent(generated_integer_StationIndicesToPlay);
          }
        return generated_array_2_StationIndicesToPlay;
      }

    private JSONValue  extraUserRequestedQueryInfoToJSON()
      {
        JSONValueHandler handler_UserRequestedQueryInfo = new JSONValueHandler();
        storeUserRequestedQueryInfo.write_as_json(handler_UserRequestedQueryInfo);
        return handler_UserRequestedQueryInfo.result;
      }

    private JSONValue  extraIHeartRadioUserIdentificationDataToJSON()
      {
        JSONValueHandler handler_IHeartRadioUserIdentificationData = new JSONValueHandler();
        storeIHeartRadioUserIdentificationData.write_as_json(handler_IHeartRadioUserIdentificationData);
        return handler_IHeartRadioUserIdentificationData.result;
      }


    private void  fromJSONStations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Stations of StationPlayIHeartRadioCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RadioStationJSON  > vector_Stations1 = new List< RadioStationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RadioStationJSON convert_classy = RadioStationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Stations1.Add(convert_classy);
          }
        initStations();
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
            appendStations(vector_Stations1[num1]);
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    private void  fromJSONStationIndicesToPlay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StationIndicesToPlay of StationPlayIHeartRadioCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_StationIndicesToPlay1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field StationIndicesToPlay of StationPlayIHeartRadioCommandJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field StationIndicesToPlay of StationPlayIHeartRadioCommandJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_StationIndicesToPlay1.Add(extracted_integer);
          }
        initStationIndicesToPlay();
        for (int num2 = 0; num2 < vector_StationIndicesToPlay1.Count; ++num2)
            appendStationIndicesToPlay(vector_StationIndicesToPlay1[num2]);
        for (int num1 = 0; num1 < vector_StationIndicesToPlay1.Count; ++num1)
          {
          }
      }


    private void  fromJSONUserRequestedQueryInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioQueryInfoJSON convert_classy = IHeartRadioQueryInfoJSON.from_json(json_value, ignore_extras, true);
        setUserRequestedQueryInfo(convert_classy);
      }


    private void  fromJSONIHeartRadioUserIdentificationData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartMediaUserIdentificationDataJSON convert_classy = IHeartMediaUserIdentificationDataJSON.from_json(json_value, ignore_extras, true);
        setIHeartRadioUserIdentificationData(convert_classy);
      }


    public StationPlayIHeartRadioCommandJSON()
      {
        flagHasStations = false;
        flagHasAttribution = false;
        flagHasStationIndicesToPlay = false;
        flagHasUserRequestedQueryInfo = false;
        flagHasIHeartRadioUserIdentificationData = false;
        storeStations = new List< RadioStationJSON  >();
        storeStationIndicesToPlay = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getIHeartRadioCommandKind()
      {
        return "StationPlayIHeartRadioCommand";
      }

    public bool  hasStations()
      {
        return flagHasStations;
      }

    public int  countOfStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations.Count;
      }

    public RadioStationJSON   elementOfStations(int element_num)
      {
        Debug.Assert(flagHasStations);
        return storeStations[element_num];
      }

    public List< RadioStationJSON  >  getStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations;
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public AttributionJSON   getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }

    public bool  hasStationIndicesToPlay()
      {
        return flagHasStationIndicesToPlay;
      }

    public int  countOfStationIndicesToPlay()
      {
        Debug.Assert(flagHasStationIndicesToPlay);
        return storeStationIndicesToPlay.Count;
      }

    public BigInteger  elementOfStationIndicesToPlay(int element_num)
      {
        Debug.Assert(flagHasStationIndicesToPlay);
        return storeStationIndicesToPlay[element_num];
      }

    public List< BigInteger >  getStationIndicesToPlay()
      {
        Debug.Assert(flagHasStationIndicesToPlay);
        return storeStationIndicesToPlay;
      }

    public bool  hasUserRequestedQueryInfo()
      {
        return flagHasUserRequestedQueryInfo;
      }

    public IHeartRadioQueryInfoJSON   getUserRequestedQueryInfo()
      {
        Debug.Assert(flagHasUserRequestedQueryInfo);
        return storeUserRequestedQueryInfo;
      }

    public bool  hasIHeartRadioUserIdentificationData()
      {
        return flagHasIHeartRadioUserIdentificationData;
      }

    public IHeartMediaUserIdentificationDataJSON   getIHeartRadioUserIdentificationData()
      {
        Debug.Assert(flagHasIHeartRadioUserIdentificationData);
        return storeIHeartRadioUserIdentificationData;
      }


    public virtual int extraStationPlayIHeartRadioCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStationPlayIHeartRadioCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStationPlayIHeartRadioCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStationPlayIHeartRadioCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraIHeartRadioCommandComponentCount()
      {
        int result = 0;
        if (flagHasStations)
            ++result;
        if (flagHasAttribution)
            ++result;
        if (flagHasStationIndicesToPlay)
            ++result;
        if (flagHasUserRequestedQueryInfo)
            ++result;
        if (flagHasIHeartRadioUserIdentificationData)
            ++result;
        result += extraStationPlayIHeartRadioCommandComponentCount();
        return result;
      }
    public override string extraIHeartRadioCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasStations)
          {
            if (remainder == 0)
                return "Stations";
            --remainder;
          }
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return "Attribution";
            --remainder;
          }
        if (flagHasStationIndicesToPlay)
          {
            if (remainder == 0)
                return "StationIndicesToPlay";
            --remainder;
          }
        if (flagHasUserRequestedQueryInfo)
          {
            if (remainder == 0)
                return "UserRequestedQueryInfo";
            --remainder;
          }
        if (flagHasIHeartRadioUserIdentificationData)
          {
            if (remainder == 0)
                return "IHeartRadioUserIdentificationData";
            --remainder;
          }
        return extraStationPlayIHeartRadioCommandComponentKey(remainder);
      }
    public override JSONValue extraIHeartRadioCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasStations)
          {
            if (remainder == 0)
                return extraStationsToJSON();
            --remainder;
          }
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return extraAttributionToJSON();
            --remainder;
          }
        if (flagHasStationIndicesToPlay)
          {
            if (remainder == 0)
                return extraStationIndicesToPlayToJSON();
            --remainder;
          }
        if (flagHasUserRequestedQueryInfo)
          {
            if (remainder == 0)
                return extraUserRequestedQueryInfoToJSON();
            --remainder;
          }
        if (flagHasIHeartRadioUserIdentificationData)
          {
            if (remainder == 0)
                return extraIHeartRadioUserIdentificationDataToJSON();
            --remainder;
          }
        return extraStationPlayIHeartRadioCommandComponentValue(remainder);
      }
    public override JSONValue extraIHeartRadioCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasAttribution ? extraAttributionToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "HeartRadioUserIdentificationData", 0, 32, false) == 0) && (field_name.Length == 33))
                    return (flagHasIHeartRadioUserIdentificationData ? extraIHeartRadioUserIdentificationDataToJSON() : null);
                break;
            case 'S':
                if (String.Compare(field_name, 1, "tation", 0, 6, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 8, "ndicesToPlay", 0, 12, false) == 0) && (field_name.Length == 20))
                                return (flagHasStationIndicesToPlay ? extraStationIndicesToPlayToJSON() : null);
                            break;
                        case 's':
                            if (field_name.Length == 8)
                                return (flagHasStations ? extraStationsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serRequestedQueryInfo", 0, 21, false) == 0) && (field_name.Length == 22))
                    return (flagHasUserRequestedQueryInfo ? extraUserRequestedQueryInfoToJSON() : null);
                break;
            default:
                break;
          }
        return extraStationPlayIHeartRadioCommandLookup(field_name);
      }

    public void initStations()
      {
        if (flagHasStations)
          {
            for (int num1 = 0; num1 < storeStations.Count; ++num1)
              {
              }
          }
        flagHasStations = true;
        storeStations.Clear();
      }
    public void appendStations(RadioStationJSON  to_append)
      {
        if (!flagHasStations)
          {
            flagHasStations = true;
            storeStations.Clear();
          }
        Debug.Assert(flagHasStations);
        storeStations.Add(to_append);
      }
    public void unsetStations()
      {
        if (flagHasStations)
          {
            for (int num2 = 0; num2 < storeStations.Count; ++num2)
              {
              }
          }
        flagHasStations = false;
        storeStations.Clear();
      }
    public void setAttribution(AttributionJSON  new_value)
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = false;
      }
    public void initStationIndicesToPlay()
      {
        flagHasStationIndicesToPlay = true;
        storeStationIndicesToPlay.Clear();
      }
    public void appendStationIndicesToPlay(BigInteger to_append)
      {
        if (!flagHasStationIndicesToPlay)
          {
            flagHasStationIndicesToPlay = true;
            storeStationIndicesToPlay.Clear();
          }
        Debug.Assert(flagHasStationIndicesToPlay);
        storeStationIndicesToPlay.Add(to_append);
      }
    public void unsetStationIndicesToPlay()
      {
        flagHasStationIndicesToPlay = false;
        storeStationIndicesToPlay.Clear();
      }
    public void setUserRequestedQueryInfo(IHeartRadioQueryInfoJSON  new_value)
      {
        if (flagHasUserRequestedQueryInfo)
          {
          }
        flagHasUserRequestedQueryInfo = true;
        storeUserRequestedQueryInfo = new_value;
      }
    public void unsetUserRequestedQueryInfo()
      {
        if (flagHasUserRequestedQueryInfo)
          {
          }
        flagHasUserRequestedQueryInfo = false;
      }
    public void setIHeartRadioUserIdentificationData(IHeartMediaUserIdentificationDataJSON  new_value)
      {
        if (flagHasIHeartRadioUserIdentificationData)
          {
          }
        flagHasIHeartRadioUserIdentificationData = true;
        storeIHeartRadioUserIdentificationData = new_value;
      }
    public void unsetIHeartRadioUserIdentificationData()
      {
        if (flagHasIHeartRadioUserIdentificationData)
          {
          }
        flagHasIHeartRadioUserIdentificationData = false;
      }

    public virtual void extraStationPlayIHeartRadioCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStationPlayIHeartRadioCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStationPlayIHeartRadioCommandLookup(key);
        if (old_field == null)
          {
            extraStationPlayIHeartRadioCommandAppendPair(key, new_component);
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
    public override void extraIHeartRadioCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "HeartRadioUserIdentificationData", 0, 32, false) == 0) && (key.Length == 33))
                    {
                    fromJSONIHeartRadioUserIdentificationData(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "tation", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'I':
                            if ((String.Compare(key, 8, "ndicesToPlay", 0, 12, false) == 0) && (key.Length == 20))
                                {
                                fromJSONStationIndicesToPlay(new_component, false);
                                return;
                                }
                            break;
                        case 's':
                            if (key.Length == 8)
                                {
                                fromJSONStations(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serRequestedQueryInfo", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONUserRequestedQueryInfo(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraStationPlayIHeartRadioCommandAppendPair(key, new_component);
      }
    public override void extraIHeartRadioCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "HeartRadioUserIdentificationData", 0, 32, false) == 0) && (key.Length == 33))
                    {
                    fromJSONIHeartRadioUserIdentificationData(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "tation", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'I':
                            if ((String.Compare(key, 8, "ndicesToPlay", 0, 12, false) == 0) && (key.Length == 20))
                                {
                                fromJSONStationIndicesToPlay(new_component, false);
                                return;
                                }
                            break;
                        case 's':
                            if (key.Length == 8)
                                {
                                fromJSONStations(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serRequestedQueryInfo", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONUserRequestedQueryInfo(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraStationPlayIHeartRadioCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStations);
        if (flagHasStations)
          {
            handler.start_pair("Stations");
            handler.start_array();
            for (int num1 = 0; num1 < storeStations.Count; ++num1)
              {
                if (partial_allowed)
                    storeStations[num1].write_partial_as_json(handler);
                else
                    storeStations[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStationIndicesToPlay);
        if (flagHasStationIndicesToPlay)
          {
            handler.start_pair("StationIndicesToPlay");
            handler.start_array();
            for (int num2 = 0; num2 < storeStationIndicesToPlay.Count; ++num2)
              {
                handler.number_value(storeStationIndicesToPlay[num2]);
              }
            handler.finish_array();
          }
        if (flagHasUserRequestedQueryInfo)
          {
            handler.start_pair("UserRequestedQueryInfo");
            if (partial_allowed)
                storeUserRequestedQueryInfo.write_partial_as_json(handler);
            else
                storeUserRequestedQueryInfo.write_as_json(handler);
          }
        if (flagHasIHeartRadioUserIdentificationData)
          {
            handler.start_pair("IHeartRadioUserIdentificationData");
            if (partial_allowed)
                storeIHeartRadioUserIdentificationData.write_partial_as_json(handler);
            else
                storeIHeartRadioUserIdentificationData.write_as_json(handler);
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
        if (!(hasStations()))
          {
            return "When parsing the object for %what%, the \"Stations\" field was missing.";
          }
        if (!(hasStationIndicesToPlay()))
          {
            return "When parsing the object for %what%, the \"StationIndicesToPlay\" field was missing.";
          }
        return null;
      }

    public static new StationPlayIHeartRadioCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StationPlayIHeartRadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationPlayIHeartRadioCommand", ignore_extras);
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
    public static new StationPlayIHeartRadioCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StationPlayIHeartRadioCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StationPlayIHeartRadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationPlayIHeartRadioCommand", ignore_extras);
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
    public static new StationPlayIHeartRadioCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StationPlayIHeartRadioCommandJSON from_text(string text, bool ignore_extras)
      {
        StationPlayIHeartRadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationPlayIHeartRadioCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StationPlayIHeartRadioCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new StationPlayIHeartRadioCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StationPlayIHeartRadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationPlayIHeartRadioCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : IHeartRadioCommandJSON.Generator
      {
        private RadioStationJSON.HoldingArrayGenerator fieldGeneratorStations;
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
    private class FieldHoldingGeneratorStationIndicesToPlay : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStationIndicesToPlay(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStationIndicesToPlay : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStationIndicesToPlay(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorStationIndicesToPlay fieldGeneratorStationIndicesToPlay;
        private IHeartRadioQueryInfoJSON.HoldingGenerator fieldGeneratorUserRequestedQueryInfo;
        private IHeartMediaUserIdentificationDataJSON.HoldingGenerator fieldGeneratorIHeartRadioUserIdentificationData;
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
            if (!(getIHeartRadioCommandJSONKey().Equals("StationPlayIHeartRadioCommand")))
                throw new Exception("The key field has a value other than `StationPlayIHeartRadioCommand'.");
            StationPlayIHeartRadioCommandJSON result = new StationPlayIHeartRadioCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStationPlayIHeartRadioCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(IHeartRadioCommandJSON new_result)
          {
            handle_result((StationPlayIHeartRadioCommandJSON )new_result);
          }
        protected void finish(StationPlayIHeartRadioCommandJSON result)
          {
            if (fieldGeneratorStations.have_value)
              {
                result.initStations();
                int count = fieldGeneratorStations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStations(fieldGeneratorStations.value[num]);
                  }
                fieldGeneratorStations.value.Clear();
                fieldGeneratorStations.have_value = false;
              }
            else if ((!(result.hasStations())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Stations\" field was missing.");
              }
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
            if (fieldGeneratorStationIndicesToPlay.have_value)
              {
                result.initStationIndicesToPlay();
                int count = fieldGeneratorStationIndicesToPlay.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStationIndicesToPlay(fieldGeneratorStationIndicesToPlay.value[num]);
                  }
                fieldGeneratorStationIndicesToPlay.value.Clear();
                fieldGeneratorStationIndicesToPlay.have_value = false;
              }
            else if ((!(result.hasStationIndicesToPlay())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StationIndicesToPlay\" field was missing.");
              }
            if (fieldGeneratorUserRequestedQueryInfo.have_value)
              {
                result.setUserRequestedQueryInfo(fieldGeneratorUserRequestedQueryInfo.value);
                fieldGeneratorUserRequestedQueryInfo.have_value = false;
              }
            if (fieldGeneratorIHeartRadioUserIdentificationData.have_value)
              {
                result.setIHeartRadioUserIdentificationData(fieldGeneratorIHeartRadioUserIdentificationData.value);
                fieldGeneratorIHeartRadioUserIdentificationData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(StationPlayIHeartRadioCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAttribution;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "HeartRadioUserIdentificationData", 0, 32, false) == 0) && (field_name.Length == 33))
                        return fieldGeneratorIHeartRadioUserIdentificationData;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tation", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 8, "ndicesToPlay", 0, 12, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorStationIndicesToPlay;
                                break;
                            case 's':
                                if (field_name.Length == 8)
                                    return fieldGeneratorStations;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serRequestedQueryInfo", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorUserRequestedQueryInfo;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorStations = new RadioStationJSON.HoldingArrayGenerator("field \"Stations\" of the StationPlayIHeartRadioCommand class", ignore_extras);
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the StationPlayIHeartRadioCommand class", ignore_extras);
            fieldGeneratorStationIndicesToPlay = new FieldHoldingArrayGeneratorStationIndicesToPlay("field \"StationIndicesToPlay\" of the StationPlayIHeartRadioCommand class");
            fieldGeneratorUserRequestedQueryInfo = new IHeartRadioQueryInfoJSON.HoldingGenerator("field \"UserRequestedQueryInfo\" of the StationPlayIHeartRadioCommand class", ignore_extras);
            fieldGeneratorIHeartRadioUserIdentificationData = new IHeartMediaUserIdentificationDataJSON.HoldingGenerator("field \"IHeartRadioUserIdentificationData\" of the StationPlayIHeartRadioCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StationPlayIHeartRadioCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorStations = new RadioStationJSON.HoldingArrayGenerator("field \"Stations\" of the StationPlayIHeartRadioCommand class", false);
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the StationPlayIHeartRadioCommand class", false);
            fieldGeneratorStationIndicesToPlay = new FieldHoldingArrayGeneratorStationIndicesToPlay("field \"StationIndicesToPlay\" of the StationPlayIHeartRadioCommand class");
            fieldGeneratorUserRequestedQueryInfo = new IHeartRadioQueryInfoJSON.HoldingGenerator("field \"UserRequestedQueryInfo\" of the StationPlayIHeartRadioCommand class", false);
            fieldGeneratorIHeartRadioUserIdentificationData = new IHeartMediaUserIdentificationDataJSON.HoldingGenerator("field \"IHeartRadioUserIdentificationData\" of the StationPlayIHeartRadioCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StationPlayIHeartRadioCommand class");
          }

        public override void reset()
          {
            fieldGeneratorStations.reset();
            fieldGeneratorAttribution.reset();
            fieldGeneratorStationIndicesToPlay.reset();
            fieldGeneratorUserRequestedQueryInfo.reset();
            fieldGeneratorIHeartRadioUserIdentificationData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(StationPlayIHeartRadioCommandJSON  result)
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
        public StationPlayIHeartRadioCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StationPlayIHeartRadioCommandJSON  result)
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
    protected virtual void handle_result(List<StationPlayIHeartRadioCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StationPlayIHeartRadioCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StationPlayIHeartRadioCommandJSON>();
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
    public List<StationPlayIHeartRadioCommandJSON> value;
  };
  };
