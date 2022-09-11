/* file "ShowWeatherForecastHourlyInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ShowWeatherForecastHourlyInformationNuggetJSON : WeatherInformationNuggetJSON
  {
    public class TypeSearchResultsJSON : JSONBase
      {
        private bool flagHasFirstForecastDateAndOrTime;
        private DateAndOrTimeJSON  storeFirstForecastDateAndOrTime;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONFirstForecastDateAndOrTime(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setFirstForecastDateAndOrTime(convert_classy);
          }


        public TypeSearchResultsJSON()
          {
            flagHasFirstForecastDateAndOrTime = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasFirstForecastDateAndOrTime()
          {
            return flagHasFirstForecastDateAndOrTime;
          }

        public DateAndOrTimeJSON   getFirstForecastDateAndOrTime()
          {
            Debug.Assert(flagHasFirstForecastDateAndOrTime);
            return storeFirstForecastDateAndOrTime;
          }


        public virtual int extraTypeSearchResultsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSearchResultsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSearchResultsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSearchResultsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setFirstForecastDateAndOrTime(DateAndOrTimeJSON  new_value)
          {
            if (flagHasFirstForecastDateAndOrTime)
              {
              }
            flagHasFirstForecastDateAndOrTime = true;
            storeFirstForecastDateAndOrTime = new_value;
          }
        public void unsetFirstForecastDateAndOrTime()
          {
            if (flagHasFirstForecastDateAndOrTime)
              {
              }
            flagHasFirstForecastDateAndOrTime = false;
          }

        public virtual void extraTypeSearchResultsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSearchResultsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSearchResultsLookup(key);
            if (old_field == null)
              {
                extraTypeSearchResultsAppendPair(key, new_component);
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
            if (flagHasFirstForecastDateAndOrTime)
              {
                handler.start_pair("FirstForecastDateAndOrTime");
                if (partial_allowed)
                    storeFirstForecastDateAndOrTime.write_partial_as_json(handler);
                else
                    storeFirstForecastDateAndOrTime.write_as_json(handler);
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

        public static TypeSearchResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSearchResultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSearchResults", ignore_extras);
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
        public static TypeSearchResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSearchResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSearchResultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSearchResults", ignore_extras);
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
        public static TypeSearchResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSearchResultsJSON from_text(string text, bool ignore_extras)
          {
            TypeSearchResultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSearchResults", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSearchResultsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSearchResultsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSearchResultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSearchResults", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorFirstForecastDateAndOrTime;
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
                TypeSearchResultsJSON result = new TypeSearchResultsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSearchResultsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSearchResultsJSON result)
              {
                if (fieldGeneratorFirstForecastDateAndOrTime.have_value)
                  {
                    result.setFirstForecastDateAndOrTime(fieldGeneratorFirstForecastDateAndOrTime.value);
                    fieldGeneratorFirstForecastDateAndOrTime.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeSearchResultsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "FirstForecastDateAndOrTime", 0, 26, false) == 0) && (field_name.Length == 26))
                    return fieldGeneratorFirstForecastDateAndOrTime;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorFirstForecastDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"FirstForecastDateAndOrTime\" of the TypeSearchResults class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSearchResults class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorFirstForecastDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"FirstForecastDateAndOrTime\" of the TypeSearchResults class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSearchResults class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorFirstForecastDateAndOrTime.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorFirstForecastDateAndOrTime.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorFirstForecastDateAndOrTime.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeSearchResultsJSON  result)
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
            public TypeSearchResultsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSearchResultsJSON  result)
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
        protected virtual void handle_result(List<TypeSearchResultsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSearchResultsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSearchResultsJSON>();
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
        public List<TypeSearchResultsJSON> value;
      };
      };
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasAlerts;
    private List< AlertJSON  > storeAlerts;
    private bool flagHasRequestedAttribute;
    private WeatherAttributeJSON  storeRequestedAttribute;
    private bool flagHasRequestedAttributeAction;
    private WeatherAttributeActionJSON  storeRequestedAttributeAction;
    private bool flagHasIsSearchQuery;
    private bool storeIsSearchQuery;
    private bool flagHasIsYesNoQuery;
    private bool storeIsYesNoQuery;
    private bool flagHasSearchResults;
    private TypeSearchResultsJSON  storeSearchResults;
    private bool flagHasStartDateAndTime;
    private DateAndOrTimeJSON  storeStartDateAndTime;
    private bool flagHasEndDateAndTime;
    private DateAndOrTimeJSON  storeEndDateAndTime;
    private bool flagHasStartDateTimeSpec;
    private DateTimeSpecJSON  storeStartDateTimeSpec;
    private bool flagHasEndDateTimeSpec;
    private DateTimeSpecJSON  storeEndDateTimeSpec;
    private bool flagHasDailyForecasts;
    private List< DailyForecastJSON  > storeDailyForecasts;
    private bool flagHasHourlyForecasts;
    private List< HourlyForecastJSON  > storeHourlyForecasts;
    private bool flagHasAverageHourlyForecast;
    private HourlyForecastJSON  storeAverageHourlyForecast;
    private bool flagHasPlanner;
    private PlannerJSON  storePlanner;
    private bool flagHasCurrentConditions;
    private CurrentConditionsJSON  storeCurrentConditions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAttributionToJSON()
      {
        JSONValueHandler handler_Attribution = new JSONValueHandler();
        storeAttribution.write_as_json(handler_Attribution);
        return handler_Attribution.result;
      }

    private JSONValue  extraLocationToJSON()
      {
        JSONValueHandler handler_Location = new JSONValueHandler();
        storeLocation.write_as_json(handler_Location);
        return handler_Location.result;
      }

    private JSONValue  extraAlertsToJSON()
      {
        JSONArrayValue generated_array_1_Alerts = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
          {
            JSONValueHandler handler_Alerts = new JSONValueHandler();
            storeAlerts[num1].write_as_json(handler_Alerts);
            generated_array_1_Alerts.appendComponent(handler_Alerts.result);
          }
        return generated_array_1_Alerts;
      }

    private JSONValue  extraRequestedAttributeToJSON()
      {
        JSONValueHandler handler_RequestedAttribute = new JSONValueHandler();
        storeRequestedAttribute.write_as_json(handler_RequestedAttribute);
        return handler_RequestedAttribute.result;
      }

    private JSONValue  extraRequestedAttributeActionToJSON()
      {
        JSONValueHandler handler_RequestedAttributeAction = new JSONValueHandler();
        storeRequestedAttributeAction.write_as_json(handler_RequestedAttributeAction);
        return handler_RequestedAttributeAction.result;
      }

    private JSONValue  extraIsSearchQueryToJSON()
      {
        JSONValue generated_boolean_IsSearchQuery = (storeIsSearchQuery ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsSearchQuery;
      }

    private JSONValue  extraIsYesNoQueryToJSON()
      {
        JSONValue generated_boolean_IsYesNoQuery = (storeIsYesNoQuery ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsYesNoQuery;
      }

    private JSONValue  extraSearchResultsToJSON()
      {
        JSONValueHandler handler_SearchResults = new JSONValueHandler();
        storeSearchResults.write_as_json(handler_SearchResults);
        return handler_SearchResults.result;
      }

    private JSONValue  extraStartDateAndTimeToJSON()
      {
        JSONValueHandler handler_StartDateAndTime = new JSONValueHandler();
        storeStartDateAndTime.write_as_json(handler_StartDateAndTime);
        return handler_StartDateAndTime.result;
      }

    private JSONValue  extraEndDateAndTimeToJSON()
      {
        JSONValueHandler handler_EndDateAndTime = new JSONValueHandler();
        storeEndDateAndTime.write_as_json(handler_EndDateAndTime);
        return handler_EndDateAndTime.result;
      }

    private JSONValue  extraStartDateTimeSpecToJSON()
      {
        JSONValueHandler handler_StartDateTimeSpec = new JSONValueHandler();
        storeStartDateTimeSpec.write_as_json(handler_StartDateTimeSpec);
        return handler_StartDateTimeSpec.result;
      }

    private JSONValue  extraEndDateTimeSpecToJSON()
      {
        JSONValueHandler handler_EndDateTimeSpec = new JSONValueHandler();
        storeEndDateTimeSpec.write_as_json(handler_EndDateTimeSpec);
        return handler_EndDateTimeSpec.result;
      }

    private JSONValue  extraDailyForecastsToJSON()
      {
        JSONArrayValue generated_array_2_DailyForecasts = new JSONArrayValue();
        for (int num2 = 0; num2 < storeDailyForecasts.Count; ++num2)
          {
            JSONValueHandler handler_DailyForecasts = new JSONValueHandler();
            storeDailyForecasts[num2].write_as_json(handler_DailyForecasts);
            generated_array_2_DailyForecasts.appendComponent(handler_DailyForecasts.result);
          }
        return generated_array_2_DailyForecasts;
      }

    private JSONValue  extraHourlyForecastsToJSON()
      {
        JSONArrayValue generated_array_3_HourlyForecasts = new JSONArrayValue();
        for (int num3 = 0; num3 < storeHourlyForecasts.Count; ++num3)
          {
            JSONValueHandler handler_HourlyForecasts = new JSONValueHandler();
            storeHourlyForecasts[num3].write_as_json(handler_HourlyForecasts);
            generated_array_3_HourlyForecasts.appendComponent(handler_HourlyForecasts.result);
          }
        return generated_array_3_HourlyForecasts;
      }

    private JSONValue  extraAverageHourlyForecastToJSON()
      {
        JSONValueHandler handler_AverageHourlyForecast = new JSONValueHandler();
        storeAverageHourlyForecast.write_as_json(handler_AverageHourlyForecast);
        return handler_AverageHourlyForecast.result;
      }

    private JSONValue  extraPlannerToJSON()
      {
        JSONValueHandler handler_Planner = new JSONValueHandler();
        storePlanner.write_as_json(handler_Planner);
        return handler_Planner.result;
      }

    private JSONValue  extraCurrentConditionsToJSON()
      {
        JSONValueHandler handler_CurrentConditions = new JSONValueHandler();
        storeCurrentConditions.write_as_json(handler_CurrentConditions);
        return handler_CurrentConditions.result;
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONAlerts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Alerts of ShowWeatherForecastHourlyInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AlertJSON  > vector_Alerts1 = new List< AlertJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AlertJSON convert_classy = AlertJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Alerts1.Add(convert_classy);
          }
        initAlerts();
        for (int num1 = 0; num1 < vector_Alerts1.Count; ++num1)
            appendAlerts(vector_Alerts1[num1]);
        for (int num1 = 0; num1 < vector_Alerts1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherAttributeJSON convert_classy = WeatherAttributeJSON.from_json(json_value, ignore_extras, true);
        setRequestedAttribute(convert_classy);
      }


    private void  fromJSONRequestedAttributeAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherAttributeActionJSON convert_classy = WeatherAttributeActionJSON.from_json(json_value, ignore_extras, true);
        setRequestedAttributeAction(convert_classy);
      }


    private void  fromJSONIsSearchQuery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsSearchQuery of ShowWeatherForecastHourlyInformationNuggetJSON is not true for false.");
              }
          }
        setIsSearchQuery(the_bool);
      }


    private void  fromJSONIsYesNoQuery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsYesNoQuery of ShowWeatherForecastHourlyInformationNuggetJSON is not true for false.");
              }
          }
        setIsYesNoQuery(the_bool);
      }


    private void  fromJSONSearchResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSearchResultsJSON convert_classy = TypeSearchResultsJSON.from_json(json_value, ignore_extras, true);
        setSearchResults(convert_classy);
      }


    private void  fromJSONStartDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartDateAndTime(convert_classy);
      }


    private void  fromJSONEndDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndDateAndTime(convert_classy);
      }


    private void  fromJSONStartDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setStartDateTimeSpec(convert_classy);
      }


    private void  fromJSONEndDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setEndDateTimeSpec(convert_classy);
      }


    private void  fromJSONDailyForecasts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DailyForecasts of ShowWeatherForecastHourlyInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DailyForecastJSON  > vector_DailyForecasts1 = new List< DailyForecastJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DailyForecastJSON convert_classy = DailyForecastJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DailyForecasts1.Add(convert_classy);
          }
        initDailyForecasts();
        for (int num2 = 0; num2 < vector_DailyForecasts1.Count; ++num2)
            appendDailyForecasts(vector_DailyForecasts1[num2]);
        for (int num1 = 0; num1 < vector_DailyForecasts1.Count; ++num1)
          {
          }
      }


    private void  fromJSONHourlyForecasts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HourlyForecasts of ShowWeatherForecastHourlyInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HourlyForecastJSON  > vector_HourlyForecasts1 = new List< HourlyForecastJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HourlyForecastJSON convert_classy = HourlyForecastJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_HourlyForecasts1.Add(convert_classy);
          }
        initHourlyForecasts();
        for (int num3 = 0; num3 < vector_HourlyForecasts1.Count; ++num3)
            appendHourlyForecasts(vector_HourlyForecasts1[num3]);
        for (int num1 = 0; num1 < vector_HourlyForecasts1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAverageHourlyForecast(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HourlyForecastJSON convert_classy = HourlyForecastJSON.from_json(json_value, ignore_extras, true);
        setAverageHourlyForecast(convert_classy);
      }


    private void  fromJSONPlanner(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PlannerJSON convert_classy = PlannerJSON.from_json(json_value, ignore_extras, true);
        setPlanner(convert_classy);
      }


    private void  fromJSONCurrentConditions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CurrentConditionsJSON convert_classy = CurrentConditionsJSON.from_json(json_value, ignore_extras, true);
        setCurrentConditions(convert_classy);
      }


    public ShowWeatherForecastHourlyInformationNuggetJSON()
      {
        flagHasAttribution = false;
        flagHasLocation = false;
        flagHasAlerts = false;
        flagHasRequestedAttribute = false;
        flagHasRequestedAttributeAction = false;
        flagHasIsSearchQuery = false;
        flagHasIsYesNoQuery = false;
        flagHasSearchResults = false;
        flagHasStartDateAndTime = false;
        flagHasEndDateAndTime = false;
        flagHasStartDateTimeSpec = false;
        flagHasEndDateTimeSpec = false;
        flagHasDailyForecasts = false;
        flagHasHourlyForecasts = false;
        flagHasAverageHourlyForecast = false;
        flagHasPlanner = false;
        flagHasCurrentConditions = false;
        storeAlerts = new List< AlertJSON  >();
        storeDailyForecasts = new List< DailyForecastJSON  >();
        storeHourlyForecasts = new List< HourlyForecastJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getWeatherNuggetKind()
      {
        return "ShowWeatherForecastHourly";
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

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasAlerts()
      {
        return flagHasAlerts;
      }

    public int  countOfAlerts()
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts.Count;
      }

    public AlertJSON   elementOfAlerts(int element_num)
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts[element_num];
      }

    public List< AlertJSON  >  getAlerts()
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts;
      }

    public bool  hasRequestedAttribute()
      {
        return flagHasRequestedAttribute;
      }

    public WeatherAttributeJSON   getRequestedAttribute()
      {
        Debug.Assert(flagHasRequestedAttribute);
        return storeRequestedAttribute;
      }

    public WeatherAttributeJSON.TypeValue  getRequestedAttributeValue()
      {
        return getRequestedAttribute().getValue();
      }

    public string  getRequestedAttributeAsString()
      {
        return getRequestedAttribute().getValueAsString();
      }

    public bool  hasRequestedAttributeAction()
      {
        return flagHasRequestedAttributeAction;
      }

    public WeatherAttributeActionJSON   getRequestedAttributeAction()
      {
        Debug.Assert(flagHasRequestedAttributeAction);
        return storeRequestedAttributeAction;
      }

    public WeatherAttributeActionJSON.TypeValue  getRequestedAttributeActionValue()
      {
        return getRequestedAttributeAction().getValue();
      }

    public string  getRequestedAttributeActionAsString()
      {
        return getRequestedAttributeAction().getValueAsString();
      }

    public bool  hasIsSearchQuery()
      {
        return flagHasIsSearchQuery;
      }

    public bool  getIsSearchQuery()
      {
        Debug.Assert(flagHasIsSearchQuery);
        return storeIsSearchQuery;
      }

    public bool  hasIsYesNoQuery()
      {
        return flagHasIsYesNoQuery;
      }

    public bool  getIsYesNoQuery()
      {
        Debug.Assert(flagHasIsYesNoQuery);
        return storeIsYesNoQuery;
      }

    public bool  hasSearchResults()
      {
        return flagHasSearchResults;
      }

    public TypeSearchResultsJSON   getSearchResults()
      {
        Debug.Assert(flagHasSearchResults);
        return storeSearchResults;
      }

    public bool  hasStartDateAndTime()
      {
        return flagHasStartDateAndTime;
      }

    public DateAndOrTimeJSON   getStartDateAndTime()
      {
        Debug.Assert(flagHasStartDateAndTime);
        return storeStartDateAndTime;
      }

    public bool  hasEndDateAndTime()
      {
        return flagHasEndDateAndTime;
      }

    public DateAndOrTimeJSON   getEndDateAndTime()
      {
        Debug.Assert(flagHasEndDateAndTime);
        return storeEndDateAndTime;
      }

    public bool  hasStartDateTimeSpec()
      {
        return flagHasStartDateTimeSpec;
      }

    public DateTimeSpecJSON   getStartDateTimeSpec()
      {
        Debug.Assert(flagHasStartDateTimeSpec);
        return storeStartDateTimeSpec;
      }

    public bool  hasEndDateTimeSpec()
      {
        return flagHasEndDateTimeSpec;
      }

    public DateTimeSpecJSON   getEndDateTimeSpec()
      {
        Debug.Assert(flagHasEndDateTimeSpec);
        return storeEndDateTimeSpec;
      }

    public bool  hasDailyForecasts()
      {
        return flagHasDailyForecasts;
      }

    public int  countOfDailyForecasts()
      {
        Debug.Assert(flagHasDailyForecasts);
        return storeDailyForecasts.Count;
      }

    public DailyForecastJSON   elementOfDailyForecasts(int element_num)
      {
        Debug.Assert(flagHasDailyForecasts);
        return storeDailyForecasts[element_num];
      }

    public List< DailyForecastJSON  >  getDailyForecasts()
      {
        Debug.Assert(flagHasDailyForecasts);
        return storeDailyForecasts;
      }

    public bool  hasHourlyForecasts()
      {
        return flagHasHourlyForecasts;
      }

    public int  countOfHourlyForecasts()
      {
        Debug.Assert(flagHasHourlyForecasts);
        return storeHourlyForecasts.Count;
      }

    public HourlyForecastJSON   elementOfHourlyForecasts(int element_num)
      {
        Debug.Assert(flagHasHourlyForecasts);
        return storeHourlyForecasts[element_num];
      }

    public List< HourlyForecastJSON  >  getHourlyForecasts()
      {
        Debug.Assert(flagHasHourlyForecasts);
        return storeHourlyForecasts;
      }

    public bool  hasAverageHourlyForecast()
      {
        return flagHasAverageHourlyForecast;
      }

    public HourlyForecastJSON   getAverageHourlyForecast()
      {
        Debug.Assert(flagHasAverageHourlyForecast);
        return storeAverageHourlyForecast;
      }

    public bool  hasPlanner()
      {
        return flagHasPlanner;
      }

    public PlannerJSON   getPlanner()
      {
        Debug.Assert(flagHasPlanner);
        return storePlanner;
      }

    public bool  hasCurrentConditions()
      {
        return flagHasCurrentConditions;
      }

    public CurrentConditionsJSON   getCurrentConditions()
      {
        Debug.Assert(flagHasCurrentConditions);
        return storeCurrentConditions;
      }


    public virtual int extraShowWeatherForecastHourlyInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraShowWeatherForecastHourlyInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraShowWeatherForecastHourlyInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraShowWeatherForecastHourlyInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraWeatherInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasAttribution)
            ++result;
        if (flagHasLocation)
            ++result;
        if (flagHasAlerts)
            ++result;
        if (flagHasRequestedAttribute)
            ++result;
        if (flagHasRequestedAttributeAction)
            ++result;
        if (flagHasIsSearchQuery)
            ++result;
        if (flagHasIsYesNoQuery)
            ++result;
        if (flagHasSearchResults)
            ++result;
        if (flagHasStartDateAndTime)
            ++result;
        if (flagHasEndDateAndTime)
            ++result;
        if (flagHasStartDateTimeSpec)
            ++result;
        if (flagHasEndDateTimeSpec)
            ++result;
        if (flagHasDailyForecasts)
            ++result;
        if (flagHasHourlyForecasts)
            ++result;
        if (flagHasAverageHourlyForecast)
            ++result;
        if (flagHasPlanner)
            ++result;
        if (flagHasCurrentConditions)
            ++result;
        result += extraShowWeatherForecastHourlyInformationNuggetComponentCount();
        return result;
      }
    public override string extraWeatherInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return "Attribution";
            --remainder;
          }
        if (flagHasLocation)
          {
            if (remainder == 0)
                return "Location";
            --remainder;
          }
        if (flagHasAlerts)
          {
            if (remainder == 0)
                return "Alerts";
            --remainder;
          }
        if (flagHasRequestedAttribute)
          {
            if (remainder == 0)
                return "RequestedAttribute";
            --remainder;
          }
        if (flagHasRequestedAttributeAction)
          {
            if (remainder == 0)
                return "RequestedAttributeAction";
            --remainder;
          }
        if (flagHasIsSearchQuery)
          {
            if (remainder == 0)
                return "IsSearchQuery";
            --remainder;
          }
        if (flagHasIsYesNoQuery)
          {
            if (remainder == 0)
                return "IsYesNoQuery";
            --remainder;
          }
        if (flagHasSearchResults)
          {
            if (remainder == 0)
                return "SearchResults";
            --remainder;
          }
        if (flagHasStartDateAndTime)
          {
            if (remainder == 0)
                return "StartDateAndTime";
            --remainder;
          }
        if (flagHasEndDateAndTime)
          {
            if (remainder == 0)
                return "EndDateAndTime";
            --remainder;
          }
        if (flagHasStartDateTimeSpec)
          {
            if (remainder == 0)
                return "StartDateTimeSpec";
            --remainder;
          }
        if (flagHasEndDateTimeSpec)
          {
            if (remainder == 0)
                return "EndDateTimeSpec";
            --remainder;
          }
        if (flagHasDailyForecasts)
          {
            if (remainder == 0)
                return "DailyForecasts";
            --remainder;
          }
        if (flagHasHourlyForecasts)
          {
            if (remainder == 0)
                return "HourlyForecasts";
            --remainder;
          }
        if (flagHasAverageHourlyForecast)
          {
            if (remainder == 0)
                return "AverageHourlyForecast";
            --remainder;
          }
        if (flagHasPlanner)
          {
            if (remainder == 0)
                return "Planner";
            --remainder;
          }
        if (flagHasCurrentConditions)
          {
            if (remainder == 0)
                return "CurrentConditions";
            --remainder;
          }
        return extraShowWeatherForecastHourlyInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraWeatherInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return extraAttributionToJSON();
            --remainder;
          }
        if (flagHasLocation)
          {
            if (remainder == 0)
                return extraLocationToJSON();
            --remainder;
          }
        if (flagHasAlerts)
          {
            if (remainder == 0)
                return extraAlertsToJSON();
            --remainder;
          }
        if (flagHasRequestedAttribute)
          {
            if (remainder == 0)
                return extraRequestedAttributeToJSON();
            --remainder;
          }
        if (flagHasRequestedAttributeAction)
          {
            if (remainder == 0)
                return extraRequestedAttributeActionToJSON();
            --remainder;
          }
        if (flagHasIsSearchQuery)
          {
            if (remainder == 0)
                return extraIsSearchQueryToJSON();
            --remainder;
          }
        if (flagHasIsYesNoQuery)
          {
            if (remainder == 0)
                return extraIsYesNoQueryToJSON();
            --remainder;
          }
        if (flagHasSearchResults)
          {
            if (remainder == 0)
                return extraSearchResultsToJSON();
            --remainder;
          }
        if (flagHasStartDateAndTime)
          {
            if (remainder == 0)
                return extraStartDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasEndDateAndTime)
          {
            if (remainder == 0)
                return extraEndDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasStartDateTimeSpec)
          {
            if (remainder == 0)
                return extraStartDateTimeSpecToJSON();
            --remainder;
          }
        if (flagHasEndDateTimeSpec)
          {
            if (remainder == 0)
                return extraEndDateTimeSpecToJSON();
            --remainder;
          }
        if (flagHasDailyForecasts)
          {
            if (remainder == 0)
                return extraDailyForecastsToJSON();
            --remainder;
          }
        if (flagHasHourlyForecasts)
          {
            if (remainder == 0)
                return extraHourlyForecastsToJSON();
            --remainder;
          }
        if (flagHasAverageHourlyForecast)
          {
            if (remainder == 0)
                return extraAverageHourlyForecastToJSON();
            --remainder;
          }
        if (flagHasPlanner)
          {
            if (remainder == 0)
                return extraPlannerToJSON();
            --remainder;
          }
        if (flagHasCurrentConditions)
          {
            if (remainder == 0)
                return extraCurrentConditionsToJSON();
            --remainder;
          }
        return extraShowWeatherForecastHourlyInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraWeatherInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 'l':
                        if ((String.Compare(field_name, 2, "erts", 0, 4, false) == 0) && (field_name.Length == 6))
                            return (flagHasAlerts ? extraAlertsToJSON() : null);
                        break;
                    case 't':
                        if ((String.Compare(field_name, 2, "tribution", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasAttribution ? extraAttributionToJSON() : null);
                        break;
                    case 'v':
                        if ((String.Compare(field_name, 2, "erageHourlyForecast", 0, 19, false) == 0) && (field_name.Length == 21))
                            return (flagHasAverageHourlyForecast ? extraAverageHourlyForecastToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "urrentConditions", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasCurrentConditions ? extraCurrentConditionsToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "ailyForecasts", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasDailyForecasts ? extraDailyForecastsToJSON() : null);
                break;
            case 'E':
                if (String.Compare(field_name, 1, "ndDate", 0, 6, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 8, "ndTime", 0, 6, false) == 0) && (field_name.Length == 14))
                                return (flagHasEndDateAndTime ? extraEndDateAndTimeToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 8, "imeSpec", 0, 7, false) == 0) && (field_name.Length == 15))
                                return (flagHasEndDateTimeSpec ? extraEndDateTimeSpecToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if ((String.Compare(field_name, 1, "ourlyForecasts", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasHourlyForecasts ? extraHourlyForecastsToJSON() : null);
                break;
            case 'I':
                if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'S':
                            if ((String.Compare(field_name, 3, "earchQuery", 0, 10, false) == 0) && (field_name.Length == 13))
                                return (flagHasIsSearchQuery ? extraIsSearchQueryToJSON() : null);
                            break;
                        case 'Y':
                            if ((String.Compare(field_name, 3, "esNoQuery", 0, 9, false) == 0) && (field_name.Length == 12))
                                return (flagHasIsYesNoQuery ? extraIsYesNoQueryToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasLocation ? extraLocationToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "lanner", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasPlanner ? extraPlannerToJSON() : null);
                break;
            case 'R':
                if (String.Compare(field_name, 1, "equestedAttribute", 0, 17, false) == 0)
                  {
                    if (field_name.Length == 18)
                      {
                        return (flagHasRequestedAttribute ? extraRequestedAttributeToJSON() : null);
                      }
                    switch (field_name[18])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 19, "ction", 0, 5, false) == 0) && (field_name.Length == 24))
                                return (flagHasRequestedAttributeAction ? extraRequestedAttributeActionToJSON() : null);
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
                        if ((String.Compare(field_name, 2, "archResults", 0, 11, false) == 0) && (field_name.Length == 13))
                            return (flagHasSearchResults ? extraSearchResultsToJSON() : null);
                        break;
                    case 't':
                        if (String.Compare(field_name, 2, "artDate", 0, 7, false) == 0)
                          {
                            switch (field_name[9])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 10, "ndTime", 0, 6, false) == 0) && (field_name.Length == 16))
                                        return (flagHasStartDateAndTime ? extraStartDateAndTimeToJSON() : null);
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 10, "imeSpec", 0, 7, false) == 0) && (field_name.Length == 17))
                                        return (flagHasStartDateTimeSpec ? extraStartDateTimeSpecToJSON() : null);
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
        return extraShowWeatherForecastHourlyInformationNuggetLookup(field_name);
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
    public void setLocation(MapLocationJSON  new_value)
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = false;
      }
    public void initAlerts()
      {
        if (flagHasAlerts)
          {
            for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
              {
              }
          }
        flagHasAlerts = true;
        storeAlerts.Clear();
      }
    public void appendAlerts(AlertJSON  to_append)
      {
        if (!flagHasAlerts)
          {
            flagHasAlerts = true;
            storeAlerts.Clear();
          }
        Debug.Assert(flagHasAlerts);
        storeAlerts.Add(to_append);
      }
    public void unsetAlerts()
      {
        if (flagHasAlerts)
          {
            for (int num2 = 0; num2 < storeAlerts.Count; ++num2)
              {
              }
          }
        flagHasAlerts = false;
        storeAlerts.Clear();
      }
    public void setRequestedAttribute(WeatherAttributeJSON  new_value)
      {
        if (flagHasRequestedAttribute)
          {
          }
        flagHasRequestedAttribute = true;
        storeRequestedAttribute = new_value;
      }
    public void setRequestedAttribute(WeatherAttributeJSON.TypeValue new_value)
      {
        setRequestedAttribute(new WeatherAttributeJSON(new_value));
      }
    public void setRequestedAttribute(string chars)
      {
        WeatherAttributeJSON.TypeValueKnownValues known = WeatherAttributeJSON.stringToValue(chars);
        WeatherAttributeJSON.TypeValue new_value = new WeatherAttributeJSON.TypeValue();
        if (known == WeatherAttributeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRequestedAttribute(new_value);
      }
    public void unsetRequestedAttribute()
      {
        if (flagHasRequestedAttribute)
          {
          }
        flagHasRequestedAttribute = false;
      }
    public void setRequestedAttributeAction(WeatherAttributeActionJSON  new_value)
      {
        if (flagHasRequestedAttributeAction)
          {
          }
        flagHasRequestedAttributeAction = true;
        storeRequestedAttributeAction = new_value;
      }
    public void setRequestedAttributeAction(WeatherAttributeActionJSON.TypeValue new_value)
      {
        setRequestedAttributeAction(new WeatherAttributeActionJSON(new_value));
      }
    public void setRequestedAttributeAction(string chars)
      {
        WeatherAttributeActionJSON.TypeValueKnownValues known = WeatherAttributeActionJSON.stringToValue(chars);
        WeatherAttributeActionJSON.TypeValue new_value = new WeatherAttributeActionJSON.TypeValue();
        if (known == WeatherAttributeActionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRequestedAttributeAction(new_value);
      }
    public void unsetRequestedAttributeAction()
      {
        if (flagHasRequestedAttributeAction)
          {
          }
        flagHasRequestedAttributeAction = false;
      }
    public void setIsSearchQuery(bool new_value)
      {
        flagHasIsSearchQuery = true;
        storeIsSearchQuery = new_value;
      }
    public void unsetIsSearchQuery()
      {
        flagHasIsSearchQuery = false;
      }
    public void setIsYesNoQuery(bool new_value)
      {
        flagHasIsYesNoQuery = true;
        storeIsYesNoQuery = new_value;
      }
    public void unsetIsYesNoQuery()
      {
        flagHasIsYesNoQuery = false;
      }
    public void setSearchResults(TypeSearchResultsJSON  new_value)
      {
        if (flagHasSearchResults)
          {
          }
        flagHasSearchResults = true;
        storeSearchResults = new_value;
      }
    public void unsetSearchResults()
      {
        if (flagHasSearchResults)
          {
          }
        flagHasSearchResults = false;
      }
    public void setStartDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartDateAndTime)
          {
          }
        flagHasStartDateAndTime = true;
        storeStartDateAndTime = new_value;
      }
    public void unsetStartDateAndTime()
      {
        if (flagHasStartDateAndTime)
          {
          }
        flagHasStartDateAndTime = false;
      }
    public void setEndDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndDateAndTime)
          {
          }
        flagHasEndDateAndTime = true;
        storeEndDateAndTime = new_value;
      }
    public void unsetEndDateAndTime()
      {
        if (flagHasEndDateAndTime)
          {
          }
        flagHasEndDateAndTime = false;
      }
    public void setStartDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasStartDateTimeSpec)
          {
          }
        flagHasStartDateTimeSpec = true;
        storeStartDateTimeSpec = new_value;
      }
    public void unsetStartDateTimeSpec()
      {
        if (flagHasStartDateTimeSpec)
          {
          }
        flagHasStartDateTimeSpec = false;
      }
    public void setEndDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasEndDateTimeSpec)
          {
          }
        flagHasEndDateTimeSpec = true;
        storeEndDateTimeSpec = new_value;
      }
    public void unsetEndDateTimeSpec()
      {
        if (flagHasEndDateTimeSpec)
          {
          }
        flagHasEndDateTimeSpec = false;
      }
    public void initDailyForecasts()
      {
        if (flagHasDailyForecasts)
          {
            for (int num3 = 0; num3 < storeDailyForecasts.Count; ++num3)
              {
              }
          }
        flagHasDailyForecasts = true;
        storeDailyForecasts.Clear();
      }
    public void appendDailyForecasts(DailyForecastJSON  to_append)
      {
        if (!flagHasDailyForecasts)
          {
            flagHasDailyForecasts = true;
            storeDailyForecasts.Clear();
          }
        Debug.Assert(flagHasDailyForecasts);
        storeDailyForecasts.Add(to_append);
      }
    public void unsetDailyForecasts()
      {
        if (flagHasDailyForecasts)
          {
            for (int num4 = 0; num4 < storeDailyForecasts.Count; ++num4)
              {
              }
          }
        flagHasDailyForecasts = false;
        storeDailyForecasts.Clear();
      }
    public void initHourlyForecasts()
      {
        if (flagHasHourlyForecasts)
          {
            for (int num5 = 0; num5 < storeHourlyForecasts.Count; ++num5)
              {
              }
          }
        flagHasHourlyForecasts = true;
        storeHourlyForecasts.Clear();
      }
    public void appendHourlyForecasts(HourlyForecastJSON  to_append)
      {
        if (!flagHasHourlyForecasts)
          {
            flagHasHourlyForecasts = true;
            storeHourlyForecasts.Clear();
          }
        Debug.Assert(flagHasHourlyForecasts);
        storeHourlyForecasts.Add(to_append);
      }
    public void unsetHourlyForecasts()
      {
        if (flagHasHourlyForecasts)
          {
            for (int num6 = 0; num6 < storeHourlyForecasts.Count; ++num6)
              {
              }
          }
        flagHasHourlyForecasts = false;
        storeHourlyForecasts.Clear();
      }
    public void setAverageHourlyForecast(HourlyForecastJSON  new_value)
      {
        if (flagHasAverageHourlyForecast)
          {
          }
        flagHasAverageHourlyForecast = true;
        storeAverageHourlyForecast = new_value;
      }
    public void unsetAverageHourlyForecast()
      {
        if (flagHasAverageHourlyForecast)
          {
          }
        flagHasAverageHourlyForecast = false;
      }
    public void setPlanner(PlannerJSON  new_value)
      {
        if (flagHasPlanner)
          {
          }
        flagHasPlanner = true;
        storePlanner = new_value;
      }
    public void unsetPlanner()
      {
        if (flagHasPlanner)
          {
          }
        flagHasPlanner = false;
      }
    public void setCurrentConditions(CurrentConditionsJSON  new_value)
      {
        if (flagHasCurrentConditions)
          {
          }
        flagHasCurrentConditions = true;
        storeCurrentConditions = new_value;
      }
    public void unsetCurrentConditions()
      {
        if (flagHasCurrentConditions)
          {
          }
        flagHasCurrentConditions = false;
      }

    public virtual void extraShowWeatherForecastHourlyInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraShowWeatherForecastHourlyInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraShowWeatherForecastHourlyInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraShowWeatherForecastHourlyInformationNuggetAppendPair(key, new_component);
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
    public override void extraWeatherInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if ((String.Compare(key, 2, "erts", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONAlerts(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "tribution", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONAttribution(new_component, false);
                            return;
                            }
                        break;
                    case 'v':
                        if ((String.Compare(key, 2, "erageHourlyForecast", 0, 19, false) == 0) && (key.Length == 21))
                            {
                            fromJSONAverageHourlyForecast(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(key, 1, "urrentConditions", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONCurrentConditions(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "ailyForecasts", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONDailyForecasts(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if (String.Compare(key, 1, "ndDate", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'A':
                            if ((String.Compare(key, 8, "ndTime", 0, 6, false) == 0) && (key.Length == 14))
                                {
                                fromJSONEndDateAndTime(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 8, "imeSpec", 0, 7, false) == 0) && (key.Length == 15))
                                {
                                fromJSONEndDateTimeSpec(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if ((String.Compare(key, 1, "ourlyForecasts", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONHourlyForecasts(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "s", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'S':
                            if ((String.Compare(key, 3, "earchQuery", 0, 10, false) == 0) && (key.Length == 13))
                                {
                                fromJSONIsSearchQuery(new_component, false);
                                return;
                                }
                            break;
                        case 'Y':
                            if ((String.Compare(key, 3, "esNoQuery", 0, 9, false) == 0) && (key.Length == 12))
                                {
                                fromJSONIsYesNoQuery(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "lanner", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONPlanner(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "equestedAttribute", 0, 17, false) == 0)
                  {
                    if (key.Length == 18)
                      {
                        {
                        fromJSONRequestedAttribute(new_component, false);
                        return;
                        }
                      }
                    switch (key[18])
                      {
                        case 'A':
                            if ((String.Compare(key, 19, "ction", 0, 5, false) == 0) && (key.Length == 24))
                                {
                                fromJSONRequestedAttributeAction(new_component, false);
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
                        if ((String.Compare(key, 2, "archResults", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONSearchResults(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if (String.Compare(key, 2, "artDate", 0, 7, false) == 0)
                          {
                            switch (key[9])
                              {
                                case 'A':
                                    if ((String.Compare(key, 10, "ndTime", 0, 6, false) == 0) && (key.Length == 16))
                                        {
                                        fromJSONStartDateAndTime(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 10, "imeSpec", 0, 7, false) == 0) && (key.Length == 17))
                                        {
                                        fromJSONStartDateTimeSpec(new_component, false);
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
            default:
                break;
          }
        extraShowWeatherForecastHourlyInformationNuggetAppendPair(key, new_component);
      }
    public override void extraWeatherInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if ((String.Compare(key, 2, "erts", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONAlerts(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "tribution", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONAttribution(new_component, false);
                            return;
                            }
                        break;
                    case 'v':
                        if ((String.Compare(key, 2, "erageHourlyForecast", 0, 19, false) == 0) && (key.Length == 21))
                            {
                            fromJSONAverageHourlyForecast(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(key, 1, "urrentConditions", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONCurrentConditions(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "ailyForecasts", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONDailyForecasts(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if (String.Compare(key, 1, "ndDate", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'A':
                            if ((String.Compare(key, 8, "ndTime", 0, 6, false) == 0) && (key.Length == 14))
                                {
                                fromJSONEndDateAndTime(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 8, "imeSpec", 0, 7, false) == 0) && (key.Length == 15))
                                {
                                fromJSONEndDateTimeSpec(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if ((String.Compare(key, 1, "ourlyForecasts", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONHourlyForecasts(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "s", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'S':
                            if ((String.Compare(key, 3, "earchQuery", 0, 10, false) == 0) && (key.Length == 13))
                                {
                                fromJSONIsSearchQuery(new_component, false);
                                return;
                                }
                            break;
                        case 'Y':
                            if ((String.Compare(key, 3, "esNoQuery", 0, 9, false) == 0) && (key.Length == 12))
                                {
                                fromJSONIsYesNoQuery(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "lanner", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONPlanner(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "equestedAttribute", 0, 17, false) == 0)
                  {
                    if (key.Length == 18)
                      {
                        {
                        fromJSONRequestedAttribute(new_component, false);
                        return;
                        }
                      }
                    switch (key[18])
                      {
                        case 'A':
                            if ((String.Compare(key, 19, "ction", 0, 5, false) == 0) && (key.Length == 24))
                                {
                                fromJSONRequestedAttributeAction(new_component, false);
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
                        if ((String.Compare(key, 2, "archResults", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONSearchResults(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if (String.Compare(key, 2, "artDate", 0, 7, false) == 0)
                          {
                            switch (key[9])
                              {
                                case 'A':
                                    if ((String.Compare(key, 10, "ndTime", 0, 6, false) == 0) && (key.Length == 16))
                                        {
                                        fromJSONStartDateAndTime(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 10, "imeSpec", 0, 7, false) == 0) && (key.Length == 17))
                                        {
                                        fromJSONStartDateTimeSpec(new_component, false);
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
            default:
                break;
          }
        extraShowWeatherForecastHourlyInformationNuggetSetField(key, new_component);
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
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasLocation);
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasAlerts);
        if (flagHasAlerts)
          {
            handler.start_pair("Alerts");
            handler.start_array();
            for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
              {
                if (partial_allowed)
                    storeAlerts[num1].write_partial_as_json(handler);
                else
                    storeAlerts[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasRequestedAttribute);
        if (flagHasRequestedAttribute)
          {
            handler.start_pair("RequestedAttribute");
            if (partial_allowed)
                storeRequestedAttribute.write_partial_as_json(handler);
            else
                storeRequestedAttribute.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRequestedAttributeAction);
        if (flagHasRequestedAttributeAction)
          {
            handler.start_pair("RequestedAttributeAction");
            if (partial_allowed)
                storeRequestedAttributeAction.write_partial_as_json(handler);
            else
                storeRequestedAttributeAction.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasIsSearchQuery);
        if (flagHasIsSearchQuery)
          {
            handler.start_pair("IsSearchQuery");
            handler.boolean_value(storeIsSearchQuery);
          }
        Debug.Assert(partial_allowed || flagHasIsYesNoQuery);
        if (flagHasIsYesNoQuery)
          {
            handler.start_pair("IsYesNoQuery");
            handler.boolean_value(storeIsYesNoQuery);
          }
        if (flagHasSearchResults)
          {
            handler.start_pair("SearchResults");
            if (partial_allowed)
                storeSearchResults.write_partial_as_json(handler);
            else
                storeSearchResults.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStartDateAndTime);
        if (flagHasStartDateAndTime)
          {
            handler.start_pair("StartDateAndTime");
            if (partial_allowed)
                storeStartDateAndTime.write_partial_as_json(handler);
            else
                storeStartDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndDateAndTime);
        if (flagHasEndDateAndTime)
          {
            handler.start_pair("EndDateAndTime");
            if (partial_allowed)
                storeEndDateAndTime.write_partial_as_json(handler);
            else
                storeEndDateAndTime.write_as_json(handler);
          }
        if (flagHasStartDateTimeSpec)
          {
            handler.start_pair("StartDateTimeSpec");
            if (partial_allowed)
                storeStartDateTimeSpec.write_partial_as_json(handler);
            else
                storeStartDateTimeSpec.write_as_json(handler);
          }
        if (flagHasEndDateTimeSpec)
          {
            handler.start_pair("EndDateTimeSpec");
            if (partial_allowed)
                storeEndDateTimeSpec.write_partial_as_json(handler);
            else
                storeEndDateTimeSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDailyForecasts);
        if (flagHasDailyForecasts)
          {
            handler.start_pair("DailyForecasts");
            handler.start_array();
            for (int num2 = 0; num2 < storeDailyForecasts.Count; ++num2)
              {
                if (partial_allowed)
                    storeDailyForecasts[num2].write_partial_as_json(handler);
                else
                    storeDailyForecasts[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasHourlyForecasts);
        if (flagHasHourlyForecasts)
          {
            handler.start_pair("HourlyForecasts");
            handler.start_array();
            for (int num3 = 0; num3 < storeHourlyForecasts.Count; ++num3)
              {
                if (partial_allowed)
                    storeHourlyForecasts[num3].write_partial_as_json(handler);
                else
                    storeHourlyForecasts[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAverageHourlyForecast)
          {
            handler.start_pair("AverageHourlyForecast");
            if (partial_allowed)
                storeAverageHourlyForecast.write_partial_as_json(handler);
            else
                storeAverageHourlyForecast.write_as_json(handler);
          }
        if (flagHasPlanner)
          {
            handler.start_pair("Planner");
            if (partial_allowed)
                storePlanner.write_partial_as_json(handler);
            else
                storePlanner.write_as_json(handler);
          }
        if (flagHasCurrentConditions)
          {
            handler.start_pair("CurrentConditions");
            if (partial_allowed)
                storeCurrentConditions.write_partial_as_json(handler);
            else
                storeCurrentConditions.write_as_json(handler);
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
        if (!(hasLocation()))
          {
            return "When parsing the object for %what%, the \"Location\" field was missing.";
          }
        if (!(hasAlerts()))
          {
            return "When parsing the object for %what%, the \"Alerts\" field was missing.";
          }
        if (!(hasRequestedAttribute()))
          {
            return "When parsing the object for %what%, the \"RequestedAttribute\" field was missing.";
          }
        if (!(hasRequestedAttributeAction()))
          {
            return "When parsing the object for %what%, the \"RequestedAttributeAction\" field was missing.";
          }
        if (!(hasIsSearchQuery()))
          {
            return "When parsing the object for %what%, the \"IsSearchQuery\" field was missing.";
          }
        if (!(hasIsYesNoQuery()))
          {
            return "When parsing the object for %what%, the \"IsYesNoQuery\" field was missing.";
          }
        if (!(hasStartDateAndTime()))
          {
            return "When parsing the object for %what%, the \"StartDateAndTime\" field was missing.";
          }
        if (!(hasEndDateAndTime()))
          {
            return "When parsing the object for %what%, the \"EndDateAndTime\" field was missing.";
          }
        if (!(hasDailyForecasts()))
          {
            return "When parsing the object for %what%, the \"DailyForecasts\" field was missing.";
          }
        if (!(hasHourlyForecasts()))
          {
            return "When parsing the object for %what%, the \"HourlyForecasts\" field was missing.";
          }
        return null;
      }

    public static new ShowWeatherForecastHourlyInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWeatherForecastHourlyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherForecastHourlyInformationNugget", ignore_extras);
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
    public static new ShowWeatherForecastHourlyInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWeatherForecastHourlyInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWeatherForecastHourlyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherForecastHourlyInformationNugget", ignore_extras);
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
    public static new ShowWeatherForecastHourlyInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWeatherForecastHourlyInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ShowWeatherForecastHourlyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherForecastHourlyInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ShowWeatherForecastHourlyInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ShowWeatherForecastHourlyInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ShowWeatherForecastHourlyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherForecastHourlyInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : WeatherInformationNuggetJSON.Generator
      {
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
        private AlertJSON.HoldingArrayGenerator fieldGeneratorAlerts;
        private WeatherAttributeJSON.HoldingGenerator fieldGeneratorRequestedAttribute;
        private WeatherAttributeActionJSON.HoldingGenerator fieldGeneratorRequestedAttributeAction;
        private JSONHoldingBooleanGenerator fieldGeneratorIsSearchQuery;
        private JSONHoldingBooleanGenerator fieldGeneratorIsYesNoQuery;
        private TypeSearchResultsJSON.HoldingGenerator fieldGeneratorSearchResults;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDateAndTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndDateAndTime;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorStartDateTimeSpec;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorEndDateTimeSpec;
        private DailyForecastJSON.HoldingArrayGenerator fieldGeneratorDailyForecasts;
        private HourlyForecastJSON.HoldingArrayGenerator fieldGeneratorHourlyForecasts;
        private HourlyForecastJSON.HoldingGenerator fieldGeneratorAverageHourlyForecast;
        private PlannerJSON.HoldingGenerator fieldGeneratorPlanner;
        private CurrentConditionsJSON.HoldingGenerator fieldGeneratorCurrentConditions;
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
            if (!(getWeatherInformationNuggetJSONKey().Equals("ShowWeatherForecastHourly")))
                throw new Exception("The key field has a value other than `ShowWeatherForecastHourly'.");
            ShowWeatherForecastHourlyInformationNuggetJSON result = new ShowWeatherForecastHourlyInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraShowWeatherForecastHourlyInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(WeatherInformationNuggetJSON new_result)
          {
            handle_result((ShowWeatherForecastHourlyInformationNuggetJSON )new_result);
          }
        protected void finish(ShowWeatherForecastHourlyInformationNuggetJSON result)
          {
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            else if ((!(result.hasLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Location\" field was missing.");
              }
            if (fieldGeneratorAlerts.have_value)
              {
                result.initAlerts();
                int count = fieldGeneratorAlerts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlerts(fieldGeneratorAlerts.value[num]);
                  }
                fieldGeneratorAlerts.value.Clear();
                fieldGeneratorAlerts.have_value = false;
              }
            else if ((!(result.hasAlerts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Alerts\" field was missing.");
              }
            if (fieldGeneratorRequestedAttribute.have_value)
              {
                result.setRequestedAttribute(fieldGeneratorRequestedAttribute.value);
                fieldGeneratorRequestedAttribute.have_value = false;
              }
            else if ((!(result.hasRequestedAttribute())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedAttribute\" field was missing.");
              }
            if (fieldGeneratorRequestedAttributeAction.have_value)
              {
                result.setRequestedAttributeAction(fieldGeneratorRequestedAttributeAction.value);
                fieldGeneratorRequestedAttributeAction.have_value = false;
              }
            else if ((!(result.hasRequestedAttributeAction())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedAttributeAction\" field was missing.");
              }
            if (fieldGeneratorIsSearchQuery.have_value)
              {
                result.setIsSearchQuery(fieldGeneratorIsSearchQuery.value);
                fieldGeneratorIsSearchQuery.have_value = false;
              }
            else if ((!(result.hasIsSearchQuery())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsSearchQuery\" field was missing.");
              }
            if (fieldGeneratorIsYesNoQuery.have_value)
              {
                result.setIsYesNoQuery(fieldGeneratorIsYesNoQuery.value);
                fieldGeneratorIsYesNoQuery.have_value = false;
              }
            else if ((!(result.hasIsYesNoQuery())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsYesNoQuery\" field was missing.");
              }
            if (fieldGeneratorSearchResults.have_value)
              {
                result.setSearchResults(fieldGeneratorSearchResults.value);
                fieldGeneratorSearchResults.have_value = false;
              }
            if (fieldGeneratorStartDateAndTime.have_value)
              {
                result.setStartDateAndTime(fieldGeneratorStartDateAndTime.value);
                fieldGeneratorStartDateAndTime.have_value = false;
              }
            else if ((!(result.hasStartDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDateAndTime\" field was missing.");
              }
            if (fieldGeneratorEndDateAndTime.have_value)
              {
                result.setEndDateAndTime(fieldGeneratorEndDateAndTime.value);
                fieldGeneratorEndDateAndTime.have_value = false;
              }
            else if ((!(result.hasEndDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDateAndTime\" field was missing.");
              }
            if (fieldGeneratorStartDateTimeSpec.have_value)
              {
                result.setStartDateTimeSpec(fieldGeneratorStartDateTimeSpec.value);
                fieldGeneratorStartDateTimeSpec.have_value = false;
              }
            if (fieldGeneratorEndDateTimeSpec.have_value)
              {
                result.setEndDateTimeSpec(fieldGeneratorEndDateTimeSpec.value);
                fieldGeneratorEndDateTimeSpec.have_value = false;
              }
            if (fieldGeneratorDailyForecasts.have_value)
              {
                result.initDailyForecasts();
                int count = fieldGeneratorDailyForecasts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDailyForecasts(fieldGeneratorDailyForecasts.value[num]);
                  }
                fieldGeneratorDailyForecasts.value.Clear();
                fieldGeneratorDailyForecasts.have_value = false;
              }
            else if ((!(result.hasDailyForecasts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DailyForecasts\" field was missing.");
              }
            if (fieldGeneratorHourlyForecasts.have_value)
              {
                result.initHourlyForecasts();
                int count = fieldGeneratorHourlyForecasts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHourlyForecasts(fieldGeneratorHourlyForecasts.value[num]);
                  }
                fieldGeneratorHourlyForecasts.value.Clear();
                fieldGeneratorHourlyForecasts.have_value = false;
              }
            else if ((!(result.hasHourlyForecasts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HourlyForecasts\" field was missing.");
              }
            if (fieldGeneratorAverageHourlyForecast.have_value)
              {
                result.setAverageHourlyForecast(fieldGeneratorAverageHourlyForecast.value);
                fieldGeneratorAverageHourlyForecast.have_value = false;
              }
            if (fieldGeneratorPlanner.have_value)
              {
                result.setPlanner(fieldGeneratorPlanner.value);
                fieldGeneratorPlanner.have_value = false;
              }
            if (fieldGeneratorCurrentConditions.have_value)
              {
                result.setCurrentConditions(fieldGeneratorCurrentConditions.value);
                fieldGeneratorCurrentConditions.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ShowWeatherForecastHourlyInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "erts", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorAlerts;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "tribution", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAttribution;
                            break;
                        case 'v':
                            if ((String.Compare(field_name, 2, "erageHourlyForecast", 0, 19, false) == 0) && (field_name.Length == 21))
                                return fieldGeneratorAverageHourlyForecast;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "urrentConditions", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorCurrentConditions;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ailyForecasts", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorDailyForecasts;
                    break;
                case 'E':
                    if (String.Compare(field_name, 1, "ndDate", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 8, "ndTime", 0, 6, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorEndDateAndTime;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "imeSpec", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorEndDateTimeSpec;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "ourlyForecasts", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorHourlyForecasts;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 3, "earchQuery", 0, 10, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorIsSearchQuery;
                                break;
                            case 'Y':
                                if ((String.Compare(field_name, 3, "esNoQuery", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorIsYesNoQuery;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "lanner", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorPlanner;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "equestedAttribute", 0, 17, false) == 0)
                      {
                        if (field_name.Length == 18)
                          {
                            return fieldGeneratorRequestedAttribute;
                          }
                        switch (field_name[18])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 19, "ction", 0, 5, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorRequestedAttributeAction;
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
                            if ((String.Compare(field_name, 2, "archResults", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorSearchResults;
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "artDate", 0, 7, false) == 0)
                              {
                                switch (field_name[9])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 10, "ndTime", 0, 6, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorStartDateAndTime;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 10, "imeSpec", 0, 7, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorStartDateTimeSpec;
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
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorAlerts = new AlertJSON.HoldingArrayGenerator("field \"Alerts\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorRequestedAttribute = new WeatherAttributeJSON.HoldingGenerator("field \"RequestedAttribute\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorRequestedAttributeAction = new WeatherAttributeActionJSON.HoldingGenerator("field \"RequestedAttributeAction\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorIsSearchQuery = new JSONHoldingBooleanGenerator("field \"IsSearchQuery\" of the ShowWeatherForecastHourlyInformationNugget class");
            fieldGeneratorIsYesNoQuery = new JSONHoldingBooleanGenerator("field \"IsYesNoQuery\" of the ShowWeatherForecastHourlyInformationNugget class");
            fieldGeneratorSearchResults = new TypeSearchResultsJSON.HoldingGenerator("field \"SearchResults\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorStartDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"StartDateTimeSpec\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorEndDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"EndDateTimeSpec\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorDailyForecasts = new DailyForecastJSON.HoldingArrayGenerator("field \"DailyForecasts\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorHourlyForecasts = new HourlyForecastJSON.HoldingArrayGenerator("field \"HourlyForecasts\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorAverageHourlyForecast = new HourlyForecastJSON.HoldingGenerator("field \"AverageHourlyForecast\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorPlanner = new PlannerJSON.HoldingGenerator("field \"Planner\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            fieldGeneratorCurrentConditions = new CurrentConditionsJSON.HoldingGenerator("field \"CurrentConditions\" of the ShowWeatherForecastHourlyInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ShowWeatherForecastHourlyInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorAlerts = new AlertJSON.HoldingArrayGenerator("field \"Alerts\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorRequestedAttribute = new WeatherAttributeJSON.HoldingGenerator("field \"RequestedAttribute\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorRequestedAttributeAction = new WeatherAttributeActionJSON.HoldingGenerator("field \"RequestedAttributeAction\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorIsSearchQuery = new JSONHoldingBooleanGenerator("field \"IsSearchQuery\" of the ShowWeatherForecastHourlyInformationNugget class");
            fieldGeneratorIsYesNoQuery = new JSONHoldingBooleanGenerator("field \"IsYesNoQuery\" of the ShowWeatherForecastHourlyInformationNugget class");
            fieldGeneratorSearchResults = new TypeSearchResultsJSON.HoldingGenerator("field \"SearchResults\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorStartDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"StartDateTimeSpec\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorEndDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"EndDateTimeSpec\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorDailyForecasts = new DailyForecastJSON.HoldingArrayGenerator("field \"DailyForecasts\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorHourlyForecasts = new HourlyForecastJSON.HoldingArrayGenerator("field \"HourlyForecasts\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorAverageHourlyForecast = new HourlyForecastJSON.HoldingGenerator("field \"AverageHourlyForecast\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorPlanner = new PlannerJSON.HoldingGenerator("field \"Planner\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            fieldGeneratorCurrentConditions = new CurrentConditionsJSON.HoldingGenerator("field \"CurrentConditions\" of the ShowWeatherForecastHourlyInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ShowWeatherForecastHourlyInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAttribution.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorAlerts.reset();
            fieldGeneratorRequestedAttribute.reset();
            fieldGeneratorRequestedAttributeAction.reset();
            fieldGeneratorIsSearchQuery.reset();
            fieldGeneratorIsYesNoQuery.reset();
            fieldGeneratorSearchResults.reset();
            fieldGeneratorStartDateAndTime.reset();
            fieldGeneratorEndDateAndTime.reset();
            fieldGeneratorStartDateTimeSpec.reset();
            fieldGeneratorEndDateTimeSpec.reset();
            fieldGeneratorDailyForecasts.reset();
            fieldGeneratorHourlyForecasts.reset();
            fieldGeneratorAverageHourlyForecast.reset();
            fieldGeneratorPlanner.reset();
            fieldGeneratorCurrentConditions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ShowWeatherForecastHourlyInformationNuggetJSON  result)
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
        public ShowWeatherForecastHourlyInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ShowWeatherForecastHourlyInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ShowWeatherForecastHourlyInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ShowWeatherForecastHourlyInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ShowWeatherForecastHourlyInformationNuggetJSON>();
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
    public List<ShowWeatherForecastHourlyInformationNuggetJSON> value;
  };
  };
