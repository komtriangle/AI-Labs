/* file "IHeartRadioSearchAllAPIResponsePlaylistJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioSearchAllAPIResponsePlaylistJSON : JSONBase
  {
    public class TypeurlsJSON : JSONBase
      {
        private bool flagHasweb;
        private BigInteger storeweb;
        private bool flagHasimage;
        private string storeimage;
        private bool flagHasplay;
        private string storeplay;
        private bool flagHasgoto;
        private string storegoto;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONweb(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field web of TypeurlsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field web of TypeurlsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setweb(extracted_integer);
          }


        private void  fromJSONimage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field image of TypeurlsJSON is not a string.");
            setimage(json_string.getData());
          }


        private void  fromJSONplay(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field play of TypeurlsJSON is not a string.");
            setplay(json_string.getData());
          }


        private void  fromJSONgoto(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field goto of TypeurlsJSON is not a string.");
            setgoto(json_string.getData());
          }


        public TypeurlsJSON()
          {
            flagHasweb = false;
            flagHasimage = false;
            flagHasplay = false;
            flagHasgoto = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasweb()
          {
            return flagHasweb;
          }

        public BigInteger  getweb()
          {
            Debug.Assert(flagHasweb);
            return storeweb;
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

        public bool  hasplay()
          {
            return flagHasplay;
          }

        public string  getplay()
          {
            Debug.Assert(flagHasplay);
            return storeplay;
          }

        public bool  hasgoto()
          {
            return flagHasgoto;
          }

        public string  getgoto()
          {
            Debug.Assert(flagHasgoto);
            return storegoto;
          }


        public virtual int extraTypeurlsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeurlsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeurlsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeurlsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setweb(BigInteger new_value)
          {
            flagHasweb = true;
            storeweb = new_value;
          }
        public void unsetweb()
          {
            flagHasweb = false;
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
        public void setplay(string new_value)
          {
            flagHasplay = true;
            storeplay = new_value;
          }
        public void unsetplay()
          {
            flagHasplay = false;
          }
        public void setgoto(string new_value)
          {
            flagHasgoto = true;
            storegoto = new_value;
          }
        public void unsetgoto()
          {
            flagHasgoto = false;
          }

        public virtual void extraTypeurlsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeurlsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeurlsLookup(key);
            if (old_field == null)
              {
                extraTypeurlsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasweb);
            if (flagHasweb)
              {
                handler.start_pair("web");
                handler.number_value(storeweb);
              }
            Debug.Assert(partial_allowed || flagHasimage);
            if (flagHasimage)
              {
                handler.start_pair("image");
                handler.string_value(storeimage);
              }
            Debug.Assert(partial_allowed || flagHasplay);
            if (flagHasplay)
              {
                handler.start_pair("play");
                handler.string_value(storeplay);
              }
            Debug.Assert(partial_allowed || flagHasgoto);
            if (flagHasgoto)
              {
                handler.start_pair("goto");
                handler.string_value(storegoto);
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
            if (!(hasweb()))
              {
                return "When parsing the object for %what%, the \"web\" field was missing.";
              }
            if (!(hasimage()))
              {
                return "When parsing the object for %what%, the \"image\" field was missing.";
              }
            if (!(hasplay()))
              {
                return "When parsing the object for %what%, the \"play\" field was missing.";
              }
            if (!(hasgoto()))
              {
                return "When parsing the object for %what%, the \"goto\" field was missing.";
              }
            return null;
          }

        public static TypeurlsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeurlsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeurls", ignore_extras);
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
        public static TypeurlsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeurlsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeurlsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeurls", ignore_extras);
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
        public static TypeurlsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeurlsJSON from_text(string text, bool ignore_extras)
          {
            TypeurlsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeurls", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeurlsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeurlsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeurlsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeurls", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorweb : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorweb(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorweb : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorweb(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorweb fieldGeneratorweb;
            private JSONHoldingStringGenerator fieldGeneratorimage;
            private JSONHoldingStringGenerator fieldGeneratorplay;
            private JSONHoldingStringGenerator fieldGeneratorgoto;
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
                TypeurlsJSON result = new TypeurlsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeurlsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeurlsJSON result)
              {
                if (fieldGeneratorweb.have_value)
                  {
                    result.setweb(fieldGeneratorweb.value);
                    fieldGeneratorweb.have_value = false;
                  }
                else if ((!(result.hasweb())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"web\" field was missing.");
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
                if (fieldGeneratorplay.have_value)
                  {
                    result.setplay(fieldGeneratorplay.value);
                    fieldGeneratorplay.have_value = false;
                  }
                else if ((!(result.hasplay())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"play\" field was missing.");
                  }
                if (fieldGeneratorgoto.have_value)
                  {
                    result.setgoto(fieldGeneratorgoto.value);
                    fieldGeneratorgoto.have_value = false;
                  }
                else if ((!(result.hasgoto())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"goto\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeurlsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'g':
                        if ((String.Compare(field_name, 1, "oto", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorgoto;
                        break;
                    case 'i':
                        if ((String.Compare(field_name, 1, "mage", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorimage;
                        break;
                    case 'p':
                        if ((String.Compare(field_name, 1, "lay", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorplay;
                        break;
                    case 'w':
                        if ((String.Compare(field_name, 1, "eb", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorweb;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorweb = new FieldHoldingGeneratorweb("field \"web\" of the Typeurls class");
                fieldGeneratorimage = new JSONHoldingStringGenerator("field \"image\" of the Typeurls class");
                fieldGeneratorplay = new JSONHoldingStringGenerator("field \"play\" of the Typeurls class");
                fieldGeneratorgoto = new JSONHoldingStringGenerator("field \"goto\" of the Typeurls class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the Typeurls class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorweb = new FieldHoldingGeneratorweb("field \"web\" of the Typeurls class");
                fieldGeneratorimage = new JSONHoldingStringGenerator("field \"image\" of the Typeurls class");
                fieldGeneratorplay = new JSONHoldingStringGenerator("field \"play\" of the Typeurls class");
                fieldGeneratorgoto = new JSONHoldingStringGenerator("field \"goto\" of the Typeurls class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the Typeurls class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorweb.reset();
                fieldGeneratorimage.reset();
                fieldGeneratorplay.reset();
                fieldGeneratorgoto.reset();
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
            protected override void handle_result(TypeurlsJSON  result)
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
            public TypeurlsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeurlsJSON  result)
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
        protected virtual void handle_result(List<TypeurlsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeurlsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeurlsJSON>();
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
        public List<TypeurlsJSON> value;
      };
      };
    private bool flagHasid;
    private string storeid;
    private bool flagHasuserId;
    private BigInteger storeuserId;
    private bool flagHasname;
    private BigInteger storename;
    private bool flagHasdescription;
    private BigInteger storedescription;
    private bool flagHasauthor;
    private BigInteger storeauthor;
    private bool flagHasurls;
    private TypeurlsJSON  storeurls;
    private bool flagHasreportingKey;
    private string storereportingKey;
    private bool flagHasscore;
    private double storescore;
    private string textStorescore;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field id of IHeartRadioSearchAllAPIResponsePlaylistJSON is not a string.");
        setid(json_string.getData());
      }


    private void  fromJSONuserId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field userId of IHeartRadioSearchAllAPIResponsePlaylistJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field userId of IHeartRadioSearchAllAPIResponsePlaylistJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setuserId(extracted_integer);
      }


    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field name of IHeartRadioSearchAllAPIResponsePlaylistJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field name of IHeartRadioSearchAllAPIResponsePlaylistJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setname(extracted_integer);
      }


    private void  fromJSONdescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field description of IHeartRadioSearchAllAPIResponsePlaylistJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field description of IHeartRadioSearchAllAPIResponsePlaylistJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setdescription(extracted_integer);
      }


    private void  fromJSONauthor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field author of IHeartRadioSearchAllAPIResponsePlaylistJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field author of IHeartRadioSearchAllAPIResponsePlaylistJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setauthor(extracted_integer);
      }


    private void  fromJSONurls(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeurlsJSON convert_classy = TypeurlsJSON.from_json(json_value, ignore_extras, true);
        seturls(convert_classy);
      }


    private void  fromJSONreportingKey(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field reportingKey of IHeartRadioSearchAllAPIResponsePlaylistJSON is not a string.");
        setreportingKey(json_string.getData());
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
                throw new Exception("The value for field score of IHeartRadioSearchAllAPIResponsePlaylistJSON is not a number.");
              }
          }
        setscoreText(the_rational_text);
      }


    public IHeartRadioSearchAllAPIResponsePlaylistJSON()
      {
        flagHasid = false;
        flagHasuserId = false;
        flagHasname = false;
        flagHasdescription = false;
        flagHasauthor = false;
        flagHasurls = false;
        flagHasreportingKey = false;
        flagHasscore = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasid()
      {
        return flagHasid;
      }

    public string  getid()
      {
        Debug.Assert(flagHasid);
        return storeid;
      }

    public bool  hasuserId()
      {
        return flagHasuserId;
      }

    public BigInteger  getuserId()
      {
        Debug.Assert(flagHasuserId);
        return storeuserId;
      }

    public bool  hasname()
      {
        return flagHasname;
      }

    public BigInteger  getname()
      {
        Debug.Assert(flagHasname);
        return storename;
      }

    public bool  hasdescription()
      {
        return flagHasdescription;
      }

    public BigInteger  getdescription()
      {
        Debug.Assert(flagHasdescription);
        return storedescription;
      }

    public bool  hasauthor()
      {
        return flagHasauthor;
      }

    public BigInteger  getauthor()
      {
        Debug.Assert(flagHasauthor);
        return storeauthor;
      }

    public bool  hasurls()
      {
        return flagHasurls;
      }

    public TypeurlsJSON   geturls()
      {
        Debug.Assert(flagHasurls);
        return storeurls;
      }

    public bool  hasreportingKey()
      {
        return flagHasreportingKey;
      }

    public string  getreportingKey()
      {
        Debug.Assert(flagHasreportingKey);
        return storereportingKey;
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


    public virtual int extraIHeartRadioSearchAllAPIResponsePlaylistComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioSearchAllAPIResponsePlaylistComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponsePlaylistComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponsePlaylistLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setid(string new_value)
      {
        flagHasid = true;
        storeid = new_value;
      }
    public void unsetid()
      {
        flagHasid = false;
      }
    public void setuserId(BigInteger new_value)
      {
        flagHasuserId = true;
        storeuserId = new_value;
      }
    public void unsetuserId()
      {
        flagHasuserId = false;
      }
    public void setname(BigInteger new_value)
      {
        flagHasname = true;
        storename = new_value;
      }
    public void unsetname()
      {
        flagHasname = false;
      }
    public void setdescription(BigInteger new_value)
      {
        flagHasdescription = true;
        storedescription = new_value;
      }
    public void unsetdescription()
      {
        flagHasdescription = false;
      }
    public void setauthor(BigInteger new_value)
      {
        flagHasauthor = true;
        storeauthor = new_value;
      }
    public void unsetauthor()
      {
        flagHasauthor = false;
      }
    public void seturls(TypeurlsJSON  new_value)
      {
        if (flagHasurls)
          {
          }
        flagHasurls = true;
        storeurls = new_value;
      }
    public void unseturls()
      {
        if (flagHasurls)
          {
          }
        flagHasurls = false;
      }
    public void setreportingKey(string new_value)
      {
        flagHasreportingKey = true;
        storereportingKey = new_value;
      }
    public void unsetreportingKey()
      {
        flagHasreportingKey = false;
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
            throw new Exception("The text value for field score of IHeartRadioSearchAllAPIResponsePlaylistJSON is not a valid number.");
        textStorescore = new_value;
      }
    public void unsetscore()
      {
        flagHasscore = false;
      }

    public virtual void extraIHeartRadioSearchAllAPIResponsePlaylistAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioSearchAllAPIResponsePlaylistSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioSearchAllAPIResponsePlaylistLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioSearchAllAPIResponsePlaylistAppendPair(key, new_component);
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
            handler.string_value(storeid);
          }
        Debug.Assert(partial_allowed || flagHasuserId);
        if (flagHasuserId)
          {
            handler.start_pair("userId");
            handler.number_value(storeuserId);
          }
        Debug.Assert(partial_allowed || flagHasname);
        if (flagHasname)
          {
            handler.start_pair("name");
            handler.number_value(storename);
          }
        Debug.Assert(partial_allowed || flagHasdescription);
        if (flagHasdescription)
          {
            handler.start_pair("description");
            handler.number_value(storedescription);
          }
        Debug.Assert(partial_allowed || flagHasauthor);
        if (flagHasauthor)
          {
            handler.start_pair("author");
            handler.number_value(storeauthor);
          }
        Debug.Assert(partial_allowed || flagHasurls);
        if (flagHasurls)
          {
            handler.start_pair("urls");
            if (partial_allowed)
                storeurls.write_partial_as_json(handler);
            else
                storeurls.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasreportingKey);
        if (flagHasreportingKey)
          {
            handler.start_pair("reportingKey");
            handler.string_value(storereportingKey);
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
        if (!(hasuserId()))
          {
            return "When parsing the object for %what%, the \"userId\" field was missing.";
          }
        if (!(hasname()))
          {
            return "When parsing the object for %what%, the \"name\" field was missing.";
          }
        if (!(hasdescription()))
          {
            return "When parsing the object for %what%, the \"description\" field was missing.";
          }
        if (!(hasauthor()))
          {
            return "When parsing the object for %what%, the \"author\" field was missing.";
          }
        if (!(hasurls()))
          {
            return "When parsing the object for %what%, the \"urls\" field was missing.";
          }
        if (!(hasreportingKey()))
          {
            return "When parsing the object for %what%, the \"reportingKey\" field was missing.";
          }
        if (!(hasscore()))
          {
            return "When parsing the object for %what%, the \"score\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioSearchAllAPIResponsePlaylistJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponsePlaylistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponsePlaylist", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponsePlaylistJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponsePlaylistJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponsePlaylistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponsePlaylist", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponsePlaylistJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponsePlaylistJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponsePlaylistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponsePlaylist", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioSearchAllAPIResponsePlaylistJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioSearchAllAPIResponsePlaylistJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponsePlaylistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponsePlaylist", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorid;
    private class FieldHoldingGeneratoruserId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratoruserId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratoruserId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratoruserId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratoruserId fieldGeneratoruserId;
    private class FieldHoldingGeneratorname : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorname(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorname : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorname(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorname fieldGeneratorname;
    private class FieldHoldingGeneratordescription : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratordescription(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratordescription : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratordescription(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratordescription fieldGeneratordescription;
    private class FieldHoldingGeneratorauthor : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorauthor(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorauthor : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorauthor(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorauthor fieldGeneratorauthor;
        private TypeurlsJSON.HoldingGenerator fieldGeneratorurls;
        private JSONHoldingStringGenerator fieldGeneratorreportingKey;
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
            IHeartRadioSearchAllAPIResponsePlaylistJSON result = new IHeartRadioSearchAllAPIResponsePlaylistJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioSearchAllAPIResponsePlaylistAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioSearchAllAPIResponsePlaylistJSON result)
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
            if (fieldGeneratoruserId.have_value)
              {
                result.setuserId(fieldGeneratoruserId.value);
                fieldGeneratoruserId.have_value = false;
              }
            else if ((!(result.hasuserId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"userId\" field was missing.");
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
            if (fieldGeneratordescription.have_value)
              {
                result.setdescription(fieldGeneratordescription.value);
                fieldGeneratordescription.have_value = false;
              }
            else if ((!(result.hasdescription())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"description\" field was missing.");
              }
            if (fieldGeneratorauthor.have_value)
              {
                result.setauthor(fieldGeneratorauthor.value);
                fieldGeneratorauthor.have_value = false;
              }
            else if ((!(result.hasauthor())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"author\" field was missing.");
              }
            if (fieldGeneratorurls.have_value)
              {
                result.seturls(fieldGeneratorurls.value);
                fieldGeneratorurls.have_value = false;
              }
            else if ((!(result.hasurls())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"urls\" field was missing.");
              }
            if (fieldGeneratorreportingKey.have_value)
              {
                result.setreportingKey(fieldGeneratorreportingKey.value);
                fieldGeneratorreportingKey.have_value = false;
              }
            else if ((!(result.hasreportingKey())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"reportingKey\" field was missing.");
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
        protected abstract void handle_result(IHeartRadioSearchAllAPIResponsePlaylistJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    if ((String.Compare(field_name, 1, "uthor", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorauthor;
                    break;
                case 'd':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratordescription;
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorid;
                    break;
                case 'n':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorname;
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "eportingKey", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorreportingKey;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "core", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorscore;
                    break;
                case 'u':
                    switch (field_name[1])
                      {
                        case 'r':
                            if ((String.Compare(field_name, 2, "ls", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorurls;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 2, "erId", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratoruserId;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratoruserId = new FieldHoldingGeneratoruserId("field \"userId\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratorname = new FieldHoldingGeneratorname("field \"name\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratordescription = new FieldHoldingGeneratordescription("field \"description\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratorauthor = new FieldHoldingGeneratorauthor("field \"author\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratorurls = new TypeurlsJSON.HoldingGenerator("field \"urls\" of the IHeartRadioSearchAllAPIResponsePlaylist class", ignore_extras);
            fieldGeneratorreportingKey = new JSONHoldingStringGenerator("field \"reportingKey\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratorscore = new JSONHoldingNumberTextGenerator("field \"score\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioSearchAllAPIResponsePlaylist class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratoruserId = new FieldHoldingGeneratoruserId("field \"userId\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratorname = new FieldHoldingGeneratorname("field \"name\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratordescription = new FieldHoldingGeneratordescription("field \"description\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratorauthor = new FieldHoldingGeneratorauthor("field \"author\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratorurls = new TypeurlsJSON.HoldingGenerator("field \"urls\" of the IHeartRadioSearchAllAPIResponsePlaylist class", false);
            fieldGeneratorreportingKey = new JSONHoldingStringGenerator("field \"reportingKey\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            fieldGeneratorscore = new JSONHoldingNumberTextGenerator("field \"score\" of the IHeartRadioSearchAllAPIResponsePlaylist class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioSearchAllAPIResponsePlaylist class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorid.reset();
            fieldGeneratoruserId.reset();
            fieldGeneratorname.reset();
            fieldGeneratordescription.reset();
            fieldGeneratorauthor.reset();
            fieldGeneratorurls.reset();
            fieldGeneratorreportingKey.reset();
            fieldGeneratorscore.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorurls.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorurls.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioSearchAllAPIResponsePlaylistJSON  result)
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
        public IHeartRadioSearchAllAPIResponsePlaylistJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioSearchAllAPIResponsePlaylistJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioSearchAllAPIResponsePlaylistJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioSearchAllAPIResponsePlaylistJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioSearchAllAPIResponsePlaylistJSON>();
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
    public List<IHeartRadioSearchAllAPIResponsePlaylistJSON> value;
  };
  };
