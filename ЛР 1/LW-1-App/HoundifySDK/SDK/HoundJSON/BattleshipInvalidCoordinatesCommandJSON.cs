/* file "BattleshipInvalidCoordinatesCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BattleshipInvalidCoordinatesCommandJSON : BattleshipCommandJSON
  {
    private bool flagHasUserData;
    private BattleshipPlayerDataJSON  storeUserData;
    private bool flagHasComputerData;
    private BattleshipPlayerDataJSON  storeComputerData;
    private bool flagHasStartDateAndOrTime;
    private DateAndOrTimeJSON  storeStartDateAndOrTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUserDataToJSON()
      {
        JSONValueHandler handler_UserData = new JSONValueHandler();
        storeUserData.write_as_json(handler_UserData);
        return handler_UserData.result;
      }

    private JSONValue  extraComputerDataToJSON()
      {
        JSONValueHandler handler_ComputerData = new JSONValueHandler();
        storeComputerData.write_as_json(handler_ComputerData);
        return handler_ComputerData.result;
      }

    private JSONValue  extraStartDateAndOrTimeToJSON()
      {
        JSONValueHandler handler_StartDateAndOrTime = new JSONValueHandler();
        storeStartDateAndOrTime.write_as_json(handler_StartDateAndOrTime);
        return handler_StartDateAndOrTime.result;
      }


    private void  fromJSONUserData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BattleshipPlayerDataJSON convert_classy = BattleshipPlayerDataJSON.from_json(json_value, ignore_extras, true);
        setUserData(convert_classy);
      }


    private void  fromJSONComputerData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BattleshipPlayerDataJSON convert_classy = BattleshipPlayerDataJSON.from_json(json_value, ignore_extras, true);
        setComputerData(convert_classy);
      }


    private void  fromJSONStartDateAndOrTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartDateAndOrTime(convert_classy);
      }


    public BattleshipInvalidCoordinatesCommandJSON()
      {
        flagHasUserData = false;
        flagHasComputerData = false;
        flagHasStartDateAndOrTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getBattleshipCommandKind()
      {
        return "BattleshipInvalidCoordinatesCommand";
      }

    public bool  hasUserData()
      {
        return flagHasUserData;
      }

    public BattleshipPlayerDataJSON   getUserData()
      {
        Debug.Assert(flagHasUserData);
        return storeUserData;
      }

    public bool  hasComputerData()
      {
        return flagHasComputerData;
      }

    public BattleshipPlayerDataJSON   getComputerData()
      {
        Debug.Assert(flagHasComputerData);
        return storeComputerData;
      }

    public bool  hasStartDateAndOrTime()
      {
        return flagHasStartDateAndOrTime;
      }

    public DateAndOrTimeJSON   getStartDateAndOrTime()
      {
        Debug.Assert(flagHasStartDateAndOrTime);
        return storeStartDateAndOrTime;
      }


    public virtual int extraBattleshipInvalidCoordinatesCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBattleshipInvalidCoordinatesCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBattleshipInvalidCoordinatesCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBattleshipInvalidCoordinatesCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraBattleshipCommandComponentCount()
      {
        int result = 0;
        if (flagHasUserData)
            ++result;
        if (flagHasComputerData)
            ++result;
        if (flagHasStartDateAndOrTime)
            ++result;
        result += extraBattleshipInvalidCoordinatesCommandComponentCount();
        return result;
      }
    public override string extraBattleshipCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserData)
          {
            if (remainder == 0)
                return "UserData";
            --remainder;
          }
        if (flagHasComputerData)
          {
            if (remainder == 0)
                return "ComputerData";
            --remainder;
          }
        if (flagHasStartDateAndOrTime)
          {
            if (remainder == 0)
                return "StartDateAndOrTime";
            --remainder;
          }
        return extraBattleshipInvalidCoordinatesCommandComponentKey(remainder);
      }
    public override JSONValue extraBattleshipCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserData)
          {
            if (remainder == 0)
                return extraUserDataToJSON();
            --remainder;
          }
        if (flagHasComputerData)
          {
            if (remainder == 0)
                return extraComputerDataToJSON();
            --remainder;
          }
        if (flagHasStartDateAndOrTime)
          {
            if (remainder == 0)
                return extraStartDateAndOrTimeToJSON();
            --remainder;
          }
        return extraBattleshipInvalidCoordinatesCommandComponentValue(remainder);
      }
    public override JSONValue extraBattleshipCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "omputerData", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasComputerData ? extraComputerDataToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tartDateAndOrTime", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasStartDateAndOrTime ? extraStartDateAndOrTimeToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serData", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasUserData ? extraUserDataToJSON() : null);
                break;
            default:
                break;
          }
        return extraBattleshipInvalidCoordinatesCommandLookup(field_name);
      }

    public void setUserData(BattleshipPlayerDataJSON  new_value)
      {
        if (flagHasUserData)
          {
          }
        flagHasUserData = true;
        storeUserData = new_value;
      }
    public void unsetUserData()
      {
        if (flagHasUserData)
          {
          }
        flagHasUserData = false;
      }
    public void setComputerData(BattleshipPlayerDataJSON  new_value)
      {
        if (flagHasComputerData)
          {
          }
        flagHasComputerData = true;
        storeComputerData = new_value;
      }
    public void unsetComputerData()
      {
        if (flagHasComputerData)
          {
          }
        flagHasComputerData = false;
      }
    public void setStartDateAndOrTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartDateAndOrTime)
          {
          }
        flagHasStartDateAndOrTime = true;
        storeStartDateAndOrTime = new_value;
      }
    public void unsetStartDateAndOrTime()
      {
        if (flagHasStartDateAndOrTime)
          {
          }
        flagHasStartDateAndOrTime = false;
      }

    public virtual void extraBattleshipInvalidCoordinatesCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBattleshipInvalidCoordinatesCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBattleshipInvalidCoordinatesCommandLookup(key);
        if (old_field == null)
          {
            extraBattleshipInvalidCoordinatesCommandAppendPair(key, new_component);
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
    public override void extraBattleshipCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "omputerData", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONComputerData(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartDateAndOrTime", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONStartDateAndOrTime(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serData", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONUserData(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBattleshipInvalidCoordinatesCommandAppendPair(key, new_component);
      }
    public override void extraBattleshipCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "omputerData", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONComputerData(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartDateAndOrTime", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONStartDateAndOrTime(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serData", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONUserData(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBattleshipInvalidCoordinatesCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUserData);
        if (flagHasUserData)
          {
            handler.start_pair("UserData");
            if (partial_allowed)
                storeUserData.write_partial_as_json(handler);
            else
                storeUserData.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasComputerData);
        if (flagHasComputerData)
          {
            handler.start_pair("ComputerData");
            if (partial_allowed)
                storeComputerData.write_partial_as_json(handler);
            else
                storeComputerData.write_as_json(handler);
          }
        if (flagHasStartDateAndOrTime)
          {
            handler.start_pair("StartDateAndOrTime");
            if (partial_allowed)
                storeStartDateAndOrTime.write_partial_as_json(handler);
            else
                storeStartDateAndOrTime.write_as_json(handler);
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
        if (!(hasUserData()))
          {
            return "When parsing the object for %what%, the \"UserData\" field was missing.";
          }
        if (!(hasComputerData()))
          {
            return "When parsing the object for %what%, the \"ComputerData\" field was missing.";
          }
        return null;
      }

    public static new BattleshipInvalidCoordinatesCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipInvalidCoordinatesCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipInvalidCoordinatesCommand", ignore_extras);
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
    public static new BattleshipInvalidCoordinatesCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BattleshipInvalidCoordinatesCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipInvalidCoordinatesCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipInvalidCoordinatesCommand", ignore_extras);
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
    public static new BattleshipInvalidCoordinatesCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BattleshipInvalidCoordinatesCommandJSON from_text(string text, bool ignore_extras)
      {
        BattleshipInvalidCoordinatesCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipInvalidCoordinatesCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BattleshipInvalidCoordinatesCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new BattleshipInvalidCoordinatesCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BattleshipInvalidCoordinatesCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipInvalidCoordinatesCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : BattleshipCommandJSON.Generator
      {
        private BattleshipPlayerDataJSON.HoldingGenerator fieldGeneratorUserData;
        private BattleshipPlayerDataJSON.HoldingGenerator fieldGeneratorComputerData;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDateAndOrTime;
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
            if (!(getBattleshipCommandJSONKey().Equals("BattleshipInvalidCoordinatesCommand")))
                throw new Exception("The key field has a value other than `BattleshipInvalidCoordinatesCommand'.");
            BattleshipInvalidCoordinatesCommandJSON result = new BattleshipInvalidCoordinatesCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBattleshipInvalidCoordinatesCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(BattleshipCommandJSON new_result)
          {
            handle_result((BattleshipInvalidCoordinatesCommandJSON )new_result);
          }
        protected void finish(BattleshipInvalidCoordinatesCommandJSON result)
          {
            if (fieldGeneratorUserData.have_value)
              {
                result.setUserData(fieldGeneratorUserData.value);
                fieldGeneratorUserData.have_value = false;
              }
            else if ((!(result.hasUserData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UserData\" field was missing.");
              }
            if (fieldGeneratorComputerData.have_value)
              {
                result.setComputerData(fieldGeneratorComputerData.value);
                fieldGeneratorComputerData.have_value = false;
              }
            else if ((!(result.hasComputerData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ComputerData\" field was missing.");
              }
            if (fieldGeneratorStartDateAndOrTime.have_value)
              {
                result.setStartDateAndOrTime(fieldGeneratorStartDateAndOrTime.value);
                fieldGeneratorStartDateAndOrTime.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(BattleshipInvalidCoordinatesCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "omputerData", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorComputerData;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartDateAndOrTime", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorStartDateAndOrTime;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serData", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorUserData;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUserData = new BattleshipPlayerDataJSON.HoldingGenerator("field \"UserData\" of the BattleshipInvalidCoordinatesCommand class", ignore_extras);
            fieldGeneratorComputerData = new BattleshipPlayerDataJSON.HoldingGenerator("field \"ComputerData\" of the BattleshipInvalidCoordinatesCommand class", ignore_extras);
            fieldGeneratorStartDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndOrTime\" of the BattleshipInvalidCoordinatesCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BattleshipInvalidCoordinatesCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUserData = new BattleshipPlayerDataJSON.HoldingGenerator("field \"UserData\" of the BattleshipInvalidCoordinatesCommand class", false);
            fieldGeneratorComputerData = new BattleshipPlayerDataJSON.HoldingGenerator("field \"ComputerData\" of the BattleshipInvalidCoordinatesCommand class", false);
            fieldGeneratorStartDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndOrTime\" of the BattleshipInvalidCoordinatesCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BattleshipInvalidCoordinatesCommand class");
          }

        public override void reset()
          {
            fieldGeneratorUserData.reset();
            fieldGeneratorComputerData.reset();
            fieldGeneratorStartDateAndOrTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(BattleshipInvalidCoordinatesCommandJSON  result)
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
        public BattleshipInvalidCoordinatesCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BattleshipInvalidCoordinatesCommandJSON  result)
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
    protected virtual void handle_result(List<BattleshipInvalidCoordinatesCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BattleshipInvalidCoordinatesCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BattleshipInvalidCoordinatesCommandJSON>();
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
    public List<BattleshipInvalidCoordinatesCommandJSON> value;
  };
  };
