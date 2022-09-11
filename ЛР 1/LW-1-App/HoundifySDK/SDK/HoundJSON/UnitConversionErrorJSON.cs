/* file "UnitConversionErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UnitConversionErrorJSON : JSONBase
  {
    public enum TypeTypeKnownValues
      {
        Type_TypeMismatch,
        Type_InvalidDensity,
        Type_UnnecessaryDensity,
        Type_NoValidInputFound,
        Type_NoValidOutputFound,
        Type_BadAdjective,
        Type__none
      };
    public struct TypeType
      {
        public bool in_known_list;
        public string string_value;
        public TypeTypeKnownValues list_value;
      };

    public static TypeTypeKnownValues  stringToType(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "adAdjective", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeTypeKnownValues.Type_BadAdjective;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nvalidDensity", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeTypeKnownValues.Type_InvalidDensity;
                break;
            case 'N':
                if (String.Compare(chars, 1, "oValid", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'I':
                            if ((String.Compare(chars, 8, "nputFound", 0, 9, false) == 0) && (chars.Length == 17))
                                return TypeTypeKnownValues.Type_NoValidInputFound;
                            break;
                        case 'O':
                            if ((String.Compare(chars, 8, "utputFound", 0, 10, false) == 0) && (chars.Length == 18))
                                return TypeTypeKnownValues.Type_NoValidOutputFound;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ypeMismatch", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeTypeKnownValues.Type_TypeMismatch;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nnecessaryDensity", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeTypeKnownValues.Type_UnnecessaryDensity;
                break;
            default:
                break;
          }
        return TypeTypeKnownValues.Type__none;
      }

    public static string  stringFromType(TypeTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTypeKnownValues.Type_TypeMismatch:
                return "TypeMismatch";
            case TypeTypeKnownValues.Type_InvalidDensity:
                return "InvalidDensity";
            case TypeTypeKnownValues.Type_UnnecessaryDensity:
                return "UnnecessaryDensity";
            case TypeTypeKnownValues.Type_NoValidInputFound:
                return "NoValidInputFound";
            case TypeTypeKnownValues.Type_NoValidOutputFound:
                return "NoValidOutputFound";
            case TypeTypeKnownValues.Type_BadAdjective:
                return "BadAdjective";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasType;
    private TypeType storeType;
    private bool flagHasInputUnit;
    private List< UnitOfMeasureJSON  > storeInputUnit;
    private bool flagHasOutputUnit;
    private List< UnitOfMeasureJSON  > storeOutputUnit;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of UnitConversionErrorJSON is not a string.");
        TypeType the_open_enum = new TypeType();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "adAdjective", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_BadAdjective;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nvalidDensity", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_InvalidDensity;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "oValid", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'I':
                            if ((String.Compare(json_string.getData(), 8, "nputFound", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTypeKnownValues.Type_NoValidInputFound;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'O':
                            if ((String.Compare(json_string.getData(), 8, "utputFound", 0, 10, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTypeKnownValues.Type_NoValidOutputFound;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "ypeMismatch", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_TypeMismatch;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nnecessaryDensity", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTypeKnownValues.Type_UnnecessaryDensity;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setType(the_open_enum);
      }


    private void  fromJSONInputUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputUnit of UnitConversionErrorJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field InputUnit of UnitConversionErrorJSON has too few elements.");
        List< UnitOfMeasureJSON  > vector_InputUnit1 = new List< UnitOfMeasureJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UnitOfMeasureJSON convert_classy = UnitOfMeasureJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InputUnit1.Add(convert_classy);
          }
        Debug.Assert(vector_InputUnit1.Count >= 1);
        initInputUnit();
        for (int num1 = 0; num1 < vector_InputUnit1.Count; ++num1)
            appendInputUnit(vector_InputUnit1[num1]);
        for (int num1 = 0; num1 < vector_InputUnit1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOutputUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OutputUnit of UnitConversionErrorJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field OutputUnit of UnitConversionErrorJSON has too few elements.");
        List< UnitOfMeasureJSON  > vector_OutputUnit1 = new List< UnitOfMeasureJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UnitOfMeasureJSON convert_classy = UnitOfMeasureJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_OutputUnit1.Add(convert_classy);
          }
        Debug.Assert(vector_OutputUnit1.Count >= 1);
        initOutputUnit();
        for (int num2 = 0; num2 < vector_OutputUnit1.Count; ++num2)
            appendOutputUnit(vector_OutputUnit1[num2]);
        for (int num1 = 0; num1 < vector_OutputUnit1.Count; ++num1)
          {
          }
      }


    public UnitConversionErrorJSON()
      {
        flagHasType = false;
        flagHasInputUnit = false;
        flagHasOutputUnit = false;
        storeInputUnit = new List< UnitOfMeasureJSON  >();
        storeOutputUnit = new List< UnitOfMeasureJSON  >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public TypeType  getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public string  getTypeAsString()
      {
        TypeType result = getType();
        if (result.in_known_list)
            return stringFromType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasInputUnit()
      {
        return flagHasInputUnit;
      }

    public int  countOfInputUnit()
      {
        Debug.Assert(flagHasInputUnit);
        return storeInputUnit.Count;
      }

    public UnitOfMeasureJSON   elementOfInputUnit(int element_num)
      {
        Debug.Assert(flagHasInputUnit);
        return storeInputUnit[element_num];
      }

    public List< UnitOfMeasureJSON  >  getInputUnit()
      {
        Debug.Assert(flagHasInputUnit);
        return storeInputUnit;
      }

    public bool  hasOutputUnit()
      {
        return flagHasOutputUnit;
      }

    public int  countOfOutputUnit()
      {
        Debug.Assert(flagHasOutputUnit);
        return storeOutputUnit.Count;
      }

    public UnitOfMeasureJSON   elementOfOutputUnit(int element_num)
      {
        Debug.Assert(flagHasOutputUnit);
        return storeOutputUnit[element_num];
      }

    public List< UnitOfMeasureJSON  >  getOutputUnit()
      {
        Debug.Assert(flagHasOutputUnit);
        return storeOutputUnit;
      }



    public void setType(TypeType new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(string chars)
      {
        TypeTypeKnownValues known = stringToType(chars);
        TypeType new_value = new TypeType();
        if (known == TypeTypeKnownValues.Type__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void setType(TypeTypeKnownValues new_value)
      {
        TypeType new_full_value = new TypeType();
        Debug.Assert(new_value != TypeTypeKnownValues.Type__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setType(new_full_value);
      }
    public void unsetType()
      {
        flagHasType = false;
      }
    public void initInputUnit()
      {
        if (flagHasInputUnit)
          {
            for (int num1 = 0; num1 < storeInputUnit.Count; ++num1)
              {
              }
          }
        flagHasInputUnit = true;
        storeInputUnit.Clear();
      }
    public void appendInputUnit(UnitOfMeasureJSON  to_append)
      {
        if (!flagHasInputUnit)
          {
            flagHasInputUnit = true;
            storeInputUnit.Clear();
          }
        Debug.Assert(flagHasInputUnit);
        storeInputUnit.Add(to_append);
      }
    public void appendInputUnit(UnitOfMeasureJSON.TypeValue new_value)
      {
        appendInputUnit(new UnitOfMeasureJSON(new_value));
      }
    public void appendInputUnit(string chars)
      {
        UnitOfMeasureJSON.TypeValueKnownValues known = UnitOfMeasureJSON.stringToValue(chars);
        UnitOfMeasureJSON.TypeValue new_value = new UnitOfMeasureJSON.TypeValue();
        if (known == UnitOfMeasureJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendInputUnit(new_value);
      }
    public void unsetInputUnit()
      {
        if (flagHasInputUnit)
          {
            for (int num2 = 0; num2 < storeInputUnit.Count; ++num2)
              {
              }
          }
        flagHasInputUnit = false;
        storeInputUnit.Clear();
      }
    public void initOutputUnit()
      {
        if (flagHasOutputUnit)
          {
            for (int num3 = 0; num3 < storeOutputUnit.Count; ++num3)
              {
              }
          }
        flagHasOutputUnit = true;
        storeOutputUnit.Clear();
      }
    public void appendOutputUnit(UnitOfMeasureJSON  to_append)
      {
        if (!flagHasOutputUnit)
          {
            flagHasOutputUnit = true;
            storeOutputUnit.Clear();
          }
        Debug.Assert(flagHasOutputUnit);
        storeOutputUnit.Add(to_append);
      }
    public void appendOutputUnit(UnitOfMeasureJSON.TypeValue new_value)
      {
        appendOutputUnit(new UnitOfMeasureJSON(new_value));
      }
    public void appendOutputUnit(string chars)
      {
        UnitOfMeasureJSON.TypeValueKnownValues known = UnitOfMeasureJSON.stringToValue(chars);
        UnitOfMeasureJSON.TypeValue new_value = new UnitOfMeasureJSON.TypeValue();
        if (known == UnitOfMeasureJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendOutputUnit(new_value);
      }
    public void unsetOutputUnit()
      {
        if (flagHasOutputUnit)
          {
            for (int num4 = 0; num4 < storeOutputUnit.Count; ++num4)
              {
              }
          }
        flagHasOutputUnit = false;
        storeOutputUnit.Clear();
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
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (storeType.in_known_list)
              {
                switch (storeType.list_value)
                  {
                    case TypeTypeKnownValues.Type_TypeMismatch:
                        handler.string_value("TypeMismatch");
                        break;
                    case TypeTypeKnownValues.Type_InvalidDensity:
                        handler.string_value("InvalidDensity");
                        break;
                    case TypeTypeKnownValues.Type_UnnecessaryDensity:
                        handler.string_value("UnnecessaryDensity");
                        break;
                    case TypeTypeKnownValues.Type_NoValidInputFound:
                        handler.string_value("NoValidInputFound");
                        break;
                    case TypeTypeKnownValues.Type_NoValidOutputFound:
                        handler.string_value("NoValidOutputFound");
                        break;
                    case TypeTypeKnownValues.Type_BadAdjective:
                        handler.string_value("BadAdjective");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeType.string_value);
              }
          }
        if (flagHasInputUnit)
          {
            handler.start_pair("InputUnit");
            Debug.Assert(storeInputUnit.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeInputUnit.Count; ++num1)
              {
                if (partial_allowed)
                    storeInputUnit[num1].write_partial_as_json(handler);
                else
                    storeInputUnit[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasOutputUnit)
          {
            handler.start_pair("OutputUnit");
            Debug.Assert(storeOutputUnit.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeOutputUnit.Count; ++num2)
              {
                if (partial_allowed)
                    storeOutputUnit[num2].write_partial_as_json(handler);
                else
                    storeOutputUnit[num2].write_as_json(handler);
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        return null;
      }

    public static UnitConversionErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitConversionErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConversionError", ignore_extras);
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
    public static UnitConversionErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UnitConversionErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitConversionErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConversionError", ignore_extras);
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
    public static UnitConversionErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UnitConversionErrorJSON from_text(string text, bool ignore_extras)
      {
        UnitConversionErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConversionError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UnitConversionErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UnitConversionErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UnitConversionErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConversionError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorType : JSONStringGenerator
          {
            protected FieldGeneratorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTypeKnownValues known = stringToType(result);
                TypeType new_value = new TypeType();
                if (known == TypeTypeKnownValues.Type__none)
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
            protected abstract void handle_result(TypeType result);
          };
    private class FieldHoldingGeneratorType : FieldGeneratorType
  {
    protected override void handle_result(TypeType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorType(String what)
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
    public TypeType value;
  };
    private class FieldHoldingArrayGeneratorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorType
      {
        private FieldHoldingArrayGeneratorType top;

        protected override void handle_result(TypeType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorType init_top)
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
    protected virtual void handle_result(List<TypeType> result)
      {
      }

    public FieldHoldingArrayGeneratorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeType> value;
  };
        private FieldHoldingGeneratorType fieldGeneratorType;
        private UnitOfMeasureJSON.HoldingArrayGenerator fieldGeneratorInputUnit;
        private UnitOfMeasureJSON.HoldingArrayGenerator fieldGeneratorOutputUnit;

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
            UnitConversionErrorJSON result = new UnitConversionErrorJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(UnitConversionErrorJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
              }
            if (fieldGeneratorInputUnit.have_value)
              {
                result.initInputUnit();
                int count = fieldGeneratorInputUnit.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInputUnit(fieldGeneratorInputUnit.value[num]);
                  }
                fieldGeneratorInputUnit.value.Clear();
                fieldGeneratorInputUnit.have_value = false;
              }
            if (fieldGeneratorOutputUnit.have_value)
              {
                result.initOutputUnit();
                int count = fieldGeneratorOutputUnit.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOutputUnit(fieldGeneratorOutputUnit.value[num]);
                  }
                fieldGeneratorOutputUnit.value.Clear();
                fieldGeneratorOutputUnit.have_value = false;
              }
          }
        protected abstract void handle_result(UnitConversionErrorJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "nputUnit", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorInputUnit;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utputUnit", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorOutputUnit;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the UnitConversionError class");
            fieldGeneratorInputUnit = new UnitOfMeasureJSON.HoldingArrayGenerator("field \"InputUnit\" of the UnitConversionError class", ignore_extras);
            fieldGeneratorOutputUnit = new UnitOfMeasureJSON.HoldingArrayGenerator("field \"OutputUnit\" of the UnitConversionError class", ignore_extras);
            set_what("the UnitConversionError class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the UnitConversionError class");
            fieldGeneratorInputUnit = new UnitOfMeasureJSON.HoldingArrayGenerator("field \"InputUnit\" of the UnitConversionError class", false);
            fieldGeneratorOutputUnit = new UnitOfMeasureJSON.HoldingArrayGenerator("field \"OutputUnit\" of the UnitConversionError class", false);
            set_what("the UnitConversionError class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorInputUnit.reset();
            fieldGeneratorOutputUnit.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorInputUnit.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputUnit.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorInputUnit.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputUnit.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UnitConversionErrorJSON  result)
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
        public UnitConversionErrorJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UnitConversionErrorJSON  result)
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
    protected virtual void handle_result(List<UnitConversionErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UnitConversionErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UnitConversionErrorJSON>();
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
    public List<UnitConversionErrorJSON> value;
  };
  };
