/* file "NumberGuessQuitGameInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class NumberGuessQuitGameInformationNuggetJSON : NumberGuessInformationNuggetJSON
  {
    public enum TypeDifficultyKnownValues
      {
        Difficulty_Easy,
        Difficulty_Hard,
        Difficulty__none
      };
    public struct TypeDifficulty
      {
        public bool in_known_list;
        public string string_value;
        public TypeDifficultyKnownValues list_value;
      };

    public static TypeDifficultyKnownValues  stringToDifficulty(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "asy", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeDifficultyKnownValues.Difficulty_Easy;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "ard", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeDifficultyKnownValues.Difficulty_Hard;
                break;
            default:
                break;
          }
        return TypeDifficultyKnownValues.Difficulty__none;
      }

    public static string  stringFromDifficulty(TypeDifficultyKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeDifficultyKnownValues.Difficulty_Easy:
                return "Easy";
            case TypeDifficultyKnownValues.Difficulty_Hard:
                return "Hard";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDifficulty;
    private TypeDifficulty storeDifficulty;
    private bool flagHasMinimumPossibleValue;
    private BigInteger storeMinimumPossibleValue;
    private bool flagHasMaximumPossibleValue;
    private BigInteger storeMaximumPossibleValue;
    private bool flagHasGuessesMade;
    private BigInteger storeGuessesMade;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDifficultyToJSON()
      {
        JSONStringValue generated_string_Difficulty;
        if (!(storeDifficulty.in_known_list))
          {
        generated_string_Difficulty = new JSONStringValue(storeDifficulty.string_value);
          }
        else
          {
        switch (storeDifficulty.list_value)
          {
            case TypeDifficultyKnownValues.Difficulty_Easy:
                generated_string_Difficulty = new JSONStringValue("Easy");
                break;
            case TypeDifficultyKnownValues.Difficulty_Hard:
                generated_string_Difficulty = new JSONStringValue("Hard");
                break;
            default:
                Debug.Assert(false);
                generated_string_Difficulty = null;
                break;
          }
          }
        return generated_string_Difficulty;
      }

    private JSONValue  extraMinimumPossibleValueToJSON()
      {
        JSONIntegerValue generated_integer_MinimumPossibleValue = new JSONIntegerValue(storeMinimumPossibleValue);
        return generated_integer_MinimumPossibleValue;
      }

    private JSONValue  extraMaximumPossibleValueToJSON()
      {
        JSONIntegerValue generated_integer_MaximumPossibleValue = new JSONIntegerValue(storeMaximumPossibleValue);
        return generated_integer_MaximumPossibleValue;
      }

    private JSONValue  extraGuessesMadeToJSON()
      {
        JSONIntegerValue generated_integer_GuessesMade = new JSONIntegerValue(storeGuessesMade);
        return generated_integer_GuessesMade;
      }


    private void  fromJSONDifficulty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Difficulty of NumberGuessQuitGameInformationNuggetJSON is not a string.");
        TypeDifficulty the_open_enum = new TypeDifficulty();
        switch (json_string.getData()[0])
          {
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "asy", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDifficultyKnownValues.Difficulty_Easy;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "ard", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDifficultyKnownValues.Difficulty_Hard;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setDifficulty(the_open_enum);
      }


    private void  fromJSONMinimumPossibleValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MinimumPossibleValue of NumberGuessQuitGameInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MinimumPossibleValue of NumberGuessQuitGameInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMinimumPossibleValue(extracted_integer);
      }


    private void  fromJSONMaximumPossibleValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MaximumPossibleValue of NumberGuessQuitGameInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MaximumPossibleValue of NumberGuessQuitGameInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMaximumPossibleValue(extracted_integer);
      }


    private void  fromJSONGuessesMade(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GuessesMade of NumberGuessQuitGameInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GuessesMade of NumberGuessQuitGameInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGuessesMade(extracted_integer);
      }


    public NumberGuessQuitGameInformationNuggetJSON()
      {
        flagHasDifficulty = false;
        flagHasMinimumPossibleValue = false;
        flagHasMaximumPossibleValue = false;
        flagHasGuessesMade = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNumberGuessNuggetKind()
      {
        return "NumberGuessQuitCommand";
      }

    public bool  hasDifficulty()
      {
        return flagHasDifficulty;
      }

    public TypeDifficulty  getDifficulty()
      {
        Debug.Assert(flagHasDifficulty);
        return storeDifficulty;
      }

    public string  getDifficultyAsString()
      {
        TypeDifficulty result = getDifficulty();
        if (result.in_known_list)
            return stringFromDifficulty(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasMinimumPossibleValue()
      {
        return flagHasMinimumPossibleValue;
      }

    public BigInteger  getMinimumPossibleValue()
      {
        Debug.Assert(flagHasMinimumPossibleValue);
        return storeMinimumPossibleValue;
      }

    public bool  hasMaximumPossibleValue()
      {
        return flagHasMaximumPossibleValue;
      }

    public BigInteger  getMaximumPossibleValue()
      {
        Debug.Assert(flagHasMaximumPossibleValue);
        return storeMaximumPossibleValue;
      }

    public bool  hasGuessesMade()
      {
        return flagHasGuessesMade;
      }

    public BigInteger  getGuessesMade()
      {
        Debug.Assert(flagHasGuessesMade);
        return storeGuessesMade;
      }


    public virtual int extraNumberGuessQuitGameInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraNumberGuessQuitGameInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraNumberGuessQuitGameInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraNumberGuessQuitGameInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraNumberGuessInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasDifficulty)
            ++result;
        if (flagHasMinimumPossibleValue)
            ++result;
        if (flagHasMaximumPossibleValue)
            ++result;
        if (flagHasGuessesMade)
            ++result;
        result += extraNumberGuessQuitGameInformationNuggetComponentCount();
        return result;
      }
    public override string extraNumberGuessInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDifficulty)
          {
            if (remainder == 0)
                return "Difficulty";
            --remainder;
          }
        if (flagHasMinimumPossibleValue)
          {
            if (remainder == 0)
                return "MinimumPossibleValue";
            --remainder;
          }
        if (flagHasMaximumPossibleValue)
          {
            if (remainder == 0)
                return "MaximumPossibleValue";
            --remainder;
          }
        if (flagHasGuessesMade)
          {
            if (remainder == 0)
                return "GuessesMade";
            --remainder;
          }
        return extraNumberGuessQuitGameInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraNumberGuessInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDifficulty)
          {
            if (remainder == 0)
                return extraDifficultyToJSON();
            --remainder;
          }
        if (flagHasMinimumPossibleValue)
          {
            if (remainder == 0)
                return extraMinimumPossibleValueToJSON();
            --remainder;
          }
        if (flagHasMaximumPossibleValue)
          {
            if (remainder == 0)
                return extraMaximumPossibleValueToJSON();
            --remainder;
          }
        if (flagHasGuessesMade)
          {
            if (remainder == 0)
                return extraGuessesMadeToJSON();
            --remainder;
          }
        return extraNumberGuessQuitGameInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraNumberGuessInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "ifficulty", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasDifficulty ? extraDifficultyToJSON() : null);
                break;
            case 'G':
                if ((String.Compare(field_name, 1, "uessesMade", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasGuessesMade ? extraGuessesMadeToJSON() : null);
                break;
            case 'M':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "ximumPossibleValue", 0, 18, false) == 0) && (field_name.Length == 20))
                            return (flagHasMaximumPossibleValue ? extraMaximumPossibleValueToJSON() : null);
                        break;
                    case 'i':
                        if ((String.Compare(field_name, 2, "nimumPossibleValue", 0, 18, false) == 0) && (field_name.Length == 20))
                            return (flagHasMinimumPossibleValue ? extraMinimumPossibleValueToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return extraNumberGuessQuitGameInformationNuggetLookup(field_name);
      }

    public void setDifficulty(TypeDifficulty new_value)
      {
        flagHasDifficulty = true;
        storeDifficulty = new_value;
      }
    public void setDifficulty(string chars)
      {
        TypeDifficultyKnownValues known = stringToDifficulty(chars);
        TypeDifficulty new_value = new TypeDifficulty();
        if (known == TypeDifficultyKnownValues.Difficulty__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDifficulty(new_value);
      }
    public void setDifficulty(TypeDifficultyKnownValues new_value)
      {
        TypeDifficulty new_full_value = new TypeDifficulty();
        Debug.Assert(new_value != TypeDifficultyKnownValues.Difficulty__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setDifficulty(new_full_value);
      }
    public void unsetDifficulty()
      {
        flagHasDifficulty = false;
      }
    public void setMinimumPossibleValue(BigInteger new_value)
      {
        flagHasMinimumPossibleValue = true;
        storeMinimumPossibleValue = new_value;
      }
    public void unsetMinimumPossibleValue()
      {
        flagHasMinimumPossibleValue = false;
      }
    public void setMaximumPossibleValue(BigInteger new_value)
      {
        flagHasMaximumPossibleValue = true;
        storeMaximumPossibleValue = new_value;
      }
    public void unsetMaximumPossibleValue()
      {
        flagHasMaximumPossibleValue = false;
      }
    public void setGuessesMade(BigInteger new_value)
      {
        flagHasGuessesMade = true;
        if (new_value < 1)
            throw new Exception("The value for field GuessesMade of NumberGuessQuitGameInformationNuggetJSON is less than the lower bound (1) for that field.");
        storeGuessesMade = new_value;
      }
    public void unsetGuessesMade()
      {
        flagHasGuessesMade = false;
      }

    public virtual void extraNumberGuessQuitGameInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraNumberGuessQuitGameInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraNumberGuessQuitGameInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraNumberGuessQuitGameInformationNuggetAppendPair(key, new_component);
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
    public override void extraNumberGuessInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ifficulty", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONDifficulty(new_component, false);
                    return;
                    }
                break;
            case 'G':
                if ((String.Compare(key, 1, "uessesMade", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONGuessesMade(new_component, false);
                    return;
                    }
                break;
            case 'M':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ximumPossibleValue", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONMaximumPossibleValue(new_component, false);
                            return;
                            }
                        break;
                    case 'i':
                        if ((String.Compare(key, 2, "nimumPossibleValue", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONMinimumPossibleValue(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraNumberGuessQuitGameInformationNuggetAppendPair(key, new_component);
      }
    public override void extraNumberGuessInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ifficulty", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONDifficulty(new_component, false);
                    return;
                    }
                break;
            case 'G':
                if ((String.Compare(key, 1, "uessesMade", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONGuessesMade(new_component, false);
                    return;
                    }
                break;
            case 'M':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ximumPossibleValue", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONMaximumPossibleValue(new_component, false);
                            return;
                            }
                        break;
                    case 'i':
                        if ((String.Compare(key, 2, "nimumPossibleValue", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONMinimumPossibleValue(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraNumberGuessQuitGameInformationNuggetSetField(key, new_component);
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
        if (flagHasDifficulty)
          {
            handler.start_pair("Difficulty");
            if (storeDifficulty.in_known_list)
              {
                switch (storeDifficulty.list_value)
                  {
                    case TypeDifficultyKnownValues.Difficulty_Easy:
                        handler.string_value("Easy");
                        break;
                    case TypeDifficultyKnownValues.Difficulty_Hard:
                        handler.string_value("Hard");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeDifficulty.string_value);
              }
          }
        if (flagHasMinimumPossibleValue)
          {
            handler.start_pair("MinimumPossibleValue");
            handler.number_value(storeMinimumPossibleValue);
          }
        if (flagHasMaximumPossibleValue)
          {
            handler.start_pair("MaximumPossibleValue");
            handler.number_value(storeMaximumPossibleValue);
          }
        if (flagHasGuessesMade)
          {
            handler.start_pair("GuessesMade");
            handler.number_value(storeGuessesMade);
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
        return null;
      }

    public static new NumberGuessQuitGameInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NumberGuessQuitGameInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberGuessQuitGameInformationNugget", ignore_extras);
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
    public static new NumberGuessQuitGameInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new NumberGuessQuitGameInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NumberGuessQuitGameInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberGuessQuitGameInformationNugget", ignore_extras);
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
    public static new NumberGuessQuitGameInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new NumberGuessQuitGameInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        NumberGuessQuitGameInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberGuessQuitGameInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NumberGuessQuitGameInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new NumberGuessQuitGameInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NumberGuessQuitGameInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberGuessQuitGameInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : NumberGuessInformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorDifficulty : JSONStringGenerator
          {
            protected FieldGeneratorDifficulty(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDifficulty()
              {
              }
            protected override void handle_result(string result)
              {
                TypeDifficultyKnownValues known = stringToDifficulty(result);
                TypeDifficulty new_value = new TypeDifficulty();
                if (known == TypeDifficultyKnownValues.Difficulty__none)
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
            protected abstract void handle_result(TypeDifficulty result);
          };
    private class FieldHoldingGeneratorDifficulty : FieldGeneratorDifficulty
  {
    protected override void handle_result(TypeDifficulty result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDifficulty(String what)
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
    public TypeDifficulty value;
  };
    private class FieldHoldingArrayGeneratorDifficulty : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDifficulty
      {
        private FieldHoldingArrayGeneratorDifficulty top;

        protected override void handle_result(TypeDifficulty result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDifficulty init_top)
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
    protected virtual void handle_result(List<TypeDifficulty> result)
      {
      }

    public FieldHoldingArrayGeneratorDifficulty(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDifficulty>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDifficulty()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDifficulty>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDifficulty> value;
  };
        private FieldHoldingGeneratorDifficulty fieldGeneratorDifficulty;
    private class FieldHoldingGeneratorMinimumPossibleValue : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorMinimumPossibleValue(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorMinimumPossibleValue : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorMinimumPossibleValue(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorMinimumPossibleValue fieldGeneratorMinimumPossibleValue;
    private class FieldHoldingGeneratorMaximumPossibleValue : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorMaximumPossibleValue(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorMaximumPossibleValue : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorMaximumPossibleValue(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorMaximumPossibleValue fieldGeneratorMaximumPossibleValue;
    private class FieldHoldingGeneratorGuessesMade : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGuessesMade(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGuessesMade : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGuessesMade(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorGuessesMade fieldGeneratorGuessesMade;
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
            if (!(getNumberGuessInformationNuggetJSONKey().Equals("NumberGuessQuitCommand")))
                throw new Exception("The key field has a value other than `NumberGuessQuitCommand'.");
            NumberGuessQuitGameInformationNuggetJSON result = new NumberGuessQuitGameInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraNumberGuessQuitGameInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(NumberGuessInformationNuggetJSON new_result)
          {
            handle_result((NumberGuessQuitGameInformationNuggetJSON )new_result);
          }
        protected void finish(NumberGuessQuitGameInformationNuggetJSON result)
          {
            if (fieldGeneratorDifficulty.have_value)
              {
                result.setDifficulty(fieldGeneratorDifficulty.value);
                fieldGeneratorDifficulty.have_value = false;
              }
            if (fieldGeneratorMinimumPossibleValue.have_value)
              {
                result.setMinimumPossibleValue(fieldGeneratorMinimumPossibleValue.value);
                fieldGeneratorMinimumPossibleValue.have_value = false;
              }
            if (fieldGeneratorMaximumPossibleValue.have_value)
              {
                result.setMaximumPossibleValue(fieldGeneratorMaximumPossibleValue.value);
                fieldGeneratorMaximumPossibleValue.have_value = false;
              }
            if (fieldGeneratorGuessesMade.have_value)
              {
                result.setGuessesMade(fieldGeneratorGuessesMade.value);
                fieldGeneratorGuessesMade.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(NumberGuessQuitGameInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ifficulty", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorDifficulty;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "uessesMade", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorGuessesMade;
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ximumPossibleValue", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorMaximumPossibleValue;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nimumPossibleValue", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorMinimumPossibleValue;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDifficulty = new FieldHoldingGeneratorDifficulty("field \"Difficulty\" of the NumberGuessQuitGameInformationNugget class");
            fieldGeneratorMinimumPossibleValue = new FieldHoldingGeneratorMinimumPossibleValue("field \"MinimumPossibleValue\" of the NumberGuessQuitGameInformationNugget class");
            fieldGeneratorMaximumPossibleValue = new FieldHoldingGeneratorMaximumPossibleValue("field \"MaximumPossibleValue\" of the NumberGuessQuitGameInformationNugget class");
            fieldGeneratorGuessesMade = new FieldHoldingGeneratorGuessesMade("field \"GuessesMade\" of the NumberGuessQuitGameInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the NumberGuessQuitGameInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDifficulty = new FieldHoldingGeneratorDifficulty("field \"Difficulty\" of the NumberGuessQuitGameInformationNugget class");
            fieldGeneratorMinimumPossibleValue = new FieldHoldingGeneratorMinimumPossibleValue("field \"MinimumPossibleValue\" of the NumberGuessQuitGameInformationNugget class");
            fieldGeneratorMaximumPossibleValue = new FieldHoldingGeneratorMaximumPossibleValue("field \"MaximumPossibleValue\" of the NumberGuessQuitGameInformationNugget class");
            fieldGeneratorGuessesMade = new FieldHoldingGeneratorGuessesMade("field \"GuessesMade\" of the NumberGuessQuitGameInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the NumberGuessQuitGameInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorDifficulty.reset();
            fieldGeneratorMinimumPossibleValue.reset();
            fieldGeneratorMaximumPossibleValue.reset();
            fieldGeneratorGuessesMade.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(NumberGuessQuitGameInformationNuggetJSON  result)
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
        public NumberGuessQuitGameInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NumberGuessQuitGameInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<NumberGuessQuitGameInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NumberGuessQuitGameInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NumberGuessQuitGameInformationNuggetJSON>();
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
    public List<NumberGuessQuitGameInformationNuggetJSON> value;
  };
  };
