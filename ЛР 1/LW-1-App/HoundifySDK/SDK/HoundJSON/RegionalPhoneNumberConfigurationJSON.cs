/* file "RegionalPhoneNumberConfigurationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RegionalPhoneNumberConfigurationJSON : JSONBase
  {
    public enum TypeFormatsKnownValues
      {
        Formats_INDIA_FORMAT,
        Formats__none
      };
    public struct TypeFormats
      {
        public bool in_known_list;
        public string string_value;
        public TypeFormatsKnownValues list_value;
      };

    public static TypeFormatsKnownValues  stringToFormats(string chars)
      {
        if ((String.Compare(chars, 0, "INDIA_FORMAT", 0, 12, false) == 0) && (chars.Length == 12))
            return TypeFormatsKnownValues.Formats_INDIA_FORMAT;
        return TypeFormatsKnownValues.Formats__none;
      }

    public static string  stringFromFormats(TypeFormatsKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeFormatsKnownValues.Formats_INDIA_FORMAT:
                return "INDIA_FORMAT";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFormats;
    private List< TypeFormats > storeFormats;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFormats(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Formats of RegionalPhoneNumberConfigurationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeFormats > vector_Formats1 = new List< TypeFormats >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Formats of RegionalPhoneNumberConfigurationJSON is not a string.");
            TypeFormats the_open_enum = new TypeFormats();
            if ((String.Compare(json_string.getData(), 0, "INDIA_FORMAT", 0, 12, false) == 0) && (json_string.getData().Length == 12))
                  {
                    the_open_enum.in_known_list = true;
                    the_open_enum.list_value = TypeFormatsKnownValues.Formats_INDIA_FORMAT;
                    goto open_enum_is_done;
                  }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            vector_Formats1.Add(the_open_enum);
          }
        initFormats();
        for (int num1 = 0; num1 < vector_Formats1.Count; ++num1)
            appendFormats(vector_Formats1[num1]);
        for (int num1 = 0; num1 < vector_Formats1.Count; ++num1)
          {
          }
      }


    public RegionalPhoneNumberConfigurationJSON()
      {
        flagHasFormats = false;
        storeFormats = new List< TypeFormats >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFormats()
      {
        return flagHasFormats;
      }

    public int  countOfFormats()
      {
        Debug.Assert(flagHasFormats);
        return storeFormats.Count;
      }

    public TypeFormats  elementOfFormats(int element_num)
      {
        Debug.Assert(flagHasFormats);
        return storeFormats[element_num];
      }

    public List< TypeFormats >  getFormats()
      {
        Debug.Assert(flagHasFormats);
        return storeFormats;
      }


    public virtual int extraRegionalPhoneNumberConfigurationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRegionalPhoneNumberConfigurationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRegionalPhoneNumberConfigurationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRegionalPhoneNumberConfigurationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initFormats()
      {
        flagHasFormats = true;
        storeFormats.Clear();
      }
    public void appendFormats(TypeFormats to_append)
      {
        if (!flagHasFormats)
          {
            flagHasFormats = true;
            storeFormats.Clear();
          }
        Debug.Assert(flagHasFormats);
        storeFormats.Add(to_append);
      }
    public void appendFormats(string chars)
      {
        TypeFormatsKnownValues known = stringToFormats(chars);
        TypeFormats new_value = new TypeFormats();
        if (known == TypeFormatsKnownValues.Formats__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendFormats(new_value);
      }
    public void appendFormats(TypeFormatsKnownValues new_value)
      {
        TypeFormats new_full_value = new TypeFormats();
        Debug.Assert(new_value != TypeFormatsKnownValues.Formats__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        appendFormats(new_full_value);
      }
    public void unsetFormats()
      {
        flagHasFormats = false;
        storeFormats.Clear();
      }

    public virtual void extraRegionalPhoneNumberConfigurationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRegionalPhoneNumberConfigurationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRegionalPhoneNumberConfigurationLookup(key);
        if (old_field == null)
          {
            extraRegionalPhoneNumberConfigurationAppendPair(key, new_component);
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
        if (flagHasFormats)
          {
            handler.start_pair("Formats");
            handler.start_array();
            for (int num1 = 0; num1 < storeFormats.Count; ++num1)
              {
                if (storeFormats[num1].in_known_list)
                  {
                    switch (storeFormats[num1].list_value)
                      {
                        case TypeFormatsKnownValues.Formats_INDIA_FORMAT:
                            handler.string_value("INDIA_FORMAT");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeFormats[num1].string_value);
                  }
              }
            handler.finish_array();
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

    public static RegionalPhoneNumberConfigurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RegionalPhoneNumberConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RegionalPhoneNumberConfiguration", ignore_extras);
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
    public static RegionalPhoneNumberConfigurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RegionalPhoneNumberConfigurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RegionalPhoneNumberConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RegionalPhoneNumberConfiguration", ignore_extras);
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
    public static RegionalPhoneNumberConfigurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RegionalPhoneNumberConfigurationJSON from_text(string text, bool ignore_extras)
      {
        RegionalPhoneNumberConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RegionalPhoneNumberConfiguration", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RegionalPhoneNumberConfigurationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RegionalPhoneNumberConfigurationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RegionalPhoneNumberConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RegionalPhoneNumberConfiguration", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorFormats : JSONStringGenerator
          {
            protected FieldGeneratorFormats(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFormats()
              {
              }
            protected override void handle_result(string result)
              {
                TypeFormatsKnownValues known = stringToFormats(result);
                TypeFormats new_value = new TypeFormats();
                if (known == TypeFormatsKnownValues.Formats__none)
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
            protected abstract void handle_result(TypeFormats result);
          };
    private class FieldHoldingGeneratorFormats : FieldGeneratorFormats
  {
    protected override void handle_result(TypeFormats result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFormats(String what)
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
    public TypeFormats value;
  };
    private class FieldHoldingArrayGeneratorFormats : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFormats
      {
        private FieldHoldingArrayGeneratorFormats top;

        protected override void handle_result(TypeFormats result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFormats init_top)
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
    protected virtual void handle_result(List<TypeFormats> result)
      {
      }

    public FieldHoldingArrayGeneratorFormats(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormats>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFormats()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormats>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFormats> value;
  };
        private FieldHoldingArrayGeneratorFormats fieldGeneratorFormats;
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
            RegionalPhoneNumberConfigurationJSON result = new RegionalPhoneNumberConfigurationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRegionalPhoneNumberConfigurationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RegionalPhoneNumberConfigurationJSON result)
          {
            if (fieldGeneratorFormats.have_value)
              {
                result.initFormats();
                int count = fieldGeneratorFormats.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFormats(fieldGeneratorFormats.value[num]);
                  }
                fieldGeneratorFormats.value.Clear();
                fieldGeneratorFormats.have_value = false;
              }
          }
        protected abstract void handle_result(RegionalPhoneNumberConfigurationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Formats", 0, 7, false) == 0) && (field_name.Length == 7))
                return fieldGeneratorFormats;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFormats = new FieldHoldingArrayGeneratorFormats("field \"Formats\" of the RegionalPhoneNumberConfiguration class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RegionalPhoneNumberConfiguration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFormats = new FieldHoldingArrayGeneratorFormats("field \"Formats\" of the RegionalPhoneNumberConfiguration class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RegionalPhoneNumberConfiguration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFormats.reset();
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
        protected override void handle_result(RegionalPhoneNumberConfigurationJSON  result)
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
        public RegionalPhoneNumberConfigurationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RegionalPhoneNumberConfigurationJSON  result)
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
    protected virtual void handle_result(List<RegionalPhoneNumberConfigurationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RegionalPhoneNumberConfigurationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RegionalPhoneNumberConfigurationJSON>();
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
    public List<RegionalPhoneNumberConfigurationJSON> value;
  };
  };
