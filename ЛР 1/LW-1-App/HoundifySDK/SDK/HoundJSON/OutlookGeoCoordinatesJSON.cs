/* file "OutlookGeoCoordinatesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class OutlookGeoCoordinatesJSON : JSONBase
  {
    private bool flagHasaccuracy;
    private double storeaccuracy;
    private string textStoreaccuracy;
    private bool flagHasaltitude;
    private double storealtitude;
    private string textStorealtitude;
    private bool flagHasaltitudeAccuracy;
    private double storealtitudeAccuracy;
    private string textStorealtitudeAccuracy;
    private bool flagHaslatitude;
    private double storelatitude;
    private string textStorelatitude;
    private bool flagHaslongitude;
    private double storelongitude;
    private string textStorelongitude;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONaccuracy(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field accuracy of OutlookGeoCoordinatesJSON is not a number.");
              }
          }
        setaccuracyText(the_rational_text);
      }


    private void  fromJSONaltitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field altitude of OutlookGeoCoordinatesJSON is not a number.");
              }
          }
        setaltitudeText(the_rational_text);
      }


    private void  fromJSONaltitudeAccuracy(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field altitudeAccuracy of OutlookGeoCoordinatesJSON is not a number.");
              }
          }
        setaltitudeAccuracyText(the_rational_text);
      }


    private void  fromJSONlatitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field latitude of OutlookGeoCoordinatesJSON is not a number.");
              }
          }
        setlatitudeText(the_rational_text);
      }


    private void  fromJSONlongitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field longitude of OutlookGeoCoordinatesJSON is not a number.");
              }
          }
        setlongitudeText(the_rational_text);
      }


    public OutlookGeoCoordinatesJSON()
      {
        flagHasaccuracy = false;
        flagHasaltitude = false;
        flagHasaltitudeAccuracy = false;
        flagHaslatitude = false;
        flagHaslongitude = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasaccuracy()
      {
        return flagHasaccuracy;
      }

    public double  getaccuracy()
      {
        Debug.Assert(flagHasaccuracy);
        if (textStoreaccuracy != "")
          {
            return Double.Parse(textStoreaccuracy);
          }
        return storeaccuracy;
      }

    public string  getaccuracyAsText()
      {
        Debug.Assert(flagHasaccuracy);
        if (textStoreaccuracy == "")
          {
            return Convert.ToString(storeaccuracy);
          }
        else
          {
            return (textStoreaccuracy);
          }
      }

    public bool  hasaltitude()
      {
        return flagHasaltitude;
      }

    public double  getaltitude()
      {
        Debug.Assert(flagHasaltitude);
        if (textStorealtitude != "")
          {
            return Double.Parse(textStorealtitude);
          }
        return storealtitude;
      }

    public string  getaltitudeAsText()
      {
        Debug.Assert(flagHasaltitude);
        if (textStorealtitude == "")
          {
            return Convert.ToString(storealtitude);
          }
        else
          {
            return (textStorealtitude);
          }
      }

    public bool  hasaltitudeAccuracy()
      {
        return flagHasaltitudeAccuracy;
      }

    public double  getaltitudeAccuracy()
      {
        Debug.Assert(flagHasaltitudeAccuracy);
        if (textStorealtitudeAccuracy != "")
          {
            return Double.Parse(textStorealtitudeAccuracy);
          }
        return storealtitudeAccuracy;
      }

    public string  getaltitudeAccuracyAsText()
      {
        Debug.Assert(flagHasaltitudeAccuracy);
        if (textStorealtitudeAccuracy == "")
          {
            return Convert.ToString(storealtitudeAccuracy);
          }
        else
          {
            return (textStorealtitudeAccuracy);
          }
      }

    public bool  haslatitude()
      {
        return flagHaslatitude;
      }

    public double  getlatitude()
      {
        Debug.Assert(flagHaslatitude);
        if (textStorelatitude != "")
          {
            return Double.Parse(textStorelatitude);
          }
        return storelatitude;
      }

    public string  getlatitudeAsText()
      {
        Debug.Assert(flagHaslatitude);
        if (textStorelatitude == "")
          {
            return Convert.ToString(storelatitude);
          }
        else
          {
            return (textStorelatitude);
          }
      }

    public bool  haslongitude()
      {
        return flagHaslongitude;
      }

    public double  getlongitude()
      {
        Debug.Assert(flagHaslongitude);
        if (textStorelongitude != "")
          {
            return Double.Parse(textStorelongitude);
          }
        return storelongitude;
      }

    public string  getlongitudeAsText()
      {
        Debug.Assert(flagHaslongitude);
        if (textStorelongitude == "")
          {
            return Convert.ToString(storelongitude);
          }
        else
          {
            return (textStorelongitude);
          }
      }


    public virtual int extraOutlookGeoCoordinatesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOutlookGeoCoordinatesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOutlookGeoCoordinatesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOutlookGeoCoordinatesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setaccuracy(double new_value)
      {
        flagHasaccuracy = true;
        storeaccuracy = new_value;
        textStoreaccuracy = "";
      }
    public void setaccuracyText(string new_value)
      {
        flagHasaccuracy = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field accuracy of OutlookGeoCoordinatesJSON is not a valid number.");
        textStoreaccuracy = new_value;
      }
    public void unsetaccuracy()
      {
        flagHasaccuracy = false;
      }
    public void setaltitude(double new_value)
      {
        flagHasaltitude = true;
        storealtitude = new_value;
        textStorealtitude = "";
      }
    public void setaltitudeText(string new_value)
      {
        flagHasaltitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field altitude of OutlookGeoCoordinatesJSON is not a valid number.");
        textStorealtitude = new_value;
      }
    public void unsetaltitude()
      {
        flagHasaltitude = false;
      }
    public void setaltitudeAccuracy(double new_value)
      {
        flagHasaltitudeAccuracy = true;
        storealtitudeAccuracy = new_value;
        textStorealtitudeAccuracy = "";
      }
    public void setaltitudeAccuracyText(string new_value)
      {
        flagHasaltitudeAccuracy = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field altitudeAccuracy of OutlookGeoCoordinatesJSON is not a valid number.");
        textStorealtitudeAccuracy = new_value;
      }
    public void unsetaltitudeAccuracy()
      {
        flagHasaltitudeAccuracy = false;
      }
    public void setlatitude(double new_value)
      {
        flagHaslatitude = true;
        storelatitude = new_value;
        textStorelatitude = "";
      }
    public void setlatitudeText(string new_value)
      {
        flagHaslatitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field latitude of OutlookGeoCoordinatesJSON is not a valid number.");
        textStorelatitude = new_value;
      }
    public void unsetlatitude()
      {
        flagHaslatitude = false;
      }
    public void setlongitude(double new_value)
      {
        flagHaslongitude = true;
        storelongitude = new_value;
        textStorelongitude = "";
      }
    public void setlongitudeText(string new_value)
      {
        flagHaslongitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field longitude of OutlookGeoCoordinatesJSON is not a valid number.");
        textStorelongitude = new_value;
      }
    public void unsetlongitude()
      {
        flagHaslongitude = false;
      }

    public virtual void extraOutlookGeoCoordinatesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOutlookGeoCoordinatesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOutlookGeoCoordinatesLookup(key);
        if (old_field == null)
          {
            extraOutlookGeoCoordinatesAppendPair(key, new_component);
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
        if (flagHasaccuracy)
          {
            handler.start_pair("accuracy");
            if (textStoreaccuracy != "")
                handler.number_value(textStoreaccuracy);
            else if (((double)(long)storeaccuracy) == storeaccuracy)
                handler.number_value((long)storeaccuracy);
            else
                handler.number_value(storeaccuracy);
          }
        if (flagHasaltitude)
          {
            handler.start_pair("altitude");
            if (textStorealtitude != "")
                handler.number_value(textStorealtitude);
            else if (((double)(long)storealtitude) == storealtitude)
                handler.number_value((long)storealtitude);
            else
                handler.number_value(storealtitude);
          }
        if (flagHasaltitudeAccuracy)
          {
            handler.start_pair("altitudeAccuracy");
            if (textStorealtitudeAccuracy != "")
                handler.number_value(textStorealtitudeAccuracy);
            else if (((double)(long)storealtitudeAccuracy) == storealtitudeAccuracy)
                handler.number_value((long)storealtitudeAccuracy);
            else
                handler.number_value(storealtitudeAccuracy);
          }
        if (flagHaslatitude)
          {
            handler.start_pair("latitude");
            if (textStorelatitude != "")
                handler.number_value(textStorelatitude);
            else if (((double)(long)storelatitude) == storelatitude)
                handler.number_value((long)storelatitude);
            else
                handler.number_value(storelatitude);
          }
        if (flagHaslongitude)
          {
            handler.start_pair("longitude");
            if (textStorelongitude != "")
                handler.number_value(textStorelongitude);
            else if (((double)(long)storelongitude) == storelongitude)
                handler.number_value((long)storelongitude);
            else
                handler.number_value(storelongitude);
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

    public static OutlookGeoCoordinatesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookGeoCoordinatesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookGeoCoordinates", ignore_extras);
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
    public static OutlookGeoCoordinatesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookGeoCoordinatesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookGeoCoordinatesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookGeoCoordinates", ignore_extras);
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
    public static OutlookGeoCoordinatesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookGeoCoordinatesJSON from_text(string text, bool ignore_extras)
      {
        OutlookGeoCoordinatesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookGeoCoordinates", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OutlookGeoCoordinatesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OutlookGeoCoordinatesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OutlookGeoCoordinatesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookGeoCoordinates", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratoraccuracy;
        private JSONHoldingNumberTextGenerator fieldGeneratoraltitude;
        private JSONHoldingNumberTextGenerator fieldGeneratoraltitudeAccuracy;
        private JSONHoldingNumberTextGenerator fieldGeneratorlatitude;
        private JSONHoldingNumberTextGenerator fieldGeneratorlongitude;
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
            OutlookGeoCoordinatesJSON result = new OutlookGeoCoordinatesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOutlookGeoCoordinatesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OutlookGeoCoordinatesJSON result)
          {
            if (fieldGeneratoraccuracy.have_value)
              {
                result.setaccuracyText(fieldGeneratoraccuracy.value);
                fieldGeneratoraccuracy.have_value = false;
              }
            if (fieldGeneratoraltitude.have_value)
              {
                result.setaltitudeText(fieldGeneratoraltitude.value);
                fieldGeneratoraltitude.have_value = false;
              }
            if (fieldGeneratoraltitudeAccuracy.have_value)
              {
                result.setaltitudeAccuracyText(fieldGeneratoraltitudeAccuracy.value);
                fieldGeneratoraltitudeAccuracy.have_value = false;
              }
            if (fieldGeneratorlatitude.have_value)
              {
                result.setlatitudeText(fieldGeneratorlatitude.value);
                fieldGeneratorlatitude.have_value = false;
              }
            if (fieldGeneratorlongitude.have_value)
              {
                result.setlongitudeText(fieldGeneratorlongitude.value);
                fieldGeneratorlongitude.have_value = false;
              }
          }
        protected abstract void handle_result(OutlookGeoCoordinatesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "curacy", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratoraccuracy;
                            break;
                        case 'l':
                            if (String.Compare(field_name, 2, "titude", 0, 6, false) == 0)
                              {
                                if (field_name.Length == 8)
                                  {
                                    return fieldGeneratoraltitude;
                                  }
                                switch (field_name[8])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 9, "ccuracy", 0, 7, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratoraltitudeAccuracy;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'l':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorlatitude;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ngitude", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorlongitude;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratoraccuracy = new JSONHoldingNumberTextGenerator("field \"accuracy\" of the OutlookGeoCoordinates class");
            fieldGeneratoraltitude = new JSONHoldingNumberTextGenerator("field \"altitude\" of the OutlookGeoCoordinates class");
            fieldGeneratoraltitudeAccuracy = new JSONHoldingNumberTextGenerator("field \"altitudeAccuracy\" of the OutlookGeoCoordinates class");
            fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the OutlookGeoCoordinates class");
            fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the OutlookGeoCoordinates class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OutlookGeoCoordinates class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratoraccuracy = new JSONHoldingNumberTextGenerator("field \"accuracy\" of the OutlookGeoCoordinates class");
            fieldGeneratoraltitude = new JSONHoldingNumberTextGenerator("field \"altitude\" of the OutlookGeoCoordinates class");
            fieldGeneratoraltitudeAccuracy = new JSONHoldingNumberTextGenerator("field \"altitudeAccuracy\" of the OutlookGeoCoordinates class");
            fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the OutlookGeoCoordinates class");
            fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the OutlookGeoCoordinates class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OutlookGeoCoordinates class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratoraccuracy.reset();
            fieldGeneratoraltitude.reset();
            fieldGeneratoraltitudeAccuracy.reset();
            fieldGeneratorlatitude.reset();
            fieldGeneratorlongitude.reset();
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
        protected override void handle_result(OutlookGeoCoordinatesJSON  result)
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
        public OutlookGeoCoordinatesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OutlookGeoCoordinatesJSON  result)
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
    protected virtual void handle_result(List<OutlookGeoCoordinatesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OutlookGeoCoordinatesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OutlookGeoCoordinatesJSON>();
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
    public List<OutlookGeoCoordinatesJSON> value;
  };
  };
