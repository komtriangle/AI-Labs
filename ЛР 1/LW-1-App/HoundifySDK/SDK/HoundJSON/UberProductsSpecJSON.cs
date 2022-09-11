/* file "UberProductsSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberProductsSpecJSON : UberSpecJSON
  {
    public enum TypeQueryTypes
      {
        QueryTypes_availability,
        QueryTypes_fare,
        QueryTypes_surge
      };

    public static TypeQueryTypes  stringToQueryTypes(string chars)
      {
        switch (chars[0])
          {
            case 'a':
                if ((String.Compare(chars, 1, "vailability", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeQueryTypes.QueryTypes_availability;
                break;
            case 'f':
                if ((String.Compare(chars, 1, "are", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeQueryTypes.QueryTypes_fare;
                break;
            case 's':
                if ((String.Compare(chars, 1, "urge", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeQueryTypes.QueryTypes_surge;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `QueryTypes' is not one of the legal values.");
      }

    public static string  stringFromQueryTypes(TypeQueryTypes the_enum)
      {
        switch (the_enum)
          {
            case TypeQueryTypes.QueryTypes_availability:
                return "availability";
            case TypeQueryTypes.QueryTypes_fare:
                return "fare";
            case TypeQueryTypes.QueryTypes_surge:
                return "surge";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasPreferredProduct;
    private string storePreferredProduct;
    private bool flagHasPickupLocation;
    private MapLocationJSON  storePickupLocation;
    private bool flagHasQueryTypes;
    private List< TypeQueryTypes > storeQueryTypes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPreferredProductToJSON()
      {
        JSONStringValue generated_string_PreferredProduct = new JSONStringValue(storePreferredProduct);
        return generated_string_PreferredProduct;
      }

    private JSONValue  extraPickupLocationToJSON()
      {
        JSONValueHandler handler_PickupLocation = new JSONValueHandler();
        storePickupLocation.write_as_json(handler_PickupLocation);
        return handler_PickupLocation.result;
      }

    private JSONValue  extraQueryTypesToJSON()
      {
        JSONArrayValue generated_array_1_QueryTypes = new JSONArrayValue();
        for (int num1 = 0; num1 < storeQueryTypes.Count; ++num1)
          {
            JSONStringValue generated_string_QueryTypes;
            switch (storeQueryTypes[num1])
              {
                case TypeQueryTypes.QueryTypes_availability:
                    generated_string_QueryTypes = new JSONStringValue("availability");
                    break;
                case TypeQueryTypes.QueryTypes_fare:
                    generated_string_QueryTypes = new JSONStringValue("fare");
                    break;
                case TypeQueryTypes.QueryTypes_surge:
                    generated_string_QueryTypes = new JSONStringValue("surge");
                    break;
                default:
                    Debug.Assert(false);
                    generated_string_QueryTypes = null;
                    break;
              }
            generated_array_1_QueryTypes.appendComponent(generated_string_QueryTypes);
          }
        return generated_array_1_QueryTypes;
      }


    private void  fromJSONPreferredProduct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PreferredProduct of UberProductsSpecJSON is not a string.");
        setPreferredProduct(json_string.getData());
      }


    private void  fromJSONPickupLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setPickupLocation(convert_classy);
      }


    private void  fromJSONQueryTypes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryTypes of UberProductsSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field QueryTypes of UberProductsSpecJSON has too few elements.");
        List< TypeQueryTypes > vector_QueryTypes1 = new List< TypeQueryTypes >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field QueryTypes of UberProductsSpecJSON is not a string.");
            TypeQueryTypes the_enum;
            switch (json_string.getData()[0])
              {
                case 'a':
                    if ((String.Compare(json_string.getData(), 1, "vailability", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                          {
                            the_enum = TypeQueryTypes.QueryTypes_availability;
                            goto enum_is_done;
                          }
                    break;
                case 'f':
                    if ((String.Compare(json_string.getData(), 1, "are", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeQueryTypes.QueryTypes_fare;
                            goto enum_is_done;
                          }
                    break;
                case 's':
                    if ((String.Compare(json_string.getData(), 1, "urge", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeQueryTypes.QueryTypes_surge;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field QueryTypes of UberProductsSpecJSON is not one of the legal strings.");
          enum_is_done:;
            vector_QueryTypes1.Add(the_enum);
          }
        Debug.Assert(vector_QueryTypes1.Count >= 1);
        initQueryTypes();
        for (int num1 = 0; num1 < vector_QueryTypes1.Count; ++num1)
            appendQueryTypes(vector_QueryTypes1[num1]);
        for (int num1 = 0; num1 < vector_QueryTypes1.Count; ++num1)
          {
          }
      }


    public UberProductsSpecJSON()
      {
        flagHasPreferredProduct = false;
        flagHasPickupLocation = false;
        flagHasQueryTypes = false;
        storeQueryTypes = new List< TypeQueryTypes >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUberSpecKind()
      {
        return "UberProductsSpec";
      }

    public bool  hasPreferredProduct()
      {
        return flagHasPreferredProduct;
      }

    public string  getPreferredProduct()
      {
        Debug.Assert(flagHasPreferredProduct);
        return storePreferredProduct;
      }

    public bool  hasPickupLocation()
      {
        return flagHasPickupLocation;
      }

    public MapLocationJSON   getPickupLocation()
      {
        Debug.Assert(flagHasPickupLocation);
        return storePickupLocation;
      }

    public bool  hasQueryTypes()
      {
        return flagHasQueryTypes;
      }

    public int  countOfQueryTypes()
      {
        Debug.Assert(flagHasQueryTypes);
        return storeQueryTypes.Count;
      }

    public TypeQueryTypes  elementOfQueryTypes(int element_num)
      {
        Debug.Assert(flagHasQueryTypes);
        return storeQueryTypes[element_num];
      }

    public List< TypeQueryTypes >  getQueryTypes()
      {
        Debug.Assert(flagHasQueryTypes);
        return storeQueryTypes;
      }


    public virtual int extraUberProductsSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberProductsSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberProductsSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberProductsSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUberSpecComponentCount()
      {
        int result = 0;
        if (flagHasPreferredProduct)
            ++result;
        if (flagHasPickupLocation)
            ++result;
        if (flagHasQueryTypes)
            ++result;
        result += extraUberProductsSpecComponentCount();
        return result;
      }
    public override string extraUberSpecComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPreferredProduct)
          {
            if (remainder == 0)
                return "PreferredProduct";
            --remainder;
          }
        if (flagHasPickupLocation)
          {
            if (remainder == 0)
                return "PickupLocation";
            --remainder;
          }
        if (flagHasQueryTypes)
          {
            if (remainder == 0)
                return "QueryTypes";
            --remainder;
          }
        return extraUberProductsSpecComponentKey(remainder);
      }
    public override JSONValue extraUberSpecComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPreferredProduct)
          {
            if (remainder == 0)
                return extraPreferredProductToJSON();
            --remainder;
          }
        if (flagHasPickupLocation)
          {
            if (remainder == 0)
                return extraPickupLocationToJSON();
            --remainder;
          }
        if (flagHasQueryTypes)
          {
            if (remainder == 0)
                return extraQueryTypesToJSON();
            --remainder;
          }
        return extraUberProductsSpecComponentValue(remainder);
      }
    public override JSONValue extraUberSpecLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'P':
                switch (field_name[1])
                  {
                    case 'i':
                        if ((String.Compare(field_name, 2, "ckupLocation", 0, 12, false) == 0) && (field_name.Length == 14))
                            return (flagHasPickupLocation ? extraPickupLocationToJSON() : null);
                        break;
                    case 'r':
                        if ((String.Compare(field_name, 2, "eferredProduct", 0, 14, false) == 0) && (field_name.Length == 16))
                            return (flagHasPreferredProduct ? extraPreferredProductToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryTypes", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasQueryTypes ? extraQueryTypesToJSON() : null);
                break;
            default:
                break;
          }
        return extraUberProductsSpecLookup(field_name);
      }

    public void setPreferredProduct(string new_value)
      {
        flagHasPreferredProduct = true;
        storePreferredProduct = new_value;
      }
    public void unsetPreferredProduct()
      {
        flagHasPreferredProduct = false;
      }
    public void setPickupLocation(MapLocationJSON  new_value)
      {
        if (flagHasPickupLocation)
          {
          }
        flagHasPickupLocation = true;
        storePickupLocation = new_value;
      }
    public void unsetPickupLocation()
      {
        if (flagHasPickupLocation)
          {
          }
        flagHasPickupLocation = false;
      }
    public void initQueryTypes()
      {
        flagHasQueryTypes = true;
        storeQueryTypes.Clear();
      }
    public void appendQueryTypes(TypeQueryTypes to_append)
      {
        if (!flagHasQueryTypes)
          {
            flagHasQueryTypes = true;
            storeQueryTypes.Clear();
          }
        Debug.Assert(flagHasQueryTypes);
        storeQueryTypes.Add(to_append);
      }
    public void appendQueryTypes(string chars)
      {
        appendQueryTypes(stringToQueryTypes(chars));
      }
    public void unsetQueryTypes()
      {
        flagHasQueryTypes = false;
        storeQueryTypes.Clear();
      }

    public virtual void extraUberProductsSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberProductsSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberProductsSpecLookup(key);
        if (old_field == null)
          {
            extraUberProductsSpecAppendPair(key, new_component);
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
    public override void extraUberSpecAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'P':
                switch (key[1])
                  {
                    case 'i':
                        if ((String.Compare(key, 2, "ckupLocation", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONPickupLocation(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "eferredProduct", 0, 14, false) == 0) && (key.Length == 16))
                            {
                            fromJSONPreferredProduct(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryTypes", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONQueryTypes(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUberProductsSpecAppendPair(key, new_component);
      }
    public override void extraUberSpecSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'P':
                switch (key[1])
                  {
                    case 'i':
                        if ((String.Compare(key, 2, "ckupLocation", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONPickupLocation(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "eferredProduct", 0, 14, false) == 0) && (key.Length == 16))
                            {
                            fromJSONPreferredProduct(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryTypes", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONQueryTypes(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUberProductsSpecSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPreferredProduct);
        if (flagHasPreferredProduct)
          {
            handler.start_pair("PreferredProduct");
            handler.string_value(storePreferredProduct);
          }
        Debug.Assert(partial_allowed || flagHasPickupLocation);
        if (flagHasPickupLocation)
          {
            handler.start_pair("PickupLocation");
            if (partial_allowed)
                storePickupLocation.write_partial_as_json(handler);
            else
                storePickupLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasQueryTypes);
        if (flagHasQueryTypes)
          {
            handler.start_pair("QueryTypes");
            Debug.Assert(storeQueryTypes.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeQueryTypes.Count; ++num1)
              {
                switch (storeQueryTypes[num1])
                  {
                    case TypeQueryTypes.QueryTypes_availability:
                        handler.string_value("availability");
                        break;
                    case TypeQueryTypes.QueryTypes_fare:
                        handler.string_value("fare");
                        break;
                    case TypeQueryTypes.QueryTypes_surge:
                        handler.string_value("surge");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
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
        if (!(hasPreferredProduct()))
          {
            return "When parsing the object for %what%, the \"PreferredProduct\" field was missing.";
          }
        if (!(hasPickupLocation()))
          {
            return "When parsing the object for %what%, the \"PickupLocation\" field was missing.";
          }
        if (!(hasQueryTypes()))
          {
            return "When parsing the object for %what%, the \"QueryTypes\" field was missing.";
          }
        return null;
      }

    public static new UberProductsSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberProductsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsSpec", ignore_extras);
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
    public static new UberProductsSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberProductsSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberProductsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsSpec", ignore_extras);
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
    public static new UberProductsSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberProductsSpecJSON from_text(string text, bool ignore_extras)
      {
        UberProductsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberProductsSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UberProductsSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberProductsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductsSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UberSpecJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorPreferredProduct;
        private MapLocationJSON.HoldingGenerator fieldGeneratorPickupLocation;
    private abstract class FieldGeneratorQueryTypes : JSONStringGenerator
          {
            protected FieldGeneratorQueryTypes(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQueryTypes()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToQueryTypes(result));
              }
            protected abstract void handle_result(TypeQueryTypes result);
          };
    private class FieldHoldingGeneratorQueryTypes : FieldGeneratorQueryTypes
  {
    protected override void handle_result(TypeQueryTypes result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQueryTypes(String what)
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
    public TypeQueryTypes value;
  };
    private class FieldHoldingArrayGeneratorQueryTypes : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQueryTypes
      {
        private FieldHoldingArrayGeneratorQueryTypes top;

        protected override void handle_result(TypeQueryTypes result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQueryTypes init_top)
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
    protected virtual void handle_result(List<TypeQueryTypes> result)
      {
      }

    public FieldHoldingArrayGeneratorQueryTypes(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryTypes>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQueryTypes()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryTypes>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQueryTypes> value;
  };
        private FieldHoldingArrayGeneratorQueryTypes fieldGeneratorQueryTypes;
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
            if (!(getUberSpecJSONKey().Equals("UberProductsSpec")))
                throw new Exception("The key field has a value other than `UberProductsSpec'.");
            UberProductsSpecJSON result = new UberProductsSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberProductsSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UberSpecJSON new_result)
          {
            handle_result((UberProductsSpecJSON )new_result);
          }
        protected void finish(UberProductsSpecJSON result)
          {
            if (fieldGeneratorPreferredProduct.have_value)
              {
                result.setPreferredProduct(fieldGeneratorPreferredProduct.value);
                fieldGeneratorPreferredProduct.have_value = false;
              }
            else if ((!(result.hasPreferredProduct())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PreferredProduct\" field was missing.");
              }
            if (fieldGeneratorPickupLocation.have_value)
              {
                result.setPickupLocation(fieldGeneratorPickupLocation.value);
                fieldGeneratorPickupLocation.have_value = false;
              }
            else if ((!(result.hasPickupLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PickupLocation\" field was missing.");
              }
            if (fieldGeneratorQueryTypes.have_value)
              {
                result.initQueryTypes();
                int count = fieldGeneratorQueryTypes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryTypes(fieldGeneratorQueryTypes.value[num]);
                  }
                fieldGeneratorQueryTypes.value.Clear();
                fieldGeneratorQueryTypes.have_value = false;
              }
            else if ((!(result.hasQueryTypes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryTypes\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UberProductsSpecJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'P':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "ckupLocation", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorPickupLocation;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "eferredProduct", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorPreferredProduct;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryTypes", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorQueryTypes;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPreferredProduct = new JSONHoldingStringGenerator("field \"PreferredProduct\" of the UberProductsSpec class");
            fieldGeneratorPickupLocation = new MapLocationJSON.HoldingGenerator("field \"PickupLocation\" of the UberProductsSpec class", ignore_extras);
            fieldGeneratorQueryTypes = new FieldHoldingArrayGeneratorQueryTypes("field \"QueryTypes\" of the UberProductsSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberProductsSpec class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPreferredProduct = new JSONHoldingStringGenerator("field \"PreferredProduct\" of the UberProductsSpec class");
            fieldGeneratorPickupLocation = new MapLocationJSON.HoldingGenerator("field \"PickupLocation\" of the UberProductsSpec class", false);
            fieldGeneratorQueryTypes = new FieldHoldingArrayGeneratorQueryTypes("field \"QueryTypes\" of the UberProductsSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberProductsSpec class");
          }

        public override void reset()
          {
            fieldGeneratorPreferredProduct.reset();
            fieldGeneratorPickupLocation.reset();
            fieldGeneratorQueryTypes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UberProductsSpecJSON  result)
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
        public UberProductsSpecJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberProductsSpecJSON  result)
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
    protected virtual void handle_result(List<UberProductsSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberProductsSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberProductsSpecJSON>();
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
    public List<UberProductsSpecJSON> value;
  };
  };
