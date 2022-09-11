/* file "FlightListSortCriterionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightListSortCriterionJSON : JSONBase
  {
    private bool flagHasSortByField;
    private FlightSortFieldJSON  storeSortByField;
    private bool flagHasSortOrder;
    private SortOrderJSON  storeSortOrder;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSortByField(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightSortFieldJSON convert_classy = FlightSortFieldJSON.from_json(json_value, ignore_extras, true);
        setSortByField(convert_classy);
      }


    private void  fromJSONSortOrder(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SortOrderJSON convert_classy = SortOrderJSON.from_json(json_value, ignore_extras, true);
        setSortOrder(convert_classy);
      }


    public FlightListSortCriterionJSON()
      {
        flagHasSortByField = false;
        flagHasSortOrder = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSortByField()
      {
        return flagHasSortByField;
      }

    public FlightSortFieldJSON   getSortByField()
      {
        Debug.Assert(flagHasSortByField);
        return storeSortByField;
      }

    public FlightSortFieldJSON.TypeValue  getSortByFieldValue()
      {
        return getSortByField().getValue();
      }

    public string  getSortByFieldAsString()
      {
        return getSortByField().getValueAsString();
      }

    public bool  hasSortOrder()
      {
        return flagHasSortOrder;
      }

    public SortOrderJSON   getSortOrder()
      {
        Debug.Assert(flagHasSortOrder);
        return storeSortOrder;
      }

    public SortOrderJSON.TypeValue  getSortOrderValue()
      {
        return getSortOrder().getValue();
      }

    public string  getSortOrderAsString()
      {
        return getSortOrder().getValueAsString();
      }


    public virtual int extraFlightListSortCriterionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightListSortCriterionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightListSortCriterionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightListSortCriterionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSortByField(FlightSortFieldJSON  new_value)
      {
        if (flagHasSortByField)
          {
          }
        flagHasSortByField = true;
        storeSortByField = new_value;
      }
    public void setSortByField(FlightSortFieldJSON.TypeValue new_value)
      {
        setSortByField(new FlightSortFieldJSON(new_value));
      }
    public void setSortByField(string chars)
      {
        FlightSortFieldJSON.TypeValueKnownValues known = FlightSortFieldJSON.stringToValue(chars);
        FlightSortFieldJSON.TypeValue new_value = new FlightSortFieldJSON.TypeValue();
        if (known == FlightSortFieldJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSortByField(new_value);
      }
    public void unsetSortByField()
      {
        if (flagHasSortByField)
          {
          }
        flagHasSortByField = false;
      }
    public void setSortOrder(SortOrderJSON  new_value)
      {
        if (flagHasSortOrder)
          {
          }
        flagHasSortOrder = true;
        storeSortOrder = new_value;
      }
    public void setSortOrder(SortOrderJSON.TypeValue new_value)
      {
        setSortOrder(new SortOrderJSON(new_value));
      }
    public void setSortOrder(string chars)
      {
        SortOrderJSON.TypeValueKnownValues known = SortOrderJSON.stringToValue(chars);
        SortOrderJSON.TypeValue new_value = new SortOrderJSON.TypeValue();
        if (known == SortOrderJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSortOrder(new_value);
      }
    public void unsetSortOrder()
      {
        if (flagHasSortOrder)
          {
          }
        flagHasSortOrder = false;
      }

    public virtual void extraFlightListSortCriterionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightListSortCriterionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightListSortCriterionLookup(key);
        if (old_field == null)
          {
            extraFlightListSortCriterionAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSortByField);
        if (flagHasSortByField)
          {
            handler.start_pair("SortByField");
            if (partial_allowed)
                storeSortByField.write_partial_as_json(handler);
            else
                storeSortByField.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasSortOrder);
        if (flagHasSortOrder)
          {
            handler.start_pair("SortOrder");
            if (partial_allowed)
                storeSortOrder.write_partial_as_json(handler);
            else
                storeSortOrder.write_as_json(handler);
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
        if (!(hasSortByField()))
          {
            return "When parsing the object for %what%, the \"SortByField\" field was missing.";
          }
        if (!(hasSortOrder()))
          {
            return "When parsing the object for %what%, the \"SortOrder\" field was missing.";
          }
        return null;
      }

    public static FlightListSortCriterionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightListSortCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightListSortCriterion", ignore_extras);
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
    public static FlightListSortCriterionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightListSortCriterionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightListSortCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightListSortCriterion", ignore_extras);
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
    public static FlightListSortCriterionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightListSortCriterionJSON from_text(string text, bool ignore_extras)
      {
        FlightListSortCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightListSortCriterion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightListSortCriterionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightListSortCriterionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightListSortCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightListSortCriterion", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private FlightSortFieldJSON.HoldingGenerator fieldGeneratorSortByField;
        private SortOrderJSON.HoldingGenerator fieldGeneratorSortOrder;
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
            FlightListSortCriterionJSON result = new FlightListSortCriterionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightListSortCriterionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightListSortCriterionJSON result)
          {
            if (fieldGeneratorSortByField.have_value)
              {
                result.setSortByField(fieldGeneratorSortByField.value);
                fieldGeneratorSortByField.have_value = false;
              }
            else if ((!(result.hasSortByField())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SortByField\" field was missing.");
              }
            if (fieldGeneratorSortOrder.have_value)
              {
                result.setSortOrder(fieldGeneratorSortOrder.value);
                fieldGeneratorSortOrder.have_value = false;
              }
            else if ((!(result.hasSortOrder())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SortOrder\" field was missing.");
              }
          }
        protected abstract void handle_result(FlightListSortCriterionJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Sort", 0, 4, false) == 0)
              {
                switch (field_name[4])
                  {
                    case 'B':
                        if ((String.Compare(field_name, 5, "yField", 0, 6, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorSortByField;
                        break;
                    case 'O':
                        if ((String.Compare(field_name, 5, "rder", 0, 4, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorSortOrder;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSortByField = new FlightSortFieldJSON.HoldingGenerator("field \"SortByField\" of the FlightListSortCriterion class", ignore_extras);
            fieldGeneratorSortOrder = new SortOrderJSON.HoldingGenerator("field \"SortOrder\" of the FlightListSortCriterion class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightListSortCriterion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSortByField = new FlightSortFieldJSON.HoldingGenerator("field \"SortByField\" of the FlightListSortCriterion class", false);
            fieldGeneratorSortOrder = new SortOrderJSON.HoldingGenerator("field \"SortOrder\" of the FlightListSortCriterion class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightListSortCriterion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSortByField.reset();
            fieldGeneratorSortOrder.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSortByField.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSortOrder.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSortByField.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSortOrder.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightListSortCriterionJSON  result)
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
        public FlightListSortCriterionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightListSortCriterionJSON  result)
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
    protected virtual void handle_result(List<FlightListSortCriterionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightListSortCriterionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightListSortCriterionJSON>();
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
    public List<FlightListSortCriterionJSON> value;
  };
  };
