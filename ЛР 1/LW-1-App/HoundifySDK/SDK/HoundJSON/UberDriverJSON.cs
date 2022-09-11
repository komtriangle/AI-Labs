/* file "UberDriverJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberDriverJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasPhoneNumber;
    private string storePhoneNumber;
    private bool flagHasRating;
    private double storeRating;
    private string textStoreRating;
    private bool flagHasPictureUrl;
    private string storePictureUrl;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of UberDriverJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONPhoneNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PhoneNumber of UberDriverJSON is not a string.");
        setPhoneNumber(json_string.getData());
      }


    private void  fromJSONRating(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Rating of UberDriverJSON is not a number.");
              }
          }
        setRatingText(the_rational_text);
      }


    private void  fromJSONPictureUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PictureUrl of UberDriverJSON is not a string.");
        setPictureUrl(json_string.getData());
      }


    public UberDriverJSON()
      {
        flagHasName = false;
        flagHasPhoneNumber = false;
        flagHasRating = false;
        flagHasPictureUrl = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasPhoneNumber()
      {
        return flagHasPhoneNumber;
      }

    public string  getPhoneNumber()
      {
        Debug.Assert(flagHasPhoneNumber);
        return storePhoneNumber;
      }

    public bool  hasRating()
      {
        return flagHasRating;
      }

    public double  getRating()
      {
        Debug.Assert(flagHasRating);
        if (textStoreRating != "")
          {
            return Double.Parse(textStoreRating);
          }
        return storeRating;
      }

    public string  getRatingAsText()
      {
        Debug.Assert(flagHasRating);
        if (textStoreRating == "")
          {
            return Convert.ToString(storeRating);
          }
        else
          {
            return (textStoreRating);
          }
      }

    public bool  hasPictureUrl()
      {
        return flagHasPictureUrl;
      }

    public string  getPictureUrl()
      {
        Debug.Assert(flagHasPictureUrl);
        return storePictureUrl;
      }


    public virtual int extraUberDriverComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberDriverComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberDriverComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberDriverLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setPhoneNumber(string new_value)
      {
        flagHasPhoneNumber = true;
        storePhoneNumber = new_value;
      }
    public void unsetPhoneNumber()
      {
        flagHasPhoneNumber = false;
      }
    public void setRating(double new_value)
      {
        flagHasRating = true;
        storeRating = new_value;
        textStoreRating = "";
      }
    public void setRatingText(string new_value)
      {
        flagHasRating = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Rating of UberDriverJSON is not a valid number.");
        textStoreRating = new_value;
      }
    public void unsetRating()
      {
        flagHasRating = false;
      }
    public void setPictureUrl(string new_value)
      {
        flagHasPictureUrl = true;
        storePictureUrl = new_value;
      }
    public void unsetPictureUrl()
      {
        flagHasPictureUrl = false;
      }

    public virtual void extraUberDriverAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberDriverSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberDriverLookup(key);
        if (old_field == null)
          {
            extraUberDriverAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        Debug.Assert(partial_allowed || flagHasPhoneNumber);
        if (flagHasPhoneNumber)
          {
            handler.start_pair("PhoneNumber");
            handler.string_value(storePhoneNumber);
          }
        Debug.Assert(partial_allowed || flagHasRating);
        if (flagHasRating)
          {
            handler.start_pair("Rating");
            if (textStoreRating != "")
                handler.number_value(textStoreRating);
            else if (((double)(long)storeRating) == storeRating)
                handler.number_value((long)storeRating);
            else
                handler.number_value(storeRating);
          }
        if (flagHasPictureUrl)
          {
            handler.start_pair("PictureUrl");
            handler.string_value(storePictureUrl);
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        if (!(hasPhoneNumber()))
          {
            return "When parsing the object for %what%, the \"PhoneNumber\" field was missing.";
          }
        if (!(hasRating()))
          {
            return "When parsing the object for %what%, the \"Rating\" field was missing.";
          }
        return null;
      }

    public static UberDriverJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberDriverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberDriver", ignore_extras);
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
    public static UberDriverJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberDriverJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberDriverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberDriver", ignore_extras);
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
    public static UberDriverJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberDriverJSON from_text(string text, bool ignore_extras)
      {
        UberDriverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberDriver", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberDriverJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberDriverJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberDriverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberDriver", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorPhoneNumber;
        private JSONHoldingNumberTextGenerator fieldGeneratorRating;
        private JSONHoldingStringGenerator fieldGeneratorPictureUrl;
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
            UberDriverJSON result = new UberDriverJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberDriverAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberDriverJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorPhoneNumber.have_value)
              {
                result.setPhoneNumber(fieldGeneratorPhoneNumber.value);
                fieldGeneratorPhoneNumber.have_value = false;
              }
            else if ((!(result.hasPhoneNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PhoneNumber\" field was missing.");
              }
            if (fieldGeneratorRating.have_value)
              {
                result.setRatingText(fieldGeneratorRating.value);
                fieldGeneratorRating.have_value = false;
              }
            else if ((!(result.hasRating())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Rating\" field was missing.");
              }
            if (fieldGeneratorPictureUrl.have_value)
              {
                result.setPictureUrl(fieldGeneratorPictureUrl.value);
                fieldGeneratorPictureUrl.have_value = false;
              }
          }
        protected abstract void handle_result(UberDriverJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "oneNumber", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorPhoneNumber;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "ctureUrl", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorPictureUrl;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ating", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorRating;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the UberDriver class");
            fieldGeneratorPhoneNumber = new JSONHoldingStringGenerator("field \"PhoneNumber\" of the UberDriver class");
            fieldGeneratorRating = new JSONHoldingNumberTextGenerator("field \"Rating\" of the UberDriver class");
            fieldGeneratorPictureUrl = new JSONHoldingStringGenerator("field \"PictureUrl\" of the UberDriver class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberDriver class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the UberDriver class");
            fieldGeneratorPhoneNumber = new JSONHoldingStringGenerator("field \"PhoneNumber\" of the UberDriver class");
            fieldGeneratorRating = new JSONHoldingNumberTextGenerator("field \"Rating\" of the UberDriver class");
            fieldGeneratorPictureUrl = new JSONHoldingStringGenerator("field \"PictureUrl\" of the UberDriver class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberDriver class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorPhoneNumber.reset();
            fieldGeneratorRating.reset();
            fieldGeneratorPictureUrl.reset();
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
        protected override void handle_result(UberDriverJSON  result)
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
        public UberDriverJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberDriverJSON  result)
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
    protected virtual void handle_result(List<UberDriverJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberDriverJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberDriverJSON>();
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
    public List<UberDriverJSON> value;
  };
  };
