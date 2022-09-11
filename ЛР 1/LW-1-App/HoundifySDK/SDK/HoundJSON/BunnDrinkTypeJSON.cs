/* file "BunnDrinkTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BunnDrinkTypeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_BreakfastBlend,
        Value_ChaiLatte,
        Value_DailySpecial,
        Value_HotChocolate,
        Value_HotWater,
        Value_IcedBreakfastBlend,
        Value_MostPopular,
        Value_PikePlace,
        Value_PikePlaceDecaf,
        Value_Veranda,
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
            case 'B':
                if ((String.Compare(chars, 1, "reakfastBlend", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeValueKnownValues.Value_BreakfastBlend;
                break;
            case 'C':
                if ((String.Compare(chars, 1, "haiLatte", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeValueKnownValues.Value_ChaiLatte;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ailySpecial", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeValueKnownValues.Value_DailySpecial;
                break;
            case 'H':
                if (String.Compare(chars, 1, "ot", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'C':
                            if ((String.Compare(chars, 4, "hocolate", 0, 8, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_HotChocolate;
                            break;
                        case 'W':
                            if ((String.Compare(chars, 4, "ater", 0, 4, false) == 0) && (chars.Length == 8))
                                return TypeValueKnownValues.Value_HotWater;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(chars, 1, "cedBreakfastBlend", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeValueKnownValues.Value_IcedBreakfastBlend;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "ostPopular", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeValueKnownValues.Value_MostPopular;
                break;
            case 'P':
                if (String.Compare(chars, 1, "ikePlace", 0, 8, false) == 0)
                  {
                    if (chars.Length == 9)
                      {
                        return TypeValueKnownValues.Value_PikePlace;
                      }
                    switch (chars[9])
                      {
                        case 'D':
                            if ((String.Compare(chars, 10, "ecaf", 0, 4, false) == 0) && (chars.Length == 14))
                                return TypeValueKnownValues.Value_PikePlaceDecaf;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(chars, 1, "eranda", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValueKnownValues.Value_Veranda;
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
            case TypeValueKnownValues.Value_BreakfastBlend:
                return "BreakfastBlend";
            case TypeValueKnownValues.Value_ChaiLatte:
                return "ChaiLatte";
            case TypeValueKnownValues.Value_DailySpecial:
                return "DailySpecial";
            case TypeValueKnownValues.Value_HotChocolate:
                return "HotChocolate";
            case TypeValueKnownValues.Value_HotWater:
                return "HotWater";
            case TypeValueKnownValues.Value_IcedBreakfastBlend:
                return "IcedBreakfastBlend";
            case TypeValueKnownValues.Value_MostPopular:
                return "MostPopular";
            case TypeValueKnownValues.Value_PikePlace:
                return "PikePlace";
            case TypeValueKnownValues.Value_PikePlaceDecaf:
                return "PikePlaceDecaf";
            case TypeValueKnownValues.Value_Veranda:
                return "Veranda";
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
            throw new Exception("The value for field Value of BunnDrinkTypeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "reakfastBlend", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_BreakfastBlend;
                        goto open_enum_is_done;
                      }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "haiLatte", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_ChaiLatte;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ailySpecial", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_DailySpecial;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if (String.Compare(json_string.getData(), 1, "ot", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'C':
                            if ((String.Compare(json_string.getData(), 4, "hocolate", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_HotChocolate;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'W':
                            if ((String.Compare(json_string.getData(), 4, "ater", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_HotWater;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "cedBreakfastBlend", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_IcedBreakfastBlend;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ostPopular", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_MostPopular;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if (String.Compare(json_string.getData(), 1, "ikePlace", 0, 8, false) == 0)
                  {
                    if (json_string.getData().Length == 9)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_PikePlace;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[9])
                      {
                        case 'D':
                            if ((String.Compare(json_string.getData(), 10, "ecaf", 0, 4, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_PikePlaceDecaf;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "eranda", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Veranda;
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


    public BunnDrinkTypeJSON()
      {
        flagHasValue = false;
      }

    public BunnDrinkTypeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public BunnDrinkTypeJSON(string init_value)
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

    public BunnDrinkTypeJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_BreakfastBlend:
                    handler.string_value("BreakfastBlend");
                    break;
                case TypeValueKnownValues.Value_ChaiLatte:
                    handler.string_value("ChaiLatte");
                    break;
                case TypeValueKnownValues.Value_DailySpecial:
                    handler.string_value("DailySpecial");
                    break;
                case TypeValueKnownValues.Value_HotChocolate:
                    handler.string_value("HotChocolate");
                    break;
                case TypeValueKnownValues.Value_HotWater:
                    handler.string_value("HotWater");
                    break;
                case TypeValueKnownValues.Value_IcedBreakfastBlend:
                    handler.string_value("IcedBreakfastBlend");
                    break;
                case TypeValueKnownValues.Value_MostPopular:
                    handler.string_value("MostPopular");
                    break;
                case TypeValueKnownValues.Value_PikePlace:
                    handler.string_value("PikePlace");
                    break;
                case TypeValueKnownValues.Value_PikePlaceDecaf:
                    handler.string_value("PikePlaceDecaf");
                    break;
                case TypeValueKnownValues.Value_Veranda:
                    handler.string_value("Veranda");
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
                case TypeValueKnownValues.Value_BreakfastBlend:
                    handler.string_value("BreakfastBlend");
                    break;
                case TypeValueKnownValues.Value_ChaiLatte:
                    handler.string_value("ChaiLatte");
                    break;
                case TypeValueKnownValues.Value_DailySpecial:
                    handler.string_value("DailySpecial");
                    break;
                case TypeValueKnownValues.Value_HotChocolate:
                    handler.string_value("HotChocolate");
                    break;
                case TypeValueKnownValues.Value_HotWater:
                    handler.string_value("HotWater");
                    break;
                case TypeValueKnownValues.Value_IcedBreakfastBlend:
                    handler.string_value("IcedBreakfastBlend");
                    break;
                case TypeValueKnownValues.Value_MostPopular:
                    handler.string_value("MostPopular");
                    break;
                case TypeValueKnownValues.Value_PikePlace:
                    handler.string_value("PikePlace");
                    break;
                case TypeValueKnownValues.Value_PikePlaceDecaf:
                    handler.string_value("PikePlaceDecaf");
                    break;
                case TypeValueKnownValues.Value_Veranda:
                    handler.string_value("Veranda");
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

    public static BunnDrinkTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BunnDrinkTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnDrinkType", ignore_extras);
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
    public static BunnDrinkTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BunnDrinkTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BunnDrinkTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnDrinkType", ignore_extras);
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
    public static BunnDrinkTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BunnDrinkTypeJSON from_text(string text, bool ignore_extras)
      {
        BunnDrinkTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnDrinkType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BunnDrinkTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BunnDrinkTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BunnDrinkTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnDrinkType", ignore_extras);
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
            BunnDrinkTypeJSON result = new BunnDrinkTypeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(BunnDrinkTypeJSON new_result);
        public Generator(bool ignore_extras) : base("Type BunnDrinkType")
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
        protected override void handle_result(BunnDrinkTypeJSON  result)
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
        public BunnDrinkTypeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BunnDrinkTypeJSON  result)
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
    protected virtual void handle_result(List<BunnDrinkTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BunnDrinkTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BunnDrinkTypeJSON>();
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
    public List<BunnDrinkTypeJSON> value;
  };
  };
