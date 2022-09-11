/* file "VolumeControlIntraQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class VolumeControlIntraQueryStateJSON : JSONBase
  {
    private bool flagHasVolumeCommandType;
    private VolumeControlCommandTypeJSON  storeVolumeCommandType;
    private bool flagHasVolumeDelta;
    private double storeVolumeDelta;
    private string textStoreVolumeDelta;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONVolumeCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        VolumeControlCommandTypeJSON convert_classy = VolumeControlCommandTypeJSON.from_json(json_value, ignore_extras, true);
        setVolumeCommandType(convert_classy);
      }


    private void  fromJSONVolumeDelta(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field VolumeDelta of VolumeControlIntraQueryStateJSON is not a number.");
              }
          }
        setVolumeDeltaText(the_rational_text);
      }


    public VolumeControlIntraQueryStateJSON()
      {
        flagHasVolumeCommandType = false;
        flagHasVolumeDelta = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasVolumeCommandType()
      {
        return flagHasVolumeCommandType;
      }

    public VolumeControlCommandTypeJSON   getVolumeCommandType()
      {
        Debug.Assert(flagHasVolumeCommandType);
        return storeVolumeCommandType;
      }

    public VolumeControlCommandTypeJSON.TypeValue  getVolumeCommandTypeValue()
      {
        return getVolumeCommandType().getValue();
      }

    public string  getVolumeCommandTypeAsString()
      {
        return getVolumeCommandType().getValueAsString();
      }

    public bool  hasVolumeDelta()
      {
        return flagHasVolumeDelta;
      }

    public double  getVolumeDelta()
      {
        Debug.Assert(flagHasVolumeDelta);
        if (textStoreVolumeDelta != "")
          {
            return Double.Parse(textStoreVolumeDelta);
          }
        return storeVolumeDelta;
      }

    public string  getVolumeDeltaAsText()
      {
        Debug.Assert(flagHasVolumeDelta);
        if (textStoreVolumeDelta == "")
          {
            return Convert.ToString(storeVolumeDelta);
          }
        else
          {
            return (textStoreVolumeDelta);
          }
      }


    public virtual int extraVolumeControlIntraQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraVolumeControlIntraQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraVolumeControlIntraQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraVolumeControlIntraQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setVolumeCommandType(VolumeControlCommandTypeJSON  new_value)
      {
        if (flagHasVolumeCommandType)
          {
          }
        flagHasVolumeCommandType = true;
        storeVolumeCommandType = new_value;
      }
    public void setVolumeCommandType(VolumeControlCommandTypeJSON.TypeValue new_value)
      {
        setVolumeCommandType(new VolumeControlCommandTypeJSON(new_value));
      }
    public void setVolumeCommandType(string chars)
      {
        setVolumeCommandType(new VolumeControlCommandTypeJSON(chars));
      }
    public void unsetVolumeCommandType()
      {
        if (flagHasVolumeCommandType)
          {
          }
        flagHasVolumeCommandType = false;
      }
    public void setVolumeDelta(double new_value)
      {
        flagHasVolumeDelta = true;
        if (new_value < -1)
            throw new Exception("The value for field VolumeDelta of VolumeControlIntraQueryStateJSON is less than the lower bound (-1) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field VolumeDelta of VolumeControlIntraQueryStateJSON is greater than the upper bound (1) for that field.");
        storeVolumeDelta = new_value;
        textStoreVolumeDelta = "";
      }
    public void setVolumeDeltaText(string new_value)
      {
        flagHasVolumeDelta = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field VolumeDelta of VolumeControlIntraQueryStateJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "1", "", false, "1") < 0)
            throw new Exception("The value for field VolumeDelta of VolumeControlIntraQueryStateJSON is less than the lower bound (-1) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field VolumeDelta of VolumeControlIntraQueryStateJSON is greater than the upper bound (1) for that field.");
        textStoreVolumeDelta = new_value;
      }
    public void unsetVolumeDelta()
      {
        flagHasVolumeDelta = false;
      }

    public virtual void extraVolumeControlIntraQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraVolumeControlIntraQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraVolumeControlIntraQueryStateLookup(key);
        if (old_field == null)
          {
            extraVolumeControlIntraQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasVolumeCommandType);
        if (flagHasVolumeCommandType)
          {
            handler.start_pair("VolumeCommandType");
            if (partial_allowed)
                storeVolumeCommandType.write_partial_as_json(handler);
            else
                storeVolumeCommandType.write_as_json(handler);
          }
        if (flagHasVolumeDelta)
          {
            handler.start_pair("VolumeDelta");
            if (textStoreVolumeDelta != "")
                handler.number_value(textStoreVolumeDelta);
            else if (((double)(long)storeVolumeDelta) == storeVolumeDelta)
                handler.number_value((long)storeVolumeDelta);
            else
                handler.number_value(storeVolumeDelta);
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
        if (!(hasVolumeCommandType()))
          {
            return "When parsing the object for %what%, the \"VolumeCommandType\" field was missing.";
          }
        return null;
      }

    public static VolumeControlIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        VolumeControlIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VolumeControlIntraQueryState", ignore_extras);
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
    public static VolumeControlIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static VolumeControlIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        VolumeControlIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VolumeControlIntraQueryState", ignore_extras);
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
    public static VolumeControlIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static VolumeControlIntraQueryStateJSON from_text(string text, bool ignore_extras)
      {
        VolumeControlIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VolumeControlIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for VolumeControlIntraQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static VolumeControlIntraQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        VolumeControlIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type VolumeControlIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private VolumeControlCommandTypeJSON.HoldingGenerator fieldGeneratorVolumeCommandType;
        private JSONHoldingNumberTextGenerator fieldGeneratorVolumeDelta;
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
            VolumeControlIntraQueryStateJSON result = new VolumeControlIntraQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraVolumeControlIntraQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(VolumeControlIntraQueryStateJSON result)
          {
            if (fieldGeneratorVolumeCommandType.have_value)
              {
                result.setVolumeCommandType(fieldGeneratorVolumeCommandType.value);
                fieldGeneratorVolumeCommandType.have_value = false;
              }
            else if ((!(result.hasVolumeCommandType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"VolumeCommandType\" field was missing.");
              }
            if (fieldGeneratorVolumeDelta.have_value)
              {
                result.setVolumeDeltaText(fieldGeneratorVolumeDelta.value);
                fieldGeneratorVolumeDelta.have_value = false;
              }
          }
        protected abstract void handle_result(VolumeControlIntraQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Volume", 0, 6, false) == 0)
              {
                switch (field_name[6])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 7, "ommandType", 0, 10, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorVolumeCommandType;
                        break;
                    case 'D':
                        if ((String.Compare(field_name, 7, "elta", 0, 4, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorVolumeDelta;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorVolumeCommandType = new VolumeControlCommandTypeJSON.HoldingGenerator("field \"VolumeCommandType\" of the VolumeControlIntraQueryState class", ignore_extras);
            fieldGeneratorVolumeDelta = new JSONHoldingNumberTextGenerator("field \"VolumeDelta\" of the VolumeControlIntraQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the VolumeControlIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorVolumeCommandType = new VolumeControlCommandTypeJSON.HoldingGenerator("field \"VolumeCommandType\" of the VolumeControlIntraQueryState class", false);
            fieldGeneratorVolumeDelta = new JSONHoldingNumberTextGenerator("field \"VolumeDelta\" of the VolumeControlIntraQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the VolumeControlIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorVolumeCommandType.reset();
            fieldGeneratorVolumeDelta.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorVolumeCommandType.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorVolumeCommandType.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(VolumeControlIntraQueryStateJSON  result)
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
        public VolumeControlIntraQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(VolumeControlIntraQueryStateJSON  result)
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
    protected virtual void handle_result(List<VolumeControlIntraQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<VolumeControlIntraQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<VolumeControlIntraQueryStateJSON>();
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
    public List<VolumeControlIntraQueryStateJSON> value;
  };
  };
