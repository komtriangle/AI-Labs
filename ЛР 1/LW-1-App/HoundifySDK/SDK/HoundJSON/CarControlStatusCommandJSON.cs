/* file "CarControlStatusCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlStatusCommandJSON : CarControlCommandJSON
  {
    public enum TypeTireSelection
      {
        TireSelection_LeftFront,
        TireSelection_RightFront,
        TireSelection_BothFront,
        TireSelection_LeftRear,
        TireSelection_RightRear,
        TireSelection_BothRear,
        TireSelection_BothLeft,
        TireSelection_BothRight,
        TireSelection_All,
        TireSelection_None
      };

    public static TypeTireSelection  stringToTireSelection(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ll", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeTireSelection.TireSelection_All;
                break;
            case 'B':
                if (String.Compare(chars, 1, "oth", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'F':
                            if ((String.Compare(chars, 5, "ront", 0, 4, false) == 0) && (chars.Length == 9))
                                return TypeTireSelection.TireSelection_BothFront;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 5, "eft", 0, 3, false) == 0) && (chars.Length == 8))
                                return TypeTireSelection.TireSelection_BothLeft;
                            break;
                        case 'R':
                            switch (chars[5])
                              {
                                case 'e':
                                    if ((String.Compare(chars, 6, "ar", 0, 2, false) == 0) && (chars.Length == 8))
                                        return TypeTireSelection.TireSelection_BothRear;
                                    break;
                                case 'i':
                                    if ((String.Compare(chars, 6, "ght", 0, 3, false) == 0) && (chars.Length == 9))
                                        return TypeTireSelection.TireSelection_BothRight;
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
            case 'L':
                if (String.Compare(chars, 1, "eft", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'F':
                            if ((String.Compare(chars, 5, "ront", 0, 4, false) == 0) && (chars.Length == 9))
                                return TypeTireSelection.TireSelection_LeftFront;
                            break;
                        case 'R':
                            if ((String.Compare(chars, 5, "ear", 0, 3, false) == 0) && (chars.Length == 8))
                                return TypeTireSelection.TireSelection_LeftRear;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeTireSelection.TireSelection_None;
                break;
            case 'R':
                if (String.Compare(chars, 1, "ight", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'F':
                            if ((String.Compare(chars, 6, "ront", 0, 4, false) == 0) && (chars.Length == 10))
                                return TypeTireSelection.TireSelection_RightFront;
                            break;
                        case 'R':
                            if ((String.Compare(chars, 6, "ear", 0, 3, false) == 0) && (chars.Length == 9))
                                return TypeTireSelection.TireSelection_RightRear;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `TireSelection' is not one of the legal values.");
      }

    public static string  stringFromTireSelection(TypeTireSelection the_enum)
      {
        switch (the_enum)
          {
            case TypeTireSelection.TireSelection_LeftFront:
                return "LeftFront";
            case TypeTireSelection.TireSelection_RightFront:
                return "RightFront";
            case TypeTireSelection.TireSelection_BothFront:
                return "BothFront";
            case TypeTireSelection.TireSelection_LeftRear:
                return "LeftRear";
            case TypeTireSelection.TireSelection_RightRear:
                return "RightRear";
            case TypeTireSelection.TireSelection_BothRear:
                return "BothRear";
            case TypeTireSelection.TireSelection_BothLeft:
                return "BothLeft";
            case TypeTireSelection.TireSelection_BothRight:
                return "BothRight";
            case TypeTireSelection.TireSelection_All:
                return "All";
            case TypeTireSelection.TireSelection_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeCommandType
      {
        CommandType_FuelInTankLeft,
        CommandType_DistanceBeforeOutOfFuel,
        CommandType_TirePressure,
        CommandType_CheckEngineLightMeaning,
        CommandType_EngineEfficiency,
        CommandType_CoolantTemperature,
        CommandType_BrakePadStatus,
        CommandType_MileageToNextService,
        CommandType_CurrentSpeed,
        CommandType_CurrentGear,
        CommandType_WhichSideFuelTank,
        CommandType_WiperFluidLeft,
        CommandType_AreSeatbeltsOn,
        CommandType_HowAmIDriving,
        CommandType_OilLevel,
        CommandType_BatteryVoltage,
        CommandType_AverageSpeed,
        CommandType_MileageToNextOilChange
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'r':
                        if ((String.Compare(chars, 2, "eSeatbeltsOn", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeCommandType.CommandType_AreSeatbeltsOn;
                        break;
                    case 'v':
                        if ((String.Compare(chars, 2, "erageSpeed", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeCommandType.CommandType_AverageSpeed;
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "tteryVoltage", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeCommandType.CommandType_BatteryVoltage;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "akePadStatus", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeCommandType.CommandType_BrakePadStatus;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'h':
                        if ((String.Compare(chars, 2, "eckEngineLightMeaning", 0, 21, false) == 0) && (chars.Length == 23))
                            return TypeCommandType.CommandType_CheckEngineLightMeaning;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "olantTemperature", 0, 16, false) == 0) && (chars.Length == 18))
                            return TypeCommandType.CommandType_CoolantTemperature;
                        break;
                    case 'u':
                        if (String.Compare(chars, 2, "rrent", 0, 5, false) == 0)
                          {
                            switch (chars[7])
                              {
                                case 'G':
                                    if ((String.Compare(chars, 8, "ear", 0, 3, false) == 0) && (chars.Length == 11))
                                        return TypeCommandType.CommandType_CurrentGear;
                                    break;
                                case 'S':
                                    if ((String.Compare(chars, 8, "peed", 0, 4, false) == 0) && (chars.Length == 12))
                                        return TypeCommandType.CommandType_CurrentSpeed;
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
            case 'D':
                if ((String.Compare(chars, 1, "istanceBeforeOutOfFuel", 0, 22, false) == 0) && (chars.Length == 23))
                    return TypeCommandType.CommandType_DistanceBeforeOutOfFuel;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "ngineEfficiency", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeCommandType.CommandType_EngineEfficiency;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "uelInTankLeft", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeCommandType.CommandType_FuelInTankLeft;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "owAmIDriving", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeCommandType.CommandType_HowAmIDriving;
                break;
            case 'M':
                if (String.Compare(chars, 1, "ileageToNext", 0, 12, false) == 0)
                  {
                    switch (chars[13])
                      {
                        case 'O':
                            if ((String.Compare(chars, 14, "ilChange", 0, 8, false) == 0) && (chars.Length == 22))
                                return TypeCommandType.CommandType_MileageToNextOilChange;
                            break;
                        case 'S':
                            if ((String.Compare(chars, 14, "ervice", 0, 6, false) == 0) && (chars.Length == 20))
                                return TypeCommandType.CommandType_MileageToNextService;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if ((String.Compare(chars, 1, "ilLevel", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeCommandType.CommandType_OilLevel;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "irePressure", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeCommandType.CommandType_TirePressure;
                break;
            case 'W':
                switch (chars[1])
                  {
                    case 'h':
                        if ((String.Compare(chars, 2, "ichSideFuelTank", 0, 15, false) == 0) && (chars.Length == 17))
                            return TypeCommandType.CommandType_WhichSideFuelTank;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "perFluidLeft", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeCommandType.CommandType_WiperFluidLeft;
                        break;
                    default:
                        break;
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
            case TypeCommandType.CommandType_FuelInTankLeft:
                return "FuelInTankLeft";
            case TypeCommandType.CommandType_DistanceBeforeOutOfFuel:
                return "DistanceBeforeOutOfFuel";
            case TypeCommandType.CommandType_TirePressure:
                return "TirePressure";
            case TypeCommandType.CommandType_CheckEngineLightMeaning:
                return "CheckEngineLightMeaning";
            case TypeCommandType.CommandType_EngineEfficiency:
                return "EngineEfficiency";
            case TypeCommandType.CommandType_CoolantTemperature:
                return "CoolantTemperature";
            case TypeCommandType.CommandType_BrakePadStatus:
                return "BrakePadStatus";
            case TypeCommandType.CommandType_MileageToNextService:
                return "MileageToNextService";
            case TypeCommandType.CommandType_CurrentSpeed:
                return "CurrentSpeed";
            case TypeCommandType.CommandType_CurrentGear:
                return "CurrentGear";
            case TypeCommandType.CommandType_WhichSideFuelTank:
                return "WhichSideFuelTank";
            case TypeCommandType.CommandType_WiperFluidLeft:
                return "WiperFluidLeft";
            case TypeCommandType.CommandType_AreSeatbeltsOn:
                return "AreSeatbeltsOn";
            case TypeCommandType.CommandType_HowAmIDriving:
                return "HowAmIDriving";
            case TypeCommandType.CommandType_OilLevel:
                return "OilLevel";
            case TypeCommandType.CommandType_BatteryVoltage:
                return "BatteryVoltage";
            case TypeCommandType.CommandType_AverageSpeed:
                return "AverageSpeed";
            case TypeCommandType.CommandType_MileageToNextOilChange:
                return "MileageToNextOilChange";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeEfficiencyUnit
      {
        EfficiencyUnit_MPG,
        EfficiencyUnit_L_x2f_100Km,
        EfficiencyUnit_Km_x2f_L,
        EfficiencyUnit_None
      };

    public static TypeEfficiencyUnit  stringToEfficiencyUnit(string chars)
      {
        switch (chars[0])
          {
            case 'K':
                if ((String.Compare(chars, 1, "m/L", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeEfficiencyUnit.EfficiencyUnit_Km_x2f_L;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "/100Km", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeEfficiencyUnit.EfficiencyUnit_L_x2f_100Km;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "PG", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeEfficiencyUnit.EfficiencyUnit_MPG;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeEfficiencyUnit.EfficiencyUnit_None;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `EfficiencyUnit' is not one of the legal values.");
      }

    public static string  stringFromEfficiencyUnit(TypeEfficiencyUnit the_enum)
      {
        switch (the_enum)
          {
            case TypeEfficiencyUnit.EfficiencyUnit_MPG:
                return "MPG";
            case TypeEfficiencyUnit.EfficiencyUnit_L_x2f_100Km:
                return "L/100Km";
            case TypeEfficiencyUnit.EfficiencyUnit_Km_x2f_L:
                return "Km/L";
            case TypeEfficiencyUnit.EfficiencyUnit_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTireSelection;
    private TypeTireSelection storeTireSelection;
    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private bool flagHasShowMe;
    private bool storeShowMe;
    private bool flagHasEfficiencyUnit;
    private TypeEfficiencyUnit storeEfficiencyUnit;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraTireSelectionToJSON()
      {
        JSONStringValue generated_string_TireSelection;
        switch (storeTireSelection)
          {
            case TypeTireSelection.TireSelection_LeftFront:
                generated_string_TireSelection = new JSONStringValue("LeftFront");
                break;
            case TypeTireSelection.TireSelection_RightFront:
                generated_string_TireSelection = new JSONStringValue("RightFront");
                break;
            case TypeTireSelection.TireSelection_BothFront:
                generated_string_TireSelection = new JSONStringValue("BothFront");
                break;
            case TypeTireSelection.TireSelection_LeftRear:
                generated_string_TireSelection = new JSONStringValue("LeftRear");
                break;
            case TypeTireSelection.TireSelection_RightRear:
                generated_string_TireSelection = new JSONStringValue("RightRear");
                break;
            case TypeTireSelection.TireSelection_BothRear:
                generated_string_TireSelection = new JSONStringValue("BothRear");
                break;
            case TypeTireSelection.TireSelection_BothLeft:
                generated_string_TireSelection = new JSONStringValue("BothLeft");
                break;
            case TypeTireSelection.TireSelection_BothRight:
                generated_string_TireSelection = new JSONStringValue("BothRight");
                break;
            case TypeTireSelection.TireSelection_All:
                generated_string_TireSelection = new JSONStringValue("All");
                break;
            case TypeTireSelection.TireSelection_None:
                generated_string_TireSelection = new JSONStringValue("None");
                break;
            default:
                Debug.Assert(false);
                generated_string_TireSelection = null;
                break;
          }
        return generated_string_TireSelection;
      }

    private JSONValue  extraCommandTypeToJSON()
      {
        JSONStringValue generated_string_CommandType;
        switch (storeCommandType)
          {
            case TypeCommandType.CommandType_FuelInTankLeft:
                generated_string_CommandType = new JSONStringValue("FuelInTankLeft");
                break;
            case TypeCommandType.CommandType_DistanceBeforeOutOfFuel:
                generated_string_CommandType = new JSONStringValue("DistanceBeforeOutOfFuel");
                break;
            case TypeCommandType.CommandType_TirePressure:
                generated_string_CommandType = new JSONStringValue("TirePressure");
                break;
            case TypeCommandType.CommandType_CheckEngineLightMeaning:
                generated_string_CommandType = new JSONStringValue("CheckEngineLightMeaning");
                break;
            case TypeCommandType.CommandType_EngineEfficiency:
                generated_string_CommandType = new JSONStringValue("EngineEfficiency");
                break;
            case TypeCommandType.CommandType_CoolantTemperature:
                generated_string_CommandType = new JSONStringValue("CoolantTemperature");
                break;
            case TypeCommandType.CommandType_BrakePadStatus:
                generated_string_CommandType = new JSONStringValue("BrakePadStatus");
                break;
            case TypeCommandType.CommandType_MileageToNextService:
                generated_string_CommandType = new JSONStringValue("MileageToNextService");
                break;
            case TypeCommandType.CommandType_CurrentSpeed:
                generated_string_CommandType = new JSONStringValue("CurrentSpeed");
                break;
            case TypeCommandType.CommandType_CurrentGear:
                generated_string_CommandType = new JSONStringValue("CurrentGear");
                break;
            case TypeCommandType.CommandType_WhichSideFuelTank:
                generated_string_CommandType = new JSONStringValue("WhichSideFuelTank");
                break;
            case TypeCommandType.CommandType_WiperFluidLeft:
                generated_string_CommandType = new JSONStringValue("WiperFluidLeft");
                break;
            case TypeCommandType.CommandType_AreSeatbeltsOn:
                generated_string_CommandType = new JSONStringValue("AreSeatbeltsOn");
                break;
            case TypeCommandType.CommandType_HowAmIDriving:
                generated_string_CommandType = new JSONStringValue("HowAmIDriving");
                break;
            case TypeCommandType.CommandType_OilLevel:
                generated_string_CommandType = new JSONStringValue("OilLevel");
                break;
            case TypeCommandType.CommandType_BatteryVoltage:
                generated_string_CommandType = new JSONStringValue("BatteryVoltage");
                break;
            case TypeCommandType.CommandType_AverageSpeed:
                generated_string_CommandType = new JSONStringValue("AverageSpeed");
                break;
            case TypeCommandType.CommandType_MileageToNextOilChange:
                generated_string_CommandType = new JSONStringValue("MileageToNextOilChange");
                break;
            default:
                Debug.Assert(false);
                generated_string_CommandType = null;
                break;
          }
        return generated_string_CommandType;
      }

    private JSONValue  extraShowMeToJSON()
      {
        JSONValue generated_boolean_ShowMe = (storeShowMe ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ShowMe;
      }

    private JSONValue  extraEfficiencyUnitToJSON()
      {
        JSONStringValue generated_string_EfficiencyUnit;
        switch (storeEfficiencyUnit)
          {
            case TypeEfficiencyUnit.EfficiencyUnit_MPG:
                generated_string_EfficiencyUnit = new JSONStringValue("MPG");
                break;
            case TypeEfficiencyUnit.EfficiencyUnit_L_x2f_100Km:
                generated_string_EfficiencyUnit = new JSONStringValue("L/100Km");
                break;
            case TypeEfficiencyUnit.EfficiencyUnit_Km_x2f_L:
                generated_string_EfficiencyUnit = new JSONStringValue("Km/L");
                break;
            case TypeEfficiencyUnit.EfficiencyUnit_None:
                generated_string_EfficiencyUnit = new JSONStringValue("None");
                break;
            default:
                Debug.Assert(false);
                generated_string_EfficiencyUnit = null;
                break;
          }
        return generated_string_EfficiencyUnit;
      }


    private void  fromJSONTireSelection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TireSelection of CarControlStatusCommandJSON is not a string.");
        TypeTireSelection the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ll", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeTireSelection.TireSelection_All;
                        goto enum_is_done;
                      }
                break;
            case 'B':
                if (String.Compare(json_string.getData(), 1, "oth", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 5, "ront", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeTireSelection.TireSelection_BothFront;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 5, "eft", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_enum = TypeTireSelection.TireSelection_BothLeft;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'R':
                            switch (json_string.getData()[5])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 6, "ar", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_enum = TypeTireSelection.TireSelection_BothRear;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'i':
                                    if ((String.Compare(json_string.getData(), 6, "ght", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_enum = TypeTireSelection.TireSelection_BothRight;
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
            case 'L':
                if (String.Compare(json_string.getData(), 1, "eft", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 5, "ront", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeTireSelection.TireSelection_LeftFront;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'R':
                            if ((String.Compare(json_string.getData(), 5, "ear", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_enum = TypeTireSelection.TireSelection_LeftRear;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeTireSelection.TireSelection_None;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if (String.Compare(json_string.getData(), 1, "ight", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 6, "ront", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeTireSelection.TireSelection_RightFront;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'R':
                            if ((String.Compare(json_string.getData(), 6, "ear", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeTireSelection.TireSelection_RightRear;
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
        throw new Exception("The value for field TireSelection of CarControlStatusCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setTireSelection(the_enum);
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of CarControlStatusCommandJSON is not a string.");
        TypeCommandType the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "eSeatbeltsOn", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_enum = TypeCommandType.CommandType_AreSeatbeltsOn;
                                goto enum_is_done;
                              }
                        break;
                    case 'v':
                        if ((String.Compare(json_string.getData(), 2, "erageSpeed", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_enum = TypeCommandType.CommandType_AverageSpeed;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "tteryVoltage", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_enum = TypeCommandType.CommandType_BatteryVoltage;
                                goto enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "akePadStatus", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_enum = TypeCommandType.CommandType_BrakePadStatus;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "eckEngineLightMeaning", 0, 21, false) == 0) && (json_string.getData().Length == 23))
                              {
                                the_enum = TypeCommandType.CommandType_CheckEngineLightMeaning;
                                goto enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "olantTemperature", 0, 16, false) == 0) && (json_string.getData().Length == 18))
                              {
                                the_enum = TypeCommandType.CommandType_CoolantTemperature;
                                goto enum_is_done;
                              }
                        break;
                    case 'u':
                        if (String.Compare(json_string.getData(), 2, "rrent", 0, 5, false) == 0)
                          {
                            switch (json_string.getData()[7])
                              {
                                case 'G':
                                    if ((String.Compare(json_string.getData(), 8, "ear", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_enum = TypeCommandType.CommandType_CurrentGear;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'S':
                                    if ((String.Compare(json_string.getData(), 8, "peed", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_enum = TypeCommandType.CommandType_CurrentSpeed;
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
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "istanceBeforeOutOfFuel", 0, 22, false) == 0) && (json_string.getData().Length == 23))
                      {
                        the_enum = TypeCommandType.CommandType_DistanceBeforeOutOfFuel;
                        goto enum_is_done;
                      }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "ngineEfficiency", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_enum = TypeCommandType.CommandType_EngineEfficiency;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "uelInTankLeft", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_enum = TypeCommandType.CommandType_FuelInTankLeft;
                        goto enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "owAmIDriving", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeCommandType.CommandType_HowAmIDriving;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if (String.Compare(json_string.getData(), 1, "ileageToNext", 0, 12, false) == 0)
                  {
                    switch (json_string.getData()[13])
                      {
                        case 'O':
                            if ((String.Compare(json_string.getData(), 14, "ilChange", 0, 8, false) == 0) && (json_string.getData().Length == 22))
                                  {
                                    the_enum = TypeCommandType.CommandType_MileageToNextOilChange;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 14, "ervice", 0, 6, false) == 0) && (json_string.getData().Length == 20))
                                  {
                                    the_enum = TypeCommandType.CommandType_MileageToNextService;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "ilLevel", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeCommandType.CommandType_OilLevel;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "irePressure", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_enum = TypeCommandType.CommandType_TirePressure;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                switch (json_string.getData()[1])
                  {
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "ichSideFuelTank", 0, 15, false) == 0) && (json_string.getData().Length == 17))
                              {
                                the_enum = TypeCommandType.CommandType_WhichSideFuelTank;
                                goto enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "perFluidLeft", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_enum = TypeCommandType.CommandType_WiperFluidLeft;
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
        throw new Exception("The value for field CommandType of CarControlStatusCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    private void  fromJSONShowMe(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ShowMe of CarControlStatusCommandJSON is not true for false.");
              }
          }
        setShowMe(the_bool);
      }


    private void  fromJSONEfficiencyUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EfficiencyUnit of CarControlStatusCommandJSON is not a string.");
        TypeEfficiencyUnit the_enum;
        switch (json_string.getData()[0])
          {
            case 'K':
                if ((String.Compare(json_string.getData(), 1, "m/L", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeEfficiencyUnit.EfficiencyUnit_Km_x2f_L;
                        goto enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "/100Km", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeEfficiencyUnit.EfficiencyUnit_L_x2f_100Km;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "PG", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeEfficiencyUnit.EfficiencyUnit_MPG;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeEfficiencyUnit.EfficiencyUnit_None;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field EfficiencyUnit of CarControlStatusCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setEfficiencyUnit(the_enum);
      }


    public CarControlStatusCommandJSON()
      {
        flagHasTireSelection = false;
        flagHasCommandType = false;
        flagHasShowMe = false;
        flagHasEfficiencyUnit = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCarControlCommandKind()
      {
        return "CarControlStatusCommand";
      }

    public bool  hasTireSelection()
      {
        return flagHasTireSelection;
      }

    public TypeTireSelection  getTireSelection()
      {
        Debug.Assert(flagHasTireSelection);
        return storeTireSelection;
      }

    public string  getTireSelectionAsString()
      {
        return stringFromTireSelection(getTireSelection());
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

    public bool  hasShowMe()
      {
        return flagHasShowMe;
      }

    public bool  getShowMe()
      {
        Debug.Assert(flagHasShowMe);
        return storeShowMe;
      }

    public bool  hasEfficiencyUnit()
      {
        return flagHasEfficiencyUnit;
      }

    public TypeEfficiencyUnit  getEfficiencyUnit()
      {
        Debug.Assert(flagHasEfficiencyUnit);
        return storeEfficiencyUnit;
      }

    public string  getEfficiencyUnitAsString()
      {
        return stringFromEfficiencyUnit(getEfficiencyUnit());
      }


    public virtual int extraCarControlStatusCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlStatusCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlStatusCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlStatusCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCarControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasTireSelection)
            ++result;
        if (flagHasCommandType)
            ++result;
        if (flagHasShowMe)
            ++result;
        if (flagHasEfficiencyUnit)
            ++result;
        result += extraCarControlStatusCommandComponentCount();
        return result;
      }
    public override string extraCarControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasTireSelection)
          {
            if (remainder == 0)
                return "TireSelection";
            --remainder;
          }
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return "CommandType";
            --remainder;
          }
        if (flagHasShowMe)
          {
            if (remainder == 0)
                return "ShowMe";
            --remainder;
          }
        if (flagHasEfficiencyUnit)
          {
            if (remainder == 0)
                return "EfficiencyUnit";
            --remainder;
          }
        return extraCarControlStatusCommandComponentKey(remainder);
      }
    public override JSONValue extraCarControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasTireSelection)
          {
            if (remainder == 0)
                return extraTireSelectionToJSON();
            --remainder;
          }
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return extraCommandTypeToJSON();
            --remainder;
          }
        if (flagHasShowMe)
          {
            if (remainder == 0)
                return extraShowMeToJSON();
            --remainder;
          }
        if (flagHasEfficiencyUnit)
          {
            if (remainder == 0)
                return extraEfficiencyUnitToJSON();
            --remainder;
          }
        return extraCarControlStatusCommandComponentValue(remainder);
      }
    public override JSONValue extraCarControlCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "fficiencyUnit", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasEfficiencyUnit ? extraEfficiencyUnitToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "howMe", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasShowMe ? extraShowMeToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "ireSelection", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasTireSelection ? extraTireSelectionToJSON() : null);
                break;
            default:
                break;
          }
        return extraCarControlStatusCommandLookup(field_name);
      }

    public void setTireSelection(TypeTireSelection new_value)
      {
        flagHasTireSelection = true;
        storeTireSelection = new_value;
      }
    public void setTireSelection(string chars)
      {
        setTireSelection(stringToTireSelection(chars));
      }
    public void unsetTireSelection()
      {
        flagHasTireSelection = false;
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
    public void setShowMe(bool new_value)
      {
        flagHasShowMe = true;
        storeShowMe = new_value;
      }
    public void unsetShowMe()
      {
        flagHasShowMe = false;
      }
    public void setEfficiencyUnit(TypeEfficiencyUnit new_value)
      {
        flagHasEfficiencyUnit = true;
        storeEfficiencyUnit = new_value;
      }
    public void setEfficiencyUnit(string chars)
      {
        setEfficiencyUnit(stringToEfficiencyUnit(chars));
      }
    public void unsetEfficiencyUnit()
      {
        flagHasEfficiencyUnit = false;
      }

    public virtual void extraCarControlStatusCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlStatusCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlStatusCommandLookup(key);
        if (old_field == null)
          {
            extraCarControlStatusCommandAppendPair(key, new_component);
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
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ommandType", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCommandType(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "fficiencyUnit", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONEfficiencyUnit(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "howMe", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONShowMe(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "ireSelection", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONTireSelection(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlStatusCommandAppendPair(key, new_component);
      }
    public override void extraCarControlCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ommandType", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCommandType(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "fficiencyUnit", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONEfficiencyUnit(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "howMe", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONShowMe(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "ireSelection", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONTireSelection(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlStatusCommandSetField(key, new_component);
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
        if (flagHasTireSelection)
          {
            handler.start_pair("TireSelection");
            switch (storeTireSelection)
              {
                case TypeTireSelection.TireSelection_LeftFront:
                    handler.string_value("LeftFront");
                    break;
                case TypeTireSelection.TireSelection_RightFront:
                    handler.string_value("RightFront");
                    break;
                case TypeTireSelection.TireSelection_BothFront:
                    handler.string_value("BothFront");
                    break;
                case TypeTireSelection.TireSelection_LeftRear:
                    handler.string_value("LeftRear");
                    break;
                case TypeTireSelection.TireSelection_RightRear:
                    handler.string_value("RightRear");
                    break;
                case TypeTireSelection.TireSelection_BothRear:
                    handler.string_value("BothRear");
                    break;
                case TypeTireSelection.TireSelection_BothLeft:
                    handler.string_value("BothLeft");
                    break;
                case TypeTireSelection.TireSelection_BothRight:
                    handler.string_value("BothRight");
                    break;
                case TypeTireSelection.TireSelection_All:
                    handler.string_value("All");
                    break;
                case TypeTireSelection.TireSelection_None:
                    handler.string_value("None");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasCommandType);
        if (flagHasCommandType)
          {
            handler.start_pair("CommandType");
            switch (storeCommandType)
              {
                case TypeCommandType.CommandType_FuelInTankLeft:
                    handler.string_value("FuelInTankLeft");
                    break;
                case TypeCommandType.CommandType_DistanceBeforeOutOfFuel:
                    handler.string_value("DistanceBeforeOutOfFuel");
                    break;
                case TypeCommandType.CommandType_TirePressure:
                    handler.string_value("TirePressure");
                    break;
                case TypeCommandType.CommandType_CheckEngineLightMeaning:
                    handler.string_value("CheckEngineLightMeaning");
                    break;
                case TypeCommandType.CommandType_EngineEfficiency:
                    handler.string_value("EngineEfficiency");
                    break;
                case TypeCommandType.CommandType_CoolantTemperature:
                    handler.string_value("CoolantTemperature");
                    break;
                case TypeCommandType.CommandType_BrakePadStatus:
                    handler.string_value("BrakePadStatus");
                    break;
                case TypeCommandType.CommandType_MileageToNextService:
                    handler.string_value("MileageToNextService");
                    break;
                case TypeCommandType.CommandType_CurrentSpeed:
                    handler.string_value("CurrentSpeed");
                    break;
                case TypeCommandType.CommandType_CurrentGear:
                    handler.string_value("CurrentGear");
                    break;
                case TypeCommandType.CommandType_WhichSideFuelTank:
                    handler.string_value("WhichSideFuelTank");
                    break;
                case TypeCommandType.CommandType_WiperFluidLeft:
                    handler.string_value("WiperFluidLeft");
                    break;
                case TypeCommandType.CommandType_AreSeatbeltsOn:
                    handler.string_value("AreSeatbeltsOn");
                    break;
                case TypeCommandType.CommandType_HowAmIDriving:
                    handler.string_value("HowAmIDriving");
                    break;
                case TypeCommandType.CommandType_OilLevel:
                    handler.string_value("OilLevel");
                    break;
                case TypeCommandType.CommandType_BatteryVoltage:
                    handler.string_value("BatteryVoltage");
                    break;
                case TypeCommandType.CommandType_AverageSpeed:
                    handler.string_value("AverageSpeed");
                    break;
                case TypeCommandType.CommandType_MileageToNextOilChange:
                    handler.string_value("MileageToNextOilChange");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasShowMe);
        if (flagHasShowMe)
          {
            handler.start_pair("ShowMe");
            handler.boolean_value(storeShowMe);
          }
        if (flagHasEfficiencyUnit)
          {
            handler.start_pair("EfficiencyUnit");
            switch (storeEfficiencyUnit)
              {
                case TypeEfficiencyUnit.EfficiencyUnit_MPG:
                    handler.string_value("MPG");
                    break;
                case TypeEfficiencyUnit.EfficiencyUnit_L_x2f_100Km:
                    handler.string_value("L/100Km");
                    break;
                case TypeEfficiencyUnit.EfficiencyUnit_Km_x2f_L:
                    handler.string_value("Km/L");
                    break;
                case TypeEfficiencyUnit.EfficiencyUnit_None:
                    handler.string_value("None");
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
        if (!(hasShowMe()))
          {
            return "When parsing the object for %what%, the \"ShowMe\" field was missing.";
          }
        return null;
      }

    public static new CarControlStatusCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlStatusCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlStatusCommand", ignore_extras);
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
    public static new CarControlStatusCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlStatusCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlStatusCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlStatusCommand", ignore_extras);
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
    public static new CarControlStatusCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlStatusCommandJSON from_text(string text, bool ignore_extras)
      {
        CarControlStatusCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlStatusCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlStatusCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CarControlStatusCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlStatusCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlStatusCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CarControlCommandJSON.Generator
      {
    private abstract class FieldGeneratorTireSelection : JSONStringGenerator
          {
            protected FieldGeneratorTireSelection(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTireSelection()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToTireSelection(result));
              }
            protected abstract void handle_result(TypeTireSelection result);
          };
    private class FieldHoldingGeneratorTireSelection : FieldGeneratorTireSelection
  {
    protected override void handle_result(TypeTireSelection result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTireSelection(String what)
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
    public TypeTireSelection value;
  };
    private class FieldHoldingArrayGeneratorTireSelection : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTireSelection
      {
        private FieldHoldingArrayGeneratorTireSelection top;

        protected override void handle_result(TypeTireSelection result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTireSelection init_top)
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
    protected virtual void handle_result(List<TypeTireSelection> result)
      {
      }

    public FieldHoldingArrayGeneratorTireSelection(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTireSelection>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTireSelection()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTireSelection>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTireSelection> value;
  };
        private FieldHoldingGeneratorTireSelection fieldGeneratorTireSelection;
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
        private JSONHoldingBooleanGenerator fieldGeneratorShowMe;
    private abstract class FieldGeneratorEfficiencyUnit : JSONStringGenerator
          {
            protected FieldGeneratorEfficiencyUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorEfficiencyUnit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToEfficiencyUnit(result));
              }
            protected abstract void handle_result(TypeEfficiencyUnit result);
          };
    private class FieldHoldingGeneratorEfficiencyUnit : FieldGeneratorEfficiencyUnit
  {
    protected override void handle_result(TypeEfficiencyUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorEfficiencyUnit(String what)
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
    public TypeEfficiencyUnit value;
  };
    private class FieldHoldingArrayGeneratorEfficiencyUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorEfficiencyUnit
      {
        private FieldHoldingArrayGeneratorEfficiencyUnit top;

        protected override void handle_result(TypeEfficiencyUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorEfficiencyUnit init_top)
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
    protected virtual void handle_result(List<TypeEfficiencyUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorEfficiencyUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEfficiencyUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorEfficiencyUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEfficiencyUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeEfficiencyUnit> value;
  };
        private FieldHoldingGeneratorEfficiencyUnit fieldGeneratorEfficiencyUnit;
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
            if (!(getCarControlCommandJSONKey().Equals("CarControlStatusCommand")))
                throw new Exception("The key field has a value other than `CarControlStatusCommand'.");
            CarControlStatusCommandJSON result = new CarControlStatusCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlStatusCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CarControlCommandJSON new_result)
          {
            handle_result((CarControlStatusCommandJSON )new_result);
          }
        protected void finish(CarControlStatusCommandJSON result)
          {
            if (fieldGeneratorTireSelection.have_value)
              {
                result.setTireSelection(fieldGeneratorTireSelection.value);
                fieldGeneratorTireSelection.have_value = false;
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
            if (fieldGeneratorShowMe.have_value)
              {
                result.setShowMe(fieldGeneratorShowMe.value);
                fieldGeneratorShowMe.have_value = false;
              }
            else if ((!(result.hasShowMe())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ShowMe\" field was missing.");
              }
            if (fieldGeneratorEfficiencyUnit.have_value)
              {
                result.setEfficiencyUnit(fieldGeneratorEfficiencyUnit.value);
                fieldGeneratorEfficiencyUnit.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CarControlStatusCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandType;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "fficiencyUnit", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorEfficiencyUnit;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "howMe", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorShowMe;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ireSelection", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorTireSelection;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorTireSelection = new FieldHoldingGeneratorTireSelection("field \"TireSelection\" of the CarControlStatusCommand class");
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlStatusCommand class");
            fieldGeneratorShowMe = new JSONHoldingBooleanGenerator("field \"ShowMe\" of the CarControlStatusCommand class");
            fieldGeneratorEfficiencyUnit = new FieldHoldingGeneratorEfficiencyUnit("field \"EfficiencyUnit\" of the CarControlStatusCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlStatusCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorTireSelection = new FieldHoldingGeneratorTireSelection("field \"TireSelection\" of the CarControlStatusCommand class");
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlStatusCommand class");
            fieldGeneratorShowMe = new JSONHoldingBooleanGenerator("field \"ShowMe\" of the CarControlStatusCommand class");
            fieldGeneratorEfficiencyUnit = new FieldHoldingGeneratorEfficiencyUnit("field \"EfficiencyUnit\" of the CarControlStatusCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlStatusCommand class");
          }

        public override void reset()
          {
            fieldGeneratorTireSelection.reset();
            fieldGeneratorCommandType.reset();
            fieldGeneratorShowMe.reset();
            fieldGeneratorEfficiencyUnit.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlStatusCommandJSON  result)
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
        public CarControlStatusCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlStatusCommandJSON  result)
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
    protected virtual void handle_result(List<CarControlStatusCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlStatusCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlStatusCommandJSON>();
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
    public List<CarControlStatusCommandJSON> value;
  };
  };
