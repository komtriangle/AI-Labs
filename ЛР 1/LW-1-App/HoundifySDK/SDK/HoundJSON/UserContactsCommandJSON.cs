/* file "UserContactsCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UserContactsCommandJSON : CommandResultJSON
  {
    private bool flagHasStartingContactCount;
    private BigInteger storeStartingContactCount;
    private bool flagHasEndingContactCount;
    private BigInteger storeEndingContactCount;
    private bool flagHasFoundMatches;
    private List< OneContactJSON  > storeFoundMatches;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraStartingContactCountToJSON()
      {
        JSONIntegerValue generated_integer_StartingContactCount = new JSONIntegerValue(storeStartingContactCount);
        return generated_integer_StartingContactCount;
      }

    private JSONValue  extraEndingContactCountToJSON()
      {
        JSONIntegerValue generated_integer_EndingContactCount = new JSONIntegerValue(storeEndingContactCount);
        return generated_integer_EndingContactCount;
      }

    private JSONValue  extraFoundMatchesToJSON()
      {
        JSONArrayValue generated_array_1_FoundMatches = new JSONArrayValue();
        for (int num1 = 0; num1 < storeFoundMatches.Count; ++num1)
          {
            JSONValueHandler handler_FoundMatches = new JSONValueHandler();
            storeFoundMatches[num1].write_as_json(handler_FoundMatches);
            generated_array_1_FoundMatches.appendComponent(handler_FoundMatches.result);
          }
        return generated_array_1_FoundMatches;
      }


    private void  fromJSONStartingContactCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StartingContactCount of UserContactsCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StartingContactCount of UserContactsCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStartingContactCount(extracted_integer);
      }


    private void  fromJSONEndingContactCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EndingContactCount of UserContactsCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EndingContactCount of UserContactsCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEndingContactCount(extracted_integer);
      }


    private void  fromJSONFoundMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FoundMatches of UserContactsCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< OneContactJSON  > vector_FoundMatches1 = new List< OneContactJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            OneContactJSON convert_classy = OneContactJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FoundMatches1.Add(convert_classy);
          }
        initFoundMatches();
        for (int num1 = 0; num1 < vector_FoundMatches1.Count; ++num1)
            appendFoundMatches(vector_FoundMatches1[num1]);
        for (int num1 = 0; num1 < vector_FoundMatches1.Count; ++num1)
          {
          }
      }


    public UserContactsCommandJSON()
      {
        flagHasStartingContactCount = false;
        flagHasEndingContactCount = false;
        flagHasFoundMatches = false;
        storeFoundMatches = new List< OneContactJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "UserContactsCommand";
      }

    public bool  hasStartingContactCount()
      {
        return flagHasStartingContactCount;
      }

    public BigInteger  getStartingContactCount()
      {
        Debug.Assert(flagHasStartingContactCount);
        return storeStartingContactCount;
      }

    public bool  hasEndingContactCount()
      {
        return flagHasEndingContactCount;
      }

    public BigInteger  getEndingContactCount()
      {
        Debug.Assert(flagHasEndingContactCount);
        return storeEndingContactCount;
      }

    public bool  hasFoundMatches()
      {
        return flagHasFoundMatches;
      }

    public int  countOfFoundMatches()
      {
        Debug.Assert(flagHasFoundMatches);
        return storeFoundMatches.Count;
      }

    public OneContactJSON   elementOfFoundMatches(int element_num)
      {
        Debug.Assert(flagHasFoundMatches);
        return storeFoundMatches[element_num];
      }

    public List< OneContactJSON  >  getFoundMatches()
      {
        Debug.Assert(flagHasFoundMatches);
        return storeFoundMatches;
      }


    public virtual int extraUserContactsCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserContactsCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserContactsCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserContactsCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasStartingContactCount)
            ++result;
        if (flagHasEndingContactCount)
            ++result;
        if (flagHasFoundMatches)
            ++result;
        result += extraUserContactsCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasStartingContactCount)
          {
            if (remainder == 0)
                return "StartingContactCount";
            --remainder;
          }
        if (flagHasEndingContactCount)
          {
            if (remainder == 0)
                return "EndingContactCount";
            --remainder;
          }
        if (flagHasFoundMatches)
          {
            if (remainder == 0)
                return "FoundMatches";
            --remainder;
          }
        return extraUserContactsCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasStartingContactCount)
          {
            if (remainder == 0)
                return extraStartingContactCountToJSON();
            --remainder;
          }
        if (flagHasEndingContactCount)
          {
            if (remainder == 0)
                return extraEndingContactCountToJSON();
            --remainder;
          }
        if (flagHasFoundMatches)
          {
            if (remainder == 0)
                return extraFoundMatchesToJSON();
            --remainder;
          }
        return extraUserContactsCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "ndingContactCount", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasEndingContactCount ? extraEndingContactCountToJSON() : null);
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "oundMatches", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasFoundMatches ? extraFoundMatchesToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tartingContactCount", 0, 19, false) == 0) && (field_name.Length == 20))
                    return (flagHasStartingContactCount ? extraStartingContactCountToJSON() : null);
                break;
            default:
                break;
          }
        return extraUserContactsCommandLookup(field_name);
      }

    public void setStartingContactCount(BigInteger new_value)
      {
        flagHasStartingContactCount = true;
        if (new_value < 0)
            throw new Exception("The value for field StartingContactCount of UserContactsCommandJSON is less than the lower bound (0) for that field.");
        storeStartingContactCount = new_value;
      }
    public void unsetStartingContactCount()
      {
        flagHasStartingContactCount = false;
      }
    public void setEndingContactCount(BigInteger new_value)
      {
        flagHasEndingContactCount = true;
        if (new_value < 0)
            throw new Exception("The value for field EndingContactCount of UserContactsCommandJSON is less than the lower bound (0) for that field.");
        storeEndingContactCount = new_value;
      }
    public void unsetEndingContactCount()
      {
        flagHasEndingContactCount = false;
      }
    public void initFoundMatches()
      {
        if (flagHasFoundMatches)
          {
            for (int num1 = 0; num1 < storeFoundMatches.Count; ++num1)
              {
              }
          }
        flagHasFoundMatches = true;
        storeFoundMatches.Clear();
      }
    public void appendFoundMatches(OneContactJSON  to_append)
      {
        if (!flagHasFoundMatches)
          {
            flagHasFoundMatches = true;
            storeFoundMatches.Clear();
          }
        Debug.Assert(flagHasFoundMatches);
        storeFoundMatches.Add(to_append);
      }
    public void unsetFoundMatches()
      {
        if (flagHasFoundMatches)
          {
            for (int num2 = 0; num2 < storeFoundMatches.Count; ++num2)
              {
              }
          }
        flagHasFoundMatches = false;
        storeFoundMatches.Clear();
      }

    public virtual void extraUserContactsCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserContactsCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserContactsCommandLookup(key);
        if (old_field == null)
          {
            extraUserContactsCommandAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "ndingContactCount", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONEndingContactCount(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "oundMatches", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONFoundMatches(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartingContactCount", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONStartingContactCount(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUserContactsCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "ndingContactCount", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONEndingContactCount(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "oundMatches", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONFoundMatches(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartingContactCount", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONStartingContactCount(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUserContactsCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStartingContactCount);
        if (flagHasStartingContactCount)
          {
            handler.start_pair("StartingContactCount");
            handler.number_value(storeStartingContactCount);
          }
        Debug.Assert(partial_allowed || flagHasEndingContactCount);
        if (flagHasEndingContactCount)
          {
            handler.start_pair("EndingContactCount");
            handler.number_value(storeEndingContactCount);
          }
        if (flagHasFoundMatches)
          {
            handler.start_pair("FoundMatches");
            handler.start_array();
            for (int num1 = 0; num1 < storeFoundMatches.Count; ++num1)
              {
                if (partial_allowed)
                    storeFoundMatches[num1].write_partial_as_json(handler);
                else
                    storeFoundMatches[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasStartingContactCount()))
          {
            return "When parsing the object for %what%, the \"StartingContactCount\" field was missing.";
          }
        if (!(hasEndingContactCount()))
          {
            return "When parsing the object for %what%, the \"EndingContactCount\" field was missing.";
          }
        return null;
      }

    public static new UserContactsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserContactsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsCommand", ignore_extras);
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
    public static new UserContactsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserContactsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserContactsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsCommand", ignore_extras);
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
    public static new UserContactsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserContactsCommandJSON from_text(string text, bool ignore_extras)
      {
        UserContactsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserContactsCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UserContactsCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserContactsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
    private class FieldHoldingGeneratorStartingContactCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStartingContactCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStartingContactCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStartingContactCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorStartingContactCount fieldGeneratorStartingContactCount;
    private class FieldHoldingGeneratorEndingContactCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorEndingContactCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorEndingContactCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorEndingContactCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorEndingContactCount fieldGeneratorEndingContactCount;
        private OneContactJSON.HoldingArrayGenerator fieldGeneratorFoundMatches;
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
            if (!(getCommandResultJSONKey().Equals("UserContactsCommand")))
                throw new Exception("The key field has a value other than `UserContactsCommand'.");
            UserContactsCommandJSON result = new UserContactsCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserContactsCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((UserContactsCommandJSON )new_result);
          }
        protected void finish(UserContactsCommandJSON result)
          {
            if (fieldGeneratorStartingContactCount.have_value)
              {
                result.setStartingContactCount(fieldGeneratorStartingContactCount.value);
                fieldGeneratorStartingContactCount.have_value = false;
              }
            else if ((!(result.hasStartingContactCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartingContactCount\" field was missing.");
              }
            if (fieldGeneratorEndingContactCount.have_value)
              {
                result.setEndingContactCount(fieldGeneratorEndingContactCount.value);
                fieldGeneratorEndingContactCount.have_value = false;
              }
            else if ((!(result.hasEndingContactCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndingContactCount\" field was missing.");
              }
            if (fieldGeneratorFoundMatches.have_value)
              {
                result.initFoundMatches();
                int count = fieldGeneratorFoundMatches.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFoundMatches(fieldGeneratorFoundMatches.value[num]);
                  }
                fieldGeneratorFoundMatches.value.Clear();
                fieldGeneratorFoundMatches.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(UserContactsCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ndingContactCount", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorEndingContactCount;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "oundMatches", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorFoundMatches;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartingContactCount", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorStartingContactCount;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorStartingContactCount = new FieldHoldingGeneratorStartingContactCount("field \"StartingContactCount\" of the UserContactsCommand class");
            fieldGeneratorEndingContactCount = new FieldHoldingGeneratorEndingContactCount("field \"EndingContactCount\" of the UserContactsCommand class");
            fieldGeneratorFoundMatches = new OneContactJSON.HoldingArrayGenerator("field \"FoundMatches\" of the UserContactsCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserContactsCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorStartingContactCount = new FieldHoldingGeneratorStartingContactCount("field \"StartingContactCount\" of the UserContactsCommand class");
            fieldGeneratorEndingContactCount = new FieldHoldingGeneratorEndingContactCount("field \"EndingContactCount\" of the UserContactsCommand class");
            fieldGeneratorFoundMatches = new OneContactJSON.HoldingArrayGenerator("field \"FoundMatches\" of the UserContactsCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserContactsCommand class");
          }

        public override void reset()
          {
            fieldGeneratorStartingContactCount.reset();
            fieldGeneratorEndingContactCount.reset();
            fieldGeneratorFoundMatches.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UserContactsCommandJSON  result)
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
        public UserContactsCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserContactsCommandJSON  result)
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
    protected virtual void handle_result(List<UserContactsCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserContactsCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserContactsCommandJSON>();
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
    public List<UserContactsCommandJSON> value;
  };
  };
