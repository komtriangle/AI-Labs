/* file "AreaCodeQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class AreaCodeQueryStateJSON : JSONBase
  {
    public enum TypeQueryType
      {
        QueryType_CityOfGivenAreaCode,
        QueryType_AreaCodeOfGivenCity
      };

    public static TypeQueryType  stringToQueryType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "reaCodeOfGivenCity", 0, 18, false) == 0) && (chars.Length == 19))
                    return TypeQueryType.QueryType_AreaCodeOfGivenCity;
                break;
            case 'C':
                if ((String.Compare(chars, 1, "ityOfGivenAreaCode", 0, 18, false) == 0) && (chars.Length == 19))
                    return TypeQueryType.QueryType_CityOfGivenAreaCode;
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
            case TypeQueryType.QueryType_CityOfGivenAreaCode:
                return "CityOfGivenAreaCode";
            case TypeQueryType.QueryType_AreaCodeOfGivenCity:
                return "AreaCodeOfGivenCity";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQueryType;
    private TypeQueryType storeQueryType;
    private bool flagHasAreaCode;
    private BigInteger storeAreaCode;
    private bool flagHasCity;
    private string storeCity;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryType of AreaCodeQueryStateJSON is not a string.");
        TypeQueryType the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "reaCodeOfGivenCity", 0, 18, false) == 0) && (json_string.getData().Length == 19))
                      {
                        the_enum = TypeQueryType.QueryType_AreaCodeOfGivenCity;
                        goto enum_is_done;
                      }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "ityOfGivenAreaCode", 0, 18, false) == 0) && (json_string.getData().Length == 19))
                      {
                        the_enum = TypeQueryType.QueryType_CityOfGivenAreaCode;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field QueryType of AreaCodeQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setQueryType(the_enum);
      }


    private void  fromJSONAreaCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AreaCode of AreaCodeQueryStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AreaCode of AreaCodeQueryStateJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAreaCode(extracted_integer);
      }


    private void  fromJSONCity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field City of AreaCodeQueryStateJSON is not a string.");
        setCity(json_string.getData());
      }


    public AreaCodeQueryStateJSON()
      {
        flagHasQueryType = false;
        flagHasAreaCode = false;
        flagHasCity = false;
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

    public bool  hasAreaCode()
      {
        return flagHasAreaCode;
      }

    public BigInteger  getAreaCode()
      {
        Debug.Assert(flagHasAreaCode);
        return storeAreaCode;
      }

    public bool  hasCity()
      {
        return flagHasCity;
      }

    public string  getCity()
      {
        Debug.Assert(flagHasCity);
        return storeCity;
      }


    public virtual int extraAreaCodeQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAreaCodeQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAreaCodeQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAreaCodeQueryStateLookup(string field_name)
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
    public void setAreaCode(BigInteger new_value)
      {
        flagHasAreaCode = true;
        storeAreaCode = new_value;
      }
    public void unsetAreaCode()
      {
        flagHasAreaCode = false;
      }
    public void setCity(string new_value)
      {
        flagHasCity = true;
        storeCity = new_value;
      }
    public void unsetCity()
      {
        flagHasCity = false;
      }

    public virtual void extraAreaCodeQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAreaCodeQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAreaCodeQueryStateLookup(key);
        if (old_field == null)
          {
            extraAreaCodeQueryStateAppendPair(key, new_component);
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
                case TypeQueryType.QueryType_CityOfGivenAreaCode:
                    handler.string_value("CityOfGivenAreaCode");
                    break;
                case TypeQueryType.QueryType_AreaCodeOfGivenCity:
                    handler.string_value("AreaCodeOfGivenCity");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasAreaCode)
          {
            handler.start_pair("AreaCode");
            handler.number_value(storeAreaCode);
          }
        if (flagHasCity)
          {
            handler.start_pair("City");
            handler.string_value(storeCity);
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

    public static AreaCodeQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AreaCodeQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeQueryState", ignore_extras);
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
    public static AreaCodeQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AreaCodeQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AreaCodeQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeQueryState", ignore_extras);
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
    public static AreaCodeQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AreaCodeQueryStateJSON from_text(string text, bool ignore_extras)
      {
        AreaCodeQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AreaCodeQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AreaCodeQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AreaCodeQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AreaCodeQueryState", ignore_extras);
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
    private class FieldHoldingGeneratorAreaCode : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorAreaCode(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAreaCode : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAreaCode(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorAreaCode fieldGeneratorAreaCode;
        private JSONHoldingStringGenerator fieldGeneratorCity;
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
            AreaCodeQueryStateJSON result = new AreaCodeQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAreaCodeQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AreaCodeQueryStateJSON result)
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
            if (fieldGeneratorAreaCode.have_value)
              {
                result.setAreaCode(fieldGeneratorAreaCode.value);
                fieldGeneratorAreaCode.have_value = false;
              }
            if (fieldGeneratorCity.have_value)
              {
                result.setCity(fieldGeneratorCity.value);
                fieldGeneratorCity.have_value = false;
              }
          }
        protected abstract void handle_result(AreaCodeQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "reaCode", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorAreaCode;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ity", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorCity;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the AreaCodeQueryState class");
            fieldGeneratorAreaCode = new FieldHoldingGeneratorAreaCode("field \"AreaCode\" of the AreaCodeQueryState class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the AreaCodeQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AreaCodeQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the AreaCodeQueryState class");
            fieldGeneratorAreaCode = new FieldHoldingGeneratorAreaCode("field \"AreaCode\" of the AreaCodeQueryState class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the AreaCodeQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AreaCodeQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            fieldGeneratorAreaCode.reset();
            fieldGeneratorCity.reset();
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
        protected override void handle_result(AreaCodeQueryStateJSON  result)
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
        public AreaCodeQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AreaCodeQueryStateJSON  result)
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
    protected virtual void handle_result(List<AreaCodeQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AreaCodeQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AreaCodeQueryStateJSON>();
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
    public List<AreaCodeQueryStateJSON> value;
  };
  };
