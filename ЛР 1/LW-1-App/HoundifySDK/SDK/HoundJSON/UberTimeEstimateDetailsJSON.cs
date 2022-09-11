/* file "UberTimeEstimateDetailsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberTimeEstimateDetailsJSON : JSONBase
  {
    private bool flagHasproduct_id;
    private string storeproduct_id;
    private bool flagHasdisplay_name;
    private string storedisplay_name;
    private bool flagHasestimate;
    private double storeestimate;
    private string textStoreestimate;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONproduct_id(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field product_id of UberTimeEstimateDetailsJSON is not a string.");
        setproduct_id(json_string.getData());
      }


    private void  fromJSONdisplay_name(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field display_name of UberTimeEstimateDetailsJSON is not a string.");
        setdisplay_name(json_string.getData());
      }


    private void  fromJSONestimate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field estimate of UberTimeEstimateDetailsJSON is not a number.");
              }
          }
        setestimateText(the_rational_text);
      }


    public UberTimeEstimateDetailsJSON()
      {
        flagHasproduct_id = false;
        flagHasdisplay_name = false;
        flagHasestimate = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasproduct_id()
      {
        return flagHasproduct_id;
      }

    public string  getproduct_id()
      {
        Debug.Assert(flagHasproduct_id);
        return storeproduct_id;
      }

    public bool  hasdisplay_name()
      {
        return flagHasdisplay_name;
      }

    public string  getdisplay_name()
      {
        Debug.Assert(flagHasdisplay_name);
        return storedisplay_name;
      }

    public bool  hasestimate()
      {
        return flagHasestimate;
      }

    public double  getestimate()
      {
        Debug.Assert(flagHasestimate);
        if (textStoreestimate != "")
          {
            return Double.Parse(textStoreestimate);
          }
        return storeestimate;
      }

    public string  getestimateAsText()
      {
        Debug.Assert(flagHasestimate);
        if (textStoreestimate == "")
          {
            return Convert.ToString(storeestimate);
          }
        else
          {
            return (textStoreestimate);
          }
      }


    public virtual int extraUberTimeEstimateDetailsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberTimeEstimateDetailsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberTimeEstimateDetailsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberTimeEstimateDetailsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setproduct_id(string new_value)
      {
        flagHasproduct_id = true;
        storeproduct_id = new_value;
      }
    public void unsetproduct_id()
      {
        flagHasproduct_id = false;
      }
    public void setdisplay_name(string new_value)
      {
        flagHasdisplay_name = true;
        storedisplay_name = new_value;
      }
    public void unsetdisplay_name()
      {
        flagHasdisplay_name = false;
      }
    public void setestimate(double new_value)
      {
        flagHasestimate = true;
        storeestimate = new_value;
        textStoreestimate = "";
      }
    public void setestimateText(string new_value)
      {
        flagHasestimate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field estimate of UberTimeEstimateDetailsJSON is not a valid number.");
        textStoreestimate = new_value;
      }
    public void unsetestimate()
      {
        flagHasestimate = false;
      }

    public virtual void extraUberTimeEstimateDetailsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberTimeEstimateDetailsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberTimeEstimateDetailsLookup(key);
        if (old_field == null)
          {
            extraUberTimeEstimateDetailsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasproduct_id);
        if (flagHasproduct_id)
          {
            handler.start_pair("product_id");
            handler.string_value(storeproduct_id);
          }
        Debug.Assert(partial_allowed || flagHasdisplay_name);
        if (flagHasdisplay_name)
          {
            handler.start_pair("display_name");
            handler.string_value(storedisplay_name);
          }
        Debug.Assert(partial_allowed || flagHasestimate);
        if (flagHasestimate)
          {
            handler.start_pair("estimate");
            if (textStoreestimate != "")
                handler.number_value(textStoreestimate);
            else if (((double)(long)storeestimate) == storeestimate)
                handler.number_value((long)storeestimate);
            else
                handler.number_value(storeestimate);
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
        if (!(hasproduct_id()))
          {
            return "When parsing the object for %what%, the \"product_id\" field was missing.";
          }
        if (!(hasdisplay_name()))
          {
            return "When parsing the object for %what%, the \"display_name\" field was missing.";
          }
        if (!(hasestimate()))
          {
            return "When parsing the object for %what%, the \"estimate\" field was missing.";
          }
        return null;
      }

    public static UberTimeEstimateDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberTimeEstimateDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTimeEstimateDetails", ignore_extras);
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
    public static UberTimeEstimateDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberTimeEstimateDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberTimeEstimateDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTimeEstimateDetails", ignore_extras);
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
    public static UberTimeEstimateDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberTimeEstimateDetailsJSON from_text(string text, bool ignore_extras)
      {
        UberTimeEstimateDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTimeEstimateDetails", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberTimeEstimateDetailsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberTimeEstimateDetailsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberTimeEstimateDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberTimeEstimateDetails", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorproduct_id;
        private JSONHoldingStringGenerator fieldGeneratordisplay_name;
        private JSONHoldingNumberTextGenerator fieldGeneratorestimate;
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
            UberTimeEstimateDetailsJSON result = new UberTimeEstimateDetailsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberTimeEstimateDetailsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberTimeEstimateDetailsJSON result)
          {
            if (fieldGeneratorproduct_id.have_value)
              {
                result.setproduct_id(fieldGeneratorproduct_id.value);
                fieldGeneratorproduct_id.have_value = false;
              }
            else if ((!(result.hasproduct_id())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"product_id\" field was missing.");
              }
            if (fieldGeneratordisplay_name.have_value)
              {
                result.setdisplay_name(fieldGeneratordisplay_name.value);
                fieldGeneratordisplay_name.have_value = false;
              }
            else if ((!(result.hasdisplay_name())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"display_name\" field was missing.");
              }
            if (fieldGeneratorestimate.have_value)
              {
                result.setestimateText(fieldGeneratorestimate.value);
                fieldGeneratorestimate.have_value = false;
              }
            else if ((!(result.hasestimate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"estimate\" field was missing.");
              }
          }
        protected abstract void handle_result(UberTimeEstimateDetailsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'd':
                    if ((String.Compare(field_name, 1, "isplay_name", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratordisplay_name;
                    break;
                case 'e':
                    if ((String.Compare(field_name, 1, "stimate", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorestimate;
                    break;
                case 'p':
                    if ((String.Compare(field_name, 1, "roduct_id", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorproduct_id;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorproduct_id = new JSONHoldingStringGenerator("field \"product_id\" of the UberTimeEstimateDetails class");
            fieldGeneratordisplay_name = new JSONHoldingStringGenerator("field \"display_name\" of the UberTimeEstimateDetails class");
            fieldGeneratorestimate = new JSONHoldingNumberTextGenerator("field \"estimate\" of the UberTimeEstimateDetails class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberTimeEstimateDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorproduct_id = new JSONHoldingStringGenerator("field \"product_id\" of the UberTimeEstimateDetails class");
            fieldGeneratordisplay_name = new JSONHoldingStringGenerator("field \"display_name\" of the UberTimeEstimateDetails class");
            fieldGeneratorestimate = new JSONHoldingNumberTextGenerator("field \"estimate\" of the UberTimeEstimateDetails class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberTimeEstimateDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorproduct_id.reset();
            fieldGeneratordisplay_name.reset();
            fieldGeneratorestimate.reset();
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
        protected override void handle_result(UberTimeEstimateDetailsJSON  result)
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
        public UberTimeEstimateDetailsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberTimeEstimateDetailsJSON  result)
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
    protected virtual void handle_result(List<UberTimeEstimateDetailsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberTimeEstimateDetailsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberTimeEstimateDetailsJSON>();
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
    public List<UberTimeEstimateDetailsJSON> value;
  };
  };
