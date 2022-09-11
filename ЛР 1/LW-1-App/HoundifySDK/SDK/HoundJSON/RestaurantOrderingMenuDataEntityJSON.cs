/* file "RestaurantOrderingMenuDataEntityJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class RestaurantOrderingMenuDataEntityJSON : JSONBase
  {
    private bool flagHasID;
    private string storeID;
    private bool flagHasDisplayName;
    private string storeDisplayName;
    private bool flagHasWrittenName;
    private string storeWrittenName;
    private bool flagHasSpokenName;
    private string storeSpokenName;
    private bool flagHasSpokenNameSSML;
    private string storeSpokenNameSSML;
    private bool flagHasRecognitionPattern;
    private RestaurantOrderingMenuDataRecognitionPatternJSON  storeRecognitionPattern;
    private bool flagHasASRFallbackRecognitionPattern;
    private RestaurantOrderingMenuDataRecognitionPatternJSON  storeASRFallbackRecognitionPattern;
    private bool flagHasCoreTagKeys;
    private List< string > storeCoreTagKeys;
    private bool flagHasRestaurantTagKeys;
    private List< string > storeRestaurantTagKeys;
    private bool flagHasPointOfSaleData;
    private PointOfSaleCatalogEntityJSON  storePointOfSaleData;
    private bool flagHasInternalName;
    private string storeInternalName;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasImageURLs;
    private List< string > storeImageURLs;


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ID of RestaurantOrderingMenuDataEntityJSON is not a string.");
        setID(json_string.getData());
      }


    private void  fromJSONDisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayName of RestaurantOrderingMenuDataEntityJSON is not a string.");
        setDisplayName(json_string.getData());
      }


    private void  fromJSONWrittenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenName of RestaurantOrderingMenuDataEntityJSON is not a string.");
        setWrittenName(json_string.getData());
      }


    private void  fromJSONSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenName of RestaurantOrderingMenuDataEntityJSON is not a string.");
        setSpokenName(json_string.getData());
      }


    private void  fromJSONSpokenNameSSML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenNameSSML of RestaurantOrderingMenuDataEntityJSON is not a string.");
        setSpokenNameSSML(json_string.getData());
      }


    private void  fromJSONRecognitionPattern(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RestaurantOrderingMenuDataRecognitionPatternJSON convert_classy = RestaurantOrderingMenuDataRecognitionPatternJSON.from_json(json_value, ignore_extras, true);
        setRecognitionPattern(convert_classy);
      }


    private void  fromJSONASRFallbackRecognitionPattern(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RestaurantOrderingMenuDataRecognitionPatternJSON convert_classy = RestaurantOrderingMenuDataRecognitionPatternJSON.from_json(json_value, ignore_extras, true);
        setASRFallbackRecognitionPattern(convert_classy);
      }


    private void  fromJSONCoreTagKeys(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CoreTagKeys of RestaurantOrderingMenuDataEntityJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_CoreTagKeys1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field CoreTagKeys of RestaurantOrderingMenuDataEntityJSON is not a string.");
            vector_CoreTagKeys1.Add(json_string.getData());
          }
        initCoreTagKeys();
        for (int num1 = 0; num1 < vector_CoreTagKeys1.Count; ++num1)
            appendCoreTagKeys(vector_CoreTagKeys1[num1]);
        for (int num1 = 0; num1 < vector_CoreTagKeys1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRestaurantTagKeys(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RestaurantTagKeys of RestaurantOrderingMenuDataEntityJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_RestaurantTagKeys1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field RestaurantTagKeys of RestaurantOrderingMenuDataEntityJSON is not a string.");
            vector_RestaurantTagKeys1.Add(json_string.getData());
          }
        initRestaurantTagKeys();
        for (int num2 = 0; num2 < vector_RestaurantTagKeys1.Count; ++num2)
            appendRestaurantTagKeys(vector_RestaurantTagKeys1[num2]);
        for (int num1 = 0; num1 < vector_RestaurantTagKeys1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPointOfSaleData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PointOfSaleCatalogEntityJSON convert_classy = PointOfSaleCatalogEntityJSON.from_json(json_value, ignore_extras, true);
        setPointOfSaleData(convert_classy);
      }


    private void  fromJSONInternalName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InternalName of RestaurantOrderingMenuDataEntityJSON is not a string.");
        setInternalName(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of RestaurantOrderingMenuDataEntityJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONImageURLs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ImageURLs of RestaurantOrderingMenuDataEntityJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ImageURLs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ImageURLs of RestaurantOrderingMenuDataEntityJSON is not a string.");
            vector_ImageURLs1.Add(json_string.getData());
          }
        initImageURLs();
        for (int num3 = 0; num3 < vector_ImageURLs1.Count; ++num3)
            appendImageURLs(vector_ImageURLs1[num3]);
        for (int num1 = 0; num1 < vector_ImageURLs1.Count; ++num1)
          {
          }
      }


    public RestaurantOrderingMenuDataEntityJSON()
      {
        flagHasID = false;
        flagHasDisplayName = false;
        flagHasWrittenName = false;
        flagHasSpokenName = false;
        flagHasSpokenNameSSML = false;
        flagHasRecognitionPattern = false;
        flagHasASRFallbackRecognitionPattern = false;
        flagHasCoreTagKeys = false;
        flagHasRestaurantTagKeys = false;
        flagHasPointOfSaleData = false;
        flagHasInternalName = false;
        flagHasDescription = false;
        flagHasImageURLs = false;
        storeCoreTagKeys = new List< string >();
        storeRestaurantTagKeys = new List< string >();
        storeImageURLs = new List< string >();
      }

    public abstract string getEntityKind();
    public bool  hasID()
      {
        return flagHasID;
      }

    public string  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }

    public bool  hasDisplayName()
      {
        return flagHasDisplayName;
      }

    public string  getDisplayName()
      {
        Debug.Assert(flagHasDisplayName);
        return storeDisplayName;
      }

    public bool  hasWrittenName()
      {
        return flagHasWrittenName;
      }

    public string  getWrittenName()
      {
        Debug.Assert(flagHasWrittenName);
        return storeWrittenName;
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

    public bool  hasSpokenNameSSML()
      {
        return flagHasSpokenNameSSML;
      }

    public string  getSpokenNameSSML()
      {
        Debug.Assert(flagHasSpokenNameSSML);
        return storeSpokenNameSSML;
      }

    public bool  hasRecognitionPattern()
      {
        return flagHasRecognitionPattern;
      }

    public RestaurantOrderingMenuDataRecognitionPatternJSON   getRecognitionPattern()
      {
        Debug.Assert(flagHasRecognitionPattern);
        return storeRecognitionPattern;
      }

    public bool  hasASRFallbackRecognitionPattern()
      {
        return flagHasASRFallbackRecognitionPattern;
      }

    public RestaurantOrderingMenuDataRecognitionPatternJSON   getASRFallbackRecognitionPattern()
      {
        Debug.Assert(flagHasASRFallbackRecognitionPattern);
        return storeASRFallbackRecognitionPattern;
      }

    public bool  hasCoreTagKeys()
      {
        return flagHasCoreTagKeys;
      }

    public int  countOfCoreTagKeys()
      {
        Debug.Assert(flagHasCoreTagKeys);
        return storeCoreTagKeys.Count;
      }

    public string  elementOfCoreTagKeys(int element_num)
      {
        Debug.Assert(flagHasCoreTagKeys);
        return storeCoreTagKeys[element_num];
      }

    public List< string >  getCoreTagKeys()
      {
        Debug.Assert(flagHasCoreTagKeys);
        return storeCoreTagKeys;
      }

    public bool  hasRestaurantTagKeys()
      {
        return flagHasRestaurantTagKeys;
      }

    public int  countOfRestaurantTagKeys()
      {
        Debug.Assert(flagHasRestaurantTagKeys);
        return storeRestaurantTagKeys.Count;
      }

    public string  elementOfRestaurantTagKeys(int element_num)
      {
        Debug.Assert(flagHasRestaurantTagKeys);
        return storeRestaurantTagKeys[element_num];
      }

    public List< string >  getRestaurantTagKeys()
      {
        Debug.Assert(flagHasRestaurantTagKeys);
        return storeRestaurantTagKeys;
      }

    public bool  hasPointOfSaleData()
      {
        return flagHasPointOfSaleData;
      }

    public PointOfSaleCatalogEntityJSON   getPointOfSaleData()
      {
        Debug.Assert(flagHasPointOfSaleData);
        return storePointOfSaleData;
      }

    public bool  hasInternalName()
      {
        return flagHasInternalName;
      }

    public string  getInternalName()
      {
        Debug.Assert(flagHasInternalName);
        return storeInternalName;
      }

    public bool  hasDescription()
      {
        return flagHasDescription;
      }

    public string  getDescription()
      {
        Debug.Assert(flagHasDescription);
        return storeDescription;
      }

    public bool  hasImageURLs()
      {
        return flagHasImageURLs;
      }

    public int  countOfImageURLs()
      {
        Debug.Assert(flagHasImageURLs);
        return storeImageURLs.Count;
      }

    public string  elementOfImageURLs(int element_num)
      {
        Debug.Assert(flagHasImageURLs);
        return storeImageURLs[element_num];
      }

    public List< string >  getImageURLs()
      {
        Debug.Assert(flagHasImageURLs);
        return storeImageURLs;
      }


    public abstract int extraRestaurantOrderingMenuDataEntityComponentCount();
    public abstract string extraRestaurantOrderingMenuDataEntityComponentKey(int component_num);
    public abstract JSONValue extraRestaurantOrderingMenuDataEntityComponentValue(int component_num);
    public abstract JSONValue extraRestaurantOrderingMenuDataEntityLookup(string field_name);

    public void setID(string new_value)
      {
        flagHasID = true;
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void setDisplayName(string new_value)
      {
        flagHasDisplayName = true;
        storeDisplayName = new_value;
      }
    public void unsetDisplayName()
      {
        flagHasDisplayName = false;
      }
    public void setWrittenName(string new_value)
      {
        flagHasWrittenName = true;
        storeWrittenName = new_value;
      }
    public void unsetWrittenName()
      {
        flagHasWrittenName = false;
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
    public void setSpokenNameSSML(string new_value)
      {
        flagHasSpokenNameSSML = true;
        storeSpokenNameSSML = new_value;
      }
    public void unsetSpokenNameSSML()
      {
        flagHasSpokenNameSSML = false;
      }
    public void setRecognitionPattern(RestaurantOrderingMenuDataRecognitionPatternJSON  new_value)
      {
        if (flagHasRecognitionPattern)
          {
          }
        flagHasRecognitionPattern = true;
        storeRecognitionPattern = new_value;
      }
    public void unsetRecognitionPattern()
      {
        if (flagHasRecognitionPattern)
          {
          }
        flagHasRecognitionPattern = false;
      }
    public void setASRFallbackRecognitionPattern(RestaurantOrderingMenuDataRecognitionPatternJSON  new_value)
      {
        if (flagHasASRFallbackRecognitionPattern)
          {
          }
        flagHasASRFallbackRecognitionPattern = true;
        storeASRFallbackRecognitionPattern = new_value;
      }
    public void unsetASRFallbackRecognitionPattern()
      {
        if (flagHasASRFallbackRecognitionPattern)
          {
          }
        flagHasASRFallbackRecognitionPattern = false;
      }
    public void initCoreTagKeys()
      {
        flagHasCoreTagKeys = true;
        storeCoreTagKeys.Clear();
      }
    public void appendCoreTagKeys(string to_append)
      {
        if (!flagHasCoreTagKeys)
          {
            flagHasCoreTagKeys = true;
            storeCoreTagKeys.Clear();
          }
        Debug.Assert(flagHasCoreTagKeys);
        storeCoreTagKeys.Add(to_append);
      }
    public void unsetCoreTagKeys()
      {
        flagHasCoreTagKeys = false;
        storeCoreTagKeys.Clear();
      }
    public void initRestaurantTagKeys()
      {
        flagHasRestaurantTagKeys = true;
        storeRestaurantTagKeys.Clear();
      }
    public void appendRestaurantTagKeys(string to_append)
      {
        if (!flagHasRestaurantTagKeys)
          {
            flagHasRestaurantTagKeys = true;
            storeRestaurantTagKeys.Clear();
          }
        Debug.Assert(flagHasRestaurantTagKeys);
        storeRestaurantTagKeys.Add(to_append);
      }
    public void unsetRestaurantTagKeys()
      {
        flagHasRestaurantTagKeys = false;
        storeRestaurantTagKeys.Clear();
      }
    public void setPointOfSaleData(PointOfSaleCatalogEntityJSON  new_value)
      {
        if (flagHasPointOfSaleData)
          {
          }
        flagHasPointOfSaleData = true;
        storePointOfSaleData = new_value;
      }
    public void unsetPointOfSaleData()
      {
        if (flagHasPointOfSaleData)
          {
          }
        flagHasPointOfSaleData = false;
      }
    public void setInternalName(string new_value)
      {
        flagHasInternalName = true;
        storeInternalName = new_value;
      }
    public void unsetInternalName()
      {
        flagHasInternalName = false;
      }
    public void setDescription(string new_value)
      {
        flagHasDescription = true;
        storeDescription = new_value;
      }
    public void unsetDescription()
      {
        flagHasDescription = false;
      }
    public void initImageURLs()
      {
        flagHasImageURLs = true;
        storeImageURLs.Clear();
      }
    public void appendImageURLs(string to_append)
      {
        if (!flagHasImageURLs)
          {
            flagHasImageURLs = true;
            storeImageURLs.Clear();
          }
        Debug.Assert(flagHasImageURLs);
        storeImageURLs.Add(to_append);
      }
    public void unsetImageURLs()
      {
        flagHasImageURLs = false;
        storeImageURLs.Clear();
      }

    public abstract void extraRestaurantOrderingMenuDataEntityAppendPair(string key, JSONValue new_component);
    public abstract void extraRestaurantOrderingMenuDataEntitySetField(string key, JSONValue new_component);

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
        handler.pair("EntityKind", getEntityKind());
        Debug.Assert(partial_allowed || flagHasID);
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.string_value(storeID);
          }
        Debug.Assert(partial_allowed || flagHasDisplayName);
        if (flagHasDisplayName)
          {
            handler.start_pair("DisplayName");
            handler.string_value(storeDisplayName);
          }
        if (flagHasWrittenName)
          {
            handler.start_pair("WrittenName");
            handler.string_value(storeWrittenName);
          }
        if (flagHasSpokenName)
          {
            handler.start_pair("SpokenName");
            handler.string_value(storeSpokenName);
          }
        if (flagHasSpokenNameSSML)
          {
            handler.start_pair("SpokenNameSSML");
            handler.string_value(storeSpokenNameSSML);
          }
        if (flagHasRecognitionPattern)
          {
            handler.start_pair("RecognitionPattern");
            if (partial_allowed)
                storeRecognitionPattern.write_partial_as_json(handler);
            else
                storeRecognitionPattern.write_as_json(handler);
          }
        if (flagHasASRFallbackRecognitionPattern)
          {
            handler.start_pair("ASRFallbackRecognitionPattern");
            if (partial_allowed)
                storeASRFallbackRecognitionPattern.write_partial_as_json(handler);
            else
                storeASRFallbackRecognitionPattern.write_as_json(handler);
          }
        if (flagHasCoreTagKeys)
          {
            handler.start_pair("CoreTagKeys");
            handler.start_array();
            for (int num1 = 0; num1 < storeCoreTagKeys.Count; ++num1)
              {
                handler.string_value(storeCoreTagKeys[num1]);
              }
            handler.finish_array();
          }
        if (flagHasRestaurantTagKeys)
          {
            handler.start_pair("RestaurantTagKeys");
            handler.start_array();
            for (int num2 = 0; num2 < storeRestaurantTagKeys.Count; ++num2)
              {
                handler.string_value(storeRestaurantTagKeys[num2]);
              }
            handler.finish_array();
          }
        if (flagHasPointOfSaleData)
          {
            handler.start_pair("PointOfSaleData");
            if (partial_allowed)
                storePointOfSaleData.write_partial_as_json(handler);
            else
                storePointOfSaleData.write_as_json(handler);
          }
        if (flagHasInternalName)
          {
            handler.start_pair("InternalName");
            handler.string_value(storeInternalName);
          }
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        if (flagHasImageURLs)
          {
            handler.start_pair("ImageURLs");
            handler.start_array();
            for (int num3 = 0; num3 < storeImageURLs.Count; ++num3)
              {
                handler.string_value(storeImageURLs[num3]);
              }
            handler.finish_array();
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
        if (!(hasDisplayName()))
          {
            return "When parsing the object for %what%, the \"DisplayName\" field was missing.";
          }
        return null;
      }

    public static RestaurantOrderingMenuDataEntityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataEntity", ignore_extras);
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
    public static RestaurantOrderingMenuDataEntityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingMenuDataEntityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataEntity", ignore_extras);
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
    public static RestaurantOrderingMenuDataEntityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingMenuDataEntityJSON from_text(string text, bool ignore_extras)
      {
        RestaurantOrderingMenuDataEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataEntity", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantOrderingMenuDataEntityJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantOrderingMenuDataEntityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantOrderingMenuDataEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataEntity", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorID;
        private JSONHoldingStringGenerator fieldGeneratorDisplayName;
        private JSONHoldingStringGenerator fieldGeneratorWrittenName;
        private JSONHoldingStringGenerator fieldGeneratorSpokenName;
        private JSONHoldingStringGenerator fieldGeneratorSpokenNameSSML;
        private RestaurantOrderingMenuDataRecognitionPatternJSON.HoldingGenerator fieldGeneratorRecognitionPattern;
        private RestaurantOrderingMenuDataRecognitionPatternJSON.HoldingGenerator fieldGeneratorASRFallbackRecognitionPattern;
        private JSONHoldingStringArrayGenerator fieldGeneratorCoreTagKeys;
        private JSONHoldingStringArrayGenerator fieldGeneratorRestaurantTagKeys;
        private PointOfSaleCatalogEntityJSON.HoldingGenerator fieldGeneratorPointOfSaleData;
        private JSONHoldingStringGenerator fieldGeneratorInternalName;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private JSONHoldingStringArrayGenerator fieldGeneratorImageURLs;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `EntityKind' field is missing.");
            RestaurantOrderingMenuDataEntityJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantOrderingMenuDataEntityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getRestaurantOrderingMenuDataEntityJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `EntityKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(RestaurantOrderingMenuDataEntityJSON result)
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
            if (fieldGeneratorDisplayName.have_value)
              {
                result.setDisplayName(fieldGeneratorDisplayName.value);
                fieldGeneratorDisplayName.have_value = false;
              }
            else if ((!(result.hasDisplayName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DisplayName\" field was missing.");
              }
            if (fieldGeneratorWrittenName.have_value)
              {
                result.setWrittenName(fieldGeneratorWrittenName.value);
                fieldGeneratorWrittenName.have_value = false;
              }
            if (fieldGeneratorSpokenName.have_value)
              {
                result.setSpokenName(fieldGeneratorSpokenName.value);
                fieldGeneratorSpokenName.have_value = false;
              }
            if (fieldGeneratorSpokenNameSSML.have_value)
              {
                result.setSpokenNameSSML(fieldGeneratorSpokenNameSSML.value);
                fieldGeneratorSpokenNameSSML.have_value = false;
              }
            if (fieldGeneratorRecognitionPattern.have_value)
              {
                result.setRecognitionPattern(fieldGeneratorRecognitionPattern.value);
                fieldGeneratorRecognitionPattern.have_value = false;
              }
            if (fieldGeneratorASRFallbackRecognitionPattern.have_value)
              {
                result.setASRFallbackRecognitionPattern(fieldGeneratorASRFallbackRecognitionPattern.value);
                fieldGeneratorASRFallbackRecognitionPattern.have_value = false;
              }
            if (fieldGeneratorCoreTagKeys.have_value)
              {
                result.initCoreTagKeys();
                int count = fieldGeneratorCoreTagKeys.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCoreTagKeys(fieldGeneratorCoreTagKeys.value[num]);
                  }
                fieldGeneratorCoreTagKeys.value.Clear();
                fieldGeneratorCoreTagKeys.have_value = false;
              }
            if (fieldGeneratorRestaurantTagKeys.have_value)
              {
                result.initRestaurantTagKeys();
                int count = fieldGeneratorRestaurantTagKeys.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRestaurantTagKeys(fieldGeneratorRestaurantTagKeys.value[num]);
                  }
                fieldGeneratorRestaurantTagKeys.value.Clear();
                fieldGeneratorRestaurantTagKeys.have_value = false;
              }
            if (fieldGeneratorPointOfSaleData.have_value)
              {
                result.setPointOfSaleData(fieldGeneratorPointOfSaleData.value);
                fieldGeneratorPointOfSaleData.have_value = false;
              }
            if (fieldGeneratorInternalName.have_value)
              {
                result.setInternalName(fieldGeneratorInternalName.value);
                fieldGeneratorInternalName.have_value = false;
              }
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorImageURLs.have_value)
              {
                result.initImageURLs();
                int count = fieldGeneratorImageURLs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendImageURLs(fieldGeneratorImageURLs.value[num]);
                  }
                fieldGeneratorImageURLs.value.Clear();
                fieldGeneratorImageURLs.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantOrderingMenuDataEntityJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "SRFallbackRecognitionPattern", 0, 28, false) == 0) && (field_name.Length == 29))
                        return fieldGeneratorASRFallbackRecognitionPattern;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "oreTagKeys", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCoreTagKeys;
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "scription", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDescription;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "splayName", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDisplayName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ntityKind", 0, 9, false) == 0) && (field_name.Length == 10))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'D':
                            if (field_name.Length == 2)
                                return fieldGeneratorID;
                            break;
                        case 'm':
                            if ((String.Compare(field_name, 2, "ageURLs", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorImageURLs;
                            break;
                        case 'n':
                            if ((String.Compare(field_name, 2, "ternalName", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorInternalName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ointOfSaleData", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorPointOfSaleData;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'c':
                                if ((String.Compare(field_name, 3, "ognitionPattern", 0, 15, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorRecognitionPattern;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 3, "taurantTagKeys", 0, 14, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorRestaurantTagKeys;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "pokenName", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorSpokenName;
                          }
                        switch (field_name[10])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 11, "SML", 0, 3, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorSpokenNameSSML;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenName", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorWrittenName;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorDisplayName = new JSONHoldingStringGenerator("field \"DisplayName\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorWrittenName = new JSONHoldingStringGenerator("field \"WrittenName\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorSpokenNameSSML = new JSONHoldingStringGenerator("field \"SpokenNameSSML\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorRecognitionPattern = new RestaurantOrderingMenuDataRecognitionPatternJSON.HoldingGenerator("field \"RecognitionPattern\" of the RestaurantOrderingMenuDataEntity class", ignore_extras);
            fieldGeneratorASRFallbackRecognitionPattern = new RestaurantOrderingMenuDataRecognitionPatternJSON.HoldingGenerator("field \"ASRFallbackRecognitionPattern\" of the RestaurantOrderingMenuDataEntity class", ignore_extras);
            fieldGeneratorCoreTagKeys = new JSONHoldingStringArrayGenerator("field \"CoreTagKeys\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorRestaurantTagKeys = new JSONHoldingStringArrayGenerator("field \"RestaurantTagKeys\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorPointOfSaleData = new PointOfSaleCatalogEntityJSON.HoldingGenerator("field \"PointOfSaleData\" of the RestaurantOrderingMenuDataEntity class", ignore_extras);
            fieldGeneratorInternalName = new JSONHoldingStringGenerator("field \"InternalName\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorImageURLs = new JSONHoldingStringArrayGenerator("field \"ImageURLs\" of the RestaurantOrderingMenuDataEntity class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"EntityKind\" of the RestaurantOrderingMenuDataEntity class");
            set_what("the RestaurantOrderingMenuDataEntity class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorDisplayName = new JSONHoldingStringGenerator("field \"DisplayName\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorWrittenName = new JSONHoldingStringGenerator("field \"WrittenName\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorSpokenNameSSML = new JSONHoldingStringGenerator("field \"SpokenNameSSML\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorRecognitionPattern = new RestaurantOrderingMenuDataRecognitionPatternJSON.HoldingGenerator("field \"RecognitionPattern\" of the RestaurantOrderingMenuDataEntity class", false);
            fieldGeneratorASRFallbackRecognitionPattern = new RestaurantOrderingMenuDataRecognitionPatternJSON.HoldingGenerator("field \"ASRFallbackRecognitionPattern\" of the RestaurantOrderingMenuDataEntity class", false);
            fieldGeneratorCoreTagKeys = new JSONHoldingStringArrayGenerator("field \"CoreTagKeys\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorRestaurantTagKeys = new JSONHoldingStringArrayGenerator("field \"RestaurantTagKeys\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorPointOfSaleData = new PointOfSaleCatalogEntityJSON.HoldingGenerator("field \"PointOfSaleData\" of the RestaurantOrderingMenuDataEntity class", false);
            fieldGeneratorInternalName = new JSONHoldingStringGenerator("field \"InternalName\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the RestaurantOrderingMenuDataEntity class");
            fieldGeneratorImageURLs = new JSONHoldingStringArrayGenerator("field \"ImageURLs\" of the RestaurantOrderingMenuDataEntity class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"EntityKind\" of the RestaurantOrderingMenuDataEntity class");
            set_what("the RestaurantOrderingMenuDataEntity class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorID.reset();
            fieldGeneratorDisplayName.reset();
            fieldGeneratorWrittenName.reset();
            fieldGeneratorSpokenName.reset();
            fieldGeneratorSpokenNameSSML.reset();
            fieldGeneratorRecognitionPattern.reset();
            fieldGeneratorASRFallbackRecognitionPattern.reset();
            fieldGeneratorCoreTagKeys.reset();
            fieldGeneratorRestaurantTagKeys.reset();
            fieldGeneratorPointOfSaleData.reset();
            fieldGeneratorInternalName.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorImageURLs.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRecognitionPattern.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorASRFallbackRecognitionPattern.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPointOfSaleData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRecognitionPattern.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorASRFallbackRecognitionPattern.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPointOfSaleData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantOrderingMenuDataEntityJSON  result)
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
        public RestaurantOrderingMenuDataEntityJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantOrderingMenuDataEntityJSON  result)
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
    protected virtual void handle_result(List<RestaurantOrderingMenuDataEntityJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantOrderingMenuDataEntityJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantOrderingMenuDataEntityJSON>();
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
    public List<RestaurantOrderingMenuDataEntityJSON> value;
  };
    class GenericRestaurantOrderingMenuDataEntityJSON : RestaurantOrderingMenuDataEntityJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericRestaurantOrderingMenuDataEntityJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getEntityKind()  { return key; }
        public override int extraRestaurantOrderingMenuDataEntityComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraRestaurantOrderingMenuDataEntityComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraRestaurantOrderingMenuDataEntityComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraRestaurantOrderingMenuDataEntityLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraRestaurantOrderingMenuDataEntityAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraRestaurantOrderingMenuDataEntitySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraRestaurantOrderingMenuDataEntityLookup(key);
            if (old_field == null)
              {
                extraRestaurantOrderingMenuDataEntityAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static RestaurantOrderingMenuDataEntityJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'I':
            if ((String.Compare(key, 1, "tem", 0, 3, false) == 0) && (key.Length == 4))
              {
                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("ItemKind") ? other_field_index["ItemKind"] : null));
                if (key_value == null)
                    throw new Exception("The `ItemKind' field is missing.");
                JSONStringValue key_string_value = key_value.string_value();
                if (key_string_value == null)
                    throw new Exception("The `ItemKind' field has a non-string value.");
                return RestaurantOrderingMenuDataItemJSON.createForKey(key_string_value.getData(), other_field_index);
              }
            break;
        case 'M':
            switch (key[1])
              {
                case 'e':
                    if ((String.Compare(key, 2, "nu", 0, 2, false) == 0) && (key.Length == 4))
                        return new RestaurantOrderingMenuDataMenuJSON();
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "difierGroup", 0, 11, false) == 0) && (key.Length == 13))
                        return new RestaurantOrderingMenuDataModifierGroupJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'S':
            switch (key[1])
              {
                case 'e':
                    if ((String.Compare(key, 2, "ction", 0, 5, false) == 0) && (key.Length == 7))
                        return new RestaurantOrderingMenuDataSectionJSON();
                    break;
                case 't':
                    if ((String.Compare(key, 2, "ore", 0, 3, false) == 0) && (key.Length == 5))
                        return new RestaurantOrderingMenuDataStoreJSON();
                    break;
                default:
                    break;
              }
            break;
        default:
            break;
      }

        return new GenericRestaurantOrderingMenuDataEntityJSON(key);
      }
  };
