/* file "GeonameAttributeWithArgumentsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class GeonameAttributeWithArgumentsJSON : JSONBase
  {
    private bool flagHasAttributeID;
    private BigInteger storeAttributeID;
    private bool flagHasArguments;
    private List< GeonameAttributeArgumentJSON  > storeArguments;


    private void  fromJSONAttributeID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AttributeID of GeonameAttributeWithArgumentsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AttributeID of GeonameAttributeWithArgumentsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAttributeID(extracted_integer);
      }


    private void  fromJSONArguments(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Arguments of GeonameAttributeWithArgumentsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< GeonameAttributeArgumentJSON  > vector_Arguments1 = new List< GeonameAttributeArgumentJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            GeonameAttributeArgumentJSON convert_classy = GeonameAttributeArgumentJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Arguments1.Add(convert_classy);
          }
        initArguments();
        for (int num1 = 0; num1 < vector_Arguments1.Count; ++num1)
            appendArguments(vector_Arguments1[num1]);
        for (int num1 = 0; num1 < vector_Arguments1.Count; ++num1)
          {
          }
      }


    public GeonameAttributeWithArgumentsJSON()
      {
        flagHasAttributeID = false;
        flagHasArguments = false;
        storeArguments = new List< GeonameAttributeArgumentJSON  >();
      }

    public bool  hasAttributeID()
      {
        return flagHasAttributeID;
      }

    public BigInteger  getAttributeID()
      {
        Debug.Assert(flagHasAttributeID);
        return storeAttributeID;
      }

    public bool  hasArguments()
      {
        return flagHasArguments;
      }

    public int  countOfArguments()
      {
        Debug.Assert(flagHasArguments);
        return storeArguments.Count;
      }

    public GeonameAttributeArgumentJSON   elementOfArguments(int element_num)
      {
        Debug.Assert(flagHasArguments);
        return storeArguments[element_num];
      }

    public List< GeonameAttributeArgumentJSON  >  getArguments()
      {
        Debug.Assert(flagHasArguments);
        return storeArguments;
      }



    public void setAttributeID(BigInteger new_value)
      {
        flagHasAttributeID = true;
        if (new_value < 1)
            throw new Exception("The value for field AttributeID of GeonameAttributeWithArgumentsJSON is less than the lower bound (1) for that field.");
        storeAttributeID = new_value;
      }
    public void unsetAttributeID()
      {
        flagHasAttributeID = false;
      }
    public void initArguments()
      {
        if (flagHasArguments)
          {
            for (int num1 = 0; num1 < storeArguments.Count; ++num1)
              {
              }
          }
        flagHasArguments = true;
        storeArguments.Clear();
      }
    public void appendArguments(GeonameAttributeArgumentJSON  to_append)
      {
        if (!flagHasArguments)
          {
            flagHasArguments = true;
            storeArguments.Clear();
          }
        Debug.Assert(flagHasArguments);
        storeArguments.Add(to_append);
      }
    public void unsetArguments()
      {
        if (flagHasArguments)
          {
            for (int num2 = 0; num2 < storeArguments.Count; ++num2)
              {
              }
          }
        flagHasArguments = false;
        storeArguments.Clear();
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
        Debug.Assert(partial_allowed || flagHasAttributeID);
        if (flagHasAttributeID)
          {
            handler.start_pair("AttributeID");
            handler.number_value(storeAttributeID);
          }
        if (flagHasArguments)
          {
            handler.start_pair("Arguments");
            handler.start_array();
            for (int num1 = 0; num1 < storeArguments.Count; ++num1)
              {
                if (partial_allowed)
                    storeArguments[num1].write_partial_as_json(handler);
                else
                    storeArguments[num1].write_as_json(handler);
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
        if (!(hasAttributeID()))
          {
            return "When parsing the object for %what%, the \"AttributeID\" field was missing.";
          }
        return null;
      }

    public static GeonameAttributeWithArgumentsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameAttributeWithArgumentsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttributeWithArguments", ignore_extras);
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
    public static GeonameAttributeWithArgumentsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeonameAttributeWithArgumentsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameAttributeWithArgumentsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttributeWithArguments", ignore_extras);
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
    public static GeonameAttributeWithArgumentsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeonameAttributeWithArgumentsJSON from_text(string text, bool ignore_extras)
      {
        GeonameAttributeWithArgumentsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttributeWithArguments", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeonameAttributeWithArgumentsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static GeonameAttributeWithArgumentsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeonameAttributeWithArgumentsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttributeWithArguments", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorAttributeID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorAttributeID(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorAttributeID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorAttributeID(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorAttributeID fieldGeneratorAttributeID;
        private GeonameAttributeArgumentJSON.HoldingArrayGenerator fieldGeneratorArguments;

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
            GeonameAttributeWithArgumentsJSON result = new GeonameAttributeWithArgumentsJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(GeonameAttributeWithArgumentsJSON result)
          {
            if (fieldGeneratorAttributeID.have_value)
              {
                result.setAttributeID(fieldGeneratorAttributeID.value);
                fieldGeneratorAttributeID.have_value = false;
              }
            else if ((!(result.hasAttributeID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AttributeID\" field was missing.");
              }
            if (fieldGeneratorArguments.have_value)
              {
                result.initArguments();
                int count = fieldGeneratorArguments.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendArguments(fieldGeneratorArguments.value[num]);
                  }
                fieldGeneratorArguments.value.Clear();
                fieldGeneratorArguments.have_value = false;
              }
          }
        protected abstract void handle_result(GeonameAttributeWithArgumentsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "A", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'r':
                        if ((String.Compare(field_name, 2, "guments", 0, 7, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorArguments;
                        break;
                    case 't':
                        if ((String.Compare(field_name, 2, "tributeID", 0, 9, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorAttributeID;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAttributeID = new FieldHoldingGeneratorAttributeID("field \"AttributeID\" of the GeonameAttributeWithArguments class");
            fieldGeneratorArguments = new GeonameAttributeArgumentJSON.HoldingArrayGenerator("field \"Arguments\" of the GeonameAttributeWithArguments class", ignore_extras);
            set_what("the GeonameAttributeWithArguments class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAttributeID = new FieldHoldingGeneratorAttributeID("field \"AttributeID\" of the GeonameAttributeWithArguments class");
            fieldGeneratorArguments = new GeonameAttributeArgumentJSON.HoldingArrayGenerator("field \"Arguments\" of the GeonameAttributeWithArguments class", false);
            set_what("the GeonameAttributeWithArguments class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAttributeID.reset();
            fieldGeneratorArguments.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorArguments.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorArguments.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(GeonameAttributeWithArgumentsJSON  result)
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
        public GeonameAttributeWithArgumentsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeonameAttributeWithArgumentsJSON  result)
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
    protected virtual void handle_result(List<GeonameAttributeWithArgumentsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeonameAttributeWithArgumentsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeonameAttributeWithArgumentsJSON>();
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
    public List<GeonameAttributeWithArgumentsJSON> value;
  };
  };
