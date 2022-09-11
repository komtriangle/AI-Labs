/* file "UberProductDetailsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UberProductDetailsJSON : JSONBase
  {
    public struct Typeprice_details
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public UberPriceDetailsJSON  choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    private bool flagHasproduct_id;
    private string storeproduct_id;
    private bool flagHasdescription;
    private string storedescription;
    private bool flagHasdisplay_name;
    private string storedisplay_name;
    private bool flagHascapacity;
    private BigInteger storecapacity;
    private bool flagHasprice_details;
    private Typeprice_details storeprice_details;
    private bool flagHasimage;
    private string storeimage;
    private bool flagHasshared;
    private bool storeshared;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONproduct_id(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field product_id of UberProductDetailsJSON is not a string.");
        setproduct_id(json_string.getData());
      }


    private void  fromJSONdescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field description of UberProductDetailsJSON is not a string.");
        setdescription(json_string.getData());
      }


    private void  fromJSONdisplay_name(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field display_name of UberProductDetailsJSON is not a string.");
        setdisplay_name(json_string.getData());
      }


    private void  fromJSONcapacity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field capacity of UberProductDetailsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field capacity of UberProductDetailsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setcapacity(extracted_integer);
      }


    private void  fromJSONprice_details(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typeprice_details or_result = new Typeprice_details();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                UberPriceDetailsJSON convert_classy = UberPriceDetailsJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
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
            throw new Exception("The value for field price_details of UberProductDetailsJSON is not one of the allowed values.");
        setprice_details(or_result);
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


    private void  fromJSONimage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field image of UberProductDetailsJSON is not a string.");
        setimage(json_string.getData());
      }


    private void  fromJSONshared(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field shared of UberProductDetailsJSON is not true for false.");
              }
          }
        setshared(the_bool);
      }


    public UberProductDetailsJSON()
      {
        flagHasproduct_id = false;
        flagHasdescription = false;
        flagHasdisplay_name = false;
        flagHascapacity = false;
        flagHasprice_details = false;
        flagHasimage = false;
        flagHasshared = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasproduct_id()
      {
        return flagHasproduct_id;
      }

    public string  getproduct_id()
      {
        Debug.Assert(flagHasproduct_id);
        return storeproduct_id;
      }

    public bool  hasdescription()
      {
        return flagHasdescription;
      }

    public string  getdescription()
      {
        Debug.Assert(flagHasdescription);
        return storedescription;
      }

    public bool  hasdisplay_name()
      {
        return flagHasdisplay_name;
      }

    public string  getdisplay_name()
      {
        Debug.Assert(flagHasdisplay_name);
        return storedisplay_name;
      }

    public bool  hascapacity()
      {
        return flagHascapacity;
      }

    public BigInteger  getcapacity()
      {
        Debug.Assert(flagHascapacity);
        return storecapacity;
      }

    public bool  hasprice_details()
      {
        return flagHasprice_details;
      }

    public Typeprice_details  getprice_details()
      {
        Debug.Assert(flagHasprice_details);
        return storeprice_details;
      }

    public bool  hasimage()
      {
        return flagHasimage;
      }

    public string  getimage()
      {
        Debug.Assert(flagHasimage);
        return storeimage;
      }

    public bool  hasshared()
      {
        return flagHasshared;
      }

    public bool  getshared()
      {
        Debug.Assert(flagHasshared);
        return storeshared;
      }


    public virtual int extraUberProductDetailsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberProductDetailsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberProductDetailsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberProductDetailsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setproduct_id(string new_value)
      {
        flagHasproduct_id = true;
        storeproduct_id = new_value;
      }
    public void unsetproduct_id()
      {
        flagHasproduct_id = false;
      }
    public void setdescription(string new_value)
      {
        flagHasdescription = true;
        storedescription = new_value;
      }
    public void unsetdescription()
      {
        flagHasdescription = false;
      }
    public void setdisplay_name(string new_value)
      {
        flagHasdisplay_name = true;
        storedisplay_name = new_value;
      }
    public void unsetdisplay_name()
      {
        flagHasdisplay_name = false;
      }
    public void setcapacity(BigInteger new_value)
      {
        flagHascapacity = true;
        if (new_value < 0)
            throw new Exception("The value for field capacity of UberProductDetailsJSON is less than the lower bound (0) for that field.");
        storecapacity = new_value;
      }
    public void unsetcapacity()
      {
        flagHascapacity = false;
      }
    public void setprice_details(Typeprice_details new_value)
      {
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
        if (flagHasprice_details)
          {
            switch (storeprice_details.key)
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
        flagHasprice_details = true;
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
        storeprice_details = new_value;
      }
    public void unsetprice_details()
      {
        if (flagHasprice_details)
          {
            switch (storeprice_details.key)
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
        flagHasprice_details = false;
      }
    public void setimage(string new_value)
      {
        flagHasimage = true;
        storeimage = new_value;
      }
    public void unsetimage()
      {
        flagHasimage = false;
      }
    public void setshared(bool new_value)
      {
        flagHasshared = true;
        storeshared = new_value;
      }
    public void unsetshared()
      {
        flagHasshared = false;
      }

    public virtual void extraUberProductDetailsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberProductDetailsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberProductDetailsLookup(key);
        if (old_field == null)
          {
            extraUberProductDetailsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasproduct_id);
        if (flagHasproduct_id)
          {
            handler.start_pair("product_id");
            handler.string_value(storeproduct_id);
          }
        Debug.Assert(partial_allowed || flagHasdescription);
        if (flagHasdescription)
          {
            handler.start_pair("description");
            handler.string_value(storedescription);
          }
        Debug.Assert(partial_allowed || flagHasdisplay_name);
        if (flagHasdisplay_name)
          {
            handler.start_pair("display_name");
            handler.string_value(storedisplay_name);
          }
        Debug.Assert(partial_allowed || flagHascapacity);
        if (flagHascapacity)
          {
            handler.start_pair("capacity");
            handler.number_value(storecapacity);
          }
        Debug.Assert(partial_allowed || flagHasprice_details);
        if (flagHasprice_details)
          {
            handler.start_pair("price_details");
            switch (storeprice_details.key)
              {
                case 0:
                    if (partial_allowed)
                        storeprice_details.u.choice0.write_partial_as_json(handler);
                    else
                        storeprice_details.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasimage);
        if (flagHasimage)
          {
            handler.start_pair("image");
            handler.string_value(storeimage);
          }
        Debug.Assert(partial_allowed || flagHasshared);
        if (flagHasshared)
          {
            handler.start_pair("shared");
            handler.boolean_value(storeshared);
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
        if (!(hasproduct_id()))
          {
            return "When parsing the object for %what%, the \"product_id\" field was missing.";
          }
        if (!(hasdescription()))
          {
            return "When parsing the object for %what%, the \"description\" field was missing.";
          }
        if (!(hasdisplay_name()))
          {
            return "When parsing the object for %what%, the \"display_name\" field was missing.";
          }
        if (!(hascapacity()))
          {
            return "When parsing the object for %what%, the \"capacity\" field was missing.";
          }
        if (!(hasprice_details()))
          {
            return "When parsing the object for %what%, the \"price_details\" field was missing.";
          }
        if (!(hasimage()))
          {
            return "When parsing the object for %what%, the \"image\" field was missing.";
          }
        if (!(hasshared()))
          {
            return "When parsing the object for %what%, the \"shared\" field was missing.";
          }
        return null;
      }

    public static UberProductDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberProductDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductDetails", ignore_extras);
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
    public static UberProductDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberProductDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberProductDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductDetails", ignore_extras);
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
    public static UberProductDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberProductDetailsJSON from_text(string text, bool ignore_extras)
      {
        UberProductDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductDetails", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberProductDetailsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberProductDetailsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberProductDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberProductDetails", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorproduct_id;
        private JSONHoldingStringGenerator fieldGeneratordescription;
        private JSONHoldingStringGenerator fieldGeneratordisplay_name;
    private class FieldHoldingGeneratorcapacity : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorcapacity(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorcapacity : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorcapacity(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorcapacity fieldGeneratorcapacity;
    private abstract class FieldGeneratorprice_details : JSONParallelGenerator
          {
            private UberPriceDetailsJSON.HoldingGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typeprice_details result = new Typeprice_details();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
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
            protected abstract void handle_result(Typeprice_details result);
            public FieldGeneratorprice_details(bool ignore_extras)
              {
                    field0 = new UberPriceDetailsJSON.HoldingGenerator("option 0 of field \"price_details\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"price_details\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorprice_details(string what, bool ignore_extras)
              {
                    field0 = new UberPriceDetailsJSON.HoldingGenerator("option 0 of field \"price_details\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"price_details\"");
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
        private class Holderprice_details
          {
            private bool have_data;
            private Typeprice_details data;
            public Holderprice_details()  { have_data = false; }
            public Holderprice_details(Typeprice_details init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holderprice_details(Holderprice_details other)
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
            public Typeprice_details referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorprice_details : FieldGeneratorprice_details
          {
            protected override void handle_result(Typeprice_details result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holderprice_details(result);
              }

            public FieldHoldingGeneratorprice_details(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holderprice_details value;
          };
    private class FieldHoldingArrayGeneratorprice_details : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorprice_details
      {
        private FieldHoldingArrayGeneratorprice_details top;

        protected override void handle_result(Typeprice_details result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorprice_details init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typeprice_details> result)
      {
      }

    public FieldHoldingArrayGeneratorprice_details(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typeprice_details>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorprice_details(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typeprice_details>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typeprice_details> value;
  };
        private FieldHoldingGeneratorprice_details fieldGeneratorprice_details;
        private JSONHoldingStringGenerator fieldGeneratorimage;
        private JSONHoldingBooleanGenerator fieldGeneratorshared;
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
            UberProductDetailsJSON result = new UberProductDetailsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberProductDetailsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberProductDetailsJSON result)
          {
            if (fieldGeneratorproduct_id.have_value)
              {
                result.setproduct_id(fieldGeneratorproduct_id.value);
                fieldGeneratorproduct_id.have_value = false;
              }
            else if ((!(result.hasproduct_id())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"product_id\" field was missing.");
              }
            if (fieldGeneratordescription.have_value)
              {
                result.setdescription(fieldGeneratordescription.value);
                fieldGeneratordescription.have_value = false;
              }
            else if ((!(result.hasdescription())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"description\" field was missing.");
              }
            if (fieldGeneratordisplay_name.have_value)
              {
                result.setdisplay_name(fieldGeneratordisplay_name.value);
                fieldGeneratordisplay_name.have_value = false;
              }
            else if ((!(result.hasdisplay_name())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"display_name\" field was missing.");
              }
            if (fieldGeneratorcapacity.have_value)
              {
                result.setcapacity(fieldGeneratorcapacity.value);
                fieldGeneratorcapacity.have_value = false;
              }
            else if ((!(result.hascapacity())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"capacity\" field was missing.");
              }
            if (fieldGeneratorprice_details.have_value)
              {
                result.setprice_details(fieldGeneratorprice_details.value.referenced());
                fieldGeneratorprice_details.have_value = false;
              }
            else if ((!(result.hasprice_details())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"price_details\" field was missing.");
              }
            if (fieldGeneratorimage.have_value)
              {
                result.setimage(fieldGeneratorimage.value);
                fieldGeneratorimage.have_value = false;
              }
            else if ((!(result.hasimage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"image\" field was missing.");
              }
            if (fieldGeneratorshared.have_value)
              {
                result.setshared(fieldGeneratorshared.value);
                fieldGeneratorshared.have_value = false;
              }
            else if ((!(result.hasshared())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"shared\" field was missing.");
              }
          }
        protected abstract void handle_result(UberProductDetailsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'c':
                    if ((String.Compare(field_name, 1, "apacity", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorcapacity;
                    break;
                case 'd':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "scription", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratordescription;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "splay_name", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratordisplay_name;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "mage", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorimage;
                    break;
                case 'p':
                    if (String.Compare(field_name, 1, "r", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'i':
                                if ((String.Compare(field_name, 3, "ce_details", 0, 10, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorprice_details;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 3, "duct_id", 0, 7, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorproduct_id;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "hared", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorshared;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorproduct_id = new JSONHoldingStringGenerator("field \"product_id\" of the UberProductDetails class");
            fieldGeneratordescription = new JSONHoldingStringGenerator("field \"description\" of the UberProductDetails class");
            fieldGeneratordisplay_name = new JSONHoldingStringGenerator("field \"display_name\" of the UberProductDetails class");
            fieldGeneratorcapacity = new FieldHoldingGeneratorcapacity("field \"capacity\" of the UberProductDetails class");
            fieldGeneratorprice_details = new FieldHoldingGeneratorprice_details("field \"price_details\" of the UberProductDetails class", ignore_extras);
            fieldGeneratorimage = new JSONHoldingStringGenerator("field \"image\" of the UberProductDetails class");
            fieldGeneratorshared = new JSONHoldingBooleanGenerator("field \"shared\" of the UberProductDetails class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberProductDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorproduct_id = new JSONHoldingStringGenerator("field \"product_id\" of the UberProductDetails class");
            fieldGeneratordescription = new JSONHoldingStringGenerator("field \"description\" of the UberProductDetails class");
            fieldGeneratordisplay_name = new JSONHoldingStringGenerator("field \"display_name\" of the UberProductDetails class");
            fieldGeneratorcapacity = new FieldHoldingGeneratorcapacity("field \"capacity\" of the UberProductDetails class");
            fieldGeneratorprice_details = new FieldHoldingGeneratorprice_details("field \"price_details\" of the UberProductDetails class", false);
            fieldGeneratorimage = new JSONHoldingStringGenerator("field \"image\" of the UberProductDetails class");
            fieldGeneratorshared = new JSONHoldingBooleanGenerator("field \"shared\" of the UberProductDetails class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberProductDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorproduct_id.reset();
            fieldGeneratordescription.reset();
            fieldGeneratordisplay_name.reset();
            fieldGeneratorcapacity.reset();
            fieldGeneratorprice_details.reset();
            fieldGeneratorimage.reset();
            fieldGeneratorshared.reset();
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
        protected override void handle_result(UberProductDetailsJSON  result)
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
        public UberProductDetailsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberProductDetailsJSON  result)
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
    protected virtual void handle_result(List<UberProductDetailsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberProductDetailsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberProductDetailsJSON>();
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
    public List<UberProductDetailsJSON> value;
  };
  };
