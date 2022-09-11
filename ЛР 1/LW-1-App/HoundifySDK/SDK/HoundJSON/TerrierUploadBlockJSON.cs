/* file "TerrierUploadBlockJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierUploadBlockJSON : JSONBase
  {
    private bool flagHasName;
    private TerrierUploadBlockNameJSON  storeName;
    private bool flagHasInputParameters;
    private List< TerrierUploadParameterJSON  > storeInputParameters;
    private bool flagHasOutputParameters;
    private List< TerrierUploadParameterJSON  > storeOutputParameters;
    private bool flagHasClauses;
    private List< TerrierUploadClauseJSON  > storeClauses;
    private bool flagHasCodeLanguage;
    private UploadedCodeFunctionLanguageJSON  storeCodeLanguage;
    private bool flagHasExtendedBlock;
    private string storeExtendedBlock;
    private bool flagHasExtensionWeight;
    private double storeExtensionWeight;
    private string textStoreExtensionWeight;
    private bool flagHasDomain;
    private string storeDomain;
    private bool flagHasMode;
    private string storeMode;
    private bool flagHasModeIndependent;
    private bool storeModeIndependent;
    private bool flagHasBlockSource;
    private UploadedCodeSourceJSON  storeBlockSource;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TerrierUploadBlockNameJSON convert_classy = TerrierUploadBlockNameJSON.from_json(json_value, ignore_extras, true);
        setName(convert_classy);
      }


    private void  fromJSONInputParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputParameters of TerrierUploadBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierUploadParameterJSON  > vector_InputParameters1 = new List< TerrierUploadParameterJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierUploadParameterJSON convert_classy = TerrierUploadParameterJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InputParameters1.Add(convert_classy);
          }
        initInputParameters();
        for (int num1 = 0; num1 < vector_InputParameters1.Count; ++num1)
            appendInputParameters(vector_InputParameters1[num1]);
        for (int num1 = 0; num1 < vector_InputParameters1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOutputParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OutputParameters of TerrierUploadBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierUploadParameterJSON  > vector_OutputParameters1 = new List< TerrierUploadParameterJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierUploadParameterJSON convert_classy = TerrierUploadParameterJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_OutputParameters1.Add(convert_classy);
          }
        initOutputParameters();
        for (int num2 = 0; num2 < vector_OutputParameters1.Count; ++num2)
            appendOutputParameters(vector_OutputParameters1[num2]);
        for (int num1 = 0; num1 < vector_OutputParameters1.Count; ++num1)
          {
          }
      }


    private void  fromJSONClauses(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Clauses of TerrierUploadBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierUploadClauseJSON  > vector_Clauses1 = new List< TerrierUploadClauseJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierUploadClauseJSON convert_classy = TerrierUploadClauseJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Clauses1.Add(convert_classy);
          }
        initClauses();
        for (int num3 = 0; num3 < vector_Clauses1.Count; ++num3)
            appendClauses(vector_Clauses1[num3]);
        for (int num1 = 0; num1 < vector_Clauses1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCodeLanguage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeFunctionLanguageJSON convert_classy = UploadedCodeFunctionLanguageJSON.from_json(json_value, ignore_extras, true);
        setCodeLanguage(convert_classy);
      }


    private void  fromJSONExtendedBlock(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExtendedBlock of TerrierUploadBlockJSON is not a string.");
        setExtendedBlock(json_string.getData());
      }


    private void  fromJSONExtensionWeight(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field ExtensionWeight of TerrierUploadBlockJSON is not a number.");
              }
          }
        setExtensionWeightText(the_rational_text);
      }


    private void  fromJSONDomain(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Domain of TerrierUploadBlockJSON is not a string.");
        setDomain(json_string.getData());
      }


    private void  fromJSONMode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Mode of TerrierUploadBlockJSON is not a string.");
        setMode(json_string.getData());
      }


    private void  fromJSONModeIndependent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ModeIndependent of TerrierUploadBlockJSON is not true for false.");
              }
          }
        setModeIndependent(the_bool);
      }


    private void  fromJSONBlockSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeSourceJSON convert_classy = UploadedCodeSourceJSON.from_json(json_value, ignore_extras, true);
        setBlockSource(convert_classy);
      }


    public TerrierUploadBlockJSON()
      {
        flagHasName = false;
        flagHasInputParameters = false;
        flagHasOutputParameters = false;
        flagHasClauses = false;
        flagHasCodeLanguage = false;
        flagHasExtendedBlock = false;
        flagHasExtensionWeight = false;
        flagHasDomain = false;
        flagHasMode = false;
        flagHasModeIndependent = false;
        flagHasBlockSource = false;
        storeInputParameters = new List< TerrierUploadParameterJSON  >();
        storeOutputParameters = new List< TerrierUploadParameterJSON  >();
        storeClauses = new List< TerrierUploadClauseJSON  >();
        storeModeIndependent = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public TerrierUploadBlockNameJSON   getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public string  getNameValue()
      {
        return getName().getValue();
      }

    public bool  hasInputParameters()
      {
        return flagHasInputParameters;
      }

    public int  countOfInputParameters()
      {
        Debug.Assert(flagHasInputParameters);
        return storeInputParameters.Count;
      }

    public TerrierUploadParameterJSON   elementOfInputParameters(int element_num)
      {
        Debug.Assert(flagHasInputParameters);
        return storeInputParameters[element_num];
      }

    public List< TerrierUploadParameterJSON  >  getInputParameters()
      {
        Debug.Assert(flagHasInputParameters);
        return storeInputParameters;
      }

    public bool  hasOutputParameters()
      {
        return flagHasOutputParameters;
      }

    public int  countOfOutputParameters()
      {
        Debug.Assert(flagHasOutputParameters);
        return storeOutputParameters.Count;
      }

    public TerrierUploadParameterJSON   elementOfOutputParameters(int element_num)
      {
        Debug.Assert(flagHasOutputParameters);
        return storeOutputParameters[element_num];
      }

    public List< TerrierUploadParameterJSON  >  getOutputParameters()
      {
        Debug.Assert(flagHasOutputParameters);
        return storeOutputParameters;
      }

    public bool  hasClauses()
      {
        return flagHasClauses;
      }

    public int  countOfClauses()
      {
        Debug.Assert(flagHasClauses);
        return storeClauses.Count;
      }

    public TerrierUploadClauseJSON   elementOfClauses(int element_num)
      {
        Debug.Assert(flagHasClauses);
        return storeClauses[element_num];
      }

    public List< TerrierUploadClauseJSON  >  getClauses()
      {
        Debug.Assert(flagHasClauses);
        return storeClauses;
      }

    public bool  hasCodeLanguage()
      {
        return flagHasCodeLanguage;
      }

    public UploadedCodeFunctionLanguageJSON   getCodeLanguage()
      {
        Debug.Assert(flagHasCodeLanguage);
        return storeCodeLanguage;
      }

    public UploadedCodeFunctionLanguageJSON.TypeValue  getCodeLanguageValue()
      {
        return getCodeLanguage().getValue();
      }

    public string  getCodeLanguageAsString()
      {
        return getCodeLanguage().getValueAsString();
      }

    public bool  hasExtendedBlock()
      {
        return flagHasExtendedBlock;
      }

    public string  getExtendedBlock()
      {
        Debug.Assert(flagHasExtendedBlock);
        return storeExtendedBlock;
      }

    public bool  hasExtensionWeight()
      {
        return flagHasExtensionWeight;
      }

    public double  getExtensionWeight()
      {
        Debug.Assert(flagHasExtensionWeight);
        if (textStoreExtensionWeight != "")
          {
            return Double.Parse(textStoreExtensionWeight);
          }
        return storeExtensionWeight;
      }

    public string  getExtensionWeightAsText()
      {
        Debug.Assert(flagHasExtensionWeight);
        if (textStoreExtensionWeight == "")
          {
            return Convert.ToString(storeExtensionWeight);
          }
        else
          {
            return (textStoreExtensionWeight);
          }
      }

    public bool  hasDomain()
      {
        return flagHasDomain;
      }

    public string  getDomain()
      {
        Debug.Assert(flagHasDomain);
        return storeDomain;
      }

    public bool  hasMode()
      {
        return flagHasMode;
      }

    public string  getMode()
      {
        Debug.Assert(flagHasMode);
        return storeMode;
      }

    public bool  hasModeIndependent()
      {
        return flagHasModeIndependent;
      }

    public bool  getModeIndependent()
      {
        return storeModeIndependent;
      }

    public bool  hasBlockSource()
      {
        return flagHasBlockSource;
      }

    public UploadedCodeSourceJSON   getBlockSource()
      {
        Debug.Assert(flagHasBlockSource);
        return storeBlockSource;
      }


    public virtual int extraTerrierUploadBlockComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadBlockComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadBlockComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadBlockLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(TerrierUploadBlockNameJSON  new_value)
      {
        if (flagHasName)
          {
          }
        flagHasName = true;
        storeName = new_value;
      }
    public void setName(string new_value)
      {
        setName(new TerrierUploadBlockNameJSON(new_value));
      }
    public void unsetName()
      {
        if (flagHasName)
          {
          }
        flagHasName = false;
      }
    public void initInputParameters()
      {
        if (flagHasInputParameters)
          {
            for (int num1 = 0; num1 < storeInputParameters.Count; ++num1)
              {
              }
          }
        flagHasInputParameters = true;
        storeInputParameters.Clear();
      }
    public void appendInputParameters(TerrierUploadParameterJSON  to_append)
      {
        if (!flagHasInputParameters)
          {
            flagHasInputParameters = true;
            storeInputParameters.Clear();
          }
        Debug.Assert(flagHasInputParameters);
        storeInputParameters.Add(to_append);
      }
    public void unsetInputParameters()
      {
        if (flagHasInputParameters)
          {
            for (int num2 = 0; num2 < storeInputParameters.Count; ++num2)
              {
              }
          }
        flagHasInputParameters = false;
        storeInputParameters.Clear();
      }
    public void initOutputParameters()
      {
        if (flagHasOutputParameters)
          {
            for (int num3 = 0; num3 < storeOutputParameters.Count; ++num3)
              {
              }
          }
        flagHasOutputParameters = true;
        storeOutputParameters.Clear();
      }
    public void appendOutputParameters(TerrierUploadParameterJSON  to_append)
      {
        if (!flagHasOutputParameters)
          {
            flagHasOutputParameters = true;
            storeOutputParameters.Clear();
          }
        Debug.Assert(flagHasOutputParameters);
        storeOutputParameters.Add(to_append);
      }
    public void unsetOutputParameters()
      {
        if (flagHasOutputParameters)
          {
            for (int num4 = 0; num4 < storeOutputParameters.Count; ++num4)
              {
              }
          }
        flagHasOutputParameters = false;
        storeOutputParameters.Clear();
      }
    public void initClauses()
      {
        if (flagHasClauses)
          {
            for (int num5 = 0; num5 < storeClauses.Count; ++num5)
              {
              }
          }
        flagHasClauses = true;
        storeClauses.Clear();
      }
    public void appendClauses(TerrierUploadClauseJSON  to_append)
      {
        if (!flagHasClauses)
          {
            flagHasClauses = true;
            storeClauses.Clear();
          }
        Debug.Assert(flagHasClauses);
        storeClauses.Add(to_append);
      }
    public void unsetClauses()
      {
        if (flagHasClauses)
          {
            for (int num6 = 0; num6 < storeClauses.Count; ++num6)
              {
              }
          }
        flagHasClauses = false;
        storeClauses.Clear();
      }
    public void setCodeLanguage(UploadedCodeFunctionLanguageJSON  new_value)
      {
        if (flagHasCodeLanguage)
          {
          }
        flagHasCodeLanguage = true;
        storeCodeLanguage = new_value;
      }
    public void setCodeLanguage(UploadedCodeFunctionLanguageJSON.TypeValue new_value)
      {
        setCodeLanguage(new UploadedCodeFunctionLanguageJSON(new_value));
      }
    public void setCodeLanguage(string chars)
      {
        UploadedCodeFunctionLanguageJSON.TypeValueKnownValues known = UploadedCodeFunctionLanguageJSON.stringToValue(chars);
        UploadedCodeFunctionLanguageJSON.TypeValue new_value = new UploadedCodeFunctionLanguageJSON.TypeValue();
        if (known == UploadedCodeFunctionLanguageJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCodeLanguage(new_value);
      }
    public void unsetCodeLanguage()
      {
        if (flagHasCodeLanguage)
          {
          }
        flagHasCodeLanguage = false;
      }
    public void setExtendedBlock(string new_value)
      {
        flagHasExtendedBlock = true;
        storeExtendedBlock = new_value;
      }
    public void unsetExtendedBlock()
      {
        flagHasExtendedBlock = false;
      }
    public void setExtensionWeight(double new_value)
      {
        flagHasExtensionWeight = true;
        if (new_value < 0)
            throw new Exception("The value for field ExtensionWeight of TerrierUploadBlockJSON is less than the lower bound (0) for that field.");
        storeExtensionWeight = new_value;
        textStoreExtensionWeight = "";
      }
    public void setExtensionWeightText(string new_value)
      {
        flagHasExtensionWeight = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field ExtensionWeight of TerrierUploadBlockJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field ExtensionWeight of TerrierUploadBlockJSON is less than the lower bound (0) for that field.");
        textStoreExtensionWeight = new_value;
      }
    public void unsetExtensionWeight()
      {
        flagHasExtensionWeight = false;
      }
    public void setDomain(string new_value)
      {
        flagHasDomain = true;
        storeDomain = new_value;
      }
    public void unsetDomain()
      {
        flagHasDomain = false;
      }
    public void setMode(string new_value)
      {
        flagHasMode = true;
        storeMode = new_value;
      }
    public void unsetMode()
      {
        flagHasMode = false;
      }
    public void setModeIndependent(bool new_value)
      {
        flagHasModeIndependent = true;
        storeModeIndependent = new_value;
      }
    public void unsetModeIndependent()
      {
        flagHasModeIndependent = false;
      }
    public void setBlockSource(UploadedCodeSourceJSON  new_value)
      {
        if (flagHasBlockSource)
          {
          }
        flagHasBlockSource = true;
        storeBlockSource = new_value;
      }
    public void unsetBlockSource()
      {
        if (flagHasBlockSource)
          {
          }
        flagHasBlockSource = false;
      }

    public virtual void extraTerrierUploadBlockAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadBlockSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadBlockLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadBlockAppendPair(key, new_component);
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
            if (partial_allowed)
                storeName.write_partial_as_json(handler);
            else
                storeName.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasInputParameters);
        if (flagHasInputParameters)
          {
            handler.start_pair("InputParameters");
            handler.start_array();
            for (int num1 = 0; num1 < storeInputParameters.Count; ++num1)
              {
                if (partial_allowed)
                    storeInputParameters[num1].write_partial_as_json(handler);
                else
                    storeInputParameters[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasOutputParameters);
        if (flagHasOutputParameters)
          {
            handler.start_pair("OutputParameters");
            handler.start_array();
            for (int num2 = 0; num2 < storeOutputParameters.Count; ++num2)
              {
                if (partial_allowed)
                    storeOutputParameters[num2].write_partial_as_json(handler);
                else
                    storeOutputParameters[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasClauses);
        if (flagHasClauses)
          {
            handler.start_pair("Clauses");
            handler.start_array();
            for (int num3 = 0; num3 < storeClauses.Count; ++num3)
              {
                if (partial_allowed)
                    storeClauses[num3].write_partial_as_json(handler);
                else
                    storeClauses[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasCodeLanguage)
          {
            handler.start_pair("CodeLanguage");
            if (partial_allowed)
                storeCodeLanguage.write_partial_as_json(handler);
            else
                storeCodeLanguage.write_as_json(handler);
          }
        if (flagHasExtendedBlock)
          {
            handler.start_pair("ExtendedBlock");
            handler.string_value(storeExtendedBlock);
          }
        if (flagHasExtensionWeight)
          {
            handler.start_pair("ExtensionWeight");
            if (textStoreExtensionWeight != "")
                handler.number_value(textStoreExtensionWeight);
            else if (((double)(long)storeExtensionWeight) == storeExtensionWeight)
                handler.number_value((long)storeExtensionWeight);
            else
                handler.number_value(storeExtensionWeight);
          }
        if (flagHasDomain)
          {
            handler.start_pair("Domain");
            handler.string_value(storeDomain);
          }
        if (flagHasMode)
          {
            handler.start_pair("Mode");
            handler.string_value(storeMode);
          }
        if (flagHasModeIndependent)
          {
            handler.start_pair("ModeIndependent");
            handler.boolean_value(storeModeIndependent);
          }
        if (flagHasBlockSource)
          {
            handler.start_pair("BlockSource");
            if (partial_allowed)
                storeBlockSource.write_partial_as_json(handler);
            else
                storeBlockSource.write_as_json(handler);
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
        if (!(hasInputParameters()))
          {
            return "When parsing the object for %what%, the \"InputParameters\" field was missing.";
          }
        if (!(hasOutputParameters()))
          {
            return "When parsing the object for %what%, the \"OutputParameters\" field was missing.";
          }
        if (!(hasClauses()))
          {
            return "When parsing the object for %what%, the \"Clauses\" field was missing.";
          }
        return null;
      }

    public static TerrierUploadBlockJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlock", ignore_extras);
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
    public static TerrierUploadBlockJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadBlockJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlock", ignore_extras);
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
    public static TerrierUploadBlockJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadBlockJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlock", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadBlockJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadBlockJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlock", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TerrierUploadBlockNameJSON.HoldingGenerator fieldGeneratorName;
        private TerrierUploadParameterJSON.HoldingArrayGenerator fieldGeneratorInputParameters;
        private TerrierUploadParameterJSON.HoldingArrayGenerator fieldGeneratorOutputParameters;
        private TerrierUploadClauseJSON.HoldingArrayGenerator fieldGeneratorClauses;
        private UploadedCodeFunctionLanguageJSON.HoldingGenerator fieldGeneratorCodeLanguage;
        private JSONHoldingStringGenerator fieldGeneratorExtendedBlock;
        private JSONHoldingNumberTextGenerator fieldGeneratorExtensionWeight;
        private JSONHoldingStringGenerator fieldGeneratorDomain;
        private JSONHoldingStringGenerator fieldGeneratorMode;
        private JSONHoldingBooleanGenerator fieldGeneratorModeIndependent;
        private UploadedCodeSourceJSON.HoldingGenerator fieldGeneratorBlockSource;
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
            TerrierUploadBlockJSON result = new TerrierUploadBlockJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadBlockAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierUploadBlockJSON result)
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
            if (fieldGeneratorInputParameters.have_value)
              {
                result.initInputParameters();
                int count = fieldGeneratorInputParameters.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInputParameters(fieldGeneratorInputParameters.value[num]);
                  }
                fieldGeneratorInputParameters.value.Clear();
                fieldGeneratorInputParameters.have_value = false;
              }
            else if ((!(result.hasInputParameters())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InputParameters\" field was missing.");
              }
            if (fieldGeneratorOutputParameters.have_value)
              {
                result.initOutputParameters();
                int count = fieldGeneratorOutputParameters.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOutputParameters(fieldGeneratorOutputParameters.value[num]);
                  }
                fieldGeneratorOutputParameters.value.Clear();
                fieldGeneratorOutputParameters.have_value = false;
              }
            else if ((!(result.hasOutputParameters())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OutputParameters\" field was missing.");
              }
            if (fieldGeneratorClauses.have_value)
              {
                result.initClauses();
                int count = fieldGeneratorClauses.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendClauses(fieldGeneratorClauses.value[num]);
                  }
                fieldGeneratorClauses.value.Clear();
                fieldGeneratorClauses.have_value = false;
              }
            else if ((!(result.hasClauses())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Clauses\" field was missing.");
              }
            if (fieldGeneratorCodeLanguage.have_value)
              {
                result.setCodeLanguage(fieldGeneratorCodeLanguage.value);
                fieldGeneratorCodeLanguage.have_value = false;
              }
            if (fieldGeneratorExtendedBlock.have_value)
              {
                result.setExtendedBlock(fieldGeneratorExtendedBlock.value);
                fieldGeneratorExtendedBlock.have_value = false;
              }
            if (fieldGeneratorExtensionWeight.have_value)
              {
                result.setExtensionWeightText(fieldGeneratorExtensionWeight.value);
                fieldGeneratorExtensionWeight.have_value = false;
              }
            if (fieldGeneratorDomain.have_value)
              {
                result.setDomain(fieldGeneratorDomain.value);
                fieldGeneratorDomain.have_value = false;
              }
            if (fieldGeneratorMode.have_value)
              {
                result.setMode(fieldGeneratorMode.value);
                fieldGeneratorMode.have_value = false;
              }
            if (fieldGeneratorModeIndependent.have_value)
              {
                result.setModeIndependent(fieldGeneratorModeIndependent.value);
                fieldGeneratorModeIndependent.have_value = false;
              }
            if (fieldGeneratorBlockSource.have_value)
              {
                result.setBlockSource(fieldGeneratorBlockSource.value);
                fieldGeneratorBlockSource.have_value = false;
              }
          }
        protected abstract void handle_result(TerrierUploadBlockJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "lockSource", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorBlockSource;
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "auses", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorClauses;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "deLanguage", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorCodeLanguage;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "omain", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorDomain;
                    break;
                case 'E':
                    if (String.Compare(field_name, 1, "xten", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 6, "edBlock", 0, 7, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorExtendedBlock;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 6, "ionWeight", 0, 9, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorExtensionWeight;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nputParameters", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorInputParameters;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "ode", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorMode;
                          }
                        switch (field_name[4])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 5, "ndependent", 0, 10, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorModeIndependent;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utputParameters", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorOutputParameters;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new TerrierUploadBlockNameJSON.HoldingGenerator("field \"Name\" of the TerrierUploadBlock class", ignore_extras);
            fieldGeneratorInputParameters = new TerrierUploadParameterJSON.HoldingArrayGenerator("field \"InputParameters\" of the TerrierUploadBlock class", ignore_extras);
            fieldGeneratorOutputParameters = new TerrierUploadParameterJSON.HoldingArrayGenerator("field \"OutputParameters\" of the TerrierUploadBlock class", ignore_extras);
            fieldGeneratorClauses = new TerrierUploadClauseJSON.HoldingArrayGenerator("field \"Clauses\" of the TerrierUploadBlock class", ignore_extras);
            fieldGeneratorCodeLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"CodeLanguage\" of the TerrierUploadBlock class", ignore_extras);
            fieldGeneratorExtendedBlock = new JSONHoldingStringGenerator("field \"ExtendedBlock\" of the TerrierUploadBlock class");
            fieldGeneratorExtensionWeight = new JSONHoldingNumberTextGenerator("field \"ExtensionWeight\" of the TerrierUploadBlock class");
            fieldGeneratorDomain = new JSONHoldingStringGenerator("field \"Domain\" of the TerrierUploadBlock class");
            fieldGeneratorMode = new JSONHoldingStringGenerator("field \"Mode\" of the TerrierUploadBlock class");
            fieldGeneratorModeIndependent = new JSONHoldingBooleanGenerator("field \"ModeIndependent\" of the TerrierUploadBlock class");
            fieldGeneratorBlockSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"BlockSource\" of the TerrierUploadBlock class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadBlock class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new TerrierUploadBlockNameJSON.HoldingGenerator("field \"Name\" of the TerrierUploadBlock class", false);
            fieldGeneratorInputParameters = new TerrierUploadParameterJSON.HoldingArrayGenerator("field \"InputParameters\" of the TerrierUploadBlock class", false);
            fieldGeneratorOutputParameters = new TerrierUploadParameterJSON.HoldingArrayGenerator("field \"OutputParameters\" of the TerrierUploadBlock class", false);
            fieldGeneratorClauses = new TerrierUploadClauseJSON.HoldingArrayGenerator("field \"Clauses\" of the TerrierUploadBlock class", false);
            fieldGeneratorCodeLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"CodeLanguage\" of the TerrierUploadBlock class", false);
            fieldGeneratorExtendedBlock = new JSONHoldingStringGenerator("field \"ExtendedBlock\" of the TerrierUploadBlock class");
            fieldGeneratorExtensionWeight = new JSONHoldingNumberTextGenerator("field \"ExtensionWeight\" of the TerrierUploadBlock class");
            fieldGeneratorDomain = new JSONHoldingStringGenerator("field \"Domain\" of the TerrierUploadBlock class");
            fieldGeneratorMode = new JSONHoldingStringGenerator("field \"Mode\" of the TerrierUploadBlock class");
            fieldGeneratorModeIndependent = new JSONHoldingBooleanGenerator("field \"ModeIndependent\" of the TerrierUploadBlock class");
            fieldGeneratorBlockSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"BlockSource\" of the TerrierUploadBlock class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadBlock class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorInputParameters.reset();
            fieldGeneratorOutputParameters.reset();
            fieldGeneratorClauses.reset();
            fieldGeneratorCodeLanguage.reset();
            fieldGeneratorExtendedBlock.reset();
            fieldGeneratorExtensionWeight.reset();
            fieldGeneratorDomain.reset();
            fieldGeneratorMode.reset();
            fieldGeneratorModeIndependent.reset();
            fieldGeneratorBlockSource.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInputParameters.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputParameters.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorClauses.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCodeLanguage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBlockSource.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInputParameters.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputParameters.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorClauses.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCodeLanguage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBlockSource.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierUploadBlockJSON  result)
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
        public TerrierUploadBlockJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadBlockJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadBlockJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadBlockJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadBlockJSON>();
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
    public List<TerrierUploadBlockJSON> value;
  };
  };
