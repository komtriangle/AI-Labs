/* file "TerrestrialTuningTargetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrestrialTuningTargetJSON : JSONBase
  {
    public enum TypeBandKnownValues
      {
        Band_AM,
        Band_FM,
        Band__none
      };
    public struct TypeBand
      {
        public bool in_known_list;
        public string string_value;
        public TypeBandKnownValues list_value;
      };

    public static TypeBandKnownValues  stringToBand(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "M", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeBandKnownValues.Band_AM;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "M", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeBandKnownValues.Band_FM;
                break;
            default:
                break;
          }
        return TypeBandKnownValues.Band__none;
      }

    public static string  stringFromBand(TypeBandKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeBandKnownValues.Band_AM:
                return "AM";
            case TypeBandKnownValues.Band_FM:
                return "FM";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasBand;
    private TypeBand storeBand;
    private bool flagHasFrequency;
    private double storeFrequency;
    private string textStoreFrequency;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONBand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Band of TerrestrialTuningTargetJSON is not a string.");
        TypeBand the_open_enum = new TypeBand();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "M", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBandKnownValues.Band_AM;
                        goto open_enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "M", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBandKnownValues.Band_FM;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setBand(the_open_enum);
      }


    private void  fromJSONFrequency(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Frequency of TerrestrialTuningTargetJSON is not a number.");
              }
          }
        setFrequencyText(the_rational_text);
      }


    public TerrestrialTuningTargetJSON()
      {
        flagHasBand = false;
        flagHasFrequency = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasBand()
      {
        return flagHasBand;
      }

    public TypeBand  getBand()
      {
        Debug.Assert(flagHasBand);
        return storeBand;
      }

    public string  getBandAsString()
      {
        TypeBand result = getBand();
        if (result.in_known_list)
            return stringFromBand(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasFrequency()
      {
        return flagHasFrequency;
      }

    public double  getFrequency()
      {
        Debug.Assert(flagHasFrequency);
        if (textStoreFrequency != "")
          {
            return Double.Parse(textStoreFrequency);
          }
        return storeFrequency;
      }

    public string  getFrequencyAsText()
      {
        Debug.Assert(flagHasFrequency);
        if (textStoreFrequency == "")
          {
            return Convert.ToString(storeFrequency);
          }
        else
          {
            return (textStoreFrequency);
          }
      }


    public virtual int extraTerrestrialTuningTargetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrestrialTuningTargetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrestrialTuningTargetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrestrialTuningTargetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setBand(TypeBand new_value)
      {
        flagHasBand = true;
        storeBand = new_value;
      }
    public void setBand(string chars)
      {
        TypeBandKnownValues known = stringToBand(chars);
        TypeBand new_value = new TypeBand();
        if (known == TypeBandKnownValues.Band__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setBand(new_value);
      }
    public void setBand(TypeBandKnownValues new_value)
      {
        TypeBand new_full_value = new TypeBand();
        Debug.Assert(new_value != TypeBandKnownValues.Band__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setBand(new_full_value);
      }
    public void unsetBand()
      {
        flagHasBand = false;
      }
    public void setFrequency(double new_value)
      {
        flagHasFrequency = true;
        storeFrequency = new_value;
        textStoreFrequency = "";
      }
    public void setFrequencyText(string new_value)
      {
        flagHasFrequency = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Frequency of TerrestrialTuningTargetJSON is not a valid number.");
        textStoreFrequency = new_value;
      }
    public void unsetFrequency()
      {
        flagHasFrequency = false;
      }

    public virtual void extraTerrestrialTuningTargetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrestrialTuningTargetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrestrialTuningTargetLookup(key);
        if (old_field == null)
          {
            extraTerrestrialTuningTargetAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasBand);
        if (flagHasBand)
          {
            handler.start_pair("Band");
            if (storeBand.in_known_list)
              {
                switch (storeBand.list_value)
                  {
                    case TypeBandKnownValues.Band_AM:
                        handler.string_value("AM");
                        break;
                    case TypeBandKnownValues.Band_FM:
                        handler.string_value("FM");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeBand.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasFrequency);
        if (flagHasFrequency)
          {
            handler.start_pair("Frequency");
            if (textStoreFrequency != "")
                handler.number_value(textStoreFrequency);
            else if (((double)(long)storeFrequency) == storeFrequency)
                handler.number_value((long)storeFrequency);
            else
                handler.number_value(storeFrequency);
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
        if (!(hasBand()))
          {
            return "When parsing the object for %what%, the \"Band\" field was missing.";
          }
        if (!(hasFrequency()))
          {
            return "When parsing the object for %what%, the \"Frequency\" field was missing.";
          }
        return null;
      }

    public static TerrestrialTuningTargetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrestrialTuningTargetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrestrialTuningTarget", ignore_extras);
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
    public static TerrestrialTuningTargetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrestrialTuningTargetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrestrialTuningTargetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrestrialTuningTarget", ignore_extras);
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
    public static TerrestrialTuningTargetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrestrialTuningTargetJSON from_text(string text, bool ignore_extras)
      {
        TerrestrialTuningTargetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrestrialTuningTarget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrestrialTuningTargetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrestrialTuningTargetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrestrialTuningTargetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrestrialTuningTarget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorBand : JSONStringGenerator
          {
            protected FieldGeneratorBand(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorBand()
              {
              }
            protected override void handle_result(string result)
              {
                TypeBandKnownValues known = stringToBand(result);
                TypeBand new_value = new TypeBand();
                if (known == TypeBandKnownValues.Band__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeBand result);
          };
    private class FieldHoldingGeneratorBand : FieldGeneratorBand
  {
    protected override void handle_result(TypeBand result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorBand(String what)
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
    public TypeBand value;
  };
    private class FieldHoldingArrayGeneratorBand : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorBand
      {
        private FieldHoldingArrayGeneratorBand top;

        protected override void handle_result(TypeBand result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorBand init_top)
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
    protected virtual void handle_result(List<TypeBand> result)
      {
      }

    public FieldHoldingArrayGeneratorBand(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBand>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorBand()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBand>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeBand> value;
  };
        private FieldHoldingGeneratorBand fieldGeneratorBand;
        private JSONHoldingNumberTextGenerator fieldGeneratorFrequency;
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
            TerrestrialTuningTargetJSON result = new TerrestrialTuningTargetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrestrialTuningTargetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrestrialTuningTargetJSON result)
          {
            if (fieldGeneratorBand.have_value)
              {
                result.setBand(fieldGeneratorBand.value);
                fieldGeneratorBand.have_value = false;
              }
            else if ((!(result.hasBand())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Band\" field was missing.");
              }
            if (fieldGeneratorFrequency.have_value)
              {
                result.setFrequencyText(fieldGeneratorFrequency.value);
                fieldGeneratorFrequency.have_value = false;
              }
            else if ((!(result.hasFrequency())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Frequency\" field was missing.");
              }
          }
        protected abstract void handle_result(TerrestrialTuningTargetJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "and", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorBand;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "requency", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorFrequency;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorBand = new FieldHoldingGeneratorBand("field \"Band\" of the TerrestrialTuningTarget class");
            fieldGeneratorFrequency = new JSONHoldingNumberTextGenerator("field \"Frequency\" of the TerrestrialTuningTarget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrestrialTuningTarget class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorBand = new FieldHoldingGeneratorBand("field \"Band\" of the TerrestrialTuningTarget class");
            fieldGeneratorFrequency = new JSONHoldingNumberTextGenerator("field \"Frequency\" of the TerrestrialTuningTarget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrestrialTuningTarget class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorBand.reset();
            fieldGeneratorFrequency.reset();
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
        protected override void handle_result(TerrestrialTuningTargetJSON  result)
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
        public TerrestrialTuningTargetJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrestrialTuningTargetJSON  result)
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
    protected virtual void handle_result(List<TerrestrialTuningTargetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrestrialTuningTargetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrestrialTuningTargetJSON>();
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
    public List<TerrestrialTuningTargetJSON> value;
  };
  };
