/* file "RestaurantMenuCategoryComponentsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RestaurantMenuCategoryComponentsJSON : JSONBase
  {
    private bool flagHasItemId;
    private BigInteger storeItemId;
    private bool flagHasCategoryComponentName;
    private string storeCategoryComponentName;
    private bool flagHasTerrierExpression;
    private string storeTerrierExpression;
    private bool flagHasOtherMatches;
    private List< BigInteger > storeOtherMatches;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONItemId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ItemId of RestaurantMenuCategoryComponentsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ItemId of RestaurantMenuCategoryComponentsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setItemId(extracted_integer);
      }


    private void  fromJSONCategoryComponentName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CategoryComponentName of RestaurantMenuCategoryComponentsJSON is not a string.");
        setCategoryComponentName(json_string.getData());
      }


    private void  fromJSONTerrierExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TerrierExpression of RestaurantMenuCategoryComponentsJSON is not a string.");
        setTerrierExpression(json_string.getData());
      }


    private void  fromJSONOtherMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OtherMatches of RestaurantMenuCategoryComponentsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field OtherMatches of RestaurantMenuCategoryComponentsJSON has too few elements.");
        List< BigInteger > vector_OtherMatches1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field OtherMatches of RestaurantMenuCategoryComponentsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field OtherMatches of RestaurantMenuCategoryComponentsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_OtherMatches1.Add(extracted_integer);
          }
        Debug.Assert(vector_OtherMatches1.Count >= 1);
        initOtherMatches();
        for (int num1 = 0; num1 < vector_OtherMatches1.Count; ++num1)
            appendOtherMatches(vector_OtherMatches1[num1]);
        for (int num1 = 0; num1 < vector_OtherMatches1.Count; ++num1)
          {
          }
      }


    public RestaurantMenuCategoryComponentsJSON()
      {
        flagHasItemId = false;
        flagHasCategoryComponentName = false;
        flagHasTerrierExpression = false;
        flagHasOtherMatches = false;
        storeOtherMatches = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasItemId()
      {
        return flagHasItemId;
      }

    public BigInteger  getItemId()
      {
        Debug.Assert(flagHasItemId);
        return storeItemId;
      }

    public bool  hasCategoryComponentName()
      {
        return flagHasCategoryComponentName;
      }

    public string  getCategoryComponentName()
      {
        Debug.Assert(flagHasCategoryComponentName);
        return storeCategoryComponentName;
      }

    public bool  hasTerrierExpression()
      {
        return flagHasTerrierExpression;
      }

    public string  getTerrierExpression()
      {
        Debug.Assert(flagHasTerrierExpression);
        return storeTerrierExpression;
      }

    public bool  hasOtherMatches()
      {
        return flagHasOtherMatches;
      }

    public int  countOfOtherMatches()
      {
        Debug.Assert(flagHasOtherMatches);
        return storeOtherMatches.Count;
      }

    public BigInteger  elementOfOtherMatches(int element_num)
      {
        Debug.Assert(flagHasOtherMatches);
        return storeOtherMatches[element_num];
      }

    public List< BigInteger >  getOtherMatches()
      {
        Debug.Assert(flagHasOtherMatches);
        return storeOtherMatches;
      }


    public virtual int extraRestaurantMenuCategoryComponentsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantMenuCategoryComponentsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantMenuCategoryComponentsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantMenuCategoryComponentsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setItemId(BigInteger new_value)
      {
        flagHasItemId = true;
        storeItemId = new_value;
      }
    public void unsetItemId()
      {
        flagHasItemId = false;
      }
    public void setCategoryComponentName(string new_value)
      {
        flagHasCategoryComponentName = true;
        storeCategoryComponentName = new_value;
      }
    public void unsetCategoryComponentName()
      {
        flagHasCategoryComponentName = false;
      }
    public void setTerrierExpression(string new_value)
      {
        flagHasTerrierExpression = true;
        storeTerrierExpression = new_value;
      }
    public void unsetTerrierExpression()
      {
        flagHasTerrierExpression = false;
      }
    public void initOtherMatches()
      {
        flagHasOtherMatches = true;
        storeOtherMatches.Clear();
      }
    public void appendOtherMatches(BigInteger to_append)
      {
        if (!flagHasOtherMatches)
          {
            flagHasOtherMatches = true;
            storeOtherMatches.Clear();
          }
        Debug.Assert(flagHasOtherMatches);
        storeOtherMatches.Add(to_append);
      }
    public void unsetOtherMatches()
      {
        flagHasOtherMatches = false;
        storeOtherMatches.Clear();
      }

    public virtual void extraRestaurantMenuCategoryComponentsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantMenuCategoryComponentsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantMenuCategoryComponentsLookup(key);
        if (old_field == null)
          {
            extraRestaurantMenuCategoryComponentsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasItemId);
        if (flagHasItemId)
          {
            handler.start_pair("ItemId");
            handler.number_value(storeItemId);
          }
        Debug.Assert(partial_allowed || flagHasCategoryComponentName);
        if (flagHasCategoryComponentName)
          {
            handler.start_pair("CategoryComponentName");
            handler.string_value(storeCategoryComponentName);
          }
        if (flagHasTerrierExpression)
          {
            handler.start_pair("TerrierExpression");
            handler.string_value(storeTerrierExpression);
          }
        if (flagHasOtherMatches)
          {
            handler.start_pair("OtherMatches");
            Debug.Assert(storeOtherMatches.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeOtherMatches.Count; ++num1)
              {
                handler.number_value(storeOtherMatches[num1]);
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
        if (!(hasItemId()))
          {
            return "When parsing the object for %what%, the \"ItemId\" field was missing.";
          }
        if (!(hasCategoryComponentName()))
          {
            return "When parsing the object for %what%, the \"CategoryComponentName\" field was missing.";
          }
        return null;
      }

    public static RestaurantMenuCategoryComponentsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuCategoryComponentsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCategoryComponents", ignore_extras);
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
    public static RestaurantMenuCategoryComponentsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuCategoryComponentsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuCategoryComponentsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCategoryComponents", ignore_extras);
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
    public static RestaurantMenuCategoryComponentsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuCategoryComponentsJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuCategoryComponentsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCategoryComponents", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuCategoryComponentsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuCategoryComponentsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuCategoryComponentsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCategoryComponents", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorItemId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorItemId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorItemId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorItemId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorItemId fieldGeneratorItemId;
        private JSONHoldingStringGenerator fieldGeneratorCategoryComponentName;
        private JSONHoldingStringGenerator fieldGeneratorTerrierExpression;
    private class FieldHoldingGeneratorOtherMatches : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorOtherMatches(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorOtherMatches : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorOtherMatches(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorOtherMatches fieldGeneratorOtherMatches;
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
            RestaurantMenuCategoryComponentsJSON result = new RestaurantMenuCategoryComponentsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantMenuCategoryComponentsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantMenuCategoryComponentsJSON result)
          {
            if (fieldGeneratorItemId.have_value)
              {
                result.setItemId(fieldGeneratorItemId.value);
                fieldGeneratorItemId.have_value = false;
              }
            else if ((!(result.hasItemId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ItemId\" field was missing.");
              }
            if (fieldGeneratorCategoryComponentName.have_value)
              {
                result.setCategoryComponentName(fieldGeneratorCategoryComponentName.value);
                fieldGeneratorCategoryComponentName.have_value = false;
              }
            else if ((!(result.hasCategoryComponentName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CategoryComponentName\" field was missing.");
              }
            if (fieldGeneratorTerrierExpression.have_value)
              {
                result.setTerrierExpression(fieldGeneratorTerrierExpression.value);
                fieldGeneratorTerrierExpression.have_value = false;
              }
            if (fieldGeneratorOtherMatches.have_value)
              {
                result.initOtherMatches();
                int count = fieldGeneratorOtherMatches.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOtherMatches(fieldGeneratorOtherMatches.value[num]);
                  }
                fieldGeneratorOtherMatches.value.Clear();
                fieldGeneratorOtherMatches.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantMenuCategoryComponentsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ategoryComponentName", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorCategoryComponentName;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "temId", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorItemId;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "therMatches", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorOtherMatches;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "errierExpression", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorTerrierExpression;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorItemId = new FieldHoldingGeneratorItemId("field \"ItemId\" of the RestaurantMenuCategoryComponents class");
            fieldGeneratorCategoryComponentName = new JSONHoldingStringGenerator("field \"CategoryComponentName\" of the RestaurantMenuCategoryComponents class");
            fieldGeneratorTerrierExpression = new JSONHoldingStringGenerator("field \"TerrierExpression\" of the RestaurantMenuCategoryComponents class");
            fieldGeneratorOtherMatches = new FieldHoldingArrayGeneratorOtherMatches("field \"OtherMatches\" of the RestaurantMenuCategoryComponents class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantMenuCategoryComponents class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorItemId = new FieldHoldingGeneratorItemId("field \"ItemId\" of the RestaurantMenuCategoryComponents class");
            fieldGeneratorCategoryComponentName = new JSONHoldingStringGenerator("field \"CategoryComponentName\" of the RestaurantMenuCategoryComponents class");
            fieldGeneratorTerrierExpression = new JSONHoldingStringGenerator("field \"TerrierExpression\" of the RestaurantMenuCategoryComponents class");
            fieldGeneratorOtherMatches = new FieldHoldingArrayGeneratorOtherMatches("field \"OtherMatches\" of the RestaurantMenuCategoryComponents class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantMenuCategoryComponents class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorItemId.reset();
            fieldGeneratorCategoryComponentName.reset();
            fieldGeneratorTerrierExpression.reset();
            fieldGeneratorOtherMatches.reset();
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
        protected override void handle_result(RestaurantMenuCategoryComponentsJSON  result)
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
        public RestaurantMenuCategoryComponentsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuCategoryComponentsJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuCategoryComponentsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuCategoryComponentsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuCategoryComponentsJSON>();
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
    public List<RestaurantMenuCategoryComponentsJSON> value;
  };
  };
