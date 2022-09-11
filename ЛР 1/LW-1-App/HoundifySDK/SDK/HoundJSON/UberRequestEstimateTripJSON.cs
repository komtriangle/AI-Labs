/* file "UberRequestEstimateTripJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberRequestEstimateTripJSON : JSONBase
  {
    private bool flagHasdistance_estimate;
    private double storedistance_estimate;
    private string textStoredistance_estimate;
    private bool flagHasdistance_unit;
    private string storedistance_unit;
    private bool flagHasduration_estimate;
    private double storeduration_estimate;
    private string textStoreduration_estimate;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONdistance_estimate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field distance_estimate of UberRequestEstimateTripJSON is not a number.");
              }
          }
        setdistance_estimateText(the_rational_text);
      }


    private void  fromJSONdistance_unit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field distance_unit of UberRequestEstimateTripJSON is not a string.");
        setdistance_unit(json_string.getData());
      }


    private void  fromJSONduration_estimate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field duration_estimate of UberRequestEstimateTripJSON is not a number.");
              }
          }
        setduration_estimateText(the_rational_text);
      }


    public UberRequestEstimateTripJSON()
      {
        flagHasdistance_estimate = false;
        flagHasdistance_unit = false;
        flagHasduration_estimate = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasdistance_estimate()
      {
        return flagHasdistance_estimate;
      }

    public double  getdistance_estimate()
      {
        Debug.Assert(flagHasdistance_estimate);
        if (textStoredistance_estimate != "")
          {
            return Double.Parse(textStoredistance_estimate);
          }
        return storedistance_estimate;
      }

    public string  getdistance_estimateAsText()
      {
        Debug.Assert(flagHasdistance_estimate);
        if (textStoredistance_estimate == "")
          {
            return Convert.ToString(storedistance_estimate);
          }
        else
          {
            return (textStoredistance_estimate);
          }
      }

    public bool  hasdistance_unit()
      {
        return flagHasdistance_unit;
      }

    public string  getdistance_unit()
      {
        Debug.Assert(flagHasdistance_unit);
        return storedistance_unit;
      }

    public bool  hasduration_estimate()
      {
        return flagHasduration_estimate;
      }

    public double  getduration_estimate()
      {
        Debug.Assert(flagHasduration_estimate);
        if (textStoreduration_estimate != "")
          {
            return Double.Parse(textStoreduration_estimate);
          }
        return storeduration_estimate;
      }

    public string  getduration_estimateAsText()
      {
        Debug.Assert(flagHasduration_estimate);
        if (textStoreduration_estimate == "")
          {
            return Convert.ToString(storeduration_estimate);
          }
        else
          {
            return (textStoreduration_estimate);
          }
      }


    public virtual int extraUberRequestEstimateTripComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberRequestEstimateTripComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberRequestEstimateTripComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberRequestEstimateTripLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setdistance_estimate(double new_value)
      {
        flagHasdistance_estimate = true;
        storedistance_estimate = new_value;
        textStoredistance_estimate = "";
      }
    public void setdistance_estimateText(string new_value)
      {
        flagHasdistance_estimate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field distance_estimate of UberRequestEstimateTripJSON is not a valid number.");
        textStoredistance_estimate = new_value;
      }
    public void unsetdistance_estimate()
      {
        flagHasdistance_estimate = false;
      }
    public void setdistance_unit(string new_value)
      {
        flagHasdistance_unit = true;
        storedistance_unit = new_value;
      }
    public void unsetdistance_unit()
      {
        flagHasdistance_unit = false;
      }
    public void setduration_estimate(double new_value)
      {
        flagHasduration_estimate = true;
        storeduration_estimate = new_value;
        textStoreduration_estimate = "";
      }
    public void setduration_estimateText(string new_value)
      {
        flagHasduration_estimate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field duration_estimate of UberRequestEstimateTripJSON is not a valid number.");
        textStoreduration_estimate = new_value;
      }
    public void unsetduration_estimate()
      {
        flagHasduration_estimate = false;
      }

    public virtual void extraUberRequestEstimateTripAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberRequestEstimateTripSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberRequestEstimateTripLookup(key);
        if (old_field == null)
          {
            extraUberRequestEstimateTripAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasdistance_estimate);
        if (flagHasdistance_estimate)
          {
            handler.start_pair("distance_estimate");
            if (((double)(long)storedistance_estimate) == storedistance_estimate)
                handler.number_value((long)storedistance_estimate);
            else
                handler.number_value(storedistance_estimate);
          }
        Debug.Assert(partial_allowed || flagHasdistance_unit);
        if (flagHasdistance_unit)
          {
            handler.start_pair("distance_unit");
            handler.string_value(storedistance_unit);
          }
        Debug.Assert(partial_allowed || flagHasduration_estimate);
        if (flagHasduration_estimate)
          {
            handler.start_pair("duration_estimate");
            if (((double)(long)storeduration_estimate) == storeduration_estimate)
                handler.number_value((long)storeduration_estimate);
            else
                handler.number_value(storeduration_estimate);
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
        if (!(hasdistance_estimate()))
          {
            return "When parsing the object for %what%, the \"distance_estimate\" field was missing.";
          }
        if (!(hasdistance_unit()))
          {
            return "When parsing the object for %what%, the \"distance_unit\" field was missing.";
          }
        if (!(hasduration_estimate()))
          {
            return "When parsing the object for %what%, the \"duration_estimate\" field was missing.";
          }
        return null;
      }

    public static UberRequestEstimateTripJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestEstimateTripJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestEstimateTrip", ignore_extras);
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
    public static UberRequestEstimateTripJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestEstimateTripJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestEstimateTripJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestEstimateTrip", ignore_extras);
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
    public static UberRequestEstimateTripJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestEstimateTripJSON from_text(string text, bool ignore_extras)
      {
        UberRequestEstimateTripJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestEstimateTrip", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberRequestEstimateTripJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberRequestEstimateTripJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberRequestEstimateTripJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestEstimateTrip", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratordistance_estimate;
        private JSONHoldingStringGenerator fieldGeneratordistance_unit;
        private JSONHoldingNumberTextGenerator fieldGeneratorduration_estimate;
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
            UberRequestEstimateTripJSON result = new UberRequestEstimateTripJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberRequestEstimateTripAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberRequestEstimateTripJSON result)
          {
            if (fieldGeneratordistance_estimate.have_value)
              {
                result.setdistance_estimateText(fieldGeneratordistance_estimate.value);
                fieldGeneratordistance_estimate.have_value = false;
              }
            else if ((!(result.hasdistance_estimate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"distance_estimate\" field was missing.");
              }
            if (fieldGeneratordistance_unit.have_value)
              {
                result.setdistance_unit(fieldGeneratordistance_unit.value);
                fieldGeneratordistance_unit.have_value = false;
              }
            else if ((!(result.hasdistance_unit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"distance_unit\" field was missing.");
              }
            if (fieldGeneratorduration_estimate.have_value)
              {
                result.setduration_estimateText(fieldGeneratorduration_estimate.value);
                fieldGeneratorduration_estimate.have_value = false;
              }
            else if ((!(result.hasduration_estimate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"duration_estimate\" field was missing.");
              }
          }
        protected abstract void handle_result(UberRequestEstimateTripJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "d", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'i':
                        if (String.Compare(field_name, 2, "stance_", 0, 7, false) == 0)
                          {
                            switch (field_name[9])
                              {
                                case 'e':
                                    if ((String.Compare(field_name, 10, "stimate", 0, 7, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratordistance_estimate;
                                    break;
                                case 'u':
                                    if ((String.Compare(field_name, 10, "nit", 0, 3, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratordistance_unit;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 2, "ration_estimate", 0, 15, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorduration_estimate;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratordistance_estimate = new JSONHoldingNumberTextGenerator("field \"distance_estimate\" of the UberRequestEstimateTrip class");
            fieldGeneratordistance_unit = new JSONHoldingStringGenerator("field \"distance_unit\" of the UberRequestEstimateTrip class");
            fieldGeneratorduration_estimate = new JSONHoldingNumberTextGenerator("field \"duration_estimate\" of the UberRequestEstimateTrip class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberRequestEstimateTrip class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratordistance_estimate = new JSONHoldingNumberTextGenerator("field \"distance_estimate\" of the UberRequestEstimateTrip class");
            fieldGeneratordistance_unit = new JSONHoldingStringGenerator("field \"distance_unit\" of the UberRequestEstimateTrip class");
            fieldGeneratorduration_estimate = new JSONHoldingNumberTextGenerator("field \"duration_estimate\" of the UberRequestEstimateTrip class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberRequestEstimateTrip class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratordistance_estimate.reset();
            fieldGeneratordistance_unit.reset();
            fieldGeneratorduration_estimate.reset();
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
        protected override void handle_result(UberRequestEstimateTripJSON  result)
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
        public UberRequestEstimateTripJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberRequestEstimateTripJSON  result)
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
    protected virtual void handle_result(List<UberRequestEstimateTripJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberRequestEstimateTripJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberRequestEstimateTripJSON>();
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
    public List<UberRequestEstimateTripJSON> value;
  };
  };
