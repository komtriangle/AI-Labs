/* file "ChineseDailyHoroscopesIntraQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ChineseDailyHoroscopesIntraQueryStateJSON : DailyHoroscopesIntraQueryStateJSON
  {
    private bool flagHasSign;
    private ChineseZodiacSignJSON  storeSign;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSignToJSON()
      {
        JSONValueHandler handler_Sign = new JSONValueHandler();
        storeSign.write_as_json(handler_Sign);
        return handler_Sign.result;
      }


    private void  fromJSONSign(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ChineseZodiacSignJSON convert_classy = ChineseZodiacSignJSON.from_json(json_value, ignore_extras, true);
        setSign(convert_classy);
      }


    public ChineseDailyHoroscopesIntraQueryStateJSON()
      {
        flagHasSign = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDailyHoroscopesIntraQueryStateKind()
      {
        return "ChineseDailyHoroscopesIntraQueryState";
      }

    public bool  hasSign()
      {
        return flagHasSign;
      }

    public ChineseZodiacSignJSON   getSign()
      {
        Debug.Assert(flagHasSign);
        return storeSign;
      }

    public ChineseZodiacSignJSON.TypeValue  getSignValue()
      {
        return getSign().getValue();
      }

    public string  getSignAsString()
      {
        return getSign().getValueAsString();
      }


    public virtual int extraChineseDailyHoroscopesIntraQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChineseDailyHoroscopesIntraQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChineseDailyHoroscopesIntraQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChineseDailyHoroscopesIntraQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDailyHoroscopesIntraQueryStateComponentCount()
      {
        int result = 0;
        if (flagHasSign)
            ++result;
        result += extraChineseDailyHoroscopesIntraQueryStateComponentCount();
        return result;
      }
    public override string extraDailyHoroscopesIntraQueryStateComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSign)
          {
            if (remainder == 0)
                return "Sign";
            --remainder;
          }
        return extraChineseDailyHoroscopesIntraQueryStateComponentKey(remainder);
      }
    public override JSONValue extraDailyHoroscopesIntraQueryStateComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSign)
          {
            if (remainder == 0)
                return extraSignToJSON();
            --remainder;
          }
        return extraChineseDailyHoroscopesIntraQueryStateComponentValue(remainder);
      }
    public override JSONValue extraDailyHoroscopesIntraQueryStateLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Sign", 0, 4, false) == 0) && (field_name.Length == 4))
            return (flagHasSign ? extraSignToJSON() : null);
        return extraChineseDailyHoroscopesIntraQueryStateLookup(field_name);
      }

    public void setSign(ChineseZodiacSignJSON  new_value)
      {
        if (flagHasSign)
          {
          }
        flagHasSign = true;
        storeSign = new_value;
      }
    public void setSign(ChineseZodiacSignJSON.TypeValue new_value)
      {
        setSign(new ChineseZodiacSignJSON(new_value));
      }
    public void setSign(string chars)
      {
        ChineseZodiacSignJSON.TypeValueKnownValues known = ChineseZodiacSignJSON.stringToValue(chars);
        ChineseZodiacSignJSON.TypeValue new_value = new ChineseZodiacSignJSON.TypeValue();
        if (known == ChineseZodiacSignJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSign(new_value);
      }
    public void unsetSign()
      {
        if (flagHasSign)
          {
          }
        flagHasSign = false;
      }

    public virtual void extraChineseDailyHoroscopesIntraQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChineseDailyHoroscopesIntraQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChineseDailyHoroscopesIntraQueryStateLookup(key);
        if (old_field == null)
          {
            extraChineseDailyHoroscopesIntraQueryStateAppendPair(key, new_component);
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
    public override void extraDailyHoroscopesIntraQueryStateAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Sign", 0, 4, false) == 0) && (key.Length == 4))
            {
            fromJSONSign(new_component, false);
            return;
            }
        extraChineseDailyHoroscopesIntraQueryStateAppendPair(key, new_component);
      }
    public override void extraDailyHoroscopesIntraQueryStateSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Sign", 0, 4, false) == 0) && (key.Length == 4))
            {
            fromJSONSign(new_component, false);
            return;
            }
        extraChineseDailyHoroscopesIntraQueryStateSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSign);
        if (flagHasSign)
          {
            handler.start_pair("Sign");
            if (partial_allowed)
                storeSign.write_partial_as_json(handler);
            else
                storeSign.write_as_json(handler);
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
        if (!(hasSign()))
          {
            return "When parsing the object for %what%, the \"Sign\" field was missing.";
          }
        return null;
      }

    public static new ChineseDailyHoroscopesIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseDailyHoroscopesIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseDailyHoroscopesIntraQueryState", ignore_extras);
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
    public static new ChineseDailyHoroscopesIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChineseDailyHoroscopesIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseDailyHoroscopesIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseDailyHoroscopesIntraQueryState", ignore_extras);
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
    public static new ChineseDailyHoroscopesIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChineseDailyHoroscopesIntraQueryStateJSON from_text(string text, bool ignore_extras)
      {
        ChineseDailyHoroscopesIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseDailyHoroscopesIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChineseDailyHoroscopesIntraQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ChineseDailyHoroscopesIntraQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChineseDailyHoroscopesIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseDailyHoroscopesIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DailyHoroscopesIntraQueryStateJSON.Generator
      {
        private ChineseZodiacSignJSON.HoldingGenerator fieldGeneratorSign;
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
            if (!(getDailyHoroscopesIntraQueryStateJSONKey().Equals("ChineseDailyHoroscopesIntraQueryState")))
                throw new Exception("The key field has a value other than `ChineseDailyHoroscopesIntraQueryState'.");
            ChineseDailyHoroscopesIntraQueryStateJSON result = new ChineseDailyHoroscopesIntraQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChineseDailyHoroscopesIntraQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DailyHoroscopesIntraQueryStateJSON new_result)
          {
            handle_result((ChineseDailyHoroscopesIntraQueryStateJSON )new_result);
          }
        protected void finish(ChineseDailyHoroscopesIntraQueryStateJSON result)
          {
            if (fieldGeneratorSign.have_value)
              {
                result.setSign(fieldGeneratorSign.value);
                fieldGeneratorSign.have_value = false;
              }
            else if ((!(result.hasSign())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Sign\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ChineseDailyHoroscopesIntraQueryStateJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Sign", 0, 4, false) == 0) && (field_name.Length == 4))
                return fieldGeneratorSign;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSign = new ChineseZodiacSignJSON.HoldingGenerator("field \"Sign\" of the ChineseDailyHoroscopesIntraQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChineseDailyHoroscopesIntraQueryState class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSign = new ChineseZodiacSignJSON.HoldingGenerator("field \"Sign\" of the ChineseDailyHoroscopesIntraQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChineseDailyHoroscopesIntraQueryState class");
          }

        public override void reset()
          {
            fieldGeneratorSign.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ChineseDailyHoroscopesIntraQueryStateJSON  result)
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
        public ChineseDailyHoroscopesIntraQueryStateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChineseDailyHoroscopesIntraQueryStateJSON  result)
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
    protected virtual void handle_result(List<ChineseDailyHoroscopesIntraQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChineseDailyHoroscopesIntraQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChineseDailyHoroscopesIntraQueryStateJSON>();
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
    public List<ChineseDailyHoroscopesIntraQueryStateJSON> value;
  };
  };
