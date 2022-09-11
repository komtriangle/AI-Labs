/* file "OpenHoursSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class OpenHoursSpecJSON : JSONBase
  {
    private bool flagHasOpenNow;
    private bool storeOpenNow;
    private bool flagHasOpen24Hrs;
    private bool storeOpen24Hrs;
    private bool flagHasOpenEveryday;
    private bool storeOpenEveryday;
    private bool flagHasOpenMonday;
    private bool storeOpenMonday;
    private bool flagHasOpenTuesday;
    private bool storeOpenTuesday;
    private bool flagHasOpenWednesday;
    private bool storeOpenWednesday;
    private bool flagHasOpenThursday;
    private bool storeOpenThursday;
    private bool flagHasOpenFriday;
    private bool storeOpenFriday;
    private bool flagHasOpenSaturday;
    private bool storeOpenSaturday;
    private bool flagHasOpenSunday;
    private bool storeOpenSunday;
    private bool flagHasOpenAfterTime;
    private bool storeOpenAfterTime;
    private bool flagHasOpenBeforeTime;
    private bool storeOpenBeforeTime;
    private bool flagHasOpenTimeMentioned;
    private bool storeOpenTimeMentioned;
    private bool flagHasStartDateAndTime;
    private DateAndOrTimeJSON  storeStartDateAndTime;
    private bool flagHasEndDateAndTime;
    private DateAndOrTimeJSON  storeEndDateAndTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONOpenNow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenNow of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenNow(the_bool);
      }


    private void  fromJSONOpen24Hrs(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Open24Hrs of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpen24Hrs(the_bool);
      }


    private void  fromJSONOpenEveryday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenEveryday of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenEveryday(the_bool);
      }


    private void  fromJSONOpenMonday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenMonday of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenMonday(the_bool);
      }


    private void  fromJSONOpenTuesday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenTuesday of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenTuesday(the_bool);
      }


    private void  fromJSONOpenWednesday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenWednesday of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenWednesday(the_bool);
      }


    private void  fromJSONOpenThursday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenThursday of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenThursday(the_bool);
      }


    private void  fromJSONOpenFriday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenFriday of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenFriday(the_bool);
      }


    private void  fromJSONOpenSaturday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenSaturday of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenSaturday(the_bool);
      }


    private void  fromJSONOpenSunday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenSunday of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenSunday(the_bool);
      }


    private void  fromJSONOpenAfterTime(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenAfterTime of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenAfterTime(the_bool);
      }


    private void  fromJSONOpenBeforeTime(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenBeforeTime of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenBeforeTime(the_bool);
      }


    private void  fromJSONOpenTimeMentioned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenTimeMentioned of OpenHoursSpecJSON is not true for false.");
              }
          }
        setOpenTimeMentioned(the_bool);
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


    public OpenHoursSpecJSON()
      {
        flagHasOpenNow = false;
        flagHasOpen24Hrs = false;
        flagHasOpenEveryday = false;
        flagHasOpenMonday = false;
        flagHasOpenTuesday = false;
        flagHasOpenWednesday = false;
        flagHasOpenThursday = false;
        flagHasOpenFriday = false;
        flagHasOpenSaturday = false;
        flagHasOpenSunday = false;
        flagHasOpenAfterTime = false;
        flagHasOpenBeforeTime = false;
        flagHasOpenTimeMentioned = false;
        flagHasStartDateAndTime = false;
        flagHasEndDateAndTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasOpenNow()
      {
        return flagHasOpenNow;
      }

    public bool  getOpenNow()
      {
        Debug.Assert(flagHasOpenNow);
        return storeOpenNow;
      }

    public bool  hasOpen24Hrs()
      {
        return flagHasOpen24Hrs;
      }

    public bool  getOpen24Hrs()
      {
        Debug.Assert(flagHasOpen24Hrs);
        return storeOpen24Hrs;
      }

    public bool  hasOpenEveryday()
      {
        return flagHasOpenEveryday;
      }

    public bool  getOpenEveryday()
      {
        Debug.Assert(flagHasOpenEveryday);
        return storeOpenEveryday;
      }

    public bool  hasOpenMonday()
      {
        return flagHasOpenMonday;
      }

    public bool  getOpenMonday()
      {
        Debug.Assert(flagHasOpenMonday);
        return storeOpenMonday;
      }

    public bool  hasOpenTuesday()
      {
        return flagHasOpenTuesday;
      }

    public bool  getOpenTuesday()
      {
        Debug.Assert(flagHasOpenTuesday);
        return storeOpenTuesday;
      }

    public bool  hasOpenWednesday()
      {
        return flagHasOpenWednesday;
      }

    public bool  getOpenWednesday()
      {
        Debug.Assert(flagHasOpenWednesday);
        return storeOpenWednesday;
      }

    public bool  hasOpenThursday()
      {
        return flagHasOpenThursday;
      }

    public bool  getOpenThursday()
      {
        Debug.Assert(flagHasOpenThursday);
        return storeOpenThursday;
      }

    public bool  hasOpenFriday()
      {
        return flagHasOpenFriday;
      }

    public bool  getOpenFriday()
      {
        Debug.Assert(flagHasOpenFriday);
        return storeOpenFriday;
      }

    public bool  hasOpenSaturday()
      {
        return flagHasOpenSaturday;
      }

    public bool  getOpenSaturday()
      {
        Debug.Assert(flagHasOpenSaturday);
        return storeOpenSaturday;
      }

    public bool  hasOpenSunday()
      {
        return flagHasOpenSunday;
      }

    public bool  getOpenSunday()
      {
        Debug.Assert(flagHasOpenSunday);
        return storeOpenSunday;
      }

    public bool  hasOpenAfterTime()
      {
        return flagHasOpenAfterTime;
      }

    public bool  getOpenAfterTime()
      {
        Debug.Assert(flagHasOpenAfterTime);
        return storeOpenAfterTime;
      }

    public bool  hasOpenBeforeTime()
      {
        return flagHasOpenBeforeTime;
      }

    public bool  getOpenBeforeTime()
      {
        Debug.Assert(flagHasOpenBeforeTime);
        return storeOpenBeforeTime;
      }

    public bool  hasOpenTimeMentioned()
      {
        return flagHasOpenTimeMentioned;
      }

    public bool  getOpenTimeMentioned()
      {
        Debug.Assert(flagHasOpenTimeMentioned);
        return storeOpenTimeMentioned;
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


    public virtual int extraOpenHoursSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOpenHoursSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOpenHoursSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOpenHoursSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setOpenNow(bool new_value)
      {
        flagHasOpenNow = true;
        storeOpenNow = new_value;
      }
    public void unsetOpenNow()
      {
        flagHasOpenNow = false;
      }
    public void setOpen24Hrs(bool new_value)
      {
        flagHasOpen24Hrs = true;
        storeOpen24Hrs = new_value;
      }
    public void unsetOpen24Hrs()
      {
        flagHasOpen24Hrs = false;
      }
    public void setOpenEveryday(bool new_value)
      {
        flagHasOpenEveryday = true;
        storeOpenEveryday = new_value;
      }
    public void unsetOpenEveryday()
      {
        flagHasOpenEveryday = false;
      }
    public void setOpenMonday(bool new_value)
      {
        flagHasOpenMonday = true;
        storeOpenMonday = new_value;
      }
    public void unsetOpenMonday()
      {
        flagHasOpenMonday = false;
      }
    public void setOpenTuesday(bool new_value)
      {
        flagHasOpenTuesday = true;
        storeOpenTuesday = new_value;
      }
    public void unsetOpenTuesday()
      {
        flagHasOpenTuesday = false;
      }
    public void setOpenWednesday(bool new_value)
      {
        flagHasOpenWednesday = true;
        storeOpenWednesday = new_value;
      }
    public void unsetOpenWednesday()
      {
        flagHasOpenWednesday = false;
      }
    public void setOpenThursday(bool new_value)
      {
        flagHasOpenThursday = true;
        storeOpenThursday = new_value;
      }
    public void unsetOpenThursday()
      {
        flagHasOpenThursday = false;
      }
    public void setOpenFriday(bool new_value)
      {
        flagHasOpenFriday = true;
        storeOpenFriday = new_value;
      }
    public void unsetOpenFriday()
      {
        flagHasOpenFriday = false;
      }
    public void setOpenSaturday(bool new_value)
      {
        flagHasOpenSaturday = true;
        storeOpenSaturday = new_value;
      }
    public void unsetOpenSaturday()
      {
        flagHasOpenSaturday = false;
      }
    public void setOpenSunday(bool new_value)
      {
        flagHasOpenSunday = true;
        storeOpenSunday = new_value;
      }
    public void unsetOpenSunday()
      {
        flagHasOpenSunday = false;
      }
    public void setOpenAfterTime(bool new_value)
      {
        flagHasOpenAfterTime = true;
        storeOpenAfterTime = new_value;
      }
    public void unsetOpenAfterTime()
      {
        flagHasOpenAfterTime = false;
      }
    public void setOpenBeforeTime(bool new_value)
      {
        flagHasOpenBeforeTime = true;
        storeOpenBeforeTime = new_value;
      }
    public void unsetOpenBeforeTime()
      {
        flagHasOpenBeforeTime = false;
      }
    public void setOpenTimeMentioned(bool new_value)
      {
        flagHasOpenTimeMentioned = true;
        storeOpenTimeMentioned = new_value;
      }
    public void unsetOpenTimeMentioned()
      {
        flagHasOpenTimeMentioned = false;
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

    public virtual void extraOpenHoursSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOpenHoursSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOpenHoursSpecLookup(key);
        if (old_field == null)
          {
            extraOpenHoursSpecAppendPair(key, new_component);
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
        if (flagHasOpenNow)
          {
            handler.start_pair("OpenNow");
            handler.boolean_value(storeOpenNow);
          }
        if (flagHasOpen24Hrs)
          {
            handler.start_pair("Open24Hrs");
            handler.boolean_value(storeOpen24Hrs);
          }
        if (flagHasOpenEveryday)
          {
            handler.start_pair("OpenEveryday");
            handler.boolean_value(storeOpenEveryday);
          }
        if (flagHasOpenMonday)
          {
            handler.start_pair("OpenMonday");
            handler.boolean_value(storeOpenMonday);
          }
        if (flagHasOpenTuesday)
          {
            handler.start_pair("OpenTuesday");
            handler.boolean_value(storeOpenTuesday);
          }
        if (flagHasOpenWednesday)
          {
            handler.start_pair("OpenWednesday");
            handler.boolean_value(storeOpenWednesday);
          }
        if (flagHasOpenThursday)
          {
            handler.start_pair("OpenThursday");
            handler.boolean_value(storeOpenThursday);
          }
        if (flagHasOpenFriday)
          {
            handler.start_pair("OpenFriday");
            handler.boolean_value(storeOpenFriday);
          }
        if (flagHasOpenSaturday)
          {
            handler.start_pair("OpenSaturday");
            handler.boolean_value(storeOpenSaturday);
          }
        if (flagHasOpenSunday)
          {
            handler.start_pair("OpenSunday");
            handler.boolean_value(storeOpenSunday);
          }
        if (flagHasOpenAfterTime)
          {
            handler.start_pair("OpenAfterTime");
            handler.boolean_value(storeOpenAfterTime);
          }
        if (flagHasOpenBeforeTime)
          {
            handler.start_pair("OpenBeforeTime");
            handler.boolean_value(storeOpenBeforeTime);
          }
        if (flagHasOpenTimeMentioned)
          {
            handler.start_pair("OpenTimeMentioned");
            handler.boolean_value(storeOpenTimeMentioned);
          }
        if (flagHasStartDateAndTime)
          {
            handler.start_pair("StartDateAndTime");
            if (partial_allowed)
                storeStartDateAndTime.write_partial_as_json(handler);
            else
                storeStartDateAndTime.write_as_json(handler);
          }
        if (flagHasEndDateAndTime)
          {
            handler.start_pair("EndDateAndTime");
            if (partial_allowed)
                storeEndDateAndTime.write_partial_as_json(handler);
            else
                storeEndDateAndTime.write_as_json(handler);
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

    public static OpenHoursSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OpenHoursSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OpenHoursSpec", ignore_extras);
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
    public static OpenHoursSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OpenHoursSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OpenHoursSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OpenHoursSpec", ignore_extras);
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
    public static OpenHoursSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OpenHoursSpecJSON from_text(string text, bool ignore_extras)
      {
        OpenHoursSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OpenHoursSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OpenHoursSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OpenHoursSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OpenHoursSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OpenHoursSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorOpenNow;
        private JSONHoldingBooleanGenerator fieldGeneratorOpen24Hrs;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenEveryday;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenMonday;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenTuesday;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenWednesday;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenThursday;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenFriday;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenSaturday;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenSunday;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenAfterTime;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenBeforeTime;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenTimeMentioned;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDateAndTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndDateAndTime;
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
            OpenHoursSpecJSON result = new OpenHoursSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOpenHoursSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OpenHoursSpecJSON result)
          {
            if (fieldGeneratorOpenNow.have_value)
              {
                result.setOpenNow(fieldGeneratorOpenNow.value);
                fieldGeneratorOpenNow.have_value = false;
              }
            if (fieldGeneratorOpen24Hrs.have_value)
              {
                result.setOpen24Hrs(fieldGeneratorOpen24Hrs.value);
                fieldGeneratorOpen24Hrs.have_value = false;
              }
            if (fieldGeneratorOpenEveryday.have_value)
              {
                result.setOpenEveryday(fieldGeneratorOpenEveryday.value);
                fieldGeneratorOpenEveryday.have_value = false;
              }
            if (fieldGeneratorOpenMonday.have_value)
              {
                result.setOpenMonday(fieldGeneratorOpenMonday.value);
                fieldGeneratorOpenMonday.have_value = false;
              }
            if (fieldGeneratorOpenTuesday.have_value)
              {
                result.setOpenTuesday(fieldGeneratorOpenTuesday.value);
                fieldGeneratorOpenTuesday.have_value = false;
              }
            if (fieldGeneratorOpenWednesday.have_value)
              {
                result.setOpenWednesday(fieldGeneratorOpenWednesday.value);
                fieldGeneratorOpenWednesday.have_value = false;
              }
            if (fieldGeneratorOpenThursday.have_value)
              {
                result.setOpenThursday(fieldGeneratorOpenThursday.value);
                fieldGeneratorOpenThursday.have_value = false;
              }
            if (fieldGeneratorOpenFriday.have_value)
              {
                result.setOpenFriday(fieldGeneratorOpenFriday.value);
                fieldGeneratorOpenFriday.have_value = false;
              }
            if (fieldGeneratorOpenSaturday.have_value)
              {
                result.setOpenSaturday(fieldGeneratorOpenSaturday.value);
                fieldGeneratorOpenSaturday.have_value = false;
              }
            if (fieldGeneratorOpenSunday.have_value)
              {
                result.setOpenSunday(fieldGeneratorOpenSunday.value);
                fieldGeneratorOpenSunday.have_value = false;
              }
            if (fieldGeneratorOpenAfterTime.have_value)
              {
                result.setOpenAfterTime(fieldGeneratorOpenAfterTime.value);
                fieldGeneratorOpenAfterTime.have_value = false;
              }
            if (fieldGeneratorOpenBeforeTime.have_value)
              {
                result.setOpenBeforeTime(fieldGeneratorOpenBeforeTime.value);
                fieldGeneratorOpenBeforeTime.have_value = false;
              }
            if (fieldGeneratorOpenTimeMentioned.have_value)
              {
                result.setOpenTimeMentioned(fieldGeneratorOpenTimeMentioned.value);
                fieldGeneratorOpenTimeMentioned.have_value = false;
              }
            if (fieldGeneratorStartDateAndTime.have_value)
              {
                result.setStartDateAndTime(fieldGeneratorStartDateAndTime.value);
                fieldGeneratorStartDateAndTime.have_value = false;
              }
            if (fieldGeneratorEndDateAndTime.have_value)
              {
                result.setEndDateAndTime(fieldGeneratorEndDateAndTime.value);
                fieldGeneratorEndDateAndTime.have_value = false;
              }
          }
        protected abstract void handle_result(OpenHoursSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ndDateAndTime", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorEndDateAndTime;
                    break;
                case 'O':
                    if (String.Compare(field_name, 1, "pen", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case '2':
                                if ((String.Compare(field_name, 5, "4Hrs", 0, 4, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorOpen24Hrs;
                                break;
                            case 'A':
                                if ((String.Compare(field_name, 5, "fterTime", 0, 8, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorOpenAfterTime;
                                break;
                            case 'B':
                                if ((String.Compare(field_name, 5, "eforeTime", 0, 9, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorOpenBeforeTime;
                                break;
                            case 'E':
                                if ((String.Compare(field_name, 5, "veryday", 0, 7, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorOpenEveryday;
                                break;
                            case 'F':
                                if ((String.Compare(field_name, 5, "riday", 0, 5, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorOpenFriday;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 5, "onday", 0, 5, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorOpenMonday;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 5, "ow", 0, 2, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorOpenNow;
                                break;
                            case 'S':
                                switch (field_name[5])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 6, "turday", 0, 6, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorOpenSaturday;
                                        break;
                                    case 'u':
                                        if ((String.Compare(field_name, 6, "nday", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorOpenSunday;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'T':
                                switch (field_name[5])
                                  {
                                    case 'h':
                                        if ((String.Compare(field_name, 6, "ursday", 0, 6, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorOpenThursday;
                                        break;
                                    case 'i':
                                        if ((String.Compare(field_name, 6, "meMentioned", 0, 11, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorOpenTimeMentioned;
                                        break;
                                    case 'u':
                                        if ((String.Compare(field_name, 6, "esday", 0, 5, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorOpenTuesday;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 5, "ednesday", 0, 8, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorOpenWednesday;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartDateAndTime", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorStartDateAndTime;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorOpenNow = new JSONHoldingBooleanGenerator("field \"OpenNow\" of the OpenHoursSpec class");
            fieldGeneratorOpen24Hrs = new JSONHoldingBooleanGenerator("field \"Open24Hrs\" of the OpenHoursSpec class");
            fieldGeneratorOpenEveryday = new JSONHoldingBooleanGenerator("field \"OpenEveryday\" of the OpenHoursSpec class");
            fieldGeneratorOpenMonday = new JSONHoldingBooleanGenerator("field \"OpenMonday\" of the OpenHoursSpec class");
            fieldGeneratorOpenTuesday = new JSONHoldingBooleanGenerator("field \"OpenTuesday\" of the OpenHoursSpec class");
            fieldGeneratorOpenWednesday = new JSONHoldingBooleanGenerator("field \"OpenWednesday\" of the OpenHoursSpec class");
            fieldGeneratorOpenThursday = new JSONHoldingBooleanGenerator("field \"OpenThursday\" of the OpenHoursSpec class");
            fieldGeneratorOpenFriday = new JSONHoldingBooleanGenerator("field \"OpenFriday\" of the OpenHoursSpec class");
            fieldGeneratorOpenSaturday = new JSONHoldingBooleanGenerator("field \"OpenSaturday\" of the OpenHoursSpec class");
            fieldGeneratorOpenSunday = new JSONHoldingBooleanGenerator("field \"OpenSunday\" of the OpenHoursSpec class");
            fieldGeneratorOpenAfterTime = new JSONHoldingBooleanGenerator("field \"OpenAfterTime\" of the OpenHoursSpec class");
            fieldGeneratorOpenBeforeTime = new JSONHoldingBooleanGenerator("field \"OpenBeforeTime\" of the OpenHoursSpec class");
            fieldGeneratorOpenTimeMentioned = new JSONHoldingBooleanGenerator("field \"OpenTimeMentioned\" of the OpenHoursSpec class");
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the OpenHoursSpec class", ignore_extras);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the OpenHoursSpec class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OpenHoursSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorOpenNow = new JSONHoldingBooleanGenerator("field \"OpenNow\" of the OpenHoursSpec class");
            fieldGeneratorOpen24Hrs = new JSONHoldingBooleanGenerator("field \"Open24Hrs\" of the OpenHoursSpec class");
            fieldGeneratorOpenEveryday = new JSONHoldingBooleanGenerator("field \"OpenEveryday\" of the OpenHoursSpec class");
            fieldGeneratorOpenMonday = new JSONHoldingBooleanGenerator("field \"OpenMonday\" of the OpenHoursSpec class");
            fieldGeneratorOpenTuesday = new JSONHoldingBooleanGenerator("field \"OpenTuesday\" of the OpenHoursSpec class");
            fieldGeneratorOpenWednesday = new JSONHoldingBooleanGenerator("field \"OpenWednesday\" of the OpenHoursSpec class");
            fieldGeneratorOpenThursday = new JSONHoldingBooleanGenerator("field \"OpenThursday\" of the OpenHoursSpec class");
            fieldGeneratorOpenFriday = new JSONHoldingBooleanGenerator("field \"OpenFriday\" of the OpenHoursSpec class");
            fieldGeneratorOpenSaturday = new JSONHoldingBooleanGenerator("field \"OpenSaturday\" of the OpenHoursSpec class");
            fieldGeneratorOpenSunday = new JSONHoldingBooleanGenerator("field \"OpenSunday\" of the OpenHoursSpec class");
            fieldGeneratorOpenAfterTime = new JSONHoldingBooleanGenerator("field \"OpenAfterTime\" of the OpenHoursSpec class");
            fieldGeneratorOpenBeforeTime = new JSONHoldingBooleanGenerator("field \"OpenBeforeTime\" of the OpenHoursSpec class");
            fieldGeneratorOpenTimeMentioned = new JSONHoldingBooleanGenerator("field \"OpenTimeMentioned\" of the OpenHoursSpec class");
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the OpenHoursSpec class", false);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the OpenHoursSpec class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OpenHoursSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorOpenNow.reset();
            fieldGeneratorOpen24Hrs.reset();
            fieldGeneratorOpenEveryday.reset();
            fieldGeneratorOpenMonday.reset();
            fieldGeneratorOpenTuesday.reset();
            fieldGeneratorOpenWednesday.reset();
            fieldGeneratorOpenThursday.reset();
            fieldGeneratorOpenFriday.reset();
            fieldGeneratorOpenSaturday.reset();
            fieldGeneratorOpenSunday.reset();
            fieldGeneratorOpenAfterTime.reset();
            fieldGeneratorOpenBeforeTime.reset();
            fieldGeneratorOpenTimeMentioned.reset();
            fieldGeneratorStartDateAndTime.reset();
            fieldGeneratorEndDateAndTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStartDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEndDateAndTime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStartDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEndDateAndTime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(OpenHoursSpecJSON  result)
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
        public OpenHoursSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OpenHoursSpecJSON  result)
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
    protected virtual void handle_result(List<OpenHoursSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OpenHoursSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OpenHoursSpecJSON>();
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
    public List<OpenHoursSpecJSON> value;
  };
  };
