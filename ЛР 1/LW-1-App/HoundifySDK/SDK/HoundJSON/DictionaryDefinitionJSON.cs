/* file "DictionaryDefinitionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DictionaryDefinitionJSON : JSONBase
  {
    private bool flagHasDefinition;
    private string storeDefinition;
    private bool flagHasPartOfSpeech;
    private DictionaryDetailedPartOfSpeechJSON  storePartOfSpeech;
    private bool flagHasGender;
    private DictionaryDetailedGenderJSON  storeGender;
    private bool flagHasExamples;
    private List< string > storeExamples;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDefinition(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Definition of DictionaryDefinitionJSON is not a string.");
        setDefinition(json_string.getData());
      }


    private void  fromJSONPartOfSpeech(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DictionaryDetailedPartOfSpeechJSON convert_classy = DictionaryDetailedPartOfSpeechJSON.from_json(json_value, ignore_extras, true);
        setPartOfSpeech(convert_classy);
      }


    private void  fromJSONGender(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DictionaryDetailedGenderJSON convert_classy = DictionaryDetailedGenderJSON.from_json(json_value, ignore_extras, true);
        setGender(convert_classy);
      }


    private void  fromJSONExamples(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Examples of DictionaryDefinitionJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Examples1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Examples of DictionaryDefinitionJSON is not a string.");
            vector_Examples1.Add(json_string.getData());
          }
        initExamples();
        for (int num1 = 0; num1 < vector_Examples1.Count; ++num1)
            appendExamples(vector_Examples1[num1]);
        for (int num1 = 0; num1 < vector_Examples1.Count; ++num1)
          {
          }
      }


    public DictionaryDefinitionJSON()
      {
        flagHasDefinition = false;
        flagHasPartOfSpeech = false;
        flagHasGender = false;
        flagHasExamples = false;
        storeExamples = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDefinition()
      {
        return flagHasDefinition;
      }

    public string  getDefinition()
      {
        Debug.Assert(flagHasDefinition);
        return storeDefinition;
      }

    public bool  hasPartOfSpeech()
      {
        return flagHasPartOfSpeech;
      }

    public DictionaryDetailedPartOfSpeechJSON   getPartOfSpeech()
      {
        Debug.Assert(flagHasPartOfSpeech);
        return storePartOfSpeech;
      }

    public bool  hasGender()
      {
        return flagHasGender;
      }

    public DictionaryDetailedGenderJSON   getGender()
      {
        Debug.Assert(flagHasGender);
        return storeGender;
      }

    public bool  hasExamples()
      {
        return flagHasExamples;
      }

    public int  countOfExamples()
      {
        Debug.Assert(flagHasExamples);
        return storeExamples.Count;
      }

    public string  elementOfExamples(int element_num)
      {
        Debug.Assert(flagHasExamples);
        return storeExamples[element_num];
      }

    public List< string >  getExamples()
      {
        Debug.Assert(flagHasExamples);
        return storeExamples;
      }


    public virtual int extraDictionaryDefinitionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDictionaryDefinitionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDictionaryDefinitionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDictionaryDefinitionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDefinition(string new_value)
      {
        flagHasDefinition = true;
        storeDefinition = new_value;
      }
    public void unsetDefinition()
      {
        flagHasDefinition = false;
      }
    public void setPartOfSpeech(DictionaryDetailedPartOfSpeechJSON  new_value)
      {
        if (flagHasPartOfSpeech)
          {
          }
        flagHasPartOfSpeech = true;
        storePartOfSpeech = new_value;
      }
    public void unsetPartOfSpeech()
      {
        if (flagHasPartOfSpeech)
          {
          }
        flagHasPartOfSpeech = false;
      }
    public void setGender(DictionaryDetailedGenderJSON  new_value)
      {
        if (flagHasGender)
          {
          }
        flagHasGender = true;
        storeGender = new_value;
      }
    public void unsetGender()
      {
        if (flagHasGender)
          {
          }
        flagHasGender = false;
      }
    public void initExamples()
      {
        flagHasExamples = true;
        storeExamples.Clear();
      }
    public void appendExamples(string to_append)
      {
        if (!flagHasExamples)
          {
            flagHasExamples = true;
            storeExamples.Clear();
          }
        Debug.Assert(flagHasExamples);
        storeExamples.Add(to_append);
      }
    public void unsetExamples()
      {
        flagHasExamples = false;
        storeExamples.Clear();
      }

    public virtual void extraDictionaryDefinitionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDictionaryDefinitionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDictionaryDefinitionLookup(key);
        if (old_field == null)
          {
            extraDictionaryDefinitionAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDefinition);
        if (flagHasDefinition)
          {
            handler.start_pair("Definition");
            handler.string_value(storeDefinition);
          }
        if (flagHasPartOfSpeech)
          {
            handler.start_pair("PartOfSpeech");
            if (partial_allowed)
                storePartOfSpeech.write_partial_as_json(handler);
            else
                storePartOfSpeech.write_as_json(handler);
          }
        if (flagHasGender)
          {
            handler.start_pair("Gender");
            if (partial_allowed)
                storeGender.write_partial_as_json(handler);
            else
                storeGender.write_as_json(handler);
          }
        if (flagHasExamples)
          {
            handler.start_pair("Examples");
            handler.start_array();
            for (int num1 = 0; num1 < storeExamples.Count; ++num1)
              {
                handler.string_value(storeExamples[num1]);
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
        if (!(hasDefinition()))
          {
            return "When parsing the object for %what%, the \"Definition\" field was missing.";
          }
        return null;
      }

    public static DictionaryDefinitionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DictionaryDefinitionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryDefinition", ignore_extras);
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
    public static DictionaryDefinitionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DictionaryDefinitionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DictionaryDefinitionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryDefinition", ignore_extras);
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
    public static DictionaryDefinitionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DictionaryDefinitionJSON from_text(string text, bool ignore_extras)
      {
        DictionaryDefinitionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryDefinition", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DictionaryDefinitionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DictionaryDefinitionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DictionaryDefinitionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryDefinition", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorDefinition;
        private DictionaryDetailedPartOfSpeechJSON.HoldingGenerator fieldGeneratorPartOfSpeech;
        private DictionaryDetailedGenderJSON.HoldingGenerator fieldGeneratorGender;
        private JSONHoldingStringArrayGenerator fieldGeneratorExamples;
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
            DictionaryDefinitionJSON result = new DictionaryDefinitionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDictionaryDefinitionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DictionaryDefinitionJSON result)
          {
            if (fieldGeneratorDefinition.have_value)
              {
                result.setDefinition(fieldGeneratorDefinition.value);
                fieldGeneratorDefinition.have_value = false;
              }
            else if ((!(result.hasDefinition())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Definition\" field was missing.");
              }
            if (fieldGeneratorPartOfSpeech.have_value)
              {
                result.setPartOfSpeech(fieldGeneratorPartOfSpeech.value);
                fieldGeneratorPartOfSpeech.have_value = false;
              }
            if (fieldGeneratorGender.have_value)
              {
                result.setGender(fieldGeneratorGender.value);
                fieldGeneratorGender.have_value = false;
              }
            if (fieldGeneratorExamples.have_value)
              {
                result.initExamples();
                int count = fieldGeneratorExamples.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendExamples(fieldGeneratorExamples.value[num]);
                  }
                fieldGeneratorExamples.value.Clear();
                fieldGeneratorExamples.have_value = false;
              }
          }
        protected abstract void handle_result(DictionaryDefinitionJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "efinition", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorDefinition;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xamples", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorExamples;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ender", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorGender;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "artOfSpeech", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorPartOfSpeech;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDefinition = new JSONHoldingStringGenerator("field \"Definition\" of the DictionaryDefinition class");
            fieldGeneratorPartOfSpeech = new DictionaryDetailedPartOfSpeechJSON.HoldingGenerator("field \"PartOfSpeech\" of the DictionaryDefinition class", ignore_extras);
            fieldGeneratorGender = new DictionaryDetailedGenderJSON.HoldingGenerator("field \"Gender\" of the DictionaryDefinition class", ignore_extras);
            fieldGeneratorExamples = new JSONHoldingStringArrayGenerator("field \"Examples\" of the DictionaryDefinition class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DictionaryDefinition class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDefinition = new JSONHoldingStringGenerator("field \"Definition\" of the DictionaryDefinition class");
            fieldGeneratorPartOfSpeech = new DictionaryDetailedPartOfSpeechJSON.HoldingGenerator("field \"PartOfSpeech\" of the DictionaryDefinition class", false);
            fieldGeneratorGender = new DictionaryDetailedGenderJSON.HoldingGenerator("field \"Gender\" of the DictionaryDefinition class", false);
            fieldGeneratorExamples = new JSONHoldingStringArrayGenerator("field \"Examples\" of the DictionaryDefinition class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DictionaryDefinition class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDefinition.reset();
            fieldGeneratorPartOfSpeech.reset();
            fieldGeneratorGender.reset();
            fieldGeneratorExamples.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPartOfSpeech.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGender.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPartOfSpeech.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGender.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DictionaryDefinitionJSON  result)
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
        public DictionaryDefinitionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DictionaryDefinitionJSON  result)
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
    protected virtual void handle_result(List<DictionaryDefinitionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DictionaryDefinitionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DictionaryDefinitionJSON>();
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
    public List<DictionaryDefinitionJSON> value;
  };
  };
