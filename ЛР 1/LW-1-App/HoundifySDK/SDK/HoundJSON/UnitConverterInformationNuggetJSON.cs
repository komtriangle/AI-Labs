/* file "UnitConverterInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UnitConverterInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasConversions;
    private List< UnitConversionJSON  > storeConversions;
    private bool flagHasErrors;
    private List< UnitConversionErrorJSON  > storeErrors;


    private JSONValue  extraConversionsToJSON()
      {
        JSONArrayValue generated_array_1_Conversions = new JSONArrayValue();
        for (int num1 = 0; num1 < storeConversions.Count; ++num1)
          {
            JSONValueHandler handler_Conversions = new JSONValueHandler();
            storeConversions[num1].write_as_json(handler_Conversions);
            generated_array_1_Conversions.appendComponent(handler_Conversions.result);
          }
        return generated_array_1_Conversions;
      }

    private JSONValue  extraErrorsToJSON()
      {
        JSONArrayValue generated_array_2_Errors = new JSONArrayValue();
        for (int num2 = 0; num2 < storeErrors.Count; ++num2)
          {
            JSONValueHandler handler_Errors = new JSONValueHandler();
            storeErrors[num2].write_as_json(handler_Errors);
            generated_array_2_Errors.appendComponent(handler_Errors.result);
          }
        return generated_array_2_Errors;
      }


    private void  fromJSONConversions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Conversions of UnitConverterInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UnitConversionJSON  > vector_Conversions1 = new List< UnitConversionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UnitConversionJSON convert_classy = UnitConversionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Conversions1.Add(convert_classy);
          }
        initConversions();
        for (int num1 = 0; num1 < vector_Conversions1.Count; ++num1)
            appendConversions(vector_Conversions1[num1]);
        for (int num1 = 0; num1 < vector_Conversions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONErrors(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Errors of UnitConverterInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Errors of UnitConverterInformationNuggetJSON has too few elements.");
        List< UnitConversionErrorJSON  > vector_Errors1 = new List< UnitConversionErrorJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UnitConversionErrorJSON convert_classy = UnitConversionErrorJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Errors1.Add(convert_classy);
          }
        Debug.Assert(vector_Errors1.Count >= 1);
        initErrors();
        for (int num2 = 0; num2 < vector_Errors1.Count; ++num2)
            appendErrors(vector_Errors1[num2]);
        for (int num1 = 0; num1 < vector_Errors1.Count; ++num1)
          {
          }
      }


    public UnitConverterInformationNuggetJSON()
      {
        flagHasConversions = false;
        flagHasErrors = false;
        storeConversions = new List< UnitConversionJSON  >();
        storeErrors = new List< UnitConversionErrorJSON  >();
      }

    public override string  getNuggetKind()
      {
        return "UnitConverter";
      }

    public bool  hasConversions()
      {
        return flagHasConversions;
      }

    public int  countOfConversions()
      {
        Debug.Assert(flagHasConversions);
        return storeConversions.Count;
      }

    public UnitConversionJSON   elementOfConversions(int element_num)
      {
        Debug.Assert(flagHasConversions);
        return storeConversions[element_num];
      }

    public List< UnitConversionJSON  >  getConversions()
      {
        Debug.Assert(flagHasConversions);
        return storeConversions;
      }

    public bool  hasErrors()
      {
        return flagHasErrors;
      }

    public int  countOfErrors()
      {
        Debug.Assert(flagHasErrors);
        return storeErrors.Count;
      }

    public UnitConversionErrorJSON   elementOfErrors(int element_num)
      {
        Debug.Assert(flagHasErrors);
        return storeErrors[element_num];
      }

    public List< UnitConversionErrorJSON  >  getErrors()
      {
        Debug.Assert(flagHasErrors);
        return storeErrors;
      }


    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasConversions)
            ++result;
        if (flagHasErrors)
            ++result;
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasConversions)
          {
            if (remainder == 0)
                return "Conversions";
            --remainder;
          }
        if (flagHasErrors)
          {
            if (remainder == 0)
                return "Errors";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasConversions)
          {
            if (remainder == 0)
                return extraConversionsToJSON();
            --remainder;
          }
        if (flagHasErrors)
          {
            if (remainder == 0)
                return extraErrorsToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "onversions", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasConversions ? extraConversionsToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "rrors", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasErrors ? extraErrorsToJSON() : null);
                break;
            default:
                break;
          }
        return null;
      }

    public void initConversions()
      {
        if (flagHasConversions)
          {
            for (int num1 = 0; num1 < storeConversions.Count; ++num1)
              {
              }
          }
        flagHasConversions = true;
        storeConversions.Clear();
      }
    public void appendConversions(UnitConversionJSON  to_append)
      {
        if (!flagHasConversions)
          {
            flagHasConversions = true;
            storeConversions.Clear();
          }
        Debug.Assert(flagHasConversions);
        storeConversions.Add(to_append);
      }
    public void unsetConversions()
      {
        if (flagHasConversions)
          {
            for (int num2 = 0; num2 < storeConversions.Count; ++num2)
              {
              }
          }
        flagHasConversions = false;
        storeConversions.Clear();
      }
    public void initErrors()
      {
        if (flagHasErrors)
          {
            for (int num3 = 0; num3 < storeErrors.Count; ++num3)
              {
              }
          }
        flagHasErrors = true;
        storeErrors.Clear();
      }
    public void appendErrors(UnitConversionErrorJSON  to_append)
      {
        if (!flagHasErrors)
          {
            flagHasErrors = true;
            storeErrors.Clear();
          }
        Debug.Assert(flagHasErrors);
        storeErrors.Add(to_append);
      }
    public void unsetErrors()
      {
        if (flagHasErrors)
          {
            for (int num4 = 0; num4 < storeErrors.Count; ++num4)
              {
              }
          }
        flagHasErrors = false;
        storeErrors.Clear();
      }

    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "onversions", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONConversions(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "rrors", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONErrors(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "onversions", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONConversions(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "rrors", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONErrors(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasConversions);
        if (flagHasConversions)
          {
            handler.start_pair("Conversions");
            handler.start_array();
            for (int num1 = 0; num1 < storeConversions.Count; ++num1)
              {
                if (partial_allowed)
                    storeConversions[num1].write_partial_as_json(handler);
                else
                    storeConversions[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasErrors)
          {
            handler.start_pair("Errors");
            Debug.Assert(storeErrors.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeErrors.Count; ++num2)
              {
                if (partial_allowed)
                    storeErrors[num2].write_partial_as_json(handler);
                else
                    storeErrors[num2].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasConversions()))
          {
            return "When parsing the object for %what%, the \"Conversions\" field was missing.";
          }
        return null;
      }

    public static new UnitConverterInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConverterInformationNugget", ignore_extras);
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
    public static new UnitConverterInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UnitConverterInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UnitConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConverterInformationNugget", ignore_extras);
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
    public static new UnitConverterInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UnitConverterInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        UnitConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConverterInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UnitConverterInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UnitConverterInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UnitConverterInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UnitConverterInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private UnitConversionJSON.HoldingArrayGenerator fieldGeneratorConversions;
        private UnitConversionErrorJSON.HoldingArrayGenerator fieldGeneratorErrors;

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
            if (!(getInformationNuggetJSONKey().Equals("UnitConverter")))
                throw new Exception("The key field has a value other than `UnitConverter'.");
            UnitConverterInformationNuggetJSON result = new UnitConverterInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((UnitConverterInformationNuggetJSON )new_result);
          }
        protected void finish(UnitConverterInformationNuggetJSON result)
          {
            if (fieldGeneratorConversions.have_value)
              {
                result.initConversions();
                int count = fieldGeneratorConversions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendConversions(fieldGeneratorConversions.value[num]);
                  }
                fieldGeneratorConversions.value.Clear();
                fieldGeneratorConversions.have_value = false;
              }
            else if ((!(result.hasConversions())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Conversions\" field was missing.");
              }
            if (fieldGeneratorErrors.have_value)
              {
                result.initErrors();
                int count = fieldGeneratorErrors.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendErrors(fieldGeneratorErrors.value[num]);
                  }
                fieldGeneratorErrors.value.Clear();
                fieldGeneratorErrors.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(UnitConverterInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "onversions", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorConversions;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rrors", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorErrors;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorConversions = new UnitConversionJSON.HoldingArrayGenerator("field \"Conversions\" of the UnitConverterInformationNugget class", ignore_extras);
            fieldGeneratorErrors = new UnitConversionErrorJSON.HoldingArrayGenerator("field \"Errors\" of the UnitConverterInformationNugget class", ignore_extras);
            set_what("the UnitConverterInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorConversions = new UnitConversionJSON.HoldingArrayGenerator("field \"Conversions\" of the UnitConverterInformationNugget class", false);
            fieldGeneratorErrors = new UnitConversionErrorJSON.HoldingArrayGenerator("field \"Errors\" of the UnitConverterInformationNugget class", false);
            set_what("the UnitConverterInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorConversions.reset();
            fieldGeneratorErrors.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UnitConverterInformationNuggetJSON  result)
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
        public UnitConverterInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UnitConverterInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<UnitConverterInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UnitConverterInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UnitConverterInformationNuggetJSON>();
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
    public List<UnitConverterInformationNuggetJSON> value;
  };
  };
