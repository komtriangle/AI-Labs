/* file "UberRequestsLoginCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberRequestsLoginCommandJSON : UberRequestsCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasUberRequestsSpec;
        private UberRequestsSpecJSON  storeUberRequestsSpec;
        private bool flagHasUberProducts;
        private UberCompositeProductsJSON  storeUberProducts;
        private bool flagHasCause;
        private string storeCause;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONUberRequestsSpec(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UberRequestsSpecJSON convert_classy = UberRequestsSpecJSON.from_json(json_value, ignore_extras, true);
            setUberRequestsSpec(convert_classy);
          }


        private void  fromJSONUberProducts(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UberCompositeProductsJSON convert_classy = UberCompositeProductsJSON.from_json(json_value, ignore_extras, true);
            setUberProducts(convert_classy);
          }


        private void  fromJSONCause(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Cause of TypeNativeDataJSON is not a string.");
            setCause(json_string.getData());
          }


        public TypeNativeDataJSON()
          {
            flagHasUberRequestsSpec = false;
            flagHasUberProducts = false;
            flagHasCause = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasUberRequestsSpec()
          {
            return flagHasUberRequestsSpec;
          }

        public UberRequestsSpecJSON   getUberRequestsSpec()
          {
            Debug.Assert(flagHasUberRequestsSpec);
            return storeUberRequestsSpec;
          }

        public bool  hasUberProducts()
          {
            return flagHasUberProducts;
          }

        public UberCompositeProductsJSON   getUberProducts()
          {
            Debug.Assert(flagHasUberProducts);
            return storeUberProducts;
          }

        public bool  hasCause()
          {
            return flagHasCause;
          }

        public string  getCause()
          {
            Debug.Assert(flagHasCause);
            return storeCause;
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

        public void setUberRequestsSpec(UberRequestsSpecJSON  new_value)
          {
            if (flagHasUberRequestsSpec)
              {
              }
            flagHasUberRequestsSpec = true;
            storeUberRequestsSpec = new_value;
          }
        public void unsetUberRequestsSpec()
          {
            if (flagHasUberRequestsSpec)
              {
              }
            flagHasUberRequestsSpec = false;
          }
        public void setUberProducts(UberCompositeProductsJSON  new_value)
          {
            if (flagHasUberProducts)
              {
              }
            flagHasUberProducts = true;
            storeUberProducts = new_value;
          }
        public void unsetUberProducts()
          {
            if (flagHasUberProducts)
              {
              }
            flagHasUberProducts = false;
          }
        public void setCause(string new_value)
          {
            flagHasCause = true;
            storeCause = new_value;
          }
        public void unsetCause()
          {
            flagHasCause = false;
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
            Debug.Assert(partial_allowed || flagHasUberRequestsSpec);
            if (flagHasUberRequestsSpec)
              {
                handler.start_pair("UberRequestsSpec");
                if (partial_allowed)
                    storeUberRequestsSpec.write_partial_as_json(handler);
                else
                    storeUberRequestsSpec.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasUberProducts);
            if (flagHasUberProducts)
              {
                handler.start_pair("UberProducts");
                if (partial_allowed)
                    storeUberProducts.write_partial_as_json(handler);
                else
                    storeUberProducts.write_as_json(handler);
              }
            if (flagHasCause)
              {
                handler.start_pair("Cause");
                handler.string_value(storeCause);
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
            if (!(hasUberRequestsSpec()))
              {
                return "When parsing the object for %what%, the \"UberRequestsSpec\" field was missing.";
              }
            if (!(hasUberProducts()))
              {
                return "When parsing the object for %what%, the \"UberProducts\" field was missing.";
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
            private UberRequestsSpecJSON.HoldingGenerator fieldGeneratorUberRequestsSpec;
            private UberCompositeProductsJSON.HoldingGenerator fieldGeneratorUberProducts;
            private JSONHoldingStringGenerator fieldGeneratorCause;
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
                if (fieldGeneratorUberRequestsSpec.have_value)
                  {
                    result.setUberRequestsSpec(fieldGeneratorUberRequestsSpec.value);
                    fieldGeneratorUberRequestsSpec.have_value = false;
                  }
                else if ((!(result.hasUberRequestsSpec())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"UberRequestsSpec\" field was missing.");
                  }
                if (fieldGeneratorUberProducts.have_value)
                  {
                    result.setUberProducts(fieldGeneratorUberProducts.value);
                    fieldGeneratorUberProducts.have_value = false;
                  }
                else if ((!(result.hasUberProducts())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"UberProducts\" field was missing.");
                  }
                if (fieldGeneratorCause.have_value)
                  {
                    result.setCause(fieldGeneratorCause.value);
                    fieldGeneratorCause.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "ause", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorCause;
                        break;
                    case 'U':
                        if (String.Compare(field_name, 1, "ber", 0, 3, false) == 0)
                          {
                            switch (field_name[4])
                              {
                                case 'P':
                                    if ((String.Compare(field_name, 5, "roducts", 0, 7, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorUberProducts;
                                    break;
                                case 'R':
                                    if ((String.Compare(field_name, 5, "equestsSpec", 0, 11, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorUberRequestsSpec;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorUberRequestsSpec = new UberRequestsSpecJSON.HoldingGenerator("field \"UberRequestsSpec\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorUberProducts = new UberCompositeProductsJSON.HoldingGenerator("field \"UberProducts\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorCause = new JSONHoldingStringGenerator("field \"Cause\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorUberRequestsSpec = new UberRequestsSpecJSON.HoldingGenerator("field \"UberRequestsSpec\" of the TypeNativeData class", false);
                fieldGeneratorUberProducts = new UberCompositeProductsJSON.HoldingGenerator("field \"UberProducts\" of the TypeNativeData class", false);
                fieldGeneratorCause = new JSONHoldingStringGenerator("field \"Cause\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorUberRequestsSpec.reset();
                fieldGeneratorUberProducts.reset();
                fieldGeneratorCause.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorUberRequestsSpec.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorUberProducts.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorUberRequestsSpec.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorUberProducts.set_allow_unpolished(new_allow_unpolished);
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
    private bool flagHasRequireLoginResponse;
    private DynamicResponseJSON  storeRequireLoginResponse;
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRequireLoginResponseToJSON()
      {
        JSONValueHandler handler_RequireLoginResponse = new JSONValueHandler();
        storeRequireLoginResponse.write_as_json(handler_RequireLoginResponse);
        return handler_RequireLoginResponse.result;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONRequireLoginResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setRequireLoginResponse(convert_classy);
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public UberRequestsLoginCommandJSON()
      {
        flagHasRequireLoginResponse = false;
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUberRequestsCommandKind()
      {
        return "UberRequestsLogin";
      }

    public bool  hasRequireLoginResponse()
      {
        return flagHasRequireLoginResponse;
      }

    public DynamicResponseJSON   getRequireLoginResponse()
      {
        Debug.Assert(flagHasRequireLoginResponse);
        return storeRequireLoginResponse;
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


    public virtual int extraUberRequestsLoginCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberRequestsLoginCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberRequestsLoginCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberRequestsLoginCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUberRequestsCommandComponentCount()
      {
        int result = 0;
        if (flagHasRequireLoginResponse)
            ++result;
        if (flagHasNativeData)
            ++result;
        result += extraUberRequestsLoginCommandComponentCount();
        return result;
      }
    public override string extraUberRequestsCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRequireLoginResponse)
          {
            if (remainder == 0)
                return "RequireLoginResponse";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraUberRequestsLoginCommandComponentKey(remainder);
      }
    public override JSONValue extraUberRequestsCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRequireLoginResponse)
          {
            if (remainder == 0)
                return extraRequireLoginResponseToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraUberRequestsLoginCommandComponentValue(remainder);
      }
    public override JSONValue extraUberRequestsCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'N':
                if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNativeData ? extraNativeDataToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equireLoginResponse", 0, 19, false) == 0) && (field_name.Length == 20))
                    return (flagHasRequireLoginResponse ? extraRequireLoginResponseToJSON() : null);
                break;
            default:
                break;
          }
        return extraUberRequestsLoginCommandLookup(field_name);
      }

    public void setRequireLoginResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasRequireLoginResponse)
          {
          }
        flagHasRequireLoginResponse = true;
        storeRequireLoginResponse = new_value;
      }
    public void unsetRequireLoginResponse()
      {
        if (flagHasRequireLoginResponse)
          {
          }
        flagHasRequireLoginResponse = false;
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

    public virtual void extraUberRequestsLoginCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberRequestsLoginCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberRequestsLoginCommandLookup(key);
        if (old_field == null)
          {
            extraUberRequestsLoginCommandAppendPair(key, new_component);
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
    public override void extraUberRequestsCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equireLoginResponse", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONRequireLoginResponse(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUberRequestsLoginCommandAppendPair(key, new_component);
      }
    public override void extraUberRequestsCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equireLoginResponse", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONRequireLoginResponse(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUberRequestsLoginCommandSetField(key, new_component);
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
        if (flagHasRequireLoginResponse)
          {
            handler.start_pair("RequireLoginResponse");
            if (partial_allowed)
                storeRequireLoginResponse.write_partial_as_json(handler);
            else
                storeRequireLoginResponse.write_as_json(handler);
          }
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

    public static new UberRequestsLoginCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestsLoginCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsLoginCommand", ignore_extras);
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
    public static new UberRequestsLoginCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberRequestsLoginCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestsLoginCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsLoginCommand", ignore_extras);
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
    public static new UberRequestsLoginCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberRequestsLoginCommandJSON from_text(string text, bool ignore_extras)
      {
        UberRequestsLoginCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsLoginCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberRequestsLoginCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UberRequestsLoginCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberRequestsLoginCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsLoginCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UberRequestsCommandJSON.Generator
      {
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorRequireLoginResponse;
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
            if (!(getUberRequestsCommandJSONKey().Equals("UberRequestsLogin")))
                throw new Exception("The key field has a value other than `UberRequestsLogin'.");
            UberRequestsLoginCommandJSON result = new UberRequestsLoginCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberRequestsLoginCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UberRequestsCommandJSON new_result)
          {
            handle_result((UberRequestsLoginCommandJSON )new_result);
          }
        protected void finish(UberRequestsLoginCommandJSON result)
          {
            if (fieldGeneratorRequireLoginResponse.have_value)
              {
                result.setRequireLoginResponse(fieldGeneratorRequireLoginResponse.value);
                fieldGeneratorRequireLoginResponse.have_value = false;
              }
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
        protected abstract void handle_result(UberRequestsLoginCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'N':
                    if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNativeData;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equireLoginResponse", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorRequireLoginResponse;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRequireLoginResponse = new DynamicResponseJSON.HoldingGenerator("field \"RequireLoginResponse\" of the UberRequestsLoginCommand class", ignore_extras);
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the UberRequestsLoginCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberRequestsLoginCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRequireLoginResponse = new DynamicResponseJSON.HoldingGenerator("field \"RequireLoginResponse\" of the UberRequestsLoginCommand class", false);
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the UberRequestsLoginCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberRequestsLoginCommand class");
          }

        public override void reset()
          {
            fieldGeneratorRequireLoginResponse.reset();
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UberRequestsLoginCommandJSON  result)
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
        public UberRequestsLoginCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberRequestsLoginCommandJSON  result)
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
    protected virtual void handle_result(List<UberRequestsLoginCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberRequestsLoginCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberRequestsLoginCommandJSON>();
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
    public List<UberRequestsLoginCommandJSON> value;
  };
  };
