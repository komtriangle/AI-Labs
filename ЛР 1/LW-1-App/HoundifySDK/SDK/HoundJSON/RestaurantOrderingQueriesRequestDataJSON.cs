/* file "RestaurantOrderingQueriesRequestDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RestaurantOrderingQueriesRequestDataJSON : JSONBase
  {
    private bool flagHasRestaurantName;
    private string storeRestaurantName;
    private bool flagHasStoreID;
    private string storeStoreID;
    private bool flagHasMaximumPromptRepetitionUnrelatedIntent;
    private BigInteger storeMaximumPromptRepetitionUnrelatedIntent;
    private bool flagHasMaximumPromptRepetitionUnknownIntent;
    private BigInteger storeMaximumPromptRepetitionUnknownIntent;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRestaurantName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RestaurantName of RestaurantOrderingQueriesRequestDataJSON is not a string.");
        setRestaurantName(json_string.getData());
      }


    private void  fromJSONStoreID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StoreID of RestaurantOrderingQueriesRequestDataJSON is not a string.");
        setStoreID(json_string.getData());
      }


    private void  fromJSONMaximumPromptRepetitionUnrelatedIntent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MaximumPromptRepetitionUnrelatedIntent of RestaurantOrderingQueriesRequestDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MaximumPromptRepetitionUnrelatedIntent of RestaurantOrderingQueriesRequestDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMaximumPromptRepetitionUnrelatedIntent(extracted_integer);
      }


    private void  fromJSONMaximumPromptRepetitionUnknownIntent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MaximumPromptRepetitionUnknownIntent of RestaurantOrderingQueriesRequestDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MaximumPromptRepetitionUnknownIntent of RestaurantOrderingQueriesRequestDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMaximumPromptRepetitionUnknownIntent(extracted_integer);
      }


    public RestaurantOrderingQueriesRequestDataJSON()
      {
        flagHasRestaurantName = false;
        flagHasStoreID = false;
        flagHasMaximumPromptRepetitionUnrelatedIntent = false;
        flagHasMaximumPromptRepetitionUnknownIntent = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRestaurantName()
      {
        return flagHasRestaurantName;
      }

    public string  getRestaurantName()
      {
        Debug.Assert(flagHasRestaurantName);
        return storeRestaurantName;
      }

    public bool  hasStoreID()
      {
        return flagHasStoreID;
      }

    public string  getStoreID()
      {
        Debug.Assert(flagHasStoreID);
        return storeStoreID;
      }

    public bool  hasMaximumPromptRepetitionUnrelatedIntent()
      {
        return flagHasMaximumPromptRepetitionUnrelatedIntent;
      }

    public BigInteger  getMaximumPromptRepetitionUnrelatedIntent()
      {
        Debug.Assert(flagHasMaximumPromptRepetitionUnrelatedIntent);
        return storeMaximumPromptRepetitionUnrelatedIntent;
      }

    public bool  hasMaximumPromptRepetitionUnknownIntent()
      {
        return flagHasMaximumPromptRepetitionUnknownIntent;
      }

    public BigInteger  getMaximumPromptRepetitionUnknownIntent()
      {
        Debug.Assert(flagHasMaximumPromptRepetitionUnknownIntent);
        return storeMaximumPromptRepetitionUnknownIntent;
      }


    public virtual int extraRestaurantOrderingQueriesRequestDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantOrderingQueriesRequestDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingQueriesRequestDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingQueriesRequestDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRestaurantName(string new_value)
      {
        flagHasRestaurantName = true;
        storeRestaurantName = new_value;
      }
    public void unsetRestaurantName()
      {
        flagHasRestaurantName = false;
      }
    public void setStoreID(string new_value)
      {
        flagHasStoreID = true;
        storeStoreID = new_value;
      }
    public void unsetStoreID()
      {
        flagHasStoreID = false;
      }
    public void setMaximumPromptRepetitionUnrelatedIntent(BigInteger new_value)
      {
        flagHasMaximumPromptRepetitionUnrelatedIntent = true;
        if (new_value < 0)
            throw new Exception("The value for field MaximumPromptRepetitionUnrelatedIntent of RestaurantOrderingQueriesRequestDataJSON is less than the lower bound (0) for that field.");
        storeMaximumPromptRepetitionUnrelatedIntent = new_value;
      }
    public void unsetMaximumPromptRepetitionUnrelatedIntent()
      {
        flagHasMaximumPromptRepetitionUnrelatedIntent = false;
      }
    public void setMaximumPromptRepetitionUnknownIntent(BigInteger new_value)
      {
        flagHasMaximumPromptRepetitionUnknownIntent = true;
        if (new_value < 0)
            throw new Exception("The value for field MaximumPromptRepetitionUnknownIntent of RestaurantOrderingQueriesRequestDataJSON is less than the lower bound (0) for that field.");
        storeMaximumPromptRepetitionUnknownIntent = new_value;
      }
    public void unsetMaximumPromptRepetitionUnknownIntent()
      {
        flagHasMaximumPromptRepetitionUnknownIntent = false;
      }

    public virtual void extraRestaurantOrderingQueriesRequestDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantOrderingQueriesRequestDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantOrderingQueriesRequestDataLookup(key);
        if (old_field == null)
          {
            extraRestaurantOrderingQueriesRequestDataAppendPair(key, new_component);
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
        if (flagHasRestaurantName)
          {
            handler.start_pair("RestaurantName");
            handler.string_value(storeRestaurantName);
          }
        Debug.Assert(partial_allowed || flagHasStoreID);
        if (flagHasStoreID)
          {
            handler.start_pair("StoreID");
            handler.string_value(storeStoreID);
          }
        if (flagHasMaximumPromptRepetitionUnrelatedIntent)
          {
            handler.start_pair("MaximumPromptRepetitionUnrelatedIntent");
            handler.number_value(storeMaximumPromptRepetitionUnrelatedIntent);
          }
        if (flagHasMaximumPromptRepetitionUnknownIntent)
          {
            handler.start_pair("MaximumPromptRepetitionUnknownIntent");
            handler.number_value(storeMaximumPromptRepetitionUnknownIntent);
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
        if (!(hasStoreID()))
          {
            return "When parsing the object for %what%, the \"StoreID\" field was missing.";
          }
        return null;
      }

    public static RestaurantOrderingQueriesRequestDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingQueriesRequestDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingQueriesRequestData", ignore_extras);
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
    public static RestaurantOrderingQueriesRequestDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingQueriesRequestDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingQueriesRequestDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingQueriesRequestData", ignore_extras);
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
    public static RestaurantOrderingQueriesRequestDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingQueriesRequestDataJSON from_text(string text, bool ignore_extras)
      {
        RestaurantOrderingQueriesRequestDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingQueriesRequestData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantOrderingQueriesRequestDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantOrderingQueriesRequestDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantOrderingQueriesRequestDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingQueriesRequestData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorRestaurantName;
        private JSONHoldingStringGenerator fieldGeneratorStoreID;
    private class FieldHoldingGeneratorMaximumPromptRepetitionUnrelatedIntent : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMaximumPromptRepetitionUnrelatedIntent(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMaximumPromptRepetitionUnrelatedIntent : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMaximumPromptRepetitionUnrelatedIntent(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorMaximumPromptRepetitionUnrelatedIntent fieldGeneratorMaximumPromptRepetitionUnrelatedIntent;
    private class FieldHoldingGeneratorMaximumPromptRepetitionUnknownIntent : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMaximumPromptRepetitionUnknownIntent(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMaximumPromptRepetitionUnknownIntent : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMaximumPromptRepetitionUnknownIntent(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorMaximumPromptRepetitionUnknownIntent fieldGeneratorMaximumPromptRepetitionUnknownIntent;
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
            RestaurantOrderingQueriesRequestDataJSON result = new RestaurantOrderingQueriesRequestDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantOrderingQueriesRequestDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantOrderingQueriesRequestDataJSON result)
          {
            if (fieldGeneratorRestaurantName.have_value)
              {
                result.setRestaurantName(fieldGeneratorRestaurantName.value);
                fieldGeneratorRestaurantName.have_value = false;
              }
            if (fieldGeneratorStoreID.have_value)
              {
                result.setStoreID(fieldGeneratorStoreID.value);
                fieldGeneratorStoreID.have_value = false;
              }
            else if ((!(result.hasStoreID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StoreID\" field was missing.");
              }
            if (fieldGeneratorMaximumPromptRepetitionUnrelatedIntent.have_value)
              {
                result.setMaximumPromptRepetitionUnrelatedIntent(fieldGeneratorMaximumPromptRepetitionUnrelatedIntent.value);
                fieldGeneratorMaximumPromptRepetitionUnrelatedIntent.have_value = false;
              }
            if (fieldGeneratorMaximumPromptRepetitionUnknownIntent.have_value)
              {
                result.setMaximumPromptRepetitionUnknownIntent(fieldGeneratorMaximumPromptRepetitionUnknownIntent.value);
                fieldGeneratorMaximumPromptRepetitionUnknownIntent.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantOrderingQueriesRequestDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if (String.Compare(field_name, 1, "aximumPromptRepetitionUn", 0, 24, false) == 0)
                      {
                        switch (field_name[25])
                          {
                            case 'k':
                                if ((String.Compare(field_name, 26, "nownIntent", 0, 10, false) == 0) && (field_name.Length == 36))
                                    return fieldGeneratorMaximumPromptRepetitionUnknownIntent;
                                break;
                            case 'r':
                                if ((String.Compare(field_name, 26, "elatedIntent", 0, 12, false) == 0) && (field_name.Length == 38))
                                    return fieldGeneratorMaximumPromptRepetitionUnrelatedIntent;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "estaurantName", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorRestaurantName;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "toreID", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorStoreID;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRestaurantName = new JSONHoldingStringGenerator("field \"RestaurantName\" of the RestaurantOrderingQueriesRequestData class");
            fieldGeneratorStoreID = new JSONHoldingStringGenerator("field \"StoreID\" of the RestaurantOrderingQueriesRequestData class");
            fieldGeneratorMaximumPromptRepetitionUnrelatedIntent = new FieldHoldingGeneratorMaximumPromptRepetitionUnrelatedIntent("field \"MaximumPromptRepetitionUnrelatedIntent\" of the RestaurantOrderingQueriesRequestData class");
            fieldGeneratorMaximumPromptRepetitionUnknownIntent = new FieldHoldingGeneratorMaximumPromptRepetitionUnknownIntent("field \"MaximumPromptRepetitionUnknownIntent\" of the RestaurantOrderingQueriesRequestData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantOrderingQueriesRequestData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRestaurantName = new JSONHoldingStringGenerator("field \"RestaurantName\" of the RestaurantOrderingQueriesRequestData class");
            fieldGeneratorStoreID = new JSONHoldingStringGenerator("field \"StoreID\" of the RestaurantOrderingQueriesRequestData class");
            fieldGeneratorMaximumPromptRepetitionUnrelatedIntent = new FieldHoldingGeneratorMaximumPromptRepetitionUnrelatedIntent("field \"MaximumPromptRepetitionUnrelatedIntent\" of the RestaurantOrderingQueriesRequestData class");
            fieldGeneratorMaximumPromptRepetitionUnknownIntent = new FieldHoldingGeneratorMaximumPromptRepetitionUnknownIntent("field \"MaximumPromptRepetitionUnknownIntent\" of the RestaurantOrderingQueriesRequestData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantOrderingQueriesRequestData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRestaurantName.reset();
            fieldGeneratorStoreID.reset();
            fieldGeneratorMaximumPromptRepetitionUnrelatedIntent.reset();
            fieldGeneratorMaximumPromptRepetitionUnknownIntent.reset();
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
        protected override void handle_result(RestaurantOrderingQueriesRequestDataJSON  result)
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
        public RestaurantOrderingQueriesRequestDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantOrderingQueriesRequestDataJSON  result)
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
    protected virtual void handle_result(List<RestaurantOrderingQueriesRequestDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantOrderingQueriesRequestDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantOrderingQueriesRequestDataJSON>();
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
    public List<RestaurantOrderingQueriesRequestDataJSON> value;
  };
  };
