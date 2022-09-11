/* file "RobotSetKnownRoomsCommandIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RobotSetKnownRoomsCommandIntentJSON : RobotCommandIntentJSON
  {
    private bool flagHasRoomsList;
    private List< RoomJSON  > storeRoomsList;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRoomsListToJSON()
      {
        JSONArrayValue generated_array_1_RoomsList = new JSONArrayValue();
        for (int num1 = 0; num1 < storeRoomsList.Count; ++num1)
          {
            JSONValueHandler handler_RoomsList = new JSONValueHandler();
            storeRoomsList[num1].write_as_json(handler_RoomsList);
            generated_array_1_RoomsList.appendComponent(handler_RoomsList.result);
          }
        return generated_array_1_RoomsList;
      }


    private void  fromJSONRoomsList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RoomsList of RobotSetKnownRoomsCommandIntentJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RoomJSON  > vector_RoomsList1 = new List< RoomJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RoomJSON convert_classy = RoomJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RoomsList1.Add(convert_classy);
          }
        initRoomsList();
        for (int num1 = 0; num1 < vector_RoomsList1.Count; ++num1)
            appendRoomsList(vector_RoomsList1[num1]);
        for (int num1 = 0; num1 < vector_RoomsList1.Count; ++num1)
          {
          }
      }


    public RobotSetKnownRoomsCommandIntentJSON()
      {
        flagHasRoomsList = false;
        storeRoomsList = new List< RoomJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRobotIntentKind()
      {
        return "RobotSetKnownRoomsCommand";
      }

    public bool  hasRoomsList()
      {
        return flagHasRoomsList;
      }

    public int  countOfRoomsList()
      {
        Debug.Assert(flagHasRoomsList);
        return storeRoomsList.Count;
      }

    public RoomJSON   elementOfRoomsList(int element_num)
      {
        Debug.Assert(flagHasRoomsList);
        return storeRoomsList[element_num];
      }

    public List< RoomJSON  >  getRoomsList()
      {
        Debug.Assert(flagHasRoomsList);
        return storeRoomsList;
      }


    public virtual int extraRobotSetKnownRoomsCommandIntentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRobotSetKnownRoomsCommandIntentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRobotSetKnownRoomsCommandIntentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRobotSetKnownRoomsCommandIntentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRobotCommandIntentComponentCount()
      {
        int result = 0;
        if (flagHasRoomsList)
            ++result;
        result += extraRobotSetKnownRoomsCommandIntentComponentCount();
        return result;
      }
    public override string extraRobotCommandIntentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRoomsList)
          {
            if (remainder == 0)
                return "RoomsList";
            --remainder;
          }
        return extraRobotSetKnownRoomsCommandIntentComponentKey(remainder);
      }
    public override JSONValue extraRobotCommandIntentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRoomsList)
          {
            if (remainder == 0)
                return extraRoomsListToJSON();
            --remainder;
          }
        return extraRobotSetKnownRoomsCommandIntentComponentValue(remainder);
      }
    public override JSONValue extraRobotCommandIntentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "RoomsList", 0, 9, false) == 0) && (field_name.Length == 9))
            return (flagHasRoomsList ? extraRoomsListToJSON() : null);
        return extraRobotSetKnownRoomsCommandIntentLookup(field_name);
      }

    public void initRoomsList()
      {
        if (flagHasRoomsList)
          {
            for (int num1 = 0; num1 < storeRoomsList.Count; ++num1)
              {
              }
          }
        flagHasRoomsList = true;
        storeRoomsList.Clear();
      }
    public void appendRoomsList(RoomJSON  to_append)
      {
        if (!flagHasRoomsList)
          {
            flagHasRoomsList = true;
            storeRoomsList.Clear();
          }
        Debug.Assert(flagHasRoomsList);
        storeRoomsList.Add(to_append);
      }
    public void unsetRoomsList()
      {
        if (flagHasRoomsList)
          {
            for (int num2 = 0; num2 < storeRoomsList.Count; ++num2)
              {
              }
          }
        flagHasRoomsList = false;
        storeRoomsList.Clear();
      }

    public virtual void extraRobotSetKnownRoomsCommandIntentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRobotSetKnownRoomsCommandIntentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRobotSetKnownRoomsCommandIntentLookup(key);
        if (old_field == null)
          {
            extraRobotSetKnownRoomsCommandIntentAppendPair(key, new_component);
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
    public override void extraRobotCommandIntentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RoomsList", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONRoomsList(new_component, false);
            return;
            }
        extraRobotSetKnownRoomsCommandIntentAppendPair(key, new_component);
      }
    public override void extraRobotCommandIntentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RoomsList", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONRoomsList(new_component, false);
            return;
            }
        extraRobotSetKnownRoomsCommandIntentSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRoomsList);
        if (flagHasRoomsList)
          {
            handler.start_pair("RoomsList");
            handler.start_array();
            for (int num1 = 0; num1 < storeRoomsList.Count; ++num1)
              {
                if (partial_allowed)
                    storeRoomsList[num1].write_partial_as_json(handler);
                else
                    storeRoomsList[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasRoomsList()))
          {
            return "When parsing the object for %what%, the \"RoomsList\" field was missing.";
          }
        return null;
      }

    public static new RobotSetKnownRoomsCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotSetKnownRoomsCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotSetKnownRoomsCommandIntent", ignore_extras);
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
    public static new RobotSetKnownRoomsCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RobotSetKnownRoomsCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotSetKnownRoomsCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotSetKnownRoomsCommandIntent", ignore_extras);
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
    public static new RobotSetKnownRoomsCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RobotSetKnownRoomsCommandIntentJSON from_text(string text, bool ignore_extras)
      {
        RobotSetKnownRoomsCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotSetKnownRoomsCommandIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RobotSetKnownRoomsCommandIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RobotSetKnownRoomsCommandIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RobotSetKnownRoomsCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotSetKnownRoomsCommandIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RobotCommandIntentJSON.Generator
      {
        private RoomJSON.HoldingArrayGenerator fieldGeneratorRoomsList;
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
            if (!(getRobotCommandIntentJSONKey().Equals("RobotSetKnownRoomsCommand")))
                throw new Exception("The key field has a value other than `RobotSetKnownRoomsCommand'.");
            RobotSetKnownRoomsCommandIntentJSON result = new RobotSetKnownRoomsCommandIntentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRobotSetKnownRoomsCommandIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RobotCommandIntentJSON new_result)
          {
            handle_result((RobotSetKnownRoomsCommandIntentJSON )new_result);
          }
        protected void finish(RobotSetKnownRoomsCommandIntentJSON result)
          {
            if (fieldGeneratorRoomsList.have_value)
              {
                result.initRoomsList();
                int count = fieldGeneratorRoomsList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRoomsList(fieldGeneratorRoomsList.value[num]);
                  }
                fieldGeneratorRoomsList.value.Clear();
                fieldGeneratorRoomsList.have_value = false;
              }
            else if ((!(result.hasRoomsList())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RoomsList\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RobotSetKnownRoomsCommandIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "RoomsList", 0, 9, false) == 0) && (field_name.Length == 9))
                return fieldGeneratorRoomsList;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRoomsList = new RoomJSON.HoldingArrayGenerator("field \"RoomsList\" of the RobotSetKnownRoomsCommandIntent class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RobotSetKnownRoomsCommandIntent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRoomsList = new RoomJSON.HoldingArrayGenerator("field \"RoomsList\" of the RobotSetKnownRoomsCommandIntent class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RobotSetKnownRoomsCommandIntent class");
          }

        public override void reset()
          {
            fieldGeneratorRoomsList.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RobotSetKnownRoomsCommandIntentJSON  result)
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
        public RobotSetKnownRoomsCommandIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RobotSetKnownRoomsCommandIntentJSON  result)
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
    protected virtual void handle_result(List<RobotSetKnownRoomsCommandIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RobotSetKnownRoomsCommandIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RobotSetKnownRoomsCommandIntentJSON>();
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
    public List<RobotSetKnownRoomsCommandIntentJSON> value;
  };
  };
