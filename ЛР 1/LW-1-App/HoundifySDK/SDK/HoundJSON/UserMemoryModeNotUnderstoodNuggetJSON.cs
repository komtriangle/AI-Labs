/* file "UserMemoryModeNotUnderstoodNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserMemoryModeNotUnderstoodNuggetJSON : UserMemoryNuggetJSON
  {
    public enum TypeErrType
      {
        ErrType_UnknownAddress,
        ErrType_EmptyName
      };

    public static TypeErrType  stringToErrType(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "mptyName", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeErrType.ErrType_EmptyName;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknownAddress", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeErrType.ErrType_UnknownAddress;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ErrType' is not one of the legal values.");
      }

    public static string  stringFromErrType(TypeErrType the_enum)
      {
        switch (the_enum)
          {
            case TypeErrType.ErrType_UnknownAddress:
                return "UnknownAddress";
            case TypeErrType.ErrType_EmptyName:
                return "EmptyName";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasErrType;
    private TypeErrType storeErrType;
    private bool flagHasWhat;
    private string storeWhat;
    private bool flagHasWhere;
    private string storeWhere;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraErrTypeToJSON()
      {
        JSONStringValue generated_string_ErrType;
        switch (storeErrType)
          {
            case TypeErrType.ErrType_UnknownAddress:
                generated_string_ErrType = new JSONStringValue("UnknownAddress");
                break;
            case TypeErrType.ErrType_EmptyName:
                generated_string_ErrType = new JSONStringValue("EmptyName");
                break;
            default:
                Debug.Assert(false);
                generated_string_ErrType = null;
                break;
          }
        return generated_string_ErrType;
      }

    private JSONValue  extraWhatToJSON()
      {
        JSONStringValue generated_string_What = new JSONStringValue(storeWhat);
        return generated_string_What;
      }

    private JSONValue  extraWhereToJSON()
      {
        JSONStringValue generated_string_Where = new JSONStringValue(storeWhere);
        return generated_string_Where;
      }


    private void  fromJSONErrType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrType of UserMemoryModeNotUnderstoodNuggetJSON is not a string.");
        TypeErrType the_enum;
        switch (json_string.getData()[0])
          {
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "mptyName", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeErrType.ErrType_EmptyName;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknownAddress", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_enum = TypeErrType.ErrType_UnknownAddress;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field ErrType of UserMemoryModeNotUnderstoodNuggetJSON is not one of the legal strings.");
      enum_is_done:;
        setErrType(the_enum);
      }


    private void  fromJSONWhat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field What of UserMemoryModeNotUnderstoodNuggetJSON is not a string.");
        setWhat(json_string.getData());
      }


    private void  fromJSONWhere(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Where of UserMemoryModeNotUnderstoodNuggetJSON is not a string.");
        setWhere(json_string.getData());
      }


    public UserMemoryModeNotUnderstoodNuggetJSON()
      {
        flagHasErrType = false;
        flagHasWhat = false;
        flagHasWhere = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUserMemoryNuggetKind()
      {
        return "UserMemoryModeNotUnderstood";
      }

    public bool  hasErrType()
      {
        return flagHasErrType;
      }

    public TypeErrType  getErrType()
      {
        Debug.Assert(flagHasErrType);
        return storeErrType;
      }

    public string  getErrTypeAsString()
      {
        return stringFromErrType(getErrType());
      }

    public bool  hasWhat()
      {
        return flagHasWhat;
      }

    public string  getWhat()
      {
        Debug.Assert(flagHasWhat);
        return storeWhat;
      }

    public bool  hasWhere()
      {
        return flagHasWhere;
      }

    public string  getWhere()
      {
        Debug.Assert(flagHasWhere);
        return storeWhere;
      }


    public virtual int extraUserMemoryModeNotUnderstoodNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserMemoryModeNotUnderstoodNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserMemoryModeNotUnderstoodNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserMemoryModeNotUnderstoodNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUserMemoryNuggetComponentCount()
      {
        int result = 0;
        if (flagHasErrType)
            ++result;
        if (flagHasWhat)
            ++result;
        if (flagHasWhere)
            ++result;
        result += extraUserMemoryModeNotUnderstoodNuggetComponentCount();
        return result;
      }
    public override string extraUserMemoryNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasErrType)
          {
            if (remainder == 0)
                return "ErrType";
            --remainder;
          }
        if (flagHasWhat)
          {
            if (remainder == 0)
                return "What";
            --remainder;
          }
        if (flagHasWhere)
          {
            if (remainder == 0)
                return "Where";
            --remainder;
          }
        return extraUserMemoryModeNotUnderstoodNuggetComponentKey(remainder);
      }
    public override JSONValue extraUserMemoryNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasErrType)
          {
            if (remainder == 0)
                return extraErrTypeToJSON();
            --remainder;
          }
        if (flagHasWhat)
          {
            if (remainder == 0)
                return extraWhatToJSON();
            --remainder;
          }
        if (flagHasWhere)
          {
            if (remainder == 0)
                return extraWhereToJSON();
            --remainder;
          }
        return extraUserMemoryModeNotUnderstoodNuggetComponentValue(remainder);
      }
    public override JSONValue extraUserMemoryNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "rrType", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasErrType ? extraErrTypeToJSON() : null);
                break;
            case 'W':
                if (String.Compare(field_name, 1, "h", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 3, "t", 0, 1, false) == 0) && (field_name.Length == 4))
                                return (flagHasWhat ? extraWhatToJSON() : null);
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 3, "re", 0, 2, false) == 0) && (field_name.Length == 5))
                                return (flagHasWhere ? extraWhereToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraUserMemoryModeNotUnderstoodNuggetLookup(field_name);
      }

    public void setErrType(TypeErrType new_value)
      {
        flagHasErrType = true;
        storeErrType = new_value;
      }
    public void setErrType(string chars)
      {
        setErrType(stringToErrType(chars));
      }
    public void unsetErrType()
      {
        flagHasErrType = false;
      }
    public void setWhat(string new_value)
      {
        flagHasWhat = true;
        storeWhat = new_value;
      }
    public void unsetWhat()
      {
        flagHasWhat = false;
      }
    public void setWhere(string new_value)
      {
        flagHasWhere = true;
        storeWhere = new_value;
      }
    public void unsetWhere()
      {
        flagHasWhere = false;
      }

    public virtual void extraUserMemoryModeNotUnderstoodNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserMemoryModeNotUnderstoodNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserMemoryModeNotUnderstoodNuggetLookup(key);
        if (old_field == null)
          {
            extraUserMemoryModeNotUnderstoodNuggetAppendPair(key, new_component);
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
    public override void extraUserMemoryNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rrType", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONErrType(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if (String.Compare(key, 1, "h", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'a':
                            if ((String.Compare(key, 3, "t", 0, 1, false) == 0) && (key.Length == 4))
                                {
                                fromJSONWhat(new_component, false);
                                return;
                                }
                            break;
                        case 'e':
                            if ((String.Compare(key, 3, "re", 0, 2, false) == 0) && (key.Length == 5))
                                {
                                fromJSONWhere(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraUserMemoryModeNotUnderstoodNuggetAppendPair(key, new_component);
      }
    public override void extraUserMemoryNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rrType", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONErrType(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if (String.Compare(key, 1, "h", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'a':
                            if ((String.Compare(key, 3, "t", 0, 1, false) == 0) && (key.Length == 4))
                                {
                                fromJSONWhat(new_component, false);
                                return;
                                }
                            break;
                        case 'e':
                            if ((String.Compare(key, 3, "re", 0, 2, false) == 0) && (key.Length == 5))
                                {
                                fromJSONWhere(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraUserMemoryModeNotUnderstoodNuggetSetField(key, new_component);
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
        if (flagHasErrType)
          {
            handler.start_pair("ErrType");
            switch (storeErrType)
              {
                case TypeErrType.ErrType_UnknownAddress:
                    handler.string_value("UnknownAddress");
                    break;
                case TypeErrType.ErrType_EmptyName:
                    handler.string_value("EmptyName");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasWhat)
          {
            handler.start_pair("What");
            handler.string_value(storeWhat);
          }
        if (flagHasWhere)
          {
            handler.start_pair("Where");
            handler.string_value(storeWhere);
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

    public static new UserMemoryModeNotUnderstoodNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserMemoryModeNotUnderstoodNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryModeNotUnderstoodNugget", ignore_extras);
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
    public static new UserMemoryModeNotUnderstoodNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserMemoryModeNotUnderstoodNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserMemoryModeNotUnderstoodNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryModeNotUnderstoodNugget", ignore_extras);
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
    public static new UserMemoryModeNotUnderstoodNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserMemoryModeNotUnderstoodNuggetJSON from_text(string text, bool ignore_extras)
      {
        UserMemoryModeNotUnderstoodNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryModeNotUnderstoodNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserMemoryModeNotUnderstoodNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UserMemoryModeNotUnderstoodNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserMemoryModeNotUnderstoodNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryModeNotUnderstoodNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UserMemoryNuggetJSON.Generator
      {
    private abstract class FieldGeneratorErrType : JSONStringGenerator
          {
            protected FieldGeneratorErrType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorErrType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToErrType(result));
              }
            protected abstract void handle_result(TypeErrType result);
          };
    private class FieldHoldingGeneratorErrType : FieldGeneratorErrType
  {
    protected override void handle_result(TypeErrType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorErrType(String what)
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
    public TypeErrType value;
  };
    private class FieldHoldingArrayGeneratorErrType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorErrType
      {
        private FieldHoldingArrayGeneratorErrType top;

        protected override void handle_result(TypeErrType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorErrType init_top)
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
    protected virtual void handle_result(List<TypeErrType> result)
      {
      }

    public FieldHoldingArrayGeneratorErrType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeErrType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorErrType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeErrType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeErrType> value;
  };
        private FieldHoldingGeneratorErrType fieldGeneratorErrType;
        private JSONHoldingStringGenerator fieldGeneratorWhat;
        private JSONHoldingStringGenerator fieldGeneratorWhere;
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
            if (!(getUserMemoryNuggetJSONKey().Equals("UserMemoryModeNotUnderstood")))
                throw new Exception("The key field has a value other than `UserMemoryModeNotUnderstood'.");
            UserMemoryModeNotUnderstoodNuggetJSON result = new UserMemoryModeNotUnderstoodNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserMemoryModeNotUnderstoodNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UserMemoryNuggetJSON new_result)
          {
            handle_result((UserMemoryModeNotUnderstoodNuggetJSON )new_result);
          }
        protected void finish(UserMemoryModeNotUnderstoodNuggetJSON result)
          {
            if (fieldGeneratorErrType.have_value)
              {
                result.setErrType(fieldGeneratorErrType.value);
                fieldGeneratorErrType.have_value = false;
              }
            if (fieldGeneratorWhat.have_value)
              {
                result.setWhat(fieldGeneratorWhat.value);
                fieldGeneratorWhat.have_value = false;
              }
            if (fieldGeneratorWhere.have_value)
              {
                result.setWhere(fieldGeneratorWhere.value);
                fieldGeneratorWhere.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(UserMemoryModeNotUnderstoodNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "rrType", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorErrType;
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "h", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 3, "t", 0, 1, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorWhat;
                                break;
                            case 'e':
                                if ((String.Compare(field_name, 3, "re", 0, 2, false) == 0) && (field_name.Length == 5))
                                    return fieldGeneratorWhere;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorErrType = new FieldHoldingGeneratorErrType("field \"ErrType\" of the UserMemoryModeNotUnderstoodNugget class");
            fieldGeneratorWhat = new JSONHoldingStringGenerator("field \"What\" of the UserMemoryModeNotUnderstoodNugget class");
            fieldGeneratorWhere = new JSONHoldingStringGenerator("field \"Where\" of the UserMemoryModeNotUnderstoodNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserMemoryModeNotUnderstoodNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorErrType = new FieldHoldingGeneratorErrType("field \"ErrType\" of the UserMemoryModeNotUnderstoodNugget class");
            fieldGeneratorWhat = new JSONHoldingStringGenerator("field \"What\" of the UserMemoryModeNotUnderstoodNugget class");
            fieldGeneratorWhere = new JSONHoldingStringGenerator("field \"Where\" of the UserMemoryModeNotUnderstoodNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserMemoryModeNotUnderstoodNugget class");
          }

        public override void reset()
          {
            fieldGeneratorErrType.reset();
            fieldGeneratorWhat.reset();
            fieldGeneratorWhere.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UserMemoryModeNotUnderstoodNuggetJSON  result)
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
        public UserMemoryModeNotUnderstoodNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserMemoryModeNotUnderstoodNuggetJSON  result)
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
    protected virtual void handle_result(List<UserMemoryModeNotUnderstoodNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserMemoryModeNotUnderstoodNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserMemoryModeNotUnderstoodNuggetJSON>();
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
    public List<UserMemoryModeNotUnderstoodNuggetJSON> value;
  };
  };
