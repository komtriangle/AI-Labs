/* file "AnswerRangeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class AnswerRangeJSON : JSONBase
  {
    private bool flagHasLowerBound;
    private BigInteger storeLowerBound;
    private bool flagHasUpperBound;
    private BigInteger storeUpperBound;
    private bool flagHasSuccessor;
    private BigInteger storeSuccessor;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLowerBound(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field LowerBound of AnswerRangeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field LowerBound of AnswerRangeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setLowerBound(extracted_integer);
      }


    private void  fromJSONUpperBound(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field UpperBound of AnswerRangeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field UpperBound of AnswerRangeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setUpperBound(extracted_integer);
      }


    private void  fromJSONSuccessor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Successor of AnswerRangeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Successor of AnswerRangeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSuccessor(extracted_integer);
      }


    public AnswerRangeJSON()
      {
        flagHasLowerBound = false;
        flagHasUpperBound = false;
        flagHasSuccessor = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLowerBound()
      {
        return flagHasLowerBound;
      }

    public BigInteger  getLowerBound()
      {
        Debug.Assert(flagHasLowerBound);
        return storeLowerBound;
      }

    public bool  hasUpperBound()
      {
        return flagHasUpperBound;
      }

    public BigInteger  getUpperBound()
      {
        Debug.Assert(flagHasUpperBound);
        return storeUpperBound;
      }

    public bool  hasSuccessor()
      {
        return flagHasSuccessor;
      }

    public BigInteger  getSuccessor()
      {
        Debug.Assert(flagHasSuccessor);
        return storeSuccessor;
      }


    public virtual int extraAnswerRangeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAnswerRangeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAnswerRangeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAnswerRangeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLowerBound(BigInteger new_value)
      {
        flagHasLowerBound = true;
        if (new_value < 0)
            throw new Exception("The value for field LowerBound of AnswerRangeJSON is less than the lower bound (0) for that field.");
        storeLowerBound = new_value;
      }
    public void unsetLowerBound()
      {
        flagHasLowerBound = false;
      }
    public void setUpperBound(BigInteger new_value)
      {
        flagHasUpperBound = true;
        if (new_value < 0)
            throw new Exception("The value for field UpperBound of AnswerRangeJSON is less than the lower bound (0) for that field.");
        storeUpperBound = new_value;
      }
    public void unsetUpperBound()
      {
        flagHasUpperBound = false;
      }
    public void setSuccessor(BigInteger new_value)
      {
        flagHasSuccessor = true;
        if (new_value < 0)
            throw new Exception("The value for field Successor of AnswerRangeJSON is less than the lower bound (0) for that field.");
        storeSuccessor = new_value;
      }
    public void unsetSuccessor()
      {
        flagHasSuccessor = false;
      }

    public virtual void extraAnswerRangeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAnswerRangeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAnswerRangeLookup(key);
        if (old_field == null)
          {
            extraAnswerRangeAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLowerBound);
        if (flagHasLowerBound)
          {
            handler.start_pair("LowerBound");
            handler.number_value(storeLowerBound);
          }
        Debug.Assert(partial_allowed || flagHasUpperBound);
        if (flagHasUpperBound)
          {
            handler.start_pair("UpperBound");
            handler.number_value(storeUpperBound);
          }
        Debug.Assert(partial_allowed || flagHasSuccessor);
        if (flagHasSuccessor)
          {
            handler.start_pair("Successor");
            handler.number_value(storeSuccessor);
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
        if (!(hasLowerBound()))
          {
            return "When parsing the object for %what%, the \"LowerBound\" field was missing.";
          }
        if (!(hasUpperBound()))
          {
            return "When parsing the object for %what%, the \"UpperBound\" field was missing.";
          }
        if (!(hasSuccessor()))
          {
            return "When parsing the object for %what%, the \"Successor\" field was missing.";
          }
        return null;
      }

    public static AnswerRangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AnswerRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AnswerRange", ignore_extras);
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
    public static AnswerRangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AnswerRangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AnswerRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AnswerRange", ignore_extras);
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
    public static AnswerRangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AnswerRangeJSON from_text(string text, bool ignore_extras)
      {
        AnswerRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AnswerRange", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AnswerRangeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AnswerRangeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AnswerRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AnswerRange", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorLowerBound : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorLowerBound(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorLowerBound : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorLowerBound(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorLowerBound fieldGeneratorLowerBound;
    private class FieldHoldingGeneratorUpperBound : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorUpperBound(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorUpperBound : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorUpperBound(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorUpperBound fieldGeneratorUpperBound;
    private class FieldHoldingGeneratorSuccessor : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSuccessor(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSuccessor : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSuccessor(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSuccessor fieldGeneratorSuccessor;
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
            AnswerRangeJSON result = new AnswerRangeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAnswerRangeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AnswerRangeJSON result)
          {
            if (fieldGeneratorLowerBound.have_value)
              {
                result.setLowerBound(fieldGeneratorLowerBound.value);
                fieldGeneratorLowerBound.have_value = false;
              }
            else if ((!(result.hasLowerBound())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LowerBound\" field was missing.");
              }
            if (fieldGeneratorUpperBound.have_value)
              {
                result.setUpperBound(fieldGeneratorUpperBound.value);
                fieldGeneratorUpperBound.have_value = false;
              }
            else if ((!(result.hasUpperBound())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UpperBound\" field was missing.");
              }
            if (fieldGeneratorSuccessor.have_value)
              {
                result.setSuccessor(fieldGeneratorSuccessor.value);
                fieldGeneratorSuccessor.have_value = false;
              }
            else if ((!(result.hasSuccessor())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Successor\" field was missing.");
              }
          }
        protected abstract void handle_result(AnswerRangeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "owerBound", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorLowerBound;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "uccessor", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorSuccessor;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "pperBound", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorUpperBound;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLowerBound = new FieldHoldingGeneratorLowerBound("field \"LowerBound\" of the AnswerRange class");
            fieldGeneratorUpperBound = new FieldHoldingGeneratorUpperBound("field \"UpperBound\" of the AnswerRange class");
            fieldGeneratorSuccessor = new FieldHoldingGeneratorSuccessor("field \"Successor\" of the AnswerRange class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AnswerRange class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLowerBound = new FieldHoldingGeneratorLowerBound("field \"LowerBound\" of the AnswerRange class");
            fieldGeneratorUpperBound = new FieldHoldingGeneratorUpperBound("field \"UpperBound\" of the AnswerRange class");
            fieldGeneratorSuccessor = new FieldHoldingGeneratorSuccessor("field \"Successor\" of the AnswerRange class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AnswerRange class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLowerBound.reset();
            fieldGeneratorUpperBound.reset();
            fieldGeneratorSuccessor.reset();
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
        protected override void handle_result(AnswerRangeJSON  result)
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
        public AnswerRangeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AnswerRangeJSON  result)
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
    protected virtual void handle_result(List<AnswerRangeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AnswerRangeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AnswerRangeJSON>();
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
    public List<AnswerRangeJSON> value;
  };
  };
