/* file "MonetaryUnitsPropertyJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MonetaryUnitsPropertyJSON : PropertyJSON
  {
    public enum TypeTagKnownValues
      {
        Tag_currency,
        Tag__none
      };
    public struct TypeTag
      {
        public bool in_known_list;
        public string string_value;
        public TypeTagKnownValues list_value;
      };

    public static TypeTagKnownValues  stringToTag(string chars)
      {
        if ((String.Compare(chars, 0, "currency", 0, 8, false) == 0) && (chars.Length == 8))
            return TypeTagKnownValues.Tag_currency;
        return TypeTagKnownValues.Tag__none;
      }

    public static string  stringFromTag(TypeTagKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTagKnownValues.Tag_currency:
                return "currency";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTag;
    private TypeTag storeTag;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraTagToJSON()
      {
        JSONStringValue generated_string_Tag;
        if (!(storeTag.in_known_list))
          {
        generated_string_Tag = new JSONStringValue(storeTag.string_value);
          }
        else
          {
        switch (storeTag.list_value)
          {
            case TypeTagKnownValues.Tag_currency:
                generated_string_Tag = new JSONStringValue("currency");
                break;
            default:
                Debug.Assert(false);
                generated_string_Tag = null;
                break;
          }
          }
        return generated_string_Tag;
      }


    private void  fromJSONTag(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Tag of MonetaryUnitsPropertyJSON is not a string.");
        TypeTag the_open_enum = new TypeTag();
        if ((String.Compare(json_string.getData(), 0, "currency", 0, 8, false) == 0) && (json_string.getData().Length == 8))
              {
                the_open_enum.in_known_list = true;
                the_open_enum.list_value = TypeTagKnownValues.Tag_currency;
                goto open_enum_is_done;
              }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setTag(the_open_enum);
      }


    public MonetaryUnitsPropertyJSON()
      {
        flagHasTag = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPropertyKind()
      {
        return "Monetary";
      }

    public bool  hasTag()
      {
        return flagHasTag;
      }

    public TypeTag  getTag()
      {
        Debug.Assert(flagHasTag);
        return storeTag;
      }

    public string  getTagAsString()
      {
        TypeTag result = getTag();
        if (result.in_known_list)
            return stringFromTag(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraMonetaryUnitsPropertyComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMonetaryUnitsPropertyComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMonetaryUnitsPropertyComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMonetaryUnitsPropertyLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPropertyComponentCount()
      {
        int result = 0;
        if (flagHasTag)
            ++result;
        result += extraMonetaryUnitsPropertyComponentCount();
        return result;
      }
    public override string extraPropertyComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasTag)
          {
            if (remainder == 0)
                return "Tag";
            --remainder;
          }
        return extraMonetaryUnitsPropertyComponentKey(remainder);
      }
    public override JSONValue extraPropertyComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasTag)
          {
            if (remainder == 0)
                return extraTagToJSON();
            --remainder;
          }
        return extraMonetaryUnitsPropertyComponentValue(remainder);
      }
    public override JSONValue extraPropertyLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Tag", 0, 3, false) == 0) && (field_name.Length == 3))
            return (flagHasTag ? extraTagToJSON() : null);
        return extraMonetaryUnitsPropertyLookup(field_name);
      }

    public void setTag(TypeTag new_value)
      {
        flagHasTag = true;
        storeTag = new_value;
      }
    public void setTag(string chars)
      {
        TypeTagKnownValues known = stringToTag(chars);
        TypeTag new_value = new TypeTag();
        if (known == TypeTagKnownValues.Tag__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setTag(new_value);
      }
    public void setTag(TypeTagKnownValues new_value)
      {
        TypeTag new_full_value = new TypeTag();
        Debug.Assert(new_value != TypeTagKnownValues.Tag__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setTag(new_full_value);
      }
    public void unsetTag()
      {
        flagHasTag = false;
      }

    public virtual void extraMonetaryUnitsPropertyAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMonetaryUnitsPropertySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMonetaryUnitsPropertyLookup(key);
        if (old_field == null)
          {
            extraMonetaryUnitsPropertyAppendPair(key, new_component);
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
    public override void extraPropertyAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Tag", 0, 3, false) == 0) && (key.Length == 3))
            {
            fromJSONTag(new_component, false);
            return;
            }
        extraMonetaryUnitsPropertyAppendPair(key, new_component);
      }
    public override void extraPropertySetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Tag", 0, 3, false) == 0) && (key.Length == 3))
            {
            fromJSONTag(new_component, false);
            return;
            }
        extraMonetaryUnitsPropertySetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTag);
        if (flagHasTag)
          {
            handler.start_pair("Tag");
            if (storeTag.in_known_list)
              {
                switch (storeTag.list_value)
                  {
                    case TypeTagKnownValues.Tag_currency:
                        handler.string_value("currency");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeTag.string_value);
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
        if (!(hasTag()))
          {
            return "When parsing the object for %what%, the \"Tag\" field was missing.";
          }
        return null;
      }

    public static new MonetaryUnitsPropertyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MonetaryUnitsPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryUnitsProperty", ignore_extras);
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
    public static new MonetaryUnitsPropertyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MonetaryUnitsPropertyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MonetaryUnitsPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryUnitsProperty", ignore_extras);
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
    public static new MonetaryUnitsPropertyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MonetaryUnitsPropertyJSON from_text(string text, bool ignore_extras)
      {
        MonetaryUnitsPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryUnitsProperty", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MonetaryUnitsPropertyJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MonetaryUnitsPropertyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MonetaryUnitsPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryUnitsProperty", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PropertyJSON.Generator
      {
    private abstract class FieldGeneratorTag : JSONStringGenerator
          {
            protected FieldGeneratorTag(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTag()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTagKnownValues known = stringToTag(result);
                TypeTag new_value = new TypeTag();
                if (known == TypeTagKnownValues.Tag__none)
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
            protected abstract void handle_result(TypeTag result);
          };
    private class FieldHoldingGeneratorTag : FieldGeneratorTag
  {
    protected override void handle_result(TypeTag result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTag(String what)
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
    public TypeTag value;
  };
    private class FieldHoldingArrayGeneratorTag : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTag
      {
        private FieldHoldingArrayGeneratorTag top;

        protected override void handle_result(TypeTag result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTag init_top)
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
    protected virtual void handle_result(List<TypeTag> result)
      {
      }

    public FieldHoldingArrayGeneratorTag(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTag>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTag()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTag>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTag> value;
  };
        private FieldHoldingGeneratorTag fieldGeneratorTag;
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
            if (!(getPropertyJSONKey().Equals("Monetary")))
                throw new Exception("The key field has a value other than `Monetary'.");
            MonetaryUnitsPropertyJSON result = new MonetaryUnitsPropertyJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMonetaryUnitsPropertyAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PropertyJSON new_result)
          {
            handle_result((MonetaryUnitsPropertyJSON )new_result);
          }
        protected void finish(MonetaryUnitsPropertyJSON result)
          {
            if (fieldGeneratorTag.have_value)
              {
                result.setTag(fieldGeneratorTag.value);
                fieldGeneratorTag.have_value = false;
              }
            else if ((!(result.hasTag())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Tag\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MonetaryUnitsPropertyJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Tag", 0, 3, false) == 0) && (field_name.Length == 3))
                return fieldGeneratorTag;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorTag = new FieldHoldingGeneratorTag("field \"Tag\" of the MonetaryUnitsProperty class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MonetaryUnitsProperty class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorTag = new FieldHoldingGeneratorTag("field \"Tag\" of the MonetaryUnitsProperty class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MonetaryUnitsProperty class");
          }

        public override void reset()
          {
            fieldGeneratorTag.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MonetaryUnitsPropertyJSON  result)
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
        public MonetaryUnitsPropertyJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MonetaryUnitsPropertyJSON  result)
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
    protected virtual void handle_result(List<MonetaryUnitsPropertyJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MonetaryUnitsPropertyJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MonetaryUnitsPropertyJSON>();
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
    public List<MonetaryUnitsPropertyJSON> value;
  };
  };
