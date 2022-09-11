/* file "StreamEncodingEnumJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StreamEncodingEnumJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_HLS,
        Value_HLSSecure,
        Value_HLSPivot,
        Value_PLS,
        Value_PLSSecure,
        Value_SHOUTcast,
        Value_SHOUTcastSecure,
        Value_AAC,
        Value_MP3,
        Value_WMA,
        Value_WMA2,
        Value_OGGVorbis,
        Value_OGGOpus,
        Value_OGGFLAC,
        Value_M3U8,
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
                if ((String.Compare(chars, 1, "AC", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeValueKnownValues.Value_AAC;
                break;
            case 'H':
                if (String.Compare(chars, 1, "LS", 0, 2, false) == 0)
                  {
                    if (chars.Length == 3)
                      {
                        return TypeValueKnownValues.Value_HLS;
                      }
                    switch (chars[3])
                      {
                        case 'P':
                            if ((String.Compare(chars, 4, "ivot", 0, 4, false) == 0) && (chars.Length == 8))
                                return TypeValueKnownValues.Value_HLSPivot;
                            break;
                        case 'S':
                            if ((String.Compare(chars, 4, "ecure", 0, 5, false) == 0) && (chars.Length == 9))
                                return TypeValueKnownValues.Value_HLSSecure;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                switch (chars[1])
                  {
                    case '3':
                        if ((String.Compare(chars, 2, "U8", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_M3U8;
                        break;
                    case 'P':
                        if ((String.Compare(chars, 2, "3", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_MP3;
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                if (String.Compare(chars, 1, "GG", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'F':
                            if ((String.Compare(chars, 4, "LAC", 0, 3, false) == 0) && (chars.Length == 7))
                                return TypeValueKnownValues.Value_OGGFLAC;
                            break;
                        case 'O':
                            if ((String.Compare(chars, 4, "pus", 0, 3, false) == 0) && (chars.Length == 7))
                                return TypeValueKnownValues.Value_OGGOpus;
                            break;
                        case 'V':
                            if ((String.Compare(chars, 4, "orbis", 0, 5, false) == 0) && (chars.Length == 9))
                                return TypeValueKnownValues.Value_OGGVorbis;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(chars, 1, "LS", 0, 2, false) == 0)
                  {
                    if (chars.Length == 3)
                      {
                        return TypeValueKnownValues.Value_PLS;
                      }
                    switch (chars[3])
                      {
                        case 'S':
                            if ((String.Compare(chars, 4, "ecure", 0, 5, false) == 0) && (chars.Length == 9))
                                return TypeValueKnownValues.Value_PLSSecure;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if (String.Compare(chars, 1, "HOUTcast", 0, 8, false) == 0)
                  {
                    if (chars.Length == 9)
                      {
                        return TypeValueKnownValues.Value_SHOUTcast;
                      }
                    switch (chars[9])
                      {
                        case 'S':
                            if ((String.Compare(chars, 10, "ecure", 0, 5, false) == 0) && (chars.Length == 15))
                                return TypeValueKnownValues.Value_SHOUTcastSecure;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if (String.Compare(chars, 1, "MA", 0, 2, false) == 0)
                  {
                    if (chars.Length == 3)
                      {
                        return TypeValueKnownValues.Value_WMA;
                      }
                    switch (chars[3])
                      {
                        case '2':
                            if (chars.Length == 4)
                                return TypeValueKnownValues.Value_WMA2;
                            break;
                        default:
                            break;
                      }
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
            case TypeValueKnownValues.Value_HLS:
                return "HLS";
            case TypeValueKnownValues.Value_HLSSecure:
                return "HLSSecure";
            case TypeValueKnownValues.Value_HLSPivot:
                return "HLSPivot";
            case TypeValueKnownValues.Value_PLS:
                return "PLS";
            case TypeValueKnownValues.Value_PLSSecure:
                return "PLSSecure";
            case TypeValueKnownValues.Value_SHOUTcast:
                return "SHOUTcast";
            case TypeValueKnownValues.Value_SHOUTcastSecure:
                return "SHOUTcastSecure";
            case TypeValueKnownValues.Value_AAC:
                return "AAC";
            case TypeValueKnownValues.Value_MP3:
                return "MP3";
            case TypeValueKnownValues.Value_WMA:
                return "WMA";
            case TypeValueKnownValues.Value_WMA2:
                return "WMA2";
            case TypeValueKnownValues.Value_OGGVorbis:
                return "OGGVorbis";
            case TypeValueKnownValues.Value_OGGOpus:
                return "OGGOpus";
            case TypeValueKnownValues.Value_OGGFLAC:
                return "OGGFLAC";
            case TypeValueKnownValues.Value_M3U8:
                return "M3U8";
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
            throw new Exception("The value for field Value of StreamEncodingEnumJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "AC", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_AAC;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if (String.Compare(json_string.getData(), 1, "LS", 0, 2, false) == 0)
                  {
                    if (json_string.getData().Length == 3)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_HLS;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[3])
                      {
                        case 'P':
                            if ((String.Compare(json_string.getData(), 4, "ivot", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_HLSPivot;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 4, "ecure", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_HLSSecure;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case '3':
                        if ((String.Compare(json_string.getData(), 2, "U8", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_M3U8;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'P':
                        if ((String.Compare(json_string.getData(), 2, "3", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_MP3;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                if (String.Compare(json_string.getData(), 1, "GG", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 4, "LAC", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_OGGFLAC;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'O':
                            if ((String.Compare(json_string.getData(), 4, "pus", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_OGGOpus;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'V':
                            if ((String.Compare(json_string.getData(), 4, "orbis", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_OGGVorbis;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(json_string.getData(), 1, "LS", 0, 2, false) == 0)
                  {
                    if (json_string.getData().Length == 3)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_PLS;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[3])
                      {
                        case 'S':
                            if ((String.Compare(json_string.getData(), 4, "ecure", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_PLSSecure;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if (String.Compare(json_string.getData(), 1, "HOUTcast", 0, 8, false) == 0)
                  {
                    if (json_string.getData().Length == 9)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_SHOUTcast;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[9])
                      {
                        case 'S':
                            if ((String.Compare(json_string.getData(), 10, "ecure", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_SHOUTcastSecure;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if (String.Compare(json_string.getData(), 1, "MA", 0, 2, false) == 0)
                  {
                    if (json_string.getData().Length == 3)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_WMA;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[3])
                      {
                        case '2':
                            if (json_string.getData().Length == 4)
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_WMA2;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public StreamEncodingEnumJSON()
      {
        flagHasValue = false;
      }

    public StreamEncodingEnumJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public StreamEncodingEnumJSON(string init_value)
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

    public StreamEncodingEnumJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_HLS:
                    handler.string_value("HLS");
                    break;
                case TypeValueKnownValues.Value_HLSSecure:
                    handler.string_value("HLSSecure");
                    break;
                case TypeValueKnownValues.Value_HLSPivot:
                    handler.string_value("HLSPivot");
                    break;
                case TypeValueKnownValues.Value_PLS:
                    handler.string_value("PLS");
                    break;
                case TypeValueKnownValues.Value_PLSSecure:
                    handler.string_value("PLSSecure");
                    break;
                case TypeValueKnownValues.Value_SHOUTcast:
                    handler.string_value("SHOUTcast");
                    break;
                case TypeValueKnownValues.Value_SHOUTcastSecure:
                    handler.string_value("SHOUTcastSecure");
                    break;
                case TypeValueKnownValues.Value_AAC:
                    handler.string_value("AAC");
                    break;
                case TypeValueKnownValues.Value_MP3:
                    handler.string_value("MP3");
                    break;
                case TypeValueKnownValues.Value_WMA:
                    handler.string_value("WMA");
                    break;
                case TypeValueKnownValues.Value_WMA2:
                    handler.string_value("WMA2");
                    break;
                case TypeValueKnownValues.Value_OGGVorbis:
                    handler.string_value("OGGVorbis");
                    break;
                case TypeValueKnownValues.Value_OGGOpus:
                    handler.string_value("OGGOpus");
                    break;
                case TypeValueKnownValues.Value_OGGFLAC:
                    handler.string_value("OGGFLAC");
                    break;
                case TypeValueKnownValues.Value_M3U8:
                    handler.string_value("M3U8");
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
                case TypeValueKnownValues.Value_HLS:
                    handler.string_value("HLS");
                    break;
                case TypeValueKnownValues.Value_HLSSecure:
                    handler.string_value("HLSSecure");
                    break;
                case TypeValueKnownValues.Value_HLSPivot:
                    handler.string_value("HLSPivot");
                    break;
                case TypeValueKnownValues.Value_PLS:
                    handler.string_value("PLS");
                    break;
                case TypeValueKnownValues.Value_PLSSecure:
                    handler.string_value("PLSSecure");
                    break;
                case TypeValueKnownValues.Value_SHOUTcast:
                    handler.string_value("SHOUTcast");
                    break;
                case TypeValueKnownValues.Value_SHOUTcastSecure:
                    handler.string_value("SHOUTcastSecure");
                    break;
                case TypeValueKnownValues.Value_AAC:
                    handler.string_value("AAC");
                    break;
                case TypeValueKnownValues.Value_MP3:
                    handler.string_value("MP3");
                    break;
                case TypeValueKnownValues.Value_WMA:
                    handler.string_value("WMA");
                    break;
                case TypeValueKnownValues.Value_WMA2:
                    handler.string_value("WMA2");
                    break;
                case TypeValueKnownValues.Value_OGGVorbis:
                    handler.string_value("OGGVorbis");
                    break;
                case TypeValueKnownValues.Value_OGGOpus:
                    handler.string_value("OGGOpus");
                    break;
                case TypeValueKnownValues.Value_OGGFLAC:
                    handler.string_value("OGGFLAC");
                    break;
                case TypeValueKnownValues.Value_M3U8:
                    handler.string_value("M3U8");
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

    public static StreamEncodingEnumJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StreamEncodingEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamEncodingEnum", ignore_extras);
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
    public static StreamEncodingEnumJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StreamEncodingEnumJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StreamEncodingEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamEncodingEnum", ignore_extras);
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
    public static StreamEncodingEnumJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StreamEncodingEnumJSON from_text(string text, bool ignore_extras)
      {
        StreamEncodingEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamEncodingEnum", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StreamEncodingEnumJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StreamEncodingEnumJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StreamEncodingEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamEncodingEnum", ignore_extras);
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
            StreamEncodingEnumJSON result = new StreamEncodingEnumJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(StreamEncodingEnumJSON new_result);
        public Generator(bool ignore_extras) : base("Type StreamEncodingEnum")
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
        protected override void handle_result(StreamEncodingEnumJSON  result)
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
        public StreamEncodingEnumJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StreamEncodingEnumJSON  result)
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
    protected virtual void handle_result(List<StreamEncodingEnumJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StreamEncodingEnumJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StreamEncodingEnumJSON>();
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
    public List<StreamEncodingEnumJSON> value;
  };
  };
