/* file "QueriedStockQueryBlockJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class QueriedStockQueryBlockJSON : JSONBase
  {
    private bool flagHasRequestedAttributes;
    private List< QueriedStockAttributeJSON  > storeRequestedAttributes;
    private bool flagHasRequestedListings;
    private List< QueriedStockListingJSON  > storeRequestedListings;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRequestedAttributes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedAttributes of QueriedStockQueryBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< QueriedStockAttributeJSON  > vector_RequestedAttributes1 = new List< QueriedStockAttributeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            QueriedStockAttributeJSON convert_classy = QueriedStockAttributeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RequestedAttributes1.Add(convert_classy);
          }
        initRequestedAttributes();
        for (int num1 = 0; num1 < vector_RequestedAttributes1.Count; ++num1)
            appendRequestedAttributes(vector_RequestedAttributes1[num1]);
        for (int num1 = 0; num1 < vector_RequestedAttributes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedListings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedListings of QueriedStockQueryBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< QueriedStockListingJSON  > vector_RequestedListings1 = new List< QueriedStockListingJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            QueriedStockListingJSON convert_classy = QueriedStockListingJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RequestedListings1.Add(convert_classy);
          }
        initRequestedListings();
        for (int num2 = 0; num2 < vector_RequestedListings1.Count; ++num2)
            appendRequestedListings(vector_RequestedListings1[num2]);
        for (int num1 = 0; num1 < vector_RequestedListings1.Count; ++num1)
          {
          }
      }


    public QueriedStockQueryBlockJSON()
      {
        flagHasRequestedAttributes = false;
        flagHasRequestedListings = false;
        storeRequestedAttributes = new List< QueriedStockAttributeJSON  >();
        storeRequestedListings = new List< QueriedStockListingJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRequestedAttributes()
      {
        return flagHasRequestedAttributes;
      }

    public int  countOfRequestedAttributes()
      {
        Debug.Assert(flagHasRequestedAttributes);
        return storeRequestedAttributes.Count;
      }

    public QueriedStockAttributeJSON   elementOfRequestedAttributes(int element_num)
      {
        Debug.Assert(flagHasRequestedAttributes);
        return storeRequestedAttributes[element_num];
      }

    public List< QueriedStockAttributeJSON  >  getRequestedAttributes()
      {
        Debug.Assert(flagHasRequestedAttributes);
        return storeRequestedAttributes;
      }

    public bool  hasRequestedListings()
      {
        return flagHasRequestedListings;
      }

    public int  countOfRequestedListings()
      {
        Debug.Assert(flagHasRequestedListings);
        return storeRequestedListings.Count;
      }

    public QueriedStockListingJSON   elementOfRequestedListings(int element_num)
      {
        Debug.Assert(flagHasRequestedListings);
        return storeRequestedListings[element_num];
      }

    public List< QueriedStockListingJSON  >  getRequestedListings()
      {
        Debug.Assert(flagHasRequestedListings);
        return storeRequestedListings;
      }


    public virtual int extraQueriedStockQueryBlockComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraQueriedStockQueryBlockComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraQueriedStockQueryBlockComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraQueriedStockQueryBlockLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initRequestedAttributes()
      {
        if (flagHasRequestedAttributes)
          {
            for (int num1 = 0; num1 < storeRequestedAttributes.Count; ++num1)
              {
              }
          }
        flagHasRequestedAttributes = true;
        storeRequestedAttributes.Clear();
      }
    public void appendRequestedAttributes(QueriedStockAttributeJSON  to_append)
      {
        if (!flagHasRequestedAttributes)
          {
            flagHasRequestedAttributes = true;
            storeRequestedAttributes.Clear();
          }
        Debug.Assert(flagHasRequestedAttributes);
        storeRequestedAttributes.Add(to_append);
      }
    public void unsetRequestedAttributes()
      {
        if (flagHasRequestedAttributes)
          {
            for (int num2 = 0; num2 < storeRequestedAttributes.Count; ++num2)
              {
              }
          }
        flagHasRequestedAttributes = false;
        storeRequestedAttributes.Clear();
      }
    public void initRequestedListings()
      {
        if (flagHasRequestedListings)
          {
            for (int num3 = 0; num3 < storeRequestedListings.Count; ++num3)
              {
              }
          }
        flagHasRequestedListings = true;
        storeRequestedListings.Clear();
      }
    public void appendRequestedListings(QueriedStockListingJSON  to_append)
      {
        if (!flagHasRequestedListings)
          {
            flagHasRequestedListings = true;
            storeRequestedListings.Clear();
          }
        Debug.Assert(flagHasRequestedListings);
        storeRequestedListings.Add(to_append);
      }
    public void unsetRequestedListings()
      {
        if (flagHasRequestedListings)
          {
            for (int num4 = 0; num4 < storeRequestedListings.Count; ++num4)
              {
              }
          }
        flagHasRequestedListings = false;
        storeRequestedListings.Clear();
      }

    public virtual void extraQueriedStockQueryBlockAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraQueriedStockQueryBlockSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraQueriedStockQueryBlockLookup(key);
        if (old_field == null)
          {
            extraQueriedStockQueryBlockAppendPair(key, new_component);
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
        if (flagHasRequestedAttributes)
          {
            handler.start_pair("RequestedAttributes");
            handler.start_array();
            for (int num1 = 0; num1 < storeRequestedAttributes.Count; ++num1)
              {
                if (partial_allowed)
                    storeRequestedAttributes[num1].write_partial_as_json(handler);
                else
                    storeRequestedAttributes[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRequestedListings)
          {
            handler.start_pair("RequestedListings");
            handler.start_array();
            for (int num2 = 0; num2 < storeRequestedListings.Count; ++num2)
              {
                if (partial_allowed)
                    storeRequestedListings[num2].write_partial_as_json(handler);
                else
                    storeRequestedListings[num2].write_as_json(handler);
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
        return null;
      }

    public static QueriedStockQueryBlockJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedStockQueryBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockQueryBlock", ignore_extras);
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
    public static QueriedStockQueryBlockJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedStockQueryBlockJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        QueriedStockQueryBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockQueryBlock", ignore_extras);
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
    public static QueriedStockQueryBlockJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static QueriedStockQueryBlockJSON from_text(string text, bool ignore_extras)
      {
        QueriedStockQueryBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockQueryBlock", ignore_extras);
            JSONParse.parse_json_value(text, "Text for QueriedStockQueryBlockJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static QueriedStockQueryBlockJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        QueriedStockQueryBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type QueriedStockQueryBlock", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private QueriedStockAttributeJSON.HoldingArrayGenerator fieldGeneratorRequestedAttributes;
        private QueriedStockListingJSON.HoldingArrayGenerator fieldGeneratorRequestedListings;
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
            QueriedStockQueryBlockJSON result = new QueriedStockQueryBlockJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraQueriedStockQueryBlockAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(QueriedStockQueryBlockJSON result)
          {
            if (fieldGeneratorRequestedAttributes.have_value)
              {
                result.initRequestedAttributes();
                int count = fieldGeneratorRequestedAttributes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequestedAttributes(fieldGeneratorRequestedAttributes.value[num]);
                  }
                fieldGeneratorRequestedAttributes.value.Clear();
                fieldGeneratorRequestedAttributes.have_value = false;
              }
            if (fieldGeneratorRequestedListings.have_value)
              {
                result.initRequestedListings();
                int count = fieldGeneratorRequestedListings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequestedListings(fieldGeneratorRequestedListings.value[num]);
                  }
                fieldGeneratorRequestedListings.value.Clear();
                fieldGeneratorRequestedListings.have_value = false;
              }
          }
        protected abstract void handle_result(QueriedStockQueryBlockJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Requested", 0, 9, false) == 0)
              {
                switch (field_name[9])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 10, "ttributes", 0, 9, false) == 0) && (field_name.Length == 19))
                            return fieldGeneratorRequestedAttributes;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 10, "istings", 0, 7, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorRequestedListings;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRequestedAttributes = new QueriedStockAttributeJSON.HoldingArrayGenerator("field \"RequestedAttributes\" of the QueriedStockQueryBlock class", ignore_extras);
            fieldGeneratorRequestedListings = new QueriedStockListingJSON.HoldingArrayGenerator("field \"RequestedListings\" of the QueriedStockQueryBlock class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the QueriedStockQueryBlock class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRequestedAttributes = new QueriedStockAttributeJSON.HoldingArrayGenerator("field \"RequestedAttributes\" of the QueriedStockQueryBlock class", false);
            fieldGeneratorRequestedListings = new QueriedStockListingJSON.HoldingArrayGenerator("field \"RequestedListings\" of the QueriedStockQueryBlock class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the QueriedStockQueryBlock class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRequestedAttributes.reset();
            fieldGeneratorRequestedListings.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRequestedAttributes.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedListings.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRequestedAttributes.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedListings.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(QueriedStockQueryBlockJSON  result)
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
        public QueriedStockQueryBlockJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(QueriedStockQueryBlockJSON  result)
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
    protected virtual void handle_result(List<QueriedStockQueryBlockJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<QueriedStockQueryBlockJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<QueriedStockQueryBlockJSON>();
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
    public List<QueriedStockQueryBlockJSON> value;
  };
  };
