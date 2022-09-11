/* file "WhatDrinkCanMakeQuestionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WhatDrinkCanMakeQuestionJSON : InformationNuggetJSON
  {
    private bool flagHasIngredients;
    private List< DrinkIngredientJSON  > storeIngredients;
    private bool flagHasCanMake;
    private List< DrinkRecipeJSON  > storeCanMake;
    private bool flagHasCanAlmostMake;
    private List< DrinkRecipeJSON  > storeCanAlmostMake;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraIngredientsToJSON()
      {
        JSONArrayValue generated_array_1_Ingredients = new JSONArrayValue();
        for (int num1 = 0; num1 < storeIngredients.Count; ++num1)
          {
            JSONValueHandler handler_Ingredients = new JSONValueHandler();
            storeIngredients[num1].write_as_json(handler_Ingredients);
            generated_array_1_Ingredients.appendComponent(handler_Ingredients.result);
          }
        return generated_array_1_Ingredients;
      }

    private JSONValue  extraCanMakeToJSON()
      {
        JSONArrayValue generated_array_2_CanMake = new JSONArrayValue();
        for (int num2 = 0; num2 < storeCanMake.Count; ++num2)
          {
            JSONValueHandler handler_CanMake = new JSONValueHandler();
            storeCanMake[num2].write_as_json(handler_CanMake);
            generated_array_2_CanMake.appendComponent(handler_CanMake.result);
          }
        return generated_array_2_CanMake;
      }

    private JSONValue  extraCanAlmostMakeToJSON()
      {
        JSONArrayValue generated_array_3_CanAlmostMake = new JSONArrayValue();
        for (int num3 = 0; num3 < storeCanAlmostMake.Count; ++num3)
          {
            JSONValueHandler handler_CanAlmostMake = new JSONValueHandler();
            storeCanAlmostMake[num3].write_as_json(handler_CanAlmostMake);
            generated_array_3_CanAlmostMake.appendComponent(handler_CanAlmostMake.result);
          }
        return generated_array_3_CanAlmostMake;
      }


    private void  fromJSONIngredients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Ingredients of WhatDrinkCanMakeQuestionJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DrinkIngredientJSON  > vector_Ingredients1 = new List< DrinkIngredientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DrinkIngredientJSON convert_classy = DrinkIngredientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Ingredients1.Add(convert_classy);
          }
        initIngredients();
        for (int num1 = 0; num1 < vector_Ingredients1.Count; ++num1)
            appendIngredients(vector_Ingredients1[num1]);
        for (int num1 = 0; num1 < vector_Ingredients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCanMake(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CanMake of WhatDrinkCanMakeQuestionJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DrinkRecipeJSON  > vector_CanMake1 = new List< DrinkRecipeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DrinkRecipeJSON convert_classy = DrinkRecipeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_CanMake1.Add(convert_classy);
          }
        initCanMake();
        for (int num2 = 0; num2 < vector_CanMake1.Count; ++num2)
            appendCanMake(vector_CanMake1[num2]);
        for (int num1 = 0; num1 < vector_CanMake1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCanAlmostMake(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CanAlmostMake of WhatDrinkCanMakeQuestionJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DrinkRecipeJSON  > vector_CanAlmostMake1 = new List< DrinkRecipeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DrinkRecipeJSON convert_classy = DrinkRecipeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_CanAlmostMake1.Add(convert_classy);
          }
        initCanAlmostMake();
        for (int num3 = 0; num3 < vector_CanAlmostMake1.Count; ++num3)
            appendCanAlmostMake(vector_CanAlmostMake1[num3]);
        for (int num1 = 0; num1 < vector_CanAlmostMake1.Count; ++num1)
          {
          }
      }


    public WhatDrinkCanMakeQuestionJSON()
      {
        flagHasIngredients = false;
        flagHasCanMake = false;
        flagHasCanAlmostMake = false;
        storeIngredients = new List< DrinkIngredientJSON  >();
        storeCanMake = new List< DrinkRecipeJSON  >();
        storeCanAlmostMake = new List< DrinkRecipeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "WhatDrinkCanMakeNugget";
      }

    public bool  hasIngredients()
      {
        return flagHasIngredients;
      }

    public int  countOfIngredients()
      {
        Debug.Assert(flagHasIngredients);
        return storeIngredients.Count;
      }

    public DrinkIngredientJSON   elementOfIngredients(int element_num)
      {
        Debug.Assert(flagHasIngredients);
        return storeIngredients[element_num];
      }

    public List< DrinkIngredientJSON  >  getIngredients()
      {
        Debug.Assert(flagHasIngredients);
        return storeIngredients;
      }

    public bool  hasCanMake()
      {
        return flagHasCanMake;
      }

    public int  countOfCanMake()
      {
        Debug.Assert(flagHasCanMake);
        return storeCanMake.Count;
      }

    public DrinkRecipeJSON   elementOfCanMake(int element_num)
      {
        Debug.Assert(flagHasCanMake);
        return storeCanMake[element_num];
      }

    public List< DrinkRecipeJSON  >  getCanMake()
      {
        Debug.Assert(flagHasCanMake);
        return storeCanMake;
      }

    public bool  hasCanAlmostMake()
      {
        return flagHasCanAlmostMake;
      }

    public int  countOfCanAlmostMake()
      {
        Debug.Assert(flagHasCanAlmostMake);
        return storeCanAlmostMake.Count;
      }

    public DrinkRecipeJSON   elementOfCanAlmostMake(int element_num)
      {
        Debug.Assert(flagHasCanAlmostMake);
        return storeCanAlmostMake[element_num];
      }

    public List< DrinkRecipeJSON  >  getCanAlmostMake()
      {
        Debug.Assert(flagHasCanAlmostMake);
        return storeCanAlmostMake;
      }


    public virtual int extraWhatDrinkCanMakeQuestionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWhatDrinkCanMakeQuestionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWhatDrinkCanMakeQuestionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWhatDrinkCanMakeQuestionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasIngredients)
            ++result;
        if (flagHasCanMake)
            ++result;
        if (flagHasCanAlmostMake)
            ++result;
        result += extraWhatDrinkCanMakeQuestionComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasIngredients)
          {
            if (remainder == 0)
                return "Ingredients";
            --remainder;
          }
        if (flagHasCanMake)
          {
            if (remainder == 0)
                return "CanMake";
            --remainder;
          }
        if (flagHasCanAlmostMake)
          {
            if (remainder == 0)
                return "CanAlmostMake";
            --remainder;
          }
        return extraWhatDrinkCanMakeQuestionComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasIngredients)
          {
            if (remainder == 0)
                return extraIngredientsToJSON();
            --remainder;
          }
        if (flagHasCanMake)
          {
            if (remainder == 0)
                return extraCanMakeToJSON();
            --remainder;
          }
        if (flagHasCanAlmostMake)
          {
            if (remainder == 0)
                return extraCanAlmostMakeToJSON();
            --remainder;
          }
        return extraWhatDrinkCanMakeQuestionComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if (String.Compare(field_name, 1, "an", 0, 2, false) == 0)
                  {
                    switch (field_name[3])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 4, "lmostMake", 0, 9, false) == 0) && (field_name.Length == 13))
                                return (flagHasCanAlmostMake ? extraCanAlmostMakeToJSON() : null);
                            break;
                        case 'M':
                            if ((String.Compare(field_name, 4, "ake", 0, 3, false) == 0) && (field_name.Length == 7))
                                return (flagHasCanMake ? extraCanMakeToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "ngredients", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasIngredients ? extraIngredientsToJSON() : null);
                break;
            default:
                break;
          }
        return extraWhatDrinkCanMakeQuestionLookup(field_name);
      }

    public void initIngredients()
      {
        if (flagHasIngredients)
          {
            for (int num1 = 0; num1 < storeIngredients.Count; ++num1)
              {
              }
          }
        flagHasIngredients = true;
        storeIngredients.Clear();
      }
    public void appendIngredients(DrinkIngredientJSON  to_append)
      {
        if (!flagHasIngredients)
          {
            flagHasIngredients = true;
            storeIngredients.Clear();
          }
        Debug.Assert(flagHasIngredients);
        storeIngredients.Add(to_append);
      }
    public void unsetIngredients()
      {
        if (flagHasIngredients)
          {
            for (int num2 = 0; num2 < storeIngredients.Count; ++num2)
              {
              }
          }
        flagHasIngredients = false;
        storeIngredients.Clear();
      }
    public void initCanMake()
      {
        if (flagHasCanMake)
          {
            for (int num3 = 0; num3 < storeCanMake.Count; ++num3)
              {
              }
          }
        flagHasCanMake = true;
        storeCanMake.Clear();
      }
    public void appendCanMake(DrinkRecipeJSON  to_append)
      {
        if (!flagHasCanMake)
          {
            flagHasCanMake = true;
            storeCanMake.Clear();
          }
        Debug.Assert(flagHasCanMake);
        storeCanMake.Add(to_append);
      }
    public void unsetCanMake()
      {
        if (flagHasCanMake)
          {
            for (int num4 = 0; num4 < storeCanMake.Count; ++num4)
              {
              }
          }
        flagHasCanMake = false;
        storeCanMake.Clear();
      }
    public void initCanAlmostMake()
      {
        if (flagHasCanAlmostMake)
          {
            for (int num5 = 0; num5 < storeCanAlmostMake.Count; ++num5)
              {
              }
          }
        flagHasCanAlmostMake = true;
        storeCanAlmostMake.Clear();
      }
    public void appendCanAlmostMake(DrinkRecipeJSON  to_append)
      {
        if (!flagHasCanAlmostMake)
          {
            flagHasCanAlmostMake = true;
            storeCanAlmostMake.Clear();
          }
        Debug.Assert(flagHasCanAlmostMake);
        storeCanAlmostMake.Add(to_append);
      }
    public void unsetCanAlmostMake()
      {
        if (flagHasCanAlmostMake)
          {
            for (int num6 = 0; num6 < storeCanAlmostMake.Count; ++num6)
              {
              }
          }
        flagHasCanAlmostMake = false;
        storeCanAlmostMake.Clear();
      }

    public virtual void extraWhatDrinkCanMakeQuestionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWhatDrinkCanMakeQuestionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWhatDrinkCanMakeQuestionLookup(key);
        if (old_field == null)
          {
            extraWhatDrinkCanMakeQuestionAppendPair(key, new_component);
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
        switch (key[0])
          {
            case 'C':
                if (String.Compare(key, 1, "an", 0, 2, false) == 0)
                  {
                    switch (key[3])
                      {
                        case 'A':
                            if ((String.Compare(key, 4, "lmostMake", 0, 9, false) == 0) && (key.Length == 13))
                                {
                                fromJSONCanAlmostMake(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 4, "ake", 0, 3, false) == 0) && (key.Length == 7))
                                {
                                fromJSONCanMake(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "ngredients", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONIngredients(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraWhatDrinkCanMakeQuestionAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if (String.Compare(key, 1, "an", 0, 2, false) == 0)
                  {
                    switch (key[3])
                      {
                        case 'A':
                            if ((String.Compare(key, 4, "lmostMake", 0, 9, false) == 0) && (key.Length == 13))
                                {
                                fromJSONCanAlmostMake(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 4, "ake", 0, 3, false) == 0) && (key.Length == 7))
                                {
                                fromJSONCanMake(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "ngredients", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONIngredients(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraWhatDrinkCanMakeQuestionSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasIngredients);
        if (flagHasIngredients)
          {
            handler.start_pair("Ingredients");
            handler.start_array();
            for (int num1 = 0; num1 < storeIngredients.Count; ++num1)
              {
                if (partial_allowed)
                    storeIngredients[num1].write_partial_as_json(handler);
                else
                    storeIngredients[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasCanMake);
        if (flagHasCanMake)
          {
            handler.start_pair("CanMake");
            handler.start_array();
            for (int num2 = 0; num2 < storeCanMake.Count; ++num2)
              {
                if (partial_allowed)
                    storeCanMake[num2].write_partial_as_json(handler);
                else
                    storeCanMake[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasCanAlmostMake);
        if (flagHasCanAlmostMake)
          {
            handler.start_pair("CanAlmostMake");
            handler.start_array();
            for (int num3 = 0; num3 < storeCanAlmostMake.Count; ++num3)
              {
                if (partial_allowed)
                    storeCanAlmostMake[num3].write_partial_as_json(handler);
                else
                    storeCanAlmostMake[num3].write_as_json(handler);
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
        if (!(hasIngredients()))
          {
            return "When parsing the object for %what%, the \"Ingredients\" field was missing.";
          }
        if (!(hasCanMake()))
          {
            return "When parsing the object for %what%, the \"CanMake\" field was missing.";
          }
        if (!(hasCanAlmostMake()))
          {
            return "When parsing the object for %what%, the \"CanAlmostMake\" field was missing.";
          }
        return null;
      }

    public static new WhatDrinkCanMakeQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WhatDrinkCanMakeQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhatDrinkCanMakeQuestion", ignore_extras);
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
    public static new WhatDrinkCanMakeQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WhatDrinkCanMakeQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WhatDrinkCanMakeQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhatDrinkCanMakeQuestion", ignore_extras);
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
    public static new WhatDrinkCanMakeQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WhatDrinkCanMakeQuestionJSON from_text(string text, bool ignore_extras)
      {
        WhatDrinkCanMakeQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhatDrinkCanMakeQuestion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WhatDrinkCanMakeQuestionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new WhatDrinkCanMakeQuestionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WhatDrinkCanMakeQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhatDrinkCanMakeQuestion", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private DrinkIngredientJSON.HoldingArrayGenerator fieldGeneratorIngredients;
        private DrinkRecipeJSON.HoldingArrayGenerator fieldGeneratorCanMake;
        private DrinkRecipeJSON.HoldingArrayGenerator fieldGeneratorCanAlmostMake;
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
            if (!(getInformationNuggetJSONKey().Equals("WhatDrinkCanMakeNugget")))
                throw new Exception("The key field has a value other than `WhatDrinkCanMakeNugget'.");
            WhatDrinkCanMakeQuestionJSON result = new WhatDrinkCanMakeQuestionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWhatDrinkCanMakeQuestionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((WhatDrinkCanMakeQuestionJSON )new_result);
          }
        protected void finish(WhatDrinkCanMakeQuestionJSON result)
          {
            if (fieldGeneratorIngredients.have_value)
              {
                result.initIngredients();
                int count = fieldGeneratorIngredients.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendIngredients(fieldGeneratorIngredients.value[num]);
                  }
                fieldGeneratorIngredients.value.Clear();
                fieldGeneratorIngredients.have_value = false;
              }
            else if ((!(result.hasIngredients())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Ingredients\" field was missing.");
              }
            if (fieldGeneratorCanMake.have_value)
              {
                result.initCanMake();
                int count = fieldGeneratorCanMake.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCanMake(fieldGeneratorCanMake.value[num]);
                  }
                fieldGeneratorCanMake.value.Clear();
                fieldGeneratorCanMake.have_value = false;
              }
            else if ((!(result.hasCanMake())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CanMake\" field was missing.");
              }
            if (fieldGeneratorCanAlmostMake.have_value)
              {
                result.initCanAlmostMake();
                int count = fieldGeneratorCanAlmostMake.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCanAlmostMake(fieldGeneratorCanAlmostMake.value[num]);
                  }
                fieldGeneratorCanAlmostMake.value.Clear();
                fieldGeneratorCanAlmostMake.have_value = false;
              }
            else if ((!(result.hasCanAlmostMake())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CanAlmostMake\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(WhatDrinkCanMakeQuestionJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "an", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 4, "lmostMake", 0, 9, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorCanAlmostMake;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 4, "ake", 0, 3, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorCanMake;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "ngredients", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorIngredients;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorIngredients = new DrinkIngredientJSON.HoldingArrayGenerator("field \"Ingredients\" of the WhatDrinkCanMakeQuestion class", ignore_extras);
            fieldGeneratorCanMake = new DrinkRecipeJSON.HoldingArrayGenerator("field \"CanMake\" of the WhatDrinkCanMakeQuestion class", ignore_extras);
            fieldGeneratorCanAlmostMake = new DrinkRecipeJSON.HoldingArrayGenerator("field \"CanAlmostMake\" of the WhatDrinkCanMakeQuestion class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WhatDrinkCanMakeQuestion class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorIngredients = new DrinkIngredientJSON.HoldingArrayGenerator("field \"Ingredients\" of the WhatDrinkCanMakeQuestion class", false);
            fieldGeneratorCanMake = new DrinkRecipeJSON.HoldingArrayGenerator("field \"CanMake\" of the WhatDrinkCanMakeQuestion class", false);
            fieldGeneratorCanAlmostMake = new DrinkRecipeJSON.HoldingArrayGenerator("field \"CanAlmostMake\" of the WhatDrinkCanMakeQuestion class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WhatDrinkCanMakeQuestion class");
          }

        public override void reset()
          {
            fieldGeneratorIngredients.reset();
            fieldGeneratorCanMake.reset();
            fieldGeneratorCanAlmostMake.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(WhatDrinkCanMakeQuestionJSON  result)
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
        public WhatDrinkCanMakeQuestionJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WhatDrinkCanMakeQuestionJSON  result)
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
    protected virtual void handle_result(List<WhatDrinkCanMakeQuestionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WhatDrinkCanMakeQuestionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WhatDrinkCanMakeQuestionJSON>();
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
    public List<WhatDrinkCanMakeQuestionJSON> value;
  };
  };
