/* file "EstimateUberResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EstimateUberResponseJSON : JSONBase
  {
    public struct Typetrip
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public UberRequestEstimateTripJSON  choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct Typepickup_estimate
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
    private bool flagHasprice;
    private UberRequestEstimatePriceJSON  storeprice;
    private bool flagHastrip;
    private Typetrip storetrip;
    private bool flagHaspickup_estimate;
    private Typepickup_estimate storepickup_estimate;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONprice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberRequestEstimatePriceJSON convert_classy = UberRequestEstimatePriceJSON.from_json(json_value, ignore_extras, true);
        setprice(convert_classy);
      }


    private void  fromJSONtrip(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typetrip or_result = new Typetrip();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                UberRequestEstimateTripJSON convert_classy = UberRequestEstimateTripJSON.from_json(json_value, ignore_extras, true);
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
            throw new Exception("The value for field trip of EstimateUberResponseJSON is not one of the allowed values.");
        settrip(or_result);
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


    private void  fromJSONpickup_estimate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typepickup_estimate or_result = new Typepickup_estimate();
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
            throw new Exception("The value for field pickup_estimate of EstimateUberResponseJSON is not one of the allowed values.");
        setpickup_estimate(or_result);
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


    public EstimateUberResponseJSON()
      {
        flagHasprice = false;
        flagHastrip = false;
        flagHaspickup_estimate = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasprice()
      {
        return flagHasprice;
      }

    public UberRequestEstimatePriceJSON   getprice()
      {
        Debug.Assert(flagHasprice);
        return storeprice;
      }

    public bool  hastrip()
      {
        return flagHastrip;
      }

    public Typetrip  gettrip()
      {
        Debug.Assert(flagHastrip);
        return storetrip;
      }

    public bool  haspickup_estimate()
      {
        return flagHaspickup_estimate;
      }

    public Typepickup_estimate  getpickup_estimate()
      {
        Debug.Assert(flagHaspickup_estimate);
        return storepickup_estimate;
      }


    public virtual int extraEstimateUberResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraEstimateUberResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraEstimateUberResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraEstimateUberResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setprice(UberRequestEstimatePriceJSON  new_value)
      {
        if (flagHasprice)
          {
          }
        flagHasprice = true;
        storeprice = new_value;
      }
    public void unsetprice()
      {
        if (flagHasprice)
          {
          }
        flagHasprice = false;
      }
    public void settrip(Typetrip new_value)
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
        if (flagHastrip)
          {
            switch (storetrip.key)
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
        flagHastrip = true;
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
        storetrip = new_value;
      }
    public void unsettrip()
      {
        if (flagHastrip)
          {
            switch (storetrip.key)
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
        flagHastrip = false;
      }
    public void setpickup_estimate(Typepickup_estimate new_value)
      {
        flagHaspickup_estimate = true;
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
        storepickup_estimate = new_value;
      }
    public void unsetpickup_estimate()
      {
        flagHaspickup_estimate = false;
      }

    public virtual void extraEstimateUberResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraEstimateUberResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraEstimateUberResponseLookup(key);
        if (old_field == null)
          {
            extraEstimateUberResponseAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasprice);
        if (flagHasprice)
          {
            handler.start_pair("price");
            if (partial_allowed)
                storeprice.write_partial_as_json(handler);
            else
                storeprice.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHastrip);
        if (flagHastrip)
          {
            handler.start_pair("trip");
            switch (storetrip.key)
              {
                case 0:
                    if (partial_allowed)
                        storetrip.u.choice0.write_partial_as_json(handler);
                    else
                        storetrip.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHaspickup_estimate);
        if (flagHaspickup_estimate)
          {
            handler.start_pair("pickup_estimate");
            switch (storepickup_estimate.key)
              {
                case 0:
                    if (((double)(long)storepickup_estimate.u.choice0) == storepickup_estimate.u.choice0)
                        handler.number_value((long)storepickup_estimate.u.choice0);
                    else
                        handler.number_value(storepickup_estimate.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
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
        if (!(hasprice()))
          {
            return "When parsing the object for %what%, the \"price\" field was missing.";
          }
        if (!(hastrip()))
          {
            return "When parsing the object for %what%, the \"trip\" field was missing.";
          }
        if (!(haspickup_estimate()))
          {
            return "When parsing the object for %what%, the \"pickup_estimate\" field was missing.";
          }
        return null;
      }

    public static EstimateUberResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EstimateUberResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EstimateUberResponse", ignore_extras);
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
    public static EstimateUberResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EstimateUberResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EstimateUberResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EstimateUberResponse", ignore_extras);
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
    public static EstimateUberResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EstimateUberResponseJSON from_text(string text, bool ignore_extras)
      {
        EstimateUberResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EstimateUberResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EstimateUberResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static EstimateUberResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EstimateUberResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EstimateUberResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UberRequestEstimatePriceJSON.HoldingGenerator fieldGeneratorprice;
    private abstract class FieldGeneratortrip : JSONParallelGenerator
          {
            private UberRequestEstimateTripJSON.HoldingGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typetrip result = new Typetrip();
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
            protected abstract void handle_result(Typetrip result);
            public FieldGeneratortrip(bool ignore_extras)
              {
                    field0 = new UberRequestEstimateTripJSON.HoldingGenerator("option 0 of field \"trip\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"trip\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratortrip(string what, bool ignore_extras)
              {
                    field0 = new UberRequestEstimateTripJSON.HoldingGenerator("option 0 of field \"trip\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"trip\"");
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
        private class Holdertrip
          {
            private bool have_data;
            private Typetrip data;
            public Holdertrip()  { have_data = false; }
            public Holdertrip(Typetrip init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holdertrip(Holdertrip other)
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
            public Typetrip referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratortrip : FieldGeneratortrip
          {
            protected override void handle_result(Typetrip result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holdertrip(result);
              }

            public FieldHoldingGeneratortrip(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holdertrip value;
          };
    private class FieldHoldingArrayGeneratortrip : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratortrip
      {
        private FieldHoldingArrayGeneratortrip top;

        protected override void handle_result(Typetrip result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratortrip init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typetrip> result)
      {
      }

    public FieldHoldingArrayGeneratortrip(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typetrip>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratortrip(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typetrip>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typetrip> value;
  };
        private FieldHoldingGeneratortrip fieldGeneratortrip;
    private abstract class FieldGeneratorpickup_estimate : JSONParallelGenerator
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
                Typepickup_estimate result = new Typepickup_estimate();
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
            protected abstract void handle_result(Typepickup_estimate result);
            public FieldGeneratorpickup_estimate(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"pickup_estimate\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"pickup_estimate\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorpickup_estimate(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"pickup_estimate\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"pickup_estimate\"");
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
        private class Holderpickup_estimate
          {
            private bool have_data;
            private Typepickup_estimate data;
            public Holderpickup_estimate()  { have_data = false; }
            public Holderpickup_estimate(Typepickup_estimate init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holderpickup_estimate(Holderpickup_estimate other)
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
            public Typepickup_estimate referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorpickup_estimate : FieldGeneratorpickup_estimate
          {
            protected override void handle_result(Typepickup_estimate result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holderpickup_estimate(result);
              }

            public FieldHoldingGeneratorpickup_estimate(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holderpickup_estimate value;
          };
    private class FieldHoldingArrayGeneratorpickup_estimate : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorpickup_estimate
      {
        private FieldHoldingArrayGeneratorpickup_estimate top;

        protected override void handle_result(Typepickup_estimate result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorpickup_estimate init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typepickup_estimate> result)
      {
      }

    public FieldHoldingArrayGeneratorpickup_estimate(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typepickup_estimate>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorpickup_estimate(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typepickup_estimate>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typepickup_estimate> value;
  };
        private FieldHoldingGeneratorpickup_estimate fieldGeneratorpickup_estimate;
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
            EstimateUberResponseJSON result = new EstimateUberResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraEstimateUberResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(EstimateUberResponseJSON result)
          {
            if (fieldGeneratorprice.have_value)
              {
                result.setprice(fieldGeneratorprice.value);
                fieldGeneratorprice.have_value = false;
              }
            else if ((!(result.hasprice())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"price\" field was missing.");
              }
            if (fieldGeneratortrip.have_value)
              {
                result.settrip(fieldGeneratortrip.value.referenced());
                fieldGeneratortrip.have_value = false;
              }
            else if ((!(result.hastrip())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"trip\" field was missing.");
              }
            if (fieldGeneratorpickup_estimate.have_value)
              {
                result.setpickup_estimate(fieldGeneratorpickup_estimate.value.referenced());
                fieldGeneratorpickup_estimate.have_value = false;
              }
            else if ((!(result.haspickup_estimate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"pickup_estimate\" field was missing.");
              }
          }
        protected abstract void handle_result(EstimateUberResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'p':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "ckup_estimate", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorpickup_estimate;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "ice", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorprice;
                            break;
                        default:
                            break;
                      }
                    break;
                case 't':
                    if ((String.Compare(field_name, 1, "rip", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratortrip;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorprice = new UberRequestEstimatePriceJSON.HoldingGenerator("field \"price\" of the EstimateUberResponse class", ignore_extras);
            fieldGeneratortrip = new FieldHoldingGeneratortrip("field \"trip\" of the EstimateUberResponse class", ignore_extras);
            fieldGeneratorpickup_estimate = new FieldHoldingGeneratorpickup_estimate("field \"pickup_estimate\" of the EstimateUberResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the EstimateUberResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorprice = new UberRequestEstimatePriceJSON.HoldingGenerator("field \"price\" of the EstimateUberResponse class", false);
            fieldGeneratortrip = new FieldHoldingGeneratortrip("field \"trip\" of the EstimateUberResponse class", false);
            fieldGeneratorpickup_estimate = new FieldHoldingGeneratorpickup_estimate("field \"pickup_estimate\" of the EstimateUberResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the EstimateUberResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorprice.reset();
            fieldGeneratortrip.reset();
            fieldGeneratorpickup_estimate.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorprice.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorprice.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(EstimateUberResponseJSON  result)
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
        public EstimateUberResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EstimateUberResponseJSON  result)
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
    protected virtual void handle_result(List<EstimateUberResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EstimateUberResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EstimateUberResponseJSON>();
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
    public List<EstimateUberResponseJSON> value;
  };
  };
