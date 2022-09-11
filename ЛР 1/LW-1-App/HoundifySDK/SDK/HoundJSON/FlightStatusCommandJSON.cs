/* file "FlightStatusCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightStatusCommandJSON : CommandResultJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasCurrentDateAndTime;
        private FlightTimesJSON  storeCurrentDateAndTime;
        private bool flagHasFlightTravelLocationForClient;
        private FlightTravelLocationJSON  storeFlightTravelLocationForClient;
        private bool flagHasFlightStatusSearchResults;
        private List< FlightStatusSearchResultJSON  > storeFlightStatusSearchResults;


        private void  fromJSONCurrentDateAndTime(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
            setCurrentDateAndTime(convert_classy);
          }


        private void  fromJSONFlightTravelLocationForClient(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            FlightTravelLocationJSON convert_classy = FlightTravelLocationJSON.from_json(json_value, ignore_extras, true);
            setFlightTravelLocationForClient(convert_classy);
          }


        private void  fromJSONFlightStatusSearchResults(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field FlightStatusSearchResults of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< FlightStatusSearchResultJSON  > vector_FlightStatusSearchResults1 = new List< FlightStatusSearchResultJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                FlightStatusSearchResultJSON convert_classy = FlightStatusSearchResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_FlightStatusSearchResults1.Add(convert_classy);
              }
            initFlightStatusSearchResults();
            for (int num1 = 0; num1 < vector_FlightStatusSearchResults1.Count; ++num1)
                appendFlightStatusSearchResults(vector_FlightStatusSearchResults1[num1]);
            for (int num1 = 0; num1 < vector_FlightStatusSearchResults1.Count; ++num1)
              {
              }
          }


        public TypeNativeDataJSON()
          {
            flagHasCurrentDateAndTime = false;
            flagHasFlightTravelLocationForClient = false;
            flagHasFlightStatusSearchResults = false;
            storeFlightStatusSearchResults = new List< FlightStatusSearchResultJSON  >();
          }

        public bool  hasCurrentDateAndTime()
          {
            return flagHasCurrentDateAndTime;
          }

        public FlightTimesJSON   getCurrentDateAndTime()
          {
            Debug.Assert(flagHasCurrentDateAndTime);
            return storeCurrentDateAndTime;
          }

        public bool  hasFlightTravelLocationForClient()
          {
            return flagHasFlightTravelLocationForClient;
          }

        public FlightTravelLocationJSON   getFlightTravelLocationForClient()
          {
            Debug.Assert(flagHasFlightTravelLocationForClient);
            return storeFlightTravelLocationForClient;
          }

        public bool  hasFlightStatusSearchResults()
          {
            return flagHasFlightStatusSearchResults;
          }

        public int  countOfFlightStatusSearchResults()
          {
            Debug.Assert(flagHasFlightStatusSearchResults);
            return storeFlightStatusSearchResults.Count;
          }

        public FlightStatusSearchResultJSON   elementOfFlightStatusSearchResults(int element_num)
          {
            Debug.Assert(flagHasFlightStatusSearchResults);
            return storeFlightStatusSearchResults[element_num];
          }

        public List< FlightStatusSearchResultJSON  >  getFlightStatusSearchResults()
          {
            Debug.Assert(flagHasFlightStatusSearchResults);
            return storeFlightStatusSearchResults;
          }



        public void setCurrentDateAndTime(FlightTimesJSON  new_value)
          {
            if (flagHasCurrentDateAndTime)
              {
              }
            flagHasCurrentDateAndTime = true;
            storeCurrentDateAndTime = new_value;
          }
        public void unsetCurrentDateAndTime()
          {
            if (flagHasCurrentDateAndTime)
              {
              }
            flagHasCurrentDateAndTime = false;
          }
        public void setFlightTravelLocationForClient(FlightTravelLocationJSON  new_value)
          {
            if (flagHasFlightTravelLocationForClient)
              {
              }
            flagHasFlightTravelLocationForClient = true;
            storeFlightTravelLocationForClient = new_value;
          }
        public void unsetFlightTravelLocationForClient()
          {
            if (flagHasFlightTravelLocationForClient)
              {
              }
            flagHasFlightTravelLocationForClient = false;
          }
        public void initFlightStatusSearchResults()
          {
            if (flagHasFlightStatusSearchResults)
              {
                for (int num1 = 0; num1 < storeFlightStatusSearchResults.Count; ++num1)
                  {
                  }
              }
            flagHasFlightStatusSearchResults = true;
            storeFlightStatusSearchResults.Clear();
          }
        public void appendFlightStatusSearchResults(FlightStatusSearchResultJSON  to_append)
          {
            if (!flagHasFlightStatusSearchResults)
              {
                flagHasFlightStatusSearchResults = true;
                storeFlightStatusSearchResults.Clear();
              }
            Debug.Assert(flagHasFlightStatusSearchResults);
            storeFlightStatusSearchResults.Add(to_append);
          }
        public void unsetFlightStatusSearchResults()
          {
            if (flagHasFlightStatusSearchResults)
              {
                for (int num2 = 0; num2 < storeFlightStatusSearchResults.Count; ++num2)
                  {
                  }
              }
            flagHasFlightStatusSearchResults = false;
            storeFlightStatusSearchResults.Clear();
          }


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
            Debug.Assert(partial_allowed || flagHasCurrentDateAndTime);
            if (flagHasCurrentDateAndTime)
              {
                handler.start_pair("CurrentDateAndTime");
                if (partial_allowed)
                    storeCurrentDateAndTime.write_partial_as_json(handler);
                else
                    storeCurrentDateAndTime.write_as_json(handler);
              }
            if (flagHasFlightTravelLocationForClient)
              {
                handler.start_pair("FlightTravelLocationForClient");
                if (partial_allowed)
                    storeFlightTravelLocationForClient.write_partial_as_json(handler);
                else
                    storeFlightTravelLocationForClient.write_as_json(handler);
              }
            if (flagHasFlightStatusSearchResults)
              {
                handler.start_pair("FlightStatusSearchResults");
                handler.start_array();
                for (int num1 = 0; num1 < storeFlightStatusSearchResults.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeFlightStatusSearchResults[num1].write_partial_as_json(handler);
                    else
                        storeFlightStatusSearchResults[num1].write_as_json(handler);
                  }
                handler.finish_array();
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
            if (!(hasCurrentDateAndTime()))
              {
                return "When parsing the object for %what%, the \"CurrentDateAndTime\" field was missing.";
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
            private FlightTimesJSON.HoldingGenerator fieldGeneratorCurrentDateAndTime;
            private FlightTravelLocationJSON.HoldingGenerator fieldGeneratorFlightTravelLocationForClient;
            private FlightStatusSearchResultJSON.HoldingArrayGenerator fieldGeneratorFlightStatusSearchResults;

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
                string message = "";
                message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
                throw new Exception(message);
              }
            protected override void finish_field(string field_name, JSONHandler field_handler)
              {
              }
            protected override void finish()
              {
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorCurrentDateAndTime.have_value)
                  {
                    result.setCurrentDateAndTime(fieldGeneratorCurrentDateAndTime.value);
                    fieldGeneratorCurrentDateAndTime.have_value = false;
                  }
                else if ((!(result.hasCurrentDateAndTime())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"CurrentDateAndTime\" field was missing.");
                  }
                if (fieldGeneratorFlightTravelLocationForClient.have_value)
                  {
                    result.setFlightTravelLocationForClient(fieldGeneratorFlightTravelLocationForClient.value);
                    fieldGeneratorFlightTravelLocationForClient.have_value = false;
                  }
                if (fieldGeneratorFlightStatusSearchResults.have_value)
                  {
                    result.initFlightStatusSearchResults();
                    int count = fieldGeneratorFlightStatusSearchResults.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendFlightStatusSearchResults(fieldGeneratorFlightStatusSearchResults.value[num]);
                      }
                    fieldGeneratorFlightStatusSearchResults.value.Clear();
                    fieldGeneratorFlightStatusSearchResults.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "urrentDateAndTime", 0, 17, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorCurrentDateAndTime;
                        break;
                    case 'F':
                        if (String.Compare(field_name, 1, "light", 0, 5, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'S':
                                    if ((String.Compare(field_name, 7, "tatusSearchResults", 0, 18, false) == 0) && (field_name.Length == 25))
                                        return fieldGeneratorFlightStatusSearchResults;
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 7, "ravelLocationForClient", 0, 22, false) == 0) && (field_name.Length == 29))
                                        return fieldGeneratorFlightTravelLocationForClient;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorCurrentDateAndTime = new FlightTimesJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorFlightTravelLocationForClient = new FlightTravelLocationJSON.HoldingGenerator("field \"FlightTravelLocationForClient\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorFlightStatusSearchResults = new FlightStatusSearchResultJSON.HoldingArrayGenerator("field \"FlightStatusSearchResults\" of the TypeNativeData class", ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorCurrentDateAndTime = new FlightTimesJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the TypeNativeData class", false);
                fieldGeneratorFlightTravelLocationForClient = new FlightTravelLocationJSON.HoldingGenerator("field \"FlightTravelLocationForClient\" of the TypeNativeData class", false);
                fieldGeneratorFlightStatusSearchResults = new FlightStatusSearchResultJSON.HoldingArrayGenerator("field \"FlightStatusSearchResults\" of the TypeNativeData class", false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorCurrentDateAndTime.reset();
                fieldGeneratorFlightTravelLocationForClient.reset();
                fieldGeneratorFlightStatusSearchResults.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorCurrentDateAndTime.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorFlightTravelLocationForClient.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorFlightStatusSearchResults.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorCurrentDateAndTime.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorFlightTravelLocationForClient.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorFlightStatusSearchResults.set_allow_unpolished(new_allow_unpolished);
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
    private bool flagHasQueryState;
    private FlightStatusQueryStateJSON  storeQueryState;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }

    private JSONValue  extraQueryStateToJSON()
      {
        JSONValueHandler handler_QueryState = new JSONValueHandler();
        storeQueryState.write_as_json(handler_QueryState);
        return handler_QueryState.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    private void  fromJSONQueryState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatusQueryStateJSON convert_classy = FlightStatusQueryStateJSON.from_json(json_value, ignore_extras, true);
        setQueryState(convert_classy);
      }


    public FlightStatusCommandJSON()
      {
        flagHasNativeData = false;
        flagHasQueryState = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "FlightStatusCommand";
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

    public bool  hasQueryState()
      {
        return flagHasQueryState;
      }

    public FlightStatusQueryStateJSON   getQueryState()
      {
        Debug.Assert(flagHasQueryState);
        return storeQueryState;
      }


    public virtual int extraFlightStatusCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatusCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatusCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatusCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        if (flagHasQueryState)
            ++result;
        result += extraFlightStatusCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        if (flagHasQueryState)
          {
            if (remainder == 0)
                return "QueryState";
            --remainder;
          }
        return extraFlightStatusCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        if (flagHasQueryState)
          {
            if (remainder == 0)
                return extraQueryStateToJSON();
            --remainder;
          }
        return extraFlightStatusCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'N':
                if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNativeData ? extraNativeDataToJSON() : null);
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryState", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasQueryState ? extraQueryStateToJSON() : null);
                break;
            default:
                break;
          }
        return extraFlightStatusCommandLookup(field_name);
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
    public void setQueryState(FlightStatusQueryStateJSON  new_value)
      {
        if (flagHasQueryState)
          {
          }
        flagHasQueryState = true;
        storeQueryState = new_value;
      }
    public void unsetQueryState()
      {
        if (flagHasQueryState)
          {
          }
        flagHasQueryState = false;
      }

    public virtual void extraFlightStatusCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatusCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatusCommandLookup(key);
        if (old_field == null)
          {
            extraFlightStatusCommandAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryState", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONQueryState(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFlightStatusCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryState", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONQueryState(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFlightStatusCommandSetField(key, new_component);
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
        if (flagHasQueryState)
          {
            handler.start_pair("QueryState");
            if (partial_allowed)
                storeQueryState.write_partial_as_json(handler);
            else
                storeQueryState.write_as_json(handler);
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

    public static new FlightStatusCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusCommand", ignore_extras);
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
    public static new FlightStatusCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FlightStatusCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusCommand", ignore_extras);
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
    public static new FlightStatusCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FlightStatusCommandJSON from_text(string text, bool ignore_extras)
      {
        FlightStatusCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatusCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FlightStatusCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatusCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private FlightStatusQueryStateJSON.HoldingGenerator fieldGeneratorQueryState;
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
            if (!(getCommandResultJSONKey().Equals("FlightStatusCommand")))
                throw new Exception("The key field has a value other than `FlightStatusCommand'.");
            FlightStatusCommandJSON result = new FlightStatusCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatusCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((FlightStatusCommandJSON )new_result);
          }
        protected void finish(FlightStatusCommandJSON result)
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
            if (fieldGeneratorQueryState.have_value)
              {
                result.setQueryState(fieldGeneratorQueryState.value);
                fieldGeneratorQueryState.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(FlightStatusCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'N':
                    if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNativeData;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryState", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorQueryState;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the FlightStatusCommand class", ignore_extras);
            fieldGeneratorQueryState = new FlightStatusQueryStateJSON.HoldingGenerator("field \"QueryState\" of the FlightStatusCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatusCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the FlightStatusCommand class", false);
            fieldGeneratorQueryState = new FlightStatusQueryStateJSON.HoldingGenerator("field \"QueryState\" of the FlightStatusCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatusCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            fieldGeneratorQueryState.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatusCommandJSON  result)
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
        public FlightStatusCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatusCommandJSON  result)
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
    protected virtual void handle_result(List<FlightStatusCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatusCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatusCommandJSON>();
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
    public List<FlightStatusCommandJSON> value;
  };
  };
