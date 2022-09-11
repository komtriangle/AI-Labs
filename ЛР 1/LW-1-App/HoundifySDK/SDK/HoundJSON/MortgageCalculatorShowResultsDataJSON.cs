/* file "MortgageCalculatorShowResultsDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorShowResultsDataJSON : JSONBase
  {
    public class TypeDownPaymentJSON : JSONBase
      {
        private bool flagHasMonetary;
        private AmountJSON  storeMonetary;
        private bool flagHasPercentage;
        private double storePercentage;
        private string textStorePercentage;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONMonetary(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
            setMonetary(convert_classy);
          }


        private void  fromJSONPercentage(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Percentage of TypeDownPaymentJSON is not a number.");
                  }
              }
            setPercentageText(the_rational_text);
          }


        public TypeDownPaymentJSON()
          {
            flagHasMonetary = false;
            flagHasPercentage = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasMonetary()
          {
            return flagHasMonetary;
          }

        public AmountJSON   getMonetary()
          {
            Debug.Assert(flagHasMonetary);
            return storeMonetary;
          }

        public bool  hasPercentage()
          {
            return flagHasPercentage;
          }

        public double  getPercentage()
          {
            Debug.Assert(flagHasPercentage);
            if (textStorePercentage != "")
              {
                return Double.Parse(textStorePercentage);
              }
            return storePercentage;
          }

        public string  getPercentageAsText()
          {
            Debug.Assert(flagHasPercentage);
            if (textStorePercentage == "")
              {
                return Convert.ToString(storePercentage);
              }
            else
              {
                return (textStorePercentage);
              }
          }


        public virtual int extraTypeDownPaymentComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDownPaymentComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDownPaymentComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDownPaymentLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setMonetary(AmountJSON  new_value)
          {
            if (flagHasMonetary)
              {
              }
            flagHasMonetary = true;
            storeMonetary = new_value;
          }
        public void unsetMonetary()
          {
            if (flagHasMonetary)
              {
              }
            flagHasMonetary = false;
          }
        public void setPercentage(double new_value)
          {
            flagHasPercentage = true;
            storePercentage = new_value;
            textStorePercentage = "";
          }
        public void setPercentageText(string new_value)
          {
            flagHasPercentage = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Percentage of TypeDownPaymentJSON is not a valid number.");
            textStorePercentage = new_value;
          }
        public void unsetPercentage()
          {
            flagHasPercentage = false;
          }

        public virtual void extraTypeDownPaymentAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDownPaymentSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDownPaymentLookup(key);
            if (old_field == null)
              {
                extraTypeDownPaymentAppendPair(key, new_component);
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
            if (flagHasMonetary)
              {
                handler.start_pair("Monetary");
                if (partial_allowed)
                    storeMonetary.write_partial_as_json(handler);
                else
                    storeMonetary.write_as_json(handler);
              }
            if (flagHasPercentage)
              {
                handler.start_pair("Percentage");
                if (textStorePercentage != "")
                    handler.number_value(textStorePercentage);
                else if (((double)(long)storePercentage) == storePercentage)
                    handler.number_value((long)storePercentage);
                else
                    handler.number_value(storePercentage);
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
            return null;
          }

        public static TypeDownPaymentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDownPaymentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDownPayment", ignore_extras);
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
        public static TypeDownPaymentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDownPaymentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDownPaymentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDownPayment", ignore_extras);
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
        public static TypeDownPaymentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDownPaymentJSON from_text(string text, bool ignore_extras)
          {
            TypeDownPaymentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDownPayment", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDownPaymentJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDownPaymentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDownPaymentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDownPayment", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private AmountJSON.HoldingGenerator fieldGeneratorMonetary;
            private JSONHoldingNumberTextGenerator fieldGeneratorPercentage;
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
                TypeDownPaymentJSON result = new TypeDownPaymentJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDownPaymentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDownPaymentJSON result)
              {
                if (fieldGeneratorMonetary.have_value)
                  {
                    result.setMonetary(fieldGeneratorMonetary.value);
                    fieldGeneratorMonetary.have_value = false;
                  }
                if (fieldGeneratorPercentage.have_value)
                  {
                    result.setPercentageText(fieldGeneratorPercentage.value);
                    fieldGeneratorPercentage.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeDownPaymentJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'M':
                        if ((String.Compare(field_name, 1, "onetary", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorMonetary;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "ercentage", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorPercentage;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorMonetary = new AmountJSON.HoldingGenerator("field \"Monetary\" of the TypeDownPayment class", ignore_extras);
                fieldGeneratorPercentage = new JSONHoldingNumberTextGenerator("field \"Percentage\" of the TypeDownPayment class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDownPayment class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorMonetary = new AmountJSON.HoldingGenerator("field \"Monetary\" of the TypeDownPayment class", false);
                fieldGeneratorPercentage = new JSONHoldingNumberTextGenerator("field \"Percentage\" of the TypeDownPayment class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDownPayment class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorMonetary.reset();
                fieldGeneratorPercentage.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorMonetary.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorMonetary.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeDownPaymentJSON  result)
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
            public TypeDownPaymentJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDownPaymentJSON  result)
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
        protected virtual void handle_result(List<TypeDownPaymentJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDownPaymentJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDownPaymentJSON>();
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
        public List<TypeDownPaymentJSON> value;
      };
      };
    public class TypeAuxiliaryResultsDataJSON : JSONBase
      {
        private bool flagHasTotalPaidPerYear;
        private AmountJSON  storeTotalPaidPerYear;
        private bool flagHasTotalPaidEntireMortgage;
        private AmountJSON  storeTotalPaidEntireMortgage;
        private bool flagHasInterestPaidFirstYear;
        private AmountJSON  storeInterestPaidFirstYear;
        private bool flagHasInterestPaidLastYear;
        private AmountJSON  storeInterestPaidLastYear;
        private bool flagHasInterestPaidEntireMortgage;
        private AmountJSON  storeInterestPaidEntireMortgage;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTotalPaidPerYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
            setTotalPaidPerYear(convert_classy);
          }


        private void  fromJSONTotalPaidEntireMortgage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
            setTotalPaidEntireMortgage(convert_classy);
          }


        private void  fromJSONInterestPaidFirstYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
            setInterestPaidFirstYear(convert_classy);
          }


        private void  fromJSONInterestPaidLastYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
            setInterestPaidLastYear(convert_classy);
          }


        private void  fromJSONInterestPaidEntireMortgage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
            setInterestPaidEntireMortgage(convert_classy);
          }


        public TypeAuxiliaryResultsDataJSON()
          {
            flagHasTotalPaidPerYear = false;
            flagHasTotalPaidEntireMortgage = false;
            flagHasInterestPaidFirstYear = false;
            flagHasInterestPaidLastYear = false;
            flagHasInterestPaidEntireMortgage = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTotalPaidPerYear()
          {
            return flagHasTotalPaidPerYear;
          }

        public AmountJSON   getTotalPaidPerYear()
          {
            Debug.Assert(flagHasTotalPaidPerYear);
            return storeTotalPaidPerYear;
          }

        public bool  hasTotalPaidEntireMortgage()
          {
            return flagHasTotalPaidEntireMortgage;
          }

        public AmountJSON   getTotalPaidEntireMortgage()
          {
            Debug.Assert(flagHasTotalPaidEntireMortgage);
            return storeTotalPaidEntireMortgage;
          }

        public bool  hasInterestPaidFirstYear()
          {
            return flagHasInterestPaidFirstYear;
          }

        public AmountJSON   getInterestPaidFirstYear()
          {
            Debug.Assert(flagHasInterestPaidFirstYear);
            return storeInterestPaidFirstYear;
          }

        public bool  hasInterestPaidLastYear()
          {
            return flagHasInterestPaidLastYear;
          }

        public AmountJSON   getInterestPaidLastYear()
          {
            Debug.Assert(flagHasInterestPaidLastYear);
            return storeInterestPaidLastYear;
          }

        public bool  hasInterestPaidEntireMortgage()
          {
            return flagHasInterestPaidEntireMortgage;
          }

        public AmountJSON   getInterestPaidEntireMortgage()
          {
            Debug.Assert(flagHasInterestPaidEntireMortgage);
            return storeInterestPaidEntireMortgage;
          }


        public virtual int extraTypeAuxiliaryResultsDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAuxiliaryResultsDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAuxiliaryResultsDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAuxiliaryResultsDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTotalPaidPerYear(AmountJSON  new_value)
          {
            if (flagHasTotalPaidPerYear)
              {
              }
            flagHasTotalPaidPerYear = true;
            storeTotalPaidPerYear = new_value;
          }
        public void unsetTotalPaidPerYear()
          {
            if (flagHasTotalPaidPerYear)
              {
              }
            flagHasTotalPaidPerYear = false;
          }
        public void setTotalPaidEntireMortgage(AmountJSON  new_value)
          {
            if (flagHasTotalPaidEntireMortgage)
              {
              }
            flagHasTotalPaidEntireMortgage = true;
            storeTotalPaidEntireMortgage = new_value;
          }
        public void unsetTotalPaidEntireMortgage()
          {
            if (flagHasTotalPaidEntireMortgage)
              {
              }
            flagHasTotalPaidEntireMortgage = false;
          }
        public void setInterestPaidFirstYear(AmountJSON  new_value)
          {
            if (flagHasInterestPaidFirstYear)
              {
              }
            flagHasInterestPaidFirstYear = true;
            storeInterestPaidFirstYear = new_value;
          }
        public void unsetInterestPaidFirstYear()
          {
            if (flagHasInterestPaidFirstYear)
              {
              }
            flagHasInterestPaidFirstYear = false;
          }
        public void setInterestPaidLastYear(AmountJSON  new_value)
          {
            if (flagHasInterestPaidLastYear)
              {
              }
            flagHasInterestPaidLastYear = true;
            storeInterestPaidLastYear = new_value;
          }
        public void unsetInterestPaidLastYear()
          {
            if (flagHasInterestPaidLastYear)
              {
              }
            flagHasInterestPaidLastYear = false;
          }
        public void setInterestPaidEntireMortgage(AmountJSON  new_value)
          {
            if (flagHasInterestPaidEntireMortgage)
              {
              }
            flagHasInterestPaidEntireMortgage = true;
            storeInterestPaidEntireMortgage = new_value;
          }
        public void unsetInterestPaidEntireMortgage()
          {
            if (flagHasInterestPaidEntireMortgage)
              {
              }
            flagHasInterestPaidEntireMortgage = false;
          }

        public virtual void extraTypeAuxiliaryResultsDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAuxiliaryResultsDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAuxiliaryResultsDataLookup(key);
            if (old_field == null)
              {
                extraTypeAuxiliaryResultsDataAppendPair(key, new_component);
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
            if (flagHasTotalPaidPerYear)
              {
                handler.start_pair("TotalPaidPerYear");
                if (partial_allowed)
                    storeTotalPaidPerYear.write_partial_as_json(handler);
                else
                    storeTotalPaidPerYear.write_as_json(handler);
              }
            if (flagHasTotalPaidEntireMortgage)
              {
                handler.start_pair("TotalPaidEntireMortgage");
                if (partial_allowed)
                    storeTotalPaidEntireMortgage.write_partial_as_json(handler);
                else
                    storeTotalPaidEntireMortgage.write_as_json(handler);
              }
            if (flagHasInterestPaidFirstYear)
              {
                handler.start_pair("InterestPaidFirstYear");
                if (partial_allowed)
                    storeInterestPaidFirstYear.write_partial_as_json(handler);
                else
                    storeInterestPaidFirstYear.write_as_json(handler);
              }
            if (flagHasInterestPaidLastYear)
              {
                handler.start_pair("InterestPaidLastYear");
                if (partial_allowed)
                    storeInterestPaidLastYear.write_partial_as_json(handler);
                else
                    storeInterestPaidLastYear.write_as_json(handler);
              }
            if (flagHasInterestPaidEntireMortgage)
              {
                handler.start_pair("InterestPaidEntireMortgage");
                if (partial_allowed)
                    storeInterestPaidEntireMortgage.write_partial_as_json(handler);
                else
                    storeInterestPaidEntireMortgage.write_as_json(handler);
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
            return null;
          }

        public static TypeAuxiliaryResultsDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAuxiliaryResultsDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAuxiliaryResultsData", ignore_extras);
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
        public static TypeAuxiliaryResultsDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAuxiliaryResultsDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAuxiliaryResultsDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAuxiliaryResultsData", ignore_extras);
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
        public static TypeAuxiliaryResultsDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAuxiliaryResultsDataJSON from_text(string text, bool ignore_extras)
          {
            TypeAuxiliaryResultsDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAuxiliaryResultsData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAuxiliaryResultsDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAuxiliaryResultsDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAuxiliaryResultsDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAuxiliaryResultsData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private AmountJSON.HoldingGenerator fieldGeneratorTotalPaidPerYear;
            private AmountJSON.HoldingGenerator fieldGeneratorTotalPaidEntireMortgage;
            private AmountJSON.HoldingGenerator fieldGeneratorInterestPaidFirstYear;
            private AmountJSON.HoldingGenerator fieldGeneratorInterestPaidLastYear;
            private AmountJSON.HoldingGenerator fieldGeneratorInterestPaidEntireMortgage;
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
                TypeAuxiliaryResultsDataJSON result = new TypeAuxiliaryResultsDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAuxiliaryResultsDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAuxiliaryResultsDataJSON result)
              {
                if (fieldGeneratorTotalPaidPerYear.have_value)
                  {
                    result.setTotalPaidPerYear(fieldGeneratorTotalPaidPerYear.value);
                    fieldGeneratorTotalPaidPerYear.have_value = false;
                  }
                if (fieldGeneratorTotalPaidEntireMortgage.have_value)
                  {
                    result.setTotalPaidEntireMortgage(fieldGeneratorTotalPaidEntireMortgage.value);
                    fieldGeneratorTotalPaidEntireMortgage.have_value = false;
                  }
                if (fieldGeneratorInterestPaidFirstYear.have_value)
                  {
                    result.setInterestPaidFirstYear(fieldGeneratorInterestPaidFirstYear.value);
                    fieldGeneratorInterestPaidFirstYear.have_value = false;
                  }
                if (fieldGeneratorInterestPaidLastYear.have_value)
                  {
                    result.setInterestPaidLastYear(fieldGeneratorInterestPaidLastYear.value);
                    fieldGeneratorInterestPaidLastYear.have_value = false;
                  }
                if (fieldGeneratorInterestPaidEntireMortgage.have_value)
                  {
                    result.setInterestPaidEntireMortgage(fieldGeneratorInterestPaidEntireMortgage.value);
                    fieldGeneratorInterestPaidEntireMortgage.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeAuxiliaryResultsDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'I':
                        if (String.Compare(field_name, 1, "nterestPaid", 0, 11, false) == 0)
                          {
                            switch (field_name[12])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 13, "ntireMortgage", 0, 13, false) == 0) && (field_name.Length == 26))
                                        return fieldGeneratorInterestPaidEntireMortgage;
                                    break;
                                case 'F':
                                    if ((String.Compare(field_name, 13, "irstYear", 0, 8, false) == 0) && (field_name.Length == 21))
                                        return fieldGeneratorInterestPaidFirstYear;
                                    break;
                                case 'L':
                                    if ((String.Compare(field_name, 13, "astYear", 0, 7, false) == 0) && (field_name.Length == 20))
                                        return fieldGeneratorInterestPaidLastYear;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'T':
                        if (String.Compare(field_name, 1, "otalPaid", 0, 8, false) == 0)
                          {
                            switch (field_name[9])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 10, "ntireMortgage", 0, 13, false) == 0) && (field_name.Length == 23))
                                        return fieldGeneratorTotalPaidEntireMortgage;
                                    break;
                                case 'P':
                                    if ((String.Compare(field_name, 10, "erYear", 0, 6, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorTotalPaidPerYear;
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
                fieldGeneratorTotalPaidPerYear = new AmountJSON.HoldingGenerator("field \"TotalPaidPerYear\" of the TypeAuxiliaryResultsData class", ignore_extras);
                fieldGeneratorTotalPaidEntireMortgage = new AmountJSON.HoldingGenerator("field \"TotalPaidEntireMortgage\" of the TypeAuxiliaryResultsData class", ignore_extras);
                fieldGeneratorInterestPaidFirstYear = new AmountJSON.HoldingGenerator("field \"InterestPaidFirstYear\" of the TypeAuxiliaryResultsData class", ignore_extras);
                fieldGeneratorInterestPaidLastYear = new AmountJSON.HoldingGenerator("field \"InterestPaidLastYear\" of the TypeAuxiliaryResultsData class", ignore_extras);
                fieldGeneratorInterestPaidEntireMortgage = new AmountJSON.HoldingGenerator("field \"InterestPaidEntireMortgage\" of the TypeAuxiliaryResultsData class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAuxiliaryResultsData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTotalPaidPerYear = new AmountJSON.HoldingGenerator("field \"TotalPaidPerYear\" of the TypeAuxiliaryResultsData class", false);
                fieldGeneratorTotalPaidEntireMortgage = new AmountJSON.HoldingGenerator("field \"TotalPaidEntireMortgage\" of the TypeAuxiliaryResultsData class", false);
                fieldGeneratorInterestPaidFirstYear = new AmountJSON.HoldingGenerator("field \"InterestPaidFirstYear\" of the TypeAuxiliaryResultsData class", false);
                fieldGeneratorInterestPaidLastYear = new AmountJSON.HoldingGenerator("field \"InterestPaidLastYear\" of the TypeAuxiliaryResultsData class", false);
                fieldGeneratorInterestPaidEntireMortgage = new AmountJSON.HoldingGenerator("field \"InterestPaidEntireMortgage\" of the TypeAuxiliaryResultsData class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAuxiliaryResultsData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTotalPaidPerYear.reset();
                fieldGeneratorTotalPaidEntireMortgage.reset();
                fieldGeneratorInterestPaidFirstYear.reset();
                fieldGeneratorInterestPaidLastYear.reset();
                fieldGeneratorInterestPaidEntireMortgage.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorTotalPaidPerYear.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTotalPaidEntireMortgage.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorInterestPaidFirstYear.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorInterestPaidLastYear.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorInterestPaidEntireMortgage.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorTotalPaidPerYear.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTotalPaidEntireMortgage.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorInterestPaidFirstYear.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorInterestPaidLastYear.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorInterestPaidEntireMortgage.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeAuxiliaryResultsDataJSON  result)
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
            public TypeAuxiliaryResultsDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAuxiliaryResultsDataJSON  result)
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
        protected virtual void handle_result(List<TypeAuxiliaryResultsDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAuxiliaryResultsDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAuxiliaryResultsDataJSON>();
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
        public List<TypeAuxiliaryResultsDataJSON> value;
      };
      };
    public enum TypeErrorKnownValues
      {
        Error_AmortizationInfinite,
        Error_DownPaymentNegative,
        Error_DownPaymentExceedsHomeValue,
        Error_Precision,
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
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "mortizationInfinite", 0, 19, false) == 0) && (chars.Length == 20))
                    return TypeErrorKnownValues.Error_AmortizationInfinite;
                break;
            case 'D':
                if (String.Compare(chars, 1, "ownPayment", 0, 10, false) == 0)
                  {
                    switch (chars[11])
                      {
                        case 'E':
                            if ((String.Compare(chars, 12, "xceedsHomeValue", 0, 15, false) == 0) && (chars.Length == 27))
                                return TypeErrorKnownValues.Error_DownPaymentExceedsHomeValue;
                            break;
                        case 'N':
                            if ((String.Compare(chars, 12, "egative", 0, 7, false) == 0) && (chars.Length == 19))
                                return TypeErrorKnownValues.Error_DownPaymentNegative;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if ((String.Compare(chars, 1, "recision", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeErrorKnownValues.Error_Precision;
                break;
            default:
                break;
          }
        return TypeErrorKnownValues.Error__none;
      }

    public static string  stringFromError(TypeErrorKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeErrorKnownValues.Error_AmortizationInfinite:
                return "AmortizationInfinite";
            case TypeErrorKnownValues.Error_DownPaymentNegative:
                return "DownPaymentNegative";
            case TypeErrorKnownValues.Error_DownPaymentExceedsHomeValue:
                return "DownPaymentExceedsHomeValue";
            case TypeErrorKnownValues.Error_Precision:
                return "Precision";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasPayment;
    private AmountJSON  storePayment;
    private bool flagHasInterestPaid;
    private AmountJSON  storeInterestPaid;
    private bool flagHasPrincipalPaid;
    private AmountJSON  storePrincipalPaid;
    private bool flagHasTotalPaid;
    private AmountJSON  storeTotalPaid;
    private bool flagHasDownPayment;
    private TypeDownPaymentJSON  storeDownPayment;
    private bool flagHasAmortizationPeriod;
    private MortgageCalculatorAmortizationPeriodJSON  storeAmortizationPeriod;
    private bool flagHasInterestRate;
    private double storeInterestRate;
    private string textStoreInterestRate;
    private bool flagHasPrincipal;
    private AmountJSON  storePrincipal;
    private bool flagHasPrincipalRemaining;
    private AmountJSON  storePrincipalRemaining;
    private bool flagHasHomeValue;
    private AmountJSON  storeHomeValue;
    private bool flagHasAuxiliaryResultsData;
    private TypeAuxiliaryResultsDataJSON  storeAuxiliaryResultsData;
    private bool flagHasError;
    private TypeError storeError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPayment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setPayment(convert_classy);
      }


    private void  fromJSONInterestPaid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setInterestPaid(convert_classy);
      }


    private void  fromJSONPrincipalPaid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setPrincipalPaid(convert_classy);
      }


    private void  fromJSONTotalPaid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setTotalPaid(convert_classy);
      }


    private void  fromJSONDownPayment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDownPaymentJSON convert_classy = TypeDownPaymentJSON.from_json(json_value, ignore_extras, true);
        setDownPayment(convert_classy);
      }


    private void  fromJSONAmortizationPeriod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MortgageCalculatorAmortizationPeriodJSON convert_classy = MortgageCalculatorAmortizationPeriodJSON.from_json(json_value, ignore_extras, true);
        setAmortizationPeriod(convert_classy);
      }


    private void  fromJSONInterestRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field InterestRate of MortgageCalculatorShowResultsDataJSON is not a number.");
              }
          }
        setInterestRateText(the_rational_text);
      }


    private void  fromJSONPrincipal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setPrincipal(convert_classy);
      }


    private void  fromJSONPrincipalRemaining(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setPrincipalRemaining(convert_classy);
      }


    private void  fromJSONHomeValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setHomeValue(convert_classy);
      }


    private void  fromJSONAuxiliaryResultsData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeAuxiliaryResultsDataJSON convert_classy = TypeAuxiliaryResultsDataJSON.from_json(json_value, ignore_extras, true);
        setAuxiliaryResultsData(convert_classy);
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Error of MortgageCalculatorShowResultsDataJSON is not a string.");
        TypeError the_open_enum = new TypeError();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "mortizationInfinite", 0, 19, false) == 0) && (json_string.getData().Length == 20))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeErrorKnownValues.Error_AmortizationInfinite;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if (String.Compare(json_string.getData(), 1, "ownPayment", 0, 10, false) == 0)
                  {
                    switch (json_string.getData()[11])
                      {
                        case 'E':
                            if ((String.Compare(json_string.getData(), 12, "xceedsHomeValue", 0, 15, false) == 0) && (json_string.getData().Length == 27))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeErrorKnownValues.Error_DownPaymentExceedsHomeValue;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'N':
                            if ((String.Compare(json_string.getData(), 12, "egative", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeErrorKnownValues.Error_DownPaymentNegative;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "recision", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeErrorKnownValues.Error_Precision;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setError(the_open_enum);
      }


    public MortgageCalculatorShowResultsDataJSON()
      {
        flagHasPayment = false;
        flagHasInterestPaid = false;
        flagHasPrincipalPaid = false;
        flagHasTotalPaid = false;
        flagHasDownPayment = false;
        flagHasAmortizationPeriod = false;
        flagHasInterestRate = false;
        flagHasPrincipal = false;
        flagHasPrincipalRemaining = false;
        flagHasHomeValue = false;
        flagHasAuxiliaryResultsData = false;
        flagHasError = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPayment()
      {
        return flagHasPayment;
      }

    public AmountJSON   getPayment()
      {
        Debug.Assert(flagHasPayment);
        return storePayment;
      }

    public bool  hasInterestPaid()
      {
        return flagHasInterestPaid;
      }

    public AmountJSON   getInterestPaid()
      {
        Debug.Assert(flagHasInterestPaid);
        return storeInterestPaid;
      }

    public bool  hasPrincipalPaid()
      {
        return flagHasPrincipalPaid;
      }

    public AmountJSON   getPrincipalPaid()
      {
        Debug.Assert(flagHasPrincipalPaid);
        return storePrincipalPaid;
      }

    public bool  hasTotalPaid()
      {
        return flagHasTotalPaid;
      }

    public AmountJSON   getTotalPaid()
      {
        Debug.Assert(flagHasTotalPaid);
        return storeTotalPaid;
      }

    public bool  hasDownPayment()
      {
        return flagHasDownPayment;
      }

    public TypeDownPaymentJSON   getDownPayment()
      {
        Debug.Assert(flagHasDownPayment);
        return storeDownPayment;
      }

    public bool  hasAmortizationPeriod()
      {
        return flagHasAmortizationPeriod;
      }

    public MortgageCalculatorAmortizationPeriodJSON   getAmortizationPeriod()
      {
        Debug.Assert(flagHasAmortizationPeriod);
        return storeAmortizationPeriod;
      }

    public bool  hasInterestRate()
      {
        return flagHasInterestRate;
      }

    public double  getInterestRate()
      {
        Debug.Assert(flagHasInterestRate);
        if (textStoreInterestRate != "")
          {
            return Double.Parse(textStoreInterestRate);
          }
        return storeInterestRate;
      }

    public string  getInterestRateAsText()
      {
        Debug.Assert(flagHasInterestRate);
        if (textStoreInterestRate == "")
          {
            return Convert.ToString(storeInterestRate);
          }
        else
          {
            return (textStoreInterestRate);
          }
      }

    public bool  hasPrincipal()
      {
        return flagHasPrincipal;
      }

    public AmountJSON   getPrincipal()
      {
        Debug.Assert(flagHasPrincipal);
        return storePrincipal;
      }

    public bool  hasPrincipalRemaining()
      {
        return flagHasPrincipalRemaining;
      }

    public AmountJSON   getPrincipalRemaining()
      {
        Debug.Assert(flagHasPrincipalRemaining);
        return storePrincipalRemaining;
      }

    public bool  hasHomeValue()
      {
        return flagHasHomeValue;
      }

    public AmountJSON   getHomeValue()
      {
        Debug.Assert(flagHasHomeValue);
        return storeHomeValue;
      }

    public bool  hasAuxiliaryResultsData()
      {
        return flagHasAuxiliaryResultsData;
      }

    public TypeAuxiliaryResultsDataJSON   getAuxiliaryResultsData()
      {
        Debug.Assert(flagHasAuxiliaryResultsData);
        return storeAuxiliaryResultsData;
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


    public virtual int extraMortgageCalculatorShowResultsDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorShowResultsDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorShowResultsDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorShowResultsDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPayment(AmountJSON  new_value)
      {
        if (flagHasPayment)
          {
          }
        flagHasPayment = true;
        storePayment = new_value;
      }
    public void unsetPayment()
      {
        if (flagHasPayment)
          {
          }
        flagHasPayment = false;
      }
    public void setInterestPaid(AmountJSON  new_value)
      {
        if (flagHasInterestPaid)
          {
          }
        flagHasInterestPaid = true;
        storeInterestPaid = new_value;
      }
    public void unsetInterestPaid()
      {
        if (flagHasInterestPaid)
          {
          }
        flagHasInterestPaid = false;
      }
    public void setPrincipalPaid(AmountJSON  new_value)
      {
        if (flagHasPrincipalPaid)
          {
          }
        flagHasPrincipalPaid = true;
        storePrincipalPaid = new_value;
      }
    public void unsetPrincipalPaid()
      {
        if (flagHasPrincipalPaid)
          {
          }
        flagHasPrincipalPaid = false;
      }
    public void setTotalPaid(AmountJSON  new_value)
      {
        if (flagHasTotalPaid)
          {
          }
        flagHasTotalPaid = true;
        storeTotalPaid = new_value;
      }
    public void unsetTotalPaid()
      {
        if (flagHasTotalPaid)
          {
          }
        flagHasTotalPaid = false;
      }
    public void setDownPayment(TypeDownPaymentJSON  new_value)
      {
        if (flagHasDownPayment)
          {
          }
        flagHasDownPayment = true;
        storeDownPayment = new_value;
      }
    public void unsetDownPayment()
      {
        if (flagHasDownPayment)
          {
          }
        flagHasDownPayment = false;
      }
    public void setAmortizationPeriod(MortgageCalculatorAmortizationPeriodJSON  new_value)
      {
        if (flagHasAmortizationPeriod)
          {
          }
        flagHasAmortizationPeriod = true;
        storeAmortizationPeriod = new_value;
      }
    public void unsetAmortizationPeriod()
      {
        if (flagHasAmortizationPeriod)
          {
          }
        flagHasAmortizationPeriod = false;
      }
    public void setInterestRate(double new_value)
      {
        flagHasInterestRate = true;
        storeInterestRate = new_value;
        textStoreInterestRate = "";
      }
    public void setInterestRateText(string new_value)
      {
        flagHasInterestRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field InterestRate of MortgageCalculatorShowResultsDataJSON is not a valid number.");
        textStoreInterestRate = new_value;
      }
    public void unsetInterestRate()
      {
        flagHasInterestRate = false;
      }
    public void setPrincipal(AmountJSON  new_value)
      {
        if (flagHasPrincipal)
          {
          }
        flagHasPrincipal = true;
        storePrincipal = new_value;
      }
    public void unsetPrincipal()
      {
        if (flagHasPrincipal)
          {
          }
        flagHasPrincipal = false;
      }
    public void setPrincipalRemaining(AmountJSON  new_value)
      {
        if (flagHasPrincipalRemaining)
          {
          }
        flagHasPrincipalRemaining = true;
        storePrincipalRemaining = new_value;
      }
    public void unsetPrincipalRemaining()
      {
        if (flagHasPrincipalRemaining)
          {
          }
        flagHasPrincipalRemaining = false;
      }
    public void setHomeValue(AmountJSON  new_value)
      {
        if (flagHasHomeValue)
          {
          }
        flagHasHomeValue = true;
        storeHomeValue = new_value;
      }
    public void unsetHomeValue()
      {
        if (flagHasHomeValue)
          {
          }
        flagHasHomeValue = false;
      }
    public void setAuxiliaryResultsData(TypeAuxiliaryResultsDataJSON  new_value)
      {
        if (flagHasAuxiliaryResultsData)
          {
          }
        flagHasAuxiliaryResultsData = true;
        storeAuxiliaryResultsData = new_value;
      }
    public void unsetAuxiliaryResultsData()
      {
        if (flagHasAuxiliaryResultsData)
          {
          }
        flagHasAuxiliaryResultsData = false;
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

    public virtual void extraMortgageCalculatorShowResultsDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorShowResultsDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorShowResultsDataLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorShowResultsDataAppendPair(key, new_component);
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
        if (flagHasPayment)
          {
            handler.start_pair("Payment");
            if (partial_allowed)
                storePayment.write_partial_as_json(handler);
            else
                storePayment.write_as_json(handler);
          }
        if (flagHasInterestPaid)
          {
            handler.start_pair("InterestPaid");
            if (partial_allowed)
                storeInterestPaid.write_partial_as_json(handler);
            else
                storeInterestPaid.write_as_json(handler);
          }
        if (flagHasPrincipalPaid)
          {
            handler.start_pair("PrincipalPaid");
            if (partial_allowed)
                storePrincipalPaid.write_partial_as_json(handler);
            else
                storePrincipalPaid.write_as_json(handler);
          }
        if (flagHasTotalPaid)
          {
            handler.start_pair("TotalPaid");
            if (partial_allowed)
                storeTotalPaid.write_partial_as_json(handler);
            else
                storeTotalPaid.write_as_json(handler);
          }
        if (flagHasDownPayment)
          {
            handler.start_pair("DownPayment");
            if (partial_allowed)
                storeDownPayment.write_partial_as_json(handler);
            else
                storeDownPayment.write_as_json(handler);
          }
        if (flagHasAmortizationPeriod)
          {
            handler.start_pair("AmortizationPeriod");
            if (partial_allowed)
                storeAmortizationPeriod.write_partial_as_json(handler);
            else
                storeAmortizationPeriod.write_as_json(handler);
          }
        if (flagHasInterestRate)
          {
            handler.start_pair("InterestRate");
            if (textStoreInterestRate != "")
                handler.number_value(textStoreInterestRate);
            else if (((double)(long)storeInterestRate) == storeInterestRate)
                handler.number_value((long)storeInterestRate);
            else
                handler.number_value(storeInterestRate);
          }
        if (flagHasPrincipal)
          {
            handler.start_pair("Principal");
            if (partial_allowed)
                storePrincipal.write_partial_as_json(handler);
            else
                storePrincipal.write_as_json(handler);
          }
        if (flagHasPrincipalRemaining)
          {
            handler.start_pair("PrincipalRemaining");
            if (partial_allowed)
                storePrincipalRemaining.write_partial_as_json(handler);
            else
                storePrincipalRemaining.write_as_json(handler);
          }
        if (flagHasHomeValue)
          {
            handler.start_pair("HomeValue");
            if (partial_allowed)
                storeHomeValue.write_partial_as_json(handler);
            else
                storeHomeValue.write_as_json(handler);
          }
        if (flagHasAuxiliaryResultsData)
          {
            handler.start_pair("AuxiliaryResultsData");
            if (partial_allowed)
                storeAuxiliaryResultsData.write_partial_as_json(handler);
            else
                storeAuxiliaryResultsData.write_as_json(handler);
          }
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (storeError.in_known_list)
              {
                switch (storeError.list_value)
                  {
                    case TypeErrorKnownValues.Error_AmortizationInfinite:
                        handler.string_value("AmortizationInfinite");
                        break;
                    case TypeErrorKnownValues.Error_DownPaymentNegative:
                        handler.string_value("DownPaymentNegative");
                        break;
                    case TypeErrorKnownValues.Error_DownPaymentExceedsHomeValue:
                        handler.string_value("DownPaymentExceedsHomeValue");
                        break;
                    case TypeErrorKnownValues.Error_Precision:
                        handler.string_value("Precision");
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static MortgageCalculatorShowResultsDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorShowResultsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsData", ignore_extras);
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
    public static MortgageCalculatorShowResultsDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MortgageCalculatorShowResultsDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorShowResultsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsData", ignore_extras);
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
    public static MortgageCalculatorShowResultsDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MortgageCalculatorShowResultsDataJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorShowResultsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorShowResultsDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MortgageCalculatorShowResultsDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorShowResultsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private AmountJSON.HoldingGenerator fieldGeneratorPayment;
        private AmountJSON.HoldingGenerator fieldGeneratorInterestPaid;
        private AmountJSON.HoldingGenerator fieldGeneratorPrincipalPaid;
        private AmountJSON.HoldingGenerator fieldGeneratorTotalPaid;
        private TypeDownPaymentJSON.HoldingGenerator fieldGeneratorDownPayment;
        private MortgageCalculatorAmortizationPeriodJSON.HoldingGenerator fieldGeneratorAmortizationPeriod;
        private JSONHoldingNumberTextGenerator fieldGeneratorInterestRate;
        private AmountJSON.HoldingGenerator fieldGeneratorPrincipal;
        private AmountJSON.HoldingGenerator fieldGeneratorPrincipalRemaining;
        private AmountJSON.HoldingGenerator fieldGeneratorHomeValue;
        private TypeAuxiliaryResultsDataJSON.HoldingGenerator fieldGeneratorAuxiliaryResultsData;
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
            MortgageCalculatorShowResultsDataJSON result = new MortgageCalculatorShowResultsDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorShowResultsDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MortgageCalculatorShowResultsDataJSON result)
          {
            if (fieldGeneratorPayment.have_value)
              {
                result.setPayment(fieldGeneratorPayment.value);
                fieldGeneratorPayment.have_value = false;
              }
            if (fieldGeneratorInterestPaid.have_value)
              {
                result.setInterestPaid(fieldGeneratorInterestPaid.value);
                fieldGeneratorInterestPaid.have_value = false;
              }
            if (fieldGeneratorPrincipalPaid.have_value)
              {
                result.setPrincipalPaid(fieldGeneratorPrincipalPaid.value);
                fieldGeneratorPrincipalPaid.have_value = false;
              }
            if (fieldGeneratorTotalPaid.have_value)
              {
                result.setTotalPaid(fieldGeneratorTotalPaid.value);
                fieldGeneratorTotalPaid.have_value = false;
              }
            if (fieldGeneratorDownPayment.have_value)
              {
                result.setDownPayment(fieldGeneratorDownPayment.value);
                fieldGeneratorDownPayment.have_value = false;
              }
            if (fieldGeneratorAmortizationPeriod.have_value)
              {
                result.setAmortizationPeriod(fieldGeneratorAmortizationPeriod.value);
                fieldGeneratorAmortizationPeriod.have_value = false;
              }
            if (fieldGeneratorInterestRate.have_value)
              {
                result.setInterestRateText(fieldGeneratorInterestRate.value);
                fieldGeneratorInterestRate.have_value = false;
              }
            if (fieldGeneratorPrincipal.have_value)
              {
                result.setPrincipal(fieldGeneratorPrincipal.value);
                fieldGeneratorPrincipal.have_value = false;
              }
            if (fieldGeneratorPrincipalRemaining.have_value)
              {
                result.setPrincipalRemaining(fieldGeneratorPrincipalRemaining.value);
                fieldGeneratorPrincipalRemaining.have_value = false;
              }
            if (fieldGeneratorHomeValue.have_value)
              {
                result.setHomeValue(fieldGeneratorHomeValue.value);
                fieldGeneratorHomeValue.have_value = false;
              }
            if (fieldGeneratorAuxiliaryResultsData.have_value)
              {
                result.setAuxiliaryResultsData(fieldGeneratorAuxiliaryResultsData.value);
                fieldGeneratorAuxiliaryResultsData.have_value = false;
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
          }
        protected abstract void handle_result(MortgageCalculatorShowResultsDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "ortizationPeriod", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorAmortizationPeriod;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "xiliaryResultsData", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorAuxiliaryResultsData;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ownPayment", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDownPayment;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "omeValue", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorHomeValue;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "nterest", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 9, "aid", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorInterestPaid;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 9, "ate", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorInterestRate;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "yment", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorPayment;
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "incipal", 0, 7, false) == 0)
                              {
                                if (field_name.Length == 9)
                                  {
                                    return fieldGeneratorPrincipal;
                                  }
                                switch (field_name[9])
                                  {
                                    case 'P':
                                        if ((String.Compare(field_name, 10, "aid", 0, 3, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorPrincipalPaid;
                                        break;
                                    case 'R':
                                        if ((String.Compare(field_name, 10, "emaining", 0, 8, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorPrincipalRemaining;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "otalPaid", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorTotalPaid;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPayment = new AmountJSON.HoldingGenerator("field \"Payment\" of the MortgageCalculatorShowResultsData class", ignore_extras);
            fieldGeneratorInterestPaid = new AmountJSON.HoldingGenerator("field \"InterestPaid\" of the MortgageCalculatorShowResultsData class", ignore_extras);
            fieldGeneratorPrincipalPaid = new AmountJSON.HoldingGenerator("field \"PrincipalPaid\" of the MortgageCalculatorShowResultsData class", ignore_extras);
            fieldGeneratorTotalPaid = new AmountJSON.HoldingGenerator("field \"TotalPaid\" of the MortgageCalculatorShowResultsData class", ignore_extras);
            fieldGeneratorDownPayment = new TypeDownPaymentJSON.HoldingGenerator("field \"DownPayment\" of the MortgageCalculatorShowResultsData class", ignore_extras);
            fieldGeneratorAmortizationPeriod = new MortgageCalculatorAmortizationPeriodJSON.HoldingGenerator("field \"AmortizationPeriod\" of the MortgageCalculatorShowResultsData class", ignore_extras);
            fieldGeneratorInterestRate = new JSONHoldingNumberTextGenerator("field \"InterestRate\" of the MortgageCalculatorShowResultsData class");
            fieldGeneratorPrincipal = new AmountJSON.HoldingGenerator("field \"Principal\" of the MortgageCalculatorShowResultsData class", ignore_extras);
            fieldGeneratorPrincipalRemaining = new AmountJSON.HoldingGenerator("field \"PrincipalRemaining\" of the MortgageCalculatorShowResultsData class", ignore_extras);
            fieldGeneratorHomeValue = new AmountJSON.HoldingGenerator("field \"HomeValue\" of the MortgageCalculatorShowResultsData class", ignore_extras);
            fieldGeneratorAuxiliaryResultsData = new TypeAuxiliaryResultsDataJSON.HoldingGenerator("field \"AuxiliaryResultsData\" of the MortgageCalculatorShowResultsData class", ignore_extras);
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the MortgageCalculatorShowResultsData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorShowResultsData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPayment = new AmountJSON.HoldingGenerator("field \"Payment\" of the MortgageCalculatorShowResultsData class", false);
            fieldGeneratorInterestPaid = new AmountJSON.HoldingGenerator("field \"InterestPaid\" of the MortgageCalculatorShowResultsData class", false);
            fieldGeneratorPrincipalPaid = new AmountJSON.HoldingGenerator("field \"PrincipalPaid\" of the MortgageCalculatorShowResultsData class", false);
            fieldGeneratorTotalPaid = new AmountJSON.HoldingGenerator("field \"TotalPaid\" of the MortgageCalculatorShowResultsData class", false);
            fieldGeneratorDownPayment = new TypeDownPaymentJSON.HoldingGenerator("field \"DownPayment\" of the MortgageCalculatorShowResultsData class", false);
            fieldGeneratorAmortizationPeriod = new MortgageCalculatorAmortizationPeriodJSON.HoldingGenerator("field \"AmortizationPeriod\" of the MortgageCalculatorShowResultsData class", false);
            fieldGeneratorInterestRate = new JSONHoldingNumberTextGenerator("field \"InterestRate\" of the MortgageCalculatorShowResultsData class");
            fieldGeneratorPrincipal = new AmountJSON.HoldingGenerator("field \"Principal\" of the MortgageCalculatorShowResultsData class", false);
            fieldGeneratorPrincipalRemaining = new AmountJSON.HoldingGenerator("field \"PrincipalRemaining\" of the MortgageCalculatorShowResultsData class", false);
            fieldGeneratorHomeValue = new AmountJSON.HoldingGenerator("field \"HomeValue\" of the MortgageCalculatorShowResultsData class", false);
            fieldGeneratorAuxiliaryResultsData = new TypeAuxiliaryResultsDataJSON.HoldingGenerator("field \"AuxiliaryResultsData\" of the MortgageCalculatorShowResultsData class", false);
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the MortgageCalculatorShowResultsData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorShowResultsData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPayment.reset();
            fieldGeneratorInterestPaid.reset();
            fieldGeneratorPrincipalPaid.reset();
            fieldGeneratorTotalPaid.reset();
            fieldGeneratorDownPayment.reset();
            fieldGeneratorAmortizationPeriod.reset();
            fieldGeneratorInterestRate.reset();
            fieldGeneratorPrincipal.reset();
            fieldGeneratorPrincipalRemaining.reset();
            fieldGeneratorHomeValue.reset();
            fieldGeneratorAuxiliaryResultsData.reset();
            fieldGeneratorError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPayment.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInterestPaid.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrincipalPaid.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTotalPaid.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDownPayment.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmortizationPeriod.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrincipal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrincipalRemaining.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHomeValue.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAuxiliaryResultsData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPayment.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInterestPaid.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrincipalPaid.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTotalPaid.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDownPayment.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmortizationPeriod.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrincipal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrincipalRemaining.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHomeValue.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAuxiliaryResultsData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorShowResultsDataJSON  result)
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
        public MortgageCalculatorShowResultsDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorShowResultsDataJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorShowResultsDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorShowResultsDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorShowResultsDataJSON>();
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
    public List<MortgageCalculatorShowResultsDataJSON> value;
  };
  };
