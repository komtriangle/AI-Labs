/* file "MapControlIntraQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MapControlIntraQueryStateJSON : JSONBase
  {
    private bool flagHasMapControlCommandType;
    private MapControlCommandCommandTypeJSON  storeMapControlCommandType;
    private bool flagHasDirection;
    private double storeDirection;
    private string textStoreDirection;
    private bool flagHasZoomAmount;
    private double storeZoomAmount;
    private string textStoreZoomAmount;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONMapControlCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapControlCommandCommandTypeJSON convert_classy = MapControlCommandCommandTypeJSON.from_json(json_value, ignore_extras, true);
        setMapControlCommandType(convert_classy);
      }


    private void  fromJSONDirection(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Direction of MapControlIntraQueryStateJSON is not a number.");
              }
          }
        setDirectionText(the_rational_text);
      }


    private void  fromJSONZoomAmount(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ZoomAmount of MapControlIntraQueryStateJSON is not a number.");
              }
          }
        setZoomAmountText(the_rational_text);
      }


    public MapControlIntraQueryStateJSON()
      {
        flagHasMapControlCommandType = false;
        flagHasDirection = false;
        flagHasZoomAmount = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasMapControlCommandType()
      {
        return flagHasMapControlCommandType;
      }

    public MapControlCommandCommandTypeJSON   getMapControlCommandType()
      {
        Debug.Assert(flagHasMapControlCommandType);
        return storeMapControlCommandType;
      }

    public MapControlCommandCommandTypeJSON.TypeValue  getMapControlCommandTypeValue()
      {
        return getMapControlCommandType().getValue();
      }

    public string  getMapControlCommandTypeAsString()
      {
        return getMapControlCommandType().getValueAsString();
      }

    public bool  hasDirection()
      {
        return flagHasDirection;
      }

    public double  getDirection()
      {
        Debug.Assert(flagHasDirection);
        if (textStoreDirection != "")
          {
            return Double.Parse(textStoreDirection);
          }
        return storeDirection;
      }

    public string  getDirectionAsText()
      {
        Debug.Assert(flagHasDirection);
        if (textStoreDirection == "")
          {
            return Convert.ToString(storeDirection);
          }
        else
          {
            return (textStoreDirection);
          }
      }

    public bool  hasZoomAmount()
      {
        return flagHasZoomAmount;
      }

    public double  getZoomAmount()
      {
        Debug.Assert(flagHasZoomAmount);
        if (textStoreZoomAmount != "")
          {
            return Double.Parse(textStoreZoomAmount);
          }
        return storeZoomAmount;
      }

    public string  getZoomAmountAsText()
      {
        Debug.Assert(flagHasZoomAmount);
        if (textStoreZoomAmount == "")
          {
            return Convert.ToString(storeZoomAmount);
          }
        else
          {
            return (textStoreZoomAmount);
          }
      }


    public virtual int extraMapControlIntraQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMapControlIntraQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMapControlIntraQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMapControlIntraQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setMapControlCommandType(MapControlCommandCommandTypeJSON  new_value)
      {
        if (flagHasMapControlCommandType)
          {
          }
        flagHasMapControlCommandType = true;
        storeMapControlCommandType = new_value;
      }
    public void setMapControlCommandType(MapControlCommandCommandTypeJSON.TypeValue new_value)
      {
        setMapControlCommandType(new MapControlCommandCommandTypeJSON(new_value));
      }
    public void setMapControlCommandType(string chars)
      {
        setMapControlCommandType(new MapControlCommandCommandTypeJSON(chars));
      }
    public void unsetMapControlCommandType()
      {
        if (flagHasMapControlCommandType)
          {
          }
        flagHasMapControlCommandType = false;
      }
    public void setDirection(double new_value)
      {
        flagHasDirection = true;
        if (new_value < 0)
            throw new Exception("The value for field Direction of MapControlIntraQueryStateJSON is less than the lower bound (0) for that field.");
        if (new_value > 360)
            throw new Exception("The value for field Direction of MapControlIntraQueryStateJSON is greater than the upper bound (360) for that field.");
        storeDirection = new_value;
        textStoreDirection = "";
      }
    public void setDirectionText(string new_value)
      {
        flagHasDirection = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Direction of MapControlIntraQueryStateJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Direction of MapControlIntraQueryStateJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "360", "", false, "3") > 0)
            throw new Exception("The value for field Direction of MapControlIntraQueryStateJSON is greater than the upper bound (360) for that field.");
        textStoreDirection = new_value;
      }
    public void unsetDirection()
      {
        flagHasDirection = false;
      }
    public void setZoomAmount(double new_value)
      {
        flagHasZoomAmount = true;
        storeZoomAmount = new_value;
        textStoreZoomAmount = "";
      }
    public void setZoomAmountText(string new_value)
      {
        flagHasZoomAmount = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field ZoomAmount of MapControlIntraQueryStateJSON is not a valid number.");
        textStoreZoomAmount = new_value;
      }
    public void unsetZoomAmount()
      {
        flagHasZoomAmount = false;
      }

    public virtual void extraMapControlIntraQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMapControlIntraQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMapControlIntraQueryStateLookup(key);
        if (old_field == null)
          {
            extraMapControlIntraQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasMapControlCommandType);
        if (flagHasMapControlCommandType)
          {
            handler.start_pair("MapControlCommandType");
            if (partial_allowed)
                storeMapControlCommandType.write_partial_as_json(handler);
            else
                storeMapControlCommandType.write_as_json(handler);
          }
        if (flagHasDirection)
          {
            handler.start_pair("Direction");
            if (textStoreDirection != "")
                handler.number_value(textStoreDirection);
            else if (((double)(long)storeDirection) == storeDirection)
                handler.number_value((long)storeDirection);
            else
                handler.number_value(storeDirection);
          }
        if (flagHasZoomAmount)
          {
            handler.start_pair("ZoomAmount");
            if (textStoreZoomAmount != "")
                handler.number_value(textStoreZoomAmount);
            else if (((double)(long)storeZoomAmount) == storeZoomAmount)
                handler.number_value((long)storeZoomAmount);
            else
                handler.number_value(storeZoomAmount);
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
        if (!(hasMapControlCommandType()))
          {
            return "When parsing the object for %what%, the \"MapControlCommandType\" field was missing.";
          }
        return null;
      }

    public static MapControlIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapControlIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlIntraQueryState", ignore_extras);
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
    public static MapControlIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MapControlIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapControlIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlIntraQueryState", ignore_extras);
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
    public static MapControlIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MapControlIntraQueryStateJSON from_text(string text, bool ignore_extras)
      {
        MapControlIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MapControlIntraQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MapControlIntraQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MapControlIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MapControlCommandCommandTypeJSON.HoldingGenerator fieldGeneratorMapControlCommandType;
        private JSONHoldingNumberTextGenerator fieldGeneratorDirection;
        private JSONHoldingNumberTextGenerator fieldGeneratorZoomAmount;
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
            MapControlIntraQueryStateJSON result = new MapControlIntraQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMapControlIntraQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MapControlIntraQueryStateJSON result)
          {
            if (fieldGeneratorMapControlCommandType.have_value)
              {
                result.setMapControlCommandType(fieldGeneratorMapControlCommandType.value);
                fieldGeneratorMapControlCommandType.have_value = false;
              }
            else if ((!(result.hasMapControlCommandType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MapControlCommandType\" field was missing.");
              }
            if (fieldGeneratorDirection.have_value)
              {
                result.setDirectionText(fieldGeneratorDirection.value);
                fieldGeneratorDirection.have_value = false;
              }
            if (fieldGeneratorZoomAmount.have_value)
              {
                result.setZoomAmountText(fieldGeneratorZoomAmount.value);
                fieldGeneratorZoomAmount.have_value = false;
              }
          }
        protected abstract void handle_result(MapControlIntraQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "irection", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDirection;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "apControlCommandType", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorMapControlCommandType;
                    break;
                case 'Z':
                    if ((String.Compare(field_name, 1, "oomAmount", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorZoomAmount;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMapControlCommandType = new MapControlCommandCommandTypeJSON.HoldingGenerator("field \"MapControlCommandType\" of the MapControlIntraQueryState class", ignore_extras);
            fieldGeneratorDirection = new JSONHoldingNumberTextGenerator("field \"Direction\" of the MapControlIntraQueryState class");
            fieldGeneratorZoomAmount = new JSONHoldingNumberTextGenerator("field \"ZoomAmount\" of the MapControlIntraQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MapControlIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMapControlCommandType = new MapControlCommandCommandTypeJSON.HoldingGenerator("field \"MapControlCommandType\" of the MapControlIntraQueryState class", false);
            fieldGeneratorDirection = new JSONHoldingNumberTextGenerator("field \"Direction\" of the MapControlIntraQueryState class");
            fieldGeneratorZoomAmount = new JSONHoldingNumberTextGenerator("field \"ZoomAmount\" of the MapControlIntraQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MapControlIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMapControlCommandType.reset();
            fieldGeneratorDirection.reset();
            fieldGeneratorZoomAmount.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMapControlCommandType.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMapControlCommandType.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MapControlIntraQueryStateJSON  result)
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
        public MapControlIntraQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MapControlIntraQueryStateJSON  result)
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
    protected virtual void handle_result(List<MapControlIntraQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MapControlIntraQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MapControlIntraQueryStateJSON>();
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
    public List<MapControlIntraQueryStateJSON> value;
  };
  };
