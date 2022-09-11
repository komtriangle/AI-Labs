/* file "ChineseZodiacQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ChineseZodiacQueryStateJSON : JSONBase
  {
    public enum TypeQueryType
      {
        QueryType_GeneralInformation,
        QueryType_SignOfGivenYear,
        QueryType_YearOfGivenSign,
        QueryType_SignOfGivenSign
      };

    public static TypeQueryType  stringToQueryType(string chars)
      {
        switch (chars[0])
          {
            case 'G':
                if ((String.Compare(chars, 1, "eneralInformation", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeQueryType.QueryType_GeneralInformation;
                break;
            case 'S':
                if (String.Compare(chars, 1, "ignOfGiven", 0, 10, false) == 0)
                  {
                    switch (chars[11])
                      {
                        case 'S':
                            if ((String.Compare(chars, 12, "ign", 0, 3, false) == 0) && (chars.Length == 15))
                                return TypeQueryType.QueryType_SignOfGivenSign;
                            break;
                        case 'Y':
                            if ((String.Compare(chars, 12, "ear", 0, 3, false) == 0) && (chars.Length == 15))
                                return TypeQueryType.QueryType_SignOfGivenYear;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "earOfGivenSign", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeQueryType.QueryType_YearOfGivenSign;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `QueryType' is not one of the legal values.");
      }

    public static string  stringFromQueryType(TypeQueryType the_enum)
      {
        switch (the_enum)
          {
            case TypeQueryType.QueryType_GeneralInformation:
                return "GeneralInformation";
            case TypeQueryType.QueryType_SignOfGivenYear:
                return "SignOfGivenYear";
            case TypeQueryType.QueryType_YearOfGivenSign:
                return "YearOfGivenSign";
            case TypeQueryType.QueryType_SignOfGivenSign:
                return "SignOfGivenSign";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQueryType;
    private TypeQueryType storeQueryType;
    private bool flagHasYear;
    private BigInteger storeYear;
    private bool flagHasZodiacSign;
    private string storeZodiacSign;
    private bool flagHasZodiacSignInEnglish;
    private ChineseZodiacSignJSON  storeZodiacSignInEnglish;
    private bool flagHasOrdinal;
    private BigInteger storeOrdinal;
    private bool flagHasYesOrNo;
    private bool storeYesOrNo;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryType of ChineseZodiacQueryStateJSON is not a string.");
        TypeQueryType the_enum;
        switch (json_string.getData()[0])
          {
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "eneralInformation", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_enum = TypeQueryType.QueryType_GeneralInformation;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if (String.Compare(json_string.getData(), 1, "ignOfGiven", 0, 10, false) == 0)
                  {
                    switch (json_string.getData()[11])
                      {
                        case 'S':
                            if ((String.Compare(json_string.getData(), 12, "ign", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypeQueryType.QueryType_SignOfGivenSign;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'Y':
                            if ((String.Compare(json_string.getData(), 12, "ear", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypeQueryType.QueryType_SignOfGivenYear;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "earOfGivenSign", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_enum = TypeQueryType.QueryType_YearOfGivenSign;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field QueryType of ChineseZodiacQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setQueryType(the_enum);
      }


    private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Year of ChineseZodiacQueryStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Year of ChineseZodiacQueryStateJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYear(extracted_integer);
      }


    private void  fromJSONZodiacSign(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ZodiacSign of ChineseZodiacQueryStateJSON is not a string.");
        setZodiacSign(json_string.getData());
      }


    private void  fromJSONZodiacSignInEnglish(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ChineseZodiacSignJSON convert_classy = ChineseZodiacSignJSON.from_json(json_value, ignore_extras, true);
        setZodiacSignInEnglish(convert_classy);
      }


    private void  fromJSONOrdinal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Ordinal of ChineseZodiacQueryStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Ordinal of ChineseZodiacQueryStateJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setOrdinal(extracted_integer);
      }


    private void  fromJSONYesOrNo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field YesOrNo of ChineseZodiacQueryStateJSON is not true for false.");
              }
          }
        setYesOrNo(the_bool);
      }


    public ChineseZodiacQueryStateJSON()
      {
        flagHasQueryType = false;
        flagHasYear = false;
        flagHasZodiacSign = false;
        flagHasZodiacSignInEnglish = false;
        flagHasOrdinal = false;
        flagHasYesOrNo = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQueryType()
      {
        return flagHasQueryType;
      }

    public TypeQueryType  getQueryType()
      {
        Debug.Assert(flagHasQueryType);
        return storeQueryType;
      }

    public string  getQueryTypeAsString()
      {
        return stringFromQueryType(getQueryType());
      }

    public bool  hasYear()
      {
        return flagHasYear;
      }

    public BigInteger  getYear()
      {
        Debug.Assert(flagHasYear);
        return storeYear;
      }

    public bool  hasZodiacSign()
      {
        return flagHasZodiacSign;
      }

    public string  getZodiacSign()
      {
        Debug.Assert(flagHasZodiacSign);
        return storeZodiacSign;
      }

    public bool  hasZodiacSignInEnglish()
      {
        return flagHasZodiacSignInEnglish;
      }

    public ChineseZodiacSignJSON   getZodiacSignInEnglish()
      {
        Debug.Assert(flagHasZodiacSignInEnglish);
        return storeZodiacSignInEnglish;
      }

    public ChineseZodiacSignJSON.TypeValue  getZodiacSignInEnglishValue()
      {
        return getZodiacSignInEnglish().getValue();
      }

    public string  getZodiacSignInEnglishAsString()
      {
        return getZodiacSignInEnglish().getValueAsString();
      }

    public bool  hasOrdinal()
      {
        return flagHasOrdinal;
      }

    public BigInteger  getOrdinal()
      {
        Debug.Assert(flagHasOrdinal);
        return storeOrdinal;
      }

    public bool  hasYesOrNo()
      {
        return flagHasYesOrNo;
      }

    public bool  getYesOrNo()
      {
        Debug.Assert(flagHasYesOrNo);
        return storeYesOrNo;
      }


    public virtual int extraChineseZodiacQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChineseZodiacQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChineseZodiacQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChineseZodiacQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQueryType(TypeQueryType new_value)
      {
        flagHasQueryType = true;
        storeQueryType = new_value;
      }
    public void setQueryType(string chars)
      {
        setQueryType(stringToQueryType(chars));
      }
    public void unsetQueryType()
      {
        flagHasQueryType = false;
      }
    public void setYear(BigInteger new_value)
      {
        flagHasYear = true;
        storeYear = new_value;
      }
    public void unsetYear()
      {
        flagHasYear = false;
      }
    public void setZodiacSign(string new_value)
      {
        flagHasZodiacSign = true;
        storeZodiacSign = new_value;
      }
    public void unsetZodiacSign()
      {
        flagHasZodiacSign = false;
      }
    public void setZodiacSignInEnglish(ChineseZodiacSignJSON  new_value)
      {
        if (flagHasZodiacSignInEnglish)
          {
          }
        flagHasZodiacSignInEnglish = true;
        storeZodiacSignInEnglish = new_value;
      }
    public void setZodiacSignInEnglish(ChineseZodiacSignJSON.TypeValue new_value)
      {
        setZodiacSignInEnglish(new ChineseZodiacSignJSON(new_value));
      }
    public void setZodiacSignInEnglish(string chars)
      {
        ChineseZodiacSignJSON.TypeValueKnownValues known = ChineseZodiacSignJSON.stringToValue(chars);
        ChineseZodiacSignJSON.TypeValue new_value = new ChineseZodiacSignJSON.TypeValue();
        if (known == ChineseZodiacSignJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setZodiacSignInEnglish(new_value);
      }
    public void unsetZodiacSignInEnglish()
      {
        if (flagHasZodiacSignInEnglish)
          {
          }
        flagHasZodiacSignInEnglish = false;
      }
    public void setOrdinal(BigInteger new_value)
      {
        flagHasOrdinal = true;
        storeOrdinal = new_value;
      }
    public void unsetOrdinal()
      {
        flagHasOrdinal = false;
      }
    public void setYesOrNo(bool new_value)
      {
        flagHasYesOrNo = true;
        storeYesOrNo = new_value;
      }
    public void unsetYesOrNo()
      {
        flagHasYesOrNo = false;
      }

    public virtual void extraChineseZodiacQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChineseZodiacQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChineseZodiacQueryStateLookup(key);
        if (old_field == null)
          {
            extraChineseZodiacQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryType);
        if (flagHasQueryType)
          {
            handler.start_pair("QueryType");
            switch (storeQueryType)
              {
                case TypeQueryType.QueryType_GeneralInformation:
                    handler.string_value("GeneralInformation");
                    break;
                case TypeQueryType.QueryType_SignOfGivenYear:
                    handler.string_value("SignOfGivenYear");
                    break;
                case TypeQueryType.QueryType_YearOfGivenSign:
                    handler.string_value("YearOfGivenSign");
                    break;
                case TypeQueryType.QueryType_SignOfGivenSign:
                    handler.string_value("SignOfGivenSign");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasYear)
          {
            handler.start_pair("Year");
            handler.number_value(storeYear);
          }
        if (flagHasZodiacSign)
          {
            handler.start_pair("ZodiacSign");
            handler.string_value(storeZodiacSign);
          }
        if (flagHasZodiacSignInEnglish)
          {
            handler.start_pair("ZodiacSignInEnglish");
            if (partial_allowed)
                storeZodiacSignInEnglish.write_partial_as_json(handler);
            else
                storeZodiacSignInEnglish.write_as_json(handler);
          }
        if (flagHasOrdinal)
          {
            handler.start_pair("Ordinal");
            handler.number_value(storeOrdinal);
          }
        if (flagHasYesOrNo)
          {
            handler.start_pair("YesOrNo");
            handler.boolean_value(storeYesOrNo);
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
        if (!(hasQueryType()))
          {
            return "When parsing the object for %what%, the \"QueryType\" field was missing.";
          }
        return null;
      }

    public static ChineseZodiacQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseZodiacQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacQueryState", ignore_extras);
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
    public static ChineseZodiacQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChineseZodiacQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseZodiacQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacQueryState", ignore_extras);
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
    public static ChineseZodiacQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChineseZodiacQueryStateJSON from_text(string text, bool ignore_extras)
      {
        ChineseZodiacQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChineseZodiacQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ChineseZodiacQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChineseZodiacQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorQueryType : JSONStringGenerator
          {
            protected FieldGeneratorQueryType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQueryType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToQueryType(result));
              }
            protected abstract void handle_result(TypeQueryType result);
          };
    private class FieldHoldingGeneratorQueryType : FieldGeneratorQueryType
  {
    protected override void handle_result(TypeQueryType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQueryType(String what)
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
    public TypeQueryType value;
  };
    private class FieldHoldingArrayGeneratorQueryType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQueryType
      {
        private FieldHoldingArrayGeneratorQueryType top;

        protected override void handle_result(TypeQueryType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQueryType init_top)
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
    protected virtual void handle_result(List<TypeQueryType> result)
      {
      }

    public FieldHoldingArrayGeneratorQueryType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQueryType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQueryType> value;
  };
        private FieldHoldingGeneratorQueryType fieldGeneratorQueryType;
    private class FieldHoldingGeneratorYear : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorYear(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorYear(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorYear fieldGeneratorYear;
        private JSONHoldingStringGenerator fieldGeneratorZodiacSign;
        private ChineseZodiacSignJSON.HoldingGenerator fieldGeneratorZodiacSignInEnglish;
    private class FieldHoldingGeneratorOrdinal : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorOrdinal(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorOrdinal : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorOrdinal(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorOrdinal fieldGeneratorOrdinal;
        private JSONHoldingBooleanGenerator fieldGeneratorYesOrNo;
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
            ChineseZodiacQueryStateJSON result = new ChineseZodiacQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChineseZodiacQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ChineseZodiacQueryStateJSON result)
          {
            if (fieldGeneratorQueryType.have_value)
              {
                result.setQueryType(fieldGeneratorQueryType.value);
                fieldGeneratorQueryType.have_value = false;
              }
            else if ((!(result.hasQueryType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryType\" field was missing.");
              }
            if (fieldGeneratorYear.have_value)
              {
                result.setYear(fieldGeneratorYear.value);
                fieldGeneratorYear.have_value = false;
              }
            if (fieldGeneratorZodiacSign.have_value)
              {
                result.setZodiacSign(fieldGeneratorZodiacSign.value);
                fieldGeneratorZodiacSign.have_value = false;
              }
            if (fieldGeneratorZodiacSignInEnglish.have_value)
              {
                result.setZodiacSignInEnglish(fieldGeneratorZodiacSignInEnglish.value);
                fieldGeneratorZodiacSignInEnglish.have_value = false;
              }
            if (fieldGeneratorOrdinal.have_value)
              {
                result.setOrdinal(fieldGeneratorOrdinal.value);
                fieldGeneratorOrdinal.have_value = false;
              }
            if (fieldGeneratorYesOrNo.have_value)
              {
                result.setYesOrNo(fieldGeneratorYesOrNo.value);
                fieldGeneratorYesOrNo.have_value = false;
              }
          }
        protected abstract void handle_result(ChineseZodiacQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'O':
                    if ((String.Compare(field_name, 1, "rdinal", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorOrdinal;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryType;
                    break;
                case 'Y':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 3, "r", 0, 1, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorYear;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 3, "OrNo", 0, 4, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorYesOrNo;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Z':
                    if (String.Compare(field_name, 1, "odiacSign", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorZodiacSign;
                          }
                        switch (field_name[10])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 11, "nEnglish", 0, 8, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorZodiacSignInEnglish;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the ChineseZodiacQueryState class");
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the ChineseZodiacQueryState class");
            fieldGeneratorZodiacSign = new JSONHoldingStringGenerator("field \"ZodiacSign\" of the ChineseZodiacQueryState class");
            fieldGeneratorZodiacSignInEnglish = new ChineseZodiacSignJSON.HoldingGenerator("field \"ZodiacSignInEnglish\" of the ChineseZodiacQueryState class", ignore_extras);
            fieldGeneratorOrdinal = new FieldHoldingGeneratorOrdinal("field \"Ordinal\" of the ChineseZodiacQueryState class");
            fieldGeneratorYesOrNo = new JSONHoldingBooleanGenerator("field \"YesOrNo\" of the ChineseZodiacQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChineseZodiacQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the ChineseZodiacQueryState class");
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the ChineseZodiacQueryState class");
            fieldGeneratorZodiacSign = new JSONHoldingStringGenerator("field \"ZodiacSign\" of the ChineseZodiacQueryState class");
            fieldGeneratorZodiacSignInEnglish = new ChineseZodiacSignJSON.HoldingGenerator("field \"ZodiacSignInEnglish\" of the ChineseZodiacQueryState class", false);
            fieldGeneratorOrdinal = new FieldHoldingGeneratorOrdinal("field \"Ordinal\" of the ChineseZodiacQueryState class");
            fieldGeneratorYesOrNo = new JSONHoldingBooleanGenerator("field \"YesOrNo\" of the ChineseZodiacQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChineseZodiacQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            fieldGeneratorYear.reset();
            fieldGeneratorZodiacSign.reset();
            fieldGeneratorZodiacSignInEnglish.reset();
            fieldGeneratorOrdinal.reset();
            fieldGeneratorYesOrNo.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorZodiacSignInEnglish.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorZodiacSignInEnglish.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ChineseZodiacQueryStateJSON  result)
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
        public ChineseZodiacQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChineseZodiacQueryStateJSON  result)
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
    protected virtual void handle_result(List<ChineseZodiacQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChineseZodiacQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChineseZodiacQueryStateJSON>();
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
    public List<ChineseZodiacQueryStateJSON> value;
  };
  };
