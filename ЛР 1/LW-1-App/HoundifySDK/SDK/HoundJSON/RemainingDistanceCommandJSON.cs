/* file "RemainingDistanceCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RemainingDistanceCommandJSON : NavigationControlCommandJSON
  {
    private bool flagHasIntermediateDestinationRequested;
    private bool storeIntermediateDestinationRequested;
    private bool flagHasIntermediateDestinationPositionFromStart;
    private BigInteger storeIntermediateDestinationPositionFromStart;
    private bool flagHasIntermediateDestinationPositionFromEnd;
    private BigInteger storeIntermediateDestinationPositionFromEnd;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraIntermediateDestinationRequestedToJSON()
      {
        JSONValue generated_boolean_IntermediateDestinationRequested = (storeIntermediateDestinationRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IntermediateDestinationRequested;
      }

    private JSONValue  extraIntermediateDestinationPositionFromStartToJSON()
      {
        JSONIntegerValue generated_integer_IntermediateDestinationPositionFromStart = new JSONIntegerValue(storeIntermediateDestinationPositionFromStart);
        return generated_integer_IntermediateDestinationPositionFromStart;
      }

    private JSONValue  extraIntermediateDestinationPositionFromEndToJSON()
      {
        JSONIntegerValue generated_integer_IntermediateDestinationPositionFromEnd = new JSONIntegerValue(storeIntermediateDestinationPositionFromEnd);
        return generated_integer_IntermediateDestinationPositionFromEnd;
      }


    private void  fromJSONIntermediateDestinationRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IntermediateDestinationRequested of RemainingDistanceCommandJSON is not true for false.");
              }
          }
        setIntermediateDestinationRequested(the_bool);
      }


    private void  fromJSONIntermediateDestinationPositionFromStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field IntermediateDestinationPositionFromStart of RemainingDistanceCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field IntermediateDestinationPositionFromStart of RemainingDistanceCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIntermediateDestinationPositionFromStart(extracted_integer);
      }


    private void  fromJSONIntermediateDestinationPositionFromEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field IntermediateDestinationPositionFromEnd of RemainingDistanceCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field IntermediateDestinationPositionFromEnd of RemainingDistanceCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIntermediateDestinationPositionFromEnd(extracted_integer);
      }


    public RemainingDistanceCommandJSON()
      {
        flagHasIntermediateDestinationRequested = false;
        flagHasIntermediateDestinationPositionFromStart = false;
        flagHasIntermediateDestinationPositionFromEnd = false;
        storeIntermediateDestinationRequested = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandType()
      {
        return "RemainingDistance";
      }

    public bool  hasIntermediateDestinationRequested()
      {
        return flagHasIntermediateDestinationRequested;
      }

    public bool  getIntermediateDestinationRequested()
      {
        return storeIntermediateDestinationRequested;
      }

    public bool  hasIntermediateDestinationPositionFromStart()
      {
        return flagHasIntermediateDestinationPositionFromStart;
      }

    public BigInteger  getIntermediateDestinationPositionFromStart()
      {
        Debug.Assert(flagHasIntermediateDestinationPositionFromStart);
        return storeIntermediateDestinationPositionFromStart;
      }

    public bool  hasIntermediateDestinationPositionFromEnd()
      {
        return flagHasIntermediateDestinationPositionFromEnd;
      }

    public BigInteger  getIntermediateDestinationPositionFromEnd()
      {
        Debug.Assert(flagHasIntermediateDestinationPositionFromEnd);
        return storeIntermediateDestinationPositionFromEnd;
      }


    public virtual int extraRemainingDistanceCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRemainingDistanceCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRemainingDistanceCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRemainingDistanceCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraNavigationControlCommandComponentCount()
      {
        int result = 0;
        if (flagHasIntermediateDestinationRequested)
            ++result;
        if (flagHasIntermediateDestinationPositionFromStart)
            ++result;
        if (flagHasIntermediateDestinationPositionFromEnd)
            ++result;
        result += extraRemainingDistanceCommandComponentCount();
        return result;
      }
    public override string extraNavigationControlCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasIntermediateDestinationRequested)
          {
            if (remainder == 0)
                return "IntermediateDestinationRequested";
            --remainder;
          }
        if (flagHasIntermediateDestinationPositionFromStart)
          {
            if (remainder == 0)
                return "IntermediateDestinationPositionFromStart";
            --remainder;
          }
        if (flagHasIntermediateDestinationPositionFromEnd)
          {
            if (remainder == 0)
                return "IntermediateDestinationPositionFromEnd";
            --remainder;
          }
        return extraRemainingDistanceCommandComponentKey(remainder);
      }
    public override JSONValue extraNavigationControlCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasIntermediateDestinationRequested)
          {
            if (remainder == 0)
                return extraIntermediateDestinationRequestedToJSON();
            --remainder;
          }
        if (flagHasIntermediateDestinationPositionFromStart)
          {
            if (remainder == 0)
                return extraIntermediateDestinationPositionFromStartToJSON();
            --remainder;
          }
        if (flagHasIntermediateDestinationPositionFromEnd)
          {
            if (remainder == 0)
                return extraIntermediateDestinationPositionFromEndToJSON();
            --remainder;
          }
        return extraRemainingDistanceCommandComponentValue(remainder);
      }
    public override JSONValue extraNavigationControlCommandLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "IntermediateDestination", 0, 23, false) == 0)
          {
            switch (field_name[23])
              {
                case 'P':
                    if (String.Compare(field_name, 24, "ositionFrom", 0, 11, false) == 0)
                      {
                        switch (field_name[35])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 36, "nd", 0, 2, false) == 0) && (field_name.Length == 38))
                                    return (flagHasIntermediateDestinationPositionFromEnd ? extraIntermediateDestinationPositionFromEndToJSON() : null);
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 36, "tart", 0, 4, false) == 0) && (field_name.Length == 40))
                                    return (flagHasIntermediateDestinationPositionFromStart ? extraIntermediateDestinationPositionFromStartToJSON() : null);
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 24, "equested", 0, 8, false) == 0) && (field_name.Length == 32))
                        return (flagHasIntermediateDestinationRequested ? extraIntermediateDestinationRequestedToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraRemainingDistanceCommandLookup(field_name);
      }

    public void setIntermediateDestinationRequested(bool new_value)
      {
        flagHasIntermediateDestinationRequested = true;
        storeIntermediateDestinationRequested = new_value;
      }
    public void unsetIntermediateDestinationRequested()
      {
        flagHasIntermediateDestinationRequested = false;
      }
    public void setIntermediateDestinationPositionFromStart(BigInteger new_value)
      {
        flagHasIntermediateDestinationPositionFromStart = true;
        if (new_value < 0)
            throw new Exception("The value for field IntermediateDestinationPositionFromStart of RemainingDistanceCommandJSON is less than the lower bound (0) for that field.");
        storeIntermediateDestinationPositionFromStart = new_value;
      }
    public void unsetIntermediateDestinationPositionFromStart()
      {
        flagHasIntermediateDestinationPositionFromStart = false;
      }
    public void setIntermediateDestinationPositionFromEnd(BigInteger new_value)
      {
        flagHasIntermediateDestinationPositionFromEnd = true;
        if (new_value < 0)
            throw new Exception("The value for field IntermediateDestinationPositionFromEnd of RemainingDistanceCommandJSON is less than the lower bound (0) for that field.");
        storeIntermediateDestinationPositionFromEnd = new_value;
      }
    public void unsetIntermediateDestinationPositionFromEnd()
      {
        flagHasIntermediateDestinationPositionFromEnd = false;
      }

    public virtual void extraRemainingDistanceCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRemainingDistanceCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRemainingDistanceCommandLookup(key);
        if (old_field == null)
          {
            extraRemainingDistanceCommandAppendPair(key, new_component);
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
    public override void extraNavigationControlCommandAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "IntermediateDestination", 0, 23, false) == 0)
          {
            switch (key[23])
              {
                case 'P':
                    if (String.Compare(key, 24, "ositionFrom", 0, 11, false) == 0)
                      {
                        switch (key[35])
                          {
                            case 'E':
                                if ((String.Compare(key, 36, "nd", 0, 2, false) == 0) && (key.Length == 38))
                                    {
                                    fromJSONIntermediateDestinationPositionFromEnd(new_component, false);
                                    return;
                                    }
                                break;
                            case 'S':
                                if ((String.Compare(key, 36, "tart", 0, 4, false) == 0) && (key.Length == 40))
                                    {
                                    fromJSONIntermediateDestinationPositionFromStart(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(key, 24, "equested", 0, 8, false) == 0) && (key.Length == 32))
                        {
                        fromJSONIntermediateDestinationRequested(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraRemainingDistanceCommandAppendPair(key, new_component);
      }
    public override void extraNavigationControlCommandSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "IntermediateDestination", 0, 23, false) == 0)
          {
            switch (key[23])
              {
                case 'P':
                    if (String.Compare(key, 24, "ositionFrom", 0, 11, false) == 0)
                      {
                        switch (key[35])
                          {
                            case 'E':
                                if ((String.Compare(key, 36, "nd", 0, 2, false) == 0) && (key.Length == 38))
                                    {
                                    fromJSONIntermediateDestinationPositionFromEnd(new_component, false);
                                    return;
                                    }
                                break;
                            case 'S':
                                if ((String.Compare(key, 36, "tart", 0, 4, false) == 0) && (key.Length == 40))
                                    {
                                    fromJSONIntermediateDestinationPositionFromStart(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(key, 24, "equested", 0, 8, false) == 0) && (key.Length == 32))
                        {
                        fromJSONIntermediateDestinationRequested(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraRemainingDistanceCommandSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasIntermediateDestinationRequested)
          {
            handler.start_pair("IntermediateDestinationRequested");
            handler.boolean_value(storeIntermediateDestinationRequested);
          }
        if (flagHasIntermediateDestinationPositionFromStart)
          {
            handler.start_pair("IntermediateDestinationPositionFromStart");
            handler.number_value(storeIntermediateDestinationPositionFromStart);
          }
        if (flagHasIntermediateDestinationPositionFromEnd)
          {
            handler.start_pair("IntermediateDestinationPositionFromEnd");
            handler.number_value(storeIntermediateDestinationPositionFromEnd);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new RemainingDistanceCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RemainingDistanceCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RemainingDistanceCommand", ignore_extras);
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
    public static new RemainingDistanceCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RemainingDistanceCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RemainingDistanceCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RemainingDistanceCommand", ignore_extras);
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
    public static new RemainingDistanceCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RemainingDistanceCommandJSON from_text(string text, bool ignore_extras)
      {
        RemainingDistanceCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RemainingDistanceCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RemainingDistanceCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RemainingDistanceCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RemainingDistanceCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RemainingDistanceCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : NavigationControlCommandJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorIntermediateDestinationRequested;
    private class FieldHoldingGeneratorIntermediateDestinationPositionFromStart : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIntermediateDestinationPositionFromStart(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIntermediateDestinationPositionFromStart : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIntermediateDestinationPositionFromStart(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIntermediateDestinationPositionFromStart fieldGeneratorIntermediateDestinationPositionFromStart;
    private class FieldHoldingGeneratorIntermediateDestinationPositionFromEnd : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIntermediateDestinationPositionFromEnd(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIntermediateDestinationPositionFromEnd : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIntermediateDestinationPositionFromEnd(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIntermediateDestinationPositionFromEnd fieldGeneratorIntermediateDestinationPositionFromEnd;
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
            if (!(getNavigationControlCommandJSONKey().Equals("RemainingDistance")))
                throw new Exception("The key field has a value other than `RemainingDistance'.");
            RemainingDistanceCommandJSON result = new RemainingDistanceCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRemainingDistanceCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(NavigationControlCommandJSON new_result)
          {
            handle_result((RemainingDistanceCommandJSON )new_result);
          }
        protected void finish(RemainingDistanceCommandJSON result)
          {
            if (fieldGeneratorIntermediateDestinationRequested.have_value)
              {
                result.setIntermediateDestinationRequested(fieldGeneratorIntermediateDestinationRequested.value);
                fieldGeneratorIntermediateDestinationRequested.have_value = false;
              }
            if (fieldGeneratorIntermediateDestinationPositionFromStart.have_value)
              {
                result.setIntermediateDestinationPositionFromStart(fieldGeneratorIntermediateDestinationPositionFromStart.value);
                fieldGeneratorIntermediateDestinationPositionFromStart.have_value = false;
              }
            if (fieldGeneratorIntermediateDestinationPositionFromEnd.have_value)
              {
                result.setIntermediateDestinationPositionFromEnd(fieldGeneratorIntermediateDestinationPositionFromEnd.value);
                fieldGeneratorIntermediateDestinationPositionFromEnd.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RemainingDistanceCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "IntermediateDestination", 0, 23, false) == 0)
              {
                switch (field_name[23])
                  {
                    case 'P':
                        if (String.Compare(field_name, 24, "ositionFrom", 0, 11, false) == 0)
                          {
                            switch (field_name[35])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 36, "nd", 0, 2, false) == 0) && (field_name.Length == 38))
                                        return fieldGeneratorIntermediateDestinationPositionFromEnd;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 36, "tart", 0, 4, false) == 0) && (field_name.Length == 40))
                                        return fieldGeneratorIntermediateDestinationPositionFromStart;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 24, "equested", 0, 8, false) == 0) && (field_name.Length == 32))
                            return fieldGeneratorIntermediateDestinationRequested;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorIntermediateDestinationRequested = new JSONHoldingBooleanGenerator("field \"IntermediateDestinationRequested\" of the RemainingDistanceCommand class");
            fieldGeneratorIntermediateDestinationPositionFromStart = new FieldHoldingGeneratorIntermediateDestinationPositionFromStart("field \"IntermediateDestinationPositionFromStart\" of the RemainingDistanceCommand class");
            fieldGeneratorIntermediateDestinationPositionFromEnd = new FieldHoldingGeneratorIntermediateDestinationPositionFromEnd("field \"IntermediateDestinationPositionFromEnd\" of the RemainingDistanceCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RemainingDistanceCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorIntermediateDestinationRequested = new JSONHoldingBooleanGenerator("field \"IntermediateDestinationRequested\" of the RemainingDistanceCommand class");
            fieldGeneratorIntermediateDestinationPositionFromStart = new FieldHoldingGeneratorIntermediateDestinationPositionFromStart("field \"IntermediateDestinationPositionFromStart\" of the RemainingDistanceCommand class");
            fieldGeneratorIntermediateDestinationPositionFromEnd = new FieldHoldingGeneratorIntermediateDestinationPositionFromEnd("field \"IntermediateDestinationPositionFromEnd\" of the RemainingDistanceCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RemainingDistanceCommand class");
          }

        public override void reset()
          {
            fieldGeneratorIntermediateDestinationRequested.reset();
            fieldGeneratorIntermediateDestinationPositionFromStart.reset();
            fieldGeneratorIntermediateDestinationPositionFromEnd.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RemainingDistanceCommandJSON  result)
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
        public RemainingDistanceCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RemainingDistanceCommandJSON  result)
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
    protected virtual void handle_result(List<RemainingDistanceCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RemainingDistanceCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RemainingDistanceCommandJSON>();
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
    public List<RemainingDistanceCommandJSON> value;
  };
  };
