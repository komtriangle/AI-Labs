/* file "RiverLocationKindJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RiverLocationKindJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_City,
        Value_UsState,
        Value_Country,
        Value_Continent,
        Value_World,
        Value_Fictional,
        Value_Unhandled,
        Value_Unknown
      };

    public static TypeValue  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "ty", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValue.Value_City;
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'n':
                                if ((String.Compare(chars, 3, "tinent", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValue.Value_Continent;
                                break;
                            case 'u':
                                if ((String.Compare(chars, 3, "ntry", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeValue.Value_Country;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if ((String.Compare(chars, 1, "ictional", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeValue.Value_Fictional;
                break;
            case 'U':
                switch (chars[1])
                  {
                    case 'n':
                        switch (chars[2])
                          {
                            case 'h':
                                if ((String.Compare(chars, 3, "andled", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValue.Value_Unhandled;
                                break;
                            case 'k':
                                if ((String.Compare(chars, 3, "nown", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeValue.Value_Unknown;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 's':
                        if ((String.Compare(chars, 2, "State", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValue.Value_UsState;
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(chars, 1, "orld", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValue.Value_World;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Value' is not one of the legal values.");
      }

    public static string  stringFromValue(TypeValue the_enum)
      {
        switch (the_enum)
          {
            case TypeValue.Value_City:
                return "City";
            case TypeValue.Value_UsState:
                return "UsState";
            case TypeValue.Value_Country:
                return "Country";
            case TypeValue.Value_Continent:
                return "Continent";
            case TypeValue.Value_World:
                return "World";
            case TypeValue.Value_Fictional:
                return "Fictional";
            case TypeValue.Value_Unhandled:
                return "Unhandled";
            case TypeValue.Value_Unknown:
                return "Unknown";
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
            throw new Exception("The value for field Value of RiverLocationKindJSON is not a string.");
        TypeValue the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ty", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_enum = TypeValue.Value_City;
                                goto enum_is_done;
                              }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "tinent", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_enum = TypeValue.Value_Continent;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'u':
                                if ((String.Compare(json_string.getData(), 3, "ntry", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_enum = TypeValue.Value_Country;
                                        goto enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ictional", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeValue.Value_Fictional;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                switch (json_string.getData()[1])
                  {
                    case 'n':
                        switch (json_string.getData()[2])
                          {
                            case 'h':
                                if ((String.Compare(json_string.getData(), 3, "andled", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_enum = TypeValue.Value_Unhandled;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'k':
                                if ((String.Compare(json_string.getData(), 3, "nown", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_enum = TypeValue.Value_Unknown;
                                        goto enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 's':
                        if ((String.Compare(json_string.getData(), 2, "State", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_enum = TypeValue.Value_UsState;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "orld", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeValue.Value_World;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Value of RiverLocationKindJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public RiverLocationKindJSON()
      {
        flagHasValue = false;
      }

    public RiverLocationKindJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public RiverLocationKindJSON(string init_value)
      {
        flagHasValue = true;
        storeValue = stringToValue(init_value);
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
        return stringFromValue(getValue());
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        setValue(stringToValue(chars));
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_City:
                handler.string_value("City");
                break;
            case TypeValue.Value_UsState:
                handler.string_value("UsState");
                break;
            case TypeValue.Value_Country:
                handler.string_value("Country");
                break;
            case TypeValue.Value_Continent:
                handler.string_value("Continent");
                break;
            case TypeValue.Value_World:
                handler.string_value("World");
                break;
            case TypeValue.Value_Fictional:
                handler.string_value("Fictional");
                break;
            case TypeValue.Value_Unhandled:
                handler.string_value("Unhandled");
                break;
            case TypeValue.Value_Unknown:
                handler.string_value("Unknown");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_City:
                handler.string_value("City");
                break;
            case TypeValue.Value_UsState:
                handler.string_value("UsState");
                break;
            case TypeValue.Value_Country:
                handler.string_value("Country");
                break;
            case TypeValue.Value_Continent:
                handler.string_value("Continent");
                break;
            case TypeValue.Value_World:
                handler.string_value("World");
                break;
            case TypeValue.Value_Fictional:
                handler.string_value("Fictional");
                break;
            case TypeValue.Value_Unhandled:
                handler.string_value("Unhandled");
                break;
            case TypeValue.Value_Unknown:
                handler.string_value("Unknown");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static RiverLocationKindJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiverLocationKindJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiverLocationKind", ignore_extras);
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
    public static RiverLocationKindJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RiverLocationKindJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiverLocationKindJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiverLocationKind", ignore_extras);
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
    public static RiverLocationKindJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RiverLocationKindJSON from_text(string text, bool ignore_extras)
      {
        RiverLocationKindJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiverLocationKind", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RiverLocationKindJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RiverLocationKindJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RiverLocationKindJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiverLocationKind", ignore_extras);
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
            handle_result(stringToValue(result));
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
            RiverLocationKindJSON result = new RiverLocationKindJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(RiverLocationKindJSON new_result);
        public Generator(bool ignore_extras) : base("Type RiverLocationKind")
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
        protected override void handle_result(RiverLocationKindJSON  result)
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
        public RiverLocationKindJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RiverLocationKindJSON  result)
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
    protected virtual void handle_result(List<RiverLocationKindJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RiverLocationKindJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RiverLocationKindJSON>();
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
    public List<RiverLocationKindJSON> value;
  };
  };
