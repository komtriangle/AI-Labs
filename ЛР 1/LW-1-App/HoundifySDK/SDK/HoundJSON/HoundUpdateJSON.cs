/* file "HoundUpdateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HoundUpdateJSON : JSONBase
  {
    public enum TypeFormat
      {
        Format_HoundQueryUpdate
      };

    public static TypeFormat  stringToFormat(string chars)
      {
        if ((String.Compare(chars, 0, "HoundQueryUpdate", 0, 16, false) == 0) && (chars.Length == 16))
            return TypeFormat.Format_HoundQueryUpdate;
        throw new Exception("The value for field `Format' is not one of the legal values.");
      }

    public static string  stringFromFormat(TypeFormat the_enum)
      {
        switch (the_enum)
          {
            case TypeFormat.Format_HoundQueryUpdate:
                return "HoundQueryUpdate";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeFormatVersion
      {
        FormatVersion_1_x2e_0
      };

    public static TypeFormatVersion  stringToFormatVersion(string chars)
      {
        if ((String.Compare(chars, 0, "1.0", 0, 3, false) == 0) && (chars.Length == 3))
            return TypeFormatVersion.FormatVersion_1_x2e_0;
        throw new Exception("The value for field `FormatVersion' is not one of the legal values.");
      }

    public static string  stringFromFormatVersion(TypeFormatVersion the_enum)
      {
        switch (the_enum)
          {
            case TypeFormatVersion.FormatVersion_1_x2e_0:
                return "1.0";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFormat;
    private bool flagHasFormatVersion;
    private bool flagHasIndex;
    private BigInteger storeIndex;
    private bool flagHasResult;
    private CommandResultJSON  storeResult;
    private bool flagHasIsFinal;
    private bool storeIsFinal;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFormat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Format of HoundUpdateJSON is not a string.");
        if (!(json_string.getData().Equals("HoundQueryUpdate")))
            throw new Exception("The value for field Format of HoundUpdateJSON is not `HoundQueryUpdate'.");
        setFormat();
      }


    private void  fromJSONFormatVersion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FormatVersion of HoundUpdateJSON is not a string.");
        if (!(json_string.getData().Equals("1.0")))
            throw new Exception("The value for field FormatVersion of HoundUpdateJSON is not `1.0'.");
        setFormatVersion();
      }


    private void  fromJSONIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Index of HoundUpdateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Index of HoundUpdateJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIndex(extracted_integer);
      }


    private void  fromJSONResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CommandResultJSON convert_classy = CommandResultJSON.from_json(json_value, ignore_extras, true);
        setResult(convert_classy);
      }


    private void  fromJSONIsFinal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IsFinal of HoundUpdateJSON is not true for false.");
              }
          }
        setIsFinal(the_bool);
      }


    public HoundUpdateJSON()
      {
        flagHasFormat = false;
        flagHasFormatVersion = false;
        flagHasIndex = false;
        flagHasResult = false;
        flagHasIsFinal = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFormat()
      {
        return flagHasFormat;
      }

    public TypeFormat  getFormat()
      {
        Debug.Assert(flagHasFormat);
        return TypeFormat.Format_HoundQueryUpdate;
      }

    public string  getFormatAsString()
      {
        return stringFromFormat(getFormat());
      }

    public bool  hasFormatVersion()
      {
        return flagHasFormatVersion;
      }

    public TypeFormatVersion  getFormatVersion()
      {
        Debug.Assert(flagHasFormatVersion);
        return TypeFormatVersion.FormatVersion_1_x2e_0;
      }

    public string  getFormatVersionAsString()
      {
        return stringFromFormatVersion(getFormatVersion());
      }

    public bool  hasIndex()
      {
        return flagHasIndex;
      }

    public BigInteger  getIndex()
      {
        Debug.Assert(flagHasIndex);
        return storeIndex;
      }

    public bool  hasResult()
      {
        return flagHasResult;
      }

    public CommandResultJSON   getResult()
      {
        Debug.Assert(flagHasResult);
        return storeResult;
      }

    public bool  hasIsFinal()
      {
        return flagHasIsFinal;
      }

    public bool  getIsFinal()
      {
        Debug.Assert(flagHasIsFinal);
        return storeIsFinal;
      }


    public virtual int extraHoundUpdateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHoundUpdateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHoundUpdateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHoundUpdateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFormat()
      {
        flagHasFormat = true;
      }
    public void setFormat(TypeFormat new_value)
      {
        setFormat();
      }
    public void setFormat(string chars)
      {
        setFormat(stringToFormat(chars));
      }
    public void unsetFormat()
      {
        flagHasFormat = false;
      }
    public void setFormatVersion()
      {
        flagHasFormatVersion = true;
      }
    public void setFormatVersion(TypeFormatVersion new_value)
      {
        setFormatVersion();
      }
    public void setFormatVersion(string chars)
      {
        setFormatVersion(stringToFormatVersion(chars));
      }
    public void unsetFormatVersion()
      {
        flagHasFormatVersion = false;
      }
    public void setIndex(BigInteger new_value)
      {
        flagHasIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field Index of HoundUpdateJSON is less than the lower bound (0) for that field.");
        storeIndex = new_value;
      }
    public void unsetIndex()
      {
        flagHasIndex = false;
      }
    public void setResult(CommandResultJSON  new_value)
      {
        if (flagHasResult)
          {
          }
        flagHasResult = true;
        storeResult = new_value;
      }
    public void unsetResult()
      {
        if (flagHasResult)
          {
          }
        flagHasResult = false;
      }
    public void setIsFinal(bool new_value)
      {
        flagHasIsFinal = true;
        storeIsFinal = new_value;
      }
    public void unsetIsFinal()
      {
        flagHasIsFinal = false;
      }

    public virtual void extraHoundUpdateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHoundUpdateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHoundUpdateLookup(key);
        if (old_field == null)
          {
            extraHoundUpdateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFormat);
        if (flagHasFormat)
          {
            handler.start_pair("Format");
            handler.string_value("HoundQueryUpdate");
          }
        Debug.Assert(partial_allowed || flagHasFormatVersion);
        if (flagHasFormatVersion)
          {
            handler.start_pair("FormatVersion");
            handler.string_value("1.0");
          }
        Debug.Assert(partial_allowed || flagHasIndex);
        if (flagHasIndex)
          {
            handler.start_pair("Index");
            handler.number_value(storeIndex);
          }
        Debug.Assert(partial_allowed || flagHasResult);
        if (flagHasResult)
          {
            handler.start_pair("Result");
            if (partial_allowed)
                storeResult.write_partial_as_json(handler);
            else
                storeResult.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasIsFinal);
        if (flagHasIsFinal)
          {
            handler.start_pair("IsFinal");
            handler.boolean_value(storeIsFinal);
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
        if (!(hasFormat()))
          {
            return "When parsing the object for %what%, the \"Format\" field was missing.";
          }
        if (!(hasFormatVersion()))
          {
            return "When parsing the object for %what%, the \"FormatVersion\" field was missing.";
          }
        if (!(hasIndex()))
          {
            return "When parsing the object for %what%, the \"Index\" field was missing.";
          }
        if (!(hasResult()))
          {
            return "When parsing the object for %what%, the \"Result\" field was missing.";
          }
        if (!(hasIsFinal()))
          {
            return "When parsing the object for %what%, the \"IsFinal\" field was missing.";
          }
        return null;
      }

    public static HoundUpdateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundUpdateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundUpdate", ignore_extras);
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
    public static HoundUpdateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundUpdateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundUpdateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundUpdate", ignore_extras);
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
    public static HoundUpdateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundUpdateJSON from_text(string text, bool ignore_extras)
      {
        HoundUpdateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundUpdate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HoundUpdateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HoundUpdateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HoundUpdateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundUpdate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorFormat : JSONStringGenerator
          {
            protected FieldGeneratorFormat(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFormat()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFormat(result));
              }
            protected abstract void handle_result(TypeFormat result);
          };
    private class FieldHoldingGeneratorFormat : FieldGeneratorFormat
  {
    protected override void handle_result(TypeFormat result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFormat(String what)
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
    public TypeFormat value;
  };
    private class FieldHoldingArrayGeneratorFormat : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFormat
      {
        private FieldHoldingArrayGeneratorFormat top;

        protected override void handle_result(TypeFormat result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFormat init_top)
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
    protected virtual void handle_result(List<TypeFormat> result)
      {
      }

    public FieldHoldingArrayGeneratorFormat(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormat>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFormat()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormat>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFormat> value;
  };
        private FieldHoldingGeneratorFormat fieldGeneratorFormat;
    private abstract class FieldGeneratorFormatVersion : JSONStringGenerator
          {
            protected FieldGeneratorFormatVersion(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFormatVersion()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFormatVersion(result));
              }
            protected abstract void handle_result(TypeFormatVersion result);
          };
    private class FieldHoldingGeneratorFormatVersion : FieldGeneratorFormatVersion
  {
    protected override void handle_result(TypeFormatVersion result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFormatVersion(String what)
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
    public TypeFormatVersion value;
  };
    private class FieldHoldingArrayGeneratorFormatVersion : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFormatVersion
      {
        private FieldHoldingArrayGeneratorFormatVersion top;

        protected override void handle_result(TypeFormatVersion result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFormatVersion init_top)
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
    protected virtual void handle_result(List<TypeFormatVersion> result)
      {
      }

    public FieldHoldingArrayGeneratorFormatVersion(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormatVersion>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFormatVersion()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormatVersion>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFormatVersion> value;
  };
        private FieldHoldingGeneratorFormatVersion fieldGeneratorFormatVersion;
    private class FieldHoldingGeneratorIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIndex fieldGeneratorIndex;
        private CommandResultJSON.HoldingGenerator fieldGeneratorResult;
        private JSONHoldingBooleanGenerator fieldGeneratorIsFinal;
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
            HoundUpdateJSON result = new HoundUpdateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHoundUpdateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HoundUpdateJSON result)
          {
            if (fieldGeneratorFormat.have_value)
              {
                result.setFormat();
                fieldGeneratorFormat.have_value = false;
              }
            else if ((!(result.hasFormat())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Format\" field was missing.");
              }
            if (fieldGeneratorFormatVersion.have_value)
              {
                result.setFormatVersion();
                fieldGeneratorFormatVersion.have_value = false;
              }
            else if ((!(result.hasFormatVersion())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FormatVersion\" field was missing.");
              }
            if (fieldGeneratorIndex.have_value)
              {
                result.setIndex(fieldGeneratorIndex.value);
                fieldGeneratorIndex.have_value = false;
              }
            else if ((!(result.hasIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Index\" field was missing.");
              }
            if (fieldGeneratorResult.have_value)
              {
                result.setResult(fieldGeneratorResult.value);
                fieldGeneratorResult.have_value = false;
              }
            else if ((!(result.hasResult())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Result\" field was missing.");
              }
            if (fieldGeneratorIsFinal.have_value)
              {
                result.setIsFinal(fieldGeneratorIsFinal.value);
                fieldGeneratorIsFinal.have_value = false;
              }
            else if ((!(result.hasIsFinal())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsFinal\" field was missing.");
              }
          }
        protected abstract void handle_result(HoundUpdateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if (String.Compare(field_name, 1, "ormat", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 6)
                          {
                            return fieldGeneratorFormat;
                          }
                        switch (field_name[6])
                          {
                            case 'V':
                                if ((String.Compare(field_name, 7, "ersion", 0, 6, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorFormatVersion;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'n':
                            if ((String.Compare(field_name, 2, "dex", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorIndex;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 2, "Final", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorIsFinal;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esult", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorResult;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFormat = new FieldHoldingGeneratorFormat("field \"Format\" of the HoundUpdate class");
            fieldGeneratorFormatVersion = new FieldHoldingGeneratorFormatVersion("field \"FormatVersion\" of the HoundUpdate class");
            fieldGeneratorIndex = new FieldHoldingGeneratorIndex("field \"Index\" of the HoundUpdate class");
            fieldGeneratorResult = new CommandResultJSON.HoldingGenerator("field \"Result\" of the HoundUpdate class", ignore_extras);
            fieldGeneratorIsFinal = new JSONHoldingBooleanGenerator("field \"IsFinal\" of the HoundUpdate class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HoundUpdate class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFormat = new FieldHoldingGeneratorFormat("field \"Format\" of the HoundUpdate class");
            fieldGeneratorFormatVersion = new FieldHoldingGeneratorFormatVersion("field \"FormatVersion\" of the HoundUpdate class");
            fieldGeneratorIndex = new FieldHoldingGeneratorIndex("field \"Index\" of the HoundUpdate class");
            fieldGeneratorResult = new CommandResultJSON.HoldingGenerator("field \"Result\" of the HoundUpdate class", false);
            fieldGeneratorIsFinal = new JSONHoldingBooleanGenerator("field \"IsFinal\" of the HoundUpdate class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HoundUpdate class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFormat.reset();
            fieldGeneratorFormatVersion.reset();
            fieldGeneratorIndex.reset();
            fieldGeneratorResult.reset();
            fieldGeneratorIsFinal.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorResult.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorResult.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HoundUpdateJSON  result)
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
        public HoundUpdateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HoundUpdateJSON  result)
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
    protected virtual void handle_result(List<HoundUpdateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HoundUpdateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HoundUpdateJSON>();
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
    public List<HoundUpdateJSON> value;
  };
  };
