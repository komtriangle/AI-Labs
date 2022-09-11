/* file "YelpUserPreferencesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class YelpUserPreferencesJSON : JSONBase
  {
    public struct TypeStarRatingMin
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public double choice1;
          };
        public Utype u;
      };
    public struct TypeStarRatingMax
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public double choice1;
          };
        public Utype u;
      };
    public struct TypeReviewCountMin
      {
        public int key;
        public bool choice0;
        public BigInteger choice1;
      };
    public struct TypeReviewCountMax
      {
        public int key;
        public bool choice0;
        public BigInteger choice1;
      };
    public struct TypeDollarSignMin
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public double choice1;
          };
        public Utype u;
      };
    public struct TypeDollarSignMax
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public double choice1;
          };
        public Utype u;
      };
    public struct TypeDelivers
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeReservations
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeGoodForKids
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeOutdoorSeating
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeWifiFree
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeWifiPaid
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeParkingLot
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeParkingStreet
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeParkingGarage
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeParkingValet
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeParkingValidated
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct TypeSmoking
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    private bool flagHasStarRatingMin;
    private TypeStarRatingMin storeStarRatingMin;
    private bool flagHasStarRatingMax;
    private TypeStarRatingMax storeStarRatingMax;
    private bool flagHasReviewCountMin;
    private TypeReviewCountMin storeReviewCountMin;
    private bool flagHasReviewCountMax;
    private TypeReviewCountMax storeReviewCountMax;
    private bool flagHasDollarSignMin;
    private TypeDollarSignMin storeDollarSignMin;
    private bool flagHasDollarSignMax;
    private TypeDollarSignMax storeDollarSignMax;
    private bool flagHasDelivers;
    private TypeDelivers storeDelivers;
    private bool flagHasReservations;
    private TypeReservations storeReservations;
    private bool flagHasGoodForKids;
    private TypeGoodForKids storeGoodForKids;
    private bool flagHasOutdoorSeating;
    private TypeOutdoorSeating storeOutdoorSeating;
    private bool flagHasWifiFree;
    private TypeWifiFree storeWifiFree;
    private bool flagHasWifiPaid;
    private TypeWifiPaid storeWifiPaid;
    private bool flagHasParkingLot;
    private TypeParkingLot storeParkingLot;
    private bool flagHasParkingStreet;
    private TypeParkingStreet storeParkingStreet;
    private bool flagHasParkingGarage;
    private TypeParkingGarage storeParkingGarage;
    private bool flagHasParkingValet;
    private TypeParkingValet storeParkingValet;
    private bool flagHasParkingValidated;
    private TypeParkingValidated storeParkingValidated;
    private bool flagHasSmoking;
    private TypeSmoking storeSmoking;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStarRatingMin(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeStarRatingMin or_result = new TypeStarRatingMin();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                if (the_double < 0)
                    throw new Exception("The value for ??? is less than the lower bound (0) for that field.");
                if (the_double > 6)
                    throw new Exception("The value for ??? is greater than the upper bound (6) for that field.");
                or_result.u.choice1 = the_double;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field StarRatingMin of YelpUserPreferencesJSON is not one of the allowed values.");
        setStarRatingMin(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONStarRatingMax(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeStarRatingMax or_result = new TypeStarRatingMax();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                if (the_double < 0)
                    throw new Exception("The value for ??? is less than the lower bound (0) for that field.");
                if (the_double > 6)
                    throw new Exception("The value for ??? is greater than the upper bound (6) for that field.");
                or_result.u.choice1 = the_double;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field StarRatingMax of YelpUserPreferencesJSON is not one of the allowed values.");
        setStarRatingMax(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONReviewCountMin(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeReviewCountMin or_result = new TypeReviewCountMin();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for ??? is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                if (extracted_integer < 0)
                    throw new Exception("The value for ??? is less than the lower bound (0) for that field.");
                or_result.choice1 = extracted_integer;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field ReviewCountMin of YelpUserPreferencesJSON is not one of the allowed values.");
        setReviewCountMin(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONReviewCountMax(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeReviewCountMax or_result = new TypeReviewCountMax();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for ??? is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                if (extracted_integer < 0)
                    throw new Exception("The value for ??? is less than the lower bound (0) for that field.");
                or_result.choice1 = extracted_integer;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field ReviewCountMax of YelpUserPreferencesJSON is not one of the allowed values.");
        setReviewCountMax(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONDollarSignMin(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDollarSignMin or_result = new TypeDollarSignMin();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                if (the_double < 0)
                    throw new Exception("The value for ??? is less than the lower bound (0) for that field.");
                if (the_double > 6)
                    throw new Exception("The value for ??? is greater than the upper bound (6) for that field.");
                or_result.u.choice1 = the_double;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field DollarSignMin of YelpUserPreferencesJSON is not one of the allowed values.");
        setDollarSignMin(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONDollarSignMax(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDollarSignMax or_result = new TypeDollarSignMax();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                if (the_double < 0)
                    throw new Exception("The value for ??? is less than the lower bound (0) for that field.");
                if (the_double > 6)
                    throw new Exception("The value for ??? is greater than the upper bound (6) for that field.");
                or_result.u.choice1 = the_double;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field DollarSignMax of YelpUserPreferencesJSON is not one of the allowed values.");
        setDollarSignMax(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONDelivers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDelivers or_result = new TypeDelivers();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Delivers of YelpUserPreferencesJSON is not one of the allowed values.");
        setDelivers(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONReservations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeReservations or_result = new TypeReservations();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Reservations of YelpUserPreferencesJSON is not one of the allowed values.");
        setReservations(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONGoodForKids(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeGoodForKids or_result = new TypeGoodForKids();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field GoodForKids of YelpUserPreferencesJSON is not one of the allowed values.");
        setGoodForKids(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONOutdoorSeating(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeOutdoorSeating or_result = new TypeOutdoorSeating();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field OutdoorSeating of YelpUserPreferencesJSON is not one of the allowed values.");
        setOutdoorSeating(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONWifiFree(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeWifiFree or_result = new TypeWifiFree();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field WifiFree of YelpUserPreferencesJSON is not one of the allowed values.");
        setWifiFree(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONWifiPaid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeWifiPaid or_result = new TypeWifiPaid();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field WifiPaid of YelpUserPreferencesJSON is not one of the allowed values.");
        setWifiPaid(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONParkingLot(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeParkingLot or_result = new TypeParkingLot();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field ParkingLot of YelpUserPreferencesJSON is not one of the allowed values.");
        setParkingLot(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONParkingStreet(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeParkingStreet or_result = new TypeParkingStreet();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field ParkingStreet of YelpUserPreferencesJSON is not one of the allowed values.");
        setParkingStreet(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONParkingGarage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeParkingGarage or_result = new TypeParkingGarage();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field ParkingGarage of YelpUserPreferencesJSON is not one of the allowed values.");
        setParkingGarage(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONParkingValet(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeParkingValet or_result = new TypeParkingValet();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field ParkingValet of YelpUserPreferencesJSON is not one of the allowed values.");
        setParkingValet(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONParkingValidated(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeParkingValidated or_result = new TypeParkingValidated();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field ParkingValidated of YelpUserPreferencesJSON is not one of the allowed values.");
        setParkingValidated(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONSmoking(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSmoking or_result = new TypeSmoking();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
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
                        throw new Exception("The value for ??? is not true for false.");
                      }
                  }
                or_result.u.choice1 = the_bool;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Smoking of YelpUserPreferencesJSON is not one of the allowed values.");
        setSmoking(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    public YelpUserPreferencesJSON()
      {
        flagHasStarRatingMin = false;
        flagHasStarRatingMax = false;
        flagHasReviewCountMin = false;
        flagHasReviewCountMax = false;
        flagHasDollarSignMin = false;
        flagHasDollarSignMax = false;
        flagHasDelivers = false;
        flagHasReservations = false;
        flagHasGoodForKids = false;
        flagHasOutdoorSeating = false;
        flagHasWifiFree = false;
        flagHasWifiPaid = false;
        flagHasParkingLot = false;
        flagHasParkingStreet = false;
        flagHasParkingGarage = false;
        flagHasParkingValet = false;
        flagHasParkingValidated = false;
        flagHasSmoking = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStarRatingMin()
      {
        return flagHasStarRatingMin;
      }

    public TypeStarRatingMin  getStarRatingMin()
      {
        Debug.Assert(flagHasStarRatingMin);
        return storeStarRatingMin;
      }

    public bool  hasStarRatingMax()
      {
        return flagHasStarRatingMax;
      }

    public TypeStarRatingMax  getStarRatingMax()
      {
        Debug.Assert(flagHasStarRatingMax);
        return storeStarRatingMax;
      }

    public bool  hasReviewCountMin()
      {
        return flagHasReviewCountMin;
      }

    public TypeReviewCountMin  getReviewCountMin()
      {
        Debug.Assert(flagHasReviewCountMin);
        return storeReviewCountMin;
      }

    public bool  hasReviewCountMax()
      {
        return flagHasReviewCountMax;
      }

    public TypeReviewCountMax  getReviewCountMax()
      {
        Debug.Assert(flagHasReviewCountMax);
        return storeReviewCountMax;
      }

    public bool  hasDollarSignMin()
      {
        return flagHasDollarSignMin;
      }

    public TypeDollarSignMin  getDollarSignMin()
      {
        Debug.Assert(flagHasDollarSignMin);
        return storeDollarSignMin;
      }

    public bool  hasDollarSignMax()
      {
        return flagHasDollarSignMax;
      }

    public TypeDollarSignMax  getDollarSignMax()
      {
        Debug.Assert(flagHasDollarSignMax);
        return storeDollarSignMax;
      }

    public bool  hasDelivers()
      {
        return flagHasDelivers;
      }

    public TypeDelivers  getDelivers()
      {
        Debug.Assert(flagHasDelivers);
        return storeDelivers;
      }

    public bool  hasReservations()
      {
        return flagHasReservations;
      }

    public TypeReservations  getReservations()
      {
        Debug.Assert(flagHasReservations);
        return storeReservations;
      }

    public bool  hasGoodForKids()
      {
        return flagHasGoodForKids;
      }

    public TypeGoodForKids  getGoodForKids()
      {
        Debug.Assert(flagHasGoodForKids);
        return storeGoodForKids;
      }

    public bool  hasOutdoorSeating()
      {
        return flagHasOutdoorSeating;
      }

    public TypeOutdoorSeating  getOutdoorSeating()
      {
        Debug.Assert(flagHasOutdoorSeating);
        return storeOutdoorSeating;
      }

    public bool  hasWifiFree()
      {
        return flagHasWifiFree;
      }

    public TypeWifiFree  getWifiFree()
      {
        Debug.Assert(flagHasWifiFree);
        return storeWifiFree;
      }

    public bool  hasWifiPaid()
      {
        return flagHasWifiPaid;
      }

    public TypeWifiPaid  getWifiPaid()
      {
        Debug.Assert(flagHasWifiPaid);
        return storeWifiPaid;
      }

    public bool  hasParkingLot()
      {
        return flagHasParkingLot;
      }

    public TypeParkingLot  getParkingLot()
      {
        Debug.Assert(flagHasParkingLot);
        return storeParkingLot;
      }

    public bool  hasParkingStreet()
      {
        return flagHasParkingStreet;
      }

    public TypeParkingStreet  getParkingStreet()
      {
        Debug.Assert(flagHasParkingStreet);
        return storeParkingStreet;
      }

    public bool  hasParkingGarage()
      {
        return flagHasParkingGarage;
      }

    public TypeParkingGarage  getParkingGarage()
      {
        Debug.Assert(flagHasParkingGarage);
        return storeParkingGarage;
      }

    public bool  hasParkingValet()
      {
        return flagHasParkingValet;
      }

    public TypeParkingValet  getParkingValet()
      {
        Debug.Assert(flagHasParkingValet);
        return storeParkingValet;
      }

    public bool  hasParkingValidated()
      {
        return flagHasParkingValidated;
      }

    public TypeParkingValidated  getParkingValidated()
      {
        Debug.Assert(flagHasParkingValidated);
        return storeParkingValidated;
      }

    public bool  hasSmoking()
      {
        return flagHasSmoking;
      }

    public TypeSmoking  getSmoking()
      {
        Debug.Assert(flagHasSmoking);
        return storeSmoking;
      }


    public virtual int extraYelpUserPreferencesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraYelpUserPreferencesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraYelpUserPreferencesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraYelpUserPreferencesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStarRatingMin(TypeStarRatingMin new_value)
      {
        flagHasStarRatingMin = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                if (new_value.u.choice1 < 0)
                    throw new Exception("The value for case 1 of field StarRatingMin of YelpUserPreferencesJSON is less than the lower bound (0) for that field.");
                if (new_value.u.choice1 > 6)
                    throw new Exception("The value for case 1 of field StarRatingMin of YelpUserPreferencesJSON is greater than the upper bound (6) for that field.");
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeStarRatingMin = new_value;
      }
    public void unsetStarRatingMin()
      {
        flagHasStarRatingMin = false;
      }
    public void setStarRatingMax(TypeStarRatingMax new_value)
      {
        flagHasStarRatingMax = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                if (new_value.u.choice1 < 0)
                    throw new Exception("The value for case 1 of field StarRatingMax of YelpUserPreferencesJSON is less than the lower bound (0) for that field.");
                if (new_value.u.choice1 > 6)
                    throw new Exception("The value for case 1 of field StarRatingMax of YelpUserPreferencesJSON is greater than the upper bound (6) for that field.");
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeStarRatingMax = new_value;
      }
    public void unsetStarRatingMax()
      {
        flagHasStarRatingMax = false;
      }
    public void setReviewCountMin(TypeReviewCountMin new_value)
      {
        flagHasReviewCountMin = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                if (new_value.choice1 < 0)
                    throw new Exception("The value for case 1 of field ReviewCountMin of YelpUserPreferencesJSON is less than the lower bound (0) for that field.");
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeReviewCountMin = new_value;
      }
    public void unsetReviewCountMin()
      {
        flagHasReviewCountMin = false;
      }
    public void setReviewCountMax(TypeReviewCountMax new_value)
      {
        flagHasReviewCountMax = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                if (new_value.choice1 < 0)
                    throw new Exception("The value for case 1 of field ReviewCountMax of YelpUserPreferencesJSON is less than the lower bound (0) for that field.");
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeReviewCountMax = new_value;
      }
    public void unsetReviewCountMax()
      {
        flagHasReviewCountMax = false;
      }
    public void setDollarSignMin(TypeDollarSignMin new_value)
      {
        flagHasDollarSignMin = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                if (new_value.u.choice1 < 0)
                    throw new Exception("The value for case 1 of field DollarSignMin of YelpUserPreferencesJSON is less than the lower bound (0) for that field.");
                if (new_value.u.choice1 > 6)
                    throw new Exception("The value for case 1 of field DollarSignMin of YelpUserPreferencesJSON is greater than the upper bound (6) for that field.");
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeDollarSignMin = new_value;
      }
    public void unsetDollarSignMin()
      {
        flagHasDollarSignMin = false;
      }
    public void setDollarSignMax(TypeDollarSignMax new_value)
      {
        flagHasDollarSignMax = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                if (new_value.u.choice1 < 0)
                    throw new Exception("The value for case 1 of field DollarSignMax of YelpUserPreferencesJSON is less than the lower bound (0) for that field.");
                if (new_value.u.choice1 > 6)
                    throw new Exception("The value for case 1 of field DollarSignMax of YelpUserPreferencesJSON is greater than the upper bound (6) for that field.");
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeDollarSignMax = new_value;
      }
    public void unsetDollarSignMax()
      {
        flagHasDollarSignMax = false;
      }
    public void setDelivers(TypeDelivers new_value)
      {
        flagHasDelivers = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeDelivers = new_value;
      }
    public void unsetDelivers()
      {
        flagHasDelivers = false;
      }
    public void setReservations(TypeReservations new_value)
      {
        flagHasReservations = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeReservations = new_value;
      }
    public void unsetReservations()
      {
        flagHasReservations = false;
      }
    public void setGoodForKids(TypeGoodForKids new_value)
      {
        flagHasGoodForKids = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeGoodForKids = new_value;
      }
    public void unsetGoodForKids()
      {
        flagHasGoodForKids = false;
      }
    public void setOutdoorSeating(TypeOutdoorSeating new_value)
      {
        flagHasOutdoorSeating = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeOutdoorSeating = new_value;
      }
    public void unsetOutdoorSeating()
      {
        flagHasOutdoorSeating = false;
      }
    public void setWifiFree(TypeWifiFree new_value)
      {
        flagHasWifiFree = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeWifiFree = new_value;
      }
    public void unsetWifiFree()
      {
        flagHasWifiFree = false;
      }
    public void setWifiPaid(TypeWifiPaid new_value)
      {
        flagHasWifiPaid = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeWifiPaid = new_value;
      }
    public void unsetWifiPaid()
      {
        flagHasWifiPaid = false;
      }
    public void setParkingLot(TypeParkingLot new_value)
      {
        flagHasParkingLot = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeParkingLot = new_value;
      }
    public void unsetParkingLot()
      {
        flagHasParkingLot = false;
      }
    public void setParkingStreet(TypeParkingStreet new_value)
      {
        flagHasParkingStreet = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeParkingStreet = new_value;
      }
    public void unsetParkingStreet()
      {
        flagHasParkingStreet = false;
      }
    public void setParkingGarage(TypeParkingGarage new_value)
      {
        flagHasParkingGarage = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeParkingGarage = new_value;
      }
    public void unsetParkingGarage()
      {
        flagHasParkingGarage = false;
      }
    public void setParkingValet(TypeParkingValet new_value)
      {
        flagHasParkingValet = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeParkingValet = new_value;
      }
    public void unsetParkingValet()
      {
        flagHasParkingValet = false;
      }
    public void setParkingValidated(TypeParkingValidated new_value)
      {
        flagHasParkingValidated = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeParkingValidated = new_value;
      }
    public void unsetParkingValidated()
      {
        flagHasParkingValidated = false;
      }
    public void setSmoking(TypeSmoking new_value)
      {
        flagHasSmoking = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeSmoking = new_value;
      }
    public void unsetSmoking()
      {
        flagHasSmoking = false;
      }

    public virtual void extraYelpUserPreferencesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraYelpUserPreferencesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraYelpUserPreferencesLookup(key);
        if (old_field == null)
          {
            extraYelpUserPreferencesAppendPair(key, new_component);
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
        if (flagHasStarRatingMin)
          {
            handler.start_pair("StarRatingMin");
            switch (storeStarRatingMin.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    if (((double)(long)storeStarRatingMin.u.choice1) == storeStarRatingMin.u.choice1)
                        handler.number_value((long)storeStarRatingMin.u.choice1);
                    else
                        handler.number_value(storeStarRatingMin.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasStarRatingMax)
          {
            handler.start_pair("StarRatingMax");
            switch (storeStarRatingMax.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    if (((double)(long)storeStarRatingMax.u.choice1) == storeStarRatingMax.u.choice1)
                        handler.number_value((long)storeStarRatingMax.u.choice1);
                    else
                        handler.number_value(storeStarRatingMax.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasReviewCountMin)
          {
            handler.start_pair("ReviewCountMin");
            switch (storeReviewCountMin.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.number_value(storeReviewCountMin.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasReviewCountMax)
          {
            handler.start_pair("ReviewCountMax");
            switch (storeReviewCountMax.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.number_value(storeReviewCountMax.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasDollarSignMin)
          {
            handler.start_pair("DollarSignMin");
            switch (storeDollarSignMin.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    if (((double)(long)storeDollarSignMin.u.choice1) == storeDollarSignMin.u.choice1)
                        handler.number_value((long)storeDollarSignMin.u.choice1);
                    else
                        handler.number_value(storeDollarSignMin.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasDollarSignMax)
          {
            handler.start_pair("DollarSignMax");
            switch (storeDollarSignMax.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    if (((double)(long)storeDollarSignMax.u.choice1) == storeDollarSignMax.u.choice1)
                        handler.number_value((long)storeDollarSignMax.u.choice1);
                    else
                        handler.number_value(storeDollarSignMax.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasDelivers)
          {
            handler.start_pair("Delivers");
            switch (storeDelivers.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeDelivers.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasReservations)
          {
            handler.start_pair("Reservations");
            switch (storeReservations.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeReservations.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasGoodForKids)
          {
            handler.start_pair("GoodForKids");
            switch (storeGoodForKids.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeGoodForKids.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasOutdoorSeating)
          {
            handler.start_pair("OutdoorSeating");
            switch (storeOutdoorSeating.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeOutdoorSeating.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasWifiFree)
          {
            handler.start_pair("WifiFree");
            switch (storeWifiFree.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeWifiFree.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasWifiPaid)
          {
            handler.start_pair("WifiPaid");
            switch (storeWifiPaid.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeWifiPaid.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasParkingLot)
          {
            handler.start_pair("ParkingLot");
            switch (storeParkingLot.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeParkingLot.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasParkingStreet)
          {
            handler.start_pair("ParkingStreet");
            switch (storeParkingStreet.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeParkingStreet.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasParkingGarage)
          {
            handler.start_pair("ParkingGarage");
            switch (storeParkingGarage.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeParkingGarage.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasParkingValet)
          {
            handler.start_pair("ParkingValet");
            switch (storeParkingValet.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeParkingValet.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasParkingValidated)
          {
            handler.start_pair("ParkingValidated");
            switch (storeParkingValidated.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeParkingValidated.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasSmoking)
          {
            handler.start_pair("Smoking");
            switch (storeSmoking.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    handler.boolean_value(storeSmoking.u.choice1);
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
        return null;
      }

    public static YelpUserPreferencesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        YelpUserPreferencesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpUserPreferences", ignore_extras);
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
    public static YelpUserPreferencesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static YelpUserPreferencesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        YelpUserPreferencesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpUserPreferences", ignore_extras);
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
    public static YelpUserPreferencesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static YelpUserPreferencesJSON from_text(string text, bool ignore_extras)
      {
        YelpUserPreferencesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpUserPreferences", ignore_extras);
            JSONParse.parse_json_value(text, "Text for YelpUserPreferencesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static YelpUserPreferencesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        YelpUserPreferencesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpUserPreferences", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorStarRatingMin : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingNumberTextGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeStarRatingMin result = new TypeStarRatingMin();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = Double.Parse(field1.value);
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeStarRatingMin result);
            public FieldGeneratorStarRatingMin(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"StarRatingMin\"");
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"StarRatingMin\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorStarRatingMin(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"StarRatingMin\"");
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"StarRatingMin\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderStarRatingMin
          {
            private bool have_data;
            private TypeStarRatingMin data;
            public HolderStarRatingMin()  { have_data = false; }
            public HolderStarRatingMin(TypeStarRatingMin init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderStarRatingMin(HolderStarRatingMin other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeStarRatingMin referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorStarRatingMin : FieldGeneratorStarRatingMin
          {
            protected override void handle_result(TypeStarRatingMin result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderStarRatingMin(result);
              }

            public FieldHoldingGeneratorStarRatingMin(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderStarRatingMin value;
          };
    private class FieldHoldingArrayGeneratorStarRatingMin : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStarRatingMin
      {
        private FieldHoldingArrayGeneratorStarRatingMin top;

        protected override void handle_result(TypeStarRatingMin result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStarRatingMin init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeStarRatingMin> result)
      {
      }

    public FieldHoldingArrayGeneratorStarRatingMin(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeStarRatingMin>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStarRatingMin(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeStarRatingMin>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStarRatingMin> value;
  };
        private FieldHoldingGeneratorStarRatingMin fieldGeneratorStarRatingMin;
    private abstract class FieldGeneratorStarRatingMax : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingNumberTextGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeStarRatingMax result = new TypeStarRatingMax();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = Double.Parse(field1.value);
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeStarRatingMax result);
            public FieldGeneratorStarRatingMax(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"StarRatingMax\"");
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"StarRatingMax\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorStarRatingMax(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"StarRatingMax\"");
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"StarRatingMax\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderStarRatingMax
          {
            private bool have_data;
            private TypeStarRatingMax data;
            public HolderStarRatingMax()  { have_data = false; }
            public HolderStarRatingMax(TypeStarRatingMax init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderStarRatingMax(HolderStarRatingMax other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeStarRatingMax referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorStarRatingMax : FieldGeneratorStarRatingMax
          {
            protected override void handle_result(TypeStarRatingMax result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderStarRatingMax(result);
              }

            public FieldHoldingGeneratorStarRatingMax(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderStarRatingMax value;
          };
    private class FieldHoldingArrayGeneratorStarRatingMax : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStarRatingMax
      {
        private FieldHoldingArrayGeneratorStarRatingMax top;

        protected override void handle_result(TypeStarRatingMax result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStarRatingMax init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeStarRatingMax> result)
      {
      }

    public FieldHoldingArrayGeneratorStarRatingMax(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeStarRatingMax>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStarRatingMax(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeStarRatingMax>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStarRatingMax> value;
  };
        private FieldHoldingGeneratorStarRatingMax fieldGeneratorStarRatingMax;
    private class FieldHoldingGeneratorReviewCountMin_1 : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorReviewCountMin_1(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorReviewCountMin_1 : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorReviewCountMin_1(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private abstract class FieldGeneratorReviewCountMin : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private FieldHoldingGeneratorReviewCountMin_1 field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeReviewCountMin result = new TypeReviewCountMin();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeReviewCountMin result);
            public FieldGeneratorReviewCountMin(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ReviewCountMin\"");
                    field1 = new FieldHoldingGeneratorReviewCountMin_1("option 1 of field \"ReviewCountMin\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorReviewCountMin(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ReviewCountMin\"");
                    field1 = new FieldHoldingGeneratorReviewCountMin_1("option 1 of field \"ReviewCountMin\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderReviewCountMin
          {
            private bool have_data;
            private TypeReviewCountMin data;
            public HolderReviewCountMin()  { have_data = false; }
            public HolderReviewCountMin(TypeReviewCountMin init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderReviewCountMin(HolderReviewCountMin other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeReviewCountMin referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorReviewCountMin : FieldGeneratorReviewCountMin
          {
            protected override void handle_result(TypeReviewCountMin result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderReviewCountMin(result);
              }

            public FieldHoldingGeneratorReviewCountMin(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderReviewCountMin value;
          };
    private class FieldHoldingArrayGeneratorReviewCountMin : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorReviewCountMin
      {
        private FieldHoldingArrayGeneratorReviewCountMin top;

        protected override void handle_result(TypeReviewCountMin result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorReviewCountMin init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeReviewCountMin> result)
      {
      }

    public FieldHoldingArrayGeneratorReviewCountMin(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeReviewCountMin>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorReviewCountMin(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeReviewCountMin>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeReviewCountMin> value;
  };
        private FieldHoldingGeneratorReviewCountMin fieldGeneratorReviewCountMin;
    private class FieldHoldingGeneratorReviewCountMax_1 : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorReviewCountMax_1(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorReviewCountMax_1 : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorReviewCountMax_1(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private abstract class FieldGeneratorReviewCountMax : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private FieldHoldingGeneratorReviewCountMax_1 field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeReviewCountMax result = new TypeReviewCountMax();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeReviewCountMax result);
            public FieldGeneratorReviewCountMax(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ReviewCountMax\"");
                    field1 = new FieldHoldingGeneratorReviewCountMax_1("option 1 of field \"ReviewCountMax\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorReviewCountMax(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ReviewCountMax\"");
                    field1 = new FieldHoldingGeneratorReviewCountMax_1("option 1 of field \"ReviewCountMax\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderReviewCountMax
          {
            private bool have_data;
            private TypeReviewCountMax data;
            public HolderReviewCountMax()  { have_data = false; }
            public HolderReviewCountMax(TypeReviewCountMax init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderReviewCountMax(HolderReviewCountMax other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeReviewCountMax referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorReviewCountMax : FieldGeneratorReviewCountMax
          {
            protected override void handle_result(TypeReviewCountMax result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderReviewCountMax(result);
              }

            public FieldHoldingGeneratorReviewCountMax(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderReviewCountMax value;
          };
    private class FieldHoldingArrayGeneratorReviewCountMax : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorReviewCountMax
      {
        private FieldHoldingArrayGeneratorReviewCountMax top;

        protected override void handle_result(TypeReviewCountMax result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorReviewCountMax init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeReviewCountMax> result)
      {
      }

    public FieldHoldingArrayGeneratorReviewCountMax(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeReviewCountMax>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorReviewCountMax(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeReviewCountMax>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeReviewCountMax> value;
  };
        private FieldHoldingGeneratorReviewCountMax fieldGeneratorReviewCountMax;
    private abstract class FieldGeneratorDollarSignMin : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingNumberTextGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeDollarSignMin result = new TypeDollarSignMin();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = Double.Parse(field1.value);
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeDollarSignMin result);
            public FieldGeneratorDollarSignMin(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"DollarSignMin\"");
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"DollarSignMin\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorDollarSignMin(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"DollarSignMin\"");
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"DollarSignMin\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderDollarSignMin
          {
            private bool have_data;
            private TypeDollarSignMin data;
            public HolderDollarSignMin()  { have_data = false; }
            public HolderDollarSignMin(TypeDollarSignMin init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderDollarSignMin(HolderDollarSignMin other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeDollarSignMin referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorDollarSignMin : FieldGeneratorDollarSignMin
          {
            protected override void handle_result(TypeDollarSignMin result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderDollarSignMin(result);
              }

            public FieldHoldingGeneratorDollarSignMin(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderDollarSignMin value;
          };
    private class FieldHoldingArrayGeneratorDollarSignMin : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDollarSignMin
      {
        private FieldHoldingArrayGeneratorDollarSignMin top;

        protected override void handle_result(TypeDollarSignMin result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDollarSignMin init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeDollarSignMin> result)
      {
      }

    public FieldHoldingArrayGeneratorDollarSignMin(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDollarSignMin>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDollarSignMin(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDollarSignMin>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDollarSignMin> value;
  };
        private FieldHoldingGeneratorDollarSignMin fieldGeneratorDollarSignMin;
    private abstract class FieldGeneratorDollarSignMax : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingNumberTextGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeDollarSignMax result = new TypeDollarSignMax();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = Double.Parse(field1.value);
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeDollarSignMax result);
            public FieldGeneratorDollarSignMax(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"DollarSignMax\"");
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"DollarSignMax\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorDollarSignMax(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"DollarSignMax\"");
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"DollarSignMax\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderDollarSignMax
          {
            private bool have_data;
            private TypeDollarSignMax data;
            public HolderDollarSignMax()  { have_data = false; }
            public HolderDollarSignMax(TypeDollarSignMax init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderDollarSignMax(HolderDollarSignMax other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeDollarSignMax referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorDollarSignMax : FieldGeneratorDollarSignMax
          {
            protected override void handle_result(TypeDollarSignMax result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderDollarSignMax(result);
              }

            public FieldHoldingGeneratorDollarSignMax(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderDollarSignMax value;
          };
    private class FieldHoldingArrayGeneratorDollarSignMax : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDollarSignMax
      {
        private FieldHoldingArrayGeneratorDollarSignMax top;

        protected override void handle_result(TypeDollarSignMax result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDollarSignMax init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeDollarSignMax> result)
      {
      }

    public FieldHoldingArrayGeneratorDollarSignMax(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDollarSignMax>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDollarSignMax(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDollarSignMax>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDollarSignMax> value;
  };
        private FieldHoldingGeneratorDollarSignMax fieldGeneratorDollarSignMax;
    private abstract class FieldGeneratorDelivers : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeDelivers result = new TypeDelivers();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeDelivers result);
            public FieldGeneratorDelivers(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"Delivers\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"Delivers\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorDelivers(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"Delivers\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"Delivers\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderDelivers
          {
            private bool have_data;
            private TypeDelivers data;
            public HolderDelivers()  { have_data = false; }
            public HolderDelivers(TypeDelivers init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderDelivers(HolderDelivers other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeDelivers referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorDelivers : FieldGeneratorDelivers
          {
            protected override void handle_result(TypeDelivers result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderDelivers(result);
              }

            public FieldHoldingGeneratorDelivers(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderDelivers value;
          };
    private class FieldHoldingArrayGeneratorDelivers : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDelivers
      {
        private FieldHoldingArrayGeneratorDelivers top;

        protected override void handle_result(TypeDelivers result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDelivers init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeDelivers> result)
      {
      }

    public FieldHoldingArrayGeneratorDelivers(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDelivers>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDelivers(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDelivers>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDelivers> value;
  };
        private FieldHoldingGeneratorDelivers fieldGeneratorDelivers;
    private abstract class FieldGeneratorReservations : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeReservations result = new TypeReservations();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeReservations result);
            public FieldGeneratorReservations(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"Reservations\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"Reservations\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorReservations(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"Reservations\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"Reservations\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderReservations
          {
            private bool have_data;
            private TypeReservations data;
            public HolderReservations()  { have_data = false; }
            public HolderReservations(TypeReservations init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderReservations(HolderReservations other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeReservations referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorReservations : FieldGeneratorReservations
          {
            protected override void handle_result(TypeReservations result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderReservations(result);
              }

            public FieldHoldingGeneratorReservations(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderReservations value;
          };
    private class FieldHoldingArrayGeneratorReservations : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorReservations
      {
        private FieldHoldingArrayGeneratorReservations top;

        protected override void handle_result(TypeReservations result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorReservations init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeReservations> result)
      {
      }

    public FieldHoldingArrayGeneratorReservations(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeReservations>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorReservations(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeReservations>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeReservations> value;
  };
        private FieldHoldingGeneratorReservations fieldGeneratorReservations;
    private abstract class FieldGeneratorGoodForKids : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeGoodForKids result = new TypeGoodForKids();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeGoodForKids result);
            public FieldGeneratorGoodForKids(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"GoodForKids\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"GoodForKids\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorGoodForKids(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"GoodForKids\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"GoodForKids\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderGoodForKids
          {
            private bool have_data;
            private TypeGoodForKids data;
            public HolderGoodForKids()  { have_data = false; }
            public HolderGoodForKids(TypeGoodForKids init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderGoodForKids(HolderGoodForKids other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeGoodForKids referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorGoodForKids : FieldGeneratorGoodForKids
          {
            protected override void handle_result(TypeGoodForKids result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderGoodForKids(result);
              }

            public FieldHoldingGeneratorGoodForKids(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderGoodForKids value;
          };
    private class FieldHoldingArrayGeneratorGoodForKids : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorGoodForKids
      {
        private FieldHoldingArrayGeneratorGoodForKids top;

        protected override void handle_result(TypeGoodForKids result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorGoodForKids init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeGoodForKids> result)
      {
      }

    public FieldHoldingArrayGeneratorGoodForKids(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeGoodForKids>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorGoodForKids(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeGoodForKids>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeGoodForKids> value;
  };
        private FieldHoldingGeneratorGoodForKids fieldGeneratorGoodForKids;
    private abstract class FieldGeneratorOutdoorSeating : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeOutdoorSeating result = new TypeOutdoorSeating();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeOutdoorSeating result);
            public FieldGeneratorOutdoorSeating(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"OutdoorSeating\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"OutdoorSeating\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorOutdoorSeating(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"OutdoorSeating\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"OutdoorSeating\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderOutdoorSeating
          {
            private bool have_data;
            private TypeOutdoorSeating data;
            public HolderOutdoorSeating()  { have_data = false; }
            public HolderOutdoorSeating(TypeOutdoorSeating init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderOutdoorSeating(HolderOutdoorSeating other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeOutdoorSeating referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorOutdoorSeating : FieldGeneratorOutdoorSeating
          {
            protected override void handle_result(TypeOutdoorSeating result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderOutdoorSeating(result);
              }

            public FieldHoldingGeneratorOutdoorSeating(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderOutdoorSeating value;
          };
    private class FieldHoldingArrayGeneratorOutdoorSeating : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorOutdoorSeating
      {
        private FieldHoldingArrayGeneratorOutdoorSeating top;

        protected override void handle_result(TypeOutdoorSeating result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorOutdoorSeating init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeOutdoorSeating> result)
      {
      }

    public FieldHoldingArrayGeneratorOutdoorSeating(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeOutdoorSeating>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorOutdoorSeating(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeOutdoorSeating>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeOutdoorSeating> value;
  };
        private FieldHoldingGeneratorOutdoorSeating fieldGeneratorOutdoorSeating;
    private abstract class FieldGeneratorWifiFree : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeWifiFree result = new TypeWifiFree();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeWifiFree result);
            public FieldGeneratorWifiFree(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"WifiFree\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"WifiFree\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorWifiFree(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"WifiFree\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"WifiFree\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderWifiFree
          {
            private bool have_data;
            private TypeWifiFree data;
            public HolderWifiFree()  { have_data = false; }
            public HolderWifiFree(TypeWifiFree init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderWifiFree(HolderWifiFree other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeWifiFree referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorWifiFree : FieldGeneratorWifiFree
          {
            protected override void handle_result(TypeWifiFree result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderWifiFree(result);
              }

            public FieldHoldingGeneratorWifiFree(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderWifiFree value;
          };
    private class FieldHoldingArrayGeneratorWifiFree : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorWifiFree
      {
        private FieldHoldingArrayGeneratorWifiFree top;

        protected override void handle_result(TypeWifiFree result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorWifiFree init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeWifiFree> result)
      {
      }

    public FieldHoldingArrayGeneratorWifiFree(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeWifiFree>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorWifiFree(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeWifiFree>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeWifiFree> value;
  };
        private FieldHoldingGeneratorWifiFree fieldGeneratorWifiFree;
    private abstract class FieldGeneratorWifiPaid : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeWifiPaid result = new TypeWifiPaid();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeWifiPaid result);
            public FieldGeneratorWifiPaid(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"WifiPaid\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"WifiPaid\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorWifiPaid(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"WifiPaid\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"WifiPaid\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderWifiPaid
          {
            private bool have_data;
            private TypeWifiPaid data;
            public HolderWifiPaid()  { have_data = false; }
            public HolderWifiPaid(TypeWifiPaid init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderWifiPaid(HolderWifiPaid other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeWifiPaid referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorWifiPaid : FieldGeneratorWifiPaid
          {
            protected override void handle_result(TypeWifiPaid result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderWifiPaid(result);
              }

            public FieldHoldingGeneratorWifiPaid(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderWifiPaid value;
          };
    private class FieldHoldingArrayGeneratorWifiPaid : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorWifiPaid
      {
        private FieldHoldingArrayGeneratorWifiPaid top;

        protected override void handle_result(TypeWifiPaid result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorWifiPaid init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeWifiPaid> result)
      {
      }

    public FieldHoldingArrayGeneratorWifiPaid(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeWifiPaid>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorWifiPaid(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeWifiPaid>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeWifiPaid> value;
  };
        private FieldHoldingGeneratorWifiPaid fieldGeneratorWifiPaid;
    private abstract class FieldGeneratorParkingLot : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeParkingLot result = new TypeParkingLot();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeParkingLot result);
            public FieldGeneratorParkingLot(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ParkingLot\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"ParkingLot\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorParkingLot(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ParkingLot\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"ParkingLot\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderParkingLot
          {
            private bool have_data;
            private TypeParkingLot data;
            public HolderParkingLot()  { have_data = false; }
            public HolderParkingLot(TypeParkingLot init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderParkingLot(HolderParkingLot other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeParkingLot referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorParkingLot : FieldGeneratorParkingLot
          {
            protected override void handle_result(TypeParkingLot result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderParkingLot(result);
              }

            public FieldHoldingGeneratorParkingLot(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderParkingLot value;
          };
    private class FieldHoldingArrayGeneratorParkingLot : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorParkingLot
      {
        private FieldHoldingArrayGeneratorParkingLot top;

        protected override void handle_result(TypeParkingLot result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorParkingLot init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeParkingLot> result)
      {
      }

    public FieldHoldingArrayGeneratorParkingLot(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeParkingLot>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorParkingLot(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeParkingLot>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeParkingLot> value;
  };
        private FieldHoldingGeneratorParkingLot fieldGeneratorParkingLot;
    private abstract class FieldGeneratorParkingStreet : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeParkingStreet result = new TypeParkingStreet();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeParkingStreet result);
            public FieldGeneratorParkingStreet(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ParkingStreet\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"ParkingStreet\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorParkingStreet(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ParkingStreet\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"ParkingStreet\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderParkingStreet
          {
            private bool have_data;
            private TypeParkingStreet data;
            public HolderParkingStreet()  { have_data = false; }
            public HolderParkingStreet(TypeParkingStreet init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderParkingStreet(HolderParkingStreet other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeParkingStreet referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorParkingStreet : FieldGeneratorParkingStreet
          {
            protected override void handle_result(TypeParkingStreet result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderParkingStreet(result);
              }

            public FieldHoldingGeneratorParkingStreet(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderParkingStreet value;
          };
    private class FieldHoldingArrayGeneratorParkingStreet : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorParkingStreet
      {
        private FieldHoldingArrayGeneratorParkingStreet top;

        protected override void handle_result(TypeParkingStreet result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorParkingStreet init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeParkingStreet> result)
      {
      }

    public FieldHoldingArrayGeneratorParkingStreet(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeParkingStreet>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorParkingStreet(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeParkingStreet>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeParkingStreet> value;
  };
        private FieldHoldingGeneratorParkingStreet fieldGeneratorParkingStreet;
    private abstract class FieldGeneratorParkingGarage : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeParkingGarage result = new TypeParkingGarage();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeParkingGarage result);
            public FieldGeneratorParkingGarage(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ParkingGarage\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"ParkingGarage\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorParkingGarage(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ParkingGarage\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"ParkingGarage\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderParkingGarage
          {
            private bool have_data;
            private TypeParkingGarage data;
            public HolderParkingGarage()  { have_data = false; }
            public HolderParkingGarage(TypeParkingGarage init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderParkingGarage(HolderParkingGarage other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeParkingGarage referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorParkingGarage : FieldGeneratorParkingGarage
          {
            protected override void handle_result(TypeParkingGarage result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderParkingGarage(result);
              }

            public FieldHoldingGeneratorParkingGarage(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderParkingGarage value;
          };
    private class FieldHoldingArrayGeneratorParkingGarage : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorParkingGarage
      {
        private FieldHoldingArrayGeneratorParkingGarage top;

        protected override void handle_result(TypeParkingGarage result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorParkingGarage init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeParkingGarage> result)
      {
      }

    public FieldHoldingArrayGeneratorParkingGarage(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeParkingGarage>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorParkingGarage(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeParkingGarage>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeParkingGarage> value;
  };
        private FieldHoldingGeneratorParkingGarage fieldGeneratorParkingGarage;
    private abstract class FieldGeneratorParkingValet : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeParkingValet result = new TypeParkingValet();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeParkingValet result);
            public FieldGeneratorParkingValet(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ParkingValet\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"ParkingValet\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorParkingValet(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ParkingValet\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"ParkingValet\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderParkingValet
          {
            private bool have_data;
            private TypeParkingValet data;
            public HolderParkingValet()  { have_data = false; }
            public HolderParkingValet(TypeParkingValet init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderParkingValet(HolderParkingValet other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeParkingValet referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorParkingValet : FieldGeneratorParkingValet
          {
            protected override void handle_result(TypeParkingValet result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderParkingValet(result);
              }

            public FieldHoldingGeneratorParkingValet(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderParkingValet value;
          };
    private class FieldHoldingArrayGeneratorParkingValet : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorParkingValet
      {
        private FieldHoldingArrayGeneratorParkingValet top;

        protected override void handle_result(TypeParkingValet result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorParkingValet init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeParkingValet> result)
      {
      }

    public FieldHoldingArrayGeneratorParkingValet(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeParkingValet>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorParkingValet(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeParkingValet>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeParkingValet> value;
  };
        private FieldHoldingGeneratorParkingValet fieldGeneratorParkingValet;
    private abstract class FieldGeneratorParkingValidated : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeParkingValidated result = new TypeParkingValidated();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeParkingValidated result);
            public FieldGeneratorParkingValidated(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ParkingValidated\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"ParkingValidated\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorParkingValidated(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"ParkingValidated\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"ParkingValidated\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderParkingValidated
          {
            private bool have_data;
            private TypeParkingValidated data;
            public HolderParkingValidated()  { have_data = false; }
            public HolderParkingValidated(TypeParkingValidated init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderParkingValidated(HolderParkingValidated other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeParkingValidated referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorParkingValidated : FieldGeneratorParkingValidated
          {
            protected override void handle_result(TypeParkingValidated result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderParkingValidated(result);
              }

            public FieldHoldingGeneratorParkingValidated(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderParkingValidated value;
          };
    private class FieldHoldingArrayGeneratorParkingValidated : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorParkingValidated
      {
        private FieldHoldingArrayGeneratorParkingValidated top;

        protected override void handle_result(TypeParkingValidated result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorParkingValidated init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeParkingValidated> result)
      {
      }

    public FieldHoldingArrayGeneratorParkingValidated(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeParkingValidated>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorParkingValidated(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeParkingValidated>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeParkingValidated> value;
  };
        private FieldHoldingGeneratorParkingValidated fieldGeneratorParkingValidated;
    private abstract class FieldGeneratorSmoking : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private JSONHoldingBooleanGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeSmoking result = new TypeSmoking();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeSmoking result);
            public FieldGeneratorSmoking(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"Smoking\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"Smoking\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorSmoking(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"Smoking\"");
                    field1 = new JSONHoldingBooleanGenerator("option 1 of field \"Smoking\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderSmoking
          {
            private bool have_data;
            private TypeSmoking data;
            public HolderSmoking()  { have_data = false; }
            public HolderSmoking(TypeSmoking init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderSmoking(HolderSmoking other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeSmoking referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorSmoking : FieldGeneratorSmoking
          {
            protected override void handle_result(TypeSmoking result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderSmoking(result);
              }

            public FieldHoldingGeneratorSmoking(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderSmoking value;
          };
    private class FieldHoldingArrayGeneratorSmoking : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSmoking
      {
        private FieldHoldingArrayGeneratorSmoking top;

        protected override void handle_result(TypeSmoking result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSmoking init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeSmoking> result)
      {
      }

    public FieldHoldingArrayGeneratorSmoking(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeSmoking>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSmoking(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeSmoking>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSmoking> value;
  };
        private FieldHoldingGeneratorSmoking fieldGeneratorSmoking;
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
            YelpUserPreferencesJSON result = new YelpUserPreferencesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraYelpUserPreferencesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(YelpUserPreferencesJSON result)
          {
            if (fieldGeneratorStarRatingMin.have_value)
              {
                result.setStarRatingMin(fieldGeneratorStarRatingMin.value.referenced());
                fieldGeneratorStarRatingMin.have_value = false;
              }
            if (fieldGeneratorStarRatingMax.have_value)
              {
                result.setStarRatingMax(fieldGeneratorStarRatingMax.value.referenced());
                fieldGeneratorStarRatingMax.have_value = false;
              }
            if (fieldGeneratorReviewCountMin.have_value)
              {
                result.setReviewCountMin(fieldGeneratorReviewCountMin.value.referenced());
                fieldGeneratorReviewCountMin.have_value = false;
              }
            if (fieldGeneratorReviewCountMax.have_value)
              {
                result.setReviewCountMax(fieldGeneratorReviewCountMax.value.referenced());
                fieldGeneratorReviewCountMax.have_value = false;
              }
            if (fieldGeneratorDollarSignMin.have_value)
              {
                result.setDollarSignMin(fieldGeneratorDollarSignMin.value.referenced());
                fieldGeneratorDollarSignMin.have_value = false;
              }
            if (fieldGeneratorDollarSignMax.have_value)
              {
                result.setDollarSignMax(fieldGeneratorDollarSignMax.value.referenced());
                fieldGeneratorDollarSignMax.have_value = false;
              }
            if (fieldGeneratorDelivers.have_value)
              {
                result.setDelivers(fieldGeneratorDelivers.value.referenced());
                fieldGeneratorDelivers.have_value = false;
              }
            if (fieldGeneratorReservations.have_value)
              {
                result.setReservations(fieldGeneratorReservations.value.referenced());
                fieldGeneratorReservations.have_value = false;
              }
            if (fieldGeneratorGoodForKids.have_value)
              {
                result.setGoodForKids(fieldGeneratorGoodForKids.value.referenced());
                fieldGeneratorGoodForKids.have_value = false;
              }
            if (fieldGeneratorOutdoorSeating.have_value)
              {
                result.setOutdoorSeating(fieldGeneratorOutdoorSeating.value.referenced());
                fieldGeneratorOutdoorSeating.have_value = false;
              }
            if (fieldGeneratorWifiFree.have_value)
              {
                result.setWifiFree(fieldGeneratorWifiFree.value.referenced());
                fieldGeneratorWifiFree.have_value = false;
              }
            if (fieldGeneratorWifiPaid.have_value)
              {
                result.setWifiPaid(fieldGeneratorWifiPaid.value.referenced());
                fieldGeneratorWifiPaid.have_value = false;
              }
            if (fieldGeneratorParkingLot.have_value)
              {
                result.setParkingLot(fieldGeneratorParkingLot.value.referenced());
                fieldGeneratorParkingLot.have_value = false;
              }
            if (fieldGeneratorParkingStreet.have_value)
              {
                result.setParkingStreet(fieldGeneratorParkingStreet.value.referenced());
                fieldGeneratorParkingStreet.have_value = false;
              }
            if (fieldGeneratorParkingGarage.have_value)
              {
                result.setParkingGarage(fieldGeneratorParkingGarage.value.referenced());
                fieldGeneratorParkingGarage.have_value = false;
              }
            if (fieldGeneratorParkingValet.have_value)
              {
                result.setParkingValet(fieldGeneratorParkingValet.value.referenced());
                fieldGeneratorParkingValet.have_value = false;
              }
            if (fieldGeneratorParkingValidated.have_value)
              {
                result.setParkingValidated(fieldGeneratorParkingValidated.value.referenced());
                fieldGeneratorParkingValidated.have_value = false;
              }
            if (fieldGeneratorSmoking.have_value)
              {
                result.setSmoking(fieldGeneratorSmoking.value.referenced());
                fieldGeneratorSmoking.have_value = false;
              }
          }
        protected abstract void handle_result(YelpUserPreferencesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "livers", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorDelivers;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "llarSignM", 0, 9, false) == 0)
                              {
                                switch (field_name[11])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 12, "x", 0, 1, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorDollarSignMax;
                                        break;
                                    case 'i':
                                        if ((String.Compare(field_name, 12, "n", 0, 1, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorDollarSignMin;
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
                case 'G':
                    if ((String.Compare(field_name, 1, "oodForKids", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorGoodForKids;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utdoorSeating", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorOutdoorSeating;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "arking", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'G':
                                if ((String.Compare(field_name, 8, "arage", 0, 5, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorParkingGarage;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 8, "ot", 0, 2, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorParkingLot;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 8, "treet", 0, 5, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorParkingStreet;
                                break;
                            case 'V':
                                if (String.Compare(field_name, 8, "al", 0, 2, false) == 0)
                                  {
                                    switch (field_name[10])
                                      {
                                        case 'e':
                                            if ((String.Compare(field_name, 11, "t", 0, 1, false) == 0) && (field_name.Length == 12))
                                                return fieldGeneratorParkingValet;
                                            break;
                                        case 'i':
                                            if ((String.Compare(field_name, 11, "dated", 0, 5, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorParkingValidated;
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
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 's':
                                if ((String.Compare(field_name, 3, "ervations", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorReservations;
                                break;
                            case 'v':
                                if (String.Compare(field_name, 3, "iewCountM", 0, 9, false) == 0)
                                  {
                                    switch (field_name[12])
                                      {
                                        case 'a':
                                            if ((String.Compare(field_name, 13, "x", 0, 1, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorReviewCountMax;
                                            break;
                                        case 'i':
                                            if ((String.Compare(field_name, 13, "n", 0, 1, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorReviewCountMin;
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
                case 'S':
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "oking", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorSmoking;
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "arRatingM", 0, 9, false) == 0)
                              {
                                switch (field_name[11])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 12, "x", 0, 1, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorStarRatingMax;
                                        break;
                                    case 'i':
                                        if ((String.Compare(field_name, 12, "n", 0, 1, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorStarRatingMin;
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
                case 'W':
                    if (String.Compare(field_name, 1, "ifi", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 5, "ree", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorWifiFree;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 5, "aid", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorWifiPaid;
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
            fieldGeneratorStarRatingMin = new FieldHoldingGeneratorStarRatingMin("field \"StarRatingMin\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorStarRatingMax = new FieldHoldingGeneratorStarRatingMax("field \"StarRatingMax\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorReviewCountMin = new FieldHoldingGeneratorReviewCountMin("field \"ReviewCountMin\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorReviewCountMax = new FieldHoldingGeneratorReviewCountMax("field \"ReviewCountMax\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorDollarSignMin = new FieldHoldingGeneratorDollarSignMin("field \"DollarSignMin\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorDollarSignMax = new FieldHoldingGeneratorDollarSignMax("field \"DollarSignMax\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorDelivers = new FieldHoldingGeneratorDelivers("field \"Delivers\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorReservations = new FieldHoldingGeneratorReservations("field \"Reservations\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorGoodForKids = new FieldHoldingGeneratorGoodForKids("field \"GoodForKids\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorOutdoorSeating = new FieldHoldingGeneratorOutdoorSeating("field \"OutdoorSeating\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorWifiFree = new FieldHoldingGeneratorWifiFree("field \"WifiFree\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorWifiPaid = new FieldHoldingGeneratorWifiPaid("field \"WifiPaid\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorParkingLot = new FieldHoldingGeneratorParkingLot("field \"ParkingLot\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorParkingStreet = new FieldHoldingGeneratorParkingStreet("field \"ParkingStreet\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorParkingGarage = new FieldHoldingGeneratorParkingGarage("field \"ParkingGarage\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorParkingValet = new FieldHoldingGeneratorParkingValet("field \"ParkingValet\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorParkingValidated = new FieldHoldingGeneratorParkingValidated("field \"ParkingValidated\" of the YelpUserPreferences class", ignore_extras);
            fieldGeneratorSmoking = new FieldHoldingGeneratorSmoking("field \"Smoking\" of the YelpUserPreferences class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the YelpUserPreferences class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStarRatingMin = new FieldHoldingGeneratorStarRatingMin("field \"StarRatingMin\" of the YelpUserPreferences class", false);
            fieldGeneratorStarRatingMax = new FieldHoldingGeneratorStarRatingMax("field \"StarRatingMax\" of the YelpUserPreferences class", false);
            fieldGeneratorReviewCountMin = new FieldHoldingGeneratorReviewCountMin("field \"ReviewCountMin\" of the YelpUserPreferences class", false);
            fieldGeneratorReviewCountMax = new FieldHoldingGeneratorReviewCountMax("field \"ReviewCountMax\" of the YelpUserPreferences class", false);
            fieldGeneratorDollarSignMin = new FieldHoldingGeneratorDollarSignMin("field \"DollarSignMin\" of the YelpUserPreferences class", false);
            fieldGeneratorDollarSignMax = new FieldHoldingGeneratorDollarSignMax("field \"DollarSignMax\" of the YelpUserPreferences class", false);
            fieldGeneratorDelivers = new FieldHoldingGeneratorDelivers("field \"Delivers\" of the YelpUserPreferences class", false);
            fieldGeneratorReservations = new FieldHoldingGeneratorReservations("field \"Reservations\" of the YelpUserPreferences class", false);
            fieldGeneratorGoodForKids = new FieldHoldingGeneratorGoodForKids("field \"GoodForKids\" of the YelpUserPreferences class", false);
            fieldGeneratorOutdoorSeating = new FieldHoldingGeneratorOutdoorSeating("field \"OutdoorSeating\" of the YelpUserPreferences class", false);
            fieldGeneratorWifiFree = new FieldHoldingGeneratorWifiFree("field \"WifiFree\" of the YelpUserPreferences class", false);
            fieldGeneratorWifiPaid = new FieldHoldingGeneratorWifiPaid("field \"WifiPaid\" of the YelpUserPreferences class", false);
            fieldGeneratorParkingLot = new FieldHoldingGeneratorParkingLot("field \"ParkingLot\" of the YelpUserPreferences class", false);
            fieldGeneratorParkingStreet = new FieldHoldingGeneratorParkingStreet("field \"ParkingStreet\" of the YelpUserPreferences class", false);
            fieldGeneratorParkingGarage = new FieldHoldingGeneratorParkingGarage("field \"ParkingGarage\" of the YelpUserPreferences class", false);
            fieldGeneratorParkingValet = new FieldHoldingGeneratorParkingValet("field \"ParkingValet\" of the YelpUserPreferences class", false);
            fieldGeneratorParkingValidated = new FieldHoldingGeneratorParkingValidated("field \"ParkingValidated\" of the YelpUserPreferences class", false);
            fieldGeneratorSmoking = new FieldHoldingGeneratorSmoking("field \"Smoking\" of the YelpUserPreferences class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the YelpUserPreferences class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStarRatingMin.reset();
            fieldGeneratorStarRatingMax.reset();
            fieldGeneratorReviewCountMin.reset();
            fieldGeneratorReviewCountMax.reset();
            fieldGeneratorDollarSignMin.reset();
            fieldGeneratorDollarSignMax.reset();
            fieldGeneratorDelivers.reset();
            fieldGeneratorReservations.reset();
            fieldGeneratorGoodForKids.reset();
            fieldGeneratorOutdoorSeating.reset();
            fieldGeneratorWifiFree.reset();
            fieldGeneratorWifiPaid.reset();
            fieldGeneratorParkingLot.reset();
            fieldGeneratorParkingStreet.reset();
            fieldGeneratorParkingGarage.reset();
            fieldGeneratorParkingValet.reset();
            fieldGeneratorParkingValidated.reset();
            fieldGeneratorSmoking.reset();
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
        protected override void handle_result(YelpUserPreferencesJSON  result)
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
        public YelpUserPreferencesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(YelpUserPreferencesJSON  result)
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
    protected virtual void handle_result(List<YelpUserPreferencesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<YelpUserPreferencesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<YelpUserPreferencesJSON>();
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
    public List<YelpUserPreferencesJSON> value;
  };
  };
