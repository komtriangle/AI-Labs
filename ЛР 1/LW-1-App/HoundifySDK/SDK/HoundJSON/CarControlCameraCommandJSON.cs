/* file "CarControlCameraCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlCameraCommandJSON : CarControlCommandJSON
  {
    public enum TypeCameraSelection
      {
        CameraSelection_Front,
        CameraSelection_Rear,
        CameraSelection_LeftSide,
        CameraSelection_RightSide
      };

    public static TypeCameraSelection  stringToCameraSelection(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "ront", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeCameraSelection.CameraSelection_Front;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "eftSide", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeCameraSelection.CameraSelection_LeftSide;
                break;
            case 'R':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "ar", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeCameraSelection.CameraSelection_Rear;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "ghtSide", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeCameraSelection.CameraSelection_RightSide;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `CameraSelection' is not one of the legal values.");
      }

    public static string  stringFromCameraSelection(TypeCameraSelection the_enum)
      {
        switch (the_enum)
          {
            case TypeCameraSelection.CameraSelection_Front:
                return "Front";
            case TypeCameraSelection.CameraSelection_Rear:
                return "Rear";
            case TypeCameraSelection.CameraSelection_LeftSide:
                return "LeftSide";
            case TypeCameraSelection.CameraSelection_RightSide:
                return "RightSide";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeCommandType
      {
        CommandType_Show,
        CommandType_TakePicture
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        switch (chars[0])
          {
            case 'S':
                if ((String.Compare(chars, 1, "how", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeCommandType.CommandType_Show;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "akePicture", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeCommandType.CommandType_TakePicture;
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
            case TypeCommandType.CommandType_Show:
                return "Show";
            case TypeCommandType.CommandType_TakePicture:
                return "TakePicture";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCameraSelection;
    private TypeCameraSelection storeCameraSelection;
    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCameraSelectionToJSON()
      {
        JSONStringValue generated_string_CameraSelection;
        switch (storeCameraSelection)
          {
            case TypeCameraSelection.CameraSelection_Front:
                generated_string_CameraSelection = new JSONStringValue("Front");
                break;
            case TypeCameraSelection.CameraSelection_Rear:
                generated_string_CameraSelection = new JSONStringValue("Rear");
                break;
            case TypeCameraSelection.CameraSelection_LeftSide:
                generated_string_CameraSelection = new JSONStringValue("LeftSide");
                break;
            case TypeCameraSelection.CameraSelection_RightSide:
                generated_string_CameraSelection = new JSONStringValue("RightSide");
                break;
            default:
                Debug.Assert(false);
                generated_string_CameraSelection = null;
                break;
          }
        return generated_string_CameraSelection;
      }

    private JSONValue  extraCommandTypeToJSON()
      {
        JSONStringValue generated_string_CommandType;
        switch (storeCommandType)
          {
            case TypeCommandType.CommandType_Show:
                generated_string_CommandType = new JSONStringValue("Show");
                break;
            case TypeCommandType.CommandType_TakePicture:
                generated_string_CommandType = new JSONStringValue("TakePicture");
                break;
            default:
                Debug.Assert(false);
                generated_string_CommandType = null;
                break;
          }
        return generated_string_CommandType;
      }


    private void  fromJSONCameraSelection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CameraSelection of CarControlCameraCommandJSON is not a string.");
        TypeCameraSelection the_enum;
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ront", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeCameraSelection.CameraSelection_Front;
                        goto enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "eftSide", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeCameraSelection.CameraSelection_LeftSide;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ar", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_enum = TypeCameraSelection.CameraSelection_Rear;
                                goto enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ghtSide", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_enum = TypeCameraSelection.CameraSelection_RightSide;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field CameraSelection of CarControlCameraCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCameraSelection(the_enum);
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of CarControlCameraCommandJSON is not a string.");
        TypeCommandType the_enum;
        switch (json_string.getData()[0])
          {
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "how", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeCommandType.CommandType_Show;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "akePicture", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeCommandType.CommandType_TakePicture;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field CommandType of CarControlCameraCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    public CarControlCameraCommandJSON()
      {
        flagHasCameraSelection = false;
        flagHasCommandType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCarControlCommandKind()
      {
        return "CarControlCameraCommand";
      }

    public bool  hasCameraSelection()
      {
        return flagHasCameraSelection;
      }

    public TypeCameraSelection  getCameraSelection()
      {
        Debug.Assert(flagHasCameraSelection);
        return storeCameraSelection;
      }

    public string  getCameraSelectionAsString()
      {
        return stringFromCameraSelection(getCameraSelection());
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


    public virtual int extraCarControlCameraCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlCameraCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlCameraCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlCameraCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCarControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCameraSelection)
            ++result;
        if (flagHasCommandType)
            ++result;
        result += extraCarControlCameraCommandComponentCount();
        return result;
      }
    public override string extraCarControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCameraSelection)
          {
            if (remainder == 0)
                return "CameraSelection";
            --remainder;
          }
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return "CommandType";
            --remainder;
          }
        return extraCarControlCameraCommandComponentKey(remainder);
      }
    public override JSONValue extraCarControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCameraSelection)
          {
            if (remainder == 0)
                return extraCameraSelectionToJSON();
            --remainder;
          }
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return extraCommandTypeToJSON();
            --remainder;
          }
        return extraCarControlCameraCommandComponentValue(remainder);
      }
    public override JSONValue extraCarControlCommandLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "C", 0, 1, false) == 0)
          {
            switch (field_name[1])
              {
                case 'a':
                    if ((String.Compare(field_name, 2, "meraSelection", 0, 13, false) == 0) && (field_name.Length == 15))
                        return (flagHasCameraSelection ? extraCameraSelectionToJSON() : null);
                    break;
                case 'o':
                    if ((String.Compare(field_name, 2, "mmandType", 0, 9, false) == 0) && (field_name.Length == 11))
                        return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraCarControlCameraCommandLookup(field_name);
      }

    public void setCameraSelection(TypeCameraSelection new_value)
      {
        flagHasCameraSelection = true;
        storeCameraSelection = new_value;
      }
    public void setCameraSelection(string chars)
      {
        setCameraSelection(stringToCameraSelection(chars));
      }
    public void unsetCameraSelection()
      {
        flagHasCameraSelection = false;
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

    public virtual void extraCarControlCameraCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlCameraCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlCameraCommandLookup(key);
        if (old_field == null)
          {
            extraCarControlCameraCommandAppendPair(key, new_component);
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
        if (String.Compare(key, 0, "C", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "meraSelection", 0, 13, false) == 0) && (key.Length == 15))
                        {
                        fromJSONCameraSelection(new_component, false);
                        return;
                        }
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "mmandType", 0, 9, false) == 0) && (key.Length == 11))
                        {
                        fromJSONCommandType(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraCarControlCameraCommandAppendPair(key, new_component);
      }
    public override void extraCarControlCommandSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "C", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "meraSelection", 0, 13, false) == 0) && (key.Length == 15))
                        {
                        fromJSONCameraSelection(new_component, false);
                        return;
                        }
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "mmandType", 0, 9, false) == 0) && (key.Length == 11))
                        {
                        fromJSONCommandType(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraCarControlCameraCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCameraSelection);
        if (flagHasCameraSelection)
          {
            handler.start_pair("CameraSelection");
            switch (storeCameraSelection)
              {
                case TypeCameraSelection.CameraSelection_Front:
                    handler.string_value("Front");
                    break;
                case TypeCameraSelection.CameraSelection_Rear:
                    handler.string_value("Rear");
                    break;
                case TypeCameraSelection.CameraSelection_LeftSide:
                    handler.string_value("LeftSide");
                    break;
                case TypeCameraSelection.CameraSelection_RightSide:
                    handler.string_value("RightSide");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasCommandType);
        if (flagHasCommandType)
          {
            handler.start_pair("CommandType");
            switch (storeCommandType)
              {
                case TypeCommandType.CommandType_Show:
                    handler.string_value("Show");
                    break;
                case TypeCommandType.CommandType_TakePicture:
                    handler.string_value("TakePicture");
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasCameraSelection()))
          {
            return "When parsing the object for %what%, the \"CameraSelection\" field was missing.";
          }
        if (!(hasCommandType()))
          {
            return "When parsing the object for %what%, the \"CommandType\" field was missing.";
          }
        return null;
      }

    public static new CarControlCameraCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlCameraCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlCameraCommand", ignore_extras);
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
    public static new CarControlCameraCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlCameraCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlCameraCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlCameraCommand", ignore_extras);
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
    public static new CarControlCameraCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlCameraCommandJSON from_text(string text, bool ignore_extras)
      {
        CarControlCameraCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlCameraCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlCameraCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CarControlCameraCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlCameraCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlCameraCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CarControlCommandJSON.Generator
      {
    private abstract class FieldGeneratorCameraSelection : JSONStringGenerator
          {
            protected FieldGeneratorCameraSelection(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCameraSelection()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCameraSelection(result));
              }
            protected abstract void handle_result(TypeCameraSelection result);
          };
    private class FieldHoldingGeneratorCameraSelection : FieldGeneratorCameraSelection
  {
    protected override void handle_result(TypeCameraSelection result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCameraSelection(String what)
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
    public TypeCameraSelection value;
  };
    private class FieldHoldingArrayGeneratorCameraSelection : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCameraSelection
      {
        private FieldHoldingArrayGeneratorCameraSelection top;

        protected override void handle_result(TypeCameraSelection result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCameraSelection init_top)
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
    protected virtual void handle_result(List<TypeCameraSelection> result)
      {
      }

    public FieldHoldingArrayGeneratorCameraSelection(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCameraSelection>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCameraSelection()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCameraSelection>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCameraSelection> value;
  };
        private FieldHoldingGeneratorCameraSelection fieldGeneratorCameraSelection;
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
            if (!(getCarControlCommandJSONKey().Equals("CarControlCameraCommand")))
                throw new Exception("The key field has a value other than `CarControlCameraCommand'.");
            CarControlCameraCommandJSON result = new CarControlCameraCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlCameraCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CarControlCommandJSON new_result)
          {
            handle_result((CarControlCameraCommandJSON )new_result);
          }
        protected void finish(CarControlCameraCommandJSON result)
          {
            if (fieldGeneratorCameraSelection.have_value)
              {
                result.setCameraSelection(fieldGeneratorCameraSelection.value);
                fieldGeneratorCameraSelection.have_value = false;
              }
            else if ((!(result.hasCameraSelection())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CameraSelection\" field was missing.");
              }
            if (fieldGeneratorCommandType.have_value)
              {
                result.setCommandType(fieldGeneratorCommandType.value);
                fieldGeneratorCommandType.have_value = false;
              }
            else if ((!(result.hasCommandType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CommandType\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CarControlCameraCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "C", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "meraSelection", 0, 13, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorCameraSelection;
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "mmandType", 0, 9, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorCommandType;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCameraSelection = new FieldHoldingGeneratorCameraSelection("field \"CameraSelection\" of the CarControlCameraCommand class");
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlCameraCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlCameraCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCameraSelection = new FieldHoldingGeneratorCameraSelection("field \"CameraSelection\" of the CarControlCameraCommand class");
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlCameraCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlCameraCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCameraSelection.reset();
            fieldGeneratorCommandType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlCameraCommandJSON  result)
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
        public CarControlCameraCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlCameraCommandJSON  result)
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
    protected virtual void handle_result(List<CarControlCameraCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlCameraCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlCameraCommandJSON>();
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
    public List<CarControlCameraCommandJSON> value;
  };
  };
