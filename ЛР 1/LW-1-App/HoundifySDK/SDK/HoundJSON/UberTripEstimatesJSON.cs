/* file "UberTripEstimatesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberTripEstimatesJSON : JSONBase
  {
    private bool flagHasPriceEstimateRange;
    private string storePriceEstimateRange;
    private bool flagHasLowPriceEstimate;
    private double storeLowPriceEstimate;
    private string textStoreLowPriceEstimate;
    private bool flagHasHighPriceEstimate;
    private double storeHighPriceEstimate;
    private string textStoreHighPriceEstimate;
    private bool flagHasCurrency;
    private string storeCurrency;
    private bool flagHasSurgeMultiplier;
    private double storeSurgeMultiplier;
    private string textStoreSurgeMultiplier;
    private bool flagHasDurationEstimateInSeconds;
    private double storeDurationEstimateInSeconds;
    private string textStoreDurationEstimateInSeconds;
    private bool flagHasDistanceEstimateInMiles;
    private double storeDistanceEstimateInMiles;
    private string textStoreDistanceEstimateInMiles;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPriceEstimateRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PriceEstimateRange of UberTripEstimatesJSON is not a string.");
        setPriceEstimateRange(json_string.getData());
      }


    private void  fromJSONLowPriceEstimate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field LowPriceEstimate of UberTripEstimatesJSON is not a number.");
              }
          }
        setLowPriceEstimateText(the_rational_text);
      }


    private void  fromJSONHighPriceEstimate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HighPriceEstimate of UberTripEstimatesJSON is not a number.");
              }
          }
        setHighPriceEstimateText(the_rational_text);
      }


    private void  fromJSONCurrency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Currency of UberTripEstimatesJSON is not a string.");
        setCurrency(json_string.getData());
      }


    private void  fromJSONSurgeMultiplier(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SurgeMultiplier of UberTripEstimatesJSON is not a number.");
              }
          }
        setSurgeMultiplierText(the_rational_text);
      }


    private void  fromJSONDurationEstimateInSeconds(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DurationEstimateInSeconds of UberTripEstimatesJSON is not a number.");
              }
          }
        setDurationEstimateInSecondsText(the_rational_text);
      }


    private void  fromJSONDistanceEstimateInMiles(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DistanceEstimateInMiles of UberTripEstimatesJSON is not a number.");
              }
          }
        setDistanceEstimateInMilesText(the_rational_text);
      }


    public UberTripEstimatesJSON()
      {
        flagHasPriceEstimateRange = false;
        flagHasLowPriceEstimate = false;
        flagHasHighPriceEstimate = false;
        flagHasCurrency = false;
        flagHasSurgeMultiplier = false;
        flagHasDurationEstimateInSeconds = false;
        flagHasDistanceEstimateInMiles = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPriceEstimateRange()
      {
        return flagHasPriceEstimateRange;
      }

    public string  getPriceEstimateRange()
      {
        Debug.Assert(flagHasPriceEstimateRange);
        return storePriceEstimateRange;
      }

    public bool  hasLowPriceEstimate()
      {
        return flagHasLowPriceEstimate;
      }

    public double  getLowPriceEstimate()
      {
        Debug.Assert(flagHasLowPriceEstimate);
        if (textStoreLowPriceEstimate != "")
          {
            return Double.Parse(textStoreLowPriceEstimate);
          }
        return storeLowPriceEstimate;
      }

    public string  getLowPriceEstimateAsText()
      {
        Debug.Assert(flagHasLowPriceEstimate);
        if (textStoreLowPriceEstimate == "")
          {
            return Convert.ToString(storeLowPriceEstimate);
          }
        else
          {
            return (textStoreLowPriceEstimate);
          }
      }

    public bool  hasHighPriceEstimate()
      {
        return flagHasHighPriceEstimate;
      }

    public double  getHighPriceEstimate()
      {
        Debug.Assert(flagHasHighPriceEstimate);
        if (textStoreHighPriceEstimate != "")
          {
            return Double.Parse(textStoreHighPriceEstimate);
          }
        return storeHighPriceEstimate;
      }

    public string  getHighPriceEstimateAsText()
      {
        Debug.Assert(flagHasHighPriceEstimate);
        if (textStoreHighPriceEstimate == "")
          {
            return Convert.ToString(storeHighPriceEstimate);
          }
        else
          {
            return (textStoreHighPriceEstimate);
          }
      }

    public bool  hasCurrency()
      {
        return flagHasCurrency;
      }

    public string  getCurrency()
      {
        Debug.Assert(flagHasCurrency);
        return storeCurrency;
      }

    public bool  hasSurgeMultiplier()
      {
        return flagHasSurgeMultiplier;
      }

    public double  getSurgeMultiplier()
      {
        Debug.Assert(flagHasSurgeMultiplier);
        if (textStoreSurgeMultiplier != "")
          {
            return Double.Parse(textStoreSurgeMultiplier);
          }
        return storeSurgeMultiplier;
      }

    public string  getSurgeMultiplierAsText()
      {
        Debug.Assert(flagHasSurgeMultiplier);
        if (textStoreSurgeMultiplier == "")
          {
            return Convert.ToString(storeSurgeMultiplier);
          }
        else
          {
            return (textStoreSurgeMultiplier);
          }
      }

    public bool  hasDurationEstimateInSeconds()
      {
        return flagHasDurationEstimateInSeconds;
      }

    public double  getDurationEstimateInSeconds()
      {
        Debug.Assert(flagHasDurationEstimateInSeconds);
        if (textStoreDurationEstimateInSeconds != "")
          {
            return Double.Parse(textStoreDurationEstimateInSeconds);
          }
        return storeDurationEstimateInSeconds;
      }

    public string  getDurationEstimateInSecondsAsText()
      {
        Debug.Assert(flagHasDurationEstimateInSeconds);
        if (textStoreDurationEstimateInSeconds == "")
          {
            return Convert.ToString(storeDurationEstimateInSeconds);
          }
        else
          {
            return (textStoreDurationEstimateInSeconds);
          }
      }

    public bool  hasDistanceEstimateInMiles()
      {
        return flagHasDistanceEstimateInMiles;
      }

    public double  getDistanceEstimateInMiles()
      {
        Debug.Assert(flagHasDistanceEstimateInMiles);
        if (textStoreDistanceEstimateInMiles != "")
          {
            return Double.Parse(textStoreDistanceEstimateInMiles);
          }
        return storeDistanceEstimateInMiles;
      }

    public string  getDistanceEstimateInMilesAsText()
      {
        Debug.Assert(flagHasDistanceEstimateInMiles);
        if (textStoreDistanceEstimateInMiles == "")
          {
            return Convert.ToString(storeDistanceEstimateInMiles);
          }
        else
          {
            return (textStoreDistanceEstimateInMiles);
          }
      }


    public virtual int extraUberTripEstimatesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberTripEstimatesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberTripEstimatesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberTripEstimatesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPriceEstimateRange(string new_value)
      {
        flagHasPriceEstimateRange = true;
        storePriceEstimateRange = new_value;
      }
    public void unsetPriceEstimateRange()
      {
        flagHasPriceEstimateRange = false;
      }
    public void setLowPriceEstimate(double new_value)
      {
        flagHasLowPriceEstimate = true;
        storeLowPriceEstimate = new_value;
        textStoreLowPriceEstimate = "";
      }
    public void setLowPriceEstimateText(string new_value)
      {
        flagHasLowPriceEstimate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field LowPriceEstimate of UberTripEstimatesJSON is not a valid number.");
        textStoreLowPriceEstimate = new_value;
      }
    public void unsetLowPriceEstimate()
      {
        flagHasLowPriceEstimate = false;
      }
    public void setHighPriceEstimate(double new_value)
      {
        flagHasHighPriceEstimate = true;
        storeHighPriceEstimate = new_value;
        textStoreHighPriceEstimate = "";
      }
    public void setHighPriceEstimateText(string new_value)
      {
        flagHasHighPriceEstimate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HighPriceEstimate of UberTripEstimatesJSON is not a valid number.");
        textStoreHighPriceEstimate = new_value;
      }
    public void unsetHighPriceEstimate()
      {
        flagHasHighPriceEstimate = false;
      }
    public void setCurrency(string new_value)
      {
        flagHasCurrency = true;
        storeCurrency = new_value;
      }
    public void unsetCurrency()
      {
        flagHasCurrency = false;
      }
    public void setSurgeMultiplier(double new_value)
      {
        flagHasSurgeMultiplier = true;
        storeSurgeMultiplier = new_value;
        textStoreSurgeMultiplier = "";
      }
    public void setSurgeMultiplierText(string new_value)
      {
        flagHasSurgeMultiplier = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field SurgeMultiplier of UberTripEstimatesJSON is not a valid number.");
        textStoreSurgeMultiplier = new_value;
      }
    public void unsetSurgeMultiplier()
      {
        flagHasSurgeMultiplier = false;
      }
    public void setDurationEstimateInSeconds(double new_value)
      {
        flagHasDurationEstimateInSeconds = true;
        storeDurationEstimateInSeconds = new_value;
        textStoreDurationEstimateInSeconds = "";
      }
    public void setDurationEstimateInSecondsText(string new_value)
      {
        flagHasDurationEstimateInSeconds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field DurationEstimateInSeconds of UberTripEstimatesJSON is not a valid number.");
        textStoreDurationEstimateInSeconds = new_value;
      }
    public void unsetDurationEstimateInSeconds()
      {
        flagHasDurationEstimateInSeconds = false;
      }
    public void setDistanceEstimateInMiles(double new_value)
      {
        flagHasDistanceEstimateInMiles = true;
        storeDistanceEstimateInMiles = new_value;
        textStoreDistanceEstimateInMiles = "";
      }
    public void setDistanceEstimateInMilesText(string new_value)
      {
        flagHasDistanceEstimateInMiles = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field DistanceEstimateInMiles of UberTripEstimatesJSON is not a valid number.");
        textStoreDistanceEstimateInMiles = new_value;
      }
    public void unsetDistanceEstimateInMiles()
      {
        flagHasDistanceEstimateInMiles = false;
      }

    public virtual void extraUberTripEstimatesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberTripEstimatesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberTripEstimatesLookup(key);
        if (old_field == null)
          {
            extraUberTripEstimatesAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPriceEstimateRange);
        if (flagHasPriceEstimateRange)
          {
            handler.start_pair("PriceEstimateRange");
            handler.string_value(storePriceEstimateRange);
          }
        if (flagHasLowPriceEstimate)
          {
            handler.start_pair("LowPriceEstimate");
            if (textStoreLowPriceEstimate != "")
                handler.number_value(textStoreLowPriceEstimate);
            else if (((double)(long)storeLowPriceEstimate) == storeLowPriceEstimate)
                handler.number_value((long)storeLowPriceEstimate);
            else
                handler.number_value(storeLowPriceEstimate);
          }
        if (flagHasHighPriceEstimate)
          {
            handler.start_pair("HighPriceEstimate");
            if (textStoreHighPriceEstimate != "")
                handler.number_value(textStoreHighPriceEstimate);
            else if (((double)(long)storeHighPriceEstimate) == storeHighPriceEstimate)
                handler.number_value((long)storeHighPriceEstimate);
            else
                handler.number_value(storeHighPriceEstimate);
          }
        if (flagHasCurrency)
          {
            handler.start_pair("Currency");
            handler.string_value(storeCurrency);
          }
        Debug.Assert(partial_allowed || flagHasSurgeMultiplier);
        if (flagHasSurgeMultiplier)
          {
            handler.start_pair("SurgeMultiplier");
            if (textStoreSurgeMultiplier != "")
                handler.number_value(textStoreSurgeMultiplier);
            else if (((double)(long)storeSurgeMultiplier) == storeSurgeMultiplier)
                handler.number_value((long)storeSurgeMultiplier);
            else
                handler.number_value(storeSurgeMultiplier);
          }
        Debug.Assert(partial_allowed || flagHasDurationEstimateInSeconds);
        if (flagHasDurationEstimateInSeconds)
          {
            handler.start_pair("DurationEstimateInSeconds");
            if (textStoreDurationEstimateInSeconds != "")
                handler.number_value(textStoreDurationEstimateInSeconds);
            else if (((double)(long)storeDurationEstimateInSeconds) == storeDurationEstimateInSeconds)
                handler.number_value((long)storeDurationEstimateInSeconds);
            else
                handler.number_value(storeDurationEstimateInSeconds);
          }
        Debug.Assert(partial_allowed || flagHasDistanceEstimateInMiles);
        if (flagHasDistanceEstimateInMiles)
          {
            handler.start_pair("DistanceEstimateInMiles");
            if (textStoreDistanceEstimateInMiles != "")
                handler.number_value(textStoreDistanceEstimateInMiles);
            else if (((double)(long)storeDistanceEstimateInMiles) == storeDistanceEstimateInMiles)
                handler.number_value((long)storeDistanceEstimateInMiles);
            else
                handler.number_value(storeDistanceEstimateInMiles);
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
        if (!(hasPriceEstimateRange()))
          {
            return "When parsing the object for %what%, the \"PriceEstimateRange\" field was missing.";
          }
        if (!(hasSurgeMultiplier()))
          {
            return "When parsing the object for %what%, the \"SurgeMultiplier\" field was missing.";
          }
        if (!(hasDurationEstimateInSeconds()))
          {
            return "When parsing the object for %what%, the \"DurationEstimateInSeconds\" field was missing.";
          }
        if (!(hasDistanceEstimateInMiles()))
          {
            return "When parsing the object for %what%, the \"DistanceEstimateInMiles\" field was missing.";
          }
        return null;
      }

    public static UberTripEstimatesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberTripEstimatesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTripEstimates", ignore_extras);
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
    public static UberTripEstimatesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberTripEstimatesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberTripEstimatesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTripEstimates", ignore_extras);
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
    public static UberTripEstimatesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberTripEstimatesJSON from_text(string text, bool ignore_extras)
      {
        UberTripEstimatesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTripEstimates", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberTripEstimatesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberTripEstimatesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberTripEstimatesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTripEstimates", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorPriceEstimateRange;
        private JSONHoldingNumberTextGenerator fieldGeneratorLowPriceEstimate;
        private JSONHoldingNumberTextGenerator fieldGeneratorHighPriceEstimate;
        private JSONHoldingStringGenerator fieldGeneratorCurrency;
        private JSONHoldingNumberTextGenerator fieldGeneratorSurgeMultiplier;
        private JSONHoldingNumberTextGenerator fieldGeneratorDurationEstimateInSeconds;
        private JSONHoldingNumberTextGenerator fieldGeneratorDistanceEstimateInMiles;
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
            UberTripEstimatesJSON result = new UberTripEstimatesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberTripEstimatesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberTripEstimatesJSON result)
          {
            if (fieldGeneratorPriceEstimateRange.have_value)
              {
                result.setPriceEstimateRange(fieldGeneratorPriceEstimateRange.value);
                fieldGeneratorPriceEstimateRange.have_value = false;
              }
            else if ((!(result.hasPriceEstimateRange())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PriceEstimateRange\" field was missing.");
              }
            if (fieldGeneratorLowPriceEstimate.have_value)
              {
                result.setLowPriceEstimateText(fieldGeneratorLowPriceEstimate.value);
                fieldGeneratorLowPriceEstimate.have_value = false;
              }
            if (fieldGeneratorHighPriceEstimate.have_value)
              {
                result.setHighPriceEstimateText(fieldGeneratorHighPriceEstimate.value);
                fieldGeneratorHighPriceEstimate.have_value = false;
              }
            if (fieldGeneratorCurrency.have_value)
              {
                result.setCurrency(fieldGeneratorCurrency.value);
                fieldGeneratorCurrency.have_value = false;
              }
            if (fieldGeneratorSurgeMultiplier.have_value)
              {
                result.setSurgeMultiplierText(fieldGeneratorSurgeMultiplier.value);
                fieldGeneratorSurgeMultiplier.have_value = false;
              }
            else if ((!(result.hasSurgeMultiplier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SurgeMultiplier\" field was missing.");
              }
            if (fieldGeneratorDurationEstimateInSeconds.have_value)
              {
                result.setDurationEstimateInSecondsText(fieldGeneratorDurationEstimateInSeconds.value);
                fieldGeneratorDurationEstimateInSeconds.have_value = false;
              }
            else if ((!(result.hasDurationEstimateInSeconds())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DurationEstimateInSeconds\" field was missing.");
              }
            if (fieldGeneratorDistanceEstimateInMiles.have_value)
              {
                result.setDistanceEstimateInMilesText(fieldGeneratorDistanceEstimateInMiles.value);
                fieldGeneratorDistanceEstimateInMiles.have_value = false;
              }
            else if ((!(result.hasDistanceEstimateInMiles())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DistanceEstimateInMiles\" field was missing.");
              }
          }
        protected abstract void handle_result(UberTripEstimatesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "urrency", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorCurrency;
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "stanceEstimateInMiles", 0, 21, false) == 0) && (field_name.Length == 23))
                                return fieldGeneratorDistanceEstimateInMiles;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rationEstimateInSeconds", 0, 23, false) == 0) && (field_name.Length == 25))
                                return fieldGeneratorDurationEstimateInSeconds;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "ighPriceEstimate", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorHighPriceEstimate;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "owPriceEstimate", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorLowPriceEstimate;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "riceEstimateRange", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorPriceEstimateRange;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "urgeMultiplier", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorSurgeMultiplier;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPriceEstimateRange = new JSONHoldingStringGenerator("field \"PriceEstimateRange\" of the UberTripEstimates class");
            fieldGeneratorLowPriceEstimate = new JSONHoldingNumberTextGenerator("field \"LowPriceEstimate\" of the UberTripEstimates class");
            fieldGeneratorHighPriceEstimate = new JSONHoldingNumberTextGenerator("field \"HighPriceEstimate\" of the UberTripEstimates class");
            fieldGeneratorCurrency = new JSONHoldingStringGenerator("field \"Currency\" of the UberTripEstimates class");
            fieldGeneratorSurgeMultiplier = new JSONHoldingNumberTextGenerator("field \"SurgeMultiplier\" of the UberTripEstimates class");
            fieldGeneratorDurationEstimateInSeconds = new JSONHoldingNumberTextGenerator("field \"DurationEstimateInSeconds\" of the UberTripEstimates class");
            fieldGeneratorDistanceEstimateInMiles = new JSONHoldingNumberTextGenerator("field \"DistanceEstimateInMiles\" of the UberTripEstimates class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberTripEstimates class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPriceEstimateRange = new JSONHoldingStringGenerator("field \"PriceEstimateRange\" of the UberTripEstimates class");
            fieldGeneratorLowPriceEstimate = new JSONHoldingNumberTextGenerator("field \"LowPriceEstimate\" of the UberTripEstimates class");
            fieldGeneratorHighPriceEstimate = new JSONHoldingNumberTextGenerator("field \"HighPriceEstimate\" of the UberTripEstimates class");
            fieldGeneratorCurrency = new JSONHoldingStringGenerator("field \"Currency\" of the UberTripEstimates class");
            fieldGeneratorSurgeMultiplier = new JSONHoldingNumberTextGenerator("field \"SurgeMultiplier\" of the UberTripEstimates class");
            fieldGeneratorDurationEstimateInSeconds = new JSONHoldingNumberTextGenerator("field \"DurationEstimateInSeconds\" of the UberTripEstimates class");
            fieldGeneratorDistanceEstimateInMiles = new JSONHoldingNumberTextGenerator("field \"DistanceEstimateInMiles\" of the UberTripEstimates class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberTripEstimates class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPriceEstimateRange.reset();
            fieldGeneratorLowPriceEstimate.reset();
            fieldGeneratorHighPriceEstimate.reset();
            fieldGeneratorCurrency.reset();
            fieldGeneratorSurgeMultiplier.reset();
            fieldGeneratorDurationEstimateInSeconds.reset();
            fieldGeneratorDistanceEstimateInMiles.reset();
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
        protected override void handle_result(UberTripEstimatesJSON  result)
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
        public UberTripEstimatesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberTripEstimatesJSON  result)
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
    protected virtual void handle_result(List<UberTripEstimatesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberTripEstimatesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberTripEstimatesJSON>();
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
    public List<UberTripEstimatesJSON> value;
  };
  };
