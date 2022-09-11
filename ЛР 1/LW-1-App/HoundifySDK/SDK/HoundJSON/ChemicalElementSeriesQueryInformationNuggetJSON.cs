/* file "ChemicalElementSeriesQueryInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ChemicalElementSeriesQueryInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeElementSeriesQueryKnownValues
      {
        ElementSeriesQuery_General,
        ElementSeriesQuery_Name,
        ElementSeriesQuery_Symbol,
        ElementSeriesQuery_AtomicNumber,
        ElementSeriesQuery_AtomicMass,
        ElementSeriesQuery_Amount,
        ElementSeriesQuery__none
      };
    public struct TypeElementSeriesQuery
      {
        public bool in_known_list;
        public string string_value;
        public TypeElementSeriesQueryKnownValues list_value;
      };

    public static TypeElementSeriesQueryKnownValues  stringToElementSeriesQuery(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'm':
                        if ((String.Compare(chars, 2, "ount", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Amount;
                        break;
                    case 't':
                        if (String.Compare(chars, 2, "omic", 0, 4, false) == 0)
                          {
                            switch (chars[6])
                              {
                                case 'M':
                                    if ((String.Compare(chars, 7, "ass", 0, 3, false) == 0) && (chars.Length == 10))
                                        return TypeElementSeriesQueryKnownValues.ElementSeriesQuery_AtomicMass;
                                    break;
                                case 'N':
                                    if ((String.Compare(chars, 7, "umber", 0, 5, false) == 0) && (chars.Length == 12))
                                        return TypeElementSeriesQueryKnownValues.ElementSeriesQuery_AtomicNumber;
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
                    return TypeElementSeriesQueryKnownValues.ElementSeriesQuery_General;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "ame", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Name;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "ymbol", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Symbol;
                break;
            default:
                break;
          }
        return TypeElementSeriesQueryKnownValues.ElementSeriesQuery__none;
      }

    public static string  stringFromElementSeriesQuery(TypeElementSeriesQueryKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_General:
                return "General";
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Name:
                return "Name";
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Symbol:
                return "Symbol";
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_AtomicNumber:
                return "AtomicNumber";
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_AtomicMass:
                return "AtomicMass";
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Amount:
                return "Amount";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasElementSeries;
    private ChemicalElementSeriesJSON  storeElementSeries;
    private bool flagHasElementSeriesQuery;
    private TypeElementSeriesQuery storeElementSeriesQuery;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraElementSeriesToJSON()
      {
        JSONValueHandler handler_ElementSeries = new JSONValueHandler();
        storeElementSeries.write_as_json(handler_ElementSeries);
        return handler_ElementSeries.result;
      }

    private JSONValue  extraElementSeriesQueryToJSON()
      {
        JSONStringValue generated_string_ElementSeriesQuery;
        if (!(storeElementSeriesQuery.in_known_list))
          {
        generated_string_ElementSeriesQuery = new JSONStringValue(storeElementSeriesQuery.string_value);
          }
        else
          {
        switch (storeElementSeriesQuery.list_value)
          {
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_General:
                generated_string_ElementSeriesQuery = new JSONStringValue("General");
                break;
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Name:
                generated_string_ElementSeriesQuery = new JSONStringValue("Name");
                break;
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Symbol:
                generated_string_ElementSeriesQuery = new JSONStringValue("Symbol");
                break;
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_AtomicNumber:
                generated_string_ElementSeriesQuery = new JSONStringValue("AtomicNumber");
                break;
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_AtomicMass:
                generated_string_ElementSeriesQuery = new JSONStringValue("AtomicMass");
                break;
            case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Amount:
                generated_string_ElementSeriesQuery = new JSONStringValue("Amount");
                break;
            default:
                Debug.Assert(false);
                generated_string_ElementSeriesQuery = null;
                break;
          }
          }
        return generated_string_ElementSeriesQuery;
      }


    private void  fromJSONElementSeries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ChemicalElementSeriesJSON convert_classy = ChemicalElementSeriesJSON.from_json(json_value, ignore_extras, true);
        setElementSeries(convert_classy);
      }


    private void  fromJSONElementSeriesQuery(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ElementSeriesQuery of ChemicalElementSeriesQueryInformationNuggetJSON is not a string.");
        TypeElementSeriesQuery the_open_enum = new TypeElementSeriesQuery();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'm':
                        if ((String.Compare(json_string.getData(), 2, "ount", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Amount;
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
                                            the_open_enum.list_value = TypeElementSeriesQueryKnownValues.ElementSeriesQuery_AtomicMass;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'N':
                                    if ((String.Compare(json_string.getData(), 7, "umber", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeElementSeriesQueryKnownValues.ElementSeriesQuery_AtomicNumber;
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
                        the_open_enum.list_value = TypeElementSeriesQueryKnownValues.ElementSeriesQuery_General;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "ame", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Name;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ymbol", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Symbol;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setElementSeriesQuery(the_open_enum);
      }


    public ChemicalElementSeriesQueryInformationNuggetJSON()
      {
        flagHasElementSeries = false;
        flagHasElementSeriesQuery = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "ChemicalElementSeriesQueryInformationNugget";
      }

    public bool  hasElementSeries()
      {
        return flagHasElementSeries;
      }

    public ChemicalElementSeriesJSON   getElementSeries()
      {
        Debug.Assert(flagHasElementSeries);
        return storeElementSeries;
      }

    public bool  hasElementSeriesQuery()
      {
        return flagHasElementSeriesQuery;
      }

    public TypeElementSeriesQuery  getElementSeriesQuery()
      {
        Debug.Assert(flagHasElementSeriesQuery);
        return storeElementSeriesQuery;
      }

    public string  getElementSeriesQueryAsString()
      {
        TypeElementSeriesQuery result = getElementSeriesQuery();
        if (result.in_known_list)
            return stringFromElementSeriesQuery(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraChemicalElementSeriesQueryInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChemicalElementSeriesQueryInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChemicalElementSeriesQueryInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChemicalElementSeriesQueryInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasElementSeries)
            ++result;
        if (flagHasElementSeriesQuery)
            ++result;
        result += extraChemicalElementSeriesQueryInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasElementSeries)
          {
            if (remainder == 0)
                return "ElementSeries";
            --remainder;
          }
        if (flagHasElementSeriesQuery)
          {
            if (remainder == 0)
                return "ElementSeriesQuery";
            --remainder;
          }
        return extraChemicalElementSeriesQueryInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasElementSeries)
          {
            if (remainder == 0)
                return extraElementSeriesToJSON();
            --remainder;
          }
        if (flagHasElementSeriesQuery)
          {
            if (remainder == 0)
                return extraElementSeriesQueryToJSON();
            --remainder;
          }
        return extraChemicalElementSeriesQueryInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "ElementSeries", 0, 13, false) == 0)
          {
            if (field_name.Length == 13)
              {
                return (flagHasElementSeries ? extraElementSeriesToJSON() : null);
              }
            switch (field_name[13])
              {
                case 'Q':
                    if ((String.Compare(field_name, 14, "uery", 0, 4, false) == 0) && (field_name.Length == 18))
                        return (flagHasElementSeriesQuery ? extraElementSeriesQueryToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraChemicalElementSeriesQueryInformationNuggetLookup(field_name);
      }

    public void setElementSeries(ChemicalElementSeriesJSON  new_value)
      {
        if (flagHasElementSeries)
          {
          }
        flagHasElementSeries = true;
        storeElementSeries = new_value;
      }
    public void unsetElementSeries()
      {
        if (flagHasElementSeries)
          {
          }
        flagHasElementSeries = false;
      }
    public void setElementSeriesQuery(TypeElementSeriesQuery new_value)
      {
        flagHasElementSeriesQuery = true;
        storeElementSeriesQuery = new_value;
      }
    public void setElementSeriesQuery(string chars)
      {
        TypeElementSeriesQueryKnownValues known = stringToElementSeriesQuery(chars);
        TypeElementSeriesQuery new_value = new TypeElementSeriesQuery();
        if (known == TypeElementSeriesQueryKnownValues.ElementSeriesQuery__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setElementSeriesQuery(new_value);
      }
    public void setElementSeriesQuery(TypeElementSeriesQueryKnownValues new_value)
      {
        TypeElementSeriesQuery new_full_value = new TypeElementSeriesQuery();
        Debug.Assert(new_value != TypeElementSeriesQueryKnownValues.ElementSeriesQuery__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setElementSeriesQuery(new_full_value);
      }
    public void unsetElementSeriesQuery()
      {
        flagHasElementSeriesQuery = false;
      }

    public virtual void extraChemicalElementSeriesQueryInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChemicalElementSeriesQueryInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChemicalElementSeriesQueryInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraChemicalElementSeriesQueryInformationNuggetAppendPair(key, new_component);
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
        if (String.Compare(key, 0, "ElementSeries", 0, 13, false) == 0)
          {
            if (key.Length == 13)
              {
                {
                fromJSONElementSeries(new_component, false);
                return;
                }
              }
            switch (key[13])
              {
                case 'Q':
                    if ((String.Compare(key, 14, "uery", 0, 4, false) == 0) && (key.Length == 18))
                        {
                        fromJSONElementSeriesQuery(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraChemicalElementSeriesQueryInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "ElementSeries", 0, 13, false) == 0)
          {
            if (key.Length == 13)
              {
                {
                fromJSONElementSeries(new_component, false);
                return;
                }
              }
            switch (key[13])
              {
                case 'Q':
                    if ((String.Compare(key, 14, "uery", 0, 4, false) == 0) && (key.Length == 18))
                        {
                        fromJSONElementSeriesQuery(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraChemicalElementSeriesQueryInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasElementSeries);
        if (flagHasElementSeries)
          {
            handler.start_pair("ElementSeries");
            if (partial_allowed)
                storeElementSeries.write_partial_as_json(handler);
            else
                storeElementSeries.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasElementSeriesQuery);
        if (flagHasElementSeriesQuery)
          {
            handler.start_pair("ElementSeriesQuery");
            if (storeElementSeriesQuery.in_known_list)
              {
                switch (storeElementSeriesQuery.list_value)
                  {
                    case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_General:
                        handler.string_value("General");
                        break;
                    case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Name:
                        handler.string_value("Name");
                        break;
                    case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Symbol:
                        handler.string_value("Symbol");
                        break;
                    case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_AtomicNumber:
                        handler.string_value("AtomicNumber");
                        break;
                    case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_AtomicMass:
                        handler.string_value("AtomicMass");
                        break;
                    case TypeElementSeriesQueryKnownValues.ElementSeriesQuery_Amount:
                        handler.string_value("Amount");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeElementSeriesQuery.string_value);
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
        if (!(hasElementSeries()))
          {
            return "When parsing the object for %what%, the \"ElementSeries\" field was missing.";
          }
        if (!(hasElementSeriesQuery()))
          {
            return "When parsing the object for %what%, the \"ElementSeriesQuery\" field was missing.";
          }
        return null;
      }

    public static new ChemicalElementSeriesQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChemicalElementSeriesQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementSeriesQueryInformationNugget", ignore_extras);
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
    public static new ChemicalElementSeriesQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChemicalElementSeriesQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChemicalElementSeriesQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementSeriesQueryInformationNugget", ignore_extras);
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
    public static new ChemicalElementSeriesQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ChemicalElementSeriesQueryInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ChemicalElementSeriesQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementSeriesQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChemicalElementSeriesQueryInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ChemicalElementSeriesQueryInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChemicalElementSeriesQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementSeriesQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private ChemicalElementSeriesJSON.HoldingGenerator fieldGeneratorElementSeries;
    private abstract class FieldGeneratorElementSeriesQuery : JSONStringGenerator
          {
            protected FieldGeneratorElementSeriesQuery(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorElementSeriesQuery()
              {
              }
            protected override void handle_result(string result)
              {
                TypeElementSeriesQueryKnownValues known = stringToElementSeriesQuery(result);
                TypeElementSeriesQuery new_value = new TypeElementSeriesQuery();
                if (known == TypeElementSeriesQueryKnownValues.ElementSeriesQuery__none)
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
            protected abstract void handle_result(TypeElementSeriesQuery result);
          };
    private class FieldHoldingGeneratorElementSeriesQuery : FieldGeneratorElementSeriesQuery
  {
    protected override void handle_result(TypeElementSeriesQuery result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorElementSeriesQuery(String what)
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
    public TypeElementSeriesQuery value;
  };
    private class FieldHoldingArrayGeneratorElementSeriesQuery : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorElementSeriesQuery
      {
        private FieldHoldingArrayGeneratorElementSeriesQuery top;

        protected override void handle_result(TypeElementSeriesQuery result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorElementSeriesQuery init_top)
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
    protected virtual void handle_result(List<TypeElementSeriesQuery> result)
      {
      }

    public FieldHoldingArrayGeneratorElementSeriesQuery(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeElementSeriesQuery>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorElementSeriesQuery()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeElementSeriesQuery>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeElementSeriesQuery> value;
  };
        private FieldHoldingGeneratorElementSeriesQuery fieldGeneratorElementSeriesQuery;
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
            if (!(getInformationNuggetJSONKey().Equals("ChemicalElementSeriesQueryInformationNugget")))
                throw new Exception("The key field has a value other than `ChemicalElementSeriesQueryInformationNugget'.");
            ChemicalElementSeriesQueryInformationNuggetJSON result = new ChemicalElementSeriesQueryInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChemicalElementSeriesQueryInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((ChemicalElementSeriesQueryInformationNuggetJSON )new_result);
          }
        protected void finish(ChemicalElementSeriesQueryInformationNuggetJSON result)
          {
            if (fieldGeneratorElementSeries.have_value)
              {
                result.setElementSeries(fieldGeneratorElementSeries.value);
                fieldGeneratorElementSeries.have_value = false;
              }
            else if ((!(result.hasElementSeries())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ElementSeries\" field was missing.");
              }
            if (fieldGeneratorElementSeriesQuery.have_value)
              {
                result.setElementSeriesQuery(fieldGeneratorElementSeriesQuery.value);
                fieldGeneratorElementSeriesQuery.have_value = false;
              }
            else if ((!(result.hasElementSeriesQuery())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ElementSeriesQuery\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ChemicalElementSeriesQueryInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "ElementSeries", 0, 13, false) == 0)
              {
                if (field_name.Length == 13)
                  {
                    return fieldGeneratorElementSeries;
                  }
                switch (field_name[13])
                  {
                    case 'Q':
                        if ((String.Compare(field_name, 14, "uery", 0, 4, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorElementSeriesQuery;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorElementSeries = new ChemicalElementSeriesJSON.HoldingGenerator("field \"ElementSeries\" of the ChemicalElementSeriesQueryInformationNugget class", ignore_extras);
            fieldGeneratorElementSeriesQuery = new FieldHoldingGeneratorElementSeriesQuery("field \"ElementSeriesQuery\" of the ChemicalElementSeriesQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChemicalElementSeriesQueryInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorElementSeries = new ChemicalElementSeriesJSON.HoldingGenerator("field \"ElementSeries\" of the ChemicalElementSeriesQueryInformationNugget class", false);
            fieldGeneratorElementSeriesQuery = new FieldHoldingGeneratorElementSeriesQuery("field \"ElementSeriesQuery\" of the ChemicalElementSeriesQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChemicalElementSeriesQueryInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorElementSeries.reset();
            fieldGeneratorElementSeriesQuery.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ChemicalElementSeriesQueryInformationNuggetJSON  result)
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
        public ChemicalElementSeriesQueryInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChemicalElementSeriesQueryInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ChemicalElementSeriesQueryInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChemicalElementSeriesQueryInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChemicalElementSeriesQueryInformationNuggetJSON>();
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
    public List<ChemicalElementSeriesQueryInformationNuggetJSON> value;
  };
  };
