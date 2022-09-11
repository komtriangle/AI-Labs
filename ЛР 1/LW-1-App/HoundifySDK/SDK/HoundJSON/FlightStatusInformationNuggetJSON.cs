/* file "FlightStatusInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightStatusInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasCurrentDateAndTime;
    private FlightTimesJSON  storeCurrentDateAndTime;
    private bool flagHasFlightTravelLocationForClient;
    private FlightTravelLocationJSON  storeFlightTravelLocationForClient;
    private bool flagHasFlightStatusSearchResults;
    private List< FlightStatusSearchResultJSON  > storeFlightStatusSearchResults;
    private bool flagHasQueryState;
    private FlightStatusQueryStateJSON  storeQueryState;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCurrentDateAndTimeToJSON()
      {
        JSONValueHandler handler_CurrentDateAndTime = new JSONValueHandler();
        storeCurrentDateAndTime.write_as_json(handler_CurrentDateAndTime);
        return handler_CurrentDateAndTime.result;
      }

    private JSONValue  extraFlightTravelLocationForClientToJSON()
      {
        JSONValueHandler handler_FlightTravelLocationForClient = new JSONValueHandler();
        storeFlightTravelLocationForClient.write_as_json(handler_FlightTravelLocationForClient);
        return handler_FlightTravelLocationForClient.result;
      }

    private JSONValue  extraFlightStatusSearchResultsToJSON()
      {
        JSONArrayValue generated_array_1_FlightStatusSearchResults = new JSONArrayValue();
        for (int num1 = 0; num1 < storeFlightStatusSearchResults.Count; ++num1)
          {
            JSONValueHandler handler_FlightStatusSearchResults = new JSONValueHandler();
            storeFlightStatusSearchResults[num1].write_as_json(handler_FlightStatusSearchResults);
            generated_array_1_FlightStatusSearchResults.appendComponent(handler_FlightStatusSearchResults.result);
          }
        return generated_array_1_FlightStatusSearchResults;
      }

    private JSONValue  extraQueryStateToJSON()
      {
        JSONValueHandler handler_QueryState = new JSONValueHandler();
        storeQueryState.write_as_json(handler_QueryState);
        return handler_QueryState.result;
      }


    private void  fromJSONCurrentDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setCurrentDateAndTime(convert_classy);
      }


    private void  fromJSONFlightTravelLocationForClient(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTravelLocationJSON convert_classy = FlightTravelLocationJSON.from_json(json_value, ignore_extras, true);
        setFlightTravelLocationForClient(convert_classy);
      }


    private void  fromJSONFlightStatusSearchResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlightStatusSearchResults of FlightStatusInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightStatusSearchResultJSON  > vector_FlightStatusSearchResults1 = new List< FlightStatusSearchResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightStatusSearchResultJSON convert_classy = FlightStatusSearchResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlightStatusSearchResults1.Add(convert_classy);
          }
        initFlightStatusSearchResults();
        for (int num1 = 0; num1 < vector_FlightStatusSearchResults1.Count; ++num1)
            appendFlightStatusSearchResults(vector_FlightStatusSearchResults1[num1]);
        for (int num1 = 0; num1 < vector_FlightStatusSearchResults1.Count; ++num1)
          {
          }
      }


    private void  fromJSONQueryState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatusQueryStateJSON convert_classy = FlightStatusQueryStateJSON.from_json(json_value, ignore_extras, true);
        setQueryState(convert_classy);
      }


    public FlightStatusInformationNuggetJSON()
      {
        flagHasCurrentDateAndTime = false;
        flagHasFlightTravelLocationForClient = false;
        flagHasFlightStatusSearchResults = false;
        flagHasQueryState = false;
        storeFlightStatusSearchResults = new List< FlightStatusSearchResultJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "FlightStatus";
      }

    public bool  hasCurrentDateAndTime()
      {
        return flagHasCurrentDateAndTime;
      }

    public FlightTimesJSON   getCurrentDateAndTime()
      {
        Debug.Assert(flagHasCurrentDateAndTime);
        return storeCurrentDateAndTime;
      }

    public bool  hasFlightTravelLocationForClient()
      {
        return flagHasFlightTravelLocationForClient;
      }

    public FlightTravelLocationJSON   getFlightTravelLocationForClient()
      {
        Debug.Assert(flagHasFlightTravelLocationForClient);
        return storeFlightTravelLocationForClient;
      }

    public bool  hasFlightStatusSearchResults()
      {
        return flagHasFlightStatusSearchResults;
      }

    public int  countOfFlightStatusSearchResults()
      {
        Debug.Assert(flagHasFlightStatusSearchResults);
        return storeFlightStatusSearchResults.Count;
      }

    public FlightStatusSearchResultJSON   elementOfFlightStatusSearchResults(int element_num)
      {
        Debug.Assert(flagHasFlightStatusSearchResults);
        return storeFlightStatusSearchResults[element_num];
      }

    public List< FlightStatusSearchResultJSON  >  getFlightStatusSearchResults()
      {
        Debug.Assert(flagHasFlightStatusSearchResults);
        return storeFlightStatusSearchResults;
      }

    public bool  hasQueryState()
      {
        return flagHasQueryState;
      }

    public FlightStatusQueryStateJSON   getQueryState()
      {
        Debug.Assert(flagHasQueryState);
        return storeQueryState;
      }


    public virtual int extraFlightStatusInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatusInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatusInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatusInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasCurrentDateAndTime)
            ++result;
        if (flagHasFlightTravelLocationForClient)
            ++result;
        if (flagHasFlightStatusSearchResults)
            ++result;
        if (flagHasQueryState)
            ++result;
        result += extraFlightStatusInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCurrentDateAndTime)
          {
            if (remainder == 0)
                return "CurrentDateAndTime";
            --remainder;
          }
        if (flagHasFlightTravelLocationForClient)
          {
            if (remainder == 0)
                return "FlightTravelLocationForClient";
            --remainder;
          }
        if (flagHasFlightStatusSearchResults)
          {
            if (remainder == 0)
                return "FlightStatusSearchResults";
            --remainder;
          }
        if (flagHasQueryState)
          {
            if (remainder == 0)
                return "QueryState";
            --remainder;
          }
        return extraFlightStatusInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCurrentDateAndTime)
          {
            if (remainder == 0)
                return extraCurrentDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasFlightTravelLocationForClient)
          {
            if (remainder == 0)
                return extraFlightTravelLocationForClientToJSON();
            --remainder;
          }
        if (flagHasFlightStatusSearchResults)
          {
            if (remainder == 0)
                return extraFlightStatusSearchResultsToJSON();
            --remainder;
          }
        if (flagHasQueryState)
          {
            if (remainder == 0)
                return extraQueryStateToJSON();
            --remainder;
          }
        return extraFlightStatusInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "urrentDateAndTime", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasCurrentDateAndTime ? extraCurrentDateAndTimeToJSON() : null);
                break;
            case 'F':
                if (String.Compare(field_name, 1, "light", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'S':
                            if ((String.Compare(field_name, 7, "tatusSearchResults", 0, 18, false) == 0) && (field_name.Length == 25))
                                return (flagHasFlightStatusSearchResults ? extraFlightStatusSearchResultsToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 7, "ravelLocationForClient", 0, 22, false) == 0) && (field_name.Length == 29))
                                return (flagHasFlightTravelLocationForClient ? extraFlightTravelLocationForClientToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryState", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasQueryState ? extraQueryStateToJSON() : null);
                break;
            default:
                break;
          }
        return extraFlightStatusInformationNuggetLookup(field_name);
      }

    public void setCurrentDateAndTime(FlightTimesJSON  new_value)
      {
        if (flagHasCurrentDateAndTime)
          {
          }
        flagHasCurrentDateAndTime = true;
        storeCurrentDateAndTime = new_value;
      }
    public void unsetCurrentDateAndTime()
      {
        if (flagHasCurrentDateAndTime)
          {
          }
        flagHasCurrentDateAndTime = false;
      }
    public void setFlightTravelLocationForClient(FlightTravelLocationJSON  new_value)
      {
        if (flagHasFlightTravelLocationForClient)
          {
          }
        flagHasFlightTravelLocationForClient = true;
        storeFlightTravelLocationForClient = new_value;
      }
    public void unsetFlightTravelLocationForClient()
      {
        if (flagHasFlightTravelLocationForClient)
          {
          }
        flagHasFlightTravelLocationForClient = false;
      }
    public void initFlightStatusSearchResults()
      {
        if (flagHasFlightStatusSearchResults)
          {
            for (int num1 = 0; num1 < storeFlightStatusSearchResults.Count; ++num1)
              {
              }
          }
        flagHasFlightStatusSearchResults = true;
        storeFlightStatusSearchResults.Clear();
      }
    public void appendFlightStatusSearchResults(FlightStatusSearchResultJSON  to_append)
      {
        if (!flagHasFlightStatusSearchResults)
          {
            flagHasFlightStatusSearchResults = true;
            storeFlightStatusSearchResults.Clear();
          }
        Debug.Assert(flagHasFlightStatusSearchResults);
        storeFlightStatusSearchResults.Add(to_append);
      }
    public void unsetFlightStatusSearchResults()
      {
        if (flagHasFlightStatusSearchResults)
          {
            for (int num2 = 0; num2 < storeFlightStatusSearchResults.Count; ++num2)
              {
              }
          }
        flagHasFlightStatusSearchResults = false;
        storeFlightStatusSearchResults.Clear();
      }
    public void setQueryState(FlightStatusQueryStateJSON  new_value)
      {
        if (flagHasQueryState)
          {
          }
        flagHasQueryState = true;
        storeQueryState = new_value;
      }
    public void unsetQueryState()
      {
        if (flagHasQueryState)
          {
          }
        flagHasQueryState = false;
      }

    public virtual void extraFlightStatusInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatusInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatusInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraFlightStatusInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "urrentDateAndTime", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONCurrentDateAndTime(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if (String.Compare(key, 1, "light", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'S':
                            if ((String.Compare(key, 7, "tatusSearchResults", 0, 18, false) == 0) && (key.Length == 25))
                                {
                                fromJSONFlightStatusSearchResults(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 7, "ravelLocationForClient", 0, 22, false) == 0) && (key.Length == 29))
                                {
                                fromJSONFlightTravelLocationForClient(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryState", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONQueryState(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFlightStatusInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "urrentDateAndTime", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONCurrentDateAndTime(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if (String.Compare(key, 1, "light", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'S':
                            if ((String.Compare(key, 7, "tatusSearchResults", 0, 18, false) == 0) && (key.Length == 25))
                                {
                                fromJSONFlightStatusSearchResults(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 7, "ravelLocationForClient", 0, 22, false) == 0) && (key.Length == 29))
                                {
                                fromJSONFlightTravelLocationForClient(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryState", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONQueryState(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFlightStatusInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCurrentDateAndTime);
        if (flagHasCurrentDateAndTime)
          {
            handler.start_pair("CurrentDateAndTime");
            if (partial_allowed)
                storeCurrentDateAndTime.write_partial_as_json(handler);
            else
                storeCurrentDateAndTime.write_as_json(handler);
          }
        if (flagHasFlightTravelLocationForClient)
          {
            handler.start_pair("FlightTravelLocationForClient");
            if (partial_allowed)
                storeFlightTravelLocationForClient.write_partial_as_json(handler);
            else
                storeFlightTravelLocationForClient.write_as_json(handler);
          }
        if (flagHasFlightStatusSearchResults)
          {
            handler.start_pair("FlightStatusSearchResults");
            handler.start_array();
            for (int num1 = 0; num1 < storeFlightStatusSearchResults.Count; ++num1)
              {
                if (partial_allowed)
                    storeFlightStatusSearchResults[num1].write_partial_as_json(handler);
                else
                    storeFlightStatusSearchResults[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasQueryState)
          {
            handler.start_pair("QueryState");
            if (partial_allowed)
                storeQueryState.write_partial_as_json(handler);
            else
                storeQueryState.write_as_json(handler);
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
        if (!(hasCurrentDateAndTime()))
          {
            return "When parsing the object for %what%, the \"CurrentDateAndTime\" field was missing.";
          }
        return null;
      }

    public static new FlightStatusInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusInformationNugget", ignore_extras);
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
    public static new FlightStatusInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FlightStatusInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusInformationNugget", ignore_extras);
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
    public static new FlightStatusInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FlightStatusInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        FlightStatusInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatusInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FlightStatusInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatusInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private FlightTimesJSON.HoldingGenerator fieldGeneratorCurrentDateAndTime;
        private FlightTravelLocationJSON.HoldingGenerator fieldGeneratorFlightTravelLocationForClient;
        private FlightStatusSearchResultJSON.HoldingArrayGenerator fieldGeneratorFlightStatusSearchResults;
        private FlightStatusQueryStateJSON.HoldingGenerator fieldGeneratorQueryState;
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
            if (!(getInformationNuggetJSONKey().Equals("FlightStatus")))
                throw new Exception("The key field has a value other than `FlightStatus'.");
            FlightStatusInformationNuggetJSON result = new FlightStatusInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatusInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((FlightStatusInformationNuggetJSON )new_result);
          }
        protected void finish(FlightStatusInformationNuggetJSON result)
          {
            if (fieldGeneratorCurrentDateAndTime.have_value)
              {
                result.setCurrentDateAndTime(fieldGeneratorCurrentDateAndTime.value);
                fieldGeneratorCurrentDateAndTime.have_value = false;
              }
            else if ((!(result.hasCurrentDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CurrentDateAndTime\" field was missing.");
              }
            if (fieldGeneratorFlightTravelLocationForClient.have_value)
              {
                result.setFlightTravelLocationForClient(fieldGeneratorFlightTravelLocationForClient.value);
                fieldGeneratorFlightTravelLocationForClient.have_value = false;
              }
            if (fieldGeneratorFlightStatusSearchResults.have_value)
              {
                result.initFlightStatusSearchResults();
                int count = fieldGeneratorFlightStatusSearchResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlightStatusSearchResults(fieldGeneratorFlightStatusSearchResults.value[num]);
                  }
                fieldGeneratorFlightStatusSearchResults.value.Clear();
                fieldGeneratorFlightStatusSearchResults.have_value = false;
              }
            if (fieldGeneratorQueryState.have_value)
              {
                result.setQueryState(fieldGeneratorQueryState.value);
                fieldGeneratorQueryState.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(FlightStatusInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "urrentDateAndTime", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorCurrentDateAndTime;
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "light", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 7, "tatusSearchResults", 0, 18, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorFlightStatusSearchResults;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "ravelLocationForClient", 0, 22, false) == 0) && (field_name.Length == 29))
                                    return fieldGeneratorFlightTravelLocationForClient;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryState", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorQueryState;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCurrentDateAndTime = new FlightTimesJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the FlightStatusInformationNugget class", ignore_extras);
            fieldGeneratorFlightTravelLocationForClient = new FlightTravelLocationJSON.HoldingGenerator("field \"FlightTravelLocationForClient\" of the FlightStatusInformationNugget class", ignore_extras);
            fieldGeneratorFlightStatusSearchResults = new FlightStatusSearchResultJSON.HoldingArrayGenerator("field \"FlightStatusSearchResults\" of the FlightStatusInformationNugget class", ignore_extras);
            fieldGeneratorQueryState = new FlightStatusQueryStateJSON.HoldingGenerator("field \"QueryState\" of the FlightStatusInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatusInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCurrentDateAndTime = new FlightTimesJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the FlightStatusInformationNugget class", false);
            fieldGeneratorFlightTravelLocationForClient = new FlightTravelLocationJSON.HoldingGenerator("field \"FlightTravelLocationForClient\" of the FlightStatusInformationNugget class", false);
            fieldGeneratorFlightStatusSearchResults = new FlightStatusSearchResultJSON.HoldingArrayGenerator("field \"FlightStatusSearchResults\" of the FlightStatusInformationNugget class", false);
            fieldGeneratorQueryState = new FlightStatusQueryStateJSON.HoldingGenerator("field \"QueryState\" of the FlightStatusInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatusInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorCurrentDateAndTime.reset();
            fieldGeneratorFlightTravelLocationForClient.reset();
            fieldGeneratorFlightStatusSearchResults.reset();
            fieldGeneratorQueryState.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatusInformationNuggetJSON  result)
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
        public FlightStatusInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatusInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<FlightStatusInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatusInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatusInformationNuggetJSON>();
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
    public List<FlightStatusInformationNuggetJSON> value;
  };
  };
