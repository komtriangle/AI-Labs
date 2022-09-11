/* file "RecipeAidIngredientSubstitutionInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RecipeAidIngredientSubstitutionInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasOfficialName;
    private string storeOfficialName;
    private bool flagHasAmount;
    private string storeAmount;
    private bool flagHasSpokenName;
    private string storeSpokenName;
    private bool flagHasSubstitutions;
    private List< string > storeSubstitutions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraOfficialNameToJSON()
      {
        JSONStringValue generated_string_OfficialName = new JSONStringValue(storeOfficialName);
        return generated_string_OfficialName;
      }

    private JSONValue  extraAmountToJSON()
      {
        JSONStringValue generated_string_Amount = new JSONStringValue(storeAmount);
        return generated_string_Amount;
      }

    private JSONValue  extraSpokenNameToJSON()
      {
        JSONStringValue generated_string_SpokenName = new JSONStringValue(storeSpokenName);
        return generated_string_SpokenName;
      }

    private JSONValue  extraSubstitutionsToJSON()
      {
        JSONArrayValue generated_array_1_Substitutions = new JSONArrayValue();
        for (int num1 = 0; num1 < storeSubstitutions.Count; ++num1)
          {
            JSONStringValue generated_string_Substitutions = new JSONStringValue(storeSubstitutions[num1]);
            generated_array_1_Substitutions.appendComponent(generated_string_Substitutions);
          }
        return generated_array_1_Substitutions;
      }


    private void  fromJSONOfficialName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OfficialName of RecipeAidIngredientSubstitutionInformationNuggetJSON is not a string.");
        setOfficialName(json_string.getData());
      }


    private void  fromJSONAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Amount of RecipeAidIngredientSubstitutionInformationNuggetJSON is not a string.");
        setAmount(json_string.getData());
      }


    private void  fromJSONSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenName of RecipeAidIngredientSubstitutionInformationNuggetJSON is not a string.");
        setSpokenName(json_string.getData());
      }


    private void  fromJSONSubstitutions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Substitutions of RecipeAidIngredientSubstitutionInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Substitutions1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Substitutions of RecipeAidIngredientSubstitutionInformationNuggetJSON is not a string.");
            vector_Substitutions1.Add(json_string.getData());
          }
        initSubstitutions();
        for (int num1 = 0; num1 < vector_Substitutions1.Count; ++num1)
            appendSubstitutions(vector_Substitutions1[num1]);
        for (int num1 = 0; num1 < vector_Substitutions1.Count; ++num1)
          {
          }
      }


    public RecipeAidIngredientSubstitutionInformationNuggetJSON()
      {
        flagHasOfficialName = false;
        flagHasAmount = false;
        flagHasSpokenName = false;
        flagHasSubstitutions = false;
        storeSubstitutions = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "RecipeAidIngredientSubstitution";
      }

    public bool  hasOfficialName()
      {
        return flagHasOfficialName;
      }

    public string  getOfficialName()
      {
        Debug.Assert(flagHasOfficialName);
        return storeOfficialName;
      }

    public bool  hasAmount()
      {
        return flagHasAmount;
      }

    public string  getAmount()
      {
        Debug.Assert(flagHasAmount);
        return storeAmount;
      }

    public bool  hasSpokenName()
      {
        return flagHasSpokenName;
      }

    public string  getSpokenName()
      {
        Debug.Assert(flagHasSpokenName);
        return storeSpokenName;
      }

    public bool  hasSubstitutions()
      {
        return flagHasSubstitutions;
      }

    public int  countOfSubstitutions()
      {
        Debug.Assert(flagHasSubstitutions);
        return storeSubstitutions.Count;
      }

    public string  elementOfSubstitutions(int element_num)
      {
        Debug.Assert(flagHasSubstitutions);
        return storeSubstitutions[element_num];
      }

    public List< string >  getSubstitutions()
      {
        Debug.Assert(flagHasSubstitutions);
        return storeSubstitutions;
      }


    public virtual int extraRecipeAidIngredientSubstitutionInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRecipeAidIngredientSubstitutionInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRecipeAidIngredientSubstitutionInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRecipeAidIngredientSubstitutionInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasOfficialName)
            ++result;
        if (flagHasAmount)
            ++result;
        if (flagHasSpokenName)
            ++result;
        if (flagHasSubstitutions)
            ++result;
        result += extraRecipeAidIngredientSubstitutionInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasOfficialName)
          {
            if (remainder == 0)
                return "OfficialName";
            --remainder;
          }
        if (flagHasAmount)
          {
            if (remainder == 0)
                return "Amount";
            --remainder;
          }
        if (flagHasSpokenName)
          {
            if (remainder == 0)
                return "SpokenName";
            --remainder;
          }
        if (flagHasSubstitutions)
          {
            if (remainder == 0)
                return "Substitutions";
            --remainder;
          }
        return extraRecipeAidIngredientSubstitutionInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasOfficialName)
          {
            if (remainder == 0)
                return extraOfficialNameToJSON();
            --remainder;
          }
        if (flagHasAmount)
          {
            if (remainder == 0)
                return extraAmountToJSON();
            --remainder;
          }
        if (flagHasSpokenName)
          {
            if (remainder == 0)
                return extraSpokenNameToJSON();
            --remainder;
          }
        if (flagHasSubstitutions)
          {
            if (remainder == 0)
                return extraSubstitutionsToJSON();
            --remainder;
          }
        return extraRecipeAidIngredientSubstitutionInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "mount", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasAmount ? extraAmountToJSON() : null);
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "fficialName", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasOfficialName ? extraOfficialNameToJSON() : null);
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 'p':
                        if ((String.Compare(field_name, 2, "okenName", 0, 8, false) == 0) && (field_name.Length == 10))
                            return (flagHasSpokenName ? extraSpokenNameToJSON() : null);
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 2, "bstitutions", 0, 11, false) == 0) && (field_name.Length == 13))
                            return (flagHasSubstitutions ? extraSubstitutionsToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return extraRecipeAidIngredientSubstitutionInformationNuggetLookup(field_name);
      }

    public void setOfficialName(string new_value)
      {
        flagHasOfficialName = true;
        storeOfficialName = new_value;
      }
    public void unsetOfficialName()
      {
        flagHasOfficialName = false;
      }
    public void setAmount(string new_value)
      {
        flagHasAmount = true;
        storeAmount = new_value;
      }
    public void unsetAmount()
      {
        flagHasAmount = false;
      }
    public void setSpokenName(string new_value)
      {
        flagHasSpokenName = true;
        storeSpokenName = new_value;
      }
    public void unsetSpokenName()
      {
        flagHasSpokenName = false;
      }
    public void initSubstitutions()
      {
        flagHasSubstitutions = true;
        storeSubstitutions.Clear();
      }
    public void appendSubstitutions(string to_append)
      {
        if (!flagHasSubstitutions)
          {
            flagHasSubstitutions = true;
            storeSubstitutions.Clear();
          }
        Debug.Assert(flagHasSubstitutions);
        storeSubstitutions.Add(to_append);
      }
    public void unsetSubstitutions()
      {
        flagHasSubstitutions = false;
        storeSubstitutions.Clear();
      }

    public virtual void extraRecipeAidIngredientSubstitutionInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRecipeAidIngredientSubstitutionInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRecipeAidIngredientSubstitutionInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraRecipeAidIngredientSubstitutionInformationNuggetAppendPair(key, new_component);
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
            case 'A':
                if ((String.Compare(key, 1, "mount", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONAmount(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "fficialName", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONOfficialName(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'p':
                        if ((String.Compare(key, 2, "okenName", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONSpokenName(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "bstitutions", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONSubstitutions(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraRecipeAidIngredientSubstitutionInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "mount", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONAmount(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "fficialName", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONOfficialName(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'p':
                        if ((String.Compare(key, 2, "okenName", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONSpokenName(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "bstitutions", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONSubstitutions(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraRecipeAidIngredientSubstitutionInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasOfficialName);
        if (flagHasOfficialName)
          {
            handler.start_pair("OfficialName");
            handler.string_value(storeOfficialName);
          }
        if (flagHasAmount)
          {
            handler.start_pair("Amount");
            handler.string_value(storeAmount);
          }
        Debug.Assert(partial_allowed || flagHasSpokenName);
        if (flagHasSpokenName)
          {
            handler.start_pair("SpokenName");
            handler.string_value(storeSpokenName);
          }
        Debug.Assert(partial_allowed || flagHasSubstitutions);
        if (flagHasSubstitutions)
          {
            handler.start_pair("Substitutions");
            handler.start_array();
            for (int num1 = 0; num1 < storeSubstitutions.Count; ++num1)
              {
                handler.string_value(storeSubstitutions[num1]);
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
        if (!(hasOfficialName()))
          {
            return "When parsing the object for %what%, the \"OfficialName\" field was missing.";
          }
        if (!(hasSpokenName()))
          {
            return "When parsing the object for %what%, the \"SpokenName\" field was missing.";
          }
        if (!(hasSubstitutions()))
          {
            return "When parsing the object for %what%, the \"Substitutions\" field was missing.";
          }
        return null;
      }

    public static new RecipeAidIngredientSubstitutionInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidIngredientSubstitutionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidIngredientSubstitutionInformationNugget", ignore_extras);
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
    public static new RecipeAidIngredientSubstitutionInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RecipeAidIngredientSubstitutionInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidIngredientSubstitutionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidIngredientSubstitutionInformationNugget", ignore_extras);
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
    public static new RecipeAidIngredientSubstitutionInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RecipeAidIngredientSubstitutionInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        RecipeAidIngredientSubstitutionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidIngredientSubstitutionInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeAidIngredientSubstitutionInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RecipeAidIngredientSubstitutionInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeAidIngredientSubstitutionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidIngredientSubstitutionInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorOfficialName;
        private JSONHoldingStringGenerator fieldGeneratorAmount;
        private JSONHoldingStringGenerator fieldGeneratorSpokenName;
        private JSONHoldingStringArrayGenerator fieldGeneratorSubstitutions;
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
            if (!(getInformationNuggetJSONKey().Equals("RecipeAidIngredientSubstitution")))
                throw new Exception("The key field has a value other than `RecipeAidIngredientSubstitution'.");
            RecipeAidIngredientSubstitutionInformationNuggetJSON result = new RecipeAidIngredientSubstitutionInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeAidIngredientSubstitutionInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((RecipeAidIngredientSubstitutionInformationNuggetJSON )new_result);
          }
        protected void finish(RecipeAidIngredientSubstitutionInformationNuggetJSON result)
          {
            if (fieldGeneratorOfficialName.have_value)
              {
                result.setOfficialName(fieldGeneratorOfficialName.value);
                fieldGeneratorOfficialName.have_value = false;
              }
            else if ((!(result.hasOfficialName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OfficialName\" field was missing.");
              }
            if (fieldGeneratorAmount.have_value)
              {
                result.setAmount(fieldGeneratorAmount.value);
                fieldGeneratorAmount.have_value = false;
              }
            if (fieldGeneratorSpokenName.have_value)
              {
                result.setSpokenName(fieldGeneratorSpokenName.value);
                fieldGeneratorSpokenName.have_value = false;
              }
            else if ((!(result.hasSpokenName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenName\" field was missing.");
              }
            if (fieldGeneratorSubstitutions.have_value)
              {
                result.initSubstitutions();
                int count = fieldGeneratorSubstitutions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSubstitutions(fieldGeneratorSubstitutions.value[num]);
                  }
                fieldGeneratorSubstitutions.value.Clear();
                fieldGeneratorSubstitutions.have_value = false;
              }
            else if ((!(result.hasSubstitutions())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Substitutions\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RecipeAidIngredientSubstitutionInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mount", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorAmount;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "fficialName", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorOfficialName;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenName", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSpokenName;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "bstitutions", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorSubstitutions;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorOfficialName = new JSONHoldingStringGenerator("field \"OfficialName\" of the RecipeAidIngredientSubstitutionInformationNugget class");
            fieldGeneratorAmount = new JSONHoldingStringGenerator("field \"Amount\" of the RecipeAidIngredientSubstitutionInformationNugget class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the RecipeAidIngredientSubstitutionInformationNugget class");
            fieldGeneratorSubstitutions = new JSONHoldingStringArrayGenerator("field \"Substitutions\" of the RecipeAidIngredientSubstitutionInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RecipeAidIngredientSubstitutionInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorOfficialName = new JSONHoldingStringGenerator("field \"OfficialName\" of the RecipeAidIngredientSubstitutionInformationNugget class");
            fieldGeneratorAmount = new JSONHoldingStringGenerator("field \"Amount\" of the RecipeAidIngredientSubstitutionInformationNugget class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the RecipeAidIngredientSubstitutionInformationNugget class");
            fieldGeneratorSubstitutions = new JSONHoldingStringArrayGenerator("field \"Substitutions\" of the RecipeAidIngredientSubstitutionInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RecipeAidIngredientSubstitutionInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorOfficialName.reset();
            fieldGeneratorAmount.reset();
            fieldGeneratorSpokenName.reset();
            fieldGeneratorSubstitutions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RecipeAidIngredientSubstitutionInformationNuggetJSON  result)
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
        public RecipeAidIngredientSubstitutionInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeAidIngredientSubstitutionInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<RecipeAidIngredientSubstitutionInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeAidIngredientSubstitutionInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeAidIngredientSubstitutionInformationNuggetJSON>();
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
    public List<RecipeAidIngredientSubstitutionInformationNuggetJSON> value;
  };
  };
