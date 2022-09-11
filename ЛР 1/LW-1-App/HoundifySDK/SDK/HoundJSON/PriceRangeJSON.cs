/* file "PriceRangeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PriceRangeJSON : JSONBase
  {
    private bool flagHasFrom;
    private MonetaryAmountJSON  storeFrom;
    private bool flagHasIsFromInclusive;
    private bool storeIsFromInclusive;
    private bool flagHasTo;
    private MonetaryAmountJSON  storeTo;
    private bool flagHasIsToInclusive;
    private bool storeIsToInclusive;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFrom(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MonetaryAmountJSON convert_classy = MonetaryAmountJSON.from_json(json_value, ignore_extras, true);
        setFrom(convert_classy);
      }


    private void  fromJSONIsFromInclusive(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsFromInclusive of PriceRangeJSON is not true for false.");
              }
          }
        setIsFromInclusive(the_bool);
      }


    private void  fromJSONTo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MonetaryAmountJSON convert_classy = MonetaryAmountJSON.from_json(json_value, ignore_extras, true);
        setTo(convert_classy);
      }


    private void  fromJSONIsToInclusive(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsToInclusive of PriceRangeJSON is not true for false.");
              }
          }
        setIsToInclusive(the_bool);
      }


    public PriceRangeJSON()
      {
        flagHasFrom = false;
        flagHasIsFromInclusive = false;
        flagHasTo = false;
        flagHasIsToInclusive = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFrom()
      {
        return flagHasFrom;
      }

    public MonetaryAmountJSON   getFrom()
      {
        Debug.Assert(flagHasFrom);
        return storeFrom;
      }

    public bool  hasIsFromInclusive()
      {
        return flagHasIsFromInclusive;
      }

    public bool  getIsFromInclusive()
      {
        Debug.Assert(flagHasIsFromInclusive);
        return storeIsFromInclusive;
      }

    public bool  hasTo()
      {
        return flagHasTo;
      }

    public MonetaryAmountJSON   getTo()
      {
        Debug.Assert(flagHasTo);
        return storeTo;
      }

    public bool  hasIsToInclusive()
      {
        return flagHasIsToInclusive;
      }

    public bool  getIsToInclusive()
      {
        Debug.Assert(flagHasIsToInclusive);
        return storeIsToInclusive;
      }


    public virtual int extraPriceRangeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPriceRangeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPriceRangeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPriceRangeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFrom(MonetaryAmountJSON  new_value)
      {
        if (flagHasFrom)
          {
          }
        flagHasFrom = true;
        storeFrom = new_value;
      }
    public void unsetFrom()
      {
        if (flagHasFrom)
          {
          }
        flagHasFrom = false;
      }
    public void setIsFromInclusive(bool new_value)
      {
        flagHasIsFromInclusive = true;
        storeIsFromInclusive = new_value;
      }
    public void unsetIsFromInclusive()
      {
        flagHasIsFromInclusive = false;
      }
    public void setTo(MonetaryAmountJSON  new_value)
      {
        if (flagHasTo)
          {
          }
        flagHasTo = true;
        storeTo = new_value;
      }
    public void unsetTo()
      {
        if (flagHasTo)
          {
          }
        flagHasTo = false;
      }
    public void setIsToInclusive(bool new_value)
      {
        flagHasIsToInclusive = true;
        storeIsToInclusive = new_value;
      }
    public void unsetIsToInclusive()
      {
        flagHasIsToInclusive = false;
      }

    public virtual void extraPriceRangeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPriceRangeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPriceRangeLookup(key);
        if (old_field == null)
          {
            extraPriceRangeAppendPair(key, new_component);
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
        if (flagHasFrom)
          {
            handler.start_pair("From");
            if (partial_allowed)
                storeFrom.write_partial_as_json(handler);
            else
                storeFrom.write_as_json(handler);
          }
        if (flagHasIsFromInclusive)
          {
            handler.start_pair("IsFromInclusive");
            handler.boolean_value(storeIsFromInclusive);
          }
        if (flagHasTo)
          {
            handler.start_pair("To");
            if (partial_allowed)
                storeTo.write_partial_as_json(handler);
            else
                storeTo.write_as_json(handler);
          }
        if (flagHasIsToInclusive)
          {
            handler.start_pair("IsToInclusive");
            handler.boolean_value(storeIsToInclusive);
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

    public static PriceRangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PriceRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PriceRange", ignore_extras);
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
    public static PriceRangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PriceRangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PriceRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PriceRange", ignore_extras);
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
    public static PriceRangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PriceRangeJSON from_text(string text, bool ignore_extras)
      {
        PriceRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PriceRange", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PriceRangeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PriceRangeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PriceRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PriceRange", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MonetaryAmountJSON.HoldingGenerator fieldGeneratorFrom;
        private JSONHoldingBooleanGenerator fieldGeneratorIsFromInclusive;
        private MonetaryAmountJSON.HoldingGenerator fieldGeneratorTo;
        private JSONHoldingBooleanGenerator fieldGeneratorIsToInclusive;
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
            PriceRangeJSON result = new PriceRangeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPriceRangeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(PriceRangeJSON result)
          {
            if (fieldGeneratorFrom.have_value)
              {
                result.setFrom(fieldGeneratorFrom.value);
                fieldGeneratorFrom.have_value = false;
              }
            if (fieldGeneratorIsFromInclusive.have_value)
              {
                result.setIsFromInclusive(fieldGeneratorIsFromInclusive.value);
                fieldGeneratorIsFromInclusive.have_value = false;
              }
            if (fieldGeneratorTo.have_value)
              {
                result.setTo(fieldGeneratorTo.value);
                fieldGeneratorTo.have_value = false;
              }
            if (fieldGeneratorIsToInclusive.have_value)
              {
                result.setIsToInclusive(fieldGeneratorIsToInclusive.value);
                fieldGeneratorIsToInclusive.have_value = false;
              }
          }
        protected abstract void handle_result(PriceRangeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "rom", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorFrom;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 3, "romInclusive", 0, 12, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorIsFromInclusive;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 3, "oInclusive", 0, 10, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorIsToInclusive;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "o", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorTo;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFrom = new MonetaryAmountJSON.HoldingGenerator("field \"From\" of the PriceRange class", ignore_extras);
            fieldGeneratorIsFromInclusive = new JSONHoldingBooleanGenerator("field \"IsFromInclusive\" of the PriceRange class");
            fieldGeneratorTo = new MonetaryAmountJSON.HoldingGenerator("field \"To\" of the PriceRange class", ignore_extras);
            fieldGeneratorIsToInclusive = new JSONHoldingBooleanGenerator("field \"IsToInclusive\" of the PriceRange class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PriceRange class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFrom = new MonetaryAmountJSON.HoldingGenerator("field \"From\" of the PriceRange class", false);
            fieldGeneratorIsFromInclusive = new JSONHoldingBooleanGenerator("field \"IsFromInclusive\" of the PriceRange class");
            fieldGeneratorTo = new MonetaryAmountJSON.HoldingGenerator("field \"To\" of the PriceRange class", false);
            fieldGeneratorIsToInclusive = new JSONHoldingBooleanGenerator("field \"IsToInclusive\" of the PriceRange class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PriceRange class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFrom.reset();
            fieldGeneratorIsFromInclusive.reset();
            fieldGeneratorTo.reset();
            fieldGeneratorIsToInclusive.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFrom.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTo.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFrom.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTo.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(PriceRangeJSON  result)
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
        public PriceRangeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PriceRangeJSON  result)
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
    protected virtual void handle_result(List<PriceRangeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PriceRangeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PriceRangeJSON>();
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
    public List<PriceRangeJSON> value;
  };
  };
