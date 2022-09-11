/* file "SportsTournamentCodeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsTournamentCodeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_NCAAMBTournament,
        Value_NCAAMBCIT,
        Value_NCAAMBCBI,
        Value_NCAAMBNIT,
        Value_SoccerInternationalMensWorldCup,
        Value_SoccerInternationalMensWorldCupQualifiers,
        Value_SoccerInternationalEuroCup,
        Value_SoccerInternationalCopaAmerica,
        Value_SoccerInternationalAfricaCupOfNations,
        Value_SoccerInternationalAFCAsianCup,
        Value_SoccerInternationalFriendly,
        Value_SoccerInternationalGoldCup,
        Value_SoccerPrimeraDivisionMexApertura,
        Value_SoccerPrimeraDivisionMexClausura,
        Value_CricketICCWorldCup,
        Value__none
      };
    public struct TypeValue
      {
        public bool in_known_list;
        public string string_value;
        public TypeValueKnownValues list_value;
      };

    public static TypeValueKnownValues  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "ricketICCWorldCup", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeValueKnownValues.Value_CricketICCWorldCup;
                break;
            case 'N':
                if (String.Compare(chars, 1, "CAAMB", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'C':
                            switch (chars[7])
                              {
                                case 'B':
                                    if ((String.Compare(chars, 8, "I", 0, 1, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_NCAAMBCBI;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 8, "T", 0, 1, false) == 0) && (chars.Length == 9))
                                        return TypeValueKnownValues.Value_NCAAMBCIT;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'N':
                            if ((String.Compare(chars, 7, "IT", 0, 2, false) == 0) && (chars.Length == 9))
                                return TypeValueKnownValues.Value_NCAAMBNIT;
                            break;
                        case 'T':
                            if ((String.Compare(chars, 7, "ournament", 0, 9, false) == 0) && (chars.Length == 16))
                                return TypeValueKnownValues.Value_NCAAMBTournament;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if (String.Compare(chars, 1, "occer", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'I':
                            if (String.Compare(chars, 7, "nternational", 0, 12, false) == 0)
                              {
                                switch (chars[19])
                                  {
                                    case 'A':
                                        switch (chars[20])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 21, "CAsianCup", 0, 9, false) == 0) && (chars.Length == 30))
                                                    return TypeValueKnownValues.Value_SoccerInternationalAFCAsianCup;
                                                break;
                                            case 'f':
                                                if ((String.Compare(chars, 21, "ricaCupOfNations", 0, 16, false) == 0) && (chars.Length == 37))
                                                    return TypeValueKnownValues.Value_SoccerInternationalAfricaCupOfNations;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'C':
                                        if ((String.Compare(chars, 20, "opaAmerica", 0, 10, false) == 0) && (chars.Length == 30))
                                            return TypeValueKnownValues.Value_SoccerInternationalCopaAmerica;
                                        break;
                                    case 'E':
                                        if ((String.Compare(chars, 20, "uroCup", 0, 6, false) == 0) && (chars.Length == 26))
                                            return TypeValueKnownValues.Value_SoccerInternationalEuroCup;
                                        break;
                                    case 'F':
                                        if ((String.Compare(chars, 20, "riendly", 0, 7, false) == 0) && (chars.Length == 27))
                                            return TypeValueKnownValues.Value_SoccerInternationalFriendly;
                                        break;
                                    case 'G':
                                        if ((String.Compare(chars, 20, "oldCup", 0, 6, false) == 0) && (chars.Length == 26))
                                            return TypeValueKnownValues.Value_SoccerInternationalGoldCup;
                                        break;
                                    case 'M':
                                        if (String.Compare(chars, 20, "ensWorldCup", 0, 11, false) == 0)
                                          {
                                            if (chars.Length == 31)
                                              {
                                                return TypeValueKnownValues.Value_SoccerInternationalMensWorldCup;
                                              }
                                            switch (chars[31])
                                              {
                                                case 'Q':
                                                    if ((String.Compare(chars, 32, "ualifiers", 0, 9, false) == 0) && (chars.Length == 41))
                                                        return TypeValueKnownValues.Value_SoccerInternationalMensWorldCupQualifiers;
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
                        case 'P':
                            if (String.Compare(chars, 7, "rimeraDivisionMex", 0, 17, false) == 0)
                              {
                                switch (chars[24])
                                  {
                                    case 'A':
                                        if ((String.Compare(chars, 25, "pertura", 0, 7, false) == 0) && (chars.Length == 32))
                                            return TypeValueKnownValues.Value_SoccerPrimeraDivisionMexApertura;
                                        break;
                                    case 'C':
                                        if ((String.Compare(chars, 25, "lausura", 0, 7, false) == 0) && (chars.Length == 32))
                                            return TypeValueKnownValues.Value_SoccerPrimeraDivisionMexClausura;
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
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_NCAAMBTournament:
                return "NCAAMBTournament";
            case TypeValueKnownValues.Value_NCAAMBCIT:
                return "NCAAMBCIT";
            case TypeValueKnownValues.Value_NCAAMBCBI:
                return "NCAAMBCBI";
            case TypeValueKnownValues.Value_NCAAMBNIT:
                return "NCAAMBNIT";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCup:
                return "SoccerInternationalMensWorldCup";
            case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupQualifiers:
                return "SoccerInternationalMensWorldCupQualifiers";
            case TypeValueKnownValues.Value_SoccerInternationalEuroCup:
                return "SoccerInternationalEuroCup";
            case TypeValueKnownValues.Value_SoccerInternationalCopaAmerica:
                return "SoccerInternationalCopaAmerica";
            case TypeValueKnownValues.Value_SoccerInternationalAfricaCupOfNations:
                return "SoccerInternationalAfricaCupOfNations";
            case TypeValueKnownValues.Value_SoccerInternationalAFCAsianCup:
                return "SoccerInternationalAFCAsianCup";
            case TypeValueKnownValues.Value_SoccerInternationalFriendly:
                return "SoccerInternationalFriendly";
            case TypeValueKnownValues.Value_SoccerInternationalGoldCup:
                return "SoccerInternationalGoldCup";
            case TypeValueKnownValues.Value_SoccerPrimeraDivisionMexApertura:
                return "SoccerPrimeraDivisionMexApertura";
            case TypeValueKnownValues.Value_SoccerPrimeraDivisionMexClausura:
                return "SoccerPrimeraDivisionMexClausura";
            case TypeValueKnownValues.Value_CricketICCWorldCup:
                return "CricketICCWorldCup";
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
            throw new Exception("The value for field Value of SportsTournamentCodeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "ricketICCWorldCup", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_CricketICCWorldCup;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "CAAMB", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'C':
                            switch (json_string.getData()[7])
                              {
                                case 'B':
                                    if ((String.Compare(json_string.getData(), 8, "I", 0, 1, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCBI;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 8, "T", 0, 1, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBCIT;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'N':
                            if ((String.Compare(json_string.getData(), 7, "IT", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBNIT;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'T':
                            if ((String.Compare(json_string.getData(), 7, "ournament", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_NCAAMBTournament;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if (String.Compare(json_string.getData(), 1, "occer", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'I':
                            if (String.Compare(json_string.getData(), 7, "nternational", 0, 12, false) == 0)
                              {
                                switch (json_string.getData()[19])
                                  {
                                    case 'A':
                                        switch (json_string.getData()[20])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 21, "CAsianCup", 0, 9, false) == 0) && (json_string.getData().Length == 30))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalAFCAsianCup;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'f':
                                                if ((String.Compare(json_string.getData(), 21, "ricaCupOfNations", 0, 16, false) == 0) && (json_string.getData().Length == 37))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalAfricaCupOfNations;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'C':
                                        if ((String.Compare(json_string.getData(), 20, "opaAmerica", 0, 10, false) == 0) && (json_string.getData().Length == 30))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalCopaAmerica;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'E':
                                        if ((String.Compare(json_string.getData(), 20, "uroCup", 0, 6, false) == 0) && (json_string.getData().Length == 26))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalEuroCup;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'F':
                                        if ((String.Compare(json_string.getData(), 20, "riendly", 0, 7, false) == 0) && (json_string.getData().Length == 27))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalFriendly;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'G':
                                        if ((String.Compare(json_string.getData(), 20, "oldCup", 0, 6, false) == 0) && (json_string.getData().Length == 26))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalGoldCup;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'M':
                                        if (String.Compare(json_string.getData(), 20, "ensWorldCup", 0, 11, false) == 0)
                                          {
                                            if (json_string.getData().Length == 31)
                                              {
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCup;
                                                    goto open_enum_is_done;
                                                  }
                                              }
                                            switch (json_string.getData()[31])
                                              {
                                                case 'Q':
                                                    if ((String.Compare(json_string.getData(), 32, "ualifiers", 0, 9, false) == 0) && (json_string.getData().Length == 41))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_SoccerInternationalMensWorldCupQualifiers;
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
                              }
                            break;
                        case 'P':
                            if (String.Compare(json_string.getData(), 7, "rimeraDivisionMex", 0, 17, false) == 0)
                              {
                                switch (json_string.getData()[24])
                                  {
                                    case 'A':
                                        if ((String.Compare(json_string.getData(), 25, "pertura", 0, 7, false) == 0) && (json_string.getData().Length == 32))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerPrimeraDivisionMexApertura;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'C':
                                        if ((String.Compare(json_string.getData(), 25, "lausura", 0, 7, false) == 0) && (json_string.getData().Length == 32))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_SoccerPrimeraDivisionMexClausura;
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
                  }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public SportsTournamentCodeJSON()
      {
        flagHasValue = false;
      }

    public SportsTournamentCodeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsTournamentCodeJSON(string init_value)
      {
        flagHasValue = true;
        TypeValueKnownValues known = stringToValue(init_value);
        if (known == TypeValueKnownValues.Value__none)
          {
            storeValue.in_known_list = false;
            storeValue.string_value = init_value;
          }
        else
          {
            storeValue.in_known_list = true;
            storeValue.list_value = known;
          }
      }

    public SportsTournamentCodeJSON(TypeValueKnownValues init_value)
      {
        flagHasValue = true;
        Debug.Assert(init_value != TypeValueKnownValues.Value__none);
        storeValue.in_known_list = true;
        storeValue.list_value = init_value;
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
        TypeValue result = getValue();
        if (result.in_known_list)
            return stringFromValue(result.list_value);
        else
            return result.string_value;
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        TypeValueKnownValues known = stringToValue(chars);
        TypeValue new_value = new TypeValue();
        if (known == TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setValue(new_value);
      }
    public void setValue(TypeValueKnownValues new_value)
      {
        TypeValue new_full_value = new TypeValue();
        Debug.Assert(new_value != TypeValueKnownValues.Value__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setValue(new_full_value);
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_NCAAMBTournament:
                    handler.string_value("NCAAMBTournament");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCIT:
                    handler.string_value("NCAAMBCIT");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCBI:
                    handler.string_value("NCAAMBCBI");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNIT:
                    handler.string_value("NCAAMBNIT");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCup:
                    handler.string_value("SoccerInternationalMensWorldCup");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupQualifiers:
                    handler.string_value("SoccerInternationalMensWorldCupQualifiers");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalEuroCup:
                    handler.string_value("SoccerInternationalEuroCup");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalCopaAmerica:
                    handler.string_value("SoccerInternationalCopaAmerica");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalAfricaCupOfNations:
                    handler.string_value("SoccerInternationalAfricaCupOfNations");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalAFCAsianCup:
                    handler.string_value("SoccerInternationalAFCAsianCup");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalFriendly:
                    handler.string_value("SoccerInternationalFriendly");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalGoldCup:
                    handler.string_value("SoccerInternationalGoldCup");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeraDivisionMexApertura:
                    handler.string_value("SoccerPrimeraDivisionMexApertura");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeraDivisionMexClausura:
                    handler.string_value("SoccerPrimeraDivisionMexClausura");
                    break;
                case TypeValueKnownValues.Value_CricketICCWorldCup:
                    handler.string_value("CricketICCWorldCup");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_NCAAMBTournament:
                    handler.string_value("NCAAMBTournament");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCIT:
                    handler.string_value("NCAAMBCIT");
                    break;
                case TypeValueKnownValues.Value_NCAAMBCBI:
                    handler.string_value("NCAAMBCBI");
                    break;
                case TypeValueKnownValues.Value_NCAAMBNIT:
                    handler.string_value("NCAAMBNIT");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCup:
                    handler.string_value("SoccerInternationalMensWorldCup");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalMensWorldCupQualifiers:
                    handler.string_value("SoccerInternationalMensWorldCupQualifiers");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalEuroCup:
                    handler.string_value("SoccerInternationalEuroCup");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalCopaAmerica:
                    handler.string_value("SoccerInternationalCopaAmerica");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalAfricaCupOfNations:
                    handler.string_value("SoccerInternationalAfricaCupOfNations");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalAFCAsianCup:
                    handler.string_value("SoccerInternationalAFCAsianCup");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalFriendly:
                    handler.string_value("SoccerInternationalFriendly");
                    break;
                case TypeValueKnownValues.Value_SoccerInternationalGoldCup:
                    handler.string_value("SoccerInternationalGoldCup");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeraDivisionMexApertura:
                    handler.string_value("SoccerPrimeraDivisionMexApertura");
                    break;
                case TypeValueKnownValues.Value_SoccerPrimeraDivisionMexClausura:
                    handler.string_value("SoccerPrimeraDivisionMexClausura");
                    break;
                case TypeValueKnownValues.Value_CricketICCWorldCup:
                    handler.string_value("CricketICCWorldCup");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }

    public static SportsTournamentCodeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsTournamentCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTournamentCode", ignore_extras);
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
    public static SportsTournamentCodeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsTournamentCodeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsTournamentCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTournamentCode", ignore_extras);
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
    public static SportsTournamentCodeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsTournamentCodeJSON from_text(string text, bool ignore_extras)
      {
        SportsTournamentCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTournamentCode", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsTournamentCodeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsTournamentCodeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsTournamentCodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTournamentCode", ignore_extras);
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
            TypeValueKnownValues known = stringToValue(result);
            TypeValue new_value = new TypeValue();
            if (known == TypeValueKnownValues.Value__none)
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
            SportsTournamentCodeJSON result = new SportsTournamentCodeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsTournamentCodeJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsTournamentCode")
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
        protected override void handle_result(SportsTournamentCodeJSON  result)
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
        public SportsTournamentCodeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsTournamentCodeJSON  result)
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
    protected virtual void handle_result(List<SportsTournamentCodeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsTournamentCodeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsTournamentCodeJSON>();
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
    public List<SportsTournamentCodeJSON> value;
  };
  };
