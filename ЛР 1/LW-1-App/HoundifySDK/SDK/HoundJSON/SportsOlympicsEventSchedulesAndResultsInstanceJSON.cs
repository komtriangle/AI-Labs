/* file "SportsOlympicsEventSchedulesAndResultsInstanceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsEventSchedulesAndResultsInstanceJSON : JSONBase
  {
    private bool flagHasEvent;
    private SportsOlympicsEventJSON  storeEvent;
    private bool flagHasEventCategory;
    private SportsOlympicsEventCategoryJSON  storeEventCategory;
    private bool flagHasInstanceDescription;
    private string storeInstanceDescription;
    private bool flagHasGames;
    private SportsOlympicsGamesJSON  storeGames;
    private bool flagHasMedalEvent;
    private bool storeMedalEvent;
    private bool flagHasGeneralSummary;
    private bool storeGeneralSummary;
    private bool flagHasStartTime;
    private DateAndOrTimeJSON  storeStartTime;
    private bool flagHasMedalWinners;
    private List< SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON  > storeMedalWinners;
    private bool flagHasParticipants;
    private List< SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON  > storeParticipants;
    private bool flagHasUpcoming;
    private bool storeUpcoming;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEvent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsEventJSON convert_classy = SportsOlympicsEventJSON.from_json(json_value, ignore_extras, true);
        setEvent(convert_classy);
      }


    private void  fromJSONEventCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsEventCategoryJSON convert_classy = SportsOlympicsEventCategoryJSON.from_json(json_value, ignore_extras, true);
        setEventCategory(convert_classy);
      }


    private void  fromJSONInstanceDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InstanceDescription of SportsOlympicsEventSchedulesAndResultsInstanceJSON is not a string.");
        setInstanceDescription(json_string.getData());
      }


    private void  fromJSONGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsGamesJSON convert_classy = SportsOlympicsGamesJSON.from_json(json_value, ignore_extras, true);
        setGames(convert_classy);
      }


    private void  fromJSONMedalEvent(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MedalEvent of SportsOlympicsEventSchedulesAndResultsInstanceJSON is not true for false.");
              }
          }
        setMedalEvent(the_bool);
      }


    private void  fromJSONGeneralSummary(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GeneralSummary of SportsOlympicsEventSchedulesAndResultsInstanceJSON is not true for false.");
              }
          }
        setGeneralSummary(the_bool);
      }


    private void  fromJSONStartTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartTime(convert_classy);
      }


    private void  fromJSONMedalWinners(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MedalWinners of SportsOlympicsEventSchedulesAndResultsInstanceJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON  > vector_MedalWinners1 = new List< SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON convert_classy = SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_MedalWinners1.Add(convert_classy);
          }
        initMedalWinners();
        for (int num1 = 0; num1 < vector_MedalWinners1.Count; ++num1)
            appendMedalWinners(vector_MedalWinners1[num1]);
        for (int num1 = 0; num1 < vector_MedalWinners1.Count; ++num1)
          {
          }
      }


    private void  fromJSONParticipants(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Participants of SportsOlympicsEventSchedulesAndResultsInstanceJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON  > vector_Participants1 = new List< SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON convert_classy = SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Participants1.Add(convert_classy);
          }
        initParticipants();
        for (int num2 = 0; num2 < vector_Participants1.Count; ++num2)
            appendParticipants(vector_Participants1[num2]);
        for (int num1 = 0; num1 < vector_Participants1.Count; ++num1)
          {
          }
      }


    private void  fromJSONUpcoming(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Upcoming of SportsOlympicsEventSchedulesAndResultsInstanceJSON is not true for false.");
              }
          }
        setUpcoming(the_bool);
      }


    public SportsOlympicsEventSchedulesAndResultsInstanceJSON()
      {
        flagHasEvent = false;
        flagHasEventCategory = false;
        flagHasInstanceDescription = false;
        flagHasGames = false;
        flagHasMedalEvent = false;
        flagHasGeneralSummary = false;
        flagHasStartTime = false;
        flagHasMedalWinners = false;
        flagHasParticipants = false;
        flagHasUpcoming = false;
        storeMedalWinners = new List< SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON  >();
        storeParticipants = new List< SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEvent()
      {
        return flagHasEvent;
      }

    public SportsOlympicsEventJSON   getEvent()
      {
        Debug.Assert(flagHasEvent);
        return storeEvent;
      }

    public SportsOlympicsEventJSON.TypeValue  getEventValue()
      {
        return getEvent().getValue();
      }

    public string  getEventAsString()
      {
        return getEvent().getValueAsString();
      }

    public bool  hasEventCategory()
      {
        return flagHasEventCategory;
      }

    public SportsOlympicsEventCategoryJSON   getEventCategory()
      {
        Debug.Assert(flagHasEventCategory);
        return storeEventCategory;
      }

    public SportsOlympicsEventCategoryJSON.TypeValue  getEventCategoryValue()
      {
        return getEventCategory().getValue();
      }

    public string  getEventCategoryAsString()
      {
        return getEventCategory().getValueAsString();
      }

    public bool  hasInstanceDescription()
      {
        return flagHasInstanceDescription;
      }

    public string  getInstanceDescription()
      {
        Debug.Assert(flagHasInstanceDescription);
        return storeInstanceDescription;
      }

    public bool  hasGames()
      {
        return flagHasGames;
      }

    public SportsOlympicsGamesJSON   getGames()
      {
        Debug.Assert(flagHasGames);
        return storeGames;
      }

    public bool  hasMedalEvent()
      {
        return flagHasMedalEvent;
      }

    public bool  getMedalEvent()
      {
        Debug.Assert(flagHasMedalEvent);
        return storeMedalEvent;
      }

    public bool  hasGeneralSummary()
      {
        return flagHasGeneralSummary;
      }

    public bool  getGeneralSummary()
      {
        Debug.Assert(flagHasGeneralSummary);
        return storeGeneralSummary;
      }

    public bool  hasStartTime()
      {
        return flagHasStartTime;
      }

    public DateAndOrTimeJSON   getStartTime()
      {
        Debug.Assert(flagHasStartTime);
        return storeStartTime;
      }

    public bool  hasMedalWinners()
      {
        return flagHasMedalWinners;
      }

    public int  countOfMedalWinners()
      {
        Debug.Assert(flagHasMedalWinners);
        return storeMedalWinners.Count;
      }

    public SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON   elementOfMedalWinners(int element_num)
      {
        Debug.Assert(flagHasMedalWinners);
        return storeMedalWinners[element_num];
      }

    public List< SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON  >  getMedalWinners()
      {
        Debug.Assert(flagHasMedalWinners);
        return storeMedalWinners;
      }

    public bool  hasParticipants()
      {
        return flagHasParticipants;
      }

    public int  countOfParticipants()
      {
        Debug.Assert(flagHasParticipants);
        return storeParticipants.Count;
      }

    public SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON   elementOfParticipants(int element_num)
      {
        Debug.Assert(flagHasParticipants);
        return storeParticipants[element_num];
      }

    public List< SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON  >  getParticipants()
      {
        Debug.Assert(flagHasParticipants);
        return storeParticipants;
      }

    public bool  hasUpcoming()
      {
        return flagHasUpcoming;
      }

    public bool  getUpcoming()
      {
        Debug.Assert(flagHasUpcoming);
        return storeUpcoming;
      }


    public virtual int extraSportsOlympicsEventSchedulesAndResultsInstanceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsEventSchedulesAndResultsInstanceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsInstanceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsInstanceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setEvent(SportsOlympicsEventJSON  new_value)
      {
        if (flagHasEvent)
          {
          }
        flagHasEvent = true;
        storeEvent = new_value;
      }
    public void setEvent(SportsOlympicsEventJSON.TypeValue new_value)
      {
        setEvent(new SportsOlympicsEventJSON(new_value));
      }
    public void setEvent(string chars)
      {
        SportsOlympicsEventJSON.TypeValueKnownValues known = SportsOlympicsEventJSON.stringToValue(chars);
        SportsOlympicsEventJSON.TypeValue new_value = new SportsOlympicsEventJSON.TypeValue();
        if (known == SportsOlympicsEventJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setEvent(new_value);
      }
    public void unsetEvent()
      {
        if (flagHasEvent)
          {
          }
        flagHasEvent = false;
      }
    public void setEventCategory(SportsOlympicsEventCategoryJSON  new_value)
      {
        if (flagHasEventCategory)
          {
          }
        flagHasEventCategory = true;
        storeEventCategory = new_value;
      }
    public void setEventCategory(SportsOlympicsEventCategoryJSON.TypeValue new_value)
      {
        setEventCategory(new SportsOlympicsEventCategoryJSON(new_value));
      }
    public void setEventCategory(string chars)
      {
        SportsOlympicsEventCategoryJSON.TypeValueKnownValues known = SportsOlympicsEventCategoryJSON.stringToValue(chars);
        SportsOlympicsEventCategoryJSON.TypeValue new_value = new SportsOlympicsEventCategoryJSON.TypeValue();
        if (known == SportsOlympicsEventCategoryJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setEventCategory(new_value);
      }
    public void unsetEventCategory()
      {
        if (flagHasEventCategory)
          {
          }
        flagHasEventCategory = false;
      }
    public void setInstanceDescription(string new_value)
      {
        flagHasInstanceDescription = true;
        storeInstanceDescription = new_value;
      }
    public void unsetInstanceDescription()
      {
        flagHasInstanceDescription = false;
      }
    public void setGames(SportsOlympicsGamesJSON  new_value)
      {
        if (flagHasGames)
          {
          }
        flagHasGames = true;
        storeGames = new_value;
      }
    public void unsetGames()
      {
        if (flagHasGames)
          {
          }
        flagHasGames = false;
      }
    public void setMedalEvent(bool new_value)
      {
        flagHasMedalEvent = true;
        storeMedalEvent = new_value;
      }
    public void unsetMedalEvent()
      {
        flagHasMedalEvent = false;
      }
    public void setGeneralSummary(bool new_value)
      {
        flagHasGeneralSummary = true;
        storeGeneralSummary = new_value;
      }
    public void unsetGeneralSummary()
      {
        flagHasGeneralSummary = false;
      }
    public void setStartTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartTime)
          {
          }
        flagHasStartTime = true;
        storeStartTime = new_value;
      }
    public void unsetStartTime()
      {
        if (flagHasStartTime)
          {
          }
        flagHasStartTime = false;
      }
    public void initMedalWinners()
      {
        if (flagHasMedalWinners)
          {
            for (int num1 = 0; num1 < storeMedalWinners.Count; ++num1)
              {
              }
          }
        flagHasMedalWinners = true;
        storeMedalWinners.Clear();
      }
    public void appendMedalWinners(SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON  to_append)
      {
        if (!flagHasMedalWinners)
          {
            flagHasMedalWinners = true;
            storeMedalWinners.Clear();
          }
        Debug.Assert(flagHasMedalWinners);
        storeMedalWinners.Add(to_append);
      }
    public void unsetMedalWinners()
      {
        if (flagHasMedalWinners)
          {
            for (int num2 = 0; num2 < storeMedalWinners.Count; ++num2)
              {
              }
          }
        flagHasMedalWinners = false;
        storeMedalWinners.Clear();
      }
    public void initParticipants()
      {
        if (flagHasParticipants)
          {
            for (int num3 = 0; num3 < storeParticipants.Count; ++num3)
              {
              }
          }
        flagHasParticipants = true;
        storeParticipants.Clear();
      }
    public void appendParticipants(SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON  to_append)
      {
        if (!flagHasParticipants)
          {
            flagHasParticipants = true;
            storeParticipants.Clear();
          }
        Debug.Assert(flagHasParticipants);
        storeParticipants.Add(to_append);
      }
    public void unsetParticipants()
      {
        if (flagHasParticipants)
          {
            for (int num4 = 0; num4 < storeParticipants.Count; ++num4)
              {
              }
          }
        flagHasParticipants = false;
        storeParticipants.Clear();
      }
    public void setUpcoming(bool new_value)
      {
        flagHasUpcoming = true;
        storeUpcoming = new_value;
      }
    public void unsetUpcoming()
      {
        flagHasUpcoming = false;
      }

    public virtual void extraSportsOlympicsEventSchedulesAndResultsInstanceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsEventSchedulesAndResultsInstanceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsEventSchedulesAndResultsInstanceLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsEventSchedulesAndResultsInstanceAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasEvent);
        if (flagHasEvent)
          {
            handler.start_pair("Event");
            if (partial_allowed)
                storeEvent.write_partial_as_json(handler);
            else
                storeEvent.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEventCategory);
        if (flagHasEventCategory)
          {
            handler.start_pair("EventCategory");
            if (partial_allowed)
                storeEventCategory.write_partial_as_json(handler);
            else
                storeEventCategory.write_as_json(handler);
          }
        if (flagHasInstanceDescription)
          {
            handler.start_pair("InstanceDescription");
            handler.string_value(storeInstanceDescription);
          }
        Debug.Assert(partial_allowed || flagHasGames);
        if (flagHasGames)
          {
            handler.start_pair("Games");
            if (partial_allowed)
                storeGames.write_partial_as_json(handler);
            else
                storeGames.write_as_json(handler);
          }
        if (flagHasMedalEvent)
          {
            handler.start_pair("MedalEvent");
            handler.boolean_value(storeMedalEvent);
          }
        if (flagHasGeneralSummary)
          {
            handler.start_pair("GeneralSummary");
            handler.boolean_value(storeGeneralSummary);
          }
        if (flagHasStartTime)
          {
            handler.start_pair("StartTime");
            if (partial_allowed)
                storeStartTime.write_partial_as_json(handler);
            else
                storeStartTime.write_as_json(handler);
          }
        if (flagHasMedalWinners)
          {
            handler.start_pair("MedalWinners");
            handler.start_array();
            for (int num1 = 0; num1 < storeMedalWinners.Count; ++num1)
              {
                if (partial_allowed)
                    storeMedalWinners[num1].write_partial_as_json(handler);
                else
                    storeMedalWinners[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasParticipants)
          {
            handler.start_pair("Participants");
            handler.start_array();
            for (int num2 = 0; num2 < storeParticipants.Count; ++num2)
              {
                if (partial_allowed)
                    storeParticipants[num2].write_partial_as_json(handler);
                else
                    storeParticipants[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasUpcoming)
          {
            handler.start_pair("Upcoming");
            handler.boolean_value(storeUpcoming);
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
        if (!(hasEvent()))
          {
            return "When parsing the object for %what%, the \"Event\" field was missing.";
          }
        if (!(hasEventCategory()))
          {
            return "When parsing the object for %what%, the \"EventCategory\" field was missing.";
          }
        if (!(hasGames()))
          {
            return "When parsing the object for %what%, the \"Games\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsEventSchedulesAndResultsInstanceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsInstanceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInstance", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsInstanceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsInstanceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsInstanceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInstance", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsInstanceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsInstanceJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsInstanceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInstance", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventSchedulesAndResultsInstanceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsEventSchedulesAndResultsInstanceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsInstanceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsInstance", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsOlympicsEventJSON.HoldingGenerator fieldGeneratorEvent;
        private SportsOlympicsEventCategoryJSON.HoldingGenerator fieldGeneratorEventCategory;
        private JSONHoldingStringGenerator fieldGeneratorInstanceDescription;
        private SportsOlympicsGamesJSON.HoldingGenerator fieldGeneratorGames;
        private JSONHoldingBooleanGenerator fieldGeneratorMedalEvent;
        private JSONHoldingBooleanGenerator fieldGeneratorGeneralSummary;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartTime;
        private SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON.HoldingArrayGenerator fieldGeneratorMedalWinners;
        private SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON.HoldingArrayGenerator fieldGeneratorParticipants;
        private JSONHoldingBooleanGenerator fieldGeneratorUpcoming;
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
            SportsOlympicsEventSchedulesAndResultsInstanceJSON result = new SportsOlympicsEventSchedulesAndResultsInstanceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsEventSchedulesAndResultsInstanceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsEventSchedulesAndResultsInstanceJSON result)
          {
            if (fieldGeneratorEvent.have_value)
              {
                result.setEvent(fieldGeneratorEvent.value);
                fieldGeneratorEvent.have_value = false;
              }
            else if ((!(result.hasEvent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Event\" field was missing.");
              }
            if (fieldGeneratorEventCategory.have_value)
              {
                result.setEventCategory(fieldGeneratorEventCategory.value);
                fieldGeneratorEventCategory.have_value = false;
              }
            else if ((!(result.hasEventCategory())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EventCategory\" field was missing.");
              }
            if (fieldGeneratorInstanceDescription.have_value)
              {
                result.setInstanceDescription(fieldGeneratorInstanceDescription.value);
                fieldGeneratorInstanceDescription.have_value = false;
              }
            if (fieldGeneratorGames.have_value)
              {
                result.setGames(fieldGeneratorGames.value);
                fieldGeneratorGames.have_value = false;
              }
            else if ((!(result.hasGames())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Games\" field was missing.");
              }
            if (fieldGeneratorMedalEvent.have_value)
              {
                result.setMedalEvent(fieldGeneratorMedalEvent.value);
                fieldGeneratorMedalEvent.have_value = false;
              }
            if (fieldGeneratorGeneralSummary.have_value)
              {
                result.setGeneralSummary(fieldGeneratorGeneralSummary.value);
                fieldGeneratorGeneralSummary.have_value = false;
              }
            if (fieldGeneratorStartTime.have_value)
              {
                result.setStartTime(fieldGeneratorStartTime.value);
                fieldGeneratorStartTime.have_value = false;
              }
            if (fieldGeneratorMedalWinners.have_value)
              {
                result.initMedalWinners();
                int count = fieldGeneratorMedalWinners.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMedalWinners(fieldGeneratorMedalWinners.value[num]);
                  }
                fieldGeneratorMedalWinners.value.Clear();
                fieldGeneratorMedalWinners.have_value = false;
              }
            if (fieldGeneratorParticipants.have_value)
              {
                result.initParticipants();
                int count = fieldGeneratorParticipants.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendParticipants(fieldGeneratorParticipants.value[num]);
                  }
                fieldGeneratorParticipants.value.Clear();
                fieldGeneratorParticipants.have_value = false;
              }
            if (fieldGeneratorUpcoming.have_value)
              {
                result.setUpcoming(fieldGeneratorUpcoming.value);
                fieldGeneratorUpcoming.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsEventSchedulesAndResultsInstanceJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if (String.Compare(field_name, 1, "vent", 0, 4, false) == 0)
                      {
                        if (field_name.Length == 5)
                          {
                            return fieldGeneratorEvent;
                          }
                        switch (field_name[5])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 6, "ategory", 0, 7, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorEventCategory;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'G':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "mes", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorGames;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "neralSummary", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorGeneralSummary;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nstanceDescription", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorInstanceDescription;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "edal", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 6, "vent", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorMedalEvent;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 6, "inners", 0, 6, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorMedalWinners;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "articipants", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorParticipants;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartTime", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorStartTime;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "pcoming", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorUpcoming;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEvent = new SportsOlympicsEventJSON.HoldingGenerator("field \"Event\" of the SportsOlympicsEventSchedulesAndResultsInstance class", ignore_extras);
            fieldGeneratorEventCategory = new SportsOlympicsEventCategoryJSON.HoldingGenerator("field \"EventCategory\" of the SportsOlympicsEventSchedulesAndResultsInstance class", ignore_extras);
            fieldGeneratorInstanceDescription = new JSONHoldingStringGenerator("field \"InstanceDescription\" of the SportsOlympicsEventSchedulesAndResultsInstance class");
            fieldGeneratorGames = new SportsOlympicsGamesJSON.HoldingGenerator("field \"Games\" of the SportsOlympicsEventSchedulesAndResultsInstance class", ignore_extras);
            fieldGeneratorMedalEvent = new JSONHoldingBooleanGenerator("field \"MedalEvent\" of the SportsOlympicsEventSchedulesAndResultsInstance class");
            fieldGeneratorGeneralSummary = new JSONHoldingBooleanGenerator("field \"GeneralSummary\" of the SportsOlympicsEventSchedulesAndResultsInstance class");
            fieldGeneratorStartTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartTime\" of the SportsOlympicsEventSchedulesAndResultsInstance class", ignore_extras);
            fieldGeneratorMedalWinners = new SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON.HoldingArrayGenerator("field \"MedalWinners\" of the SportsOlympicsEventSchedulesAndResultsInstance class", ignore_extras);
            fieldGeneratorParticipants = new SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON.HoldingArrayGenerator("field \"Participants\" of the SportsOlympicsEventSchedulesAndResultsInstance class", ignore_extras);
            fieldGeneratorUpcoming = new JSONHoldingBooleanGenerator("field \"Upcoming\" of the SportsOlympicsEventSchedulesAndResultsInstance class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsEventSchedulesAndResultsInstance class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEvent = new SportsOlympicsEventJSON.HoldingGenerator("field \"Event\" of the SportsOlympicsEventSchedulesAndResultsInstance class", false);
            fieldGeneratorEventCategory = new SportsOlympicsEventCategoryJSON.HoldingGenerator("field \"EventCategory\" of the SportsOlympicsEventSchedulesAndResultsInstance class", false);
            fieldGeneratorInstanceDescription = new JSONHoldingStringGenerator("field \"InstanceDescription\" of the SportsOlympicsEventSchedulesAndResultsInstance class");
            fieldGeneratorGames = new SportsOlympicsGamesJSON.HoldingGenerator("field \"Games\" of the SportsOlympicsEventSchedulesAndResultsInstance class", false);
            fieldGeneratorMedalEvent = new JSONHoldingBooleanGenerator("field \"MedalEvent\" of the SportsOlympicsEventSchedulesAndResultsInstance class");
            fieldGeneratorGeneralSummary = new JSONHoldingBooleanGenerator("field \"GeneralSummary\" of the SportsOlympicsEventSchedulesAndResultsInstance class");
            fieldGeneratorStartTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartTime\" of the SportsOlympicsEventSchedulesAndResultsInstance class", false);
            fieldGeneratorMedalWinners = new SportsOlympicsEventSchedulesAndResultsInstanceMedalWinnerJSON.HoldingArrayGenerator("field \"MedalWinners\" of the SportsOlympicsEventSchedulesAndResultsInstance class", false);
            fieldGeneratorParticipants = new SportsOlympicsEventSchedulesAndResultsInstanceParticipantJSON.HoldingArrayGenerator("field \"Participants\" of the SportsOlympicsEventSchedulesAndResultsInstance class", false);
            fieldGeneratorUpcoming = new JSONHoldingBooleanGenerator("field \"Upcoming\" of the SportsOlympicsEventSchedulesAndResultsInstance class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsEventSchedulesAndResultsInstance class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEvent.reset();
            fieldGeneratorEventCategory.reset();
            fieldGeneratorInstanceDescription.reset();
            fieldGeneratorGames.reset();
            fieldGeneratorMedalEvent.reset();
            fieldGeneratorGeneralSummary.reset();
            fieldGeneratorStartTime.reset();
            fieldGeneratorMedalWinners.reset();
            fieldGeneratorParticipants.reset();
            fieldGeneratorUpcoming.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEvent.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEventCategory.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGames.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStartTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMedalWinners.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorParticipants.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEvent.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEventCategory.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGames.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStartTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMedalWinners.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorParticipants.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsInstanceJSON  result)
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
        public SportsOlympicsEventSchedulesAndResultsInstanceJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsInstanceJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventSchedulesAndResultsInstanceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventSchedulesAndResultsInstanceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventSchedulesAndResultsInstanceJSON>();
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
    public List<SportsOlympicsEventSchedulesAndResultsInstanceJSON> value;
  };
  };
