/* file "RecipeSearchSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RecipeSearchSpecJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasCuisine;
    private string storeCuisine;
    private bool flagHasCategory;
    private string storeCategory;
    private bool flagHasIncludedIngredients;
    private List< string > storeIncludedIngredients;
    private bool flagHasExcludedIngredients;
    private List< string > storeExcludedIngredients;
    private bool flagHasTimeToCook;
    private BigInteger storeTimeToCook;
    private bool flagHasPageNumber;
    private BigInteger storePageNumber;
    private bool flagHasOptions;
    private List< bool > storeOptions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of RecipeSearchSpecJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONCuisine(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Cuisine of RecipeSearchSpecJSON is not a string.");
        setCuisine(json_string.getData());
      }


    private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Category of RecipeSearchSpecJSON is not a string.");
        setCategory(json_string.getData());
      }


    private void  fromJSONIncludedIngredients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field IncludedIngredients of RecipeSearchSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_IncludedIngredients1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field IncludedIngredients of RecipeSearchSpecJSON is not a string.");
            vector_IncludedIngredients1.Add(json_string.getData());
          }
        initIncludedIngredients();
        for (int num1 = 0; num1 < vector_IncludedIngredients1.Count; ++num1)
            appendIncludedIngredients(vector_IncludedIngredients1[num1]);
        for (int num1 = 0; num1 < vector_IncludedIngredients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONExcludedIngredients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ExcludedIngredients of RecipeSearchSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ExcludedIngredients1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ExcludedIngredients of RecipeSearchSpecJSON is not a string.");
            vector_ExcludedIngredients1.Add(json_string.getData());
          }
        initExcludedIngredients();
        for (int num2 = 0; num2 < vector_ExcludedIngredients1.Count; ++num2)
            appendExcludedIngredients(vector_ExcludedIngredients1[num2]);
        for (int num1 = 0; num1 < vector_ExcludedIngredients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTimeToCook(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TimeToCook of RecipeSearchSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TimeToCook of RecipeSearchSpecJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTimeToCook(extracted_integer);
      }


    private void  fromJSONPageNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PageNumber of RecipeSearchSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PageNumber of RecipeSearchSpecJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPageNumber(extracted_integer);
      }


    private void  fromJSONOptions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Options of RecipeSearchSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_Options1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field Options of RecipeSearchSpecJSON is not true for false.");
                  }
              }
            vector_Options1.Add(the_bool);
          }
        initOptions();
        for (int num3 = 0; num3 < vector_Options1.Count; ++num3)
            appendOptions(vector_Options1[num3]);
        for (int num1 = 0; num1 < vector_Options1.Count; ++num1)
          {
          }
      }


    public RecipeSearchSpecJSON()
      {
        flagHasName = false;
        flagHasCuisine = false;
        flagHasCategory = false;
        flagHasIncludedIngredients = false;
        flagHasExcludedIngredients = false;
        flagHasTimeToCook = false;
        flagHasPageNumber = false;
        flagHasOptions = false;
        storeIncludedIngredients = new List< string >();
        storeExcludedIngredients = new List< string >();
        storeOptions = new List< bool >();
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

    public bool  hasCuisine()
      {
        return flagHasCuisine;
      }

    public string  getCuisine()
      {
        Debug.Assert(flagHasCuisine);
        return storeCuisine;
      }

    public bool  hasCategory()
      {
        return flagHasCategory;
      }

    public string  getCategory()
      {
        Debug.Assert(flagHasCategory);
        return storeCategory;
      }

    public bool  hasIncludedIngredients()
      {
        return flagHasIncludedIngredients;
      }

    public int  countOfIncludedIngredients()
      {
        Debug.Assert(flagHasIncludedIngredients);
        return storeIncludedIngredients.Count;
      }

    public string  elementOfIncludedIngredients(int element_num)
      {
        Debug.Assert(flagHasIncludedIngredients);
        return storeIncludedIngredients[element_num];
      }

    public List< string >  getIncludedIngredients()
      {
        Debug.Assert(flagHasIncludedIngredients);
        return storeIncludedIngredients;
      }

    public bool  hasExcludedIngredients()
      {
        return flagHasExcludedIngredients;
      }

    public int  countOfExcludedIngredients()
      {
        Debug.Assert(flagHasExcludedIngredients);
        return storeExcludedIngredients.Count;
      }

    public string  elementOfExcludedIngredients(int element_num)
      {
        Debug.Assert(flagHasExcludedIngredients);
        return storeExcludedIngredients[element_num];
      }

    public List< string >  getExcludedIngredients()
      {
        Debug.Assert(flagHasExcludedIngredients);
        return storeExcludedIngredients;
      }

    public bool  hasTimeToCook()
      {
        return flagHasTimeToCook;
      }

    public BigInteger  getTimeToCook()
      {
        Debug.Assert(flagHasTimeToCook);
        return storeTimeToCook;
      }

    public bool  hasPageNumber()
      {
        return flagHasPageNumber;
      }

    public BigInteger  getPageNumber()
      {
        Debug.Assert(flagHasPageNumber);
        return storePageNumber;
      }

    public bool  hasOptions()
      {
        return flagHasOptions;
      }

    public int  countOfOptions()
      {
        Debug.Assert(flagHasOptions);
        return storeOptions.Count;
      }

    public bool  elementOfOptions(int element_num)
      {
        Debug.Assert(flagHasOptions);
        return storeOptions[element_num];
      }

    public List< bool >  getOptions()
      {
        Debug.Assert(flagHasOptions);
        return storeOptions;
      }


    public virtual int extraRecipeSearchSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRecipeSearchSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRecipeSearchSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRecipeSearchSpecLookup(string field_name)
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
    public void setCuisine(string new_value)
      {
        flagHasCuisine = true;
        storeCuisine = new_value;
      }
    public void unsetCuisine()
      {
        flagHasCuisine = false;
      }
    public void setCategory(string new_value)
      {
        flagHasCategory = true;
        storeCategory = new_value;
      }
    public void unsetCategory()
      {
        flagHasCategory = false;
      }
    public void initIncludedIngredients()
      {
        flagHasIncludedIngredients = true;
        storeIncludedIngredients.Clear();
      }
    public void appendIncludedIngredients(string to_append)
      {
        if (!flagHasIncludedIngredients)
          {
            flagHasIncludedIngredients = true;
            storeIncludedIngredients.Clear();
          }
        Debug.Assert(flagHasIncludedIngredients);
        storeIncludedIngredients.Add(to_append);
      }
    public void unsetIncludedIngredients()
      {
        flagHasIncludedIngredients = false;
        storeIncludedIngredients.Clear();
      }
    public void initExcludedIngredients()
      {
        flagHasExcludedIngredients = true;
        storeExcludedIngredients.Clear();
      }
    public void appendExcludedIngredients(string to_append)
      {
        if (!flagHasExcludedIngredients)
          {
            flagHasExcludedIngredients = true;
            storeExcludedIngredients.Clear();
          }
        Debug.Assert(flagHasExcludedIngredients);
        storeExcludedIngredients.Add(to_append);
      }
    public void unsetExcludedIngredients()
      {
        flagHasExcludedIngredients = false;
        storeExcludedIngredients.Clear();
      }
    public void setTimeToCook(BigInteger new_value)
      {
        flagHasTimeToCook = true;
        storeTimeToCook = new_value;
      }
    public void unsetTimeToCook()
      {
        flagHasTimeToCook = false;
      }
    public void setPageNumber(BigInteger new_value)
      {
        flagHasPageNumber = true;
        storePageNumber = new_value;
      }
    public void unsetPageNumber()
      {
        flagHasPageNumber = false;
      }
    public void initOptions()
      {
        flagHasOptions = true;
        storeOptions.Clear();
      }
    public void appendOptions(bool to_append)
      {
        if (!flagHasOptions)
          {
            flagHasOptions = true;
            storeOptions.Clear();
          }
        Debug.Assert(flagHasOptions);
        storeOptions.Add(to_append);
      }
    public void unsetOptions()
      {
        flagHasOptions = false;
        storeOptions.Clear();
      }

    public virtual void extraRecipeSearchSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRecipeSearchSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRecipeSearchSpecLookup(key);
        if (old_field == null)
          {
            extraRecipeSearchSpecAppendPair(key, new_component);
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
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasCuisine)
          {
            handler.start_pair("Cuisine");
            handler.string_value(storeCuisine);
          }
        if (flagHasCategory)
          {
            handler.start_pair("Category");
            handler.string_value(storeCategory);
          }
        if (flagHasIncludedIngredients)
          {
            handler.start_pair("IncludedIngredients");
            handler.start_array();
            for (int num1 = 0; num1 < storeIncludedIngredients.Count; ++num1)
              {
                handler.string_value(storeIncludedIngredients[num1]);
              }
            handler.finish_array();
          }
        if (flagHasExcludedIngredients)
          {
            handler.start_pair("ExcludedIngredients");
            handler.start_array();
            for (int num2 = 0; num2 < storeExcludedIngredients.Count; ++num2)
              {
                handler.string_value(storeExcludedIngredients[num2]);
              }
            handler.finish_array();
          }
        if (flagHasTimeToCook)
          {
            handler.start_pair("TimeToCook");
            handler.number_value(storeTimeToCook);
          }
        if (flagHasPageNumber)
          {
            handler.start_pair("PageNumber");
            handler.number_value(storePageNumber);
          }
        if (flagHasOptions)
          {
            handler.start_pair("Options");
            handler.start_array();
            for (int num3 = 0; num3 < storeOptions.Count; ++num3)
              {
                handler.boolean_value(storeOptions[num3]);
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
        return null;
      }

    public static RecipeSearchSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeSearchSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchSpec", ignore_extras);
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
    public static RecipeSearchSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeSearchSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeSearchSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchSpec", ignore_extras);
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
    public static RecipeSearchSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeSearchSpecJSON from_text(string text, bool ignore_extras)
      {
        RecipeSearchSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeSearchSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RecipeSearchSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeSearchSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorCuisine;
        private JSONHoldingStringGenerator fieldGeneratorCategory;
        private JSONHoldingStringArrayGenerator fieldGeneratorIncludedIngredients;
        private JSONHoldingStringArrayGenerator fieldGeneratorExcludedIngredients;
    private class FieldHoldingGeneratorTimeToCook : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorTimeToCook(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorTimeToCook : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorTimeToCook(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorTimeToCook fieldGeneratorTimeToCook;
    private class FieldHoldingGeneratorPageNumber : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorPageNumber(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPageNumber : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPageNumber(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorPageNumber fieldGeneratorPageNumber;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorOptions;
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
            RecipeSearchSpecJSON result = new RecipeSearchSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeSearchSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RecipeSearchSpecJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            if (fieldGeneratorCuisine.have_value)
              {
                result.setCuisine(fieldGeneratorCuisine.value);
                fieldGeneratorCuisine.have_value = false;
              }
            if (fieldGeneratorCategory.have_value)
              {
                result.setCategory(fieldGeneratorCategory.value);
                fieldGeneratorCategory.have_value = false;
              }
            if (fieldGeneratorIncludedIngredients.have_value)
              {
                result.initIncludedIngredients();
                int count = fieldGeneratorIncludedIngredients.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendIncludedIngredients(fieldGeneratorIncludedIngredients.value[num]);
                  }
                fieldGeneratorIncludedIngredients.value.Clear();
                fieldGeneratorIncludedIngredients.have_value = false;
              }
            if (fieldGeneratorExcludedIngredients.have_value)
              {
                result.initExcludedIngredients();
                int count = fieldGeneratorExcludedIngredients.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendExcludedIngredients(fieldGeneratorExcludedIngredients.value[num]);
                  }
                fieldGeneratorExcludedIngredients.value.Clear();
                fieldGeneratorExcludedIngredients.have_value = false;
              }
            if (fieldGeneratorTimeToCook.have_value)
              {
                result.setTimeToCook(fieldGeneratorTimeToCook.value);
                fieldGeneratorTimeToCook.have_value = false;
              }
            if (fieldGeneratorPageNumber.have_value)
              {
                result.setPageNumber(fieldGeneratorPageNumber.value);
                fieldGeneratorPageNumber.have_value = false;
              }
            if (fieldGeneratorOptions.have_value)
              {
                result.initOptions();
                int count = fieldGeneratorOptions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOptions(fieldGeneratorOptions.value[num]);
                  }
                fieldGeneratorOptions.value.Clear();
                fieldGeneratorOptions.have_value = false;
              }
          }
        protected abstract void handle_result(RecipeSearchSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tegory", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorCategory;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "isine", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorCuisine;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xcludedIngredients", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorExcludedIngredients;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "ncludedIngredients", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorIncludedIngredients;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "ptions", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorOptions;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ageNumber", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPageNumber;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "imeToCook", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorTimeToCook;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the RecipeSearchSpec class");
            fieldGeneratorCuisine = new JSONHoldingStringGenerator("field \"Cuisine\" of the RecipeSearchSpec class");
            fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the RecipeSearchSpec class");
            fieldGeneratorIncludedIngredients = new JSONHoldingStringArrayGenerator("field \"IncludedIngredients\" of the RecipeSearchSpec class");
            fieldGeneratorExcludedIngredients = new JSONHoldingStringArrayGenerator("field \"ExcludedIngredients\" of the RecipeSearchSpec class");
            fieldGeneratorTimeToCook = new FieldHoldingGeneratorTimeToCook("field \"TimeToCook\" of the RecipeSearchSpec class");
            fieldGeneratorPageNumber = new FieldHoldingGeneratorPageNumber("field \"PageNumber\" of the RecipeSearchSpec class");
            fieldGeneratorOptions = new JSONHoldingBooleanArrayGenerator("field \"Options\" of the RecipeSearchSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RecipeSearchSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the RecipeSearchSpec class");
            fieldGeneratorCuisine = new JSONHoldingStringGenerator("field \"Cuisine\" of the RecipeSearchSpec class");
            fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the RecipeSearchSpec class");
            fieldGeneratorIncludedIngredients = new JSONHoldingStringArrayGenerator("field \"IncludedIngredients\" of the RecipeSearchSpec class");
            fieldGeneratorExcludedIngredients = new JSONHoldingStringArrayGenerator("field \"ExcludedIngredients\" of the RecipeSearchSpec class");
            fieldGeneratorTimeToCook = new FieldHoldingGeneratorTimeToCook("field \"TimeToCook\" of the RecipeSearchSpec class");
            fieldGeneratorPageNumber = new FieldHoldingGeneratorPageNumber("field \"PageNumber\" of the RecipeSearchSpec class");
            fieldGeneratorOptions = new JSONHoldingBooleanArrayGenerator("field \"Options\" of the RecipeSearchSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RecipeSearchSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorCuisine.reset();
            fieldGeneratorCategory.reset();
            fieldGeneratorIncludedIngredients.reset();
            fieldGeneratorExcludedIngredients.reset();
            fieldGeneratorTimeToCook.reset();
            fieldGeneratorPageNumber.reset();
            fieldGeneratorOptions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RecipeSearchSpecJSON  result)
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
        public RecipeSearchSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeSearchSpecJSON  result)
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
    protected virtual void handle_result(List<RecipeSearchSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeSearchSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeSearchSpecJSON>();
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
    public List<RecipeSearchSpecJSON> value;
  };
  };
