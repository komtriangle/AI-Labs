/* file "ChemicalElementSeriesNameJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ChemicalElementSeriesNameJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Nonmetals,
        Value_Noble_x20_gases,
        Value_Alkali_x20_metals,
        Value_Alkaline_x20_earth_x20_metals,
        Value_Metalloids,
        Value_Halogens,
        Value_Poor_x20_metals,
        Value_Transition_x20_Metals,
        Value_Lanthanides,
        Value_Actinides,
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
            case 'A':
                switch (chars[1])
                  {
                    case 'c':
                        if ((String.Compare(chars, 2, "tinides", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_Actinides;
                        break;
                    case 'l':
                        if (String.Compare(chars, 2, "kali", 0, 4, false) == 0)
                          {
                            switch (chars[6])
                              {
                                case ' ':
                                    if ((String.Compare(chars, 7, "metals", 0, 6, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_Alkali_x20_metals;
                                    break;
                                case 'n':
                                    if ((String.Compare(chars, 7, "e earth metals", 0, 14, false) == 0) && (chars.Length == 21))
                                        return TypeValueKnownValues.Value_Alkaline_x20_earth_x20_metals;
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
                if ((String.Compare(chars, 1, "alogens", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeValueKnownValues.Value_Halogens;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "anthanides", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeValueKnownValues.Value_Lanthanides;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "etalloids", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeValueKnownValues.Value_Metalloids;
                break;
            case 'N':
                if (String.Compare(chars, 1, "o", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'b':
                            if ((String.Compare(chars, 3, "le gases", 0, 8, false) == 0) && (chars.Length == 11))
                                return TypeValueKnownValues.Value_Noble_x20_gases;
                            break;
                        case 'n':
                            if ((String.Compare(chars, 3, "metals", 0, 6, false) == 0) && (chars.Length == 9))
                                return TypeValueKnownValues.Value_Nonmetals;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if ((String.Compare(chars, 1, "oor metals", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeValueKnownValues.Value_Poor_x20_metals;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ransition Metals", 0, 16, false) == 0) && (chars.Length == 17))
                    return TypeValueKnownValues.Value_Transition_x20_Metals;
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
            case TypeValueKnownValues.Value_Nonmetals:
                return "Nonmetals";
            case TypeValueKnownValues.Value_Noble_x20_gases:
                return "Noble gases";
            case TypeValueKnownValues.Value_Alkali_x20_metals:
                return "Alkali metals";
            case TypeValueKnownValues.Value_Alkaline_x20_earth_x20_metals:
                return "Alkaline earth metals";
            case TypeValueKnownValues.Value_Metalloids:
                return "Metalloids";
            case TypeValueKnownValues.Value_Halogens:
                return "Halogens";
            case TypeValueKnownValues.Value_Poor_x20_metals:
                return "Poor metals";
            case TypeValueKnownValues.Value_Transition_x20_Metals:
                return "Transition Metals";
            case TypeValueKnownValues.Value_Lanthanides:
                return "Lanthanides";
            case TypeValueKnownValues.Value_Actinides:
                return "Actinides";
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
            throw new Exception("The value for field Value of ChemicalElementSeriesNameJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'c':
                        if ((String.Compare(json_string.getData(), 2, "tinides", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Actinides;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'l':
                        if (String.Compare(json_string.getData(), 2, "kali", 0, 4, false) == 0)
                          {
                            switch (json_string.getData()[6])
                              {
                                case ' ':
                                    if ((String.Compare(json_string.getData(), 7, "metals", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Alkali_x20_metals;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'n':
                                    if ((String.Compare(json_string.getData(), 7, "e earth metals", 0, 14, false) == 0) && (json_string.getData().Length == 21))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_Alkaline_x20_earth_x20_metals;
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
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "alogens", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Halogens;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "anthanides", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Lanthanides;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "etalloids", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Metalloids;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'b':
                            if ((String.Compare(json_string.getData(), 3, "le gases", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Noble_x20_gases;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'n':
                            if ((String.Compare(json_string.getData(), 3, "metals", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Nonmetals;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "oor metals", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Poor_x20_metals;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "ransition Metals", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Transition_x20_Metals;
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


    public ChemicalElementSeriesNameJSON()
      {
        flagHasValue = false;
      }

    public ChemicalElementSeriesNameJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public ChemicalElementSeriesNameJSON(string init_value)
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

    public ChemicalElementSeriesNameJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_Nonmetals:
                    handler.string_value("Nonmetals");
                    break;
                case TypeValueKnownValues.Value_Noble_x20_gases:
                    handler.string_value("Noble gases");
                    break;
                case TypeValueKnownValues.Value_Alkali_x20_metals:
                    handler.string_value("Alkali metals");
                    break;
                case TypeValueKnownValues.Value_Alkaline_x20_earth_x20_metals:
                    handler.string_value("Alkaline earth metals");
                    break;
                case TypeValueKnownValues.Value_Metalloids:
                    handler.string_value("Metalloids");
                    break;
                case TypeValueKnownValues.Value_Halogens:
                    handler.string_value("Halogens");
                    break;
                case TypeValueKnownValues.Value_Poor_x20_metals:
                    handler.string_value("Poor metals");
                    break;
                case TypeValueKnownValues.Value_Transition_x20_Metals:
                    handler.string_value("Transition Metals");
                    break;
                case TypeValueKnownValues.Value_Lanthanides:
                    handler.string_value("Lanthanides");
                    break;
                case TypeValueKnownValues.Value_Actinides:
                    handler.string_value("Actinides");
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
                case TypeValueKnownValues.Value_Nonmetals:
                    handler.string_value("Nonmetals");
                    break;
                case TypeValueKnownValues.Value_Noble_x20_gases:
                    handler.string_value("Noble gases");
                    break;
                case TypeValueKnownValues.Value_Alkali_x20_metals:
                    handler.string_value("Alkali metals");
                    break;
                case TypeValueKnownValues.Value_Alkaline_x20_earth_x20_metals:
                    handler.string_value("Alkaline earth metals");
                    break;
                case TypeValueKnownValues.Value_Metalloids:
                    handler.string_value("Metalloids");
                    break;
                case TypeValueKnownValues.Value_Halogens:
                    handler.string_value("Halogens");
                    break;
                case TypeValueKnownValues.Value_Poor_x20_metals:
                    handler.string_value("Poor metals");
                    break;
                case TypeValueKnownValues.Value_Transition_x20_Metals:
                    handler.string_value("Transition Metals");
                    break;
                case TypeValueKnownValues.Value_Lanthanides:
                    handler.string_value("Lanthanides");
                    break;
                case TypeValueKnownValues.Value_Actinides:
                    handler.string_value("Actinides");
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

    public static ChemicalElementSeriesNameJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChemicalElementSeriesNameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementSeriesName", ignore_extras);
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
    public static ChemicalElementSeriesNameJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChemicalElementSeriesNameJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChemicalElementSeriesNameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementSeriesName", ignore_extras);
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
    public static ChemicalElementSeriesNameJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChemicalElementSeriesNameJSON from_text(string text, bool ignore_extras)
      {
        ChemicalElementSeriesNameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementSeriesName", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChemicalElementSeriesNameJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ChemicalElementSeriesNameJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChemicalElementSeriesNameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementSeriesName", ignore_extras);
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
            ChemicalElementSeriesNameJSON result = new ChemicalElementSeriesNameJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(ChemicalElementSeriesNameJSON new_result);
        public Generator(bool ignore_extras) : base("Type ChemicalElementSeriesName")
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
        protected override void handle_result(ChemicalElementSeriesNameJSON  result)
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
        public ChemicalElementSeriesNameJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChemicalElementSeriesNameJSON  result)
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
    protected virtual void handle_result(List<ChemicalElementSeriesNameJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChemicalElementSeriesNameJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChemicalElementSeriesNameJSON>();
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
    public List<ChemicalElementSeriesNameJSON> value;
  };
  };
