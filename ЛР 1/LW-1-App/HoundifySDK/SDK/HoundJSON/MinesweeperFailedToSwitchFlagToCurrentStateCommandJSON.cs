/* file "MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON : CommandResultJSON
  {
    private bool flagHasState;
    private MinesweeperStateJSON  storeState;
    private bool flagHasCoordinate;
    private MinesweeperCoordinateJSON  storeCoordinate;
    private bool flagHasIsFlagging;
    private bool storeIsFlagging;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraStateToJSON()
      {
        JSONValueHandler handler_State = new JSONValueHandler();
        storeState.write_as_json(handler_State);
        return handler_State.result;
      }

    private JSONValue  extraCoordinateToJSON()
      {
        JSONValueHandler handler_Coordinate = new JSONValueHandler();
        storeCoordinate.write_as_json(handler_Coordinate);
        return handler_Coordinate.result;
      }

    private JSONValue  extraIsFlaggingToJSON()
      {
        JSONValue generated_boolean_IsFlagging = (storeIsFlagging ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsFlagging;
      }


    private void  fromJSONState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MinesweeperStateJSON convert_classy = MinesweeperStateJSON.from_json(json_value, ignore_extras, true);
        setState(convert_classy);
      }


    private void  fromJSONCoordinate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MinesweeperCoordinateJSON convert_classy = MinesweeperCoordinateJSON.from_json(json_value, ignore_extras, true);
        setCoordinate(convert_classy);
      }


    private void  fromJSONIsFlagging(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IsFlagging of MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON is not true for false.");
              }
          }
        setIsFlagging(the_bool);
      }


    public MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON()
      {
        flagHasState = false;
        flagHasCoordinate = false;
        flagHasIsFlagging = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "MinesweeperFailedToSwitchFlagToCurrentStateCommand";
      }

    public bool  hasState()
      {
        return flagHasState;
      }

    public MinesweeperStateJSON   getState()
      {
        Debug.Assert(flagHasState);
        return storeState;
      }

    public bool  hasCoordinate()
      {
        return flagHasCoordinate;
      }

    public MinesweeperCoordinateJSON   getCoordinate()
      {
        Debug.Assert(flagHasCoordinate);
        return storeCoordinate;
      }

    public bool  hasIsFlagging()
      {
        return flagHasIsFlagging;
      }

    public bool  getIsFlagging()
      {
        Debug.Assert(flagHasIsFlagging);
        return storeIsFlagging;
      }


    public virtual int extraMinesweeperFailedToSwitchFlagToCurrentStateCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMinesweeperFailedToSwitchFlagToCurrentStateCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMinesweeperFailedToSwitchFlagToCurrentStateCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMinesweeperFailedToSwitchFlagToCurrentStateCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasState)
            ++result;
        if (flagHasCoordinate)
            ++result;
        if (flagHasIsFlagging)
            ++result;
        result += extraMinesweeperFailedToSwitchFlagToCurrentStateCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasState)
          {
            if (remainder == 0)
                return "State";
            --remainder;
          }
        if (flagHasCoordinate)
          {
            if (remainder == 0)
                return "Coordinate";
            --remainder;
          }
        if (flagHasIsFlagging)
          {
            if (remainder == 0)
                return "IsFlagging";
            --remainder;
          }
        return extraMinesweeperFailedToSwitchFlagToCurrentStateCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasState)
          {
            if (remainder == 0)
                return extraStateToJSON();
            --remainder;
          }
        if (flagHasCoordinate)
          {
            if (remainder == 0)
                return extraCoordinateToJSON();
            --remainder;
          }
        if (flagHasIsFlagging)
          {
            if (remainder == 0)
                return extraIsFlaggingToJSON();
            --remainder;
          }
        return extraMinesweeperFailedToSwitchFlagToCurrentStateCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "oordinate", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasCoordinate ? extraCoordinateToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "sFlagging", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasIsFlagging ? extraIsFlaggingToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tate", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasState ? extraStateToJSON() : null);
                break;
            default:
                break;
          }
        return extraMinesweeperFailedToSwitchFlagToCurrentStateCommandLookup(field_name);
      }

    public void setState(MinesweeperStateJSON  new_value)
      {
        if (flagHasState)
          {
          }
        flagHasState = true;
        storeState = new_value;
      }
    public void unsetState()
      {
        if (flagHasState)
          {
          }
        flagHasState = false;
      }
    public void setCoordinate(MinesweeperCoordinateJSON  new_value)
      {
        if (flagHasCoordinate)
          {
          }
        flagHasCoordinate = true;
        storeCoordinate = new_value;
      }
    public void unsetCoordinate()
      {
        if (flagHasCoordinate)
          {
          }
        flagHasCoordinate = false;
      }
    public void setIsFlagging(bool new_value)
      {
        flagHasIsFlagging = true;
        storeIsFlagging = new_value;
      }
    public void unsetIsFlagging()
      {
        flagHasIsFlagging = false;
      }

    public virtual void extraMinesweeperFailedToSwitchFlagToCurrentStateCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMinesweeperFailedToSwitchFlagToCurrentStateCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMinesweeperFailedToSwitchFlagToCurrentStateCommandLookup(key);
        if (old_field == null)
          {
            extraMinesweeperFailedToSwitchFlagToCurrentStateCommandAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "oordinate", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONCoordinate(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "sFlagging", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONIsFlagging(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tate", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONState(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMinesweeperFailedToSwitchFlagToCurrentStateCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "oordinate", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONCoordinate(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "sFlagging", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONIsFlagging(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tate", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONState(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMinesweeperFailedToSwitchFlagToCurrentStateCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasState);
        if (flagHasState)
          {
            handler.start_pair("State");
            if (partial_allowed)
                storeState.write_partial_as_json(handler);
            else
                storeState.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasCoordinate);
        if (flagHasCoordinate)
          {
            handler.start_pair("Coordinate");
            if (partial_allowed)
                storeCoordinate.write_partial_as_json(handler);
            else
                storeCoordinate.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasIsFlagging);
        if (flagHasIsFlagging)
          {
            handler.start_pair("IsFlagging");
            handler.boolean_value(storeIsFlagging);
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
        if (!(hasState()))
          {
            return "When parsing the object for %what%, the \"State\" field was missing.";
          }
        if (!(hasCoordinate()))
          {
            return "When parsing the object for %what%, the \"Coordinate\" field was missing.";
          }
        if (!(hasIsFlagging()))
          {
            return "When parsing the object for %what%, the \"IsFlagging\" field was missing.";
          }
        return null;
      }

    public static new MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperFailedToSwitchFlagToCurrentStateCommand", ignore_extras);
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
    public static new MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperFailedToSwitchFlagToCurrentStateCommand", ignore_extras);
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
    public static new MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON from_text(string text, bool ignore_extras)
      {
        MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperFailedToSwitchFlagToCurrentStateCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperFailedToSwitchFlagToCurrentStateCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private MinesweeperStateJSON.HoldingGenerator fieldGeneratorState;
        private MinesweeperCoordinateJSON.HoldingGenerator fieldGeneratorCoordinate;
        private JSONHoldingBooleanGenerator fieldGeneratorIsFlagging;
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
            if (!(getCommandResultJSONKey().Equals("MinesweeperFailedToSwitchFlagToCurrentStateCommand")))
                throw new Exception("The key field has a value other than `MinesweeperFailedToSwitchFlagToCurrentStateCommand'.");
            MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON result = new MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMinesweeperFailedToSwitchFlagToCurrentStateCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON )new_result);
          }
        protected void finish(MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON result)
          {
            if (fieldGeneratorState.have_value)
              {
                result.setState(fieldGeneratorState.value);
                fieldGeneratorState.have_value = false;
              }
            else if ((!(result.hasState())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"State\" field was missing.");
              }
            if (fieldGeneratorCoordinate.have_value)
              {
                result.setCoordinate(fieldGeneratorCoordinate.value);
                fieldGeneratorCoordinate.have_value = false;
              }
            else if ((!(result.hasCoordinate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Coordinate\" field was missing.");
              }
            if (fieldGeneratorIsFlagging.have_value)
              {
                result.setIsFlagging(fieldGeneratorIsFlagging.value);
                fieldGeneratorIsFlagging.have_value = false;
              }
            else if ((!(result.hasIsFlagging())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsFlagging\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "oordinate", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorCoordinate;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sFlagging", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorIsFlagging;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tate", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorState;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorState = new MinesweeperStateJSON.HoldingGenerator("field \"State\" of the MinesweeperFailedToSwitchFlagToCurrentStateCommand class", ignore_extras);
            fieldGeneratorCoordinate = new MinesweeperCoordinateJSON.HoldingGenerator("field \"Coordinate\" of the MinesweeperFailedToSwitchFlagToCurrentStateCommand class", ignore_extras);
            fieldGeneratorIsFlagging = new JSONHoldingBooleanGenerator("field \"IsFlagging\" of the MinesweeperFailedToSwitchFlagToCurrentStateCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MinesweeperFailedToSwitchFlagToCurrentStateCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorState = new MinesweeperStateJSON.HoldingGenerator("field \"State\" of the MinesweeperFailedToSwitchFlagToCurrentStateCommand class", false);
            fieldGeneratorCoordinate = new MinesweeperCoordinateJSON.HoldingGenerator("field \"Coordinate\" of the MinesweeperFailedToSwitchFlagToCurrentStateCommand class", false);
            fieldGeneratorIsFlagging = new JSONHoldingBooleanGenerator("field \"IsFlagging\" of the MinesweeperFailedToSwitchFlagToCurrentStateCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MinesweeperFailedToSwitchFlagToCurrentStateCommand class");
          }

        public override void reset()
          {
            fieldGeneratorState.reset();
            fieldGeneratorCoordinate.reset();
            fieldGeneratorIsFlagging.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON  result)
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
        public MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON  result)
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
    protected virtual void handle_result(List<MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON>();
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
    public List<MinesweeperFailedToSwitchFlagToCurrentStateCommandJSON> value;
  };
  };
