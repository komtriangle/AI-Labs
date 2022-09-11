/* file "NavigationQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class NavigationQueryStateJSON : JSONBase
  {
    public enum TypeNavigationCommandKind
      {
        NavigationCommandKind_Start,
        NavigationCommandKind_NotUnderstood,
        NavigationCommandKind_Cancel
      };

    public static TypeNavigationCommandKind  stringToNavigationCommandKind(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "ancel", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeNavigationCommandKind.NavigationCommandKind_Cancel;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "otUnderstood", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeNavigationCommandKind.NavigationCommandKind_NotUnderstood;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "tart", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeNavigationCommandKind.NavigationCommandKind_Start;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `NavigationCommandKind' is not one of the legal values.");
      }

    public static string  stringFromNavigationCommandKind(TypeNavigationCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeNavigationCommandKind.NavigationCommandKind_Start:
                return "Start";
            case TypeNavigationCommandKind.NavigationCommandKind_NotUnderstood:
                return "NotUnderstood";
            case TypeNavigationCommandKind.NavigationCommandKind_Cancel:
                return "Cancel";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasNavigationCommandKind;
    private TypeNavigationCommandKind storeNavigationCommandKind;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONNavigationCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NavigationCommandKind of NavigationQueryStateJSON is not a string.");
        TypeNavigationCommandKind the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "ancel", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeNavigationCommandKind.NavigationCommandKind_Cancel;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "otUnderstood", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeNavigationCommandKind.NavigationCommandKind_NotUnderstood;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "tart", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeNavigationCommandKind.NavigationCommandKind_Start;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field NavigationCommandKind of NavigationQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setNavigationCommandKind(the_enum);
      }


    public NavigationQueryStateJSON()
      {
        flagHasNavigationCommandKind = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasNavigationCommandKind()
      {
        return flagHasNavigationCommandKind;
      }

    public TypeNavigationCommandKind  getNavigationCommandKind()
      {
        Debug.Assert(flagHasNavigationCommandKind);
        return storeNavigationCommandKind;
      }

    public string  getNavigationCommandKindAsString()
      {
        return stringFromNavigationCommandKind(getNavigationCommandKind());
      }


    public virtual int extraNavigationQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraNavigationQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraNavigationQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraNavigationQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setNavigationCommandKind(TypeNavigationCommandKind new_value)
      {
        flagHasNavigationCommandKind = true;
        storeNavigationCommandKind = new_value;
      }
    public void setNavigationCommandKind(string chars)
      {
        setNavigationCommandKind(stringToNavigationCommandKind(chars));
      }
    public void unsetNavigationCommandKind()
      {
        flagHasNavigationCommandKind = false;
      }

    public virtual void extraNavigationQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraNavigationQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraNavigationQueryStateLookup(key);
        if (old_field == null)
          {
            extraNavigationQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNavigationCommandKind);
        if (flagHasNavigationCommandKind)
          {
            handler.start_pair("NavigationCommandKind");
            switch (storeNavigationCommandKind)
              {
                case TypeNavigationCommandKind.NavigationCommandKind_Start:
                    handler.string_value("Start");
                    break;
                case TypeNavigationCommandKind.NavigationCommandKind_NotUnderstood:
                    handler.string_value("NotUnderstood");
                    break;
                case TypeNavigationCommandKind.NavigationCommandKind_Cancel:
                    handler.string_value("Cancel");
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
        if (!(hasNavigationCommandKind()))
          {
            return "When parsing the object for %what%, the \"NavigationCommandKind\" field was missing.";
          }
        return null;
      }

    public static NavigationQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NavigationQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NavigationQueryState", ignore_extras);
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
    public static NavigationQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NavigationQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NavigationQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NavigationQueryState", ignore_extras);
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
    public static NavigationQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NavigationQueryStateJSON from_text(string text, bool ignore_extras)
      {
        NavigationQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NavigationQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NavigationQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static NavigationQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NavigationQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NavigationQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorNavigationCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorNavigationCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNavigationCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNavigationCommandKind(result));
              }
            protected abstract void handle_result(TypeNavigationCommandKind result);
          };
    private class FieldHoldingGeneratorNavigationCommandKind : FieldGeneratorNavigationCommandKind
  {
    protected override void handle_result(TypeNavigationCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNavigationCommandKind(String what)
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
    public TypeNavigationCommandKind value;
  };
    private class FieldHoldingArrayGeneratorNavigationCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNavigationCommandKind
      {
        private FieldHoldingArrayGeneratorNavigationCommandKind top;

        protected override void handle_result(TypeNavigationCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNavigationCommandKind init_top)
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
    protected virtual void handle_result(List<TypeNavigationCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorNavigationCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNavigationCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNavigationCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNavigationCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNavigationCommandKind> value;
  };
        private FieldHoldingGeneratorNavigationCommandKind fieldGeneratorNavigationCommandKind;
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
            NavigationQueryStateJSON result = new NavigationQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraNavigationQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(NavigationQueryStateJSON result)
          {
            if (fieldGeneratorNavigationCommandKind.have_value)
              {
                result.setNavigationCommandKind(fieldGeneratorNavigationCommandKind.value);
                fieldGeneratorNavigationCommandKind.have_value = false;
              }
            else if ((!(result.hasNavigationCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NavigationCommandKind\" field was missing.");
              }
          }
        protected abstract void handle_result(NavigationQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NavigationCommandKind", 0, 21, false) == 0) && (field_name.Length == 21))
                return fieldGeneratorNavigationCommandKind;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorNavigationCommandKind = new FieldHoldingGeneratorNavigationCommandKind("field \"NavigationCommandKind\" of the NavigationQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the NavigationQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorNavigationCommandKind = new FieldHoldingGeneratorNavigationCommandKind("field \"NavigationCommandKind\" of the NavigationQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the NavigationQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorNavigationCommandKind.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(NavigationQueryStateJSON  result)
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
        public NavigationQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NavigationQueryStateJSON  result)
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
    protected virtual void handle_result(List<NavigationQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NavigationQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NavigationQueryStateJSON>();
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
    public List<NavigationQueryStateJSON> value;
  };
  };
