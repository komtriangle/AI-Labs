/* file "TimerAddTimeCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimerAddTimeCommandJSON : TimerCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasTimerCriteria;
        private List< TimerCriteriaJSON  > storeTimerCriteria;
        private bool flagHasTimer;
        private TimerJSON  storeTimer;
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


        private void  fromJSONTimer(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TimerJSON convert_classy = TimerJSON.from_json(json_value, ignore_extras, true);
            setTimer(convert_classy);
          }


        public TypeNativeDataJSON()
          {
            flagHasTimerCriteria = false;
            flagHasTimer = false;
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

        public bool  hasTimer()
          {
            return flagHasTimer;
          }

        public TimerJSON   getTimer()
          {
            Debug.Assert(flagHasTimer);
            return storeTimer;
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
        public void setTimer(TimerJSON  new_value)
          {
            if (flagHasTimer)
              {
              }
            flagHasTimer = true;
            storeTimer = new_value;
          }
        public void unsetTimer()
          {
            if (flagHasTimer)
              {
              }
            flagHasTimer = false;
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
            Debug.Assert(partial_allowed || flagHasTimer);
            if (flagHasTimer)
              {
                handler.start_pair("Timer");
                if (partial_allowed)
                    storeTimer.write_partial_as_json(handler);
                else
                    storeTimer.write_as_json(handler);
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
            if (!(hasTimer()))
              {
                return "When parsing the object for %what%, the \"Timer\" field was missing.";
              }
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
            private TimerJSON.HoldingGenerator fieldGeneratorTimer;
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
                if (fieldGeneratorTimer.have_value)
                  {
                    result.setTimer(fieldGeneratorTimer.value);
                    fieldGeneratorTimer.have_value = false;
                  }
                else if ((!(result.hasTimer())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Timer\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "Timer", 0, 5, false) == 0)
                  {
                    if (field_name.Length == 5)
                      {
                        return fieldGeneratorTimer;
                      }
                    switch (field_name[5])
                      {
                        case 'C':
                            if ((String.Compare(field_name, 6, "riteria", 0, 7, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorTimerCriteria;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTimerCriteria = new TimerCriteriaJSON.HoldingArrayGenerator("field \"TimerCriteria\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorTimer = new TimerJSON.HoldingGenerator("field \"Timer\" of the TypeNativeData class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTimerCriteria = new TimerCriteriaJSON.HoldingArrayGenerator("field \"TimerCriteria\" of the TypeNativeData class", false);
                fieldGeneratorTimer = new TimerJSON.HoldingGenerator("field \"Timer\" of the TypeNativeData class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTimerCriteria.reset();
                fieldGeneratorTimer.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorTimerCriteria.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTimer.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorTimerCriteria.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTimer.set_allow_unpolished(new_allow_unpolished);
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
    private bool flagHasAddTimeAllDynamicResponse;
    private DynamicResponseJSON  storeAddTimeAllDynamicResponse;
    private bool flagHasAddTimeSingleDynamicResponse;
    private DynamicResponseJSON  storeAddTimeSingleDynamicResponse;
    private bool flagHasAddTimeMultiDynamicResponse;
    private DynamicResponseJSON  storeAddTimeMultiDynamicResponse;
    private bool flagHasAddTimeNoMatchDynamicResponse;
    private DynamicResponseJSON  storeAddTimeNoMatchDynamicResponse;
    private bool flagHasAddTimePartialMatchDynamicResponse;
    private DynamicResponseJSON  storeAddTimePartialMatchDynamicResponse;
    private bool flagHasFutureSupportDynamicResponse;
    private DynamicResponseJSON  storeFutureSupportDynamicResponse;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }

    private JSONValue  extraAddTimeAllDynamicResponseToJSON()
      {
        JSONValueHandler handler_AddTimeAllDynamicResponse = new JSONValueHandler();
        storeAddTimeAllDynamicResponse.write_as_json(handler_AddTimeAllDynamicResponse);
        return handler_AddTimeAllDynamicResponse.result;
      }

    private JSONValue  extraAddTimeSingleDynamicResponseToJSON()
      {
        JSONValueHandler handler_AddTimeSingleDynamicResponse = new JSONValueHandler();
        storeAddTimeSingleDynamicResponse.write_as_json(handler_AddTimeSingleDynamicResponse);
        return handler_AddTimeSingleDynamicResponse.result;
      }

    private JSONValue  extraAddTimeMultiDynamicResponseToJSON()
      {
        JSONValueHandler handler_AddTimeMultiDynamicResponse = new JSONValueHandler();
        storeAddTimeMultiDynamicResponse.write_as_json(handler_AddTimeMultiDynamicResponse);
        return handler_AddTimeMultiDynamicResponse.result;
      }

    private JSONValue  extraAddTimeNoMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_AddTimeNoMatchDynamicResponse = new JSONValueHandler();
        storeAddTimeNoMatchDynamicResponse.write_as_json(handler_AddTimeNoMatchDynamicResponse);
        return handler_AddTimeNoMatchDynamicResponse.result;
      }

    private JSONValue  extraAddTimePartialMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_AddTimePartialMatchDynamicResponse = new JSONValueHandler();
        storeAddTimePartialMatchDynamicResponse.write_as_json(handler_AddTimePartialMatchDynamicResponse);
        return handler_AddTimePartialMatchDynamicResponse.result;
      }

    private JSONValue  extraFutureSupportDynamicResponseToJSON()
      {
        JSONValueHandler handler_FutureSupportDynamicResponse = new JSONValueHandler();
        storeFutureSupportDynamicResponse.write_as_json(handler_FutureSupportDynamicResponse);
        return handler_FutureSupportDynamicResponse.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    private void  fromJSONAddTimeAllDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAddTimeAllDynamicResponse(convert_classy);
      }


    private void  fromJSONAddTimeSingleDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAddTimeSingleDynamicResponse(convert_classy);
      }


    private void  fromJSONAddTimeMultiDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAddTimeMultiDynamicResponse(convert_classy);
      }


    private void  fromJSONAddTimeNoMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAddTimeNoMatchDynamicResponse(convert_classy);
      }


    private void  fromJSONAddTimePartialMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAddTimePartialMatchDynamicResponse(convert_classy);
      }


    private void  fromJSONFutureSupportDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setFutureSupportDynamicResponse(convert_classy);
      }


    public TimerAddTimeCommandJSON()
      {
        flagHasNativeData = false;
        flagHasAddTimeAllDynamicResponse = false;
        flagHasAddTimeSingleDynamicResponse = false;
        flagHasAddTimeMultiDynamicResponse = false;
        flagHasAddTimeNoMatchDynamicResponse = false;
        flagHasAddTimePartialMatchDynamicResponse = false;
        flagHasFutureSupportDynamicResponse = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTimerCommandKind()
      {
        return "TimerAddTimeCommand";
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

    public bool  hasAddTimeAllDynamicResponse()
      {
        return flagHasAddTimeAllDynamicResponse;
      }

    public DynamicResponseJSON   getAddTimeAllDynamicResponse()
      {
        Debug.Assert(flagHasAddTimeAllDynamicResponse);
        return storeAddTimeAllDynamicResponse;
      }

    public bool  hasAddTimeSingleDynamicResponse()
      {
        return flagHasAddTimeSingleDynamicResponse;
      }

    public DynamicResponseJSON   getAddTimeSingleDynamicResponse()
      {
        Debug.Assert(flagHasAddTimeSingleDynamicResponse);
        return storeAddTimeSingleDynamicResponse;
      }

    public bool  hasAddTimeMultiDynamicResponse()
      {
        return flagHasAddTimeMultiDynamicResponse;
      }

    public DynamicResponseJSON   getAddTimeMultiDynamicResponse()
      {
        Debug.Assert(flagHasAddTimeMultiDynamicResponse);
        return storeAddTimeMultiDynamicResponse;
      }

    public bool  hasAddTimeNoMatchDynamicResponse()
      {
        return flagHasAddTimeNoMatchDynamicResponse;
      }

    public DynamicResponseJSON   getAddTimeNoMatchDynamicResponse()
      {
        Debug.Assert(flagHasAddTimeNoMatchDynamicResponse);
        return storeAddTimeNoMatchDynamicResponse;
      }

    public bool  hasAddTimePartialMatchDynamicResponse()
      {
        return flagHasAddTimePartialMatchDynamicResponse;
      }

    public DynamicResponseJSON   getAddTimePartialMatchDynamicResponse()
      {
        Debug.Assert(flagHasAddTimePartialMatchDynamicResponse);
        return storeAddTimePartialMatchDynamicResponse;
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


    public virtual int extraTimerAddTimeCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimerAddTimeCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimerAddTimeCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimerAddTimeCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTimerCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        if (flagHasAddTimeAllDynamicResponse)
            ++result;
        if (flagHasAddTimeSingleDynamicResponse)
            ++result;
        if (flagHasAddTimeMultiDynamicResponse)
            ++result;
        if (flagHasAddTimeNoMatchDynamicResponse)
            ++result;
        if (flagHasAddTimePartialMatchDynamicResponse)
            ++result;
        if (flagHasFutureSupportDynamicResponse)
            ++result;
        result += extraTimerAddTimeCommandComponentCount();
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
        if (flagHasAddTimeAllDynamicResponse)
          {
            if (remainder == 0)
                return "AddTimeAllDynamicResponse";
            --remainder;
          }
        if (flagHasAddTimeSingleDynamicResponse)
          {
            if (remainder == 0)
                return "AddTimeSingleDynamicResponse";
            --remainder;
          }
        if (flagHasAddTimeMultiDynamicResponse)
          {
            if (remainder == 0)
                return "AddTimeMultiDynamicResponse";
            --remainder;
          }
        if (flagHasAddTimeNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return "AddTimeNoMatchDynamicResponse";
            --remainder;
          }
        if (flagHasAddTimePartialMatchDynamicResponse)
          {
            if (remainder == 0)
                return "AddTimePartialMatchDynamicResponse";
            --remainder;
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            if (remainder == 0)
                return "FutureSupportDynamicResponse";
            --remainder;
          }
        return extraTimerAddTimeCommandComponentKey(remainder);
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
        if (flagHasAddTimeAllDynamicResponse)
          {
            if (remainder == 0)
                return extraAddTimeAllDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasAddTimeSingleDynamicResponse)
          {
            if (remainder == 0)
                return extraAddTimeSingleDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasAddTimeMultiDynamicResponse)
          {
            if (remainder == 0)
                return extraAddTimeMultiDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasAddTimeNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraAddTimeNoMatchDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasAddTimePartialMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraAddTimePartialMatchDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            if (remainder == 0)
                return extraFutureSupportDynamicResponseToJSON();
            --remainder;
          }
        return extraTimerAddTimeCommandComponentValue(remainder);
      }
    public override JSONValue extraTimerCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if (String.Compare(field_name, 1, "ddTime", 0, 6, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 8, "llDynamicResponse", 0, 17, false) == 0) && (field_name.Length == 25))
                                return (flagHasAddTimeAllDynamicResponse ? extraAddTimeAllDynamicResponseToJSON() : null);
                            break;
                        case 'M':
                            if ((String.Compare(field_name, 8, "ultiDynamicResponse", 0, 19, false) == 0) && (field_name.Length == 27))
                                return (flagHasAddTimeMultiDynamicResponse ? extraAddTimeMultiDynamicResponseToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 8, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 29))
                                return (flagHasAddTimeNoMatchDynamicResponse ? extraAddTimeNoMatchDynamicResponseToJSON() : null);
                            break;
                        case 'P':
                            if ((String.Compare(field_name, 8, "artialMatchDynamicResponse", 0, 26, false) == 0) && (field_name.Length == 34))
                                return (flagHasAddTimePartialMatchDynamicResponse ? extraAddTimePartialMatchDynamicResponseToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 8, "ingleDynamicResponse", 0, 20, false) == 0) && (field_name.Length == 28))
                                return (flagHasAddTimeSingleDynamicResponse ? extraAddTimeSingleDynamicResponseToJSON() : null);
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
        return extraTimerAddTimeCommandLookup(field_name);
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
    public void setAddTimeAllDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasAddTimeAllDynamicResponse)
          {
          }
        flagHasAddTimeAllDynamicResponse = true;
        storeAddTimeAllDynamicResponse = new_value;
      }
    public void unsetAddTimeAllDynamicResponse()
      {
        if (flagHasAddTimeAllDynamicResponse)
          {
          }
        flagHasAddTimeAllDynamicResponse = false;
      }
    public void setAddTimeSingleDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasAddTimeSingleDynamicResponse)
          {
          }
        flagHasAddTimeSingleDynamicResponse = true;
        storeAddTimeSingleDynamicResponse = new_value;
      }
    public void unsetAddTimeSingleDynamicResponse()
      {
        if (flagHasAddTimeSingleDynamicResponse)
          {
          }
        flagHasAddTimeSingleDynamicResponse = false;
      }
    public void setAddTimeMultiDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasAddTimeMultiDynamicResponse)
          {
          }
        flagHasAddTimeMultiDynamicResponse = true;
        storeAddTimeMultiDynamicResponse = new_value;
      }
    public void unsetAddTimeMultiDynamicResponse()
      {
        if (flagHasAddTimeMultiDynamicResponse)
          {
          }
        flagHasAddTimeMultiDynamicResponse = false;
      }
    public void setAddTimeNoMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasAddTimeNoMatchDynamicResponse)
          {
          }
        flagHasAddTimeNoMatchDynamicResponse = true;
        storeAddTimeNoMatchDynamicResponse = new_value;
      }
    public void unsetAddTimeNoMatchDynamicResponse()
      {
        if (flagHasAddTimeNoMatchDynamicResponse)
          {
          }
        flagHasAddTimeNoMatchDynamicResponse = false;
      }
    public void setAddTimePartialMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasAddTimePartialMatchDynamicResponse)
          {
          }
        flagHasAddTimePartialMatchDynamicResponse = true;
        storeAddTimePartialMatchDynamicResponse = new_value;
      }
    public void unsetAddTimePartialMatchDynamicResponse()
      {
        if (flagHasAddTimePartialMatchDynamicResponse)
          {
          }
        flagHasAddTimePartialMatchDynamicResponse = false;
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

    public virtual void extraTimerAddTimeCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimerAddTimeCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimerAddTimeCommandLookup(key);
        if (old_field == null)
          {
            extraTimerAddTimeCommandAppendPair(key, new_component);
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
            case 'A':
                if (String.Compare(key, 1, "ddTime", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'A':
                            if ((String.Compare(key, 8, "llDynamicResponse", 0, 17, false) == 0) && (key.Length == 25))
                                {
                                fromJSONAddTimeAllDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 8, "ultiDynamicResponse", 0, 19, false) == 0) && (key.Length == 27))
                                {
                                fromJSONAddTimeMultiDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 8, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 29))
                                {
                                fromJSONAddTimeNoMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 8, "artialMatchDynamicResponse", 0, 26, false) == 0) && (key.Length == 34))
                                {
                                fromJSONAddTimePartialMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 8, "ingleDynamicResponse", 0, 20, false) == 0) && (key.Length == 28))
                                {
                                fromJSONAddTimeSingleDynamicResponse(new_component, false);
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
        extraTimerAddTimeCommandAppendPair(key, new_component);
      }
    public override void extraTimerCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if (String.Compare(key, 1, "ddTime", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'A':
                            if ((String.Compare(key, 8, "llDynamicResponse", 0, 17, false) == 0) && (key.Length == 25))
                                {
                                fromJSONAddTimeAllDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 8, "ultiDynamicResponse", 0, 19, false) == 0) && (key.Length == 27))
                                {
                                fromJSONAddTimeMultiDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 8, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 29))
                                {
                                fromJSONAddTimeNoMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 8, "artialMatchDynamicResponse", 0, 26, false) == 0) && (key.Length == 34))
                                {
                                fromJSONAddTimePartialMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 8, "ingleDynamicResponse", 0, 20, false) == 0) && (key.Length == 28))
                                {
                                fromJSONAddTimeSingleDynamicResponse(new_component, false);
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
        extraTimerAddTimeCommandSetField(key, new_component);
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
        if (flagHasAddTimeAllDynamicResponse)
          {
            handler.start_pair("AddTimeAllDynamicResponse");
            if (partial_allowed)
                storeAddTimeAllDynamicResponse.write_partial_as_json(handler);
            else
                storeAddTimeAllDynamicResponse.write_as_json(handler);
          }
        if (flagHasAddTimeSingleDynamicResponse)
          {
            handler.start_pair("AddTimeSingleDynamicResponse");
            if (partial_allowed)
                storeAddTimeSingleDynamicResponse.write_partial_as_json(handler);
            else
                storeAddTimeSingleDynamicResponse.write_as_json(handler);
          }
        if (flagHasAddTimeMultiDynamicResponse)
          {
            handler.start_pair("AddTimeMultiDynamicResponse");
            if (partial_allowed)
                storeAddTimeMultiDynamicResponse.write_partial_as_json(handler);
            else
                storeAddTimeMultiDynamicResponse.write_as_json(handler);
          }
        if (flagHasAddTimeNoMatchDynamicResponse)
          {
            handler.start_pair("AddTimeNoMatchDynamicResponse");
            if (partial_allowed)
                storeAddTimeNoMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeAddTimeNoMatchDynamicResponse.write_as_json(handler);
          }
        if (flagHasAddTimePartialMatchDynamicResponse)
          {
            handler.start_pair("AddTimePartialMatchDynamicResponse");
            if (partial_allowed)
                storeAddTimePartialMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeAddTimePartialMatchDynamicResponse.write_as_json(handler);
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            handler.start_pair("FutureSupportDynamicResponse");
            if (partial_allowed)
                storeFutureSupportDynamicResponse.write_partial_as_json(handler);
            else
                storeFutureSupportDynamicResponse.write_as_json(handler);
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

    public static new TimerAddTimeCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerAddTimeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerAddTimeCommand", ignore_extras);
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
    public static new TimerAddTimeCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimerAddTimeCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerAddTimeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerAddTimeCommand", ignore_extras);
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
    public static new TimerAddTimeCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimerAddTimeCommandJSON from_text(string text, bool ignore_extras)
      {
        TimerAddTimeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerAddTimeCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimerAddTimeCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TimerAddTimeCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimerAddTimeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerAddTimeCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TimerCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAddTimeAllDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAddTimeSingleDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAddTimeMultiDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAddTimeNoMatchDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAddTimePartialMatchDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorFutureSupportDynamicResponse;
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
            if (!(getTimerCommandJSONKey().Equals("TimerAddTimeCommand")))
                throw new Exception("The key field has a value other than `TimerAddTimeCommand'.");
            TimerAddTimeCommandJSON result = new TimerAddTimeCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimerAddTimeCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TimerCommandJSON new_result)
          {
            handle_result((TimerAddTimeCommandJSON )new_result);
          }
        protected void finish(TimerAddTimeCommandJSON result)
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
            if (fieldGeneratorAddTimeAllDynamicResponse.have_value)
              {
                result.setAddTimeAllDynamicResponse(fieldGeneratorAddTimeAllDynamicResponse.value);
                fieldGeneratorAddTimeAllDynamicResponse.have_value = false;
              }
            if (fieldGeneratorAddTimeSingleDynamicResponse.have_value)
              {
                result.setAddTimeSingleDynamicResponse(fieldGeneratorAddTimeSingleDynamicResponse.value);
                fieldGeneratorAddTimeSingleDynamicResponse.have_value = false;
              }
            if (fieldGeneratorAddTimeMultiDynamicResponse.have_value)
              {
                result.setAddTimeMultiDynamicResponse(fieldGeneratorAddTimeMultiDynamicResponse.value);
                fieldGeneratorAddTimeMultiDynamicResponse.have_value = false;
              }
            if (fieldGeneratorAddTimeNoMatchDynamicResponse.have_value)
              {
                result.setAddTimeNoMatchDynamicResponse(fieldGeneratorAddTimeNoMatchDynamicResponse.value);
                fieldGeneratorAddTimeNoMatchDynamicResponse.have_value = false;
              }
            if (fieldGeneratorAddTimePartialMatchDynamicResponse.have_value)
              {
                result.setAddTimePartialMatchDynamicResponse(fieldGeneratorAddTimePartialMatchDynamicResponse.value);
                fieldGeneratorAddTimePartialMatchDynamicResponse.have_value = false;
              }
            if (fieldGeneratorFutureSupportDynamicResponse.have_value)
              {
                result.setFutureSupportDynamicResponse(fieldGeneratorFutureSupportDynamicResponse.value);
                fieldGeneratorFutureSupportDynamicResponse.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(TimerAddTimeCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "ddTime", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 8, "llDynamicResponse", 0, 17, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorAddTimeAllDynamicResponse;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 8, "ultiDynamicResponse", 0, 19, false) == 0) && (field_name.Length == 27))
                                    return fieldGeneratorAddTimeMultiDynamicResponse;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 29))
                                    return fieldGeneratorAddTimeNoMatchDynamicResponse;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 8, "artialMatchDynamicResponse", 0, 26, false) == 0) && (field_name.Length == 34))
                                    return fieldGeneratorAddTimePartialMatchDynamicResponse;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 8, "ingleDynamicResponse", 0, 20, false) == 0) && (field_name.Length == 28))
                                    return fieldGeneratorAddTimeSingleDynamicResponse;
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
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the TimerAddTimeCommand class", ignore_extras);
            fieldGeneratorAddTimeAllDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"AddTimeAllDynamicResponse\" of the TimerAddTimeCommand class", ignore_extras);
            fieldGeneratorAddTimeSingleDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"AddTimeSingleDynamicResponse\" of the TimerAddTimeCommand class", ignore_extras);
            fieldGeneratorAddTimeMultiDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"AddTimeMultiDynamicResponse\" of the TimerAddTimeCommand class", ignore_extras);
            fieldGeneratorAddTimeNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"AddTimeNoMatchDynamicResponse\" of the TimerAddTimeCommand class", ignore_extras);
            fieldGeneratorAddTimePartialMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"AddTimePartialMatchDynamicResponse\" of the TimerAddTimeCommand class", ignore_extras);
            fieldGeneratorFutureSupportDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"FutureSupportDynamicResponse\" of the TimerAddTimeCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimerAddTimeCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the TimerAddTimeCommand class", false);
            fieldGeneratorAddTimeAllDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"AddTimeAllDynamicResponse\" of the TimerAddTimeCommand class", false);
            fieldGeneratorAddTimeSingleDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"AddTimeSingleDynamicResponse\" of the TimerAddTimeCommand class", false);
            fieldGeneratorAddTimeMultiDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"AddTimeMultiDynamicResponse\" of the TimerAddTimeCommand class", false);
            fieldGeneratorAddTimeNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"AddTimeNoMatchDynamicResponse\" of the TimerAddTimeCommand class", false);
            fieldGeneratorAddTimePartialMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"AddTimePartialMatchDynamicResponse\" of the TimerAddTimeCommand class", false);
            fieldGeneratorFutureSupportDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"FutureSupportDynamicResponse\" of the TimerAddTimeCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimerAddTimeCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            fieldGeneratorAddTimeAllDynamicResponse.reset();
            fieldGeneratorAddTimeSingleDynamicResponse.reset();
            fieldGeneratorAddTimeMultiDynamicResponse.reset();
            fieldGeneratorAddTimeNoMatchDynamicResponse.reset();
            fieldGeneratorAddTimePartialMatchDynamicResponse.reset();
            fieldGeneratorFutureSupportDynamicResponse.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TimerAddTimeCommandJSON  result)
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
        public TimerAddTimeCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimerAddTimeCommandJSON  result)
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
    protected virtual void handle_result(List<TimerAddTimeCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimerAddTimeCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimerAddTimeCommandJSON>();
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
    public List<TimerAddTimeCommandJSON> value;
  };
  };
