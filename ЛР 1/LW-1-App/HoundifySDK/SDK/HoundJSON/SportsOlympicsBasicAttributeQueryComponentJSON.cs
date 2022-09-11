/* file "SportsOlympicsBasicAttributeQueryComponentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsOlympicsBasicAttributeQueryComponentJSON : JSONBase
  {
    private bool flagHasType;
    private SportsOlympicsBasicAttributeTypeJSON  storeType;
    private bool flagHasGamesIndices;
    private List< BigInteger > storeGamesIndices;
    private bool flagHasError;
    private SportsOlympicsBasicAttributeErrorJSON  storeError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsBasicAttributeTypeJSON convert_classy = SportsOlympicsBasicAttributeTypeJSON.from_json(json_value, ignore_extras, true);
        setType(convert_classy);
      }


    private void  fromJSONGamesIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GamesIndices of SportsOlympicsBasicAttributeQueryComponentJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_GamesIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field GamesIndices of SportsOlympicsBasicAttributeQueryComponentJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field GamesIndices of SportsOlympicsBasicAttributeQueryComponentJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_GamesIndices1.Add(extracted_integer);
          }
        initGamesIndices();
        for (int num1 = 0; num1 < vector_GamesIndices1.Count; ++num1)
            appendGamesIndices(vector_GamesIndices1[num1]);
        for (int num1 = 0; num1 < vector_GamesIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsBasicAttributeErrorJSON convert_classy = SportsOlympicsBasicAttributeErrorJSON.from_json(json_value, ignore_extras, true);
        setError(convert_classy);
      }


    public SportsOlympicsBasicAttributeQueryComponentJSON()
      {
        flagHasType = false;
        flagHasGamesIndices = false;
        flagHasError = false;
        storeGamesIndices = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public SportsOlympicsBasicAttributeTypeJSON   getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public SportsOlympicsBasicAttributeTypeJSON.TypeValue  getTypeValue()
      {
        return getType().getValue();
      }

    public string  getTypeAsString()
      {
        return getType().getValueAsString();
      }

    public bool  hasGamesIndices()
      {
        return flagHasGamesIndices;
      }

    public int  countOfGamesIndices()
      {
        Debug.Assert(flagHasGamesIndices);
        return storeGamesIndices.Count;
      }

    public BigInteger  elementOfGamesIndices(int element_num)
      {
        Debug.Assert(flagHasGamesIndices);
        return storeGamesIndices[element_num];
      }

    public List< BigInteger >  getGamesIndices()
      {
        Debug.Assert(flagHasGamesIndices);
        return storeGamesIndices;
      }

    public bool  hasError()
      {
        return flagHasError;
      }

    public SportsOlympicsBasicAttributeErrorJSON   getError()
      {
        Debug.Assert(flagHasError);
        return storeError;
      }

    public SportsOlympicsBasicAttributeErrorJSON.TypeValue  getErrorValue()
      {
        return getError().getValue();
      }

    public string  getErrorAsString()
      {
        return getError().getValueAsString();
      }


    public virtual int extraSportsOlympicsBasicAttributeQueryComponentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsBasicAttributeQueryComponentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsBasicAttributeQueryComponentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsBasicAttributeQueryComponentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setType(SportsOlympicsBasicAttributeTypeJSON  new_value)
      {
        if (flagHasType)
          {
          }
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(SportsOlympicsBasicAttributeTypeJSON.TypeValue new_value)
      {
        setType(new SportsOlympicsBasicAttributeTypeJSON(new_value));
      }
    public void setType(string chars)
      {
        SportsOlympicsBasicAttributeTypeJSON.TypeValueKnownValues known = SportsOlympicsBasicAttributeTypeJSON.stringToValue(chars);
        SportsOlympicsBasicAttributeTypeJSON.TypeValue new_value = new SportsOlympicsBasicAttributeTypeJSON.TypeValue();
        if (known == SportsOlympicsBasicAttributeTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void unsetType()
      {
        if (flagHasType)
          {
          }
        flagHasType = false;
      }
    public void initGamesIndices()
      {
        flagHasGamesIndices = true;
        storeGamesIndices.Clear();
      }
    public void appendGamesIndices(BigInteger to_append)
      {
        if (!flagHasGamesIndices)
          {
            flagHasGamesIndices = true;
            storeGamesIndices.Clear();
          }
        Debug.Assert(flagHasGamesIndices);
        storeGamesIndices.Add(to_append);
      }
    public void unsetGamesIndices()
      {
        flagHasGamesIndices = false;
        storeGamesIndices.Clear();
      }
    public void setError(SportsOlympicsBasicAttributeErrorJSON  new_value)
      {
        if (flagHasError)
          {
          }
        flagHasError = true;
        storeError = new_value;
      }
    public void setError(SportsOlympicsBasicAttributeErrorJSON.TypeValue new_value)
      {
        setError(new SportsOlympicsBasicAttributeErrorJSON(new_value));
      }
    public void setError(string chars)
      {
        SportsOlympicsBasicAttributeErrorJSON.TypeValueKnownValues known = SportsOlympicsBasicAttributeErrorJSON.stringToValue(chars);
        SportsOlympicsBasicAttributeErrorJSON.TypeValue new_value = new SportsOlympicsBasicAttributeErrorJSON.TypeValue();
        if (known == SportsOlympicsBasicAttributeErrorJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setError(new_value);
      }
    public void unsetError()
      {
        if (flagHasError)
          {
          }
        flagHasError = false;
      }

    public virtual void extraSportsOlympicsBasicAttributeQueryComponentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsBasicAttributeQueryComponentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsBasicAttributeQueryComponentLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsBasicAttributeQueryComponentAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (partial_allowed)
                storeType.write_partial_as_json(handler);
            else
                storeType.write_as_json(handler);
          }
        if (flagHasGamesIndices)
          {
            handler.start_pair("GamesIndices");
            handler.start_array();
            for (int num1 = 0; num1 < storeGamesIndices.Count; ++num1)
              {
                handler.number_value(storeGamesIndices[num1]);
              }
            handler.finish_array();
          }
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (partial_allowed)
                storeError.write_partial_as_json(handler);
            else
                storeError.write_as_json(handler);
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsBasicAttributeQueryComponentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsBasicAttributeQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeQueryComponent", ignore_extras);
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
    public static SportsOlympicsBasicAttributeQueryComponentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsBasicAttributeQueryComponentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsBasicAttributeQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeQueryComponent", ignore_extras);
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
    public static SportsOlympicsBasicAttributeQueryComponentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsBasicAttributeQueryComponentJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsBasicAttributeQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeQueryComponent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsBasicAttributeQueryComponentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsBasicAttributeQueryComponentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsBasicAttributeQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeQueryComponent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsOlympicsBasicAttributeTypeJSON.HoldingGenerator fieldGeneratorType;
    private class FieldHoldingGeneratorGamesIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGamesIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGamesIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGamesIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorGamesIndices fieldGeneratorGamesIndices;
        private SportsOlympicsBasicAttributeErrorJSON.HoldingGenerator fieldGeneratorError;
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
            SportsOlympicsBasicAttributeQueryComponentJSON result = new SportsOlympicsBasicAttributeQueryComponentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsBasicAttributeQueryComponentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsBasicAttributeQueryComponentJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
              }
            if (fieldGeneratorGamesIndices.have_value)
              {
                result.initGamesIndices();
                int count = fieldGeneratorGamesIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGamesIndices(fieldGeneratorGamesIndices.value[num]);
                  }
                fieldGeneratorGamesIndices.value.Clear();
                fieldGeneratorGamesIndices.have_value = false;
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsBasicAttributeQueryComponentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "amesIndices", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorGamesIndices;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorType = new SportsOlympicsBasicAttributeTypeJSON.HoldingGenerator("field \"Type\" of the SportsOlympicsBasicAttributeQueryComponent class", ignore_extras);
            fieldGeneratorGamesIndices = new FieldHoldingArrayGeneratorGamesIndices("field \"GamesIndices\" of the SportsOlympicsBasicAttributeQueryComponent class");
            fieldGeneratorError = new SportsOlympicsBasicAttributeErrorJSON.HoldingGenerator("field \"Error\" of the SportsOlympicsBasicAttributeQueryComponent class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsBasicAttributeQueryComponent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new SportsOlympicsBasicAttributeTypeJSON.HoldingGenerator("field \"Type\" of the SportsOlympicsBasicAttributeQueryComponent class", false);
            fieldGeneratorGamesIndices = new FieldHoldingArrayGeneratorGamesIndices("field \"GamesIndices\" of the SportsOlympicsBasicAttributeQueryComponent class");
            fieldGeneratorError = new SportsOlympicsBasicAttributeErrorJSON.HoldingGenerator("field \"Error\" of the SportsOlympicsBasicAttributeQueryComponent class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsBasicAttributeQueryComponent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorGamesIndices.reset();
            fieldGeneratorError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorError.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorError.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsBasicAttributeQueryComponentJSON  result)
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
        public SportsOlympicsBasicAttributeQueryComponentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsBasicAttributeQueryComponentJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsBasicAttributeQueryComponentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsBasicAttributeQueryComponentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsBasicAttributeQueryComponentJSON>();
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
    public List<SportsOlympicsBasicAttributeQueryComponentJSON> value;
  };
  };
