/* file "CarControlClimateCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlClimateCommandJSON : CarControlCommandJSON
  {
    public enum TypeCommandType
      {
        CommandType_TurnAirConditioningOn,
        CommandType_TurnAirConditioningOff,
        CommandType_MaxAirConditioning,
        CommandType_TurnHeatingOn,
        CommandType_TurnHeatingOff,
        CommandType_AdjustTemperature,
        CommandType_RecirculateOn,
        CommandType_RecirculateOff,
        CommandType_AdjustVents,
        CommandType_AdjustFan,
        CommandType_SyncTemperatureZones,
        CommandType_SetClimateControlToAuto,
        CommandType_SetClimateControlToManual,
        CommandType_ShowClimateControlScreen
      };

    public static TypeCommandType  stringToCommandType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (String.Compare(chars, 1, "djust", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'F':
                            if ((String.Compare(chars, 7, "an", 0, 2, false) == 0) && (chars.Length == 9))
                                return TypeCommandType.CommandType_AdjustFan;
                            break;
                        case 'T':
                            if ((String.Compare(chars, 7, "emperature", 0, 10, false) == 0) && (chars.Length == 17))
                                return TypeCommandType.CommandType_AdjustTemperature;
                            break;
                        case 'V':
                            if ((String.Compare(chars, 7, "ents", 0, 4, false) == 0) && (chars.Length == 11))
                                return TypeCommandType.CommandType_AdjustVents;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(chars, 1, "axAirConditioning", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeCommandType.CommandType_MaxAirConditioning;
                break;
            case 'R':
                if (String.Compare(chars, 1, "ecirculateO", 0, 11, false) == 0)
                  {
                    switch (chars[12])
                      {
                        case 'f':
                            if ((String.Compare(chars, 13, "f", 0, 1, false) == 0) && (chars.Length == 14))
                                return TypeCommandType.CommandType_RecirculateOff;
                            break;
                        case 'n':
                            if (chars.Length == 13)
                                return TypeCommandType.CommandType_RecirculateOn;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'e':
                        if (String.Compare(chars, 2, "tClimateControlTo", 0, 17, false) == 0)
                          {
                            switch (chars[19])
                              {
                                case 'A':
                                    if ((String.Compare(chars, 20, "uto", 0, 3, false) == 0) && (chars.Length == 23))
                                        return TypeCommandType.CommandType_SetClimateControlToAuto;
                                    break;
                                case 'M':
                                    if ((String.Compare(chars, 20, "anual", 0, 5, false) == 0) && (chars.Length == 25))
                                        return TypeCommandType.CommandType_SetClimateControlToManual;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'h':
                        if ((String.Compare(chars, 2, "owClimateControlScreen", 0, 22, false) == 0) && (chars.Length == 24))
                            return TypeCommandType.CommandType_ShowClimateControlScreen;
                        break;
                    case 'y':
                        if ((String.Compare(chars, 2, "ncTemperatureZones", 0, 18, false) == 0) && (chars.Length == 20))
                            return TypeCommandType.CommandType_SyncTemperatureZones;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if (String.Compare(chars, 1, "urn", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'A':
                            if (String.Compare(chars, 5, "irConditioningO", 0, 15, false) == 0)
                              {
                                switch (chars[20])
                                  {
                                    case 'f':
                                        if ((String.Compare(chars, 21, "f", 0, 1, false) == 0) && (chars.Length == 22))
                                            return TypeCommandType.CommandType_TurnAirConditioningOff;
                                        break;
                                    case 'n':
                                        if (chars.Length == 21)
                                            return TypeCommandType.CommandType_TurnAirConditioningOn;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'H':
                            if (String.Compare(chars, 5, "eatingO", 0, 7, false) == 0)
                              {
                                switch (chars[12])
                                  {
                                    case 'f':
                                        if ((String.Compare(chars, 13, "f", 0, 1, false) == 0) && (chars.Length == 14))
                                            return TypeCommandType.CommandType_TurnHeatingOff;
                                        break;
                                    case 'n':
                                        if (chars.Length == 13)
                                            return TypeCommandType.CommandType_TurnHeatingOn;
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
        throw new Exception("The value for field `CommandType' is not one of the legal values.");
      }

    public static string  stringFromCommandType(TypeCommandType the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandType.CommandType_TurnAirConditioningOn:
                return "TurnAirConditioningOn";
            case TypeCommandType.CommandType_TurnAirConditioningOff:
                return "TurnAirConditioningOff";
            case TypeCommandType.CommandType_MaxAirConditioning:
                return "MaxAirConditioning";
            case TypeCommandType.CommandType_TurnHeatingOn:
                return "TurnHeatingOn";
            case TypeCommandType.CommandType_TurnHeatingOff:
                return "TurnHeatingOff";
            case TypeCommandType.CommandType_AdjustTemperature:
                return "AdjustTemperature";
            case TypeCommandType.CommandType_RecirculateOn:
                return "RecirculateOn";
            case TypeCommandType.CommandType_RecirculateOff:
                return "RecirculateOff";
            case TypeCommandType.CommandType_AdjustVents:
                return "AdjustVents";
            case TypeCommandType.CommandType_AdjustFan:
                return "AdjustFan";
            case TypeCommandType.CommandType_SyncTemperatureZones:
                return "SyncTemperatureZones";
            case TypeCommandType.CommandType_SetClimateControlToAuto:
                return "SetClimateControlToAuto";
            case TypeCommandType.CommandType_SetClimateControlToManual:
                return "SetClimateControlToManual";
            case TypeCommandType.CommandType_ShowClimateControlScreen:
                return "ShowClimateControlScreen";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeFanSpeed
      {
        FanSpeed_Off,
        FanSpeed_Lowest,
        FanSpeed_Lower,
        FanSpeed_Low,
        FanSpeed_Medium,
        FanSpeed_High,
        FanSpeed_Higher,
        FanSpeed_Highest,
        FanSpeed_On,
        FanSpeed_Auto,
        FanSpeed_NoChange,
        FanSpeed_SetTo
      };

    public static TypeFanSpeed  stringToFanSpeed(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "uto", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeFanSpeed.FanSpeed_Auto;
                break;
            case 'H':
                if (String.Compare(chars, 1, "igh", 0, 3, false) == 0)
                  {
                    if (chars.Length == 4)
                      {
                        return TypeFanSpeed.FanSpeed_High;
                      }
                    switch (chars[4])
                      {
                        case 'e':
                            switch (chars[5])
                              {
                                case 'r':
                                    if (chars.Length == 6)
                                        return TypeFanSpeed.FanSpeed_Higher;
                                    break;
                                case 's':
                                    if ((String.Compare(chars, 6, "t", 0, 1, false) == 0) && (chars.Length == 7))
                                        return TypeFanSpeed.FanSpeed_Highest;
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
                if (String.Compare(chars, 1, "ow", 0, 2, false) == 0)
                  {
                    if (chars.Length == 3)
                      {
                        return TypeFanSpeed.FanSpeed_Low;
                      }
                    switch (chars[3])
                      {
                        case 'e':
                            switch (chars[4])
                              {
                                case 'r':
                                    if (chars.Length == 5)
                                        return TypeFanSpeed.FanSpeed_Lower;
                                    break;
                                case 's':
                                    if ((String.Compare(chars, 5, "t", 0, 1, false) == 0) && (chars.Length == 6))
                                        return TypeFanSpeed.FanSpeed_Lowest;
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
            case 'M':
                if ((String.Compare(chars, 1, "edium", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeFanSpeed.FanSpeed_Medium;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "oChange", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeFanSpeed.FanSpeed_NoChange;
                break;
            case 'O':
                switch (chars[1])
                  {
                    case 'f':
                        if ((String.Compare(chars, 2, "f", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeFanSpeed.FanSpeed_Off;
                        break;
                    case 'n':
                        if (chars.Length == 2)
                            return TypeFanSpeed.FanSpeed_On;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "etTo", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeFanSpeed.FanSpeed_SetTo;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `FanSpeed' is not one of the legal values.");
      }

    public static string  stringFromFanSpeed(TypeFanSpeed the_enum)
      {
        switch (the_enum)
          {
            case TypeFanSpeed.FanSpeed_Off:
                return "Off";
            case TypeFanSpeed.FanSpeed_Lowest:
                return "Lowest";
            case TypeFanSpeed.FanSpeed_Lower:
                return "Lower";
            case TypeFanSpeed.FanSpeed_Low:
                return "Low";
            case TypeFanSpeed.FanSpeed_Medium:
                return "Medium";
            case TypeFanSpeed.FanSpeed_High:
                return "High";
            case TypeFanSpeed.FanSpeed_Higher:
                return "Higher";
            case TypeFanSpeed.FanSpeed_Highest:
                return "Highest";
            case TypeFanSpeed.FanSpeed_On:
                return "On";
            case TypeFanSpeed.FanSpeed_Auto:
                return "Auto";
            case TypeFanSpeed.FanSpeed_NoChange:
                return "NoChange";
            case TypeFanSpeed.FanSpeed_SetTo:
                return "SetTo";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeVentsJSON : JSONBase
      {
        public enum TypeVentAction
          {
            VentAction_Open,
            VentAction_Close,
            VentAction_SetTo,
            VentAction_None
          };

        public static TypeVentAction  stringToVentAction(string chars)
          {
            switch (chars[0])
              {
                case 'C':
                    if ((String.Compare(chars, 1, "lose", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeVentAction.VentAction_Close;
                    break;
                case 'N':
                    if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeVentAction.VentAction_None;
                    break;
                case 'O':
                    if ((String.Compare(chars, 1, "pen", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeVentAction.VentAction_Open;
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "etTo", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeVentAction.VentAction_SetTo;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `VentAction' is not one of the legal values.");
          }

        public static string  stringFromVentAction(TypeVentAction the_enum)
          {
            switch (the_enum)
              {
                case TypeVentAction.VentAction_Open:
                    return "Open";
                case TypeVentAction.VentAction_Close:
                    return "Close";
                case TypeVentAction.VentAction_SetTo:
                    return "SetTo";
                case TypeVentAction.VentAction_None:
                    return "None";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeVentSelection
          {
            VentSelection_DriverDashboardVent,
            VentSelection_PassengerDashboardVent,
            VentSelection_DriverFootwellVent,
            VentSelection_PassengerFootwellVent,
            VentSelection_DriverBothVents,
            VentSelection_PassengerBothVents,
            VentSelection_BothFootwellVents,
            VentSelection_BothDashboardVents,
            VentSelection_AllVents
          };

        public static TypeVentSelection  stringToVentSelection(string chars)
          {
            switch (chars[0])
              {
                case 'A':
                    if ((String.Compare(chars, 1, "llVents", 0, 7, false) == 0) && (chars.Length == 8))
                        return TypeVentSelection.VentSelection_AllVents;
                    break;
                case 'B':
                    if (String.Compare(chars, 1, "oth", 0, 3, false) == 0)
                      {
                        switch (chars[4])
                          {
                            case 'D':
                                if ((String.Compare(chars, 5, "ashboardVents", 0, 13, false) == 0) && (chars.Length == 18))
                                    return TypeVentSelection.VentSelection_BothDashboardVents;
                                break;
                            case 'F':
                                if ((String.Compare(chars, 5, "ootwellVents", 0, 12, false) == 0) && (chars.Length == 17))
                                    return TypeVentSelection.VentSelection_BothFootwellVents;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    if (String.Compare(chars, 1, "river", 0, 5, false) == 0)
                      {
                        switch (chars[6])
                          {
                            case 'B':
                                if ((String.Compare(chars, 7, "othVents", 0, 8, false) == 0) && (chars.Length == 15))
                                    return TypeVentSelection.VentSelection_DriverBothVents;
                                break;
                            case 'D':
                                if ((String.Compare(chars, 7, "ashboardVent", 0, 12, false) == 0) && (chars.Length == 19))
                                    return TypeVentSelection.VentSelection_DriverDashboardVent;
                                break;
                            case 'F':
                                if ((String.Compare(chars, 7, "ootwellVent", 0, 11, false) == 0) && (chars.Length == 18))
                                    return TypeVentSelection.VentSelection_DriverFootwellVent;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if (String.Compare(chars, 1, "assenger", 0, 8, false) == 0)
                      {
                        switch (chars[9])
                          {
                            case 'B':
                                if ((String.Compare(chars, 10, "othVents", 0, 8, false) == 0) && (chars.Length == 18))
                                    return TypeVentSelection.VentSelection_PassengerBothVents;
                                break;
                            case 'D':
                                if ((String.Compare(chars, 10, "ashboardVent", 0, 12, false) == 0) && (chars.Length == 22))
                                    return TypeVentSelection.VentSelection_PassengerDashboardVent;
                                break;
                            case 'F':
                                if ((String.Compare(chars, 10, "ootwellVent", 0, 11, false) == 0) && (chars.Length == 21))
                                    return TypeVentSelection.VentSelection_PassengerFootwellVent;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `VentSelection' is not one of the legal values.");
          }

        public static string  stringFromVentSelection(TypeVentSelection the_enum)
          {
            switch (the_enum)
              {
                case TypeVentSelection.VentSelection_DriverDashboardVent:
                    return "DriverDashboardVent";
                case TypeVentSelection.VentSelection_PassengerDashboardVent:
                    return "PassengerDashboardVent";
                case TypeVentSelection.VentSelection_DriverFootwellVent:
                    return "DriverFootwellVent";
                case TypeVentSelection.VentSelection_PassengerFootwellVent:
                    return "PassengerFootwellVent";
                case TypeVentSelection.VentSelection_DriverBothVents:
                    return "DriverBothVents";
                case TypeVentSelection.VentSelection_PassengerBothVents:
                    return "PassengerBothVents";
                case TypeVentSelection.VentSelection_BothFootwellVents:
                    return "BothFootwellVents";
                case TypeVentSelection.VentSelection_BothDashboardVents:
                    return "BothDashboardVents";
                case TypeVentSelection.VentSelection_AllVents:
                    return "AllVents";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeExtendedVentSelectionKnownValues
          {
            ExtendedVentSelection_DriverDashboardVent,
            ExtendedVentSelection_PassengerDashboardVent,
            ExtendedVentSelection_DriverFootwellVent,
            ExtendedVentSelection_PassengerFootwellVent,
            ExtendedVentSelection_DriverBothVents,
            ExtendedVentSelection_PassengerBothVents,
            ExtendedVentSelection_BothFootwellVents,
            ExtendedVentSelection_BothDashboardVents,
            ExtendedVentSelection_AllVents,
            ExtendedVentSelection_Windshield,
            ExtendedVentSelection_DashboardAndWindshield,
            ExtendedVentSelection_FootwellAndDashboard,
            ExtendedVentSelection_FootwellAndWindshield,
            ExtendedVentSelection__none
          };
        public struct TypeExtendedVentSelection
          {
            public bool in_known_list;
            public string string_value;
            public TypeExtendedVentSelectionKnownValues list_value;
          };

        public static TypeExtendedVentSelectionKnownValues  stringToExtendedVentSelection(string chars)
          {
            switch (chars[0])
              {
                case 'A':
                    if ((String.Compare(chars, 1, "llVents", 0, 7, false) == 0) && (chars.Length == 8))
                        return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_AllVents;
                    break;
                case 'B':
                    if (String.Compare(chars, 1, "oth", 0, 3, false) == 0)
                      {
                        switch (chars[4])
                          {
                            case 'D':
                                if ((String.Compare(chars, 5, "ashboardVents", 0, 13, false) == 0) && (chars.Length == 18))
                                    return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_BothDashboardVents;
                                break;
                            case 'F':
                                if ((String.Compare(chars, 5, "ootwellVents", 0, 12, false) == 0) && (chars.Length == 17))
                                    return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_BothFootwellVents;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    switch (chars[1])
                      {
                        case 'a':
                            if ((String.Compare(chars, 2, "shboardAndWindshield", 0, 20, false) == 0) && (chars.Length == 22))
                                return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DashboardAndWindshield;
                            break;
                        case 'r':
                            if (String.Compare(chars, 2, "iver", 0, 4, false) == 0)
                              {
                                switch (chars[6])
                                  {
                                    case 'B':
                                        if ((String.Compare(chars, 7, "othVents", 0, 8, false) == 0) && (chars.Length == 15))
                                            return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverBothVents;
                                        break;
                                    case 'D':
                                        if ((String.Compare(chars, 7, "ashboardVent", 0, 12, false) == 0) && (chars.Length == 19))
                                            return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverDashboardVent;
                                        break;
                                    case 'F':
                                        if ((String.Compare(chars, 7, "ootwellVent", 0, 11, false) == 0) && (chars.Length == 18))
                                            return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverFootwellVent;
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
                case 'F':
                    if (String.Compare(chars, 1, "ootwellAnd", 0, 10, false) == 0)
                      {
                        switch (chars[11])
                          {
                            case 'D':
                                if ((String.Compare(chars, 12, "ashboard", 0, 8, false) == 0) && (chars.Length == 20))
                                    return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_FootwellAndDashboard;
                                break;
                            case 'W':
                                if ((String.Compare(chars, 12, "indshield", 0, 9, false) == 0) && (chars.Length == 21))
                                    return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_FootwellAndWindshield;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if (String.Compare(chars, 1, "assenger", 0, 8, false) == 0)
                      {
                        switch (chars[9])
                          {
                            case 'B':
                                if ((String.Compare(chars, 10, "othVents", 0, 8, false) == 0) && (chars.Length == 18))
                                    return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerBothVents;
                                break;
                            case 'D':
                                if ((String.Compare(chars, 10, "ashboardVent", 0, 12, false) == 0) && (chars.Length == 22))
                                    return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerDashboardVent;
                                break;
                            case 'F':
                                if ((String.Compare(chars, 10, "ootwellVent", 0, 11, false) == 0) && (chars.Length == 21))
                                    return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerFootwellVent;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if ((String.Compare(chars, 1, "indshield", 0, 9, false) == 0) && (chars.Length == 10))
                        return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_Windshield;
                    break;
                default:
                    break;
              }
            return TypeExtendedVentSelectionKnownValues.ExtendedVentSelection__none;
          }

        public static string  stringFromExtendedVentSelection(TypeExtendedVentSelectionKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverDashboardVent:
                    return "DriverDashboardVent";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerDashboardVent:
                    return "PassengerDashboardVent";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverFootwellVent:
                    return "DriverFootwellVent";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerFootwellVent:
                    return "PassengerFootwellVent";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverBothVents:
                    return "DriverBothVents";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerBothVents:
                    return "PassengerBothVents";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_BothFootwellVents:
                    return "BothFootwellVents";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_BothDashboardVents:
                    return "BothDashboardVents";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_AllVents:
                    return "AllVents";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_Windshield:
                    return "Windshield";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DashboardAndWindshield:
                    return "DashboardAndWindshield";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_FootwellAndDashboard:
                    return "FootwellAndDashboard";
                case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_FootwellAndWindshield:
                    return "FootwellAndWindshield";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasVentAction;
        private TypeVentAction storeVentAction;
        private bool flagHasVentSelection;
        private TypeVentSelection storeVentSelection;
        private bool flagHasExtendedVentSelection;
        private TypeExtendedVentSelection storeExtendedVentSelection;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONVentAction(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field VentAction of TypeVentsJSON is not a string.");
            TypeVentAction the_enum;
            switch (json_string.getData()[0])
              {
                case 'C':
                    if ((String.Compare(json_string.getData(), 1, "lose", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeVentAction.VentAction_Close;
                            goto enum_is_done;
                          }
                    break;
                case 'N':
                    if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeVentAction.VentAction_None;
                            goto enum_is_done;
                          }
                    break;
                case 'O':
                    if ((String.Compare(json_string.getData(), 1, "pen", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeVentAction.VentAction_Open;
                            goto enum_is_done;
                          }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "etTo", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeVentAction.VentAction_SetTo;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field VentAction of TypeVentsJSON is not one of the legal strings.");
          enum_is_done:;
            setVentAction(the_enum);
          }


        private void  fromJSONVentSelection(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field VentSelection of TypeVentsJSON is not a string.");
            TypeVentSelection the_enum;
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "llVents", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeVentSelection.VentSelection_AllVents;
                            goto enum_is_done;
                          }
                    break;
                case 'B':
                    if (String.Compare(json_string.getData(), 1, "oth", 0, 3, false) == 0)
                      {
                        switch (json_string.getData()[4])
                          {
                            case 'D':
                                if ((String.Compare(json_string.getData(), 5, "ashboardVents", 0, 13, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_enum = TypeVentSelection.VentSelection_BothDashboardVents;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'F':
                                if ((String.Compare(json_string.getData(), 5, "ootwellVents", 0, 12, false) == 0) && (json_string.getData().Length == 17))
                                      {
                                        the_enum = TypeVentSelection.VentSelection_BothFootwellVents;
                                        goto enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    if (String.Compare(json_string.getData(), 1, "river", 0, 5, false) == 0)
                      {
                        switch (json_string.getData()[6])
                          {
                            case 'B':
                                if ((String.Compare(json_string.getData(), 7, "othVents", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_enum = TypeVentSelection.VentSelection_DriverBothVents;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'D':
                                if ((String.Compare(json_string.getData(), 7, "ashboardVent", 0, 12, false) == 0) && (json_string.getData().Length == 19))
                                      {
                                        the_enum = TypeVentSelection.VentSelection_DriverDashboardVent;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'F':
                                if ((String.Compare(json_string.getData(), 7, "ootwellVent", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_enum = TypeVentSelection.VentSelection_DriverFootwellVent;
                                        goto enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if (String.Compare(json_string.getData(), 1, "assenger", 0, 8, false) == 0)
                      {
                        switch (json_string.getData()[9])
                          {
                            case 'B':
                                if ((String.Compare(json_string.getData(), 10, "othVents", 0, 8, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_enum = TypeVentSelection.VentSelection_PassengerBothVents;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'D':
                                if ((String.Compare(json_string.getData(), 10, "ashboardVent", 0, 12, false) == 0) && (json_string.getData().Length == 22))
                                      {
                                        the_enum = TypeVentSelection.VentSelection_PassengerDashboardVent;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'F':
                                if ((String.Compare(json_string.getData(), 10, "ootwellVent", 0, 11, false) == 0) && (json_string.getData().Length == 21))
                                      {
                                        the_enum = TypeVentSelection.VentSelection_PassengerFootwellVent;
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
            throw new Exception("The value for field VentSelection of TypeVentsJSON is not one of the legal strings.");
          enum_is_done:;
            setVentSelection(the_enum);
          }


        private void  fromJSONExtendedVentSelection(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ExtendedVentSelection of TypeVentsJSON is not a string.");
            TypeExtendedVentSelection the_open_enum = new TypeExtendedVentSelection();
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "llVents", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_AllVents;
                            goto open_enum_is_done;
                          }
                    break;
                case 'B':
                    if (String.Compare(json_string.getData(), 1, "oth", 0, 3, false) == 0)
                      {
                        switch (json_string.getData()[4])
                          {
                            case 'D':
                                if ((String.Compare(json_string.getData(), 5, "ashboardVents", 0, 13, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_BothDashboardVents;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'F':
                                if ((String.Compare(json_string.getData(), 5, "ootwellVents", 0, 12, false) == 0) && (json_string.getData().Length == 17))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_BothFootwellVents;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    switch (json_string.getData()[1])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 2, "shboardAndWindshield", 0, 20, false) == 0) && (json_string.getData().Length == 22))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DashboardAndWindshield;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'r':
                            if (String.Compare(json_string.getData(), 2, "iver", 0, 4, false) == 0)
                              {
                                switch (json_string.getData()[6])
                                  {
                                    case 'B':
                                        if ((String.Compare(json_string.getData(), 7, "othVents", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverBothVents;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'D':
                                        if ((String.Compare(json_string.getData(), 7, "ashboardVent", 0, 12, false) == 0) && (json_string.getData().Length == 19))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverDashboardVent;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'F':
                                        if ((String.Compare(json_string.getData(), 7, "ootwellVent", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverFootwellVent;
                                                goto open_enum_is_done;
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
                case 'F':
                    if (String.Compare(json_string.getData(), 1, "ootwellAnd", 0, 10, false) == 0)
                      {
                        switch (json_string.getData()[11])
                          {
                            case 'D':
                                if ((String.Compare(json_string.getData(), 12, "ashboard", 0, 8, false) == 0) && (json_string.getData().Length == 20))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_FootwellAndDashboard;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'W':
                                if ((String.Compare(json_string.getData(), 12, "indshield", 0, 9, false) == 0) && (json_string.getData().Length == 21))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_FootwellAndWindshield;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if (String.Compare(json_string.getData(), 1, "assenger", 0, 8, false) == 0)
                      {
                        switch (json_string.getData()[9])
                          {
                            case 'B':
                                if ((String.Compare(json_string.getData(), 10, "othVents", 0, 8, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerBothVents;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'D':
                                if ((String.Compare(json_string.getData(), 10, "ashboardVent", 0, 12, false) == 0) && (json_string.getData().Length == 22))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerDashboardVent;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'F':
                                if ((String.Compare(json_string.getData(), 10, "ootwellVent", 0, 11, false) == 0) && (json_string.getData().Length == 21))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerFootwellVent;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if ((String.Compare(json_string.getData(), 1, "indshield", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_Windshield;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setExtendedVentSelection(the_open_enum);
          }


        public TypeVentsJSON()
          {
            flagHasVentAction = false;
            flagHasVentSelection = false;
            flagHasExtendedVentSelection = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasVentAction()
          {
            return flagHasVentAction;
          }

        public TypeVentAction  getVentAction()
          {
            Debug.Assert(flagHasVentAction);
            return storeVentAction;
          }

        public string  getVentActionAsString()
          {
            return stringFromVentAction(getVentAction());
          }

        public bool  hasVentSelection()
          {
            return flagHasVentSelection;
          }

        public TypeVentSelection  getVentSelection()
          {
            Debug.Assert(flagHasVentSelection);
            return storeVentSelection;
          }

        public string  getVentSelectionAsString()
          {
            return stringFromVentSelection(getVentSelection());
          }

        public bool  hasExtendedVentSelection()
          {
            return flagHasExtendedVentSelection;
          }

        public TypeExtendedVentSelection  getExtendedVentSelection()
          {
            Debug.Assert(flagHasExtendedVentSelection);
            return storeExtendedVentSelection;
          }

        public string  getExtendedVentSelectionAsString()
          {
            TypeExtendedVentSelection result = getExtendedVentSelection();
            if (result.in_known_list)
                return stringFromExtendedVentSelection(result.list_value);
            else
                return result.string_value;
          }


        public virtual int extraTypeVentsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeVentsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeVentsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeVentsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setVentAction(TypeVentAction new_value)
          {
            flagHasVentAction = true;
            storeVentAction = new_value;
          }
        public void setVentAction(string chars)
          {
            setVentAction(stringToVentAction(chars));
          }
        public void unsetVentAction()
          {
            flagHasVentAction = false;
          }
        public void setVentSelection(TypeVentSelection new_value)
          {
            flagHasVentSelection = true;
            storeVentSelection = new_value;
          }
        public void setVentSelection(string chars)
          {
            setVentSelection(stringToVentSelection(chars));
          }
        public void unsetVentSelection()
          {
            flagHasVentSelection = false;
          }
        public void setExtendedVentSelection(TypeExtendedVentSelection new_value)
          {
            flagHasExtendedVentSelection = true;
            storeExtendedVentSelection = new_value;
          }
        public void setExtendedVentSelection(string chars)
          {
            TypeExtendedVentSelectionKnownValues known = stringToExtendedVentSelection(chars);
            TypeExtendedVentSelection new_value = new TypeExtendedVentSelection();
            if (known == TypeExtendedVentSelectionKnownValues.ExtendedVentSelection__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setExtendedVentSelection(new_value);
          }
        public void setExtendedVentSelection(TypeExtendedVentSelectionKnownValues new_value)
          {
            TypeExtendedVentSelection new_full_value = new TypeExtendedVentSelection();
            Debug.Assert(new_value != TypeExtendedVentSelectionKnownValues.ExtendedVentSelection__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setExtendedVentSelection(new_full_value);
          }
        public void unsetExtendedVentSelection()
          {
            flagHasExtendedVentSelection = false;
          }

        public virtual void extraTypeVentsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeVentsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeVentsLookup(key);
            if (old_field == null)
              {
                extraTypeVentsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasVentAction);
            if (flagHasVentAction)
              {
                handler.start_pair("VentAction");
                switch (storeVentAction)
                  {
                    case TypeVentAction.VentAction_Open:
                        handler.string_value("Open");
                        break;
                    case TypeVentAction.VentAction_Close:
                        handler.string_value("Close");
                        break;
                    case TypeVentAction.VentAction_SetTo:
                        handler.string_value("SetTo");
                        break;
                    case TypeVentAction.VentAction_None:
                        handler.string_value("None");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            Debug.Assert(partial_allowed || flagHasVentSelection);
            if (flagHasVentSelection)
              {
                handler.start_pair("VentSelection");
                switch (storeVentSelection)
                  {
                    case TypeVentSelection.VentSelection_DriverDashboardVent:
                        handler.string_value("DriverDashboardVent");
                        break;
                    case TypeVentSelection.VentSelection_PassengerDashboardVent:
                        handler.string_value("PassengerDashboardVent");
                        break;
                    case TypeVentSelection.VentSelection_DriverFootwellVent:
                        handler.string_value("DriverFootwellVent");
                        break;
                    case TypeVentSelection.VentSelection_PassengerFootwellVent:
                        handler.string_value("PassengerFootwellVent");
                        break;
                    case TypeVentSelection.VentSelection_DriverBothVents:
                        handler.string_value("DriverBothVents");
                        break;
                    case TypeVentSelection.VentSelection_PassengerBothVents:
                        handler.string_value("PassengerBothVents");
                        break;
                    case TypeVentSelection.VentSelection_BothFootwellVents:
                        handler.string_value("BothFootwellVents");
                        break;
                    case TypeVentSelection.VentSelection_BothDashboardVents:
                        handler.string_value("BothDashboardVents");
                        break;
                    case TypeVentSelection.VentSelection_AllVents:
                        handler.string_value("AllVents");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            if (flagHasExtendedVentSelection)
              {
                handler.start_pair("ExtendedVentSelection");
                if (storeExtendedVentSelection.in_known_list)
                  {
                    switch (storeExtendedVentSelection.list_value)
                      {
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverDashboardVent:
                            handler.string_value("DriverDashboardVent");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerDashboardVent:
                            handler.string_value("PassengerDashboardVent");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverFootwellVent:
                            handler.string_value("DriverFootwellVent");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerFootwellVent:
                            handler.string_value("PassengerFootwellVent");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DriverBothVents:
                            handler.string_value("DriverBothVents");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_PassengerBothVents:
                            handler.string_value("PassengerBothVents");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_BothFootwellVents:
                            handler.string_value("BothFootwellVents");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_BothDashboardVents:
                            handler.string_value("BothDashboardVents");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_AllVents:
                            handler.string_value("AllVents");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_Windshield:
                            handler.string_value("Windshield");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_DashboardAndWindshield:
                            handler.string_value("DashboardAndWindshield");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_FootwellAndDashboard:
                            handler.string_value("FootwellAndDashboard");
                            break;
                        case TypeExtendedVentSelectionKnownValues.ExtendedVentSelection_FootwellAndWindshield:
                            handler.string_value("FootwellAndWindshield");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeExtendedVentSelection.string_value);
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
            if (!(hasVentAction()))
              {
                return "When parsing the object for %what%, the \"VentAction\" field was missing.";
              }
            if (!(hasVentSelection()))
              {
                return "When parsing the object for %what%, the \"VentSelection\" field was missing.";
              }
            return null;
          }

        public static TypeVentsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeVentsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVents", ignore_extras);
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
        public static TypeVentsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeVentsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeVentsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVents", ignore_extras);
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
        public static TypeVentsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeVentsJSON from_text(string text, bool ignore_extras)
          {
            TypeVentsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVents", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeVentsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeVentsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeVentsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVents", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorVentAction : JSONStringGenerator
              {
                protected FieldGeneratorVentAction(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorVentAction()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToVentAction(result));
                  }
                protected abstract void handle_result(TypeVentAction result);
              };
        private class FieldHoldingGeneratorVentAction : FieldGeneratorVentAction
      {
        protected override void handle_result(TypeVentAction result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorVentAction(String what)
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
        public TypeVentAction value;
      };
        private class FieldHoldingArrayGeneratorVentAction : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorVentAction
          {
            private FieldHoldingArrayGeneratorVentAction top;

            protected override void handle_result(TypeVentAction result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorVentAction init_top)
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
        protected virtual void handle_result(List<TypeVentAction> result)
          {
          }

        public FieldHoldingArrayGeneratorVentAction(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeVentAction>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorVentAction()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeVentAction>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeVentAction> value;
      };
            private FieldHoldingGeneratorVentAction fieldGeneratorVentAction;
        private abstract class FieldGeneratorVentSelection : JSONStringGenerator
              {
                protected FieldGeneratorVentSelection(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorVentSelection()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToVentSelection(result));
                  }
                protected abstract void handle_result(TypeVentSelection result);
              };
        private class FieldHoldingGeneratorVentSelection : FieldGeneratorVentSelection
      {
        protected override void handle_result(TypeVentSelection result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorVentSelection(String what)
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
        public TypeVentSelection value;
      };
        private class FieldHoldingArrayGeneratorVentSelection : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorVentSelection
          {
            private FieldHoldingArrayGeneratorVentSelection top;

            protected override void handle_result(TypeVentSelection result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorVentSelection init_top)
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
        protected virtual void handle_result(List<TypeVentSelection> result)
          {
          }

        public FieldHoldingArrayGeneratorVentSelection(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeVentSelection>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorVentSelection()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeVentSelection>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeVentSelection> value;
      };
            private FieldHoldingGeneratorVentSelection fieldGeneratorVentSelection;
        private abstract class FieldGeneratorExtendedVentSelection : JSONStringGenerator
              {
                protected FieldGeneratorExtendedVentSelection(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorExtendedVentSelection()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeExtendedVentSelectionKnownValues known = stringToExtendedVentSelection(result);
                    TypeExtendedVentSelection new_value = new TypeExtendedVentSelection();
                    if (known == TypeExtendedVentSelectionKnownValues.ExtendedVentSelection__none)
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
                protected abstract void handle_result(TypeExtendedVentSelection result);
              };
        private class FieldHoldingGeneratorExtendedVentSelection : FieldGeneratorExtendedVentSelection
      {
        protected override void handle_result(TypeExtendedVentSelection result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorExtendedVentSelection(String what)
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
        public TypeExtendedVentSelection value;
      };
        private class FieldHoldingArrayGeneratorExtendedVentSelection : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorExtendedVentSelection
          {
            private FieldHoldingArrayGeneratorExtendedVentSelection top;

            protected override void handle_result(TypeExtendedVentSelection result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorExtendedVentSelection init_top)
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
        protected virtual void handle_result(List<TypeExtendedVentSelection> result)
          {
          }

        public FieldHoldingArrayGeneratorExtendedVentSelection(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeExtendedVentSelection>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorExtendedVentSelection()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeExtendedVentSelection>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeExtendedVentSelection> value;
      };
            private FieldHoldingGeneratorExtendedVentSelection fieldGeneratorExtendedVentSelection;
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
                TypeVentsJSON result = new TypeVentsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeVentsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeVentsJSON result)
              {
                if (fieldGeneratorVentAction.have_value)
                  {
                    result.setVentAction(fieldGeneratorVentAction.value);
                    fieldGeneratorVentAction.have_value = false;
                  }
                else if ((!(result.hasVentAction())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"VentAction\" field was missing.");
                  }
                if (fieldGeneratorVentSelection.have_value)
                  {
                    result.setVentSelection(fieldGeneratorVentSelection.value);
                    fieldGeneratorVentSelection.have_value = false;
                  }
                else if ((!(result.hasVentSelection())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"VentSelection\" field was missing.");
                  }
                if (fieldGeneratorExtendedVentSelection.have_value)
                  {
                    result.setExtendedVentSelection(fieldGeneratorExtendedVentSelection.value);
                    fieldGeneratorExtendedVentSelection.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeVentsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'E':
                        if ((String.Compare(field_name, 1, "xtendedVentSelection", 0, 20, false) == 0) && (field_name.Length == 21))
                            return fieldGeneratorExtendedVentSelection;
                        break;
                    case 'V':
                        if (String.Compare(field_name, 1, "ent", 0, 3, false) == 0)
                          {
                            switch (field_name[4])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 5, "ction", 0, 5, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorVentAction;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 5, "election", 0, 8, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorVentSelection;
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
                fieldGeneratorVentAction = new FieldHoldingGeneratorVentAction("field \"VentAction\" of the TypeVents class");
                fieldGeneratorVentSelection = new FieldHoldingGeneratorVentSelection("field \"VentSelection\" of the TypeVents class");
                fieldGeneratorExtendedVentSelection = new FieldHoldingGeneratorExtendedVentSelection("field \"ExtendedVentSelection\" of the TypeVents class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeVents class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorVentAction = new FieldHoldingGeneratorVentAction("field \"VentAction\" of the TypeVents class");
                fieldGeneratorVentSelection = new FieldHoldingGeneratorVentSelection("field \"VentSelection\" of the TypeVents class");
                fieldGeneratorExtendedVentSelection = new FieldHoldingGeneratorExtendedVentSelection("field \"ExtendedVentSelection\" of the TypeVents class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeVents class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorVentAction.reset();
                fieldGeneratorVentSelection.reset();
                fieldGeneratorExtendedVentSelection.reset();
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
            protected override void handle_result(TypeVentsJSON  result)
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
            public TypeVentsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeVentsJSON  result)
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
        protected virtual void handle_result(List<TypeVentsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeVentsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeVentsJSON>();
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
        public List<TypeVentsJSON> value;
      };
      };
    public class TypeTemperatureJSON : JSONBase
      {
        public enum TypeUnit
          {
            Unit_F,
            Unit_C,
            Unit_degrees
          };

        public static TypeUnit  stringToUnit(string chars)
          {
            switch (chars[0])
              {
                case 'C':
                    if (chars.Length == 1)
                        return TypeUnit.Unit_C;
                    break;
                case 'F':
                    if (chars.Length == 1)
                        return TypeUnit.Unit_F;
                    break;
                case 'd':
                    if ((String.Compare(chars, 1, "egrees", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeUnit.Unit_degrees;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Unit' is not one of the legal values.");
          }

        public static string  stringFromUnit(TypeUnit the_enum)
          {
            switch (the_enum)
              {
                case TypeUnit.Unit_F:
                    return "F";
                case TypeUnit.Unit_C:
                    return "C";
                case TypeUnit.Unit_degrees:
                    return "degrees";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeQualitativeTemperatureKnownValues
          {
            QualitativeTemperature_Coldest,
            QualitativeTemperature_Cold,
            QualitativeTemperature_Cool,
            QualitativeTemperature_Medium,
            QualitativeTemperature_Warm,
            QualitativeTemperature_Hot,
            QualitativeTemperature_Hottest,
            QualitativeTemperature__none
          };
        public struct TypeQualitativeTemperature
          {
            public bool in_known_list;
            public string string_value;
            public TypeQualitativeTemperatureKnownValues list_value;
          };

        public static TypeQualitativeTemperatureKnownValues  stringToQualitativeTemperature(string chars)
          {
            switch (chars[0])
              {
                case 'C':
                    if (String.Compare(chars, 1, "o", 0, 1, false) == 0)
                      {
                        switch (chars[2])
                          {
                            case 'l':
                                if (String.Compare(chars, 3, "d", 0, 1, false) == 0)
                                  {
                                    if (chars.Length == 4)
                                      {
                                        return TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Cold;
                                      }
                                    switch (chars[4])
                                      {
                                        case 'e':
                                            if ((String.Compare(chars, 5, "st", 0, 2, false) == 0) && (chars.Length == 7))
                                                return TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Coldest;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'o':
                                if ((String.Compare(chars, 3, "l", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Cool;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if (String.Compare(chars, 1, "ot", 0, 2, false) == 0)
                      {
                        if (chars.Length == 3)
                          {
                            return TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Hot;
                          }
                        switch (chars[3])
                          {
                            case 't':
                                if ((String.Compare(chars, 4, "est", 0, 3, false) == 0) && (chars.Length == 7))
                                    return TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Hottest;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(chars, 1, "edium", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Medium;
                    break;
                case 'W':
                    if ((String.Compare(chars, 1, "arm", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Warm;
                    break;
                default:
                    break;
              }
            return TypeQualitativeTemperatureKnownValues.QualitativeTemperature__none;
          }

        public static string  stringFromQualitativeTemperature(TypeQualitativeTemperatureKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Coldest:
                    return "Coldest";
                case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Cold:
                    return "Cold";
                case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Cool:
                    return "Cool";
                case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Medium:
                    return "Medium";
                case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Warm:
                    return "Warm";
                case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Hot:
                    return "Hot";
                case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Hottest:
                    return "Hottest";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeIncrementalChangeIntentKnownValues
          {
            IncrementalChangeIntent_DecreaseStrongly,
            IncrementalChangeIntent_Decrease,
            IncrementalChangeIntent_DecreaseSlightly,
            IncrementalChangeIntent_IncreaseSlightly,
            IncrementalChangeIntent_Increase,
            IncrementalChangeIntent_IncreaseStrongly,
            IncrementalChangeIntent__none
          };
        public struct TypeIncrementalChangeIntent
          {
            public bool in_known_list;
            public string string_value;
            public TypeIncrementalChangeIntentKnownValues list_value;
          };

        public static TypeIncrementalChangeIntentKnownValues  stringToIncrementalChangeIntent(string chars)
          {
            switch (chars[0])
              {
                case 'D':
                    if (String.Compare(chars, 1, "ecrease", 0, 7, false) == 0)
                      {
                        if (chars.Length == 8)
                          {
                            return TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_Decrease;
                          }
                        switch (chars[8])
                          {
                            case 'S':
                                switch (chars[9])
                                  {
                                    case 'l':
                                        if ((String.Compare(chars, 10, "ightly", 0, 6, false) == 0) && (chars.Length == 16))
                                            return TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_DecreaseSlightly;
                                        break;
                                    case 't':
                                        if ((String.Compare(chars, 10, "rongly", 0, 6, false) == 0) && (chars.Length == 16))
                                            return TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_DecreaseStrongly;
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
                case 'I':
                    if (String.Compare(chars, 1, "ncrease", 0, 7, false) == 0)
                      {
                        if (chars.Length == 8)
                          {
                            return TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_Increase;
                          }
                        switch (chars[8])
                          {
                            case 'S':
                                switch (chars[9])
                                  {
                                    case 'l':
                                        if ((String.Compare(chars, 10, "ightly", 0, 6, false) == 0) && (chars.Length == 16))
                                            return TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_IncreaseSlightly;
                                        break;
                                    case 't':
                                        if ((String.Compare(chars, 10, "rongly", 0, 6, false) == 0) && (chars.Length == 16))
                                            return TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_IncreaseStrongly;
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
                default:
                    break;
              }
            return TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent__none;
          }

        public static string  stringFromIncrementalChangeIntent(TypeIncrementalChangeIntentKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_DecreaseStrongly:
                    return "DecreaseStrongly";
                case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_Decrease:
                    return "Decrease";
                case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_DecreaseSlightly:
                    return "DecreaseSlightly";
                case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_IncreaseSlightly:
                    return "IncreaseSlightly";
                case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_Increase:
                    return "Increase";
                case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_IncreaseStrongly:
                    return "IncreaseStrongly";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeZone
          {
            Zone_Unspecified,
            Zone_Driver,
            Zone_Passenger,
            Zone_BackSeat
          };

        public static TypeZone  stringToZone(string chars)
          {
            switch (chars[0])
              {
                case 'B':
                    if ((String.Compare(chars, 1, "ackSeat", 0, 7, false) == 0) && (chars.Length == 8))
                        return TypeZone.Zone_BackSeat;
                    break;
                case 'D':
                    if ((String.Compare(chars, 1, "river", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeZone.Zone_Driver;
                    break;
                case 'P':
                    if ((String.Compare(chars, 1, "assenger", 0, 8, false) == 0) && (chars.Length == 9))
                        return TypeZone.Zone_Passenger;
                    break;
                case 'U':
                    if ((String.Compare(chars, 1, "nspecified", 0, 10, false) == 0) && (chars.Length == 11))
                        return TypeZone.Zone_Unspecified;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Zone' is not one of the legal values.");
          }

        public static string  stringFromZone(TypeZone the_enum)
          {
            switch (the_enum)
              {
                case TypeZone.Zone_Unspecified:
                    return "Unspecified";
                case TypeZone.Zone_Driver:
                    return "Driver";
                case TypeZone.Zone_Passenger:
                    return "Passenger";
                case TypeZone.Zone_BackSeat:
                    return "BackSeat";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasValue;
        private double storeValue;
        private string textStoreValue;
        private bool flagHasIsRelative;
        private bool storeIsRelative;
        private bool flagHasUnit;
        private TypeUnit storeUnit;
        private bool flagHasAmbiguousValue;
        private double storeAmbiguousValue;
        private string textStoreAmbiguousValue;
        private bool flagHasQualitativeTemperature;
        private TypeQualitativeTemperature storeQualitativeTemperature;
        private bool flagHasIncrementalChangeIntent;
        private TypeIncrementalChangeIntent storeIncrementalChangeIntent;
        private bool flagHasZone;
        private TypeZone storeZone;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Value of TypeTemperatureJSON is not a number.");
                  }
              }
            setValueText(the_rational_text);
          }


        private void  fromJSONIsRelative(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field IsRelative of TypeTemperatureJSON is not true for false.");
                  }
              }
            setIsRelative(the_bool);
          }


        private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Unit of TypeTemperatureJSON is not a string.");
            TypeUnit the_enum;
            switch (json_string.getData()[0])
              {
                case 'C':
                    if (json_string.getData().Length == 1)
                          {
                            the_enum = TypeUnit.Unit_C;
                            goto enum_is_done;
                          }
                    break;
                case 'F':
                    if (json_string.getData().Length == 1)
                          {
                            the_enum = TypeUnit.Unit_F;
                            goto enum_is_done;
                          }
                    break;
                case 'd':
                    if ((String.Compare(json_string.getData(), 1, "egrees", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_enum = TypeUnit.Unit_degrees;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Unit of TypeTemperatureJSON is not one of the legal strings.");
          enum_is_done:;
            setUnit(the_enum);
          }


        private void  fromJSONAmbiguousValue(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field AmbiguousValue of TypeTemperatureJSON is not a number.");
                  }
              }
            setAmbiguousValueText(the_rational_text);
          }


        private void  fromJSONQualitativeTemperature(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field QualitativeTemperature of TypeTemperatureJSON is not a string.");
            TypeQualitativeTemperature the_open_enum = new TypeQualitativeTemperature();
            switch (json_string.getData()[0])
              {
                case 'C':
                    if (String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0)
                      {
                        switch (json_string.getData()[2])
                          {
                            case 'l':
                                if (String.Compare(json_string.getData(), 3, "d", 0, 1, false) == 0)
                                  {
                                    if (json_string.getData().Length == 4)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Cold;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[4])
                                      {
                                        case 'e':
                                            if ((String.Compare(json_string.getData(), 5, "st", 0, 2, false) == 0) && (json_string.getData().Length == 7))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Coldest;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'o':
                                if ((String.Compare(json_string.getData(), 3, "l", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Cool;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if (String.Compare(json_string.getData(), 1, "ot", 0, 2, false) == 0)
                      {
                        if (json_string.getData().Length == 3)
                          {
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Hot;
                                goto open_enum_is_done;
                              }
                          }
                        switch (json_string.getData()[3])
                          {
                            case 't':
                                if ((String.Compare(json_string.getData(), 4, "est", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Hottest;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(json_string.getData(), 1, "edium", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Medium;
                            goto open_enum_is_done;
                          }
                    break;
                case 'W':
                    if ((String.Compare(json_string.getData(), 1, "arm", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Warm;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setQualitativeTemperature(the_open_enum);
          }


        private void  fromJSONIncrementalChangeIntent(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field IncrementalChangeIntent of TypeTemperatureJSON is not a string.");
            TypeIncrementalChangeIntent the_open_enum = new TypeIncrementalChangeIntent();
            switch (json_string.getData()[0])
              {
                case 'D':
                    if (String.Compare(json_string.getData(), 1, "ecrease", 0, 7, false) == 0)
                      {
                        if (json_string.getData().Length == 8)
                          {
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_Decrease;
                                goto open_enum_is_done;
                              }
                          }
                        switch (json_string.getData()[8])
                          {
                            case 'S':
                                switch (json_string.getData()[9])
                                  {
                                    case 'l':
                                        if ((String.Compare(json_string.getData(), 10, "ightly", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_DecreaseSlightly;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 't':
                                        if ((String.Compare(json_string.getData(), 10, "rongly", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_DecreaseStrongly;
                                                goto open_enum_is_done;
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
                case 'I':
                    if (String.Compare(json_string.getData(), 1, "ncrease", 0, 7, false) == 0)
                      {
                        if (json_string.getData().Length == 8)
                          {
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_Increase;
                                goto open_enum_is_done;
                              }
                          }
                        switch (json_string.getData()[8])
                          {
                            case 'S':
                                switch (json_string.getData()[9])
                                  {
                                    case 'l':
                                        if ((String.Compare(json_string.getData(), 10, "ightly", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_IncreaseSlightly;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 't':
                                        if ((String.Compare(json_string.getData(), 10, "rongly", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_IncreaseStrongly;
                                                goto open_enum_is_done;
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
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setIncrementalChangeIntent(the_open_enum);
          }


        private void  fromJSONZone(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Zone of TypeTemperatureJSON is not a string.");
            TypeZone the_enum;
            switch (json_string.getData()[0])
              {
                case 'B':
                    if ((String.Compare(json_string.getData(), 1, "ackSeat", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeZone.Zone_BackSeat;
                            goto enum_is_done;
                          }
                    break;
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "river", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypeZone.Zone_Driver;
                            goto enum_is_done;
                          }
                    break;
                case 'P':
                    if ((String.Compare(json_string.getData(), 1, "assenger", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_enum = TypeZone.Zone_Passenger;
                            goto enum_is_done;
                          }
                    break;
                case 'U':
                    if ((String.Compare(json_string.getData(), 1, "nspecified", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                          {
                            the_enum = TypeZone.Zone_Unspecified;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Zone of TypeTemperatureJSON is not one of the legal strings.");
          enum_is_done:;
            setZone(the_enum);
          }


        public TypeTemperatureJSON()
          {
            flagHasValue = false;
            flagHasIsRelative = false;
            flagHasUnit = false;
            flagHasAmbiguousValue = false;
            flagHasQualitativeTemperature = false;
            flagHasIncrementalChangeIntent = false;
            flagHasZone = false;
            storeUnit = TypeUnit.Unit_degrees;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public double  getValue()
          {
            Debug.Assert(flagHasValue);
            if (textStoreValue != "")
              {
                return Double.Parse(textStoreValue);
              }
            return storeValue;
          }

        public string  getValueAsText()
          {
            Debug.Assert(flagHasValue);
            if (textStoreValue == "")
              {
                return Convert.ToString(storeValue);
              }
            else
              {
                return (textStoreValue);
              }
          }

        public bool  hasIsRelative()
          {
            return flagHasIsRelative;
          }

        public bool  getIsRelative()
          {
            Debug.Assert(flagHasIsRelative);
            return storeIsRelative;
          }

        public bool  hasUnit()
          {
            return flagHasUnit;
          }

        public TypeUnit  getUnit()
          {
            return storeUnit;
          }

        public string  getUnitAsString()
          {
            return stringFromUnit(getUnit());
          }

        public bool  hasAmbiguousValue()
          {
            return flagHasAmbiguousValue;
          }

        public double  getAmbiguousValue()
          {
            Debug.Assert(flagHasAmbiguousValue);
            if (textStoreAmbiguousValue != "")
              {
                return Double.Parse(textStoreAmbiguousValue);
              }
            return storeAmbiguousValue;
          }

        public string  getAmbiguousValueAsText()
          {
            Debug.Assert(flagHasAmbiguousValue);
            if (textStoreAmbiguousValue == "")
              {
                return Convert.ToString(storeAmbiguousValue);
              }
            else
              {
                return (textStoreAmbiguousValue);
              }
          }

        public bool  hasQualitativeTemperature()
          {
            return flagHasQualitativeTemperature;
          }

        public TypeQualitativeTemperature  getQualitativeTemperature()
          {
            Debug.Assert(flagHasQualitativeTemperature);
            return storeQualitativeTemperature;
          }

        public string  getQualitativeTemperatureAsString()
          {
            TypeQualitativeTemperature result = getQualitativeTemperature();
            if (result.in_known_list)
                return stringFromQualitativeTemperature(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasIncrementalChangeIntent()
          {
            return flagHasIncrementalChangeIntent;
          }

        public TypeIncrementalChangeIntent  getIncrementalChangeIntent()
          {
            Debug.Assert(flagHasIncrementalChangeIntent);
            return storeIncrementalChangeIntent;
          }

        public string  getIncrementalChangeIntentAsString()
          {
            TypeIncrementalChangeIntent result = getIncrementalChangeIntent();
            if (result.in_known_list)
                return stringFromIncrementalChangeIntent(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasZone()
          {
            return flagHasZone;
          }

        public TypeZone  getZone()
          {
            Debug.Assert(flagHasZone);
            return storeZone;
          }

        public string  getZoneAsString()
          {
            return stringFromZone(getZone());
          }


        public virtual int extraTypeTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeTemperatureLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(double new_value)
          {
            flagHasValue = true;
            storeValue = new_value;
            textStoreValue = "";
          }
        public void setValueText(string new_value)
          {
            flagHasValue = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Value of TypeTemperatureJSON is not a valid number.");
            textStoreValue = new_value;
          }
        public void unsetValue()
          {
            flagHasValue = false;
          }
        public void setIsRelative(bool new_value)
          {
            flagHasIsRelative = true;
            storeIsRelative = new_value;
          }
        public void unsetIsRelative()
          {
            flagHasIsRelative = false;
          }
        public void setUnit(TypeUnit new_value)
          {
            flagHasUnit = true;
            storeUnit = new_value;
          }
        public void setUnit(string chars)
          {
            setUnit(stringToUnit(chars));
          }
        public void unsetUnit()
          {
            flagHasUnit = false;
          }
        public void setAmbiguousValue(double new_value)
          {
            flagHasAmbiguousValue = true;
            storeAmbiguousValue = new_value;
            textStoreAmbiguousValue = "";
          }
        public void setAmbiguousValueText(string new_value)
          {
            flagHasAmbiguousValue = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field AmbiguousValue of TypeTemperatureJSON is not a valid number.");
            textStoreAmbiguousValue = new_value;
          }
        public void unsetAmbiguousValue()
          {
            flagHasAmbiguousValue = false;
          }
        public void setQualitativeTemperature(TypeQualitativeTemperature new_value)
          {
            flagHasQualitativeTemperature = true;
            storeQualitativeTemperature = new_value;
          }
        public void setQualitativeTemperature(string chars)
          {
            TypeQualitativeTemperatureKnownValues known = stringToQualitativeTemperature(chars);
            TypeQualitativeTemperature new_value = new TypeQualitativeTemperature();
            if (known == TypeQualitativeTemperatureKnownValues.QualitativeTemperature__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setQualitativeTemperature(new_value);
          }
        public void setQualitativeTemperature(TypeQualitativeTemperatureKnownValues new_value)
          {
            TypeQualitativeTemperature new_full_value = new TypeQualitativeTemperature();
            Debug.Assert(new_value != TypeQualitativeTemperatureKnownValues.QualitativeTemperature__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setQualitativeTemperature(new_full_value);
          }
        public void unsetQualitativeTemperature()
          {
            flagHasQualitativeTemperature = false;
          }
        public void setIncrementalChangeIntent(TypeIncrementalChangeIntent new_value)
          {
            flagHasIncrementalChangeIntent = true;
            storeIncrementalChangeIntent = new_value;
          }
        public void setIncrementalChangeIntent(string chars)
          {
            TypeIncrementalChangeIntentKnownValues known = stringToIncrementalChangeIntent(chars);
            TypeIncrementalChangeIntent new_value = new TypeIncrementalChangeIntent();
            if (known == TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setIncrementalChangeIntent(new_value);
          }
        public void setIncrementalChangeIntent(TypeIncrementalChangeIntentKnownValues new_value)
          {
            TypeIncrementalChangeIntent new_full_value = new TypeIncrementalChangeIntent();
            Debug.Assert(new_value != TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setIncrementalChangeIntent(new_full_value);
          }
        public void unsetIncrementalChangeIntent()
          {
            flagHasIncrementalChangeIntent = false;
          }
        public void setZone(TypeZone new_value)
          {
            flagHasZone = true;
            storeZone = new_value;
          }
        public void setZone(string chars)
          {
            setZone(stringToZone(chars));
          }
        public void unsetZone()
          {
            flagHasZone = false;
          }

        public virtual void extraTypeTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeTemperatureAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (textStoreValue != "")
                    handler.number_value(textStoreValue);
                else if (((double)(long)storeValue) == storeValue)
                    handler.number_value((long)storeValue);
                else
                    handler.number_value(storeValue);
              }
            Debug.Assert(partial_allowed || flagHasIsRelative);
            if (flagHasIsRelative)
              {
                handler.start_pair("IsRelative");
                handler.boolean_value(storeIsRelative);
              }
            Debug.Assert(partial_allowed || flagHasUnit);
            if (flagHasUnit)
              {
                handler.start_pair("Unit");
                switch (storeUnit)
                  {
                    case TypeUnit.Unit_F:
                        handler.string_value("F");
                        break;
                    case TypeUnit.Unit_C:
                        handler.string_value("C");
                        break;
                    case TypeUnit.Unit_degrees:
                        handler.string_value("degrees");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            if (flagHasAmbiguousValue)
              {
                handler.start_pair("AmbiguousValue");
                if (textStoreAmbiguousValue != "")
                    handler.number_value(textStoreAmbiguousValue);
                else if (((double)(long)storeAmbiguousValue) == storeAmbiguousValue)
                    handler.number_value((long)storeAmbiguousValue);
                else
                    handler.number_value(storeAmbiguousValue);
              }
            if (flagHasQualitativeTemperature)
              {
                handler.start_pair("QualitativeTemperature");
                if (storeQualitativeTemperature.in_known_list)
                  {
                    switch (storeQualitativeTemperature.list_value)
                      {
                        case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Coldest:
                            handler.string_value("Coldest");
                            break;
                        case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Cold:
                            handler.string_value("Cold");
                            break;
                        case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Cool:
                            handler.string_value("Cool");
                            break;
                        case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Medium:
                            handler.string_value("Medium");
                            break;
                        case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Warm:
                            handler.string_value("Warm");
                            break;
                        case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Hot:
                            handler.string_value("Hot");
                            break;
                        case TypeQualitativeTemperatureKnownValues.QualitativeTemperature_Hottest:
                            handler.string_value("Hottest");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeQualitativeTemperature.string_value);
                  }
              }
            if (flagHasIncrementalChangeIntent)
              {
                handler.start_pair("IncrementalChangeIntent");
                if (storeIncrementalChangeIntent.in_known_list)
                  {
                    switch (storeIncrementalChangeIntent.list_value)
                      {
                        case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_DecreaseStrongly:
                            handler.string_value("DecreaseStrongly");
                            break;
                        case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_Decrease:
                            handler.string_value("Decrease");
                            break;
                        case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_DecreaseSlightly:
                            handler.string_value("DecreaseSlightly");
                            break;
                        case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_IncreaseSlightly:
                            handler.string_value("IncreaseSlightly");
                            break;
                        case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_Increase:
                            handler.string_value("Increase");
                            break;
                        case TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent_IncreaseStrongly:
                            handler.string_value("IncreaseStrongly");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeIncrementalChangeIntent.string_value);
                  }
              }
            Debug.Assert(partial_allowed || flagHasZone);
            if (flagHasZone)
              {
                handler.start_pair("Zone");
                switch (storeZone)
                  {
                    case TypeZone.Zone_Unspecified:
                        handler.string_value("Unspecified");
                        break;
                    case TypeZone.Zone_Driver:
                        handler.string_value("Driver");
                        break;
                    case TypeZone.Zone_Passenger:
                        handler.string_value("Passenger");
                        break;
                    case TypeZone.Zone_BackSeat:
                        handler.string_value("BackSeat");
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            if (!(hasIsRelative()))
              {
                return "When parsing the object for %what%, the \"IsRelative\" field was missing.";
              }
            if (!(hasUnit()))
              {
                return "When parsing the object for %what%, the \"Unit\" field was missing.";
              }
            if (!(hasZone()))
              {
                return "When parsing the object for %what%, the \"Zone\" field was missing.";
              }
            return null;
          }

        public static TypeTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTemperature", ignore_extras);
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
        public static TypeTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTemperature", ignore_extras);
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
        public static TypeTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTemperature", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingNumberTextGenerator fieldGeneratorValue;
            private JSONHoldingBooleanGenerator fieldGeneratorIsRelative;
        private abstract class FieldGeneratorUnit : JSONStringGenerator
              {
                protected FieldGeneratorUnit(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorUnit()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToUnit(result));
                  }
                protected abstract void handle_result(TypeUnit result);
              };
        private class FieldHoldingGeneratorUnit : FieldGeneratorUnit
      {
        protected override void handle_result(TypeUnit result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorUnit(String what)
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
        public TypeUnit value;
      };
        private class FieldHoldingArrayGeneratorUnit : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorUnit
          {
            private FieldHoldingArrayGeneratorUnit top;

            protected override void handle_result(TypeUnit result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorUnit init_top)
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
        protected virtual void handle_result(List<TypeUnit> result)
          {
          }

        public FieldHoldingArrayGeneratorUnit(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnit>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorUnit()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnit>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeUnit> value;
      };
            private FieldHoldingGeneratorUnit fieldGeneratorUnit;
            private JSONHoldingNumberTextGenerator fieldGeneratorAmbiguousValue;
        private abstract class FieldGeneratorQualitativeTemperature : JSONStringGenerator
              {
                protected FieldGeneratorQualitativeTemperature(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorQualitativeTemperature()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeQualitativeTemperatureKnownValues known = stringToQualitativeTemperature(result);
                    TypeQualitativeTemperature new_value = new TypeQualitativeTemperature();
                    if (known == TypeQualitativeTemperatureKnownValues.QualitativeTemperature__none)
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
                protected abstract void handle_result(TypeQualitativeTemperature result);
              };
        private class FieldHoldingGeneratorQualitativeTemperature : FieldGeneratorQualitativeTemperature
      {
        protected override void handle_result(TypeQualitativeTemperature result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorQualitativeTemperature(String what)
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
        public TypeQualitativeTemperature value;
      };
        private class FieldHoldingArrayGeneratorQualitativeTemperature : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorQualitativeTemperature
          {
            private FieldHoldingArrayGeneratorQualitativeTemperature top;

            protected override void handle_result(TypeQualitativeTemperature result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorQualitativeTemperature init_top)
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
        protected virtual void handle_result(List<TypeQualitativeTemperature> result)
          {
          }

        public FieldHoldingArrayGeneratorQualitativeTemperature(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeQualitativeTemperature>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorQualitativeTemperature()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeQualitativeTemperature>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeQualitativeTemperature> value;
      };
            private FieldHoldingGeneratorQualitativeTemperature fieldGeneratorQualitativeTemperature;
        private abstract class FieldGeneratorIncrementalChangeIntent : JSONStringGenerator
              {
                protected FieldGeneratorIncrementalChangeIntent(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorIncrementalChangeIntent()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeIncrementalChangeIntentKnownValues known = stringToIncrementalChangeIntent(result);
                    TypeIncrementalChangeIntent new_value = new TypeIncrementalChangeIntent();
                    if (known == TypeIncrementalChangeIntentKnownValues.IncrementalChangeIntent__none)
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
                protected abstract void handle_result(TypeIncrementalChangeIntent result);
              };
        private class FieldHoldingGeneratorIncrementalChangeIntent : FieldGeneratorIncrementalChangeIntent
      {
        protected override void handle_result(TypeIncrementalChangeIntent result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorIncrementalChangeIntent(String what)
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
        public TypeIncrementalChangeIntent value;
      };
        private class FieldHoldingArrayGeneratorIncrementalChangeIntent : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorIncrementalChangeIntent
          {
            private FieldHoldingArrayGeneratorIncrementalChangeIntent top;

            protected override void handle_result(TypeIncrementalChangeIntent result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorIncrementalChangeIntent init_top)
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
        protected virtual void handle_result(List<TypeIncrementalChangeIntent> result)
          {
          }

        public FieldHoldingArrayGeneratorIncrementalChangeIntent(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeIncrementalChangeIntent>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorIncrementalChangeIntent()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeIncrementalChangeIntent>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeIncrementalChangeIntent> value;
      };
            private FieldHoldingGeneratorIncrementalChangeIntent fieldGeneratorIncrementalChangeIntent;
        private abstract class FieldGeneratorZone : JSONStringGenerator
              {
                protected FieldGeneratorZone(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorZone()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToZone(result));
                  }
                protected abstract void handle_result(TypeZone result);
              };
        private class FieldHoldingGeneratorZone : FieldGeneratorZone
      {
        protected override void handle_result(TypeZone result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorZone(String what)
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
        public TypeZone value;
      };
        private class FieldHoldingArrayGeneratorZone : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorZone
          {
            private FieldHoldingArrayGeneratorZone top;

            protected override void handle_result(TypeZone result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorZone init_top)
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
        protected virtual void handle_result(List<TypeZone> result)
          {
          }

        public FieldHoldingArrayGeneratorZone(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeZone>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorZone()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeZone>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeZone> value;
      };
            private FieldHoldingGeneratorZone fieldGeneratorZone;
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
                TypeTemperatureJSON result = new TypeTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeTemperatureJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValueText(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
                if (fieldGeneratorIsRelative.have_value)
                  {
                    result.setIsRelative(fieldGeneratorIsRelative.value);
                    fieldGeneratorIsRelative.have_value = false;
                  }
                else if ((!(result.hasIsRelative())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"IsRelative\" field was missing.");
                  }
                if (fieldGeneratorUnit.have_value)
                  {
                    result.setUnit(fieldGeneratorUnit.value);
                    fieldGeneratorUnit.have_value = false;
                  }
                else if ((!(result.hasUnit())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Unit\" field was missing.");
                  }
                if (fieldGeneratorAmbiguousValue.have_value)
                  {
                    result.setAmbiguousValueText(fieldGeneratorAmbiguousValue.value);
                    fieldGeneratorAmbiguousValue.have_value = false;
                  }
                if (fieldGeneratorQualitativeTemperature.have_value)
                  {
                    result.setQualitativeTemperature(fieldGeneratorQualitativeTemperature.value);
                    fieldGeneratorQualitativeTemperature.have_value = false;
                  }
                if (fieldGeneratorIncrementalChangeIntent.have_value)
                  {
                    result.setIncrementalChangeIntent(fieldGeneratorIncrementalChangeIntent.value);
                    fieldGeneratorIncrementalChangeIntent.have_value = false;
                  }
                if (fieldGeneratorZone.have_value)
                  {
                    result.setZone(fieldGeneratorZone.value);
                    fieldGeneratorZone.have_value = false;
                  }
                else if ((!(result.hasZone())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Zone\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "mbiguousValue", 0, 13, false) == 0) && (field_name.Length == 14))
                            return fieldGeneratorAmbiguousValue;
                        break;
                    case 'I':
                        switch (field_name[1])
                          {
                            case 'n':
                                if ((String.Compare(field_name, 2, "crementalChangeIntent", 0, 21, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorIncrementalChangeIntent;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 2, "Relative", 0, 8, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorIsRelative;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'Q':
                        if ((String.Compare(field_name, 1, "ualitativeTemperature", 0, 21, false) == 0) && (field_name.Length == 22))
                            return fieldGeneratorQualitativeTemperature;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorUnit;
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    case 'Z':
                        if ((String.Compare(field_name, 1, "one", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorZone;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeTemperature class");
                fieldGeneratorIsRelative = new JSONHoldingBooleanGenerator("field \"IsRelative\" of the TypeTemperature class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeTemperature class");
                fieldGeneratorAmbiguousValue = new JSONHoldingNumberTextGenerator("field \"AmbiguousValue\" of the TypeTemperature class");
                fieldGeneratorQualitativeTemperature = new FieldHoldingGeneratorQualitativeTemperature("field \"QualitativeTemperature\" of the TypeTemperature class");
                fieldGeneratorIncrementalChangeIntent = new FieldHoldingGeneratorIncrementalChangeIntent("field \"IncrementalChangeIntent\" of the TypeTemperature class");
                fieldGeneratorZone = new FieldHoldingGeneratorZone("field \"Zone\" of the TypeTemperature class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeTemperature class");
                fieldGeneratorIsRelative = new JSONHoldingBooleanGenerator("field \"IsRelative\" of the TypeTemperature class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeTemperature class");
                fieldGeneratorAmbiguousValue = new JSONHoldingNumberTextGenerator("field \"AmbiguousValue\" of the TypeTemperature class");
                fieldGeneratorQualitativeTemperature = new FieldHoldingGeneratorQualitativeTemperature("field \"QualitativeTemperature\" of the TypeTemperature class");
                fieldGeneratorIncrementalChangeIntent = new FieldHoldingGeneratorIncrementalChangeIntent("field \"IncrementalChangeIntent\" of the TypeTemperature class");
                fieldGeneratorZone = new FieldHoldingGeneratorZone("field \"Zone\" of the TypeTemperature class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorIsRelative.reset();
                fieldGeneratorUnit.reset();
                fieldGeneratorAmbiguousValue.reset();
                fieldGeneratorQualitativeTemperature.reset();
                fieldGeneratorIncrementalChangeIntent.reset();
                fieldGeneratorZone.reset();
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
            protected override void handle_result(TypeTemperatureJSON  result)
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
            public TypeTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeTemperatureJSON>();
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
        public List<TypeTemperatureJSON> value;
      };
      };
    private bool flagHasCommandType;
    private TypeCommandType storeCommandType;
    private bool flagHasFanSpeed;
    private TypeFanSpeed storeFanSpeed;
    private bool flagHasFanSpeedNumber;
    private double storeFanSpeedNumber;
    private string textStoreFanSpeedNumber;
    private bool flagHasVents;
    private TypeVentsJSON  storeVents;
    private bool flagHasTemperature;
    private List< TypeTemperatureJSON  > storeTemperature;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCommandTypeToJSON()
      {
        JSONStringValue generated_string_CommandType;
        switch (storeCommandType)
          {
            case TypeCommandType.CommandType_TurnAirConditioningOn:
                generated_string_CommandType = new JSONStringValue("TurnAirConditioningOn");
                break;
            case TypeCommandType.CommandType_TurnAirConditioningOff:
                generated_string_CommandType = new JSONStringValue("TurnAirConditioningOff");
                break;
            case TypeCommandType.CommandType_MaxAirConditioning:
                generated_string_CommandType = new JSONStringValue("MaxAirConditioning");
                break;
            case TypeCommandType.CommandType_TurnHeatingOn:
                generated_string_CommandType = new JSONStringValue("TurnHeatingOn");
                break;
            case TypeCommandType.CommandType_TurnHeatingOff:
                generated_string_CommandType = new JSONStringValue("TurnHeatingOff");
                break;
            case TypeCommandType.CommandType_AdjustTemperature:
                generated_string_CommandType = new JSONStringValue("AdjustTemperature");
                break;
            case TypeCommandType.CommandType_RecirculateOn:
                generated_string_CommandType = new JSONStringValue("RecirculateOn");
                break;
            case TypeCommandType.CommandType_RecirculateOff:
                generated_string_CommandType = new JSONStringValue("RecirculateOff");
                break;
            case TypeCommandType.CommandType_AdjustVents:
                generated_string_CommandType = new JSONStringValue("AdjustVents");
                break;
            case TypeCommandType.CommandType_AdjustFan:
                generated_string_CommandType = new JSONStringValue("AdjustFan");
                break;
            case TypeCommandType.CommandType_SyncTemperatureZones:
                generated_string_CommandType = new JSONStringValue("SyncTemperatureZones");
                break;
            case TypeCommandType.CommandType_SetClimateControlToAuto:
                generated_string_CommandType = new JSONStringValue("SetClimateControlToAuto");
                break;
            case TypeCommandType.CommandType_SetClimateControlToManual:
                generated_string_CommandType = new JSONStringValue("SetClimateControlToManual");
                break;
            case TypeCommandType.CommandType_ShowClimateControlScreen:
                generated_string_CommandType = new JSONStringValue("ShowClimateControlScreen");
                break;
            default:
                Debug.Assert(false);
                generated_string_CommandType = null;
                break;
          }
        return generated_string_CommandType;
      }

    private JSONValue  extraFanSpeedToJSON()
      {
        JSONStringValue generated_string_FanSpeed;
        switch (storeFanSpeed)
          {
            case TypeFanSpeed.FanSpeed_Off:
                generated_string_FanSpeed = new JSONStringValue("Off");
                break;
            case TypeFanSpeed.FanSpeed_Lowest:
                generated_string_FanSpeed = new JSONStringValue("Lowest");
                break;
            case TypeFanSpeed.FanSpeed_Lower:
                generated_string_FanSpeed = new JSONStringValue("Lower");
                break;
            case TypeFanSpeed.FanSpeed_Low:
                generated_string_FanSpeed = new JSONStringValue("Low");
                break;
            case TypeFanSpeed.FanSpeed_Medium:
                generated_string_FanSpeed = new JSONStringValue("Medium");
                break;
            case TypeFanSpeed.FanSpeed_High:
                generated_string_FanSpeed = new JSONStringValue("High");
                break;
            case TypeFanSpeed.FanSpeed_Higher:
                generated_string_FanSpeed = new JSONStringValue("Higher");
                break;
            case TypeFanSpeed.FanSpeed_Highest:
                generated_string_FanSpeed = new JSONStringValue("Highest");
                break;
            case TypeFanSpeed.FanSpeed_On:
                generated_string_FanSpeed = new JSONStringValue("On");
                break;
            case TypeFanSpeed.FanSpeed_Auto:
                generated_string_FanSpeed = new JSONStringValue("Auto");
                break;
            case TypeFanSpeed.FanSpeed_NoChange:
                generated_string_FanSpeed = new JSONStringValue("NoChange");
                break;
            case TypeFanSpeed.FanSpeed_SetTo:
                generated_string_FanSpeed = new JSONStringValue("SetTo");
                break;
            default:
                Debug.Assert(false);
                generated_string_FanSpeed = null;
                break;
          }
        return generated_string_FanSpeed;
      }

    private JSONValue  extraFanSpeedNumberToJSON()
      {
        JSONValue generated_rational_FanSpeedNumber;
        if (textStoreFanSpeedNumber != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreFanSpeedNumber);
            generated_rational_FanSpeedNumber = handler.result;
          }
        else if (((double)(long)storeFanSpeedNumber) == storeFanSpeedNumber)
            generated_rational_FanSpeedNumber = new JSONIntegerValue((long)(storeFanSpeedNumber));
        else
            generated_rational_FanSpeedNumber = new JSONRationalValue(storeFanSpeedNumber, 15);
        return generated_rational_FanSpeedNumber;
      }

    private JSONValue  extraVentsToJSON()
      {
        JSONValueHandler handler_Vents = new JSONValueHandler();
        storeVents.write_as_json(handler_Vents);
        return handler_Vents.result;
      }

    private JSONValue  extraTemperatureToJSON()
      {
        JSONArrayValue generated_array_1_Temperature = new JSONArrayValue();
        for (int num1 = 0; num1 < storeTemperature.Count; ++num1)
          {
            JSONValueHandler handler_Temperature = new JSONValueHandler();
            storeTemperature[num1].write_as_json(handler_Temperature);
            generated_array_1_Temperature.appendComponent(handler_Temperature.result);
          }
        return generated_array_1_Temperature;
      }


    private void  fromJSONCommandType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandType of CarControlClimateCommandJSON is not a string.");
        TypeCommandType the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if (String.Compare(json_string.getData(), 1, "djust", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 7, "an", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeCommandType.CommandType_AdjustFan;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'T':
                            if ((String.Compare(json_string.getData(), 7, "emperature", 0, 10, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_enum = TypeCommandType.CommandType_AdjustTemperature;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'V':
                            if ((String.Compare(json_string.getData(), 7, "ents", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_enum = TypeCommandType.CommandType_AdjustVents;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "axAirConditioning", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_enum = TypeCommandType.CommandType_MaxAirConditioning;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if (String.Compare(json_string.getData(), 1, "ecirculateO", 0, 11, false) == 0)
                  {
                    switch (json_string.getData()[12])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 13, "f", 0, 1, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_enum = TypeCommandType.CommandType_RecirculateOff;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if (json_string.getData().Length == 13)
                                  {
                                    the_enum = TypeCommandType.CommandType_RecirculateOn;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "tClimateControlTo", 0, 17, false) == 0)
                          {
                            switch (json_string.getData()[19])
                              {
                                case 'A':
                                    if ((String.Compare(json_string.getData(), 20, "uto", 0, 3, false) == 0) && (json_string.getData().Length == 23))
                                          {
                                            the_enum = TypeCommandType.CommandType_SetClimateControlToAuto;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'M':
                                    if ((String.Compare(json_string.getData(), 20, "anual", 0, 5, false) == 0) && (json_string.getData().Length == 25))
                                          {
                                            the_enum = TypeCommandType.CommandType_SetClimateControlToManual;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "owClimateControlScreen", 0, 22, false) == 0) && (json_string.getData().Length == 24))
                              {
                                the_enum = TypeCommandType.CommandType_ShowClimateControlScreen;
                                goto enum_is_done;
                              }
                        break;
                    case 'y':
                        if ((String.Compare(json_string.getData(), 2, "ncTemperatureZones", 0, 18, false) == 0) && (json_string.getData().Length == 20))
                              {
                                the_enum = TypeCommandType.CommandType_SyncTemperatureZones;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if (String.Compare(json_string.getData(), 1, "urn", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'A':
                            if (String.Compare(json_string.getData(), 5, "irConditioningO", 0, 15, false) == 0)
                              {
                                switch (json_string.getData()[20])
                                  {
                                    case 'f':
                                        if ((String.Compare(json_string.getData(), 21, "f", 0, 1, false) == 0) && (json_string.getData().Length == 22))
                                              {
                                                the_enum = TypeCommandType.CommandType_TurnAirConditioningOff;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 'n':
                                        if (json_string.getData().Length == 21)
                                              {
                                                the_enum = TypeCommandType.CommandType_TurnAirConditioningOn;
                                                goto enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'H':
                            if (String.Compare(json_string.getData(), 5, "eatingO", 0, 7, false) == 0)
                              {
                                switch (json_string.getData()[12])
                                  {
                                    case 'f':
                                        if ((String.Compare(json_string.getData(), 13, "f", 0, 1, false) == 0) && (json_string.getData().Length == 14))
                                              {
                                                the_enum = TypeCommandType.CommandType_TurnHeatingOff;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 'n':
                                        if (json_string.getData().Length == 13)
                                              {
                                                the_enum = TypeCommandType.CommandType_TurnHeatingOn;
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
        throw new Exception("The value for field CommandType of CarControlClimateCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setCommandType(the_enum);
      }


    private void  fromJSONFanSpeed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FanSpeed of CarControlClimateCommandJSON is not a string.");
        TypeFanSpeed the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "uto", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeFanSpeed.FanSpeed_Auto;
                        goto enum_is_done;
                      }
                break;
            case 'H':
                if (String.Compare(json_string.getData(), 1, "igh", 0, 3, false) == 0)
                  {
                    if (json_string.getData().Length == 4)
                      {
                          {
                            the_enum = TypeFanSpeed.FanSpeed_High;
                            goto enum_is_done;
                          }
                      }
                    switch (json_string.getData()[4])
                      {
                        case 'e':
                            switch (json_string.getData()[5])
                              {
                                case 'r':
                                    if (json_string.getData().Length == 6)
                                          {
                                            the_enum = TypeFanSpeed.FanSpeed_Higher;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 's':
                                    if ((String.Compare(json_string.getData(), 6, "t", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                          {
                                            the_enum = TypeFanSpeed.FanSpeed_Highest;
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
                if (String.Compare(json_string.getData(), 1, "ow", 0, 2, false) == 0)
                  {
                    if (json_string.getData().Length == 3)
                      {
                          {
                            the_enum = TypeFanSpeed.FanSpeed_Low;
                            goto enum_is_done;
                          }
                      }
                    switch (json_string.getData()[3])
                      {
                        case 'e':
                            switch (json_string.getData()[4])
                              {
                                case 'r':
                                    if (json_string.getData().Length == 5)
                                          {
                                            the_enum = TypeFanSpeed.FanSpeed_Lower;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 's':
                                    if ((String.Compare(json_string.getData(), 5, "t", 0, 1, false) == 0) && (json_string.getData().Length == 6))
                                          {
                                            the_enum = TypeFanSpeed.FanSpeed_Lowest;
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
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "edium", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeFanSpeed.FanSpeed_Medium;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "oChange", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeFanSpeed.FanSpeed_NoChange;
                        goto enum_is_done;
                      }
                break;
            case 'O':
                switch (json_string.getData()[1])
                  {
                    case 'f':
                        if ((String.Compare(json_string.getData(), 2, "f", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_enum = TypeFanSpeed.FanSpeed_Off;
                                goto enum_is_done;
                              }
                        break;
                    case 'n':
                        if (json_string.getData().Length == 2)
                              {
                                the_enum = TypeFanSpeed.FanSpeed_On;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "etTo", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeFanSpeed.FanSpeed_SetTo;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field FanSpeed of CarControlClimateCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setFanSpeed(the_enum);
      }


    private void  fromJSONFanSpeedNumber(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field FanSpeedNumber of CarControlClimateCommandJSON is not a number.");
              }
          }
        setFanSpeedNumberText(the_rational_text);
      }


    private void  fromJSONVents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeVentsJSON convert_classy = TypeVentsJSON.from_json(json_value, ignore_extras, true);
        setVents(convert_classy);
      }


    private void  fromJSONTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Temperature of CarControlClimateCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Temperature of CarControlClimateCommandJSON has too few elements.");
        List< TypeTemperatureJSON  > vector_Temperature1 = new List< TypeTemperatureJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeTemperatureJSON convert_classy = TypeTemperatureJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Temperature1.Add(convert_classy);
          }
        Debug.Assert(vector_Temperature1.Count >= 1);
        initTemperature();
        for (int num1 = 0; num1 < vector_Temperature1.Count; ++num1)
            appendTemperature(vector_Temperature1[num1]);
        for (int num1 = 0; num1 < vector_Temperature1.Count; ++num1)
          {
          }
      }


    public CarControlClimateCommandJSON()
      {
        flagHasCommandType = false;
        flagHasFanSpeed = false;
        flagHasFanSpeedNumber = false;
        flagHasVents = false;
        flagHasTemperature = false;
        storeTemperature = new List< TypeTemperatureJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCarControlCommandKind()
      {
        return "CarControlClimateCommand";
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

    public bool  hasFanSpeed()
      {
        return flagHasFanSpeed;
      }

    public TypeFanSpeed  getFanSpeed()
      {
        Debug.Assert(flagHasFanSpeed);
        return storeFanSpeed;
      }

    public string  getFanSpeedAsString()
      {
        return stringFromFanSpeed(getFanSpeed());
      }

    public bool  hasFanSpeedNumber()
      {
        return flagHasFanSpeedNumber;
      }

    public double  getFanSpeedNumber()
      {
        Debug.Assert(flagHasFanSpeedNumber);
        if (textStoreFanSpeedNumber != "")
          {
            return Double.Parse(textStoreFanSpeedNumber);
          }
        return storeFanSpeedNumber;
      }

    public string  getFanSpeedNumberAsText()
      {
        Debug.Assert(flagHasFanSpeedNumber);
        if (textStoreFanSpeedNumber == "")
          {
            return Convert.ToString(storeFanSpeedNumber);
          }
        else
          {
            return (textStoreFanSpeedNumber);
          }
      }

    public bool  hasVents()
      {
        return flagHasVents;
      }

    public TypeVentsJSON   getVents()
      {
        Debug.Assert(flagHasVents);
        return storeVents;
      }

    public bool  hasTemperature()
      {
        return flagHasTemperature;
      }

    public int  countOfTemperature()
      {
        Debug.Assert(flagHasTemperature);
        return storeTemperature.Count;
      }

    public TypeTemperatureJSON   elementOfTemperature(int element_num)
      {
        Debug.Assert(flagHasTemperature);
        return storeTemperature[element_num];
      }

    public List< TypeTemperatureJSON  >  getTemperature()
      {
        Debug.Assert(flagHasTemperature);
        return storeTemperature;
      }


    public virtual int extraCarControlClimateCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlClimateCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlClimateCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlClimateCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCarControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasCommandType)
            ++result;
        if (flagHasFanSpeed)
            ++result;
        if (flagHasFanSpeedNumber)
            ++result;
        if (flagHasVents)
            ++result;
        if (flagHasTemperature)
            ++result;
        result += extraCarControlClimateCommandComponentCount();
        return result;
      }
    public override string extraCarControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return "CommandType";
            --remainder;
          }
        if (flagHasFanSpeed)
          {
            if (remainder == 0)
                return "FanSpeed";
            --remainder;
          }
        if (flagHasFanSpeedNumber)
          {
            if (remainder == 0)
                return "FanSpeedNumber";
            --remainder;
          }
        if (flagHasVents)
          {
            if (remainder == 0)
                return "Vents";
            --remainder;
          }
        if (flagHasTemperature)
          {
            if (remainder == 0)
                return "Temperature";
            --remainder;
          }
        return extraCarControlClimateCommandComponentKey(remainder);
      }
    public override JSONValue extraCarControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandType)
          {
            if (remainder == 0)
                return extraCommandTypeToJSON();
            --remainder;
          }
        if (flagHasFanSpeed)
          {
            if (remainder == 0)
                return extraFanSpeedToJSON();
            --remainder;
          }
        if (flagHasFanSpeedNumber)
          {
            if (remainder == 0)
                return extraFanSpeedNumberToJSON();
            --remainder;
          }
        if (flagHasVents)
          {
            if (remainder == 0)
                return extraVentsToJSON();
            --remainder;
          }
        if (flagHasTemperature)
          {
            if (remainder == 0)
                return extraTemperatureToJSON();
            --remainder;
          }
        return extraCarControlClimateCommandComponentValue(remainder);
      }
    public override JSONValue extraCarControlCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCommandType ? extraCommandTypeToJSON() : null);
                break;
            case 'F':
                if (String.Compare(field_name, 1, "anSpeed", 0, 7, false) == 0)
                  {
                    if (field_name.Length == 8)
                      {
                        return (flagHasFanSpeed ? extraFanSpeedToJSON() : null);
                      }
                    switch (field_name[8])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 9, "umber", 0, 5, false) == 0) && (field_name.Length == 14))
                                return (flagHasFanSpeedNumber ? extraFanSpeedNumberToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "emperature", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasTemperature ? extraTemperatureToJSON() : null);
                break;
            case 'V':
                if ((String.Compare(field_name, 1, "ents", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasVents ? extraVentsToJSON() : null);
                break;
            default:
                break;
          }
        return extraCarControlClimateCommandLookup(field_name);
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
    public void setFanSpeed(TypeFanSpeed new_value)
      {
        flagHasFanSpeed = true;
        storeFanSpeed = new_value;
      }
    public void setFanSpeed(string chars)
      {
        setFanSpeed(stringToFanSpeed(chars));
      }
    public void unsetFanSpeed()
      {
        flagHasFanSpeed = false;
      }
    public void setFanSpeedNumber(double new_value)
      {
        flagHasFanSpeedNumber = true;
        storeFanSpeedNumber = new_value;
        textStoreFanSpeedNumber = "";
      }
    public void setFanSpeedNumberText(string new_value)
      {
        flagHasFanSpeedNumber = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field FanSpeedNumber of CarControlClimateCommandJSON is not a valid number.");
        textStoreFanSpeedNumber = new_value;
      }
    public void unsetFanSpeedNumber()
      {
        flagHasFanSpeedNumber = false;
      }
    public void setVents(TypeVentsJSON  new_value)
      {
        if (flagHasVents)
          {
          }
        flagHasVents = true;
        storeVents = new_value;
      }
    public void unsetVents()
      {
        if (flagHasVents)
          {
          }
        flagHasVents = false;
      }
    public void initTemperature()
      {
        if (flagHasTemperature)
          {
            for (int num1 = 0; num1 < storeTemperature.Count; ++num1)
              {
              }
          }
        flagHasTemperature = true;
        storeTemperature.Clear();
      }
    public void appendTemperature(TypeTemperatureJSON  to_append)
      {
        if (!flagHasTemperature)
          {
            flagHasTemperature = true;
            storeTemperature.Clear();
          }
        Debug.Assert(flagHasTemperature);
        storeTemperature.Add(to_append);
      }
    public void unsetTemperature()
      {
        if (flagHasTemperature)
          {
            for (int num2 = 0; num2 < storeTemperature.Count; ++num2)
              {
              }
          }
        flagHasTemperature = false;
        storeTemperature.Clear();
      }

    public virtual void extraCarControlClimateCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlClimateCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlClimateCommandLookup(key);
        if (old_field == null)
          {
            extraCarControlClimateCommandAppendPair(key, new_component);
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
            case 'F':
                if (String.Compare(key, 1, "anSpeed", 0, 7, false) == 0)
                  {
                    if (key.Length == 8)
                      {
                        {
                        fromJSONFanSpeed(new_component, false);
                        return;
                        }
                      }
                    switch (key[8])
                      {
                        case 'N':
                            if ((String.Compare(key, 9, "umber", 0, 5, false) == 0) && (key.Length == 14))
                                {
                                fromJSONFanSpeedNumber(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(key, 1, "emperature", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONTemperature(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if ((String.Compare(key, 1, "ents", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONVents(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlClimateCommandAppendPair(key, new_component);
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
            case 'F':
                if (String.Compare(key, 1, "anSpeed", 0, 7, false) == 0)
                  {
                    if (key.Length == 8)
                      {
                        {
                        fromJSONFanSpeed(new_component, false);
                        return;
                        }
                      }
                    switch (key[8])
                      {
                        case 'N':
                            if ((String.Compare(key, 9, "umber", 0, 5, false) == 0) && (key.Length == 14))
                                {
                                fromJSONFanSpeedNumber(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(key, 1, "emperature", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONTemperature(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if ((String.Compare(key, 1, "ents", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONVents(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCarControlClimateCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCommandType);
        if (flagHasCommandType)
          {
            handler.start_pair("CommandType");
            switch (storeCommandType)
              {
                case TypeCommandType.CommandType_TurnAirConditioningOn:
                    handler.string_value("TurnAirConditioningOn");
                    break;
                case TypeCommandType.CommandType_TurnAirConditioningOff:
                    handler.string_value("TurnAirConditioningOff");
                    break;
                case TypeCommandType.CommandType_MaxAirConditioning:
                    handler.string_value("MaxAirConditioning");
                    break;
                case TypeCommandType.CommandType_TurnHeatingOn:
                    handler.string_value("TurnHeatingOn");
                    break;
                case TypeCommandType.CommandType_TurnHeatingOff:
                    handler.string_value("TurnHeatingOff");
                    break;
                case TypeCommandType.CommandType_AdjustTemperature:
                    handler.string_value("AdjustTemperature");
                    break;
                case TypeCommandType.CommandType_RecirculateOn:
                    handler.string_value("RecirculateOn");
                    break;
                case TypeCommandType.CommandType_RecirculateOff:
                    handler.string_value("RecirculateOff");
                    break;
                case TypeCommandType.CommandType_AdjustVents:
                    handler.string_value("AdjustVents");
                    break;
                case TypeCommandType.CommandType_AdjustFan:
                    handler.string_value("AdjustFan");
                    break;
                case TypeCommandType.CommandType_SyncTemperatureZones:
                    handler.string_value("SyncTemperatureZones");
                    break;
                case TypeCommandType.CommandType_SetClimateControlToAuto:
                    handler.string_value("SetClimateControlToAuto");
                    break;
                case TypeCommandType.CommandType_SetClimateControlToManual:
                    handler.string_value("SetClimateControlToManual");
                    break;
                case TypeCommandType.CommandType_ShowClimateControlScreen:
                    handler.string_value("ShowClimateControlScreen");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasFanSpeed)
          {
            handler.start_pair("FanSpeed");
            switch (storeFanSpeed)
              {
                case TypeFanSpeed.FanSpeed_Off:
                    handler.string_value("Off");
                    break;
                case TypeFanSpeed.FanSpeed_Lowest:
                    handler.string_value("Lowest");
                    break;
                case TypeFanSpeed.FanSpeed_Lower:
                    handler.string_value("Lower");
                    break;
                case TypeFanSpeed.FanSpeed_Low:
                    handler.string_value("Low");
                    break;
                case TypeFanSpeed.FanSpeed_Medium:
                    handler.string_value("Medium");
                    break;
                case TypeFanSpeed.FanSpeed_High:
                    handler.string_value("High");
                    break;
                case TypeFanSpeed.FanSpeed_Higher:
                    handler.string_value("Higher");
                    break;
                case TypeFanSpeed.FanSpeed_Highest:
                    handler.string_value("Highest");
                    break;
                case TypeFanSpeed.FanSpeed_On:
                    handler.string_value("On");
                    break;
                case TypeFanSpeed.FanSpeed_Auto:
                    handler.string_value("Auto");
                    break;
                case TypeFanSpeed.FanSpeed_NoChange:
                    handler.string_value("NoChange");
                    break;
                case TypeFanSpeed.FanSpeed_SetTo:
                    handler.string_value("SetTo");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasFanSpeedNumber)
          {
            handler.start_pair("FanSpeedNumber");
            if (textStoreFanSpeedNumber != "")
                handler.number_value(textStoreFanSpeedNumber);
            else if (((double)(long)storeFanSpeedNumber) == storeFanSpeedNumber)
                handler.number_value((long)storeFanSpeedNumber);
            else
                handler.number_value(storeFanSpeedNumber);
          }
        if (flagHasVents)
          {
            handler.start_pair("Vents");
            if (partial_allowed)
                storeVents.write_partial_as_json(handler);
            else
                storeVents.write_as_json(handler);
          }
        if (flagHasTemperature)
          {
            handler.start_pair("Temperature");
            Debug.Assert(storeTemperature.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeTemperature.Count; ++num1)
              {
                if (partial_allowed)
                    storeTemperature[num1].write_partial_as_json(handler);
                else
                    storeTemperature[num1].write_as_json(handler);
              }
            handler.finish_array();
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

    public static new CarControlClimateCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlClimateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlClimateCommand", ignore_extras);
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
    public static new CarControlClimateCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlClimateCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlClimateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlClimateCommand", ignore_extras);
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
    public static new CarControlClimateCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlClimateCommandJSON from_text(string text, bool ignore_extras)
      {
        CarControlClimateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlClimateCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlClimateCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CarControlClimateCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlClimateCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlClimateCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CarControlCommandJSON.Generator
      {
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
    private abstract class FieldGeneratorFanSpeed : JSONStringGenerator
          {
            protected FieldGeneratorFanSpeed(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFanSpeed()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFanSpeed(result));
              }
            protected abstract void handle_result(TypeFanSpeed result);
          };
    private class FieldHoldingGeneratorFanSpeed : FieldGeneratorFanSpeed
  {
    protected override void handle_result(TypeFanSpeed result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFanSpeed(String what)
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
    public TypeFanSpeed value;
  };
    private class FieldHoldingArrayGeneratorFanSpeed : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFanSpeed
      {
        private FieldHoldingArrayGeneratorFanSpeed top;

        protected override void handle_result(TypeFanSpeed result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFanSpeed init_top)
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
    protected virtual void handle_result(List<TypeFanSpeed> result)
      {
      }

    public FieldHoldingArrayGeneratorFanSpeed(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFanSpeed>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFanSpeed()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFanSpeed>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFanSpeed> value;
  };
        private FieldHoldingGeneratorFanSpeed fieldGeneratorFanSpeed;
        private JSONHoldingNumberTextGenerator fieldGeneratorFanSpeedNumber;
        private TypeVentsJSON.HoldingGenerator fieldGeneratorVents;
        private TypeTemperatureJSON.HoldingArrayGenerator fieldGeneratorTemperature;
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
            if (!(getCarControlCommandJSONKey().Equals("CarControlClimateCommand")))
                throw new Exception("The key field has a value other than `CarControlClimateCommand'.");
            CarControlClimateCommandJSON result = new CarControlClimateCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlClimateCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CarControlCommandJSON new_result)
          {
            handle_result((CarControlClimateCommandJSON )new_result);
          }
        protected void finish(CarControlClimateCommandJSON result)
          {
            if (fieldGeneratorCommandType.have_value)
              {
                result.setCommandType(fieldGeneratorCommandType.value);
                fieldGeneratorCommandType.have_value = false;
              }
            else if ((!(result.hasCommandType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CommandType\" field was missing.");
              }
            if (fieldGeneratorFanSpeed.have_value)
              {
                result.setFanSpeed(fieldGeneratorFanSpeed.value);
                fieldGeneratorFanSpeed.have_value = false;
              }
            if (fieldGeneratorFanSpeedNumber.have_value)
              {
                result.setFanSpeedNumberText(fieldGeneratorFanSpeedNumber.value);
                fieldGeneratorFanSpeedNumber.have_value = false;
              }
            if (fieldGeneratorVents.have_value)
              {
                result.setVents(fieldGeneratorVents.value);
                fieldGeneratorVents.have_value = false;
              }
            if (fieldGeneratorTemperature.have_value)
              {
                result.initTemperature();
                int count = fieldGeneratorTemperature.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTemperature(fieldGeneratorTemperature.value[num]);
                  }
                fieldGeneratorTemperature.value.Clear();
                fieldGeneratorTemperature.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CarControlClimateCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandType;
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "anSpeed", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorFanSpeed;
                          }
                        switch (field_name[8])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 9, "umber", 0, 5, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorFanSpeedNumber;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "emperature", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorTemperature;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ents", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorVents;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlClimateCommand class");
            fieldGeneratorFanSpeed = new FieldHoldingGeneratorFanSpeed("field \"FanSpeed\" of the CarControlClimateCommand class");
            fieldGeneratorFanSpeedNumber = new JSONHoldingNumberTextGenerator("field \"FanSpeedNumber\" of the CarControlClimateCommand class");
            fieldGeneratorVents = new TypeVentsJSON.HoldingGenerator("field \"Vents\" of the CarControlClimateCommand class", ignore_extras);
            fieldGeneratorTemperature = new TypeTemperatureJSON.HoldingArrayGenerator("field \"Temperature\" of the CarControlClimateCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlClimateCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandType = new FieldHoldingGeneratorCommandType("field \"CommandType\" of the CarControlClimateCommand class");
            fieldGeneratorFanSpeed = new FieldHoldingGeneratorFanSpeed("field \"FanSpeed\" of the CarControlClimateCommand class");
            fieldGeneratorFanSpeedNumber = new JSONHoldingNumberTextGenerator("field \"FanSpeedNumber\" of the CarControlClimateCommand class");
            fieldGeneratorVents = new TypeVentsJSON.HoldingGenerator("field \"Vents\" of the CarControlClimateCommand class", false);
            fieldGeneratorTemperature = new TypeTemperatureJSON.HoldingArrayGenerator("field \"Temperature\" of the CarControlClimateCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlClimateCommand class");
          }

        public override void reset()
          {
            fieldGeneratorCommandType.reset();
            fieldGeneratorFanSpeed.reset();
            fieldGeneratorFanSpeedNumber.reset();
            fieldGeneratorVents.reset();
            fieldGeneratorTemperature.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlClimateCommandJSON  result)
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
        public CarControlClimateCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlClimateCommandJSON  result)
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
    protected virtual void handle_result(List<CarControlClimateCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlClimateCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlClimateCommandJSON>();
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
    public List<CarControlClimateCommandJSON> value;
  };
  };
