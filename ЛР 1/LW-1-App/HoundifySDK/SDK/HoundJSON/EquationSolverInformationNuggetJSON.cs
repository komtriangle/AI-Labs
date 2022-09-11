/* file "EquationSolverInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EquationSolverInformationNuggetJSON : InformationNuggetJSON
  {
    public class TypeSolutionsJSON : JSONBase
      {
        private bool flagHasReal;
        private double storeReal;
        private string textStoreReal;
        private bool flagHasImaginary;
        private double storeImaginary;
        private string textStoreImaginary;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONReal(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field Real of TypeSolutionsJSON is not a number.");
                  }
              }
            setRealText(the_rational_text);
          }


        private void  fromJSONImaginary(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field Imaginary of TypeSolutionsJSON is not a number.");
                  }
              }
            setImaginaryText(the_rational_text);
          }


        public TypeSolutionsJSON()
          {
            flagHasReal = false;
            flagHasImaginary = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasReal()
          {
            return flagHasReal;
          }

        public double  getReal()
          {
            Debug.Assert(flagHasReal);
            if (textStoreReal != "")
              {
                return Double.Parse(textStoreReal);
              }
            return storeReal;
          }

        public string  getRealAsText()
          {
            Debug.Assert(flagHasReal);
            if (textStoreReal == "")
              {
                return Convert.ToString(storeReal);
              }
            else
              {
                return (textStoreReal);
              }
          }

        public bool  hasImaginary()
          {
            return flagHasImaginary;
          }

        public double  getImaginary()
          {
            Debug.Assert(flagHasImaginary);
            if (textStoreImaginary != "")
              {
                return Double.Parse(textStoreImaginary);
              }
            return storeImaginary;
          }

        public string  getImaginaryAsText()
          {
            Debug.Assert(flagHasImaginary);
            if (textStoreImaginary == "")
              {
                return Convert.ToString(storeImaginary);
              }
            else
              {
                return (textStoreImaginary);
              }
          }


        public virtual int extraTypeSolutionsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSolutionsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSolutionsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSolutionsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setReal(double new_value)
          {
            flagHasReal = true;
            storeReal = new_value;
            textStoreReal = "";
          }
        public void setRealText(string new_value)
          {
            flagHasReal = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Real of TypeSolutionsJSON is not a valid number.");
            textStoreReal = new_value;
          }
        public void unsetReal()
          {
            flagHasReal = false;
          }
        public void setImaginary(double new_value)
          {
            flagHasImaginary = true;
            storeImaginary = new_value;
            textStoreImaginary = "";
          }
        public void setImaginaryText(string new_value)
          {
            flagHasImaginary = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Imaginary of TypeSolutionsJSON is not a valid number.");
            textStoreImaginary = new_value;
          }
        public void unsetImaginary()
          {
            flagHasImaginary = false;
          }

        public virtual void extraTypeSolutionsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSolutionsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSolutionsLookup(key);
            if (old_field == null)
              {
                extraTypeSolutionsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasReal);
            if (flagHasReal)
              {
                handler.start_pair("Real");
                if (textStoreReal != "")
                    handler.number_value(textStoreReal);
                else if (((double)(long)storeReal) == storeReal)
                    handler.number_value((long)storeReal);
                else
                    handler.number_value(storeReal);
              }
            Debug.Assert(partial_allowed || flagHasImaginary);
            if (flagHasImaginary)
              {
                handler.start_pair("Imaginary");
                if (textStoreImaginary != "")
                    handler.number_value(textStoreImaginary);
                else if (((double)(long)storeImaginary) == storeImaginary)
                    handler.number_value((long)storeImaginary);
                else
                    handler.number_value(storeImaginary);
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
            if (!(hasReal()))
              {
                return "When parsing the object for %what%, the \"Real\" field was missing.";
              }
            if (!(hasImaginary()))
              {
                return "When parsing the object for %what%, the \"Imaginary\" field was missing.";
              }
            return null;
          }

        public static TypeSolutionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSolutionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSolutions", ignore_extras);
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
        public static TypeSolutionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSolutionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSolutionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSolutions", ignore_extras);
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
        public static TypeSolutionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSolutionsJSON from_text(string text, bool ignore_extras)
          {
            TypeSolutionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSolutions", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSolutionsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSolutionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSolutionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSolutions", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingNumberTextGenerator fieldGeneratorReal;
            private JSONHoldingNumberTextGenerator fieldGeneratorImaginary;
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
                TypeSolutionsJSON result = new TypeSolutionsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSolutionsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSolutionsJSON result)
              {
                if (fieldGeneratorReal.have_value)
                  {
                    result.setRealText(fieldGeneratorReal.value);
                    fieldGeneratorReal.have_value = false;
                  }
                else if ((!(result.hasReal())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Real\" field was missing.");
                  }
                if (fieldGeneratorImaginary.have_value)
                  {
                    result.setImaginaryText(fieldGeneratorImaginary.value);
                    fieldGeneratorImaginary.have_value = false;
                  }
                else if ((!(result.hasImaginary())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Imaginary\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeSolutionsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'I':
                        if ((String.Compare(field_name, 1, "maginary", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorImaginary;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "eal", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorReal;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorReal = new JSONHoldingNumberTextGenerator("field \"Real\" of the TypeSolutions class");
                fieldGeneratorImaginary = new JSONHoldingNumberTextGenerator("field \"Imaginary\" of the TypeSolutions class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSolutions class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorReal = new JSONHoldingNumberTextGenerator("field \"Real\" of the TypeSolutions class");
                fieldGeneratorImaginary = new JSONHoldingNumberTextGenerator("field \"Imaginary\" of the TypeSolutions class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSolutions class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorReal.reset();
                fieldGeneratorImaginary.reset();
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
            protected override void handle_result(TypeSolutionsJSON  result)
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
            public TypeSolutionsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSolutionsJSON  result)
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
        protected virtual void handle_result(List<TypeSolutionsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSolutionsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSolutionsJSON>();
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
        public List<TypeSolutionsJSON> value;
      };
      };
    private bool flagHasEquation;
    private string storeEquation;
    private bool flagHasVariable;
    private string storeVariable;
    private bool flagHasSolutions;
    private List< TypeSolutionsJSON  > storeSolutions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraEquationToJSON()
      {
        JSONStringValue generated_string_Equation = new JSONStringValue(storeEquation);
        return generated_string_Equation;
      }

    private JSONValue  extraVariableToJSON()
      {
        JSONStringValue generated_string_Variable = new JSONStringValue(storeVariable);
        return generated_string_Variable;
      }

    private JSONValue  extraSolutionsToJSON()
      {
        JSONArrayValue generated_array_1_Solutions = new JSONArrayValue();
        for (int num1 = 0; num1 < storeSolutions.Count; ++num1)
          {
            JSONValueHandler handler_Solutions = new JSONValueHandler();
            storeSolutions[num1].write_as_json(handler_Solutions);
            generated_array_1_Solutions.appendComponent(handler_Solutions.result);
          }
        return generated_array_1_Solutions;
      }


    private void  fromJSONEquation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Equation of EquationSolverInformationNuggetJSON is not a string.");
        setEquation(json_string.getData());
      }


    private void  fromJSONVariable(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Variable of EquationSolverInformationNuggetJSON is not a string.");
        setVariable(json_string.getData());
      }


    private void  fromJSONSolutions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Solutions of EquationSolverInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeSolutionsJSON  > vector_Solutions1 = new List< TypeSolutionsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeSolutionsJSON convert_classy = TypeSolutionsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Solutions1.Add(convert_classy);
          }
        initSolutions();
        for (int num1 = 0; num1 < vector_Solutions1.Count; ++num1)
            appendSolutions(vector_Solutions1[num1]);
        for (int num1 = 0; num1 < vector_Solutions1.Count; ++num1)
          {
          }
      }


    public EquationSolverInformationNuggetJSON()
      {
        flagHasEquation = false;
        flagHasVariable = false;
        flagHasSolutions = false;
        storeSolutions = new List< TypeSolutionsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "EquationSolverInformationNugget";
      }

    public bool  hasEquation()
      {
        return flagHasEquation;
      }

    public string  getEquation()
      {
        Debug.Assert(flagHasEquation);
        return storeEquation;
      }

    public bool  hasVariable()
      {
        return flagHasVariable;
      }

    public string  getVariable()
      {
        Debug.Assert(flagHasVariable);
        return storeVariable;
      }

    public bool  hasSolutions()
      {
        return flagHasSolutions;
      }

    public int  countOfSolutions()
      {
        Debug.Assert(flagHasSolutions);
        return storeSolutions.Count;
      }

    public TypeSolutionsJSON   elementOfSolutions(int element_num)
      {
        Debug.Assert(flagHasSolutions);
        return storeSolutions[element_num];
      }

    public List< TypeSolutionsJSON  >  getSolutions()
      {
        Debug.Assert(flagHasSolutions);
        return storeSolutions;
      }


    public virtual int extraEquationSolverInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraEquationSolverInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraEquationSolverInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraEquationSolverInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasEquation)
            ++result;
        if (flagHasVariable)
            ++result;
        if (flagHasSolutions)
            ++result;
        result += extraEquationSolverInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasEquation)
          {
            if (remainder == 0)
                return "Equation";
            --remainder;
          }
        if (flagHasVariable)
          {
            if (remainder == 0)
                return "Variable";
            --remainder;
          }
        if (flagHasSolutions)
          {
            if (remainder == 0)
                return "Solutions";
            --remainder;
          }
        return extraEquationSolverInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasEquation)
          {
            if (remainder == 0)
                return extraEquationToJSON();
            --remainder;
          }
        if (flagHasVariable)
          {
            if (remainder == 0)
                return extraVariableToJSON();
            --remainder;
          }
        if (flagHasSolutions)
          {
            if (remainder == 0)
                return extraSolutionsToJSON();
            --remainder;
          }
        return extraEquationSolverInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "quation", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasEquation ? extraEquationToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "olutions", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasSolutions ? extraSolutionsToJSON() : null);
                break;
            case 'V':
                if ((String.Compare(field_name, 1, "ariable", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasVariable ? extraVariableToJSON() : null);
                break;
            default:
                break;
          }
        return extraEquationSolverInformationNuggetLookup(field_name);
      }

    public void setEquation(string new_value)
      {
        flagHasEquation = true;
        storeEquation = new_value;
      }
    public void unsetEquation()
      {
        flagHasEquation = false;
      }
    public void setVariable(string new_value)
      {
        flagHasVariable = true;
        storeVariable = new_value;
      }
    public void unsetVariable()
      {
        flagHasVariable = false;
      }
    public void initSolutions()
      {
        if (flagHasSolutions)
          {
            for (int num1 = 0; num1 < storeSolutions.Count; ++num1)
              {
              }
          }
        flagHasSolutions = true;
        storeSolutions.Clear();
      }
    public void appendSolutions(TypeSolutionsJSON  to_append)
      {
        if (!flagHasSolutions)
          {
            flagHasSolutions = true;
            storeSolutions.Clear();
          }
        Debug.Assert(flagHasSolutions);
        storeSolutions.Add(to_append);
      }
    public void unsetSolutions()
      {
        if (flagHasSolutions)
          {
            for (int num2 = 0; num2 < storeSolutions.Count; ++num2)
              {
              }
          }
        flagHasSolutions = false;
        storeSolutions.Clear();
      }

    public virtual void extraEquationSolverInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraEquationSolverInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraEquationSolverInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraEquationSolverInformationNuggetAppendPair(key, new_component);
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
            case 'E':
                if ((String.Compare(key, 1, "quation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONEquation(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "olutions", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONSolutions(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if ((String.Compare(key, 1, "ariable", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONVariable(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraEquationSolverInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "quation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONEquation(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "olutions", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONSolutions(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if ((String.Compare(key, 1, "ariable", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONVariable(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraEquationSolverInformationNuggetSetField(key, new_component);
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
        if (flagHasEquation)
          {
            handler.start_pair("Equation");
            handler.string_value(storeEquation);
          }
        if (flagHasVariable)
          {
            handler.start_pair("Variable");
            handler.string_value(storeVariable);
          }
        if (flagHasSolutions)
          {
            handler.start_pair("Solutions");
            handler.start_array();
            for (int num1 = 0; num1 < storeSolutions.Count; ++num1)
              {
                if (partial_allowed)
                    storeSolutions[num1].write_partial_as_json(handler);
                else
                    storeSolutions[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new EquationSolverInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EquationSolverInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EquationSolverInformationNugget", ignore_extras);
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
    public static new EquationSolverInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new EquationSolverInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EquationSolverInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EquationSolverInformationNugget", ignore_extras);
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
    public static new EquationSolverInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new EquationSolverInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        EquationSolverInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EquationSolverInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EquationSolverInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new EquationSolverInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EquationSolverInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EquationSolverInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorEquation;
        private JSONHoldingStringGenerator fieldGeneratorVariable;
        private TypeSolutionsJSON.HoldingArrayGenerator fieldGeneratorSolutions;
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
            if (!(getInformationNuggetJSONKey().Equals("EquationSolverInformationNugget")))
                throw new Exception("The key field has a value other than `EquationSolverInformationNugget'.");
            EquationSolverInformationNuggetJSON result = new EquationSolverInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraEquationSolverInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((EquationSolverInformationNuggetJSON )new_result);
          }
        protected void finish(EquationSolverInformationNuggetJSON result)
          {
            if (fieldGeneratorEquation.have_value)
              {
                result.setEquation(fieldGeneratorEquation.value);
                fieldGeneratorEquation.have_value = false;
              }
            if (fieldGeneratorVariable.have_value)
              {
                result.setVariable(fieldGeneratorVariable.value);
                fieldGeneratorVariable.have_value = false;
              }
            if (fieldGeneratorSolutions.have_value)
              {
                result.initSolutions();
                int count = fieldGeneratorSolutions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSolutions(fieldGeneratorSolutions.value[num]);
                  }
                fieldGeneratorSolutions.value.Clear();
                fieldGeneratorSolutions.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(EquationSolverInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "quation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorEquation;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "olutions", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorSolutions;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ariable", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorVariable;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorEquation = new JSONHoldingStringGenerator("field \"Equation\" of the EquationSolverInformationNugget class");
            fieldGeneratorVariable = new JSONHoldingStringGenerator("field \"Variable\" of the EquationSolverInformationNugget class");
            fieldGeneratorSolutions = new TypeSolutionsJSON.HoldingArrayGenerator("field \"Solutions\" of the EquationSolverInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the EquationSolverInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorEquation = new JSONHoldingStringGenerator("field \"Equation\" of the EquationSolverInformationNugget class");
            fieldGeneratorVariable = new JSONHoldingStringGenerator("field \"Variable\" of the EquationSolverInformationNugget class");
            fieldGeneratorSolutions = new TypeSolutionsJSON.HoldingArrayGenerator("field \"Solutions\" of the EquationSolverInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the EquationSolverInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorEquation.reset();
            fieldGeneratorVariable.reset();
            fieldGeneratorSolutions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(EquationSolverInformationNuggetJSON  result)
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
        public EquationSolverInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EquationSolverInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<EquationSolverInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EquationSolverInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EquationSolverInformationNuggetJSON>();
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
    public List<EquationSolverInformationNuggetJSON> value;
  };
  };
