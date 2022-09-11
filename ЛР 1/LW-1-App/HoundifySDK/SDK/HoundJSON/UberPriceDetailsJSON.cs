/* file "UberPriceDetailsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberPriceDetailsJSON : JSONBase
  {
    public struct Typeminimum
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public enum Typedistance_unit
      {
        distance_unit_mile,
        distance_unit_km
      };

    public static Typedistance_unit  stringTodistance_unit(string chars)
      {
        switch (chars[0])
          {
            case 'k':
                if ((String.Compare(chars, 1, "m", 0, 1, false) == 0) && (chars.Length == 2))
                    return Typedistance_unit.distance_unit_km;
                break;
            case 'm':
                if ((String.Compare(chars, 1, "ile", 0, 3, false) == 0) && (chars.Length == 4))
                    return Typedistance_unit.distance_unit_mile;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `distance_unit' is not one of the legal values.");
      }

    public static string  stringFromdistance_unit(Typedistance_unit the_enum)
      {
        switch (the_enum)
          {
            case Typedistance_unit.distance_unit_mile:
                return "mile";
            case Typedistance_unit.distance_unit_km:
                return "km";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class Typeservice_feesJSON : JSONBase
      {
        private bool flagHasname;
        private string storename;
        private bool flagHasfee;
        private double storefee;
        private string textStorefee;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONname(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field name of Typeservice_feesJSON is not a string.");
            setname(json_string.getData());
          }


        private void  fromJSONfee(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field fee of Typeservice_feesJSON is not a number.");
                  }
              }
            setfeeText(the_rational_text);
          }


        public Typeservice_feesJSON()
          {
            flagHasname = false;
            flagHasfee = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasname()
          {
            return flagHasname;
          }

        public string  getname()
          {
            Debug.Assert(flagHasname);
            return storename;
          }

        public bool  hasfee()
          {
            return flagHasfee;
          }

        public double  getfee()
          {
            Debug.Assert(flagHasfee);
            if (textStorefee != "")
              {
                return Double.Parse(textStorefee);
              }
            return storefee;
          }

        public string  getfeeAsText()
          {
            Debug.Assert(flagHasfee);
            if (textStorefee == "")
              {
                return Convert.ToString(storefee);
              }
            else
              {
                return (textStorefee);
              }
          }


        public virtual int extraTypeservice_feesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeservice_feesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeservice_feesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeservice_feesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setname(string new_value)
          {
            flagHasname = true;
            storename = new_value;
          }
        public void unsetname()
          {
            flagHasname = false;
          }
        public void setfee(double new_value)
          {
            flagHasfee = true;
            storefee = new_value;
            textStorefee = "";
          }
        public void setfeeText(string new_value)
          {
            flagHasfee = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field fee of Typeservice_feesJSON is not a valid number.");
            textStorefee = new_value;
          }
        public void unsetfee()
          {
            flagHasfee = false;
          }

        public virtual void extraTypeservice_feesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeservice_feesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeservice_feesLookup(key);
            if (old_field == null)
              {
                extraTypeservice_feesAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasname);
            if (flagHasname)
              {
                handler.start_pair("name");
                handler.string_value(storename);
              }
            Debug.Assert(partial_allowed || flagHasfee);
            if (flagHasfee)
              {
                handler.start_pair("fee");
                if (textStorefee != "")
                    handler.number_value(textStorefee);
                else if (((double)(long)storefee) == storefee)
                    handler.number_value((long)storefee);
                else
                    handler.number_value(storefee);
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
            if (!(hasname()))
              {
                return "When parsing the object for %what%, the \"name\" field was missing.";
              }
            if (!(hasfee()))
              {
                return "When parsing the object for %what%, the \"fee\" field was missing.";
              }
            return null;
          }

        public static Typeservice_feesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            Typeservice_feesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeservice_fees", ignore_extras);
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
        public static Typeservice_feesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static Typeservice_feesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            Typeservice_feesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeservice_fees", ignore_extras);
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
        public static Typeservice_feesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static Typeservice_feesJSON from_text(string text, bool ignore_extras)
          {
            Typeservice_feesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeservice_fees", ignore_extras);
                JSONParse.parse_json_value(text, "Text for Typeservice_feesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static Typeservice_feesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            Typeservice_feesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeservice_fees", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorname;
            private JSONHoldingNumberTextGenerator fieldGeneratorfee;
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
                Typeservice_feesJSON result = new Typeservice_feesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeservice_feesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(Typeservice_feesJSON result)
              {
                if (fieldGeneratorname.have_value)
                  {
                    result.setname(fieldGeneratorname.value);
                    fieldGeneratorname.have_value = false;
                  }
                else if ((!(result.hasname())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"name\" field was missing.");
                  }
                if (fieldGeneratorfee.have_value)
                  {
                    result.setfeeText(fieldGeneratorfee.value);
                    fieldGeneratorfee.have_value = false;
                  }
                else if ((!(result.hasfee())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"fee\" field was missing.");
                  }
              }
            protected abstract void handle_result(Typeservice_feesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'f':
                        if ((String.Compare(field_name, 1, "ee", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorfee;
                        break;
                    case 'n':
                        if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorname;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typeservice_fees class");
                fieldGeneratorfee = new JSONHoldingNumberTextGenerator("field \"fee\" of the Typeservice_fees class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the Typeservice_fees class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typeservice_fees class");
                fieldGeneratorfee = new JSONHoldingNumberTextGenerator("field \"fee\" of the Typeservice_fees class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the Typeservice_fees class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorname.reset();
                fieldGeneratorfee.reset();
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
            protected override void handle_result(Typeservice_feesJSON  result)
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
            public Typeservice_feesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(Typeservice_feesJSON  result)
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
        protected virtual void handle_result(List<Typeservice_feesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<Typeservice_feesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<Typeservice_feesJSON>();
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
        public List<Typeservice_feesJSON> value;
      };
      };
    private bool flagHasbase;
    private double storebase;
    private string textStorebase;
    private bool flagHasminimum;
    private Typeminimum storeminimum;
    private bool flagHascost_per_minute;
    private double storecost_per_minute;
    private string textStorecost_per_minute;
    private bool flagHascost_per_distance;
    private double storecost_per_distance;
    private string textStorecost_per_distance;
    private bool flagHasdistance_unit;
    private Typedistance_unit storedistance_unit;
    private bool flagHascancellation_fee;
    private double storecancellation_fee;
    private string textStorecancellation_fee;
    private bool flagHascurrency_code;
    private string storecurrency_code;
    private bool flagHasservice_fees;
    private List< Typeservice_feesJSON  > storeservice_fees;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONbase(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field base of UberPriceDetailsJSON is not a number.");
              }
          }
        setbaseText(the_rational_text);
      }


    private void  fromJSONminimum(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typeminimum or_result = new Typeminimum();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                or_result.u.choice0 = the_double;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field minimum of UberPriceDetailsJSON is not one of the allowed values.");
        setminimum(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONcost_per_minute(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field cost_per_minute of UberPriceDetailsJSON is not a number.");
              }
          }
        setcost_per_minuteText(the_rational_text);
      }


    private void  fromJSONcost_per_distance(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field cost_per_distance of UberPriceDetailsJSON is not a number.");
              }
          }
        setcost_per_distanceText(the_rational_text);
      }


    private void  fromJSONdistance_unit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field distance_unit of UberPriceDetailsJSON is not a string.");
        Typedistance_unit the_enum;
        switch (json_string.getData()[0])
          {
            case 'k':
                if ((String.Compare(json_string.getData(), 1, "m", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = Typedistance_unit.distance_unit_km;
                        goto enum_is_done;
                      }
                break;
            case 'm':
                if ((String.Compare(json_string.getData(), 1, "ile", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = Typedistance_unit.distance_unit_mile;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field distance_unit of UberPriceDetailsJSON is not one of the legal strings.");
      enum_is_done:;
        setdistance_unit(the_enum);
      }


    private void  fromJSONcancellation_fee(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field cancellation_fee of UberPriceDetailsJSON is not a number.");
              }
          }
        setcancellation_feeText(the_rational_text);
      }


    private void  fromJSONcurrency_code(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field currency_code of UberPriceDetailsJSON is not a string.");
        setcurrency_code(json_string.getData());
      }


    private void  fromJSONservice_fees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field service_fees of UberPriceDetailsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Typeservice_feesJSON  > vector_service_fees1 = new List< Typeservice_feesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            Typeservice_feesJSON convert_classy = Typeservice_feesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_service_fees1.Add(convert_classy);
          }
        initservice_fees();
        for (int num1 = 0; num1 < vector_service_fees1.Count; ++num1)
            appendservice_fees(vector_service_fees1[num1]);
        for (int num1 = 0; num1 < vector_service_fees1.Count; ++num1)
          {
          }
      }


    public UberPriceDetailsJSON()
      {
        flagHasbase = false;
        flagHasminimum = false;
        flagHascost_per_minute = false;
        flagHascost_per_distance = false;
        flagHasdistance_unit = false;
        flagHascancellation_fee = false;
        flagHascurrency_code = false;
        flagHasservice_fees = false;
        storeservice_fees = new List< Typeservice_feesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasbase()
      {
        return flagHasbase;
      }

    public double  getbase()
      {
        Debug.Assert(flagHasbase);
        if (textStorebase != "")
          {
            return Double.Parse(textStorebase);
          }
        return storebase;
      }

    public string  getbaseAsText()
      {
        Debug.Assert(flagHasbase);
        if (textStorebase == "")
          {
            return Convert.ToString(storebase);
          }
        else
          {
            return (textStorebase);
          }
      }

    public bool  hasminimum()
      {
        return flagHasminimum;
      }

    public Typeminimum  getminimum()
      {
        Debug.Assert(flagHasminimum);
        return storeminimum;
      }

    public bool  hascost_per_minute()
      {
        return flagHascost_per_minute;
      }

    public double  getcost_per_minute()
      {
        Debug.Assert(flagHascost_per_minute);
        if (textStorecost_per_minute != "")
          {
            return Double.Parse(textStorecost_per_minute);
          }
        return storecost_per_minute;
      }

    public string  getcost_per_minuteAsText()
      {
        Debug.Assert(flagHascost_per_minute);
        if (textStorecost_per_minute == "")
          {
            return Convert.ToString(storecost_per_minute);
          }
        else
          {
            return (textStorecost_per_minute);
          }
      }

    public bool  hascost_per_distance()
      {
        return flagHascost_per_distance;
      }

    public double  getcost_per_distance()
      {
        Debug.Assert(flagHascost_per_distance);
        if (textStorecost_per_distance != "")
          {
            return Double.Parse(textStorecost_per_distance);
          }
        return storecost_per_distance;
      }

    public string  getcost_per_distanceAsText()
      {
        Debug.Assert(flagHascost_per_distance);
        if (textStorecost_per_distance == "")
          {
            return Convert.ToString(storecost_per_distance);
          }
        else
          {
            return (textStorecost_per_distance);
          }
      }

    public bool  hasdistance_unit()
      {
        return flagHasdistance_unit;
      }

    public Typedistance_unit  getdistance_unit()
      {
        Debug.Assert(flagHasdistance_unit);
        return storedistance_unit;
      }

    public string  getdistance_unitAsString()
      {
        return stringFromdistance_unit(getdistance_unit());
      }

    public bool  hascancellation_fee()
      {
        return flagHascancellation_fee;
      }

    public double  getcancellation_fee()
      {
        Debug.Assert(flagHascancellation_fee);
        if (textStorecancellation_fee != "")
          {
            return Double.Parse(textStorecancellation_fee);
          }
        return storecancellation_fee;
      }

    public string  getcancellation_feeAsText()
      {
        Debug.Assert(flagHascancellation_fee);
        if (textStorecancellation_fee == "")
          {
            return Convert.ToString(storecancellation_fee);
          }
        else
          {
            return (textStorecancellation_fee);
          }
      }

    public bool  hascurrency_code()
      {
        return flagHascurrency_code;
      }

    public string  getcurrency_code()
      {
        Debug.Assert(flagHascurrency_code);
        return storecurrency_code;
      }

    public bool  hasservice_fees()
      {
        return flagHasservice_fees;
      }

    public int  countOfservice_fees()
      {
        Debug.Assert(flagHasservice_fees);
        return storeservice_fees.Count;
      }

    public Typeservice_feesJSON   elementOfservice_fees(int element_num)
      {
        Debug.Assert(flagHasservice_fees);
        return storeservice_fees[element_num];
      }

    public List< Typeservice_feesJSON  >  getservice_fees()
      {
        Debug.Assert(flagHasservice_fees);
        return storeservice_fees;
      }


    public virtual int extraUberPriceDetailsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberPriceDetailsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberPriceDetailsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberPriceDetailsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setbase(double new_value)
      {
        flagHasbase = true;
        storebase = new_value;
        textStorebase = "";
      }
    public void setbaseText(string new_value)
      {
        flagHasbase = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field base of UberPriceDetailsJSON is not a valid number.");
        textStorebase = new_value;
      }
    public void unsetbase()
      {
        flagHasbase = false;
      }
    public void setminimum(Typeminimum new_value)
      {
        flagHasminimum = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeminimum = new_value;
      }
    public void unsetminimum()
      {
        flagHasminimum = false;
      }
    public void setcost_per_minute(double new_value)
      {
        flagHascost_per_minute = true;
        storecost_per_minute = new_value;
        textStorecost_per_minute = "";
      }
    public void setcost_per_minuteText(string new_value)
      {
        flagHascost_per_minute = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field cost_per_minute of UberPriceDetailsJSON is not a valid number.");
        textStorecost_per_minute = new_value;
      }
    public void unsetcost_per_minute()
      {
        flagHascost_per_minute = false;
      }
    public void setcost_per_distance(double new_value)
      {
        flagHascost_per_distance = true;
        storecost_per_distance = new_value;
        textStorecost_per_distance = "";
      }
    public void setcost_per_distanceText(string new_value)
      {
        flagHascost_per_distance = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field cost_per_distance of UberPriceDetailsJSON is not a valid number.");
        textStorecost_per_distance = new_value;
      }
    public void unsetcost_per_distance()
      {
        flagHascost_per_distance = false;
      }
    public void setdistance_unit(Typedistance_unit new_value)
      {
        flagHasdistance_unit = true;
        storedistance_unit = new_value;
      }
    public void setdistance_unit(string chars)
      {
        setdistance_unit(stringTodistance_unit(chars));
      }
    public void unsetdistance_unit()
      {
        flagHasdistance_unit = false;
      }
    public void setcancellation_fee(double new_value)
      {
        flagHascancellation_fee = true;
        storecancellation_fee = new_value;
        textStorecancellation_fee = "";
      }
    public void setcancellation_feeText(string new_value)
      {
        flagHascancellation_fee = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field cancellation_fee of UberPriceDetailsJSON is not a valid number.");
        textStorecancellation_fee = new_value;
      }
    public void unsetcancellation_fee()
      {
        flagHascancellation_fee = false;
      }
    public void setcurrency_code(string new_value)
      {
        flagHascurrency_code = true;
        storecurrency_code = new_value;
      }
    public void unsetcurrency_code()
      {
        flagHascurrency_code = false;
      }
    public void initservice_fees()
      {
        if (flagHasservice_fees)
          {
            for (int num1 = 0; num1 < storeservice_fees.Count; ++num1)
              {
              }
          }
        flagHasservice_fees = true;
        storeservice_fees.Clear();
      }
    public void appendservice_fees(Typeservice_feesJSON  to_append)
      {
        if (!flagHasservice_fees)
          {
            flagHasservice_fees = true;
            storeservice_fees.Clear();
          }
        Debug.Assert(flagHasservice_fees);
        storeservice_fees.Add(to_append);
      }
    public void unsetservice_fees()
      {
        if (flagHasservice_fees)
          {
            for (int num2 = 0; num2 < storeservice_fees.Count; ++num2)
              {
              }
          }
        flagHasservice_fees = false;
        storeservice_fees.Clear();
      }

    public virtual void extraUberPriceDetailsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberPriceDetailsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberPriceDetailsLookup(key);
        if (old_field == null)
          {
            extraUberPriceDetailsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasbase);
        if (flagHasbase)
          {
            handler.start_pair("base");
            if (textStorebase != "")
                handler.number_value(textStorebase);
            else if (((double)(long)storebase) == storebase)
                handler.number_value((long)storebase);
            else
                handler.number_value(storebase);
          }
        Debug.Assert(partial_allowed || flagHasminimum);
        if (flagHasminimum)
          {
            handler.start_pair("minimum");
            switch (storeminimum.key)
              {
                case 0:
                    if (((double)(long)storeminimum.u.choice0) == storeminimum.u.choice0)
                        handler.number_value((long)storeminimum.u.choice0);
                    else
                        handler.number_value(storeminimum.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHascost_per_minute)
          {
            handler.start_pair("cost_per_minute");
            if (((double)(long)storecost_per_minute) == storecost_per_minute)
                handler.number_value((long)storecost_per_minute);
            else
                handler.number_value(storecost_per_minute);
          }
        if (flagHascost_per_distance)
          {
            handler.start_pair("cost_per_distance");
            if (((double)(long)storecost_per_distance) == storecost_per_distance)
                handler.number_value((long)storecost_per_distance);
            else
                handler.number_value(storecost_per_distance);
          }
        Debug.Assert(partial_allowed || flagHasdistance_unit);
        if (flagHasdistance_unit)
          {
            handler.start_pair("distance_unit");
            switch (storedistance_unit)
              {
                case Typedistance_unit.distance_unit_mile:
                    handler.string_value("mile");
                    break;
                case Typedistance_unit.distance_unit_km:
                    handler.string_value("km");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHascancellation_fee);
        if (flagHascancellation_fee)
          {
            handler.start_pair("cancellation_fee");
            if (((double)(long)storecancellation_fee) == storecancellation_fee)
                handler.number_value((long)storecancellation_fee);
            else
                handler.number_value(storecancellation_fee);
          }
        Debug.Assert(partial_allowed || flagHascurrency_code);
        if (flagHascurrency_code)
          {
            handler.start_pair("currency_code");
            handler.string_value(storecurrency_code);
          }
        Debug.Assert(partial_allowed || flagHasservice_fees);
        if (flagHasservice_fees)
          {
            handler.start_pair("service_fees");
            handler.start_array();
            for (int num1 = 0; num1 < storeservice_fees.Count; ++num1)
              {
                if (partial_allowed)
                    storeservice_fees[num1].write_partial_as_json(handler);
                else
                    storeservice_fees[num1].write_as_json(handler);
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
        if (!(hasbase()))
          {
            return "When parsing the object for %what%, the \"base\" field was missing.";
          }
        if (!(hasminimum()))
          {
            return "When parsing the object for %what%, the \"minimum\" field was missing.";
          }
        if (!(hasdistance_unit()))
          {
            return "When parsing the object for %what%, the \"distance_unit\" field was missing.";
          }
        if (!(hascancellation_fee()))
          {
            return "When parsing the object for %what%, the \"cancellation_fee\" field was missing.";
          }
        if (!(hascurrency_code()))
          {
            return "When parsing the object for %what%, the \"currency_code\" field was missing.";
          }
        if (!(hasservice_fees()))
          {
            return "When parsing the object for %what%, the \"service_fees\" field was missing.";
          }
        return null;
      }

    public static UberPriceDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberPriceDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberPriceDetails", ignore_extras);
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
    public static UberPriceDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberPriceDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberPriceDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberPriceDetails", ignore_extras);
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
    public static UberPriceDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberPriceDetailsJSON from_text(string text, bool ignore_extras)
      {
        UberPriceDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberPriceDetails", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberPriceDetailsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberPriceDetailsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberPriceDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberPriceDetails", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorbase;
    private abstract class FieldGeneratorminimum : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typeminimum result = new Typeminimum();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = Double.Parse(field0.value);
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(Typeminimum result);
            public FieldGeneratorminimum(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"minimum\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"minimum\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorminimum(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"minimum\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"minimum\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class Holderminimum
          {
            private bool have_data;
            private Typeminimum data;
            public Holderminimum()  { have_data = false; }
            public Holderminimum(Typeminimum init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holderminimum(Holderminimum other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public Typeminimum referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorminimum : FieldGeneratorminimum
          {
            protected override void handle_result(Typeminimum result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holderminimum(result);
              }

            public FieldHoldingGeneratorminimum(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holderminimum value;
          };
    private class FieldHoldingArrayGeneratorminimum : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorminimum
      {
        private FieldHoldingArrayGeneratorminimum top;

        protected override void handle_result(Typeminimum result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorminimum init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typeminimum> result)
      {
      }

    public FieldHoldingArrayGeneratorminimum(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typeminimum>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorminimum(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typeminimum>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typeminimum> value;
  };
        private FieldHoldingGeneratorminimum fieldGeneratorminimum;
        private JSONHoldingNumberTextGenerator fieldGeneratorcost_per_minute;
        private JSONHoldingNumberTextGenerator fieldGeneratorcost_per_distance;
    private abstract class FieldGeneratordistance_unit : JSONStringGenerator
          {
            protected FieldGeneratordistance_unit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratordistance_unit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringTodistance_unit(result));
              }
            protected abstract void handle_result(Typedistance_unit result);
          };
    private class FieldHoldingGeneratordistance_unit : FieldGeneratordistance_unit
  {
    protected override void handle_result(Typedistance_unit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratordistance_unit(String what)
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
    public Typedistance_unit value;
  };
    private class FieldHoldingArrayGeneratordistance_unit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratordistance_unit
      {
        private FieldHoldingArrayGeneratordistance_unit top;

        protected override void handle_result(Typedistance_unit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratordistance_unit init_top)
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
    protected virtual void handle_result(List<Typedistance_unit> result)
      {
      }

    public FieldHoldingArrayGeneratordistance_unit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<Typedistance_unit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratordistance_unit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<Typedistance_unit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typedistance_unit> value;
  };
        private FieldHoldingGeneratordistance_unit fieldGeneratordistance_unit;
        private JSONHoldingNumberTextGenerator fieldGeneratorcancellation_fee;
        private JSONHoldingStringGenerator fieldGeneratorcurrency_code;
        private Typeservice_feesJSON.HoldingArrayGenerator fieldGeneratorservice_fees;
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
            UberPriceDetailsJSON result = new UberPriceDetailsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberPriceDetailsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberPriceDetailsJSON result)
          {
            if (fieldGeneratorbase.have_value)
              {
                result.setbaseText(fieldGeneratorbase.value);
                fieldGeneratorbase.have_value = false;
              }
            else if ((!(result.hasbase())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"base\" field was missing.");
              }
            if (fieldGeneratorminimum.have_value)
              {
                result.setminimum(fieldGeneratorminimum.value.referenced());
                fieldGeneratorminimum.have_value = false;
              }
            else if ((!(result.hasminimum())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"minimum\" field was missing.");
              }
            if (fieldGeneratorcost_per_minute.have_value)
              {
                result.setcost_per_minuteText(fieldGeneratorcost_per_minute.value);
                fieldGeneratorcost_per_minute.have_value = false;
              }
            if (fieldGeneratorcost_per_distance.have_value)
              {
                result.setcost_per_distanceText(fieldGeneratorcost_per_distance.value);
                fieldGeneratorcost_per_distance.have_value = false;
              }
            if (fieldGeneratordistance_unit.have_value)
              {
                result.setdistance_unit(fieldGeneratordistance_unit.value);
                fieldGeneratordistance_unit.have_value = false;
              }
            else if ((!(result.hasdistance_unit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"distance_unit\" field was missing.");
              }
            if (fieldGeneratorcancellation_fee.have_value)
              {
                result.setcancellation_feeText(fieldGeneratorcancellation_fee.value);
                fieldGeneratorcancellation_fee.have_value = false;
              }
            else if ((!(result.hascancellation_fee())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"cancellation_fee\" field was missing.");
              }
            if (fieldGeneratorcurrency_code.have_value)
              {
                result.setcurrency_code(fieldGeneratorcurrency_code.value);
                fieldGeneratorcurrency_code.have_value = false;
              }
            else if ((!(result.hascurrency_code())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"currency_code\" field was missing.");
              }
            if (fieldGeneratorservice_fees.have_value)
              {
                result.initservice_fees();
                int count = fieldGeneratorservice_fees.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendservice_fees(fieldGeneratorservice_fees.value[num]);
                  }
                fieldGeneratorservice_fees.value.Clear();
                fieldGeneratorservice_fees.have_value = false;
              }
            else if ((!(result.hasservice_fees())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"service_fees\" field was missing.");
              }
          }
        protected abstract void handle_result(UberPriceDetailsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'b':
                    if ((String.Compare(field_name, 1, "ase", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorbase;
                    break;
                case 'c':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ncellation_fee", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorcancellation_fee;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "st_per_", 0, 7, false) == 0)
                              {
                                switch (field_name[9])
                                  {
                                    case 'd':
                                        if ((String.Compare(field_name, 10, "istance", 0, 7, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorcost_per_distance;
                                        break;
                                    case 'm':
                                        if ((String.Compare(field_name, 10, "inute", 0, 5, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorcost_per_minute;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrency_code", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorcurrency_code;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'd':
                    if ((String.Compare(field_name, 1, "istance_unit", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratordistance_unit;
                    break;
                case 'm':
                    if ((String.Compare(field_name, 1, "inimum", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorminimum;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "ervice_fees", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorservice_fees;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorbase = new JSONHoldingNumberTextGenerator("field \"base\" of the UberPriceDetails class");
            fieldGeneratorminimum = new FieldHoldingGeneratorminimum("field \"minimum\" of the UberPriceDetails class", ignore_extras);
            fieldGeneratorcost_per_minute = new JSONHoldingNumberTextGenerator("field \"cost_per_minute\" of the UberPriceDetails class");
            fieldGeneratorcost_per_distance = new JSONHoldingNumberTextGenerator("field \"cost_per_distance\" of the UberPriceDetails class");
            fieldGeneratordistance_unit = new FieldHoldingGeneratordistance_unit("field \"distance_unit\" of the UberPriceDetails class");
            fieldGeneratorcancellation_fee = new JSONHoldingNumberTextGenerator("field \"cancellation_fee\" of the UberPriceDetails class");
            fieldGeneratorcurrency_code = new JSONHoldingStringGenerator("field \"currency_code\" of the UberPriceDetails class");
            fieldGeneratorservice_fees = new Typeservice_feesJSON.HoldingArrayGenerator("field \"service_fees\" of the UberPriceDetails class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberPriceDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorbase = new JSONHoldingNumberTextGenerator("field \"base\" of the UberPriceDetails class");
            fieldGeneratorminimum = new FieldHoldingGeneratorminimum("field \"minimum\" of the UberPriceDetails class", false);
            fieldGeneratorcost_per_minute = new JSONHoldingNumberTextGenerator("field \"cost_per_minute\" of the UberPriceDetails class");
            fieldGeneratorcost_per_distance = new JSONHoldingNumberTextGenerator("field \"cost_per_distance\" of the UberPriceDetails class");
            fieldGeneratordistance_unit = new FieldHoldingGeneratordistance_unit("field \"distance_unit\" of the UberPriceDetails class");
            fieldGeneratorcancellation_fee = new JSONHoldingNumberTextGenerator("field \"cancellation_fee\" of the UberPriceDetails class");
            fieldGeneratorcurrency_code = new JSONHoldingStringGenerator("field \"currency_code\" of the UberPriceDetails class");
            fieldGeneratorservice_fees = new Typeservice_feesJSON.HoldingArrayGenerator("field \"service_fees\" of the UberPriceDetails class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberPriceDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorbase.reset();
            fieldGeneratorminimum.reset();
            fieldGeneratorcost_per_minute.reset();
            fieldGeneratorcost_per_distance.reset();
            fieldGeneratordistance_unit.reset();
            fieldGeneratorcancellation_fee.reset();
            fieldGeneratorcurrency_code.reset();
            fieldGeneratorservice_fees.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorservice_fees.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorservice_fees.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberPriceDetailsJSON  result)
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
        public UberPriceDetailsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberPriceDetailsJSON  result)
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
    protected virtual void handle_result(List<UberPriceDetailsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberPriceDetailsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberPriceDetailsJSON>();
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
    public List<UberPriceDetailsJSON> value;
  };
  };
