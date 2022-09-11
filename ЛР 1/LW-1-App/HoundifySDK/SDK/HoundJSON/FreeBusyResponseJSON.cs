/* file "FreeBusyResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FreeBusyResponseJSON : JSONBase
  {
    public class TypeutilFieldJSON : JSONBase
      {
        public class TypeerrorsJSON : JSONBase
          {
            private bool flagHasdomain;
            private string storedomain;
            private bool flagHasreason;
            private string storereason;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONdomain(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field domain of TypeerrorsJSON is not a string.");
                setdomain(json_string.getData());
              }


            private void  fromJSONreason(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field reason of TypeerrorsJSON is not a string.");
                setreason(json_string.getData());
              }


            public TypeerrorsJSON()
              {
                flagHasdomain = false;
                flagHasreason = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasdomain()
              {
                return flagHasdomain;
              }

            public string  getdomain()
              {
                Debug.Assert(flagHasdomain);
                return storedomain;
              }

            public bool  hasreason()
              {
                return flagHasreason;
              }

            public string  getreason()
              {
                Debug.Assert(flagHasreason);
                return storereason;
              }


            public virtual int extraTypeerrorsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeerrorsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeerrorsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeerrorsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setdomain(string new_value)
              {
                flagHasdomain = true;
                storedomain = new_value;
              }
            public void unsetdomain()
              {
                flagHasdomain = false;
              }
            public void setreason(string new_value)
              {
                flagHasreason = true;
                storereason = new_value;
              }
            public void unsetreason()
              {
                flagHasreason = false;
              }

            public virtual void extraTypeerrorsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeerrorsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeerrorsLookup(key);
                if (old_field == null)
                  {
                    extraTypeerrorsAppendPair(key, new_component);
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
                if (flagHasdomain)
                  {
                    handler.start_pair("domain");
                    handler.string_value(storedomain);
                  }
                if (flagHasreason)
                  {
                    handler.start_pair("reason");
                    handler.string_value(storereason);
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
                return null;
              }

            public static TypeerrorsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeerrorsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeerrors", ignore_extras);
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
            public static TypeerrorsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeerrorsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeerrorsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeerrors", ignore_extras);
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
            public static TypeerrorsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeerrorsJSON from_text(string text, bool ignore_extras)
              {
                TypeerrorsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeerrors", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeerrorsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeerrorsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeerrorsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeerrors", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratordomain;
                private JSONHoldingStringGenerator fieldGeneratorreason;
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
                    TypeerrorsJSON result = new TypeerrorsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeerrorsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeerrorsJSON result)
                  {
                    if (fieldGeneratordomain.have_value)
                      {
                        result.setdomain(fieldGeneratordomain.value);
                        fieldGeneratordomain.have_value = false;
                      }
                    if (fieldGeneratorreason.have_value)
                      {
                        result.setreason(fieldGeneratorreason.value);
                        fieldGeneratorreason.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeerrorsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'd':
                            if ((String.Compare(field_name, 1, "omain", 0, 5, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratordomain;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 1, "eason", 0, 5, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorreason;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratordomain = new JSONHoldingStringGenerator("field \"domain\" of the Typeerrors class");
                    fieldGeneratorreason = new JSONHoldingStringGenerator("field \"reason\" of the Typeerrors class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the Typeerrors class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratordomain = new JSONHoldingStringGenerator("field \"domain\" of the Typeerrors class");
                    fieldGeneratorreason = new JSONHoldingStringGenerator("field \"reason\" of the Typeerrors class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the Typeerrors class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratordomain.reset();
                    fieldGeneratorreason.reset();
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
                protected override void handle_result(TypeerrorsJSON  result)
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
                public TypeerrorsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeerrorsJSON  result)
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
            protected virtual void handle_result(List<TypeerrorsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeerrorsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeerrorsJSON>();
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
            public List<TypeerrorsJSON> value;
          };
          };
        public class TypebusyJSON : JSONBase
          {
            private bool flagHasstart;
            private string storestart;
            private bool flagHasend;
            private string storeend;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONstart(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field start of TypebusyJSON is not a string.");
                setstart(json_string.getData());
              }


            private void  fromJSONend(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field end of TypebusyJSON is not a string.");
                setend(json_string.getData());
              }


            public TypebusyJSON()
              {
                flagHasstart = false;
                flagHasend = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasstart()
              {
                return flagHasstart;
              }

            public string  getstart()
              {
                Debug.Assert(flagHasstart);
                return storestart;
              }

            public bool  hasend()
              {
                return flagHasend;
              }

            public string  getend()
              {
                Debug.Assert(flagHasend);
                return storeend;
              }


            public virtual int extraTypebusyComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypebusyComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypebusyComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypebusyLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setstart(string new_value)
              {
                flagHasstart = true;
                storestart = new_value;
              }
            public void unsetstart()
              {
                flagHasstart = false;
              }
            public void setend(string new_value)
              {
                flagHasend = true;
                storeend = new_value;
              }
            public void unsetend()
              {
                flagHasend = false;
              }

            public virtual void extraTypebusyAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypebusySetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypebusyLookup(key);
                if (old_field == null)
                  {
                    extraTypebusyAppendPair(key, new_component);
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
                if (flagHasstart)
                  {
                    handler.start_pair("start");
                    handler.string_value(storestart);
                  }
                if (flagHasend)
                  {
                    handler.start_pair("end");
                    handler.string_value(storeend);
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
                return null;
              }

            public static TypebusyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypebusyJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typebusy", ignore_extras);
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
            public static TypebusyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypebusyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypebusyJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typebusy", ignore_extras);
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
            public static TypebusyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypebusyJSON from_text(string text, bool ignore_extras)
              {
                TypebusyJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typebusy", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypebusyJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypebusyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypebusyJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typebusy", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorstart;
                private JSONHoldingStringGenerator fieldGeneratorend;
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
                    TypebusyJSON result = new TypebusyJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypebusyAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypebusyJSON result)
                  {
                    if (fieldGeneratorstart.have_value)
                      {
                        result.setstart(fieldGeneratorstart.value);
                        fieldGeneratorstart.have_value = false;
                      }
                    if (fieldGeneratorend.have_value)
                      {
                        result.setend(fieldGeneratorend.value);
                        fieldGeneratorend.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypebusyJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 1, "nd", 0, 2, false) == 0) && (field_name.Length == 3))
                                return fieldGeneratorend;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 1, "tart", 0, 4, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorstart;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorstart = new JSONHoldingStringGenerator("field \"start\" of the Typebusy class");
                    fieldGeneratorend = new JSONHoldingStringGenerator("field \"end\" of the Typebusy class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the Typebusy class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorstart = new JSONHoldingStringGenerator("field \"start\" of the Typebusy class");
                    fieldGeneratorend = new JSONHoldingStringGenerator("field \"end\" of the Typebusy class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the Typebusy class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorstart.reset();
                    fieldGeneratorend.reset();
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
                protected override void handle_result(TypebusyJSON  result)
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
                public TypebusyJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypebusyJSON  result)
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
            protected virtual void handle_result(List<TypebusyJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypebusyJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypebusyJSON>();
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
            public List<TypebusyJSON> value;
          };
          };
        private bool flagHaserrors;
        private List< TypeerrorsJSON  > storeerrors;
        private bool flagHasbusy;
        private List< TypebusyJSON  > storebusy;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONerrors(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field errors of TypeutilFieldJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeerrorsJSON  > vector_errors1 = new List< TypeerrorsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeerrorsJSON convert_classy = TypeerrorsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_errors1.Add(convert_classy);
              }
            initerrors();
            for (int num1 = 0; num1 < vector_errors1.Count; ++num1)
                appenderrors(vector_errors1[num1]);
            for (int num1 = 0; num1 < vector_errors1.Count; ++num1)
              {
              }
          }


        private void  fromJSONbusy(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field busy of TypeutilFieldJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypebusyJSON  > vector_busy1 = new List< TypebusyJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypebusyJSON convert_classy = TypebusyJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_busy1.Add(convert_classy);
              }
            initbusy();
            for (int num2 = 0; num2 < vector_busy1.Count; ++num2)
                appendbusy(vector_busy1[num2]);
            for (int num1 = 0; num1 < vector_busy1.Count; ++num1)
              {
              }
          }


        public TypeutilFieldJSON()
          {
            flagHaserrors = false;
            flagHasbusy = false;
            storeerrors = new List< TypeerrorsJSON  >();
            storebusy = new List< TypebusyJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  haserrors()
          {
            return flagHaserrors;
          }

        public int  countOferrors()
          {
            Debug.Assert(flagHaserrors);
            return storeerrors.Count;
          }

        public TypeerrorsJSON   elementOferrors(int element_num)
          {
            Debug.Assert(flagHaserrors);
            return storeerrors[element_num];
          }

        public List< TypeerrorsJSON  >  geterrors()
          {
            Debug.Assert(flagHaserrors);
            return storeerrors;
          }

        public bool  hasbusy()
          {
            return flagHasbusy;
          }

        public int  countOfbusy()
          {
            Debug.Assert(flagHasbusy);
            return storebusy.Count;
          }

        public TypebusyJSON   elementOfbusy(int element_num)
          {
            Debug.Assert(flagHasbusy);
            return storebusy[element_num];
          }

        public List< TypebusyJSON  >  getbusy()
          {
            Debug.Assert(flagHasbusy);
            return storebusy;
          }


        public virtual int extraTypeutilFieldComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeutilFieldComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeutilFieldComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeutilFieldLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initerrors()
          {
            if (flagHaserrors)
              {
                for (int num1 = 0; num1 < storeerrors.Count; ++num1)
                  {
                  }
              }
            flagHaserrors = true;
            storeerrors.Clear();
          }
        public void appenderrors(TypeerrorsJSON  to_append)
          {
            if (!flagHaserrors)
              {
                flagHaserrors = true;
                storeerrors.Clear();
              }
            Debug.Assert(flagHaserrors);
            storeerrors.Add(to_append);
          }
        public void unseterrors()
          {
            if (flagHaserrors)
              {
                for (int num2 = 0; num2 < storeerrors.Count; ++num2)
                  {
                  }
              }
            flagHaserrors = false;
            storeerrors.Clear();
          }
        public void initbusy()
          {
            if (flagHasbusy)
              {
                for (int num3 = 0; num3 < storebusy.Count; ++num3)
                  {
                  }
              }
            flagHasbusy = true;
            storebusy.Clear();
          }
        public void appendbusy(TypebusyJSON  to_append)
          {
            if (!flagHasbusy)
              {
                flagHasbusy = true;
                storebusy.Clear();
              }
            Debug.Assert(flagHasbusy);
            storebusy.Add(to_append);
          }
        public void unsetbusy()
          {
            if (flagHasbusy)
              {
                for (int num4 = 0; num4 < storebusy.Count; ++num4)
                  {
                  }
              }
            flagHasbusy = false;
            storebusy.Clear();
          }

        public virtual void extraTypeutilFieldAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeutilFieldSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeutilFieldLookup(key);
            if (old_field == null)
              {
                extraTypeutilFieldAppendPair(key, new_component);
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
            if (flagHaserrors)
              {
                handler.start_pair("errors");
                handler.start_array();
                for (int num1 = 0; num1 < storeerrors.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeerrors[num1].write_partial_as_json(handler);
                    else
                        storeerrors[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasbusy)
              {
                handler.start_pair("busy");
                handler.start_array();
                for (int num2 = 0; num2 < storebusy.Count; ++num2)
                  {
                    if (partial_allowed)
                        storebusy[num2].write_partial_as_json(handler);
                    else
                        storebusy[num2].write_as_json(handler);
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
            return null;
          }

        public static TypeutilFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeutilFieldJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeutilField", ignore_extras);
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
        public static TypeutilFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeutilFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeutilFieldJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeutilField", ignore_extras);
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
        public static TypeutilFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeutilFieldJSON from_text(string text, bool ignore_extras)
          {
            TypeutilFieldJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeutilField", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeutilFieldJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeutilFieldJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeutilFieldJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeutilField", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private TypeerrorsJSON.HoldingArrayGenerator fieldGeneratorerrors;
            private TypebusyJSON.HoldingArrayGenerator fieldGeneratorbusy;
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
                TypeutilFieldJSON result = new TypeutilFieldJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeutilFieldAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeutilFieldJSON result)
              {
                if (fieldGeneratorerrors.have_value)
                  {
                    result.initerrors();
                    int count = fieldGeneratorerrors.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appenderrors(fieldGeneratorerrors.value[num]);
                      }
                    fieldGeneratorerrors.value.Clear();
                    fieldGeneratorerrors.have_value = false;
                  }
                if (fieldGeneratorbusy.have_value)
                  {
                    result.initbusy();
                    int count = fieldGeneratorbusy.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendbusy(fieldGeneratorbusy.value[num]);
                      }
                    fieldGeneratorbusy.value.Clear();
                    fieldGeneratorbusy.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeutilFieldJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'b':
                        if ((String.Compare(field_name, 1, "usy", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorbusy;
                        break;
                    case 'e':
                        if ((String.Compare(field_name, 1, "rrors", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorerrors;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorerrors = new TypeerrorsJSON.HoldingArrayGenerator("field \"errors\" of the TypeutilField class", ignore_extras);
                fieldGeneratorbusy = new TypebusyJSON.HoldingArrayGenerator("field \"busy\" of the TypeutilField class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeutilField class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorerrors = new TypeerrorsJSON.HoldingArrayGenerator("field \"errors\" of the TypeutilField class", false);
                fieldGeneratorbusy = new TypebusyJSON.HoldingArrayGenerator("field \"busy\" of the TypeutilField class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeutilField class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorerrors.reset();
                fieldGeneratorbusy.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorerrors.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorbusy.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorerrors.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorbusy.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeutilFieldJSON  result)
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
            public TypeutilFieldJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeutilFieldJSON  result)
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
        protected virtual void handle_result(List<TypeutilFieldJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeutilFieldJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeutilFieldJSON>();
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
        public List<TypeutilFieldJSON> value;
      };
      };
    private bool flagHascalendars;
    private JSONObjectValue  storecalendars;
    private bool flagHasutilField;
    private TypeutilFieldJSON  storeutilField;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONcalendars(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field calendars of FreeBusyResponseJSON is not an object.");
        setcalendars(json_value.object_value());
      }


    private void  fromJSONutilField(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeutilFieldJSON convert_classy = TypeutilFieldJSON.from_json(json_value, ignore_extras, true);
        setutilField(convert_classy);
      }


    public FreeBusyResponseJSON()
      {
        flagHascalendars = false;
        flagHasutilField = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hascalendars()
      {
        return flagHascalendars;
      }

    public JSONObjectValue   getcalendars()
      {
        Debug.Assert(flagHascalendars);
        return storecalendars;
      }

    public bool  hasutilField()
      {
        return flagHasutilField;
      }

    public TypeutilFieldJSON   getutilField()
      {
        Debug.Assert(flagHasutilField);
        return storeutilField;
      }


    public virtual int extraFreeBusyResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFreeBusyResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFreeBusyResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFreeBusyResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setcalendars(JSONObjectValue  new_value)
      {
        if (flagHascalendars)
          {
          }
        flagHascalendars = true;
        storecalendars = new_value;
      }
    public void unsetcalendars()
      {
        if (flagHascalendars)
          {
          }
        flagHascalendars = false;
      }
    public void setutilField(TypeutilFieldJSON  new_value)
      {
        if (flagHasutilField)
          {
          }
        flagHasutilField = true;
        storeutilField = new_value;
      }
    public void unsetutilField()
      {
        if (flagHasutilField)
          {
          }
        flagHasutilField = false;
      }

    public virtual void extraFreeBusyResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFreeBusyResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFreeBusyResponseLookup(key);
        if (old_field == null)
          {
            extraFreeBusyResponseAppendPair(key, new_component);
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
        if (flagHascalendars)
          {
            handler.start_pair("calendars");
            storecalendars.write(handler);
          }
        if (flagHasutilField)
          {
            handler.start_pair("utilField");
            if (partial_allowed)
                storeutilField.write_partial_as_json(handler);
            else
                storeutilField.write_as_json(handler);
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
        return null;
      }

    public static FreeBusyResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FreeBusyResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FreeBusyResponse", ignore_extras);
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
    public static FreeBusyResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FreeBusyResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FreeBusyResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FreeBusyResponse", ignore_extras);
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
    public static FreeBusyResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FreeBusyResponseJSON from_text(string text, bool ignore_extras)
      {
        FreeBusyResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FreeBusyResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FreeBusyResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FreeBusyResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FreeBusyResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FreeBusyResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingObjectValueGenerator fieldGeneratorcalendars;
        private TypeutilFieldJSON.HoldingGenerator fieldGeneratorutilField;
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
            FreeBusyResponseJSON result = new FreeBusyResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFreeBusyResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FreeBusyResponseJSON result)
          {
            if (fieldGeneratorcalendars.have_value)
              {
                result.setcalendars(fieldGeneratorcalendars.value);
                fieldGeneratorcalendars.have_value = false;
              }
            if (fieldGeneratorutilField.have_value)
              {
                result.setutilField(fieldGeneratorutilField.value);
                fieldGeneratorutilField.have_value = false;
              }
          }
        protected abstract void handle_result(FreeBusyResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'c':
                    if ((String.Compare(field_name, 1, "alendars", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorcalendars;
                    break;
                case 'u':
                    if ((String.Compare(field_name, 1, "tilField", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorutilField;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorcalendars = new JSONHoldingObjectValueGenerator("field \"calendars\" of the FreeBusyResponse class");
            fieldGeneratorutilField = new TypeutilFieldJSON.HoldingGenerator("field \"utilField\" of the FreeBusyResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FreeBusyResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorcalendars = new JSONHoldingObjectValueGenerator("field \"calendars\" of the FreeBusyResponse class");
            fieldGeneratorutilField = new TypeutilFieldJSON.HoldingGenerator("field \"utilField\" of the FreeBusyResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FreeBusyResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorcalendars.reset();
            fieldGeneratorutilField.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorutilField.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorutilField.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FreeBusyResponseJSON  result)
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
        public FreeBusyResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FreeBusyResponseJSON  result)
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
    protected virtual void handle_result(List<FreeBusyResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FreeBusyResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FreeBusyResponseJSON>();
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
    public List<FreeBusyResponseJSON> value;
  };
  };
