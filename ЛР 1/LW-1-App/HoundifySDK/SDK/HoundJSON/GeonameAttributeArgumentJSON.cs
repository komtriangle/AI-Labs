/* file "GeonameAttributeArgumentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GeonameAttributeArgumentJSON : JSONBase
  {
    private bool flagHasAreaUnit;
    private string storeAreaUnit;
    private bool flagHasUnitOfMeasure;
    private string storeUnitOfMeasure;
    private bool flagHasIsOfficial;
    private bool storeIsOfficial;
    private bool flagHasDateTimeRangeSpec;
    private DateTimeRangeSpecJSON  storeDateTimeRangeSpec;


    private void  fromJSONAreaUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AreaUnit of GeonameAttributeArgumentJSON is not a string.");
        setAreaUnit(json_string.getData());
      }


    private void  fromJSONUnitOfMeasure(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UnitOfMeasure of GeonameAttributeArgumentJSON is not a string.");
        setUnitOfMeasure(json_string.getData());
      }


    private void  fromJSONIsOfficial(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsOfficial of GeonameAttributeArgumentJSON is not true for false.");
              }
          }
        setIsOfficial(the_bool);
      }


    private void  fromJSONDateTimeRangeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateTimeRangeSpec(convert_classy);
      }


    public GeonameAttributeArgumentJSON()
      {
        flagHasAreaUnit = false;
        flagHasUnitOfMeasure = false;
        flagHasIsOfficial = false;
        flagHasDateTimeRangeSpec = false;
      }

    public bool  hasAreaUnit()
      {
        return flagHasAreaUnit;
      }

    public string  getAreaUnit()
      {
        Debug.Assert(flagHasAreaUnit);
        return storeAreaUnit;
      }

    public bool  hasUnitOfMeasure()
      {
        return flagHasUnitOfMeasure;
      }

    public string  getUnitOfMeasure()
      {
        Debug.Assert(flagHasUnitOfMeasure);
        return storeUnitOfMeasure;
      }

    public bool  hasIsOfficial()
      {
        return flagHasIsOfficial;
      }

    public bool  getIsOfficial()
      {
        Debug.Assert(flagHasIsOfficial);
        return storeIsOfficial;
      }

    public bool  hasDateTimeRangeSpec()
      {
        return flagHasDateTimeRangeSpec;
      }

    public DateTimeRangeSpecJSON   getDateTimeRangeSpec()
      {
        Debug.Assert(flagHasDateTimeRangeSpec);
        return storeDateTimeRangeSpec;
      }



    public void setAreaUnit(string new_value)
      {
        flagHasAreaUnit = true;
        storeAreaUnit = new_value;
      }
    public void unsetAreaUnit()
      {
        flagHasAreaUnit = false;
      }
    public void setUnitOfMeasure(string new_value)
      {
        flagHasUnitOfMeasure = true;
        storeUnitOfMeasure = new_value;
      }
    public void unsetUnitOfMeasure()
      {
        flagHasUnitOfMeasure = false;
      }
    public void setIsOfficial(bool new_value)
      {
        flagHasIsOfficial = true;
        storeIsOfficial = new_value;
      }
    public void unsetIsOfficial()
      {
        flagHasIsOfficial = false;
      }
    public void setDateTimeRangeSpec(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDateTimeRangeSpec)
          {
          }
        flagHasDateTimeRangeSpec = true;
        storeDateTimeRangeSpec = new_value;
      }
    public void unsetDateTimeRangeSpec()
      {
        if (flagHasDateTimeRangeSpec)
          {
          }
        flagHasDateTimeRangeSpec = false;
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
        if (flagHasAreaUnit)
          {
            handler.start_pair("AreaUnit");
            handler.string_value(storeAreaUnit);
          }
        if (flagHasUnitOfMeasure)
          {
            handler.start_pair("UnitOfMeasure");
            handler.string_value(storeUnitOfMeasure);
          }
        if (flagHasIsOfficial)
          {
            handler.start_pair("IsOfficial");
            handler.boolean_value(storeIsOfficial);
          }
        if (flagHasDateTimeRangeSpec)
          {
            handler.start_pair("DateTimeRangeSpec");
            if (partial_allowed)
                storeDateTimeRangeSpec.write_partial_as_json(handler);
            else
                storeDateTimeRangeSpec.write_as_json(handler);
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
        return null;
      }

    public static GeonameAttributeArgumentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameAttributeArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttributeArgument", ignore_extras);
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
    public static GeonameAttributeArgumentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeonameAttributeArgumentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameAttributeArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttributeArgument", ignore_extras);
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
    public static GeonameAttributeArgumentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeonameAttributeArgumentJSON from_text(string text, bool ignore_extras)
      {
        GeonameAttributeArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttributeArgument", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeonameAttributeArgumentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static GeonameAttributeArgumentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeonameAttributeArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttributeArgument", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorAreaUnit;
        private JSONHoldingStringGenerator fieldGeneratorUnitOfMeasure;
        private JSONHoldingBooleanGenerator fieldGeneratorIsOfficial;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateTimeRangeSpec;

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
            GeonameAttributeArgumentJSON result = new GeonameAttributeArgumentJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(GeonameAttributeArgumentJSON result)
          {
            if (fieldGeneratorAreaUnit.have_value)
              {
                result.setAreaUnit(fieldGeneratorAreaUnit.value);
                fieldGeneratorAreaUnit.have_value = false;
              }
            if (fieldGeneratorUnitOfMeasure.have_value)
              {
                result.setUnitOfMeasure(fieldGeneratorUnitOfMeasure.value);
                fieldGeneratorUnitOfMeasure.have_value = false;
              }
            if (fieldGeneratorIsOfficial.have_value)
              {
                result.setIsOfficial(fieldGeneratorIsOfficial.value);
                fieldGeneratorIsOfficial.have_value = false;
              }
            if (fieldGeneratorDateTimeRangeSpec.have_value)
              {
                result.setDateTimeRangeSpec(fieldGeneratorDateTimeRangeSpec.value);
                fieldGeneratorDateTimeRangeSpec.have_value = false;
              }
          }
        protected abstract void handle_result(GeonameAttributeArgumentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "reaUnit", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorAreaUnit;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ateTimeRangeSpec", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorDateTimeRangeSpec;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sOfficial", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorIsOfficial;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nitOfMeasure", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorUnitOfMeasure;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAreaUnit = new JSONHoldingStringGenerator("field \"AreaUnit\" of the GeonameAttributeArgument class");
            fieldGeneratorUnitOfMeasure = new JSONHoldingStringGenerator("field \"UnitOfMeasure\" of the GeonameAttributeArgument class");
            fieldGeneratorIsOfficial = new JSONHoldingBooleanGenerator("field \"IsOfficial\" of the GeonameAttributeArgument class");
            fieldGeneratorDateTimeRangeSpec = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRangeSpec\" of the GeonameAttributeArgument class", ignore_extras);
            set_what("the GeonameAttributeArgument class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAreaUnit = new JSONHoldingStringGenerator("field \"AreaUnit\" of the GeonameAttributeArgument class");
            fieldGeneratorUnitOfMeasure = new JSONHoldingStringGenerator("field \"UnitOfMeasure\" of the GeonameAttributeArgument class");
            fieldGeneratorIsOfficial = new JSONHoldingBooleanGenerator("field \"IsOfficial\" of the GeonameAttributeArgument class");
            fieldGeneratorDateTimeRangeSpec = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRangeSpec\" of the GeonameAttributeArgument class", false);
            set_what("the GeonameAttributeArgument class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAreaUnit.reset();
            fieldGeneratorUnitOfMeasure.reset();
            fieldGeneratorIsOfficial.reset();
            fieldGeneratorDateTimeRangeSpec.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDateTimeRangeSpec.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDateTimeRangeSpec.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(GeonameAttributeArgumentJSON  result)
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
        public GeonameAttributeArgumentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeonameAttributeArgumentJSON  result)
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
    protected virtual void handle_result(List<GeonameAttributeArgumentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeonameAttributeArgumentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeonameAttributeArgumentJSON>();
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
    public List<GeonameAttributeArgumentJSON> value;
  };
  };
