/* file "HondaCarManualParametersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HondaCarManualParametersJSON : JSONBase
  {
    private bool flagHasVehicleManual;
    private HondaCarManualVehicleManualJSON  storeVehicleManual;
    private bool flagHasNavigationManual;
    private HondaCarManualNavigationManualJSON  storeNavigationManual;
    private bool flagHasCarStatus;
    private CarStatusJSON  storeCarStatus;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONVehicleManual(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HondaCarManualVehicleManualJSON convert_classy = HondaCarManualVehicleManualJSON.from_json(json_value, ignore_extras, true);
        setVehicleManual(convert_classy);
      }


    private void  fromJSONNavigationManual(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HondaCarManualNavigationManualJSON convert_classy = HondaCarManualNavigationManualJSON.from_json(json_value, ignore_extras, true);
        setNavigationManual(convert_classy);
      }


    private void  fromJSONCarStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CarStatusJSON convert_classy = CarStatusJSON.from_json(json_value, ignore_extras, true);
        setCarStatus(convert_classy);
      }


    public HondaCarManualParametersJSON()
      {
        flagHasVehicleManual = false;
        flagHasNavigationManual = false;
        flagHasCarStatus = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasVehicleManual()
      {
        return flagHasVehicleManual;
      }

    public HondaCarManualVehicleManualJSON   getVehicleManual()
      {
        Debug.Assert(flagHasVehicleManual);
        return storeVehicleManual;
      }

    public bool  hasNavigationManual()
      {
        return flagHasNavigationManual;
      }

    public HondaCarManualNavigationManualJSON   getNavigationManual()
      {
        Debug.Assert(flagHasNavigationManual);
        return storeNavigationManual;
      }

    public bool  hasCarStatus()
      {
        return flagHasCarStatus;
      }

    public CarStatusJSON   getCarStatus()
      {
        Debug.Assert(flagHasCarStatus);
        return storeCarStatus;
      }


    public virtual int extraHondaCarManualParametersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHondaCarManualParametersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHondaCarManualParametersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHondaCarManualParametersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setVehicleManual(HondaCarManualVehicleManualJSON  new_value)
      {
        if (flagHasVehicleManual)
          {
          }
        flagHasVehicleManual = true;
        storeVehicleManual = new_value;
      }
    public void unsetVehicleManual()
      {
        if (flagHasVehicleManual)
          {
          }
        flagHasVehicleManual = false;
      }
    public void setNavigationManual(HondaCarManualNavigationManualJSON  new_value)
      {
        if (flagHasNavigationManual)
          {
          }
        flagHasNavigationManual = true;
        storeNavigationManual = new_value;
      }
    public void unsetNavigationManual()
      {
        if (flagHasNavigationManual)
          {
          }
        flagHasNavigationManual = false;
      }
    public void setCarStatus(CarStatusJSON  new_value)
      {
        if (flagHasCarStatus)
          {
          }
        flagHasCarStatus = true;
        storeCarStatus = new_value;
      }
    public void unsetCarStatus()
      {
        if (flagHasCarStatus)
          {
          }
        flagHasCarStatus = false;
      }

    public virtual void extraHondaCarManualParametersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHondaCarManualParametersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHondaCarManualParametersLookup(key);
        if (old_field == null)
          {
            extraHondaCarManualParametersAppendPair(key, new_component);
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
        if (flagHasVehicleManual)
          {
            handler.start_pair("VehicleManual");
            if (partial_allowed)
                storeVehicleManual.write_partial_as_json(handler);
            else
                storeVehicleManual.write_as_json(handler);
          }
        if (flagHasNavigationManual)
          {
            handler.start_pair("NavigationManual");
            if (partial_allowed)
                storeNavigationManual.write_partial_as_json(handler);
            else
                storeNavigationManual.write_as_json(handler);
          }
        if (flagHasCarStatus)
          {
            handler.start_pair("CarStatus");
            if (partial_allowed)
                storeCarStatus.write_partial_as_json(handler);
            else
                storeCarStatus.write_as_json(handler);
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

    public static HondaCarManualParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HondaCarManualParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaCarManualParameters", ignore_extras);
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
    public static HondaCarManualParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HondaCarManualParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HondaCarManualParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaCarManualParameters", ignore_extras);
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
    public static HondaCarManualParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HondaCarManualParametersJSON from_text(string text, bool ignore_extras)
      {
        HondaCarManualParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaCarManualParameters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HondaCarManualParametersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HondaCarManualParametersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HondaCarManualParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaCarManualParameters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private HondaCarManualVehicleManualJSON.HoldingGenerator fieldGeneratorVehicleManual;
        private HondaCarManualNavigationManualJSON.HoldingGenerator fieldGeneratorNavigationManual;
        private CarStatusJSON.HoldingGenerator fieldGeneratorCarStatus;
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
            HondaCarManualParametersJSON result = new HondaCarManualParametersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHondaCarManualParametersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HondaCarManualParametersJSON result)
          {
            if (fieldGeneratorVehicleManual.have_value)
              {
                result.setVehicleManual(fieldGeneratorVehicleManual.value);
                fieldGeneratorVehicleManual.have_value = false;
              }
            if (fieldGeneratorNavigationManual.have_value)
              {
                result.setNavigationManual(fieldGeneratorNavigationManual.value);
                fieldGeneratorNavigationManual.have_value = false;
              }
            if (fieldGeneratorCarStatus.have_value)
              {
                result.setCarStatus(fieldGeneratorCarStatus.value);
                fieldGeneratorCarStatus.have_value = false;
              }
          }
        protected abstract void handle_result(HondaCarManualParametersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "arStatus", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorCarStatus;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "avigationManual", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorNavigationManual;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ehicleManual", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorVehicleManual;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorVehicleManual = new HondaCarManualVehicleManualJSON.HoldingGenerator("field \"VehicleManual\" of the HondaCarManualParameters class", ignore_extras);
            fieldGeneratorNavigationManual = new HondaCarManualNavigationManualJSON.HoldingGenerator("field \"NavigationManual\" of the HondaCarManualParameters class", ignore_extras);
            fieldGeneratorCarStatus = new CarStatusJSON.HoldingGenerator("field \"CarStatus\" of the HondaCarManualParameters class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HondaCarManualParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorVehicleManual = new HondaCarManualVehicleManualJSON.HoldingGenerator("field \"VehicleManual\" of the HondaCarManualParameters class", false);
            fieldGeneratorNavigationManual = new HondaCarManualNavigationManualJSON.HoldingGenerator("field \"NavigationManual\" of the HondaCarManualParameters class", false);
            fieldGeneratorCarStatus = new CarStatusJSON.HoldingGenerator("field \"CarStatus\" of the HondaCarManualParameters class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HondaCarManualParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorVehicleManual.reset();
            fieldGeneratorNavigationManual.reset();
            fieldGeneratorCarStatus.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorVehicleManual.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNavigationManual.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCarStatus.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorVehicleManual.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNavigationManual.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCarStatus.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HondaCarManualParametersJSON  result)
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
        public HondaCarManualParametersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HondaCarManualParametersJSON  result)
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
    protected virtual void handle_result(List<HondaCarManualParametersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HondaCarManualParametersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HondaCarManualParametersJSON>();
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
    public List<HondaCarManualParametersJSON> value;
  };
  };
