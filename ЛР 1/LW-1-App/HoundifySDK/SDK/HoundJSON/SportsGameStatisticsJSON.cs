/* file "SportsGameStatisticsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsGameStatisticsJSON : JSONBase
  {
    public class TypeTeamsJSON : JSONBase
      {
        public class TypePlayersJSON : JSONBase
          {
            private bool flagHasPlayersIndex;
            private BigInteger storePlayersIndex;
            private bool flagHasStatistics;
            private List< SportsStatsTypeAndValueJSON  > storeStatistics;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONPlayersIndex(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field PlayersIndex of TypePlayersJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field PlayersIndex of TypePlayersJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setPlayersIndex(extracted_integer);
              }


            private void  fromJSONStatistics(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONArrayValue json_array1 = json_value.array_value();
                if (json_array1 == null)
                    throw new Exception("The value for field Statistics of TypePlayersJSON is not an array.");
                int count1 = json_array1.componentCount();
                List< SportsStatsTypeAndValueJSON  > vector_Statistics1 = new List< SportsStatsTypeAndValueJSON  >(count1);
                for (int num1 = 0; num1 < count1; ++num1)
                  {
                    SportsStatsTypeAndValueJSON convert_classy = SportsStatsTypeAndValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
                    vector_Statistics1.Add(convert_classy);
                  }
                initStatistics();
                for (int num1 = 0; num1 < vector_Statistics1.Count; ++num1)
                    appendStatistics(vector_Statistics1[num1]);
                for (int num1 = 0; num1 < vector_Statistics1.Count; ++num1)
                  {
                  }
              }


            public TypePlayersJSON()
              {
                flagHasPlayersIndex = false;
                flagHasStatistics = false;
                storeStatistics = new List< SportsStatsTypeAndValueJSON  >();
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasPlayersIndex()
              {
                return flagHasPlayersIndex;
              }

            public BigInteger  getPlayersIndex()
              {
                Debug.Assert(flagHasPlayersIndex);
                return storePlayersIndex;
              }

            public bool  hasStatistics()
              {
                return flagHasStatistics;
              }

            public int  countOfStatistics()
              {
                Debug.Assert(flagHasStatistics);
                return storeStatistics.Count;
              }

            public SportsStatsTypeAndValueJSON   elementOfStatistics(int element_num)
              {
                Debug.Assert(flagHasStatistics);
                return storeStatistics[element_num];
              }

            public List< SportsStatsTypeAndValueJSON  >  getStatistics()
              {
                Debug.Assert(flagHasStatistics);
                return storeStatistics;
              }


            public virtual int extraTypePlayersComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypePlayersComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypePlayersComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypePlayersLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setPlayersIndex(BigInteger new_value)
              {
                flagHasPlayersIndex = true;
                if (new_value < 0)
                    throw new Exception("The value for field PlayersIndex of TypePlayersJSON is less than the lower bound (0) for that field.");
                storePlayersIndex = new_value;
              }
            public void unsetPlayersIndex()
              {
                flagHasPlayersIndex = false;
              }
            public void initStatistics()
              {
                if (flagHasStatistics)
                  {
                    for (int num1 = 0; num1 < storeStatistics.Count; ++num1)
                      {
                      }
                  }
                flagHasStatistics = true;
                storeStatistics.Clear();
              }
            public void appendStatistics(SportsStatsTypeAndValueJSON  to_append)
              {
                if (!flagHasStatistics)
                  {
                    flagHasStatistics = true;
                    storeStatistics.Clear();
                  }
                Debug.Assert(flagHasStatistics);
                storeStatistics.Add(to_append);
              }
            public void unsetStatistics()
              {
                if (flagHasStatistics)
                  {
                    for (int num2 = 0; num2 < storeStatistics.Count; ++num2)
                      {
                      }
                  }
                flagHasStatistics = false;
                storeStatistics.Clear();
              }

            public virtual void extraTypePlayersAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypePlayersSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypePlayersLookup(key);
                if (old_field == null)
                  {
                    extraTypePlayersAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasPlayersIndex);
                if (flagHasPlayersIndex)
                  {
                    handler.start_pair("PlayersIndex");
                    handler.number_value(storePlayersIndex);
                  }
                if (flagHasStatistics)
                  {
                    handler.start_pair("Statistics");
                    handler.start_array();
                    for (int num1 = 0; num1 < storeStatistics.Count; ++num1)
                      {
                        if (partial_allowed)
                            storeStatistics[num1].write_partial_as_json(handler);
                        else
                            storeStatistics[num1].write_as_json(handler);
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
                if (!(hasPlayersIndex()))
                  {
                    return "When parsing the object for %what%, the \"PlayersIndex\" field was missing.";
                  }
                return null;
              }

            public static TypePlayersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypePlayersJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
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
            public static TypePlayersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypePlayersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypePlayersJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
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
            public static TypePlayersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypePlayersJSON from_text(string text, bool ignore_extras)
              {
                TypePlayersJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypePlayersJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypePlayersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypePlayersJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
            private class FieldHoldingGeneratorPlayersIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorPlayersIndex(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorPlayersIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorPlayersIndex(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorPlayersIndex fieldGeneratorPlayersIndex;
                private SportsStatsTypeAndValueJSON.HoldingArrayGenerator fieldGeneratorStatistics;
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
                    TypePlayersJSON result = new TypePlayersJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypePlayersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypePlayersJSON result)
                  {
                    if (fieldGeneratorPlayersIndex.have_value)
                      {
                        result.setPlayersIndex(fieldGeneratorPlayersIndex.value);
                        fieldGeneratorPlayersIndex.have_value = false;
                      }
                    else if ((!(result.hasPlayersIndex())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"PlayersIndex\" field was missing.");
                      }
                    if (fieldGeneratorStatistics.have_value)
                      {
                        result.initStatistics();
                        int count = fieldGeneratorStatistics.value.Count;
                        for (int num = 0; num < count; ++num)
                          {
                            result.appendStatistics(fieldGeneratorStatistics.value[num]);
                          }
                        fieldGeneratorStatistics.value.Clear();
                        fieldGeneratorStatistics.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypePlayersJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'P':
                            if ((String.Compare(field_name, 1, "layersIndex", 0, 11, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorPlayersIndex;
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 1, "tatistics", 0, 9, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorStatistics;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorPlayersIndex = new FieldHoldingGeneratorPlayersIndex("field \"PlayersIndex\" of the TypePlayers class");
                    fieldGeneratorStatistics = new SportsStatsTypeAndValueJSON.HoldingArrayGenerator("field \"Statistics\" of the TypePlayers class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypePlayers class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorPlayersIndex = new FieldHoldingGeneratorPlayersIndex("field \"PlayersIndex\" of the TypePlayers class");
                    fieldGeneratorStatistics = new SportsStatsTypeAndValueJSON.HoldingArrayGenerator("field \"Statistics\" of the TypePlayers class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypePlayers class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorPlayersIndex.reset();
                    fieldGeneratorStatistics.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorStatistics.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorStatistics.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypePlayersJSON  result)
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
                public TypePlayersJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypePlayersJSON  result)
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
            protected virtual void handle_result(List<TypePlayersJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypePlayersJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypePlayersJSON>();
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
            public List<TypePlayersJSON> value;
          };
          };
        private bool flagHasPlayers;
        private List< TypePlayersJSON  > storePlayers;
        private bool flagHasTeamIndex;
        private sbyte storeTeamIndex;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONPlayers(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Players of TypeTeamsJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypePlayersJSON  > vector_Players1 = new List< TypePlayersJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypePlayersJSON convert_classy = TypePlayersJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Players1.Add(convert_classy);
              }
            initPlayers();
            for (int num2 = 0; num2 < vector_Players1.Count; ++num2)
                appendPlayers(vector_Players1[num2]);
            for (int num1 = 0; num1 < vector_Players1.Count; ++num1)
              {
              }
          }


        private void  fromJSONTeamIndex(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field TeamIndex of TypeTeamsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field TeamIndex of TypeTeamsJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setTeamIndex(extracted_integer);
          }


        public TypeTeamsJSON()
          {
            flagHasPlayers = false;
            flagHasTeamIndex = false;
            storePlayers = new List< TypePlayersJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasPlayers()
          {
            return flagHasPlayers;
          }

        public int  countOfPlayers()
          {
            Debug.Assert(flagHasPlayers);
            return storePlayers.Count;
          }

        public TypePlayersJSON   elementOfPlayers(int element_num)
          {
            Debug.Assert(flagHasPlayers);
            return storePlayers[element_num];
          }

        public List< TypePlayersJSON  >  getPlayers()
          {
            Debug.Assert(flagHasPlayers);
            return storePlayers;
          }

        public bool  hasTeamIndex()
          {
            return flagHasTeamIndex;
          }

        public sbyte  getTeamIndex()
          {
            Debug.Assert(flagHasTeamIndex);
            return storeTeamIndex;
          }


        public virtual int extraTypeTeamsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeTeamsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeTeamsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeTeamsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initPlayers()
          {
            if (flagHasPlayers)
              {
                for (int num3 = 0; num3 < storePlayers.Count; ++num3)
                  {
                  }
              }
            flagHasPlayers = true;
            storePlayers.Clear();
          }
        public void appendPlayers(TypePlayersJSON  to_append)
          {
            if (!flagHasPlayers)
              {
                flagHasPlayers = true;
                storePlayers.Clear();
              }
            Debug.Assert(flagHasPlayers);
            storePlayers.Add(to_append);
          }
        public void unsetPlayers()
          {
            if (flagHasPlayers)
              {
                for (int num4 = 0; num4 < storePlayers.Count; ++num4)
                  {
                  }
              }
            flagHasPlayers = false;
            storePlayers.Clear();
          }
        public void setTeamIndex(sbyte new_value)
          {
            flagHasTeamIndex = true;
            if (new_value < 0)
                throw new Exception("The value for field TeamIndex of TypeTeamsJSON is less than the lower bound (0) for that field.");
            if (new_value > 1)
                throw new Exception("The value for field TeamIndex of TypeTeamsJSON is greater than the upper bound (1) for that field.");
            storeTeamIndex = new_value;
          }
        public void unsetTeamIndex()
          {
            flagHasTeamIndex = false;
          }

        public virtual void extraTypeTeamsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeTeamsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeTeamsLookup(key);
            if (old_field == null)
              {
                extraTypeTeamsAppendPair(key, new_component);
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
            if (flagHasPlayers)
              {
                handler.start_pair("Players");
                handler.start_array();
                for (int num1 = 0; num1 < storePlayers.Count; ++num1)
                  {
                    if (partial_allowed)
                        storePlayers[num1].write_partial_as_json(handler);
                    else
                        storePlayers[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            Debug.Assert(partial_allowed || flagHasTeamIndex);
            if (flagHasTeamIndex)
              {
                handler.start_pair("TeamIndex");
                handler.number_value(storeTeamIndex);
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
            if (!(hasTeamIndex()))
              {
                return "When parsing the object for %what%, the \"TeamIndex\" field was missing.";
              }
            return null;
          }

        public static TypeTeamsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTeamsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
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
        public static TypeTeamsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTeamsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTeamsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
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
        public static TypeTeamsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTeamsJSON from_text(string text, bool ignore_extras)
          {
            TypeTeamsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeTeamsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeTeamsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeTeamsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private TypePlayersJSON.HoldingArrayGenerator fieldGeneratorPlayers;
        private class FieldHoldingGeneratorTeamIndex : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorTeamIndex(String what) : base(what, 0, 1)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorTeamIndex : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorTeamIndex(String what) : base(what, 0, 1)
                  {
                  }
              };
            private FieldHoldingGeneratorTeamIndex fieldGeneratorTeamIndex;
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
                TypeTeamsJSON result = new TypeTeamsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeTeamsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeTeamsJSON result)
              {
                if (fieldGeneratorPlayers.have_value)
                  {
                    result.initPlayers();
                    int count = fieldGeneratorPlayers.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendPlayers(fieldGeneratorPlayers.value[num]);
                      }
                    fieldGeneratorPlayers.value.Clear();
                    fieldGeneratorPlayers.have_value = false;
                  }
                if (fieldGeneratorTeamIndex.have_value)
                  {
                    result.setTeamIndex((sbyte)(fieldGeneratorTeamIndex.value));
                    fieldGeneratorTeamIndex.have_value = false;
                  }
                else if ((!(result.hasTeamIndex())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TeamIndex\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeTeamsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'P':
                        if ((String.Compare(field_name, 1, "layers", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorPlayers;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "eamIndex", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorTeamIndex;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorPlayers = new TypePlayersJSON.HoldingArrayGenerator("field \"Players\" of the TypeTeams class", ignore_extras);
                fieldGeneratorTeamIndex = new FieldHoldingGeneratorTeamIndex("field \"TeamIndex\" of the TypeTeams class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeTeams class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorPlayers = new TypePlayersJSON.HoldingArrayGenerator("field \"Players\" of the TypeTeams class", false);
                fieldGeneratorTeamIndex = new FieldHoldingGeneratorTeamIndex("field \"TeamIndex\" of the TypeTeams class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeTeams class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorPlayers.reset();
                fieldGeneratorTeamIndex.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorPlayers.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorPlayers.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeTeamsJSON  result)
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
            public TypeTeamsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeTeamsJSON  result)
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
        protected virtual void handle_result(List<TypeTeamsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeTeamsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeTeamsJSON>();
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
        public List<TypeTeamsJSON> value;
      };
      };
    private bool flagHasTeams;
    private List< TypeTeamsJSON  > storeTeams;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Teams of SportsGameStatisticsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Teams of SportsGameStatisticsJSON has too few elements.");
        List< TypeTeamsJSON  > vector_Teams1 = new List< TypeTeamsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeTeamsJSON convert_classy = TypeTeamsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Teams1.Add(convert_classy);
          }
        Debug.Assert(vector_Teams1.Count >= 2);
        initTeams();
        for (int num3 = 0; num3 < vector_Teams1.Count; ++num3)
            appendTeams(vector_Teams1[num3]);
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
          {
          }
      }


    public SportsGameStatisticsJSON()
      {
        flagHasTeams = false;
        storeTeams = new List< TypeTeamsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTeams()
      {
        return flagHasTeams;
      }

    public int  countOfTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams.Count;
      }

    public TypeTeamsJSON   elementOfTeams(int element_num)
      {
        Debug.Assert(flagHasTeams);
        return storeTeams[element_num];
      }

    public List< TypeTeamsJSON  >  getTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams;
      }


    public virtual int extraSportsGameStatisticsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsGameStatisticsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsGameStatisticsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsGameStatisticsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initTeams()
      {
        if (flagHasTeams)
          {
            for (int num5 = 0; num5 < storeTeams.Count; ++num5)
              {
              }
          }
        flagHasTeams = true;
        storeTeams.Clear();
      }
    public void appendTeams(TypeTeamsJSON  to_append)
      {
        if (!flagHasTeams)
          {
            flagHasTeams = true;
            storeTeams.Clear();
          }
        Debug.Assert(flagHasTeams);
        storeTeams.Add(to_append);
      }
    public void unsetTeams()
      {
        if (flagHasTeams)
          {
            for (int num6 = 0; num6 < storeTeams.Count; ++num6)
              {
              }
          }
        flagHasTeams = false;
        storeTeams.Clear();
      }

    public virtual void extraSportsGameStatisticsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsGameStatisticsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsGameStatisticsLookup(key);
        if (old_field == null)
          {
            extraSportsGameStatisticsAppendPair(key, new_component);
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
        if (flagHasTeams)
          {
            handler.start_pair("Teams");
            Debug.Assert(storeTeams.Count >= 2);
            handler.start_array();
            for (int num1 = 0; num1 < storeTeams.Count; ++num1)
              {
                if (partial_allowed)
                    storeTeams[num1].write_partial_as_json(handler);
                else
                    storeTeams[num1].write_as_json(handler);
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
        return null;
      }

    public static SportsGameStatisticsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsGameStatisticsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameStatistics", ignore_extras);
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
    public static SportsGameStatisticsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsGameStatisticsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsGameStatisticsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameStatistics", ignore_extras);
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
    public static SportsGameStatisticsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsGameStatisticsJSON from_text(string text, bool ignore_extras)
      {
        SportsGameStatisticsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameStatistics", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsGameStatisticsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsGameStatisticsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsGameStatisticsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameStatistics", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeTeamsJSON.HoldingArrayGenerator fieldGeneratorTeams;
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
            SportsGameStatisticsJSON result = new SportsGameStatisticsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsGameStatisticsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsGameStatisticsJSON result)
          {
            if (fieldGeneratorTeams.have_value)
              {
                result.initTeams();
                int count = fieldGeneratorTeams.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTeams(fieldGeneratorTeams.value[num]);
                  }
                fieldGeneratorTeams.value.Clear();
                fieldGeneratorTeams.have_value = false;
              }
          }
        protected abstract void handle_result(SportsGameStatisticsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Teams", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorTeams;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTeams = new TypeTeamsJSON.HoldingArrayGenerator("field \"Teams\" of the SportsGameStatistics class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsGameStatistics class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTeams = new TypeTeamsJSON.HoldingArrayGenerator("field \"Teams\" of the SportsGameStatistics class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsGameStatistics class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTeams.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTeams.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTeams.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsGameStatisticsJSON  result)
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
        public SportsGameStatisticsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsGameStatisticsJSON  result)
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
    protected virtual void handle_result(List<SportsGameStatisticsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsGameStatisticsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsGameStatisticsJSON>();
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
    public List<SportsGameStatisticsJSON> value;
  };
  };
