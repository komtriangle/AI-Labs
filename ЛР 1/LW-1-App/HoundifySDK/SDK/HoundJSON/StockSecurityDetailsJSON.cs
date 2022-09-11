/* file "StockSecurityDetailsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StockSecurityDetailsJSON : JSONBase
  {
    public struct TypeCIK
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeISIN
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeValoren
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeMarket
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeMarketIdentificationCode
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct TypeMostLiquidExchange
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeCategoryOrIndustry
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    private bool flagHasCIK;
    private TypeCIK storeCIK;
    private bool flagHasSymbol;
    private string storeSymbol;
    private bool flagHasISIN;
    private TypeISIN storeISIN;
    private bool flagHasValoren;
    private TypeValoren storeValoren;
    private bool flagHasName;
    private string storeName;
    private bool flagHasMarket;
    private TypeMarket storeMarket;
    private bool flagHasMarketIdentificationCode;
    private TypeMarketIdentificationCode storeMarketIdentificationCode;
    private bool flagHasMostLiquidExchange;
    private TypeMostLiquidExchange storeMostLiquidExchange;
    private bool flagHasCategoryOrIndustry;
    private TypeCategoryOrIndustry storeCategoryOrIndustry;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCIK(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeCIK or_result = new TypeCIK();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field CIK of StockSecurityDetailsJSON is not one of the allowed values.");
        setCIK(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Symbol of StockSecurityDetailsJSON is not a string.");
        setSymbol(json_string.getData());
      }


    private void  fromJSONISIN(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeISIN or_result = new TypeISIN();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field ISIN of StockSecurityDetailsJSON is not one of the allowed values.");
        setISIN(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONValoren(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeValoren or_result = new TypeValoren();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Valoren of StockSecurityDetailsJSON is not one of the allowed values.");
        setValoren(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of StockSecurityDetailsJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONMarket(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMarket or_result = new TypeMarket();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Market of StockSecurityDetailsJSON is not one of the allowed values.");
        setMarket(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONMarketIdentificationCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMarketIdentificationCode or_result = new TypeMarketIdentificationCode();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field MarketIdentificationCode of StockSecurityDetailsJSON is not one of the allowed values.");
        setMarketIdentificationCode(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONMostLiquidExchange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMostLiquidExchange or_result = new TypeMostLiquidExchange();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice0 = the_bool;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field MostLiquidExchange of StockSecurityDetailsJSON is not one of the allowed values.");
        setMostLiquidExchange(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONCategoryOrIndustry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeCategoryOrIndustry or_result = new TypeCategoryOrIndustry();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field CategoryOrIndustry of StockSecurityDetailsJSON is not one of the allowed values.");
        setCategoryOrIndustry(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    public StockSecurityDetailsJSON()
      {
        flagHasCIK = false;
        flagHasSymbol = false;
        flagHasISIN = false;
        flagHasValoren = false;
        flagHasName = false;
        flagHasMarket = false;
        flagHasMarketIdentificationCode = false;
        flagHasMostLiquidExchange = false;
        flagHasCategoryOrIndustry = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCIK()
      {
        return flagHasCIK;
      }

    public TypeCIK  getCIK()
      {
        Debug.Assert(flagHasCIK);
        return storeCIK;
      }

    public bool  hasSymbol()
      {
        return flagHasSymbol;
      }

    public string  getSymbol()
      {
        Debug.Assert(flagHasSymbol);
        return storeSymbol;
      }

    public bool  hasISIN()
      {
        return flagHasISIN;
      }

    public TypeISIN  getISIN()
      {
        Debug.Assert(flagHasISIN);
        return storeISIN;
      }

    public bool  hasValoren()
      {
        return flagHasValoren;
      }

    public TypeValoren  getValoren()
      {
        Debug.Assert(flagHasValoren);
        return storeValoren;
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

    public bool  hasMarket()
      {
        return flagHasMarket;
      }

    public TypeMarket  getMarket()
      {
        Debug.Assert(flagHasMarket);
        return storeMarket;
      }

    public bool  hasMarketIdentificationCode()
      {
        return flagHasMarketIdentificationCode;
      }

    public TypeMarketIdentificationCode  getMarketIdentificationCode()
      {
        Debug.Assert(flagHasMarketIdentificationCode);
        return storeMarketIdentificationCode;
      }

    public bool  hasMostLiquidExchange()
      {
        return flagHasMostLiquidExchange;
      }

    public TypeMostLiquidExchange  getMostLiquidExchange()
      {
        Debug.Assert(flagHasMostLiquidExchange);
        return storeMostLiquidExchange;
      }

    public bool  hasCategoryOrIndustry()
      {
        return flagHasCategoryOrIndustry;
      }

    public TypeCategoryOrIndustry  getCategoryOrIndustry()
      {
        Debug.Assert(flagHasCategoryOrIndustry);
        return storeCategoryOrIndustry;
      }


    public virtual int extraStockSecurityDetailsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStockSecurityDetailsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStockSecurityDetailsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStockSecurityDetailsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCIK(TypeCIK new_value)
      {
        flagHasCIK = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeCIK = new_value;
      }
    public void unsetCIK()
      {
        flagHasCIK = false;
      }
    public void setSymbol(string new_value)
      {
        flagHasSymbol = true;
        storeSymbol = new_value;
      }
    public void unsetSymbol()
      {
        flagHasSymbol = false;
      }
    public void setISIN(TypeISIN new_value)
      {
        flagHasISIN = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeISIN = new_value;
      }
    public void unsetISIN()
      {
        flagHasISIN = false;
      }
    public void setValoren(TypeValoren new_value)
      {
        flagHasValoren = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeValoren = new_value;
      }
    public void unsetValoren()
      {
        flagHasValoren = false;
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
    public void setMarket(TypeMarket new_value)
      {
        flagHasMarket = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeMarket = new_value;
      }
    public void unsetMarket()
      {
        flagHasMarket = false;
      }
    public void setMarketIdentificationCode(TypeMarketIdentificationCode new_value)
      {
        flagHasMarketIdentificationCode = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeMarketIdentificationCode = new_value;
      }
    public void unsetMarketIdentificationCode()
      {
        flagHasMarketIdentificationCode = false;
      }
    public void setMostLiquidExchange(TypeMostLiquidExchange new_value)
      {
        flagHasMostLiquidExchange = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeMostLiquidExchange = new_value;
      }
    public void unsetMostLiquidExchange()
      {
        flagHasMostLiquidExchange = false;
      }
    public void setCategoryOrIndustry(TypeCategoryOrIndustry new_value)
      {
        flagHasCategoryOrIndustry = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeCategoryOrIndustry = new_value;
      }
    public void unsetCategoryOrIndustry()
      {
        flagHasCategoryOrIndustry = false;
      }

    public virtual void extraStockSecurityDetailsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStockSecurityDetailsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStockSecurityDetailsLookup(key);
        if (old_field == null)
          {
            extraStockSecurityDetailsAppendPair(key, new_component);
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
        if (flagHasCIK)
          {
            handler.start_pair("CIK");
            switch (storeCIK.key)
              {
                case 0:
                    handler.string_value(storeCIK.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasSymbol);
        if (flagHasSymbol)
          {
            handler.start_pair("Symbol");
            handler.string_value(storeSymbol);
          }
        if (flagHasISIN)
          {
            handler.start_pair("ISIN");
            switch (storeISIN.key)
              {
                case 0:
                    handler.string_value(storeISIN.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasValoren)
          {
            handler.start_pair("Valoren");
            switch (storeValoren.key)
              {
                case 0:
                    handler.string_value(storeValoren.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasMarket)
          {
            handler.start_pair("Market");
            switch (storeMarket.key)
              {
                case 0:
                    handler.string_value(storeMarket.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasMarketIdentificationCode)
          {
            handler.start_pair("MarketIdentificationCode");
            switch (storeMarketIdentificationCode.key)
              {
                case 0:
                    handler.string_value(storeMarketIdentificationCode.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasMostLiquidExchange)
          {
            handler.start_pair("MostLiquidExchange");
            switch (storeMostLiquidExchange.key)
              {
                case 0:
                    handler.boolean_value(storeMostLiquidExchange.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasCategoryOrIndustry)
          {
            handler.start_pair("CategoryOrIndustry");
            switch (storeCategoryOrIndustry.key)
              {
                case 0:
                    handler.string_value(storeCategoryOrIndustry.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasSymbol()))
          {
            return "When parsing the object for %what%, the \"Symbol\" field was missing.";
          }
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        return null;
      }

    public static StockSecurityDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockSecurityDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockSecurityDetails", ignore_extras);
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
    public static StockSecurityDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockSecurityDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StockSecurityDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockSecurityDetails", ignore_extras);
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
    public static StockSecurityDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StockSecurityDetailsJSON from_text(string text, bool ignore_extras)
      {
        StockSecurityDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockSecurityDetails", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StockSecurityDetailsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StockSecurityDetailsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StockSecurityDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StockSecurityDetails", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorCIK : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeCIK result = new TypeCIK();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeCIK result);
            public FieldGeneratorCIK(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"CIK\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"CIK\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorCIK(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"CIK\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"CIK\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderCIK
          {
            private bool have_data;
            private TypeCIK data;
            public HolderCIK()  { have_data = false; }
            public HolderCIK(TypeCIK init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderCIK(HolderCIK other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeCIK referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorCIK : FieldGeneratorCIK
          {
            protected override void handle_result(TypeCIK result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderCIK(result);
              }

            public FieldHoldingGeneratorCIK(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderCIK value;
          };
    private class FieldHoldingArrayGeneratorCIK : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCIK
      {
        private FieldHoldingArrayGeneratorCIK top;

        protected override void handle_result(TypeCIK result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCIK init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeCIK> result)
      {
      }

    public FieldHoldingArrayGeneratorCIK(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeCIK>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCIK(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeCIK>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCIK> value;
  };
        private FieldHoldingGeneratorCIK fieldGeneratorCIK;
        private JSONHoldingStringGenerator fieldGeneratorSymbol;
    private abstract class FieldGeneratorISIN : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeISIN result = new TypeISIN();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeISIN result);
            public FieldGeneratorISIN(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"ISIN\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"ISIN\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorISIN(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"ISIN\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"ISIN\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderISIN
          {
            private bool have_data;
            private TypeISIN data;
            public HolderISIN()  { have_data = false; }
            public HolderISIN(TypeISIN init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderISIN(HolderISIN other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeISIN referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorISIN : FieldGeneratorISIN
          {
            protected override void handle_result(TypeISIN result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderISIN(result);
              }

            public FieldHoldingGeneratorISIN(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderISIN value;
          };
    private class FieldHoldingArrayGeneratorISIN : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorISIN
      {
        private FieldHoldingArrayGeneratorISIN top;

        protected override void handle_result(TypeISIN result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorISIN init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeISIN> result)
      {
      }

    public FieldHoldingArrayGeneratorISIN(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeISIN>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorISIN(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeISIN>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeISIN> value;
  };
        private FieldHoldingGeneratorISIN fieldGeneratorISIN;
    private abstract class FieldGeneratorValoren : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeValoren result = new TypeValoren();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeValoren result);
            public FieldGeneratorValoren(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Valoren\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Valoren\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorValoren(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Valoren\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Valoren\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderValoren
          {
            private bool have_data;
            private TypeValoren data;
            public HolderValoren()  { have_data = false; }
            public HolderValoren(TypeValoren init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderValoren(HolderValoren other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeValoren referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorValoren : FieldGeneratorValoren
          {
            protected override void handle_result(TypeValoren result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderValoren(result);
              }

            public FieldHoldingGeneratorValoren(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderValoren value;
          };
    private class FieldHoldingArrayGeneratorValoren : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValoren
      {
        private FieldHoldingArrayGeneratorValoren top;

        protected override void handle_result(TypeValoren result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValoren init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeValoren> result)
      {
      }

    public FieldHoldingArrayGeneratorValoren(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeValoren>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValoren(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeValoren>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValoren> value;
  };
        private FieldHoldingGeneratorValoren fieldGeneratorValoren;
        private JSONHoldingStringGenerator fieldGeneratorName;
    private abstract class FieldGeneratorMarket : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeMarket result = new TypeMarket();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeMarket result);
            public FieldGeneratorMarket(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Market\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Market\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorMarket(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"Market\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"Market\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderMarket
          {
            private bool have_data;
            private TypeMarket data;
            public HolderMarket()  { have_data = false; }
            public HolderMarket(TypeMarket init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderMarket(HolderMarket other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeMarket referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorMarket : FieldGeneratorMarket
          {
            protected override void handle_result(TypeMarket result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderMarket(result);
              }

            public FieldHoldingGeneratorMarket(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderMarket value;
          };
    private class FieldHoldingArrayGeneratorMarket : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMarket
      {
        private FieldHoldingArrayGeneratorMarket top;

        protected override void handle_result(TypeMarket result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMarket init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeMarket> result)
      {
      }

    public FieldHoldingArrayGeneratorMarket(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeMarket>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMarket(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeMarket>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMarket> value;
  };
        private FieldHoldingGeneratorMarket fieldGeneratorMarket;
    private abstract class FieldGeneratorMarketIdentificationCode : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeMarketIdentificationCode result = new TypeMarketIdentificationCode();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeMarketIdentificationCode result);
            public FieldGeneratorMarketIdentificationCode(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"MarketIdentificationCode\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"MarketIdentificationCode\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorMarketIdentificationCode(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"MarketIdentificationCode\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"MarketIdentificationCode\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderMarketIdentificationCode
          {
            private bool have_data;
            private TypeMarketIdentificationCode data;
            public HolderMarketIdentificationCode()  { have_data = false; }
            public HolderMarketIdentificationCode(TypeMarketIdentificationCode init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderMarketIdentificationCode(HolderMarketIdentificationCode other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeMarketIdentificationCode referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorMarketIdentificationCode : FieldGeneratorMarketIdentificationCode
          {
            protected override void handle_result(TypeMarketIdentificationCode result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderMarketIdentificationCode(result);
              }

            public FieldHoldingGeneratorMarketIdentificationCode(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderMarketIdentificationCode value;
          };
    private class FieldHoldingArrayGeneratorMarketIdentificationCode : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMarketIdentificationCode
      {
        private FieldHoldingArrayGeneratorMarketIdentificationCode top;

        protected override void handle_result(TypeMarketIdentificationCode result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMarketIdentificationCode init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeMarketIdentificationCode> result)
      {
      }

    public FieldHoldingArrayGeneratorMarketIdentificationCode(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeMarketIdentificationCode>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMarketIdentificationCode(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeMarketIdentificationCode>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMarketIdentificationCode> value;
  };
        private FieldHoldingGeneratorMarketIdentificationCode fieldGeneratorMarketIdentificationCode;
    private abstract class FieldGeneratorMostLiquidExchange : JSONParallelGenerator
          {
            private JSONHoldingBooleanGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeMostLiquidExchange result = new TypeMostLiquidExchange();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeMostLiquidExchange result);
            public FieldGeneratorMostLiquidExchange(bool ignore_extras)
              {
                    field0 = new JSONHoldingBooleanGenerator("option 0 of field \"MostLiquidExchange\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"MostLiquidExchange\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorMostLiquidExchange(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingBooleanGenerator("option 0 of field \"MostLiquidExchange\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"MostLiquidExchange\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderMostLiquidExchange
          {
            private bool have_data;
            private TypeMostLiquidExchange data;
            public HolderMostLiquidExchange()  { have_data = false; }
            public HolderMostLiquidExchange(TypeMostLiquidExchange init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderMostLiquidExchange(HolderMostLiquidExchange other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeMostLiquidExchange referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorMostLiquidExchange : FieldGeneratorMostLiquidExchange
          {
            protected override void handle_result(TypeMostLiquidExchange result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderMostLiquidExchange(result);
              }

            public FieldHoldingGeneratorMostLiquidExchange(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderMostLiquidExchange value;
          };
    private class FieldHoldingArrayGeneratorMostLiquidExchange : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMostLiquidExchange
      {
        private FieldHoldingArrayGeneratorMostLiquidExchange top;

        protected override void handle_result(TypeMostLiquidExchange result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMostLiquidExchange init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeMostLiquidExchange> result)
      {
      }

    public FieldHoldingArrayGeneratorMostLiquidExchange(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeMostLiquidExchange>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMostLiquidExchange(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeMostLiquidExchange>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMostLiquidExchange> value;
  };
        private FieldHoldingGeneratorMostLiquidExchange fieldGeneratorMostLiquidExchange;
    private abstract class FieldGeneratorCategoryOrIndustry : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeCategoryOrIndustry result = new TypeCategoryOrIndustry();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeCategoryOrIndustry result);
            public FieldGeneratorCategoryOrIndustry(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"CategoryOrIndustry\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"CategoryOrIndustry\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorCategoryOrIndustry(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"CategoryOrIndustry\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"CategoryOrIndustry\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderCategoryOrIndustry
          {
            private bool have_data;
            private TypeCategoryOrIndustry data;
            public HolderCategoryOrIndustry()  { have_data = false; }
            public HolderCategoryOrIndustry(TypeCategoryOrIndustry init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderCategoryOrIndustry(HolderCategoryOrIndustry other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeCategoryOrIndustry referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorCategoryOrIndustry : FieldGeneratorCategoryOrIndustry
          {
            protected override void handle_result(TypeCategoryOrIndustry result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderCategoryOrIndustry(result);
              }

            public FieldHoldingGeneratorCategoryOrIndustry(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderCategoryOrIndustry value;
          };
    private class FieldHoldingArrayGeneratorCategoryOrIndustry : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCategoryOrIndustry
      {
        private FieldHoldingArrayGeneratorCategoryOrIndustry top;

        protected override void handle_result(TypeCategoryOrIndustry result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCategoryOrIndustry init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeCategoryOrIndustry> result)
      {
      }

    public FieldHoldingArrayGeneratorCategoryOrIndustry(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeCategoryOrIndustry>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCategoryOrIndustry(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeCategoryOrIndustry>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCategoryOrIndustry> value;
  };
        private FieldHoldingGeneratorCategoryOrIndustry fieldGeneratorCategoryOrIndustry;
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
            StockSecurityDetailsJSON result = new StockSecurityDetailsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStockSecurityDetailsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StockSecurityDetailsJSON result)
          {
            if (fieldGeneratorCIK.have_value)
              {
                result.setCIK(fieldGeneratorCIK.value.referenced());
                fieldGeneratorCIK.have_value = false;
              }
            if (fieldGeneratorSymbol.have_value)
              {
                result.setSymbol(fieldGeneratorSymbol.value);
                fieldGeneratorSymbol.have_value = false;
              }
            else if ((!(result.hasSymbol())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Symbol\" field was missing.");
              }
            if (fieldGeneratorISIN.have_value)
              {
                result.setISIN(fieldGeneratorISIN.value.referenced());
                fieldGeneratorISIN.have_value = false;
              }
            if (fieldGeneratorValoren.have_value)
              {
                result.setValoren(fieldGeneratorValoren.value.referenced());
                fieldGeneratorValoren.have_value = false;
              }
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorMarket.have_value)
              {
                result.setMarket(fieldGeneratorMarket.value.referenced());
                fieldGeneratorMarket.have_value = false;
              }
            if (fieldGeneratorMarketIdentificationCode.have_value)
              {
                result.setMarketIdentificationCode(fieldGeneratorMarketIdentificationCode.value.referenced());
                fieldGeneratorMarketIdentificationCode.have_value = false;
              }
            if (fieldGeneratorMostLiquidExchange.have_value)
              {
                result.setMostLiquidExchange(fieldGeneratorMostLiquidExchange.value.referenced());
                fieldGeneratorMostLiquidExchange.have_value = false;
              }
            if (fieldGeneratorCategoryOrIndustry.have_value)
              {
                result.setCategoryOrIndustry(fieldGeneratorCategoryOrIndustry.value.referenced());
                fieldGeneratorCategoryOrIndustry.have_value = false;
              }
          }
        protected abstract void handle_result(StockSecurityDetailsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 2, "K", 0, 1, false) == 0) && (field_name.Length == 3))
                                return fieldGeneratorCIK;
                            break;
                        case 'a':
                            if ((String.Compare(field_name, 2, "tegoryOrIndustry", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorCategoryOrIndustry;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "SIN", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorISIN;
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "rket", 0, 4, false) == 0)
                              {
                                if (field_name.Length == 6)
                                  {
                                    return fieldGeneratorMarket;
                                  }
                                switch (field_name[6])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "dentificationCode", 0, 17, false) == 0) && (field_name.Length == 24))
                                            return fieldGeneratorMarketIdentificationCode;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "stLiquidExchange", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorMostLiquidExchange;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ymbol", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSymbol;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "aloren", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorValoren;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCIK = new FieldHoldingGeneratorCIK("field \"CIK\" of the StockSecurityDetails class", ignore_extras);
            fieldGeneratorSymbol = new JSONHoldingStringGenerator("field \"Symbol\" of the StockSecurityDetails class");
            fieldGeneratorISIN = new FieldHoldingGeneratorISIN("field \"ISIN\" of the StockSecurityDetails class", ignore_extras);
            fieldGeneratorValoren = new FieldHoldingGeneratorValoren("field \"Valoren\" of the StockSecurityDetails class", ignore_extras);
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the StockSecurityDetails class");
            fieldGeneratorMarket = new FieldHoldingGeneratorMarket("field \"Market\" of the StockSecurityDetails class", ignore_extras);
            fieldGeneratorMarketIdentificationCode = new FieldHoldingGeneratorMarketIdentificationCode("field \"MarketIdentificationCode\" of the StockSecurityDetails class", ignore_extras);
            fieldGeneratorMostLiquidExchange = new FieldHoldingGeneratorMostLiquidExchange("field \"MostLiquidExchange\" of the StockSecurityDetails class", ignore_extras);
            fieldGeneratorCategoryOrIndustry = new FieldHoldingGeneratorCategoryOrIndustry("field \"CategoryOrIndustry\" of the StockSecurityDetails class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StockSecurityDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCIK = new FieldHoldingGeneratorCIK("field \"CIK\" of the StockSecurityDetails class", false);
            fieldGeneratorSymbol = new JSONHoldingStringGenerator("field \"Symbol\" of the StockSecurityDetails class");
            fieldGeneratorISIN = new FieldHoldingGeneratorISIN("field \"ISIN\" of the StockSecurityDetails class", false);
            fieldGeneratorValoren = new FieldHoldingGeneratorValoren("field \"Valoren\" of the StockSecurityDetails class", false);
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the StockSecurityDetails class");
            fieldGeneratorMarket = new FieldHoldingGeneratorMarket("field \"Market\" of the StockSecurityDetails class", false);
            fieldGeneratorMarketIdentificationCode = new FieldHoldingGeneratorMarketIdentificationCode("field \"MarketIdentificationCode\" of the StockSecurityDetails class", false);
            fieldGeneratorMostLiquidExchange = new FieldHoldingGeneratorMostLiquidExchange("field \"MostLiquidExchange\" of the StockSecurityDetails class", false);
            fieldGeneratorCategoryOrIndustry = new FieldHoldingGeneratorCategoryOrIndustry("field \"CategoryOrIndustry\" of the StockSecurityDetails class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StockSecurityDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCIK.reset();
            fieldGeneratorSymbol.reset();
            fieldGeneratorISIN.reset();
            fieldGeneratorValoren.reset();
            fieldGeneratorName.reset();
            fieldGeneratorMarket.reset();
            fieldGeneratorMarketIdentificationCode.reset();
            fieldGeneratorMostLiquidExchange.reset();
            fieldGeneratorCategoryOrIndustry.reset();
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
        protected override void handle_result(StockSecurityDetailsJSON  result)
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
        public StockSecurityDetailsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StockSecurityDetailsJSON  result)
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
    protected virtual void handle_result(List<StockSecurityDetailsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StockSecurityDetailsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StockSecurityDetailsJSON>();
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
    public List<StockSecurityDetailsJSON> value;
  };
  };
