/* file "CarControlMirrorStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlMirrorStateJSON : JSONBase
  {
    public enum TypeCommandKind
      {
        CommandKind_CarControlMirrorCommand
      };

    public static TypeCommandKind  stringToCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "CarControlMirrorCommand", 0, 23, false) == 0) && (chars.Length == 23))
            return TypeCommandKind.CommandKind_CarControlMirrorCommand;
        throw new Exception("The value for field `CommandKind' is not one of the legal values.");
      }

    public static string  stringFromCommandKind(TypeCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandKind.CommandKind_CarControlMirrorCommand:
                return "CarControlMirrorCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeCommandType
      {
        CommandType_RotateUp,
        CommandType_RotateDown,
        CommandType_RotateIn,
        CommandType_RotateOut,
        CommandType_Defrost,
        CommandType_RotateToDefault,
        CommandType_SaveDefaultRotation
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if ((String.Compare(chars, 1, "efrost", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeCommandType.CommandType_Defrost;
                break;
            case 'R':
                if (String.Compare(chars, 1, "otate", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'D':
                            if ((String.Compare(chars, 7, "own", 0, 3, false) == 0) && (chars.Length == 10))
                                return TypeCommandType.CommandType_RotateDown;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 7, "n", 0, 1, false) == 0) && (chars.Length == 8))
                                return TypeCommandType.CommandType_RotateIn;
                            break;
                        case 'O':
                            if ((String.Compare(chars, 7, "ut", 0, 2, false) == 0) && (chars.Length == 9))
                                return TypeCommandType.CommandType_RotateOut;
                            break;
                        case 'T':
                            if ((String.Compare(chars, 7, "oDefault", 0, 8, false) == 0) && (chars.Length == 15))
                                return TypeCommandType.CommandType_RotateToDefault;
                            break;
                        case 'U':
                            if ((String.Compare(chars, 7, "p", 0, 1, false) == 0) && (chars.Length == 8))
                                return TypeCommandType.CommandType_RotateUp;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "aveDefaultRotation", 0, 18, false) == 0) && (chars.Length == 19))
                    return TypeCommandType.CommandType_SaveDefaultRotation;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `CommandType' is not one of the legal values.");
      }

    public static string  stringFromCommandType(TypeCommandType the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandType.CommandType_RotateUp:
                return "RotateUp";
            case TypeCommandType.CommandType_RotateDown:
                return "RotateDown";
            case TypeCommandType.CommandType_RotateIn:
                return "RotateIn";
            case TypeCommandType.CommandType_RotateOut:
                return "RotateOut";
            case TypeCommandType.CommandType_Defrost:
                return "Defrost";
            case TypeCommandType.CommandType_RotateToDefault:
                return "RotateToDefault";
            case TypeCommandType.CommandType_SaveDefaultRotation:
                return "SaveDefaultRotation";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandKind;
    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private bool flagHasMirrorSelection;
    private CarMirrorSelectionEnumJSON  storeMirrorSelection;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandKind of CarControlMirrorStateJSON is not a string.");
        if (!(json_string.getData().Equals("CarControlMirrorCommand")))
            throw new Exception("The value for field CommandKind of CarControlMirrorStateJSON is not `CarControlMirrorCommand'.");
        setCommandKind();
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of CarControlMirrorStateJSON is not a string.");
        TypeCommandType the_enum;
        switch (json_string.getData()[0])
          {
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "efrost", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeCommandType.CommandType_Defrost;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if (String.Compare(json_string.getData(), 1, "otate", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'D':
                            if ((String.Compare(json_string.getData(), 7, "own", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeCommandType.CommandType_RotateDown;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 7, "n", 0, 1, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_enum = TypeCommandType.CommandType_RotateIn;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'O':
                            if ((String.Compare(json_string.getData(), 7, "ut", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeCommandType.CommandType_RotateOut;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'T':
                            if ((String.Compare(json_string.getData(), 7, "oDefault", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypeCommandType.CommandType_RotateToDefault;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'U':
                            if ((String.Compare(json_string.getData(), 7, "p", 0, 1, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_enum = TypeCommandType.CommandType_RotateUp;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "aveDefaultRotation", 0, 18, false) == 0) && (json_string.getData().Length == 19))
                      {
                        the_enum = TypeCommandType.CommandType_SaveDefaultRotation;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field CommandType of CarControlMirrorStateJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    private void  fromJSONMirrorSelection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CarMirrorSelectionEnumJSON convert_classy = CarMirrorSelectionEnumJSON.from_json(json_value, ignore_extras, true);
        setMirrorSelection(convert_classy);
      }


    public CarControlMirrorStateJSON()
      {
        flagHasCommandKind = false;
        flagHasCommandType = false;
        flagHasMirrorSelection = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCommandKind()
      {
        return flagHasCommandKind;
      }

    public TypeCommandKind  getCommandKind()
      {
        Debug.Assert(flagHasCommandKind);
        return TypeCommandKind.CommandKind_CarControlMirrorCommand;
      }

    public string  getCommandKindAsString()
      {
        return stringFromCommandKind(getCommandKind());
      }

    public bool  hasCommandType()
      {
        return flagHasCommandType;
      }

    public TypeCommandType  getCommandType()
      {
        Debug.Assert(flagHasCommandType);
        return storeCommandType;
      }

    public string  getCommandTypeAsString()
      {
        return stringFromCommandType(getCommandType());
      }

    public bool  hasMirrorSelection()
      {
        return flagHasMirrorSelection;
      }

    public CarMirrorSelectionEnumJSON   getMirrorSelection()
      {
        Debug.Assert(flagHasMirrorSelection);
        return storeMirrorSelection;
      }

    public CarMirrorSelectionEnumJSON.TypeValue  getMirrorSelectionValue()
      {
        return getMirrorSelection().getValue();
      }

    public string  getMirrorSelectionAsString()
      {
        return getMirrorSelection().getValueAsString();
      }


    public virtual int extraCarControlMirrorStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlMirrorStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlMirrorStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlMirrorStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCommandKind()
      {
        flagHasCommandKind = true;
      }
    public void setCommandKind(TypeCommandKind new_value)
      {
        setCommandKind();
      }
    public void setCommandKind(string chars)
      {
        setCommandKind(stringToCommandKind(chars));
      }
    public void unsetCommandKind()
      {
        flagHasCommandKind = false;
      }
    public void setCommandType(TypeCommandType new_value)
      {
        flagHasCommandType = true;
        storeCommandType = new_value;
      }
    public void setCommandType(string chars)
      {
        setCommandType(stringToCommandType(chars));
      }
    public void unsetCommandType()
      {
        flagHasCommandType = false;
      }
    public void setMirrorSelection(CarMirrorSelectionEnumJSON  new_value)
      {
        if (flagHasMirrorSelection)
          {
          }
        flagHasMirrorSelection = true;
        storeMirrorSelection = new_value;
      }
    public void setMirrorSelection(CarMirrorSelectionEnumJSON.TypeValue new_value)
      {
        setMirrorSelection(new CarMirrorSelectionEnumJSON(new_value));
      }
    public void setMirrorSelection(string chars)
      {
        setMirrorSelection(new CarMirrorSelectionEnumJSON(chars));
      }
    public void unsetMirrorSelection()
      {
        if (flagHasMirrorSelection)
          {
          }
        flagHasMirrorSelection = false;
      }

    public virtual void extraCarControlMirrorStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlMirrorStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlMirrorStateLookup(key);
        if (old_field == null)
          {
            extraCarControlMirrorStateAppendPair(key, new_component);
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
        if (flagHasCommandKind)
          {
            handler.start_pair("CommandKind");
            handler.string_value("CarControlMirrorCommand");
          }
        if (flagHasCommandType)
          {
            handler.start_pair("CommandType");
            switch (storeCommandType)
              {
                case TypeCommandType.CommandType_RotateUp:
                    handler.string_value("RotateUp");
                    break;
                case TypeCommandType.CommandType_RotateDown:
                    handler.string_value("RotateDown");
                    break;
                case TypeCommandType.CommandType_RotateIn:
                    handler.string_value("RotateIn");
                    break;
                case TypeCommandType.CommandType_RotateOut:
                    handler.string_value("RotateOut");
                    break;
                case TypeCommandType.CommandType_Defrost:
                    handler.string_value("Defrost");
                    break;
                case TypeCommandType.CommandType_RotateToDefault:
                    handler.string_value("RotateToDefault");
                    break;
                case TypeCommandType.CommandType_SaveDefaultRotation:
                    handler.string_value("SaveDefaultRotation");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasMirrorSelection)
          {
            handler.start_pair("MirrorSelection");
            if (partial_allowed)
                storeMirrorSelection.write_partial_as_json(handler);
            else
                storeMirrorSelection.write_as_json(handler);
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

    public static CarControlMirrorStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlMirrorStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlMirrorState", ignore_extras);
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
    public static CarControlMirrorStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarControlMirrorStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlMirrorStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlMirrorState", ignore_extras);
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
    public static CarControlMirrorStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarControlMirrorStateJSON from_text(string text, bool ignore_extras)
      {
        CarControlMirrorStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlMirrorState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlMirrorStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CarControlMirrorStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlMirrorStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlMirrorState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCommandKind(result));
              }
            protected abstract void handle_result(TypeCommandKind result);
          };
    private class FieldHoldingGeneratorCommandKind : FieldGeneratorCommandKind
  {
    protected override void handle_result(TypeCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCommandKind(String what)
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
    public TypeCommandKind value;
  };
    private class FieldHoldingArrayGeneratorCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCommandKind
      {
        private FieldHoldingArrayGeneratorCommandKind top;

        protected override void handle_result(TypeCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCommandKind init_top)
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
    protected virtual void handle_result(List<TypeCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCommandKind> value;
  };
        private FieldHoldingGeneratorCommandKind fieldGeneratorCommandKind;
    private abstract class FieldGeneratorCommandType : JSONStringGenerator
          {
            protected FieldGeneratorCommandType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCommandType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCommandType(result));
              }
            protected abstract void handle_result(TypeCommandType result);
          };
    private class FieldHoldingGeneratorCommandType : FieldGeneratorCommandType
  {
    protected override void handle_result(TypeCommandType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCommandType(String what)
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
    public TypeCommandType value;
  };
    private class FieldHoldingArrayGeneratorCommandType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCommandType
      {
        private FieldHoldingArrayGeneratorCommandType top;

        protected override void handle_result(TypeCommandType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCommandType init_top)
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
    protected virtual void handle_result(List<TypeCommandType> result)
      {
      }

    public FieldHoldingArrayGeneratorCommandType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCommandType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCommandType> value;
  };
        private FieldHoldingGeneratorCommandType fieldGeneratorCommandType;
        private CarMirrorSelectionEnumJSON.HoldingGenerator fieldGeneratorMirrorSelection;
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
            CarControlMirrorStateJSON result = new CarControlMirrorStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlMirrorStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CarControlMirrorStateJSON result)
          {
            if (fieldGeneratorCommandKind.have_value)
              {
                result.setCommandKind();
                fieldGeneratorCommandKind.have_value = false;
              }
            if (fieldGeneratorCommandType.have_value)
              {
                result.setCommandType(fieldGeneratorCommandType.value);
                fieldGeneratorCommandType.have_value = false;
              }
            if (fieldGeneratorMirrorSelection.have_value)
              {
                result.setMirrorSelection(fieldGeneratorMirrorSelection.value);
                fieldGeneratorMirrorSelection.have_value = false;
              }
          }
        protected abstract void handle_result(CarControlMirrorStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "ommand", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'K':
                                if ((String.Compare(field_name, 8, "ind", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorCommandKind;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "ype", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorCommandType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "irrorSelection", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorMirrorSelection;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the CarControlMirrorState class");
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlMirrorState class");
            fieldGeneratorMirrorSelection = new CarMirrorSelectionEnumJSON.HoldingGenerator("field \"MirrorSelection\" of the CarControlMirrorState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlMirrorState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the CarControlMirrorState class");
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlMirrorState class");
            fieldGeneratorMirrorSelection = new CarMirrorSelectionEnumJSON.HoldingGenerator("field \"MirrorSelection\" of the CarControlMirrorState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlMirrorState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCommandKind.reset();
            fieldGeneratorCommandType.reset();
            fieldGeneratorMirrorSelection.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMirrorSelection.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMirrorSelection.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlMirrorStateJSON  result)
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
        public CarControlMirrorStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlMirrorStateJSON  result)
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
    protected virtual void handle_result(List<CarControlMirrorStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlMirrorStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlMirrorStateJSON>();
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
    public List<CarControlMirrorStateJSON> value;
  };
  };
