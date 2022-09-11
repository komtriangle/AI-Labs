/* file "SportsStatsArgumentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class SportsStatsArgumentJSON : JSONBase
  {
    private bool flagHasArgumentID;
    private BigInteger storeArgumentID;
    private bool flagHasInstanceID;
    private string storeInstanceID;


    private void  fromJSONArgumentID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ArgumentID of SportsStatsArgumentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ArgumentID of SportsStatsArgumentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setArgumentID(extracted_integer);
      }


    private void  fromJSONInstanceID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InstanceID of SportsStatsArgumentJSON is not a string.");
        setInstanceID(json_string.getData());
      }


    public SportsStatsArgumentJSON()
      {
        flagHasArgumentID = false;
        flagHasInstanceID = false;
      }

    public abstract string getSportsStatsArgumentKind();
    public bool  hasArgumentID()
      {
        return flagHasArgumentID;
      }

    public BigInteger  getArgumentID()
      {
        Debug.Assert(flagHasArgumentID);
        return storeArgumentID;
      }

    public bool  hasInstanceID()
      {
        return flagHasInstanceID;
      }

    public string  getInstanceID()
      {
        Debug.Assert(flagHasInstanceID);
        return storeInstanceID;
      }


    public abstract int extraSportsStatsArgumentComponentCount();
    public abstract string extraSportsStatsArgumentComponentKey(int component_num);
    public abstract JSONValue extraSportsStatsArgumentComponentValue(int component_num);
    public abstract JSONValue extraSportsStatsArgumentLookup(string field_name);

    public void setArgumentID(BigInteger new_value)
      {
        flagHasArgumentID = true;
        if (new_value < 0)
            throw new Exception("The value for field ArgumentID of SportsStatsArgumentJSON is less than the lower bound (0) for that field.");
        storeArgumentID = new_value;
      }
    public void unsetArgumentID()
      {
        flagHasArgumentID = false;
      }
    public void setInstanceID(string new_value)
      {
        flagHasInstanceID = true;
        storeInstanceID = new_value;
      }
    public void unsetInstanceID()
      {
        flagHasInstanceID = false;
      }

    public abstract void extraSportsStatsArgumentAppendPair(string key, JSONValue new_component);
    public abstract void extraSportsStatsArgumentSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("SportsStatsArgumentKind", getSportsStatsArgumentKind());
        Debug.Assert(partial_allowed || flagHasArgumentID);
        if (flagHasArgumentID)
          {
            handler.start_pair("ArgumentID");
            handler.number_value(storeArgumentID);
          }
        if (flagHasInstanceID)
          {
            handler.start_pair("InstanceID");
            handler.string_value(storeInstanceID);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasArgumentID()))
          {
            return "When parsing the object for %what%, the \"ArgumentID\" field was missing.";
          }
        return null;
      }

    public static SportsStatsArgumentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsArgument", ignore_extras);
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
    public static SportsStatsArgumentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsArgumentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsArgument", ignore_extras);
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
    public static SportsStatsArgumentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsArgumentJSON from_text(string text, bool ignore_extras)
      {
        SportsStatsArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsArgument", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStatsArgumentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStatsArgumentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStatsArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsArgument", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorArgumentID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorArgumentID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorArgumentID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorArgumentID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorArgumentID fieldGeneratorArgumentID;
        private JSONHoldingStringGenerator fieldGeneratorInstanceID;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsStatsArgumentKind' field is missing.");
            SportsStatsArgumentJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStatsArgumentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getSportsStatsArgumentJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsStatsArgumentKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(SportsStatsArgumentJSON result)
          {
            if (fieldGeneratorArgumentID.have_value)
              {
                result.setArgumentID(fieldGeneratorArgumentID.value);
                fieldGeneratorArgumentID.have_value = false;
              }
            else if ((!(result.hasArgumentID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArgumentID\" field was missing.");
              }
            if (fieldGeneratorInstanceID.have_value)
              {
                result.setInstanceID(fieldGeneratorInstanceID.value);
                fieldGeneratorInstanceID.have_value = false;
              }
          }
        protected abstract void handle_result(SportsStatsArgumentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "rgumentID", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorArgumentID;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nstanceID", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorInstanceID;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "portsStatsArgumentKind", 0, 22, false) == 0) && (field_name.Length == 23))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorArgumentID = new FieldHoldingGeneratorArgumentID("field \"ArgumentID\" of the SportsStatsArgument class");
            fieldGeneratorInstanceID = new JSONHoldingStringGenerator("field \"InstanceID\" of the SportsStatsArgument class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsStatsArgumentKind\" of the SportsStatsArgument class");
            set_what("the SportsStatsArgument class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorArgumentID = new FieldHoldingGeneratorArgumentID("field \"ArgumentID\" of the SportsStatsArgument class");
            fieldGeneratorInstanceID = new JSONHoldingStringGenerator("field \"InstanceID\" of the SportsStatsArgument class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsStatsArgumentKind\" of the SportsStatsArgument class");
            set_what("the SportsStatsArgument class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorArgumentID.reset();
            fieldGeneratorInstanceID.reset();
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
        protected override void handle_result(SportsStatsArgumentJSON  result)
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
        public SportsStatsArgumentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStatsArgumentJSON  result)
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
    protected virtual void handle_result(List<SportsStatsArgumentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStatsArgumentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStatsArgumentJSON>();
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
    public List<SportsStatsArgumentJSON> value;
  };
    class GenericSportsStatsArgumentJSON : SportsStatsArgumentJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericSportsStatsArgumentJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getSportsStatsArgumentKind()  { return key; }
        public override int extraSportsStatsArgumentComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraSportsStatsArgumentComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraSportsStatsArgumentComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraSportsStatsArgumentLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraSportsStatsArgumentAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraSportsStatsArgumentSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraSportsStatsArgumentLookup(key);
            if (old_field == null)
              {
                extraSportsStatsArgumentAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static SportsStatsArgumentJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'P':
            if ((String.Compare(key, 1, "layer", 0, 5, false) == 0) && (key.Length == 6))
                return new SportsStatsArgumentPlayerJSON();
            break;
        case 'S':
            switch (key[1])
              {
                case 'e':
                    if ((String.Compare(key, 2, "ason", 0, 4, false) == 0) && (key.Length == 6))
                        return new SportsStatsArgumentSeasonJSON();
                    break;
                case 't':
                    if (String.Compare(key, 2, "at", 0, 2, false) == 0)
                      {
                        switch (key[4])
                          {
                            case 'M':
                                if ((String.Compare(key, 5, "odifier", 0, 7, false) == 0) && (key.Length == 12))
                                    return new SportsStatsArgumentStatModifierJSON();
                                break;
                            case 'T':
                                if ((String.Compare(key, 5, "ype", 0, 3, false) == 0) && (key.Length == 8))
                                    return new SportsStatsArgumentStatTypeJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'T':
            if ((String.Compare(key, 1, "eam", 0, 3, false) == 0) && (key.Length == 4))
                return new SportsStatsArgumentTeamJSON();
            break;
        default:
            break;
      }

        return new GenericSportsStatsArgumentJSON(key);
      }
  };
