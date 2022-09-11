/* file "IHeartRadioSearchAllAPIResponseArtistJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioSearchAllAPIResponseArtistJSON : JSONBase
  {
    private bool flagHasid;
    private BigInteger storeid;
    private bool flagHasname;
    private string storename;
    private bool flagHasimage;
    private string storeimage;
    private bool flagHasrank;
    private double storerank;
    private string textStorerank;
    private bool flagHasscore;
    private double storescore;
    private string textStorescore;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field id of IHeartRadioSearchAllAPIResponseArtistJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field id of IHeartRadioSearchAllAPIResponseArtistJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setid(extracted_integer);
      }


    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field name of IHeartRadioSearchAllAPIResponseArtistJSON is not a string.");
        setname(json_string.getData());
      }


    private void  fromJSONimage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field image of IHeartRadioSearchAllAPIResponseArtistJSON is not a string.");
        setimage(json_string.getData());
      }


    private void  fromJSONrank(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field rank of IHeartRadioSearchAllAPIResponseArtistJSON is not a number.");
              }
          }
        setrankText(the_rational_text);
      }


    private void  fromJSONscore(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field score of IHeartRadioSearchAllAPIResponseArtistJSON is not a number.");
              }
          }
        setscoreText(the_rational_text);
      }


    public IHeartRadioSearchAllAPIResponseArtistJSON()
      {
        flagHasid = false;
        flagHasname = false;
        flagHasimage = false;
        flagHasrank = false;
        flagHasscore = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasid()
      {
        return flagHasid;
      }

    public BigInteger  getid()
      {
        Debug.Assert(flagHasid);
        return storeid;
      }

    public bool  hasname()
      {
        return flagHasname;
      }

    public string  getname()
      {
        Debug.Assert(flagHasname);
        return storename;
      }

    public bool  hasimage()
      {
        return flagHasimage;
      }

    public string  getimage()
      {
        Debug.Assert(flagHasimage);
        return storeimage;
      }

    public bool  hasrank()
      {
        return flagHasrank;
      }

    public double  getrank()
      {
        Debug.Assert(flagHasrank);
        if (textStorerank != "")
          {
            return Double.Parse(textStorerank);
          }
        return storerank;
      }

    public string  getrankAsText()
      {
        Debug.Assert(flagHasrank);
        if (textStorerank == "")
          {
            return Convert.ToString(storerank);
          }
        else
          {
            return (textStorerank);
          }
      }

    public bool  hasscore()
      {
        return flagHasscore;
      }

    public double  getscore()
      {
        Debug.Assert(flagHasscore);
        if (textStorescore != "")
          {
            return Double.Parse(textStorescore);
          }
        return storescore;
      }

    public string  getscoreAsText()
      {
        Debug.Assert(flagHasscore);
        if (textStorescore == "")
          {
            return Convert.ToString(storescore);
          }
        else
          {
            return (textStorescore);
          }
      }


    public virtual int extraIHeartRadioSearchAllAPIResponseArtistComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioSearchAllAPIResponseArtistComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponseArtistComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponseArtistLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setid(BigInteger new_value)
      {
        flagHasid = true;
        storeid = new_value;
      }
    public void unsetid()
      {
        flagHasid = false;
      }
    public void setname(string new_value)
      {
        flagHasname = true;
        storename = new_value;
      }
    public void unsetname()
      {
        flagHasname = false;
      }
    public void setimage(string new_value)
      {
        flagHasimage = true;
        storeimage = new_value;
      }
    public void unsetimage()
      {
        flagHasimage = false;
      }
    public void setrank(double new_value)
      {
        flagHasrank = true;
        storerank = new_value;
        textStorerank = "";
      }
    public void setrankText(string new_value)
      {
        flagHasrank = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field rank of IHeartRadioSearchAllAPIResponseArtistJSON is not a valid number.");
        textStorerank = new_value;
      }
    public void unsetrank()
      {
        flagHasrank = false;
      }
    public void setscore(double new_value)
      {
        flagHasscore = true;
        storescore = new_value;
        textStorescore = "";
      }
    public void setscoreText(string new_value)
      {
        flagHasscore = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field score of IHeartRadioSearchAllAPIResponseArtistJSON is not a valid number.");
        textStorescore = new_value;
      }
    public void unsetscore()
      {
        flagHasscore = false;
      }

    public virtual void extraIHeartRadioSearchAllAPIResponseArtistAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioSearchAllAPIResponseArtistSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioSearchAllAPIResponseArtistLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioSearchAllAPIResponseArtistAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasid);
        if (flagHasid)
          {
            handler.start_pair("id");
            handler.number_value(storeid);
          }
        Debug.Assert(partial_allowed || flagHasname);
        if (flagHasname)
          {
            handler.start_pair("name");
            handler.string_value(storename);
          }
        Debug.Assert(partial_allowed || flagHasimage);
        if (flagHasimage)
          {
            handler.start_pair("image");
            handler.string_value(storeimage);
          }
        Debug.Assert(partial_allowed || flagHasrank);
        if (flagHasrank)
          {
            handler.start_pair("rank");
            if (textStorerank != "")
                handler.number_value(textStorerank);
            else if (((double)(long)storerank) == storerank)
                handler.number_value((long)storerank);
            else
                handler.number_value(storerank);
          }
        Debug.Assert(partial_allowed || flagHasscore);
        if (flagHasscore)
          {
            handler.start_pair("score");
            if (textStorescore != "")
                handler.number_value(textStorescore);
            else if (((double)(long)storescore) == storescore)
                handler.number_value((long)storescore);
            else
                handler.number_value(storescore);
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
        if (!(hasid()))
          {
            return "When parsing the object for %what%, the \"id\" field was missing.";
          }
        if (!(hasname()))
          {
            return "When parsing the object for %what%, the \"name\" field was missing.";
          }
        if (!(hasimage()))
          {
            return "When parsing the object for %what%, the \"image\" field was missing.";
          }
        if (!(hasrank()))
          {
            return "When parsing the object for %what%, the \"rank\" field was missing.";
          }
        if (!(hasscore()))
          {
            return "When parsing the object for %what%, the \"score\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioSearchAllAPIResponseArtistJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponseArtistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseArtist", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponseArtistJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponseArtistJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponseArtistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseArtist", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponseArtistJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponseArtistJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponseArtistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseArtist", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioSearchAllAPIResponseArtistJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioSearchAllAPIResponseArtistJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponseArtistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseArtist", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorid : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorid(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorid : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorid(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorid fieldGeneratorid;
        private JSONHoldingStringGenerator fieldGeneratorname;
        private JSONHoldingStringGenerator fieldGeneratorimage;
        private JSONHoldingNumberTextGenerator fieldGeneratorrank;
        private JSONHoldingNumberTextGenerator fieldGeneratorscore;
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
            IHeartRadioSearchAllAPIResponseArtistJSON result = new IHeartRadioSearchAllAPIResponseArtistJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioSearchAllAPIResponseArtistAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioSearchAllAPIResponseArtistJSON result)
          {
            if (fieldGeneratorid.have_value)
              {
                result.setid(fieldGeneratorid.value);
                fieldGeneratorid.have_value = false;
              }
            else if ((!(result.hasid())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"id\" field was missing.");
              }
            if (fieldGeneratorname.have_value)
              {
                result.setname(fieldGeneratorname.value);
                fieldGeneratorname.have_value = false;
              }
            else if ((!(result.hasname())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"name\" field was missing.");
              }
            if (fieldGeneratorimage.have_value)
              {
                result.setimage(fieldGeneratorimage.value);
                fieldGeneratorimage.have_value = false;
              }
            else if ((!(result.hasimage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"image\" field was missing.");
              }
            if (fieldGeneratorrank.have_value)
              {
                result.setrankText(fieldGeneratorrank.value);
                fieldGeneratorrank.have_value = false;
              }
            else if ((!(result.hasrank())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"rank\" field was missing.");
              }
            if (fieldGeneratorscore.have_value)
              {
                result.setscoreText(fieldGeneratorscore.value);
                fieldGeneratorscore.have_value = false;
              }
            else if ((!(result.hasscore())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"score\" field was missing.");
              }
          }
        protected abstract void handle_result(IHeartRadioSearchAllAPIResponseArtistJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'i':
                    switch (field_name[1])
                      {
                        case 'd':
                            if (field_name.Length == 2)
                                return fieldGeneratorid;
                            break;
                        case 'm':
                            if ((String.Compare(field_name, 2, "age", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorimage;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'n':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorname;
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "ank", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorrank;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "core", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorscore;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorid = new FieldHoldingGeneratorid("field \"id\" of the IHeartRadioSearchAllAPIResponseArtist class");
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the IHeartRadioSearchAllAPIResponseArtist class");
            fieldGeneratorimage = new JSONHoldingStringGenerator("field \"image\" of the IHeartRadioSearchAllAPIResponseArtist class");
            fieldGeneratorrank = new JSONHoldingNumberTextGenerator("field \"rank\" of the IHeartRadioSearchAllAPIResponseArtist class");
            fieldGeneratorscore = new JSONHoldingNumberTextGenerator("field \"score\" of the IHeartRadioSearchAllAPIResponseArtist class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioSearchAllAPIResponseArtist class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorid = new FieldHoldingGeneratorid("field \"id\" of the IHeartRadioSearchAllAPIResponseArtist class");
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the IHeartRadioSearchAllAPIResponseArtist class");
            fieldGeneratorimage = new JSONHoldingStringGenerator("field \"image\" of the IHeartRadioSearchAllAPIResponseArtist class");
            fieldGeneratorrank = new JSONHoldingNumberTextGenerator("field \"rank\" of the IHeartRadioSearchAllAPIResponseArtist class");
            fieldGeneratorscore = new JSONHoldingNumberTextGenerator("field \"score\" of the IHeartRadioSearchAllAPIResponseArtist class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioSearchAllAPIResponseArtist class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorid.reset();
            fieldGeneratorname.reset();
            fieldGeneratorimage.reset();
            fieldGeneratorrank.reset();
            fieldGeneratorscore.reset();
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
        protected override void handle_result(IHeartRadioSearchAllAPIResponseArtistJSON  result)
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
        public IHeartRadioSearchAllAPIResponseArtistJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioSearchAllAPIResponseArtistJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioSearchAllAPIResponseArtistJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioSearchAllAPIResponseArtistJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioSearchAllAPIResponseArtistJSON>();
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
    public List<IHeartRadioSearchAllAPIResponseArtistJSON> value;
  };
  };
