/* file "UploadedCodeSourceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UploadedCodeSourceJSON : JSONBase
  {
    private bool flagHasFileName;
    private string storeFileName;
    private bool flagHasStartLineNumber;
    private BigInteger storeStartLineNumber;
    private bool flagHasStartColumnNumber;
    private BigInteger storeStartColumnNumber;
    private bool flagHasEndLineNumber;
    private BigInteger storeEndLineNumber;
    private bool flagHasEndColumnNumber;
    private BigInteger storeEndColumnNumber;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFileName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FileName of UploadedCodeSourceJSON is not a string.");
        setFileName(json_string.getData());
      }


    private void  fromJSONStartLineNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StartLineNumber of UploadedCodeSourceJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StartLineNumber of UploadedCodeSourceJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStartLineNumber(extracted_integer);
      }


    private void  fromJSONStartColumnNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StartColumnNumber of UploadedCodeSourceJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StartColumnNumber of UploadedCodeSourceJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStartColumnNumber(extracted_integer);
      }


    private void  fromJSONEndLineNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EndLineNumber of UploadedCodeSourceJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EndLineNumber of UploadedCodeSourceJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEndLineNumber(extracted_integer);
      }


    private void  fromJSONEndColumnNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EndColumnNumber of UploadedCodeSourceJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EndColumnNumber of UploadedCodeSourceJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEndColumnNumber(extracted_integer);
      }


    public UploadedCodeSourceJSON()
      {
        flagHasFileName = false;
        flagHasStartLineNumber = false;
        flagHasStartColumnNumber = false;
        flagHasEndLineNumber = false;
        flagHasEndColumnNumber = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFileName()
      {
        return flagHasFileName;
      }

    public string  getFileName()
      {
        Debug.Assert(flagHasFileName);
        return storeFileName;
      }

    public bool  hasStartLineNumber()
      {
        return flagHasStartLineNumber;
      }

    public BigInteger  getStartLineNumber()
      {
        Debug.Assert(flagHasStartLineNumber);
        return storeStartLineNumber;
      }

    public bool  hasStartColumnNumber()
      {
        return flagHasStartColumnNumber;
      }

    public BigInteger  getStartColumnNumber()
      {
        Debug.Assert(flagHasStartColumnNumber);
        return storeStartColumnNumber;
      }

    public bool  hasEndLineNumber()
      {
        return flagHasEndLineNumber;
      }

    public BigInteger  getEndLineNumber()
      {
        Debug.Assert(flagHasEndLineNumber);
        return storeEndLineNumber;
      }

    public bool  hasEndColumnNumber()
      {
        return flagHasEndColumnNumber;
      }

    public BigInteger  getEndColumnNumber()
      {
        Debug.Assert(flagHasEndColumnNumber);
        return storeEndColumnNumber;
      }


    public virtual int extraUploadedCodeSourceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUploadedCodeSourceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUploadedCodeSourceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUploadedCodeSourceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFileName(string new_value)
      {
        flagHasFileName = true;
        storeFileName = new_value;
      }
    public void unsetFileName()
      {
        flagHasFileName = false;
      }
    public void setStartLineNumber(BigInteger new_value)
      {
        flagHasStartLineNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field StartLineNumber of UploadedCodeSourceJSON is less than the lower bound (1) for that field.");
        storeStartLineNumber = new_value;
      }
    public void unsetStartLineNumber()
      {
        flagHasStartLineNumber = false;
      }
    public void setStartColumnNumber(BigInteger new_value)
      {
        flagHasStartColumnNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field StartColumnNumber of UploadedCodeSourceJSON is less than the lower bound (1) for that field.");
        storeStartColumnNumber = new_value;
      }
    public void unsetStartColumnNumber()
      {
        flagHasStartColumnNumber = false;
      }
    public void setEndLineNumber(BigInteger new_value)
      {
        flagHasEndLineNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field EndLineNumber of UploadedCodeSourceJSON is less than the lower bound (1) for that field.");
        storeEndLineNumber = new_value;
      }
    public void unsetEndLineNumber()
      {
        flagHasEndLineNumber = false;
      }
    public void setEndColumnNumber(BigInteger new_value)
      {
        flagHasEndColumnNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field EndColumnNumber of UploadedCodeSourceJSON is less than the lower bound (1) for that field.");
        storeEndColumnNumber = new_value;
      }
    public void unsetEndColumnNumber()
      {
        flagHasEndColumnNumber = false;
      }

    public virtual void extraUploadedCodeSourceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUploadedCodeSourceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUploadedCodeSourceLookup(key);
        if (old_field == null)
          {
            extraUploadedCodeSourceAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFileName);
        if (flagHasFileName)
          {
            handler.start_pair("FileName");
            handler.string_value(storeFileName);
          }
        if (flagHasStartLineNumber)
          {
            handler.start_pair("StartLineNumber");
            handler.number_value(storeStartLineNumber);
          }
        if (flagHasStartColumnNumber)
          {
            handler.start_pair("StartColumnNumber");
            handler.number_value(storeStartColumnNumber);
          }
        if (flagHasEndLineNumber)
          {
            handler.start_pair("EndLineNumber");
            handler.number_value(storeEndLineNumber);
          }
        if (flagHasEndColumnNumber)
          {
            handler.start_pair("EndColumnNumber");
            handler.number_value(storeEndColumnNumber);
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
        if (!(hasFileName()))
          {
            return "When parsing the object for %what%, the \"FileName\" field was missing.";
          }
        return null;
      }

    public static UploadedCodeSourceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedCodeSourceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedCodeSource", ignore_extras);
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
    public static UploadedCodeSourceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedCodeSourceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedCodeSourceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedCodeSource", ignore_extras);
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
    public static UploadedCodeSourceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedCodeSourceJSON from_text(string text, bool ignore_extras)
      {
        UploadedCodeSourceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedCodeSource", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UploadedCodeSourceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UploadedCodeSourceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UploadedCodeSourceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedCodeSource", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorFileName;
    private class FieldHoldingGeneratorStartLineNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStartLineNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStartLineNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStartLineNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorStartLineNumber fieldGeneratorStartLineNumber;
    private class FieldHoldingGeneratorStartColumnNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStartColumnNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStartColumnNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStartColumnNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorStartColumnNumber fieldGeneratorStartColumnNumber;
    private class FieldHoldingGeneratorEndLineNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorEndLineNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorEndLineNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorEndLineNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorEndLineNumber fieldGeneratorEndLineNumber;
    private class FieldHoldingGeneratorEndColumnNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorEndColumnNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorEndColumnNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorEndColumnNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorEndColumnNumber fieldGeneratorEndColumnNumber;
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
            UploadedCodeSourceJSON result = new UploadedCodeSourceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUploadedCodeSourceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UploadedCodeSourceJSON result)
          {
            if (fieldGeneratorFileName.have_value)
              {
                result.setFileName(fieldGeneratorFileName.value);
                fieldGeneratorFileName.have_value = false;
              }
            else if ((!(result.hasFileName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FileName\" field was missing.");
              }
            if (fieldGeneratorStartLineNumber.have_value)
              {
                result.setStartLineNumber(fieldGeneratorStartLineNumber.value);
                fieldGeneratorStartLineNumber.have_value = false;
              }
            if (fieldGeneratorStartColumnNumber.have_value)
              {
                result.setStartColumnNumber(fieldGeneratorStartColumnNumber.value);
                fieldGeneratorStartColumnNumber.have_value = false;
              }
            if (fieldGeneratorEndLineNumber.have_value)
              {
                result.setEndLineNumber(fieldGeneratorEndLineNumber.value);
                fieldGeneratorEndLineNumber.have_value = false;
              }
            if (fieldGeneratorEndColumnNumber.have_value)
              {
                result.setEndColumnNumber(fieldGeneratorEndColumnNumber.value);
                fieldGeneratorEndColumnNumber.have_value = false;
              }
          }
        protected abstract void handle_result(UploadedCodeSourceJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if (String.Compare(field_name, 1, "nd", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 4, "olumnNumber", 0, 11, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorEndColumnNumber;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 4, "ineNumber", 0, 9, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorEndLineNumber;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ileName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorFileName;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tart", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 6, "olumnNumber", 0, 11, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorStartColumnNumber;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 6, "ineNumber", 0, 9, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorStartLineNumber;
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
            fieldGeneratorFileName = new JSONHoldingStringGenerator("field \"FileName\" of the UploadedCodeSource class");
            fieldGeneratorStartLineNumber = new FieldHoldingGeneratorStartLineNumber("field \"StartLineNumber\" of the UploadedCodeSource class");
            fieldGeneratorStartColumnNumber = new FieldHoldingGeneratorStartColumnNumber("field \"StartColumnNumber\" of the UploadedCodeSource class");
            fieldGeneratorEndLineNumber = new FieldHoldingGeneratorEndLineNumber("field \"EndLineNumber\" of the UploadedCodeSource class");
            fieldGeneratorEndColumnNumber = new FieldHoldingGeneratorEndColumnNumber("field \"EndColumnNumber\" of the UploadedCodeSource class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UploadedCodeSource class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFileName = new JSONHoldingStringGenerator("field \"FileName\" of the UploadedCodeSource class");
            fieldGeneratorStartLineNumber = new FieldHoldingGeneratorStartLineNumber("field \"StartLineNumber\" of the UploadedCodeSource class");
            fieldGeneratorStartColumnNumber = new FieldHoldingGeneratorStartColumnNumber("field \"StartColumnNumber\" of the UploadedCodeSource class");
            fieldGeneratorEndLineNumber = new FieldHoldingGeneratorEndLineNumber("field \"EndLineNumber\" of the UploadedCodeSource class");
            fieldGeneratorEndColumnNumber = new FieldHoldingGeneratorEndColumnNumber("field \"EndColumnNumber\" of the UploadedCodeSource class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UploadedCodeSource class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFileName.reset();
            fieldGeneratorStartLineNumber.reset();
            fieldGeneratorStartColumnNumber.reset();
            fieldGeneratorEndLineNumber.reset();
            fieldGeneratorEndColumnNumber.reset();
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
        protected override void handle_result(UploadedCodeSourceJSON  result)
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
        public UploadedCodeSourceJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UploadedCodeSourceJSON  result)
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
    protected virtual void handle_result(List<UploadedCodeSourceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UploadedCodeSourceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UploadedCodeSourceJSON>();
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
    public List<UploadedCodeSourceJSON> value;
  };
  };
