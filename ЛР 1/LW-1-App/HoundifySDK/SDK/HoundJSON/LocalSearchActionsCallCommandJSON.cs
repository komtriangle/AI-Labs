/* file "LocalSearchActionsCallCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class LocalSearchActionsCallCommandJSON : PhoneCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasNumber;
        private string storeNumber;
        private bool flagHasLocalSearchCriteria;
        private LocalSearchFilterSpecJSON  storeLocalSearchCriteria;
        private bool flagHasLocalSearchCriteriaIncremental;
        private LocalSearchFilterSpecJSON  storeLocalSearchCriteriaIncremental;
        private bool flagHasLocalResult;
        private LocalResultJSON  storeLocalResult;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONNumber(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Number of TypeNativeDataJSON is not a string.");
            setNumber(json_string.getData());
          }


        private void  fromJSONLocalSearchCriteria(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            LocalSearchFilterSpecJSON convert_classy = LocalSearchFilterSpecJSON.from_json(json_value, ignore_extras, true);
            setLocalSearchCriteria(convert_classy);
          }


        private void  fromJSONLocalSearchCriteriaIncremental(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            LocalSearchFilterSpecJSON convert_classy = LocalSearchFilterSpecJSON.from_json(json_value, ignore_extras, true);
            setLocalSearchCriteriaIncremental(convert_classy);
          }


        private void  fromJSONLocalResult(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            LocalResultJSON convert_classy = LocalResultJSON.from_json(json_value, ignore_extras, true);
            setLocalResult(convert_classy);
          }


        public TypeNativeDataJSON()
          {
            flagHasNumber = false;
            flagHasLocalSearchCriteria = false;
            flagHasLocalSearchCriteriaIncremental = false;
            flagHasLocalResult = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasNumber()
          {
            return flagHasNumber;
          }

        public string  getNumber()
          {
            Debug.Assert(flagHasNumber);
            return storeNumber;
          }

        public bool  hasLocalSearchCriteria()
          {
            return flagHasLocalSearchCriteria;
          }

        public LocalSearchFilterSpecJSON   getLocalSearchCriteria()
          {
            Debug.Assert(flagHasLocalSearchCriteria);
            return storeLocalSearchCriteria;
          }

        public bool  hasLocalSearchCriteriaIncremental()
          {
            return flagHasLocalSearchCriteriaIncremental;
          }

        public LocalSearchFilterSpecJSON   getLocalSearchCriteriaIncremental()
          {
            Debug.Assert(flagHasLocalSearchCriteriaIncremental);
            return storeLocalSearchCriteriaIncremental;
          }

        public bool  hasLocalResult()
          {
            return flagHasLocalResult;
          }

        public LocalResultJSON   getLocalResult()
          {
            Debug.Assert(flagHasLocalResult);
            return storeLocalResult;
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

        public void setNumber(string new_value)
          {
            flagHasNumber = true;
            storeNumber = new_value;
          }
        public void unsetNumber()
          {
            flagHasNumber = false;
          }
        public void setLocalSearchCriteria(LocalSearchFilterSpecJSON  new_value)
          {
            if (flagHasLocalSearchCriteria)
              {
              }
            flagHasLocalSearchCriteria = true;
            storeLocalSearchCriteria = new_value;
          }
        public void unsetLocalSearchCriteria()
          {
            if (flagHasLocalSearchCriteria)
              {
              }
            flagHasLocalSearchCriteria = false;
          }
        public void setLocalSearchCriteriaIncremental(LocalSearchFilterSpecJSON  new_value)
          {
            if (flagHasLocalSearchCriteriaIncremental)
              {
              }
            flagHasLocalSearchCriteriaIncremental = true;
            storeLocalSearchCriteriaIncremental = new_value;
          }
        public void unsetLocalSearchCriteriaIncremental()
          {
            if (flagHasLocalSearchCriteriaIncremental)
              {
              }
            flagHasLocalSearchCriteriaIncremental = false;
          }
        public void setLocalResult(LocalResultJSON  new_value)
          {
            if (flagHasLocalResult)
              {
              }
            flagHasLocalResult = true;
            storeLocalResult = new_value;
          }
        public void unsetLocalResult()
          {
            if (flagHasLocalResult)
              {
              }
            flagHasLocalResult = false;
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
            Debug.Assert(partial_allowed || flagHasNumber);
            if (flagHasNumber)
              {
                handler.start_pair("Number");
                handler.string_value(storeNumber);
              }
            if (flagHasLocalSearchCriteria)
              {
                handler.start_pair("LocalSearchCriteria");
                if (partial_allowed)
                    storeLocalSearchCriteria.write_partial_as_json(handler);
                else
                    storeLocalSearchCriteria.write_as_json(handler);
              }
            if (flagHasLocalSearchCriteriaIncremental)
              {
                handler.start_pair("LocalSearchCriteriaIncremental");
                if (partial_allowed)
                    storeLocalSearchCriteriaIncremental.write_partial_as_json(handler);
                else
                    storeLocalSearchCriteriaIncremental.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasLocalResult);
            if (flagHasLocalResult)
              {
                handler.start_pair("LocalResult");
                if (partial_allowed)
                    storeLocalResult.write_partial_as_json(handler);
                else
                    storeLocalResult.write_as_json(handler);
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
            if (!(hasNumber()))
              {
                return "When parsing the object for %what%, the \"Number\" field was missing.";
              }
            if (!(hasLocalResult()))
              {
                return "When parsing the object for %what%, the \"LocalResult\" field was missing.";
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
            private JSONHoldingStringGenerator fieldGeneratorNumber;
            private LocalSearchFilterSpecJSON.HoldingGenerator fieldGeneratorLocalSearchCriteria;
            private LocalSearchFilterSpecJSON.HoldingGenerator fieldGeneratorLocalSearchCriteriaIncremental;
            private LocalResultJSON.HoldingGenerator fieldGeneratorLocalResult;
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
                if (fieldGeneratorNumber.have_value)
                  {
                    result.setNumber(fieldGeneratorNumber.value);
                    fieldGeneratorNumber.have_value = false;
                  }
                else if ((!(result.hasNumber())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Number\" field was missing.");
                  }
                if (fieldGeneratorLocalSearchCriteria.have_value)
                  {
                    result.setLocalSearchCriteria(fieldGeneratorLocalSearchCriteria.value);
                    fieldGeneratorLocalSearchCriteria.have_value = false;
                  }
                if (fieldGeneratorLocalSearchCriteriaIncremental.have_value)
                  {
                    result.setLocalSearchCriteriaIncremental(fieldGeneratorLocalSearchCriteriaIncremental.value);
                    fieldGeneratorLocalSearchCriteriaIncremental.have_value = false;
                  }
                if (fieldGeneratorLocalResult.have_value)
                  {
                    result.setLocalResult(fieldGeneratorLocalResult.value);
                    fieldGeneratorLocalResult.have_value = false;
                  }
                else if ((!(result.hasLocalResult())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"LocalResult\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if (String.Compare(field_name, 1, "ocal", 0, 4, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'R':
                                    if ((String.Compare(field_name, 6, "esult", 0, 5, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorLocalResult;
                                    break;
                                case 'S':
                                    if (String.Compare(field_name, 6, "earchCriteria", 0, 13, false) == 0)
                                      {
                                        if (field_name.Length == 19)
                                          {
                                            return fieldGeneratorLocalSearchCriteria;
                                          }
                                        switch (field_name[19])
                                          {
                                            case 'I':
                                                if ((String.Compare(field_name, 20, "ncremental", 0, 10, false) == 0) && (field_name.Length == 30))
                                                    return fieldGeneratorLocalSearchCriteriaIncremental;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorNumber;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the TypeNativeData class");
                fieldGeneratorLocalSearchCriteria = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"LocalSearchCriteria\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorLocalSearchCriteriaIncremental = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"LocalSearchCriteriaIncremental\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorLocalResult = new LocalResultJSON.HoldingGenerator("field \"LocalResult\" of the TypeNativeData class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the TypeNativeData class");
                fieldGeneratorLocalSearchCriteria = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"LocalSearchCriteria\" of the TypeNativeData class", false);
                fieldGeneratorLocalSearchCriteriaIncremental = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"LocalSearchCriteriaIncremental\" of the TypeNativeData class", false);
                fieldGeneratorLocalResult = new LocalResultJSON.HoldingGenerator("field \"LocalResult\" of the TypeNativeData class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorNumber.reset();
                fieldGeneratorLocalSearchCriteria.reset();
                fieldGeneratorLocalSearchCriteriaIncremental.reset();
                fieldGeneratorLocalResult.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorLocalSearchCriteria.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorLocalSearchCriteriaIncremental.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorLocalResult.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorLocalSearchCriteria.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorLocalSearchCriteriaIncremental.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorLocalResult.set_allow_unpolished(new_allow_unpolished);
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
    private bool flagHasNumber;
    private string storeNumber;
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNumberToJSON()
      {
        JSONStringValue generated_string_Number = new JSONStringValue(storeNumber);
        return generated_string_Number;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Number of LocalSearchActionsCallCommandJSON is not a string.");
        setNumber(json_string.getData());
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public LocalSearchActionsCallCommandJSON()
      {
        flagHasNumber = false;
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPhoneCommandKind()
      {
        return "CallLocalBusiness";
      }

    public bool  hasNumber()
      {
        return flagHasNumber;
      }

    public string  getNumber()
      {
        Debug.Assert(flagHasNumber);
        return storeNumber;
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


    public virtual int extraLocalSearchActionsCallCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLocalSearchActionsCallCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLocalSearchActionsCallCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLocalSearchActionsCallCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPhoneCommandComponentCount()
      {
        int result = 0;
        if (flagHasNumber)
            ++result;
        if (flagHasNativeData)
            ++result;
        result += extraLocalSearchActionsCallCommandComponentCount();
        return result;
      }
    public override string extraPhoneCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumber)
          {
            if (remainder == 0)
                return "Number";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraLocalSearchActionsCallCommandComponentKey(remainder);
      }
    public override JSONValue extraPhoneCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumber)
          {
            if (remainder == 0)
                return extraNumberToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraLocalSearchActionsCallCommandComponentValue(remainder);
      }
    public override JSONValue extraPhoneCommandLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "N", 0, 1, false) == 0)
          {
            switch (field_name[1])
              {
                case 'a':
                    if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                        return (flagHasNativeData ? extraNativeDataToJSON() : null);
                    break;
                case 'u':
                    if ((String.Compare(field_name, 2, "mber", 0, 4, false) == 0) && (field_name.Length == 6))
                        return (flagHasNumber ? extraNumberToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraLocalSearchActionsCallCommandLookup(field_name);
      }

    public void setNumber(string new_value)
      {
        flagHasNumber = true;
        storeNumber = new_value;
      }
    public void unsetNumber()
      {
        flagHasNumber = false;
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

    public virtual void extraLocalSearchActionsCallCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLocalSearchActionsCallCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLocalSearchActionsCallCommandLookup(key);
        if (old_field == null)
          {
            extraLocalSearchActionsCallCommandAppendPair(key, new_component);
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
    public override void extraPhoneCommandAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "N", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                        {
                        fromJSONNativeData(new_component, false);
                        return;
                        }
                    break;
                case 'u':
                    if ((String.Compare(key, 2, "mber", 0, 4, false) == 0) && (key.Length == 6))
                        {
                        fromJSONNumber(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraLocalSearchActionsCallCommandAppendPair(key, new_component);
      }
    public override void extraPhoneCommandSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "N", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                        {
                        fromJSONNativeData(new_component, false);
                        return;
                        }
                    break;
                case 'u':
                    if ((String.Compare(key, 2, "mber", 0, 4, false) == 0) && (key.Length == 6))
                        {
                        fromJSONNumber(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraLocalSearchActionsCallCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNumber);
        if (flagHasNumber)
          {
            handler.start_pair("Number");
            handler.string_value(storeNumber);
          }
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
        if (!(hasNumber()))
          {
            return "When parsing the object for %what%, the \"Number\" field was missing.";
          }
        return null;
      }

    public static new LocalSearchActionsCallCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchActionsCallCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchActionsCallCommand", ignore_extras);
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
    public static new LocalSearchActionsCallCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LocalSearchActionsCallCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchActionsCallCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchActionsCallCommand", ignore_extras);
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
    public static new LocalSearchActionsCallCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LocalSearchActionsCallCommandJSON from_text(string text, bool ignore_extras)
      {
        LocalSearchActionsCallCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchActionsCallCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LocalSearchActionsCallCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new LocalSearchActionsCallCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LocalSearchActionsCallCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchActionsCallCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PhoneCommandJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorNumber;
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
            if (!(getPhoneCommandJSONKey().Equals("CallLocalBusiness")))
                throw new Exception("The key field has a value other than `CallLocalBusiness'.");
            LocalSearchActionsCallCommandJSON result = new LocalSearchActionsCallCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLocalSearchActionsCallCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PhoneCommandJSON new_result)
          {
            handle_result((LocalSearchActionsCallCommandJSON )new_result);
          }
        protected void finish(LocalSearchActionsCallCommandJSON result)
          {
            if (fieldGeneratorNumber.have_value)
              {
                result.setNumber(fieldGeneratorNumber.value);
                fieldGeneratorNumber.have_value = false;
              }
            else if ((!(result.hasNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Number\" field was missing.");
              }
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(LocalSearchActionsCallCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "N", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorNativeData;
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 2, "mber", 0, 4, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorNumber;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the LocalSearchActionsCallCommand class");
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the LocalSearchActionsCallCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LocalSearchActionsCallCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the LocalSearchActionsCallCommand class");
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the LocalSearchActionsCallCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LocalSearchActionsCallCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNumber.reset();
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(LocalSearchActionsCallCommandJSON  result)
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
        public LocalSearchActionsCallCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LocalSearchActionsCallCommandJSON  result)
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
    protected virtual void handle_result(List<LocalSearchActionsCallCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LocalSearchActionsCallCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LocalSearchActionsCallCommandJSON>();
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
    public List<LocalSearchActionsCallCommandJSON> value;
  };
  };
