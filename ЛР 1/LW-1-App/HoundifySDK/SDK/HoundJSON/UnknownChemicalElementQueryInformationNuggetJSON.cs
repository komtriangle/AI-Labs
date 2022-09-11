/* file "UnknownChemicalElementQueryInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UnknownChemicalElementQueryInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeElementQueriedByKnownValues
      {
        ElementQueriedBy_ElementName,
        ElementQueriedBy_ElementSymbol,
        ElementQueriedBy_ElementNumber,
        ElementQueriedBy_ElementProtonNumber,
        ElementQueriedBy_ElementElectronNumber,
        ElementQueriedBy_ConversationHistory,
        ElementQueriedBy__none
      };
    public struct TypeElementQueriedBy
      {
        public bool in_known_list;
        public string string_value;
        public TypeElementQueriedByKnownValues list_value;
      };

    public static TypeElementQueriedByKnownValues  stringToElementQueriedBy(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "onversationHistory", 0, 18, false) == 0) && (chars.Length == 19))
                    return TypeElementQueriedByKnownValues.ElementQueriedBy_ConversationHistory;
                break;
            case 'E':
                if (String.Compare(chars, 1, "lement", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'E':
                            if ((String.Compare(chars, 8, "lectronNumber", 0, 13, false) == 0) && (chars.Length == 21))
                                return TypeElementQueriedByKnownValues.ElementQueriedBy_ElementElectronNumber;
                            break;
                        case 'N':
                            switch (chars[8])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 9, "me", 0, 2, false) == 0) && (chars.Length == 11))
                                        return TypeElementQueriedByKnownValues.ElementQueriedBy_ElementName;
                                    break;
                                case 'u':
                                    if ((String.Compare(chars, 9, "mber", 0, 4, false) == 0) && (chars.Length == 13))
                                        return TypeElementQueriedByKnownValues.ElementQueriedBy_ElementNumber;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'P':
                            if ((String.Compare(chars, 8, "rotonNumber", 0, 11, false) == 0) && (chars.Length == 19))
                                return TypeElementQueriedByKnownValues.ElementQueriedBy_ElementProtonNumber;
                            break;
                        case 'S':
                            if ((String.Compare(chars, 8, "ymbol", 0, 5, false) == 0) && (chars.Length == 13))
                                return TypeElementQueriedByKnownValues.ElementQueriedBy_ElementSymbol;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeElementQueriedByKnownValues.ElementQueriedBy__none;
      }

    public static string  stringFromElementQueriedBy(TypeElementQueriedByKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementName:
                return "ElementName";
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementSymbol:
                return "ElementSymbol";
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementNumber:
                return "ElementNumber";
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementProtonNumber:
                return "ElementProtonNumber";
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementElectronNumber:
                return "ElementElectronNumber";
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ConversationHistory:
                return "ConversationHistory";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasAtomicNumber;
    private BigInteger storeAtomicNumber;
    private bool flagHasElementQueriedBy;
    private TypeElementQueriedBy storeElementQueriedBy;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAtomicNumberToJSON()
      {
        JSONIntegerValue generated_integer_AtomicNumber = new JSONIntegerValue(storeAtomicNumber);
        return generated_integer_AtomicNumber;
      }

    private JSONValue  extraElementQueriedByToJSON()
      {
        JSONStringValue generated_string_ElementQueriedBy;
        if (!(storeElementQueriedBy.in_known_list))
          {
        generated_string_ElementQueriedBy = new JSONStringValue(storeElementQueriedBy.string_value);
          }
        else
          {
        switch (storeElementQueriedBy.list_value)
          {
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementName:
                generated_string_ElementQueriedBy = new JSONStringValue("ElementName");
                break;
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementSymbol:
                generated_string_ElementQueriedBy = new JSONStringValue("ElementSymbol");
                break;
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementNumber:
                generated_string_ElementQueriedBy = new JSONStringValue("ElementNumber");
                break;
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementProtonNumber:
                generated_string_ElementQueriedBy = new JSONStringValue("ElementProtonNumber");
                break;
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementElectronNumber:
                generated_string_ElementQueriedBy = new JSONStringValue("ElementElectronNumber");
                break;
            case TypeElementQueriedByKnownValues.ElementQueriedBy_ConversationHistory:
                generated_string_ElementQueriedBy = new JSONStringValue("ConversationHistory");
                break;
            default:
                Debug.Assert(false);
                generated_string_ElementQueriedBy = null;
                break;
          }
          }
        return generated_string_ElementQueriedBy;
      }


    private void  fromJSONAtomicNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AtomicNumber of UnknownChemicalElementQueryInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AtomicNumber of UnknownChemicalElementQueryInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAtomicNumber(extracted_integer);
      }


    private void  fromJSONElementQueriedBy(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ElementQueriedBy of UnknownChemicalElementQueryInformationNuggetJSON is not a string.");
        TypeElementQueriedBy the_open_enum = new TypeElementQueriedBy();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "onversationHistory", 0, 18, false) == 0) && (json_string.getData().Length == 19))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeElementQueriedByKnownValues.ElementQueriedBy_ConversationHistory;
                        goto open_enum_is_done;
                      }
                break;
            case 'E':
                if (String.Compare(json_string.getData(), 1, "lement", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'E':
                            if ((String.Compare(json_string.getData(), 8, "lectronNumber", 0, 13, false) == 0) && (json_string.getData().Length == 21))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeElementQueriedByKnownValues.ElementQueriedBy_ElementElectronNumber;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'N':
                            switch (json_string.getData()[8])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 9, "me", 0, 2, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeElementQueriedByKnownValues.ElementQueriedBy_ElementName;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'u':
                                    if ((String.Compare(json_string.getData(), 9, "mber", 0, 4, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeElementQueriedByKnownValues.ElementQueriedBy_ElementNumber;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'P':
                            if ((String.Compare(json_string.getData(), 8, "rotonNumber", 0, 11, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeElementQueriedByKnownValues.ElementQueriedBy_ElementProtonNumber;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 8, "ymbol", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeElementQueriedByKnownValues.ElementQueriedBy_ElementSymbol;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setElementQueriedBy(the_open_enum);
      }


    public UnknownChemicalElementQueryInformationNuggetJSON()
      {
        flagHasAtomicNumber = false;
        flagHasElementQueriedBy = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "UnknownChemicalElementQueryInformationNugget";
      }

    public bool  hasAtomicNumber()
      {
        return flagHasAtomicNumber;
      }

    public BigInteger  getAtomicNumber()
      {
        Debug.Assert(flagHasAtomicNumber);
        return storeAtomicNumber;
      }

    public bool  hasElementQueriedBy()
      {
        return flagHasElementQueriedBy;
      }

    public TypeElementQueriedBy  getElementQueriedBy()
      {
        Debug.Assert(flagHasElementQueriedBy);
        return storeElementQueriedBy;
      }

    public string  getElementQueriedByAsString()
      {
        TypeElementQueriedBy result = getElementQueriedBy();
        if (result.in_known_list)
            return stringFromElementQueriedBy(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraUnknownChemicalElementQueryInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUnknownChemicalElementQueryInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUnknownChemicalElementQueryInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUnknownChemicalElementQueryInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasAtomicNumber)
            ++result;
        if (flagHasElementQueriedBy)
            ++result;
        result += extraUnknownChemicalElementQueryInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAtomicNumber)
          {
            if (remainder == 0)
                return "AtomicNumber";
            --remainder;
          }
        if (flagHasElementQueriedBy)
          {
            if (remainder == 0)
                return "ElementQueriedBy";
            --remainder;
          }
        return extraUnknownChemicalElementQueryInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAtomicNumber)
          {
            if (remainder == 0)
                return extraAtomicNumberToJSON();
            --remainder;
          }
        if (flagHasElementQueriedBy)
          {
            if (remainder == 0)
                return extraElementQueriedByToJSON();
            --remainder;
          }
        return extraUnknownChemicalElementQueryInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "tomicNumber", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasAtomicNumber ? extraAtomicNumberToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "lementQueriedBy", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasElementQueriedBy ? extraElementQueriedByToJSON() : null);
                break;
            default:
                break;
          }
        return extraUnknownChemicalElementQueryInformationNuggetLookup(field_name);
      }

    public void setAtomicNumber(BigInteger new_value)
      {
        flagHasAtomicNumber = true;
        storeAtomicNumber = new_value;
      }
    public void unsetAtomicNumber()
      {
        flagHasAtomicNumber = false;
      }
    public void setElementQueriedBy(TypeElementQueriedBy new_value)
      {
        flagHasElementQueriedBy = true;
        storeElementQueriedBy = new_value;
      }
    public void setElementQueriedBy(string chars)
      {
        TypeElementQueriedByKnownValues known = stringToElementQueriedBy(chars);
        TypeElementQueriedBy new_value = new TypeElementQueriedBy();
        if (known == TypeElementQueriedByKnownValues.ElementQueriedBy__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setElementQueriedBy(new_value);
      }
    public void setElementQueriedBy(TypeElementQueriedByKnownValues new_value)
      {
        TypeElementQueriedBy new_full_value = new TypeElementQueriedBy();
        Debug.Assert(new_value != TypeElementQueriedByKnownValues.ElementQueriedBy__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setElementQueriedBy(new_full_value);
      }
    public void unsetElementQueriedBy()
      {
        flagHasElementQueriedBy = false;
      }

    public virtual void extraUnknownChemicalElementQueryInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUnknownChemicalElementQueryInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUnknownChemicalElementQueryInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraUnknownChemicalElementQueryInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "tomicNumber", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONAtomicNumber(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "lementQueriedBy", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONElementQueriedBy(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUnknownChemicalElementQueryInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "tomicNumber", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONAtomicNumber(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "lementQueriedBy", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONElementQueriedBy(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUnknownChemicalElementQueryInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAtomicNumber);
        if (flagHasAtomicNumber)
          {
            handler.start_pair("AtomicNumber");
            handler.number_value(storeAtomicNumber);
          }
        Debug.Assert(partial_allowed || flagHasElementQueriedBy);
        if (flagHasElementQueriedBy)
          {
            handler.start_pair("ElementQueriedBy");
            if (storeElementQueriedBy.in_known_list)
              {
                switch (storeElementQueriedBy.list_value)
                  {
                    case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementName:
                        handler.string_value("ElementName");
                        break;
                    case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementSymbol:
                        handler.string_value("ElementSymbol");
                        break;
                    case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementNumber:
                        handler.string_value("ElementNumber");
                        break;
                    case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementProtonNumber:
                        handler.string_value("ElementProtonNumber");
                        break;
                    case TypeElementQueriedByKnownValues.ElementQueriedBy_ElementElectronNumber:
                        handler.string_value("ElementElectronNumber");
                        break;
                    case TypeElementQueriedByKnownValues.ElementQueriedBy_ConversationHistory:
                        handler.string_value("ConversationHistory");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeElementQueriedBy.string_value);
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
        if (!(hasAtomicNumber()))
          {
            return "When parsing the object for %what%, the \"AtomicNumber\" field was missing.";
          }
        if (!(hasElementQueriedBy()))
          {
            return "When parsing the object for %what%, the \"ElementQueriedBy\" field was missing.";
          }
        return null;
      }

    public static new UnknownChemicalElementQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnknownChemicalElementQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnknownChemicalElementQueryInformationNugget", ignore_extras);
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
    public static new UnknownChemicalElementQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UnknownChemicalElementQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnknownChemicalElementQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnknownChemicalElementQueryInformationNugget", ignore_extras);
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
    public static new UnknownChemicalElementQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UnknownChemicalElementQueryInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        UnknownChemicalElementQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnknownChemicalElementQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UnknownChemicalElementQueryInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UnknownChemicalElementQueryInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UnknownChemicalElementQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnknownChemicalElementQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private class FieldHoldingGeneratorAtomicNumber : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorAtomicNumber(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAtomicNumber : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAtomicNumber(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorAtomicNumber fieldGeneratorAtomicNumber;
    private abstract class FieldGeneratorElementQueriedBy : JSONStringGenerator
          {
            protected FieldGeneratorElementQueriedBy(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorElementQueriedBy()
              {
              }
            protected override void handle_result(string result)
              {
                TypeElementQueriedByKnownValues known = stringToElementQueriedBy(result);
                TypeElementQueriedBy new_value = new TypeElementQueriedBy();
                if (known == TypeElementQueriedByKnownValues.ElementQueriedBy__none)
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
            protected abstract void handle_result(TypeElementQueriedBy result);
          };
    private class FieldHoldingGeneratorElementQueriedBy : FieldGeneratorElementQueriedBy
  {
    protected override void handle_result(TypeElementQueriedBy result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorElementQueriedBy(String what)
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
    public TypeElementQueriedBy value;
  };
    private class FieldHoldingArrayGeneratorElementQueriedBy : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorElementQueriedBy
      {
        private FieldHoldingArrayGeneratorElementQueriedBy top;

        protected override void handle_result(TypeElementQueriedBy result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorElementQueriedBy init_top)
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
    protected virtual void handle_result(List<TypeElementQueriedBy> result)
      {
      }

    public FieldHoldingArrayGeneratorElementQueriedBy(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeElementQueriedBy>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorElementQueriedBy()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeElementQueriedBy>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeElementQueriedBy> value;
  };
        private FieldHoldingGeneratorElementQueriedBy fieldGeneratorElementQueriedBy;
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
            if (!(getInformationNuggetJSONKey().Equals("UnknownChemicalElementQueryInformationNugget")))
                throw new Exception("The key field has a value other than `UnknownChemicalElementQueryInformationNugget'.");
            UnknownChemicalElementQueryInformationNuggetJSON result = new UnknownChemicalElementQueryInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUnknownChemicalElementQueryInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((UnknownChemicalElementQueryInformationNuggetJSON )new_result);
          }
        protected void finish(UnknownChemicalElementQueryInformationNuggetJSON result)
          {
            if (fieldGeneratorAtomicNumber.have_value)
              {
                result.setAtomicNumber(fieldGeneratorAtomicNumber.value);
                fieldGeneratorAtomicNumber.have_value = false;
              }
            else if ((!(result.hasAtomicNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AtomicNumber\" field was missing.");
              }
            if (fieldGeneratorElementQueriedBy.have_value)
              {
                result.setElementQueriedBy(fieldGeneratorElementQueriedBy.value);
                fieldGeneratorElementQueriedBy.have_value = false;
              }
            else if ((!(result.hasElementQueriedBy())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ElementQueriedBy\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UnknownChemicalElementQueryInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "tomicNumber", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorAtomicNumber;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "lementQueriedBy", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorElementQueriedBy;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAtomicNumber = new FieldHoldingGeneratorAtomicNumber("field \"AtomicNumber\" of the UnknownChemicalElementQueryInformationNugget class");
            fieldGeneratorElementQueriedBy = new FieldHoldingGeneratorElementQueriedBy("field \"ElementQueriedBy\" of the UnknownChemicalElementQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UnknownChemicalElementQueryInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAtomicNumber = new FieldHoldingGeneratorAtomicNumber("field \"AtomicNumber\" of the UnknownChemicalElementQueryInformationNugget class");
            fieldGeneratorElementQueriedBy = new FieldHoldingGeneratorElementQueriedBy("field \"ElementQueriedBy\" of the UnknownChemicalElementQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UnknownChemicalElementQueryInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAtomicNumber.reset();
            fieldGeneratorElementQueriedBy.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UnknownChemicalElementQueryInformationNuggetJSON  result)
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
        public UnknownChemicalElementQueryInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UnknownChemicalElementQueryInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<UnknownChemicalElementQueryInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UnknownChemicalElementQueryInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UnknownChemicalElementQueryInformationNuggetJSON>();
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
    public List<UnknownChemicalElementQueryInformationNuggetJSON> value;
  };
  };
