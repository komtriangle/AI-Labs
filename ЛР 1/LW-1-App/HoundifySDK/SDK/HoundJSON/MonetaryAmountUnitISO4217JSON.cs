/* file "MonetaryAmountUnitISO4217JSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MonetaryAmountUnitISO4217JSON : MonetaryAmountUnitJSON
  {
    public enum TypeISO4217CodeKnownValues
      {
        ISO4217Code_AED,
        ISO4217Code_AFN,
        ISO4217Code_ALL,
        ISO4217Code_AMD,
        ISO4217Code_ANG,
        ISO4217Code_AOA,
        ISO4217Code_ARS,
        ISO4217Code_AUD,
        ISO4217Code_AWG,
        ISO4217Code_AZN,
        ISO4217Code_BAM,
        ISO4217Code_BBD,
        ISO4217Code_BDT,
        ISO4217Code_BGN,
        ISO4217Code_BHD,
        ISO4217Code_BIF,
        ISO4217Code_BMD,
        ISO4217Code_BND,
        ISO4217Code_BOB,
        ISO4217Code_BOV,
        ISO4217Code_BRL,
        ISO4217Code_BSD,
        ISO4217Code_BTN,
        ISO4217Code_BWP,
        ISO4217Code_BYN,
        ISO4217Code_BZD,
        ISO4217Code_CAD,
        ISO4217Code_CDF,
        ISO4217Code_CHE,
        ISO4217Code_CHF,
        ISO4217Code_CHW,
        ISO4217Code_CLF,
        ISO4217Code_CLP,
        ISO4217Code_CNY,
        ISO4217Code_COP,
        ISO4217Code_COU,
        ISO4217Code_CRC,
        ISO4217Code_CUC,
        ISO4217Code_CUP,
        ISO4217Code_CVE,
        ISO4217Code_CZK,
        ISO4217Code_DJF,
        ISO4217Code_DKK,
        ISO4217Code_DOP,
        ISO4217Code_DZD,
        ISO4217Code_EGP,
        ISO4217Code_ERN,
        ISO4217Code_ETB,
        ISO4217Code_EUR,
        ISO4217Code_FJD,
        ISO4217Code_FKP,
        ISO4217Code_GBP,
        ISO4217Code_GEL,
        ISO4217Code_GHS,
        ISO4217Code_GIP,
        ISO4217Code_GMD,
        ISO4217Code_GNF,
        ISO4217Code_GTQ,
        ISO4217Code_GYD,
        ISO4217Code_HKD,
        ISO4217Code_HNL,
        ISO4217Code_HRK,
        ISO4217Code_HTG,
        ISO4217Code_HUF,
        ISO4217Code_IDR,
        ISO4217Code_ILS,
        ISO4217Code_INR,
        ISO4217Code_IQD,
        ISO4217Code_IRR,
        ISO4217Code_ISK,
        ISO4217Code_JMD,
        ISO4217Code_JOD,
        ISO4217Code_JPY,
        ISO4217Code_KES,
        ISO4217Code_KGS,
        ISO4217Code_KHR,
        ISO4217Code_KMF,
        ISO4217Code_KPW,
        ISO4217Code_KRW,
        ISO4217Code_KWD,
        ISO4217Code_KYD,
        ISO4217Code_KZT,
        ISO4217Code_LAK,
        ISO4217Code_LBP,
        ISO4217Code_LKR,
        ISO4217Code_LRD,
        ISO4217Code_LSL,
        ISO4217Code_LYD,
        ISO4217Code_MAD,
        ISO4217Code_MDL,
        ISO4217Code_MGA,
        ISO4217Code_MKD,
        ISO4217Code_MMK,
        ISO4217Code_MNT,
        ISO4217Code_MOP,
        ISO4217Code_MRU,
        ISO4217Code_MUR,
        ISO4217Code_MVR,
        ISO4217Code_MWK,
        ISO4217Code_MXN,
        ISO4217Code_MXV,
        ISO4217Code_MYR,
        ISO4217Code_MZN,
        ISO4217Code_NAD,
        ISO4217Code_NGN,
        ISO4217Code_NIO,
        ISO4217Code_NOK,
        ISO4217Code_NPR,
        ISO4217Code_NZD,
        ISO4217Code_OMR,
        ISO4217Code_PAB,
        ISO4217Code_PEN,
        ISO4217Code_PGK,
        ISO4217Code_PHP,
        ISO4217Code_PKR,
        ISO4217Code_PLN,
        ISO4217Code_PYG,
        ISO4217Code_QAR,
        ISO4217Code_RON,
        ISO4217Code_RSD,
        ISO4217Code_RUB,
        ISO4217Code_RWF,
        ISO4217Code_SAR,
        ISO4217Code_SBD,
        ISO4217Code_SCR,
        ISO4217Code_SDG,
        ISO4217Code_SEK,
        ISO4217Code_SGD,
        ISO4217Code_SHP,
        ISO4217Code_SLL,
        ISO4217Code_SOS,
        ISO4217Code_SRD,
        ISO4217Code_SSP,
        ISO4217Code_STN,
        ISO4217Code_SVC,
        ISO4217Code_SYP,
        ISO4217Code_SZL,
        ISO4217Code_THB,
        ISO4217Code_TJS,
        ISO4217Code_TMT,
        ISO4217Code_TND,
        ISO4217Code_TOP,
        ISO4217Code_TRY,
        ISO4217Code_TTD,
        ISO4217Code_TWD,
        ISO4217Code_TZS,
        ISO4217Code_UAH,
        ISO4217Code_UGX,
        ISO4217Code_USD,
        ISO4217Code_USN,
        ISO4217Code_UYI,
        ISO4217Code_UYU,
        ISO4217Code_UYW,
        ISO4217Code_UZS,
        ISO4217Code_VES,
        ISO4217Code_VND,
        ISO4217Code_VUV,
        ISO4217Code_WST,
        ISO4217Code_XAF,
        ISO4217Code_XAG,
        ISO4217Code_XAU,
        ISO4217Code_XBA,
        ISO4217Code_XBB,
        ISO4217Code_XBC,
        ISO4217Code_XBD,
        ISO4217Code_XCD,
        ISO4217Code_XDR,
        ISO4217Code_XOF,
        ISO4217Code_XPD,
        ISO4217Code_XPF,
        ISO4217Code_XPT,
        ISO4217Code_XSU,
        ISO4217Code_XTS,
        ISO4217Code_XUA,
        ISO4217Code_XXX,
        ISO4217Code_YER,
        ISO4217Code_ZAR,
        ISO4217Code_ZMW,
        ISO4217Code_ZWL,
        ISO4217Code__none
      };
    public struct TypeISO4217Code
      {
        public bool in_known_list;
        public string string_value;
        public TypeISO4217CodeKnownValues list_value;
      };

    public static TypeISO4217CodeKnownValues  stringToISO4217Code(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'E':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_AED;
                        break;
                    case 'F':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_AFN;
                        break;
                    case 'L':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_ALL;
                        break;
                    case 'M':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_AMD;
                        break;
                    case 'N':
                        if ((String.Compare(chars, 2, "G", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_ANG;
                        break;
                    case 'O':
                        if ((String.Compare(chars, 2, "A", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_AOA;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_ARS;
                        break;
                    case 'U':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_AUD;
                        break;
                    case 'W':
                        if ((String.Compare(chars, 2, "G", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_AWG;
                        break;
                    case 'Z':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_AZN;
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                switch (chars[1])
                  {
                    case 'A':
                        if ((String.Compare(chars, 2, "M", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BAM;
                        break;
                    case 'B':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BBD;
                        break;
                    case 'D':
                        if ((String.Compare(chars, 2, "T", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BDT;
                        break;
                    case 'G':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BGN;
                        break;
                    case 'H':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BHD;
                        break;
                    case 'I':
                        if ((String.Compare(chars, 2, "F", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BIF;
                        break;
                    case 'M':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BMD;
                        break;
                    case 'N':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BND;
                        break;
                    case 'O':
                        switch (chars[2])
                          {
                            case 'B':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_BOB;
                                break;
                            case 'V':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_BOV;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BRL;
                        break;
                    case 'S':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BSD;
                        break;
                    case 'T':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BTN;
                        break;
                    case 'W':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BWP;
                        break;
                    case 'Y':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BYN;
                        break;
                    case 'Z':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_BZD;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'A':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_CAD;
                        break;
                    case 'D':
                        if ((String.Compare(chars, 2, "F", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_CDF;
                        break;
                    case 'H':
                        switch (chars[2])
                          {
                            case 'E':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_CHE;
                                break;
                            case 'F':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_CHF;
                                break;
                            case 'W':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_CHW;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'L':
                        switch (chars[2])
                          {
                            case 'F':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_CLF;
                                break;
                            case 'P':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_CLP;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'N':
                        if ((String.Compare(chars, 2, "Y", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_CNY;
                        break;
                    case 'O':
                        switch (chars[2])
                          {
                            case 'P':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_COP;
                                break;
                            case 'U':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_COU;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "C", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_CRC;
                        break;
                    case 'U':
                        switch (chars[2])
                          {
                            case 'C':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_CUC;
                                break;
                            case 'P':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_CUP;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'V':
                        if ((String.Compare(chars, 2, "E", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_CVE;
                        break;
                    case 'Z':
                        if ((String.Compare(chars, 2, "K", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_CZK;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (chars[1])
                  {
                    case 'J':
                        if ((String.Compare(chars, 2, "F", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_DJF;
                        break;
                    case 'K':
                        if ((String.Compare(chars, 2, "K", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_DKK;
                        break;
                    case 'O':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_DOP;
                        break;
                    case 'Z':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_DZD;
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                switch (chars[1])
                  {
                    case 'G':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_EGP;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_ERN;
                        break;
                    case 'T':
                        if ((String.Compare(chars, 2, "B", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_ETB;
                        break;
                    case 'U':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_EUR;
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                switch (chars[1])
                  {
                    case 'J':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_FJD;
                        break;
                    case 'K':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_FKP;
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                switch (chars[1])
                  {
                    case 'B':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_GBP;
                        break;
                    case 'E':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_GEL;
                        break;
                    case 'H':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_GHS;
                        break;
                    case 'I':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_GIP;
                        break;
                    case 'M':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_GMD;
                        break;
                    case 'N':
                        if ((String.Compare(chars, 2, "F", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_GNF;
                        break;
                    case 'T':
                        if ((String.Compare(chars, 2, "Q", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_GTQ;
                        break;
                    case 'Y':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_GYD;
                        break;
                    default:
                        break;
                  }
                break;
            case 'H':
                switch (chars[1])
                  {
                    case 'K':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_HKD;
                        break;
                    case 'N':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_HNL;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "K", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_HRK;
                        break;
                    case 'T':
                        if ((String.Compare(chars, 2, "G", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_HTG;
                        break;
                    case 'U':
                        if ((String.Compare(chars, 2, "F", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_HUF;
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                switch (chars[1])
                  {
                    case 'D':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_IDR;
                        break;
                    case 'L':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_ILS;
                        break;
                    case 'N':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_INR;
                        break;
                    case 'Q':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_IQD;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_IRR;
                        break;
                    case 'S':
                        if ((String.Compare(chars, 2, "K", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_ISK;
                        break;
                    default:
                        break;
                  }
                break;
            case 'J':
                switch (chars[1])
                  {
                    case 'M':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_JMD;
                        break;
                    case 'O':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_JOD;
                        break;
                    case 'P':
                        if ((String.Compare(chars, 2, "Y", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_JPY;
                        break;
                    default:
                        break;
                  }
                break;
            case 'K':
                switch (chars[1])
                  {
                    case 'E':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_KES;
                        break;
                    case 'G':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_KGS;
                        break;
                    case 'H':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_KHR;
                        break;
                    case 'M':
                        if ((String.Compare(chars, 2, "F", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_KMF;
                        break;
                    case 'P':
                        if ((String.Compare(chars, 2, "W", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_KPW;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "W", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_KRW;
                        break;
                    case 'W':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_KWD;
                        break;
                    case 'Y':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_KYD;
                        break;
                    case 'Z':
                        if ((String.Compare(chars, 2, "T", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_KZT;
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                switch (chars[1])
                  {
                    case 'A':
                        if ((String.Compare(chars, 2, "K", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_LAK;
                        break;
                    case 'B':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_LBP;
                        break;
                    case 'K':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_LKR;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_LRD;
                        break;
                    case 'S':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_LSL;
                        break;
                    case 'Y':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_LYD;
                        break;
                    default:
                        break;
                  }
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'A':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MAD;
                        break;
                    case 'D':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MDL;
                        break;
                    case 'G':
                        if ((String.Compare(chars, 2, "A", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MGA;
                        break;
                    case 'K':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MKD;
                        break;
                    case 'M':
                        if ((String.Compare(chars, 2, "K", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MMK;
                        break;
                    case 'N':
                        if ((String.Compare(chars, 2, "T", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MNT;
                        break;
                    case 'O':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MOP;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "U", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MRU;
                        break;
                    case 'U':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MUR;
                        break;
                    case 'V':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MVR;
                        break;
                    case 'W':
                        if ((String.Compare(chars, 2, "K", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MWK;
                        break;
                    case 'X':
                        switch (chars[2])
                          {
                            case 'N':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_MXN;
                                break;
                            case 'V':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_MXV;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'Y':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MYR;
                        break;
                    case 'Z':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_MZN;
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (chars[1])
                  {
                    case 'A':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_NAD;
                        break;
                    case 'G':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_NGN;
                        break;
                    case 'I':
                        if ((String.Compare(chars, 2, "O", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_NIO;
                        break;
                    case 'O':
                        if ((String.Compare(chars, 2, "K", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_NOK;
                        break;
                    case 'P':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_NPR;
                        break;
                    case 'Z':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_NZD;
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                if ((String.Compare(chars, 1, "MR", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeISO4217CodeKnownValues.ISO4217Code_OMR;
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'A':
                        if ((String.Compare(chars, 2, "B", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_PAB;
                        break;
                    case 'E':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_PEN;
                        break;
                    case 'G':
                        if ((String.Compare(chars, 2, "K", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_PGK;
                        break;
                    case 'H':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_PHP;
                        break;
                    case 'K':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_PKR;
                        break;
                    case 'L':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_PLN;
                        break;
                    case 'Y':
                        if ((String.Compare(chars, 2, "G", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_PYG;
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(chars, 1, "AR", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeISO4217CodeKnownValues.ISO4217Code_QAR;
                break;
            case 'R':
                switch (chars[1])
                  {
                    case 'O':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_RON;
                        break;
                    case 'S':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_RSD;
                        break;
                    case 'U':
                        if ((String.Compare(chars, 2, "B", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_RUB;
                        break;
                    case 'W':
                        if ((String.Compare(chars, 2, "F", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_RWF;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'A':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SAR;
                        break;
                    case 'B':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SBD;
                        break;
                    case 'C':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SCR;
                        break;
                    case 'D':
                        if ((String.Compare(chars, 2, "G", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SDG;
                        break;
                    case 'E':
                        if ((String.Compare(chars, 2, "K", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SEK;
                        break;
                    case 'G':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SGD;
                        break;
                    case 'H':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SHP;
                        break;
                    case 'L':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SLL;
                        break;
                    case 'O':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SOS;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SRD;
                        break;
                    case 'S':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SSP;
                        break;
                    case 'T':
                        if ((String.Compare(chars, 2, "N", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_STN;
                        break;
                    case 'V':
                        if ((String.Compare(chars, 2, "C", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SVC;
                        break;
                    case 'Y':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SYP;
                        break;
                    case 'Z':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_SZL;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'H':
                        if ((String.Compare(chars, 2, "B", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_THB;
                        break;
                    case 'J':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_TJS;
                        break;
                    case 'M':
                        if ((String.Compare(chars, 2, "T", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_TMT;
                        break;
                    case 'N':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_TND;
                        break;
                    case 'O':
                        if ((String.Compare(chars, 2, "P", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_TOP;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "Y", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_TRY;
                        break;
                    case 'T':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_TTD;
                        break;
                    case 'W':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_TWD;
                        break;
                    case 'Z':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_TZS;
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                switch (chars[1])
                  {
                    case 'A':
                        if ((String.Compare(chars, 2, "H", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_UAH;
                        break;
                    case 'G':
                        if ((String.Compare(chars, 2, "X", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_UGX;
                        break;
                    case 'S':
                        switch (chars[2])
                          {
                            case 'D':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_USD;
                                break;
                            case 'N':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_USN;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'Y':
                        switch (chars[2])
                          {
                            case 'I':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_UYI;
                                break;
                            case 'U':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_UYU;
                                break;
                            case 'W':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_UYW;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'Z':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_UZS;
                        break;
                    default:
                        break;
                  }
                break;
            case 'V':
                switch (chars[1])
                  {
                    case 'E':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_VES;
                        break;
                    case 'N':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_VND;
                        break;
                    case 'U':
                        if ((String.Compare(chars, 2, "V", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_VUV;
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(chars, 1, "ST", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeISO4217CodeKnownValues.ISO4217Code_WST;
                break;
            case 'X':
                switch (chars[1])
                  {
                    case 'A':
                        switch (chars[2])
                          {
                            case 'F':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_XAF;
                                break;
                            case 'G':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_XAG;
                                break;
                            case 'U':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_XAU;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'B':
                        switch (chars[2])
                          {
                            case 'A':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_XBA;
                                break;
                            case 'B':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_XBB;
                                break;
                            case 'C':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_XBC;
                                break;
                            case 'D':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_XBD;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'C':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_XCD;
                        break;
                    case 'D':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_XDR;
                        break;
                    case 'O':
                        if ((String.Compare(chars, 2, "F", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_XOF;
                        break;
                    case 'P':
                        switch (chars[2])
                          {
                            case 'D':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_XPD;
                                break;
                            case 'F':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_XPF;
                                break;
                            case 'T':
                                if (chars.Length == 3)
                                    return TypeISO4217CodeKnownValues.ISO4217Code_XPT;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'S':
                        if ((String.Compare(chars, 2, "U", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_XSU;
                        break;
                    case 'T':
                        if ((String.Compare(chars, 2, "S", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_XTS;
                        break;
                    case 'U':
                        if ((String.Compare(chars, 2, "A", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_XUA;
                        break;
                    case 'X':
                        if ((String.Compare(chars, 2, "X", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_XXX;
                        break;
                    default:
                        break;
                  }
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "ER", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeISO4217CodeKnownValues.ISO4217Code_YER;
                break;
            case 'Z':
                switch (chars[1])
                  {
                    case 'A':
                        if ((String.Compare(chars, 2, "R", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_ZAR;
                        break;
                    case 'M':
                        if ((String.Compare(chars, 2, "W", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_ZMW;
                        break;
                    case 'W':
                        if ((String.Compare(chars, 2, "L", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeISO4217CodeKnownValues.ISO4217Code_ZWL;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeISO4217CodeKnownValues.ISO4217Code__none;
      }

    public static string  stringFromISO4217Code(TypeISO4217CodeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeISO4217CodeKnownValues.ISO4217Code_AED:
                return "AED";
            case TypeISO4217CodeKnownValues.ISO4217Code_AFN:
                return "AFN";
            case TypeISO4217CodeKnownValues.ISO4217Code_ALL:
                return "ALL";
            case TypeISO4217CodeKnownValues.ISO4217Code_AMD:
                return "AMD";
            case TypeISO4217CodeKnownValues.ISO4217Code_ANG:
                return "ANG";
            case TypeISO4217CodeKnownValues.ISO4217Code_AOA:
                return "AOA";
            case TypeISO4217CodeKnownValues.ISO4217Code_ARS:
                return "ARS";
            case TypeISO4217CodeKnownValues.ISO4217Code_AUD:
                return "AUD";
            case TypeISO4217CodeKnownValues.ISO4217Code_AWG:
                return "AWG";
            case TypeISO4217CodeKnownValues.ISO4217Code_AZN:
                return "AZN";
            case TypeISO4217CodeKnownValues.ISO4217Code_BAM:
                return "BAM";
            case TypeISO4217CodeKnownValues.ISO4217Code_BBD:
                return "BBD";
            case TypeISO4217CodeKnownValues.ISO4217Code_BDT:
                return "BDT";
            case TypeISO4217CodeKnownValues.ISO4217Code_BGN:
                return "BGN";
            case TypeISO4217CodeKnownValues.ISO4217Code_BHD:
                return "BHD";
            case TypeISO4217CodeKnownValues.ISO4217Code_BIF:
                return "BIF";
            case TypeISO4217CodeKnownValues.ISO4217Code_BMD:
                return "BMD";
            case TypeISO4217CodeKnownValues.ISO4217Code_BND:
                return "BND";
            case TypeISO4217CodeKnownValues.ISO4217Code_BOB:
                return "BOB";
            case TypeISO4217CodeKnownValues.ISO4217Code_BOV:
                return "BOV";
            case TypeISO4217CodeKnownValues.ISO4217Code_BRL:
                return "BRL";
            case TypeISO4217CodeKnownValues.ISO4217Code_BSD:
                return "BSD";
            case TypeISO4217CodeKnownValues.ISO4217Code_BTN:
                return "BTN";
            case TypeISO4217CodeKnownValues.ISO4217Code_BWP:
                return "BWP";
            case TypeISO4217CodeKnownValues.ISO4217Code_BYN:
                return "BYN";
            case TypeISO4217CodeKnownValues.ISO4217Code_BZD:
                return "BZD";
            case TypeISO4217CodeKnownValues.ISO4217Code_CAD:
                return "CAD";
            case TypeISO4217CodeKnownValues.ISO4217Code_CDF:
                return "CDF";
            case TypeISO4217CodeKnownValues.ISO4217Code_CHE:
                return "CHE";
            case TypeISO4217CodeKnownValues.ISO4217Code_CHF:
                return "CHF";
            case TypeISO4217CodeKnownValues.ISO4217Code_CHW:
                return "CHW";
            case TypeISO4217CodeKnownValues.ISO4217Code_CLF:
                return "CLF";
            case TypeISO4217CodeKnownValues.ISO4217Code_CLP:
                return "CLP";
            case TypeISO4217CodeKnownValues.ISO4217Code_CNY:
                return "CNY";
            case TypeISO4217CodeKnownValues.ISO4217Code_COP:
                return "COP";
            case TypeISO4217CodeKnownValues.ISO4217Code_COU:
                return "COU";
            case TypeISO4217CodeKnownValues.ISO4217Code_CRC:
                return "CRC";
            case TypeISO4217CodeKnownValues.ISO4217Code_CUC:
                return "CUC";
            case TypeISO4217CodeKnownValues.ISO4217Code_CUP:
                return "CUP";
            case TypeISO4217CodeKnownValues.ISO4217Code_CVE:
                return "CVE";
            case TypeISO4217CodeKnownValues.ISO4217Code_CZK:
                return "CZK";
            case TypeISO4217CodeKnownValues.ISO4217Code_DJF:
                return "DJF";
            case TypeISO4217CodeKnownValues.ISO4217Code_DKK:
                return "DKK";
            case TypeISO4217CodeKnownValues.ISO4217Code_DOP:
                return "DOP";
            case TypeISO4217CodeKnownValues.ISO4217Code_DZD:
                return "DZD";
            case TypeISO4217CodeKnownValues.ISO4217Code_EGP:
                return "EGP";
            case TypeISO4217CodeKnownValues.ISO4217Code_ERN:
                return "ERN";
            case TypeISO4217CodeKnownValues.ISO4217Code_ETB:
                return "ETB";
            case TypeISO4217CodeKnownValues.ISO4217Code_EUR:
                return "EUR";
            case TypeISO4217CodeKnownValues.ISO4217Code_FJD:
                return "FJD";
            case TypeISO4217CodeKnownValues.ISO4217Code_FKP:
                return "FKP";
            case TypeISO4217CodeKnownValues.ISO4217Code_GBP:
                return "GBP";
            case TypeISO4217CodeKnownValues.ISO4217Code_GEL:
                return "GEL";
            case TypeISO4217CodeKnownValues.ISO4217Code_GHS:
                return "GHS";
            case TypeISO4217CodeKnownValues.ISO4217Code_GIP:
                return "GIP";
            case TypeISO4217CodeKnownValues.ISO4217Code_GMD:
                return "GMD";
            case TypeISO4217CodeKnownValues.ISO4217Code_GNF:
                return "GNF";
            case TypeISO4217CodeKnownValues.ISO4217Code_GTQ:
                return "GTQ";
            case TypeISO4217CodeKnownValues.ISO4217Code_GYD:
                return "GYD";
            case TypeISO4217CodeKnownValues.ISO4217Code_HKD:
                return "HKD";
            case TypeISO4217CodeKnownValues.ISO4217Code_HNL:
                return "HNL";
            case TypeISO4217CodeKnownValues.ISO4217Code_HRK:
                return "HRK";
            case TypeISO4217CodeKnownValues.ISO4217Code_HTG:
                return "HTG";
            case TypeISO4217CodeKnownValues.ISO4217Code_HUF:
                return "HUF";
            case TypeISO4217CodeKnownValues.ISO4217Code_IDR:
                return "IDR";
            case TypeISO4217CodeKnownValues.ISO4217Code_ILS:
                return "ILS";
            case TypeISO4217CodeKnownValues.ISO4217Code_INR:
                return "INR";
            case TypeISO4217CodeKnownValues.ISO4217Code_IQD:
                return "IQD";
            case TypeISO4217CodeKnownValues.ISO4217Code_IRR:
                return "IRR";
            case TypeISO4217CodeKnownValues.ISO4217Code_ISK:
                return "ISK";
            case TypeISO4217CodeKnownValues.ISO4217Code_JMD:
                return "JMD";
            case TypeISO4217CodeKnownValues.ISO4217Code_JOD:
                return "JOD";
            case TypeISO4217CodeKnownValues.ISO4217Code_JPY:
                return "JPY";
            case TypeISO4217CodeKnownValues.ISO4217Code_KES:
                return "KES";
            case TypeISO4217CodeKnownValues.ISO4217Code_KGS:
                return "KGS";
            case TypeISO4217CodeKnownValues.ISO4217Code_KHR:
                return "KHR";
            case TypeISO4217CodeKnownValues.ISO4217Code_KMF:
                return "KMF";
            case TypeISO4217CodeKnownValues.ISO4217Code_KPW:
                return "KPW";
            case TypeISO4217CodeKnownValues.ISO4217Code_KRW:
                return "KRW";
            case TypeISO4217CodeKnownValues.ISO4217Code_KWD:
                return "KWD";
            case TypeISO4217CodeKnownValues.ISO4217Code_KYD:
                return "KYD";
            case TypeISO4217CodeKnownValues.ISO4217Code_KZT:
                return "KZT";
            case TypeISO4217CodeKnownValues.ISO4217Code_LAK:
                return "LAK";
            case TypeISO4217CodeKnownValues.ISO4217Code_LBP:
                return "LBP";
            case TypeISO4217CodeKnownValues.ISO4217Code_LKR:
                return "LKR";
            case TypeISO4217CodeKnownValues.ISO4217Code_LRD:
                return "LRD";
            case TypeISO4217CodeKnownValues.ISO4217Code_LSL:
                return "LSL";
            case TypeISO4217CodeKnownValues.ISO4217Code_LYD:
                return "LYD";
            case TypeISO4217CodeKnownValues.ISO4217Code_MAD:
                return "MAD";
            case TypeISO4217CodeKnownValues.ISO4217Code_MDL:
                return "MDL";
            case TypeISO4217CodeKnownValues.ISO4217Code_MGA:
                return "MGA";
            case TypeISO4217CodeKnownValues.ISO4217Code_MKD:
                return "MKD";
            case TypeISO4217CodeKnownValues.ISO4217Code_MMK:
                return "MMK";
            case TypeISO4217CodeKnownValues.ISO4217Code_MNT:
                return "MNT";
            case TypeISO4217CodeKnownValues.ISO4217Code_MOP:
                return "MOP";
            case TypeISO4217CodeKnownValues.ISO4217Code_MRU:
                return "MRU";
            case TypeISO4217CodeKnownValues.ISO4217Code_MUR:
                return "MUR";
            case TypeISO4217CodeKnownValues.ISO4217Code_MVR:
                return "MVR";
            case TypeISO4217CodeKnownValues.ISO4217Code_MWK:
                return "MWK";
            case TypeISO4217CodeKnownValues.ISO4217Code_MXN:
                return "MXN";
            case TypeISO4217CodeKnownValues.ISO4217Code_MXV:
                return "MXV";
            case TypeISO4217CodeKnownValues.ISO4217Code_MYR:
                return "MYR";
            case TypeISO4217CodeKnownValues.ISO4217Code_MZN:
                return "MZN";
            case TypeISO4217CodeKnownValues.ISO4217Code_NAD:
                return "NAD";
            case TypeISO4217CodeKnownValues.ISO4217Code_NGN:
                return "NGN";
            case TypeISO4217CodeKnownValues.ISO4217Code_NIO:
                return "NIO";
            case TypeISO4217CodeKnownValues.ISO4217Code_NOK:
                return "NOK";
            case TypeISO4217CodeKnownValues.ISO4217Code_NPR:
                return "NPR";
            case TypeISO4217CodeKnownValues.ISO4217Code_NZD:
                return "NZD";
            case TypeISO4217CodeKnownValues.ISO4217Code_OMR:
                return "OMR";
            case TypeISO4217CodeKnownValues.ISO4217Code_PAB:
                return "PAB";
            case TypeISO4217CodeKnownValues.ISO4217Code_PEN:
                return "PEN";
            case TypeISO4217CodeKnownValues.ISO4217Code_PGK:
                return "PGK";
            case TypeISO4217CodeKnownValues.ISO4217Code_PHP:
                return "PHP";
            case TypeISO4217CodeKnownValues.ISO4217Code_PKR:
                return "PKR";
            case TypeISO4217CodeKnownValues.ISO4217Code_PLN:
                return "PLN";
            case TypeISO4217CodeKnownValues.ISO4217Code_PYG:
                return "PYG";
            case TypeISO4217CodeKnownValues.ISO4217Code_QAR:
                return "QAR";
            case TypeISO4217CodeKnownValues.ISO4217Code_RON:
                return "RON";
            case TypeISO4217CodeKnownValues.ISO4217Code_RSD:
                return "RSD";
            case TypeISO4217CodeKnownValues.ISO4217Code_RUB:
                return "RUB";
            case TypeISO4217CodeKnownValues.ISO4217Code_RWF:
                return "RWF";
            case TypeISO4217CodeKnownValues.ISO4217Code_SAR:
                return "SAR";
            case TypeISO4217CodeKnownValues.ISO4217Code_SBD:
                return "SBD";
            case TypeISO4217CodeKnownValues.ISO4217Code_SCR:
                return "SCR";
            case TypeISO4217CodeKnownValues.ISO4217Code_SDG:
                return "SDG";
            case TypeISO4217CodeKnownValues.ISO4217Code_SEK:
                return "SEK";
            case TypeISO4217CodeKnownValues.ISO4217Code_SGD:
                return "SGD";
            case TypeISO4217CodeKnownValues.ISO4217Code_SHP:
                return "SHP";
            case TypeISO4217CodeKnownValues.ISO4217Code_SLL:
                return "SLL";
            case TypeISO4217CodeKnownValues.ISO4217Code_SOS:
                return "SOS";
            case TypeISO4217CodeKnownValues.ISO4217Code_SRD:
                return "SRD";
            case TypeISO4217CodeKnownValues.ISO4217Code_SSP:
                return "SSP";
            case TypeISO4217CodeKnownValues.ISO4217Code_STN:
                return "STN";
            case TypeISO4217CodeKnownValues.ISO4217Code_SVC:
                return "SVC";
            case TypeISO4217CodeKnownValues.ISO4217Code_SYP:
                return "SYP";
            case TypeISO4217CodeKnownValues.ISO4217Code_SZL:
                return "SZL";
            case TypeISO4217CodeKnownValues.ISO4217Code_THB:
                return "THB";
            case TypeISO4217CodeKnownValues.ISO4217Code_TJS:
                return "TJS";
            case TypeISO4217CodeKnownValues.ISO4217Code_TMT:
                return "TMT";
            case TypeISO4217CodeKnownValues.ISO4217Code_TND:
                return "TND";
            case TypeISO4217CodeKnownValues.ISO4217Code_TOP:
                return "TOP";
            case TypeISO4217CodeKnownValues.ISO4217Code_TRY:
                return "TRY";
            case TypeISO4217CodeKnownValues.ISO4217Code_TTD:
                return "TTD";
            case TypeISO4217CodeKnownValues.ISO4217Code_TWD:
                return "TWD";
            case TypeISO4217CodeKnownValues.ISO4217Code_TZS:
                return "TZS";
            case TypeISO4217CodeKnownValues.ISO4217Code_UAH:
                return "UAH";
            case TypeISO4217CodeKnownValues.ISO4217Code_UGX:
                return "UGX";
            case TypeISO4217CodeKnownValues.ISO4217Code_USD:
                return "USD";
            case TypeISO4217CodeKnownValues.ISO4217Code_USN:
                return "USN";
            case TypeISO4217CodeKnownValues.ISO4217Code_UYI:
                return "UYI";
            case TypeISO4217CodeKnownValues.ISO4217Code_UYU:
                return "UYU";
            case TypeISO4217CodeKnownValues.ISO4217Code_UYW:
                return "UYW";
            case TypeISO4217CodeKnownValues.ISO4217Code_UZS:
                return "UZS";
            case TypeISO4217CodeKnownValues.ISO4217Code_VES:
                return "VES";
            case TypeISO4217CodeKnownValues.ISO4217Code_VND:
                return "VND";
            case TypeISO4217CodeKnownValues.ISO4217Code_VUV:
                return "VUV";
            case TypeISO4217CodeKnownValues.ISO4217Code_WST:
                return "WST";
            case TypeISO4217CodeKnownValues.ISO4217Code_XAF:
                return "XAF";
            case TypeISO4217CodeKnownValues.ISO4217Code_XAG:
                return "XAG";
            case TypeISO4217CodeKnownValues.ISO4217Code_XAU:
                return "XAU";
            case TypeISO4217CodeKnownValues.ISO4217Code_XBA:
                return "XBA";
            case TypeISO4217CodeKnownValues.ISO4217Code_XBB:
                return "XBB";
            case TypeISO4217CodeKnownValues.ISO4217Code_XBC:
                return "XBC";
            case TypeISO4217CodeKnownValues.ISO4217Code_XBD:
                return "XBD";
            case TypeISO4217CodeKnownValues.ISO4217Code_XCD:
                return "XCD";
            case TypeISO4217CodeKnownValues.ISO4217Code_XDR:
                return "XDR";
            case TypeISO4217CodeKnownValues.ISO4217Code_XOF:
                return "XOF";
            case TypeISO4217CodeKnownValues.ISO4217Code_XPD:
                return "XPD";
            case TypeISO4217CodeKnownValues.ISO4217Code_XPF:
                return "XPF";
            case TypeISO4217CodeKnownValues.ISO4217Code_XPT:
                return "XPT";
            case TypeISO4217CodeKnownValues.ISO4217Code_XSU:
                return "XSU";
            case TypeISO4217CodeKnownValues.ISO4217Code_XTS:
                return "XTS";
            case TypeISO4217CodeKnownValues.ISO4217Code_XUA:
                return "XUA";
            case TypeISO4217CodeKnownValues.ISO4217Code_XXX:
                return "XXX";
            case TypeISO4217CodeKnownValues.ISO4217Code_YER:
                return "YER";
            case TypeISO4217CodeKnownValues.ISO4217Code_ZAR:
                return "ZAR";
            case TypeISO4217CodeKnownValues.ISO4217Code_ZMW:
                return "ZMW";
            case TypeISO4217CodeKnownValues.ISO4217Code_ZWL:
                return "ZWL";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasISO4217Code;
    private TypeISO4217Code storeISO4217Code;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraISO4217CodeToJSON()
      {
        JSONStringValue generated_string_ISO4217Code;
        if (!(storeISO4217Code.in_known_list))
          {
        generated_string_ISO4217Code = new JSONStringValue(storeISO4217Code.string_value);
          }
        else
          {
        switch (storeISO4217Code.list_value)
          {
            case TypeISO4217CodeKnownValues.ISO4217Code_AED:
                generated_string_ISO4217Code = new JSONStringValue("AED");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_AFN:
                generated_string_ISO4217Code = new JSONStringValue("AFN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_ALL:
                generated_string_ISO4217Code = new JSONStringValue("ALL");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_AMD:
                generated_string_ISO4217Code = new JSONStringValue("AMD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_ANG:
                generated_string_ISO4217Code = new JSONStringValue("ANG");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_AOA:
                generated_string_ISO4217Code = new JSONStringValue("AOA");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_ARS:
                generated_string_ISO4217Code = new JSONStringValue("ARS");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_AUD:
                generated_string_ISO4217Code = new JSONStringValue("AUD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_AWG:
                generated_string_ISO4217Code = new JSONStringValue("AWG");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_AZN:
                generated_string_ISO4217Code = new JSONStringValue("AZN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BAM:
                generated_string_ISO4217Code = new JSONStringValue("BAM");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BBD:
                generated_string_ISO4217Code = new JSONStringValue("BBD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BDT:
                generated_string_ISO4217Code = new JSONStringValue("BDT");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BGN:
                generated_string_ISO4217Code = new JSONStringValue("BGN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BHD:
                generated_string_ISO4217Code = new JSONStringValue("BHD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BIF:
                generated_string_ISO4217Code = new JSONStringValue("BIF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BMD:
                generated_string_ISO4217Code = new JSONStringValue("BMD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BND:
                generated_string_ISO4217Code = new JSONStringValue("BND");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BOB:
                generated_string_ISO4217Code = new JSONStringValue("BOB");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BOV:
                generated_string_ISO4217Code = new JSONStringValue("BOV");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BRL:
                generated_string_ISO4217Code = new JSONStringValue("BRL");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BSD:
                generated_string_ISO4217Code = new JSONStringValue("BSD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BTN:
                generated_string_ISO4217Code = new JSONStringValue("BTN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BWP:
                generated_string_ISO4217Code = new JSONStringValue("BWP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BYN:
                generated_string_ISO4217Code = new JSONStringValue("BYN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_BZD:
                generated_string_ISO4217Code = new JSONStringValue("BZD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CAD:
                generated_string_ISO4217Code = new JSONStringValue("CAD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CDF:
                generated_string_ISO4217Code = new JSONStringValue("CDF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CHE:
                generated_string_ISO4217Code = new JSONStringValue("CHE");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CHF:
                generated_string_ISO4217Code = new JSONStringValue("CHF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CHW:
                generated_string_ISO4217Code = new JSONStringValue("CHW");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CLF:
                generated_string_ISO4217Code = new JSONStringValue("CLF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CLP:
                generated_string_ISO4217Code = new JSONStringValue("CLP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CNY:
                generated_string_ISO4217Code = new JSONStringValue("CNY");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_COP:
                generated_string_ISO4217Code = new JSONStringValue("COP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_COU:
                generated_string_ISO4217Code = new JSONStringValue("COU");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CRC:
                generated_string_ISO4217Code = new JSONStringValue("CRC");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CUC:
                generated_string_ISO4217Code = new JSONStringValue("CUC");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CUP:
                generated_string_ISO4217Code = new JSONStringValue("CUP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CVE:
                generated_string_ISO4217Code = new JSONStringValue("CVE");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_CZK:
                generated_string_ISO4217Code = new JSONStringValue("CZK");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_DJF:
                generated_string_ISO4217Code = new JSONStringValue("DJF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_DKK:
                generated_string_ISO4217Code = new JSONStringValue("DKK");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_DOP:
                generated_string_ISO4217Code = new JSONStringValue("DOP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_DZD:
                generated_string_ISO4217Code = new JSONStringValue("DZD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_EGP:
                generated_string_ISO4217Code = new JSONStringValue("EGP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_ERN:
                generated_string_ISO4217Code = new JSONStringValue("ERN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_ETB:
                generated_string_ISO4217Code = new JSONStringValue("ETB");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_EUR:
                generated_string_ISO4217Code = new JSONStringValue("EUR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_FJD:
                generated_string_ISO4217Code = new JSONStringValue("FJD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_FKP:
                generated_string_ISO4217Code = new JSONStringValue("FKP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_GBP:
                generated_string_ISO4217Code = new JSONStringValue("GBP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_GEL:
                generated_string_ISO4217Code = new JSONStringValue("GEL");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_GHS:
                generated_string_ISO4217Code = new JSONStringValue("GHS");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_GIP:
                generated_string_ISO4217Code = new JSONStringValue("GIP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_GMD:
                generated_string_ISO4217Code = new JSONStringValue("GMD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_GNF:
                generated_string_ISO4217Code = new JSONStringValue("GNF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_GTQ:
                generated_string_ISO4217Code = new JSONStringValue("GTQ");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_GYD:
                generated_string_ISO4217Code = new JSONStringValue("GYD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_HKD:
                generated_string_ISO4217Code = new JSONStringValue("HKD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_HNL:
                generated_string_ISO4217Code = new JSONStringValue("HNL");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_HRK:
                generated_string_ISO4217Code = new JSONStringValue("HRK");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_HTG:
                generated_string_ISO4217Code = new JSONStringValue("HTG");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_HUF:
                generated_string_ISO4217Code = new JSONStringValue("HUF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_IDR:
                generated_string_ISO4217Code = new JSONStringValue("IDR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_ILS:
                generated_string_ISO4217Code = new JSONStringValue("ILS");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_INR:
                generated_string_ISO4217Code = new JSONStringValue("INR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_IQD:
                generated_string_ISO4217Code = new JSONStringValue("IQD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_IRR:
                generated_string_ISO4217Code = new JSONStringValue("IRR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_ISK:
                generated_string_ISO4217Code = new JSONStringValue("ISK");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_JMD:
                generated_string_ISO4217Code = new JSONStringValue("JMD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_JOD:
                generated_string_ISO4217Code = new JSONStringValue("JOD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_JPY:
                generated_string_ISO4217Code = new JSONStringValue("JPY");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_KES:
                generated_string_ISO4217Code = new JSONStringValue("KES");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_KGS:
                generated_string_ISO4217Code = new JSONStringValue("KGS");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_KHR:
                generated_string_ISO4217Code = new JSONStringValue("KHR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_KMF:
                generated_string_ISO4217Code = new JSONStringValue("KMF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_KPW:
                generated_string_ISO4217Code = new JSONStringValue("KPW");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_KRW:
                generated_string_ISO4217Code = new JSONStringValue("KRW");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_KWD:
                generated_string_ISO4217Code = new JSONStringValue("KWD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_KYD:
                generated_string_ISO4217Code = new JSONStringValue("KYD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_KZT:
                generated_string_ISO4217Code = new JSONStringValue("KZT");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_LAK:
                generated_string_ISO4217Code = new JSONStringValue("LAK");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_LBP:
                generated_string_ISO4217Code = new JSONStringValue("LBP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_LKR:
                generated_string_ISO4217Code = new JSONStringValue("LKR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_LRD:
                generated_string_ISO4217Code = new JSONStringValue("LRD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_LSL:
                generated_string_ISO4217Code = new JSONStringValue("LSL");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_LYD:
                generated_string_ISO4217Code = new JSONStringValue("LYD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MAD:
                generated_string_ISO4217Code = new JSONStringValue("MAD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MDL:
                generated_string_ISO4217Code = new JSONStringValue("MDL");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MGA:
                generated_string_ISO4217Code = new JSONStringValue("MGA");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MKD:
                generated_string_ISO4217Code = new JSONStringValue("MKD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MMK:
                generated_string_ISO4217Code = new JSONStringValue("MMK");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MNT:
                generated_string_ISO4217Code = new JSONStringValue("MNT");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MOP:
                generated_string_ISO4217Code = new JSONStringValue("MOP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MRU:
                generated_string_ISO4217Code = new JSONStringValue("MRU");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MUR:
                generated_string_ISO4217Code = new JSONStringValue("MUR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MVR:
                generated_string_ISO4217Code = new JSONStringValue("MVR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MWK:
                generated_string_ISO4217Code = new JSONStringValue("MWK");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MXN:
                generated_string_ISO4217Code = new JSONStringValue("MXN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MXV:
                generated_string_ISO4217Code = new JSONStringValue("MXV");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MYR:
                generated_string_ISO4217Code = new JSONStringValue("MYR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_MZN:
                generated_string_ISO4217Code = new JSONStringValue("MZN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_NAD:
                generated_string_ISO4217Code = new JSONStringValue("NAD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_NGN:
                generated_string_ISO4217Code = new JSONStringValue("NGN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_NIO:
                generated_string_ISO4217Code = new JSONStringValue("NIO");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_NOK:
                generated_string_ISO4217Code = new JSONStringValue("NOK");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_NPR:
                generated_string_ISO4217Code = new JSONStringValue("NPR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_NZD:
                generated_string_ISO4217Code = new JSONStringValue("NZD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_OMR:
                generated_string_ISO4217Code = new JSONStringValue("OMR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_PAB:
                generated_string_ISO4217Code = new JSONStringValue("PAB");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_PEN:
                generated_string_ISO4217Code = new JSONStringValue("PEN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_PGK:
                generated_string_ISO4217Code = new JSONStringValue("PGK");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_PHP:
                generated_string_ISO4217Code = new JSONStringValue("PHP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_PKR:
                generated_string_ISO4217Code = new JSONStringValue("PKR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_PLN:
                generated_string_ISO4217Code = new JSONStringValue("PLN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_PYG:
                generated_string_ISO4217Code = new JSONStringValue("PYG");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_QAR:
                generated_string_ISO4217Code = new JSONStringValue("QAR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_RON:
                generated_string_ISO4217Code = new JSONStringValue("RON");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_RSD:
                generated_string_ISO4217Code = new JSONStringValue("RSD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_RUB:
                generated_string_ISO4217Code = new JSONStringValue("RUB");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_RWF:
                generated_string_ISO4217Code = new JSONStringValue("RWF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SAR:
                generated_string_ISO4217Code = new JSONStringValue("SAR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SBD:
                generated_string_ISO4217Code = new JSONStringValue("SBD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SCR:
                generated_string_ISO4217Code = new JSONStringValue("SCR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SDG:
                generated_string_ISO4217Code = new JSONStringValue("SDG");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SEK:
                generated_string_ISO4217Code = new JSONStringValue("SEK");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SGD:
                generated_string_ISO4217Code = new JSONStringValue("SGD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SHP:
                generated_string_ISO4217Code = new JSONStringValue("SHP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SLL:
                generated_string_ISO4217Code = new JSONStringValue("SLL");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SOS:
                generated_string_ISO4217Code = new JSONStringValue("SOS");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SRD:
                generated_string_ISO4217Code = new JSONStringValue("SRD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SSP:
                generated_string_ISO4217Code = new JSONStringValue("SSP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_STN:
                generated_string_ISO4217Code = new JSONStringValue("STN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SVC:
                generated_string_ISO4217Code = new JSONStringValue("SVC");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SYP:
                generated_string_ISO4217Code = new JSONStringValue("SYP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_SZL:
                generated_string_ISO4217Code = new JSONStringValue("SZL");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_THB:
                generated_string_ISO4217Code = new JSONStringValue("THB");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_TJS:
                generated_string_ISO4217Code = new JSONStringValue("TJS");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_TMT:
                generated_string_ISO4217Code = new JSONStringValue("TMT");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_TND:
                generated_string_ISO4217Code = new JSONStringValue("TND");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_TOP:
                generated_string_ISO4217Code = new JSONStringValue("TOP");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_TRY:
                generated_string_ISO4217Code = new JSONStringValue("TRY");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_TTD:
                generated_string_ISO4217Code = new JSONStringValue("TTD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_TWD:
                generated_string_ISO4217Code = new JSONStringValue("TWD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_TZS:
                generated_string_ISO4217Code = new JSONStringValue("TZS");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_UAH:
                generated_string_ISO4217Code = new JSONStringValue("UAH");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_UGX:
                generated_string_ISO4217Code = new JSONStringValue("UGX");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_USD:
                generated_string_ISO4217Code = new JSONStringValue("USD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_USN:
                generated_string_ISO4217Code = new JSONStringValue("USN");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_UYI:
                generated_string_ISO4217Code = new JSONStringValue("UYI");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_UYU:
                generated_string_ISO4217Code = new JSONStringValue("UYU");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_UYW:
                generated_string_ISO4217Code = new JSONStringValue("UYW");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_UZS:
                generated_string_ISO4217Code = new JSONStringValue("UZS");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_VES:
                generated_string_ISO4217Code = new JSONStringValue("VES");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_VND:
                generated_string_ISO4217Code = new JSONStringValue("VND");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_VUV:
                generated_string_ISO4217Code = new JSONStringValue("VUV");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_WST:
                generated_string_ISO4217Code = new JSONStringValue("WST");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XAF:
                generated_string_ISO4217Code = new JSONStringValue("XAF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XAG:
                generated_string_ISO4217Code = new JSONStringValue("XAG");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XAU:
                generated_string_ISO4217Code = new JSONStringValue("XAU");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XBA:
                generated_string_ISO4217Code = new JSONStringValue("XBA");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XBB:
                generated_string_ISO4217Code = new JSONStringValue("XBB");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XBC:
                generated_string_ISO4217Code = new JSONStringValue("XBC");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XBD:
                generated_string_ISO4217Code = new JSONStringValue("XBD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XCD:
                generated_string_ISO4217Code = new JSONStringValue("XCD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XDR:
                generated_string_ISO4217Code = new JSONStringValue("XDR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XOF:
                generated_string_ISO4217Code = new JSONStringValue("XOF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XPD:
                generated_string_ISO4217Code = new JSONStringValue("XPD");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XPF:
                generated_string_ISO4217Code = new JSONStringValue("XPF");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XPT:
                generated_string_ISO4217Code = new JSONStringValue("XPT");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XSU:
                generated_string_ISO4217Code = new JSONStringValue("XSU");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XTS:
                generated_string_ISO4217Code = new JSONStringValue("XTS");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XUA:
                generated_string_ISO4217Code = new JSONStringValue("XUA");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_XXX:
                generated_string_ISO4217Code = new JSONStringValue("XXX");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_YER:
                generated_string_ISO4217Code = new JSONStringValue("YER");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_ZAR:
                generated_string_ISO4217Code = new JSONStringValue("ZAR");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_ZMW:
                generated_string_ISO4217Code = new JSONStringValue("ZMW");
                break;
            case TypeISO4217CodeKnownValues.ISO4217Code_ZWL:
                generated_string_ISO4217Code = new JSONStringValue("ZWL");
                break;
            default:
                Debug.Assert(false);
                generated_string_ISO4217Code = null;
                break;
          }
          }
        return generated_string_ISO4217Code;
      }


    private void  fromJSONISO4217Code(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ISO4217Code of MonetaryAmountUnitISO4217JSON is not a string.");
        TypeISO4217Code the_open_enum = new TypeISO4217Code();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'E':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_AED;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'F':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_AFN;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'L':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_ALL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_AMD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "G", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_ANG;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'O':
                        if ((String.Compare(json_string.getData(), 2, "A", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_AOA;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_ARS;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'U':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_AUD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'W':
                        if ((String.Compare(json_string.getData(), 2, "G", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_AWG;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Z':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_AZN;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 2, "M", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BAM;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'B':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BBD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'D':
                        if ((String.Compare(json_string.getData(), 2, "T", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BDT;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'G':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BGN;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'H':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BHD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'I':
                        if ((String.Compare(json_string.getData(), 2, "F", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BIF;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BMD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BND;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'O':
                        switch (json_string.getData()[2])
                          {
                            case 'B':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BOB;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'V':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BOV;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BRL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'S':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BSD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'T':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BTN;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'W':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BWP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Y':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BYN;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Z':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_BZD;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CAD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'D':
                        if ((String.Compare(json_string.getData(), 2, "F", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CDF;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'H':
                        switch (json_string.getData()[2])
                          {
                            case 'E':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CHE;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'F':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CHF;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'W':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CHW;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'L':
                        switch (json_string.getData()[2])
                          {
                            case 'F':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CLF;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'P':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CLP;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "Y", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CNY;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'O':
                        switch (json_string.getData()[2])
                          {
                            case 'P':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_COP;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'U':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_COU;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "C", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CRC;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'U':
                        switch (json_string.getData()[2])
                          {
                            case 'C':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CUC;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'P':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CUP;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'V':
                        if ((String.Compare(json_string.getData(), 2, "E", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CVE;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Z':
                        if ((String.Compare(json_string.getData(), 2, "K", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_CZK;
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
                    case 'J':
                        if ((String.Compare(json_string.getData(), 2, "F", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_DJF;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'K':
                        if ((String.Compare(json_string.getData(), 2, "K", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_DKK;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'O':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_DOP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Z':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_DZD;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                switch (json_string.getData()[1])
                  {
                    case 'G':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_EGP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_ERN;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'T':
                        if ((String.Compare(json_string.getData(), 2, "B", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_ETB;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'U':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_EUR;
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
                    case 'J':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_FJD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'K':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_FKP;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                switch (json_string.getData()[1])
                  {
                    case 'B':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_GBP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'E':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_GEL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'H':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_GHS;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'I':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_GIP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_GMD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "F", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_GNF;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'T':
                        if ((String.Compare(json_string.getData(), 2, "Q", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_GTQ;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Y':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_GYD;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'H':
                switch (json_string.getData()[1])
                  {
                    case 'K':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_HKD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_HNL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "K", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_HRK;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'T':
                        if ((String.Compare(json_string.getData(), 2, "G", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_HTG;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'U':
                        if ((String.Compare(json_string.getData(), 2, "F", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_HUF;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                switch (json_string.getData()[1])
                  {
                    case 'D':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_IDR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'L':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_ILS;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_INR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Q':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_IQD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_IRR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'S':
                        if ((String.Compare(json_string.getData(), 2, "K", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_ISK;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'J':
                switch (json_string.getData()[1])
                  {
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_JMD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'O':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_JOD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'P':
                        if ((String.Compare(json_string.getData(), 2, "Y", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_JPY;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'K':
                switch (json_string.getData()[1])
                  {
                    case 'E':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_KES;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'G':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_KGS;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'H':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_KHR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "F", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_KMF;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'P':
                        if ((String.Compare(json_string.getData(), 2, "W", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_KPW;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "W", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_KRW;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'W':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_KWD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Y':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_KYD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Z':
                        if ((String.Compare(json_string.getData(), 2, "T", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_KZT;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 2, "K", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_LAK;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'B':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_LBP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'K':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_LKR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_LRD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'S':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_LSL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Y':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_LYD;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MAD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'D':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MDL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'G':
                        if ((String.Compare(json_string.getData(), 2, "A", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MGA;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'K':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MKD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "K", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MMK;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "T", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MNT;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'O':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MOP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "U", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MRU;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'U':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MUR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'V':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MVR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'W':
                        if ((String.Compare(json_string.getData(), 2, "K", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MWK;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'X':
                        switch (json_string.getData()[2])
                          {
                            case 'N':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MXN;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'V':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MXV;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'Y':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MYR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Z':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_MZN;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_NAD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'G':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_NGN;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'I':
                        if ((String.Compare(json_string.getData(), 2, "O", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_NIO;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'O':
                        if ((String.Compare(json_string.getData(), 2, "K", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_NOK;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'P':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_NPR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Z':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_NZD;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "MR", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_OMR;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 2, "B", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_PAB;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'E':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_PEN;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'G':
                        if ((String.Compare(json_string.getData(), 2, "K", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_PGK;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'H':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_PHP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'K':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_PKR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'L':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_PLN;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Y':
                        if ((String.Compare(json_string.getData(), 2, "G", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_PYG;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(json_string.getData(), 1, "AR", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_QAR;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                switch (json_string.getData()[1])
                  {
                    case 'O':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_RON;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'S':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_RSD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'U':
                        if ((String.Compare(json_string.getData(), 2, "B", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_RUB;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'W':
                        if ((String.Compare(json_string.getData(), 2, "F", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_RWF;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SAR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'B':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SBD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'C':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SCR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'D':
                        if ((String.Compare(json_string.getData(), 2, "G", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SDG;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'E':
                        if ((String.Compare(json_string.getData(), 2, "K", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SEK;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'G':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SGD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'H':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SHP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'L':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SLL;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'O':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SOS;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SRD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'S':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SSP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'T':
                        if ((String.Compare(json_string.getData(), 2, "N", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_STN;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'V':
                        if ((String.Compare(json_string.getData(), 2, "C", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SVC;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Y':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SYP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Z':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_SZL;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (json_string.getData()[1])
                  {
                    case 'H':
                        if ((String.Compare(json_string.getData(), 2, "B", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_THB;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'J':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_TJS;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "T", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_TMT;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_TND;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'O':
                        if ((String.Compare(json_string.getData(), 2, "P", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_TOP;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "Y", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_TRY;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'T':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_TTD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'W':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_TWD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'Z':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_TZS;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 2, "H", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_UAH;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'G':
                        if ((String.Compare(json_string.getData(), 2, "X", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_UGX;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'S':
                        switch (json_string.getData()[2])
                          {
                            case 'D':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_USD;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'N':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_USN;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'Y':
                        switch (json_string.getData()[2])
                          {
                            case 'I':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_UYI;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'U':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_UYU;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'W':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_UYW;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'Z':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_UZS;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'V':
                switch (json_string.getData()[1])
                  {
                    case 'E':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_VES;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'N':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_VND;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'U':
                        if ((String.Compare(json_string.getData(), 2, "V", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_VUV;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "ST", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_WST;
                        goto open_enum_is_done;
                      }
                break;
            case 'X':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        switch (json_string.getData()[2])
                          {
                            case 'F':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XAF;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'G':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XAG;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'U':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XAU;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'B':
                        switch (json_string.getData()[2])
                          {
                            case 'A':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XBA;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'B':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XBB;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'C':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XBC;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'D':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XBD;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'C':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XCD;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'D':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XDR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'O':
                        if ((String.Compare(json_string.getData(), 2, "F", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XOF;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'P':
                        switch (json_string.getData()[2])
                          {
                            case 'D':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XPD;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'F':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XPF;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'T':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XPT;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'S':
                        if ((String.Compare(json_string.getData(), 2, "U", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XSU;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'T':
                        if ((String.Compare(json_string.getData(), 2, "S", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XTS;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'U':
                        if ((String.Compare(json_string.getData(), 2, "A", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XUA;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'X':
                        if ((String.Compare(json_string.getData(), 2, "X", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_XXX;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "ER", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_YER;
                        goto open_enum_is_done;
                      }
                break;
            case 'Z':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if ((String.Compare(json_string.getData(), 2, "R", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_ZAR;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'M':
                        if ((String.Compare(json_string.getData(), 2, "W", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_ZMW;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'W':
                        if ((String.Compare(json_string.getData(), 2, "L", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeISO4217CodeKnownValues.ISO4217Code_ZWL;
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
        setISO4217Code(the_open_enum);
      }


    public MonetaryAmountUnitISO4217JSON()
      {
        flagHasISO4217Code = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getMonetaryAmountKind()
      {
        return "ISO4217";
      }

    public bool  hasISO4217Code()
      {
        return flagHasISO4217Code;
      }

    public TypeISO4217Code  getISO4217Code()
      {
        Debug.Assert(flagHasISO4217Code);
        return storeISO4217Code;
      }

    public string  getISO4217CodeAsString()
      {
        TypeISO4217Code result = getISO4217Code();
        if (result.in_known_list)
            return stringFromISO4217Code(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraMonetaryAmountUnitISO4217ComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMonetaryAmountUnitISO4217ComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMonetaryAmountUnitISO4217ComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMonetaryAmountUnitISO4217Lookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMonetaryAmountUnitComponentCount()
      {
        int result = 0;
        if (flagHasISO4217Code)
            ++result;
        result += extraMonetaryAmountUnitISO4217ComponentCount();
        return result;
      }
    public override string extraMonetaryAmountUnitComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasISO4217Code)
          {
            if (remainder == 0)
                return "ISO4217Code";
            --remainder;
          }
        return extraMonetaryAmountUnitISO4217ComponentKey(remainder);
      }
    public override JSONValue extraMonetaryAmountUnitComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasISO4217Code)
          {
            if (remainder == 0)
                return extraISO4217CodeToJSON();
            --remainder;
          }
        return extraMonetaryAmountUnitISO4217ComponentValue(remainder);
      }
    public override JSONValue extraMonetaryAmountUnitLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "ISO4217Code", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasISO4217Code ? extraISO4217CodeToJSON() : null);
        return extraMonetaryAmountUnitISO4217Lookup(field_name);
      }

    public void setISO4217Code(TypeISO4217Code new_value)
      {
        flagHasISO4217Code = true;
        storeISO4217Code = new_value;
      }
    public void setISO4217Code(string chars)
      {
        TypeISO4217CodeKnownValues known = stringToISO4217Code(chars);
        TypeISO4217Code new_value = new TypeISO4217Code();
        if (known == TypeISO4217CodeKnownValues.ISO4217Code__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setISO4217Code(new_value);
      }
    public void setISO4217Code(TypeISO4217CodeKnownValues new_value)
      {
        TypeISO4217Code new_full_value = new TypeISO4217Code();
        Debug.Assert(new_value != TypeISO4217CodeKnownValues.ISO4217Code__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setISO4217Code(new_full_value);
      }
    public void unsetISO4217Code()
      {
        flagHasISO4217Code = false;
      }

    public virtual void extraMonetaryAmountUnitISO4217AppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMonetaryAmountUnitISO4217SetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMonetaryAmountUnitISO4217Lookup(key);
        if (old_field == null)
          {
            extraMonetaryAmountUnitISO4217AppendPair(key, new_component);
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
    public override void extraMonetaryAmountUnitAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "ISO4217Code", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONISO4217Code(new_component, false);
            return;
            }
        extraMonetaryAmountUnitISO4217AppendPair(key, new_component);
      }
    public override void extraMonetaryAmountUnitSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "ISO4217Code", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONISO4217Code(new_component, false);
            return;
            }
        extraMonetaryAmountUnitISO4217SetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasISO4217Code);
        if (flagHasISO4217Code)
          {
            handler.start_pair("ISO4217Code");
            if (storeISO4217Code.in_known_list)
              {
                switch (storeISO4217Code.list_value)
                  {
                    case TypeISO4217CodeKnownValues.ISO4217Code_AED:
                        handler.string_value("AED");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_AFN:
                        handler.string_value("AFN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_ALL:
                        handler.string_value("ALL");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_AMD:
                        handler.string_value("AMD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_ANG:
                        handler.string_value("ANG");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_AOA:
                        handler.string_value("AOA");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_ARS:
                        handler.string_value("ARS");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_AUD:
                        handler.string_value("AUD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_AWG:
                        handler.string_value("AWG");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_AZN:
                        handler.string_value("AZN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BAM:
                        handler.string_value("BAM");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BBD:
                        handler.string_value("BBD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BDT:
                        handler.string_value("BDT");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BGN:
                        handler.string_value("BGN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BHD:
                        handler.string_value("BHD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BIF:
                        handler.string_value("BIF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BMD:
                        handler.string_value("BMD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BND:
                        handler.string_value("BND");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BOB:
                        handler.string_value("BOB");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BOV:
                        handler.string_value("BOV");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BRL:
                        handler.string_value("BRL");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BSD:
                        handler.string_value("BSD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BTN:
                        handler.string_value("BTN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BWP:
                        handler.string_value("BWP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BYN:
                        handler.string_value("BYN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_BZD:
                        handler.string_value("BZD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CAD:
                        handler.string_value("CAD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CDF:
                        handler.string_value("CDF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CHE:
                        handler.string_value("CHE");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CHF:
                        handler.string_value("CHF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CHW:
                        handler.string_value("CHW");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CLF:
                        handler.string_value("CLF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CLP:
                        handler.string_value("CLP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CNY:
                        handler.string_value("CNY");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_COP:
                        handler.string_value("COP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_COU:
                        handler.string_value("COU");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CRC:
                        handler.string_value("CRC");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CUC:
                        handler.string_value("CUC");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CUP:
                        handler.string_value("CUP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CVE:
                        handler.string_value("CVE");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_CZK:
                        handler.string_value("CZK");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_DJF:
                        handler.string_value("DJF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_DKK:
                        handler.string_value("DKK");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_DOP:
                        handler.string_value("DOP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_DZD:
                        handler.string_value("DZD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_EGP:
                        handler.string_value("EGP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_ERN:
                        handler.string_value("ERN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_ETB:
                        handler.string_value("ETB");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_EUR:
                        handler.string_value("EUR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_FJD:
                        handler.string_value("FJD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_FKP:
                        handler.string_value("FKP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_GBP:
                        handler.string_value("GBP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_GEL:
                        handler.string_value("GEL");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_GHS:
                        handler.string_value("GHS");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_GIP:
                        handler.string_value("GIP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_GMD:
                        handler.string_value("GMD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_GNF:
                        handler.string_value("GNF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_GTQ:
                        handler.string_value("GTQ");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_GYD:
                        handler.string_value("GYD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_HKD:
                        handler.string_value("HKD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_HNL:
                        handler.string_value("HNL");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_HRK:
                        handler.string_value("HRK");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_HTG:
                        handler.string_value("HTG");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_HUF:
                        handler.string_value("HUF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_IDR:
                        handler.string_value("IDR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_ILS:
                        handler.string_value("ILS");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_INR:
                        handler.string_value("INR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_IQD:
                        handler.string_value("IQD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_IRR:
                        handler.string_value("IRR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_ISK:
                        handler.string_value("ISK");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_JMD:
                        handler.string_value("JMD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_JOD:
                        handler.string_value("JOD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_JPY:
                        handler.string_value("JPY");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_KES:
                        handler.string_value("KES");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_KGS:
                        handler.string_value("KGS");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_KHR:
                        handler.string_value("KHR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_KMF:
                        handler.string_value("KMF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_KPW:
                        handler.string_value("KPW");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_KRW:
                        handler.string_value("KRW");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_KWD:
                        handler.string_value("KWD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_KYD:
                        handler.string_value("KYD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_KZT:
                        handler.string_value("KZT");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_LAK:
                        handler.string_value("LAK");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_LBP:
                        handler.string_value("LBP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_LKR:
                        handler.string_value("LKR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_LRD:
                        handler.string_value("LRD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_LSL:
                        handler.string_value("LSL");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_LYD:
                        handler.string_value("LYD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MAD:
                        handler.string_value("MAD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MDL:
                        handler.string_value("MDL");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MGA:
                        handler.string_value("MGA");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MKD:
                        handler.string_value("MKD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MMK:
                        handler.string_value("MMK");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MNT:
                        handler.string_value("MNT");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MOP:
                        handler.string_value("MOP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MRU:
                        handler.string_value("MRU");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MUR:
                        handler.string_value("MUR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MVR:
                        handler.string_value("MVR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MWK:
                        handler.string_value("MWK");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MXN:
                        handler.string_value("MXN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MXV:
                        handler.string_value("MXV");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MYR:
                        handler.string_value("MYR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_MZN:
                        handler.string_value("MZN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_NAD:
                        handler.string_value("NAD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_NGN:
                        handler.string_value("NGN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_NIO:
                        handler.string_value("NIO");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_NOK:
                        handler.string_value("NOK");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_NPR:
                        handler.string_value("NPR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_NZD:
                        handler.string_value("NZD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_OMR:
                        handler.string_value("OMR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_PAB:
                        handler.string_value("PAB");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_PEN:
                        handler.string_value("PEN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_PGK:
                        handler.string_value("PGK");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_PHP:
                        handler.string_value("PHP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_PKR:
                        handler.string_value("PKR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_PLN:
                        handler.string_value("PLN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_PYG:
                        handler.string_value("PYG");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_QAR:
                        handler.string_value("QAR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_RON:
                        handler.string_value("RON");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_RSD:
                        handler.string_value("RSD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_RUB:
                        handler.string_value("RUB");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_RWF:
                        handler.string_value("RWF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SAR:
                        handler.string_value("SAR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SBD:
                        handler.string_value("SBD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SCR:
                        handler.string_value("SCR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SDG:
                        handler.string_value("SDG");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SEK:
                        handler.string_value("SEK");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SGD:
                        handler.string_value("SGD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SHP:
                        handler.string_value("SHP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SLL:
                        handler.string_value("SLL");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SOS:
                        handler.string_value("SOS");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SRD:
                        handler.string_value("SRD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SSP:
                        handler.string_value("SSP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_STN:
                        handler.string_value("STN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SVC:
                        handler.string_value("SVC");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SYP:
                        handler.string_value("SYP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_SZL:
                        handler.string_value("SZL");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_THB:
                        handler.string_value("THB");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_TJS:
                        handler.string_value("TJS");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_TMT:
                        handler.string_value("TMT");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_TND:
                        handler.string_value("TND");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_TOP:
                        handler.string_value("TOP");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_TRY:
                        handler.string_value("TRY");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_TTD:
                        handler.string_value("TTD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_TWD:
                        handler.string_value("TWD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_TZS:
                        handler.string_value("TZS");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_UAH:
                        handler.string_value("UAH");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_UGX:
                        handler.string_value("UGX");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_USD:
                        handler.string_value("USD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_USN:
                        handler.string_value("USN");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_UYI:
                        handler.string_value("UYI");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_UYU:
                        handler.string_value("UYU");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_UYW:
                        handler.string_value("UYW");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_UZS:
                        handler.string_value("UZS");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_VES:
                        handler.string_value("VES");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_VND:
                        handler.string_value("VND");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_VUV:
                        handler.string_value("VUV");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_WST:
                        handler.string_value("WST");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XAF:
                        handler.string_value("XAF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XAG:
                        handler.string_value("XAG");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XAU:
                        handler.string_value("XAU");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XBA:
                        handler.string_value("XBA");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XBB:
                        handler.string_value("XBB");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XBC:
                        handler.string_value("XBC");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XBD:
                        handler.string_value("XBD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XCD:
                        handler.string_value("XCD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XDR:
                        handler.string_value("XDR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XOF:
                        handler.string_value("XOF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XPD:
                        handler.string_value("XPD");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XPF:
                        handler.string_value("XPF");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XPT:
                        handler.string_value("XPT");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XSU:
                        handler.string_value("XSU");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XTS:
                        handler.string_value("XTS");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XUA:
                        handler.string_value("XUA");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_XXX:
                        handler.string_value("XXX");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_YER:
                        handler.string_value("YER");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_ZAR:
                        handler.string_value("ZAR");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_ZMW:
                        handler.string_value("ZMW");
                        break;
                    case TypeISO4217CodeKnownValues.ISO4217Code_ZWL:
                        handler.string_value("ZWL");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeISO4217Code.string_value);
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
        if (!(hasISO4217Code()))
          {
            return "When parsing the object for %what%, the \"ISO4217Code\" field was missing.";
          }
        return null;
      }

    public static new MonetaryAmountUnitISO4217JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MonetaryAmountUnitISO4217JSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryAmountUnitISO4217", ignore_extras);
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
    public static new MonetaryAmountUnitISO4217JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MonetaryAmountUnitISO4217JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MonetaryAmountUnitISO4217JSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryAmountUnitISO4217", ignore_extras);
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
    public static new MonetaryAmountUnitISO4217JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MonetaryAmountUnitISO4217JSON from_text(string text, bool ignore_extras)
      {
        MonetaryAmountUnitISO4217JSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryAmountUnitISO4217", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MonetaryAmountUnitISO4217JSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MonetaryAmountUnitISO4217JSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MonetaryAmountUnitISO4217JSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonetaryAmountUnitISO4217", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MonetaryAmountUnitJSON.Generator
      {
    private abstract class FieldGeneratorISO4217Code : JSONStringGenerator
          {
            protected FieldGeneratorISO4217Code(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorISO4217Code()
              {
              }
            protected override void handle_result(string result)
              {
                TypeISO4217CodeKnownValues known = stringToISO4217Code(result);
                TypeISO4217Code new_value = new TypeISO4217Code();
                if (known == TypeISO4217CodeKnownValues.ISO4217Code__none)
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
            protected abstract void handle_result(TypeISO4217Code result);
          };
    private class FieldHoldingGeneratorISO4217Code : FieldGeneratorISO4217Code
  {
    protected override void handle_result(TypeISO4217Code result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorISO4217Code(String what)
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
    public TypeISO4217Code value;
  };
    private class FieldHoldingArrayGeneratorISO4217Code : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorISO4217Code
      {
        private FieldHoldingArrayGeneratorISO4217Code top;

        protected override void handle_result(TypeISO4217Code result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorISO4217Code init_top)
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
    protected virtual void handle_result(List<TypeISO4217Code> result)
      {
      }

    public FieldHoldingArrayGeneratorISO4217Code(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeISO4217Code>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorISO4217Code()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeISO4217Code>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeISO4217Code> value;
  };
        private FieldHoldingGeneratorISO4217Code fieldGeneratorISO4217Code;
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
            if (!(getMonetaryAmountUnitJSONKey().Equals("ISO4217")))
                throw new Exception("The key field has a value other than `ISO4217'.");
            MonetaryAmountUnitISO4217JSON result = new MonetaryAmountUnitISO4217JSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMonetaryAmountUnitISO4217AppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MonetaryAmountUnitJSON new_result)
          {
            handle_result((MonetaryAmountUnitISO4217JSON )new_result);
          }
        protected void finish(MonetaryAmountUnitISO4217JSON result)
          {
            if (fieldGeneratorISO4217Code.have_value)
              {
                result.setISO4217Code(fieldGeneratorISO4217Code.value);
                fieldGeneratorISO4217Code.have_value = false;
              }
            else if ((!(result.hasISO4217Code())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ISO4217Code\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MonetaryAmountUnitISO4217JSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "ISO4217Code", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorISO4217Code;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorISO4217Code = new FieldHoldingGeneratorISO4217Code("field \"ISO4217Code\" of the MonetaryAmountUnitISO4217 class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MonetaryAmountUnitISO4217 class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorISO4217Code = new FieldHoldingGeneratorISO4217Code("field \"ISO4217Code\" of the MonetaryAmountUnitISO4217 class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MonetaryAmountUnitISO4217 class");
          }

        public override void reset()
          {
            fieldGeneratorISO4217Code.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MonetaryAmountUnitISO4217JSON  result)
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
        public MonetaryAmountUnitISO4217JSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MonetaryAmountUnitISO4217JSON  result)
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
    protected virtual void handle_result(List<MonetaryAmountUnitISO4217JSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MonetaryAmountUnitISO4217JSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MonetaryAmountUnitISO4217JSON>();
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
    public List<MonetaryAmountUnitISO4217JSON> value;
  };
  };
