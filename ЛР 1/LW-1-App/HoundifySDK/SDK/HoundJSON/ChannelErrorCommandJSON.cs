/* file "ChannelErrorCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ChannelErrorCommandJSON : CommandErrorJSON
  {
    public enum TypeBand
      {
        Band_AM,
        Band_FM
      };

    public static TypeBand  stringToBand(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "M", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeBand.Band_AM;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "M", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeBand.Band_FM;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Band' is not one of the legal values.");
      }

    public static string  stringFromBand(TypeBand the_enum)
      {
        switch (the_enum)
          {
            case TypeBand.Band_AM:
                return "AM";
            case TypeBand.Band_FM:
                return "FM";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeLimitRelation
      {
        LimitRelation_LessThan,
        LimitRelation_GreaterThan,
        LimitRelation_NotAligned
      };

    public static TypeLimitRelation  stringToLimitRelation(string chars)
      {
        switch (chars[0])
          {
            case 'G':
                if ((String.Compare(chars, 1, "reaterThan", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeLimitRelation.LimitRelation_GreaterThan;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "essThan", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeLimitRelation.LimitRelation_LessThan;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "otAligned", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeLimitRelation.LimitRelation_NotAligned;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `LimitRelation' is not one of the legal values.");
      }

    public static string  stringFromLimitRelation(TypeLimitRelation the_enum)
      {
        switch (the_enum)
          {
            case TypeLimitRelation.LimitRelation_LessThan:
                return "LessThan";
            case TypeLimitRelation.LimitRelation_GreaterThan:
                return "GreaterThan";
            case TypeLimitRelation.LimitRelation_NotAligned:
                return "NotAligned";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasChannel;
    private double storeChannel;
    private string textStoreChannel;
    private bool flagHasBand;
    private TypeBand storeBand;
    private bool flagHasLimitRelation;
    private TypeLimitRelation storeLimitRelation;
    private bool flagHasLimit;
    private double storeLimit;
    private string textStoreLimit;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraChannelToJSON()
      {
        JSONValue generated_rational_Channel;
        if (textStoreChannel != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreChannel);
            generated_rational_Channel = handler.result;
          }
        else if (((double)(long)storeChannel) == storeChannel)
            generated_rational_Channel = new JSONIntegerValue((long)(storeChannel));
        else
            generated_rational_Channel = new JSONRationalValue(storeChannel, 15);
        return generated_rational_Channel;
      }

    private JSONValue  extraBandToJSON()
      {
        JSONStringValue generated_string_Band;
        switch (storeBand)
          {
            case TypeBand.Band_AM:
                generated_string_Band = new JSONStringValue("AM");
                break;
            case TypeBand.Band_FM:
                generated_string_Band = new JSONStringValue("FM");
                break;
            default:
                Debug.Assert(false);
                generated_string_Band = null;
                break;
          }
        return generated_string_Band;
      }

    private JSONValue  extraLimitRelationToJSON()
      {
        JSONStringValue generated_string_LimitRelation;
        switch (storeLimitRelation)
          {
            case TypeLimitRelation.LimitRelation_LessThan:
                generated_string_LimitRelation = new JSONStringValue("LessThan");
                break;
            case TypeLimitRelation.LimitRelation_GreaterThan:
                generated_string_LimitRelation = new JSONStringValue("GreaterThan");
                break;
            case TypeLimitRelation.LimitRelation_NotAligned:
                generated_string_LimitRelation = new JSONStringValue("NotAligned");
                break;
            default:
                Debug.Assert(false);
                generated_string_LimitRelation = null;
                break;
          }
        return generated_string_LimitRelation;
      }

    private JSONValue  extraLimitToJSON()
      {
        JSONValue generated_rational_Limit;
        if (textStoreLimit != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreLimit);
            generated_rational_Limit = handler.result;
          }
        else if (((double)(long)storeLimit) == storeLimit)
            generated_rational_Limit = new JSONIntegerValue((long)(storeLimit));
        else
            generated_rational_Limit = new JSONRationalValue(storeLimit, 15);
        return generated_rational_Limit;
      }


    private void  fromJSONChannel(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Channel of ChannelErrorCommandJSON is not a number.");
              }
          }
        setChannelText(the_rational_text);
      }


    private void  fromJSONBand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Band of ChannelErrorCommandJSON is not a string.");
        TypeBand the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "M", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeBand.Band_AM;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "M", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeBand.Band_FM;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Band of ChannelErrorCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setBand(the_enum);
      }


    private void  fromJSONLimitRelation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LimitRelation of ChannelErrorCommandJSON is not a string.");
        TypeLimitRelation the_enum;
        switch (json_string.getData()[0])
          {
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "reaterThan", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeLimitRelation.LimitRelation_GreaterThan;
                        goto enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "essThan", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeLimitRelation.LimitRelation_LessThan;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "otAligned", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeLimitRelation.LimitRelation_NotAligned;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field LimitRelation of ChannelErrorCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setLimitRelation(the_enum);
      }


    private void  fromJSONLimit(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Limit of ChannelErrorCommandJSON is not a number.");
              }
          }
        setLimitText(the_rational_text);
      }


    public ChannelErrorCommandJSON()
      {
        flagHasChannel = false;
        flagHasBand = false;
        flagHasLimitRelation = false;
        flagHasLimit = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getErrorType()
      {
        return "RadioChannelError";
      }

    public bool  hasChannel()
      {
        return flagHasChannel;
      }

    public double  getChannel()
      {
        Debug.Assert(flagHasChannel);
        if (textStoreChannel != "")
          {
            return Double.Parse(textStoreChannel);
          }
        return storeChannel;
      }

    public string  getChannelAsText()
      {
        Debug.Assert(flagHasChannel);
        if (textStoreChannel == "")
          {
            return Convert.ToString(storeChannel);
          }
        else
          {
            return (textStoreChannel);
          }
      }

    public bool  hasBand()
      {
        return flagHasBand;
      }

    public TypeBand  getBand()
      {
        Debug.Assert(flagHasBand);
        return storeBand;
      }

    public string  getBandAsString()
      {
        return stringFromBand(getBand());
      }

    public bool  hasLimitRelation()
      {
        return flagHasLimitRelation;
      }

    public TypeLimitRelation  getLimitRelation()
      {
        Debug.Assert(flagHasLimitRelation);
        return storeLimitRelation;
      }

    public string  getLimitRelationAsString()
      {
        return stringFromLimitRelation(getLimitRelation());
      }

    public bool  hasLimit()
      {
        return flagHasLimit;
      }

    public double  getLimit()
      {
        Debug.Assert(flagHasLimit);
        if (textStoreLimit != "")
          {
            return Double.Parse(textStoreLimit);
          }
        return storeLimit;
      }

    public string  getLimitAsText()
      {
        Debug.Assert(flagHasLimit);
        if (textStoreLimit == "")
          {
            return Convert.ToString(storeLimit);
          }
        else
          {
            return (textStoreLimit);
          }
      }


    public virtual int extraChannelErrorCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChannelErrorCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChannelErrorCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChannelErrorCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandErrorComponentCount()
      {
        int result = 0;
        if (flagHasChannel)
            ++result;
        if (flagHasBand)
            ++result;
        if (flagHasLimitRelation)
            ++result;
        if (flagHasLimit)
            ++result;
        result += extraChannelErrorCommandComponentCount();
        return result;
      }
    public override string extraCommandErrorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannel)
          {
            if (remainder == 0)
                return "Channel";
            --remainder;
          }
        if (flagHasBand)
          {
            if (remainder == 0)
                return "Band";
            --remainder;
          }
        if (flagHasLimitRelation)
          {
            if (remainder == 0)
                return "LimitRelation";
            --remainder;
          }
        if (flagHasLimit)
          {
            if (remainder == 0)
                return "Limit";
            --remainder;
          }
        return extraChannelErrorCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandErrorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannel)
          {
            if (remainder == 0)
                return extraChannelToJSON();
            --remainder;
          }
        if (flagHasBand)
          {
            if (remainder == 0)
                return extraBandToJSON();
            --remainder;
          }
        if (flagHasLimitRelation)
          {
            if (remainder == 0)
                return extraLimitRelationToJSON();
            --remainder;
          }
        if (flagHasLimit)
          {
            if (remainder == 0)
                return extraLimitToJSON();
            --remainder;
          }
        return extraChannelErrorCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandErrorLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'B':
                if ((String.Compare(field_name, 1, "and", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasBand ? extraBandToJSON() : null);
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "hannel", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasChannel ? extraChannelToJSON() : null);
                break;
            case 'L':
                if (String.Compare(field_name, 1, "imit", 0, 4, false) == 0)
                  {
                    if (field_name.Length == 5)
                      {
                        return (flagHasLimit ? extraLimitToJSON() : null);
                      }
                    switch (field_name[5])
                      {
                        case 'R':
                            if ((String.Compare(field_name, 6, "elation", 0, 7, false) == 0) && (field_name.Length == 13))
                                return (flagHasLimitRelation ? extraLimitRelationToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraChannelErrorCommandLookup(field_name);
      }

    public void setChannel(double new_value)
      {
        flagHasChannel = true;
        storeChannel = new_value;
        textStoreChannel = "";
      }
    public void setChannelText(string new_value)
      {
        flagHasChannel = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Channel of ChannelErrorCommandJSON is not a valid number.");
        textStoreChannel = new_value;
      }
    public void unsetChannel()
      {
        flagHasChannel = false;
      }
    public void setBand(TypeBand new_value)
      {
        flagHasBand = true;
        storeBand = new_value;
      }
    public void setBand(string chars)
      {
        setBand(stringToBand(chars));
      }
    public void unsetBand()
      {
        flagHasBand = false;
      }
    public void setLimitRelation(TypeLimitRelation new_value)
      {
        flagHasLimitRelation = true;
        storeLimitRelation = new_value;
      }
    public void setLimitRelation(string chars)
      {
        setLimitRelation(stringToLimitRelation(chars));
      }
    public void unsetLimitRelation()
      {
        flagHasLimitRelation = false;
      }
    public void setLimit(double new_value)
      {
        flagHasLimit = true;
        storeLimit = new_value;
        textStoreLimit = "";
      }
    public void setLimitText(string new_value)
      {
        flagHasLimit = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Limit of ChannelErrorCommandJSON is not a valid number.");
        textStoreLimit = new_value;
      }
    public void unsetLimit()
      {
        flagHasLimit = false;
      }

    public virtual void extraChannelErrorCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChannelErrorCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChannelErrorCommandLookup(key);
        if (old_field == null)
          {
            extraChannelErrorCommandAppendPair(key, new_component);
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
    public override void extraCommandErrorAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "and", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONBand(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "hannel", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONChannel(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if (String.Compare(key, 1, "imit", 0, 4, false) == 0)
                  {
                    if (key.Length == 5)
                      {
                        {
                        fromJSONLimit(new_component, false);
                        return;
                        }
                      }
                    switch (key[5])
                      {
                        case 'R':
                            if ((String.Compare(key, 6, "elation", 0, 7, false) == 0) && (key.Length == 13))
                                {
                                fromJSONLimitRelation(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraChannelErrorCommandAppendPair(key, new_component);
      }
    public override void extraCommandErrorSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "and", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONBand(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "hannel", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONChannel(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if (String.Compare(key, 1, "imit", 0, 4, false) == 0)
                  {
                    if (key.Length == 5)
                      {
                        {
                        fromJSONLimit(new_component, false);
                        return;
                        }
                      }
                    switch (key[5])
                      {
                        case 'R':
                            if ((String.Compare(key, 6, "elation", 0, 7, false) == 0) && (key.Length == 13))
                                {
                                fromJSONLimitRelation(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraChannelErrorCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasChannel);
        if (flagHasChannel)
          {
            handler.start_pair("Channel");
            if (textStoreChannel != "")
                handler.number_value(textStoreChannel);
            else if (((double)(long)storeChannel) == storeChannel)
                handler.number_value((long)storeChannel);
            else
                handler.number_value(storeChannel);
          }
        Debug.Assert(partial_allowed || flagHasBand);
        if (flagHasBand)
          {
            handler.start_pair("Band");
            switch (storeBand)
              {
                case TypeBand.Band_AM:
                    handler.string_value("AM");
                    break;
                case TypeBand.Band_FM:
                    handler.string_value("FM");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasLimitRelation)
          {
            handler.start_pair("LimitRelation");
            switch (storeLimitRelation)
              {
                case TypeLimitRelation.LimitRelation_LessThan:
                    handler.string_value("LessThan");
                    break;
                case TypeLimitRelation.LimitRelation_GreaterThan:
                    handler.string_value("GreaterThan");
                    break;
                case TypeLimitRelation.LimitRelation_NotAligned:
                    handler.string_value("NotAligned");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasLimit)
          {
            handler.start_pair("Limit");
            if (textStoreLimit != "")
                handler.number_value(textStoreLimit);
            else if (((double)(long)storeLimit) == storeLimit)
                handler.number_value((long)storeLimit);
            else
                handler.number_value(storeLimit);
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
        if (!(hasChannel()))
          {
            return "When parsing the object for %what%, the \"Channel\" field was missing.";
          }
        if (!(hasBand()))
          {
            return "When parsing the object for %what%, the \"Band\" field was missing.";
          }
        return null;
      }

    public static new ChannelErrorCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChannelErrorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChannelErrorCommand", ignore_extras);
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
    public static new ChannelErrorCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChannelErrorCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChannelErrorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChannelErrorCommand", ignore_extras);
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
    public static new ChannelErrorCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChannelErrorCommandJSON from_text(string text, bool ignore_extras)
      {
        ChannelErrorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChannelErrorCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChannelErrorCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ChannelErrorCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChannelErrorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChannelErrorCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandErrorJSON.Generator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorChannel;
    private abstract class FieldGeneratorBand : JSONStringGenerator
          {
            protected FieldGeneratorBand(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorBand()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToBand(result));
              }
            protected abstract void handle_result(TypeBand result);
          };
    private class FieldHoldingGeneratorBand : FieldGeneratorBand
  {
    protected override void handle_result(TypeBand result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorBand(String what)
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
    public TypeBand value;
  };
    private class FieldHoldingArrayGeneratorBand : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorBand
      {
        private FieldHoldingArrayGeneratorBand top;

        protected override void handle_result(TypeBand result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorBand init_top)
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
    protected virtual void handle_result(List<TypeBand> result)
      {
      }

    public FieldHoldingArrayGeneratorBand(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBand>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorBand()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBand>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeBand> value;
  };
        private FieldHoldingGeneratorBand fieldGeneratorBand;
    private abstract class FieldGeneratorLimitRelation : JSONStringGenerator
          {
            protected FieldGeneratorLimitRelation(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLimitRelation()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToLimitRelation(result));
              }
            protected abstract void handle_result(TypeLimitRelation result);
          };
    private class FieldHoldingGeneratorLimitRelation : FieldGeneratorLimitRelation
  {
    protected override void handle_result(TypeLimitRelation result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLimitRelation(String what)
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
    public TypeLimitRelation value;
  };
    private class FieldHoldingArrayGeneratorLimitRelation : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLimitRelation
      {
        private FieldHoldingArrayGeneratorLimitRelation top;

        protected override void handle_result(TypeLimitRelation result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLimitRelation init_top)
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
    protected virtual void handle_result(List<TypeLimitRelation> result)
      {
      }

    public FieldHoldingArrayGeneratorLimitRelation(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLimitRelation>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLimitRelation()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLimitRelation>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLimitRelation> value;
  };
        private FieldHoldingGeneratorLimitRelation fieldGeneratorLimitRelation;
        private JSONHoldingNumberTextGenerator fieldGeneratorLimit;
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
            if (!(getCommandErrorJSONKey().Equals("RadioChannelError")))
                throw new Exception("The key field has a value other than `RadioChannelError'.");
            ChannelErrorCommandJSON result = new ChannelErrorCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChannelErrorCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandErrorJSON new_result)
          {
            handle_result((ChannelErrorCommandJSON )new_result);
          }
        protected void finish(ChannelErrorCommandJSON result)
          {
            if (fieldGeneratorChannel.have_value)
              {
                result.setChannelText(fieldGeneratorChannel.value);
                fieldGeneratorChannel.have_value = false;
              }
            else if ((!(result.hasChannel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Channel\" field was missing.");
              }
            if (fieldGeneratorBand.have_value)
              {
                result.setBand(fieldGeneratorBand.value);
                fieldGeneratorBand.have_value = false;
              }
            else if ((!(result.hasBand())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Band\" field was missing.");
              }
            if (fieldGeneratorLimitRelation.have_value)
              {
                result.setLimitRelation(fieldGeneratorLimitRelation.value);
                fieldGeneratorLimitRelation.have_value = false;
              }
            if (fieldGeneratorLimit.have_value)
              {
                result.setLimitText(fieldGeneratorLimit.value);
                fieldGeneratorLimit.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ChannelErrorCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "and", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorBand;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "hannel", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorChannel;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "imit", 0, 4, false) == 0)
                      {
                        if (field_name.Length == 5)
                          {
                            return fieldGeneratorLimit;
                          }
                        switch (field_name[5])
                          {
                            case 'R':
                                if ((String.Compare(field_name, 6, "elation", 0, 7, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorLimitRelation;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorChannel = new JSONHoldingNumberTextGenerator("field \"Channel\" of the ChannelErrorCommand class");
            fieldGeneratorBand = new FieldHoldingGeneratorBand("field \"Band\" of the ChannelErrorCommand class");
            fieldGeneratorLimitRelation = new FieldHoldingGeneratorLimitRelation("field \"LimitRelation\" of the ChannelErrorCommand class");
            fieldGeneratorLimit = new JSONHoldingNumberTextGenerator("field \"Limit\" of the ChannelErrorCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChannelErrorCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorChannel = new JSONHoldingNumberTextGenerator("field \"Channel\" of the ChannelErrorCommand class");
            fieldGeneratorBand = new FieldHoldingGeneratorBand("field \"Band\" of the ChannelErrorCommand class");
            fieldGeneratorLimitRelation = new FieldHoldingGeneratorLimitRelation("field \"LimitRelation\" of the ChannelErrorCommand class");
            fieldGeneratorLimit = new JSONHoldingNumberTextGenerator("field \"Limit\" of the ChannelErrorCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChannelErrorCommand class");
          }

        public override void reset()
          {
            fieldGeneratorChannel.reset();
            fieldGeneratorBand.reset();
            fieldGeneratorLimitRelation.reset();
            fieldGeneratorLimit.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ChannelErrorCommandJSON  result)
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
        public ChannelErrorCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChannelErrorCommandJSON  result)
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
    protected virtual void handle_result(List<ChannelErrorCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChannelErrorCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChannelErrorCommandJSON>();
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
    public List<ChannelErrorCommandJSON> value;
  };
  };
