/* file "RestaurantMenuItemModifierJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RestaurantMenuItemModifierJSON : JSONBase
  {
    private bool flagHasModificationId;
    private BigInteger storeModificationId;
    private bool flagHasModifierGroupId;
    private BigInteger storeModifierGroupId;
    private bool flagHasTerrierExpression;
    private string storeTerrierExpression;
    private bool flagHasTerrierExpressionPerfect;
    private string storeTerrierExpressionPerfect;
    private bool flagHasTerrierExpressionConfusion;
    private string storeTerrierExpressionConfusion;
    private bool flagHasFlexibleExpressionData;
    private List< RestaurantMenuFlexibleExpressionDataJSON  > storeFlexibleExpressionData;
    private bool flagHasExternalModificationId;
    private BigInteger storeExternalModificationId;
    private bool flagHasSynonyms;
    private List< string > storeSynonyms;
    private bool flagHasVerb;
    private RestaurantMenuModifierVerbJSON  storeVerb;
    private bool flagHasModificationName;
    private string storeModificationName;
    private bool flagHasModificationNameSpoken;
    private string storeModificationNameSpoken;
    private bool flagHasLastModifier;
    private bool storeLastModifier;
    private bool flagHasPrice;
    private double storePrice;
    private string textStorePrice;
    private bool flagHasWindowCondiment;
    private bool storeWindowCondiment;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONModificationId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ModificationId of RestaurantMenuItemModifierJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ModificationId of RestaurantMenuItemModifierJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setModificationId(extracted_integer);
      }


    private void  fromJSONModifierGroupId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ModifierGroupId of RestaurantMenuItemModifierJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ModifierGroupId of RestaurantMenuItemModifierJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setModifierGroupId(extracted_integer);
      }


    private void  fromJSONTerrierExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TerrierExpression of RestaurantMenuItemModifierJSON is not a string.");
        setTerrierExpression(json_string.getData());
      }


    private void  fromJSONTerrierExpressionPerfect(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TerrierExpressionPerfect of RestaurantMenuItemModifierJSON is not a string.");
        setTerrierExpressionPerfect(json_string.getData());
      }


    private void  fromJSONTerrierExpressionConfusion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TerrierExpressionConfusion of RestaurantMenuItemModifierJSON is not a string.");
        setTerrierExpressionConfusion(json_string.getData());
      }


    private void  fromJSONFlexibleExpressionData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlexibleExpressionData of RestaurantMenuItemModifierJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field FlexibleExpressionData of RestaurantMenuItemModifierJSON has too few elements.");
        List< RestaurantMenuFlexibleExpressionDataJSON  > vector_FlexibleExpressionData1 = new List< RestaurantMenuFlexibleExpressionDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantMenuFlexibleExpressionDataJSON convert_classy = RestaurantMenuFlexibleExpressionDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlexibleExpressionData1.Add(convert_classy);
          }
        Debug.Assert(vector_FlexibleExpressionData1.Count >= 1);
        initFlexibleExpressionData();
        for (int num1 = 0; num1 < vector_FlexibleExpressionData1.Count; ++num1)
            appendFlexibleExpressionData(vector_FlexibleExpressionData1[num1]);
        for (int num1 = 0; num1 < vector_FlexibleExpressionData1.Count; ++num1)
          {
          }
      }


    private void  fromJSONExternalModificationId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ExternalModificationId of RestaurantMenuItemModifierJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ExternalModificationId of RestaurantMenuItemModifierJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setExternalModificationId(extracted_integer);
      }


    private void  fromJSONSynonyms(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Synonyms of RestaurantMenuItemModifierJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Synonyms of RestaurantMenuItemModifierJSON has too few elements.");
        List< string > vector_Synonyms1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Synonyms of RestaurantMenuItemModifierJSON is not a string.");
            vector_Synonyms1.Add(json_string.getData());
          }
        Debug.Assert(vector_Synonyms1.Count >= 1);
        initSynonyms();
        for (int num2 = 0; num2 < vector_Synonyms1.Count; ++num2)
            appendSynonyms(vector_Synonyms1[num2]);
        for (int num1 = 0; num1 < vector_Synonyms1.Count; ++num1)
          {
          }
      }


    private void  fromJSONVerb(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RestaurantMenuModifierVerbJSON convert_classy = RestaurantMenuModifierVerbJSON.from_json(json_value, ignore_extras, true);
        setVerb(convert_classy);
      }


    private void  fromJSONModificationName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ModificationName of RestaurantMenuItemModifierJSON is not a string.");
        setModificationName(json_string.getData());
      }


    private void  fromJSONModificationNameSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ModificationNameSpoken of RestaurantMenuItemModifierJSON is not a string.");
        setModificationNameSpoken(json_string.getData());
      }


    private void  fromJSONLastModifier(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field LastModifier of RestaurantMenuItemModifierJSON is not true for false.");
              }
          }
        setLastModifier(the_bool);
      }


    private void  fromJSONPrice(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Price of RestaurantMenuItemModifierJSON is not a number.");
              }
          }
        setPriceText(the_rational_text);
      }


    private void  fromJSONWindowCondiment(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field WindowCondiment of RestaurantMenuItemModifierJSON is not true for false.");
              }
          }
        setWindowCondiment(the_bool);
      }


    public RestaurantMenuItemModifierJSON()
      {
        flagHasModificationId = false;
        flagHasModifierGroupId = false;
        flagHasTerrierExpression = false;
        flagHasTerrierExpressionPerfect = false;
        flagHasTerrierExpressionConfusion = false;
        flagHasFlexibleExpressionData = false;
        flagHasExternalModificationId = false;
        flagHasSynonyms = false;
        flagHasVerb = false;
        flagHasModificationName = false;
        flagHasModificationNameSpoken = false;
        flagHasLastModifier = false;
        flagHasPrice = false;
        flagHasWindowCondiment = false;
        storeFlexibleExpressionData = new List< RestaurantMenuFlexibleExpressionDataJSON  >();
        storeSynonyms = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasModificationId()
      {
        return flagHasModificationId;
      }

    public BigInteger  getModificationId()
      {
        Debug.Assert(flagHasModificationId);
        return storeModificationId;
      }

    public bool  hasModifierGroupId()
      {
        return flagHasModifierGroupId;
      }

    public BigInteger  getModifierGroupId()
      {
        Debug.Assert(flagHasModifierGroupId);
        return storeModifierGroupId;
      }

    public bool  hasTerrierExpression()
      {
        return flagHasTerrierExpression;
      }

    public string  getTerrierExpression()
      {
        Debug.Assert(flagHasTerrierExpression);
        return storeTerrierExpression;
      }

    public bool  hasTerrierExpressionPerfect()
      {
        return flagHasTerrierExpressionPerfect;
      }

    public string  getTerrierExpressionPerfect()
      {
        Debug.Assert(flagHasTerrierExpressionPerfect);
        return storeTerrierExpressionPerfect;
      }

    public bool  hasTerrierExpressionConfusion()
      {
        return flagHasTerrierExpressionConfusion;
      }

    public string  getTerrierExpressionConfusion()
      {
        Debug.Assert(flagHasTerrierExpressionConfusion);
        return storeTerrierExpressionConfusion;
      }

    public bool  hasFlexibleExpressionData()
      {
        return flagHasFlexibleExpressionData;
      }

    public int  countOfFlexibleExpressionData()
      {
        Debug.Assert(flagHasFlexibleExpressionData);
        return storeFlexibleExpressionData.Count;
      }

    public RestaurantMenuFlexibleExpressionDataJSON   elementOfFlexibleExpressionData(int element_num)
      {
        Debug.Assert(flagHasFlexibleExpressionData);
        return storeFlexibleExpressionData[element_num];
      }

    public List< RestaurantMenuFlexibleExpressionDataJSON  >  getFlexibleExpressionData()
      {
        Debug.Assert(flagHasFlexibleExpressionData);
        return storeFlexibleExpressionData;
      }

    public bool  hasExternalModificationId()
      {
        return flagHasExternalModificationId;
      }

    public BigInteger  getExternalModificationId()
      {
        Debug.Assert(flagHasExternalModificationId);
        return storeExternalModificationId;
      }

    public bool  hasSynonyms()
      {
        return flagHasSynonyms;
      }

    public int  countOfSynonyms()
      {
        Debug.Assert(flagHasSynonyms);
        return storeSynonyms.Count;
      }

    public string  elementOfSynonyms(int element_num)
      {
        Debug.Assert(flagHasSynonyms);
        return storeSynonyms[element_num];
      }

    public List< string >  getSynonyms()
      {
        Debug.Assert(flagHasSynonyms);
        return storeSynonyms;
      }

    public bool  hasVerb()
      {
        return flagHasVerb;
      }

    public RestaurantMenuModifierVerbJSON   getVerb()
      {
        Debug.Assert(flagHasVerb);
        return storeVerb;
      }

    public RestaurantMenuModifierVerbJSON.TypeValue  getVerbValue()
      {
        return getVerb().getValue();
      }

    public string  getVerbAsString()
      {
        return getVerb().getValueAsString();
      }

    public bool  hasModificationName()
      {
        return flagHasModificationName;
      }

    public string  getModificationName()
      {
        Debug.Assert(flagHasModificationName);
        return storeModificationName;
      }

    public bool  hasModificationNameSpoken()
      {
        return flagHasModificationNameSpoken;
      }

    public string  getModificationNameSpoken()
      {
        Debug.Assert(flagHasModificationNameSpoken);
        return storeModificationNameSpoken;
      }

    public bool  hasLastModifier()
      {
        return flagHasLastModifier;
      }

    public bool  getLastModifier()
      {
        Debug.Assert(flagHasLastModifier);
        return storeLastModifier;
      }

    public bool  hasPrice()
      {
        return flagHasPrice;
      }

    public double  getPrice()
      {
        Debug.Assert(flagHasPrice);
        if (textStorePrice != "")
          {
            return Double.Parse(textStorePrice);
          }
        return storePrice;
      }

    public string  getPriceAsText()
      {
        Debug.Assert(flagHasPrice);
        if (textStorePrice == "")
          {
            return Convert.ToString(storePrice);
          }
        else
          {
            return (textStorePrice);
          }
      }

    public bool  hasWindowCondiment()
      {
        return flagHasWindowCondiment;
      }

    public bool  getWindowCondiment()
      {
        Debug.Assert(flagHasWindowCondiment);
        return storeWindowCondiment;
      }


    public virtual int extraRestaurantMenuItemModifierComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantMenuItemModifierComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantMenuItemModifierComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantMenuItemModifierLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setModificationId(BigInteger new_value)
      {
        flagHasModificationId = true;
        storeModificationId = new_value;
      }
    public void unsetModificationId()
      {
        flagHasModificationId = false;
      }
    public void setModifierGroupId(BigInteger new_value)
      {
        flagHasModifierGroupId = true;
        storeModifierGroupId = new_value;
      }
    public void unsetModifierGroupId()
      {
        flagHasModifierGroupId = false;
      }
    public void setTerrierExpression(string new_value)
      {
        flagHasTerrierExpression = true;
        storeTerrierExpression = new_value;
      }
    public void unsetTerrierExpression()
      {
        flagHasTerrierExpression = false;
      }
    public void setTerrierExpressionPerfect(string new_value)
      {
        flagHasTerrierExpressionPerfect = true;
        storeTerrierExpressionPerfect = new_value;
      }
    public void unsetTerrierExpressionPerfect()
      {
        flagHasTerrierExpressionPerfect = false;
      }
    public void setTerrierExpressionConfusion(string new_value)
      {
        flagHasTerrierExpressionConfusion = true;
        storeTerrierExpressionConfusion = new_value;
      }
    public void unsetTerrierExpressionConfusion()
      {
        flagHasTerrierExpressionConfusion = false;
      }
    public void initFlexibleExpressionData()
      {
        if (flagHasFlexibleExpressionData)
          {
            for (int num1 = 0; num1 < storeFlexibleExpressionData.Count; ++num1)
              {
              }
          }
        flagHasFlexibleExpressionData = true;
        storeFlexibleExpressionData.Clear();
      }
    public void appendFlexibleExpressionData(RestaurantMenuFlexibleExpressionDataJSON  to_append)
      {
        if (!flagHasFlexibleExpressionData)
          {
            flagHasFlexibleExpressionData = true;
            storeFlexibleExpressionData.Clear();
          }
        Debug.Assert(flagHasFlexibleExpressionData);
        storeFlexibleExpressionData.Add(to_append);
      }
    public void unsetFlexibleExpressionData()
      {
        if (flagHasFlexibleExpressionData)
          {
            for (int num2 = 0; num2 < storeFlexibleExpressionData.Count; ++num2)
              {
              }
          }
        flagHasFlexibleExpressionData = false;
        storeFlexibleExpressionData.Clear();
      }
    public void setExternalModificationId(BigInteger new_value)
      {
        flagHasExternalModificationId = true;
        storeExternalModificationId = new_value;
      }
    public void unsetExternalModificationId()
      {
        flagHasExternalModificationId = false;
      }
    public void initSynonyms()
      {
        flagHasSynonyms = true;
        storeSynonyms.Clear();
      }
    public void appendSynonyms(string to_append)
      {
        if (!flagHasSynonyms)
          {
            flagHasSynonyms = true;
            storeSynonyms.Clear();
          }
        Debug.Assert(flagHasSynonyms);
        storeSynonyms.Add(to_append);
      }
    public void unsetSynonyms()
      {
        flagHasSynonyms = false;
        storeSynonyms.Clear();
      }
    public void setVerb(RestaurantMenuModifierVerbJSON  new_value)
      {
        if (flagHasVerb)
          {
          }
        flagHasVerb = true;
        storeVerb = new_value;
      }
    public void setVerb(RestaurantMenuModifierVerbJSON.TypeValue new_value)
      {
        setVerb(new RestaurantMenuModifierVerbJSON(new_value));
      }
    public void setVerb(string chars)
      {
        setVerb(new RestaurantMenuModifierVerbJSON(chars));
      }
    public void unsetVerb()
      {
        if (flagHasVerb)
          {
          }
        flagHasVerb = false;
      }
    public void setModificationName(string new_value)
      {
        flagHasModificationName = true;
        storeModificationName = new_value;
      }
    public void unsetModificationName()
      {
        flagHasModificationName = false;
      }
    public void setModificationNameSpoken(string new_value)
      {
        flagHasModificationNameSpoken = true;
        storeModificationNameSpoken = new_value;
      }
    public void unsetModificationNameSpoken()
      {
        flagHasModificationNameSpoken = false;
      }
    public void setLastModifier(bool new_value)
      {
        flagHasLastModifier = true;
        storeLastModifier = new_value;
      }
    public void unsetLastModifier()
      {
        flagHasLastModifier = false;
      }
    public void setPrice(double new_value)
      {
        flagHasPrice = true;
        storePrice = new_value;
        textStorePrice = "";
      }
    public void setPriceText(string new_value)
      {
        flagHasPrice = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Price of RestaurantMenuItemModifierJSON is not a valid number.");
        textStorePrice = new_value;
      }
    public void unsetPrice()
      {
        flagHasPrice = false;
      }
    public void setWindowCondiment(bool new_value)
      {
        flagHasWindowCondiment = true;
        storeWindowCondiment = new_value;
      }
    public void unsetWindowCondiment()
      {
        flagHasWindowCondiment = false;
      }

    public virtual void extraRestaurantMenuItemModifierAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantMenuItemModifierSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantMenuItemModifierLookup(key);
        if (old_field == null)
          {
            extraRestaurantMenuItemModifierAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasModificationId);
        if (flagHasModificationId)
          {
            handler.start_pair("ModificationId");
            handler.number_value(storeModificationId);
          }
        if (flagHasModifierGroupId)
          {
            handler.start_pair("ModifierGroupId");
            handler.number_value(storeModifierGroupId);
          }
        if (flagHasTerrierExpression)
          {
            handler.start_pair("TerrierExpression");
            handler.string_value(storeTerrierExpression);
          }
        if (flagHasTerrierExpressionPerfect)
          {
            handler.start_pair("TerrierExpressionPerfect");
            handler.string_value(storeTerrierExpressionPerfect);
          }
        if (flagHasTerrierExpressionConfusion)
          {
            handler.start_pair("TerrierExpressionConfusion");
            handler.string_value(storeTerrierExpressionConfusion);
          }
        if (flagHasFlexibleExpressionData)
          {
            handler.start_pair("FlexibleExpressionData");
            Debug.Assert(storeFlexibleExpressionData.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeFlexibleExpressionData.Count; ++num1)
              {
                if (partial_allowed)
                    storeFlexibleExpressionData[num1].write_partial_as_json(handler);
                else
                    storeFlexibleExpressionData[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasExternalModificationId);
        if (flagHasExternalModificationId)
          {
            handler.start_pair("ExternalModificationId");
            handler.number_value(storeExternalModificationId);
          }
        if (flagHasSynonyms)
          {
            handler.start_pair("Synonyms");
            Debug.Assert(storeSynonyms.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeSynonyms.Count; ++num2)
              {
                handler.string_value(storeSynonyms[num2]);
              }
            handler.finish_array();
          }
        if (flagHasVerb)
          {
            handler.start_pair("Verb");
            if (partial_allowed)
                storeVerb.write_partial_as_json(handler);
            else
                storeVerb.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasModificationName);
        if (flagHasModificationName)
          {
            handler.start_pair("ModificationName");
            handler.string_value(storeModificationName);
          }
        if (flagHasModificationNameSpoken)
          {
            handler.start_pair("ModificationNameSpoken");
            handler.string_value(storeModificationNameSpoken);
          }
        if (flagHasLastModifier)
          {
            handler.start_pair("LastModifier");
            handler.boolean_value(storeLastModifier);
          }
        if (flagHasPrice)
          {
            handler.start_pair("Price");
            if (textStorePrice != "")
                handler.number_value(textStorePrice);
            else if (((double)(long)storePrice) == storePrice)
                handler.number_value((long)storePrice);
            else
                handler.number_value(storePrice);
          }
        if (flagHasWindowCondiment)
          {
            handler.start_pair("WindowCondiment");
            handler.boolean_value(storeWindowCondiment);
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
        if (!(hasModificationId()))
          {
            return "When parsing the object for %what%, the \"ModificationId\" field was missing.";
          }
        if (!(hasExternalModificationId()))
          {
            return "When parsing the object for %what%, the \"ExternalModificationId\" field was missing.";
          }
        if (!(hasModificationName()))
          {
            return "When parsing the object for %what%, the \"ModificationName\" field was missing.";
          }
        return null;
      }

    public static RestaurantMenuItemModifierJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuItemModifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuItemModifier", ignore_extras);
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
    public static RestaurantMenuItemModifierJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuItemModifierJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuItemModifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuItemModifier", ignore_extras);
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
    public static RestaurantMenuItemModifierJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuItemModifierJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuItemModifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuItemModifier", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuItemModifierJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuItemModifierJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuItemModifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuItemModifier", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorModificationId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorModificationId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorModificationId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorModificationId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorModificationId fieldGeneratorModificationId;
    private class FieldHoldingGeneratorModifierGroupId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorModifierGroupId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorModifierGroupId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorModifierGroupId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorModifierGroupId fieldGeneratorModifierGroupId;
        private JSONHoldingStringGenerator fieldGeneratorTerrierExpression;
        private JSONHoldingStringGenerator fieldGeneratorTerrierExpressionPerfect;
        private JSONHoldingStringGenerator fieldGeneratorTerrierExpressionConfusion;
        private RestaurantMenuFlexibleExpressionDataJSON.HoldingArrayGenerator fieldGeneratorFlexibleExpressionData;
    private class FieldHoldingGeneratorExternalModificationId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorExternalModificationId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorExternalModificationId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorExternalModificationId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorExternalModificationId fieldGeneratorExternalModificationId;
        private JSONHoldingStringArrayGenerator fieldGeneratorSynonyms;
        private RestaurantMenuModifierVerbJSON.HoldingGenerator fieldGeneratorVerb;
        private JSONHoldingStringGenerator fieldGeneratorModificationName;
        private JSONHoldingStringGenerator fieldGeneratorModificationNameSpoken;
        private JSONHoldingBooleanGenerator fieldGeneratorLastModifier;
        private JSONHoldingNumberTextGenerator fieldGeneratorPrice;
        private JSONHoldingBooleanGenerator fieldGeneratorWindowCondiment;
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
            RestaurantMenuItemModifierJSON result = new RestaurantMenuItemModifierJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantMenuItemModifierAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantMenuItemModifierJSON result)
          {
            if (fieldGeneratorModificationId.have_value)
              {
                result.setModificationId(fieldGeneratorModificationId.value);
                fieldGeneratorModificationId.have_value = false;
              }
            else if ((!(result.hasModificationId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ModificationId\" field was missing.");
              }
            if (fieldGeneratorModifierGroupId.have_value)
              {
                result.setModifierGroupId(fieldGeneratorModifierGroupId.value);
                fieldGeneratorModifierGroupId.have_value = false;
              }
            if (fieldGeneratorTerrierExpression.have_value)
              {
                result.setTerrierExpression(fieldGeneratorTerrierExpression.value);
                fieldGeneratorTerrierExpression.have_value = false;
              }
            if (fieldGeneratorTerrierExpressionPerfect.have_value)
              {
                result.setTerrierExpressionPerfect(fieldGeneratorTerrierExpressionPerfect.value);
                fieldGeneratorTerrierExpressionPerfect.have_value = false;
              }
            if (fieldGeneratorTerrierExpressionConfusion.have_value)
              {
                result.setTerrierExpressionConfusion(fieldGeneratorTerrierExpressionConfusion.value);
                fieldGeneratorTerrierExpressionConfusion.have_value = false;
              }
            if (fieldGeneratorFlexibleExpressionData.have_value)
              {
                result.initFlexibleExpressionData();
                int count = fieldGeneratorFlexibleExpressionData.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlexibleExpressionData(fieldGeneratorFlexibleExpressionData.value[num]);
                  }
                fieldGeneratorFlexibleExpressionData.value.Clear();
                fieldGeneratorFlexibleExpressionData.have_value = false;
              }
            if (fieldGeneratorExternalModificationId.have_value)
              {
                result.setExternalModificationId(fieldGeneratorExternalModificationId.value);
                fieldGeneratorExternalModificationId.have_value = false;
              }
            else if ((!(result.hasExternalModificationId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExternalModificationId\" field was missing.");
              }
            if (fieldGeneratorSynonyms.have_value)
              {
                result.initSynonyms();
                int count = fieldGeneratorSynonyms.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSynonyms(fieldGeneratorSynonyms.value[num]);
                  }
                fieldGeneratorSynonyms.value.Clear();
                fieldGeneratorSynonyms.have_value = false;
              }
            if (fieldGeneratorVerb.have_value)
              {
                result.setVerb(fieldGeneratorVerb.value);
                fieldGeneratorVerb.have_value = false;
              }
            if (fieldGeneratorModificationName.have_value)
              {
                result.setModificationName(fieldGeneratorModificationName.value);
                fieldGeneratorModificationName.have_value = false;
              }
            else if ((!(result.hasModificationName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ModificationName\" field was missing.");
              }
            if (fieldGeneratorModificationNameSpoken.have_value)
              {
                result.setModificationNameSpoken(fieldGeneratorModificationNameSpoken.value);
                fieldGeneratorModificationNameSpoken.have_value = false;
              }
            if (fieldGeneratorLastModifier.have_value)
              {
                result.setLastModifier(fieldGeneratorLastModifier.value);
                fieldGeneratorLastModifier.have_value = false;
              }
            if (fieldGeneratorPrice.have_value)
              {
                result.setPriceText(fieldGeneratorPrice.value);
                fieldGeneratorPrice.have_value = false;
              }
            if (fieldGeneratorWindowCondiment.have_value)
              {
                result.setWindowCondiment(fieldGeneratorWindowCondiment.value);
                fieldGeneratorWindowCondiment.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantMenuItemModifierJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "xternalModificationId", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorExternalModificationId;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "lexibleExpressionData", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorFlexibleExpressionData;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astModifier", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorLastModifier;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "odifi", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'c':
                                if (String.Compare(field_name, 7, "ation", 0, 5, false) == 0)
                                  {
                                    switch (field_name[12])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 13, "d", 0, 1, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorModificationId;
                                            break;
                                        case 'N':
                                            if (String.Compare(field_name, 13, "ame", 0, 3, false) == 0)
                                              {
                                                if (field_name.Length == 16)
                                                  {
                                                    return fieldGeneratorModificationName;
                                                  }
                                                switch (field_name[16])
                                                  {
                                                    case 'S':
                                                        if ((String.Compare(field_name, 17, "poken", 0, 5, false) == 0) && (field_name.Length == 22))
                                                            return fieldGeneratorModificationNameSpoken;
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
                            case 'e':
                                if ((String.Compare(field_name, 7, "rGroupId", 0, 8, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorModifierGroupId;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rice", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorPrice;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ynonyms", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorSynonyms;
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "errierExpression", 0, 16, false) == 0)
                      {
                        if (field_name.Length == 17)
                          {
                            return fieldGeneratorTerrierExpression;
                          }
                        switch (field_name[17])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 18, "onfusion", 0, 8, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorTerrierExpressionConfusion;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 18, "erfect", 0, 6, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorTerrierExpressionPerfect;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "erb", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorVerb;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "indowCondiment", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorWindowCondiment;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorModificationId = new FieldHoldingGeneratorModificationId("field \"ModificationId\" of the RestaurantMenuItemModifier class");
            fieldGeneratorModifierGroupId = new FieldHoldingGeneratorModifierGroupId("field \"ModifierGroupId\" of the RestaurantMenuItemModifier class");
            fieldGeneratorTerrierExpression = new JSONHoldingStringGenerator("field \"TerrierExpression\" of the RestaurantMenuItemModifier class");
            fieldGeneratorTerrierExpressionPerfect = new JSONHoldingStringGenerator("field \"TerrierExpressionPerfect\" of the RestaurantMenuItemModifier class");
            fieldGeneratorTerrierExpressionConfusion = new JSONHoldingStringGenerator("field \"TerrierExpressionConfusion\" of the RestaurantMenuItemModifier class");
            fieldGeneratorFlexibleExpressionData = new RestaurantMenuFlexibleExpressionDataJSON.HoldingArrayGenerator("field \"FlexibleExpressionData\" of the RestaurantMenuItemModifier class", ignore_extras);
            fieldGeneratorExternalModificationId = new FieldHoldingGeneratorExternalModificationId("field \"ExternalModificationId\" of the RestaurantMenuItemModifier class");
            fieldGeneratorSynonyms = new JSONHoldingStringArrayGenerator("field \"Synonyms\" of the RestaurantMenuItemModifier class");
            fieldGeneratorVerb = new RestaurantMenuModifierVerbJSON.HoldingGenerator("field \"Verb\" of the RestaurantMenuItemModifier class", ignore_extras);
            fieldGeneratorModificationName = new JSONHoldingStringGenerator("field \"ModificationName\" of the RestaurantMenuItemModifier class");
            fieldGeneratorModificationNameSpoken = new JSONHoldingStringGenerator("field \"ModificationNameSpoken\" of the RestaurantMenuItemModifier class");
            fieldGeneratorLastModifier = new JSONHoldingBooleanGenerator("field \"LastModifier\" of the RestaurantMenuItemModifier class");
            fieldGeneratorPrice = new JSONHoldingNumberTextGenerator("field \"Price\" of the RestaurantMenuItemModifier class");
            fieldGeneratorWindowCondiment = new JSONHoldingBooleanGenerator("field \"WindowCondiment\" of the RestaurantMenuItemModifier class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantMenuItemModifier class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorModificationId = new FieldHoldingGeneratorModificationId("field \"ModificationId\" of the RestaurantMenuItemModifier class");
            fieldGeneratorModifierGroupId = new FieldHoldingGeneratorModifierGroupId("field \"ModifierGroupId\" of the RestaurantMenuItemModifier class");
            fieldGeneratorTerrierExpression = new JSONHoldingStringGenerator("field \"TerrierExpression\" of the RestaurantMenuItemModifier class");
            fieldGeneratorTerrierExpressionPerfect = new JSONHoldingStringGenerator("field \"TerrierExpressionPerfect\" of the RestaurantMenuItemModifier class");
            fieldGeneratorTerrierExpressionConfusion = new JSONHoldingStringGenerator("field \"TerrierExpressionConfusion\" of the RestaurantMenuItemModifier class");
            fieldGeneratorFlexibleExpressionData = new RestaurantMenuFlexibleExpressionDataJSON.HoldingArrayGenerator("field \"FlexibleExpressionData\" of the RestaurantMenuItemModifier class", false);
            fieldGeneratorExternalModificationId = new FieldHoldingGeneratorExternalModificationId("field \"ExternalModificationId\" of the RestaurantMenuItemModifier class");
            fieldGeneratorSynonyms = new JSONHoldingStringArrayGenerator("field \"Synonyms\" of the RestaurantMenuItemModifier class");
            fieldGeneratorVerb = new RestaurantMenuModifierVerbJSON.HoldingGenerator("field \"Verb\" of the RestaurantMenuItemModifier class", false);
            fieldGeneratorModificationName = new JSONHoldingStringGenerator("field \"ModificationName\" of the RestaurantMenuItemModifier class");
            fieldGeneratorModificationNameSpoken = new JSONHoldingStringGenerator("field \"ModificationNameSpoken\" of the RestaurantMenuItemModifier class");
            fieldGeneratorLastModifier = new JSONHoldingBooleanGenerator("field \"LastModifier\" of the RestaurantMenuItemModifier class");
            fieldGeneratorPrice = new JSONHoldingNumberTextGenerator("field \"Price\" of the RestaurantMenuItemModifier class");
            fieldGeneratorWindowCondiment = new JSONHoldingBooleanGenerator("field \"WindowCondiment\" of the RestaurantMenuItemModifier class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantMenuItemModifier class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorModificationId.reset();
            fieldGeneratorModifierGroupId.reset();
            fieldGeneratorTerrierExpression.reset();
            fieldGeneratorTerrierExpressionPerfect.reset();
            fieldGeneratorTerrierExpressionConfusion.reset();
            fieldGeneratorFlexibleExpressionData.reset();
            fieldGeneratorExternalModificationId.reset();
            fieldGeneratorSynonyms.reset();
            fieldGeneratorVerb.reset();
            fieldGeneratorModificationName.reset();
            fieldGeneratorModificationNameSpoken.reset();
            fieldGeneratorLastModifier.reset();
            fieldGeneratorPrice.reset();
            fieldGeneratorWindowCondiment.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFlexibleExpressionData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorVerb.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFlexibleExpressionData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorVerb.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantMenuItemModifierJSON  result)
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
        public RestaurantMenuItemModifierJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuItemModifierJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuItemModifierJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuItemModifierJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuItemModifierJSON>();
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
    public List<RestaurantMenuItemModifierJSON> value;
  };
  };
