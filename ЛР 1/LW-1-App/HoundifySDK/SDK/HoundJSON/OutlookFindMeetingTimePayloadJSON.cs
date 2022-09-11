/* file "OutlookFindMeetingTimePayloadJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class OutlookFindMeetingTimePayloadJSON : JSONBase
  {
    private bool flagHasattendees;
    private List< OutlookAttendeeBaseJSON  > storeattendees;
    private bool flagHasisOrganizerOptional;
    private bool storeisOrganizerOptional;
    private bool flagHasmaxCandidates;
    private BigInteger storemaxCandidates;
    private bool flagHasmeetingDuration;
    private string storemeetingDuration;
    private bool flagHasreturnSuggestionReasons;
    private bool storereturnSuggestionReasons;
    private bool flagHastimeConstraint;
    private OutlookTimeConstraintJSON  storetimeConstraint;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONattendees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field attendees of OutlookFindMeetingTimePayloadJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< OutlookAttendeeBaseJSON  > vector_attendees1 = new List< OutlookAttendeeBaseJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            OutlookAttendeeBaseJSON convert_classy = OutlookAttendeeBaseJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_attendees1.Add(convert_classy);
          }
        initattendees();
        for (int num1 = 0; num1 < vector_attendees1.Count; ++num1)
            appendattendees(vector_attendees1[num1]);
        for (int num1 = 0; num1 < vector_attendees1.Count; ++num1)
          {
          }
      }


    private void  fromJSONisOrganizerOptional(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field isOrganizerOptional of OutlookFindMeetingTimePayloadJSON is not true for false.");
              }
          }
        setisOrganizerOptional(the_bool);
      }


    private void  fromJSONmaxCandidates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field maxCandidates of OutlookFindMeetingTimePayloadJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field maxCandidates of OutlookFindMeetingTimePayloadJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setmaxCandidates(extracted_integer);
      }


    private void  fromJSONmeetingDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field meetingDuration of OutlookFindMeetingTimePayloadJSON is not a string.");
        setmeetingDuration(json_string.getData());
      }


    private void  fromJSONreturnSuggestionReasons(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field returnSuggestionReasons of OutlookFindMeetingTimePayloadJSON is not true for false.");
              }
          }
        setreturnSuggestionReasons(the_bool);
      }


    private void  fromJSONtimeConstraint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OutlookTimeConstraintJSON convert_classy = OutlookTimeConstraintJSON.from_json(json_value, ignore_extras, true);
        settimeConstraint(convert_classy);
      }


    public OutlookFindMeetingTimePayloadJSON()
      {
        flagHasattendees = false;
        flagHasisOrganizerOptional = false;
        flagHasmaxCandidates = false;
        flagHasmeetingDuration = false;
        flagHasreturnSuggestionReasons = false;
        flagHastimeConstraint = false;
        storeattendees = new List< OutlookAttendeeBaseJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasattendees()
      {
        return flagHasattendees;
      }

    public int  countOfattendees()
      {
        Debug.Assert(flagHasattendees);
        return storeattendees.Count;
      }

    public OutlookAttendeeBaseJSON   elementOfattendees(int element_num)
      {
        Debug.Assert(flagHasattendees);
        return storeattendees[element_num];
      }

    public List< OutlookAttendeeBaseJSON  >  getattendees()
      {
        Debug.Assert(flagHasattendees);
        return storeattendees;
      }

    public bool  hasisOrganizerOptional()
      {
        return flagHasisOrganizerOptional;
      }

    public bool  getisOrganizerOptional()
      {
        Debug.Assert(flagHasisOrganizerOptional);
        return storeisOrganizerOptional;
      }

    public bool  hasmaxCandidates()
      {
        return flagHasmaxCandidates;
      }

    public BigInteger  getmaxCandidates()
      {
        Debug.Assert(flagHasmaxCandidates);
        return storemaxCandidates;
      }

    public bool  hasmeetingDuration()
      {
        return flagHasmeetingDuration;
      }

    public string  getmeetingDuration()
      {
        Debug.Assert(flagHasmeetingDuration);
        return storemeetingDuration;
      }

    public bool  hasreturnSuggestionReasons()
      {
        return flagHasreturnSuggestionReasons;
      }

    public bool  getreturnSuggestionReasons()
      {
        Debug.Assert(flagHasreturnSuggestionReasons);
        return storereturnSuggestionReasons;
      }

    public bool  hastimeConstraint()
      {
        return flagHastimeConstraint;
      }

    public OutlookTimeConstraintJSON   gettimeConstraint()
      {
        Debug.Assert(flagHastimeConstraint);
        return storetimeConstraint;
      }


    public virtual int extraOutlookFindMeetingTimePayloadComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOutlookFindMeetingTimePayloadComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOutlookFindMeetingTimePayloadComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOutlookFindMeetingTimePayloadLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initattendees()
      {
        if (flagHasattendees)
          {
            for (int num1 = 0; num1 < storeattendees.Count; ++num1)
              {
              }
          }
        flagHasattendees = true;
        storeattendees.Clear();
      }
    public void appendattendees(OutlookAttendeeBaseJSON  to_append)
      {
        if (!flagHasattendees)
          {
            flagHasattendees = true;
            storeattendees.Clear();
          }
        Debug.Assert(flagHasattendees);
        storeattendees.Add(to_append);
      }
    public void unsetattendees()
      {
        if (flagHasattendees)
          {
            for (int num2 = 0; num2 < storeattendees.Count; ++num2)
              {
              }
          }
        flagHasattendees = false;
        storeattendees.Clear();
      }
    public void setisOrganizerOptional(bool new_value)
      {
        flagHasisOrganizerOptional = true;
        storeisOrganizerOptional = new_value;
      }
    public void unsetisOrganizerOptional()
      {
        flagHasisOrganizerOptional = false;
      }
    public void setmaxCandidates(BigInteger new_value)
      {
        flagHasmaxCandidates = true;
        storemaxCandidates = new_value;
      }
    public void unsetmaxCandidates()
      {
        flagHasmaxCandidates = false;
      }
    public void setmeetingDuration(string new_value)
      {
        flagHasmeetingDuration = true;
        storemeetingDuration = new_value;
      }
    public void unsetmeetingDuration()
      {
        flagHasmeetingDuration = false;
      }
    public void setreturnSuggestionReasons(bool new_value)
      {
        flagHasreturnSuggestionReasons = true;
        storereturnSuggestionReasons = new_value;
      }
    public void unsetreturnSuggestionReasons()
      {
        flagHasreturnSuggestionReasons = false;
      }
    public void settimeConstraint(OutlookTimeConstraintJSON  new_value)
      {
        if (flagHastimeConstraint)
          {
          }
        flagHastimeConstraint = true;
        storetimeConstraint = new_value;
      }
    public void unsettimeConstraint()
      {
        if (flagHastimeConstraint)
          {
          }
        flagHastimeConstraint = false;
      }

    public virtual void extraOutlookFindMeetingTimePayloadAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOutlookFindMeetingTimePayloadSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOutlookFindMeetingTimePayloadLookup(key);
        if (old_field == null)
          {
            extraOutlookFindMeetingTimePayloadAppendPair(key, new_component);
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
        if (flagHasattendees)
          {
            handler.start_pair("attendees");
            handler.start_array();
            for (int num1 = 0; num1 < storeattendees.Count; ++num1)
              {
                if (partial_allowed)
                    storeattendees[num1].write_partial_as_json(handler);
                else
                    storeattendees[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasisOrganizerOptional)
          {
            handler.start_pair("isOrganizerOptional");
            handler.boolean_value(storeisOrganizerOptional);
          }
        if (flagHasmaxCandidates)
          {
            handler.start_pair("maxCandidates");
            handler.number_value(storemaxCandidates);
          }
        if (flagHasmeetingDuration)
          {
            handler.start_pair("meetingDuration");
            handler.string_value(storemeetingDuration);
          }
        if (flagHasreturnSuggestionReasons)
          {
            handler.start_pair("returnSuggestionReasons");
            handler.boolean_value(storereturnSuggestionReasons);
          }
        if (flagHastimeConstraint)
          {
            handler.start_pair("timeConstraint");
            if (partial_allowed)
                storetimeConstraint.write_partial_as_json(handler);
            else
                storetimeConstraint.write_as_json(handler);
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

    public static OutlookFindMeetingTimePayloadJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookFindMeetingTimePayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFindMeetingTimePayload", ignore_extras);
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
    public static OutlookFindMeetingTimePayloadJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookFindMeetingTimePayloadJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookFindMeetingTimePayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFindMeetingTimePayload", ignore_extras);
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
    public static OutlookFindMeetingTimePayloadJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookFindMeetingTimePayloadJSON from_text(string text, bool ignore_extras)
      {
        OutlookFindMeetingTimePayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFindMeetingTimePayload", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OutlookFindMeetingTimePayloadJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OutlookFindMeetingTimePayloadJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OutlookFindMeetingTimePayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFindMeetingTimePayload", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private OutlookAttendeeBaseJSON.HoldingArrayGenerator fieldGeneratorattendees;
        private JSONHoldingBooleanGenerator fieldGeneratorisOrganizerOptional;
    private class FieldHoldingGeneratormaxCandidates : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratormaxCandidates(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratormaxCandidates : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratormaxCandidates(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratormaxCandidates fieldGeneratormaxCandidates;
        private JSONHoldingStringGenerator fieldGeneratormeetingDuration;
        private JSONHoldingBooleanGenerator fieldGeneratorreturnSuggestionReasons;
        private OutlookTimeConstraintJSON.HoldingGenerator fieldGeneratortimeConstraint;
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
            OutlookFindMeetingTimePayloadJSON result = new OutlookFindMeetingTimePayloadJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOutlookFindMeetingTimePayloadAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OutlookFindMeetingTimePayloadJSON result)
          {
            if (fieldGeneratorattendees.have_value)
              {
                result.initattendees();
                int count = fieldGeneratorattendees.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendattendees(fieldGeneratorattendees.value[num]);
                  }
                fieldGeneratorattendees.value.Clear();
                fieldGeneratorattendees.have_value = false;
              }
            if (fieldGeneratorisOrganizerOptional.have_value)
              {
                result.setisOrganizerOptional(fieldGeneratorisOrganizerOptional.value);
                fieldGeneratorisOrganizerOptional.have_value = false;
              }
            if (fieldGeneratormaxCandidates.have_value)
              {
                result.setmaxCandidates(fieldGeneratormaxCandidates.value);
                fieldGeneratormaxCandidates.have_value = false;
              }
            if (fieldGeneratormeetingDuration.have_value)
              {
                result.setmeetingDuration(fieldGeneratormeetingDuration.value);
                fieldGeneratormeetingDuration.have_value = false;
              }
            if (fieldGeneratorreturnSuggestionReasons.have_value)
              {
                result.setreturnSuggestionReasons(fieldGeneratorreturnSuggestionReasons.value);
                fieldGeneratorreturnSuggestionReasons.have_value = false;
              }
            if (fieldGeneratortimeConstraint.have_value)
              {
                result.settimeConstraint(fieldGeneratortimeConstraint.value);
                fieldGeneratortimeConstraint.have_value = false;
              }
          }
        protected abstract void handle_result(OutlookFindMeetingTimePayloadJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    if ((String.Compare(field_name, 1, "ttendees", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorattendees;
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "sOrganizerOptional", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorisOrganizerOptional;
                    break;
                case 'm':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "xCandidates", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratormaxCandidates;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "etingDuration", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratormeetingDuration;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "eturnSuggestionReasons", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorreturnSuggestionReasons;
                    break;
                case 't':
                    if ((String.Compare(field_name, 1, "imeConstraint", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratortimeConstraint;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorattendees = new OutlookAttendeeBaseJSON.HoldingArrayGenerator("field \"attendees\" of the OutlookFindMeetingTimePayload class", ignore_extras);
            fieldGeneratorisOrganizerOptional = new JSONHoldingBooleanGenerator("field \"isOrganizerOptional\" of the OutlookFindMeetingTimePayload class");
            fieldGeneratormaxCandidates = new FieldHoldingGeneratormaxCandidates("field \"maxCandidates\" of the OutlookFindMeetingTimePayload class");
            fieldGeneratormeetingDuration = new JSONHoldingStringGenerator("field \"meetingDuration\" of the OutlookFindMeetingTimePayload class");
            fieldGeneratorreturnSuggestionReasons = new JSONHoldingBooleanGenerator("field \"returnSuggestionReasons\" of the OutlookFindMeetingTimePayload class");
            fieldGeneratortimeConstraint = new OutlookTimeConstraintJSON.HoldingGenerator("field \"timeConstraint\" of the OutlookFindMeetingTimePayload class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OutlookFindMeetingTimePayload class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorattendees = new OutlookAttendeeBaseJSON.HoldingArrayGenerator("field \"attendees\" of the OutlookFindMeetingTimePayload class", false);
            fieldGeneratorisOrganizerOptional = new JSONHoldingBooleanGenerator("field \"isOrganizerOptional\" of the OutlookFindMeetingTimePayload class");
            fieldGeneratormaxCandidates = new FieldHoldingGeneratormaxCandidates("field \"maxCandidates\" of the OutlookFindMeetingTimePayload class");
            fieldGeneratormeetingDuration = new JSONHoldingStringGenerator("field \"meetingDuration\" of the OutlookFindMeetingTimePayload class");
            fieldGeneratorreturnSuggestionReasons = new JSONHoldingBooleanGenerator("field \"returnSuggestionReasons\" of the OutlookFindMeetingTimePayload class");
            fieldGeneratortimeConstraint = new OutlookTimeConstraintJSON.HoldingGenerator("field \"timeConstraint\" of the OutlookFindMeetingTimePayload class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OutlookFindMeetingTimePayload class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorattendees.reset();
            fieldGeneratorisOrganizerOptional.reset();
            fieldGeneratormaxCandidates.reset();
            fieldGeneratormeetingDuration.reset();
            fieldGeneratorreturnSuggestionReasons.reset();
            fieldGeneratortimeConstraint.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorattendees.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratortimeConstraint.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorattendees.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratortimeConstraint.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(OutlookFindMeetingTimePayloadJSON  result)
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
        public OutlookFindMeetingTimePayloadJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OutlookFindMeetingTimePayloadJSON  result)
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
    protected virtual void handle_result(List<OutlookFindMeetingTimePayloadJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OutlookFindMeetingTimePayloadJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OutlookFindMeetingTimePayloadJSON>();
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
    public List<OutlookFindMeetingTimePayloadJSON> value;
  };
  };
