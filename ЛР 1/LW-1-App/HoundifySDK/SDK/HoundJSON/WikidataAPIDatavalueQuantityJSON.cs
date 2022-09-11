/* file "WikidataAPIDatavalueQuantityJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WikidataAPIDatavalueQuantityJSON : WikidataAPIDatavalueJSON
  {
    public class TypevalueJSON : JSONBase
      {
        private bool flagHasamount;
        private string storeamount;
        private bool flagHasunit;
        private string storeunit;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONamount(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field amount of TypevalueJSON is not a string.");
            setamount(json_string.getData());
          }


        private void  fromJSONunit(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field unit of TypevalueJSON is not a string.");
            setunit(json_string.getData());
          }


        public TypevalueJSON()
          {
            flagHasamount = false;
            flagHasunit = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasamount()
          {
            return flagHasamount;
          }

        public string  getamount()
          {
            Debug.Assert(flagHasamount);
            return storeamount;
          }

        public bool  hasunit()
          {
            return flagHasunit;
          }

        public string  getunit()
          {
            Debug.Assert(flagHasunit);
            return storeunit;
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

        public void setamount(string new_value)
          {
            flagHasamount = true;
            storeamount = new_value;
          }
        public void unsetamount()
          {
            flagHasamount = false;
          }
        public void setunit(string new_value)
          {
            flagHasunit = true;
            storeunit = new_value;
          }
        public void unsetunit()
          {
            flagHasunit = false;
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
            Debug.Assert(partial_allowed || flagHasamount);
            if (flagHasamount)
              {
                handler.start_pair("amount");
                handler.string_value(storeamount);
              }
            Debug.Assert(partial_allowed || flagHasunit);
            if (flagHasunit)
              {
                handler.start_pair("unit");
                handler.string_value(storeunit);
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
            if (!(hasamount()))
              {
                return "When parsing the object for %what%, the \"amount\" field was missing.";
              }
            if (!(hasunit()))
              {
                return "When parsing the object for %what%, the \"unit\" field was missing.";
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
            private JSONHoldingStringGenerator fieldGeneratoramount;
            private JSONHoldingStringGenerator fieldGeneratorunit;
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
                if (fieldGeneratoramount.have_value)
                  {
                    result.setamount(fieldGeneratoramount.value);
                    fieldGeneratoramount.have_value = false;
                  }
                else if ((!(result.hasamount())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"amount\" field was missing.");
                  }
                if (fieldGeneratorunit.have_value)
                  {
                    result.setunit(fieldGeneratorunit.value);
                    fieldGeneratorunit.have_value = false;
                  }
                else if ((!(result.hasunit())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"unit\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypevalueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 1, "mount", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratoramount;
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorunit;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratoramount = new JSONHoldingStringGenerator("field \"amount\" of the Typevalue class");
                fieldGeneratorunit = new JSONHoldingStringGenerator("field \"unit\" of the Typevalue class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the Typevalue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratoramount = new JSONHoldingStringGenerator("field \"amount\" of the Typevalue class");
                fieldGeneratorunit = new JSONHoldingStringGenerator("field \"unit\" of the Typevalue class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the Typevalue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratoramount.reset();
                fieldGeneratorunit.reset();
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


    public WikidataAPIDatavalueQuantityJSON()
      {
        flagHasvalue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  gettype()
      {
        return "quantity";
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


    public virtual int extraWikidataAPIDatavalueQuantityComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWikidataAPIDatavalueQuantityComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWikidataAPIDatavalueQuantityComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWikidataAPIDatavalueQuantityLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraWikidataAPIDatavalueComponentCount()
      {
        int result = 0;
        if (flagHasvalue)
            ++result;
        result += extraWikidataAPIDatavalueQuantityComponentCount();
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
        return extraWikidataAPIDatavalueQuantityComponentKey(remainder);
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
        return extraWikidataAPIDatavalueQuantityComponentValue(remainder);
      }
    public override JSONValue extraWikidataAPIDatavalueLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "value", 0, 5, false) == 0) && (field_name.Length == 5))
            return (flagHasvalue ? extravalueToJSON() : null);
        return extraWikidataAPIDatavalueQuantityLookup(field_name);
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

    public virtual void extraWikidataAPIDatavalueQuantityAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWikidataAPIDatavalueQuantitySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWikidataAPIDatavalueQuantityLookup(key);
        if (old_field == null)
          {
            extraWikidataAPIDatavalueQuantityAppendPair(key, new_component);
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
        extraWikidataAPIDatavalueQuantityAppendPair(key, new_component);
      }
    public override void extraWikidataAPIDatavalueSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "value", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONvalue(new_component, false);
            return;
            }
        extraWikidataAPIDatavalueQuantitySetField(key, new_component);
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

    public static new WikidataAPIDatavalueQuantityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPIDatavalueQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueQuantity", ignore_extras);
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
    public static new WikidataAPIDatavalueQuantityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WikidataAPIDatavalueQuantityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPIDatavalueQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueQuantity", ignore_extras);
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
    public static new WikidataAPIDatavalueQuantityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WikidataAPIDatavalueQuantityJSON from_text(string text, bool ignore_extras)
      {
        WikidataAPIDatavalueQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueQuantity", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WikidataAPIDatavalueQuantityJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new WikidataAPIDatavalueQuantityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WikidataAPIDatavalueQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueQuantity", ignore_extras);
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
            if (!(getWikidataAPIDatavalueJSONKey().Equals("quantity")))
                throw new Exception("The key field has a value other than `quantity'.");
            WikidataAPIDatavalueQuantityJSON result = new WikidataAPIDatavalueQuantityJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWikidataAPIDatavalueQuantityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(WikidataAPIDatavalueJSON new_result)
          {
            handle_result((WikidataAPIDatavalueQuantityJSON )new_result);
          }
        protected void finish(WikidataAPIDatavalueQuantityJSON result)
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
        protected abstract void handle_result(WikidataAPIDatavalueQuantityJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "value", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorvalue;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorvalue = new TypevalueJSON.HoldingGenerator("field \"value\" of the WikidataAPIDatavalueQuantity class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WikidataAPIDatavalueQuantity class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorvalue = new TypevalueJSON.HoldingGenerator("field \"value\" of the WikidataAPIDatavalueQuantity class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WikidataAPIDatavalueQuantity class");
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
        protected override void handle_result(WikidataAPIDatavalueQuantityJSON  result)
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
        public WikidataAPIDatavalueQuantityJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WikidataAPIDatavalueQuantityJSON  result)
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
    protected virtual void handle_result(List<WikidataAPIDatavalueQuantityJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WikidataAPIDatavalueQuantityJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WikidataAPIDatavalueQuantityJSON>();
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
    public List<WikidataAPIDatavalueQuantityJSON> value;
  };
  };
