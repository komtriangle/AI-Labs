/* file "SportsStatsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStatsInformationNuggetJSON : SportsInformationNuggetJSON
  {
    public enum TypeErrorKnownValues
      {
        Error_ResolutionError,
        Error__none
      };
    public struct TypeError
      {
        public bool in_known_list;
        public string string_value;
        public TypeErrorKnownValues list_value;
      };

    public static TypeErrorKnownValues  stringToError(string chars)
      {
        if ((String.Compare(chars, 0, "ResolutionError", 0, 15, false) == 0) && (chars.Length == 15))
            return TypeErrorKnownValues.Error_ResolutionError;
        return TypeErrorKnownValues.Error__none;
      }

    public static string  stringFromError(TypeErrorKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeErrorKnownValues.Error_ResolutionError:
                return "ResolutionError";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQueryData;
    private List< SportsStatsQueryDataJSON  > storeQueryData;
    private bool flagHasError;
    private TypeError storeError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQueryDataToJSON()
      {
        JSONArrayValue generated_array_1_QueryData = new JSONArrayValue();
        for (int num1 = 0; num1 < storeQueryData.Count; ++num1)
          {
            JSONValueHandler handler_QueryData = new JSONValueHandler();
            storeQueryData[num1].write_as_json(handler_QueryData);
            generated_array_1_QueryData.appendComponent(handler_QueryData.result);
          }
        return generated_array_1_QueryData;
      }

    private JSONValue  extraErrorToJSON()
      {
        JSONStringValue generated_string_Error;
        if (!(storeError.in_known_list))
          {
        generated_string_Error = new JSONStringValue(storeError.string_value);
          }
        else
          {
        switch (storeError.list_value)
          {
            case TypeErrorKnownValues.Error_ResolutionError:
                generated_string_Error = new JSONStringValue("ResolutionError");
                break;
            default:
                Debug.Assert(false);
                generated_string_Error = null;
                break;
          }
          }
        return generated_string_Error;
      }


    private void  fromJSONQueryData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryData of SportsStatsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsStatsQueryDataJSON  > vector_QueryData1 = new List< SportsStatsQueryDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsStatsQueryDataJSON convert_classy = SportsStatsQueryDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueryData1.Add(convert_classy);
          }
        initQueryData();
        for (int num1 = 0; num1 < vector_QueryData1.Count; ++num1)
            appendQueryData(vector_QueryData1[num1]);
        for (int num1 = 0; num1 < vector_QueryData1.Count; ++num1)
          {
          }
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Error of SportsStatsInformationNuggetJSON is not a string.");
        TypeError the_open_enum = new TypeError();
        if ((String.Compare(json_string.getData(), 0, "ResolutionError", 0, 15, false) == 0) && (json_string.getData().Length == 15))
              {
                the_open_enum.in_known_list = true;
                the_open_enum.list_value = TypeErrorKnownValues.Error_ResolutionError;
                goto open_enum_is_done;
              }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setError(the_open_enum);
      }


    public SportsStatsInformationNuggetJSON()
      {
        flagHasQueryData = false;
        flagHasError = false;
        storeQueryData = new List< SportsStatsQueryDataJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsNuggetKind()
      {
        return "SportsStats";
      }

    public bool  hasQueryData()
      {
        return flagHasQueryData;
      }

    public int  countOfQueryData()
      {
        Debug.Assert(flagHasQueryData);
        return storeQueryData.Count;
      }

    public SportsStatsQueryDataJSON   elementOfQueryData(int element_num)
      {
        Debug.Assert(flagHasQueryData);
        return storeQueryData[element_num];
      }

    public List< SportsStatsQueryDataJSON  >  getQueryData()
      {
        Debug.Assert(flagHasQueryData);
        return storeQueryData;
      }

    public bool  hasError()
      {
        return flagHasError;
      }

    public TypeError  getError()
      {
        Debug.Assert(flagHasError);
        return storeError;
      }

    public string  getErrorAsString()
      {
        TypeError result = getError();
        if (result.in_known_list)
            return stringFromError(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSportsStatsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStatsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStatsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStatsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasQueryData)
            ++result;
        if (flagHasError)
            ++result;
        result += extraSportsStatsInformationNuggetComponentCount();
        return result;
      }
    public override string extraSportsInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryData)
          {
            if (remainder == 0)
                return "QueryData";
            --remainder;
          }
        if (flagHasError)
          {
            if (remainder == 0)
                return "Error";
            --remainder;
          }
        return extraSportsStatsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraSportsInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryData)
          {
            if (remainder == 0)
                return extraQueryDataToJSON();
            --remainder;
          }
        if (flagHasError)
          {
            if (remainder == 0)
                return extraErrorToJSON();
            --remainder;
          }
        return extraSportsStatsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraSportsInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasError ? extraErrorToJSON() : null);
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryData", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasQueryData ? extraQueryDataToJSON() : null);
                break;
            default:
                break;
          }
        return extraSportsStatsInformationNuggetLookup(field_name);
      }

    public void initQueryData()
      {
        if (flagHasQueryData)
          {
            for (int num1 = 0; num1 < storeQueryData.Count; ++num1)
              {
              }
          }
        flagHasQueryData = true;
        storeQueryData.Clear();
      }
    public void appendQueryData(SportsStatsQueryDataJSON  to_append)
      {
        if (!flagHasQueryData)
          {
            flagHasQueryData = true;
            storeQueryData.Clear();
          }
        Debug.Assert(flagHasQueryData);
        storeQueryData.Add(to_append);
      }
    public void unsetQueryData()
      {
        if (flagHasQueryData)
          {
            for (int num2 = 0; num2 < storeQueryData.Count; ++num2)
              {
              }
          }
        flagHasQueryData = false;
        storeQueryData.Clear();
      }
    public void setError(TypeError new_value)
      {
        flagHasError = true;
        storeError = new_value;
      }
    public void setError(string chars)
      {
        TypeErrorKnownValues known = stringToError(chars);
        TypeError new_value = new TypeError();
        if (known == TypeErrorKnownValues.Error__none)
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
    public void setError(TypeErrorKnownValues new_value)
      {
        TypeError new_full_value = new TypeError();
        Debug.Assert(new_value != TypeErrorKnownValues.Error__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setError(new_full_value);
      }
    public void unsetError()
      {
        flagHasError = false;
      }

    public virtual void extraSportsStatsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStatsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStatsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraSportsStatsInformationNuggetAppendPair(key, new_component);
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
    public override void extraSportsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rror", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONError(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryData", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONQueryData(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSportsStatsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraSportsInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rror", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONError(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryData", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONQueryData(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSportsStatsInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryData);
        if (flagHasQueryData)
          {
            handler.start_pair("QueryData");
            handler.start_array();
            for (int num1 = 0; num1 < storeQueryData.Count; ++num1)
              {
                if (partial_allowed)
                    storeQueryData[num1].write_partial_as_json(handler);
                else
                    storeQueryData[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (storeError.in_known_list)
              {
                switch (storeError.list_value)
                  {
                    case TypeErrorKnownValues.Error_ResolutionError:
                        handler.string_value("ResolutionError");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeError.string_value);
              }
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
        if (!(hasQueryData()))
          {
            return "When parsing the object for %what%, the \"QueryData\" field was missing.";
          }
        return null;
      }

    public static new SportsStatsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsInformationNugget", ignore_extras);
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
    public static new SportsStatsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStatsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsInformationNugget", ignore_extras);
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
    public static new SportsStatsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStatsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SportsStatsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStatsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsStatsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStatsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsInformationNuggetJSON.Generator
      {
        private SportsStatsQueryDataJSON.HoldingArrayGenerator fieldGeneratorQueryData;
    private abstract class FieldGeneratorError : JSONStringGenerator
          {
            protected FieldGeneratorError(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorError()
              {
              }
            protected override void handle_result(string result)
              {
                TypeErrorKnownValues known = stringToError(result);
                TypeError new_value = new TypeError();
                if (known == TypeErrorKnownValues.Error__none)
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
            protected abstract void handle_result(TypeError result);
          };
    private class FieldHoldingGeneratorError : FieldGeneratorError
  {
    protected override void handle_result(TypeError result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorError(String what)
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
    public TypeError value;
  };
    private class FieldHoldingArrayGeneratorError : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorError
      {
        private FieldHoldingArrayGeneratorError top;

        protected override void handle_result(TypeError result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorError init_top)
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
    protected virtual void handle_result(List<TypeError> result)
      {
      }

    public FieldHoldingArrayGeneratorError(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeError>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorError()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeError>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeError> value;
  };
        private FieldHoldingGeneratorError fieldGeneratorError;
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
            if (!(getSportsInformationNuggetJSONKey().Equals("SportsStats")))
                throw new Exception("The key field has a value other than `SportsStats'.");
            SportsStatsInformationNuggetJSON result = new SportsStatsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStatsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsInformationNuggetJSON new_result)
          {
            handle_result((SportsStatsInformationNuggetJSON )new_result);
          }
        protected void finish(SportsStatsInformationNuggetJSON result)
          {
            if (fieldGeneratorQueryData.have_value)
              {
                result.initQueryData();
                int count = fieldGeneratorQueryData.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryData(fieldGeneratorQueryData.value[num]);
                  }
                fieldGeneratorQueryData.value.Clear();
                fieldGeneratorQueryData.have_value = false;
              }
            else if ((!(result.hasQueryData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryData\" field was missing.");
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsStatsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryData", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryData;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQueryData = new SportsStatsQueryDataJSON.HoldingArrayGenerator("field \"QueryData\" of the SportsStatsInformationNugget class", ignore_extras);
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsStatsInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStatsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryData = new SportsStatsQueryDataJSON.HoldingArrayGenerator("field \"QueryData\" of the SportsStatsInformationNugget class", false);
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsStatsInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStatsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorQueryData.reset();
            fieldGeneratorError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStatsInformationNuggetJSON  result)
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
        public SportsStatsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStatsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SportsStatsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStatsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStatsInformationNuggetJSON>();
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
    public List<SportsStatsInformationNuggetJSON> value;
  };
  };
