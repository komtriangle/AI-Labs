/* file "ChemicalElementGroupQueryInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ChemicalElementGroupQueryInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeElementGroupQueryKnownValues
      {
        ElementGroupQuery_General,
        ElementGroupQuery_Name,
        ElementGroupQuery_Symbol,
        ElementGroupQuery_AtomicNumber,
        ElementGroupQuery_AtomicMass,
        ElementGroupQuery_Amount,
        ElementGroupQuery__none
      };
    public struct TypeElementGroupQuery
      {
        public bool in_known_list;
        public string string_value;
        public TypeElementGroupQueryKnownValues list_value;
      };

    public static TypeElementGroupQueryKnownValues  stringToElementGroupQuery(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'm':
                        if ((String.Compare(chars, 2, "ount", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeElementGroupQueryKnownValues.ElementGroupQuery_Amount;
                        break;
                    case 't':
                        if (String.Compare(chars, 2, "omic", 0, 4, false) == 0)
                          {
                            switch (chars[6])
                              {
                                case 'M':
                                    if ((String.Compare(chars, 7, "ass", 0, 3, false) == 0) && (chars.Length == 10))
                                        return TypeElementGroupQueryKnownValues.ElementGroupQuery_AtomicMass;
                                    break;
                                case 'N':
                                    if ((String.Compare(chars, 7, "umber", 0, 5, false) == 0) && (chars.Length == 12))
                                        return TypeElementGroupQueryKnownValues.ElementGroupQuery_AtomicNumber;
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
                if ((String.Compare(chars, 1, "eneral", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeElementGroupQueryKnownValues.ElementGroupQuery_General;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "ame", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeElementGroupQueryKnownValues.ElementGroupQuery_Name;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "ymbol", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeElementGroupQueryKnownValues.ElementGroupQuery_Symbol;
                break;
            default:
                break;
          }
        return TypeElementGroupQueryKnownValues.ElementGroupQuery__none;
      }

    public static string  stringFromElementGroupQuery(TypeElementGroupQueryKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_General:
                return "General";
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_Name:
                return "Name";
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_Symbol:
                return "Symbol";
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_AtomicNumber:
                return "AtomicNumber";
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_AtomicMass:
                return "AtomicMass";
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_Amount:
                return "Amount";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasElementGroup;
    private ChemicalElementGroupJSON  storeElementGroup;
    private bool flagHasElementGroupQuery;
    private TypeElementGroupQuery storeElementGroupQuery;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraElementGroupToJSON()
      {
        JSONValueHandler handler_ElementGroup = new JSONValueHandler();
        storeElementGroup.write_as_json(handler_ElementGroup);
        return handler_ElementGroup.result;
      }

    private JSONValue  extraElementGroupQueryToJSON()
      {
        JSONStringValue generated_string_ElementGroupQuery;
        if (!(storeElementGroupQuery.in_known_list))
          {
        generated_string_ElementGroupQuery = new JSONStringValue(storeElementGroupQuery.string_value);
          }
        else
          {
        switch (storeElementGroupQuery.list_value)
          {
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_General:
                generated_string_ElementGroupQuery = new JSONStringValue("General");
                break;
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_Name:
                generated_string_ElementGroupQuery = new JSONStringValue("Name");
                break;
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_Symbol:
                generated_string_ElementGroupQuery = new JSONStringValue("Symbol");
                break;
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_AtomicNumber:
                generated_string_ElementGroupQuery = new JSONStringValue("AtomicNumber");
                break;
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_AtomicMass:
                generated_string_ElementGroupQuery = new JSONStringValue("AtomicMass");
                break;
            case TypeElementGroupQueryKnownValues.ElementGroupQuery_Amount:
                generated_string_ElementGroupQuery = new JSONStringValue("Amount");
                break;
            default:
                Debug.Assert(false);
                generated_string_ElementGroupQuery = null;
                break;
          }
          }
        return generated_string_ElementGroupQuery;
      }


    private void  fromJSONElementGroup(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ChemicalElementGroupJSON convert_classy = ChemicalElementGroupJSON.from_json(json_value, ignore_extras, true);
        setElementGroup(convert_classy);
      }


    private void  fromJSONElementGroupQuery(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ElementGroupQuery of ChemicalElementGroupQueryInformationNuggetJSON is not a string.");
        TypeElementGroupQuery the_open_enum = new TypeElementGroupQuery();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'm':
                        if ((String.Compare(json_string.getData(), 2, "ount", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeElementGroupQueryKnownValues.ElementGroupQuery_Amount;
                                goto open_enum_is_done;
                              }
                        break;
                    case 't':
                        if (String.Compare(json_string.getData(), 2, "omic", 0, 4, false) == 0)
                          {
                            switch (json_string.getData()[6])
                              {
                                case 'M':
                                    if ((String.Compare(json_string.getData(), 7, "ass", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeElementGroupQueryKnownValues.ElementGroupQuery_AtomicMass;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'N':
                                    if ((String.Compare(json_string.getData(), 7, "umber", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeElementGroupQueryKnownValues.ElementGroupQuery_AtomicNumber;
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
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "eneral", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeElementGroupQueryKnownValues.ElementGroupQuery_General;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "ame", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeElementGroupQueryKnownValues.ElementGroupQuery_Name;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ymbol", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeElementGroupQueryKnownValues.ElementGroupQuery_Symbol;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setElementGroupQuery(the_open_enum);
      }


    public ChemicalElementGroupQueryInformationNuggetJSON()
      {
        flagHasElementGroup = false;
        flagHasElementGroupQuery = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "ChemicalElementGroupQueryInformationNugget";
      }

    public bool  hasElementGroup()
      {
        return flagHasElementGroup;
      }

    public ChemicalElementGroupJSON   getElementGroup()
      {
        Debug.Assert(flagHasElementGroup);
        return storeElementGroup;
      }

    public bool  hasElementGroupQuery()
      {
        return flagHasElementGroupQuery;
      }

    public TypeElementGroupQuery  getElementGroupQuery()
      {
        Debug.Assert(flagHasElementGroupQuery);
        return storeElementGroupQuery;
      }

    public string  getElementGroupQueryAsString()
      {
        TypeElementGroupQuery result = getElementGroupQuery();
        if (result.in_known_list)
            return stringFromElementGroupQuery(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraChemicalElementGroupQueryInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChemicalElementGroupQueryInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChemicalElementGroupQueryInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChemicalElementGroupQueryInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasElementGroup)
            ++result;
        if (flagHasElementGroupQuery)
            ++result;
        result += extraChemicalElementGroupQueryInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasElementGroup)
          {
            if (remainder == 0)
                return "ElementGroup";
            --remainder;
          }
        if (flagHasElementGroupQuery)
          {
            if (remainder == 0)
                return "ElementGroupQuery";
            --remainder;
          }
        return extraChemicalElementGroupQueryInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasElementGroup)
          {
            if (remainder == 0)
                return extraElementGroupToJSON();
            --remainder;
          }
        if (flagHasElementGroupQuery)
          {
            if (remainder == 0)
                return extraElementGroupQueryToJSON();
            --remainder;
          }
        return extraChemicalElementGroupQueryInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "ElementGroup", 0, 12, false) == 0)
          {
            if (field_name.Length == 12)
              {
                return (flagHasElementGroup ? extraElementGroupToJSON() : null);
              }
            switch (field_name[12])
              {
                case 'Q':
                    if ((String.Compare(field_name, 13, "uery", 0, 4, false) == 0) && (field_name.Length == 17))
                        return (flagHasElementGroupQuery ? extraElementGroupQueryToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraChemicalElementGroupQueryInformationNuggetLookup(field_name);
      }

    public void setElementGroup(ChemicalElementGroupJSON  new_value)
      {
        if (flagHasElementGroup)
          {
          }
        flagHasElementGroup = true;
        storeElementGroup = new_value;
      }
    public void unsetElementGroup()
      {
        if (flagHasElementGroup)
          {
          }
        flagHasElementGroup = false;
      }
    public void setElementGroupQuery(TypeElementGroupQuery new_value)
      {
        flagHasElementGroupQuery = true;
        storeElementGroupQuery = new_value;
      }
    public void setElementGroupQuery(string chars)
      {
        TypeElementGroupQueryKnownValues known = stringToElementGroupQuery(chars);
        TypeElementGroupQuery new_value = new TypeElementGroupQuery();
        if (known == TypeElementGroupQueryKnownValues.ElementGroupQuery__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setElementGroupQuery(new_value);
      }
    public void setElementGroupQuery(TypeElementGroupQueryKnownValues new_value)
      {
        TypeElementGroupQuery new_full_value = new TypeElementGroupQuery();
        Debug.Assert(new_value != TypeElementGroupQueryKnownValues.ElementGroupQuery__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setElementGroupQuery(new_full_value);
      }
    public void unsetElementGroupQuery()
      {
        flagHasElementGroupQuery = false;
      }

    public virtual void extraChemicalElementGroupQueryInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChemicalElementGroupQueryInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChemicalElementGroupQueryInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraChemicalElementGroupQueryInformationNuggetAppendPair(key, new_component);
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
        if (String.Compare(key, 0, "ElementGroup", 0, 12, false) == 0)
          {
            if (key.Length == 12)
              {
                {
                fromJSONElementGroup(new_component, false);
                return;
                }
              }
            switch (key[12])
              {
                case 'Q':
                    if ((String.Compare(key, 13, "uery", 0, 4, false) == 0) && (key.Length == 17))
                        {
                        fromJSONElementGroupQuery(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraChemicalElementGroupQueryInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "ElementGroup", 0, 12, false) == 0)
          {
            if (key.Length == 12)
              {
                {
                fromJSONElementGroup(new_component, false);
                return;
                }
              }
            switch (key[12])
              {
                case 'Q':
                    if ((String.Compare(key, 13, "uery", 0, 4, false) == 0) && (key.Length == 17))
                        {
                        fromJSONElementGroupQuery(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraChemicalElementGroupQueryInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasElementGroup);
        if (flagHasElementGroup)
          {
            handler.start_pair("ElementGroup");
            if (partial_allowed)
                storeElementGroup.write_partial_as_json(handler);
            else
                storeElementGroup.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasElementGroupQuery);
        if (flagHasElementGroupQuery)
          {
            handler.start_pair("ElementGroupQuery");
            if (storeElementGroupQuery.in_known_list)
              {
                switch (storeElementGroupQuery.list_value)
                  {
                    case TypeElementGroupQueryKnownValues.ElementGroupQuery_General:
                        handler.string_value("General");
                        break;
                    case TypeElementGroupQueryKnownValues.ElementGroupQuery_Name:
                        handler.string_value("Name");
                        break;
                    case TypeElementGroupQueryKnownValues.ElementGroupQuery_Symbol:
                        handler.string_value("Symbol");
                        break;
                    case TypeElementGroupQueryKnownValues.ElementGroupQuery_AtomicNumber:
                        handler.string_value("AtomicNumber");
                        break;
                    case TypeElementGroupQueryKnownValues.ElementGroupQuery_AtomicMass:
                        handler.string_value("AtomicMass");
                        break;
                    case TypeElementGroupQueryKnownValues.ElementGroupQuery_Amount:
                        handler.string_value("Amount");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeElementGroupQuery.string_value);
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
        if (!(hasElementGroup()))
          {
            return "When parsing the object for %what%, the \"ElementGroup\" field was missing.";
          }
        if (!(hasElementGroupQuery()))
          {
            return "When parsing the object for %what%, the \"ElementGroupQuery\" field was missing.";
          }
        return null;
      }

    public static new ChemicalElementGroupQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChemicalElementGroupQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementGroupQueryInformationNugget", ignore_extras);
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
    public static new ChemicalElementGroupQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChemicalElementGroupQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChemicalElementGroupQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementGroupQueryInformationNugget", ignore_extras);
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
    public static new ChemicalElementGroupQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChemicalElementGroupQueryInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ChemicalElementGroupQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementGroupQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChemicalElementGroupQueryInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ChemicalElementGroupQueryInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChemicalElementGroupQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementGroupQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private ChemicalElementGroupJSON.HoldingGenerator fieldGeneratorElementGroup;
    private abstract class FieldGeneratorElementGroupQuery : JSONStringGenerator
          {
            protected FieldGeneratorElementGroupQuery(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorElementGroupQuery()
              {
              }
            protected override void handle_result(string result)
              {
                TypeElementGroupQueryKnownValues known = stringToElementGroupQuery(result);
                TypeElementGroupQuery new_value = new TypeElementGroupQuery();
                if (known == TypeElementGroupQueryKnownValues.ElementGroupQuery__none)
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
            protected abstract void handle_result(TypeElementGroupQuery result);
          };
    private class FieldHoldingGeneratorElementGroupQuery : FieldGeneratorElementGroupQuery
  {
    protected override void handle_result(TypeElementGroupQuery result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorElementGroupQuery(String what)
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
    public TypeElementGroupQuery value;
  };
    private class FieldHoldingArrayGeneratorElementGroupQuery : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorElementGroupQuery
      {
        private FieldHoldingArrayGeneratorElementGroupQuery top;

        protected override void handle_result(TypeElementGroupQuery result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorElementGroupQuery init_top)
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
    protected virtual void handle_result(List<TypeElementGroupQuery> result)
      {
      }

    public FieldHoldingArrayGeneratorElementGroupQuery(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeElementGroupQuery>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorElementGroupQuery()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeElementGroupQuery>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeElementGroupQuery> value;
  };
        private FieldHoldingGeneratorElementGroupQuery fieldGeneratorElementGroupQuery;
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
            if (!(getInformationNuggetJSONKey().Equals("ChemicalElementGroupQueryInformationNugget")))
                throw new Exception("The key field has a value other than `ChemicalElementGroupQueryInformationNugget'.");
            ChemicalElementGroupQueryInformationNuggetJSON result = new ChemicalElementGroupQueryInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChemicalElementGroupQueryInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((ChemicalElementGroupQueryInformationNuggetJSON )new_result);
          }
        protected void finish(ChemicalElementGroupQueryInformationNuggetJSON result)
          {
            if (fieldGeneratorElementGroup.have_value)
              {
                result.setElementGroup(fieldGeneratorElementGroup.value);
                fieldGeneratorElementGroup.have_value = false;
              }
            else if ((!(result.hasElementGroup())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ElementGroup\" field was missing.");
              }
            if (fieldGeneratorElementGroupQuery.have_value)
              {
                result.setElementGroupQuery(fieldGeneratorElementGroupQuery.value);
                fieldGeneratorElementGroupQuery.have_value = false;
              }
            else if ((!(result.hasElementGroupQuery())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ElementGroupQuery\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ChemicalElementGroupQueryInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "ElementGroup", 0, 12, false) == 0)
              {
                if (field_name.Length == 12)
                  {
                    return fieldGeneratorElementGroup;
                  }
                switch (field_name[12])
                  {
                    case 'Q':
                        if ((String.Compare(field_name, 13, "uery", 0, 4, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorElementGroupQuery;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorElementGroup = new ChemicalElementGroupJSON.HoldingGenerator("field \"ElementGroup\" of the ChemicalElementGroupQueryInformationNugget class", ignore_extras);
            fieldGeneratorElementGroupQuery = new FieldHoldingGeneratorElementGroupQuery("field \"ElementGroupQuery\" of the ChemicalElementGroupQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChemicalElementGroupQueryInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorElementGroup = new ChemicalElementGroupJSON.HoldingGenerator("field \"ElementGroup\" of the ChemicalElementGroupQueryInformationNugget class", false);
            fieldGeneratorElementGroupQuery = new FieldHoldingGeneratorElementGroupQuery("field \"ElementGroupQuery\" of the ChemicalElementGroupQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChemicalElementGroupQueryInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorElementGroup.reset();
            fieldGeneratorElementGroupQuery.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ChemicalElementGroupQueryInformationNuggetJSON  result)
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
        public ChemicalElementGroupQueryInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChemicalElementGroupQueryInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ChemicalElementGroupQueryInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChemicalElementGroupQueryInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChemicalElementGroupQueryInformationNuggetJSON>();
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
    public List<ChemicalElementGroupQueryInformationNuggetJSON> value;
  };
  };
