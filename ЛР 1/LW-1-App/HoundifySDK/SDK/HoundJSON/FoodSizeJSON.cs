/* file "FoodSizeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FoodSizeJSON : JSONBase
  {
    private bool flagHasWrittenSing;
    private string storeWrittenSing;
    private bool flagHasWrittenPlur;
    private string storeWrittenPlur;
    private bool flagHasSpokenSizeAndFoodSing;
    private string storeSpokenSizeAndFoodSing;
    private bool flagHasSpokenSizeAndFoodPlur;
    private string storeSpokenSizeAndFoodPlur;
    private bool flagHasGrams;
    private double storeGrams;
    private string textStoreGrams;


    private void  fromJSONWrittenSing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenSing of FoodSizeJSON is not a string.");
        setWrittenSing(json_string.getData());
      }


    private void  fromJSONWrittenPlur(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenPlur of FoodSizeJSON is not a string.");
        setWrittenPlur(json_string.getData());
      }


    private void  fromJSONSpokenSizeAndFoodSing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenSizeAndFoodSing of FoodSizeJSON is not a string.");
        setSpokenSizeAndFoodSing(json_string.getData());
      }


    private void  fromJSONSpokenSizeAndFoodPlur(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenSizeAndFoodPlur of FoodSizeJSON is not a string.");
        setSpokenSizeAndFoodPlur(json_string.getData());
      }


    private void  fromJSONGrams(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field Grams of FoodSizeJSON is not a number.");
              }
          }
        setGramsText(the_rational_text);
      }


    public FoodSizeJSON()
      {
        flagHasWrittenSing = false;
        flagHasWrittenPlur = false;
        flagHasSpokenSizeAndFoodSing = false;
        flagHasSpokenSizeAndFoodPlur = false;
        flagHasGrams = false;
      }

    public bool  hasWrittenSing()
      {
        return flagHasWrittenSing;
      }

    public string  getWrittenSing()
      {
        Debug.Assert(flagHasWrittenSing);
        return storeWrittenSing;
      }

    public bool  hasWrittenPlur()
      {
        return flagHasWrittenPlur;
      }

    public string  getWrittenPlur()
      {
        Debug.Assert(flagHasWrittenPlur);
        return storeWrittenPlur;
      }

    public bool  hasSpokenSizeAndFoodSing()
      {
        return flagHasSpokenSizeAndFoodSing;
      }

    public string  getSpokenSizeAndFoodSing()
      {
        Debug.Assert(flagHasSpokenSizeAndFoodSing);
        return storeSpokenSizeAndFoodSing;
      }

    public bool  hasSpokenSizeAndFoodPlur()
      {
        return flagHasSpokenSizeAndFoodPlur;
      }

    public string  getSpokenSizeAndFoodPlur()
      {
        Debug.Assert(flagHasSpokenSizeAndFoodPlur);
        return storeSpokenSizeAndFoodPlur;
      }

    public bool  hasGrams()
      {
        return flagHasGrams;
      }

    public double  getGrams()
      {
        Debug.Assert(flagHasGrams);
        if (textStoreGrams != "")
          {
            return Double.Parse(textStoreGrams);
          }
        return storeGrams;
      }

    public string  getGramsAsText()
      {
        Debug.Assert(flagHasGrams);
        if (textStoreGrams == "")
          {
            return Convert.ToString(storeGrams);
          }
        else
          {
            return (textStoreGrams);
          }
      }



    public void setWrittenSing(string new_value)
      {
        flagHasWrittenSing = true;
        storeWrittenSing = new_value;
      }
    public void unsetWrittenSing()
      {
        flagHasWrittenSing = false;
      }
    public void setWrittenPlur(string new_value)
      {
        flagHasWrittenPlur = true;
        storeWrittenPlur = new_value;
      }
    public void unsetWrittenPlur()
      {
        flagHasWrittenPlur = false;
      }
    public void setSpokenSizeAndFoodSing(string new_value)
      {
        flagHasSpokenSizeAndFoodSing = true;
        storeSpokenSizeAndFoodSing = new_value;
      }
    public void unsetSpokenSizeAndFoodSing()
      {
        flagHasSpokenSizeAndFoodSing = false;
      }
    public void setSpokenSizeAndFoodPlur(string new_value)
      {
        flagHasSpokenSizeAndFoodPlur = true;
        storeSpokenSizeAndFoodPlur = new_value;
      }
    public void unsetSpokenSizeAndFoodPlur()
      {
        flagHasSpokenSizeAndFoodPlur = false;
      }
    public void setGrams(double new_value)
      {
        flagHasGrams = true;
        if (new_value < 0)
            throw new Exception("The value for field Grams of FoodSizeJSON is less than the lower bound (0) for that field.");
        storeGrams = new_value;
        textStoreGrams = "";
      }
    public void setGramsText(string new_value)
      {
        flagHasGrams = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Grams of FoodSizeJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Grams of FoodSizeJSON is less than the lower bound (0) for that field.");
        textStoreGrams = new_value;
      }
    public void unsetGrams()
      {
        flagHasGrams = false;
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
        Debug.Assert(partial_allowed || flagHasWrittenSing);
        if (flagHasWrittenSing)
          {
            handler.start_pair("WrittenSing");
            handler.string_value(storeWrittenSing);
          }
        Debug.Assert(partial_allowed || flagHasWrittenPlur);
        if (flagHasWrittenPlur)
          {
            handler.start_pair("WrittenPlur");
            handler.string_value(storeWrittenPlur);
          }
        Debug.Assert(partial_allowed || flagHasSpokenSizeAndFoodSing);
        if (flagHasSpokenSizeAndFoodSing)
          {
            handler.start_pair("SpokenSizeAndFoodSing");
            handler.string_value(storeSpokenSizeAndFoodSing);
          }
        Debug.Assert(partial_allowed || flagHasSpokenSizeAndFoodPlur);
        if (flagHasSpokenSizeAndFoodPlur)
          {
            handler.start_pair("SpokenSizeAndFoodPlur");
            handler.string_value(storeSpokenSizeAndFoodPlur);
          }
        Debug.Assert(partial_allowed || flagHasGrams);
        if (flagHasGrams)
          {
            handler.start_pair("Grams");
            if (textStoreGrams != "")
                handler.number_value(textStoreGrams);
            else if (((double)(long)storeGrams) == storeGrams)
                handler.number_value((long)storeGrams);
            else
                handler.number_value(storeGrams);
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
        if (!(hasWrittenSing()))
          {
            return "When parsing the object for %what%, the \"WrittenSing\" field was missing.";
          }
        if (!(hasWrittenPlur()))
          {
            return "When parsing the object for %what%, the \"WrittenPlur\" field was missing.";
          }
        if (!(hasSpokenSizeAndFoodSing()))
          {
            return "When parsing the object for %what%, the \"SpokenSizeAndFoodSing\" field was missing.";
          }
        if (!(hasSpokenSizeAndFoodPlur()))
          {
            return "When parsing the object for %what%, the \"SpokenSizeAndFoodPlur\" field was missing.";
          }
        if (!(hasGrams()))
          {
            return "When parsing the object for %what%, the \"Grams\" field was missing.";
          }
        return null;
      }

    public static FoodSizeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FoodSizeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FoodSize", ignore_extras);
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
    public static FoodSizeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FoodSizeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FoodSizeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FoodSize", ignore_extras);
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
    public static FoodSizeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FoodSizeJSON from_text(string text, bool ignore_extras)
      {
        FoodSizeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FoodSize", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FoodSizeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FoodSizeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FoodSizeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FoodSize", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorWrittenSing;
        private JSONHoldingStringGenerator fieldGeneratorWrittenPlur;
        private JSONHoldingStringGenerator fieldGeneratorSpokenSizeAndFoodSing;
        private JSONHoldingStringGenerator fieldGeneratorSpokenSizeAndFoodPlur;
        private JSONHoldingNumberTextGenerator fieldGeneratorGrams;

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
            FoodSizeJSON result = new FoodSizeJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(FoodSizeJSON result)
          {
            if (fieldGeneratorWrittenSing.have_value)
              {
                result.setWrittenSing(fieldGeneratorWrittenSing.value);
                fieldGeneratorWrittenSing.have_value = false;
              }
            else if ((!(result.hasWrittenSing())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenSing\" field was missing.");
              }
            if (fieldGeneratorWrittenPlur.have_value)
              {
                result.setWrittenPlur(fieldGeneratorWrittenPlur.value);
                fieldGeneratorWrittenPlur.have_value = false;
              }
            else if ((!(result.hasWrittenPlur())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenPlur\" field was missing.");
              }
            if (fieldGeneratorSpokenSizeAndFoodSing.have_value)
              {
                result.setSpokenSizeAndFoodSing(fieldGeneratorSpokenSizeAndFoodSing.value);
                fieldGeneratorSpokenSizeAndFoodSing.have_value = false;
              }
            else if ((!(result.hasSpokenSizeAndFoodSing())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenSizeAndFoodSing\" field was missing.");
              }
            if (fieldGeneratorSpokenSizeAndFoodPlur.have_value)
              {
                result.setSpokenSizeAndFoodPlur(fieldGeneratorSpokenSizeAndFoodPlur.value);
                fieldGeneratorSpokenSizeAndFoodPlur.have_value = false;
              }
            else if ((!(result.hasSpokenSizeAndFoodPlur())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenSizeAndFoodPlur\" field was missing.");
              }
            if (fieldGeneratorGrams.have_value)
              {
                result.setGramsText(fieldGeneratorGrams.value);
                fieldGeneratorGrams.have_value = false;
              }
            else if ((!(result.hasGrams())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Grams\" field was missing.");
              }
          }
        protected abstract void handle_result(FoodSizeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'G':
                    if ((String.Compare(field_name, 1, "rams", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorGrams;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "pokenSizeAndFood", 0, 16, false) == 0)
                      {
                        switch (field_name[17])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 18, "lur", 0, 3, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorSpokenSizeAndFoodPlur;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 18, "ing", 0, 3, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorSpokenSizeAndFoodSing;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "ritten", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 8, "lur", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorWrittenPlur;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 8, "ing", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorWrittenSing;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorWrittenSing = new JSONHoldingStringGenerator("field \"WrittenSing\" of the FoodSize class");
            fieldGeneratorWrittenPlur = new JSONHoldingStringGenerator("field \"WrittenPlur\" of the FoodSize class");
            fieldGeneratorSpokenSizeAndFoodSing = new JSONHoldingStringGenerator("field \"SpokenSizeAndFoodSing\" of the FoodSize class");
            fieldGeneratorSpokenSizeAndFoodPlur = new JSONHoldingStringGenerator("field \"SpokenSizeAndFoodPlur\" of the FoodSize class");
            fieldGeneratorGrams = new JSONHoldingNumberTextGenerator("field \"Grams\" of the FoodSize class");
            set_what("the FoodSize class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorWrittenSing = new JSONHoldingStringGenerator("field \"WrittenSing\" of the FoodSize class");
            fieldGeneratorWrittenPlur = new JSONHoldingStringGenerator("field \"WrittenPlur\" of the FoodSize class");
            fieldGeneratorSpokenSizeAndFoodSing = new JSONHoldingStringGenerator("field \"SpokenSizeAndFoodSing\" of the FoodSize class");
            fieldGeneratorSpokenSizeAndFoodPlur = new JSONHoldingStringGenerator("field \"SpokenSizeAndFoodPlur\" of the FoodSize class");
            fieldGeneratorGrams = new JSONHoldingNumberTextGenerator("field \"Grams\" of the FoodSize class");
            set_what("the FoodSize class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorWrittenSing.reset();
            fieldGeneratorWrittenPlur.reset();
            fieldGeneratorSpokenSizeAndFoodSing.reset();
            fieldGeneratorSpokenSizeAndFoodPlur.reset();
            fieldGeneratorGrams.reset();
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
        protected override void handle_result(FoodSizeJSON  result)
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
        public FoodSizeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FoodSizeJSON  result)
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
    protected virtual void handle_result(List<FoodSizeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FoodSizeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FoodSizeJSON>();
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
    public List<FoodSizeJSON> value;
  };
  };
