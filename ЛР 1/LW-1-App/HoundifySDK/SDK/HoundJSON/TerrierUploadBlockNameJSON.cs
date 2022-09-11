/* file "TerrierUploadBlockNameJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


public class TerrierUploadBlockNameJSON : JSONBase
  {
    public static Regex expressionValue = new Regex("^[a-zA-Z_]([a-zA-Z_0-9]*)$");
    private bool flagHasValue;
    private string storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of TerrierUploadBlockNameJSON is not a string.");
        setValue(json_string.getData());
      }


    public TerrierUploadBlockNameJSON()
      {
        flagHasValue = false;
      }

    public TerrierUploadBlockNameJSON(string init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public string  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void setValue(string new_value)
      {
        flagHasValue = true;
        if (!expressionValue.IsMatch(new_value))
            throw new Exception("The value is not in the regular expression for field Value of TerrierUploadBlockNameJSON.");
        storeValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.string_value(storeValue);
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.string_value(storeValue);
      }

    public static TerrierUploadBlockNameJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadBlockNameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlockName", ignore_extras);
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
    public static TerrierUploadBlockNameJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadBlockNameJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadBlockNameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlockName", ignore_extras);
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
    public static TerrierUploadBlockNameJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadBlockNameJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadBlockNameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlockName", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadBlockNameJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadBlockNameJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadBlockNameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlockName", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        private Regex checker;
        protected FieldGeneratorValue()  { checker = new Regex("^[a-zA-Z_]([a-zA-Z_0-9]*)$"); }
        protected FieldGeneratorValue(string  what) : base(what) { checker = new Regex("^[a-zA-Z_]([a-zA-Z_0-9]*)$"); }
        protected void validate(string result)
          {
            if (!(checker.IsMatch(result)))
                error("The string for %what% doesn't match the required pattern @^[a-zA-Z_]([a-zA-Z_0-9]*)$@.");
          }
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(string result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public string value;
  };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(string result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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
    protected virtual void handle_result(List<string> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<string> value;
  };
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(string  new_value)
          {
            TerrierUploadBlockNameJSON result = new TerrierUploadBlockNameJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(TerrierUploadBlockNameJSON new_result);
        public Generator(bool ignore_extras) : base("Type TerrierUploadBlockName")
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
        protected override void handle_result(TerrierUploadBlockNameJSON  result)
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
        public TerrierUploadBlockNameJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadBlockNameJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadBlockNameJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadBlockNameJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadBlockNameJSON>();
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
    public List<TerrierUploadBlockNameJSON> value;
  };
  };
