/* file "ChemicalElementGroupJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ChemicalElementGroupJSON : JSONBase
  {
    private bool flagHasElements;
    private List< ChemicalElementJSON  > storeElements;
    private bool flagHasGroupNumber;
    private sbyte storeGroupNumber;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONElements(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Elements of ChemicalElementGroupJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Elements of ChemicalElementGroupJSON has too few elements.");
        List< ChemicalElementJSON  > vector_Elements1 = new List< ChemicalElementJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ChemicalElementJSON convert_classy = ChemicalElementJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Elements1.Add(convert_classy);
          }
        Debug.Assert(vector_Elements1.Count >= 1);
        initElements();
        for (int num1 = 0; num1 < vector_Elements1.Count; ++num1)
            appendElements(vector_Elements1[num1]);
        for (int num1 = 0; num1 < vector_Elements1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGroupNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GroupNumber of ChemicalElementGroupJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GroupNumber of ChemicalElementGroupJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setGroupNumber(extracted_integer);
      }


    public ChemicalElementGroupJSON()
      {
        flagHasElements = false;
        flagHasGroupNumber = false;
        storeElements = new List< ChemicalElementJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasElements()
      {
        return flagHasElements;
      }

    public int  countOfElements()
      {
        Debug.Assert(flagHasElements);
        return storeElements.Count;
      }

    public ChemicalElementJSON   elementOfElements(int element_num)
      {
        Debug.Assert(flagHasElements);
        return storeElements[element_num];
      }

    public List< ChemicalElementJSON  >  getElements()
      {
        Debug.Assert(flagHasElements);
        return storeElements;
      }

    public bool  hasGroupNumber()
      {
        return flagHasGroupNumber;
      }

    public sbyte  getGroupNumber()
      {
        Debug.Assert(flagHasGroupNumber);
        return storeGroupNumber;
      }


    public virtual int extraChemicalElementGroupComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraChemicalElementGroupComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraChemicalElementGroupComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraChemicalElementGroupLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initElements()
      {
        if (flagHasElements)
          {
            for (int num1 = 0; num1 < storeElements.Count; ++num1)
              {
              }
          }
        flagHasElements = true;
        storeElements.Clear();
      }
    public void appendElements(ChemicalElementJSON  to_append)
      {
        if (!flagHasElements)
          {
            flagHasElements = true;
            storeElements.Clear();
          }
        Debug.Assert(flagHasElements);
        storeElements.Add(to_append);
      }
    public void unsetElements()
      {
        if (flagHasElements)
          {
            for (int num2 = 0; num2 < storeElements.Count; ++num2)
              {
              }
          }
        flagHasElements = false;
        storeElements.Clear();
      }
    public void setGroupNumber(sbyte new_value)
      {
        flagHasGroupNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field GroupNumber of ChemicalElementGroupJSON is less than the lower bound (1) for that field.");
        if (new_value > 18)
            throw new Exception("The value for field GroupNumber of ChemicalElementGroupJSON is greater than the upper bound (18) for that field.");
        storeGroupNumber = new_value;
      }
    public void unsetGroupNumber()
      {
        flagHasGroupNumber = false;
      }

    public virtual void extraChemicalElementGroupAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraChemicalElementGroupSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraChemicalElementGroupLookup(key);
        if (old_field == null)
          {
            extraChemicalElementGroupAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasElements);
        if (flagHasElements)
          {
            handler.start_pair("Elements");
            Debug.Assert(storeElements.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeElements.Count; ++num1)
              {
                if (partial_allowed)
                    storeElements[num1].write_partial_as_json(handler);
                else
                    storeElements[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasGroupNumber);
        if (flagHasGroupNumber)
          {
            handler.start_pair("GroupNumber");
            handler.number_value(storeGroupNumber);
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
        if (!(hasElements()))
          {
            return "When parsing the object for %what%, the \"Elements\" field was missing.";
          }
        if (!(hasGroupNumber()))
          {
            return "When parsing the object for %what%, the \"GroupNumber\" field was missing.";
          }
        return null;
      }

    public static ChemicalElementGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChemicalElementGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementGroup", ignore_extras);
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
    public static ChemicalElementGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChemicalElementGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ChemicalElementGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementGroup", ignore_extras);
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
    public static ChemicalElementGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ChemicalElementGroupJSON from_text(string text, bool ignore_extras)
      {
        ChemicalElementGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementGroup", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ChemicalElementGroupJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ChemicalElementGroupJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ChemicalElementGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ChemicalElementGroup", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private ChemicalElementJSON.HoldingArrayGenerator fieldGeneratorElements;
    private class FieldHoldingGeneratorGroupNumber : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorGroupNumber(String what) : base(what, 1, 18)
              {
              }
          };
    private class FieldHoldingArrayGeneratorGroupNumber : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorGroupNumber(String what) : base(what, 1, 18)
              {
              }
          };
        private FieldHoldingGeneratorGroupNumber fieldGeneratorGroupNumber;
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
            ChemicalElementGroupJSON result = new ChemicalElementGroupJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraChemicalElementGroupAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ChemicalElementGroupJSON result)
          {
            if (fieldGeneratorElements.have_value)
              {
                result.initElements();
                int count = fieldGeneratorElements.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendElements(fieldGeneratorElements.value[num]);
                  }
                fieldGeneratorElements.value.Clear();
                fieldGeneratorElements.have_value = false;
              }
            else if ((!(result.hasElements())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Elements\" field was missing.");
              }
            if (fieldGeneratorGroupNumber.have_value)
              {
                result.setGroupNumber((sbyte)(fieldGeneratorGroupNumber.value));
                fieldGeneratorGroupNumber.have_value = false;
              }
            else if ((!(result.hasGroupNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"GroupNumber\" field was missing.");
              }
          }
        protected abstract void handle_result(ChemicalElementGroupJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "lements", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorElements;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "roupNumber", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorGroupNumber;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorElements = new ChemicalElementJSON.HoldingArrayGenerator("field \"Elements\" of the ChemicalElementGroup class", ignore_extras);
            fieldGeneratorGroupNumber = new FieldHoldingGeneratorGroupNumber("field \"GroupNumber\" of the ChemicalElementGroup class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ChemicalElementGroup class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorElements = new ChemicalElementJSON.HoldingArrayGenerator("field \"Elements\" of the ChemicalElementGroup class", false);
            fieldGeneratorGroupNumber = new FieldHoldingGeneratorGroupNumber("field \"GroupNumber\" of the ChemicalElementGroup class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ChemicalElementGroup class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorElements.reset();
            fieldGeneratorGroupNumber.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorElements.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorElements.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ChemicalElementGroupJSON  result)
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
        public ChemicalElementGroupJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ChemicalElementGroupJSON  result)
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
    protected virtual void handle_result(List<ChemicalElementGroupJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ChemicalElementGroupJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ChemicalElementGroupJSON>();
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
    public List<ChemicalElementGroupJSON> value;
  };
  };
