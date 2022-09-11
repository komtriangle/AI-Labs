/* file "HotelFilterSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HotelFilterSpecJSON : JSONBase
  {
    public enum TypeQueryType
      {
        QueryType_Search,
        QueryType_Reservation,
        QueryType_HotelQuestion
      };

    public static TypeQueryType  stringToQueryType(string chars)
      {
        switch (chars[0])
          {
            case 'H':
                if ((String.Compare(chars, 1, "otelQuestion", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeQueryType.QueryType_HotelQuestion;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "eservation", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeQueryType.QueryType_Reservation;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "earch", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeQueryType.QueryType_Search;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `QueryType' is not one of the legal values.");
      }

    public static string  stringFromQueryType(TypeQueryType the_enum)
      {
        switch (the_enum)
          {
            case TypeQueryType.QueryType_Search:
                return "Search";
            case TypeQueryType.QueryType_Reservation:
                return "Reservation";
            case TypeQueryType.QueryType_HotelQuestion:
                return "HotelQuestion";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeRadiusUnit
      {
        RadiusUnit_Kilometers,
        RadiusUnit_Miles
      };

    public static TypeRadiusUnit  stringToRadiusUnit(string chars)
      {
        switch (chars[0])
          {
            case 'K':
                if ((String.Compare(chars, 1, "ilometers", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeRadiusUnit.RadiusUnit_Kilometers;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "iles", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeRadiusUnit.RadiusUnit_Miles;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `RadiusUnit' is not one of the legal values.");
      }

    public static string  stringFromRadiusUnit(TypeRadiusUnit the_enum)
      {
        switch (the_enum)
          {
            case TypeRadiusUnit.RadiusUnit_Kilometers:
                return "Kilometers";
            case TypeRadiusUnit.RadiusUnit_Miles:
                return "Miles";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeSortCriteria
      {
        SortCriteria_Distance,
        SortCriteria_Price,
        SortCriteria_StarRating,
        SortCriteria_GuestRating
      };

    public static TypeSortCriteria  stringToSortCriteria(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if ((String.Compare(chars, 1, "istance", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSortCriteria.SortCriteria_Distance;
                break;
            case 'G':
                if ((String.Compare(chars, 1, "uestRating", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeSortCriteria.SortCriteria_GuestRating;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "rice", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeSortCriteria.SortCriteria_Price;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "tarRating", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeSortCriteria.SortCriteria_StarRating;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `SortCriteria' is not one of the legal values.");
      }

    public static string  stringFromSortCriteria(TypeSortCriteria the_enum)
      {
        switch (the_enum)
          {
            case TypeSortCriteria.SortCriteria_Distance:
                return "Distance";
            case TypeSortCriteria.SortCriteria_Price:
                return "Price";
            case TypeSortCriteria.SortCriteria_StarRating:
                return "StarRating";
            case TypeSortCriteria.SortCriteria_GuestRating:
                return "GuestRating";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeSortOrder
      {
        SortOrder_Ascending,
        SortOrder_Descending
      };

    public static TypeSortOrder  stringToSortOrder(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "scending", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeSortOrder.SortOrder_Ascending;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "escending", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeSortOrder.SortOrder_Descending;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `SortOrder' is not one of the legal values.");
      }

    public static string  stringFromSortOrder(TypeSortOrder the_enum)
      {
        switch (the_enum)
          {
            case TypeSortOrder.SortOrder_Ascending:
                return "Ascending";
            case TypeSortOrder.SortOrder_Descending:
                return "Descending";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeAccommodationTypesInclude
      {
        AccommodationTypesInclude_Motel,
        AccommodationTypesInclude_Resort,
        AccommodationTypesInclude_Bed_x20_And_x20_Breakfast,
        AccommodationTypesInclude_Apartment_x20_Hotel
      };

    public static TypeAccommodationTypesInclude  stringToAccommodationTypesInclude(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "partment Hotel", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeAccommodationTypesInclude.AccommodationTypesInclude_Apartment_x20_Hotel;
                break;
            case 'B':
                if ((String.Compare(chars, 1, "ed And Breakfast", 0, 16, false) == 0) && (chars.Length == 17))
                    return TypeAccommodationTypesInclude.AccommodationTypesInclude_Bed_x20_And_x20_Breakfast;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "otel", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeAccommodationTypesInclude.AccommodationTypesInclude_Motel;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "esort", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeAccommodationTypesInclude.AccommodationTypesInclude_Resort;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `AccommodationTypesInclude' is not one of the legal values.");
      }

    public static string  stringFromAccommodationTypesInclude(TypeAccommodationTypesInclude the_enum)
      {
        switch (the_enum)
          {
            case TypeAccommodationTypesInclude.AccommodationTypesInclude_Motel:
                return "Motel";
            case TypeAccommodationTypesInclude.AccommodationTypesInclude_Resort:
                return "Resort";
            case TypeAccommodationTypesInclude.AccommodationTypesInclude_Bed_x20_And_x20_Breakfast:
                return "Bed And Breakfast";
            case TypeAccommodationTypesInclude.AccommodationTypesInclude_Apartment_x20_Hotel:
                return "Apartment Hotel";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeAccommodationTypesExclude
      {
        AccommodationTypesExclude_Motel,
        AccommodationTypesExclude_Resort,
        AccommodationTypesExclude_Bed_x20_And_x20_Breakfast,
        AccommodationTypesExclude_Apartment_x20_Hotel
      };

    public static TypeAccommodationTypesExclude  stringToAccommodationTypesExclude(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "partment Hotel", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeAccommodationTypesExclude.AccommodationTypesExclude_Apartment_x20_Hotel;
                break;
            case 'B':
                if ((String.Compare(chars, 1, "ed And Breakfast", 0, 16, false) == 0) && (chars.Length == 17))
                    return TypeAccommodationTypesExclude.AccommodationTypesExclude_Bed_x20_And_x20_Breakfast;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "otel", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeAccommodationTypesExclude.AccommodationTypesExclude_Motel;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "esort", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeAccommodationTypesExclude.AccommodationTypesExclude_Resort;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `AccommodationTypesExclude' is not one of the legal values.");
      }

    public static string  stringFromAccommodationTypesExclude(TypeAccommodationTypesExclude the_enum)
      {
        switch (the_enum)
          {
            case TypeAccommodationTypesExclude.AccommodationTypesExclude_Motel:
                return "Motel";
            case TypeAccommodationTypesExclude.AccommodationTypesExclude_Resort:
                return "Resort";
            case TypeAccommodationTypesExclude.AccommodationTypesExclude_Bed_x20_And_x20_Breakfast:
                return "Bed And Breakfast";
            case TypeAccommodationTypesExclude.AccommodationTypesExclude_Apartment_x20_Hotel:
                return "Apartment Hotel";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeAmenitiesIncludeJSON : JSONBase
      {
        public class TypeAmenityGroupJSON : JSONBase
          {
            private bool flagHasAmenityIndex;
            private BigInteger storeAmenityIndex;
            private bool flagHasAmenityID;
            private BigInteger storeAmenityID;
            private bool flagHasAmenityName;
            private string storeAmenityName;
            private bool flagHasAmenitySpokenNameSingular;
            private string storeAmenitySpokenNameSingular;
            private bool flagHasAmenitySpokenNamePlural;
            private string storeAmenitySpokenNamePlural;
            private bool flagHasAmenityTopLevelName;
            private string storeAmenityTopLevelName;
            private bool flagHasAmenityTopLevelSpokenNameSingular;
            private string storeAmenityTopLevelSpokenNameSingular;
            private bool flagHasAmenityTopLevelSpokenNamePlural;
            private string storeAmenityTopLevelSpokenNamePlural;


            private void  fromJSONAmenityIndex(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field AmenityIndex of TypeAmenityGroupJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field AmenityIndex of TypeAmenityGroupJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setAmenityIndex(extracted_integer);
              }


            private void  fromJSONAmenityID(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field AmenityID of TypeAmenityGroupJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field AmenityID of TypeAmenityGroupJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setAmenityID(extracted_integer);
              }


            private void  fromJSONAmenityName(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenityName of TypeAmenityGroupJSON is not a string.");
                setAmenityName(json_string.getData());
              }


            private void  fromJSONAmenitySpokenNameSingular(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenitySpokenNameSingular of TypeAmenityGroupJSON is not a string.");
                setAmenitySpokenNameSingular(json_string.getData());
              }


            private void  fromJSONAmenitySpokenNamePlural(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenitySpokenNamePlural of TypeAmenityGroupJSON is not a string.");
                setAmenitySpokenNamePlural(json_string.getData());
              }


            private void  fromJSONAmenityTopLevelName(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenityTopLevelName of TypeAmenityGroupJSON is not a string.");
                setAmenityTopLevelName(json_string.getData());
              }


            private void  fromJSONAmenityTopLevelSpokenNameSingular(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenityTopLevelSpokenNameSingular of TypeAmenityGroupJSON is not a string.");
                setAmenityTopLevelSpokenNameSingular(json_string.getData());
              }


            private void  fromJSONAmenityTopLevelSpokenNamePlural(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenityTopLevelSpokenNamePlural of TypeAmenityGroupJSON is not a string.");
                setAmenityTopLevelSpokenNamePlural(json_string.getData());
              }


            public TypeAmenityGroupJSON()
              {
                flagHasAmenityIndex = false;
                flagHasAmenityID = false;
                flagHasAmenityName = false;
                flagHasAmenitySpokenNameSingular = false;
                flagHasAmenitySpokenNamePlural = false;
                flagHasAmenityTopLevelName = false;
                flagHasAmenityTopLevelSpokenNameSingular = false;
                flagHasAmenityTopLevelSpokenNamePlural = false;
              }

            public bool  hasAmenityIndex()
              {
                return flagHasAmenityIndex;
              }

            public BigInteger  getAmenityIndex()
              {
                Debug.Assert(flagHasAmenityIndex);
                return storeAmenityIndex;
              }

            public bool  hasAmenityID()
              {
                return flagHasAmenityID;
              }

            public BigInteger  getAmenityID()
              {
                Debug.Assert(flagHasAmenityID);
                return storeAmenityID;
              }

            public bool  hasAmenityName()
              {
                return flagHasAmenityName;
              }

            public string  getAmenityName()
              {
                Debug.Assert(flagHasAmenityName);
                return storeAmenityName;
              }

            public bool  hasAmenitySpokenNameSingular()
              {
                return flagHasAmenitySpokenNameSingular;
              }

            public string  getAmenitySpokenNameSingular()
              {
                Debug.Assert(flagHasAmenitySpokenNameSingular);
                return storeAmenitySpokenNameSingular;
              }

            public bool  hasAmenitySpokenNamePlural()
              {
                return flagHasAmenitySpokenNamePlural;
              }

            public string  getAmenitySpokenNamePlural()
              {
                Debug.Assert(flagHasAmenitySpokenNamePlural);
                return storeAmenitySpokenNamePlural;
              }

            public bool  hasAmenityTopLevelName()
              {
                return flagHasAmenityTopLevelName;
              }

            public string  getAmenityTopLevelName()
              {
                Debug.Assert(flagHasAmenityTopLevelName);
                return storeAmenityTopLevelName;
              }

            public bool  hasAmenityTopLevelSpokenNameSingular()
              {
                return flagHasAmenityTopLevelSpokenNameSingular;
              }

            public string  getAmenityTopLevelSpokenNameSingular()
              {
                Debug.Assert(flagHasAmenityTopLevelSpokenNameSingular);
                return storeAmenityTopLevelSpokenNameSingular;
              }

            public bool  hasAmenityTopLevelSpokenNamePlural()
              {
                return flagHasAmenityTopLevelSpokenNamePlural;
              }

            public string  getAmenityTopLevelSpokenNamePlural()
              {
                Debug.Assert(flagHasAmenityTopLevelSpokenNamePlural);
                return storeAmenityTopLevelSpokenNamePlural;
              }



            public void setAmenityIndex(BigInteger new_value)
              {
                flagHasAmenityIndex = true;
                if (new_value < 0)
                    throw new Exception("The value for field AmenityIndex of TypeAmenityGroupJSON is less than the lower bound (0) for that field.");
                storeAmenityIndex = new_value;
              }
            public void unsetAmenityIndex()
              {
                flagHasAmenityIndex = false;
              }
            public void setAmenityID(BigInteger new_value)
              {
                flagHasAmenityID = true;
                if (new_value < 0)
                    throw new Exception("The value for field AmenityID of TypeAmenityGroupJSON is less than the lower bound (0) for that field.");
                storeAmenityID = new_value;
              }
            public void unsetAmenityID()
              {
                flagHasAmenityID = false;
              }
            public void setAmenityName(string new_value)
              {
                flagHasAmenityName = true;
                storeAmenityName = new_value;
              }
            public void unsetAmenityName()
              {
                flagHasAmenityName = false;
              }
            public void setAmenitySpokenNameSingular(string new_value)
              {
                flagHasAmenitySpokenNameSingular = true;
                storeAmenitySpokenNameSingular = new_value;
              }
            public void unsetAmenitySpokenNameSingular()
              {
                flagHasAmenitySpokenNameSingular = false;
              }
            public void setAmenitySpokenNamePlural(string new_value)
              {
                flagHasAmenitySpokenNamePlural = true;
                storeAmenitySpokenNamePlural = new_value;
              }
            public void unsetAmenitySpokenNamePlural()
              {
                flagHasAmenitySpokenNamePlural = false;
              }
            public void setAmenityTopLevelName(string new_value)
              {
                flagHasAmenityTopLevelName = true;
                storeAmenityTopLevelName = new_value;
              }
            public void unsetAmenityTopLevelName()
              {
                flagHasAmenityTopLevelName = false;
              }
            public void setAmenityTopLevelSpokenNameSingular(string new_value)
              {
                flagHasAmenityTopLevelSpokenNameSingular = true;
                storeAmenityTopLevelSpokenNameSingular = new_value;
              }
            public void unsetAmenityTopLevelSpokenNameSingular()
              {
                flagHasAmenityTopLevelSpokenNameSingular = false;
              }
            public void setAmenityTopLevelSpokenNamePlural(string new_value)
              {
                flagHasAmenityTopLevelSpokenNamePlural = true;
                storeAmenityTopLevelSpokenNamePlural = new_value;
              }
            public void unsetAmenityTopLevelSpokenNamePlural()
              {
                flagHasAmenityTopLevelSpokenNamePlural = false;
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
                Debug.Assert(partial_allowed || flagHasAmenityIndex);
                if (flagHasAmenityIndex)
                  {
                    handler.start_pair("AmenityIndex");
                    handler.number_value(storeAmenityIndex);
                  }
                Debug.Assert(partial_allowed || flagHasAmenityID);
                if (flagHasAmenityID)
                  {
                    handler.start_pair("AmenityID");
                    handler.number_value(storeAmenityID);
                  }
                Debug.Assert(partial_allowed || flagHasAmenityName);
                if (flagHasAmenityName)
                  {
                    handler.start_pair("AmenityName");
                    handler.string_value(storeAmenityName);
                  }
                if (flagHasAmenitySpokenNameSingular)
                  {
                    handler.start_pair("AmenitySpokenNameSingular");
                    handler.string_value(storeAmenitySpokenNameSingular);
                  }
                if (flagHasAmenitySpokenNamePlural)
                  {
                    handler.start_pair("AmenitySpokenNamePlural");
                    handler.string_value(storeAmenitySpokenNamePlural);
                  }
                if (flagHasAmenityTopLevelName)
                  {
                    handler.start_pair("AmenityTopLevelName");
                    handler.string_value(storeAmenityTopLevelName);
                  }
                if (flagHasAmenityTopLevelSpokenNameSingular)
                  {
                    handler.start_pair("AmenityTopLevelSpokenNameSingular");
                    handler.string_value(storeAmenityTopLevelSpokenNameSingular);
                  }
                if (flagHasAmenityTopLevelSpokenNamePlural)
                  {
                    handler.start_pair("AmenityTopLevelSpokenNamePlural");
                    handler.string_value(storeAmenityTopLevelSpokenNamePlural);
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
                if (!(hasAmenityIndex()))
                  {
                    return "When parsing the object for %what%, the \"AmenityIndex\" field was missing.";
                  }
                if (!(hasAmenityID()))
                  {
                    return "When parsing the object for %what%, the \"AmenityID\" field was missing.";
                  }
                if (!(hasAmenityName()))
                  {
                    return "When parsing the object for %what%, the \"AmenityName\" field was missing.";
                  }
                return null;
              }

            public static TypeAmenityGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAmenityGroupJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
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
            public static TypeAmenityGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAmenityGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAmenityGroupJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
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
            public static TypeAmenityGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAmenityGroupJSON from_text(string text, bool ignore_extras)
              {
                TypeAmenityGroupJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeAmenityGroupJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeAmenityGroupJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeAmenityGroupJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
            private class FieldHoldingGeneratorAmenityIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorAmenityIndex(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorAmenityIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorAmenityIndex(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorAmenityIndex fieldGeneratorAmenityIndex;
            private class FieldHoldingGeneratorAmenityID : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorAmenityID(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorAmenityID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorAmenityID(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorAmenityID fieldGeneratorAmenityID;
                private JSONHoldingStringGenerator fieldGeneratorAmenityName;
                private JSONHoldingStringGenerator fieldGeneratorAmenitySpokenNameSingular;
                private JSONHoldingStringGenerator fieldGeneratorAmenitySpokenNamePlural;
                private JSONHoldingStringGenerator fieldGeneratorAmenityTopLevelName;
                private JSONHoldingStringGenerator fieldGeneratorAmenityTopLevelSpokenNameSingular;
                private JSONHoldingStringGenerator fieldGeneratorAmenityTopLevelSpokenNamePlural;

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
                    TypeAmenityGroupJSON result = new TypeAmenityGroupJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    handle_result(result);
                  }
                protected void finish(TypeAmenityGroupJSON result)
                  {
                    if (fieldGeneratorAmenityIndex.have_value)
                      {
                        result.setAmenityIndex(fieldGeneratorAmenityIndex.value);
                        fieldGeneratorAmenityIndex.have_value = false;
                      }
                    else if ((!(result.hasAmenityIndex())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"AmenityIndex\" field was missing.");
                      }
                    if (fieldGeneratorAmenityID.have_value)
                      {
                        result.setAmenityID(fieldGeneratorAmenityID.value);
                        fieldGeneratorAmenityID.have_value = false;
                      }
                    else if ((!(result.hasAmenityID())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"AmenityID\" field was missing.");
                      }
                    if (fieldGeneratorAmenityName.have_value)
                      {
                        result.setAmenityName(fieldGeneratorAmenityName.value);
                        fieldGeneratorAmenityName.have_value = false;
                      }
                    else if ((!(result.hasAmenityName())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"AmenityName\" field was missing.");
                      }
                    if (fieldGeneratorAmenitySpokenNameSingular.have_value)
                      {
                        result.setAmenitySpokenNameSingular(fieldGeneratorAmenitySpokenNameSingular.value);
                        fieldGeneratorAmenitySpokenNameSingular.have_value = false;
                      }
                    if (fieldGeneratorAmenitySpokenNamePlural.have_value)
                      {
                        result.setAmenitySpokenNamePlural(fieldGeneratorAmenitySpokenNamePlural.value);
                        fieldGeneratorAmenitySpokenNamePlural.have_value = false;
                      }
                    if (fieldGeneratorAmenityTopLevelName.have_value)
                      {
                        result.setAmenityTopLevelName(fieldGeneratorAmenityTopLevelName.value);
                        fieldGeneratorAmenityTopLevelName.have_value = false;
                      }
                    if (fieldGeneratorAmenityTopLevelSpokenNameSingular.have_value)
                      {
                        result.setAmenityTopLevelSpokenNameSingular(fieldGeneratorAmenityTopLevelSpokenNameSingular.value);
                        fieldGeneratorAmenityTopLevelSpokenNameSingular.have_value = false;
                      }
                    if (fieldGeneratorAmenityTopLevelSpokenNamePlural.have_value)
                      {
                        result.setAmenityTopLevelSpokenNamePlural(fieldGeneratorAmenityTopLevelSpokenNamePlural.value);
                        fieldGeneratorAmenityTopLevelSpokenNamePlural.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeAmenityGroupJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if (String.Compare(field_name, 0, "Amenity", 0, 7, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'I':
                                switch (field_name[8])
                                  {
                                    case 'D':
                                        if (field_name.Length == 9)
                                            return fieldGeneratorAmenityID;
                                        break;
                                    case 'n':
                                        if ((String.Compare(field_name, 9, "dex", 0, 3, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorAmenityIndex;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorAmenityName;
                                break;
                            case 'S':
                                if (String.Compare(field_name, 8, "pokenName", 0, 9, false) == 0)
                                  {
                                    switch (field_name[17])
                                      {
                                        case 'P':
                                            if ((String.Compare(field_name, 18, "lural", 0, 5, false) == 0) && (field_name.Length == 23))
                                                return fieldGeneratorAmenitySpokenNamePlural;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 18, "ingular", 0, 7, false) == 0) && (field_name.Length == 25))
                                                return fieldGeneratorAmenitySpokenNameSingular;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'T':
                                if (String.Compare(field_name, 8, "opLevel", 0, 7, false) == 0)
                                  {
                                    switch (field_name[15])
                                      {
                                        case 'N':
                                            if ((String.Compare(field_name, 16, "ame", 0, 3, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorAmenityTopLevelName;
                                            break;
                                        case 'S':
                                            if (String.Compare(field_name, 16, "pokenName", 0, 9, false) == 0)
                                              {
                                                switch (field_name[25])
                                                  {
                                                    case 'P':
                                                        if ((String.Compare(field_name, 26, "lural", 0, 5, false) == 0) && (field_name.Length == 31))
                                                            return fieldGeneratorAmenityTopLevelSpokenNamePlural;
                                                        break;
                                                    case 'S':
                                                        if ((String.Compare(field_name, 26, "ingular", 0, 7, false) == 0) && (field_name.Length == 33))
                                                            return fieldGeneratorAmenityTopLevelSpokenNameSingular;
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
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorAmenityIndex = new FieldHoldingGeneratorAmenityIndex("field \"AmenityIndex\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityID = new FieldHoldingGeneratorAmenityID("field \"AmenityID\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityName = new JSONHoldingStringGenerator("field \"AmenityName\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenitySpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenitySpokenNameSingular\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenitySpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenitySpokenNamePlural\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelName = new JSONHoldingStringGenerator("field \"AmenityTopLevelName\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNameSingular\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNamePlural\" of the TypeAmenityGroup class");
                    set_what("the TypeAmenityGroup class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorAmenityIndex = new FieldHoldingGeneratorAmenityIndex("field \"AmenityIndex\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityID = new FieldHoldingGeneratorAmenityID("field \"AmenityID\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityName = new JSONHoldingStringGenerator("field \"AmenityName\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenitySpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenitySpokenNameSingular\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenitySpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenitySpokenNamePlural\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelName = new JSONHoldingStringGenerator("field \"AmenityTopLevelName\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNameSingular\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNamePlural\" of the TypeAmenityGroup class");
                    set_what("the TypeAmenityGroup class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorAmenityIndex.reset();
                    fieldGeneratorAmenityID.reset();
                    fieldGeneratorAmenityName.reset();
                    fieldGeneratorAmenitySpokenNameSingular.reset();
                    fieldGeneratorAmenitySpokenNamePlural.reset();
                    fieldGeneratorAmenityTopLevelName.reset();
                    fieldGeneratorAmenityTopLevelSpokenNameSingular.reset();
                    fieldGeneratorAmenityTopLevelSpokenNamePlural.reset();
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
                protected override void handle_result(TypeAmenityGroupJSON  result)
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
                public TypeAmenityGroupJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeAmenityGroupJSON  result)
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
            protected virtual void handle_result(List<TypeAmenityGroupJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeAmenityGroupJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeAmenityGroupJSON>();
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
            public List<TypeAmenityGroupJSON> value;
          };
          };
        private bool flagHasAmenityGroupName;
        private string storeAmenityGroupName;
        private bool flagHasAmenityGroupSpokenNameSingular;
        private string storeAmenityGroupSpokenNameSingular;
        private bool flagHasAmenityGroupSpokenNamePlural;
        private string storeAmenityGroupSpokenNamePlural;
        private bool flagHasAmenityGroup;
        private List< TypeAmenityGroupJSON  > storeAmenityGroup;


        private void  fromJSONAmenityGroupName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityGroupName of TypeAmenitiesIncludeJSON is not a string.");
            setAmenityGroupName(json_string.getData());
          }


        private void  fromJSONAmenityGroupSpokenNameSingular(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityGroupSpokenNameSingular of TypeAmenitiesIncludeJSON is not a string.");
            setAmenityGroupSpokenNameSingular(json_string.getData());
          }


        private void  fromJSONAmenityGroupSpokenNamePlural(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityGroupSpokenNamePlural of TypeAmenitiesIncludeJSON is not a string.");
            setAmenityGroupSpokenNamePlural(json_string.getData());
          }


        private void  fromJSONAmenityGroup(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field AmenityGroup of TypeAmenitiesIncludeJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeAmenityGroupJSON  > vector_AmenityGroup1 = new List< TypeAmenityGroupJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeAmenityGroupJSON convert_classy = TypeAmenityGroupJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_AmenityGroup1.Add(convert_classy);
              }
            initAmenityGroup();
            for (int num1 = 0; num1 < vector_AmenityGroup1.Count; ++num1)
                appendAmenityGroup(vector_AmenityGroup1[num1]);
            for (int num1 = 0; num1 < vector_AmenityGroup1.Count; ++num1)
              {
              }
          }


        public TypeAmenitiesIncludeJSON()
          {
            flagHasAmenityGroupName = false;
            flagHasAmenityGroupSpokenNameSingular = false;
            flagHasAmenityGroupSpokenNamePlural = false;
            flagHasAmenityGroup = false;
            storeAmenityGroup = new List< TypeAmenityGroupJSON  >();
          }

        public bool  hasAmenityGroupName()
          {
            return flagHasAmenityGroupName;
          }

        public string  getAmenityGroupName()
          {
            Debug.Assert(flagHasAmenityGroupName);
            return storeAmenityGroupName;
          }

        public bool  hasAmenityGroupSpokenNameSingular()
          {
            return flagHasAmenityGroupSpokenNameSingular;
          }

        public string  getAmenityGroupSpokenNameSingular()
          {
            Debug.Assert(flagHasAmenityGroupSpokenNameSingular);
            return storeAmenityGroupSpokenNameSingular;
          }

        public bool  hasAmenityGroupSpokenNamePlural()
          {
            return flagHasAmenityGroupSpokenNamePlural;
          }

        public string  getAmenityGroupSpokenNamePlural()
          {
            Debug.Assert(flagHasAmenityGroupSpokenNamePlural);
            return storeAmenityGroupSpokenNamePlural;
          }

        public bool  hasAmenityGroup()
          {
            return flagHasAmenityGroup;
          }

        public int  countOfAmenityGroup()
          {
            Debug.Assert(flagHasAmenityGroup);
            return storeAmenityGroup.Count;
          }

        public TypeAmenityGroupJSON   elementOfAmenityGroup(int element_num)
          {
            Debug.Assert(flagHasAmenityGroup);
            return storeAmenityGroup[element_num];
          }

        public List< TypeAmenityGroupJSON  >  getAmenityGroup()
          {
            Debug.Assert(flagHasAmenityGroup);
            return storeAmenityGroup;
          }



        public void setAmenityGroupName(string new_value)
          {
            flagHasAmenityGroupName = true;
            storeAmenityGroupName = new_value;
          }
        public void unsetAmenityGroupName()
          {
            flagHasAmenityGroupName = false;
          }
        public void setAmenityGroupSpokenNameSingular(string new_value)
          {
            flagHasAmenityGroupSpokenNameSingular = true;
            storeAmenityGroupSpokenNameSingular = new_value;
          }
        public void unsetAmenityGroupSpokenNameSingular()
          {
            flagHasAmenityGroupSpokenNameSingular = false;
          }
        public void setAmenityGroupSpokenNamePlural(string new_value)
          {
            flagHasAmenityGroupSpokenNamePlural = true;
            storeAmenityGroupSpokenNamePlural = new_value;
          }
        public void unsetAmenityGroupSpokenNamePlural()
          {
            flagHasAmenityGroupSpokenNamePlural = false;
          }
        public void initAmenityGroup()
          {
            if (flagHasAmenityGroup)
              {
                for (int num1 = 0; num1 < storeAmenityGroup.Count; ++num1)
                  {
                  }
              }
            flagHasAmenityGroup = true;
            storeAmenityGroup.Clear();
          }
        public void appendAmenityGroup(TypeAmenityGroupJSON  to_append)
          {
            if (!flagHasAmenityGroup)
              {
                flagHasAmenityGroup = true;
                storeAmenityGroup.Clear();
              }
            Debug.Assert(flagHasAmenityGroup);
            storeAmenityGroup.Add(to_append);
          }
        public void unsetAmenityGroup()
          {
            if (flagHasAmenityGroup)
              {
                for (int num2 = 0; num2 < storeAmenityGroup.Count; ++num2)
                  {
                  }
              }
            flagHasAmenityGroup = false;
            storeAmenityGroup.Clear();
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
            if (flagHasAmenityGroupName)
              {
                handler.start_pair("AmenityGroupName");
                handler.string_value(storeAmenityGroupName);
              }
            if (flagHasAmenityGroupSpokenNameSingular)
              {
                handler.start_pair("AmenityGroupSpokenNameSingular");
                handler.string_value(storeAmenityGroupSpokenNameSingular);
              }
            if (flagHasAmenityGroupSpokenNamePlural)
              {
                handler.start_pair("AmenityGroupSpokenNamePlural");
                handler.string_value(storeAmenityGroupSpokenNamePlural);
              }
            Debug.Assert(partial_allowed || flagHasAmenityGroup);
            if (flagHasAmenityGroup)
              {
                handler.start_pair("AmenityGroup");
                handler.start_array();
                for (int num1 = 0; num1 < storeAmenityGroup.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeAmenityGroup[num1].write_partial_as_json(handler);
                    else
                        storeAmenityGroup[num1].write_as_json(handler);
                  }
                handler.finish_array();
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
            if (!(hasAmenityGroup()))
              {
                return "When parsing the object for %what%, the \"AmenityGroup\" field was missing.";
              }
            return null;
          }

        public static TypeAmenitiesIncludeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAmenitiesIncludeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenitiesInclude", ignore_extras);
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
        public static TypeAmenitiesIncludeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAmenitiesIncludeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAmenitiesIncludeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenitiesInclude", ignore_extras);
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
        public static TypeAmenitiesIncludeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAmenitiesIncludeJSON from_text(string text, bool ignore_extras)
          {
            TypeAmenitiesIncludeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenitiesInclude", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAmenitiesIncludeJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAmenitiesIncludeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAmenitiesIncludeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenitiesInclude", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorAmenityGroupName;
            private JSONHoldingStringGenerator fieldGeneratorAmenityGroupSpokenNameSingular;
            private JSONHoldingStringGenerator fieldGeneratorAmenityGroupSpokenNamePlural;
            private TypeAmenityGroupJSON.HoldingArrayGenerator fieldGeneratorAmenityGroup;

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
                TypeAmenitiesIncludeJSON result = new TypeAmenitiesIncludeJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeAmenitiesIncludeJSON result)
              {
                if (fieldGeneratorAmenityGroupName.have_value)
                  {
                    result.setAmenityGroupName(fieldGeneratorAmenityGroupName.value);
                    fieldGeneratorAmenityGroupName.have_value = false;
                  }
                if (fieldGeneratorAmenityGroupSpokenNameSingular.have_value)
                  {
                    result.setAmenityGroupSpokenNameSingular(fieldGeneratorAmenityGroupSpokenNameSingular.value);
                    fieldGeneratorAmenityGroupSpokenNameSingular.have_value = false;
                  }
                if (fieldGeneratorAmenityGroupSpokenNamePlural.have_value)
                  {
                    result.setAmenityGroupSpokenNamePlural(fieldGeneratorAmenityGroupSpokenNamePlural.value);
                    fieldGeneratorAmenityGroupSpokenNamePlural.have_value = false;
                  }
                if (fieldGeneratorAmenityGroup.have_value)
                  {
                    result.initAmenityGroup();
                    int count = fieldGeneratorAmenityGroup.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendAmenityGroup(fieldGeneratorAmenityGroup.value[num]);
                      }
                    fieldGeneratorAmenityGroup.value.Clear();
                    fieldGeneratorAmenityGroup.have_value = false;
                  }
                else if ((!(result.hasAmenityGroup())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"AmenityGroup\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeAmenitiesIncludeJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "AmenityGroup", 0, 12, false) == 0)
                  {
                    if (field_name.Length == 12)
                      {
                        return fieldGeneratorAmenityGroup;
                      }
                    switch (field_name[12])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 13, "ame", 0, 3, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorAmenityGroupName;
                            break;
                        case 'S':
                            if (String.Compare(field_name, 13, "pokenName", 0, 9, false) == 0)
                              {
                                switch (field_name[22])
                                  {
                                    case 'P':
                                        if ((String.Compare(field_name, 23, "lural", 0, 5, false) == 0) && (field_name.Length == 28))
                                            return fieldGeneratorAmenityGroupSpokenNamePlural;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 23, "ingular", 0, 7, false) == 0) && (field_name.Length == 30))
                                            return fieldGeneratorAmenityGroupSpokenNameSingular;
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
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorAmenityGroupName = new JSONHoldingStringGenerator("field \"AmenityGroupName\" of the TypeAmenitiesInclude class");
                fieldGeneratorAmenityGroupSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNameSingular\" of the TypeAmenitiesInclude class");
                fieldGeneratorAmenityGroupSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNamePlural\" of the TypeAmenitiesInclude class");
                fieldGeneratorAmenityGroup = new TypeAmenityGroupJSON.HoldingArrayGenerator("field \"AmenityGroup\" of the TypeAmenitiesInclude class", ignore_extras);
                set_what("the TypeAmenitiesInclude class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorAmenityGroupName = new JSONHoldingStringGenerator("field \"AmenityGroupName\" of the TypeAmenitiesInclude class");
                fieldGeneratorAmenityGroupSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNameSingular\" of the TypeAmenitiesInclude class");
                fieldGeneratorAmenityGroupSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNamePlural\" of the TypeAmenitiesInclude class");
                fieldGeneratorAmenityGroup = new TypeAmenityGroupJSON.HoldingArrayGenerator("field \"AmenityGroup\" of the TypeAmenitiesInclude class", false);
                set_what("the TypeAmenitiesInclude class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorAmenityGroupName.reset();
                fieldGeneratorAmenityGroupSpokenNameSingular.reset();
                fieldGeneratorAmenityGroupSpokenNamePlural.reset();
                fieldGeneratorAmenityGroup.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorAmenityGroup.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorAmenityGroup.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeAmenitiesIncludeJSON  result)
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
            public TypeAmenitiesIncludeJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAmenitiesIncludeJSON  result)
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
        protected virtual void handle_result(List<TypeAmenitiesIncludeJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAmenitiesIncludeJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAmenitiesIncludeJSON>();
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
        public List<TypeAmenitiesIncludeJSON> value;
      };
      };
    public class TypeAmenitiesExcludeJSON : JSONBase
      {
        public class TypeAmenityGroupJSON : JSONBase
          {
            private bool flagHasAmenityIndex;
            private BigInteger storeAmenityIndex;
            private bool flagHasAmenityID;
            private BigInteger storeAmenityID;
            private bool flagHasAmenityName;
            private string storeAmenityName;
            private bool flagHasAmenitySpokenNameSingular;
            private string storeAmenitySpokenNameSingular;
            private bool flagHasAmenitySpokenNamePlural;
            private string storeAmenitySpokenNamePlural;
            private bool flagHasAmenityTopLevelName;
            private string storeAmenityTopLevelName;
            private bool flagHasAmenityTopLevelSpokenNameSingular;
            private string storeAmenityTopLevelSpokenNameSingular;
            private bool flagHasAmenityTopLevelSpokenNamePlural;
            private string storeAmenityTopLevelSpokenNamePlural;


            private void  fromJSONAmenityIndex(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field AmenityIndex of TypeAmenityGroupJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field AmenityIndex of TypeAmenityGroupJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setAmenityIndex(extracted_integer);
              }


            private void  fromJSONAmenityID(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field AmenityID of TypeAmenityGroupJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field AmenityID of TypeAmenityGroupJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setAmenityID(extracted_integer);
              }


            private void  fromJSONAmenityName(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenityName of TypeAmenityGroupJSON is not a string.");
                setAmenityName(json_string.getData());
              }


            private void  fromJSONAmenitySpokenNameSingular(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenitySpokenNameSingular of TypeAmenityGroupJSON is not a string.");
                setAmenitySpokenNameSingular(json_string.getData());
              }


            private void  fromJSONAmenitySpokenNamePlural(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenitySpokenNamePlural of TypeAmenityGroupJSON is not a string.");
                setAmenitySpokenNamePlural(json_string.getData());
              }


            private void  fromJSONAmenityTopLevelName(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenityTopLevelName of TypeAmenityGroupJSON is not a string.");
                setAmenityTopLevelName(json_string.getData());
              }


            private void  fromJSONAmenityTopLevelSpokenNameSingular(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenityTopLevelSpokenNameSingular of TypeAmenityGroupJSON is not a string.");
                setAmenityTopLevelSpokenNameSingular(json_string.getData());
              }


            private void  fromJSONAmenityTopLevelSpokenNamePlural(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field AmenityTopLevelSpokenNamePlural of TypeAmenityGroupJSON is not a string.");
                setAmenityTopLevelSpokenNamePlural(json_string.getData());
              }


            public TypeAmenityGroupJSON()
              {
                flagHasAmenityIndex = false;
                flagHasAmenityID = false;
                flagHasAmenityName = false;
                flagHasAmenitySpokenNameSingular = false;
                flagHasAmenitySpokenNamePlural = false;
                flagHasAmenityTopLevelName = false;
                flagHasAmenityTopLevelSpokenNameSingular = false;
                flagHasAmenityTopLevelSpokenNamePlural = false;
              }

            public bool  hasAmenityIndex()
              {
                return flagHasAmenityIndex;
              }

            public BigInteger  getAmenityIndex()
              {
                Debug.Assert(flagHasAmenityIndex);
                return storeAmenityIndex;
              }

            public bool  hasAmenityID()
              {
                return flagHasAmenityID;
              }

            public BigInteger  getAmenityID()
              {
                Debug.Assert(flagHasAmenityID);
                return storeAmenityID;
              }

            public bool  hasAmenityName()
              {
                return flagHasAmenityName;
              }

            public string  getAmenityName()
              {
                Debug.Assert(flagHasAmenityName);
                return storeAmenityName;
              }

            public bool  hasAmenitySpokenNameSingular()
              {
                return flagHasAmenitySpokenNameSingular;
              }

            public string  getAmenitySpokenNameSingular()
              {
                Debug.Assert(flagHasAmenitySpokenNameSingular);
                return storeAmenitySpokenNameSingular;
              }

            public bool  hasAmenitySpokenNamePlural()
              {
                return flagHasAmenitySpokenNamePlural;
              }

            public string  getAmenitySpokenNamePlural()
              {
                Debug.Assert(flagHasAmenitySpokenNamePlural);
                return storeAmenitySpokenNamePlural;
              }

            public bool  hasAmenityTopLevelName()
              {
                return flagHasAmenityTopLevelName;
              }

            public string  getAmenityTopLevelName()
              {
                Debug.Assert(flagHasAmenityTopLevelName);
                return storeAmenityTopLevelName;
              }

            public bool  hasAmenityTopLevelSpokenNameSingular()
              {
                return flagHasAmenityTopLevelSpokenNameSingular;
              }

            public string  getAmenityTopLevelSpokenNameSingular()
              {
                Debug.Assert(flagHasAmenityTopLevelSpokenNameSingular);
                return storeAmenityTopLevelSpokenNameSingular;
              }

            public bool  hasAmenityTopLevelSpokenNamePlural()
              {
                return flagHasAmenityTopLevelSpokenNamePlural;
              }

            public string  getAmenityTopLevelSpokenNamePlural()
              {
                Debug.Assert(flagHasAmenityTopLevelSpokenNamePlural);
                return storeAmenityTopLevelSpokenNamePlural;
              }



            public void setAmenityIndex(BigInteger new_value)
              {
                flagHasAmenityIndex = true;
                if (new_value < 0)
                    throw new Exception("The value for field AmenityIndex of TypeAmenityGroupJSON is less than the lower bound (0) for that field.");
                storeAmenityIndex = new_value;
              }
            public void unsetAmenityIndex()
              {
                flagHasAmenityIndex = false;
              }
            public void setAmenityID(BigInteger new_value)
              {
                flagHasAmenityID = true;
                if (new_value < 0)
                    throw new Exception("The value for field AmenityID of TypeAmenityGroupJSON is less than the lower bound (0) for that field.");
                storeAmenityID = new_value;
              }
            public void unsetAmenityID()
              {
                flagHasAmenityID = false;
              }
            public void setAmenityName(string new_value)
              {
                flagHasAmenityName = true;
                storeAmenityName = new_value;
              }
            public void unsetAmenityName()
              {
                flagHasAmenityName = false;
              }
            public void setAmenitySpokenNameSingular(string new_value)
              {
                flagHasAmenitySpokenNameSingular = true;
                storeAmenitySpokenNameSingular = new_value;
              }
            public void unsetAmenitySpokenNameSingular()
              {
                flagHasAmenitySpokenNameSingular = false;
              }
            public void setAmenitySpokenNamePlural(string new_value)
              {
                flagHasAmenitySpokenNamePlural = true;
                storeAmenitySpokenNamePlural = new_value;
              }
            public void unsetAmenitySpokenNamePlural()
              {
                flagHasAmenitySpokenNamePlural = false;
              }
            public void setAmenityTopLevelName(string new_value)
              {
                flagHasAmenityTopLevelName = true;
                storeAmenityTopLevelName = new_value;
              }
            public void unsetAmenityTopLevelName()
              {
                flagHasAmenityTopLevelName = false;
              }
            public void setAmenityTopLevelSpokenNameSingular(string new_value)
              {
                flagHasAmenityTopLevelSpokenNameSingular = true;
                storeAmenityTopLevelSpokenNameSingular = new_value;
              }
            public void unsetAmenityTopLevelSpokenNameSingular()
              {
                flagHasAmenityTopLevelSpokenNameSingular = false;
              }
            public void setAmenityTopLevelSpokenNamePlural(string new_value)
              {
                flagHasAmenityTopLevelSpokenNamePlural = true;
                storeAmenityTopLevelSpokenNamePlural = new_value;
              }
            public void unsetAmenityTopLevelSpokenNamePlural()
              {
                flagHasAmenityTopLevelSpokenNamePlural = false;
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
                Debug.Assert(partial_allowed || flagHasAmenityIndex);
                if (flagHasAmenityIndex)
                  {
                    handler.start_pair("AmenityIndex");
                    handler.number_value(storeAmenityIndex);
                  }
                Debug.Assert(partial_allowed || flagHasAmenityID);
                if (flagHasAmenityID)
                  {
                    handler.start_pair("AmenityID");
                    handler.number_value(storeAmenityID);
                  }
                Debug.Assert(partial_allowed || flagHasAmenityName);
                if (flagHasAmenityName)
                  {
                    handler.start_pair("AmenityName");
                    handler.string_value(storeAmenityName);
                  }
                if (flagHasAmenitySpokenNameSingular)
                  {
                    handler.start_pair("AmenitySpokenNameSingular");
                    handler.string_value(storeAmenitySpokenNameSingular);
                  }
                if (flagHasAmenitySpokenNamePlural)
                  {
                    handler.start_pair("AmenitySpokenNamePlural");
                    handler.string_value(storeAmenitySpokenNamePlural);
                  }
                if (flagHasAmenityTopLevelName)
                  {
                    handler.start_pair("AmenityTopLevelName");
                    handler.string_value(storeAmenityTopLevelName);
                  }
                if (flagHasAmenityTopLevelSpokenNameSingular)
                  {
                    handler.start_pair("AmenityTopLevelSpokenNameSingular");
                    handler.string_value(storeAmenityTopLevelSpokenNameSingular);
                  }
                if (flagHasAmenityTopLevelSpokenNamePlural)
                  {
                    handler.start_pair("AmenityTopLevelSpokenNamePlural");
                    handler.string_value(storeAmenityTopLevelSpokenNamePlural);
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
                if (!(hasAmenityIndex()))
                  {
                    return "When parsing the object for %what%, the \"AmenityIndex\" field was missing.";
                  }
                if (!(hasAmenityID()))
                  {
                    return "When parsing the object for %what%, the \"AmenityID\" field was missing.";
                  }
                if (!(hasAmenityName()))
                  {
                    return "When parsing the object for %what%, the \"AmenityName\" field was missing.";
                  }
                return null;
              }

            public static TypeAmenityGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAmenityGroupJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
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
            public static TypeAmenityGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAmenityGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAmenityGroupJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
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
            public static TypeAmenityGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAmenityGroupJSON from_text(string text, bool ignore_extras)
              {
                TypeAmenityGroupJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeAmenityGroupJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeAmenityGroupJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeAmenityGroupJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
            private class FieldHoldingGeneratorAmenityIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorAmenityIndex(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorAmenityIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorAmenityIndex(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorAmenityIndex fieldGeneratorAmenityIndex;
            private class FieldHoldingGeneratorAmenityID : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorAmenityID(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorAmenityID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorAmenityID(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorAmenityID fieldGeneratorAmenityID;
                private JSONHoldingStringGenerator fieldGeneratorAmenityName;
                private JSONHoldingStringGenerator fieldGeneratorAmenitySpokenNameSingular;
                private JSONHoldingStringGenerator fieldGeneratorAmenitySpokenNamePlural;
                private JSONHoldingStringGenerator fieldGeneratorAmenityTopLevelName;
                private JSONHoldingStringGenerator fieldGeneratorAmenityTopLevelSpokenNameSingular;
                private JSONHoldingStringGenerator fieldGeneratorAmenityTopLevelSpokenNamePlural;

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
                    TypeAmenityGroupJSON result = new TypeAmenityGroupJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    handle_result(result);
                  }
                protected void finish(TypeAmenityGroupJSON result)
                  {
                    if (fieldGeneratorAmenityIndex.have_value)
                      {
                        result.setAmenityIndex(fieldGeneratorAmenityIndex.value);
                        fieldGeneratorAmenityIndex.have_value = false;
                      }
                    else if ((!(result.hasAmenityIndex())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"AmenityIndex\" field was missing.");
                      }
                    if (fieldGeneratorAmenityID.have_value)
                      {
                        result.setAmenityID(fieldGeneratorAmenityID.value);
                        fieldGeneratorAmenityID.have_value = false;
                      }
                    else if ((!(result.hasAmenityID())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"AmenityID\" field was missing.");
                      }
                    if (fieldGeneratorAmenityName.have_value)
                      {
                        result.setAmenityName(fieldGeneratorAmenityName.value);
                        fieldGeneratorAmenityName.have_value = false;
                      }
                    else if ((!(result.hasAmenityName())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"AmenityName\" field was missing.");
                      }
                    if (fieldGeneratorAmenitySpokenNameSingular.have_value)
                      {
                        result.setAmenitySpokenNameSingular(fieldGeneratorAmenitySpokenNameSingular.value);
                        fieldGeneratorAmenitySpokenNameSingular.have_value = false;
                      }
                    if (fieldGeneratorAmenitySpokenNamePlural.have_value)
                      {
                        result.setAmenitySpokenNamePlural(fieldGeneratorAmenitySpokenNamePlural.value);
                        fieldGeneratorAmenitySpokenNamePlural.have_value = false;
                      }
                    if (fieldGeneratorAmenityTopLevelName.have_value)
                      {
                        result.setAmenityTopLevelName(fieldGeneratorAmenityTopLevelName.value);
                        fieldGeneratorAmenityTopLevelName.have_value = false;
                      }
                    if (fieldGeneratorAmenityTopLevelSpokenNameSingular.have_value)
                      {
                        result.setAmenityTopLevelSpokenNameSingular(fieldGeneratorAmenityTopLevelSpokenNameSingular.value);
                        fieldGeneratorAmenityTopLevelSpokenNameSingular.have_value = false;
                      }
                    if (fieldGeneratorAmenityTopLevelSpokenNamePlural.have_value)
                      {
                        result.setAmenityTopLevelSpokenNamePlural(fieldGeneratorAmenityTopLevelSpokenNamePlural.value);
                        fieldGeneratorAmenityTopLevelSpokenNamePlural.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeAmenityGroupJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if (String.Compare(field_name, 0, "Amenity", 0, 7, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'I':
                                switch (field_name[8])
                                  {
                                    case 'D':
                                        if (field_name.Length == 9)
                                            return fieldGeneratorAmenityID;
                                        break;
                                    case 'n':
                                        if ((String.Compare(field_name, 9, "dex", 0, 3, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorAmenityIndex;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorAmenityName;
                                break;
                            case 'S':
                                if (String.Compare(field_name, 8, "pokenName", 0, 9, false) == 0)
                                  {
                                    switch (field_name[17])
                                      {
                                        case 'P':
                                            if ((String.Compare(field_name, 18, "lural", 0, 5, false) == 0) && (field_name.Length == 23))
                                                return fieldGeneratorAmenitySpokenNamePlural;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 18, "ingular", 0, 7, false) == 0) && (field_name.Length == 25))
                                                return fieldGeneratorAmenitySpokenNameSingular;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'T':
                                if (String.Compare(field_name, 8, "opLevel", 0, 7, false) == 0)
                                  {
                                    switch (field_name[15])
                                      {
                                        case 'N':
                                            if ((String.Compare(field_name, 16, "ame", 0, 3, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorAmenityTopLevelName;
                                            break;
                                        case 'S':
                                            if (String.Compare(field_name, 16, "pokenName", 0, 9, false) == 0)
                                              {
                                                switch (field_name[25])
                                                  {
                                                    case 'P':
                                                        if ((String.Compare(field_name, 26, "lural", 0, 5, false) == 0) && (field_name.Length == 31))
                                                            return fieldGeneratorAmenityTopLevelSpokenNamePlural;
                                                        break;
                                                    case 'S':
                                                        if ((String.Compare(field_name, 26, "ingular", 0, 7, false) == 0) && (field_name.Length == 33))
                                                            return fieldGeneratorAmenityTopLevelSpokenNameSingular;
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
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorAmenityIndex = new FieldHoldingGeneratorAmenityIndex("field \"AmenityIndex\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityID = new FieldHoldingGeneratorAmenityID("field \"AmenityID\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityName = new JSONHoldingStringGenerator("field \"AmenityName\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenitySpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenitySpokenNameSingular\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenitySpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenitySpokenNamePlural\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelName = new JSONHoldingStringGenerator("field \"AmenityTopLevelName\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNameSingular\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNamePlural\" of the TypeAmenityGroup class");
                    set_what("the TypeAmenityGroup class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorAmenityIndex = new FieldHoldingGeneratorAmenityIndex("field \"AmenityIndex\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityID = new FieldHoldingGeneratorAmenityID("field \"AmenityID\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityName = new JSONHoldingStringGenerator("field \"AmenityName\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenitySpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenitySpokenNameSingular\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenitySpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenitySpokenNamePlural\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelName = new JSONHoldingStringGenerator("field \"AmenityTopLevelName\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNameSingular\" of the TypeAmenityGroup class");
                    fieldGeneratorAmenityTopLevelSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNamePlural\" of the TypeAmenityGroup class");
                    set_what("the TypeAmenityGroup class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorAmenityIndex.reset();
                    fieldGeneratorAmenityID.reset();
                    fieldGeneratorAmenityName.reset();
                    fieldGeneratorAmenitySpokenNameSingular.reset();
                    fieldGeneratorAmenitySpokenNamePlural.reset();
                    fieldGeneratorAmenityTopLevelName.reset();
                    fieldGeneratorAmenityTopLevelSpokenNameSingular.reset();
                    fieldGeneratorAmenityTopLevelSpokenNamePlural.reset();
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
                protected override void handle_result(TypeAmenityGroupJSON  result)
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
                public TypeAmenityGroupJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeAmenityGroupJSON  result)
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
            protected virtual void handle_result(List<TypeAmenityGroupJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeAmenityGroupJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeAmenityGroupJSON>();
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
            public List<TypeAmenityGroupJSON> value;
          };
          };
        private bool flagHasAmenityGroupName;
        private string storeAmenityGroupName;
        private bool flagHasAmenityGroupSpokenNameSingular;
        private string storeAmenityGroupSpokenNameSingular;
        private bool flagHasAmenityGroupSpokenNamePlural;
        private string storeAmenityGroupSpokenNamePlural;
        private bool flagHasAmenityGroup;
        private List< TypeAmenityGroupJSON  > storeAmenityGroup;


        private void  fromJSONAmenityGroupName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityGroupName of TypeAmenitiesExcludeJSON is not a string.");
            setAmenityGroupName(json_string.getData());
          }


        private void  fromJSONAmenityGroupSpokenNameSingular(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityGroupSpokenNameSingular of TypeAmenitiesExcludeJSON is not a string.");
            setAmenityGroupSpokenNameSingular(json_string.getData());
          }


        private void  fromJSONAmenityGroupSpokenNamePlural(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityGroupSpokenNamePlural of TypeAmenitiesExcludeJSON is not a string.");
            setAmenityGroupSpokenNamePlural(json_string.getData());
          }


        private void  fromJSONAmenityGroup(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field AmenityGroup of TypeAmenitiesExcludeJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeAmenityGroupJSON  > vector_AmenityGroup1 = new List< TypeAmenityGroupJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeAmenityGroupJSON convert_classy = TypeAmenityGroupJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_AmenityGroup1.Add(convert_classy);
              }
            initAmenityGroup();
            for (int num2 = 0; num2 < vector_AmenityGroup1.Count; ++num2)
                appendAmenityGroup(vector_AmenityGroup1[num2]);
            for (int num1 = 0; num1 < vector_AmenityGroup1.Count; ++num1)
              {
              }
          }


        public TypeAmenitiesExcludeJSON()
          {
            flagHasAmenityGroupName = false;
            flagHasAmenityGroupSpokenNameSingular = false;
            flagHasAmenityGroupSpokenNamePlural = false;
            flagHasAmenityGroup = false;
            storeAmenityGroup = new List< TypeAmenityGroupJSON  >();
          }

        public bool  hasAmenityGroupName()
          {
            return flagHasAmenityGroupName;
          }

        public string  getAmenityGroupName()
          {
            Debug.Assert(flagHasAmenityGroupName);
            return storeAmenityGroupName;
          }

        public bool  hasAmenityGroupSpokenNameSingular()
          {
            return flagHasAmenityGroupSpokenNameSingular;
          }

        public string  getAmenityGroupSpokenNameSingular()
          {
            Debug.Assert(flagHasAmenityGroupSpokenNameSingular);
            return storeAmenityGroupSpokenNameSingular;
          }

        public bool  hasAmenityGroupSpokenNamePlural()
          {
            return flagHasAmenityGroupSpokenNamePlural;
          }

        public string  getAmenityGroupSpokenNamePlural()
          {
            Debug.Assert(flagHasAmenityGroupSpokenNamePlural);
            return storeAmenityGroupSpokenNamePlural;
          }

        public bool  hasAmenityGroup()
          {
            return flagHasAmenityGroup;
          }

        public int  countOfAmenityGroup()
          {
            Debug.Assert(flagHasAmenityGroup);
            return storeAmenityGroup.Count;
          }

        public TypeAmenityGroupJSON   elementOfAmenityGroup(int element_num)
          {
            Debug.Assert(flagHasAmenityGroup);
            return storeAmenityGroup[element_num];
          }

        public List< TypeAmenityGroupJSON  >  getAmenityGroup()
          {
            Debug.Assert(flagHasAmenityGroup);
            return storeAmenityGroup;
          }



        public void setAmenityGroupName(string new_value)
          {
            flagHasAmenityGroupName = true;
            storeAmenityGroupName = new_value;
          }
        public void unsetAmenityGroupName()
          {
            flagHasAmenityGroupName = false;
          }
        public void setAmenityGroupSpokenNameSingular(string new_value)
          {
            flagHasAmenityGroupSpokenNameSingular = true;
            storeAmenityGroupSpokenNameSingular = new_value;
          }
        public void unsetAmenityGroupSpokenNameSingular()
          {
            flagHasAmenityGroupSpokenNameSingular = false;
          }
        public void setAmenityGroupSpokenNamePlural(string new_value)
          {
            flagHasAmenityGroupSpokenNamePlural = true;
            storeAmenityGroupSpokenNamePlural = new_value;
          }
        public void unsetAmenityGroupSpokenNamePlural()
          {
            flagHasAmenityGroupSpokenNamePlural = false;
          }
        public void initAmenityGroup()
          {
            if (flagHasAmenityGroup)
              {
                for (int num3 = 0; num3 < storeAmenityGroup.Count; ++num3)
                  {
                  }
              }
            flagHasAmenityGroup = true;
            storeAmenityGroup.Clear();
          }
        public void appendAmenityGroup(TypeAmenityGroupJSON  to_append)
          {
            if (!flagHasAmenityGroup)
              {
                flagHasAmenityGroup = true;
                storeAmenityGroup.Clear();
              }
            Debug.Assert(flagHasAmenityGroup);
            storeAmenityGroup.Add(to_append);
          }
        public void unsetAmenityGroup()
          {
            if (flagHasAmenityGroup)
              {
                for (int num4 = 0; num4 < storeAmenityGroup.Count; ++num4)
                  {
                  }
              }
            flagHasAmenityGroup = false;
            storeAmenityGroup.Clear();
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
            if (flagHasAmenityGroupName)
              {
                handler.start_pair("AmenityGroupName");
                handler.string_value(storeAmenityGroupName);
              }
            if (flagHasAmenityGroupSpokenNameSingular)
              {
                handler.start_pair("AmenityGroupSpokenNameSingular");
                handler.string_value(storeAmenityGroupSpokenNameSingular);
              }
            if (flagHasAmenityGroupSpokenNamePlural)
              {
                handler.start_pair("AmenityGroupSpokenNamePlural");
                handler.string_value(storeAmenityGroupSpokenNamePlural);
              }
            Debug.Assert(partial_allowed || flagHasAmenityGroup);
            if (flagHasAmenityGroup)
              {
                handler.start_pair("AmenityGroup");
                handler.start_array();
                for (int num1 = 0; num1 < storeAmenityGroup.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeAmenityGroup[num1].write_partial_as_json(handler);
                    else
                        storeAmenityGroup[num1].write_as_json(handler);
                  }
                handler.finish_array();
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
            if (!(hasAmenityGroup()))
              {
                return "When parsing the object for %what%, the \"AmenityGroup\" field was missing.";
              }
            return null;
          }

        public static TypeAmenitiesExcludeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAmenitiesExcludeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenitiesExclude", ignore_extras);
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
        public static TypeAmenitiesExcludeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAmenitiesExcludeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAmenitiesExcludeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenitiesExclude", ignore_extras);
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
        public static TypeAmenitiesExcludeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAmenitiesExcludeJSON from_text(string text, bool ignore_extras)
          {
            TypeAmenitiesExcludeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenitiesExclude", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAmenitiesExcludeJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAmenitiesExcludeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAmenitiesExcludeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenitiesExclude", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorAmenityGroupName;
            private JSONHoldingStringGenerator fieldGeneratorAmenityGroupSpokenNameSingular;
            private JSONHoldingStringGenerator fieldGeneratorAmenityGroupSpokenNamePlural;
            private TypeAmenityGroupJSON.HoldingArrayGenerator fieldGeneratorAmenityGroup;

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
                TypeAmenitiesExcludeJSON result = new TypeAmenitiesExcludeJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeAmenitiesExcludeJSON result)
              {
                if (fieldGeneratorAmenityGroupName.have_value)
                  {
                    result.setAmenityGroupName(fieldGeneratorAmenityGroupName.value);
                    fieldGeneratorAmenityGroupName.have_value = false;
                  }
                if (fieldGeneratorAmenityGroupSpokenNameSingular.have_value)
                  {
                    result.setAmenityGroupSpokenNameSingular(fieldGeneratorAmenityGroupSpokenNameSingular.value);
                    fieldGeneratorAmenityGroupSpokenNameSingular.have_value = false;
                  }
                if (fieldGeneratorAmenityGroupSpokenNamePlural.have_value)
                  {
                    result.setAmenityGroupSpokenNamePlural(fieldGeneratorAmenityGroupSpokenNamePlural.value);
                    fieldGeneratorAmenityGroupSpokenNamePlural.have_value = false;
                  }
                if (fieldGeneratorAmenityGroup.have_value)
                  {
                    result.initAmenityGroup();
                    int count = fieldGeneratorAmenityGroup.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendAmenityGroup(fieldGeneratorAmenityGroup.value[num]);
                      }
                    fieldGeneratorAmenityGroup.value.Clear();
                    fieldGeneratorAmenityGroup.have_value = false;
                  }
                else if ((!(result.hasAmenityGroup())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"AmenityGroup\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeAmenitiesExcludeJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "AmenityGroup", 0, 12, false) == 0)
                  {
                    if (field_name.Length == 12)
                      {
                        return fieldGeneratorAmenityGroup;
                      }
                    switch (field_name[12])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 13, "ame", 0, 3, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorAmenityGroupName;
                            break;
                        case 'S':
                            if (String.Compare(field_name, 13, "pokenName", 0, 9, false) == 0)
                              {
                                switch (field_name[22])
                                  {
                                    case 'P':
                                        if ((String.Compare(field_name, 23, "lural", 0, 5, false) == 0) && (field_name.Length == 28))
                                            return fieldGeneratorAmenityGroupSpokenNamePlural;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 23, "ingular", 0, 7, false) == 0) && (field_name.Length == 30))
                                            return fieldGeneratorAmenityGroupSpokenNameSingular;
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
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorAmenityGroupName = new JSONHoldingStringGenerator("field \"AmenityGroupName\" of the TypeAmenitiesExclude class");
                fieldGeneratorAmenityGroupSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNameSingular\" of the TypeAmenitiesExclude class");
                fieldGeneratorAmenityGroupSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNamePlural\" of the TypeAmenitiesExclude class");
                fieldGeneratorAmenityGroup = new TypeAmenityGroupJSON.HoldingArrayGenerator("field \"AmenityGroup\" of the TypeAmenitiesExclude class", ignore_extras);
                set_what("the TypeAmenitiesExclude class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorAmenityGroupName = new JSONHoldingStringGenerator("field \"AmenityGroupName\" of the TypeAmenitiesExclude class");
                fieldGeneratorAmenityGroupSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNameSingular\" of the TypeAmenitiesExclude class");
                fieldGeneratorAmenityGroupSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNamePlural\" of the TypeAmenitiesExclude class");
                fieldGeneratorAmenityGroup = new TypeAmenityGroupJSON.HoldingArrayGenerator("field \"AmenityGroup\" of the TypeAmenitiesExclude class", false);
                set_what("the TypeAmenitiesExclude class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorAmenityGroupName.reset();
                fieldGeneratorAmenityGroupSpokenNameSingular.reset();
                fieldGeneratorAmenityGroupSpokenNamePlural.reset();
                fieldGeneratorAmenityGroup.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorAmenityGroup.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorAmenityGroup.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeAmenitiesExcludeJSON  result)
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
            public TypeAmenitiesExcludeJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAmenitiesExcludeJSON  result)
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
        protected virtual void handle_result(List<TypeAmenitiesExcludeJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAmenitiesExcludeJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAmenitiesExcludeJSON>();
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
        public List<TypeAmenitiesExcludeJSON> value;
      };
      };
    private bool flagHasQueryType;
    private TypeQueryType storeQueryType;
    private bool flagHasResultCount;
    private sbyte storeResultCount;
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private bool flagHasRadius;
    private double storeRadius;
    private string textStoreRadius;
    private bool flagHasRadiusUnit;
    private TypeRadiusUnit storeRadiusUnit;
    private bool flagHasRadiusInferred;
    private bool storeRadiusInferred;
    private bool flagHasAveragePrice;
    private MoneyJSON  storeAveragePrice;
    private bool flagHasMinimumPrice;
    private MoneyJSON  storeMinimumPrice;
    private bool flagHasMaximumPrice;
    private MoneyJSON  storeMaximumPrice;
    private bool flagHasPriceIsTotal;
    private bool storePriceIsTotal;
    private bool flagHasStartDateAndTimeInput;
    private DateAndOrTimeJSON  storeStartDateAndTimeInput;
    private bool flagHasEndDateAndTimeInput;
    private DateAndOrTimeJSON  storeEndDateAndTimeInput;
    private bool flagHasStartDateAndTimeInferred;
    private bool storeStartDateAndTimeInferred;
    private bool flagHasEndDateAndTimeInferred;
    private bool storeEndDateAndTimeInferred;
    private bool flagHasStartDateAndTimeFinal;
    private DateAndOrTimeJSON  storeStartDateAndTimeFinal;
    private bool flagHasStartDatePrintedForm;
    private string storeStartDatePrintedForm;
    private bool flagHasStartDateSpokenForm;
    private string storeStartDateSpokenForm;
    private bool flagHasEndDateAndTimeFinal;
    private DateAndOrTimeJSON  storeEndDateAndTimeFinal;
    private bool flagHasEndDatePrintedForm;
    private string storeEndDatePrintedForm;
    private bool flagHasEndDateSpokenForm;
    private string storeEndDateSpokenForm;
    private bool flagHasDurationInDaysInput;
    private BigInteger storeDurationInDaysInput;
    private bool flagHasDurationInDaysFinal;
    private BigInteger storeDurationInDaysFinal;
    private bool flagHasSortCriteria;
    private List< TypeSortCriteria > storeSortCriteria;
    private bool flagHasSortOrder;
    private List< TypeSortOrder > storeSortOrder;
    private bool flagHasAvailableOnly;
    private bool storeAvailableOnly;
    private bool flagHasExpensiveFlag;
    private bool storeExpensiveFlag;
    private bool flagHasInexpensiveFlag;
    private bool storeInexpensiveFlag;
    private bool flagHasSpecificHotelQuestion;
    private bool storeSpecificHotelQuestion;
    private bool flagHasConversationMode;
    private bool storeConversationMode;
    private bool flagHasGuestRatingMin;
    private double storeGuestRatingMin;
    private string textStoreGuestRatingMin;
    private bool flagHasGuestRatingMax;
    private double storeGuestRatingMax;
    private string textStoreGuestRatingMax;
    private bool flagHasStarRatingMin;
    private double storeStarRatingMin;
    private string textStoreStarRatingMin;
    private bool flagHasStarRatingMax;
    private double storeStarRatingMax;
    private string textStoreStarRatingMax;
    private bool flagHasStarRatingsInclude;
    private List< Double > storeStarRatingsInclude;
    private bool flagHasStarRatingsExclude;
    private List< Double > storeStarRatingsExclude;
    private bool flagHasRoomCount;
    private sbyte storeRoomCount;
    private bool flagHasAdultCount;
    private List< sbyte > storeAdultCount;
    private bool flagHasChildrenCount;
    private List< sbyte > storeChildrenCount;
    private bool flagHasGuestCountIsPerRoom;
    private bool storeGuestCountIsPerRoom;
    private bool flagHasFranchiseNamesInclude;
    private List< string > storeFranchiseNamesInclude;
    private bool flagHasFranchiseNamesExclude;
    private List< string > storeFranchiseNamesExclude;
    private bool flagHasHotelsInclude;
    private List< BigInteger > storeHotelsInclude;
    private bool flagHasHotelsExclude;
    private List< BigInteger > storeHotelsExclude;
    private bool flagHasAccommodationTypesInclude;
    private List< TypeAccommodationTypesInclude > storeAccommodationTypesInclude;
    private bool flagHasAccommodationTypesExclude;
    private List< TypeAccommodationTypesExclude > storeAccommodationTypesExclude;
    private bool flagHasAmenitiesInclude;
    private List< TypeAmenitiesIncludeJSON  > storeAmenitiesInclude;
    private bool flagHasAmenitiesExclude;
    private List< TypeAmenitiesExcludeJSON  > storeAmenitiesExclude;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryType of HotelFilterSpecJSON is not a string.");
        TypeQueryType the_enum;
        switch (json_string.getData()[0])
          {
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "otelQuestion", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeQueryType.QueryType_HotelQuestion;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "eservation", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeQueryType.QueryType_Reservation;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "earch", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeQueryType.QueryType_Search;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field QueryType of HotelFilterSpecJSON is not one of the legal strings.");
      enum_is_done:;
        setQueryType(the_enum);
      }


    private void  fromJSONResultCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ResultCount of HotelFilterSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ResultCount of HotelFilterSpecJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setResultCount(extracted_integer);
      }


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setMapLocation(convert_classy);
      }


    private void  fromJSONRadius(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Radius of HotelFilterSpecJSON is not a number.");
              }
          }
        setRadiusText(the_rational_text);
      }


    private void  fromJSONRadiusUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RadiusUnit of HotelFilterSpecJSON is not a string.");
        TypeRadiusUnit the_enum;
        switch (json_string.getData()[0])
          {
            case 'K':
                if ((String.Compare(json_string.getData(), 1, "ilometers", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeRadiusUnit.RadiusUnit_Kilometers;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "iles", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeRadiusUnit.RadiusUnit_Miles;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field RadiusUnit of HotelFilterSpecJSON is not one of the legal strings.");
      enum_is_done:;
        setRadiusUnit(the_enum);
      }


    private void  fromJSONRadiusInferred(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RadiusInferred of HotelFilterSpecJSON is not true for false.");
              }
          }
        setRadiusInferred(the_bool);
      }


    private void  fromJSONAveragePrice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setAveragePrice(convert_classy);
      }


    private void  fromJSONMinimumPrice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setMinimumPrice(convert_classy);
      }


    private void  fromJSONMaximumPrice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setMaximumPrice(convert_classy);
      }


    private void  fromJSONPriceIsTotal(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PriceIsTotal of HotelFilterSpecJSON is not true for false.");
              }
          }
        setPriceIsTotal(the_bool);
      }


    private void  fromJSONStartDateAndTimeInput(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartDateAndTimeInput(convert_classy);
      }


    private void  fromJSONEndDateAndTimeInput(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndDateAndTimeInput(convert_classy);
      }


    private void  fromJSONStartDateAndTimeInferred(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StartDateAndTimeInferred of HotelFilterSpecJSON is not true for false.");
              }
          }
        setStartDateAndTimeInferred(the_bool);
      }


    private void  fromJSONEndDateAndTimeInferred(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EndDateAndTimeInferred of HotelFilterSpecJSON is not true for false.");
              }
          }
        setEndDateAndTimeInferred(the_bool);
      }


    private void  fromJSONStartDateAndTimeFinal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartDateAndTimeFinal(convert_classy);
      }


    private void  fromJSONStartDatePrintedForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StartDatePrintedForm of HotelFilterSpecJSON is not a string.");
        setStartDatePrintedForm(json_string.getData());
      }


    private void  fromJSONStartDateSpokenForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StartDateSpokenForm of HotelFilterSpecJSON is not a string.");
        setStartDateSpokenForm(json_string.getData());
      }


    private void  fromJSONEndDateAndTimeFinal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndDateAndTimeFinal(convert_classy);
      }


    private void  fromJSONEndDatePrintedForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EndDatePrintedForm of HotelFilterSpecJSON is not a string.");
        setEndDatePrintedForm(json_string.getData());
      }


    private void  fromJSONEndDateSpokenForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EndDateSpokenForm of HotelFilterSpecJSON is not a string.");
        setEndDateSpokenForm(json_string.getData());
      }


    private void  fromJSONDurationInDaysInput(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DurationInDaysInput of HotelFilterSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DurationInDaysInput of HotelFilterSpecJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDurationInDaysInput(extracted_integer);
      }


    private void  fromJSONDurationInDaysFinal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DurationInDaysFinal of HotelFilterSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DurationInDaysFinal of HotelFilterSpecJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDurationInDaysFinal(extracted_integer);
      }


    private void  fromJSONSortCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SortCriteria of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeSortCriteria > vector_SortCriteria1 = new List< TypeSortCriteria >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SortCriteria of HotelFilterSpecJSON is not a string.");
            TypeSortCriteria the_enum;
            switch (json_string.getData()[0])
              {
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "istance", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeSortCriteria.SortCriteria_Distance;
                            goto enum_is_done;
                          }
                    break;
                case 'G':
                    if ((String.Compare(json_string.getData(), 1, "uestRating", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                          {
                            the_enum = TypeSortCriteria.SortCriteria_GuestRating;
                            goto enum_is_done;
                          }
                    break;
                case 'P':
                    if ((String.Compare(json_string.getData(), 1, "rice", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeSortCriteria.SortCriteria_Price;
                            goto enum_is_done;
                          }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "tarRating", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                          {
                            the_enum = TypeSortCriteria.SortCriteria_StarRating;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field SortCriteria of HotelFilterSpecJSON is not one of the legal strings.");
          enum_is_done:;
            vector_SortCriteria1.Add(the_enum);
          }
        initSortCriteria();
        for (int num3 = 0; num3 < vector_SortCriteria1.Count; ++num3)
            appendSortCriteria(vector_SortCriteria1[num3]);
        for (int num1 = 0; num1 < vector_SortCriteria1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSortOrder(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SortOrder of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeSortOrder > vector_SortOrder1 = new List< TypeSortOrder >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SortOrder of HotelFilterSpecJSON is not a string.");
            TypeSortOrder the_enum;
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "scending", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_enum = TypeSortOrder.SortOrder_Ascending;
                            goto enum_is_done;
                          }
                    break;
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "escending", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                          {
                            the_enum = TypeSortOrder.SortOrder_Descending;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field SortOrder of HotelFilterSpecJSON is not one of the legal strings.");
          enum_is_done:;
            vector_SortOrder1.Add(the_enum);
          }
        initSortOrder();
        for (int num4 = 0; num4 < vector_SortOrder1.Count; ++num4)
            appendSortOrder(vector_SortOrder1[num4]);
        for (int num1 = 0; num1 < vector_SortOrder1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAvailableOnly(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AvailableOnly of HotelFilterSpecJSON is not true for false.");
              }
          }
        setAvailableOnly(the_bool);
      }


    private void  fromJSONExpensiveFlag(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ExpensiveFlag of HotelFilterSpecJSON is not true for false.");
              }
          }
        setExpensiveFlag(the_bool);
      }


    private void  fromJSONInexpensiveFlag(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field InexpensiveFlag of HotelFilterSpecJSON is not true for false.");
              }
          }
        setInexpensiveFlag(the_bool);
      }


    private void  fromJSONSpecificHotelQuestion(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SpecificHotelQuestion of HotelFilterSpecJSON is not true for false.");
              }
          }
        setSpecificHotelQuestion(the_bool);
      }


    private void  fromJSONConversationMode(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ConversationMode of HotelFilterSpecJSON is not true for false.");
              }
          }
        setConversationMode(the_bool);
      }


    private void  fromJSONGuestRatingMin(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GuestRatingMin of HotelFilterSpecJSON is not a number.");
              }
          }
        setGuestRatingMinText(the_rational_text);
      }


    private void  fromJSONGuestRatingMax(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GuestRatingMax of HotelFilterSpecJSON is not a number.");
              }
          }
        setGuestRatingMaxText(the_rational_text);
      }


    private void  fromJSONStarRatingMin(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StarRatingMin of HotelFilterSpecJSON is not a number.");
              }
          }
        setStarRatingMinText(the_rational_text);
      }


    private void  fromJSONStarRatingMax(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StarRatingMax of HotelFilterSpecJSON is not a number.");
              }
          }
        setStarRatingMaxText(the_rational_text);
      }


    private void  fromJSONStarRatingsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StarRatingsInclude of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_StarRatingsInclude1 = new List< Double >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONRationalValue json_rational = json_array1.component(num1).rational_value();
            double the_double;
            if (json_rational != null)
              {
                the_double = json_rational.getDouble();
              }
            else
              {
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer != null)
                  {
                    the_double = json_integer.getLongInt();
                  }
                else
                  {
                    throw new Exception("The value for an element of field StarRatingsInclude of HotelFilterSpecJSON is not a number.");
                  }
              }
            vector_StarRatingsInclude1.Add(the_double);
          }
        initStarRatingsInclude();
        for (int num5 = 0; num5 < vector_StarRatingsInclude1.Count; ++num5)
            appendStarRatingsInclude(vector_StarRatingsInclude1[num5]);
        for (int num1 = 0; num1 < vector_StarRatingsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONStarRatingsExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StarRatingsExclude of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_StarRatingsExclude1 = new List< Double >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONRationalValue json_rational = json_array1.component(num1).rational_value();
            double the_double;
            if (json_rational != null)
              {
                the_double = json_rational.getDouble();
              }
            else
              {
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer != null)
                  {
                    the_double = json_integer.getLongInt();
                  }
                else
                  {
                    throw new Exception("The value for an element of field StarRatingsExclude of HotelFilterSpecJSON is not a number.");
                  }
              }
            vector_StarRatingsExclude1.Add(the_double);
          }
        initStarRatingsExclude();
        for (int num6 = 0; num6 < vector_StarRatingsExclude1.Count; ++num6)
            appendStarRatingsExclude(vector_StarRatingsExclude1[num6]);
        for (int num1 = 0; num1 < vector_StarRatingsExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRoomCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RoomCount of HotelFilterSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RoomCount of HotelFilterSpecJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setRoomCount(extracted_integer);
      }


    private void  fromJSONAdultCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AdultCount of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< sbyte > vector_AdultCount1 = new List< sbyte >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field AdultCount of HotelFilterSpecJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field AdultCount of HotelFilterSpecJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            vector_AdultCount1.Add(extracted_integer);
          }
        initAdultCount();
        for (int num7 = 0; num7 < vector_AdultCount1.Count; ++num7)
            appendAdultCount(vector_AdultCount1[num7]);
        for (int num1 = 0; num1 < vector_AdultCount1.Count; ++num1)
          {
          }
      }


    private void  fromJSONChildrenCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ChildrenCount of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< sbyte > vector_ChildrenCount1 = new List< sbyte >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field ChildrenCount of HotelFilterSpecJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field ChildrenCount of HotelFilterSpecJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            vector_ChildrenCount1.Add(extracted_integer);
          }
        initChildrenCount();
        for (int num8 = 0; num8 < vector_ChildrenCount1.Count; ++num8)
            appendChildrenCount(vector_ChildrenCount1[num8]);
        for (int num1 = 0; num1 < vector_ChildrenCount1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGuestCountIsPerRoom(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GuestCountIsPerRoom of HotelFilterSpecJSON is not true for false.");
              }
          }
        setGuestCountIsPerRoom(the_bool);
      }


    private void  fromJSONFranchiseNamesInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FranchiseNamesInclude of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_FranchiseNamesInclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field FranchiseNamesInclude of HotelFilterSpecJSON is not a string.");
            vector_FranchiseNamesInclude1.Add(json_string.getData());
          }
        initFranchiseNamesInclude();
        for (int num9 = 0; num9 < vector_FranchiseNamesInclude1.Count; ++num9)
            appendFranchiseNamesInclude(vector_FranchiseNamesInclude1[num9]);
        for (int num1 = 0; num1 < vector_FranchiseNamesInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONFranchiseNamesExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FranchiseNamesExclude of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_FranchiseNamesExclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field FranchiseNamesExclude of HotelFilterSpecJSON is not a string.");
            vector_FranchiseNamesExclude1.Add(json_string.getData());
          }
        initFranchiseNamesExclude();
        for (int num10 = 0; num10 < vector_FranchiseNamesExclude1.Count; ++num10)
            appendFranchiseNamesExclude(vector_FranchiseNamesExclude1[num10]);
        for (int num1 = 0; num1 < vector_FranchiseNamesExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONHotelsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HotelsInclude of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_HotelsInclude1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field HotelsInclude of HotelFilterSpecJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field HotelsInclude of HotelFilterSpecJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_HotelsInclude1.Add(extracted_integer);
          }
        initHotelsInclude();
        for (int num11 = 0; num11 < vector_HotelsInclude1.Count; ++num11)
            appendHotelsInclude(vector_HotelsInclude1[num11]);
        for (int num1 = 0; num1 < vector_HotelsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONHotelsExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HotelsExclude of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_HotelsExclude1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field HotelsExclude of HotelFilterSpecJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field HotelsExclude of HotelFilterSpecJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_HotelsExclude1.Add(extracted_integer);
          }
        initHotelsExclude();
        for (int num12 = 0; num12 < vector_HotelsExclude1.Count; ++num12)
            appendHotelsExclude(vector_HotelsExclude1[num12]);
        for (int num1 = 0; num1 < vector_HotelsExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAccommodationTypesInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AccommodationTypesInclude of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeAccommodationTypesInclude > vector_AccommodationTypesInclude1 = new List< TypeAccommodationTypesInclude >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field AccommodationTypesInclude of HotelFilterSpecJSON is not a string.");
            TypeAccommodationTypesInclude the_enum;
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "partment Hotel", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                          {
                            the_enum = TypeAccommodationTypesInclude.AccommodationTypesInclude_Apartment_x20_Hotel;
                            goto enum_is_done;
                          }
                    break;
                case 'B':
                    if ((String.Compare(json_string.getData(), 1, "ed And Breakfast", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                          {
                            the_enum = TypeAccommodationTypesInclude.AccommodationTypesInclude_Bed_x20_And_x20_Breakfast;
                            goto enum_is_done;
                          }
                    break;
                case 'M':
                    if ((String.Compare(json_string.getData(), 1, "otel", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeAccommodationTypesInclude.AccommodationTypesInclude_Motel;
                            goto enum_is_done;
                          }
                    break;
                case 'R':
                    if ((String.Compare(json_string.getData(), 1, "esort", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypeAccommodationTypesInclude.AccommodationTypesInclude_Resort;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field AccommodationTypesInclude of HotelFilterSpecJSON is not one of the legal strings.");
          enum_is_done:;
            vector_AccommodationTypesInclude1.Add(the_enum);
          }
        initAccommodationTypesInclude();
        for (int num13 = 0; num13 < vector_AccommodationTypesInclude1.Count; ++num13)
            appendAccommodationTypesInclude(vector_AccommodationTypesInclude1[num13]);
        for (int num1 = 0; num1 < vector_AccommodationTypesInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAccommodationTypesExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AccommodationTypesExclude of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeAccommodationTypesExclude > vector_AccommodationTypesExclude1 = new List< TypeAccommodationTypesExclude >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field AccommodationTypesExclude of HotelFilterSpecJSON is not a string.");
            TypeAccommodationTypesExclude the_enum;
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "partment Hotel", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                          {
                            the_enum = TypeAccommodationTypesExclude.AccommodationTypesExclude_Apartment_x20_Hotel;
                            goto enum_is_done;
                          }
                    break;
                case 'B':
                    if ((String.Compare(json_string.getData(), 1, "ed And Breakfast", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                          {
                            the_enum = TypeAccommodationTypesExclude.AccommodationTypesExclude_Bed_x20_And_x20_Breakfast;
                            goto enum_is_done;
                          }
                    break;
                case 'M':
                    if ((String.Compare(json_string.getData(), 1, "otel", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeAccommodationTypesExclude.AccommodationTypesExclude_Motel;
                            goto enum_is_done;
                          }
                    break;
                case 'R':
                    if ((String.Compare(json_string.getData(), 1, "esort", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypeAccommodationTypesExclude.AccommodationTypesExclude_Resort;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field AccommodationTypesExclude of HotelFilterSpecJSON is not one of the legal strings.");
          enum_is_done:;
            vector_AccommodationTypesExclude1.Add(the_enum);
          }
        initAccommodationTypesExclude();
        for (int num14 = 0; num14 < vector_AccommodationTypesExclude1.Count; ++num14)
            appendAccommodationTypesExclude(vector_AccommodationTypesExclude1[num14]);
        for (int num1 = 0; num1 < vector_AccommodationTypesExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesInclude of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeAmenitiesIncludeJSON  > vector_AmenitiesInclude1 = new List< TypeAmenitiesIncludeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeAmenitiesIncludeJSON convert_classy = TypeAmenitiesIncludeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenitiesInclude1.Add(convert_classy);
          }
        initAmenitiesInclude();
        for (int num15 = 0; num15 < vector_AmenitiesInclude1.Count; ++num15)
            appendAmenitiesInclude(vector_AmenitiesInclude1[num15]);
        for (int num1 = 0; num1 < vector_AmenitiesInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesExclude of HotelFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeAmenitiesExcludeJSON  > vector_AmenitiesExclude1 = new List< TypeAmenitiesExcludeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeAmenitiesExcludeJSON convert_classy = TypeAmenitiesExcludeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenitiesExclude1.Add(convert_classy);
          }
        initAmenitiesExclude();
        for (int num16 = 0; num16 < vector_AmenitiesExclude1.Count; ++num16)
            appendAmenitiesExclude(vector_AmenitiesExclude1[num16]);
        for (int num1 = 0; num1 < vector_AmenitiesExclude1.Count; ++num1)
          {
          }
      }


    public HotelFilterSpecJSON()
      {
        flagHasQueryType = false;
        flagHasResultCount = false;
        flagHasMapLocation = false;
        flagHasRadius = false;
        flagHasRadiusUnit = false;
        flagHasRadiusInferred = false;
        flagHasAveragePrice = false;
        flagHasMinimumPrice = false;
        flagHasMaximumPrice = false;
        flagHasPriceIsTotal = false;
        flagHasStartDateAndTimeInput = false;
        flagHasEndDateAndTimeInput = false;
        flagHasStartDateAndTimeInferred = false;
        flagHasEndDateAndTimeInferred = false;
        flagHasStartDateAndTimeFinal = false;
        flagHasStartDatePrintedForm = false;
        flagHasStartDateSpokenForm = false;
        flagHasEndDateAndTimeFinal = false;
        flagHasEndDatePrintedForm = false;
        flagHasEndDateSpokenForm = false;
        flagHasDurationInDaysInput = false;
        flagHasDurationInDaysFinal = false;
        flagHasSortCriteria = false;
        flagHasSortOrder = false;
        flagHasAvailableOnly = false;
        flagHasExpensiveFlag = false;
        flagHasInexpensiveFlag = false;
        flagHasSpecificHotelQuestion = false;
        flagHasConversationMode = false;
        flagHasGuestRatingMin = false;
        flagHasGuestRatingMax = false;
        flagHasStarRatingMin = false;
        flagHasStarRatingMax = false;
        flagHasStarRatingsInclude = false;
        flagHasStarRatingsExclude = false;
        flagHasRoomCount = false;
        flagHasAdultCount = false;
        flagHasChildrenCount = false;
        flagHasGuestCountIsPerRoom = false;
        flagHasFranchiseNamesInclude = false;
        flagHasFranchiseNamesExclude = false;
        flagHasHotelsInclude = false;
        flagHasHotelsExclude = false;
        flagHasAccommodationTypesInclude = false;
        flagHasAccommodationTypesExclude = false;
        flagHasAmenitiesInclude = false;
        flagHasAmenitiesExclude = false;
        storeSortCriteria = new List< TypeSortCriteria >();
        storeSortOrder = new List< TypeSortOrder >();
        storeStarRatingsInclude = new List< Double >();
        storeStarRatingsExclude = new List< Double >();
        storeAdultCount = new List< sbyte >();
        storeChildrenCount = new List< sbyte >();
        storeFranchiseNamesInclude = new List< string >();
        storeFranchiseNamesExclude = new List< string >();
        storeHotelsInclude = new List< BigInteger >();
        storeHotelsExclude = new List< BigInteger >();
        storeAccommodationTypesInclude = new List< TypeAccommodationTypesInclude >();
        storeAccommodationTypesExclude = new List< TypeAccommodationTypesExclude >();
        storeAmenitiesInclude = new List< TypeAmenitiesIncludeJSON  >();
        storeAmenitiesExclude = new List< TypeAmenitiesExcludeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQueryType()
      {
        return flagHasQueryType;
      }

    public TypeQueryType  getQueryType()
      {
        Debug.Assert(flagHasQueryType);
        return storeQueryType;
      }

    public string  getQueryTypeAsString()
      {
        return stringFromQueryType(getQueryType());
      }

    public bool  hasResultCount()
      {
        return flagHasResultCount;
      }

    public sbyte  getResultCount()
      {
        Debug.Assert(flagHasResultCount);
        return storeResultCount;
      }

    public bool  hasMapLocation()
      {
        return flagHasMapLocation;
      }

    public MapLocationJSON   getMapLocation()
      {
        Debug.Assert(flagHasMapLocation);
        return storeMapLocation;
      }

    public bool  hasRadius()
      {
        return flagHasRadius;
      }

    public double  getRadius()
      {
        Debug.Assert(flagHasRadius);
        if (textStoreRadius != "")
          {
            return Double.Parse(textStoreRadius);
          }
        return storeRadius;
      }

    public string  getRadiusAsText()
      {
        Debug.Assert(flagHasRadius);
        if (textStoreRadius == "")
          {
            return Convert.ToString(storeRadius);
          }
        else
          {
            return (textStoreRadius);
          }
      }

    public bool  hasRadiusUnit()
      {
        return flagHasRadiusUnit;
      }

    public TypeRadiusUnit  getRadiusUnit()
      {
        Debug.Assert(flagHasRadiusUnit);
        return storeRadiusUnit;
      }

    public string  getRadiusUnitAsString()
      {
        return stringFromRadiusUnit(getRadiusUnit());
      }

    public bool  hasRadiusInferred()
      {
        return flagHasRadiusInferred;
      }

    public bool  getRadiusInferred()
      {
        Debug.Assert(flagHasRadiusInferred);
        return storeRadiusInferred;
      }

    public bool  hasAveragePrice()
      {
        return flagHasAveragePrice;
      }

    public MoneyJSON   getAveragePrice()
      {
        Debug.Assert(flagHasAveragePrice);
        return storeAveragePrice;
      }

    public bool  hasMinimumPrice()
      {
        return flagHasMinimumPrice;
      }

    public MoneyJSON   getMinimumPrice()
      {
        Debug.Assert(flagHasMinimumPrice);
        return storeMinimumPrice;
      }

    public bool  hasMaximumPrice()
      {
        return flagHasMaximumPrice;
      }

    public MoneyJSON   getMaximumPrice()
      {
        Debug.Assert(flagHasMaximumPrice);
        return storeMaximumPrice;
      }

    public bool  hasPriceIsTotal()
      {
        return flagHasPriceIsTotal;
      }

    public bool  getPriceIsTotal()
      {
        Debug.Assert(flagHasPriceIsTotal);
        return storePriceIsTotal;
      }

    public bool  hasStartDateAndTimeInput()
      {
        return flagHasStartDateAndTimeInput;
      }

    public DateAndOrTimeJSON   getStartDateAndTimeInput()
      {
        Debug.Assert(flagHasStartDateAndTimeInput);
        return storeStartDateAndTimeInput;
      }

    public bool  hasEndDateAndTimeInput()
      {
        return flagHasEndDateAndTimeInput;
      }

    public DateAndOrTimeJSON   getEndDateAndTimeInput()
      {
        Debug.Assert(flagHasEndDateAndTimeInput);
        return storeEndDateAndTimeInput;
      }

    public bool  hasStartDateAndTimeInferred()
      {
        return flagHasStartDateAndTimeInferred;
      }

    public bool  getStartDateAndTimeInferred()
      {
        Debug.Assert(flagHasStartDateAndTimeInferred);
        return storeStartDateAndTimeInferred;
      }

    public bool  hasEndDateAndTimeInferred()
      {
        return flagHasEndDateAndTimeInferred;
      }

    public bool  getEndDateAndTimeInferred()
      {
        Debug.Assert(flagHasEndDateAndTimeInferred);
        return storeEndDateAndTimeInferred;
      }

    public bool  hasStartDateAndTimeFinal()
      {
        return flagHasStartDateAndTimeFinal;
      }

    public DateAndOrTimeJSON   getStartDateAndTimeFinal()
      {
        Debug.Assert(flagHasStartDateAndTimeFinal);
        return storeStartDateAndTimeFinal;
      }

    public bool  hasStartDatePrintedForm()
      {
        return flagHasStartDatePrintedForm;
      }

    public string  getStartDatePrintedForm()
      {
        Debug.Assert(flagHasStartDatePrintedForm);
        return storeStartDatePrintedForm;
      }

    public bool  hasStartDateSpokenForm()
      {
        return flagHasStartDateSpokenForm;
      }

    public string  getStartDateSpokenForm()
      {
        Debug.Assert(flagHasStartDateSpokenForm);
        return storeStartDateSpokenForm;
      }

    public bool  hasEndDateAndTimeFinal()
      {
        return flagHasEndDateAndTimeFinal;
      }

    public DateAndOrTimeJSON   getEndDateAndTimeFinal()
      {
        Debug.Assert(flagHasEndDateAndTimeFinal);
        return storeEndDateAndTimeFinal;
      }

    public bool  hasEndDatePrintedForm()
      {
        return flagHasEndDatePrintedForm;
      }

    public string  getEndDatePrintedForm()
      {
        Debug.Assert(flagHasEndDatePrintedForm);
        return storeEndDatePrintedForm;
      }

    public bool  hasEndDateSpokenForm()
      {
        return flagHasEndDateSpokenForm;
      }

    public string  getEndDateSpokenForm()
      {
        Debug.Assert(flagHasEndDateSpokenForm);
        return storeEndDateSpokenForm;
      }

    public bool  hasDurationInDaysInput()
      {
        return flagHasDurationInDaysInput;
      }

    public BigInteger  getDurationInDaysInput()
      {
        Debug.Assert(flagHasDurationInDaysInput);
        return storeDurationInDaysInput;
      }

    public bool  hasDurationInDaysFinal()
      {
        return flagHasDurationInDaysFinal;
      }

    public BigInteger  getDurationInDaysFinal()
      {
        Debug.Assert(flagHasDurationInDaysFinal);
        return storeDurationInDaysFinal;
      }

    public bool  hasSortCriteria()
      {
        return flagHasSortCriteria;
      }

    public int  countOfSortCriteria()
      {
        Debug.Assert(flagHasSortCriteria);
        return storeSortCriteria.Count;
      }

    public TypeSortCriteria  elementOfSortCriteria(int element_num)
      {
        Debug.Assert(flagHasSortCriteria);
        return storeSortCriteria[element_num];
      }

    public List< TypeSortCriteria >  getSortCriteria()
      {
        Debug.Assert(flagHasSortCriteria);
        return storeSortCriteria;
      }

    public bool  hasSortOrder()
      {
        return flagHasSortOrder;
      }

    public int  countOfSortOrder()
      {
        Debug.Assert(flagHasSortOrder);
        return storeSortOrder.Count;
      }

    public TypeSortOrder  elementOfSortOrder(int element_num)
      {
        Debug.Assert(flagHasSortOrder);
        return storeSortOrder[element_num];
      }

    public List< TypeSortOrder >  getSortOrder()
      {
        Debug.Assert(flagHasSortOrder);
        return storeSortOrder;
      }

    public bool  hasAvailableOnly()
      {
        return flagHasAvailableOnly;
      }

    public bool  getAvailableOnly()
      {
        Debug.Assert(flagHasAvailableOnly);
        return storeAvailableOnly;
      }

    public bool  hasExpensiveFlag()
      {
        return flagHasExpensiveFlag;
      }

    public bool  getExpensiveFlag()
      {
        Debug.Assert(flagHasExpensiveFlag);
        return storeExpensiveFlag;
      }

    public bool  hasInexpensiveFlag()
      {
        return flagHasInexpensiveFlag;
      }

    public bool  getInexpensiveFlag()
      {
        Debug.Assert(flagHasInexpensiveFlag);
        return storeInexpensiveFlag;
      }

    public bool  hasSpecificHotelQuestion()
      {
        return flagHasSpecificHotelQuestion;
      }

    public bool  getSpecificHotelQuestion()
      {
        Debug.Assert(flagHasSpecificHotelQuestion);
        return storeSpecificHotelQuestion;
      }

    public bool  hasConversationMode()
      {
        return flagHasConversationMode;
      }

    public bool  getConversationMode()
      {
        Debug.Assert(flagHasConversationMode);
        return storeConversationMode;
      }

    public bool  hasGuestRatingMin()
      {
        return flagHasGuestRatingMin;
      }

    public double  getGuestRatingMin()
      {
        Debug.Assert(flagHasGuestRatingMin);
        if (textStoreGuestRatingMin != "")
          {
            return Double.Parse(textStoreGuestRatingMin);
          }
        return storeGuestRatingMin;
      }

    public string  getGuestRatingMinAsText()
      {
        Debug.Assert(flagHasGuestRatingMin);
        if (textStoreGuestRatingMin == "")
          {
            return Convert.ToString(storeGuestRatingMin);
          }
        else
          {
            return (textStoreGuestRatingMin);
          }
      }

    public bool  hasGuestRatingMax()
      {
        return flagHasGuestRatingMax;
      }

    public double  getGuestRatingMax()
      {
        Debug.Assert(flagHasGuestRatingMax);
        if (textStoreGuestRatingMax != "")
          {
            return Double.Parse(textStoreGuestRatingMax);
          }
        return storeGuestRatingMax;
      }

    public string  getGuestRatingMaxAsText()
      {
        Debug.Assert(flagHasGuestRatingMax);
        if (textStoreGuestRatingMax == "")
          {
            return Convert.ToString(storeGuestRatingMax);
          }
        else
          {
            return (textStoreGuestRatingMax);
          }
      }

    public bool  hasStarRatingMin()
      {
        return flagHasStarRatingMin;
      }

    public double  getStarRatingMin()
      {
        Debug.Assert(flagHasStarRatingMin);
        if (textStoreStarRatingMin != "")
          {
            return Double.Parse(textStoreStarRatingMin);
          }
        return storeStarRatingMin;
      }

    public string  getStarRatingMinAsText()
      {
        Debug.Assert(flagHasStarRatingMin);
        if (textStoreStarRatingMin == "")
          {
            return Convert.ToString(storeStarRatingMin);
          }
        else
          {
            return (textStoreStarRatingMin);
          }
      }

    public bool  hasStarRatingMax()
      {
        return flagHasStarRatingMax;
      }

    public double  getStarRatingMax()
      {
        Debug.Assert(flagHasStarRatingMax);
        if (textStoreStarRatingMax != "")
          {
            return Double.Parse(textStoreStarRatingMax);
          }
        return storeStarRatingMax;
      }

    public string  getStarRatingMaxAsText()
      {
        Debug.Assert(flagHasStarRatingMax);
        if (textStoreStarRatingMax == "")
          {
            return Convert.ToString(storeStarRatingMax);
          }
        else
          {
            return (textStoreStarRatingMax);
          }
      }

    public bool  hasStarRatingsInclude()
      {
        return flagHasStarRatingsInclude;
      }

    public int  countOfStarRatingsInclude()
      {
        Debug.Assert(flagHasStarRatingsInclude);
        return storeStarRatingsInclude.Count;
      }

    public double  elementOfStarRatingsInclude(int element_num)
      {
        Debug.Assert(flagHasStarRatingsInclude);
        return storeStarRatingsInclude[element_num];
      }

    public List< Double >  getStarRatingsInclude()
      {
        Debug.Assert(flagHasStarRatingsInclude);
        return storeStarRatingsInclude;
      }

    public bool  hasStarRatingsExclude()
      {
        return flagHasStarRatingsExclude;
      }

    public int  countOfStarRatingsExclude()
      {
        Debug.Assert(flagHasStarRatingsExclude);
        return storeStarRatingsExclude.Count;
      }

    public double  elementOfStarRatingsExclude(int element_num)
      {
        Debug.Assert(flagHasStarRatingsExclude);
        return storeStarRatingsExclude[element_num];
      }

    public List< Double >  getStarRatingsExclude()
      {
        Debug.Assert(flagHasStarRatingsExclude);
        return storeStarRatingsExclude;
      }

    public bool  hasRoomCount()
      {
        return flagHasRoomCount;
      }

    public sbyte  getRoomCount()
      {
        Debug.Assert(flagHasRoomCount);
        return storeRoomCount;
      }

    public bool  hasAdultCount()
      {
        return flagHasAdultCount;
      }

    public int  countOfAdultCount()
      {
        Debug.Assert(flagHasAdultCount);
        return storeAdultCount.Count;
      }

    public sbyte  elementOfAdultCount(int element_num)
      {
        Debug.Assert(flagHasAdultCount);
        return storeAdultCount[element_num];
      }

    public List< sbyte >  getAdultCount()
      {
        Debug.Assert(flagHasAdultCount);
        return storeAdultCount;
      }

    public bool  hasChildrenCount()
      {
        return flagHasChildrenCount;
      }

    public int  countOfChildrenCount()
      {
        Debug.Assert(flagHasChildrenCount);
        return storeChildrenCount.Count;
      }

    public sbyte  elementOfChildrenCount(int element_num)
      {
        Debug.Assert(flagHasChildrenCount);
        return storeChildrenCount[element_num];
      }

    public List< sbyte >  getChildrenCount()
      {
        Debug.Assert(flagHasChildrenCount);
        return storeChildrenCount;
      }

    public bool  hasGuestCountIsPerRoom()
      {
        return flagHasGuestCountIsPerRoom;
      }

    public bool  getGuestCountIsPerRoom()
      {
        Debug.Assert(flagHasGuestCountIsPerRoom);
        return storeGuestCountIsPerRoom;
      }

    public bool  hasFranchiseNamesInclude()
      {
        return flagHasFranchiseNamesInclude;
      }

    public int  countOfFranchiseNamesInclude()
      {
        Debug.Assert(flagHasFranchiseNamesInclude);
        return storeFranchiseNamesInclude.Count;
      }

    public string  elementOfFranchiseNamesInclude(int element_num)
      {
        Debug.Assert(flagHasFranchiseNamesInclude);
        return storeFranchiseNamesInclude[element_num];
      }

    public List< string >  getFranchiseNamesInclude()
      {
        Debug.Assert(flagHasFranchiseNamesInclude);
        return storeFranchiseNamesInclude;
      }

    public bool  hasFranchiseNamesExclude()
      {
        return flagHasFranchiseNamesExclude;
      }

    public int  countOfFranchiseNamesExclude()
      {
        Debug.Assert(flagHasFranchiseNamesExclude);
        return storeFranchiseNamesExclude.Count;
      }

    public string  elementOfFranchiseNamesExclude(int element_num)
      {
        Debug.Assert(flagHasFranchiseNamesExclude);
        return storeFranchiseNamesExclude[element_num];
      }

    public List< string >  getFranchiseNamesExclude()
      {
        Debug.Assert(flagHasFranchiseNamesExclude);
        return storeFranchiseNamesExclude;
      }

    public bool  hasHotelsInclude()
      {
        return flagHasHotelsInclude;
      }

    public int  countOfHotelsInclude()
      {
        Debug.Assert(flagHasHotelsInclude);
        return storeHotelsInclude.Count;
      }

    public BigInteger  elementOfHotelsInclude(int element_num)
      {
        Debug.Assert(flagHasHotelsInclude);
        return storeHotelsInclude[element_num];
      }

    public List< BigInteger >  getHotelsInclude()
      {
        Debug.Assert(flagHasHotelsInclude);
        return storeHotelsInclude;
      }

    public bool  hasHotelsExclude()
      {
        return flagHasHotelsExclude;
      }

    public int  countOfHotelsExclude()
      {
        Debug.Assert(flagHasHotelsExclude);
        return storeHotelsExclude.Count;
      }

    public BigInteger  elementOfHotelsExclude(int element_num)
      {
        Debug.Assert(flagHasHotelsExclude);
        return storeHotelsExclude[element_num];
      }

    public List< BigInteger >  getHotelsExclude()
      {
        Debug.Assert(flagHasHotelsExclude);
        return storeHotelsExclude;
      }

    public bool  hasAccommodationTypesInclude()
      {
        return flagHasAccommodationTypesInclude;
      }

    public int  countOfAccommodationTypesInclude()
      {
        Debug.Assert(flagHasAccommodationTypesInclude);
        return storeAccommodationTypesInclude.Count;
      }

    public TypeAccommodationTypesInclude  elementOfAccommodationTypesInclude(int element_num)
      {
        Debug.Assert(flagHasAccommodationTypesInclude);
        return storeAccommodationTypesInclude[element_num];
      }

    public List< TypeAccommodationTypesInclude >  getAccommodationTypesInclude()
      {
        Debug.Assert(flagHasAccommodationTypesInclude);
        return storeAccommodationTypesInclude;
      }

    public bool  hasAccommodationTypesExclude()
      {
        return flagHasAccommodationTypesExclude;
      }

    public int  countOfAccommodationTypesExclude()
      {
        Debug.Assert(flagHasAccommodationTypesExclude);
        return storeAccommodationTypesExclude.Count;
      }

    public TypeAccommodationTypesExclude  elementOfAccommodationTypesExclude(int element_num)
      {
        Debug.Assert(flagHasAccommodationTypesExclude);
        return storeAccommodationTypesExclude[element_num];
      }

    public List< TypeAccommodationTypesExclude >  getAccommodationTypesExclude()
      {
        Debug.Assert(flagHasAccommodationTypesExclude);
        return storeAccommodationTypesExclude;
      }

    public bool  hasAmenitiesInclude()
      {
        return flagHasAmenitiesInclude;
      }

    public int  countOfAmenitiesInclude()
      {
        Debug.Assert(flagHasAmenitiesInclude);
        return storeAmenitiesInclude.Count;
      }

    public TypeAmenitiesIncludeJSON   elementOfAmenitiesInclude(int element_num)
      {
        Debug.Assert(flagHasAmenitiesInclude);
        return storeAmenitiesInclude[element_num];
      }

    public List< TypeAmenitiesIncludeJSON  >  getAmenitiesInclude()
      {
        Debug.Assert(flagHasAmenitiesInclude);
        return storeAmenitiesInclude;
      }

    public bool  hasAmenitiesExclude()
      {
        return flagHasAmenitiesExclude;
      }

    public int  countOfAmenitiesExclude()
      {
        Debug.Assert(flagHasAmenitiesExclude);
        return storeAmenitiesExclude.Count;
      }

    public TypeAmenitiesExcludeJSON   elementOfAmenitiesExclude(int element_num)
      {
        Debug.Assert(flagHasAmenitiesExclude);
        return storeAmenitiesExclude[element_num];
      }

    public List< TypeAmenitiesExcludeJSON  >  getAmenitiesExclude()
      {
        Debug.Assert(flagHasAmenitiesExclude);
        return storeAmenitiesExclude;
      }


    public virtual int extraHotelFilterSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHotelFilterSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHotelFilterSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHotelFilterSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQueryType(TypeQueryType new_value)
      {
        flagHasQueryType = true;
        storeQueryType = new_value;
      }
    public void setQueryType(string chars)
      {
        setQueryType(stringToQueryType(chars));
      }
    public void unsetQueryType()
      {
        flagHasQueryType = false;
      }
    public void setResultCount(sbyte new_value)
      {
        flagHasResultCount = true;
        if (new_value < 0)
            throw new Exception("The value for field ResultCount of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 30)
            throw new Exception("The value for field ResultCount of HotelFilterSpecJSON is greater than the upper bound (30) for that field.");
        storeResultCount = new_value;
      }
    public void unsetResultCount()
      {
        flagHasResultCount = false;
      }
    public void setMapLocation(MapLocationJSON  new_value)
      {
        if (flagHasMapLocation)
          {
          }
        flagHasMapLocation = true;
        storeMapLocation = new_value;
      }
    public void unsetMapLocation()
      {
        if (flagHasMapLocation)
          {
          }
        flagHasMapLocation = false;
      }
    public void setRadius(double new_value)
      {
        flagHasRadius = true;
        if (new_value < 0)
            throw new Exception("The value for field Radius of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        storeRadius = new_value;
        textStoreRadius = "";
      }
    public void setRadiusText(string new_value)
      {
        flagHasRadius = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Radius of HotelFilterSpecJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Radius of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        textStoreRadius = new_value;
      }
    public void unsetRadius()
      {
        flagHasRadius = false;
      }
    public void setRadiusUnit(TypeRadiusUnit new_value)
      {
        flagHasRadiusUnit = true;
        storeRadiusUnit = new_value;
      }
    public void setRadiusUnit(string chars)
      {
        setRadiusUnit(stringToRadiusUnit(chars));
      }
    public void unsetRadiusUnit()
      {
        flagHasRadiusUnit = false;
      }
    public void setRadiusInferred(bool new_value)
      {
        flagHasRadiusInferred = true;
        storeRadiusInferred = new_value;
      }
    public void unsetRadiusInferred()
      {
        flagHasRadiusInferred = false;
      }
    public void setAveragePrice(MoneyJSON  new_value)
      {
        if (flagHasAveragePrice)
          {
          }
        flagHasAveragePrice = true;
        storeAveragePrice = new_value;
      }
    public void unsetAveragePrice()
      {
        if (flagHasAveragePrice)
          {
          }
        flagHasAveragePrice = false;
      }
    public void setMinimumPrice(MoneyJSON  new_value)
      {
        if (flagHasMinimumPrice)
          {
          }
        flagHasMinimumPrice = true;
        storeMinimumPrice = new_value;
      }
    public void unsetMinimumPrice()
      {
        if (flagHasMinimumPrice)
          {
          }
        flagHasMinimumPrice = false;
      }
    public void setMaximumPrice(MoneyJSON  new_value)
      {
        if (flagHasMaximumPrice)
          {
          }
        flagHasMaximumPrice = true;
        storeMaximumPrice = new_value;
      }
    public void unsetMaximumPrice()
      {
        if (flagHasMaximumPrice)
          {
          }
        flagHasMaximumPrice = false;
      }
    public void setPriceIsTotal(bool new_value)
      {
        flagHasPriceIsTotal = true;
        storePriceIsTotal = new_value;
      }
    public void unsetPriceIsTotal()
      {
        flagHasPriceIsTotal = false;
      }
    public void setStartDateAndTimeInput(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartDateAndTimeInput)
          {
          }
        flagHasStartDateAndTimeInput = true;
        storeStartDateAndTimeInput = new_value;
      }
    public void unsetStartDateAndTimeInput()
      {
        if (flagHasStartDateAndTimeInput)
          {
          }
        flagHasStartDateAndTimeInput = false;
      }
    public void setEndDateAndTimeInput(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndDateAndTimeInput)
          {
          }
        flagHasEndDateAndTimeInput = true;
        storeEndDateAndTimeInput = new_value;
      }
    public void unsetEndDateAndTimeInput()
      {
        if (flagHasEndDateAndTimeInput)
          {
          }
        flagHasEndDateAndTimeInput = false;
      }
    public void setStartDateAndTimeInferred(bool new_value)
      {
        flagHasStartDateAndTimeInferred = true;
        storeStartDateAndTimeInferred = new_value;
      }
    public void unsetStartDateAndTimeInferred()
      {
        flagHasStartDateAndTimeInferred = false;
      }
    public void setEndDateAndTimeInferred(bool new_value)
      {
        flagHasEndDateAndTimeInferred = true;
        storeEndDateAndTimeInferred = new_value;
      }
    public void unsetEndDateAndTimeInferred()
      {
        flagHasEndDateAndTimeInferred = false;
      }
    public void setStartDateAndTimeFinal(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartDateAndTimeFinal)
          {
          }
        flagHasStartDateAndTimeFinal = true;
        storeStartDateAndTimeFinal = new_value;
      }
    public void unsetStartDateAndTimeFinal()
      {
        if (flagHasStartDateAndTimeFinal)
          {
          }
        flagHasStartDateAndTimeFinal = false;
      }
    public void setStartDatePrintedForm(string new_value)
      {
        flagHasStartDatePrintedForm = true;
        storeStartDatePrintedForm = new_value;
      }
    public void unsetStartDatePrintedForm()
      {
        flagHasStartDatePrintedForm = false;
      }
    public void setStartDateSpokenForm(string new_value)
      {
        flagHasStartDateSpokenForm = true;
        storeStartDateSpokenForm = new_value;
      }
    public void unsetStartDateSpokenForm()
      {
        flagHasStartDateSpokenForm = false;
      }
    public void setEndDateAndTimeFinal(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndDateAndTimeFinal)
          {
          }
        flagHasEndDateAndTimeFinal = true;
        storeEndDateAndTimeFinal = new_value;
      }
    public void unsetEndDateAndTimeFinal()
      {
        if (flagHasEndDateAndTimeFinal)
          {
          }
        flagHasEndDateAndTimeFinal = false;
      }
    public void setEndDatePrintedForm(string new_value)
      {
        flagHasEndDatePrintedForm = true;
        storeEndDatePrintedForm = new_value;
      }
    public void unsetEndDatePrintedForm()
      {
        flagHasEndDatePrintedForm = false;
      }
    public void setEndDateSpokenForm(string new_value)
      {
        flagHasEndDateSpokenForm = true;
        storeEndDateSpokenForm = new_value;
      }
    public void unsetEndDateSpokenForm()
      {
        flagHasEndDateSpokenForm = false;
      }
    public void setDurationInDaysInput(BigInteger new_value)
      {
        flagHasDurationInDaysInput = true;
        if (new_value < 0)
            throw new Exception("The value for field DurationInDaysInput of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        storeDurationInDaysInput = new_value;
      }
    public void unsetDurationInDaysInput()
      {
        flagHasDurationInDaysInput = false;
      }
    public void setDurationInDaysFinal(BigInteger new_value)
      {
        flagHasDurationInDaysFinal = true;
        if (new_value < 1)
            throw new Exception("The value for field DurationInDaysFinal of HotelFilterSpecJSON is less than the lower bound (1) for that field.");
        storeDurationInDaysFinal = new_value;
      }
    public void unsetDurationInDaysFinal()
      {
        flagHasDurationInDaysFinal = false;
      }
    public void initSortCriteria()
      {
        flagHasSortCriteria = true;
        storeSortCriteria.Clear();
      }
    public void appendSortCriteria(TypeSortCriteria to_append)
      {
        if (!flagHasSortCriteria)
          {
            flagHasSortCriteria = true;
            storeSortCriteria.Clear();
          }
        Debug.Assert(flagHasSortCriteria);
        storeSortCriteria.Add(to_append);
      }
    public void appendSortCriteria(string chars)
      {
        appendSortCriteria(stringToSortCriteria(chars));
      }
    public void unsetSortCriteria()
      {
        flagHasSortCriteria = false;
        storeSortCriteria.Clear();
      }
    public void initSortOrder()
      {
        flagHasSortOrder = true;
        storeSortOrder.Clear();
      }
    public void appendSortOrder(TypeSortOrder to_append)
      {
        if (!flagHasSortOrder)
          {
            flagHasSortOrder = true;
            storeSortOrder.Clear();
          }
        Debug.Assert(flagHasSortOrder);
        storeSortOrder.Add(to_append);
      }
    public void appendSortOrder(string chars)
      {
        appendSortOrder(stringToSortOrder(chars));
      }
    public void unsetSortOrder()
      {
        flagHasSortOrder = false;
        storeSortOrder.Clear();
      }
    public void setAvailableOnly(bool new_value)
      {
        flagHasAvailableOnly = true;
        storeAvailableOnly = new_value;
      }
    public void unsetAvailableOnly()
      {
        flagHasAvailableOnly = false;
      }
    public void setExpensiveFlag(bool new_value)
      {
        flagHasExpensiveFlag = true;
        storeExpensiveFlag = new_value;
      }
    public void unsetExpensiveFlag()
      {
        flagHasExpensiveFlag = false;
      }
    public void setInexpensiveFlag(bool new_value)
      {
        flagHasInexpensiveFlag = true;
        storeInexpensiveFlag = new_value;
      }
    public void unsetInexpensiveFlag()
      {
        flagHasInexpensiveFlag = false;
      }
    public void setSpecificHotelQuestion(bool new_value)
      {
        flagHasSpecificHotelQuestion = true;
        storeSpecificHotelQuestion = new_value;
      }
    public void unsetSpecificHotelQuestion()
      {
        flagHasSpecificHotelQuestion = false;
      }
    public void setConversationMode(bool new_value)
      {
        flagHasConversationMode = true;
        storeConversationMode = new_value;
      }
    public void unsetConversationMode()
      {
        flagHasConversationMode = false;
      }
    public void setGuestRatingMin(double new_value)
      {
        flagHasGuestRatingMin = true;
        if (new_value < 0)
            throw new Exception("The value for field GuestRatingMin of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 6)
            throw new Exception("The value for field GuestRatingMin of HotelFilterSpecJSON is greater than the upper bound (6) for that field.");
        storeGuestRatingMin = new_value;
        textStoreGuestRatingMin = "";
      }
    public void setGuestRatingMinText(string new_value)
      {
        flagHasGuestRatingMin = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field GuestRatingMin of HotelFilterSpecJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field GuestRatingMin of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "6", "", false, "1") > 0)
            throw new Exception("The value for field GuestRatingMin of HotelFilterSpecJSON is greater than the upper bound (6) for that field.");
        textStoreGuestRatingMin = new_value;
      }
    public void unsetGuestRatingMin()
      {
        flagHasGuestRatingMin = false;
      }
    public void setGuestRatingMax(double new_value)
      {
        flagHasGuestRatingMax = true;
        if (new_value < 0)
            throw new Exception("The value for field GuestRatingMax of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 6)
            throw new Exception("The value for field GuestRatingMax of HotelFilterSpecJSON is greater than the upper bound (6) for that field.");
        storeGuestRatingMax = new_value;
        textStoreGuestRatingMax = "";
      }
    public void setGuestRatingMaxText(string new_value)
      {
        flagHasGuestRatingMax = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field GuestRatingMax of HotelFilterSpecJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field GuestRatingMax of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "6", "", false, "1") > 0)
            throw new Exception("The value for field GuestRatingMax of HotelFilterSpecJSON is greater than the upper bound (6) for that field.");
        textStoreGuestRatingMax = new_value;
      }
    public void unsetGuestRatingMax()
      {
        flagHasGuestRatingMax = false;
      }
    public void setStarRatingMin(double new_value)
      {
        flagHasStarRatingMin = true;
        if (new_value < 0)
            throw new Exception("The value for field StarRatingMin of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 6)
            throw new Exception("The value for field StarRatingMin of HotelFilterSpecJSON is greater than the upper bound (6) for that field.");
        storeStarRatingMin = new_value;
        textStoreStarRatingMin = "";
      }
    public void setStarRatingMinText(string new_value)
      {
        flagHasStarRatingMin = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field StarRatingMin of HotelFilterSpecJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field StarRatingMin of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "6", "", false, "1") > 0)
            throw new Exception("The value for field StarRatingMin of HotelFilterSpecJSON is greater than the upper bound (6) for that field.");
        textStoreStarRatingMin = new_value;
      }
    public void unsetStarRatingMin()
      {
        flagHasStarRatingMin = false;
      }
    public void setStarRatingMax(double new_value)
      {
        flagHasStarRatingMax = true;
        if (new_value < 0)
            throw new Exception("The value for field StarRatingMax of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 6)
            throw new Exception("The value for field StarRatingMax of HotelFilterSpecJSON is greater than the upper bound (6) for that field.");
        storeStarRatingMax = new_value;
        textStoreStarRatingMax = "";
      }
    public void setStarRatingMaxText(string new_value)
      {
        flagHasStarRatingMax = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field StarRatingMax of HotelFilterSpecJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field StarRatingMax of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "6", "", false, "1") > 0)
            throw new Exception("The value for field StarRatingMax of HotelFilterSpecJSON is greater than the upper bound (6) for that field.");
        textStoreStarRatingMax = new_value;
      }
    public void unsetStarRatingMax()
      {
        flagHasStarRatingMax = false;
      }
    public void initStarRatingsInclude()
      {
        flagHasStarRatingsInclude = true;
        storeStarRatingsInclude.Clear();
      }
    public void appendStarRatingsInclude(double to_append)
      {
        if (!flagHasStarRatingsInclude)
          {
            flagHasStarRatingsInclude = true;
            storeStarRatingsInclude.Clear();
          }
        Debug.Assert(flagHasStarRatingsInclude);
        storeStarRatingsInclude.Add(to_append);
      }
    public void unsetStarRatingsInclude()
      {
        flagHasStarRatingsInclude = false;
        storeStarRatingsInclude.Clear();
      }
    public void initStarRatingsExclude()
      {
        flagHasStarRatingsExclude = true;
        storeStarRatingsExclude.Clear();
      }
    public void appendStarRatingsExclude(double to_append)
      {
        if (!flagHasStarRatingsExclude)
          {
            flagHasStarRatingsExclude = true;
            storeStarRatingsExclude.Clear();
          }
        Debug.Assert(flagHasStarRatingsExclude);
        storeStarRatingsExclude.Add(to_append);
      }
    public void unsetStarRatingsExclude()
      {
        flagHasStarRatingsExclude = false;
        storeStarRatingsExclude.Clear();
      }
    public void setRoomCount(sbyte new_value)
      {
        flagHasRoomCount = true;
        if (new_value < 0)
            throw new Exception("The value for field RoomCount of HotelFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 8)
            throw new Exception("The value for field RoomCount of HotelFilterSpecJSON is greater than the upper bound (8) for that field.");
        storeRoomCount = new_value;
      }
    public void unsetRoomCount()
      {
        flagHasRoomCount = false;
      }
    public void initAdultCount()
      {
        flagHasAdultCount = true;
        storeAdultCount.Clear();
      }
    public void appendAdultCount(sbyte to_append)
      {
        if (!flagHasAdultCount)
          {
            flagHasAdultCount = true;
            storeAdultCount.Clear();
          }
        Debug.Assert(flagHasAdultCount);
        storeAdultCount.Add(to_append);
      }
    public void unsetAdultCount()
      {
        flagHasAdultCount = false;
        storeAdultCount.Clear();
      }
    public void initChildrenCount()
      {
        flagHasChildrenCount = true;
        storeChildrenCount.Clear();
      }
    public void appendChildrenCount(sbyte to_append)
      {
        if (!flagHasChildrenCount)
          {
            flagHasChildrenCount = true;
            storeChildrenCount.Clear();
          }
        Debug.Assert(flagHasChildrenCount);
        storeChildrenCount.Add(to_append);
      }
    public void unsetChildrenCount()
      {
        flagHasChildrenCount = false;
        storeChildrenCount.Clear();
      }
    public void setGuestCountIsPerRoom(bool new_value)
      {
        flagHasGuestCountIsPerRoom = true;
        storeGuestCountIsPerRoom = new_value;
      }
    public void unsetGuestCountIsPerRoom()
      {
        flagHasGuestCountIsPerRoom = false;
      }
    public void initFranchiseNamesInclude()
      {
        flagHasFranchiseNamesInclude = true;
        storeFranchiseNamesInclude.Clear();
      }
    public void appendFranchiseNamesInclude(string to_append)
      {
        if (!flagHasFranchiseNamesInclude)
          {
            flagHasFranchiseNamesInclude = true;
            storeFranchiseNamesInclude.Clear();
          }
        Debug.Assert(flagHasFranchiseNamesInclude);
        storeFranchiseNamesInclude.Add(to_append);
      }
    public void unsetFranchiseNamesInclude()
      {
        flagHasFranchiseNamesInclude = false;
        storeFranchiseNamesInclude.Clear();
      }
    public void initFranchiseNamesExclude()
      {
        flagHasFranchiseNamesExclude = true;
        storeFranchiseNamesExclude.Clear();
      }
    public void appendFranchiseNamesExclude(string to_append)
      {
        if (!flagHasFranchiseNamesExclude)
          {
            flagHasFranchiseNamesExclude = true;
            storeFranchiseNamesExclude.Clear();
          }
        Debug.Assert(flagHasFranchiseNamesExclude);
        storeFranchiseNamesExclude.Add(to_append);
      }
    public void unsetFranchiseNamesExclude()
      {
        flagHasFranchiseNamesExclude = false;
        storeFranchiseNamesExclude.Clear();
      }
    public void initHotelsInclude()
      {
        flagHasHotelsInclude = true;
        storeHotelsInclude.Clear();
      }
    public void appendHotelsInclude(BigInteger to_append)
      {
        if (!flagHasHotelsInclude)
          {
            flagHasHotelsInclude = true;
            storeHotelsInclude.Clear();
          }
        Debug.Assert(flagHasHotelsInclude);
        storeHotelsInclude.Add(to_append);
      }
    public void unsetHotelsInclude()
      {
        flagHasHotelsInclude = false;
        storeHotelsInclude.Clear();
      }
    public void initHotelsExclude()
      {
        flagHasHotelsExclude = true;
        storeHotelsExclude.Clear();
      }
    public void appendHotelsExclude(BigInteger to_append)
      {
        if (!flagHasHotelsExclude)
          {
            flagHasHotelsExclude = true;
            storeHotelsExclude.Clear();
          }
        Debug.Assert(flagHasHotelsExclude);
        storeHotelsExclude.Add(to_append);
      }
    public void unsetHotelsExclude()
      {
        flagHasHotelsExclude = false;
        storeHotelsExclude.Clear();
      }
    public void initAccommodationTypesInclude()
      {
        flagHasAccommodationTypesInclude = true;
        storeAccommodationTypesInclude.Clear();
      }
    public void appendAccommodationTypesInclude(TypeAccommodationTypesInclude to_append)
      {
        if (!flagHasAccommodationTypesInclude)
          {
            flagHasAccommodationTypesInclude = true;
            storeAccommodationTypesInclude.Clear();
          }
        Debug.Assert(flagHasAccommodationTypesInclude);
        storeAccommodationTypesInclude.Add(to_append);
      }
    public void appendAccommodationTypesInclude(string chars)
      {
        appendAccommodationTypesInclude(stringToAccommodationTypesInclude(chars));
      }
    public void unsetAccommodationTypesInclude()
      {
        flagHasAccommodationTypesInclude = false;
        storeAccommodationTypesInclude.Clear();
      }
    public void initAccommodationTypesExclude()
      {
        flagHasAccommodationTypesExclude = true;
        storeAccommodationTypesExclude.Clear();
      }
    public void appendAccommodationTypesExclude(TypeAccommodationTypesExclude to_append)
      {
        if (!flagHasAccommodationTypesExclude)
          {
            flagHasAccommodationTypesExclude = true;
            storeAccommodationTypesExclude.Clear();
          }
        Debug.Assert(flagHasAccommodationTypesExclude);
        storeAccommodationTypesExclude.Add(to_append);
      }
    public void appendAccommodationTypesExclude(string chars)
      {
        appendAccommodationTypesExclude(stringToAccommodationTypesExclude(chars));
      }
    public void unsetAccommodationTypesExclude()
      {
        flagHasAccommodationTypesExclude = false;
        storeAccommodationTypesExclude.Clear();
      }
    public void initAmenitiesInclude()
      {
        if (flagHasAmenitiesInclude)
          {
            for (int num5 = 0; num5 < storeAmenitiesInclude.Count; ++num5)
              {
              }
          }
        flagHasAmenitiesInclude = true;
        storeAmenitiesInclude.Clear();
      }
    public void appendAmenitiesInclude(TypeAmenitiesIncludeJSON  to_append)
      {
        if (!flagHasAmenitiesInclude)
          {
            flagHasAmenitiesInclude = true;
            storeAmenitiesInclude.Clear();
          }
        Debug.Assert(flagHasAmenitiesInclude);
        storeAmenitiesInclude.Add(to_append);
      }
    public void unsetAmenitiesInclude()
      {
        if (flagHasAmenitiesInclude)
          {
            for (int num6 = 0; num6 < storeAmenitiesInclude.Count; ++num6)
              {
              }
          }
        flagHasAmenitiesInclude = false;
        storeAmenitiesInclude.Clear();
      }
    public void initAmenitiesExclude()
      {
        if (flagHasAmenitiesExclude)
          {
            for (int num7 = 0; num7 < storeAmenitiesExclude.Count; ++num7)
              {
              }
          }
        flagHasAmenitiesExclude = true;
        storeAmenitiesExclude.Clear();
      }
    public void appendAmenitiesExclude(TypeAmenitiesExcludeJSON  to_append)
      {
        if (!flagHasAmenitiesExclude)
          {
            flagHasAmenitiesExclude = true;
            storeAmenitiesExclude.Clear();
          }
        Debug.Assert(flagHasAmenitiesExclude);
        storeAmenitiesExclude.Add(to_append);
      }
    public void unsetAmenitiesExclude()
      {
        if (flagHasAmenitiesExclude)
          {
            for (int num8 = 0; num8 < storeAmenitiesExclude.Count; ++num8)
              {
              }
          }
        flagHasAmenitiesExclude = false;
        storeAmenitiesExclude.Clear();
      }

    public virtual void extraHotelFilterSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHotelFilterSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHotelFilterSpecLookup(key);
        if (old_field == null)
          {
            extraHotelFilterSpecAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryType);
        if (flagHasQueryType)
          {
            handler.start_pair("QueryType");
            switch (storeQueryType)
              {
                case TypeQueryType.QueryType_Search:
                    handler.string_value("Search");
                    break;
                case TypeQueryType.QueryType_Reservation:
                    handler.string_value("Reservation");
                    break;
                case TypeQueryType.QueryType_HotelQuestion:
                    handler.string_value("HotelQuestion");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasResultCount)
          {
            handler.start_pair("ResultCount");
            handler.number_value(storeResultCount);
          }
        if (flagHasMapLocation)
          {
            handler.start_pair("MapLocation");
            if (partial_allowed)
                storeMapLocation.write_partial_as_json(handler);
            else
                storeMapLocation.write_as_json(handler);
          }
        if (flagHasRadius)
          {
            handler.start_pair("Radius");
            if (textStoreRadius != "")
                handler.number_value(textStoreRadius);
            else if (((double)(long)storeRadius) == storeRadius)
                handler.number_value((long)storeRadius);
            else
                handler.number_value(storeRadius);
          }
        if (flagHasRadiusUnit)
          {
            handler.start_pair("RadiusUnit");
            switch (storeRadiusUnit)
              {
                case TypeRadiusUnit.RadiusUnit_Kilometers:
                    handler.string_value("Kilometers");
                    break;
                case TypeRadiusUnit.RadiusUnit_Miles:
                    handler.string_value("Miles");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasRadiusInferred)
          {
            handler.start_pair("RadiusInferred");
            handler.boolean_value(storeRadiusInferred);
          }
        if (flagHasAveragePrice)
          {
            handler.start_pair("AveragePrice");
            if (partial_allowed)
                storeAveragePrice.write_partial_as_json(handler);
            else
                storeAveragePrice.write_as_json(handler);
          }
        if (flagHasMinimumPrice)
          {
            handler.start_pair("MinimumPrice");
            if (partial_allowed)
                storeMinimumPrice.write_partial_as_json(handler);
            else
                storeMinimumPrice.write_as_json(handler);
          }
        if (flagHasMaximumPrice)
          {
            handler.start_pair("MaximumPrice");
            if (partial_allowed)
                storeMaximumPrice.write_partial_as_json(handler);
            else
                storeMaximumPrice.write_as_json(handler);
          }
        if (flagHasPriceIsTotal)
          {
            handler.start_pair("PriceIsTotal");
            handler.boolean_value(storePriceIsTotal);
          }
        if (flagHasStartDateAndTimeInput)
          {
            handler.start_pair("StartDateAndTimeInput");
            if (partial_allowed)
                storeStartDateAndTimeInput.write_partial_as_json(handler);
            else
                storeStartDateAndTimeInput.write_as_json(handler);
          }
        if (flagHasEndDateAndTimeInput)
          {
            handler.start_pair("EndDateAndTimeInput");
            if (partial_allowed)
                storeEndDateAndTimeInput.write_partial_as_json(handler);
            else
                storeEndDateAndTimeInput.write_as_json(handler);
          }
        if (flagHasStartDateAndTimeInferred)
          {
            handler.start_pair("StartDateAndTimeInferred");
            handler.boolean_value(storeStartDateAndTimeInferred);
          }
        if (flagHasEndDateAndTimeInferred)
          {
            handler.start_pair("EndDateAndTimeInferred");
            handler.boolean_value(storeEndDateAndTimeInferred);
          }
        if (flagHasStartDateAndTimeFinal)
          {
            handler.start_pair("StartDateAndTimeFinal");
            if (partial_allowed)
                storeStartDateAndTimeFinal.write_partial_as_json(handler);
            else
                storeStartDateAndTimeFinal.write_as_json(handler);
          }
        if (flagHasStartDatePrintedForm)
          {
            handler.start_pair("StartDatePrintedForm");
            handler.string_value(storeStartDatePrintedForm);
          }
        if (flagHasStartDateSpokenForm)
          {
            handler.start_pair("StartDateSpokenForm");
            handler.string_value(storeStartDateSpokenForm);
          }
        if (flagHasEndDateAndTimeFinal)
          {
            handler.start_pair("EndDateAndTimeFinal");
            if (partial_allowed)
                storeEndDateAndTimeFinal.write_partial_as_json(handler);
            else
                storeEndDateAndTimeFinal.write_as_json(handler);
          }
        if (flagHasEndDatePrintedForm)
          {
            handler.start_pair("EndDatePrintedForm");
            handler.string_value(storeEndDatePrintedForm);
          }
        if (flagHasEndDateSpokenForm)
          {
            handler.start_pair("EndDateSpokenForm");
            handler.string_value(storeEndDateSpokenForm);
          }
        if (flagHasDurationInDaysInput)
          {
            handler.start_pair("DurationInDaysInput");
            handler.number_value(storeDurationInDaysInput);
          }
        if (flagHasDurationInDaysFinal)
          {
            handler.start_pair("DurationInDaysFinal");
            handler.number_value(storeDurationInDaysFinal);
          }
        if (flagHasSortCriteria)
          {
            handler.start_pair("SortCriteria");
            handler.start_array();
            for (int num1 = 0; num1 < storeSortCriteria.Count; ++num1)
              {
                switch (storeSortCriteria[num1])
                  {
                    case TypeSortCriteria.SortCriteria_Distance:
                        handler.string_value("Distance");
                        break;
                    case TypeSortCriteria.SortCriteria_Price:
                        handler.string_value("Price");
                        break;
                    case TypeSortCriteria.SortCriteria_StarRating:
                        handler.string_value("StarRating");
                        break;
                    case TypeSortCriteria.SortCriteria_GuestRating:
                        handler.string_value("GuestRating");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            handler.finish_array();
          }
        if (flagHasSortOrder)
          {
            handler.start_pair("SortOrder");
            handler.start_array();
            for (int num2 = 0; num2 < storeSortOrder.Count; ++num2)
              {
                switch (storeSortOrder[num2])
                  {
                    case TypeSortOrder.SortOrder_Ascending:
                        handler.string_value("Ascending");
                        break;
                    case TypeSortOrder.SortOrder_Descending:
                        handler.string_value("Descending");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            handler.finish_array();
          }
        if (flagHasAvailableOnly)
          {
            handler.start_pair("AvailableOnly");
            handler.boolean_value(storeAvailableOnly);
          }
        if (flagHasExpensiveFlag)
          {
            handler.start_pair("ExpensiveFlag");
            handler.boolean_value(storeExpensiveFlag);
          }
        if (flagHasInexpensiveFlag)
          {
            handler.start_pair("InexpensiveFlag");
            handler.boolean_value(storeInexpensiveFlag);
          }
        if (flagHasSpecificHotelQuestion)
          {
            handler.start_pair("SpecificHotelQuestion");
            handler.boolean_value(storeSpecificHotelQuestion);
          }
        if (flagHasConversationMode)
          {
            handler.start_pair("ConversationMode");
            handler.boolean_value(storeConversationMode);
          }
        if (flagHasGuestRatingMin)
          {
            handler.start_pair("GuestRatingMin");
            if (textStoreGuestRatingMin != "")
                handler.number_value(textStoreGuestRatingMin);
            else if (((double)(long)storeGuestRatingMin) == storeGuestRatingMin)
                handler.number_value((long)storeGuestRatingMin);
            else
                handler.number_value(storeGuestRatingMin);
          }
        if (flagHasGuestRatingMax)
          {
            handler.start_pair("GuestRatingMax");
            if (textStoreGuestRatingMax != "")
                handler.number_value(textStoreGuestRatingMax);
            else if (((double)(long)storeGuestRatingMax) == storeGuestRatingMax)
                handler.number_value((long)storeGuestRatingMax);
            else
                handler.number_value(storeGuestRatingMax);
          }
        if (flagHasStarRatingMin)
          {
            handler.start_pair("StarRatingMin");
            if (textStoreStarRatingMin != "")
                handler.number_value(textStoreStarRatingMin);
            else if (((double)(long)storeStarRatingMin) == storeStarRatingMin)
                handler.number_value((long)storeStarRatingMin);
            else
                handler.number_value(storeStarRatingMin);
          }
        if (flagHasStarRatingMax)
          {
            handler.start_pair("StarRatingMax");
            if (textStoreStarRatingMax != "")
                handler.number_value(textStoreStarRatingMax);
            else if (((double)(long)storeStarRatingMax) == storeStarRatingMax)
                handler.number_value((long)storeStarRatingMax);
            else
                handler.number_value(storeStarRatingMax);
          }
        if (flagHasStarRatingsInclude)
          {
            handler.start_pair("StarRatingsInclude");
            handler.start_array();
            for (int num3 = 0; num3 < storeStarRatingsInclude.Count; ++num3)
              {
                if (((double)(long)storeStarRatingsInclude[num3]) == storeStarRatingsInclude[num3])
                    handler.number_value((long)storeStarRatingsInclude[num3]);
                else
                    handler.number_value(storeStarRatingsInclude[num3]);
              }
            handler.finish_array();
          }
        if (flagHasStarRatingsExclude)
          {
            handler.start_pair("StarRatingsExclude");
            handler.start_array();
            for (int num4 = 0; num4 < storeStarRatingsExclude.Count; ++num4)
              {
                if (((double)(long)storeStarRatingsExclude[num4]) == storeStarRatingsExclude[num4])
                    handler.number_value((long)storeStarRatingsExclude[num4]);
                else
                    handler.number_value(storeStarRatingsExclude[num4]);
              }
            handler.finish_array();
          }
        if (flagHasRoomCount)
          {
            handler.start_pair("RoomCount");
            handler.number_value(storeRoomCount);
          }
        if (flagHasAdultCount)
          {
            handler.start_pair("AdultCount");
            handler.start_array();
            for (int num5 = 0; num5 < storeAdultCount.Count; ++num5)
              {
                handler.number_value(storeAdultCount[num5]);
              }
            handler.finish_array();
          }
        if (flagHasChildrenCount)
          {
            handler.start_pair("ChildrenCount");
            handler.start_array();
            for (int num6 = 0; num6 < storeChildrenCount.Count; ++num6)
              {
                handler.number_value(storeChildrenCount[num6]);
              }
            handler.finish_array();
          }
        if (flagHasGuestCountIsPerRoom)
          {
            handler.start_pair("GuestCountIsPerRoom");
            handler.boolean_value(storeGuestCountIsPerRoom);
          }
        if (flagHasFranchiseNamesInclude)
          {
            handler.start_pair("FranchiseNamesInclude");
            handler.start_array();
            for (int num7 = 0; num7 < storeFranchiseNamesInclude.Count; ++num7)
              {
                handler.string_value(storeFranchiseNamesInclude[num7]);
              }
            handler.finish_array();
          }
        if (flagHasFranchiseNamesExclude)
          {
            handler.start_pair("FranchiseNamesExclude");
            handler.start_array();
            for (int num8 = 0; num8 < storeFranchiseNamesExclude.Count; ++num8)
              {
                handler.string_value(storeFranchiseNamesExclude[num8]);
              }
            handler.finish_array();
          }
        if (flagHasHotelsInclude)
          {
            handler.start_pair("HotelsInclude");
            handler.start_array();
            for (int num9 = 0; num9 < storeHotelsInclude.Count; ++num9)
              {
                handler.number_value(storeHotelsInclude[num9]);
              }
            handler.finish_array();
          }
        if (flagHasHotelsExclude)
          {
            handler.start_pair("HotelsExclude");
            handler.start_array();
            for (int num10 = 0; num10 < storeHotelsExclude.Count; ++num10)
              {
                handler.number_value(storeHotelsExclude[num10]);
              }
            handler.finish_array();
          }
        if (flagHasAccommodationTypesInclude)
          {
            handler.start_pair("AccommodationTypesInclude");
            handler.start_array();
            for (int num11 = 0; num11 < storeAccommodationTypesInclude.Count; ++num11)
              {
                switch (storeAccommodationTypesInclude[num11])
                  {
                    case TypeAccommodationTypesInclude.AccommodationTypesInclude_Motel:
                        handler.string_value("Motel");
                        break;
                    case TypeAccommodationTypesInclude.AccommodationTypesInclude_Resort:
                        handler.string_value("Resort");
                        break;
                    case TypeAccommodationTypesInclude.AccommodationTypesInclude_Bed_x20_And_x20_Breakfast:
                        handler.string_value("Bed And Breakfast");
                        break;
                    case TypeAccommodationTypesInclude.AccommodationTypesInclude_Apartment_x20_Hotel:
                        handler.string_value("Apartment Hotel");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            handler.finish_array();
          }
        if (flagHasAccommodationTypesExclude)
          {
            handler.start_pair("AccommodationTypesExclude");
            handler.start_array();
            for (int num12 = 0; num12 < storeAccommodationTypesExclude.Count; ++num12)
              {
                switch (storeAccommodationTypesExclude[num12])
                  {
                    case TypeAccommodationTypesExclude.AccommodationTypesExclude_Motel:
                        handler.string_value("Motel");
                        break;
                    case TypeAccommodationTypesExclude.AccommodationTypesExclude_Resort:
                        handler.string_value("Resort");
                        break;
                    case TypeAccommodationTypesExclude.AccommodationTypesExclude_Bed_x20_And_x20_Breakfast:
                        handler.string_value("Bed And Breakfast");
                        break;
                    case TypeAccommodationTypesExclude.AccommodationTypesExclude_Apartment_x20_Hotel:
                        handler.string_value("Apartment Hotel");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesInclude)
          {
            handler.start_pair("AmenitiesInclude");
            handler.start_array();
            for (int num13 = 0; num13 < storeAmenitiesInclude.Count; ++num13)
              {
                if (partial_allowed)
                    storeAmenitiesInclude[num13].write_partial_as_json(handler);
                else
                    storeAmenitiesInclude[num13].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesExclude)
          {
            handler.start_pair("AmenitiesExclude");
            handler.start_array();
            for (int num14 = 0; num14 < storeAmenitiesExclude.Count; ++num14)
              {
                if (partial_allowed)
                    storeAmenitiesExclude[num14].write_partial_as_json(handler);
                else
                    storeAmenitiesExclude[num14].write_as_json(handler);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasQueryType()))
          {
            return "When parsing the object for %what%, the \"QueryType\" field was missing.";
          }
        return null;
      }

    public static HotelFilterSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelFilterSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelFilterSpec", ignore_extras);
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
    public static HotelFilterSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HotelFilterSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelFilterSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelFilterSpec", ignore_extras);
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
    public static HotelFilterSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HotelFilterSpecJSON from_text(string text, bool ignore_extras)
      {
        HotelFilterSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelFilterSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HotelFilterSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HotelFilterSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HotelFilterSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelFilterSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorQueryType : JSONStringGenerator
          {
            protected FieldGeneratorQueryType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQueryType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToQueryType(result));
              }
            protected abstract void handle_result(TypeQueryType result);
          };
    private class FieldHoldingGeneratorQueryType : FieldGeneratorQueryType
  {
    protected override void handle_result(TypeQueryType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQueryType(String what)
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
    public TypeQueryType value;
  };
    private class FieldHoldingArrayGeneratorQueryType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQueryType
      {
        private FieldHoldingArrayGeneratorQueryType top;

        protected override void handle_result(TypeQueryType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQueryType init_top)
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
    protected virtual void handle_result(List<TypeQueryType> result)
      {
      }

    public FieldHoldingArrayGeneratorQueryType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQueryType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQueryType> value;
  };
        private FieldHoldingGeneratorQueryType fieldGeneratorQueryType;
    private class FieldHoldingGeneratorResultCount : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorResultCount(String what) : base(what, 0, 30)
              {
              }
          };
    private class FieldHoldingArrayGeneratorResultCount : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorResultCount(String what) : base(what, 0, 30)
              {
              }
          };
        private FieldHoldingGeneratorResultCount fieldGeneratorResultCount;
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
        private JSONHoldingNumberTextGenerator fieldGeneratorRadius;
    private abstract class FieldGeneratorRadiusUnit : JSONStringGenerator
          {
            protected FieldGeneratorRadiusUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorRadiusUnit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToRadiusUnit(result));
              }
            protected abstract void handle_result(TypeRadiusUnit result);
          };
    private class FieldHoldingGeneratorRadiusUnit : FieldGeneratorRadiusUnit
  {
    protected override void handle_result(TypeRadiusUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorRadiusUnit(String what)
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
    public TypeRadiusUnit value;
  };
    private class FieldHoldingArrayGeneratorRadiusUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorRadiusUnit
      {
        private FieldHoldingArrayGeneratorRadiusUnit top;

        protected override void handle_result(TypeRadiusUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorRadiusUnit init_top)
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
    protected virtual void handle_result(List<TypeRadiusUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorRadiusUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRadiusUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorRadiusUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRadiusUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeRadiusUnit> value;
  };
        private FieldHoldingGeneratorRadiusUnit fieldGeneratorRadiusUnit;
        private JSONHoldingBooleanGenerator fieldGeneratorRadiusInferred;
        private MoneyJSON.HoldingGenerator fieldGeneratorAveragePrice;
        private MoneyJSON.HoldingGenerator fieldGeneratorMinimumPrice;
        private MoneyJSON.HoldingGenerator fieldGeneratorMaximumPrice;
        private JSONHoldingBooleanGenerator fieldGeneratorPriceIsTotal;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDateAndTimeInput;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndDateAndTimeInput;
        private JSONHoldingBooleanGenerator fieldGeneratorStartDateAndTimeInferred;
        private JSONHoldingBooleanGenerator fieldGeneratorEndDateAndTimeInferred;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDateAndTimeFinal;
        private JSONHoldingStringGenerator fieldGeneratorStartDatePrintedForm;
        private JSONHoldingStringGenerator fieldGeneratorStartDateSpokenForm;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndDateAndTimeFinal;
        private JSONHoldingStringGenerator fieldGeneratorEndDatePrintedForm;
        private JSONHoldingStringGenerator fieldGeneratorEndDateSpokenForm;
    private class FieldHoldingGeneratorDurationInDaysInput : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDurationInDaysInput(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDurationInDaysInput : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDurationInDaysInput(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorDurationInDaysInput fieldGeneratorDurationInDaysInput;
    private class FieldHoldingGeneratorDurationInDaysFinal : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDurationInDaysFinal(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDurationInDaysFinal : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDurationInDaysFinal(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorDurationInDaysFinal fieldGeneratorDurationInDaysFinal;
    private abstract class FieldGeneratorSortCriteria : JSONStringGenerator
          {
            protected FieldGeneratorSortCriteria(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSortCriteria()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSortCriteria(result));
              }
            protected abstract void handle_result(TypeSortCriteria result);
          };
    private class FieldHoldingGeneratorSortCriteria : FieldGeneratorSortCriteria
  {
    protected override void handle_result(TypeSortCriteria result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSortCriteria(String what)
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
    public TypeSortCriteria value;
  };
    private class FieldHoldingArrayGeneratorSortCriteria : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSortCriteria
      {
        private FieldHoldingArrayGeneratorSortCriteria top;

        protected override void handle_result(TypeSortCriteria result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSortCriteria init_top)
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
    protected virtual void handle_result(List<TypeSortCriteria> result)
      {
      }

    public FieldHoldingArrayGeneratorSortCriteria(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSortCriteria>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSortCriteria()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSortCriteria>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSortCriteria> value;
  };
        private FieldHoldingArrayGeneratorSortCriteria fieldGeneratorSortCriteria;
    private abstract class FieldGeneratorSortOrder : JSONStringGenerator
          {
            protected FieldGeneratorSortOrder(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSortOrder()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSortOrder(result));
              }
            protected abstract void handle_result(TypeSortOrder result);
          };
    private class FieldHoldingGeneratorSortOrder : FieldGeneratorSortOrder
  {
    protected override void handle_result(TypeSortOrder result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSortOrder(String what)
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
    public TypeSortOrder value;
  };
    private class FieldHoldingArrayGeneratorSortOrder : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSortOrder
      {
        private FieldHoldingArrayGeneratorSortOrder top;

        protected override void handle_result(TypeSortOrder result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSortOrder init_top)
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
    protected virtual void handle_result(List<TypeSortOrder> result)
      {
      }

    public FieldHoldingArrayGeneratorSortOrder(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSortOrder>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSortOrder()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSortOrder>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSortOrder> value;
  };
        private FieldHoldingArrayGeneratorSortOrder fieldGeneratorSortOrder;
        private JSONHoldingBooleanGenerator fieldGeneratorAvailableOnly;
        private JSONHoldingBooleanGenerator fieldGeneratorExpensiveFlag;
        private JSONHoldingBooleanGenerator fieldGeneratorInexpensiveFlag;
        private JSONHoldingBooleanGenerator fieldGeneratorSpecificHotelQuestion;
        private JSONHoldingBooleanGenerator fieldGeneratorConversationMode;
        private JSONHoldingNumberTextGenerator fieldGeneratorGuestRatingMin;
        private JSONHoldingNumberTextGenerator fieldGeneratorGuestRatingMax;
        private JSONHoldingNumberTextGenerator fieldGeneratorStarRatingMin;
        private JSONHoldingNumberTextGenerator fieldGeneratorStarRatingMax;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorStarRatingsInclude;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorStarRatingsExclude;
    private class FieldHoldingGeneratorRoomCount : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorRoomCount(String what) : base(what, 0, 8)
              {
              }
          };
    private class FieldHoldingArrayGeneratorRoomCount : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorRoomCount(String what) : base(what, 0, 8)
              {
              }
          };
        private FieldHoldingGeneratorRoomCount fieldGeneratorRoomCount;
    private class FieldHoldingGeneratorAdultCount : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorAdultCount(String what) : base(what, 0, 14)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAdultCount : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAdultCount(String what) : base(what, 0, 14)
              {
              }
          };
        private FieldHoldingArrayGeneratorAdultCount fieldGeneratorAdultCount;
    private class FieldHoldingGeneratorChildrenCount : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorChildrenCount(String what) : base(what, 0, 14)
              {
              }
          };
    private class FieldHoldingArrayGeneratorChildrenCount : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorChildrenCount(String what) : base(what, 0, 14)
              {
              }
          };
        private FieldHoldingArrayGeneratorChildrenCount fieldGeneratorChildrenCount;
        private JSONHoldingBooleanGenerator fieldGeneratorGuestCountIsPerRoom;
        private JSONHoldingStringArrayGenerator fieldGeneratorFranchiseNamesInclude;
        private JSONHoldingStringArrayGenerator fieldGeneratorFranchiseNamesExclude;
    private class FieldHoldingGeneratorHotelsInclude : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorHotelsInclude(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorHotelsInclude : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorHotelsInclude(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorHotelsInclude fieldGeneratorHotelsInclude;
    private class FieldHoldingGeneratorHotelsExclude : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorHotelsExclude(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorHotelsExclude : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorHotelsExclude(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorHotelsExclude fieldGeneratorHotelsExclude;
    private abstract class FieldGeneratorAccommodationTypesInclude : JSONStringGenerator
          {
            protected FieldGeneratorAccommodationTypesInclude(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorAccommodationTypesInclude()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToAccommodationTypesInclude(result));
              }
            protected abstract void handle_result(TypeAccommodationTypesInclude result);
          };
    private class FieldHoldingGeneratorAccommodationTypesInclude : FieldGeneratorAccommodationTypesInclude
  {
    protected override void handle_result(TypeAccommodationTypesInclude result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorAccommodationTypesInclude(String what)
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
    public TypeAccommodationTypesInclude value;
  };
    private class FieldHoldingArrayGeneratorAccommodationTypesInclude : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAccommodationTypesInclude
      {
        private FieldHoldingArrayGeneratorAccommodationTypesInclude top;

        protected override void handle_result(TypeAccommodationTypesInclude result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAccommodationTypesInclude init_top)
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
    protected virtual void handle_result(List<TypeAccommodationTypesInclude> result)
      {
      }

    public FieldHoldingArrayGeneratorAccommodationTypesInclude(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAccommodationTypesInclude>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAccommodationTypesInclude()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAccommodationTypesInclude>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAccommodationTypesInclude> value;
  };
        private FieldHoldingArrayGeneratorAccommodationTypesInclude fieldGeneratorAccommodationTypesInclude;
    private abstract class FieldGeneratorAccommodationTypesExclude : JSONStringGenerator
          {
            protected FieldGeneratorAccommodationTypesExclude(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorAccommodationTypesExclude()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToAccommodationTypesExclude(result));
              }
            protected abstract void handle_result(TypeAccommodationTypesExclude result);
          };
    private class FieldHoldingGeneratorAccommodationTypesExclude : FieldGeneratorAccommodationTypesExclude
  {
    protected override void handle_result(TypeAccommodationTypesExclude result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorAccommodationTypesExclude(String what)
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
    public TypeAccommodationTypesExclude value;
  };
    private class FieldHoldingArrayGeneratorAccommodationTypesExclude : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAccommodationTypesExclude
      {
        private FieldHoldingArrayGeneratorAccommodationTypesExclude top;

        protected override void handle_result(TypeAccommodationTypesExclude result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAccommodationTypesExclude init_top)
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
    protected virtual void handle_result(List<TypeAccommodationTypesExclude> result)
      {
      }

    public FieldHoldingArrayGeneratorAccommodationTypesExclude(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAccommodationTypesExclude>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAccommodationTypesExclude()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAccommodationTypesExclude>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAccommodationTypesExclude> value;
  };
        private FieldHoldingArrayGeneratorAccommodationTypesExclude fieldGeneratorAccommodationTypesExclude;
        private TypeAmenitiesIncludeJSON.HoldingArrayGenerator fieldGeneratorAmenitiesInclude;
        private TypeAmenitiesExcludeJSON.HoldingArrayGenerator fieldGeneratorAmenitiesExclude;
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
            HotelFilterSpecJSON result = new HotelFilterSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHotelFilterSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HotelFilterSpecJSON result)
          {
            if (fieldGeneratorQueryType.have_value)
              {
                result.setQueryType(fieldGeneratorQueryType.value);
                fieldGeneratorQueryType.have_value = false;
              }
            else if ((!(result.hasQueryType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryType\" field was missing.");
              }
            if (fieldGeneratorResultCount.have_value)
              {
                result.setResultCount((sbyte)(fieldGeneratorResultCount.value));
                fieldGeneratorResultCount.have_value = false;
              }
            if (fieldGeneratorMapLocation.have_value)
              {
                result.setMapLocation(fieldGeneratorMapLocation.value);
                fieldGeneratorMapLocation.have_value = false;
              }
            if (fieldGeneratorRadius.have_value)
              {
                result.setRadiusText(fieldGeneratorRadius.value);
                fieldGeneratorRadius.have_value = false;
              }
            if (fieldGeneratorRadiusUnit.have_value)
              {
                result.setRadiusUnit(fieldGeneratorRadiusUnit.value);
                fieldGeneratorRadiusUnit.have_value = false;
              }
            if (fieldGeneratorRadiusInferred.have_value)
              {
                result.setRadiusInferred(fieldGeneratorRadiusInferred.value);
                fieldGeneratorRadiusInferred.have_value = false;
              }
            if (fieldGeneratorAveragePrice.have_value)
              {
                result.setAveragePrice(fieldGeneratorAveragePrice.value);
                fieldGeneratorAveragePrice.have_value = false;
              }
            if (fieldGeneratorMinimumPrice.have_value)
              {
                result.setMinimumPrice(fieldGeneratorMinimumPrice.value);
                fieldGeneratorMinimumPrice.have_value = false;
              }
            if (fieldGeneratorMaximumPrice.have_value)
              {
                result.setMaximumPrice(fieldGeneratorMaximumPrice.value);
                fieldGeneratorMaximumPrice.have_value = false;
              }
            if (fieldGeneratorPriceIsTotal.have_value)
              {
                result.setPriceIsTotal(fieldGeneratorPriceIsTotal.value);
                fieldGeneratorPriceIsTotal.have_value = false;
              }
            if (fieldGeneratorStartDateAndTimeInput.have_value)
              {
                result.setStartDateAndTimeInput(fieldGeneratorStartDateAndTimeInput.value);
                fieldGeneratorStartDateAndTimeInput.have_value = false;
              }
            if (fieldGeneratorEndDateAndTimeInput.have_value)
              {
                result.setEndDateAndTimeInput(fieldGeneratorEndDateAndTimeInput.value);
                fieldGeneratorEndDateAndTimeInput.have_value = false;
              }
            if (fieldGeneratorStartDateAndTimeInferred.have_value)
              {
                result.setStartDateAndTimeInferred(fieldGeneratorStartDateAndTimeInferred.value);
                fieldGeneratorStartDateAndTimeInferred.have_value = false;
              }
            if (fieldGeneratorEndDateAndTimeInferred.have_value)
              {
                result.setEndDateAndTimeInferred(fieldGeneratorEndDateAndTimeInferred.value);
                fieldGeneratorEndDateAndTimeInferred.have_value = false;
              }
            if (fieldGeneratorStartDateAndTimeFinal.have_value)
              {
                result.setStartDateAndTimeFinal(fieldGeneratorStartDateAndTimeFinal.value);
                fieldGeneratorStartDateAndTimeFinal.have_value = false;
              }
            if (fieldGeneratorStartDatePrintedForm.have_value)
              {
                result.setStartDatePrintedForm(fieldGeneratorStartDatePrintedForm.value);
                fieldGeneratorStartDatePrintedForm.have_value = false;
              }
            if (fieldGeneratorStartDateSpokenForm.have_value)
              {
                result.setStartDateSpokenForm(fieldGeneratorStartDateSpokenForm.value);
                fieldGeneratorStartDateSpokenForm.have_value = false;
              }
            if (fieldGeneratorEndDateAndTimeFinal.have_value)
              {
                result.setEndDateAndTimeFinal(fieldGeneratorEndDateAndTimeFinal.value);
                fieldGeneratorEndDateAndTimeFinal.have_value = false;
              }
            if (fieldGeneratorEndDatePrintedForm.have_value)
              {
                result.setEndDatePrintedForm(fieldGeneratorEndDatePrintedForm.value);
                fieldGeneratorEndDatePrintedForm.have_value = false;
              }
            if (fieldGeneratorEndDateSpokenForm.have_value)
              {
                result.setEndDateSpokenForm(fieldGeneratorEndDateSpokenForm.value);
                fieldGeneratorEndDateSpokenForm.have_value = false;
              }
            if (fieldGeneratorDurationInDaysInput.have_value)
              {
                result.setDurationInDaysInput(fieldGeneratorDurationInDaysInput.value);
                fieldGeneratorDurationInDaysInput.have_value = false;
              }
            if (fieldGeneratorDurationInDaysFinal.have_value)
              {
                result.setDurationInDaysFinal(fieldGeneratorDurationInDaysFinal.value);
                fieldGeneratorDurationInDaysFinal.have_value = false;
              }
            if (fieldGeneratorSortCriteria.have_value)
              {
                result.initSortCriteria();
                int count = fieldGeneratorSortCriteria.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSortCriteria(fieldGeneratorSortCriteria.value[num]);
                  }
                fieldGeneratorSortCriteria.value.Clear();
                fieldGeneratorSortCriteria.have_value = false;
              }
            if (fieldGeneratorSortOrder.have_value)
              {
                result.initSortOrder();
                int count = fieldGeneratorSortOrder.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSortOrder(fieldGeneratorSortOrder.value[num]);
                  }
                fieldGeneratorSortOrder.value.Clear();
                fieldGeneratorSortOrder.have_value = false;
              }
            if (fieldGeneratorAvailableOnly.have_value)
              {
                result.setAvailableOnly(fieldGeneratorAvailableOnly.value);
                fieldGeneratorAvailableOnly.have_value = false;
              }
            if (fieldGeneratorExpensiveFlag.have_value)
              {
                result.setExpensiveFlag(fieldGeneratorExpensiveFlag.value);
                fieldGeneratorExpensiveFlag.have_value = false;
              }
            if (fieldGeneratorInexpensiveFlag.have_value)
              {
                result.setInexpensiveFlag(fieldGeneratorInexpensiveFlag.value);
                fieldGeneratorInexpensiveFlag.have_value = false;
              }
            if (fieldGeneratorSpecificHotelQuestion.have_value)
              {
                result.setSpecificHotelQuestion(fieldGeneratorSpecificHotelQuestion.value);
                fieldGeneratorSpecificHotelQuestion.have_value = false;
              }
            if (fieldGeneratorConversationMode.have_value)
              {
                result.setConversationMode(fieldGeneratorConversationMode.value);
                fieldGeneratorConversationMode.have_value = false;
              }
            if (fieldGeneratorGuestRatingMin.have_value)
              {
                result.setGuestRatingMinText(fieldGeneratorGuestRatingMin.value);
                fieldGeneratorGuestRatingMin.have_value = false;
              }
            if (fieldGeneratorGuestRatingMax.have_value)
              {
                result.setGuestRatingMaxText(fieldGeneratorGuestRatingMax.value);
                fieldGeneratorGuestRatingMax.have_value = false;
              }
            if (fieldGeneratorStarRatingMin.have_value)
              {
                result.setStarRatingMinText(fieldGeneratorStarRatingMin.value);
                fieldGeneratorStarRatingMin.have_value = false;
              }
            if (fieldGeneratorStarRatingMax.have_value)
              {
                result.setStarRatingMaxText(fieldGeneratorStarRatingMax.value);
                fieldGeneratorStarRatingMax.have_value = false;
              }
            if (fieldGeneratorStarRatingsInclude.have_value)
              {
                result.initStarRatingsInclude();
                int count = fieldGeneratorStarRatingsInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStarRatingsInclude(Double.Parse(fieldGeneratorStarRatingsInclude.value[num]));
                  }
                fieldGeneratorStarRatingsInclude.value.Clear();
                fieldGeneratorStarRatingsInclude.have_value = false;
              }
            if (fieldGeneratorStarRatingsExclude.have_value)
              {
                result.initStarRatingsExclude();
                int count = fieldGeneratorStarRatingsExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStarRatingsExclude(Double.Parse(fieldGeneratorStarRatingsExclude.value[num]));
                  }
                fieldGeneratorStarRatingsExclude.value.Clear();
                fieldGeneratorStarRatingsExclude.have_value = false;
              }
            if (fieldGeneratorRoomCount.have_value)
              {
                result.setRoomCount((sbyte)(fieldGeneratorRoomCount.value));
                fieldGeneratorRoomCount.have_value = false;
              }
            if (fieldGeneratorAdultCount.have_value)
              {
                result.initAdultCount();
                int count = fieldGeneratorAdultCount.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAdultCount((sbyte)(fieldGeneratorAdultCount.value[num]));
                  }
                fieldGeneratorAdultCount.value.Clear();
                fieldGeneratorAdultCount.have_value = false;
              }
            if (fieldGeneratorChildrenCount.have_value)
              {
                result.initChildrenCount();
                int count = fieldGeneratorChildrenCount.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendChildrenCount((sbyte)(fieldGeneratorChildrenCount.value[num]));
                  }
                fieldGeneratorChildrenCount.value.Clear();
                fieldGeneratorChildrenCount.have_value = false;
              }
            if (fieldGeneratorGuestCountIsPerRoom.have_value)
              {
                result.setGuestCountIsPerRoom(fieldGeneratorGuestCountIsPerRoom.value);
                fieldGeneratorGuestCountIsPerRoom.have_value = false;
              }
            if (fieldGeneratorFranchiseNamesInclude.have_value)
              {
                result.initFranchiseNamesInclude();
                int count = fieldGeneratorFranchiseNamesInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFranchiseNamesInclude(fieldGeneratorFranchiseNamesInclude.value[num]);
                  }
                fieldGeneratorFranchiseNamesInclude.value.Clear();
                fieldGeneratorFranchiseNamesInclude.have_value = false;
              }
            if (fieldGeneratorFranchiseNamesExclude.have_value)
              {
                result.initFranchiseNamesExclude();
                int count = fieldGeneratorFranchiseNamesExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFranchiseNamesExclude(fieldGeneratorFranchiseNamesExclude.value[num]);
                  }
                fieldGeneratorFranchiseNamesExclude.value.Clear();
                fieldGeneratorFranchiseNamesExclude.have_value = false;
              }
            if (fieldGeneratorHotelsInclude.have_value)
              {
                result.initHotelsInclude();
                int count = fieldGeneratorHotelsInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHotelsInclude(fieldGeneratorHotelsInclude.value[num]);
                  }
                fieldGeneratorHotelsInclude.value.Clear();
                fieldGeneratorHotelsInclude.have_value = false;
              }
            if (fieldGeneratorHotelsExclude.have_value)
              {
                result.initHotelsExclude();
                int count = fieldGeneratorHotelsExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHotelsExclude(fieldGeneratorHotelsExclude.value[num]);
                  }
                fieldGeneratorHotelsExclude.value.Clear();
                fieldGeneratorHotelsExclude.have_value = false;
              }
            if (fieldGeneratorAccommodationTypesInclude.have_value)
              {
                result.initAccommodationTypesInclude();
                int count = fieldGeneratorAccommodationTypesInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAccommodationTypesInclude(fieldGeneratorAccommodationTypesInclude.value[num]);
                  }
                fieldGeneratorAccommodationTypesInclude.value.Clear();
                fieldGeneratorAccommodationTypesInclude.have_value = false;
              }
            if (fieldGeneratorAccommodationTypesExclude.have_value)
              {
                result.initAccommodationTypesExclude();
                int count = fieldGeneratorAccommodationTypesExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAccommodationTypesExclude(fieldGeneratorAccommodationTypesExclude.value[num]);
                  }
                fieldGeneratorAccommodationTypesExclude.value.Clear();
                fieldGeneratorAccommodationTypesExclude.have_value = false;
              }
            if (fieldGeneratorAmenitiesInclude.have_value)
              {
                result.initAmenitiesInclude();
                int count = fieldGeneratorAmenitiesInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmenitiesInclude(fieldGeneratorAmenitiesInclude.value[num]);
                  }
                fieldGeneratorAmenitiesInclude.value.Clear();
                fieldGeneratorAmenitiesInclude.have_value = false;
              }
            if (fieldGeneratorAmenitiesExclude.have_value)
              {
                result.initAmenitiesExclude();
                int count = fieldGeneratorAmenitiesExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmenitiesExclude(fieldGeneratorAmenitiesExclude.value[num]);
                  }
                fieldGeneratorAmenitiesExclude.value.Clear();
                fieldGeneratorAmenitiesExclude.have_value = false;
              }
          }
        protected abstract void handle_result(HotelFilterSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'c':
                            if (String.Compare(field_name, 2, "commodationTypes", 0, 16, false) == 0)
                              {
                                switch (field_name[18])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 19, "xclude", 0, 6, false) == 0) && (field_name.Length == 25))
                                            return fieldGeneratorAccommodationTypesExclude;
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 19, "nclude", 0, 6, false) == 0) && (field_name.Length == 25))
                                            return fieldGeneratorAccommodationTypesInclude;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'd':
                            if ((String.Compare(field_name, 2, "ultCount", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorAdultCount;
                            break;
                        case 'm':
                            if (String.Compare(field_name, 2, "enities", 0, 7, false) == 0)
                              {
                                switch (field_name[9])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 10, "xclude", 0, 6, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorAmenitiesExclude;
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 10, "nclude", 0, 6, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorAmenitiesInclude;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'v':
                            switch (field_name[2])
                              {
                                case 'a':
                                    if ((String.Compare(field_name, 3, "ilableOnly", 0, 10, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorAvailableOnly;
                                    break;
                                case 'e':
                                    if ((String.Compare(field_name, 3, "ragePrice", 0, 9, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorAveragePrice;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "ildrenCount", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorChildrenCount;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "nversationMode", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorConversationMode;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "urationInDays", 0, 13, false) == 0)
                      {
                        switch (field_name[14])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 15, "inal", 0, 4, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorDurationInDaysFinal;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 15, "nput", 0, 4, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorDurationInDaysInput;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if (String.Compare(field_name, 2, "dDate", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'A':
                                        if (String.Compare(field_name, 8, "ndTime", 0, 6, false) == 0)
                                          {
                                            switch (field_name[14])
                                              {
                                                case 'F':
                                                    if ((String.Compare(field_name, 15, "inal", 0, 4, false) == 0) && (field_name.Length == 19))
                                                        return fieldGeneratorEndDateAndTimeFinal;
                                                    break;
                                                case 'I':
                                                    if (String.Compare(field_name, 15, "n", 0, 1, false) == 0)
                                                      {
                                                        switch (field_name[16])
                                                          {
                                                            case 'f':
                                                                if ((String.Compare(field_name, 17, "erred", 0, 5, false) == 0) && (field_name.Length == 22))
                                                                    return fieldGeneratorEndDateAndTimeInferred;
                                                                break;
                                                            case 'p':
                                                                if ((String.Compare(field_name, 17, "ut", 0, 2, false) == 0) && (field_name.Length == 19))
                                                                    return fieldGeneratorEndDateAndTimeInput;
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
                                        if ((String.Compare(field_name, 8, "rintedForm", 0, 10, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorEndDatePrintedForm;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 8, "pokenForm", 0, 9, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorEndDateSpokenForm;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'x':
                            if ((String.Compare(field_name, 2, "pensiveFlag", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorExpensiveFlag;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "ranchiseNames", 0, 13, false) == 0)
                      {
                        switch (field_name[14])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 15, "xclude", 0, 6, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorFranchiseNamesExclude;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 15, "nclude", 0, 6, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorFranchiseNamesInclude;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'G':
                    if (String.Compare(field_name, 1, "uest", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 6, "ountIsPerRoom", 0, 13, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorGuestCountIsPerRoom;
                                break;
                            case 'R':
                                if (String.Compare(field_name, 6, "atingM", 0, 6, false) == 0)
                                  {
                                    switch (field_name[12])
                                      {
                                        case 'a':
                                            if ((String.Compare(field_name, 13, "x", 0, 1, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorGuestRatingMax;
                                            break;
                                        case 'i':
                                            if ((String.Compare(field_name, 13, "n", 0, 1, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorGuestRatingMin;
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
                case 'H':
                    if (String.Compare(field_name, 1, "otels", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 7, "xclude", 0, 6, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorHotelsExclude;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 7, "nclude", 0, 6, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorHotelsInclude;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nexpensiveFlag", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorInexpensiveFlag;
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            switch (field_name[2])
                              {
                                case 'p':
                                    if ((String.Compare(field_name, 3, "Location", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorMapLocation;
                                    break;
                                case 'x':
                                    if ((String.Compare(field_name, 3, "imumPrice", 0, 9, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorMaximumPrice;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nimumPrice", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorMinimumPrice;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "riceIsTotal", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorPriceIsTotal;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryType;
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "dius", 0, 4, false) == 0)
                              {
                                if (field_name.Length == 6)
                                  {
                                    return fieldGeneratorRadius;
                                  }
                                switch (field_name[6])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "nferred", 0, 7, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorRadiusInferred;
                                        break;
                                    case 'U':
                                        if ((String.Compare(field_name, 7, "nit", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorRadiusUnit;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "sultCount", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorResultCount;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "omCount", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorRoomCount;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'o':
                            if (String.Compare(field_name, 2, "rt", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 5, "riteria", 0, 7, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorSortCriteria;
                                        break;
                                    case 'O':
                                        if ((String.Compare(field_name, 5, "rder", 0, 4, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorSortOrder;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "ecificHotelQuestion", 0, 19, false) == 0) && (field_name.Length == 21))
                                return fieldGeneratorSpecificHotelQuestion;
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "ar", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'R':
                                        if (String.Compare(field_name, 5, "ating", 0, 5, false) == 0)
                                          {
                                            switch (field_name[10])
                                              {
                                                case 'M':
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
                                                    break;
                                                case 's':
                                                    switch (field_name[11])
                                                      {
                                                        case 'E':
                                                            if ((String.Compare(field_name, 12, "xclude", 0, 6, false) == 0) && (field_name.Length == 18))
                                                                return fieldGeneratorStarRatingsExclude;
                                                            break;
                                                        case 'I':
                                                            if ((String.Compare(field_name, 12, "nclude", 0, 6, false) == 0) && (field_name.Length == 18))
                                                                return fieldGeneratorStarRatingsInclude;
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
                                    case 't':
                                        if (String.Compare(field_name, 5, "Date", 0, 4, false) == 0)
                                          {
                                            switch (field_name[9])
                                              {
                                                case 'A':
                                                    if (String.Compare(field_name, 10, "ndTime", 0, 6, false) == 0)
                                                      {
                                                        switch (field_name[16])
                                                          {
                                                            case 'F':
                                                                if ((String.Compare(field_name, 17, "inal", 0, 4, false) == 0) && (field_name.Length == 21))
                                                                    return fieldGeneratorStartDateAndTimeFinal;
                                                                break;
                                                            case 'I':
                                                                if (String.Compare(field_name, 17, "n", 0, 1, false) == 0)
                                                                  {
                                                                    switch (field_name[18])
                                                                      {
                                                                        case 'f':
                                                                            if ((String.Compare(field_name, 19, "erred", 0, 5, false) == 0) && (field_name.Length == 24))
                                                                                return fieldGeneratorStartDateAndTimeInferred;
                                                                            break;
                                                                        case 'p':
                                                                            if ((String.Compare(field_name, 19, "ut", 0, 2, false) == 0) && (field_name.Length == 21))
                                                                                return fieldGeneratorStartDateAndTimeInput;
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
                                                    if ((String.Compare(field_name, 10, "rintedForm", 0, 10, false) == 0) && (field_name.Length == 20))
                                                        return fieldGeneratorStartDatePrintedForm;
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(field_name, 10, "pokenForm", 0, 9, false) == 0) && (field_name.Length == 19))
                                                        return fieldGeneratorStartDateSpokenForm;
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
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the HotelFilterSpec class");
            fieldGeneratorResultCount = new FieldHoldingGeneratorResultCount("field \"ResultCount\" of the HotelFilterSpec class");
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the HotelFilterSpec class", ignore_extras);
            fieldGeneratorRadius = new JSONHoldingNumberTextGenerator("field \"Radius\" of the HotelFilterSpec class");
            fieldGeneratorRadiusUnit = new FieldHoldingGeneratorRadiusUnit("field \"RadiusUnit\" of the HotelFilterSpec class");
            fieldGeneratorRadiusInferred = new JSONHoldingBooleanGenerator("field \"RadiusInferred\" of the HotelFilterSpec class");
            fieldGeneratorAveragePrice = new MoneyJSON.HoldingGenerator("field \"AveragePrice\" of the HotelFilterSpec class", ignore_extras);
            fieldGeneratorMinimumPrice = new MoneyJSON.HoldingGenerator("field \"MinimumPrice\" of the HotelFilterSpec class", ignore_extras);
            fieldGeneratorMaximumPrice = new MoneyJSON.HoldingGenerator("field \"MaximumPrice\" of the HotelFilterSpec class", ignore_extras);
            fieldGeneratorPriceIsTotal = new JSONHoldingBooleanGenerator("field \"PriceIsTotal\" of the HotelFilterSpec class");
            fieldGeneratorStartDateAndTimeInput = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTimeInput\" of the HotelFilterSpec class", ignore_extras);
            fieldGeneratorEndDateAndTimeInput = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTimeInput\" of the HotelFilterSpec class", ignore_extras);
            fieldGeneratorStartDateAndTimeInferred = new JSONHoldingBooleanGenerator("field \"StartDateAndTimeInferred\" of the HotelFilterSpec class");
            fieldGeneratorEndDateAndTimeInferred = new JSONHoldingBooleanGenerator("field \"EndDateAndTimeInferred\" of the HotelFilterSpec class");
            fieldGeneratorStartDateAndTimeFinal = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTimeFinal\" of the HotelFilterSpec class", ignore_extras);
            fieldGeneratorStartDatePrintedForm = new JSONHoldingStringGenerator("field \"StartDatePrintedForm\" of the HotelFilterSpec class");
            fieldGeneratorStartDateSpokenForm = new JSONHoldingStringGenerator("field \"StartDateSpokenForm\" of the HotelFilterSpec class");
            fieldGeneratorEndDateAndTimeFinal = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTimeFinal\" of the HotelFilterSpec class", ignore_extras);
            fieldGeneratorEndDatePrintedForm = new JSONHoldingStringGenerator("field \"EndDatePrintedForm\" of the HotelFilterSpec class");
            fieldGeneratorEndDateSpokenForm = new JSONHoldingStringGenerator("field \"EndDateSpokenForm\" of the HotelFilterSpec class");
            fieldGeneratorDurationInDaysInput = new FieldHoldingGeneratorDurationInDaysInput("field \"DurationInDaysInput\" of the HotelFilterSpec class");
            fieldGeneratorDurationInDaysFinal = new FieldHoldingGeneratorDurationInDaysFinal("field \"DurationInDaysFinal\" of the HotelFilterSpec class");
            fieldGeneratorSortCriteria = new FieldHoldingArrayGeneratorSortCriteria("field \"SortCriteria\" of the HotelFilterSpec class");
            fieldGeneratorSortOrder = new FieldHoldingArrayGeneratorSortOrder("field \"SortOrder\" of the HotelFilterSpec class");
            fieldGeneratorAvailableOnly = new JSONHoldingBooleanGenerator("field \"AvailableOnly\" of the HotelFilterSpec class");
            fieldGeneratorExpensiveFlag = new JSONHoldingBooleanGenerator("field \"ExpensiveFlag\" of the HotelFilterSpec class");
            fieldGeneratorInexpensiveFlag = new JSONHoldingBooleanGenerator("field \"InexpensiveFlag\" of the HotelFilterSpec class");
            fieldGeneratorSpecificHotelQuestion = new JSONHoldingBooleanGenerator("field \"SpecificHotelQuestion\" of the HotelFilterSpec class");
            fieldGeneratorConversationMode = new JSONHoldingBooleanGenerator("field \"ConversationMode\" of the HotelFilterSpec class");
            fieldGeneratorGuestRatingMin = new JSONHoldingNumberTextGenerator("field \"GuestRatingMin\" of the HotelFilterSpec class");
            fieldGeneratorGuestRatingMax = new JSONHoldingNumberTextGenerator("field \"GuestRatingMax\" of the HotelFilterSpec class");
            fieldGeneratorStarRatingMin = new JSONHoldingNumberTextGenerator("field \"StarRatingMin\" of the HotelFilterSpec class");
            fieldGeneratorStarRatingMax = new JSONHoldingNumberTextGenerator("field \"StarRatingMax\" of the HotelFilterSpec class");
            fieldGeneratorStarRatingsInclude = new JSONHoldingNumberTextArrayGenerator("field \"StarRatingsInclude\" of the HotelFilterSpec class");
            fieldGeneratorStarRatingsExclude = new JSONHoldingNumberTextArrayGenerator("field \"StarRatingsExclude\" of the HotelFilterSpec class");
            fieldGeneratorRoomCount = new FieldHoldingGeneratorRoomCount("field \"RoomCount\" of the HotelFilterSpec class");
            fieldGeneratorAdultCount = new FieldHoldingArrayGeneratorAdultCount("field \"AdultCount\" of the HotelFilterSpec class");
            fieldGeneratorChildrenCount = new FieldHoldingArrayGeneratorChildrenCount("field \"ChildrenCount\" of the HotelFilterSpec class");
            fieldGeneratorGuestCountIsPerRoom = new JSONHoldingBooleanGenerator("field \"GuestCountIsPerRoom\" of the HotelFilterSpec class");
            fieldGeneratorFranchiseNamesInclude = new JSONHoldingStringArrayGenerator("field \"FranchiseNamesInclude\" of the HotelFilterSpec class");
            fieldGeneratorFranchiseNamesExclude = new JSONHoldingStringArrayGenerator("field \"FranchiseNamesExclude\" of the HotelFilterSpec class");
            fieldGeneratorHotelsInclude = new FieldHoldingArrayGeneratorHotelsInclude("field \"HotelsInclude\" of the HotelFilterSpec class");
            fieldGeneratorHotelsExclude = new FieldHoldingArrayGeneratorHotelsExclude("field \"HotelsExclude\" of the HotelFilterSpec class");
            fieldGeneratorAccommodationTypesInclude = new FieldHoldingArrayGeneratorAccommodationTypesInclude("field \"AccommodationTypesInclude\" of the HotelFilterSpec class");
            fieldGeneratorAccommodationTypesExclude = new FieldHoldingArrayGeneratorAccommodationTypesExclude("field \"AccommodationTypesExclude\" of the HotelFilterSpec class");
            fieldGeneratorAmenitiesInclude = new TypeAmenitiesIncludeJSON.HoldingArrayGenerator("field \"AmenitiesInclude\" of the HotelFilterSpec class", ignore_extras);
            fieldGeneratorAmenitiesExclude = new TypeAmenitiesExcludeJSON.HoldingArrayGenerator("field \"AmenitiesExclude\" of the HotelFilterSpec class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HotelFilterSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the HotelFilterSpec class");
            fieldGeneratorResultCount = new FieldHoldingGeneratorResultCount("field \"ResultCount\" of the HotelFilterSpec class");
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the HotelFilterSpec class", false);
            fieldGeneratorRadius = new JSONHoldingNumberTextGenerator("field \"Radius\" of the HotelFilterSpec class");
            fieldGeneratorRadiusUnit = new FieldHoldingGeneratorRadiusUnit("field \"RadiusUnit\" of the HotelFilterSpec class");
            fieldGeneratorRadiusInferred = new JSONHoldingBooleanGenerator("field \"RadiusInferred\" of the HotelFilterSpec class");
            fieldGeneratorAveragePrice = new MoneyJSON.HoldingGenerator("field \"AveragePrice\" of the HotelFilterSpec class", false);
            fieldGeneratorMinimumPrice = new MoneyJSON.HoldingGenerator("field \"MinimumPrice\" of the HotelFilterSpec class", false);
            fieldGeneratorMaximumPrice = new MoneyJSON.HoldingGenerator("field \"MaximumPrice\" of the HotelFilterSpec class", false);
            fieldGeneratorPriceIsTotal = new JSONHoldingBooleanGenerator("field \"PriceIsTotal\" of the HotelFilterSpec class");
            fieldGeneratorStartDateAndTimeInput = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTimeInput\" of the HotelFilterSpec class", false);
            fieldGeneratorEndDateAndTimeInput = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTimeInput\" of the HotelFilterSpec class", false);
            fieldGeneratorStartDateAndTimeInferred = new JSONHoldingBooleanGenerator("field \"StartDateAndTimeInferred\" of the HotelFilterSpec class");
            fieldGeneratorEndDateAndTimeInferred = new JSONHoldingBooleanGenerator("field \"EndDateAndTimeInferred\" of the HotelFilterSpec class");
            fieldGeneratorStartDateAndTimeFinal = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTimeFinal\" of the HotelFilterSpec class", false);
            fieldGeneratorStartDatePrintedForm = new JSONHoldingStringGenerator("field \"StartDatePrintedForm\" of the HotelFilterSpec class");
            fieldGeneratorStartDateSpokenForm = new JSONHoldingStringGenerator("field \"StartDateSpokenForm\" of the HotelFilterSpec class");
            fieldGeneratorEndDateAndTimeFinal = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTimeFinal\" of the HotelFilterSpec class", false);
            fieldGeneratorEndDatePrintedForm = new JSONHoldingStringGenerator("field \"EndDatePrintedForm\" of the HotelFilterSpec class");
            fieldGeneratorEndDateSpokenForm = new JSONHoldingStringGenerator("field \"EndDateSpokenForm\" of the HotelFilterSpec class");
            fieldGeneratorDurationInDaysInput = new FieldHoldingGeneratorDurationInDaysInput("field \"DurationInDaysInput\" of the HotelFilterSpec class");
            fieldGeneratorDurationInDaysFinal = new FieldHoldingGeneratorDurationInDaysFinal("field \"DurationInDaysFinal\" of the HotelFilterSpec class");
            fieldGeneratorSortCriteria = new FieldHoldingArrayGeneratorSortCriteria("field \"SortCriteria\" of the HotelFilterSpec class");
            fieldGeneratorSortOrder = new FieldHoldingArrayGeneratorSortOrder("field \"SortOrder\" of the HotelFilterSpec class");
            fieldGeneratorAvailableOnly = new JSONHoldingBooleanGenerator("field \"AvailableOnly\" of the HotelFilterSpec class");
            fieldGeneratorExpensiveFlag = new JSONHoldingBooleanGenerator("field \"ExpensiveFlag\" of the HotelFilterSpec class");
            fieldGeneratorInexpensiveFlag = new JSONHoldingBooleanGenerator("field \"InexpensiveFlag\" of the HotelFilterSpec class");
            fieldGeneratorSpecificHotelQuestion = new JSONHoldingBooleanGenerator("field \"SpecificHotelQuestion\" of the HotelFilterSpec class");
            fieldGeneratorConversationMode = new JSONHoldingBooleanGenerator("field \"ConversationMode\" of the HotelFilterSpec class");
            fieldGeneratorGuestRatingMin = new JSONHoldingNumberTextGenerator("field \"GuestRatingMin\" of the HotelFilterSpec class");
            fieldGeneratorGuestRatingMax = new JSONHoldingNumberTextGenerator("field \"GuestRatingMax\" of the HotelFilterSpec class");
            fieldGeneratorStarRatingMin = new JSONHoldingNumberTextGenerator("field \"StarRatingMin\" of the HotelFilterSpec class");
            fieldGeneratorStarRatingMax = new JSONHoldingNumberTextGenerator("field \"StarRatingMax\" of the HotelFilterSpec class");
            fieldGeneratorStarRatingsInclude = new JSONHoldingNumberTextArrayGenerator("field \"StarRatingsInclude\" of the HotelFilterSpec class");
            fieldGeneratorStarRatingsExclude = new JSONHoldingNumberTextArrayGenerator("field \"StarRatingsExclude\" of the HotelFilterSpec class");
            fieldGeneratorRoomCount = new FieldHoldingGeneratorRoomCount("field \"RoomCount\" of the HotelFilterSpec class");
            fieldGeneratorAdultCount = new FieldHoldingArrayGeneratorAdultCount("field \"AdultCount\" of the HotelFilterSpec class");
            fieldGeneratorChildrenCount = new FieldHoldingArrayGeneratorChildrenCount("field \"ChildrenCount\" of the HotelFilterSpec class");
            fieldGeneratorGuestCountIsPerRoom = new JSONHoldingBooleanGenerator("field \"GuestCountIsPerRoom\" of the HotelFilterSpec class");
            fieldGeneratorFranchiseNamesInclude = new JSONHoldingStringArrayGenerator("field \"FranchiseNamesInclude\" of the HotelFilterSpec class");
            fieldGeneratorFranchiseNamesExclude = new JSONHoldingStringArrayGenerator("field \"FranchiseNamesExclude\" of the HotelFilterSpec class");
            fieldGeneratorHotelsInclude = new FieldHoldingArrayGeneratorHotelsInclude("field \"HotelsInclude\" of the HotelFilterSpec class");
            fieldGeneratorHotelsExclude = new FieldHoldingArrayGeneratorHotelsExclude("field \"HotelsExclude\" of the HotelFilterSpec class");
            fieldGeneratorAccommodationTypesInclude = new FieldHoldingArrayGeneratorAccommodationTypesInclude("field \"AccommodationTypesInclude\" of the HotelFilterSpec class");
            fieldGeneratorAccommodationTypesExclude = new FieldHoldingArrayGeneratorAccommodationTypesExclude("field \"AccommodationTypesExclude\" of the HotelFilterSpec class");
            fieldGeneratorAmenitiesInclude = new TypeAmenitiesIncludeJSON.HoldingArrayGenerator("field \"AmenitiesInclude\" of the HotelFilterSpec class", false);
            fieldGeneratorAmenitiesExclude = new TypeAmenitiesExcludeJSON.HoldingArrayGenerator("field \"AmenitiesExclude\" of the HotelFilterSpec class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HotelFilterSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            fieldGeneratorResultCount.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorRadius.reset();
            fieldGeneratorRadiusUnit.reset();
            fieldGeneratorRadiusInferred.reset();
            fieldGeneratorAveragePrice.reset();
            fieldGeneratorMinimumPrice.reset();
            fieldGeneratorMaximumPrice.reset();
            fieldGeneratorPriceIsTotal.reset();
            fieldGeneratorStartDateAndTimeInput.reset();
            fieldGeneratorEndDateAndTimeInput.reset();
            fieldGeneratorStartDateAndTimeInferred.reset();
            fieldGeneratorEndDateAndTimeInferred.reset();
            fieldGeneratorStartDateAndTimeFinal.reset();
            fieldGeneratorStartDatePrintedForm.reset();
            fieldGeneratorStartDateSpokenForm.reset();
            fieldGeneratorEndDateAndTimeFinal.reset();
            fieldGeneratorEndDatePrintedForm.reset();
            fieldGeneratorEndDateSpokenForm.reset();
            fieldGeneratorDurationInDaysInput.reset();
            fieldGeneratorDurationInDaysFinal.reset();
            fieldGeneratorSortCriteria.reset();
            fieldGeneratorSortOrder.reset();
            fieldGeneratorAvailableOnly.reset();
            fieldGeneratorExpensiveFlag.reset();
            fieldGeneratorInexpensiveFlag.reset();
            fieldGeneratorSpecificHotelQuestion.reset();
            fieldGeneratorConversationMode.reset();
            fieldGeneratorGuestRatingMin.reset();
            fieldGeneratorGuestRatingMax.reset();
            fieldGeneratorStarRatingMin.reset();
            fieldGeneratorStarRatingMax.reset();
            fieldGeneratorStarRatingsInclude.reset();
            fieldGeneratorStarRatingsExclude.reset();
            fieldGeneratorRoomCount.reset();
            fieldGeneratorAdultCount.reset();
            fieldGeneratorChildrenCount.reset();
            fieldGeneratorGuestCountIsPerRoom.reset();
            fieldGeneratorFranchiseNamesInclude.reset();
            fieldGeneratorFranchiseNamesExclude.reset();
            fieldGeneratorHotelsInclude.reset();
            fieldGeneratorHotelsExclude.reset();
            fieldGeneratorAccommodationTypesInclude.reset();
            fieldGeneratorAccommodationTypesExclude.reset();
            fieldGeneratorAmenitiesInclude.reset();
            fieldGeneratorAmenitiesExclude.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMapLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAveragePrice.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMinimumPrice.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMaximumPrice.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStartDateAndTimeInput.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEndDateAndTimeInput.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStartDateAndTimeFinal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEndDateAndTimeFinal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmenitiesInclude.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmenitiesExclude.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMapLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAveragePrice.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMinimumPrice.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMaximumPrice.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStartDateAndTimeInput.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEndDateAndTimeInput.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStartDateAndTimeFinal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEndDateAndTimeFinal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmenitiesInclude.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmenitiesExclude.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HotelFilterSpecJSON  result)
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
        public HotelFilterSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HotelFilterSpecJSON  result)
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
    protected virtual void handle_result(List<HotelFilterSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HotelFilterSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HotelFilterSpecJSON>();
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
    public List<HotelFilterSpecJSON> value;
  };
  };
