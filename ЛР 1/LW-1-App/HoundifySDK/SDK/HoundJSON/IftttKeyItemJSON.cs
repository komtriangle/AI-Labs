/* file "IftttKeyItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class IftttKeyItemJSON : JSONBase
  {
    private bool flagHasKey;
    private string storeKey;


    private void  fromJSONKey(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Key of IftttKeyItemJSON is not a string.");
        setKey(json_string.getData());
      }


    public IftttKeyItemJSON()
      {
        flagHasKey = false;
      }

    public bool  hasKey()
      {
        return flagHasKey;
      }

    public string  getKey()
      {
        Debug.Assert(flagHasKey);
        return storeKey;
      }



    public void setKey(string new_value)
      {
        flagHasKey = true;
        storeKey = new_value;
      }
    public void unsetKey()
      {
        flagHasKey = false;
      }


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
        Debug.Assert(partial_allowed || flagHasKey);
        if (flagHasKey)
          {
            handler.start_pair("Key");
            handler.string_value(storeKey);
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
        if (!(hasKey()))
          {
            return "When parsing the object for %what%, the \"Key\" field was missing.";
          }
        return null;
      }

    public static IftttKeyItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IftttKeyItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IftttKeyItem", ignore_extras);
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
    public static IftttKeyItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IftttKeyItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IftttKeyItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IftttKeyItem", ignore_extras);
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
    public static IftttKeyItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IftttKeyItemJSON from_text(string text, bool ignore_extras)
      {
        IftttKeyItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IftttKeyItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IftttKeyItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IftttKeyItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IftttKeyItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IftttKeyItem", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorKey;

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
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            IftttKeyItemJSON result = new IftttKeyItemJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(IftttKeyItemJSON result)
          {
            if (fieldGeneratorKey.have_value)
              {
                result.setKey(fieldGeneratorKey.value);
                fieldGeneratorKey.have_value = false;
              }
            else if ((!(result.hasKey())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Key\" field was missing.");
              }
          }
        protected abstract void handle_result(IftttKeyItemJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Key", 0, 3, false) == 0) && (field_name.Length == 3))
                return fieldGeneratorKey;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorKey = new JSONHoldingStringGenerator("field \"Key\" of the IftttKeyItem class");
            set_what("the IftttKeyItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorKey = new JSONHoldingStringGenerator("field \"Key\" of the IftttKeyItem class");
            set_what("the IftttKeyItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorKey.reset();
            base.reset();
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
        protected override void handle_result(IftttKeyItemJSON  result)
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
        public IftttKeyItemJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IftttKeyItemJSON  result)
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
    protected virtual void handle_result(List<IftttKeyItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IftttKeyItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IftttKeyItemJSON>();
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
    public List<IftttKeyItemJSON> value;
  };
  };
