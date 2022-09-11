/* file "UberFareJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberFareJSON : JSONBase
  {
    public enum TypeDistanceUnitKnownValues
      {
        DistanceUnit_mile,
        DistanceUnit_km,
        DistanceUnit__none
      };
    public struct TypeDistanceUnit
      {
        public bool in_known_list;
        public string string_value;
        public TypeDistanceUnitKnownValues list_value;
      };

    public static TypeDistanceUnitKnownValues  stringToDistanceUnit(string chars)
      {
        switch (chars[0])
          {
            case 'k':
                if ((String.Compare(chars, 1, "m", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeDistanceUnitKnownValues.DistanceUnit_km;
                break;
            case 'm':
                if ((String.Compare(chars, 1, "ile", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeDistanceUnitKnownValues.DistanceUnit_mile;
                break;
            default:
                break;
          }
        return TypeDistanceUnitKnownValues.DistanceUnit__none;
      }

    public static string  stringFromDistanceUnit(TypeDistanceUnitKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeDistanceUnitKnownValues.DistanceUnit_mile:
                return "mile";
            case TypeDistanceUnitKnownValues.DistanceUnit_km:
                return "km";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeServiceFeesJSON : JSONBase
      {
        private bool flagHasName;
        private string storeName;
        private bool flagHasFee;
        private double storeFee;
        private string textStoreFee;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Name of TypeServiceFeesJSON is not a string.");
            setName(json_string.getData());
          }


        private void  fromJSONFee(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Fee of TypeServiceFeesJSON is not a number.");
                  }
              }
            setFeeText(the_rational_text);
          }


        public TypeServiceFeesJSON()
          {
            flagHasName = false;
            flagHasFee = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasName()
          {
            return flagHasName;
          }

        public string  getName()
          {
            Debug.Assert(flagHasName);
            return storeName;
          }

        public bool  hasFee()
          {
            return flagHasFee;
          }

        public double  getFee()
          {
            Debug.Assert(flagHasFee);
            if (textStoreFee != "")
              {
                return Double.Parse(textStoreFee);
              }
            return storeFee;
          }

        public string  getFeeAsText()
          {
            Debug.Assert(flagHasFee);
            if (textStoreFee == "")
              {
                return Convert.ToString(storeFee);
              }
            else
              {
                return (textStoreFee);
              }
          }


        public virtual int extraTypeServiceFeesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeServiceFeesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeServiceFeesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeServiceFeesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setName(string new_value)
          {
            flagHasName = true;
            storeName = new_value;
          }
        public void unsetName()
          {
            flagHasName = false;
          }
        public void setFee(double new_value)
          {
            flagHasFee = true;
            storeFee = new_value;
            textStoreFee = "";
          }
        public void setFeeText(string new_value)
          {
            flagHasFee = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Fee of TypeServiceFeesJSON is not a valid number.");
            textStoreFee = new_value;
          }
        public void unsetFee()
          {
            flagHasFee = false;
          }

        public virtual void extraTypeServiceFeesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeServiceFeesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeServiceFeesLookup(key);
            if (old_field == null)
              {
                extraTypeServiceFeesAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasName);
            if (flagHasName)
              {
                handler.start_pair("Name");
                handler.string_value(storeName);
              }
            Debug.Assert(partial_allowed || flagHasFee);
            if (flagHasFee)
              {
                handler.start_pair("Fee");
                if (textStoreFee != "")
                    handler.number_value(textStoreFee);
                else if (((double)(long)storeFee) == storeFee)
                    handler.number_value((long)storeFee);
                else
                    handler.number_value(storeFee);
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
            if (!(hasName()))
              {
                return "When parsing the object for %what%, the \"Name\" field was missing.";
              }
            if (!(hasFee()))
              {
                return "When parsing the object for %what%, the \"Fee\" field was missing.";
              }
            return null;
          }

        public static TypeServiceFeesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeServiceFeesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeServiceFees", ignore_extras);
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
        public static TypeServiceFeesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeServiceFeesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeServiceFeesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeServiceFees", ignore_extras);
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
        public static TypeServiceFeesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeServiceFeesJSON from_text(string text, bool ignore_extras)
          {
            TypeServiceFeesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeServiceFees", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeServiceFeesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeServiceFeesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeServiceFeesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeServiceFees", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorName;
            private JSONHoldingNumberTextGenerator fieldGeneratorFee;
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
                TypeServiceFeesJSON result = new TypeServiceFeesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeServiceFeesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeServiceFeesJSON result)
              {
                if (fieldGeneratorName.have_value)
                  {
                    result.setName(fieldGeneratorName.value);
                    fieldGeneratorName.have_value = false;
                  }
                else if ((!(result.hasName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Name\" field was missing.");
                  }
                if (fieldGeneratorFee.have_value)
                  {
                    result.setFeeText(fieldGeneratorFee.value);
                    fieldGeneratorFee.have_value = false;
                  }
                else if ((!(result.hasFee())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Fee\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeServiceFeesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'F':
                        if ((String.Compare(field_name, 1, "ee", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorFee;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorName;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeServiceFees class");
                fieldGeneratorFee = new JSONHoldingNumberTextGenerator("field \"Fee\" of the TypeServiceFees class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeServiceFees class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeServiceFees class");
                fieldGeneratorFee = new JSONHoldingNumberTextGenerator("field \"Fee\" of the TypeServiceFees class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeServiceFees class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorName.reset();
                fieldGeneratorFee.reset();
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
            protected override void handle_result(TypeServiceFeesJSON  result)
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
            public TypeServiceFeesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeServiceFeesJSON  result)
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
        protected virtual void handle_result(List<TypeServiceFeesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeServiceFeesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeServiceFeesJSON>();
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
        public List<TypeServiceFeesJSON> value;
      };
      };
    private bool flagHasBasePrice;
    private double storeBasePrice;
    private string textStoreBasePrice;
    private bool flagHasMinimumPrice;
    private double storeMinimumPrice;
    private string textStoreMinimumPrice;
    private bool flagHasRatePerMinute;
    private double storeRatePerMinute;
    private string textStoreRatePerMinute;
    private bool flagHasRatePerDistance;
    private double storeRatePerDistance;
    private string textStoreRatePerDistance;
    private bool flagHasDistanceUnit;
    private TypeDistanceUnit storeDistanceUnit;
    private bool flagHasCancellationFee;
    private double storeCancellationFee;
    private string textStoreCancellationFee;
    private bool flagHasCurrency;
    private string storeCurrency;
    private bool flagHasServiceFees;
    private List< TypeServiceFeesJSON  > storeServiceFees;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONBasePrice(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field BasePrice of UberFareJSON is not a number.");
              }
          }
        setBasePriceText(the_rational_text);
      }


    private void  fromJSONMinimumPrice(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MinimumPrice of UberFareJSON is not a number.");
              }
          }
        setMinimumPriceText(the_rational_text);
      }


    private void  fromJSONRatePerMinute(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RatePerMinute of UberFareJSON is not a number.");
              }
          }
        setRatePerMinuteText(the_rational_text);
      }


    private void  fromJSONRatePerDistance(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RatePerDistance of UberFareJSON is not a number.");
              }
          }
        setRatePerDistanceText(the_rational_text);
      }


    private void  fromJSONDistanceUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DistanceUnit of UberFareJSON is not a string.");
        TypeDistanceUnit the_open_enum = new TypeDistanceUnit();
        switch (json_string.getData()[0])
          {
            case 'k':
                if ((String.Compare(json_string.getData(), 1, "m", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDistanceUnitKnownValues.DistanceUnit_km;
                        goto open_enum_is_done;
                      }
                break;
            case 'm':
                if ((String.Compare(json_string.getData(), 1, "ile", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDistanceUnitKnownValues.DistanceUnit_mile;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setDistanceUnit(the_open_enum);
      }


    private void  fromJSONCancellationFee(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CancellationFee of UberFareJSON is not a number.");
              }
          }
        setCancellationFeeText(the_rational_text);
      }


    private void  fromJSONCurrency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Currency of UberFareJSON is not a string.");
        setCurrency(json_string.getData());
      }


    private void  fromJSONServiceFees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ServiceFees of UberFareJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeServiceFeesJSON  > vector_ServiceFees1 = new List< TypeServiceFeesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeServiceFeesJSON convert_classy = TypeServiceFeesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ServiceFees1.Add(convert_classy);
          }
        initServiceFees();
        for (int num1 = 0; num1 < vector_ServiceFees1.Count; ++num1)
            appendServiceFees(vector_ServiceFees1[num1]);
        for (int num1 = 0; num1 < vector_ServiceFees1.Count; ++num1)
          {
          }
      }


    public UberFareJSON()
      {
        flagHasBasePrice = false;
        flagHasMinimumPrice = false;
        flagHasRatePerMinute = false;
        flagHasRatePerDistance = false;
        flagHasDistanceUnit = false;
        flagHasCancellationFee = false;
        flagHasCurrency = false;
        flagHasServiceFees = false;
        storeServiceFees = new List< TypeServiceFeesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasBasePrice()
      {
        return flagHasBasePrice;
      }

    public double  getBasePrice()
      {
        Debug.Assert(flagHasBasePrice);
        if (textStoreBasePrice != "")
          {
            return Double.Parse(textStoreBasePrice);
          }
        return storeBasePrice;
      }

    public string  getBasePriceAsText()
      {
        Debug.Assert(flagHasBasePrice);
        if (textStoreBasePrice == "")
          {
            return Convert.ToString(storeBasePrice);
          }
        else
          {
            return (textStoreBasePrice);
          }
      }

    public bool  hasMinimumPrice()
      {
        return flagHasMinimumPrice;
      }

    public double  getMinimumPrice()
      {
        Debug.Assert(flagHasMinimumPrice);
        if (textStoreMinimumPrice != "")
          {
            return Double.Parse(textStoreMinimumPrice);
          }
        return storeMinimumPrice;
      }

    public string  getMinimumPriceAsText()
      {
        Debug.Assert(flagHasMinimumPrice);
        if (textStoreMinimumPrice == "")
          {
            return Convert.ToString(storeMinimumPrice);
          }
        else
          {
            return (textStoreMinimumPrice);
          }
      }

    public bool  hasRatePerMinute()
      {
        return flagHasRatePerMinute;
      }

    public double  getRatePerMinute()
      {
        Debug.Assert(flagHasRatePerMinute);
        if (textStoreRatePerMinute != "")
          {
            return Double.Parse(textStoreRatePerMinute);
          }
        return storeRatePerMinute;
      }

    public string  getRatePerMinuteAsText()
      {
        Debug.Assert(flagHasRatePerMinute);
        if (textStoreRatePerMinute == "")
          {
            return Convert.ToString(storeRatePerMinute);
          }
        else
          {
            return (textStoreRatePerMinute);
          }
      }

    public bool  hasRatePerDistance()
      {
        return flagHasRatePerDistance;
      }

    public double  getRatePerDistance()
      {
        Debug.Assert(flagHasRatePerDistance);
        if (textStoreRatePerDistance != "")
          {
            return Double.Parse(textStoreRatePerDistance);
          }
        return storeRatePerDistance;
      }

    public string  getRatePerDistanceAsText()
      {
        Debug.Assert(flagHasRatePerDistance);
        if (textStoreRatePerDistance == "")
          {
            return Convert.ToString(storeRatePerDistance);
          }
        else
          {
            return (textStoreRatePerDistance);
          }
      }

    public bool  hasDistanceUnit()
      {
        return flagHasDistanceUnit;
      }

    public TypeDistanceUnit  getDistanceUnit()
      {
        Debug.Assert(flagHasDistanceUnit);
        return storeDistanceUnit;
      }

    public string  getDistanceUnitAsString()
      {
        TypeDistanceUnit result = getDistanceUnit();
        if (result.in_known_list)
            return stringFromDistanceUnit(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasCancellationFee()
      {
        return flagHasCancellationFee;
      }

    public double  getCancellationFee()
      {
        Debug.Assert(flagHasCancellationFee);
        if (textStoreCancellationFee != "")
          {
            return Double.Parse(textStoreCancellationFee);
          }
        return storeCancellationFee;
      }

    public string  getCancellationFeeAsText()
      {
        Debug.Assert(flagHasCancellationFee);
        if (textStoreCancellationFee == "")
          {
            return Convert.ToString(storeCancellationFee);
          }
        else
          {
            return (textStoreCancellationFee);
          }
      }

    public bool  hasCurrency()
      {
        return flagHasCurrency;
      }

    public string  getCurrency()
      {
        Debug.Assert(flagHasCurrency);
        return storeCurrency;
      }

    public bool  hasServiceFees()
      {
        return flagHasServiceFees;
      }

    public int  countOfServiceFees()
      {
        Debug.Assert(flagHasServiceFees);
        return storeServiceFees.Count;
      }

    public TypeServiceFeesJSON   elementOfServiceFees(int element_num)
      {
        Debug.Assert(flagHasServiceFees);
        return storeServiceFees[element_num];
      }

    public List< TypeServiceFeesJSON  >  getServiceFees()
      {
        Debug.Assert(flagHasServiceFees);
        return storeServiceFees;
      }


    public virtual int extraUberFareComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberFareComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberFareComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberFareLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setBasePrice(double new_value)
      {
        flagHasBasePrice = true;
        storeBasePrice = new_value;
        textStoreBasePrice = "";
      }
    public void setBasePriceText(string new_value)
      {
        flagHasBasePrice = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field BasePrice of UberFareJSON is not a valid number.");
        textStoreBasePrice = new_value;
      }
    public void unsetBasePrice()
      {
        flagHasBasePrice = false;
      }
    public void setMinimumPrice(double new_value)
      {
        flagHasMinimumPrice = true;
        storeMinimumPrice = new_value;
        textStoreMinimumPrice = "";
      }
    public void setMinimumPriceText(string new_value)
      {
        flagHasMinimumPrice = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MinimumPrice of UberFareJSON is not a valid number.");
        textStoreMinimumPrice = new_value;
      }
    public void unsetMinimumPrice()
      {
        flagHasMinimumPrice = false;
      }
    public void setRatePerMinute(double new_value)
      {
        flagHasRatePerMinute = true;
        storeRatePerMinute = new_value;
        textStoreRatePerMinute = "";
      }
    public void setRatePerMinuteText(string new_value)
      {
        flagHasRatePerMinute = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field RatePerMinute of UberFareJSON is not a valid number.");
        textStoreRatePerMinute = new_value;
      }
    public void unsetRatePerMinute()
      {
        flagHasRatePerMinute = false;
      }
    public void setRatePerDistance(double new_value)
      {
        flagHasRatePerDistance = true;
        storeRatePerDistance = new_value;
        textStoreRatePerDistance = "";
      }
    public void setRatePerDistanceText(string new_value)
      {
        flagHasRatePerDistance = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field RatePerDistance of UberFareJSON is not a valid number.");
        textStoreRatePerDistance = new_value;
      }
    public void unsetRatePerDistance()
      {
        flagHasRatePerDistance = false;
      }
    public void setDistanceUnit(TypeDistanceUnit new_value)
      {
        flagHasDistanceUnit = true;
        storeDistanceUnit = new_value;
      }
    public void setDistanceUnit(string chars)
      {
        TypeDistanceUnitKnownValues known = stringToDistanceUnit(chars);
        TypeDistanceUnit new_value = new TypeDistanceUnit();
        if (known == TypeDistanceUnitKnownValues.DistanceUnit__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDistanceUnit(new_value);
      }
    public void setDistanceUnit(TypeDistanceUnitKnownValues new_value)
      {
        TypeDistanceUnit new_full_value = new TypeDistanceUnit();
        Debug.Assert(new_value != TypeDistanceUnitKnownValues.DistanceUnit__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setDistanceUnit(new_full_value);
      }
    public void unsetDistanceUnit()
      {
        flagHasDistanceUnit = false;
      }
    public void setCancellationFee(double new_value)
      {
        flagHasCancellationFee = true;
        storeCancellationFee = new_value;
        textStoreCancellationFee = "";
      }
    public void setCancellationFeeText(string new_value)
      {
        flagHasCancellationFee = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field CancellationFee of UberFareJSON is not a valid number.");
        textStoreCancellationFee = new_value;
      }
    public void unsetCancellationFee()
      {
        flagHasCancellationFee = false;
      }
    public void setCurrency(string new_value)
      {
        flagHasCurrency = true;
        storeCurrency = new_value;
      }
    public void unsetCurrency()
      {
        flagHasCurrency = false;
      }
    public void initServiceFees()
      {
        if (flagHasServiceFees)
          {
            for (int num1 = 0; num1 < storeServiceFees.Count; ++num1)
              {
              }
          }
        flagHasServiceFees = true;
        storeServiceFees.Clear();
      }
    public void appendServiceFees(TypeServiceFeesJSON  to_append)
      {
        if (!flagHasServiceFees)
          {
            flagHasServiceFees = true;
            storeServiceFees.Clear();
          }
        Debug.Assert(flagHasServiceFees);
        storeServiceFees.Add(to_append);
      }
    public void unsetServiceFees()
      {
        if (flagHasServiceFees)
          {
            for (int num2 = 0; num2 < storeServiceFees.Count; ++num2)
              {
              }
          }
        flagHasServiceFees = false;
        storeServiceFees.Clear();
      }

    public virtual void extraUberFareAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberFareSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberFareLookup(key);
        if (old_field == null)
          {
            extraUberFareAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasBasePrice);
        if (flagHasBasePrice)
          {
            handler.start_pair("BasePrice");
            if (textStoreBasePrice != "")
                handler.number_value(textStoreBasePrice);
            else if (((double)(long)storeBasePrice) == storeBasePrice)
                handler.number_value((long)storeBasePrice);
            else
                handler.number_value(storeBasePrice);
          }
        Debug.Assert(partial_allowed || flagHasMinimumPrice);
        if (flagHasMinimumPrice)
          {
            handler.start_pair("MinimumPrice");
            if (textStoreMinimumPrice != "")
                handler.number_value(textStoreMinimumPrice);
            else if (((double)(long)storeMinimumPrice) == storeMinimumPrice)
                handler.number_value((long)storeMinimumPrice);
            else
                handler.number_value(storeMinimumPrice);
          }
        if (flagHasRatePerMinute)
          {
            handler.start_pair("RatePerMinute");
            if (textStoreRatePerMinute != "")
                handler.number_value(textStoreRatePerMinute);
            else if (((double)(long)storeRatePerMinute) == storeRatePerMinute)
                handler.number_value((long)storeRatePerMinute);
            else
                handler.number_value(storeRatePerMinute);
          }
        if (flagHasRatePerDistance)
          {
            handler.start_pair("RatePerDistance");
            if (textStoreRatePerDistance != "")
                handler.number_value(textStoreRatePerDistance);
            else if (((double)(long)storeRatePerDistance) == storeRatePerDistance)
                handler.number_value((long)storeRatePerDistance);
            else
                handler.number_value(storeRatePerDistance);
          }
        Debug.Assert(partial_allowed || flagHasDistanceUnit);
        if (flagHasDistanceUnit)
          {
            handler.start_pair("DistanceUnit");
            if (storeDistanceUnit.in_known_list)
              {
                switch (storeDistanceUnit.list_value)
                  {
                    case TypeDistanceUnitKnownValues.DistanceUnit_mile:
                        handler.string_value("mile");
                        break;
                    case TypeDistanceUnitKnownValues.DistanceUnit_km:
                        handler.string_value("km");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeDistanceUnit.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasCancellationFee);
        if (flagHasCancellationFee)
          {
            handler.start_pair("CancellationFee");
            if (textStoreCancellationFee != "")
                handler.number_value(textStoreCancellationFee);
            else if (((double)(long)storeCancellationFee) == storeCancellationFee)
                handler.number_value((long)storeCancellationFee);
            else
                handler.number_value(storeCancellationFee);
          }
        Debug.Assert(partial_allowed || flagHasCurrency);
        if (flagHasCurrency)
          {
            handler.start_pair("Currency");
            handler.string_value(storeCurrency);
          }
        Debug.Assert(partial_allowed || flagHasServiceFees);
        if (flagHasServiceFees)
          {
            handler.start_pair("ServiceFees");
            handler.start_array();
            for (int num1 = 0; num1 < storeServiceFees.Count; ++num1)
              {
                if (partial_allowed)
                    storeServiceFees[num1].write_partial_as_json(handler);
                else
                    storeServiceFees[num1].write_as_json(handler);
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
        if (!(hasBasePrice()))
          {
            return "When parsing the object for %what%, the \"BasePrice\" field was missing.";
          }
        if (!(hasMinimumPrice()))
          {
            return "When parsing the object for %what%, the \"MinimumPrice\" field was missing.";
          }
        if (!(hasDistanceUnit()))
          {
            return "When parsing the object for %what%, the \"DistanceUnit\" field was missing.";
          }
        if (!(hasCancellationFee()))
          {
            return "When parsing the object for %what%, the \"CancellationFee\" field was missing.";
          }
        if (!(hasCurrency()))
          {
            return "When parsing the object for %what%, the \"Currency\" field was missing.";
          }
        if (!(hasServiceFees()))
          {
            return "When parsing the object for %what%, the \"ServiceFees\" field was missing.";
          }
        return null;
      }

    public static UberFareJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberFareJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberFare", ignore_extras);
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
    public static UberFareJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberFareJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberFareJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberFare", ignore_extras);
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
    public static UberFareJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberFareJSON from_text(string text, bool ignore_extras)
      {
        UberFareJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberFare", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberFareJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberFareJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberFareJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberFare", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorBasePrice;
        private JSONHoldingNumberTextGenerator fieldGeneratorMinimumPrice;
        private JSONHoldingNumberTextGenerator fieldGeneratorRatePerMinute;
        private JSONHoldingNumberTextGenerator fieldGeneratorRatePerDistance;
    private abstract class FieldGeneratorDistanceUnit : JSONStringGenerator
          {
            protected FieldGeneratorDistanceUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDistanceUnit()
              {
              }
            protected override void handle_result(string result)
              {
                TypeDistanceUnitKnownValues known = stringToDistanceUnit(result);
                TypeDistanceUnit new_value = new TypeDistanceUnit();
                if (known == TypeDistanceUnitKnownValues.DistanceUnit__none)
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
            protected abstract void handle_result(TypeDistanceUnit result);
          };
    private class FieldHoldingGeneratorDistanceUnit : FieldGeneratorDistanceUnit
  {
    protected override void handle_result(TypeDistanceUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDistanceUnit(String what)
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
    public TypeDistanceUnit value;
  };
    private class FieldHoldingArrayGeneratorDistanceUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDistanceUnit
      {
        private FieldHoldingArrayGeneratorDistanceUnit top;

        protected override void handle_result(TypeDistanceUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDistanceUnit init_top)
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
    protected virtual void handle_result(List<TypeDistanceUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorDistanceUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDistanceUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDistanceUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDistanceUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDistanceUnit> value;
  };
        private FieldHoldingGeneratorDistanceUnit fieldGeneratorDistanceUnit;
        private JSONHoldingNumberTextGenerator fieldGeneratorCancellationFee;
        private JSONHoldingStringGenerator fieldGeneratorCurrency;
        private TypeServiceFeesJSON.HoldingArrayGenerator fieldGeneratorServiceFees;
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
            UberFareJSON result = new UberFareJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberFareAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberFareJSON result)
          {
            if (fieldGeneratorBasePrice.have_value)
              {
                result.setBasePriceText(fieldGeneratorBasePrice.value);
                fieldGeneratorBasePrice.have_value = false;
              }
            else if ((!(result.hasBasePrice())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"BasePrice\" field was missing.");
              }
            if (fieldGeneratorMinimumPrice.have_value)
              {
                result.setMinimumPriceText(fieldGeneratorMinimumPrice.value);
                fieldGeneratorMinimumPrice.have_value = false;
              }
            else if ((!(result.hasMinimumPrice())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MinimumPrice\" field was missing.");
              }
            if (fieldGeneratorRatePerMinute.have_value)
              {
                result.setRatePerMinuteText(fieldGeneratorRatePerMinute.value);
                fieldGeneratorRatePerMinute.have_value = false;
              }
            if (fieldGeneratorRatePerDistance.have_value)
              {
                result.setRatePerDistanceText(fieldGeneratorRatePerDistance.value);
                fieldGeneratorRatePerDistance.have_value = false;
              }
            if (fieldGeneratorDistanceUnit.have_value)
              {
                result.setDistanceUnit(fieldGeneratorDistanceUnit.value);
                fieldGeneratorDistanceUnit.have_value = false;
              }
            else if ((!(result.hasDistanceUnit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DistanceUnit\" field was missing.");
              }
            if (fieldGeneratorCancellationFee.have_value)
              {
                result.setCancellationFeeText(fieldGeneratorCancellationFee.value);
                fieldGeneratorCancellationFee.have_value = false;
              }
            else if ((!(result.hasCancellationFee())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CancellationFee\" field was missing.");
              }
            if (fieldGeneratorCurrency.have_value)
              {
                result.setCurrency(fieldGeneratorCurrency.value);
                fieldGeneratorCurrency.have_value = false;
              }
            else if ((!(result.hasCurrency())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Currency\" field was missing.");
              }
            if (fieldGeneratorServiceFees.have_value)
              {
                result.initServiceFees();
                int count = fieldGeneratorServiceFees.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendServiceFees(fieldGeneratorServiceFees.value[num]);
                  }
                fieldGeneratorServiceFees.value.Clear();
                fieldGeneratorServiceFees.have_value = false;
              }
            else if ((!(result.hasServiceFees())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ServiceFees\" field was missing.");
              }
          }
        protected abstract void handle_result(UberFareJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "asePrice", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorBasePrice;
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ncellationFee", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorCancellationFee;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrency", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorCurrency;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "istanceUnit", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorDistanceUnit;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "inimumPrice", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorMinimumPrice;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "atePer", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 8, "istance", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorRatePerDistance;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 8, "inute", 0, 5, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorRatePerMinute;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "erviceFees", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorServiceFees;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorBasePrice = new JSONHoldingNumberTextGenerator("field \"BasePrice\" of the UberFare class");
            fieldGeneratorMinimumPrice = new JSONHoldingNumberTextGenerator("field \"MinimumPrice\" of the UberFare class");
            fieldGeneratorRatePerMinute = new JSONHoldingNumberTextGenerator("field \"RatePerMinute\" of the UberFare class");
            fieldGeneratorRatePerDistance = new JSONHoldingNumberTextGenerator("field \"RatePerDistance\" of the UberFare class");
            fieldGeneratorDistanceUnit = new FieldHoldingGeneratorDistanceUnit("field \"DistanceUnit\" of the UberFare class");
            fieldGeneratorCancellationFee = new JSONHoldingNumberTextGenerator("field \"CancellationFee\" of the UberFare class");
            fieldGeneratorCurrency = new JSONHoldingStringGenerator("field \"Currency\" of the UberFare class");
            fieldGeneratorServiceFees = new TypeServiceFeesJSON.HoldingArrayGenerator("field \"ServiceFees\" of the UberFare class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberFare class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorBasePrice = new JSONHoldingNumberTextGenerator("field \"BasePrice\" of the UberFare class");
            fieldGeneratorMinimumPrice = new JSONHoldingNumberTextGenerator("field \"MinimumPrice\" of the UberFare class");
            fieldGeneratorRatePerMinute = new JSONHoldingNumberTextGenerator("field \"RatePerMinute\" of the UberFare class");
            fieldGeneratorRatePerDistance = new JSONHoldingNumberTextGenerator("field \"RatePerDistance\" of the UberFare class");
            fieldGeneratorDistanceUnit = new FieldHoldingGeneratorDistanceUnit("field \"DistanceUnit\" of the UberFare class");
            fieldGeneratorCancellationFee = new JSONHoldingNumberTextGenerator("field \"CancellationFee\" of the UberFare class");
            fieldGeneratorCurrency = new JSONHoldingStringGenerator("field \"Currency\" of the UberFare class");
            fieldGeneratorServiceFees = new TypeServiceFeesJSON.HoldingArrayGenerator("field \"ServiceFees\" of the UberFare class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberFare class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorBasePrice.reset();
            fieldGeneratorMinimumPrice.reset();
            fieldGeneratorRatePerMinute.reset();
            fieldGeneratorRatePerDistance.reset();
            fieldGeneratorDistanceUnit.reset();
            fieldGeneratorCancellationFee.reset();
            fieldGeneratorCurrency.reset();
            fieldGeneratorServiceFees.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorServiceFees.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorServiceFees.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberFareJSON  result)
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
        public UberFareJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberFareJSON  result)
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
    protected virtual void handle_result(List<UberFareJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberFareJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberFareJSON>();
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
    public List<UberFareJSON> value;
  };
  };
