/* file "CarControlDrivingCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlDrivingCommandJSON : CarControlCommandJSON
  {
    public enum TypeCommandType
      {
        CommandType_CruiseControlOn,
        CommandType_CruiseControlOff,
        CommandType_FourWheelDriveOn,
        CommandType_FourWheelDriveOff,
        CommandType_AdaptiveCruiseControlOn,
        CommandType_AdaptiveCruiseControlOff,
        CommandType_TractionControlOn,
        CommandType_TractionControlOff,
        CommandType_LaneDepartureWarningOn,
        CommandType_LaneDepartureWarningOff,
        CommandType_AutomaticLaneKeepingOn,
        CommandType_AutomaticLaneKeepingOff,
        CommandType_ParkingAssistOn,
        CommandType_ParkingAssistOff,
        CommandType_CruiseControlSpeedUp,
        CommandType_CruiseControlSlowDown,
        CommandType_AutonomousParking,
        CommandType_AutopilotOn,
        CommandType_AutopilotOff
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'd':
                        if (String.Compare(chars, 2, "aptiveCruiseControlO", 0, 20, false) == 0)
                          {
                            switch (chars[22])
                              {
                                case 'f':
                                    if ((String.Compare(chars, 23, "f", 0, 1, false) == 0) && (chars.Length == 24))
                                        return TypeCommandType.CommandType_AdaptiveCruiseControlOff;
                                    break;
                                case 'n':
                                    if (chars.Length == 23)
                                        return TypeCommandType.CommandType_AdaptiveCruiseControlOn;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if (String.Compare(chars, 2, "to", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'm':
                                    if (String.Compare(chars, 5, "aticLaneKeepingO", 0, 16, false) == 0)
                                      {
                                        switch (chars[21])
                                          {
                                            case 'f':
                                                if ((String.Compare(chars, 22, "f", 0, 1, false) == 0) && (chars.Length == 23))
                                                    return TypeCommandType.CommandType_AutomaticLaneKeepingOff;
                                                break;
                                            case 'n':
                                                if (chars.Length == 22)
                                                    return TypeCommandType.CommandType_AutomaticLaneKeepingOn;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'n':
                                    if ((String.Compare(chars, 5, "omousParking", 0, 12, false) == 0) && (chars.Length == 17))
                                        return TypeCommandType.CommandType_AutonomousParking;
                                    break;
                                case 'p':
                                    if (String.Compare(chars, 5, "ilotO", 0, 5, false) == 0)
                                      {
                                        switch (chars[10])
                                          {
                                            case 'f':
                                                if ((String.Compare(chars, 11, "f", 0, 1, false) == 0) && (chars.Length == 12))
                                                    return TypeCommandType.CommandType_AutopilotOff;
                                                break;
                                            case 'n':
                                                if (chars.Length == 11)
                                                    return TypeCommandType.CommandType_AutopilotOn;
                                                break;
                                            default:
                                                break;
                                          }
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
                break;
            case 'C':
                if (String.Compare(chars, 1, "ruiseControl", 0, 12, false) == 0)
                  {
                    switch (chars[13])
                      {
                        case 'O':
                            switch (chars[14])
                              {
                                case 'f':
                                    if ((String.Compare(chars, 15, "f", 0, 1, false) == 0) && (chars.Length == 16))
                                        return TypeCommandType.CommandType_CruiseControlOff;
                                    break;
                                case 'n':
                                    if (chars.Length == 15)
                                        return TypeCommandType.CommandType_CruiseControlOn;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'S':
                            switch (chars[14])
                              {
                                case 'l':
                                    if ((String.Compare(chars, 15, "owDown", 0, 6, false) == 0) && (chars.Length == 21))
                                        return TypeCommandType.CommandType_CruiseControlSlowDown;
                                    break;
                                case 'p':
                                    if ((String.Compare(chars, 15, "eedUp", 0, 5, false) == 0) && (chars.Length == 20))
                                        return TypeCommandType.CommandType_CruiseControlSpeedUp;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if (String.Compare(chars, 1, "ourWheelDriveO", 0, 14, false) == 0)
                  {
                    switch (chars[15])
                      {
                        case 'f':
                            if ((String.Compare(chars, 16, "f", 0, 1, false) == 0) && (chars.Length == 17))
                                return TypeCommandType.CommandType_FourWheelDriveOff;
                            break;
                        case 'n':
                            if (chars.Length == 16)
                                return TypeCommandType.CommandType_FourWheelDriveOn;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if (String.Compare(chars, 1, "aneDepartureWarningO", 0, 20, false) == 0)
                  {
                    switch (chars[21])
                      {
                        case 'f':
                            if ((String.Compare(chars, 22, "f", 0, 1, false) == 0) && (chars.Length == 23))
                                return TypeCommandType.CommandType_LaneDepartureWarningOff;
                            break;
                        case 'n':
                            if (chars.Length == 22)
                                return TypeCommandType.CommandType_LaneDepartureWarningOn;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(chars, 1, "arkingAssistO", 0, 13, false) == 0)
                  {
                    switch (chars[14])
                      {
                        case 'f':
                            if ((String.Compare(chars, 15, "f", 0, 1, false) == 0) && (chars.Length == 16))
                                return TypeCommandType.CommandType_ParkingAssistOff;
                            break;
                        case 'n':
                            if (chars.Length == 15)
                                return TypeCommandType.CommandType_ParkingAssistOn;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if (String.Compare(chars, 1, "ractionControlO", 0, 15, false) == 0)
                  {
                    switch (chars[16])
                      {
                        case 'f':
                            if ((String.Compare(chars, 17, "f", 0, 1, false) == 0) && (chars.Length == 18))
                                return TypeCommandType.CommandType_TractionControlOff;
                            break;
                        case 'n':
                            if (chars.Length == 17)
                                return TypeCommandType.CommandType_TractionControlOn;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `CommandType' is not one of the legal values.");
      }

    public static string  stringFromCommandType(TypeCommandType the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandType.CommandType_CruiseControlOn:
                return "CruiseControlOn";
            case TypeCommandType.CommandType_CruiseControlOff:
                return "CruiseControlOff";
            case TypeCommandType.CommandType_FourWheelDriveOn:
                return "FourWheelDriveOn";
            case TypeCommandType.CommandType_FourWheelDriveOff:
                return "FourWheelDriveOff";
            case TypeCommandType.CommandType_AdaptiveCruiseControlOn:
                return "AdaptiveCruiseControlOn";
            case TypeCommandType.CommandType_AdaptiveCruiseControlOff:
                return "AdaptiveCruiseControlOff";
            case TypeCommandType.CommandType_TractionControlOn:
                return "TractionControlOn";
            case TypeCommandType.CommandType_TractionControlOff:
                return "TractionControlOff";
            case TypeCommandType.CommandType_LaneDepartureWarningOn:
                return "LaneDepartureWarningOn";
            case TypeCommandType.CommandType_LaneDepartureWarningOff:
                return "LaneDepartureWarningOff";
            case TypeCommandType.CommandType_AutomaticLaneKeepingOn:
                return "AutomaticLaneKeepingOn";
            case TypeCommandType.CommandType_AutomaticLaneKeepingOff:
                return "AutomaticLaneKeepingOff";
            case TypeCommandType.CommandType_ParkingAssistOn:
                return "ParkingAssistOn";
            case TypeCommandType.CommandType_ParkingAssistOff:
                return "ParkingAssistOff";
            case TypeCommandType.CommandType_CruiseControlSpeedUp:
                return "CruiseControlSpeedUp";
            case TypeCommandType.CommandType_CruiseControlSlowDown:
                return "CruiseControlSlowDown";
            case TypeCommandType.CommandType_AutonomousParking:
                return "AutonomousParking";
            case TypeCommandType.CommandType_AutopilotOn:
                return "AutopilotOn";
            case TypeCommandType.CommandType_AutopilotOff:
                return "AutopilotOff";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCruiseSpeed;
    private double storeCruiseSpeed;
    private string textStoreCruiseSpeed;
    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCruiseSpeedToJSON()
      {
        JSONValue generated_rational_CruiseSpeed;
        if (textStoreCruiseSpeed != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreCruiseSpeed);
            generated_rational_CruiseSpeed = handler.result;
          }
        else if (((double)(long)storeCruiseSpeed) == storeCruiseSpeed)
            generated_rational_CruiseSpeed = new JSONIntegerValue((long)(storeCruiseSpeed));
        else
            generated_rational_CruiseSpeed = new JSONRationalValue(storeCruiseSpeed, 15);
        return generated_rational_CruiseSpeed;
      }

    private JSONValue  extraCommandTypeToJSON()
      {
        JSONStringValue generated_string_CommandType;
        switch (storeCommandType)
          {
            case TypeCommandType.CommandType_CruiseControlOn:
                generated_string_CommandType = new JSONStringValue("CruiseControlOn");
                break;
            case TypeCommandType.CommandType_CruiseControlOff:
                generated_string_CommandType = new JSONStringValue("CruiseControlOff");
                break;
            case TypeCommandType.CommandType_FourWheelDriveOn:
                generated_string_CommandType = new JSONStringValue("FourWheelDriveOn");
                break;
            case TypeCommandType.CommandType_FourWheelDriveOff:
                generated_string_CommandType = new JSONStringValue("FourWheelDriveOff");
                break;
            case TypeCommandType.CommandType_AdaptiveCruiseControlOn:
                generated_string_CommandType = new JSONStringValue("AdaptiveCruiseControlOn");
                break;
            case TypeCommandType.CommandType_AdaptiveCruiseControlOff:
                generated_string_CommandType = new JSONStringValue("AdaptiveCruiseControlOff");
                break;
            case TypeCommandType.CommandType_TractionControlOn:
                generated_string_CommandType = new JSONStringValue("TractionControlOn");
                break;
            case TypeCommandType.CommandType_TractionControlOff:
                generated_string_CommandType = new JSONStringValue("TractionControlOff");
                break;
            case TypeCommandType.CommandType_LaneDepartureWarningOn:
                generated_string_CommandType = new JSONStringValue("LaneDepartureWarningOn");
                break;
            case TypeCommandType.CommandType_LaneDepartureWarningOff:
                generated_string_CommandType = new JSONStringValue("LaneDepartureWarningOff");
                break;
            case TypeCommandType.CommandType_AutomaticLaneKeepingOn:
                generated_string_CommandType = new JSONStringValue("AutomaticLaneKeepingOn");
                break;
            case TypeCommandType.CommandType_AutomaticLaneKeepingOff:
                generated_string_CommandType = new JSONStringValue("AutomaticLaneKeepingOff");
                break;
            case TypeCommandType.CommandType_ParkingAssistOn:
                generated_string_CommandType = new JSONStringValue("ParkingAssistOn");
                break;
            case TypeCommandType.CommandType_ParkingAssistOff:
                generated_string_CommandType = new JSONStringValue("ParkingAssistOff");
                break;
            case TypeCommandType.CommandType_CruiseControlSpeedUp:
                generated_string_CommandType = new JSONStringValue("CruiseControlSpeedUp");
                break;
            case TypeCommandType.CommandType_CruiseControlSlowDown:
                generated_string_CommandType = new JSONStringValue("CruiseControlSlowDown");
                break;
            case TypeCommandType.CommandType_AutonomousParking:
                generated_string_CommandType = new JSONStringValue("AutonomousParking");
                break;
            case TypeCommandType.CommandType_AutopilotOn:
                generated_string_CommandType = new JSONStringValue("AutopilotOn");
                break;
            case TypeCommandType.CommandType_AutopilotOff:
                generated_string_CommandType = new JSONStringValue("AutopilotOff");
                break;
            default:
                Debug.Assert(false);
                generated_string_CommandType = null;
                break;
          }
        return generated_string_CommandType;
      }


    private void  fromJSONCruiseSpeed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CruiseSpeed of CarControlDrivingCommandJSON is not a number.");
              }
          }
        setCruiseSpeedText(the_rational_text);
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of CarControlDrivingCommandJSON is not a string.");
        TypeCommandType the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'd':
                        if (String.Compare(json_string.getData(), 2, "aptiveCruiseControlO", 0, 20, false) == 0)
                          {
                            switch (json_string.getData()[22])
                              {
                                case 'f':
                                    if ((String.Compare(json_string.getData(), 23, "f", 0, 1, false) == 0) && (json_string.getData().Length == 24))
                                          {
                                            the_enum = TypeCommandType.CommandType_AdaptiveCruiseControlOff;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'n':
                                    if (json_string.getData().Length == 23)
                                          {
                                            the_enum = TypeCommandType.CommandType_AdaptiveCruiseControlOn;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if (String.Compare(json_string.getData(), 2, "to", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'm':
                                    if (String.Compare(json_string.getData(), 5, "aticLaneKeepingO", 0, 16, false) == 0)
                                      {
                                        switch (json_string.getData()[21])
                                          {
                                            case 'f':
                                                if ((String.Compare(json_string.getData(), 22, "f", 0, 1, false) == 0) && (json_string.getData().Length == 23))
                                                      {
                                                        the_enum = TypeCommandType.CommandType_AutomaticLaneKeepingOff;
                                                        goto enum_is_done;
                                                      }
                                                break;
                                            case 'n':
                                                if (json_string.getData().Length == 22)
                                                      {
                                                        the_enum = TypeCommandType.CommandType_AutomaticLaneKeepingOn;
                                                        goto enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'n':
                                    if ((String.Compare(json_string.getData(), 5, "omousParking", 0, 12, false) == 0) && (json_string.getData().Length == 17))
                                          {
                                            the_enum = TypeCommandType.CommandType_AutonomousParking;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'p':
                                    if (String.Compare(json_string.getData(), 5, "ilotO", 0, 5, false) == 0)
                                      {
                                        switch (json_string.getData()[10])
                                          {
                                            case 'f':
                                                if ((String.Compare(json_string.getData(), 11, "f", 0, 1, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_enum = TypeCommandType.CommandType_AutopilotOff;
                                                        goto enum_is_done;
                                                      }
                                                break;
                                            case 'n':
                                                if (json_string.getData().Length == 11)
                                                      {
                                                        the_enum = TypeCommandType.CommandType_AutopilotOn;
                                                        goto enum_is_done;
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
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if (String.Compare(json_string.getData(), 1, "ruiseControl", 0, 12, false) == 0)
                  {
                    switch (json_string.getData()[13])
                      {
                        case 'O':
                            switch (json_string.getData()[14])
                              {
                                case 'f':
                                    if ((String.Compare(json_string.getData(), 15, "f", 0, 1, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_enum = TypeCommandType.CommandType_CruiseControlOff;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'n':
                                    if (json_string.getData().Length == 15)
                                          {
                                            the_enum = TypeCommandType.CommandType_CruiseControlOn;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'S':
                            switch (json_string.getData()[14])
                              {
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 15, "owDown", 0, 6, false) == 0) && (json_string.getData().Length == 21))
                                          {
                                            the_enum = TypeCommandType.CommandType_CruiseControlSlowDown;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'p':
                                    if ((String.Compare(json_string.getData(), 15, "eedUp", 0, 5, false) == 0) && (json_string.getData().Length == 20))
                                          {
                                            the_enum = TypeCommandType.CommandType_CruiseControlSpeedUp;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if (String.Compare(json_string.getData(), 1, "ourWheelDriveO", 0, 14, false) == 0)
                  {
                    switch (json_string.getData()[15])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 16, "f", 0, 1, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_enum = TypeCommandType.CommandType_FourWheelDriveOff;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if (json_string.getData().Length == 16)
                                  {
                                    the_enum = TypeCommandType.CommandType_FourWheelDriveOn;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if (String.Compare(json_string.getData(), 1, "aneDepartureWarningO", 0, 20, false) == 0)
                  {
                    switch (json_string.getData()[21])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 22, "f", 0, 1, false) == 0) && (json_string.getData().Length == 23))
                                  {
                                    the_enum = TypeCommandType.CommandType_LaneDepartureWarningOff;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if (json_string.getData().Length == 22)
                                  {
                                    the_enum = TypeCommandType.CommandType_LaneDepartureWarningOn;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(json_string.getData(), 1, "arkingAssistO", 0, 13, false) == 0)
                  {
                    switch (json_string.getData()[14])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 15, "f", 0, 1, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_enum = TypeCommandType.CommandType_ParkingAssistOff;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if (json_string.getData().Length == 15)
                                  {
                                    the_enum = TypeCommandType.CommandType_ParkingAssistOn;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if (String.Compare(json_string.getData(), 1, "ractionControlO", 0, 15, false) == 0)
                  {
                    switch (json_string.getData()[16])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 17, "f", 0, 1, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_enum = TypeCommandType.CommandType_TractionControlOff;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if (json_string.getData().Length == 17)
                                  {
                                    the_enum = TypeCommandType.CommandType_TractionControlOn;
                                    goto enum_is_done;
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
        throw new Exception("The value for field CommandType of CarControlDrivingCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    public CarControlDrivingCommandJSON()
      {
        flagHasCruiseSpeed = false;
        flagHasCommandType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCarControlCommandKind()
      {
        return "CarControlDrivingCommand";
      }

    public bool  hasCruiseSpeed()
      {
        return flagHasCruiseSpeed;
      }

    public double  getCruiseSpeed()
      {
        Debug.Assert(flagHasCruiseSpeed);
        if (textStoreCruiseSpeed != "")
          {
            return Double.Parse(textStoreCruiseSpeed);
          }
        return storeCruiseSpeed;
      }

    public string  getCruiseSpeedAsText()
      {
        Debug.Assert(flagHasCruiseSpeed);
        if (textStoreCruiseSpeed == "")
          {
            return Convert.ToString(storeCruiseSpeed);
          }
        else
          {
            return (textStoreCruiseSpeed);
          }
      }

    public bool  hasCommandType()
      {
        return flagHasCommandType;
      }

    public TypeCommandType  getCommandType()
      {
        Debug.Assert(flagHasCommandType);
        return storeCommandType;
      }

    public string  getCommandTypeAsString()
      {
        return stringFromCommandType(getCommandType());
      }


    public virtual int extraCarControlDrivingCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlDrivingCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlDrivingCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlDrivingCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCarControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCruiseSpeed)
            ++result;
        if (flagHasCommandType)
            ++result;
        result += extraCarControlDrivingCommandComponentCount();
        return result;
      }
    public override string extraCarControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCruiseSpeed)
          {
            if (remainder == 0)
                return "CruiseSpeed";
            --remainder;
          }
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return "CommandType";
            --remainder;
          }
        return extraCarControlDrivingCommandComponentKey(remainder);
      }
    public override JSONValue extraCarControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCruiseSpeed)
          {
            if (remainder == 0)
                return extraCruiseSpeedToJSON();
            --remainder;
          }
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return extraCommandTypeToJSON();
            --remainder;
          }
        return extraCarControlDrivingCommandComponentValue(remainder);
      }
    public override JSONValue extraCarControlCommandLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "C", 0, 1, false) == 0)
          {
            switch (field_name[1])
              {
                case 'o':
                    if ((String.Compare(field_name, 2, "mmandType", 0, 9, false) == 0) && (field_name.Length == 11))
                        return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                    break;
                case 'r':
                    if ((String.Compare(field_name, 2, "uiseSpeed", 0, 9, false) == 0) && (field_name.Length == 11))
                        return (flagHasCruiseSpeed ? extraCruiseSpeedToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraCarControlDrivingCommandLookup(field_name);
      }

    public void setCruiseSpeed(double new_value)
      {
        flagHasCruiseSpeed = true;
        storeCruiseSpeed = new_value;
        textStoreCruiseSpeed = "";
      }
    public void setCruiseSpeedText(string new_value)
      {
        flagHasCruiseSpeed = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field CruiseSpeed of CarControlDrivingCommandJSON is not a valid number.");
        textStoreCruiseSpeed = new_value;
      }
    public void unsetCruiseSpeed()
      {
        flagHasCruiseSpeed = false;
      }
    public void setCommandType(TypeCommandType new_value)
      {
        flagHasCommandType = true;
        storeCommandType = new_value;
      }
    public void setCommandType(string chars)
      {
        setCommandType(stringToCommandType(chars));
      }
    public void unsetCommandType()
      {
        flagHasCommandType = false;
      }

    public virtual void extraCarControlDrivingCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlDrivingCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlDrivingCommandLookup(key);
        if (old_field == null)
          {
            extraCarControlDrivingCommandAppendPair(key, new_component);
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
    public override void extraCarControlCommandAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "C", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'o':
                    if ((String.Compare(key, 2, "mmandType", 0, 9, false) == 0) && (key.Length == 11))
                        {
                        fromJSONCommandType(new_component, false);
                        return;
                        }
                    break;
                case 'r':
                    if ((String.Compare(key, 2, "uiseSpeed", 0, 9, false) == 0) && (key.Length == 11))
                        {
                        fromJSONCruiseSpeed(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraCarControlDrivingCommandAppendPair(key, new_component);
      }
    public override void extraCarControlCommandSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "C", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'o':
                    if ((String.Compare(key, 2, "mmandType", 0, 9, false) == 0) && (key.Length == 11))
                        {
                        fromJSONCommandType(new_component, false);
                        return;
                        }
                    break;
                case 'r':
                    if ((String.Compare(key, 2, "uiseSpeed", 0, 9, false) == 0) && (key.Length == 11))
                        {
                        fromJSONCruiseSpeed(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraCarControlDrivingCommandSetField(key, new_component);
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
        if (flagHasCruiseSpeed)
          {
            handler.start_pair("CruiseSpeed");
            if (textStoreCruiseSpeed != "")
                handler.number_value(textStoreCruiseSpeed);
            else if (((double)(long)storeCruiseSpeed) == storeCruiseSpeed)
                handler.number_value((long)storeCruiseSpeed);
            else
                handler.number_value(storeCruiseSpeed);
          }
        Debug.Assert(partial_allowed || flagHasCommandType);
        if (flagHasCommandType)
          {
            handler.start_pair("CommandType");
            switch (storeCommandType)
              {
                case TypeCommandType.CommandType_CruiseControlOn:
                    handler.string_value("CruiseControlOn");
                    break;
                case TypeCommandType.CommandType_CruiseControlOff:
                    handler.string_value("CruiseControlOff");
                    break;
                case TypeCommandType.CommandType_FourWheelDriveOn:
                    handler.string_value("FourWheelDriveOn");
                    break;
                case TypeCommandType.CommandType_FourWheelDriveOff:
                    handler.string_value("FourWheelDriveOff");
                    break;
                case TypeCommandType.CommandType_AdaptiveCruiseControlOn:
                    handler.string_value("AdaptiveCruiseControlOn");
                    break;
                case TypeCommandType.CommandType_AdaptiveCruiseControlOff:
                    handler.string_value("AdaptiveCruiseControlOff");
                    break;
                case TypeCommandType.CommandType_TractionControlOn:
                    handler.string_value("TractionControlOn");
                    break;
                case TypeCommandType.CommandType_TractionControlOff:
                    handler.string_value("TractionControlOff");
                    break;
                case TypeCommandType.CommandType_LaneDepartureWarningOn:
                    handler.string_value("LaneDepartureWarningOn");
                    break;
                case TypeCommandType.CommandType_LaneDepartureWarningOff:
                    handler.string_value("LaneDepartureWarningOff");
                    break;
                case TypeCommandType.CommandType_AutomaticLaneKeepingOn:
                    handler.string_value("AutomaticLaneKeepingOn");
                    break;
                case TypeCommandType.CommandType_AutomaticLaneKeepingOff:
                    handler.string_value("AutomaticLaneKeepingOff");
                    break;
                case TypeCommandType.CommandType_ParkingAssistOn:
                    handler.string_value("ParkingAssistOn");
                    break;
                case TypeCommandType.CommandType_ParkingAssistOff:
                    handler.string_value("ParkingAssistOff");
                    break;
                case TypeCommandType.CommandType_CruiseControlSpeedUp:
                    handler.string_value("CruiseControlSpeedUp");
                    break;
                case TypeCommandType.CommandType_CruiseControlSlowDown:
                    handler.string_value("CruiseControlSlowDown");
                    break;
                case TypeCommandType.CommandType_AutonomousParking:
                    handler.string_value("AutonomousParking");
                    break;
                case TypeCommandType.CommandType_AutopilotOn:
                    handler.string_value("AutopilotOn");
                    break;
                case TypeCommandType.CommandType_AutopilotOff:
                    handler.string_value("AutopilotOff");
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasCommandType()))
          {
            return "When parsing the object for %what%, the \"CommandType\" field was missing.";
          }
        return null;
      }

    public static new CarControlDrivingCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlDrivingCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlDrivingCommand", ignore_extras);
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
    public static new CarControlDrivingCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlDrivingCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlDrivingCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlDrivingCommand", ignore_extras);
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
    public static new CarControlDrivingCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlDrivingCommandJSON from_text(string text, bool ignore_extras)
      {
        CarControlDrivingCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlDrivingCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlDrivingCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CarControlDrivingCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlDrivingCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlDrivingCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CarControlCommandJSON.Generator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorCruiseSpeed;
    private abstract class FieldGeneratorCommandType : JSONStringGenerator
          {
            protected FieldGeneratorCommandType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCommandType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCommandType(result));
              }
            protected abstract void handle_result(TypeCommandType result);
          };
    private class FieldHoldingGeneratorCommandType : FieldGeneratorCommandType
  {
    protected override void handle_result(TypeCommandType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCommandType(String what)
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
    public TypeCommandType value;
  };
    private class FieldHoldingArrayGeneratorCommandType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCommandType
      {
        private FieldHoldingArrayGeneratorCommandType top;

        protected override void handle_result(TypeCommandType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCommandType init_top)
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
    protected virtual void handle_result(List<TypeCommandType> result)
      {
      }

    public FieldHoldingArrayGeneratorCommandType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCommandType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCommandType> value;
  };
        private FieldHoldingGeneratorCommandType fieldGeneratorCommandType;
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
            if (!(getCarControlCommandJSONKey().Equals("CarControlDrivingCommand")))
                throw new Exception("The key field has a value other than `CarControlDrivingCommand'.");
            CarControlDrivingCommandJSON result = new CarControlDrivingCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlDrivingCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CarControlCommandJSON new_result)
          {
            handle_result((CarControlDrivingCommandJSON )new_result);
          }
        protected void finish(CarControlDrivingCommandJSON result)
          {
            if (fieldGeneratorCruiseSpeed.have_value)
              {
                result.setCruiseSpeedText(fieldGeneratorCruiseSpeed.value);
                fieldGeneratorCruiseSpeed.have_value = false;
              }
            if (fieldGeneratorCommandType.have_value)
              {
                result.setCommandType(fieldGeneratorCommandType.value);
                fieldGeneratorCommandType.have_value = false;
              }
            else if ((!(result.hasCommandType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CommandType\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CarControlDrivingCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "C", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'o':
                        if ((String.Compare(field_name, 2, "mmandType", 0, 9, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorCommandType;
                        break;
                    case 'r':
                        if ((String.Compare(field_name, 2, "uiseSpeed", 0, 9, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorCruiseSpeed;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCruiseSpeed = new JSONHoldingNumberTextGenerator("field \"CruiseSpeed\" of the CarControlDrivingCommand class");
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlDrivingCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlDrivingCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCruiseSpeed = new JSONHoldingNumberTextGenerator("field \"CruiseSpeed\" of the CarControlDrivingCommand class");
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlDrivingCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlDrivingCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCruiseSpeed.reset();
            fieldGeneratorCommandType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlDrivingCommandJSON  result)
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
        public CarControlDrivingCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlDrivingCommandJSON  result)
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
    protected virtual void handle_result(List<CarControlDrivingCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlDrivingCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlDrivingCommandJSON>();
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
    public List<CarControlDrivingCommandJSON> value;
  };
  };
