/* file "OutlookFreeBusyPayloadJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class OutlookFreeBusyPayloadJSON : JSONBase
  {
    private bool flagHasavailabilityViewInterval;
    private BigInteger storeavailabilityViewInterval;
    private bool flagHasendTime;
    private OutlookTimeSpecifierJSON  storeendTime;
    private bool flagHasstartTime;
    private OutlookTimeSpecifierJSON  storestartTime;
    private bool flagHasschedules;
    private List< string > storeschedules;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONavailabilityViewInterval(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field availabilityViewInterval of OutlookFreeBusyPayloadJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field availabilityViewInterval of OutlookFreeBusyPayloadJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setavailabilityViewInterval(extracted_integer);
      }


    private void  fromJSONendTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OutlookTimeSpecifierJSON convert_classy = OutlookTimeSpecifierJSON.from_json(json_value, ignore_extras, true);
        setendTime(convert_classy);
      }


    private void  fromJSONstartTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OutlookTimeSpecifierJSON convert_classy = OutlookTimeSpecifierJSON.from_json(json_value, ignore_extras, true);
        setstartTime(convert_classy);
      }


    private void  fromJSONschedules(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field schedules of OutlookFreeBusyPayloadJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_schedules1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field schedules of OutlookFreeBusyPayloadJSON is not a string.");
            vector_schedules1.Add(json_string.getData());
          }
        initschedules();
        for (int num1 = 0; num1 < vector_schedules1.Count; ++num1)
            appendschedules(vector_schedules1[num1]);
        for (int num1 = 0; num1 < vector_schedules1.Count; ++num1)
          {
          }
      }


    public OutlookFreeBusyPayloadJSON()
      {
        flagHasavailabilityViewInterval = false;
        flagHasendTime = false;
        flagHasstartTime = false;
        flagHasschedules = false;
        storeschedules = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasavailabilityViewInterval()
      {
        return flagHasavailabilityViewInterval;
      }

    public BigInteger  getavailabilityViewInterval()
      {
        Debug.Assert(flagHasavailabilityViewInterval);
        return storeavailabilityViewInterval;
      }

    public bool  hasendTime()
      {
        return flagHasendTime;
      }

    public OutlookTimeSpecifierJSON   getendTime()
      {
        Debug.Assert(flagHasendTime);
        return storeendTime;
      }

    public bool  hasstartTime()
      {
        return flagHasstartTime;
      }

    public OutlookTimeSpecifierJSON   getstartTime()
      {
        Debug.Assert(flagHasstartTime);
        return storestartTime;
      }

    public bool  hasschedules()
      {
        return flagHasschedules;
      }

    public int  countOfschedules()
      {
        Debug.Assert(flagHasschedules);
        return storeschedules.Count;
      }

    public string  elementOfschedules(int element_num)
      {
        Debug.Assert(flagHasschedules);
        return storeschedules[element_num];
      }

    public List< string >  getschedules()
      {
        Debug.Assert(flagHasschedules);
        return storeschedules;
      }


    public virtual int extraOutlookFreeBusyPayloadComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOutlookFreeBusyPayloadComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOutlookFreeBusyPayloadComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOutlookFreeBusyPayloadLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setavailabilityViewInterval(BigInteger new_value)
      {
        flagHasavailabilityViewInterval = true;
        storeavailabilityViewInterval = new_value;
      }
    public void unsetavailabilityViewInterval()
      {
        flagHasavailabilityViewInterval = false;
      }
    public void setendTime(OutlookTimeSpecifierJSON  new_value)
      {
        if (flagHasendTime)
          {
          }
        flagHasendTime = true;
        storeendTime = new_value;
      }
    public void unsetendTime()
      {
        if (flagHasendTime)
          {
          }
        flagHasendTime = false;
      }
    public void setstartTime(OutlookTimeSpecifierJSON  new_value)
      {
        if (flagHasstartTime)
          {
          }
        flagHasstartTime = true;
        storestartTime = new_value;
      }
    public void unsetstartTime()
      {
        if (flagHasstartTime)
          {
          }
        flagHasstartTime = false;
      }
    public void initschedules()
      {
        flagHasschedules = true;
        storeschedules.Clear();
      }
    public void appendschedules(string to_append)
      {
        if (!flagHasschedules)
          {
            flagHasschedules = true;
            storeschedules.Clear();
          }
        Debug.Assert(flagHasschedules);
        storeschedules.Add(to_append);
      }
    public void unsetschedules()
      {
        flagHasschedules = false;
        storeschedules.Clear();
      }

    public virtual void extraOutlookFreeBusyPayloadAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOutlookFreeBusyPayloadSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOutlookFreeBusyPayloadLookup(key);
        if (old_field == null)
          {
            extraOutlookFreeBusyPayloadAppendPair(key, new_component);
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
        if (flagHasavailabilityViewInterval)
          {
            handler.start_pair("availabilityViewInterval");
            handler.number_value(storeavailabilityViewInterval);
          }
        if (flagHasendTime)
          {
            handler.start_pair("endTime");
            if (partial_allowed)
                storeendTime.write_partial_as_json(handler);
            else
                storeendTime.write_as_json(handler);
          }
        if (flagHasstartTime)
          {
            handler.start_pair("startTime");
            if (partial_allowed)
                storestartTime.write_partial_as_json(handler);
            else
                storestartTime.write_as_json(handler);
          }
        if (flagHasschedules)
          {
            handler.start_pair("schedules");
            handler.start_array();
            for (int num1 = 0; num1 < storeschedules.Count; ++num1)
              {
                handler.string_value(storeschedules[num1]);
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

    public static OutlookFreeBusyPayloadJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookFreeBusyPayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFreeBusyPayload", ignore_extras);
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
    public static OutlookFreeBusyPayloadJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookFreeBusyPayloadJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookFreeBusyPayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFreeBusyPayload", ignore_extras);
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
    public static OutlookFreeBusyPayloadJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookFreeBusyPayloadJSON from_text(string text, bool ignore_extras)
      {
        OutlookFreeBusyPayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFreeBusyPayload", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OutlookFreeBusyPayloadJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OutlookFreeBusyPayloadJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OutlookFreeBusyPayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFreeBusyPayload", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratoravailabilityViewInterval : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratoravailabilityViewInterval(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratoravailabilityViewInterval : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratoravailabilityViewInterval(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratoravailabilityViewInterval fieldGeneratoravailabilityViewInterval;
        private OutlookTimeSpecifierJSON.HoldingGenerator fieldGeneratorendTime;
        private OutlookTimeSpecifierJSON.HoldingGenerator fieldGeneratorstartTime;
        private JSONHoldingStringArrayGenerator fieldGeneratorschedules;
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
            OutlookFreeBusyPayloadJSON result = new OutlookFreeBusyPayloadJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOutlookFreeBusyPayloadAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OutlookFreeBusyPayloadJSON result)
          {
            if (fieldGeneratoravailabilityViewInterval.have_value)
              {
                result.setavailabilityViewInterval(fieldGeneratoravailabilityViewInterval.value);
                fieldGeneratoravailabilityViewInterval.have_value = false;
              }
            if (fieldGeneratorendTime.have_value)
              {
                result.setendTime(fieldGeneratorendTime.value);
                fieldGeneratorendTime.have_value = false;
              }
            if (fieldGeneratorstartTime.have_value)
              {
                result.setstartTime(fieldGeneratorstartTime.value);
                fieldGeneratorstartTime.have_value = false;
              }
            if (fieldGeneratorschedules.have_value)
              {
                result.initschedules();
                int count = fieldGeneratorschedules.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendschedules(fieldGeneratorschedules.value[num]);
                  }
                fieldGeneratorschedules.value.Clear();
                fieldGeneratorschedules.have_value = false;
              }
          }
        protected abstract void handle_result(OutlookFreeBusyPayloadJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    if ((String.Compare(field_name, 1, "vailabilityViewInterval", 0, 23, false) == 0) && (field_name.Length == 24))
                        return fieldGeneratoravailabilityViewInterval;
                    break;
                case 'e':
                    if ((String.Compare(field_name, 1, "ndTime", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorendTime;
                    break;
                case 's':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "hedules", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorschedules;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "artTime", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorstartTime;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratoravailabilityViewInterval = new FieldHoldingGeneratoravailabilityViewInterval("field \"availabilityViewInterval\" of the OutlookFreeBusyPayload class");
            fieldGeneratorendTime = new OutlookTimeSpecifierJSON.HoldingGenerator("field \"endTime\" of the OutlookFreeBusyPayload class", ignore_extras);
            fieldGeneratorstartTime = new OutlookTimeSpecifierJSON.HoldingGenerator("field \"startTime\" of the OutlookFreeBusyPayload class", ignore_extras);
            fieldGeneratorschedules = new JSONHoldingStringArrayGenerator("field \"schedules\" of the OutlookFreeBusyPayload class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OutlookFreeBusyPayload class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratoravailabilityViewInterval = new FieldHoldingGeneratoravailabilityViewInterval("field \"availabilityViewInterval\" of the OutlookFreeBusyPayload class");
            fieldGeneratorendTime = new OutlookTimeSpecifierJSON.HoldingGenerator("field \"endTime\" of the OutlookFreeBusyPayload class", false);
            fieldGeneratorstartTime = new OutlookTimeSpecifierJSON.HoldingGenerator("field \"startTime\" of the OutlookFreeBusyPayload class", false);
            fieldGeneratorschedules = new JSONHoldingStringArrayGenerator("field \"schedules\" of the OutlookFreeBusyPayload class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OutlookFreeBusyPayload class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratoravailabilityViewInterval.reset();
            fieldGeneratorendTime.reset();
            fieldGeneratorstartTime.reset();
            fieldGeneratorschedules.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorendTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorstartTime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorendTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorstartTime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(OutlookFreeBusyPayloadJSON  result)
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
        public OutlookFreeBusyPayloadJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OutlookFreeBusyPayloadJSON  result)
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
    protected virtual void handle_result(List<OutlookFreeBusyPayloadJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OutlookFreeBusyPayloadJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OutlookFreeBusyPayloadJSON>();
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
    public List<OutlookFreeBusyPayloadJSON> value;
  };
  };
