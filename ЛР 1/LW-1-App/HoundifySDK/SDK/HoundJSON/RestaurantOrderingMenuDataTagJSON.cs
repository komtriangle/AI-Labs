/* file "RestaurantOrderingMenuDataTagJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RestaurantOrderingMenuDataTagJSON : JSONBase
  {
    private bool flagHasKey;
    private string storeKey;
    private bool flagHasWrittenName;
    private string storeWrittenName;
    private bool flagHasSpokenName;
    private string storeSpokenName;
    private bool flagHasRecognitionExpression;
    private RestaurantOrderingMenuDataExpressionRecognitionPatternJSON  storeRecognitionExpression;
    private bool flagHasASRFallbackRecognitionExpression;
    private RestaurantOrderingMenuDataExpressionRecognitionPatternJSON  storeASRFallbackRecognitionExpression;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONKey(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Key of RestaurantOrderingMenuDataTagJSON is not a string.");
        setKey(json_string.getData());
      }


    private void  fromJSONWrittenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenName of RestaurantOrderingMenuDataTagJSON is not a string.");
        setWrittenName(json_string.getData());
      }


    private void  fromJSONSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenName of RestaurantOrderingMenuDataTagJSON is not a string.");
        setSpokenName(json_string.getData());
      }


    private void  fromJSONRecognitionExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RestaurantOrderingMenuDataExpressionRecognitionPatternJSON convert_classy = RestaurantOrderingMenuDataExpressionRecognitionPatternJSON.from_json(json_value, ignore_extras, true);
        setRecognitionExpression(convert_classy);
      }


    private void  fromJSONASRFallbackRecognitionExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RestaurantOrderingMenuDataExpressionRecognitionPatternJSON convert_classy = RestaurantOrderingMenuDataExpressionRecognitionPatternJSON.from_json(json_value, ignore_extras, true);
        setASRFallbackRecognitionExpression(convert_classy);
      }


    public RestaurantOrderingMenuDataTagJSON()
      {
        flagHasKey = false;
        flagHasWrittenName = false;
        flagHasSpokenName = false;
        flagHasRecognitionExpression = false;
        flagHasASRFallbackRecognitionExpression = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasKey()
      {
        return flagHasKey;
      }

    public string  getKey()
      {
        Debug.Assert(flagHasKey);
        return storeKey;
      }

    public bool  hasWrittenName()
      {
        return flagHasWrittenName;
      }

    public string  getWrittenName()
      {
        Debug.Assert(flagHasWrittenName);
        return storeWrittenName;
      }

    public bool  hasSpokenName()
      {
        return flagHasSpokenName;
      }

    public string  getSpokenName()
      {
        Debug.Assert(flagHasSpokenName);
        return storeSpokenName;
      }

    public bool  hasRecognitionExpression()
      {
        return flagHasRecognitionExpression;
      }

    public RestaurantOrderingMenuDataExpressionRecognitionPatternJSON   getRecognitionExpression()
      {
        Debug.Assert(flagHasRecognitionExpression);
        return storeRecognitionExpression;
      }

    public bool  hasASRFallbackRecognitionExpression()
      {
        return flagHasASRFallbackRecognitionExpression;
      }

    public RestaurantOrderingMenuDataExpressionRecognitionPatternJSON   getASRFallbackRecognitionExpression()
      {
        Debug.Assert(flagHasASRFallbackRecognitionExpression);
        return storeASRFallbackRecognitionExpression;
      }


    public virtual int extraRestaurantOrderingMenuDataTagComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantOrderingMenuDataTagComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataTagComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataTagLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setKey(string new_value)
      {
        flagHasKey = true;
        storeKey = new_value;
      }
    public void unsetKey()
      {
        flagHasKey = false;
      }
    public void setWrittenName(string new_value)
      {
        flagHasWrittenName = true;
        storeWrittenName = new_value;
      }
    public void unsetWrittenName()
      {
        flagHasWrittenName = false;
      }
    public void setSpokenName(string new_value)
      {
        flagHasSpokenName = true;
        storeSpokenName = new_value;
      }
    public void unsetSpokenName()
      {
        flagHasSpokenName = false;
      }
    public void setRecognitionExpression(RestaurantOrderingMenuDataExpressionRecognitionPatternJSON  new_value)
      {
        if (flagHasRecognitionExpression)
          {
          }
        flagHasRecognitionExpression = true;
        storeRecognitionExpression = new_value;
      }
    public void unsetRecognitionExpression()
      {
        if (flagHasRecognitionExpression)
          {
          }
        flagHasRecognitionExpression = false;
      }
    public void setASRFallbackRecognitionExpression(RestaurantOrderingMenuDataExpressionRecognitionPatternJSON  new_value)
      {
        if (flagHasASRFallbackRecognitionExpression)
          {
          }
        flagHasASRFallbackRecognitionExpression = true;
        storeASRFallbackRecognitionExpression = new_value;
      }
    public void unsetASRFallbackRecognitionExpression()
      {
        if (flagHasASRFallbackRecognitionExpression)
          {
          }
        flagHasASRFallbackRecognitionExpression = false;
      }

    public virtual void extraRestaurantOrderingMenuDataTagAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantOrderingMenuDataTagSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantOrderingMenuDataTagLookup(key);
        if (old_field == null)
          {
            extraRestaurantOrderingMenuDataTagAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasKey);
        if (flagHasKey)
          {
            handler.start_pair("Key");
            handler.string_value(storeKey);
          }
        Debug.Assert(partial_allowed || flagHasWrittenName);
        if (flagHasWrittenName)
          {
            handler.start_pair("WrittenName");
            handler.string_value(storeWrittenName);
          }
        Debug.Assert(partial_allowed || flagHasSpokenName);
        if (flagHasSpokenName)
          {
            handler.start_pair("SpokenName");
            handler.string_value(storeSpokenName);
          }
        if (flagHasRecognitionExpression)
          {
            handler.start_pair("RecognitionExpression");
            if (partial_allowed)
                storeRecognitionExpression.write_partial_as_json(handler);
            else
                storeRecognitionExpression.write_as_json(handler);
          }
        if (flagHasASRFallbackRecognitionExpression)
          {
            handler.start_pair("ASRFallbackRecognitionExpression");
            if (partial_allowed)
                storeASRFallbackRecognitionExpression.write_partial_as_json(handler);
            else
                storeASRFallbackRecognitionExpression.write_as_json(handler);
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
        if (!(hasKey()))
          {
            return "When parsing the object for %what%, the \"Key\" field was missing.";
          }
        if (!(hasWrittenName()))
          {
            return "When parsing the object for %what%, the \"WrittenName\" field was missing.";
          }
        if (!(hasSpokenName()))
          {
            return "When parsing the object for %what%, the \"SpokenName\" field was missing.";
          }
        return null;
      }

    public static RestaurantOrderingMenuDataTagJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataTagJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataTag", ignore_extras);
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
    public static RestaurantOrderingMenuDataTagJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingMenuDataTagJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataTagJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataTag", ignore_extras);
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
    public static RestaurantOrderingMenuDataTagJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingMenuDataTagJSON from_text(string text, bool ignore_extras)
      {
        RestaurantOrderingMenuDataTagJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataTag", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantOrderingMenuDataTagJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantOrderingMenuDataTagJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantOrderingMenuDataTagJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataTag", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorKey;
        private JSONHoldingStringGenerator fieldGeneratorWrittenName;
        private JSONHoldingStringGenerator fieldGeneratorSpokenName;
        private RestaurantOrderingMenuDataExpressionRecognitionPatternJSON.HoldingGenerator fieldGeneratorRecognitionExpression;
        private RestaurantOrderingMenuDataExpressionRecognitionPatternJSON.HoldingGenerator fieldGeneratorASRFallbackRecognitionExpression;
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
            RestaurantOrderingMenuDataTagJSON result = new RestaurantOrderingMenuDataTagJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantOrderingMenuDataTagAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantOrderingMenuDataTagJSON result)
          {
            if (fieldGeneratorKey.have_value)
              {
                result.setKey(fieldGeneratorKey.value);
                fieldGeneratorKey.have_value = false;
              }
            else if ((!(result.hasKey())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Key\" field was missing.");
              }
            if (fieldGeneratorWrittenName.have_value)
              {
                result.setWrittenName(fieldGeneratorWrittenName.value);
                fieldGeneratorWrittenName.have_value = false;
              }
            else if ((!(result.hasWrittenName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenName\" field was missing.");
              }
            if (fieldGeneratorSpokenName.have_value)
              {
                result.setSpokenName(fieldGeneratorSpokenName.value);
                fieldGeneratorSpokenName.have_value = false;
              }
            else if ((!(result.hasSpokenName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenName\" field was missing.");
              }
            if (fieldGeneratorRecognitionExpression.have_value)
              {
                result.setRecognitionExpression(fieldGeneratorRecognitionExpression.value);
                fieldGeneratorRecognitionExpression.have_value = false;
              }
            if (fieldGeneratorASRFallbackRecognitionExpression.have_value)
              {
                result.setASRFallbackRecognitionExpression(fieldGeneratorASRFallbackRecognitionExpression.value);
                fieldGeneratorASRFallbackRecognitionExpression.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantOrderingMenuDataTagJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "SRFallbackRecognitionExpression", 0, 31, false) == 0) && (field_name.Length == 32))
                        return fieldGeneratorASRFallbackRecognitionExpression;
                    break;
                case 'K':
                    if ((String.Compare(field_name, 1, "ey", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorKey;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ecognitionExpression", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorRecognitionExpression;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenName", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSpokenName;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenName", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorWrittenName;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorKey = new JSONHoldingStringGenerator("field \"Key\" of the RestaurantOrderingMenuDataTag class");
            fieldGeneratorWrittenName = new JSONHoldingStringGenerator("field \"WrittenName\" of the RestaurantOrderingMenuDataTag class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the RestaurantOrderingMenuDataTag class");
            fieldGeneratorRecognitionExpression = new RestaurantOrderingMenuDataExpressionRecognitionPatternJSON.HoldingGenerator("field \"RecognitionExpression\" of the RestaurantOrderingMenuDataTag class", ignore_extras);
            fieldGeneratorASRFallbackRecognitionExpression = new RestaurantOrderingMenuDataExpressionRecognitionPatternJSON.HoldingGenerator("field \"ASRFallbackRecognitionExpression\" of the RestaurantOrderingMenuDataTag class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantOrderingMenuDataTag class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorKey = new JSONHoldingStringGenerator("field \"Key\" of the RestaurantOrderingMenuDataTag class");
            fieldGeneratorWrittenName = new JSONHoldingStringGenerator("field \"WrittenName\" of the RestaurantOrderingMenuDataTag class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the RestaurantOrderingMenuDataTag class");
            fieldGeneratorRecognitionExpression = new RestaurantOrderingMenuDataExpressionRecognitionPatternJSON.HoldingGenerator("field \"RecognitionExpression\" of the RestaurantOrderingMenuDataTag class", false);
            fieldGeneratorASRFallbackRecognitionExpression = new RestaurantOrderingMenuDataExpressionRecognitionPatternJSON.HoldingGenerator("field \"ASRFallbackRecognitionExpression\" of the RestaurantOrderingMenuDataTag class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantOrderingMenuDataTag class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorKey.reset();
            fieldGeneratorWrittenName.reset();
            fieldGeneratorSpokenName.reset();
            fieldGeneratorRecognitionExpression.reset();
            fieldGeneratorASRFallbackRecognitionExpression.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRecognitionExpression.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorASRFallbackRecognitionExpression.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRecognitionExpression.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorASRFallbackRecognitionExpression.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantOrderingMenuDataTagJSON  result)
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
        public RestaurantOrderingMenuDataTagJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantOrderingMenuDataTagJSON  result)
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
    protected virtual void handle_result(List<RestaurantOrderingMenuDataTagJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantOrderingMenuDataTagJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantOrderingMenuDataTagJSON>();
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
    public List<RestaurantOrderingMenuDataTagJSON> value;
  };
  };
