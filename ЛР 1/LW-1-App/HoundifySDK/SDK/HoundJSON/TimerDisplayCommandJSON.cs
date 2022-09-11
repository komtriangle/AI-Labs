/* file "TimerDisplayCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimerDisplayCommandJSON : TimerCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasTimerCriteria;
        private List< TimerCriteriaJSON  > storeTimerCriteria;
        private bool flagHasIsTimeRemainingQuery;
        private bool storeIsTimeRemainingQuery;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTimerCriteria(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field TimerCriteria of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field TimerCriteria of TypeNativeDataJSON has too few elements.");
            List< TimerCriteriaJSON  > vector_TimerCriteria1 = new List< TimerCriteriaJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TimerCriteriaJSON convert_classy = TimerCriteriaJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_TimerCriteria1.Add(convert_classy);
              }
            Debug.Assert(vector_TimerCriteria1.Count >= 1);
            initTimerCriteria();
            for (int num1 = 0; num1 < vector_TimerCriteria1.Count; ++num1)
                appendTimerCriteria(vector_TimerCriteria1[num1]);
            for (int num1 = 0; num1 < vector_TimerCriteria1.Count; ++num1)
              {
              }
          }


        private void  fromJSONIsTimeRemainingQuery(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field IsTimeRemainingQuery of TypeNativeDataJSON is not true for false.");
                  }
              }
            setIsTimeRemainingQuery(the_bool);
          }


        public TypeNativeDataJSON()
          {
            flagHasTimerCriteria = false;
            flagHasIsTimeRemainingQuery = false;
            storeTimerCriteria = new List< TimerCriteriaJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTimerCriteria()
          {
            return flagHasTimerCriteria;
          }

        public int  countOfTimerCriteria()
          {
            Debug.Assert(flagHasTimerCriteria);
            return storeTimerCriteria.Count;
          }

        public TimerCriteriaJSON   elementOfTimerCriteria(int element_num)
          {
            Debug.Assert(flagHasTimerCriteria);
            return storeTimerCriteria[element_num];
          }

        public List< TimerCriteriaJSON  >  getTimerCriteria()
          {
            Debug.Assert(flagHasTimerCriteria);
            return storeTimerCriteria;
          }

        public bool  hasIsTimeRemainingQuery()
          {
            return flagHasIsTimeRemainingQuery;
          }

        public bool  getIsTimeRemainingQuery()
          {
            Debug.Assert(flagHasIsTimeRemainingQuery);
            return storeIsTimeRemainingQuery;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initTimerCriteria()
          {
            if (flagHasTimerCriteria)
              {
                for (int num1 = 0; num1 < storeTimerCriteria.Count; ++num1)
                  {
                  }
              }
            flagHasTimerCriteria = true;
            storeTimerCriteria.Clear();
          }
        public void appendTimerCriteria(TimerCriteriaJSON  to_append)
          {
            if (!flagHasTimerCriteria)
              {
                flagHasTimerCriteria = true;
                storeTimerCriteria.Clear();
              }
            Debug.Assert(flagHasTimerCriteria);
            storeTimerCriteria.Add(to_append);
          }
        public void unsetTimerCriteria()
          {
            if (flagHasTimerCriteria)
              {
                for (int num2 = 0; num2 < storeTimerCriteria.Count; ++num2)
                  {
                  }
              }
            flagHasTimerCriteria = false;
            storeTimerCriteria.Clear();
          }
        public void setIsTimeRemainingQuery(bool new_value)
          {
            flagHasIsTimeRemainingQuery = true;
            storeIsTimeRemainingQuery = new_value;
          }
        public void unsetIsTimeRemainingQuery()
          {
            flagHasIsTimeRemainingQuery = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            if (flagHasTimerCriteria)
              {
                handler.start_pair("TimerCriteria");
                Debug.Assert(storeTimerCriteria.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeTimerCriteria.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeTimerCriteria[num1].write_partial_as_json(handler);
                    else
                        storeTimerCriteria[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasIsTimeRemainingQuery)
              {
                handler.start_pair("IsTimeRemainingQuery");
                handler.boolean_value(storeIsTimeRemainingQuery);
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

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private TimerCriteriaJSON.HoldingArrayGenerator fieldGeneratorTimerCriteria;
            private JSONHoldingBooleanGenerator fieldGeneratorIsTimeRemainingQuery;
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorTimerCriteria.have_value)
                  {
                    result.initTimerCriteria();
                    int count = fieldGeneratorTimerCriteria.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendTimerCriteria(fieldGeneratorTimerCriteria.value[num]);
                      }
                    fieldGeneratorTimerCriteria.value.Clear();
                    fieldGeneratorTimerCriteria.have_value = false;
                  }
                if (fieldGeneratorIsTimeRemainingQuery.have_value)
                  {
                    result.setIsTimeRemainingQuery(fieldGeneratorIsTimeRemainingQuery.value);
                    fieldGeneratorIsTimeRemainingQuery.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'I':
                        if ((String.Compare(field_name, 1, "sTimeRemainingQuery", 0, 19, false) == 0) && (field_name.Length == 20))
                            return fieldGeneratorIsTimeRemainingQuery;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "imerCriteria", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorTimerCriteria;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTimerCriteria = new TimerCriteriaJSON.HoldingArrayGenerator("field \"TimerCriteria\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorIsTimeRemainingQuery = new JSONHoldingBooleanGenerator("field \"IsTimeRemainingQuery\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTimerCriteria = new TimerCriteriaJSON.HoldingArrayGenerator("field \"TimerCriteria\" of the TypeNativeData class", false);
                fieldGeneratorIsTimeRemainingQuery = new JSONHoldingBooleanGenerator("field \"IsTimeRemainingQuery\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTimerCriteria.reset();
                fieldGeneratorIsTimeRemainingQuery.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorTimerCriteria.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorTimerCriteria.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private bool flagHasFutureSupportDynamicResponse;
    private DynamicResponseJSON  storeFutureSupportDynamicResponse;
    private bool flagHasDisplayAllDynamicResponse;
    private DynamicResponseJSON  storeDisplayAllDynamicResponse;
    private bool flagHasDisplaySingleDynamicResponse;
    private DynamicResponseJSON  storeDisplaySingleDynamicResponse;
    private bool flagHasDisplayMultiDynamicResponse;
    private DynamicResponseJSON  storeDisplayMultiDynamicResponse;
    private bool flagHasDisplayNoMatchDynamicResponse;
    private DynamicResponseJSON  storeDisplayNoMatchDynamicResponse;
    private bool flagHasDisplayPartialMatchDynamicResponse;
    private DynamicResponseJSON  storeDisplayPartialMatchDynamicResponse;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }

    private JSONValue  extraFutureSupportDynamicResponseToJSON()
      {
        JSONValueHandler handler_FutureSupportDynamicResponse = new JSONValueHandler();
        storeFutureSupportDynamicResponse.write_as_json(handler_FutureSupportDynamicResponse);
        return handler_FutureSupportDynamicResponse.result;
      }

    private JSONValue  extraDisplayAllDynamicResponseToJSON()
      {
        JSONValueHandler handler_DisplayAllDynamicResponse = new JSONValueHandler();
        storeDisplayAllDynamicResponse.write_as_json(handler_DisplayAllDynamicResponse);
        return handler_DisplayAllDynamicResponse.result;
      }

    private JSONValue  extraDisplaySingleDynamicResponseToJSON()
      {
        JSONValueHandler handler_DisplaySingleDynamicResponse = new JSONValueHandler();
        storeDisplaySingleDynamicResponse.write_as_json(handler_DisplaySingleDynamicResponse);
        return handler_DisplaySingleDynamicResponse.result;
      }

    private JSONValue  extraDisplayMultiDynamicResponseToJSON()
      {
        JSONValueHandler handler_DisplayMultiDynamicResponse = new JSONValueHandler();
        storeDisplayMultiDynamicResponse.write_as_json(handler_DisplayMultiDynamicResponse);
        return handler_DisplayMultiDynamicResponse.result;
      }

    private JSONValue  extraDisplayNoMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_DisplayNoMatchDynamicResponse = new JSONValueHandler();
        storeDisplayNoMatchDynamicResponse.write_as_json(handler_DisplayNoMatchDynamicResponse);
        return handler_DisplayNoMatchDynamicResponse.result;
      }

    private JSONValue  extraDisplayPartialMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_DisplayPartialMatchDynamicResponse = new JSONValueHandler();
        storeDisplayPartialMatchDynamicResponse.write_as_json(handler_DisplayPartialMatchDynamicResponse);
        return handler_DisplayPartialMatchDynamicResponse.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    private void  fromJSONFutureSupportDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setFutureSupportDynamicResponse(convert_classy);
      }


    private void  fromJSONDisplayAllDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDisplayAllDynamicResponse(convert_classy);
      }


    private void  fromJSONDisplaySingleDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDisplaySingleDynamicResponse(convert_classy);
      }


    private void  fromJSONDisplayMultiDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDisplayMultiDynamicResponse(convert_classy);
      }


    private void  fromJSONDisplayNoMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDisplayNoMatchDynamicResponse(convert_classy);
      }


    private void  fromJSONDisplayPartialMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDisplayPartialMatchDynamicResponse(convert_classy);
      }


    public TimerDisplayCommandJSON()
      {
        flagHasNativeData = false;
        flagHasFutureSupportDynamicResponse = false;
        flagHasDisplayAllDynamicResponse = false;
        flagHasDisplaySingleDynamicResponse = false;
        flagHasDisplayMultiDynamicResponse = false;
        flagHasDisplayNoMatchDynamicResponse = false;
        flagHasDisplayPartialMatchDynamicResponse = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTimerCommandKind()
      {
        return "TimerDisplayCommand";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }

    public bool  hasFutureSupportDynamicResponse()
      {
        return flagHasFutureSupportDynamicResponse;
      }

    public DynamicResponseJSON   getFutureSupportDynamicResponse()
      {
        Debug.Assert(flagHasFutureSupportDynamicResponse);
        return storeFutureSupportDynamicResponse;
      }

    public bool  hasDisplayAllDynamicResponse()
      {
        return flagHasDisplayAllDynamicResponse;
      }

    public DynamicResponseJSON   getDisplayAllDynamicResponse()
      {
        Debug.Assert(flagHasDisplayAllDynamicResponse);
        return storeDisplayAllDynamicResponse;
      }

    public bool  hasDisplaySingleDynamicResponse()
      {
        return flagHasDisplaySingleDynamicResponse;
      }

    public DynamicResponseJSON   getDisplaySingleDynamicResponse()
      {
        Debug.Assert(flagHasDisplaySingleDynamicResponse);
        return storeDisplaySingleDynamicResponse;
      }

    public bool  hasDisplayMultiDynamicResponse()
      {
        return flagHasDisplayMultiDynamicResponse;
      }

    public DynamicResponseJSON   getDisplayMultiDynamicResponse()
      {
        Debug.Assert(flagHasDisplayMultiDynamicResponse);
        return storeDisplayMultiDynamicResponse;
      }

    public bool  hasDisplayNoMatchDynamicResponse()
      {
        return flagHasDisplayNoMatchDynamicResponse;
      }

    public DynamicResponseJSON   getDisplayNoMatchDynamicResponse()
      {
        Debug.Assert(flagHasDisplayNoMatchDynamicResponse);
        return storeDisplayNoMatchDynamicResponse;
      }

    public bool  hasDisplayPartialMatchDynamicResponse()
      {
        return flagHasDisplayPartialMatchDynamicResponse;
      }

    public DynamicResponseJSON   getDisplayPartialMatchDynamicResponse()
      {
        Debug.Assert(flagHasDisplayPartialMatchDynamicResponse);
        return storeDisplayPartialMatchDynamicResponse;
      }


    public virtual int extraTimerDisplayCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimerDisplayCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimerDisplayCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimerDisplayCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTimerCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        if (flagHasFutureSupportDynamicResponse)
            ++result;
        if (flagHasDisplayAllDynamicResponse)
            ++result;
        if (flagHasDisplaySingleDynamicResponse)
            ++result;
        if (flagHasDisplayMultiDynamicResponse)
            ++result;
        if (flagHasDisplayNoMatchDynamicResponse)
            ++result;
        if (flagHasDisplayPartialMatchDynamicResponse)
            ++result;
        result += extraTimerDisplayCommandComponentCount();
        return result;
      }
    public override string extraTimerCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            if (remainder == 0)
                return "FutureSupportDynamicResponse";
            --remainder;
          }
        if (flagHasDisplayAllDynamicResponse)
          {
            if (remainder == 0)
                return "DisplayAllDynamicResponse";
            --remainder;
          }
        if (flagHasDisplaySingleDynamicResponse)
          {
            if (remainder == 0)
                return "DisplaySingleDynamicResponse";
            --remainder;
          }
        if (flagHasDisplayMultiDynamicResponse)
          {
            if (remainder == 0)
                return "DisplayMultiDynamicResponse";
            --remainder;
          }
        if (flagHasDisplayNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return "DisplayNoMatchDynamicResponse";
            --remainder;
          }
        if (flagHasDisplayPartialMatchDynamicResponse)
          {
            if (remainder == 0)
                return "DisplayPartialMatchDynamicResponse";
            --remainder;
          }
        return extraTimerDisplayCommandComponentKey(remainder);
      }
    public override JSONValue extraTimerCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            if (remainder == 0)
                return extraFutureSupportDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasDisplayAllDynamicResponse)
          {
            if (remainder == 0)
                return extraDisplayAllDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasDisplaySingleDynamicResponse)
          {
            if (remainder == 0)
                return extraDisplaySingleDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasDisplayMultiDynamicResponse)
          {
            if (remainder == 0)
                return extraDisplayMultiDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasDisplayNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraDisplayNoMatchDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasDisplayPartialMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraDisplayPartialMatchDynamicResponseToJSON();
            --remainder;
          }
        return extraTimerDisplayCommandComponentValue(remainder);
      }
    public override JSONValue extraTimerCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if (String.Compare(field_name, 1, "isplay", 0, 6, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 8, "llDynamicResponse", 0, 17, false) == 0) && (field_name.Length == 25))
                                return (flagHasDisplayAllDynamicResponse ? extraDisplayAllDynamicResponseToJSON() : null);
                            break;
                        case 'M':
                            if ((String.Compare(field_name, 8, "ultiDynamicResponse", 0, 19, false) == 0) && (field_name.Length == 27))
                                return (flagHasDisplayMultiDynamicResponse ? extraDisplayMultiDynamicResponseToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 8, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 29))
                                return (flagHasDisplayNoMatchDynamicResponse ? extraDisplayNoMatchDynamicResponseToJSON() : null);
                            break;
                        case 'P':
                            if ((String.Compare(field_name, 8, "artialMatchDynamicResponse", 0, 26, false) == 0) && (field_name.Length == 34))
                                return (flagHasDisplayPartialMatchDynamicResponse ? extraDisplayPartialMatchDynamicResponseToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 8, "ingleDynamicResponse", 0, 20, false) == 0) && (field_name.Length == 28))
                                return (flagHasDisplaySingleDynamicResponse ? extraDisplaySingleDynamicResponseToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "utureSupportDynamicResponse", 0, 27, false) == 0) && (field_name.Length == 28))
                    return (flagHasFutureSupportDynamicResponse ? extraFutureSupportDynamicResponseToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNativeData ? extraNativeDataToJSON() : null);
                break;
            default:
                break;
          }
        return extraTimerDisplayCommandLookup(field_name);
      }

    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }
    public void setFutureSupportDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasFutureSupportDynamicResponse)
          {
          }
        flagHasFutureSupportDynamicResponse = true;
        storeFutureSupportDynamicResponse = new_value;
      }
    public void unsetFutureSupportDynamicResponse()
      {
        if (flagHasFutureSupportDynamicResponse)
          {
          }
        flagHasFutureSupportDynamicResponse = false;
      }
    public void setDisplayAllDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDisplayAllDynamicResponse)
          {
          }
        flagHasDisplayAllDynamicResponse = true;
        storeDisplayAllDynamicResponse = new_value;
      }
    public void unsetDisplayAllDynamicResponse()
      {
        if (flagHasDisplayAllDynamicResponse)
          {
          }
        flagHasDisplayAllDynamicResponse = false;
      }
    public void setDisplaySingleDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDisplaySingleDynamicResponse)
          {
          }
        flagHasDisplaySingleDynamicResponse = true;
        storeDisplaySingleDynamicResponse = new_value;
      }
    public void unsetDisplaySingleDynamicResponse()
      {
        if (flagHasDisplaySingleDynamicResponse)
          {
          }
        flagHasDisplaySingleDynamicResponse = false;
      }
    public void setDisplayMultiDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDisplayMultiDynamicResponse)
          {
          }
        flagHasDisplayMultiDynamicResponse = true;
        storeDisplayMultiDynamicResponse = new_value;
      }
    public void unsetDisplayMultiDynamicResponse()
      {
        if (flagHasDisplayMultiDynamicResponse)
          {
          }
        flagHasDisplayMultiDynamicResponse = false;
      }
    public void setDisplayNoMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDisplayNoMatchDynamicResponse)
          {
          }
        flagHasDisplayNoMatchDynamicResponse = true;
        storeDisplayNoMatchDynamicResponse = new_value;
      }
    public void unsetDisplayNoMatchDynamicResponse()
      {
        if (flagHasDisplayNoMatchDynamicResponse)
          {
          }
        flagHasDisplayNoMatchDynamicResponse = false;
      }
    public void setDisplayPartialMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDisplayPartialMatchDynamicResponse)
          {
          }
        flagHasDisplayPartialMatchDynamicResponse = true;
        storeDisplayPartialMatchDynamicResponse = new_value;
      }
    public void unsetDisplayPartialMatchDynamicResponse()
      {
        if (flagHasDisplayPartialMatchDynamicResponse)
          {
          }
        flagHasDisplayPartialMatchDynamicResponse = false;
      }

    public virtual void extraTimerDisplayCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimerDisplayCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimerDisplayCommandLookup(key);
        if (old_field == null)
          {
            extraTimerDisplayCommandAppendPair(key, new_component);
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
    public override void extraTimerCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if (String.Compare(key, 1, "isplay", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'A':
                            if ((String.Compare(key, 8, "llDynamicResponse", 0, 17, false) == 0) && (key.Length == 25))
                                {
                                fromJSONDisplayAllDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 8, "ultiDynamicResponse", 0, 19, false) == 0) && (key.Length == 27))
                                {
                                fromJSONDisplayMultiDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 8, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 29))
                                {
                                fromJSONDisplayNoMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 8, "artialMatchDynamicResponse", 0, 26, false) == 0) && (key.Length == 34))
                                {
                                fromJSONDisplayPartialMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 8, "ingleDynamicResponse", 0, 20, false) == 0) && (key.Length == 28))
                                {
                                fromJSONDisplaySingleDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(key, 1, "utureSupportDynamicResponse", 0, 27, false) == 0) && (key.Length == 28))
                    {
                    fromJSONFutureSupportDynamicResponse(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraTimerDisplayCommandAppendPair(key, new_component);
      }
    public override void extraTimerCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if (String.Compare(key, 1, "isplay", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'A':
                            if ((String.Compare(key, 8, "llDynamicResponse", 0, 17, false) == 0) && (key.Length == 25))
                                {
                                fromJSONDisplayAllDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 8, "ultiDynamicResponse", 0, 19, false) == 0) && (key.Length == 27))
                                {
                                fromJSONDisplayMultiDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 8, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 29))
                                {
                                fromJSONDisplayNoMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 8, "artialMatchDynamicResponse", 0, 26, false) == 0) && (key.Length == 34))
                                {
                                fromJSONDisplayPartialMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 8, "ingleDynamicResponse", 0, 20, false) == 0) && (key.Length == 28))
                                {
                                fromJSONDisplaySingleDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(key, 1, "utureSupportDynamicResponse", 0, 27, false) == 0) && (key.Length == 28))
                    {
                    fromJSONFutureSupportDynamicResponse(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraTimerDisplayCommandSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            handler.start_pair("FutureSupportDynamicResponse");
            if (partial_allowed)
                storeFutureSupportDynamicResponse.write_partial_as_json(handler);
            else
                storeFutureSupportDynamicResponse.write_as_json(handler);
          }
        if (flagHasDisplayAllDynamicResponse)
          {
            handler.start_pair("DisplayAllDynamicResponse");
            if (partial_allowed)
                storeDisplayAllDynamicResponse.write_partial_as_json(handler);
            else
                storeDisplayAllDynamicResponse.write_as_json(handler);
          }
        if (flagHasDisplaySingleDynamicResponse)
          {
            handler.start_pair("DisplaySingleDynamicResponse");
            if (partial_allowed)
                storeDisplaySingleDynamicResponse.write_partial_as_json(handler);
            else
                storeDisplaySingleDynamicResponse.write_as_json(handler);
          }
        if (flagHasDisplayMultiDynamicResponse)
          {
            handler.start_pair("DisplayMultiDynamicResponse");
            if (partial_allowed)
                storeDisplayMultiDynamicResponse.write_partial_as_json(handler);
            else
                storeDisplayMultiDynamicResponse.write_as_json(handler);
          }
        if (flagHasDisplayNoMatchDynamicResponse)
          {
            handler.start_pair("DisplayNoMatchDynamicResponse");
            if (partial_allowed)
                storeDisplayNoMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeDisplayNoMatchDynamicResponse.write_as_json(handler);
          }
        if (flagHasDisplayPartialMatchDynamicResponse)
          {
            handler.start_pair("DisplayPartialMatchDynamicResponse");
            if (partial_allowed)
                storeDisplayPartialMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeDisplayPartialMatchDynamicResponse.write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new TimerDisplayCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerDisplayCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerDisplayCommand", ignore_extras);
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
    public static new TimerDisplayCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimerDisplayCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerDisplayCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerDisplayCommand", ignore_extras);
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
    public static new TimerDisplayCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimerDisplayCommandJSON from_text(string text, bool ignore_extras)
      {
        TimerDisplayCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerDisplayCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimerDisplayCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TimerDisplayCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimerDisplayCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerDisplayCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TimerCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorFutureSupportDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDisplayAllDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDisplaySingleDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDisplayMultiDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDisplayNoMatchDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDisplayPartialMatchDynamicResponse;
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
            if (!(getTimerCommandJSONKey().Equals("TimerDisplayCommand")))
                throw new Exception("The key field has a value other than `TimerDisplayCommand'.");
            TimerDisplayCommandJSON result = new TimerDisplayCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimerDisplayCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TimerCommandJSON new_result)
          {
            handle_result((TimerDisplayCommandJSON )new_result);
          }
        protected void finish(TimerDisplayCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            if (fieldGeneratorFutureSupportDynamicResponse.have_value)
              {
                result.setFutureSupportDynamicResponse(fieldGeneratorFutureSupportDynamicResponse.value);
                fieldGeneratorFutureSupportDynamicResponse.have_value = false;
              }
            if (fieldGeneratorDisplayAllDynamicResponse.have_value)
              {
                result.setDisplayAllDynamicResponse(fieldGeneratorDisplayAllDynamicResponse.value);
                fieldGeneratorDisplayAllDynamicResponse.have_value = false;
              }
            if (fieldGeneratorDisplaySingleDynamicResponse.have_value)
              {
                result.setDisplaySingleDynamicResponse(fieldGeneratorDisplaySingleDynamicResponse.value);
                fieldGeneratorDisplaySingleDynamicResponse.have_value = false;
              }
            if (fieldGeneratorDisplayMultiDynamicResponse.have_value)
              {
                result.setDisplayMultiDynamicResponse(fieldGeneratorDisplayMultiDynamicResponse.value);
                fieldGeneratorDisplayMultiDynamicResponse.have_value = false;
              }
            if (fieldGeneratorDisplayNoMatchDynamicResponse.have_value)
              {
                result.setDisplayNoMatchDynamicResponse(fieldGeneratorDisplayNoMatchDynamicResponse.value);
                fieldGeneratorDisplayNoMatchDynamicResponse.have_value = false;
              }
            if (fieldGeneratorDisplayPartialMatchDynamicResponse.have_value)
              {
                result.setDisplayPartialMatchDynamicResponse(fieldGeneratorDisplayPartialMatchDynamicResponse.value);
                fieldGeneratorDisplayPartialMatchDynamicResponse.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(TimerDisplayCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "isplay", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 8, "llDynamicResponse", 0, 17, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorDisplayAllDynamicResponse;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 8, "ultiDynamicResponse", 0, 19, false) == 0) && (field_name.Length == 27))
                                    return fieldGeneratorDisplayMultiDynamicResponse;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 29))
                                    return fieldGeneratorDisplayNoMatchDynamicResponse;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 8, "artialMatchDynamicResponse", 0, 26, false) == 0) && (field_name.Length == 34))
                                    return fieldGeneratorDisplayPartialMatchDynamicResponse;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 8, "ingleDynamicResponse", 0, 20, false) == 0) && (field_name.Length == 28))
                                    return fieldGeneratorDisplaySingleDynamicResponse;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "utureSupportDynamicResponse", 0, 27, false) == 0) && (field_name.Length == 28))
                        return fieldGeneratorFutureSupportDynamicResponse;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNativeData;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the TimerDisplayCommand class", ignore_extras);
            fieldGeneratorFutureSupportDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"FutureSupportDynamicResponse\" of the TimerDisplayCommand class", ignore_extras);
            fieldGeneratorDisplayAllDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DisplayAllDynamicResponse\" of the TimerDisplayCommand class", ignore_extras);
            fieldGeneratorDisplaySingleDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DisplaySingleDynamicResponse\" of the TimerDisplayCommand class", ignore_extras);
            fieldGeneratorDisplayMultiDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DisplayMultiDynamicResponse\" of the TimerDisplayCommand class", ignore_extras);
            fieldGeneratorDisplayNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DisplayNoMatchDynamicResponse\" of the TimerDisplayCommand class", ignore_extras);
            fieldGeneratorDisplayPartialMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DisplayPartialMatchDynamicResponse\" of the TimerDisplayCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimerDisplayCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the TimerDisplayCommand class", false);
            fieldGeneratorFutureSupportDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"FutureSupportDynamicResponse\" of the TimerDisplayCommand class", false);
            fieldGeneratorDisplayAllDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DisplayAllDynamicResponse\" of the TimerDisplayCommand class", false);
            fieldGeneratorDisplaySingleDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DisplaySingleDynamicResponse\" of the TimerDisplayCommand class", false);
            fieldGeneratorDisplayMultiDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DisplayMultiDynamicResponse\" of the TimerDisplayCommand class", false);
            fieldGeneratorDisplayNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DisplayNoMatchDynamicResponse\" of the TimerDisplayCommand class", false);
            fieldGeneratorDisplayPartialMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DisplayPartialMatchDynamicResponse\" of the TimerDisplayCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimerDisplayCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            fieldGeneratorFutureSupportDynamicResponse.reset();
            fieldGeneratorDisplayAllDynamicResponse.reset();
            fieldGeneratorDisplaySingleDynamicResponse.reset();
            fieldGeneratorDisplayMultiDynamicResponse.reset();
            fieldGeneratorDisplayNoMatchDynamicResponse.reset();
            fieldGeneratorDisplayPartialMatchDynamicResponse.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TimerDisplayCommandJSON  result)
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
        public TimerDisplayCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimerDisplayCommandJSON  result)
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
    protected virtual void handle_result(List<TimerDisplayCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimerDisplayCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimerDisplayCommandJSON>();
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
    public List<TimerDisplayCommandJSON> value;
  };
  };
