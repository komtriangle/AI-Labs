/* file "UnitConversionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UnitConversionJSON : JSONBase
  {
    public enum TypeConversionTypeKnownValues
      {
        ConversionType_MassToVolume,
        ConversionType_VolumeToMass,
        ConversionType_Length,
        ConversionType_Temperature,
        ConversionType_Pressure,
        ConversionType_Mass,
        ConversionType_Time,
        ConversionType_Data,
        ConversionType_Frequency,
        ConversionType_Angles,
        ConversionType_Volume,
        ConversionType_Force,
        ConversionType_Work,
        ConversionType_Power,
        ConversionType_Area,
        ConversionType_Speed,
        ConversionType_Acceleration,
        ConversionType_Unknown,
        ConversionType__none
      };
    public struct TypeConversionType
      {
        public bool in_known_list;
        public string string_value;
        public TypeConversionTypeKnownValues list_value;
      };

    public static TypeConversionTypeKnownValues  stringToConversionType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'c':
                        if ((String.Compare(chars, 2, "celeration", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeConversionTypeKnownValues.ConversionType_Acceleration;
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "gles", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeConversionTypeKnownValues.ConversionType_Angles;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "ea", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeConversionTypeKnownValues.ConversionType_Area;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ata", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeConversionTypeKnownValues.ConversionType_Data;
                break;
            case 'F':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "rce", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeConversionTypeKnownValues.ConversionType_Force;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "equency", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeConversionTypeKnownValues.ConversionType_Frequency;
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ength", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeConversionTypeKnownValues.ConversionType_Length;
                break;
            case 'M':
                if (String.Compare(chars, 1, "ass", 0, 3, false) == 0)
                  {
                    if (chars.Length == 4)
                      {
                        return TypeConversionTypeKnownValues.ConversionType_Mass;
                      }
                    switch (chars[4])
                      {
                        case 'T':
                            if ((String.Compare(chars, 5, "oVolume", 0, 7, false) == 0) && (chars.Length == 12))
                                return TypeConversionTypeKnownValues.ConversionType_MassToVolume;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "wer", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeConversionTypeKnownValues.ConversionType_Power;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "essure", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeConversionTypeKnownValues.ConversionType_Pressure;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "peed", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeConversionTypeKnownValues.ConversionType_Speed;
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "mperature", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeConversionTypeKnownValues.ConversionType_Temperature;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "me", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeConversionTypeKnownValues.ConversionType_Time;
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeConversionTypeKnownValues.ConversionType_Unknown;
                break;
            case 'V':
                if (String.Compare(chars, 1, "olume", 0, 5, false) == 0)
                  {
                    if (chars.Length == 6)
                      {
                        return TypeConversionTypeKnownValues.ConversionType_Volume;
                      }
                    switch (chars[6])
                      {
                        case 'T':
                            if ((String.Compare(chars, 7, "oMass", 0, 5, false) == 0) && (chars.Length == 12))
                                return TypeConversionTypeKnownValues.ConversionType_VolumeToMass;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if ((String.Compare(chars, 1, "ork", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeConversionTypeKnownValues.ConversionType_Work;
                break;
            default:
                break;
          }
        return TypeConversionTypeKnownValues.ConversionType__none;
      }

    public static string  stringFromConversionType(TypeConversionTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeConversionTypeKnownValues.ConversionType_MassToVolume:
                return "MassToVolume";
            case TypeConversionTypeKnownValues.ConversionType_VolumeToMass:
                return "VolumeToMass";
            case TypeConversionTypeKnownValues.ConversionType_Length:
                return "Length";
            case TypeConversionTypeKnownValues.ConversionType_Temperature:
                return "Temperature";
            case TypeConversionTypeKnownValues.ConversionType_Pressure:
                return "Pressure";
            case TypeConversionTypeKnownValues.ConversionType_Mass:
                return "Mass";
            case TypeConversionTypeKnownValues.ConversionType_Time:
                return "Time";
            case TypeConversionTypeKnownValues.ConversionType_Data:
                return "Data";
            case TypeConversionTypeKnownValues.ConversionType_Frequency:
                return "Frequency";
            case TypeConversionTypeKnownValues.ConversionType_Angles:
                return "Angles";
            case TypeConversionTypeKnownValues.ConversionType_Volume:
                return "Volume";
            case TypeConversionTypeKnownValues.ConversionType_Force:
                return "Force";
            case TypeConversionTypeKnownValues.ConversionType_Work:
                return "Work";
            case TypeConversionTypeKnownValues.ConversionType_Power:
                return "Power";
            case TypeConversionTypeKnownValues.ConversionType_Area:
                return "Area";
            case TypeConversionTypeKnownValues.ConversionType_Speed:
                return "Speed";
            case TypeConversionTypeKnownValues.ConversionType_Acceleration:
                return "Acceleration";
            case TypeConversionTypeKnownValues.ConversionType_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeReferencePointJSON : JSONBase
      {
        public enum TypeUnitTypeKnownValues
          {
            UnitType_Density,
            UnitType_Length,
            UnitType_Temperature,
            UnitType_Pressure,
            UnitType_Mass,
            UnitType_Time,
            UnitType_Data,
            UnitType_Frequency,
            UnitType_Angles,
            UnitType_Volume,
            UnitType_Force,
            UnitType_Work,
            UnitType_Power,
            UnitType_Area,
            UnitType_Speed,
            UnitType_Acceleration,
            UnitType_Unknown,
            UnitType__none
          };
        public struct TypeUnitType
          {
            public bool in_known_list;
            public string string_value;
            public TypeUnitTypeKnownValues list_value;
          };

        public static TypeUnitTypeKnownValues  stringToUnitType(string chars)
          {
            switch (chars[0])
              {
                case 'A':
                    switch (chars[1])
                      {
                        case 'c':
                            if ((String.Compare(chars, 2, "celeration", 0, 10, false) == 0) && (chars.Length == 12))
                                return TypeUnitTypeKnownValues.UnitType_Acceleration;
                            break;
                        case 'n':
                            if ((String.Compare(chars, 2, "gles", 0, 4, false) == 0) && (chars.Length == 6))
                                return TypeUnitTypeKnownValues.UnitType_Angles;
                            break;
                        case 'r':
                            if ((String.Compare(chars, 2, "ea", 0, 2, false) == 0) && (chars.Length == 4))
                                return TypeUnitTypeKnownValues.UnitType_Area;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    switch (chars[1])
                      {
                        case 'a':
                            if ((String.Compare(chars, 2, "ta", 0, 2, false) == 0) && (chars.Length == 4))
                                return TypeUnitTypeKnownValues.UnitType_Data;
                            break;
                        case 'e':
                            if ((String.Compare(chars, 2, "nsity", 0, 5, false) == 0) && (chars.Length == 7))
                                return TypeUnitTypeKnownValues.UnitType_Density;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    switch (chars[1])
                      {
                        case 'o':
                            if ((String.Compare(chars, 2, "rce", 0, 3, false) == 0) && (chars.Length == 5))
                                return TypeUnitTypeKnownValues.UnitType_Force;
                            break;
                        case 'r':
                            if ((String.Compare(chars, 2, "equency", 0, 7, false) == 0) && (chars.Length == 9))
                                return TypeUnitTypeKnownValues.UnitType_Frequency;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(chars, 1, "ength", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeUnitTypeKnownValues.UnitType_Length;
                    break;
                case 'M':
                    if ((String.Compare(chars, 1, "ass", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeUnitTypeKnownValues.UnitType_Mass;
                    break;
                case 'P':
                    switch (chars[1])
                      {
                        case 'o':
                            if ((String.Compare(chars, 2, "wer", 0, 3, false) == 0) && (chars.Length == 5))
                                return TypeUnitTypeKnownValues.UnitType_Power;
                            break;
                        case 'r':
                            if ((String.Compare(chars, 2, "essure", 0, 6, false) == 0) && (chars.Length == 8))
                                return TypeUnitTypeKnownValues.UnitType_Pressure;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "peed", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeUnitTypeKnownValues.UnitType_Speed;
                    break;
                case 'T':
                    switch (chars[1])
                      {
                        case 'e':
                            if ((String.Compare(chars, 2, "mperature", 0, 9, false) == 0) && (chars.Length == 11))
                                return TypeUnitTypeKnownValues.UnitType_Temperature;
                            break;
                        case 'i':
                            if ((String.Compare(chars, 2, "me", 0, 2, false) == 0) && (chars.Length == 4))
                                return TypeUnitTypeKnownValues.UnitType_Time;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeUnitTypeKnownValues.UnitType_Unknown;
                    break;
                case 'V':
                    if ((String.Compare(chars, 1, "olume", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeUnitTypeKnownValues.UnitType_Volume;
                    break;
                case 'W':
                    if ((String.Compare(chars, 1, "ork", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeUnitTypeKnownValues.UnitType_Work;
                    break;
                default:
                    break;
              }
            return TypeUnitTypeKnownValues.UnitType__none;
          }

        public static string  stringFromUnitType(TypeUnitTypeKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeUnitTypeKnownValues.UnitType_Density:
                    return "Density";
                case TypeUnitTypeKnownValues.UnitType_Length:
                    return "Length";
                case TypeUnitTypeKnownValues.UnitType_Temperature:
                    return "Temperature";
                case TypeUnitTypeKnownValues.UnitType_Pressure:
                    return "Pressure";
                case TypeUnitTypeKnownValues.UnitType_Mass:
                    return "Mass";
                case TypeUnitTypeKnownValues.UnitType_Time:
                    return "Time";
                case TypeUnitTypeKnownValues.UnitType_Data:
                    return "Data";
                case TypeUnitTypeKnownValues.UnitType_Frequency:
                    return "Frequency";
                case TypeUnitTypeKnownValues.UnitType_Angles:
                    return "Angles";
                case TypeUnitTypeKnownValues.UnitType_Volume:
                    return "Volume";
                case TypeUnitTypeKnownValues.UnitType_Force:
                    return "Force";
                case TypeUnitTypeKnownValues.UnitType_Work:
                    return "Work";
                case TypeUnitTypeKnownValues.UnitType_Power:
                    return "Power";
                case TypeUnitTypeKnownValues.UnitType_Area:
                    return "Area";
                case TypeUnitTypeKnownValues.UnitType_Speed:
                    return "Speed";
                case TypeUnitTypeKnownValues.UnitType_Acceleration:
                    return "Acceleration";
                case TypeUnitTypeKnownValues.UnitType_Unknown:
                    return "Unknown";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasUnit;
        private string storeUnit;
        private bool flagHasUnitType;
        private TypeUnitType storeUnitType;
        private bool flagHasSingularName;
        private string storeSingularName;
        private bool flagHasPluralName;
        private string storePluralName;
        private bool flagHasAbbreviatedName;
        private string storeAbbreviatedName;
        private bool flagHasValue;
        private double storeValue;
        private string textStoreValue;


        private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Unit of TypeReferencePointJSON is not a string.");
            setUnit(json_string.getData());
          }


        private void  fromJSONUnitType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field UnitType of TypeReferencePointJSON is not a string.");
            TypeUnitType the_open_enum = new TypeUnitType();
            switch (json_string.getData()[0])
              {
                case 'A':
                    switch (json_string.getData()[1])
                      {
                        case 'c':
                            if ((String.Compare(json_string.getData(), 2, "celeration", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Acceleration;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'n':
                            if ((String.Compare(json_string.getData(), 2, "gles", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Angles;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'r':
                            if ((String.Compare(json_string.getData(), 2, "ea", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Area;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    switch (json_string.getData()[1])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 2, "ta", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Data;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'e':
                            if ((String.Compare(json_string.getData(), 2, "nsity", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Density;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    switch (json_string.getData()[1])
                      {
                        case 'o':
                            if ((String.Compare(json_string.getData(), 2, "rce", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Force;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'r':
                            if ((String.Compare(json_string.getData(), 2, "equency", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Frequency;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(json_string.getData(), 1, "ength", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Length;
                            goto open_enum_is_done;
                          }
                    break;
                case 'M':
                    if ((String.Compare(json_string.getData(), 1, "ass", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Mass;
                            goto open_enum_is_done;
                          }
                    break;
                case 'P':
                    switch (json_string.getData()[1])
                      {
                        case 'o':
                            if ((String.Compare(json_string.getData(), 2, "wer", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Power;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'r':
                            if ((String.Compare(json_string.getData(), 2, "essure", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Pressure;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "peed", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Speed;
                            goto open_enum_is_done;
                          }
                    break;
                case 'T':
                    switch (json_string.getData()[1])
                      {
                        case 'e':
                            if ((String.Compare(json_string.getData(), 2, "mperature", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Temperature;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'i':
                            if ((String.Compare(json_string.getData(), 2, "me", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Time;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Unknown;
                            goto open_enum_is_done;
                          }
                    break;
                case 'V':
                    if ((String.Compare(json_string.getData(), 1, "olume", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Volume;
                            goto open_enum_is_done;
                          }
                    break;
                case 'W':
                    if ((String.Compare(json_string.getData(), 1, "ork", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeUnitTypeKnownValues.UnitType_Work;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setUnitType(the_open_enum);
          }


        private void  fromJSONSingularName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SingularName of TypeReferencePointJSON is not a string.");
            setSingularName(json_string.getData());
          }


        private void  fromJSONPluralName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PluralName of TypeReferencePointJSON is not a string.");
            setPluralName(json_string.getData());
          }


        private void  fromJSONAbbreviatedName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AbbreviatedName of TypeReferencePointJSON is not a string.");
            setAbbreviatedName(json_string.getData());
          }


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
                    throw new Exception("The value for field Value of TypeReferencePointJSON is not a number.");
                  }
              }
            setValueText(the_rational_text);
          }


        public TypeReferencePointJSON()
          {
            flagHasUnit = false;
            flagHasUnitType = false;
            flagHasSingularName = false;
            flagHasPluralName = false;
            flagHasAbbreviatedName = false;
            flagHasValue = false;
          }

        public bool  hasUnit()
          {
            return flagHasUnit;
          }

        public string  getUnit()
          {
            Debug.Assert(flagHasUnit);
            return storeUnit;
          }

        public bool  hasUnitType()
          {
            return flagHasUnitType;
          }

        public TypeUnitType  getUnitType()
          {
            Debug.Assert(flagHasUnitType);
            return storeUnitType;
          }

        public string  getUnitTypeAsString()
          {
            TypeUnitType result = getUnitType();
            if (result.in_known_list)
                return stringFromUnitType(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasSingularName()
          {
            return flagHasSingularName;
          }

        public string  getSingularName()
          {
            Debug.Assert(flagHasSingularName);
            return storeSingularName;
          }

        public bool  hasPluralName()
          {
            return flagHasPluralName;
          }

        public string  getPluralName()
          {
            Debug.Assert(flagHasPluralName);
            return storePluralName;
          }

        public bool  hasAbbreviatedName()
          {
            return flagHasAbbreviatedName;
          }

        public string  getAbbreviatedName()
          {
            Debug.Assert(flagHasAbbreviatedName);
            return storeAbbreviatedName;
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



        public void setUnit(string new_value)
          {
            flagHasUnit = true;
            storeUnit = new_value;
          }
        public void unsetUnit()
          {
            flagHasUnit = false;
          }
        public void setUnitType(TypeUnitType new_value)
          {
            flagHasUnitType = true;
            storeUnitType = new_value;
          }
        public void setUnitType(string chars)
          {
            TypeUnitTypeKnownValues known = stringToUnitType(chars);
            TypeUnitType new_value = new TypeUnitType();
            if (known == TypeUnitTypeKnownValues.UnitType__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setUnitType(new_value);
          }
        public void setUnitType(TypeUnitTypeKnownValues new_value)
          {
            TypeUnitType new_full_value = new TypeUnitType();
            Debug.Assert(new_value != TypeUnitTypeKnownValues.UnitType__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setUnitType(new_full_value);
          }
        public void unsetUnitType()
          {
            flagHasUnitType = false;
          }
        public void setSingularName(string new_value)
          {
            flagHasSingularName = true;
            storeSingularName = new_value;
          }
        public void unsetSingularName()
          {
            flagHasSingularName = false;
          }
        public void setPluralName(string new_value)
          {
            flagHasPluralName = true;
            storePluralName = new_value;
          }
        public void unsetPluralName()
          {
            flagHasPluralName = false;
          }
        public void setAbbreviatedName(string new_value)
          {
            flagHasAbbreviatedName = true;
            storeAbbreviatedName = new_value;
          }
        public void unsetAbbreviatedName()
          {
            flagHasAbbreviatedName = false;
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
                throw new Exception("The text value for field Value of TypeReferencePointJSON is not a valid number.");
            textStoreValue = new_value;
          }
        public void unsetValue()
          {
            flagHasValue = false;
          }


        public override void write_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler);
            handler.finish_object();
          }

        public virtual void write_fields_as_json(JSONHandler handler)
          {
            write_fields_as_json(handler, false);
          }

        public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
          {
            Debug.Assert(partial_allowed || flagHasUnit);
            if (flagHasUnit)
              {
                handler.start_pair("Unit");
                handler.string_value(storeUnit);
              }
            Debug.Assert(partial_allowed || flagHasUnitType);
            if (flagHasUnitType)
              {
                handler.start_pair("UnitType");
                if (storeUnitType.in_known_list)
                  {
                    switch (storeUnitType.list_value)
                      {
                        case TypeUnitTypeKnownValues.UnitType_Density:
                            handler.string_value("Density");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Length:
                            handler.string_value("Length");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Temperature:
                            handler.string_value("Temperature");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Pressure:
                            handler.string_value("Pressure");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Mass:
                            handler.string_value("Mass");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Time:
                            handler.string_value("Time");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Data:
                            handler.string_value("Data");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Frequency:
                            handler.string_value("Frequency");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Angles:
                            handler.string_value("Angles");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Volume:
                            handler.string_value("Volume");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Force:
                            handler.string_value("Force");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Work:
                            handler.string_value("Work");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Power:
                            handler.string_value("Power");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Area:
                            handler.string_value("Area");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Speed:
                            handler.string_value("Speed");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Acceleration:
                            handler.string_value("Acceleration");
                            break;
                        case TypeUnitTypeKnownValues.UnitType_Unknown:
                            handler.string_value("Unknown");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeUnitType.string_value);
                  }
              }
            Debug.Assert(partial_allowed || flagHasSingularName);
            if (flagHasSingularName)
              {
                handler.start_pair("SingularName");
                handler.string_value(storeSingularName);
              }
            Debug.Assert(partial_allowed || flagHasPluralName);
            if (flagHasPluralName)
              {
                handler.start_pair("PluralName");
                handler.string_value(storePluralName);
              }
            if (flagHasAbbreviatedName)
              {
                handler.start_pair("AbbreviatedName");
                handler.string_value(storeAbbreviatedName);
              }
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
          }
        public override void write_partial_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler, true);
            handler.finish_object();
          }
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasUnit()))
              {
                return "When parsing the object for %what%, the \"Unit\" field was missing.";
              }
            if (!(hasUnitType()))
              {
                return "When parsing the object for %what%, the \"UnitType\" field was missing.";
              }
            if (!(hasSingularName()))
              {
                return "When parsing the object for %what%, the \"SingularName\" field was missing.";
              }
            if (!(hasPluralName()))
              {
                return "When parsing the object for %what%, the \"PluralName\" field was missing.";
              }
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeReferencePointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeReferencePointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeReferencePoint", ignore_extras);
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
        public static TypeReferencePointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeReferencePointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeReferencePointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeReferencePoint", ignore_extras);
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
        public static TypeReferencePointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeReferencePointJSON from_text(string text, bool ignore_extras)
          {
            TypeReferencePointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeReferencePoint", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeReferencePointJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeReferencePointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeReferencePointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeReferencePoint", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorUnit;
        private abstract class FieldGeneratorUnitType : JSONStringGenerator
              {
                protected FieldGeneratorUnitType(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorUnitType()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeUnitTypeKnownValues known = stringToUnitType(result);
                    TypeUnitType new_value = new TypeUnitType();
                    if (known == TypeUnitTypeKnownValues.UnitType__none)
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
                protected abstract void handle_result(TypeUnitType result);
              };
        private class FieldHoldingGeneratorUnitType : FieldGeneratorUnitType
      {
        protected override void handle_result(TypeUnitType result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorUnitType(String what)
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
        public TypeUnitType value;
      };
        private class FieldHoldingArrayGeneratorUnitType : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorUnitType
          {
            private FieldHoldingArrayGeneratorUnitType top;

            protected override void handle_result(TypeUnitType result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorUnitType init_top)
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
        protected virtual void handle_result(List<TypeUnitType> result)
          {
          }

        public FieldHoldingArrayGeneratorUnitType(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnitType>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorUnitType()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnitType>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeUnitType> value;
      };
            private FieldHoldingGeneratorUnitType fieldGeneratorUnitType;
            private JSONHoldingStringGenerator fieldGeneratorSingularName;
            private JSONHoldingStringGenerator fieldGeneratorPluralName;
            private JSONHoldingStringGenerator fieldGeneratorAbbreviatedName;
            private JSONHoldingNumberTextGenerator fieldGeneratorValue;

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
                string message = "";
                message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
                throw new Exception(message);
              }
            protected override void finish_field(string field_name, JSONHandler field_handler)
              {
              }
            protected override void finish()
              {
                TypeReferencePointJSON result = new TypeReferencePointJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeReferencePointJSON result)
              {
                if (fieldGeneratorUnit.have_value)
                  {
                    result.setUnit(fieldGeneratorUnit.value);
                    fieldGeneratorUnit.have_value = false;
                  }
                else if ((!(result.hasUnit())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Unit\" field was missing.");
                  }
                if (fieldGeneratorUnitType.have_value)
                  {
                    result.setUnitType(fieldGeneratorUnitType.value);
                    fieldGeneratorUnitType.have_value = false;
                  }
                else if ((!(result.hasUnitType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"UnitType\" field was missing.");
                  }
                if (fieldGeneratorSingularName.have_value)
                  {
                    result.setSingularName(fieldGeneratorSingularName.value);
                    fieldGeneratorSingularName.have_value = false;
                  }
                else if ((!(result.hasSingularName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SingularName\" field was missing.");
                  }
                if (fieldGeneratorPluralName.have_value)
                  {
                    result.setPluralName(fieldGeneratorPluralName.value);
                    fieldGeneratorPluralName.have_value = false;
                  }
                else if ((!(result.hasPluralName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"PluralName\" field was missing.");
                  }
                if (fieldGeneratorAbbreviatedName.have_value)
                  {
                    result.setAbbreviatedName(fieldGeneratorAbbreviatedName.value);
                    fieldGeneratorAbbreviatedName.have_value = false;
                  }
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValueText(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeReferencePointJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "bbreviatedName", 0, 14, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorAbbreviatedName;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "luralName", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorPluralName;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "ingularName", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorSingularName;
                        break;
                    case 'U':
                        if (String.Compare(field_name, 1, "nit", 0, 3, false) == 0)
                          {
                            if (field_name.Length == 4)
                              {
                                return fieldGeneratorUnit;
                              }
                            switch (field_name[4])
                              {
                                case 'T':
                                    if ((String.Compare(field_name, 5, "ype", 0, 3, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorUnitType;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorUnit = new JSONHoldingStringGenerator("field \"Unit\" of the TypeReferencePoint class");
                fieldGeneratorUnitType = new FieldHoldingGeneratorUnitType("field \"UnitType\" of the TypeReferencePoint class");
                fieldGeneratorSingularName = new JSONHoldingStringGenerator("field \"SingularName\" of the TypeReferencePoint class");
                fieldGeneratorPluralName = new JSONHoldingStringGenerator("field \"PluralName\" of the TypeReferencePoint class");
                fieldGeneratorAbbreviatedName = new JSONHoldingStringGenerator("field \"AbbreviatedName\" of the TypeReferencePoint class");
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeReferencePoint class");
                set_what("the TypeReferencePoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorUnit = new JSONHoldingStringGenerator("field \"Unit\" of the TypeReferencePoint class");
                fieldGeneratorUnitType = new FieldHoldingGeneratorUnitType("field \"UnitType\" of the TypeReferencePoint class");
                fieldGeneratorSingularName = new JSONHoldingStringGenerator("field \"SingularName\" of the TypeReferencePoint class");
                fieldGeneratorPluralName = new JSONHoldingStringGenerator("field \"PluralName\" of the TypeReferencePoint class");
                fieldGeneratorAbbreviatedName = new JSONHoldingStringGenerator("field \"AbbreviatedName\" of the TypeReferencePoint class");
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeReferencePoint class");
                set_what("the TypeReferencePoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorUnit.reset();
                fieldGeneratorUnitType.reset();
                fieldGeneratorSingularName.reset();
                fieldGeneratorPluralName.reset();
                fieldGeneratorAbbreviatedName.reset();
                fieldGeneratorValue.reset();
                base.reset();
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
            protected override void handle_result(TypeReferencePointJSON  result)
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
            public TypeReferencePointJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeReferencePointJSON  result)
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
        protected virtual void handle_result(List<TypeReferencePointJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeReferencePointJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeReferencePointJSON>();
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
        public List<TypeReferencePointJSON> value;
      };
      };
    private bool flagHasConversionType;
    private TypeConversionType storeConversionType;
    private bool flagHasDisplayTitle;
    private string storeDisplayTitle;
    private bool flagHasDisplayDescription;
    private string storeDisplayDescription;
    private bool flagHasInputValue;
    private List< MeasuredAmountJSON  > storeInputValue;
    private bool flagHasOutputValue;
    private List< MeasuredAmountJSON  > storeOutputValue;
    private bool flagHasReferencePoint;
    private TypeReferencePointJSON  storeReferencePoint;


    private void  fromJSONConversionType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConversionType of UnitConversionJSON is not a string.");
        TypeConversionType the_open_enum = new TypeConversionType();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'c':
                        if ((String.Compare(json_string.getData(), 2, "celeration", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Acceleration;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "gles", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Angles;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "ea", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Area;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ata", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Data;
                        goto open_enum_is_done;
                      }
                break;
            case 'F':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "rce", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Force;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "equency", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Frequency;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ength", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Length;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if (String.Compare(json_string.getData(), 1, "ass", 0, 3, false) == 0)
                  {
                    if (json_string.getData().Length == 4)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Mass;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[4])
                      {
                        case 'T':
                            if ((String.Compare(json_string.getData(), 5, "oVolume", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_MassToVolume;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "wer", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Power;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "essure", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Pressure;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "peed", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Speed;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "mperature", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Temperature;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "me", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Time;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Unknown;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                if (String.Compare(json_string.getData(), 1, "olume", 0, 5, false) == 0)
                  {
                    if (json_string.getData().Length == 6)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Volume;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[6])
                      {
                        case 'T':
                            if ((String.Compare(json_string.getData(), 7, "oMass", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_VolumeToMass;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "ork", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeConversionTypeKnownValues.ConversionType_Work;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setConversionType(the_open_enum);
      }


    private void  fromJSONDisplayTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayTitle of UnitConversionJSON is not a string.");
        setDisplayTitle(json_string.getData());
      }


    private void  fromJSONDisplayDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayDescription of UnitConversionJSON is not a string.");
        setDisplayDescription(json_string.getData());
      }


    private void  fromJSONInputValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputValue of UnitConversionJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field InputValue of UnitConversionJSON has too few elements.");
        List< MeasuredAmountJSON  > vector_InputValue1 = new List< MeasuredAmountJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MeasuredAmountJSON convert_classy = MeasuredAmountJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InputValue1.Add(convert_classy);
          }
        Debug.Assert(vector_InputValue1.Count >= 1);
        initInputValue();
        for (int num1 = 0; num1 < vector_InputValue1.Count; ++num1)
            appendInputValue(vector_InputValue1[num1]);
        for (int num1 = 0; num1 < vector_InputValue1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOutputValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OutputValue of UnitConversionJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field OutputValue of UnitConversionJSON has too few elements.");
        List< MeasuredAmountJSON  > vector_OutputValue1 = new List< MeasuredAmountJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MeasuredAmountJSON convert_classy = MeasuredAmountJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_OutputValue1.Add(convert_classy);
          }
        Debug.Assert(vector_OutputValue1.Count >= 1);
        initOutputValue();
        for (int num2 = 0; num2 < vector_OutputValue1.Count; ++num2)
            appendOutputValue(vector_OutputValue1[num2]);
        for (int num1 = 0; num1 < vector_OutputValue1.Count; ++num1)
          {
          }
      }


    private void  fromJSONReferencePoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeReferencePointJSON convert_classy = TypeReferencePointJSON.from_json(json_value, ignore_extras, true);
        setReferencePoint(convert_classy);
      }


    public UnitConversionJSON()
      {
        flagHasConversionType = false;
        flagHasDisplayTitle = false;
        flagHasDisplayDescription = false;
        flagHasInputValue = false;
        flagHasOutputValue = false;
        flagHasReferencePoint = false;
        storeInputValue = new List< MeasuredAmountJSON  >();
        storeOutputValue = new List< MeasuredAmountJSON  >();
      }

    public bool  hasConversionType()
      {
        return flagHasConversionType;
      }

    public TypeConversionType  getConversionType()
      {
        Debug.Assert(flagHasConversionType);
        return storeConversionType;
      }

    public string  getConversionTypeAsString()
      {
        TypeConversionType result = getConversionType();
        if (result.in_known_list)
            return stringFromConversionType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasDisplayTitle()
      {
        return flagHasDisplayTitle;
      }

    public string  getDisplayTitle()
      {
        Debug.Assert(flagHasDisplayTitle);
        return storeDisplayTitle;
      }

    public bool  hasDisplayDescription()
      {
        return flagHasDisplayDescription;
      }

    public string  getDisplayDescription()
      {
        Debug.Assert(flagHasDisplayDescription);
        return storeDisplayDescription;
      }

    public bool  hasInputValue()
      {
        return flagHasInputValue;
      }

    public int  countOfInputValue()
      {
        Debug.Assert(flagHasInputValue);
        return storeInputValue.Count;
      }

    public MeasuredAmountJSON   elementOfInputValue(int element_num)
      {
        Debug.Assert(flagHasInputValue);
        return storeInputValue[element_num];
      }

    public List< MeasuredAmountJSON  >  getInputValue()
      {
        Debug.Assert(flagHasInputValue);
        return storeInputValue;
      }

    public bool  hasOutputValue()
      {
        return flagHasOutputValue;
      }

    public int  countOfOutputValue()
      {
        Debug.Assert(flagHasOutputValue);
        return storeOutputValue.Count;
      }

    public MeasuredAmountJSON   elementOfOutputValue(int element_num)
      {
        Debug.Assert(flagHasOutputValue);
        return storeOutputValue[element_num];
      }

    public List< MeasuredAmountJSON  >  getOutputValue()
      {
        Debug.Assert(flagHasOutputValue);
        return storeOutputValue;
      }

    public bool  hasReferencePoint()
      {
        return flagHasReferencePoint;
      }

    public TypeReferencePointJSON   getReferencePoint()
      {
        Debug.Assert(flagHasReferencePoint);
        return storeReferencePoint;
      }



    public void setConversionType(TypeConversionType new_value)
      {
        flagHasConversionType = true;
        storeConversionType = new_value;
      }
    public void setConversionType(string chars)
      {
        TypeConversionTypeKnownValues known = stringToConversionType(chars);
        TypeConversionType new_value = new TypeConversionType();
        if (known == TypeConversionTypeKnownValues.ConversionType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setConversionType(new_value);
      }
    public void setConversionType(TypeConversionTypeKnownValues new_value)
      {
        TypeConversionType new_full_value = new TypeConversionType();
        Debug.Assert(new_value != TypeConversionTypeKnownValues.ConversionType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setConversionType(new_full_value);
      }
    public void unsetConversionType()
      {
        flagHasConversionType = false;
      }
    public void setDisplayTitle(string new_value)
      {
        flagHasDisplayTitle = true;
        storeDisplayTitle = new_value;
      }
    public void unsetDisplayTitle()
      {
        flagHasDisplayTitle = false;
      }
    public void setDisplayDescription(string new_value)
      {
        flagHasDisplayDescription = true;
        storeDisplayDescription = new_value;
      }
    public void unsetDisplayDescription()
      {
        flagHasDisplayDescription = false;
      }
    public void initInputValue()
      {
        if (flagHasInputValue)
          {
            for (int num1 = 0; num1 < storeInputValue.Count; ++num1)
              {
              }
          }
        flagHasInputValue = true;
        storeInputValue.Clear();
      }
    public void appendInputValue(MeasuredAmountJSON  to_append)
      {
        if (!flagHasInputValue)
          {
            flagHasInputValue = true;
            storeInputValue.Clear();
          }
        Debug.Assert(flagHasInputValue);
        storeInputValue.Add(to_append);
      }
    public void unsetInputValue()
      {
        if (flagHasInputValue)
          {
            for (int num2 = 0; num2 < storeInputValue.Count; ++num2)
              {
              }
          }
        flagHasInputValue = false;
        storeInputValue.Clear();
      }
    public void initOutputValue()
      {
        if (flagHasOutputValue)
          {
            for (int num3 = 0; num3 < storeOutputValue.Count; ++num3)
              {
              }
          }
        flagHasOutputValue = true;
        storeOutputValue.Clear();
      }
    public void appendOutputValue(MeasuredAmountJSON  to_append)
      {
        if (!flagHasOutputValue)
          {
            flagHasOutputValue = true;
            storeOutputValue.Clear();
          }
        Debug.Assert(flagHasOutputValue);
        storeOutputValue.Add(to_append);
      }
    public void unsetOutputValue()
      {
        if (flagHasOutputValue)
          {
            for (int num4 = 0; num4 < storeOutputValue.Count; ++num4)
              {
              }
          }
        flagHasOutputValue = false;
        storeOutputValue.Clear();
      }
    public void setReferencePoint(TypeReferencePointJSON  new_value)
      {
        if (flagHasReferencePoint)
          {
          }
        flagHasReferencePoint = true;
        storeReferencePoint = new_value;
      }
    public void unsetReferencePoint()
      {
        if (flagHasReferencePoint)
          {
          }
        flagHasReferencePoint = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasConversionType);
        if (flagHasConversionType)
          {
            handler.start_pair("ConversionType");
            if (storeConversionType.in_known_list)
              {
                switch (storeConversionType.list_value)
                  {
                    case TypeConversionTypeKnownValues.ConversionType_MassToVolume:
                        handler.string_value("MassToVolume");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_VolumeToMass:
                        handler.string_value("VolumeToMass");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Length:
                        handler.string_value("Length");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Temperature:
                        handler.string_value("Temperature");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Pressure:
                        handler.string_value("Pressure");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Mass:
                        handler.string_value("Mass");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Time:
                        handler.string_value("Time");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Data:
                        handler.string_value("Data");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Frequency:
                        handler.string_value("Frequency");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Angles:
                        handler.string_value("Angles");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Volume:
                        handler.string_value("Volume");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Force:
                        handler.string_value("Force");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Work:
                        handler.string_value("Work");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Power:
                        handler.string_value("Power");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Area:
                        handler.string_value("Area");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Speed:
                        handler.string_value("Speed");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Acceleration:
                        handler.string_value("Acceleration");
                        break;
                    case TypeConversionTypeKnownValues.ConversionType_Unknown:
                        handler.string_value("Unknown");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeConversionType.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasDisplayTitle);
        if (flagHasDisplayTitle)
          {
            handler.start_pair("DisplayTitle");
            handler.string_value(storeDisplayTitle);
          }
        if (flagHasDisplayDescription)
          {
            handler.start_pair("DisplayDescription");
            handler.string_value(storeDisplayDescription);
          }
        Debug.Assert(partial_allowed || flagHasInputValue);
        if (flagHasInputValue)
          {
            handler.start_pair("InputValue");
            Debug.Assert(storeInputValue.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeInputValue.Count; ++num1)
              {
                if (partial_allowed)
                    storeInputValue[num1].write_partial_as_json(handler);
                else
                    storeInputValue[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasOutputValue);
        if (flagHasOutputValue)
          {
            handler.start_pair("OutputValue");
            Debug.Assert(storeOutputValue.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeOutputValue.Count; ++num2)
              {
                if (partial_allowed)
                    storeOutputValue[num2].write_partial_as_json(handler);
                else
                    storeOutputValue[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasReferencePoint)
          {
            handler.start_pair("ReferencePoint");
            if (partial_allowed)
                storeReferencePoint.write_partial_as_json(handler);
            else
                storeReferencePoint.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasConversionType()))
          {
            return "When parsing the object for %what%, the \"ConversionType\" field was missing.";
          }
        if (!(hasDisplayTitle()))
          {
            return "When parsing the object for %what%, the \"DisplayTitle\" field was missing.";
          }
        if (!(hasInputValue()))
          {
            return "When parsing the object for %what%, the \"InputValue\" field was missing.";
          }
        if (!(hasOutputValue()))
          {
            return "When parsing the object for %what%, the \"OutputValue\" field was missing.";
          }
        return null;
      }

    public static UnitConversionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitConversionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConversion", ignore_extras);
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
    public static UnitConversionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UnitConversionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitConversionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConversion", ignore_extras);
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
    public static UnitConversionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UnitConversionJSON from_text(string text, bool ignore_extras)
      {
        UnitConversionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConversion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UnitConversionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UnitConversionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UnitConversionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConversion", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorConversionType : JSONStringGenerator
          {
            protected FieldGeneratorConversionType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorConversionType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeConversionTypeKnownValues known = stringToConversionType(result);
                TypeConversionType new_value = new TypeConversionType();
                if (known == TypeConversionTypeKnownValues.ConversionType__none)
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
            protected abstract void handle_result(TypeConversionType result);
          };
    private class FieldHoldingGeneratorConversionType : FieldGeneratorConversionType
  {
    protected override void handle_result(TypeConversionType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorConversionType(String what)
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
    public TypeConversionType value;
  };
    private class FieldHoldingArrayGeneratorConversionType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorConversionType
      {
        private FieldHoldingArrayGeneratorConversionType top;

        protected override void handle_result(TypeConversionType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorConversionType init_top)
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
    protected virtual void handle_result(List<TypeConversionType> result)
      {
      }

    public FieldHoldingArrayGeneratorConversionType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeConversionType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorConversionType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeConversionType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeConversionType> value;
  };
        private FieldHoldingGeneratorConversionType fieldGeneratorConversionType;
        private JSONHoldingStringGenerator fieldGeneratorDisplayTitle;
        private JSONHoldingStringGenerator fieldGeneratorDisplayDescription;
        private MeasuredAmountJSON.HoldingArrayGenerator fieldGeneratorInputValue;
        private MeasuredAmountJSON.HoldingArrayGenerator fieldGeneratorOutputValue;
        private TypeReferencePointJSON.HoldingGenerator fieldGeneratorReferencePoint;

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
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            UnitConversionJSON result = new UnitConversionJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(UnitConversionJSON result)
          {
            if (fieldGeneratorConversionType.have_value)
              {
                result.setConversionType(fieldGeneratorConversionType.value);
                fieldGeneratorConversionType.have_value = false;
              }
            else if ((!(result.hasConversionType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ConversionType\" field was missing.");
              }
            if (fieldGeneratorDisplayTitle.have_value)
              {
                result.setDisplayTitle(fieldGeneratorDisplayTitle.value);
                fieldGeneratorDisplayTitle.have_value = false;
              }
            else if ((!(result.hasDisplayTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DisplayTitle\" field was missing.");
              }
            if (fieldGeneratorDisplayDescription.have_value)
              {
                result.setDisplayDescription(fieldGeneratorDisplayDescription.value);
                fieldGeneratorDisplayDescription.have_value = false;
              }
            if (fieldGeneratorInputValue.have_value)
              {
                result.initInputValue();
                int count = fieldGeneratorInputValue.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInputValue(fieldGeneratorInputValue.value[num]);
                  }
                fieldGeneratorInputValue.value.Clear();
                fieldGeneratorInputValue.have_value = false;
              }
            else if ((!(result.hasInputValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InputValue\" field was missing.");
              }
            if (fieldGeneratorOutputValue.have_value)
              {
                result.initOutputValue();
                int count = fieldGeneratorOutputValue.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOutputValue(fieldGeneratorOutputValue.value[num]);
                  }
                fieldGeneratorOutputValue.value.Clear();
                fieldGeneratorOutputValue.have_value = false;
              }
            else if ((!(result.hasOutputValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OutputValue\" field was missing.");
              }
            if (fieldGeneratorReferencePoint.have_value)
              {
                result.setReferencePoint(fieldGeneratorReferencePoint.value);
                fieldGeneratorReferencePoint.have_value = false;
              }
          }
        protected abstract void handle_result(UnitConversionJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "onversionType", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorConversionType;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "isplay", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 8, "escription", 0, 10, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorDisplayDescription;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "itle", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorDisplayTitle;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nputValue", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorInputValue;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utputValue", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorOutputValue;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eferencePoint", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorReferencePoint;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorConversionType = new FieldHoldingGeneratorConversionType("field \"ConversionType\" of the UnitConversion class");
            fieldGeneratorDisplayTitle = new JSONHoldingStringGenerator("field \"DisplayTitle\" of the UnitConversion class");
            fieldGeneratorDisplayDescription = new JSONHoldingStringGenerator("field \"DisplayDescription\" of the UnitConversion class");
            fieldGeneratorInputValue = new MeasuredAmountJSON.HoldingArrayGenerator("field \"InputValue\" of the UnitConversion class", ignore_extras);
            fieldGeneratorOutputValue = new MeasuredAmountJSON.HoldingArrayGenerator("field \"OutputValue\" of the UnitConversion class", ignore_extras);
            fieldGeneratorReferencePoint = new TypeReferencePointJSON.HoldingGenerator("field \"ReferencePoint\" of the UnitConversion class", ignore_extras);
            set_what("the UnitConversion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorConversionType = new FieldHoldingGeneratorConversionType("field \"ConversionType\" of the UnitConversion class");
            fieldGeneratorDisplayTitle = new JSONHoldingStringGenerator("field \"DisplayTitle\" of the UnitConversion class");
            fieldGeneratorDisplayDescription = new JSONHoldingStringGenerator("field \"DisplayDescription\" of the UnitConversion class");
            fieldGeneratorInputValue = new MeasuredAmountJSON.HoldingArrayGenerator("field \"InputValue\" of the UnitConversion class", false);
            fieldGeneratorOutputValue = new MeasuredAmountJSON.HoldingArrayGenerator("field \"OutputValue\" of the UnitConversion class", false);
            fieldGeneratorReferencePoint = new TypeReferencePointJSON.HoldingGenerator("field \"ReferencePoint\" of the UnitConversion class", false);
            set_what("the UnitConversion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorConversionType.reset();
            fieldGeneratorDisplayTitle.reset();
            fieldGeneratorDisplayDescription.reset();
            fieldGeneratorInputValue.reset();
            fieldGeneratorOutputValue.reset();
            fieldGeneratorReferencePoint.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorInputValue.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputValue.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorReferencePoint.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorInputValue.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputValue.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorReferencePoint.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UnitConversionJSON  result)
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
        public UnitConversionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UnitConversionJSON  result)
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
    protected virtual void handle_result(List<UnitConversionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UnitConversionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UnitConversionJSON>();
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
    public List<UnitConversionJSON> value;
  };
  };
