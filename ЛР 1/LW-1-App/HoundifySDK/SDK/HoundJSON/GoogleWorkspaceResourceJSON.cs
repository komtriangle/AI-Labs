/* file "GoogleWorkspaceResourceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class GoogleWorkspaceResourceJSON : InternalThirdPartyRoomJSON
  {
    private bool flagHaskind;
    private string storekind;
    private bool flagHasetags;
    private string storeetags;
    private bool flagHasresourceName;
    private string storeresourceName;
    private bool flagHasresourceDescription;
    private string storeresourceDescription;
    private bool flagHasresourceType;
    private string storeresourceType;
    private bool flagHasresourceEmail;
    private string storeresourceEmail;
    private bool flagHasresourceCategory;
    private string storeresourceCategory;
    private bool flagHasuserVisibleDescription;
    private string storeuserVisibleDescription;
    private bool flagHasgeneratedResourceName;
    private string storegeneratedResourceName;
    private bool flagHasresourceId;
    private string storeresourceId;
    private bool flagHascapacity;
    private BigInteger storecapacity;
    private bool flagHasfloorName;
    private string storefloorName;
    private bool flagHasbuildingId;
    private string storebuildingId;
    private bool flagHasfloorSection;
    private string storefloorSection;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extrakindToJSON()
      {
        JSONStringValue generated_string_kind = new JSONStringValue(storekind);
        return generated_string_kind;
      }

    private JSONValue  extraetagsToJSON()
      {
        JSONStringValue generated_string_etags = new JSONStringValue(storeetags);
        return generated_string_etags;
      }

    private JSONValue  extraresourceNameToJSON()
      {
        JSONStringValue generated_string_resourceName = new JSONStringValue(storeresourceName);
        return generated_string_resourceName;
      }

    private JSONValue  extraresourceDescriptionToJSON()
      {
        JSONStringValue generated_string_resourceDescription = new JSONStringValue(storeresourceDescription);
        return generated_string_resourceDescription;
      }

    private JSONValue  extraresourceTypeToJSON()
      {
        JSONStringValue generated_string_resourceType = new JSONStringValue(storeresourceType);
        return generated_string_resourceType;
      }

    private JSONValue  extraresourceEmailToJSON()
      {
        JSONStringValue generated_string_resourceEmail = new JSONStringValue(storeresourceEmail);
        return generated_string_resourceEmail;
      }

    private JSONValue  extraresourceCategoryToJSON()
      {
        JSONStringValue generated_string_resourceCategory = new JSONStringValue(storeresourceCategory);
        return generated_string_resourceCategory;
      }

    private JSONValue  extrauserVisibleDescriptionToJSON()
      {
        JSONStringValue generated_string_userVisibleDescription = new JSONStringValue(storeuserVisibleDescription);
        return generated_string_userVisibleDescription;
      }

    private JSONValue  extrageneratedResourceNameToJSON()
      {
        JSONStringValue generated_string_generatedResourceName = new JSONStringValue(storegeneratedResourceName);
        return generated_string_generatedResourceName;
      }

    private JSONValue  extraresourceIdToJSON()
      {
        JSONStringValue generated_string_resourceId = new JSONStringValue(storeresourceId);
        return generated_string_resourceId;
      }

    private JSONValue  extracapacityToJSON()
      {
        JSONIntegerValue generated_integer_capacity = new JSONIntegerValue(storecapacity);
        return generated_integer_capacity;
      }

    private JSONValue  extrafloorNameToJSON()
      {
        JSONStringValue generated_string_floorName = new JSONStringValue(storefloorName);
        return generated_string_floorName;
      }

    private JSONValue  extrabuildingIdToJSON()
      {
        JSONStringValue generated_string_buildingId = new JSONStringValue(storebuildingId);
        return generated_string_buildingId;
      }

    private JSONValue  extrafloorSectionToJSON()
      {
        JSONStringValue generated_string_floorSection = new JSONStringValue(storefloorSection);
        return generated_string_floorSection;
      }


    private void  fromJSONkind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field kind of GoogleWorkspaceResourceJSON is not a string.");
        setkind(json_string.getData());
      }


    private void  fromJSONetags(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field etags of GoogleWorkspaceResourceJSON is not a string.");
        setetags(json_string.getData());
      }


    private void  fromJSONresourceName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field resourceName of GoogleWorkspaceResourceJSON is not a string.");
        setresourceName(json_string.getData());
      }


    private void  fromJSONresourceDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field resourceDescription of GoogleWorkspaceResourceJSON is not a string.");
        setresourceDescription(json_string.getData());
      }


    private void  fromJSONresourceType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field resourceType of GoogleWorkspaceResourceJSON is not a string.");
        setresourceType(json_string.getData());
      }


    private void  fromJSONresourceEmail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field resourceEmail of GoogleWorkspaceResourceJSON is not a string.");
        setresourceEmail(json_string.getData());
      }


    private void  fromJSONresourceCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field resourceCategory of GoogleWorkspaceResourceJSON is not a string.");
        setresourceCategory(json_string.getData());
      }


    private void  fromJSONuserVisibleDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field userVisibleDescription of GoogleWorkspaceResourceJSON is not a string.");
        setuserVisibleDescription(json_string.getData());
      }


    private void  fromJSONgeneratedResourceName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field generatedResourceName of GoogleWorkspaceResourceJSON is not a string.");
        setgeneratedResourceName(json_string.getData());
      }


    private void  fromJSONresourceId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field resourceId of GoogleWorkspaceResourceJSON is not a string.");
        setresourceId(json_string.getData());
      }


    private void  fromJSONcapacity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field capacity of GoogleWorkspaceResourceJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field capacity of GoogleWorkspaceResourceJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setcapacity(extracted_integer);
      }


    private void  fromJSONfloorName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field floorName of GoogleWorkspaceResourceJSON is not a string.");
        setfloorName(json_string.getData());
      }


    private void  fromJSONbuildingId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field buildingId of GoogleWorkspaceResourceJSON is not a string.");
        setbuildingId(json_string.getData());
      }


    private void  fromJSONfloorSection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field floorSection of GoogleWorkspaceResourceJSON is not a string.");
        setfloorSection(json_string.getData());
      }


    public GoogleWorkspaceResourceJSON()
      {
        flagHaskind = false;
        flagHasetags = false;
        flagHasresourceName = false;
        flagHasresourceDescription = false;
        flagHasresourceType = false;
        flagHasresourceEmail = false;
        flagHasresourceCategory = false;
        flagHasuserVisibleDescription = false;
        flagHasgeneratedResourceName = false;
        flagHasresourceId = false;
        flagHascapacity = false;
        flagHasfloorName = false;
        flagHasbuildingId = false;
        flagHasfloorSection = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyAPIName()
      {
        return "GoogleWorkspace";
      }

    public bool  haskind()
      {
        return flagHaskind;
      }

    public string  getkind()
      {
        Debug.Assert(flagHaskind);
        return storekind;
      }

    public bool  hasetags()
      {
        return flagHasetags;
      }

    public string  getetags()
      {
        Debug.Assert(flagHasetags);
        return storeetags;
      }

    public bool  hasresourceName()
      {
        return flagHasresourceName;
      }

    public string  getresourceName()
      {
        Debug.Assert(flagHasresourceName);
        return storeresourceName;
      }

    public bool  hasresourceDescription()
      {
        return flagHasresourceDescription;
      }

    public string  getresourceDescription()
      {
        Debug.Assert(flagHasresourceDescription);
        return storeresourceDescription;
      }

    public bool  hasresourceType()
      {
        return flagHasresourceType;
      }

    public string  getresourceType()
      {
        Debug.Assert(flagHasresourceType);
        return storeresourceType;
      }

    public bool  hasresourceEmail()
      {
        return flagHasresourceEmail;
      }

    public string  getresourceEmail()
      {
        Debug.Assert(flagHasresourceEmail);
        return storeresourceEmail;
      }

    public bool  hasresourceCategory()
      {
        return flagHasresourceCategory;
      }

    public string  getresourceCategory()
      {
        Debug.Assert(flagHasresourceCategory);
        return storeresourceCategory;
      }

    public bool  hasuserVisibleDescription()
      {
        return flagHasuserVisibleDescription;
      }

    public string  getuserVisibleDescription()
      {
        Debug.Assert(flagHasuserVisibleDescription);
        return storeuserVisibleDescription;
      }

    public bool  hasgeneratedResourceName()
      {
        return flagHasgeneratedResourceName;
      }

    public string  getgeneratedResourceName()
      {
        Debug.Assert(flagHasgeneratedResourceName);
        return storegeneratedResourceName;
      }

    public bool  hasresourceId()
      {
        return flagHasresourceId;
      }

    public string  getresourceId()
      {
        Debug.Assert(flagHasresourceId);
        return storeresourceId;
      }

    public bool  hascapacity()
      {
        return flagHascapacity;
      }

    public BigInteger  getcapacity()
      {
        Debug.Assert(flagHascapacity);
        return storecapacity;
      }

    public bool  hasfloorName()
      {
        return flagHasfloorName;
      }

    public string  getfloorName()
      {
        Debug.Assert(flagHasfloorName);
        return storefloorName;
      }

    public bool  hasbuildingId()
      {
        return flagHasbuildingId;
      }

    public string  getbuildingId()
      {
        Debug.Assert(flagHasbuildingId);
        return storebuildingId;
      }

    public bool  hasfloorSection()
      {
        return flagHasfloorSection;
      }

    public string  getfloorSection()
      {
        Debug.Assert(flagHasfloorSection);
        return storefloorSection;
      }


    public virtual int extraGoogleWorkspaceResourceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGoogleWorkspaceResourceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGoogleWorkspaceResourceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGoogleWorkspaceResourceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInternalThirdPartyRoomComponentCount()
      {
        int result = 0;
        if (flagHaskind)
            ++result;
        if (flagHasetags)
            ++result;
        if (flagHasresourceName)
            ++result;
        if (flagHasresourceDescription)
            ++result;
        if (flagHasresourceType)
            ++result;
        if (flagHasresourceEmail)
            ++result;
        if (flagHasresourceCategory)
            ++result;
        if (flagHasuserVisibleDescription)
            ++result;
        if (flagHasgeneratedResourceName)
            ++result;
        if (flagHasresourceId)
            ++result;
        if (flagHascapacity)
            ++result;
        if (flagHasfloorName)
            ++result;
        if (flagHasbuildingId)
            ++result;
        if (flagHasfloorSection)
            ++result;
        result += extraGoogleWorkspaceResourceComponentCount();
        return result;
      }
    public override string extraInternalThirdPartyRoomComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHaskind)
          {
            if (remainder == 0)
                return "kind";
            --remainder;
          }
        if (flagHasetags)
          {
            if (remainder == 0)
                return "etags";
            --remainder;
          }
        if (flagHasresourceName)
          {
            if (remainder == 0)
                return "resourceName";
            --remainder;
          }
        if (flagHasresourceDescription)
          {
            if (remainder == 0)
                return "resourceDescription";
            --remainder;
          }
        if (flagHasresourceType)
          {
            if (remainder == 0)
                return "resourceType";
            --remainder;
          }
        if (flagHasresourceEmail)
          {
            if (remainder == 0)
                return "resourceEmail";
            --remainder;
          }
        if (flagHasresourceCategory)
          {
            if (remainder == 0)
                return "resourceCategory";
            --remainder;
          }
        if (flagHasuserVisibleDescription)
          {
            if (remainder == 0)
                return "userVisibleDescription";
            --remainder;
          }
        if (flagHasgeneratedResourceName)
          {
            if (remainder == 0)
                return "generatedResourceName";
            --remainder;
          }
        if (flagHasresourceId)
          {
            if (remainder == 0)
                return "resourceId";
            --remainder;
          }
        if (flagHascapacity)
          {
            if (remainder == 0)
                return "capacity";
            --remainder;
          }
        if (flagHasfloorName)
          {
            if (remainder == 0)
                return "floorName";
            --remainder;
          }
        if (flagHasbuildingId)
          {
            if (remainder == 0)
                return "buildingId";
            --remainder;
          }
        if (flagHasfloorSection)
          {
            if (remainder == 0)
                return "floorSection";
            --remainder;
          }
        return extraGoogleWorkspaceResourceComponentKey(remainder);
      }
    public override JSONValue extraInternalThirdPartyRoomComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHaskind)
          {
            if (remainder == 0)
                return extrakindToJSON();
            --remainder;
          }
        if (flagHasetags)
          {
            if (remainder == 0)
                return extraetagsToJSON();
            --remainder;
          }
        if (flagHasresourceName)
          {
            if (remainder == 0)
                return extraresourceNameToJSON();
            --remainder;
          }
        if (flagHasresourceDescription)
          {
            if (remainder == 0)
                return extraresourceDescriptionToJSON();
            --remainder;
          }
        if (flagHasresourceType)
          {
            if (remainder == 0)
                return extraresourceTypeToJSON();
            --remainder;
          }
        if (flagHasresourceEmail)
          {
            if (remainder == 0)
                return extraresourceEmailToJSON();
            --remainder;
          }
        if (flagHasresourceCategory)
          {
            if (remainder == 0)
                return extraresourceCategoryToJSON();
            --remainder;
          }
        if (flagHasuserVisibleDescription)
          {
            if (remainder == 0)
                return extrauserVisibleDescriptionToJSON();
            --remainder;
          }
        if (flagHasgeneratedResourceName)
          {
            if (remainder == 0)
                return extrageneratedResourceNameToJSON();
            --remainder;
          }
        if (flagHasresourceId)
          {
            if (remainder == 0)
                return extraresourceIdToJSON();
            --remainder;
          }
        if (flagHascapacity)
          {
            if (remainder == 0)
                return extracapacityToJSON();
            --remainder;
          }
        if (flagHasfloorName)
          {
            if (remainder == 0)
                return extrafloorNameToJSON();
            --remainder;
          }
        if (flagHasbuildingId)
          {
            if (remainder == 0)
                return extrabuildingIdToJSON();
            --remainder;
          }
        if (flagHasfloorSection)
          {
            if (remainder == 0)
                return extrafloorSectionToJSON();
            --remainder;
          }
        return extraGoogleWorkspaceResourceComponentValue(remainder);
      }
    public override JSONValue extraInternalThirdPartyRoomLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'b':
                if ((String.Compare(field_name, 1, "uildingId", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasbuildingId ? extrabuildingIdToJSON() : null);
                break;
            case 'c':
                if ((String.Compare(field_name, 1, "apacity", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHascapacity ? extracapacityToJSON() : null);
                break;
            case 'e':
                if ((String.Compare(field_name, 1, "tags", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasetags ? extraetagsToJSON() : null);
                break;
            case 'f':
                if (String.Compare(field_name, 1, "loor", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                return (flagHasfloorName ? extrafloorNameToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 6, "ection", 0, 6, false) == 0) && (field_name.Length == 12))
                                return (flagHasfloorSection ? extrafloorSectionToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'g':
                if ((String.Compare(field_name, 1, "eneratedResourceName", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasgeneratedResourceName ? extrageneratedResourceNameToJSON() : null);
                break;
            case 'k':
                if ((String.Compare(field_name, 1, "ind", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHaskind ? extrakindToJSON() : null);
                break;
            case 'r':
                if (String.Compare(field_name, 1, "esource", 0, 7, false) == 0)
                  {
                    switch (field_name[8])
                      {
                        case 'C':
                            if ((String.Compare(field_name, 9, "ategory", 0, 7, false) == 0) && (field_name.Length == 16))
                                return (flagHasresourceCategory ? extraresourceCategoryToJSON() : null);
                            break;
                        case 'D':
                            if ((String.Compare(field_name, 9, "escription", 0, 10, false) == 0) && (field_name.Length == 19))
                                return (flagHasresourceDescription ? extraresourceDescriptionToJSON() : null);
                            break;
                        case 'E':
                            if ((String.Compare(field_name, 9, "mail", 0, 4, false) == 0) && (field_name.Length == 13))
                                return (flagHasresourceEmail ? extraresourceEmailToJSON() : null);
                            break;
                        case 'I':
                            if ((String.Compare(field_name, 9, "d", 0, 1, false) == 0) && (field_name.Length == 10))
                                return (flagHasresourceId ? extraresourceIdToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 9, "ame", 0, 3, false) == 0) && (field_name.Length == 12))
                                return (flagHasresourceName ? extraresourceNameToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 9, "ype", 0, 3, false) == 0) && (field_name.Length == 12))
                                return (flagHasresourceType ? extraresourceTypeToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'u':
                if ((String.Compare(field_name, 1, "serVisibleDescription", 0, 21, false) == 0) && (field_name.Length == 22))
                    return (flagHasuserVisibleDescription ? extrauserVisibleDescriptionToJSON() : null);
                break;
            default:
                break;
          }
        return extraGoogleWorkspaceResourceLookup(field_name);
      }

    public void setkind(string new_value)
      {
        flagHaskind = true;
        storekind = new_value;
      }
    public void unsetkind()
      {
        flagHaskind = false;
      }
    public void setetags(string new_value)
      {
        flagHasetags = true;
        storeetags = new_value;
      }
    public void unsetetags()
      {
        flagHasetags = false;
      }
    public void setresourceName(string new_value)
      {
        flagHasresourceName = true;
        storeresourceName = new_value;
      }
    public void unsetresourceName()
      {
        flagHasresourceName = false;
      }
    public void setresourceDescription(string new_value)
      {
        flagHasresourceDescription = true;
        storeresourceDescription = new_value;
      }
    public void unsetresourceDescription()
      {
        flagHasresourceDescription = false;
      }
    public void setresourceType(string new_value)
      {
        flagHasresourceType = true;
        storeresourceType = new_value;
      }
    public void unsetresourceType()
      {
        flagHasresourceType = false;
      }
    public void setresourceEmail(string new_value)
      {
        flagHasresourceEmail = true;
        storeresourceEmail = new_value;
      }
    public void unsetresourceEmail()
      {
        flagHasresourceEmail = false;
      }
    public void setresourceCategory(string new_value)
      {
        flagHasresourceCategory = true;
        storeresourceCategory = new_value;
      }
    public void unsetresourceCategory()
      {
        flagHasresourceCategory = false;
      }
    public void setuserVisibleDescription(string new_value)
      {
        flagHasuserVisibleDescription = true;
        storeuserVisibleDescription = new_value;
      }
    public void unsetuserVisibleDescription()
      {
        flagHasuserVisibleDescription = false;
      }
    public void setgeneratedResourceName(string new_value)
      {
        flagHasgeneratedResourceName = true;
        storegeneratedResourceName = new_value;
      }
    public void unsetgeneratedResourceName()
      {
        flagHasgeneratedResourceName = false;
      }
    public void setresourceId(string new_value)
      {
        flagHasresourceId = true;
        storeresourceId = new_value;
      }
    public void unsetresourceId()
      {
        flagHasresourceId = false;
      }
    public void setcapacity(BigInteger new_value)
      {
        flagHascapacity = true;
        storecapacity = new_value;
      }
    public void unsetcapacity()
      {
        flagHascapacity = false;
      }
    public void setfloorName(string new_value)
      {
        flagHasfloorName = true;
        storefloorName = new_value;
      }
    public void unsetfloorName()
      {
        flagHasfloorName = false;
      }
    public void setbuildingId(string new_value)
      {
        flagHasbuildingId = true;
        storebuildingId = new_value;
      }
    public void unsetbuildingId()
      {
        flagHasbuildingId = false;
      }
    public void setfloorSection(string new_value)
      {
        flagHasfloorSection = true;
        storefloorSection = new_value;
      }
    public void unsetfloorSection()
      {
        flagHasfloorSection = false;
      }

    public virtual void extraGoogleWorkspaceResourceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGoogleWorkspaceResourceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGoogleWorkspaceResourceLookup(key);
        if (old_field == null)
          {
            extraGoogleWorkspaceResourceAppendPair(key, new_component);
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
    public override void extraInternalThirdPartyRoomAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'b':
                if ((String.Compare(key, 1, "uildingId", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONbuildingId(new_component, false);
                    return;
                    }
                break;
            case 'c':
                if ((String.Compare(key, 1, "apacity", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONcapacity(new_component, false);
                    return;
                    }
                break;
            case 'e':
                if ((String.Compare(key, 1, "tags", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONetags(new_component, false);
                    return;
                    }
                break;
            case 'f':
                if (String.Compare(key, 1, "loor", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'N':
                            if ((String.Compare(key, 6, "ame", 0, 3, false) == 0) && (key.Length == 9))
                                {
                                fromJSONfloorName(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 6, "ection", 0, 6, false) == 0) && (key.Length == 12))
                                {
                                fromJSONfloorSection(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'g':
                if ((String.Compare(key, 1, "eneratedResourceName", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONgeneratedResourceName(new_component, false);
                    return;
                    }
                break;
            case 'k':
                if ((String.Compare(key, 1, "ind", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONkind(new_component, false);
                    return;
                    }
                break;
            case 'r':
                if (String.Compare(key, 1, "esource", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'C':
                            if ((String.Compare(key, 9, "ategory", 0, 7, false) == 0) && (key.Length == 16))
                                {
                                fromJSONresourceCategory(new_component, false);
                                return;
                                }
                            break;
                        case 'D':
                            if ((String.Compare(key, 9, "escription", 0, 10, false) == 0) && (key.Length == 19))
                                {
                                fromJSONresourceDescription(new_component, false);
                                return;
                                }
                            break;
                        case 'E':
                            if ((String.Compare(key, 9, "mail", 0, 4, false) == 0) && (key.Length == 13))
                                {
                                fromJSONresourceEmail(new_component, false);
                                return;
                                }
                            break;
                        case 'I':
                            if ((String.Compare(key, 9, "d", 0, 1, false) == 0) && (key.Length == 10))
                                {
                                fromJSONresourceId(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 9, "ame", 0, 3, false) == 0) && (key.Length == 12))
                                {
                                fromJSONresourceName(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 9, "ype", 0, 3, false) == 0) && (key.Length == 12))
                                {
                                fromJSONresourceType(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'u':
                if ((String.Compare(key, 1, "serVisibleDescription", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONuserVisibleDescription(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGoogleWorkspaceResourceAppendPair(key, new_component);
      }
    public override void extraInternalThirdPartyRoomSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'b':
                if ((String.Compare(key, 1, "uildingId", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONbuildingId(new_component, false);
                    return;
                    }
                break;
            case 'c':
                if ((String.Compare(key, 1, "apacity", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONcapacity(new_component, false);
                    return;
                    }
                break;
            case 'e':
                if ((String.Compare(key, 1, "tags", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONetags(new_component, false);
                    return;
                    }
                break;
            case 'f':
                if (String.Compare(key, 1, "loor", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'N':
                            if ((String.Compare(key, 6, "ame", 0, 3, false) == 0) && (key.Length == 9))
                                {
                                fromJSONfloorName(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 6, "ection", 0, 6, false) == 0) && (key.Length == 12))
                                {
                                fromJSONfloorSection(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'g':
                if ((String.Compare(key, 1, "eneratedResourceName", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONgeneratedResourceName(new_component, false);
                    return;
                    }
                break;
            case 'k':
                if ((String.Compare(key, 1, "ind", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONkind(new_component, false);
                    return;
                    }
                break;
            case 'r':
                if (String.Compare(key, 1, "esource", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'C':
                            if ((String.Compare(key, 9, "ategory", 0, 7, false) == 0) && (key.Length == 16))
                                {
                                fromJSONresourceCategory(new_component, false);
                                return;
                                }
                            break;
                        case 'D':
                            if ((String.Compare(key, 9, "escription", 0, 10, false) == 0) && (key.Length == 19))
                                {
                                fromJSONresourceDescription(new_component, false);
                                return;
                                }
                            break;
                        case 'E':
                            if ((String.Compare(key, 9, "mail", 0, 4, false) == 0) && (key.Length == 13))
                                {
                                fromJSONresourceEmail(new_component, false);
                                return;
                                }
                            break;
                        case 'I':
                            if ((String.Compare(key, 9, "d", 0, 1, false) == 0) && (key.Length == 10))
                                {
                                fromJSONresourceId(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 9, "ame", 0, 3, false) == 0) && (key.Length == 12))
                                {
                                fromJSONresourceName(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 9, "ype", 0, 3, false) == 0) && (key.Length == 12))
                                {
                                fromJSONresourceType(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'u':
                if ((String.Compare(key, 1, "serVisibleDescription", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONuserVisibleDescription(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGoogleWorkspaceResourceSetField(key, new_component);
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
        if (flagHaskind)
          {
            handler.start_pair("kind");
            handler.string_value(storekind);
          }
        if (flagHasetags)
          {
            handler.start_pair("etags");
            handler.string_value(storeetags);
          }
        if (flagHasresourceName)
          {
            handler.start_pair("resourceName");
            handler.string_value(storeresourceName);
          }
        if (flagHasresourceDescription)
          {
            handler.start_pair("resourceDescription");
            handler.string_value(storeresourceDescription);
          }
        if (flagHasresourceType)
          {
            handler.start_pair("resourceType");
            handler.string_value(storeresourceType);
          }
        if (flagHasresourceEmail)
          {
            handler.start_pair("resourceEmail");
            handler.string_value(storeresourceEmail);
          }
        if (flagHasresourceCategory)
          {
            handler.start_pair("resourceCategory");
            handler.string_value(storeresourceCategory);
          }
        if (flagHasuserVisibleDescription)
          {
            handler.start_pair("userVisibleDescription");
            handler.string_value(storeuserVisibleDescription);
          }
        if (flagHasgeneratedResourceName)
          {
            handler.start_pair("generatedResourceName");
            handler.string_value(storegeneratedResourceName);
          }
        if (flagHasresourceId)
          {
            handler.start_pair("resourceId");
            handler.string_value(storeresourceId);
          }
        if (flagHascapacity)
          {
            handler.start_pair("capacity");
            handler.number_value(storecapacity);
          }
        if (flagHasfloorName)
          {
            handler.start_pair("floorName");
            handler.string_value(storefloorName);
          }
        if (flagHasbuildingId)
          {
            handler.start_pair("buildingId");
            handler.string_value(storebuildingId);
          }
        if (flagHasfloorSection)
          {
            handler.start_pair("floorSection");
            handler.string_value(storefloorSection);
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
        return null;
      }

    public static new GoogleWorkspaceResourceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GoogleWorkspaceResourceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleWorkspaceResource", ignore_extras);
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
    public static new GoogleWorkspaceResourceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GoogleWorkspaceResourceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GoogleWorkspaceResourceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleWorkspaceResource", ignore_extras);
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
    public static new GoogleWorkspaceResourceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GoogleWorkspaceResourceJSON from_text(string text, bool ignore_extras)
      {
        GoogleWorkspaceResourceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleWorkspaceResource", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GoogleWorkspaceResourceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new GoogleWorkspaceResourceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GoogleWorkspaceResourceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleWorkspaceResource", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InternalThirdPartyRoomJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorkind;
        private JSONHoldingStringGenerator fieldGeneratoretags;
        private JSONHoldingStringGenerator fieldGeneratorresourceName;
        private JSONHoldingStringGenerator fieldGeneratorresourceDescription;
        private JSONHoldingStringGenerator fieldGeneratorresourceType;
        private JSONHoldingStringGenerator fieldGeneratorresourceEmail;
        private JSONHoldingStringGenerator fieldGeneratorresourceCategory;
        private JSONHoldingStringGenerator fieldGeneratoruserVisibleDescription;
        private JSONHoldingStringGenerator fieldGeneratorgeneratedResourceName;
        private JSONHoldingStringGenerator fieldGeneratorresourceId;
    private class FieldHoldingGeneratorcapacity : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorcapacity(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorcapacity : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorcapacity(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorcapacity fieldGeneratorcapacity;
        private JSONHoldingStringGenerator fieldGeneratorfloorName;
        private JSONHoldingStringGenerator fieldGeneratorbuildingId;
        private JSONHoldingStringGenerator fieldGeneratorfloorSection;
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
            if (!(getInternalThirdPartyRoomJSONKey().Equals("GoogleWorkspace")))
                throw new Exception("The key field has a value other than `GoogleWorkspace'.");
            GoogleWorkspaceResourceJSON result = new GoogleWorkspaceResourceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGoogleWorkspaceResourceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InternalThirdPartyRoomJSON new_result)
          {
            handle_result((GoogleWorkspaceResourceJSON )new_result);
          }
        protected void finish(GoogleWorkspaceResourceJSON result)
          {
            if (fieldGeneratorkind.have_value)
              {
                result.setkind(fieldGeneratorkind.value);
                fieldGeneratorkind.have_value = false;
              }
            if (fieldGeneratoretags.have_value)
              {
                result.setetags(fieldGeneratoretags.value);
                fieldGeneratoretags.have_value = false;
              }
            if (fieldGeneratorresourceName.have_value)
              {
                result.setresourceName(fieldGeneratorresourceName.value);
                fieldGeneratorresourceName.have_value = false;
              }
            if (fieldGeneratorresourceDescription.have_value)
              {
                result.setresourceDescription(fieldGeneratorresourceDescription.value);
                fieldGeneratorresourceDescription.have_value = false;
              }
            if (fieldGeneratorresourceType.have_value)
              {
                result.setresourceType(fieldGeneratorresourceType.value);
                fieldGeneratorresourceType.have_value = false;
              }
            if (fieldGeneratorresourceEmail.have_value)
              {
                result.setresourceEmail(fieldGeneratorresourceEmail.value);
                fieldGeneratorresourceEmail.have_value = false;
              }
            if (fieldGeneratorresourceCategory.have_value)
              {
                result.setresourceCategory(fieldGeneratorresourceCategory.value);
                fieldGeneratorresourceCategory.have_value = false;
              }
            if (fieldGeneratoruserVisibleDescription.have_value)
              {
                result.setuserVisibleDescription(fieldGeneratoruserVisibleDescription.value);
                fieldGeneratoruserVisibleDescription.have_value = false;
              }
            if (fieldGeneratorgeneratedResourceName.have_value)
              {
                result.setgeneratedResourceName(fieldGeneratorgeneratedResourceName.value);
                fieldGeneratorgeneratedResourceName.have_value = false;
              }
            if (fieldGeneratorresourceId.have_value)
              {
                result.setresourceId(fieldGeneratorresourceId.value);
                fieldGeneratorresourceId.have_value = false;
              }
            if (fieldGeneratorcapacity.have_value)
              {
                result.setcapacity(fieldGeneratorcapacity.value);
                fieldGeneratorcapacity.have_value = false;
              }
            if (fieldGeneratorfloorName.have_value)
              {
                result.setfloorName(fieldGeneratorfloorName.value);
                fieldGeneratorfloorName.have_value = false;
              }
            if (fieldGeneratorbuildingId.have_value)
              {
                result.setbuildingId(fieldGeneratorbuildingId.value);
                fieldGeneratorbuildingId.have_value = false;
              }
            if (fieldGeneratorfloorSection.have_value)
              {
                result.setfloorSection(fieldGeneratorfloorSection.value);
                fieldGeneratorfloorSection.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(GoogleWorkspaceResourceJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'b':
                    if ((String.Compare(field_name, 1, "uildingId", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorbuildingId;
                    break;
                case 'c':
                    if ((String.Compare(field_name, 1, "apacity", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorcapacity;
                    break;
                case 'e':
                    if ((String.Compare(field_name, 1, "tags", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratoretags;
                    break;
                case 'f':
                    if (String.Compare(field_name, 1, "loor", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorfloorName;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 6, "ection", 0, 6, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorfloorSection;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'g':
                    if ((String.Compare(field_name, 1, "eneratedResourceName", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorgeneratedResourceName;
                    break;
                case 'k':
                    if ((String.Compare(field_name, 1, "ind", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorkind;
                    break;
                case 'r':
                    if (String.Compare(field_name, 1, "esource", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 9, "ategory", 0, 7, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorresourceCategory;
                                break;
                            case 'D':
                                if ((String.Compare(field_name, 9, "escription", 0, 10, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorresourceDescription;
                                break;
                            case 'E':
                                if ((String.Compare(field_name, 9, "mail", 0, 4, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorresourceEmail;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 9, "d", 0, 1, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorresourceId;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 9, "ame", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorresourceName;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 9, "ype", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorresourceType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'u':
                    if ((String.Compare(field_name, 1, "serVisibleDescription", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratoruserVisibleDescription;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorkind = new JSONHoldingStringGenerator("field \"kind\" of the GoogleWorkspaceResource class");
            fieldGeneratoretags = new JSONHoldingStringGenerator("field \"etags\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceName = new JSONHoldingStringGenerator("field \"resourceName\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceDescription = new JSONHoldingStringGenerator("field \"resourceDescription\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceType = new JSONHoldingStringGenerator("field \"resourceType\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceEmail = new JSONHoldingStringGenerator("field \"resourceEmail\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceCategory = new JSONHoldingStringGenerator("field \"resourceCategory\" of the GoogleWorkspaceResource class");
            fieldGeneratoruserVisibleDescription = new JSONHoldingStringGenerator("field \"userVisibleDescription\" of the GoogleWorkspaceResource class");
            fieldGeneratorgeneratedResourceName = new JSONHoldingStringGenerator("field \"generatedResourceName\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceId = new JSONHoldingStringGenerator("field \"resourceId\" of the GoogleWorkspaceResource class");
            fieldGeneratorcapacity = new FieldHoldingGeneratorcapacity("field \"capacity\" of the GoogleWorkspaceResource class");
            fieldGeneratorfloorName = new JSONHoldingStringGenerator("field \"floorName\" of the GoogleWorkspaceResource class");
            fieldGeneratorbuildingId = new JSONHoldingStringGenerator("field \"buildingId\" of the GoogleWorkspaceResource class");
            fieldGeneratorfloorSection = new JSONHoldingStringGenerator("field \"floorSection\" of the GoogleWorkspaceResource class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GoogleWorkspaceResource class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorkind = new JSONHoldingStringGenerator("field \"kind\" of the GoogleWorkspaceResource class");
            fieldGeneratoretags = new JSONHoldingStringGenerator("field \"etags\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceName = new JSONHoldingStringGenerator("field \"resourceName\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceDescription = new JSONHoldingStringGenerator("field \"resourceDescription\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceType = new JSONHoldingStringGenerator("field \"resourceType\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceEmail = new JSONHoldingStringGenerator("field \"resourceEmail\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceCategory = new JSONHoldingStringGenerator("field \"resourceCategory\" of the GoogleWorkspaceResource class");
            fieldGeneratoruserVisibleDescription = new JSONHoldingStringGenerator("field \"userVisibleDescription\" of the GoogleWorkspaceResource class");
            fieldGeneratorgeneratedResourceName = new JSONHoldingStringGenerator("field \"generatedResourceName\" of the GoogleWorkspaceResource class");
            fieldGeneratorresourceId = new JSONHoldingStringGenerator("field \"resourceId\" of the GoogleWorkspaceResource class");
            fieldGeneratorcapacity = new FieldHoldingGeneratorcapacity("field \"capacity\" of the GoogleWorkspaceResource class");
            fieldGeneratorfloorName = new JSONHoldingStringGenerator("field \"floorName\" of the GoogleWorkspaceResource class");
            fieldGeneratorbuildingId = new JSONHoldingStringGenerator("field \"buildingId\" of the GoogleWorkspaceResource class");
            fieldGeneratorfloorSection = new JSONHoldingStringGenerator("field \"floorSection\" of the GoogleWorkspaceResource class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GoogleWorkspaceResource class");
          }

        public override void reset()
          {
            fieldGeneratorkind.reset();
            fieldGeneratoretags.reset();
            fieldGeneratorresourceName.reset();
            fieldGeneratorresourceDescription.reset();
            fieldGeneratorresourceType.reset();
            fieldGeneratorresourceEmail.reset();
            fieldGeneratorresourceCategory.reset();
            fieldGeneratoruserVisibleDescription.reset();
            fieldGeneratorgeneratedResourceName.reset();
            fieldGeneratorresourceId.reset();
            fieldGeneratorcapacity.reset();
            fieldGeneratorfloorName.reset();
            fieldGeneratorbuildingId.reset();
            fieldGeneratorfloorSection.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(GoogleWorkspaceResourceJSON  result)
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
        public GoogleWorkspaceResourceJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GoogleWorkspaceResourceJSON  result)
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
    protected virtual void handle_result(List<GoogleWorkspaceResourceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GoogleWorkspaceResourceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GoogleWorkspaceResourceJSON>();
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
    public List<GoogleWorkspaceResourceJSON> value;
  };
  };
