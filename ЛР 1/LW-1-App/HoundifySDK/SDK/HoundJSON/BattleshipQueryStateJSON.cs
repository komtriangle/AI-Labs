/* file "BattleshipQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BattleshipQueryStateJSON : JSONBase
  {
    public enum TypeBattleshipCommandKind
      {
        BattleshipCommandKind_BattleshipPlayCommand,
        BattleshipCommandKind_BattleshipInvalidCoordinatesCommand,
        BattleshipCommandKind_BattleshipNotUnderstoodCommand,
        BattleshipCommandKind_BattleshipDictateCoordinatesCommand
      };

    public static TypeBattleshipCommandKind  stringToBattleshipCommandKind(string chars)
      {
        if (String.Compare(chars, 0, "Battleship", 0, 10, false) == 0)
          {
            switch (chars[10])
              {
                case 'D':
                    if ((String.Compare(chars, 11, "ictateCoordinatesCommand", 0, 24, false) == 0) && (chars.Length == 35))
                        return TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipDictateCoordinatesCommand;
                    break;
                case 'I':
                    if ((String.Compare(chars, 11, "nvalidCoordinatesCommand", 0, 24, false) == 0) && (chars.Length == 35))
                        return TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipInvalidCoordinatesCommand;
                    break;
                case 'N':
                    if ((String.Compare(chars, 11, "otUnderstoodCommand", 0, 19, false) == 0) && (chars.Length == 30))
                        return TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipNotUnderstoodCommand;
                    break;
                case 'P':
                    if ((String.Compare(chars, 11, "layCommand", 0, 10, false) == 0) && (chars.Length == 21))
                        return TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipPlayCommand;
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field `BattleshipCommandKind' is not one of the legal values.");
      }

    public static string  stringFromBattleshipCommandKind(TypeBattleshipCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipPlayCommand:
                return "BattleshipPlayCommand";
            case TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipInvalidCoordinatesCommand:
                return "BattleshipInvalidCoordinatesCommand";
            case TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipNotUnderstoodCommand:
                return "BattleshipNotUnderstoodCommand";
            case TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipDictateCoordinatesCommand:
                return "BattleshipDictateCoordinatesCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasUserCoordinates;
    private List< BattleshipCoordinateJSON  > storeUserCoordinates;
    private bool flagHasComputerCoordinates;
    private List< BattleshipCoordinateJSON  > storeComputerCoordinates;
    private bool flagHasStartDatetime;
    private DateAndOrTimeJSON  storeStartDatetime;
    private bool flagHasBattleshipCommandKind;
    private TypeBattleshipCommandKind storeBattleshipCommandKind;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUserCoordinates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field UserCoordinates of BattleshipQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BattleshipCoordinateJSON  > vector_UserCoordinates1 = new List< BattleshipCoordinateJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BattleshipCoordinateJSON convert_classy = BattleshipCoordinateJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_UserCoordinates1.Add(convert_classy);
          }
        initUserCoordinates();
        for (int num1 = 0; num1 < vector_UserCoordinates1.Count; ++num1)
            appendUserCoordinates(vector_UserCoordinates1[num1]);
        for (int num1 = 0; num1 < vector_UserCoordinates1.Count; ++num1)
          {
          }
      }


    private void  fromJSONComputerCoordinates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ComputerCoordinates of BattleshipQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BattleshipCoordinateJSON  > vector_ComputerCoordinates1 = new List< BattleshipCoordinateJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BattleshipCoordinateJSON convert_classy = BattleshipCoordinateJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ComputerCoordinates1.Add(convert_classy);
          }
        initComputerCoordinates();
        for (int num2 = 0; num2 < vector_ComputerCoordinates1.Count; ++num2)
            appendComputerCoordinates(vector_ComputerCoordinates1[num2]);
        for (int num1 = 0; num1 < vector_ComputerCoordinates1.Count; ++num1)
          {
          }
      }


    private void  fromJSONStartDatetime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartDatetime(convert_classy);
      }


    private void  fromJSONBattleshipCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BattleshipCommandKind of BattleshipQueryStateJSON is not a string.");
        TypeBattleshipCommandKind the_enum;
        if (String.Compare(json_string.getData(), 0, "Battleship", 0, 10, false) == 0)
          {
            switch (json_string.getData()[10])
              {
                case 'D':
                    if ((String.Compare(json_string.getData(), 11, "ictateCoordinatesCommand", 0, 24, false) == 0) && (json_string.getData().Length == 35))
                          {
                            the_enum = TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipDictateCoordinatesCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'I':
                    if ((String.Compare(json_string.getData(), 11, "nvalidCoordinatesCommand", 0, 24, false) == 0) && (json_string.getData().Length == 35))
                          {
                            the_enum = TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipInvalidCoordinatesCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'N':
                    if ((String.Compare(json_string.getData(), 11, "otUnderstoodCommand", 0, 19, false) == 0) && (json_string.getData().Length == 30))
                          {
                            the_enum = TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipNotUnderstoodCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'P':
                    if ((String.Compare(json_string.getData(), 11, "layCommand", 0, 10, false) == 0) && (json_string.getData().Length == 21))
                          {
                            the_enum = TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipPlayCommand;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field BattleshipCommandKind of BattleshipQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setBattleshipCommandKind(the_enum);
      }


    public BattleshipQueryStateJSON()
      {
        flagHasUserCoordinates = false;
        flagHasComputerCoordinates = false;
        flagHasStartDatetime = false;
        flagHasBattleshipCommandKind = false;
        storeUserCoordinates = new List< BattleshipCoordinateJSON  >();
        storeComputerCoordinates = new List< BattleshipCoordinateJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUserCoordinates()
      {
        return flagHasUserCoordinates;
      }

    public int  countOfUserCoordinates()
      {
        Debug.Assert(flagHasUserCoordinates);
        return storeUserCoordinates.Count;
      }

    public BattleshipCoordinateJSON   elementOfUserCoordinates(int element_num)
      {
        Debug.Assert(flagHasUserCoordinates);
        return storeUserCoordinates[element_num];
      }

    public List< BattleshipCoordinateJSON  >  getUserCoordinates()
      {
        Debug.Assert(flagHasUserCoordinates);
        return storeUserCoordinates;
      }

    public bool  hasComputerCoordinates()
      {
        return flagHasComputerCoordinates;
      }

    public int  countOfComputerCoordinates()
      {
        Debug.Assert(flagHasComputerCoordinates);
        return storeComputerCoordinates.Count;
      }

    public BattleshipCoordinateJSON   elementOfComputerCoordinates(int element_num)
      {
        Debug.Assert(flagHasComputerCoordinates);
        return storeComputerCoordinates[element_num];
      }

    public List< BattleshipCoordinateJSON  >  getComputerCoordinates()
      {
        Debug.Assert(flagHasComputerCoordinates);
        return storeComputerCoordinates;
      }

    public bool  hasStartDatetime()
      {
        return flagHasStartDatetime;
      }

    public DateAndOrTimeJSON   getStartDatetime()
      {
        Debug.Assert(flagHasStartDatetime);
        return storeStartDatetime;
      }

    public bool  hasBattleshipCommandKind()
      {
        return flagHasBattleshipCommandKind;
      }

    public TypeBattleshipCommandKind  getBattleshipCommandKind()
      {
        Debug.Assert(flagHasBattleshipCommandKind);
        return storeBattleshipCommandKind;
      }

    public string  getBattleshipCommandKindAsString()
      {
        return stringFromBattleshipCommandKind(getBattleshipCommandKind());
      }


    public virtual int extraBattleshipQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBattleshipQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBattleshipQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBattleshipQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initUserCoordinates()
      {
        if (flagHasUserCoordinates)
          {
            for (int num1 = 0; num1 < storeUserCoordinates.Count; ++num1)
              {
              }
          }
        flagHasUserCoordinates = true;
        storeUserCoordinates.Clear();
      }
    public void appendUserCoordinates(BattleshipCoordinateJSON  to_append)
      {
        if (!flagHasUserCoordinates)
          {
            flagHasUserCoordinates = true;
            storeUserCoordinates.Clear();
          }
        Debug.Assert(flagHasUserCoordinates);
        storeUserCoordinates.Add(to_append);
      }
    public void unsetUserCoordinates()
      {
        if (flagHasUserCoordinates)
          {
            for (int num2 = 0; num2 < storeUserCoordinates.Count; ++num2)
              {
              }
          }
        flagHasUserCoordinates = false;
        storeUserCoordinates.Clear();
      }
    public void initComputerCoordinates()
      {
        if (flagHasComputerCoordinates)
          {
            for (int num3 = 0; num3 < storeComputerCoordinates.Count; ++num3)
              {
              }
          }
        flagHasComputerCoordinates = true;
        storeComputerCoordinates.Clear();
      }
    public void appendComputerCoordinates(BattleshipCoordinateJSON  to_append)
      {
        if (!flagHasComputerCoordinates)
          {
            flagHasComputerCoordinates = true;
            storeComputerCoordinates.Clear();
          }
        Debug.Assert(flagHasComputerCoordinates);
        storeComputerCoordinates.Add(to_append);
      }
    public void unsetComputerCoordinates()
      {
        if (flagHasComputerCoordinates)
          {
            for (int num4 = 0; num4 < storeComputerCoordinates.Count; ++num4)
              {
              }
          }
        flagHasComputerCoordinates = false;
        storeComputerCoordinates.Clear();
      }
    public void setStartDatetime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartDatetime)
          {
          }
        flagHasStartDatetime = true;
        storeStartDatetime = new_value;
      }
    public void unsetStartDatetime()
      {
        if (flagHasStartDatetime)
          {
          }
        flagHasStartDatetime = false;
      }
    public void setBattleshipCommandKind(TypeBattleshipCommandKind new_value)
      {
        flagHasBattleshipCommandKind = true;
        storeBattleshipCommandKind = new_value;
      }
    public void setBattleshipCommandKind(string chars)
      {
        setBattleshipCommandKind(stringToBattleshipCommandKind(chars));
      }
    public void unsetBattleshipCommandKind()
      {
        flagHasBattleshipCommandKind = false;
      }

    public virtual void extraBattleshipQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBattleshipQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBattleshipQueryStateLookup(key);
        if (old_field == null)
          {
            extraBattleshipQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUserCoordinates);
        if (flagHasUserCoordinates)
          {
            handler.start_pair("UserCoordinates");
            handler.start_array();
            for (int num1 = 0; num1 < storeUserCoordinates.Count; ++num1)
              {
                if (partial_allowed)
                    storeUserCoordinates[num1].write_partial_as_json(handler);
                else
                    storeUserCoordinates[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasComputerCoordinates);
        if (flagHasComputerCoordinates)
          {
            handler.start_pair("ComputerCoordinates");
            handler.start_array();
            for (int num2 = 0; num2 < storeComputerCoordinates.Count; ++num2)
              {
                if (partial_allowed)
                    storeComputerCoordinates[num2].write_partial_as_json(handler);
                else
                    storeComputerCoordinates[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasStartDatetime)
          {
            handler.start_pair("StartDatetime");
            if (partial_allowed)
                storeStartDatetime.write_partial_as_json(handler);
            else
                storeStartDatetime.write_as_json(handler);
          }
        if (flagHasBattleshipCommandKind)
          {
            handler.start_pair("BattleshipCommandKind");
            switch (storeBattleshipCommandKind)
              {
                case TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipPlayCommand:
                    handler.string_value("BattleshipPlayCommand");
                    break;
                case TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipInvalidCoordinatesCommand:
                    handler.string_value("BattleshipInvalidCoordinatesCommand");
                    break;
                case TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipNotUnderstoodCommand:
                    handler.string_value("BattleshipNotUnderstoodCommand");
                    break;
                case TypeBattleshipCommandKind.BattleshipCommandKind_BattleshipDictateCoordinatesCommand:
                    handler.string_value("BattleshipDictateCoordinatesCommand");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasUserCoordinates()))
          {
            return "When parsing the object for %what%, the \"UserCoordinates\" field was missing.";
          }
        if (!(hasComputerCoordinates()))
          {
            return "When parsing the object for %what%, the \"ComputerCoordinates\" field was missing.";
          }
        return null;
      }

    public static BattleshipQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipQueryState", ignore_extras);
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
    public static BattleshipQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BattleshipQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipQueryState", ignore_extras);
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
    public static BattleshipQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BattleshipQueryStateJSON from_text(string text, bool ignore_extras)
      {
        BattleshipQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BattleshipQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BattleshipQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BattleshipQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private BattleshipCoordinateJSON.HoldingArrayGenerator fieldGeneratorUserCoordinates;
        private BattleshipCoordinateJSON.HoldingArrayGenerator fieldGeneratorComputerCoordinates;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDatetime;
    private abstract class FieldGeneratorBattleshipCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorBattleshipCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorBattleshipCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToBattleshipCommandKind(result));
              }
            protected abstract void handle_result(TypeBattleshipCommandKind result);
          };
    private class FieldHoldingGeneratorBattleshipCommandKind : FieldGeneratorBattleshipCommandKind
  {
    protected override void handle_result(TypeBattleshipCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorBattleshipCommandKind(String what)
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
    public TypeBattleshipCommandKind value;
  };
    private class FieldHoldingArrayGeneratorBattleshipCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorBattleshipCommandKind
      {
        private FieldHoldingArrayGeneratorBattleshipCommandKind top;

        protected override void handle_result(TypeBattleshipCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorBattleshipCommandKind init_top)
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
    protected virtual void handle_result(List<TypeBattleshipCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorBattleshipCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBattleshipCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorBattleshipCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBattleshipCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeBattleshipCommandKind> value;
  };
        private FieldHoldingGeneratorBattleshipCommandKind fieldGeneratorBattleshipCommandKind;
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
            BattleshipQueryStateJSON result = new BattleshipQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBattleshipQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BattleshipQueryStateJSON result)
          {
            if (fieldGeneratorUserCoordinates.have_value)
              {
                result.initUserCoordinates();
                int count = fieldGeneratorUserCoordinates.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendUserCoordinates(fieldGeneratorUserCoordinates.value[num]);
                  }
                fieldGeneratorUserCoordinates.value.Clear();
                fieldGeneratorUserCoordinates.have_value = false;
              }
            else if ((!(result.hasUserCoordinates())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UserCoordinates\" field was missing.");
              }
            if (fieldGeneratorComputerCoordinates.have_value)
              {
                result.initComputerCoordinates();
                int count = fieldGeneratorComputerCoordinates.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendComputerCoordinates(fieldGeneratorComputerCoordinates.value[num]);
                  }
                fieldGeneratorComputerCoordinates.value.Clear();
                fieldGeneratorComputerCoordinates.have_value = false;
              }
            else if ((!(result.hasComputerCoordinates())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ComputerCoordinates\" field was missing.");
              }
            if (fieldGeneratorStartDatetime.have_value)
              {
                result.setStartDatetime(fieldGeneratorStartDatetime.value);
                fieldGeneratorStartDatetime.have_value = false;
              }
            if (fieldGeneratorBattleshipCommandKind.have_value)
              {
                result.setBattleshipCommandKind(fieldGeneratorBattleshipCommandKind.value);
                fieldGeneratorBattleshipCommandKind.have_value = false;
              }
          }
        protected abstract void handle_result(BattleshipQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "attleshipCommandKind", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorBattleshipCommandKind;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "omputerCoordinates", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorComputerCoordinates;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartDatetime", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorStartDatetime;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serCoordinates", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorUserCoordinates;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorUserCoordinates = new BattleshipCoordinateJSON.HoldingArrayGenerator("field \"UserCoordinates\" of the BattleshipQueryState class", ignore_extras);
            fieldGeneratorComputerCoordinates = new BattleshipCoordinateJSON.HoldingArrayGenerator("field \"ComputerCoordinates\" of the BattleshipQueryState class", ignore_extras);
            fieldGeneratorStartDatetime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDatetime\" of the BattleshipQueryState class", ignore_extras);
            fieldGeneratorBattleshipCommandKind = new FieldHoldingGeneratorBattleshipCommandKind("field \"BattleshipCommandKind\" of the BattleshipQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BattleshipQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUserCoordinates = new BattleshipCoordinateJSON.HoldingArrayGenerator("field \"UserCoordinates\" of the BattleshipQueryState class", false);
            fieldGeneratorComputerCoordinates = new BattleshipCoordinateJSON.HoldingArrayGenerator("field \"ComputerCoordinates\" of the BattleshipQueryState class", false);
            fieldGeneratorStartDatetime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDatetime\" of the BattleshipQueryState class", false);
            fieldGeneratorBattleshipCommandKind = new FieldHoldingGeneratorBattleshipCommandKind("field \"BattleshipCommandKind\" of the BattleshipQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BattleshipQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUserCoordinates.reset();
            fieldGeneratorComputerCoordinates.reset();
            fieldGeneratorStartDatetime.reset();
            fieldGeneratorBattleshipCommandKind.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorUserCoordinates.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorComputerCoordinates.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStartDatetime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorUserCoordinates.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorComputerCoordinates.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStartDatetime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BattleshipQueryStateJSON  result)
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
        public BattleshipQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BattleshipQueryStateJSON  result)
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
    protected virtual void handle_result(List<BattleshipQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BattleshipQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BattleshipQueryStateJSON>();
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
    public List<BattleshipQueryStateJSON> value;
  };
  };
