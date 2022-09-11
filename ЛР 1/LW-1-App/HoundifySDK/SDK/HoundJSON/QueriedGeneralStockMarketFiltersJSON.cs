/* file "QueriedGeneralStockMarketFiltersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class QueriedGeneralStockMarketFiltersJSON : JSONBase
  {
    private bool flagHasDateRange;
    private DateTimeRangeSpecJSON  storeDateRange;
    private bool flagHasCountry;
    private QueriedStockCountryJSON  storeCountry;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDateRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateRange(convert_classy);
      }


    private void  fromJSONCountry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        QueriedStockCountryJSON convert_classy = QueriedStockCountryJSON.from_json(json_value, ignore_extras, true);
        setCountry(convert_classy);
      }


    public QueriedGeneralStockMarketFiltersJSON()
      {
        flagHasDateRange = false;
        flagHasCountry = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDateRange()
      {
        return flagHasDateRange;
      }

    public DateTimeRangeSpecJSON   getDateRange()
      {
        Debug.Assert(flagHasDateRange);
        return storeDateRange;
      }

    public bool  hasCountry()
      {
        return flagHasCountry;
      }

    public QueriedStockCountryJSON   getCountry()
      {
        Debug.Assert(flagHasCountry);
        return storeCountry;
      }


    public virtual int extraQueriedGeneralStockMarketFiltersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraQueriedGeneralStockMarketFiltersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraQueriedGeneralStockMarketFiltersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraQueriedGeneralStockMarketFiltersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDateRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDateRange)
          {
          }
        flagHasDateRange = true;
        storeDateRange = new_value;
      }
    public void unsetDateRange()
      {
        if (flagHasDateRange)
          {
          }
        flagHasDateRange = false;
      }
    public void setCountry(QueriedStockCountryJSON  new_value)
      {
        if (flagHasCountry)
          {
          }
        flagHasCountry = true;
        storeCountry = new_value;
      }
    public void unsetCountry()
      {
        if (flagHasCountry)
          {
          }
        flagHasCountry = false;
      }

    public virtual void extraQueriedGeneralStockMarketFiltersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraQueriedGeneralStockMarketFiltersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraQueriedGeneralStockMarketFiltersLookup(key);
        if (old_field == null)
          {
            extraQueriedGeneralStockMarketFiltersAppendPair(key, new_component);
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
        if (flagHasDateRange)
          {
            handler.start_pair("DateRange");
            if (partial_allowed)
                storeDateRange.write_partial_as_json(handler);
            else
                storeDateRange.write_as_json(handler);
          }
        if (flagHasCountry)
          {
            handler.start_pair("Country");
            if (partial_allowed)
                storeCountry.write_partial_as_json(handler);
            else
                storeCountry.write_as_json(handler);
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

    public static QueriedGeneralStockMarketFiltersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedGeneralStockMarketFiltersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedGeneralStockMarketFilters", ignore_extras);
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
    public static QueriedGeneralStockMarketFiltersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedGeneralStockMarketFiltersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedGeneralStockMarketFiltersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedGeneralStockMarketFilters", ignore_extras);
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
    public static QueriedGeneralStockMarketFiltersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedGeneralStockMarketFiltersJSON from_text(string text, bool ignore_extras)
      {
        QueriedGeneralStockMarketFiltersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedGeneralStockMarketFilters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for QueriedGeneralStockMarketFiltersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static QueriedGeneralStockMarketFiltersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        QueriedGeneralStockMarketFiltersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedGeneralStockMarketFilters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateRange;
        private QueriedStockCountryJSON.HoldingGenerator fieldGeneratorCountry;
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
            QueriedGeneralStockMarketFiltersJSON result = new QueriedGeneralStockMarketFiltersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraQueriedGeneralStockMarketFiltersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(QueriedGeneralStockMarketFiltersJSON result)
          {
            if (fieldGeneratorDateRange.have_value)
              {
                result.setDateRange(fieldGeneratorDateRange.value);
                fieldGeneratorDateRange.have_value = false;
              }
            if (fieldGeneratorCountry.have_value)
              {
                result.setCountry(fieldGeneratorCountry.value);
                fieldGeneratorCountry.have_value = false;
              }
          }
        protected abstract void handle_result(QueriedGeneralStockMarketFiltersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ountry", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorCountry;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ateRange", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDateRange;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the QueriedGeneralStockMarketFilters class", ignore_extras);
            fieldGeneratorCountry = new QueriedStockCountryJSON.HoldingGenerator("field \"Country\" of the QueriedGeneralStockMarketFilters class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the QueriedGeneralStockMarketFilters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the QueriedGeneralStockMarketFilters class", false);
            fieldGeneratorCountry = new QueriedStockCountryJSON.HoldingGenerator("field \"Country\" of the QueriedGeneralStockMarketFilters class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the QueriedGeneralStockMarketFilters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDateRange.reset();
            fieldGeneratorCountry.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDateRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCountry.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDateRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCountry.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(QueriedGeneralStockMarketFiltersJSON  result)
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
        public QueriedGeneralStockMarketFiltersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(QueriedGeneralStockMarketFiltersJSON  result)
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
    protected virtual void handle_result(List<QueriedGeneralStockMarketFiltersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<QueriedGeneralStockMarketFiltersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<QueriedGeneralStockMarketFiltersJSON>();
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
    public List<QueriedGeneralStockMarketFiltersJSON> value;
  };
  };
