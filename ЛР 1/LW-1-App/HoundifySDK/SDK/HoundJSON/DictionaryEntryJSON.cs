/* file "DictionaryEntryJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class DictionaryEntryJSON : JSONBase
  {
    private bool flagHasTerm;
    private string storeTerm;
    private bool flagHasID;
    private BigInteger storeID;
    private bool flagHasDefinitions;
    private List< DictionaryDefinitionJSON  > storeDefinitions;
    private bool flagHasDefinitionsDisplay;
    private string storeDefinitionsDisplay;
    private bool flagHasSynonyms;
    private List< string > storeSynonyms;
    private bool flagHasAntonyms;
    private List< string > storeAntonyms;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTerm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Term of DictionaryEntryJSON is not a string.");
        setTerm(json_string.getData());
      }


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ID of DictionaryEntryJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ID of DictionaryEntryJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setID(extracted_integer);
      }


    private void  fromJSONDefinitions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Definitions of DictionaryEntryJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DictionaryDefinitionJSON  > vector_Definitions1 = new List< DictionaryDefinitionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DictionaryDefinitionJSON convert_classy = DictionaryDefinitionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Definitions1.Add(convert_classy);
          }
        initDefinitions();
        for (int num1 = 0; num1 < vector_Definitions1.Count; ++num1)
            appendDefinitions(vector_Definitions1[num1]);
        for (int num1 = 0; num1 < vector_Definitions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDefinitionsDisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DefinitionsDisplay of DictionaryEntryJSON is not a string.");
        setDefinitionsDisplay(json_string.getData());
      }


    private void  fromJSONSynonyms(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Synonyms of DictionaryEntryJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Synonyms1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Synonyms of DictionaryEntryJSON is not a string.");
            vector_Synonyms1.Add(json_string.getData());
          }
        initSynonyms();
        for (int num2 = 0; num2 < vector_Synonyms1.Count; ++num2)
            appendSynonyms(vector_Synonyms1[num2]);
        for (int num1 = 0; num1 < vector_Synonyms1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAntonyms(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Antonyms of DictionaryEntryJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Antonyms1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Antonyms of DictionaryEntryJSON is not a string.");
            vector_Antonyms1.Add(json_string.getData());
          }
        initAntonyms();
        for (int num3 = 0; num3 < vector_Antonyms1.Count; ++num3)
            appendAntonyms(vector_Antonyms1[num3]);
        for (int num1 = 0; num1 < vector_Antonyms1.Count; ++num1)
          {
          }
      }


    public DictionaryEntryJSON()
      {
        flagHasTerm = false;
        flagHasID = false;
        flagHasDefinitions = false;
        flagHasDefinitionsDisplay = false;
        flagHasSynonyms = false;
        flagHasAntonyms = false;
        storeDefinitions = new List< DictionaryDefinitionJSON  >();
        storeSynonyms = new List< string >();
        storeAntonyms = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTerm()
      {
        return flagHasTerm;
      }

    public string  getTerm()
      {
        Debug.Assert(flagHasTerm);
        return storeTerm;
      }

    public bool  hasID()
      {
        return flagHasID;
      }

    public BigInteger  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }

    public bool  hasDefinitions()
      {
        return flagHasDefinitions;
      }

    public int  countOfDefinitions()
      {
        Debug.Assert(flagHasDefinitions);
        return storeDefinitions.Count;
      }

    public DictionaryDefinitionJSON   elementOfDefinitions(int element_num)
      {
        Debug.Assert(flagHasDefinitions);
        return storeDefinitions[element_num];
      }

    public List< DictionaryDefinitionJSON  >  getDefinitions()
      {
        Debug.Assert(flagHasDefinitions);
        return storeDefinitions;
      }

    public bool  hasDefinitionsDisplay()
      {
        return flagHasDefinitionsDisplay;
      }

    public string  getDefinitionsDisplay()
      {
        Debug.Assert(flagHasDefinitionsDisplay);
        return storeDefinitionsDisplay;
      }

    public bool  hasSynonyms()
      {
        return flagHasSynonyms;
      }

    public int  countOfSynonyms()
      {
        Debug.Assert(flagHasSynonyms);
        return storeSynonyms.Count;
      }

    public string  elementOfSynonyms(int element_num)
      {
        Debug.Assert(flagHasSynonyms);
        return storeSynonyms[element_num];
      }

    public List< string >  getSynonyms()
      {
        Debug.Assert(flagHasSynonyms);
        return storeSynonyms;
      }

    public bool  hasAntonyms()
      {
        return flagHasAntonyms;
      }

    public int  countOfAntonyms()
      {
        Debug.Assert(flagHasAntonyms);
        return storeAntonyms.Count;
      }

    public string  elementOfAntonyms(int element_num)
      {
        Debug.Assert(flagHasAntonyms);
        return storeAntonyms[element_num];
      }

    public List< string >  getAntonyms()
      {
        Debug.Assert(flagHasAntonyms);
        return storeAntonyms;
      }


    public virtual int extraDictionaryEntryComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDictionaryEntryComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDictionaryEntryComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDictionaryEntryLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTerm(string new_value)
      {
        flagHasTerm = true;
        storeTerm = new_value;
      }
    public void unsetTerm()
      {
        flagHasTerm = false;
      }
    public void setID(BigInteger new_value)
      {
        flagHasID = true;
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void initDefinitions()
      {
        if (flagHasDefinitions)
          {
            for (int num1 = 0; num1 < storeDefinitions.Count; ++num1)
              {
              }
          }
        flagHasDefinitions = true;
        storeDefinitions.Clear();
      }
    public void appendDefinitions(DictionaryDefinitionJSON  to_append)
      {
        if (!flagHasDefinitions)
          {
            flagHasDefinitions = true;
            storeDefinitions.Clear();
          }
        Debug.Assert(flagHasDefinitions);
        storeDefinitions.Add(to_append);
      }
    public void unsetDefinitions()
      {
        if (flagHasDefinitions)
          {
            for (int num2 = 0; num2 < storeDefinitions.Count; ++num2)
              {
              }
          }
        flagHasDefinitions = false;
        storeDefinitions.Clear();
      }
    public void setDefinitionsDisplay(string new_value)
      {
        flagHasDefinitionsDisplay = true;
        storeDefinitionsDisplay = new_value;
      }
    public void unsetDefinitionsDisplay()
      {
        flagHasDefinitionsDisplay = false;
      }
    public void initSynonyms()
      {
        flagHasSynonyms = true;
        storeSynonyms.Clear();
      }
    public void appendSynonyms(string to_append)
      {
        if (!flagHasSynonyms)
          {
            flagHasSynonyms = true;
            storeSynonyms.Clear();
          }
        Debug.Assert(flagHasSynonyms);
        storeSynonyms.Add(to_append);
      }
    public void unsetSynonyms()
      {
        flagHasSynonyms = false;
        storeSynonyms.Clear();
      }
    public void initAntonyms()
      {
        flagHasAntonyms = true;
        storeAntonyms.Clear();
      }
    public void appendAntonyms(string to_append)
      {
        if (!flagHasAntonyms)
          {
            flagHasAntonyms = true;
            storeAntonyms.Clear();
          }
        Debug.Assert(flagHasAntonyms);
        storeAntonyms.Add(to_append);
      }
    public void unsetAntonyms()
      {
        flagHasAntonyms = false;
        storeAntonyms.Clear();
      }

    public virtual void extraDictionaryEntryAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDictionaryEntrySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDictionaryEntryLookup(key);
        if (old_field == null)
          {
            extraDictionaryEntryAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTerm);
        if (flagHasTerm)
          {
            handler.start_pair("Term");
            handler.string_value(storeTerm);
          }
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.number_value(storeID);
          }
        if (flagHasDefinitions)
          {
            handler.start_pair("Definitions");
            handler.start_array();
            for (int num1 = 0; num1 < storeDefinitions.Count; ++num1)
              {
                if (partial_allowed)
                    storeDefinitions[num1].write_partial_as_json(handler);
                else
                    storeDefinitions[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDefinitionsDisplay)
          {
            handler.start_pair("DefinitionsDisplay");
            handler.string_value(storeDefinitionsDisplay);
          }
        if (flagHasSynonyms)
          {
            handler.start_pair("Synonyms");
            handler.start_array();
            for (int num2 = 0; num2 < storeSynonyms.Count; ++num2)
              {
                handler.string_value(storeSynonyms[num2]);
              }
            handler.finish_array();
          }
        if (flagHasAntonyms)
          {
            handler.start_pair("Antonyms");
            handler.start_array();
            for (int num3 = 0; num3 < storeAntonyms.Count; ++num3)
              {
                handler.string_value(storeAntonyms[num3]);
              }
            handler.finish_array();
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
        if (!(hasTerm()))
          {
            return "When parsing the object for %what%, the \"Term\" field was missing.";
          }
        return null;
      }

    public static DictionaryEntryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DictionaryEntryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryEntry", ignore_extras);
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
    public static DictionaryEntryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DictionaryEntryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DictionaryEntryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryEntry", ignore_extras);
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
    public static DictionaryEntryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DictionaryEntryJSON from_text(string text, bool ignore_extras)
      {
        DictionaryEntryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryEntry", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DictionaryEntryJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DictionaryEntryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DictionaryEntryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryEntry", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTerm;
    private class FieldHoldingGeneratorID : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorID(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorID : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorID(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorID fieldGeneratorID;
        private DictionaryDefinitionJSON.HoldingArrayGenerator fieldGeneratorDefinitions;
        private JSONHoldingStringGenerator fieldGeneratorDefinitionsDisplay;
        private JSONHoldingStringArrayGenerator fieldGeneratorSynonyms;
        private JSONHoldingStringArrayGenerator fieldGeneratorAntonyms;
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
            DictionaryEntryJSON result = new DictionaryEntryJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDictionaryEntryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DictionaryEntryJSON result)
          {
            if (fieldGeneratorTerm.have_value)
              {
                result.setTerm(fieldGeneratorTerm.value);
                fieldGeneratorTerm.have_value = false;
              }
            else if ((!(result.hasTerm())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Term\" field was missing.");
              }
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            if (fieldGeneratorDefinitions.have_value)
              {
                result.initDefinitions();
                int count = fieldGeneratorDefinitions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDefinitions(fieldGeneratorDefinitions.value[num]);
                  }
                fieldGeneratorDefinitions.value.Clear();
                fieldGeneratorDefinitions.have_value = false;
              }
            if (fieldGeneratorDefinitionsDisplay.have_value)
              {
                result.setDefinitionsDisplay(fieldGeneratorDefinitionsDisplay.value);
                fieldGeneratorDefinitionsDisplay.have_value = false;
              }
            if (fieldGeneratorSynonyms.have_value)
              {
                result.initSynonyms();
                int count = fieldGeneratorSynonyms.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSynonyms(fieldGeneratorSynonyms.value[num]);
                  }
                fieldGeneratorSynonyms.value.Clear();
                fieldGeneratorSynonyms.have_value = false;
              }
            if (fieldGeneratorAntonyms.have_value)
              {
                result.initAntonyms();
                int count = fieldGeneratorAntonyms.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAntonyms(fieldGeneratorAntonyms.value[num]);
                  }
                fieldGeneratorAntonyms.value.Clear();
                fieldGeneratorAntonyms.have_value = false;
              }
          }
        protected abstract void handle_result(DictionaryEntryJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ntonyms", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorAntonyms;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "efinitions", 0, 10, false) == 0)
                      {
                        if (field_name.Length == 11)
                          {
                            return fieldGeneratorDefinitions;
                          }
                        switch (field_name[11])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 12, "isplay", 0, 6, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorDefinitionsDisplay;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorID;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ynonyms", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorSynonyms;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "erm", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorTerm;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTerm = new JSONHoldingStringGenerator("field \"Term\" of the DictionaryEntry class");
            fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the DictionaryEntry class");
            fieldGeneratorDefinitions = new DictionaryDefinitionJSON.HoldingArrayGenerator("field \"Definitions\" of the DictionaryEntry class", ignore_extras);
            fieldGeneratorDefinitionsDisplay = new JSONHoldingStringGenerator("field \"DefinitionsDisplay\" of the DictionaryEntry class");
            fieldGeneratorSynonyms = new JSONHoldingStringArrayGenerator("field \"Synonyms\" of the DictionaryEntry class");
            fieldGeneratorAntonyms = new JSONHoldingStringArrayGenerator("field \"Antonyms\" of the DictionaryEntry class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DictionaryEntry class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTerm = new JSONHoldingStringGenerator("field \"Term\" of the DictionaryEntry class");
            fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the DictionaryEntry class");
            fieldGeneratorDefinitions = new DictionaryDefinitionJSON.HoldingArrayGenerator("field \"Definitions\" of the DictionaryEntry class", false);
            fieldGeneratorDefinitionsDisplay = new JSONHoldingStringGenerator("field \"DefinitionsDisplay\" of the DictionaryEntry class");
            fieldGeneratorSynonyms = new JSONHoldingStringArrayGenerator("field \"Synonyms\" of the DictionaryEntry class");
            fieldGeneratorAntonyms = new JSONHoldingStringArrayGenerator("field \"Antonyms\" of the DictionaryEntry class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DictionaryEntry class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTerm.reset();
            fieldGeneratorID.reset();
            fieldGeneratorDefinitions.reset();
            fieldGeneratorDefinitionsDisplay.reset();
            fieldGeneratorSynonyms.reset();
            fieldGeneratorAntonyms.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDefinitions.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDefinitions.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DictionaryEntryJSON  result)
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
        public DictionaryEntryJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DictionaryEntryJSON  result)
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
    protected virtual void handle_result(List<DictionaryEntryJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DictionaryEntryJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DictionaryEntryJSON>();
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
    public List<DictionaryEntryJSON> value;
  };
  };
