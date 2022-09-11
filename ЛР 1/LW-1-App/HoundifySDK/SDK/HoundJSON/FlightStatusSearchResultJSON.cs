/* file "FlightStatusSearchResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FlightStatusSearchResultJSON : JSONBase
  {
    private bool flagHasFlightSpec;
    private FlightSpecJSON  storeFlightSpec;
    private bool flagHasErrorMessage;
    private string storeErrorMessage;
    private bool flagHasErrorMessageSpoken;
    private string storeErrorMessageSpoken;
    private bool flagHasErrorType;
    private string storeErrorType;
    private bool flagHasErrorData;
    private CommandErrorJSON  storeErrorData;
    private bool flagHasFlightStatuses;
    private List< FlightStatusJSON  > storeFlightStatuses;
    private bool flagHasMostRelevantFlightIndex;
    private BigInteger storeMostRelevantFlightIndex;
    private bool flagHasMostRelevantFlightCriteria;
    private ResponseTypesJSON  storeMostRelevantFlightCriteria;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFlightSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightSpecJSON convert_classy = FlightSpecJSON.from_json(json_value, ignore_extras, true);
        setFlightSpec(convert_classy);
      }


    private void  fromJSONErrorMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorMessage of FlightStatusSearchResultJSON is not a string.");
        setErrorMessage(json_string.getData());
      }


    private void  fromJSONErrorMessageSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorMessageSpoken of FlightStatusSearchResultJSON is not a string.");
        setErrorMessageSpoken(json_string.getData());
      }


    private void  fromJSONErrorType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorType of FlightStatusSearchResultJSON is not a string.");
        setErrorType(json_string.getData());
      }


    private void  fromJSONErrorData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CommandErrorJSON convert_classy = CommandErrorJSON.from_json(json_value, ignore_extras, true);
        setErrorData(convert_classy);
      }


    private void  fromJSONFlightStatuses(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlightStatuses of FlightStatusSearchResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightStatusJSON  > vector_FlightStatuses1 = new List< FlightStatusJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightStatusJSON convert_classy = FlightStatusJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlightStatuses1.Add(convert_classy);
          }
        initFlightStatuses();
        for (int num1 = 0; num1 < vector_FlightStatuses1.Count; ++num1)
            appendFlightStatuses(vector_FlightStatuses1[num1]);
        for (int num1 = 0; num1 < vector_FlightStatuses1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMostRelevantFlightIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MostRelevantFlightIndex of FlightStatusSearchResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MostRelevantFlightIndex of FlightStatusSearchResultJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMostRelevantFlightIndex(extracted_integer);
      }


    private void  fromJSONMostRelevantFlightCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ResponseTypesJSON convert_classy = ResponseTypesJSON.from_json(json_value, ignore_extras, true);
        setMostRelevantFlightCriteria(convert_classy);
      }


    public FlightStatusSearchResultJSON()
      {
        flagHasFlightSpec = false;
        flagHasErrorMessage = false;
        flagHasErrorMessageSpoken = false;
        flagHasErrorType = false;
        flagHasErrorData = false;
        flagHasFlightStatuses = false;
        flagHasMostRelevantFlightIndex = false;
        flagHasMostRelevantFlightCriteria = false;
        storeFlightStatuses = new List< FlightStatusJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFlightSpec()
      {
        return flagHasFlightSpec;
      }

    public FlightSpecJSON   getFlightSpec()
      {
        Debug.Assert(flagHasFlightSpec);
        return storeFlightSpec;
      }

    public bool  hasErrorMessage()
      {
        return flagHasErrorMessage;
      }

    public string  getErrorMessage()
      {
        Debug.Assert(flagHasErrorMessage);
        return storeErrorMessage;
      }

    public bool  hasErrorMessageSpoken()
      {
        return flagHasErrorMessageSpoken;
      }

    public string  getErrorMessageSpoken()
      {
        Debug.Assert(flagHasErrorMessageSpoken);
        return storeErrorMessageSpoken;
      }

    public bool  hasErrorType()
      {
        return flagHasErrorType;
      }

    public string  getErrorType()
      {
        Debug.Assert(flagHasErrorType);
        return storeErrorType;
      }

    public bool  hasErrorData()
      {
        return flagHasErrorData;
      }

    public CommandErrorJSON   getErrorData()
      {
        Debug.Assert(flagHasErrorData);
        return storeErrorData;
      }

    public bool  hasFlightStatuses()
      {
        return flagHasFlightStatuses;
      }

    public int  countOfFlightStatuses()
      {
        Debug.Assert(flagHasFlightStatuses);
        return storeFlightStatuses.Count;
      }

    public FlightStatusJSON   elementOfFlightStatuses(int element_num)
      {
        Debug.Assert(flagHasFlightStatuses);
        return storeFlightStatuses[element_num];
      }

    public List< FlightStatusJSON  >  getFlightStatuses()
      {
        Debug.Assert(flagHasFlightStatuses);
        return storeFlightStatuses;
      }

    public bool  hasMostRelevantFlightIndex()
      {
        return flagHasMostRelevantFlightIndex;
      }

    public BigInteger  getMostRelevantFlightIndex()
      {
        Debug.Assert(flagHasMostRelevantFlightIndex);
        return storeMostRelevantFlightIndex;
      }

    public bool  hasMostRelevantFlightCriteria()
      {
        return flagHasMostRelevantFlightCriteria;
      }

    public ResponseTypesJSON   getMostRelevantFlightCriteria()
      {
        Debug.Assert(flagHasMostRelevantFlightCriteria);
        return storeMostRelevantFlightCriteria;
      }


    public virtual int extraFlightStatusSearchResultComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatusSearchResultComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatusSearchResultComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatusSearchResultLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFlightSpec(FlightSpecJSON  new_value)
      {
        if (flagHasFlightSpec)
          {
          }
        flagHasFlightSpec = true;
        storeFlightSpec = new_value;
      }
    public void unsetFlightSpec()
      {
        if (flagHasFlightSpec)
          {
          }
        flagHasFlightSpec = false;
      }
    public void setErrorMessage(string new_value)
      {
        flagHasErrorMessage = true;
        storeErrorMessage = new_value;
      }
    public void unsetErrorMessage()
      {
        flagHasErrorMessage = false;
      }
    public void setErrorMessageSpoken(string new_value)
      {
        flagHasErrorMessageSpoken = true;
        storeErrorMessageSpoken = new_value;
      }
    public void unsetErrorMessageSpoken()
      {
        flagHasErrorMessageSpoken = false;
      }
    public void setErrorType(string new_value)
      {
        flagHasErrorType = true;
        storeErrorType = new_value;
      }
    public void unsetErrorType()
      {
        flagHasErrorType = false;
      }
    public void setErrorData(CommandErrorJSON  new_value)
      {
        if (flagHasErrorData)
          {
          }
        flagHasErrorData = true;
        storeErrorData = new_value;
      }
    public void unsetErrorData()
      {
        if (flagHasErrorData)
          {
          }
        flagHasErrorData = false;
      }
    public void initFlightStatuses()
      {
        if (flagHasFlightStatuses)
          {
            for (int num1 = 0; num1 < storeFlightStatuses.Count; ++num1)
              {
              }
          }
        flagHasFlightStatuses = true;
        storeFlightStatuses.Clear();
      }
    public void appendFlightStatuses(FlightStatusJSON  to_append)
      {
        if (!flagHasFlightStatuses)
          {
            flagHasFlightStatuses = true;
            storeFlightStatuses.Clear();
          }
        Debug.Assert(flagHasFlightStatuses);
        storeFlightStatuses.Add(to_append);
      }
    public void unsetFlightStatuses()
      {
        if (flagHasFlightStatuses)
          {
            for (int num2 = 0; num2 < storeFlightStatuses.Count; ++num2)
              {
              }
          }
        flagHasFlightStatuses = false;
        storeFlightStatuses.Clear();
      }
    public void setMostRelevantFlightIndex(BigInteger new_value)
      {
        flagHasMostRelevantFlightIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field MostRelevantFlightIndex of FlightStatusSearchResultJSON is less than the lower bound (0) for that field.");
        storeMostRelevantFlightIndex = new_value;
      }
    public void unsetMostRelevantFlightIndex()
      {
        flagHasMostRelevantFlightIndex = false;
      }
    public void setMostRelevantFlightCriteria(ResponseTypesJSON  new_value)
      {
        if (flagHasMostRelevantFlightCriteria)
          {
          }
        flagHasMostRelevantFlightCriteria = true;
        storeMostRelevantFlightCriteria = new_value;
      }
    public void unsetMostRelevantFlightCriteria()
      {
        if (flagHasMostRelevantFlightCriteria)
          {
          }
        flagHasMostRelevantFlightCriteria = false;
      }

    public virtual void extraFlightStatusSearchResultAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatusSearchResultSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatusSearchResultLookup(key);
        if (old_field == null)
          {
            extraFlightStatusSearchResultAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFlightSpec);
        if (flagHasFlightSpec)
          {
            handler.start_pair("FlightSpec");
            if (partial_allowed)
                storeFlightSpec.write_partial_as_json(handler);
            else
                storeFlightSpec.write_as_json(handler);
          }
        if (flagHasErrorMessage)
          {
            handler.start_pair("ErrorMessage");
            handler.string_value(storeErrorMessage);
          }
        if (flagHasErrorMessageSpoken)
          {
            handler.start_pair("ErrorMessageSpoken");
            handler.string_value(storeErrorMessageSpoken);
          }
        if (flagHasErrorType)
          {
            handler.start_pair("ErrorType");
            handler.string_value(storeErrorType);
          }
        if (flagHasErrorData)
          {
            handler.start_pair("ErrorData");
            if (partial_allowed)
                storeErrorData.write_partial_as_json(handler);
            else
                storeErrorData.write_as_json(handler);
          }
        if (flagHasFlightStatuses)
          {
            handler.start_pair("FlightStatuses");
            handler.start_array();
            for (int num1 = 0; num1 < storeFlightStatuses.Count; ++num1)
              {
                if (partial_allowed)
                    storeFlightStatuses[num1].write_partial_as_json(handler);
                else
                    storeFlightStatuses[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMostRelevantFlightIndex)
          {
            handler.start_pair("MostRelevantFlightIndex");
            handler.number_value(storeMostRelevantFlightIndex);
          }
        if (flagHasMostRelevantFlightCriteria)
          {
            handler.start_pair("MostRelevantFlightCriteria");
            if (partial_allowed)
                storeMostRelevantFlightCriteria.write_partial_as_json(handler);
            else
                storeMostRelevantFlightCriteria.write_as_json(handler);
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
        if (!(hasFlightSpec()))
          {
            return "When parsing the object for %what%, the \"FlightSpec\" field was missing.";
          }
        return null;
      }

    public static FlightStatusSearchResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusSearchResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusSearchResult", ignore_extras);
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
    public static FlightStatusSearchResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatusSearchResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusSearchResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusSearchResult", ignore_extras);
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
    public static FlightStatusSearchResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatusSearchResultJSON from_text(string text, bool ignore_extras)
      {
        FlightStatusSearchResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusSearchResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatusSearchResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatusSearchResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatusSearchResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusSearchResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private FlightSpecJSON.HoldingGenerator fieldGeneratorFlightSpec;
        private JSONHoldingStringGenerator fieldGeneratorErrorMessage;
        private JSONHoldingStringGenerator fieldGeneratorErrorMessageSpoken;
        private JSONHoldingStringGenerator fieldGeneratorErrorType;
        private CommandErrorJSON.HoldingGenerator fieldGeneratorErrorData;
        private FlightStatusJSON.HoldingArrayGenerator fieldGeneratorFlightStatuses;
    private class FieldHoldingGeneratorMostRelevantFlightIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMostRelevantFlightIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMostRelevantFlightIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMostRelevantFlightIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorMostRelevantFlightIndex fieldGeneratorMostRelevantFlightIndex;
        private ResponseTypesJSON.HoldingGenerator fieldGeneratorMostRelevantFlightCriteria;
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
            FlightStatusSearchResultJSON result = new FlightStatusSearchResultJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatusSearchResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatusSearchResultJSON result)
          {
            if (fieldGeneratorFlightSpec.have_value)
              {
                result.setFlightSpec(fieldGeneratorFlightSpec.value);
                fieldGeneratorFlightSpec.have_value = false;
              }
            else if ((!(result.hasFlightSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightSpec\" field was missing.");
              }
            if (fieldGeneratorErrorMessage.have_value)
              {
                result.setErrorMessage(fieldGeneratorErrorMessage.value);
                fieldGeneratorErrorMessage.have_value = false;
              }
            if (fieldGeneratorErrorMessageSpoken.have_value)
              {
                result.setErrorMessageSpoken(fieldGeneratorErrorMessageSpoken.value);
                fieldGeneratorErrorMessageSpoken.have_value = false;
              }
            if (fieldGeneratorErrorType.have_value)
              {
                result.setErrorType(fieldGeneratorErrorType.value);
                fieldGeneratorErrorType.have_value = false;
              }
            if (fieldGeneratorErrorData.have_value)
              {
                result.setErrorData(fieldGeneratorErrorData.value);
                fieldGeneratorErrorData.have_value = false;
              }
            if (fieldGeneratorFlightStatuses.have_value)
              {
                result.initFlightStatuses();
                int count = fieldGeneratorFlightStatuses.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlightStatuses(fieldGeneratorFlightStatuses.value[num]);
                  }
                fieldGeneratorFlightStatuses.value.Clear();
                fieldGeneratorFlightStatuses.have_value = false;
              }
            if (fieldGeneratorMostRelevantFlightIndex.have_value)
              {
                result.setMostRelevantFlightIndex(fieldGeneratorMostRelevantFlightIndex.value);
                fieldGeneratorMostRelevantFlightIndex.have_value = false;
              }
            if (fieldGeneratorMostRelevantFlightCriteria.have_value)
              {
                result.setMostRelevantFlightCriteria(fieldGeneratorMostRelevantFlightCriteria.value);
                fieldGeneratorMostRelevantFlightCriteria.have_value = false;
              }
          }
        protected abstract void handle_result(FlightStatusSearchResultJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if (String.Compare(field_name, 1, "rror", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 6, "ata", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorErrorData;
                                break;
                            case 'M':
                                if (String.Compare(field_name, 6, "essage", 0, 6, false) == 0)
                                  {
                                    if (field_name.Length == 12)
                                      {
                                        return fieldGeneratorErrorMessage;
                                      }
                                    switch (field_name[12])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 13, "poken", 0, 5, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorErrorMessageSpoken;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 6, "ype", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorErrorType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "lightS", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'p':
                                if ((String.Compare(field_name, 8, "ec", 0, 2, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorFlightSpec;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 8, "atuses", 0, 6, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorFlightStatuses;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "ostRelevantFlight", 0, 17, false) == 0)
                      {
                        switch (field_name[18])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 19, "riteria", 0, 7, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorMostRelevantFlightCriteria;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 19, "ndex", 0, 4, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorMostRelevantFlightIndex;
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
            fieldGeneratorFlightSpec = new FlightSpecJSON.HoldingGenerator("field \"FlightSpec\" of the FlightStatusSearchResult class", ignore_extras);
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the FlightStatusSearchResult class");
            fieldGeneratorErrorMessageSpoken = new JSONHoldingStringGenerator("field \"ErrorMessageSpoken\" of the FlightStatusSearchResult class");
            fieldGeneratorErrorType = new JSONHoldingStringGenerator("field \"ErrorType\" of the FlightStatusSearchResult class");
            fieldGeneratorErrorData = new CommandErrorJSON.HoldingGenerator("field \"ErrorData\" of the FlightStatusSearchResult class", ignore_extras);
            fieldGeneratorFlightStatuses = new FlightStatusJSON.HoldingArrayGenerator("field \"FlightStatuses\" of the FlightStatusSearchResult class", ignore_extras);
            fieldGeneratorMostRelevantFlightIndex = new FieldHoldingGeneratorMostRelevantFlightIndex("field \"MostRelevantFlightIndex\" of the FlightStatusSearchResult class");
            fieldGeneratorMostRelevantFlightCriteria = new ResponseTypesJSON.HoldingGenerator("field \"MostRelevantFlightCriteria\" of the FlightStatusSearchResult class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatusSearchResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFlightSpec = new FlightSpecJSON.HoldingGenerator("field \"FlightSpec\" of the FlightStatusSearchResult class", false);
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the FlightStatusSearchResult class");
            fieldGeneratorErrorMessageSpoken = new JSONHoldingStringGenerator("field \"ErrorMessageSpoken\" of the FlightStatusSearchResult class");
            fieldGeneratorErrorType = new JSONHoldingStringGenerator("field \"ErrorType\" of the FlightStatusSearchResult class");
            fieldGeneratorErrorData = new CommandErrorJSON.HoldingGenerator("field \"ErrorData\" of the FlightStatusSearchResult class", false);
            fieldGeneratorFlightStatuses = new FlightStatusJSON.HoldingArrayGenerator("field \"FlightStatuses\" of the FlightStatusSearchResult class", false);
            fieldGeneratorMostRelevantFlightIndex = new FieldHoldingGeneratorMostRelevantFlightIndex("field \"MostRelevantFlightIndex\" of the FlightStatusSearchResult class");
            fieldGeneratorMostRelevantFlightCriteria = new ResponseTypesJSON.HoldingGenerator("field \"MostRelevantFlightCriteria\" of the FlightStatusSearchResult class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatusSearchResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFlightSpec.reset();
            fieldGeneratorErrorMessage.reset();
            fieldGeneratorErrorMessageSpoken.reset();
            fieldGeneratorErrorType.reset();
            fieldGeneratorErrorData.reset();
            fieldGeneratorFlightStatuses.reset();
            fieldGeneratorMostRelevantFlightIndex.reset();
            fieldGeneratorMostRelevantFlightCriteria.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFlightSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorErrorData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFlightStatuses.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMostRelevantFlightCriteria.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFlightSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorErrorData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFlightStatuses.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMostRelevantFlightCriteria.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatusSearchResultJSON  result)
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
        public FlightStatusSearchResultJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatusSearchResultJSON  result)
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
    protected virtual void handle_result(List<FlightStatusSearchResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatusSearchResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatusSearchResultJSON>();
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
    public List<FlightStatusSearchResultJSON> value;
  };
  };
