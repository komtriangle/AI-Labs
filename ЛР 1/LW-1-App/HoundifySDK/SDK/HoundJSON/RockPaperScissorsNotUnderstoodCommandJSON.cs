/* file "RockPaperScissorsNotUnderstoodCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RockPaperScissorsNotUnderstoodCommandJSON : RockPaperScissorsCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasServerScore;
        private BigInteger storeServerScore;
        private bool flagHasPlayerScore;
        private BigInteger storePlayerScore;
        private bool flagHasGameState;
        private string storeGameState;
        private bool flagHasLastPlayerObject;
        private string storeLastPlayerObject;
        private bool flagHasLastServerObject;
        private string storeLastServerObject;
        private bool flagHasMatchImageURL;
        private string storeMatchImageURL;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONServerScore(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field ServerScore of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field ServerScore of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setServerScore(extracted_integer);
          }


        private void  fromJSONPlayerScore(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field PlayerScore of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field PlayerScore of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setPlayerScore(extracted_integer);
          }


        private void  fromJSONGameState(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field GameState of TypeNativeDataJSON is not a string.");
            setGameState(json_string.getData());
          }


        private void  fromJSONLastPlayerObject(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field LastPlayerObject of TypeNativeDataJSON is not a string.");
            setLastPlayerObject(json_string.getData());
          }


        private void  fromJSONLastServerObject(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field LastServerObject of TypeNativeDataJSON is not a string.");
            setLastServerObject(json_string.getData());
          }


        private void  fromJSONMatchImageURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field MatchImageURL of TypeNativeDataJSON is not a string.");
            setMatchImageURL(json_string.getData());
          }


        public TypeNativeDataJSON()
          {
            flagHasServerScore = false;
            flagHasPlayerScore = false;
            flagHasGameState = false;
            flagHasLastPlayerObject = false;
            flagHasLastServerObject = false;
            flagHasMatchImageURL = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasServerScore()
          {
            return flagHasServerScore;
          }

        public BigInteger  getServerScore()
          {
            Debug.Assert(flagHasServerScore);
            return storeServerScore;
          }

        public bool  hasPlayerScore()
          {
            return flagHasPlayerScore;
          }

        public BigInteger  getPlayerScore()
          {
            Debug.Assert(flagHasPlayerScore);
            return storePlayerScore;
          }

        public bool  hasGameState()
          {
            return flagHasGameState;
          }

        public string  getGameState()
          {
            Debug.Assert(flagHasGameState);
            return storeGameState;
          }

        public bool  hasLastPlayerObject()
          {
            return flagHasLastPlayerObject;
          }

        public string  getLastPlayerObject()
          {
            Debug.Assert(flagHasLastPlayerObject);
            return storeLastPlayerObject;
          }

        public bool  hasLastServerObject()
          {
            return flagHasLastServerObject;
          }

        public string  getLastServerObject()
          {
            Debug.Assert(flagHasLastServerObject);
            return storeLastServerObject;
          }

        public bool  hasMatchImageURL()
          {
            return flagHasMatchImageURL;
          }

        public string  getMatchImageURL()
          {
            Debug.Assert(flagHasMatchImageURL);
            return storeMatchImageURL;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setServerScore(BigInteger new_value)
          {
            flagHasServerScore = true;
            if (new_value < 0)
                throw new Exception("The value for field ServerScore of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeServerScore = new_value;
          }
        public void unsetServerScore()
          {
            flagHasServerScore = false;
          }
        public void setPlayerScore(BigInteger new_value)
          {
            flagHasPlayerScore = true;
            if (new_value < 0)
                throw new Exception("The value for field PlayerScore of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storePlayerScore = new_value;
          }
        public void unsetPlayerScore()
          {
            flagHasPlayerScore = false;
          }
        public void setGameState(string new_value)
          {
            flagHasGameState = true;
            storeGameState = new_value;
          }
        public void unsetGameState()
          {
            flagHasGameState = false;
          }
        public void setLastPlayerObject(string new_value)
          {
            flagHasLastPlayerObject = true;
            storeLastPlayerObject = new_value;
          }
        public void unsetLastPlayerObject()
          {
            flagHasLastPlayerObject = false;
          }
        public void setLastServerObject(string new_value)
          {
            flagHasLastServerObject = true;
            storeLastServerObject = new_value;
          }
        public void unsetLastServerObject()
          {
            flagHasLastServerObject = false;
          }
        public void setMatchImageURL(string new_value)
          {
            flagHasMatchImageURL = true;
            storeMatchImageURL = new_value;
          }
        public void unsetMatchImageURL()
          {
            flagHasMatchImageURL = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            if (flagHasServerScore)
              {
                handler.start_pair("ServerScore");
                handler.number_value(storeServerScore);
              }
            if (flagHasPlayerScore)
              {
                handler.start_pair("PlayerScore");
                handler.number_value(storePlayerScore);
              }
            Debug.Assert(partial_allowed || flagHasGameState);
            if (flagHasGameState)
              {
                handler.start_pair("GameState");
                handler.string_value(storeGameState);
              }
            if (flagHasLastPlayerObject)
              {
                handler.start_pair("LastPlayerObject");
                handler.string_value(storeLastPlayerObject);
              }
            if (flagHasLastServerObject)
              {
                handler.start_pair("LastServerObject");
                handler.string_value(storeLastServerObject);
              }
            if (flagHasMatchImageURL)
              {
                handler.start_pair("MatchImageURL");
                handler.string_value(storeMatchImageURL);
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
            if (!(hasGameState()))
              {
                return "When parsing the object for %what%, the \"GameState\" field was missing.";
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
        private class FieldHoldingGeneratorServerScore : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorServerScore(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorServerScore : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorServerScore(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorServerScore fieldGeneratorServerScore;
        private class FieldHoldingGeneratorPlayerScore : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorPlayerScore(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorPlayerScore : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorPlayerScore(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorPlayerScore fieldGeneratorPlayerScore;
            private JSONHoldingStringGenerator fieldGeneratorGameState;
            private JSONHoldingStringGenerator fieldGeneratorLastPlayerObject;
            private JSONHoldingStringGenerator fieldGeneratorLastServerObject;
            private JSONHoldingStringGenerator fieldGeneratorMatchImageURL;
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorServerScore.have_value)
                  {
                    result.setServerScore(fieldGeneratorServerScore.value);
                    fieldGeneratorServerScore.have_value = false;
                  }
                if (fieldGeneratorPlayerScore.have_value)
                  {
                    result.setPlayerScore(fieldGeneratorPlayerScore.value);
                    fieldGeneratorPlayerScore.have_value = false;
                  }
                if (fieldGeneratorGameState.have_value)
                  {
                    result.setGameState(fieldGeneratorGameState.value);
                    fieldGeneratorGameState.have_value = false;
                  }
                else if ((!(result.hasGameState())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"GameState\" field was missing.");
                  }
                if (fieldGeneratorLastPlayerObject.have_value)
                  {
                    result.setLastPlayerObject(fieldGeneratorLastPlayerObject.value);
                    fieldGeneratorLastPlayerObject.have_value = false;
                  }
                if (fieldGeneratorLastServerObject.have_value)
                  {
                    result.setLastServerObject(fieldGeneratorLastServerObject.value);
                    fieldGeneratorLastServerObject.have_value = false;
                  }
                if (fieldGeneratorMatchImageURL.have_value)
                  {
                    result.setMatchImageURL(fieldGeneratorMatchImageURL.value);
                    fieldGeneratorMatchImageURL.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'G':
                        if ((String.Compare(field_name, 1, "ameState", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorGameState;
                        break;
                    case 'L':
                        if (String.Compare(field_name, 1, "ast", 0, 3, false) == 0)
                          {
                            switch (field_name[4])
                              {
                                case 'P':
                                    if ((String.Compare(field_name, 5, "layerObject", 0, 11, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorLastPlayerObject;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 5, "erverObject", 0, 11, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorLastServerObject;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "atchImageURL", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorMatchImageURL;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "layerScore", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorPlayerScore;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "erverScore", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorServerScore;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorServerScore = new FieldHoldingGeneratorServerScore("field \"ServerScore\" of the TypeNativeData class");
                fieldGeneratorPlayerScore = new FieldHoldingGeneratorPlayerScore("field \"PlayerScore\" of the TypeNativeData class");
                fieldGeneratorGameState = new JSONHoldingStringGenerator("field \"GameState\" of the TypeNativeData class");
                fieldGeneratorLastPlayerObject = new JSONHoldingStringGenerator("field \"LastPlayerObject\" of the TypeNativeData class");
                fieldGeneratorLastServerObject = new JSONHoldingStringGenerator("field \"LastServerObject\" of the TypeNativeData class");
                fieldGeneratorMatchImageURL = new JSONHoldingStringGenerator("field \"MatchImageURL\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorServerScore = new FieldHoldingGeneratorServerScore("field \"ServerScore\" of the TypeNativeData class");
                fieldGeneratorPlayerScore = new FieldHoldingGeneratorPlayerScore("field \"PlayerScore\" of the TypeNativeData class");
                fieldGeneratorGameState = new JSONHoldingStringGenerator("field \"GameState\" of the TypeNativeData class");
                fieldGeneratorLastPlayerObject = new JSONHoldingStringGenerator("field \"LastPlayerObject\" of the TypeNativeData class");
                fieldGeneratorLastServerObject = new JSONHoldingStringGenerator("field \"LastServerObject\" of the TypeNativeData class");
                fieldGeneratorMatchImageURL = new JSONHoldingStringGenerator("field \"MatchImageURL\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorServerScore.reset();
                fieldGeneratorPlayerScore.reset();
                fieldGeneratorGameState.reset();
                fieldGeneratorLastPlayerObject.reset();
                fieldGeneratorLastServerObject.reset();
                fieldGeneratorMatchImageURL.reset();
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
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public RockPaperScissorsNotUnderstoodCommandJSON()
      {
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRockPaperScissorsCommandKind()
      {
        return "RockPaperScissorsNotUnderstoodCommand";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public virtual int extraRockPaperScissorsNotUnderstoodCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRockPaperScissorsNotUnderstoodCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRockPaperScissorsNotUnderstoodCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRockPaperScissorsNotUnderstoodCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRockPaperScissorsCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraRockPaperScissorsNotUnderstoodCommandComponentCount();
        return result;
      }
    public override string extraRockPaperScissorsCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraRockPaperScissorsNotUnderstoodCommandComponentKey(remainder);
      }
    public override JSONValue extraRockPaperScissorsCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraRockPaperScissorsNotUnderstoodCommandComponentValue(remainder);
      }
    public override JSONValue extraRockPaperScissorsCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraRockPaperScissorsNotUnderstoodCommandLookup(field_name);
      }

    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public virtual void extraRockPaperScissorsNotUnderstoodCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRockPaperScissorsNotUnderstoodCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRockPaperScissorsNotUnderstoodCommandLookup(key);
        if (old_field == null)
          {
            extraRockPaperScissorsNotUnderstoodCommandAppendPair(key, new_component);
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
    public override void extraRockPaperScissorsCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraRockPaperScissorsNotUnderstoodCommandAppendPair(key, new_component);
      }
    public override void extraRockPaperScissorsCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraRockPaperScissorsNotUnderstoodCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
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
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new RockPaperScissorsNotUnderstoodCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RockPaperScissorsNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RockPaperScissorsNotUnderstoodCommand", ignore_extras);
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
    public static new RockPaperScissorsNotUnderstoodCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RockPaperScissorsNotUnderstoodCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RockPaperScissorsNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RockPaperScissorsNotUnderstoodCommand", ignore_extras);
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
    public static new RockPaperScissorsNotUnderstoodCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RockPaperScissorsNotUnderstoodCommandJSON from_text(string text, bool ignore_extras)
      {
        RockPaperScissorsNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RockPaperScissorsNotUnderstoodCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RockPaperScissorsNotUnderstoodCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RockPaperScissorsNotUnderstoodCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RockPaperScissorsNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RockPaperScissorsNotUnderstoodCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RockPaperScissorsCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
            if (!(getRockPaperScissorsCommandJSONKey().Equals("RockPaperScissorsNotUnderstoodCommand")))
                throw new Exception("The key field has a value other than `RockPaperScissorsNotUnderstoodCommand'.");
            RockPaperScissorsNotUnderstoodCommandJSON result = new RockPaperScissorsNotUnderstoodCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRockPaperScissorsNotUnderstoodCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RockPaperScissorsCommandJSON new_result)
          {
            handle_result((RockPaperScissorsNotUnderstoodCommandJSON )new_result);
          }
        protected void finish(RockPaperScissorsNotUnderstoodCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RockPaperScissorsNotUnderstoodCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the RockPaperScissorsNotUnderstoodCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RockPaperScissorsNotUnderstoodCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the RockPaperScissorsNotUnderstoodCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RockPaperScissorsNotUnderstoodCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RockPaperScissorsNotUnderstoodCommandJSON  result)
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
        public RockPaperScissorsNotUnderstoodCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RockPaperScissorsNotUnderstoodCommandJSON  result)
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
    protected virtual void handle_result(List<RockPaperScissorsNotUnderstoodCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RockPaperScissorsNotUnderstoodCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RockPaperScissorsNotUnderstoodCommandJSON>();
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
    public List<RockPaperScissorsNotUnderstoodCommandJSON> value;
  };
  };
