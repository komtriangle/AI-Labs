/* file "StoredAlwaysMatchReadDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StoredAlwaysMatchReadDataJSON : JSONBase
  {
    private bool flagHasValue;
    private bool storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Value of StoredAlwaysMatchReadDataJSON is not true for false.");
              }
          }
        setValue(the_bool);
      }


    public StoredAlwaysMatchReadDataJSON()
      {
        flagHasValue = false;
      }

    public StoredAlwaysMatchReadDataJSON(bool init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public bool  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void setValue(bool new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.boolean_value(storeValue);
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.boolean_value(storeValue);
      }

    public static StoredAlwaysMatchReadDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StoredAlwaysMatchReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredAlwaysMatchReadData", ignore_extras);
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
    public static StoredAlwaysMatchReadDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StoredAlwaysMatchReadDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StoredAlwaysMatchReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredAlwaysMatchReadData", ignore_extras);
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
    public static StoredAlwaysMatchReadDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static StoredAlwaysMatchReadDataJSON from_text(string text, bool ignore_extras)
      {
        StoredAlwaysMatchReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredAlwaysMatchReadData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StoredAlwaysMatchReadDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static StoredAlwaysMatchReadDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StoredAlwaysMatchReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredAlwaysMatchReadData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONBooleanGenerator
      {
        protected override void handle_result(bool new_value)
          {
            StoredAlwaysMatchReadDataJSON result = new StoredAlwaysMatchReadDataJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(StoredAlwaysMatchReadDataJSON new_result);
        public Generator(bool ignore_extras) : base("Type StoredAlwaysMatchReadData")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(StoredAlwaysMatchReadDataJSON  result)
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
        public StoredAlwaysMatchReadDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StoredAlwaysMatchReadDataJSON  result)
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
    protected virtual void handle_result(List<StoredAlwaysMatchReadDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StoredAlwaysMatchReadDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StoredAlwaysMatchReadDataJSON>();
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
    public List<StoredAlwaysMatchReadDataJSON> value;
  };
  };
