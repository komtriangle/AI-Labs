/* file "SportsPlayerDetailJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsPlayerDetailJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Team,
        Value_League,
        Value_Position,
        Value_JerseyNumber,
        Value_Weight,
        Value_Height,
        Value_ThrowHand,
        Value_BatHand,
        Value_BirthDate,
        Value_Age,
        Value_BirthLocation,
        Value_College,
        Value_HighSchool,
        Value_Experience,
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
            case 'A':
                if ((String.Compare(chars, 1, "ge", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeValueKnownValues.Value_Age;
                break;
            case 'B':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "tHand", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_BatHand;
                        break;
                    case 'i':
                        if (String.Compare(chars, 2, "rth", 0, 3, false) == 0)
                          {
                            switch (chars[5])
                              {
                                case 'D':
                                    if ((String.Compare(chars, 6, "ate", 0, 3, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_BirthDate;
                                    break;
                                case 'L':
                                    if ((String.Compare(chars, 6, "ocation", 0, 7, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_BirthLocation;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(chars, 1, "ollege", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValueKnownValues.Value_College;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "xperience", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeValueKnownValues.Value_Experience;
                break;
            case 'H':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "ight", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Height;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "ghSchool", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeValueKnownValues.Value_HighSchool;
                        break;
                    default:
                        break;
                  }
                break;
            case 'J':
                if ((String.Compare(chars, 1, "erseyNumber", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeValueKnownValues.Value_JerseyNumber;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "eague", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValueKnownValues.Value_League;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "osition", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeValueKnownValues.Value_Position;
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "am", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Team;
                        break;
                    case 'h':
                        if ((String.Compare(chars, 2, "rowHand", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_ThrowHand;
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(chars, 1, "eight", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValueKnownValues.Value_Weight;
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
            case TypeValueKnownValues.Value_Team:
                return "Team";
            case TypeValueKnownValues.Value_League:
                return "League";
            case TypeValueKnownValues.Value_Position:
                return "Position";
            case TypeValueKnownValues.Value_JerseyNumber:
                return "JerseyNumber";
            case TypeValueKnownValues.Value_Weight:
                return "Weight";
            case TypeValueKnownValues.Value_Height:
                return "Height";
            case TypeValueKnownValues.Value_ThrowHand:
                return "ThrowHand";
            case TypeValueKnownValues.Value_BatHand:
                return "BatHand";
            case TypeValueKnownValues.Value_BirthDate:
                return "BirthDate";
            case TypeValueKnownValues.Value_Age:
                return "Age";
            case TypeValueKnownValues.Value_BirthLocation:
                return "BirthLocation";
            case TypeValueKnownValues.Value_College:
                return "College";
            case TypeValueKnownValues.Value_HighSchool:
                return "HighSchool";
            case TypeValueKnownValues.Value_Experience:
                return "Experience";
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
            throw new Exception("The value for field Value of SportsPlayerDetailJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ge", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Age;
                        goto open_enum_is_done;
                      }
                break;
            case 'B':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "tHand", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_BatHand;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if (String.Compare(json_string.getData(), 2, "rth", 0, 3, false) == 0)
                          {
                            switch (json_string.getData()[5])
                              {
                                case 'D':
                                    if ((String.Compare(json_string.getData(), 6, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_BirthDate;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'L':
                                    if ((String.Compare(json_string.getData(), 6, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_BirthLocation;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "ollege", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_College;
                        goto open_enum_is_done;
                      }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "xperience", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Experience;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ight", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Height;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ghSchool", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_HighSchool;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'J':
                if ((String.Compare(json_string.getData(), 1, "erseyNumber", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_JerseyNumber;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "eague", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_League;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "osition", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Position;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "am", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Team;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "rowHand", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_ThrowHand;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "eight", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Weight;
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


    public SportsPlayerDetailJSON()
      {
        flagHasValue = false;
      }

    public SportsPlayerDetailJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsPlayerDetailJSON(string init_value)
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

    public SportsPlayerDetailJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_Team:
                    handler.string_value("Team");
                    break;
                case TypeValueKnownValues.Value_League:
                    handler.string_value("League");
                    break;
                case TypeValueKnownValues.Value_Position:
                    handler.string_value("Position");
                    break;
                case TypeValueKnownValues.Value_JerseyNumber:
                    handler.string_value("JerseyNumber");
                    break;
                case TypeValueKnownValues.Value_Weight:
                    handler.string_value("Weight");
                    break;
                case TypeValueKnownValues.Value_Height:
                    handler.string_value("Height");
                    break;
                case TypeValueKnownValues.Value_ThrowHand:
                    handler.string_value("ThrowHand");
                    break;
                case TypeValueKnownValues.Value_BatHand:
                    handler.string_value("BatHand");
                    break;
                case TypeValueKnownValues.Value_BirthDate:
                    handler.string_value("BirthDate");
                    break;
                case TypeValueKnownValues.Value_Age:
                    handler.string_value("Age");
                    break;
                case TypeValueKnownValues.Value_BirthLocation:
                    handler.string_value("BirthLocation");
                    break;
                case TypeValueKnownValues.Value_College:
                    handler.string_value("College");
                    break;
                case TypeValueKnownValues.Value_HighSchool:
                    handler.string_value("HighSchool");
                    break;
                case TypeValueKnownValues.Value_Experience:
                    handler.string_value("Experience");
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
                case TypeValueKnownValues.Value_Team:
                    handler.string_value("Team");
                    break;
                case TypeValueKnownValues.Value_League:
                    handler.string_value("League");
                    break;
                case TypeValueKnownValues.Value_Position:
                    handler.string_value("Position");
                    break;
                case TypeValueKnownValues.Value_JerseyNumber:
                    handler.string_value("JerseyNumber");
                    break;
                case TypeValueKnownValues.Value_Weight:
                    handler.string_value("Weight");
                    break;
                case TypeValueKnownValues.Value_Height:
                    handler.string_value("Height");
                    break;
                case TypeValueKnownValues.Value_ThrowHand:
                    handler.string_value("ThrowHand");
                    break;
                case TypeValueKnownValues.Value_BatHand:
                    handler.string_value("BatHand");
                    break;
                case TypeValueKnownValues.Value_BirthDate:
                    handler.string_value("BirthDate");
                    break;
                case TypeValueKnownValues.Value_Age:
                    handler.string_value("Age");
                    break;
                case TypeValueKnownValues.Value_BirthLocation:
                    handler.string_value("BirthLocation");
                    break;
                case TypeValueKnownValues.Value_College:
                    handler.string_value("College");
                    break;
                case TypeValueKnownValues.Value_HighSchool:
                    handler.string_value("HighSchool");
                    break;
                case TypeValueKnownValues.Value_Experience:
                    handler.string_value("Experience");
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

    public static SportsPlayerDetailJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayerDetailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerDetail", ignore_extras);
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
    public static SportsPlayerDetailJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayerDetailJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayerDetailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerDetail", ignore_extras);
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
    public static SportsPlayerDetailJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayerDetailJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayerDetailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerDetail", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayerDetailJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayerDetailJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayerDetailJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerDetail", ignore_extras);
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
            SportsPlayerDetailJSON result = new SportsPlayerDetailJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsPlayerDetailJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsPlayerDetail")
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
        protected override void handle_result(SportsPlayerDetailJSON  result)
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
        public SportsPlayerDetailJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayerDetailJSON  result)
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
    protected virtual void handle_result(List<SportsPlayerDetailJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayerDetailJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayerDetailJSON>();
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
    public List<SportsPlayerDetailJSON> value;
  };
  };
