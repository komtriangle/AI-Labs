/* file "UnitConverterQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UnitConverterQueryStateJSON : JSONBase
  {
    public enum TypeUnitConverterCommandKind
      {
        UnitConverterCommandKind_UnitConverterCommand
      };

    public static TypeUnitConverterCommandKind  stringToUnitConverterCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "UnitConverterCommand", 0, 20, false) == 0) && (chars.Length == 20))
            return TypeUnitConverterCommandKind.UnitConverterCommandKind_UnitConverterCommand;
        throw new Exception("The value for field `UnitConverterCommandKind' is not one of the legal values.");
      }

    public static string  stringFromUnitConverterCommandKind(TypeUnitConverterCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeUnitConverterCommandKind.UnitConverterCommandKind_UnitConverterCommand:
                return "UnitConverterCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasUnitConverterCommandKind;
    private bool flagHasInputValue;
    private List< MeasuredAmountJSON  > storeInputValue;
    private bool flagHasOutputValue;
    private List< MeasuredAmountJSON  > storeOutputValue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUnitConverterCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UnitConverterCommandKind of UnitConverterQueryStateJSON is not a string.");
        if (!(json_string.getData().Equals("UnitConverterCommand")))
            throw new Exception("The value for field UnitConverterCommandKind of UnitConverterQueryStateJSON is not `UnitConverterCommand'.");
        setUnitConverterCommandKind();
      }


    private void  fromJSONInputValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputValue of UnitConverterQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MeasuredAmountJSON  > vector_InputValue1 = new List< MeasuredAmountJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MeasuredAmountJSON convert_classy = MeasuredAmountJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InputValue1.Add(convert_classy);
          }
        initInputValue();
        for (int num1 = 0; num1 < vector_InputValue1.Count; ++num1)
            appendInputValue(vector_InputValue1[num1]);
        for (int num1 = 0; num1 < vector_InputValue1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOutputValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OutputValue of UnitConverterQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MeasuredAmountJSON  > vector_OutputValue1 = new List< MeasuredAmountJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MeasuredAmountJSON convert_classy = MeasuredAmountJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_OutputValue1.Add(convert_classy);
          }
        initOutputValue();
        for (int num2 = 0; num2 < vector_OutputValue1.Count; ++num2)
            appendOutputValue(vector_OutputValue1[num2]);
        for (int num1 = 0; num1 < vector_OutputValue1.Count; ++num1)
          {
          }
      }


    public UnitConverterQueryStateJSON()
      {
        flagHasUnitConverterCommandKind = false;
        flagHasInputValue = false;
        flagHasOutputValue = false;
        storeInputValue = new List< MeasuredAmountJSON  >();
        storeOutputValue = new List< MeasuredAmountJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUnitConverterCommandKind()
      {
        return flagHasUnitConverterCommandKind;
      }

    public TypeUnitConverterCommandKind  getUnitConverterCommandKind()
      {
        Debug.Assert(flagHasUnitConverterCommandKind);
        return TypeUnitConverterCommandKind.UnitConverterCommandKind_UnitConverterCommand;
      }

    public string  getUnitConverterCommandKindAsString()
      {
        return stringFromUnitConverterCommandKind(getUnitConverterCommandKind());
      }

    public bool  hasInputValue()
      {
        return flagHasInputValue;
      }

    public int  countOfInputValue()
      {
        Debug.Assert(flagHasInputValue);
        return storeInputValue.Count;
      }

    public MeasuredAmountJSON   elementOfInputValue(int element_num)
      {
        Debug.Assert(flagHasInputValue);
        return storeInputValue[element_num];
      }

    public List< MeasuredAmountJSON  >  getInputValue()
      {
        Debug.Assert(flagHasInputValue);
        return storeInputValue;
      }

    public bool  hasOutputValue()
      {
        return flagHasOutputValue;
      }

    public int  countOfOutputValue()
      {
        Debug.Assert(flagHasOutputValue);
        return storeOutputValue.Count;
      }

    public MeasuredAmountJSON   elementOfOutputValue(int element_num)
      {
        Debug.Assert(flagHasOutputValue);
        return storeOutputValue[element_num];
      }

    public List< MeasuredAmountJSON  >  getOutputValue()
      {
        Debug.Assert(flagHasOutputValue);
        return storeOutputValue;
      }


    public virtual int extraUnitConverterQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUnitConverterQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUnitConverterQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUnitConverterQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setUnitConverterCommandKind()
      {
        flagHasUnitConverterCommandKind = true;
      }
    public void setUnitConverterCommandKind(TypeUnitConverterCommandKind new_value)
      {
        setUnitConverterCommandKind();
      }
    public void setUnitConverterCommandKind(string chars)
      {
        setUnitConverterCommandKind(stringToUnitConverterCommandKind(chars));
      }
    public void unsetUnitConverterCommandKind()
      {
        flagHasUnitConverterCommandKind = false;
      }
    public void initInputValue()
      {
        if (flagHasInputValue)
          {
            for (int num1 = 0; num1 < storeInputValue.Count; ++num1)
              {
              }
          }
        flagHasInputValue = true;
        storeInputValue.Clear();
      }
    public void appendInputValue(MeasuredAmountJSON  to_append)
      {
        if (!flagHasInputValue)
          {
            flagHasInputValue = true;
            storeInputValue.Clear();
          }
        Debug.Assert(flagHasInputValue);
        storeInputValue.Add(to_append);
      }
    public void unsetInputValue()
      {
        if (flagHasInputValue)
          {
            for (int num2 = 0; num2 < storeInputValue.Count; ++num2)
              {
              }
          }
        flagHasInputValue = false;
        storeInputValue.Clear();
      }
    public void initOutputValue()
      {
        if (flagHasOutputValue)
          {
            for (int num3 = 0; num3 < storeOutputValue.Count; ++num3)
              {
              }
          }
        flagHasOutputValue = true;
        storeOutputValue.Clear();
      }
    public void appendOutputValue(MeasuredAmountJSON  to_append)
      {
        if (!flagHasOutputValue)
          {
            flagHasOutputValue = true;
            storeOutputValue.Clear();
          }
        Debug.Assert(flagHasOutputValue);
        storeOutputValue.Add(to_append);
      }
    public void unsetOutputValue()
      {
        if (flagHasOutputValue)
          {
            for (int num4 = 0; num4 < storeOutputValue.Count; ++num4)
              {
              }
          }
        flagHasOutputValue = false;
        storeOutputValue.Clear();
      }

    public virtual void extraUnitConverterQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUnitConverterQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUnitConverterQueryStateLookup(key);
        if (old_field == null)
          {
            extraUnitConverterQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUnitConverterCommandKind);
        if (flagHasUnitConverterCommandKind)
          {
            handler.start_pair("UnitConverterCommandKind");
            handler.string_value("UnitConverterCommand");
          }
        Debug.Assert(partial_allowed || flagHasInputValue);
        if (flagHasInputValue)
          {
            handler.start_pair("InputValue");
            handler.start_array();
            for (int num1 = 0; num1 < storeInputValue.Count; ++num1)
              {
                if (partial_allowed)
                    storeInputValue[num1].write_partial_as_json(handler);
                else
                    storeInputValue[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasOutputValue);
        if (flagHasOutputValue)
          {
            handler.start_pair("OutputValue");
            handler.start_array();
            for (int num2 = 0; num2 < storeOutputValue.Count; ++num2)
              {
                if (partial_allowed)
                    storeOutputValue[num2].write_partial_as_json(handler);
                else
                    storeOutputValue[num2].write_as_json(handler);
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
        if (!(hasUnitConverterCommandKind()))
          {
            return "When parsing the object for %what%, the \"UnitConverterCommandKind\" field was missing.";
          }
        if (!(hasInputValue()))
          {
            return "When parsing the object for %what%, the \"InputValue\" field was missing.";
          }
        if (!(hasOutputValue()))
          {
            return "When parsing the object for %what%, the \"OutputValue\" field was missing.";
          }
        return null;
      }

    public static UnitConverterQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConverterQueryState", ignore_extras);
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
    public static UnitConverterQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UnitConverterQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConverterQueryState", ignore_extras);
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
    public static UnitConverterQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UnitConverterQueryStateJSON from_text(string text, bool ignore_extras)
      {
        UnitConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConverterQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UnitConverterQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UnitConverterQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UnitConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConverterQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorUnitConverterCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorUnitConverterCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorUnitConverterCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToUnitConverterCommandKind(result));
              }
            protected abstract void handle_result(TypeUnitConverterCommandKind result);
          };
    private class FieldHoldingGeneratorUnitConverterCommandKind : FieldGeneratorUnitConverterCommandKind
  {
    protected override void handle_result(TypeUnitConverterCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorUnitConverterCommandKind(String what)
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
    public TypeUnitConverterCommandKind value;
  };
    private class FieldHoldingArrayGeneratorUnitConverterCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorUnitConverterCommandKind
      {
        private FieldHoldingArrayGeneratorUnitConverterCommandKind top;

        protected override void handle_result(TypeUnitConverterCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorUnitConverterCommandKind init_top)
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
    protected virtual void handle_result(List<TypeUnitConverterCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorUnitConverterCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnitConverterCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorUnitConverterCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnitConverterCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeUnitConverterCommandKind> value;
  };
        private FieldHoldingGeneratorUnitConverterCommandKind fieldGeneratorUnitConverterCommandKind;
        private MeasuredAmountJSON.HoldingArrayGenerator fieldGeneratorInputValue;
        private MeasuredAmountJSON.HoldingArrayGenerator fieldGeneratorOutputValue;
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
            UnitConverterQueryStateJSON result = new UnitConverterQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUnitConverterQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UnitConverterQueryStateJSON result)
          {
            if (fieldGeneratorUnitConverterCommandKind.have_value)
              {
                result.setUnitConverterCommandKind();
                fieldGeneratorUnitConverterCommandKind.have_value = false;
              }
            else if ((!(result.hasUnitConverterCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UnitConverterCommandKind\" field was missing.");
              }
            if (fieldGeneratorInputValue.have_value)
              {
                result.initInputValue();
                int count = fieldGeneratorInputValue.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInputValue(fieldGeneratorInputValue.value[num]);
                  }
                fieldGeneratorInputValue.value.Clear();
                fieldGeneratorInputValue.have_value = false;
              }
            else if ((!(result.hasInputValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InputValue\" field was missing.");
              }
            if (fieldGeneratorOutputValue.have_value)
              {
                result.initOutputValue();
                int count = fieldGeneratorOutputValue.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOutputValue(fieldGeneratorOutputValue.value[num]);
                  }
                fieldGeneratorOutputValue.value.Clear();
                fieldGeneratorOutputValue.have_value = false;
              }
            else if ((!(result.hasOutputValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OutputValue\" field was missing.");
              }
          }
        protected abstract void handle_result(UnitConverterQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "nputValue", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorInputValue;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utputValue", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorOutputValue;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nitConverterCommandKind", 0, 23, false) == 0) && (field_name.Length == 24))
                        return fieldGeneratorUnitConverterCommandKind;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorUnitConverterCommandKind = new FieldHoldingGeneratorUnitConverterCommandKind("field \"UnitConverterCommandKind\" of the UnitConverterQueryState class");
            fieldGeneratorInputValue = new MeasuredAmountJSON.HoldingArrayGenerator("field \"InputValue\" of the UnitConverterQueryState class", ignore_extras);
            fieldGeneratorOutputValue = new MeasuredAmountJSON.HoldingArrayGenerator("field \"OutputValue\" of the UnitConverterQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UnitConverterQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUnitConverterCommandKind = new FieldHoldingGeneratorUnitConverterCommandKind("field \"UnitConverterCommandKind\" of the UnitConverterQueryState class");
            fieldGeneratorInputValue = new MeasuredAmountJSON.HoldingArrayGenerator("field \"InputValue\" of the UnitConverterQueryState class", false);
            fieldGeneratorOutputValue = new MeasuredAmountJSON.HoldingArrayGenerator("field \"OutputValue\" of the UnitConverterQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UnitConverterQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUnitConverterCommandKind.reset();
            fieldGeneratorInputValue.reset();
            fieldGeneratorOutputValue.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorInputValue.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputValue.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorInputValue.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputValue.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UnitConverterQueryStateJSON  result)
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
        public UnitConverterQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UnitConverterQueryStateJSON  result)
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
    protected virtual void handle_result(List<UnitConverterQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UnitConverterQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UnitConverterQueryStateJSON>();
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
    public List<UnitConverterQueryStateJSON> value;
  };
  };
