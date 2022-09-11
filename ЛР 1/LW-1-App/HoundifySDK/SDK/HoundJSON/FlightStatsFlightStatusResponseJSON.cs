/* file "FlightStatsFlightStatusResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightStatsFlightStatusResponseJSON : JSONBase
  {
    private bool flagHaserror;
    private FlightStatsErrorJSON  storeerror;
    private bool flagHasflightStatuses;
    private List< FlightStatsFlightStatusJSON  > storeflightStatuses;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONerror(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsErrorJSON convert_classy = FlightStatsErrorJSON.from_json(json_value, ignore_extras, true);
        seterror(convert_classy);
      }


    private void  fromJSONflightStatuses(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field flightStatuses of FlightStatsFlightStatusResponseJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightStatsFlightStatusJSON  > vector_flightStatuses1 = new List< FlightStatsFlightStatusJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightStatsFlightStatusJSON convert_classy = FlightStatsFlightStatusJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_flightStatuses1.Add(convert_classy);
          }
        initflightStatuses();
        for (int num1 = 0; num1 < vector_flightStatuses1.Count; ++num1)
            appendflightStatuses(vector_flightStatuses1[num1]);
        for (int num1 = 0; num1 < vector_flightStatuses1.Count; ++num1)
          {
          }
      }


    public FlightStatsFlightStatusResponseJSON()
      {
        flagHaserror = false;
        flagHasflightStatuses = false;
        storeflightStatuses = new List< FlightStatsFlightStatusJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  haserror()
      {
        return flagHaserror;
      }

    public FlightStatsErrorJSON   geterror()
      {
        Debug.Assert(flagHaserror);
        return storeerror;
      }

    public bool  hasflightStatuses()
      {
        return flagHasflightStatuses;
      }

    public int  countOfflightStatuses()
      {
        Debug.Assert(flagHasflightStatuses);
        return storeflightStatuses.Count;
      }

    public FlightStatsFlightStatusJSON   elementOfflightStatuses(int element_num)
      {
        Debug.Assert(flagHasflightStatuses);
        return storeflightStatuses[element_num];
      }

    public List< FlightStatsFlightStatusJSON  >  getflightStatuses()
      {
        Debug.Assert(flagHasflightStatuses);
        return storeflightStatuses;
      }


    public virtual int extraFlightStatsFlightStatusResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatsFlightStatusResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatsFlightStatusResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatsFlightStatusResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void seterror(FlightStatsErrorJSON  new_value)
      {
        if (flagHaserror)
          {
          }
        flagHaserror = true;
        storeerror = new_value;
      }
    public void unseterror()
      {
        if (flagHaserror)
          {
          }
        flagHaserror = false;
      }
    public void initflightStatuses()
      {
        if (flagHasflightStatuses)
          {
            for (int num1 = 0; num1 < storeflightStatuses.Count; ++num1)
              {
              }
          }
        flagHasflightStatuses = true;
        storeflightStatuses.Clear();
      }
    public void appendflightStatuses(FlightStatsFlightStatusJSON  to_append)
      {
        if (!flagHasflightStatuses)
          {
            flagHasflightStatuses = true;
            storeflightStatuses.Clear();
          }
        Debug.Assert(flagHasflightStatuses);
        storeflightStatuses.Add(to_append);
      }
    public void unsetflightStatuses()
      {
        if (flagHasflightStatuses)
          {
            for (int num2 = 0; num2 < storeflightStatuses.Count; ++num2)
              {
              }
          }
        flagHasflightStatuses = false;
        storeflightStatuses.Clear();
      }

    public virtual void extraFlightStatsFlightStatusResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatsFlightStatusResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatsFlightStatusResponseLookup(key);
        if (old_field == null)
          {
            extraFlightStatsFlightStatusResponseAppendPair(key, new_component);
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
        if (flagHaserror)
          {
            handler.start_pair("error");
            if (partial_allowed)
                storeerror.write_partial_as_json(handler);
            else
                storeerror.write_as_json(handler);
          }
        if (flagHasflightStatuses)
          {
            handler.start_pair("flightStatuses");
            handler.start_array();
            for (int num1 = 0; num1 < storeflightStatuses.Count; ++num1)
              {
                if (partial_allowed)
                    storeflightStatuses[num1].write_partial_as_json(handler);
                else
                    storeflightStatuses[num1].write_as_json(handler);
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

    public static FlightStatsFlightStatusResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsFlightStatusResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsFlightStatusResponse", ignore_extras);
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
    public static FlightStatsFlightStatusResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsFlightStatusResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsFlightStatusResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsFlightStatusResponse", ignore_extras);
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
    public static FlightStatsFlightStatusResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsFlightStatusResponseJSON from_text(string text, bool ignore_extras)
      {
        FlightStatsFlightStatusResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsFlightStatusResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatsFlightStatusResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatsFlightStatusResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatsFlightStatusResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsFlightStatusResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private FlightStatsErrorJSON.HoldingGenerator fieldGeneratorerror;
        private FlightStatsFlightStatusJSON.HoldingArrayGenerator fieldGeneratorflightStatuses;
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
            FlightStatsFlightStatusResponseJSON result = new FlightStatsFlightStatusResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatsFlightStatusResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatsFlightStatusResponseJSON result)
          {
            if (fieldGeneratorerror.have_value)
              {
                result.seterror(fieldGeneratorerror.value);
                fieldGeneratorerror.have_value = false;
              }
            if (fieldGeneratorflightStatuses.have_value)
              {
                result.initflightStatuses();
                int count = fieldGeneratorflightStatuses.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendflightStatuses(fieldGeneratorflightStatuses.value[num]);
                  }
                fieldGeneratorflightStatuses.value.Clear();
                fieldGeneratorflightStatuses.have_value = false;
              }
          }
        protected abstract void handle_result(FlightStatsFlightStatusResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'e':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorerror;
                    break;
                case 'f':
                    if ((String.Compare(field_name, 1, "lightStatuses", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorflightStatuses;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorerror = new FlightStatsErrorJSON.HoldingGenerator("field \"error\" of the FlightStatsFlightStatusResponse class", ignore_extras);
            fieldGeneratorflightStatuses = new FlightStatsFlightStatusJSON.HoldingArrayGenerator("field \"flightStatuses\" of the FlightStatsFlightStatusResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatsFlightStatusResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorerror = new FlightStatsErrorJSON.HoldingGenerator("field \"error\" of the FlightStatsFlightStatusResponse class", false);
            fieldGeneratorflightStatuses = new FlightStatsFlightStatusJSON.HoldingArrayGenerator("field \"flightStatuses\" of the FlightStatsFlightStatusResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatsFlightStatusResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorerror.reset();
            fieldGeneratorflightStatuses.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorerror.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorflightStatuses.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorerror.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorflightStatuses.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatsFlightStatusResponseJSON  result)
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
        public FlightStatsFlightStatusResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatsFlightStatusResponseJSON  result)
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
    protected virtual void handle_result(List<FlightStatsFlightStatusResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatsFlightStatusResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatsFlightStatusResponseJSON>();
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
    public List<FlightStatsFlightStatusResponseJSON> value;
  };
  };
