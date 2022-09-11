/* file "RiversQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RiversQueryStateJSON : JSONBase
  {
    public enum TypeQueryTypeKnownValues
      {
        QueryType_RiversInfo,
        QueryType_RiversByLocation,
        QueryType_RiversList,
        QueryType__none
      };
    public struct TypeQueryType
      {
        public bool in_known_list;
        public string string_value;
        public TypeQueryTypeKnownValues list_value;
      };

    public static TypeQueryTypeKnownValues  stringToQueryType(string chars)
      {
        if (String.Compare(chars, 0, "Rivers", 0, 6, false) == 0)
          {
            switch (chars[6])
              {
                case 'B':
                    if ((String.Compare(chars, 7, "yLocation", 0, 9, false) == 0) && (chars.Length == 16))
                        return TypeQueryTypeKnownValues.QueryType_RiversByLocation;
                    break;
                case 'I':
                    if ((String.Compare(chars, 7, "nfo", 0, 3, false) == 0) && (chars.Length == 10))
                        return TypeQueryTypeKnownValues.QueryType_RiversInfo;
                    break;
                case 'L':
                    if ((String.Compare(chars, 7, "ist", 0, 3, false) == 0) && (chars.Length == 10))
                        return TypeQueryTypeKnownValues.QueryType_RiversList;
                    break;
                default:
                    break;
              }
          }
        return TypeQueryTypeKnownValues.QueryType__none;
      }

    public static string  stringFromQueryType(TypeQueryTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeQueryTypeKnownValues.QueryType_RiversInfo:
                return "RiversInfo";
            case TypeQueryTypeKnownValues.QueryType_RiversByLocation:
                return "RiversByLocation";
            case TypeQueryTypeKnownValues.QueryType_RiversList:
                return "RiversList";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeCriterion
      {
        Criterion_Length,
        Criterion_Discharge
      };

    public static TypeCriterion  stringToCriterion(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if ((String.Compare(chars, 1, "ischarge", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeCriterion.Criterion_Discharge;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ength", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeCriterion.Criterion_Length;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Criterion' is not one of the legal values.");
      }

    public static string  stringFromCriterion(TypeCriterion the_enum)
      {
        switch (the_enum)
          {
            case TypeCriterion.Criterion_Length:
                return "Length";
            case TypeCriterion.Criterion_Discharge:
                return "Discharge";
            default:
                Debug.Assert(false);
                return null;
          }
      }

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
    private bool flagHasQueryType;
    private TypeQueryType storeQueryType;
    private bool flagHasRivers;
    private List< RiverJSON  > storeRivers;
    private bool flagHasRequestLength;
    private bool storeRequestLength;
    private bool flagHasRequestDischarge;
    private bool storeRequestDischarge;
    private bool flagHasRequestDischargeIfPresent;
    private bool storeRequestDischargeIfPresent;
    private bool flagHasRequestCities;
    private bool storeRequestCities;
    private bool flagHasRequestCitiesIfPresent;
    private bool storeRequestCitiesIfPresent;
    private bool flagHasRequestUsStates;
    private bool storeRequestUsStates;
    private bool flagHasRequestUsStatesIfPresent;
    private bool storeRequestUsStatesIfPresent;
    private bool flagHasRequestCountries;
    private bool storeRequestCountries;
    private bool flagHasRequestContinents;
    private bool storeRequestContinents;
    private bool flagHasRequestedCount;
    private BigInteger storeRequestedCount;
    private bool flagHasOnlyLast;
    private bool storeOnlyLast;
    private bool flagHasCriterion;
    private TypeCriterion storeCriterion;
    private bool flagHasUseImperialUnits;
    private bool storeUseImperialUnits;
    private bool flagHasSubqueries;
    private List< TypeSubqueriesJSON  > storeSubqueries;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryType of RiversQueryStateJSON is not a string.");
        TypeQueryType the_open_enum = new TypeQueryType();
        if (String.Compare(json_string.getData(), 0, "Rivers", 0, 6, false) == 0)
          {
            switch (json_string.getData()[6])
              {
                case 'B':
                    if ((String.Compare(json_string.getData(), 7, "yLocation", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_RiversByLocation;
                            goto open_enum_is_done;
                          }
                    break;
                case 'I':
                    if ((String.Compare(json_string.getData(), 7, "nfo", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_RiversInfo;
                            goto open_enum_is_done;
                          }
                    break;
                case 'L':
                    if ((String.Compare(json_string.getData(), 7, "ist", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_RiversList;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setQueryType(the_open_enum);
      }


    private void  fromJSONRivers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Rivers of RiversQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Rivers of RiversQueryStateJSON has too few elements.");
        List< RiverJSON  > vector_Rivers1 = new List< RiverJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RiverJSON convert_classy = RiverJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Rivers1.Add(convert_classy);
          }
        Debug.Assert(vector_Rivers1.Count >= 1);
        initRivers();
        for (int num2 = 0; num2 < vector_Rivers1.Count; ++num2)
            appendRivers(vector_Rivers1[num2]);
        for (int num1 = 0; num1 < vector_Rivers1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestLength(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestLength of RiversQueryStateJSON is not true for false.");
              }
          }
        setRequestLength(the_bool);
      }


    private void  fromJSONRequestDischarge(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestDischarge of RiversQueryStateJSON is not true for false.");
              }
          }
        setRequestDischarge(the_bool);
      }


    private void  fromJSONRequestDischargeIfPresent(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestDischargeIfPresent of RiversQueryStateJSON is not true for false.");
              }
          }
        setRequestDischargeIfPresent(the_bool);
      }


    private void  fromJSONRequestCities(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestCities of RiversQueryStateJSON is not true for false.");
              }
          }
        setRequestCities(the_bool);
      }


    private void  fromJSONRequestCitiesIfPresent(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestCitiesIfPresent of RiversQueryStateJSON is not true for false.");
              }
          }
        setRequestCitiesIfPresent(the_bool);
      }


    private void  fromJSONRequestUsStates(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestUsStates of RiversQueryStateJSON is not true for false.");
              }
          }
        setRequestUsStates(the_bool);
      }


    private void  fromJSONRequestUsStatesIfPresent(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestUsStatesIfPresent of RiversQueryStateJSON is not true for false.");
              }
          }
        setRequestUsStatesIfPresent(the_bool);
      }


    private void  fromJSONRequestCountries(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestCountries of RiversQueryStateJSON is not true for false.");
              }
          }
        setRequestCountries(the_bool);
      }


    private void  fromJSONRequestContinents(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestContinents of RiversQueryStateJSON is not true for false.");
              }
          }
        setRequestContinents(the_bool);
      }


    private void  fromJSONRequestedCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RequestedCount of RiversQueryStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RequestedCount of RiversQueryStateJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRequestedCount(extracted_integer);
      }


    private void  fromJSONOnlyLast(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OnlyLast of RiversQueryStateJSON is not true for false.");
              }
          }
        setOnlyLast(the_bool);
      }


    private void  fromJSONCriterion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Criterion of RiversQueryStateJSON is not a string.");
        TypeCriterion the_enum;
        switch (json_string.getData()[0])
          {
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ischarge", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeCriterion.Criterion_Discharge;
                        goto enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ength", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeCriterion.Criterion_Length;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Criterion of RiversQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setCriterion(the_enum);
      }


    private void  fromJSONUseImperialUnits(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UseImperialUnits of RiversQueryStateJSON is not true for false.");
              }
          }
        setUseImperialUnits(the_bool);
      }


    private void  fromJSONSubqueries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Subqueries of RiversQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Subqueries of RiversQueryStateJSON has too few elements.");
        List< TypeSubqueriesJSON  > vector_Subqueries1 = new List< TypeSubqueriesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeSubqueriesJSON convert_classy = TypeSubqueriesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Subqueries1.Add(convert_classy);
          }
        Debug.Assert(vector_Subqueries1.Count >= 1);
        initSubqueries();
        for (int num3 = 0; num3 < vector_Subqueries1.Count; ++num3)
            appendSubqueries(vector_Subqueries1[num3]);
        for (int num1 = 0; num1 < vector_Subqueries1.Count; ++num1)
          {
          }
      }


    public RiversQueryStateJSON()
      {
        flagHasQueryType = false;
        flagHasRivers = false;
        flagHasRequestLength = false;
        flagHasRequestDischarge = false;
        flagHasRequestDischargeIfPresent = false;
        flagHasRequestCities = false;
        flagHasRequestCitiesIfPresent = false;
        flagHasRequestUsStates = false;
        flagHasRequestUsStatesIfPresent = false;
        flagHasRequestCountries = false;
        flagHasRequestContinents = false;
        flagHasRequestedCount = false;
        flagHasOnlyLast = false;
        flagHasCriterion = false;
        flagHasUseImperialUnits = false;
        flagHasSubqueries = false;
        storeRivers = new List< RiverJSON  >();
        storeSubqueries = new List< TypeSubqueriesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQueryType()
      {
        return flagHasQueryType;
      }

    public TypeQueryType  getQueryType()
      {
        Debug.Assert(flagHasQueryType);
        return storeQueryType;
      }

    public string  getQueryTypeAsString()
      {
        TypeQueryType result = getQueryType();
        if (result.in_known_list)
            return stringFromQueryType(result.list_value);
        else
            return result.string_value;
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

    public bool  hasRequestLength()
      {
        return flagHasRequestLength;
      }

    public bool  getRequestLength()
      {
        Debug.Assert(flagHasRequestLength);
        return storeRequestLength;
      }

    public bool  hasRequestDischarge()
      {
        return flagHasRequestDischarge;
      }

    public bool  getRequestDischarge()
      {
        Debug.Assert(flagHasRequestDischarge);
        return storeRequestDischarge;
      }

    public bool  hasRequestDischargeIfPresent()
      {
        return flagHasRequestDischargeIfPresent;
      }

    public bool  getRequestDischargeIfPresent()
      {
        Debug.Assert(flagHasRequestDischargeIfPresent);
        return storeRequestDischargeIfPresent;
      }

    public bool  hasRequestCities()
      {
        return flagHasRequestCities;
      }

    public bool  getRequestCities()
      {
        Debug.Assert(flagHasRequestCities);
        return storeRequestCities;
      }

    public bool  hasRequestCitiesIfPresent()
      {
        return flagHasRequestCitiesIfPresent;
      }

    public bool  getRequestCitiesIfPresent()
      {
        Debug.Assert(flagHasRequestCitiesIfPresent);
        return storeRequestCitiesIfPresent;
      }

    public bool  hasRequestUsStates()
      {
        return flagHasRequestUsStates;
      }

    public bool  getRequestUsStates()
      {
        Debug.Assert(flagHasRequestUsStates);
        return storeRequestUsStates;
      }

    public bool  hasRequestUsStatesIfPresent()
      {
        return flagHasRequestUsStatesIfPresent;
      }

    public bool  getRequestUsStatesIfPresent()
      {
        Debug.Assert(flagHasRequestUsStatesIfPresent);
        return storeRequestUsStatesIfPresent;
      }

    public bool  hasRequestCountries()
      {
        return flagHasRequestCountries;
      }

    public bool  getRequestCountries()
      {
        Debug.Assert(flagHasRequestCountries);
        return storeRequestCountries;
      }

    public bool  hasRequestContinents()
      {
        return flagHasRequestContinents;
      }

    public bool  getRequestContinents()
      {
        Debug.Assert(flagHasRequestContinents);
        return storeRequestContinents;
      }

    public bool  hasRequestedCount()
      {
        return flagHasRequestedCount;
      }

    public BigInteger  getRequestedCount()
      {
        Debug.Assert(flagHasRequestedCount);
        return storeRequestedCount;
      }

    public bool  hasOnlyLast()
      {
        return flagHasOnlyLast;
      }

    public bool  getOnlyLast()
      {
        Debug.Assert(flagHasOnlyLast);
        return storeOnlyLast;
      }

    public bool  hasCriterion()
      {
        return flagHasCriterion;
      }

    public TypeCriterion  getCriterion()
      {
        Debug.Assert(flagHasCriterion);
        return storeCriterion;
      }

    public string  getCriterionAsString()
      {
        return stringFromCriterion(getCriterion());
      }

    public bool  hasUseImperialUnits()
      {
        return flagHasUseImperialUnits;
      }

    public bool  getUseImperialUnits()
      {
        Debug.Assert(flagHasUseImperialUnits);
        return storeUseImperialUnits;
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


    public virtual int extraRiversQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRiversQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRiversQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRiversQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQueryType(TypeQueryType new_value)
      {
        flagHasQueryType = true;
        storeQueryType = new_value;
      }
    public void setQueryType(string chars)
      {
        TypeQueryTypeKnownValues known = stringToQueryType(chars);
        TypeQueryType new_value = new TypeQueryType();
        if (known == TypeQueryTypeKnownValues.QueryType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQueryType(new_value);
      }
    public void setQueryType(TypeQueryTypeKnownValues new_value)
      {
        TypeQueryType new_full_value = new TypeQueryType();
        Debug.Assert(new_value != TypeQueryTypeKnownValues.QueryType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setQueryType(new_full_value);
      }
    public void unsetQueryType()
      {
        flagHasQueryType = false;
      }
    public void initRivers()
      {
        if (flagHasRivers)
          {
            for (int num3 = 0; num3 < storeRivers.Count; ++num3)
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
            for (int num4 = 0; num4 < storeRivers.Count; ++num4)
              {
              }
          }
        flagHasRivers = false;
        storeRivers.Clear();
      }
    public void setRequestLength(bool new_value)
      {
        flagHasRequestLength = true;
        storeRequestLength = new_value;
      }
    public void unsetRequestLength()
      {
        flagHasRequestLength = false;
      }
    public void setRequestDischarge(bool new_value)
      {
        flagHasRequestDischarge = true;
        storeRequestDischarge = new_value;
      }
    public void unsetRequestDischarge()
      {
        flagHasRequestDischarge = false;
      }
    public void setRequestDischargeIfPresent(bool new_value)
      {
        flagHasRequestDischargeIfPresent = true;
        storeRequestDischargeIfPresent = new_value;
      }
    public void unsetRequestDischargeIfPresent()
      {
        flagHasRequestDischargeIfPresent = false;
      }
    public void setRequestCities(bool new_value)
      {
        flagHasRequestCities = true;
        storeRequestCities = new_value;
      }
    public void unsetRequestCities()
      {
        flagHasRequestCities = false;
      }
    public void setRequestCitiesIfPresent(bool new_value)
      {
        flagHasRequestCitiesIfPresent = true;
        storeRequestCitiesIfPresent = new_value;
      }
    public void unsetRequestCitiesIfPresent()
      {
        flagHasRequestCitiesIfPresent = false;
      }
    public void setRequestUsStates(bool new_value)
      {
        flagHasRequestUsStates = true;
        storeRequestUsStates = new_value;
      }
    public void unsetRequestUsStates()
      {
        flagHasRequestUsStates = false;
      }
    public void setRequestUsStatesIfPresent(bool new_value)
      {
        flagHasRequestUsStatesIfPresent = true;
        storeRequestUsStatesIfPresent = new_value;
      }
    public void unsetRequestUsStatesIfPresent()
      {
        flagHasRequestUsStatesIfPresent = false;
      }
    public void setRequestCountries(bool new_value)
      {
        flagHasRequestCountries = true;
        storeRequestCountries = new_value;
      }
    public void unsetRequestCountries()
      {
        flagHasRequestCountries = false;
      }
    public void setRequestContinents(bool new_value)
      {
        flagHasRequestContinents = true;
        storeRequestContinents = new_value;
      }
    public void unsetRequestContinents()
      {
        flagHasRequestContinents = false;
      }
    public void setRequestedCount(BigInteger new_value)
      {
        flagHasRequestedCount = true;
        if (new_value < 1)
            throw new Exception("The value for field RequestedCount of RiversQueryStateJSON is less than the lower bound (1) for that field.");
        storeRequestedCount = new_value;
      }
    public void unsetRequestedCount()
      {
        flagHasRequestedCount = false;
      }
    public void setOnlyLast(bool new_value)
      {
        flagHasOnlyLast = true;
        storeOnlyLast = new_value;
      }
    public void unsetOnlyLast()
      {
        flagHasOnlyLast = false;
      }
    public void setCriterion(TypeCriterion new_value)
      {
        flagHasCriterion = true;
        storeCriterion = new_value;
      }
    public void setCriterion(string chars)
      {
        setCriterion(stringToCriterion(chars));
      }
    public void unsetCriterion()
      {
        flagHasCriterion = false;
      }
    public void setUseImperialUnits(bool new_value)
      {
        flagHasUseImperialUnits = true;
        storeUseImperialUnits = new_value;
      }
    public void unsetUseImperialUnits()
      {
        flagHasUseImperialUnits = false;
      }
    public void initSubqueries()
      {
        if (flagHasSubqueries)
          {
            for (int num5 = 0; num5 < storeSubqueries.Count; ++num5)
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
            for (int num6 = 0; num6 < storeSubqueries.Count; ++num6)
              {
              }
          }
        flagHasSubqueries = false;
        storeSubqueries.Clear();
      }

    public virtual void extraRiversQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRiversQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRiversQueryStateLookup(key);
        if (old_field == null)
          {
            extraRiversQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryType);
        if (flagHasQueryType)
          {
            handler.start_pair("QueryType");
            if (storeQueryType.in_known_list)
              {
                switch (storeQueryType.list_value)
                  {
                    case TypeQueryTypeKnownValues.QueryType_RiversInfo:
                        handler.string_value("RiversInfo");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_RiversByLocation:
                        handler.string_value("RiversByLocation");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_RiversList:
                        handler.string_value("RiversList");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeQueryType.string_value);
              }
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
        if (flagHasRequestLength)
          {
            handler.start_pair("RequestLength");
            handler.boolean_value(storeRequestLength);
          }
        if (flagHasRequestDischarge)
          {
            handler.start_pair("RequestDischarge");
            handler.boolean_value(storeRequestDischarge);
          }
        if (flagHasRequestDischargeIfPresent)
          {
            handler.start_pair("RequestDischargeIfPresent");
            handler.boolean_value(storeRequestDischargeIfPresent);
          }
        if (flagHasRequestCities)
          {
            handler.start_pair("RequestCities");
            handler.boolean_value(storeRequestCities);
          }
        if (flagHasRequestCitiesIfPresent)
          {
            handler.start_pair("RequestCitiesIfPresent");
            handler.boolean_value(storeRequestCitiesIfPresent);
          }
        if (flagHasRequestUsStates)
          {
            handler.start_pair("RequestUsStates");
            handler.boolean_value(storeRequestUsStates);
          }
        if (flagHasRequestUsStatesIfPresent)
          {
            handler.start_pair("RequestUsStatesIfPresent");
            handler.boolean_value(storeRequestUsStatesIfPresent);
          }
        if (flagHasRequestCountries)
          {
            handler.start_pair("RequestCountries");
            handler.boolean_value(storeRequestCountries);
          }
        if (flagHasRequestContinents)
          {
            handler.start_pair("RequestContinents");
            handler.boolean_value(storeRequestContinents);
          }
        if (flagHasRequestedCount)
          {
            handler.start_pair("RequestedCount");
            handler.number_value(storeRequestedCount);
          }
        if (flagHasOnlyLast)
          {
            handler.start_pair("OnlyLast");
            handler.boolean_value(storeOnlyLast);
          }
        if (flagHasCriterion)
          {
            handler.start_pair("Criterion");
            switch (storeCriterion)
              {
                case TypeCriterion.Criterion_Length:
                    handler.string_value("Length");
                    break;
                case TypeCriterion.Criterion_Discharge:
                    handler.string_value("Discharge");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasUseImperialUnits)
          {
            handler.start_pair("UseImperialUnits");
            handler.boolean_value(storeUseImperialUnits);
          }
        if (flagHasSubqueries)
          {
            handler.start_pair("Subqueries");
            Debug.Assert(storeSubqueries.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeSubqueries.Count; ++num2)
              {
                if (partial_allowed)
                    storeSubqueries[num2].write_partial_as_json(handler);
                else
                    storeSubqueries[num2].write_as_json(handler);
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
        if (!(hasQueryType()))
          {
            return "When parsing the object for %what%, the \"QueryType\" field was missing.";
          }
        return null;
      }

    public static RiversQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiversQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversQueryState", ignore_extras);
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
    public static RiversQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RiversQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiversQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversQueryState", ignore_extras);
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
    public static RiversQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RiversQueryStateJSON from_text(string text, bool ignore_extras)
      {
        RiversQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RiversQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RiversQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RiversQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorQueryType : JSONStringGenerator
          {
            protected FieldGeneratorQueryType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQueryType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeQueryTypeKnownValues known = stringToQueryType(result);
                TypeQueryType new_value = new TypeQueryType();
                if (known == TypeQueryTypeKnownValues.QueryType__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeQueryType result);
          };
    private class FieldHoldingGeneratorQueryType : FieldGeneratorQueryType
  {
    protected override void handle_result(TypeQueryType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQueryType(String what)
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
    public TypeQueryType value;
  };
    private class FieldHoldingArrayGeneratorQueryType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQueryType
      {
        private FieldHoldingArrayGeneratorQueryType top;

        protected override void handle_result(TypeQueryType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQueryType init_top)
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
    protected virtual void handle_result(List<TypeQueryType> result)
      {
      }

    public FieldHoldingArrayGeneratorQueryType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQueryType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQueryType> value;
  };
        private FieldHoldingGeneratorQueryType fieldGeneratorQueryType;
        private RiverJSON.HoldingArrayGenerator fieldGeneratorRivers;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestLength;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestDischarge;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestDischargeIfPresent;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestCities;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestCitiesIfPresent;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestUsStates;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestUsStatesIfPresent;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestCountries;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestContinents;
    private class FieldHoldingGeneratorRequestedCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRequestedCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRequestedCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRequestedCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorRequestedCount fieldGeneratorRequestedCount;
        private JSONHoldingBooleanGenerator fieldGeneratorOnlyLast;
    private abstract class FieldGeneratorCriterion : JSONStringGenerator
          {
            protected FieldGeneratorCriterion(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCriterion()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCriterion(result));
              }
            protected abstract void handle_result(TypeCriterion result);
          };
    private class FieldHoldingGeneratorCriterion : FieldGeneratorCriterion
  {
    protected override void handle_result(TypeCriterion result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCriterion(String what)
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
    public TypeCriterion value;
  };
    private class FieldHoldingArrayGeneratorCriterion : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCriterion
      {
        private FieldHoldingArrayGeneratorCriterion top;

        protected override void handle_result(TypeCriterion result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCriterion init_top)
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
    protected virtual void handle_result(List<TypeCriterion> result)
      {
      }

    public FieldHoldingArrayGeneratorCriterion(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCriterion>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCriterion()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCriterion>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCriterion> value;
  };
        private FieldHoldingGeneratorCriterion fieldGeneratorCriterion;
        private JSONHoldingBooleanGenerator fieldGeneratorUseImperialUnits;
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
            RiversQueryStateJSON result = new RiversQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRiversQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RiversQueryStateJSON result)
          {
            if (fieldGeneratorQueryType.have_value)
              {
                result.setQueryType(fieldGeneratorQueryType.value);
                fieldGeneratorQueryType.have_value = false;
              }
            else if ((!(result.hasQueryType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryType\" field was missing.");
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
            if (fieldGeneratorRequestLength.have_value)
              {
                result.setRequestLength(fieldGeneratorRequestLength.value);
                fieldGeneratorRequestLength.have_value = false;
              }
            if (fieldGeneratorRequestDischarge.have_value)
              {
                result.setRequestDischarge(fieldGeneratorRequestDischarge.value);
                fieldGeneratorRequestDischarge.have_value = false;
              }
            if (fieldGeneratorRequestDischargeIfPresent.have_value)
              {
                result.setRequestDischargeIfPresent(fieldGeneratorRequestDischargeIfPresent.value);
                fieldGeneratorRequestDischargeIfPresent.have_value = false;
              }
            if (fieldGeneratorRequestCities.have_value)
              {
                result.setRequestCities(fieldGeneratorRequestCities.value);
                fieldGeneratorRequestCities.have_value = false;
              }
            if (fieldGeneratorRequestCitiesIfPresent.have_value)
              {
                result.setRequestCitiesIfPresent(fieldGeneratorRequestCitiesIfPresent.value);
                fieldGeneratorRequestCitiesIfPresent.have_value = false;
              }
            if (fieldGeneratorRequestUsStates.have_value)
              {
                result.setRequestUsStates(fieldGeneratorRequestUsStates.value);
                fieldGeneratorRequestUsStates.have_value = false;
              }
            if (fieldGeneratorRequestUsStatesIfPresent.have_value)
              {
                result.setRequestUsStatesIfPresent(fieldGeneratorRequestUsStatesIfPresent.value);
                fieldGeneratorRequestUsStatesIfPresent.have_value = false;
              }
            if (fieldGeneratorRequestCountries.have_value)
              {
                result.setRequestCountries(fieldGeneratorRequestCountries.value);
                fieldGeneratorRequestCountries.have_value = false;
              }
            if (fieldGeneratorRequestContinents.have_value)
              {
                result.setRequestContinents(fieldGeneratorRequestContinents.value);
                fieldGeneratorRequestContinents.have_value = false;
              }
            if (fieldGeneratorRequestedCount.have_value)
              {
                result.setRequestedCount(fieldGeneratorRequestedCount.value);
                fieldGeneratorRequestedCount.have_value = false;
              }
            if (fieldGeneratorOnlyLast.have_value)
              {
                result.setOnlyLast(fieldGeneratorOnlyLast.value);
                fieldGeneratorOnlyLast.have_value = false;
              }
            if (fieldGeneratorCriterion.have_value)
              {
                result.setCriterion(fieldGeneratorCriterion.value);
                fieldGeneratorCriterion.have_value = false;
              }
            if (fieldGeneratorUseImperialUnits.have_value)
              {
                result.setUseImperialUnits(fieldGeneratorUseImperialUnits.value);
                fieldGeneratorUseImperialUnits.have_value = false;
              }
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
          }
        protected abstract void handle_result(RiversQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "riterion", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorCriterion;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "nlyLast", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorOnlyLast;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryType;
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'e':
                            if (String.Compare(field_name, 2, "quest", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'C':
                                        switch (field_name[8])
                                          {
                                            case 'i':
                                                if (String.Compare(field_name, 9, "ties", 0, 4, false) == 0)
                                                  {
                                                    if (field_name.Length == 13)
                                                      {
                                                        return fieldGeneratorRequestCities;
                                                      }
                                                    switch (field_name[13])
                                                      {
                                                        case 'I':
                                                            if ((String.Compare(field_name, 14, "fPresent", 0, 8, false) == 0) && (field_name.Length == 22))
                                                                return fieldGeneratorRequestCitiesIfPresent;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'o':
                                                switch (field_name[9])
                                                  {
                                                    case 'n':
                                                        if ((String.Compare(field_name, 10, "tinents", 0, 7, false) == 0) && (field_name.Length == 17))
                                                            return fieldGeneratorRequestContinents;
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(field_name, 10, "ntries", 0, 6, false) == 0) && (field_name.Length == 16))
                                                            return fieldGeneratorRequestCountries;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'D':
                                        if (String.Compare(field_name, 8, "ischarge", 0, 8, false) == 0)
                                          {
                                            if (field_name.Length == 16)
                                              {
                                                return fieldGeneratorRequestDischarge;
                                              }
                                            switch (field_name[16])
                                              {
                                                case 'I':
                                                    if ((String.Compare(field_name, 17, "fPresent", 0, 8, false) == 0) && (field_name.Length == 25))
                                                        return fieldGeneratorRequestDischargeIfPresent;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'L':
                                        if ((String.Compare(field_name, 8, "ength", 0, 5, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorRequestLength;
                                        break;
                                    case 'U':
                                        if (String.Compare(field_name, 8, "sStates", 0, 7, false) == 0)
                                          {
                                            if (field_name.Length == 15)
                                              {
                                                return fieldGeneratorRequestUsStates;
                                              }
                                            switch (field_name[15])
                                              {
                                                case 'I':
                                                    if ((String.Compare(field_name, 16, "fPresent", 0, 8, false) == 0) && (field_name.Length == 24))
                                                        return fieldGeneratorRequestUsStatesIfPresent;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'e':
                                        if ((String.Compare(field_name, 8, "dCount", 0, 6, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorRequestedCount;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "vers", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorRivers;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ubqueries", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSubqueries;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "seImperialUnits", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorUseImperialUnits;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the RiversQueryState class");
            fieldGeneratorRivers = new RiverJSON.HoldingArrayGenerator("field \"Rivers\" of the RiversQueryState class", ignore_extras);
            fieldGeneratorRequestLength = new JSONHoldingBooleanGenerator("field \"RequestLength\" of the RiversQueryState class");
            fieldGeneratorRequestDischarge = new JSONHoldingBooleanGenerator("field \"RequestDischarge\" of the RiversQueryState class");
            fieldGeneratorRequestDischargeIfPresent = new JSONHoldingBooleanGenerator("field \"RequestDischargeIfPresent\" of the RiversQueryState class");
            fieldGeneratorRequestCities = new JSONHoldingBooleanGenerator("field \"RequestCities\" of the RiversQueryState class");
            fieldGeneratorRequestCitiesIfPresent = new JSONHoldingBooleanGenerator("field \"RequestCitiesIfPresent\" of the RiversQueryState class");
            fieldGeneratorRequestUsStates = new JSONHoldingBooleanGenerator("field \"RequestUsStates\" of the RiversQueryState class");
            fieldGeneratorRequestUsStatesIfPresent = new JSONHoldingBooleanGenerator("field \"RequestUsStatesIfPresent\" of the RiversQueryState class");
            fieldGeneratorRequestCountries = new JSONHoldingBooleanGenerator("field \"RequestCountries\" of the RiversQueryState class");
            fieldGeneratorRequestContinents = new JSONHoldingBooleanGenerator("field \"RequestContinents\" of the RiversQueryState class");
            fieldGeneratorRequestedCount = new FieldHoldingGeneratorRequestedCount("field \"RequestedCount\" of the RiversQueryState class");
            fieldGeneratorOnlyLast = new JSONHoldingBooleanGenerator("field \"OnlyLast\" of the RiversQueryState class");
            fieldGeneratorCriterion = new FieldHoldingGeneratorCriterion("field \"Criterion\" of the RiversQueryState class");
            fieldGeneratorUseImperialUnits = new JSONHoldingBooleanGenerator("field \"UseImperialUnits\" of the RiversQueryState class");
            fieldGeneratorSubqueries = new TypeSubqueriesJSON.HoldingArrayGenerator("field \"Subqueries\" of the RiversQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RiversQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the RiversQueryState class");
            fieldGeneratorRivers = new RiverJSON.HoldingArrayGenerator("field \"Rivers\" of the RiversQueryState class", false);
            fieldGeneratorRequestLength = new JSONHoldingBooleanGenerator("field \"RequestLength\" of the RiversQueryState class");
            fieldGeneratorRequestDischarge = new JSONHoldingBooleanGenerator("field \"RequestDischarge\" of the RiversQueryState class");
            fieldGeneratorRequestDischargeIfPresent = new JSONHoldingBooleanGenerator("field \"RequestDischargeIfPresent\" of the RiversQueryState class");
            fieldGeneratorRequestCities = new JSONHoldingBooleanGenerator("field \"RequestCities\" of the RiversQueryState class");
            fieldGeneratorRequestCitiesIfPresent = new JSONHoldingBooleanGenerator("field \"RequestCitiesIfPresent\" of the RiversQueryState class");
            fieldGeneratorRequestUsStates = new JSONHoldingBooleanGenerator("field \"RequestUsStates\" of the RiversQueryState class");
            fieldGeneratorRequestUsStatesIfPresent = new JSONHoldingBooleanGenerator("field \"RequestUsStatesIfPresent\" of the RiversQueryState class");
            fieldGeneratorRequestCountries = new JSONHoldingBooleanGenerator("field \"RequestCountries\" of the RiversQueryState class");
            fieldGeneratorRequestContinents = new JSONHoldingBooleanGenerator("field \"RequestContinents\" of the RiversQueryState class");
            fieldGeneratorRequestedCount = new FieldHoldingGeneratorRequestedCount("field \"RequestedCount\" of the RiversQueryState class");
            fieldGeneratorOnlyLast = new JSONHoldingBooleanGenerator("field \"OnlyLast\" of the RiversQueryState class");
            fieldGeneratorCriterion = new FieldHoldingGeneratorCriterion("field \"Criterion\" of the RiversQueryState class");
            fieldGeneratorUseImperialUnits = new JSONHoldingBooleanGenerator("field \"UseImperialUnits\" of the RiversQueryState class");
            fieldGeneratorSubqueries = new TypeSubqueriesJSON.HoldingArrayGenerator("field \"Subqueries\" of the RiversQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RiversQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            fieldGeneratorRivers.reset();
            fieldGeneratorRequestLength.reset();
            fieldGeneratorRequestDischarge.reset();
            fieldGeneratorRequestDischargeIfPresent.reset();
            fieldGeneratorRequestCities.reset();
            fieldGeneratorRequestCitiesIfPresent.reset();
            fieldGeneratorRequestUsStates.reset();
            fieldGeneratorRequestUsStatesIfPresent.reset();
            fieldGeneratorRequestCountries.reset();
            fieldGeneratorRequestContinents.reset();
            fieldGeneratorRequestedCount.reset();
            fieldGeneratorOnlyLast.reset();
            fieldGeneratorCriterion.reset();
            fieldGeneratorUseImperialUnits.reset();
            fieldGeneratorSubqueries.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRivers.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSubqueries.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRivers.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSubqueries.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RiversQueryStateJSON  result)
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
        public RiversQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RiversQueryStateJSON  result)
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
    protected virtual void handle_result(List<RiversQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RiversQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RiversQueryStateJSON>();
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
    public List<RiversQueryStateJSON> value;
  };
  };
