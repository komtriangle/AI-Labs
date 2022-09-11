/* file "HarmanHospitalityMeetingJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HarmanHospitalityMeetingJSON : JSONBase
  {
    private bool flagHasId;
    private string storeId;
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasDate;
    private string storeDate;
    private bool flagHasFromTime;
    private string storeFromTime;
    private bool flagHasToTime;
    private string storeToTime;
    private bool flagHasRoom;
    private HarmanHospitalityMeetingRoomJSON  storeRoom;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Id of HarmanHospitalityMeetingJSON is not a string.");
        setId(json_string.getData());
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of HarmanHospitalityMeetingJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Date of HarmanHospitalityMeetingJSON is not a string.");
        setDate(json_string.getData());
      }


    private void  fromJSONFromTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FromTime of HarmanHospitalityMeetingJSON is not a string.");
        setFromTime(json_string.getData());
      }


    private void  fromJSONToTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ToTime of HarmanHospitalityMeetingJSON is not a string.");
        setToTime(json_string.getData());
      }


    private void  fromJSONRoom(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HarmanHospitalityMeetingRoomJSON convert_classy = HarmanHospitalityMeetingRoomJSON.from_json(json_value, ignore_extras, true);
        setRoom(convert_classy);
      }


    public HarmanHospitalityMeetingJSON()
      {
        flagHasId = false;
        flagHasTitle = false;
        flagHasDate = false;
        flagHasFromTime = false;
        flagHasToTime = false;
        flagHasRoom = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasId()
      {
        return flagHasId;
      }

    public string  getId()
      {
        Debug.Assert(flagHasId);
        return storeId;
      }

    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        Debug.Assert(flagHasTitle);
        return storeTitle;
      }

    public bool  hasDate()
      {
        return flagHasDate;
      }

    public string  getDate()
      {
        Debug.Assert(flagHasDate);
        return storeDate;
      }

    public bool  hasFromTime()
      {
        return flagHasFromTime;
      }

    public string  getFromTime()
      {
        Debug.Assert(flagHasFromTime);
        return storeFromTime;
      }

    public bool  hasToTime()
      {
        return flagHasToTime;
      }

    public string  getToTime()
      {
        Debug.Assert(flagHasToTime);
        return storeToTime;
      }

    public bool  hasRoom()
      {
        return flagHasRoom;
      }

    public HarmanHospitalityMeetingRoomJSON   getRoom()
      {
        Debug.Assert(flagHasRoom);
        return storeRoom;
      }


    public virtual int extraHarmanHospitalityMeetingComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanHospitalityMeetingComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityMeetingComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityMeetingLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setId(string new_value)
      {
        flagHasId = true;
        storeId = new_value;
      }
    public void unsetId()
      {
        flagHasId = false;
      }
    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setDate(string new_value)
      {
        flagHasDate = true;
        storeDate = new_value;
      }
    public void unsetDate()
      {
        flagHasDate = false;
      }
    public void setFromTime(string new_value)
      {
        flagHasFromTime = true;
        storeFromTime = new_value;
      }
    public void unsetFromTime()
      {
        flagHasFromTime = false;
      }
    public void setToTime(string new_value)
      {
        flagHasToTime = true;
        storeToTime = new_value;
      }
    public void unsetToTime()
      {
        flagHasToTime = false;
      }
    public void setRoom(HarmanHospitalityMeetingRoomJSON  new_value)
      {
        if (flagHasRoom)
          {
          }
        flagHasRoom = true;
        storeRoom = new_value;
      }
    public void unsetRoom()
      {
        if (flagHasRoom)
          {
          }
        flagHasRoom = false;
      }

    public virtual void extraHarmanHospitalityMeetingAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanHospitalityMeetingSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanHospitalityMeetingLookup(key);
        if (old_field == null)
          {
            extraHarmanHospitalityMeetingAppendPair(key, new_component);
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
        if (flagHasId)
          {
            handler.start_pair("Id");
            handler.string_value(storeId);
          }
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasDate)
          {
            handler.start_pair("Date");
            handler.string_value(storeDate);
          }
        if (flagHasFromTime)
          {
            handler.start_pair("FromTime");
            handler.string_value(storeFromTime);
          }
        if (flagHasToTime)
          {
            handler.start_pair("ToTime");
            handler.string_value(storeToTime);
          }
        if (flagHasRoom)
          {
            handler.start_pair("Room");
            if (partial_allowed)
                storeRoom.write_partial_as_json(handler);
            else
                storeRoom.write_as_json(handler);
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

    public static HarmanHospitalityMeetingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityMeetingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeeting", ignore_extras);
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
    public static HarmanHospitalityMeetingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityMeetingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityMeetingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeeting", ignore_extras);
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
    public static HarmanHospitalityMeetingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityMeetingJSON from_text(string text, bool ignore_extras)
      {
        HarmanHospitalityMeetingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeeting", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanHospitalityMeetingJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanHospitalityMeetingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanHospitalityMeetingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeeting", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorId;
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorDate;
        private JSONHoldingStringGenerator fieldGeneratorFromTime;
        private JSONHoldingStringGenerator fieldGeneratorToTime;
        private HarmanHospitalityMeetingRoomJSON.HoldingGenerator fieldGeneratorRoom;
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
            HarmanHospitalityMeetingJSON result = new HarmanHospitalityMeetingJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanHospitalityMeetingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanHospitalityMeetingJSON result)
          {
            if (fieldGeneratorId.have_value)
              {
                result.setId(fieldGeneratorId.value);
                fieldGeneratorId.have_value = false;
              }
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            if (fieldGeneratorDate.have_value)
              {
                result.setDate(fieldGeneratorDate.value);
                fieldGeneratorDate.have_value = false;
              }
            if (fieldGeneratorFromTime.have_value)
              {
                result.setFromTime(fieldGeneratorFromTime.value);
                fieldGeneratorFromTime.have_value = false;
              }
            if (fieldGeneratorToTime.have_value)
              {
                result.setToTime(fieldGeneratorToTime.value);
                fieldGeneratorToTime.have_value = false;
              }
            if (fieldGeneratorRoom.have_value)
              {
                result.setRoom(fieldGeneratorRoom.value);
                fieldGeneratorRoom.have_value = false;
              }
          }
        protected abstract void handle_result(HarmanHospitalityMeetingJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ate", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorDate;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "romTime", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorFromTime;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorId;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "oom", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorRoom;
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "tle", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorTitle;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "Time", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorToTime;
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
            fieldGeneratorId = new JSONHoldingStringGenerator("field \"Id\" of the HarmanHospitalityMeeting class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the HarmanHospitalityMeeting class");
            fieldGeneratorDate = new JSONHoldingStringGenerator("field \"Date\" of the HarmanHospitalityMeeting class");
            fieldGeneratorFromTime = new JSONHoldingStringGenerator("field \"FromTime\" of the HarmanHospitalityMeeting class");
            fieldGeneratorToTime = new JSONHoldingStringGenerator("field \"ToTime\" of the HarmanHospitalityMeeting class");
            fieldGeneratorRoom = new HarmanHospitalityMeetingRoomJSON.HoldingGenerator("field \"Room\" of the HarmanHospitalityMeeting class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanHospitalityMeeting class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorId = new JSONHoldingStringGenerator("field \"Id\" of the HarmanHospitalityMeeting class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the HarmanHospitalityMeeting class");
            fieldGeneratorDate = new JSONHoldingStringGenerator("field \"Date\" of the HarmanHospitalityMeeting class");
            fieldGeneratorFromTime = new JSONHoldingStringGenerator("field \"FromTime\" of the HarmanHospitalityMeeting class");
            fieldGeneratorToTime = new JSONHoldingStringGenerator("field \"ToTime\" of the HarmanHospitalityMeeting class");
            fieldGeneratorRoom = new HarmanHospitalityMeetingRoomJSON.HoldingGenerator("field \"Room\" of the HarmanHospitalityMeeting class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanHospitalityMeeting class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorId.reset();
            fieldGeneratorTitle.reset();
            fieldGeneratorDate.reset();
            fieldGeneratorFromTime.reset();
            fieldGeneratorToTime.reset();
            fieldGeneratorRoom.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRoom.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRoom.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HarmanHospitalityMeetingJSON  result)
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
        public HarmanHospitalityMeetingJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanHospitalityMeetingJSON  result)
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
    protected virtual void handle_result(List<HarmanHospitalityMeetingJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanHospitalityMeetingJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanHospitalityMeetingJSON>();
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
    public List<HarmanHospitalityMeetingJSON> value;
  };
  };
