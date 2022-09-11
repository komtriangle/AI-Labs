/* file "HerePlacesApiSettingsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HerePlacesApiSettingsJSON : JSONBase
  {
    private bool flagHasIsIntentOnly;
    private bool storeIsIntentOnly;
    private bool flagHasBaseUrl;
    private string storeBaseUrl;
    private bool flagHasDiscoverSearchEndpoint;
    private string storeDiscoverSearchEndpoint;
    private bool flagHasDefaultSearchRadius;
    private BigInteger storeDefaultSearchRadius;
    private bool flagHasUrlParameters;
    private List< PairOfStringsJSON  > storeUrlParameters;
    private bool flagHasHttpHeaders;
    private List< PairOfStringsJSON  > storeHttpHeaders;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONIsIntentOnly(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsIntentOnly of HerePlacesApiSettingsJSON is not true for false.");
              }
          }
        setIsIntentOnly(the_bool);
      }


    private void  fromJSONBaseUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BaseUrl of HerePlacesApiSettingsJSON is not a string.");
        setBaseUrl(json_string.getData());
      }


    private void  fromJSONDiscoverSearchEndpoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DiscoverSearchEndpoint of HerePlacesApiSettingsJSON is not a string.");
        setDiscoverSearchEndpoint(json_string.getData());
      }


    private void  fromJSONDefaultSearchRadius(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DefaultSearchRadius of HerePlacesApiSettingsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DefaultSearchRadius of HerePlacesApiSettingsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDefaultSearchRadius(extracted_integer);
      }


    private void  fromJSONUrlParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field UrlParameters of HerePlacesApiSettingsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field UrlParameters of HerePlacesApiSettingsJSON has too few elements.");
        List< PairOfStringsJSON  > vector_UrlParameters1 = new List< PairOfStringsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PairOfStringsJSON convert_classy = PairOfStringsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_UrlParameters1.Add(convert_classy);
          }
        Debug.Assert(vector_UrlParameters1.Count >= 1);
        initUrlParameters();
        for (int num1 = 0; num1 < vector_UrlParameters1.Count; ++num1)
            appendUrlParameters(vector_UrlParameters1[num1]);
        for (int num1 = 0; num1 < vector_UrlParameters1.Count; ++num1)
          {
          }
      }


    private void  fromJSONHttpHeaders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HttpHeaders of HerePlacesApiSettingsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field HttpHeaders of HerePlacesApiSettingsJSON has too few elements.");
        List< PairOfStringsJSON  > vector_HttpHeaders1 = new List< PairOfStringsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PairOfStringsJSON convert_classy = PairOfStringsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_HttpHeaders1.Add(convert_classy);
          }
        Debug.Assert(vector_HttpHeaders1.Count >= 1);
        initHttpHeaders();
        for (int num2 = 0; num2 < vector_HttpHeaders1.Count; ++num2)
            appendHttpHeaders(vector_HttpHeaders1[num2]);
        for (int num1 = 0; num1 < vector_HttpHeaders1.Count; ++num1)
          {
          }
      }


    public HerePlacesApiSettingsJSON()
      {
        flagHasIsIntentOnly = false;
        flagHasBaseUrl = false;
        flagHasDiscoverSearchEndpoint = false;
        flagHasDefaultSearchRadius = false;
        flagHasUrlParameters = false;
        flagHasHttpHeaders = false;
        storeUrlParameters = new List< PairOfStringsJSON  >();
        storeHttpHeaders = new List< PairOfStringsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasIsIntentOnly()
      {
        return flagHasIsIntentOnly;
      }

    public bool  getIsIntentOnly()
      {
        Debug.Assert(flagHasIsIntentOnly);
        return storeIsIntentOnly;
      }

    public bool  hasBaseUrl()
      {
        return flagHasBaseUrl;
      }

    public string  getBaseUrl()
      {
        Debug.Assert(flagHasBaseUrl);
        return storeBaseUrl;
      }

    public bool  hasDiscoverSearchEndpoint()
      {
        return flagHasDiscoverSearchEndpoint;
      }

    public string  getDiscoverSearchEndpoint()
      {
        Debug.Assert(flagHasDiscoverSearchEndpoint);
        return storeDiscoverSearchEndpoint;
      }

    public bool  hasDefaultSearchRadius()
      {
        return flagHasDefaultSearchRadius;
      }

    public BigInteger  getDefaultSearchRadius()
      {
        Debug.Assert(flagHasDefaultSearchRadius);
        return storeDefaultSearchRadius;
      }

    public bool  hasUrlParameters()
      {
        return flagHasUrlParameters;
      }

    public int  countOfUrlParameters()
      {
        Debug.Assert(flagHasUrlParameters);
        return storeUrlParameters.Count;
      }

    public PairOfStringsJSON   elementOfUrlParameters(int element_num)
      {
        Debug.Assert(flagHasUrlParameters);
        return storeUrlParameters[element_num];
      }

    public List< PairOfStringsJSON  >  getUrlParameters()
      {
        Debug.Assert(flagHasUrlParameters);
        return storeUrlParameters;
      }

    public bool  hasHttpHeaders()
      {
        return flagHasHttpHeaders;
      }

    public int  countOfHttpHeaders()
      {
        Debug.Assert(flagHasHttpHeaders);
        return storeHttpHeaders.Count;
      }

    public PairOfStringsJSON   elementOfHttpHeaders(int element_num)
      {
        Debug.Assert(flagHasHttpHeaders);
        return storeHttpHeaders[element_num];
      }

    public List< PairOfStringsJSON  >  getHttpHeaders()
      {
        Debug.Assert(flagHasHttpHeaders);
        return storeHttpHeaders;
      }


    public virtual int extraHerePlacesApiSettingsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHerePlacesApiSettingsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHerePlacesApiSettingsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHerePlacesApiSettingsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setIsIntentOnly(bool new_value)
      {
        flagHasIsIntentOnly = true;
        storeIsIntentOnly = new_value;
      }
    public void unsetIsIntentOnly()
      {
        flagHasIsIntentOnly = false;
      }
    public void setBaseUrl(string new_value)
      {
        flagHasBaseUrl = true;
        storeBaseUrl = new_value;
      }
    public void unsetBaseUrl()
      {
        flagHasBaseUrl = false;
      }
    public void setDiscoverSearchEndpoint(string new_value)
      {
        flagHasDiscoverSearchEndpoint = true;
        storeDiscoverSearchEndpoint = new_value;
      }
    public void unsetDiscoverSearchEndpoint()
      {
        flagHasDiscoverSearchEndpoint = false;
      }
    public void setDefaultSearchRadius(BigInteger new_value)
      {
        flagHasDefaultSearchRadius = true;
        if (new_value < 0)
            throw new Exception("The value for field DefaultSearchRadius of HerePlacesApiSettingsJSON is less than the lower bound (0) for that field.");
        storeDefaultSearchRadius = new_value;
      }
    public void unsetDefaultSearchRadius()
      {
        flagHasDefaultSearchRadius = false;
      }
    public void initUrlParameters()
      {
        if (flagHasUrlParameters)
          {
            for (int num1 = 0; num1 < storeUrlParameters.Count; ++num1)
              {
              }
          }
        flagHasUrlParameters = true;
        storeUrlParameters.Clear();
      }
    public void appendUrlParameters(PairOfStringsJSON  to_append)
      {
        if (!flagHasUrlParameters)
          {
            flagHasUrlParameters = true;
            storeUrlParameters.Clear();
          }
        Debug.Assert(flagHasUrlParameters);
        storeUrlParameters.Add(to_append);
      }
    public void unsetUrlParameters()
      {
        if (flagHasUrlParameters)
          {
            for (int num2 = 0; num2 < storeUrlParameters.Count; ++num2)
              {
              }
          }
        flagHasUrlParameters = false;
        storeUrlParameters.Clear();
      }
    public void initHttpHeaders()
      {
        if (flagHasHttpHeaders)
          {
            for (int num3 = 0; num3 < storeHttpHeaders.Count; ++num3)
              {
              }
          }
        flagHasHttpHeaders = true;
        storeHttpHeaders.Clear();
      }
    public void appendHttpHeaders(PairOfStringsJSON  to_append)
      {
        if (!flagHasHttpHeaders)
          {
            flagHasHttpHeaders = true;
            storeHttpHeaders.Clear();
          }
        Debug.Assert(flagHasHttpHeaders);
        storeHttpHeaders.Add(to_append);
      }
    public void unsetHttpHeaders()
      {
        if (flagHasHttpHeaders)
          {
            for (int num4 = 0; num4 < storeHttpHeaders.Count; ++num4)
              {
              }
          }
        flagHasHttpHeaders = false;
        storeHttpHeaders.Clear();
      }

    public virtual void extraHerePlacesApiSettingsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHerePlacesApiSettingsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHerePlacesApiSettingsLookup(key);
        if (old_field == null)
          {
            extraHerePlacesApiSettingsAppendPair(key, new_component);
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
        if (flagHasIsIntentOnly)
          {
            handler.start_pair("IsIntentOnly");
            handler.boolean_value(storeIsIntentOnly);
          }
        if (flagHasBaseUrl)
          {
            handler.start_pair("BaseUrl");
            handler.string_value(storeBaseUrl);
          }
        if (flagHasDiscoverSearchEndpoint)
          {
            handler.start_pair("DiscoverSearchEndpoint");
            handler.string_value(storeDiscoverSearchEndpoint);
          }
        if (flagHasDefaultSearchRadius)
          {
            handler.start_pair("DefaultSearchRadius");
            handler.number_value(storeDefaultSearchRadius);
          }
        if (flagHasUrlParameters)
          {
            handler.start_pair("UrlParameters");
            Debug.Assert(storeUrlParameters.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeUrlParameters.Count; ++num1)
              {
                if (partial_allowed)
                    storeUrlParameters[num1].write_partial_as_json(handler);
                else
                    storeUrlParameters[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasHttpHeaders)
          {
            handler.start_pair("HttpHeaders");
            Debug.Assert(storeHttpHeaders.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeHttpHeaders.Count; ++num2)
              {
                if (partial_allowed)
                    storeHttpHeaders[num2].write_partial_as_json(handler);
                else
                    storeHttpHeaders[num2].write_as_json(handler);
              }
            handler.finish_array();
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
        return null;
      }

    public static HerePlacesApiSettingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HerePlacesApiSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HerePlacesApiSettings", ignore_extras);
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
    public static HerePlacesApiSettingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HerePlacesApiSettingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HerePlacesApiSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HerePlacesApiSettings", ignore_extras);
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
    public static HerePlacesApiSettingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HerePlacesApiSettingsJSON from_text(string text, bool ignore_extras)
      {
        HerePlacesApiSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HerePlacesApiSettings", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HerePlacesApiSettingsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HerePlacesApiSettingsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HerePlacesApiSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HerePlacesApiSettings", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorIsIntentOnly;
        private JSONHoldingStringGenerator fieldGeneratorBaseUrl;
        private JSONHoldingStringGenerator fieldGeneratorDiscoverSearchEndpoint;
    private class FieldHoldingGeneratorDefaultSearchRadius : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDefaultSearchRadius(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDefaultSearchRadius : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDefaultSearchRadius(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorDefaultSearchRadius fieldGeneratorDefaultSearchRadius;
        private PairOfStringsJSON.HoldingArrayGenerator fieldGeneratorUrlParameters;
        private PairOfStringsJSON.HoldingArrayGenerator fieldGeneratorHttpHeaders;
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
            HerePlacesApiSettingsJSON result = new HerePlacesApiSettingsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHerePlacesApiSettingsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HerePlacesApiSettingsJSON result)
          {
            if (fieldGeneratorIsIntentOnly.have_value)
              {
                result.setIsIntentOnly(fieldGeneratorIsIntentOnly.value);
                fieldGeneratorIsIntentOnly.have_value = false;
              }
            if (fieldGeneratorBaseUrl.have_value)
              {
                result.setBaseUrl(fieldGeneratorBaseUrl.value);
                fieldGeneratorBaseUrl.have_value = false;
              }
            if (fieldGeneratorDiscoverSearchEndpoint.have_value)
              {
                result.setDiscoverSearchEndpoint(fieldGeneratorDiscoverSearchEndpoint.value);
                fieldGeneratorDiscoverSearchEndpoint.have_value = false;
              }
            if (fieldGeneratorDefaultSearchRadius.have_value)
              {
                result.setDefaultSearchRadius(fieldGeneratorDefaultSearchRadius.value);
                fieldGeneratorDefaultSearchRadius.have_value = false;
              }
            if (fieldGeneratorUrlParameters.have_value)
              {
                result.initUrlParameters();
                int count = fieldGeneratorUrlParameters.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendUrlParameters(fieldGeneratorUrlParameters.value[num]);
                  }
                fieldGeneratorUrlParameters.value.Clear();
                fieldGeneratorUrlParameters.have_value = false;
              }
            if (fieldGeneratorHttpHeaders.have_value)
              {
                result.initHttpHeaders();
                int count = fieldGeneratorHttpHeaders.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHttpHeaders(fieldGeneratorHttpHeaders.value[num]);
                  }
                fieldGeneratorHttpHeaders.value.Clear();
                fieldGeneratorHttpHeaders.have_value = false;
              }
          }
        protected abstract void handle_result(HerePlacesApiSettingsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "aseUrl", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorBaseUrl;
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "faultSearchRadius", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorDefaultSearchRadius;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "scoverSearchEndpoint", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorDiscoverSearchEndpoint;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "ttpHeaders", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorHttpHeaders;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sIntentOnly", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorIsIntentOnly;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "rlParameters", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorUrlParameters;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorIsIntentOnly = new JSONHoldingBooleanGenerator("field \"IsIntentOnly\" of the HerePlacesApiSettings class");
            fieldGeneratorBaseUrl = new JSONHoldingStringGenerator("field \"BaseUrl\" of the HerePlacesApiSettings class");
            fieldGeneratorDiscoverSearchEndpoint = new JSONHoldingStringGenerator("field \"DiscoverSearchEndpoint\" of the HerePlacesApiSettings class");
            fieldGeneratorDefaultSearchRadius = new FieldHoldingGeneratorDefaultSearchRadius("field \"DefaultSearchRadius\" of the HerePlacesApiSettings class");
            fieldGeneratorUrlParameters = new PairOfStringsJSON.HoldingArrayGenerator("field \"UrlParameters\" of the HerePlacesApiSettings class", ignore_extras);
            fieldGeneratorHttpHeaders = new PairOfStringsJSON.HoldingArrayGenerator("field \"HttpHeaders\" of the HerePlacesApiSettings class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HerePlacesApiSettings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorIsIntentOnly = new JSONHoldingBooleanGenerator("field \"IsIntentOnly\" of the HerePlacesApiSettings class");
            fieldGeneratorBaseUrl = new JSONHoldingStringGenerator("field \"BaseUrl\" of the HerePlacesApiSettings class");
            fieldGeneratorDiscoverSearchEndpoint = new JSONHoldingStringGenerator("field \"DiscoverSearchEndpoint\" of the HerePlacesApiSettings class");
            fieldGeneratorDefaultSearchRadius = new FieldHoldingGeneratorDefaultSearchRadius("field \"DefaultSearchRadius\" of the HerePlacesApiSettings class");
            fieldGeneratorUrlParameters = new PairOfStringsJSON.HoldingArrayGenerator("field \"UrlParameters\" of the HerePlacesApiSettings class", false);
            fieldGeneratorHttpHeaders = new PairOfStringsJSON.HoldingArrayGenerator("field \"HttpHeaders\" of the HerePlacesApiSettings class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HerePlacesApiSettings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorIsIntentOnly.reset();
            fieldGeneratorBaseUrl.reset();
            fieldGeneratorDiscoverSearchEndpoint.reset();
            fieldGeneratorDefaultSearchRadius.reset();
            fieldGeneratorUrlParameters.reset();
            fieldGeneratorHttpHeaders.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorUrlParameters.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHttpHeaders.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorUrlParameters.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHttpHeaders.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HerePlacesApiSettingsJSON  result)
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
        public HerePlacesApiSettingsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HerePlacesApiSettingsJSON  result)
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
    protected virtual void handle_result(List<HerePlacesApiSettingsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HerePlacesApiSettingsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HerePlacesApiSettingsJSON>();
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
    public List<HerePlacesApiSettingsJSON> value;
  };
  };
