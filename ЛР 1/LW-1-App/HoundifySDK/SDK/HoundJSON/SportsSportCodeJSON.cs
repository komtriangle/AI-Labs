/* file "SportsSportCodeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsSportCodeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Baseball,
        Value_Basketball,
        Value_AmericanFootball,
        Value_Hockey,
        Value_Soccer,
        Value_Cricket,
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
                if ((String.Compare(chars, 1, "mericanFootball", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeValueKnownValues.Value_AmericanFootball;
                break;
            case 'B':
                if (String.Compare(chars, 1, "as", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'e':
                            if ((String.Compare(chars, 4, "ball", 0, 4, false) == 0) && (chars.Length == 8))
                                return TypeValueKnownValues.Value_Baseball;
                            break;
                        case 'k':
                            if ((String.Compare(chars, 4, "etball", 0, 6, false) == 0) && (chars.Length == 10))
                                return TypeValueKnownValues.Value_Basketball;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if ((String.Compare(chars, 1, "ricket", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValueKnownValues.Value_Cricket;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "ockey", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValueKnownValues.Value_Hockey;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "occer", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValueKnownValues.Value_Soccer;
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
            case TypeValueKnownValues.Value_Baseball:
                return "Baseball";
            case TypeValueKnownValues.Value_Basketball:
                return "Basketball";
            case TypeValueKnownValues.Value_AmericanFootball:
                return "AmericanFootball";
            case TypeValueKnownValues.Value_Hockey:
                return "Hockey";
            case TypeValueKnownValues.Value_Soccer:
                return "Soccer";
            case TypeValueKnownValues.Value_Cricket:
                return "Cricket";
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
            throw new Exception("The value for field Value of SportsSportCodeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "mericanFootball", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_AmericanFootball;
                        goto open_enum_is_done;
                      }
                break;
            case 'B':
                if (String.Compare(json_string.getData(), 1, "as", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'e':
                            if ((String.Compare(json_string.getData(), 4, "ball", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Baseball;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'k':
                            if ((String.Compare(json_string.getData(), 4, "etball", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Basketball;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "ricket", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Cricket;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "ockey", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Hockey;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "occer", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Soccer;
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


    public SportsSportCodeJSON()
      {
        flagHasValue = false;
      }

    public SportsSportCodeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsSportCodeJSON(string init_value)
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

    public SportsSportCodeJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_Baseball:
                    handler.string_value("Baseball");
                    break;
                case TypeValueKnownValues.Value_Basketball:
                    handler.string_value("Basketball");
                    break;
                case TypeValueKnownValues.Value_AmericanFootball:
                    handler.string_value("AmericanFootball");
                    break;
                case TypeValueKnownValues.Value_Hockey:
                    handler.string_value("Hockey");
                    break;
                case TypeValueKnownValues.Value_Soccer:
                    handler.string_value("Soccer");
                    break;
                case TypeValueKnownValues.Value_Cricket:
                    handler.string_value("Cricket");
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
                case TypeValueKnownValues.Value_Baseball:
                    handler.string_value("Baseball");
                    break;
                case TypeValueKnownValues.Value_Basketball:
                    handler.string_value("Basketball");
                    break;
                case TypeValueKnownValues.Value_AmericanFootball:
                    handler.string_value("AmericanFootball");
                    break;
                case TypeValueKnownValues.Value_Hockey:
                    handler.string_value("Hockey");
                    break;
                case TypeValueKnownValues.Value_Soccer:
                    handler.string_value("Soccer");
                    break;
                case TypeValueKnownValues.Value_Cricket:
                    handler.string_value("Cricket");
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

    public static SportsSportCodeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsSportCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSportCode", ignore_extras);
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
    public static SportsSportCodeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsSportCodeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsSportCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSportCode", ignore_extras);
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
    public static SportsSportCodeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsSportCodeJSON from_text(string text, bool ignore_extras)
      {
        SportsSportCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSportCode", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsSportCodeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsSportCodeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsSportCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSportCode", ignore_extras);
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
            SportsSportCodeJSON result = new SportsSportCodeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsSportCodeJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsSportCode")
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
        protected override void handle_result(SportsSportCodeJSON  result)
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
        public SportsSportCodeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsSportCodeJSON  result)
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
    protected virtual void handle_result(List<SportsSportCodeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsSportCodeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsSportCodeJSON>();
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
    public List<SportsSportCodeJSON> value;
  };
  };
