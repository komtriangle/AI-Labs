/* file "FlightSegmentGroupJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FlightSegmentGroupJSON : JSONBase
  {
    private bool flagHasTotalTravelDuration;
    private double storeTotalTravelDuration;
    private string textStoreTotalTravelDuration;
    private bool flagHasTotalFlightDuration;
    private double storeTotalFlightDuration;
    private string textStoreTotalFlightDuration;
    private bool flagHasTotalLayoverDuration;
    private double storeTotalLayoverDuration;
    private string textStoreTotalLayoverDuration;
    private bool flagHasNumberOfStops;
    private BigInteger storeNumberOfStops;
    private bool flagHasFlightSegmentDetails;
    private List< FlightSegmentDetailsJSON  > storeFlightSegmentDetails;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTotalTravelDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field TotalTravelDuration of FlightSegmentGroupJSON is not a number.");
              }
          }
        setTotalTravelDurationText(the_rational_text);
      }


    private void  fromJSONTotalFlightDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field TotalFlightDuration of FlightSegmentGroupJSON is not a number.");
              }
          }
        setTotalFlightDurationText(the_rational_text);
      }


    private void  fromJSONTotalLayoverDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field TotalLayoverDuration of FlightSegmentGroupJSON is not a number.");
              }
          }
        setTotalLayoverDurationText(the_rational_text);
      }


    private void  fromJSONNumberOfStops(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumberOfStops of FlightSegmentGroupJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumberOfStops of FlightSegmentGroupJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumberOfStops(extracted_integer);
      }


    private void  fromJSONFlightSegmentDetails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlightSegmentDetails of FlightSegmentGroupJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field FlightSegmentDetails of FlightSegmentGroupJSON has too few elements.");
        List< FlightSegmentDetailsJSON  > vector_FlightSegmentDetails1 = new List< FlightSegmentDetailsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightSegmentDetailsJSON convert_classy = FlightSegmentDetailsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlightSegmentDetails1.Add(convert_classy);
          }
        Debug.Assert(vector_FlightSegmentDetails1.Count >= 1);
        initFlightSegmentDetails();
        for (int num1 = 0; num1 < vector_FlightSegmentDetails1.Count; ++num1)
            appendFlightSegmentDetails(vector_FlightSegmentDetails1[num1]);
        for (int num1 = 0; num1 < vector_FlightSegmentDetails1.Count; ++num1)
          {
          }
      }


    public FlightSegmentGroupJSON()
      {
        flagHasTotalTravelDuration = false;
        flagHasTotalFlightDuration = false;
        flagHasTotalLayoverDuration = false;
        flagHasNumberOfStops = false;
        flagHasFlightSegmentDetails = false;
        storeFlightSegmentDetails = new List< FlightSegmentDetailsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTotalTravelDuration()
      {
        return flagHasTotalTravelDuration;
      }

    public double  getTotalTravelDuration()
      {
        Debug.Assert(flagHasTotalTravelDuration);
        if (textStoreTotalTravelDuration != "")
          {
            return Double.Parse(textStoreTotalTravelDuration);
          }
        return storeTotalTravelDuration;
      }

    public string  getTotalTravelDurationAsText()
      {
        Debug.Assert(flagHasTotalTravelDuration);
        if (textStoreTotalTravelDuration == "")
          {
            return Convert.ToString(storeTotalTravelDuration);
          }
        else
          {
            return (textStoreTotalTravelDuration);
          }
      }

    public bool  hasTotalFlightDuration()
      {
        return flagHasTotalFlightDuration;
      }

    public double  getTotalFlightDuration()
      {
        Debug.Assert(flagHasTotalFlightDuration);
        if (textStoreTotalFlightDuration != "")
          {
            return Double.Parse(textStoreTotalFlightDuration);
          }
        return storeTotalFlightDuration;
      }

    public string  getTotalFlightDurationAsText()
      {
        Debug.Assert(flagHasTotalFlightDuration);
        if (textStoreTotalFlightDuration == "")
          {
            return Convert.ToString(storeTotalFlightDuration);
          }
        else
          {
            return (textStoreTotalFlightDuration);
          }
      }

    public bool  hasTotalLayoverDuration()
      {
        return flagHasTotalLayoverDuration;
      }

    public double  getTotalLayoverDuration()
      {
        Debug.Assert(flagHasTotalLayoverDuration);
        if (textStoreTotalLayoverDuration != "")
          {
            return Double.Parse(textStoreTotalLayoverDuration);
          }
        return storeTotalLayoverDuration;
      }

    public string  getTotalLayoverDurationAsText()
      {
        Debug.Assert(flagHasTotalLayoverDuration);
        if (textStoreTotalLayoverDuration == "")
          {
            return Convert.ToString(storeTotalLayoverDuration);
          }
        else
          {
            return (textStoreTotalLayoverDuration);
          }
      }

    public bool  hasNumberOfStops()
      {
        return flagHasNumberOfStops;
      }

    public BigInteger  getNumberOfStops()
      {
        Debug.Assert(flagHasNumberOfStops);
        return storeNumberOfStops;
      }

    public bool  hasFlightSegmentDetails()
      {
        return flagHasFlightSegmentDetails;
      }

    public int  countOfFlightSegmentDetails()
      {
        Debug.Assert(flagHasFlightSegmentDetails);
        return storeFlightSegmentDetails.Count;
      }

    public FlightSegmentDetailsJSON   elementOfFlightSegmentDetails(int element_num)
      {
        Debug.Assert(flagHasFlightSegmentDetails);
        return storeFlightSegmentDetails[element_num];
      }

    public List< FlightSegmentDetailsJSON  >  getFlightSegmentDetails()
      {
        Debug.Assert(flagHasFlightSegmentDetails);
        return storeFlightSegmentDetails;
      }


    public virtual int extraFlightSegmentGroupComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightSegmentGroupComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightSegmentGroupComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightSegmentGroupLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTotalTravelDuration(double new_value)
      {
        flagHasTotalTravelDuration = true;
        storeTotalTravelDuration = new_value;
        textStoreTotalTravelDuration = "";
      }
    public void setTotalTravelDurationText(string new_value)
      {
        flagHasTotalTravelDuration = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalTravelDuration of FlightSegmentGroupJSON is not a valid number.");
        textStoreTotalTravelDuration = new_value;
      }
    public void unsetTotalTravelDuration()
      {
        flagHasTotalTravelDuration = false;
      }
    public void setTotalFlightDuration(double new_value)
      {
        flagHasTotalFlightDuration = true;
        storeTotalFlightDuration = new_value;
        textStoreTotalFlightDuration = "";
      }
    public void setTotalFlightDurationText(string new_value)
      {
        flagHasTotalFlightDuration = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalFlightDuration of FlightSegmentGroupJSON is not a valid number.");
        textStoreTotalFlightDuration = new_value;
      }
    public void unsetTotalFlightDuration()
      {
        flagHasTotalFlightDuration = false;
      }
    public void setTotalLayoverDuration(double new_value)
      {
        flagHasTotalLayoverDuration = true;
        storeTotalLayoverDuration = new_value;
        textStoreTotalLayoverDuration = "";
      }
    public void setTotalLayoverDurationText(string new_value)
      {
        flagHasTotalLayoverDuration = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalLayoverDuration of FlightSegmentGroupJSON is not a valid number.");
        textStoreTotalLayoverDuration = new_value;
      }
    public void unsetTotalLayoverDuration()
      {
        flagHasTotalLayoverDuration = false;
      }
    public void setNumberOfStops(BigInteger new_value)
      {
        flagHasNumberOfStops = true;
        if (new_value < 0)
            throw new Exception("The value for field NumberOfStops of FlightSegmentGroupJSON is less than the lower bound (0) for that field.");
        storeNumberOfStops = new_value;
      }
    public void unsetNumberOfStops()
      {
        flagHasNumberOfStops = false;
      }
    public void initFlightSegmentDetails()
      {
        if (flagHasFlightSegmentDetails)
          {
            for (int num1 = 0; num1 < storeFlightSegmentDetails.Count; ++num1)
              {
              }
          }
        flagHasFlightSegmentDetails = true;
        storeFlightSegmentDetails.Clear();
      }
    public void appendFlightSegmentDetails(FlightSegmentDetailsJSON  to_append)
      {
        if (!flagHasFlightSegmentDetails)
          {
            flagHasFlightSegmentDetails = true;
            storeFlightSegmentDetails.Clear();
          }
        Debug.Assert(flagHasFlightSegmentDetails);
        storeFlightSegmentDetails.Add(to_append);
      }
    public void unsetFlightSegmentDetails()
      {
        if (flagHasFlightSegmentDetails)
          {
            for (int num2 = 0; num2 < storeFlightSegmentDetails.Count; ++num2)
              {
              }
          }
        flagHasFlightSegmentDetails = false;
        storeFlightSegmentDetails.Clear();
      }

    public virtual void extraFlightSegmentGroupAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightSegmentGroupSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightSegmentGroupLookup(key);
        if (old_field == null)
          {
            extraFlightSegmentGroupAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTotalTravelDuration);
        if (flagHasTotalTravelDuration)
          {
            handler.start_pair("TotalTravelDuration");
            if (textStoreTotalTravelDuration != "")
                handler.number_value(textStoreTotalTravelDuration);
            else if (((double)(long)storeTotalTravelDuration) == storeTotalTravelDuration)
                handler.number_value((long)storeTotalTravelDuration);
            else
                handler.number_value(storeTotalTravelDuration);
          }
        Debug.Assert(partial_allowed || flagHasTotalFlightDuration);
        if (flagHasTotalFlightDuration)
          {
            handler.start_pair("TotalFlightDuration");
            if (textStoreTotalFlightDuration != "")
                handler.number_value(textStoreTotalFlightDuration);
            else if (((double)(long)storeTotalFlightDuration) == storeTotalFlightDuration)
                handler.number_value((long)storeTotalFlightDuration);
            else
                handler.number_value(storeTotalFlightDuration);
          }
        Debug.Assert(partial_allowed || flagHasTotalLayoverDuration);
        if (flagHasTotalLayoverDuration)
          {
            handler.start_pair("TotalLayoverDuration");
            if (textStoreTotalLayoverDuration != "")
                handler.number_value(textStoreTotalLayoverDuration);
            else if (((double)(long)storeTotalLayoverDuration) == storeTotalLayoverDuration)
                handler.number_value((long)storeTotalLayoverDuration);
            else
                handler.number_value(storeTotalLayoverDuration);
          }
        Debug.Assert(partial_allowed || flagHasNumberOfStops);
        if (flagHasNumberOfStops)
          {
            handler.start_pair("NumberOfStops");
            handler.number_value(storeNumberOfStops);
          }
        Debug.Assert(partial_allowed || flagHasFlightSegmentDetails);
        if (flagHasFlightSegmentDetails)
          {
            handler.start_pair("FlightSegmentDetails");
            Debug.Assert(storeFlightSegmentDetails.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeFlightSegmentDetails.Count; ++num1)
              {
                if (partial_allowed)
                    storeFlightSegmentDetails[num1].write_partial_as_json(handler);
                else
                    storeFlightSegmentDetails[num1].write_as_json(handler);
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
        if (!(hasTotalTravelDuration()))
          {
            return "When parsing the object for %what%, the \"TotalTravelDuration\" field was missing.";
          }
        if (!(hasTotalFlightDuration()))
          {
            return "When parsing the object for %what%, the \"TotalFlightDuration\" field was missing.";
          }
        if (!(hasTotalLayoverDuration()))
          {
            return "When parsing the object for %what%, the \"TotalLayoverDuration\" field was missing.";
          }
        if (!(hasNumberOfStops()))
          {
            return "When parsing the object for %what%, the \"NumberOfStops\" field was missing.";
          }
        if (!(hasFlightSegmentDetails()))
          {
            return "When parsing the object for %what%, the \"FlightSegmentDetails\" field was missing.";
          }
        return null;
      }

    public static FlightSegmentGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSegmentGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentGroup", ignore_extras);
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
    public static FlightSegmentGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSegmentGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSegmentGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentGroup", ignore_extras);
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
    public static FlightSegmentGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSegmentGroupJSON from_text(string text, bool ignore_extras)
      {
        FlightSegmentGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentGroup", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightSegmentGroupJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightSegmentGroupJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightSegmentGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentGroup", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalTravelDuration;
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalFlightDuration;
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalLayoverDuration;
    private class FieldHoldingGeneratorNumberOfStops : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNumberOfStops(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumberOfStops : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumberOfStops(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNumberOfStops fieldGeneratorNumberOfStops;
        private FlightSegmentDetailsJSON.HoldingArrayGenerator fieldGeneratorFlightSegmentDetails;
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
            FlightSegmentGroupJSON result = new FlightSegmentGroupJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightSegmentGroupAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightSegmentGroupJSON result)
          {
            if (fieldGeneratorTotalTravelDuration.have_value)
              {
                result.setTotalTravelDurationText(fieldGeneratorTotalTravelDuration.value);
                fieldGeneratorTotalTravelDuration.have_value = false;
              }
            else if ((!(result.hasTotalTravelDuration())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TotalTravelDuration\" field was missing.");
              }
            if (fieldGeneratorTotalFlightDuration.have_value)
              {
                result.setTotalFlightDurationText(fieldGeneratorTotalFlightDuration.value);
                fieldGeneratorTotalFlightDuration.have_value = false;
              }
            else if ((!(result.hasTotalFlightDuration())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TotalFlightDuration\" field was missing.");
              }
            if (fieldGeneratorTotalLayoverDuration.have_value)
              {
                result.setTotalLayoverDurationText(fieldGeneratorTotalLayoverDuration.value);
                fieldGeneratorTotalLayoverDuration.have_value = false;
              }
            else if ((!(result.hasTotalLayoverDuration())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TotalLayoverDuration\" field was missing.");
              }
            if (fieldGeneratorNumberOfStops.have_value)
              {
                result.setNumberOfStops(fieldGeneratorNumberOfStops.value);
                fieldGeneratorNumberOfStops.have_value = false;
              }
            else if ((!(result.hasNumberOfStops())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NumberOfStops\" field was missing.");
              }
            if (fieldGeneratorFlightSegmentDetails.have_value)
              {
                result.initFlightSegmentDetails();
                int count = fieldGeneratorFlightSegmentDetails.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlightSegmentDetails(fieldGeneratorFlightSegmentDetails.value[num]);
                  }
                fieldGeneratorFlightSegmentDetails.value.Clear();
                fieldGeneratorFlightSegmentDetails.have_value = false;
              }
            else if ((!(result.hasFlightSegmentDetails())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightSegmentDetails\" field was missing.");
              }
          }
        protected abstract void handle_result(FlightSegmentGroupJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "lightSegmentDetails", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorFlightSegmentDetails;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umberOfStops", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorNumberOfStops;
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "otal", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 6, "lightDuration", 0, 13, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorTotalFlightDuration;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 6, "ayoverDuration", 0, 14, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorTotalLayoverDuration;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 6, "ravelDuration", 0, 13, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorTotalTravelDuration;
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
            fieldGeneratorTotalTravelDuration = new JSONHoldingNumberTextGenerator("field \"TotalTravelDuration\" of the FlightSegmentGroup class");
            fieldGeneratorTotalFlightDuration = new JSONHoldingNumberTextGenerator("field \"TotalFlightDuration\" of the FlightSegmentGroup class");
            fieldGeneratorTotalLayoverDuration = new JSONHoldingNumberTextGenerator("field \"TotalLayoverDuration\" of the FlightSegmentGroup class");
            fieldGeneratorNumberOfStops = new FieldHoldingGeneratorNumberOfStops("field \"NumberOfStops\" of the FlightSegmentGroup class");
            fieldGeneratorFlightSegmentDetails = new FlightSegmentDetailsJSON.HoldingArrayGenerator("field \"FlightSegmentDetails\" of the FlightSegmentGroup class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightSegmentGroup class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTotalTravelDuration = new JSONHoldingNumberTextGenerator("field \"TotalTravelDuration\" of the FlightSegmentGroup class");
            fieldGeneratorTotalFlightDuration = new JSONHoldingNumberTextGenerator("field \"TotalFlightDuration\" of the FlightSegmentGroup class");
            fieldGeneratorTotalLayoverDuration = new JSONHoldingNumberTextGenerator("field \"TotalLayoverDuration\" of the FlightSegmentGroup class");
            fieldGeneratorNumberOfStops = new FieldHoldingGeneratorNumberOfStops("field \"NumberOfStops\" of the FlightSegmentGroup class");
            fieldGeneratorFlightSegmentDetails = new FlightSegmentDetailsJSON.HoldingArrayGenerator("field \"FlightSegmentDetails\" of the FlightSegmentGroup class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightSegmentGroup class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTotalTravelDuration.reset();
            fieldGeneratorTotalFlightDuration.reset();
            fieldGeneratorTotalLayoverDuration.reset();
            fieldGeneratorNumberOfStops.reset();
            fieldGeneratorFlightSegmentDetails.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFlightSegmentDetails.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFlightSegmentDetails.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightSegmentGroupJSON  result)
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
        public FlightSegmentGroupJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightSegmentGroupJSON  result)
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
    protected virtual void handle_result(List<FlightSegmentGroupJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightSegmentGroupJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightSegmentGroupJSON>();
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
    public List<FlightSegmentGroupJSON> value;
  };
  };
