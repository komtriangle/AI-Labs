/* file "BingRequestInfoAdExtensionsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BingRequestInfoAdExtensionsJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Call,
        Value_Location,
        Value_MerchantRating,
        Value_MeteredCall,
        Value_SiteLinks,
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
            case 'C':
                if ((String.Compare(chars, 1, "all", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_Call;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ocation", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeValueKnownValues.Value_Location;
                break;
            case 'M':
                if (String.Compare(chars, 1, "e", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'r':
                            if ((String.Compare(chars, 3, "chantRating", 0, 11, false) == 0) && (chars.Length == 14))
                                return TypeValueKnownValues.Value_MerchantRating;
                            break;
                        case 't':
                            if ((String.Compare(chars, 3, "eredCall", 0, 8, false) == 0) && (chars.Length == 11))
                                return TypeValueKnownValues.Value_MeteredCall;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "iteLinks", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeValueKnownValues.Value_SiteLinks;
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
            case TypeValueKnownValues.Value_Call:
                return "Call";
            case TypeValueKnownValues.Value_Location:
                return "Location";
            case TypeValueKnownValues.Value_MerchantRating:
                return "MerchantRating";
            case TypeValueKnownValues.Value_MeteredCall:
                return "MeteredCall";
            case TypeValueKnownValues.Value_SiteLinks:
                return "SiteLinks";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private List< TypeValue > storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Value of BingRequestInfoAdExtensionsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeValue > vector_Value1 = new List< TypeValue >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Value of BingRequestInfoAdExtensionsJSON is not a string.");
            TypeValue the_open_enum = new TypeValue();
            switch (json_string.getData()[0])
              {
                case 'C':
                    if ((String.Compare(json_string.getData(), 1, "all", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_Call;
                            goto open_enum_is_done;
                          }
                    break;
                case 'L':
                    if ((String.Compare(json_string.getData(), 1, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_Location;
                            goto open_enum_is_done;
                          }
                    break;
                case 'M':
                    if (String.Compare(json_string.getData(), 1, "e", 0, 1, false) == 0)
                      {
                        switch (json_string.getData()[2])
                          {
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "chantRating", 0, 11, false) == 0) && (json_string.getData().Length == 14))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_MerchantRating;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "eredCall", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_MeteredCall;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "iteLinks", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_SiteLinks;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            vector_Value1.Add(the_open_enum);
          }
        initValue();
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
            appendValue(vector_Value1[num1]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public BingRequestInfoAdExtensionsJSON()
      {
        flagHasValue = false;
        storeValue = new List< TypeValue >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public int  countOfValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue.Count;
      }

    public TypeValue  elementOfValue(int element_num)
      {
        Debug.Assert(flagHasValue);
        return storeValue[element_num];
      }

    public List< TypeValue >  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void initValue()
      {
        flagHasValue = true;
        storeValue.Clear();
      }
    public void appendValue(TypeValue to_append)
      {
        if (!flagHasValue)
          {
            flagHasValue = true;
            storeValue.Clear();
          }
        Debug.Assert(flagHasValue);
        storeValue.Add(to_append);
      }
    public void appendValue(string chars)
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
        appendValue(new_value);
      }
    public void appendValue(TypeValueKnownValues new_value)
      {
        TypeValue new_full_value = new TypeValue();
        Debug.Assert(new_value != TypeValueKnownValues.Value__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        appendValue(new_full_value);
      }
    public void unsetValue()
      {
        flagHasValue = false;
        storeValue.Clear();
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num1 = 0; num1 < storeValue.Count; ++num1)
          {
            if (storeValue[num1].in_known_list)
              {
                switch (storeValue[num1].list_value)
                  {
                    case TypeValueKnownValues.Value_Call:
                        handler.string_value("Call");
                        break;
                    case TypeValueKnownValues.Value_Location:
                        handler.string_value("Location");
                        break;
                    case TypeValueKnownValues.Value_MerchantRating:
                        handler.string_value("MerchantRating");
                        break;
                    case TypeValueKnownValues.Value_MeteredCall:
                        handler.string_value("MeteredCall");
                        break;
                    case TypeValueKnownValues.Value_SiteLinks:
                        handler.string_value("SiteLinks");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeValue[num1].string_value);
              }
          }
        handler.finish_array();
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num2 = 0; num2 < storeValue.Count; ++num2)
          {
            if (storeValue[num2].in_known_list)
              {
                switch (storeValue[num2].list_value)
                  {
                    case TypeValueKnownValues.Value_Call:
                        handler.string_value("Call");
                        break;
                    case TypeValueKnownValues.Value_Location:
                        handler.string_value("Location");
                        break;
                    case TypeValueKnownValues.Value_MerchantRating:
                        handler.string_value("MerchantRating");
                        break;
                    case TypeValueKnownValues.Value_MeteredCall:
                        handler.string_value("MeteredCall");
                        break;
                    case TypeValueKnownValues.Value_SiteLinks:
                        handler.string_value("SiteLinks");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeValue[num2].string_value);
              }
          }
        handler.finish_array();
      }

    public static BingRequestInfoAdExtensionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BingRequestInfoAdExtensionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BingRequestInfoAdExtensions", ignore_extras);
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
    public static BingRequestInfoAdExtensionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BingRequestInfoAdExtensionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BingRequestInfoAdExtensionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BingRequestInfoAdExtensions", ignore_extras);
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
    public static BingRequestInfoAdExtensionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BingRequestInfoAdExtensionsJSON from_text(string text, bool ignore_extras)
      {
        BingRequestInfoAdExtensionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BingRequestInfoAdExtensions", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BingRequestInfoAdExtensionsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BingRequestInfoAdExtensionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BingRequestInfoAdExtensionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BingRequestInfoAdExtensions", ignore_extras);
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
    public abstract class Generator : FieldHoldingArrayGeneratorValue
      {
        protected void finish()
          {
            Debug.Assert(have_value);
            BingRequestInfoAdExtensionsJSON result = new BingRequestInfoAdExtensionsJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(BingRequestInfoAdExtensionsJSON new_result);
        public Generator(bool ignore_extras) : base("Type BingRequestInfoAdExtensions")
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
        protected override void handle_result(BingRequestInfoAdExtensionsJSON  result)
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
        public BingRequestInfoAdExtensionsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BingRequestInfoAdExtensionsJSON  result)
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
    protected virtual void handle_result(List<BingRequestInfoAdExtensionsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BingRequestInfoAdExtensionsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BingRequestInfoAdExtensionsJSON>();
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
    public List<BingRequestInfoAdExtensionsJSON> value;
  };
  };
