/* file "DetailedDictionarySearchTermJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DetailedDictionarySearchTermJSON : DictionarySearchTermJSON
  {
    private bool flagHasAdditionalMatches;
    private List< SimpleDictionarySearchTermJSON  > storeAdditionalMatches;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAdditionalMatchesToJSON()
      {
        JSONArrayValue generated_array_1_AdditionalMatches = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAdditionalMatches.Count; ++num1)
          {
            JSONValueHandler handler_AdditionalMatches = new JSONValueHandler();
            storeAdditionalMatches[num1].write_as_json(handler_AdditionalMatches);
            generated_array_1_AdditionalMatches.appendComponent(handler_AdditionalMatches.result);
          }
        return generated_array_1_AdditionalMatches;
      }


    private void  fromJSONAdditionalMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AdditionalMatches of DetailedDictionarySearchTermJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SimpleDictionarySearchTermJSON  > vector_AdditionalMatches1 = new List< SimpleDictionarySearchTermJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SimpleDictionarySearchTermJSON convert_classy = SimpleDictionarySearchTermJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AdditionalMatches1.Add(convert_classy);
          }
        initAdditionalMatches();
        for (int num1 = 0; num1 < vector_AdditionalMatches1.Count; ++num1)
            appendAdditionalMatches(vector_AdditionalMatches1[num1]);
        for (int num1 = 0; num1 < vector_AdditionalMatches1.Count; ++num1)
          {
          }
      }


    public DetailedDictionarySearchTermJSON()
      {
        flagHasAdditionalMatches = false;
        storeAdditionalMatches = new List< SimpleDictionarySearchTermJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDictionarySearchTermKind()
      {
        return "DetailedDictionarySearchTerm";
      }

    public bool  hasAdditionalMatches()
      {
        return flagHasAdditionalMatches;
      }

    public int  countOfAdditionalMatches()
      {
        Debug.Assert(flagHasAdditionalMatches);
        return storeAdditionalMatches.Count;
      }

    public SimpleDictionarySearchTermJSON   elementOfAdditionalMatches(int element_num)
      {
        Debug.Assert(flagHasAdditionalMatches);
        return storeAdditionalMatches[element_num];
      }

    public List< SimpleDictionarySearchTermJSON  >  getAdditionalMatches()
      {
        Debug.Assert(flagHasAdditionalMatches);
        return storeAdditionalMatches;
      }


    public virtual int extraDetailedDictionarySearchTermComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDetailedDictionarySearchTermComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDetailedDictionarySearchTermComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDetailedDictionarySearchTermLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDictionarySearchTermComponentCount()
      {
        int result = 0;
        if (flagHasAdditionalMatches)
            ++result;
        result += extraDetailedDictionarySearchTermComponentCount();
        return result;
      }
    public override string extraDictionarySearchTermComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAdditionalMatches)
          {
            if (remainder == 0)
                return "AdditionalMatches";
            --remainder;
          }
        return extraDetailedDictionarySearchTermComponentKey(remainder);
      }
    public override JSONValue extraDictionarySearchTermComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAdditionalMatches)
          {
            if (remainder == 0)
                return extraAdditionalMatchesToJSON();
            --remainder;
          }
        return extraDetailedDictionarySearchTermComponentValue(remainder);
      }
    public override JSONValue extraDictionarySearchTermLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "AdditionalMatches", 0, 17, false) == 0) && (field_name.Length == 17))
            return (flagHasAdditionalMatches ? extraAdditionalMatchesToJSON() : null);
        return extraDetailedDictionarySearchTermLookup(field_name);
      }

    public void initAdditionalMatches()
      {
        if (flagHasAdditionalMatches)
          {
            for (int num1 = 0; num1 < storeAdditionalMatches.Count; ++num1)
              {
              }
          }
        flagHasAdditionalMatches = true;
        storeAdditionalMatches.Clear();
      }
    public void appendAdditionalMatches(SimpleDictionarySearchTermJSON  to_append)
      {
        if (!flagHasAdditionalMatches)
          {
            flagHasAdditionalMatches = true;
            storeAdditionalMatches.Clear();
          }
        Debug.Assert(flagHasAdditionalMatches);
        storeAdditionalMatches.Add(to_append);
      }
    public void unsetAdditionalMatches()
      {
        if (flagHasAdditionalMatches)
          {
            for (int num2 = 0; num2 < storeAdditionalMatches.Count; ++num2)
              {
              }
          }
        flagHasAdditionalMatches = false;
        storeAdditionalMatches.Clear();
      }

    public virtual void extraDetailedDictionarySearchTermAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDetailedDictionarySearchTermSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDetailedDictionarySearchTermLookup(key);
        if (old_field == null)
          {
            extraDetailedDictionarySearchTermAppendPair(key, new_component);
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
    public override void extraDictionarySearchTermAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "AdditionalMatches", 0, 17, false) == 0) && (key.Length == 17))
            {
            fromJSONAdditionalMatches(new_component, false);
            return;
            }
        extraDetailedDictionarySearchTermAppendPair(key, new_component);
      }
    public override void extraDictionarySearchTermSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "AdditionalMatches", 0, 17, false) == 0) && (key.Length == 17))
            {
            fromJSONAdditionalMatches(new_component, false);
            return;
            }
        extraDetailedDictionarySearchTermSetField(key, new_component);
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
        if (flagHasAdditionalMatches)
          {
            handler.start_pair("AdditionalMatches");
            handler.start_array();
            for (int num1 = 0; num1 < storeAdditionalMatches.Count; ++num1)
              {
                if (partial_allowed)
                    storeAdditionalMatches[num1].write_partial_as_json(handler);
                else
                    storeAdditionalMatches[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new DetailedDictionarySearchTermJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DetailedDictionarySearchTermJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DetailedDictionarySearchTerm", ignore_extras);
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
    public static new DetailedDictionarySearchTermJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DetailedDictionarySearchTermJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DetailedDictionarySearchTermJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DetailedDictionarySearchTerm", ignore_extras);
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
    public static new DetailedDictionarySearchTermJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DetailedDictionarySearchTermJSON from_text(string text, bool ignore_extras)
      {
        DetailedDictionarySearchTermJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DetailedDictionarySearchTerm", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DetailedDictionarySearchTermJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DetailedDictionarySearchTermJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DetailedDictionarySearchTermJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DetailedDictionarySearchTerm", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DictionarySearchTermJSON.Generator
      {
        private SimpleDictionarySearchTermJSON.HoldingArrayGenerator fieldGeneratorAdditionalMatches;
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
            if (!(getDictionarySearchTermJSONKey().Equals("DetailedDictionarySearchTerm")))
                throw new Exception("The key field has a value other than `DetailedDictionarySearchTerm'.");
            DetailedDictionarySearchTermJSON result = new DetailedDictionarySearchTermJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDetailedDictionarySearchTermAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DictionarySearchTermJSON new_result)
          {
            handle_result((DetailedDictionarySearchTermJSON )new_result);
          }
        protected void finish(DetailedDictionarySearchTermJSON result)
          {
            if (fieldGeneratorAdditionalMatches.have_value)
              {
                result.initAdditionalMatches();
                int count = fieldGeneratorAdditionalMatches.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAdditionalMatches(fieldGeneratorAdditionalMatches.value[num]);
                  }
                fieldGeneratorAdditionalMatches.value.Clear();
                fieldGeneratorAdditionalMatches.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(DetailedDictionarySearchTermJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "AdditionalMatches", 0, 17, false) == 0) && (field_name.Length == 17))
                return fieldGeneratorAdditionalMatches;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAdditionalMatches = new SimpleDictionarySearchTermJSON.HoldingArrayGenerator("field \"AdditionalMatches\" of the DetailedDictionarySearchTerm class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DetailedDictionarySearchTerm class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAdditionalMatches = new SimpleDictionarySearchTermJSON.HoldingArrayGenerator("field \"AdditionalMatches\" of the DetailedDictionarySearchTerm class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DetailedDictionarySearchTerm class");
          }

        public override void reset()
          {
            fieldGeneratorAdditionalMatches.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DetailedDictionarySearchTermJSON  result)
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
        public DetailedDictionarySearchTermJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DetailedDictionarySearchTermJSON  result)
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
    protected virtual void handle_result(List<DetailedDictionarySearchTermJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DetailedDictionarySearchTermJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DetailedDictionarySearchTermJSON>();
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
    public List<DetailedDictionarySearchTermJSON> value;
  };
  };
