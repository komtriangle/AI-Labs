/* file "CarControlActionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlActionJSON : JSONBase
  {
    public enum TypeTargetTypeKnownValues
      {
        TargetType_SeatHeater,
        TargetType_SeatVentilator,
        TargetType_SeatMassager,
        TargetType_SteeringWheelHeater,
        TargetType_Sunshade,
        TargetType_InteriorLight,
        TargetType__none
      };
    public struct TypeTargetType
      {
        public bool in_known_list;
        public string string_value;
        public TypeTargetTypeKnownValues list_value;
      };

    public static TypeTargetTypeKnownValues  stringToTargetType(string chars)
      {
        switch (chars[0])
          {
            case 'I':
                if ((String.Compare(chars, 1, "nteriorLight", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeTargetTypeKnownValues.TargetType_InteriorLight;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'e':
                        if (String.Compare(chars, 2, "at", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'H':
                                    if ((String.Compare(chars, 5, "eater", 0, 5, false) == 0) && (chars.Length == 10))
                                        return TypeTargetTypeKnownValues.TargetType_SeatHeater;
                                    break;
                                case 'M':
                                    if ((String.Compare(chars, 5, "assager", 0, 7, false) == 0) && (chars.Length == 12))
                                        return TypeTargetTypeKnownValues.TargetType_SeatMassager;
                                    break;
                                case 'V':
                                    if ((String.Compare(chars, 5, "entilator", 0, 9, false) == 0) && (chars.Length == 14))
                                        return TypeTargetTypeKnownValues.TargetType_SeatVentilator;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "eeringWheelHeater", 0, 17, false) == 0) && (chars.Length == 19))
                            return TypeTargetTypeKnownValues.TargetType_SteeringWheelHeater;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "nshade", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeTargetTypeKnownValues.TargetType_Sunshade;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeTargetTypeKnownValues.TargetType__none;
      }

    public static string  stringFromTargetType(TypeTargetTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTargetTypeKnownValues.TargetType_SeatHeater:
                return "SeatHeater";
            case TypeTargetTypeKnownValues.TargetType_SeatVentilator:
                return "SeatVentilator";
            case TypeTargetTypeKnownValues.TargetType_SeatMassager:
                return "SeatMassager";
            case TypeTargetTypeKnownValues.TargetType_SteeringWheelHeater:
                return "SteeringWheelHeater";
            case TypeTargetTypeKnownValues.TargetType_Sunshade:
                return "Sunshade";
            case TypeTargetTypeKnownValues.TargetType_InteriorLight:
                return "InteriorLight";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeVerbKnownValues
      {
        Verb_TurnOn,
        Verb_TurnOff,
        Verb_Open,
        Verb_Close,
        Verb_IncrementIntensity,
        Verb_DecrementIntensity,
        Verb_SetIntensity,
        Verb__none
      };
    public struct TypeVerb
      {
        public bool in_known_list;
        public string string_value;
        public TypeVerbKnownValues list_value;
      };

    public static TypeVerbKnownValues  stringToVerb(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "lose", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeVerbKnownValues.Verb_Close;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ecrementIntensity", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeVerbKnownValues.Verb_DecrementIntensity;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "ncrementIntensity", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeVerbKnownValues.Verb_IncrementIntensity;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "pen", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeVerbKnownValues.Verb_Open;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "etIntensity", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeVerbKnownValues.Verb_SetIntensity;
                break;
            case 'T':
                if (String.Compare(chars, 1, "urnO", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'f':
                            if ((String.Compare(chars, 6, "f", 0, 1, false) == 0) && (chars.Length == 7))
                                return TypeVerbKnownValues.Verb_TurnOff;
                            break;
                        case 'n':
                            if (chars.Length == 6)
                                return TypeVerbKnownValues.Verb_TurnOn;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeVerbKnownValues.Verb__none;
      }

    public static string  stringFromVerb(TypeVerbKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeVerbKnownValues.Verb_TurnOn:
                return "TurnOn";
            case TypeVerbKnownValues.Verb_TurnOff:
                return "TurnOff";
            case TypeVerbKnownValues.Verb_Open:
                return "Open";
            case TypeVerbKnownValues.Verb_Close:
                return "Close";
            case TypeVerbKnownValues.Verb_IncrementIntensity:
                return "IncrementIntensity";
            case TypeVerbKnownValues.Verb_DecrementIntensity:
                return "DecrementIntensity";
            case TypeVerbKnownValues.Verb_SetIntensity:
                return "SetIntensity";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeIntensityKnownValues
      {
        Intensity_Level_1,
        Intensity_Level_2,
        Intensity_Level_3,
        Intensity_Level_4,
        Intensity_Level_5,
        Intensity_Level_6,
        Intensity_Level_Low,
        Intensity_Level_Medium,
        Intensity_Level_High,
        Intensity__none
      };
    public struct TypeIntensity
      {
        public bool in_known_list;
        public string string_value;
        public TypeIntensityKnownValues list_value;
      };

    public static TypeIntensityKnownValues  stringToIntensity(string chars)
      {
        if (String.Compare(chars, 0, "Level_", 0, 6, false) == 0)
          {
            switch (chars[6])
              {
                case '1':
                    if (chars.Length == 7)
                        return TypeIntensityKnownValues.Intensity_Level_1;
                    break;
                case '2':
                    if (chars.Length == 7)
                        return TypeIntensityKnownValues.Intensity_Level_2;
                    break;
                case '3':
                    if (chars.Length == 7)
                        return TypeIntensityKnownValues.Intensity_Level_3;
                    break;
                case '4':
                    if (chars.Length == 7)
                        return TypeIntensityKnownValues.Intensity_Level_4;
                    break;
                case '5':
                    if (chars.Length == 7)
                        return TypeIntensityKnownValues.Intensity_Level_5;
                    break;
                case '6':
                    if (chars.Length == 7)
                        return TypeIntensityKnownValues.Intensity_Level_6;
                    break;
                case 'H':
                    if ((String.Compare(chars, 7, "igh", 0, 3, false) == 0) && (chars.Length == 10))
                        return TypeIntensityKnownValues.Intensity_Level_High;
                    break;
                case 'L':
                    if ((String.Compare(chars, 7, "ow", 0, 2, false) == 0) && (chars.Length == 9))
                        return TypeIntensityKnownValues.Intensity_Level_Low;
                    break;
                case 'M':
                    if ((String.Compare(chars, 7, "edium", 0, 5, false) == 0) && (chars.Length == 12))
                        return TypeIntensityKnownValues.Intensity_Level_Medium;
                    break;
                default:
                    break;
              }
          }
        return TypeIntensityKnownValues.Intensity__none;
      }

    public static string  stringFromIntensity(TypeIntensityKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeIntensityKnownValues.Intensity_Level_1:
                return "Level_1";
            case TypeIntensityKnownValues.Intensity_Level_2:
                return "Level_2";
            case TypeIntensityKnownValues.Intensity_Level_3:
                return "Level_3";
            case TypeIntensityKnownValues.Intensity_Level_4:
                return "Level_4";
            case TypeIntensityKnownValues.Intensity_Level_5:
                return "Level_5";
            case TypeIntensityKnownValues.Intensity_Level_6:
                return "Level_6";
            case TypeIntensityKnownValues.Intensity_Level_Low:
                return "Level_Low";
            case TypeIntensityKnownValues.Intensity_Level_Medium:
                return "Level_Medium";
            case TypeIntensityKnownValues.Intensity_Level_High:
                return "Level_High";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeMassageStyleKnownValues
      {
        MassageStyle_Classical,
        MassageStyle_Wave,
        MassageStyle_HotStone,
        MassageStyle__none
      };
    public struct TypeMassageStyle
      {
        public bool in_known_list;
        public string string_value;
        public TypeMassageStyleKnownValues list_value;
      };

    public static TypeMassageStyleKnownValues  stringToMassageStyle(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "lassical", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeMassageStyleKnownValues.MassageStyle_Classical;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "otStone", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeMassageStyleKnownValues.MassageStyle_HotStone;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "ave", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeMassageStyleKnownValues.MassageStyle_Wave;
                break;
            default:
                break;
          }
        return TypeMassageStyleKnownValues.MassageStyle__none;
      }

    public static string  stringFromMassageStyle(TypeMassageStyleKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeMassageStyleKnownValues.MassageStyle_Classical:
                return "Classical";
            case TypeMassageStyleKnownValues.MassageStyle_Wave:
                return "Wave";
            case TypeMassageStyleKnownValues.MassageStyle_HotStone:
                return "HotStone";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeShadeInstanceKnownValues
      {
        ShadeInstance_RoofUnspecified,
        ShadeInstance_RoofFront,
        ShadeInstance_RoofBack,
        ShadeInstance_RoofBoth,
        ShadeInstance_RoofAll,
        ShadeInstance__none
      };
    public struct TypeShadeInstance
      {
        public bool in_known_list;
        public string string_value;
        public TypeShadeInstanceKnownValues list_value;
      };

    public static TypeShadeInstanceKnownValues  stringToShadeInstance(string chars)
      {
        if (String.Compare(chars, 0, "Roof", 0, 4, false) == 0)
          {
            switch (chars[4])
              {
                case 'A':
                    if ((String.Compare(chars, 5, "ll", 0, 2, false) == 0) && (chars.Length == 7))
                        return TypeShadeInstanceKnownValues.ShadeInstance_RoofAll;
                    break;
                case 'B':
                    switch (chars[5])
                      {
                        case 'a':
                            if ((String.Compare(chars, 6, "ck", 0, 2, false) == 0) && (chars.Length == 8))
                                return TypeShadeInstanceKnownValues.ShadeInstance_RoofBack;
                            break;
                        case 'o':
                            if ((String.Compare(chars, 6, "th", 0, 2, false) == 0) && (chars.Length == 8))
                                return TypeShadeInstanceKnownValues.ShadeInstance_RoofBoth;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if ((String.Compare(chars, 5, "ront", 0, 4, false) == 0) && (chars.Length == 9))
                        return TypeShadeInstanceKnownValues.ShadeInstance_RoofFront;
                    break;
                case 'U':
                    if ((String.Compare(chars, 5, "nspecified", 0, 10, false) == 0) && (chars.Length == 15))
                        return TypeShadeInstanceKnownValues.ShadeInstance_RoofUnspecified;
                    break;
                default:
                    break;
              }
          }
        return TypeShadeInstanceKnownValues.ShadeInstance__none;
      }

    public static string  stringFromShadeInstance(TypeShadeInstanceKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeShadeInstanceKnownValues.ShadeInstance_RoofUnspecified:
                return "RoofUnspecified";
            case TypeShadeInstanceKnownValues.ShadeInstance_RoofFront:
                return "RoofFront";
            case TypeShadeInstanceKnownValues.ShadeInstance_RoofBack:
                return "RoofBack";
            case TypeShadeInstanceKnownValues.ShadeInstance_RoofBoth:
                return "RoofBoth";
            case TypeShadeInstanceKnownValues.ShadeInstance_RoofAll:
                return "RoofAll";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeLightInstanceKnownValues
      {
        LightInstance_Dome,
        LightInstance_DomeFront,
        LightInstance_DomeBack,
        LightInstance_DomeBoth,
        LightInstance_Map,
        LightInstance_Ambient,
        LightInstance__none
      };
    public struct TypeLightInstance
      {
        public bool in_known_list;
        public string string_value;
        public TypeLightInstanceKnownValues list_value;
      };

    public static TypeLightInstanceKnownValues  stringToLightInstance(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "mbient", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeLightInstanceKnownValues.LightInstance_Ambient;
                break;
            case 'D':
                if (String.Compare(chars, 1, "ome", 0, 3, false) == 0)
                  {
                    if (chars.Length == 4)
                      {
                        return TypeLightInstanceKnownValues.LightInstance_Dome;
                      }
                    switch (chars[4])
                      {
                        case 'B':
                            switch (chars[5])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 6, "ck", 0, 2, false) == 0) && (chars.Length == 8))
                                        return TypeLightInstanceKnownValues.LightInstance_DomeBack;
                                    break;
                                case 'o':
                                    if ((String.Compare(chars, 6, "th", 0, 2, false) == 0) && (chars.Length == 8))
                                        return TypeLightInstanceKnownValues.LightInstance_DomeBoth;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'F':
                            if ((String.Compare(chars, 5, "ront", 0, 4, false) == 0) && (chars.Length == 9))
                                return TypeLightInstanceKnownValues.LightInstance_DomeFront;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(chars, 1, "ap", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeLightInstanceKnownValues.LightInstance_Map;
                break;
            default:
                break;
          }
        return TypeLightInstanceKnownValues.LightInstance__none;
      }

    public static string  stringFromLightInstance(TypeLightInstanceKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeLightInstanceKnownValues.LightInstance_Dome:
                return "Dome";
            case TypeLightInstanceKnownValues.LightInstance_DomeFront:
                return "DomeFront";
            case TypeLightInstanceKnownValues.LightInstance_DomeBack:
                return "DomeBack";
            case TypeLightInstanceKnownValues.LightInstance_DomeBoth:
                return "DomeBoth";
            case TypeLightInstanceKnownValues.LightInstance_Map:
                return "Map";
            case TypeLightInstanceKnownValues.LightInstance_Ambient:
                return "Ambient";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeAmbientColorKnownValues
      {
        AmbientColor_Red,
        AmbientColor_Green,
        AmbientColor_Blue,
        AmbientColor_Purple,
        AmbientColor_Yellow,
        AmbientColor_Pink,
        AmbientColor_Orange,
        AmbientColor_Brown,
        AmbientColor_White,
        AmbientColor__none
      };
    public struct TypeAmbientColor
      {
        public bool in_known_list;
        public string string_value;
        public TypeAmbientColorKnownValues list_value;
      };

    public static TypeAmbientColorKnownValues  stringToAmbientColor(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "ue", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeAmbientColorKnownValues.AmbientColor_Blue;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "own", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeAmbientColorKnownValues.AmbientColor_Brown;
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                if ((String.Compare(chars, 1, "reen", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeAmbientColorKnownValues.AmbientColor_Green;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "range", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeAmbientColorKnownValues.AmbientColor_Orange;
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "nk", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeAmbientColorKnownValues.AmbientColor_Pink;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "rple", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeAmbientColorKnownValues.AmbientColor_Purple;
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                if ((String.Compare(chars, 1, "ed", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeAmbientColorKnownValues.AmbientColor_Red;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "hite", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeAmbientColorKnownValues.AmbientColor_White;
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "ellow", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeAmbientColorKnownValues.AmbientColor_Yellow;
                break;
            default:
                break;
          }
        return TypeAmbientColorKnownValues.AmbientColor__none;
      }

    public static string  stringFromAmbientColor(TypeAmbientColorKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeAmbientColorKnownValues.AmbientColor_Red:
                return "Red";
            case TypeAmbientColorKnownValues.AmbientColor_Green:
                return "Green";
            case TypeAmbientColorKnownValues.AmbientColor_Blue:
                return "Blue";
            case TypeAmbientColorKnownValues.AmbientColor_Purple:
                return "Purple";
            case TypeAmbientColorKnownValues.AmbientColor_Yellow:
                return "Yellow";
            case TypeAmbientColorKnownValues.AmbientColor_Pink:
                return "Pink";
            case TypeAmbientColorKnownValues.AmbientColor_Orange:
                return "Orange";
            case TypeAmbientColorKnownValues.AmbientColor_Brown:
                return "Brown";
            case TypeAmbientColorKnownValues.AmbientColor_White:
                return "White";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTargetType;
    private TypeTargetType storeTargetType;
    private bool flagHasSeatSelection;
    private CarSeatSelectionJSON  storeSeatSelection;
    private bool flagHasVerb;
    private TypeVerb storeVerb;
    private bool flagHasIntensity;
    private TypeIntensity storeIntensity;
    private bool flagHasMassageStyle;
    private TypeMassageStyle storeMassageStyle;
    private bool flagHasShadeInstance;
    private TypeShadeInstance storeShadeInstance;
    private bool flagHasLightInstance;
    private TypeLightInstance storeLightInstance;
    private bool flagHasAmbientColor;
    private TypeAmbientColor storeAmbientColor;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTargetType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TargetType of CarControlActionJSON is not a string.");
        TypeTargetType the_open_enum = new TypeTargetType();
        switch (json_string.getData()[0])
          {
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nteriorLight", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTargetTypeKnownValues.TargetType_InteriorLight;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "at", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'H':
                                    if ((String.Compare(json_string.getData(), 5, "eater", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeTargetTypeKnownValues.TargetType_SeatHeater;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'M':
                                    if ((String.Compare(json_string.getData(), 5, "assager", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeTargetTypeKnownValues.TargetType_SeatMassager;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'V':
                                    if ((String.Compare(json_string.getData(), 5, "entilator", 0, 9, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeTargetTypeKnownValues.TargetType_SeatVentilator;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(json_string.getData(), 2, "eeringWheelHeater", 0, 17, false) == 0) && (json_string.getData().Length == 19))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTargetTypeKnownValues.TargetType_SteeringWheelHeater;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "nshade", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTargetTypeKnownValues.TargetType_Sunshade;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setTargetType(the_open_enum);
      }


    private void  fromJSONSeatSelection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CarSeatSelectionJSON convert_classy = CarSeatSelectionJSON.from_json(json_value, ignore_extras, true);
        setSeatSelection(convert_classy);
      }


    private void  fromJSONVerb(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Verb of CarControlActionJSON is not a string.");
        TypeVerb the_open_enum = new TypeVerb();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "lose", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeVerbKnownValues.Verb_Close;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ecrementIntensity", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeVerbKnownValues.Verb_DecrementIntensity;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "ncrementIntensity", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeVerbKnownValues.Verb_IncrementIntensity;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "pen", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeVerbKnownValues.Verb_Open;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "etIntensity", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeVerbKnownValues.Verb_SetIntensity;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if (String.Compare(json_string.getData(), 1, "urnO", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 6, "f", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeVerbKnownValues.Verb_TurnOff;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'n':
                            if (json_string.getData().Length == 6)
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeVerbKnownValues.Verb_TurnOn;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setVerb(the_open_enum);
      }


    private void  fromJSONIntensity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Intensity of CarControlActionJSON is not a string.");
        TypeIntensity the_open_enum = new TypeIntensity();
        if (String.Compare(json_string.getData(), 0, "Level_", 0, 6, false) == 0)
          {
            switch (json_string.getData()[6])
              {
                case '1':
                    if (json_string.getData().Length == 7)
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeIntensityKnownValues.Intensity_Level_1;
                            goto open_enum_is_done;
                          }
                    break;
                case '2':
                    if (json_string.getData().Length == 7)
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeIntensityKnownValues.Intensity_Level_2;
                            goto open_enum_is_done;
                          }
                    break;
                case '3':
                    if (json_string.getData().Length == 7)
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeIntensityKnownValues.Intensity_Level_3;
                            goto open_enum_is_done;
                          }
                    break;
                case '4':
                    if (json_string.getData().Length == 7)
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeIntensityKnownValues.Intensity_Level_4;
                            goto open_enum_is_done;
                          }
                    break;
                case '5':
                    if (json_string.getData().Length == 7)
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeIntensityKnownValues.Intensity_Level_5;
                            goto open_enum_is_done;
                          }
                    break;
                case '6':
                    if (json_string.getData().Length == 7)
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeIntensityKnownValues.Intensity_Level_6;
                            goto open_enum_is_done;
                          }
                    break;
                case 'H':
                    if ((String.Compare(json_string.getData(), 7, "igh", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeIntensityKnownValues.Intensity_Level_High;
                            goto open_enum_is_done;
                          }
                    break;
                case 'L':
                    if ((String.Compare(json_string.getData(), 7, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeIntensityKnownValues.Intensity_Level_Low;
                            goto open_enum_is_done;
                          }
                    break;
                case 'M':
                    if ((String.Compare(json_string.getData(), 7, "edium", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeIntensityKnownValues.Intensity_Level_Medium;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setIntensity(the_open_enum);
      }


    private void  fromJSONMassageStyle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MassageStyle of CarControlActionJSON is not a string.");
        TypeMassageStyle the_open_enum = new TypeMassageStyle();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "lassical", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMassageStyleKnownValues.MassageStyle_Classical;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "otStone", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMassageStyleKnownValues.MassageStyle_HotStone;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "ave", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMassageStyleKnownValues.MassageStyle_Wave;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setMassageStyle(the_open_enum);
      }


    private void  fromJSONShadeInstance(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShadeInstance of CarControlActionJSON is not a string.");
        TypeShadeInstance the_open_enum = new TypeShadeInstance();
        if (String.Compare(json_string.getData(), 0, "Roof", 0, 4, false) == 0)
          {
            switch (json_string.getData()[4])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 5, "ll", 0, 2, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeShadeInstanceKnownValues.ShadeInstance_RoofAll;
                            goto open_enum_is_done;
                          }
                    break;
                case 'B':
                    switch (json_string.getData()[5])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 6, "ck", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeShadeInstanceKnownValues.ShadeInstance_RoofBack;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'o':
                            if ((String.Compare(json_string.getData(), 6, "th", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeShadeInstanceKnownValues.ShadeInstance_RoofBoth;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if ((String.Compare(json_string.getData(), 5, "ront", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeShadeInstanceKnownValues.ShadeInstance_RoofFront;
                            goto open_enum_is_done;
                          }
                    break;
                case 'U':
                    if ((String.Compare(json_string.getData(), 5, "nspecified", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeShadeInstanceKnownValues.ShadeInstance_RoofUnspecified;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setShadeInstance(the_open_enum);
      }


    private void  fromJSONLightInstance(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LightInstance of CarControlActionJSON is not a string.");
        TypeLightInstance the_open_enum = new TypeLightInstance();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "mbient", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLightInstanceKnownValues.LightInstance_Ambient;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if (String.Compare(json_string.getData(), 1, "ome", 0, 3, false) == 0)
                  {
                    if (json_string.getData().Length == 4)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeLightInstanceKnownValues.LightInstance_Dome;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[4])
                      {
                        case 'B':
                            switch (json_string.getData()[5])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 6, "ck", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeLightInstanceKnownValues.LightInstance_DomeBack;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'o':
                                    if ((String.Compare(json_string.getData(), 6, "th", 0, 2, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeLightInstanceKnownValues.LightInstance_DomeBoth;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'F':
                            if ((String.Compare(json_string.getData(), 5, "ront", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLightInstanceKnownValues.LightInstance_DomeFront;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ap", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLightInstanceKnownValues.LightInstance_Map;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setLightInstance(the_open_enum);
      }


    private void  fromJSONAmbientColor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AmbientColor of CarControlActionJSON is not a string.");
        TypeAmbientColor the_open_enum = new TypeAmbientColor();
        switch (json_string.getData()[0])
          {
            case 'B':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ue", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeAmbientColorKnownValues.AmbientColor_Blue;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "own", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeAmbientColorKnownValues.AmbientColor_Brown;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "reen", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeAmbientColorKnownValues.AmbientColor_Green;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "range", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeAmbientColorKnownValues.AmbientColor_Orange;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "nk", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeAmbientColorKnownValues.AmbientColor_Pink;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "rple", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeAmbientColorKnownValues.AmbientColor_Purple;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "ed", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeAmbientColorKnownValues.AmbientColor_Red;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "hite", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeAmbientColorKnownValues.AmbientColor_White;
                        goto open_enum_is_done;
                      }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "ellow", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeAmbientColorKnownValues.AmbientColor_Yellow;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setAmbientColor(the_open_enum);
      }


    public CarControlActionJSON()
      {
        flagHasTargetType = false;
        flagHasSeatSelection = false;
        flagHasVerb = false;
        flagHasIntensity = false;
        flagHasMassageStyle = false;
        flagHasShadeInstance = false;
        flagHasLightInstance = false;
        flagHasAmbientColor = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTargetType()
      {
        return flagHasTargetType;
      }

    public TypeTargetType  getTargetType()
      {
        Debug.Assert(flagHasTargetType);
        return storeTargetType;
      }

    public string  getTargetTypeAsString()
      {
        TypeTargetType result = getTargetType();
        if (result.in_known_list)
            return stringFromTargetType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasSeatSelection()
      {
        return flagHasSeatSelection;
      }

    public CarSeatSelectionJSON   getSeatSelection()
      {
        Debug.Assert(flagHasSeatSelection);
        return storeSeatSelection;
      }

    public bool  hasVerb()
      {
        return flagHasVerb;
      }

    public TypeVerb  getVerb()
      {
        Debug.Assert(flagHasVerb);
        return storeVerb;
      }

    public string  getVerbAsString()
      {
        TypeVerb result = getVerb();
        if (result.in_known_list)
            return stringFromVerb(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasIntensity()
      {
        return flagHasIntensity;
      }

    public TypeIntensity  getIntensity()
      {
        Debug.Assert(flagHasIntensity);
        return storeIntensity;
      }

    public string  getIntensityAsString()
      {
        TypeIntensity result = getIntensity();
        if (result.in_known_list)
            return stringFromIntensity(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasMassageStyle()
      {
        return flagHasMassageStyle;
      }

    public TypeMassageStyle  getMassageStyle()
      {
        Debug.Assert(flagHasMassageStyle);
        return storeMassageStyle;
      }

    public string  getMassageStyleAsString()
      {
        TypeMassageStyle result = getMassageStyle();
        if (result.in_known_list)
            return stringFromMassageStyle(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasShadeInstance()
      {
        return flagHasShadeInstance;
      }

    public TypeShadeInstance  getShadeInstance()
      {
        Debug.Assert(flagHasShadeInstance);
        return storeShadeInstance;
      }

    public string  getShadeInstanceAsString()
      {
        TypeShadeInstance result = getShadeInstance();
        if (result.in_known_list)
            return stringFromShadeInstance(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasLightInstance()
      {
        return flagHasLightInstance;
      }

    public TypeLightInstance  getLightInstance()
      {
        Debug.Assert(flagHasLightInstance);
        return storeLightInstance;
      }

    public string  getLightInstanceAsString()
      {
        TypeLightInstance result = getLightInstance();
        if (result.in_known_list)
            return stringFromLightInstance(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasAmbientColor()
      {
        return flagHasAmbientColor;
      }

    public TypeAmbientColor  getAmbientColor()
      {
        Debug.Assert(flagHasAmbientColor);
        return storeAmbientColor;
      }

    public string  getAmbientColorAsString()
      {
        TypeAmbientColor result = getAmbientColor();
        if (result.in_known_list)
            return stringFromAmbientColor(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraCarControlActionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlActionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlActionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlActionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTargetType(TypeTargetType new_value)
      {
        flagHasTargetType = true;
        storeTargetType = new_value;
      }
    public void setTargetType(string chars)
      {
        TypeTargetTypeKnownValues known = stringToTargetType(chars);
        TypeTargetType new_value = new TypeTargetType();
        if (known == TypeTargetTypeKnownValues.TargetType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setTargetType(new_value);
      }
    public void setTargetType(TypeTargetTypeKnownValues new_value)
      {
        TypeTargetType new_full_value = new TypeTargetType();
        Debug.Assert(new_value != TypeTargetTypeKnownValues.TargetType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setTargetType(new_full_value);
      }
    public void unsetTargetType()
      {
        flagHasTargetType = false;
      }
    public void setSeatSelection(CarSeatSelectionJSON  new_value)
      {
        if (flagHasSeatSelection)
          {
          }
        flagHasSeatSelection = true;
        storeSeatSelection = new_value;
      }
    public void unsetSeatSelection()
      {
        if (flagHasSeatSelection)
          {
          }
        flagHasSeatSelection = false;
      }
    public void setVerb(TypeVerb new_value)
      {
        flagHasVerb = true;
        storeVerb = new_value;
      }
    public void setVerb(string chars)
      {
        TypeVerbKnownValues known = stringToVerb(chars);
        TypeVerb new_value = new TypeVerb();
        if (known == TypeVerbKnownValues.Verb__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setVerb(new_value);
      }
    public void setVerb(TypeVerbKnownValues new_value)
      {
        TypeVerb new_full_value = new TypeVerb();
        Debug.Assert(new_value != TypeVerbKnownValues.Verb__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setVerb(new_full_value);
      }
    public void unsetVerb()
      {
        flagHasVerb = false;
      }
    public void setIntensity(TypeIntensity new_value)
      {
        flagHasIntensity = true;
        storeIntensity = new_value;
      }
    public void setIntensity(string chars)
      {
        TypeIntensityKnownValues known = stringToIntensity(chars);
        TypeIntensity new_value = new TypeIntensity();
        if (known == TypeIntensityKnownValues.Intensity__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setIntensity(new_value);
      }
    public void setIntensity(TypeIntensityKnownValues new_value)
      {
        TypeIntensity new_full_value = new TypeIntensity();
        Debug.Assert(new_value != TypeIntensityKnownValues.Intensity__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setIntensity(new_full_value);
      }
    public void unsetIntensity()
      {
        flagHasIntensity = false;
      }
    public void setMassageStyle(TypeMassageStyle new_value)
      {
        flagHasMassageStyle = true;
        storeMassageStyle = new_value;
      }
    public void setMassageStyle(string chars)
      {
        TypeMassageStyleKnownValues known = stringToMassageStyle(chars);
        TypeMassageStyle new_value = new TypeMassageStyle();
        if (known == TypeMassageStyleKnownValues.MassageStyle__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setMassageStyle(new_value);
      }
    public void setMassageStyle(TypeMassageStyleKnownValues new_value)
      {
        TypeMassageStyle new_full_value = new TypeMassageStyle();
        Debug.Assert(new_value != TypeMassageStyleKnownValues.MassageStyle__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setMassageStyle(new_full_value);
      }
    public void unsetMassageStyle()
      {
        flagHasMassageStyle = false;
      }
    public void setShadeInstance(TypeShadeInstance new_value)
      {
        flagHasShadeInstance = true;
        storeShadeInstance = new_value;
      }
    public void setShadeInstance(string chars)
      {
        TypeShadeInstanceKnownValues known = stringToShadeInstance(chars);
        TypeShadeInstance new_value = new TypeShadeInstance();
        if (known == TypeShadeInstanceKnownValues.ShadeInstance__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setShadeInstance(new_value);
      }
    public void setShadeInstance(TypeShadeInstanceKnownValues new_value)
      {
        TypeShadeInstance new_full_value = new TypeShadeInstance();
        Debug.Assert(new_value != TypeShadeInstanceKnownValues.ShadeInstance__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setShadeInstance(new_full_value);
      }
    public void unsetShadeInstance()
      {
        flagHasShadeInstance = false;
      }
    public void setLightInstance(TypeLightInstance new_value)
      {
        flagHasLightInstance = true;
        storeLightInstance = new_value;
      }
    public void setLightInstance(string chars)
      {
        TypeLightInstanceKnownValues known = stringToLightInstance(chars);
        TypeLightInstance new_value = new TypeLightInstance();
        if (known == TypeLightInstanceKnownValues.LightInstance__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setLightInstance(new_value);
      }
    public void setLightInstance(TypeLightInstanceKnownValues new_value)
      {
        TypeLightInstance new_full_value = new TypeLightInstance();
        Debug.Assert(new_value != TypeLightInstanceKnownValues.LightInstance__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setLightInstance(new_full_value);
      }
    public void unsetLightInstance()
      {
        flagHasLightInstance = false;
      }
    public void setAmbientColor(TypeAmbientColor new_value)
      {
        flagHasAmbientColor = true;
        storeAmbientColor = new_value;
      }
    public void setAmbientColor(string chars)
      {
        TypeAmbientColorKnownValues known = stringToAmbientColor(chars);
        TypeAmbientColor new_value = new TypeAmbientColor();
        if (known == TypeAmbientColorKnownValues.AmbientColor__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setAmbientColor(new_value);
      }
    public void setAmbientColor(TypeAmbientColorKnownValues new_value)
      {
        TypeAmbientColor new_full_value = new TypeAmbientColor();
        Debug.Assert(new_value != TypeAmbientColorKnownValues.AmbientColor__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setAmbientColor(new_full_value);
      }
    public void unsetAmbientColor()
      {
        flagHasAmbientColor = false;
      }

    public virtual void extraCarControlActionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlActionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlActionLookup(key);
        if (old_field == null)
          {
            extraCarControlActionAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTargetType);
        if (flagHasTargetType)
          {
            handler.start_pair("TargetType");
            if (storeTargetType.in_known_list)
              {
                switch (storeTargetType.list_value)
                  {
                    case TypeTargetTypeKnownValues.TargetType_SeatHeater:
                        handler.string_value("SeatHeater");
                        break;
                    case TypeTargetTypeKnownValues.TargetType_SeatVentilator:
                        handler.string_value("SeatVentilator");
                        break;
                    case TypeTargetTypeKnownValues.TargetType_SeatMassager:
                        handler.string_value("SeatMassager");
                        break;
                    case TypeTargetTypeKnownValues.TargetType_SteeringWheelHeater:
                        handler.string_value("SteeringWheelHeater");
                        break;
                    case TypeTargetTypeKnownValues.TargetType_Sunshade:
                        handler.string_value("Sunshade");
                        break;
                    case TypeTargetTypeKnownValues.TargetType_InteriorLight:
                        handler.string_value("InteriorLight");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeTargetType.string_value);
              }
          }
        if (flagHasSeatSelection)
          {
            handler.start_pair("SeatSelection");
            if (partial_allowed)
                storeSeatSelection.write_partial_as_json(handler);
            else
                storeSeatSelection.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasVerb);
        if (flagHasVerb)
          {
            handler.start_pair("Verb");
            if (storeVerb.in_known_list)
              {
                switch (storeVerb.list_value)
                  {
                    case TypeVerbKnownValues.Verb_TurnOn:
                        handler.string_value("TurnOn");
                        break;
                    case TypeVerbKnownValues.Verb_TurnOff:
                        handler.string_value("TurnOff");
                        break;
                    case TypeVerbKnownValues.Verb_Open:
                        handler.string_value("Open");
                        break;
                    case TypeVerbKnownValues.Verb_Close:
                        handler.string_value("Close");
                        break;
                    case TypeVerbKnownValues.Verb_IncrementIntensity:
                        handler.string_value("IncrementIntensity");
                        break;
                    case TypeVerbKnownValues.Verb_DecrementIntensity:
                        handler.string_value("DecrementIntensity");
                        break;
                    case TypeVerbKnownValues.Verb_SetIntensity:
                        handler.string_value("SetIntensity");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeVerb.string_value);
              }
          }
        if (flagHasIntensity)
          {
            handler.start_pair("Intensity");
            if (storeIntensity.in_known_list)
              {
                switch (storeIntensity.list_value)
                  {
                    case TypeIntensityKnownValues.Intensity_Level_1:
                        handler.string_value("Level_1");
                        break;
                    case TypeIntensityKnownValues.Intensity_Level_2:
                        handler.string_value("Level_2");
                        break;
                    case TypeIntensityKnownValues.Intensity_Level_3:
                        handler.string_value("Level_3");
                        break;
                    case TypeIntensityKnownValues.Intensity_Level_4:
                        handler.string_value("Level_4");
                        break;
                    case TypeIntensityKnownValues.Intensity_Level_5:
                        handler.string_value("Level_5");
                        break;
                    case TypeIntensityKnownValues.Intensity_Level_6:
                        handler.string_value("Level_6");
                        break;
                    case TypeIntensityKnownValues.Intensity_Level_Low:
                        handler.string_value("Level_Low");
                        break;
                    case TypeIntensityKnownValues.Intensity_Level_Medium:
                        handler.string_value("Level_Medium");
                        break;
                    case TypeIntensityKnownValues.Intensity_Level_High:
                        handler.string_value("Level_High");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeIntensity.string_value);
              }
          }
        if (flagHasMassageStyle)
          {
            handler.start_pair("MassageStyle");
            if (storeMassageStyle.in_known_list)
              {
                switch (storeMassageStyle.list_value)
                  {
                    case TypeMassageStyleKnownValues.MassageStyle_Classical:
                        handler.string_value("Classical");
                        break;
                    case TypeMassageStyleKnownValues.MassageStyle_Wave:
                        handler.string_value("Wave");
                        break;
                    case TypeMassageStyleKnownValues.MassageStyle_HotStone:
                        handler.string_value("HotStone");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeMassageStyle.string_value);
              }
          }
        if (flagHasShadeInstance)
          {
            handler.start_pair("ShadeInstance");
            if (storeShadeInstance.in_known_list)
              {
                switch (storeShadeInstance.list_value)
                  {
                    case TypeShadeInstanceKnownValues.ShadeInstance_RoofUnspecified:
                        handler.string_value("RoofUnspecified");
                        break;
                    case TypeShadeInstanceKnownValues.ShadeInstance_RoofFront:
                        handler.string_value("RoofFront");
                        break;
                    case TypeShadeInstanceKnownValues.ShadeInstance_RoofBack:
                        handler.string_value("RoofBack");
                        break;
                    case TypeShadeInstanceKnownValues.ShadeInstance_RoofBoth:
                        handler.string_value("RoofBoth");
                        break;
                    case TypeShadeInstanceKnownValues.ShadeInstance_RoofAll:
                        handler.string_value("RoofAll");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeShadeInstance.string_value);
              }
          }
        if (flagHasLightInstance)
          {
            handler.start_pair("LightInstance");
            if (storeLightInstance.in_known_list)
              {
                switch (storeLightInstance.list_value)
                  {
                    case TypeLightInstanceKnownValues.LightInstance_Dome:
                        handler.string_value("Dome");
                        break;
                    case TypeLightInstanceKnownValues.LightInstance_DomeFront:
                        handler.string_value("DomeFront");
                        break;
                    case TypeLightInstanceKnownValues.LightInstance_DomeBack:
                        handler.string_value("DomeBack");
                        break;
                    case TypeLightInstanceKnownValues.LightInstance_DomeBoth:
                        handler.string_value("DomeBoth");
                        break;
                    case TypeLightInstanceKnownValues.LightInstance_Map:
                        handler.string_value("Map");
                        break;
                    case TypeLightInstanceKnownValues.LightInstance_Ambient:
                        handler.string_value("Ambient");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeLightInstance.string_value);
              }
          }
        if (flagHasAmbientColor)
          {
            handler.start_pair("AmbientColor");
            if (storeAmbientColor.in_known_list)
              {
                switch (storeAmbientColor.list_value)
                  {
                    case TypeAmbientColorKnownValues.AmbientColor_Red:
                        handler.string_value("Red");
                        break;
                    case TypeAmbientColorKnownValues.AmbientColor_Green:
                        handler.string_value("Green");
                        break;
                    case TypeAmbientColorKnownValues.AmbientColor_Blue:
                        handler.string_value("Blue");
                        break;
                    case TypeAmbientColorKnownValues.AmbientColor_Purple:
                        handler.string_value("Purple");
                        break;
                    case TypeAmbientColorKnownValues.AmbientColor_Yellow:
                        handler.string_value("Yellow");
                        break;
                    case TypeAmbientColorKnownValues.AmbientColor_Pink:
                        handler.string_value("Pink");
                        break;
                    case TypeAmbientColorKnownValues.AmbientColor_Orange:
                        handler.string_value("Orange");
                        break;
                    case TypeAmbientColorKnownValues.AmbientColor_Brown:
                        handler.string_value("Brown");
                        break;
                    case TypeAmbientColorKnownValues.AmbientColor_White:
                        handler.string_value("White");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeAmbientColor.string_value);
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
        if (!(hasTargetType()))
          {
            return "When parsing the object for %what%, the \"TargetType\" field was missing.";
          }
        if (!(hasVerb()))
          {
            return "When parsing the object for %what%, the \"Verb\" field was missing.";
          }
        return null;
      }

    public static CarControlActionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlActionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlAction", ignore_extras);
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
    public static CarControlActionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarControlActionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlActionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlAction", ignore_extras);
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
    public static CarControlActionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarControlActionJSON from_text(string text, bool ignore_extras)
      {
        CarControlActionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlAction", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlActionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CarControlActionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlActionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlAction", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorTargetType : JSONStringGenerator
          {
            protected FieldGeneratorTargetType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTargetType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTargetTypeKnownValues known = stringToTargetType(result);
                TypeTargetType new_value = new TypeTargetType();
                if (known == TypeTargetTypeKnownValues.TargetType__none)
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
            protected abstract void handle_result(TypeTargetType result);
          };
    private class FieldHoldingGeneratorTargetType : FieldGeneratorTargetType
  {
    protected override void handle_result(TypeTargetType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTargetType(String what)
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
    public TypeTargetType value;
  };
    private class FieldHoldingArrayGeneratorTargetType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTargetType
      {
        private FieldHoldingArrayGeneratorTargetType top;

        protected override void handle_result(TypeTargetType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTargetType init_top)
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
    protected virtual void handle_result(List<TypeTargetType> result)
      {
      }

    public FieldHoldingArrayGeneratorTargetType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTargetType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTargetType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTargetType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTargetType> value;
  };
        private FieldHoldingGeneratorTargetType fieldGeneratorTargetType;
        private CarSeatSelectionJSON.HoldingGenerator fieldGeneratorSeatSelection;
    private abstract class FieldGeneratorVerb : JSONStringGenerator
          {
            protected FieldGeneratorVerb(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorVerb()
              {
              }
            protected override void handle_result(string result)
              {
                TypeVerbKnownValues known = stringToVerb(result);
                TypeVerb new_value = new TypeVerb();
                if (known == TypeVerbKnownValues.Verb__none)
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
            protected abstract void handle_result(TypeVerb result);
          };
    private class FieldHoldingGeneratorVerb : FieldGeneratorVerb
  {
    protected override void handle_result(TypeVerb result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorVerb(String what)
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
    public TypeVerb value;
  };
    private class FieldHoldingArrayGeneratorVerb : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorVerb
      {
        private FieldHoldingArrayGeneratorVerb top;

        protected override void handle_result(TypeVerb result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorVerb init_top)
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
    protected virtual void handle_result(List<TypeVerb> result)
      {
      }

    public FieldHoldingArrayGeneratorVerb(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeVerb>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorVerb()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeVerb>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeVerb> value;
  };
        private FieldHoldingGeneratorVerb fieldGeneratorVerb;
    private abstract class FieldGeneratorIntensity : JSONStringGenerator
          {
            protected FieldGeneratorIntensity(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorIntensity()
              {
              }
            protected override void handle_result(string result)
              {
                TypeIntensityKnownValues known = stringToIntensity(result);
                TypeIntensity new_value = new TypeIntensity();
                if (known == TypeIntensityKnownValues.Intensity__none)
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
            protected abstract void handle_result(TypeIntensity result);
          };
    private class FieldHoldingGeneratorIntensity : FieldGeneratorIntensity
  {
    protected override void handle_result(TypeIntensity result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorIntensity(String what)
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
    public TypeIntensity value;
  };
    private class FieldHoldingArrayGeneratorIntensity : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorIntensity
      {
        private FieldHoldingArrayGeneratorIntensity top;

        protected override void handle_result(TypeIntensity result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorIntensity init_top)
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
    protected virtual void handle_result(List<TypeIntensity> result)
      {
      }

    public FieldHoldingArrayGeneratorIntensity(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeIntensity>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorIntensity()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeIntensity>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeIntensity> value;
  };
        private FieldHoldingGeneratorIntensity fieldGeneratorIntensity;
    private abstract class FieldGeneratorMassageStyle : JSONStringGenerator
          {
            protected FieldGeneratorMassageStyle(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorMassageStyle()
              {
              }
            protected override void handle_result(string result)
              {
                TypeMassageStyleKnownValues known = stringToMassageStyle(result);
                TypeMassageStyle new_value = new TypeMassageStyle();
                if (known == TypeMassageStyleKnownValues.MassageStyle__none)
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
            protected abstract void handle_result(TypeMassageStyle result);
          };
    private class FieldHoldingGeneratorMassageStyle : FieldGeneratorMassageStyle
  {
    protected override void handle_result(TypeMassageStyle result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorMassageStyle(String what)
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
    public TypeMassageStyle value;
  };
    private class FieldHoldingArrayGeneratorMassageStyle : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMassageStyle
      {
        private FieldHoldingArrayGeneratorMassageStyle top;

        protected override void handle_result(TypeMassageStyle result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMassageStyle init_top)
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
    protected virtual void handle_result(List<TypeMassageStyle> result)
      {
      }

    public FieldHoldingArrayGeneratorMassageStyle(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMassageStyle>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMassageStyle()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMassageStyle>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMassageStyle> value;
  };
        private FieldHoldingGeneratorMassageStyle fieldGeneratorMassageStyle;
    private abstract class FieldGeneratorShadeInstance : JSONStringGenerator
          {
            protected FieldGeneratorShadeInstance(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorShadeInstance()
              {
              }
            protected override void handle_result(string result)
              {
                TypeShadeInstanceKnownValues known = stringToShadeInstance(result);
                TypeShadeInstance new_value = new TypeShadeInstance();
                if (known == TypeShadeInstanceKnownValues.ShadeInstance__none)
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
            protected abstract void handle_result(TypeShadeInstance result);
          };
    private class FieldHoldingGeneratorShadeInstance : FieldGeneratorShadeInstance
  {
    protected override void handle_result(TypeShadeInstance result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorShadeInstance(String what)
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
    public TypeShadeInstance value;
  };
    private class FieldHoldingArrayGeneratorShadeInstance : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorShadeInstance
      {
        private FieldHoldingArrayGeneratorShadeInstance top;

        protected override void handle_result(TypeShadeInstance result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorShadeInstance init_top)
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
    protected virtual void handle_result(List<TypeShadeInstance> result)
      {
      }

    public FieldHoldingArrayGeneratorShadeInstance(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeShadeInstance>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorShadeInstance()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeShadeInstance>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeShadeInstance> value;
  };
        private FieldHoldingGeneratorShadeInstance fieldGeneratorShadeInstance;
    private abstract class FieldGeneratorLightInstance : JSONStringGenerator
          {
            protected FieldGeneratorLightInstance(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLightInstance()
              {
              }
            protected override void handle_result(string result)
              {
                TypeLightInstanceKnownValues known = stringToLightInstance(result);
                TypeLightInstance new_value = new TypeLightInstance();
                if (known == TypeLightInstanceKnownValues.LightInstance__none)
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
            protected abstract void handle_result(TypeLightInstance result);
          };
    private class FieldHoldingGeneratorLightInstance : FieldGeneratorLightInstance
  {
    protected override void handle_result(TypeLightInstance result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLightInstance(String what)
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
    public TypeLightInstance value;
  };
    private class FieldHoldingArrayGeneratorLightInstance : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLightInstance
      {
        private FieldHoldingArrayGeneratorLightInstance top;

        protected override void handle_result(TypeLightInstance result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLightInstance init_top)
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
    protected virtual void handle_result(List<TypeLightInstance> result)
      {
      }

    public FieldHoldingArrayGeneratorLightInstance(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLightInstance>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLightInstance()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLightInstance>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLightInstance> value;
  };
        private FieldHoldingGeneratorLightInstance fieldGeneratorLightInstance;
    private abstract class FieldGeneratorAmbientColor : JSONStringGenerator
          {
            protected FieldGeneratorAmbientColor(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorAmbientColor()
              {
              }
            protected override void handle_result(string result)
              {
                TypeAmbientColorKnownValues known = stringToAmbientColor(result);
                TypeAmbientColor new_value = new TypeAmbientColor();
                if (known == TypeAmbientColorKnownValues.AmbientColor__none)
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
            protected abstract void handle_result(TypeAmbientColor result);
          };
    private class FieldHoldingGeneratorAmbientColor : FieldGeneratorAmbientColor
  {
    protected override void handle_result(TypeAmbientColor result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorAmbientColor(String what)
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
    public TypeAmbientColor value;
  };
    private class FieldHoldingArrayGeneratorAmbientColor : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAmbientColor
      {
        private FieldHoldingArrayGeneratorAmbientColor top;

        protected override void handle_result(TypeAmbientColor result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAmbientColor init_top)
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
    protected virtual void handle_result(List<TypeAmbientColor> result)
      {
      }

    public FieldHoldingArrayGeneratorAmbientColor(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAmbientColor>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAmbientColor()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAmbientColor>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAmbientColor> value;
  };
        private FieldHoldingGeneratorAmbientColor fieldGeneratorAmbientColor;
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
            CarControlActionJSON result = new CarControlActionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlActionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CarControlActionJSON result)
          {
            if (fieldGeneratorTargetType.have_value)
              {
                result.setTargetType(fieldGeneratorTargetType.value);
                fieldGeneratorTargetType.have_value = false;
              }
            else if ((!(result.hasTargetType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TargetType\" field was missing.");
              }
            if (fieldGeneratorSeatSelection.have_value)
              {
                result.setSeatSelection(fieldGeneratorSeatSelection.value);
                fieldGeneratorSeatSelection.have_value = false;
              }
            if (fieldGeneratorVerb.have_value)
              {
                result.setVerb(fieldGeneratorVerb.value);
                fieldGeneratorVerb.have_value = false;
              }
            else if ((!(result.hasVerb())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Verb\" field was missing.");
              }
            if (fieldGeneratorIntensity.have_value)
              {
                result.setIntensity(fieldGeneratorIntensity.value);
                fieldGeneratorIntensity.have_value = false;
              }
            if (fieldGeneratorMassageStyle.have_value)
              {
                result.setMassageStyle(fieldGeneratorMassageStyle.value);
                fieldGeneratorMassageStyle.have_value = false;
              }
            if (fieldGeneratorShadeInstance.have_value)
              {
                result.setShadeInstance(fieldGeneratorShadeInstance.value);
                fieldGeneratorShadeInstance.have_value = false;
              }
            if (fieldGeneratorLightInstance.have_value)
              {
                result.setLightInstance(fieldGeneratorLightInstance.value);
                fieldGeneratorLightInstance.have_value = false;
              }
            if (fieldGeneratorAmbientColor.have_value)
              {
                result.setAmbientColor(fieldGeneratorAmbientColor.value);
                fieldGeneratorAmbientColor.have_value = false;
              }
          }
        protected abstract void handle_result(CarControlActionJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mbientColor", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorAmbientColor;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "ntensity", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorIntensity;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ightInstance", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorLightInstance;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "assageStyle", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorMassageStyle;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "atSelection", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorSeatSelection;
                            break;
                        case 'h':
                            if ((String.Compare(field_name, 2, "adeInstance", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorShadeInstance;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "argetType", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorTargetType;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "erb", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorVerb;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTargetType = new FieldHoldingGeneratorTargetType("field \"TargetType\" of the CarControlAction class");
            fieldGeneratorSeatSelection = new CarSeatSelectionJSON.HoldingGenerator("field \"SeatSelection\" of the CarControlAction class", ignore_extras);
            fieldGeneratorVerb = new FieldHoldingGeneratorVerb("field \"Verb\" of the CarControlAction class");
            fieldGeneratorIntensity = new FieldHoldingGeneratorIntensity("field \"Intensity\" of the CarControlAction class");
            fieldGeneratorMassageStyle = new FieldHoldingGeneratorMassageStyle("field \"MassageStyle\" of the CarControlAction class");
            fieldGeneratorShadeInstance = new FieldHoldingGeneratorShadeInstance("field \"ShadeInstance\" of the CarControlAction class");
            fieldGeneratorLightInstance = new FieldHoldingGeneratorLightInstance("field \"LightInstance\" of the CarControlAction class");
            fieldGeneratorAmbientColor = new FieldHoldingGeneratorAmbientColor("field \"AmbientColor\" of the CarControlAction class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlAction class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTargetType = new FieldHoldingGeneratorTargetType("field \"TargetType\" of the CarControlAction class");
            fieldGeneratorSeatSelection = new CarSeatSelectionJSON.HoldingGenerator("field \"SeatSelection\" of the CarControlAction class", false);
            fieldGeneratorVerb = new FieldHoldingGeneratorVerb("field \"Verb\" of the CarControlAction class");
            fieldGeneratorIntensity = new FieldHoldingGeneratorIntensity("field \"Intensity\" of the CarControlAction class");
            fieldGeneratorMassageStyle = new FieldHoldingGeneratorMassageStyle("field \"MassageStyle\" of the CarControlAction class");
            fieldGeneratorShadeInstance = new FieldHoldingGeneratorShadeInstance("field \"ShadeInstance\" of the CarControlAction class");
            fieldGeneratorLightInstance = new FieldHoldingGeneratorLightInstance("field \"LightInstance\" of the CarControlAction class");
            fieldGeneratorAmbientColor = new FieldHoldingGeneratorAmbientColor("field \"AmbientColor\" of the CarControlAction class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlAction class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTargetType.reset();
            fieldGeneratorSeatSelection.reset();
            fieldGeneratorVerb.reset();
            fieldGeneratorIntensity.reset();
            fieldGeneratorMassageStyle.reset();
            fieldGeneratorShadeInstance.reset();
            fieldGeneratorLightInstance.reset();
            fieldGeneratorAmbientColor.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSeatSelection.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSeatSelection.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlActionJSON  result)
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
        public CarControlActionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlActionJSON  result)
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
    protected virtual void handle_result(List<CarControlActionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlActionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlActionJSON>();
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
    public List<CarControlActionJSON> value;
  };
  };
