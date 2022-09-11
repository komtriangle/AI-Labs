/* file "WikidataAPIDatavalueWikibaseEntityIDJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WikidataAPIDatavalueWikibaseEntityIDJSON : WikidataAPIDatavalueJSON
  {
    public class TypevalueJSON : JSONBase
      {
        private bool flagHasentity_type;
        private string storeentity_type;
        private bool flagHasid;
        private string storeid;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONentity_type(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field entity_type of TypevalueJSON is not a string.");
            setentity_type(json_string.getData());
          }


        private void  fromJSONid(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field id of TypevalueJSON is not a string.");
            setid(json_string.getData());
          }


        public TypevalueJSON()
          {
            flagHasentity_type = false;
            flagHasid = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasentity_type()
          {
            return flagHasentity_type;
          }

        public string  getentity_type()
          {
            Debug.Assert(flagHasentity_type);
            return storeentity_type;
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


        public virtual int extraTypevalueComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypevalueComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypevalueComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypevalueLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setentity_type(string new_value)
          {
            flagHasentity_type = true;
            storeentity_type = new_value;
          }
        public void unsetentity_type()
          {
            flagHasentity_type = false;
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

        public virtual void extraTypevalueAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypevalueSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypevalueLookup(key);
            if (old_field == null)
              {
                extraTypevalueAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasentity_type);
            if (flagHasentity_type)
              {
                handler.start_pair("entity-type");
                handler.string_value(storeentity_type);
              }
            Debug.Assert(partial_allowed || flagHasid);
            if (flagHasid)
              {
                handler.start_pair("id");
                handler.string_value(storeid);
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
            if (!(hasentity_type()))
              {
                return "When parsing the object for %what%, the \"entity_type\" field was missing.";
              }
            if (!(hasid()))
              {
                return "When parsing the object for %what%, the \"id\" field was missing.";
              }
            return null;
          }

        public static TypevalueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypevalueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typevalue", ignore_extras);
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
        public static TypevalueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypevalueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypevalueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typevalue", ignore_extras);
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
        public static TypevalueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypevalueJSON from_text(string text, bool ignore_extras)
          {
            TypevalueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typevalue", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypevalueJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypevalueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypevalueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typevalue", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorentity_type;
            private JSONHoldingStringGenerator fieldGeneratorid;
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
                TypevalueJSON result = new TypevalueJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypevalueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypevalueJSON result)
              {
                if (fieldGeneratorentity_type.have_value)
                  {
                    result.setentity_type(fieldGeneratorentity_type.value);
                    fieldGeneratorentity_type.have_value = false;
                  }
                else if ((!(result.hasentity_type())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"entity-type\" field was missing.");
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
              }
            protected abstract void handle_result(TypevalueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'e':
                        if ((String.Compare(field_name, 1, "ntity-type", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorentity_type;
                        break;
                    case 'i':
                        if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                            return fieldGeneratorid;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorentity_type = new JSONHoldingStringGenerator("field \"entity-type\" of the Typevalue class");
                fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typevalue class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the Typevalue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorentity_type = new JSONHoldingStringGenerator("field \"entity-type\" of the Typevalue class");
                fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typevalue class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the Typevalue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorentity_type.reset();
                fieldGeneratorid.reset();
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
            protected override void handle_result(TypevalueJSON  result)
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
            public TypevalueJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypevalueJSON  result)
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
        protected virtual void handle_result(List<TypevalueJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypevalueJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypevalueJSON>();
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
        public List<TypevalueJSON> value;
      };
      };
    private bool flagHasvalue;
    private TypevalueJSON  storevalue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extravalueToJSON()
      {
        JSONValueHandler handler_value = new JSONValueHandler();
        storevalue.write_as_json(handler_value);
        return handler_value.result;
      }


    private void  fromJSONvalue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypevalueJSON convert_classy = TypevalueJSON.from_json(json_value, ignore_extras, true);
        setvalue(convert_classy);
      }


    public WikidataAPIDatavalueWikibaseEntityIDJSON()
      {
        flagHasvalue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  gettype()
      {
        return "wikibase-entityid";
      }

    public bool  hasvalue()
      {
        return flagHasvalue;
      }

    public TypevalueJSON   getvalue()
      {
        Debug.Assert(flagHasvalue);
        return storevalue;
      }


    public virtual int extraWikidataAPIDatavalueWikibaseEntityIDComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWikidataAPIDatavalueWikibaseEntityIDComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWikidataAPIDatavalueWikibaseEntityIDComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWikidataAPIDatavalueWikibaseEntityIDLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraWikidataAPIDatavalueComponentCount()
      {
        int result = 0;
        if (flagHasvalue)
            ++result;
        result += extraWikidataAPIDatavalueWikibaseEntityIDComponentCount();
        return result;
      }
    public override string extraWikidataAPIDatavalueComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasvalue)
          {
            if (remainder == 0)
                return "value";
            --remainder;
          }
        return extraWikidataAPIDatavalueWikibaseEntityIDComponentKey(remainder);
      }
    public override JSONValue extraWikidataAPIDatavalueComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasvalue)
          {
            if (remainder == 0)
                return extravalueToJSON();
            --remainder;
          }
        return extraWikidataAPIDatavalueWikibaseEntityIDComponentValue(remainder);
      }
    public override JSONValue extraWikidataAPIDatavalueLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "value", 0, 5, false) == 0) && (field_name.Length == 5))
            return (flagHasvalue ? extravalueToJSON() : null);
        return extraWikidataAPIDatavalueWikibaseEntityIDLookup(field_name);
      }

    public void setvalue(TypevalueJSON  new_value)
      {
        if (flagHasvalue)
          {
          }
        flagHasvalue = true;
        storevalue = new_value;
      }
    public void unsetvalue()
      {
        if (flagHasvalue)
          {
          }
        flagHasvalue = false;
      }

    public virtual void extraWikidataAPIDatavalueWikibaseEntityIDAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWikidataAPIDatavalueWikibaseEntityIDSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWikidataAPIDatavalueWikibaseEntityIDLookup(key);
        if (old_field == null)
          {
            extraWikidataAPIDatavalueWikibaseEntityIDAppendPair(key, new_component);
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
    public override void extraWikidataAPIDatavalueAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "value", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONvalue(new_component, false);
            return;
            }
        extraWikidataAPIDatavalueWikibaseEntityIDAppendPair(key, new_component);
      }
    public override void extraWikidataAPIDatavalueSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "value", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONvalue(new_component, false);
            return;
            }
        extraWikidataAPIDatavalueWikibaseEntityIDSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasvalue);
        if (flagHasvalue)
          {
            handler.start_pair("value");
            if (partial_allowed)
                storevalue.write_partial_as_json(handler);
            else
                storevalue.write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasvalue()))
          {
            return "When parsing the object for %what%, the \"value\" field was missing.";
          }
        return null;
      }

    public static new WikidataAPIDatavalueWikibaseEntityIDJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPIDatavalueWikibaseEntityIDJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueWikibaseEntityID", ignore_extras);
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
    public static new WikidataAPIDatavalueWikibaseEntityIDJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WikidataAPIDatavalueWikibaseEntityIDJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPIDatavalueWikibaseEntityIDJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueWikibaseEntityID", ignore_extras);
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
    public static new WikidataAPIDatavalueWikibaseEntityIDJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WikidataAPIDatavalueWikibaseEntityIDJSON from_text(string text, bool ignore_extras)
      {
        WikidataAPIDatavalueWikibaseEntityIDJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueWikibaseEntityID", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WikidataAPIDatavalueWikibaseEntityIDJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new WikidataAPIDatavalueWikibaseEntityIDJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WikidataAPIDatavalueWikibaseEntityIDJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueWikibaseEntityID", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : WikidataAPIDatavalueJSON.Generator
      {
        private TypevalueJSON.HoldingGenerator fieldGeneratorvalue;
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
            if (!(getWikidataAPIDatavalueJSONKey().Equals("wikibase-entityid")))
                throw new Exception("The key field has a value other than `wikibase-entityid'.");
            WikidataAPIDatavalueWikibaseEntityIDJSON result = new WikidataAPIDatavalueWikibaseEntityIDJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWikidataAPIDatavalueWikibaseEntityIDAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(WikidataAPIDatavalueJSON new_result)
          {
            handle_result((WikidataAPIDatavalueWikibaseEntityIDJSON )new_result);
          }
        protected void finish(WikidataAPIDatavalueWikibaseEntityIDJSON result)
          {
            if (fieldGeneratorvalue.have_value)
              {
                result.setvalue(fieldGeneratorvalue.value);
                fieldGeneratorvalue.have_value = false;
              }
            else if ((!(result.hasvalue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"value\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(WikidataAPIDatavalueWikibaseEntityIDJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "value", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorvalue;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorvalue = new TypevalueJSON.HoldingGenerator("field \"value\" of the WikidataAPIDatavalueWikibaseEntityID class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WikidataAPIDatavalueWikibaseEntityID class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorvalue = new TypevalueJSON.HoldingGenerator("field \"value\" of the WikidataAPIDatavalueWikibaseEntityID class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WikidataAPIDatavalueWikibaseEntityID class");
          }

        public override void reset()
          {
            fieldGeneratorvalue.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(WikidataAPIDatavalueWikibaseEntityIDJSON  result)
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
        public WikidataAPIDatavalueWikibaseEntityIDJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WikidataAPIDatavalueWikibaseEntityIDJSON  result)
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
    protected virtual void handle_result(List<WikidataAPIDatavalueWikibaseEntityIDJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WikidataAPIDatavalueWikibaseEntityIDJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WikidataAPIDatavalueWikibaseEntityIDJSON>();
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
    public List<WikidataAPIDatavalueWikibaseEntityIDJSON> value;
  };
  };
