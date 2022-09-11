/* file "StreamAudioIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class StreamAudioIntentJSON : CommandIntentJSON
  {
    public enum TypeDurationTypeKnownValues
      {
        DurationType_FixedLength,
        DurationType_FiniteUnknown,
        DurationType_Infinite,
        DurationType__none
      };
    public struct TypeDurationType
      {
        public bool in_known_list;
        public string string_value;
        public TypeDurationTypeKnownValues list_value;
      };

    public static TypeDurationTypeKnownValues  stringToDurationType(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if (String.Compare(chars, 1, "i", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'n':
                            if ((String.Compare(chars, 3, "iteUnknown", 0, 10, false) == 0) && (chars.Length == 13))
                                return TypeDurationTypeKnownValues.DurationType_FiniteUnknown;
                            break;
                        case 'x':
                            if ((String.Compare(chars, 3, "edLength", 0, 8, false) == 0) && (chars.Length == 11))
                                return TypeDurationTypeKnownValues.DurationType_FixedLength;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nfinite", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeDurationTypeKnownValues.DurationType_Infinite;
                break;
            default:
                break;
          }
        return TypeDurationTypeKnownValues.DurationType__none;
      }

    public static string  stringFromDurationType(TypeDurationTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeDurationTypeKnownValues.DurationType_FixedLength:
                return "FixedLength";
            case TypeDurationTypeKnownValues.DurationType_FiniteUnknown:
                return "FiniteUnknown";
            case TypeDurationTypeKnownValues.DurationType_Infinite:
                return "Infinite";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeProviderKnownValues
      {
        Provider_IHeartRadio,
        Provider_Audacy,
        Provider__none
      };
    public struct TypeProvider
      {
        public bool in_known_list;
        public string string_value;
        public TypeProviderKnownValues list_value;
      };

    public static TypeProviderKnownValues  stringToProvider(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "udacy", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeProviderKnownValues.Provider_Audacy;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "HeartRadio", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeProviderKnownValues.Provider_IHeartRadio;
                break;
            default:
                break;
          }
        return TypeProviderKnownValues.Provider__none;
      }

    public static string  stringFromProvider(TypeProviderKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeProviderKnownValues.Provider_IHeartRadio:
                return "IHeartRadio";
            case TypeProviderKnownValues.Provider_Audacy:
                return "Audacy";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFulfillments;
    private List< StreamFulfillmentJSON  > storeFulfillments;
    private bool flagHasDurationType;
    private TypeDurationType storeDurationType;
    private bool flagHasDurationInSeconds;
    private BigInteger storeDurationInSeconds;
    private bool flagHasLogoImage;
    private string storeLogoImage;
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private bool flagHasProvider;
    private TypeProvider storeProvider;


    private JSONValue  extraFulfillmentsToJSON()
      {
        JSONArrayValue generated_array_1_Fulfillments = new JSONArrayValue();
        for (int num1 = 0; num1 < storeFulfillments.Count; ++num1)
          {
            JSONValueHandler handler_Fulfillments = new JSONValueHandler();
            storeFulfillments[num1].write_as_json(handler_Fulfillments);
            generated_array_1_Fulfillments.appendComponent(handler_Fulfillments.result);
          }
        return generated_array_1_Fulfillments;
      }

    private JSONValue  extraDurationTypeToJSON()
      {
        JSONStringValue generated_string_DurationType;
        if (!(storeDurationType.in_known_list))
          {
        generated_string_DurationType = new JSONStringValue(storeDurationType.string_value);
          }
        else
          {
        switch (storeDurationType.list_value)
          {
            case TypeDurationTypeKnownValues.DurationType_FixedLength:
                generated_string_DurationType = new JSONStringValue("FixedLength");
                break;
            case TypeDurationTypeKnownValues.DurationType_FiniteUnknown:
                generated_string_DurationType = new JSONStringValue("FiniteUnknown");
                break;
            case TypeDurationTypeKnownValues.DurationType_Infinite:
                generated_string_DurationType = new JSONStringValue("Infinite");
                break;
            default:
                Debug.Assert(false);
                generated_string_DurationType = null;
                break;
          }
          }
        return generated_string_DurationType;
      }

    private JSONValue  extraDurationInSecondsToJSON()
      {
        JSONIntegerValue generated_integer_DurationInSeconds = new JSONIntegerValue(storeDurationInSeconds);
        return generated_integer_DurationInSeconds;
      }

    private JSONValue  extraLogoImageToJSON()
      {
        JSONStringValue generated_string_LogoImage = new JSONStringValue(storeLogoImage);
        return generated_string_LogoImage;
      }

    private JSONValue  extraAttributionToJSON()
      {
        JSONValueHandler handler_Attribution = new JSONValueHandler();
        storeAttribution.write_as_json(handler_Attribution);
        return handler_Attribution.result;
      }

    private JSONValue  extraProviderToJSON()
      {
        JSONStringValue generated_string_Provider;
        if (!(storeProvider.in_known_list))
          {
        generated_string_Provider = new JSONStringValue(storeProvider.string_value);
          }
        else
          {
        switch (storeProvider.list_value)
          {
            case TypeProviderKnownValues.Provider_IHeartRadio:
                generated_string_Provider = new JSONStringValue("IHeartRadio");
                break;
            case TypeProviderKnownValues.Provider_Audacy:
                generated_string_Provider = new JSONStringValue("Audacy");
                break;
            default:
                Debug.Assert(false);
                generated_string_Provider = null;
                break;
          }
          }
        return generated_string_Provider;
      }


    private void  fromJSONFulfillments(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Fulfillments of StreamAudioIntentJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Fulfillments of StreamAudioIntentJSON has too few elements.");
        List< StreamFulfillmentJSON  > vector_Fulfillments1 = new List< StreamFulfillmentJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StreamFulfillmentJSON convert_classy = StreamFulfillmentJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Fulfillments1.Add(convert_classy);
          }
        Debug.Assert(vector_Fulfillments1.Count >= 1);
        initFulfillments();
        for (int num1 = 0; num1 < vector_Fulfillments1.Count; ++num1)
            appendFulfillments(vector_Fulfillments1[num1]);
        for (int num1 = 0; num1 < vector_Fulfillments1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDurationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DurationType of StreamAudioIntentJSON is not a string.");
        TypeDurationType the_open_enum = new TypeDurationType();
        switch (json_string.getData()[0])
          {
            case 'F':
                if (String.Compare(json_string.getData(), 1, "i", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'n':
                            if ((String.Compare(json_string.getData(), 3, "iteUnknown", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeDurationTypeKnownValues.DurationType_FiniteUnknown;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'x':
                            if ((String.Compare(json_string.getData(), 3, "edLength", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeDurationTypeKnownValues.DurationType_FixedLength;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nfinite", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDurationTypeKnownValues.DurationType_Infinite;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setDurationType(the_open_enum);
      }


    private void  fromJSONDurationInSeconds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DurationInSeconds of StreamAudioIntentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DurationInSeconds of StreamAudioIntentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDurationInSeconds(extracted_integer);
      }


    private void  fromJSONLogoImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LogoImage of StreamAudioIntentJSON is not a string.");
        setLogoImage(json_string.getData());
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    private void  fromJSONProvider(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Provider of StreamAudioIntentJSON is not a string.");
        TypeProvider the_open_enum = new TypeProvider();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "udacy", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeProviderKnownValues.Provider_Audacy;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "HeartRadio", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeProviderKnownValues.Provider_IHeartRadio;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setProvider(the_open_enum);
      }


    public StreamAudioIntentJSON()
      {
        flagHasFulfillments = false;
        flagHasDurationType = false;
        flagHasDurationInSeconds = false;
        flagHasLogoImage = false;
        flagHasAttribution = false;
        flagHasProvider = false;
        storeFulfillments = new List< StreamFulfillmentJSON  >();
      }

    public override string  getCommandIntentKind()
      {
        return "StreamAudio";
      }

    public abstract string getStreamAudioKind();
    public bool  hasFulfillments()
      {
        return flagHasFulfillments;
      }

    public int  countOfFulfillments()
      {
        Debug.Assert(flagHasFulfillments);
        return storeFulfillments.Count;
      }

    public StreamFulfillmentJSON   elementOfFulfillments(int element_num)
      {
        Debug.Assert(flagHasFulfillments);
        return storeFulfillments[element_num];
      }

    public List< StreamFulfillmentJSON  >  getFulfillments()
      {
        Debug.Assert(flagHasFulfillments);
        return storeFulfillments;
      }

    public bool  hasDurationType()
      {
        return flagHasDurationType;
      }

    public TypeDurationType  getDurationType()
      {
        Debug.Assert(flagHasDurationType);
        return storeDurationType;
      }

    public string  getDurationTypeAsString()
      {
        TypeDurationType result = getDurationType();
        if (result.in_known_list)
            return stringFromDurationType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasDurationInSeconds()
      {
        return flagHasDurationInSeconds;
      }

    public BigInteger  getDurationInSeconds()
      {
        Debug.Assert(flagHasDurationInSeconds);
        return storeDurationInSeconds;
      }

    public bool  hasLogoImage()
      {
        return flagHasLogoImage;
      }

    public string  getLogoImage()
      {
        Debug.Assert(flagHasLogoImage);
        return storeLogoImage;
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public AttributionJSON   getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }

    public bool  hasProvider()
      {
        return flagHasProvider;
      }

    public TypeProvider  getProvider()
      {
        Debug.Assert(flagHasProvider);
        return storeProvider;
      }

    public string  getProviderAsString()
      {
        TypeProvider result = getProvider();
        if (result.in_known_list)
            return stringFromProvider(result.list_value);
        else
            return result.string_value;
      }


    public abstract int extraStreamAudioIntentComponentCount();
    public abstract string extraStreamAudioIntentComponentKey(int component_num);
    public abstract JSONValue extraStreamAudioIntentComponentValue(int component_num);
    public abstract JSONValue extraStreamAudioIntentLookup(string field_name);
    public override int extraCommandIntentComponentCount()
      {
        int result = 1;
        if (flagHasFulfillments)
            ++result;
        if (flagHasDurationType)
            ++result;
        if (flagHasDurationInSeconds)
            ++result;
        if (flagHasLogoImage)
            ++result;
        if (flagHasAttribution)
            ++result;
        if (flagHasProvider)
            ++result;
        result += extraStreamAudioIntentComponentCount();
        return result;
      }
    public override string extraCommandIntentComponentKey(int component_num)
      {
        if (component_num == 0)
            return "StreamAudioKind";
        int remainder = (component_num - 1);
        if (flagHasFulfillments)
          {
            if (remainder == 0)
                return "Fulfillments";
            --remainder;
          }
        if (flagHasDurationType)
          {
            if (remainder == 0)
                return "DurationType";
            --remainder;
          }
        if (flagHasDurationInSeconds)
          {
            if (remainder == 0)
                return "DurationInSeconds";
            --remainder;
          }
        if (flagHasLogoImage)
          {
            if (remainder == 0)
                return "LogoImage";
            --remainder;
          }
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return "Attribution";
            --remainder;
          }
        if (flagHasProvider)
          {
            if (remainder == 0)
                return "Provider";
            --remainder;
          }
        return extraStreamAudioIntentComponentKey(remainder);
      }
    public override JSONValue extraCommandIntentComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getStreamAudioKind());
        int remainder = (component_num - 1);
        if (flagHasFulfillments)
          {
            if (remainder == 0)
                return extraFulfillmentsToJSON();
            --remainder;
          }
        if (flagHasDurationType)
          {
            if (remainder == 0)
                return extraDurationTypeToJSON();
            --remainder;
          }
        if (flagHasDurationInSeconds)
          {
            if (remainder == 0)
                return extraDurationInSecondsToJSON();
            --remainder;
          }
        if (flagHasLogoImage)
          {
            if (remainder == 0)
                return extraLogoImageToJSON();
            --remainder;
          }
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return extraAttributionToJSON();
            --remainder;
          }
        if (flagHasProvider)
          {
            if (remainder == 0)
                return extraProviderToJSON();
            --remainder;
          }
        return extraStreamAudioIntentComponentValue(remainder);
      }
    public override JSONValue extraCommandIntentLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasAttribution ? extraAttributionToJSON() : null);
                break;
            case 'D':
                if (String.Compare(field_name, 1, "uration", 0, 7, false) == 0)
                  {
                    switch (field_name[8])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 9, "nSeconds", 0, 8, false) == 0) && (field_name.Length == 17))
                                return (flagHasDurationInSeconds ? extraDurationInSecondsToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 9, "ype", 0, 3, false) == 0) && (field_name.Length == 12))
                                return (flagHasDurationType ? extraDurationTypeToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "ulfillments", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasFulfillments ? extraFulfillmentsToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ogoImage", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasLogoImage ? extraLogoImageToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "rovider", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasProvider ? extraProviderToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "treamAudioKind", 0, 14, false) == 0) && (field_name.Length == 15))
                    return new JSONStringValue(getStreamAudioKind());
                break;
            default:
                break;
          }
        return extraStreamAudioIntentLookup(field_name);
      }

    public void initFulfillments()
      {
        if (flagHasFulfillments)
          {
            for (int num1 = 0; num1 < storeFulfillments.Count; ++num1)
              {
              }
          }
        flagHasFulfillments = true;
        storeFulfillments.Clear();
      }
    public void appendFulfillments(StreamFulfillmentJSON  to_append)
      {
        if (!flagHasFulfillments)
          {
            flagHasFulfillments = true;
            storeFulfillments.Clear();
          }
        Debug.Assert(flagHasFulfillments);
        storeFulfillments.Add(to_append);
      }
    public void unsetFulfillments()
      {
        if (flagHasFulfillments)
          {
            for (int num2 = 0; num2 < storeFulfillments.Count; ++num2)
              {
              }
          }
        flagHasFulfillments = false;
        storeFulfillments.Clear();
      }
    public void setDurationType(TypeDurationType new_value)
      {
        flagHasDurationType = true;
        storeDurationType = new_value;
      }
    public void setDurationType(string chars)
      {
        TypeDurationTypeKnownValues known = stringToDurationType(chars);
        TypeDurationType new_value = new TypeDurationType();
        if (known == TypeDurationTypeKnownValues.DurationType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDurationType(new_value);
      }
    public void setDurationType(TypeDurationTypeKnownValues new_value)
      {
        TypeDurationType new_full_value = new TypeDurationType();
        Debug.Assert(new_value != TypeDurationTypeKnownValues.DurationType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setDurationType(new_full_value);
      }
    public void unsetDurationType()
      {
        flagHasDurationType = false;
      }
    public void setDurationInSeconds(BigInteger new_value)
      {
        flagHasDurationInSeconds = true;
        storeDurationInSeconds = new_value;
      }
    public void unsetDurationInSeconds()
      {
        flagHasDurationInSeconds = false;
      }
    public void setLogoImage(string new_value)
      {
        flagHasLogoImage = true;
        storeLogoImage = new_value;
      }
    public void unsetLogoImage()
      {
        flagHasLogoImage = false;
      }
    public void setAttribution(AttributionJSON  new_value)
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = false;
      }
    public void setProvider(TypeProvider new_value)
      {
        flagHasProvider = true;
        storeProvider = new_value;
      }
    public void setProvider(string chars)
      {
        TypeProviderKnownValues known = stringToProvider(chars);
        TypeProvider new_value = new TypeProvider();
        if (known == TypeProviderKnownValues.Provider__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setProvider(new_value);
      }
    public void setProvider(TypeProviderKnownValues new_value)
      {
        TypeProvider new_full_value = new TypeProvider();
        Debug.Assert(new_value != TypeProviderKnownValues.Provider__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setProvider(new_full_value);
      }
    public void unsetProvider()
      {
        flagHasProvider = false;
      }

    public abstract void extraStreamAudioIntentAppendPair(string key, JSONValue new_component);
    public abstract void extraStreamAudioIntentSetField(string key, JSONValue new_component);
    public override void extraCommandIntentAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if (String.Compare(key, 1, "uration", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'I':
                            if ((String.Compare(key, 9, "nSeconds", 0, 8, false) == 0) && (key.Length == 17))
                                {
                                fromJSONDurationInSeconds(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 9, "ype", 0, 3, false) == 0) && (key.Length == 12))
                                {
                                fromJSONDurationType(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ulfillments", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONFulfillments(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ogoImage", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONLogoImage(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rovider", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONProvider(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "treamAudioKind", 0, 14, false) == 0) && (key.Length == 15))
                    return;
                break;
            default:
                break;
          }
        extraStreamAudioIntentAppendPair(key, new_component);
      }
    public override void extraCommandIntentSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if (String.Compare(key, 1, "uration", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'I':
                            if ((String.Compare(key, 9, "nSeconds", 0, 8, false) == 0) && (key.Length == 17))
                                {
                                fromJSONDurationInSeconds(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 9, "ype", 0, 3, false) == 0) && (key.Length == 12))
                                {
                                fromJSONDurationType(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ulfillments", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONFulfillments(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ogoImage", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONLogoImage(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rovider", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONProvider(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "treamAudioKind", 0, 14, false) == 0) && (key.Length == 15))
                    return;
                break;
            default:
                break;
          }
        extraStreamAudioIntentSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("StreamAudioKind", getStreamAudioKind());
        if (flagHasFulfillments)
          {
            handler.start_pair("Fulfillments");
            Debug.Assert(storeFulfillments.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeFulfillments.Count; ++num1)
              {
                if (partial_allowed)
                    storeFulfillments[num1].write_partial_as_json(handler);
                else
                    storeFulfillments[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDurationType)
          {
            handler.start_pair("DurationType");
            if (storeDurationType.in_known_list)
              {
                switch (storeDurationType.list_value)
                  {
                    case TypeDurationTypeKnownValues.DurationType_FixedLength:
                        handler.string_value("FixedLength");
                        break;
                    case TypeDurationTypeKnownValues.DurationType_FiniteUnknown:
                        handler.string_value("FiniteUnknown");
                        break;
                    case TypeDurationTypeKnownValues.DurationType_Infinite:
                        handler.string_value("Infinite");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeDurationType.string_value);
              }
          }
        if (flagHasDurationInSeconds)
          {
            handler.start_pair("DurationInSeconds");
            handler.number_value(storeDurationInSeconds);
          }
        if (flagHasLogoImage)
          {
            handler.start_pair("LogoImage");
            handler.string_value(storeLogoImage);
          }
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
          }
        if (flagHasProvider)
          {
            handler.start_pair("Provider");
            if (storeProvider.in_known_list)
              {
                switch (storeProvider.list_value)
                  {
                    case TypeProviderKnownValues.Provider_IHeartRadio:
                        handler.string_value("IHeartRadio");
                        break;
                    case TypeProviderKnownValues.Provider_Audacy:
                        handler.string_value("Audacy");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeProvider.string_value);
              }
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new StreamAudioIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StreamAudioIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamAudioIntent", ignore_extras);
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
    public static new StreamAudioIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StreamAudioIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StreamAudioIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamAudioIntent", ignore_extras);
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
    public static new StreamAudioIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StreamAudioIntentJSON from_text(string text, bool ignore_extras)
      {
        StreamAudioIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamAudioIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StreamAudioIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new StreamAudioIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StreamAudioIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StreamAudioIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandIntentJSON.Generator
      {
        private StreamFulfillmentJSON.HoldingArrayGenerator fieldGeneratorFulfillments;
    private abstract class FieldGeneratorDurationType : JSONStringGenerator
          {
            protected FieldGeneratorDurationType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDurationType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeDurationTypeKnownValues known = stringToDurationType(result);
                TypeDurationType new_value = new TypeDurationType();
                if (known == TypeDurationTypeKnownValues.DurationType__none)
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
            protected abstract void handle_result(TypeDurationType result);
          };
    private class FieldHoldingGeneratorDurationType : FieldGeneratorDurationType
  {
    protected override void handle_result(TypeDurationType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDurationType(String what)
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
    public TypeDurationType value;
  };
    private class FieldHoldingArrayGeneratorDurationType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDurationType
      {
        private FieldHoldingArrayGeneratorDurationType top;

        protected override void handle_result(TypeDurationType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDurationType init_top)
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
    protected virtual void handle_result(List<TypeDurationType> result)
      {
      }

    public FieldHoldingArrayGeneratorDurationType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDurationType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDurationType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDurationType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDurationType> value;
  };
        private FieldHoldingGeneratorDurationType fieldGeneratorDurationType;
    private class FieldHoldingGeneratorDurationInSeconds : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorDurationInSeconds(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDurationInSeconds : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDurationInSeconds(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorDurationInSeconds fieldGeneratorDurationInSeconds;
        private JSONHoldingStringGenerator fieldGeneratorLogoImage;
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
    private abstract class FieldGeneratorProvider : JSONStringGenerator
          {
            protected FieldGeneratorProvider(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorProvider()
              {
              }
            protected override void handle_result(string result)
              {
                TypeProviderKnownValues known = stringToProvider(result);
                TypeProvider new_value = new TypeProvider();
                if (known == TypeProviderKnownValues.Provider__none)
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
            protected abstract void handle_result(TypeProvider result);
          };
    private class FieldHoldingGeneratorProvider : FieldGeneratorProvider
  {
    protected override void handle_result(TypeProvider result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorProvider(String what)
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
    public TypeProvider value;
  };
    private class FieldHoldingArrayGeneratorProvider : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorProvider
      {
        private FieldHoldingArrayGeneratorProvider top;

        protected override void handle_result(TypeProvider result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorProvider init_top)
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
    protected virtual void handle_result(List<TypeProvider> result)
      {
      }

    public FieldHoldingArrayGeneratorProvider(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeProvider>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorProvider()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeProvider>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeProvider> value;
  };
        private FieldHoldingGeneratorProvider fieldGeneratorProvider;
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
                throw new Exception("The `StreamAudioKind' field is missing.");
            if (!(getCommandIntentJSONKey().Equals("StreamAudio")))
                throw new Exception("The key field has a value other than `StreamAudio'.");
            StreamAudioIntentJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStreamAudioIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getStreamAudioIntentJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `StreamAudioKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandIntentJSON new_result)
          {
            handle_result((StreamAudioIntentJSON )new_result);
          }
        protected void finish(StreamAudioIntentJSON result)
          {
            if (fieldGeneratorFulfillments.have_value)
              {
                result.initFulfillments();
                int count = fieldGeneratorFulfillments.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFulfillments(fieldGeneratorFulfillments.value[num]);
                  }
                fieldGeneratorFulfillments.value.Clear();
                fieldGeneratorFulfillments.have_value = false;
              }
            if (fieldGeneratorDurationType.have_value)
              {
                result.setDurationType(fieldGeneratorDurationType.value);
                fieldGeneratorDurationType.have_value = false;
              }
            if (fieldGeneratorDurationInSeconds.have_value)
              {
                result.setDurationInSeconds(fieldGeneratorDurationInSeconds.value);
                fieldGeneratorDurationInSeconds.have_value = false;
              }
            if (fieldGeneratorLogoImage.have_value)
              {
                result.setLogoImage(fieldGeneratorLogoImage.value);
                fieldGeneratorLogoImage.have_value = false;
              }
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
            if (fieldGeneratorProvider.have_value)
              {
                result.setProvider(fieldGeneratorProvider.value);
                fieldGeneratorProvider.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(StreamAudioIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAttribution;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "uration", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 9, "nSeconds", 0, 8, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorDurationInSeconds;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 9, "ype", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorDurationType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ulfillments", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorFulfillments;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ogoImage", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorLogoImage;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rovider", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorProvider;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "treamAudioKind", 0, 14, false) == 0) && (field_name.Length == 15))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorFulfillments = new StreamFulfillmentJSON.HoldingArrayGenerator("field \"Fulfillments\" of the StreamAudioIntent class", ignore_extras);
            fieldGeneratorDurationType = new FieldHoldingGeneratorDurationType("field \"DurationType\" of the StreamAudioIntent class");
            fieldGeneratorDurationInSeconds = new FieldHoldingGeneratorDurationInSeconds("field \"DurationInSeconds\" of the StreamAudioIntent class");
            fieldGeneratorLogoImage = new JSONHoldingStringGenerator("field \"LogoImage\" of the StreamAudioIntent class");
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the StreamAudioIntent class", ignore_extras);
            fieldGeneratorProvider = new FieldHoldingGeneratorProvider("field \"Provider\" of the StreamAudioIntent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"StreamAudioKind\" of the StreamAudioIntent class");
            set_what("the StreamAudioIntent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorFulfillments = new StreamFulfillmentJSON.HoldingArrayGenerator("field \"Fulfillments\" of the StreamAudioIntent class", false);
            fieldGeneratorDurationType = new FieldHoldingGeneratorDurationType("field \"DurationType\" of the StreamAudioIntent class");
            fieldGeneratorDurationInSeconds = new FieldHoldingGeneratorDurationInSeconds("field \"DurationInSeconds\" of the StreamAudioIntent class");
            fieldGeneratorLogoImage = new JSONHoldingStringGenerator("field \"LogoImage\" of the StreamAudioIntent class");
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the StreamAudioIntent class", false);
            fieldGeneratorProvider = new FieldHoldingGeneratorProvider("field \"Provider\" of the StreamAudioIntent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"StreamAudioKind\" of the StreamAudioIntent class");
            set_what("the StreamAudioIntent class");
          }

        public override void reset()
          {
            fieldGeneratorFulfillments.reset();
            fieldGeneratorDurationType.reset();
            fieldGeneratorDurationInSeconds.reset();
            fieldGeneratorLogoImage.reset();
            fieldGeneratorAttribution.reset();
            fieldGeneratorProvider.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(StreamAudioIntentJSON  result)
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
        public StreamAudioIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StreamAudioIntentJSON  result)
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
    protected virtual void handle_result(List<StreamAudioIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StreamAudioIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StreamAudioIntentJSON>();
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
    public List<StreamAudioIntentJSON> value;
  };
    class GenericStreamAudioIntentJSON : StreamAudioIntentJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericStreamAudioIntentJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getStreamAudioKind()  { return key; }
        public override int extraStreamAudioIntentComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraStreamAudioIntentComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraStreamAudioIntentComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraStreamAudioIntentLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraStreamAudioIntentAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraStreamAudioIntentSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraStreamAudioIntentLookup(key);
            if (old_field == null)
              {
                extraStreamAudioIntentAppendPair(key, new_component);
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
    public static new StreamAudioIntentJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if ((String.Compare(key, 0, "StreamLiveStation", 0, 17, false) == 0) && (key.Length == 17))
        return new StreamLiveStationIntentJSON();

        return new GenericStreamAudioIntentJSON(key);
      }
  };
