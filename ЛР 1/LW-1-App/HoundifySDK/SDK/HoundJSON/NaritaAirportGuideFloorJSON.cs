/* file "NaritaAirportGuideFloorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class NaritaAirportGuideFloorJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_B2F,
        Value_B1F,
        Value_1F,
        Value_2F,
        Value_3F,
        Value_4F,
        Value_5F,
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
            case '1':
                if ((String.Compare(chars, 1, "F", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeValueKnownValues.Value_1F;
                break;
            case '2':
                if ((String.Compare(chars, 1, "F", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeValueKnownValues.Value_2F;
                break;
            case '3':
                if ((String.Compare(chars, 1, "F", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeValueKnownValues.Value_3F;
                break;
            case '4':
                if ((String.Compare(chars, 1, "F", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeValueKnownValues.Value_4F;
                break;
            case '5':
                if ((String.Compare(chars, 1, "F", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeValueKnownValues.Value_5F;
                break;
            case 'B':
                switch (chars[1])
                  {
                    case '1':
                        if ((String.Compare(chars, 2, "F", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_B1F;
                        break;
                    case '2':
                        if ((String.Compare(chars, 2, "F", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_B2F;
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
            case TypeValueKnownValues.Value_B2F:
                return "B2F";
            case TypeValueKnownValues.Value_B1F:
                return "B1F";
            case TypeValueKnownValues.Value_1F:
                return "1F";
            case TypeValueKnownValues.Value_2F:
                return "2F";
            case TypeValueKnownValues.Value_3F:
                return "3F";
            case TypeValueKnownValues.Value_4F:
                return "4F";
            case TypeValueKnownValues.Value_5F:
                return "5F";
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
            throw new Exception("The value for field Value of NaritaAirportGuideFloorJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case '1':
                if ((String.Compare(json_string.getData(), 1, "F", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_1F;
                        goto open_enum_is_done;
                      }
                break;
            case '2':
                if ((String.Compare(json_string.getData(), 1, "F", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_2F;
                        goto open_enum_is_done;
                      }
                break;
            case '3':
                if ((String.Compare(json_string.getData(), 1, "F", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_3F;
                        goto open_enum_is_done;
                      }
                break;
            case '4':
                if ((String.Compare(json_string.getData(), 1, "F", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_4F;
                        goto open_enum_is_done;
                      }
                break;
            case '5':
                if ((String.Compare(json_string.getData(), 1, "F", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_5F;
                        goto open_enum_is_done;
                      }
                break;
            case 'B':
                switch (json_string.getData()[1])
                  {
                    case '1':
                        if ((String.Compare(json_string.getData(), 2, "F", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_B1F;
                                goto open_enum_is_done;
                              }
                        break;
                    case '2':
                        if ((String.Compare(json_string.getData(), 2, "F", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_B2F;
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


    public NaritaAirportGuideFloorJSON()
      {
        flagHasValue = false;
      }

    public NaritaAirportGuideFloorJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public NaritaAirportGuideFloorJSON(string init_value)
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

    public NaritaAirportGuideFloorJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_B2F:
                    handler.string_value("B2F");
                    break;
                case TypeValueKnownValues.Value_B1F:
                    handler.string_value("B1F");
                    break;
                case TypeValueKnownValues.Value_1F:
                    handler.string_value("1F");
                    break;
                case TypeValueKnownValues.Value_2F:
                    handler.string_value("2F");
                    break;
                case TypeValueKnownValues.Value_3F:
                    handler.string_value("3F");
                    break;
                case TypeValueKnownValues.Value_4F:
                    handler.string_value("4F");
                    break;
                case TypeValueKnownValues.Value_5F:
                    handler.string_value("5F");
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
                case TypeValueKnownValues.Value_B2F:
                    handler.string_value("B2F");
                    break;
                case TypeValueKnownValues.Value_B1F:
                    handler.string_value("B1F");
                    break;
                case TypeValueKnownValues.Value_1F:
                    handler.string_value("1F");
                    break;
                case TypeValueKnownValues.Value_2F:
                    handler.string_value("2F");
                    break;
                case TypeValueKnownValues.Value_3F:
                    handler.string_value("3F");
                    break;
                case TypeValueKnownValues.Value_4F:
                    handler.string_value("4F");
                    break;
                case TypeValueKnownValues.Value_5F:
                    handler.string_value("5F");
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

    public static NaritaAirportGuideFloorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NaritaAirportGuideFloorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NaritaAirportGuideFloor", ignore_extras);
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
    public static NaritaAirportGuideFloorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NaritaAirportGuideFloorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NaritaAirportGuideFloorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NaritaAirportGuideFloor", ignore_extras);
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
    public static NaritaAirportGuideFloorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NaritaAirportGuideFloorJSON from_text(string text, bool ignore_extras)
      {
        NaritaAirportGuideFloorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NaritaAirportGuideFloor", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NaritaAirportGuideFloorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static NaritaAirportGuideFloorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NaritaAirportGuideFloorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NaritaAirportGuideFloor", ignore_extras);
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
            NaritaAirportGuideFloorJSON result = new NaritaAirportGuideFloorJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(NaritaAirportGuideFloorJSON new_result);
        public Generator(bool ignore_extras) : base("Type NaritaAirportGuideFloor")
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
        protected override void handle_result(NaritaAirportGuideFloorJSON  result)
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
        public NaritaAirportGuideFloorJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NaritaAirportGuideFloorJSON  result)
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
    protected virtual void handle_result(List<NaritaAirportGuideFloorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NaritaAirportGuideFloorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NaritaAirportGuideFloorJSON>();
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
    public List<NaritaAirportGuideFloorJSON> value;
  };
  };
