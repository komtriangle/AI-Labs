/* file "ChineseZodiacNoSuchSignInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ChineseZodiacNoSuchSignInfoNuggetJSON : ChineseZodiacInfoNuggetJSON
  {
    private bool flagHasInputZodiacSign;
    private string storeInputZodiacSign;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraInputZodiacSignToJSON()
      {
        JSONStringValue generated_string_InputZodiacSign = new JSONStringValue(storeInputZodiacSign);
        return generated_string_InputZodiacSign;
      }


    private void  fromJSONInputZodiacSign(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InputZodiacSign of ChineseZodiacNoSuchSignInfoNuggetJSON is not a string.");
        setInputZodiacSign(json_string.getData());
      }


    public ChineseZodiacNoSuchSignInfoNuggetJSON()
      {
        flagHasInputZodiacSign = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getChineseZodiacInfoNuggetKind()
      {
        return "ChineseZodiacNoSuchSignInfoNugget";
      }

    public bool  hasInputZodiacSign()
      {
        return flagHasInputZodiacSign;
      }

    public string  getInputZodiacSign()
      {
        Debug.Assert(flagHasInputZodiacSign);
        return storeInputZodiacSign;
      }


    public virtual int extraChineseZodiacNoSuchSignInfoNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChineseZodiacNoSuchSignInfoNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChineseZodiacNoSuchSignInfoNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChineseZodiacNoSuchSignInfoNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraChineseZodiacInfoNuggetComponentCount()
      {
        int result = 0;
        if (flagHasInputZodiacSign)
            ++result;
        result += extraChineseZodiacNoSuchSignInfoNuggetComponentCount();
        return result;
      }
    public override string extraChineseZodiacInfoNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasInputZodiacSign)
          {
            if (remainder == 0)
                return "InputZodiacSign";
            --remainder;
          }
        return extraChineseZodiacNoSuchSignInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraChineseZodiacInfoNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasInputZodiacSign)
          {
            if (remainder == 0)
                return extraInputZodiacSignToJSON();
            --remainder;
          }
        return extraChineseZodiacNoSuchSignInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraChineseZodiacInfoNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "InputZodiacSign", 0, 15, false) == 0) && (field_name.Length == 15))
            return (flagHasInputZodiacSign ? extraInputZodiacSignToJSON() : null);
        return extraChineseZodiacNoSuchSignInfoNuggetLookup(field_name);
      }

    public void setInputZodiacSign(string new_value)
      {
        flagHasInputZodiacSign = true;
        storeInputZodiacSign = new_value;
      }
    public void unsetInputZodiacSign()
      {
        flagHasInputZodiacSign = false;
      }

    public virtual void extraChineseZodiacNoSuchSignInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChineseZodiacNoSuchSignInfoNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChineseZodiacNoSuchSignInfoNuggetLookup(key);
        if (old_field == null)
          {
            extraChineseZodiacNoSuchSignInfoNuggetAppendPair(key, new_component);
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
    public override void extraChineseZodiacInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "InputZodiacSign", 0, 15, false) == 0) && (key.Length == 15))
            {
            fromJSONInputZodiacSign(new_component, false);
            return;
            }
        extraChineseZodiacNoSuchSignInfoNuggetAppendPair(key, new_component);
      }
    public override void extraChineseZodiacInfoNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "InputZodiacSign", 0, 15, false) == 0) && (key.Length == 15))
            {
            fromJSONInputZodiacSign(new_component, false);
            return;
            }
        extraChineseZodiacNoSuchSignInfoNuggetSetField(key, new_component);
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
        if (flagHasInputZodiacSign)
          {
            handler.start_pair("InputZodiacSign");
            handler.string_value(storeInputZodiacSign);
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

    public static new ChineseZodiacNoSuchSignInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseZodiacNoSuchSignInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacNoSuchSignInfoNugget", ignore_extras);
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
    public static new ChineseZodiacNoSuchSignInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChineseZodiacNoSuchSignInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseZodiacNoSuchSignInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacNoSuchSignInfoNugget", ignore_extras);
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
    public static new ChineseZodiacNoSuchSignInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChineseZodiacNoSuchSignInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        ChineseZodiacNoSuchSignInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacNoSuchSignInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChineseZodiacNoSuchSignInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ChineseZodiacNoSuchSignInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChineseZodiacNoSuchSignInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacNoSuchSignInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ChineseZodiacInfoNuggetJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorInputZodiacSign;
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
            if (!(getChineseZodiacInfoNuggetJSONKey().Equals("ChineseZodiacNoSuchSignInfoNugget")))
                throw new Exception("The key field has a value other than `ChineseZodiacNoSuchSignInfoNugget'.");
            ChineseZodiacNoSuchSignInfoNuggetJSON result = new ChineseZodiacNoSuchSignInfoNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChineseZodiacNoSuchSignInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ChineseZodiacInfoNuggetJSON new_result)
          {
            handle_result((ChineseZodiacNoSuchSignInfoNuggetJSON )new_result);
          }
        protected void finish(ChineseZodiacNoSuchSignInfoNuggetJSON result)
          {
            if (fieldGeneratorInputZodiacSign.have_value)
              {
                result.setInputZodiacSign(fieldGeneratorInputZodiacSign.value);
                fieldGeneratorInputZodiacSign.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ChineseZodiacNoSuchSignInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "InputZodiacSign", 0, 15, false) == 0) && (field_name.Length == 15))
                return fieldGeneratorInputZodiacSign;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorInputZodiacSign = new JSONHoldingStringGenerator("field \"InputZodiacSign\" of the ChineseZodiacNoSuchSignInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChineseZodiacNoSuchSignInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorInputZodiacSign = new JSONHoldingStringGenerator("field \"InputZodiacSign\" of the ChineseZodiacNoSuchSignInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChineseZodiacNoSuchSignInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorInputZodiacSign.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ChineseZodiacNoSuchSignInfoNuggetJSON  result)
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
        public ChineseZodiacNoSuchSignInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChineseZodiacNoSuchSignInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<ChineseZodiacNoSuchSignInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChineseZodiacNoSuchSignInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChineseZodiacNoSuchSignInfoNuggetJSON>();
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
    public List<ChineseZodiacNoSuchSignInfoNuggetJSON> value;
  };
  };
