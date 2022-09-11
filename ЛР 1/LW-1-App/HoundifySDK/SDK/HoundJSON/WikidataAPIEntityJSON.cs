/* file "WikidataAPIEntityJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WikidataAPIEntityJSON : JSONBase
  {
    private bool flagHastype;
    private string storetype;
    private bool flagHasid;
    private string storeid;
    private bool flagHasaliases;
    private JSONObjectValue  storealiases;
    private bool flagHaslabels;
    private JSONObjectValue  storelabels;
    private bool flagHasdescriptions;
    private JSONObjectValue  storedescriptions;
    private bool flagHasclaims;
    private JSONObjectValue  storeclaims;
    private bool flagHassitelinks;
    private JSONObjectValue  storesitelinks;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONtype(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field type of WikidataAPIEntityJSON is not a string.");
        settype(json_string.getData());
      }


    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field id of WikidataAPIEntityJSON is not a string.");
        setid(json_string.getData());
      }


    private void  fromJSONaliases(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field aliases of WikidataAPIEntityJSON is not an object.");
        setaliases(json_value.object_value());
      }


    private void  fromJSONlabels(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field labels of WikidataAPIEntityJSON is not an object.");
        setlabels(json_value.object_value());
      }


    private void  fromJSONdescriptions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field descriptions of WikidataAPIEntityJSON is not an object.");
        setdescriptions(json_value.object_value());
      }


    private void  fromJSONclaims(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field claims of WikidataAPIEntityJSON is not an object.");
        setclaims(json_value.object_value());
      }


    private void  fromJSONsitelinks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field sitelinks of WikidataAPIEntityJSON is not an object.");
        setsitelinks(json_value.object_value());
      }


    public WikidataAPIEntityJSON()
      {
        flagHastype = false;
        flagHasid = false;
        flagHasaliases = false;
        flagHaslabels = false;
        flagHasdescriptions = false;
        flagHasclaims = false;
        flagHassitelinks = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasid()
      {
        return flagHasid;
      }

    public string  getid()
      {
        Debug.Assert(flagHasid);
        return storeid;
      }

    public bool  hasaliases()
      {
        return flagHasaliases;
      }

    public JSONObjectValue   getaliases()
      {
        Debug.Assert(flagHasaliases);
        return storealiases;
      }

    public bool  haslabels()
      {
        return flagHaslabels;
      }

    public JSONObjectValue   getlabels()
      {
        Debug.Assert(flagHaslabels);
        return storelabels;
      }

    public bool  hasdescriptions()
      {
        return flagHasdescriptions;
      }

    public JSONObjectValue   getdescriptions()
      {
        Debug.Assert(flagHasdescriptions);
        return storedescriptions;
      }

    public bool  hasclaims()
      {
        return flagHasclaims;
      }

    public JSONObjectValue   getclaims()
      {
        Debug.Assert(flagHasclaims);
        return storeclaims;
      }

    public bool  hassitelinks()
      {
        return flagHassitelinks;
      }

    public JSONObjectValue   getsitelinks()
      {
        Debug.Assert(flagHassitelinks);
        return storesitelinks;
      }


    public virtual int extraWikidataAPIEntityComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWikidataAPIEntityComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWikidataAPIEntityComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWikidataAPIEntityLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setid(string new_value)
      {
        flagHasid = true;
        storeid = new_value;
      }
    public void unsetid()
      {
        flagHasid = false;
      }
    public void setaliases(JSONObjectValue  new_value)
      {
        if (flagHasaliases)
          {
          }
        flagHasaliases = true;
        storealiases = new_value;
      }
    public void unsetaliases()
      {
        if (flagHasaliases)
          {
          }
        flagHasaliases = false;
      }
    public void setlabels(JSONObjectValue  new_value)
      {
        if (flagHaslabels)
          {
          }
        flagHaslabels = true;
        storelabels = new_value;
      }
    public void unsetlabels()
      {
        if (flagHaslabels)
          {
          }
        flagHaslabels = false;
      }
    public void setdescriptions(JSONObjectValue  new_value)
      {
        if (flagHasdescriptions)
          {
          }
        flagHasdescriptions = true;
        storedescriptions = new_value;
      }
    public void unsetdescriptions()
      {
        if (flagHasdescriptions)
          {
          }
        flagHasdescriptions = false;
      }
    public void setclaims(JSONObjectValue  new_value)
      {
        if (flagHasclaims)
          {
          }
        flagHasclaims = true;
        storeclaims = new_value;
      }
    public void unsetclaims()
      {
        if (flagHasclaims)
          {
          }
        flagHasclaims = false;
      }
    public void setsitelinks(JSONObjectValue  new_value)
      {
        if (flagHassitelinks)
          {
          }
        flagHassitelinks = true;
        storesitelinks = new_value;
      }
    public void unsetsitelinks()
      {
        if (flagHassitelinks)
          {
          }
        flagHassitelinks = false;
      }

    public virtual void extraWikidataAPIEntityAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWikidataAPIEntitySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWikidataAPIEntityLookup(key);
        if (old_field == null)
          {
            extraWikidataAPIEntityAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHastype);
        if (flagHastype)
          {
            handler.start_pair("type");
            handler.string_value(storetype);
          }
        Debug.Assert(partial_allowed || flagHasid);
        if (flagHasid)
          {
            handler.start_pair("id");
            handler.string_value(storeid);
          }
        if (flagHasaliases)
          {
            handler.start_pair("aliases");
            storealiases.write(handler);
          }
        if (flagHaslabels)
          {
            handler.start_pair("labels");
            storelabels.write(handler);
          }
        if (flagHasdescriptions)
          {
            handler.start_pair("descriptions");
            storedescriptions.write(handler);
          }
        if (flagHasclaims)
          {
            handler.start_pair("claims");
            storeclaims.write(handler);
          }
        if (flagHassitelinks)
          {
            handler.start_pair("sitelinks");
            storesitelinks.write(handler);
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
        if (!(hasid()))
          {
            return "When parsing the object for %what%, the \"id\" field was missing.";
          }
        return null;
      }

    public static WikidataAPIEntityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPIEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIEntity", ignore_extras);
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
    public static WikidataAPIEntityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WikidataAPIEntityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPIEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIEntity", ignore_extras);
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
    public static WikidataAPIEntityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WikidataAPIEntityJSON from_text(string text, bool ignore_extras)
      {
        WikidataAPIEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIEntity", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WikidataAPIEntityJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WikidataAPIEntityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WikidataAPIEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIEntity", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratortype;
        private JSONHoldingStringGenerator fieldGeneratorid;
        private JSONHoldingObjectValueGenerator fieldGeneratoraliases;
        private JSONHoldingObjectValueGenerator fieldGeneratorlabels;
        private JSONHoldingObjectValueGenerator fieldGeneratordescriptions;
        private JSONHoldingObjectValueGenerator fieldGeneratorclaims;
        private JSONHoldingObjectValueGenerator fieldGeneratorsitelinks;
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
            WikidataAPIEntityJSON result = new WikidataAPIEntityJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWikidataAPIEntityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WikidataAPIEntityJSON result)
          {
            if (fieldGeneratortype.have_value)
              {
                result.settype(fieldGeneratortype.value);
                fieldGeneratortype.have_value = false;
              }
            else if ((!(result.hastype())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"type\" field was missing.");
              }
            if (fieldGeneratorid.have_value)
              {
                result.setid(fieldGeneratorid.value);
                fieldGeneratorid.have_value = false;
              }
            else if ((!(result.hasid())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"id\" field was missing.");
              }
            if (fieldGeneratoraliases.have_value)
              {
                result.setaliases(fieldGeneratoraliases.value);
                fieldGeneratoraliases.have_value = false;
              }
            if (fieldGeneratorlabels.have_value)
              {
                result.setlabels(fieldGeneratorlabels.value);
                fieldGeneratorlabels.have_value = false;
              }
            if (fieldGeneratordescriptions.have_value)
              {
                result.setdescriptions(fieldGeneratordescriptions.value);
                fieldGeneratordescriptions.have_value = false;
              }
            if (fieldGeneratorclaims.have_value)
              {
                result.setclaims(fieldGeneratorclaims.value);
                fieldGeneratorclaims.have_value = false;
              }
            if (fieldGeneratorsitelinks.have_value)
              {
                result.setsitelinks(fieldGeneratorsitelinks.value);
                fieldGeneratorsitelinks.have_value = false;
              }
          }
        protected abstract void handle_result(WikidataAPIEntityJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    if ((String.Compare(field_name, 1, "liases", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratoraliases;
                    break;
                case 'c':
                    if ((String.Compare(field_name, 1, "laims", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorclaims;
                    break;
                case 'd':
                    if ((String.Compare(field_name, 1, "escriptions", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratordescriptions;
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorid;
                    break;
                case 'l':
                    if ((String.Compare(field_name, 1, "abels", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorlabels;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "itelinks", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorsitelinks;
                    break;
                case 't':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratortype;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratortype = new JSONHoldingStringGenerator("field \"type\" of the WikidataAPIEntity class");
            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the WikidataAPIEntity class");
            fieldGeneratoraliases = new JSONHoldingObjectValueGenerator("field \"aliases\" of the WikidataAPIEntity class");
            fieldGeneratorlabels = new JSONHoldingObjectValueGenerator("field \"labels\" of the WikidataAPIEntity class");
            fieldGeneratordescriptions = new JSONHoldingObjectValueGenerator("field \"descriptions\" of the WikidataAPIEntity class");
            fieldGeneratorclaims = new JSONHoldingObjectValueGenerator("field \"claims\" of the WikidataAPIEntity class");
            fieldGeneratorsitelinks = new JSONHoldingObjectValueGenerator("field \"sitelinks\" of the WikidataAPIEntity class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WikidataAPIEntity class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratortype = new JSONHoldingStringGenerator("field \"type\" of the WikidataAPIEntity class");
            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the WikidataAPIEntity class");
            fieldGeneratoraliases = new JSONHoldingObjectValueGenerator("field \"aliases\" of the WikidataAPIEntity class");
            fieldGeneratorlabels = new JSONHoldingObjectValueGenerator("field \"labels\" of the WikidataAPIEntity class");
            fieldGeneratordescriptions = new JSONHoldingObjectValueGenerator("field \"descriptions\" of the WikidataAPIEntity class");
            fieldGeneratorclaims = new JSONHoldingObjectValueGenerator("field \"claims\" of the WikidataAPIEntity class");
            fieldGeneratorsitelinks = new JSONHoldingObjectValueGenerator("field \"sitelinks\" of the WikidataAPIEntity class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WikidataAPIEntity class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratortype.reset();
            fieldGeneratorid.reset();
            fieldGeneratoraliases.reset();
            fieldGeneratorlabels.reset();
            fieldGeneratordescriptions.reset();
            fieldGeneratorclaims.reset();
            fieldGeneratorsitelinks.reset();
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
        protected override void handle_result(WikidataAPIEntityJSON  result)
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
        public WikidataAPIEntityJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WikidataAPIEntityJSON  result)
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
    protected virtual void handle_result(List<WikidataAPIEntityJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WikidataAPIEntityJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WikidataAPIEntityJSON>();
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
    public List<WikidataAPIEntityJSON> value;
  };
  };
