/* file "AlarmUnsetCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AlarmUnsetCommandJSON : AlarmCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasAlarms;
        private List< AlarmJSON  > storeAlarms;
        private bool flagHasAlarmCriteria;
        private List< AlarmCriteriaJSON  > storeAlarmCriteria;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONAlarms(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Alarms of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field Alarms of TypeNativeDataJSON has too few elements.");
            List< AlarmJSON  > vector_Alarms1 = new List< AlarmJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                AlarmJSON convert_classy = AlarmJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Alarms1.Add(convert_classy);
              }
            Debug.Assert(vector_Alarms1.Count >= 1);
            initAlarms();
            for (int num1 = 0; num1 < vector_Alarms1.Count; ++num1)
                appendAlarms(vector_Alarms1[num1]);
            for (int num1 = 0; num1 < vector_Alarms1.Count; ++num1)
              {
              }
          }


        private void  fromJSONAlarmCriteria(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field AlarmCriteria of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field AlarmCriteria of TypeNativeDataJSON has too few elements.");
            List< AlarmCriteriaJSON  > vector_AlarmCriteria1 = new List< AlarmCriteriaJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                AlarmCriteriaJSON convert_classy = AlarmCriteriaJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_AlarmCriteria1.Add(convert_classy);
              }
            Debug.Assert(vector_AlarmCriteria1.Count >= 1);
            initAlarmCriteria();
            for (int num2 = 0; num2 < vector_AlarmCriteria1.Count; ++num2)
                appendAlarmCriteria(vector_AlarmCriteria1[num2]);
            for (int num1 = 0; num1 < vector_AlarmCriteria1.Count; ++num1)
              {
              }
          }


        public TypeNativeDataJSON()
          {
            flagHasAlarms = false;
            flagHasAlarmCriteria = false;
            storeAlarms = new List< AlarmJSON  >();
            storeAlarmCriteria = new List< AlarmCriteriaJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasAlarms()
          {
            return flagHasAlarms;
          }

        public int  countOfAlarms()
          {
            Debug.Assert(flagHasAlarms);
            return storeAlarms.Count;
          }

        public AlarmJSON   elementOfAlarms(int element_num)
          {
            Debug.Assert(flagHasAlarms);
            return storeAlarms[element_num];
          }

        public List< AlarmJSON  >  getAlarms()
          {
            Debug.Assert(flagHasAlarms);
            return storeAlarms;
          }

        public bool  hasAlarmCriteria()
          {
            return flagHasAlarmCriteria;
          }

        public int  countOfAlarmCriteria()
          {
            Debug.Assert(flagHasAlarmCriteria);
            return storeAlarmCriteria.Count;
          }

        public AlarmCriteriaJSON   elementOfAlarmCriteria(int element_num)
          {
            Debug.Assert(flagHasAlarmCriteria);
            return storeAlarmCriteria[element_num];
          }

        public List< AlarmCriteriaJSON  >  getAlarmCriteria()
          {
            Debug.Assert(flagHasAlarmCriteria);
            return storeAlarmCriteria;
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

        public void initAlarms()
          {
            if (flagHasAlarms)
              {
                for (int num1 = 0; num1 < storeAlarms.Count; ++num1)
                  {
                  }
              }
            flagHasAlarms = true;
            storeAlarms.Clear();
          }
        public void appendAlarms(AlarmJSON  to_append)
          {
            if (!flagHasAlarms)
              {
                flagHasAlarms = true;
                storeAlarms.Clear();
              }
            Debug.Assert(flagHasAlarms);
            storeAlarms.Add(to_append);
          }
        public void unsetAlarms()
          {
            if (flagHasAlarms)
              {
                for (int num2 = 0; num2 < storeAlarms.Count; ++num2)
                  {
                  }
              }
            flagHasAlarms = false;
            storeAlarms.Clear();
          }
        public void initAlarmCriteria()
          {
            if (flagHasAlarmCriteria)
              {
                for (int num3 = 0; num3 < storeAlarmCriteria.Count; ++num3)
                  {
                  }
              }
            flagHasAlarmCriteria = true;
            storeAlarmCriteria.Clear();
          }
        public void appendAlarmCriteria(AlarmCriteriaJSON  to_append)
          {
            if (!flagHasAlarmCriteria)
              {
                flagHasAlarmCriteria = true;
                storeAlarmCriteria.Clear();
              }
            Debug.Assert(flagHasAlarmCriteria);
            storeAlarmCriteria.Add(to_append);
          }
        public void unsetAlarmCriteria()
          {
            if (flagHasAlarmCriteria)
              {
                for (int num4 = 0; num4 < storeAlarmCriteria.Count; ++num4)
                  {
                  }
              }
            flagHasAlarmCriteria = false;
            storeAlarmCriteria.Clear();
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
            if (flagHasAlarms)
              {
                handler.start_pair("Alarms");
                Debug.Assert(storeAlarms.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeAlarms.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeAlarms[num1].write_partial_as_json(handler);
                    else
                        storeAlarms[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasAlarmCriteria)
              {
                handler.start_pair("AlarmCriteria");
                Debug.Assert(storeAlarmCriteria.Count >= 1);
                handler.start_array();
                for (int num2 = 0; num2 < storeAlarmCriteria.Count; ++num2)
                  {
                    if (partial_allowed)
                        storeAlarmCriteria[num2].write_partial_as_json(handler);
                    else
                        storeAlarmCriteria[num2].write_as_json(handler);
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
            private AlarmJSON.HoldingArrayGenerator fieldGeneratorAlarms;
            private AlarmCriteriaJSON.HoldingArrayGenerator fieldGeneratorAlarmCriteria;
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
                if (fieldGeneratorAlarms.have_value)
                  {
                    result.initAlarms();
                    int count = fieldGeneratorAlarms.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendAlarms(fieldGeneratorAlarms.value[num]);
                      }
                    fieldGeneratorAlarms.value.Clear();
                    fieldGeneratorAlarms.have_value = false;
                  }
                if (fieldGeneratorAlarmCriteria.have_value)
                  {
                    result.initAlarmCriteria();
                    int count = fieldGeneratorAlarmCriteria.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendAlarmCriteria(fieldGeneratorAlarmCriteria.value[num]);
                      }
                    fieldGeneratorAlarmCriteria.value.Clear();
                    fieldGeneratorAlarmCriteria.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "Alarm", 0, 5, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'C':
                            if ((String.Compare(field_name, 6, "riteria", 0, 7, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorAlarmCriteria;
                            break;
                        case 's':
                            if (field_name.Length == 6)
                                return fieldGeneratorAlarms;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorAlarms = new AlarmJSON.HoldingArrayGenerator("field \"Alarms\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorAlarmCriteria = new AlarmCriteriaJSON.HoldingArrayGenerator("field \"AlarmCriteria\" of the TypeNativeData class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorAlarms = new AlarmJSON.HoldingArrayGenerator("field \"Alarms\" of the TypeNativeData class", false);
                fieldGeneratorAlarmCriteria = new AlarmCriteriaJSON.HoldingArrayGenerator("field \"AlarmCriteria\" of the TypeNativeData class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorAlarms.reset();
                fieldGeneratorAlarmCriteria.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorAlarms.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAlarmCriteria.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorAlarms.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAlarmCriteria.set_allow_unpolished(new_allow_unpolished);
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
    private bool flagHasDeleteAllDynamicResponse;
    private DynamicResponseJSON  storeDeleteAllDynamicResponse;
    private bool flagHasDeleteSingleDynamicResponse;
    private DynamicResponseJSON  storeDeleteSingleDynamicResponse;
    private bool flagHasDeleteMultiDynamicResponse;
    private DynamicResponseJSON  storeDeleteMultiDynamicResponse;
    private bool flagHasDeleteAllNoMatchDynamicResponse;
    private DynamicResponseJSON  storeDeleteAllNoMatchDynamicResponse;
    private bool flagHasDeleteNoMatchDynamicResponse;
    private DynamicResponseJSON  storeDeleteNoMatchDynamicResponse;
    private bool flagHasDeletePartialMatchDynamicResponse;
    private DynamicResponseJSON  storeDeletePartialMatchDynamicResponse;
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

    private JSONValue  extraDeleteAllDynamicResponseToJSON()
      {
        JSONValueHandler handler_DeleteAllDynamicResponse = new JSONValueHandler();
        storeDeleteAllDynamicResponse.write_as_json(handler_DeleteAllDynamicResponse);
        return handler_DeleteAllDynamicResponse.result;
      }

    private JSONValue  extraDeleteSingleDynamicResponseToJSON()
      {
        JSONValueHandler handler_DeleteSingleDynamicResponse = new JSONValueHandler();
        storeDeleteSingleDynamicResponse.write_as_json(handler_DeleteSingleDynamicResponse);
        return handler_DeleteSingleDynamicResponse.result;
      }

    private JSONValue  extraDeleteMultiDynamicResponseToJSON()
      {
        JSONValueHandler handler_DeleteMultiDynamicResponse = new JSONValueHandler();
        storeDeleteMultiDynamicResponse.write_as_json(handler_DeleteMultiDynamicResponse);
        return handler_DeleteMultiDynamicResponse.result;
      }

    private JSONValue  extraDeleteAllNoMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_DeleteAllNoMatchDynamicResponse = new JSONValueHandler();
        storeDeleteAllNoMatchDynamicResponse.write_as_json(handler_DeleteAllNoMatchDynamicResponse);
        return handler_DeleteAllNoMatchDynamicResponse.result;
      }

    private JSONValue  extraDeleteNoMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_DeleteNoMatchDynamicResponse = new JSONValueHandler();
        storeDeleteNoMatchDynamicResponse.write_as_json(handler_DeleteNoMatchDynamicResponse);
        return handler_DeleteNoMatchDynamicResponse.result;
      }

    private JSONValue  extraDeletePartialMatchDynamicResponseToJSON()
      {
        JSONValueHandler handler_DeletePartialMatchDynamicResponse = new JSONValueHandler();
        storeDeletePartialMatchDynamicResponse.write_as_json(handler_DeletePartialMatchDynamicResponse);
        return handler_DeletePartialMatchDynamicResponse.result;
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


    private void  fromJSONDeleteAllDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDeleteAllDynamicResponse(convert_classy);
      }


    private void  fromJSONDeleteSingleDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDeleteSingleDynamicResponse(convert_classy);
      }


    private void  fromJSONDeleteMultiDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDeleteMultiDynamicResponse(convert_classy);
      }


    private void  fromJSONDeleteAllNoMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDeleteAllNoMatchDynamicResponse(convert_classy);
      }


    private void  fromJSONDeleteNoMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDeleteNoMatchDynamicResponse(convert_classy);
      }


    private void  fromJSONDeletePartialMatchDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setDeletePartialMatchDynamicResponse(convert_classy);
      }


    private void  fromJSONFutureSupportDynamicResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setFutureSupportDynamicResponse(convert_classy);
      }


    public AlarmUnsetCommandJSON()
      {
        flagHasNativeData = false;
        flagHasDeleteAllDynamicResponse = false;
        flagHasDeleteSingleDynamicResponse = false;
        flagHasDeleteMultiDynamicResponse = false;
        flagHasDeleteAllNoMatchDynamicResponse = false;
        flagHasDeleteNoMatchDynamicResponse = false;
        flagHasDeletePartialMatchDynamicResponse = false;
        flagHasFutureSupportDynamicResponse = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getAlarmCommandKind()
      {
        return "AlarmUnsetCommand";
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

    public bool  hasDeleteAllDynamicResponse()
      {
        return flagHasDeleteAllDynamicResponse;
      }

    public DynamicResponseJSON   getDeleteAllDynamicResponse()
      {
        Debug.Assert(flagHasDeleteAllDynamicResponse);
        return storeDeleteAllDynamicResponse;
      }

    public bool  hasDeleteSingleDynamicResponse()
      {
        return flagHasDeleteSingleDynamicResponse;
      }

    public DynamicResponseJSON   getDeleteSingleDynamicResponse()
      {
        Debug.Assert(flagHasDeleteSingleDynamicResponse);
        return storeDeleteSingleDynamicResponse;
      }

    public bool  hasDeleteMultiDynamicResponse()
      {
        return flagHasDeleteMultiDynamicResponse;
      }

    public DynamicResponseJSON   getDeleteMultiDynamicResponse()
      {
        Debug.Assert(flagHasDeleteMultiDynamicResponse);
        return storeDeleteMultiDynamicResponse;
      }

    public bool  hasDeleteAllNoMatchDynamicResponse()
      {
        return flagHasDeleteAllNoMatchDynamicResponse;
      }

    public DynamicResponseJSON   getDeleteAllNoMatchDynamicResponse()
      {
        Debug.Assert(flagHasDeleteAllNoMatchDynamicResponse);
        return storeDeleteAllNoMatchDynamicResponse;
      }

    public bool  hasDeleteNoMatchDynamicResponse()
      {
        return flagHasDeleteNoMatchDynamicResponse;
      }

    public DynamicResponseJSON   getDeleteNoMatchDynamicResponse()
      {
        Debug.Assert(flagHasDeleteNoMatchDynamicResponse);
        return storeDeleteNoMatchDynamicResponse;
      }

    public bool  hasDeletePartialMatchDynamicResponse()
      {
        return flagHasDeletePartialMatchDynamicResponse;
      }

    public DynamicResponseJSON   getDeletePartialMatchDynamicResponse()
      {
        Debug.Assert(flagHasDeletePartialMatchDynamicResponse);
        return storeDeletePartialMatchDynamicResponse;
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


    public virtual int extraAlarmUnsetCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAlarmUnsetCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAlarmUnsetCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAlarmUnsetCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraAlarmCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        if (flagHasDeleteAllDynamicResponse)
            ++result;
        if (flagHasDeleteSingleDynamicResponse)
            ++result;
        if (flagHasDeleteMultiDynamicResponse)
            ++result;
        if (flagHasDeleteAllNoMatchDynamicResponse)
            ++result;
        if (flagHasDeleteNoMatchDynamicResponse)
            ++result;
        if (flagHasDeletePartialMatchDynamicResponse)
            ++result;
        if (flagHasFutureSupportDynamicResponse)
            ++result;
        result += extraAlarmUnsetCommandComponentCount();
        return result;
      }
    public override string extraAlarmCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        if (flagHasDeleteAllDynamicResponse)
          {
            if (remainder == 0)
                return "DeleteAllDynamicResponse";
            --remainder;
          }
        if (flagHasDeleteSingleDynamicResponse)
          {
            if (remainder == 0)
                return "DeleteSingleDynamicResponse";
            --remainder;
          }
        if (flagHasDeleteMultiDynamicResponse)
          {
            if (remainder == 0)
                return "DeleteMultiDynamicResponse";
            --remainder;
          }
        if (flagHasDeleteAllNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return "DeleteAllNoMatchDynamicResponse";
            --remainder;
          }
        if (flagHasDeleteNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return "DeleteNoMatchDynamicResponse";
            --remainder;
          }
        if (flagHasDeletePartialMatchDynamicResponse)
          {
            if (remainder == 0)
                return "DeletePartialMatchDynamicResponse";
            --remainder;
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            if (remainder == 0)
                return "FutureSupportDynamicResponse";
            --remainder;
          }
        return extraAlarmUnsetCommandComponentKey(remainder);
      }
    public override JSONValue extraAlarmCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        if (flagHasDeleteAllDynamicResponse)
          {
            if (remainder == 0)
                return extraDeleteAllDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasDeleteSingleDynamicResponse)
          {
            if (remainder == 0)
                return extraDeleteSingleDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasDeleteMultiDynamicResponse)
          {
            if (remainder == 0)
                return extraDeleteMultiDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasDeleteAllNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraDeleteAllNoMatchDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasDeleteNoMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraDeleteNoMatchDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasDeletePartialMatchDynamicResponse)
          {
            if (remainder == 0)
                return extraDeletePartialMatchDynamicResponseToJSON();
            --remainder;
          }
        if (flagHasFutureSupportDynamicResponse)
          {
            if (remainder == 0)
                return extraFutureSupportDynamicResponseToJSON();
            --remainder;
          }
        return extraAlarmUnsetCommandComponentValue(remainder);
      }
    public override JSONValue extraAlarmCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if (String.Compare(field_name, 1, "elete", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'A':
                            if (String.Compare(field_name, 7, "ll", 0, 2, false) == 0)
                              {
                                switch (field_name[9])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 10, "ynamicResponse", 0, 14, false) == 0) && (field_name.Length == 24))
                                            return (flagHasDeleteAllDynamicResponse ? extraDeleteAllDynamicResponseToJSON() : null);
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 10, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 31))
                                            return (flagHasDeleteAllNoMatchDynamicResponse ? extraDeleteAllNoMatchDynamicResponseToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'M':
                            if ((String.Compare(field_name, 7, "ultiDynamicResponse", 0, 19, false) == 0) && (field_name.Length == 26))
                                return (flagHasDeleteMultiDynamicResponse ? extraDeleteMultiDynamicResponseToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 7, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 28))
                                return (flagHasDeleteNoMatchDynamicResponse ? extraDeleteNoMatchDynamicResponseToJSON() : null);
                            break;
                        case 'P':
                            if ((String.Compare(field_name, 7, "artialMatchDynamicResponse", 0, 26, false) == 0) && (field_name.Length == 33))
                                return (flagHasDeletePartialMatchDynamicResponse ? extraDeletePartialMatchDynamicResponseToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 7, "ingleDynamicResponse", 0, 20, false) == 0) && (field_name.Length == 27))
                                return (flagHasDeleteSingleDynamicResponse ? extraDeleteSingleDynamicResponseToJSON() : null);
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
        return extraAlarmUnsetCommandLookup(field_name);
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
    public void setDeleteAllDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDeleteAllDynamicResponse)
          {
          }
        flagHasDeleteAllDynamicResponse = true;
        storeDeleteAllDynamicResponse = new_value;
      }
    public void unsetDeleteAllDynamicResponse()
      {
        if (flagHasDeleteAllDynamicResponse)
          {
          }
        flagHasDeleteAllDynamicResponse = false;
      }
    public void setDeleteSingleDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDeleteSingleDynamicResponse)
          {
          }
        flagHasDeleteSingleDynamicResponse = true;
        storeDeleteSingleDynamicResponse = new_value;
      }
    public void unsetDeleteSingleDynamicResponse()
      {
        if (flagHasDeleteSingleDynamicResponse)
          {
          }
        flagHasDeleteSingleDynamicResponse = false;
      }
    public void setDeleteMultiDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDeleteMultiDynamicResponse)
          {
          }
        flagHasDeleteMultiDynamicResponse = true;
        storeDeleteMultiDynamicResponse = new_value;
      }
    public void unsetDeleteMultiDynamicResponse()
      {
        if (flagHasDeleteMultiDynamicResponse)
          {
          }
        flagHasDeleteMultiDynamicResponse = false;
      }
    public void setDeleteAllNoMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDeleteAllNoMatchDynamicResponse)
          {
          }
        flagHasDeleteAllNoMatchDynamicResponse = true;
        storeDeleteAllNoMatchDynamicResponse = new_value;
      }
    public void unsetDeleteAllNoMatchDynamicResponse()
      {
        if (flagHasDeleteAllNoMatchDynamicResponse)
          {
          }
        flagHasDeleteAllNoMatchDynamicResponse = false;
      }
    public void setDeleteNoMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDeleteNoMatchDynamicResponse)
          {
          }
        flagHasDeleteNoMatchDynamicResponse = true;
        storeDeleteNoMatchDynamicResponse = new_value;
      }
    public void unsetDeleteNoMatchDynamicResponse()
      {
        if (flagHasDeleteNoMatchDynamicResponse)
          {
          }
        flagHasDeleteNoMatchDynamicResponse = false;
      }
    public void setDeletePartialMatchDynamicResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasDeletePartialMatchDynamicResponse)
          {
          }
        flagHasDeletePartialMatchDynamicResponse = true;
        storeDeletePartialMatchDynamicResponse = new_value;
      }
    public void unsetDeletePartialMatchDynamicResponse()
      {
        if (flagHasDeletePartialMatchDynamicResponse)
          {
          }
        flagHasDeletePartialMatchDynamicResponse = false;
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

    public virtual void extraAlarmUnsetCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAlarmUnsetCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAlarmUnsetCommandLookup(key);
        if (old_field == null)
          {
            extraAlarmUnsetCommandAppendPair(key, new_component);
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
    public override void extraAlarmCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if (String.Compare(key, 1, "elete", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'A':
                            if (String.Compare(key, 7, "ll", 0, 2, false) == 0)
                              {
                                switch (key[9])
                                  {
                                    case 'D':
                                        if ((String.Compare(key, 10, "ynamicResponse", 0, 14, false) == 0) && (key.Length == 24))
                                            {
                                            fromJSONDeleteAllDynamicResponse(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'N':
                                        if ((String.Compare(key, 10, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 31))
                                            {
                                            fromJSONDeleteAllNoMatchDynamicResponse(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'M':
                            if ((String.Compare(key, 7, "ultiDynamicResponse", 0, 19, false) == 0) && (key.Length == 26))
                                {
                                fromJSONDeleteMultiDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 7, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 28))
                                {
                                fromJSONDeleteNoMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 7, "artialMatchDynamicResponse", 0, 26, false) == 0) && (key.Length == 33))
                                {
                                fromJSONDeletePartialMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 7, "ingleDynamicResponse", 0, 20, false) == 0) && (key.Length == 27))
                                {
                                fromJSONDeleteSingleDynamicResponse(new_component, false);
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
        extraAlarmUnsetCommandAppendPair(key, new_component);
      }
    public override void extraAlarmCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if (String.Compare(key, 1, "elete", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'A':
                            if (String.Compare(key, 7, "ll", 0, 2, false) == 0)
                              {
                                switch (key[9])
                                  {
                                    case 'D':
                                        if ((String.Compare(key, 10, "ynamicResponse", 0, 14, false) == 0) && (key.Length == 24))
                                            {
                                            fromJSONDeleteAllDynamicResponse(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'N':
                                        if ((String.Compare(key, 10, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 31))
                                            {
                                            fromJSONDeleteAllNoMatchDynamicResponse(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'M':
                            if ((String.Compare(key, 7, "ultiDynamicResponse", 0, 19, false) == 0) && (key.Length == 26))
                                {
                                fromJSONDeleteMultiDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 7, "oMatchDynamicResponse", 0, 21, false) == 0) && (key.Length == 28))
                                {
                                fromJSONDeleteNoMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 7, "artialMatchDynamicResponse", 0, 26, false) == 0) && (key.Length == 33))
                                {
                                fromJSONDeletePartialMatchDynamicResponse(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 7, "ingleDynamicResponse", 0, 20, false) == 0) && (key.Length == 27))
                                {
                                fromJSONDeleteSingleDynamicResponse(new_component, false);
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
        extraAlarmUnsetCommandSetField(key, new_component);
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
        if (flagHasDeleteAllDynamicResponse)
          {
            handler.start_pair("DeleteAllDynamicResponse");
            if (partial_allowed)
                storeDeleteAllDynamicResponse.write_partial_as_json(handler);
            else
                storeDeleteAllDynamicResponse.write_as_json(handler);
          }
        if (flagHasDeleteSingleDynamicResponse)
          {
            handler.start_pair("DeleteSingleDynamicResponse");
            if (partial_allowed)
                storeDeleteSingleDynamicResponse.write_partial_as_json(handler);
            else
                storeDeleteSingleDynamicResponse.write_as_json(handler);
          }
        if (flagHasDeleteMultiDynamicResponse)
          {
            handler.start_pair("DeleteMultiDynamicResponse");
            if (partial_allowed)
                storeDeleteMultiDynamicResponse.write_partial_as_json(handler);
            else
                storeDeleteMultiDynamicResponse.write_as_json(handler);
          }
        if (flagHasDeleteAllNoMatchDynamicResponse)
          {
            handler.start_pair("DeleteAllNoMatchDynamicResponse");
            if (partial_allowed)
                storeDeleteAllNoMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeDeleteAllNoMatchDynamicResponse.write_as_json(handler);
          }
        if (flagHasDeleteNoMatchDynamicResponse)
          {
            handler.start_pair("DeleteNoMatchDynamicResponse");
            if (partial_allowed)
                storeDeleteNoMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeDeleteNoMatchDynamicResponse.write_as_json(handler);
          }
        if (flagHasDeletePartialMatchDynamicResponse)
          {
            handler.start_pair("DeletePartialMatchDynamicResponse");
            if (partial_allowed)
                storeDeletePartialMatchDynamicResponse.write_partial_as_json(handler);
            else
                storeDeletePartialMatchDynamicResponse.write_as_json(handler);
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

    public static new AlarmUnsetCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AlarmUnsetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlarmUnsetCommand", ignore_extras);
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
    public static new AlarmUnsetCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AlarmUnsetCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AlarmUnsetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlarmUnsetCommand", ignore_extras);
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
    public static new AlarmUnsetCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AlarmUnsetCommandJSON from_text(string text, bool ignore_extras)
      {
        AlarmUnsetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlarmUnsetCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AlarmUnsetCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AlarmUnsetCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AlarmUnsetCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlarmUnsetCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : AlarmCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDeleteAllDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDeleteSingleDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDeleteMultiDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDeleteAllNoMatchDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDeleteNoMatchDynamicResponse;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorDeletePartialMatchDynamicResponse;
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
            if (!(getAlarmCommandJSONKey().Equals("AlarmUnsetCommand")))
                throw new Exception("The key field has a value other than `AlarmUnsetCommand'.");
            AlarmUnsetCommandJSON result = new AlarmUnsetCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAlarmUnsetCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(AlarmCommandJSON new_result)
          {
            handle_result((AlarmUnsetCommandJSON )new_result);
          }
        protected void finish(AlarmUnsetCommandJSON result)
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
            if (fieldGeneratorDeleteAllDynamicResponse.have_value)
              {
                result.setDeleteAllDynamicResponse(fieldGeneratorDeleteAllDynamicResponse.value);
                fieldGeneratorDeleteAllDynamicResponse.have_value = false;
              }
            if (fieldGeneratorDeleteSingleDynamicResponse.have_value)
              {
                result.setDeleteSingleDynamicResponse(fieldGeneratorDeleteSingleDynamicResponse.value);
                fieldGeneratorDeleteSingleDynamicResponse.have_value = false;
              }
            if (fieldGeneratorDeleteMultiDynamicResponse.have_value)
              {
                result.setDeleteMultiDynamicResponse(fieldGeneratorDeleteMultiDynamicResponse.value);
                fieldGeneratorDeleteMultiDynamicResponse.have_value = false;
              }
            if (fieldGeneratorDeleteAllNoMatchDynamicResponse.have_value)
              {
                result.setDeleteAllNoMatchDynamicResponse(fieldGeneratorDeleteAllNoMatchDynamicResponse.value);
                fieldGeneratorDeleteAllNoMatchDynamicResponse.have_value = false;
              }
            if (fieldGeneratorDeleteNoMatchDynamicResponse.have_value)
              {
                result.setDeleteNoMatchDynamicResponse(fieldGeneratorDeleteNoMatchDynamicResponse.value);
                fieldGeneratorDeleteNoMatchDynamicResponse.have_value = false;
              }
            if (fieldGeneratorDeletePartialMatchDynamicResponse.have_value)
              {
                result.setDeletePartialMatchDynamicResponse(fieldGeneratorDeletePartialMatchDynamicResponse.value);
                fieldGeneratorDeletePartialMatchDynamicResponse.have_value = false;
              }
            if (fieldGeneratorFutureSupportDynamicResponse.have_value)
              {
                result.setFutureSupportDynamicResponse(fieldGeneratorFutureSupportDynamicResponse.value);
                fieldGeneratorFutureSupportDynamicResponse.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(AlarmUnsetCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "elete", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'A':
                                if (String.Compare(field_name, 7, "ll", 0, 2, false) == 0)
                                  {
                                    switch (field_name[9])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 10, "ynamicResponse", 0, 14, false) == 0) && (field_name.Length == 24))
                                                return fieldGeneratorDeleteAllDynamicResponse;
                                            break;
                                        case 'N':
                                            if ((String.Compare(field_name, 10, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 31))
                                                return fieldGeneratorDeleteAllNoMatchDynamicResponse;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 7, "ultiDynamicResponse", 0, 19, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorDeleteMultiDynamicResponse;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 7, "oMatchDynamicResponse", 0, 21, false) == 0) && (field_name.Length == 28))
                                    return fieldGeneratorDeleteNoMatchDynamicResponse;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 7, "artialMatchDynamicResponse", 0, 26, false) == 0) && (field_name.Length == 33))
                                    return fieldGeneratorDeletePartialMatchDynamicResponse;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 7, "ingleDynamicResponse", 0, 20, false) == 0) && (field_name.Length == 27))
                                    return fieldGeneratorDeleteSingleDynamicResponse;
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
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the AlarmUnsetCommand class", ignore_extras);
            fieldGeneratorDeleteAllDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeleteAllDynamicResponse\" of the AlarmUnsetCommand class", ignore_extras);
            fieldGeneratorDeleteSingleDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeleteSingleDynamicResponse\" of the AlarmUnsetCommand class", ignore_extras);
            fieldGeneratorDeleteMultiDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeleteMultiDynamicResponse\" of the AlarmUnsetCommand class", ignore_extras);
            fieldGeneratorDeleteAllNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeleteAllNoMatchDynamicResponse\" of the AlarmUnsetCommand class", ignore_extras);
            fieldGeneratorDeleteNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeleteNoMatchDynamicResponse\" of the AlarmUnsetCommand class", ignore_extras);
            fieldGeneratorDeletePartialMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeletePartialMatchDynamicResponse\" of the AlarmUnsetCommand class", ignore_extras);
            fieldGeneratorFutureSupportDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"FutureSupportDynamicResponse\" of the AlarmUnsetCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AlarmUnsetCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the AlarmUnsetCommand class", false);
            fieldGeneratorDeleteAllDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeleteAllDynamicResponse\" of the AlarmUnsetCommand class", false);
            fieldGeneratorDeleteSingleDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeleteSingleDynamicResponse\" of the AlarmUnsetCommand class", false);
            fieldGeneratorDeleteMultiDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeleteMultiDynamicResponse\" of the AlarmUnsetCommand class", false);
            fieldGeneratorDeleteAllNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeleteAllNoMatchDynamicResponse\" of the AlarmUnsetCommand class", false);
            fieldGeneratorDeleteNoMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeleteNoMatchDynamicResponse\" of the AlarmUnsetCommand class", false);
            fieldGeneratorDeletePartialMatchDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"DeletePartialMatchDynamicResponse\" of the AlarmUnsetCommand class", false);
            fieldGeneratorFutureSupportDynamicResponse = new DynamicResponseJSON.HoldingGenerator("field \"FutureSupportDynamicResponse\" of the AlarmUnsetCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AlarmUnsetCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            fieldGeneratorDeleteAllDynamicResponse.reset();
            fieldGeneratorDeleteSingleDynamicResponse.reset();
            fieldGeneratorDeleteMultiDynamicResponse.reset();
            fieldGeneratorDeleteAllNoMatchDynamicResponse.reset();
            fieldGeneratorDeleteNoMatchDynamicResponse.reset();
            fieldGeneratorDeletePartialMatchDynamicResponse.reset();
            fieldGeneratorFutureSupportDynamicResponse.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AlarmUnsetCommandJSON  result)
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
        public AlarmUnsetCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AlarmUnsetCommandJSON  result)
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
    protected virtual void handle_result(List<AlarmUnsetCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AlarmUnsetCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AlarmUnsetCommandJSON>();
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
    public List<AlarmUnsetCommandJSON> value;
  };
  };
