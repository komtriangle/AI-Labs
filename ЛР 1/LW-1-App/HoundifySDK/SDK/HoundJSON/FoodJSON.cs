/* file "FoodJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FoodJSON : JSONBase
  {
    private bool flagHasID;
    private BigInteger storeID;
    private bool flagHasQuantity;
    private double storeQuantity;
    private string textStoreQuantity;
    private bool flagHasNDB_No;
    private string storeNDB_No;
    private bool flagHasSizeIndex;
    private BigInteger storeSizeIndex;
    private bool flagHasNameIncludesUnits;
    private bool storeNameIncludesUnits;
    private bool flagHasExclude;
    private bool storeExclude;
    private bool flagHasSpokenNoSize;
    private string storeSpokenNoSize;
    private bool flagHasWrittenNoSize;
    private string storeWrittenNoSize;
    private bool flagHasWikiUrl;
    private string storeWikiUrl;
    private bool flagHasImageUrl;
    private string storeImageUrl;
    private bool flagHasAllSizes;
    private List< FoodSizeJSON  > storeAllSizes;
    private bool flagHasNutrients;
    private List< NutrientJSON  > storeNutrients;
    private bool flagHasNutrientNameToID;
    private JSONObjectValue  storeNutrientNameToID;


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ID of FoodJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ID of FoodJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setID(extracted_integer);
      }


    private void  fromJSONQuantity(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Quantity of FoodJSON is not a number.");
              }
          }
        setQuantityText(the_rational_text);
      }


    private void  fromJSONNDB_No(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NDB_No of FoodJSON is not a string.");
        setNDB_No(json_string.getData());
      }


    private void  fromJSONSizeIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SizeIndex of FoodJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SizeIndex of FoodJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSizeIndex(extracted_integer);
      }


    private void  fromJSONNameIncludesUnits(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NameIncludesUnits of FoodJSON is not true for false.");
              }
          }
        setNameIncludesUnits(the_bool);
      }


    private void  fromJSONExclude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Exclude of FoodJSON is not true for false.");
              }
          }
        setExclude(the_bool);
      }


    private void  fromJSONSpokenNoSize(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenNoSize of FoodJSON is not a string.");
        setSpokenNoSize(json_string.getData());
      }


    private void  fromJSONWrittenNoSize(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenNoSize of FoodJSON is not a string.");
        setWrittenNoSize(json_string.getData());
      }


    private void  fromJSONWikiUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WikiUrl of FoodJSON is not a string.");
        setWikiUrl(json_string.getData());
      }


    private void  fromJSONImageUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ImageUrl of FoodJSON is not a string.");
        setImageUrl(json_string.getData());
      }


    private void  fromJSONAllSizes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AllSizes of FoodJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FoodSizeJSON  > vector_AllSizes1 = new List< FoodSizeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FoodSizeJSON convert_classy = FoodSizeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AllSizes1.Add(convert_classy);
          }
        initAllSizes();
        for (int num1 = 0; num1 < vector_AllSizes1.Count; ++num1)
            appendAllSizes(vector_AllSizes1[num1]);
        for (int num1 = 0; num1 < vector_AllSizes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNutrients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Nutrients of FoodJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< NutrientJSON  > vector_Nutrients1 = new List< NutrientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            NutrientJSON convert_classy = NutrientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Nutrients1.Add(convert_classy);
          }
        initNutrients();
        for (int num2 = 0; num2 < vector_Nutrients1.Count; ++num2)
            appendNutrients(vector_Nutrients1[num2]);
        for (int num1 = 0; num1 < vector_Nutrients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNutrientNameToID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field NutrientNameToID of FoodJSON is not an object.");
        setNutrientNameToID(json_value.object_value());
      }


    public FoodJSON()
      {
        flagHasID = false;
        flagHasQuantity = false;
        flagHasNDB_No = false;
        flagHasSizeIndex = false;
        flagHasNameIncludesUnits = false;
        flagHasExclude = false;
        flagHasSpokenNoSize = false;
        flagHasWrittenNoSize = false;
        flagHasWikiUrl = false;
        flagHasImageUrl = false;
        flagHasAllSizes = false;
        flagHasNutrients = false;
        flagHasNutrientNameToID = false;
        storeAllSizes = new List< FoodSizeJSON  >();
        storeNutrients = new List< NutrientJSON  >();
      }

    public bool  hasID()
      {
        return flagHasID;
      }

    public BigInteger  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }

    public bool  hasQuantity()
      {
        return flagHasQuantity;
      }

    public double  getQuantity()
      {
        Debug.Assert(flagHasQuantity);
        if (textStoreQuantity != "")
          {
            return Double.Parse(textStoreQuantity);
          }
        return storeQuantity;
      }

    public string  getQuantityAsText()
      {
        Debug.Assert(flagHasQuantity);
        if (textStoreQuantity == "")
          {
            return Convert.ToString(storeQuantity);
          }
        else
          {
            return (textStoreQuantity);
          }
      }

    public bool  hasNDB_No()
      {
        return flagHasNDB_No;
      }

    public string  getNDB_No()
      {
        Debug.Assert(flagHasNDB_No);
        return storeNDB_No;
      }

    public bool  hasSizeIndex()
      {
        return flagHasSizeIndex;
      }

    public BigInteger  getSizeIndex()
      {
        Debug.Assert(flagHasSizeIndex);
        return storeSizeIndex;
      }

    public bool  hasNameIncludesUnits()
      {
        return flagHasNameIncludesUnits;
      }

    public bool  getNameIncludesUnits()
      {
        Debug.Assert(flagHasNameIncludesUnits);
        return storeNameIncludesUnits;
      }

    public bool  hasExclude()
      {
        return flagHasExclude;
      }

    public bool  getExclude()
      {
        Debug.Assert(flagHasExclude);
        return storeExclude;
      }

    public bool  hasSpokenNoSize()
      {
        return flagHasSpokenNoSize;
      }

    public string  getSpokenNoSize()
      {
        Debug.Assert(flagHasSpokenNoSize);
        return storeSpokenNoSize;
      }

    public bool  hasWrittenNoSize()
      {
        return flagHasWrittenNoSize;
      }

    public string  getWrittenNoSize()
      {
        Debug.Assert(flagHasWrittenNoSize);
        return storeWrittenNoSize;
      }

    public bool  hasWikiUrl()
      {
        return flagHasWikiUrl;
      }

    public string  getWikiUrl()
      {
        Debug.Assert(flagHasWikiUrl);
        return storeWikiUrl;
      }

    public bool  hasImageUrl()
      {
        return flagHasImageUrl;
      }

    public string  getImageUrl()
      {
        Debug.Assert(flagHasImageUrl);
        return storeImageUrl;
      }

    public bool  hasAllSizes()
      {
        return flagHasAllSizes;
      }

    public int  countOfAllSizes()
      {
        Debug.Assert(flagHasAllSizes);
        return storeAllSizes.Count;
      }

    public FoodSizeJSON   elementOfAllSizes(int element_num)
      {
        Debug.Assert(flagHasAllSizes);
        return storeAllSizes[element_num];
      }

    public List< FoodSizeJSON  >  getAllSizes()
      {
        Debug.Assert(flagHasAllSizes);
        return storeAllSizes;
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

    public bool  hasNutrientNameToID()
      {
        return flagHasNutrientNameToID;
      }

    public JSONObjectValue   getNutrientNameToID()
      {
        Debug.Assert(flagHasNutrientNameToID);
        return storeNutrientNameToID;
      }



    public void setID(BigInteger new_value)
      {
        flagHasID = true;
        if (new_value < -1)
            throw new Exception("The value for field ID of FoodJSON is less than the lower bound (-1) for that field.");
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void setQuantity(double new_value)
      {
        flagHasQuantity = true;
        if (new_value < 0)
            throw new Exception("The value for field Quantity of FoodJSON is less than the lower bound (0) for that field.");
        storeQuantity = new_value;
        textStoreQuantity = "";
      }
    public void setQuantityText(string new_value)
      {
        flagHasQuantity = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Quantity of FoodJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Quantity of FoodJSON is less than the lower bound (0) for that field.");
        textStoreQuantity = new_value;
      }
    public void unsetQuantity()
      {
        flagHasQuantity = false;
      }
    public void setNDB_No(string new_value)
      {
        flagHasNDB_No = true;
        storeNDB_No = new_value;
      }
    public void unsetNDB_No()
      {
        flagHasNDB_No = false;
      }
    public void setSizeIndex(BigInteger new_value)
      {
        flagHasSizeIndex = true;
        if (new_value < -1)
            throw new Exception("The value for field SizeIndex of FoodJSON is less than the lower bound (-1) for that field.");
        storeSizeIndex = new_value;
      }
    public void unsetSizeIndex()
      {
        flagHasSizeIndex = false;
      }
    public void setNameIncludesUnits(bool new_value)
      {
        flagHasNameIncludesUnits = true;
        storeNameIncludesUnits = new_value;
      }
    public void unsetNameIncludesUnits()
      {
        flagHasNameIncludesUnits = false;
      }
    public void setExclude(bool new_value)
      {
        flagHasExclude = true;
        storeExclude = new_value;
      }
    public void unsetExclude()
      {
        flagHasExclude = false;
      }
    public void setSpokenNoSize(string new_value)
      {
        flagHasSpokenNoSize = true;
        storeSpokenNoSize = new_value;
      }
    public void unsetSpokenNoSize()
      {
        flagHasSpokenNoSize = false;
      }
    public void setWrittenNoSize(string new_value)
      {
        flagHasWrittenNoSize = true;
        storeWrittenNoSize = new_value;
      }
    public void unsetWrittenNoSize()
      {
        flagHasWrittenNoSize = false;
      }
    public void setWikiUrl(string new_value)
      {
        flagHasWikiUrl = true;
        storeWikiUrl = new_value;
      }
    public void unsetWikiUrl()
      {
        flagHasWikiUrl = false;
      }
    public void setImageUrl(string new_value)
      {
        flagHasImageUrl = true;
        storeImageUrl = new_value;
      }
    public void unsetImageUrl()
      {
        flagHasImageUrl = false;
      }
    public void initAllSizes()
      {
        if (flagHasAllSizes)
          {
            for (int num1 = 0; num1 < storeAllSizes.Count; ++num1)
              {
              }
          }
        flagHasAllSizes = true;
        storeAllSizes.Clear();
      }
    public void appendAllSizes(FoodSizeJSON  to_append)
      {
        if (!flagHasAllSizes)
          {
            flagHasAllSizes = true;
            storeAllSizes.Clear();
          }
        Debug.Assert(flagHasAllSizes);
        storeAllSizes.Add(to_append);
      }
    public void unsetAllSizes()
      {
        if (flagHasAllSizes)
          {
            for (int num2 = 0; num2 < storeAllSizes.Count; ++num2)
              {
              }
          }
        flagHasAllSizes = false;
        storeAllSizes.Clear();
      }
    public void initNutrients()
      {
        if (flagHasNutrients)
          {
            for (int num3 = 0; num3 < storeNutrients.Count; ++num3)
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
            for (int num4 = 0; num4 < storeNutrients.Count; ++num4)
              {
              }
          }
        flagHasNutrients = false;
        storeNutrients.Clear();
      }
    public void setNutrientNameToID(JSONObjectValue  new_value)
      {
        if (flagHasNutrientNameToID)
          {
          }
        flagHasNutrientNameToID = true;
        storeNutrientNameToID = new_value;
      }
    public void unsetNutrientNameToID()
      {
        if (flagHasNutrientNameToID)
          {
          }
        flagHasNutrientNameToID = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasID);
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.number_value(storeID);
          }
        Debug.Assert(partial_allowed || flagHasQuantity);
        if (flagHasQuantity)
          {
            handler.start_pair("Quantity");
            if (textStoreQuantity != "")
                handler.number_value(textStoreQuantity);
            else if (((double)(long)storeQuantity) == storeQuantity)
                handler.number_value((long)storeQuantity);
            else
                handler.number_value(storeQuantity);
          }
        Debug.Assert(partial_allowed || flagHasNDB_No);
        if (flagHasNDB_No)
          {
            handler.start_pair("NDB_No");
            handler.string_value(storeNDB_No);
          }
        Debug.Assert(partial_allowed || flagHasSizeIndex);
        if (flagHasSizeIndex)
          {
            handler.start_pair("SizeIndex");
            handler.number_value(storeSizeIndex);
          }
        Debug.Assert(partial_allowed || flagHasNameIncludesUnits);
        if (flagHasNameIncludesUnits)
          {
            handler.start_pair("NameIncludesUnits");
            handler.boolean_value(storeNameIncludesUnits);
          }
        Debug.Assert(partial_allowed || flagHasExclude);
        if (flagHasExclude)
          {
            handler.start_pair("Exclude");
            handler.boolean_value(storeExclude);
          }
        Debug.Assert(partial_allowed || flagHasSpokenNoSize);
        if (flagHasSpokenNoSize)
          {
            handler.start_pair("SpokenNoSize");
            handler.string_value(storeSpokenNoSize);
          }
        Debug.Assert(partial_allowed || flagHasWrittenNoSize);
        if (flagHasWrittenNoSize)
          {
            handler.start_pair("WrittenNoSize");
            handler.string_value(storeWrittenNoSize);
          }
        Debug.Assert(partial_allowed || flagHasWikiUrl);
        if (flagHasWikiUrl)
          {
            handler.start_pair("WikiUrl");
            handler.string_value(storeWikiUrl);
          }
        Debug.Assert(partial_allowed || flagHasImageUrl);
        if (flagHasImageUrl)
          {
            handler.start_pair("ImageUrl");
            handler.string_value(storeImageUrl);
          }
        Debug.Assert(partial_allowed || flagHasAllSizes);
        if (flagHasAllSizes)
          {
            handler.start_pair("AllSizes");
            handler.start_array();
            for (int num1 = 0; num1 < storeAllSizes.Count; ++num1)
              {
                if (partial_allowed)
                    storeAllSizes[num1].write_partial_as_json(handler);
                else
                    storeAllSizes[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasNutrients);
        if (flagHasNutrients)
          {
            handler.start_pair("Nutrients");
            handler.start_array();
            for (int num2 = 0; num2 < storeNutrients.Count; ++num2)
              {
                if (partial_allowed)
                    storeNutrients[num2].write_partial_as_json(handler);
                else
                    storeNutrients[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasNutrientNameToID);
        if (flagHasNutrientNameToID)
          {
            handler.start_pair("NutrientNameToID");
            storeNutrientNameToID.write(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasID()))
          {
            return "When parsing the object for %what%, the \"ID\" field was missing.";
          }
        if (!(hasQuantity()))
          {
            return "When parsing the object for %what%, the \"Quantity\" field was missing.";
          }
        if (!(hasNDB_No()))
          {
            return "When parsing the object for %what%, the \"NDB_No\" field was missing.";
          }
        if (!(hasSizeIndex()))
          {
            return "When parsing the object for %what%, the \"SizeIndex\" field was missing.";
          }
        if (!(hasNameIncludesUnits()))
          {
            return "When parsing the object for %what%, the \"NameIncludesUnits\" field was missing.";
          }
        if (!(hasExclude()))
          {
            return "When parsing the object for %what%, the \"Exclude\" field was missing.";
          }
        if (!(hasSpokenNoSize()))
          {
            return "When parsing the object for %what%, the \"SpokenNoSize\" field was missing.";
          }
        if (!(hasWrittenNoSize()))
          {
            return "When parsing the object for %what%, the \"WrittenNoSize\" field was missing.";
          }
        if (!(hasWikiUrl()))
          {
            return "When parsing the object for %what%, the \"WikiUrl\" field was missing.";
          }
        if (!(hasImageUrl()))
          {
            return "When parsing the object for %what%, the \"ImageUrl\" field was missing.";
          }
        if (!(hasAllSizes()))
          {
            return "When parsing the object for %what%, the \"AllSizes\" field was missing.";
          }
        if (!(hasNutrients()))
          {
            return "When parsing the object for %what%, the \"Nutrients\" field was missing.";
          }
        if (!(hasNutrientNameToID()))
          {
            return "When parsing the object for %what%, the \"NutrientNameToID\" field was missing.";
          }
        return null;
      }

    public static FoodJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FoodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Food", ignore_extras);
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
    public static FoodJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FoodJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FoodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Food", ignore_extras);
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
    public static FoodJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FoodJSON from_text(string text, bool ignore_extras)
      {
        FoodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Food", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FoodJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FoodJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FoodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Food", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorID(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorID(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
        private FieldHoldingGeneratorID fieldGeneratorID;
        private JSONHoldingNumberTextGenerator fieldGeneratorQuantity;
        private JSONHoldingStringGenerator fieldGeneratorNDB_No;
    private class FieldHoldingGeneratorSizeIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSizeIndex(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSizeIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSizeIndex(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
        private FieldHoldingGeneratorSizeIndex fieldGeneratorSizeIndex;
        private JSONHoldingBooleanGenerator fieldGeneratorNameIncludesUnits;
        private JSONHoldingBooleanGenerator fieldGeneratorExclude;
        private JSONHoldingStringGenerator fieldGeneratorSpokenNoSize;
        private JSONHoldingStringGenerator fieldGeneratorWrittenNoSize;
        private JSONHoldingStringGenerator fieldGeneratorWikiUrl;
        private JSONHoldingStringGenerator fieldGeneratorImageUrl;
        private FoodSizeJSON.HoldingArrayGenerator fieldGeneratorAllSizes;
        private NutrientJSON.HoldingArrayGenerator fieldGeneratorNutrients;
        private JSONHoldingObjectValueGenerator fieldGeneratorNutrientNameToID;

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
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            FoodJSON result = new FoodJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(FoodJSON result)
          {
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            else if ((!(result.hasID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ID\" field was missing.");
              }
            if (fieldGeneratorQuantity.have_value)
              {
                result.setQuantityText(fieldGeneratorQuantity.value);
                fieldGeneratorQuantity.have_value = false;
              }
            else if ((!(result.hasQuantity())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Quantity\" field was missing.");
              }
            if (fieldGeneratorNDB_No.have_value)
              {
                result.setNDB_No(fieldGeneratorNDB_No.value);
                fieldGeneratorNDB_No.have_value = false;
              }
            else if ((!(result.hasNDB_No())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NDB_No\" field was missing.");
              }
            if (fieldGeneratorSizeIndex.have_value)
              {
                result.setSizeIndex(fieldGeneratorSizeIndex.value);
                fieldGeneratorSizeIndex.have_value = false;
              }
            else if ((!(result.hasSizeIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SizeIndex\" field was missing.");
              }
            if (fieldGeneratorNameIncludesUnits.have_value)
              {
                result.setNameIncludesUnits(fieldGeneratorNameIncludesUnits.value);
                fieldGeneratorNameIncludesUnits.have_value = false;
              }
            else if ((!(result.hasNameIncludesUnits())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NameIncludesUnits\" field was missing.");
              }
            if (fieldGeneratorExclude.have_value)
              {
                result.setExclude(fieldGeneratorExclude.value);
                fieldGeneratorExclude.have_value = false;
              }
            else if ((!(result.hasExclude())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Exclude\" field was missing.");
              }
            if (fieldGeneratorSpokenNoSize.have_value)
              {
                result.setSpokenNoSize(fieldGeneratorSpokenNoSize.value);
                fieldGeneratorSpokenNoSize.have_value = false;
              }
            else if ((!(result.hasSpokenNoSize())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenNoSize\" field was missing.");
              }
            if (fieldGeneratorWrittenNoSize.have_value)
              {
                result.setWrittenNoSize(fieldGeneratorWrittenNoSize.value);
                fieldGeneratorWrittenNoSize.have_value = false;
              }
            else if ((!(result.hasWrittenNoSize())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenNoSize\" field was missing.");
              }
            if (fieldGeneratorWikiUrl.have_value)
              {
                result.setWikiUrl(fieldGeneratorWikiUrl.value);
                fieldGeneratorWikiUrl.have_value = false;
              }
            else if ((!(result.hasWikiUrl())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WikiUrl\" field was missing.");
              }
            if (fieldGeneratorImageUrl.have_value)
              {
                result.setImageUrl(fieldGeneratorImageUrl.value);
                fieldGeneratorImageUrl.have_value = false;
              }
            else if ((!(result.hasImageUrl())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ImageUrl\" field was missing.");
              }
            if (fieldGeneratorAllSizes.have_value)
              {
                result.initAllSizes();
                int count = fieldGeneratorAllSizes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAllSizes(fieldGeneratorAllSizes.value[num]);
                  }
                fieldGeneratorAllSizes.value.Clear();
                fieldGeneratorAllSizes.have_value = false;
              }
            else if ((!(result.hasAllSizes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AllSizes\" field was missing.");
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
            if (fieldGeneratorNutrientNameToID.have_value)
              {
                result.setNutrientNameToID(fieldGeneratorNutrientNameToID.value);
                fieldGeneratorNutrientNameToID.have_value = false;
              }
            else if ((!(result.hasNutrientNameToID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NutrientNameToID\" field was missing.");
              }
          }
        protected abstract void handle_result(FoodJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "llSizes", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorAllSizes;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xclude", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorExclude;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'D':
                            if (field_name.Length == 2)
                                return fieldGeneratorID;
                            break;
                        case 'm':
                            if ((String.Compare(field_name, 2, "ageUrl", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorImageUrl;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    switch (field_name[1])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 2, "B_No", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorNDB_No;
                            break;
                        case 'a':
                            if ((String.Compare(field_name, 2, "meIncludesUnits", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorNameIncludesUnits;
                            break;
                        case 'u':
                            if (String.Compare(field_name, 2, "trient", 0, 6, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'N':
                                        if ((String.Compare(field_name, 9, "ameToID", 0, 7, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorNutrientNameToID;
                                        break;
                                    case 's':
                                        if (field_name.Length == 9)
                                            return fieldGeneratorNutrients;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uantity", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorQuantity;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "zeIndex", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorSizeIndex;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenNoSize", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorSpokenNoSize;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "kiUrl", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorWikiUrl;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "ittenNoSize", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorWrittenNoSize;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the Food class");
            fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the Food class");
            fieldGeneratorNDB_No = new JSONHoldingStringGenerator("field \"NDB_No\" of the Food class");
            fieldGeneratorSizeIndex = new FieldHoldingGeneratorSizeIndex("field \"SizeIndex\" of the Food class");
            fieldGeneratorNameIncludesUnits = new JSONHoldingBooleanGenerator("field \"NameIncludesUnits\" of the Food class");
            fieldGeneratorExclude = new JSONHoldingBooleanGenerator("field \"Exclude\" of the Food class");
            fieldGeneratorSpokenNoSize = new JSONHoldingStringGenerator("field \"SpokenNoSize\" of the Food class");
            fieldGeneratorWrittenNoSize = new JSONHoldingStringGenerator("field \"WrittenNoSize\" of the Food class");
            fieldGeneratorWikiUrl = new JSONHoldingStringGenerator("field \"WikiUrl\" of the Food class");
            fieldGeneratorImageUrl = new JSONHoldingStringGenerator("field \"ImageUrl\" of the Food class");
            fieldGeneratorAllSizes = new FoodSizeJSON.HoldingArrayGenerator("field \"AllSizes\" of the Food class", ignore_extras);
            fieldGeneratorNutrients = new NutrientJSON.HoldingArrayGenerator("field \"Nutrients\" of the Food class", ignore_extras);
            fieldGeneratorNutrientNameToID = new JSONHoldingObjectValueGenerator("field \"NutrientNameToID\" of the Food class");
            set_what("the Food class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the Food class");
            fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the Food class");
            fieldGeneratorNDB_No = new JSONHoldingStringGenerator("field \"NDB_No\" of the Food class");
            fieldGeneratorSizeIndex = new FieldHoldingGeneratorSizeIndex("field \"SizeIndex\" of the Food class");
            fieldGeneratorNameIncludesUnits = new JSONHoldingBooleanGenerator("field \"NameIncludesUnits\" of the Food class");
            fieldGeneratorExclude = new JSONHoldingBooleanGenerator("field \"Exclude\" of the Food class");
            fieldGeneratorSpokenNoSize = new JSONHoldingStringGenerator("field \"SpokenNoSize\" of the Food class");
            fieldGeneratorWrittenNoSize = new JSONHoldingStringGenerator("field \"WrittenNoSize\" of the Food class");
            fieldGeneratorWikiUrl = new JSONHoldingStringGenerator("field \"WikiUrl\" of the Food class");
            fieldGeneratorImageUrl = new JSONHoldingStringGenerator("field \"ImageUrl\" of the Food class");
            fieldGeneratorAllSizes = new FoodSizeJSON.HoldingArrayGenerator("field \"AllSizes\" of the Food class", false);
            fieldGeneratorNutrients = new NutrientJSON.HoldingArrayGenerator("field \"Nutrients\" of the Food class", false);
            fieldGeneratorNutrientNameToID = new JSONHoldingObjectValueGenerator("field \"NutrientNameToID\" of the Food class");
            set_what("the Food class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorID.reset();
            fieldGeneratorQuantity.reset();
            fieldGeneratorNDB_No.reset();
            fieldGeneratorSizeIndex.reset();
            fieldGeneratorNameIncludesUnits.reset();
            fieldGeneratorExclude.reset();
            fieldGeneratorSpokenNoSize.reset();
            fieldGeneratorWrittenNoSize.reset();
            fieldGeneratorWikiUrl.reset();
            fieldGeneratorImageUrl.reset();
            fieldGeneratorAllSizes.reset();
            fieldGeneratorNutrients.reset();
            fieldGeneratorNutrientNameToID.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAllSizes.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNutrients.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAllSizes.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNutrients.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FoodJSON  result)
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
        public FoodJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FoodJSON  result)
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
    protected virtual void handle_result(List<FoodJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FoodJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FoodJSON>();
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
    public List<FoodJSON> value;
  };
  };
