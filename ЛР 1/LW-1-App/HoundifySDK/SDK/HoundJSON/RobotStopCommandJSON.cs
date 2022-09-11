/* file "RobotStopCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RobotStopCommandJSON : RobotCommandJSON
  {
    public enum TypeScope
      {
        Scope_all,
        Scope_last,
        Scope_movement
      };

    public static TypeScope  stringToScope(string chars)
      {
        switch (chars[0])
          {
            case 'a':
                if ((String.Compare(chars, 1, "ll", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeScope.Scope_all;
                break;
            case 'l':
                if ((String.Compare(chars, 1, "ast", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeScope.Scope_last;
                break;
            case 'm':
                if ((String.Compare(chars, 1, "ovement", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeScope.Scope_movement;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Scope' is not one of the legal values.");
      }

    public static string  stringFromScope(TypeScope the_enum)
      {
        switch (the_enum)
          {
            case TypeScope.Scope_all:
                return "all";
            case TypeScope.Scope_last:
                return "last";
            case TypeScope.Scope_movement:
                return "movement";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasAlreadyStoppedResult;
    private DynamicResponseJSON  storeAlreadyStoppedResult;
    private bool flagHasScope;
    private TypeScope storeScope;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAlreadyStoppedResultToJSON()
      {
        JSONValueHandler handler_AlreadyStoppedResult = new JSONValueHandler();
        storeAlreadyStoppedResult.write_as_json(handler_AlreadyStoppedResult);
        return handler_AlreadyStoppedResult.result;
      }

    private JSONValue  extraScopeToJSON()
      {
        JSONStringValue generated_string_Scope;
        switch (storeScope)
          {
            case TypeScope.Scope_all:
                generated_string_Scope = new JSONStringValue("all");
                break;
            case TypeScope.Scope_last:
                generated_string_Scope = new JSONStringValue("last");
                break;
            case TypeScope.Scope_movement:
                generated_string_Scope = new JSONStringValue("movement");
                break;
            default:
                Debug.Assert(false);
                generated_string_Scope = null;
                break;
          }
        return generated_string_Scope;
      }


    private void  fromJSONAlreadyStoppedResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAlreadyStoppedResult(convert_classy);
      }


    private void  fromJSONScope(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Scope of RobotStopCommandJSON is not a string.");
        TypeScope the_enum;
        switch (json_string.getData()[0])
          {
            case 'a':
                if ((String.Compare(json_string.getData(), 1, "ll", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeScope.Scope_all;
                        goto enum_is_done;
                      }
                break;
            case 'l':
                if ((String.Compare(json_string.getData(), 1, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeScope.Scope_last;
                        goto enum_is_done;
                      }
                break;
            case 'm':
                if ((String.Compare(json_string.getData(), 1, "ovement", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeScope.Scope_movement;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Scope of RobotStopCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setScope(the_enum);
      }


    public RobotStopCommandJSON()
      {
        flagHasAlreadyStoppedResult = false;
        flagHasScope = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRobotCommandKind()
      {
        return "StopCommand";
      }

    public bool  hasAlreadyStoppedResult()
      {
        return flagHasAlreadyStoppedResult;
      }

    public DynamicResponseJSON   getAlreadyStoppedResult()
      {
        Debug.Assert(flagHasAlreadyStoppedResult);
        return storeAlreadyStoppedResult;
      }

    public bool  hasScope()
      {
        return flagHasScope;
      }

    public TypeScope  getScope()
      {
        Debug.Assert(flagHasScope);
        return storeScope;
      }

    public string  getScopeAsString()
      {
        return stringFromScope(getScope());
      }


    public virtual int extraRobotStopCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRobotStopCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRobotStopCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRobotStopCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRobotCommandComponentCount()
      {
        int result = 0;
        if (flagHasAlreadyStoppedResult)
            ++result;
        if (flagHasScope)
            ++result;
        result += extraRobotStopCommandComponentCount();
        return result;
      }
    public override string extraRobotCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAlreadyStoppedResult)
          {
            if (remainder == 0)
                return "AlreadyStoppedResult";
            --remainder;
          }
        if (flagHasScope)
          {
            if (remainder == 0)
                return "Scope";
            --remainder;
          }
        return extraRobotStopCommandComponentKey(remainder);
      }
    public override JSONValue extraRobotCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAlreadyStoppedResult)
          {
            if (remainder == 0)
                return extraAlreadyStoppedResultToJSON();
            --remainder;
          }
        if (flagHasScope)
          {
            if (remainder == 0)
                return extraScopeToJSON();
            --remainder;
          }
        return extraRobotStopCommandComponentValue(remainder);
      }
    public override JSONValue extraRobotCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "lreadyStoppedResult", 0, 19, false) == 0) && (field_name.Length == 20))
                    return (flagHasAlreadyStoppedResult ? extraAlreadyStoppedResultToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "cope", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasScope ? extraScopeToJSON() : null);
                break;
            default:
                break;
          }
        return extraRobotStopCommandLookup(field_name);
      }

    public void setAlreadyStoppedResult(DynamicResponseJSON  new_value)
      {
        if (flagHasAlreadyStoppedResult)
          {
          }
        flagHasAlreadyStoppedResult = true;
        storeAlreadyStoppedResult = new_value;
      }
    public void unsetAlreadyStoppedResult()
      {
        if (flagHasAlreadyStoppedResult)
          {
          }
        flagHasAlreadyStoppedResult = false;
      }
    public void setScope(TypeScope new_value)
      {
        flagHasScope = true;
        storeScope = new_value;
      }
    public void setScope(string chars)
      {
        setScope(stringToScope(chars));
      }
    public void unsetScope()
      {
        flagHasScope = false;
      }

    public virtual void extraRobotStopCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRobotStopCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRobotStopCommandLookup(key);
        if (old_field == null)
          {
            extraRobotStopCommandAppendPair(key, new_component);
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
    public override void extraRobotCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "lreadyStoppedResult", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONAlreadyStoppedResult(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "cope", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONScope(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRobotStopCommandAppendPair(key, new_component);
      }
    public override void extraRobotCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "lreadyStoppedResult", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONAlreadyStoppedResult(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "cope", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONScope(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRobotStopCommandSetField(key, new_component);
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
        if (flagHasAlreadyStoppedResult)
          {
            handler.start_pair("AlreadyStoppedResult");
            if (partial_allowed)
                storeAlreadyStoppedResult.write_partial_as_json(handler);
            else
                storeAlreadyStoppedResult.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasScope);
        if (flagHasScope)
          {
            handler.start_pair("Scope");
            switch (storeScope)
              {
                case TypeScope.Scope_all:
                    handler.string_value("all");
                    break;
                case TypeScope.Scope_last:
                    handler.string_value("last");
                    break;
                case TypeScope.Scope_movement:
                    handler.string_value("movement");
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
        if (!(hasScope()))
          {
            return "When parsing the object for %what%, the \"Scope\" field was missing.";
          }
        return null;
      }

    public static new RobotStopCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotStopCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotStopCommand", ignore_extras);
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
    public static new RobotStopCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RobotStopCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotStopCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotStopCommand", ignore_extras);
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
    public static new RobotStopCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RobotStopCommandJSON from_text(string text, bool ignore_extras)
      {
        RobotStopCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotStopCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RobotStopCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RobotStopCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RobotStopCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotStopCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RobotCommandJSON.Generator
      {
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAlreadyStoppedResult;
    private abstract class FieldGeneratorScope : JSONStringGenerator
          {
            protected FieldGeneratorScope(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorScope()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToScope(result));
              }
            protected abstract void handle_result(TypeScope result);
          };
    private class FieldHoldingGeneratorScope : FieldGeneratorScope
  {
    protected override void handle_result(TypeScope result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorScope(String what)
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
    public TypeScope value;
  };
    private class FieldHoldingArrayGeneratorScope : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorScope
      {
        private FieldHoldingArrayGeneratorScope top;

        protected override void handle_result(TypeScope result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorScope init_top)
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
    protected virtual void handle_result(List<TypeScope> result)
      {
      }

    public FieldHoldingArrayGeneratorScope(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeScope>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorScope()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeScope>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeScope> value;
  };
        private FieldHoldingGeneratorScope fieldGeneratorScope;
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
            if (!(getRobotCommandJSONKey().Equals("StopCommand")))
                throw new Exception("The key field has a value other than `StopCommand'.");
            RobotStopCommandJSON result = new RobotStopCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRobotStopCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RobotCommandJSON new_result)
          {
            handle_result((RobotStopCommandJSON )new_result);
          }
        protected void finish(RobotStopCommandJSON result)
          {
            if (fieldGeneratorAlreadyStoppedResult.have_value)
              {
                result.setAlreadyStoppedResult(fieldGeneratorAlreadyStoppedResult.value);
                fieldGeneratorAlreadyStoppedResult.have_value = false;
              }
            if (fieldGeneratorScope.have_value)
              {
                result.setScope(fieldGeneratorScope.value);
                fieldGeneratorScope.have_value = false;
              }
            else if ((!(result.hasScope())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Scope\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RobotStopCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "lreadyStoppedResult", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorAlreadyStoppedResult;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "cope", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorScope;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAlreadyStoppedResult = new DynamicResponseJSON.HoldingGenerator("field \"AlreadyStoppedResult\" of the RobotStopCommand class", ignore_extras);
            fieldGeneratorScope = new FieldHoldingGeneratorScope("field \"Scope\" of the RobotStopCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RobotStopCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAlreadyStoppedResult = new DynamicResponseJSON.HoldingGenerator("field \"AlreadyStoppedResult\" of the RobotStopCommand class", false);
            fieldGeneratorScope = new FieldHoldingGeneratorScope("field \"Scope\" of the RobotStopCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RobotStopCommand class");
          }

        public override void reset()
          {
            fieldGeneratorAlreadyStoppedResult.reset();
            fieldGeneratorScope.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RobotStopCommandJSON  result)
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
        public RobotStopCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RobotStopCommandJSON  result)
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
    protected virtual void handle_result(List<RobotStopCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RobotStopCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RobotStopCommandJSON>();
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
    public List<RobotStopCommandJSON> value;
  };
  };
