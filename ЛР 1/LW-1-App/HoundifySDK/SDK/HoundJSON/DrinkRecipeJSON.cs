/* file "DrinkRecipeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DrinkRecipeJSON : JSONBase
  {
    public enum TypeTagsKnownValues
      {
        Tags_fruity,
        Tags_strong,
        Tags_weak,
        Tags_bitter,
        Tags_sweet,
        Tags_easy,
        Tags_blue,
        Tags_green,
        Tags_red,
        Tags__none
      };
    public struct TypeTags
      {
        public bool in_known_list;
        public string string_value;
        public TypeTagsKnownValues list_value;
      };

    public static TypeTagsKnownValues  stringToTags(string chars)
      {
        switch (chars[0])
          {
            case 'b':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "tter", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeTagsKnownValues.Tags_bitter;
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "ue", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeTagsKnownValues.Tags_blue;
                        break;
                    default:
                        break;
                  }
                break;
            case 'e':
                if ((String.Compare(chars, 1, "asy", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeTagsKnownValues.Tags_easy;
                break;
            case 'f':
                if ((String.Compare(chars, 1, "ruity", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeTagsKnownValues.Tags_fruity;
                break;
            case 'g':
                if ((String.Compare(chars, 1, "reen", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeTagsKnownValues.Tags_green;
                break;
            case 'r':
                if ((String.Compare(chars, 1, "ed", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeTagsKnownValues.Tags_red;
                break;
            case 's':
                switch (chars[1])
                  {
                    case 't':
                        if ((String.Compare(chars, 2, "rong", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeTagsKnownValues.Tags_strong;
                        break;
                    case 'w':
                        if ((String.Compare(chars, 2, "eet", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeTagsKnownValues.Tags_sweet;
                        break;
                    default:
                        break;
                  }
                break;
            case 'w':
                if ((String.Compare(chars, 1, "eak", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeTagsKnownValues.Tags_weak;
                break;
            default:
                break;
          }
        return TypeTagsKnownValues.Tags__none;
      }

    public static string  stringFromTags(TypeTagsKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTagsKnownValues.Tags_fruity:
                return "fruity";
            case TypeTagsKnownValues.Tags_strong:
                return "strong";
            case TypeTagsKnownValues.Tags_weak:
                return "weak";
            case TypeTagsKnownValues.Tags_bitter:
                return "bitter";
            case TypeTagsKnownValues.Tags_sweet:
                return "sweet";
            case TypeTagsKnownValues.Tags_easy:
                return "easy";
            case TypeTagsKnownValues.Tags_blue:
                return "blue";
            case TypeTagsKnownValues.Tags_green:
                return "green";
            case TypeTagsKnownValues.Tags_red:
                return "red";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasName;
    private string storeName;
    private bool flagHasGlass;
    private string storeGlass;
    private bool flagHasImage;
    private string storeImage;
    private bool flagHasTags;
    private List< TypeTags > storeTags;
    private bool flagHasIngredients;
    private List< DrinkIngredientJSON  > storeIngredients;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of DrinkRecipeJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONGlass(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Glass of DrinkRecipeJSON is not a string.");
        setGlass(json_string.getData());
      }


    private void  fromJSONImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Image of DrinkRecipeJSON is not a string.");
        setImage(json_string.getData());
      }


    private void  fromJSONTags(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Tags of DrinkRecipeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeTags > vector_Tags1 = new List< TypeTags >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Tags of DrinkRecipeJSON is not a string.");
            TypeTags the_open_enum = new TypeTags();
            switch (json_string.getData()[0])
              {
                case 'b':
                    switch (json_string.getData()[1])
                      {
                        case 'i':
                            if ((String.Compare(json_string.getData(), 2, "tter", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTagsKnownValues.Tags_bitter;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'l':
                            if ((String.Compare(json_string.getData(), 2, "ue", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTagsKnownValues.Tags_blue;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'e':
                    if ((String.Compare(json_string.getData(), 1, "asy", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeTagsKnownValues.Tags_easy;
                            goto open_enum_is_done;
                          }
                    break;
                case 'f':
                    if ((String.Compare(json_string.getData(), 1, "ruity", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeTagsKnownValues.Tags_fruity;
                            goto open_enum_is_done;
                          }
                    break;
                case 'g':
                    if ((String.Compare(json_string.getData(), 1, "reen", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeTagsKnownValues.Tags_green;
                            goto open_enum_is_done;
                          }
                    break;
                case 'r':
                    if ((String.Compare(json_string.getData(), 1, "ed", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeTagsKnownValues.Tags_red;
                            goto open_enum_is_done;
                          }
                    break;
                case 's':
                    switch (json_string.getData()[1])
                      {
                        case 't':
                            if ((String.Compare(json_string.getData(), 2, "rong", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTagsKnownValues.Tags_strong;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'w':
                            if ((String.Compare(json_string.getData(), 2, "eet", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTagsKnownValues.Tags_sweet;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'w':
                    if ((String.Compare(json_string.getData(), 1, "eak", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeTagsKnownValues.Tags_weak;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            vector_Tags1.Add(the_open_enum);
          }
        initTags();
        for (int num1 = 0; num1 < vector_Tags1.Count; ++num1)
            appendTags(vector_Tags1[num1]);
        for (int num1 = 0; num1 < vector_Tags1.Count; ++num1)
          {
          }
      }


    private void  fromJSONIngredients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Ingredients of DrinkRecipeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DrinkIngredientJSON  > vector_Ingredients1 = new List< DrinkIngredientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DrinkIngredientJSON convert_classy = DrinkIngredientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Ingredients1.Add(convert_classy);
          }
        initIngredients();
        for (int num2 = 0; num2 < vector_Ingredients1.Count; ++num2)
            appendIngredients(vector_Ingredients1[num2]);
        for (int num1 = 0; num1 < vector_Ingredients1.Count; ++num1)
          {
          }
      }


    public DrinkRecipeJSON()
      {
        flagHasName = false;
        flagHasGlass = false;
        flagHasImage = false;
        flagHasTags = false;
        flagHasIngredients = false;
        storeTags = new List< TypeTags >();
        storeIngredients = new List< DrinkIngredientJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasGlass()
      {
        return flagHasGlass;
      }

    public string  getGlass()
      {
        Debug.Assert(flagHasGlass);
        return storeGlass;
      }

    public bool  hasImage()
      {
        return flagHasImage;
      }

    public string  getImage()
      {
        Debug.Assert(flagHasImage);
        return storeImage;
      }

    public bool  hasTags()
      {
        return flagHasTags;
      }

    public int  countOfTags()
      {
        Debug.Assert(flagHasTags);
        return storeTags.Count;
      }

    public TypeTags  elementOfTags(int element_num)
      {
        Debug.Assert(flagHasTags);
        return storeTags[element_num];
      }

    public List< TypeTags >  getTags()
      {
        Debug.Assert(flagHasTags);
        return storeTags;
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


    public virtual int extraDrinkRecipeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDrinkRecipeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDrinkRecipeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDrinkRecipeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setGlass(string new_value)
      {
        flagHasGlass = true;
        storeGlass = new_value;
      }
    public void unsetGlass()
      {
        flagHasGlass = false;
      }
    public void setImage(string new_value)
      {
        flagHasImage = true;
        storeImage = new_value;
      }
    public void unsetImage()
      {
        flagHasImage = false;
      }
    public void initTags()
      {
        flagHasTags = true;
        storeTags.Clear();
      }
    public void appendTags(TypeTags to_append)
      {
        if (!flagHasTags)
          {
            flagHasTags = true;
            storeTags.Clear();
          }
        Debug.Assert(flagHasTags);
        storeTags.Add(to_append);
      }
    public void appendTags(string chars)
      {
        TypeTagsKnownValues known = stringToTags(chars);
        TypeTags new_value = new TypeTags();
        if (known == TypeTagsKnownValues.Tags__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendTags(new_value);
      }
    public void appendTags(TypeTagsKnownValues new_value)
      {
        TypeTags new_full_value = new TypeTags();
        Debug.Assert(new_value != TypeTagsKnownValues.Tags__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        appendTags(new_full_value);
      }
    public void unsetTags()
      {
        flagHasTags = false;
        storeTags.Clear();
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

    public virtual void extraDrinkRecipeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDrinkRecipeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDrinkRecipeLookup(key);
        if (old_field == null)
          {
            extraDrinkRecipeAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasGlass)
          {
            handler.start_pair("Glass");
            handler.string_value(storeGlass);
          }
        if (flagHasImage)
          {
            handler.start_pair("Image");
            handler.string_value(storeImage);
          }
        if (flagHasTags)
          {
            handler.start_pair("Tags");
            handler.start_array();
            for (int num1 = 0; num1 < storeTags.Count; ++num1)
              {
                if (storeTags[num1].in_known_list)
                  {
                    switch (storeTags[num1].list_value)
                      {
                        case TypeTagsKnownValues.Tags_fruity:
                            handler.string_value("fruity");
                            break;
                        case TypeTagsKnownValues.Tags_strong:
                            handler.string_value("strong");
                            break;
                        case TypeTagsKnownValues.Tags_weak:
                            handler.string_value("weak");
                            break;
                        case TypeTagsKnownValues.Tags_bitter:
                            handler.string_value("bitter");
                            break;
                        case TypeTagsKnownValues.Tags_sweet:
                            handler.string_value("sweet");
                            break;
                        case TypeTagsKnownValues.Tags_easy:
                            handler.string_value("easy");
                            break;
                        case TypeTagsKnownValues.Tags_blue:
                            handler.string_value("blue");
                            break;
                        case TypeTagsKnownValues.Tags_green:
                            handler.string_value("green");
                            break;
                        case TypeTagsKnownValues.Tags_red:
                            handler.string_value("red");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeTags[num1].string_value);
                  }
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasIngredients);
        if (flagHasIngredients)
          {
            handler.start_pair("Ingredients");
            handler.start_array();
            for (int num2 = 0; num2 < storeIngredients.Count; ++num2)
              {
                if (partial_allowed)
                    storeIngredients[num2].write_partial_as_json(handler);
                else
                    storeIngredients[num2].write_as_json(handler);
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        if (!(hasIngredients()))
          {
            return "When parsing the object for %what%, the \"Ingredients\" field was missing.";
          }
        return null;
      }

    public static DrinkRecipeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DrinkRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DrinkRecipe", ignore_extras);
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
    public static DrinkRecipeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DrinkRecipeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DrinkRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DrinkRecipe", ignore_extras);
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
    public static DrinkRecipeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DrinkRecipeJSON from_text(string text, bool ignore_extras)
      {
        DrinkRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DrinkRecipe", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DrinkRecipeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DrinkRecipeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DrinkRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DrinkRecipe", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorGlass;
        private JSONHoldingStringGenerator fieldGeneratorImage;
    private abstract class FieldGeneratorTags : JSONStringGenerator
          {
            protected FieldGeneratorTags(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTags()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTagsKnownValues known = stringToTags(result);
                TypeTags new_value = new TypeTags();
                if (known == TypeTagsKnownValues.Tags__none)
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
            protected abstract void handle_result(TypeTags result);
          };
    private class FieldHoldingGeneratorTags : FieldGeneratorTags
  {
    protected override void handle_result(TypeTags result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTags(String what)
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
    public TypeTags value;
  };
    private class FieldHoldingArrayGeneratorTags : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTags
      {
        private FieldHoldingArrayGeneratorTags top;

        protected override void handle_result(TypeTags result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTags init_top)
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
    protected virtual void handle_result(List<TypeTags> result)
      {
      }

    public FieldHoldingArrayGeneratorTags(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTags>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTags()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTags>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTags> value;
  };
        private FieldHoldingArrayGeneratorTags fieldGeneratorTags;
        private DrinkIngredientJSON.HoldingArrayGenerator fieldGeneratorIngredients;
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
            DrinkRecipeJSON result = new DrinkRecipeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDrinkRecipeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DrinkRecipeJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorGlass.have_value)
              {
                result.setGlass(fieldGeneratorGlass.value);
                fieldGeneratorGlass.have_value = false;
              }
            if (fieldGeneratorImage.have_value)
              {
                result.setImage(fieldGeneratorImage.value);
                fieldGeneratorImage.have_value = false;
              }
            if (fieldGeneratorTags.have_value)
              {
                result.initTags();
                int count = fieldGeneratorTags.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTags(fieldGeneratorTags.value[num]);
                  }
                fieldGeneratorTags.value.Clear();
                fieldGeneratorTags.have_value = false;
              }
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
          }
        protected abstract void handle_result(DrinkRecipeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'G':
                    if ((String.Compare(field_name, 1, "lass", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorGlass;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "age", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorImage;
                            break;
                        case 'n':
                            if ((String.Compare(field_name, 2, "gredients", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorIngredients;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ags", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorTags;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the DrinkRecipe class");
            fieldGeneratorGlass = new JSONHoldingStringGenerator("field \"Glass\" of the DrinkRecipe class");
            fieldGeneratorImage = new JSONHoldingStringGenerator("field \"Image\" of the DrinkRecipe class");
            fieldGeneratorTags = new FieldHoldingArrayGeneratorTags("field \"Tags\" of the DrinkRecipe class");
            fieldGeneratorIngredients = new DrinkIngredientJSON.HoldingArrayGenerator("field \"Ingredients\" of the DrinkRecipe class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DrinkRecipe class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the DrinkRecipe class");
            fieldGeneratorGlass = new JSONHoldingStringGenerator("field \"Glass\" of the DrinkRecipe class");
            fieldGeneratorImage = new JSONHoldingStringGenerator("field \"Image\" of the DrinkRecipe class");
            fieldGeneratorTags = new FieldHoldingArrayGeneratorTags("field \"Tags\" of the DrinkRecipe class");
            fieldGeneratorIngredients = new DrinkIngredientJSON.HoldingArrayGenerator("field \"Ingredients\" of the DrinkRecipe class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DrinkRecipe class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorGlass.reset();
            fieldGeneratorImage.reset();
            fieldGeneratorTags.reset();
            fieldGeneratorIngredients.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorIngredients.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorIngredients.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DrinkRecipeJSON  result)
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
        public DrinkRecipeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DrinkRecipeJSON  result)
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
    protected virtual void handle_result(List<DrinkRecipeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DrinkRecipeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DrinkRecipeJSON>();
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
    public List<DrinkRecipeJSON> value;
  };
  };
