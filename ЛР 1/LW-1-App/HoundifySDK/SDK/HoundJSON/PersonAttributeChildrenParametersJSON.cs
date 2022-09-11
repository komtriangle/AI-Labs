/* file "PersonAttributeChildrenParametersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class PersonAttributeChildrenParametersJSON : JSONBase
  {
    public enum TypeSymbolicOrdinal
      {
        SymbolicOrdinal_Oldest,
        SymbolicOrdinal_Youngest,
        SymbolicOrdinal_Middle
      };

    public static TypeSymbolicOrdinal  stringToSymbolicOrdinal(string chars)
      {
        switch (chars[0])
          {
            case 'M':
                if ((String.Compare(chars, 1, "iddle", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeSymbolicOrdinal.SymbolicOrdinal_Middle;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "ldest", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeSymbolicOrdinal.SymbolicOrdinal_Oldest;
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "oungest", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSymbolicOrdinal.SymbolicOrdinal_Youngest;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `SymbolicOrdinal' is not one of the legal values.");
      }

    public static string  stringFromSymbolicOrdinal(TypeSymbolicOrdinal the_enum)
      {
        switch (the_enum)
          {
            case TypeSymbolicOrdinal.SymbolicOrdinal_Oldest:
                return "Oldest";
            case TypeSymbolicOrdinal.SymbolicOrdinal_Youngest:
                return "Youngest";
            case TypeSymbolicOrdinal.SymbolicOrdinal_Middle:
                return "Middle";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeSex
      {
        Sex_Female,
        Sex_Male
      };

    public static TypeSex  stringToSex(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "emale", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeSex.Sex_Female;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "ale", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeSex.Sex_Male;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Sex' is not one of the legal values.");
      }

    public static string  stringFromSex(TypeSex the_enum)
      {
        switch (the_enum)
          {
            case TypeSex.Sex_Female:
                return "Female";
            case TypeSex.Sex_Male:
                return "Male";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasOrdinal;
    private BigInteger storeOrdinal;
    private bool flagHasSymbolicOrdinal;
    private TypeSymbolicOrdinal storeSymbolicOrdinal;
    private bool flagHasSex;
    private TypeSex storeSex;
    private bool flagHasBornDateRange;
    private SetOfTimeJSON  storeBornDateRange;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONOrdinal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Ordinal of PersonAttributeChildrenParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Ordinal of PersonAttributeChildrenParametersJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setOrdinal(extracted_integer);
      }


    private void  fromJSONSymbolicOrdinal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SymbolicOrdinal of PersonAttributeChildrenParametersJSON is not a string.");
        TypeSymbolicOrdinal the_enum;
        switch (json_string.getData()[0])
          {
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "iddle", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeSymbolicOrdinal.SymbolicOrdinal_Middle;
                        goto enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "ldest", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeSymbolicOrdinal.SymbolicOrdinal_Oldest;
                        goto enum_is_done;
                      }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "oungest", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeSymbolicOrdinal.SymbolicOrdinal_Youngest;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field SymbolicOrdinal of PersonAttributeChildrenParametersJSON is not one of the legal strings.");
      enum_is_done:;
        setSymbolicOrdinal(the_enum);
      }


    private void  fromJSONSex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Sex of PersonAttributeChildrenParametersJSON is not a string.");
        TypeSex the_enum;
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "emale", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeSex.Sex_Female;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ale", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeSex.Sex_Male;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Sex of PersonAttributeChildrenParametersJSON is not one of the legal strings.");
      enum_is_done:;
        setSex(the_enum);
      }


    private void  fromJSONBornDateRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SetOfTimeJSON convert_classy = SetOfTimeJSON.from_json(json_value, ignore_extras, true);
        setBornDateRange(convert_classy);
      }


    public PersonAttributeChildrenParametersJSON()
      {
        flagHasOrdinal = false;
        flagHasSymbolicOrdinal = false;
        flagHasSex = false;
        flagHasBornDateRange = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasOrdinal()
      {
        return flagHasOrdinal;
      }

    public BigInteger  getOrdinal()
      {
        Debug.Assert(flagHasOrdinal);
        return storeOrdinal;
      }

    public bool  hasSymbolicOrdinal()
      {
        return flagHasSymbolicOrdinal;
      }

    public TypeSymbolicOrdinal  getSymbolicOrdinal()
      {
        Debug.Assert(flagHasSymbolicOrdinal);
        return storeSymbolicOrdinal;
      }

    public string  getSymbolicOrdinalAsString()
      {
        return stringFromSymbolicOrdinal(getSymbolicOrdinal());
      }

    public bool  hasSex()
      {
        return flagHasSex;
      }

    public TypeSex  getSex()
      {
        Debug.Assert(flagHasSex);
        return storeSex;
      }

    public string  getSexAsString()
      {
        return stringFromSex(getSex());
      }

    public bool  hasBornDateRange()
      {
        return flagHasBornDateRange;
      }

    public SetOfTimeJSON   getBornDateRange()
      {
        Debug.Assert(flagHasBornDateRange);
        return storeBornDateRange;
      }


    public virtual int extraPersonAttributeChildrenParametersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPersonAttributeChildrenParametersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPersonAttributeChildrenParametersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPersonAttributeChildrenParametersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setOrdinal(BigInteger new_value)
      {
        flagHasOrdinal = true;
        if (new_value < 1)
            throw new Exception("The value for field Ordinal of PersonAttributeChildrenParametersJSON is less than the lower bound (1) for that field.");
        storeOrdinal = new_value;
      }
    public void unsetOrdinal()
      {
        flagHasOrdinal = false;
      }
    public void setSymbolicOrdinal(TypeSymbolicOrdinal new_value)
      {
        flagHasSymbolicOrdinal = true;
        storeSymbolicOrdinal = new_value;
      }
    public void setSymbolicOrdinal(string chars)
      {
        setSymbolicOrdinal(stringToSymbolicOrdinal(chars));
      }
    public void unsetSymbolicOrdinal()
      {
        flagHasSymbolicOrdinal = false;
      }
    public void setSex(TypeSex new_value)
      {
        flagHasSex = true;
        storeSex = new_value;
      }
    public void setSex(string chars)
      {
        setSex(stringToSex(chars));
      }
    public void unsetSex()
      {
        flagHasSex = false;
      }
    public void setBornDateRange(SetOfTimeJSON  new_value)
      {
        if (flagHasBornDateRange)
          {
          }
        flagHasBornDateRange = true;
        storeBornDateRange = new_value;
      }
    public void unsetBornDateRange()
      {
        if (flagHasBornDateRange)
          {
          }
        flagHasBornDateRange = false;
      }

    public virtual void extraPersonAttributeChildrenParametersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPersonAttributeChildrenParametersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPersonAttributeChildrenParametersLookup(key);
        if (old_field == null)
          {
            extraPersonAttributeChildrenParametersAppendPair(key, new_component);
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
        if (flagHasOrdinal)
          {
            handler.start_pair("Ordinal");
            handler.number_value(storeOrdinal);
          }
        if (flagHasSymbolicOrdinal)
          {
            handler.start_pair("SymbolicOrdinal");
            switch (storeSymbolicOrdinal)
              {
                case TypeSymbolicOrdinal.SymbolicOrdinal_Oldest:
                    handler.string_value("Oldest");
                    break;
                case TypeSymbolicOrdinal.SymbolicOrdinal_Youngest:
                    handler.string_value("Youngest");
                    break;
                case TypeSymbolicOrdinal.SymbolicOrdinal_Middle:
                    handler.string_value("Middle");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasSex)
          {
            handler.start_pair("Sex");
            switch (storeSex)
              {
                case TypeSex.Sex_Female:
                    handler.string_value("Female");
                    break;
                case TypeSex.Sex_Male:
                    handler.string_value("Male");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasBornDateRange)
          {
            handler.start_pair("BornDateRange");
            if (partial_allowed)
                storeBornDateRange.write_partial_as_json(handler);
            else
                storeBornDateRange.write_as_json(handler);
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

    public static PersonAttributeChildrenParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeChildrenParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeChildrenParameters", ignore_extras);
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
    public static PersonAttributeChildrenParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PersonAttributeChildrenParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeChildrenParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeChildrenParameters", ignore_extras);
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
    public static PersonAttributeChildrenParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PersonAttributeChildrenParametersJSON from_text(string text, bool ignore_extras)
      {
        PersonAttributeChildrenParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeChildrenParameters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonAttributeChildrenParametersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PersonAttributeChildrenParametersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonAttributeChildrenParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeChildrenParameters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorOrdinal : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorOrdinal(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorOrdinal : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorOrdinal(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorOrdinal fieldGeneratorOrdinal;
    private abstract class FieldGeneratorSymbolicOrdinal : JSONStringGenerator
          {
            protected FieldGeneratorSymbolicOrdinal(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSymbolicOrdinal()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSymbolicOrdinal(result));
              }
            protected abstract void handle_result(TypeSymbolicOrdinal result);
          };
    private class FieldHoldingGeneratorSymbolicOrdinal : FieldGeneratorSymbolicOrdinal
  {
    protected override void handle_result(TypeSymbolicOrdinal result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSymbolicOrdinal(String what)
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
    public TypeSymbolicOrdinal value;
  };
    private class FieldHoldingArrayGeneratorSymbolicOrdinal : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSymbolicOrdinal
      {
        private FieldHoldingArrayGeneratorSymbolicOrdinal top;

        protected override void handle_result(TypeSymbolicOrdinal result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSymbolicOrdinal init_top)
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
    protected virtual void handle_result(List<TypeSymbolicOrdinal> result)
      {
      }

    public FieldHoldingArrayGeneratorSymbolicOrdinal(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSymbolicOrdinal>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSymbolicOrdinal()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSymbolicOrdinal>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSymbolicOrdinal> value;
  };
        private FieldHoldingGeneratorSymbolicOrdinal fieldGeneratorSymbolicOrdinal;
    private abstract class FieldGeneratorSex : JSONStringGenerator
          {
            protected FieldGeneratorSex(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSex()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSex(result));
              }
            protected abstract void handle_result(TypeSex result);
          };
    private class FieldHoldingGeneratorSex : FieldGeneratorSex
  {
    protected override void handle_result(TypeSex result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSex(String what)
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
    public TypeSex value;
  };
    private class FieldHoldingArrayGeneratorSex : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSex
      {
        private FieldHoldingArrayGeneratorSex top;

        protected override void handle_result(TypeSex result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSex init_top)
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
    protected virtual void handle_result(List<TypeSex> result)
      {
      }

    public FieldHoldingArrayGeneratorSex(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSex>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSex()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSex>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSex> value;
  };
        private FieldHoldingGeneratorSex fieldGeneratorSex;
        private SetOfTimeJSON.HoldingGenerator fieldGeneratorBornDateRange;
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
            PersonAttributeChildrenParametersJSON result = new PersonAttributeChildrenParametersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonAttributeChildrenParametersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(PersonAttributeChildrenParametersJSON result)
          {
            if (fieldGeneratorOrdinal.have_value)
              {
                result.setOrdinal(fieldGeneratorOrdinal.value);
                fieldGeneratorOrdinal.have_value = false;
              }
            if (fieldGeneratorSymbolicOrdinal.have_value)
              {
                result.setSymbolicOrdinal(fieldGeneratorSymbolicOrdinal.value);
                fieldGeneratorSymbolicOrdinal.have_value = false;
              }
            if (fieldGeneratorSex.have_value)
              {
                result.setSex(fieldGeneratorSex.value);
                fieldGeneratorSex.have_value = false;
              }
            if (fieldGeneratorBornDateRange.have_value)
              {
                result.setBornDateRange(fieldGeneratorBornDateRange.value);
                fieldGeneratorBornDateRange.have_value = false;
              }
          }
        protected abstract void handle_result(PersonAttributeChildrenParametersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "ornDateRange", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorBornDateRange;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "rdinal", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorOrdinal;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "x", 0, 1, false) == 0) && (field_name.Length == 3))
                                return fieldGeneratorSex;
                            break;
                        case 'y':
                            if ((String.Compare(field_name, 2, "mbolicOrdinal", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorSymbolicOrdinal;
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
            fieldGeneratorOrdinal = new FieldHoldingGeneratorOrdinal("field \"Ordinal\" of the PersonAttributeChildrenParameters class");
            fieldGeneratorSymbolicOrdinal = new FieldHoldingGeneratorSymbolicOrdinal("field \"SymbolicOrdinal\" of the PersonAttributeChildrenParameters class");
            fieldGeneratorSex = new FieldHoldingGeneratorSex("field \"Sex\" of the PersonAttributeChildrenParameters class");
            fieldGeneratorBornDateRange = new SetOfTimeJSON.HoldingGenerator("field \"BornDateRange\" of the PersonAttributeChildrenParameters class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PersonAttributeChildrenParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorOrdinal = new FieldHoldingGeneratorOrdinal("field \"Ordinal\" of the PersonAttributeChildrenParameters class");
            fieldGeneratorSymbolicOrdinal = new FieldHoldingGeneratorSymbolicOrdinal("field \"SymbolicOrdinal\" of the PersonAttributeChildrenParameters class");
            fieldGeneratorSex = new FieldHoldingGeneratorSex("field \"Sex\" of the PersonAttributeChildrenParameters class");
            fieldGeneratorBornDateRange = new SetOfTimeJSON.HoldingGenerator("field \"BornDateRange\" of the PersonAttributeChildrenParameters class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PersonAttributeChildrenParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorOrdinal.reset();
            fieldGeneratorSymbolicOrdinal.reset();
            fieldGeneratorSex.reset();
            fieldGeneratorBornDateRange.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorBornDateRange.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorBornDateRange.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonAttributeChildrenParametersJSON  result)
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
        public PersonAttributeChildrenParametersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonAttributeChildrenParametersJSON  result)
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
    protected virtual void handle_result(List<PersonAttributeChildrenParametersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonAttributeChildrenParametersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonAttributeChildrenParametersJSON>();
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
    public List<PersonAttributeChildrenParametersJSON> value;
  };
  };
