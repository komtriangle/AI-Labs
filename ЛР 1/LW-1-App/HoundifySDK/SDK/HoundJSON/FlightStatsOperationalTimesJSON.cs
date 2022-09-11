/* file "FlightStatsOperationalTimesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightStatsOperationalTimesJSON : JSONBase
  {
    private bool flagHaspublishedDeparture;
    private FlightStatsTimesJSON  storepublishedDeparture;
    private bool flagHaspublishedArrival;
    private FlightStatsTimesJSON  storepublishedArrival;
    private bool flagHasscheduledGateDeparture;
    private FlightStatsTimesJSON  storescheduledGateDeparture;
    private bool flagHasestimatedGateDeparture;
    private FlightStatsTimesJSON  storeestimatedGateDeparture;
    private bool flagHasactualGateDeparture;
    private FlightStatsTimesJSON  storeactualGateDeparture;
    private bool flagHasflightPlanPlannedDeparture;
    private FlightStatsTimesJSON  storeflightPlanPlannedDeparture;
    private bool flagHasestimatedRunwayDeparture;
    private FlightStatsTimesJSON  storeestimatedRunwayDeparture;
    private bool flagHasactualRunwayDeparture;
    private FlightStatsTimesJSON  storeactualRunwayDeparture;
    private bool flagHasscheduledGateArrival;
    private FlightStatsTimesJSON  storescheduledGateArrival;
    private bool flagHasestimatedGateArrival;
    private FlightStatsTimesJSON  storeestimatedGateArrival;
    private bool flagHasactualGateArrival;
    private FlightStatsTimesJSON  storeactualGateArrival;
    private bool flagHasflightPlanPlannedArrival;
    private FlightStatsTimesJSON  storeflightPlanPlannedArrival;
    private bool flagHasestimatedRunwayArrival;
    private FlightStatsTimesJSON  storeestimatedRunwayArrival;
    private bool flagHasactualRunwayArrival;
    private FlightStatsTimesJSON  storeactualRunwayArrival;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONpublishedDeparture(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setpublishedDeparture(convert_classy);
      }


    private void  fromJSONpublishedArrival(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setpublishedArrival(convert_classy);
      }


    private void  fromJSONscheduledGateDeparture(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setscheduledGateDeparture(convert_classy);
      }


    private void  fromJSONestimatedGateDeparture(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setestimatedGateDeparture(convert_classy);
      }


    private void  fromJSONactualGateDeparture(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setactualGateDeparture(convert_classy);
      }


    private void  fromJSONflightPlanPlannedDeparture(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setflightPlanPlannedDeparture(convert_classy);
      }


    private void  fromJSONestimatedRunwayDeparture(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setestimatedRunwayDeparture(convert_classy);
      }


    private void  fromJSONactualRunwayDeparture(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setactualRunwayDeparture(convert_classy);
      }


    private void  fromJSONscheduledGateArrival(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setscheduledGateArrival(convert_classy);
      }


    private void  fromJSONestimatedGateArrival(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setestimatedGateArrival(convert_classy);
      }


    private void  fromJSONactualGateArrival(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setactualGateArrival(convert_classy);
      }


    private void  fromJSONflightPlanPlannedArrival(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setflightPlanPlannedArrival(convert_classy);
      }


    private void  fromJSONestimatedRunwayArrival(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setestimatedRunwayArrival(convert_classy);
      }


    private void  fromJSONactualRunwayArrival(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setactualRunwayArrival(convert_classy);
      }


    public FlightStatsOperationalTimesJSON()
      {
        flagHaspublishedDeparture = false;
        flagHaspublishedArrival = false;
        flagHasscheduledGateDeparture = false;
        flagHasestimatedGateDeparture = false;
        flagHasactualGateDeparture = false;
        flagHasflightPlanPlannedDeparture = false;
        flagHasestimatedRunwayDeparture = false;
        flagHasactualRunwayDeparture = false;
        flagHasscheduledGateArrival = false;
        flagHasestimatedGateArrival = false;
        flagHasactualGateArrival = false;
        flagHasflightPlanPlannedArrival = false;
        flagHasestimatedRunwayArrival = false;
        flagHasactualRunwayArrival = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  haspublishedDeparture()
      {
        return flagHaspublishedDeparture;
      }

    public FlightStatsTimesJSON   getpublishedDeparture()
      {
        Debug.Assert(flagHaspublishedDeparture);
        return storepublishedDeparture;
      }

    public bool  haspublishedArrival()
      {
        return flagHaspublishedArrival;
      }

    public FlightStatsTimesJSON   getpublishedArrival()
      {
        Debug.Assert(flagHaspublishedArrival);
        return storepublishedArrival;
      }

    public bool  hasscheduledGateDeparture()
      {
        return flagHasscheduledGateDeparture;
      }

    public FlightStatsTimesJSON   getscheduledGateDeparture()
      {
        Debug.Assert(flagHasscheduledGateDeparture);
        return storescheduledGateDeparture;
      }

    public bool  hasestimatedGateDeparture()
      {
        return flagHasestimatedGateDeparture;
      }

    public FlightStatsTimesJSON   getestimatedGateDeparture()
      {
        Debug.Assert(flagHasestimatedGateDeparture);
        return storeestimatedGateDeparture;
      }

    public bool  hasactualGateDeparture()
      {
        return flagHasactualGateDeparture;
      }

    public FlightStatsTimesJSON   getactualGateDeparture()
      {
        Debug.Assert(flagHasactualGateDeparture);
        return storeactualGateDeparture;
      }

    public bool  hasflightPlanPlannedDeparture()
      {
        return flagHasflightPlanPlannedDeparture;
      }

    public FlightStatsTimesJSON   getflightPlanPlannedDeparture()
      {
        Debug.Assert(flagHasflightPlanPlannedDeparture);
        return storeflightPlanPlannedDeparture;
      }

    public bool  hasestimatedRunwayDeparture()
      {
        return flagHasestimatedRunwayDeparture;
      }

    public FlightStatsTimesJSON   getestimatedRunwayDeparture()
      {
        Debug.Assert(flagHasestimatedRunwayDeparture);
        return storeestimatedRunwayDeparture;
      }

    public bool  hasactualRunwayDeparture()
      {
        return flagHasactualRunwayDeparture;
      }

    public FlightStatsTimesJSON   getactualRunwayDeparture()
      {
        Debug.Assert(flagHasactualRunwayDeparture);
        return storeactualRunwayDeparture;
      }

    public bool  hasscheduledGateArrival()
      {
        return flagHasscheduledGateArrival;
      }

    public FlightStatsTimesJSON   getscheduledGateArrival()
      {
        Debug.Assert(flagHasscheduledGateArrival);
        return storescheduledGateArrival;
      }

    public bool  hasestimatedGateArrival()
      {
        return flagHasestimatedGateArrival;
      }

    public FlightStatsTimesJSON   getestimatedGateArrival()
      {
        Debug.Assert(flagHasestimatedGateArrival);
        return storeestimatedGateArrival;
      }

    public bool  hasactualGateArrival()
      {
        return flagHasactualGateArrival;
      }

    public FlightStatsTimesJSON   getactualGateArrival()
      {
        Debug.Assert(flagHasactualGateArrival);
        return storeactualGateArrival;
      }

    public bool  hasflightPlanPlannedArrival()
      {
        return flagHasflightPlanPlannedArrival;
      }

    public FlightStatsTimesJSON   getflightPlanPlannedArrival()
      {
        Debug.Assert(flagHasflightPlanPlannedArrival);
        return storeflightPlanPlannedArrival;
      }

    public bool  hasestimatedRunwayArrival()
      {
        return flagHasestimatedRunwayArrival;
      }

    public FlightStatsTimesJSON   getestimatedRunwayArrival()
      {
        Debug.Assert(flagHasestimatedRunwayArrival);
        return storeestimatedRunwayArrival;
      }

    public bool  hasactualRunwayArrival()
      {
        return flagHasactualRunwayArrival;
      }

    public FlightStatsTimesJSON   getactualRunwayArrival()
      {
        Debug.Assert(flagHasactualRunwayArrival);
        return storeactualRunwayArrival;
      }


    public virtual int extraFlightStatsOperationalTimesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatsOperationalTimesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatsOperationalTimesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatsOperationalTimesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setpublishedDeparture(FlightStatsTimesJSON  new_value)
      {
        if (flagHaspublishedDeparture)
          {
          }
        flagHaspublishedDeparture = true;
        storepublishedDeparture = new_value;
      }
    public void unsetpublishedDeparture()
      {
        if (flagHaspublishedDeparture)
          {
          }
        flagHaspublishedDeparture = false;
      }
    public void setpublishedArrival(FlightStatsTimesJSON  new_value)
      {
        if (flagHaspublishedArrival)
          {
          }
        flagHaspublishedArrival = true;
        storepublishedArrival = new_value;
      }
    public void unsetpublishedArrival()
      {
        if (flagHaspublishedArrival)
          {
          }
        flagHaspublishedArrival = false;
      }
    public void setscheduledGateDeparture(FlightStatsTimesJSON  new_value)
      {
        if (flagHasscheduledGateDeparture)
          {
          }
        flagHasscheduledGateDeparture = true;
        storescheduledGateDeparture = new_value;
      }
    public void unsetscheduledGateDeparture()
      {
        if (flagHasscheduledGateDeparture)
          {
          }
        flagHasscheduledGateDeparture = false;
      }
    public void setestimatedGateDeparture(FlightStatsTimesJSON  new_value)
      {
        if (flagHasestimatedGateDeparture)
          {
          }
        flagHasestimatedGateDeparture = true;
        storeestimatedGateDeparture = new_value;
      }
    public void unsetestimatedGateDeparture()
      {
        if (flagHasestimatedGateDeparture)
          {
          }
        flagHasestimatedGateDeparture = false;
      }
    public void setactualGateDeparture(FlightStatsTimesJSON  new_value)
      {
        if (flagHasactualGateDeparture)
          {
          }
        flagHasactualGateDeparture = true;
        storeactualGateDeparture = new_value;
      }
    public void unsetactualGateDeparture()
      {
        if (flagHasactualGateDeparture)
          {
          }
        flagHasactualGateDeparture = false;
      }
    public void setflightPlanPlannedDeparture(FlightStatsTimesJSON  new_value)
      {
        if (flagHasflightPlanPlannedDeparture)
          {
          }
        flagHasflightPlanPlannedDeparture = true;
        storeflightPlanPlannedDeparture = new_value;
      }
    public void unsetflightPlanPlannedDeparture()
      {
        if (flagHasflightPlanPlannedDeparture)
          {
          }
        flagHasflightPlanPlannedDeparture = false;
      }
    public void setestimatedRunwayDeparture(FlightStatsTimesJSON  new_value)
      {
        if (flagHasestimatedRunwayDeparture)
          {
          }
        flagHasestimatedRunwayDeparture = true;
        storeestimatedRunwayDeparture = new_value;
      }
    public void unsetestimatedRunwayDeparture()
      {
        if (flagHasestimatedRunwayDeparture)
          {
          }
        flagHasestimatedRunwayDeparture = false;
      }
    public void setactualRunwayDeparture(FlightStatsTimesJSON  new_value)
      {
        if (flagHasactualRunwayDeparture)
          {
          }
        flagHasactualRunwayDeparture = true;
        storeactualRunwayDeparture = new_value;
      }
    public void unsetactualRunwayDeparture()
      {
        if (flagHasactualRunwayDeparture)
          {
          }
        flagHasactualRunwayDeparture = false;
      }
    public void setscheduledGateArrival(FlightStatsTimesJSON  new_value)
      {
        if (flagHasscheduledGateArrival)
          {
          }
        flagHasscheduledGateArrival = true;
        storescheduledGateArrival = new_value;
      }
    public void unsetscheduledGateArrival()
      {
        if (flagHasscheduledGateArrival)
          {
          }
        flagHasscheduledGateArrival = false;
      }
    public void setestimatedGateArrival(FlightStatsTimesJSON  new_value)
      {
        if (flagHasestimatedGateArrival)
          {
          }
        flagHasestimatedGateArrival = true;
        storeestimatedGateArrival = new_value;
      }
    public void unsetestimatedGateArrival()
      {
        if (flagHasestimatedGateArrival)
          {
          }
        flagHasestimatedGateArrival = false;
      }
    public void setactualGateArrival(FlightStatsTimesJSON  new_value)
      {
        if (flagHasactualGateArrival)
          {
          }
        flagHasactualGateArrival = true;
        storeactualGateArrival = new_value;
      }
    public void unsetactualGateArrival()
      {
        if (flagHasactualGateArrival)
          {
          }
        flagHasactualGateArrival = false;
      }
    public void setflightPlanPlannedArrival(FlightStatsTimesJSON  new_value)
      {
        if (flagHasflightPlanPlannedArrival)
          {
          }
        flagHasflightPlanPlannedArrival = true;
        storeflightPlanPlannedArrival = new_value;
      }
    public void unsetflightPlanPlannedArrival()
      {
        if (flagHasflightPlanPlannedArrival)
          {
          }
        flagHasflightPlanPlannedArrival = false;
      }
    public void setestimatedRunwayArrival(FlightStatsTimesJSON  new_value)
      {
        if (flagHasestimatedRunwayArrival)
          {
          }
        flagHasestimatedRunwayArrival = true;
        storeestimatedRunwayArrival = new_value;
      }
    public void unsetestimatedRunwayArrival()
      {
        if (flagHasestimatedRunwayArrival)
          {
          }
        flagHasestimatedRunwayArrival = false;
      }
    public void setactualRunwayArrival(FlightStatsTimesJSON  new_value)
      {
        if (flagHasactualRunwayArrival)
          {
          }
        flagHasactualRunwayArrival = true;
        storeactualRunwayArrival = new_value;
      }
    public void unsetactualRunwayArrival()
      {
        if (flagHasactualRunwayArrival)
          {
          }
        flagHasactualRunwayArrival = false;
      }

    public virtual void extraFlightStatsOperationalTimesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatsOperationalTimesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatsOperationalTimesLookup(key);
        if (old_field == null)
          {
            extraFlightStatsOperationalTimesAppendPair(key, new_component);
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
        if (flagHaspublishedDeparture)
          {
            handler.start_pair("publishedDeparture");
            if (partial_allowed)
                storepublishedDeparture.write_partial_as_json(handler);
            else
                storepublishedDeparture.write_as_json(handler);
          }
        if (flagHaspublishedArrival)
          {
            handler.start_pair("publishedArrival");
            if (partial_allowed)
                storepublishedArrival.write_partial_as_json(handler);
            else
                storepublishedArrival.write_as_json(handler);
          }
        if (flagHasscheduledGateDeparture)
          {
            handler.start_pair("scheduledGateDeparture");
            if (partial_allowed)
                storescheduledGateDeparture.write_partial_as_json(handler);
            else
                storescheduledGateDeparture.write_as_json(handler);
          }
        if (flagHasestimatedGateDeparture)
          {
            handler.start_pair("estimatedGateDeparture");
            if (partial_allowed)
                storeestimatedGateDeparture.write_partial_as_json(handler);
            else
                storeestimatedGateDeparture.write_as_json(handler);
          }
        if (flagHasactualGateDeparture)
          {
            handler.start_pair("actualGateDeparture");
            if (partial_allowed)
                storeactualGateDeparture.write_partial_as_json(handler);
            else
                storeactualGateDeparture.write_as_json(handler);
          }
        if (flagHasflightPlanPlannedDeparture)
          {
            handler.start_pair("flightPlanPlannedDeparture");
            if (partial_allowed)
                storeflightPlanPlannedDeparture.write_partial_as_json(handler);
            else
                storeflightPlanPlannedDeparture.write_as_json(handler);
          }
        if (flagHasestimatedRunwayDeparture)
          {
            handler.start_pair("estimatedRunwayDeparture");
            if (partial_allowed)
                storeestimatedRunwayDeparture.write_partial_as_json(handler);
            else
                storeestimatedRunwayDeparture.write_as_json(handler);
          }
        if (flagHasactualRunwayDeparture)
          {
            handler.start_pair("actualRunwayDeparture");
            if (partial_allowed)
                storeactualRunwayDeparture.write_partial_as_json(handler);
            else
                storeactualRunwayDeparture.write_as_json(handler);
          }
        if (flagHasscheduledGateArrival)
          {
            handler.start_pair("scheduledGateArrival");
            if (partial_allowed)
                storescheduledGateArrival.write_partial_as_json(handler);
            else
                storescheduledGateArrival.write_as_json(handler);
          }
        if (flagHasestimatedGateArrival)
          {
            handler.start_pair("estimatedGateArrival");
            if (partial_allowed)
                storeestimatedGateArrival.write_partial_as_json(handler);
            else
                storeestimatedGateArrival.write_as_json(handler);
          }
        if (flagHasactualGateArrival)
          {
            handler.start_pair("actualGateArrival");
            if (partial_allowed)
                storeactualGateArrival.write_partial_as_json(handler);
            else
                storeactualGateArrival.write_as_json(handler);
          }
        if (flagHasflightPlanPlannedArrival)
          {
            handler.start_pair("flightPlanPlannedArrival");
            if (partial_allowed)
                storeflightPlanPlannedArrival.write_partial_as_json(handler);
            else
                storeflightPlanPlannedArrival.write_as_json(handler);
          }
        if (flagHasestimatedRunwayArrival)
          {
            handler.start_pair("estimatedRunwayArrival");
            if (partial_allowed)
                storeestimatedRunwayArrival.write_partial_as_json(handler);
            else
                storeestimatedRunwayArrival.write_as_json(handler);
          }
        if (flagHasactualRunwayArrival)
          {
            handler.start_pair("actualRunwayArrival");
            if (partial_allowed)
                storeactualRunwayArrival.write_partial_as_json(handler);
            else
                storeactualRunwayArrival.write_as_json(handler);
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

    public static FlightStatsOperationalTimesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsOperationalTimesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsOperationalTimes", ignore_extras);
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
    public static FlightStatsOperationalTimesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsOperationalTimesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsOperationalTimesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsOperationalTimes", ignore_extras);
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
    public static FlightStatsOperationalTimesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsOperationalTimesJSON from_text(string text, bool ignore_extras)
      {
        FlightStatsOperationalTimesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsOperationalTimes", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatsOperationalTimesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatsOperationalTimesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatsOperationalTimesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsOperationalTimes", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorpublishedDeparture;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorpublishedArrival;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorscheduledGateDeparture;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorestimatedGateDeparture;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratoractualGateDeparture;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorflightPlanPlannedDeparture;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorestimatedRunwayDeparture;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratoractualRunwayDeparture;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorscheduledGateArrival;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorestimatedGateArrival;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratoractualGateArrival;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorflightPlanPlannedArrival;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorestimatedRunwayArrival;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratoractualRunwayArrival;
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
            FlightStatsOperationalTimesJSON result = new FlightStatsOperationalTimesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatsOperationalTimesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatsOperationalTimesJSON result)
          {
            if (fieldGeneratorpublishedDeparture.have_value)
              {
                result.setpublishedDeparture(fieldGeneratorpublishedDeparture.value);
                fieldGeneratorpublishedDeparture.have_value = false;
              }
            if (fieldGeneratorpublishedArrival.have_value)
              {
                result.setpublishedArrival(fieldGeneratorpublishedArrival.value);
                fieldGeneratorpublishedArrival.have_value = false;
              }
            if (fieldGeneratorscheduledGateDeparture.have_value)
              {
                result.setscheduledGateDeparture(fieldGeneratorscheduledGateDeparture.value);
                fieldGeneratorscheduledGateDeparture.have_value = false;
              }
            if (fieldGeneratorestimatedGateDeparture.have_value)
              {
                result.setestimatedGateDeparture(fieldGeneratorestimatedGateDeparture.value);
                fieldGeneratorestimatedGateDeparture.have_value = false;
              }
            if (fieldGeneratoractualGateDeparture.have_value)
              {
                result.setactualGateDeparture(fieldGeneratoractualGateDeparture.value);
                fieldGeneratoractualGateDeparture.have_value = false;
              }
            if (fieldGeneratorflightPlanPlannedDeparture.have_value)
              {
                result.setflightPlanPlannedDeparture(fieldGeneratorflightPlanPlannedDeparture.value);
                fieldGeneratorflightPlanPlannedDeparture.have_value = false;
              }
            if (fieldGeneratorestimatedRunwayDeparture.have_value)
              {
                result.setestimatedRunwayDeparture(fieldGeneratorestimatedRunwayDeparture.value);
                fieldGeneratorestimatedRunwayDeparture.have_value = false;
              }
            if (fieldGeneratoractualRunwayDeparture.have_value)
              {
                result.setactualRunwayDeparture(fieldGeneratoractualRunwayDeparture.value);
                fieldGeneratoractualRunwayDeparture.have_value = false;
              }
            if (fieldGeneratorscheduledGateArrival.have_value)
              {
                result.setscheduledGateArrival(fieldGeneratorscheduledGateArrival.value);
                fieldGeneratorscheduledGateArrival.have_value = false;
              }
            if (fieldGeneratorestimatedGateArrival.have_value)
              {
                result.setestimatedGateArrival(fieldGeneratorestimatedGateArrival.value);
                fieldGeneratorestimatedGateArrival.have_value = false;
              }
            if (fieldGeneratoractualGateArrival.have_value)
              {
                result.setactualGateArrival(fieldGeneratoractualGateArrival.value);
                fieldGeneratoractualGateArrival.have_value = false;
              }
            if (fieldGeneratorflightPlanPlannedArrival.have_value)
              {
                result.setflightPlanPlannedArrival(fieldGeneratorflightPlanPlannedArrival.value);
                fieldGeneratorflightPlanPlannedArrival.have_value = false;
              }
            if (fieldGeneratorestimatedRunwayArrival.have_value)
              {
                result.setestimatedRunwayArrival(fieldGeneratorestimatedRunwayArrival.value);
                fieldGeneratorestimatedRunwayArrival.have_value = false;
              }
            if (fieldGeneratoractualRunwayArrival.have_value)
              {
                result.setactualRunwayArrival(fieldGeneratoractualRunwayArrival.value);
                fieldGeneratoractualRunwayArrival.have_value = false;
              }
          }
        protected abstract void handle_result(FlightStatsOperationalTimesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    if (String.Compare(field_name, 1, "ctual", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'G':
                                if (String.Compare(field_name, 7, "ate", 0, 3, false) == 0)
                                  {
                                    switch (field_name[10])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 11, "rrival", 0, 6, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratoractualGateArrival;
                                            break;
                                        case 'D':
                                            if ((String.Compare(field_name, 11, "eparture", 0, 8, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratoractualGateDeparture;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'R':
                                if (String.Compare(field_name, 7, "unway", 0, 5, false) == 0)
                                  {
                                    switch (field_name[12])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 13, "rrival", 0, 6, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratoractualRunwayArrival;
                                            break;
                                        case 'D':
                                            if ((String.Compare(field_name, 13, "eparture", 0, 8, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratoractualRunwayDeparture;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'e':
                    if (String.Compare(field_name, 1, "stimated", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'G':
                                if (String.Compare(field_name, 10, "ate", 0, 3, false) == 0)
                                  {
                                    switch (field_name[13])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 14, "rrival", 0, 6, false) == 0) && (field_name.Length == 20))
                                                return fieldGeneratorestimatedGateArrival;
                                            break;
                                        case 'D':
                                            if ((String.Compare(field_name, 14, "eparture", 0, 8, false) == 0) && (field_name.Length == 22))
                                                return fieldGeneratorestimatedGateDeparture;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'R':
                                if (String.Compare(field_name, 10, "unway", 0, 5, false) == 0)
                                  {
                                    switch (field_name[15])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 16, "rrival", 0, 6, false) == 0) && (field_name.Length == 22))
                                                return fieldGeneratorestimatedRunwayArrival;
                                            break;
                                        case 'D':
                                            if ((String.Compare(field_name, 16, "eparture", 0, 8, false) == 0) && (field_name.Length == 24))
                                                return fieldGeneratorestimatedRunwayDeparture;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'f':
                    if (String.Compare(field_name, 1, "lightPlanPlanned", 0, 16, false) == 0)
                      {
                        switch (field_name[17])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 18, "rrival", 0, 6, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorflightPlanPlannedArrival;
                                break;
                            case 'D':
                                if ((String.Compare(field_name, 18, "eparture", 0, 8, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorflightPlanPlannedDeparture;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'p':
                    if (String.Compare(field_name, 1, "ublished", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 10, "rrival", 0, 6, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorpublishedArrival;
                                break;
                            case 'D':
                                if ((String.Compare(field_name, 10, "eparture", 0, 8, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorpublishedDeparture;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 's':
                    if (String.Compare(field_name, 1, "cheduledGate", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 14, "rrival", 0, 6, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorscheduledGateArrival;
                                break;
                            case 'D':
                                if ((String.Compare(field_name, 14, "eparture", 0, 8, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorscheduledGateDeparture;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorpublishedDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"publishedDeparture\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratorpublishedArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"publishedArrival\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratorscheduledGateDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"scheduledGateDeparture\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratorestimatedGateDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"estimatedGateDeparture\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratoractualGateDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"actualGateDeparture\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratorflightPlanPlannedDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"flightPlanPlannedDeparture\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratorestimatedRunwayDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"estimatedRunwayDeparture\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratoractualRunwayDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"actualRunwayDeparture\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratorscheduledGateArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"scheduledGateArrival\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratorestimatedGateArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"estimatedGateArrival\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratoractualGateArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"actualGateArrival\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratorflightPlanPlannedArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"flightPlanPlannedArrival\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratorestimatedRunwayArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"estimatedRunwayArrival\" of the FlightStatsOperationalTimes class", ignore_extras);
            fieldGeneratoractualRunwayArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"actualRunwayArrival\" of the FlightStatsOperationalTimes class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatsOperationalTimes class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorpublishedDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"publishedDeparture\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratorpublishedArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"publishedArrival\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratorscheduledGateDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"scheduledGateDeparture\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratorestimatedGateDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"estimatedGateDeparture\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratoractualGateDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"actualGateDeparture\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratorflightPlanPlannedDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"flightPlanPlannedDeparture\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratorestimatedRunwayDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"estimatedRunwayDeparture\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratoractualRunwayDeparture = new FlightStatsTimesJSON.HoldingGenerator("field \"actualRunwayDeparture\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratorscheduledGateArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"scheduledGateArrival\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratorestimatedGateArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"estimatedGateArrival\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratoractualGateArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"actualGateArrival\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratorflightPlanPlannedArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"flightPlanPlannedArrival\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratorestimatedRunwayArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"estimatedRunwayArrival\" of the FlightStatsOperationalTimes class", false);
            fieldGeneratoractualRunwayArrival = new FlightStatsTimesJSON.HoldingGenerator("field \"actualRunwayArrival\" of the FlightStatsOperationalTimes class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatsOperationalTimes class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorpublishedDeparture.reset();
            fieldGeneratorpublishedArrival.reset();
            fieldGeneratorscheduledGateDeparture.reset();
            fieldGeneratorestimatedGateDeparture.reset();
            fieldGeneratoractualGateDeparture.reset();
            fieldGeneratorflightPlanPlannedDeparture.reset();
            fieldGeneratorestimatedRunwayDeparture.reset();
            fieldGeneratoractualRunwayDeparture.reset();
            fieldGeneratorscheduledGateArrival.reset();
            fieldGeneratorestimatedGateArrival.reset();
            fieldGeneratoractualGateArrival.reset();
            fieldGeneratorflightPlanPlannedArrival.reset();
            fieldGeneratorestimatedRunwayArrival.reset();
            fieldGeneratoractualRunwayArrival.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorpublishedDeparture.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorpublishedArrival.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorscheduledGateDeparture.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorestimatedGateDeparture.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratoractualGateDeparture.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorflightPlanPlannedDeparture.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorestimatedRunwayDeparture.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratoractualRunwayDeparture.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorscheduledGateArrival.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorestimatedGateArrival.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratoractualGateArrival.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorflightPlanPlannedArrival.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorestimatedRunwayArrival.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratoractualRunwayArrival.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorpublishedDeparture.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorpublishedArrival.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorscheduledGateDeparture.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorestimatedGateDeparture.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratoractualGateDeparture.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorflightPlanPlannedDeparture.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorestimatedRunwayDeparture.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratoractualRunwayDeparture.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorscheduledGateArrival.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorestimatedGateArrival.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratoractualGateArrival.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorflightPlanPlannedArrival.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorestimatedRunwayArrival.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratoractualRunwayArrival.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatsOperationalTimesJSON  result)
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
        public FlightStatsOperationalTimesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatsOperationalTimesJSON  result)
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
    protected virtual void handle_result(List<FlightStatsOperationalTimesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatsOperationalTimesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatsOperationalTimesJSON>();
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
    public List<FlightStatsOperationalTimesJSON> value;
  };
  };
