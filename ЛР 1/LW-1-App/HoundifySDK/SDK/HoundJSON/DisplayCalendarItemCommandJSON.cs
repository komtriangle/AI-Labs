/* file "DisplayCalendarItemCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DisplayCalendarItemCommandJSON : CalendarCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasEventIDs;
        private List< string > storeEventIDs;
        private bool flagHasQuery;
        private CalendarQueryJSON  storeQuery;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONEventIDs(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field EventIDs of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field EventIDs of TypeNativeDataJSON has too few elements.");
            List< string > vector_EventIDs1 = new List< string >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONStringValue json_string = json_array1.component(num1).string_value();
                if (json_string == null)
                    throw new Exception("The value for an element of field EventIDs of TypeNativeDataJSON is not a string.");
                vector_EventIDs1.Add(json_string.getData());
              }
            Debug.Assert(vector_EventIDs1.Count >= 1);
            initEventIDs();
            for (int num1 = 0; num1 < vector_EventIDs1.Count; ++num1)
                appendEventIDs(vector_EventIDs1[num1]);
            for (int num1 = 0; num1 < vector_EventIDs1.Count; ++num1)
              {
              }
          }


        private void  fromJSONQuery(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            CalendarQueryJSON convert_classy = CalendarQueryJSON.from_json(json_value, ignore_extras, true);
            setQuery(convert_classy);
          }


        public TypeNativeDataJSON()
          {
            flagHasEventIDs = false;
            flagHasQuery = false;
            storeEventIDs = new List< string >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasEventIDs()
          {
            return flagHasEventIDs;
          }

        public int  countOfEventIDs()
          {
            Debug.Assert(flagHasEventIDs);
            return storeEventIDs.Count;
          }

        public string  elementOfEventIDs(int element_num)
          {
            Debug.Assert(flagHasEventIDs);
            return storeEventIDs[element_num];
          }

        public List< string >  getEventIDs()
          {
            Debug.Assert(flagHasEventIDs);
            return storeEventIDs;
          }

        public bool  hasQuery()
          {
            return flagHasQuery;
          }

        public CalendarQueryJSON   getQuery()
          {
            Debug.Assert(flagHasQuery);
            return storeQuery;
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

        public void initEventIDs()
          {
            flagHasEventIDs = true;
            storeEventIDs.Clear();
          }
        public void appendEventIDs(string to_append)
          {
            if (!flagHasEventIDs)
              {
                flagHasEventIDs = true;
                storeEventIDs.Clear();
              }
            Debug.Assert(flagHasEventIDs);
            storeEventIDs.Add(to_append);
          }
        public void unsetEventIDs()
          {
            flagHasEventIDs = false;
            storeEventIDs.Clear();
          }
        public void setQuery(CalendarQueryJSON  new_value)
          {
            if (flagHasQuery)
              {
              }
            flagHasQuery = true;
            storeQuery = new_value;
          }
        public void unsetQuery()
          {
            if (flagHasQuery)
              {
              }
            flagHasQuery = false;
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
            if (flagHasEventIDs)
              {
                handler.start_pair("EventIDs");
                Debug.Assert(storeEventIDs.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeEventIDs.Count; ++num1)
                  {
                    handler.string_value(storeEventIDs[num1]);
                  }
                handler.finish_array();
              }
            if (flagHasQuery)
              {
                handler.start_pair("Query");
                if (partial_allowed)
                    storeQuery.write_partial_as_json(handler);
                else
                    storeQuery.write_as_json(handler);
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
            private JSONHoldingStringArrayGenerator fieldGeneratorEventIDs;
            private CalendarQueryJSON.HoldingGenerator fieldGeneratorQuery;
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
                if (fieldGeneratorEventIDs.have_value)
                  {
                    result.initEventIDs();
                    int count = fieldGeneratorEventIDs.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendEventIDs(fieldGeneratorEventIDs.value[num]);
                      }
                    fieldGeneratorEventIDs.value.Clear();
                    fieldGeneratorEventIDs.have_value = false;
                  }
                if (fieldGeneratorQuery.have_value)
                  {
                    result.setQuery(fieldGeneratorQuery.value);
                    fieldGeneratorQuery.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'E':
                        if ((String.Compare(field_name, 1, "ventIDs", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorEventIDs;
                        break;
                    case 'Q':
                        if ((String.Compare(field_name, 1, "uery", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorQuery;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorEventIDs = new JSONHoldingStringArrayGenerator("field \"EventIDs\" of the TypeNativeData class");
                fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the TypeNativeData class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorEventIDs = new JSONHoldingStringArrayGenerator("field \"EventIDs\" of the TypeNativeData class");
                fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the TypeNativeData class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorEventIDs.reset();
                fieldGeneratorQuery.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorQuery.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorQuery.set_allow_unpolished(new_allow_unpolished);
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
    private bool flagHasUserRequest;
    private CalendarUserRequestJSON  storeUserRequest;
    private bool flagHasEventIDs;
    private List< string > storeEventIDs;
    private bool flagHasQuery;
    private CalendarQueryJSON  storeQuery;
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private bool flagHasCalendarPreferenceIsNotSetResult;
    private DynamicResponseJSON  storeCalendarPreferenceIsNotSetResult;
    private bool flagHasNoMatchResult;
    private DynamicResponseJSON  storeNoMatchResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUserRequestToJSON()
      {
        JSONValueHandler handler_UserRequest = new JSONValueHandler();
        storeUserRequest.write_as_json(handler_UserRequest);
        return handler_UserRequest.result;
      }

    private JSONValue  extraEventIDsToJSON()
      {
        JSONArrayValue generated_array_1_EventIDs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeEventIDs.Count; ++num1)
          {
            JSONStringValue generated_string_EventIDs = new JSONStringValue(storeEventIDs[num1]);
            generated_array_1_EventIDs.appendComponent(generated_string_EventIDs);
          }
        return generated_array_1_EventIDs;
      }

    private JSONValue  extraQueryToJSON()
      {
        JSONValueHandler handler_Query = new JSONValueHandler();
        storeQuery.write_as_json(handler_Query);
        return handler_Query.result;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }

    private JSONValue  extraCalendarPreferenceIsNotSetResultToJSON()
      {
        JSONValueHandler handler_CalendarPreferenceIsNotSetResult = new JSONValueHandler();
        storeCalendarPreferenceIsNotSetResult.write_as_json(handler_CalendarPreferenceIsNotSetResult);
        return handler_CalendarPreferenceIsNotSetResult.result;
      }

    private JSONValue  extraNoMatchResultToJSON()
      {
        JSONValueHandler handler_NoMatchResult = new JSONValueHandler();
        storeNoMatchResult.write_as_json(handler_NoMatchResult);
        return handler_NoMatchResult.result;
      }


    private void  fromJSONUserRequest(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarUserRequestJSON convert_classy = CalendarUserRequestJSON.from_json(json_value, ignore_extras, true);
        setUserRequest(convert_classy);
      }


    private void  fromJSONEventIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field EventIDs of DisplayCalendarItemCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field EventIDs of DisplayCalendarItemCommandJSON has too few elements.");
        List< string > vector_EventIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field EventIDs of DisplayCalendarItemCommandJSON is not a string.");
            vector_EventIDs1.Add(json_string.getData());
          }
        Debug.Assert(vector_EventIDs1.Count >= 1);
        initEventIDs();
        for (int num2 = 0; num2 < vector_EventIDs1.Count; ++num2)
            appendEventIDs(vector_EventIDs1[num2]);
        for (int num1 = 0; num1 < vector_EventIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONQuery(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarQueryJSON convert_classy = CalendarQueryJSON.from_json(json_value, ignore_extras, true);
        setQuery(convert_classy);
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    private void  fromJSONCalendarPreferenceIsNotSetResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setCalendarPreferenceIsNotSetResult(convert_classy);
      }


    private void  fromJSONNoMatchResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setNoMatchResult(convert_classy);
      }


    public DisplayCalendarItemCommandJSON()
      {
        flagHasUserRequest = false;
        flagHasEventIDs = false;
        flagHasQuery = false;
        flagHasNativeData = false;
        flagHasCalendarPreferenceIsNotSetResult = false;
        flagHasNoMatchResult = false;
        storeEventIDs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCalendarCommandKind()
      {
        return "DisplayItem";
      }

    public bool  hasUserRequest()
      {
        return flagHasUserRequest;
      }

    public CalendarUserRequestJSON   getUserRequest()
      {
        Debug.Assert(flagHasUserRequest);
        return storeUserRequest;
      }

    public bool  hasEventIDs()
      {
        return flagHasEventIDs;
      }

    public int  countOfEventIDs()
      {
        Debug.Assert(flagHasEventIDs);
        return storeEventIDs.Count;
      }

    public string  elementOfEventIDs(int element_num)
      {
        Debug.Assert(flagHasEventIDs);
        return storeEventIDs[element_num];
      }

    public List< string >  getEventIDs()
      {
        Debug.Assert(flagHasEventIDs);
        return storeEventIDs;
      }

    public bool  hasQuery()
      {
        return flagHasQuery;
      }

    public CalendarQueryJSON   getQuery()
      {
        Debug.Assert(flagHasQuery);
        return storeQuery;
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

    public bool  hasCalendarPreferenceIsNotSetResult()
      {
        return flagHasCalendarPreferenceIsNotSetResult;
      }

    public DynamicResponseJSON   getCalendarPreferenceIsNotSetResult()
      {
        Debug.Assert(flagHasCalendarPreferenceIsNotSetResult);
        return storeCalendarPreferenceIsNotSetResult;
      }

    public bool  hasNoMatchResult()
      {
        return flagHasNoMatchResult;
      }

    public DynamicResponseJSON   getNoMatchResult()
      {
        Debug.Assert(flagHasNoMatchResult);
        return storeNoMatchResult;
      }


    public virtual int extraDisplayCalendarItemCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDisplayCalendarItemCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDisplayCalendarItemCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDisplayCalendarItemCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCalendarCommandComponentCount()
      {
        int result = 0;
        if (flagHasUserRequest)
            ++result;
        if (flagHasEventIDs)
            ++result;
        if (flagHasQuery)
            ++result;
        if (flagHasNativeData)
            ++result;
        if (flagHasCalendarPreferenceIsNotSetResult)
            ++result;
        if (flagHasNoMatchResult)
            ++result;
        result += extraDisplayCalendarItemCommandComponentCount();
        return result;
      }
    public override string extraCalendarCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserRequest)
          {
            if (remainder == 0)
                return "UserRequest";
            --remainder;
          }
        if (flagHasEventIDs)
          {
            if (remainder == 0)
                return "EventIDs";
            --remainder;
          }
        if (flagHasQuery)
          {
            if (remainder == 0)
                return "Query";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
            if (remainder == 0)
                return "CalendarPreferenceIsNotSetResult";
            --remainder;
          }
        if (flagHasNoMatchResult)
          {
            if (remainder == 0)
                return "NoMatchResult";
            --remainder;
          }
        return extraDisplayCalendarItemCommandComponentKey(remainder);
      }
    public override JSONValue extraCalendarCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserRequest)
          {
            if (remainder == 0)
                return extraUserRequestToJSON();
            --remainder;
          }
        if (flagHasEventIDs)
          {
            if (remainder == 0)
                return extraEventIDsToJSON();
            --remainder;
          }
        if (flagHasQuery)
          {
            if (remainder == 0)
                return extraQueryToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
            if (remainder == 0)
                return extraCalendarPreferenceIsNotSetResultToJSON();
            --remainder;
          }
        if (flagHasNoMatchResult)
          {
            if (remainder == 0)
                return extraNoMatchResultToJSON();
            --remainder;
          }
        return extraDisplayCalendarItemCommandComponentValue(remainder);
      }
    public override JSONValue extraCalendarCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (field_name.Length == 32))
                    return (flagHasCalendarPreferenceIsNotSetResult ? extraCalendarPreferenceIsNotSetResultToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "ventIDs", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasEventIDs ? extraEventIDsToJSON() : null);
                break;
            case 'N':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                            return (flagHasNativeData ? extraNativeDataToJSON() : null);
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "MatchResult", 0, 11, false) == 0) && (field_name.Length == 13))
                            return (flagHasNoMatchResult ? extraNoMatchResultToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "uery", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasQuery ? extraQueryToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serRequest", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasUserRequest ? extraUserRequestToJSON() : null);
                break;
            default:
                break;
          }
        return extraDisplayCalendarItemCommandLookup(field_name);
      }

    public void setUserRequest(CalendarUserRequestJSON  new_value)
      {
        if (flagHasUserRequest)
          {
          }
        flagHasUserRequest = true;
        storeUserRequest = new_value;
      }
    public void unsetUserRequest()
      {
        if (flagHasUserRequest)
          {
          }
        flagHasUserRequest = false;
      }
    public void initEventIDs()
      {
        flagHasEventIDs = true;
        storeEventIDs.Clear();
      }
    public void appendEventIDs(string to_append)
      {
        if (!flagHasEventIDs)
          {
            flagHasEventIDs = true;
            storeEventIDs.Clear();
          }
        Debug.Assert(flagHasEventIDs);
        storeEventIDs.Add(to_append);
      }
    public void unsetEventIDs()
      {
        flagHasEventIDs = false;
        storeEventIDs.Clear();
      }
    public void setQuery(CalendarQueryJSON  new_value)
      {
        if (flagHasQuery)
          {
          }
        flagHasQuery = true;
        storeQuery = new_value;
      }
    public void unsetQuery()
      {
        if (flagHasQuery)
          {
          }
        flagHasQuery = false;
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
    public void setCalendarPreferenceIsNotSetResult(DynamicResponseJSON  new_value)
      {
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
          }
        flagHasCalendarPreferenceIsNotSetResult = true;
        storeCalendarPreferenceIsNotSetResult = new_value;
      }
    public void unsetCalendarPreferenceIsNotSetResult()
      {
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
          }
        flagHasCalendarPreferenceIsNotSetResult = false;
      }
    public void setNoMatchResult(DynamicResponseJSON  new_value)
      {
        if (flagHasNoMatchResult)
          {
          }
        flagHasNoMatchResult = true;
        storeNoMatchResult = new_value;
      }
    public void unsetNoMatchResult()
      {
        if (flagHasNoMatchResult)
          {
          }
        flagHasNoMatchResult = false;
      }

    public virtual void extraDisplayCalendarItemCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDisplayCalendarItemCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDisplayCalendarItemCommandLookup(key);
        if (old_field == null)
          {
            extraDisplayCalendarItemCommandAppendPair(key, new_component);
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
    public override void extraCalendarCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (key.Length == 32))
                    {
                    fromJSONCalendarPreferenceIsNotSetResult(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "ventIDs", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONEventIDs(new_component, false);
                    return;
                    }
                break;
            case 'N':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONNativeData(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "MatchResult", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONNoMatchResult(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "uery", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONQuery(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serRequest", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONUserRequest(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDisplayCalendarItemCommandAppendPair(key, new_component);
      }
    public override void extraCalendarCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (key.Length == 32))
                    {
                    fromJSONCalendarPreferenceIsNotSetResult(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "ventIDs", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONEventIDs(new_component, false);
                    return;
                    }
                break;
            case 'N':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONNativeData(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "MatchResult", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONNoMatchResult(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "uery", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONQuery(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serRequest", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONUserRequest(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDisplayCalendarItemCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUserRequest);
        if (flagHasUserRequest)
          {
            handler.start_pair("UserRequest");
            if (partial_allowed)
                storeUserRequest.write_partial_as_json(handler);
            else
                storeUserRequest.write_as_json(handler);
          }
        if (flagHasEventIDs)
          {
            handler.start_pair("EventIDs");
            Debug.Assert(storeEventIDs.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeEventIDs.Count; ++num1)
              {
                handler.string_value(storeEventIDs[num1]);
              }
            handler.finish_array();
          }
        if (flagHasQuery)
          {
            handler.start_pair("Query");
            if (partial_allowed)
                storeQuery.write_partial_as_json(handler);
            else
                storeQuery.write_as_json(handler);
          }
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
          }
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
            handler.start_pair("CalendarPreferenceIsNotSetResult");
            if (partial_allowed)
                storeCalendarPreferenceIsNotSetResult.write_partial_as_json(handler);
            else
                storeCalendarPreferenceIsNotSetResult.write_as_json(handler);
          }
        if (flagHasNoMatchResult)
          {
            handler.start_pair("NoMatchResult");
            if (partial_allowed)
                storeNoMatchResult.write_partial_as_json(handler);
            else
                storeNoMatchResult.write_as_json(handler);
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
        if (!(hasUserRequest()))
          {
            return "When parsing the object for %what%, the \"UserRequest\" field was missing.";
          }
        return null;
      }

    public static new DisplayCalendarItemCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisplayCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayCalendarItemCommand", ignore_extras);
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
    public static new DisplayCalendarItemCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisplayCalendarItemCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisplayCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayCalendarItemCommand", ignore_extras);
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
    public static new DisplayCalendarItemCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisplayCalendarItemCommandJSON from_text(string text, bool ignore_extras)
      {
        DisplayCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayCalendarItemCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DisplayCalendarItemCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DisplayCalendarItemCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DisplayCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayCalendarItemCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CalendarCommandJSON.Generator
      {
        private CalendarUserRequestJSON.HoldingGenerator fieldGeneratorUserRequest;
        private JSONHoldingStringArrayGenerator fieldGeneratorEventIDs;
        private CalendarQueryJSON.HoldingGenerator fieldGeneratorQuery;
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorCalendarPreferenceIsNotSetResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorNoMatchResult;
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
            if (!(getCalendarCommandJSONKey().Equals("DisplayItem")))
                throw new Exception("The key field has a value other than `DisplayItem'.");
            DisplayCalendarItemCommandJSON result = new DisplayCalendarItemCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDisplayCalendarItemCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CalendarCommandJSON new_result)
          {
            handle_result((DisplayCalendarItemCommandJSON )new_result);
          }
        protected void finish(DisplayCalendarItemCommandJSON result)
          {
            if (fieldGeneratorUserRequest.have_value)
              {
                result.setUserRequest(fieldGeneratorUserRequest.value);
                fieldGeneratorUserRequest.have_value = false;
              }
            else if ((!(result.hasUserRequest())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UserRequest\" field was missing.");
              }
            if (fieldGeneratorEventIDs.have_value)
              {
                result.initEventIDs();
                int count = fieldGeneratorEventIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEventIDs(fieldGeneratorEventIDs.value[num]);
                  }
                fieldGeneratorEventIDs.value.Clear();
                fieldGeneratorEventIDs.have_value = false;
              }
            if (fieldGeneratorQuery.have_value)
              {
                result.setQuery(fieldGeneratorQuery.value);
                fieldGeneratorQuery.have_value = false;
              }
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            if (fieldGeneratorCalendarPreferenceIsNotSetResult.have_value)
              {
                result.setCalendarPreferenceIsNotSetResult(fieldGeneratorCalendarPreferenceIsNotSetResult.value);
                fieldGeneratorCalendarPreferenceIsNotSetResult.have_value = false;
              }
            if (fieldGeneratorNoMatchResult.have_value)
              {
                result.setNoMatchResult(fieldGeneratorNoMatchResult.value);
                fieldGeneratorNoMatchResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(DisplayCalendarItemCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (field_name.Length == 32))
                        return fieldGeneratorCalendarPreferenceIsNotSetResult;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ventIDs", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorEventIDs;
                    break;
                case 'N':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorNativeData;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "MatchResult", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorNoMatchResult;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uery", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorQuery;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serRequest", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorUserRequest;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUserRequest = new CalendarUserRequestJSON.HoldingGenerator("field \"UserRequest\" of the DisplayCalendarItemCommand class", ignore_extras);
            fieldGeneratorEventIDs = new JSONHoldingStringArrayGenerator("field \"EventIDs\" of the DisplayCalendarItemCommand class");
            fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the DisplayCalendarItemCommand class", ignore_extras);
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the DisplayCalendarItemCommand class", ignore_extras);
            fieldGeneratorCalendarPreferenceIsNotSetResult = new DynamicResponseJSON.HoldingGenerator("field \"CalendarPreferenceIsNotSetResult\" of the DisplayCalendarItemCommand class", ignore_extras);
            fieldGeneratorNoMatchResult = new DynamicResponseJSON.HoldingGenerator("field \"NoMatchResult\" of the DisplayCalendarItemCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DisplayCalendarItemCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUserRequest = new CalendarUserRequestJSON.HoldingGenerator("field \"UserRequest\" of the DisplayCalendarItemCommand class", false);
            fieldGeneratorEventIDs = new JSONHoldingStringArrayGenerator("field \"EventIDs\" of the DisplayCalendarItemCommand class");
            fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the DisplayCalendarItemCommand class", false);
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the DisplayCalendarItemCommand class", false);
            fieldGeneratorCalendarPreferenceIsNotSetResult = new DynamicResponseJSON.HoldingGenerator("field \"CalendarPreferenceIsNotSetResult\" of the DisplayCalendarItemCommand class", false);
            fieldGeneratorNoMatchResult = new DynamicResponseJSON.HoldingGenerator("field \"NoMatchResult\" of the DisplayCalendarItemCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DisplayCalendarItemCommand class");
          }

        public override void reset()
          {
            fieldGeneratorUserRequest.reset();
            fieldGeneratorEventIDs.reset();
            fieldGeneratorQuery.reset();
            fieldGeneratorNativeData.reset();
            fieldGeneratorCalendarPreferenceIsNotSetResult.reset();
            fieldGeneratorNoMatchResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DisplayCalendarItemCommandJSON  result)
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
        public DisplayCalendarItemCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DisplayCalendarItemCommandJSON  result)
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
    protected virtual void handle_result(List<DisplayCalendarItemCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DisplayCalendarItemCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DisplayCalendarItemCommandJSON>();
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
    public List<DisplayCalendarItemCommandJSON> value;
  };
  };
