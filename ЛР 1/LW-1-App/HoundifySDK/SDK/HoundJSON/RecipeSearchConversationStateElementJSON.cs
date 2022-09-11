/* file "RecipeSearchConversationStateElementJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RecipeSearchConversationStateElementJSON : JSONBase
  {
    private bool flagHasRecipeSearchSpecifications;
    private RecipeSearchSpecJSON  storeRecipeSearchSpecifications;
    private bool flagHasRecipeSearchResults;
    private RecipeSearchResultConversationStateJSON  storeRecipeSearchResults;
    private bool flagHasDishDetails;
    private DishDetailsJSON  storeDishDetails;
    private bool flagHasDishPositionOnList;
    private BigInteger storeDishPositionOnList;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRecipeSearchSpecifications(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RecipeSearchSpecJSON convert_classy = RecipeSearchSpecJSON.from_json(json_value, ignore_extras, true);
        setRecipeSearchSpecifications(convert_classy);
      }


    private void  fromJSONRecipeSearchResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RecipeSearchResultConversationStateJSON convert_classy = RecipeSearchResultConversationStateJSON.from_json(json_value, ignore_extras, true);
        setRecipeSearchResults(convert_classy);
      }


    private void  fromJSONDishDetails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DishDetailsJSON convert_classy = DishDetailsJSON.from_json(json_value, ignore_extras, true);
        setDishDetails(convert_classy);
      }


    private void  fromJSONDishPositionOnList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DishPositionOnList of RecipeSearchConversationStateElementJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DishPositionOnList of RecipeSearchConversationStateElementJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDishPositionOnList(extracted_integer);
      }


    public RecipeSearchConversationStateElementJSON()
      {
        flagHasRecipeSearchSpecifications = false;
        flagHasRecipeSearchResults = false;
        flagHasDishDetails = false;
        flagHasDishPositionOnList = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRecipeSearchSpecifications()
      {
        return flagHasRecipeSearchSpecifications;
      }

    public RecipeSearchSpecJSON   getRecipeSearchSpecifications()
      {
        Debug.Assert(flagHasRecipeSearchSpecifications);
        return storeRecipeSearchSpecifications;
      }

    public bool  hasRecipeSearchResults()
      {
        return flagHasRecipeSearchResults;
      }

    public RecipeSearchResultConversationStateJSON   getRecipeSearchResults()
      {
        Debug.Assert(flagHasRecipeSearchResults);
        return storeRecipeSearchResults;
      }

    public bool  hasDishDetails()
      {
        return flagHasDishDetails;
      }

    public DishDetailsJSON   getDishDetails()
      {
        Debug.Assert(flagHasDishDetails);
        return storeDishDetails;
      }

    public bool  hasDishPositionOnList()
      {
        return flagHasDishPositionOnList;
      }

    public BigInteger  getDishPositionOnList()
      {
        Debug.Assert(flagHasDishPositionOnList);
        return storeDishPositionOnList;
      }


    public virtual int extraRecipeSearchConversationStateElementComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRecipeSearchConversationStateElementComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRecipeSearchConversationStateElementComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRecipeSearchConversationStateElementLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRecipeSearchSpecifications(RecipeSearchSpecJSON  new_value)
      {
        if (flagHasRecipeSearchSpecifications)
          {
          }
        flagHasRecipeSearchSpecifications = true;
        storeRecipeSearchSpecifications = new_value;
      }
    public void unsetRecipeSearchSpecifications()
      {
        if (flagHasRecipeSearchSpecifications)
          {
          }
        flagHasRecipeSearchSpecifications = false;
      }
    public void setRecipeSearchResults(RecipeSearchResultConversationStateJSON  new_value)
      {
        if (flagHasRecipeSearchResults)
          {
          }
        flagHasRecipeSearchResults = true;
        storeRecipeSearchResults = new_value;
      }
    public void unsetRecipeSearchResults()
      {
        if (flagHasRecipeSearchResults)
          {
          }
        flagHasRecipeSearchResults = false;
      }
    public void setDishDetails(DishDetailsJSON  new_value)
      {
        if (flagHasDishDetails)
          {
          }
        flagHasDishDetails = true;
        storeDishDetails = new_value;
      }
    public void unsetDishDetails()
      {
        if (flagHasDishDetails)
          {
          }
        flagHasDishDetails = false;
      }
    public void setDishPositionOnList(BigInteger new_value)
      {
        flagHasDishPositionOnList = true;
        if (new_value < 0)
            throw new Exception("The value for field DishPositionOnList of RecipeSearchConversationStateElementJSON is less than the lower bound (0) for that field.");
        storeDishPositionOnList = new_value;
      }
    public void unsetDishPositionOnList()
      {
        flagHasDishPositionOnList = false;
      }

    public virtual void extraRecipeSearchConversationStateElementAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRecipeSearchConversationStateElementSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRecipeSearchConversationStateElementLookup(key);
        if (old_field == null)
          {
            extraRecipeSearchConversationStateElementAppendPair(key, new_component);
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
        if (flagHasRecipeSearchSpecifications)
          {
            handler.start_pair("RecipeSearchSpecifications");
            if (partial_allowed)
                storeRecipeSearchSpecifications.write_partial_as_json(handler);
            else
                storeRecipeSearchSpecifications.write_as_json(handler);
          }
        if (flagHasRecipeSearchResults)
          {
            handler.start_pair("RecipeSearchResults");
            if (partial_allowed)
                storeRecipeSearchResults.write_partial_as_json(handler);
            else
                storeRecipeSearchResults.write_as_json(handler);
          }
        if (flagHasDishDetails)
          {
            handler.start_pair("DishDetails");
            if (partial_allowed)
                storeDishDetails.write_partial_as_json(handler);
            else
                storeDishDetails.write_as_json(handler);
          }
        if (flagHasDishPositionOnList)
          {
            handler.start_pair("DishPositionOnList");
            handler.number_value(storeDishPositionOnList);
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

    public static RecipeSearchConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchConversationStateElement", ignore_extras);
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
    public static RecipeSearchConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeSearchConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchConversationStateElement", ignore_extras);
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
    public static RecipeSearchConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeSearchConversationStateElementJSON from_text(string text, bool ignore_extras)
      {
        RecipeSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeSearchConversationStateElementJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RecipeSearchConversationStateElementJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private RecipeSearchSpecJSON.HoldingGenerator fieldGeneratorRecipeSearchSpecifications;
        private RecipeSearchResultConversationStateJSON.HoldingGenerator fieldGeneratorRecipeSearchResults;
        private DishDetailsJSON.HoldingGenerator fieldGeneratorDishDetails;
    private class FieldHoldingGeneratorDishPositionOnList : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDishPositionOnList(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDishPositionOnList : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDishPositionOnList(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorDishPositionOnList fieldGeneratorDishPositionOnList;
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
            RecipeSearchConversationStateElementJSON result = new RecipeSearchConversationStateElementJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeSearchConversationStateElementAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RecipeSearchConversationStateElementJSON result)
          {
            if (fieldGeneratorRecipeSearchSpecifications.have_value)
              {
                result.setRecipeSearchSpecifications(fieldGeneratorRecipeSearchSpecifications.value);
                fieldGeneratorRecipeSearchSpecifications.have_value = false;
              }
            if (fieldGeneratorRecipeSearchResults.have_value)
              {
                result.setRecipeSearchResults(fieldGeneratorRecipeSearchResults.value);
                fieldGeneratorRecipeSearchResults.have_value = false;
              }
            if (fieldGeneratorDishDetails.have_value)
              {
                result.setDishDetails(fieldGeneratorDishDetails.value);
                fieldGeneratorDishDetails.have_value = false;
              }
            if (fieldGeneratorDishPositionOnList.have_value)
              {
                result.setDishPositionOnList(fieldGeneratorDishPositionOnList.value);
                fieldGeneratorDishPositionOnList.have_value = false;
              }
          }
        protected abstract void handle_result(RecipeSearchConversationStateElementJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "ish", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 5, "etails", 0, 6, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorDishDetails;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 5, "ositionOnList", 0, 13, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorDishPositionOnList;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "ecipeSearch", 0, 11, false) == 0)
                      {
                        switch (field_name[12])
                          {
                            case 'R':
                                if ((String.Compare(field_name, 13, "esults", 0, 6, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorRecipeSearchResults;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 13, "pecifications", 0, 13, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorRecipeSearchSpecifications;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRecipeSearchSpecifications = new RecipeSearchSpecJSON.HoldingGenerator("field \"RecipeSearchSpecifications\" of the RecipeSearchConversationStateElement class", ignore_extras);
            fieldGeneratorRecipeSearchResults = new RecipeSearchResultConversationStateJSON.HoldingGenerator("field \"RecipeSearchResults\" of the RecipeSearchConversationStateElement class", ignore_extras);
            fieldGeneratorDishDetails = new DishDetailsJSON.HoldingGenerator("field \"DishDetails\" of the RecipeSearchConversationStateElement class", ignore_extras);
            fieldGeneratorDishPositionOnList = new FieldHoldingGeneratorDishPositionOnList("field \"DishPositionOnList\" of the RecipeSearchConversationStateElement class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RecipeSearchConversationStateElement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRecipeSearchSpecifications = new RecipeSearchSpecJSON.HoldingGenerator("field \"RecipeSearchSpecifications\" of the RecipeSearchConversationStateElement class", false);
            fieldGeneratorRecipeSearchResults = new RecipeSearchResultConversationStateJSON.HoldingGenerator("field \"RecipeSearchResults\" of the RecipeSearchConversationStateElement class", false);
            fieldGeneratorDishDetails = new DishDetailsJSON.HoldingGenerator("field \"DishDetails\" of the RecipeSearchConversationStateElement class", false);
            fieldGeneratorDishPositionOnList = new FieldHoldingGeneratorDishPositionOnList("field \"DishPositionOnList\" of the RecipeSearchConversationStateElement class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RecipeSearchConversationStateElement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRecipeSearchSpecifications.reset();
            fieldGeneratorRecipeSearchResults.reset();
            fieldGeneratorDishDetails.reset();
            fieldGeneratorDishPositionOnList.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRecipeSearchSpecifications.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRecipeSearchResults.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDishDetails.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRecipeSearchSpecifications.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRecipeSearchResults.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDishDetails.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RecipeSearchConversationStateElementJSON  result)
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
        public RecipeSearchConversationStateElementJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeSearchConversationStateElementJSON  result)
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
    protected virtual void handle_result(List<RecipeSearchConversationStateElementJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeSearchConversationStateElementJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeSearchConversationStateElementJSON>();
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
    public List<RecipeSearchConversationStateElementJSON> value;
  };
  };
