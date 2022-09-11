/* file "SportsStandingsArgumentLeagueDivisionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStandingsArgumentLeagueDivisionJSON : SportsStandingsArgumentJSON
  {
    private bool flagHasLeagueDivisions;
    private List< SportsLeagueDivisionJSON  > storeLeagueDivisions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraLeagueDivisionsToJSON()
      {
        JSONArrayValue generated_array_1_LeagueDivisions = new JSONArrayValue();
        for (int num1 = 0; num1 < storeLeagueDivisions.Count; ++num1)
          {
            JSONValueHandler handler_LeagueDivisions = new JSONValueHandler();
            storeLeagueDivisions[num1].write_as_json(handler_LeagueDivisions);
            generated_array_1_LeagueDivisions.appendComponent(handler_LeagueDivisions.result);
          }
        return generated_array_1_LeagueDivisions;
      }


    private void  fromJSONLeagueDivisions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field LeagueDivisions of SportsStandingsArgumentLeagueDivisionJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field LeagueDivisions of SportsStandingsArgumentLeagueDivisionJSON has too few elements.");
        List< SportsLeagueDivisionJSON  > vector_LeagueDivisions1 = new List< SportsLeagueDivisionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsLeagueDivisionJSON convert_classy = SportsLeagueDivisionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_LeagueDivisions1.Add(convert_classy);
          }
        Debug.Assert(vector_LeagueDivisions1.Count >= 1);
        initLeagueDivisions();
        for (int num1 = 0; num1 < vector_LeagueDivisions1.Count; ++num1)
            appendLeagueDivisions(vector_LeagueDivisions1[num1]);
        for (int num1 = 0; num1 < vector_LeagueDivisions1.Count; ++num1)
          {
          }
      }


    public SportsStandingsArgumentLeagueDivisionJSON()
      {
        flagHasLeagueDivisions = false;
        storeLeagueDivisions = new List< SportsLeagueDivisionJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsStandingsArgumentKind()
      {
        return "LeagueDivision";
      }

    public bool  hasLeagueDivisions()
      {
        return flagHasLeagueDivisions;
      }

    public int  countOfLeagueDivisions()
      {
        Debug.Assert(flagHasLeagueDivisions);
        return storeLeagueDivisions.Count;
      }

    public SportsLeagueDivisionJSON   elementOfLeagueDivisions(int element_num)
      {
        Debug.Assert(flagHasLeagueDivisions);
        return storeLeagueDivisions[element_num];
      }

    public List< SportsLeagueDivisionJSON  >  getLeagueDivisions()
      {
        Debug.Assert(flagHasLeagueDivisions);
        return storeLeagueDivisions;
      }


    public virtual int extraSportsStandingsArgumentLeagueDivisionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsArgumentLeagueDivisionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentLeagueDivisionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentLeagueDivisionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsStandingsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasLeagueDivisions)
            ++result;
        result += extraSportsStandingsArgumentLeagueDivisionComponentCount();
        return result;
      }
    public override string extraSportsStandingsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasLeagueDivisions)
          {
            if (remainder == 0)
                return "LeagueDivisions";
            --remainder;
          }
        return extraSportsStandingsArgumentLeagueDivisionComponentKey(remainder);
      }
    public override JSONValue extraSportsStandingsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasLeagueDivisions)
          {
            if (remainder == 0)
                return extraLeagueDivisionsToJSON();
            --remainder;
          }
        return extraSportsStandingsArgumentLeagueDivisionComponentValue(remainder);
      }
    public override JSONValue extraSportsStandingsArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "LeagueDivisions", 0, 15, false) == 0) && (field_name.Length == 15))
            return (flagHasLeagueDivisions ? extraLeagueDivisionsToJSON() : null);
        return extraSportsStandingsArgumentLeagueDivisionLookup(field_name);
      }

    public void initLeagueDivisions()
      {
        if (flagHasLeagueDivisions)
          {
            for (int num1 = 0; num1 < storeLeagueDivisions.Count; ++num1)
              {
              }
          }
        flagHasLeagueDivisions = true;
        storeLeagueDivisions.Clear();
      }
    public void appendLeagueDivisions(SportsLeagueDivisionJSON  to_append)
      {
        if (!flagHasLeagueDivisions)
          {
            flagHasLeagueDivisions = true;
            storeLeagueDivisions.Clear();
          }
        Debug.Assert(flagHasLeagueDivisions);
        storeLeagueDivisions.Add(to_append);
      }
    public void appendLeagueDivisions(SportsLeagueDivisionJSON.TypeValue new_value)
      {
        appendLeagueDivisions(new SportsLeagueDivisionJSON(new_value));
      }
    public void appendLeagueDivisions(string chars)
      {
        SportsLeagueDivisionJSON.TypeValueKnownValues known = SportsLeagueDivisionJSON.stringToValue(chars);
        SportsLeagueDivisionJSON.TypeValue new_value = new SportsLeagueDivisionJSON.TypeValue();
        if (known == SportsLeagueDivisionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendLeagueDivisions(new_value);
      }
    public void unsetLeagueDivisions()
      {
        if (flagHasLeagueDivisions)
          {
            for (int num2 = 0; num2 < storeLeagueDivisions.Count; ++num2)
              {
              }
          }
        flagHasLeagueDivisions = false;
        storeLeagueDivisions.Clear();
      }

    public virtual void extraSportsStandingsArgumentLeagueDivisionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsArgumentLeagueDivisionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsArgumentLeagueDivisionLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsArgumentLeagueDivisionAppendPair(key, new_component);
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
    public override void extraSportsStandingsArgumentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "LeagueDivisions", 0, 15, false) == 0) && (key.Length == 15))
            {
            fromJSONLeagueDivisions(new_component, false);
            return;
            }
        extraSportsStandingsArgumentLeagueDivisionAppendPair(key, new_component);
      }
    public override void extraSportsStandingsArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "LeagueDivisions", 0, 15, false) == 0) && (key.Length == 15))
            {
            fromJSONLeagueDivisions(new_component, false);
            return;
            }
        extraSportsStandingsArgumentLeagueDivisionSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasLeagueDivisions);
        if (flagHasLeagueDivisions)
          {
            handler.start_pair("LeagueDivisions");
            Debug.Assert(storeLeagueDivisions.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeLeagueDivisions.Count; ++num1)
              {
                if (partial_allowed)
                    storeLeagueDivisions[num1].write_partial_as_json(handler);
                else
                    storeLeagueDivisions[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasLeagueDivisions()))
          {
            return "When parsing the object for %what%, the \"LeagueDivisions\" field was missing.";
          }
        return null;
      }

    public static new SportsStandingsArgumentLeagueDivisionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentLeagueDivisionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentLeagueDivision", ignore_extras);
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
    public static new SportsStandingsArgumentLeagueDivisionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStandingsArgumentLeagueDivisionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentLeagueDivisionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentLeagueDivision", ignore_extras);
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
    public static new SportsStandingsArgumentLeagueDivisionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStandingsArgumentLeagueDivisionJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsArgumentLeagueDivisionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentLeagueDivision", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsArgumentLeagueDivisionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsStandingsArgumentLeagueDivisionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsArgumentLeagueDivisionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentLeagueDivision", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsStandingsArgumentJSON.Generator
      {
        private SportsLeagueDivisionJSON.HoldingArrayGenerator fieldGeneratorLeagueDivisions;
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
            if (!(getSportsStandingsArgumentJSONKey().Equals("LeagueDivision")))
                throw new Exception("The key field has a value other than `LeagueDivision'.");
            SportsStandingsArgumentLeagueDivisionJSON result = new SportsStandingsArgumentLeagueDivisionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsArgumentLeagueDivisionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsStandingsArgumentJSON new_result)
          {
            handle_result((SportsStandingsArgumentLeagueDivisionJSON )new_result);
          }
        protected void finish(SportsStandingsArgumentLeagueDivisionJSON result)
          {
            if (fieldGeneratorLeagueDivisions.have_value)
              {
                result.initLeagueDivisions();
                int count = fieldGeneratorLeagueDivisions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLeagueDivisions(fieldGeneratorLeagueDivisions.value[num]);
                  }
                fieldGeneratorLeagueDivisions.value.Clear();
                fieldGeneratorLeagueDivisions.have_value = false;
              }
            else if ((!(result.hasLeagueDivisions())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LeagueDivisions\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsStandingsArgumentLeagueDivisionJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "LeagueDivisions", 0, 15, false) == 0) && (field_name.Length == 15))
                return fieldGeneratorLeagueDivisions;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorLeagueDivisions = new SportsLeagueDivisionJSON.HoldingArrayGenerator("field \"LeagueDivisions\" of the SportsStandingsArgumentLeagueDivision class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandingsArgumentLeagueDivision class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorLeagueDivisions = new SportsLeagueDivisionJSON.HoldingArrayGenerator("field \"LeagueDivisions\" of the SportsStandingsArgumentLeagueDivision class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandingsArgumentLeagueDivision class");
          }

        public override void reset()
          {
            fieldGeneratorLeagueDivisions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStandingsArgumentLeagueDivisionJSON  result)
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
        public SportsStandingsArgumentLeagueDivisionJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsArgumentLeagueDivisionJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsArgumentLeagueDivisionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsArgumentLeagueDivisionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsArgumentLeagueDivisionJSON>();
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
    public List<SportsStandingsArgumentLeagueDivisionJSON> value;
  };
  };
