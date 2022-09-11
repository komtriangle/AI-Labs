/* file "HarmanHospitalityMeetingsByMeetingRoomJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HarmanHospitalityMeetingsByMeetingRoomJSON : JSONBase
  {
    private bool flagHasMeetingRoomID;
    private string storeMeetingRoomID;
    private bool flagHasMeetingRoomName;
    private string storeMeetingRoomName;
    private bool flagHasMeetings;
    private List< HarmanHospitalityMeetingJSON  > storeMeetings;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONMeetingRoomID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MeetingRoomID of HarmanHospitalityMeetingsByMeetingRoomJSON is not a string.");
        setMeetingRoomID(json_string.getData());
      }


    private void  fromJSONMeetingRoomName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MeetingRoomName of HarmanHospitalityMeetingsByMeetingRoomJSON is not a string.");
        setMeetingRoomName(json_string.getData());
      }


    private void  fromJSONMeetings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Meetings of HarmanHospitalityMeetingsByMeetingRoomJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Meetings of HarmanHospitalityMeetingsByMeetingRoomJSON has too few elements.");
        List< HarmanHospitalityMeetingJSON  > vector_Meetings1 = new List< HarmanHospitalityMeetingJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HarmanHospitalityMeetingJSON convert_classy = HarmanHospitalityMeetingJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Meetings1.Add(convert_classy);
          }
        Debug.Assert(vector_Meetings1.Count >= 1);
        initMeetings();
        for (int num1 = 0; num1 < vector_Meetings1.Count; ++num1)
            appendMeetings(vector_Meetings1[num1]);
        for (int num1 = 0; num1 < vector_Meetings1.Count; ++num1)
          {
          }
      }


    public HarmanHospitalityMeetingsByMeetingRoomJSON()
      {
        flagHasMeetingRoomID = false;
        flagHasMeetingRoomName = false;
        flagHasMeetings = false;
        storeMeetings = new List< HarmanHospitalityMeetingJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasMeetingRoomID()
      {
        return flagHasMeetingRoomID;
      }

    public string  getMeetingRoomID()
      {
        Debug.Assert(flagHasMeetingRoomID);
        return storeMeetingRoomID;
      }

    public bool  hasMeetingRoomName()
      {
        return flagHasMeetingRoomName;
      }

    public string  getMeetingRoomName()
      {
        Debug.Assert(flagHasMeetingRoomName);
        return storeMeetingRoomName;
      }

    public bool  hasMeetings()
      {
        return flagHasMeetings;
      }

    public int  countOfMeetings()
      {
        Debug.Assert(flagHasMeetings);
        return storeMeetings.Count;
      }

    public HarmanHospitalityMeetingJSON   elementOfMeetings(int element_num)
      {
        Debug.Assert(flagHasMeetings);
        return storeMeetings[element_num];
      }

    public List< HarmanHospitalityMeetingJSON  >  getMeetings()
      {
        Debug.Assert(flagHasMeetings);
        return storeMeetings;
      }


    public virtual int extraHarmanHospitalityMeetingsByMeetingRoomComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanHospitalityMeetingsByMeetingRoomComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityMeetingsByMeetingRoomComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityMeetingsByMeetingRoomLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setMeetingRoomID(string new_value)
      {
        flagHasMeetingRoomID = true;
        storeMeetingRoomID = new_value;
      }
    public void unsetMeetingRoomID()
      {
        flagHasMeetingRoomID = false;
      }
    public void setMeetingRoomName(string new_value)
      {
        flagHasMeetingRoomName = true;
        storeMeetingRoomName = new_value;
      }
    public void unsetMeetingRoomName()
      {
        flagHasMeetingRoomName = false;
      }
    public void initMeetings()
      {
        if (flagHasMeetings)
          {
            for (int num1 = 0; num1 < storeMeetings.Count; ++num1)
              {
              }
          }
        flagHasMeetings = true;
        storeMeetings.Clear();
      }
    public void appendMeetings(HarmanHospitalityMeetingJSON  to_append)
      {
        if (!flagHasMeetings)
          {
            flagHasMeetings = true;
            storeMeetings.Clear();
          }
        Debug.Assert(flagHasMeetings);
        storeMeetings.Add(to_append);
      }
    public void unsetMeetings()
      {
        if (flagHasMeetings)
          {
            for (int num2 = 0; num2 < storeMeetings.Count; ++num2)
              {
              }
          }
        flagHasMeetings = false;
        storeMeetings.Clear();
      }

    public virtual void extraHarmanHospitalityMeetingsByMeetingRoomAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanHospitalityMeetingsByMeetingRoomSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanHospitalityMeetingsByMeetingRoomLookup(key);
        if (old_field == null)
          {
            extraHarmanHospitalityMeetingsByMeetingRoomAppendPair(key, new_component);
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
        if (flagHasMeetingRoomID)
          {
            handler.start_pair("MeetingRoomID");
            handler.string_value(storeMeetingRoomID);
          }
        if (flagHasMeetingRoomName)
          {
            handler.start_pair("MeetingRoomName");
            handler.string_value(storeMeetingRoomName);
          }
        if (flagHasMeetings)
          {
            handler.start_pair("Meetings");
            Debug.Assert(storeMeetings.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeMeetings.Count; ++num1)
              {
                if (partial_allowed)
                    storeMeetings[num1].write_partial_as_json(handler);
                else
                    storeMeetings[num1].write_as_json(handler);
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

    public static HarmanHospitalityMeetingsByMeetingRoomJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityMeetingsByMeetingRoomJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeetingsByMeetingRoom", ignore_extras);
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
    public static HarmanHospitalityMeetingsByMeetingRoomJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityMeetingsByMeetingRoomJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityMeetingsByMeetingRoomJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeetingsByMeetingRoom", ignore_extras);
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
    public static HarmanHospitalityMeetingsByMeetingRoomJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityMeetingsByMeetingRoomJSON from_text(string text, bool ignore_extras)
      {
        HarmanHospitalityMeetingsByMeetingRoomJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeetingsByMeetingRoom", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanHospitalityMeetingsByMeetingRoomJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanHospitalityMeetingsByMeetingRoomJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanHospitalityMeetingsByMeetingRoomJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeetingsByMeetingRoom", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorMeetingRoomID;
        private JSONHoldingStringGenerator fieldGeneratorMeetingRoomName;
        private HarmanHospitalityMeetingJSON.HoldingArrayGenerator fieldGeneratorMeetings;
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
            HarmanHospitalityMeetingsByMeetingRoomJSON result = new HarmanHospitalityMeetingsByMeetingRoomJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanHospitalityMeetingsByMeetingRoomAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanHospitalityMeetingsByMeetingRoomJSON result)
          {
            if (fieldGeneratorMeetingRoomID.have_value)
              {
                result.setMeetingRoomID(fieldGeneratorMeetingRoomID.value);
                fieldGeneratorMeetingRoomID.have_value = false;
              }
            if (fieldGeneratorMeetingRoomName.have_value)
              {
                result.setMeetingRoomName(fieldGeneratorMeetingRoomName.value);
                fieldGeneratorMeetingRoomName.have_value = false;
              }
            if (fieldGeneratorMeetings.have_value)
              {
                result.initMeetings();
                int count = fieldGeneratorMeetings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMeetings(fieldGeneratorMeetings.value[num]);
                  }
                fieldGeneratorMeetings.value.Clear();
                fieldGeneratorMeetings.have_value = false;
              }
          }
        protected abstract void handle_result(HarmanHospitalityMeetingsByMeetingRoomJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Meeting", 0, 7, false) == 0)
              {
                switch (field_name[7])
                  {
                    case 'R':
                        if (String.Compare(field_name, 8, "oom", 0, 3, false) == 0)
                          {
                            switch (field_name[11])
                              {
                                case 'I':
                                    if ((String.Compare(field_name, 12, "D", 0, 1, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorMeetingRoomID;
                                    break;
                                case 'N':
                                    if ((String.Compare(field_name, 12, "ame", 0, 3, false) == 0) && (field_name.Length == 15))
                                        return fieldGeneratorMeetingRoomName;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 's':
                        if (field_name.Length == 8)
                            return fieldGeneratorMeetings;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMeetingRoomID = new JSONHoldingStringGenerator("field \"MeetingRoomID\" of the HarmanHospitalityMeetingsByMeetingRoom class");
            fieldGeneratorMeetingRoomName = new JSONHoldingStringGenerator("field \"MeetingRoomName\" of the HarmanHospitalityMeetingsByMeetingRoom class");
            fieldGeneratorMeetings = new HarmanHospitalityMeetingJSON.HoldingArrayGenerator("field \"Meetings\" of the HarmanHospitalityMeetingsByMeetingRoom class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanHospitalityMeetingsByMeetingRoom class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMeetingRoomID = new JSONHoldingStringGenerator("field \"MeetingRoomID\" of the HarmanHospitalityMeetingsByMeetingRoom class");
            fieldGeneratorMeetingRoomName = new JSONHoldingStringGenerator("field \"MeetingRoomName\" of the HarmanHospitalityMeetingsByMeetingRoom class");
            fieldGeneratorMeetings = new HarmanHospitalityMeetingJSON.HoldingArrayGenerator("field \"Meetings\" of the HarmanHospitalityMeetingsByMeetingRoom class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanHospitalityMeetingsByMeetingRoom class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMeetingRoomID.reset();
            fieldGeneratorMeetingRoomName.reset();
            fieldGeneratorMeetings.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMeetings.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMeetings.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HarmanHospitalityMeetingsByMeetingRoomJSON  result)
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
        public HarmanHospitalityMeetingsByMeetingRoomJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanHospitalityMeetingsByMeetingRoomJSON  result)
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
    protected virtual void handle_result(List<HarmanHospitalityMeetingsByMeetingRoomJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanHospitalityMeetingsByMeetingRoomJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanHospitalityMeetingsByMeetingRoomJSON>();
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
    public List<HarmanHospitalityMeetingsByMeetingRoomJSON> value;
  };
  };
