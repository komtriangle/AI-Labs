/* file "AppSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AppSpecJSON : JSONBase
  {
    public enum TypePlatformKnownValues
      {
        Platform_Android,
        Platform_iOS,
        Platform__none
      };
    public struct TypePlatform
      {
        public bool in_known_list;
        public string string_value;
        public TypePlatformKnownValues list_value;
      };

    public static TypePlatformKnownValues  stringToPlatform(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ndroid", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypePlatformKnownValues.Platform_Android;
                break;
            case 'i':
                if ((String.Compare(chars, 1, "OS", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypePlatformKnownValues.Platform_iOS;
                break;
            default:
                break;
          }
        return TypePlatformKnownValues.Platform__none;
      }

    public static string  stringFromPlatform(TypePlatformKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypePlatformKnownValues.Platform_Android:
                return "Android";
            case TypePlatformKnownValues.Platform_iOS:
                return "iOS";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasPlatform;
    private TypePlatform storePlatform;
    private bool flagHasAppID;
    private string storeAppID;
    private bool flagHasLaunchURLScheme;
    private string storeLaunchURLScheme;
    private bool flagHasAppName;
    private string storeAppName;
    private bool flagHasAppSpokenName;
    private string storeAppSpokenName;
    private bool flagHasAliases;
    private List< string > storeAliases;
    private bool flagHasPopularityMeasure;
    private double storePopularityMeasure;
    private string textStorePopularityMeasure;
    private bool flagHasCompanyName;
    private string storeCompanyName;
    private bool flagHasAppPrice;
    private double storeAppPrice;
    private string textStoreAppPrice;
    private bool flagHasAppRating;
    private double storeAppRating;
    private string textStoreAppRating;
    private bool flagHasAppURL;
    private string storeAppURL;
    private bool flagHasAppIconURL;
    private string storeAppIconURL;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPlatform(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Platform of AppSpecJSON is not a string.");
        TypePlatform the_open_enum = new TypePlatform();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ndroid", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePlatformKnownValues.Platform_Android;
                        goto open_enum_is_done;
                      }
                break;
            case 'i':
                if ((String.Compare(json_string.getData(), 1, "OS", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePlatformKnownValues.Platform_iOS;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setPlatform(the_open_enum);
      }


    private void  fromJSONAppID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AppID of AppSpecJSON is not a string.");
        setAppID(json_string.getData());
      }


    private void  fromJSONLaunchURLScheme(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LaunchURLScheme of AppSpecJSON is not a string.");
        setLaunchURLScheme(json_string.getData());
      }


    private void  fromJSONAppName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AppName of AppSpecJSON is not a string.");
        setAppName(json_string.getData());
      }


    private void  fromJSONAppSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AppSpokenName of AppSpecJSON is not a string.");
        setAppSpokenName(json_string.getData());
      }


    private void  fromJSONAliases(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Aliases of AppSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Aliases1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Aliases of AppSpecJSON is not a string.");
            vector_Aliases1.Add(json_string.getData());
          }
        initAliases();
        for (int num1 = 0; num1 < vector_Aliases1.Count; ++num1)
            appendAliases(vector_Aliases1[num1]);
        for (int num1 = 0; num1 < vector_Aliases1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPopularityMeasure(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PopularityMeasure of AppSpecJSON is not a number.");
              }
          }
        setPopularityMeasureText(the_rational_text);
      }


    private void  fromJSONCompanyName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CompanyName of AppSpecJSON is not a string.");
        setCompanyName(json_string.getData());
      }


    private void  fromJSONAppPrice(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AppPrice of AppSpecJSON is not a number.");
              }
          }
        setAppPriceText(the_rational_text);
      }


    private void  fromJSONAppRating(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AppRating of AppSpecJSON is not a number.");
              }
          }
        setAppRatingText(the_rational_text);
      }


    private void  fromJSONAppURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AppURL of AppSpecJSON is not a string.");
        setAppURL(json_string.getData());
      }


    private void  fromJSONAppIconURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AppIconURL of AppSpecJSON is not a string.");
        setAppIconURL(json_string.getData());
      }


    public AppSpecJSON()
      {
        flagHasPlatform = false;
        flagHasAppID = false;
        flagHasLaunchURLScheme = false;
        flagHasAppName = false;
        flagHasAppSpokenName = false;
        flagHasAliases = false;
        flagHasPopularityMeasure = false;
        flagHasCompanyName = false;
        flagHasAppPrice = false;
        flagHasAppRating = false;
        flagHasAppURL = false;
        flagHasAppIconURL = false;
        storeAliases = new List< string >();
        storePopularityMeasure = 1;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPlatform()
      {
        return flagHasPlatform;
      }

    public TypePlatform  getPlatform()
      {
        Debug.Assert(flagHasPlatform);
        return storePlatform;
      }

    public string  getPlatformAsString()
      {
        TypePlatform result = getPlatform();
        if (result.in_known_list)
            return stringFromPlatform(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasAppID()
      {
        return flagHasAppID;
      }

    public string  getAppID()
      {
        Debug.Assert(flagHasAppID);
        return storeAppID;
      }

    public bool  hasLaunchURLScheme()
      {
        return flagHasLaunchURLScheme;
      }

    public string  getLaunchURLScheme()
      {
        Debug.Assert(flagHasLaunchURLScheme);
        return storeLaunchURLScheme;
      }

    public bool  hasAppName()
      {
        return flagHasAppName;
      }

    public string  getAppName()
      {
        Debug.Assert(flagHasAppName);
        return storeAppName;
      }

    public bool  hasAppSpokenName()
      {
        return flagHasAppSpokenName;
      }

    public string  getAppSpokenName()
      {
        Debug.Assert(flagHasAppSpokenName);
        return storeAppSpokenName;
      }

    public bool  hasAliases()
      {
        return flagHasAliases;
      }

    public int  countOfAliases()
      {
        Debug.Assert(flagHasAliases);
        return storeAliases.Count;
      }

    public string  elementOfAliases(int element_num)
      {
        Debug.Assert(flagHasAliases);
        return storeAliases[element_num];
      }

    public List< string >  getAliases()
      {
        Debug.Assert(flagHasAliases);
        return storeAliases;
      }

    public bool  hasPopularityMeasure()
      {
        return flagHasPopularityMeasure;
      }

    public double  getPopularityMeasure()
      {
        if (textStorePopularityMeasure != "")
          {
            return Double.Parse(textStorePopularityMeasure);
          }
        return storePopularityMeasure;
      }

    public string  getPopularityMeasureAsText()
      {
        if (textStorePopularityMeasure == "")
          {
            return Convert.ToString(storePopularityMeasure);
          }
        else
          {
            return (textStorePopularityMeasure);
          }
      }

    public bool  hasCompanyName()
      {
        return flagHasCompanyName;
      }

    public string  getCompanyName()
      {
        Debug.Assert(flagHasCompanyName);
        return storeCompanyName;
      }

    public bool  hasAppPrice()
      {
        return flagHasAppPrice;
      }

    public double  getAppPrice()
      {
        Debug.Assert(flagHasAppPrice);
        if (textStoreAppPrice != "")
          {
            return Double.Parse(textStoreAppPrice);
          }
        return storeAppPrice;
      }

    public string  getAppPriceAsText()
      {
        Debug.Assert(flagHasAppPrice);
        if (textStoreAppPrice == "")
          {
            return Convert.ToString(storeAppPrice);
          }
        else
          {
            return (textStoreAppPrice);
          }
      }

    public bool  hasAppRating()
      {
        return flagHasAppRating;
      }

    public double  getAppRating()
      {
        Debug.Assert(flagHasAppRating);
        if (textStoreAppRating != "")
          {
            return Double.Parse(textStoreAppRating);
          }
        return storeAppRating;
      }

    public string  getAppRatingAsText()
      {
        Debug.Assert(flagHasAppRating);
        if (textStoreAppRating == "")
          {
            return Convert.ToString(storeAppRating);
          }
        else
          {
            return (textStoreAppRating);
          }
      }

    public bool  hasAppURL()
      {
        return flagHasAppURL;
      }

    public string  getAppURL()
      {
        Debug.Assert(flagHasAppURL);
        return storeAppURL;
      }

    public bool  hasAppIconURL()
      {
        return flagHasAppIconURL;
      }

    public string  getAppIconURL()
      {
        Debug.Assert(flagHasAppIconURL);
        return storeAppIconURL;
      }


    public virtual int extraAppSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAppSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAppSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAppSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPlatform(TypePlatform new_value)
      {
        flagHasPlatform = true;
        storePlatform = new_value;
      }
    public void setPlatform(string chars)
      {
        TypePlatformKnownValues known = stringToPlatform(chars);
        TypePlatform new_value = new TypePlatform();
        if (known == TypePlatformKnownValues.Platform__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPlatform(new_value);
      }
    public void setPlatform(TypePlatformKnownValues new_value)
      {
        TypePlatform new_full_value = new TypePlatform();
        Debug.Assert(new_value != TypePlatformKnownValues.Platform__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setPlatform(new_full_value);
      }
    public void unsetPlatform()
      {
        flagHasPlatform = false;
      }
    public void setAppID(string new_value)
      {
        flagHasAppID = true;
        storeAppID = new_value;
      }
    public void unsetAppID()
      {
        flagHasAppID = false;
      }
    public void setLaunchURLScheme(string new_value)
      {
        flagHasLaunchURLScheme = true;
        storeLaunchURLScheme = new_value;
      }
    public void unsetLaunchURLScheme()
      {
        flagHasLaunchURLScheme = false;
      }
    public void setAppName(string new_value)
      {
        flagHasAppName = true;
        storeAppName = new_value;
      }
    public void unsetAppName()
      {
        flagHasAppName = false;
      }
    public void setAppSpokenName(string new_value)
      {
        flagHasAppSpokenName = true;
        storeAppSpokenName = new_value;
      }
    public void unsetAppSpokenName()
      {
        flagHasAppSpokenName = false;
      }
    public void initAliases()
      {
        flagHasAliases = true;
        storeAliases.Clear();
      }
    public void appendAliases(string to_append)
      {
        if (!flagHasAliases)
          {
            flagHasAliases = true;
            storeAliases.Clear();
          }
        Debug.Assert(flagHasAliases);
        storeAliases.Add(to_append);
      }
    public void unsetAliases()
      {
        flagHasAliases = false;
        storeAliases.Clear();
      }
    public void setPopularityMeasure(double new_value)
      {
        flagHasPopularityMeasure = true;
        storePopularityMeasure = new_value;
        textStorePopularityMeasure = "";
      }
    public void setPopularityMeasureText(string new_value)
      {
        flagHasPopularityMeasure = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field PopularityMeasure of AppSpecJSON is not a valid number.");
        textStorePopularityMeasure = new_value;
      }
    public void unsetPopularityMeasure()
      {
        flagHasPopularityMeasure = false;
      }
    public void setCompanyName(string new_value)
      {
        flagHasCompanyName = true;
        storeCompanyName = new_value;
      }
    public void unsetCompanyName()
      {
        flagHasCompanyName = false;
      }
    public void setAppPrice(double new_value)
      {
        flagHasAppPrice = true;
        storeAppPrice = new_value;
        textStoreAppPrice = "";
      }
    public void setAppPriceText(string new_value)
      {
        flagHasAppPrice = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field AppPrice of AppSpecJSON is not a valid number.");
        textStoreAppPrice = new_value;
      }
    public void unsetAppPrice()
      {
        flagHasAppPrice = false;
      }
    public void setAppRating(double new_value)
      {
        flagHasAppRating = true;
        storeAppRating = new_value;
        textStoreAppRating = "";
      }
    public void setAppRatingText(string new_value)
      {
        flagHasAppRating = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field AppRating of AppSpecJSON is not a valid number.");
        textStoreAppRating = new_value;
      }
    public void unsetAppRating()
      {
        flagHasAppRating = false;
      }
    public void setAppURL(string new_value)
      {
        flagHasAppURL = true;
        storeAppURL = new_value;
      }
    public void unsetAppURL()
      {
        flagHasAppURL = false;
      }
    public void setAppIconURL(string new_value)
      {
        flagHasAppIconURL = true;
        storeAppIconURL = new_value;
      }
    public void unsetAppIconURL()
      {
        flagHasAppIconURL = false;
      }

    public virtual void extraAppSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAppSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAppSpecLookup(key);
        if (old_field == null)
          {
            extraAppSpecAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPlatform);
        if (flagHasPlatform)
          {
            handler.start_pair("Platform");
            if (storePlatform.in_known_list)
              {
                switch (storePlatform.list_value)
                  {
                    case TypePlatformKnownValues.Platform_Android:
                        handler.string_value("Android");
                        break;
                    case TypePlatformKnownValues.Platform_iOS:
                        handler.string_value("iOS");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storePlatform.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasAppID);
        if (flagHasAppID)
          {
            handler.start_pair("AppID");
            handler.string_value(storeAppID);
          }
        Debug.Assert(partial_allowed || flagHasLaunchURLScheme);
        if (flagHasLaunchURLScheme)
          {
            handler.start_pair("LaunchURLScheme");
            handler.string_value(storeLaunchURLScheme);
          }
        Debug.Assert(partial_allowed || flagHasAppName);
        if (flagHasAppName)
          {
            handler.start_pair("AppName");
            handler.string_value(storeAppName);
          }
        Debug.Assert(partial_allowed || flagHasAppSpokenName);
        if (flagHasAppSpokenName)
          {
            handler.start_pair("AppSpokenName");
            handler.string_value(storeAppSpokenName);
          }
        if (flagHasAliases)
          {
            handler.start_pair("Aliases");
            handler.start_array();
            for (int num1 = 0; num1 < storeAliases.Count; ++num1)
              {
                handler.string_value(storeAliases[num1]);
              }
            handler.finish_array();
          }
        if (flagHasPopularityMeasure)
          {
            handler.start_pair("PopularityMeasure");
            if (textStorePopularityMeasure != "")
                handler.number_value(textStorePopularityMeasure);
            else if (((double)(long)storePopularityMeasure) == storePopularityMeasure)
                handler.number_value((long)storePopularityMeasure);
            else
                handler.number_value(storePopularityMeasure);
          }
        if (flagHasCompanyName)
          {
            handler.start_pair("CompanyName");
            handler.string_value(storeCompanyName);
          }
        if (flagHasAppPrice)
          {
            handler.start_pair("AppPrice");
            if (textStoreAppPrice != "")
                handler.number_value(textStoreAppPrice);
            else if (((double)(long)storeAppPrice) == storeAppPrice)
                handler.number_value((long)storeAppPrice);
            else
                handler.number_value(storeAppPrice);
          }
        if (flagHasAppRating)
          {
            handler.start_pair("AppRating");
            if (textStoreAppRating != "")
                handler.number_value(textStoreAppRating);
            else if (((double)(long)storeAppRating) == storeAppRating)
                handler.number_value((long)storeAppRating);
            else
                handler.number_value(storeAppRating);
          }
        if (flagHasAppURL)
          {
            handler.start_pair("AppURL");
            handler.string_value(storeAppURL);
          }
        if (flagHasAppIconURL)
          {
            handler.start_pair("AppIconURL");
            handler.string_value(storeAppIconURL);
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
        if (!(hasPlatform()))
          {
            return "When parsing the object for %what%, the \"Platform\" field was missing.";
          }
        if (!(hasAppID()))
          {
            return "When parsing the object for %what%, the \"AppID\" field was missing.";
          }
        if (!(hasLaunchURLScheme()))
          {
            return "When parsing the object for %what%, the \"LaunchURLScheme\" field was missing.";
          }
        if (!(hasAppName()))
          {
            return "When parsing the object for %what%, the \"AppName\" field was missing.";
          }
        if (!(hasAppSpokenName()))
          {
            return "When parsing the object for %what%, the \"AppSpokenName\" field was missing.";
          }
        return null;
      }

    public static AppSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AppSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AppSpec", ignore_extras);
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
    public static AppSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AppSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AppSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AppSpec", ignore_extras);
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
    public static AppSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AppSpecJSON from_text(string text, bool ignore_extras)
      {
        AppSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AppSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AppSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AppSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AppSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AppSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorPlatform : JSONStringGenerator
          {
            protected FieldGeneratorPlatform(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorPlatform()
              {
              }
            protected override void handle_result(string result)
              {
                TypePlatformKnownValues known = stringToPlatform(result);
                TypePlatform new_value = new TypePlatform();
                if (known == TypePlatformKnownValues.Platform__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypePlatform result);
          };
    private class FieldHoldingGeneratorPlatform : FieldGeneratorPlatform
  {
    protected override void handle_result(TypePlatform result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorPlatform(String what)
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
    public TypePlatform value;
  };
    private class FieldHoldingArrayGeneratorPlatform : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPlatform
      {
        private FieldHoldingArrayGeneratorPlatform top;

        protected override void handle_result(TypePlatform result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPlatform init_top)
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
    protected virtual void handle_result(List<TypePlatform> result)
      {
      }

    public FieldHoldingArrayGeneratorPlatform(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePlatform>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPlatform()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePlatform>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePlatform> value;
  };
        private FieldHoldingGeneratorPlatform fieldGeneratorPlatform;
        private JSONHoldingStringGenerator fieldGeneratorAppID;
        private JSONHoldingStringGenerator fieldGeneratorLaunchURLScheme;
        private JSONHoldingStringGenerator fieldGeneratorAppName;
        private JSONHoldingStringGenerator fieldGeneratorAppSpokenName;
        private JSONHoldingStringArrayGenerator fieldGeneratorAliases;
        private JSONHoldingNumberTextGenerator fieldGeneratorPopularityMeasure;
        private JSONHoldingStringGenerator fieldGeneratorCompanyName;
        private JSONHoldingNumberTextGenerator fieldGeneratorAppPrice;
        private JSONHoldingNumberTextGenerator fieldGeneratorAppRating;
        private JSONHoldingStringGenerator fieldGeneratorAppURL;
        private JSONHoldingStringGenerator fieldGeneratorAppIconURL;
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
            AppSpecJSON result = new AppSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAppSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AppSpecJSON result)
          {
            if (fieldGeneratorPlatform.have_value)
              {
                result.setPlatform(fieldGeneratorPlatform.value);
                fieldGeneratorPlatform.have_value = false;
              }
            else if ((!(result.hasPlatform())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Platform\" field was missing.");
              }
            if (fieldGeneratorAppID.have_value)
              {
                result.setAppID(fieldGeneratorAppID.value);
                fieldGeneratorAppID.have_value = false;
              }
            else if ((!(result.hasAppID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AppID\" field was missing.");
              }
            if (fieldGeneratorLaunchURLScheme.have_value)
              {
                result.setLaunchURLScheme(fieldGeneratorLaunchURLScheme.value);
                fieldGeneratorLaunchURLScheme.have_value = false;
              }
            else if ((!(result.hasLaunchURLScheme())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LaunchURLScheme\" field was missing.");
              }
            if (fieldGeneratorAppName.have_value)
              {
                result.setAppName(fieldGeneratorAppName.value);
                fieldGeneratorAppName.have_value = false;
              }
            else if ((!(result.hasAppName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AppName\" field was missing.");
              }
            if (fieldGeneratorAppSpokenName.have_value)
              {
                result.setAppSpokenName(fieldGeneratorAppSpokenName.value);
                fieldGeneratorAppSpokenName.have_value = false;
              }
            else if ((!(result.hasAppSpokenName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AppSpokenName\" field was missing.");
              }
            if (fieldGeneratorAliases.have_value)
              {
                result.initAliases();
                int count = fieldGeneratorAliases.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAliases(fieldGeneratorAliases.value[num]);
                  }
                fieldGeneratorAliases.value.Clear();
                fieldGeneratorAliases.have_value = false;
              }
            if (fieldGeneratorPopularityMeasure.have_value)
              {
                result.setPopularityMeasureText(fieldGeneratorPopularityMeasure.value);
                fieldGeneratorPopularityMeasure.have_value = false;
              }
            if (fieldGeneratorCompanyName.have_value)
              {
                result.setCompanyName(fieldGeneratorCompanyName.value);
                fieldGeneratorCompanyName.have_value = false;
              }
            if (fieldGeneratorAppPrice.have_value)
              {
                result.setAppPriceText(fieldGeneratorAppPrice.value);
                fieldGeneratorAppPrice.have_value = false;
              }
            if (fieldGeneratorAppRating.have_value)
              {
                result.setAppRatingText(fieldGeneratorAppRating.value);
                fieldGeneratorAppRating.have_value = false;
              }
            if (fieldGeneratorAppURL.have_value)
              {
                result.setAppURL(fieldGeneratorAppURL.value);
                fieldGeneratorAppURL.have_value = false;
              }
            if (fieldGeneratorAppIconURL.have_value)
              {
                result.setAppIconURL(fieldGeneratorAppIconURL.value);
                fieldGeneratorAppIconURL.have_value = false;
              }
          }
        protected abstract void handle_result(AppSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "iases", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorAliases;
                            break;
                        case 'p':
                            if (String.Compare(field_name, 2, "p", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'I':
                                        switch (field_name[4])
                                          {
                                            case 'D':
                                                if (field_name.Length == 5)
                                                    return fieldGeneratorAppID;
                                                break;
                                            case 'c':
                                                if ((String.Compare(field_name, 5, "onURL", 0, 5, false) == 0) && (field_name.Length == 10))
                                                    return fieldGeneratorAppIconURL;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 4, "ame", 0, 3, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratorAppName;
                                        break;
                                    case 'P':
                                        if ((String.Compare(field_name, 4, "rice", 0, 4, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorAppPrice;
                                        break;
                                    case 'R':
                                        if ((String.Compare(field_name, 4, "ating", 0, 5, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorAppRating;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 4, "pokenName", 0, 9, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorAppSpokenName;
                                        break;
                                    case 'U':
                                        if ((String.Compare(field_name, 4, "RL", 0, 2, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorAppURL;
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
                case 'C':
                    if ((String.Compare(field_name, 1, "ompanyName", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCompanyName;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "aunchURLScheme", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorLaunchURLScheme;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "atform", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPlatform;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "pularityMeasure", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorPopularityMeasure;
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
            fieldGeneratorPlatform = new FieldHoldingGeneratorPlatform("field \"Platform\" of the AppSpec class");
            fieldGeneratorAppID = new JSONHoldingStringGenerator("field \"AppID\" of the AppSpec class");
            fieldGeneratorLaunchURLScheme = new JSONHoldingStringGenerator("field \"LaunchURLScheme\" of the AppSpec class");
            fieldGeneratorAppName = new JSONHoldingStringGenerator("field \"AppName\" of the AppSpec class");
            fieldGeneratorAppSpokenName = new JSONHoldingStringGenerator("field \"AppSpokenName\" of the AppSpec class");
            fieldGeneratorAliases = new JSONHoldingStringArrayGenerator("field \"Aliases\" of the AppSpec class");
            fieldGeneratorPopularityMeasure = new JSONHoldingNumberTextGenerator("field \"PopularityMeasure\" of the AppSpec class");
            fieldGeneratorCompanyName = new JSONHoldingStringGenerator("field \"CompanyName\" of the AppSpec class");
            fieldGeneratorAppPrice = new JSONHoldingNumberTextGenerator("field \"AppPrice\" of the AppSpec class");
            fieldGeneratorAppRating = new JSONHoldingNumberTextGenerator("field \"AppRating\" of the AppSpec class");
            fieldGeneratorAppURL = new JSONHoldingStringGenerator("field \"AppURL\" of the AppSpec class");
            fieldGeneratorAppIconURL = new JSONHoldingStringGenerator("field \"AppIconURL\" of the AppSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AppSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPlatform = new FieldHoldingGeneratorPlatform("field \"Platform\" of the AppSpec class");
            fieldGeneratorAppID = new JSONHoldingStringGenerator("field \"AppID\" of the AppSpec class");
            fieldGeneratorLaunchURLScheme = new JSONHoldingStringGenerator("field \"LaunchURLScheme\" of the AppSpec class");
            fieldGeneratorAppName = new JSONHoldingStringGenerator("field \"AppName\" of the AppSpec class");
            fieldGeneratorAppSpokenName = new JSONHoldingStringGenerator("field \"AppSpokenName\" of the AppSpec class");
            fieldGeneratorAliases = new JSONHoldingStringArrayGenerator("field \"Aliases\" of the AppSpec class");
            fieldGeneratorPopularityMeasure = new JSONHoldingNumberTextGenerator("field \"PopularityMeasure\" of the AppSpec class");
            fieldGeneratorCompanyName = new JSONHoldingStringGenerator("field \"CompanyName\" of the AppSpec class");
            fieldGeneratorAppPrice = new JSONHoldingNumberTextGenerator("field \"AppPrice\" of the AppSpec class");
            fieldGeneratorAppRating = new JSONHoldingNumberTextGenerator("field \"AppRating\" of the AppSpec class");
            fieldGeneratorAppURL = new JSONHoldingStringGenerator("field \"AppURL\" of the AppSpec class");
            fieldGeneratorAppIconURL = new JSONHoldingStringGenerator("field \"AppIconURL\" of the AppSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AppSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPlatform.reset();
            fieldGeneratorAppID.reset();
            fieldGeneratorLaunchURLScheme.reset();
            fieldGeneratorAppName.reset();
            fieldGeneratorAppSpokenName.reset();
            fieldGeneratorAliases.reset();
            fieldGeneratorPopularityMeasure.reset();
            fieldGeneratorCompanyName.reset();
            fieldGeneratorAppPrice.reset();
            fieldGeneratorAppRating.reset();
            fieldGeneratorAppURL.reset();
            fieldGeneratorAppIconURL.reset();
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
        protected override void handle_result(AppSpecJSON  result)
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
        public AppSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AppSpecJSON  result)
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
    protected virtual void handle_result(List<AppSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AppSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AppSpecJSON>();
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
    public List<AppSpecJSON> value;
  };
  };
