/* file "WebSearchRequestInfoProvidersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WebSearchRequestInfoProvidersJSON : JSONBase
  {
    public enum TypeProvidersKnownValues
      {
        Providers_Bing,
        Providers_Google,
        Providers_Yahoo,
        Providers_Baidu,
        Providers__none
      };
    public struct TypeProviders
      {
        public bool in_known_list;
        public string string_value;
        public TypeProvidersKnownValues list_value;
      };

    public static TypeProvidersKnownValues  stringToProviders(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "idu", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeProvidersKnownValues.Providers_Baidu;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "ng", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeProvidersKnownValues.Providers_Bing;
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                if ((String.Compare(chars, 1, "oogle", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeProvidersKnownValues.Providers_Google;
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "ahoo", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeProvidersKnownValues.Providers_Yahoo;
                break;
            default:
                break;
          }
        return TypeProvidersKnownValues.Providers__none;
      }

    public static string  stringFromProviders(TypeProvidersKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeProvidersKnownValues.Providers_Bing:
                return "Bing";
            case TypeProvidersKnownValues.Providers_Google:
                return "Google";
            case TypeProvidersKnownValues.Providers_Yahoo:
                return "Yahoo";
            case TypeProvidersKnownValues.Providers_Baidu:
                return "Baidu";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasProviders;
    private List< TypeProviders > storeProviders;
    private bool flagHasOverrideExplicitlyNamedProviders;
    private bool storeOverrideExplicitlyNamedProviders;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONProviders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Providers of WebSearchRequestInfoProvidersJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeProviders > vector_Providers1 = new List< TypeProviders >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Providers of WebSearchRequestInfoProvidersJSON is not a string.");
            TypeProviders the_open_enum = new TypeProviders();
            switch (json_string.getData()[0])
              {
                case 'B':
                    switch (json_string.getData()[1])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 2, "idu", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeProvidersKnownValues.Providers_Baidu;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'i':
                            if ((String.Compare(json_string.getData(), 2, "ng", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeProvidersKnownValues.Providers_Bing;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'G':
                    if ((String.Compare(json_string.getData(), 1, "oogle", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeProvidersKnownValues.Providers_Google;
                            goto open_enum_is_done;
                          }
                    break;
                case 'Y':
                    if ((String.Compare(json_string.getData(), 1, "ahoo", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeProvidersKnownValues.Providers_Yahoo;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            vector_Providers1.Add(the_open_enum);
          }
        initProviders();
        for (int num1 = 0; num1 < vector_Providers1.Count; ++num1)
            appendProviders(vector_Providers1[num1]);
        for (int num1 = 0; num1 < vector_Providers1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOverrideExplicitlyNamedProviders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field OverrideExplicitlyNamedProviders of WebSearchRequestInfoProvidersJSON is not true for false.");
              }
          }
        setOverrideExplicitlyNamedProviders(the_bool);
      }


    public WebSearchRequestInfoProvidersJSON()
      {
        flagHasProviders = false;
        flagHasOverrideExplicitlyNamedProviders = false;
        storeProviders = new List< TypeProviders >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasProviders()
      {
        return flagHasProviders;
      }

    public int  countOfProviders()
      {
        Debug.Assert(flagHasProviders);
        return storeProviders.Count;
      }

    public TypeProviders  elementOfProviders(int element_num)
      {
        Debug.Assert(flagHasProviders);
        return storeProviders[element_num];
      }

    public List< TypeProviders >  getProviders()
      {
        Debug.Assert(flagHasProviders);
        return storeProviders;
      }

    public bool  hasOverrideExplicitlyNamedProviders()
      {
        return flagHasOverrideExplicitlyNamedProviders;
      }

    public bool  getOverrideExplicitlyNamedProviders()
      {
        Debug.Assert(flagHasOverrideExplicitlyNamedProviders);
        return storeOverrideExplicitlyNamedProviders;
      }


    public virtual int extraWebSearchRequestInfoProvidersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWebSearchRequestInfoProvidersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWebSearchRequestInfoProvidersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWebSearchRequestInfoProvidersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initProviders()
      {
        flagHasProviders = true;
        storeProviders.Clear();
      }
    public void appendProviders(TypeProviders to_append)
      {
        if (!flagHasProviders)
          {
            flagHasProviders = true;
            storeProviders.Clear();
          }
        Debug.Assert(flagHasProviders);
        storeProviders.Add(to_append);
      }
    public void appendProviders(string chars)
      {
        TypeProvidersKnownValues known = stringToProviders(chars);
        TypeProviders new_value = new TypeProviders();
        if (known == TypeProvidersKnownValues.Providers__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendProviders(new_value);
      }
    public void appendProviders(TypeProvidersKnownValues new_value)
      {
        TypeProviders new_full_value = new TypeProviders();
        Debug.Assert(new_value != TypeProvidersKnownValues.Providers__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        appendProviders(new_full_value);
      }
    public void unsetProviders()
      {
        flagHasProviders = false;
        storeProviders.Clear();
      }
    public void setOverrideExplicitlyNamedProviders(bool new_value)
      {
        flagHasOverrideExplicitlyNamedProviders = true;
        storeOverrideExplicitlyNamedProviders = new_value;
      }
    public void unsetOverrideExplicitlyNamedProviders()
      {
        flagHasOverrideExplicitlyNamedProviders = false;
      }

    public virtual void extraWebSearchRequestInfoProvidersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWebSearchRequestInfoProvidersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWebSearchRequestInfoProvidersLookup(key);
        if (old_field == null)
          {
            extraWebSearchRequestInfoProvidersAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasProviders);
        if (flagHasProviders)
          {
            handler.start_pair("Providers");
            handler.start_array();
            for (int num1 = 0; num1 < storeProviders.Count; ++num1)
              {
                if (storeProviders[num1].in_known_list)
                  {
                    switch (storeProviders[num1].list_value)
                      {
                        case TypeProvidersKnownValues.Providers_Bing:
                            handler.string_value("Bing");
                            break;
                        case TypeProvidersKnownValues.Providers_Google:
                            handler.string_value("Google");
                            break;
                        case TypeProvidersKnownValues.Providers_Yahoo:
                            handler.string_value("Yahoo");
                            break;
                        case TypeProvidersKnownValues.Providers_Baidu:
                            handler.string_value("Baidu");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeProviders[num1].string_value);
                  }
              }
            handler.finish_array();
          }
        if (flagHasOverrideExplicitlyNamedProviders)
          {
            handler.start_pair("OverrideExplicitlyNamedProviders");
            handler.boolean_value(storeOverrideExplicitlyNamedProviders);
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
        if (!(hasProviders()))
          {
            return "When parsing the object for %what%, the \"Providers\" field was missing.";
          }
        return null;
      }

    public static WebSearchRequestInfoProvidersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WebSearchRequestInfoProvidersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WebSearchRequestInfoProviders", ignore_extras);
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
    public static WebSearchRequestInfoProvidersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WebSearchRequestInfoProvidersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WebSearchRequestInfoProvidersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WebSearchRequestInfoProviders", ignore_extras);
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
    public static WebSearchRequestInfoProvidersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WebSearchRequestInfoProvidersJSON from_text(string text, bool ignore_extras)
      {
        WebSearchRequestInfoProvidersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WebSearchRequestInfoProviders", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WebSearchRequestInfoProvidersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WebSearchRequestInfoProvidersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WebSearchRequestInfoProvidersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WebSearchRequestInfoProviders", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorProviders : JSONStringGenerator
          {
            protected FieldGeneratorProviders(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorProviders()
              {
              }
            protected override void handle_result(string result)
              {
                TypeProvidersKnownValues known = stringToProviders(result);
                TypeProviders new_value = new TypeProviders();
                if (known == TypeProvidersKnownValues.Providers__none)
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
            protected abstract void handle_result(TypeProviders result);
          };
    private class FieldHoldingGeneratorProviders : FieldGeneratorProviders
  {
    protected override void handle_result(TypeProviders result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorProviders(String what)
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
    public TypeProviders value;
  };
    private class FieldHoldingArrayGeneratorProviders : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorProviders
      {
        private FieldHoldingArrayGeneratorProviders top;

        protected override void handle_result(TypeProviders result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorProviders init_top)
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
    protected virtual void handle_result(List<TypeProviders> result)
      {
      }

    public FieldHoldingArrayGeneratorProviders(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeProviders>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorProviders()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeProviders>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeProviders> value;
  };
        private FieldHoldingArrayGeneratorProviders fieldGeneratorProviders;
        private JSONHoldingBooleanGenerator fieldGeneratorOverrideExplicitlyNamedProviders;
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
            WebSearchRequestInfoProvidersJSON result = new WebSearchRequestInfoProvidersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWebSearchRequestInfoProvidersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WebSearchRequestInfoProvidersJSON result)
          {
            if (fieldGeneratorProviders.have_value)
              {
                result.initProviders();
                int count = fieldGeneratorProviders.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendProviders(fieldGeneratorProviders.value[num]);
                  }
                fieldGeneratorProviders.value.Clear();
                fieldGeneratorProviders.have_value = false;
              }
            else if ((!(result.hasProviders())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Providers\" field was missing.");
              }
            if (fieldGeneratorOverrideExplicitlyNamedProviders.have_value)
              {
                result.setOverrideExplicitlyNamedProviders(fieldGeneratorOverrideExplicitlyNamedProviders.value);
                fieldGeneratorOverrideExplicitlyNamedProviders.have_value = false;
              }
          }
        protected abstract void handle_result(WebSearchRequestInfoProvidersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'O':
                    if ((String.Compare(field_name, 1, "verrideExplicitlyNamedProviders", 0, 31, false) == 0) && (field_name.Length == 32))
                        return fieldGeneratorOverrideExplicitlyNamedProviders;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "roviders", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorProviders;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorProviders = new FieldHoldingArrayGeneratorProviders("field \"Providers\" of the WebSearchRequestInfoProviders class");
            fieldGeneratorOverrideExplicitlyNamedProviders = new JSONHoldingBooleanGenerator("field \"OverrideExplicitlyNamedProviders\" of the WebSearchRequestInfoProviders class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WebSearchRequestInfoProviders class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorProviders = new FieldHoldingArrayGeneratorProviders("field \"Providers\" of the WebSearchRequestInfoProviders class");
            fieldGeneratorOverrideExplicitlyNamedProviders = new JSONHoldingBooleanGenerator("field \"OverrideExplicitlyNamedProviders\" of the WebSearchRequestInfoProviders class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WebSearchRequestInfoProviders class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorProviders.reset();
            fieldGeneratorOverrideExplicitlyNamedProviders.reset();
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
        protected override void handle_result(WebSearchRequestInfoProvidersJSON  result)
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
        public WebSearchRequestInfoProvidersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WebSearchRequestInfoProvidersJSON  result)
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
    protected virtual void handle_result(List<WebSearchRequestInfoProvidersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WebSearchRequestInfoProvidersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WebSearchRequestInfoProvidersJSON>();
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
    public List<WebSearchRequestInfoProvidersJSON> value;
  };
  };
