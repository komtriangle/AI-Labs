/* file "WesternAstrologySignInformationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WesternAstrologySignInformationJSON : JSONBase
  {
    public enum TypeSignKnownValues
      {
        Sign_Aries,
        Sign_Taurus,
        Sign_Gemini,
        Sign_Cancer,
        Sign_Leo,
        Sign_Virgo,
        Sign_Libra,
        Sign_Scorpio,
        Sign_Sagittarius,
        Sign_Capricorn,
        Sign_Aquarius,
        Sign_Pisces,
        Sign__none
      };
    public struct TypeSign
      {
        public bool in_known_list;
        public string string_value;
        public TypeSignKnownValues list_value;
      };

    public static TypeSignKnownValues  stringToSign(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'q':
                        if ((String.Compare(chars, 2, "uarius", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeSignKnownValues.Sign_Aquarius;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "ies", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeSignKnownValues.Sign_Aries;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if (String.Compare(chars, 1, "a", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'n':
                            if ((String.Compare(chars, 3, "cer", 0, 3, false) == 0) && (chars.Length == 6))
                                return TypeSignKnownValues.Sign_Cancer;
                            break;
                        case 'p':
                            if ((String.Compare(chars, 3, "ricorn", 0, 6, false) == 0) && (chars.Length == 9))
                                return TypeSignKnownValues.Sign_Capricorn;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'G':
                if ((String.Compare(chars, 1, "emini", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeSignKnownValues.Sign_Gemini;
                break;
            case 'L':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "o", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeSignKnownValues.Sign_Leo;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "bra", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeSignKnownValues.Sign_Libra;
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                if ((String.Compare(chars, 1, "isces", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeSignKnownValues.Sign_Pisces;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "gittarius", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeSignKnownValues.Sign_Sagittarius;
                        break;
                    case 'c':
                        if ((String.Compare(chars, 2, "orpio", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeSignKnownValues.Sign_Scorpio;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "aurus", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeSignKnownValues.Sign_Taurus;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "irgo", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeSignKnownValues.Sign_Virgo;
                break;
            default:
                break;
          }
        return TypeSignKnownValues.Sign__none;
      }

    public static string  stringFromSign(TypeSignKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeSignKnownValues.Sign_Aries:
                return "Aries";
            case TypeSignKnownValues.Sign_Taurus:
                return "Taurus";
            case TypeSignKnownValues.Sign_Gemini:
                return "Gemini";
            case TypeSignKnownValues.Sign_Cancer:
                return "Cancer";
            case TypeSignKnownValues.Sign_Leo:
                return "Leo";
            case TypeSignKnownValues.Sign_Virgo:
                return "Virgo";
            case TypeSignKnownValues.Sign_Libra:
                return "Libra";
            case TypeSignKnownValues.Sign_Scorpio:
                return "Scorpio";
            case TypeSignKnownValues.Sign_Sagittarius:
                return "Sagittarius";
            case TypeSignKnownValues.Sign_Capricorn:
                return "Capricorn";
            case TypeSignKnownValues.Sign_Aquarius:
                return "Aquarius";
            case TypeSignKnownValues.Sign_Pisces:
                return "Pisces";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasSign;
    private TypeSign storeSign;
    private bool flagHasBirthDateRange;
    private DateTimeRangeSpecJSON  storeBirthDateRange;
    private bool flagHasImageURL;
    private string storeImageURL;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSign(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Sign of WesternAstrologySignInformationJSON is not a string.");
        TypeSign the_open_enum = new TypeSign();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'q':
                        if ((String.Compare(json_string.getData(), 2, "uarius", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSignKnownValues.Sign_Aquarius;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "ies", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSignKnownValues.Sign_Aries;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if (String.Compare(json_string.getData(), 1, "a", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'n':
                            if ((String.Compare(json_string.getData(), 3, "cer", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeSignKnownValues.Sign_Cancer;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'p':
                            if ((String.Compare(json_string.getData(), 3, "ricorn", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeSignKnownValues.Sign_Capricorn;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "emini", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSignKnownValues.Sign_Gemini;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "o", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSignKnownValues.Sign_Leo;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "bra", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSignKnownValues.Sign_Libra;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "isces", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSignKnownValues.Sign_Pisces;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "gittarius", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSignKnownValues.Sign_Sagittarius;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'c':
                        if ((String.Compare(json_string.getData(), 2, "orpio", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSignKnownValues.Sign_Scorpio;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "aurus", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSignKnownValues.Sign_Taurus;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "irgo", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSignKnownValues.Sign_Virgo;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setSign(the_open_enum);
      }


    private void  fromJSONBirthDateRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setBirthDateRange(convert_classy);
      }


    private void  fromJSONImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ImageURL of WesternAstrologySignInformationJSON is not a string.");
        setImageURL(json_string.getData());
      }


    public WesternAstrologySignInformationJSON()
      {
        flagHasSign = false;
        flagHasBirthDateRange = false;
        flagHasImageURL = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSign()
      {
        return flagHasSign;
      }

    public TypeSign  getSign()
      {
        Debug.Assert(flagHasSign);
        return storeSign;
      }

    public string  getSignAsString()
      {
        TypeSign result = getSign();
        if (result.in_known_list)
            return stringFromSign(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasBirthDateRange()
      {
        return flagHasBirthDateRange;
      }

    public DateTimeRangeSpecJSON   getBirthDateRange()
      {
        Debug.Assert(flagHasBirthDateRange);
        return storeBirthDateRange;
      }

    public bool  hasImageURL()
      {
        return flagHasImageURL;
      }

    public string  getImageURL()
      {
        Debug.Assert(flagHasImageURL);
        return storeImageURL;
      }


    public virtual int extraWesternAstrologySignInformationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWesternAstrologySignInformationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWesternAstrologySignInformationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWesternAstrologySignInformationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSign(TypeSign new_value)
      {
        flagHasSign = true;
        storeSign = new_value;
      }
    public void setSign(string chars)
      {
        TypeSignKnownValues known = stringToSign(chars);
        TypeSign new_value = new TypeSign();
        if (known == TypeSignKnownValues.Sign__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSign(new_value);
      }
    public void setSign(TypeSignKnownValues new_value)
      {
        TypeSign new_full_value = new TypeSign();
        Debug.Assert(new_value != TypeSignKnownValues.Sign__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setSign(new_full_value);
      }
    public void unsetSign()
      {
        flagHasSign = false;
      }
    public void setBirthDateRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasBirthDateRange)
          {
          }
        flagHasBirthDateRange = true;
        storeBirthDateRange = new_value;
      }
    public void unsetBirthDateRange()
      {
        if (flagHasBirthDateRange)
          {
          }
        flagHasBirthDateRange = false;
      }
    public void setImageURL(string new_value)
      {
        flagHasImageURL = true;
        storeImageURL = new_value;
      }
    public void unsetImageURL()
      {
        flagHasImageURL = false;
      }

    public virtual void extraWesternAstrologySignInformationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWesternAstrologySignInformationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWesternAstrologySignInformationLookup(key);
        if (old_field == null)
          {
            extraWesternAstrologySignInformationAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSign);
        if (flagHasSign)
          {
            handler.start_pair("Sign");
            if (storeSign.in_known_list)
              {
                switch (storeSign.list_value)
                  {
                    case TypeSignKnownValues.Sign_Aries:
                        handler.string_value("Aries");
                        break;
                    case TypeSignKnownValues.Sign_Taurus:
                        handler.string_value("Taurus");
                        break;
                    case TypeSignKnownValues.Sign_Gemini:
                        handler.string_value("Gemini");
                        break;
                    case TypeSignKnownValues.Sign_Cancer:
                        handler.string_value("Cancer");
                        break;
                    case TypeSignKnownValues.Sign_Leo:
                        handler.string_value("Leo");
                        break;
                    case TypeSignKnownValues.Sign_Virgo:
                        handler.string_value("Virgo");
                        break;
                    case TypeSignKnownValues.Sign_Libra:
                        handler.string_value("Libra");
                        break;
                    case TypeSignKnownValues.Sign_Scorpio:
                        handler.string_value("Scorpio");
                        break;
                    case TypeSignKnownValues.Sign_Sagittarius:
                        handler.string_value("Sagittarius");
                        break;
                    case TypeSignKnownValues.Sign_Capricorn:
                        handler.string_value("Capricorn");
                        break;
                    case TypeSignKnownValues.Sign_Aquarius:
                        handler.string_value("Aquarius");
                        break;
                    case TypeSignKnownValues.Sign_Pisces:
                        handler.string_value("Pisces");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeSign.string_value);
              }
          }
        if (flagHasBirthDateRange)
          {
            handler.start_pair("BirthDateRange");
            if (partial_allowed)
                storeBirthDateRange.write_partial_as_json(handler);
            else
                storeBirthDateRange.write_as_json(handler);
          }
        if (flagHasImageURL)
          {
            handler.start_pair("ImageURL");
            handler.string_value(storeImageURL);
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
        if (!(hasSign()))
          {
            return "When parsing the object for %what%, the \"Sign\" field was missing.";
          }
        return null;
      }

    public static WesternAstrologySignInformationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WesternAstrologySignInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WesternAstrologySignInformation", ignore_extras);
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
    public static WesternAstrologySignInformationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WesternAstrologySignInformationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WesternAstrologySignInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WesternAstrologySignInformation", ignore_extras);
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
    public static WesternAstrologySignInformationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WesternAstrologySignInformationJSON from_text(string text, bool ignore_extras)
      {
        WesternAstrologySignInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WesternAstrologySignInformation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WesternAstrologySignInformationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WesternAstrologySignInformationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WesternAstrologySignInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WesternAstrologySignInformation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorSign : JSONStringGenerator
          {
            protected FieldGeneratorSign(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSign()
              {
              }
            protected override void handle_result(string result)
              {
                TypeSignKnownValues known = stringToSign(result);
                TypeSign new_value = new TypeSign();
                if (known == TypeSignKnownValues.Sign__none)
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
            protected abstract void handle_result(TypeSign result);
          };
    private class FieldHoldingGeneratorSign : FieldGeneratorSign
  {
    protected override void handle_result(TypeSign result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSign(String what)
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
    public TypeSign value;
  };
    private class FieldHoldingArrayGeneratorSign : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSign
      {
        private FieldHoldingArrayGeneratorSign top;

        protected override void handle_result(TypeSign result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSign init_top)
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
    protected virtual void handle_result(List<TypeSign> result)
      {
      }

    public FieldHoldingArrayGeneratorSign(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSign>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSign()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSign>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSign> value;
  };
        private FieldHoldingGeneratorSign fieldGeneratorSign;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorBirthDateRange;
        private JSONHoldingStringGenerator fieldGeneratorImageURL;
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
            WesternAstrologySignInformationJSON result = new WesternAstrologySignInformationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWesternAstrologySignInformationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WesternAstrologySignInformationJSON result)
          {
            if (fieldGeneratorSign.have_value)
              {
                result.setSign(fieldGeneratorSign.value);
                fieldGeneratorSign.have_value = false;
              }
            else if ((!(result.hasSign())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Sign\" field was missing.");
              }
            if (fieldGeneratorBirthDateRange.have_value)
              {
                result.setBirthDateRange(fieldGeneratorBirthDateRange.value);
                fieldGeneratorBirthDateRange.have_value = false;
              }
            if (fieldGeneratorImageURL.have_value)
              {
                result.setImageURL(fieldGeneratorImageURL.value);
                fieldGeneratorImageURL.have_value = false;
              }
          }
        protected abstract void handle_result(WesternAstrologySignInformationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "irthDateRange", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorBirthDateRange;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "mageURL", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorImageURL;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ign", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorSign;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSign = new FieldHoldingGeneratorSign("field \"Sign\" of the WesternAstrologySignInformation class");
            fieldGeneratorBirthDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"BirthDateRange\" of the WesternAstrologySignInformation class", ignore_extras);
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the WesternAstrologySignInformation class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WesternAstrologySignInformation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSign = new FieldHoldingGeneratorSign("field \"Sign\" of the WesternAstrologySignInformation class");
            fieldGeneratorBirthDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"BirthDateRange\" of the WesternAstrologySignInformation class", false);
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the WesternAstrologySignInformation class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WesternAstrologySignInformation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSign.reset();
            fieldGeneratorBirthDateRange.reset();
            fieldGeneratorImageURL.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorBirthDateRange.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorBirthDateRange.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(WesternAstrologySignInformationJSON  result)
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
        public WesternAstrologySignInformationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WesternAstrologySignInformationJSON  result)
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
    protected virtual void handle_result(List<WesternAstrologySignInformationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WesternAstrologySignInformationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WesternAstrologySignInformationJSON>();
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
    public List<WesternAstrologySignInformationJSON> value;
  };
  };
