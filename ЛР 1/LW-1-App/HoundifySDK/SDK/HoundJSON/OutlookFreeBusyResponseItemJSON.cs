/* file "OutlookFreeBusyResponseItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class OutlookFreeBusyResponseItemJSON : JSONBase
  {
    private bool flagHasscheduleId;
    private string storescheduleId;
    private bool flagHasavailabilityView;
    private string storeavailabilityView;
    private bool flagHasscheduleItems;
    private List< OutlookFreeBusyResponseScheduleItemJSON  > storescheduleItems;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONscheduleId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field scheduleId of OutlookFreeBusyResponseItemJSON is not a string.");
        setscheduleId(json_string.getData());
      }


    private void  fromJSONavailabilityView(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field availabilityView of OutlookFreeBusyResponseItemJSON is not a string.");
        setavailabilityView(json_string.getData());
      }


    private void  fromJSONscheduleItems(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field scheduleItems of OutlookFreeBusyResponseItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< OutlookFreeBusyResponseScheduleItemJSON  > vector_scheduleItems1 = new List< OutlookFreeBusyResponseScheduleItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            OutlookFreeBusyResponseScheduleItemJSON convert_classy = OutlookFreeBusyResponseScheduleItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_scheduleItems1.Add(convert_classy);
          }
        initscheduleItems();
        for (int num1 = 0; num1 < vector_scheduleItems1.Count; ++num1)
            appendscheduleItems(vector_scheduleItems1[num1]);
        for (int num1 = 0; num1 < vector_scheduleItems1.Count; ++num1)
          {
          }
      }


    public OutlookFreeBusyResponseItemJSON()
      {
        flagHasscheduleId = false;
        flagHasavailabilityView = false;
        flagHasscheduleItems = false;
        storescheduleItems = new List< OutlookFreeBusyResponseScheduleItemJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasscheduleId()
      {
        return flagHasscheduleId;
      }

    public string  getscheduleId()
      {
        Debug.Assert(flagHasscheduleId);
        return storescheduleId;
      }

    public bool  hasavailabilityView()
      {
        return flagHasavailabilityView;
      }

    public string  getavailabilityView()
      {
        Debug.Assert(flagHasavailabilityView);
        return storeavailabilityView;
      }

    public bool  hasscheduleItems()
      {
        return flagHasscheduleItems;
      }

    public int  countOfscheduleItems()
      {
        Debug.Assert(flagHasscheduleItems);
        return storescheduleItems.Count;
      }

    public OutlookFreeBusyResponseScheduleItemJSON   elementOfscheduleItems(int element_num)
      {
        Debug.Assert(flagHasscheduleItems);
        return storescheduleItems[element_num];
      }

    public List< OutlookFreeBusyResponseScheduleItemJSON  >  getscheduleItems()
      {
        Debug.Assert(flagHasscheduleItems);
        return storescheduleItems;
      }


    public virtual int extraOutlookFreeBusyResponseItemComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOutlookFreeBusyResponseItemComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOutlookFreeBusyResponseItemComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOutlookFreeBusyResponseItemLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setscheduleId(string new_value)
      {
        flagHasscheduleId = true;
        storescheduleId = new_value;
      }
    public void unsetscheduleId()
      {
        flagHasscheduleId = false;
      }
    public void setavailabilityView(string new_value)
      {
        flagHasavailabilityView = true;
        storeavailabilityView = new_value;
      }
    public void unsetavailabilityView()
      {
        flagHasavailabilityView = false;
      }
    public void initscheduleItems()
      {
        if (flagHasscheduleItems)
          {
            for (int num1 = 0; num1 < storescheduleItems.Count; ++num1)
              {
              }
          }
        flagHasscheduleItems = true;
        storescheduleItems.Clear();
      }
    public void appendscheduleItems(OutlookFreeBusyResponseScheduleItemJSON  to_append)
      {
        if (!flagHasscheduleItems)
          {
            flagHasscheduleItems = true;
            storescheduleItems.Clear();
          }
        Debug.Assert(flagHasscheduleItems);
        storescheduleItems.Add(to_append);
      }
    public void unsetscheduleItems()
      {
        if (flagHasscheduleItems)
          {
            for (int num2 = 0; num2 < storescheduleItems.Count; ++num2)
              {
              }
          }
        flagHasscheduleItems = false;
        storescheduleItems.Clear();
      }

    public virtual void extraOutlookFreeBusyResponseItemAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOutlookFreeBusyResponseItemSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOutlookFreeBusyResponseItemLookup(key);
        if (old_field == null)
          {
            extraOutlookFreeBusyResponseItemAppendPair(key, new_component);
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
        if (flagHasscheduleId)
          {
            handler.start_pair("scheduleId");
            handler.string_value(storescheduleId);
          }
        if (flagHasavailabilityView)
          {
            handler.start_pair("availabilityView");
            handler.string_value(storeavailabilityView);
          }
        if (flagHasscheduleItems)
          {
            handler.start_pair("scheduleItems");
            handler.start_array();
            for (int num1 = 0; num1 < storescheduleItems.Count; ++num1)
              {
                if (partial_allowed)
                    storescheduleItems[num1].write_partial_as_json(handler);
                else
                    storescheduleItems[num1].write_as_json(handler);
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

    public static OutlookFreeBusyResponseItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookFreeBusyResponseItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFreeBusyResponseItem", ignore_extras);
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
    public static OutlookFreeBusyResponseItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookFreeBusyResponseItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookFreeBusyResponseItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFreeBusyResponseItem", ignore_extras);
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
    public static OutlookFreeBusyResponseItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookFreeBusyResponseItemJSON from_text(string text, bool ignore_extras)
      {
        OutlookFreeBusyResponseItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFreeBusyResponseItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OutlookFreeBusyResponseItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OutlookFreeBusyResponseItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OutlookFreeBusyResponseItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookFreeBusyResponseItem", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorscheduleId;
        private JSONHoldingStringGenerator fieldGeneratoravailabilityView;
        private OutlookFreeBusyResponseScheduleItemJSON.HoldingArrayGenerator fieldGeneratorscheduleItems;
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
            OutlookFreeBusyResponseItemJSON result = new OutlookFreeBusyResponseItemJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOutlookFreeBusyResponseItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OutlookFreeBusyResponseItemJSON result)
          {
            if (fieldGeneratorscheduleId.have_value)
              {
                result.setscheduleId(fieldGeneratorscheduleId.value);
                fieldGeneratorscheduleId.have_value = false;
              }
            if (fieldGeneratoravailabilityView.have_value)
              {
                result.setavailabilityView(fieldGeneratoravailabilityView.value);
                fieldGeneratoravailabilityView.have_value = false;
              }
            if (fieldGeneratorscheduleItems.have_value)
              {
                result.initscheduleItems();
                int count = fieldGeneratorscheduleItems.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendscheduleItems(fieldGeneratorscheduleItems.value[num]);
                  }
                fieldGeneratorscheduleItems.value.Clear();
                fieldGeneratorscheduleItems.have_value = false;
              }
          }
        protected abstract void handle_result(OutlookFreeBusyResponseItemJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    if ((String.Compare(field_name, 1, "vailabilityView", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratoravailabilityView;
                    break;
                case 's':
                    if (String.Compare(field_name, 1, "cheduleI", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'd':
                                if (field_name.Length == 10)
                                    return fieldGeneratorscheduleId;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 10, "ems", 0, 3, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorscheduleItems;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorscheduleId = new JSONHoldingStringGenerator("field \"scheduleId\" of the OutlookFreeBusyResponseItem class");
            fieldGeneratoravailabilityView = new JSONHoldingStringGenerator("field \"availabilityView\" of the OutlookFreeBusyResponseItem class");
            fieldGeneratorscheduleItems = new OutlookFreeBusyResponseScheduleItemJSON.HoldingArrayGenerator("field \"scheduleItems\" of the OutlookFreeBusyResponseItem class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OutlookFreeBusyResponseItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorscheduleId = new JSONHoldingStringGenerator("field \"scheduleId\" of the OutlookFreeBusyResponseItem class");
            fieldGeneratoravailabilityView = new JSONHoldingStringGenerator("field \"availabilityView\" of the OutlookFreeBusyResponseItem class");
            fieldGeneratorscheduleItems = new OutlookFreeBusyResponseScheduleItemJSON.HoldingArrayGenerator("field \"scheduleItems\" of the OutlookFreeBusyResponseItem class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OutlookFreeBusyResponseItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorscheduleId.reset();
            fieldGeneratoravailabilityView.reset();
            fieldGeneratorscheduleItems.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorscheduleItems.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorscheduleItems.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(OutlookFreeBusyResponseItemJSON  result)
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
        public OutlookFreeBusyResponseItemJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OutlookFreeBusyResponseItemJSON  result)
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
    protected virtual void handle_result(List<OutlookFreeBusyResponseItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OutlookFreeBusyResponseItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OutlookFreeBusyResponseItemJSON>();
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
    public List<OutlookFreeBusyResponseItemJSON> value;
  };
  };
