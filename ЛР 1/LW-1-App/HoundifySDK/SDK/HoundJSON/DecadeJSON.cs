/* file "DecadeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class DecadeJSON : JSONBase
  {
    private bool flagHasDecade;
    private BigInteger storeDecade;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDecade(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Decade of DecadeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Decade of DecadeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDecade(extracted_integer);
      }


    public DecadeJSON()
      {
        flagHasDecade = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDecade()
      {
        return flagHasDecade;
      }

    public BigInteger  getDecade()
      {
        Debug.Assert(flagHasDecade);
        return storeDecade;
      }


    public virtual int extraDecadeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDecadeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDecadeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDecadeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDecade(BigInteger new_value)
      {
        flagHasDecade = true;
        if (new_value < 0)
            throw new Exception("The value for field Decade of DecadeJSON is less than the lower bound (0) for that field.");
        storeDecade = new_value;
      }
    public void unsetDecade()
      {
        flagHasDecade = false;
      }

    public virtual void extraDecadeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDecadeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDecadeLookup(key);
        if (old_field == null)
          {
            extraDecadeAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDecade);
        if (flagHasDecade)
          {
            handler.start_pair("Decade");
            handler.number_value(storeDecade);
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
        if (!(hasDecade()))
          {
            return "When parsing the object for %what%, the \"Decade\" field was missing.";
          }
        return null;
      }

    public static DecadeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DecadeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Decade", ignore_extras);
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
    public static DecadeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DecadeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DecadeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Decade", ignore_extras);
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
    public static DecadeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DecadeJSON from_text(string text, bool ignore_extras)
      {
        DecadeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Decade", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DecadeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DecadeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DecadeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Decade", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorDecade : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDecade(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDecade : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDecade(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorDecade fieldGeneratorDecade;
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
            DecadeJSON result = new DecadeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDecadeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DecadeJSON result)
          {
            if (fieldGeneratorDecade.have_value)
              {
                result.setDecade(fieldGeneratorDecade.value);
                fieldGeneratorDecade.have_value = false;
              }
            else if ((!(result.hasDecade())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Decade\" field was missing.");
              }
          }
        protected abstract void handle_result(DecadeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Decade", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorDecade;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDecade = new FieldHoldingGeneratorDecade("field \"Decade\" of the Decade class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Decade class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDecade = new FieldHoldingGeneratorDecade("field \"Decade\" of the Decade class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Decade class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDecade.reset();
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
        protected override void handle_result(DecadeJSON  result)
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
        public DecadeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DecadeJSON  result)
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
    protected virtual void handle_result(List<DecadeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DecadeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DecadeJSON>();
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
    public List<DecadeJSON> value;
  };
  };
