/* file "OutlookTimeConstraintJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class OutlookTimeConstraintJSON : JSONBase
  {
    private bool flagHasactivityDomain;
    private string storeactivityDomain;
    private bool flagHastimeslots;
    private List< OutlookTimeSlotJSON  > storetimeslots;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONactivityDomain(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field activityDomain of OutlookTimeConstraintJSON is not a string.");
        setactivityDomain(json_string.getData());
      }


    private void  fromJSONtimeslots(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field timeslots of OutlookTimeConstraintJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< OutlookTimeSlotJSON  > vector_timeslots1 = new List< OutlookTimeSlotJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            OutlookTimeSlotJSON convert_classy = OutlookTimeSlotJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_timeslots1.Add(convert_classy);
          }
        inittimeslots();
        for (int num1 = 0; num1 < vector_timeslots1.Count; ++num1)
            appendtimeslots(vector_timeslots1[num1]);
        for (int num1 = 0; num1 < vector_timeslots1.Count; ++num1)
          {
          }
      }


    public OutlookTimeConstraintJSON()
      {
        flagHasactivityDomain = false;
        flagHastimeslots = false;
        storetimeslots = new List< OutlookTimeSlotJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasactivityDomain()
      {
        return flagHasactivityDomain;
      }

    public string  getactivityDomain()
      {
        Debug.Assert(flagHasactivityDomain);
        return storeactivityDomain;
      }

    public bool  hastimeslots()
      {
        return flagHastimeslots;
      }

    public int  countOftimeslots()
      {
        Debug.Assert(flagHastimeslots);
        return storetimeslots.Count;
      }

    public OutlookTimeSlotJSON   elementOftimeslots(int element_num)
      {
        Debug.Assert(flagHastimeslots);
        return storetimeslots[element_num];
      }

    public List< OutlookTimeSlotJSON  >  gettimeslots()
      {
        Debug.Assert(flagHastimeslots);
        return storetimeslots;
      }


    public virtual int extraOutlookTimeConstraintComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOutlookTimeConstraintComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOutlookTimeConstraintComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOutlookTimeConstraintLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setactivityDomain(string new_value)
      {
        flagHasactivityDomain = true;
        storeactivityDomain = new_value;
      }
    public void unsetactivityDomain()
      {
        flagHasactivityDomain = false;
      }
    public void inittimeslots()
      {
        if (flagHastimeslots)
          {
            for (int num1 = 0; num1 < storetimeslots.Count; ++num1)
              {
              }
          }
        flagHastimeslots = true;
        storetimeslots.Clear();
      }
    public void appendtimeslots(OutlookTimeSlotJSON  to_append)
      {
        if (!flagHastimeslots)
          {
            flagHastimeslots = true;
            storetimeslots.Clear();
          }
        Debug.Assert(flagHastimeslots);
        storetimeslots.Add(to_append);
      }
    public void unsettimeslots()
      {
        if (flagHastimeslots)
          {
            for (int num2 = 0; num2 < storetimeslots.Count; ++num2)
              {
              }
          }
        flagHastimeslots = false;
        storetimeslots.Clear();
      }

    public virtual void extraOutlookTimeConstraintAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOutlookTimeConstraintSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOutlookTimeConstraintLookup(key);
        if (old_field == null)
          {
            extraOutlookTimeConstraintAppendPair(key, new_component);
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
        if (flagHasactivityDomain)
          {
            handler.start_pair("activityDomain");
            handler.string_value(storeactivityDomain);
          }
        if (flagHastimeslots)
          {
            handler.start_pair("timeslots");
            handler.start_array();
            for (int num1 = 0; num1 < storetimeslots.Count; ++num1)
              {
                if (partial_allowed)
                    storetimeslots[num1].write_partial_as_json(handler);
                else
                    storetimeslots[num1].write_as_json(handler);
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
        return null;
      }

    public static OutlookTimeConstraintJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookTimeConstraintJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookTimeConstraint", ignore_extras);
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
    public static OutlookTimeConstraintJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookTimeConstraintJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookTimeConstraintJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookTimeConstraint", ignore_extras);
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
    public static OutlookTimeConstraintJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookTimeConstraintJSON from_text(string text, bool ignore_extras)
      {
        OutlookTimeConstraintJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookTimeConstraint", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OutlookTimeConstraintJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OutlookTimeConstraintJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OutlookTimeConstraintJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookTimeConstraint", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratoractivityDomain;
        private OutlookTimeSlotJSON.HoldingArrayGenerator fieldGeneratortimeslots;
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
            OutlookTimeConstraintJSON result = new OutlookTimeConstraintJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOutlookTimeConstraintAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OutlookTimeConstraintJSON result)
          {
            if (fieldGeneratoractivityDomain.have_value)
              {
                result.setactivityDomain(fieldGeneratoractivityDomain.value);
                fieldGeneratoractivityDomain.have_value = false;
              }
            if (fieldGeneratortimeslots.have_value)
              {
                result.inittimeslots();
                int count = fieldGeneratortimeslots.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendtimeslots(fieldGeneratortimeslots.value[num]);
                  }
                fieldGeneratortimeslots.value.Clear();
                fieldGeneratortimeslots.have_value = false;
              }
          }
        protected abstract void handle_result(OutlookTimeConstraintJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    if ((String.Compare(field_name, 1, "ctivityDomain", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratoractivityDomain;
                    break;
                case 't':
                    if ((String.Compare(field_name, 1, "imeslots", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratortimeslots;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratoractivityDomain = new JSONHoldingStringGenerator("field \"activityDomain\" of the OutlookTimeConstraint class");
            fieldGeneratortimeslots = new OutlookTimeSlotJSON.HoldingArrayGenerator("field \"timeslots\" of the OutlookTimeConstraint class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OutlookTimeConstraint class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratoractivityDomain = new JSONHoldingStringGenerator("field \"activityDomain\" of the OutlookTimeConstraint class");
            fieldGeneratortimeslots = new OutlookTimeSlotJSON.HoldingArrayGenerator("field \"timeslots\" of the OutlookTimeConstraint class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OutlookTimeConstraint class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratoractivityDomain.reset();
            fieldGeneratortimeslots.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratortimeslots.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratortimeslots.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(OutlookTimeConstraintJSON  result)
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
        public OutlookTimeConstraintJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OutlookTimeConstraintJSON  result)
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
    protected virtual void handle_result(List<OutlookTimeConstraintJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OutlookTimeConstraintJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OutlookTimeConstraintJSON>();
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
    public List<OutlookTimeConstraintJSON> value;
  };
  };
