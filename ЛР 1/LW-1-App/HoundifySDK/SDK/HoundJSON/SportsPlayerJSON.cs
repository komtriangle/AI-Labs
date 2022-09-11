/* file "SportsPlayerJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsPlayerJSON : JSONBase
  {
    public enum TypeThrowHandKnownValues
      {
        ThrowHand_Left,
        ThrowHand_Right,
        ThrowHand_Both,
        ThrowHand__none
      };
    public struct TypeThrowHand
      {
        public bool in_known_list;
        public string string_value;
        public TypeThrowHandKnownValues list_value;
      };

    public static TypeThrowHandKnownValues  stringToThrowHand(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "oth", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeThrowHandKnownValues.ThrowHand_Both;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "eft", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeThrowHandKnownValues.ThrowHand_Left;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "ight", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeThrowHandKnownValues.ThrowHand_Right;
                break;
            default:
                break;
          }
        return TypeThrowHandKnownValues.ThrowHand__none;
      }

    public static string  stringFromThrowHand(TypeThrowHandKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeThrowHandKnownValues.ThrowHand_Left:
                return "Left";
            case TypeThrowHandKnownValues.ThrowHand_Right:
                return "Right";
            case TypeThrowHandKnownValues.ThrowHand_Both:
                return "Both";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeBatHandKnownValues
      {
        BatHand_Left,
        BatHand_Right,
        BatHand_Both,
        BatHand__none
      };
    public struct TypeBatHand
      {
        public bool in_known_list;
        public string string_value;
        public TypeBatHandKnownValues list_value;
      };

    public static TypeBatHandKnownValues  stringToBatHand(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "oth", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeBatHandKnownValues.BatHand_Both;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "eft", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeBatHandKnownValues.BatHand_Left;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "ight", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeBatHandKnownValues.BatHand_Right;
                break;
            default:
                break;
          }
        return TypeBatHandKnownValues.BatHand__none;
      }

    public static string  stringFromBatHand(TypeBatHandKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeBatHandKnownValues.BatHand_Left:
                return "Left";
            case TypeBatHandKnownValues.BatHand_Right:
                return "Right";
            case TypeBatHandKnownValues.BatHand_Both:
                return "Both";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeExperienceCollegeKnownValues
      {
        ExperienceCollege_Freshman,
        ExperienceCollege_Sophomore,
        ExperienceCollege_Junior,
        ExperienceCollege_Senior,
        ExperienceCollege_GraduateStudent,
        ExperienceCollege__none
      };
    public struct TypeExperienceCollege
      {
        public bool in_known_list;
        public string string_value;
        public TypeExperienceCollegeKnownValues list_value;
      };

    public static TypeExperienceCollegeKnownValues  stringToExperienceCollege(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "reshman", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeExperienceCollegeKnownValues.ExperienceCollege_Freshman;
                break;
            case 'G':
                if ((String.Compare(chars, 1, "raduateStudent", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeExperienceCollegeKnownValues.ExperienceCollege_GraduateStudent;
                break;
            case 'J':
                if ((String.Compare(chars, 1, "unior", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeExperienceCollegeKnownValues.ExperienceCollege_Junior;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "nior", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeExperienceCollegeKnownValues.ExperienceCollege_Senior;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "phomore", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeExperienceCollegeKnownValues.ExperienceCollege_Sophomore;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeExperienceCollegeKnownValues.ExperienceCollege__none;
      }

    public static string  stringFromExperienceCollege(TypeExperienceCollegeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeExperienceCollegeKnownValues.ExperienceCollege_Freshman:
                return "Freshman";
            case TypeExperienceCollegeKnownValues.ExperienceCollege_Sophomore:
                return "Sophomore";
            case TypeExperienceCollegeKnownValues.ExperienceCollege_Junior:
                return "Junior";
            case TypeExperienceCollegeKnownValues.ExperienceCollege_Senior:
                return "Senior";
            case TypeExperienceCollegeKnownValues.ExperienceCollege_GraduateStudent:
                return "GraduateStudent";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFirstName;
    private string storeFirstName;
    private bool flagHasLastName;
    private string storeLastName;
    private bool flagHasPreferredName;
    private string storePreferredName;
    private bool flagHasFullName;
    private string storeFullName;
    private bool flagHasTeam;
    private SportsTeamNewJSON  storeTeam;
    private bool flagHasID;
    private string storeID;
    private bool flagHasJerseyNumber;
    private BigInteger storeJerseyNumber;
    private bool flagHasWeightInPounds;
    private double storeWeightInPounds;
    private string textStoreWeightInPounds;
    private bool flagHasHeightInInches;
    private double storeHeightInInches;
    private string textStoreHeightInInches;
    private bool flagHasPosition;
    private SportsPlayerPositionJSON  storePosition;
    private bool flagHasStatus;
    private SportsPlayerStatusJSON  storeStatus;
    private bool flagHasThrowHand;
    private TypeThrowHand storeThrowHand;
    private bool flagHasBatHand;
    private TypeBatHand storeBatHand;
    private bool flagHasBirthDate;
    private DateAndOrTimeJSON  storeBirthDate;
    private bool flagHasBirthCountry;
    private string storeBirthCountry;
    private bool flagHasBirthState;
    private string storeBirthState;
    private bool flagHasBirthCity;
    private string storeBirthCity;
    private bool flagHasCollege;
    private string storeCollege;
    private bool flagHasHighSchool;
    private string storeHighSchool;
    private bool flagHasExperienceInYears;
    private BigInteger storeExperienceInYears;
    private bool flagHasExperienceCollege;
    private TypeExperienceCollege storeExperienceCollege;
    private bool flagHasImages;
    private List< SportsPlayerImageJSON  > storeImages;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFirstName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FirstName of SportsPlayerJSON is not a string.");
        setFirstName(json_string.getData());
      }


    private void  fromJSONLastName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastName of SportsPlayerJSON is not a string.");
        setLastName(json_string.getData());
      }


    private void  fromJSONPreferredName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PreferredName of SportsPlayerJSON is not a string.");
        setPreferredName(json_string.getData());
      }


    private void  fromJSONFullName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FullName of SportsPlayerJSON is not a string.");
        setFullName(json_string.getData());
      }


    private void  fromJSONTeam(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_value, ignore_extras, true);
        setTeam(convert_classy);
      }


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ID of SportsPlayerJSON is not a string.");
        setID(json_string.getData());
      }


    private void  fromJSONJerseyNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field JerseyNumber of SportsPlayerJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field JerseyNumber of SportsPlayerJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setJerseyNumber(extracted_integer);
      }


    private void  fromJSONWeightInPounds(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field WeightInPounds of SportsPlayerJSON is not a number.");
              }
          }
        setWeightInPoundsText(the_rational_text);
      }


    private void  fromJSONHeightInInches(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HeightInInches of SportsPlayerJSON is not a number.");
              }
          }
        setHeightInInchesText(the_rational_text);
      }


    private void  fromJSONPosition(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayerPositionJSON convert_classy = SportsPlayerPositionJSON.from_json(json_value, ignore_extras, true);
        setPosition(convert_classy);
      }


    private void  fromJSONStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayerStatusJSON convert_classy = SportsPlayerStatusJSON.from_json(json_value, ignore_extras, true);
        setStatus(convert_classy);
      }


    private void  fromJSONThrowHand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ThrowHand of SportsPlayerJSON is not a string.");
        TypeThrowHand the_open_enum = new TypeThrowHand();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "oth", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeThrowHandKnownValues.ThrowHand_Both;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "eft", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeThrowHandKnownValues.ThrowHand_Left;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "ight", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeThrowHandKnownValues.ThrowHand_Right;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setThrowHand(the_open_enum);
      }


    private void  fromJSONBatHand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BatHand of SportsPlayerJSON is not a string.");
        TypeBatHand the_open_enum = new TypeBatHand();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "oth", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBatHandKnownValues.BatHand_Both;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "eft", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBatHandKnownValues.BatHand_Left;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "ight", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBatHandKnownValues.BatHand_Right;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setBatHand(the_open_enum);
      }


    private void  fromJSONBirthDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setBirthDate(convert_classy);
      }


    private void  fromJSONBirthCountry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BirthCountry of SportsPlayerJSON is not a string.");
        setBirthCountry(json_string.getData());
      }


    private void  fromJSONBirthState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BirthState of SportsPlayerJSON is not a string.");
        setBirthState(json_string.getData());
      }


    private void  fromJSONBirthCity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BirthCity of SportsPlayerJSON is not a string.");
        setBirthCity(json_string.getData());
      }


    private void  fromJSONCollege(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field College of SportsPlayerJSON is not a string.");
        setCollege(json_string.getData());
      }


    private void  fromJSONHighSchool(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HighSchool of SportsPlayerJSON is not a string.");
        setHighSchool(json_string.getData());
      }


    private void  fromJSONExperienceInYears(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ExperienceInYears of SportsPlayerJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ExperienceInYears of SportsPlayerJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setExperienceInYears(extracted_integer);
      }


    private void  fromJSONExperienceCollege(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExperienceCollege of SportsPlayerJSON is not a string.");
        TypeExperienceCollege the_open_enum = new TypeExperienceCollege();
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "reshman", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeExperienceCollegeKnownValues.ExperienceCollege_Freshman;
                        goto open_enum_is_done;
                      }
                break;
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "raduateStudent", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeExperienceCollegeKnownValues.ExperienceCollege_GraduateStudent;
                        goto open_enum_is_done;
                      }
                break;
            case 'J':
                if ((String.Compare(json_string.getData(), 1, "unior", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeExperienceCollegeKnownValues.ExperienceCollege_Junior;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "nior", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeExperienceCollegeKnownValues.ExperienceCollege_Senior;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "phomore", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeExperienceCollegeKnownValues.ExperienceCollege_Sophomore;
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
        setExperienceCollege(the_open_enum);
      }


    private void  fromJSONImages(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Images of SportsPlayerJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsPlayerImageJSON  > vector_Images1 = new List< SportsPlayerImageJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsPlayerImageJSON convert_classy = SportsPlayerImageJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Images1.Add(convert_classy);
          }
        initImages();
        for (int num1 = 0; num1 < vector_Images1.Count; ++num1)
            appendImages(vector_Images1[num1]);
        for (int num1 = 0; num1 < vector_Images1.Count; ++num1)
          {
          }
      }


    public SportsPlayerJSON()
      {
        flagHasFirstName = false;
        flagHasLastName = false;
        flagHasPreferredName = false;
        flagHasFullName = false;
        flagHasTeam = false;
        flagHasID = false;
        flagHasJerseyNumber = false;
        flagHasWeightInPounds = false;
        flagHasHeightInInches = false;
        flagHasPosition = false;
        flagHasStatus = false;
        flagHasThrowHand = false;
        flagHasBatHand = false;
        flagHasBirthDate = false;
        flagHasBirthCountry = false;
        flagHasBirthState = false;
        flagHasBirthCity = false;
        flagHasCollege = false;
        flagHasHighSchool = false;
        flagHasExperienceInYears = false;
        flagHasExperienceCollege = false;
        flagHasImages = false;
        storeImages = new List< SportsPlayerImageJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFirstName()
      {
        return flagHasFirstName;
      }

    public string  getFirstName()
      {
        Debug.Assert(flagHasFirstName);
        return storeFirstName;
      }

    public bool  hasLastName()
      {
        return flagHasLastName;
      }

    public string  getLastName()
      {
        Debug.Assert(flagHasLastName);
        return storeLastName;
      }

    public bool  hasPreferredName()
      {
        return flagHasPreferredName;
      }

    public string  getPreferredName()
      {
        Debug.Assert(flagHasPreferredName);
        return storePreferredName;
      }

    public bool  hasFullName()
      {
        return flagHasFullName;
      }

    public string  getFullName()
      {
        Debug.Assert(flagHasFullName);
        return storeFullName;
      }

    public bool  hasTeam()
      {
        return flagHasTeam;
      }

    public SportsTeamNewJSON   getTeam()
      {
        Debug.Assert(flagHasTeam);
        return storeTeam;
      }

    public bool  hasID()
      {
        return flagHasID;
      }

    public string  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }

    public bool  hasJerseyNumber()
      {
        return flagHasJerseyNumber;
      }

    public BigInteger  getJerseyNumber()
      {
        Debug.Assert(flagHasJerseyNumber);
        return storeJerseyNumber;
      }

    public bool  hasWeightInPounds()
      {
        return flagHasWeightInPounds;
      }

    public double  getWeightInPounds()
      {
        Debug.Assert(flagHasWeightInPounds);
        if (textStoreWeightInPounds != "")
          {
            return Double.Parse(textStoreWeightInPounds);
          }
        return storeWeightInPounds;
      }

    public string  getWeightInPoundsAsText()
      {
        Debug.Assert(flagHasWeightInPounds);
        if (textStoreWeightInPounds == "")
          {
            return Convert.ToString(storeWeightInPounds);
          }
        else
          {
            return (textStoreWeightInPounds);
          }
      }

    public bool  hasHeightInInches()
      {
        return flagHasHeightInInches;
      }

    public double  getHeightInInches()
      {
        Debug.Assert(flagHasHeightInInches);
        if (textStoreHeightInInches != "")
          {
            return Double.Parse(textStoreHeightInInches);
          }
        return storeHeightInInches;
      }

    public string  getHeightInInchesAsText()
      {
        Debug.Assert(flagHasHeightInInches);
        if (textStoreHeightInInches == "")
          {
            return Convert.ToString(storeHeightInInches);
          }
        else
          {
            return (textStoreHeightInInches);
          }
      }

    public bool  hasPosition()
      {
        return flagHasPosition;
      }

    public SportsPlayerPositionJSON   getPosition()
      {
        Debug.Assert(flagHasPosition);
        return storePosition;
      }

    public SportsPlayerPositionJSON.TypeValue  getPositionValue()
      {
        return getPosition().getValue();
      }

    public string  getPositionAsString()
      {
        return getPosition().getValueAsString();
      }

    public bool  hasStatus()
      {
        return flagHasStatus;
      }

    public SportsPlayerStatusJSON   getStatus()
      {
        Debug.Assert(flagHasStatus);
        return storeStatus;
      }

    public SportsPlayerStatusJSON.TypeValue  getStatusValue()
      {
        return getStatus().getValue();
      }

    public string  getStatusAsString()
      {
        return getStatus().getValueAsString();
      }

    public bool  hasThrowHand()
      {
        return flagHasThrowHand;
      }

    public TypeThrowHand  getThrowHand()
      {
        Debug.Assert(flagHasThrowHand);
        return storeThrowHand;
      }

    public string  getThrowHandAsString()
      {
        TypeThrowHand result = getThrowHand();
        if (result.in_known_list)
            return stringFromThrowHand(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasBatHand()
      {
        return flagHasBatHand;
      }

    public TypeBatHand  getBatHand()
      {
        Debug.Assert(flagHasBatHand);
        return storeBatHand;
      }

    public string  getBatHandAsString()
      {
        TypeBatHand result = getBatHand();
        if (result.in_known_list)
            return stringFromBatHand(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasBirthDate()
      {
        return flagHasBirthDate;
      }

    public DateAndOrTimeJSON   getBirthDate()
      {
        Debug.Assert(flagHasBirthDate);
        return storeBirthDate;
      }

    public bool  hasBirthCountry()
      {
        return flagHasBirthCountry;
      }

    public string  getBirthCountry()
      {
        Debug.Assert(flagHasBirthCountry);
        return storeBirthCountry;
      }

    public bool  hasBirthState()
      {
        return flagHasBirthState;
      }

    public string  getBirthState()
      {
        Debug.Assert(flagHasBirthState);
        return storeBirthState;
      }

    public bool  hasBirthCity()
      {
        return flagHasBirthCity;
      }

    public string  getBirthCity()
      {
        Debug.Assert(flagHasBirthCity);
        return storeBirthCity;
      }

    public bool  hasCollege()
      {
        return flagHasCollege;
      }

    public string  getCollege()
      {
        Debug.Assert(flagHasCollege);
        return storeCollege;
      }

    public bool  hasHighSchool()
      {
        return flagHasHighSchool;
      }

    public string  getHighSchool()
      {
        Debug.Assert(flagHasHighSchool);
        return storeHighSchool;
      }

    public bool  hasExperienceInYears()
      {
        return flagHasExperienceInYears;
      }

    public BigInteger  getExperienceInYears()
      {
        Debug.Assert(flagHasExperienceInYears);
        return storeExperienceInYears;
      }

    public bool  hasExperienceCollege()
      {
        return flagHasExperienceCollege;
      }

    public TypeExperienceCollege  getExperienceCollege()
      {
        Debug.Assert(flagHasExperienceCollege);
        return storeExperienceCollege;
      }

    public string  getExperienceCollegeAsString()
      {
        TypeExperienceCollege result = getExperienceCollege();
        if (result.in_known_list)
            return stringFromExperienceCollege(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasImages()
      {
        return flagHasImages;
      }

    public int  countOfImages()
      {
        Debug.Assert(flagHasImages);
        return storeImages.Count;
      }

    public SportsPlayerImageJSON   elementOfImages(int element_num)
      {
        Debug.Assert(flagHasImages);
        return storeImages[element_num];
      }

    public List< SportsPlayerImageJSON  >  getImages()
      {
        Debug.Assert(flagHasImages);
        return storeImages;
      }


    public virtual int extraSportsPlayerComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayerComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayerComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayerLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFirstName(string new_value)
      {
        flagHasFirstName = true;
        storeFirstName = new_value;
      }
    public void unsetFirstName()
      {
        flagHasFirstName = false;
      }
    public void setLastName(string new_value)
      {
        flagHasLastName = true;
        storeLastName = new_value;
      }
    public void unsetLastName()
      {
        flagHasLastName = false;
      }
    public void setPreferredName(string new_value)
      {
        flagHasPreferredName = true;
        storePreferredName = new_value;
      }
    public void unsetPreferredName()
      {
        flagHasPreferredName = false;
      }
    public void setFullName(string new_value)
      {
        flagHasFullName = true;
        storeFullName = new_value;
      }
    public void unsetFullName()
      {
        flagHasFullName = false;
      }
    public void setTeam(SportsTeamNewJSON  new_value)
      {
        if (flagHasTeam)
          {
          }
        flagHasTeam = true;
        storeTeam = new_value;
      }
    public void unsetTeam()
      {
        if (flagHasTeam)
          {
          }
        flagHasTeam = false;
      }
    public void setID(string new_value)
      {
        flagHasID = true;
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void setJerseyNumber(BigInteger new_value)
      {
        flagHasJerseyNumber = true;
        if (new_value < 0)
            throw new Exception("The value for field JerseyNumber of SportsPlayerJSON is less than the lower bound (0) for that field.");
        storeJerseyNumber = new_value;
      }
    public void unsetJerseyNumber()
      {
        flagHasJerseyNumber = false;
      }
    public void setWeightInPounds(double new_value)
      {
        flagHasWeightInPounds = true;
        if (new_value < 0)
            throw new Exception("The value for field WeightInPounds of SportsPlayerJSON is less than the lower bound (0) for that field.");
        storeWeightInPounds = new_value;
        textStoreWeightInPounds = "";
      }
    public void setWeightInPoundsText(string new_value)
      {
        flagHasWeightInPounds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field WeightInPounds of SportsPlayerJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field WeightInPounds of SportsPlayerJSON is less than the lower bound (0) for that field.");
        textStoreWeightInPounds = new_value;
      }
    public void unsetWeightInPounds()
      {
        flagHasWeightInPounds = false;
      }
    public void setHeightInInches(double new_value)
      {
        flagHasHeightInInches = true;
        if (new_value < 0)
            throw new Exception("The value for field HeightInInches of SportsPlayerJSON is less than the lower bound (0) for that field.");
        storeHeightInInches = new_value;
        textStoreHeightInInches = "";
      }
    public void setHeightInInchesText(string new_value)
      {
        flagHasHeightInInches = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HeightInInches of SportsPlayerJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HeightInInches of SportsPlayerJSON is less than the lower bound (0) for that field.");
        textStoreHeightInInches = new_value;
      }
    public void unsetHeightInInches()
      {
        flagHasHeightInInches = false;
      }
    public void setPosition(SportsPlayerPositionJSON  new_value)
      {
        if (flagHasPosition)
          {
          }
        flagHasPosition = true;
        storePosition = new_value;
      }
    public void setPosition(SportsPlayerPositionJSON.TypeValue new_value)
      {
        setPosition(new SportsPlayerPositionJSON(new_value));
      }
    public void setPosition(string chars)
      {
        SportsPlayerPositionJSON.TypeValueKnownValues known = SportsPlayerPositionJSON.stringToValue(chars);
        SportsPlayerPositionJSON.TypeValue new_value = new SportsPlayerPositionJSON.TypeValue();
        if (known == SportsPlayerPositionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPosition(new_value);
      }
    public void unsetPosition()
      {
        if (flagHasPosition)
          {
          }
        flagHasPosition = false;
      }
    public void setStatus(SportsPlayerStatusJSON  new_value)
      {
        if (flagHasStatus)
          {
          }
        flagHasStatus = true;
        storeStatus = new_value;
      }
    public void setStatus(SportsPlayerStatusJSON.TypeValue new_value)
      {
        setStatus(new SportsPlayerStatusJSON(new_value));
      }
    public void setStatus(string chars)
      {
        SportsPlayerStatusJSON.TypeValueKnownValues known = SportsPlayerStatusJSON.stringToValue(chars);
        SportsPlayerStatusJSON.TypeValue new_value = new SportsPlayerStatusJSON.TypeValue();
        if (known == SportsPlayerStatusJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setStatus(new_value);
      }
    public void unsetStatus()
      {
        if (flagHasStatus)
          {
          }
        flagHasStatus = false;
      }
    public void setThrowHand(TypeThrowHand new_value)
      {
        flagHasThrowHand = true;
        storeThrowHand = new_value;
      }
    public void setThrowHand(string chars)
      {
        TypeThrowHandKnownValues known = stringToThrowHand(chars);
        TypeThrowHand new_value = new TypeThrowHand();
        if (known == TypeThrowHandKnownValues.ThrowHand__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setThrowHand(new_value);
      }
    public void setThrowHand(TypeThrowHandKnownValues new_value)
      {
        TypeThrowHand new_full_value = new TypeThrowHand();
        Debug.Assert(new_value != TypeThrowHandKnownValues.ThrowHand__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setThrowHand(new_full_value);
      }
    public void unsetThrowHand()
      {
        flagHasThrowHand = false;
      }
    public void setBatHand(TypeBatHand new_value)
      {
        flagHasBatHand = true;
        storeBatHand = new_value;
      }
    public void setBatHand(string chars)
      {
        TypeBatHandKnownValues known = stringToBatHand(chars);
        TypeBatHand new_value = new TypeBatHand();
        if (known == TypeBatHandKnownValues.BatHand__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setBatHand(new_value);
      }
    public void setBatHand(TypeBatHandKnownValues new_value)
      {
        TypeBatHand new_full_value = new TypeBatHand();
        Debug.Assert(new_value != TypeBatHandKnownValues.BatHand__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setBatHand(new_full_value);
      }
    public void unsetBatHand()
      {
        flagHasBatHand = false;
      }
    public void setBirthDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasBirthDate)
          {
          }
        flagHasBirthDate = true;
        storeBirthDate = new_value;
      }
    public void unsetBirthDate()
      {
        if (flagHasBirthDate)
          {
          }
        flagHasBirthDate = false;
      }
    public void setBirthCountry(string new_value)
      {
        flagHasBirthCountry = true;
        storeBirthCountry = new_value;
      }
    public void unsetBirthCountry()
      {
        flagHasBirthCountry = false;
      }
    public void setBirthState(string new_value)
      {
        flagHasBirthState = true;
        storeBirthState = new_value;
      }
    public void unsetBirthState()
      {
        flagHasBirthState = false;
      }
    public void setBirthCity(string new_value)
      {
        flagHasBirthCity = true;
        storeBirthCity = new_value;
      }
    public void unsetBirthCity()
      {
        flagHasBirthCity = false;
      }
    public void setCollege(string new_value)
      {
        flagHasCollege = true;
        storeCollege = new_value;
      }
    public void unsetCollege()
      {
        flagHasCollege = false;
      }
    public void setHighSchool(string new_value)
      {
        flagHasHighSchool = true;
        storeHighSchool = new_value;
      }
    public void unsetHighSchool()
      {
        flagHasHighSchool = false;
      }
    public void setExperienceInYears(BigInteger new_value)
      {
        flagHasExperienceInYears = true;
        if (new_value < 0)
            throw new Exception("The value for field ExperienceInYears of SportsPlayerJSON is less than the lower bound (0) for that field.");
        storeExperienceInYears = new_value;
      }
    public void unsetExperienceInYears()
      {
        flagHasExperienceInYears = false;
      }
    public void setExperienceCollege(TypeExperienceCollege new_value)
      {
        flagHasExperienceCollege = true;
        storeExperienceCollege = new_value;
      }
    public void setExperienceCollege(string chars)
      {
        TypeExperienceCollegeKnownValues known = stringToExperienceCollege(chars);
        TypeExperienceCollege new_value = new TypeExperienceCollege();
        if (known == TypeExperienceCollegeKnownValues.ExperienceCollege__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setExperienceCollege(new_value);
      }
    public void setExperienceCollege(TypeExperienceCollegeKnownValues new_value)
      {
        TypeExperienceCollege new_full_value = new TypeExperienceCollege();
        Debug.Assert(new_value != TypeExperienceCollegeKnownValues.ExperienceCollege__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setExperienceCollege(new_full_value);
      }
    public void unsetExperienceCollege()
      {
        flagHasExperienceCollege = false;
      }
    public void initImages()
      {
        if (flagHasImages)
          {
            for (int num1 = 0; num1 < storeImages.Count; ++num1)
              {
              }
          }
        flagHasImages = true;
        storeImages.Clear();
      }
    public void appendImages(SportsPlayerImageJSON  to_append)
      {
        if (!flagHasImages)
          {
            flagHasImages = true;
            storeImages.Clear();
          }
        Debug.Assert(flagHasImages);
        storeImages.Add(to_append);
      }
    public void unsetImages()
      {
        if (flagHasImages)
          {
            for (int num2 = 0; num2 < storeImages.Count; ++num2)
              {
              }
          }
        flagHasImages = false;
        storeImages.Clear();
      }

    public virtual void extraSportsPlayerAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayerSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayerLookup(key);
        if (old_field == null)
          {
            extraSportsPlayerAppendPair(key, new_component);
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
        if (flagHasFirstName)
          {
            handler.start_pair("FirstName");
            handler.string_value(storeFirstName);
          }
        Debug.Assert(partial_allowed || flagHasLastName);
        if (flagHasLastName)
          {
            handler.start_pair("LastName");
            handler.string_value(storeLastName);
          }
        if (flagHasPreferredName)
          {
            handler.start_pair("PreferredName");
            handler.string_value(storePreferredName);
          }
        Debug.Assert(partial_allowed || flagHasFullName);
        if (flagHasFullName)
          {
            handler.start_pair("FullName");
            handler.string_value(storeFullName);
          }
        if (flagHasTeam)
          {
            handler.start_pair("Team");
            if (partial_allowed)
                storeTeam.write_partial_as_json(handler);
            else
                storeTeam.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasID);
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.string_value(storeID);
          }
        if (flagHasJerseyNumber)
          {
            handler.start_pair("JerseyNumber");
            handler.number_value(storeJerseyNumber);
          }
        if (flagHasWeightInPounds)
          {
            handler.start_pair("WeightInPounds");
            if (textStoreWeightInPounds != "")
                handler.number_value(textStoreWeightInPounds);
            else if (((double)(long)storeWeightInPounds) == storeWeightInPounds)
                handler.number_value((long)storeWeightInPounds);
            else
                handler.number_value(storeWeightInPounds);
          }
        if (flagHasHeightInInches)
          {
            handler.start_pair("HeightInInches");
            if (textStoreHeightInInches != "")
                handler.number_value(textStoreHeightInInches);
            else if (((double)(long)storeHeightInInches) == storeHeightInInches)
                handler.number_value((long)storeHeightInInches);
            else
                handler.number_value(storeHeightInInches);
          }
        if (flagHasPosition)
          {
            handler.start_pair("Position");
            if (partial_allowed)
                storePosition.write_partial_as_json(handler);
            else
                storePosition.write_as_json(handler);
          }
        if (flagHasStatus)
          {
            handler.start_pair("Status");
            if (partial_allowed)
                storeStatus.write_partial_as_json(handler);
            else
                storeStatus.write_as_json(handler);
          }
        if (flagHasThrowHand)
          {
            handler.start_pair("ThrowHand");
            if (storeThrowHand.in_known_list)
              {
                switch (storeThrowHand.list_value)
                  {
                    case TypeThrowHandKnownValues.ThrowHand_Left:
                        handler.string_value("Left");
                        break;
                    case TypeThrowHandKnownValues.ThrowHand_Right:
                        handler.string_value("Right");
                        break;
                    case TypeThrowHandKnownValues.ThrowHand_Both:
                        handler.string_value("Both");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeThrowHand.string_value);
              }
          }
        if (flagHasBatHand)
          {
            handler.start_pair("BatHand");
            if (storeBatHand.in_known_list)
              {
                switch (storeBatHand.list_value)
                  {
                    case TypeBatHandKnownValues.BatHand_Left:
                        handler.string_value("Left");
                        break;
                    case TypeBatHandKnownValues.BatHand_Right:
                        handler.string_value("Right");
                        break;
                    case TypeBatHandKnownValues.BatHand_Both:
                        handler.string_value("Both");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeBatHand.string_value);
              }
          }
        if (flagHasBirthDate)
          {
            handler.start_pair("BirthDate");
            if (partial_allowed)
                storeBirthDate.write_partial_as_json(handler);
            else
                storeBirthDate.write_as_json(handler);
          }
        if (flagHasBirthCountry)
          {
            handler.start_pair("BirthCountry");
            handler.string_value(storeBirthCountry);
          }
        if (flagHasBirthState)
          {
            handler.start_pair("BirthState");
            handler.string_value(storeBirthState);
          }
        if (flagHasBirthCity)
          {
            handler.start_pair("BirthCity");
            handler.string_value(storeBirthCity);
          }
        if (flagHasCollege)
          {
            handler.start_pair("College");
            handler.string_value(storeCollege);
          }
        if (flagHasHighSchool)
          {
            handler.start_pair("HighSchool");
            handler.string_value(storeHighSchool);
          }
        if (flagHasExperienceInYears)
          {
            handler.start_pair("ExperienceInYears");
            handler.number_value(storeExperienceInYears);
          }
        if (flagHasExperienceCollege)
          {
            handler.start_pair("ExperienceCollege");
            if (storeExperienceCollege.in_known_list)
              {
                switch (storeExperienceCollege.list_value)
                  {
                    case TypeExperienceCollegeKnownValues.ExperienceCollege_Freshman:
                        handler.string_value("Freshman");
                        break;
                    case TypeExperienceCollegeKnownValues.ExperienceCollege_Sophomore:
                        handler.string_value("Sophomore");
                        break;
                    case TypeExperienceCollegeKnownValues.ExperienceCollege_Junior:
                        handler.string_value("Junior");
                        break;
                    case TypeExperienceCollegeKnownValues.ExperienceCollege_Senior:
                        handler.string_value("Senior");
                        break;
                    case TypeExperienceCollegeKnownValues.ExperienceCollege_GraduateStudent:
                        handler.string_value("GraduateStudent");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeExperienceCollege.string_value);
              }
          }
        if (flagHasImages)
          {
            handler.start_pair("Images");
            handler.start_array();
            for (int num1 = 0; num1 < storeImages.Count; ++num1)
              {
                if (partial_allowed)
                    storeImages[num1].write_partial_as_json(handler);
                else
                    storeImages[num1].write_as_json(handler);
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
        if (!(hasLastName()))
          {
            return "When parsing the object for %what%, the \"LastName\" field was missing.";
          }
        if (!(hasFullName()))
          {
            return "When parsing the object for %what%, the \"FullName\" field was missing.";
          }
        if (!(hasID()))
          {
            return "When parsing the object for %what%, the \"ID\" field was missing.";
          }
        return null;
      }

    public static SportsPlayerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayer", ignore_extras);
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
    public static SportsPlayerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayer", ignore_extras);
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
    public static SportsPlayerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayerJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayer", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayerJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayerJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayer", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorFirstName;
        private JSONHoldingStringGenerator fieldGeneratorLastName;
        private JSONHoldingStringGenerator fieldGeneratorPreferredName;
        private JSONHoldingStringGenerator fieldGeneratorFullName;
        private SportsTeamNewJSON.HoldingGenerator fieldGeneratorTeam;
        private JSONHoldingStringGenerator fieldGeneratorID;
    private class FieldHoldingGeneratorJerseyNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorJerseyNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorJerseyNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorJerseyNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorJerseyNumber fieldGeneratorJerseyNumber;
        private JSONHoldingNumberTextGenerator fieldGeneratorWeightInPounds;
        private JSONHoldingNumberTextGenerator fieldGeneratorHeightInInches;
        private SportsPlayerPositionJSON.HoldingGenerator fieldGeneratorPosition;
        private SportsPlayerStatusJSON.HoldingGenerator fieldGeneratorStatus;
    private abstract class FieldGeneratorThrowHand : JSONStringGenerator
          {
            protected FieldGeneratorThrowHand(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorThrowHand()
              {
              }
            protected override void handle_result(string result)
              {
                TypeThrowHandKnownValues known = stringToThrowHand(result);
                TypeThrowHand new_value = new TypeThrowHand();
                if (known == TypeThrowHandKnownValues.ThrowHand__none)
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
            protected abstract void handle_result(TypeThrowHand result);
          };
    private class FieldHoldingGeneratorThrowHand : FieldGeneratorThrowHand
  {
    protected override void handle_result(TypeThrowHand result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorThrowHand(String what)
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
    public TypeThrowHand value;
  };
    private class FieldHoldingArrayGeneratorThrowHand : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorThrowHand
      {
        private FieldHoldingArrayGeneratorThrowHand top;

        protected override void handle_result(TypeThrowHand result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorThrowHand init_top)
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
    protected virtual void handle_result(List<TypeThrowHand> result)
      {
      }

    public FieldHoldingArrayGeneratorThrowHand(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeThrowHand>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorThrowHand()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeThrowHand>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeThrowHand> value;
  };
        private FieldHoldingGeneratorThrowHand fieldGeneratorThrowHand;
    private abstract class FieldGeneratorBatHand : JSONStringGenerator
          {
            protected FieldGeneratorBatHand(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorBatHand()
              {
              }
            protected override void handle_result(string result)
              {
                TypeBatHandKnownValues known = stringToBatHand(result);
                TypeBatHand new_value = new TypeBatHand();
                if (known == TypeBatHandKnownValues.BatHand__none)
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
            protected abstract void handle_result(TypeBatHand result);
          };
    private class FieldHoldingGeneratorBatHand : FieldGeneratorBatHand
  {
    protected override void handle_result(TypeBatHand result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorBatHand(String what)
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
    public TypeBatHand value;
  };
    private class FieldHoldingArrayGeneratorBatHand : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorBatHand
      {
        private FieldHoldingArrayGeneratorBatHand top;

        protected override void handle_result(TypeBatHand result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorBatHand init_top)
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
    protected virtual void handle_result(List<TypeBatHand> result)
      {
      }

    public FieldHoldingArrayGeneratorBatHand(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBatHand>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorBatHand()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBatHand>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeBatHand> value;
  };
        private FieldHoldingGeneratorBatHand fieldGeneratorBatHand;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorBirthDate;
        private JSONHoldingStringGenerator fieldGeneratorBirthCountry;
        private JSONHoldingStringGenerator fieldGeneratorBirthState;
        private JSONHoldingStringGenerator fieldGeneratorBirthCity;
        private JSONHoldingStringGenerator fieldGeneratorCollege;
        private JSONHoldingStringGenerator fieldGeneratorHighSchool;
    private class FieldHoldingGeneratorExperienceInYears : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorExperienceInYears(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorExperienceInYears : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorExperienceInYears(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorExperienceInYears fieldGeneratorExperienceInYears;
    private abstract class FieldGeneratorExperienceCollege : JSONStringGenerator
          {
            protected FieldGeneratorExperienceCollege(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorExperienceCollege()
              {
              }
            protected override void handle_result(string result)
              {
                TypeExperienceCollegeKnownValues known = stringToExperienceCollege(result);
                TypeExperienceCollege new_value = new TypeExperienceCollege();
                if (known == TypeExperienceCollegeKnownValues.ExperienceCollege__none)
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
            protected abstract void handle_result(TypeExperienceCollege result);
          };
    private class FieldHoldingGeneratorExperienceCollege : FieldGeneratorExperienceCollege
  {
    protected override void handle_result(TypeExperienceCollege result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorExperienceCollege(String what)
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
    public TypeExperienceCollege value;
  };
    private class FieldHoldingArrayGeneratorExperienceCollege : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorExperienceCollege
      {
        private FieldHoldingArrayGeneratorExperienceCollege top;

        protected override void handle_result(TypeExperienceCollege result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorExperienceCollege init_top)
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
    protected virtual void handle_result(List<TypeExperienceCollege> result)
      {
      }

    public FieldHoldingArrayGeneratorExperienceCollege(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeExperienceCollege>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorExperienceCollege()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeExperienceCollege>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeExperienceCollege> value;
  };
        private FieldHoldingGeneratorExperienceCollege fieldGeneratorExperienceCollege;
        private SportsPlayerImageJSON.HoldingArrayGenerator fieldGeneratorImages;
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
            SportsPlayerJSON result = new SportsPlayerJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayerAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsPlayerJSON result)
          {
            if (fieldGeneratorFirstName.have_value)
              {
                result.setFirstName(fieldGeneratorFirstName.value);
                fieldGeneratorFirstName.have_value = false;
              }
            if (fieldGeneratorLastName.have_value)
              {
                result.setLastName(fieldGeneratorLastName.value);
                fieldGeneratorLastName.have_value = false;
              }
            else if ((!(result.hasLastName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LastName\" field was missing.");
              }
            if (fieldGeneratorPreferredName.have_value)
              {
                result.setPreferredName(fieldGeneratorPreferredName.value);
                fieldGeneratorPreferredName.have_value = false;
              }
            if (fieldGeneratorFullName.have_value)
              {
                result.setFullName(fieldGeneratorFullName.value);
                fieldGeneratorFullName.have_value = false;
              }
            else if ((!(result.hasFullName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FullName\" field was missing.");
              }
            if (fieldGeneratorTeam.have_value)
              {
                result.setTeam(fieldGeneratorTeam.value);
                fieldGeneratorTeam.have_value = false;
              }
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            else if ((!(result.hasID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ID\" field was missing.");
              }
            if (fieldGeneratorJerseyNumber.have_value)
              {
                result.setJerseyNumber(fieldGeneratorJerseyNumber.value);
                fieldGeneratorJerseyNumber.have_value = false;
              }
            if (fieldGeneratorWeightInPounds.have_value)
              {
                result.setWeightInPoundsText(fieldGeneratorWeightInPounds.value);
                fieldGeneratorWeightInPounds.have_value = false;
              }
            if (fieldGeneratorHeightInInches.have_value)
              {
                result.setHeightInInchesText(fieldGeneratorHeightInInches.value);
                fieldGeneratorHeightInInches.have_value = false;
              }
            if (fieldGeneratorPosition.have_value)
              {
                result.setPosition(fieldGeneratorPosition.value);
                fieldGeneratorPosition.have_value = false;
              }
            if (fieldGeneratorStatus.have_value)
              {
                result.setStatus(fieldGeneratorStatus.value);
                fieldGeneratorStatus.have_value = false;
              }
            if (fieldGeneratorThrowHand.have_value)
              {
                result.setThrowHand(fieldGeneratorThrowHand.value);
                fieldGeneratorThrowHand.have_value = false;
              }
            if (fieldGeneratorBatHand.have_value)
              {
                result.setBatHand(fieldGeneratorBatHand.value);
                fieldGeneratorBatHand.have_value = false;
              }
            if (fieldGeneratorBirthDate.have_value)
              {
                result.setBirthDate(fieldGeneratorBirthDate.value);
                fieldGeneratorBirthDate.have_value = false;
              }
            if (fieldGeneratorBirthCountry.have_value)
              {
                result.setBirthCountry(fieldGeneratorBirthCountry.value);
                fieldGeneratorBirthCountry.have_value = false;
              }
            if (fieldGeneratorBirthState.have_value)
              {
                result.setBirthState(fieldGeneratorBirthState.value);
                fieldGeneratorBirthState.have_value = false;
              }
            if (fieldGeneratorBirthCity.have_value)
              {
                result.setBirthCity(fieldGeneratorBirthCity.value);
                fieldGeneratorBirthCity.have_value = false;
              }
            if (fieldGeneratorCollege.have_value)
              {
                result.setCollege(fieldGeneratorCollege.value);
                fieldGeneratorCollege.have_value = false;
              }
            if (fieldGeneratorHighSchool.have_value)
              {
                result.setHighSchool(fieldGeneratorHighSchool.value);
                fieldGeneratorHighSchool.have_value = false;
              }
            if (fieldGeneratorExperienceInYears.have_value)
              {
                result.setExperienceInYears(fieldGeneratorExperienceInYears.value);
                fieldGeneratorExperienceInYears.have_value = false;
              }
            if (fieldGeneratorExperienceCollege.have_value)
              {
                result.setExperienceCollege(fieldGeneratorExperienceCollege.value);
                fieldGeneratorExperienceCollege.have_value = false;
              }
            if (fieldGeneratorImages.have_value)
              {
                result.initImages();
                int count = fieldGeneratorImages.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendImages(fieldGeneratorImages.value[num]);
                  }
                fieldGeneratorImages.value.Clear();
                fieldGeneratorImages.have_value = false;
              }
          }
        protected abstract void handle_result(SportsPlayerJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tHand", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorBatHand;
                            break;
                        case 'i':
                            if (String.Compare(field_name, 2, "rth", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'C':
                                        switch (field_name[6])
                                          {
                                            case 'i':
                                                if ((String.Compare(field_name, 7, "ty", 0, 2, false) == 0) && (field_name.Length == 9))
                                                    return fieldGeneratorBirthCity;
                                                break;
                                            case 'o':
                                                if ((String.Compare(field_name, 7, "untry", 0, 5, false) == 0) && (field_name.Length == 12))
                                                    return fieldGeneratorBirthCountry;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'D':
                                        if ((String.Compare(field_name, 6, "ate", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorBirthDate;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 6, "tate", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorBirthState;
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
                    if ((String.Compare(field_name, 1, "ollege", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorCollege;
                    break;
                case 'E':
                    if (String.Compare(field_name, 1, "xperience", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 11, "ollege", 0, 6, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorExperienceCollege;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 11, "nYears", 0, 6, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorExperienceInYears;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'F':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "rstName", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorFirstName;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "llName", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorFullName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ightInInches", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorHeightInInches;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "ghSchool", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorHighSchool;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'D':
                            if (field_name.Length == 2)
                                return fieldGeneratorID;
                            break;
                        case 'm':
                            if ((String.Compare(field_name, 2, "ages", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorImages;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'J':
                    if ((String.Compare(field_name, 1, "erseyNumber", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorJerseyNumber;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLastName;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 2, "sition", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPosition;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "eferredName", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorPreferredName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tatus", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorStatus;
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "am", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorTeam;
                            break;
                        case 'h':
                            if ((String.Compare(field_name, 2, "rowHand", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorThrowHand;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "eightInPounds", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorWeightInPounds;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFirstName = new JSONHoldingStringGenerator("field \"FirstName\" of the SportsPlayer class");
            fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the SportsPlayer class");
            fieldGeneratorPreferredName = new JSONHoldingStringGenerator("field \"PreferredName\" of the SportsPlayer class");
            fieldGeneratorFullName = new JSONHoldingStringGenerator("field \"FullName\" of the SportsPlayer class");
            fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the SportsPlayer class", ignore_extras);
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the SportsPlayer class");
            fieldGeneratorJerseyNumber = new FieldHoldingGeneratorJerseyNumber("field \"JerseyNumber\" of the SportsPlayer class");
            fieldGeneratorWeightInPounds = new JSONHoldingNumberTextGenerator("field \"WeightInPounds\" of the SportsPlayer class");
            fieldGeneratorHeightInInches = new JSONHoldingNumberTextGenerator("field \"HeightInInches\" of the SportsPlayer class");
            fieldGeneratorPosition = new SportsPlayerPositionJSON.HoldingGenerator("field \"Position\" of the SportsPlayer class", ignore_extras);
            fieldGeneratorStatus = new SportsPlayerStatusJSON.HoldingGenerator("field \"Status\" of the SportsPlayer class", ignore_extras);
            fieldGeneratorThrowHand = new FieldHoldingGeneratorThrowHand("field \"ThrowHand\" of the SportsPlayer class");
            fieldGeneratorBatHand = new FieldHoldingGeneratorBatHand("field \"BatHand\" of the SportsPlayer class");
            fieldGeneratorBirthDate = new DateAndOrTimeJSON.HoldingGenerator("field \"BirthDate\" of the SportsPlayer class", ignore_extras);
            fieldGeneratorBirthCountry = new JSONHoldingStringGenerator("field \"BirthCountry\" of the SportsPlayer class");
            fieldGeneratorBirthState = new JSONHoldingStringGenerator("field \"BirthState\" of the SportsPlayer class");
            fieldGeneratorBirthCity = new JSONHoldingStringGenerator("field \"BirthCity\" of the SportsPlayer class");
            fieldGeneratorCollege = new JSONHoldingStringGenerator("field \"College\" of the SportsPlayer class");
            fieldGeneratorHighSchool = new JSONHoldingStringGenerator("field \"HighSchool\" of the SportsPlayer class");
            fieldGeneratorExperienceInYears = new FieldHoldingGeneratorExperienceInYears("field \"ExperienceInYears\" of the SportsPlayer class");
            fieldGeneratorExperienceCollege = new FieldHoldingGeneratorExperienceCollege("field \"ExperienceCollege\" of the SportsPlayer class");
            fieldGeneratorImages = new SportsPlayerImageJSON.HoldingArrayGenerator("field \"Images\" of the SportsPlayer class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayer class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFirstName = new JSONHoldingStringGenerator("field \"FirstName\" of the SportsPlayer class");
            fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the SportsPlayer class");
            fieldGeneratorPreferredName = new JSONHoldingStringGenerator("field \"PreferredName\" of the SportsPlayer class");
            fieldGeneratorFullName = new JSONHoldingStringGenerator("field \"FullName\" of the SportsPlayer class");
            fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the SportsPlayer class", false);
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the SportsPlayer class");
            fieldGeneratorJerseyNumber = new FieldHoldingGeneratorJerseyNumber("field \"JerseyNumber\" of the SportsPlayer class");
            fieldGeneratorWeightInPounds = new JSONHoldingNumberTextGenerator("field \"WeightInPounds\" of the SportsPlayer class");
            fieldGeneratorHeightInInches = new JSONHoldingNumberTextGenerator("field \"HeightInInches\" of the SportsPlayer class");
            fieldGeneratorPosition = new SportsPlayerPositionJSON.HoldingGenerator("field \"Position\" of the SportsPlayer class", false);
            fieldGeneratorStatus = new SportsPlayerStatusJSON.HoldingGenerator("field \"Status\" of the SportsPlayer class", false);
            fieldGeneratorThrowHand = new FieldHoldingGeneratorThrowHand("field \"ThrowHand\" of the SportsPlayer class");
            fieldGeneratorBatHand = new FieldHoldingGeneratorBatHand("field \"BatHand\" of the SportsPlayer class");
            fieldGeneratorBirthDate = new DateAndOrTimeJSON.HoldingGenerator("field \"BirthDate\" of the SportsPlayer class", false);
            fieldGeneratorBirthCountry = new JSONHoldingStringGenerator("field \"BirthCountry\" of the SportsPlayer class");
            fieldGeneratorBirthState = new JSONHoldingStringGenerator("field \"BirthState\" of the SportsPlayer class");
            fieldGeneratorBirthCity = new JSONHoldingStringGenerator("field \"BirthCity\" of the SportsPlayer class");
            fieldGeneratorCollege = new JSONHoldingStringGenerator("field \"College\" of the SportsPlayer class");
            fieldGeneratorHighSchool = new JSONHoldingStringGenerator("field \"HighSchool\" of the SportsPlayer class");
            fieldGeneratorExperienceInYears = new FieldHoldingGeneratorExperienceInYears("field \"ExperienceInYears\" of the SportsPlayer class");
            fieldGeneratorExperienceCollege = new FieldHoldingGeneratorExperienceCollege("field \"ExperienceCollege\" of the SportsPlayer class");
            fieldGeneratorImages = new SportsPlayerImageJSON.HoldingArrayGenerator("field \"Images\" of the SportsPlayer class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayer class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFirstName.reset();
            fieldGeneratorLastName.reset();
            fieldGeneratorPreferredName.reset();
            fieldGeneratorFullName.reset();
            fieldGeneratorTeam.reset();
            fieldGeneratorID.reset();
            fieldGeneratorJerseyNumber.reset();
            fieldGeneratorWeightInPounds.reset();
            fieldGeneratorHeightInInches.reset();
            fieldGeneratorPosition.reset();
            fieldGeneratorStatus.reset();
            fieldGeneratorThrowHand.reset();
            fieldGeneratorBatHand.reset();
            fieldGeneratorBirthDate.reset();
            fieldGeneratorBirthCountry.reset();
            fieldGeneratorBirthState.reset();
            fieldGeneratorBirthCity.reset();
            fieldGeneratorCollege.reset();
            fieldGeneratorHighSchool.reset();
            fieldGeneratorExperienceInYears.reset();
            fieldGeneratorExperienceCollege.reset();
            fieldGeneratorImages.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTeam.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPosition.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStatus.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBirthDate.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorImages.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTeam.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPosition.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStatus.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBirthDate.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorImages.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsPlayerJSON  result)
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
        public SportsPlayerJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayerJSON  result)
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
    protected virtual void handle_result(List<SportsPlayerJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayerJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayerJSON>();
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
    public List<SportsPlayerJSON> value;
  };
  };
