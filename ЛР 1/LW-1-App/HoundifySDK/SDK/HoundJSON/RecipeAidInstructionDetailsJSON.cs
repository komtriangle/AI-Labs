/* file "RecipeAidInstructionDetailsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RecipeAidInstructionDetailsJSON : JSONBase
  {
    private bool flagHasInstructionTextWritten;
    private string storeInstructionTextWritten;
    private bool flagHasInstructionTextSpoken;
    private string storeInstructionTextSpoken;
    private bool flagHasInstructionIngredients;
    private List< IngredientInfoJSON  > storeInstructionIngredients;
    private bool flagHasCookMinutes;
    private BigInteger storeCookMinutes;
    private bool flagHasCookTerms;
    private List< string > storeCookTerms;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONInstructionTextWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InstructionTextWritten of RecipeAidInstructionDetailsJSON is not a string.");
        setInstructionTextWritten(json_string.getData());
      }


    private void  fromJSONInstructionTextSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InstructionTextSpoken of RecipeAidInstructionDetailsJSON is not a string.");
        setInstructionTextSpoken(json_string.getData());
      }


    private void  fromJSONInstructionIngredients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InstructionIngredients of RecipeAidInstructionDetailsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< IngredientInfoJSON  > vector_InstructionIngredients1 = new List< IngredientInfoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            IngredientInfoJSON convert_classy = IngredientInfoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InstructionIngredients1.Add(convert_classy);
          }
        initInstructionIngredients();
        for (int num1 = 0; num1 < vector_InstructionIngredients1.Count; ++num1)
            appendInstructionIngredients(vector_InstructionIngredients1[num1]);
        for (int num1 = 0; num1 < vector_InstructionIngredients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCookMinutes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CookMinutes of RecipeAidInstructionDetailsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CookMinutes of RecipeAidInstructionDetailsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCookMinutes(extracted_integer);
      }


    private void  fromJSONCookTerms(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CookTerms of RecipeAidInstructionDetailsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_CookTerms1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field CookTerms of RecipeAidInstructionDetailsJSON is not a string.");
            vector_CookTerms1.Add(json_string.getData());
          }
        initCookTerms();
        for (int num2 = 0; num2 < vector_CookTerms1.Count; ++num2)
            appendCookTerms(vector_CookTerms1[num2]);
        for (int num1 = 0; num1 < vector_CookTerms1.Count; ++num1)
          {
          }
      }


    public RecipeAidInstructionDetailsJSON()
      {
        flagHasInstructionTextWritten = false;
        flagHasInstructionTextSpoken = false;
        flagHasInstructionIngredients = false;
        flagHasCookMinutes = false;
        flagHasCookTerms = false;
        storeInstructionIngredients = new List< IngredientInfoJSON  >();
        storeCookTerms = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasInstructionTextWritten()
      {
        return flagHasInstructionTextWritten;
      }

    public string  getInstructionTextWritten()
      {
        Debug.Assert(flagHasInstructionTextWritten);
        return storeInstructionTextWritten;
      }

    public bool  hasInstructionTextSpoken()
      {
        return flagHasInstructionTextSpoken;
      }

    public string  getInstructionTextSpoken()
      {
        Debug.Assert(flagHasInstructionTextSpoken);
        return storeInstructionTextSpoken;
      }

    public bool  hasInstructionIngredients()
      {
        return flagHasInstructionIngredients;
      }

    public int  countOfInstructionIngredients()
      {
        Debug.Assert(flagHasInstructionIngredients);
        return storeInstructionIngredients.Count;
      }

    public IngredientInfoJSON   elementOfInstructionIngredients(int element_num)
      {
        Debug.Assert(flagHasInstructionIngredients);
        return storeInstructionIngredients[element_num];
      }

    public List< IngredientInfoJSON  >  getInstructionIngredients()
      {
        Debug.Assert(flagHasInstructionIngredients);
        return storeInstructionIngredients;
      }

    public bool  hasCookMinutes()
      {
        return flagHasCookMinutes;
      }

    public BigInteger  getCookMinutes()
      {
        Debug.Assert(flagHasCookMinutes);
        return storeCookMinutes;
      }

    public bool  hasCookTerms()
      {
        return flagHasCookTerms;
      }

    public int  countOfCookTerms()
      {
        Debug.Assert(flagHasCookTerms);
        return storeCookTerms.Count;
      }

    public string  elementOfCookTerms(int element_num)
      {
        Debug.Assert(flagHasCookTerms);
        return storeCookTerms[element_num];
      }

    public List< string >  getCookTerms()
      {
        Debug.Assert(flagHasCookTerms);
        return storeCookTerms;
      }


    public virtual int extraRecipeAidInstructionDetailsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRecipeAidInstructionDetailsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRecipeAidInstructionDetailsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRecipeAidInstructionDetailsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setInstructionTextWritten(string new_value)
      {
        flagHasInstructionTextWritten = true;
        storeInstructionTextWritten = new_value;
      }
    public void unsetInstructionTextWritten()
      {
        flagHasInstructionTextWritten = false;
      }
    public void setInstructionTextSpoken(string new_value)
      {
        flagHasInstructionTextSpoken = true;
        storeInstructionTextSpoken = new_value;
      }
    public void unsetInstructionTextSpoken()
      {
        flagHasInstructionTextSpoken = false;
      }
    public void initInstructionIngredients()
      {
        if (flagHasInstructionIngredients)
          {
            for (int num1 = 0; num1 < storeInstructionIngredients.Count; ++num1)
              {
              }
          }
        flagHasInstructionIngredients = true;
        storeInstructionIngredients.Clear();
      }
    public void appendInstructionIngredients(IngredientInfoJSON  to_append)
      {
        if (!flagHasInstructionIngredients)
          {
            flagHasInstructionIngredients = true;
            storeInstructionIngredients.Clear();
          }
        Debug.Assert(flagHasInstructionIngredients);
        storeInstructionIngredients.Add(to_append);
      }
    public void unsetInstructionIngredients()
      {
        if (flagHasInstructionIngredients)
          {
            for (int num2 = 0; num2 < storeInstructionIngredients.Count; ++num2)
              {
              }
          }
        flagHasInstructionIngredients = false;
        storeInstructionIngredients.Clear();
      }
    public void setCookMinutes(BigInteger new_value)
      {
        flagHasCookMinutes = true;
        if (new_value < 0)
            throw new Exception("The value for field CookMinutes of RecipeAidInstructionDetailsJSON is less than the lower bound (0) for that field.");
        storeCookMinutes = new_value;
      }
    public void unsetCookMinutes()
      {
        flagHasCookMinutes = false;
      }
    public void initCookTerms()
      {
        flagHasCookTerms = true;
        storeCookTerms.Clear();
      }
    public void appendCookTerms(string to_append)
      {
        if (!flagHasCookTerms)
          {
            flagHasCookTerms = true;
            storeCookTerms.Clear();
          }
        Debug.Assert(flagHasCookTerms);
        storeCookTerms.Add(to_append);
      }
    public void unsetCookTerms()
      {
        flagHasCookTerms = false;
        storeCookTerms.Clear();
      }

    public virtual void extraRecipeAidInstructionDetailsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRecipeAidInstructionDetailsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRecipeAidInstructionDetailsLookup(key);
        if (old_field == null)
          {
            extraRecipeAidInstructionDetailsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasInstructionTextWritten);
        if (flagHasInstructionTextWritten)
          {
            handler.start_pair("InstructionTextWritten");
            handler.string_value(storeInstructionTextWritten);
          }
        Debug.Assert(partial_allowed || flagHasInstructionTextSpoken);
        if (flagHasInstructionTextSpoken)
          {
            handler.start_pair("InstructionTextSpoken");
            handler.string_value(storeInstructionTextSpoken);
          }
        if (flagHasInstructionIngredients)
          {
            handler.start_pair("InstructionIngredients");
            handler.start_array();
            for (int num1 = 0; num1 < storeInstructionIngredients.Count; ++num1)
              {
                if (partial_allowed)
                    storeInstructionIngredients[num1].write_partial_as_json(handler);
                else
                    storeInstructionIngredients[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasCookMinutes)
          {
            handler.start_pair("CookMinutes");
            handler.number_value(storeCookMinutes);
          }
        if (flagHasCookTerms)
          {
            handler.start_pair("CookTerms");
            handler.start_array();
            for (int num2 = 0; num2 < storeCookTerms.Count; ++num2)
              {
                handler.string_value(storeCookTerms[num2]);
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
        if (!(hasInstructionTextWritten()))
          {
            return "When parsing the object for %what%, the \"InstructionTextWritten\" field was missing.";
          }
        if (!(hasInstructionTextSpoken()))
          {
            return "When parsing the object for %what%, the \"InstructionTextSpoken\" field was missing.";
          }
        return null;
      }

    public static RecipeAidInstructionDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidInstructionDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInstructionDetails", ignore_extras);
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
    public static RecipeAidInstructionDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeAidInstructionDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidInstructionDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInstructionDetails", ignore_extras);
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
    public static RecipeAidInstructionDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeAidInstructionDetailsJSON from_text(string text, bool ignore_extras)
      {
        RecipeAidInstructionDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInstructionDetails", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeAidInstructionDetailsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RecipeAidInstructionDetailsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeAidInstructionDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInstructionDetails", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorInstructionTextWritten;
        private JSONHoldingStringGenerator fieldGeneratorInstructionTextSpoken;
        private IngredientInfoJSON.HoldingArrayGenerator fieldGeneratorInstructionIngredients;
    private class FieldHoldingGeneratorCookMinutes : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorCookMinutes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorCookMinutes : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorCookMinutes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorCookMinutes fieldGeneratorCookMinutes;
        private JSONHoldingStringArrayGenerator fieldGeneratorCookTerms;
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
            RecipeAidInstructionDetailsJSON result = new RecipeAidInstructionDetailsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeAidInstructionDetailsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RecipeAidInstructionDetailsJSON result)
          {
            if (fieldGeneratorInstructionTextWritten.have_value)
              {
                result.setInstructionTextWritten(fieldGeneratorInstructionTextWritten.value);
                fieldGeneratorInstructionTextWritten.have_value = false;
              }
            else if ((!(result.hasInstructionTextWritten())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InstructionTextWritten\" field was missing.");
              }
            if (fieldGeneratorInstructionTextSpoken.have_value)
              {
                result.setInstructionTextSpoken(fieldGeneratorInstructionTextSpoken.value);
                fieldGeneratorInstructionTextSpoken.have_value = false;
              }
            else if ((!(result.hasInstructionTextSpoken())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InstructionTextSpoken\" field was missing.");
              }
            if (fieldGeneratorInstructionIngredients.have_value)
              {
                result.initInstructionIngredients();
                int count = fieldGeneratorInstructionIngredients.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInstructionIngredients(fieldGeneratorInstructionIngredients.value[num]);
                  }
                fieldGeneratorInstructionIngredients.value.Clear();
                fieldGeneratorInstructionIngredients.have_value = false;
              }
            if (fieldGeneratorCookMinutes.have_value)
              {
                result.setCookMinutes(fieldGeneratorCookMinutes.value);
                fieldGeneratorCookMinutes.have_value = false;
              }
            if (fieldGeneratorCookTerms.have_value)
              {
                result.initCookTerms();
                int count = fieldGeneratorCookTerms.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCookTerms(fieldGeneratorCookTerms.value[num]);
                  }
                fieldGeneratorCookTerms.value.Clear();
                fieldGeneratorCookTerms.have_value = false;
              }
          }
        protected abstract void handle_result(RecipeAidInstructionDetailsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "ook", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'M':
                                if ((String.Compare(field_name, 5, "inutes", 0, 6, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorCookMinutes;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 5, "erms", 0, 4, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorCookTerms;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "nstruction", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 12, "ngredients", 0, 10, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorInstructionIngredients;
                                break;
                            case 'T':
                                if (String.Compare(field_name, 12, "ext", 0, 3, false) == 0)
                                  {
                                    switch (field_name[15])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 16, "poken", 0, 5, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratorInstructionTextSpoken;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 16, "ritten", 0, 6, false) == 0) && (field_name.Length == 22))
                                                return fieldGeneratorInstructionTextWritten;
                                            break;
                                        default:
                                            break;
                                      }
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorInstructionTextWritten = new JSONHoldingStringGenerator("field \"InstructionTextWritten\" of the RecipeAidInstructionDetails class");
            fieldGeneratorInstructionTextSpoken = new JSONHoldingStringGenerator("field \"InstructionTextSpoken\" of the RecipeAidInstructionDetails class");
            fieldGeneratorInstructionIngredients = new IngredientInfoJSON.HoldingArrayGenerator("field \"InstructionIngredients\" of the RecipeAidInstructionDetails class", ignore_extras);
            fieldGeneratorCookMinutes = new FieldHoldingGeneratorCookMinutes("field \"CookMinutes\" of the RecipeAidInstructionDetails class");
            fieldGeneratorCookTerms = new JSONHoldingStringArrayGenerator("field \"CookTerms\" of the RecipeAidInstructionDetails class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RecipeAidInstructionDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorInstructionTextWritten = new JSONHoldingStringGenerator("field \"InstructionTextWritten\" of the RecipeAidInstructionDetails class");
            fieldGeneratorInstructionTextSpoken = new JSONHoldingStringGenerator("field \"InstructionTextSpoken\" of the RecipeAidInstructionDetails class");
            fieldGeneratorInstructionIngredients = new IngredientInfoJSON.HoldingArrayGenerator("field \"InstructionIngredients\" of the RecipeAidInstructionDetails class", false);
            fieldGeneratorCookMinutes = new FieldHoldingGeneratorCookMinutes("field \"CookMinutes\" of the RecipeAidInstructionDetails class");
            fieldGeneratorCookTerms = new JSONHoldingStringArrayGenerator("field \"CookTerms\" of the RecipeAidInstructionDetails class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RecipeAidInstructionDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorInstructionTextWritten.reset();
            fieldGeneratorInstructionTextSpoken.reset();
            fieldGeneratorInstructionIngredients.reset();
            fieldGeneratorCookMinutes.reset();
            fieldGeneratorCookTerms.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorInstructionIngredients.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorInstructionIngredients.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RecipeAidInstructionDetailsJSON  result)
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
        public RecipeAidInstructionDetailsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeAidInstructionDetailsJSON  result)
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
    protected virtual void handle_result(List<RecipeAidInstructionDetailsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeAidInstructionDetailsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeAidInstructionDetailsJSON>();
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
    public List<RecipeAidInstructionDetailsJSON> value;
  };
  };
