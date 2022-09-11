/* file "RiversByLocationInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RiversByLocationInformationNuggetJSON : InformationNuggetJSON
  {
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
    private bool flagHasRequestedCount;
    private BigInteger storeRequestedCount;
    private bool flagHasOnlyLast;
    private bool storeOnlyLast;
    private bool flagHasCriterion;
    private TypeCriterion storeCriterion;
    private bool flagHasSubqueries;
    private List< TypeSubqueriesJSON  > storeSubqueries;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRequestedCountToJSON()
      {
        JSONIntegerValue generated_integer_RequestedCount = new JSONIntegerValue(storeRequestedCount);
        return generated_integer_RequestedCount;
      }

    private JSONValue  extraOnlyLastToJSON()
      {
        JSONValue generated_boolean_OnlyLast = (storeOnlyLast ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_OnlyLast;
      }

    private JSONValue  extraCriterionToJSON()
      {
        JSONStringValue generated_string_Criterion;
        switch (storeCriterion)
          {
            case TypeCriterion.Criterion_Length:
                generated_string_Criterion = new JSONStringValue("Length");
                break;
            case TypeCriterion.Criterion_Discharge:
                generated_string_Criterion = new JSONStringValue("Discharge");
                break;
            default:
                Debug.Assert(false);
                generated_string_Criterion = null;
                break;
          }
        return generated_string_Criterion;
      }

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
                throw new Exception("The value for field RequestedCount of RiversByLocationInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RequestedCount of RiversByLocationInformationNuggetJSON is not an integer.");
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
                throw new Exception("The value for field OnlyLast of RiversByLocationInformationNuggetJSON is not true for false.");
              }
          }
        setOnlyLast(the_bool);
      }


    private void  fromJSONCriterion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Criterion of RiversByLocationInformationNuggetJSON is not a string.");
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
        throw new Exception("The value for field Criterion of RiversByLocationInformationNuggetJSON is not one of the legal strings.");
      enum_is_done:;
        setCriterion(the_enum);
      }


    private void  fromJSONSubqueries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Subqueries of RiversByLocationInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Subqueries of RiversByLocationInformationNuggetJSON has too few elements.");
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


    public RiversByLocationInformationNuggetJSON()
      {
        flagHasRequestedCount = false;
        flagHasOnlyLast = false;
        flagHasCriterion = false;
        flagHasSubqueries = false;
        storeSubqueries = new List< TypeSubqueriesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "RiversByLocationInformationNugget";
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


    public virtual int extraRiversByLocationInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRiversByLocationInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRiversByLocationInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRiversByLocationInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasRequestedCount)
            ++result;
        if (flagHasOnlyLast)
            ++result;
        if (flagHasCriterion)
            ++result;
        if (flagHasSubqueries)
            ++result;
        result += extraRiversByLocationInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRequestedCount)
          {
            if (remainder == 0)
                return "RequestedCount";
            --remainder;
          }
        if (flagHasOnlyLast)
          {
            if (remainder == 0)
                return "OnlyLast";
            --remainder;
          }
        if (flagHasCriterion)
          {
            if (remainder == 0)
                return "Criterion";
            --remainder;
          }
        if (flagHasSubqueries)
          {
            if (remainder == 0)
                return "Subqueries";
            --remainder;
          }
        return extraRiversByLocationInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRequestedCount)
          {
            if (remainder == 0)
                return extraRequestedCountToJSON();
            --remainder;
          }
        if (flagHasOnlyLast)
          {
            if (remainder == 0)
                return extraOnlyLastToJSON();
            --remainder;
          }
        if (flagHasCriterion)
          {
            if (remainder == 0)
                return extraCriterionToJSON();
            --remainder;
          }
        if (flagHasSubqueries)
          {
            if (remainder == 0)
                return extraSubqueriesToJSON();
            --remainder;
          }
        return extraRiversByLocationInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "riterion", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasCriterion ? extraCriterionToJSON() : null);
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "nlyLast", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasOnlyLast ? extraOnlyLastToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equestedCount", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasRequestedCount ? extraRequestedCountToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "ubqueries", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasSubqueries ? extraSubqueriesToJSON() : null);
                break;
            default:
                break;
          }
        return extraRiversByLocationInformationNuggetLookup(field_name);
      }

    public void setRequestedCount(BigInteger new_value)
      {
        flagHasRequestedCount = true;
        if (new_value < 1)
            throw new Exception("The value for field RequestedCount of RiversByLocationInformationNuggetJSON is less than the lower bound (1) for that field.");
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

    public virtual void extraRiversByLocationInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRiversByLocationInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRiversByLocationInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraRiversByLocationInformationNuggetAppendPair(key, new_component);
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
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "riterion", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONCriterion(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "nlyLast", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONOnlyLast(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedCount", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONRequestedCount(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ubqueries", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONSubqueries(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRiversByLocationInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "riterion", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONCriterion(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "nlyLast", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONOnlyLast(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedCount", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONRequestedCount(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ubqueries", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONSubqueries(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRiversByLocationInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRequestedCount);
        if (flagHasRequestedCount)
          {
            handler.start_pair("RequestedCount");
            handler.number_value(storeRequestedCount);
          }
        Debug.Assert(partial_allowed || flagHasOnlyLast);
        if (flagHasOnlyLast)
          {
            handler.start_pair("OnlyLast");
            handler.boolean_value(storeOnlyLast);
          }
        Debug.Assert(partial_allowed || flagHasCriterion);
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
        if (!(hasRequestedCount()))
          {
            return "When parsing the object for %what%, the \"RequestedCount\" field was missing.";
          }
        if (!(hasOnlyLast()))
          {
            return "When parsing the object for %what%, the \"OnlyLast\" field was missing.";
          }
        if (!(hasCriterion()))
          {
            return "When parsing the object for %what%, the \"Criterion\" field was missing.";
          }
        if (!(hasSubqueries()))
          {
            return "When parsing the object for %what%, the \"Subqueries\" field was missing.";
          }
        return null;
      }

    public static new RiversByLocationInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiversByLocationInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversByLocationInformationNugget", ignore_extras);
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
    public static new RiversByLocationInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RiversByLocationInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiversByLocationInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversByLocationInformationNugget", ignore_extras);
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
    public static new RiversByLocationInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RiversByLocationInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        RiversByLocationInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversByLocationInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RiversByLocationInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RiversByLocationInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RiversByLocationInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversByLocationInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
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
            if (!(getInformationNuggetJSONKey().Equals("RiversByLocationInformationNugget")))
                throw new Exception("The key field has a value other than `RiversByLocationInformationNugget'.");
            RiversByLocationInformationNuggetJSON result = new RiversByLocationInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRiversByLocationInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((RiversByLocationInformationNuggetJSON )new_result);
          }
        protected void finish(RiversByLocationInformationNuggetJSON result)
          {
            if (fieldGeneratorRequestedCount.have_value)
              {
                result.setRequestedCount(fieldGeneratorRequestedCount.value);
                fieldGeneratorRequestedCount.have_value = false;
              }
            else if ((!(result.hasRequestedCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedCount\" field was missing.");
              }
            if (fieldGeneratorOnlyLast.have_value)
              {
                result.setOnlyLast(fieldGeneratorOnlyLast.value);
                fieldGeneratorOnlyLast.have_value = false;
              }
            else if ((!(result.hasOnlyLast())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OnlyLast\" field was missing.");
              }
            if (fieldGeneratorCriterion.have_value)
              {
                result.setCriterion(fieldGeneratorCriterion.value);
                fieldGeneratorCriterion.have_value = false;
              }
            else if ((!(result.hasCriterion())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Criterion\" field was missing.");
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
            else if ((!(result.hasSubqueries())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Subqueries\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RiversByLocationInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
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
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedCount", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorRequestedCount;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ubqueries", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorSubqueries;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRequestedCount = new FieldHoldingGeneratorRequestedCount("field \"RequestedCount\" of the RiversByLocationInformationNugget class");
            fieldGeneratorOnlyLast = new JSONHoldingBooleanGenerator("field \"OnlyLast\" of the RiversByLocationInformationNugget class");
            fieldGeneratorCriterion = new FieldHoldingGeneratorCriterion("field \"Criterion\" of the RiversByLocationInformationNugget class");
            fieldGeneratorSubqueries = new TypeSubqueriesJSON.HoldingArrayGenerator("field \"Subqueries\" of the RiversByLocationInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RiversByLocationInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRequestedCount = new FieldHoldingGeneratorRequestedCount("field \"RequestedCount\" of the RiversByLocationInformationNugget class");
            fieldGeneratorOnlyLast = new JSONHoldingBooleanGenerator("field \"OnlyLast\" of the RiversByLocationInformationNugget class");
            fieldGeneratorCriterion = new FieldHoldingGeneratorCriterion("field \"Criterion\" of the RiversByLocationInformationNugget class");
            fieldGeneratorSubqueries = new TypeSubqueriesJSON.HoldingArrayGenerator("field \"Subqueries\" of the RiversByLocationInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RiversByLocationInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorRequestedCount.reset();
            fieldGeneratorOnlyLast.reset();
            fieldGeneratorCriterion.reset();
            fieldGeneratorSubqueries.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RiversByLocationInformationNuggetJSON  result)
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
        public RiversByLocationInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RiversByLocationInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<RiversByLocationInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RiversByLocationInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RiversByLocationInformationNuggetJSON>();
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
    public List<RiversByLocationInformationNuggetJSON> value;
  };
  };
