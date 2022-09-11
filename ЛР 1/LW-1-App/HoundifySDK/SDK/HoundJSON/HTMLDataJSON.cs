/* file "HTMLDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HTMLDataJSON : JSONBase
  {
    public class TypeHTMLHeadJSON : JSONBase
      {
        private bool flagHasCSS;
        private string storeCSS;
        private bool flagHasJS;
        private string storeJS;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONCSS(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field CSS of TypeHTMLHeadJSON is not a string.");
            setCSS(json_string.getData());
          }


        private void  fromJSONJS(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field JS of TypeHTMLHeadJSON is not a string.");
            setJS(json_string.getData());
          }


        public TypeHTMLHeadJSON()
          {
            flagHasCSS = false;
            flagHasJS = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasCSS()
          {
            return flagHasCSS;
          }

        public string  getCSS()
          {
            Debug.Assert(flagHasCSS);
            return storeCSS;
          }

        public bool  hasJS()
          {
            return flagHasJS;
          }

        public string  getJS()
          {
            Debug.Assert(flagHasJS);
            return storeJS;
          }


        public virtual int extraTypeHTMLHeadComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeHTMLHeadComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeHTMLHeadComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeHTMLHeadLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setCSS(string new_value)
          {
            flagHasCSS = true;
            storeCSS = new_value;
          }
        public void unsetCSS()
          {
            flagHasCSS = false;
          }
        public void setJS(string new_value)
          {
            flagHasJS = true;
            storeJS = new_value;
          }
        public void unsetJS()
          {
            flagHasJS = false;
          }

        public virtual void extraTypeHTMLHeadAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeHTMLHeadSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeHTMLHeadLookup(key);
            if (old_field == null)
              {
                extraTypeHTMLHeadAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasCSS);
            if (flagHasCSS)
              {
                handler.start_pair("CSS");
                handler.string_value(storeCSS);
              }
            Debug.Assert(partial_allowed || flagHasJS);
            if (flagHasJS)
              {
                handler.start_pair("JS");
                handler.string_value(storeJS);
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
            if (!(hasCSS()))
              {
                return "When parsing the object for %what%, the \"CSS\" field was missing.";
              }
            if (!(hasJS()))
              {
                return "When parsing the object for %what%, the \"JS\" field was missing.";
              }
            return null;
          }

        public static TypeHTMLHeadJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHTMLHeadJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHTMLHead", ignore_extras);
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
        public static TypeHTMLHeadJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHTMLHeadJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHTMLHeadJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHTMLHead", ignore_extras);
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
        public static TypeHTMLHeadJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHTMLHeadJSON from_text(string text, bool ignore_extras)
          {
            TypeHTMLHeadJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHTMLHead", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeHTMLHeadJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeHTMLHeadJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeHTMLHeadJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHTMLHead", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorCSS;
            private JSONHoldingStringGenerator fieldGeneratorJS;
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
                TypeHTMLHeadJSON result = new TypeHTMLHeadJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeHTMLHeadAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeHTMLHeadJSON result)
              {
                if (fieldGeneratorCSS.have_value)
                  {
                    result.setCSS(fieldGeneratorCSS.value);
                    fieldGeneratorCSS.have_value = false;
                  }
                else if ((!(result.hasCSS())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"CSS\" field was missing.");
                  }
                if (fieldGeneratorJS.have_value)
                  {
                    result.setJS(fieldGeneratorJS.value);
                    fieldGeneratorJS.have_value = false;
                  }
                else if ((!(result.hasJS())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"JS\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeHTMLHeadJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "SS", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorCSS;
                        break;
                    case 'J':
                        if ((String.Compare(field_name, 1, "S", 0, 1, false) == 0) && (field_name.Length == 2))
                            return fieldGeneratorJS;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorCSS = new JSONHoldingStringGenerator("field \"CSS\" of the TypeHTMLHead class");
                fieldGeneratorJS = new JSONHoldingStringGenerator("field \"JS\" of the TypeHTMLHead class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeHTMLHead class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorCSS = new JSONHoldingStringGenerator("field \"CSS\" of the TypeHTMLHead class");
                fieldGeneratorJS = new JSONHoldingStringGenerator("field \"JS\" of the TypeHTMLHead class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeHTMLHead class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorCSS.reset();
                fieldGeneratorJS.reset();
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
            protected override void handle_result(TypeHTMLHeadJSON  result)
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
            public TypeHTMLHeadJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeHTMLHeadJSON  result)
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
        protected virtual void handle_result(List<TypeHTMLHeadJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeHTMLHeadJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeHTMLHeadJSON>();
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
        public List<TypeHTMLHeadJSON> value;
      };
      };
    private bool flagHasHTMLHead;
    private TypeHTMLHeadJSON  storeHTMLHead;
    private bool flagHasSmallScreenHTML;
    private string storeSmallScreenHTML;
    private bool flagHasLargeScreenHTML;
    private string storeLargeScreenHTML;
    private bool flagHasSmallScreenURL;
    private string storeSmallScreenURL;
    private bool flagHasLargeScreenURL;
    private string storeLargeScreenURL;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONHTMLHead(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeHTMLHeadJSON convert_classy = TypeHTMLHeadJSON.from_json(json_value, ignore_extras, true);
        setHTMLHead(convert_classy);
      }


    private void  fromJSONSmallScreenHTML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SmallScreenHTML of HTMLDataJSON is not a string.");
        setSmallScreenHTML(json_string.getData());
      }


    private void  fromJSONLargeScreenHTML(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LargeScreenHTML of HTMLDataJSON is not a string.");
        setLargeScreenHTML(json_string.getData());
      }


    private void  fromJSONSmallScreenURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SmallScreenURL of HTMLDataJSON is not a string.");
        setSmallScreenURL(json_string.getData());
      }


    private void  fromJSONLargeScreenURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LargeScreenURL of HTMLDataJSON is not a string.");
        setLargeScreenURL(json_string.getData());
      }


    public HTMLDataJSON()
      {
        flagHasHTMLHead = false;
        flagHasSmallScreenHTML = false;
        flagHasLargeScreenHTML = false;
        flagHasSmallScreenURL = false;
        flagHasLargeScreenURL = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasHTMLHead()
      {
        return flagHasHTMLHead;
      }

    public TypeHTMLHeadJSON   getHTMLHead()
      {
        Debug.Assert(flagHasHTMLHead);
        return storeHTMLHead;
      }

    public bool  hasSmallScreenHTML()
      {
        return flagHasSmallScreenHTML;
      }

    public string  getSmallScreenHTML()
      {
        Debug.Assert(flagHasSmallScreenHTML);
        return storeSmallScreenHTML;
      }

    public bool  hasLargeScreenHTML()
      {
        return flagHasLargeScreenHTML;
      }

    public string  getLargeScreenHTML()
      {
        Debug.Assert(flagHasLargeScreenHTML);
        return storeLargeScreenHTML;
      }

    public bool  hasSmallScreenURL()
      {
        return flagHasSmallScreenURL;
      }

    public string  getSmallScreenURL()
      {
        Debug.Assert(flagHasSmallScreenURL);
        return storeSmallScreenURL;
      }

    public bool  hasLargeScreenURL()
      {
        return flagHasLargeScreenURL;
      }

    public string  getLargeScreenURL()
      {
        Debug.Assert(flagHasLargeScreenURL);
        return storeLargeScreenURL;
      }


    public virtual int extraHTMLDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHTMLDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHTMLDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHTMLDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setHTMLHead(TypeHTMLHeadJSON  new_value)
      {
        if (flagHasHTMLHead)
          {
          }
        flagHasHTMLHead = true;
        storeHTMLHead = new_value;
      }
    public void unsetHTMLHead()
      {
        if (flagHasHTMLHead)
          {
          }
        flagHasHTMLHead = false;
      }
    public void setSmallScreenHTML(string new_value)
      {
        flagHasSmallScreenHTML = true;
        storeSmallScreenHTML = new_value;
      }
    public void unsetSmallScreenHTML()
      {
        flagHasSmallScreenHTML = false;
      }
    public void setLargeScreenHTML(string new_value)
      {
        flagHasLargeScreenHTML = true;
        storeLargeScreenHTML = new_value;
      }
    public void unsetLargeScreenHTML()
      {
        flagHasLargeScreenHTML = false;
      }
    public void setSmallScreenURL(string new_value)
      {
        flagHasSmallScreenURL = true;
        storeSmallScreenURL = new_value;
      }
    public void unsetSmallScreenURL()
      {
        flagHasSmallScreenURL = false;
      }
    public void setLargeScreenURL(string new_value)
      {
        flagHasLargeScreenURL = true;
        storeLargeScreenURL = new_value;
      }
    public void unsetLargeScreenURL()
      {
        flagHasLargeScreenURL = false;
      }

    public virtual void extraHTMLDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHTMLDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHTMLDataLookup(key);
        if (old_field == null)
          {
            extraHTMLDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasHTMLHead);
        if (flagHasHTMLHead)
          {
            handler.start_pair("HTMLHead");
            if (partial_allowed)
                storeHTMLHead.write_partial_as_json(handler);
            else
                storeHTMLHead.write_as_json(handler);
          }
        if (flagHasSmallScreenHTML)
          {
            handler.start_pair("SmallScreenHTML");
            handler.string_value(storeSmallScreenHTML);
          }
        if (flagHasLargeScreenHTML)
          {
            handler.start_pair("LargeScreenHTML");
            handler.string_value(storeLargeScreenHTML);
          }
        if (flagHasSmallScreenURL)
          {
            handler.start_pair("SmallScreenURL");
            handler.string_value(storeSmallScreenURL);
          }
        if (flagHasLargeScreenURL)
          {
            handler.start_pair("LargeScreenURL");
            handler.string_value(storeLargeScreenURL);
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
        if (!(hasHTMLHead()))
          {
            return "When parsing the object for %what%, the \"HTMLHead\" field was missing.";
          }
        return null;
      }

    public static HTMLDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HTMLDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HTMLData", ignore_extras);
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
    public static HTMLDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HTMLDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HTMLDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HTMLData", ignore_extras);
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
    public static HTMLDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HTMLDataJSON from_text(string text, bool ignore_extras)
      {
        HTMLDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HTMLData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HTMLDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HTMLDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HTMLDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HTMLData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeHTMLHeadJSON.HoldingGenerator fieldGeneratorHTMLHead;
        private JSONHoldingStringGenerator fieldGeneratorSmallScreenHTML;
        private JSONHoldingStringGenerator fieldGeneratorLargeScreenHTML;
        private JSONHoldingStringGenerator fieldGeneratorSmallScreenURL;
        private JSONHoldingStringGenerator fieldGeneratorLargeScreenURL;
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
            HTMLDataJSON result = new HTMLDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHTMLDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HTMLDataJSON result)
          {
            if (fieldGeneratorHTMLHead.have_value)
              {
                result.setHTMLHead(fieldGeneratorHTMLHead.value);
                fieldGeneratorHTMLHead.have_value = false;
              }
            else if ((!(result.hasHTMLHead())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HTMLHead\" field was missing.");
              }
            if (fieldGeneratorSmallScreenHTML.have_value)
              {
                result.setSmallScreenHTML(fieldGeneratorSmallScreenHTML.value);
                fieldGeneratorSmallScreenHTML.have_value = false;
              }
            if (fieldGeneratorLargeScreenHTML.have_value)
              {
                result.setLargeScreenHTML(fieldGeneratorLargeScreenHTML.value);
                fieldGeneratorLargeScreenHTML.have_value = false;
              }
            if (fieldGeneratorSmallScreenURL.have_value)
              {
                result.setSmallScreenURL(fieldGeneratorSmallScreenURL.value);
                fieldGeneratorSmallScreenURL.have_value = false;
              }
            if (fieldGeneratorLargeScreenURL.have_value)
              {
                result.setLargeScreenURL(fieldGeneratorLargeScreenURL.value);
                fieldGeneratorLargeScreenURL.have_value = false;
              }
          }
        protected abstract void handle_result(HTMLDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'H':
                    if ((String.Compare(field_name, 1, "TMLHead", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorHTMLHead;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "argeScreen", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'H':
                                if ((String.Compare(field_name, 12, "TML", 0, 3, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorLargeScreenHTML;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 12, "RL", 0, 2, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorLargeScreenURL;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "mallScreen", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'H':
                                if ((String.Compare(field_name, 12, "TML", 0, 3, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorSmallScreenHTML;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 12, "RL", 0, 2, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorSmallScreenURL;
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
            fieldGeneratorHTMLHead = new TypeHTMLHeadJSON.HoldingGenerator("field \"HTMLHead\" of the HTMLData class", ignore_extras);
            fieldGeneratorSmallScreenHTML = new JSONHoldingStringGenerator("field \"SmallScreenHTML\" of the HTMLData class");
            fieldGeneratorLargeScreenHTML = new JSONHoldingStringGenerator("field \"LargeScreenHTML\" of the HTMLData class");
            fieldGeneratorSmallScreenURL = new JSONHoldingStringGenerator("field \"SmallScreenURL\" of the HTMLData class");
            fieldGeneratorLargeScreenURL = new JSONHoldingStringGenerator("field \"LargeScreenURL\" of the HTMLData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HTMLData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHTMLHead = new TypeHTMLHeadJSON.HoldingGenerator("field \"HTMLHead\" of the HTMLData class", false);
            fieldGeneratorSmallScreenHTML = new JSONHoldingStringGenerator("field \"SmallScreenHTML\" of the HTMLData class");
            fieldGeneratorLargeScreenHTML = new JSONHoldingStringGenerator("field \"LargeScreenHTML\" of the HTMLData class");
            fieldGeneratorSmallScreenURL = new JSONHoldingStringGenerator("field \"SmallScreenURL\" of the HTMLData class");
            fieldGeneratorLargeScreenURL = new JSONHoldingStringGenerator("field \"LargeScreenURL\" of the HTMLData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HTMLData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHTMLHead.reset();
            fieldGeneratorSmallScreenHTML.reset();
            fieldGeneratorLargeScreenHTML.reset();
            fieldGeneratorSmallScreenURL.reset();
            fieldGeneratorLargeScreenURL.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorHTMLHead.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorHTMLHead.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HTMLDataJSON  result)
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
        public HTMLDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HTMLDataJSON  result)
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
    protected virtual void handle_result(List<HTMLDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HTMLDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HTMLDataJSON>();
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
    public List<HTMLDataJSON> value;
  };
  };
