/* file "SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON : SportsOlympicsInformationNuggetJSON
  {
    private bool flagHasQueryComponents;
    private List< SportsOlympicsEventSchedulesAndResultsQueryComponentJSON  > storeQueryComponents;
    private bool flagHasQueryResults;
    private List< SportsOlympicsEventSchedulesAndResultsQueryResultJSON  > storeQueryResults;
    private bool flagHasEventInstances;
    private List< SportsOlympicsEventSchedulesAndResultsInstanceJSON  > storeEventInstances;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQueryComponentsToJSON()
      {
        JSONArrayValue generated_array_1_QueryComponents = new JSONArrayValue();
        for (int num1 = 0; num1 < storeQueryComponents.Count; ++num1)
          {
            JSONValueHandler handler_QueryComponents = new JSONValueHandler();
            storeQueryComponents[num1].write_as_json(handler_QueryComponents);
            generated_array_1_QueryComponents.appendComponent(handler_QueryComponents.result);
          }
        return generated_array_1_QueryComponents;
      }

    private JSONValue  extraQueryResultsToJSON()
      {
        JSONArrayValue generated_array_2_QueryResults = new JSONArrayValue();
        for (int num2 = 0; num2 < storeQueryResults.Count; ++num2)
          {
            JSONValueHandler handler_QueryResults = new JSONValueHandler();
            storeQueryResults[num2].write_as_json(handler_QueryResults);
            generated_array_2_QueryResults.appendComponent(handler_QueryResults.result);
          }
        return generated_array_2_QueryResults;
      }

    private JSONValue  extraEventInstancesToJSON()
      {
        JSONArrayValue generated_array_3_EventInstances = new JSONArrayValue();
        for (int num3 = 0; num3 < storeEventInstances.Count; ++num3)
          {
            JSONValueHandler handler_EventInstances = new JSONValueHandler();
            storeEventInstances[num3].write_as_json(handler_EventInstances);
            generated_array_3_EventInstances.appendComponent(handler_EventInstances.result);
          }
        return generated_array_3_EventInstances;
      }


    private void  fromJSONQueryComponents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryComponents of SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field QueryComponents of SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON has too few elements.");
        List< SportsOlympicsEventSchedulesAndResultsQueryComponentJSON  > vector_QueryComponents1 = new List< SportsOlympicsEventSchedulesAndResultsQueryComponentJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsEventSchedulesAndResultsQueryComponentJSON convert_classy = SportsOlympicsEventSchedulesAndResultsQueryComponentJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueryComponents1.Add(convert_classy);
          }
        Debug.Assert(vector_QueryComponents1.Count >= 1);
        initQueryComponents();
        for (int num1 = 0; num1 < vector_QueryComponents1.Count; ++num1)
            appendQueryComponents(vector_QueryComponents1[num1]);
        for (int num1 = 0; num1 < vector_QueryComponents1.Count; ++num1)
          {
          }
      }


    private void  fromJSONQueryResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryResults of SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field QueryResults of SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON has too few elements.");
        List< SportsOlympicsEventSchedulesAndResultsQueryResultJSON  > vector_QueryResults1 = new List< SportsOlympicsEventSchedulesAndResultsQueryResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsEventSchedulesAndResultsQueryResultJSON convert_classy = SportsOlympicsEventSchedulesAndResultsQueryResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueryResults1.Add(convert_classy);
          }
        Debug.Assert(vector_QueryResults1.Count >= 1);
        initQueryResults();
        for (int num2 = 0; num2 < vector_QueryResults1.Count; ++num2)
            appendQueryResults(vector_QueryResults1[num2]);
        for (int num1 = 0; num1 < vector_QueryResults1.Count; ++num1)
          {
          }
      }


    private void  fromJSONEventInstances(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field EventInstances of SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsOlympicsEventSchedulesAndResultsInstanceJSON  > vector_EventInstances1 = new List< SportsOlympicsEventSchedulesAndResultsInstanceJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsEventSchedulesAndResultsInstanceJSON convert_classy = SportsOlympicsEventSchedulesAndResultsInstanceJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_EventInstances1.Add(convert_classy);
          }
        initEventInstances();
        for (int num3 = 0; num3 < vector_EventInstances1.Count; ++num3)
            appendEventInstances(vector_EventInstances1[num3]);
        for (int num1 = 0; num1 < vector_EventInstances1.Count; ++num1)
          {
          }
      }


    public SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON()
      {
        flagHasQueryComponents = false;
        flagHasQueryResults = false;
        flagHasEventInstances = false;
        storeQueryComponents = new List< SportsOlympicsEventSchedulesAndResultsQueryComponentJSON  >();
        storeQueryResults = new List< SportsOlympicsEventSchedulesAndResultsQueryResultJSON  >();
        storeEventInstances = new List< SportsOlympicsEventSchedulesAndResultsInstanceJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsOlympicsInformationNuggetKind()
      {
        return "SportsOlympicsEventSchedulesAndResultsInformationNugget";
      }

    public bool  hasQueryComponents()
      {
        return flagHasQueryComponents;
      }

    public int  countOfQueryComponents()
      {
        Debug.Assert(flagHasQueryComponents);
        return storeQueryComponents.Count;
      }

    public SportsOlympicsEventSchedulesAndResultsQueryComponentJSON   elementOfQueryComponents(int element_num)
      {
        Debug.Assert(flagHasQueryComponents);
        return storeQueryComponents[element_num];
      }

    public List< SportsOlympicsEventSchedulesAndResultsQueryComponentJSON  >  getQueryComponents()
      {
        Debug.Assert(flagHasQueryComponents);
        return storeQueryComponents;
      }

    public bool  hasQueryResults()
      {
        return flagHasQueryResults;
      }

    public int  countOfQueryResults()
      {
        Debug.Assert(flagHasQueryResults);
        return storeQueryResults.Count;
      }

    public SportsOlympicsEventSchedulesAndResultsQueryResultJSON   elementOfQueryResults(int element_num)
      {
        Debug.Assert(flagHasQueryResults);
        return storeQueryResults[element_num];
      }

    public List< SportsOlympicsEventSchedulesAndResultsQueryResultJSON  >  getQueryResults()
      {
        Debug.Assert(flagHasQueryResults);
        return storeQueryResults;
      }

    public bool  hasEventInstances()
      {
        return flagHasEventInstances;
      }

    public int  countOfEventInstances()
      {
        Debug.Assert(flagHasEventInstances);
        return storeEventInstances.Count;
      }

    public SportsOlympicsEventSchedulesAndResultsInstanceJSON   elementOfEventInstances(int element_num)
      {
        Debug.Assert(flagHasEventInstances);
        return storeEventInstances[element_num];
      }

    public List< SportsOlympicsEventSchedulesAndResultsInstanceJSON  >  getEventInstances()
      {
        Debug.Assert(flagHasEventInstances);
        return storeEventInstances;
      }


    public virtual int extraSportsOlympicsEventSchedulesAndResultsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsEventSchedulesAndResultsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsOlympicsInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasQueryComponents)
            ++result;
        if (flagHasQueryResults)
            ++result;
        if (flagHasEventInstances)
            ++result;
        result += extraSportsOlympicsEventSchedulesAndResultsInformationNuggetComponentCount();
        return result;
      }
    public override string extraSportsOlympicsInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryComponents)
          {
            if (remainder == 0)
                return "QueryComponents";
            --remainder;
          }
        if (flagHasQueryResults)
          {
            if (remainder == 0)
                return "QueryResults";
            --remainder;
          }
        if (flagHasEventInstances)
          {
            if (remainder == 0)
                return "EventInstances";
            --remainder;
          }
        return extraSportsOlympicsEventSchedulesAndResultsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraSportsOlympicsInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryComponents)
          {
            if (remainder == 0)
                return extraQueryComponentsToJSON();
            --remainder;
          }
        if (flagHasQueryResults)
          {
            if (remainder == 0)
                return extraQueryResultsToJSON();
            --remainder;
          }
        if (flagHasEventInstances)
          {
            if (remainder == 0)
                return extraEventInstancesToJSON();
            --remainder;
          }
        return extraSportsOlympicsEventSchedulesAndResultsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraSportsOlympicsInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "ventInstances", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasEventInstances ? extraEventInstancesToJSON() : null);
                break;
            case 'Q':
                if (String.Compare(field_name, 1, "uery", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'C':
                            if ((String.Compare(field_name, 6, "omponents", 0, 9, false) == 0) && (field_name.Length == 15))
                                return (flagHasQueryComponents ? extraQueryComponentsToJSON() : null);
                            break;
                        case 'R':
                            if ((String.Compare(field_name, 6, "esults", 0, 6, false) == 0) && (field_name.Length == 12))
                                return (flagHasQueryResults ? extraQueryResultsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraSportsOlympicsEventSchedulesAndResultsInformationNuggetLookup(field_name);
      }

    public void initQueryComponents()
      {
        if (flagHasQueryComponents)
          {
            for (int num1 = 0; num1 < storeQueryComponents.Count; ++num1)
              {
              }
          }
        flagHasQueryComponents = true;
        storeQueryComponents.Clear();
      }
    public void appendQueryComponents(SportsOlympicsEventSchedulesAndResultsQueryComponentJSON  to_append)
      {
        if (!flagHasQueryComponents)
          {
            flagHasQueryComponents = true;
            storeQueryComponents.Clear();
          }
        Debug.Assert(flagHasQueryComponents);
        storeQueryComponents.Add(to_append);
      }
    public void unsetQueryComponents()
      {
        if (flagHasQueryComponents)
          {
            for (int num2 = 0; num2 < storeQueryComponents.Count; ++num2)
              {
              }
          }
        flagHasQueryComponents = false;
        storeQueryComponents.Clear();
      }
    public void initQueryResults()
      {
        if (flagHasQueryResults)
          {
            for (int num3 = 0; num3 < storeQueryResults.Count; ++num3)
              {
              }
          }
        flagHasQueryResults = true;
        storeQueryResults.Clear();
      }
    public void appendQueryResults(SportsOlympicsEventSchedulesAndResultsQueryResultJSON  to_append)
      {
        if (!flagHasQueryResults)
          {
            flagHasQueryResults = true;
            storeQueryResults.Clear();
          }
        Debug.Assert(flagHasQueryResults);
        storeQueryResults.Add(to_append);
      }
    public void unsetQueryResults()
      {
        if (flagHasQueryResults)
          {
            for (int num4 = 0; num4 < storeQueryResults.Count; ++num4)
              {
              }
          }
        flagHasQueryResults = false;
        storeQueryResults.Clear();
      }
    public void initEventInstances()
      {
        if (flagHasEventInstances)
          {
            for (int num5 = 0; num5 < storeEventInstances.Count; ++num5)
              {
              }
          }
        flagHasEventInstances = true;
        storeEventInstances.Clear();
      }
    public void appendEventInstances(SportsOlympicsEventSchedulesAndResultsInstanceJSON  to_append)
      {
        if (!flagHasEventInstances)
          {
            flagHasEventInstances = true;
            storeEventInstances.Clear();
          }
        Debug.Assert(flagHasEventInstances);
        storeEventInstances.Add(to_append);
      }
    public void unsetEventInstances()
      {
        if (flagHasEventInstances)
          {
            for (int num6 = 0; num6 < storeEventInstances.Count; ++num6)
              {
              }
          }
        flagHasEventInstances = false;
        storeEventInstances.Clear();
      }

    public virtual void extraSportsOlympicsEventSchedulesAndResultsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsEventSchedulesAndResultsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsEventSchedulesAndResultsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsEventSchedulesAndResultsInformationNuggetAppendPair(key, new_component);
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
    public override void extraSportsOlympicsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "ventInstances", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONEventInstances(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if (String.Compare(key, 1, "uery", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'C':
                            if ((String.Compare(key, 6, "omponents", 0, 9, false) == 0) && (key.Length == 15))
                                {
                                fromJSONQueryComponents(new_component, false);
                                return;
                                }
                            break;
                        case 'R':
                            if ((String.Compare(key, 6, "esults", 0, 6, false) == 0) && (key.Length == 12))
                                {
                                fromJSONQueryResults(new_component, false);
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
        extraSportsOlympicsEventSchedulesAndResultsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraSportsOlympicsInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "ventInstances", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONEventInstances(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if (String.Compare(key, 1, "uery", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'C':
                            if ((String.Compare(key, 6, "omponents", 0, 9, false) == 0) && (key.Length == 15))
                                {
                                fromJSONQueryComponents(new_component, false);
                                return;
                                }
                            break;
                        case 'R':
                            if ((String.Compare(key, 6, "esults", 0, 6, false) == 0) && (key.Length == 12))
                                {
                                fromJSONQueryResults(new_component, false);
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
        extraSportsOlympicsEventSchedulesAndResultsInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryComponents);
        if (flagHasQueryComponents)
          {
            handler.start_pair("QueryComponents");
            Debug.Assert(storeQueryComponents.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeQueryComponents.Count; ++num1)
              {
                if (partial_allowed)
                    storeQueryComponents[num1].write_partial_as_json(handler);
                else
                    storeQueryComponents[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasQueryResults);
        if (flagHasQueryResults)
          {
            handler.start_pair("QueryResults");
            Debug.Assert(storeQueryResults.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeQueryResults.Count; ++num2)
              {
                if (partial_allowed)
                    storeQueryResults[num2].write_partial_as_json(handler);
                else
                    storeQueryResults[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasEventInstances)
          {
            handler.start_pair("EventInstances");
            handler.start_array();
            for (int num3 = 0; num3 < storeEventInstances.Count; ++num3)
              {
                if (partial_allowed)
                    storeEventInstances[num3].write_partial_as_json(handler);
                else
                    storeEventInstances[num3].write_as_json(handler);
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
        if (!(hasQueryComponents()))
          {
            return "When parsing the object for %what%, the \"QueryComponents\" field was missing.";
          }
        if (!(hasQueryResults()))
          {
            return "When parsing the object for %what%, the \"QueryResults\" field was missing.";
          }
        return null;
      }

    public static new SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInformationNugget", ignore_extras);
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
    public static new SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInformationNugget", ignore_extras);
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
    public static new SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsOlympicsInformationNuggetJSON.Generator
      {
        private SportsOlympicsEventSchedulesAndResultsQueryComponentJSON.HoldingArrayGenerator fieldGeneratorQueryComponents;
        private SportsOlympicsEventSchedulesAndResultsQueryResultJSON.HoldingArrayGenerator fieldGeneratorQueryResults;
        private SportsOlympicsEventSchedulesAndResultsInstanceJSON.HoldingArrayGenerator fieldGeneratorEventInstances;
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
            if (!(getSportsOlympicsInformationNuggetJSONKey().Equals("SportsOlympicsEventSchedulesAndResultsInformationNugget")))
                throw new Exception("The key field has a value other than `SportsOlympicsEventSchedulesAndResultsInformationNugget'.");
            SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON result = new SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsEventSchedulesAndResultsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsOlympicsInformationNuggetJSON new_result)
          {
            handle_result((SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON )new_result);
          }
        protected void finish(SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON result)
          {
            if (fieldGeneratorQueryComponents.have_value)
              {
                result.initQueryComponents();
                int count = fieldGeneratorQueryComponents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryComponents(fieldGeneratorQueryComponents.value[num]);
                  }
                fieldGeneratorQueryComponents.value.Clear();
                fieldGeneratorQueryComponents.have_value = false;
              }
            else if ((!(result.hasQueryComponents())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryComponents\" field was missing.");
              }
            if (fieldGeneratorQueryResults.have_value)
              {
                result.initQueryResults();
                int count = fieldGeneratorQueryResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryResults(fieldGeneratorQueryResults.value[num]);
                  }
                fieldGeneratorQueryResults.value.Clear();
                fieldGeneratorQueryResults.have_value = false;
              }
            else if ((!(result.hasQueryResults())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryResults\" field was missing.");
              }
            if (fieldGeneratorEventInstances.have_value)
              {
                result.initEventInstances();
                int count = fieldGeneratorEventInstances.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEventInstances(fieldGeneratorEventInstances.value[num]);
                  }
                fieldGeneratorEventInstances.value.Clear();
                fieldGeneratorEventInstances.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ventInstances", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorEventInstances;
                    break;
                case 'Q':
                    if (String.Compare(field_name, 1, "uery", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 6, "omponents", 0, 9, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorQueryComponents;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 6, "esults", 0, 6, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorQueryResults;
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
            fieldGeneratorQueryComponents = new SportsOlympicsEventSchedulesAndResultsQueryComponentJSON.HoldingArrayGenerator("field \"QueryComponents\" of the SportsOlympicsEventSchedulesAndResultsInformationNugget class", ignore_extras);
            fieldGeneratorQueryResults = new SportsOlympicsEventSchedulesAndResultsQueryResultJSON.HoldingArrayGenerator("field \"QueryResults\" of the SportsOlympicsEventSchedulesAndResultsInformationNugget class", ignore_extras);
            fieldGeneratorEventInstances = new SportsOlympicsEventSchedulesAndResultsInstanceJSON.HoldingArrayGenerator("field \"EventInstances\" of the SportsOlympicsEventSchedulesAndResultsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsEventSchedulesAndResultsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryComponents = new SportsOlympicsEventSchedulesAndResultsQueryComponentJSON.HoldingArrayGenerator("field \"QueryComponents\" of the SportsOlympicsEventSchedulesAndResultsInformationNugget class", false);
            fieldGeneratorQueryResults = new SportsOlympicsEventSchedulesAndResultsQueryResultJSON.HoldingArrayGenerator("field \"QueryResults\" of the SportsOlympicsEventSchedulesAndResultsInformationNugget class", false);
            fieldGeneratorEventInstances = new SportsOlympicsEventSchedulesAndResultsInstanceJSON.HoldingArrayGenerator("field \"EventInstances\" of the SportsOlympicsEventSchedulesAndResultsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsEventSchedulesAndResultsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorQueryComponents.reset();
            fieldGeneratorQueryResults.reset();
            fieldGeneratorEventInstances.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON  result)
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
        public SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON>();
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
    public List<SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON> value;
  };
  };
