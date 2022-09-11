/* file "WhatsInDrinkQuestionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WhatsInDrinkQuestionJSON : InformationNuggetJSON
  {
    private bool flagHasRecipe;
    private DrinkRecipeJSON  storeRecipe;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRecipeToJSON()
      {
        JSONValueHandler handler_Recipe = new JSONValueHandler();
        storeRecipe.write_as_json(handler_Recipe);
        return handler_Recipe.result;
      }


    private void  fromJSONRecipe(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DrinkRecipeJSON convert_classy = DrinkRecipeJSON.from_json(json_value, ignore_extras, true);
        setRecipe(convert_classy);
      }


    public WhatsInDrinkQuestionJSON()
      {
        flagHasRecipe = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "WhatsInDrinkNugget";
      }

    public bool  hasRecipe()
      {
        return flagHasRecipe;
      }

    public DrinkRecipeJSON   getRecipe()
      {
        Debug.Assert(flagHasRecipe);
        return storeRecipe;
      }


    public virtual int extraWhatsInDrinkQuestionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWhatsInDrinkQuestionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWhatsInDrinkQuestionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWhatsInDrinkQuestionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasRecipe)
            ++result;
        result += extraWhatsInDrinkQuestionComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRecipe)
          {
            if (remainder == 0)
                return "Recipe";
            --remainder;
          }
        return extraWhatsInDrinkQuestionComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRecipe)
          {
            if (remainder == 0)
                return extraRecipeToJSON();
            --remainder;
          }
        return extraWhatsInDrinkQuestionComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Recipe", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasRecipe ? extraRecipeToJSON() : null);
        return extraWhatsInDrinkQuestionLookup(field_name);
      }

    public void setRecipe(DrinkRecipeJSON  new_value)
      {
        if (flagHasRecipe)
          {
          }
        flagHasRecipe = true;
        storeRecipe = new_value;
      }
    public void unsetRecipe()
      {
        if (flagHasRecipe)
          {
          }
        flagHasRecipe = false;
      }

    public virtual void extraWhatsInDrinkQuestionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWhatsInDrinkQuestionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWhatsInDrinkQuestionLookup(key);
        if (old_field == null)
          {
            extraWhatsInDrinkQuestionAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Recipe", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONRecipe(new_component, false);
            return;
            }
        extraWhatsInDrinkQuestionAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Recipe", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONRecipe(new_component, false);
            return;
            }
        extraWhatsInDrinkQuestionSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRecipe);
        if (flagHasRecipe)
          {
            handler.start_pair("Recipe");
            if (partial_allowed)
                storeRecipe.write_partial_as_json(handler);
            else
                storeRecipe.write_as_json(handler);
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
        if (!(hasRecipe()))
          {
            return "When parsing the object for %what%, the \"Recipe\" field was missing.";
          }
        return null;
      }

    public static new WhatsInDrinkQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WhatsInDrinkQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhatsInDrinkQuestion", ignore_extras);
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
    public static new WhatsInDrinkQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WhatsInDrinkQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WhatsInDrinkQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhatsInDrinkQuestion", ignore_extras);
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
    public static new WhatsInDrinkQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WhatsInDrinkQuestionJSON from_text(string text, bool ignore_extras)
      {
        WhatsInDrinkQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhatsInDrinkQuestion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WhatsInDrinkQuestionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new WhatsInDrinkQuestionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WhatsInDrinkQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhatsInDrinkQuestion", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private DrinkRecipeJSON.HoldingGenerator fieldGeneratorRecipe;
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
            if (!(getInformationNuggetJSONKey().Equals("WhatsInDrinkNugget")))
                throw new Exception("The key field has a value other than `WhatsInDrinkNugget'.");
            WhatsInDrinkQuestionJSON result = new WhatsInDrinkQuestionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWhatsInDrinkQuestionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((WhatsInDrinkQuestionJSON )new_result);
          }
        protected void finish(WhatsInDrinkQuestionJSON result)
          {
            if (fieldGeneratorRecipe.have_value)
              {
                result.setRecipe(fieldGeneratorRecipe.value);
                fieldGeneratorRecipe.have_value = false;
              }
            else if ((!(result.hasRecipe())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Recipe\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(WhatsInDrinkQuestionJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Recipe", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorRecipe;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRecipe = new DrinkRecipeJSON.HoldingGenerator("field \"Recipe\" of the WhatsInDrinkQuestion class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WhatsInDrinkQuestion class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRecipe = new DrinkRecipeJSON.HoldingGenerator("field \"Recipe\" of the WhatsInDrinkQuestion class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WhatsInDrinkQuestion class");
          }

        public override void reset()
          {
            fieldGeneratorRecipe.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(WhatsInDrinkQuestionJSON  result)
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
        public WhatsInDrinkQuestionJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WhatsInDrinkQuestionJSON  result)
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
    protected virtual void handle_result(List<WhatsInDrinkQuestionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WhatsInDrinkQuestionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WhatsInDrinkQuestionJSON>();
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
    public List<WhatsInDrinkQuestionJSON> value;
  };
  };
