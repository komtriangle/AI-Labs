/* file "PersonAttributeSiblingsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PersonAttributeSiblingsJSON : PersonAttributePersonArrayJSON
  {
    private bool flagHasParameters;
    private PersonAttributeSiblingsParametersJSON  storeParameters;


    private JSONValue  extraParametersToJSON()
      {
        JSONValueHandler handler_Parameters = new JSONValueHandler();
        storeParameters.write_as_json(handler_Parameters);
        return handler_Parameters.result;
      }


    private void  fromJSONParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PersonAttributeSiblingsParametersJSON convert_classy = PersonAttributeSiblingsParametersJSON.from_json(json_value, ignore_extras, true);
        setParameters(convert_classy);
      }


    public PersonAttributeSiblingsJSON()
      {
        flagHasParameters = false;
      }

    public override string  getPersonAttribute()
      {
        return "Siblings";
      }

    public bool  hasParameters()
      {
        return flagHasParameters;
      }

    public PersonAttributeSiblingsParametersJSON   getParameters()
      {
        Debug.Assert(flagHasParameters);
        return storeParameters;
      }


    public override int extraPersonAttributePersonArrayComponentCount()
      {
        int result = 0;
        if (flagHasParameters)
            ++result;
        return result;
      }
    public override string extraPersonAttributePersonArrayComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasParameters)
          {
            if (remainder == 0)
                return "Parameters";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraPersonAttributePersonArrayComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasParameters)
          {
            if (remainder == 0)
                return extraParametersToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraPersonAttributePersonArrayLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Parameters", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasParameters ? extraParametersToJSON() : null);
        return null;
      }

    public void setParameters(PersonAttributeSiblingsParametersJSON  new_value)
      {
        if (flagHasParameters)
          {
          }
        flagHasParameters = true;
        storeParameters = new_value;
      }
    public void unsetParameters()
      {
        if (flagHasParameters)
          {
          }
        flagHasParameters = false;
      }

    public override void extraPersonAttributePersonArrayAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Parameters", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONParameters(new_component, false);
            return;
            }
      }
    public override void extraPersonAttributePersonArraySetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Parameters", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONParameters(new_component, false);
            return;
            }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasParameters)
          {
            handler.start_pair("Parameters");
            if (partial_allowed)
                storeParameters.write_partial_as_json(handler);
            else
                storeParameters.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new PersonAttributeSiblingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeSiblingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSiblings", ignore_extras);
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
    public static new PersonAttributeSiblingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonAttributeSiblingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeSiblingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSiblings", ignore_extras);
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
    public static new PersonAttributeSiblingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonAttributeSiblingsJSON from_text(string text, bool ignore_extras)
      {
        PersonAttributeSiblingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSiblings", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonAttributeSiblingsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PersonAttributeSiblingsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonAttributeSiblingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSiblings", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PersonAttributePersonArrayJSON.Generator
      {
        private PersonAttributeSiblingsParametersJSON.HoldingGenerator fieldGeneratorParameters;

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
            if (!(getPersonAttributePersonArrayJSONKey().Equals("Siblings")))
                throw new Exception("The key field has a value other than `Siblings'.");
            PersonAttributeSiblingsJSON result = new PersonAttributeSiblingsJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(PersonAttributePersonArrayJSON new_result)
          {
            handle_result((PersonAttributeSiblingsJSON )new_result);
          }
        protected void finish(PersonAttributeSiblingsJSON result)
          {
            if (fieldGeneratorParameters.have_value)
              {
                result.setParameters(fieldGeneratorParameters.value);
                fieldGeneratorParameters.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(PersonAttributeSiblingsJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Parameters", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorParameters;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorParameters = new PersonAttributeSiblingsParametersJSON.HoldingGenerator("field \"Parameters\" of the PersonAttributeSiblings class", ignore_extras);
            set_what("the PersonAttributeSiblings class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorParameters = new PersonAttributeSiblingsParametersJSON.HoldingGenerator("field \"Parameters\" of the PersonAttributeSiblings class", false);
            set_what("the PersonAttributeSiblings class");
          }

        public override void reset()
          {
            fieldGeneratorParameters.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonAttributeSiblingsJSON  result)
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
        public PersonAttributeSiblingsJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonAttributeSiblingsJSON  result)
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
    protected virtual void handle_result(List<PersonAttributeSiblingsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonAttributeSiblingsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonAttributeSiblingsJSON>();
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
    public List<PersonAttributeSiblingsJSON> value;
  };
  };
