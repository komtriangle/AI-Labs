/* file "OutlookTimeSlotJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class OutlookTimeSlotJSON : JSONBase
  {
    private bool flagHasstart;
    private OutlookTimeSpecifierJSON  storestart;
    private bool flagHasend;
    private OutlookTimeSpecifierJSON  storeend;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONstart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OutlookTimeSpecifierJSON convert_classy = OutlookTimeSpecifierJSON.from_json(json_value, ignore_extras, true);
        setstart(convert_classy);
      }


    private void  fromJSONend(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OutlookTimeSpecifierJSON convert_classy = OutlookTimeSpecifierJSON.from_json(json_value, ignore_extras, true);
        setend(convert_classy);
      }


    public OutlookTimeSlotJSON()
      {
        flagHasstart = false;
        flagHasend = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasstart()
      {
        return flagHasstart;
      }

    public OutlookTimeSpecifierJSON   getstart()
      {
        Debug.Assert(flagHasstart);
        return storestart;
      }

    public bool  hasend()
      {
        return flagHasend;
      }

    public OutlookTimeSpecifierJSON   getend()
      {
        Debug.Assert(flagHasend);
        return storeend;
      }


    public virtual int extraOutlookTimeSlotComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOutlookTimeSlotComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOutlookTimeSlotComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOutlookTimeSlotLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setstart(OutlookTimeSpecifierJSON  new_value)
      {
        if (flagHasstart)
          {
          }
        flagHasstart = true;
        storestart = new_value;
      }
    public void unsetstart()
      {
        if (flagHasstart)
          {
          }
        flagHasstart = false;
      }
    public void setend(OutlookTimeSpecifierJSON  new_value)
      {
        if (flagHasend)
          {
          }
        flagHasend = true;
        storeend = new_value;
      }
    public void unsetend()
      {
        if (flagHasend)
          {
          }
        flagHasend = false;
      }

    public virtual void extraOutlookTimeSlotAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOutlookTimeSlotSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOutlookTimeSlotLookup(key);
        if (old_field == null)
          {
            extraOutlookTimeSlotAppendPair(key, new_component);
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
        if (flagHasstart)
          {
            handler.start_pair("start");
            if (partial_allowed)
                storestart.write_partial_as_json(handler);
            else
                storestart.write_as_json(handler);
          }
        if (flagHasend)
          {
            handler.start_pair("end");
            if (partial_allowed)
                storeend.write_partial_as_json(handler);
            else
                storeend.write_as_json(handler);
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

    public static OutlookTimeSlotJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookTimeSlotJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookTimeSlot", ignore_extras);
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
    public static OutlookTimeSlotJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookTimeSlotJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookTimeSlotJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookTimeSlot", ignore_extras);
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
    public static OutlookTimeSlotJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookTimeSlotJSON from_text(string text, bool ignore_extras)
      {
        OutlookTimeSlotJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookTimeSlot", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OutlookTimeSlotJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OutlookTimeSlotJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OutlookTimeSlotJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookTimeSlot", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private OutlookTimeSpecifierJSON.HoldingGenerator fieldGeneratorstart;
        private OutlookTimeSpecifierJSON.HoldingGenerator fieldGeneratorend;
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
            OutlookTimeSlotJSON result = new OutlookTimeSlotJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOutlookTimeSlotAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OutlookTimeSlotJSON result)
          {
            if (fieldGeneratorstart.have_value)
              {
                result.setstart(fieldGeneratorstart.value);
                fieldGeneratorstart.have_value = false;
              }
            if (fieldGeneratorend.have_value)
              {
                result.setend(fieldGeneratorend.value);
                fieldGeneratorend.have_value = false;
              }
          }
        protected abstract void handle_result(OutlookTimeSlotJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'e':
                    if ((String.Compare(field_name, 1, "nd", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorend;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "tart", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorstart;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorstart = new OutlookTimeSpecifierJSON.HoldingGenerator("field \"start\" of the OutlookTimeSlot class", ignore_extras);
            fieldGeneratorend = new OutlookTimeSpecifierJSON.HoldingGenerator("field \"end\" of the OutlookTimeSlot class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OutlookTimeSlot class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorstart = new OutlookTimeSpecifierJSON.HoldingGenerator("field \"start\" of the OutlookTimeSlot class", false);
            fieldGeneratorend = new OutlookTimeSpecifierJSON.HoldingGenerator("field \"end\" of the OutlookTimeSlot class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OutlookTimeSlot class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorstart.reset();
            fieldGeneratorend.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorstart.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorend.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorstart.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorend.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(OutlookTimeSlotJSON  result)
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
        public OutlookTimeSlotJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OutlookTimeSlotJSON  result)
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
    protected virtual void handle_result(List<OutlookTimeSlotJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OutlookTimeSlotJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OutlookTimeSlotJSON>();
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
    public List<OutlookTimeSlotJSON> value;
  };
  };
