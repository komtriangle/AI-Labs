/* file "RecipeAidInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class RecipeAidInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasRecipe;
    private DishDetailsJSON  storeRecipe;


    private JSONValue  extraRecipeToJSON()
      {
        JSONValueHandler handler_Recipe = new JSONValueHandler();
        storeRecipe.write_as_json(handler_Recipe);
        return handler_Recipe.result;
      }


    private void  fromJSONRecipe(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DishDetailsJSON convert_classy = DishDetailsJSON.from_json(json_value, ignore_extras, true);
        setRecipe(convert_classy);
      }


    public RecipeAidInformationNuggetJSON()
      {
        flagHasRecipe = false;
      }

    public override string  getNuggetKind()
      {
        return "RecipeAid";
      }

    public abstract string getRecipeAidNuggetKind();
    public bool  hasRecipe()
      {
        return flagHasRecipe;
      }

    public DishDetailsJSON   getRecipe()
      {
        Debug.Assert(flagHasRecipe);
        return storeRecipe;
      }


    public abstract int extraRecipeAidInformationNuggetComponentCount();
    public abstract string extraRecipeAidInformationNuggetComponentKey(int component_num);
    public abstract JSONValue extraRecipeAidInformationNuggetComponentValue(int component_num);
    public abstract JSONValue extraRecipeAidInformationNuggetLookup(string field_name);
    public override int extraInformationNuggetComponentCount()
      {
        int result = 1;
        if (flagHasRecipe)
            ++result;
        result += extraRecipeAidInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "RecipeAidNuggetKind";
        int remainder = (component_num - 1);
        if (flagHasRecipe)
          {
            if (remainder == 0)
                return "Recipe";
            --remainder;
          }
        return extraRecipeAidInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getRecipeAidNuggetKind());
        int remainder = (component_num - 1);
        if (flagHasRecipe)
          {
            if (remainder == 0)
                return extraRecipeToJSON();
            --remainder;
          }
        return extraRecipeAidInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "Recipe", 0, 6, false) == 0)
          {
            if (field_name.Length == 6)
              {
                return (flagHasRecipe ? extraRecipeToJSON() : null);
              }
            switch (field_name[6])
              {
                case 'A':
                    if ((String.Compare(field_name, 7, "idNuggetKind", 0, 12, false) == 0) && (field_name.Length == 19))
                        return new JSONStringValue(getRecipeAidNuggetKind());
                    break;
                default:
                    break;
              }
          }
        return extraRecipeAidInformationNuggetLookup(field_name);
      }

    public void setRecipe(DishDetailsJSON  new_value)
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

    public abstract void extraRecipeAidInformationNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraRecipeAidInformationNuggetSetField(string key, JSONValue new_component);
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Recipe", 0, 6, false) == 0)
          {
            if (key.Length == 6)
              {
                {
                fromJSONRecipe(new_component, false);
                return;
                }
              }
            switch (key[6])
              {
                case 'A':
                    if ((String.Compare(key, 7, "idNuggetKind", 0, 12, false) == 0) && (key.Length == 19))
                        return;
                    break;
                default:
                    break;
              }
          }
        extraRecipeAidInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Recipe", 0, 6, false) == 0)
          {
            if (key.Length == 6)
              {
                {
                fromJSONRecipe(new_component, false);
                return;
                }
              }
            switch (key[6])
              {
                case 'A':
                    if ((String.Compare(key, 7, "idNuggetKind", 0, 12, false) == 0) && (key.Length == 19))
                        return;
                    break;
                default:
                    break;
              }
          }
        extraRecipeAidInformationNuggetSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("RecipeAidNuggetKind", getRecipeAidNuggetKind());
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

    public static new RecipeAidInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInformationNugget", ignore_extras);
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
    public static new RecipeAidInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RecipeAidInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInformationNugget", ignore_extras);
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
    public static new RecipeAidInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RecipeAidInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        RecipeAidInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeAidInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RecipeAidInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeAidInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private DishDetailsJSON.HoldingGenerator fieldGeneratorRecipe;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `RecipeAidNuggetKind' field is missing.");
            if (!(getInformationNuggetJSONKey().Equals("RecipeAid")))
                throw new Exception("The key field has a value other than `RecipeAid'.");
            RecipeAidInformationNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeAidInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getRecipeAidInformationNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `RecipeAidNuggetKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((RecipeAidInformationNuggetJSON )new_result);
          }
        protected void finish(RecipeAidInformationNuggetJSON result)
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
        protected abstract void handle_result(RecipeAidInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Recipe", 0, 6, false) == 0)
              {
                if (field_name.Length == 6)
                  {
                    return fieldGeneratorRecipe;
                  }
                switch (field_name[6])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 7, "idNuggetKind", 0, 12, false) == 0) && (field_name.Length == 19))
                            {
                            keyGenerator.reset();
                            return keyGenerator;
                            }
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRecipe = new DishDetailsJSON.HoldingGenerator("field \"Recipe\" of the RecipeAidInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"RecipeAidNuggetKind\" of the RecipeAidInformationNugget class");
            set_what("the RecipeAidInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRecipe = new DishDetailsJSON.HoldingGenerator("field \"Recipe\" of the RecipeAidInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"RecipeAidNuggetKind\" of the RecipeAidInformationNugget class");
            set_what("the RecipeAidInformationNugget class");
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
        protected override void handle_result(RecipeAidInformationNuggetJSON  result)
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
        public RecipeAidInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeAidInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<RecipeAidInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeAidInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeAidInformationNuggetJSON>();
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
    public List<RecipeAidInformationNuggetJSON> value;
  };
    class GenericRecipeAidInformationNuggetJSON : RecipeAidInformationNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericRecipeAidInformationNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getRecipeAidNuggetKind()  { return key; }
        public override int extraRecipeAidInformationNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraRecipeAidInformationNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraRecipeAidInformationNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraRecipeAidInformationNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraRecipeAidInformationNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraRecipeAidInformationNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraRecipeAidInformationNuggetLookup(key);
            if (old_field == null)
              {
                extraRecipeAidInformationNuggetAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new RecipeAidInformationNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'G':
            if ((String.Compare(key, 1, "eneralQuery", 0, 11, false) == 0) && (key.Length == 12))
                return new RecipeAidGeneralQueryInformationNuggetJSON();
            break;
        case 'I':
            if ((String.Compare(key, 1, "nstructionQuery", 0, 15, false) == 0) && (key.Length == 16))
                return new RecipeAidInstructionQueryInformationNuggetJSON();
            break;
        default:
            break;
      }

        return new GenericRecipeAidInformationNuggetJSON(key);
      }
  };
