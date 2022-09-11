/* file "ChemicalElementJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ChemicalElementJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasSymbol;
    private string storeSymbol;
    private bool flagHasSpokenSymbol;
    private string storeSpokenSymbol;
    private bool flagHasAtomicNumber;
    private BigInteger storeAtomicNumber;
    private bool flagHasAtomicMass;
    private double storeAtomicMass;
    private string textStoreAtomicMass;
    private bool flagHasGroupNumber;
    private sbyte storeGroupNumber;
    private bool flagHasSeriesName;
    private ChemicalElementSeriesNameJSON  storeSeriesName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of ChemicalElementJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Symbol of ChemicalElementJSON is not a string.");
        setSymbol(json_string.getData());
      }


    private void  fromJSONSpokenSymbol(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenSymbol of ChemicalElementJSON is not a string.");
        setSpokenSymbol(json_string.getData());
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
                throw new Exception("The value for field AtomicNumber of ChemicalElementJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AtomicNumber of ChemicalElementJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAtomicNumber(extracted_integer);
      }


    private void  fromJSONAtomicMass(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AtomicMass of ChemicalElementJSON is not a number.");
              }
          }
        setAtomicMassText(the_rational_text);
      }


    private void  fromJSONGroupNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GroupNumber of ChemicalElementJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GroupNumber of ChemicalElementJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setGroupNumber(extracted_integer);
      }


    private void  fromJSONSeriesName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ChemicalElementSeriesNameJSON convert_classy = ChemicalElementSeriesNameJSON.from_json(json_value, ignore_extras, true);
        setSeriesName(convert_classy);
      }


    public ChemicalElementJSON()
      {
        flagHasName = false;
        flagHasSymbol = false;
        flagHasSpokenSymbol = false;
        flagHasAtomicNumber = false;
        flagHasAtomicMass = false;
        flagHasGroupNumber = false;
        flagHasSeriesName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasSymbol()
      {
        return flagHasSymbol;
      }

    public string  getSymbol()
      {
        Debug.Assert(flagHasSymbol);
        return storeSymbol;
      }

    public bool  hasSpokenSymbol()
      {
        return flagHasSpokenSymbol;
      }

    public string  getSpokenSymbol()
      {
        Debug.Assert(flagHasSpokenSymbol);
        return storeSpokenSymbol;
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

    public bool  hasAtomicMass()
      {
        return flagHasAtomicMass;
      }

    public double  getAtomicMass()
      {
        Debug.Assert(flagHasAtomicMass);
        if (textStoreAtomicMass != "")
          {
            return Double.Parse(textStoreAtomicMass);
          }
        return storeAtomicMass;
      }

    public string  getAtomicMassAsText()
      {
        Debug.Assert(flagHasAtomicMass);
        if (textStoreAtomicMass == "")
          {
            return Convert.ToString(storeAtomicMass);
          }
        else
          {
            return (textStoreAtomicMass);
          }
      }

    public bool  hasGroupNumber()
      {
        return flagHasGroupNumber;
      }

    public sbyte  getGroupNumber()
      {
        Debug.Assert(flagHasGroupNumber);
        return storeGroupNumber;
      }

    public bool  hasSeriesName()
      {
        return flagHasSeriesName;
      }

    public ChemicalElementSeriesNameJSON   getSeriesName()
      {
        Debug.Assert(flagHasSeriesName);
        return storeSeriesName;
      }

    public ChemicalElementSeriesNameJSON.TypeValue  getSeriesNameValue()
      {
        return getSeriesName().getValue();
      }

    public string  getSeriesNameAsString()
      {
        return getSeriesName().getValueAsString();
      }


    public virtual int extraChemicalElementComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChemicalElementComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChemicalElementComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChemicalElementLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setSymbol(string new_value)
      {
        flagHasSymbol = true;
        storeSymbol = new_value;
      }
    public void unsetSymbol()
      {
        flagHasSymbol = false;
      }
    public void setSpokenSymbol(string new_value)
      {
        flagHasSpokenSymbol = true;
        storeSpokenSymbol = new_value;
      }
    public void unsetSpokenSymbol()
      {
        flagHasSpokenSymbol = false;
      }
    public void setAtomicNumber(BigInteger new_value)
      {
        flagHasAtomicNumber = true;
        if (new_value < 0)
            throw new Exception("The value for field AtomicNumber of ChemicalElementJSON is less than the lower bound (0) for that field.");
        storeAtomicNumber = new_value;
      }
    public void unsetAtomicNumber()
      {
        flagHasAtomicNumber = false;
      }
    public void setAtomicMass(double new_value)
      {
        flagHasAtomicMass = true;
        storeAtomicMass = new_value;
        textStoreAtomicMass = "";
      }
    public void setAtomicMassText(string new_value)
      {
        flagHasAtomicMass = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field AtomicMass of ChemicalElementJSON is not a valid number.");
        textStoreAtomicMass = new_value;
      }
    public void unsetAtomicMass()
      {
        flagHasAtomicMass = false;
      }
    public void setGroupNumber(sbyte new_value)
      {
        flagHasGroupNumber = true;
        if (new_value < 0)
            throw new Exception("The value for field GroupNumber of ChemicalElementJSON is less than the lower bound (0) for that field.");
        if (new_value > 18)
            throw new Exception("The value for field GroupNumber of ChemicalElementJSON is greater than the upper bound (18) for that field.");
        storeGroupNumber = new_value;
      }
    public void unsetGroupNumber()
      {
        flagHasGroupNumber = false;
      }
    public void setSeriesName(ChemicalElementSeriesNameJSON  new_value)
      {
        if (flagHasSeriesName)
          {
          }
        flagHasSeriesName = true;
        storeSeriesName = new_value;
      }
    public void setSeriesName(ChemicalElementSeriesNameJSON.TypeValue new_value)
      {
        setSeriesName(new ChemicalElementSeriesNameJSON(new_value));
      }
    public void setSeriesName(string chars)
      {
        ChemicalElementSeriesNameJSON.TypeValueKnownValues known = ChemicalElementSeriesNameJSON.stringToValue(chars);
        ChemicalElementSeriesNameJSON.TypeValue new_value = new ChemicalElementSeriesNameJSON.TypeValue();
        if (known == ChemicalElementSeriesNameJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSeriesName(new_value);
      }
    public void unsetSeriesName()
      {
        if (flagHasSeriesName)
          {
          }
        flagHasSeriesName = false;
      }

    public virtual void extraChemicalElementAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChemicalElementSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChemicalElementLookup(key);
        if (old_field == null)
          {
            extraChemicalElementAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        Debug.Assert(partial_allowed || flagHasSymbol);
        if (flagHasSymbol)
          {
            handler.start_pair("Symbol");
            handler.string_value(storeSymbol);
          }
        Debug.Assert(partial_allowed || flagHasSpokenSymbol);
        if (flagHasSpokenSymbol)
          {
            handler.start_pair("SpokenSymbol");
            handler.string_value(storeSpokenSymbol);
          }
        Debug.Assert(partial_allowed || flagHasAtomicNumber);
        if (flagHasAtomicNumber)
          {
            handler.start_pair("AtomicNumber");
            handler.number_value(storeAtomicNumber);
          }
        Debug.Assert(partial_allowed || flagHasAtomicMass);
        if (flagHasAtomicMass)
          {
            handler.start_pair("AtomicMass");
            if (textStoreAtomicMass != "")
                handler.number_value(textStoreAtomicMass);
            else if (((double)(long)storeAtomicMass) == storeAtomicMass)
                handler.number_value((long)storeAtomicMass);
            else
                handler.number_value(storeAtomicMass);
          }
        if (flagHasGroupNumber)
          {
            handler.start_pair("GroupNumber");
            handler.number_value(storeGroupNumber);
          }
        if (flagHasSeriesName)
          {
            handler.start_pair("SeriesName");
            if (partial_allowed)
                storeSeriesName.write_partial_as_json(handler);
            else
                storeSeriesName.write_as_json(handler);
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        if (!(hasSymbol()))
          {
            return "When parsing the object for %what%, the \"Symbol\" field was missing.";
          }
        if (!(hasSpokenSymbol()))
          {
            return "When parsing the object for %what%, the \"SpokenSymbol\" field was missing.";
          }
        if (!(hasAtomicNumber()))
          {
            return "When parsing the object for %what%, the \"AtomicNumber\" field was missing.";
          }
        if (!(hasAtomicMass()))
          {
            return "When parsing the object for %what%, the \"AtomicMass\" field was missing.";
          }
        return null;
      }

    public static ChemicalElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChemicalElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElement", ignore_extras);
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
    public static ChemicalElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChemicalElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChemicalElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElement", ignore_extras);
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
    public static ChemicalElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChemicalElementJSON from_text(string text, bool ignore_extras)
      {
        ChemicalElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElement", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChemicalElementJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ChemicalElementJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChemicalElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElement", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorSymbol;
        private JSONHoldingStringGenerator fieldGeneratorSpokenSymbol;
    private class FieldHoldingGeneratorAtomicNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorAtomicNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorAtomicNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorAtomicNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorAtomicNumber fieldGeneratorAtomicNumber;
        private JSONHoldingNumberTextGenerator fieldGeneratorAtomicMass;
    private class FieldHoldingGeneratorGroupNumber : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorGroupNumber(String what) : base(what, 0, 18)
              {
              }
          };
    private class FieldHoldingArrayGeneratorGroupNumber : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorGroupNumber(String what) : base(what, 0, 18)
              {
              }
          };
        private FieldHoldingGeneratorGroupNumber fieldGeneratorGroupNumber;
        private ChemicalElementSeriesNameJSON.HoldingGenerator fieldGeneratorSeriesName;
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
            ChemicalElementJSON result = new ChemicalElementJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChemicalElementAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ChemicalElementJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorSymbol.have_value)
              {
                result.setSymbol(fieldGeneratorSymbol.value);
                fieldGeneratorSymbol.have_value = false;
              }
            else if ((!(result.hasSymbol())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Symbol\" field was missing.");
              }
            if (fieldGeneratorSpokenSymbol.have_value)
              {
                result.setSpokenSymbol(fieldGeneratorSpokenSymbol.value);
                fieldGeneratorSpokenSymbol.have_value = false;
              }
            else if ((!(result.hasSpokenSymbol())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenSymbol\" field was missing.");
              }
            if (fieldGeneratorAtomicNumber.have_value)
              {
                result.setAtomicNumber(fieldGeneratorAtomicNumber.value);
                fieldGeneratorAtomicNumber.have_value = false;
              }
            else if ((!(result.hasAtomicNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AtomicNumber\" field was missing.");
              }
            if (fieldGeneratorAtomicMass.have_value)
              {
                result.setAtomicMassText(fieldGeneratorAtomicMass.value);
                fieldGeneratorAtomicMass.have_value = false;
              }
            else if ((!(result.hasAtomicMass())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AtomicMass\" field was missing.");
              }
            if (fieldGeneratorGroupNumber.have_value)
              {
                result.setGroupNumber((sbyte)(fieldGeneratorGroupNumber.value));
                fieldGeneratorGroupNumber.have_value = false;
              }
            if (fieldGeneratorSeriesName.have_value)
              {
                result.setSeriesName(fieldGeneratorSeriesName.value);
                fieldGeneratorSeriesName.have_value = false;
              }
          }
        protected abstract void handle_result(ChemicalElementJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "tomic", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'M':
                                if ((String.Compare(field_name, 7, "ass", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorAtomicMass;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 7, "umber", 0, 5, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorAtomicNumber;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "roupNumber", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorGroupNumber;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "riesName", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSeriesName;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenSymbol", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorSpokenSymbol;
                            break;
                        case 'y':
                            if ((String.Compare(field_name, 2, "mbol", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSymbol;
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
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the ChemicalElement class");
            fieldGeneratorSymbol = new JSONHoldingStringGenerator("field \"Symbol\" of the ChemicalElement class");
            fieldGeneratorSpokenSymbol = new JSONHoldingStringGenerator("field \"SpokenSymbol\" of the ChemicalElement class");
            fieldGeneratorAtomicNumber = new FieldHoldingGeneratorAtomicNumber("field \"AtomicNumber\" of the ChemicalElement class");
            fieldGeneratorAtomicMass = new JSONHoldingNumberTextGenerator("field \"AtomicMass\" of the ChemicalElement class");
            fieldGeneratorGroupNumber = new FieldHoldingGeneratorGroupNumber("field \"GroupNumber\" of the ChemicalElement class");
            fieldGeneratorSeriesName = new ChemicalElementSeriesNameJSON.HoldingGenerator("field \"SeriesName\" of the ChemicalElement class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChemicalElement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the ChemicalElement class");
            fieldGeneratorSymbol = new JSONHoldingStringGenerator("field \"Symbol\" of the ChemicalElement class");
            fieldGeneratorSpokenSymbol = new JSONHoldingStringGenerator("field \"SpokenSymbol\" of the ChemicalElement class");
            fieldGeneratorAtomicNumber = new FieldHoldingGeneratorAtomicNumber("field \"AtomicNumber\" of the ChemicalElement class");
            fieldGeneratorAtomicMass = new JSONHoldingNumberTextGenerator("field \"AtomicMass\" of the ChemicalElement class");
            fieldGeneratorGroupNumber = new FieldHoldingGeneratorGroupNumber("field \"GroupNumber\" of the ChemicalElement class");
            fieldGeneratorSeriesName = new ChemicalElementSeriesNameJSON.HoldingGenerator("field \"SeriesName\" of the ChemicalElement class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChemicalElement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorSymbol.reset();
            fieldGeneratorSpokenSymbol.reset();
            fieldGeneratorAtomicNumber.reset();
            fieldGeneratorAtomicMass.reset();
            fieldGeneratorGroupNumber.reset();
            fieldGeneratorSeriesName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSeriesName.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSeriesName.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ChemicalElementJSON  result)
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
        public ChemicalElementJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChemicalElementJSON  result)
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
    protected virtual void handle_result(List<ChemicalElementJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChemicalElementJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChemicalElementJSON>();
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
    public List<ChemicalElementJSON> value;
  };
  };
