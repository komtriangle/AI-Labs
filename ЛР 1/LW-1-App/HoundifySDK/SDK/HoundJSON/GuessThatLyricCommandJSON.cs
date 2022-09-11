/* file "GuessThatLyricCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class GuessThatLyricCommandJSON : MusicCommandJSON
  {
    private bool flagHasDecade;
    private BigInteger storeDecade;
    private bool flagHasGuessedCorrectly;
    private BigInteger storeGuessedCorrectly;
    private bool flagHasHintsRemaining;
    private sbyte storeHintsRemaining;
    private bool flagHasDifficulty;
    private string storeDifficulty;
    private bool flagHasCorrectAnswer;
    private string storeCorrectAnswer;
    private bool flagHasQuestion;
    private string storeQuestion;
    private bool flagHasSoundhoundLyricID;
    private string storeSoundhoundLyricID;
    private bool flagHasGTLSoundhoundTrackID;
    private string storeGTLSoundhoundTrackID;
    private bool flagHasCorrectTitle;
    private string storeCorrectTitle;
    private bool flagHasCorrectArtist;
    private string storeCorrectArtist;
    private bool flagHasPlayerLost;
    private bool storePlayerLost;
    private bool flagHasGuessedTracksList;
    private List< MusicTrackJSON  > storeGuessedTracksList;


    private JSONValue  extraDecadeToJSON()
      {
        JSONIntegerValue generated_integer_Decade = new JSONIntegerValue(storeDecade);
        return generated_integer_Decade;
      }

    private JSONValue  extraGuessedCorrectlyToJSON()
      {
        JSONIntegerValue generated_integer_GuessedCorrectly = new JSONIntegerValue(storeGuessedCorrectly);
        return generated_integer_GuessedCorrectly;
      }

    private JSONValue  extraHintsRemainingToJSON()
      {
        JSONIntegerValue generated_integer_HintsRemaining = new JSONIntegerValue(storeHintsRemaining);
        return generated_integer_HintsRemaining;
      }

    private JSONValue  extraDifficultyToJSON()
      {
        JSONStringValue generated_string_Difficulty = new JSONStringValue(storeDifficulty);
        return generated_string_Difficulty;
      }

    private JSONValue  extraCorrectAnswerToJSON()
      {
        JSONStringValue generated_string_CorrectAnswer = new JSONStringValue(storeCorrectAnswer);
        return generated_string_CorrectAnswer;
      }

    private JSONValue  extraQuestionToJSON()
      {
        JSONStringValue generated_string_Question = new JSONStringValue(storeQuestion);
        return generated_string_Question;
      }

    private JSONValue  extraSoundhoundLyricIDToJSON()
      {
        JSONStringValue generated_string_SoundhoundLyricID = new JSONStringValue(storeSoundhoundLyricID);
        return generated_string_SoundhoundLyricID;
      }

    private JSONValue  extraGTLSoundhoundTrackIDToJSON()
      {
        JSONStringValue generated_string_GTLSoundhoundTrackID = new JSONStringValue(storeGTLSoundhoundTrackID);
        return generated_string_GTLSoundhoundTrackID;
      }

    private JSONValue  extraCorrectTitleToJSON()
      {
        JSONStringValue generated_string_CorrectTitle = new JSONStringValue(storeCorrectTitle);
        return generated_string_CorrectTitle;
      }

    private JSONValue  extraCorrectArtistToJSON()
      {
        JSONStringValue generated_string_CorrectArtist = new JSONStringValue(storeCorrectArtist);
        return generated_string_CorrectArtist;
      }

    private JSONValue  extraPlayerLostToJSON()
      {
        JSONValue generated_boolean_PlayerLost = (storePlayerLost ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_PlayerLost;
      }

    private JSONValue  extraGuessedTracksListToJSON()
      {
        JSONArrayValue generated_array_1_GuessedTracksList = new JSONArrayValue();
        for (int num1 = 0; num1 < storeGuessedTracksList.Count; ++num1)
          {
            JSONValueHandler handler_GuessedTracksList = new JSONValueHandler();
            storeGuessedTracksList[num1].write_as_json(handler_GuessedTracksList);
            generated_array_1_GuessedTracksList.appendComponent(handler_GuessedTracksList.result);
          }
        return generated_array_1_GuessedTracksList;
      }


    private void  fromJSONDecade(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Decade of GuessThatLyricCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Decade of GuessThatLyricCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDecade(extracted_integer);
      }


    private void  fromJSONGuessedCorrectly(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GuessedCorrectly of GuessThatLyricCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GuessedCorrectly of GuessThatLyricCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGuessedCorrectly(extracted_integer);
      }


    private void  fromJSONHintsRemaining(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field HintsRemaining of GuessThatLyricCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field HintsRemaining of GuessThatLyricCommandJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setHintsRemaining(extracted_integer);
      }


    private void  fromJSONDifficulty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Difficulty of GuessThatLyricCommandJSON is not a string.");
        setDifficulty(json_string.getData());
      }


    private void  fromJSONCorrectAnswer(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CorrectAnswer of GuessThatLyricCommandJSON is not a string.");
        setCorrectAnswer(json_string.getData());
      }


    private void  fromJSONQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Question of GuessThatLyricCommandJSON is not a string.");
        setQuestion(json_string.getData());
      }


    private void  fromJSONSoundhoundLyricID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SoundhoundLyricID of GuessThatLyricCommandJSON is not a string.");
        setSoundhoundLyricID(json_string.getData());
      }


    private void  fromJSONGTLSoundhoundTrackID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field GTLSoundhoundTrackID of GuessThatLyricCommandJSON is not a string.");
        setGTLSoundhoundTrackID(json_string.getData());
      }


    private void  fromJSONCorrectTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CorrectTitle of GuessThatLyricCommandJSON is not a string.");
        setCorrectTitle(json_string.getData());
      }


    private void  fromJSONCorrectArtist(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CorrectArtist of GuessThatLyricCommandJSON is not a string.");
        setCorrectArtist(json_string.getData());
      }


    private void  fromJSONPlayerLost(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PlayerLost of GuessThatLyricCommandJSON is not true for false.");
              }
          }
        setPlayerLost(the_bool);
      }


    private void  fromJSONGuessedTracksList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GuessedTracksList of GuessThatLyricCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MusicTrackJSON  > vector_GuessedTracksList1 = new List< MusicTrackJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicTrackJSON convert_classy = MusicTrackJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_GuessedTracksList1.Add(convert_classy);
          }
        initGuessedTracksList();
        for (int num1 = 0; num1 < vector_GuessedTracksList1.Count; ++num1)
            appendGuessedTracksList(vector_GuessedTracksList1[num1]);
        for (int num1 = 0; num1 < vector_GuessedTracksList1.Count; ++num1)
          {
          }
      }


    public GuessThatLyricCommandJSON()
      {
        flagHasDecade = false;
        flagHasGuessedCorrectly = false;
        flagHasHintsRemaining = false;
        flagHasDifficulty = false;
        flagHasCorrectAnswer = false;
        flagHasQuestion = false;
        flagHasSoundhoundLyricID = false;
        flagHasGTLSoundhoundTrackID = false;
        flagHasCorrectTitle = false;
        flagHasCorrectArtist = false;
        flagHasPlayerLost = false;
        flagHasGuessedTracksList = false;
        storeGuessedTracksList = new List< MusicTrackJSON  >();
      }

    public override string  getMusicCommandKind()
      {
        return "GuessThatLyricCommand";
      }

    public abstract string getGuessThatLyricCommandKind();
    public bool  hasDecade()
      {
        return flagHasDecade;
      }

    public BigInteger  getDecade()
      {
        Debug.Assert(flagHasDecade);
        return storeDecade;
      }

    public bool  hasGuessedCorrectly()
      {
        return flagHasGuessedCorrectly;
      }

    public BigInteger  getGuessedCorrectly()
      {
        Debug.Assert(flagHasGuessedCorrectly);
        return storeGuessedCorrectly;
      }

    public bool  hasHintsRemaining()
      {
        return flagHasHintsRemaining;
      }

    public sbyte  getHintsRemaining()
      {
        Debug.Assert(flagHasHintsRemaining);
        return storeHintsRemaining;
      }

    public bool  hasDifficulty()
      {
        return flagHasDifficulty;
      }

    public string  getDifficulty()
      {
        Debug.Assert(flagHasDifficulty);
        return storeDifficulty;
      }

    public bool  hasCorrectAnswer()
      {
        return flagHasCorrectAnswer;
      }

    public string  getCorrectAnswer()
      {
        Debug.Assert(flagHasCorrectAnswer);
        return storeCorrectAnswer;
      }

    public bool  hasQuestion()
      {
        return flagHasQuestion;
      }

    public string  getQuestion()
      {
        Debug.Assert(flagHasQuestion);
        return storeQuestion;
      }

    public bool  hasSoundhoundLyricID()
      {
        return flagHasSoundhoundLyricID;
      }

    public string  getSoundhoundLyricID()
      {
        Debug.Assert(flagHasSoundhoundLyricID);
        return storeSoundhoundLyricID;
      }

    public bool  hasGTLSoundhoundTrackID()
      {
        return flagHasGTLSoundhoundTrackID;
      }

    public string  getGTLSoundhoundTrackID()
      {
        Debug.Assert(flagHasGTLSoundhoundTrackID);
        return storeGTLSoundhoundTrackID;
      }

    public bool  hasCorrectTitle()
      {
        return flagHasCorrectTitle;
      }

    public string  getCorrectTitle()
      {
        Debug.Assert(flagHasCorrectTitle);
        return storeCorrectTitle;
      }

    public bool  hasCorrectArtist()
      {
        return flagHasCorrectArtist;
      }

    public string  getCorrectArtist()
      {
        Debug.Assert(flagHasCorrectArtist);
        return storeCorrectArtist;
      }

    public bool  hasPlayerLost()
      {
        return flagHasPlayerLost;
      }

    public bool  getPlayerLost()
      {
        Debug.Assert(flagHasPlayerLost);
        return storePlayerLost;
      }

    public bool  hasGuessedTracksList()
      {
        return flagHasGuessedTracksList;
      }

    public int  countOfGuessedTracksList()
      {
        Debug.Assert(flagHasGuessedTracksList);
        return storeGuessedTracksList.Count;
      }

    public MusicTrackJSON   elementOfGuessedTracksList(int element_num)
      {
        Debug.Assert(flagHasGuessedTracksList);
        return storeGuessedTracksList[element_num];
      }

    public List< MusicTrackJSON  >  getGuessedTracksList()
      {
        Debug.Assert(flagHasGuessedTracksList);
        return storeGuessedTracksList;
      }


    public abstract int extraGuessThatLyricCommandComponentCount();
    public abstract string extraGuessThatLyricCommandComponentKey(int component_num);
    public abstract JSONValue extraGuessThatLyricCommandComponentValue(int component_num);
    public abstract JSONValue extraGuessThatLyricCommandLookup(string field_name);
    public override int extraMusicCommandComponentCount()
      {
        int result = 1;
        if (flagHasDecade)
            ++result;
        if (flagHasGuessedCorrectly)
            ++result;
        if (flagHasHintsRemaining)
            ++result;
        if (flagHasDifficulty)
            ++result;
        if (flagHasCorrectAnswer)
            ++result;
        if (flagHasQuestion)
            ++result;
        if (flagHasSoundhoundLyricID)
            ++result;
        if (flagHasGTLSoundhoundTrackID)
            ++result;
        if (flagHasCorrectTitle)
            ++result;
        if (flagHasCorrectArtist)
            ++result;
        if (flagHasPlayerLost)
            ++result;
        if (flagHasGuessedTracksList)
            ++result;
        result += extraGuessThatLyricCommandComponentCount();
        return result;
      }
    public override string extraMusicCommandComponentKey(int component_num)
      {
        if (component_num == 0)
            return "GuessThatLyricCommandKind";
        int remainder = (component_num - 1);
        if (flagHasDecade)
          {
            if (remainder == 0)
                return "Decade";
            --remainder;
          }
        if (flagHasGuessedCorrectly)
          {
            if (remainder == 0)
                return "GuessedCorrectly";
            --remainder;
          }
        if (flagHasHintsRemaining)
          {
            if (remainder == 0)
                return "HintsRemaining";
            --remainder;
          }
        if (flagHasDifficulty)
          {
            if (remainder == 0)
                return "Difficulty";
            --remainder;
          }
        if (flagHasCorrectAnswer)
          {
            if (remainder == 0)
                return "CorrectAnswer";
            --remainder;
          }
        if (flagHasQuestion)
          {
            if (remainder == 0)
                return "Question";
            --remainder;
          }
        if (flagHasSoundhoundLyricID)
          {
            if (remainder == 0)
                return "SoundhoundLyricID";
            --remainder;
          }
        if (flagHasGTLSoundhoundTrackID)
          {
            if (remainder == 0)
                return "GTLSoundhoundTrackID";
            --remainder;
          }
        if (flagHasCorrectTitle)
          {
            if (remainder == 0)
                return "CorrectTitle";
            --remainder;
          }
        if (flagHasCorrectArtist)
          {
            if (remainder == 0)
                return "CorrectArtist";
            --remainder;
          }
        if (flagHasPlayerLost)
          {
            if (remainder == 0)
                return "PlayerLost";
            --remainder;
          }
        if (flagHasGuessedTracksList)
          {
            if (remainder == 0)
                return "GuessedTracksList";
            --remainder;
          }
        return extraGuessThatLyricCommandComponentKey(remainder);
      }
    public override JSONValue extraMusicCommandComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getGuessThatLyricCommandKind());
        int remainder = (component_num - 1);
        if (flagHasDecade)
          {
            if (remainder == 0)
                return extraDecadeToJSON();
            --remainder;
          }
        if (flagHasGuessedCorrectly)
          {
            if (remainder == 0)
                return extraGuessedCorrectlyToJSON();
            --remainder;
          }
        if (flagHasHintsRemaining)
          {
            if (remainder == 0)
                return extraHintsRemainingToJSON();
            --remainder;
          }
        if (flagHasDifficulty)
          {
            if (remainder == 0)
                return extraDifficultyToJSON();
            --remainder;
          }
        if (flagHasCorrectAnswer)
          {
            if (remainder == 0)
                return extraCorrectAnswerToJSON();
            --remainder;
          }
        if (flagHasQuestion)
          {
            if (remainder == 0)
                return extraQuestionToJSON();
            --remainder;
          }
        if (flagHasSoundhoundLyricID)
          {
            if (remainder == 0)
                return extraSoundhoundLyricIDToJSON();
            --remainder;
          }
        if (flagHasGTLSoundhoundTrackID)
          {
            if (remainder == 0)
                return extraGTLSoundhoundTrackIDToJSON();
            --remainder;
          }
        if (flagHasCorrectTitle)
          {
            if (remainder == 0)
                return extraCorrectTitleToJSON();
            --remainder;
          }
        if (flagHasCorrectArtist)
          {
            if (remainder == 0)
                return extraCorrectArtistToJSON();
            --remainder;
          }
        if (flagHasPlayerLost)
          {
            if (remainder == 0)
                return extraPlayerLostToJSON();
            --remainder;
          }
        if (flagHasGuessedTracksList)
          {
            if (remainder == 0)
                return extraGuessedTracksListToJSON();
            --remainder;
          }
        return extraGuessThatLyricCommandComponentValue(remainder);
      }
    public override JSONValue extraMusicCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if (String.Compare(field_name, 1, "orrect", 0, 6, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'A':
                            switch (field_name[8])
                              {
                                case 'n':
                                    if ((String.Compare(field_name, 9, "swer", 0, 4, false) == 0) && (field_name.Length == 13))
                                        return (flagHasCorrectAnswer ? extraCorrectAnswerToJSON() : null);
                                    break;
                                case 'r':
                                    if ((String.Compare(field_name, 9, "tist", 0, 4, false) == 0) && (field_name.Length == 13))
                                        return (flagHasCorrectArtist ? extraCorrectArtistToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 8, "itle", 0, 4, false) == 0) && (field_name.Length == 12))
                                return (flagHasCorrectTitle ? extraCorrectTitleToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                switch (field_name[1])
                  {
                    case 'e':
                        if ((String.Compare(field_name, 2, "cade", 0, 4, false) == 0) && (field_name.Length == 6))
                            return (flagHasDecade ? extraDecadeToJSON() : null);
                        break;
                    case 'i':
                        if ((String.Compare(field_name, 2, "fficulty", 0, 8, false) == 0) && (field_name.Length == 10))
                            return (flagHasDifficulty ? extraDifficultyToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                switch (field_name[1])
                  {
                    case 'T':
                        if ((String.Compare(field_name, 2, "LSoundhoundTrackID", 0, 18, false) == 0) && (field_name.Length == 20))
                            return (flagHasGTLSoundhoundTrackID ? extraGTLSoundhoundTrackIDToJSON() : null);
                        break;
                    case 'u':
                        if (String.Compare(field_name, 2, "ess", 0, 3, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'T':
                                    if ((String.Compare(field_name, 6, "hatLyricCommandKind", 0, 19, false) == 0) && (field_name.Length == 25))
                                        return new JSONStringValue(getGuessThatLyricCommandKind());
                                    break;
                                case 'e':
                                    if (String.Compare(field_name, 6, "d", 0, 1, false) == 0)
                                      {
                                        switch (field_name[7])
                                          {
                                            case 'C':
                                                if ((String.Compare(field_name, 8, "orrectly", 0, 8, false) == 0) && (field_name.Length == 16))
                                                    return (flagHasGuessedCorrectly ? extraGuessedCorrectlyToJSON() : null);
                                                break;
                                            case 'T':
                                                if ((String.Compare(field_name, 8, "racksList", 0, 9, false) == 0) && (field_name.Length == 17))
                                                    return (flagHasGuessedTracksList ? extraGuessedTracksListToJSON() : null);
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
            case 'H':
                if ((String.Compare(field_name, 1, "intsRemaining", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasHintsRemaining ? extraHintsRemainingToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "layerLost", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasPlayerLost ? extraPlayerLostToJSON() : null);
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "uestion", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasQuestion ? extraQuestionToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "oundhoundLyricID", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasSoundhoundLyricID ? extraSoundhoundLyricIDToJSON() : null);
                break;
            default:
                break;
          }
        return extraGuessThatLyricCommandLookup(field_name);
      }

    public void setDecade(BigInteger new_value)
      {
        flagHasDecade = true;
        if (new_value < 0)
            throw new Exception("The value for field Decade of GuessThatLyricCommandJSON is less than the lower bound (0) for that field.");
        storeDecade = new_value;
      }
    public virtual void unsetDecade()
      {
        flagHasDecade = false;
      }
    public void setGuessedCorrectly(BigInteger new_value)
      {
        flagHasGuessedCorrectly = true;
        if (new_value < 0)
            throw new Exception("The value for field GuessedCorrectly of GuessThatLyricCommandJSON is less than the lower bound (0) for that field.");
        storeGuessedCorrectly = new_value;
      }
    public virtual void unsetGuessedCorrectly()
      {
        flagHasGuessedCorrectly = false;
      }
    public void setHintsRemaining(sbyte new_value)
      {
        flagHasHintsRemaining = true;
        if (new_value < 0)
            throw new Exception("The value for field HintsRemaining of GuessThatLyricCommandJSON is less than the lower bound (0) for that field.");
        if (new_value > 4)
            throw new Exception("The value for field HintsRemaining of GuessThatLyricCommandJSON is greater than the upper bound (4) for that field.");
        storeHintsRemaining = new_value;
      }
    public virtual void unsetHintsRemaining()
      {
        flagHasHintsRemaining = false;
      }
    public void setDifficulty(string new_value)
      {
        flagHasDifficulty = true;
        storeDifficulty = new_value;
      }
    public virtual void unsetDifficulty()
      {
        flagHasDifficulty = false;
      }
    public void setCorrectAnswer(string new_value)
      {
        flagHasCorrectAnswer = true;
        storeCorrectAnswer = new_value;
      }
    public virtual void unsetCorrectAnswer()
      {
        flagHasCorrectAnswer = false;
      }
    public void setQuestion(string new_value)
      {
        flagHasQuestion = true;
        storeQuestion = new_value;
      }
    public virtual void unsetQuestion()
      {
        flagHasQuestion = false;
      }
    public void setSoundhoundLyricID(string new_value)
      {
        flagHasSoundhoundLyricID = true;
        storeSoundhoundLyricID = new_value;
      }
    public virtual void unsetSoundhoundLyricID()
      {
        flagHasSoundhoundLyricID = false;
      }
    public void setGTLSoundhoundTrackID(string new_value)
      {
        flagHasGTLSoundhoundTrackID = true;
        storeGTLSoundhoundTrackID = new_value;
      }
    public virtual void unsetGTLSoundhoundTrackID()
      {
        flagHasGTLSoundhoundTrackID = false;
      }
    public void setCorrectTitle(string new_value)
      {
        flagHasCorrectTitle = true;
        storeCorrectTitle = new_value;
      }
    public virtual void unsetCorrectTitle()
      {
        flagHasCorrectTitle = false;
      }
    public void setCorrectArtist(string new_value)
      {
        flagHasCorrectArtist = true;
        storeCorrectArtist = new_value;
      }
    public virtual void unsetCorrectArtist()
      {
        flagHasCorrectArtist = false;
      }
    public void setPlayerLost(bool new_value)
      {
        flagHasPlayerLost = true;
        storePlayerLost = new_value;
      }
    public virtual void unsetPlayerLost()
      {
        flagHasPlayerLost = false;
      }
    public void initGuessedTracksList()
      {
        if (flagHasGuessedTracksList)
          {
            for (int num1 = 0; num1 < storeGuessedTracksList.Count; ++num1)
              {
              }
          }
        flagHasGuessedTracksList = true;
        storeGuessedTracksList.Clear();
      }
    public void appendGuessedTracksList(MusicTrackJSON  to_append)
      {
        if (!flagHasGuessedTracksList)
          {
            flagHasGuessedTracksList = true;
            storeGuessedTracksList.Clear();
          }
        Debug.Assert(flagHasGuessedTracksList);
        storeGuessedTracksList.Add(to_append);
      }
    public void unsetGuessedTracksList()
      {
        if (flagHasGuessedTracksList)
          {
            for (int num2 = 0; num2 < storeGuessedTracksList.Count; ++num2)
              {
              }
          }
        flagHasGuessedTracksList = false;
        storeGuessedTracksList.Clear();
      }

    public abstract void extraGuessThatLyricCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraGuessThatLyricCommandSetField(string key, JSONValue new_component);
    public override void extraMusicCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if (String.Compare(key, 1, "orrect", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'A':
                            switch (key[8])
                              {
                                case 'n':
                                    if ((String.Compare(key, 9, "swer", 0, 4, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONCorrectAnswer(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'r':
                                    if ((String.Compare(key, 9, "tist", 0, 4, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONCorrectArtist(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'T':
                            if ((String.Compare(key, 8, "itle", 0, 4, false) == 0) && (key.Length == 12))
                                {
                                fromJSONCorrectTitle(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "cade", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONDecade(new_component, false);
                            return;
                            }
                        break;
                    case 'i':
                        if ((String.Compare(key, 2, "fficulty", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONDifficulty(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                switch (key[1])
                  {
                    case 'T':
                        if ((String.Compare(key, 2, "LSoundhoundTrackID", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONGTLSoundhoundTrackID(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if (String.Compare(key, 2, "ess", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'T':
                                    if ((String.Compare(key, 6, "hatLyricCommandKind", 0, 19, false) == 0) && (key.Length == 25))
                                        return;
                                    break;
                                case 'e':
                                    if (String.Compare(key, 6, "d", 0, 1, false) == 0)
                                      {
                                        switch (key[7])
                                          {
                                            case 'C':
                                                if ((String.Compare(key, 8, "orrectly", 0, 8, false) == 0) && (key.Length == 16))
                                                    {
                                                    fromJSONGuessedCorrectly(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'T':
                                                if ((String.Compare(key, 8, "racksList", 0, 9, false) == 0) && (key.Length == 17))
                                                    {
                                                    fromJSONGuessedTracksList(new_component, false);
                                                    return;
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
                break;
            case 'H':
                if ((String.Compare(key, 1, "intsRemaining", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONHintsRemaining(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "layerLost", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONPlayerLost(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "uestion", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONQuestion(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "oundhoundLyricID", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONSoundhoundLyricID(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGuessThatLyricCommandAppendPair(key, new_component);
      }
    public override void extraMusicCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if (String.Compare(key, 1, "orrect", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'A':
                            switch (key[8])
                              {
                                case 'n':
                                    if ((String.Compare(key, 9, "swer", 0, 4, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONCorrectAnswer(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'r':
                                    if ((String.Compare(key, 9, "tist", 0, 4, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONCorrectArtist(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'T':
                            if ((String.Compare(key, 8, "itle", 0, 4, false) == 0) && (key.Length == 12))
                                {
                                fromJSONCorrectTitle(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "cade", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONDecade(new_component, false);
                            return;
                            }
                        break;
                    case 'i':
                        if ((String.Compare(key, 2, "fficulty", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONDifficulty(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                switch (key[1])
                  {
                    case 'T':
                        if ((String.Compare(key, 2, "LSoundhoundTrackID", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONGTLSoundhoundTrackID(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if (String.Compare(key, 2, "ess", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'T':
                                    if ((String.Compare(key, 6, "hatLyricCommandKind", 0, 19, false) == 0) && (key.Length == 25))
                                        return;
                                    break;
                                case 'e':
                                    if (String.Compare(key, 6, "d", 0, 1, false) == 0)
                                      {
                                        switch (key[7])
                                          {
                                            case 'C':
                                                if ((String.Compare(key, 8, "orrectly", 0, 8, false) == 0) && (key.Length == 16))
                                                    {
                                                    fromJSONGuessedCorrectly(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'T':
                                                if ((String.Compare(key, 8, "racksList", 0, 9, false) == 0) && (key.Length == 17))
                                                    {
                                                    fromJSONGuessedTracksList(new_component, false);
                                                    return;
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
                break;
            case 'H':
                if ((String.Compare(key, 1, "intsRemaining", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONHintsRemaining(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "layerLost", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONPlayerLost(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "uestion", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONQuestion(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "oundhoundLyricID", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONSoundhoundLyricID(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGuessThatLyricCommandSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("GuessThatLyricCommandKind", getGuessThatLyricCommandKind());
        writeFieldDecade(handler);
        writeFieldGuessedCorrectly(handler);
        writeFieldHintsRemaining(handler);
        writeFieldDifficulty(handler);
        writeFieldCorrectAnswer(handler);
        writeFieldQuestion(handler);
        writeFieldSoundhoundLyricID(handler);
        writeFieldGTLSoundhoundTrackID(handler);
        writeFieldCorrectTitle(handler);
        writeFieldCorrectArtist(handler);
        writeFieldPlayerLost(handler);
        writeFieldGuessedTracksList(handler);
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual void writeFieldDecade(JSONHandler handler)
      {
        Debug.Assert(flagHasDecade);
        handler.start_pair("Decade");
        handler.number_value(storeDecade);
      }
    public virtual void writeFieldGuessedCorrectly(JSONHandler handler)
      {
        Debug.Assert(flagHasGuessedCorrectly);
        handler.start_pair("GuessedCorrectly");
        handler.number_value(storeGuessedCorrectly);
      }
    public virtual void writeFieldHintsRemaining(JSONHandler handler)
      {
        Debug.Assert(flagHasHintsRemaining);
        handler.start_pair("HintsRemaining");
        handler.number_value(storeHintsRemaining);
      }
    public virtual void writeFieldDifficulty(JSONHandler handler)
      {
        Debug.Assert(flagHasDifficulty);
        handler.start_pair("Difficulty");
        handler.string_value(storeDifficulty);
      }
    public virtual void writeFieldCorrectAnswer(JSONHandler handler)
      {
        Debug.Assert(flagHasCorrectAnswer);
        handler.start_pair("CorrectAnswer");
        handler.string_value(storeCorrectAnswer);
      }
    public virtual void writeFieldQuestion(JSONHandler handler)
      {
        Debug.Assert(flagHasQuestion);
        handler.start_pair("Question");
        handler.string_value(storeQuestion);
      }
    public virtual void writeFieldSoundhoundLyricID(JSONHandler handler)
      {
        Debug.Assert(flagHasSoundhoundLyricID);
        handler.start_pair("SoundhoundLyricID");
        handler.string_value(storeSoundhoundLyricID);
      }
    public virtual void writeFieldGTLSoundhoundTrackID(JSONHandler handler)
      {
        Debug.Assert(flagHasGTLSoundhoundTrackID);
        handler.start_pair("GTLSoundhoundTrackID");
        handler.string_value(storeGTLSoundhoundTrackID);
      }
    public virtual void writeFieldCorrectTitle(JSONHandler handler)
      {
        Debug.Assert(flagHasCorrectTitle);
        handler.start_pair("CorrectTitle");
        handler.string_value(storeCorrectTitle);
      }
    public virtual void writeFieldCorrectArtist(JSONHandler handler)
      {
        Debug.Assert(flagHasCorrectArtist);
        handler.start_pair("CorrectArtist");
        handler.string_value(storeCorrectArtist);
      }
    public virtual void writeFieldPlayerLost(JSONHandler handler)
      {
        if (flagHasPlayerLost)
          {
            handler.start_pair("PlayerLost");
            handler.boolean_value(storePlayerLost);
          }
      }
    public virtual void writeFieldGuessedTracksList(JSONHandler handler)
      {
        if (flagHasGuessedTracksList)
          {
            handler.start_pair("GuessedTracksList");
            handler.start_array();
            for (int num1 = 0; num1 < storeGuessedTracksList.Count; ++num1)
              {
                storeGuessedTracksList[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasDecade()))
          {
            return "When parsing the object for %what%, the \"Decade\" field was missing.";
          }
        if (!(hasGuessedCorrectly()))
          {
            return "When parsing the object for %what%, the \"GuessedCorrectly\" field was missing.";
          }
        if (!(hasHintsRemaining()))
          {
            return "When parsing the object for %what%, the \"HintsRemaining\" field was missing.";
          }
        if (!(hasDifficulty()))
          {
            return "When parsing the object for %what%, the \"Difficulty\" field was missing.";
          }
        if (!(hasCorrectAnswer()))
          {
            return "When parsing the object for %what%, the \"CorrectAnswer\" field was missing.";
          }
        if (!(hasQuestion()))
          {
            return "When parsing the object for %what%, the \"Question\" field was missing.";
          }
        if (!(hasSoundhoundLyricID()))
          {
            return "When parsing the object for %what%, the \"SoundhoundLyricID\" field was missing.";
          }
        if (!(hasGTLSoundhoundTrackID()))
          {
            return "When parsing the object for %what%, the \"GTLSoundhoundTrackID\" field was missing.";
          }
        if (!(hasCorrectTitle()))
          {
            return "When parsing the object for %what%, the \"CorrectTitle\" field was missing.";
          }
        if (!(hasCorrectArtist()))
          {
            return "When parsing the object for %what%, the \"CorrectArtist\" field was missing.";
          }
        return null;
      }

    public static new GuessThatLyricCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GuessThatLyricCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GuessThatLyricCommand", ignore_extras);
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
    public static new GuessThatLyricCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GuessThatLyricCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GuessThatLyricCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GuessThatLyricCommand", ignore_extras);
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
    public static new GuessThatLyricCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GuessThatLyricCommandJSON from_text(string text, bool ignore_extras)
      {
        GuessThatLyricCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GuessThatLyricCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GuessThatLyricCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new GuessThatLyricCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GuessThatLyricCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GuessThatLyricCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MusicCommandJSON.Generator
      {
    private class FieldHoldingGeneratorDecade : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDecade(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDecade : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDecade(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorDecade fieldGeneratorDecade;
    private class FieldHoldingGeneratorGuessedCorrectly : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGuessedCorrectly(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGuessedCorrectly : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGuessedCorrectly(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorGuessedCorrectly fieldGeneratorGuessedCorrectly;
    private class FieldHoldingGeneratorHintsRemaining : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorHintsRemaining(String what) : base(what, 0, 4)
              {
              }
          };
    private class FieldHoldingArrayGeneratorHintsRemaining : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorHintsRemaining(String what) : base(what, 0, 4)
              {
              }
          };
        private FieldHoldingGeneratorHintsRemaining fieldGeneratorHintsRemaining;
        private JSONHoldingStringGenerator fieldGeneratorDifficulty;
        private JSONHoldingStringGenerator fieldGeneratorCorrectAnswer;
        private JSONHoldingStringGenerator fieldGeneratorQuestion;
        private JSONHoldingStringGenerator fieldGeneratorSoundhoundLyricID;
        private JSONHoldingStringGenerator fieldGeneratorGTLSoundhoundTrackID;
        private JSONHoldingStringGenerator fieldGeneratorCorrectTitle;
        private JSONHoldingStringGenerator fieldGeneratorCorrectArtist;
        private JSONHoldingBooleanGenerator fieldGeneratorPlayerLost;
        private MusicTrackJSON.HoldingArrayGenerator fieldGeneratorGuessedTracksList;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `GuessThatLyricCommandKind' field is missing.");
            if (!(getMusicCommandJSONKey().Equals("GuessThatLyricCommand")))
                throw new Exception("The key field has a value other than `GuessThatLyricCommand'.");
            GuessThatLyricCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGuessThatLyricCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getGuessThatLyricCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `GuessThatLyricCommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(MusicCommandJSON new_result)
          {
            handle_result((GuessThatLyricCommandJSON )new_result);
          }
        protected void finish(GuessThatLyricCommandJSON result)
          {
            if (fieldGeneratorDecade.have_value)
              {
                result.setDecade(fieldGeneratorDecade.value);
                fieldGeneratorDecade.have_value = false;
              }
            else if ((!(result.hasDecade())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Decade\" field was missing.");
              }
            if (fieldGeneratorGuessedCorrectly.have_value)
              {
                result.setGuessedCorrectly(fieldGeneratorGuessedCorrectly.value);
                fieldGeneratorGuessedCorrectly.have_value = false;
              }
            else if ((!(result.hasGuessedCorrectly())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"GuessedCorrectly\" field was missing.");
              }
            if (fieldGeneratorHintsRemaining.have_value)
              {
                result.setHintsRemaining((sbyte)(fieldGeneratorHintsRemaining.value));
                fieldGeneratorHintsRemaining.have_value = false;
              }
            else if ((!(result.hasHintsRemaining())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HintsRemaining\" field was missing.");
              }
            if (fieldGeneratorDifficulty.have_value)
              {
                result.setDifficulty(fieldGeneratorDifficulty.value);
                fieldGeneratorDifficulty.have_value = false;
              }
            else if ((!(result.hasDifficulty())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Difficulty\" field was missing.");
              }
            if (fieldGeneratorCorrectAnswer.have_value)
              {
                result.setCorrectAnswer(fieldGeneratorCorrectAnswer.value);
                fieldGeneratorCorrectAnswer.have_value = false;
              }
            else if ((!(result.hasCorrectAnswer())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CorrectAnswer\" field was missing.");
              }
            if (fieldGeneratorQuestion.have_value)
              {
                result.setQuestion(fieldGeneratorQuestion.value);
                fieldGeneratorQuestion.have_value = false;
              }
            else if ((!(result.hasQuestion())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Question\" field was missing.");
              }
            if (fieldGeneratorSoundhoundLyricID.have_value)
              {
                result.setSoundhoundLyricID(fieldGeneratorSoundhoundLyricID.value);
                fieldGeneratorSoundhoundLyricID.have_value = false;
              }
            else if ((!(result.hasSoundhoundLyricID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SoundhoundLyricID\" field was missing.");
              }
            if (fieldGeneratorGTLSoundhoundTrackID.have_value)
              {
                result.setGTLSoundhoundTrackID(fieldGeneratorGTLSoundhoundTrackID.value);
                fieldGeneratorGTLSoundhoundTrackID.have_value = false;
              }
            else if ((!(result.hasGTLSoundhoundTrackID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"GTLSoundhoundTrackID\" field was missing.");
              }
            if (fieldGeneratorCorrectTitle.have_value)
              {
                result.setCorrectTitle(fieldGeneratorCorrectTitle.value);
                fieldGeneratorCorrectTitle.have_value = false;
              }
            else if ((!(result.hasCorrectTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CorrectTitle\" field was missing.");
              }
            if (fieldGeneratorCorrectArtist.have_value)
              {
                result.setCorrectArtist(fieldGeneratorCorrectArtist.value);
                fieldGeneratorCorrectArtist.have_value = false;
              }
            else if ((!(result.hasCorrectArtist())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CorrectArtist\" field was missing.");
              }
            if (fieldGeneratorPlayerLost.have_value)
              {
                result.setPlayerLost(fieldGeneratorPlayerLost.value);
                fieldGeneratorPlayerLost.have_value = false;
              }
            if (fieldGeneratorGuessedTracksList.have_value)
              {
                result.initGuessedTracksList();
                int count = fieldGeneratorGuessedTracksList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGuessedTracksList(fieldGeneratorGuessedTracksList.value[num]);
                  }
                fieldGeneratorGuessedTracksList.value.Clear();
                fieldGeneratorGuessedTracksList.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(GuessThatLyricCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "orrect", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'A':
                                switch (field_name[8])
                                  {
                                    case 'n':
                                        if ((String.Compare(field_name, 9, "swer", 0, 4, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorCorrectAnswer;
                                        break;
                                    case 'r':
                                        if ((String.Compare(field_name, 9, "tist", 0, 4, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorCorrectArtist;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "itle", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorCorrectTitle;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "cade", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorDecade;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "fficulty", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorDifficulty;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'G':
                    switch (field_name[1])
                      {
                        case 'T':
                            if ((String.Compare(field_name, 2, "LSoundhoundTrackID", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorGTLSoundhoundTrackID;
                            break;
                        case 'u':
                            if (String.Compare(field_name, 2, "ess", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'T':
                                        if ((String.Compare(field_name, 6, "hatLyricCommandKind", 0, 19, false) == 0) && (field_name.Length == 25))
                                            {
                                            keyGenerator.reset();
                                            return keyGenerator;
                                            }
                                        break;
                                    case 'e':
                                        if (String.Compare(field_name, 6, "d", 0, 1, false) == 0)
                                          {
                                            switch (field_name[7])
                                              {
                                                case 'C':
                                                    if ((String.Compare(field_name, 8, "orrectly", 0, 8, false) == 0) && (field_name.Length == 16))
                                                        return fieldGeneratorGuessedCorrectly;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(field_name, 8, "racksList", 0, 9, false) == 0) && (field_name.Length == 17))
                                                        return fieldGeneratorGuessedTracksList;
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
                case 'H':
                    if ((String.Compare(field_name, 1, "intsRemaining", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorHintsRemaining;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "layerLost", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPlayerLost;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uestion", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorQuestion;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "oundhoundLyricID", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorSoundhoundLyricID;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDecade = new FieldHoldingGeneratorDecade("field \"Decade\" of the GuessThatLyricCommand class");
            fieldGeneratorGuessedCorrectly = new FieldHoldingGeneratorGuessedCorrectly("field \"GuessedCorrectly\" of the GuessThatLyricCommand class");
            fieldGeneratorHintsRemaining = new FieldHoldingGeneratorHintsRemaining("field \"HintsRemaining\" of the GuessThatLyricCommand class");
            fieldGeneratorDifficulty = new JSONHoldingStringGenerator("field \"Difficulty\" of the GuessThatLyricCommand class");
            fieldGeneratorCorrectAnswer = new JSONHoldingStringGenerator("field \"CorrectAnswer\" of the GuessThatLyricCommand class");
            fieldGeneratorQuestion = new JSONHoldingStringGenerator("field \"Question\" of the GuessThatLyricCommand class");
            fieldGeneratorSoundhoundLyricID = new JSONHoldingStringGenerator("field \"SoundhoundLyricID\" of the GuessThatLyricCommand class");
            fieldGeneratorGTLSoundhoundTrackID = new JSONHoldingStringGenerator("field \"GTLSoundhoundTrackID\" of the GuessThatLyricCommand class");
            fieldGeneratorCorrectTitle = new JSONHoldingStringGenerator("field \"CorrectTitle\" of the GuessThatLyricCommand class");
            fieldGeneratorCorrectArtist = new JSONHoldingStringGenerator("field \"CorrectArtist\" of the GuessThatLyricCommand class");
            fieldGeneratorPlayerLost = new JSONHoldingBooleanGenerator("field \"PlayerLost\" of the GuessThatLyricCommand class");
            fieldGeneratorGuessedTracksList = new MusicTrackJSON.HoldingArrayGenerator("field \"GuessedTracksList\" of the GuessThatLyricCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"GuessThatLyricCommandKind\" of the GuessThatLyricCommand class");
            set_what("the GuessThatLyricCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDecade = new FieldHoldingGeneratorDecade("field \"Decade\" of the GuessThatLyricCommand class");
            fieldGeneratorGuessedCorrectly = new FieldHoldingGeneratorGuessedCorrectly("field \"GuessedCorrectly\" of the GuessThatLyricCommand class");
            fieldGeneratorHintsRemaining = new FieldHoldingGeneratorHintsRemaining("field \"HintsRemaining\" of the GuessThatLyricCommand class");
            fieldGeneratorDifficulty = new JSONHoldingStringGenerator("field \"Difficulty\" of the GuessThatLyricCommand class");
            fieldGeneratorCorrectAnswer = new JSONHoldingStringGenerator("field \"CorrectAnswer\" of the GuessThatLyricCommand class");
            fieldGeneratorQuestion = new JSONHoldingStringGenerator("field \"Question\" of the GuessThatLyricCommand class");
            fieldGeneratorSoundhoundLyricID = new JSONHoldingStringGenerator("field \"SoundhoundLyricID\" of the GuessThatLyricCommand class");
            fieldGeneratorGTLSoundhoundTrackID = new JSONHoldingStringGenerator("field \"GTLSoundhoundTrackID\" of the GuessThatLyricCommand class");
            fieldGeneratorCorrectTitle = new JSONHoldingStringGenerator("field \"CorrectTitle\" of the GuessThatLyricCommand class");
            fieldGeneratorCorrectArtist = new JSONHoldingStringGenerator("field \"CorrectArtist\" of the GuessThatLyricCommand class");
            fieldGeneratorPlayerLost = new JSONHoldingBooleanGenerator("field \"PlayerLost\" of the GuessThatLyricCommand class");
            fieldGeneratorGuessedTracksList = new MusicTrackJSON.HoldingArrayGenerator("field \"GuessedTracksList\" of the GuessThatLyricCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"GuessThatLyricCommandKind\" of the GuessThatLyricCommand class");
            set_what("the GuessThatLyricCommand class");
          }

        public override void reset()
          {
            fieldGeneratorDecade.reset();
            fieldGeneratorGuessedCorrectly.reset();
            fieldGeneratorHintsRemaining.reset();
            fieldGeneratorDifficulty.reset();
            fieldGeneratorCorrectAnswer.reset();
            fieldGeneratorQuestion.reset();
            fieldGeneratorSoundhoundLyricID.reset();
            fieldGeneratorGTLSoundhoundTrackID.reset();
            fieldGeneratorCorrectTitle.reset();
            fieldGeneratorCorrectArtist.reset();
            fieldGeneratorPlayerLost.reset();
            fieldGeneratorGuessedTracksList.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(GuessThatLyricCommandJSON  result)
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
        public GuessThatLyricCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GuessThatLyricCommandJSON  result)
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
    protected virtual void handle_result(List<GuessThatLyricCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GuessThatLyricCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GuessThatLyricCommandJSON>();
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
    public List<GuessThatLyricCommandJSON> value;
  };
    class GenericGuessThatLyricCommandJSON : GuessThatLyricCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericGuessThatLyricCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getGuessThatLyricCommandKind()  { return key; }
        public override int extraGuessThatLyricCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraGuessThatLyricCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraGuessThatLyricCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraGuessThatLyricCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraGuessThatLyricCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraGuessThatLyricCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraGuessThatLyricCommandLookup(key);
            if (old_field == null)
              {
                extraGuessThatLyricCommandAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new GuessThatLyricCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "GuessThatLyric", 0, 14, false) == 0)
      {
        switch (key[14])
          {
            case 'G':
                if ((String.Compare(key, 15, "uessCommand", 0, 11, false) == 0) && (key.Length == 26))
                    return new GuessThatLyricGuessCommandJSON();
                break;
            case 'H':
                if ((String.Compare(key, 15, "intCommand", 0, 10, false) == 0) && (key.Length == 25))
                    return new GuessThatLyricHintCommandJSON();
                break;
            case 'N':
                if ((String.Compare(key, 15, "otUnderstoodCommand", 0, 19, false) == 0) && (key.Length == 34))
                    return new GuessThatLyricNotUnderstoodCommandJSON();
                break;
            case 'S':
                if ((String.Compare(key, 15, "tartGameCommand", 0, 15, false) == 0) && (key.Length == 30))
                    return new GuessThatLyricStartGameCommandJSON();
                break;
            default:
                break;
          }
      }

        return new GenericGuessThatLyricCommandJSON(key);
      }
  };
