/* file "CurrencyConverterQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CurrencyConverterQueryStateJSON : JSONBase
  {
    public enum TypeCurrencyConverterCommandKind
      {
        CurrencyConverterCommandKind_CurrencyConverterCommand
      };

    public static TypeCurrencyConverterCommandKind  stringToCurrencyConverterCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "CurrencyConverterCommand", 0, 24, false) == 0) && (chars.Length == 24))
            return TypeCurrencyConverterCommandKind.CurrencyConverterCommandKind_CurrencyConverterCommand;
        throw new Exception("The value for field `CurrencyConverterCommandKind' is not one of the legal values.");
      }

    public static string  stringFromCurrencyConverterCommandKind(TypeCurrencyConverterCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeCurrencyConverterCommandKind.CurrencyConverterCommandKind_CurrencyConverterCommand:
                return "CurrencyConverterCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCurrencyConverterCommandKind;
    private bool flagHasInputMonetaryAmounts;
    private List< MoneyJSON  > storeInputMonetaryAmounts;
    private bool flagHasOutputMonetaryAmounts;
    private List< MoneyJSON  > storeOutputMonetaryAmounts;


    private void  fromJSONCurrencyConverterCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CurrencyConverterCommandKind of CurrencyConverterQueryStateJSON is not a string.");
        if (!(json_string.getData().Equals("CurrencyConverterCommand")))
            throw new Exception("The value for field CurrencyConverterCommandKind of CurrencyConverterQueryStateJSON is not `CurrencyConverterCommand'.");
        setCurrencyConverterCommandKind();
      }


    private void  fromJSONInputMonetaryAmounts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputMonetaryAmounts of CurrencyConverterQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MoneyJSON  > vector_InputMonetaryAmounts1 = new List< MoneyJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MoneyJSON convert_classy = MoneyJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InputMonetaryAmounts1.Add(convert_classy);
          }
        initInputMonetaryAmounts();
        for (int num1 = 0; num1 < vector_InputMonetaryAmounts1.Count; ++num1)
            appendInputMonetaryAmounts(vector_InputMonetaryAmounts1[num1]);
        for (int num1 = 0; num1 < vector_InputMonetaryAmounts1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOutputMonetaryAmounts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OutputMonetaryAmounts of CurrencyConverterQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MoneyJSON  > vector_OutputMonetaryAmounts1 = new List< MoneyJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MoneyJSON convert_classy = MoneyJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_OutputMonetaryAmounts1.Add(convert_classy);
          }
        initOutputMonetaryAmounts();
        for (int num2 = 0; num2 < vector_OutputMonetaryAmounts1.Count; ++num2)
            appendOutputMonetaryAmounts(vector_OutputMonetaryAmounts1[num2]);
        for (int num1 = 0; num1 < vector_OutputMonetaryAmounts1.Count; ++num1)
          {
          }
      }


    public CurrencyConverterQueryStateJSON()
      {
        flagHasCurrencyConverterCommandKind = false;
        flagHasInputMonetaryAmounts = false;
        flagHasOutputMonetaryAmounts = false;
        storeInputMonetaryAmounts = new List< MoneyJSON  >();
        storeOutputMonetaryAmounts = new List< MoneyJSON  >();
      }

    public bool  hasCurrencyConverterCommandKind()
      {
        return flagHasCurrencyConverterCommandKind;
      }

    public TypeCurrencyConverterCommandKind  getCurrencyConverterCommandKind()
      {
        Debug.Assert(flagHasCurrencyConverterCommandKind);
        return TypeCurrencyConverterCommandKind.CurrencyConverterCommandKind_CurrencyConverterCommand;
      }

    public string  getCurrencyConverterCommandKindAsString()
      {
        return stringFromCurrencyConverterCommandKind(getCurrencyConverterCommandKind());
      }

    public bool  hasInputMonetaryAmounts()
      {
        return flagHasInputMonetaryAmounts;
      }

    public int  countOfInputMonetaryAmounts()
      {
        Debug.Assert(flagHasInputMonetaryAmounts);
        return storeInputMonetaryAmounts.Count;
      }

    public MoneyJSON   elementOfInputMonetaryAmounts(int element_num)
      {
        Debug.Assert(flagHasInputMonetaryAmounts);
        return storeInputMonetaryAmounts[element_num];
      }

    public List< MoneyJSON  >  getInputMonetaryAmounts()
      {
        Debug.Assert(flagHasInputMonetaryAmounts);
        return storeInputMonetaryAmounts;
      }

    public bool  hasOutputMonetaryAmounts()
      {
        return flagHasOutputMonetaryAmounts;
      }

    public int  countOfOutputMonetaryAmounts()
      {
        Debug.Assert(flagHasOutputMonetaryAmounts);
        return storeOutputMonetaryAmounts.Count;
      }

    public MoneyJSON   elementOfOutputMonetaryAmounts(int element_num)
      {
        Debug.Assert(flagHasOutputMonetaryAmounts);
        return storeOutputMonetaryAmounts[element_num];
      }

    public List< MoneyJSON  >  getOutputMonetaryAmounts()
      {
        Debug.Assert(flagHasOutputMonetaryAmounts);
        return storeOutputMonetaryAmounts;
      }



    public void setCurrencyConverterCommandKind()
      {
        flagHasCurrencyConverterCommandKind = true;
      }
    public void setCurrencyConverterCommandKind(TypeCurrencyConverterCommandKind new_value)
      {
        setCurrencyConverterCommandKind();
      }
    public void setCurrencyConverterCommandKind(string chars)
      {
        setCurrencyConverterCommandKind(stringToCurrencyConverterCommandKind(chars));
      }
    public void unsetCurrencyConverterCommandKind()
      {
        flagHasCurrencyConverterCommandKind = false;
      }
    public void initInputMonetaryAmounts()
      {
        if (flagHasInputMonetaryAmounts)
          {
            for (int num1 = 0; num1 < storeInputMonetaryAmounts.Count; ++num1)
              {
              }
          }
        flagHasInputMonetaryAmounts = true;
        storeInputMonetaryAmounts.Clear();
      }
    public void appendInputMonetaryAmounts(MoneyJSON  to_append)
      {
        if (!flagHasInputMonetaryAmounts)
          {
            flagHasInputMonetaryAmounts = true;
            storeInputMonetaryAmounts.Clear();
          }
        Debug.Assert(flagHasInputMonetaryAmounts);
        storeInputMonetaryAmounts.Add(to_append);
      }
    public void unsetInputMonetaryAmounts()
      {
        if (flagHasInputMonetaryAmounts)
          {
            for (int num2 = 0; num2 < storeInputMonetaryAmounts.Count; ++num2)
              {
              }
          }
        flagHasInputMonetaryAmounts = false;
        storeInputMonetaryAmounts.Clear();
      }
    public void initOutputMonetaryAmounts()
      {
        if (flagHasOutputMonetaryAmounts)
          {
            for (int num3 = 0; num3 < storeOutputMonetaryAmounts.Count; ++num3)
              {
              }
          }
        flagHasOutputMonetaryAmounts = true;
        storeOutputMonetaryAmounts.Clear();
      }
    public void appendOutputMonetaryAmounts(MoneyJSON  to_append)
      {
        if (!flagHasOutputMonetaryAmounts)
          {
            flagHasOutputMonetaryAmounts = true;
            storeOutputMonetaryAmounts.Clear();
          }
        Debug.Assert(flagHasOutputMonetaryAmounts);
        storeOutputMonetaryAmounts.Add(to_append);
      }
    public void unsetOutputMonetaryAmounts()
      {
        if (flagHasOutputMonetaryAmounts)
          {
            for (int num4 = 0; num4 < storeOutputMonetaryAmounts.Count; ++num4)
              {
              }
          }
        flagHasOutputMonetaryAmounts = false;
        storeOutputMonetaryAmounts.Clear();
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
        Debug.Assert(partial_allowed || flagHasCurrencyConverterCommandKind);
        if (flagHasCurrencyConverterCommandKind)
          {
            handler.start_pair("CurrencyConverterCommandKind");
            handler.string_value("CurrencyConverterCommand");
          }
        Debug.Assert(partial_allowed || flagHasInputMonetaryAmounts);
        if (flagHasInputMonetaryAmounts)
          {
            handler.start_pair("InputMonetaryAmounts");
            handler.start_array();
            for (int num1 = 0; num1 < storeInputMonetaryAmounts.Count; ++num1)
              {
                if (partial_allowed)
                    storeInputMonetaryAmounts[num1].write_partial_as_json(handler);
                else
                    storeInputMonetaryAmounts[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasOutputMonetaryAmounts);
        if (flagHasOutputMonetaryAmounts)
          {
            handler.start_pair("OutputMonetaryAmounts");
            handler.start_array();
            for (int num2 = 0; num2 < storeOutputMonetaryAmounts.Count; ++num2)
              {
                if (partial_allowed)
                    storeOutputMonetaryAmounts[num2].write_partial_as_json(handler);
                else
                    storeOutputMonetaryAmounts[num2].write_as_json(handler);
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
        if (!(hasCurrencyConverterCommandKind()))
          {
            return "When parsing the object for %what%, the \"CurrencyConverterCommandKind\" field was missing.";
          }
        if (!(hasInputMonetaryAmounts()))
          {
            return "When parsing the object for %what%, the \"InputMonetaryAmounts\" field was missing.";
          }
        if (!(hasOutputMonetaryAmounts()))
          {
            return "When parsing the object for %what%, the \"OutputMonetaryAmounts\" field was missing.";
          }
        return null;
      }

    public static CurrencyConverterQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CurrencyConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConverterQueryState", ignore_extras);
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
    public static CurrencyConverterQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CurrencyConverterQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CurrencyConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConverterQueryState", ignore_extras);
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
    public static CurrencyConverterQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CurrencyConverterQueryStateJSON from_text(string text, bool ignore_extras)
      {
        CurrencyConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConverterQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CurrencyConverterQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CurrencyConverterQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CurrencyConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrencyConverterQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorCurrencyConverterCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorCurrencyConverterCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCurrencyConverterCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCurrencyConverterCommandKind(result));
              }
            protected abstract void handle_result(TypeCurrencyConverterCommandKind result);
          };
    private class FieldHoldingGeneratorCurrencyConverterCommandKind : FieldGeneratorCurrencyConverterCommandKind
  {
    protected override void handle_result(TypeCurrencyConverterCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCurrencyConverterCommandKind(String what)
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
    public TypeCurrencyConverterCommandKind value;
  };
    private class FieldHoldingArrayGeneratorCurrencyConverterCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCurrencyConverterCommandKind
      {
        private FieldHoldingArrayGeneratorCurrencyConverterCommandKind top;

        protected override void handle_result(TypeCurrencyConverterCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCurrencyConverterCommandKind init_top)
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
    protected virtual void handle_result(List<TypeCurrencyConverterCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorCurrencyConverterCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCurrencyConverterCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCurrencyConverterCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCurrencyConverterCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCurrencyConverterCommandKind> value;
  };
        private FieldHoldingGeneratorCurrencyConverterCommandKind fieldGeneratorCurrencyConverterCommandKind;
        private MoneyJSON.HoldingArrayGenerator fieldGeneratorInputMonetaryAmounts;
        private MoneyJSON.HoldingArrayGenerator fieldGeneratorOutputMonetaryAmounts;

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
            CurrencyConverterQueryStateJSON result = new CurrencyConverterQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(CurrencyConverterQueryStateJSON result)
          {
            if (fieldGeneratorCurrencyConverterCommandKind.have_value)
              {
                result.setCurrencyConverterCommandKind();
                fieldGeneratorCurrencyConverterCommandKind.have_value = false;
              }
            else if ((!(result.hasCurrencyConverterCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CurrencyConverterCommandKind\" field was missing.");
              }
            if (fieldGeneratorInputMonetaryAmounts.have_value)
              {
                result.initInputMonetaryAmounts();
                int count = fieldGeneratorInputMonetaryAmounts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInputMonetaryAmounts(fieldGeneratorInputMonetaryAmounts.value[num]);
                  }
                fieldGeneratorInputMonetaryAmounts.value.Clear();
                fieldGeneratorInputMonetaryAmounts.have_value = false;
              }
            else if ((!(result.hasInputMonetaryAmounts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InputMonetaryAmounts\" field was missing.");
              }
            if (fieldGeneratorOutputMonetaryAmounts.have_value)
              {
                result.initOutputMonetaryAmounts();
                int count = fieldGeneratorOutputMonetaryAmounts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOutputMonetaryAmounts(fieldGeneratorOutputMonetaryAmounts.value[num]);
                  }
                fieldGeneratorOutputMonetaryAmounts.value.Clear();
                fieldGeneratorOutputMonetaryAmounts.have_value = false;
              }
            else if ((!(result.hasOutputMonetaryAmounts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OutputMonetaryAmounts\" field was missing.");
              }
          }
        protected abstract void handle_result(CurrencyConverterQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "urrencyConverterCommandKind", 0, 27, false) == 0) && (field_name.Length == 28))
                        return fieldGeneratorCurrencyConverterCommandKind;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nputMonetaryAmounts", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorInputMonetaryAmounts;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utputMonetaryAmounts", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorOutputMonetaryAmounts;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCurrencyConverterCommandKind = new FieldHoldingGeneratorCurrencyConverterCommandKind("field \"CurrencyConverterCommandKind\" of the CurrencyConverterQueryState class");
            fieldGeneratorInputMonetaryAmounts = new MoneyJSON.HoldingArrayGenerator("field \"InputMonetaryAmounts\" of the CurrencyConverterQueryState class", ignore_extras);
            fieldGeneratorOutputMonetaryAmounts = new MoneyJSON.HoldingArrayGenerator("field \"OutputMonetaryAmounts\" of the CurrencyConverterQueryState class", ignore_extras);
            set_what("the CurrencyConverterQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCurrencyConverterCommandKind = new FieldHoldingGeneratorCurrencyConverterCommandKind("field \"CurrencyConverterCommandKind\" of the CurrencyConverterQueryState class");
            fieldGeneratorInputMonetaryAmounts = new MoneyJSON.HoldingArrayGenerator("field \"InputMonetaryAmounts\" of the CurrencyConverterQueryState class", false);
            fieldGeneratorOutputMonetaryAmounts = new MoneyJSON.HoldingArrayGenerator("field \"OutputMonetaryAmounts\" of the CurrencyConverterQueryState class", false);
            set_what("the CurrencyConverterQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCurrencyConverterCommandKind.reset();
            fieldGeneratorInputMonetaryAmounts.reset();
            fieldGeneratorOutputMonetaryAmounts.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorInputMonetaryAmounts.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputMonetaryAmounts.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorInputMonetaryAmounts.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputMonetaryAmounts.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CurrencyConverterQueryStateJSON  result)
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
        public CurrencyConverterQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CurrencyConverterQueryStateJSON  result)
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
    protected virtual void handle_result(List<CurrencyConverterQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CurrencyConverterQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CurrencyConverterQueryStateJSON>();
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
    public List<CurrencyConverterQueryStateJSON> value;
  };
  };
