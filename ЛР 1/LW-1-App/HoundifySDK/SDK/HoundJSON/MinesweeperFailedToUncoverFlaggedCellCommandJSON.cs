/* file "MinesweeperFailedToUncoverFlaggedCellCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MinesweeperFailedToUncoverFlaggedCellCommandJSON : CommandResultJSON
  {
    private bool flagHasState;
    private MinesweeperStateJSON  storeState;
    private bool flagHasCoordinate;
    private MinesweeperCoordinateJSON  storeCoordinate;
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


    public MinesweeperFailedToUncoverFlaggedCellCommandJSON()
      {
        flagHasState = false;
        flagHasCoordinate = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "MinesweeperFailedToUncoverFlaggedCellCommand";
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


    public virtual int extraMinesweeperFailedToUncoverFlaggedCellCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMinesweeperFailedToUncoverFlaggedCellCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMinesweeperFailedToUncoverFlaggedCellCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMinesweeperFailedToUncoverFlaggedCellCommandLookup(string field_name)
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
        result += extraMinesweeperFailedToUncoverFlaggedCellCommandComponentCount();
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
        return extraMinesweeperFailedToUncoverFlaggedCellCommandComponentKey(remainder);
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
        return extraMinesweeperFailedToUncoverFlaggedCellCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "oordinate", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasCoordinate ? extraCoordinateToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tate", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasState ? extraStateToJSON() : null);
                break;
            default:
                break;
          }
        return extraMinesweeperFailedToUncoverFlaggedCellCommandLookup(field_name);
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

    public virtual void extraMinesweeperFailedToUncoverFlaggedCellCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMinesweeperFailedToUncoverFlaggedCellCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMinesweeperFailedToUncoverFlaggedCellCommandLookup(key);
        if (old_field == null)
          {
            extraMinesweeperFailedToUncoverFlaggedCellCommandAppendPair(key, new_component);
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
        extraMinesweeperFailedToUncoverFlaggedCellCommandAppendPair(key, new_component);
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
        extraMinesweeperFailedToUncoverFlaggedCellCommandSetField(key, new_component);
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
        return null;
      }

    public static new MinesweeperFailedToUncoverFlaggedCellCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MinesweeperFailedToUncoverFlaggedCellCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperFailedToUncoverFlaggedCellCommand", ignore_extras);
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
    public static new MinesweeperFailedToUncoverFlaggedCellCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MinesweeperFailedToUncoverFlaggedCellCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MinesweeperFailedToUncoverFlaggedCellCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperFailedToUncoverFlaggedCellCommand", ignore_extras);
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
    public static new MinesweeperFailedToUncoverFlaggedCellCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MinesweeperFailedToUncoverFlaggedCellCommandJSON from_text(string text, bool ignore_extras)
      {
        MinesweeperFailedToUncoverFlaggedCellCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperFailedToUncoverFlaggedCellCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MinesweeperFailedToUncoverFlaggedCellCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MinesweeperFailedToUncoverFlaggedCellCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MinesweeperFailedToUncoverFlaggedCellCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperFailedToUncoverFlaggedCellCommand", ignore_extras);
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
            if (!(getCommandResultJSONKey().Equals("MinesweeperFailedToUncoverFlaggedCellCommand")))
                throw new Exception("The key field has a value other than `MinesweeperFailedToUncoverFlaggedCellCommand'.");
            MinesweeperFailedToUncoverFlaggedCellCommandJSON result = new MinesweeperFailedToUncoverFlaggedCellCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMinesweeperFailedToUncoverFlaggedCellCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((MinesweeperFailedToUncoverFlaggedCellCommandJSON )new_result);
          }
        protected void finish(MinesweeperFailedToUncoverFlaggedCellCommandJSON result)
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
            base.finish(result);
          }
        protected abstract void handle_result(MinesweeperFailedToUncoverFlaggedCellCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "oordinate", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorCoordinate;
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
            fieldGeneratorState = new MinesweeperStateJSON.HoldingGenerator("field \"State\" of the MinesweeperFailedToUncoverFlaggedCellCommand class", ignore_extras);
            fieldGeneratorCoordinate = new MinesweeperCoordinateJSON.HoldingGenerator("field \"Coordinate\" of the MinesweeperFailedToUncoverFlaggedCellCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MinesweeperFailedToUncoverFlaggedCellCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorState = new MinesweeperStateJSON.HoldingGenerator("field \"State\" of the MinesweeperFailedToUncoverFlaggedCellCommand class", false);
            fieldGeneratorCoordinate = new MinesweeperCoordinateJSON.HoldingGenerator("field \"Coordinate\" of the MinesweeperFailedToUncoverFlaggedCellCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MinesweeperFailedToUncoverFlaggedCellCommand class");
          }

        public override void reset()
          {
            fieldGeneratorState.reset();
            fieldGeneratorCoordinate.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MinesweeperFailedToUncoverFlaggedCellCommandJSON  result)
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
        public MinesweeperFailedToUncoverFlaggedCellCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MinesweeperFailedToUncoverFlaggedCellCommandJSON  result)
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
    protected virtual void handle_result(List<MinesweeperFailedToUncoverFlaggedCellCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MinesweeperFailedToUncoverFlaggedCellCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MinesweeperFailedToUncoverFlaggedCellCommandJSON>();
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
    public List<MinesweeperFailedToUncoverFlaggedCellCommandJSON> value;
  };
  };
