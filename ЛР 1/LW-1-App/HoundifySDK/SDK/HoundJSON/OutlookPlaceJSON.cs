/* file "OutlookPlaceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class OutlookPlaceJSON : InternalThirdPartyRoomJSON
  {
    public enum TypebookingTypeKnownValues
      {
        bookingType_standard,
        bookingType_reserved,
        bookingType__none
      };
    public struct TypebookingType
      {
        public bool in_known_list;
        public string string_value;
        public TypebookingTypeKnownValues list_value;
      };

    public static TypebookingTypeKnownValues  stringTobookingType(string chars)
      {
        switch (chars[0])
          {
            case 'r':
                if ((String.Compare(chars, 1, "eserved", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypebookingTypeKnownValues.bookingType_reserved;
                break;
            case 's':
                if ((String.Compare(chars, 1, "tandard", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypebookingTypeKnownValues.bookingType_standard;
                break;
            default:
                break;
          }
        return TypebookingTypeKnownValues.bookingType__none;
      }

    public static string  stringFrombookingType(TypebookingTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypebookingTypeKnownValues.bookingType_standard:
                return "standard";
            case TypebookingTypeKnownValues.bookingType_reserved:
                return "reserved";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasaddress;
    private OutlookPhysicalAddressJSON  storeaddress;
    private bool flagHasbookingType;
    private TypebookingType storebookingType;
    private bool flagHasbuilding;
    private string storebuilding;
    private bool flagHascapacity;
    private BigInteger storecapacity;
    private bool flagHasdisplayName;
    private string storedisplayName;
    private bool flagHasemailAddress;
    private string storeemailAddress;
    private bool flagHasfloorLabel;
    private string storefloorLabel;
    private bool flagHasfloorNumber;
    private BigInteger storefloorNumber;
    private bool flagHasgeoCoordinates;
    private OutlookGeoCoordinatesJSON  storegeoCoordinates;
    private bool flagHasid;
    private string storeid;
    private bool flagHaslabel;
    private string storelabel;
    private bool flagHasnickname;
    private string storenickname;
    private bool flagHasphone;
    private string storephone;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraaddressToJSON()
      {
        JSONValueHandler handler_address = new JSONValueHandler();
        storeaddress.write_as_json(handler_address);
        return handler_address.result;
      }

    private JSONValue  extrabookingTypeToJSON()
      {
        JSONStringValue generated_string_bookingType;
        if (!(storebookingType.in_known_list))
          {
        generated_string_bookingType = new JSONStringValue(storebookingType.string_value);
          }
        else
          {
        switch (storebookingType.list_value)
          {
            case TypebookingTypeKnownValues.bookingType_standard:
                generated_string_bookingType = new JSONStringValue("standard");
                break;
            case TypebookingTypeKnownValues.bookingType_reserved:
                generated_string_bookingType = new JSONStringValue("reserved");
                break;
            default:
                Debug.Assert(false);
                generated_string_bookingType = null;
                break;
          }
          }
        return generated_string_bookingType;
      }

    private JSONValue  extrabuildingToJSON()
      {
        JSONStringValue generated_string_building = new JSONStringValue(storebuilding);
        return generated_string_building;
      }

    private JSONValue  extracapacityToJSON()
      {
        JSONIntegerValue generated_integer_capacity = new JSONIntegerValue(storecapacity);
        return generated_integer_capacity;
      }

    private JSONValue  extradisplayNameToJSON()
      {
        JSONStringValue generated_string_displayName = new JSONStringValue(storedisplayName);
        return generated_string_displayName;
      }

    private JSONValue  extraemailAddressToJSON()
      {
        JSONStringValue generated_string_emailAddress = new JSONStringValue(storeemailAddress);
        return generated_string_emailAddress;
      }

    private JSONValue  extrafloorLabelToJSON()
      {
        JSONStringValue generated_string_floorLabel = new JSONStringValue(storefloorLabel);
        return generated_string_floorLabel;
      }

    private JSONValue  extrafloorNumberToJSON()
      {
        JSONIntegerValue generated_integer_floorNumber = new JSONIntegerValue(storefloorNumber);
        return generated_integer_floorNumber;
      }

    private JSONValue  extrageoCoordinatesToJSON()
      {
        JSONValueHandler handler_geoCoordinates = new JSONValueHandler();
        storegeoCoordinates.write_as_json(handler_geoCoordinates);
        return handler_geoCoordinates.result;
      }

    private JSONValue  extraidToJSON()
      {
        JSONStringValue generated_string_id = new JSONStringValue(storeid);
        return generated_string_id;
      }

    private JSONValue  extralabelToJSON()
      {
        JSONStringValue generated_string_label = new JSONStringValue(storelabel);
        return generated_string_label;
      }

    private JSONValue  extranicknameToJSON()
      {
        JSONStringValue generated_string_nickname = new JSONStringValue(storenickname);
        return generated_string_nickname;
      }

    private JSONValue  extraphoneToJSON()
      {
        JSONStringValue generated_string_phone = new JSONStringValue(storephone);
        return generated_string_phone;
      }


    private void  fromJSONaddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OutlookPhysicalAddressJSON convert_classy = OutlookPhysicalAddressJSON.from_json(json_value, ignore_extras, true);
        setaddress(convert_classy);
      }


    private void  fromJSONbookingType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field bookingType of OutlookPlaceJSON is not a string.");
        TypebookingType the_open_enum = new TypebookingType();
        switch (json_string.getData()[0])
          {
            case 'r':
                if ((String.Compare(json_string.getData(), 1, "eserved", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypebookingTypeKnownValues.bookingType_reserved;
                        goto open_enum_is_done;
                      }
                break;
            case 's':
                if ((String.Compare(json_string.getData(), 1, "tandard", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypebookingTypeKnownValues.bookingType_standard;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setbookingType(the_open_enum);
      }


    private void  fromJSONbuilding(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field building of OutlookPlaceJSON is not a string.");
        setbuilding(json_string.getData());
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
                throw new Exception("The value for field capacity of OutlookPlaceJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field capacity of OutlookPlaceJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setcapacity(extracted_integer);
      }


    private void  fromJSONdisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field displayName of OutlookPlaceJSON is not a string.");
        setdisplayName(json_string.getData());
      }


    private void  fromJSONemailAddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field emailAddress of OutlookPlaceJSON is not a string.");
        setemailAddress(json_string.getData());
      }


    private void  fromJSONfloorLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field floorLabel of OutlookPlaceJSON is not a string.");
        setfloorLabel(json_string.getData());
      }


    private void  fromJSONfloorNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field floorNumber of OutlookPlaceJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field floorNumber of OutlookPlaceJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setfloorNumber(extracted_integer);
      }


    private void  fromJSONgeoCoordinates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OutlookGeoCoordinatesJSON convert_classy = OutlookGeoCoordinatesJSON.from_json(json_value, ignore_extras, true);
        setgeoCoordinates(convert_classy);
      }


    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field id of OutlookPlaceJSON is not a string.");
        setid(json_string.getData());
      }


    private void  fromJSONlabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field label of OutlookPlaceJSON is not a string.");
        setlabel(json_string.getData());
      }


    private void  fromJSONnickname(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field nickname of OutlookPlaceJSON is not a string.");
        setnickname(json_string.getData());
      }


    private void  fromJSONphone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field phone of OutlookPlaceJSON is not a string.");
        setphone(json_string.getData());
      }


    public OutlookPlaceJSON()
      {
        flagHasaddress = false;
        flagHasbookingType = false;
        flagHasbuilding = false;
        flagHascapacity = false;
        flagHasdisplayName = false;
        flagHasemailAddress = false;
        flagHasfloorLabel = false;
        flagHasfloorNumber = false;
        flagHasgeoCoordinates = false;
        flagHasid = false;
        flagHaslabel = false;
        flagHasnickname = false;
        flagHasphone = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getThirdPartyAPIName()
      {
        return "OutlookCalendar";
      }

    public bool  hasaddress()
      {
        return flagHasaddress;
      }

    public OutlookPhysicalAddressJSON   getaddress()
      {
        Debug.Assert(flagHasaddress);
        return storeaddress;
      }

    public bool  hasbookingType()
      {
        return flagHasbookingType;
      }

    public TypebookingType  getbookingType()
      {
        Debug.Assert(flagHasbookingType);
        return storebookingType;
      }

    public string  getbookingTypeAsString()
      {
        TypebookingType result = getbookingType();
        if (result.in_known_list)
            return stringFrombookingType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasbuilding()
      {
        return flagHasbuilding;
      }

    public string  getbuilding()
      {
        Debug.Assert(flagHasbuilding);
        return storebuilding;
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

    public bool  hasdisplayName()
      {
        return flagHasdisplayName;
      }

    public string  getdisplayName()
      {
        Debug.Assert(flagHasdisplayName);
        return storedisplayName;
      }

    public bool  hasemailAddress()
      {
        return flagHasemailAddress;
      }

    public string  getemailAddress()
      {
        Debug.Assert(flagHasemailAddress);
        return storeemailAddress;
      }

    public bool  hasfloorLabel()
      {
        return flagHasfloorLabel;
      }

    public string  getfloorLabel()
      {
        Debug.Assert(flagHasfloorLabel);
        return storefloorLabel;
      }

    public bool  hasfloorNumber()
      {
        return flagHasfloorNumber;
      }

    public BigInteger  getfloorNumber()
      {
        Debug.Assert(flagHasfloorNumber);
        return storefloorNumber;
      }

    public bool  hasgeoCoordinates()
      {
        return flagHasgeoCoordinates;
      }

    public OutlookGeoCoordinatesJSON   getgeoCoordinates()
      {
        Debug.Assert(flagHasgeoCoordinates);
        return storegeoCoordinates;
      }

    public bool  hasid()
      {
        return flagHasid;
      }

    public string  getid()
      {
        Debug.Assert(flagHasid);
        return storeid;
      }

    public bool  haslabel()
      {
        return flagHaslabel;
      }

    public string  getlabel()
      {
        Debug.Assert(flagHaslabel);
        return storelabel;
      }

    public bool  hasnickname()
      {
        return flagHasnickname;
      }

    public string  getnickname()
      {
        Debug.Assert(flagHasnickname);
        return storenickname;
      }

    public bool  hasphone()
      {
        return flagHasphone;
      }

    public string  getphone()
      {
        Debug.Assert(flagHasphone);
        return storephone;
      }


    public virtual int extraOutlookPlaceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOutlookPlaceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOutlookPlaceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOutlookPlaceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInternalThirdPartyRoomComponentCount()
      {
        int result = 0;
        if (flagHasaddress)
            ++result;
        if (flagHasbookingType)
            ++result;
        if (flagHasbuilding)
            ++result;
        if (flagHascapacity)
            ++result;
        if (flagHasdisplayName)
            ++result;
        if (flagHasemailAddress)
            ++result;
        if (flagHasfloorLabel)
            ++result;
        if (flagHasfloorNumber)
            ++result;
        if (flagHasgeoCoordinates)
            ++result;
        if (flagHasid)
            ++result;
        if (flagHaslabel)
            ++result;
        if (flagHasnickname)
            ++result;
        if (flagHasphone)
            ++result;
        result += extraOutlookPlaceComponentCount();
        return result;
      }
    public override string extraInternalThirdPartyRoomComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasaddress)
          {
            if (remainder == 0)
                return "address";
            --remainder;
          }
        if (flagHasbookingType)
          {
            if (remainder == 0)
                return "bookingType";
            --remainder;
          }
        if (flagHasbuilding)
          {
            if (remainder == 0)
                return "building";
            --remainder;
          }
        if (flagHascapacity)
          {
            if (remainder == 0)
                return "capacity";
            --remainder;
          }
        if (flagHasdisplayName)
          {
            if (remainder == 0)
                return "displayName";
            --remainder;
          }
        if (flagHasemailAddress)
          {
            if (remainder == 0)
                return "emailAddress";
            --remainder;
          }
        if (flagHasfloorLabel)
          {
            if (remainder == 0)
                return "floorLabel";
            --remainder;
          }
        if (flagHasfloorNumber)
          {
            if (remainder == 0)
                return "floorNumber";
            --remainder;
          }
        if (flagHasgeoCoordinates)
          {
            if (remainder == 0)
                return "geoCoordinates";
            --remainder;
          }
        if (flagHasid)
          {
            if (remainder == 0)
                return "id";
            --remainder;
          }
        if (flagHaslabel)
          {
            if (remainder == 0)
                return "label";
            --remainder;
          }
        if (flagHasnickname)
          {
            if (remainder == 0)
                return "nickname";
            --remainder;
          }
        if (flagHasphone)
          {
            if (remainder == 0)
                return "phone";
            --remainder;
          }
        return extraOutlookPlaceComponentKey(remainder);
      }
    public override JSONValue extraInternalThirdPartyRoomComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasaddress)
          {
            if (remainder == 0)
                return extraaddressToJSON();
            --remainder;
          }
        if (flagHasbookingType)
          {
            if (remainder == 0)
                return extrabookingTypeToJSON();
            --remainder;
          }
        if (flagHasbuilding)
          {
            if (remainder == 0)
                return extrabuildingToJSON();
            --remainder;
          }
        if (flagHascapacity)
          {
            if (remainder == 0)
                return extracapacityToJSON();
            --remainder;
          }
        if (flagHasdisplayName)
          {
            if (remainder == 0)
                return extradisplayNameToJSON();
            --remainder;
          }
        if (flagHasemailAddress)
          {
            if (remainder == 0)
                return extraemailAddressToJSON();
            --remainder;
          }
        if (flagHasfloorLabel)
          {
            if (remainder == 0)
                return extrafloorLabelToJSON();
            --remainder;
          }
        if (flagHasfloorNumber)
          {
            if (remainder == 0)
                return extrafloorNumberToJSON();
            --remainder;
          }
        if (flagHasgeoCoordinates)
          {
            if (remainder == 0)
                return extrageoCoordinatesToJSON();
            --remainder;
          }
        if (flagHasid)
          {
            if (remainder == 0)
                return extraidToJSON();
            --remainder;
          }
        if (flagHaslabel)
          {
            if (remainder == 0)
                return extralabelToJSON();
            --remainder;
          }
        if (flagHasnickname)
          {
            if (remainder == 0)
                return extranicknameToJSON();
            --remainder;
          }
        if (flagHasphone)
          {
            if (remainder == 0)
                return extraphoneToJSON();
            --remainder;
          }
        return extraOutlookPlaceComponentValue(remainder);
      }
    public override JSONValue extraInternalThirdPartyRoomLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'a':
                if ((String.Compare(field_name, 1, "ddress", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasaddress ? extraaddressToJSON() : null);
                break;
            case 'b':
                switch (field_name[1])
                  {
                    case 'o':
                        if ((String.Compare(field_name, 2, "okingType", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasbookingType ? extrabookingTypeToJSON() : null);
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 2, "ilding", 0, 6, false) == 0) && (field_name.Length == 8))
                            return (flagHasbuilding ? extrabuildingToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'c':
                if ((String.Compare(field_name, 1, "apacity", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHascapacity ? extracapacityToJSON() : null);
                break;
            case 'd':
                if ((String.Compare(field_name, 1, "isplayName", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasdisplayName ? extradisplayNameToJSON() : null);
                break;
            case 'e':
                if ((String.Compare(field_name, 1, "mailAddress", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasemailAddress ? extraemailAddressToJSON() : null);
                break;
            case 'f':
                if (String.Compare(field_name, 1, "loor", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'L':
                            if ((String.Compare(field_name, 6, "abel", 0, 4, false) == 0) && (field_name.Length == 10))
                                return (flagHasfloorLabel ? extrafloorLabelToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 6, "umber", 0, 5, false) == 0) && (field_name.Length == 11))
                                return (flagHasfloorNumber ? extrafloorNumberToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'g':
                if ((String.Compare(field_name, 1, "eoCoordinates", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasgeoCoordinates ? extrageoCoordinatesToJSON() : null);
                break;
            case 'i':
                if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                    return (flagHasid ? extraidToJSON() : null);
                break;
            case 'l':
                if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHaslabel ? extralabelToJSON() : null);
                break;
            case 'n':
                if ((String.Compare(field_name, 1, "ickname", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasnickname ? extranicknameToJSON() : null);
                break;
            case 'p':
                if ((String.Compare(field_name, 1, "hone", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasphone ? extraphoneToJSON() : null);
                break;
            default:
                break;
          }
        return extraOutlookPlaceLookup(field_name);
      }

    public void setaddress(OutlookPhysicalAddressJSON  new_value)
      {
        if (flagHasaddress)
          {
          }
        flagHasaddress = true;
        storeaddress = new_value;
      }
    public void unsetaddress()
      {
        if (flagHasaddress)
          {
          }
        flagHasaddress = false;
      }
    public void setbookingType(TypebookingType new_value)
      {
        flagHasbookingType = true;
        storebookingType = new_value;
      }
    public void setbookingType(string chars)
      {
        TypebookingTypeKnownValues known = stringTobookingType(chars);
        TypebookingType new_value = new TypebookingType();
        if (known == TypebookingTypeKnownValues.bookingType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setbookingType(new_value);
      }
    public void setbookingType(TypebookingTypeKnownValues new_value)
      {
        TypebookingType new_full_value = new TypebookingType();
        Debug.Assert(new_value != TypebookingTypeKnownValues.bookingType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setbookingType(new_full_value);
      }
    public void unsetbookingType()
      {
        flagHasbookingType = false;
      }
    public void setbuilding(string new_value)
      {
        flagHasbuilding = true;
        storebuilding = new_value;
      }
    public void unsetbuilding()
      {
        flagHasbuilding = false;
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
    public void setdisplayName(string new_value)
      {
        flagHasdisplayName = true;
        storedisplayName = new_value;
      }
    public void unsetdisplayName()
      {
        flagHasdisplayName = false;
      }
    public void setemailAddress(string new_value)
      {
        flagHasemailAddress = true;
        storeemailAddress = new_value;
      }
    public void unsetemailAddress()
      {
        flagHasemailAddress = false;
      }
    public void setfloorLabel(string new_value)
      {
        flagHasfloorLabel = true;
        storefloorLabel = new_value;
      }
    public void unsetfloorLabel()
      {
        flagHasfloorLabel = false;
      }
    public void setfloorNumber(BigInteger new_value)
      {
        flagHasfloorNumber = true;
        storefloorNumber = new_value;
      }
    public void unsetfloorNumber()
      {
        flagHasfloorNumber = false;
      }
    public void setgeoCoordinates(OutlookGeoCoordinatesJSON  new_value)
      {
        if (flagHasgeoCoordinates)
          {
          }
        flagHasgeoCoordinates = true;
        storegeoCoordinates = new_value;
      }
    public void unsetgeoCoordinates()
      {
        if (flagHasgeoCoordinates)
          {
          }
        flagHasgeoCoordinates = false;
      }
    public void setid(string new_value)
      {
        flagHasid = true;
        storeid = new_value;
      }
    public void unsetid()
      {
        flagHasid = false;
      }
    public void setlabel(string new_value)
      {
        flagHaslabel = true;
        storelabel = new_value;
      }
    public void unsetlabel()
      {
        flagHaslabel = false;
      }
    public void setnickname(string new_value)
      {
        flagHasnickname = true;
        storenickname = new_value;
      }
    public void unsetnickname()
      {
        flagHasnickname = false;
      }
    public void setphone(string new_value)
      {
        flagHasphone = true;
        storephone = new_value;
      }
    public void unsetphone()
      {
        flagHasphone = false;
      }

    public virtual void extraOutlookPlaceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOutlookPlaceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOutlookPlaceLookup(key);
        if (old_field == null)
          {
            extraOutlookPlaceAppendPair(key, new_component);
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
            case 'a':
                if ((String.Compare(key, 1, "ddress", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONaddress(new_component, false);
                    return;
                    }
                break;
            case 'b':
                switch (key[1])
                  {
                    case 'o':
                        if ((String.Compare(key, 2, "okingType", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONbookingType(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "ilding", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONbuilding(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'c':
                if ((String.Compare(key, 1, "apacity", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONcapacity(new_component, false);
                    return;
                    }
                break;
            case 'd':
                if ((String.Compare(key, 1, "isplayName", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONdisplayName(new_component, false);
                    return;
                    }
                break;
            case 'e':
                if ((String.Compare(key, 1, "mailAddress", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONemailAddress(new_component, false);
                    return;
                    }
                break;
            case 'f':
                if (String.Compare(key, 1, "loor", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'L':
                            if ((String.Compare(key, 6, "abel", 0, 4, false) == 0) && (key.Length == 10))
                                {
                                fromJSONfloorLabel(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 6, "umber", 0, 5, false) == 0) && (key.Length == 11))
                                {
                                fromJSONfloorNumber(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'g':
                if ((String.Compare(key, 1, "eoCoordinates", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONgeoCoordinates(new_component, false);
                    return;
                    }
                break;
            case 'i':
                if ((String.Compare(key, 1, "d", 0, 1, false) == 0) && (key.Length == 2))
                    {
                    fromJSONid(new_component, false);
                    return;
                    }
                break;
            case 'l':
                if ((String.Compare(key, 1, "abel", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONlabel(new_component, false);
                    return;
                    }
                break;
            case 'n':
                if ((String.Compare(key, 1, "ickname", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONnickname(new_component, false);
                    return;
                    }
                break;
            case 'p':
                if ((String.Compare(key, 1, "hone", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONphone(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraOutlookPlaceAppendPair(key, new_component);
      }
    public override void extraInternalThirdPartyRoomSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'a':
                if ((String.Compare(key, 1, "ddress", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONaddress(new_component, false);
                    return;
                    }
                break;
            case 'b':
                switch (key[1])
                  {
                    case 'o':
                        if ((String.Compare(key, 2, "okingType", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONbookingType(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "ilding", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONbuilding(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'c':
                if ((String.Compare(key, 1, "apacity", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONcapacity(new_component, false);
                    return;
                    }
                break;
            case 'd':
                if ((String.Compare(key, 1, "isplayName", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONdisplayName(new_component, false);
                    return;
                    }
                break;
            case 'e':
                if ((String.Compare(key, 1, "mailAddress", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONemailAddress(new_component, false);
                    return;
                    }
                break;
            case 'f':
                if (String.Compare(key, 1, "loor", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'L':
                            if ((String.Compare(key, 6, "abel", 0, 4, false) == 0) && (key.Length == 10))
                                {
                                fromJSONfloorLabel(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 6, "umber", 0, 5, false) == 0) && (key.Length == 11))
                                {
                                fromJSONfloorNumber(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'g':
                if ((String.Compare(key, 1, "eoCoordinates", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONgeoCoordinates(new_component, false);
                    return;
                    }
                break;
            case 'i':
                if ((String.Compare(key, 1, "d", 0, 1, false) == 0) && (key.Length == 2))
                    {
                    fromJSONid(new_component, false);
                    return;
                    }
                break;
            case 'l':
                if ((String.Compare(key, 1, "abel", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONlabel(new_component, false);
                    return;
                    }
                break;
            case 'n':
                if ((String.Compare(key, 1, "ickname", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONnickname(new_component, false);
                    return;
                    }
                break;
            case 'p':
                if ((String.Compare(key, 1, "hone", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONphone(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraOutlookPlaceSetField(key, new_component);
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
        if (flagHasaddress)
          {
            handler.start_pair("address");
            if (partial_allowed)
                storeaddress.write_partial_as_json(handler);
            else
                storeaddress.write_as_json(handler);
          }
        if (flagHasbookingType)
          {
            handler.start_pair("bookingType");
            if (storebookingType.in_known_list)
              {
                switch (storebookingType.list_value)
                  {
                    case TypebookingTypeKnownValues.bookingType_standard:
                        handler.string_value("standard");
                        break;
                    case TypebookingTypeKnownValues.bookingType_reserved:
                        handler.string_value("reserved");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storebookingType.string_value);
              }
          }
        if (flagHasbuilding)
          {
            handler.start_pair("building");
            handler.string_value(storebuilding);
          }
        if (flagHascapacity)
          {
            handler.start_pair("capacity");
            handler.number_value(storecapacity);
          }
        if (flagHasdisplayName)
          {
            handler.start_pair("displayName");
            handler.string_value(storedisplayName);
          }
        if (flagHasemailAddress)
          {
            handler.start_pair("emailAddress");
            handler.string_value(storeemailAddress);
          }
        if (flagHasfloorLabel)
          {
            handler.start_pair("floorLabel");
            handler.string_value(storefloorLabel);
          }
        if (flagHasfloorNumber)
          {
            handler.start_pair("floorNumber");
            handler.number_value(storefloorNumber);
          }
        if (flagHasgeoCoordinates)
          {
            handler.start_pair("geoCoordinates");
            if (partial_allowed)
                storegeoCoordinates.write_partial_as_json(handler);
            else
                storegeoCoordinates.write_as_json(handler);
          }
        if (flagHasid)
          {
            handler.start_pair("id");
            handler.string_value(storeid);
          }
        if (flagHaslabel)
          {
            handler.start_pair("label");
            handler.string_value(storelabel);
          }
        if (flagHasnickname)
          {
            handler.start_pair("nickname");
            handler.string_value(storenickname);
          }
        if (flagHasphone)
          {
            handler.start_pair("phone");
            handler.string_value(storephone);
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

    public static new OutlookPlaceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookPlaceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookPlace", ignore_extras);
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
    public static new OutlookPlaceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new OutlookPlaceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookPlaceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookPlace", ignore_extras);
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
    public static new OutlookPlaceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new OutlookPlaceJSON from_text(string text, bool ignore_extras)
      {
        OutlookPlaceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookPlace", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OutlookPlaceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new OutlookPlaceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OutlookPlaceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookPlace", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InternalThirdPartyRoomJSON.Generator
      {
        private OutlookPhysicalAddressJSON.HoldingGenerator fieldGeneratoraddress;
    private abstract class FieldGeneratorbookingType : JSONStringGenerator
          {
            protected FieldGeneratorbookingType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorbookingType()
              {
              }
            protected override void handle_result(string result)
              {
                TypebookingTypeKnownValues known = stringTobookingType(result);
                TypebookingType new_value = new TypebookingType();
                if (known == TypebookingTypeKnownValues.bookingType__none)
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
            protected abstract void handle_result(TypebookingType result);
          };
    private class FieldHoldingGeneratorbookingType : FieldGeneratorbookingType
  {
    protected override void handle_result(TypebookingType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorbookingType(String what)
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
    public TypebookingType value;
  };
    private class FieldHoldingArrayGeneratorbookingType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorbookingType
      {
        private FieldHoldingArrayGeneratorbookingType top;

        protected override void handle_result(TypebookingType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorbookingType init_top)
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
    protected virtual void handle_result(List<TypebookingType> result)
      {
      }

    public FieldHoldingArrayGeneratorbookingType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypebookingType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorbookingType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypebookingType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypebookingType> value;
  };
        private FieldHoldingGeneratorbookingType fieldGeneratorbookingType;
        private JSONHoldingStringGenerator fieldGeneratorbuilding;
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
        private JSONHoldingStringGenerator fieldGeneratordisplayName;
        private JSONHoldingStringGenerator fieldGeneratoremailAddress;
        private JSONHoldingStringGenerator fieldGeneratorfloorLabel;
    private class FieldHoldingGeneratorfloorNumber : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorfloorNumber(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorfloorNumber : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorfloorNumber(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorfloorNumber fieldGeneratorfloorNumber;
        private OutlookGeoCoordinatesJSON.HoldingGenerator fieldGeneratorgeoCoordinates;
        private JSONHoldingStringGenerator fieldGeneratorid;
        private JSONHoldingStringGenerator fieldGeneratorlabel;
        private JSONHoldingStringGenerator fieldGeneratornickname;
        private JSONHoldingStringGenerator fieldGeneratorphone;
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
            if (!(getInternalThirdPartyRoomJSONKey().Equals("OutlookCalendar")))
                throw new Exception("The key field has a value other than `OutlookCalendar'.");
            OutlookPlaceJSON result = new OutlookPlaceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOutlookPlaceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InternalThirdPartyRoomJSON new_result)
          {
            handle_result((OutlookPlaceJSON )new_result);
          }
        protected void finish(OutlookPlaceJSON result)
          {
            if (fieldGeneratoraddress.have_value)
              {
                result.setaddress(fieldGeneratoraddress.value);
                fieldGeneratoraddress.have_value = false;
              }
            if (fieldGeneratorbookingType.have_value)
              {
                result.setbookingType(fieldGeneratorbookingType.value);
                fieldGeneratorbookingType.have_value = false;
              }
            if (fieldGeneratorbuilding.have_value)
              {
                result.setbuilding(fieldGeneratorbuilding.value);
                fieldGeneratorbuilding.have_value = false;
              }
            if (fieldGeneratorcapacity.have_value)
              {
                result.setcapacity(fieldGeneratorcapacity.value);
                fieldGeneratorcapacity.have_value = false;
              }
            if (fieldGeneratordisplayName.have_value)
              {
                result.setdisplayName(fieldGeneratordisplayName.value);
                fieldGeneratordisplayName.have_value = false;
              }
            if (fieldGeneratoremailAddress.have_value)
              {
                result.setemailAddress(fieldGeneratoremailAddress.value);
                fieldGeneratoremailAddress.have_value = false;
              }
            if (fieldGeneratorfloorLabel.have_value)
              {
                result.setfloorLabel(fieldGeneratorfloorLabel.value);
                fieldGeneratorfloorLabel.have_value = false;
              }
            if (fieldGeneratorfloorNumber.have_value)
              {
                result.setfloorNumber(fieldGeneratorfloorNumber.value);
                fieldGeneratorfloorNumber.have_value = false;
              }
            if (fieldGeneratorgeoCoordinates.have_value)
              {
                result.setgeoCoordinates(fieldGeneratorgeoCoordinates.value);
                fieldGeneratorgeoCoordinates.have_value = false;
              }
            if (fieldGeneratorid.have_value)
              {
                result.setid(fieldGeneratorid.value);
                fieldGeneratorid.have_value = false;
              }
            if (fieldGeneratorlabel.have_value)
              {
                result.setlabel(fieldGeneratorlabel.value);
                fieldGeneratorlabel.have_value = false;
              }
            if (fieldGeneratornickname.have_value)
              {
                result.setnickname(fieldGeneratornickname.value);
                fieldGeneratornickname.have_value = false;
              }
            if (fieldGeneratorphone.have_value)
              {
                result.setphone(fieldGeneratorphone.value);
                fieldGeneratorphone.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(OutlookPlaceJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    if ((String.Compare(field_name, 1, "ddress", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratoraddress;
                    break;
                case 'b':
                    switch (field_name[1])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 2, "okingType", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorbookingType;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "ilding", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorbuilding;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'c':
                    if ((String.Compare(field_name, 1, "apacity", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorcapacity;
                    break;
                case 'd':
                    if ((String.Compare(field_name, 1, "isplayName", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratordisplayName;
                    break;
                case 'e':
                    if ((String.Compare(field_name, 1, "mailAddress", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratoremailAddress;
                    break;
                case 'f':
                    if (String.Compare(field_name, 1, "loor", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 6, "abel", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorfloorLabel;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 6, "umber", 0, 5, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorfloorNumber;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'g':
                    if ((String.Compare(field_name, 1, "eoCoordinates", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorgeoCoordinates;
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorid;
                    break;
                case 'l':
                    if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorlabel;
                    break;
                case 'n':
                    if ((String.Compare(field_name, 1, "ickname", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratornickname;
                    break;
                case 'p':
                    if ((String.Compare(field_name, 1, "hone", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorphone;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratoraddress = new OutlookPhysicalAddressJSON.HoldingGenerator("field \"address\" of the OutlookPlace class", ignore_extras);
            fieldGeneratorbookingType = new FieldHoldingGeneratorbookingType("field \"bookingType\" of the OutlookPlace class");
            fieldGeneratorbuilding = new JSONHoldingStringGenerator("field \"building\" of the OutlookPlace class");
            fieldGeneratorcapacity = new FieldHoldingGeneratorcapacity("field \"capacity\" of the OutlookPlace class");
            fieldGeneratordisplayName = new JSONHoldingStringGenerator("field \"displayName\" of the OutlookPlace class");
            fieldGeneratoremailAddress = new JSONHoldingStringGenerator("field \"emailAddress\" of the OutlookPlace class");
            fieldGeneratorfloorLabel = new JSONHoldingStringGenerator("field \"floorLabel\" of the OutlookPlace class");
            fieldGeneratorfloorNumber = new FieldHoldingGeneratorfloorNumber("field \"floorNumber\" of the OutlookPlace class");
            fieldGeneratorgeoCoordinates = new OutlookGeoCoordinatesJSON.HoldingGenerator("field \"geoCoordinates\" of the OutlookPlace class", ignore_extras);
            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the OutlookPlace class");
            fieldGeneratorlabel = new JSONHoldingStringGenerator("field \"label\" of the OutlookPlace class");
            fieldGeneratornickname = new JSONHoldingStringGenerator("field \"nickname\" of the OutlookPlace class");
            fieldGeneratorphone = new JSONHoldingStringGenerator("field \"phone\" of the OutlookPlace class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OutlookPlace class");
          }
        public Generator() : base(false)
          {
            fieldGeneratoraddress = new OutlookPhysicalAddressJSON.HoldingGenerator("field \"address\" of the OutlookPlace class", false);
            fieldGeneratorbookingType = new FieldHoldingGeneratorbookingType("field \"bookingType\" of the OutlookPlace class");
            fieldGeneratorbuilding = new JSONHoldingStringGenerator("field \"building\" of the OutlookPlace class");
            fieldGeneratorcapacity = new FieldHoldingGeneratorcapacity("field \"capacity\" of the OutlookPlace class");
            fieldGeneratordisplayName = new JSONHoldingStringGenerator("field \"displayName\" of the OutlookPlace class");
            fieldGeneratoremailAddress = new JSONHoldingStringGenerator("field \"emailAddress\" of the OutlookPlace class");
            fieldGeneratorfloorLabel = new JSONHoldingStringGenerator("field \"floorLabel\" of the OutlookPlace class");
            fieldGeneratorfloorNumber = new FieldHoldingGeneratorfloorNumber("field \"floorNumber\" of the OutlookPlace class");
            fieldGeneratorgeoCoordinates = new OutlookGeoCoordinatesJSON.HoldingGenerator("field \"geoCoordinates\" of the OutlookPlace class", false);
            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the OutlookPlace class");
            fieldGeneratorlabel = new JSONHoldingStringGenerator("field \"label\" of the OutlookPlace class");
            fieldGeneratornickname = new JSONHoldingStringGenerator("field \"nickname\" of the OutlookPlace class");
            fieldGeneratorphone = new JSONHoldingStringGenerator("field \"phone\" of the OutlookPlace class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OutlookPlace class");
          }

        public override void reset()
          {
            fieldGeneratoraddress.reset();
            fieldGeneratorbookingType.reset();
            fieldGeneratorbuilding.reset();
            fieldGeneratorcapacity.reset();
            fieldGeneratordisplayName.reset();
            fieldGeneratoremailAddress.reset();
            fieldGeneratorfloorLabel.reset();
            fieldGeneratorfloorNumber.reset();
            fieldGeneratorgeoCoordinates.reset();
            fieldGeneratorid.reset();
            fieldGeneratorlabel.reset();
            fieldGeneratornickname.reset();
            fieldGeneratorphone.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(OutlookPlaceJSON  result)
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
        public OutlookPlaceJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OutlookPlaceJSON  result)
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
    protected virtual void handle_result(List<OutlookPlaceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OutlookPlaceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OutlookPlaceJSON>();
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
    public List<OutlookPlaceJSON> value;
  };
  };
