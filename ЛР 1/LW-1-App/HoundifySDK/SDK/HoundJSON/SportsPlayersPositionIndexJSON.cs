/* file "SportsPlayersPositionIndexJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsPlayersPositionIndexJSON : JSONBase
  {
    private bool flagHasIndex;
    private BigInteger storeIndex;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Index of SportsPlayersPositionIndexJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Index of SportsPlayersPositionIndexJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIndex(extracted_integer);
      }


    public SportsPlayersPositionIndexJSON()
      {
        flagHasIndex = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasIndex()
      {
        return flagHasIndex;
      }

    public BigInteger  getIndex()
      {
        Debug.Assert(flagHasIndex);
        return storeIndex;
      }


    public virtual int extraSportsPlayersPositionIndexComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayersPositionIndexComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayersPositionIndexComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayersPositionIndexLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setIndex(BigInteger new_value)
      {
        flagHasIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field Index of SportsPlayersPositionIndexJSON is less than the lower bound (0) for that field.");
        storeIndex = new_value;
      }
    public void unsetIndex()
      {
        flagHasIndex = false;
      }

    public virtual void extraSportsPlayersPositionIndexAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayersPositionIndexSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayersPositionIndexLookup(key);
        if (old_field == null)
          {
            extraSportsPlayersPositionIndexAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasIndex);
        if (flagHasIndex)
          {
            handler.start_pair("Index");
            handler.number_value(storeIndex);
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
        if (!(hasIndex()))
          {
            return "When parsing the object for %what%, the \"Index\" field was missing.";
          }
        return null;
      }

    public static SportsPlayersPositionIndexJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayersPositionIndexJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersPositionIndex", ignore_extras);
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
    public static SportsPlayersPositionIndexJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayersPositionIndexJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayersPositionIndexJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersPositionIndex", ignore_extras);
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
    public static SportsPlayersPositionIndexJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayersPositionIndexJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayersPositionIndexJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersPositionIndex", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayersPositionIndexJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayersPositionIndexJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayersPositionIndexJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersPositionIndex", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIndex fieldGeneratorIndex;
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
            SportsPlayersPositionIndexJSON result = new SportsPlayersPositionIndexJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayersPositionIndexAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsPlayersPositionIndexJSON result)
          {
            if (fieldGeneratorIndex.have_value)
              {
                result.setIndex(fieldGeneratorIndex.value);
                fieldGeneratorIndex.have_value = false;
              }
            else if ((!(result.hasIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Index\" field was missing.");
              }
          }
        protected abstract void handle_result(SportsPlayersPositionIndexJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Index", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorIndex;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorIndex = new FieldHoldingGeneratorIndex("field \"Index\" of the SportsPlayersPositionIndex class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayersPositionIndex class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorIndex = new FieldHoldingGeneratorIndex("field \"Index\" of the SportsPlayersPositionIndex class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayersPositionIndex class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorIndex.reset();
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
        protected override void handle_result(SportsPlayersPositionIndexJSON  result)
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
        public SportsPlayersPositionIndexJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayersPositionIndexJSON  result)
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
    protected virtual void handle_result(List<SportsPlayersPositionIndexJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayersPositionIndexJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayersPositionIndexJSON>();
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
    public List<SportsPlayersPositionIndexJSON> value;
  };
  };
