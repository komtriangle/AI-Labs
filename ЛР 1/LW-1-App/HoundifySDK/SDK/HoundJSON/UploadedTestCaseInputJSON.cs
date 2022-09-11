/* file "UploadedTestCaseInputJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class UploadedTestCaseInputJSON : JSONBase
  {
    private bool flagHasNow;
    private DateAndOrTimeJSON  storeNow;
    private bool flagHasDeltaRequestInfo;
    private JSONObjectValue  storeDeltaRequestInfo;
    private bool flagHasMaxResults;
    private BigInteger storeMaxResults;
    private bool flagHasAllResults;
    private bool storeAllResults;
    private bool flagHasWhichDynamicResponse;
    private string storeWhichDynamicResponse;
    private bool flagHasWeights;
    private bool storeWeights;


    private void  fromJSONNow(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setNow(convert_classy);
      }


    private void  fromJSONDeltaRequestInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field DeltaRequestInfo of UploadedTestCaseInputJSON is not an object.");
        setDeltaRequestInfo(json_value.object_value());
      }


    private void  fromJSONMaxResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MaxResults of UploadedTestCaseInputJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MaxResults of UploadedTestCaseInputJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMaxResults(extracted_integer);
      }


    private void  fromJSONAllResults(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AllResults of UploadedTestCaseInputJSON is not true for false.");
              }
          }
        setAllResults(the_bool);
      }


    private void  fromJSONWhichDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WhichDynamicResponse of UploadedTestCaseInputJSON is not a string.");
        setWhichDynamicResponse(json_string.getData());
      }


    private void  fromJSONWeights(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Weights of UploadedTestCaseInputJSON is not true for false.");
              }
          }
        setWeights(the_bool);
      }


    public UploadedTestCaseInputJSON()
      {
        flagHasNow = false;
        flagHasDeltaRequestInfo = false;
        flagHasMaxResults = false;
        flagHasAllResults = false;
        flagHasWhichDynamicResponse = false;
        flagHasWeights = false;
      }

    public abstract string getKind();
    public bool  hasNow()
      {
        return flagHasNow;
      }

    public DateAndOrTimeJSON   getNow()
      {
        Debug.Assert(flagHasNow);
        return storeNow;
      }

    public bool  hasDeltaRequestInfo()
      {
        return flagHasDeltaRequestInfo;
      }

    public JSONObjectValue   getDeltaRequestInfo()
      {
        Debug.Assert(flagHasDeltaRequestInfo);
        return storeDeltaRequestInfo;
      }

    public bool  hasMaxResults()
      {
        return flagHasMaxResults;
      }

    public BigInteger  getMaxResults()
      {
        Debug.Assert(flagHasMaxResults);
        return storeMaxResults;
      }

    public bool  hasAllResults()
      {
        return flagHasAllResults;
      }

    public bool  getAllResults()
      {
        Debug.Assert(flagHasAllResults);
        return storeAllResults;
      }

    public bool  hasWhichDynamicResponse()
      {
        return flagHasWhichDynamicResponse;
      }

    public string  getWhichDynamicResponse()
      {
        Debug.Assert(flagHasWhichDynamicResponse);
        return storeWhichDynamicResponse;
      }

    public bool  hasWeights()
      {
        return flagHasWeights;
      }

    public bool  getWeights()
      {
        Debug.Assert(flagHasWeights);
        return storeWeights;
      }


    public abstract int extraUploadedTestCaseInputComponentCount();
    public abstract string extraUploadedTestCaseInputComponentKey(int component_num);
    public abstract JSONValue extraUploadedTestCaseInputComponentValue(int component_num);
    public abstract JSONValue extraUploadedTestCaseInputLookup(string field_name);

    public void setNow(DateAndOrTimeJSON  new_value)
      {
        if (flagHasNow)
          {
          }
        flagHasNow = true;
        storeNow = new_value;
      }
    public void unsetNow()
      {
        if (flagHasNow)
          {
          }
        flagHasNow = false;
      }
    public void setDeltaRequestInfo(JSONObjectValue  new_value)
      {
        if (flagHasDeltaRequestInfo)
          {
          }
        flagHasDeltaRequestInfo = true;
        storeDeltaRequestInfo = new_value;
      }
    public void unsetDeltaRequestInfo()
      {
        if (flagHasDeltaRequestInfo)
          {
          }
        flagHasDeltaRequestInfo = false;
      }
    public void setMaxResults(BigInteger new_value)
      {
        flagHasMaxResults = true;
        if (new_value < 1)
            throw new Exception("The value for field MaxResults of UploadedTestCaseInputJSON is less than the lower bound (1) for that field.");
        storeMaxResults = new_value;
      }
    public void unsetMaxResults()
      {
        flagHasMaxResults = false;
      }
    public void setAllResults(bool new_value)
      {
        flagHasAllResults = true;
        storeAllResults = new_value;
      }
    public void unsetAllResults()
      {
        flagHasAllResults = false;
      }
    public void setWhichDynamicResponse(string new_value)
      {
        flagHasWhichDynamicResponse = true;
        storeWhichDynamicResponse = new_value;
      }
    public void unsetWhichDynamicResponse()
      {
        flagHasWhichDynamicResponse = false;
      }
    public void setWeights(bool new_value)
      {
        flagHasWeights = true;
        storeWeights = new_value;
      }
    public void unsetWeights()
      {
        flagHasWeights = false;
      }

    public abstract void extraUploadedTestCaseInputAppendPair(string key, JSONValue new_component);
    public abstract void extraUploadedTestCaseInputSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("Kind", getKind());
        if (flagHasNow)
          {
            handler.start_pair("Now");
            if (partial_allowed)
                storeNow.write_partial_as_json(handler);
            else
                storeNow.write_as_json(handler);
          }
        if (flagHasDeltaRequestInfo)
          {
            handler.start_pair("DeltaRequestInfo");
            storeDeltaRequestInfo.write(handler);
          }
        if (flagHasMaxResults)
          {
            handler.start_pair("MaxResults");
            handler.number_value(storeMaxResults);
          }
        if (flagHasAllResults)
          {
            handler.start_pair("AllResults");
            handler.boolean_value(storeAllResults);
          }
        if (flagHasWhichDynamicResponse)
          {
            handler.start_pair("WhichDynamicResponse");
            handler.string_value(storeWhichDynamicResponse);
          }
        if (flagHasWeights)
          {
            handler.start_pair("Weights");
            handler.boolean_value(storeWeights);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static UploadedTestCaseInputJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedTestCaseInputJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestCaseInput", ignore_extras);
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
    public static UploadedTestCaseInputJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedTestCaseInputJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedTestCaseInputJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestCaseInput", ignore_extras);
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
    public static UploadedTestCaseInputJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedTestCaseInputJSON from_text(string text, bool ignore_extras)
      {
        UploadedTestCaseInputJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestCaseInput", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UploadedTestCaseInputJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UploadedTestCaseInputJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UploadedTestCaseInputJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestCaseInput", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNow;
        private JSONHoldingObjectValueGenerator fieldGeneratorDeltaRequestInfo;
    private class FieldHoldingGeneratorMaxResults : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMaxResults(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMaxResults : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMaxResults(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorMaxResults fieldGeneratorMaxResults;
        private JSONHoldingBooleanGenerator fieldGeneratorAllResults;
        private JSONHoldingStringGenerator fieldGeneratorWhichDynamicResponse;
        private JSONHoldingBooleanGenerator fieldGeneratorWeights;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `Kind' field is missing.");
            UploadedTestCaseInputJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUploadedTestCaseInputAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getUploadedTestCaseInputJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `Kind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(UploadedTestCaseInputJSON result)
          {
            if (fieldGeneratorNow.have_value)
              {
                result.setNow(fieldGeneratorNow.value);
                fieldGeneratorNow.have_value = false;
              }
            if (fieldGeneratorDeltaRequestInfo.have_value)
              {
                result.setDeltaRequestInfo(fieldGeneratorDeltaRequestInfo.value);
                fieldGeneratorDeltaRequestInfo.have_value = false;
              }
            if (fieldGeneratorMaxResults.have_value)
              {
                result.setMaxResults(fieldGeneratorMaxResults.value);
                fieldGeneratorMaxResults.have_value = false;
              }
            if (fieldGeneratorAllResults.have_value)
              {
                result.setAllResults(fieldGeneratorAllResults.value);
                fieldGeneratorAllResults.have_value = false;
              }
            if (fieldGeneratorWhichDynamicResponse.have_value)
              {
                result.setWhichDynamicResponse(fieldGeneratorWhichDynamicResponse.value);
                fieldGeneratorWhichDynamicResponse.have_value = false;
              }
            if (fieldGeneratorWeights.have_value)
              {
                result.setWeights(fieldGeneratorWeights.value);
                fieldGeneratorWeights.have_value = false;
              }
          }
        protected abstract void handle_result(UploadedTestCaseInputJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "llResults", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorAllResults;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "eltaRequestInfo", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorDeltaRequestInfo;
                    break;
                case 'K':
                    if ((String.Compare(field_name, 1, "ind", 0, 3, false) == 0) && (field_name.Length == 4))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "axResults", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorMaxResults;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ow", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorNow;
                    break;
                case 'W':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ights", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorWeights;
                            break;
                        case 'h':
                            if ((String.Compare(field_name, 2, "ichDynamicResponse", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorWhichDynamicResponse;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorNow = new DateAndOrTimeJSON.HoldingGenerator("field \"Now\" of the UploadedTestCaseInput class", ignore_extras);
            fieldGeneratorDeltaRequestInfo = new JSONHoldingObjectValueGenerator("field \"DeltaRequestInfo\" of the UploadedTestCaseInput class");
            fieldGeneratorMaxResults = new FieldHoldingGeneratorMaxResults("field \"MaxResults\" of the UploadedTestCaseInput class");
            fieldGeneratorAllResults = new JSONHoldingBooleanGenerator("field \"AllResults\" of the UploadedTestCaseInput class");
            fieldGeneratorWhichDynamicResponse = new JSONHoldingStringGenerator("field \"WhichDynamicResponse\" of the UploadedTestCaseInput class");
            fieldGeneratorWeights = new JSONHoldingBooleanGenerator("field \"Weights\" of the UploadedTestCaseInput class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"Kind\" of the UploadedTestCaseInput class");
            set_what("the UploadedTestCaseInput class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorNow = new DateAndOrTimeJSON.HoldingGenerator("field \"Now\" of the UploadedTestCaseInput class", false);
            fieldGeneratorDeltaRequestInfo = new JSONHoldingObjectValueGenerator("field \"DeltaRequestInfo\" of the UploadedTestCaseInput class");
            fieldGeneratorMaxResults = new FieldHoldingGeneratorMaxResults("field \"MaxResults\" of the UploadedTestCaseInput class");
            fieldGeneratorAllResults = new JSONHoldingBooleanGenerator("field \"AllResults\" of the UploadedTestCaseInput class");
            fieldGeneratorWhichDynamicResponse = new JSONHoldingStringGenerator("field \"WhichDynamicResponse\" of the UploadedTestCaseInput class");
            fieldGeneratorWeights = new JSONHoldingBooleanGenerator("field \"Weights\" of the UploadedTestCaseInput class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"Kind\" of the UploadedTestCaseInput class");
            set_what("the UploadedTestCaseInput class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorNow.reset();
            fieldGeneratorDeltaRequestInfo.reset();
            fieldGeneratorMaxResults.reset();
            fieldGeneratorAllResults.reset();
            fieldGeneratorWhichDynamicResponse.reset();
            fieldGeneratorWeights.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorNow.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorNow.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UploadedTestCaseInputJSON  result)
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
        public UploadedTestCaseInputJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UploadedTestCaseInputJSON  result)
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
    protected virtual void handle_result(List<UploadedTestCaseInputJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UploadedTestCaseInputJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UploadedTestCaseInputJSON>();
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
    public List<UploadedTestCaseInputJSON> value;
  };
    class GenericUploadedTestCaseInputJSON : UploadedTestCaseInputJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericUploadedTestCaseInputJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getKind()  { return key; }
        public override int extraUploadedTestCaseInputComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraUploadedTestCaseInputComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraUploadedTestCaseInputComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraUploadedTestCaseInputLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraUploadedTestCaseInputAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraUploadedTestCaseInputSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraUploadedTestCaseInputLookup(key);
            if (old_field == null)
              {
                extraUploadedTestCaseInputAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static UploadedTestCaseInputJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {

        return new GenericUploadedTestCaseInputJSON(key);
      }
  };
