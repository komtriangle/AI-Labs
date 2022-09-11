/* file "WikidataAPISitelinkJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WikidataAPISitelinkJSON : JSONBase
  {
    private bool flagHastitle;
    private string storetitle;
    private bool flagHassite;
    private string storesite;
    private bool flagHasurl;
    private string storeurl;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONtitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field title of WikidataAPISitelinkJSON is not a string.");
        settitle(json_string.getData());
      }


    private void  fromJSONsite(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field site of WikidataAPISitelinkJSON is not a string.");
        setsite(json_string.getData());
      }


    private void  fromJSONurl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field url of WikidataAPISitelinkJSON is not a string.");
        seturl(json_string.getData());
      }


    public WikidataAPISitelinkJSON()
      {
        flagHastitle = false;
        flagHassite = false;
        flagHasurl = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hastitle()
      {
        return flagHastitle;
      }

    public string  gettitle()
      {
        Debug.Assert(flagHastitle);
        return storetitle;
      }

    public bool  hassite()
      {
        return flagHassite;
      }

    public string  getsite()
      {
        Debug.Assert(flagHassite);
        return storesite;
      }

    public bool  hasurl()
      {
        return flagHasurl;
      }

    public string  geturl()
      {
        Debug.Assert(flagHasurl);
        return storeurl;
      }


    public virtual int extraWikidataAPISitelinkComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWikidataAPISitelinkComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWikidataAPISitelinkComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWikidataAPISitelinkLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void settitle(string new_value)
      {
        flagHastitle = true;
        storetitle = new_value;
      }
    public void unsettitle()
      {
        flagHastitle = false;
      }
    public void setsite(string new_value)
      {
        flagHassite = true;
        storesite = new_value;
      }
    public void unsetsite()
      {
        flagHassite = false;
      }
    public void seturl(string new_value)
      {
        flagHasurl = true;
        storeurl = new_value;
      }
    public void unseturl()
      {
        flagHasurl = false;
      }

    public virtual void extraWikidataAPISitelinkAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWikidataAPISitelinkSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWikidataAPISitelinkLookup(key);
        if (old_field == null)
          {
            extraWikidataAPISitelinkAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHastitle);
        if (flagHastitle)
          {
            handler.start_pair("title");
            handler.string_value(storetitle);
          }
        if (flagHassite)
          {
            handler.start_pair("site");
            handler.string_value(storesite);
          }
        if (flagHasurl)
          {
            handler.start_pair("url");
            handler.string_value(storeurl);
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
        if (!(hastitle()))
          {
            return "When parsing the object for %what%, the \"title\" field was missing.";
          }
        return null;
      }

    public static WikidataAPISitelinkJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPISitelinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPISitelink", ignore_extras);
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
    public static WikidataAPISitelinkJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WikidataAPISitelinkJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPISitelinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPISitelink", ignore_extras);
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
    public static WikidataAPISitelinkJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WikidataAPISitelinkJSON from_text(string text, bool ignore_extras)
      {
        WikidataAPISitelinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPISitelink", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WikidataAPISitelinkJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WikidataAPISitelinkJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WikidataAPISitelinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPISitelink", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratortitle;
        private JSONHoldingStringGenerator fieldGeneratorsite;
        private JSONHoldingStringGenerator fieldGeneratorurl;
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
            WikidataAPISitelinkJSON result = new WikidataAPISitelinkJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWikidataAPISitelinkAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WikidataAPISitelinkJSON result)
          {
            if (fieldGeneratortitle.have_value)
              {
                result.settitle(fieldGeneratortitle.value);
                fieldGeneratortitle.have_value = false;
              }
            else if ((!(result.hastitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"title\" field was missing.");
              }
            if (fieldGeneratorsite.have_value)
              {
                result.setsite(fieldGeneratorsite.value);
                fieldGeneratorsite.have_value = false;
              }
            if (fieldGeneratorurl.have_value)
              {
                result.seturl(fieldGeneratorurl.value);
                fieldGeneratorurl.have_value = false;
              }
          }
        protected abstract void handle_result(WikidataAPISitelinkJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 's':
                    if ((String.Compare(field_name, 1, "ite", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorsite;
                    break;
                case 't':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratortitle;
                    break;
                case 'u':
                    if ((String.Compare(field_name, 1, "rl", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorurl;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratortitle = new JSONHoldingStringGenerator("field \"title\" of the WikidataAPISitelink class");
            fieldGeneratorsite = new JSONHoldingStringGenerator("field \"site\" of the WikidataAPISitelink class");
            fieldGeneratorurl = new JSONHoldingStringGenerator("field \"url\" of the WikidataAPISitelink class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WikidataAPISitelink class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratortitle = new JSONHoldingStringGenerator("field \"title\" of the WikidataAPISitelink class");
            fieldGeneratorsite = new JSONHoldingStringGenerator("field \"site\" of the WikidataAPISitelink class");
            fieldGeneratorurl = new JSONHoldingStringGenerator("field \"url\" of the WikidataAPISitelink class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WikidataAPISitelink class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratortitle.reset();
            fieldGeneratorsite.reset();
            fieldGeneratorurl.reset();
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
        protected override void handle_result(WikidataAPISitelinkJSON  result)
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
        public WikidataAPISitelinkJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WikidataAPISitelinkJSON  result)
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
    protected virtual void handle_result(List<WikidataAPISitelinkJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WikidataAPISitelinkJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WikidataAPISitelinkJSON>();
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
    public List<WikidataAPISitelinkJSON> value;
  };
  };
