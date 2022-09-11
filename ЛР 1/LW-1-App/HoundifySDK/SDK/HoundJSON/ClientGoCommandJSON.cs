/* file "ClientGoCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ClientGoCommandJSON : ClientCommandJSON
  {
    private bool flagHasIsRelative;
    private bool storeIsRelative;
    private bool flagHasIndex;
    private BigInteger storeIndex;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraIsRelativeToJSON()
      {
        JSONValue generated_boolean_IsRelative = (storeIsRelative ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsRelative;
      }

    private JSONValue  extraIndexToJSON()
      {
        JSONIntegerValue generated_integer_Index = new JSONIntegerValue(storeIndex);
        return generated_integer_Index;
      }


    private void  fromJSONIsRelative(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsRelative of ClientGoCommandJSON is not true for false.");
              }
          }
        setIsRelative(the_bool);
      }


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
                throw new Exception("The value for field Index of ClientGoCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Index of ClientGoCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIndex(extracted_integer);
      }


    public ClientGoCommandJSON()
      {
        flagHasIsRelative = false;
        flagHasIndex = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getClientCommandKind()
      {
        return "ClientGoCommand";
      }

    public bool  hasIsRelative()
      {
        return flagHasIsRelative;
      }

    public bool  getIsRelative()
      {
        Debug.Assert(flagHasIsRelative);
        return storeIsRelative;
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


    public virtual int extraClientGoCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraClientGoCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraClientGoCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraClientGoCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraClientCommandComponentCount()
      {
        int result = 0;
        if (flagHasIsRelative)
            ++result;
        if (flagHasIndex)
            ++result;
        result += extraClientGoCommandComponentCount();
        return result;
      }
    public override string extraClientCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasIsRelative)
          {
            if (remainder == 0)
                return "IsRelative";
            --remainder;
          }
        if (flagHasIndex)
          {
            if (remainder == 0)
                return "Index";
            --remainder;
          }
        return extraClientGoCommandComponentKey(remainder);
      }
    public override JSONValue extraClientCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasIsRelative)
          {
            if (remainder == 0)
                return extraIsRelativeToJSON();
            --remainder;
          }
        if (flagHasIndex)
          {
            if (remainder == 0)
                return extraIndexToJSON();
            --remainder;
          }
        return extraClientGoCommandComponentValue(remainder);
      }
    public override JSONValue extraClientCommandLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "I", 0, 1, false) == 0)
          {
            switch (field_name[1])
              {
                case 'n':
                    if ((String.Compare(field_name, 2, "dex", 0, 3, false) == 0) && (field_name.Length == 5))
                        return (flagHasIndex ? extraIndexToJSON() : null);
                    break;
                case 's':
                    if ((String.Compare(field_name, 2, "Relative", 0, 8, false) == 0) && (field_name.Length == 10))
                        return (flagHasIsRelative ? extraIsRelativeToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraClientGoCommandLookup(field_name);
      }

    public void setIsRelative(bool new_value)
      {
        flagHasIsRelative = true;
        storeIsRelative = new_value;
      }
    public void unsetIsRelative()
      {
        flagHasIsRelative = false;
      }
    public void setIndex(BigInteger new_value)
      {
        flagHasIndex = true;
        storeIndex = new_value;
      }
    public void unsetIndex()
      {
        flagHasIndex = false;
      }

    public virtual void extraClientGoCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraClientGoCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraClientGoCommandLookup(key);
        if (old_field == null)
          {
            extraClientGoCommandAppendPair(key, new_component);
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
    public override void extraClientCommandAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "I", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'n':
                    if ((String.Compare(key, 2, "dex", 0, 3, false) == 0) && (key.Length == 5))
                        {
                        fromJSONIndex(new_component, false);
                        return;
                        }
                    break;
                case 's':
                    if ((String.Compare(key, 2, "Relative", 0, 8, false) == 0) && (key.Length == 10))
                        {
                        fromJSONIsRelative(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraClientGoCommandAppendPair(key, new_component);
      }
    public override void extraClientCommandSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "I", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'n':
                    if ((String.Compare(key, 2, "dex", 0, 3, false) == 0) && (key.Length == 5))
                        {
                        fromJSONIndex(new_component, false);
                        return;
                        }
                    break;
                case 's':
                    if ((String.Compare(key, 2, "Relative", 0, 8, false) == 0) && (key.Length == 10))
                        {
                        fromJSONIsRelative(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraClientGoCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasIsRelative);
        if (flagHasIsRelative)
          {
            handler.start_pair("IsRelative");
            handler.boolean_value(storeIsRelative);
          }
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasIsRelative()))
          {
            return "When parsing the object for %what%, the \"IsRelative\" field was missing.";
          }
        if (!(hasIndex()))
          {
            return "When parsing the object for %what%, the \"Index\" field was missing.";
          }
        return null;
      }

    public static new ClientGoCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClientGoCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientGoCommand", ignore_extras);
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
    public static new ClientGoCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ClientGoCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClientGoCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientGoCommand", ignore_extras);
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
    public static new ClientGoCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ClientGoCommandJSON from_text(string text, bool ignore_extras)
      {
        ClientGoCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientGoCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ClientGoCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ClientGoCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ClientGoCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClientGoCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ClientCommandJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorIsRelative;
    private class FieldHoldingGeneratorIndex : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorIndex(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorIndex : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorIndex(String what) : base(what)
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
            if (!(getClientCommandJSONKey().Equals("ClientGoCommand")))
                throw new Exception("The key field has a value other than `ClientGoCommand'.");
            ClientGoCommandJSON result = new ClientGoCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraClientGoCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ClientCommandJSON new_result)
          {
            handle_result((ClientGoCommandJSON )new_result);
          }
        protected void finish(ClientGoCommandJSON result)
          {
            if (fieldGeneratorIsRelative.have_value)
              {
                result.setIsRelative(fieldGeneratorIsRelative.value);
                fieldGeneratorIsRelative.have_value = false;
              }
            else if ((!(result.hasIsRelative())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsRelative\" field was missing.");
              }
            if (fieldGeneratorIndex.have_value)
              {
                result.setIndex(fieldGeneratorIndex.value);
                fieldGeneratorIndex.have_value = false;
              }
            else if ((!(result.hasIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Index\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ClientGoCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "I", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'n':
                        if ((String.Compare(field_name, 2, "dex", 0, 3, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorIndex;
                        break;
                    case 's':
                        if ((String.Compare(field_name, 2, "Relative", 0, 8, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorIsRelative;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorIsRelative = new JSONHoldingBooleanGenerator("field \"IsRelative\" of the ClientGoCommand class");
            fieldGeneratorIndex = new FieldHoldingGeneratorIndex("field \"Index\" of the ClientGoCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ClientGoCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorIsRelative = new JSONHoldingBooleanGenerator("field \"IsRelative\" of the ClientGoCommand class");
            fieldGeneratorIndex = new FieldHoldingGeneratorIndex("field \"Index\" of the ClientGoCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ClientGoCommand class");
          }

        public override void reset()
          {
            fieldGeneratorIsRelative.reset();
            fieldGeneratorIndex.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ClientGoCommandJSON  result)
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
        public ClientGoCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ClientGoCommandJSON  result)
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
    protected virtual void handle_result(List<ClientGoCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ClientGoCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ClientGoCommandJSON>();
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
    public List<ClientGoCommandJSON> value;
  };
  };
