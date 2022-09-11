/* file "DictionaryConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class DictionaryConversationStateJSON : JSONBase
  {
    public class TypeEntriesJSON : JSONBase
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
            private DictionaryPartOfSpeechJSON  storePOS;


            private void  fromJSONPOS(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                DictionaryPartOfSpeechJSON convert_classy = DictionaryPartOfSpeechJSON.from_json(json_value, ignore_extras, true);
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

            public DictionaryPartOfSpeechJSON   getPOS()
              {
                Debug.Assert(flagHasPOS);
                return storePOS;
              }

            public DictionaryPartOfSpeechJSON.TypeValue  getPOSValue()
              {
                return getPOS().getValue();
              }

            public string  getPOSAsString()
              {
                return getPOS().getValueAsString();
              }



            public void setPOS(DictionaryPartOfSpeechJSON  new_value)
              {
                if (flagHasPOS)
                  {
                  }
                flagHasPOS = true;
                storePOS = new_value;
              }
            public void setPOS(DictionaryPartOfSpeechJSON.TypeValue new_value)
              {
                setPOS(new DictionaryPartOfSpeechJSON(new_value));
              }
            public void setPOS(string chars)
              {
                DictionaryPartOfSpeechJSON.TypeValueKnownValues known = DictionaryPartOfSpeechJSON.stringToValue(chars);
                DictionaryPartOfSpeechJSON.TypeValue new_value = new DictionaryPartOfSpeechJSON.TypeValue();
                if (known == DictionaryPartOfSpeechJSON.TypeValueKnownValues.Value__none)
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
                private DictionaryPartOfSpeechJSON.HoldingGenerator fieldGeneratorPOS;

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
                    fieldGeneratorPOS = new DictionaryPartOfSpeechJSON.HoldingGenerator("field \"POS\" of the TypePOSList class", ignore_extras);
                    set_what("the TypePOSList class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorPOS = new DictionaryPartOfSpeechJSON.HoldingGenerator("field \"POS\" of the TypePOSList class", false);
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
        public class TypeTargetsJSON : JSONBase
          {
            private bool flagHasTarget;
            private BigInteger storeTarget;
            private bool flagHasWord;
            private string storeWord;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONTarget(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field Target of TypeTargetsJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field Target of TypeTargetsJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setTarget(extracted_integer);
              }


            private void  fromJSONWord(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Word of TypeTargetsJSON is not a string.");
                setWord(json_string.getData());
              }


            public TypeTargetsJSON()
              {
                flagHasTarget = false;
                flagHasWord = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasTarget()
              {
                return flagHasTarget;
              }

            public BigInteger  getTarget()
              {
                Debug.Assert(flagHasTarget);
                return storeTarget;
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


            public virtual int extraTypeTargetsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeTargetsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeTargetsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeTargetsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setTarget(BigInteger new_value)
              {
                flagHasTarget = true;
                storeTarget = new_value;
              }
            public void unsetTarget()
              {
                flagHasTarget = false;
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

            public virtual void extraTypeTargetsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeTargetsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeTargetsLookup(key);
                if (old_field == null)
                  {
                    extraTypeTargetsAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasTarget);
                if (flagHasTarget)
                  {
                    handler.start_pair("Target");
                    handler.number_value(storeTarget);
                  }
                Debug.Assert(partial_allowed || flagHasWord);
                if (flagHasWord)
                  {
                    handler.start_pair("Word");
                    handler.string_value(storeWord);
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
                if (!(hasTarget()))
                  {
                    return "When parsing the object for %what%, the \"Target\" field was missing.";
                  }
                if (!(hasWord()))
                  {
                    return "When parsing the object for %what%, the \"Word\" field was missing.";
                  }
                return null;
              }

            public static TypeTargetsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeTargetsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeTargets", ignore_extras);
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
            public static TypeTargetsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeTargetsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeTargetsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeTargets", ignore_extras);
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
            public static TypeTargetsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeTargetsJSON from_text(string text, bool ignore_extras)
              {
                TypeTargetsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeTargets", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeTargetsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeTargetsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeTargetsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeTargets", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
            private class FieldHoldingGeneratorTarget : JSONHoldingIntegerUnboundRangeGenerator
                  {
                    public FieldHoldingGeneratorTarget(String what) : base(what)
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorTarget : JSONHoldingIntegerUnboundRangeArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorTarget(String what) : base(what)
                      {
                      }
                  };
                private FieldHoldingGeneratorTarget fieldGeneratorTarget;
                private JSONHoldingStringGenerator fieldGeneratorWord;
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
                    TypeTargetsJSON result = new TypeTargetsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeTargetsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeTargetsJSON result)
                  {
                    if (fieldGeneratorTarget.have_value)
                      {
                        result.setTarget(fieldGeneratorTarget.value);
                        fieldGeneratorTarget.have_value = false;
                      }
                    else if ((!(result.hasTarget())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Target\" field was missing.");
                      }
                    if (fieldGeneratorWord.have_value)
                      {
                        result.setWord(fieldGeneratorWord.value);
                        fieldGeneratorWord.have_value = false;
                      }
                    else if ((!(result.hasWord())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Word\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeTargetsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'T':
                            if ((String.Compare(field_name, 1, "arget", 0, 5, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorTarget;
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
                    fieldGeneratorTarget = new FieldHoldingGeneratorTarget("field \"Target\" of the TypeTargets class");
                    fieldGeneratorWord = new JSONHoldingStringGenerator("field \"Word\" of the TypeTargets class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeTargets class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorTarget = new FieldHoldingGeneratorTarget("field \"Target\" of the TypeTargets class");
                    fieldGeneratorWord = new JSONHoldingStringGenerator("field \"Word\" of the TypeTargets class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeTargets class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorTarget.reset();
                    fieldGeneratorWord.reset();
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
                protected override void handle_result(TypeTargetsJSON  result)
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
                public TypeTargetsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeTargetsJSON  result)
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
            protected virtual void handle_result(List<TypeTargetsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeTargetsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeTargetsJSON>();
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
            public List<TypeTargetsJSON> value;
          };
          };
        private bool flagHasRequestKindList;
        private List< TypeRequestKindListJSON  > storeRequestKindList;
        private bool flagHasPOSList;
        private List< TypePOSListJSON  > storePOSList;
        private bool flagHasTargets;
        private List< TypeTargetsJSON  > storeTargets;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONRequestKindList(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field RequestKindList of TypeEntriesJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field RequestKindList of TypeEntriesJSON has too few elements.");
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
                throw new Exception("The value for field POSList of TypeEntriesJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field POSList of TypeEntriesJSON has too few elements.");
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


        private void  fromJSONTargets(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Targets of TypeEntriesJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field Targets of TypeEntriesJSON has too few elements.");
            List< TypeTargetsJSON  > vector_Targets1 = new List< TypeTargetsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeTargetsJSON convert_classy = TypeTargetsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Targets1.Add(convert_classy);
              }
            Debug.Assert(vector_Targets1.Count >= 1);
            initTargets();
            for (int num3 = 0; num3 < vector_Targets1.Count; ++num3)
                appendTargets(vector_Targets1[num3]);
            for (int num1 = 0; num1 < vector_Targets1.Count; ++num1)
              {
              }
          }


        public TypeEntriesJSON()
          {
            flagHasRequestKindList = false;
            flagHasPOSList = false;
            flagHasTargets = false;
            storeRequestKindList = new List< TypeRequestKindListJSON  >();
            storePOSList = new List< TypePOSListJSON  >();
            storeTargets = new List< TypeTargetsJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
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

        public bool  hasTargets()
          {
            return flagHasTargets;
          }

        public int  countOfTargets()
          {
            Debug.Assert(flagHasTargets);
            return storeTargets.Count;
          }

        public TypeTargetsJSON   elementOfTargets(int element_num)
          {
            Debug.Assert(flagHasTargets);
            return storeTargets[element_num];
          }

        public List< TypeTargetsJSON  >  getTargets()
          {
            Debug.Assert(flagHasTargets);
            return storeTargets;
          }


        public virtual int extraTypeEntriesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeEntriesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeEntriesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeEntriesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
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
        public void initTargets()
          {
            if (flagHasTargets)
              {
                for (int num5 = 0; num5 < storeTargets.Count; ++num5)
                  {
                  }
              }
            flagHasTargets = true;
            storeTargets.Clear();
          }
        public void appendTargets(TypeTargetsJSON  to_append)
          {
            if (!flagHasTargets)
              {
                flagHasTargets = true;
                storeTargets.Clear();
              }
            Debug.Assert(flagHasTargets);
            storeTargets.Add(to_append);
          }
        public void unsetTargets()
          {
            if (flagHasTargets)
              {
                for (int num6 = 0; num6 < storeTargets.Count; ++num6)
                  {
                  }
              }
            flagHasTargets = false;
            storeTargets.Clear();
          }

        public virtual void extraTypeEntriesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeEntriesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeEntriesLookup(key);
            if (old_field == null)
              {
                extraTypeEntriesAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasTargets);
            if (flagHasTargets)
              {
                handler.start_pair("Targets");
                Debug.Assert(storeTargets.Count >= 1);
                handler.start_array();
                for (int num3 = 0; num3 < storeTargets.Count; ++num3)
                  {
                    if (partial_allowed)
                        storeTargets[num3].write_partial_as_json(handler);
                    else
                        storeTargets[num3].write_as_json(handler);
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
            if (!(hasRequestKindList()))
              {
                return "When parsing the object for %what%, the \"RequestKindList\" field was missing.";
              }
            if (!(hasPOSList()))
              {
                return "When parsing the object for %what%, the \"POSList\" field was missing.";
              }
            if (!(hasTargets()))
              {
                return "When parsing the object for %what%, the \"Targets\" field was missing.";
              }
            return null;
          }

        public static TypeEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntries", ignore_extras);
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
        public static TypeEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntries", ignore_extras);
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
        public static TypeEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEntriesJSON from_text(string text, bool ignore_extras)
          {
            TypeEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntries", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeEntriesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeEntriesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntries", ignore_extras);
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
            private TypeTargetsJSON.HoldingArrayGenerator fieldGeneratorTargets;
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
                TypeEntriesJSON result = new TypeEntriesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeEntriesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeEntriesJSON result)
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
                if (fieldGeneratorTargets.have_value)
                  {
                    result.initTargets();
                    int count = fieldGeneratorTargets.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendTargets(fieldGeneratorTargets.value[num]);
                      }
                    fieldGeneratorTargets.value.Clear();
                    fieldGeneratorTargets.have_value = false;
                  }
                else if ((!(result.hasTargets())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Targets\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeEntriesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'P':
                        if ((String.Compare(field_name, 1, "OSList", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorPOSList;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "equestKindList", 0, 14, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorRequestKindList;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "argets", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorTargets;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorRequestKindList = new TypeRequestKindListJSON.HoldingArrayGenerator("field \"RequestKindList\" of the TypeEntries class", ignore_extras);
                fieldGeneratorPOSList = new TypePOSListJSON.HoldingArrayGenerator("field \"POSList\" of the TypeEntries class", ignore_extras);
                fieldGeneratorTargets = new TypeTargetsJSON.HoldingArrayGenerator("field \"Targets\" of the TypeEntries class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorRequestKindList = new TypeRequestKindListJSON.HoldingArrayGenerator("field \"RequestKindList\" of the TypeEntries class", false);
                fieldGeneratorPOSList = new TypePOSListJSON.HoldingArrayGenerator("field \"POSList\" of the TypeEntries class", false);
                fieldGeneratorTargets = new TypeTargetsJSON.HoldingArrayGenerator("field \"Targets\" of the TypeEntries class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorRequestKindList.reset();
                fieldGeneratorPOSList.reset();
                fieldGeneratorTargets.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorRequestKindList.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorPOSList.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTargets.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorRequestKindList.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorPOSList.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTargets.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeEntriesJSON  result)
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
            public TypeEntriesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeEntriesJSON  result)
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
        protected virtual void handle_result(List<TypeEntriesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeEntriesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeEntriesJSON>();
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
        public List<TypeEntriesJSON> value;
      };
      };
    private bool flagHasEntries;
    private List< TypeEntriesJSON  > storeEntries;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEntries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Entries of DictionaryConversationStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Entries of DictionaryConversationStateJSON has too few elements.");
        List< TypeEntriesJSON  > vector_Entries1 = new List< TypeEntriesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeEntriesJSON convert_classy = TypeEntriesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Entries1.Add(convert_classy);
          }
        Debug.Assert(vector_Entries1.Count >= 1);
        initEntries();
        for (int num4 = 0; num4 < vector_Entries1.Count; ++num4)
            appendEntries(vector_Entries1[num4]);
        for (int num1 = 0; num1 < vector_Entries1.Count; ++num1)
          {
          }
      }


    public DictionaryConversationStateJSON()
      {
        flagHasEntries = false;
        storeEntries = new List< TypeEntriesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEntries()
      {
        return flagHasEntries;
      }

    public int  countOfEntries()
      {
        Debug.Assert(flagHasEntries);
        return storeEntries.Count;
      }

    public TypeEntriesJSON   elementOfEntries(int element_num)
      {
        Debug.Assert(flagHasEntries);
        return storeEntries[element_num];
      }

    public List< TypeEntriesJSON  >  getEntries()
      {
        Debug.Assert(flagHasEntries);
        return storeEntries;
      }


    public virtual int extraDictionaryConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDictionaryConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDictionaryConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDictionaryConversationStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initEntries()
      {
        if (flagHasEntries)
          {
            for (int num7 = 0; num7 < storeEntries.Count; ++num7)
              {
              }
          }
        flagHasEntries = true;
        storeEntries.Clear();
      }
    public void appendEntries(TypeEntriesJSON  to_append)
      {
        if (!flagHasEntries)
          {
            flagHasEntries = true;
            storeEntries.Clear();
          }
        Debug.Assert(flagHasEntries);
        storeEntries.Add(to_append);
      }
    public void unsetEntries()
      {
        if (flagHasEntries)
          {
            for (int num8 = 0; num8 < storeEntries.Count; ++num8)
              {
              }
          }
        flagHasEntries = false;
        storeEntries.Clear();
      }

    public virtual void extraDictionaryConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDictionaryConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDictionaryConversationStateLookup(key);
        if (old_field == null)
          {
            extraDictionaryConversationStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasEntries);
        if (flagHasEntries)
          {
            handler.start_pair("Entries");
            Debug.Assert(storeEntries.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeEntries.Count; ++num1)
              {
                if (partial_allowed)
                    storeEntries[num1].write_partial_as_json(handler);
                else
                    storeEntries[num1].write_as_json(handler);
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
        if (!(hasEntries()))
          {
            return "When parsing the object for %what%, the \"Entries\" field was missing.";
          }
        return null;
      }

    public static DictionaryConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DictionaryConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryConversationState", ignore_extras);
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
    public static DictionaryConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DictionaryConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DictionaryConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryConversationState", ignore_extras);
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
    public static DictionaryConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DictionaryConversationStateJSON from_text(string text, bool ignore_extras)
      {
        DictionaryConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DictionaryConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DictionaryConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DictionaryConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DictionaryConversationState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeEntriesJSON.HoldingArrayGenerator fieldGeneratorEntries;
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
            DictionaryConversationStateJSON result = new DictionaryConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDictionaryConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DictionaryConversationStateJSON result)
          {
            if (fieldGeneratorEntries.have_value)
              {
                result.initEntries();
                int count = fieldGeneratorEntries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEntries(fieldGeneratorEntries.value[num]);
                  }
                fieldGeneratorEntries.value.Clear();
                fieldGeneratorEntries.have_value = false;
              }
            else if ((!(result.hasEntries())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Entries\" field was missing.");
              }
          }
        protected abstract void handle_result(DictionaryConversationStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Entries", 0, 7, false) == 0) && (field_name.Length == 7))
                return fieldGeneratorEntries;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEntries = new TypeEntriesJSON.HoldingArrayGenerator("field \"Entries\" of the DictionaryConversationState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DictionaryConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEntries = new TypeEntriesJSON.HoldingArrayGenerator("field \"Entries\" of the DictionaryConversationState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DictionaryConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEntries.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEntries.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEntries.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DictionaryConversationStateJSON  result)
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
        public DictionaryConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DictionaryConversationStateJSON  result)
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
    protected virtual void handle_result(List<DictionaryConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DictionaryConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DictionaryConversationStateJSON>();
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
    public List<DictionaryConversationStateJSON> value;
  };
  };
