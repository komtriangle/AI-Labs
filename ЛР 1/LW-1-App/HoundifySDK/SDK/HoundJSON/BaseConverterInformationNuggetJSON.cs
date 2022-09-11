/* file "BaseConverterInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BaseConverterInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasConversionRows;
    private List< ConversionRowJSON  > storeConversionRows;
    private bool flagHasErrorMessage;
    private string storeErrorMessage;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraConversionRowsToJSON()
      {
        JSONArrayValue generated_array_1_ConversionRows = new JSONArrayValue();
        for (int num1 = 0; num1 < storeConversionRows.Count; ++num1)
          {
            JSONValueHandler handler_ConversionRows = new JSONValueHandler();
            storeConversionRows[num1].write_as_json(handler_ConversionRows);
            generated_array_1_ConversionRows.appendComponent(handler_ConversionRows.result);
          }
        return generated_array_1_ConversionRows;
      }

    private JSONValue  extraErrorMessageToJSON()
      {
        JSONStringValue generated_string_ErrorMessage = new JSONStringValue(storeErrorMessage);
        return generated_string_ErrorMessage;
      }


    private void  fromJSONConversionRows(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ConversionRows of BaseConverterInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< ConversionRowJSON  > vector_ConversionRows1 = new List< ConversionRowJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ConversionRowJSON convert_classy = ConversionRowJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ConversionRows1.Add(convert_classy);
          }
        initConversionRows();
        for (int num1 = 0; num1 < vector_ConversionRows1.Count; ++num1)
            appendConversionRows(vector_ConversionRows1[num1]);
        for (int num1 = 0; num1 < vector_ConversionRows1.Count; ++num1)
          {
          }
      }


    private void  fromJSONErrorMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorMessage of BaseConverterInformationNuggetJSON is not a string.");
        setErrorMessage(json_string.getData());
      }


    public BaseConverterInformationNuggetJSON()
      {
        flagHasConversionRows = false;
        flagHasErrorMessage = false;
        storeConversionRows = new List< ConversionRowJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "BaseConverter";
      }

    public bool  hasConversionRows()
      {
        return flagHasConversionRows;
      }

    public int  countOfConversionRows()
      {
        Debug.Assert(flagHasConversionRows);
        return storeConversionRows.Count;
      }

    public ConversionRowJSON   elementOfConversionRows(int element_num)
      {
        Debug.Assert(flagHasConversionRows);
        return storeConversionRows[element_num];
      }

    public List< ConversionRowJSON  >  getConversionRows()
      {
        Debug.Assert(flagHasConversionRows);
        return storeConversionRows;
      }

    public bool  hasErrorMessage()
      {
        return flagHasErrorMessage;
      }

    public string  getErrorMessage()
      {
        Debug.Assert(flagHasErrorMessage);
        return storeErrorMessage;
      }


    public virtual int extraBaseConverterInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBaseConverterInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBaseConverterInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBaseConverterInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasConversionRows)
            ++result;
        if (flagHasErrorMessage)
            ++result;
        result += extraBaseConverterInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasConversionRows)
          {
            if (remainder == 0)
                return "ConversionRows";
            --remainder;
          }
        if (flagHasErrorMessage)
          {
            if (remainder == 0)
                return "ErrorMessage";
            --remainder;
          }
        return extraBaseConverterInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasConversionRows)
          {
            if (remainder == 0)
                return extraConversionRowsToJSON();
            --remainder;
          }
        if (flagHasErrorMessage)
          {
            if (remainder == 0)
                return extraErrorMessageToJSON();
            --remainder;
          }
        return extraBaseConverterInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "onversionRows", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasConversionRows ? extraConversionRowsToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasErrorMessage ? extraErrorMessageToJSON() : null);
                break;
            default:
                break;
          }
        return extraBaseConverterInformationNuggetLookup(field_name);
      }

    public void initConversionRows()
      {
        if (flagHasConversionRows)
          {
            for (int num1 = 0; num1 < storeConversionRows.Count; ++num1)
              {
              }
          }
        flagHasConversionRows = true;
        storeConversionRows.Clear();
      }
    public void appendConversionRows(ConversionRowJSON  to_append)
      {
        if (!flagHasConversionRows)
          {
            flagHasConversionRows = true;
            storeConversionRows.Clear();
          }
        Debug.Assert(flagHasConversionRows);
        storeConversionRows.Add(to_append);
      }
    public void unsetConversionRows()
      {
        if (flagHasConversionRows)
          {
            for (int num2 = 0; num2 < storeConversionRows.Count; ++num2)
              {
              }
          }
        flagHasConversionRows = false;
        storeConversionRows.Clear();
      }
    public void setErrorMessage(string new_value)
      {
        flagHasErrorMessage = true;
        storeErrorMessage = new_value;
      }
    public void unsetErrorMessage()
      {
        flagHasErrorMessage = false;
      }

    public virtual void extraBaseConverterInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBaseConverterInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBaseConverterInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraBaseConverterInformationNuggetAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "onversionRows", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONConversionRows(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "rrorMessage", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONErrorMessage(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBaseConverterInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "onversionRows", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONConversionRows(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "rrorMessage", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONErrorMessage(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBaseConverterInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasConversionRows);
        if (flagHasConversionRows)
          {
            handler.start_pair("ConversionRows");
            handler.start_array();
            for (int num1 = 0; num1 < storeConversionRows.Count; ++num1)
              {
                if (partial_allowed)
                    storeConversionRows[num1].write_partial_as_json(handler);
                else
                    storeConversionRows[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasErrorMessage)
          {
            handler.start_pair("ErrorMessage");
            handler.string_value(storeErrorMessage);
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
        if (!(hasConversionRows()))
          {
            return "When parsing the object for %what%, the \"ConversionRows\" field was missing.";
          }
        return null;
      }

    public static new BaseConverterInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BaseConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BaseConverterInformationNugget", ignore_extras);
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
    public static new BaseConverterInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BaseConverterInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BaseConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BaseConverterInformationNugget", ignore_extras);
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
    public static new BaseConverterInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BaseConverterInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        BaseConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BaseConverterInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BaseConverterInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new BaseConverterInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BaseConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BaseConverterInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private ConversionRowJSON.HoldingArrayGenerator fieldGeneratorConversionRows;
        private JSONHoldingStringGenerator fieldGeneratorErrorMessage;
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
            if (!(getInformationNuggetJSONKey().Equals("BaseConverter")))
                throw new Exception("The key field has a value other than `BaseConverter'.");
            BaseConverterInformationNuggetJSON result = new BaseConverterInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBaseConverterInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((BaseConverterInformationNuggetJSON )new_result);
          }
        protected void finish(BaseConverterInformationNuggetJSON result)
          {
            if (fieldGeneratorConversionRows.have_value)
              {
                result.initConversionRows();
                int count = fieldGeneratorConversionRows.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendConversionRows(fieldGeneratorConversionRows.value[num]);
                  }
                fieldGeneratorConversionRows.value.Clear();
                fieldGeneratorConversionRows.have_value = false;
              }
            else if ((!(result.hasConversionRows())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ConversionRows\" field was missing.");
              }
            if (fieldGeneratorErrorMessage.have_value)
              {
                result.setErrorMessage(fieldGeneratorErrorMessage.value);
                fieldGeneratorErrorMessage.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(BaseConverterInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "onversionRows", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorConversionRows;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorErrorMessage;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorConversionRows = new ConversionRowJSON.HoldingArrayGenerator("field \"ConversionRows\" of the BaseConverterInformationNugget class", ignore_extras);
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the BaseConverterInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BaseConverterInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorConversionRows = new ConversionRowJSON.HoldingArrayGenerator("field \"ConversionRows\" of the BaseConverterInformationNugget class", false);
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the BaseConverterInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BaseConverterInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorConversionRows.reset();
            fieldGeneratorErrorMessage.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(BaseConverterInformationNuggetJSON  result)
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
        public BaseConverterInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BaseConverterInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<BaseConverterInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BaseConverterInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BaseConverterInformationNuggetJSON>();
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
    public List<BaseConverterInformationNuggetJSON> value;
  };
  };
