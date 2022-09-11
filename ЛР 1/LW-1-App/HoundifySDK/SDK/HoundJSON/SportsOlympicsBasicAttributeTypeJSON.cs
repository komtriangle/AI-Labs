/* file "SportsOlympicsBasicAttributeTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsBasicAttributeTypeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Location,
        Value_Date,
        Value_OpeningCeremonyDate,
        Value_ClosingCeremonyDate,
        Value_GamesInLocation,
        Value_GamesInYear,
        Value__none
      };
    public struct TypeValue
      {
        public bool in_known_list;
        public string string_value;
        public TypeValueKnownValues list_value;
      };

    public static TypeValueKnownValues  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "losingCeremonyDate", 0, 18, false) == 0) && (chars.Length == 19))
                    return TypeValueKnownValues.Value_ClosingCeremonyDate;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ate", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_Date;
                break;
            case 'G':
                if (String.Compare(chars, 1, "amesIn", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'L':
                            if ((String.Compare(chars, 8, "ocation", 0, 7, false) == 0) && (chars.Length == 15))
                                return TypeValueKnownValues.Value_GamesInLocation;
                            break;
                        case 'Y':
                            if ((String.Compare(chars, 8, "ear", 0, 3, false) == 0) && (chars.Length == 11))
                                return TypeValueKnownValues.Value_GamesInYear;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ocation", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeValueKnownValues.Value_Location;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "peningCeremonyDate", 0, 18, false) == 0) && (chars.Length == 19))
                    return TypeValueKnownValues.Value_OpeningCeremonyDate;
                break;
            default:
                break;
          }
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_Location:
                return "Location";
            case TypeValueKnownValues.Value_Date:
                return "Date";
            case TypeValueKnownValues.Value_OpeningCeremonyDate:
                return "OpeningCeremonyDate";
            case TypeValueKnownValues.Value_ClosingCeremonyDate:
                return "ClosingCeremonyDate";
            case TypeValueKnownValues.Value_GamesInLocation:
                return "GamesInLocation";
            case TypeValueKnownValues.Value_GamesInYear:
                return "GamesInYear";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of SportsOlympicsBasicAttributeTypeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "losingCeremonyDate", 0, 18, false) == 0) && (json_string.getData().Length == 19))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_ClosingCeremonyDate;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Date;
                        goto open_enum_is_done;
                      }
                break;
            case 'G':
                if (String.Compare(json_string.getData(), 1, "amesIn", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'L':
                            if ((String.Compare(json_string.getData(), 8, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_GamesInLocation;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'Y':
                            if ((String.Compare(json_string.getData(), 8, "ear", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_GamesInYear;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Location;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "peningCeremonyDate", 0, 18, false) == 0) && (json_string.getData().Length == 19))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_OpeningCeremonyDate;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public SportsOlympicsBasicAttributeTypeJSON()
      {
        flagHasValue = false;
      }

    public SportsOlympicsBasicAttributeTypeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsOlympicsBasicAttributeTypeJSON(string init_value)
      {
        flagHasValue = true;
        TypeValueKnownValues known = stringToValue(init_value);
        if (known == TypeValueKnownValues.Value__none)
          {
            storeValue.in_known_list = false;
            storeValue.string_value = init_value;
          }
        else
          {
            storeValue.in_known_list = true;
            storeValue.list_value = known;
          }
      }

    public SportsOlympicsBasicAttributeTypeJSON(TypeValueKnownValues init_value)
      {
        flagHasValue = true;
        Debug.Assert(init_value != TypeValueKnownValues.Value__none);
        storeValue.in_known_list = true;
        storeValue.list_value = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public string  getValueAsString()
      {
        TypeValue result = getValue();
        if (result.in_known_list)
            return stringFromValue(result.list_value);
        else
            return result.string_value;
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        TypeValueKnownValues known = stringToValue(chars);
        TypeValue new_value = new TypeValue();
        if (known == TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setValue(new_value);
      }
    public void setValue(TypeValueKnownValues new_value)
      {
        TypeValue new_full_value = new TypeValue();
        Debug.Assert(new_value != TypeValueKnownValues.Value__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setValue(new_full_value);
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_Location:
                    handler.string_value("Location");
                    break;
                case TypeValueKnownValues.Value_Date:
                    handler.string_value("Date");
                    break;
                case TypeValueKnownValues.Value_OpeningCeremonyDate:
                    handler.string_value("OpeningCeremonyDate");
                    break;
                case TypeValueKnownValues.Value_ClosingCeremonyDate:
                    handler.string_value("ClosingCeremonyDate");
                    break;
                case TypeValueKnownValues.Value_GamesInLocation:
                    handler.string_value("GamesInLocation");
                    break;
                case TypeValueKnownValues.Value_GamesInYear:
                    handler.string_value("GamesInYear");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_Location:
                    handler.string_value("Location");
                    break;
                case TypeValueKnownValues.Value_Date:
                    handler.string_value("Date");
                    break;
                case TypeValueKnownValues.Value_OpeningCeremonyDate:
                    handler.string_value("OpeningCeremonyDate");
                    break;
                case TypeValueKnownValues.Value_ClosingCeremonyDate:
                    handler.string_value("ClosingCeremonyDate");
                    break;
                case TypeValueKnownValues.Value_GamesInLocation:
                    handler.string_value("GamesInLocation");
                    break;
                case TypeValueKnownValues.Value_GamesInYear:
                    handler.string_value("GamesInYear");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }

    public static SportsOlympicsBasicAttributeTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsBasicAttributeTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeType", ignore_extras);
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
    public static SportsOlympicsBasicAttributeTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsBasicAttributeTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsBasicAttributeTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeType", ignore_extras);
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
    public static SportsOlympicsBasicAttributeTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsBasicAttributeTypeJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsBasicAttributeTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsBasicAttributeTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsBasicAttributeTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsBasicAttributeTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeType", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        protected FieldGeneratorValue(string what)
          {
            set_what(what);
          }
        protected FieldGeneratorValue()
          {
          }
        protected override void handle_result(string result)
          {
            TypeValueKnownValues known = stringToValue(result);
            TypeValue new_value = new TypeValue();
            if (known == TypeValueKnownValues.Value__none)
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
        protected abstract void handle_result(TypeValue result);
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(TypeValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public TypeValue value;
  };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue new_value)
          {
            SportsOlympicsBasicAttributeTypeJSON result = new SportsOlympicsBasicAttributeTypeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsOlympicsBasicAttributeTypeJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsOlympicsBasicAttributeType")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsBasicAttributeTypeJSON  result)
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
        public SportsOlympicsBasicAttributeTypeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsBasicAttributeTypeJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsBasicAttributeTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsBasicAttributeTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsBasicAttributeTypeJSON>();
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
    public List<SportsOlympicsBasicAttributeTypeJSON> value;
  };
  };
