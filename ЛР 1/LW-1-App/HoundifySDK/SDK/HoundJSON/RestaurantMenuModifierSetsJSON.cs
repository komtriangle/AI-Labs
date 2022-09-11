/* file "RestaurantMenuModifierSetsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RestaurantMenuModifierSetsJSON : JSONBase
  {
    private bool flagHasModifierType;
    private string storeModifierType;
    private bool flagHasModifierTypeSpoken;
    private string storeModifierTypeSpoken;
    private bool flagHasMin;
    private BigInteger storeMin;
    private bool flagHasMax;
    private BigInteger storeMax;
    private bool flagHasModifierList;
    private List< BigInteger > storeModifierList;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONModifierType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ModifierType of RestaurantMenuModifierSetsJSON is not a string.");
        setModifierType(json_string.getData());
      }


    private void  fromJSONModifierTypeSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ModifierTypeSpoken of RestaurantMenuModifierSetsJSON is not a string.");
        setModifierTypeSpoken(json_string.getData());
      }


    private void  fromJSONMin(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Min of RestaurantMenuModifierSetsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Min of RestaurantMenuModifierSetsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMin(extracted_integer);
      }


    private void  fromJSONMax(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Max of RestaurantMenuModifierSetsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Max of RestaurantMenuModifierSetsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMax(extracted_integer);
      }


    private void  fromJSONModifierList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ModifierList of RestaurantMenuModifierSetsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_ModifierList1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field ModifierList of RestaurantMenuModifierSetsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field ModifierList of RestaurantMenuModifierSetsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_ModifierList1.Add(extracted_integer);
          }
        initModifierList();
        for (int num1 = 0; num1 < vector_ModifierList1.Count; ++num1)
            appendModifierList(vector_ModifierList1[num1]);
        for (int num1 = 0; num1 < vector_ModifierList1.Count; ++num1)
          {
          }
      }


    public RestaurantMenuModifierSetsJSON()
      {
        flagHasModifierType = false;
        flagHasModifierTypeSpoken = false;
        flagHasMin = false;
        flagHasMax = false;
        flagHasModifierList = false;
        storeModifierList = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasModifierType()
      {
        return flagHasModifierType;
      }

    public string  getModifierType()
      {
        Debug.Assert(flagHasModifierType);
        return storeModifierType;
      }

    public bool  hasModifierTypeSpoken()
      {
        return flagHasModifierTypeSpoken;
      }

    public string  getModifierTypeSpoken()
      {
        Debug.Assert(flagHasModifierTypeSpoken);
        return storeModifierTypeSpoken;
      }

    public bool  hasMin()
      {
        return flagHasMin;
      }

    public BigInteger  getMin()
      {
        Debug.Assert(flagHasMin);
        return storeMin;
      }

    public bool  hasMax()
      {
        return flagHasMax;
      }

    public BigInteger  getMax()
      {
        Debug.Assert(flagHasMax);
        return storeMax;
      }

    public bool  hasModifierList()
      {
        return flagHasModifierList;
      }

    public int  countOfModifierList()
      {
        Debug.Assert(flagHasModifierList);
        return storeModifierList.Count;
      }

    public BigInteger  elementOfModifierList(int element_num)
      {
        Debug.Assert(flagHasModifierList);
        return storeModifierList[element_num];
      }

    public List< BigInteger >  getModifierList()
      {
        Debug.Assert(flagHasModifierList);
        return storeModifierList;
      }


    public virtual int extraRestaurantMenuModifierSetsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantMenuModifierSetsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantMenuModifierSetsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantMenuModifierSetsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setModifierType(string new_value)
      {
        flagHasModifierType = true;
        storeModifierType = new_value;
      }
    public void unsetModifierType()
      {
        flagHasModifierType = false;
      }
    public void setModifierTypeSpoken(string new_value)
      {
        flagHasModifierTypeSpoken = true;
        storeModifierTypeSpoken = new_value;
      }
    public void unsetModifierTypeSpoken()
      {
        flagHasModifierTypeSpoken = false;
      }
    public void setMin(BigInteger new_value)
      {
        flagHasMin = true;
        storeMin = new_value;
      }
    public void unsetMin()
      {
        flagHasMin = false;
      }
    public void setMax(BigInteger new_value)
      {
        flagHasMax = true;
        storeMax = new_value;
      }
    public void unsetMax()
      {
        flagHasMax = false;
      }
    public void initModifierList()
      {
        flagHasModifierList = true;
        storeModifierList.Clear();
      }
    public void appendModifierList(BigInteger to_append)
      {
        if (!flagHasModifierList)
          {
            flagHasModifierList = true;
            storeModifierList.Clear();
          }
        Debug.Assert(flagHasModifierList);
        storeModifierList.Add(to_append);
      }
    public void unsetModifierList()
      {
        flagHasModifierList = false;
        storeModifierList.Clear();
      }

    public virtual void extraRestaurantMenuModifierSetsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantMenuModifierSetsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantMenuModifierSetsLookup(key);
        if (old_field == null)
          {
            extraRestaurantMenuModifierSetsAppendPair(key, new_component);
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
        if (flagHasModifierType)
          {
            handler.start_pair("ModifierType");
            handler.string_value(storeModifierType);
          }
        if (flagHasModifierTypeSpoken)
          {
            handler.start_pair("ModifierTypeSpoken");
            handler.string_value(storeModifierTypeSpoken);
          }
        Debug.Assert(partial_allowed || flagHasMin);
        if (flagHasMin)
          {
            handler.start_pair("Min");
            handler.number_value(storeMin);
          }
        if (flagHasMax)
          {
            handler.start_pair("Max");
            handler.number_value(storeMax);
          }
        if (flagHasModifierList)
          {
            handler.start_pair("ModifierList");
            handler.start_array();
            for (int num1 = 0; num1 < storeModifierList.Count; ++num1)
              {
                handler.number_value(storeModifierList[num1]);
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
        if (!(hasMin()))
          {
            return "When parsing the object for %what%, the \"Min\" field was missing.";
          }
        return null;
      }

    public static RestaurantMenuModifierSetsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuModifierSetsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuModifierSets", ignore_extras);
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
    public static RestaurantMenuModifierSetsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuModifierSetsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuModifierSetsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuModifierSets", ignore_extras);
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
    public static RestaurantMenuModifierSetsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuModifierSetsJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuModifierSetsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuModifierSets", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuModifierSetsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuModifierSetsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuModifierSetsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuModifierSets", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorModifierType;
        private JSONHoldingStringGenerator fieldGeneratorModifierTypeSpoken;
    private class FieldHoldingGeneratorMin : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorMin(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorMin : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorMin(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorMin fieldGeneratorMin;
    private class FieldHoldingGeneratorMax : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorMax(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorMax : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorMax(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorMax fieldGeneratorMax;
    private class FieldHoldingGeneratorModifierList : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorModifierList(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorModifierList : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorModifierList(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorModifierList fieldGeneratorModifierList;
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
            RestaurantMenuModifierSetsJSON result = new RestaurantMenuModifierSetsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantMenuModifierSetsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantMenuModifierSetsJSON result)
          {
            if (fieldGeneratorModifierType.have_value)
              {
                result.setModifierType(fieldGeneratorModifierType.value);
                fieldGeneratorModifierType.have_value = false;
              }
            if (fieldGeneratorModifierTypeSpoken.have_value)
              {
                result.setModifierTypeSpoken(fieldGeneratorModifierTypeSpoken.value);
                fieldGeneratorModifierTypeSpoken.have_value = false;
              }
            if (fieldGeneratorMin.have_value)
              {
                result.setMin(fieldGeneratorMin.value);
                fieldGeneratorMin.have_value = false;
              }
            else if ((!(result.hasMin())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Min\" field was missing.");
              }
            if (fieldGeneratorMax.have_value)
              {
                result.setMax(fieldGeneratorMax.value);
                fieldGeneratorMax.have_value = false;
              }
            if (fieldGeneratorModifierList.have_value)
              {
                result.initModifierList();
                int count = fieldGeneratorModifierList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendModifierList(fieldGeneratorModifierList.value[num]);
                  }
                fieldGeneratorModifierList.value.Clear();
                fieldGeneratorModifierList.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantMenuModifierSetsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "M", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "x", 0, 1, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorMax;
                        break;
                    case 'i':
                        if ((String.Compare(field_name, 2, "n", 0, 1, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorMin;
                        break;
                    case 'o':
                        if (String.Compare(field_name, 2, "difier", 0, 6, false) == 0)
                          {
                            switch (field_name[8])
                              {
                                case 'L':
                                    if ((String.Compare(field_name, 9, "ist", 0, 3, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorModifierList;
                                    break;
                                case 'T':
                                    if (String.Compare(field_name, 9, "ype", 0, 3, false) == 0)
                                      {
                                        if (field_name.Length == 12)
                                          {
                                            return fieldGeneratorModifierType;
                                          }
                                        switch (field_name[12])
                                          {
                                            case 'S':
                                                if ((String.Compare(field_name, 13, "poken", 0, 5, false) == 0) && (field_name.Length == 18))
                                                    return fieldGeneratorModifierTypeSpoken;
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
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorModifierType = new JSONHoldingStringGenerator("field \"ModifierType\" of the RestaurantMenuModifierSets class");
            fieldGeneratorModifierTypeSpoken = new JSONHoldingStringGenerator("field \"ModifierTypeSpoken\" of the RestaurantMenuModifierSets class");
            fieldGeneratorMin = new FieldHoldingGeneratorMin("field \"Min\" of the RestaurantMenuModifierSets class");
            fieldGeneratorMax = new FieldHoldingGeneratorMax("field \"Max\" of the RestaurantMenuModifierSets class");
            fieldGeneratorModifierList = new FieldHoldingArrayGeneratorModifierList("field \"ModifierList\" of the RestaurantMenuModifierSets class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantMenuModifierSets class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorModifierType = new JSONHoldingStringGenerator("field \"ModifierType\" of the RestaurantMenuModifierSets class");
            fieldGeneratorModifierTypeSpoken = new JSONHoldingStringGenerator("field \"ModifierTypeSpoken\" of the RestaurantMenuModifierSets class");
            fieldGeneratorMin = new FieldHoldingGeneratorMin("field \"Min\" of the RestaurantMenuModifierSets class");
            fieldGeneratorMax = new FieldHoldingGeneratorMax("field \"Max\" of the RestaurantMenuModifierSets class");
            fieldGeneratorModifierList = new FieldHoldingArrayGeneratorModifierList("field \"ModifierList\" of the RestaurantMenuModifierSets class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantMenuModifierSets class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorModifierType.reset();
            fieldGeneratorModifierTypeSpoken.reset();
            fieldGeneratorMin.reset();
            fieldGeneratorMax.reset();
            fieldGeneratorModifierList.reset();
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
        protected override void handle_result(RestaurantMenuModifierSetsJSON  result)
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
        public RestaurantMenuModifierSetsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuModifierSetsJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuModifierSetsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuModifierSetsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuModifierSetsJSON>();
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
    public List<RestaurantMenuModifierSetsJSON> value;
  };
  };
