/* file "MultiColumnTableTemplateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


public class MultiColumnTableTemplateJSON : TemplateJSON
  {
    public static Regex expressionColumnStretch = new Regex("^((\\*)|([0-3]((,[0-3])*)))$");
    public class TypeHeaderJSON : JSONBase
      {
        private bool flagHasText;
        private string storeText;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONText(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Text of TypeHeaderJSON is not a string.");
            setText(json_string.getData());
          }


        public TypeHeaderJSON()
          {
            flagHasText = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasText()
          {
            return flagHasText;
          }

        public string  getText()
          {
            Debug.Assert(flagHasText);
            return storeText;
          }


        public virtual int extraTypeHeaderComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeHeaderComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeHeaderComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeHeaderLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setText(string new_value)
          {
            flagHasText = true;
            storeText = new_value;
          }
        public void unsetText()
          {
            flagHasText = false;
          }

        public virtual void extraTypeHeaderAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeHeaderSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeHeaderLookup(key);
            if (old_field == null)
              {
                extraTypeHeaderAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasText);
            if (flagHasText)
              {
                handler.start_pair("Text");
                handler.string_value(storeText);
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
            if ((!allow_unpolished) && !(hasText()))
              {
                return "When parsing the object for %what%, the \"Text\" field was missing.";
              }
            return null;
          }

        public static TypeHeaderJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHeaderJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeader", ignore_extras);
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
        public static TypeHeaderJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHeaderJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHeaderJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeader", ignore_extras);
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
        public static TypeHeaderJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHeaderJSON from_text(string text, bool ignore_extras)
          {
            TypeHeaderJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeader", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeHeaderJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeHeaderJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeHeaderJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeader", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorText;
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
                TypeHeaderJSON result = new TypeHeaderJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeHeaderAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeHeaderJSON result)
              {
                if (fieldGeneratorText.have_value)
                  {
                    result.setText(fieldGeneratorText.value);
                    fieldGeneratorText.have_value = false;
                  }
                else if ((!(result.hasText())) && (!allow_unpolished) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Text\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeHeaderJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Text", 0, 4, false) == 0) && (field_name.Length == 4))
                    return fieldGeneratorText;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeHeader class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeHeader class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeHeader class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeHeader class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorText.reset();
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
            protected override void handle_result(TypeHeaderJSON  result)
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
            public TypeHeaderJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeHeaderJSON  result)
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
        protected virtual void handle_result(List<TypeHeaderJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeHeaderJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeHeaderJSON>();
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
        public List<TypeHeaderJSON> value;
      };
      };
    public class TypeContentRowsJSON : JSONBase
      {
        public class TypeColumnsJSON : JSONBase
          {
            private bool flagHasText;
            private string storeText;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONText(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Text of TypeColumnsJSON is not a string.");
                setText(json_string.getData());
              }


            public TypeColumnsJSON()
              {
                flagHasText = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasText()
              {
                return flagHasText;
              }

            public string  getText()
              {
                Debug.Assert(flagHasText);
                return storeText;
              }


            public virtual int extraTypeColumnsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeColumnsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeColumnsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeColumnsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setText(string new_value)
              {
                flagHasText = true;
                storeText = new_value;
              }
            public void unsetText()
              {
                flagHasText = false;
              }

            public virtual void extraTypeColumnsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeColumnsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeColumnsLookup(key);
                if (old_field == null)
                  {
                    extraTypeColumnsAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasText);
                if (flagHasText)
                  {
                    handler.start_pair("Text");
                    handler.string_value(storeText);
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
                if ((!allow_unpolished) && !(hasText()))
                  {
                    return "When parsing the object for %what%, the \"Text\" field was missing.";
                  }
                return null;
              }

            public static TypeColumnsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeColumnsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeColumns", ignore_extras);
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
            public static TypeColumnsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeColumnsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeColumnsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeColumns", ignore_extras);
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
            public static TypeColumnsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeColumnsJSON from_text(string text, bool ignore_extras)
              {
                TypeColumnsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeColumns", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeColumnsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeColumnsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeColumnsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeColumns", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorText;
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
                    TypeColumnsJSON result = new TypeColumnsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeColumnsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeColumnsJSON result)
                  {
                    if (fieldGeneratorText.have_value)
                      {
                        result.setText(fieldGeneratorText.value);
                        fieldGeneratorText.have_value = false;
                      }
                    else if ((!(result.hasText())) && (!allow_unpolished) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Text\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeColumnsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Text", 0, 4, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorText;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeColumns class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeColumns class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeColumns class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeColumns class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorText.reset();
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
                protected override void handle_result(TypeColumnsJSON  result)
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
                public TypeColumnsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeColumnsJSON  result)
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
            protected virtual void handle_result(List<TypeColumnsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeColumnsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeColumnsJSON>();
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
            public List<TypeColumnsJSON> value;
          };
          };
        private bool flagHasColumns;
        private List< TypeColumnsJSON  > storeColumns;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONColumns(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Columns of TypeContentRowsJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field Columns of TypeContentRowsJSON has too few elements.");
            List< TypeColumnsJSON  > vector_Columns1 = new List< TypeColumnsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeColumnsJSON convert_classy = TypeColumnsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Columns1.Add(convert_classy);
              }
            Debug.Assert(vector_Columns1.Count >= 1);
            initColumns();
            for (int num1 = 0; num1 < vector_Columns1.Count; ++num1)
                appendColumns(vector_Columns1[num1]);
            for (int num1 = 0; num1 < vector_Columns1.Count; ++num1)
              {
              }
          }


        public TypeContentRowsJSON()
          {
            flagHasColumns = false;
            storeColumns = new List< TypeColumnsJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasColumns()
          {
            return flagHasColumns;
          }

        public int  countOfColumns()
          {
            Debug.Assert(flagHasColumns);
            return storeColumns.Count;
          }

        public TypeColumnsJSON   elementOfColumns(int element_num)
          {
            Debug.Assert(flagHasColumns);
            return storeColumns[element_num];
          }

        public List< TypeColumnsJSON  >  getColumns()
          {
            Debug.Assert(flagHasColumns);
            return storeColumns;
          }


        public virtual int extraTypeContentRowsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeContentRowsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeContentRowsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeContentRowsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initColumns()
          {
            if (flagHasColumns)
              {
                for (int num1 = 0; num1 < storeColumns.Count; ++num1)
                  {
                  }
              }
            flagHasColumns = true;
            storeColumns.Clear();
          }
        public void appendColumns(TypeColumnsJSON  to_append)
          {
            if (!flagHasColumns)
              {
                flagHasColumns = true;
                storeColumns.Clear();
              }
            Debug.Assert(flagHasColumns);
            storeColumns.Add(to_append);
          }
        public void unsetColumns()
          {
            if (flagHasColumns)
              {
                for (int num2 = 0; num2 < storeColumns.Count; ++num2)
                  {
                  }
              }
            flagHasColumns = false;
            storeColumns.Clear();
          }

        public virtual void extraTypeContentRowsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeContentRowsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeContentRowsLookup(key);
            if (old_field == null)
              {
                extraTypeContentRowsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasColumns);
            if (flagHasColumns)
              {
                handler.start_pair("Columns");
                Debug.Assert(storeColumns.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeColumns.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeColumns[num1].write_partial_as_json(handler);
                    else
                        storeColumns[num1].write_as_json(handler);
                  }
                handler.finish_array();
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
            if (!(hasColumns()))
              {
                return "When parsing the object for %what%, the \"Columns\" field was missing.";
              }
            return null;
          }

        public static TypeContentRowsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeContentRowsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContentRows", ignore_extras);
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
        public static TypeContentRowsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeContentRowsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeContentRowsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContentRows", ignore_extras);
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
        public static TypeContentRowsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeContentRowsJSON from_text(string text, bool ignore_extras)
          {
            TypeContentRowsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContentRows", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeContentRowsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeContentRowsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeContentRowsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContentRows", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private TypeColumnsJSON.HoldingArrayGenerator fieldGeneratorColumns;
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
                TypeContentRowsJSON result = new TypeContentRowsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeContentRowsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeContentRowsJSON result)
              {
                if (fieldGeneratorColumns.have_value)
                  {
                    result.initColumns();
                    int count = fieldGeneratorColumns.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendColumns(fieldGeneratorColumns.value[num]);
                      }
                    fieldGeneratorColumns.value.Clear();
                    fieldGeneratorColumns.have_value = false;
                  }
                else if ((!(result.hasColumns())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Columns\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeContentRowsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Columns", 0, 7, false) == 0) && (field_name.Length == 7))
                    return fieldGeneratorColumns;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorColumns = new TypeColumnsJSON.HoldingArrayGenerator("field \"Columns\" of the TypeContentRows class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeContentRows class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorColumns = new TypeColumnsJSON.HoldingArrayGenerator("field \"Columns\" of the TypeContentRows class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeContentRows class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorColumns.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorColumns.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorColumns.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeContentRowsJSON  result)
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
            public TypeContentRowsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeContentRowsJSON  result)
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
        protected virtual void handle_result(List<TypeContentRowsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeContentRowsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeContentRowsJSON>();
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
        public List<TypeContentRowsJSON> value;
      };
      };
    private bool flagHasColumnCount;
    private sbyte storeColumnCount;
    private bool flagHasColumnStretch;
    private string storeColumnStretch;
    private bool flagHasContentDivider;
    private bool storeContentDivider;
    private bool flagHasHeader;
    private List< TypeHeaderJSON  > storeHeader;
    private bool flagHasContentRows;
    private List< TypeContentRowsJSON  > storeContentRows;
    private bool flagHasActionAndroidIntent;
    private AndroidIntentJSON  storeActionAndroidIntent;
    private bool flagHasActionURIs;
    private List< string > storeActionURIs;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraColumnCountToJSON()
      {
        JSONIntegerValue generated_integer_ColumnCount = new JSONIntegerValue(storeColumnCount);
        return generated_integer_ColumnCount;
      }

    private JSONValue  extraColumnStretchToJSON()
      {
        JSONStringValue generated_string_ColumnStretch = new JSONStringValue(storeColumnStretch);
        return generated_string_ColumnStretch;
      }

    private JSONValue  extraContentDividerToJSON()
      {
        JSONValue generated_boolean_ContentDivider = (storeContentDivider ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ContentDivider;
      }

    private JSONValue  extraHeaderToJSON()
      {
        JSONArrayValue generated_array_1_Header = new JSONArrayValue();
        for (int num1 = 0; num1 < storeHeader.Count; ++num1)
          {
            JSONValueHandler handler_Header = new JSONValueHandler();
            storeHeader[num1].write_as_json(handler_Header);
            generated_array_1_Header.appendComponent(handler_Header.result);
          }
        return generated_array_1_Header;
      }

    private JSONValue  extraContentRowsToJSON()
      {
        JSONArrayValue generated_array_2_ContentRows = new JSONArrayValue();
        for (int num2 = 0; num2 < storeContentRows.Count; ++num2)
          {
            JSONValueHandler handler_ContentRows = new JSONValueHandler();
            storeContentRows[num2].write_as_json(handler_ContentRows);
            generated_array_2_ContentRows.appendComponent(handler_ContentRows.result);
          }
        return generated_array_2_ContentRows;
      }

    private JSONValue  extraActionAndroidIntentToJSON()
      {
        JSONValueHandler handler_ActionAndroidIntent = new JSONValueHandler();
        storeActionAndroidIntent.write_as_json(handler_ActionAndroidIntent);
        return handler_ActionAndroidIntent.result;
      }

    private JSONValue  extraActionURIsToJSON()
      {
        JSONArrayValue generated_array_3_ActionURIs = new JSONArrayValue();
        for (int num3 = 0; num3 < storeActionURIs.Count; ++num3)
          {
            JSONStringValue generated_string_ActionURIs = new JSONStringValue(storeActionURIs[num3]);
            generated_array_3_ActionURIs.appendComponent(generated_string_ActionURIs);
          }
        return generated_array_3_ActionURIs;
      }


    private void  fromJSONColumnCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ColumnCount of MultiColumnTableTemplateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ColumnCount of MultiColumnTableTemplateJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setColumnCount(extracted_integer);
      }


    private void  fromJSONColumnStretch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ColumnStretch of MultiColumnTableTemplateJSON is not a string.");
        setColumnStretch(json_string.getData());
      }


    private void  fromJSONContentDivider(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ContentDivider of MultiColumnTableTemplateJSON is not true for false.");
              }
          }
        setContentDivider(the_bool);
      }


    private void  fromJSONHeader(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Header of MultiColumnTableTemplateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Header of MultiColumnTableTemplateJSON has too few elements.");
        List< TypeHeaderJSON  > vector_Header1 = new List< TypeHeaderJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeHeaderJSON convert_classy = TypeHeaderJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Header1.Add(convert_classy);
          }
        Debug.Assert(vector_Header1.Count >= 1);
        initHeader();
        for (int num2 = 0; num2 < vector_Header1.Count; ++num2)
            appendHeader(vector_Header1[num2]);
        for (int num1 = 0; num1 < vector_Header1.Count; ++num1)
          {
          }
      }


    private void  fromJSONContentRows(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ContentRows of MultiColumnTableTemplateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ContentRows of MultiColumnTableTemplateJSON has too few elements.");
        List< TypeContentRowsJSON  > vector_ContentRows1 = new List< TypeContentRowsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeContentRowsJSON convert_classy = TypeContentRowsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ContentRows1.Add(convert_classy);
          }
        Debug.Assert(vector_ContentRows1.Count >= 1);
        initContentRows();
        for (int num3 = 0; num3 < vector_ContentRows1.Count; ++num3)
            appendContentRows(vector_ContentRows1[num3]);
        for (int num1 = 0; num1 < vector_ContentRows1.Count; ++num1)
          {
          }
      }


    private void  fromJSONActionAndroidIntent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AndroidIntentJSON convert_classy = AndroidIntentJSON.from_json(json_value, ignore_extras, true);
        setActionAndroidIntent(convert_classy);
      }


    private void  fromJSONActionURIs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ActionURIs of MultiColumnTableTemplateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ActionURIs of MultiColumnTableTemplateJSON has too few elements.");
        List< string > vector_ActionURIs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ActionURIs of MultiColumnTableTemplateJSON is not a string.");
            vector_ActionURIs1.Add(json_string.getData());
          }
        Debug.Assert(vector_ActionURIs1.Count >= 1);
        initActionURIs();
        for (int num4 = 0; num4 < vector_ActionURIs1.Count; ++num4)
            appendActionURIs(vector_ActionURIs1[num4]);
        for (int num1 = 0; num1 < vector_ActionURIs1.Count; ++num1)
          {
          }
      }


    public MultiColumnTableTemplateJSON()
      {
        flagHasColumnCount = false;
        flagHasColumnStretch = false;
        flagHasContentDivider = false;
        flagHasHeader = false;
        flagHasContentRows = false;
        flagHasActionAndroidIntent = false;
        flagHasActionURIs = false;
        storeColumnStretch = "*";
        storeContentDivider = true;
        storeHeader = new List< TypeHeaderJSON  >();
        storeContentRows = new List< TypeContentRowsJSON  >();
        storeActionURIs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTemplateName()
      {
        return "MultiColumnTable";
      }

    public bool  hasColumnCount()
      {
        return flagHasColumnCount;
      }

    public sbyte  getColumnCount()
      {
        Debug.Assert(flagHasColumnCount);
        return storeColumnCount;
      }

    public bool  hasColumnStretch()
      {
        return flagHasColumnStretch;
      }

    public string  getColumnStretch()
      {
        return storeColumnStretch;
      }

    public bool  hasContentDivider()
      {
        return flagHasContentDivider;
      }

    public bool  getContentDivider()
      {
        return storeContentDivider;
      }

    public bool  hasHeader()
      {
        return flagHasHeader;
      }

    public int  countOfHeader()
      {
        Debug.Assert(flagHasHeader);
        return storeHeader.Count;
      }

    public TypeHeaderJSON   elementOfHeader(int element_num)
      {
        Debug.Assert(flagHasHeader);
        return storeHeader[element_num];
      }

    public List< TypeHeaderJSON  >  getHeader()
      {
        Debug.Assert(flagHasHeader);
        return storeHeader;
      }

    public bool  hasContentRows()
      {
        return flagHasContentRows;
      }

    public int  countOfContentRows()
      {
        Debug.Assert(flagHasContentRows);
        return storeContentRows.Count;
      }

    public TypeContentRowsJSON   elementOfContentRows(int element_num)
      {
        Debug.Assert(flagHasContentRows);
        return storeContentRows[element_num];
      }

    public List< TypeContentRowsJSON  >  getContentRows()
      {
        Debug.Assert(flagHasContentRows);
        return storeContentRows;
      }

    public bool  hasActionAndroidIntent()
      {
        return flagHasActionAndroidIntent;
      }

    public AndroidIntentJSON   getActionAndroidIntent()
      {
        Debug.Assert(flagHasActionAndroidIntent);
        return storeActionAndroidIntent;
      }

    public bool  hasActionURIs()
      {
        return flagHasActionURIs;
      }

    public int  countOfActionURIs()
      {
        Debug.Assert(flagHasActionURIs);
        return storeActionURIs.Count;
      }

    public string  elementOfActionURIs(int element_num)
      {
        Debug.Assert(flagHasActionURIs);
        return storeActionURIs[element_num];
      }

    public List< string >  getActionURIs()
      {
        Debug.Assert(flagHasActionURIs);
        return storeActionURIs;
      }


    public virtual int extraMultiColumnTableTemplateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMultiColumnTableTemplateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMultiColumnTableTemplateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMultiColumnTableTemplateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTemplateComponentCount()
      {
        int result = 0;
        if (flagHasColumnCount)
            ++result;
        if (flagHasColumnStretch)
            ++result;
        if (flagHasContentDivider)
            ++result;
        if (flagHasHeader)
            ++result;
        if (flagHasContentRows)
            ++result;
        if (flagHasActionAndroidIntent)
            ++result;
        if (flagHasActionURIs)
            ++result;
        result += extraMultiColumnTableTemplateComponentCount();
        return result;
      }
    public override string extraTemplateComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasColumnCount)
          {
            if (remainder == 0)
                return "ColumnCount";
            --remainder;
          }
        if (flagHasColumnStretch)
          {
            if (remainder == 0)
                return "ColumnStretch";
            --remainder;
          }
        if (flagHasContentDivider)
          {
            if (remainder == 0)
                return "ContentDivider";
            --remainder;
          }
        if (flagHasHeader)
          {
            if (remainder == 0)
                return "Header";
            --remainder;
          }
        if (flagHasContentRows)
          {
            if (remainder == 0)
                return "ContentRows";
            --remainder;
          }
        if (flagHasActionAndroidIntent)
          {
            if (remainder == 0)
                return "ActionAndroidIntent";
            --remainder;
          }
        if (flagHasActionURIs)
          {
            if (remainder == 0)
                return "ActionURIs";
            --remainder;
          }
        return extraMultiColumnTableTemplateComponentKey(remainder);
      }
    public override JSONValue extraTemplateComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasColumnCount)
          {
            if (remainder == 0)
                return extraColumnCountToJSON();
            --remainder;
          }
        if (flagHasColumnStretch)
          {
            if (remainder == 0)
                return extraColumnStretchToJSON();
            --remainder;
          }
        if (flagHasContentDivider)
          {
            if (remainder == 0)
                return extraContentDividerToJSON();
            --remainder;
          }
        if (flagHasHeader)
          {
            if (remainder == 0)
                return extraHeaderToJSON();
            --remainder;
          }
        if (flagHasContentRows)
          {
            if (remainder == 0)
                return extraContentRowsToJSON();
            --remainder;
          }
        if (flagHasActionAndroidIntent)
          {
            if (remainder == 0)
                return extraActionAndroidIntentToJSON();
            --remainder;
          }
        if (flagHasActionURIs)
          {
            if (remainder == 0)
                return extraActionURIsToJSON();
            --remainder;
          }
        return extraMultiColumnTableTemplateComponentValue(remainder);
      }
    public override JSONValue extraTemplateLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if (String.Compare(field_name, 1, "ction", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 7, "ndroidIntent", 0, 12, false) == 0) && (field_name.Length == 19))
                                return (flagHasActionAndroidIntent ? extraActionAndroidIntentToJSON() : null);
                            break;
                        case 'U':
                            if ((String.Compare(field_name, 7, "RIs", 0, 3, false) == 0) && (field_name.Length == 10))
                                return (flagHasActionURIs ? extraActionURIsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'l':
                            if (String.Compare(field_name, 3, "umn", 0, 3, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 7, "ount", 0, 4, false) == 0) && (field_name.Length == 11))
                                            return (flagHasColumnCount ? extraColumnCountToJSON() : null);
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 7, "tretch", 0, 6, false) == 0) && (field_name.Length == 13))
                                            return (flagHasColumnStretch ? extraColumnStretchToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'n':
                            if (String.Compare(field_name, 3, "tent", 0, 4, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 8, "ivider", 0, 6, false) == 0) && (field_name.Length == 14))
                                            return (flagHasContentDivider ? extraContentDividerToJSON() : null);
                                        break;
                                    case 'R':
                                        if ((String.Compare(field_name, 8, "ows", 0, 3, false) == 0) && (field_name.Length == 11))
                                            return (flagHasContentRows ? extraContentRowsToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if ((String.Compare(field_name, 1, "eader", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasHeader ? extraHeaderToJSON() : null);
                break;
            default:
                break;
          }
        return extraMultiColumnTableTemplateLookup(field_name);
      }

    public void setColumnCount(sbyte new_value)
      {
        flagHasColumnCount = true;
        if (new_value < 1)
            throw new Exception("The value for field ColumnCount of MultiColumnTableTemplateJSON is less than the lower bound (1) for that field.");
        if (new_value > 4)
            throw new Exception("The value for field ColumnCount of MultiColumnTableTemplateJSON is greater than the upper bound (4) for that field.");
        storeColumnCount = new_value;
      }
    public void unsetColumnCount()
      {
        flagHasColumnCount = false;
      }
    public void setColumnStretch(string new_value)
      {
        flagHasColumnStretch = true;
        if (!expressionColumnStretch.IsMatch(new_value))
            throw new Exception("The value is not in the regular expression for field ColumnStretch of MultiColumnTableTemplateJSON.");
        storeColumnStretch = new_value;
      }
    public void unsetColumnStretch()
      {
        flagHasColumnStretch = false;
      }
    public void setContentDivider(bool new_value)
      {
        flagHasContentDivider = true;
        storeContentDivider = new_value;
      }
    public void unsetContentDivider()
      {
        flagHasContentDivider = false;
      }
    public void initHeader()
      {
        if (flagHasHeader)
          {
            for (int num3 = 0; num3 < storeHeader.Count; ++num3)
              {
              }
          }
        flagHasHeader = true;
        storeHeader.Clear();
      }
    public void appendHeader(TypeHeaderJSON  to_append)
      {
        if (!flagHasHeader)
          {
            flagHasHeader = true;
            storeHeader.Clear();
          }
        Debug.Assert(flagHasHeader);
        storeHeader.Add(to_append);
      }
    public void unsetHeader()
      {
        if (flagHasHeader)
          {
            for (int num4 = 0; num4 < storeHeader.Count; ++num4)
              {
              }
          }
        flagHasHeader = false;
        storeHeader.Clear();
      }
    public void initContentRows()
      {
        if (flagHasContentRows)
          {
            for (int num5 = 0; num5 < storeContentRows.Count; ++num5)
              {
              }
          }
        flagHasContentRows = true;
        storeContentRows.Clear();
      }
    public void appendContentRows(TypeContentRowsJSON  to_append)
      {
        if (!flagHasContentRows)
          {
            flagHasContentRows = true;
            storeContentRows.Clear();
          }
        Debug.Assert(flagHasContentRows);
        storeContentRows.Add(to_append);
      }
    public void unsetContentRows()
      {
        if (flagHasContentRows)
          {
            for (int num6 = 0; num6 < storeContentRows.Count; ++num6)
              {
              }
          }
        flagHasContentRows = false;
        storeContentRows.Clear();
      }
    public void setActionAndroidIntent(AndroidIntentJSON  new_value)
      {
        if (flagHasActionAndroidIntent)
          {
          }
        flagHasActionAndroidIntent = true;
        storeActionAndroidIntent = new_value;
      }
    public void unsetActionAndroidIntent()
      {
        if (flagHasActionAndroidIntent)
          {
          }
        flagHasActionAndroidIntent = false;
      }
    public void initActionURIs()
      {
        flagHasActionURIs = true;
        storeActionURIs.Clear();
      }
    public void appendActionURIs(string to_append)
      {
        if (!flagHasActionURIs)
          {
            flagHasActionURIs = true;
            storeActionURIs.Clear();
          }
        Debug.Assert(flagHasActionURIs);
        storeActionURIs.Add(to_append);
      }
    public void unsetActionURIs()
      {
        flagHasActionURIs = false;
        storeActionURIs.Clear();
      }

    public virtual void extraMultiColumnTableTemplateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMultiColumnTableTemplateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMultiColumnTableTemplateLookup(key);
        if (old_field == null)
          {
            extraMultiColumnTableTemplateAppendPair(key, new_component);
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
    public override void extraTemplateAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if (String.Compare(key, 1, "ction", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'A':
                            if ((String.Compare(key, 7, "ndroidIntent", 0, 12, false) == 0) && (key.Length == 19))
                                {
                                fromJSONActionAndroidIntent(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 7, "RIs", 0, 3, false) == 0) && (key.Length == 10))
                                {
                                fromJSONActionURIs(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if (String.Compare(key, 1, "o", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'l':
                            if (String.Compare(key, 3, "umn", 0, 3, false) == 0)
                              {
                                switch (key[6])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 7, "ount", 0, 4, false) == 0) && (key.Length == 11))
                                            {
                                            fromJSONColumnCount(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'S':
                                        if ((String.Compare(key, 7, "tretch", 0, 6, false) == 0) && (key.Length == 13))
                                            {
                                            fromJSONColumnStretch(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'n':
                            if (String.Compare(key, 3, "tent", 0, 4, false) == 0)
                              {
                                switch (key[7])
                                  {
                                    case 'D':
                                        if ((String.Compare(key, 8, "ivider", 0, 6, false) == 0) && (key.Length == 14))
                                            {
                                            fromJSONContentDivider(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'R':
                                        if ((String.Compare(key, 8, "ows", 0, 3, false) == 0) && (key.Length == 11))
                                            {
                                            fromJSONContentRows(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if ((String.Compare(key, 1, "eader", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONHeader(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMultiColumnTableTemplateAppendPair(key, new_component);
      }
    public override void extraTemplateSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if (String.Compare(key, 1, "ction", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'A':
                            if ((String.Compare(key, 7, "ndroidIntent", 0, 12, false) == 0) && (key.Length == 19))
                                {
                                fromJSONActionAndroidIntent(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 7, "RIs", 0, 3, false) == 0) && (key.Length == 10))
                                {
                                fromJSONActionURIs(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if (String.Compare(key, 1, "o", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'l':
                            if (String.Compare(key, 3, "umn", 0, 3, false) == 0)
                              {
                                switch (key[6])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 7, "ount", 0, 4, false) == 0) && (key.Length == 11))
                                            {
                                            fromJSONColumnCount(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'S':
                                        if ((String.Compare(key, 7, "tretch", 0, 6, false) == 0) && (key.Length == 13))
                                            {
                                            fromJSONColumnStretch(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'n':
                            if (String.Compare(key, 3, "tent", 0, 4, false) == 0)
                              {
                                switch (key[7])
                                  {
                                    case 'D':
                                        if ((String.Compare(key, 8, "ivider", 0, 6, false) == 0) && (key.Length == 14))
                                            {
                                            fromJSONContentDivider(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'R':
                                        if ((String.Compare(key, 8, "ows", 0, 3, false) == 0) && (key.Length == 11))
                                            {
                                            fromJSONContentRows(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if ((String.Compare(key, 1, "eader", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONHeader(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMultiColumnTableTemplateSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasColumnCount);
        if (flagHasColumnCount)
          {
            handler.start_pair("ColumnCount");
            handler.number_value(storeColumnCount);
          }
        if (flagHasColumnStretch)
          {
            handler.start_pair("ColumnStretch");
            handler.string_value(storeColumnStretch);
          }
        if (flagHasContentDivider)
          {
            handler.start_pair("ContentDivider");
            handler.boolean_value(storeContentDivider);
          }
        if (flagHasHeader)
          {
            handler.start_pair("Header");
            Debug.Assert(storeHeader.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeHeader.Count; ++num1)
              {
                if (partial_allowed)
                    storeHeader[num1].write_partial_as_json(handler);
                else
                    storeHeader[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasContentRows);
        if (flagHasContentRows)
          {
            handler.start_pair("ContentRows");
            Debug.Assert(storeContentRows.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeContentRows.Count; ++num2)
              {
                if (partial_allowed)
                    storeContentRows[num2].write_partial_as_json(handler);
                else
                    storeContentRows[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasActionAndroidIntent)
          {
            handler.start_pair("ActionAndroidIntent");
            if (partial_allowed)
                storeActionAndroidIntent.write_partial_as_json(handler);
            else
                storeActionAndroidIntent.write_as_json(handler);
          }
        if (flagHasActionURIs)
          {
            handler.start_pair("ActionURIs");
            Debug.Assert(storeActionURIs.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeActionURIs.Count; ++num3)
              {
                handler.string_value(storeActionURIs[num3]);
              }
            handler.finish_array();
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
        if (!(hasColumnCount()))
          {
            return "When parsing the object for %what%, the \"ColumnCount\" field was missing.";
          }
        if (!(hasContentRows()))
          {
            return "When parsing the object for %what%, the \"ContentRows\" field was missing.";
          }
        return null;
      }

    public static new MultiColumnTableTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultiColumnTableTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultiColumnTableTemplate", ignore_extras);
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
    public static new MultiColumnTableTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MultiColumnTableTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultiColumnTableTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultiColumnTableTemplate", ignore_extras);
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
    public static new MultiColumnTableTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MultiColumnTableTemplateJSON from_text(string text, bool ignore_extras)
      {
        MultiColumnTableTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultiColumnTableTemplate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MultiColumnTableTemplateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MultiColumnTableTemplateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MultiColumnTableTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultiColumnTableTemplate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TemplateJSON.Generator
      {
    private class FieldHoldingGeneratorColumnCount : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorColumnCount(String what) : base(what, 1, 4)
              {
              }
          };
    private class FieldHoldingArrayGeneratorColumnCount : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorColumnCount(String what) : base(what, 1, 4)
              {
              }
          };
        private FieldHoldingGeneratorColumnCount fieldGeneratorColumnCount;
    private abstract class FieldGeneratorColumnStretch : JSONStringGenerator
          {
            private Regex checker;
            protected FieldGeneratorColumnStretch()  { checker = new Regex("^((\\*)|([0-3]((,[0-3])*)))$"); }
            protected FieldGeneratorColumnStretch(string  what) : base(what) { checker = new Regex("^((\\*)|([0-3]((,[0-3])*)))$"); }
            protected void validate(string result)
              {
                if (!(checker.IsMatch(result)))
                    error("The string for %what% doesn't match the required pattern @^((\\*)|([0-3]((,[0-3])*)))$@.");
              }
          };
    private class FieldHoldingGeneratorColumnStretch : FieldGeneratorColumnStretch
  {
    protected override void handle_result(string result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorColumnStretch(String what)
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
    public string value;
  };
    private class FieldHoldingArrayGeneratorColumnStretch : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorColumnStretch
      {
        private FieldHoldingArrayGeneratorColumnStretch top;

        protected override void handle_result(string result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorColumnStretch init_top)
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
    protected virtual void handle_result(List<string> result)
      {
      }

    public FieldHoldingArrayGeneratorColumnStretch(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorColumnStretch()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<string> value;
  };
        private FieldHoldingGeneratorColumnStretch fieldGeneratorColumnStretch;
        private JSONHoldingBooleanGenerator fieldGeneratorContentDivider;
        private TypeHeaderJSON.HoldingArrayGenerator fieldGeneratorHeader;
        private TypeContentRowsJSON.HoldingArrayGenerator fieldGeneratorContentRows;
        private AndroidIntentJSON.HoldingGenerator fieldGeneratorActionAndroidIntent;
        private JSONHoldingStringArrayGenerator fieldGeneratorActionURIs;
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
            if (!(getTemplateJSONKey().Equals("MultiColumnTable")))
                throw new Exception("The key field has a value other than `MultiColumnTable'.");
            MultiColumnTableTemplateJSON result = new MultiColumnTableTemplateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMultiColumnTableTemplateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TemplateJSON new_result)
          {
            handle_result((MultiColumnTableTemplateJSON )new_result);
          }
        protected void finish(MultiColumnTableTemplateJSON result)
          {
            if (fieldGeneratorColumnCount.have_value)
              {
                result.setColumnCount((sbyte)(fieldGeneratorColumnCount.value));
                fieldGeneratorColumnCount.have_value = false;
              }
            else if ((!(result.hasColumnCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ColumnCount\" field was missing.");
              }
            if (fieldGeneratorColumnStretch.have_value)
              {
                result.setColumnStretch(fieldGeneratorColumnStretch.value);
                fieldGeneratorColumnStretch.have_value = false;
              }
            if (fieldGeneratorContentDivider.have_value)
              {
                result.setContentDivider(fieldGeneratorContentDivider.value);
                fieldGeneratorContentDivider.have_value = false;
              }
            if (fieldGeneratorHeader.have_value)
              {
                result.initHeader();
                int count = fieldGeneratorHeader.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHeader(fieldGeneratorHeader.value[num]);
                  }
                fieldGeneratorHeader.value.Clear();
                fieldGeneratorHeader.have_value = false;
              }
            if (fieldGeneratorContentRows.have_value)
              {
                result.initContentRows();
                int count = fieldGeneratorContentRows.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendContentRows(fieldGeneratorContentRows.value[num]);
                  }
                fieldGeneratorContentRows.value.Clear();
                fieldGeneratorContentRows.have_value = false;
              }
            else if ((!(result.hasContentRows())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ContentRows\" field was missing.");
              }
            if (fieldGeneratorActionAndroidIntent.have_value)
              {
                result.setActionAndroidIntent(fieldGeneratorActionAndroidIntent.value);
                fieldGeneratorActionAndroidIntent.have_value = false;
              }
            if (fieldGeneratorActionURIs.have_value)
              {
                result.initActionURIs();
                int count = fieldGeneratorActionURIs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendActionURIs(fieldGeneratorActionURIs.value[num]);
                  }
                fieldGeneratorActionURIs.value.Clear();
                fieldGeneratorActionURIs.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MultiColumnTableTemplateJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "ction", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 7, "ndroidIntent", 0, 12, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorActionAndroidIntent;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 7, "RIs", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorActionURIs;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'C':
                    if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'l':
                                if (String.Compare(field_name, 3, "umn", 0, 3, false) == 0)
                                  {
                                    switch (field_name[6])
                                      {
                                        case 'C':
                                            if ((String.Compare(field_name, 7, "ount", 0, 4, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorColumnCount;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 7, "tretch", 0, 6, false) == 0) && (field_name.Length == 13))
                                                return fieldGeneratorColumnStretch;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'n':
                                if (String.Compare(field_name, 3, "tent", 0, 4, false) == 0)
                                  {
                                    switch (field_name[7])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 8, "ivider", 0, 6, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorContentDivider;
                                            break;
                                        case 'R':
                                            if ((String.Compare(field_name, 8, "ows", 0, 3, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorContentRows;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "eader", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorHeader;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorColumnCount = new FieldHoldingGeneratorColumnCount("field \"ColumnCount\" of the MultiColumnTableTemplate class");
            fieldGeneratorColumnStretch = new FieldHoldingGeneratorColumnStretch("field \"ColumnStretch\" of the MultiColumnTableTemplate class");
            fieldGeneratorContentDivider = new JSONHoldingBooleanGenerator("field \"ContentDivider\" of the MultiColumnTableTemplate class");
            fieldGeneratorHeader = new TypeHeaderJSON.HoldingArrayGenerator("field \"Header\" of the MultiColumnTableTemplate class", ignore_extras);
            fieldGeneratorContentRows = new TypeContentRowsJSON.HoldingArrayGenerator("field \"ContentRows\" of the MultiColumnTableTemplate class", ignore_extras);
            fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the MultiColumnTableTemplate class", ignore_extras);
            fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the MultiColumnTableTemplate class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MultiColumnTableTemplate class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorColumnCount = new FieldHoldingGeneratorColumnCount("field \"ColumnCount\" of the MultiColumnTableTemplate class");
            fieldGeneratorColumnStretch = new FieldHoldingGeneratorColumnStretch("field \"ColumnStretch\" of the MultiColumnTableTemplate class");
            fieldGeneratorContentDivider = new JSONHoldingBooleanGenerator("field \"ContentDivider\" of the MultiColumnTableTemplate class");
            fieldGeneratorHeader = new TypeHeaderJSON.HoldingArrayGenerator("field \"Header\" of the MultiColumnTableTemplate class", false);
            fieldGeneratorContentRows = new TypeContentRowsJSON.HoldingArrayGenerator("field \"ContentRows\" of the MultiColumnTableTemplate class", false);
            fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the MultiColumnTableTemplate class", false);
            fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the MultiColumnTableTemplate class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MultiColumnTableTemplate class");
          }

        public override void reset()
          {
            fieldGeneratorColumnCount.reset();
            fieldGeneratorColumnStretch.reset();
            fieldGeneratorContentDivider.reset();
            fieldGeneratorHeader.reset();
            fieldGeneratorContentRows.reset();
            fieldGeneratorActionAndroidIntent.reset();
            fieldGeneratorActionURIs.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MultiColumnTableTemplateJSON  result)
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
        public MultiColumnTableTemplateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MultiColumnTableTemplateJSON  result)
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
    protected virtual void handle_result(List<MultiColumnTableTemplateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MultiColumnTableTemplateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MultiColumnTableTemplateJSON>();
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
    public List<MultiColumnTableTemplateJSON> value;
  };
  };
