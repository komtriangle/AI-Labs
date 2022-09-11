/* file "WikidataAPISPARQLVariableContentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WikidataAPISPARQLVariableContentJSON : JSONBase
  {
    private bool flagHasxml_lang;
    private string storexml_lang;
    private bool flagHastype;
    private string storetype;
    private bool flagHasvalue;
    private string storevalue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONxml_lang(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field xml_lang of WikidataAPISPARQLVariableContentJSON is not a string.");
        setxml_lang(json_string.getData());
      }


    private void  fromJSONtype(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field type of WikidataAPISPARQLVariableContentJSON is not a string.");
        settype(json_string.getData());
      }


    private void  fromJSONvalue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field value of WikidataAPISPARQLVariableContentJSON is not a string.");
        setvalue(json_string.getData());
      }


    public WikidataAPISPARQLVariableContentJSON()
      {
        flagHasxml_lang = false;
        flagHastype = false;
        flagHasvalue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasxml_lang()
      {
        return flagHasxml_lang;
      }

    public string  getxml_lang()
      {
        Debug.Assert(flagHasxml_lang);
        return storexml_lang;
      }

    public bool  hastype()
      {
        return flagHastype;
      }

    public string  gettype()
      {
        Debug.Assert(flagHastype);
        return storetype;
      }

    public bool  hasvalue()
      {
        return flagHasvalue;
      }

    public string  getvalue()
      {
        Debug.Assert(flagHasvalue);
        return storevalue;
      }


    public virtual int extraWikidataAPISPARQLVariableContentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWikidataAPISPARQLVariableContentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWikidataAPISPARQLVariableContentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWikidataAPISPARQLVariableContentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setxml_lang(string new_value)
      {
        flagHasxml_lang = true;
        storexml_lang = new_value;
      }
    public void unsetxml_lang()
      {
        flagHasxml_lang = false;
      }
    public void settype(string new_value)
      {
        flagHastype = true;
        storetype = new_value;
      }
    public void unsettype()
      {
        flagHastype = false;
      }
    public void setvalue(string new_value)
      {
        flagHasvalue = true;
        storevalue = new_value;
      }
    public void unsetvalue()
      {
        flagHasvalue = false;
      }

    public virtual void extraWikidataAPISPARQLVariableContentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWikidataAPISPARQLVariableContentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWikidataAPISPARQLVariableContentLookup(key);
        if (old_field == null)
          {
            extraWikidataAPISPARQLVariableContentAppendPair(key, new_component);
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
        if (flagHasxml_lang)
          {
            handler.start_pair("xml:lang");
            handler.string_value(storexml_lang);
          }
        Debug.Assert(partial_allowed || flagHastype);
        if (flagHastype)
          {
            handler.start_pair("type");
            handler.string_value(storetype);
          }
        Debug.Assert(partial_allowed || flagHasvalue);
        if (flagHasvalue)
          {
            handler.start_pair("value");
            handler.string_value(storevalue);
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
        if (!(hastype()))
          {
            return "When parsing the object for %what%, the \"type\" field was missing.";
          }
        if (!(hasvalue()))
          {
            return "When parsing the object for %what%, the \"value\" field was missing.";
          }
        return null;
      }

    public static WikidataAPISPARQLVariableContentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPISPARQLVariableContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPISPARQLVariableContent", ignore_extras);
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
    public static WikidataAPISPARQLVariableContentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WikidataAPISPARQLVariableContentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPISPARQLVariableContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPISPARQLVariableContent", ignore_extras);
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
    public static WikidataAPISPARQLVariableContentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WikidataAPISPARQLVariableContentJSON from_text(string text, bool ignore_extras)
      {
        WikidataAPISPARQLVariableContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPISPARQLVariableContent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WikidataAPISPARQLVariableContentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WikidataAPISPARQLVariableContentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WikidataAPISPARQLVariableContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPISPARQLVariableContent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorxml_lang;
        private JSONHoldingStringGenerator fieldGeneratortype;
        private JSONHoldingStringGenerator fieldGeneratorvalue;
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
            WikidataAPISPARQLVariableContentJSON result = new WikidataAPISPARQLVariableContentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWikidataAPISPARQLVariableContentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WikidataAPISPARQLVariableContentJSON result)
          {
            if (fieldGeneratorxml_lang.have_value)
              {
                result.setxml_lang(fieldGeneratorxml_lang.value);
                fieldGeneratorxml_lang.have_value = false;
              }
            if (fieldGeneratortype.have_value)
              {
                result.settype(fieldGeneratortype.value);
                fieldGeneratortype.have_value = false;
              }
            else if ((!(result.hastype())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"type\" field was missing.");
              }
            if (fieldGeneratorvalue.have_value)
              {
                result.setvalue(fieldGeneratorvalue.value);
                fieldGeneratorvalue.have_value = false;
              }
            else if ((!(result.hasvalue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"value\" field was missing.");
              }
          }
        protected abstract void handle_result(WikidataAPISPARQLVariableContentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 't':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratortype;
                    break;
                case 'v':
                    if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorvalue;
                    break;
                case 'x':
                    if ((String.Compare(field_name, 1, "ml:lang", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorxml_lang;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorxml_lang = new JSONHoldingStringGenerator("field \"xml:lang\" of the WikidataAPISPARQLVariableContent class");
            fieldGeneratortype = new JSONHoldingStringGenerator("field \"type\" of the WikidataAPISPARQLVariableContent class");
            fieldGeneratorvalue = new JSONHoldingStringGenerator("field \"value\" of the WikidataAPISPARQLVariableContent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WikidataAPISPARQLVariableContent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorxml_lang = new JSONHoldingStringGenerator("field \"xml:lang\" of the WikidataAPISPARQLVariableContent class");
            fieldGeneratortype = new JSONHoldingStringGenerator("field \"type\" of the WikidataAPISPARQLVariableContent class");
            fieldGeneratorvalue = new JSONHoldingStringGenerator("field \"value\" of the WikidataAPISPARQLVariableContent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WikidataAPISPARQLVariableContent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorxml_lang.reset();
            fieldGeneratortype.reset();
            fieldGeneratorvalue.reset();
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
        protected override void handle_result(WikidataAPISPARQLVariableContentJSON  result)
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
        public WikidataAPISPARQLVariableContentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WikidataAPISPARQLVariableContentJSON  result)
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
    protected virtual void handle_result(List<WikidataAPISPARQLVariableContentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WikidataAPISPARQLVariableContentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WikidataAPISPARQLVariableContentJSON>();
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
    public List<WikidataAPISPARQLVariableContentJSON> value;
  };
  };
