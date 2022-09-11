/* file "ChineseZodiacSignJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ChineseZodiacSignJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Rat,
        Value_Ox,
        Value_Tiger,
        Value_Rabbit,
        Value_Dragon,
        Value_Snake,
        Value_Horse,
        Value_Ram,
        Value_Monkey,
        Value_Rooster,
        Value_Dog,
        Value_Pig,
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
            case 'D':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "g", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeValueKnownValues.Value_Dog;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "agon", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Dragon;
                        break;
                    default:
                        break;
                  }
                break;
            case 'H':
                if ((String.Compare(chars, 1, "orse", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValueKnownValues.Value_Horse;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "onkey", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValueKnownValues.Value_Monkey;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "x", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeValueKnownValues.Value_Ox;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "ig", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeValueKnownValues.Value_Pig;
                break;
            case 'R':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'b':
                                if ((String.Compare(chars, 3, "bit", 0, 3, false) == 0) && (chars.Length == 6))
                                    return TypeValueKnownValues.Value_Rabbit;
                                break;
                            case 'm':
                                if (chars.Length == 3)
                                    return TypeValueKnownValues.Value_Ram;
                                break;
                            case 't':
                                if (chars.Length == 3)
                                    return TypeValueKnownValues.Value_Rat;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "oster", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_Rooster;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "nake", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValueKnownValues.Value_Snake;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "iger", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValueKnownValues.Value_Tiger;
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
            case TypeValueKnownValues.Value_Rat:
                return "Rat";
            case TypeValueKnownValues.Value_Ox:
                return "Ox";
            case TypeValueKnownValues.Value_Tiger:
                return "Tiger";
            case TypeValueKnownValues.Value_Rabbit:
                return "Rabbit";
            case TypeValueKnownValues.Value_Dragon:
                return "Dragon";
            case TypeValueKnownValues.Value_Snake:
                return "Snake";
            case TypeValueKnownValues.Value_Horse:
                return "Horse";
            case TypeValueKnownValues.Value_Ram:
                return "Ram";
            case TypeValueKnownValues.Value_Monkey:
                return "Monkey";
            case TypeValueKnownValues.Value_Rooster:
                return "Rooster";
            case TypeValueKnownValues.Value_Dog:
                return "Dog";
            case TypeValueKnownValues.Value_Pig:
                return "Pig";
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
            throw new Exception("The value for field Value of ChineseZodiacSignJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'D':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "g", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Dog;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "agon", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Dragon;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "orse", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Horse;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "onkey", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Monkey;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "x", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Ox;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "ig", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Pig;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'b':
                                if ((String.Compare(json_string.getData(), 3, "bit", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Rabbit;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'm':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Ram;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if (json_string.getData().Length == 3)
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_Rat;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "oster", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Rooster;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "nake", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Snake;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "iger", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Tiger;
                        goto open_enum_is_done;
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


    public ChineseZodiacSignJSON()
      {
        flagHasValue = false;
      }

    public ChineseZodiacSignJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public ChineseZodiacSignJSON(string init_value)
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

    public ChineseZodiacSignJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_Rat:
                    handler.string_value("Rat");
                    break;
                case TypeValueKnownValues.Value_Ox:
                    handler.string_value("Ox");
                    break;
                case TypeValueKnownValues.Value_Tiger:
                    handler.string_value("Tiger");
                    break;
                case TypeValueKnownValues.Value_Rabbit:
                    handler.string_value("Rabbit");
                    break;
                case TypeValueKnownValues.Value_Dragon:
                    handler.string_value("Dragon");
                    break;
                case TypeValueKnownValues.Value_Snake:
                    handler.string_value("Snake");
                    break;
                case TypeValueKnownValues.Value_Horse:
                    handler.string_value("Horse");
                    break;
                case TypeValueKnownValues.Value_Ram:
                    handler.string_value("Ram");
                    break;
                case TypeValueKnownValues.Value_Monkey:
                    handler.string_value("Monkey");
                    break;
                case TypeValueKnownValues.Value_Rooster:
                    handler.string_value("Rooster");
                    break;
                case TypeValueKnownValues.Value_Dog:
                    handler.string_value("Dog");
                    break;
                case TypeValueKnownValues.Value_Pig:
                    handler.string_value("Pig");
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
                case TypeValueKnownValues.Value_Rat:
                    handler.string_value("Rat");
                    break;
                case TypeValueKnownValues.Value_Ox:
                    handler.string_value("Ox");
                    break;
                case TypeValueKnownValues.Value_Tiger:
                    handler.string_value("Tiger");
                    break;
                case TypeValueKnownValues.Value_Rabbit:
                    handler.string_value("Rabbit");
                    break;
                case TypeValueKnownValues.Value_Dragon:
                    handler.string_value("Dragon");
                    break;
                case TypeValueKnownValues.Value_Snake:
                    handler.string_value("Snake");
                    break;
                case TypeValueKnownValues.Value_Horse:
                    handler.string_value("Horse");
                    break;
                case TypeValueKnownValues.Value_Ram:
                    handler.string_value("Ram");
                    break;
                case TypeValueKnownValues.Value_Monkey:
                    handler.string_value("Monkey");
                    break;
                case TypeValueKnownValues.Value_Rooster:
                    handler.string_value("Rooster");
                    break;
                case TypeValueKnownValues.Value_Dog:
                    handler.string_value("Dog");
                    break;
                case TypeValueKnownValues.Value_Pig:
                    handler.string_value("Pig");
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

    public static ChineseZodiacSignJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseZodiacSignJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSign", ignore_extras);
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
    public static ChineseZodiacSignJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChineseZodiacSignJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChineseZodiacSignJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSign", ignore_extras);
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
    public static ChineseZodiacSignJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChineseZodiacSignJSON from_text(string text, bool ignore_extras)
      {
        ChineseZodiacSignJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSign", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChineseZodiacSignJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ChineseZodiacSignJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChineseZodiacSignJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChineseZodiacSign", ignore_extras);
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
            ChineseZodiacSignJSON result = new ChineseZodiacSignJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(ChineseZodiacSignJSON new_result);
        public Generator(bool ignore_extras) : base("Type ChineseZodiacSign")
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
        protected override void handle_result(ChineseZodiacSignJSON  result)
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
        public ChineseZodiacSignJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChineseZodiacSignJSON  result)
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
    protected virtual void handle_result(List<ChineseZodiacSignJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChineseZodiacSignJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChineseZodiacSignJSON>();
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
    public List<ChineseZodiacSignJSON> value;
  };
  };
