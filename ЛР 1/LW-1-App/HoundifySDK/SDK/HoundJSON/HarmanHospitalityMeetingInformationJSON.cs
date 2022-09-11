/* file "HarmanHospitalityMeetingInformationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HarmanHospitalityMeetingInformationJSON : JSONBase
  {
    private bool flagHasPropertyId;
    private string storePropertyId;
    private bool flagHasMeetingsToAdd;
    private List< HarmanHospitalityMeetingsByMeetingRoomJSON  > storeMeetingsToAdd;
    private bool flagHasMeetingsToUpdate;
    private List< HarmanHospitalityMeetingsByMeetingRoomJSON  > storeMeetingsToUpdate;
    private bool flagHasMeetingsToRemove;
    private List< string > storeMeetingsToRemove;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPropertyId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PropertyId of HarmanHospitalityMeetingInformationJSON is not a string.");
        setPropertyId(json_string.getData());
      }


    private void  fromJSONMeetingsToAdd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MeetingsToAdd of HarmanHospitalityMeetingInformationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HarmanHospitalityMeetingsByMeetingRoomJSON  > vector_MeetingsToAdd1 = new List< HarmanHospitalityMeetingsByMeetingRoomJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HarmanHospitalityMeetingsByMeetingRoomJSON convert_classy = HarmanHospitalityMeetingsByMeetingRoomJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_MeetingsToAdd1.Add(convert_classy);
          }
        initMeetingsToAdd();
        for (int num1 = 0; num1 < vector_MeetingsToAdd1.Count; ++num1)
            appendMeetingsToAdd(vector_MeetingsToAdd1[num1]);
        for (int num1 = 0; num1 < vector_MeetingsToAdd1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMeetingsToUpdate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MeetingsToUpdate of HarmanHospitalityMeetingInformationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HarmanHospitalityMeetingsByMeetingRoomJSON  > vector_MeetingsToUpdate1 = new List< HarmanHospitalityMeetingsByMeetingRoomJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HarmanHospitalityMeetingsByMeetingRoomJSON convert_classy = HarmanHospitalityMeetingsByMeetingRoomJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_MeetingsToUpdate1.Add(convert_classy);
          }
        initMeetingsToUpdate();
        for (int num2 = 0; num2 < vector_MeetingsToUpdate1.Count; ++num2)
            appendMeetingsToUpdate(vector_MeetingsToUpdate1[num2]);
        for (int num1 = 0; num1 < vector_MeetingsToUpdate1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMeetingsToRemove(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MeetingsToRemove of HarmanHospitalityMeetingInformationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_MeetingsToRemove1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field MeetingsToRemove of HarmanHospitalityMeetingInformationJSON is not a string.");
            vector_MeetingsToRemove1.Add(json_string.getData());
          }
        initMeetingsToRemove();
        for (int num3 = 0; num3 < vector_MeetingsToRemove1.Count; ++num3)
            appendMeetingsToRemove(vector_MeetingsToRemove1[num3]);
        for (int num1 = 0; num1 < vector_MeetingsToRemove1.Count; ++num1)
          {
          }
      }


    public HarmanHospitalityMeetingInformationJSON()
      {
        flagHasPropertyId = false;
        flagHasMeetingsToAdd = false;
        flagHasMeetingsToUpdate = false;
        flagHasMeetingsToRemove = false;
        storeMeetingsToAdd = new List< HarmanHospitalityMeetingsByMeetingRoomJSON  >();
        storeMeetingsToUpdate = new List< HarmanHospitalityMeetingsByMeetingRoomJSON  >();
        storeMeetingsToRemove = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPropertyId()
      {
        return flagHasPropertyId;
      }

    public string  getPropertyId()
      {
        Debug.Assert(flagHasPropertyId);
        return storePropertyId;
      }

    public bool  hasMeetingsToAdd()
      {
        return flagHasMeetingsToAdd;
      }

    public int  countOfMeetingsToAdd()
      {
        Debug.Assert(flagHasMeetingsToAdd);
        return storeMeetingsToAdd.Count;
      }

    public HarmanHospitalityMeetingsByMeetingRoomJSON   elementOfMeetingsToAdd(int element_num)
      {
        Debug.Assert(flagHasMeetingsToAdd);
        return storeMeetingsToAdd[element_num];
      }

    public List< HarmanHospitalityMeetingsByMeetingRoomJSON  >  getMeetingsToAdd()
      {
        Debug.Assert(flagHasMeetingsToAdd);
        return storeMeetingsToAdd;
      }

    public bool  hasMeetingsToUpdate()
      {
        return flagHasMeetingsToUpdate;
      }

    public int  countOfMeetingsToUpdate()
      {
        Debug.Assert(flagHasMeetingsToUpdate);
        return storeMeetingsToUpdate.Count;
      }

    public HarmanHospitalityMeetingsByMeetingRoomJSON   elementOfMeetingsToUpdate(int element_num)
      {
        Debug.Assert(flagHasMeetingsToUpdate);
        return storeMeetingsToUpdate[element_num];
      }

    public List< HarmanHospitalityMeetingsByMeetingRoomJSON  >  getMeetingsToUpdate()
      {
        Debug.Assert(flagHasMeetingsToUpdate);
        return storeMeetingsToUpdate;
      }

    public bool  hasMeetingsToRemove()
      {
        return flagHasMeetingsToRemove;
      }

    public int  countOfMeetingsToRemove()
      {
        Debug.Assert(flagHasMeetingsToRemove);
        return storeMeetingsToRemove.Count;
      }

    public string  elementOfMeetingsToRemove(int element_num)
      {
        Debug.Assert(flagHasMeetingsToRemove);
        return storeMeetingsToRemove[element_num];
      }

    public List< string >  getMeetingsToRemove()
      {
        Debug.Assert(flagHasMeetingsToRemove);
        return storeMeetingsToRemove;
      }


    public virtual int extraHarmanHospitalityMeetingInformationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanHospitalityMeetingInformationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityMeetingInformationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityMeetingInformationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPropertyId(string new_value)
      {
        flagHasPropertyId = true;
        storePropertyId = new_value;
      }
    public void unsetPropertyId()
      {
        flagHasPropertyId = false;
      }
    public void initMeetingsToAdd()
      {
        if (flagHasMeetingsToAdd)
          {
            for (int num1 = 0; num1 < storeMeetingsToAdd.Count; ++num1)
              {
              }
          }
        flagHasMeetingsToAdd = true;
        storeMeetingsToAdd.Clear();
      }
    public void appendMeetingsToAdd(HarmanHospitalityMeetingsByMeetingRoomJSON  to_append)
      {
        if (!flagHasMeetingsToAdd)
          {
            flagHasMeetingsToAdd = true;
            storeMeetingsToAdd.Clear();
          }
        Debug.Assert(flagHasMeetingsToAdd);
        storeMeetingsToAdd.Add(to_append);
      }
    public void unsetMeetingsToAdd()
      {
        if (flagHasMeetingsToAdd)
          {
            for (int num2 = 0; num2 < storeMeetingsToAdd.Count; ++num2)
              {
              }
          }
        flagHasMeetingsToAdd = false;
        storeMeetingsToAdd.Clear();
      }
    public void initMeetingsToUpdate()
      {
        if (flagHasMeetingsToUpdate)
          {
            for (int num3 = 0; num3 < storeMeetingsToUpdate.Count; ++num3)
              {
              }
          }
        flagHasMeetingsToUpdate = true;
        storeMeetingsToUpdate.Clear();
      }
    public void appendMeetingsToUpdate(HarmanHospitalityMeetingsByMeetingRoomJSON  to_append)
      {
        if (!flagHasMeetingsToUpdate)
          {
            flagHasMeetingsToUpdate = true;
            storeMeetingsToUpdate.Clear();
          }
        Debug.Assert(flagHasMeetingsToUpdate);
        storeMeetingsToUpdate.Add(to_append);
      }
    public void unsetMeetingsToUpdate()
      {
        if (flagHasMeetingsToUpdate)
          {
            for (int num4 = 0; num4 < storeMeetingsToUpdate.Count; ++num4)
              {
              }
          }
        flagHasMeetingsToUpdate = false;
        storeMeetingsToUpdate.Clear();
      }
    public void initMeetingsToRemove()
      {
        flagHasMeetingsToRemove = true;
        storeMeetingsToRemove.Clear();
      }
    public void appendMeetingsToRemove(string to_append)
      {
        if (!flagHasMeetingsToRemove)
          {
            flagHasMeetingsToRemove = true;
            storeMeetingsToRemove.Clear();
          }
        Debug.Assert(flagHasMeetingsToRemove);
        storeMeetingsToRemove.Add(to_append);
      }
    public void unsetMeetingsToRemove()
      {
        flagHasMeetingsToRemove = false;
        storeMeetingsToRemove.Clear();
      }

    public virtual void extraHarmanHospitalityMeetingInformationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanHospitalityMeetingInformationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanHospitalityMeetingInformationLookup(key);
        if (old_field == null)
          {
            extraHarmanHospitalityMeetingInformationAppendPair(key, new_component);
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
        if (flagHasPropertyId)
          {
            handler.start_pair("PropertyId");
            handler.string_value(storePropertyId);
          }
        if (flagHasMeetingsToAdd)
          {
            handler.start_pair("MeetingsToAdd");
            handler.start_array();
            for (int num1 = 0; num1 < storeMeetingsToAdd.Count; ++num1)
              {
                if (partial_allowed)
                    storeMeetingsToAdd[num1].write_partial_as_json(handler);
                else
                    storeMeetingsToAdd[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMeetingsToUpdate)
          {
            handler.start_pair("MeetingsToUpdate");
            handler.start_array();
            for (int num2 = 0; num2 < storeMeetingsToUpdate.Count; ++num2)
              {
                if (partial_allowed)
                    storeMeetingsToUpdate[num2].write_partial_as_json(handler);
                else
                    storeMeetingsToUpdate[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMeetingsToRemove)
          {
            handler.start_pair("MeetingsToRemove");
            handler.start_array();
            for (int num3 = 0; num3 < storeMeetingsToRemove.Count; ++num3)
              {
                handler.string_value(storeMeetingsToRemove[num3]);
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

    public static HarmanHospitalityMeetingInformationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityMeetingInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeetingInformation", ignore_extras);
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
    public static HarmanHospitalityMeetingInformationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityMeetingInformationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityMeetingInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeetingInformation", ignore_extras);
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
    public static HarmanHospitalityMeetingInformationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityMeetingInformationJSON from_text(string text, bool ignore_extras)
      {
        HarmanHospitalityMeetingInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeetingInformation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanHospitalityMeetingInformationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanHospitalityMeetingInformationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanHospitalityMeetingInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityMeetingInformation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorPropertyId;
        private HarmanHospitalityMeetingsByMeetingRoomJSON.HoldingArrayGenerator fieldGeneratorMeetingsToAdd;
        private HarmanHospitalityMeetingsByMeetingRoomJSON.HoldingArrayGenerator fieldGeneratorMeetingsToUpdate;
        private JSONHoldingStringArrayGenerator fieldGeneratorMeetingsToRemove;
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
            HarmanHospitalityMeetingInformationJSON result = new HarmanHospitalityMeetingInformationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanHospitalityMeetingInformationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanHospitalityMeetingInformationJSON result)
          {
            if (fieldGeneratorPropertyId.have_value)
              {
                result.setPropertyId(fieldGeneratorPropertyId.value);
                fieldGeneratorPropertyId.have_value = false;
              }
            if (fieldGeneratorMeetingsToAdd.have_value)
              {
                result.initMeetingsToAdd();
                int count = fieldGeneratorMeetingsToAdd.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMeetingsToAdd(fieldGeneratorMeetingsToAdd.value[num]);
                  }
                fieldGeneratorMeetingsToAdd.value.Clear();
                fieldGeneratorMeetingsToAdd.have_value = false;
              }
            if (fieldGeneratorMeetingsToUpdate.have_value)
              {
                result.initMeetingsToUpdate();
                int count = fieldGeneratorMeetingsToUpdate.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMeetingsToUpdate(fieldGeneratorMeetingsToUpdate.value[num]);
                  }
                fieldGeneratorMeetingsToUpdate.value.Clear();
                fieldGeneratorMeetingsToUpdate.have_value = false;
              }
            if (fieldGeneratorMeetingsToRemove.have_value)
              {
                result.initMeetingsToRemove();
                int count = fieldGeneratorMeetingsToRemove.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMeetingsToRemove(fieldGeneratorMeetingsToRemove.value[num]);
                  }
                fieldGeneratorMeetingsToRemove.value.Clear();
                fieldGeneratorMeetingsToRemove.have_value = false;
              }
          }
        protected abstract void handle_result(HarmanHospitalityMeetingInformationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if (String.Compare(field_name, 1, "eetingsTo", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 11, "dd", 0, 2, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorMeetingsToAdd;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 11, "emove", 0, 5, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorMeetingsToRemove;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 11, "pdate", 0, 5, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorMeetingsToUpdate;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ropertyId", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPropertyId;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPropertyId = new JSONHoldingStringGenerator("field \"PropertyId\" of the HarmanHospitalityMeetingInformation class");
            fieldGeneratorMeetingsToAdd = new HarmanHospitalityMeetingsByMeetingRoomJSON.HoldingArrayGenerator("field \"MeetingsToAdd\" of the HarmanHospitalityMeetingInformation class", ignore_extras);
            fieldGeneratorMeetingsToUpdate = new HarmanHospitalityMeetingsByMeetingRoomJSON.HoldingArrayGenerator("field \"MeetingsToUpdate\" of the HarmanHospitalityMeetingInformation class", ignore_extras);
            fieldGeneratorMeetingsToRemove = new JSONHoldingStringArrayGenerator("field \"MeetingsToRemove\" of the HarmanHospitalityMeetingInformation class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanHospitalityMeetingInformation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPropertyId = new JSONHoldingStringGenerator("field \"PropertyId\" of the HarmanHospitalityMeetingInformation class");
            fieldGeneratorMeetingsToAdd = new HarmanHospitalityMeetingsByMeetingRoomJSON.HoldingArrayGenerator("field \"MeetingsToAdd\" of the HarmanHospitalityMeetingInformation class", false);
            fieldGeneratorMeetingsToUpdate = new HarmanHospitalityMeetingsByMeetingRoomJSON.HoldingArrayGenerator("field \"MeetingsToUpdate\" of the HarmanHospitalityMeetingInformation class", false);
            fieldGeneratorMeetingsToRemove = new JSONHoldingStringArrayGenerator("field \"MeetingsToRemove\" of the HarmanHospitalityMeetingInformation class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanHospitalityMeetingInformation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPropertyId.reset();
            fieldGeneratorMeetingsToAdd.reset();
            fieldGeneratorMeetingsToUpdate.reset();
            fieldGeneratorMeetingsToRemove.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMeetingsToAdd.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMeetingsToUpdate.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMeetingsToAdd.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMeetingsToUpdate.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HarmanHospitalityMeetingInformationJSON  result)
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
        public HarmanHospitalityMeetingInformationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanHospitalityMeetingInformationJSON  result)
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
    protected virtual void handle_result(List<HarmanHospitalityMeetingInformationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanHospitalityMeetingInformationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanHospitalityMeetingInformationJSON>();
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
    public List<HarmanHospitalityMeetingInformationJSON> value;
  };
  };
