/* file "WeeklyOperatingHoursJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WeeklyOperatingHoursJSON : SetOfTimeJSON
  {
    private bool flagHasRegularWeeklyHours;
    private List< WeeklyOpenCloseEventJSON  > storeRegularWeeklyHours;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRegularWeeklyHoursToJSON()
      {
        JSONArrayValue generated_array_1_RegularWeeklyHours = new JSONArrayValue();
        for (int num1 = 0; num1 < storeRegularWeeklyHours.Count; ++num1)
          {
            JSONValueHandler handler_RegularWeeklyHours = new JSONValueHandler();
            storeRegularWeeklyHours[num1].write_as_json(handler_RegularWeeklyHours);
            generated_array_1_RegularWeeklyHours.appendComponent(handler_RegularWeeklyHours.result);
          }
        return generated_array_1_RegularWeeklyHours;
      }


    private void  fromJSONRegularWeeklyHours(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RegularWeeklyHours of WeeklyOperatingHoursJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< WeeklyOpenCloseEventJSON  > vector_RegularWeeklyHours1 = new List< WeeklyOpenCloseEventJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            WeeklyOpenCloseEventJSON convert_classy = WeeklyOpenCloseEventJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RegularWeeklyHours1.Add(convert_classy);
          }
        initRegularWeeklyHours();
        for (int num1 = 0; num1 < vector_RegularWeeklyHours1.Count; ++num1)
            appendRegularWeeklyHours(vector_RegularWeeklyHours1[num1]);
        for (int num1 = 0; num1 < vector_RegularWeeklyHours1.Count; ++num1)
          {
          }
      }


    public WeeklyOperatingHoursJSON()
      {
        flagHasRegularWeeklyHours = false;
        storeRegularWeeklyHours = new List< WeeklyOpenCloseEventJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSetOfTimeKind()
      {
        return "WeeklyOperatingHours";
      }

    public bool  hasRegularWeeklyHours()
      {
        return flagHasRegularWeeklyHours;
      }

    public int  countOfRegularWeeklyHours()
      {
        Debug.Assert(flagHasRegularWeeklyHours);
        return storeRegularWeeklyHours.Count;
      }

    public WeeklyOpenCloseEventJSON   elementOfRegularWeeklyHours(int element_num)
      {
        Debug.Assert(flagHasRegularWeeklyHours);
        return storeRegularWeeklyHours[element_num];
      }

    public List< WeeklyOpenCloseEventJSON  >  getRegularWeeklyHours()
      {
        Debug.Assert(flagHasRegularWeeklyHours);
        return storeRegularWeeklyHours;
      }


    public virtual int extraWeeklyOperatingHoursComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWeeklyOperatingHoursComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWeeklyOperatingHoursComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWeeklyOperatingHoursLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSetOfTimeComponentCount()
      {
        int result = 0;
        if (flagHasRegularWeeklyHours)
            ++result;
        result += extraWeeklyOperatingHoursComponentCount();
        return result;
      }
    public override string extraSetOfTimeComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRegularWeeklyHours)
          {
            if (remainder == 0)
                return "RegularWeeklyHours";
            --remainder;
          }
        return extraWeeklyOperatingHoursComponentKey(remainder);
      }
    public override JSONValue extraSetOfTimeComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRegularWeeklyHours)
          {
            if (remainder == 0)
                return extraRegularWeeklyHoursToJSON();
            --remainder;
          }
        return extraWeeklyOperatingHoursComponentValue(remainder);
      }
    public override JSONValue extraSetOfTimeLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "RegularWeeklyHours", 0, 18, false) == 0) && (field_name.Length == 18))
            return (flagHasRegularWeeklyHours ? extraRegularWeeklyHoursToJSON() : null);
        return extraWeeklyOperatingHoursLookup(field_name);
      }

    public void initRegularWeeklyHours()
      {
        if (flagHasRegularWeeklyHours)
          {
            for (int num1 = 0; num1 < storeRegularWeeklyHours.Count; ++num1)
              {
              }
          }
        flagHasRegularWeeklyHours = true;
        storeRegularWeeklyHours.Clear();
      }
    public void appendRegularWeeklyHours(WeeklyOpenCloseEventJSON  to_append)
      {
        if (!flagHasRegularWeeklyHours)
          {
            flagHasRegularWeeklyHours = true;
            storeRegularWeeklyHours.Clear();
          }
        Debug.Assert(flagHasRegularWeeklyHours);
        storeRegularWeeklyHours.Add(to_append);
      }
    public void unsetRegularWeeklyHours()
      {
        if (flagHasRegularWeeklyHours)
          {
            for (int num2 = 0; num2 < storeRegularWeeklyHours.Count; ++num2)
              {
              }
          }
        flagHasRegularWeeklyHours = false;
        storeRegularWeeklyHours.Clear();
      }

    public virtual void extraWeeklyOperatingHoursAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWeeklyOperatingHoursSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWeeklyOperatingHoursLookup(key);
        if (old_field == null)
          {
            extraWeeklyOperatingHoursAppendPair(key, new_component);
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
    public override void extraSetOfTimeAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RegularWeeklyHours", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONRegularWeeklyHours(new_component, false);
            return;
            }
        extraWeeklyOperatingHoursAppendPair(key, new_component);
      }
    public override void extraSetOfTimeSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RegularWeeklyHours", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONRegularWeeklyHours(new_component, false);
            return;
            }
        extraWeeklyOperatingHoursSetField(key, new_component);
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
        if (flagHasRegularWeeklyHours)
          {
            handler.start_pair("RegularWeeklyHours");
            handler.start_array();
            for (int num1 = 0; num1 < storeRegularWeeklyHours.Count; ++num1)
              {
                if (partial_allowed)
                    storeRegularWeeklyHours[num1].write_partial_as_json(handler);
                else
                    storeRegularWeeklyHours[num1].write_as_json(handler);
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
        return null;
      }

    public static new WeeklyOperatingHoursJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WeeklyOperatingHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeeklyOperatingHours", ignore_extras);
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
    public static new WeeklyOperatingHoursJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WeeklyOperatingHoursJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WeeklyOperatingHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeeklyOperatingHours", ignore_extras);
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
    public static new WeeklyOperatingHoursJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WeeklyOperatingHoursJSON from_text(string text, bool ignore_extras)
      {
        WeeklyOperatingHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeeklyOperatingHours", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WeeklyOperatingHoursJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new WeeklyOperatingHoursJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WeeklyOperatingHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeeklyOperatingHours", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SetOfTimeJSON.Generator
      {
        private WeeklyOpenCloseEventJSON.HoldingArrayGenerator fieldGeneratorRegularWeeklyHours;
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
            if (!(getSetOfTimeJSONKey().Equals("WeeklyOperatingHours")))
                throw new Exception("The key field has a value other than `WeeklyOperatingHours'.");
            WeeklyOperatingHoursJSON result = new WeeklyOperatingHoursJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWeeklyOperatingHoursAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SetOfTimeJSON new_result)
          {
            handle_result((WeeklyOperatingHoursJSON )new_result);
          }
        protected void finish(WeeklyOperatingHoursJSON result)
          {
            if (fieldGeneratorRegularWeeklyHours.have_value)
              {
                result.initRegularWeeklyHours();
                int count = fieldGeneratorRegularWeeklyHours.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRegularWeeklyHours(fieldGeneratorRegularWeeklyHours.value[num]);
                  }
                fieldGeneratorRegularWeeklyHours.value.Clear();
                fieldGeneratorRegularWeeklyHours.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(WeeklyOperatingHoursJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "RegularWeeklyHours", 0, 18, false) == 0) && (field_name.Length == 18))
                return fieldGeneratorRegularWeeklyHours;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRegularWeeklyHours = new WeeklyOpenCloseEventJSON.HoldingArrayGenerator("field \"RegularWeeklyHours\" of the WeeklyOperatingHours class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WeeklyOperatingHours class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRegularWeeklyHours = new WeeklyOpenCloseEventJSON.HoldingArrayGenerator("field \"RegularWeeklyHours\" of the WeeklyOperatingHours class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WeeklyOperatingHours class");
          }

        public override void reset()
          {
            fieldGeneratorRegularWeeklyHours.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(WeeklyOperatingHoursJSON  result)
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
        public WeeklyOperatingHoursJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WeeklyOperatingHoursJSON  result)
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
    protected virtual void handle_result(List<WeeklyOperatingHoursJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WeeklyOperatingHoursJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WeeklyOperatingHoursJSON>();
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
    public List<WeeklyOperatingHoursJSON> value;
  };
  };
