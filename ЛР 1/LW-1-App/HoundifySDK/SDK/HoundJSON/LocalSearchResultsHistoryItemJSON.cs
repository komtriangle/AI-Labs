/* file "LocalSearchResultsHistoryItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class LocalSearchResultsHistoryItemJSON : JSONBase
  {
    private bool flagHasTimestamp;
    private BigInteger storeTimestamp;
    private bool flagHasYelpID;
    private string storeYelpID;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTimestamp(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Timestamp of LocalSearchResultsHistoryItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Timestamp of LocalSearchResultsHistoryItemJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTimestamp(extracted_integer);
      }


    private void  fromJSONYelpID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field YelpID of LocalSearchResultsHistoryItemJSON is not a string.");
        setYelpID(json_string.getData());
      }


    public LocalSearchResultsHistoryItemJSON()
      {
        flagHasTimestamp = false;
        flagHasYelpID = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTimestamp()
      {
        return flagHasTimestamp;
      }

    public BigInteger  getTimestamp()
      {
        Debug.Assert(flagHasTimestamp);
        return storeTimestamp;
      }

    public bool  hasYelpID()
      {
        return flagHasYelpID;
      }

    public string  getYelpID()
      {
        Debug.Assert(flagHasYelpID);
        return storeYelpID;
      }


    public virtual int extraLocalSearchResultsHistoryItemComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLocalSearchResultsHistoryItemComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLocalSearchResultsHistoryItemComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLocalSearchResultsHistoryItemLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTimestamp(BigInteger new_value)
      {
        flagHasTimestamp = true;
        storeTimestamp = new_value;
      }
    public void unsetTimestamp()
      {
        flagHasTimestamp = false;
      }
    public void setYelpID(string new_value)
      {
        flagHasYelpID = true;
        storeYelpID = new_value;
      }
    public void unsetYelpID()
      {
        flagHasYelpID = false;
      }

    public virtual void extraLocalSearchResultsHistoryItemAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLocalSearchResultsHistoryItemSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLocalSearchResultsHistoryItemLookup(key);
        if (old_field == null)
          {
            extraLocalSearchResultsHistoryItemAppendPair(key, new_component);
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
        if (flagHasTimestamp)
          {
            handler.start_pair("Timestamp");
            handler.number_value(storeTimestamp);
          }
        if (flagHasYelpID)
          {
            handler.start_pair("YelpID");
            handler.string_value(storeYelpID);
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

    public static LocalSearchResultsHistoryItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchResultsHistoryItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchResultsHistoryItem", ignore_extras);
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
    public static LocalSearchResultsHistoryItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalSearchResultsHistoryItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchResultsHistoryItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchResultsHistoryItem", ignore_extras);
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
    public static LocalSearchResultsHistoryItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalSearchResultsHistoryItemJSON from_text(string text, bool ignore_extras)
      {
        LocalSearchResultsHistoryItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchResultsHistoryItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LocalSearchResultsHistoryItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static LocalSearchResultsHistoryItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LocalSearchResultsHistoryItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchResultsHistoryItem", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorTimestamp : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorTimestamp(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorTimestamp : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorTimestamp(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorTimestamp fieldGeneratorTimestamp;
        private JSONHoldingStringGenerator fieldGeneratorYelpID;
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
            LocalSearchResultsHistoryItemJSON result = new LocalSearchResultsHistoryItemJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLocalSearchResultsHistoryItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(LocalSearchResultsHistoryItemJSON result)
          {
            if (fieldGeneratorTimestamp.have_value)
              {
                result.setTimestamp(fieldGeneratorTimestamp.value);
                fieldGeneratorTimestamp.have_value = false;
              }
            if (fieldGeneratorYelpID.have_value)
              {
                result.setYelpID(fieldGeneratorYelpID.value);
                fieldGeneratorYelpID.have_value = false;
              }
          }
        protected abstract void handle_result(LocalSearchResultsHistoryItemJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'T':
                    if ((String.Compare(field_name, 1, "imestamp", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorTimestamp;
                    break;
                case 'Y':
                    if ((String.Compare(field_name, 1, "elpID", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorYelpID;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTimestamp = new FieldHoldingGeneratorTimestamp("field \"Timestamp\" of the LocalSearchResultsHistoryItem class");
            fieldGeneratorYelpID = new JSONHoldingStringGenerator("field \"YelpID\" of the LocalSearchResultsHistoryItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LocalSearchResultsHistoryItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTimestamp = new FieldHoldingGeneratorTimestamp("field \"Timestamp\" of the LocalSearchResultsHistoryItem class");
            fieldGeneratorYelpID = new JSONHoldingStringGenerator("field \"YelpID\" of the LocalSearchResultsHistoryItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LocalSearchResultsHistoryItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTimestamp.reset();
            fieldGeneratorYelpID.reset();
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
        protected override void handle_result(LocalSearchResultsHistoryItemJSON  result)
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
        public LocalSearchResultsHistoryItemJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LocalSearchResultsHistoryItemJSON  result)
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
    protected virtual void handle_result(List<LocalSearchResultsHistoryItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LocalSearchResultsHistoryItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LocalSearchResultsHistoryItemJSON>();
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
    public List<LocalSearchResultsHistoryItemJSON> value;
  };
  };
