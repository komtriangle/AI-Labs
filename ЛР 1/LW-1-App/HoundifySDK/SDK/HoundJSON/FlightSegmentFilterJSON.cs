/* file "FlightSegmentFilterJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightSegmentFilterJSON : JSONBase
  {
    private bool flagHasFindNextAvailableFlight;
    private bool storeFindNextAvailableFlight;
    private bool flagHasDepartureLocationFilter;
    private FlightTravelLocationFilterJSON  storeDepartureLocationFilter;
    private bool flagHasDestinationLocationFilter;
    private FlightTravelLocationFilterJSON  storeDestinationLocationFilter;
    private bool flagHasDepartureDateTimeRange;
    private DateTimeRangeSpecJSON  storeDepartureDateTimeRange;
    private bool flagHasDepartureTimeSpan;
    private string storeDepartureTimeSpan;
    private bool flagHasSearchCriteria;
    private List< FlightSegmentSearchCriterionJSON  > storeSearchCriteria;
    private bool flagHasUpdatedSearchCriteria;
    private List< FlightSegmentSearchCriterionJSON  > storeUpdatedSearchCriteria;
    private bool flagHasTypeOfLastDateTimeRangeFilter;
    private DepartureOrArrivalJSON  storeTypeOfLastDateTimeRangeFilter;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFindNextAvailableFlight(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field FindNextAvailableFlight of FlightSegmentFilterJSON is not true for false.");
              }
          }
        setFindNextAvailableFlight(the_bool);
      }


    private void  fromJSONDepartureLocationFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTravelLocationFilterJSON convert_classy = FlightTravelLocationFilterJSON.from_json(json_value, ignore_extras, true);
        setDepartureLocationFilter(convert_classy);
      }


    private void  fromJSONDestinationLocationFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTravelLocationFilterJSON convert_classy = FlightTravelLocationFilterJSON.from_json(json_value, ignore_extras, true);
        setDestinationLocationFilter(convert_classy);
      }


    private void  fromJSONDepartureDateTimeRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDepartureDateTimeRange(convert_classy);
      }


    private void  fromJSONDepartureTimeSpan(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DepartureTimeSpan of FlightSegmentFilterJSON is not a string.");
        setDepartureTimeSpan(json_string.getData());
      }


    private void  fromJSONSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SearchCriteria of FlightSegmentFilterJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SearchCriteria of FlightSegmentFilterJSON has too few elements.");
        List< FlightSegmentSearchCriterionJSON  > vector_SearchCriteria1 = new List< FlightSegmentSearchCriterionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightSegmentSearchCriterionJSON convert_classy = FlightSegmentSearchCriterionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SearchCriteria1.Add(convert_classy);
          }
        Debug.Assert(vector_SearchCriteria1.Count >= 1);
        initSearchCriteria();
        for (int num1 = 0; num1 < vector_SearchCriteria1.Count; ++num1)
            appendSearchCriteria(vector_SearchCriteria1[num1]);
        for (int num1 = 0; num1 < vector_SearchCriteria1.Count; ++num1)
          {
          }
      }


    private void  fromJSONUpdatedSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field UpdatedSearchCriteria of FlightSegmentFilterJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field UpdatedSearchCriteria of FlightSegmentFilterJSON has too few elements.");
        List< FlightSegmentSearchCriterionJSON  > vector_UpdatedSearchCriteria1 = new List< FlightSegmentSearchCriterionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightSegmentSearchCriterionJSON convert_classy = FlightSegmentSearchCriterionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_UpdatedSearchCriteria1.Add(convert_classy);
          }
        Debug.Assert(vector_UpdatedSearchCriteria1.Count >= 1);
        initUpdatedSearchCriteria();
        for (int num2 = 0; num2 < vector_UpdatedSearchCriteria1.Count; ++num2)
            appendUpdatedSearchCriteria(vector_UpdatedSearchCriteria1[num2]);
        for (int num1 = 0; num1 < vector_UpdatedSearchCriteria1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTypeOfLastDateTimeRangeFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DepartureOrArrivalJSON convert_classy = DepartureOrArrivalJSON.from_json(json_value, ignore_extras, true);
        setTypeOfLastDateTimeRangeFilter(convert_classy);
      }


    public FlightSegmentFilterJSON()
      {
        flagHasFindNextAvailableFlight = false;
        flagHasDepartureLocationFilter = false;
        flagHasDestinationLocationFilter = false;
        flagHasDepartureDateTimeRange = false;
        flagHasDepartureTimeSpan = false;
        flagHasSearchCriteria = false;
        flagHasUpdatedSearchCriteria = false;
        flagHasTypeOfLastDateTimeRangeFilter = false;
        storeSearchCriteria = new List< FlightSegmentSearchCriterionJSON  >();
        storeUpdatedSearchCriteria = new List< FlightSegmentSearchCriterionJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFindNextAvailableFlight()
      {
        return flagHasFindNextAvailableFlight;
      }

    public bool  getFindNextAvailableFlight()
      {
        Debug.Assert(flagHasFindNextAvailableFlight);
        return storeFindNextAvailableFlight;
      }

    public bool  hasDepartureLocationFilter()
      {
        return flagHasDepartureLocationFilter;
      }

    public FlightTravelLocationFilterJSON   getDepartureLocationFilter()
      {
        Debug.Assert(flagHasDepartureLocationFilter);
        return storeDepartureLocationFilter;
      }

    public bool  hasDestinationLocationFilter()
      {
        return flagHasDestinationLocationFilter;
      }

    public FlightTravelLocationFilterJSON   getDestinationLocationFilter()
      {
        Debug.Assert(flagHasDestinationLocationFilter);
        return storeDestinationLocationFilter;
      }

    public bool  hasDepartureDateTimeRange()
      {
        return flagHasDepartureDateTimeRange;
      }

    public DateTimeRangeSpecJSON   getDepartureDateTimeRange()
      {
        Debug.Assert(flagHasDepartureDateTimeRange);
        return storeDepartureDateTimeRange;
      }

    public bool  hasDepartureTimeSpan()
      {
        return flagHasDepartureTimeSpan;
      }

    public string  getDepartureTimeSpan()
      {
        Debug.Assert(flagHasDepartureTimeSpan);
        return storeDepartureTimeSpan;
      }

    public bool  hasSearchCriteria()
      {
        return flagHasSearchCriteria;
      }

    public int  countOfSearchCriteria()
      {
        Debug.Assert(flagHasSearchCriteria);
        return storeSearchCriteria.Count;
      }

    public FlightSegmentSearchCriterionJSON   elementOfSearchCriteria(int element_num)
      {
        Debug.Assert(flagHasSearchCriteria);
        return storeSearchCriteria[element_num];
      }

    public List< FlightSegmentSearchCriterionJSON  >  getSearchCriteria()
      {
        Debug.Assert(flagHasSearchCriteria);
        return storeSearchCriteria;
      }

    public bool  hasUpdatedSearchCriteria()
      {
        return flagHasUpdatedSearchCriteria;
      }

    public int  countOfUpdatedSearchCriteria()
      {
        Debug.Assert(flagHasUpdatedSearchCriteria);
        return storeUpdatedSearchCriteria.Count;
      }

    public FlightSegmentSearchCriterionJSON   elementOfUpdatedSearchCriteria(int element_num)
      {
        Debug.Assert(flagHasUpdatedSearchCriteria);
        return storeUpdatedSearchCriteria[element_num];
      }

    public List< FlightSegmentSearchCriterionJSON  >  getUpdatedSearchCriteria()
      {
        Debug.Assert(flagHasUpdatedSearchCriteria);
        return storeUpdatedSearchCriteria;
      }

    public bool  hasTypeOfLastDateTimeRangeFilter()
      {
        return flagHasTypeOfLastDateTimeRangeFilter;
      }

    public DepartureOrArrivalJSON   getTypeOfLastDateTimeRangeFilter()
      {
        Debug.Assert(flagHasTypeOfLastDateTimeRangeFilter);
        return storeTypeOfLastDateTimeRangeFilter;
      }

    public DepartureOrArrivalJSON.TypeValue  getTypeOfLastDateTimeRangeFilterValue()
      {
        return getTypeOfLastDateTimeRangeFilter().getValue();
      }

    public string  getTypeOfLastDateTimeRangeFilterAsString()
      {
        return getTypeOfLastDateTimeRangeFilter().getValueAsString();
      }


    public virtual int extraFlightSegmentFilterComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightSegmentFilterComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightSegmentFilterComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightSegmentFilterLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFindNextAvailableFlight(bool new_value)
      {
        flagHasFindNextAvailableFlight = true;
        storeFindNextAvailableFlight = new_value;
      }
    public void unsetFindNextAvailableFlight()
      {
        flagHasFindNextAvailableFlight = false;
      }
    public void setDepartureLocationFilter(FlightTravelLocationFilterJSON  new_value)
      {
        if (flagHasDepartureLocationFilter)
          {
          }
        flagHasDepartureLocationFilter = true;
        storeDepartureLocationFilter = new_value;
      }
    public void unsetDepartureLocationFilter()
      {
        if (flagHasDepartureLocationFilter)
          {
          }
        flagHasDepartureLocationFilter = false;
      }
    public void setDestinationLocationFilter(FlightTravelLocationFilterJSON  new_value)
      {
        if (flagHasDestinationLocationFilter)
          {
          }
        flagHasDestinationLocationFilter = true;
        storeDestinationLocationFilter = new_value;
      }
    public void unsetDestinationLocationFilter()
      {
        if (flagHasDestinationLocationFilter)
          {
          }
        flagHasDestinationLocationFilter = false;
      }
    public void setDepartureDateTimeRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDepartureDateTimeRange)
          {
          }
        flagHasDepartureDateTimeRange = true;
        storeDepartureDateTimeRange = new_value;
      }
    public void unsetDepartureDateTimeRange()
      {
        if (flagHasDepartureDateTimeRange)
          {
          }
        flagHasDepartureDateTimeRange = false;
      }
    public void setDepartureTimeSpan(string new_value)
      {
        flagHasDepartureTimeSpan = true;
        storeDepartureTimeSpan = new_value;
      }
    public void unsetDepartureTimeSpan()
      {
        flagHasDepartureTimeSpan = false;
      }
    public void initSearchCriteria()
      {
        if (flagHasSearchCriteria)
          {
            for (int num1 = 0; num1 < storeSearchCriteria.Count; ++num1)
              {
              }
          }
        flagHasSearchCriteria = true;
        storeSearchCriteria.Clear();
      }
    public void appendSearchCriteria(FlightSegmentSearchCriterionJSON  to_append)
      {
        if (!flagHasSearchCriteria)
          {
            flagHasSearchCriteria = true;
            storeSearchCriteria.Clear();
          }
        Debug.Assert(flagHasSearchCriteria);
        storeSearchCriteria.Add(to_append);
      }
    public void appendSearchCriteria(FlightSegmentSearchCriterionJSON.TypeValue new_value)
      {
        appendSearchCriteria(new FlightSegmentSearchCriterionJSON(new_value));
      }
    public void appendSearchCriteria(string chars)
      {
        FlightSegmentSearchCriterionJSON.TypeValueKnownValues known = FlightSegmentSearchCriterionJSON.stringToValue(chars);
        FlightSegmentSearchCriterionJSON.TypeValue new_value = new FlightSegmentSearchCriterionJSON.TypeValue();
        if (known == FlightSegmentSearchCriterionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendSearchCriteria(new_value);
      }
    public void unsetSearchCriteria()
      {
        if (flagHasSearchCriteria)
          {
            for (int num2 = 0; num2 < storeSearchCriteria.Count; ++num2)
              {
              }
          }
        flagHasSearchCriteria = false;
        storeSearchCriteria.Clear();
      }
    public void initUpdatedSearchCriteria()
      {
        if (flagHasUpdatedSearchCriteria)
          {
            for (int num3 = 0; num3 < storeUpdatedSearchCriteria.Count; ++num3)
              {
              }
          }
        flagHasUpdatedSearchCriteria = true;
        storeUpdatedSearchCriteria.Clear();
      }
    public void appendUpdatedSearchCriteria(FlightSegmentSearchCriterionJSON  to_append)
      {
        if (!flagHasUpdatedSearchCriteria)
          {
            flagHasUpdatedSearchCriteria = true;
            storeUpdatedSearchCriteria.Clear();
          }
        Debug.Assert(flagHasUpdatedSearchCriteria);
        storeUpdatedSearchCriteria.Add(to_append);
      }
    public void appendUpdatedSearchCriteria(FlightSegmentSearchCriterionJSON.TypeValue new_value)
      {
        appendUpdatedSearchCriteria(new FlightSegmentSearchCriterionJSON(new_value));
      }
    public void appendUpdatedSearchCriteria(string chars)
      {
        FlightSegmentSearchCriterionJSON.TypeValueKnownValues known = FlightSegmentSearchCriterionJSON.stringToValue(chars);
        FlightSegmentSearchCriterionJSON.TypeValue new_value = new FlightSegmentSearchCriterionJSON.TypeValue();
        if (known == FlightSegmentSearchCriterionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendUpdatedSearchCriteria(new_value);
      }
    public void unsetUpdatedSearchCriteria()
      {
        if (flagHasUpdatedSearchCriteria)
          {
            for (int num4 = 0; num4 < storeUpdatedSearchCriteria.Count; ++num4)
              {
              }
          }
        flagHasUpdatedSearchCriteria = false;
        storeUpdatedSearchCriteria.Clear();
      }
    public void setTypeOfLastDateTimeRangeFilter(DepartureOrArrivalJSON  new_value)
      {
        if (flagHasTypeOfLastDateTimeRangeFilter)
          {
          }
        flagHasTypeOfLastDateTimeRangeFilter = true;
        storeTypeOfLastDateTimeRangeFilter = new_value;
      }
    public void setTypeOfLastDateTimeRangeFilter(DepartureOrArrivalJSON.TypeValue new_value)
      {
        setTypeOfLastDateTimeRangeFilter(new DepartureOrArrivalJSON(new_value));
      }
    public void setTypeOfLastDateTimeRangeFilter(string chars)
      {
        setTypeOfLastDateTimeRangeFilter(new DepartureOrArrivalJSON(chars));
      }
    public void unsetTypeOfLastDateTimeRangeFilter()
      {
        if (flagHasTypeOfLastDateTimeRangeFilter)
          {
          }
        flagHasTypeOfLastDateTimeRangeFilter = false;
      }

    public virtual void extraFlightSegmentFilterAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightSegmentFilterSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightSegmentFilterLookup(key);
        if (old_field == null)
          {
            extraFlightSegmentFilterAppendPair(key, new_component);
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
        if (flagHasFindNextAvailableFlight)
          {
            handler.start_pair("FindNextAvailableFlight");
            handler.boolean_value(storeFindNextAvailableFlight);
          }
        if (flagHasDepartureLocationFilter)
          {
            handler.start_pair("DepartureLocationFilter");
            if (partial_allowed)
                storeDepartureLocationFilter.write_partial_as_json(handler);
            else
                storeDepartureLocationFilter.write_as_json(handler);
          }
        if (flagHasDestinationLocationFilter)
          {
            handler.start_pair("DestinationLocationFilter");
            if (partial_allowed)
                storeDestinationLocationFilter.write_partial_as_json(handler);
            else
                storeDestinationLocationFilter.write_as_json(handler);
          }
        if (flagHasDepartureDateTimeRange)
          {
            handler.start_pair("DepartureDateTimeRange");
            if (partial_allowed)
                storeDepartureDateTimeRange.write_partial_as_json(handler);
            else
                storeDepartureDateTimeRange.write_as_json(handler);
          }
        if (flagHasDepartureTimeSpan)
          {
            handler.start_pair("DepartureTimeSpan");
            handler.string_value(storeDepartureTimeSpan);
          }
        if (flagHasSearchCriteria)
          {
            handler.start_pair("SearchCriteria");
            Debug.Assert(storeSearchCriteria.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeSearchCriteria.Count; ++num1)
              {
                if (partial_allowed)
                    storeSearchCriteria[num1].write_partial_as_json(handler);
                else
                    storeSearchCriteria[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasUpdatedSearchCriteria)
          {
            handler.start_pair("UpdatedSearchCriteria");
            Debug.Assert(storeUpdatedSearchCriteria.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeUpdatedSearchCriteria.Count; ++num2)
              {
                if (partial_allowed)
                    storeUpdatedSearchCriteria[num2].write_partial_as_json(handler);
                else
                    storeUpdatedSearchCriteria[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasTypeOfLastDateTimeRangeFilter)
          {
            handler.start_pair("TypeOfLastDateTimeRangeFilter");
            if (partial_allowed)
                storeTypeOfLastDateTimeRangeFilter.write_partial_as_json(handler);
            else
                storeTypeOfLastDateTimeRangeFilter.write_as_json(handler);
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

    public static FlightSegmentFilterJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSegmentFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentFilter", ignore_extras);
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
    public static FlightSegmentFilterJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSegmentFilterJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSegmentFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentFilter", ignore_extras);
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
    public static FlightSegmentFilterJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSegmentFilterJSON from_text(string text, bool ignore_extras)
      {
        FlightSegmentFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentFilter", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightSegmentFilterJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightSegmentFilterJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightSegmentFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentFilter", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorFindNextAvailableFlight;
        private FlightTravelLocationFilterJSON.HoldingGenerator fieldGeneratorDepartureLocationFilter;
        private FlightTravelLocationFilterJSON.HoldingGenerator fieldGeneratorDestinationLocationFilter;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDepartureDateTimeRange;
        private JSONHoldingStringGenerator fieldGeneratorDepartureTimeSpan;
        private FlightSegmentSearchCriterionJSON.HoldingArrayGenerator fieldGeneratorSearchCriteria;
        private FlightSegmentSearchCriterionJSON.HoldingArrayGenerator fieldGeneratorUpdatedSearchCriteria;
        private DepartureOrArrivalJSON.HoldingGenerator fieldGeneratorTypeOfLastDateTimeRangeFilter;
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
            FlightSegmentFilterJSON result = new FlightSegmentFilterJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightSegmentFilterAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightSegmentFilterJSON result)
          {
            if (fieldGeneratorFindNextAvailableFlight.have_value)
              {
                result.setFindNextAvailableFlight(fieldGeneratorFindNextAvailableFlight.value);
                fieldGeneratorFindNextAvailableFlight.have_value = false;
              }
            if (fieldGeneratorDepartureLocationFilter.have_value)
              {
                result.setDepartureLocationFilter(fieldGeneratorDepartureLocationFilter.value);
                fieldGeneratorDepartureLocationFilter.have_value = false;
              }
            if (fieldGeneratorDestinationLocationFilter.have_value)
              {
                result.setDestinationLocationFilter(fieldGeneratorDestinationLocationFilter.value);
                fieldGeneratorDestinationLocationFilter.have_value = false;
              }
            if (fieldGeneratorDepartureDateTimeRange.have_value)
              {
                result.setDepartureDateTimeRange(fieldGeneratorDepartureDateTimeRange.value);
                fieldGeneratorDepartureDateTimeRange.have_value = false;
              }
            if (fieldGeneratorDepartureTimeSpan.have_value)
              {
                result.setDepartureTimeSpan(fieldGeneratorDepartureTimeSpan.value);
                fieldGeneratorDepartureTimeSpan.have_value = false;
              }
            if (fieldGeneratorSearchCriteria.have_value)
              {
                result.initSearchCriteria();
                int count = fieldGeneratorSearchCriteria.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSearchCriteria(fieldGeneratorSearchCriteria.value[num]);
                  }
                fieldGeneratorSearchCriteria.value.Clear();
                fieldGeneratorSearchCriteria.have_value = false;
              }
            if (fieldGeneratorUpdatedSearchCriteria.have_value)
              {
                result.initUpdatedSearchCriteria();
                int count = fieldGeneratorUpdatedSearchCriteria.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendUpdatedSearchCriteria(fieldGeneratorUpdatedSearchCriteria.value[num]);
                  }
                fieldGeneratorUpdatedSearchCriteria.value.Clear();
                fieldGeneratorUpdatedSearchCriteria.have_value = false;
              }
            if (fieldGeneratorTypeOfLastDateTimeRangeFilter.have_value)
              {
                result.setTypeOfLastDateTimeRangeFilter(fieldGeneratorTypeOfLastDateTimeRangeFilter.value);
                fieldGeneratorTypeOfLastDateTimeRangeFilter.have_value = false;
              }
          }
        protected abstract void handle_result(FlightSegmentFilterJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'p':
                                if (String.Compare(field_name, 3, "arture", 0, 6, false) == 0)
                                  {
                                    switch (field_name[9])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 10, "ateTimeRange", 0, 12, false) == 0) && (field_name.Length == 22))
                                                return fieldGeneratorDepartureDateTimeRange;
                                            break;
                                        case 'L':
                                            if ((String.Compare(field_name, 10, "ocationFilter", 0, 13, false) == 0) && (field_name.Length == 23))
                                                return fieldGeneratorDepartureLocationFilter;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 10, "imeSpan", 0, 7, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorDepartureTimeSpan;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 's':
                                if ((String.Compare(field_name, 3, "tinationLocationFilter", 0, 22, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorDestinationLocationFilter;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "indNextAvailableFlight", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorFindNextAvailableFlight;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "earchCriteria", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorSearchCriteria;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ypeOfLastDateTimeRangeFilter", 0, 28, false) == 0) && (field_name.Length == 29))
                        return fieldGeneratorTypeOfLastDateTimeRangeFilter;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "pdatedSearchCriteria", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorUpdatedSearchCriteria;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFindNextAvailableFlight = new JSONHoldingBooleanGenerator("field \"FindNextAvailableFlight\" of the FlightSegmentFilter class");
            fieldGeneratorDepartureLocationFilter = new FlightTravelLocationFilterJSON.HoldingGenerator("field \"DepartureLocationFilter\" of the FlightSegmentFilter class", ignore_extras);
            fieldGeneratorDestinationLocationFilter = new FlightTravelLocationFilterJSON.HoldingGenerator("field \"DestinationLocationFilter\" of the FlightSegmentFilter class", ignore_extras);
            fieldGeneratorDepartureDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DepartureDateTimeRange\" of the FlightSegmentFilter class", ignore_extras);
            fieldGeneratorDepartureTimeSpan = new JSONHoldingStringGenerator("field \"DepartureTimeSpan\" of the FlightSegmentFilter class");
            fieldGeneratorSearchCriteria = new FlightSegmentSearchCriterionJSON.HoldingArrayGenerator("field \"SearchCriteria\" of the FlightSegmentFilter class", ignore_extras);
            fieldGeneratorUpdatedSearchCriteria = new FlightSegmentSearchCriterionJSON.HoldingArrayGenerator("field \"UpdatedSearchCriteria\" of the FlightSegmentFilter class", ignore_extras);
            fieldGeneratorTypeOfLastDateTimeRangeFilter = new DepartureOrArrivalJSON.HoldingGenerator("field \"TypeOfLastDateTimeRangeFilter\" of the FlightSegmentFilter class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightSegmentFilter class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFindNextAvailableFlight = new JSONHoldingBooleanGenerator("field \"FindNextAvailableFlight\" of the FlightSegmentFilter class");
            fieldGeneratorDepartureLocationFilter = new FlightTravelLocationFilterJSON.HoldingGenerator("field \"DepartureLocationFilter\" of the FlightSegmentFilter class", false);
            fieldGeneratorDestinationLocationFilter = new FlightTravelLocationFilterJSON.HoldingGenerator("field \"DestinationLocationFilter\" of the FlightSegmentFilter class", false);
            fieldGeneratorDepartureDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DepartureDateTimeRange\" of the FlightSegmentFilter class", false);
            fieldGeneratorDepartureTimeSpan = new JSONHoldingStringGenerator("field \"DepartureTimeSpan\" of the FlightSegmentFilter class");
            fieldGeneratorSearchCriteria = new FlightSegmentSearchCriterionJSON.HoldingArrayGenerator("field \"SearchCriteria\" of the FlightSegmentFilter class", false);
            fieldGeneratorUpdatedSearchCriteria = new FlightSegmentSearchCriterionJSON.HoldingArrayGenerator("field \"UpdatedSearchCriteria\" of the FlightSegmentFilter class", false);
            fieldGeneratorTypeOfLastDateTimeRangeFilter = new DepartureOrArrivalJSON.HoldingGenerator("field \"TypeOfLastDateTimeRangeFilter\" of the FlightSegmentFilter class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightSegmentFilter class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFindNextAvailableFlight.reset();
            fieldGeneratorDepartureLocationFilter.reset();
            fieldGeneratorDestinationLocationFilter.reset();
            fieldGeneratorDepartureDateTimeRange.reset();
            fieldGeneratorDepartureTimeSpan.reset();
            fieldGeneratorSearchCriteria.reset();
            fieldGeneratorUpdatedSearchCriteria.reset();
            fieldGeneratorTypeOfLastDateTimeRangeFilter.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDepartureLocationFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationLocationFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDepartureDateTimeRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSearchCriteria.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUpdatedSearchCriteria.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTypeOfLastDateTimeRangeFilter.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDepartureLocationFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationLocationFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDepartureDateTimeRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSearchCriteria.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUpdatedSearchCriteria.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTypeOfLastDateTimeRangeFilter.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightSegmentFilterJSON  result)
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
        public FlightSegmentFilterJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightSegmentFilterJSON  result)
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
    protected virtual void handle_result(List<FlightSegmentFilterJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightSegmentFilterJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightSegmentFilterJSON>();
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
    public List<FlightSegmentFilterJSON> value;
  };
  };
