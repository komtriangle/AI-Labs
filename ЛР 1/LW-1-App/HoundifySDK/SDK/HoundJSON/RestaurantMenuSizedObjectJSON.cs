/* file "RestaurantMenuSizedObjectJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RestaurantMenuSizedObjectJSON : JSONBase
  {
    public enum TypeSizeKnownValues
      {
        Size_Mini,
        Size_Small,
        Size_Medium,
        Size_Large,
        Size_ExtraLarge,
        Size_ThreePiece,
        Size_FivePiece,
        Size_SixPiece,
        Size_SevenPiece,
        Size_NinePiece,
        Size_TenPiece,
        Size_TwelvePiece,
        Size_ThirteenPiece,
        Size_TwentyPiece,
        Size__none
      };
    public struct TypeSize
      {
        public bool in_known_list;
        public string string_value;
        public TypeSizeKnownValues list_value;
      };

    public static TypeSizeKnownValues  stringToSize(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "xtraLarge", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeSizeKnownValues.Size_ExtraLarge;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "ivePiece", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeSizeKnownValues.Size_FivePiece;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "arge", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeSizeKnownValues.Size_Large;
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "dium", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeSizeKnownValues.Size_Medium;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "ni", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeSizeKnownValues.Size_Mini;
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if ((String.Compare(chars, 1, "inePiece", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeSizeKnownValues.Size_NinePiece;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "venPiece", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeSizeKnownValues.Size_SevenPiece;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "xPiece", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeSizeKnownValues.Size_SixPiece;
                        break;
                    case 'm':
                        if ((String.Compare(chars, 2, "all", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeSizeKnownValues.Size_Small;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "nPiece", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeSizeKnownValues.Size_TenPiece;
                        break;
                    case 'h':
                        switch (chars[2])
                          {
                            case 'i':
                                if ((String.Compare(chars, 3, "rteenPiece", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeSizeKnownValues.Size_ThirteenPiece;
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "eePiece", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeSizeKnownValues.Size_ThreePiece;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'w':
                        if (String.Compare(chars, 2, "e", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'l':
                                    if ((String.Compare(chars, 4, "vePiece", 0, 7, false) == 0) && (chars.Length == 11))
                                        return TypeSizeKnownValues.Size_TwelvePiece;
                                    break;
                                case 'n':
                                    if ((String.Compare(chars, 4, "tyPiece", 0, 7, false) == 0) && (chars.Length == 11))
                                        return TypeSizeKnownValues.Size_TwentyPiece;
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
            default:
                break;
          }
        return TypeSizeKnownValues.Size__none;
      }

    public static string  stringFromSize(TypeSizeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeSizeKnownValues.Size_Mini:
                return "Mini";
            case TypeSizeKnownValues.Size_Small:
                return "Small";
            case TypeSizeKnownValues.Size_Medium:
                return "Medium";
            case TypeSizeKnownValues.Size_Large:
                return "Large";
            case TypeSizeKnownValues.Size_ExtraLarge:
                return "ExtraLarge";
            case TypeSizeKnownValues.Size_ThreePiece:
                return "ThreePiece";
            case TypeSizeKnownValues.Size_FivePiece:
                return "FivePiece";
            case TypeSizeKnownValues.Size_SixPiece:
                return "SixPiece";
            case TypeSizeKnownValues.Size_SevenPiece:
                return "SevenPiece";
            case TypeSizeKnownValues.Size_NinePiece:
                return "NinePiece";
            case TypeSizeKnownValues.Size_TenPiece:
                return "TenPiece";
            case TypeSizeKnownValues.Size_TwelvePiece:
                return "TwelvePiece";
            case TypeSizeKnownValues.Size_ThirteenPiece:
                return "ThirteenPiece";
            case TypeSizeKnownValues.Size_TwentyPiece:
                return "TwentyPiece";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasSize;
    private TypeSize storeSize;
    private bool flagHasSizedId;
    private BigInteger storeSizedId;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSize(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Size of RestaurantMenuSizedObjectJSON is not a string.");
        TypeSize the_open_enum = new TypeSize();
        switch (json_string.getData()[0])
          {
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "xtraLarge", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSizeKnownValues.Size_ExtraLarge;
                        goto open_enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ivePiece", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSizeKnownValues.Size_FivePiece;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "arge", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSizeKnownValues.Size_Large;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "dium", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSizeKnownValues.Size_Medium;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ni", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSizeKnownValues.Size_Mini;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "inePiece", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSizeKnownValues.Size_NinePiece;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "venPiece", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSizeKnownValues.Size_SevenPiece;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "xPiece", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSizeKnownValues.Size_SixPiece;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'm':
                        if ((String.Compare(json_string.getData(), 2, "all", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSizeKnownValues.Size_Small;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "nPiece", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSizeKnownValues.Size_TenPiece;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        switch (json_string.getData()[2])
                          {
                            case 'i':
                                if ((String.Compare(json_string.getData(), 3, "rteenPiece", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeSizeKnownValues.Size_ThirteenPiece;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "eePiece", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeSizeKnownValues.Size_ThreePiece;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'w':
                        if (String.Compare(json_string.getData(), 2, "e", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 4, "vePiece", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeSizeKnownValues.Size_TwelvePiece;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'n':
                                    if ((String.Compare(json_string.getData(), 4, "tyPiece", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeSizeKnownValues.Size_TwentyPiece;
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
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setSize(the_open_enum);
      }


    private void  fromJSONSizedId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SizedId of RestaurantMenuSizedObjectJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SizedId of RestaurantMenuSizedObjectJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSizedId(extracted_integer);
      }


    public RestaurantMenuSizedObjectJSON()
      {
        flagHasSize = false;
        flagHasSizedId = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSize()
      {
        return flagHasSize;
      }

    public TypeSize  getSize()
      {
        Debug.Assert(flagHasSize);
        return storeSize;
      }

    public string  getSizeAsString()
      {
        TypeSize result = getSize();
        if (result.in_known_list)
            return stringFromSize(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasSizedId()
      {
        return flagHasSizedId;
      }

    public BigInteger  getSizedId()
      {
        Debug.Assert(flagHasSizedId);
        return storeSizedId;
      }


    public virtual int extraRestaurantMenuSizedObjectComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantMenuSizedObjectComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantMenuSizedObjectComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantMenuSizedObjectLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSize(TypeSize new_value)
      {
        flagHasSize = true;
        storeSize = new_value;
      }
    public void setSize(string chars)
      {
        TypeSizeKnownValues known = stringToSize(chars);
        TypeSize new_value = new TypeSize();
        if (known == TypeSizeKnownValues.Size__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSize(new_value);
      }
    public void setSize(TypeSizeKnownValues new_value)
      {
        TypeSize new_full_value = new TypeSize();
        Debug.Assert(new_value != TypeSizeKnownValues.Size__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setSize(new_full_value);
      }
    public void unsetSize()
      {
        flagHasSize = false;
      }
    public void setSizedId(BigInteger new_value)
      {
        flagHasSizedId = true;
        storeSizedId = new_value;
      }
    public void unsetSizedId()
      {
        flagHasSizedId = false;
      }

    public virtual void extraRestaurantMenuSizedObjectAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantMenuSizedObjectSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantMenuSizedObjectLookup(key);
        if (old_field == null)
          {
            extraRestaurantMenuSizedObjectAppendPair(key, new_component);
          }
        else
          {
            int count = extraKeys.Count;
            Debug.Assert(count == extraValues.Count);
            for (int num = 0; num < count; ++num)
              {
                if (extraKeys[num].Equals( key))
                  {
                    extraValues[num] = new_component;
                    break;
                  }
              }
            extraIndex.Add(key, new_component);
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasSize);
        if (flagHasSize)
          {
            handler.start_pair("Size");
            if (storeSize.in_known_list)
              {
                switch (storeSize.list_value)
                  {
                    case TypeSizeKnownValues.Size_Mini:
                        handler.string_value("Mini");
                        break;
                    case TypeSizeKnownValues.Size_Small:
                        handler.string_value("Small");
                        break;
                    case TypeSizeKnownValues.Size_Medium:
                        handler.string_value("Medium");
                        break;
                    case TypeSizeKnownValues.Size_Large:
                        handler.string_value("Large");
                        break;
                    case TypeSizeKnownValues.Size_ExtraLarge:
                        handler.string_value("ExtraLarge");
                        break;
                    case TypeSizeKnownValues.Size_ThreePiece:
                        handler.string_value("ThreePiece");
                        break;
                    case TypeSizeKnownValues.Size_FivePiece:
                        handler.string_value("FivePiece");
                        break;
                    case TypeSizeKnownValues.Size_SixPiece:
                        handler.string_value("SixPiece");
                        break;
                    case TypeSizeKnownValues.Size_SevenPiece:
                        handler.string_value("SevenPiece");
                        break;
                    case TypeSizeKnownValues.Size_NinePiece:
                        handler.string_value("NinePiece");
                        break;
                    case TypeSizeKnownValues.Size_TenPiece:
                        handler.string_value("TenPiece");
                        break;
                    case TypeSizeKnownValues.Size_TwelvePiece:
                        handler.string_value("TwelvePiece");
                        break;
                    case TypeSizeKnownValues.Size_ThirteenPiece:
                        handler.string_value("ThirteenPiece");
                        break;
                    case TypeSizeKnownValues.Size_TwentyPiece:
                        handler.string_value("TwentyPiece");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeSize.string_value);
              }
          }
        if (flagHasSizedId)
          {
            handler.start_pair("SizedId");
            handler.number_value(storeSizedId);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasSize()))
          {
            return "When parsing the object for %what%, the \"Size\" field was missing.";
          }
        return null;
      }

    public static RestaurantMenuSizedObjectJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuSizedObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuSizedObject", ignore_extras);
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
    public static RestaurantMenuSizedObjectJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuSizedObjectJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuSizedObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuSizedObject", ignore_extras);
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
    public static RestaurantMenuSizedObjectJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuSizedObjectJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuSizedObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuSizedObject", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuSizedObjectJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuSizedObjectJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuSizedObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuSizedObject", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorSize : JSONStringGenerator
          {
            protected FieldGeneratorSize(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSize()
              {
              }
            protected override void handle_result(string result)
              {
                TypeSizeKnownValues known = stringToSize(result);
                TypeSize new_value = new TypeSize();
                if (known == TypeSizeKnownValues.Size__none)
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
            protected abstract void handle_result(TypeSize result);
          };
    private class FieldHoldingGeneratorSize : FieldGeneratorSize
  {
    protected override void handle_result(TypeSize result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSize(String what)
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
    public TypeSize value;
  };
    private class FieldHoldingArrayGeneratorSize : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSize
      {
        private FieldHoldingArrayGeneratorSize top;

        protected override void handle_result(TypeSize result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSize init_top)
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
    protected virtual void handle_result(List<TypeSize> result)
      {
      }

    public FieldHoldingArrayGeneratorSize(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSize>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSize()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSize>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSize> value;
  };
        private FieldHoldingGeneratorSize fieldGeneratorSize;
    private class FieldHoldingGeneratorSizedId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorSizedId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorSizedId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorSizedId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorSizedId fieldGeneratorSizedId;
        private class UnknownFieldGenerator : JSONValueHandler
          {
            public bool ignore;
            public List<string> field_names;
            public List<JSONValue > field_values;
            public Dictionary<string, JSONValue > index;
            public UnknownFieldGenerator(bool init_ignore)
              {
                ignore = init_ignore;
                field_names = new List<string>();
                field_values = new List<JSONValue >();
            index = new Dictionary<string, JSONValue >();
              }

            protected override void new_value(JSONValue item)
              {
                if (ignore)
                    return;
                Debug.Assert(field_names.Count == (field_values.Count + 1));
                index.Add(field_names[field_values.Count], item);
                field_values.Add(item);
              }
            public override void reset()
              {
                field_names.Clear();
                field_values.Clear();
            index = new Dictionary<string, JSONValue >();
              }
          };
        private UnknownFieldGenerator unknownFieldGenerator;

        protected bool allow_incomplete;

        protected bool allow_unpolished;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            Debug.Assert(unknownFieldGenerator.field_names.Count ==
                   unknownFieldGenerator.field_values.Count);
            if (unknownFieldGenerator.ignore)
              {
                Debug.Assert(unknownFieldGenerator.field_names.Count == 0);
              }
            else
              {
                unknownFieldGenerator.field_names.Add(field_name);
              }
            return unknownFieldGenerator;
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            RestaurantMenuSizedObjectJSON result = new RestaurantMenuSizedObjectJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantMenuSizedObjectAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantMenuSizedObjectJSON result)
          {
            if (fieldGeneratorSize.have_value)
              {
                result.setSize(fieldGeneratorSize.value);
                fieldGeneratorSize.have_value = false;
              }
            else if ((!(result.hasSize())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Size\" field was missing.");
              }
            if (fieldGeneratorSizedId.have_value)
              {
                result.setSizedId(fieldGeneratorSizedId.value);
                fieldGeneratorSizedId.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantMenuSizedObjectJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Size", 0, 4, false) == 0)
              {
                if (field_name.Length == 4)
                  {
                    return fieldGeneratorSize;
                  }
                switch (field_name[4])
                  {
                    case 'd':
                        if ((String.Compare(field_name, 5, "Id", 0, 2, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorSizedId;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSize = new FieldHoldingGeneratorSize("field \"Size\" of the RestaurantMenuSizedObject class");
            fieldGeneratorSizedId = new FieldHoldingGeneratorSizedId("field \"SizedId\" of the RestaurantMenuSizedObject class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantMenuSizedObject class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSize = new FieldHoldingGeneratorSize("field \"Size\" of the RestaurantMenuSizedObject class");
            fieldGeneratorSizedId = new FieldHoldingGeneratorSizedId("field \"SizedId\" of the RestaurantMenuSizedObject class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantMenuSizedObject class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSize.reset();
            fieldGeneratorSizedId.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantMenuSizedObjectJSON  result)
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
        public RestaurantMenuSizedObjectJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuSizedObjectJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuSizedObjectJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuSizedObjectJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuSizedObjectJSON>();
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
    public List<RestaurantMenuSizedObjectJSON> value;
  };
  };
