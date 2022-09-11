/* file "BaseConverterQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BaseConverterQueryStateJSON : JSONBase
  {
    private bool flagHasBases;
    private List< string > storeBases;


    private void  fromJSONBases(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Bases of BaseConverterQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Bases1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Bases of BaseConverterQueryStateJSON is not a string.");
            vector_Bases1.Add(json_string.getData());
          }
        initBases();
        for (int num1 = 0; num1 < vector_Bases1.Count; ++num1)
            appendBases(vector_Bases1[num1]);
        for (int num1 = 0; num1 < vector_Bases1.Count; ++num1)
          {
          }
      }


    public BaseConverterQueryStateJSON()
      {
        flagHasBases = false;
        storeBases = new List< string >();
      }

    public bool  hasBases()
      {
        return flagHasBases;
      }

    public int  countOfBases()
      {
        Debug.Assert(flagHasBases);
        return storeBases.Count;
      }

    public string  elementOfBases(int element_num)
      {
        Debug.Assert(flagHasBases);
        return storeBases[element_num];
      }

    public List< string >  getBases()
      {
        Debug.Assert(flagHasBases);
        return storeBases;
      }



    public void initBases()
      {
        flagHasBases = true;
        storeBases.Clear();
      }
    public void appendBases(string to_append)
      {
        if (!flagHasBases)
          {
            flagHasBases = true;
            storeBases.Clear();
          }
        Debug.Assert(flagHasBases);
        storeBases.Add(to_append);
      }
    public void unsetBases()
      {
        flagHasBases = false;
        storeBases.Clear();
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
        Debug.Assert(partial_allowed || flagHasBases);
        if (flagHasBases)
          {
            handler.start_pair("Bases");
            handler.start_array();
            for (int num1 = 0; num1 < storeBases.Count; ++num1)
              {
                handler.string_value(storeBases[num1]);
              }
            handler.finish_array();
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
        if (!(hasBases()))
          {
            return "When parsing the object for %what%, the \"Bases\" field was missing.";
          }
        return null;
      }

    public static BaseConverterQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BaseConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BaseConverterQueryState", ignore_extras);
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
    public static BaseConverterQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BaseConverterQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BaseConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BaseConverterQueryState", ignore_extras);
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
    public static BaseConverterQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BaseConverterQueryStateJSON from_text(string text, bool ignore_extras)
      {
        BaseConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BaseConverterQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BaseConverterQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BaseConverterQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BaseConverterQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BaseConverterQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorBases;

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
            BaseConverterQueryStateJSON result = new BaseConverterQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(BaseConverterQueryStateJSON result)
          {
            if (fieldGeneratorBases.have_value)
              {
                result.initBases();
                int count = fieldGeneratorBases.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBases(fieldGeneratorBases.value[num]);
                  }
                fieldGeneratorBases.value.Clear();
                fieldGeneratorBases.have_value = false;
              }
            else if ((!(result.hasBases())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Bases\" field was missing.");
              }
          }
        protected abstract void handle_result(BaseConverterQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Bases", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorBases;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorBases = new JSONHoldingStringArrayGenerator("field \"Bases\" of the BaseConverterQueryState class");
            set_what("the BaseConverterQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorBases = new JSONHoldingStringArrayGenerator("field \"Bases\" of the BaseConverterQueryState class");
            set_what("the BaseConverterQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorBases.reset();
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
        protected override void handle_result(BaseConverterQueryStateJSON  result)
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
        public BaseConverterQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BaseConverterQueryStateJSON  result)
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
    protected virtual void handle_result(List<BaseConverterQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BaseConverterQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BaseConverterQueryStateJSON>();
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
    public List<BaseConverterQueryStateJSON> value;
  };
  };
