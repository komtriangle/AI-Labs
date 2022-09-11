/* file "RestaurantMenuModifierVerbJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RestaurantMenuModifierVerbJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_ADD,
        Value_NO,
        Value_EASY,
        Value_EXTRA
      };

    public static TypeValue  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "DD", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeValue.Value_ADD;
                break;
            case 'E':
                switch (chars[1])
                  {
                    case 'A':
                        if ((String.Compare(chars, 2, "SY", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValue.Value_EASY;
                        break;
                    case 'X':
                        if ((String.Compare(chars, 2, "TRA", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValue.Value_EXTRA;
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if ((String.Compare(chars, 1, "O", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeValue.Value_NO;
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
            case TypeValue.Value_ADD:
                return "ADD";
            case TypeValue.Value_NO:
                return "NO";
            case TypeValue.Value_EASY:
                return "EASY";
            case TypeValue.Value_EXTRA:
                return "EXTRA";
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
            throw new Exception("The value for field Value of RestaurantMenuModifierVerbJSON is not a string.");
        TypeValue the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "DD", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeValue.Value_ADD;
                        goto enum_is_done;
                      }
                break;
            case 'E':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 2, "SY", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_enum = TypeValue.Value_EASY;
                                goto enum_is_done;
                              }
                        break;
                    case 'X':
                        if ((String.Compare(json_string.getData(), 2, "TRA", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_enum = TypeValue.Value_EXTRA;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "O", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeValue.Value_NO;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Value of RestaurantMenuModifierVerbJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public RestaurantMenuModifierVerbJSON()
      {
        flagHasValue = false;
      }

    public RestaurantMenuModifierVerbJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public RestaurantMenuModifierVerbJSON(string init_value)
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
            case TypeValue.Value_ADD:
                handler.string_value("ADD");
                break;
            case TypeValue.Value_NO:
                handler.string_value("NO");
                break;
            case TypeValue.Value_EASY:
                handler.string_value("EASY");
                break;
            case TypeValue.Value_EXTRA:
                handler.string_value("EXTRA");
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
            case TypeValue.Value_ADD:
                handler.string_value("ADD");
                break;
            case TypeValue.Value_NO:
                handler.string_value("NO");
                break;
            case TypeValue.Value_EASY:
                handler.string_value("EASY");
                break;
            case TypeValue.Value_EXTRA:
                handler.string_value("EXTRA");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static RestaurantMenuModifierVerbJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuModifierVerbJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuModifierVerb", ignore_extras);
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
    public static RestaurantMenuModifierVerbJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuModifierVerbJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuModifierVerbJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuModifierVerb", ignore_extras);
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
    public static RestaurantMenuModifierVerbJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuModifierVerbJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuModifierVerbJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuModifierVerb", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuModifierVerbJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuModifierVerbJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuModifierVerbJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuModifierVerb", ignore_extras);
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
            RestaurantMenuModifierVerbJSON result = new RestaurantMenuModifierVerbJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(RestaurantMenuModifierVerbJSON new_result);
        public Generator(bool ignore_extras) : base("Type RestaurantMenuModifierVerb")
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
        protected override void handle_result(RestaurantMenuModifierVerbJSON  result)
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
        public RestaurantMenuModifierVerbJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuModifierVerbJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuModifierVerbJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuModifierVerbJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuModifierVerbJSON>();
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
    public List<RestaurantMenuModifierVerbJSON> value;
  };
  };
