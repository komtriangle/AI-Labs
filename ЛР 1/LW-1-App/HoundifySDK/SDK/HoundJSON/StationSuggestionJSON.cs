/* file "StationSuggestionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StationSuggestionJSON : JSONBase
  {
    public class TypeStationsJSON : JSONBase
      {
        public enum TypeProviderKnownValues
          {
            Provider_RadioStationNames,
            Provider_Audacy,
            Provider_iHeart,
            Provider_SiriusXM,
            Provider__none
          };
        public struct TypeProvider
          {
            public bool in_known_list;
            public string string_value;
            public TypeProviderKnownValues list_value;
          };

        public static TypeProviderKnownValues  stringToProvider(string chars)
          {
            switch (chars[0])
              {
                case 'A':
                    if ((String.Compare(chars, 1, "udacy", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeProviderKnownValues.Provider_Audacy;
                    break;
                case 'R':
                    if ((String.Compare(chars, 1, "adioStationNames", 0, 16, false) == 0) && (chars.Length == 17))
                        return TypeProviderKnownValues.Provider_RadioStationNames;
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "iriusXM", 0, 7, false) == 0) && (chars.Length == 8))
                        return TypeProviderKnownValues.Provider_SiriusXM;
                    break;
                case 'i':
                    if ((String.Compare(chars, 1, "Heart", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeProviderKnownValues.Provider_iHeart;
                    break;
                default:
                    break;
              }
            return TypeProviderKnownValues.Provider__none;
          }

        public static string  stringFromProvider(TypeProviderKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeProviderKnownValues.Provider_RadioStationNames:
                    return "RadioStationNames";
                case TypeProviderKnownValues.Provider_Audacy:
                    return "Audacy";
                case TypeProviderKnownValues.Provider_iHeart:
                    return "iHeart";
                case TypeProviderKnownValues.Provider_SiriusXM:
                    return "SiriusXM";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasProvider;
        private TypeProvider storeProvider;
        private bool flagHasId;
        private uint storeId;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONProvider(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Provider of TypeStationsJSON is not a string.");
            TypeProvider the_open_enum = new TypeProvider();
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "udacy", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeProviderKnownValues.Provider_Audacy;
                            goto open_enum_is_done;
                          }
                    break;
                case 'R':
                    if ((String.Compare(json_string.getData(), 1, "adioStationNames", 0, 16, false) == 0) && (json_string.getData().Length == 17))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeProviderKnownValues.Provider_RadioStationNames;
                            goto open_enum_is_done;
                          }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "iriusXM", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeProviderKnownValues.Provider_SiriusXM;
                            goto open_enum_is_done;
                          }
                    break;
                case 'i':
                    if ((String.Compare(json_string.getData(), 1, "Heart", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeProviderKnownValues.Provider_iHeart;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setProvider(the_open_enum);
          }


        private void  fromJSONId(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            uint extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Id of TypeStationsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Id of TypeStationsJSON is not an integer.");
                  }
                extracted_integer = (uint)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (uint)(json_integer.getLongInt())            ;
              }
            setId(extracted_integer);
          }


        public TypeStationsJSON()
          {
            flagHasProvider = false;
            flagHasId = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasProvider()
          {
            return flagHasProvider;
          }

        public TypeProvider  getProvider()
          {
            Debug.Assert(flagHasProvider);
            return storeProvider;
          }

        public string  getProviderAsString()
          {
            TypeProvider result = getProvider();
            if (result.in_known_list)
                return stringFromProvider(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasId()
          {
            return flagHasId;
          }

        public uint  getId()
          {
            Debug.Assert(flagHasId);
            return storeId;
          }


        public virtual int extraTypeStationsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeStationsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeStationsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeStationsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setProvider(TypeProvider new_value)
          {
            flagHasProvider = true;
            storeProvider = new_value;
          }
        public void setProvider(string chars)
          {
            TypeProviderKnownValues known = stringToProvider(chars);
            TypeProvider new_value = new TypeProvider();
            if (known == TypeProviderKnownValues.Provider__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setProvider(new_value);
          }
        public void setProvider(TypeProviderKnownValues new_value)
          {
            TypeProvider new_full_value = new TypeProvider();
            Debug.Assert(new_value != TypeProviderKnownValues.Provider__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setProvider(new_full_value);
          }
        public void unsetProvider()
          {
            flagHasProvider = false;
          }
        public void setId(uint new_value)
          {
            flagHasId = true;
            if (new_value < 1)
                throw new Exception("The value for field Id of TypeStationsJSON is less than the lower bound (1) for that field.");
            if (new_value > 4294967294)
                throw new Exception("The value for field Id of TypeStationsJSON is greater than the upper bound (4294967294) for that field.");
            storeId = new_value;
          }
        public void unsetId()
          {
            flagHasId = false;
          }

        public virtual void extraTypeStationsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeStationsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeStationsLookup(key);
            if (old_field == null)
              {
                extraTypeStationsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasProvider);
            if (flagHasProvider)
              {
                handler.start_pair("Provider");
                if (storeProvider.in_known_list)
                  {
                    switch (storeProvider.list_value)
                      {
                        case TypeProviderKnownValues.Provider_RadioStationNames:
                            handler.string_value("RadioStationNames");
                            break;
                        case TypeProviderKnownValues.Provider_Audacy:
                            handler.string_value("Audacy");
                            break;
                        case TypeProviderKnownValues.Provider_iHeart:
                            handler.string_value("iHeart");
                            break;
                        case TypeProviderKnownValues.Provider_SiriusXM:
                            handler.string_value("SiriusXM");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeProvider.string_value);
                  }
              }
            Debug.Assert(partial_allowed || flagHasId);
            if (flagHasId)
              {
                handler.start_pair("Id");
                handler.number_value(storeId);
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
            if (!(hasProvider()))
              {
                return "When parsing the object for %what%, the \"Provider\" field was missing.";
              }
            if (!(hasId()))
              {
                return "When parsing the object for %what%, the \"Id\" field was missing.";
              }
            return null;
          }

        public static TypeStationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStations", ignore_extras);
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
        public static TypeStationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStations", ignore_extras);
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
        public static TypeStationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStationsJSON from_text(string text, bool ignore_extras)
          {
            TypeStationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStations", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeStationsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeStationsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeStationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStations", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorProvider : JSONStringGenerator
              {
                protected FieldGeneratorProvider(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorProvider()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeProviderKnownValues known = stringToProvider(result);
                    TypeProvider new_value = new TypeProvider();
                    if (known == TypeProviderKnownValues.Provider__none)
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
                protected abstract void handle_result(TypeProvider result);
              };
        private class FieldHoldingGeneratorProvider : FieldGeneratorProvider
      {
        protected override void handle_result(TypeProvider result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorProvider(String what)
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
        public TypeProvider value;
      };
        private class FieldHoldingArrayGeneratorProvider : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorProvider
          {
            private FieldHoldingArrayGeneratorProvider top;

            protected override void handle_result(TypeProvider result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorProvider init_top)
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
        protected virtual void handle_result(List<TypeProvider> result)
          {
          }

        public FieldHoldingArrayGeneratorProvider(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeProvider>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorProvider()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeProvider>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeProvider> value;
      };
            private FieldHoldingGeneratorProvider fieldGeneratorProvider;
        private class FieldHoldingGeneratorId : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorId(String what) : base(what, 1, 4294967294L)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorId : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorId(String what) : base(what, 1, 4294967294L)
                  {
                  }
              };
            private FieldHoldingGeneratorId fieldGeneratorId;
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
                TypeStationsJSON result = new TypeStationsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeStationsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeStationsJSON result)
              {
                if (fieldGeneratorProvider.have_value)
                  {
                    result.setProvider(fieldGeneratorProvider.value);
                    fieldGeneratorProvider.have_value = false;
                  }
                else if ((!(result.hasProvider())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Provider\" field was missing.");
                  }
                if (fieldGeneratorId.have_value)
                  {
                    result.setId((uint)(fieldGeneratorId.value));
                    fieldGeneratorId.have_value = false;
                  }
                else if ((!(result.hasId())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Id\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeStationsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'I':
                        if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                            return fieldGeneratorId;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "rovider", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorProvider;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorProvider = new FieldHoldingGeneratorProvider("field \"Provider\" of the TypeStations class");
                fieldGeneratorId = new FieldHoldingGeneratorId("field \"Id\" of the TypeStations class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeStations class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorProvider = new FieldHoldingGeneratorProvider("field \"Provider\" of the TypeStations class");
                fieldGeneratorId = new FieldHoldingGeneratorId("field \"Id\" of the TypeStations class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeStations class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorProvider.reset();
                fieldGeneratorId.reset();
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
            protected override void handle_result(TypeStationsJSON  result)
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
            public TypeStationsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeStationsJSON  result)
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
        protected virtual void handle_result(List<TypeStationsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeStationsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeStationsJSON>();
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
        public List<TypeStationsJSON> value;
      };
      };
    private bool flagHasStations;
    private List< TypeStationsJSON  > storeStations;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Stations of StationSuggestionJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeStationsJSON  > vector_Stations1 = new List< TypeStationsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeStationsJSON convert_classy = TypeStationsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Stations1.Add(convert_classy);
          }
        initStations();
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
            appendStations(vector_Stations1[num1]);
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
          {
          }
      }


    public StationSuggestionJSON()
      {
        flagHasStations = false;
        storeStations = new List< TypeStationsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStations()
      {
        return flagHasStations;
      }

    public int  countOfStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations.Count;
      }

    public TypeStationsJSON   elementOfStations(int element_num)
      {
        Debug.Assert(flagHasStations);
        return storeStations[element_num];
      }

    public List< TypeStationsJSON  >  getStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations;
      }


    public virtual int extraStationSuggestionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStationSuggestionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStationSuggestionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStationSuggestionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initStations()
      {
        if (flagHasStations)
          {
            for (int num1 = 0; num1 < storeStations.Count; ++num1)
              {
              }
          }
        flagHasStations = true;
        storeStations.Clear();
      }
    public void appendStations(TypeStationsJSON  to_append)
      {
        if (!flagHasStations)
          {
            flagHasStations = true;
            storeStations.Clear();
          }
        Debug.Assert(flagHasStations);
        storeStations.Add(to_append);
      }
    public void unsetStations()
      {
        if (flagHasStations)
          {
            for (int num2 = 0; num2 < storeStations.Count; ++num2)
              {
              }
          }
        flagHasStations = false;
        storeStations.Clear();
      }

    public virtual void extraStationSuggestionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStationSuggestionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStationSuggestionLookup(key);
        if (old_field == null)
          {
            extraStationSuggestionAppendPair(key, new_component);
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
        if (flagHasStations)
          {
            handler.start_pair("Stations");
            handler.start_array();
            for (int num1 = 0; num1 < storeStations.Count; ++num1)
              {
                if (partial_allowed)
                    storeStations[num1].write_partial_as_json(handler);
                else
                    storeStations[num1].write_as_json(handler);
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

    public static StationSuggestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StationSuggestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationSuggestion", ignore_extras);
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
    public static StationSuggestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StationSuggestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StationSuggestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationSuggestion", ignore_extras);
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
    public static StationSuggestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StationSuggestionJSON from_text(string text, bool ignore_extras)
      {
        StationSuggestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationSuggestion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StationSuggestionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StationSuggestionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StationSuggestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationSuggestion", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeStationsJSON.HoldingArrayGenerator fieldGeneratorStations;
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
            StationSuggestionJSON result = new StationSuggestionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStationSuggestionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(StationSuggestionJSON result)
          {
            if (fieldGeneratorStations.have_value)
              {
                result.initStations();
                int count = fieldGeneratorStations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStations(fieldGeneratorStations.value[num]);
                  }
                fieldGeneratorStations.value.Clear();
                fieldGeneratorStations.have_value = false;
              }
          }
        protected abstract void handle_result(StationSuggestionJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Stations", 0, 8, false) == 0) && (field_name.Length == 8))
                return fieldGeneratorStations;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStations = new TypeStationsJSON.HoldingArrayGenerator("field \"Stations\" of the StationSuggestion class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StationSuggestion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStations = new TypeStationsJSON.HoldingArrayGenerator("field \"Stations\" of the StationSuggestion class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StationSuggestion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStations.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStations.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStations.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StationSuggestionJSON  result)
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
        public StationSuggestionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StationSuggestionJSON  result)
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
    protected virtual void handle_result(List<StationSuggestionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StationSuggestionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StationSuggestionJSON>();
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
    public List<StationSuggestionJSON> value;
  };
  };
