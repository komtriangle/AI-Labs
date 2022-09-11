/* file "NumberFactsAPIResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class NumberFactsAPIResultJSON : JSONBase
  {
    public struct Typenumber
      {
        public int key;
        public BigInteger choice0;
        public string choice1;
      };
    private bool flagHastext;
    private string storetext;
    private bool flagHasnumber;
    private Typenumber storenumber;
    private bool flagHasfound;
    private bool storefound;
    private bool flagHastype;
    private string storetype;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONtext(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field text of NumberFactsAPIResultJSON is not a string.");
        settext(json_string.getData());
      }


    private void  fromJSONnumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typenumber or_result = new Typenumber();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for ??? is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                if (extracted_integer < 0)
                    throw new Exception("The value for ??? is less than the lower bound (0) for that field.");
                or_result.choice0 = extracted_integer;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice1 = json_string.getData();
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field number of NumberFactsAPIResultJSON is not one of the allowed values.");
        setnumber(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONfound(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field found of NumberFactsAPIResultJSON is not true for false.");
              }
          }
        setfound(the_bool);
      }


    private void  fromJSONtype(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field type of NumberFactsAPIResultJSON is not a string.");
        settype(json_string.getData());
      }


    public NumberFactsAPIResultJSON()
      {
        flagHastext = false;
        flagHasnumber = false;
        flagHasfound = false;
        flagHastype = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hastext()
      {
        return flagHastext;
      }

    public string  gettext()
      {
        Debug.Assert(flagHastext);
        return storetext;
      }

    public bool  hasnumber()
      {
        return flagHasnumber;
      }

    public Typenumber  getnumber()
      {
        Debug.Assert(flagHasnumber);
        return storenumber;
      }

    public bool  hasfound()
      {
        return flagHasfound;
      }

    public bool  getfound()
      {
        Debug.Assert(flagHasfound);
        return storefound;
      }

    public bool  hastype()
      {
        return flagHastype;
      }

    public string  gettype()
      {
        Debug.Assert(flagHastype);
        return storetype;
      }


    public virtual int extraNumberFactsAPIResultComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraNumberFactsAPIResultComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraNumberFactsAPIResultComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraNumberFactsAPIResultLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void settext(string new_value)
      {
        flagHastext = true;
        storetext = new_value;
      }
    public void unsettext()
      {
        flagHastext = false;
      }
    public void setnumber(Typenumber new_value)
      {
        flagHasnumber = true;
        switch (new_value.key)
          {
            case 0:
                if (new_value.choice0 < 0)
                    throw new Exception("The value for case 0 of field number of NumberFactsAPIResultJSON is less than the lower bound (0) for that field.");
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storenumber = new_value;
      }
    public void unsetnumber()
      {
        flagHasnumber = false;
      }
    public void setfound(bool new_value)
      {
        flagHasfound = true;
        storefound = new_value;
      }
    public void unsetfound()
      {
        flagHasfound = false;
      }
    public void settype(string new_value)
      {
        flagHastype = true;
        storetype = new_value;
      }
    public void unsettype()
      {
        flagHastype = false;
      }

    public virtual void extraNumberFactsAPIResultAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraNumberFactsAPIResultSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraNumberFactsAPIResultLookup(key);
        if (old_field == null)
          {
            extraNumberFactsAPIResultAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHastext);
        if (flagHastext)
          {
            handler.start_pair("text");
            handler.string_value(storetext);
          }
        Debug.Assert(partial_allowed || flagHasnumber);
        if (flagHasnumber)
          {
            handler.start_pair("number");
            switch (storenumber.key)
              {
                case 0:
                    handler.number_value(storenumber.choice0);
                    break;
                case 1:
                    handler.string_value(storenumber.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasfound);
        if (flagHasfound)
          {
            handler.start_pair("found");
            handler.boolean_value(storefound);
          }
        Debug.Assert(partial_allowed || flagHastype);
        if (flagHastype)
          {
            handler.start_pair("type");
            handler.string_value(storetype);
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
        if (!(hastext()))
          {
            return "When parsing the object for %what%, the \"text\" field was missing.";
          }
        if (!(hasnumber()))
          {
            return "When parsing the object for %what%, the \"number\" field was missing.";
          }
        if (!(hasfound()))
          {
            return "When parsing the object for %what%, the \"found\" field was missing.";
          }
        if (!(hastype()))
          {
            return "When parsing the object for %what%, the \"type\" field was missing.";
          }
        return null;
      }

    public static NumberFactsAPIResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NumberFactsAPIResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberFactsAPIResult", ignore_extras);
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
    public static NumberFactsAPIResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NumberFactsAPIResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NumberFactsAPIResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberFactsAPIResult", ignore_extras);
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
    public static NumberFactsAPIResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NumberFactsAPIResultJSON from_text(string text, bool ignore_extras)
      {
        NumberFactsAPIResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberFactsAPIResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NumberFactsAPIResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static NumberFactsAPIResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NumberFactsAPIResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberFactsAPIResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratortext;
    private class FieldHoldingGeneratornumber_0 : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratornumber_0(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratornumber_0 : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratornumber_0(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private abstract class FieldGeneratornumber : JSONParallelGenerator
          {
            private FieldHoldingGeneratornumber_0 field0;
            private JSONHoldingStringGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typenumber result = new Typenumber();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(Typenumber result);
            public FieldGeneratornumber(bool ignore_extras)
              {
                    field0 = new FieldHoldingGeneratornumber_0("option 0 of field \"number\"");
                    field1 = new JSONHoldingStringGenerator("option 1 of field \"number\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratornumber(string what, bool ignore_extras)
              {
                    field0 = new FieldHoldingGeneratornumber_0("option 0 of field \"number\"");
                    field1 = new JSONHoldingStringGenerator("option 1 of field \"number\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class Holdernumber
          {
            private bool have_data;
            private Typenumber data;
            public Holdernumber()  { have_data = false; }
            public Holdernumber(Typenumber init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holdernumber(Holdernumber other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public Typenumber referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratornumber : FieldGeneratornumber
          {
            protected override void handle_result(Typenumber result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holdernumber(result);
              }

            public FieldHoldingGeneratornumber(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holdernumber value;
          };
    private class FieldHoldingArrayGeneratornumber : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratornumber
      {
        private FieldHoldingArrayGeneratornumber top;

        protected override void handle_result(Typenumber result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratornumber init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typenumber> result)
      {
      }

    public FieldHoldingArrayGeneratornumber(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typenumber>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratornumber(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typenumber>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typenumber> value;
  };
        private FieldHoldingGeneratornumber fieldGeneratornumber;
        private JSONHoldingBooleanGenerator fieldGeneratorfound;
        private JSONHoldingStringGenerator fieldGeneratortype;
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
            NumberFactsAPIResultJSON result = new NumberFactsAPIResultJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraNumberFactsAPIResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(NumberFactsAPIResultJSON result)
          {
            if (fieldGeneratortext.have_value)
              {
                result.settext(fieldGeneratortext.value);
                fieldGeneratortext.have_value = false;
              }
            else if ((!(result.hastext())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"text\" field was missing.");
              }
            if (fieldGeneratornumber.have_value)
              {
                result.setnumber(fieldGeneratornumber.value.referenced());
                fieldGeneratornumber.have_value = false;
              }
            else if ((!(result.hasnumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"number\" field was missing.");
              }
            if (fieldGeneratorfound.have_value)
              {
                result.setfound(fieldGeneratorfound.value);
                fieldGeneratorfound.have_value = false;
              }
            else if ((!(result.hasfound())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"found\" field was missing.");
              }
            if (fieldGeneratortype.have_value)
              {
                result.settype(fieldGeneratortype.value);
                fieldGeneratortype.have_value = false;
              }
            else if ((!(result.hastype())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"type\" field was missing.");
              }
          }
        protected abstract void handle_result(NumberFactsAPIResultJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'f':
                    if ((String.Compare(field_name, 1, "ound", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorfound;
                    break;
                case 'n':
                    if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratornumber;
                    break;
                case 't':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "xt", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratortext;
                            break;
                        case 'y':
                            if ((String.Compare(field_name, 2, "pe", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratortype;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratortext = new JSONHoldingStringGenerator("field \"text\" of the NumberFactsAPIResult class");
            fieldGeneratornumber = new FieldHoldingGeneratornumber("field \"number\" of the NumberFactsAPIResult class", ignore_extras);
            fieldGeneratorfound = new JSONHoldingBooleanGenerator("field \"found\" of the NumberFactsAPIResult class");
            fieldGeneratortype = new JSONHoldingStringGenerator("field \"type\" of the NumberFactsAPIResult class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the NumberFactsAPIResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratortext = new JSONHoldingStringGenerator("field \"text\" of the NumberFactsAPIResult class");
            fieldGeneratornumber = new FieldHoldingGeneratornumber("field \"number\" of the NumberFactsAPIResult class", false);
            fieldGeneratorfound = new JSONHoldingBooleanGenerator("field \"found\" of the NumberFactsAPIResult class");
            fieldGeneratortype = new JSONHoldingStringGenerator("field \"type\" of the NumberFactsAPIResult class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the NumberFactsAPIResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratortext.reset();
            fieldGeneratornumber.reset();
            fieldGeneratorfound.reset();
            fieldGeneratortype.reset();
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
        protected override void handle_result(NumberFactsAPIResultJSON  result)
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
        public NumberFactsAPIResultJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NumberFactsAPIResultJSON  result)
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
    protected virtual void handle_result(List<NumberFactsAPIResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NumberFactsAPIResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NumberFactsAPIResultJSON>();
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
    public List<NumberFactsAPIResultJSON> value;
  };
  };
