/* file "SportsUserDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsUserDataJSON : JSONBase
  {
    private bool flagHasNow;
    private DateAndOrTimeJSON  storeNow;
    private bool flagHasLatitude;
    private double storeLatitude;
    private string textStoreLatitude;
    private bool flagHasLongitude;
    private double storeLongitude;
    private string textStoreLongitude;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONNow(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setNow(convert_classy);
      }


    private void  fromJSONLatitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Latitude of SportsUserDataJSON is not a number.");
              }
          }
        setLatitudeText(the_rational_text);
      }


    private void  fromJSONLongitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Longitude of SportsUserDataJSON is not a number.");
              }
          }
        setLongitudeText(the_rational_text);
      }


    public SportsUserDataJSON()
      {
        flagHasNow = false;
        flagHasLatitude = false;
        flagHasLongitude = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasNow()
      {
        return flagHasNow;
      }

    public DateAndOrTimeJSON   getNow()
      {
        Debug.Assert(flagHasNow);
        return storeNow;
      }

    public bool  hasLatitude()
      {
        return flagHasLatitude;
      }

    public double  getLatitude()
      {
        Debug.Assert(flagHasLatitude);
        if (textStoreLatitude != "")
          {
            return Double.Parse(textStoreLatitude);
          }
        return storeLatitude;
      }

    public string  getLatitudeAsText()
      {
        Debug.Assert(flagHasLatitude);
        if (textStoreLatitude == "")
          {
            return Convert.ToString(storeLatitude);
          }
        else
          {
            return (textStoreLatitude);
          }
      }

    public bool  hasLongitude()
      {
        return flagHasLongitude;
      }

    public double  getLongitude()
      {
        Debug.Assert(flagHasLongitude);
        if (textStoreLongitude != "")
          {
            return Double.Parse(textStoreLongitude);
          }
        return storeLongitude;
      }

    public string  getLongitudeAsText()
      {
        Debug.Assert(flagHasLongitude);
        if (textStoreLongitude == "")
          {
            return Convert.ToString(storeLongitude);
          }
        else
          {
            return (textStoreLongitude);
          }
      }


    public virtual int extraSportsUserDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsUserDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsUserDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsUserDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setNow(DateAndOrTimeJSON  new_value)
      {
        if (flagHasNow)
          {
          }
        flagHasNow = true;
        storeNow = new_value;
      }
    public void unsetNow()
      {
        if (flagHasNow)
          {
          }
        flagHasNow = false;
      }
    public void setLatitude(double new_value)
      {
        flagHasLatitude = true;
        if (new_value < -90)
            throw new Exception("The value for field Latitude of SportsUserDataJSON is less than the lower bound (-90) for that field.");
        if (new_value > 90)
            throw new Exception("The value for field Latitude of SportsUserDataJSON is greater than the upper bound (90) for that field.");
        storeLatitude = new_value;
        textStoreLatitude = "";
      }
    public void setLatitudeText(string new_value)
      {
        flagHasLatitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Latitude of SportsUserDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "90", "", false, "2") < 0)
            throw new Exception("The value for field Latitude of SportsUserDataJSON is less than the lower bound (-90) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "90", "", false, "2") > 0)
            throw new Exception("The value for field Latitude of SportsUserDataJSON is greater than the upper bound (90) for that field.");
        textStoreLatitude = new_value;
      }
    public void unsetLatitude()
      {
        flagHasLatitude = false;
      }
    public void setLongitude(double new_value)
      {
        flagHasLongitude = true;
        if (new_value < -180)
            throw new Exception("The value for field Longitude of SportsUserDataJSON is less than the lower bound (-180) for that field.");
        if (new_value > 180)
            throw new Exception("The value for field Longitude of SportsUserDataJSON is greater than the upper bound (180) for that field.");
        storeLongitude = new_value;
        textStoreLongitude = "";
      }
    public void setLongitudeText(string new_value)
      {
        flagHasLongitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Longitude of SportsUserDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "180", "", false, "3") < 0)
            throw new Exception("The value for field Longitude of SportsUserDataJSON is less than the lower bound (-180) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "180", "", false, "3") > 0)
            throw new Exception("The value for field Longitude of SportsUserDataJSON is greater than the upper bound (180) for that field.");
        textStoreLongitude = new_value;
      }
    public void unsetLongitude()
      {
        flagHasLongitude = false;
      }

    public virtual void extraSportsUserDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsUserDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsUserDataLookup(key);
        if (old_field == null)
          {
            extraSportsUserDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNow);
        if (flagHasNow)
          {
            handler.start_pair("Now");
            if (partial_allowed)
                storeNow.write_partial_as_json(handler);
            else
                storeNow.write_as_json(handler);
          }
        if (flagHasLatitude)
          {
            handler.start_pair("Latitude");
            if (textStoreLatitude != "")
                handler.number_value(textStoreLatitude);
            else if (((double)(long)storeLatitude) == storeLatitude)
                handler.number_value((long)storeLatitude);
            else
                handler.number_value(storeLatitude);
          }
        if (flagHasLongitude)
          {
            handler.start_pair("Longitude");
            if (textStoreLongitude != "")
                handler.number_value(textStoreLongitude);
            else if (((double)(long)storeLongitude) == storeLongitude)
                handler.number_value((long)storeLongitude);
            else
                handler.number_value(storeLongitude);
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
        if (!(hasNow()))
          {
            return "When parsing the object for %what%, the \"Now\" field was missing.";
          }
        return null;
      }

    public static SportsUserDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsUserDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsUserData", ignore_extras);
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
    public static SportsUserDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsUserDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsUserDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsUserData", ignore_extras);
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
    public static SportsUserDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsUserDataJSON from_text(string text, bool ignore_extras)
      {
        SportsUserDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsUserData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsUserDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsUserDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsUserDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsUserData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNow;
        private JSONHoldingNumberTextGenerator fieldGeneratorLatitude;
        private JSONHoldingNumberTextGenerator fieldGeneratorLongitude;
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
            SportsUserDataJSON result = new SportsUserDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsUserDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsUserDataJSON result)
          {
            if (fieldGeneratorNow.have_value)
              {
                result.setNow(fieldGeneratorNow.value);
                fieldGeneratorNow.have_value = false;
              }
            else if ((!(result.hasNow())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Now\" field was missing.");
              }
            if (fieldGeneratorLatitude.have_value)
              {
                result.setLatitudeText(fieldGeneratorLatitude.value);
                fieldGeneratorLatitude.have_value = false;
              }
            if (fieldGeneratorLongitude.have_value)
              {
                result.setLongitudeText(fieldGeneratorLongitude.value);
                fieldGeneratorLongitude.have_value = false;
              }
          }
        protected abstract void handle_result(SportsUserDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorLatitude;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ngitude", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorLongitude;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ow", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorNow;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorNow = new DateAndOrTimeJSON.HoldingGenerator("field \"Now\" of the SportsUserData class", ignore_extras);
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the SportsUserData class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the SportsUserData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsUserData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorNow = new DateAndOrTimeJSON.HoldingGenerator("field \"Now\" of the SportsUserData class", false);
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the SportsUserData class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the SportsUserData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsUserData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorNow.reset();
            fieldGeneratorLatitude.reset();
            fieldGeneratorLongitude.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorNow.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorNow.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsUserDataJSON  result)
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
        public SportsUserDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsUserDataJSON  result)
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
    protected virtual void handle_result(List<SportsUserDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsUserDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsUserDataJSON>();
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
    public List<SportsUserDataJSON> value;
  };
  };
