/* file "NutritionInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class NutritionInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeNutritionCommandKind
      {
        NutritionCommandKind_NutritionCommand
      };

    public static TypeNutritionCommandKind  stringToNutritionCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "NutritionCommand", 0, 16, false) == 0) && (chars.Length == 16))
            return TypeNutritionCommandKind.NutritionCommandKind_NutritionCommand;
        throw new Exception("The value for field `NutritionCommandKind' is not one of the legal values.");
      }

    public static string  stringFromNutritionCommandKind(TypeNutritionCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeNutritionCommandKind.NutritionCommandKind_NutritionCommand:
                return "NutritionCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasNutritionCommandKind;
    private bool flagHasNutrients;
    private List< NutrientJSON  > storeNutrients;
    private bool flagHasFoodBlocks;
    private List< List< FoodJSON  > > storeFoodBlocks;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNutritionCommandKindToJSON()
      {
        JSONStringValue generated_string_NutritionCommandKind;
        generated_string_NutritionCommandKind = new JSONStringValue("NutritionCommand");
        return generated_string_NutritionCommandKind;
      }

    private JSONValue  extraNutrientsToJSON()
      {
        JSONArrayValue generated_array_1_Nutrients = new JSONArrayValue();
        for (int num1 = 0; num1 < storeNutrients.Count; ++num1)
          {
            JSONValueHandler handler_Nutrients = new JSONValueHandler();
            storeNutrients[num1].write_as_json(handler_Nutrients);
            generated_array_1_Nutrients.appendComponent(handler_Nutrients.result);
          }
        return generated_array_1_Nutrients;
      }

    private JSONValue  extraFoodBlocksToJSON()
      {
        JSONArrayValue generated_array_2_FoodBlocks = new JSONArrayValue();
        for (int num2 = 0; num2 < storeFoodBlocks.Count; ++num2)
          {
            JSONArrayValue generated_array_3_FoodBlocks = new JSONArrayValue();
            for (int num3 = 0; num3 < storeFoodBlocks[num2].Count; ++num3)
              {
                JSONValueHandler handler_FoodBlocks = new JSONValueHandler();
                storeFoodBlocks[num2][num3].write_as_json(handler_FoodBlocks);
                generated_array_3_FoodBlocks.appendComponent(handler_FoodBlocks.result);
              }
            generated_array_2_FoodBlocks.appendComponent(generated_array_3_FoodBlocks);
          }
        return generated_array_2_FoodBlocks;
      }


    private void  fromJSONNutritionCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NutritionCommandKind of NutritionInformationNuggetJSON is not a string.");
        if (!(json_string.getData().Equals("NutritionCommand")))
            throw new Exception("The value for field NutritionCommandKind of NutritionInformationNuggetJSON is not `NutritionCommand'.");
        setNutritionCommandKind();
      }


    private void  fromJSONNutrients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Nutrients of NutritionInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< NutrientJSON  > vector_Nutrients1 = new List< NutrientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            NutrientJSON convert_classy = NutrientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Nutrients1.Add(convert_classy);
          }
        initNutrients();
        for (int num1 = 0; num1 < vector_Nutrients1.Count; ++num1)
            appendNutrients(vector_Nutrients1[num1]);
        for (int num1 = 0; num1 < vector_Nutrients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONFoodBlocks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FoodBlocks of NutritionInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< List< FoodJSON  > > vector_FoodBlocks1 = new List< List< FoodJSON  > >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONArrayValue json_array2 = json_array1.component(num1).array_value();
            if (json_array2 == null)
                throw new Exception("The value for an element of field FoodBlocks of NutritionInformationNuggetJSON is not an array.");
            int count2 = json_array2.componentCount();
            List< FoodJSON  > vector_FoodBlocks2 = new List< FoodJSON  >(count2);
            for (int num2 = 0; num2 < count2; ++num2)
              {
                FoodJSON convert_classy = FoodJSON.from_json(json_array2.component(num2), ignore_extras, true);
                vector_FoodBlocks2.Add(convert_classy);
              }
            vector_FoodBlocks1.Add(vector_FoodBlocks2);
          }
        initFoodBlocks();
        for (int num2 = 0; num2 < vector_FoodBlocks1.Count; ++num2)
            appendFoodBlocks(vector_FoodBlocks1[num2]);
        for (int num1 = 0; num1 < vector_FoodBlocks1.Count; ++num1)
          {
            for (int num2 = 0; num2 < vector_FoodBlocks1[num1].Count; ++num2)
              {
              }
          }
      }


    public NutritionInformationNuggetJSON()
      {
        flagHasNutritionCommandKind = false;
        flagHasNutrients = false;
        flagHasFoodBlocks = false;
        storeNutrients = new List< NutrientJSON  >();
        storeFoodBlocks = new List< List< FoodJSON  > >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "Nutrition";
      }

    public bool  hasNutritionCommandKind()
      {
        return flagHasNutritionCommandKind;
      }

    public TypeNutritionCommandKind  getNutritionCommandKind()
      {
        Debug.Assert(flagHasNutritionCommandKind);
        return TypeNutritionCommandKind.NutritionCommandKind_NutritionCommand;
      }

    public string  getNutritionCommandKindAsString()
      {
        return stringFromNutritionCommandKind(getNutritionCommandKind());
      }

    public bool  hasNutrients()
      {
        return flagHasNutrients;
      }

    public int  countOfNutrients()
      {
        Debug.Assert(flagHasNutrients);
        return storeNutrients.Count;
      }

    public NutrientJSON   elementOfNutrients(int element_num)
      {
        Debug.Assert(flagHasNutrients);
        return storeNutrients[element_num];
      }

    public List< NutrientJSON  >  getNutrients()
      {
        Debug.Assert(flagHasNutrients);
        return storeNutrients;
      }

    public bool  hasFoodBlocks()
      {
        return flagHasFoodBlocks;
      }

    public int  countOfFoodBlocks()
      {
        Debug.Assert(flagHasFoodBlocks);
        return storeFoodBlocks.Count;
      }

    public List< FoodJSON  >  elementOfFoodBlocks(int element_num)
      {
        Debug.Assert(flagHasFoodBlocks);
        return storeFoodBlocks[element_num];
      }

    public List< List< FoodJSON  > >  getFoodBlocks()
      {
        Debug.Assert(flagHasFoodBlocks);
        return storeFoodBlocks;
      }


    public virtual int extraNutritionInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraNutritionInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraNutritionInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraNutritionInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasNutritionCommandKind)
            ++result;
        if (flagHasNutrients)
            ++result;
        if (flagHasFoodBlocks)
            ++result;
        result += extraNutritionInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNutritionCommandKind)
          {
            if (remainder == 0)
                return "NutritionCommandKind";
            --remainder;
          }
        if (flagHasNutrients)
          {
            if (remainder == 0)
                return "Nutrients";
            --remainder;
          }
        if (flagHasFoodBlocks)
          {
            if (remainder == 0)
                return "FoodBlocks";
            --remainder;
          }
        return extraNutritionInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNutritionCommandKind)
          {
            if (remainder == 0)
                return extraNutritionCommandKindToJSON();
            --remainder;
          }
        if (flagHasNutrients)
          {
            if (remainder == 0)
                return extraNutrientsToJSON();
            --remainder;
          }
        if (flagHasFoodBlocks)
          {
            if (remainder == 0)
                return extraFoodBlocksToJSON();
            --remainder;
          }
        return extraNutritionInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'F':
                if ((String.Compare(field_name, 1, "oodBlocks", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasFoodBlocks ? extraFoodBlocksToJSON() : null);
                break;
            case 'N':
                if (String.Compare(field_name, 1, "utri", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 6, "nts", 0, 3, false) == 0) && (field_name.Length == 9))
                                return (flagHasNutrients ? extraNutrientsToJSON() : null);
                            break;
                        case 't':
                            if ((String.Compare(field_name, 6, "ionCommandKind", 0, 14, false) == 0) && (field_name.Length == 20))
                                return (flagHasNutritionCommandKind ? extraNutritionCommandKindToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraNutritionInformationNuggetLookup(field_name);
      }

    public void setNutritionCommandKind()
      {
        flagHasNutritionCommandKind = true;
      }
    public void setNutritionCommandKind(TypeNutritionCommandKind new_value)
      {
        setNutritionCommandKind();
      }
    public void setNutritionCommandKind(string chars)
      {
        setNutritionCommandKind(stringToNutritionCommandKind(chars));
      }
    public void unsetNutritionCommandKind()
      {
        flagHasNutritionCommandKind = false;
      }
    public void initNutrients()
      {
        if (flagHasNutrients)
          {
            for (int num1 = 0; num1 < storeNutrients.Count; ++num1)
              {
              }
          }
        flagHasNutrients = true;
        storeNutrients.Clear();
      }
    public void appendNutrients(NutrientJSON  to_append)
      {
        if (!flagHasNutrients)
          {
            flagHasNutrients = true;
            storeNutrients.Clear();
          }
        Debug.Assert(flagHasNutrients);
        storeNutrients.Add(to_append);
      }
    public void unsetNutrients()
      {
        if (flagHasNutrients)
          {
            for (int num2 = 0; num2 < storeNutrients.Count; ++num2)
              {
              }
          }
        flagHasNutrients = false;
        storeNutrients.Clear();
      }
    public void initFoodBlocks()
      {
        if (flagHasFoodBlocks)
          {
            for (int num3 = 0; num3 < storeFoodBlocks.Count; ++num3)
              {
                for (int num4 = 0; num4 < storeFoodBlocks[num3].Count; ++num4)
                  {
                  }
              }
          }
        flagHasFoodBlocks = true;
        storeFoodBlocks.Clear();
      }
    public void appendFoodBlocks(List< FoodJSON  > to_append)
      {
        if (!flagHasFoodBlocks)
          {
            flagHasFoodBlocks = true;
            storeFoodBlocks.Clear();
          }
        Debug.Assert(flagHasFoodBlocks);
        for (int num1 = 0; num1 < to_append.Count; ++num1)
          {
          }
        storeFoodBlocks.Add(to_append);
      }
    public void unsetFoodBlocks()
      {
        if (flagHasFoodBlocks)
          {
            for (int num5 = 0; num5 < storeFoodBlocks.Count; ++num5)
              {
                for (int num6 = 0; num6 < storeFoodBlocks[num5].Count; ++num6)
                  {
                  }
              }
          }
        flagHasFoodBlocks = false;
        storeFoodBlocks.Clear();
      }

    public virtual void extraNutritionInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraNutritionInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraNutritionInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraNutritionInformationNuggetAppendPair(key, new_component);
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
            case 'F':
                if ((String.Compare(key, 1, "oodBlocks", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONFoodBlocks(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if (String.Compare(key, 1, "utri", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'e':
                            if ((String.Compare(key, 6, "nts", 0, 3, false) == 0) && (key.Length == 9))
                                {
                                fromJSONNutrients(new_component, false);
                                return;
                                }
                            break;
                        case 't':
                            if ((String.Compare(key, 6, "ionCommandKind", 0, 14, false) == 0) && (key.Length == 20))
                                {
                                fromJSONNutritionCommandKind(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraNutritionInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                if ((String.Compare(key, 1, "oodBlocks", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONFoodBlocks(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if (String.Compare(key, 1, "utri", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'e':
                            if ((String.Compare(key, 6, "nts", 0, 3, false) == 0) && (key.Length == 9))
                                {
                                fromJSONNutrients(new_component, false);
                                return;
                                }
                            break;
                        case 't':
                            if ((String.Compare(key, 6, "ionCommandKind", 0, 14, false) == 0) && (key.Length == 20))
                                {
                                fromJSONNutritionCommandKind(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraNutritionInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNutritionCommandKind);
        if (flagHasNutritionCommandKind)
          {
            handler.start_pair("NutritionCommandKind");
            handler.string_value("NutritionCommand");
          }
        Debug.Assert(partial_allowed || flagHasNutrients);
        if (flagHasNutrients)
          {
            handler.start_pair("Nutrients");
            handler.start_array();
            for (int num1 = 0; num1 < storeNutrients.Count; ++num1)
              {
                if (partial_allowed)
                    storeNutrients[num1].write_partial_as_json(handler);
                else
                    storeNutrients[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasFoodBlocks);
        if (flagHasFoodBlocks)
          {
            handler.start_pair("FoodBlocks");
            handler.start_array();
            for (int num2 = 0; num2 < storeFoodBlocks.Count; ++num2)
              {
                handler.start_array();
                for (int num3 = 0; num3 < storeFoodBlocks[num2].Count; ++num3)
                  {
                    if (partial_allowed)
                        storeFoodBlocks[num2][num3].write_partial_as_json(handler);
                    else
                        storeFoodBlocks[num2][num3].write_as_json(handler);
                  }
                handler.finish_array();
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
        if (!(hasNutritionCommandKind()))
          {
            return "When parsing the object for %what%, the \"NutritionCommandKind\" field was missing.";
          }
        if (!(hasNutrients()))
          {
            return "When parsing the object for %what%, the \"Nutrients\" field was missing.";
          }
        if (!(hasFoodBlocks()))
          {
            return "When parsing the object for %what%, the \"FoodBlocks\" field was missing.";
          }
        return null;
      }

    public static new NutritionInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NutritionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NutritionInformationNugget", ignore_extras);
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
    public static new NutritionInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new NutritionInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NutritionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NutritionInformationNugget", ignore_extras);
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
    public static new NutritionInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new NutritionInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        NutritionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NutritionInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NutritionInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new NutritionInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NutritionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NutritionInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorNutritionCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorNutritionCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNutritionCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNutritionCommandKind(result));
              }
            protected abstract void handle_result(TypeNutritionCommandKind result);
          };
    private class FieldHoldingGeneratorNutritionCommandKind : FieldGeneratorNutritionCommandKind
  {
    protected override void handle_result(TypeNutritionCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNutritionCommandKind(String what)
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
    public TypeNutritionCommandKind value;
  };
    private class FieldHoldingArrayGeneratorNutritionCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNutritionCommandKind
      {
        private FieldHoldingArrayGeneratorNutritionCommandKind top;

        protected override void handle_result(TypeNutritionCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNutritionCommandKind init_top)
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
    protected virtual void handle_result(List<TypeNutritionCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorNutritionCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNutritionCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNutritionCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNutritionCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNutritionCommandKind> value;
  };
        private FieldHoldingGeneratorNutritionCommandKind fieldGeneratorNutritionCommandKind;
        private NutrientJSON.HoldingArrayGenerator fieldGeneratorNutrients;
    private class FieldHoldingArrayGeneratorFoodBlocks : JSONArrayGenerator
  {
    protected class ElementHandler : FoodJSON.HoldingArrayGenerator
      {
        private FieldHoldingArrayGeneratorFoodBlocks top;

        protected override void handle_result(List< FoodJSON  > result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFoodBlocks init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<List< FoodJSON  >> result)
      {
      }

    public FieldHoldingArrayGeneratorFoodBlocks(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< FoodJSON  >>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFoodBlocks(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< FoodJSON  >>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<List< FoodJSON  >> value;
  };
        private FieldHoldingArrayGeneratorFoodBlocks fieldGeneratorFoodBlocks;
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
            if (!(getInformationNuggetJSONKey().Equals("Nutrition")))
                throw new Exception("The key field has a value other than `Nutrition'.");
            NutritionInformationNuggetJSON result = new NutritionInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraNutritionInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((NutritionInformationNuggetJSON )new_result);
          }
        protected void finish(NutritionInformationNuggetJSON result)
          {
            if (fieldGeneratorNutritionCommandKind.have_value)
              {
                result.setNutritionCommandKind();
                fieldGeneratorNutritionCommandKind.have_value = false;
              }
            else if ((!(result.hasNutritionCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NutritionCommandKind\" field was missing.");
              }
            if (fieldGeneratorNutrients.have_value)
              {
                result.initNutrients();
                int count = fieldGeneratorNutrients.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNutrients(fieldGeneratorNutrients.value[num]);
                  }
                fieldGeneratorNutrients.value.Clear();
                fieldGeneratorNutrients.have_value = false;
              }
            else if ((!(result.hasNutrients())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Nutrients\" field was missing.");
              }
            if (fieldGeneratorFoodBlocks.have_value)
              {
                result.initFoodBlocks();
                int count = fieldGeneratorFoodBlocks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    List< FoodJSON  > unwrapped0 = new List< FoodJSON  >();
                    for (int num0 = 0; num0 < fieldGeneratorFoodBlocks.value[num].Count; ++num0)
                      {
                        unwrapped0.Add(fieldGeneratorFoodBlocks.value[num][num0]);
                      }
                    result.appendFoodBlocks(unwrapped0);
                  }
                fieldGeneratorFoodBlocks.value.Clear();
                fieldGeneratorFoodBlocks.have_value = false;
              }
            else if ((!(result.hasFoodBlocks())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FoodBlocks\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(NutritionInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "oodBlocks", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorFoodBlocks;
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "utri", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 6, "nts", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorNutrients;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 6, "ionCommandKind", 0, 14, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorNutritionCommandKind;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNutritionCommandKind = new FieldHoldingGeneratorNutritionCommandKind("field \"NutritionCommandKind\" of the NutritionInformationNugget class");
            fieldGeneratorNutrients = new NutrientJSON.HoldingArrayGenerator("field \"Nutrients\" of the NutritionInformationNugget class", ignore_extras);
            fieldGeneratorFoodBlocks = new FieldHoldingArrayGeneratorFoodBlocks("field \"FoodBlocks\" of the NutritionInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the NutritionInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNutritionCommandKind = new FieldHoldingGeneratorNutritionCommandKind("field \"NutritionCommandKind\" of the NutritionInformationNugget class");
            fieldGeneratorNutrients = new NutrientJSON.HoldingArrayGenerator("field \"Nutrients\" of the NutritionInformationNugget class", false);
            fieldGeneratorFoodBlocks = new FieldHoldingArrayGeneratorFoodBlocks("field \"FoodBlocks\" of the NutritionInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the NutritionInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorNutritionCommandKind.reset();
            fieldGeneratorNutrients.reset();
            fieldGeneratorFoodBlocks.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(NutritionInformationNuggetJSON  result)
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
        public NutritionInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NutritionInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<NutritionInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NutritionInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NutritionInformationNuggetJSON>();
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
    public List<NutritionInformationNuggetJSON> value;
  };
  };
