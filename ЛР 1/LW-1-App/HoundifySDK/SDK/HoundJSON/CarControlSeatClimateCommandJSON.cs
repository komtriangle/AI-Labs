/* file "CarControlSeatClimateCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlSeatClimateCommandJSON : CarControlCommandJSON
  {
    private bool flagHasActions;
    private List< CarControlActionJSON  > storeActions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraActionsToJSON()
      {
        JSONArrayValue generated_array_1_Actions = new JSONArrayValue();
        for (int num1 = 0; num1 < storeActions.Count; ++num1)
          {
            JSONValueHandler handler_Actions = new JSONValueHandler();
            storeActions[num1].write_as_json(handler_Actions);
            generated_array_1_Actions.appendComponent(handler_Actions.result);
          }
        return generated_array_1_Actions;
      }


    private void  fromJSONActions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Actions of CarControlSeatClimateCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Actions of CarControlSeatClimateCommandJSON has too few elements.");
        List< CarControlActionJSON  > vector_Actions1 = new List< CarControlActionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CarControlActionJSON convert_classy = CarControlActionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Actions1.Add(convert_classy);
          }
        Debug.Assert(vector_Actions1.Count >= 1);
        initActions();
        for (int num1 = 0; num1 < vector_Actions1.Count; ++num1)
            appendActions(vector_Actions1[num1]);
        for (int num1 = 0; num1 < vector_Actions1.Count; ++num1)
          {
          }
      }


    public CarControlSeatClimateCommandJSON()
      {
        flagHasActions = false;
        storeActions = new List< CarControlActionJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCarControlCommandKind()
      {
        return "CarControlSeatClimateCommand";
      }

    public bool  hasActions()
      {
        return flagHasActions;
      }

    public int  countOfActions()
      {
        Debug.Assert(flagHasActions);
        return storeActions.Count;
      }

    public CarControlActionJSON   elementOfActions(int element_num)
      {
        Debug.Assert(flagHasActions);
        return storeActions[element_num];
      }

    public List< CarControlActionJSON  >  getActions()
      {
        Debug.Assert(flagHasActions);
        return storeActions;
      }


    public virtual int extraCarControlSeatClimateCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlSeatClimateCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlSeatClimateCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlSeatClimateCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCarControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasActions)
            ++result;
        result += extraCarControlSeatClimateCommandComponentCount();
        return result;
      }
    public override string extraCarControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasActions)
          {
            if (remainder == 0)
                return "Actions";
            --remainder;
          }
        return extraCarControlSeatClimateCommandComponentKey(remainder);
      }
    public override JSONValue extraCarControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasActions)
          {
            if (remainder == 0)
                return extraActionsToJSON();
            --remainder;
          }
        return extraCarControlSeatClimateCommandComponentValue(remainder);
      }
    public override JSONValue extraCarControlCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Actions", 0, 7, false) == 0) && (field_name.Length == 7))
            return (flagHasActions ? extraActionsToJSON() : null);
        return extraCarControlSeatClimateCommandLookup(field_name);
      }

    public void initActions()
      {
        if (flagHasActions)
          {
            for (int num1 = 0; num1 < storeActions.Count; ++num1)
              {
              }
          }
        flagHasActions = true;
        storeActions.Clear();
      }
    public void appendActions(CarControlActionJSON  to_append)
      {
        if (!flagHasActions)
          {
            flagHasActions = true;
            storeActions.Clear();
          }
        Debug.Assert(flagHasActions);
        storeActions.Add(to_append);
      }
    public void unsetActions()
      {
        if (flagHasActions)
          {
            for (int num2 = 0; num2 < storeActions.Count; ++num2)
              {
              }
          }
        flagHasActions = false;
        storeActions.Clear();
      }

    public virtual void extraCarControlSeatClimateCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlSeatClimateCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlSeatClimateCommandLookup(key);
        if (old_field == null)
          {
            extraCarControlSeatClimateCommandAppendPair(key, new_component);
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
    public override void extraCarControlCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Actions", 0, 7, false) == 0) && (key.Length == 7))
            {
            fromJSONActions(new_component, false);
            return;
            }
        extraCarControlSeatClimateCommandAppendPair(key, new_component);
      }
    public override void extraCarControlCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Actions", 0, 7, false) == 0) && (key.Length == 7))
            {
            fromJSONActions(new_component, false);
            return;
            }
        extraCarControlSeatClimateCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasActions);
        if (flagHasActions)
          {
            handler.start_pair("Actions");
            Debug.Assert(storeActions.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeActions.Count; ++num1)
              {
                if (partial_allowed)
                    storeActions[num1].write_partial_as_json(handler);
                else
                    storeActions[num1].write_as_json(handler);
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
        if (!(hasActions()))
          {
            return "When parsing the object for %what%, the \"Actions\" field was missing.";
          }
        return null;
      }

    public static new CarControlSeatClimateCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlSeatClimateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlSeatClimateCommand", ignore_extras);
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
    public static new CarControlSeatClimateCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlSeatClimateCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlSeatClimateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlSeatClimateCommand", ignore_extras);
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
    public static new CarControlSeatClimateCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlSeatClimateCommandJSON from_text(string text, bool ignore_extras)
      {
        CarControlSeatClimateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlSeatClimateCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlSeatClimateCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CarControlSeatClimateCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlSeatClimateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlSeatClimateCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CarControlCommandJSON.Generator
      {
        private CarControlActionJSON.HoldingArrayGenerator fieldGeneratorActions;
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
            if (!(getCarControlCommandJSONKey().Equals("CarControlSeatClimateCommand")))
                throw new Exception("The key field has a value other than `CarControlSeatClimateCommand'.");
            CarControlSeatClimateCommandJSON result = new CarControlSeatClimateCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlSeatClimateCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CarControlCommandJSON new_result)
          {
            handle_result((CarControlSeatClimateCommandJSON )new_result);
          }
        protected void finish(CarControlSeatClimateCommandJSON result)
          {
            if (fieldGeneratorActions.have_value)
              {
                result.initActions();
                int count = fieldGeneratorActions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendActions(fieldGeneratorActions.value[num]);
                  }
                fieldGeneratorActions.value.Clear();
                fieldGeneratorActions.have_value = false;
              }
            else if ((!(result.hasActions())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Actions\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CarControlSeatClimateCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Actions", 0, 7, false) == 0) && (field_name.Length == 7))
                return fieldGeneratorActions;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorActions = new CarControlActionJSON.HoldingArrayGenerator("field \"Actions\" of the CarControlSeatClimateCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlSeatClimateCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorActions = new CarControlActionJSON.HoldingArrayGenerator("field \"Actions\" of the CarControlSeatClimateCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlSeatClimateCommand class");
          }

        public override void reset()
          {
            fieldGeneratorActions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlSeatClimateCommandJSON  result)
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
        public CarControlSeatClimateCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlSeatClimateCommandJSON  result)
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
    protected virtual void handle_result(List<CarControlSeatClimateCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlSeatClimateCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlSeatClimateCommandJSON>();
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
    public List<CarControlSeatClimateCommandJSON> value;
  };
  };
