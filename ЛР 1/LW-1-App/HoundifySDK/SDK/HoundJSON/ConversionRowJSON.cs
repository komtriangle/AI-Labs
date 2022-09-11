/* file "ConversionRowJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ConversionRowJSON : JSONBase
  {
    private bool flagHasStringToConvert;
    private string storeStringToConvert;
    private bool flagHasInputBaseSmallName;
    private string storeInputBaseSmallName;
    private bool flagHasInputBaseFullName;
    private string storeInputBaseFullName;
    private bool flagHasBaseSmallName;
    private string storeBaseSmallName;
    private bool flagHasBaseFullName;
    private string storeBaseFullName;
    private bool flagHasConvertedNumber;
    private string storeConvertedNumber;
    private bool flagHasConvertedNumberSpoken;
    private string storeConvertedNumberSpoken;


    private void  fromJSONStringToConvert(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StringToConvert of ConversionRowJSON is not a string.");
        setStringToConvert(json_string.getData());
      }


    private void  fromJSONInputBaseSmallName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InputBaseSmallName of ConversionRowJSON is not a string.");
        setInputBaseSmallName(json_string.getData());
      }


    private void  fromJSONInputBaseFullName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InputBaseFullName of ConversionRowJSON is not a string.");
        setInputBaseFullName(json_string.getData());
      }


    private void  fromJSONBaseSmallName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BaseSmallName of ConversionRowJSON is not a string.");
        setBaseSmallName(json_string.getData());
      }


    private void  fromJSONBaseFullName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BaseFullName of ConversionRowJSON is not a string.");
        setBaseFullName(json_string.getData());
      }


    private void  fromJSONConvertedNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConvertedNumber of ConversionRowJSON is not a string.");
        setConvertedNumber(json_string.getData());
      }


    private void  fromJSONConvertedNumberSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConvertedNumberSpoken of ConversionRowJSON is not a string.");
        setConvertedNumberSpoken(json_string.getData());
      }


    public ConversionRowJSON()
      {
        flagHasStringToConvert = false;
        flagHasInputBaseSmallName = false;
        flagHasInputBaseFullName = false;
        flagHasBaseSmallName = false;
        flagHasBaseFullName = false;
        flagHasConvertedNumber = false;
        flagHasConvertedNumberSpoken = false;
      }

    public bool  hasStringToConvert()
      {
        return flagHasStringToConvert;
      }

    public string  getStringToConvert()
      {
        Debug.Assert(flagHasStringToConvert);
        return storeStringToConvert;
      }

    public bool  hasInputBaseSmallName()
      {
        return flagHasInputBaseSmallName;
      }

    public string  getInputBaseSmallName()
      {
        Debug.Assert(flagHasInputBaseSmallName);
        return storeInputBaseSmallName;
      }

    public bool  hasInputBaseFullName()
      {
        return flagHasInputBaseFullName;
      }

    public string  getInputBaseFullName()
      {
        Debug.Assert(flagHasInputBaseFullName);
        return storeInputBaseFullName;
      }

    public bool  hasBaseSmallName()
      {
        return flagHasBaseSmallName;
      }

    public string  getBaseSmallName()
      {
        Debug.Assert(flagHasBaseSmallName);
        return storeBaseSmallName;
      }

    public bool  hasBaseFullName()
      {
        return flagHasBaseFullName;
      }

    public string  getBaseFullName()
      {
        Debug.Assert(flagHasBaseFullName);
        return storeBaseFullName;
      }

    public bool  hasConvertedNumber()
      {
        return flagHasConvertedNumber;
      }

    public string  getConvertedNumber()
      {
        Debug.Assert(flagHasConvertedNumber);
        return storeConvertedNumber;
      }

    public bool  hasConvertedNumberSpoken()
      {
        return flagHasConvertedNumberSpoken;
      }

    public string  getConvertedNumberSpoken()
      {
        Debug.Assert(flagHasConvertedNumberSpoken);
        return storeConvertedNumberSpoken;
      }



    public void setStringToConvert(string new_value)
      {
        flagHasStringToConvert = true;
        storeStringToConvert = new_value;
      }
    public void unsetStringToConvert()
      {
        flagHasStringToConvert = false;
      }
    public void setInputBaseSmallName(string new_value)
      {
        flagHasInputBaseSmallName = true;
        storeInputBaseSmallName = new_value;
      }
    public void unsetInputBaseSmallName()
      {
        flagHasInputBaseSmallName = false;
      }
    public void setInputBaseFullName(string new_value)
      {
        flagHasInputBaseFullName = true;
        storeInputBaseFullName = new_value;
      }
    public void unsetInputBaseFullName()
      {
        flagHasInputBaseFullName = false;
      }
    public void setBaseSmallName(string new_value)
      {
        flagHasBaseSmallName = true;
        storeBaseSmallName = new_value;
      }
    public void unsetBaseSmallName()
      {
        flagHasBaseSmallName = false;
      }
    public void setBaseFullName(string new_value)
      {
        flagHasBaseFullName = true;
        storeBaseFullName = new_value;
      }
    public void unsetBaseFullName()
      {
        flagHasBaseFullName = false;
      }
    public void setConvertedNumber(string new_value)
      {
        flagHasConvertedNumber = true;
        storeConvertedNumber = new_value;
      }
    public void unsetConvertedNumber()
      {
        flagHasConvertedNumber = false;
      }
    public void setConvertedNumberSpoken(string new_value)
      {
        flagHasConvertedNumberSpoken = true;
        storeConvertedNumberSpoken = new_value;
      }
    public void unsetConvertedNumberSpoken()
      {
        flagHasConvertedNumberSpoken = false;
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
        Debug.Assert(partial_allowed || flagHasStringToConvert);
        if (flagHasStringToConvert)
          {
            handler.start_pair("StringToConvert");
            handler.string_value(storeStringToConvert);
          }
        Debug.Assert(partial_allowed || flagHasInputBaseSmallName);
        if (flagHasInputBaseSmallName)
          {
            handler.start_pair("InputBaseSmallName");
            handler.string_value(storeInputBaseSmallName);
          }
        Debug.Assert(partial_allowed || flagHasInputBaseFullName);
        if (flagHasInputBaseFullName)
          {
            handler.start_pair("InputBaseFullName");
            handler.string_value(storeInputBaseFullName);
          }
        Debug.Assert(partial_allowed || flagHasBaseSmallName);
        if (flagHasBaseSmallName)
          {
            handler.start_pair("BaseSmallName");
            handler.string_value(storeBaseSmallName);
          }
        Debug.Assert(partial_allowed || flagHasBaseFullName);
        if (flagHasBaseFullName)
          {
            handler.start_pair("BaseFullName");
            handler.string_value(storeBaseFullName);
          }
        Debug.Assert(partial_allowed || flagHasConvertedNumber);
        if (flagHasConvertedNumber)
          {
            handler.start_pair("ConvertedNumber");
            handler.string_value(storeConvertedNumber);
          }
        Debug.Assert(partial_allowed || flagHasConvertedNumberSpoken);
        if (flagHasConvertedNumberSpoken)
          {
            handler.start_pair("ConvertedNumberSpoken");
            handler.string_value(storeConvertedNumberSpoken);
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
        if (!(hasStringToConvert()))
          {
            return "When parsing the object for %what%, the \"StringToConvert\" field was missing.";
          }
        if (!(hasInputBaseSmallName()))
          {
            return "When parsing the object for %what%, the \"InputBaseSmallName\" field was missing.";
          }
        if (!(hasInputBaseFullName()))
          {
            return "When parsing the object for %what%, the \"InputBaseFullName\" field was missing.";
          }
        if (!(hasBaseSmallName()))
          {
            return "When parsing the object for %what%, the \"BaseSmallName\" field was missing.";
          }
        if (!(hasBaseFullName()))
          {
            return "When parsing the object for %what%, the \"BaseFullName\" field was missing.";
          }
        if (!(hasConvertedNumber()))
          {
            return "When parsing the object for %what%, the \"ConvertedNumber\" field was missing.";
          }
        if (!(hasConvertedNumberSpoken()))
          {
            return "When parsing the object for %what%, the \"ConvertedNumberSpoken\" field was missing.";
          }
        return null;
      }

    public static ConversionRowJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ConversionRowJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ConversionRow", ignore_extras);
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
    public static ConversionRowJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ConversionRowJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ConversionRowJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ConversionRow", ignore_extras);
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
    public static ConversionRowJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ConversionRowJSON from_text(string text, bool ignore_extras)
      {
        ConversionRowJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ConversionRow", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ConversionRowJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ConversionRowJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ConversionRowJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ConversionRow", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorStringToConvert;
        private JSONHoldingStringGenerator fieldGeneratorInputBaseSmallName;
        private JSONHoldingStringGenerator fieldGeneratorInputBaseFullName;
        private JSONHoldingStringGenerator fieldGeneratorBaseSmallName;
        private JSONHoldingStringGenerator fieldGeneratorBaseFullName;
        private JSONHoldingStringGenerator fieldGeneratorConvertedNumber;
        private JSONHoldingStringGenerator fieldGeneratorConvertedNumberSpoken;

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
            ConversionRowJSON result = new ConversionRowJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(ConversionRowJSON result)
          {
            if (fieldGeneratorStringToConvert.have_value)
              {
                result.setStringToConvert(fieldGeneratorStringToConvert.value);
                fieldGeneratorStringToConvert.have_value = false;
              }
            else if ((!(result.hasStringToConvert())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StringToConvert\" field was missing.");
              }
            if (fieldGeneratorInputBaseSmallName.have_value)
              {
                result.setInputBaseSmallName(fieldGeneratorInputBaseSmallName.value);
                fieldGeneratorInputBaseSmallName.have_value = false;
              }
            else if ((!(result.hasInputBaseSmallName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InputBaseSmallName\" field was missing.");
              }
            if (fieldGeneratorInputBaseFullName.have_value)
              {
                result.setInputBaseFullName(fieldGeneratorInputBaseFullName.value);
                fieldGeneratorInputBaseFullName.have_value = false;
              }
            else if ((!(result.hasInputBaseFullName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InputBaseFullName\" field was missing.");
              }
            if (fieldGeneratorBaseSmallName.have_value)
              {
                result.setBaseSmallName(fieldGeneratorBaseSmallName.value);
                fieldGeneratorBaseSmallName.have_value = false;
              }
            else if ((!(result.hasBaseSmallName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"BaseSmallName\" field was missing.");
              }
            if (fieldGeneratorBaseFullName.have_value)
              {
                result.setBaseFullName(fieldGeneratorBaseFullName.value);
                fieldGeneratorBaseFullName.have_value = false;
              }
            else if ((!(result.hasBaseFullName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"BaseFullName\" field was missing.");
              }
            if (fieldGeneratorConvertedNumber.have_value)
              {
                result.setConvertedNumber(fieldGeneratorConvertedNumber.value);
                fieldGeneratorConvertedNumber.have_value = false;
              }
            else if ((!(result.hasConvertedNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ConvertedNumber\" field was missing.");
              }
            if (fieldGeneratorConvertedNumberSpoken.have_value)
              {
                result.setConvertedNumberSpoken(fieldGeneratorConvertedNumberSpoken.value);
                fieldGeneratorConvertedNumberSpoken.have_value = false;
              }
            else if ((!(result.hasConvertedNumberSpoken())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ConvertedNumberSpoken\" field was missing.");
              }
          }
        protected abstract void handle_result(ConversionRowJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if (String.Compare(field_name, 1, "ase", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 5, "ullName", 0, 7, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorBaseFullName;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 5, "mallName", 0, 8, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorBaseSmallName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'C':
                    if (String.Compare(field_name, 1, "onvertedNumber", 0, 14, false) == 0)
                      {
                        if (field_name.Length == 15)
                          {
                            return fieldGeneratorConvertedNumber;
                          }
                        switch (field_name[15])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 16, "poken", 0, 5, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorConvertedNumberSpoken;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "nputBase", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 10, "ullName", 0, 7, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorInputBaseFullName;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 10, "mallName", 0, 8, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorInputBaseSmallName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tringToConvert", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorStringToConvert;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStringToConvert = new JSONHoldingStringGenerator("field \"StringToConvert\" of the ConversionRow class");
            fieldGeneratorInputBaseSmallName = new JSONHoldingStringGenerator("field \"InputBaseSmallName\" of the ConversionRow class");
            fieldGeneratorInputBaseFullName = new JSONHoldingStringGenerator("field \"InputBaseFullName\" of the ConversionRow class");
            fieldGeneratorBaseSmallName = new JSONHoldingStringGenerator("field \"BaseSmallName\" of the ConversionRow class");
            fieldGeneratorBaseFullName = new JSONHoldingStringGenerator("field \"BaseFullName\" of the ConversionRow class");
            fieldGeneratorConvertedNumber = new JSONHoldingStringGenerator("field \"ConvertedNumber\" of the ConversionRow class");
            fieldGeneratorConvertedNumberSpoken = new JSONHoldingStringGenerator("field \"ConvertedNumberSpoken\" of the ConversionRow class");
            set_what("the ConversionRow class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStringToConvert = new JSONHoldingStringGenerator("field \"StringToConvert\" of the ConversionRow class");
            fieldGeneratorInputBaseSmallName = new JSONHoldingStringGenerator("field \"InputBaseSmallName\" of the ConversionRow class");
            fieldGeneratorInputBaseFullName = new JSONHoldingStringGenerator("field \"InputBaseFullName\" of the ConversionRow class");
            fieldGeneratorBaseSmallName = new JSONHoldingStringGenerator("field \"BaseSmallName\" of the ConversionRow class");
            fieldGeneratorBaseFullName = new JSONHoldingStringGenerator("field \"BaseFullName\" of the ConversionRow class");
            fieldGeneratorConvertedNumber = new JSONHoldingStringGenerator("field \"ConvertedNumber\" of the ConversionRow class");
            fieldGeneratorConvertedNumberSpoken = new JSONHoldingStringGenerator("field \"ConvertedNumberSpoken\" of the ConversionRow class");
            set_what("the ConversionRow class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStringToConvert.reset();
            fieldGeneratorInputBaseSmallName.reset();
            fieldGeneratorInputBaseFullName.reset();
            fieldGeneratorBaseSmallName.reset();
            fieldGeneratorBaseFullName.reset();
            fieldGeneratorConvertedNumber.reset();
            fieldGeneratorConvertedNumberSpoken.reset();
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
        protected override void handle_result(ConversionRowJSON  result)
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
        public ConversionRowJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ConversionRowJSON  result)
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
    protected virtual void handle_result(List<ConversionRowJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ConversionRowJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ConversionRowJSON>();
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
    public List<ConversionRowJSON> value;
  };
  };
