/* file "SMSDisambiguateOriginJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSDisambiguateOriginJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_SMSCreate,
        Value_SMSEditRecipients
      };

    public static TypeValue  stringToValue(string chars)
      {
        if (String.Compare(chars, 0, "SMS", 0, 3, false) == 0)
          {
            switch (chars[3])
              {
                case 'C':
                    if ((String.Compare(chars, 4, "reate", 0, 5, false) == 0) && (chars.Length == 9))
                        return TypeValue.Value_SMSCreate;
                    break;
                case 'E':
                    if ((String.Compare(chars, 4, "ditRecipients", 0, 13, false) == 0) && (chars.Length == 17))
                        return TypeValue.Value_SMSEditRecipients;
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field `Value' is not one of the legal values.");
      }

    public static string  stringFromValue(TypeValue the_enum)
      {
        switch (the_enum)
          {
            case TypeValue.Value_SMSCreate:
                return "SMSCreate";
            case TypeValue.Value_SMSEditRecipients:
                return "SMSEditRecipients";
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
            throw new Exception("The value for field Value of SMSDisambiguateOriginJSON is not a string.");
        TypeValue the_enum;
        if (String.Compare(json_string.getData(), 0, "SMS", 0, 3, false) == 0)
          {
            switch (json_string.getData()[3])
              {
                case 'C':
                    if ((String.Compare(json_string.getData(), 4, "reate", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_enum = TypeValue.Value_SMSCreate;
                            goto enum_is_done;
                          }
                    break;
                case 'E':
                    if ((String.Compare(json_string.getData(), 4, "ditRecipients", 0, 13, false) == 0) && (json_string.getData().Length == 17))
                          {
                            the_enum = TypeValue.Value_SMSEditRecipients;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field Value of SMSDisambiguateOriginJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public SMSDisambiguateOriginJSON()
      {
        flagHasValue = false;
      }

    public SMSDisambiguateOriginJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SMSDisambiguateOriginJSON(string init_value)
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
            case TypeValue.Value_SMSCreate:
                handler.string_value("SMSCreate");
                break;
            case TypeValue.Value_SMSEditRecipients:
                handler.string_value("SMSEditRecipients");
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
            case TypeValue.Value_SMSCreate:
                handler.string_value("SMSCreate");
                break;
            case TypeValue.Value_SMSEditRecipients:
                handler.string_value("SMSEditRecipients");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static SMSDisambiguateOriginJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSDisambiguateOriginJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguateOrigin", ignore_extras);
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
    public static SMSDisambiguateOriginJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSDisambiguateOriginJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSDisambiguateOriginJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguateOrigin", ignore_extras);
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
    public static SMSDisambiguateOriginJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SMSDisambiguateOriginJSON from_text(string text, bool ignore_extras)
      {
        SMSDisambiguateOriginJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguateOrigin", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSDisambiguateOriginJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SMSDisambiguateOriginJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSDisambiguateOriginJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguateOrigin", ignore_extras);
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
            SMSDisambiguateOriginJSON result = new SMSDisambiguateOriginJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SMSDisambiguateOriginJSON new_result);
        public Generator(bool ignore_extras) : base("Type SMSDisambiguateOrigin")
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
        protected override void handle_result(SMSDisambiguateOriginJSON  result)
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
        public SMSDisambiguateOriginJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSDisambiguateOriginJSON  result)
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
    protected virtual void handle_result(List<SMSDisambiguateOriginJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSDisambiguateOriginJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSDisambiguateOriginJSON>();
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
    public List<SMSDisambiguateOriginJSON> value;
  };
  };
