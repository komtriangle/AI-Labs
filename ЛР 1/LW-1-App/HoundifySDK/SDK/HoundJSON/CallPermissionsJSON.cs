/* file "CallPermissionsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CallPermissionsJSON : JSONBase
  {
    public enum TypeLocalPlaceKnownValues
      {
        LocalPlace_Always,
        LocalPlace_WithContext,
        LocalPlace_Never,
        LocalPlace__none
      };
    public struct TypeLocalPlace
      {
        public bool in_known_list;
        public string string_value;
        public TypeLocalPlaceKnownValues list_value;
      };

    public static TypeLocalPlaceKnownValues  stringToLocalPlace(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "lways", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeLocalPlaceKnownValues.LocalPlace_Always;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "ever", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeLocalPlaceKnownValues.LocalPlace_Never;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "ithContext", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeLocalPlaceKnownValues.LocalPlace_WithContext;
                break;
            default:
                break;
          }
        return TypeLocalPlaceKnownValues.LocalPlace__none;
      }

    public static string  stringFromLocalPlace(TypeLocalPlaceKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeLocalPlaceKnownValues.LocalPlace_Always:
                return "Always";
            case TypeLocalPlaceKnownValues.LocalPlace_WithContext:
                return "WithContext";
            case TypeLocalPlaceKnownValues.LocalPlace_Never:
                return "Never";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasLocalPlace;
    private TypeLocalPlace storeLocalPlace;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLocalPlace(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocalPlace of CallPermissionsJSON is not a string.");
        TypeLocalPlace the_open_enum = new TypeLocalPlace();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "lways", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLocalPlaceKnownValues.LocalPlace_Always;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "ever", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLocalPlaceKnownValues.LocalPlace_Never;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "ithContext", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLocalPlaceKnownValues.LocalPlace_WithContext;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setLocalPlace(the_open_enum);
      }


    public CallPermissionsJSON()
      {
        flagHasLocalPlace = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLocalPlace()
      {
        return flagHasLocalPlace;
      }

    public TypeLocalPlace  getLocalPlace()
      {
        Debug.Assert(flagHasLocalPlace);
        return storeLocalPlace;
      }

    public string  getLocalPlaceAsString()
      {
        TypeLocalPlace result = getLocalPlace();
        if (result.in_known_list)
            return stringFromLocalPlace(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraCallPermissionsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCallPermissionsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCallPermissionsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCallPermissionsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLocalPlace(TypeLocalPlace new_value)
      {
        flagHasLocalPlace = true;
        storeLocalPlace = new_value;
      }
    public void setLocalPlace(string chars)
      {
        TypeLocalPlaceKnownValues known = stringToLocalPlace(chars);
        TypeLocalPlace new_value = new TypeLocalPlace();
        if (known == TypeLocalPlaceKnownValues.LocalPlace__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setLocalPlace(new_value);
      }
    public void setLocalPlace(TypeLocalPlaceKnownValues new_value)
      {
        TypeLocalPlace new_full_value = new TypeLocalPlace();
        Debug.Assert(new_value != TypeLocalPlaceKnownValues.LocalPlace__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setLocalPlace(new_full_value);
      }
    public void unsetLocalPlace()
      {
        flagHasLocalPlace = false;
      }

    public virtual void extraCallPermissionsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCallPermissionsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCallPermissionsLookup(key);
        if (old_field == null)
          {
            extraCallPermissionsAppendPair(key, new_component);
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
        if (flagHasLocalPlace)
          {
            handler.start_pair("LocalPlace");
            if (storeLocalPlace.in_known_list)
              {
                switch (storeLocalPlace.list_value)
                  {
                    case TypeLocalPlaceKnownValues.LocalPlace_Always:
                        handler.string_value("Always");
                        break;
                    case TypeLocalPlaceKnownValues.LocalPlace_WithContext:
                        handler.string_value("WithContext");
                        break;
                    case TypeLocalPlaceKnownValues.LocalPlace_Never:
                        handler.string_value("Never");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeLocalPlace.string_value);
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
        return null;
      }

    public static CallPermissionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CallPermissionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CallPermissions", ignore_extras);
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
    public static CallPermissionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CallPermissionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CallPermissionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CallPermissions", ignore_extras);
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
    public static CallPermissionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CallPermissionsJSON from_text(string text, bool ignore_extras)
      {
        CallPermissionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CallPermissions", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CallPermissionsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CallPermissionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CallPermissionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CallPermissions", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorLocalPlace : JSONStringGenerator
          {
            protected FieldGeneratorLocalPlace(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLocalPlace()
              {
              }
            protected override void handle_result(string result)
              {
                TypeLocalPlaceKnownValues known = stringToLocalPlace(result);
                TypeLocalPlace new_value = new TypeLocalPlace();
                if (known == TypeLocalPlaceKnownValues.LocalPlace__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeLocalPlace result);
          };
    private class FieldHoldingGeneratorLocalPlace : FieldGeneratorLocalPlace
  {
    protected override void handle_result(TypeLocalPlace result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLocalPlace(String what)
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
    public TypeLocalPlace value;
  };
    private class FieldHoldingArrayGeneratorLocalPlace : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLocalPlace
      {
        private FieldHoldingArrayGeneratorLocalPlace top;

        protected override void handle_result(TypeLocalPlace result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLocalPlace init_top)
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
    protected virtual void handle_result(List<TypeLocalPlace> result)
      {
      }

    public FieldHoldingArrayGeneratorLocalPlace(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLocalPlace>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLocalPlace()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLocalPlace>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLocalPlace> value;
  };
        private FieldHoldingGeneratorLocalPlace fieldGeneratorLocalPlace;
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
            CallPermissionsJSON result = new CallPermissionsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCallPermissionsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CallPermissionsJSON result)
          {
            if (fieldGeneratorLocalPlace.have_value)
              {
                result.setLocalPlace(fieldGeneratorLocalPlace.value);
                fieldGeneratorLocalPlace.have_value = false;
              }
          }
        protected abstract void handle_result(CallPermissionsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "LocalPlace", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorLocalPlace;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLocalPlace = new FieldHoldingGeneratorLocalPlace("field \"LocalPlace\" of the CallPermissions class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CallPermissions class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLocalPlace = new FieldHoldingGeneratorLocalPlace("field \"LocalPlace\" of the CallPermissions class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CallPermissions class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLocalPlace.reset();
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
        protected override void handle_result(CallPermissionsJSON  result)
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
        public CallPermissionsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CallPermissionsJSON  result)
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
    protected virtual void handle_result(List<CallPermissionsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CallPermissionsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CallPermissionsJSON>();
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
    public List<CallPermissionsJSON> value;
  };
  };
