/* file "BigOvenRecipesPosterSingleRecipeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class BigOvenRecipesPosterSingleRecipeJSON : JSONBase
  {
    private bool flagHasUserID;
    private BigInteger storeUserID;
    private bool flagHasUserName;
    private string storeUserName;
    private bool flagHasPhotoUrl;
    private string storePhotoUrl;
    private bool flagHasIsPremium;
    private bool storeIsPremium;
    private bool flagHasIsKitchenHelper;
    private bool storeIsKitchenHelper;
    private bool flagHasPremiumExpiryDate;
    private string storePremiumExpiryDate;
    private bool flagHasMemberSince;
    private string storeMemberSince;
    private bool flagHasIsUsingRecurly;
    private bool storeIsUsingRecurly;
    private bool flagHasFirstName;
    private string storeFirstName;
    private bool flagHasLastName;
    private string storeLastName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUserID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field UserID of BigOvenRecipesPosterSingleRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field UserID of BigOvenRecipesPosterSingleRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setUserID(extracted_integer);
      }


    private void  fromJSONUserName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserName of BigOvenRecipesPosterSingleRecipeJSON is not a string.");
        setUserName(json_string.getData());
      }


    private void  fromJSONPhotoUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PhotoUrl of BigOvenRecipesPosterSingleRecipeJSON is not a string.");
        setPhotoUrl(json_string.getData());
      }


    private void  fromJSONIsPremium(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsPremium of BigOvenRecipesPosterSingleRecipeJSON is not true for false.");
              }
          }
        setIsPremium(the_bool);
      }


    private void  fromJSONIsKitchenHelper(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsKitchenHelper of BigOvenRecipesPosterSingleRecipeJSON is not true for false.");
              }
          }
        setIsKitchenHelper(the_bool);
      }


    private void  fromJSONPremiumExpiryDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PremiumExpiryDate of BigOvenRecipesPosterSingleRecipeJSON is not a string.");
        setPremiumExpiryDate(json_string.getData());
      }


    private void  fromJSONMemberSince(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MemberSince of BigOvenRecipesPosterSingleRecipeJSON is not a string.");
        setMemberSince(json_string.getData());
      }


    private void  fromJSONIsUsingRecurly(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsUsingRecurly of BigOvenRecipesPosterSingleRecipeJSON is not true for false.");
              }
          }
        setIsUsingRecurly(the_bool);
      }


    private void  fromJSONFirstName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FirstName of BigOvenRecipesPosterSingleRecipeJSON is not a string.");
        setFirstName(json_string.getData());
      }


    private void  fromJSONLastName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastName of BigOvenRecipesPosterSingleRecipeJSON is not a string.");
        setLastName(json_string.getData());
      }


    public BigOvenRecipesPosterSingleRecipeJSON()
      {
        flagHasUserID = false;
        flagHasUserName = false;
        flagHasPhotoUrl = false;
        flagHasIsPremium = false;
        flagHasIsKitchenHelper = false;
        flagHasPremiumExpiryDate = false;
        flagHasMemberSince = false;
        flagHasIsUsingRecurly = false;
        flagHasFirstName = false;
        flagHasLastName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUserID()
      {
        return flagHasUserID;
      }

    public BigInteger  getUserID()
      {
        Debug.Assert(flagHasUserID);
        return storeUserID;
      }

    public bool  hasUserName()
      {
        return flagHasUserName;
      }

    public string  getUserName()
      {
        Debug.Assert(flagHasUserName);
        return storeUserName;
      }

    public bool  hasPhotoUrl()
      {
        return flagHasPhotoUrl;
      }

    public string  getPhotoUrl()
      {
        Debug.Assert(flagHasPhotoUrl);
        return storePhotoUrl;
      }

    public bool  hasIsPremium()
      {
        return flagHasIsPremium;
      }

    public bool  getIsPremium()
      {
        Debug.Assert(flagHasIsPremium);
        return storeIsPremium;
      }

    public bool  hasIsKitchenHelper()
      {
        return flagHasIsKitchenHelper;
      }

    public bool  getIsKitchenHelper()
      {
        Debug.Assert(flagHasIsKitchenHelper);
        return storeIsKitchenHelper;
      }

    public bool  hasPremiumExpiryDate()
      {
        return flagHasPremiumExpiryDate;
      }

    public string  getPremiumExpiryDate()
      {
        Debug.Assert(flagHasPremiumExpiryDate);
        return storePremiumExpiryDate;
      }

    public bool  hasMemberSince()
      {
        return flagHasMemberSince;
      }

    public string  getMemberSince()
      {
        Debug.Assert(flagHasMemberSince);
        return storeMemberSince;
      }

    public bool  hasIsUsingRecurly()
      {
        return flagHasIsUsingRecurly;
      }

    public bool  getIsUsingRecurly()
      {
        Debug.Assert(flagHasIsUsingRecurly);
        return storeIsUsingRecurly;
      }

    public bool  hasFirstName()
      {
        return flagHasFirstName;
      }

    public string  getFirstName()
      {
        Debug.Assert(flagHasFirstName);
        return storeFirstName;
      }

    public bool  hasLastName()
      {
        return flagHasLastName;
      }

    public string  getLastName()
      {
        Debug.Assert(flagHasLastName);
        return storeLastName;
      }


    public virtual int extraBigOvenRecipesPosterSingleRecipeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBigOvenRecipesPosterSingleRecipeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBigOvenRecipesPosterSingleRecipeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBigOvenRecipesPosterSingleRecipeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setUserID(BigInteger new_value)
      {
        flagHasUserID = true;
        if (new_value < 0)
            throw new Exception("The value for field UserID of BigOvenRecipesPosterSingleRecipeJSON is less than the lower bound (0) for that field.");
        storeUserID = new_value;
      }
    public void unsetUserID()
      {
        flagHasUserID = false;
      }
    public void setUserName(string new_value)
      {
        flagHasUserName = true;
        storeUserName = new_value;
      }
    public void unsetUserName()
      {
        flagHasUserName = false;
      }
    public void setPhotoUrl(string new_value)
      {
        flagHasPhotoUrl = true;
        storePhotoUrl = new_value;
      }
    public void unsetPhotoUrl()
      {
        flagHasPhotoUrl = false;
      }
    public void setIsPremium(bool new_value)
      {
        flagHasIsPremium = true;
        storeIsPremium = new_value;
      }
    public void unsetIsPremium()
      {
        flagHasIsPremium = false;
      }
    public void setIsKitchenHelper(bool new_value)
      {
        flagHasIsKitchenHelper = true;
        storeIsKitchenHelper = new_value;
      }
    public void unsetIsKitchenHelper()
      {
        flagHasIsKitchenHelper = false;
      }
    public void setPremiumExpiryDate(string new_value)
      {
        flagHasPremiumExpiryDate = true;
        storePremiumExpiryDate = new_value;
      }
    public void unsetPremiumExpiryDate()
      {
        flagHasPremiumExpiryDate = false;
      }
    public void setMemberSince(string new_value)
      {
        flagHasMemberSince = true;
        storeMemberSince = new_value;
      }
    public void unsetMemberSince()
      {
        flagHasMemberSince = false;
      }
    public void setIsUsingRecurly(bool new_value)
      {
        flagHasIsUsingRecurly = true;
        storeIsUsingRecurly = new_value;
      }
    public void unsetIsUsingRecurly()
      {
        flagHasIsUsingRecurly = false;
      }
    public void setFirstName(string new_value)
      {
        flagHasFirstName = true;
        storeFirstName = new_value;
      }
    public void unsetFirstName()
      {
        flagHasFirstName = false;
      }
    public void setLastName(string new_value)
      {
        flagHasLastName = true;
        storeLastName = new_value;
      }
    public void unsetLastName()
      {
        flagHasLastName = false;
      }

    public virtual void extraBigOvenRecipesPosterSingleRecipeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBigOvenRecipesPosterSingleRecipeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBigOvenRecipesPosterSingleRecipeLookup(key);
        if (old_field == null)
          {
            extraBigOvenRecipesPosterSingleRecipeAppendPair(key, new_component);
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
        if (flagHasUserID)
          {
            handler.start_pair("UserID");
            handler.number_value(storeUserID);
          }
        if (flagHasUserName)
          {
            handler.start_pair("UserName");
            handler.string_value(storeUserName);
          }
        if (flagHasPhotoUrl)
          {
            handler.start_pair("PhotoUrl");
            handler.string_value(storePhotoUrl);
          }
        if (flagHasIsPremium)
          {
            handler.start_pair("IsPremium");
            handler.boolean_value(storeIsPremium);
          }
        if (flagHasIsKitchenHelper)
          {
            handler.start_pair("IsKitchenHelper");
            handler.boolean_value(storeIsKitchenHelper);
          }
        if (flagHasPremiumExpiryDate)
          {
            handler.start_pair("PremiumExpiryDate");
            handler.string_value(storePremiumExpiryDate);
          }
        if (flagHasMemberSince)
          {
            handler.start_pair("MemberSince");
            handler.string_value(storeMemberSince);
          }
        if (flagHasIsUsingRecurly)
          {
            handler.start_pair("IsUsingRecurly");
            handler.boolean_value(storeIsUsingRecurly);
          }
        if (flagHasFirstName)
          {
            handler.start_pair("FirstName");
            handler.string_value(storeFirstName);
          }
        if (flagHasLastName)
          {
            handler.start_pair("LastName");
            handler.string_value(storeLastName);
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

    public static BigOvenRecipesPosterSingleRecipeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BigOvenRecipesPosterSingleRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesPosterSingleRecipe", ignore_extras);
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
    public static BigOvenRecipesPosterSingleRecipeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BigOvenRecipesPosterSingleRecipeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BigOvenRecipesPosterSingleRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesPosterSingleRecipe", ignore_extras);
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
    public static BigOvenRecipesPosterSingleRecipeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BigOvenRecipesPosterSingleRecipeJSON from_text(string text, bool ignore_extras)
      {
        BigOvenRecipesPosterSingleRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesPosterSingleRecipe", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BigOvenRecipesPosterSingleRecipeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BigOvenRecipesPosterSingleRecipeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BigOvenRecipesPosterSingleRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesPosterSingleRecipe", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorUserID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorUserID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorUserID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorUserID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorUserID fieldGeneratorUserID;
        private JSONHoldingStringGenerator fieldGeneratorUserName;
        private JSONHoldingStringGenerator fieldGeneratorPhotoUrl;
        private JSONHoldingBooleanGenerator fieldGeneratorIsPremium;
        private JSONHoldingBooleanGenerator fieldGeneratorIsKitchenHelper;
        private JSONHoldingStringGenerator fieldGeneratorPremiumExpiryDate;
        private JSONHoldingStringGenerator fieldGeneratorMemberSince;
        private JSONHoldingBooleanGenerator fieldGeneratorIsUsingRecurly;
        private JSONHoldingStringGenerator fieldGeneratorFirstName;
        private JSONHoldingStringGenerator fieldGeneratorLastName;
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
            BigOvenRecipesPosterSingleRecipeJSON result = new BigOvenRecipesPosterSingleRecipeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBigOvenRecipesPosterSingleRecipeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BigOvenRecipesPosterSingleRecipeJSON result)
          {
            if (fieldGeneratorUserID.have_value)
              {
                result.setUserID(fieldGeneratorUserID.value);
                fieldGeneratorUserID.have_value = false;
              }
            if (fieldGeneratorUserName.have_value)
              {
                result.setUserName(fieldGeneratorUserName.value);
                fieldGeneratorUserName.have_value = false;
              }
            if (fieldGeneratorPhotoUrl.have_value)
              {
                result.setPhotoUrl(fieldGeneratorPhotoUrl.value);
                fieldGeneratorPhotoUrl.have_value = false;
              }
            if (fieldGeneratorIsPremium.have_value)
              {
                result.setIsPremium(fieldGeneratorIsPremium.value);
                fieldGeneratorIsPremium.have_value = false;
              }
            if (fieldGeneratorIsKitchenHelper.have_value)
              {
                result.setIsKitchenHelper(fieldGeneratorIsKitchenHelper.value);
                fieldGeneratorIsKitchenHelper.have_value = false;
              }
            if (fieldGeneratorPremiumExpiryDate.have_value)
              {
                result.setPremiumExpiryDate(fieldGeneratorPremiumExpiryDate.value);
                fieldGeneratorPremiumExpiryDate.have_value = false;
              }
            if (fieldGeneratorMemberSince.have_value)
              {
                result.setMemberSince(fieldGeneratorMemberSince.value);
                fieldGeneratorMemberSince.have_value = false;
              }
            if (fieldGeneratorIsUsingRecurly.have_value)
              {
                result.setIsUsingRecurly(fieldGeneratorIsUsingRecurly.value);
                fieldGeneratorIsUsingRecurly.have_value = false;
              }
            if (fieldGeneratorFirstName.have_value)
              {
                result.setFirstName(fieldGeneratorFirstName.value);
                fieldGeneratorFirstName.have_value = false;
              }
            if (fieldGeneratorLastName.have_value)
              {
                result.setLastName(fieldGeneratorLastName.value);
                fieldGeneratorLastName.have_value = false;
              }
          }
        protected abstract void handle_result(BigOvenRecipesPosterSingleRecipeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "irstName", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorFirstName;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'K':
                                if ((String.Compare(field_name, 3, "itchenHelper", 0, 12, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorIsKitchenHelper;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 3, "remium", 0, 6, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorIsPremium;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 3, "singRecurly", 0, 11, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorIsUsingRecurly;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLastName;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "emberSince", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMemberSince;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "otoUrl", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPhotoUrl;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "emiumExpiryDate", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorPremiumExpiryDate;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "ser", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 5, "D", 0, 1, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorUserID;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 5, "ame", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorUserName;
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
            fieldGeneratorUserID = new FieldHoldingGeneratorUserID("field \"UserID\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorUserName = new JSONHoldingStringGenerator("field \"UserName\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorPhotoUrl = new JSONHoldingStringGenerator("field \"PhotoUrl\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorIsPremium = new JSONHoldingBooleanGenerator("field \"IsPremium\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorIsKitchenHelper = new JSONHoldingBooleanGenerator("field \"IsKitchenHelper\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorPremiumExpiryDate = new JSONHoldingStringGenerator("field \"PremiumExpiryDate\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorMemberSince = new JSONHoldingStringGenerator("field \"MemberSince\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorIsUsingRecurly = new JSONHoldingBooleanGenerator("field \"IsUsingRecurly\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorFirstName = new JSONHoldingStringGenerator("field \"FirstName\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the BigOvenRecipesPosterSingleRecipe class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BigOvenRecipesPosterSingleRecipe class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUserID = new FieldHoldingGeneratorUserID("field \"UserID\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorUserName = new JSONHoldingStringGenerator("field \"UserName\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorPhotoUrl = new JSONHoldingStringGenerator("field \"PhotoUrl\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorIsPremium = new JSONHoldingBooleanGenerator("field \"IsPremium\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorIsKitchenHelper = new JSONHoldingBooleanGenerator("field \"IsKitchenHelper\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorPremiumExpiryDate = new JSONHoldingStringGenerator("field \"PremiumExpiryDate\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorMemberSince = new JSONHoldingStringGenerator("field \"MemberSince\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorIsUsingRecurly = new JSONHoldingBooleanGenerator("field \"IsUsingRecurly\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorFirstName = new JSONHoldingStringGenerator("field \"FirstName\" of the BigOvenRecipesPosterSingleRecipe class");
            fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the BigOvenRecipesPosterSingleRecipe class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BigOvenRecipesPosterSingleRecipe class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUserID.reset();
            fieldGeneratorUserName.reset();
            fieldGeneratorPhotoUrl.reset();
            fieldGeneratorIsPremium.reset();
            fieldGeneratorIsKitchenHelper.reset();
            fieldGeneratorPremiumExpiryDate.reset();
            fieldGeneratorMemberSince.reset();
            fieldGeneratorIsUsingRecurly.reset();
            fieldGeneratorFirstName.reset();
            fieldGeneratorLastName.reset();
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
        protected override void handle_result(BigOvenRecipesPosterSingleRecipeJSON  result)
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
        public BigOvenRecipesPosterSingleRecipeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BigOvenRecipesPosterSingleRecipeJSON  result)
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
    protected virtual void handle_result(List<BigOvenRecipesPosterSingleRecipeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BigOvenRecipesPosterSingleRecipeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BigOvenRecipesPosterSingleRecipeJSON>();
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
    public List<BigOvenRecipesPosterSingleRecipeJSON> value;
  };
  };
