/* file "TimerStopCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimerStopCommandJSON : TimerCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasTimerCriteria;
        private List< TimerCriteriaJSON  > storeTimerCriteria;
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


        public TypeNativeDataJSON()
          {
            flagHasTimerCriteria = false;
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
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "TimerCriteria", 0, 13, false) == 0) && (field_name.Length == 13))
                    return fieldGeneratorTimerCriteria;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTimerCriteria = new TimerCriteriaJSON.HoldingArrayGenerator("field \"TimerCriteria\" of the TypeNativeData class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTimerCriteria = new TimerCriteriaJSON.HoldingArrayGenerator("field \"TimerCriteria\" of the TypeNativeData class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTimerCriteria.reset();
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
    private bool flagHasStopAllDynamicResponse;
    private DynamicResponseJSON  storeStopAllDynamicResponse;
    private bool flagHasStopSingleDynamicResponse;
    private DynamicResponseJSON  storeStopSingleDynamicResponse;
    private bool flagHasStopMultiDynamicResponse;
    private DynamicResponseJSON  storeStopMultiDynamicResponse;
    private bool flagHasStopNoMatchDynamicResponse;
    private DynamicResponseJSON  storeStopNoMatchDynamicResponse;
    private bool flagHasStopPartialMatchDynamicResponse;
    private DynamicResponseJSON  storeStopPartialMatchDynamicResponse;
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

    private JSONValue  extraStopAllDynamicResponseToJSON()
      {
        JSONValueHandler handler_StopAllDynamicResponse = new JSONValueHandler();
        storeStopAllDynamicResponse.write_as_json(handler_StopAllDynamicResponse);
        return handler_StopAllDynamicResponse.result;
      }

    private JSONValue  extraStopSingleDynamicResponseToJSON()
      {
        JSONValueHandler handler_StopSingleDynamicResponse = new JSONValueHandler();
        storeStopSingleDynamicResponse.write_as_json(handler_StopSingleDynamicResponse);
        return handler_StopSingleDynamicResponse.result;
      }

    private JSONValue  extraStopMultiDynamicResponseToJSON()
      {
        JSONValueHandler handler_StopMultiDynamicResponse = new JSONValueHandler();
        storeStopMultiDynamicResponse.write_as_json(handler_StopMultiDynamicResponse);
        return handler_StopMultiDynamicResponse.result;
      }

    private JSONValue  extraStopNoMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_StopNoMatchDynamicResponse = new JSONValueHandler();
        storeStopNoMatchDynamicResponse.write_as_json(handler_StopNoMatchDynamicResponse);
        return handler_StopNoMatchDynamicResponse.result;
      }

    private JSONValue  extraStopPartialMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_StopPartialMatchDynamicResponse = new JSONValueHandler();
        storeStopPartialMatchDynamicResponse.write_as_json(handler_StopPartialMatchDynamicResponse);
        return handler_StopPartialMatchDynamicResponse.result;
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


    private void  fromJSONStopAllDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setStopAllDynamicResponse(convert_classy);
      }


    private void  fromJSONStopSingleDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setStopSingleDynamicResponse(convert_classy);
      }


    private void  fromJSONStopMultiDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setStopMultiDynamicResponse(convert_classy);
      }


    private void  fromJSONStopNoMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setStopNoMatchDynamicResponse(convert_classy);
      }


    private void  fromJSONStopPartialMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setStopPartialMatchDynamicResponse(convert_classy);
      }


    private void  fromJSONFutureSupportDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setFutureSupportDynamicResponse(convert_classy);
      }


    public TimerStopCommandJSON()
      {
        flagHasNativeData = false;
        flagHasStopAllDynamicResponse = false;
        flagHasStopSingleDynamicResponse = false;
        flagHasStopMultiDynamicResponse = false;
        flagHasStopNoMatchDynamicResponse = false;
        flagHasStopPartialMatchDynamicResponse = false;
        flagHasFutureSupportDynamicResponse = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTimerCommandKind()
      {
        return "TimerStopCommand";
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

    public bool  hasStopAllDynamicResponse()
      {
        return flagHasStopAllDynamicResponse;
      }

    public DynamicResponseJSON   getStopAllDynamicResponse()
      {
        Debug.Assert(flagHasStopAllDynamicResponse);
        return storeStopAllDynamicResponse;
      }

    public bool  hasStopSingleDynamicResponse()
      {
        return flagHasStopSingleDynamicResponse;
      }

    public DynamicResponseJSON   getStopSingleDynamicResponse()
      {
        Debug.Assert(flagHasStopSingleDynamicResponse);
        return storeStopSingleDynamicResponse;
      }

    public bool  hasStopMultiDynamicResponse()
      {
        return flagHasStopMultiDynamicResponse;
      }

    public DynamicResponseJSON   getStopMultiDynamicResponse()
      {
        Debug.Assert(flagHasStopMultiDynamicResponse);
        return storeStopMultiDynamicResponse;
      }

    public bool  hasStopNoMatchDynamicResponse()
      {
        return flagHasStopNoMatchDynamicResponse;
      }

    public DynamicResponseJSON   getStopNoMatchDynamicResponse()
      {
        Debug.Assert(flagHasStopNoMatchDynamicResponse);
        return storeStopNoMatchDynamicResponse;
      }

    public bool  hasStopPartialMatchDynamicResponse()
      {
        return flagHasStopPartialMatchDynamicResponse;
      }

    public DynamicResponseJSON   getStopPartialMatchDynamicResponse()
      {
        Debug.Assert(flagHasStopPartialMatchDynamicResponse);
        return storeStopPartialMatchDynamicResponse;
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


    public virtual int extraTimerStopCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimerStopCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimerStopCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimerStopCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTimerCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        if (flagHasStopAllDynamicResponse)
            ++result;
        if (flagHasStopSingleDynamicResponse)
            ++result;
        if (flagHasStopMultiDynamicResponse)
            ++result;
        if (flagHasStopNoMatchDynamicResponse)
            ++result;
        if (flagHasStopPartialMatchDynamicResponse)
            ++result;
        if (flagHasFutureSupportDynamicResponse)
            ++result;
        result += extraTimerStopCommandComponentCount();
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
        if (flagHasStopAllDynamicResponse)
          {
            if (remainder == 0)
                return "StopAllDynamicResponse";
            --remainder;
          }
        if (flagHasStopSingleDynamicResponse)
          {
            if (remainder == 0)
                return "StopSingleDynamicResponse";
            --remainder;
          }
        if (flagHasStopMultiDynamicResponse)
          {
            if (remainder == 0)
                return "StopMultiDynamicResponse";
            --remainder;
          }
        if (flagHasStopNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return "StopNoMatchDynamicResponse";
            --remainder;
          }
        if (flagHasStopPartialMatchDynamicResponse)
          {
            if (remainder == 0)
                return "StopPartialMatchDynamicResponse";
            --remainder;
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            if (remainder == 0)
                return "FutureSupportDynamicResponse";
            --remainder;
          }
        return extraTimerStopCommandComponentKey(remainder);
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
        if (flagHasStopAllDynamicResponse)
          {
            if (remainder == 0)
                return extraStopAllDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasStopSingleDynamicResponse)
          {
            if (remainder == 0)
                return extraStopSingleDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasStopMultiDynamicResponse)
          {
            if (remainder == 0)
                return extraStopMultiDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasStopNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraStopNoMatchDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasStopPartialMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraStopPartialMatchDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            if (remainder == 0)
                return extraFutureSupportDynamicResponseToJSON();
            --remainder;
          }
        return extraTimerStopCommandComponentValue(remainder);
      }
    public override JSONValue extraTimerCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'F':
                if ((String.Compare(field_name, 1, "utureSupportDynamicResponse", 0, 27, false) == 0) && (field_name.Length == 28))
                    return (flagHasFutureSupportDynamicResponse ? extraFutureSupportDynamicResponseToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNativeData ? extraNativeDataToJSON() : null);
                break;
            case 'S':
                if (String.Compare(field_name, 1, "top", 0, 3, false) == 0)
                  {
                    switch (field_name[4])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 5, "llDynamicResponse", 0, 17, false) == 0) && (field_name.Length == 22))
                                return (flagHasStopAllDynamicResponse ? extraStopAllDynamicResponseToJSON() : null);
                            break;
                        case 'M':
                            if ((String.Compare(field_name, 5, "ultiDynamicResponse", 0, 19, false) == 0) && (field_name.Length == 24))
                                return (flagHasStopMultiDynamicResponse ? extraStopMultiDynamicResponseToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 5, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 26))
                                return (flagHasStopNoMatchDynamicResponse ? extraStopNoMatchDynamicResponseToJSON() : null);
                            break;
                        case 'P':
                            if ((String.Compare(field_name, 5, "artialMatchDynamicResponse", 0, 26, false) == 0) && (field_name.Length == 31))
                                return (flagHasStopPartialMatchDynamicResponse ? extraStopPartialMatchDynamicResponseToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 5, "ingleDynamicResponse", 0, 20, false) == 0) && (field_name.Length == 25))
                                return (flagHasStopSingleDynamicResponse ? extraStopSingleDynamicResponseToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraTimerStopCommandLookup(field_name);
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
    public void setStopAllDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasStopAllDynamicResponse)
          {
          }
        flagHasStopAllDynamicResponse = true;
        storeStopAllDynamicResponse = new_value;
      }
    public void unsetStopAllDynamicResponse()
      {
        if (flagHasStopAllDynamicResponse)
          {
          }
        flagHasStopAllDynamicResponse = false;
      }
    public void setStopSingleDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasStopSingleDynamicResponse)
          {
          }
        flagHasStopSingleDynamicResponse = true;
        storeStopSingleDynamicResponse = new_value;
      }
    public void unsetStopSingleDynamicResponse()
      {
        if (flagHasStopSingleDynamicResponse)
          {
          }
        flagHasStopSingleDynamicResponse = false;
      }
    public void setStopMultiDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasStopMultiDynamicResponse)
          {
          }
        flagHasStopMultiDynamicResponse = true;
        storeStopMultiDynamicResponse = new_value;
      }
    public void unsetStopMultiDynamicResponse()
      {
        if (flagHasStopMultiDynamicResponse)
          {
          }
        flagHasStopMultiDynamicResponse = false;
      }
    public void setStopNoMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasStopNoMatchDynamicResponse)
          {
          }
        flagHasStopNoMatchDynamicResponse = true;
        storeStopNoMatchDynamicResponse = new_value;
      }
    public void unsetStopNoMatchDynamicResponse()
      {
        if (flagHasStopNoMatchDynamicResponse)
          {
          }
        flagHasStopNoMatchDynamicResponse = false;
      }
    public void setStopPartialMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasStopPartialMatchDynamicResponse)
          {
          }
        flagHasStopPartialMatchDynamicResponse = true;
        storeStopPartialMatchDynamicResponse = new_value;
      }
    public void unsetStopPartialMatchDynamicResponse()
      {
        if (flagHasStopPartialMatchDynamicResponse)
          {
          }
        flagHasStopPartialMatchDynamicResponse = false;
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

    public virtual void extraTimerStopCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimerStopCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimerStopCommandLookup(key);
        if (old_field == null)
          {
            extraTimerStopCommandAppendPair(key, new_component);
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
            case 'S':
                if (String.Compare(key, 1, "top", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'A':
                            if ((String.Compare(key, 5, "llDynamicResponse", 0, 17, false) == 0) && (key.Length == 22))
                                {
                                fromJSONStopAllDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 5, "ultiDynamicResponse", 0, 19, false) == 0) && (key.Length == 24))
                                {
                                fromJSONStopMultiDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 5, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 26))
                                {
                                fromJSONStopNoMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 5, "artialMatchDynamicResponse", 0, 26, false) == 0) && (key.Length == 31))
                                {
                                fromJSONStopPartialMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 5, "ingleDynamicResponse", 0, 20, false) == 0) && (key.Length == 25))
                                {
                                fromJSONStopSingleDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraTimerStopCommandAppendPair(key, new_component);
      }
    public override void extraTimerCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
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
            case 'S':
                if (String.Compare(key, 1, "top", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'A':
                            if ((String.Compare(key, 5, "llDynamicResponse", 0, 17, false) == 0) && (key.Length == 22))
                                {
                                fromJSONStopAllDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 5, "ultiDynamicResponse", 0, 19, false) == 0) && (key.Length == 24))
                                {
                                fromJSONStopMultiDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 5, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 26))
                                {
                                fromJSONStopNoMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 5, "artialMatchDynamicResponse", 0, 26, false) == 0) && (key.Length == 31))
                                {
                                fromJSONStopPartialMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 5, "ingleDynamicResponse", 0, 20, false) == 0) && (key.Length == 25))
                                {
                                fromJSONStopSingleDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraTimerStopCommandSetField(key, new_component);
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
        if (flagHasStopAllDynamicResponse)
          {
            handler.start_pair("StopAllDynamicResponse");
            if (partial_allowed)
                storeStopAllDynamicResponse.write_partial_as_json(handler);
            else
                storeStopAllDynamicResponse.write_as_json(handler);
          }
        if (flagHasStopSingleDynamicResponse)
          {
            handler.start_pair("StopSingleDynamicResponse");
            if (partial_allowed)
                storeStopSingleDynamicResponse.write_partial_as_json(handler);
            else
                storeStopSingleDynamicResponse.write_as_json(handler);
          }
        if (flagHasStopMultiDynamicResponse)
          {
            handler.start_pair("StopMultiDynamicResponse");
            if (partial_allowed)
                storeStopMultiDynamicResponse.write_partial_as_json(handler);
            else
                storeStopMultiDynamicResponse.write_as_json(handler);
          }
        if (flagHasStopNoMatchDynamicResponse)
          {
            handler.start_pair("StopNoMatchDynamicResponse");
            if (partial_allowed)
                storeStopNoMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeStopNoMatchDynamicResponse.write_as_json(handler);
          }
        if (flagHasStopPartialMatchDynamicResponse)
          {
            handler.start_pair("StopPartialMatchDynamicResponse");
            if (partial_allowed)
                storeStopPartialMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeStopPartialMatchDynamicResponse.write_as_json(handler);
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

    public static new TimerStopCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerStopCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerStopCommand", ignore_extras);
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
    public static new TimerStopCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimerStopCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerStopCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerStopCommand", ignore_extras);
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
    public static new TimerStopCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimerStopCommandJSON from_text(string text, bool ignore_extras)
      {
        TimerStopCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerStopCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimerStopCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TimerStopCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimerStopCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerStopCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TimerCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorStopAllDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorStopSingleDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorStopMultiDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorStopNoMatchDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorStopPartialMatchDynamicResponse;
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
            if (!(getTimerCommandJSONKey().Equals("TimerStopCommand")))
                throw new Exception("The key field has a value other than `TimerStopCommand'.");
            TimerStopCommandJSON result = new TimerStopCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimerStopCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TimerCommandJSON new_result)
          {
            handle_result((TimerStopCommandJSON )new_result);
          }
        protected void finish(TimerStopCommandJSON result)
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
            if (fieldGeneratorStopAllDynamicResponse.have_value)
              {
                result.setStopAllDynamicResponse(fieldGeneratorStopAllDynamicResponse.value);
                fieldGeneratorStopAllDynamicResponse.have_value = false;
              }
            if (fieldGeneratorStopSingleDynamicResponse.have_value)
              {
                result.setStopSingleDynamicResponse(fieldGeneratorStopSingleDynamicResponse.value);
                fieldGeneratorStopSingleDynamicResponse.have_value = false;
              }
            if (fieldGeneratorStopMultiDynamicResponse.have_value)
              {
                result.setStopMultiDynamicResponse(fieldGeneratorStopMultiDynamicResponse.value);
                fieldGeneratorStopMultiDynamicResponse.have_value = false;
              }
            if (fieldGeneratorStopNoMatchDynamicResponse.have_value)
              {
                result.setStopNoMatchDynamicResponse(fieldGeneratorStopNoMatchDynamicResponse.value);
                fieldGeneratorStopNoMatchDynamicResponse.have_value = false;
              }
            if (fieldGeneratorStopPartialMatchDynamicResponse.have_value)
              {
                result.setStopPartialMatchDynamicResponse(fieldGeneratorStopPartialMatchDynamicResponse.value);
                fieldGeneratorStopPartialMatchDynamicResponse.have_value = false;
              }
            if (fieldGeneratorFutureSupportDynamicResponse.have_value)
              {
                result.setFutureSupportDynamicResponse(fieldGeneratorFutureSupportDynamicResponse.value);
                fieldGeneratorFutureSupportDynamicResponse.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(TimerStopCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "utureSupportDynamicResponse", 0, 27, false) == 0) && (field_name.Length == 28))
                        return fieldGeneratorFutureSupportDynamicResponse;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNativeData;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "top", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 5, "llDynamicResponse", 0, 17, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorStopAllDynamicResponse;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 5, "ultiDynamicResponse", 0, 19, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorStopMultiDynamicResponse;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 5, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorStopNoMatchDynamicResponse;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 5, "artialMatchDynamicResponse", 0, 26, false) == 0) && (field_name.Length == 31))
                                    return fieldGeneratorStopPartialMatchDynamicResponse;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 5, "ingleDynamicResponse", 0, 20, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorStopSingleDynamicResponse;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the TimerStopCommand class", ignore_extras);
            fieldGeneratorStopAllDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"StopAllDynamicResponse\" of the TimerStopCommand class", ignore_extras);
            fieldGeneratorStopSingleDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"StopSingleDynamicResponse\" of the TimerStopCommand class", ignore_extras);
            fieldGeneratorStopMultiDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"StopMultiDynamicResponse\" of the TimerStopCommand class", ignore_extras);
            fieldGeneratorStopNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"StopNoMatchDynamicResponse\" of the TimerStopCommand class", ignore_extras);
            fieldGeneratorStopPartialMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"StopPartialMatchDynamicResponse\" of the TimerStopCommand class", ignore_extras);
            fieldGeneratorFutureSupportDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"FutureSupportDynamicResponse\" of the TimerStopCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimerStopCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the TimerStopCommand class", false);
            fieldGeneratorStopAllDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"StopAllDynamicResponse\" of the TimerStopCommand class", false);
            fieldGeneratorStopSingleDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"StopSingleDynamicResponse\" of the TimerStopCommand class", false);
            fieldGeneratorStopMultiDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"StopMultiDynamicResponse\" of the TimerStopCommand class", false);
            fieldGeneratorStopNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"StopNoMatchDynamicResponse\" of the TimerStopCommand class", false);
            fieldGeneratorStopPartialMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"StopPartialMatchDynamicResponse\" of the TimerStopCommand class", false);
            fieldGeneratorFutureSupportDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"FutureSupportDynamicResponse\" of the TimerStopCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimerStopCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            fieldGeneratorStopAllDynamicResponse.reset();
            fieldGeneratorStopSingleDynamicResponse.reset();
            fieldGeneratorStopMultiDynamicResponse.reset();
            fieldGeneratorStopNoMatchDynamicResponse.reset();
            fieldGeneratorStopPartialMatchDynamicResponse.reset();
            fieldGeneratorFutureSupportDynamicResponse.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TimerStopCommandJSON  result)
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
        public TimerStopCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimerStopCommandJSON  result)
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
    protected virtual void handle_result(List<TimerStopCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimerStopCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimerStopCommandJSON>();
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
    public List<TimerStopCommandJSON> value;
  };
  };
