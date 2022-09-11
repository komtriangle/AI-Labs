/* file "CiscoSparkRoomDetailJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CiscoSparkRoomDetailJSON : JSONBase
  {
    public enum TypeRoomKnownValues
      {
        Room_CurrentRoom,
        Room__none
      };
    public struct TypeRoom
      {
        public bool in_known_list;
        public string string_value;
        public TypeRoomKnownValues list_value;
      };

    public static TypeRoomKnownValues  stringToRoom(string chars)
      {
        if ((String.Compare(chars, 0, "CurrentRoom", 0, 11, false) == 0) && (chars.Length == 11))
            return TypeRoomKnownValues.Room_CurrentRoom;
        return TypeRoomKnownValues.Room__none;
      }

    public static string  stringFromRoom(TypeRoomKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeRoomKnownValues.Room_CurrentRoom:
                return "CurrentRoom";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasRoom;
    private TypeRoom storeRoom;
    private bool flagHasRoomName;
    private string storeRoomName;
    private bool flagHasRoomNumber;
    private string storeRoomNumber;
    private bool flagHasSubQueryId;
    private string storeSubQueryId;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRoom(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Room of CiscoSparkRoomDetailJSON is not a string.");
        TypeRoom the_open_enum = new TypeRoom();
        if ((String.Compare(json_string.getData(), 0, "CurrentRoom", 0, 11, false) == 0) && (json_string.getData().Length == 11))
              {
                the_open_enum.in_known_list = true;
                the_open_enum.list_value = TypeRoomKnownValues.Room_CurrentRoom;
                goto open_enum_is_done;
              }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setRoom(the_open_enum);
      }


    private void  fromJSONRoomName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RoomName of CiscoSparkRoomDetailJSON is not a string.");
        setRoomName(json_string.getData());
      }


    private void  fromJSONRoomNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RoomNumber of CiscoSparkRoomDetailJSON is not a string.");
        setRoomNumber(json_string.getData());
      }


    private void  fromJSONSubQueryId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SubQueryId of CiscoSparkRoomDetailJSON is not a string.");
        setSubQueryId(json_string.getData());
      }


    public CiscoSparkRoomDetailJSON()
      {
        flagHasRoom = false;
        flagHasRoomName = false;
        flagHasRoomNumber = false;
        flagHasSubQueryId = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRoom()
      {
        return flagHasRoom;
      }

    public TypeRoom  getRoom()
      {
        Debug.Assert(flagHasRoom);
        return storeRoom;
      }

    public string  getRoomAsString()
      {
        TypeRoom result = getRoom();
        if (result.in_known_list)
            return stringFromRoom(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasRoomName()
      {
        return flagHasRoomName;
      }

    public string  getRoomName()
      {
        Debug.Assert(flagHasRoomName);
        return storeRoomName;
      }

    public bool  hasRoomNumber()
      {
        return flagHasRoomNumber;
      }

    public string  getRoomNumber()
      {
        Debug.Assert(flagHasRoomNumber);
        return storeRoomNumber;
      }

    public bool  hasSubQueryId()
      {
        return flagHasSubQueryId;
      }

    public string  getSubQueryId()
      {
        Debug.Assert(flagHasSubQueryId);
        return storeSubQueryId;
      }


    public virtual int extraCiscoSparkRoomDetailComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCiscoSparkRoomDetailComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCiscoSparkRoomDetailComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCiscoSparkRoomDetailLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRoom(TypeRoom new_value)
      {
        flagHasRoom = true;
        storeRoom = new_value;
      }
    public void setRoom(string chars)
      {
        TypeRoomKnownValues known = stringToRoom(chars);
        TypeRoom new_value = new TypeRoom();
        if (known == TypeRoomKnownValues.Room__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRoom(new_value);
      }
    public void setRoom(TypeRoomKnownValues new_value)
      {
        TypeRoom new_full_value = new TypeRoom();
        Debug.Assert(new_value != TypeRoomKnownValues.Room__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setRoom(new_full_value);
      }
    public void unsetRoom()
      {
        flagHasRoom = false;
      }
    public void setRoomName(string new_value)
      {
        flagHasRoomName = true;
        storeRoomName = new_value;
      }
    public void unsetRoomName()
      {
        flagHasRoomName = false;
      }
    public void setRoomNumber(string new_value)
      {
        flagHasRoomNumber = true;
        storeRoomNumber = new_value;
      }
    public void unsetRoomNumber()
      {
        flagHasRoomNumber = false;
      }
    public void setSubQueryId(string new_value)
      {
        flagHasSubQueryId = true;
        storeSubQueryId = new_value;
      }
    public void unsetSubQueryId()
      {
        flagHasSubQueryId = false;
      }

    public virtual void extraCiscoSparkRoomDetailAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCiscoSparkRoomDetailSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCiscoSparkRoomDetailLookup(key);
        if (old_field == null)
          {
            extraCiscoSparkRoomDetailAppendPair(key, new_component);
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
        if (flagHasRoom)
          {
            handler.start_pair("Room");
            if (storeRoom.in_known_list)
              {
                switch (storeRoom.list_value)
                  {
                    case TypeRoomKnownValues.Room_CurrentRoom:
                        handler.string_value("CurrentRoom");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeRoom.string_value);
              }
          }
        if (flagHasRoomName)
          {
            handler.start_pair("RoomName");
            handler.string_value(storeRoomName);
          }
        if (flagHasRoomNumber)
          {
            handler.start_pair("RoomNumber");
            handler.string_value(storeRoomNumber);
          }
        if (flagHasSubQueryId)
          {
            handler.start_pair("SubQueryId");
            handler.string_value(storeSubQueryId);
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

    public static CiscoSparkRoomDetailJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CiscoSparkRoomDetailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkRoomDetail", ignore_extras);
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
    public static CiscoSparkRoomDetailJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CiscoSparkRoomDetailJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CiscoSparkRoomDetailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkRoomDetail", ignore_extras);
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
    public static CiscoSparkRoomDetailJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CiscoSparkRoomDetailJSON from_text(string text, bool ignore_extras)
      {
        CiscoSparkRoomDetailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkRoomDetail", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CiscoSparkRoomDetailJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CiscoSparkRoomDetailJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CiscoSparkRoomDetailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CiscoSparkRoomDetail", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorRoom : JSONStringGenerator
          {
            protected FieldGeneratorRoom(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorRoom()
              {
              }
            protected override void handle_result(string result)
              {
                TypeRoomKnownValues known = stringToRoom(result);
                TypeRoom new_value = new TypeRoom();
                if (known == TypeRoomKnownValues.Room__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeRoom result);
          };
    private class FieldHoldingGeneratorRoom : FieldGeneratorRoom
  {
    protected override void handle_result(TypeRoom result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorRoom(String what)
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
    public TypeRoom value;
  };
    private class FieldHoldingArrayGeneratorRoom : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorRoom
      {
        private FieldHoldingArrayGeneratorRoom top;

        protected override void handle_result(TypeRoom result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorRoom init_top)
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
    protected virtual void handle_result(List<TypeRoom> result)
      {
      }

    public FieldHoldingArrayGeneratorRoom(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRoom>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorRoom()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRoom>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeRoom> value;
  };
        private FieldHoldingGeneratorRoom fieldGeneratorRoom;
        private JSONHoldingStringGenerator fieldGeneratorRoomName;
        private JSONHoldingStringGenerator fieldGeneratorRoomNumber;
        private JSONHoldingStringGenerator fieldGeneratorSubQueryId;
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
            CiscoSparkRoomDetailJSON result = new CiscoSparkRoomDetailJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCiscoSparkRoomDetailAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CiscoSparkRoomDetailJSON result)
          {
            if (fieldGeneratorRoom.have_value)
              {
                result.setRoom(fieldGeneratorRoom.value);
                fieldGeneratorRoom.have_value = false;
              }
            if (fieldGeneratorRoomName.have_value)
              {
                result.setRoomName(fieldGeneratorRoomName.value);
                fieldGeneratorRoomName.have_value = false;
              }
            if (fieldGeneratorRoomNumber.have_value)
              {
                result.setRoomNumber(fieldGeneratorRoomNumber.value);
                fieldGeneratorRoomNumber.have_value = false;
              }
            if (fieldGeneratorSubQueryId.have_value)
              {
                result.setSubQueryId(fieldGeneratorSubQueryId.value);
                fieldGeneratorSubQueryId.have_value = false;
              }
          }
        protected abstract void handle_result(CiscoSparkRoomDetailJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'R':
                    if (String.Compare(field_name, 1, "oom", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorRoom;
                          }
                        switch (field_name[4])
                          {
                            case 'N':
                                switch (field_name[5])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 6, "me", 0, 2, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorRoomName;
                                        break;
                                    case 'u':
                                        if ((String.Compare(field_name, 6, "mber", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorRoomNumber;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ubQueryId", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSubQueryId;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRoom = new FieldHoldingGeneratorRoom("field \"Room\" of the CiscoSparkRoomDetail class");
            fieldGeneratorRoomName = new JSONHoldingStringGenerator("field \"RoomName\" of the CiscoSparkRoomDetail class");
            fieldGeneratorRoomNumber = new JSONHoldingStringGenerator("field \"RoomNumber\" of the CiscoSparkRoomDetail class");
            fieldGeneratorSubQueryId = new JSONHoldingStringGenerator("field \"SubQueryId\" of the CiscoSparkRoomDetail class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CiscoSparkRoomDetail class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRoom = new FieldHoldingGeneratorRoom("field \"Room\" of the CiscoSparkRoomDetail class");
            fieldGeneratorRoomName = new JSONHoldingStringGenerator("field \"RoomName\" of the CiscoSparkRoomDetail class");
            fieldGeneratorRoomNumber = new JSONHoldingStringGenerator("field \"RoomNumber\" of the CiscoSparkRoomDetail class");
            fieldGeneratorSubQueryId = new JSONHoldingStringGenerator("field \"SubQueryId\" of the CiscoSparkRoomDetail class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CiscoSparkRoomDetail class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRoom.reset();
            fieldGeneratorRoomName.reset();
            fieldGeneratorRoomNumber.reset();
            fieldGeneratorSubQueryId.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CiscoSparkRoomDetailJSON  result)
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
        public CiscoSparkRoomDetailJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CiscoSparkRoomDetailJSON  result)
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
    protected virtual void handle_result(List<CiscoSparkRoomDetailJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CiscoSparkRoomDetailJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CiscoSparkRoomDetailJSON>();
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
    public List<CiscoSparkRoomDetailJSON> value;
  };
  };
