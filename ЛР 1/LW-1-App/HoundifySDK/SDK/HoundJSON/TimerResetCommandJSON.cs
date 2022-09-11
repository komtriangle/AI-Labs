/* file "TimerResetCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimerResetCommandJSON : TimerCommandJSON
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
    private bool flagHasResetAllDynamicResponse;
    private DynamicResponseJSON  storeResetAllDynamicResponse;
    private bool flagHasResetSingleDynamicResponse;
    private DynamicResponseJSON  storeResetSingleDynamicResponse;
    private bool flagHasResetMultiDynamicResponse;
    private DynamicResponseJSON  storeResetMultiDynamicResponse;
    private bool flagHasResetNoMatchDynamicResponse;
    private DynamicResponseJSON  storeResetNoMatchDynamicResponse;
    private bool flagHasResetPartialMatchDynamicResponse;
    private DynamicResponseJSON  storeResetPartialMatchDynamicResponse;
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

    private JSONValue  extraResetAllDynamicResponseToJSON()
      {
        JSONValueHandler handler_ResetAllDynamicResponse = new JSONValueHandler();
        storeResetAllDynamicResponse.write_as_json(handler_ResetAllDynamicResponse);
        return handler_ResetAllDynamicResponse.result;
      }

    private JSONValue  extraResetSingleDynamicResponseToJSON()
      {
        JSONValueHandler handler_ResetSingleDynamicResponse = new JSONValueHandler();
        storeResetSingleDynamicResponse.write_as_json(handler_ResetSingleDynamicResponse);
        return handler_ResetSingleDynamicResponse.result;
      }

    private JSONValue  extraResetMultiDynamicResponseToJSON()
      {
        JSONValueHandler handler_ResetMultiDynamicResponse = new JSONValueHandler();
        storeResetMultiDynamicResponse.write_as_json(handler_ResetMultiDynamicResponse);
        return handler_ResetMultiDynamicResponse.result;
      }

    private JSONValue  extraResetNoMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_ResetNoMatchDynamicResponse = new JSONValueHandler();
        storeResetNoMatchDynamicResponse.write_as_json(handler_ResetNoMatchDynamicResponse);
        return handler_ResetNoMatchDynamicResponse.result;
      }

    private JSONValue  extraResetPartialMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_ResetPartialMatchDynamicResponse = new JSONValueHandler();
        storeResetPartialMatchDynamicResponse.write_as_json(handler_ResetPartialMatchDynamicResponse);
        return handler_ResetPartialMatchDynamicResponse.result;
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


    private void  fromJSONResetAllDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setResetAllDynamicResponse(convert_classy);
      }


    private void  fromJSONResetSingleDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setResetSingleDynamicResponse(convert_classy);
      }


    private void  fromJSONResetMultiDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setResetMultiDynamicResponse(convert_classy);
      }


    private void  fromJSONResetNoMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setResetNoMatchDynamicResponse(convert_classy);
      }


    private void  fromJSONResetPartialMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setResetPartialMatchDynamicResponse(convert_classy);
      }


    private void  fromJSONFutureSupportDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setFutureSupportDynamicResponse(convert_classy);
      }


    public TimerResetCommandJSON()
      {
        flagHasNativeData = false;
        flagHasResetAllDynamicResponse = false;
        flagHasResetSingleDynamicResponse = false;
        flagHasResetMultiDynamicResponse = false;
        flagHasResetNoMatchDynamicResponse = false;
        flagHasResetPartialMatchDynamicResponse = false;
        flagHasFutureSupportDynamicResponse = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTimerCommandKind()
      {
        return "TimerResetCommand";
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

    public bool  hasResetAllDynamicResponse()
      {
        return flagHasResetAllDynamicResponse;
      }

    public DynamicResponseJSON   getResetAllDynamicResponse()
      {
        Debug.Assert(flagHasResetAllDynamicResponse);
        return storeResetAllDynamicResponse;
      }

    public bool  hasResetSingleDynamicResponse()
      {
        return flagHasResetSingleDynamicResponse;
      }

    public DynamicResponseJSON   getResetSingleDynamicResponse()
      {
        Debug.Assert(flagHasResetSingleDynamicResponse);
        return storeResetSingleDynamicResponse;
      }

    public bool  hasResetMultiDynamicResponse()
      {
        return flagHasResetMultiDynamicResponse;
      }

    public DynamicResponseJSON   getResetMultiDynamicResponse()
      {
        Debug.Assert(flagHasResetMultiDynamicResponse);
        return storeResetMultiDynamicResponse;
      }

    public bool  hasResetNoMatchDynamicResponse()
      {
        return flagHasResetNoMatchDynamicResponse;
      }

    public DynamicResponseJSON   getResetNoMatchDynamicResponse()
      {
        Debug.Assert(flagHasResetNoMatchDynamicResponse);
        return storeResetNoMatchDynamicResponse;
      }

    public bool  hasResetPartialMatchDynamicResponse()
      {
        return flagHasResetPartialMatchDynamicResponse;
      }

    public DynamicResponseJSON   getResetPartialMatchDynamicResponse()
      {
        Debug.Assert(flagHasResetPartialMatchDynamicResponse);
        return storeResetPartialMatchDynamicResponse;
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


    public virtual int extraTimerResetCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimerResetCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimerResetCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimerResetCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTimerCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        if (flagHasResetAllDynamicResponse)
            ++result;
        if (flagHasResetSingleDynamicResponse)
            ++result;
        if (flagHasResetMultiDynamicResponse)
            ++result;
        if (flagHasResetNoMatchDynamicResponse)
            ++result;
        if (flagHasResetPartialMatchDynamicResponse)
            ++result;
        if (flagHasFutureSupportDynamicResponse)
            ++result;
        result += extraTimerResetCommandComponentCount();
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
        if (flagHasResetAllDynamicResponse)
          {
            if (remainder == 0)
                return "ResetAllDynamicResponse";
            --remainder;
          }
        if (flagHasResetSingleDynamicResponse)
          {
            if (remainder == 0)
                return "ResetSingleDynamicResponse";
            --remainder;
          }
        if (flagHasResetMultiDynamicResponse)
          {
            if (remainder == 0)
                return "ResetMultiDynamicResponse";
            --remainder;
          }
        if (flagHasResetNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return "ResetNoMatchDynamicResponse";
            --remainder;
          }
        if (flagHasResetPartialMatchDynamicResponse)
          {
            if (remainder == 0)
                return "ResetPartialMatchDynamicResponse";
            --remainder;
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            if (remainder == 0)
                return "FutureSupportDynamicResponse";
            --remainder;
          }
        return extraTimerResetCommandComponentKey(remainder);
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
        if (flagHasResetAllDynamicResponse)
          {
            if (remainder == 0)
                return extraResetAllDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasResetSingleDynamicResponse)
          {
            if (remainder == 0)
                return extraResetSingleDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasResetMultiDynamicResponse)
          {
            if (remainder == 0)
                return extraResetMultiDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasResetNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraResetNoMatchDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasResetPartialMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraResetPartialMatchDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            if (remainder == 0)
                return extraFutureSupportDynamicResponseToJSON();
            --remainder;
          }
        return extraTimerResetCommandComponentValue(remainder);
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
            case 'R':
                if (String.Compare(field_name, 1, "eset", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 6, "llDynamicResponse", 0, 17, false) == 0) && (field_name.Length == 23))
                                return (flagHasResetAllDynamicResponse ? extraResetAllDynamicResponseToJSON() : null);
                            break;
                        case 'M':
                            if ((String.Compare(field_name, 6, "ultiDynamicResponse", 0, 19, false) == 0) && (field_name.Length == 25))
                                return (flagHasResetMultiDynamicResponse ? extraResetMultiDynamicResponseToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 6, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 27))
                                return (flagHasResetNoMatchDynamicResponse ? extraResetNoMatchDynamicResponseToJSON() : null);
                            break;
                        case 'P':
                            if ((String.Compare(field_name, 6, "artialMatchDynamicResponse", 0, 26, false) == 0) && (field_name.Length == 32))
                                return (flagHasResetPartialMatchDynamicResponse ? extraResetPartialMatchDynamicResponseToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 6, "ingleDynamicResponse", 0, 20, false) == 0) && (field_name.Length == 26))
                                return (flagHasResetSingleDynamicResponse ? extraResetSingleDynamicResponseToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraTimerResetCommandLookup(field_name);
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
    public void setResetAllDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasResetAllDynamicResponse)
          {
          }
        flagHasResetAllDynamicResponse = true;
        storeResetAllDynamicResponse = new_value;
      }
    public void unsetResetAllDynamicResponse()
      {
        if (flagHasResetAllDynamicResponse)
          {
          }
        flagHasResetAllDynamicResponse = false;
      }
    public void setResetSingleDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasResetSingleDynamicResponse)
          {
          }
        flagHasResetSingleDynamicResponse = true;
        storeResetSingleDynamicResponse = new_value;
      }
    public void unsetResetSingleDynamicResponse()
      {
        if (flagHasResetSingleDynamicResponse)
          {
          }
        flagHasResetSingleDynamicResponse = false;
      }
    public void setResetMultiDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasResetMultiDynamicResponse)
          {
          }
        flagHasResetMultiDynamicResponse = true;
        storeResetMultiDynamicResponse = new_value;
      }
    public void unsetResetMultiDynamicResponse()
      {
        if (flagHasResetMultiDynamicResponse)
          {
          }
        flagHasResetMultiDynamicResponse = false;
      }
    public void setResetNoMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasResetNoMatchDynamicResponse)
          {
          }
        flagHasResetNoMatchDynamicResponse = true;
        storeResetNoMatchDynamicResponse = new_value;
      }
    public void unsetResetNoMatchDynamicResponse()
      {
        if (flagHasResetNoMatchDynamicResponse)
          {
          }
        flagHasResetNoMatchDynamicResponse = false;
      }
    public void setResetPartialMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasResetPartialMatchDynamicResponse)
          {
          }
        flagHasResetPartialMatchDynamicResponse = true;
        storeResetPartialMatchDynamicResponse = new_value;
      }
    public void unsetResetPartialMatchDynamicResponse()
      {
        if (flagHasResetPartialMatchDynamicResponse)
          {
          }
        flagHasResetPartialMatchDynamicResponse = false;
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

    public virtual void extraTimerResetCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimerResetCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimerResetCommandLookup(key);
        if (old_field == null)
          {
            extraTimerResetCommandAppendPair(key, new_component);
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
            case 'R':
                if (String.Compare(key, 1, "eset", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'A':
                            if ((String.Compare(key, 6, "llDynamicResponse", 0, 17, false) == 0) && (key.Length == 23))
                                {
                                fromJSONResetAllDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 6, "ultiDynamicResponse", 0, 19, false) == 0) && (key.Length == 25))
                                {
                                fromJSONResetMultiDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 6, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 27))
                                {
                                fromJSONResetNoMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 6, "artialMatchDynamicResponse", 0, 26, false) == 0) && (key.Length == 32))
                                {
                                fromJSONResetPartialMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 6, "ingleDynamicResponse", 0, 20, false) == 0) && (key.Length == 26))
                                {
                                fromJSONResetSingleDynamicResponse(new_component, false);
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
        extraTimerResetCommandAppendPair(key, new_component);
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
            case 'R':
                if (String.Compare(key, 1, "eset", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'A':
                            if ((String.Compare(key, 6, "llDynamicResponse", 0, 17, false) == 0) && (key.Length == 23))
                                {
                                fromJSONResetAllDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 6, "ultiDynamicResponse", 0, 19, false) == 0) && (key.Length == 25))
                                {
                                fromJSONResetMultiDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 6, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 27))
                                {
                                fromJSONResetNoMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 6, "artialMatchDynamicResponse", 0, 26, false) == 0) && (key.Length == 32))
                                {
                                fromJSONResetPartialMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 6, "ingleDynamicResponse", 0, 20, false) == 0) && (key.Length == 26))
                                {
                                fromJSONResetSingleDynamicResponse(new_component, false);
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
        extraTimerResetCommandSetField(key, new_component);
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
        if (flagHasResetAllDynamicResponse)
          {
            handler.start_pair("ResetAllDynamicResponse");
            if (partial_allowed)
                storeResetAllDynamicResponse.write_partial_as_json(handler);
            else
                storeResetAllDynamicResponse.write_as_json(handler);
          }
        if (flagHasResetSingleDynamicResponse)
          {
            handler.start_pair("ResetSingleDynamicResponse");
            if (partial_allowed)
                storeResetSingleDynamicResponse.write_partial_as_json(handler);
            else
                storeResetSingleDynamicResponse.write_as_json(handler);
          }
        if (flagHasResetMultiDynamicResponse)
          {
            handler.start_pair("ResetMultiDynamicResponse");
            if (partial_allowed)
                storeResetMultiDynamicResponse.write_partial_as_json(handler);
            else
                storeResetMultiDynamicResponse.write_as_json(handler);
          }
        if (flagHasResetNoMatchDynamicResponse)
          {
            handler.start_pair("ResetNoMatchDynamicResponse");
            if (partial_allowed)
                storeResetNoMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeResetNoMatchDynamicResponse.write_as_json(handler);
          }
        if (flagHasResetPartialMatchDynamicResponse)
          {
            handler.start_pair("ResetPartialMatchDynamicResponse");
            if (partial_allowed)
                storeResetPartialMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeResetPartialMatchDynamicResponse.write_as_json(handler);
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

    public static new TimerResetCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerResetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerResetCommand", ignore_extras);
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
    public static new TimerResetCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimerResetCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerResetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerResetCommand", ignore_extras);
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
    public static new TimerResetCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimerResetCommandJSON from_text(string text, bool ignore_extras)
      {
        TimerResetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerResetCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimerResetCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TimerResetCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimerResetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerResetCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TimerCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorResetAllDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorResetSingleDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorResetMultiDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorResetNoMatchDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorResetPartialMatchDynamicResponse;
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
            if (!(getTimerCommandJSONKey().Equals("TimerResetCommand")))
                throw new Exception("The key field has a value other than `TimerResetCommand'.");
            TimerResetCommandJSON result = new TimerResetCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimerResetCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TimerCommandJSON new_result)
          {
            handle_result((TimerResetCommandJSON )new_result);
          }
        protected void finish(TimerResetCommandJSON result)
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
            if (fieldGeneratorResetAllDynamicResponse.have_value)
              {
                result.setResetAllDynamicResponse(fieldGeneratorResetAllDynamicResponse.value);
                fieldGeneratorResetAllDynamicResponse.have_value = false;
              }
            if (fieldGeneratorResetSingleDynamicResponse.have_value)
              {
                result.setResetSingleDynamicResponse(fieldGeneratorResetSingleDynamicResponse.value);
                fieldGeneratorResetSingleDynamicResponse.have_value = false;
              }
            if (fieldGeneratorResetMultiDynamicResponse.have_value)
              {
                result.setResetMultiDynamicResponse(fieldGeneratorResetMultiDynamicResponse.value);
                fieldGeneratorResetMultiDynamicResponse.have_value = false;
              }
            if (fieldGeneratorResetNoMatchDynamicResponse.have_value)
              {
                result.setResetNoMatchDynamicResponse(fieldGeneratorResetNoMatchDynamicResponse.value);
                fieldGeneratorResetNoMatchDynamicResponse.have_value = false;
              }
            if (fieldGeneratorResetPartialMatchDynamicResponse.have_value)
              {
                result.setResetPartialMatchDynamicResponse(fieldGeneratorResetPartialMatchDynamicResponse.value);
                fieldGeneratorResetPartialMatchDynamicResponse.have_value = false;
              }
            if (fieldGeneratorFutureSupportDynamicResponse.have_value)
              {
                result.setFutureSupportDynamicResponse(fieldGeneratorFutureSupportDynamicResponse.value);
                fieldGeneratorFutureSupportDynamicResponse.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(TimerResetCommandJSON new_result);
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
                case 'R':
                    if (String.Compare(field_name, 1, "eset", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 6, "llDynamicResponse", 0, 17, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorResetAllDynamicResponse;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 6, "ultiDynamicResponse", 0, 19, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorResetMultiDynamicResponse;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 6, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 27))
                                    return fieldGeneratorResetNoMatchDynamicResponse;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 6, "artialMatchDynamicResponse", 0, 26, false) == 0) && (field_name.Length == 32))
                                    return fieldGeneratorResetPartialMatchDynamicResponse;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 6, "ingleDynamicResponse", 0, 20, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorResetSingleDynamicResponse;
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
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the TimerResetCommand class", ignore_extras);
            fieldGeneratorResetAllDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"ResetAllDynamicResponse\" of the TimerResetCommand class", ignore_extras);
            fieldGeneratorResetSingleDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"ResetSingleDynamicResponse\" of the TimerResetCommand class", ignore_extras);
            fieldGeneratorResetMultiDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"ResetMultiDynamicResponse\" of the TimerResetCommand class", ignore_extras);
            fieldGeneratorResetNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"ResetNoMatchDynamicResponse\" of the TimerResetCommand class", ignore_extras);
            fieldGeneratorResetPartialMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"ResetPartialMatchDynamicResponse\" of the TimerResetCommand class", ignore_extras);
            fieldGeneratorFutureSupportDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"FutureSupportDynamicResponse\" of the TimerResetCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimerResetCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the TimerResetCommand class", false);
            fieldGeneratorResetAllDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"ResetAllDynamicResponse\" of the TimerResetCommand class", false);
            fieldGeneratorResetSingleDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"ResetSingleDynamicResponse\" of the TimerResetCommand class", false);
            fieldGeneratorResetMultiDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"ResetMultiDynamicResponse\" of the TimerResetCommand class", false);
            fieldGeneratorResetNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"ResetNoMatchDynamicResponse\" of the TimerResetCommand class", false);
            fieldGeneratorResetPartialMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"ResetPartialMatchDynamicResponse\" of the TimerResetCommand class", false);
            fieldGeneratorFutureSupportDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"FutureSupportDynamicResponse\" of the TimerResetCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimerResetCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            fieldGeneratorResetAllDynamicResponse.reset();
            fieldGeneratorResetSingleDynamicResponse.reset();
            fieldGeneratorResetMultiDynamicResponse.reset();
            fieldGeneratorResetNoMatchDynamicResponse.reset();
            fieldGeneratorResetPartialMatchDynamicResponse.reset();
            fieldGeneratorFutureSupportDynamicResponse.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TimerResetCommandJSON  result)
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
        public TimerResetCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimerResetCommandJSON  result)
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
    protected virtual void handle_result(List<TimerResetCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimerResetCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimerResetCommandJSON>();
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
    public List<TimerResetCommandJSON> value;
  };
  };
