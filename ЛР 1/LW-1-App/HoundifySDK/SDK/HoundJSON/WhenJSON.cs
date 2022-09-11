/* file "WhenJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WhenJSON : JSONBase
  {
    private bool flagHasInstant;
    private DateAndOrTimeJSON  storeInstant;
    private bool flagHasStart;
    private DateAndOrTimeJSON  storeStart;
    private bool flagHasEnd;
    private DateAndOrTimeJSON  storeEnd;
    private bool flagHasDetails;
    private SetOfTimeJSON  storeDetails;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONInstant(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setInstant(convert_classy);
      }


    private void  fromJSONStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStart(convert_classy);
      }


    private void  fromJSONEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEnd(convert_classy);
      }


    private void  fromJSONDetails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SetOfTimeJSON convert_classy = SetOfTimeJSON.from_json(json_value, ignore_extras, true);
        setDetails(convert_classy);
      }


    public WhenJSON()
      {
        flagHasInstant = false;
        flagHasStart = false;
        flagHasEnd = false;
        flagHasDetails = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasInstant()
      {
        return flagHasInstant;
      }

    public DateAndOrTimeJSON   getInstant()
      {
        Debug.Assert(flagHasInstant);
        return storeInstant;
      }

    public bool  hasStart()
      {
        return flagHasStart;
      }

    public DateAndOrTimeJSON   getStart()
      {
        Debug.Assert(flagHasStart);
        return storeStart;
      }

    public bool  hasEnd()
      {
        return flagHasEnd;
      }

    public DateAndOrTimeJSON   getEnd()
      {
        Debug.Assert(flagHasEnd);
        return storeEnd;
      }

    public bool  hasDetails()
      {
        return flagHasDetails;
      }

    public SetOfTimeJSON   getDetails()
      {
        Debug.Assert(flagHasDetails);
        return storeDetails;
      }


    public virtual int extraWhenComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWhenComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWhenComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWhenLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setInstant(DateAndOrTimeJSON  new_value)
      {
        if (flagHasInstant)
          {
          }
        flagHasInstant = true;
        storeInstant = new_value;
      }
    public void unsetInstant()
      {
        if (flagHasInstant)
          {
          }
        flagHasInstant = false;
      }
    public void setStart(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStart)
          {
          }
        flagHasStart = true;
        storeStart = new_value;
      }
    public void unsetStart()
      {
        if (flagHasStart)
          {
          }
        flagHasStart = false;
      }
    public void setEnd(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEnd)
          {
          }
        flagHasEnd = true;
        storeEnd = new_value;
      }
    public void unsetEnd()
      {
        if (flagHasEnd)
          {
          }
        flagHasEnd = false;
      }
    public void setDetails(SetOfTimeJSON  new_value)
      {
        if (flagHasDetails)
          {
          }
        flagHasDetails = true;
        storeDetails = new_value;
      }
    public void unsetDetails()
      {
        if (flagHasDetails)
          {
          }
        flagHasDetails = false;
      }

    public virtual void extraWhenAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWhenSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWhenLookup(key);
        if (old_field == null)
          {
            extraWhenAppendPair(key, new_component);
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
        if (flagHasInstant)
          {
            handler.start_pair("Instant");
            if (partial_allowed)
                storeInstant.write_partial_as_json(handler);
            else
                storeInstant.write_as_json(handler);
          }
        if (flagHasStart)
          {
            handler.start_pair("Start");
            if (partial_allowed)
                storeStart.write_partial_as_json(handler);
            else
                storeStart.write_as_json(handler);
          }
        if (flagHasEnd)
          {
            handler.start_pair("End");
            if (partial_allowed)
                storeEnd.write_partial_as_json(handler);
            else
                storeEnd.write_as_json(handler);
          }
        if (flagHasDetails)
          {
            handler.start_pair("Details");
            if (partial_allowed)
                storeDetails.write_partial_as_json(handler);
            else
                storeDetails.write_as_json(handler);
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

    public static WhenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WhenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type When", ignore_extras);
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
    public static WhenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WhenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WhenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type When", ignore_extras);
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
    public static WhenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WhenJSON from_text(string text, bool ignore_extras)
      {
        WhenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type When", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WhenJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WhenJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WhenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type When", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorInstant;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStart;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEnd;
        private SetOfTimeJSON.HoldingGenerator fieldGeneratorDetails;
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
            WhenJSON result = new WhenJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWhenAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WhenJSON result)
          {
            if (fieldGeneratorInstant.have_value)
              {
                result.setInstant(fieldGeneratorInstant.value);
                fieldGeneratorInstant.have_value = false;
              }
            if (fieldGeneratorStart.have_value)
              {
                result.setStart(fieldGeneratorStart.value);
                fieldGeneratorStart.have_value = false;
              }
            if (fieldGeneratorEnd.have_value)
              {
                result.setEnd(fieldGeneratorEnd.value);
                fieldGeneratorEnd.have_value = false;
              }
            if (fieldGeneratorDetails.have_value)
              {
                result.setDetails(fieldGeneratorDetails.value);
                fieldGeneratorDetails.have_value = false;
              }
          }
        protected abstract void handle_result(WhenJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "etails", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorDetails;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "nd", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorEnd;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nstant", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorInstant;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tart", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorStart;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorInstant = new DateAndOrTimeJSON.HoldingGenerator("field \"Instant\" of the When class", ignore_extras);
            fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the When class", ignore_extras);
            fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the When class", ignore_extras);
            fieldGeneratorDetails = new SetOfTimeJSON.HoldingGenerator("field \"Details\" of the When class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the When class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorInstant = new DateAndOrTimeJSON.HoldingGenerator("field \"Instant\" of the When class", false);
            fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the When class", false);
            fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the When class", false);
            fieldGeneratorDetails = new SetOfTimeJSON.HoldingGenerator("field \"Details\" of the When class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the When class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorInstant.reset();
            fieldGeneratorStart.reset();
            fieldGeneratorEnd.reset();
            fieldGeneratorDetails.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorInstant.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStart.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEnd.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDetails.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorInstant.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStart.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEnd.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDetails.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(WhenJSON  result)
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
        public WhenJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WhenJSON  result)
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
    protected virtual void handle_result(List<WhenJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WhenJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WhenJSON>();
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
    public List<WhenJSON> value;
  };
  };
