/* file "CalendarLocationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class CalendarLocationJSON : JSONBase
  {
    public enum TypeTypeKnownValues
      {
        Type_BasicLocation,
        Type_Room,
        Type_FindRoomIntent,
        Type_Undefined,
        Type__none
      };
    public struct TypeType
      {
        public bool in_known_list;
        public string string_value;
        public TypeTypeKnownValues list_value;
      };

    public static TypeTypeKnownValues  stringToType(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "asicLocation", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeTypeKnownValues.Type_BasicLocation;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "indRoomIntent", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeTypeKnownValues.Type_FindRoomIntent;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "oom", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeTypeKnownValues.Type_Room;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "ndefined", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeTypeKnownValues.Type_Undefined;
                break;
            default:
                break;
          }
        return TypeTypeKnownValues.Type__none;
      }

    public static string  stringFromType(TypeTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTypeKnownValues.Type_BasicLocation:
                return "BasicLocation";
            case TypeTypeKnownValues.Type_Room:
                return "Room";
            case TypeTypeKnownValues.Type_FindRoomIntent:
                return "FindRoomIntent";
            case TypeTypeKnownValues.Type_Undefined:
                return "Undefined";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasType;
    private TypeType storeType;
    private bool flagHasName;
    private string storeName;
    private bool flagHasEmail;
    private string storeEmail;
    private bool flagHasDesiredCapacity;
    private BigInteger storeDesiredCapacity;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of CalendarLocationJSON is not a string.");
        TypeType the_open_enum = new TypeType();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "asicLocation", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_BasicLocation;
                        goto open_enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "indRoomIntent", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_FindRoomIntent;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "oom", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_Room;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "ndefined", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_Undefined;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setType(the_open_enum);
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of CalendarLocationJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONEmail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Email of CalendarLocationJSON is not a string.");
        setEmail(json_string.getData());
      }


    private void  fromJSONDesiredCapacity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DesiredCapacity of CalendarLocationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DesiredCapacity of CalendarLocationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDesiredCapacity(extracted_integer);
      }


    public CalendarLocationJSON()
      {
        flagHasType = false;
        flagHasName = false;
        flagHasEmail = false;
        flagHasDesiredCapacity = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public TypeType  getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public string  getTypeAsString()
      {
        TypeType result = getType();
        if (result.in_known_list)
            return stringFromType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasEmail()
      {
        return flagHasEmail;
      }

    public string  getEmail()
      {
        Debug.Assert(flagHasEmail);
        return storeEmail;
      }

    public bool  hasDesiredCapacity()
      {
        return flagHasDesiredCapacity;
      }

    public BigInteger  getDesiredCapacity()
      {
        Debug.Assert(flagHasDesiredCapacity);
        return storeDesiredCapacity;
      }


    public virtual int extraCalendarLocationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarLocationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarLocationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarLocationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setType(TypeType new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(string chars)
      {
        TypeTypeKnownValues known = stringToType(chars);
        TypeType new_value = new TypeType();
        if (known == TypeTypeKnownValues.Type__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void setType(TypeTypeKnownValues new_value)
      {
        TypeType new_full_value = new TypeType();
        Debug.Assert(new_value != TypeTypeKnownValues.Type__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setType(new_full_value);
      }
    public void unsetType()
      {
        flagHasType = false;
      }
    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setEmail(string new_value)
      {
        flagHasEmail = true;
        storeEmail = new_value;
      }
    public void unsetEmail()
      {
        flagHasEmail = false;
      }
    public void setDesiredCapacity(BigInteger new_value)
      {
        flagHasDesiredCapacity = true;
        storeDesiredCapacity = new_value;
      }
    public void unsetDesiredCapacity()
      {
        flagHasDesiredCapacity = false;
      }

    public virtual void extraCalendarLocationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarLocationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarLocationLookup(key);
        if (old_field == null)
          {
            extraCalendarLocationAppendPair(key, new_component);
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
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (storeType.in_known_list)
              {
                switch (storeType.list_value)
                  {
                    case TypeTypeKnownValues.Type_BasicLocation:
                        handler.string_value("BasicLocation");
                        break;
                    case TypeTypeKnownValues.Type_Room:
                        handler.string_value("Room");
                        break;
                    case TypeTypeKnownValues.Type_FindRoomIntent:
                        handler.string_value("FindRoomIntent");
                        break;
                    case TypeTypeKnownValues.Type_Undefined:
                        handler.string_value("Undefined");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeType.string_value);
              }
          }
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasEmail)
          {
            handler.start_pair("Email");
            handler.string_value(storeEmail);
          }
        if (flagHasDesiredCapacity)
          {
            handler.start_pair("DesiredCapacity");
            handler.number_value(storeDesiredCapacity);
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

    public static CalendarLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarLocation", ignore_extras);
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
    public static CalendarLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarLocation", ignore_extras);
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
    public static CalendarLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarLocationJSON from_text(string text, bool ignore_extras)
      {
        CalendarLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarLocation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarLocationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CalendarLocationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarLocation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorType : JSONStringGenerator
          {
            protected FieldGeneratorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTypeKnownValues known = stringToType(result);
                TypeType new_value = new TypeType();
                if (known == TypeTypeKnownValues.Type__none)
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
            protected abstract void handle_result(TypeType result);
          };
    private class FieldHoldingGeneratorType : FieldGeneratorType
  {
    protected override void handle_result(TypeType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorType(String what)
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
    public TypeType value;
  };
    private class FieldHoldingArrayGeneratorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorType
      {
        private FieldHoldingArrayGeneratorType top;

        protected override void handle_result(TypeType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorType init_top)
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
    protected virtual void handle_result(List<TypeType> result)
      {
      }

    public FieldHoldingArrayGeneratorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeType> value;
  };
        private FieldHoldingGeneratorType fieldGeneratorType;
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorEmail;
    private class FieldHoldingGeneratorDesiredCapacity : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorDesiredCapacity(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDesiredCapacity : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDesiredCapacity(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorDesiredCapacity fieldGeneratorDesiredCapacity;
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
            CalendarLocationJSON result = new CalendarLocationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarLocationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CalendarLocationJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            if (fieldGeneratorEmail.have_value)
              {
                result.setEmail(fieldGeneratorEmail.value);
                fieldGeneratorEmail.have_value = false;
              }
            if (fieldGeneratorDesiredCapacity.have_value)
              {
                result.setDesiredCapacity(fieldGeneratorDesiredCapacity.value);
                fieldGeneratorDesiredCapacity.have_value = false;
              }
          }
        protected abstract void handle_result(CalendarLocationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "esiredCapacity", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorDesiredCapacity;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "mail", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorEmail;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the CalendarLocation class");
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the CalendarLocation class");
            fieldGeneratorEmail = new JSONHoldingStringGenerator("field \"Email\" of the CalendarLocation class");
            fieldGeneratorDesiredCapacity = new FieldHoldingGeneratorDesiredCapacity("field \"DesiredCapacity\" of the CalendarLocation class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarLocation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the CalendarLocation class");
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the CalendarLocation class");
            fieldGeneratorEmail = new JSONHoldingStringGenerator("field \"Email\" of the CalendarLocation class");
            fieldGeneratorDesiredCapacity = new FieldHoldingGeneratorDesiredCapacity("field \"DesiredCapacity\" of the CalendarLocation class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarLocation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorName.reset();
            fieldGeneratorEmail.reset();
            fieldGeneratorDesiredCapacity.reset();
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
        protected override void handle_result(CalendarLocationJSON  result)
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
        public CalendarLocationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarLocationJSON  result)
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
    protected virtual void handle_result(List<CalendarLocationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarLocationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarLocationJSON>();
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
    public List<CalendarLocationJSON> value;
  };
  };
