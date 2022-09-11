/* file "DictionaryCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DictionaryCommandJSON : CommandResultJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        public class TypeRequestKindListJSON : JSONBase
          {
            private bool flagHasRequestKind;
            private DictionaryRequestKindJSON  storeRequestKind;


            private void  fromJSONRequestKind(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                DictionaryRequestKindJSON convert_classy = DictionaryRequestKindJSON.from_json(json_value, ignore_extras, true);
                setRequestKind(convert_classy);
              }


            public TypeRequestKindListJSON()
              {
                flagHasRequestKind = false;
              }

            public bool  hasRequestKind()
              {
                return flagHasRequestKind;
              }

            public DictionaryRequestKindJSON   getRequestKind()
              {
                Debug.Assert(flagHasRequestKind);
                return storeRequestKind;
              }

            public DictionaryRequestKindJSON.TypeValue  getRequestKindValue()
              {
                return getRequestKind().getValue();
              }

            public string  getRequestKindAsString()
              {
                return getRequestKind().getValueAsString();
              }



            public void setRequestKind(DictionaryRequestKindJSON  new_value)
              {
                if (flagHasRequestKind)
                  {
                  }
                flagHasRequestKind = true;
                storeRequestKind = new_value;
              }
            public void setRequestKind(DictionaryRequestKindJSON.TypeValue new_value)
              {
                setRequestKind(new DictionaryRequestKindJSON(new_value));
              }
            public void setRequestKind(string chars)
              {
                DictionaryRequestKindJSON.TypeValueKnownValues known = DictionaryRequestKindJSON.stringToValue(chars);
                DictionaryRequestKindJSON.TypeValue new_value = new DictionaryRequestKindJSON.TypeValue();
                if (known == DictionaryRequestKindJSON.TypeValueKnownValues.Value__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = chars;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                setRequestKind(new_value);
              }
            public void unsetRequestKind()
              {
                if (flagHasRequestKind)
                  {
                  }
                flagHasRequestKind = false;
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
                Debug.Assert(partial_allowed || flagHasRequestKind);
                if (flagHasRequestKind)
                  {
                    handler.start_pair("RequestKind");
                    if (partial_allowed)
                        storeRequestKind.write_partial_as_json(handler);
                    else
                        storeRequestKind.write_as_json(handler);
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
                if (!(hasRequestKind()))
                  {
                    return "When parsing the object for %what%, the \"RequestKind\" field was missing.";
                  }
                return null;
              }

            public static TypeRequestKindListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeRequestKindListJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeRequestKindList", ignore_extras);
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
            public static TypeRequestKindListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeRequestKindListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeRequestKindListJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeRequestKindList", ignore_extras);
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
            public static TypeRequestKindListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeRequestKindListJSON from_text(string text, bool ignore_extras)
              {
                TypeRequestKindListJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeRequestKindList", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeRequestKindListJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeRequestKindListJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeRequestKindListJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeRequestKindList", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private DictionaryRequestKindJSON.HoldingGenerator fieldGeneratorRequestKind;

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
                    TypeRequestKindListJSON result = new TypeRequestKindListJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    handle_result(result);
                  }
                protected void finish(TypeRequestKindListJSON result)
                  {
                    if (fieldGeneratorRequestKind.have_value)
                      {
                        result.setRequestKind(fieldGeneratorRequestKind.value);
                        fieldGeneratorRequestKind.have_value = false;
                      }
                    else if ((!(result.hasRequestKind())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"RequestKind\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeRequestKindListJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "RequestKind", 0, 11, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorRequestKind;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorRequestKind = new DictionaryRequestKindJSON.HoldingGenerator("field \"RequestKind\" of the TypeRequestKindList class", ignore_extras);
                    set_what("the TypeRequestKindList class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorRequestKind = new DictionaryRequestKindJSON.HoldingGenerator("field \"RequestKind\" of the TypeRequestKindList class", false);
                    set_what("the TypeRequestKindList class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorRequestKind.reset();
                    base.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorRequestKind.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorRequestKind.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeRequestKindListJSON  result)
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
                public TypeRequestKindListJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeRequestKindListJSON  result)
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
            protected virtual void handle_result(List<TypeRequestKindListJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeRequestKindListJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeRequestKindListJSON>();
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
            public List<TypeRequestKindListJSON> value;
          };
          };
        public class TypePOSListJSON : JSONBase
          {
            private bool flagHasPOS;
            private LegacyDictionaryPartOfSpeechJSON  storePOS;


            private void  fromJSONPOS(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                LegacyDictionaryPartOfSpeechJSON convert_classy = LegacyDictionaryPartOfSpeechJSON.from_json(json_value, ignore_extras, true);
                setPOS(convert_classy);
              }


            public TypePOSListJSON()
              {
                flagHasPOS = false;
              }

            public bool  hasPOS()
              {
                return flagHasPOS;
              }

            public LegacyDictionaryPartOfSpeechJSON   getPOS()
              {
                Debug.Assert(flagHasPOS);
                return storePOS;
              }

            public LegacyDictionaryPartOfSpeechJSON.TypeValue  getPOSValue()
              {
                return getPOS().getValue();
              }

            public string  getPOSAsString()
              {
                return getPOS().getValueAsString();
              }



            public void setPOS(LegacyDictionaryPartOfSpeechJSON  new_value)
              {
                if (flagHasPOS)
                  {
                  }
                flagHasPOS = true;
                storePOS = new_value;
              }
            public void setPOS(LegacyDictionaryPartOfSpeechJSON.TypeValue new_value)
              {
                setPOS(new LegacyDictionaryPartOfSpeechJSON(new_value));
              }
            public void setPOS(string chars)
              {
                LegacyDictionaryPartOfSpeechJSON.TypeValueKnownValues known = LegacyDictionaryPartOfSpeechJSON.stringToValue(chars);
                LegacyDictionaryPartOfSpeechJSON.TypeValue new_value = new LegacyDictionaryPartOfSpeechJSON.TypeValue();
                if (known == LegacyDictionaryPartOfSpeechJSON.TypeValueKnownValues.Value__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = chars;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                setPOS(new_value);
              }
            public void unsetPOS()
              {
                if (flagHasPOS)
                  {
                  }
                flagHasPOS = false;
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
                Debug.Assert(partial_allowed || flagHasPOS);
                if (flagHasPOS)
                  {
                    handler.start_pair("POS");
                    if (partial_allowed)
                        storePOS.write_partial_as_json(handler);
                    else
                        storePOS.write_as_json(handler);
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
                if (!(hasPOS()))
                  {
                    return "When parsing the object for %what%, the \"POS\" field was missing.";
                  }
                return null;
              }

            public static TypePOSListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypePOSListJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePOSList", ignore_extras);
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
            public static TypePOSListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypePOSListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypePOSListJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePOSList", ignore_extras);
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
            public static TypePOSListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypePOSListJSON from_text(string text, bool ignore_extras)
              {
                TypePOSListJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePOSList", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypePOSListJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypePOSListJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypePOSListJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePOSList", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private LegacyDictionaryPartOfSpeechJSON.HoldingGenerator fieldGeneratorPOS;

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
                    TypePOSListJSON result = new TypePOSListJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    handle_result(result);
                  }
                protected void finish(TypePOSListJSON result)
                  {
                    if (fieldGeneratorPOS.have_value)
                      {
                        result.setPOS(fieldGeneratorPOS.value);
                        fieldGeneratorPOS.have_value = false;
                      }
                    else if ((!(result.hasPOS())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"POS\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypePOSListJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "POS", 0, 3, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorPOS;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorPOS = new LegacyDictionaryPartOfSpeechJSON.HoldingGenerator("field \"POS\" of the TypePOSList class", ignore_extras);
                    set_what("the TypePOSList class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorPOS = new LegacyDictionaryPartOfSpeechJSON.HoldingGenerator("field \"POS\" of the TypePOSList class", false);
                    set_what("the TypePOSList class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorPOS.reset();
                    base.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorPOS.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorPOS.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypePOSListJSON  result)
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
                public TypePOSListJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypePOSListJSON  result)
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
            protected virtual void handle_result(List<TypePOSListJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypePOSListJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypePOSListJSON>();
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
            public List<TypePOSListJSON> value;
          };
          };
        public class TypeDictionaryInfoJSON : JSONBase
          {
            private bool flagHasWord;
            private string storeWord;
            private bool flagHasDefinitions;
            private string storeDefinitions;
            private bool flagHasSynonyms;
            private string storeSynonyms;
            private bool flagHasAntonyms;
            private string storeAntonyms;
            private bool flagHasURI;
            private string storeURI;


            private void  fromJSONWord(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Word of TypeDictionaryInfoJSON is not a string.");
                setWord(json_string.getData());
              }


            private void  fromJSONDefinitions(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Definitions of TypeDictionaryInfoJSON is not a string.");
                setDefinitions(json_string.getData());
              }


            private void  fromJSONSynonyms(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Synonyms of TypeDictionaryInfoJSON is not a string.");
                setSynonyms(json_string.getData());
              }


            private void  fromJSONAntonyms(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Antonyms of TypeDictionaryInfoJSON is not a string.");
                setAntonyms(json_string.getData());
              }


            private void  fromJSONURI(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field URI of TypeDictionaryInfoJSON is not a string.");
                setURI(json_string.getData());
              }


            public TypeDictionaryInfoJSON()
              {
                flagHasWord = false;
                flagHasDefinitions = false;
                flagHasSynonyms = false;
                flagHasAntonyms = false;
                flagHasURI = false;
              }

            public bool  hasWord()
              {
                return flagHasWord;
              }

            public string  getWord()
              {
                Debug.Assert(flagHasWord);
                return storeWord;
              }

            public bool  hasDefinitions()
              {
                return flagHasDefinitions;
              }

            public string  getDefinitions()
              {
                Debug.Assert(flagHasDefinitions);
                return storeDefinitions;
              }

            public bool  hasSynonyms()
              {
                return flagHasSynonyms;
              }

            public string  getSynonyms()
              {
                Debug.Assert(flagHasSynonyms);
                return storeSynonyms;
              }

            public bool  hasAntonyms()
              {
                return flagHasAntonyms;
              }

            public string  getAntonyms()
              {
                Debug.Assert(flagHasAntonyms);
                return storeAntonyms;
              }

            public bool  hasURI()
              {
                return flagHasURI;
              }

            public string  getURI()
              {
                Debug.Assert(flagHasURI);
                return storeURI;
              }



            public void setWord(string new_value)
              {
                flagHasWord = true;
                storeWord = new_value;
              }
            public void unsetWord()
              {
                flagHasWord = false;
              }
            public void setDefinitions(string new_value)
              {
                flagHasDefinitions = true;
                storeDefinitions = new_value;
              }
            public void unsetDefinitions()
              {
                flagHasDefinitions = false;
              }
            public void setSynonyms(string new_value)
              {
                flagHasSynonyms = true;
                storeSynonyms = new_value;
              }
            public void unsetSynonyms()
              {
                flagHasSynonyms = false;
              }
            public void setAntonyms(string new_value)
              {
                flagHasAntonyms = true;
                storeAntonyms = new_value;
              }
            public void unsetAntonyms()
              {
                flagHasAntonyms = false;
              }
            public void setURI(string new_value)
              {
                flagHasURI = true;
                storeURI = new_value;
              }
            public void unsetURI()
              {
                flagHasURI = false;
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
                Debug.Assert(partial_allowed || flagHasWord);
                if (flagHasWord)
                  {
                    handler.start_pair("Word");
                    handler.string_value(storeWord);
                  }
                Debug.Assert(partial_allowed || flagHasDefinitions);
                if (flagHasDefinitions)
                  {
                    handler.start_pair("Definitions");
                    handler.string_value(storeDefinitions);
                  }
                if (flagHasSynonyms)
                  {
                    handler.start_pair("Synonyms");
                    handler.string_value(storeSynonyms);
                  }
                if (flagHasAntonyms)
                  {
                    handler.start_pair("Antonyms");
                    handler.string_value(storeAntonyms);
                  }
                if (flagHasURI)
                  {
                    handler.start_pair("URI");
                    handler.string_value(storeURI);
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
                if (!(hasWord()))
                  {
                    return "When parsing the object for %what%, the \"Word\" field was missing.";
                  }
                if (!(hasDefinitions()))
                  {
                    return "When parsing the object for %what%, the \"Definitions\" field was missing.";
                  }
                return null;
              }

            public static TypeDictionaryInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeDictionaryInfoJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeDictionaryInfo", ignore_extras);
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
            public static TypeDictionaryInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeDictionaryInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeDictionaryInfoJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeDictionaryInfo", ignore_extras);
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
            public static TypeDictionaryInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeDictionaryInfoJSON from_text(string text, bool ignore_extras)
              {
                TypeDictionaryInfoJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeDictionaryInfo", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeDictionaryInfoJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeDictionaryInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeDictionaryInfoJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeDictionaryInfo", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorWord;
                private JSONHoldingStringGenerator fieldGeneratorDefinitions;
                private JSONHoldingStringGenerator fieldGeneratorSynonyms;
                private JSONHoldingStringGenerator fieldGeneratorAntonyms;
                private JSONHoldingStringGenerator fieldGeneratorURI;

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
                    TypeDictionaryInfoJSON result = new TypeDictionaryInfoJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    handle_result(result);
                  }
                protected void finish(TypeDictionaryInfoJSON result)
                  {
                    if (fieldGeneratorWord.have_value)
                      {
                        result.setWord(fieldGeneratorWord.value);
                        fieldGeneratorWord.have_value = false;
                      }
                    else if ((!(result.hasWord())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Word\" field was missing.");
                      }
                    if (fieldGeneratorDefinitions.have_value)
                      {
                        result.setDefinitions(fieldGeneratorDefinitions.value);
                        fieldGeneratorDefinitions.have_value = false;
                      }
                    else if ((!(result.hasDefinitions())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Definitions\" field was missing.");
                      }
                    if (fieldGeneratorSynonyms.have_value)
                      {
                        result.setSynonyms(fieldGeneratorSynonyms.value);
                        fieldGeneratorSynonyms.have_value = false;
                      }
                    if (fieldGeneratorAntonyms.have_value)
                      {
                        result.setAntonyms(fieldGeneratorAntonyms.value);
                        fieldGeneratorAntonyms.have_value = false;
                      }
                    if (fieldGeneratorURI.have_value)
                      {
                        result.setURI(fieldGeneratorURI.value);
                        fieldGeneratorURI.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeDictionaryInfoJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 1, "ntonyms", 0, 7, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorAntonyms;
                            break;
                        case 'D':
                            if ((String.Compare(field_name, 1, "efinitions", 0, 10, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDefinitions;
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 1, "ynonyms", 0, 7, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorSynonyms;
                            break;
                        case 'U':
                            if ((String.Compare(field_name, 1, "RI", 0, 2, false) == 0) && (field_name.Length == 3))
                                return fieldGeneratorURI;
                            break;
                        case 'W':
                            if ((String.Compare(field_name, 1, "ord", 0, 3, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorWord;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorWord = new JSONHoldingStringGenerator("field \"Word\" of the TypeDictionaryInfo class");
                    fieldGeneratorDefinitions = new JSONHoldingStringGenerator("field \"Definitions\" of the TypeDictionaryInfo class");
                    fieldGeneratorSynonyms = new JSONHoldingStringGenerator("field \"Synonyms\" of the TypeDictionaryInfo class");
                    fieldGeneratorAntonyms = new JSONHoldingStringGenerator("field \"Antonyms\" of the TypeDictionaryInfo class");
                    fieldGeneratorURI = new JSONHoldingStringGenerator("field \"URI\" of the TypeDictionaryInfo class");
                    set_what("the TypeDictionaryInfo class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorWord = new JSONHoldingStringGenerator("field \"Word\" of the TypeDictionaryInfo class");
                    fieldGeneratorDefinitions = new JSONHoldingStringGenerator("field \"Definitions\" of the TypeDictionaryInfo class");
                    fieldGeneratorSynonyms = new JSONHoldingStringGenerator("field \"Synonyms\" of the TypeDictionaryInfo class");
                    fieldGeneratorAntonyms = new JSONHoldingStringGenerator("field \"Antonyms\" of the TypeDictionaryInfo class");
                    fieldGeneratorURI = new JSONHoldingStringGenerator("field \"URI\" of the TypeDictionaryInfo class");
                    set_what("the TypeDictionaryInfo class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorWord.reset();
                    fieldGeneratorDefinitions.reset();
                    fieldGeneratorSynonyms.reset();
                    fieldGeneratorAntonyms.reset();
                    fieldGeneratorURI.reset();
                    base.reset();
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
                protected override void handle_result(TypeDictionaryInfoJSON  result)
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
                public TypeDictionaryInfoJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeDictionaryInfoJSON  result)
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
            protected virtual void handle_result(List<TypeDictionaryInfoJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeDictionaryInfoJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeDictionaryInfoJSON>();
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
            public List<TypeDictionaryInfoJSON> value;
          };
          };
        private bool flagHasRequestKindList;
        private List< TypeRequestKindListJSON  > storeRequestKindList;
        private bool flagHasPOSList;
        private List< TypePOSListJSON  > storePOSList;
        private bool flagHasWasSpelled;
        private bool storeWasSpelled;
        private bool flagHasSpellingAttempt;
        private string storeSpellingAttempt;
        private bool flagHasDictionaryInfo;
        private List< TypeDictionaryInfoJSON  > storeDictionaryInfo;
        private bool flagHasWebCommandEnabled;
        private bool storeWebCommandEnabled;


        private void  fromJSONRequestKindList(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field RequestKindList of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field RequestKindList of TypeNativeDataJSON has too few elements.");
            List< TypeRequestKindListJSON  > vector_RequestKindList1 = new List< TypeRequestKindListJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeRequestKindListJSON convert_classy = TypeRequestKindListJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_RequestKindList1.Add(convert_classy);
              }
            Debug.Assert(vector_RequestKindList1.Count >= 1);
            initRequestKindList();
            for (int num1 = 0; num1 < vector_RequestKindList1.Count; ++num1)
                appendRequestKindList(vector_RequestKindList1[num1]);
            for (int num1 = 0; num1 < vector_RequestKindList1.Count; ++num1)
              {
              }
          }


        private void  fromJSONPOSList(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field POSList of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field POSList of TypeNativeDataJSON has too few elements.");
            List< TypePOSListJSON  > vector_POSList1 = new List< TypePOSListJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypePOSListJSON convert_classy = TypePOSListJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_POSList1.Add(convert_classy);
              }
            Debug.Assert(vector_POSList1.Count >= 1);
            initPOSList();
            for (int num2 = 0; num2 < vector_POSList1.Count; ++num2)
                appendPOSList(vector_POSList1[num2]);
            for (int num1 = 0; num1 < vector_POSList1.Count; ++num1)
              {
              }
          }


        private void  fromJSONWasSpelled(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field WasSpelled of TypeNativeDataJSON is not true for false.");
                  }
              }
            setWasSpelled(the_bool);
          }


        private void  fromJSONSpellingAttempt(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SpellingAttempt of TypeNativeDataJSON is not a string.");
            setSpellingAttempt(json_string.getData());
          }


        private void  fromJSONDictionaryInfo(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field DictionaryInfo of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field DictionaryInfo of TypeNativeDataJSON has too few elements.");
            List< TypeDictionaryInfoJSON  > vector_DictionaryInfo1 = new List< TypeDictionaryInfoJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeDictionaryInfoJSON convert_classy = TypeDictionaryInfoJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_DictionaryInfo1.Add(convert_classy);
              }
            Debug.Assert(vector_DictionaryInfo1.Count >= 1);
            initDictionaryInfo();
            for (int num3 = 0; num3 < vector_DictionaryInfo1.Count; ++num3)
                appendDictionaryInfo(vector_DictionaryInfo1[num3]);
            for (int num1 = 0; num1 < vector_DictionaryInfo1.Count; ++num1)
              {
              }
          }


        private void  fromJSONWebCommandEnabled(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONTrueValue json_true = json_value.true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_value.false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for field WebCommandEnabled of TypeNativeDataJSON is not true for false.");
                  }
              }
            setWebCommandEnabled(the_bool);
          }


        public TypeNativeDataJSON()
          {
            flagHasRequestKindList = false;
            flagHasPOSList = false;
            flagHasWasSpelled = false;
            flagHasSpellingAttempt = false;
            flagHasDictionaryInfo = false;
            flagHasWebCommandEnabled = false;
            storeRequestKindList = new List< TypeRequestKindListJSON  >();
            storePOSList = new List< TypePOSListJSON  >();
            storeDictionaryInfo = new List< TypeDictionaryInfoJSON  >();
          }

        public bool  hasRequestKindList()
          {
            return flagHasRequestKindList;
          }

        public int  countOfRequestKindList()
          {
            Debug.Assert(flagHasRequestKindList);
            return storeRequestKindList.Count;
          }

        public TypeRequestKindListJSON   elementOfRequestKindList(int element_num)
          {
            Debug.Assert(flagHasRequestKindList);
            return storeRequestKindList[element_num];
          }

        public List< TypeRequestKindListJSON  >  getRequestKindList()
          {
            Debug.Assert(flagHasRequestKindList);
            return storeRequestKindList;
          }

        public bool  hasPOSList()
          {
            return flagHasPOSList;
          }

        public int  countOfPOSList()
          {
            Debug.Assert(flagHasPOSList);
            return storePOSList.Count;
          }

        public TypePOSListJSON   elementOfPOSList(int element_num)
          {
            Debug.Assert(flagHasPOSList);
            return storePOSList[element_num];
          }

        public List< TypePOSListJSON  >  getPOSList()
          {
            Debug.Assert(flagHasPOSList);
            return storePOSList;
          }

        public bool  hasWasSpelled()
          {
            return flagHasWasSpelled;
          }

        public bool  getWasSpelled()
          {
            Debug.Assert(flagHasWasSpelled);
            return storeWasSpelled;
          }

        public bool  hasSpellingAttempt()
          {
            return flagHasSpellingAttempt;
          }

        public string  getSpellingAttempt()
          {
            Debug.Assert(flagHasSpellingAttempt);
            return storeSpellingAttempt;
          }

        public bool  hasDictionaryInfo()
          {
            return flagHasDictionaryInfo;
          }

        public int  countOfDictionaryInfo()
          {
            Debug.Assert(flagHasDictionaryInfo);
            return storeDictionaryInfo.Count;
          }

        public TypeDictionaryInfoJSON   elementOfDictionaryInfo(int element_num)
          {
            Debug.Assert(flagHasDictionaryInfo);
            return storeDictionaryInfo[element_num];
          }

        public List< TypeDictionaryInfoJSON  >  getDictionaryInfo()
          {
            Debug.Assert(flagHasDictionaryInfo);
            return storeDictionaryInfo;
          }

        public bool  hasWebCommandEnabled()
          {
            return flagHasWebCommandEnabled;
          }

        public bool  getWebCommandEnabled()
          {
            Debug.Assert(flagHasWebCommandEnabled);
            return storeWebCommandEnabled;
          }



        public void initRequestKindList()
          {
            if (flagHasRequestKindList)
              {
                for (int num1 = 0; num1 < storeRequestKindList.Count; ++num1)
                  {
                  }
              }
            flagHasRequestKindList = true;
            storeRequestKindList.Clear();
          }
        public void appendRequestKindList(TypeRequestKindListJSON  to_append)
          {
            if (!flagHasRequestKindList)
              {
                flagHasRequestKindList = true;
                storeRequestKindList.Clear();
              }
            Debug.Assert(flagHasRequestKindList);
            storeRequestKindList.Add(to_append);
          }
        public void unsetRequestKindList()
          {
            if (flagHasRequestKindList)
              {
                for (int num2 = 0; num2 < storeRequestKindList.Count; ++num2)
                  {
                  }
              }
            flagHasRequestKindList = false;
            storeRequestKindList.Clear();
          }
        public void initPOSList()
          {
            if (flagHasPOSList)
              {
                for (int num3 = 0; num3 < storePOSList.Count; ++num3)
                  {
                  }
              }
            flagHasPOSList = true;
            storePOSList.Clear();
          }
        public void appendPOSList(TypePOSListJSON  to_append)
          {
            if (!flagHasPOSList)
              {
                flagHasPOSList = true;
                storePOSList.Clear();
              }
            Debug.Assert(flagHasPOSList);
            storePOSList.Add(to_append);
          }
        public void unsetPOSList()
          {
            if (flagHasPOSList)
              {
                for (int num4 = 0; num4 < storePOSList.Count; ++num4)
                  {
                  }
              }
            flagHasPOSList = false;
            storePOSList.Clear();
          }
        public void setWasSpelled(bool new_value)
          {
            flagHasWasSpelled = true;
            storeWasSpelled = new_value;
          }
        public void unsetWasSpelled()
          {
            flagHasWasSpelled = false;
          }
        public void setSpellingAttempt(string new_value)
          {
            flagHasSpellingAttempt = true;
            storeSpellingAttempt = new_value;
          }
        public void unsetSpellingAttempt()
          {
            flagHasSpellingAttempt = false;
          }
        public void initDictionaryInfo()
          {
            if (flagHasDictionaryInfo)
              {
                for (int num5 = 0; num5 < storeDictionaryInfo.Count; ++num5)
                  {
                  }
              }
            flagHasDictionaryInfo = true;
            storeDictionaryInfo.Clear();
          }
        public void appendDictionaryInfo(TypeDictionaryInfoJSON  to_append)
          {
            if (!flagHasDictionaryInfo)
              {
                flagHasDictionaryInfo = true;
                storeDictionaryInfo.Clear();
              }
            Debug.Assert(flagHasDictionaryInfo);
            storeDictionaryInfo.Add(to_append);
          }
        public void unsetDictionaryInfo()
          {
            if (flagHasDictionaryInfo)
              {
                for (int num6 = 0; num6 < storeDictionaryInfo.Count; ++num6)
                  {
                  }
              }
            flagHasDictionaryInfo = false;
            storeDictionaryInfo.Clear();
          }
        public void setWebCommandEnabled(bool new_value)
          {
            flagHasWebCommandEnabled = true;
            storeWebCommandEnabled = new_value;
          }
        public void unsetWebCommandEnabled()
          {
            flagHasWebCommandEnabled = false;
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
            Debug.Assert(partial_allowed || flagHasRequestKindList);
            if (flagHasRequestKindList)
              {
                handler.start_pair("RequestKindList");
                Debug.Assert(storeRequestKindList.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeRequestKindList.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeRequestKindList[num1].write_partial_as_json(handler);
                    else
                        storeRequestKindList[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            Debug.Assert(partial_allowed || flagHasPOSList);
            if (flagHasPOSList)
              {
                handler.start_pair("POSList");
                Debug.Assert(storePOSList.Count >= 1);
                handler.start_array();
                for (int num2 = 0; num2 < storePOSList.Count; ++num2)
                  {
                    if (partial_allowed)
                        storePOSList[num2].write_partial_as_json(handler);
                    else
                        storePOSList[num2].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasWasSpelled)
              {
                handler.start_pair("WasSpelled");
                handler.boolean_value(storeWasSpelled);
              }
            if (flagHasSpellingAttempt)
              {
                handler.start_pair("SpellingAttempt");
                handler.string_value(storeSpellingAttempt);
              }
            Debug.Assert(partial_allowed || flagHasDictionaryInfo);
            if (flagHasDictionaryInfo)
              {
                handler.start_pair("DictionaryInfo");
                Debug.Assert(storeDictionaryInfo.Count >= 1);
                handler.start_array();
                for (int num3 = 0; num3 < storeDictionaryInfo.Count; ++num3)
                  {
                    if (partial_allowed)
                        storeDictionaryInfo[num3].write_partial_as_json(handler);
                    else
                        storeDictionaryInfo[num3].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasWebCommandEnabled)
              {
                handler.start_pair("WebCommandEnabled");
                handler.boolean_value(storeWebCommandEnabled);
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
            if (!(hasRequestKindList()))
              {
                return "When parsing the object for %what%, the \"RequestKindList\" field was missing.";
              }
            if (!(hasPOSList()))
              {
                return "When parsing the object for %what%, the \"POSList\" field was missing.";
              }
            if (!(hasDictionaryInfo()))
              {
                return "When parsing the object for %what%, the \"DictionaryInfo\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private TypeRequestKindListJSON.HoldingArrayGenerator fieldGeneratorRequestKindList;
            private TypePOSListJSON.HoldingArrayGenerator fieldGeneratorPOSList;
            private JSONHoldingBooleanGenerator fieldGeneratorWasSpelled;
            private JSONHoldingStringGenerator fieldGeneratorSpellingAttempt;
            private TypeDictionaryInfoJSON.HoldingArrayGenerator fieldGeneratorDictionaryInfo;
            private JSONHoldingBooleanGenerator fieldGeneratorWebCommandEnabled;

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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorRequestKindList.have_value)
                  {
                    result.initRequestKindList();
                    int count = fieldGeneratorRequestKindList.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendRequestKindList(fieldGeneratorRequestKindList.value[num]);
                      }
                    fieldGeneratorRequestKindList.value.Clear();
                    fieldGeneratorRequestKindList.have_value = false;
                  }
                else if ((!(result.hasRequestKindList())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"RequestKindList\" field was missing.");
                  }
                if (fieldGeneratorPOSList.have_value)
                  {
                    result.initPOSList();
                    int count = fieldGeneratorPOSList.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendPOSList(fieldGeneratorPOSList.value[num]);
                      }
                    fieldGeneratorPOSList.value.Clear();
                    fieldGeneratorPOSList.have_value = false;
                  }
                else if ((!(result.hasPOSList())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"POSList\" field was missing.");
                  }
                if (fieldGeneratorWasSpelled.have_value)
                  {
                    result.setWasSpelled(fieldGeneratorWasSpelled.value);
                    fieldGeneratorWasSpelled.have_value = false;
                  }
                if (fieldGeneratorSpellingAttempt.have_value)
                  {
                    result.setSpellingAttempt(fieldGeneratorSpellingAttempt.value);
                    fieldGeneratorSpellingAttempt.have_value = false;
                  }
                if (fieldGeneratorDictionaryInfo.have_value)
                  {
                    result.initDictionaryInfo();
                    int count = fieldGeneratorDictionaryInfo.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendDictionaryInfo(fieldGeneratorDictionaryInfo.value[num]);
                      }
                    fieldGeneratorDictionaryInfo.value.Clear();
                    fieldGeneratorDictionaryInfo.have_value = false;
                  }
                else if ((!(result.hasDictionaryInfo())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"DictionaryInfo\" field was missing.");
                  }
                if (fieldGeneratorWebCommandEnabled.have_value)
                  {
                    result.setWebCommandEnabled(fieldGeneratorWebCommandEnabled.value);
                    fieldGeneratorWebCommandEnabled.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "ictionaryInfo", 0, 13, false) == 0) && (field_name.Length == 14))
                            return fieldGeneratorDictionaryInfo;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "OSList", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorPOSList;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "equestKindList", 0, 14, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorRequestKindList;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "pellingAttempt", 0, 14, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorSpellingAttempt;
                        break;
                    case 'W':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "sSpelled", 0, 8, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorWasSpelled;
                                break;
                            case 'e':
                                if ((String.Compare(field_name, 2, "bCommandEnabled", 0, 15, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorWebCommandEnabled;
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
                fieldGeneratorRequestKindList = new TypeRequestKindListJSON.HoldingArrayGenerator("field \"RequestKindList\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorPOSList = new TypePOSListJSON.HoldingArrayGenerator("field \"POSList\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorWasSpelled = new JSONHoldingBooleanGenerator("field \"WasSpelled\" of the TypeNativeData class");
                fieldGeneratorSpellingAttempt = new JSONHoldingStringGenerator("field \"SpellingAttempt\" of the TypeNativeData class");
                fieldGeneratorDictionaryInfo = new TypeDictionaryInfoJSON.HoldingArrayGenerator("field \"DictionaryInfo\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorWebCommandEnabled = new JSONHoldingBooleanGenerator("field \"WebCommandEnabled\" of the TypeNativeData class");
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorRequestKindList = new TypeRequestKindListJSON.HoldingArrayGenerator("field \"RequestKindList\" of the TypeNativeData class", false);
                fieldGeneratorPOSList = new TypePOSListJSON.HoldingArrayGenerator("field \"POSList\" of the TypeNativeData class", false);
                fieldGeneratorWasSpelled = new JSONHoldingBooleanGenerator("field \"WasSpelled\" of the TypeNativeData class");
                fieldGeneratorSpellingAttempt = new JSONHoldingStringGenerator("field \"SpellingAttempt\" of the TypeNativeData class");
                fieldGeneratorDictionaryInfo = new TypeDictionaryInfoJSON.HoldingArrayGenerator("field \"DictionaryInfo\" of the TypeNativeData class", false);
                fieldGeneratorWebCommandEnabled = new JSONHoldingBooleanGenerator("field \"WebCommandEnabled\" of the TypeNativeData class");
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorRequestKindList.reset();
                fieldGeneratorPOSList.reset();
                fieldGeneratorWasSpelled.reset();
                fieldGeneratorSpellingAttempt.reset();
                fieldGeneratorDictionaryInfo.reset();
                fieldGeneratorWebCommandEnabled.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorRequestKindList.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorPOSList.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorDictionaryInfo.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorRequestKindList.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorPOSList.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorDictionaryInfo.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasNativeData;
    private List< TypeNativeDataJSON  > storeNativeData;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONArrayValue generated_array_1_NativeData = new JSONArrayValue();
        for (int num1 = 0; num1 < storeNativeData.Count; ++num1)
          {
            JSONValueHandler handler_NativeData = new JSONValueHandler();
            storeNativeData[num1].write_as_json(handler_NativeData);
            generated_array_1_NativeData.appendComponent(handler_NativeData.result);
          }
        return generated_array_1_NativeData;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NativeData of DictionaryCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field NativeData of DictionaryCommandJSON has too few elements.");
        List< TypeNativeDataJSON  > vector_NativeData1 = new List< TypeNativeDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NativeData1.Add(convert_classy);
          }
        Debug.Assert(vector_NativeData1.Count >= 1);
        initNativeData();
        for (int num4 = 0; num4 < vector_NativeData1.Count; ++num4)
            appendNativeData(vector_NativeData1[num4]);
        for (int num1 = 0; num1 < vector_NativeData1.Count; ++num1)
          {
          }
      }


    public DictionaryCommandJSON()
      {
        flagHasNativeData = false;
        storeNativeData = new List< TypeNativeDataJSON  >();
      }

    public override string  getCommandKind()
      {
        return "DictionaryCommand";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public int  countOfNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData.Count;
      }

    public TypeNativeDataJSON   elementOfNativeData(int element_num)
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData[element_num];
      }

    public List< TypeNativeDataJSON  >  getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return null;
      }

    public void initNativeData()
      {
        if (flagHasNativeData)
          {
            for (int num7 = 0; num7 < storeNativeData.Count; ++num7)
              {
              }
          }
        flagHasNativeData = true;
        storeNativeData.Clear();
      }
    public void appendNativeData(TypeNativeDataJSON  to_append)
      {
        if (!flagHasNativeData)
          {
            flagHasNativeData = true;
            storeNativeData.Clear();
          }
        Debug.Assert(flagHasNativeData);
        storeNativeData.Add(to_append);
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
            for (int num8 = 0; num8 < storeNativeData.Count; ++num8)
              {
              }
          }
        flagHasNativeData = false;
        storeNativeData.Clear();
      }

    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            Debug.Assert(storeNativeData.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeNativeData.Count; ++num1)
              {
                if (partial_allowed)
                    storeNativeData[num1].write_partial_as_json(handler);
                else
                    storeNativeData[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new DictionaryCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DictionaryCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryCommand", ignore_extras);
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
    public static new DictionaryCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DictionaryCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DictionaryCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryCommand", ignore_extras);
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
    public static new DictionaryCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DictionaryCommandJSON from_text(string text, bool ignore_extras)
      {
        DictionaryCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DictionaryCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DictionaryCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DictionaryCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private TypeNativeDataJSON.HoldingArrayGenerator fieldGeneratorNativeData;

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
            if (!(getCommandResultJSONKey().Equals("DictionaryCommand")))
                throw new Exception("The key field has a value other than `DictionaryCommand'.");
            DictionaryCommandJSON result = new DictionaryCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((DictionaryCommandJSON )new_result);
          }
        protected void finish(DictionaryCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.initNativeData();
                int count = fieldGeneratorNativeData.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNativeData(fieldGeneratorNativeData.value[num]);
                  }
                fieldGeneratorNativeData.value.Clear();
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(DictionaryCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingArrayGenerator("field \"NativeData\" of the DictionaryCommand class", ignore_extras);
            set_what("the DictionaryCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingArrayGenerator("field \"NativeData\" of the DictionaryCommand class", false);
            set_what("the DictionaryCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DictionaryCommandJSON  result)
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
        public DictionaryCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DictionaryCommandJSON  result)
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
    protected virtual void handle_result(List<DictionaryCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DictionaryCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DictionaryCommandJSON>();
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
    public List<DictionaryCommandJSON> value;
  };
  };
