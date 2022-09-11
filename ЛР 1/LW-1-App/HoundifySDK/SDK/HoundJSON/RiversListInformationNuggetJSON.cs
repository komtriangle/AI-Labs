/* file "RiversListInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RiversListInformationNuggetJSON : InformationNuggetJSON
  {
    public class TypeSubqueriesJSON : JSONBase
      {
        private bool flagHasLocationKind;
        private RiverLocationKindJSON  storeLocationKind;
        private bool flagHasLocation;
        private MapLocationJSON  storeLocation;
        private bool flagHasFoundRiverCount;
        private BigInteger storeFoundRiverCount;
        private bool flagHasRivers;
        private List< RiverJSON  > storeRivers;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONLocationKind(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            RiverLocationKindJSON convert_classy = RiverLocationKindJSON.from_json(json_value, ignore_extras, true);
            setLocationKind(convert_classy);
          }


        private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
            setLocation(convert_classy);
          }


        private void  fromJSONFoundRiverCount(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field FoundRiverCount of TypeSubqueriesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field FoundRiverCount of TypeSubqueriesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setFoundRiverCount(extracted_integer);
          }


        private void  fromJSONRivers(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Rivers of TypeSubqueriesJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field Rivers of TypeSubqueriesJSON has too few elements.");
            List< RiverJSON  > vector_Rivers1 = new List< RiverJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                RiverJSON convert_classy = RiverJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Rivers1.Add(convert_classy);
              }
            Debug.Assert(vector_Rivers1.Count >= 1);
            initRivers();
            for (int num1 = 0; num1 < vector_Rivers1.Count; ++num1)
                appendRivers(vector_Rivers1[num1]);
            for (int num1 = 0; num1 < vector_Rivers1.Count; ++num1)
              {
              }
          }


        public TypeSubqueriesJSON()
          {
            flagHasLocationKind = false;
            flagHasLocation = false;
            flagHasFoundRiverCount = false;
            flagHasRivers = false;
            storeRivers = new List< RiverJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasLocationKind()
          {
            return flagHasLocationKind;
          }

        public RiverLocationKindJSON   getLocationKind()
          {
            Debug.Assert(flagHasLocationKind);
            return storeLocationKind;
          }

        public RiverLocationKindJSON.TypeValue  getLocationKindValue()
          {
            return getLocationKind().getValue();
          }

        public string  getLocationKindAsString()
          {
            return getLocationKind().getValueAsString();
          }

        public bool  hasLocation()
          {
            return flagHasLocation;
          }

        public MapLocationJSON   getLocation()
          {
            Debug.Assert(flagHasLocation);
            return storeLocation;
          }

        public bool  hasFoundRiverCount()
          {
            return flagHasFoundRiverCount;
          }

        public BigInteger  getFoundRiverCount()
          {
            Debug.Assert(flagHasFoundRiverCount);
            return storeFoundRiverCount;
          }

        public bool  hasRivers()
          {
            return flagHasRivers;
          }

        public int  countOfRivers()
          {
            Debug.Assert(flagHasRivers);
            return storeRivers.Count;
          }

        public RiverJSON   elementOfRivers(int element_num)
          {
            Debug.Assert(flagHasRivers);
            return storeRivers[element_num];
          }

        public List< RiverJSON  >  getRivers()
          {
            Debug.Assert(flagHasRivers);
            return storeRivers;
          }


        public virtual int extraTypeSubqueriesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSubqueriesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSubqueriesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSubqueriesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setLocationKind(RiverLocationKindJSON  new_value)
          {
            if (flagHasLocationKind)
              {
              }
            flagHasLocationKind = true;
            storeLocationKind = new_value;
          }
        public void setLocationKind(RiverLocationKindJSON.TypeValue new_value)
          {
            setLocationKind(new RiverLocationKindJSON(new_value));
          }
        public void setLocationKind(string chars)
          {
            setLocationKind(new RiverLocationKindJSON(chars));
          }
        public void unsetLocationKind()
          {
            if (flagHasLocationKind)
              {
              }
            flagHasLocationKind = false;
          }
        public void setLocation(MapLocationJSON  new_value)
          {
            if (flagHasLocation)
              {
              }
            flagHasLocation = true;
            storeLocation = new_value;
          }
        public void unsetLocation()
          {
            if (flagHasLocation)
              {
              }
            flagHasLocation = false;
          }
        public void setFoundRiverCount(BigInteger new_value)
          {
            flagHasFoundRiverCount = true;
            if (new_value < 0)
                throw new Exception("The value for field FoundRiverCount of TypeSubqueriesJSON is less than the lower bound (0) for that field.");
            storeFoundRiverCount = new_value;
          }
        public void unsetFoundRiverCount()
          {
            flagHasFoundRiverCount = false;
          }
        public void initRivers()
          {
            if (flagHasRivers)
              {
                for (int num1 = 0; num1 < storeRivers.Count; ++num1)
                  {
                  }
              }
            flagHasRivers = true;
            storeRivers.Clear();
          }
        public void appendRivers(RiverJSON  to_append)
          {
            if (!flagHasRivers)
              {
                flagHasRivers = true;
                storeRivers.Clear();
              }
            Debug.Assert(flagHasRivers);
            storeRivers.Add(to_append);
          }
        public void unsetRivers()
          {
            if (flagHasRivers)
              {
                for (int num2 = 0; num2 < storeRivers.Count; ++num2)
                  {
                  }
              }
            flagHasRivers = false;
            storeRivers.Clear();
          }

        public virtual void extraTypeSubqueriesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSubqueriesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSubqueriesLookup(key);
            if (old_field == null)
              {
                extraTypeSubqueriesAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasLocationKind);
            if (flagHasLocationKind)
              {
                handler.start_pair("LocationKind");
                if (partial_allowed)
                    storeLocationKind.write_partial_as_json(handler);
                else
                    storeLocationKind.write_as_json(handler);
              }
            if (flagHasLocation)
              {
                handler.start_pair("Location");
                if (partial_allowed)
                    storeLocation.write_partial_as_json(handler);
                else
                    storeLocation.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasFoundRiverCount);
            if (flagHasFoundRiverCount)
              {
                handler.start_pair("FoundRiverCount");
                handler.number_value(storeFoundRiverCount);
              }
            if (flagHasRivers)
              {
                handler.start_pair("Rivers");
                Debug.Assert(storeRivers.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeRivers.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeRivers[num1].write_partial_as_json(handler);
                    else
                        storeRivers[num1].write_as_json(handler);
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
            if (!(hasLocationKind()))
              {
                return "When parsing the object for %what%, the \"LocationKind\" field was missing.";
              }
            if (!(hasFoundRiverCount()))
              {
                return "When parsing the object for %what%, the \"FoundRiverCount\" field was missing.";
              }
            return null;
          }

        public static TypeSubqueriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSubqueriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSubqueries", ignore_extras);
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
        public static TypeSubqueriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSubqueriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSubqueriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSubqueries", ignore_extras);
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
        public static TypeSubqueriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSubqueriesJSON from_text(string text, bool ignore_extras)
          {
            TypeSubqueriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSubqueries", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSubqueriesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSubqueriesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSubqueriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSubqueries", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private RiverLocationKindJSON.HoldingGenerator fieldGeneratorLocationKind;
            private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
        private class FieldHoldingGeneratorFoundRiverCount : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorFoundRiverCount(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorFoundRiverCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorFoundRiverCount(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorFoundRiverCount fieldGeneratorFoundRiverCount;
            private RiverJSON.HoldingArrayGenerator fieldGeneratorRivers;
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
                TypeSubqueriesJSON result = new TypeSubqueriesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSubqueriesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSubqueriesJSON result)
              {
                if (fieldGeneratorLocationKind.have_value)
                  {
                    result.setLocationKind(fieldGeneratorLocationKind.value);
                    fieldGeneratorLocationKind.have_value = false;
                  }
                else if ((!(result.hasLocationKind())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"LocationKind\" field was missing.");
                  }
                if (fieldGeneratorLocation.have_value)
                  {
                    result.setLocation(fieldGeneratorLocation.value);
                    fieldGeneratorLocation.have_value = false;
                  }
                if (fieldGeneratorFoundRiverCount.have_value)
                  {
                    result.setFoundRiverCount(fieldGeneratorFoundRiverCount.value);
                    fieldGeneratorFoundRiverCount.have_value = false;
                  }
                else if ((!(result.hasFoundRiverCount())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"FoundRiverCount\" field was missing.");
                  }
                if (fieldGeneratorRivers.have_value)
                  {
                    result.initRivers();
                    int count = fieldGeneratorRivers.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendRivers(fieldGeneratorRivers.value[num]);
                      }
                    fieldGeneratorRivers.value.Clear();
                    fieldGeneratorRivers.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeSubqueriesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'F':
                        if ((String.Compare(field_name, 1, "oundRiverCount", 0, 14, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorFoundRiverCount;
                        break;
                    case 'L':
                        if (String.Compare(field_name, 1, "ocation", 0, 7, false) == 0)
                          {
                            if (field_name.Length == 8)
                              {
                                return fieldGeneratorLocation;
                              }
                            switch (field_name[8])
                              {
                                case 'K':
                                    if ((String.Compare(field_name, 9, "ind", 0, 3, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorLocationKind;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "ivers", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorRivers;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorLocationKind = new RiverLocationKindJSON.HoldingGenerator("field \"LocationKind\" of the TypeSubqueries class", ignore_extras);
                fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the TypeSubqueries class", ignore_extras);
                fieldGeneratorFoundRiverCount = new FieldHoldingGeneratorFoundRiverCount("field \"FoundRiverCount\" of the TypeSubqueries class");
                fieldGeneratorRivers = new RiverJSON.HoldingArrayGenerator("field \"Rivers\" of the TypeSubqueries class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSubqueries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLocationKind = new RiverLocationKindJSON.HoldingGenerator("field \"LocationKind\" of the TypeSubqueries class", false);
                fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the TypeSubqueries class", false);
                fieldGeneratorFoundRiverCount = new FieldHoldingGeneratorFoundRiverCount("field \"FoundRiverCount\" of the TypeSubqueries class");
                fieldGeneratorRivers = new RiverJSON.HoldingArrayGenerator("field \"Rivers\" of the TypeSubqueries class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSubqueries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLocationKind.reset();
                fieldGeneratorLocation.reset();
                fieldGeneratorFoundRiverCount.reset();
                fieldGeneratorRivers.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorLocationKind.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorLocation.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorRivers.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorLocationKind.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorLocation.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorRivers.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeSubqueriesJSON  result)
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
            public TypeSubqueriesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSubqueriesJSON  result)
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
        protected virtual void handle_result(List<TypeSubqueriesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSubqueriesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSubqueriesJSON>();
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
        public List<TypeSubqueriesJSON> value;
      };
      };
    private bool flagHasSubqueries;
    private List< TypeSubqueriesJSON  > storeSubqueries;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSubqueriesToJSON()
      {
        JSONArrayValue generated_array_1_Subqueries = new JSONArrayValue();
        for (int num1 = 0; num1 < storeSubqueries.Count; ++num1)
          {
            JSONValueHandler handler_Subqueries = new JSONValueHandler();
            storeSubqueries[num1].write_as_json(handler_Subqueries);
            generated_array_1_Subqueries.appendComponent(handler_Subqueries.result);
          }
        return generated_array_1_Subqueries;
      }


    private void  fromJSONSubqueries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Subqueries of RiversListInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Subqueries of RiversListInformationNuggetJSON has too few elements.");
        List< TypeSubqueriesJSON  > vector_Subqueries1 = new List< TypeSubqueriesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeSubqueriesJSON convert_classy = TypeSubqueriesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Subqueries1.Add(convert_classy);
          }
        Debug.Assert(vector_Subqueries1.Count >= 1);
        initSubqueries();
        for (int num2 = 0; num2 < vector_Subqueries1.Count; ++num2)
            appendSubqueries(vector_Subqueries1[num2]);
        for (int num1 = 0; num1 < vector_Subqueries1.Count; ++num1)
          {
          }
      }


    public RiversListInformationNuggetJSON()
      {
        flagHasSubqueries = false;
        storeSubqueries = new List< TypeSubqueriesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "RiversListInformationNugget";
      }

    public bool  hasSubqueries()
      {
        return flagHasSubqueries;
      }

    public int  countOfSubqueries()
      {
        Debug.Assert(flagHasSubqueries);
        return storeSubqueries.Count;
      }

    public TypeSubqueriesJSON   elementOfSubqueries(int element_num)
      {
        Debug.Assert(flagHasSubqueries);
        return storeSubqueries[element_num];
      }

    public List< TypeSubqueriesJSON  >  getSubqueries()
      {
        Debug.Assert(flagHasSubqueries);
        return storeSubqueries;
      }


    public virtual int extraRiversListInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRiversListInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRiversListInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRiversListInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasSubqueries)
            ++result;
        result += extraRiversListInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSubqueries)
          {
            if (remainder == 0)
                return "Subqueries";
            --remainder;
          }
        return extraRiversListInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSubqueries)
          {
            if (remainder == 0)
                return extraSubqueriesToJSON();
            --remainder;
          }
        return extraRiversListInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Subqueries", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasSubqueries ? extraSubqueriesToJSON() : null);
        return extraRiversListInformationNuggetLookup(field_name);
      }

    public void initSubqueries()
      {
        if (flagHasSubqueries)
          {
            for (int num3 = 0; num3 < storeSubqueries.Count; ++num3)
              {
              }
          }
        flagHasSubqueries = true;
        storeSubqueries.Clear();
      }
    public void appendSubqueries(TypeSubqueriesJSON  to_append)
      {
        if (!flagHasSubqueries)
          {
            flagHasSubqueries = true;
            storeSubqueries.Clear();
          }
        Debug.Assert(flagHasSubqueries);
        storeSubqueries.Add(to_append);
      }
    public void unsetSubqueries()
      {
        if (flagHasSubqueries)
          {
            for (int num4 = 0; num4 < storeSubqueries.Count; ++num4)
              {
              }
          }
        flagHasSubqueries = false;
        storeSubqueries.Clear();
      }

    public virtual void extraRiversListInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRiversListInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRiversListInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraRiversListInformationNuggetAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "Subqueries", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONSubqueries(new_component, false);
            return;
            }
        extraRiversListInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Subqueries", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONSubqueries(new_component, false);
            return;
            }
        extraRiversListInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSubqueries);
        if (flagHasSubqueries)
          {
            handler.start_pair("Subqueries");
            Debug.Assert(storeSubqueries.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeSubqueries.Count; ++num1)
              {
                if (partial_allowed)
                    storeSubqueries[num1].write_partial_as_json(handler);
                else
                    storeSubqueries[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasSubqueries()))
          {
            return "When parsing the object for %what%, the \"Subqueries\" field was missing.";
          }
        return null;
      }

    public static new RiversListInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiversListInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversListInformationNugget", ignore_extras);
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
    public static new RiversListInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RiversListInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiversListInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversListInformationNugget", ignore_extras);
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
    public static new RiversListInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RiversListInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        RiversListInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversListInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RiversListInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RiversListInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RiversListInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversListInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private TypeSubqueriesJSON.HoldingArrayGenerator fieldGeneratorSubqueries;
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
            if (!(getInformationNuggetJSONKey().Equals("RiversListInformationNugget")))
                throw new Exception("The key field has a value other than `RiversListInformationNugget'.");
            RiversListInformationNuggetJSON result = new RiversListInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRiversListInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((RiversListInformationNuggetJSON )new_result);
          }
        protected void finish(RiversListInformationNuggetJSON result)
          {
            if (fieldGeneratorSubqueries.have_value)
              {
                result.initSubqueries();
                int count = fieldGeneratorSubqueries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSubqueries(fieldGeneratorSubqueries.value[num]);
                  }
                fieldGeneratorSubqueries.value.Clear();
                fieldGeneratorSubqueries.have_value = false;
              }
            else if ((!(result.hasSubqueries())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Subqueries\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RiversListInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Subqueries", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorSubqueries;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSubqueries = new TypeSubqueriesJSON.HoldingArrayGenerator("field \"Subqueries\" of the RiversListInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RiversListInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSubqueries = new TypeSubqueriesJSON.HoldingArrayGenerator("field \"Subqueries\" of the RiversListInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RiversListInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorSubqueries.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RiversListInformationNuggetJSON  result)
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
        public RiversListInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RiversListInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<RiversListInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RiversListInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RiversListInformationNuggetJSON>();
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
    public List<RiversListInformationNuggetJSON> value;
  };
  };
