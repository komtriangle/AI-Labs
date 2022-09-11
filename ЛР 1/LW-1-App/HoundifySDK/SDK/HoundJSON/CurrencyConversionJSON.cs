/* file "CurrencyConversionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CurrencyConversionJSON : JSONBase
  {
    public class TypeOutputValueJSON : JSONBase
      {
        private bool flagHasConvertedValue;
        private MoneyJSON  storeConvertedValue;
        private bool flagHasError;
        private CurrencyConversionErrorJSON  storeError;


        private void  fromJSONConvertedValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setConvertedValue(convert_classy);
          }


        private void  fromJSONError(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            CurrencyConversionErrorJSON convert_classy = CurrencyConversionErrorJSON.from_json(json_value, ignore_extras, true);
            setError(convert_classy);
          }


        public TypeOutputValueJSON()
          {
            flagHasConvertedValue = false;
            flagHasError = false;
          }

        public bool  hasConvertedValue()
          {
            return flagHasConvertedValue;
          }

        public MoneyJSON   getConvertedValue()
          {
            Debug.Assert(flagHasConvertedValue);
            return storeConvertedValue;
          }

        public bool  hasError()
          {
            return flagHasError;
          }

        public CurrencyConversionErrorJSON   getError()
          {
            Debug.Assert(flagHasError);
            return storeError;
          }



        public void setConvertedValue(MoneyJSON  new_value)
          {
            if (flagHasConvertedValue)
              {
              }
            flagHasConvertedValue = true;
            storeConvertedValue = new_value;
          }
        public void unsetConvertedValue()
          {
            if (flagHasConvertedValue)
              {
              }
            flagHasConvertedValue = false;
          }
        public void setError(CurrencyConversionErrorJSON  new_value)
          {
            if (flagHasError)
              {
              }
            flagHasError = true;
            storeError = new_value;
          }
        public void unsetError()
          {
            if (flagHasError)
              {
              }
            flagHasError = false;
          }


        public override void write_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler);
            handler.finish_object();
          }

        public virtual void write_fields_as_json(JSONHandler handler)
          {
            write_fields_as_json(handler, false);
          }

        public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
          {
            Debug.Assert(partial_allowed || flagHasConvertedValue);
            if (flagHasConvertedValue)
              {
                handler.start_pair("ConvertedValue");
                if (partial_allowed)
                    storeConvertedValue.write_partial_as_json(handler);
                else
                    storeConvertedValue.write_as_json(handler);
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
            handler.finish_object();
          }
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasConvertedValue()))
              {
                return "When parsing the object for %what%, the \"ConvertedValue\" field was missing.";
              }
            return null;
          }

        public static TypeOutputValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeOutputValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeOutputValue", ignore_extras);
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
        public static TypeOutputValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeOutputValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeOutputValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeOutputValue", ignore_extras);
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
        public static TypeOutputValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeOutputValueJSON from_text(string text, bool ignore_extras)
          {
            TypeOutputValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeOutputValue", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeOutputValueJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeOutputValueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeOutputValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeOutputValue", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private MoneyJSON.HoldingGenerator fieldGeneratorConvertedValue;
            private CurrencyConversionErrorJSON.HoldingGenerator fieldGeneratorError;

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
                string message = "";
                message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
                throw new Exception(message);
              }
            protected override void finish_field(string field_name, JSONHandler field_handler)
              {
              }
            protected override void finish()
              {
                TypeOutputValueJSON result = new TypeOutputValueJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeOutputValueJSON result)
              {
                if (fieldGeneratorConvertedValue.have_value)
                  {
                    result.setConvertedValue(fieldGeneratorConvertedValue.value);
                    fieldGeneratorConvertedValue.have_value = false;
                  }
                else if ((!(result.hasConvertedValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ConvertedValue\" field was missing.");
                  }
                if (fieldGeneratorError.have_value)
                  {
                    result.setError(fieldGeneratorError.value);
                    fieldGeneratorError.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeOutputValueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "onvertedValue", 0, 13, false) == 0) && (field_name.Length == 14))
                            return fieldGeneratorConvertedValue;
                        break;
                    case 'E':
                        if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorError;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorConvertedValue = new MoneyJSON.HoldingGenerator("field \"ConvertedValue\" of the TypeOutputValue class", ignore_extras);
                fieldGeneratorError = new CurrencyConversionErrorJSON.HoldingGenerator("field \"Error\" of the TypeOutputValue class", ignore_extras);
                set_what("the TypeOutputValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorConvertedValue = new MoneyJSON.HoldingGenerator("field \"ConvertedValue\" of the TypeOutputValue class", false);
                fieldGeneratorError = new CurrencyConversionErrorJSON.HoldingGenerator("field \"Error\" of the TypeOutputValue class", false);
                set_what("the TypeOutputValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorConvertedValue.reset();
                fieldGeneratorError.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorConvertedValue.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorError.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorConvertedValue.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorError.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeOutputValueJSON  result)
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
            public TypeOutputValueJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeOutputValueJSON  result)
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
        protected virtual void handle_result(List<TypeOutputValueJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeOutputValueJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeOutputValueJSON>();
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
        public List<TypeOutputValueJSON> value;
      };
      };
    private bool flagHasInputValue;
    private List< MoneyJSON  > storeInputValue;
    private bool flagHasOutputValue;
    private List< TypeOutputValueJSON  > storeOutputValue;


    private void  fromJSONInputValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputValue of CurrencyConversionJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field InputValue of CurrencyConversionJSON has too few elements.");
        List< MoneyJSON  > vector_InputValue1 = new List< MoneyJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MoneyJSON convert_classy = MoneyJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InputValue1.Add(convert_classy);
          }
        Debug.Assert(vector_InputValue1.Count >= 1);
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
            throw new Exception("The value for field OutputValue of CurrencyConversionJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field OutputValue of CurrencyConversionJSON has too few elements.");
        List< TypeOutputValueJSON  > vector_OutputValue1 = new List< TypeOutputValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeOutputValueJSON convert_classy = TypeOutputValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_OutputValue1.Add(convert_classy);
          }
        Debug.Assert(vector_OutputValue1.Count >= 1);
        initOutputValue();
        for (int num2 = 0; num2 < vector_OutputValue1.Count; ++num2)
            appendOutputValue(vector_OutputValue1[num2]);
        for (int num1 = 0; num1 < vector_OutputValue1.Count; ++num1)
          {
          }
      }


    public CurrencyConversionJSON()
      {
        flagHasInputValue = false;
        flagHasOutputValue = false;
        storeInputValue = new List< MoneyJSON  >();
        storeOutputValue = new List< TypeOutputValueJSON  >();
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

    public MoneyJSON   elementOfInputValue(int element_num)
      {
        Debug.Assert(flagHasInputValue);
        return storeInputValue[element_num];
      }

    public List< MoneyJSON  >  getInputValue()
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

    public TypeOutputValueJSON   elementOfOutputValue(int element_num)
      {
        Debug.Assert(flagHasOutputValue);
        return storeOutputValue[element_num];
      }

    public List< TypeOutputValueJSON  >  getOutputValue()
      {
        Debug.Assert(flagHasOutputValue);
        return storeOutputValue;
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
    public void appendInputValue(MoneyJSON  to_append)
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
    public void appendOutputValue(TypeOutputValueJSON  to_append)
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


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasInputValue);
        if (flagHasInputValue)
          {
            handler.start_pair("InputValue");
            Debug.Assert(storeInputValue.Count >= 1);
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
            Debug.Assert(storeOutputValue.Count >= 1);
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
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
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

    public static CurrencyConversionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CurrencyConversionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConversion", ignore_extras);
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
    public static CurrencyConversionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CurrencyConversionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CurrencyConversionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConversion", ignore_extras);
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
    public static CurrencyConversionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CurrencyConversionJSON from_text(string text, bool ignore_extras)
      {
        CurrencyConversionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConversion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CurrencyConversionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CurrencyConversionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CurrencyConversionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConversion", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MoneyJSON.HoldingArrayGenerator fieldGeneratorInputValue;
        private TypeOutputValueJSON.HoldingArrayGenerator fieldGeneratorOutputValue;

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
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            CurrencyConversionJSON result = new CurrencyConversionJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(CurrencyConversionJSON result)
          {
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
        protected abstract void handle_result(CurrencyConversionJSON new_result);
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
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorInputValue = new MoneyJSON.HoldingArrayGenerator("field \"InputValue\" of the CurrencyConversion class", ignore_extras);
            fieldGeneratorOutputValue = new TypeOutputValueJSON.HoldingArrayGenerator("field \"OutputValue\" of the CurrencyConversion class", ignore_extras);
            set_what("the CurrencyConversion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorInputValue = new MoneyJSON.HoldingArrayGenerator("field \"InputValue\" of the CurrencyConversion class", false);
            fieldGeneratorOutputValue = new TypeOutputValueJSON.HoldingArrayGenerator("field \"OutputValue\" of the CurrencyConversion class", false);
            set_what("the CurrencyConversion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorInputValue.reset();
            fieldGeneratorOutputValue.reset();
            base.reset();
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
        protected override void handle_result(CurrencyConversionJSON  result)
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
        public CurrencyConversionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CurrencyConversionJSON  result)
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
    protected virtual void handle_result(List<CurrencyConversionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CurrencyConversionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CurrencyConversionJSON>();
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
    public List<CurrencyConversionJSON> value;
  };
  };
