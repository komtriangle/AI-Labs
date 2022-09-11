/* file "RiverJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RiverJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasAuxiliaryID;
    private BigInteger storeAuxiliaryID;
    private bool flagHasLength;
    private BigInteger storeLength;
    private bool flagHasDischarge;
    private double storeDischarge;
    private string textStoreDischarge;
    private bool flagHasCities;
    private List< RiverLocationJSON  > storeCities;
    private bool flagHasUsStates;
    private List< RiverLocationJSON  > storeUsStates;
    private bool flagHasCountries;
    private List< RiverLocationJSON  > storeCountries;
    private bool flagHasContinents;
    private List< RiverLocationJSON  > storeContinents;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of RiverJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONAuxiliaryID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AuxiliaryID of RiverJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AuxiliaryID of RiverJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAuxiliaryID(extracted_integer);
      }


    private void  fromJSONLength(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Length of RiverJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Length of RiverJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setLength(extracted_integer);
      }


    private void  fromJSONDischarge(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Discharge of RiverJSON is not a number.");
              }
          }
        setDischargeText(the_rational_text);
      }


    private void  fromJSONCities(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Cities of RiverJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Cities of RiverJSON has too few elements.");
        List< RiverLocationJSON  > vector_Cities1 = new List< RiverLocationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RiverLocationJSON convert_classy = RiverLocationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Cities1.Add(convert_classy);
          }
        Debug.Assert(vector_Cities1.Count >= 1);
        initCities();
        for (int num1 = 0; num1 < vector_Cities1.Count; ++num1)
            appendCities(vector_Cities1[num1]);
        for (int num1 = 0; num1 < vector_Cities1.Count; ++num1)
          {
          }
      }


    private void  fromJSONUsStates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field UsStates of RiverJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field UsStates of RiverJSON has too few elements.");
        List< RiverLocationJSON  > vector_UsStates1 = new List< RiverLocationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RiverLocationJSON convert_classy = RiverLocationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_UsStates1.Add(convert_classy);
          }
        Debug.Assert(vector_UsStates1.Count >= 1);
        initUsStates();
        for (int num2 = 0; num2 < vector_UsStates1.Count; ++num2)
            appendUsStates(vector_UsStates1[num2]);
        for (int num1 = 0; num1 < vector_UsStates1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCountries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Countries of RiverJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Countries of RiverJSON has too few elements.");
        List< RiverLocationJSON  > vector_Countries1 = new List< RiverLocationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RiverLocationJSON convert_classy = RiverLocationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Countries1.Add(convert_classy);
          }
        Debug.Assert(vector_Countries1.Count >= 1);
        initCountries();
        for (int num3 = 0; num3 < vector_Countries1.Count; ++num3)
            appendCountries(vector_Countries1[num3]);
        for (int num1 = 0; num1 < vector_Countries1.Count; ++num1)
          {
          }
      }


    private void  fromJSONContinents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Continents of RiverJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Continents of RiverJSON has too few elements.");
        List< RiverLocationJSON  > vector_Continents1 = new List< RiverLocationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RiverLocationJSON convert_classy = RiverLocationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Continents1.Add(convert_classy);
          }
        Debug.Assert(vector_Continents1.Count >= 1);
        initContinents();
        for (int num4 = 0; num4 < vector_Continents1.Count; ++num4)
            appendContinents(vector_Continents1[num4]);
        for (int num1 = 0; num1 < vector_Continents1.Count; ++num1)
          {
          }
      }


    public RiverJSON()
      {
        flagHasName = false;
        flagHasAuxiliaryID = false;
        flagHasLength = false;
        flagHasDischarge = false;
        flagHasCities = false;
        flagHasUsStates = false;
        flagHasCountries = false;
        flagHasContinents = false;
        storeCities = new List< RiverLocationJSON  >();
        storeUsStates = new List< RiverLocationJSON  >();
        storeCountries = new List< RiverLocationJSON  >();
        storeContinents = new List< RiverLocationJSON  >();
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

    public bool  hasAuxiliaryID()
      {
        return flagHasAuxiliaryID;
      }

    public BigInteger  getAuxiliaryID()
      {
        Debug.Assert(flagHasAuxiliaryID);
        return storeAuxiliaryID;
      }

    public bool  hasLength()
      {
        return flagHasLength;
      }

    public BigInteger  getLength()
      {
        Debug.Assert(flagHasLength);
        return storeLength;
      }

    public bool  hasDischarge()
      {
        return flagHasDischarge;
      }

    public double  getDischarge()
      {
        Debug.Assert(flagHasDischarge);
        if (textStoreDischarge != "")
          {
            return Double.Parse(textStoreDischarge);
          }
        return storeDischarge;
      }

    public string  getDischargeAsText()
      {
        Debug.Assert(flagHasDischarge);
        if (textStoreDischarge == "")
          {
            return Convert.ToString(storeDischarge);
          }
        else
          {
            return (textStoreDischarge);
          }
      }

    public bool  hasCities()
      {
        return flagHasCities;
      }

    public int  countOfCities()
      {
        Debug.Assert(flagHasCities);
        return storeCities.Count;
      }

    public RiverLocationJSON   elementOfCities(int element_num)
      {
        Debug.Assert(flagHasCities);
        return storeCities[element_num];
      }

    public List< RiverLocationJSON  >  getCities()
      {
        Debug.Assert(flagHasCities);
        return storeCities;
      }

    public bool  hasUsStates()
      {
        return flagHasUsStates;
      }

    public int  countOfUsStates()
      {
        Debug.Assert(flagHasUsStates);
        return storeUsStates.Count;
      }

    public RiverLocationJSON   elementOfUsStates(int element_num)
      {
        Debug.Assert(flagHasUsStates);
        return storeUsStates[element_num];
      }

    public List< RiverLocationJSON  >  getUsStates()
      {
        Debug.Assert(flagHasUsStates);
        return storeUsStates;
      }

    public bool  hasCountries()
      {
        return flagHasCountries;
      }

    public int  countOfCountries()
      {
        Debug.Assert(flagHasCountries);
        return storeCountries.Count;
      }

    public RiverLocationJSON   elementOfCountries(int element_num)
      {
        Debug.Assert(flagHasCountries);
        return storeCountries[element_num];
      }

    public List< RiverLocationJSON  >  getCountries()
      {
        Debug.Assert(flagHasCountries);
        return storeCountries;
      }

    public bool  hasContinents()
      {
        return flagHasContinents;
      }

    public int  countOfContinents()
      {
        Debug.Assert(flagHasContinents);
        return storeContinents.Count;
      }

    public RiverLocationJSON   elementOfContinents(int element_num)
      {
        Debug.Assert(flagHasContinents);
        return storeContinents[element_num];
      }

    public List< RiverLocationJSON  >  getContinents()
      {
        Debug.Assert(flagHasContinents);
        return storeContinents;
      }


    public virtual int extraRiverComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRiverComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRiverComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRiverLookup(string field_name)
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
    public void setAuxiliaryID(BigInteger new_value)
      {
        flagHasAuxiliaryID = true;
        if (new_value < 0)
            throw new Exception("The value for field AuxiliaryID of RiverJSON is less than the lower bound (0) for that field.");
        storeAuxiliaryID = new_value;
      }
    public void unsetAuxiliaryID()
      {
        flagHasAuxiliaryID = false;
      }
    public void setLength(BigInteger new_value)
      {
        flagHasLength = true;
        if (new_value < 0)
            throw new Exception("The value for field Length of RiverJSON is less than the lower bound (0) for that field.");
        storeLength = new_value;
      }
    public void unsetLength()
      {
        flagHasLength = false;
      }
    public void setDischarge(double new_value)
      {
        flagHasDischarge = true;
        if (new_value < 0)
            throw new Exception("The value for field Discharge of RiverJSON is less than the lower bound (0) for that field.");
        storeDischarge = new_value;
        textStoreDischarge = "";
      }
    public void setDischargeText(string new_value)
      {
        flagHasDischarge = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Discharge of RiverJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Discharge of RiverJSON is less than the lower bound (0) for that field.");
        textStoreDischarge = new_value;
      }
    public void unsetDischarge()
      {
        flagHasDischarge = false;
      }
    public void initCities()
      {
        if (flagHasCities)
          {
            for (int num1 = 0; num1 < storeCities.Count; ++num1)
              {
              }
          }
        flagHasCities = true;
        storeCities.Clear();
      }
    public void appendCities(RiverLocationJSON  to_append)
      {
        if (!flagHasCities)
          {
            flagHasCities = true;
            storeCities.Clear();
          }
        Debug.Assert(flagHasCities);
        storeCities.Add(to_append);
      }
    public void unsetCities()
      {
        if (flagHasCities)
          {
            for (int num2 = 0; num2 < storeCities.Count; ++num2)
              {
              }
          }
        flagHasCities = false;
        storeCities.Clear();
      }
    public void initUsStates()
      {
        if (flagHasUsStates)
          {
            for (int num3 = 0; num3 < storeUsStates.Count; ++num3)
              {
              }
          }
        flagHasUsStates = true;
        storeUsStates.Clear();
      }
    public void appendUsStates(RiverLocationJSON  to_append)
      {
        if (!flagHasUsStates)
          {
            flagHasUsStates = true;
            storeUsStates.Clear();
          }
        Debug.Assert(flagHasUsStates);
        storeUsStates.Add(to_append);
      }
    public void unsetUsStates()
      {
        if (flagHasUsStates)
          {
            for (int num4 = 0; num4 < storeUsStates.Count; ++num4)
              {
              }
          }
        flagHasUsStates = false;
        storeUsStates.Clear();
      }
    public void initCountries()
      {
        if (flagHasCountries)
          {
            for (int num5 = 0; num5 < storeCountries.Count; ++num5)
              {
              }
          }
        flagHasCountries = true;
        storeCountries.Clear();
      }
    public void appendCountries(RiverLocationJSON  to_append)
      {
        if (!flagHasCountries)
          {
            flagHasCountries = true;
            storeCountries.Clear();
          }
        Debug.Assert(flagHasCountries);
        storeCountries.Add(to_append);
      }
    public void unsetCountries()
      {
        if (flagHasCountries)
          {
            for (int num6 = 0; num6 < storeCountries.Count; ++num6)
              {
              }
          }
        flagHasCountries = false;
        storeCountries.Clear();
      }
    public void initContinents()
      {
        if (flagHasContinents)
          {
            for (int num7 = 0; num7 < storeContinents.Count; ++num7)
              {
              }
          }
        flagHasContinents = true;
        storeContinents.Clear();
      }
    public void appendContinents(RiverLocationJSON  to_append)
      {
        if (!flagHasContinents)
          {
            flagHasContinents = true;
            storeContinents.Clear();
          }
        Debug.Assert(flagHasContinents);
        storeContinents.Add(to_append);
      }
    public void unsetContinents()
      {
        if (flagHasContinents)
          {
            for (int num8 = 0; num8 < storeContinents.Count; ++num8)
              {
              }
          }
        flagHasContinents = false;
        storeContinents.Clear();
      }

    public virtual void extraRiverAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRiverSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRiverLookup(key);
        if (old_field == null)
          {
            extraRiverAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAuxiliaryID);
        if (flagHasAuxiliaryID)
          {
            handler.start_pair("AuxiliaryID");
            handler.number_value(storeAuxiliaryID);
          }
        Debug.Assert(partial_allowed || flagHasLength);
        if (flagHasLength)
          {
            handler.start_pair("Length");
            handler.number_value(storeLength);
          }
        if (flagHasDischarge)
          {
            handler.start_pair("Discharge");
            if (textStoreDischarge != "")
                handler.number_value(textStoreDischarge);
            else if (((double)(long)storeDischarge) == storeDischarge)
                handler.number_value((long)storeDischarge);
            else
                handler.number_value(storeDischarge);
          }
        if (flagHasCities)
          {
            handler.start_pair("Cities");
            Debug.Assert(storeCities.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeCities.Count; ++num1)
              {
                if (partial_allowed)
                    storeCities[num1].write_partial_as_json(handler);
                else
                    storeCities[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasUsStates)
          {
            handler.start_pair("UsStates");
            Debug.Assert(storeUsStates.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeUsStates.Count; ++num2)
              {
                if (partial_allowed)
                    storeUsStates[num2].write_partial_as_json(handler);
                else
                    storeUsStates[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasCountries);
        if (flagHasCountries)
          {
            handler.start_pair("Countries");
            Debug.Assert(storeCountries.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeCountries.Count; ++num3)
              {
                if (partial_allowed)
                    storeCountries[num3].write_partial_as_json(handler);
                else
                    storeCountries[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasContinents);
        if (flagHasContinents)
          {
            handler.start_pair("Continents");
            Debug.Assert(storeContinents.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeContinents.Count; ++num4)
              {
                if (partial_allowed)
                    storeContinents[num4].write_partial_as_json(handler);
                else
                    storeContinents[num4].write_as_json(handler);
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
        if (!(hasAuxiliaryID()))
          {
            return "When parsing the object for %what%, the \"AuxiliaryID\" field was missing.";
          }
        if (!(hasLength()))
          {
            return "When parsing the object for %what%, the \"Length\" field was missing.";
          }
        if (!(hasCountries()))
          {
            return "When parsing the object for %what%, the \"Countries\" field was missing.";
          }
        if (!(hasContinents()))
          {
            return "When parsing the object for %what%, the \"Continents\" field was missing.";
          }
        return null;
      }

    public static RiverJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type River", ignore_extras);
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
    public static RiverJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RiverJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type River", ignore_extras);
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
    public static RiverJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RiverJSON from_text(string text, bool ignore_extras)
      {
        RiverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type River", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RiverJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RiverJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RiverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type River", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
    private class FieldHoldingGeneratorAuxiliaryID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorAuxiliaryID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorAuxiliaryID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorAuxiliaryID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorAuxiliaryID fieldGeneratorAuxiliaryID;
    private class FieldHoldingGeneratorLength : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorLength(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorLength : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorLength(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorLength fieldGeneratorLength;
        private JSONHoldingNumberTextGenerator fieldGeneratorDischarge;
        private RiverLocationJSON.HoldingArrayGenerator fieldGeneratorCities;
        private RiverLocationJSON.HoldingArrayGenerator fieldGeneratorUsStates;
        private RiverLocationJSON.HoldingArrayGenerator fieldGeneratorCountries;
        private RiverLocationJSON.HoldingArrayGenerator fieldGeneratorContinents;
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
            RiverJSON result = new RiverJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRiverAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RiverJSON result)
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
            if (fieldGeneratorAuxiliaryID.have_value)
              {
                result.setAuxiliaryID(fieldGeneratorAuxiliaryID.value);
                fieldGeneratorAuxiliaryID.have_value = false;
              }
            else if ((!(result.hasAuxiliaryID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AuxiliaryID\" field was missing.");
              }
            if (fieldGeneratorLength.have_value)
              {
                result.setLength(fieldGeneratorLength.value);
                fieldGeneratorLength.have_value = false;
              }
            else if ((!(result.hasLength())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Length\" field was missing.");
              }
            if (fieldGeneratorDischarge.have_value)
              {
                result.setDischargeText(fieldGeneratorDischarge.value);
                fieldGeneratorDischarge.have_value = false;
              }
            if (fieldGeneratorCities.have_value)
              {
                result.initCities();
                int count = fieldGeneratorCities.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCities(fieldGeneratorCities.value[num]);
                  }
                fieldGeneratorCities.value.Clear();
                fieldGeneratorCities.have_value = false;
              }
            if (fieldGeneratorUsStates.have_value)
              {
                result.initUsStates();
                int count = fieldGeneratorUsStates.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendUsStates(fieldGeneratorUsStates.value[num]);
                  }
                fieldGeneratorUsStates.value.Clear();
                fieldGeneratorUsStates.have_value = false;
              }
            if (fieldGeneratorCountries.have_value)
              {
                result.initCountries();
                int count = fieldGeneratorCountries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCountries(fieldGeneratorCountries.value[num]);
                  }
                fieldGeneratorCountries.value.Clear();
                fieldGeneratorCountries.have_value = false;
              }
            else if ((!(result.hasCountries())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Countries\" field was missing.");
              }
            if (fieldGeneratorContinents.have_value)
              {
                result.initContinents();
                int count = fieldGeneratorContinents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendContinents(fieldGeneratorContinents.value[num]);
                  }
                fieldGeneratorContinents.value.Clear();
                fieldGeneratorContinents.have_value = false;
              }
            else if ((!(result.hasContinents())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Continents\" field was missing.");
              }
          }
        protected abstract void handle_result(RiverJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "uxiliaryID", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAuxiliaryID;
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "ties", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorCities;
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'n':
                                    if ((String.Compare(field_name, 3, "tinents", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorContinents;
                                    break;
                                case 'u':
                                    if ((String.Compare(field_name, 3, "ntries", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorCountries;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ischarge", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDischarge;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ength", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorLength;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "sStates", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorUsStates;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the River class");
            fieldGeneratorAuxiliaryID = new FieldHoldingGeneratorAuxiliaryID("field \"AuxiliaryID\" of the River class");
            fieldGeneratorLength = new FieldHoldingGeneratorLength("field \"Length\" of the River class");
            fieldGeneratorDischarge = new JSONHoldingNumberTextGenerator("field \"Discharge\" of the River class");
            fieldGeneratorCities = new RiverLocationJSON.HoldingArrayGenerator("field \"Cities\" of the River class", ignore_extras);
            fieldGeneratorUsStates = new RiverLocationJSON.HoldingArrayGenerator("field \"UsStates\" of the River class", ignore_extras);
            fieldGeneratorCountries = new RiverLocationJSON.HoldingArrayGenerator("field \"Countries\" of the River class", ignore_extras);
            fieldGeneratorContinents = new RiverLocationJSON.HoldingArrayGenerator("field \"Continents\" of the River class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the River class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the River class");
            fieldGeneratorAuxiliaryID = new FieldHoldingGeneratorAuxiliaryID("field \"AuxiliaryID\" of the River class");
            fieldGeneratorLength = new FieldHoldingGeneratorLength("field \"Length\" of the River class");
            fieldGeneratorDischarge = new JSONHoldingNumberTextGenerator("field \"Discharge\" of the River class");
            fieldGeneratorCities = new RiverLocationJSON.HoldingArrayGenerator("field \"Cities\" of the River class", false);
            fieldGeneratorUsStates = new RiverLocationJSON.HoldingArrayGenerator("field \"UsStates\" of the River class", false);
            fieldGeneratorCountries = new RiverLocationJSON.HoldingArrayGenerator("field \"Countries\" of the River class", false);
            fieldGeneratorContinents = new RiverLocationJSON.HoldingArrayGenerator("field \"Continents\" of the River class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the River class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorAuxiliaryID.reset();
            fieldGeneratorLength.reset();
            fieldGeneratorDischarge.reset();
            fieldGeneratorCities.reset();
            fieldGeneratorUsStates.reset();
            fieldGeneratorCountries.reset();
            fieldGeneratorContinents.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCities.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUsStates.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCountries.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorContinents.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCities.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUsStates.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCountries.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorContinents.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RiverJSON  result)
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
        public RiverJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RiverJSON  result)
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
    protected virtual void handle_result(List<RiverJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RiverJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RiverJSON>();
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
    public List<RiverJSON> value;
  };
  };
