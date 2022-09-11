/* file "SportsOlympicsMedalStandingsErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsMedalStandingsErrorJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_DataUnavailable,
        Value_NoOrganizationInRank,
        Value_OrganizationNotFound,
        Value_OlympicsGamesNotStarted,
        Value_NoOrganizationsInResponse,
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
            case 'D':
                if ((String.Compare(chars, 1, "ataUnavailable", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeValueKnownValues.Value_DataUnavailable;
                break;
            case 'N':
                if (String.Compare(chars, 1, "oOrganization", 0, 13, false) == 0)
                  {
                    switch (chars[14])
                      {
                        case 'I':
                            if ((String.Compare(chars, 15, "nRank", 0, 5, false) == 0) && (chars.Length == 20))
                                return TypeValueKnownValues.Value_NoOrganizationInRank;
                            break;
                        case 's':
                            if ((String.Compare(chars, 15, "InResponse", 0, 10, false) == 0) && (chars.Length == 25))
                                return TypeValueKnownValues.Value_NoOrganizationsInResponse;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "ympicsGamesNotStarted", 0, 21, false) == 0) && (chars.Length == 23))
                            return TypeValueKnownValues.Value_OlympicsGamesNotStarted;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "ganizationNotFound", 0, 18, false) == 0) && (chars.Length == 20))
                            return TypeValueKnownValues.Value_OrganizationNotFound;
                        break;
                    default:
                        break;
                  }
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
            case TypeValueKnownValues.Value_DataUnavailable:
                return "DataUnavailable";
            case TypeValueKnownValues.Value_NoOrganizationInRank:
                return "NoOrganizationInRank";
            case TypeValueKnownValues.Value_OrganizationNotFound:
                return "OrganizationNotFound";
            case TypeValueKnownValues.Value_OlympicsGamesNotStarted:
                return "OlympicsGamesNotStarted";
            case TypeValueKnownValues.Value_NoOrganizationsInResponse:
                return "NoOrganizationsInResponse";
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
            throw new Exception("The value for field Value of SportsOlympicsMedalStandingsErrorJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ataUnavailable", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_DataUnavailable;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "oOrganization", 0, 13, false) == 0)
                  {
                    switch (json_string.getData()[14])
                      {
                        case 'I':
                            if ((String.Compare(json_string.getData(), 15, "nRank", 0, 5, false) == 0) && (json_string.getData().Length == 20))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_NoOrganizationInRank;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 's':
                            if ((String.Compare(json_string.getData(), 15, "InResponse", 0, 10, false) == 0) && (json_string.getData().Length == 25))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_NoOrganizationsInResponse;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ympicsGamesNotStarted", 0, 21, false) == 0) && (json_string.getData().Length == 23))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_OlympicsGamesNotStarted;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "ganizationNotFound", 0, 18, false) == 0) && (json_string.getData().Length == 20))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_OrganizationNotFound;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
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


    public SportsOlympicsMedalStandingsErrorJSON()
      {
        flagHasValue = false;
      }

    public SportsOlympicsMedalStandingsErrorJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsOlympicsMedalStandingsErrorJSON(string init_value)
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

    public SportsOlympicsMedalStandingsErrorJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_DataUnavailable:
                    handler.string_value("DataUnavailable");
                    break;
                case TypeValueKnownValues.Value_NoOrganizationInRank:
                    handler.string_value("NoOrganizationInRank");
                    break;
                case TypeValueKnownValues.Value_OrganizationNotFound:
                    handler.string_value("OrganizationNotFound");
                    break;
                case TypeValueKnownValues.Value_OlympicsGamesNotStarted:
                    handler.string_value("OlympicsGamesNotStarted");
                    break;
                case TypeValueKnownValues.Value_NoOrganizationsInResponse:
                    handler.string_value("NoOrganizationsInResponse");
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
                case TypeValueKnownValues.Value_DataUnavailable:
                    handler.string_value("DataUnavailable");
                    break;
                case TypeValueKnownValues.Value_NoOrganizationInRank:
                    handler.string_value("NoOrganizationInRank");
                    break;
                case TypeValueKnownValues.Value_OrganizationNotFound:
                    handler.string_value("OrganizationNotFound");
                    break;
                case TypeValueKnownValues.Value_OlympicsGamesNotStarted:
                    handler.string_value("OlympicsGamesNotStarted");
                    break;
                case TypeValueKnownValues.Value_NoOrganizationsInResponse:
                    handler.string_value("NoOrganizationsInResponse");
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

    public static SportsOlympicsMedalStandingsErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsError", ignore_extras);
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
    public static SportsOlympicsMedalStandingsErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsMedalStandingsErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsError", ignore_extras);
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
    public static SportsOlympicsMedalStandingsErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsMedalStandingsErrorJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsMedalStandingsErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsMedalStandingsErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsError", ignore_extras);
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
            SportsOlympicsMedalStandingsErrorJSON result = new SportsOlympicsMedalStandingsErrorJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsOlympicsMedalStandingsErrorJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsOlympicsMedalStandingsError")
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
        protected override void handle_result(SportsOlympicsMedalStandingsErrorJSON  result)
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
        public SportsOlympicsMedalStandingsErrorJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsMedalStandingsErrorJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsMedalStandingsErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsMedalStandingsErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsMedalStandingsErrorJSON>();
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
    public List<SportsOlympicsMedalStandingsErrorJSON> value;
  };
  };
