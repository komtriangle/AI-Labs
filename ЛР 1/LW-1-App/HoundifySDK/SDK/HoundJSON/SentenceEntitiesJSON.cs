/* file "SentenceEntitiesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SentenceEntitiesJSON : JSONBase
  {
    private bool flagHasWho;
    private List< WhoJSON  > storeWho;
    private bool flagHasSpecialPersonIndex;
    private BigInteger storeSpecialPersonIndex;
    private bool flagHasWhen;
    private List< WhenJSON  > storeWhen;
    private bool flagHasSpecialTimeIndex;
    private BigInteger storeSpecialTimeIndex;
    private bool flagHasWhere;
    private List< MapLocationJSON  > storeWhere;
    private bool flagHasSpecialPlaceIndex;
    private BigInteger storeSpecialPlaceIndex;
    private bool flagHasHowMuch;
    private List< AmountJSON  > storeHowMuch;
    private bool flagHasSpecialAmountIndex;
    private BigInteger storeSpecialAmountIndex;
    private bool flagHasWhatWord;
    private List< WhatWordJSON  > storeWhatWord;
    private bool flagHasSpecialWhatWordIndex;
    private BigInteger storeSpecialWhatWordIndex;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONWho(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Who of SentenceEntitiesJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Who of SentenceEntitiesJSON has too few elements.");
        List< WhoJSON  > vector_Who1 = new List< WhoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            WhoJSON convert_classy = WhoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Who1.Add(convert_classy);
          }
        Debug.Assert(vector_Who1.Count >= 1);
        initWho();
        for (int num1 = 0; num1 < vector_Who1.Count; ++num1)
            appendWho(vector_Who1[num1]);
        for (int num1 = 0; num1 < vector_Who1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpecialPersonIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SpecialPersonIndex of SentenceEntitiesJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SpecialPersonIndex of SentenceEntitiesJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSpecialPersonIndex(extracted_integer);
      }


    private void  fromJSONWhen(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field When of SentenceEntitiesJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field When of SentenceEntitiesJSON has too few elements.");
        List< WhenJSON  > vector_When1 = new List< WhenJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            WhenJSON convert_classy = WhenJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_When1.Add(convert_classy);
          }
        Debug.Assert(vector_When1.Count >= 1);
        initWhen();
        for (int num2 = 0; num2 < vector_When1.Count; ++num2)
            appendWhen(vector_When1[num2]);
        for (int num1 = 0; num1 < vector_When1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpecialTimeIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SpecialTimeIndex of SentenceEntitiesJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SpecialTimeIndex of SentenceEntitiesJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSpecialTimeIndex(extracted_integer);
      }


    private void  fromJSONWhere(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Where of SentenceEntitiesJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Where of SentenceEntitiesJSON has too few elements.");
        List< MapLocationJSON  > vector_Where1 = new List< MapLocationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MapLocationJSON convert_classy = MapLocationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Where1.Add(convert_classy);
          }
        Debug.Assert(vector_Where1.Count >= 1);
        initWhere();
        for (int num3 = 0; num3 < vector_Where1.Count; ++num3)
            appendWhere(vector_Where1[num3]);
        for (int num1 = 0; num1 < vector_Where1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpecialPlaceIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SpecialPlaceIndex of SentenceEntitiesJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SpecialPlaceIndex of SentenceEntitiesJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSpecialPlaceIndex(extracted_integer);
      }


    private void  fromJSONHowMuch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HowMuch of SentenceEntitiesJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field HowMuch of SentenceEntitiesJSON has too few elements.");
        List< AmountJSON  > vector_HowMuch1 = new List< AmountJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AmountJSON convert_classy = AmountJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_HowMuch1.Add(convert_classy);
          }
        Debug.Assert(vector_HowMuch1.Count >= 1);
        initHowMuch();
        for (int num4 = 0; num4 < vector_HowMuch1.Count; ++num4)
            appendHowMuch(vector_HowMuch1[num4]);
        for (int num1 = 0; num1 < vector_HowMuch1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpecialAmountIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SpecialAmountIndex of SentenceEntitiesJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SpecialAmountIndex of SentenceEntitiesJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSpecialAmountIndex(extracted_integer);
      }


    private void  fromJSONWhatWord(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field WhatWord of SentenceEntitiesJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field WhatWord of SentenceEntitiesJSON has too few elements.");
        List< WhatWordJSON  > vector_WhatWord1 = new List< WhatWordJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            WhatWordJSON convert_classy = WhatWordJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_WhatWord1.Add(convert_classy);
          }
        Debug.Assert(vector_WhatWord1.Count >= 1);
        initWhatWord();
        for (int num5 = 0; num5 < vector_WhatWord1.Count; ++num5)
            appendWhatWord(vector_WhatWord1[num5]);
        for (int num1 = 0; num1 < vector_WhatWord1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpecialWhatWordIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SpecialWhatWordIndex of SentenceEntitiesJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SpecialWhatWordIndex of SentenceEntitiesJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSpecialWhatWordIndex(extracted_integer);
      }


    public SentenceEntitiesJSON()
      {
        flagHasWho = false;
        flagHasSpecialPersonIndex = false;
        flagHasWhen = false;
        flagHasSpecialTimeIndex = false;
        flagHasWhere = false;
        flagHasSpecialPlaceIndex = false;
        flagHasHowMuch = false;
        flagHasSpecialAmountIndex = false;
        flagHasWhatWord = false;
        flagHasSpecialWhatWordIndex = false;
        storeWho = new List< WhoJSON  >();
        storeWhen = new List< WhenJSON  >();
        storeWhere = new List< MapLocationJSON  >();
        storeHowMuch = new List< AmountJSON  >();
        storeWhatWord = new List< WhatWordJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasWho()
      {
        return flagHasWho;
      }

    public int  countOfWho()
      {
        Debug.Assert(flagHasWho);
        return storeWho.Count;
      }

    public WhoJSON   elementOfWho(int element_num)
      {
        Debug.Assert(flagHasWho);
        return storeWho[element_num];
      }

    public List< WhoJSON  >  getWho()
      {
        Debug.Assert(flagHasWho);
        return storeWho;
      }

    public bool  hasSpecialPersonIndex()
      {
        return flagHasSpecialPersonIndex;
      }

    public BigInteger  getSpecialPersonIndex()
      {
        Debug.Assert(flagHasSpecialPersonIndex);
        return storeSpecialPersonIndex;
      }

    public bool  hasWhen()
      {
        return flagHasWhen;
      }

    public int  countOfWhen()
      {
        Debug.Assert(flagHasWhen);
        return storeWhen.Count;
      }

    public WhenJSON   elementOfWhen(int element_num)
      {
        Debug.Assert(flagHasWhen);
        return storeWhen[element_num];
      }

    public List< WhenJSON  >  getWhen()
      {
        Debug.Assert(flagHasWhen);
        return storeWhen;
      }

    public bool  hasSpecialTimeIndex()
      {
        return flagHasSpecialTimeIndex;
      }

    public BigInteger  getSpecialTimeIndex()
      {
        Debug.Assert(flagHasSpecialTimeIndex);
        return storeSpecialTimeIndex;
      }

    public bool  hasWhere()
      {
        return flagHasWhere;
      }

    public int  countOfWhere()
      {
        Debug.Assert(flagHasWhere);
        return storeWhere.Count;
      }

    public MapLocationJSON   elementOfWhere(int element_num)
      {
        Debug.Assert(flagHasWhere);
        return storeWhere[element_num];
      }

    public List< MapLocationJSON  >  getWhere()
      {
        Debug.Assert(flagHasWhere);
        return storeWhere;
      }

    public bool  hasSpecialPlaceIndex()
      {
        return flagHasSpecialPlaceIndex;
      }

    public BigInteger  getSpecialPlaceIndex()
      {
        Debug.Assert(flagHasSpecialPlaceIndex);
        return storeSpecialPlaceIndex;
      }

    public bool  hasHowMuch()
      {
        return flagHasHowMuch;
      }

    public int  countOfHowMuch()
      {
        Debug.Assert(flagHasHowMuch);
        return storeHowMuch.Count;
      }

    public AmountJSON   elementOfHowMuch(int element_num)
      {
        Debug.Assert(flagHasHowMuch);
        return storeHowMuch[element_num];
      }

    public List< AmountJSON  >  getHowMuch()
      {
        Debug.Assert(flagHasHowMuch);
        return storeHowMuch;
      }

    public bool  hasSpecialAmountIndex()
      {
        return flagHasSpecialAmountIndex;
      }

    public BigInteger  getSpecialAmountIndex()
      {
        Debug.Assert(flagHasSpecialAmountIndex);
        return storeSpecialAmountIndex;
      }

    public bool  hasWhatWord()
      {
        return flagHasWhatWord;
      }

    public int  countOfWhatWord()
      {
        Debug.Assert(flagHasWhatWord);
        return storeWhatWord.Count;
      }

    public WhatWordJSON   elementOfWhatWord(int element_num)
      {
        Debug.Assert(flagHasWhatWord);
        return storeWhatWord[element_num];
      }

    public List< WhatWordJSON  >  getWhatWord()
      {
        Debug.Assert(flagHasWhatWord);
        return storeWhatWord;
      }

    public bool  hasSpecialWhatWordIndex()
      {
        return flagHasSpecialWhatWordIndex;
      }

    public BigInteger  getSpecialWhatWordIndex()
      {
        Debug.Assert(flagHasSpecialWhatWordIndex);
        return storeSpecialWhatWordIndex;
      }


    public virtual int extraSentenceEntitiesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSentenceEntitiesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSentenceEntitiesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSentenceEntitiesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initWho()
      {
        if (flagHasWho)
          {
            for (int num1 = 0; num1 < storeWho.Count; ++num1)
              {
              }
          }
        flagHasWho = true;
        storeWho.Clear();
      }
    public void appendWho(WhoJSON  to_append)
      {
        if (!flagHasWho)
          {
            flagHasWho = true;
            storeWho.Clear();
          }
        Debug.Assert(flagHasWho);
        storeWho.Add(to_append);
      }
    public void unsetWho()
      {
        if (flagHasWho)
          {
            for (int num2 = 0; num2 < storeWho.Count; ++num2)
              {
              }
          }
        flagHasWho = false;
        storeWho.Clear();
      }
    public void setSpecialPersonIndex(BigInteger new_value)
      {
        flagHasSpecialPersonIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field SpecialPersonIndex of SentenceEntitiesJSON is less than the lower bound (0) for that field.");
        storeSpecialPersonIndex = new_value;
      }
    public void unsetSpecialPersonIndex()
      {
        flagHasSpecialPersonIndex = false;
      }
    public void initWhen()
      {
        if (flagHasWhen)
          {
            for (int num3 = 0; num3 < storeWhen.Count; ++num3)
              {
              }
          }
        flagHasWhen = true;
        storeWhen.Clear();
      }
    public void appendWhen(WhenJSON  to_append)
      {
        if (!flagHasWhen)
          {
            flagHasWhen = true;
            storeWhen.Clear();
          }
        Debug.Assert(flagHasWhen);
        storeWhen.Add(to_append);
      }
    public void unsetWhen()
      {
        if (flagHasWhen)
          {
            for (int num4 = 0; num4 < storeWhen.Count; ++num4)
              {
              }
          }
        flagHasWhen = false;
        storeWhen.Clear();
      }
    public void setSpecialTimeIndex(BigInteger new_value)
      {
        flagHasSpecialTimeIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field SpecialTimeIndex of SentenceEntitiesJSON is less than the lower bound (0) for that field.");
        storeSpecialTimeIndex = new_value;
      }
    public void unsetSpecialTimeIndex()
      {
        flagHasSpecialTimeIndex = false;
      }
    public void initWhere()
      {
        if (flagHasWhere)
          {
            for (int num5 = 0; num5 < storeWhere.Count; ++num5)
              {
              }
          }
        flagHasWhere = true;
        storeWhere.Clear();
      }
    public void appendWhere(MapLocationJSON  to_append)
      {
        if (!flagHasWhere)
          {
            flagHasWhere = true;
            storeWhere.Clear();
          }
        Debug.Assert(flagHasWhere);
        storeWhere.Add(to_append);
      }
    public void unsetWhere()
      {
        if (flagHasWhere)
          {
            for (int num6 = 0; num6 < storeWhere.Count; ++num6)
              {
              }
          }
        flagHasWhere = false;
        storeWhere.Clear();
      }
    public void setSpecialPlaceIndex(BigInteger new_value)
      {
        flagHasSpecialPlaceIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field SpecialPlaceIndex of SentenceEntitiesJSON is less than the lower bound (0) for that field.");
        storeSpecialPlaceIndex = new_value;
      }
    public void unsetSpecialPlaceIndex()
      {
        flagHasSpecialPlaceIndex = false;
      }
    public void initHowMuch()
      {
        if (flagHasHowMuch)
          {
            for (int num7 = 0; num7 < storeHowMuch.Count; ++num7)
              {
              }
          }
        flagHasHowMuch = true;
        storeHowMuch.Clear();
      }
    public void appendHowMuch(AmountJSON  to_append)
      {
        if (!flagHasHowMuch)
          {
            flagHasHowMuch = true;
            storeHowMuch.Clear();
          }
        Debug.Assert(flagHasHowMuch);
        storeHowMuch.Add(to_append);
      }
    public void unsetHowMuch()
      {
        if (flagHasHowMuch)
          {
            for (int num8 = 0; num8 < storeHowMuch.Count; ++num8)
              {
              }
          }
        flagHasHowMuch = false;
        storeHowMuch.Clear();
      }
    public void setSpecialAmountIndex(BigInteger new_value)
      {
        flagHasSpecialAmountIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field SpecialAmountIndex of SentenceEntitiesJSON is less than the lower bound (0) for that field.");
        storeSpecialAmountIndex = new_value;
      }
    public void unsetSpecialAmountIndex()
      {
        flagHasSpecialAmountIndex = false;
      }
    public void initWhatWord()
      {
        if (flagHasWhatWord)
          {
            for (int num9 = 0; num9 < storeWhatWord.Count; ++num9)
              {
              }
          }
        flagHasWhatWord = true;
        storeWhatWord.Clear();
      }
    public void appendWhatWord(WhatWordJSON  to_append)
      {
        if (!flagHasWhatWord)
          {
            flagHasWhatWord = true;
            storeWhatWord.Clear();
          }
        Debug.Assert(flagHasWhatWord);
        storeWhatWord.Add(to_append);
      }
    public void unsetWhatWord()
      {
        if (flagHasWhatWord)
          {
            for (int num10 = 0; num10 < storeWhatWord.Count; ++num10)
              {
              }
          }
        flagHasWhatWord = false;
        storeWhatWord.Clear();
      }
    public void setSpecialWhatWordIndex(BigInteger new_value)
      {
        flagHasSpecialWhatWordIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field SpecialWhatWordIndex of SentenceEntitiesJSON is less than the lower bound (0) for that field.");
        storeSpecialWhatWordIndex = new_value;
      }
    public void unsetSpecialWhatWordIndex()
      {
        flagHasSpecialWhatWordIndex = false;
      }

    public virtual void extraSentenceEntitiesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSentenceEntitiesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSentenceEntitiesLookup(key);
        if (old_field == null)
          {
            extraSentenceEntitiesAppendPair(key, new_component);
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
        if (flagHasWho)
          {
            handler.start_pair("Who");
            Debug.Assert(storeWho.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeWho.Count; ++num1)
              {
                if (partial_allowed)
                    storeWho[num1].write_partial_as_json(handler);
                else
                    storeWho[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSpecialPersonIndex)
          {
            handler.start_pair("SpecialPersonIndex");
            handler.number_value(storeSpecialPersonIndex);
          }
        if (flagHasWhen)
          {
            handler.start_pair("When");
            Debug.Assert(storeWhen.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeWhen.Count; ++num2)
              {
                if (partial_allowed)
                    storeWhen[num2].write_partial_as_json(handler);
                else
                    storeWhen[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSpecialTimeIndex)
          {
            handler.start_pair("SpecialTimeIndex");
            handler.number_value(storeSpecialTimeIndex);
          }
        if (flagHasWhere)
          {
            handler.start_pair("Where");
            Debug.Assert(storeWhere.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeWhere.Count; ++num3)
              {
                if (partial_allowed)
                    storeWhere[num3].write_partial_as_json(handler);
                else
                    storeWhere[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSpecialPlaceIndex)
          {
            handler.start_pair("SpecialPlaceIndex");
            handler.number_value(storeSpecialPlaceIndex);
          }
        if (flagHasHowMuch)
          {
            handler.start_pair("HowMuch");
            Debug.Assert(storeHowMuch.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeHowMuch.Count; ++num4)
              {
                if (partial_allowed)
                    storeHowMuch[num4].write_partial_as_json(handler);
                else
                    storeHowMuch[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSpecialAmountIndex)
          {
            handler.start_pair("SpecialAmountIndex");
            handler.number_value(storeSpecialAmountIndex);
          }
        if (flagHasWhatWord)
          {
            handler.start_pair("WhatWord");
            Debug.Assert(storeWhatWord.Count >= 1);
            handler.start_array();
            for (int num5 = 0; num5 < storeWhatWord.Count; ++num5)
              {
                if (partial_allowed)
                    storeWhatWord[num5].write_partial_as_json(handler);
                else
                    storeWhatWord[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSpecialWhatWordIndex)
          {
            handler.start_pair("SpecialWhatWordIndex");
            handler.number_value(storeSpecialWhatWordIndex);
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

    public static SentenceEntitiesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SentenceEntitiesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SentenceEntities", ignore_extras);
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
    public static SentenceEntitiesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SentenceEntitiesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SentenceEntitiesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SentenceEntities", ignore_extras);
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
    public static SentenceEntitiesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SentenceEntitiesJSON from_text(string text, bool ignore_extras)
      {
        SentenceEntitiesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SentenceEntities", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SentenceEntitiesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SentenceEntitiesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SentenceEntitiesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SentenceEntities", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private WhoJSON.HoldingArrayGenerator fieldGeneratorWho;
    private class FieldHoldingGeneratorSpecialPersonIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSpecialPersonIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSpecialPersonIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSpecialPersonIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSpecialPersonIndex fieldGeneratorSpecialPersonIndex;
        private WhenJSON.HoldingArrayGenerator fieldGeneratorWhen;
    private class FieldHoldingGeneratorSpecialTimeIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSpecialTimeIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSpecialTimeIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSpecialTimeIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSpecialTimeIndex fieldGeneratorSpecialTimeIndex;
        private MapLocationJSON.HoldingArrayGenerator fieldGeneratorWhere;
    private class FieldHoldingGeneratorSpecialPlaceIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSpecialPlaceIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSpecialPlaceIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSpecialPlaceIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSpecialPlaceIndex fieldGeneratorSpecialPlaceIndex;
        private AmountJSON.HoldingArrayGenerator fieldGeneratorHowMuch;
    private class FieldHoldingGeneratorSpecialAmountIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSpecialAmountIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSpecialAmountIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSpecialAmountIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSpecialAmountIndex fieldGeneratorSpecialAmountIndex;
        private WhatWordJSON.HoldingArrayGenerator fieldGeneratorWhatWord;
    private class FieldHoldingGeneratorSpecialWhatWordIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSpecialWhatWordIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSpecialWhatWordIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSpecialWhatWordIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSpecialWhatWordIndex fieldGeneratorSpecialWhatWordIndex;
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
            SentenceEntitiesJSON result = new SentenceEntitiesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSentenceEntitiesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SentenceEntitiesJSON result)
          {
            if (fieldGeneratorWho.have_value)
              {
                result.initWho();
                int count = fieldGeneratorWho.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWho(fieldGeneratorWho.value[num]);
                  }
                fieldGeneratorWho.value.Clear();
                fieldGeneratorWho.have_value = false;
              }
            if (fieldGeneratorSpecialPersonIndex.have_value)
              {
                result.setSpecialPersonIndex(fieldGeneratorSpecialPersonIndex.value);
                fieldGeneratorSpecialPersonIndex.have_value = false;
              }
            if (fieldGeneratorWhen.have_value)
              {
                result.initWhen();
                int count = fieldGeneratorWhen.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWhen(fieldGeneratorWhen.value[num]);
                  }
                fieldGeneratorWhen.value.Clear();
                fieldGeneratorWhen.have_value = false;
              }
            if (fieldGeneratorSpecialTimeIndex.have_value)
              {
                result.setSpecialTimeIndex(fieldGeneratorSpecialTimeIndex.value);
                fieldGeneratorSpecialTimeIndex.have_value = false;
              }
            if (fieldGeneratorWhere.have_value)
              {
                result.initWhere();
                int count = fieldGeneratorWhere.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWhere(fieldGeneratorWhere.value[num]);
                  }
                fieldGeneratorWhere.value.Clear();
                fieldGeneratorWhere.have_value = false;
              }
            if (fieldGeneratorSpecialPlaceIndex.have_value)
              {
                result.setSpecialPlaceIndex(fieldGeneratorSpecialPlaceIndex.value);
                fieldGeneratorSpecialPlaceIndex.have_value = false;
              }
            if (fieldGeneratorHowMuch.have_value)
              {
                result.initHowMuch();
                int count = fieldGeneratorHowMuch.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHowMuch(fieldGeneratorHowMuch.value[num]);
                  }
                fieldGeneratorHowMuch.value.Clear();
                fieldGeneratorHowMuch.have_value = false;
              }
            if (fieldGeneratorSpecialAmountIndex.have_value)
              {
                result.setSpecialAmountIndex(fieldGeneratorSpecialAmountIndex.value);
                fieldGeneratorSpecialAmountIndex.have_value = false;
              }
            if (fieldGeneratorWhatWord.have_value)
              {
                result.initWhatWord();
                int count = fieldGeneratorWhatWord.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWhatWord(fieldGeneratorWhatWord.value[num]);
                  }
                fieldGeneratorWhatWord.value.Clear();
                fieldGeneratorWhatWord.have_value = false;
              }
            if (fieldGeneratorSpecialWhatWordIndex.have_value)
              {
                result.setSpecialWhatWordIndex(fieldGeneratorSpecialWhatWordIndex.value);
                fieldGeneratorSpecialWhatWordIndex.have_value = false;
              }
          }
        protected abstract void handle_result(SentenceEntitiesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'H':
                    if ((String.Compare(field_name, 1, "owMuch", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorHowMuch;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "pecial", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 8, "mountIndex", 0, 10, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorSpecialAmountIndex;
                                break;
                            case 'P':
                                switch (field_name[8])
                                  {
                                    case 'e':
                                        if ((String.Compare(field_name, 9, "rsonIndex", 0, 9, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorSpecialPersonIndex;
                                        break;
                                    case 'l':
                                        if ((String.Compare(field_name, 9, "aceIndex", 0, 8, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorSpecialPlaceIndex;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "imeIndex", 0, 8, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorSpecialTimeIndex;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 8, "hatWordIndex", 0, 12, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorSpecialWhatWordIndex;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "h", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 3, "tWord", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorWhatWord;
                                break;
                            case 'e':
                                switch (field_name[3])
                                  {
                                    case 'n':
                                        if (field_name.Length == 4)
                                            return fieldGeneratorWhen;
                                        break;
                                    case 'r':
                                        if ((String.Compare(field_name, 4, "e", 0, 1, false) == 0) && (field_name.Length == 5))
                                            return fieldGeneratorWhere;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'o':
                                if (field_name.Length == 3)
                                    return fieldGeneratorWho;
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
            fieldGeneratorWho = new WhoJSON.HoldingArrayGenerator("field \"Who\" of the SentenceEntities class", ignore_extras);
            fieldGeneratorSpecialPersonIndex = new FieldHoldingGeneratorSpecialPersonIndex("field \"SpecialPersonIndex\" of the SentenceEntities class");
            fieldGeneratorWhen = new WhenJSON.HoldingArrayGenerator("field \"When\" of the SentenceEntities class", ignore_extras);
            fieldGeneratorSpecialTimeIndex = new FieldHoldingGeneratorSpecialTimeIndex("field \"SpecialTimeIndex\" of the SentenceEntities class");
            fieldGeneratorWhere = new MapLocationJSON.HoldingArrayGenerator("field \"Where\" of the SentenceEntities class", ignore_extras);
            fieldGeneratorSpecialPlaceIndex = new FieldHoldingGeneratorSpecialPlaceIndex("field \"SpecialPlaceIndex\" of the SentenceEntities class");
            fieldGeneratorHowMuch = new AmountJSON.HoldingArrayGenerator("field \"HowMuch\" of the SentenceEntities class", ignore_extras);
            fieldGeneratorSpecialAmountIndex = new FieldHoldingGeneratorSpecialAmountIndex("field \"SpecialAmountIndex\" of the SentenceEntities class");
            fieldGeneratorWhatWord = new WhatWordJSON.HoldingArrayGenerator("field \"WhatWord\" of the SentenceEntities class", ignore_extras);
            fieldGeneratorSpecialWhatWordIndex = new FieldHoldingGeneratorSpecialWhatWordIndex("field \"SpecialWhatWordIndex\" of the SentenceEntities class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SentenceEntities class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorWho = new WhoJSON.HoldingArrayGenerator("field \"Who\" of the SentenceEntities class", false);
            fieldGeneratorSpecialPersonIndex = new FieldHoldingGeneratorSpecialPersonIndex("field \"SpecialPersonIndex\" of the SentenceEntities class");
            fieldGeneratorWhen = new WhenJSON.HoldingArrayGenerator("field \"When\" of the SentenceEntities class", false);
            fieldGeneratorSpecialTimeIndex = new FieldHoldingGeneratorSpecialTimeIndex("field \"SpecialTimeIndex\" of the SentenceEntities class");
            fieldGeneratorWhere = new MapLocationJSON.HoldingArrayGenerator("field \"Where\" of the SentenceEntities class", false);
            fieldGeneratorSpecialPlaceIndex = new FieldHoldingGeneratorSpecialPlaceIndex("field \"SpecialPlaceIndex\" of the SentenceEntities class");
            fieldGeneratorHowMuch = new AmountJSON.HoldingArrayGenerator("field \"HowMuch\" of the SentenceEntities class", false);
            fieldGeneratorSpecialAmountIndex = new FieldHoldingGeneratorSpecialAmountIndex("field \"SpecialAmountIndex\" of the SentenceEntities class");
            fieldGeneratorWhatWord = new WhatWordJSON.HoldingArrayGenerator("field \"WhatWord\" of the SentenceEntities class", false);
            fieldGeneratorSpecialWhatWordIndex = new FieldHoldingGeneratorSpecialWhatWordIndex("field \"SpecialWhatWordIndex\" of the SentenceEntities class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SentenceEntities class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorWho.reset();
            fieldGeneratorSpecialPersonIndex.reset();
            fieldGeneratorWhen.reset();
            fieldGeneratorSpecialTimeIndex.reset();
            fieldGeneratorWhere.reset();
            fieldGeneratorSpecialPlaceIndex.reset();
            fieldGeneratorHowMuch.reset();
            fieldGeneratorSpecialAmountIndex.reset();
            fieldGeneratorWhatWord.reset();
            fieldGeneratorSpecialWhatWordIndex.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorWho.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWhen.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWhere.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHowMuch.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWhatWord.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorWho.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWhen.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWhere.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHowMuch.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWhatWord.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SentenceEntitiesJSON  result)
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
        public SentenceEntitiesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SentenceEntitiesJSON  result)
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
    protected virtual void handle_result(List<SentenceEntitiesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SentenceEntitiesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SentenceEntitiesJSON>();
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
    public List<SentenceEntitiesJSON> value;
  };
  };
