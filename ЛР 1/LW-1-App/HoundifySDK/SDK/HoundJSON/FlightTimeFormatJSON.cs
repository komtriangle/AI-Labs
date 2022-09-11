/* file "FlightTimeFormatJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightTimeFormatJSON : JSONBase
  {
    public enum TypeFormat
      {
        Format_DateTime,
        Format_TimeTill,
        Format_HowLateEarly
      };

    public static TypeFormat  stringToFormat(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if ((String.Compare(chars, 1, "ateTime", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeFormat.Format_DateTime;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "owLateEarly", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeFormat.Format_HowLateEarly;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "imeTill", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeFormat.Format_TimeTill;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Format' is not one of the legal values.");
      }

    public static string  stringFromFormat(TypeFormat the_enum)
      {
        switch (the_enum)
          {
            case TypeFormat.Format_DateTime:
                return "DateTime";
            case TypeFormat.Format_TimeTill:
                return "TimeTill";
            case TypeFormat.Format_HowLateEarly:
                return "HowLateEarly";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeUnit
      {
        Unit_None,
        Unit_Week,
        Unit_Hour,
        Unit_Minute,
        Unit_Second
      };

    public static TypeUnit  stringToUnit(string chars)
      {
        switch (chars[0])
          {
            case 'H':
                if ((String.Compare(chars, 1, "our", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeUnit.Unit_Hour;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "inute", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeUnit.Unit_Minute;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeUnit.Unit_None;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "econd", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeUnit.Unit_Second;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "eek", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeUnit.Unit_Week;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Unit' is not one of the legal values.");
      }

    public static string  stringFromUnit(TypeUnit the_enum)
      {
        switch (the_enum)
          {
            case TypeUnit.Unit_None:
                return "None";
            case TypeUnit.Unit_Week:
                return "Week";
            case TypeUnit.Unit_Hour:
                return "Hour";
            case TypeUnit.Unit_Minute:
                return "Minute";
            case TypeUnit.Unit_Second:
                return "Second";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFormat;
    private TypeFormat storeFormat;
    private bool flagHasUnit;
    private TypeUnit storeUnit;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFormat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Format of FlightTimeFormatJSON is not a string.");
        TypeFormat the_enum;
        switch (json_string.getData()[0])
          {
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ateTime", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeFormat.Format_DateTime;
                        goto enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "owLateEarly", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_enum = TypeFormat.Format_HowLateEarly;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "imeTill", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeFormat.Format_TimeTill;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Format of FlightTimeFormatJSON is not one of the legal strings.");
      enum_is_done:;
        setFormat(the_enum);
      }


    private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Unit of FlightTimeFormatJSON is not a string.");
        TypeUnit the_enum;
        switch (json_string.getData()[0])
          {
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "our", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeUnit.Unit_Hour;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "inute", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeUnit.Unit_Minute;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeUnit.Unit_None;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "econd", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeUnit.Unit_Second;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "eek", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeUnit.Unit_Week;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Unit of FlightTimeFormatJSON is not one of the legal strings.");
      enum_is_done:;
        setUnit(the_enum);
      }


    public FlightTimeFormatJSON()
      {
        flagHasFormat = false;
        flagHasUnit = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFormat()
      {
        return flagHasFormat;
      }

    public TypeFormat  getFormat()
      {
        Debug.Assert(flagHasFormat);
        return storeFormat;
      }

    public string  getFormatAsString()
      {
        return stringFromFormat(getFormat());
      }

    public bool  hasUnit()
      {
        return flagHasUnit;
      }

    public TypeUnit  getUnit()
      {
        Debug.Assert(flagHasUnit);
        return storeUnit;
      }

    public string  getUnitAsString()
      {
        return stringFromUnit(getUnit());
      }


    public virtual int extraFlightTimeFormatComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightTimeFormatComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightTimeFormatComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightTimeFormatLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFormat(TypeFormat new_value)
      {
        flagHasFormat = true;
        storeFormat = new_value;
      }
    public void setFormat(string chars)
      {
        setFormat(stringToFormat(chars));
      }
    public void unsetFormat()
      {
        flagHasFormat = false;
      }
    public void setUnit(TypeUnit new_value)
      {
        flagHasUnit = true;
        storeUnit = new_value;
      }
    public void setUnit(string chars)
      {
        setUnit(stringToUnit(chars));
      }
    public void unsetUnit()
      {
        flagHasUnit = false;
      }

    public virtual void extraFlightTimeFormatAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightTimeFormatSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightTimeFormatLookup(key);
        if (old_field == null)
          {
            extraFlightTimeFormatAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFormat);
        if (flagHasFormat)
          {
            handler.start_pair("Format");
            switch (storeFormat)
              {
                case TypeFormat.Format_DateTime:
                    handler.string_value("DateTime");
                    break;
                case TypeFormat.Format_TimeTill:
                    handler.string_value("TimeTill");
                    break;
                case TypeFormat.Format_HowLateEarly:
                    handler.string_value("HowLateEarly");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasUnit)
          {
            handler.start_pair("Unit");
            switch (storeUnit)
              {
                case TypeUnit.Unit_None:
                    handler.string_value("None");
                    break;
                case TypeUnit.Unit_Week:
                    handler.string_value("Week");
                    break;
                case TypeUnit.Unit_Hour:
                    handler.string_value("Hour");
                    break;
                case TypeUnit.Unit_Minute:
                    handler.string_value("Minute");
                    break;
                case TypeUnit.Unit_Second:
                    handler.string_value("Second");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasFormat()))
          {
            return "When parsing the object for %what%, the \"Format\" field was missing.";
          }
        return null;
      }

    public static FlightTimeFormatJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightTimeFormatJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightTimeFormat", ignore_extras);
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
    public static FlightTimeFormatJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightTimeFormatJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightTimeFormatJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightTimeFormat", ignore_extras);
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
    public static FlightTimeFormatJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightTimeFormatJSON from_text(string text, bool ignore_extras)
      {
        FlightTimeFormatJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightTimeFormat", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightTimeFormatJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightTimeFormatJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightTimeFormatJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightTimeFormat", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorFormat : JSONStringGenerator
          {
            protected FieldGeneratorFormat(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFormat()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFormat(result));
              }
            protected abstract void handle_result(TypeFormat result);
          };
    private class FieldHoldingGeneratorFormat : FieldGeneratorFormat
  {
    protected override void handle_result(TypeFormat result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFormat(String what)
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
    public TypeFormat value;
  };
    private class FieldHoldingArrayGeneratorFormat : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFormat
      {
        private FieldHoldingArrayGeneratorFormat top;

        protected override void handle_result(TypeFormat result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFormat init_top)
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
    protected virtual void handle_result(List<TypeFormat> result)
      {
      }

    public FieldHoldingArrayGeneratorFormat(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormat>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFormat()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormat>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFormat> value;
  };
        private FieldHoldingGeneratorFormat fieldGeneratorFormat;
    private abstract class FieldGeneratorUnit : JSONStringGenerator
          {
            protected FieldGeneratorUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorUnit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToUnit(result));
              }
            protected abstract void handle_result(TypeUnit result);
          };
    private class FieldHoldingGeneratorUnit : FieldGeneratorUnit
  {
    protected override void handle_result(TypeUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorUnit(String what)
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
    public TypeUnit value;
  };
    private class FieldHoldingArrayGeneratorUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorUnit
      {
        private FieldHoldingArrayGeneratorUnit top;

        protected override void handle_result(TypeUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorUnit init_top)
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
    protected virtual void handle_result(List<TypeUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeUnit> value;
  };
        private FieldHoldingGeneratorUnit fieldGeneratorUnit;
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
            FlightTimeFormatJSON result = new FlightTimeFormatJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightTimeFormatAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightTimeFormatJSON result)
          {
            if (fieldGeneratorFormat.have_value)
              {
                result.setFormat(fieldGeneratorFormat.value);
                fieldGeneratorFormat.have_value = false;
              }
            else if ((!(result.hasFormat())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Format\" field was missing.");
              }
            if (fieldGeneratorUnit.have_value)
              {
                result.setUnit(fieldGeneratorUnit.value);
                fieldGeneratorUnit.have_value = false;
              }
          }
        protected abstract void handle_result(FlightTimeFormatJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "ormat", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorFormat;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorUnit;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFormat = new FieldHoldingGeneratorFormat("field \"Format\" of the FlightTimeFormat class");
            fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the FlightTimeFormat class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightTimeFormat class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFormat = new FieldHoldingGeneratorFormat("field \"Format\" of the FlightTimeFormat class");
            fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the FlightTimeFormat class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightTimeFormat class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFormat.reset();
            fieldGeneratorUnit.reset();
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
        protected override void handle_result(FlightTimeFormatJSON  result)
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
        public FlightTimeFormatJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightTimeFormatJSON  result)
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
    protected virtual void handle_result(List<FlightTimeFormatJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightTimeFormatJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightTimeFormatJSON>();
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
    public List<FlightTimeFormatJSON> value;
  };
  };
