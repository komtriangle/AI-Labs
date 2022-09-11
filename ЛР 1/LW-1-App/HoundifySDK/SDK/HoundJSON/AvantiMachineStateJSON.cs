/* file "AvantiMachineStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AvantiMachineStateJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_PoweredOff,
        Value_PoweredOnInStandby,
        Value_WaterCircuitNeedsPriming,
        Value_WarmingUp,
        Value_SelfCleaningBeforeBrew,
        Value_ReadyToBrew,
        Value_DispensingSingleEspresso,
        Value_DispensingSingleCoffee,
        Value_DispensingDoubleEspresso,
        Value_DispensingDoubleCoffee,
        Value_DispensingHotWater,
        Value_DispensingSteam,
        Value_NeedsBeans,
        Value_NeedsWater,
        Value_NeedsDregsCleaned,
        Value_Descaling,
        Value_Warning,
        Value_Unknown
      };

    public static TypeValue  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "scaling", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValue.Value_Descaling;
                        break;
                    case 'i':
                        if (String.Compare(chars, 2, "spensing", 0, 8, false) == 0)
                          {
                            switch (chars[10])
                              {
                                case 'D':
                                    if (String.Compare(chars, 11, "ouble", 0, 5, false) == 0)
                                      {
                                        switch (chars[16])
                                          {
                                            case 'C':
                                                if ((String.Compare(chars, 17, "offee", 0, 5, false) == 0) && (chars.Length == 22))
                                                    return TypeValue.Value_DispensingDoubleCoffee;
                                                break;
                                            case 'E':
                                                if ((String.Compare(chars, 17, "spresso", 0, 7, false) == 0) && (chars.Length == 24))
                                                    return TypeValue.Value_DispensingDoubleEspresso;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'H':
                                    if ((String.Compare(chars, 11, "otWater", 0, 7, false) == 0) && (chars.Length == 18))
                                        return TypeValue.Value_DispensingHotWater;
                                    break;
                                case 'S':
                                    switch (chars[11])
                                      {
                                        case 'i':
                                            if (String.Compare(chars, 12, "ngle", 0, 4, false) == 0)
                                              {
                                                switch (chars[16])
                                                  {
                                                    case 'C':
                                                        if ((String.Compare(chars, 17, "offee", 0, 5, false) == 0) && (chars.Length == 22))
                                                            return TypeValue.Value_DispensingSingleCoffee;
                                                        break;
                                                    case 'E':
                                                        if ((String.Compare(chars, 17, "spresso", 0, 7, false) == 0) && (chars.Length == 24))
                                                            return TypeValue.Value_DispensingSingleEspresso;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 't':
                                            if ((String.Compare(chars, 12, "eam", 0, 3, false) == 0) && (chars.Length == 15))
                                                return TypeValue.Value_DispensingSteam;
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
                break;
            case 'N':
                if (String.Compare(chars, 1, "eeds", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'B':
                            if ((String.Compare(chars, 6, "eans", 0, 4, false) == 0) && (chars.Length == 10))
                                return TypeValue.Value_NeedsBeans;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 6, "regsCleaned", 0, 11, false) == 0) && (chars.Length == 17))
                                return TypeValue.Value_NeedsDregsCleaned;
                            break;
                        case 'W':
                            if ((String.Compare(chars, 6, "ater", 0, 4, false) == 0) && (chars.Length == 10))
                                return TypeValue.Value_NeedsWater;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(chars, 1, "oweredO", 0, 7, false) == 0)
                  {
                    switch (chars[8])
                      {
                        case 'f':
                            if ((String.Compare(chars, 9, "f", 0, 1, false) == 0) && (chars.Length == 10))
                                return TypeValue.Value_PoweredOff;
                            break;
                        case 'n':
                            if ((String.Compare(chars, 9, "InStandby", 0, 9, false) == 0) && (chars.Length == 18))
                                return TypeValue.Value_PoweredOnInStandby;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(chars, 1, "eadyToBrew", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeValue.Value_ReadyToBrew;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "elfCleaningBeforeBrew", 0, 21, false) == 0) && (chars.Length == 22))
                    return TypeValue.Value_SelfCleaningBeforeBrew;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValue.Value_Unknown;
                break;
            case 'W':
                if (String.Compare(chars, 1, "a", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'r':
                            switch (chars[3])
                              {
                                case 'm':
                                    if ((String.Compare(chars, 4, "ingUp", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeValue.Value_WarmingUp;
                                    break;
                                case 'n':
                                    if ((String.Compare(chars, 4, "ing", 0, 3, false) == 0) && (chars.Length == 7))
                                        return TypeValue.Value_Warning;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 't':
                            if ((String.Compare(chars, 3, "erCircuitNeedsPriming", 0, 21, false) == 0) && (chars.Length == 24))
                                return TypeValue.Value_WaterCircuitNeedsPriming;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Value' is not one of the legal values.");
      }

    public static string  stringFromValue(TypeValue the_enum)
      {
        switch (the_enum)
          {
            case TypeValue.Value_PoweredOff:
                return "PoweredOff";
            case TypeValue.Value_PoweredOnInStandby:
                return "PoweredOnInStandby";
            case TypeValue.Value_WaterCircuitNeedsPriming:
                return "WaterCircuitNeedsPriming";
            case TypeValue.Value_WarmingUp:
                return "WarmingUp";
            case TypeValue.Value_SelfCleaningBeforeBrew:
                return "SelfCleaningBeforeBrew";
            case TypeValue.Value_ReadyToBrew:
                return "ReadyToBrew";
            case TypeValue.Value_DispensingSingleEspresso:
                return "DispensingSingleEspresso";
            case TypeValue.Value_DispensingSingleCoffee:
                return "DispensingSingleCoffee";
            case TypeValue.Value_DispensingDoubleEspresso:
                return "DispensingDoubleEspresso";
            case TypeValue.Value_DispensingDoubleCoffee:
                return "DispensingDoubleCoffee";
            case TypeValue.Value_DispensingHotWater:
                return "DispensingHotWater";
            case TypeValue.Value_DispensingSteam:
                return "DispensingSteam";
            case TypeValue.Value_NeedsBeans:
                return "NeedsBeans";
            case TypeValue.Value_NeedsWater:
                return "NeedsWater";
            case TypeValue.Value_NeedsDregsCleaned:
                return "NeedsDregsCleaned";
            case TypeValue.Value_Descaling:
                return "Descaling";
            case TypeValue.Value_Warning:
                return "Warning";
            case TypeValue.Value_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of AvantiMachineStateJSON is not a string.");
        TypeValue the_enum;
        switch (json_string.getData()[0])
          {
            case 'D':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "scaling", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_enum = TypeValue.Value_Descaling;
                                goto enum_is_done;
                              }
                        break;
                    case 'i':
                        if (String.Compare(json_string.getData(), 2, "spensing", 0, 8, false) == 0)
                          {
                            switch (json_string.getData()[10])
                              {
                                case 'D':
                                    if (String.Compare(json_string.getData(), 11, "ouble", 0, 5, false) == 0)
                                      {
                                        switch (json_string.getData()[16])
                                          {
                                            case 'C':
                                                if ((String.Compare(json_string.getData(), 17, "offee", 0, 5, false) == 0) && (json_string.getData().Length == 22))
                                                      {
                                                        the_enum = TypeValue.Value_DispensingDoubleCoffee;
                                                        goto enum_is_done;
                                                      }
                                                break;
                                            case 'E':
                                                if ((String.Compare(json_string.getData(), 17, "spresso", 0, 7, false) == 0) && (json_string.getData().Length == 24))
                                                      {
                                                        the_enum = TypeValue.Value_DispensingDoubleEspresso;
                                                        goto enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'H':
                                    if ((String.Compare(json_string.getData(), 11, "otWater", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_enum = TypeValue.Value_DispensingHotWater;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'S':
                                    switch (json_string.getData()[11])
                                      {
                                        case 'i':
                                            if (String.Compare(json_string.getData(), 12, "ngle", 0, 4, false) == 0)
                                              {
                                                switch (json_string.getData()[16])
                                                  {
                                                    case 'C':
                                                        if ((String.Compare(json_string.getData(), 17, "offee", 0, 5, false) == 0) && (json_string.getData().Length == 22))
                                                              {
                                                                the_enum = TypeValue.Value_DispensingSingleCoffee;
                                                                goto enum_is_done;
                                                              }
                                                        break;
                                                    case 'E':
                                                        if ((String.Compare(json_string.getData(), 17, "spresso", 0, 7, false) == 0) && (json_string.getData().Length == 24))
                                                              {
                                                                the_enum = TypeValue.Value_DispensingSingleEspresso;
                                                                goto enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 't':
                                            if ((String.Compare(json_string.getData(), 12, "eam", 0, 3, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_enum = TypeValue.Value_DispensingSteam;
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
                    default:
                        break;
                  }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "eeds", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'B':
                            if ((String.Compare(json_string.getData(), 6, "eans", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeValue.Value_NeedsBeans;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 6, "regsCleaned", 0, 11, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_enum = TypeValue.Value_NeedsDregsCleaned;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'W':
                            if ((String.Compare(json_string.getData(), 6, "ater", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeValue.Value_NeedsWater;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(json_string.getData(), 1, "oweredO", 0, 7, false) == 0)
                  {
                    switch (json_string.getData()[8])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 9, "f", 0, 1, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeValue.Value_PoweredOff;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if ((String.Compare(json_string.getData(), 9, "InStandby", 0, 9, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_enum = TypeValue.Value_PoweredOnInStandby;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "eadyToBrew", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeValue.Value_ReadyToBrew;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "elfCleaningBeforeBrew", 0, 21, false) == 0) && (json_string.getData().Length == 22))
                      {
                        the_enum = TypeValue.Value_SelfCleaningBeforeBrew;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeValue.Value_Unknown;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if (String.Compare(json_string.getData(), 1, "a", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'r':
                            switch (json_string.getData()[3])
                              {
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 4, "ingUp", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_enum = TypeValue.Value_WarmingUp;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'n':
                                    if ((String.Compare(json_string.getData(), 4, "ing", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                          {
                                            the_enum = TypeValue.Value_Warning;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 't':
                            if ((String.Compare(json_string.getData(), 3, "erCircuitNeedsPriming", 0, 21, false) == 0) && (json_string.getData().Length == 24))
                                  {
                                    the_enum = TypeValue.Value_WaterCircuitNeedsPriming;
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
        throw new Exception("The value for field Value of AvantiMachineStateJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public AvantiMachineStateJSON()
      {
        flagHasValue = false;
      }

    public AvantiMachineStateJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public AvantiMachineStateJSON(string init_value)
      {
        flagHasValue = true;
        storeValue = stringToValue(init_value);
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public string  getValueAsString()
      {
        return stringFromValue(getValue());
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        setValue(stringToValue(chars));
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_PoweredOff:
                handler.string_value("PoweredOff");
                break;
            case TypeValue.Value_PoweredOnInStandby:
                handler.string_value("PoweredOnInStandby");
                break;
            case TypeValue.Value_WaterCircuitNeedsPriming:
                handler.string_value("WaterCircuitNeedsPriming");
                break;
            case TypeValue.Value_WarmingUp:
                handler.string_value("WarmingUp");
                break;
            case TypeValue.Value_SelfCleaningBeforeBrew:
                handler.string_value("SelfCleaningBeforeBrew");
                break;
            case TypeValue.Value_ReadyToBrew:
                handler.string_value("ReadyToBrew");
                break;
            case TypeValue.Value_DispensingSingleEspresso:
                handler.string_value("DispensingSingleEspresso");
                break;
            case TypeValue.Value_DispensingSingleCoffee:
                handler.string_value("DispensingSingleCoffee");
                break;
            case TypeValue.Value_DispensingDoubleEspresso:
                handler.string_value("DispensingDoubleEspresso");
                break;
            case TypeValue.Value_DispensingDoubleCoffee:
                handler.string_value("DispensingDoubleCoffee");
                break;
            case TypeValue.Value_DispensingHotWater:
                handler.string_value("DispensingHotWater");
                break;
            case TypeValue.Value_DispensingSteam:
                handler.string_value("DispensingSteam");
                break;
            case TypeValue.Value_NeedsBeans:
                handler.string_value("NeedsBeans");
                break;
            case TypeValue.Value_NeedsWater:
                handler.string_value("NeedsWater");
                break;
            case TypeValue.Value_NeedsDregsCleaned:
                handler.string_value("NeedsDregsCleaned");
                break;
            case TypeValue.Value_Descaling:
                handler.string_value("Descaling");
                break;
            case TypeValue.Value_Warning:
                handler.string_value("Warning");
                break;
            case TypeValue.Value_Unknown:
                handler.string_value("Unknown");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_PoweredOff:
                handler.string_value("PoweredOff");
                break;
            case TypeValue.Value_PoweredOnInStandby:
                handler.string_value("PoweredOnInStandby");
                break;
            case TypeValue.Value_WaterCircuitNeedsPriming:
                handler.string_value("WaterCircuitNeedsPriming");
                break;
            case TypeValue.Value_WarmingUp:
                handler.string_value("WarmingUp");
                break;
            case TypeValue.Value_SelfCleaningBeforeBrew:
                handler.string_value("SelfCleaningBeforeBrew");
                break;
            case TypeValue.Value_ReadyToBrew:
                handler.string_value("ReadyToBrew");
                break;
            case TypeValue.Value_DispensingSingleEspresso:
                handler.string_value("DispensingSingleEspresso");
                break;
            case TypeValue.Value_DispensingSingleCoffee:
                handler.string_value("DispensingSingleCoffee");
                break;
            case TypeValue.Value_DispensingDoubleEspresso:
                handler.string_value("DispensingDoubleEspresso");
                break;
            case TypeValue.Value_DispensingDoubleCoffee:
                handler.string_value("DispensingDoubleCoffee");
                break;
            case TypeValue.Value_DispensingHotWater:
                handler.string_value("DispensingHotWater");
                break;
            case TypeValue.Value_DispensingSteam:
                handler.string_value("DispensingSteam");
                break;
            case TypeValue.Value_NeedsBeans:
                handler.string_value("NeedsBeans");
                break;
            case TypeValue.Value_NeedsWater:
                handler.string_value("NeedsWater");
                break;
            case TypeValue.Value_NeedsDregsCleaned:
                handler.string_value("NeedsDregsCleaned");
                break;
            case TypeValue.Value_Descaling:
                handler.string_value("Descaling");
                break;
            case TypeValue.Value_Warning:
                handler.string_value("Warning");
                break;
            case TypeValue.Value_Unknown:
                handler.string_value("Unknown");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static AvantiMachineStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AvantiMachineStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AvantiMachineState", ignore_extras);
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
    public static AvantiMachineStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AvantiMachineStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AvantiMachineStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AvantiMachineState", ignore_extras);
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
    public static AvantiMachineStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AvantiMachineStateJSON from_text(string text, bool ignore_extras)
      {
        AvantiMachineStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AvantiMachineState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AvantiMachineStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AvantiMachineStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AvantiMachineStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AvantiMachineState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        protected FieldGeneratorValue(string what)
          {
            set_what(what);
          }
        protected FieldGeneratorValue()
          {
          }
        protected override void handle_result(string result)
          {
            handle_result(stringToValue(result));
          }
        protected abstract void handle_result(TypeValue result);
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(TypeValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public TypeValue value;
  };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue new_value)
          {
            AvantiMachineStateJSON result = new AvantiMachineStateJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(AvantiMachineStateJSON new_result);
        public Generator(bool ignore_extras) : base("Type AvantiMachineState")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(AvantiMachineStateJSON  result)
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
        public AvantiMachineStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AvantiMachineStateJSON  result)
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
    protected virtual void handle_result(List<AvantiMachineStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AvantiMachineStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AvantiMachineStateJSON>();
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
    public List<AvantiMachineStateJSON> value;
  };
  };
