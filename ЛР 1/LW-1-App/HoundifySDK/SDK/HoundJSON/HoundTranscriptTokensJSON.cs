/* file "HoundTranscriptTokensJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HoundTranscriptTokensJSON : JSONBase
  {
    public class TypeValueJSON : JSONBase
      {
        private bool flagHasToken;
        private string storeToken;
        private bool flagHasPunctuationBefore;
        private string storePunctuationBefore;
        private bool flagHasPunctuationAfter;
        private string storePunctuationAfter;
        private bool flagHasStartMillisecond;
        private BigInteger storeStartMillisecond;
        private bool flagHasEndMillisecond;
        private BigInteger storeEndMillisecond;
        private bool flagHasSpeakerID;
        private BigInteger storeSpeakerID;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONToken(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Token of TypeValueJSON is not a string.");
            setToken(json_string.getData());
          }


        private void  fromJSONPunctuationBefore(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PunctuationBefore of TypeValueJSON is not a string.");
            setPunctuationBefore(json_string.getData());
          }


        private void  fromJSONPunctuationAfter(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PunctuationAfter of TypeValueJSON is not a string.");
            setPunctuationAfter(json_string.getData());
          }


        private void  fromJSONStartMillisecond(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field StartMillisecond of TypeValueJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field StartMillisecond of TypeValueJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setStartMillisecond(extracted_integer);
          }


        private void  fromJSONEndMillisecond(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field EndMillisecond of TypeValueJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field EndMillisecond of TypeValueJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setEndMillisecond(extracted_integer);
          }


        private void  fromJSONSpeakerID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field SpeakerID of TypeValueJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field SpeakerID of TypeValueJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setSpeakerID(extracted_integer);
          }


        public TypeValueJSON()
          {
            flagHasToken = false;
            flagHasPunctuationBefore = false;
            flagHasPunctuationAfter = false;
            flagHasStartMillisecond = false;
            flagHasEndMillisecond = false;
            flagHasSpeakerID = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasToken()
          {
            return flagHasToken;
          }

        public string  getToken()
          {
            Debug.Assert(flagHasToken);
            return storeToken;
          }

        public bool  hasPunctuationBefore()
          {
            return flagHasPunctuationBefore;
          }

        public string  getPunctuationBefore()
          {
            Debug.Assert(flagHasPunctuationBefore);
            return storePunctuationBefore;
          }

        public bool  hasPunctuationAfter()
          {
            return flagHasPunctuationAfter;
          }

        public string  getPunctuationAfter()
          {
            Debug.Assert(flagHasPunctuationAfter);
            return storePunctuationAfter;
          }

        public bool  hasStartMillisecond()
          {
            return flagHasStartMillisecond;
          }

        public BigInteger  getStartMillisecond()
          {
            Debug.Assert(flagHasStartMillisecond);
            return storeStartMillisecond;
          }

        public bool  hasEndMillisecond()
          {
            return flagHasEndMillisecond;
          }

        public BigInteger  getEndMillisecond()
          {
            Debug.Assert(flagHasEndMillisecond);
            return storeEndMillisecond;
          }

        public bool  hasSpeakerID()
          {
            return flagHasSpeakerID;
          }

        public BigInteger  getSpeakerID()
          {
            Debug.Assert(flagHasSpeakerID);
            return storeSpeakerID;
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

        public void setToken(string new_value)
          {
            flagHasToken = true;
            storeToken = new_value;
          }
        public void unsetToken()
          {
            flagHasToken = false;
          }
        public void setPunctuationBefore(string new_value)
          {
            flagHasPunctuationBefore = true;
            storePunctuationBefore = new_value;
          }
        public void unsetPunctuationBefore()
          {
            flagHasPunctuationBefore = false;
          }
        public void setPunctuationAfter(string new_value)
          {
            flagHasPunctuationAfter = true;
            storePunctuationAfter = new_value;
          }
        public void unsetPunctuationAfter()
          {
            flagHasPunctuationAfter = false;
          }
        public void setStartMillisecond(BigInteger new_value)
          {
            flagHasStartMillisecond = true;
            if (new_value < 0)
                throw new Exception("The value for field StartMillisecond of TypeValueJSON is less than the lower bound (0) for that field.");
            storeStartMillisecond = new_value;
          }
        public void unsetStartMillisecond()
          {
            flagHasStartMillisecond = false;
          }
        public void setEndMillisecond(BigInteger new_value)
          {
            flagHasEndMillisecond = true;
            if (new_value < 0)
                throw new Exception("The value for field EndMillisecond of TypeValueJSON is less than the lower bound (0) for that field.");
            storeEndMillisecond = new_value;
          }
        public void unsetEndMillisecond()
          {
            flagHasEndMillisecond = false;
          }
        public void setSpeakerID(BigInteger new_value)
          {
            flagHasSpeakerID = true;
            if (new_value < 0)
                throw new Exception("The value for field SpeakerID of TypeValueJSON is less than the lower bound (0) for that field.");
            storeSpeakerID = new_value;
          }
        public void unsetSpeakerID()
          {
            flagHasSpeakerID = false;
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
            Debug.Assert(partial_allowed || flagHasToken);
            if (flagHasToken)
              {
                handler.start_pair("Token");
                handler.string_value(storeToken);
              }
            if (flagHasPunctuationBefore)
              {
                handler.start_pair("PunctuationBefore");
                handler.string_value(storePunctuationBefore);
              }
            if (flagHasPunctuationAfter)
              {
                handler.start_pair("PunctuationAfter");
                handler.string_value(storePunctuationAfter);
              }
            if (flagHasStartMillisecond)
              {
                handler.start_pair("StartMillisecond");
                handler.number_value(storeStartMillisecond);
              }
            if (flagHasEndMillisecond)
              {
                handler.start_pair("EndMillisecond");
                handler.number_value(storeEndMillisecond);
              }
            if (flagHasSpeakerID)
              {
                handler.start_pair("SpeakerID");
                handler.number_value(storeSpeakerID);
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
            if (!(hasToken()))
              {
                return "When parsing the object for %what%, the \"Token\" field was missing.";
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
            private JSONHoldingStringGenerator fieldGeneratorToken;
            private JSONHoldingStringGenerator fieldGeneratorPunctuationBefore;
            private JSONHoldingStringGenerator fieldGeneratorPunctuationAfter;
        private class FieldHoldingGeneratorStartMillisecond : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorStartMillisecond(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorStartMillisecond : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorStartMillisecond(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorStartMillisecond fieldGeneratorStartMillisecond;
        private class FieldHoldingGeneratorEndMillisecond : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorEndMillisecond(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorEndMillisecond : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorEndMillisecond(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorEndMillisecond fieldGeneratorEndMillisecond;
        private class FieldHoldingGeneratorSpeakerID : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorSpeakerID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorSpeakerID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorSpeakerID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorSpeakerID fieldGeneratorSpeakerID;
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
                if (fieldGeneratorToken.have_value)
                  {
                    result.setToken(fieldGeneratorToken.value);
                    fieldGeneratorToken.have_value = false;
                  }
                else if ((!(result.hasToken())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Token\" field was missing.");
                  }
                if (fieldGeneratorPunctuationBefore.have_value)
                  {
                    result.setPunctuationBefore(fieldGeneratorPunctuationBefore.value);
                    fieldGeneratorPunctuationBefore.have_value = false;
                  }
                if (fieldGeneratorPunctuationAfter.have_value)
                  {
                    result.setPunctuationAfter(fieldGeneratorPunctuationAfter.value);
                    fieldGeneratorPunctuationAfter.have_value = false;
                  }
                if (fieldGeneratorStartMillisecond.have_value)
                  {
                    result.setStartMillisecond(fieldGeneratorStartMillisecond.value);
                    fieldGeneratorStartMillisecond.have_value = false;
                  }
                if (fieldGeneratorEndMillisecond.have_value)
                  {
                    result.setEndMillisecond(fieldGeneratorEndMillisecond.value);
                    fieldGeneratorEndMillisecond.have_value = false;
                  }
                if (fieldGeneratorSpeakerID.have_value)
                  {
                    result.setSpeakerID(fieldGeneratorSpeakerID.value);
                    fieldGeneratorSpeakerID.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeValueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'E':
                        if ((String.Compare(field_name, 1, "ndMillisecond", 0, 13, false) == 0) && (field_name.Length == 14))
                            return fieldGeneratorEndMillisecond;
                        break;
                    case 'P':
                        if (String.Compare(field_name, 1, "unctuation", 0, 10, false) == 0)
                          {
                            switch (field_name[11])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 12, "fter", 0, 4, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorPunctuationAfter;
                                    break;
                                case 'B':
                                    if ((String.Compare(field_name, 12, "efore", 0, 5, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratorPunctuationBefore;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'p':
                                if ((String.Compare(field_name, 2, "eakerID", 0, 7, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorSpeakerID;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 2, "artMillisecond", 0, 14, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorStartMillisecond;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "oken", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorToken;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorToken = new JSONHoldingStringGenerator("field \"Token\" of the TypeValue class");
                fieldGeneratorPunctuationBefore = new JSONHoldingStringGenerator("field \"PunctuationBefore\" of the TypeValue class");
                fieldGeneratorPunctuationAfter = new JSONHoldingStringGenerator("field \"PunctuationAfter\" of the TypeValue class");
                fieldGeneratorStartMillisecond = new FieldHoldingGeneratorStartMillisecond("field \"StartMillisecond\" of the TypeValue class");
                fieldGeneratorEndMillisecond = new FieldHoldingGeneratorEndMillisecond("field \"EndMillisecond\" of the TypeValue class");
                fieldGeneratorSpeakerID = new FieldHoldingGeneratorSpeakerID("field \"SpeakerID\" of the TypeValue class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorToken = new JSONHoldingStringGenerator("field \"Token\" of the TypeValue class");
                fieldGeneratorPunctuationBefore = new JSONHoldingStringGenerator("field \"PunctuationBefore\" of the TypeValue class");
                fieldGeneratorPunctuationAfter = new JSONHoldingStringGenerator("field \"PunctuationAfter\" of the TypeValue class");
                fieldGeneratorStartMillisecond = new FieldHoldingGeneratorStartMillisecond("field \"StartMillisecond\" of the TypeValue class");
                fieldGeneratorEndMillisecond = new FieldHoldingGeneratorEndMillisecond("field \"EndMillisecond\" of the TypeValue class");
                fieldGeneratorSpeakerID = new FieldHoldingGeneratorSpeakerID("field \"SpeakerID\" of the TypeValue class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorToken.reset();
                fieldGeneratorPunctuationBefore.reset();
                fieldGeneratorPunctuationAfter.reset();
                fieldGeneratorStartMillisecond.reset();
                fieldGeneratorEndMillisecond.reset();
                fieldGeneratorSpeakerID.reset();
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
            throw new Exception("The value for field Value of HoundTranscriptTokensJSON is not an array.");
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


    public HoundTranscriptTokensJSON()
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

    public static HoundTranscriptTokensJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundTranscriptTokensJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundTranscriptTokens", ignore_extras);
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
    public static HoundTranscriptTokensJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundTranscriptTokensJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundTranscriptTokensJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundTranscriptTokens", ignore_extras);
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
    public static HoundTranscriptTokensJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundTranscriptTokensJSON from_text(string text, bool ignore_extras)
      {
        HoundTranscriptTokensJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundTranscriptTokens", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HoundTranscriptTokensJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HoundTranscriptTokensJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HoundTranscriptTokensJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundTranscriptTokens", ignore_extras);
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
            HoundTranscriptTokensJSON result = new HoundTranscriptTokensJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(HoundTranscriptTokensJSON new_result);
        public Generator(bool ignore_extras) : base("Type HoundTranscriptTokens", ignore_extras)
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
        protected override void handle_result(HoundTranscriptTokensJSON  result)
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
        public HoundTranscriptTokensJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HoundTranscriptTokensJSON  result)
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
    protected virtual void handle_result(List<HoundTranscriptTokensJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HoundTranscriptTokensJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HoundTranscriptTokensJSON>();
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
    public List<HoundTranscriptTokensJSON> value;
  };
  };
