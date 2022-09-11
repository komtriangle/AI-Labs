/* file "UpdateRouteConditionCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UpdateRouteConditionCommandJSON : NavigationControlCommandJSON
  {
    public enum TypeNewRouteCondition
      {
        NewRouteCondition_Recommended,
        NewRouteCondition_Fastest,
        NewRouteCondition_AvoidTollRoad,
        NewRouteCondition_AvoidHighway
      };

    public static TypeNewRouteCondition  stringToNewRouteCondition(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (String.Compare(chars, 1, "void", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'H':
                            if ((String.Compare(chars, 6, "ighway", 0, 6, false) == 0) && (chars.Length == 12))
                                return TypeNewRouteCondition.NewRouteCondition_AvoidHighway;
                            break;
                        case 'T':
                            if ((String.Compare(chars, 6, "ollRoad", 0, 7, false) == 0) && (chars.Length == 13))
                                return TypeNewRouteCondition.NewRouteCondition_AvoidTollRoad;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(chars, 1, "astest", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNewRouteCondition.NewRouteCondition_Fastest;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "ecommended", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeNewRouteCondition.NewRouteCondition_Recommended;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `NewRouteCondition' is not one of the legal values.");
      }

    public static string  stringFromNewRouteCondition(TypeNewRouteCondition the_enum)
      {
        switch (the_enum)
          {
            case TypeNewRouteCondition.NewRouteCondition_Recommended:
                return "Recommended";
            case TypeNewRouteCondition.NewRouteCondition_Fastest:
                return "Fastest";
            case TypeNewRouteCondition.NewRouteCondition_AvoidTollRoad:
                return "AvoidTollRoad";
            case TypeNewRouteCondition.NewRouteCondition_AvoidHighway:
                return "AvoidHighway";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasNewRouteCondition;
    private TypeNewRouteCondition storeNewRouteCondition;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNewRouteConditionToJSON()
      {
        JSONStringValue generated_string_NewRouteCondition;
        switch (storeNewRouteCondition)
          {
            case TypeNewRouteCondition.NewRouteCondition_Recommended:
                generated_string_NewRouteCondition = new JSONStringValue("Recommended");
                break;
            case TypeNewRouteCondition.NewRouteCondition_Fastest:
                generated_string_NewRouteCondition = new JSONStringValue("Fastest");
                break;
            case TypeNewRouteCondition.NewRouteCondition_AvoidTollRoad:
                generated_string_NewRouteCondition = new JSONStringValue("AvoidTollRoad");
                break;
            case TypeNewRouteCondition.NewRouteCondition_AvoidHighway:
                generated_string_NewRouteCondition = new JSONStringValue("AvoidHighway");
                break;
            default:
                Debug.Assert(false);
                generated_string_NewRouteCondition = null;
                break;
          }
        return generated_string_NewRouteCondition;
      }


    private void  fromJSONNewRouteCondition(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewRouteCondition of UpdateRouteConditionCommandJSON is not a string.");
        TypeNewRouteCondition the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if (String.Compare(json_string.getData(), 1, "void", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'H':
                            if ((String.Compare(json_string.getData(), 6, "ighway", 0, 6, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_enum = TypeNewRouteCondition.NewRouteCondition_AvoidHighway;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'T':
                            if ((String.Compare(json_string.getData(), 6, "ollRoad", 0, 7, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_enum = TypeNewRouteCondition.NewRouteCondition_AvoidTollRoad;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "astest", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeNewRouteCondition.NewRouteCondition_Fastest;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "ecommended", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeNewRouteCondition.NewRouteCondition_Recommended;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field NewRouteCondition of UpdateRouteConditionCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setNewRouteCondition(the_enum);
      }


    public UpdateRouteConditionCommandJSON()
      {
        flagHasNewRouteCondition = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandType()
      {
        return "UpdateRouteCondition";
      }

    public bool  hasNewRouteCondition()
      {
        return flagHasNewRouteCondition;
      }

    public TypeNewRouteCondition  getNewRouteCondition()
      {
        Debug.Assert(flagHasNewRouteCondition);
        return storeNewRouteCondition;
      }

    public string  getNewRouteConditionAsString()
      {
        return stringFromNewRouteCondition(getNewRouteCondition());
      }


    public virtual int extraUpdateRouteConditionCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUpdateRouteConditionCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUpdateRouteConditionCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUpdateRouteConditionCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraNavigationControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasNewRouteCondition)
            ++result;
        result += extraUpdateRouteConditionCommandComponentCount();
        return result;
      }
    public override string extraNavigationControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNewRouteCondition)
          {
            if (remainder == 0)
                return "NewRouteCondition";
            --remainder;
          }
        return extraUpdateRouteConditionCommandComponentKey(remainder);
      }
    public override JSONValue extraNavigationControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNewRouteCondition)
          {
            if (remainder == 0)
                return extraNewRouteConditionToJSON();
            --remainder;
          }
        return extraUpdateRouteConditionCommandComponentValue(remainder);
      }
    public override JSONValue extraNavigationControlCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NewRouteCondition", 0, 17, false) == 0) && (field_name.Length == 17))
            return (flagHasNewRouteCondition ? extraNewRouteConditionToJSON() : null);
        return extraUpdateRouteConditionCommandLookup(field_name);
      }

    public void setNewRouteCondition(TypeNewRouteCondition new_value)
      {
        flagHasNewRouteCondition = true;
        storeNewRouteCondition = new_value;
      }
    public void setNewRouteCondition(string chars)
      {
        setNewRouteCondition(stringToNewRouteCondition(chars));
      }
    public void unsetNewRouteCondition()
      {
        flagHasNewRouteCondition = false;
      }

    public virtual void extraUpdateRouteConditionCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUpdateRouteConditionCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUpdateRouteConditionCommandLookup(key);
        if (old_field == null)
          {
            extraUpdateRouteConditionCommandAppendPair(key, new_component);
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
    public override void extraNavigationControlCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NewRouteCondition", 0, 17, false) == 0) && (key.Length == 17))
            {
            fromJSONNewRouteCondition(new_component, false);
            return;
            }
        extraUpdateRouteConditionCommandAppendPair(key, new_component);
      }
    public override void extraNavigationControlCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NewRouteCondition", 0, 17, false) == 0) && (key.Length == 17))
            {
            fromJSONNewRouteCondition(new_component, false);
            return;
            }
        extraUpdateRouteConditionCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNewRouteCondition);
        if (flagHasNewRouteCondition)
          {
            handler.start_pair("NewRouteCondition");
            switch (storeNewRouteCondition)
              {
                case TypeNewRouteCondition.NewRouteCondition_Recommended:
                    handler.string_value("Recommended");
                    break;
                case TypeNewRouteCondition.NewRouteCondition_Fastest:
                    handler.string_value("Fastest");
                    break;
                case TypeNewRouteCondition.NewRouteCondition_AvoidTollRoad:
                    handler.string_value("AvoidTollRoad");
                    break;
                case TypeNewRouteCondition.NewRouteCondition_AvoidHighway:
                    handler.string_value("AvoidHighway");
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
        if (!(hasNewRouteCondition()))
          {
            return "When parsing the object for %what%, the \"NewRouteCondition\" field was missing.";
          }
        return null;
      }

    public static new UpdateRouteConditionCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UpdateRouteConditionCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UpdateRouteConditionCommand", ignore_extras);
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
    public static new UpdateRouteConditionCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UpdateRouteConditionCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UpdateRouteConditionCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UpdateRouteConditionCommand", ignore_extras);
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
    public static new UpdateRouteConditionCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UpdateRouteConditionCommandJSON from_text(string text, bool ignore_extras)
      {
        UpdateRouteConditionCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UpdateRouteConditionCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UpdateRouteConditionCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UpdateRouteConditionCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UpdateRouteConditionCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UpdateRouteConditionCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : NavigationControlCommandJSON.Generator
      {
    private abstract class FieldGeneratorNewRouteCondition : JSONStringGenerator
          {
            protected FieldGeneratorNewRouteCondition(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNewRouteCondition()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNewRouteCondition(result));
              }
            protected abstract void handle_result(TypeNewRouteCondition result);
          };
    private class FieldHoldingGeneratorNewRouteCondition : FieldGeneratorNewRouteCondition
  {
    protected override void handle_result(TypeNewRouteCondition result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNewRouteCondition(String what)
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
    public TypeNewRouteCondition value;
  };
    private class FieldHoldingArrayGeneratorNewRouteCondition : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNewRouteCondition
      {
        private FieldHoldingArrayGeneratorNewRouteCondition top;

        protected override void handle_result(TypeNewRouteCondition result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNewRouteCondition init_top)
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
    protected virtual void handle_result(List<TypeNewRouteCondition> result)
      {
      }

    public FieldHoldingArrayGeneratorNewRouteCondition(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewRouteCondition>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNewRouteCondition()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewRouteCondition>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNewRouteCondition> value;
  };
        private FieldHoldingGeneratorNewRouteCondition fieldGeneratorNewRouteCondition;
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
            if (!(getNavigationControlCommandJSONKey().Equals("UpdateRouteCondition")))
                throw new Exception("The key field has a value other than `UpdateRouteCondition'.");
            UpdateRouteConditionCommandJSON result = new UpdateRouteConditionCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUpdateRouteConditionCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(NavigationControlCommandJSON new_result)
          {
            handle_result((UpdateRouteConditionCommandJSON )new_result);
          }
        protected void finish(UpdateRouteConditionCommandJSON result)
          {
            if (fieldGeneratorNewRouteCondition.have_value)
              {
                result.setNewRouteCondition(fieldGeneratorNewRouteCondition.value);
                fieldGeneratorNewRouteCondition.have_value = false;
              }
            else if ((!(result.hasNewRouteCondition())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewRouteCondition\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UpdateRouteConditionCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NewRouteCondition", 0, 17, false) == 0) && (field_name.Length == 17))
                return fieldGeneratorNewRouteCondition;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNewRouteCondition = new FieldHoldingGeneratorNewRouteCondition("field \"NewRouteCondition\" of the UpdateRouteConditionCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UpdateRouteConditionCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNewRouteCondition = new FieldHoldingGeneratorNewRouteCondition("field \"NewRouteCondition\" of the UpdateRouteConditionCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UpdateRouteConditionCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNewRouteCondition.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UpdateRouteConditionCommandJSON  result)
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
        public UpdateRouteConditionCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UpdateRouteConditionCommandJSON  result)
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
    protected virtual void handle_result(List<UpdateRouteConditionCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UpdateRouteConditionCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UpdateRouteConditionCommandJSON>();
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
    public List<UpdateRouteConditionCommandJSON> value;
  };
  };
