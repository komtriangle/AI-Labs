/* file "RadioControlAvailableAudioSourcesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RadioControlAvailableAudioSourcesJSON : JSONBase
  {
    public class TypeValueJSON : JSONBase
      {
        private bool flagHasTag;
        private string storeTag;
        private bool flagHasRecognitionPattern;
        private string storeRecognitionPattern;
        private bool flagHasSpokenOutputForm;
        private string storeSpokenOutputForm;
        private bool flagHasWrittenOutputForm;
        private string storeWrittenOutputForm;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTag(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Tag of TypeValueJSON is not a string.");
            setTag(json_string.getData());
          }


        private void  fromJSONRecognitionPattern(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field RecognitionPattern of TypeValueJSON is not a string.");
            setRecognitionPattern(json_string.getData());
          }


        private void  fromJSONSpokenOutputForm(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SpokenOutputForm of TypeValueJSON is not a string.");
            setSpokenOutputForm(json_string.getData());
          }


        private void  fromJSONWrittenOutputForm(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field WrittenOutputForm of TypeValueJSON is not a string.");
            setWrittenOutputForm(json_string.getData());
          }


        public TypeValueJSON()
          {
            flagHasTag = false;
            flagHasRecognitionPattern = false;
            flagHasSpokenOutputForm = false;
            flagHasWrittenOutputForm = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTag()
          {
            return flagHasTag;
          }

        public string  getTag()
          {
            Debug.Assert(flagHasTag);
            return storeTag;
          }

        public bool  hasRecognitionPattern()
          {
            return flagHasRecognitionPattern;
          }

        public string  getRecognitionPattern()
          {
            Debug.Assert(flagHasRecognitionPattern);
            return storeRecognitionPattern;
          }

        public bool  hasSpokenOutputForm()
          {
            return flagHasSpokenOutputForm;
          }

        public string  getSpokenOutputForm()
          {
            Debug.Assert(flagHasSpokenOutputForm);
            return storeSpokenOutputForm;
          }

        public bool  hasWrittenOutputForm()
          {
            return flagHasWrittenOutputForm;
          }

        public string  getWrittenOutputForm()
          {
            Debug.Assert(flagHasWrittenOutputForm);
            return storeWrittenOutputForm;
          }


        public virtual int extraTypeValueComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeValueComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeValueComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeValueLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTag(string new_value)
          {
            flagHasTag = true;
            storeTag = new_value;
          }
        public void unsetTag()
          {
            flagHasTag = false;
          }
        public void setRecognitionPattern(string new_value)
          {
            flagHasRecognitionPattern = true;
            storeRecognitionPattern = new_value;
          }
        public void unsetRecognitionPattern()
          {
            flagHasRecognitionPattern = false;
          }
        public void setSpokenOutputForm(string new_value)
          {
            flagHasSpokenOutputForm = true;
            storeSpokenOutputForm = new_value;
          }
        public void unsetSpokenOutputForm()
          {
            flagHasSpokenOutputForm = false;
          }
        public void setWrittenOutputForm(string new_value)
          {
            flagHasWrittenOutputForm = true;
            storeWrittenOutputForm = new_value;
          }
        public void unsetWrittenOutputForm()
          {
            flagHasWrittenOutputForm = false;
          }

        public virtual void extraTypeValueAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeValueSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeValueLookup(key);
            if (old_field == null)
              {
                extraTypeValueAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasTag);
            if (flagHasTag)
              {
                handler.start_pair("Tag");
                handler.string_value(storeTag);
              }
            Debug.Assert(partial_allowed || flagHasRecognitionPattern);
            if (flagHasRecognitionPattern)
              {
                handler.start_pair("RecognitionPattern");
                handler.string_value(storeRecognitionPattern);
              }
            Debug.Assert(partial_allowed || flagHasSpokenOutputForm);
            if (flagHasSpokenOutputForm)
              {
                handler.start_pair("SpokenOutputForm");
                handler.string_value(storeSpokenOutputForm);
              }
            Debug.Assert(partial_allowed || flagHasWrittenOutputForm);
            if (flagHasWrittenOutputForm)
              {
                handler.start_pair("WrittenOutputForm");
                handler.string_value(storeWrittenOutputForm);
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
            if (!(hasTag()))
              {
                return "When parsing the object for %what%, the \"Tag\" field was missing.";
              }
            if (!(hasRecognitionPattern()))
              {
                return "When parsing the object for %what%, the \"RecognitionPattern\" field was missing.";
              }
            if (!(hasSpokenOutputForm()))
              {
                return "When parsing the object for %what%, the \"SpokenOutputForm\" field was missing.";
              }
            if (!(hasWrittenOutputForm()))
              {
                return "When parsing the object for %what%, the \"WrittenOutputForm\" field was missing.";
              }
            return null;
          }

        public static TypeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
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
        public static TypeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
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
        public static TypeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValueJSON from_text(string text, bool ignore_extras)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeValueJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeValueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorTag;
            private JSONHoldingStringGenerator fieldGeneratorRecognitionPattern;
            private JSONHoldingStringGenerator fieldGeneratorSpokenOutputForm;
            private JSONHoldingStringGenerator fieldGeneratorWrittenOutputForm;
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
                TypeValueJSON result = new TypeValueJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeValueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeValueJSON result)
              {
                if (fieldGeneratorTag.have_value)
                  {
                    result.setTag(fieldGeneratorTag.value);
                    fieldGeneratorTag.have_value = false;
                  }
                else if ((!(result.hasTag())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Tag\" field was missing.");
                  }
                if (fieldGeneratorRecognitionPattern.have_value)
                  {
                    result.setRecognitionPattern(fieldGeneratorRecognitionPattern.value);
                    fieldGeneratorRecognitionPattern.have_value = false;
                  }
                else if ((!(result.hasRecognitionPattern())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"RecognitionPattern\" field was missing.");
                  }
                if (fieldGeneratorSpokenOutputForm.have_value)
                  {
                    result.setSpokenOutputForm(fieldGeneratorSpokenOutputForm.value);
                    fieldGeneratorSpokenOutputForm.have_value = false;
                  }
                else if ((!(result.hasSpokenOutputForm())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SpokenOutputForm\" field was missing.");
                  }
                if (fieldGeneratorWrittenOutputForm.have_value)
                  {
                    result.setWrittenOutputForm(fieldGeneratorWrittenOutputForm.value);
                    fieldGeneratorWrittenOutputForm.have_value = false;
                  }
                else if ((!(result.hasWrittenOutputForm())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"WrittenOutputForm\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeValueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'R':
                        if ((String.Compare(field_name, 1, "ecognitionPattern", 0, 17, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorRecognitionPattern;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "pokenOutputForm", 0, 15, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorSpokenOutputForm;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ag", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorTag;
                        break;
                    case 'W':
                        if ((String.Compare(field_name, 1, "rittenOutputForm", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorWrittenOutputForm;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTag = new JSONHoldingStringGenerator("field \"Tag\" of the TypeValue class");
                fieldGeneratorRecognitionPattern = new JSONHoldingStringGenerator("field \"RecognitionPattern\" of the TypeValue class");
                fieldGeneratorSpokenOutputForm = new JSONHoldingStringGenerator("field \"SpokenOutputForm\" of the TypeValue class");
                fieldGeneratorWrittenOutputForm = new JSONHoldingStringGenerator("field \"WrittenOutputForm\" of the TypeValue class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTag = new JSONHoldingStringGenerator("field \"Tag\" of the TypeValue class");
                fieldGeneratorRecognitionPattern = new JSONHoldingStringGenerator("field \"RecognitionPattern\" of the TypeValue class");
                fieldGeneratorSpokenOutputForm = new JSONHoldingStringGenerator("field \"SpokenOutputForm\" of the TypeValue class");
                fieldGeneratorWrittenOutputForm = new JSONHoldingStringGenerator("field \"WrittenOutputForm\" of the TypeValue class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTag.reset();
                fieldGeneratorRecognitionPattern.reset();
                fieldGeneratorSpokenOutputForm.reset();
                fieldGeneratorWrittenOutputForm.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeValueJSON  result)
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
            public TypeValueJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeValueJSON  result)
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
        protected virtual void handle_result(List<TypeValueJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeValueJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeValueJSON>();
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
        public List<TypeValueJSON> value;
      };
      };
    private bool flagHasValue;
    private List< TypeValueJSON  > storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Value of RadioControlAvailableAudioSourcesJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeValueJSON  > vector_Value1 = new List< TypeValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeValueJSON convert_classy = TypeValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Value1.Add(convert_classy);
          }
        initValue();
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
            appendValue(vector_Value1[num1]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public RadioControlAvailableAudioSourcesJSON()
      {
        flagHasValue = false;
        storeValue = new List< TypeValueJSON  >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public int  countOfValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue.Count;
      }

    public TypeValueJSON   elementOfValue(int element_num)
      {
        Debug.Assert(flagHasValue);
        return storeValue[element_num];
      }

    public List< TypeValueJSON  >  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void initValue()
      {
        if (flagHasValue)
          {
            for (int num1 = 0; num1 < storeValue.Count; ++num1)
              {
              }
          }
        flagHasValue = true;
        storeValue.Clear();
      }
    public void appendValue(TypeValueJSON  to_append)
      {
        if (!flagHasValue)
          {
            flagHasValue = true;
            storeValue.Clear();
          }
        Debug.Assert(flagHasValue);
        storeValue.Add(to_append);
      }
    public void unsetValue()
      {
        if (flagHasValue)
          {
            for (int num2 = 0; num2 < storeValue.Count; ++num2)
              {
              }
          }
        flagHasValue = false;
        storeValue.Clear();
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num1 = 0; num1 < storeValue.Count; ++num1)
          {
            storeValue[num1].write_as_json(handler);
          }
        handler.finish_array();
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num2 = 0; num2 < storeValue.Count; ++num2)
          {
            storeValue[num2].write_partial_as_json(handler);
          }
        handler.finish_array();
      }

    public static RadioControlAvailableAudioSourcesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioControlAvailableAudioSourcesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioControlAvailableAudioSources", ignore_extras);
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
    public static RadioControlAvailableAudioSourcesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RadioControlAvailableAudioSourcesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioControlAvailableAudioSourcesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioControlAvailableAudioSources", ignore_extras);
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
    public static RadioControlAvailableAudioSourcesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RadioControlAvailableAudioSourcesJSON from_text(string text, bool ignore_extras)
      {
        RadioControlAvailableAudioSourcesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioControlAvailableAudioSources", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RadioControlAvailableAudioSourcesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RadioControlAvailableAudioSourcesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RadioControlAvailableAudioSourcesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioControlAvailableAudioSources", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : TypeValueJSON.HoldingArrayGenerator
      {
        protected void finish()
          {
            Debug.Assert(have_value);
            RadioControlAvailableAudioSourcesJSON result = new RadioControlAvailableAudioSourcesJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(RadioControlAvailableAudioSourcesJSON new_result);
        public Generator(bool ignore_extras) : base("Type RadioControlAvailableAudioSources", ignore_extras)
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
        protected override void handle_result(RadioControlAvailableAudioSourcesJSON  result)
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
        public RadioControlAvailableAudioSourcesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RadioControlAvailableAudioSourcesJSON  result)
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
    protected virtual void handle_result(List<RadioControlAvailableAudioSourcesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RadioControlAvailableAudioSourcesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RadioControlAvailableAudioSourcesJSON>();
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
    public List<RadioControlAvailableAudioSourcesJSON> value;
  };
  };
