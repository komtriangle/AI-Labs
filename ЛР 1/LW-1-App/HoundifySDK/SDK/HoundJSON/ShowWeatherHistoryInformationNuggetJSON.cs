/* file "ShowWeatherHistoryInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ShowWeatherHistoryInformationNuggetJSON : WeatherInformationNuggetJSON
  {
    public class TypeDailySummaryJSON : JSONBase
      {
        public class TypePrecipitationJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_PrecipitationJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_PrecipitationJSON convert_classy = UnitsValue_PrecipitationJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypePrecipitationJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_PrecipitationJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypePrecipitationComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypePrecipitationComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypePrecipitationComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypePrecipitationLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_PrecipitationJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypePrecipitationAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypePrecipitationSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypePrecipitationLookup(key);
                if (old_field == null)
                  {
                    extraTypePrecipitationAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypePrecipitationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypePrecipitationJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation", ignore_extras);
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
            public static TypePrecipitationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypePrecipitationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypePrecipitationJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation", ignore_extras);
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
            public static TypePrecipitationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypePrecipitationJSON from_text(string text, bool ignore_extras)
              {
                TypePrecipitationJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypePrecipitationJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypePrecipitationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypePrecipitationJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_PrecipitationJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypePrecipitationJSON result = new TypePrecipitationJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypePrecipitationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypePrecipitationJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypePrecipitationJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitation class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypePrecipitation class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitation class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypePrecipitation class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypePrecipitationJSON  result)
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
                public TypePrecipitationJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypePrecipitationJSON  result)
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
            protected virtual void handle_result(List<TypePrecipitationJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypePrecipitationJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypePrecipitationJSON>();
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
            public List<TypePrecipitationJSON> value;
          };
          };
        public class TypeSnowfallJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_SnowJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_SnowJSON convert_classy = UnitsValue_SnowJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeSnowfallJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_SnowJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeSnowfallComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeSnowfallComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeSnowfallComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeSnowfallLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_SnowJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeSnowfallAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeSnowfallSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeSnowfallLookup(key);
                if (old_field == null)
                  {
                    extraTypeSnowfallAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeSnowfallJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSnowfallJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfall", ignore_extras);
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
            public static TypeSnowfallJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSnowfallJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSnowfallJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfall", ignore_extras);
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
            public static TypeSnowfallJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSnowfallJSON from_text(string text, bool ignore_extras)
              {
                TypeSnowfallJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfall", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeSnowfallJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeSnowfallJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeSnowfallJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfall", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_SnowJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeSnowfallJSON result = new TypeSnowfallJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeSnowfallAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeSnowfallJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeSnowfallJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowfall class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeSnowfall class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowfall class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeSnowfall class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeSnowfallJSON  result)
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
                public TypeSnowfallJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeSnowfallJSON  result)
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
            protected virtual void handle_result(List<TypeSnowfallJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeSnowfallJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeSnowfallJSON>();
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
            public List<TypeSnowfallJSON> value;
          };
          };
        public class TypeSnowfallMonthToDateJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_SnowJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_SnowJSON convert_classy = UnitsValue_SnowJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeSnowfallMonthToDateJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_SnowJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeSnowfallMonthToDateComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeSnowfallMonthToDateComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeSnowfallMonthToDateComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeSnowfallMonthToDateLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_SnowJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeSnowfallMonthToDateAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeSnowfallMonthToDateSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeSnowfallMonthToDateLookup(key);
                if (old_field == null)
                  {
                    extraTypeSnowfallMonthToDateAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeSnowfallMonthToDateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSnowfallMonthToDateJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfallMonthToDate", ignore_extras);
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
            public static TypeSnowfallMonthToDateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSnowfallMonthToDateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSnowfallMonthToDateJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfallMonthToDate", ignore_extras);
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
            public static TypeSnowfallMonthToDateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSnowfallMonthToDateJSON from_text(string text, bool ignore_extras)
              {
                TypeSnowfallMonthToDateJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfallMonthToDate", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeSnowfallMonthToDateJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeSnowfallMonthToDateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeSnowfallMonthToDateJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfallMonthToDate", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_SnowJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeSnowfallMonthToDateJSON result = new TypeSnowfallMonthToDateJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeSnowfallMonthToDateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeSnowfallMonthToDateJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeSnowfallMonthToDateJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowfallMonthToDate class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeSnowfallMonthToDate class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowfallMonthToDate class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeSnowfallMonthToDate class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeSnowfallMonthToDateJSON  result)
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
                public TypeSnowfallMonthToDateJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeSnowfallMonthToDateJSON  result)
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
            protected virtual void handle_result(List<TypeSnowfallMonthToDateJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeSnowfallMonthToDateJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeSnowfallMonthToDateJSON>();
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
            public List<TypeSnowfallMonthToDateJSON> value;
          };
          };
        public class TypeSnowfallSinceJulyFirstJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_SnowJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_SnowJSON convert_classy = UnitsValue_SnowJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeSnowfallSinceJulyFirstJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_SnowJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeSnowfallSinceJulyFirstComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeSnowfallSinceJulyFirstComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeSnowfallSinceJulyFirstComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeSnowfallSinceJulyFirstLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_SnowJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeSnowfallSinceJulyFirstAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeSnowfallSinceJulyFirstSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeSnowfallSinceJulyFirstLookup(key);
                if (old_field == null)
                  {
                    extraTypeSnowfallSinceJulyFirstAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeSnowfallSinceJulyFirstJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSnowfallSinceJulyFirstJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfallSinceJulyFirst", ignore_extras);
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
            public static TypeSnowfallSinceJulyFirstJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSnowfallSinceJulyFirstJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSnowfallSinceJulyFirstJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfallSinceJulyFirst", ignore_extras);
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
            public static TypeSnowfallSinceJulyFirstJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSnowfallSinceJulyFirstJSON from_text(string text, bool ignore_extras)
              {
                TypeSnowfallSinceJulyFirstJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfallSinceJulyFirst", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeSnowfallSinceJulyFirstJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeSnowfallSinceJulyFirstJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeSnowfallSinceJulyFirstJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowfallSinceJulyFirst", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_SnowJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeSnowfallSinceJulyFirstJSON result = new TypeSnowfallSinceJulyFirstJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeSnowfallSinceJulyFirstAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeSnowfallSinceJulyFirstJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeSnowfallSinceJulyFirstJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowfallSinceJulyFirst class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeSnowfallSinceJulyFirst class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowfallSinceJulyFirst class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeSnowfallSinceJulyFirst class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeSnowfallSinceJulyFirstJSON  result)
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
                public TypeSnowfallSinceJulyFirstJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeSnowfallSinceJulyFirstJSON  result)
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
            protected virtual void handle_result(List<TypeSnowfallSinceJulyFirstJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeSnowfallSinceJulyFirstJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeSnowfallSinceJulyFirstJSON>();
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
            public List<TypeSnowfallSinceJulyFirstJSON> value;
          };
          };
        public class TypeSnowDepthJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_SnowJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_SnowJSON convert_classy = UnitsValue_SnowJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeSnowDepthJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_SnowJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeSnowDepthComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeSnowDepthComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeSnowDepthComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeSnowDepthLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_SnowJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeSnowDepthAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeSnowDepthSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeSnowDepthLookup(key);
                if (old_field == null)
                  {
                    extraTypeSnowDepthAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeSnowDepthJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSnowDepthJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowDepth", ignore_extras);
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
            public static TypeSnowDepthJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSnowDepthJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSnowDepthJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowDepth", ignore_extras);
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
            public static TypeSnowDepthJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSnowDepthJSON from_text(string text, bool ignore_extras)
              {
                TypeSnowDepthJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowDepth", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeSnowDepthJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeSnowDepthJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeSnowDepthJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSnowDepth", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_SnowJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeSnowDepthJSON result = new TypeSnowDepthJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeSnowDepthAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeSnowDepthJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeSnowDepthJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowDepth class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeSnowDepth class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowDepth class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeSnowDepth class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeSnowDepthJSON  result)
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
                public TypeSnowDepthJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeSnowDepthJSON  result)
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
            protected virtual void handle_result(List<TypeSnowDepthJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeSnowDepthJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeSnowDepthJSON>();
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
            public List<TypeSnowDepthJSON> value;
          };
          };
        public class TypeMaxTemperatureJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_TemperatureJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeMaxTemperatureJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_TemperatureJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeMaxTemperatureComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeMaxTemperatureComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeMaxTemperatureComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeMaxTemperatureLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_TemperatureJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeMaxTemperatureAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeMaxTemperatureSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeMaxTemperatureLookup(key);
                if (old_field == null)
                  {
                    extraTypeMaxTemperatureAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeMaxTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMaxTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxTemperature", ignore_extras);
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
            public static TypeMaxTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMaxTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMaxTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxTemperature", ignore_extras);
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
            public static TypeMaxTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMaxTemperatureJSON from_text(string text, bool ignore_extras)
              {
                TypeMaxTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxTemperature", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeMaxTemperatureJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeMaxTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeMaxTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxTemperature", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeMaxTemperatureJSON result = new TypeMaxTemperatureJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeMaxTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeMaxTemperatureJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeMaxTemperatureJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxTemperature class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeMaxTemperature class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxTemperature class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeMaxTemperature class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeMaxTemperatureJSON  result)
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
                public TypeMaxTemperatureJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeMaxTemperatureJSON  result)
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
            protected virtual void handle_result(List<TypeMaxTemperatureJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeMaxTemperatureJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeMaxTemperatureJSON>();
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
            public List<TypeMaxTemperatureJSON> value;
          };
          };
        public class TypeAvgTemperatureJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_TemperatureJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeAvgTemperatureJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_TemperatureJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeAvgTemperatureComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeAvgTemperatureComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeAvgTemperatureComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeAvgTemperatureLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_TemperatureJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeAvgTemperatureAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeAvgTemperatureSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeAvgTemperatureLookup(key);
                if (old_field == null)
                  {
                    extraTypeAvgTemperatureAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeAvgTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAvgTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgTemperature", ignore_extras);
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
            public static TypeAvgTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAvgTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAvgTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgTemperature", ignore_extras);
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
            public static TypeAvgTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAvgTemperatureJSON from_text(string text, bool ignore_extras)
              {
                TypeAvgTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgTemperature", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeAvgTemperatureJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeAvgTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeAvgTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgTemperature", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeAvgTemperatureJSON result = new TypeAvgTemperatureJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeAvgTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeAvgTemperatureJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeAvgTemperatureJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgTemperature class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeAvgTemperature class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgTemperature class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeAvgTemperature class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeAvgTemperatureJSON  result)
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
                public TypeAvgTemperatureJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeAvgTemperatureJSON  result)
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
            protected virtual void handle_result(List<TypeAvgTemperatureJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeAvgTemperatureJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeAvgTemperatureJSON>();
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
            public List<TypeAvgTemperatureJSON> value;
          };
          };
        public class TypeMinTemperatureJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_TemperatureJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeMinTemperatureJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_TemperatureJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeMinTemperatureComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeMinTemperatureComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeMinTemperatureComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeMinTemperatureLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_TemperatureJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeMinTemperatureAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeMinTemperatureSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeMinTemperatureLookup(key);
                if (old_field == null)
                  {
                    extraTypeMinTemperatureAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeMinTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMinTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinTemperature", ignore_extras);
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
            public static TypeMinTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMinTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMinTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinTemperature", ignore_extras);
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
            public static TypeMinTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMinTemperatureJSON from_text(string text, bool ignore_extras)
              {
                TypeMinTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinTemperature", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeMinTemperatureJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeMinTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeMinTemperatureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinTemperature", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeMinTemperatureJSON result = new TypeMinTemperatureJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeMinTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeMinTemperatureJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeMinTemperatureJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinTemperature class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeMinTemperature class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinTemperature class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeMinTemperature class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeMinTemperatureJSON  result)
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
                public TypeMinTemperatureJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeMinTemperatureJSON  result)
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
            protected virtual void handle_result(List<TypeMinTemperatureJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeMinTemperatureJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeMinTemperatureJSON>();
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
            public List<TypeMinTemperatureJSON> value;
          };
          };
        public class TypeMaxDewPointJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_TemperatureJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeMaxDewPointJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_TemperatureJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeMaxDewPointComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeMaxDewPointComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeMaxDewPointComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeMaxDewPointLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_TemperatureJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeMaxDewPointAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeMaxDewPointSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeMaxDewPointLookup(key);
                if (old_field == null)
                  {
                    extraTypeMaxDewPointAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeMaxDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMaxDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxDewPoint", ignore_extras);
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
            public static TypeMaxDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMaxDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMaxDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxDewPoint", ignore_extras);
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
            public static TypeMaxDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMaxDewPointJSON from_text(string text, bool ignore_extras)
              {
                TypeMaxDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxDewPoint", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeMaxDewPointJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeMaxDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeMaxDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxDewPoint", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeMaxDewPointJSON result = new TypeMaxDewPointJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeMaxDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeMaxDewPointJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeMaxDewPointJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxDewPoint class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeMaxDewPoint class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxDewPoint class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeMaxDewPoint class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeMaxDewPointJSON  result)
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
                public TypeMaxDewPointJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeMaxDewPointJSON  result)
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
            protected virtual void handle_result(List<TypeMaxDewPointJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeMaxDewPointJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeMaxDewPointJSON>();
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
            public List<TypeMaxDewPointJSON> value;
          };
          };
        public class TypeAvgDewPointJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_TemperatureJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeAvgDewPointJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_TemperatureJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeAvgDewPointComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeAvgDewPointComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeAvgDewPointComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeAvgDewPointLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_TemperatureJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeAvgDewPointAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeAvgDewPointSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeAvgDewPointLookup(key);
                if (old_field == null)
                  {
                    extraTypeAvgDewPointAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeAvgDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAvgDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgDewPoint", ignore_extras);
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
            public static TypeAvgDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAvgDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAvgDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgDewPoint", ignore_extras);
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
            public static TypeAvgDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAvgDewPointJSON from_text(string text, bool ignore_extras)
              {
                TypeAvgDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgDewPoint", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeAvgDewPointJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeAvgDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeAvgDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgDewPoint", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeAvgDewPointJSON result = new TypeAvgDewPointJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeAvgDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeAvgDewPointJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeAvgDewPointJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgDewPoint class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeAvgDewPoint class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgDewPoint class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeAvgDewPoint class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeAvgDewPointJSON  result)
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
                public TypeAvgDewPointJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeAvgDewPointJSON  result)
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
            protected virtual void handle_result(List<TypeAvgDewPointJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeAvgDewPointJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeAvgDewPointJSON>();
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
            public List<TypeAvgDewPointJSON> value;
          };
          };
        public class TypeMinDewPointJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_TemperatureJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeMinDewPointJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_TemperatureJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeMinDewPointComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeMinDewPointComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeMinDewPointComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeMinDewPointLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_TemperatureJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeMinDewPointAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeMinDewPointSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeMinDewPointLookup(key);
                if (old_field == null)
                  {
                    extraTypeMinDewPointAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeMinDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMinDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinDewPoint", ignore_extras);
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
            public static TypeMinDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMinDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMinDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinDewPoint", ignore_extras);
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
            public static TypeMinDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMinDewPointJSON from_text(string text, bool ignore_extras)
              {
                TypeMinDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinDewPoint", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeMinDewPointJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeMinDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeMinDewPointJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinDewPoint", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeMinDewPointJSON result = new TypeMinDewPointJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeMinDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeMinDewPointJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeMinDewPointJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinDewPoint class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeMinDewPoint class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinDewPoint class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeMinDewPoint class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeMinDewPointJSON  result)
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
                public TypeMinDewPointJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeMinDewPointJSON  result)
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
            protected virtual void handle_result(List<TypeMinDewPointJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeMinDewPointJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeMinDewPointJSON>();
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
            public List<TypeMinDewPointJSON> value;
          };
          };
        public class TypeMaxPressureJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_PressureJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_PressureJSON convert_classy = UnitsValue_PressureJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeMaxPressureJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_PressureJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeMaxPressureComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeMaxPressureComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeMaxPressureComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeMaxPressureLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_PressureJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeMaxPressureAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeMaxPressureSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeMaxPressureLookup(key);
                if (old_field == null)
                  {
                    extraTypeMaxPressureAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeMaxPressureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMaxPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxPressure", ignore_extras);
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
            public static TypeMaxPressureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMaxPressureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMaxPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxPressure", ignore_extras);
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
            public static TypeMaxPressureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMaxPressureJSON from_text(string text, bool ignore_extras)
              {
                TypeMaxPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxPressure", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeMaxPressureJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeMaxPressureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeMaxPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxPressure", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_PressureJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeMaxPressureJSON result = new TypeMaxPressureJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeMaxPressureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeMaxPressureJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeMaxPressureJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the TypeMaxPressure class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeMaxPressure class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the TypeMaxPressure class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeMaxPressure class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeMaxPressureJSON  result)
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
                public TypeMaxPressureJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeMaxPressureJSON  result)
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
            protected virtual void handle_result(List<TypeMaxPressureJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeMaxPressureJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeMaxPressureJSON>();
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
            public List<TypeMaxPressureJSON> value;
          };
          };
        public class TypeAvgPressureJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_PressureJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_PressureJSON convert_classy = UnitsValue_PressureJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeAvgPressureJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_PressureJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeAvgPressureComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeAvgPressureComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeAvgPressureComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeAvgPressureLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_PressureJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeAvgPressureAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeAvgPressureSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeAvgPressureLookup(key);
                if (old_field == null)
                  {
                    extraTypeAvgPressureAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeAvgPressureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAvgPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgPressure", ignore_extras);
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
            public static TypeAvgPressureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAvgPressureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAvgPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgPressure", ignore_extras);
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
            public static TypeAvgPressureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAvgPressureJSON from_text(string text, bool ignore_extras)
              {
                TypeAvgPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgPressure", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeAvgPressureJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeAvgPressureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeAvgPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgPressure", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_PressureJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeAvgPressureJSON result = new TypeAvgPressureJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeAvgPressureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeAvgPressureJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeAvgPressureJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the TypeAvgPressure class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeAvgPressure class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the TypeAvgPressure class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeAvgPressure class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeAvgPressureJSON  result)
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
                public TypeAvgPressureJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeAvgPressureJSON  result)
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
            protected virtual void handle_result(List<TypeAvgPressureJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeAvgPressureJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeAvgPressureJSON>();
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
            public List<TypeAvgPressureJSON> value;
          };
          };
        public class TypeMinPressureJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_PressureJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_PressureJSON convert_classy = UnitsValue_PressureJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeMinPressureJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_PressureJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeMinPressureComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeMinPressureComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeMinPressureComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeMinPressureLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_PressureJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeMinPressureAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeMinPressureSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeMinPressureLookup(key);
                if (old_field == null)
                  {
                    extraTypeMinPressureAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeMinPressureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMinPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinPressure", ignore_extras);
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
            public static TypeMinPressureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMinPressureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMinPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinPressure", ignore_extras);
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
            public static TypeMinPressureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMinPressureJSON from_text(string text, bool ignore_extras)
              {
                TypeMinPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinPressure", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeMinPressureJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeMinPressureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeMinPressureJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinPressure", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_PressureJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeMinPressureJSON result = new TypeMinPressureJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeMinPressureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeMinPressureJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeMinPressureJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the TypeMinPressure class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeMinPressure class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the TypeMinPressure class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeMinPressure class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeMinPressureJSON  result)
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
                public TypeMinPressureJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeMinPressureJSON  result)
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
            protected virtual void handle_result(List<TypeMinPressureJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeMinPressureJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeMinPressureJSON>();
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
            public List<TypeMinPressureJSON> value;
          };
          };
        public class TypeMaxWindJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_WindJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_WindJSON convert_classy = UnitsValue_WindJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeMaxWindJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_WindJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeMaxWindComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeMaxWindComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeMaxWindComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeMaxWindLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_WindJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeMaxWindAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeMaxWindSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeMaxWindLookup(key);
                if (old_field == null)
                  {
                    extraTypeMaxWindAppendPair(key, new_component);
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
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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

            public static TypeMaxWindJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMaxWindJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxWind", ignore_extras);
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
            public static TypeMaxWindJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMaxWindJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMaxWindJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxWind", ignore_extras);
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
            public static TypeMaxWindJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMaxWindJSON from_text(string text, bool ignore_extras)
              {
                TypeMaxWindJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxWind", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeMaxWindJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeMaxWindJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeMaxWindJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxWind", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_WindJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeMaxWindJSON result = new TypeMaxWindJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeMaxWindAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeMaxWindJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeMaxWindJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the TypeMaxWind class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeMaxWind class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the TypeMaxWind class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeMaxWind class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeMaxWindJSON  result)
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
                public TypeMaxWindJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeMaxWindJSON  result)
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
            protected virtual void handle_result(List<TypeMaxWindJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeMaxWindJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeMaxWindJSON>();
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
            public List<TypeMaxWindJSON> value;
          };
          };
        public class TypeMinWindJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_WindJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_WindJSON convert_classy = UnitsValue_WindJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeMinWindJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_WindJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeMinWindComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeMinWindComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeMinWindComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeMinWindLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_WindJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeMinWindAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeMinWindSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeMinWindLookup(key);
                if (old_field == null)
                  {
                    extraTypeMinWindAppendPair(key, new_component);
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
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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

            public static TypeMinWindJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMinWindJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinWind", ignore_extras);
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
            public static TypeMinWindJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMinWindJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMinWindJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinWind", ignore_extras);
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
            public static TypeMinWindJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMinWindJSON from_text(string text, bool ignore_extras)
              {
                TypeMinWindJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinWind", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeMinWindJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeMinWindJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeMinWindJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinWind", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_WindJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeMinWindJSON result = new TypeMinWindJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeMinWindAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeMinWindJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeMinWindJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the TypeMinWind class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeMinWind class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the TypeMinWind class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeMinWind class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeMinWindJSON  result)
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
                public TypeMinWindJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeMinWindJSON  result)
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
            protected virtual void handle_result(List<TypeMinWindJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeMinWindJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeMinWindJSON>();
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
            public List<TypeMinWindJSON> value;
          };
          };
        public class TypeMaxVisibilityJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_VisibilityJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_VisibilityJSON convert_classy = UnitsValue_VisibilityJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeMaxVisibilityJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_VisibilityJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeMaxVisibilityComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeMaxVisibilityComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeMaxVisibilityComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeMaxVisibilityLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_VisibilityJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeMaxVisibilityAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeMaxVisibilitySetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeMaxVisibilityLookup(key);
                if (old_field == null)
                  {
                    extraTypeMaxVisibilityAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeMaxVisibilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMaxVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxVisibility", ignore_extras);
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
            public static TypeMaxVisibilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMaxVisibilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMaxVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxVisibility", ignore_extras);
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
            public static TypeMaxVisibilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMaxVisibilityJSON from_text(string text, bool ignore_extras)
              {
                TypeMaxVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxVisibility", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeMaxVisibilityJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeMaxVisibilityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeMaxVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMaxVisibility", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_VisibilityJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeMaxVisibilityJSON result = new TypeMaxVisibilityJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeMaxVisibilityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeMaxVisibilityJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeMaxVisibilityJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_VisibilityJSON.HoldingGenerator("field \"Value\" of the TypeMaxVisibility class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeMaxVisibility class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_VisibilityJSON.HoldingGenerator("field \"Value\" of the TypeMaxVisibility class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeMaxVisibility class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeMaxVisibilityJSON  result)
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
                public TypeMaxVisibilityJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeMaxVisibilityJSON  result)
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
            protected virtual void handle_result(List<TypeMaxVisibilityJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeMaxVisibilityJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeMaxVisibilityJSON>();
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
            public List<TypeMaxVisibilityJSON> value;
          };
          };
        public class TypeAvgVisibilityJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_VisibilityJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_VisibilityJSON convert_classy = UnitsValue_VisibilityJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeAvgVisibilityJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_VisibilityJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeAvgVisibilityComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeAvgVisibilityComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeAvgVisibilityComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeAvgVisibilityLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_VisibilityJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeAvgVisibilityAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeAvgVisibilitySetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeAvgVisibilityLookup(key);
                if (old_field == null)
                  {
                    extraTypeAvgVisibilityAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeAvgVisibilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAvgVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgVisibility", ignore_extras);
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
            public static TypeAvgVisibilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAvgVisibilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAvgVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgVisibility", ignore_extras);
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
            public static TypeAvgVisibilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAvgVisibilityJSON from_text(string text, bool ignore_extras)
              {
                TypeAvgVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgVisibility", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeAvgVisibilityJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeAvgVisibilityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeAvgVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAvgVisibility", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_VisibilityJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeAvgVisibilityJSON result = new TypeAvgVisibilityJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeAvgVisibilityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeAvgVisibilityJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeAvgVisibilityJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_VisibilityJSON.HoldingGenerator("field \"Value\" of the TypeAvgVisibility class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeAvgVisibility class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_VisibilityJSON.HoldingGenerator("field \"Value\" of the TypeAvgVisibility class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeAvgVisibility class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeAvgVisibilityJSON  result)
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
                public TypeAvgVisibilityJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeAvgVisibilityJSON  result)
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
            protected virtual void handle_result(List<TypeAvgVisibilityJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeAvgVisibilityJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeAvgVisibilityJSON>();
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
            public List<TypeAvgVisibilityJSON> value;
          };
          };
        public class TypeMinVisibilityJSON : JSONBase
          {
            private bool flagHasValue;
            private UnitsValue_VisibilityJSON  storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                UnitsValue_VisibilityJSON convert_classy = UnitsValue_VisibilityJSON.from_json(json_value, ignore_extras, true);
                setValue(convert_classy);
              }


            public TypeMinVisibilityJSON()
              {
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public UnitsValue_VisibilityJSON   getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeMinVisibilityComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeMinVisibilityComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeMinVisibilityComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeMinVisibilityLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setValue(UnitsValue_VisibilityJSON  new_value)
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                if (flagHasValue)
                  {
                  }
                flagHasValue = false;
              }

            public virtual void extraTypeMinVisibilityAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeMinVisibilitySetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeMinVisibilityLookup(key);
                if (old_field == null)
                  {
                    extraTypeMinVisibilityAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (partial_allowed)
                        storeValue.write_partial_as_json(handler);
                    else
                        storeValue.write_as_json(handler);
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
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeMinVisibilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMinVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinVisibility", ignore_extras);
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
            public static TypeMinVisibilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMinVisibilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeMinVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinVisibility", ignore_extras);
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
            public static TypeMinVisibilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeMinVisibilityJSON from_text(string text, bool ignore_extras)
              {
                TypeMinVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinVisibility", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeMinVisibilityJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeMinVisibilityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeMinVisibilityJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeMinVisibility", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private UnitsValue_VisibilityJSON.HoldingGenerator fieldGeneratorValue;
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
                    TypeMinVisibilityJSON result = new TypeMinVisibilityJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeMinVisibilityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeMinVisibilityJSON result)
                  {
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeMinVisibilityJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorValue = new UnitsValue_VisibilityJSON.HoldingGenerator("field \"Value\" of the TypeMinVisibility class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeMinVisibility class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorValue = new UnitsValue_VisibilityJSON.HoldingGenerator("field \"Value\" of the TypeMinVisibility class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeMinVisibility class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorValue.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeMinVisibilityJSON  result)
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
                public TypeMinVisibilityJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeMinVisibilityJSON  result)
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
            protected virtual void handle_result(List<TypeMinVisibilityJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeMinVisibilityJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeMinVisibilityJSON>();
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
            public List<TypeMinVisibilityJSON> value;
          };
          };
        private bool flagHasIsObservedConditions;
        private bool storeIsObservedConditions;
        private bool flagHasDateAndTime;
        private DateAndOrTimeJSON  storeDateAndTime;
        private bool flagHasSunriseDateAndTime;
        private DateAndOrTimeJSON  storeSunriseDateAndTime;
        private bool flagHasSunsetDateAndTime;
        private DateAndOrTimeJSON  storeSunsetDateAndTime;
        private bool flagHasMoonPhaseText;
        private MoonPhaseDataJSON  storeMoonPhaseText;
        private bool flagHasMoonPhaseTextDisplay;
        private string storeMoonPhaseTextDisplay;
        private bool flagHasMoonPhaseTextSpoken;
        private string storeMoonPhaseTextSpoken;
        private bool flagHasMoonPhaseTextWritten;
        private string storeMoonPhaseTextWritten;
        private bool flagHasMoonPhasePct;
        private sbyte storeMoonPhasePct;
        private bool flagHasPrecipitation;
        private TypePrecipitationJSON  storePrecipitation;
        private bool flagHasSnowfall;
        private TypeSnowfallJSON  storeSnowfall;
        private bool flagHasSnowfallMonthToDate;
        private TypeSnowfallMonthToDateJSON  storeSnowfallMonthToDate;
        private bool flagHasSnowfallSinceJulyFirst;
        private TypeSnowfallSinceJulyFirstJSON  storeSnowfallSinceJulyFirst;
        private bool flagHasSnowDepth;
        private TypeSnowDepthJSON  storeSnowDepth;
        private bool flagHasMaxTemperature;
        private TypeMaxTemperatureJSON  storeMaxTemperature;
        private bool flagHasAvgTemperature;
        private TypeAvgTemperatureJSON  storeAvgTemperature;
        private bool flagHasMinTemperature;
        private TypeMinTemperatureJSON  storeMinTemperature;
        private bool flagHasMaxDewPoint;
        private TypeMaxDewPointJSON  storeMaxDewPoint;
        private bool flagHasAvgDewPoint;
        private TypeAvgDewPointJSON  storeAvgDewPoint;
        private bool flagHasMinDewPoint;
        private TypeMinDewPointJSON  storeMinDewPoint;
        private bool flagHasMaxHumidityPct;
        private sbyte storeMaxHumidityPct;
        private bool flagHasAvgHumidityPct;
        private sbyte storeAvgHumidityPct;
        private bool flagHasMinHumidityPct;
        private sbyte storeMinHumidityPct;
        private bool flagHasMaxPressure;
        private TypeMaxPressureJSON  storeMaxPressure;
        private bool flagHasAvgPressure;
        private TypeAvgPressureJSON  storeAvgPressure;
        private bool flagHasMinPressure;
        private TypeMinPressureJSON  storeMinPressure;
        private bool flagHasMaxWind;
        private TypeMaxWindJSON  storeMaxWind;
        private bool flagHasAvgWind;
        private WindDataJSON  storeAvgWind;
        private bool flagHasMinWind;
        private TypeMinWindJSON  storeMinWind;
        private bool flagHasMaxVisibility;
        private TypeMaxVisibilityJSON  storeMaxVisibility;
        private bool flagHasAvgVisibility;
        private TypeAvgVisibilityJSON  storeAvgVisibility;
        private bool flagHasMinVisibility;
        private TypeMinVisibilityJSON  storeMinVisibility;
        private bool flagHasFog;
        private bool storeFog;
        private bool flagHasRain;
        private bool storeRain;
        private bool flagHasSnow;
        private bool storeSnow;
        private bool flagHasHail;
        private bool storeHail;
        private bool flagHasThunder;
        private bool storeThunder;
        private bool flagHasTornado;
        private bool storeTornado;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONIsObservedConditions(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field IsObservedConditions of TypeDailySummaryJSON is not true for false.");
                  }
              }
            setIsObservedConditions(the_bool);
          }


        private void  fromJSONDateAndTime(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setDateAndTime(convert_classy);
          }


        private void  fromJSONSunriseDateAndTime(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setSunriseDateAndTime(convert_classy);
          }


        private void  fromJSONSunsetDateAndTime(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setSunsetDateAndTime(convert_classy);
          }


        private void  fromJSONMoonPhaseText(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoonPhaseDataJSON convert_classy = MoonPhaseDataJSON.from_json(json_value, ignore_extras, true);
            setMoonPhaseText(convert_classy);
          }


        private void  fromJSONMoonPhaseTextDisplay(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field MoonPhaseTextDisplay of TypeDailySummaryJSON is not a string.");
            setMoonPhaseTextDisplay(json_string.getData());
          }


        private void  fromJSONMoonPhaseTextSpoken(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field MoonPhaseTextSpoken of TypeDailySummaryJSON is not a string.");
            setMoonPhaseTextSpoken(json_string.getData());
          }


        private void  fromJSONMoonPhaseTextWritten(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field MoonPhaseTextWritten of TypeDailySummaryJSON is not a string.");
            setMoonPhaseTextWritten(json_string.getData());
          }


        private void  fromJSONMoonPhasePct(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field MoonPhasePct of TypeDailySummaryJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field MoonPhasePct of TypeDailySummaryJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setMoonPhasePct(extracted_integer);
          }


        private void  fromJSONPrecipitation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypePrecipitationJSON convert_classy = TypePrecipitationJSON.from_json(json_value, ignore_extras, true);
            setPrecipitation(convert_classy);
          }


        private void  fromJSONSnowfall(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeSnowfallJSON convert_classy = TypeSnowfallJSON.from_json(json_value, ignore_extras, true);
            setSnowfall(convert_classy);
          }


        private void  fromJSONSnowfallMonthToDate(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeSnowfallMonthToDateJSON convert_classy = TypeSnowfallMonthToDateJSON.from_json(json_value, ignore_extras, true);
            setSnowfallMonthToDate(convert_classy);
          }


        private void  fromJSONSnowfallSinceJulyFirst(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeSnowfallSinceJulyFirstJSON convert_classy = TypeSnowfallSinceJulyFirstJSON.from_json(json_value, ignore_extras, true);
            setSnowfallSinceJulyFirst(convert_classy);
          }


        private void  fromJSONSnowDepth(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeSnowDepthJSON convert_classy = TypeSnowDepthJSON.from_json(json_value, ignore_extras, true);
            setSnowDepth(convert_classy);
          }


        private void  fromJSONMaxTemperature(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeMaxTemperatureJSON convert_classy = TypeMaxTemperatureJSON.from_json(json_value, ignore_extras, true);
            setMaxTemperature(convert_classy);
          }


        private void  fromJSONAvgTemperature(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeAvgTemperatureJSON convert_classy = TypeAvgTemperatureJSON.from_json(json_value, ignore_extras, true);
            setAvgTemperature(convert_classy);
          }


        private void  fromJSONMinTemperature(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeMinTemperatureJSON convert_classy = TypeMinTemperatureJSON.from_json(json_value, ignore_extras, true);
            setMinTemperature(convert_classy);
          }


        private void  fromJSONMaxDewPoint(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeMaxDewPointJSON convert_classy = TypeMaxDewPointJSON.from_json(json_value, ignore_extras, true);
            setMaxDewPoint(convert_classy);
          }


        private void  fromJSONAvgDewPoint(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeAvgDewPointJSON convert_classy = TypeAvgDewPointJSON.from_json(json_value, ignore_extras, true);
            setAvgDewPoint(convert_classy);
          }


        private void  fromJSONMinDewPoint(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeMinDewPointJSON convert_classy = TypeMinDewPointJSON.from_json(json_value, ignore_extras, true);
            setMinDewPoint(convert_classy);
          }


        private void  fromJSONMaxHumidityPct(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field MaxHumidityPct of TypeDailySummaryJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field MaxHumidityPct of TypeDailySummaryJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setMaxHumidityPct(extracted_integer);
          }


        private void  fromJSONAvgHumidityPct(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field AvgHumidityPct of TypeDailySummaryJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field AvgHumidityPct of TypeDailySummaryJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setAvgHumidityPct(extracted_integer);
          }


        private void  fromJSONMinHumidityPct(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field MinHumidityPct of TypeDailySummaryJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field MinHumidityPct of TypeDailySummaryJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setMinHumidityPct(extracted_integer);
          }


        private void  fromJSONMaxPressure(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeMaxPressureJSON convert_classy = TypeMaxPressureJSON.from_json(json_value, ignore_extras, true);
            setMaxPressure(convert_classy);
          }


        private void  fromJSONAvgPressure(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeAvgPressureJSON convert_classy = TypeAvgPressureJSON.from_json(json_value, ignore_extras, true);
            setAvgPressure(convert_classy);
          }


        private void  fromJSONMinPressure(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeMinPressureJSON convert_classy = TypeMinPressureJSON.from_json(json_value, ignore_extras, true);
            setMinPressure(convert_classy);
          }


        private void  fromJSONMaxWind(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeMaxWindJSON convert_classy = TypeMaxWindJSON.from_json(json_value, ignore_extras, true);
            setMaxWind(convert_classy);
          }


        private void  fromJSONAvgWind(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            WindDataJSON convert_classy = WindDataJSON.from_json(json_value, ignore_extras, true);
            setAvgWind(convert_classy);
          }


        private void  fromJSONMinWind(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeMinWindJSON convert_classy = TypeMinWindJSON.from_json(json_value, ignore_extras, true);
            setMinWind(convert_classy);
          }


        private void  fromJSONMaxVisibility(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeMaxVisibilityJSON convert_classy = TypeMaxVisibilityJSON.from_json(json_value, ignore_extras, true);
            setMaxVisibility(convert_classy);
          }


        private void  fromJSONAvgVisibility(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeAvgVisibilityJSON convert_classy = TypeAvgVisibilityJSON.from_json(json_value, ignore_extras, true);
            setAvgVisibility(convert_classy);
          }


        private void  fromJSONMinVisibility(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeMinVisibilityJSON convert_classy = TypeMinVisibilityJSON.from_json(json_value, ignore_extras, true);
            setMinVisibility(convert_classy);
          }


        private void  fromJSONFog(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Fog of TypeDailySummaryJSON is not true for false.");
                  }
              }
            setFog(the_bool);
          }


        private void  fromJSONRain(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Rain of TypeDailySummaryJSON is not true for false.");
                  }
              }
            setRain(the_bool);
          }


        private void  fromJSONSnow(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Snow of TypeDailySummaryJSON is not true for false.");
                  }
              }
            setSnow(the_bool);
          }


        private void  fromJSONHail(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Hail of TypeDailySummaryJSON is not true for false.");
                  }
              }
            setHail(the_bool);
          }


        private void  fromJSONThunder(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Thunder of TypeDailySummaryJSON is not true for false.");
                  }
              }
            setThunder(the_bool);
          }


        private void  fromJSONTornado(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Tornado of TypeDailySummaryJSON is not true for false.");
                  }
              }
            setTornado(the_bool);
          }


        public TypeDailySummaryJSON()
          {
            flagHasIsObservedConditions = false;
            flagHasDateAndTime = false;
            flagHasSunriseDateAndTime = false;
            flagHasSunsetDateAndTime = false;
            flagHasMoonPhaseText = false;
            flagHasMoonPhaseTextDisplay = false;
            flagHasMoonPhaseTextSpoken = false;
            flagHasMoonPhaseTextWritten = false;
            flagHasMoonPhasePct = false;
            flagHasPrecipitation = false;
            flagHasSnowfall = false;
            flagHasSnowfallMonthToDate = false;
            flagHasSnowfallSinceJulyFirst = false;
            flagHasSnowDepth = false;
            flagHasMaxTemperature = false;
            flagHasAvgTemperature = false;
            flagHasMinTemperature = false;
            flagHasMaxDewPoint = false;
            flagHasAvgDewPoint = false;
            flagHasMinDewPoint = false;
            flagHasMaxHumidityPct = false;
            flagHasAvgHumidityPct = false;
            flagHasMinHumidityPct = false;
            flagHasMaxPressure = false;
            flagHasAvgPressure = false;
            flagHasMinPressure = false;
            flagHasMaxWind = false;
            flagHasAvgWind = false;
            flagHasMinWind = false;
            flagHasMaxVisibility = false;
            flagHasAvgVisibility = false;
            flagHasMinVisibility = false;
            flagHasFog = false;
            flagHasRain = false;
            flagHasSnow = false;
            flagHasHail = false;
            flagHasThunder = false;
            flagHasTornado = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasIsObservedConditions()
          {
            return flagHasIsObservedConditions;
          }

        public bool  getIsObservedConditions()
          {
            Debug.Assert(flagHasIsObservedConditions);
            return storeIsObservedConditions;
          }

        public bool  hasDateAndTime()
          {
            return flagHasDateAndTime;
          }

        public DateAndOrTimeJSON   getDateAndTime()
          {
            Debug.Assert(flagHasDateAndTime);
            return storeDateAndTime;
          }

        public bool  hasSunriseDateAndTime()
          {
            return flagHasSunriseDateAndTime;
          }

        public DateAndOrTimeJSON   getSunriseDateAndTime()
          {
            Debug.Assert(flagHasSunriseDateAndTime);
            return storeSunriseDateAndTime;
          }

        public bool  hasSunsetDateAndTime()
          {
            return flagHasSunsetDateAndTime;
          }

        public DateAndOrTimeJSON   getSunsetDateAndTime()
          {
            Debug.Assert(flagHasSunsetDateAndTime);
            return storeSunsetDateAndTime;
          }

        public bool  hasMoonPhaseText()
          {
            return flagHasMoonPhaseText;
          }

        public MoonPhaseDataJSON   getMoonPhaseText()
          {
            Debug.Assert(flagHasMoonPhaseText);
            return storeMoonPhaseText;
          }

        public MoonPhaseDataJSON.TypeValue  getMoonPhaseTextValue()
          {
            return getMoonPhaseText().getValue();
          }

        public string  getMoonPhaseTextAsString()
          {
            return getMoonPhaseText().getValueAsString();
          }

        public bool  hasMoonPhaseTextDisplay()
          {
            return flagHasMoonPhaseTextDisplay;
          }

        public string  getMoonPhaseTextDisplay()
          {
            Debug.Assert(flagHasMoonPhaseTextDisplay);
            return storeMoonPhaseTextDisplay;
          }

        public bool  hasMoonPhaseTextSpoken()
          {
            return flagHasMoonPhaseTextSpoken;
          }

        public string  getMoonPhaseTextSpoken()
          {
            Debug.Assert(flagHasMoonPhaseTextSpoken);
            return storeMoonPhaseTextSpoken;
          }

        public bool  hasMoonPhaseTextWritten()
          {
            return flagHasMoonPhaseTextWritten;
          }

        public string  getMoonPhaseTextWritten()
          {
            Debug.Assert(flagHasMoonPhaseTextWritten);
            return storeMoonPhaseTextWritten;
          }

        public bool  hasMoonPhasePct()
          {
            return flagHasMoonPhasePct;
          }

        public sbyte  getMoonPhasePct()
          {
            Debug.Assert(flagHasMoonPhasePct);
            return storeMoonPhasePct;
          }

        public bool  hasPrecipitation()
          {
            return flagHasPrecipitation;
          }

        public TypePrecipitationJSON   getPrecipitation()
          {
            Debug.Assert(flagHasPrecipitation);
            return storePrecipitation;
          }

        public bool  hasSnowfall()
          {
            return flagHasSnowfall;
          }

        public TypeSnowfallJSON   getSnowfall()
          {
            Debug.Assert(flagHasSnowfall);
            return storeSnowfall;
          }

        public bool  hasSnowfallMonthToDate()
          {
            return flagHasSnowfallMonthToDate;
          }

        public TypeSnowfallMonthToDateJSON   getSnowfallMonthToDate()
          {
            Debug.Assert(flagHasSnowfallMonthToDate);
            return storeSnowfallMonthToDate;
          }

        public bool  hasSnowfallSinceJulyFirst()
          {
            return flagHasSnowfallSinceJulyFirst;
          }

        public TypeSnowfallSinceJulyFirstJSON   getSnowfallSinceJulyFirst()
          {
            Debug.Assert(flagHasSnowfallSinceJulyFirst);
            return storeSnowfallSinceJulyFirst;
          }

        public bool  hasSnowDepth()
          {
            return flagHasSnowDepth;
          }

        public TypeSnowDepthJSON   getSnowDepth()
          {
            Debug.Assert(flagHasSnowDepth);
            return storeSnowDepth;
          }

        public bool  hasMaxTemperature()
          {
            return flagHasMaxTemperature;
          }

        public TypeMaxTemperatureJSON   getMaxTemperature()
          {
            Debug.Assert(flagHasMaxTemperature);
            return storeMaxTemperature;
          }

        public bool  hasAvgTemperature()
          {
            return flagHasAvgTemperature;
          }

        public TypeAvgTemperatureJSON   getAvgTemperature()
          {
            Debug.Assert(flagHasAvgTemperature);
            return storeAvgTemperature;
          }

        public bool  hasMinTemperature()
          {
            return flagHasMinTemperature;
          }

        public TypeMinTemperatureJSON   getMinTemperature()
          {
            Debug.Assert(flagHasMinTemperature);
            return storeMinTemperature;
          }

        public bool  hasMaxDewPoint()
          {
            return flagHasMaxDewPoint;
          }

        public TypeMaxDewPointJSON   getMaxDewPoint()
          {
            Debug.Assert(flagHasMaxDewPoint);
            return storeMaxDewPoint;
          }

        public bool  hasAvgDewPoint()
          {
            return flagHasAvgDewPoint;
          }

        public TypeAvgDewPointJSON   getAvgDewPoint()
          {
            Debug.Assert(flagHasAvgDewPoint);
            return storeAvgDewPoint;
          }

        public bool  hasMinDewPoint()
          {
            return flagHasMinDewPoint;
          }

        public TypeMinDewPointJSON   getMinDewPoint()
          {
            Debug.Assert(flagHasMinDewPoint);
            return storeMinDewPoint;
          }

        public bool  hasMaxHumidityPct()
          {
            return flagHasMaxHumidityPct;
          }

        public sbyte  getMaxHumidityPct()
          {
            Debug.Assert(flagHasMaxHumidityPct);
            return storeMaxHumidityPct;
          }

        public bool  hasAvgHumidityPct()
          {
            return flagHasAvgHumidityPct;
          }

        public sbyte  getAvgHumidityPct()
          {
            Debug.Assert(flagHasAvgHumidityPct);
            return storeAvgHumidityPct;
          }

        public bool  hasMinHumidityPct()
          {
            return flagHasMinHumidityPct;
          }

        public sbyte  getMinHumidityPct()
          {
            Debug.Assert(flagHasMinHumidityPct);
            return storeMinHumidityPct;
          }

        public bool  hasMaxPressure()
          {
            return flagHasMaxPressure;
          }

        public TypeMaxPressureJSON   getMaxPressure()
          {
            Debug.Assert(flagHasMaxPressure);
            return storeMaxPressure;
          }

        public bool  hasAvgPressure()
          {
            return flagHasAvgPressure;
          }

        public TypeAvgPressureJSON   getAvgPressure()
          {
            Debug.Assert(flagHasAvgPressure);
            return storeAvgPressure;
          }

        public bool  hasMinPressure()
          {
            return flagHasMinPressure;
          }

        public TypeMinPressureJSON   getMinPressure()
          {
            Debug.Assert(flagHasMinPressure);
            return storeMinPressure;
          }

        public bool  hasMaxWind()
          {
            return flagHasMaxWind;
          }

        public TypeMaxWindJSON   getMaxWind()
          {
            Debug.Assert(flagHasMaxWind);
            return storeMaxWind;
          }

        public bool  hasAvgWind()
          {
            return flagHasAvgWind;
          }

        public WindDataJSON   getAvgWind()
          {
            Debug.Assert(flagHasAvgWind);
            return storeAvgWind;
          }

        public bool  hasMinWind()
          {
            return flagHasMinWind;
          }

        public TypeMinWindJSON   getMinWind()
          {
            Debug.Assert(flagHasMinWind);
            return storeMinWind;
          }

        public bool  hasMaxVisibility()
          {
            return flagHasMaxVisibility;
          }

        public TypeMaxVisibilityJSON   getMaxVisibility()
          {
            Debug.Assert(flagHasMaxVisibility);
            return storeMaxVisibility;
          }

        public bool  hasAvgVisibility()
          {
            return flagHasAvgVisibility;
          }

        public TypeAvgVisibilityJSON   getAvgVisibility()
          {
            Debug.Assert(flagHasAvgVisibility);
            return storeAvgVisibility;
          }

        public bool  hasMinVisibility()
          {
            return flagHasMinVisibility;
          }

        public TypeMinVisibilityJSON   getMinVisibility()
          {
            Debug.Assert(flagHasMinVisibility);
            return storeMinVisibility;
          }

        public bool  hasFog()
          {
            return flagHasFog;
          }

        public bool  getFog()
          {
            Debug.Assert(flagHasFog);
            return storeFog;
          }

        public bool  hasRain()
          {
            return flagHasRain;
          }

        public bool  getRain()
          {
            Debug.Assert(flagHasRain);
            return storeRain;
          }

        public bool  hasSnow()
          {
            return flagHasSnow;
          }

        public bool  getSnow()
          {
            Debug.Assert(flagHasSnow);
            return storeSnow;
          }

        public bool  hasHail()
          {
            return flagHasHail;
          }

        public bool  getHail()
          {
            Debug.Assert(flagHasHail);
            return storeHail;
          }

        public bool  hasThunder()
          {
            return flagHasThunder;
          }

        public bool  getThunder()
          {
            Debug.Assert(flagHasThunder);
            return storeThunder;
          }

        public bool  hasTornado()
          {
            return flagHasTornado;
          }

        public bool  getTornado()
          {
            Debug.Assert(flagHasTornado);
            return storeTornado;
          }


        public virtual int extraTypeDailySummaryComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDailySummaryComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDailySummaryComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDailySummaryLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setIsObservedConditions(bool new_value)
          {
            flagHasIsObservedConditions = true;
            storeIsObservedConditions = new_value;
          }
        public void unsetIsObservedConditions()
          {
            flagHasIsObservedConditions = false;
          }
        public void setDateAndTime(DateAndOrTimeJSON  new_value)
          {
            if (flagHasDateAndTime)
              {
              }
            flagHasDateAndTime = true;
            storeDateAndTime = new_value;
          }
        public void unsetDateAndTime()
          {
            if (flagHasDateAndTime)
              {
              }
            flagHasDateAndTime = false;
          }
        public void setSunriseDateAndTime(DateAndOrTimeJSON  new_value)
          {
            if (flagHasSunriseDateAndTime)
              {
              }
            flagHasSunriseDateAndTime = true;
            storeSunriseDateAndTime = new_value;
          }
        public void unsetSunriseDateAndTime()
          {
            if (flagHasSunriseDateAndTime)
              {
              }
            flagHasSunriseDateAndTime = false;
          }
        public void setSunsetDateAndTime(DateAndOrTimeJSON  new_value)
          {
            if (flagHasSunsetDateAndTime)
              {
              }
            flagHasSunsetDateAndTime = true;
            storeSunsetDateAndTime = new_value;
          }
        public void unsetSunsetDateAndTime()
          {
            if (flagHasSunsetDateAndTime)
              {
              }
            flagHasSunsetDateAndTime = false;
          }
        public void setMoonPhaseText(MoonPhaseDataJSON  new_value)
          {
            if (flagHasMoonPhaseText)
              {
              }
            flagHasMoonPhaseText = true;
            storeMoonPhaseText = new_value;
          }
        public void setMoonPhaseText(MoonPhaseDataJSON.TypeValue new_value)
          {
            setMoonPhaseText(new MoonPhaseDataJSON(new_value));
          }
        public void setMoonPhaseText(string chars)
          {
            MoonPhaseDataJSON.TypeValueKnownValues known = MoonPhaseDataJSON.stringToValue(chars);
            MoonPhaseDataJSON.TypeValue new_value = new MoonPhaseDataJSON.TypeValue();
            if (known == MoonPhaseDataJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setMoonPhaseText(new_value);
          }
        public void unsetMoonPhaseText()
          {
            if (flagHasMoonPhaseText)
              {
              }
            flagHasMoonPhaseText = false;
          }
        public void setMoonPhaseTextDisplay(string new_value)
          {
            flagHasMoonPhaseTextDisplay = true;
            storeMoonPhaseTextDisplay = new_value;
          }
        public void unsetMoonPhaseTextDisplay()
          {
            flagHasMoonPhaseTextDisplay = false;
          }
        public void setMoonPhaseTextSpoken(string new_value)
          {
            flagHasMoonPhaseTextSpoken = true;
            storeMoonPhaseTextSpoken = new_value;
          }
        public void unsetMoonPhaseTextSpoken()
          {
            flagHasMoonPhaseTextSpoken = false;
          }
        public void setMoonPhaseTextWritten(string new_value)
          {
            flagHasMoonPhaseTextWritten = true;
            storeMoonPhaseTextWritten = new_value;
          }
        public void unsetMoonPhaseTextWritten()
          {
            flagHasMoonPhaseTextWritten = false;
          }
        public void setMoonPhasePct(sbyte new_value)
          {
            flagHasMoonPhasePct = true;
            if (new_value < 0)
                throw new Exception("The value for field MoonPhasePct of TypeDailySummaryJSON is less than the lower bound (0) for that field.");
            if (new_value > 100)
                throw new Exception("The value for field MoonPhasePct of TypeDailySummaryJSON is greater than the upper bound (100) for that field.");
            storeMoonPhasePct = new_value;
          }
        public void unsetMoonPhasePct()
          {
            flagHasMoonPhasePct = false;
          }
        public void setPrecipitation(TypePrecipitationJSON  new_value)
          {
            if (flagHasPrecipitation)
              {
              }
            flagHasPrecipitation = true;
            storePrecipitation = new_value;
          }
        public void unsetPrecipitation()
          {
            if (flagHasPrecipitation)
              {
              }
            flagHasPrecipitation = false;
          }
        public void setSnowfall(TypeSnowfallJSON  new_value)
          {
            if (flagHasSnowfall)
              {
              }
            flagHasSnowfall = true;
            storeSnowfall = new_value;
          }
        public void unsetSnowfall()
          {
            if (flagHasSnowfall)
              {
              }
            flagHasSnowfall = false;
          }
        public void setSnowfallMonthToDate(TypeSnowfallMonthToDateJSON  new_value)
          {
            if (flagHasSnowfallMonthToDate)
              {
              }
            flagHasSnowfallMonthToDate = true;
            storeSnowfallMonthToDate = new_value;
          }
        public void unsetSnowfallMonthToDate()
          {
            if (flagHasSnowfallMonthToDate)
              {
              }
            flagHasSnowfallMonthToDate = false;
          }
        public void setSnowfallSinceJulyFirst(TypeSnowfallSinceJulyFirstJSON  new_value)
          {
            if (flagHasSnowfallSinceJulyFirst)
              {
              }
            flagHasSnowfallSinceJulyFirst = true;
            storeSnowfallSinceJulyFirst = new_value;
          }
        public void unsetSnowfallSinceJulyFirst()
          {
            if (flagHasSnowfallSinceJulyFirst)
              {
              }
            flagHasSnowfallSinceJulyFirst = false;
          }
        public void setSnowDepth(TypeSnowDepthJSON  new_value)
          {
            if (flagHasSnowDepth)
              {
              }
            flagHasSnowDepth = true;
            storeSnowDepth = new_value;
          }
        public void unsetSnowDepth()
          {
            if (flagHasSnowDepth)
              {
              }
            flagHasSnowDepth = false;
          }
        public void setMaxTemperature(TypeMaxTemperatureJSON  new_value)
          {
            if (flagHasMaxTemperature)
              {
              }
            flagHasMaxTemperature = true;
            storeMaxTemperature = new_value;
          }
        public void unsetMaxTemperature()
          {
            if (flagHasMaxTemperature)
              {
              }
            flagHasMaxTemperature = false;
          }
        public void setAvgTemperature(TypeAvgTemperatureJSON  new_value)
          {
            if (flagHasAvgTemperature)
              {
              }
            flagHasAvgTemperature = true;
            storeAvgTemperature = new_value;
          }
        public void unsetAvgTemperature()
          {
            if (flagHasAvgTemperature)
              {
              }
            flagHasAvgTemperature = false;
          }
        public void setMinTemperature(TypeMinTemperatureJSON  new_value)
          {
            if (flagHasMinTemperature)
              {
              }
            flagHasMinTemperature = true;
            storeMinTemperature = new_value;
          }
        public void unsetMinTemperature()
          {
            if (flagHasMinTemperature)
              {
              }
            flagHasMinTemperature = false;
          }
        public void setMaxDewPoint(TypeMaxDewPointJSON  new_value)
          {
            if (flagHasMaxDewPoint)
              {
              }
            flagHasMaxDewPoint = true;
            storeMaxDewPoint = new_value;
          }
        public void unsetMaxDewPoint()
          {
            if (flagHasMaxDewPoint)
              {
              }
            flagHasMaxDewPoint = false;
          }
        public void setAvgDewPoint(TypeAvgDewPointJSON  new_value)
          {
            if (flagHasAvgDewPoint)
              {
              }
            flagHasAvgDewPoint = true;
            storeAvgDewPoint = new_value;
          }
        public void unsetAvgDewPoint()
          {
            if (flagHasAvgDewPoint)
              {
              }
            flagHasAvgDewPoint = false;
          }
        public void setMinDewPoint(TypeMinDewPointJSON  new_value)
          {
            if (flagHasMinDewPoint)
              {
              }
            flagHasMinDewPoint = true;
            storeMinDewPoint = new_value;
          }
        public void unsetMinDewPoint()
          {
            if (flagHasMinDewPoint)
              {
              }
            flagHasMinDewPoint = false;
          }
        public void setMaxHumidityPct(sbyte new_value)
          {
            flagHasMaxHumidityPct = true;
            if (new_value < 0)
                throw new Exception("The value for field MaxHumidityPct of TypeDailySummaryJSON is less than the lower bound (0) for that field.");
            if (new_value > 100)
                throw new Exception("The value for field MaxHumidityPct of TypeDailySummaryJSON is greater than the upper bound (100) for that field.");
            storeMaxHumidityPct = new_value;
          }
        public void unsetMaxHumidityPct()
          {
            flagHasMaxHumidityPct = false;
          }
        public void setAvgHumidityPct(sbyte new_value)
          {
            flagHasAvgHumidityPct = true;
            if (new_value < 0)
                throw new Exception("The value for field AvgHumidityPct of TypeDailySummaryJSON is less than the lower bound (0) for that field.");
            if (new_value > 100)
                throw new Exception("The value for field AvgHumidityPct of TypeDailySummaryJSON is greater than the upper bound (100) for that field.");
            storeAvgHumidityPct = new_value;
          }
        public void unsetAvgHumidityPct()
          {
            flagHasAvgHumidityPct = false;
          }
        public void setMinHumidityPct(sbyte new_value)
          {
            flagHasMinHumidityPct = true;
            if (new_value < 0)
                throw new Exception("The value for field MinHumidityPct of TypeDailySummaryJSON is less than the lower bound (0) for that field.");
            if (new_value > 100)
                throw new Exception("The value for field MinHumidityPct of TypeDailySummaryJSON is greater than the upper bound (100) for that field.");
            storeMinHumidityPct = new_value;
          }
        public void unsetMinHumidityPct()
          {
            flagHasMinHumidityPct = false;
          }
        public void setMaxPressure(TypeMaxPressureJSON  new_value)
          {
            if (flagHasMaxPressure)
              {
              }
            flagHasMaxPressure = true;
            storeMaxPressure = new_value;
          }
        public void unsetMaxPressure()
          {
            if (flagHasMaxPressure)
              {
              }
            flagHasMaxPressure = false;
          }
        public void setAvgPressure(TypeAvgPressureJSON  new_value)
          {
            if (flagHasAvgPressure)
              {
              }
            flagHasAvgPressure = true;
            storeAvgPressure = new_value;
          }
        public void unsetAvgPressure()
          {
            if (flagHasAvgPressure)
              {
              }
            flagHasAvgPressure = false;
          }
        public void setMinPressure(TypeMinPressureJSON  new_value)
          {
            if (flagHasMinPressure)
              {
              }
            flagHasMinPressure = true;
            storeMinPressure = new_value;
          }
        public void unsetMinPressure()
          {
            if (flagHasMinPressure)
              {
              }
            flagHasMinPressure = false;
          }
        public void setMaxWind(TypeMaxWindJSON  new_value)
          {
            if (flagHasMaxWind)
              {
              }
            flagHasMaxWind = true;
            storeMaxWind = new_value;
          }
        public void unsetMaxWind()
          {
            if (flagHasMaxWind)
              {
              }
            flagHasMaxWind = false;
          }
        public void setAvgWind(WindDataJSON  new_value)
          {
            if (flagHasAvgWind)
              {
              }
            flagHasAvgWind = true;
            storeAvgWind = new_value;
          }
        public void unsetAvgWind()
          {
            if (flagHasAvgWind)
              {
              }
            flagHasAvgWind = false;
          }
        public void setMinWind(TypeMinWindJSON  new_value)
          {
            if (flagHasMinWind)
              {
              }
            flagHasMinWind = true;
            storeMinWind = new_value;
          }
        public void unsetMinWind()
          {
            if (flagHasMinWind)
              {
              }
            flagHasMinWind = false;
          }
        public void setMaxVisibility(TypeMaxVisibilityJSON  new_value)
          {
            if (flagHasMaxVisibility)
              {
              }
            flagHasMaxVisibility = true;
            storeMaxVisibility = new_value;
          }
        public void unsetMaxVisibility()
          {
            if (flagHasMaxVisibility)
              {
              }
            flagHasMaxVisibility = false;
          }
        public void setAvgVisibility(TypeAvgVisibilityJSON  new_value)
          {
            if (flagHasAvgVisibility)
              {
              }
            flagHasAvgVisibility = true;
            storeAvgVisibility = new_value;
          }
        public void unsetAvgVisibility()
          {
            if (flagHasAvgVisibility)
              {
              }
            flagHasAvgVisibility = false;
          }
        public void setMinVisibility(TypeMinVisibilityJSON  new_value)
          {
            if (flagHasMinVisibility)
              {
              }
            flagHasMinVisibility = true;
            storeMinVisibility = new_value;
          }
        public void unsetMinVisibility()
          {
            if (flagHasMinVisibility)
              {
              }
            flagHasMinVisibility = false;
          }
        public void setFog(bool new_value)
          {
            flagHasFog = true;
            storeFog = new_value;
          }
        public void unsetFog()
          {
            flagHasFog = false;
          }
        public void setRain(bool new_value)
          {
            flagHasRain = true;
            storeRain = new_value;
          }
        public void unsetRain()
          {
            flagHasRain = false;
          }
        public void setSnow(bool new_value)
          {
            flagHasSnow = true;
            storeSnow = new_value;
          }
        public void unsetSnow()
          {
            flagHasSnow = false;
          }
        public void setHail(bool new_value)
          {
            flagHasHail = true;
            storeHail = new_value;
          }
        public void unsetHail()
          {
            flagHasHail = false;
          }
        public void setThunder(bool new_value)
          {
            flagHasThunder = true;
            storeThunder = new_value;
          }
        public void unsetThunder()
          {
            flagHasThunder = false;
          }
        public void setTornado(bool new_value)
          {
            flagHasTornado = true;
            storeTornado = new_value;
          }
        public void unsetTornado()
          {
            flagHasTornado = false;
          }

        public virtual void extraTypeDailySummaryAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDailySummarySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDailySummaryLookup(key);
            if (old_field == null)
              {
                extraTypeDailySummaryAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasIsObservedConditions);
            if (flagHasIsObservedConditions)
              {
                handler.start_pair("IsObservedConditions");
                handler.boolean_value(storeIsObservedConditions);
              }
            Debug.Assert(partial_allowed || flagHasDateAndTime);
            if (flagHasDateAndTime)
              {
                handler.start_pair("DateAndTime");
                if (partial_allowed)
                    storeDateAndTime.write_partial_as_json(handler);
                else
                    storeDateAndTime.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasSunriseDateAndTime);
            if (flagHasSunriseDateAndTime)
              {
                handler.start_pair("SunriseDateAndTime");
                if (partial_allowed)
                    storeSunriseDateAndTime.write_partial_as_json(handler);
                else
                    storeSunriseDateAndTime.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasSunsetDateAndTime);
            if (flagHasSunsetDateAndTime)
              {
                handler.start_pair("SunsetDateAndTime");
                if (partial_allowed)
                    storeSunsetDateAndTime.write_partial_as_json(handler);
                else
                    storeSunsetDateAndTime.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasMoonPhaseText);
            if (flagHasMoonPhaseText)
              {
                handler.start_pair("MoonPhaseText");
                if (partial_allowed)
                    storeMoonPhaseText.write_partial_as_json(handler);
                else
                    storeMoonPhaseText.write_as_json(handler);
              }
            if (flagHasMoonPhaseTextDisplay)
              {
                handler.start_pair("MoonPhaseTextDisplay");
                handler.string_value(storeMoonPhaseTextDisplay);
              }
            if (flagHasMoonPhaseTextSpoken)
              {
                handler.start_pair("MoonPhaseTextSpoken");
                handler.string_value(storeMoonPhaseTextSpoken);
              }
            if (flagHasMoonPhaseTextWritten)
              {
                handler.start_pair("MoonPhaseTextWritten");
                handler.string_value(storeMoonPhaseTextWritten);
              }
            Debug.Assert(partial_allowed || flagHasMoonPhasePct);
            if (flagHasMoonPhasePct)
              {
                handler.start_pair("MoonPhasePct");
                handler.number_value(storeMoonPhasePct);
              }
            if (flagHasPrecipitation)
              {
                handler.start_pair("Precipitation");
                if (partial_allowed)
                    storePrecipitation.write_partial_as_json(handler);
                else
                    storePrecipitation.write_as_json(handler);
              }
            if (flagHasSnowfall)
              {
                handler.start_pair("Snowfall");
                if (partial_allowed)
                    storeSnowfall.write_partial_as_json(handler);
                else
                    storeSnowfall.write_as_json(handler);
              }
            if (flagHasSnowfallMonthToDate)
              {
                handler.start_pair("SnowfallMonthToDate");
                if (partial_allowed)
                    storeSnowfallMonthToDate.write_partial_as_json(handler);
                else
                    storeSnowfallMonthToDate.write_as_json(handler);
              }
            if (flagHasSnowfallSinceJulyFirst)
              {
                handler.start_pair("SnowfallSinceJulyFirst");
                if (partial_allowed)
                    storeSnowfallSinceJulyFirst.write_partial_as_json(handler);
                else
                    storeSnowfallSinceJulyFirst.write_as_json(handler);
              }
            if (flagHasSnowDepth)
              {
                handler.start_pair("SnowDepth");
                if (partial_allowed)
                    storeSnowDepth.write_partial_as_json(handler);
                else
                    storeSnowDepth.write_as_json(handler);
              }
            if (flagHasMaxTemperature)
              {
                handler.start_pair("MaxTemperature");
                if (partial_allowed)
                    storeMaxTemperature.write_partial_as_json(handler);
                else
                    storeMaxTemperature.write_as_json(handler);
              }
            if (flagHasAvgTemperature)
              {
                handler.start_pair("AvgTemperature");
                if (partial_allowed)
                    storeAvgTemperature.write_partial_as_json(handler);
                else
                    storeAvgTemperature.write_as_json(handler);
              }
            if (flagHasMinTemperature)
              {
                handler.start_pair("MinTemperature");
                if (partial_allowed)
                    storeMinTemperature.write_partial_as_json(handler);
                else
                    storeMinTemperature.write_as_json(handler);
              }
            if (flagHasMaxDewPoint)
              {
                handler.start_pair("MaxDewPoint");
                if (partial_allowed)
                    storeMaxDewPoint.write_partial_as_json(handler);
                else
                    storeMaxDewPoint.write_as_json(handler);
              }
            if (flagHasAvgDewPoint)
              {
                handler.start_pair("AvgDewPoint");
                if (partial_allowed)
                    storeAvgDewPoint.write_partial_as_json(handler);
                else
                    storeAvgDewPoint.write_as_json(handler);
              }
            if (flagHasMinDewPoint)
              {
                handler.start_pair("MinDewPoint");
                if (partial_allowed)
                    storeMinDewPoint.write_partial_as_json(handler);
                else
                    storeMinDewPoint.write_as_json(handler);
              }
            if (flagHasMaxHumidityPct)
              {
                handler.start_pair("MaxHumidityPct");
                handler.number_value(storeMaxHumidityPct);
              }
            if (flagHasAvgHumidityPct)
              {
                handler.start_pair("AvgHumidityPct");
                handler.number_value(storeAvgHumidityPct);
              }
            if (flagHasMinHumidityPct)
              {
                handler.start_pair("MinHumidityPct");
                handler.number_value(storeMinHumidityPct);
              }
            if (flagHasMaxPressure)
              {
                handler.start_pair("MaxPressure");
                if (partial_allowed)
                    storeMaxPressure.write_partial_as_json(handler);
                else
                    storeMaxPressure.write_as_json(handler);
              }
            if (flagHasAvgPressure)
              {
                handler.start_pair("AvgPressure");
                if (partial_allowed)
                    storeAvgPressure.write_partial_as_json(handler);
                else
                    storeAvgPressure.write_as_json(handler);
              }
            if (flagHasMinPressure)
              {
                handler.start_pair("MinPressure");
                if (partial_allowed)
                    storeMinPressure.write_partial_as_json(handler);
                else
                    storeMinPressure.write_as_json(handler);
              }
            if (flagHasMaxWind)
              {
                handler.start_pair("MaxWind");
                if (partial_allowed)
                    storeMaxWind.write_partial_as_json(handler);
                else
                    storeMaxWind.write_as_json(handler);
              }
            if (flagHasAvgWind)
              {
                handler.start_pair("AvgWind");
                if (partial_allowed)
                    storeAvgWind.write_partial_as_json(handler);
                else
                    storeAvgWind.write_as_json(handler);
              }
            if (flagHasMinWind)
              {
                handler.start_pair("MinWind");
                if (partial_allowed)
                    storeMinWind.write_partial_as_json(handler);
                else
                    storeMinWind.write_as_json(handler);
              }
            if (flagHasMaxVisibility)
              {
                handler.start_pair("MaxVisibility");
                if (partial_allowed)
                    storeMaxVisibility.write_partial_as_json(handler);
                else
                    storeMaxVisibility.write_as_json(handler);
              }
            if (flagHasAvgVisibility)
              {
                handler.start_pair("AvgVisibility");
                if (partial_allowed)
                    storeAvgVisibility.write_partial_as_json(handler);
                else
                    storeAvgVisibility.write_as_json(handler);
              }
            if (flagHasMinVisibility)
              {
                handler.start_pair("MinVisibility");
                if (partial_allowed)
                    storeMinVisibility.write_partial_as_json(handler);
                else
                    storeMinVisibility.write_as_json(handler);
              }
            if (flagHasFog)
              {
                handler.start_pair("Fog");
                handler.boolean_value(storeFog);
              }
            if (flagHasRain)
              {
                handler.start_pair("Rain");
                handler.boolean_value(storeRain);
              }
            if (flagHasSnow)
              {
                handler.start_pair("Snow");
                handler.boolean_value(storeSnow);
              }
            if (flagHasHail)
              {
                handler.start_pair("Hail");
                handler.boolean_value(storeHail);
              }
            if (flagHasThunder)
              {
                handler.start_pair("Thunder");
                handler.boolean_value(storeThunder);
              }
            if (flagHasTornado)
              {
                handler.start_pair("Tornado");
                handler.boolean_value(storeTornado);
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
            if (!(hasIsObservedConditions()))
              {
                return "When parsing the object for %what%, the \"IsObservedConditions\" field was missing.";
              }
            if (!(hasDateAndTime()))
              {
                return "When parsing the object for %what%, the \"DateAndTime\" field was missing.";
              }
            if (!(hasSunriseDateAndTime()))
              {
                return "When parsing the object for %what%, the \"SunriseDateAndTime\" field was missing.";
              }
            if (!(hasSunsetDateAndTime()))
              {
                return "When parsing the object for %what%, the \"SunsetDateAndTime\" field was missing.";
              }
            if (!(hasMoonPhaseText()))
              {
                return "When parsing the object for %what%, the \"MoonPhaseText\" field was missing.";
              }
            if (!(hasMoonPhasePct()))
              {
                return "When parsing the object for %what%, the \"MoonPhasePct\" field was missing.";
              }
            return null;
          }

        public static TypeDailySummaryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDailySummaryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDailySummary", ignore_extras);
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
        public static TypeDailySummaryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDailySummaryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDailySummaryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDailySummary", ignore_extras);
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
        public static TypeDailySummaryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDailySummaryJSON from_text(string text, bool ignore_extras)
          {
            TypeDailySummaryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDailySummary", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDailySummaryJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDailySummaryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDailySummaryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDailySummary", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorIsObservedConditions;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDateAndTime;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorSunriseDateAndTime;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorSunsetDateAndTime;
            private MoonPhaseDataJSON.HoldingGenerator fieldGeneratorMoonPhaseText;
            private JSONHoldingStringGenerator fieldGeneratorMoonPhaseTextDisplay;
            private JSONHoldingStringGenerator fieldGeneratorMoonPhaseTextSpoken;
            private JSONHoldingStringGenerator fieldGeneratorMoonPhaseTextWritten;
        private class FieldHoldingGeneratorMoonPhasePct : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorMoonPhasePct(String what) : base(what, 0, 100)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMoonPhasePct : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorMoonPhasePct(String what) : base(what, 0, 100)
                  {
                  }
              };
            private FieldHoldingGeneratorMoonPhasePct fieldGeneratorMoonPhasePct;
            private TypePrecipitationJSON.HoldingGenerator fieldGeneratorPrecipitation;
            private TypeSnowfallJSON.HoldingGenerator fieldGeneratorSnowfall;
            private TypeSnowfallMonthToDateJSON.HoldingGenerator fieldGeneratorSnowfallMonthToDate;
            private TypeSnowfallSinceJulyFirstJSON.HoldingGenerator fieldGeneratorSnowfallSinceJulyFirst;
            private TypeSnowDepthJSON.HoldingGenerator fieldGeneratorSnowDepth;
            private TypeMaxTemperatureJSON.HoldingGenerator fieldGeneratorMaxTemperature;
            private TypeAvgTemperatureJSON.HoldingGenerator fieldGeneratorAvgTemperature;
            private TypeMinTemperatureJSON.HoldingGenerator fieldGeneratorMinTemperature;
            private TypeMaxDewPointJSON.HoldingGenerator fieldGeneratorMaxDewPoint;
            private TypeAvgDewPointJSON.HoldingGenerator fieldGeneratorAvgDewPoint;
            private TypeMinDewPointJSON.HoldingGenerator fieldGeneratorMinDewPoint;
        private class FieldHoldingGeneratorMaxHumidityPct : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorMaxHumidityPct(String what) : base(what, 0, 100)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMaxHumidityPct : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorMaxHumidityPct(String what) : base(what, 0, 100)
                  {
                  }
              };
            private FieldHoldingGeneratorMaxHumidityPct fieldGeneratorMaxHumidityPct;
        private class FieldHoldingGeneratorAvgHumidityPct : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorAvgHumidityPct(String what) : base(what, 0, 100)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorAvgHumidityPct : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorAvgHumidityPct(String what) : base(what, 0, 100)
                  {
                  }
              };
            private FieldHoldingGeneratorAvgHumidityPct fieldGeneratorAvgHumidityPct;
        private class FieldHoldingGeneratorMinHumidityPct : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorMinHumidityPct(String what) : base(what, 0, 100)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMinHumidityPct : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorMinHumidityPct(String what) : base(what, 0, 100)
                  {
                  }
              };
            private FieldHoldingGeneratorMinHumidityPct fieldGeneratorMinHumidityPct;
            private TypeMaxPressureJSON.HoldingGenerator fieldGeneratorMaxPressure;
            private TypeAvgPressureJSON.HoldingGenerator fieldGeneratorAvgPressure;
            private TypeMinPressureJSON.HoldingGenerator fieldGeneratorMinPressure;
            private TypeMaxWindJSON.HoldingGenerator fieldGeneratorMaxWind;
            private WindDataJSON.HoldingGenerator fieldGeneratorAvgWind;
            private TypeMinWindJSON.HoldingGenerator fieldGeneratorMinWind;
            private TypeMaxVisibilityJSON.HoldingGenerator fieldGeneratorMaxVisibility;
            private TypeAvgVisibilityJSON.HoldingGenerator fieldGeneratorAvgVisibility;
            private TypeMinVisibilityJSON.HoldingGenerator fieldGeneratorMinVisibility;
            private JSONHoldingBooleanGenerator fieldGeneratorFog;
            private JSONHoldingBooleanGenerator fieldGeneratorRain;
            private JSONHoldingBooleanGenerator fieldGeneratorSnow;
            private JSONHoldingBooleanGenerator fieldGeneratorHail;
            private JSONHoldingBooleanGenerator fieldGeneratorThunder;
            private JSONHoldingBooleanGenerator fieldGeneratorTornado;
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
                TypeDailySummaryJSON result = new TypeDailySummaryJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDailySummaryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDailySummaryJSON result)
              {
                if (fieldGeneratorIsObservedConditions.have_value)
                  {
                    result.setIsObservedConditions(fieldGeneratorIsObservedConditions.value);
                    fieldGeneratorIsObservedConditions.have_value = false;
                  }
                else if ((!(result.hasIsObservedConditions())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"IsObservedConditions\" field was missing.");
                  }
                if (fieldGeneratorDateAndTime.have_value)
                  {
                    result.setDateAndTime(fieldGeneratorDateAndTime.value);
                    fieldGeneratorDateAndTime.have_value = false;
                  }
                else if ((!(result.hasDateAndTime())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"DateAndTime\" field was missing.");
                  }
                if (fieldGeneratorSunriseDateAndTime.have_value)
                  {
                    result.setSunriseDateAndTime(fieldGeneratorSunriseDateAndTime.value);
                    fieldGeneratorSunriseDateAndTime.have_value = false;
                  }
                else if ((!(result.hasSunriseDateAndTime())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SunriseDateAndTime\" field was missing.");
                  }
                if (fieldGeneratorSunsetDateAndTime.have_value)
                  {
                    result.setSunsetDateAndTime(fieldGeneratorSunsetDateAndTime.value);
                    fieldGeneratorSunsetDateAndTime.have_value = false;
                  }
                else if ((!(result.hasSunsetDateAndTime())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SunsetDateAndTime\" field was missing.");
                  }
                if (fieldGeneratorMoonPhaseText.have_value)
                  {
                    result.setMoonPhaseText(fieldGeneratorMoonPhaseText.value);
                    fieldGeneratorMoonPhaseText.have_value = false;
                  }
                else if ((!(result.hasMoonPhaseText())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"MoonPhaseText\" field was missing.");
                  }
                if (fieldGeneratorMoonPhaseTextDisplay.have_value)
                  {
                    result.setMoonPhaseTextDisplay(fieldGeneratorMoonPhaseTextDisplay.value);
                    fieldGeneratorMoonPhaseTextDisplay.have_value = false;
                  }
                if (fieldGeneratorMoonPhaseTextSpoken.have_value)
                  {
                    result.setMoonPhaseTextSpoken(fieldGeneratorMoonPhaseTextSpoken.value);
                    fieldGeneratorMoonPhaseTextSpoken.have_value = false;
                  }
                if (fieldGeneratorMoonPhaseTextWritten.have_value)
                  {
                    result.setMoonPhaseTextWritten(fieldGeneratorMoonPhaseTextWritten.value);
                    fieldGeneratorMoonPhaseTextWritten.have_value = false;
                  }
                if (fieldGeneratorMoonPhasePct.have_value)
                  {
                    result.setMoonPhasePct((sbyte)(fieldGeneratorMoonPhasePct.value));
                    fieldGeneratorMoonPhasePct.have_value = false;
                  }
                else if ((!(result.hasMoonPhasePct())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"MoonPhasePct\" field was missing.");
                  }
                if (fieldGeneratorPrecipitation.have_value)
                  {
                    result.setPrecipitation(fieldGeneratorPrecipitation.value);
                    fieldGeneratorPrecipitation.have_value = false;
                  }
                if (fieldGeneratorSnowfall.have_value)
                  {
                    result.setSnowfall(fieldGeneratorSnowfall.value);
                    fieldGeneratorSnowfall.have_value = false;
                  }
                if (fieldGeneratorSnowfallMonthToDate.have_value)
                  {
                    result.setSnowfallMonthToDate(fieldGeneratorSnowfallMonthToDate.value);
                    fieldGeneratorSnowfallMonthToDate.have_value = false;
                  }
                if (fieldGeneratorSnowfallSinceJulyFirst.have_value)
                  {
                    result.setSnowfallSinceJulyFirst(fieldGeneratorSnowfallSinceJulyFirst.value);
                    fieldGeneratorSnowfallSinceJulyFirst.have_value = false;
                  }
                if (fieldGeneratorSnowDepth.have_value)
                  {
                    result.setSnowDepth(fieldGeneratorSnowDepth.value);
                    fieldGeneratorSnowDepth.have_value = false;
                  }
                if (fieldGeneratorMaxTemperature.have_value)
                  {
                    result.setMaxTemperature(fieldGeneratorMaxTemperature.value);
                    fieldGeneratorMaxTemperature.have_value = false;
                  }
                if (fieldGeneratorAvgTemperature.have_value)
                  {
                    result.setAvgTemperature(fieldGeneratorAvgTemperature.value);
                    fieldGeneratorAvgTemperature.have_value = false;
                  }
                if (fieldGeneratorMinTemperature.have_value)
                  {
                    result.setMinTemperature(fieldGeneratorMinTemperature.value);
                    fieldGeneratorMinTemperature.have_value = false;
                  }
                if (fieldGeneratorMaxDewPoint.have_value)
                  {
                    result.setMaxDewPoint(fieldGeneratorMaxDewPoint.value);
                    fieldGeneratorMaxDewPoint.have_value = false;
                  }
                if (fieldGeneratorAvgDewPoint.have_value)
                  {
                    result.setAvgDewPoint(fieldGeneratorAvgDewPoint.value);
                    fieldGeneratorAvgDewPoint.have_value = false;
                  }
                if (fieldGeneratorMinDewPoint.have_value)
                  {
                    result.setMinDewPoint(fieldGeneratorMinDewPoint.value);
                    fieldGeneratorMinDewPoint.have_value = false;
                  }
                if (fieldGeneratorMaxHumidityPct.have_value)
                  {
                    result.setMaxHumidityPct((sbyte)(fieldGeneratorMaxHumidityPct.value));
                    fieldGeneratorMaxHumidityPct.have_value = false;
                  }
                if (fieldGeneratorAvgHumidityPct.have_value)
                  {
                    result.setAvgHumidityPct((sbyte)(fieldGeneratorAvgHumidityPct.value));
                    fieldGeneratorAvgHumidityPct.have_value = false;
                  }
                if (fieldGeneratorMinHumidityPct.have_value)
                  {
                    result.setMinHumidityPct((sbyte)(fieldGeneratorMinHumidityPct.value));
                    fieldGeneratorMinHumidityPct.have_value = false;
                  }
                if (fieldGeneratorMaxPressure.have_value)
                  {
                    result.setMaxPressure(fieldGeneratorMaxPressure.value);
                    fieldGeneratorMaxPressure.have_value = false;
                  }
                if (fieldGeneratorAvgPressure.have_value)
                  {
                    result.setAvgPressure(fieldGeneratorAvgPressure.value);
                    fieldGeneratorAvgPressure.have_value = false;
                  }
                if (fieldGeneratorMinPressure.have_value)
                  {
                    result.setMinPressure(fieldGeneratorMinPressure.value);
                    fieldGeneratorMinPressure.have_value = false;
                  }
                if (fieldGeneratorMaxWind.have_value)
                  {
                    result.setMaxWind(fieldGeneratorMaxWind.value);
                    fieldGeneratorMaxWind.have_value = false;
                  }
                if (fieldGeneratorAvgWind.have_value)
                  {
                    result.setAvgWind(fieldGeneratorAvgWind.value);
                    fieldGeneratorAvgWind.have_value = false;
                  }
                if (fieldGeneratorMinWind.have_value)
                  {
                    result.setMinWind(fieldGeneratorMinWind.value);
                    fieldGeneratorMinWind.have_value = false;
                  }
                if (fieldGeneratorMaxVisibility.have_value)
                  {
                    result.setMaxVisibility(fieldGeneratorMaxVisibility.value);
                    fieldGeneratorMaxVisibility.have_value = false;
                  }
                if (fieldGeneratorAvgVisibility.have_value)
                  {
                    result.setAvgVisibility(fieldGeneratorAvgVisibility.value);
                    fieldGeneratorAvgVisibility.have_value = false;
                  }
                if (fieldGeneratorMinVisibility.have_value)
                  {
                    result.setMinVisibility(fieldGeneratorMinVisibility.value);
                    fieldGeneratorMinVisibility.have_value = false;
                  }
                if (fieldGeneratorFog.have_value)
                  {
                    result.setFog(fieldGeneratorFog.value);
                    fieldGeneratorFog.have_value = false;
                  }
                if (fieldGeneratorRain.have_value)
                  {
                    result.setRain(fieldGeneratorRain.value);
                    fieldGeneratorRain.have_value = false;
                  }
                if (fieldGeneratorSnow.have_value)
                  {
                    result.setSnow(fieldGeneratorSnow.value);
                    fieldGeneratorSnow.have_value = false;
                  }
                if (fieldGeneratorHail.have_value)
                  {
                    result.setHail(fieldGeneratorHail.value);
                    fieldGeneratorHail.have_value = false;
                  }
                if (fieldGeneratorThunder.have_value)
                  {
                    result.setThunder(fieldGeneratorThunder.value);
                    fieldGeneratorThunder.have_value = false;
                  }
                if (fieldGeneratorTornado.have_value)
                  {
                    result.setTornado(fieldGeneratorTornado.value);
                    fieldGeneratorTornado.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeDailySummaryJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if (String.Compare(field_name, 1, "vg", 0, 2, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 4, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorAvgDewPoint;
                                    break;
                                case 'H':
                                    if ((String.Compare(field_name, 4, "umidityPct", 0, 10, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorAvgHumidityPct;
                                    break;
                                case 'P':
                                    if ((String.Compare(field_name, 4, "ressure", 0, 7, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorAvgPressure;
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 4, "emperature", 0, 10, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorAvgTemperature;
                                    break;
                                case 'V':
                                    if ((String.Compare(field_name, 4, "isibility", 0, 9, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorAvgVisibility;
                                    break;
                                case 'W':
                                    if ((String.Compare(field_name, 4, "ind", 0, 3, false) == 0) && (field_name.Length == 7))
                                        return fieldGeneratorAvgWind;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'D':
                        if ((String.Compare(field_name, 1, "ateAndTime", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorDateAndTime;
                        break;
                    case 'F':
                        if ((String.Compare(field_name, 1, "og", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorFog;
                        break;
                    case 'H':
                        if ((String.Compare(field_name, 1, "ail", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorHail;
                        break;
                    case 'I':
                        if ((String.Compare(field_name, 1, "sObservedConditions", 0, 19, false) == 0) && (field_name.Length == 20))
                            return fieldGeneratorIsObservedConditions;
                        break;
                    case 'M':
                        switch (field_name[1])
                          {
                            case 'a':
                                if (String.Compare(field_name, 2, "x", 0, 1, false) == 0)
                                  {
                                    switch (field_name[3])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 4, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorMaxDewPoint;
                                            break;
                                        case 'H':
                                            if ((String.Compare(field_name, 4, "umidityPct", 0, 10, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorMaxHumidityPct;
                                            break;
                                        case 'P':
                                            if ((String.Compare(field_name, 4, "ressure", 0, 7, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorMaxPressure;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 4, "emperature", 0, 10, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorMaxTemperature;
                                            break;
                                        case 'V':
                                            if ((String.Compare(field_name, 4, "isibility", 0, 9, false) == 0) && (field_name.Length == 13))
                                                return fieldGeneratorMaxVisibility;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 4, "ind", 0, 3, false) == 0) && (field_name.Length == 7))
                                                return fieldGeneratorMaxWind;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'i':
                                if (String.Compare(field_name, 2, "n", 0, 1, false) == 0)
                                  {
                                    switch (field_name[3])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 4, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorMinDewPoint;
                                            break;
                                        case 'H':
                                            if ((String.Compare(field_name, 4, "umidityPct", 0, 10, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorMinHumidityPct;
                                            break;
                                        case 'P':
                                            if ((String.Compare(field_name, 4, "ressure", 0, 7, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorMinPressure;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 4, "emperature", 0, 10, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorMinTemperature;
                                            break;
                                        case 'V':
                                            if ((String.Compare(field_name, 4, "isibility", 0, 9, false) == 0) && (field_name.Length == 13))
                                                return fieldGeneratorMinVisibility;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 4, "ind", 0, 3, false) == 0) && (field_name.Length == 7))
                                                return fieldGeneratorMinWind;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'o':
                                if (String.Compare(field_name, 2, "onPhase", 0, 7, false) == 0)
                                  {
                                    switch (field_name[9])
                                      {
                                        case 'P':
                                            if ((String.Compare(field_name, 10, "ct", 0, 2, false) == 0) && (field_name.Length == 12))
                                                return fieldGeneratorMoonPhasePct;
                                            break;
                                        case 'T':
                                            if (String.Compare(field_name, 10, "ext", 0, 3, false) == 0)
                                              {
                                                if (field_name.Length == 13)
                                                  {
                                                    return fieldGeneratorMoonPhaseText;
                                                  }
                                                switch (field_name[13])
                                                  {
                                                    case 'D':
                                                        if ((String.Compare(field_name, 14, "isplay", 0, 6, false) == 0) && (field_name.Length == 20))
                                                            return fieldGeneratorMoonPhaseTextDisplay;
                                                        break;
                                                    case 'S':
                                                        if ((String.Compare(field_name, 14, "poken", 0, 5, false) == 0) && (field_name.Length == 19))
                                                            return fieldGeneratorMoonPhaseTextSpoken;
                                                        break;
                                                    case 'W':
                                                        if ((String.Compare(field_name, 14, "ritten", 0, 6, false) == 0) && (field_name.Length == 20))
                                                            return fieldGeneratorMoonPhaseTextWritten;
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
                            default:
                                break;
                          }
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "recipitation", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorPrecipitation;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "ain", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorRain;
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'n':
                                if (String.Compare(field_name, 2, "ow", 0, 2, false) == 0)
                                  {
                                    if (field_name.Length == 4)
                                      {
                                        return fieldGeneratorSnow;
                                      }
                                    switch (field_name[4])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 5, "epth", 0, 4, false) == 0) && (field_name.Length == 9))
                                                return fieldGeneratorSnowDepth;
                                            break;
                                        case 'f':
                                            if (String.Compare(field_name, 5, "all", 0, 3, false) == 0)
                                              {
                                                if (field_name.Length == 8)
                                                  {
                                                    return fieldGeneratorSnowfall;
                                                  }
                                                switch (field_name[8])
                                                  {
                                                    case 'M':
                                                        if ((String.Compare(field_name, 9, "onthToDate", 0, 10, false) == 0) && (field_name.Length == 19))
                                                            return fieldGeneratorSnowfallMonthToDate;
                                                        break;
                                                    case 'S':
                                                        if ((String.Compare(field_name, 9, "inceJulyFirst", 0, 13, false) == 0) && (field_name.Length == 22))
                                                            return fieldGeneratorSnowfallSinceJulyFirst;
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
                            case 'u':
                                if (String.Compare(field_name, 2, "n", 0, 1, false) == 0)
                                  {
                                    switch (field_name[3])
                                      {
                                        case 'r':
                                            if ((String.Compare(field_name, 4, "iseDateAndTime", 0, 14, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorSunriseDateAndTime;
                                            break;
                                        case 's':
                                            if ((String.Compare(field_name, 4, "etDateAndTime", 0, 13, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorSunsetDateAndTime;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        switch (field_name[1])
                          {
                            case 'h':
                                if ((String.Compare(field_name, 2, "under", 0, 5, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorThunder;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 2, "rnado", 0, 5, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorTornado;
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
                fieldGeneratorIsObservedConditions = new JSONHoldingBooleanGenerator("field \"IsObservedConditions\" of the TypeDailySummary class");
                fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorSunriseDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SunriseDateAndTime\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorSunsetDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SunsetDateAndTime\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMoonPhaseText = new MoonPhaseDataJSON.HoldingGenerator("field \"MoonPhaseText\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMoonPhaseTextDisplay = new JSONHoldingStringGenerator("field \"MoonPhaseTextDisplay\" of the TypeDailySummary class");
                fieldGeneratorMoonPhaseTextSpoken = new JSONHoldingStringGenerator("field \"MoonPhaseTextSpoken\" of the TypeDailySummary class");
                fieldGeneratorMoonPhaseTextWritten = new JSONHoldingStringGenerator("field \"MoonPhaseTextWritten\" of the TypeDailySummary class");
                fieldGeneratorMoonPhasePct = new FieldHoldingGeneratorMoonPhasePct("field \"MoonPhasePct\" of the TypeDailySummary class");
                fieldGeneratorPrecipitation = new TypePrecipitationJSON.HoldingGenerator("field \"Precipitation\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorSnowfall = new TypeSnowfallJSON.HoldingGenerator("field \"Snowfall\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorSnowfallMonthToDate = new TypeSnowfallMonthToDateJSON.HoldingGenerator("field \"SnowfallMonthToDate\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorSnowfallSinceJulyFirst = new TypeSnowfallSinceJulyFirstJSON.HoldingGenerator("field \"SnowfallSinceJulyFirst\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorSnowDepth = new TypeSnowDepthJSON.HoldingGenerator("field \"SnowDepth\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMaxTemperature = new TypeMaxTemperatureJSON.HoldingGenerator("field \"MaxTemperature\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorAvgTemperature = new TypeAvgTemperatureJSON.HoldingGenerator("field \"AvgTemperature\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMinTemperature = new TypeMinTemperatureJSON.HoldingGenerator("field \"MinTemperature\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMaxDewPoint = new TypeMaxDewPointJSON.HoldingGenerator("field \"MaxDewPoint\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorAvgDewPoint = new TypeAvgDewPointJSON.HoldingGenerator("field \"AvgDewPoint\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMinDewPoint = new TypeMinDewPointJSON.HoldingGenerator("field \"MinDewPoint\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMaxHumidityPct = new FieldHoldingGeneratorMaxHumidityPct("field \"MaxHumidityPct\" of the TypeDailySummary class");
                fieldGeneratorAvgHumidityPct = new FieldHoldingGeneratorAvgHumidityPct("field \"AvgHumidityPct\" of the TypeDailySummary class");
                fieldGeneratorMinHumidityPct = new FieldHoldingGeneratorMinHumidityPct("field \"MinHumidityPct\" of the TypeDailySummary class");
                fieldGeneratorMaxPressure = new TypeMaxPressureJSON.HoldingGenerator("field \"MaxPressure\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorAvgPressure = new TypeAvgPressureJSON.HoldingGenerator("field \"AvgPressure\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMinPressure = new TypeMinPressureJSON.HoldingGenerator("field \"MinPressure\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMaxWind = new TypeMaxWindJSON.HoldingGenerator("field \"MaxWind\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorAvgWind = new WindDataJSON.HoldingGenerator("field \"AvgWind\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMinWind = new TypeMinWindJSON.HoldingGenerator("field \"MinWind\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMaxVisibility = new TypeMaxVisibilityJSON.HoldingGenerator("field \"MaxVisibility\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorAvgVisibility = new TypeAvgVisibilityJSON.HoldingGenerator("field \"AvgVisibility\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorMinVisibility = new TypeMinVisibilityJSON.HoldingGenerator("field \"MinVisibility\" of the TypeDailySummary class", ignore_extras);
                fieldGeneratorFog = new JSONHoldingBooleanGenerator("field \"Fog\" of the TypeDailySummary class");
                fieldGeneratorRain = new JSONHoldingBooleanGenerator("field \"Rain\" of the TypeDailySummary class");
                fieldGeneratorSnow = new JSONHoldingBooleanGenerator("field \"Snow\" of the TypeDailySummary class");
                fieldGeneratorHail = new JSONHoldingBooleanGenerator("field \"Hail\" of the TypeDailySummary class");
                fieldGeneratorThunder = new JSONHoldingBooleanGenerator("field \"Thunder\" of the TypeDailySummary class");
                fieldGeneratorTornado = new JSONHoldingBooleanGenerator("field \"Tornado\" of the TypeDailySummary class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDailySummary class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorIsObservedConditions = new JSONHoldingBooleanGenerator("field \"IsObservedConditions\" of the TypeDailySummary class");
                fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the TypeDailySummary class", false);
                fieldGeneratorSunriseDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SunriseDateAndTime\" of the TypeDailySummary class", false);
                fieldGeneratorSunsetDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SunsetDateAndTime\" of the TypeDailySummary class", false);
                fieldGeneratorMoonPhaseText = new MoonPhaseDataJSON.HoldingGenerator("field \"MoonPhaseText\" of the TypeDailySummary class", false);
                fieldGeneratorMoonPhaseTextDisplay = new JSONHoldingStringGenerator("field \"MoonPhaseTextDisplay\" of the TypeDailySummary class");
                fieldGeneratorMoonPhaseTextSpoken = new JSONHoldingStringGenerator("field \"MoonPhaseTextSpoken\" of the TypeDailySummary class");
                fieldGeneratorMoonPhaseTextWritten = new JSONHoldingStringGenerator("field \"MoonPhaseTextWritten\" of the TypeDailySummary class");
                fieldGeneratorMoonPhasePct = new FieldHoldingGeneratorMoonPhasePct("field \"MoonPhasePct\" of the TypeDailySummary class");
                fieldGeneratorPrecipitation = new TypePrecipitationJSON.HoldingGenerator("field \"Precipitation\" of the TypeDailySummary class", false);
                fieldGeneratorSnowfall = new TypeSnowfallJSON.HoldingGenerator("field \"Snowfall\" of the TypeDailySummary class", false);
                fieldGeneratorSnowfallMonthToDate = new TypeSnowfallMonthToDateJSON.HoldingGenerator("field \"SnowfallMonthToDate\" of the TypeDailySummary class", false);
                fieldGeneratorSnowfallSinceJulyFirst = new TypeSnowfallSinceJulyFirstJSON.HoldingGenerator("field \"SnowfallSinceJulyFirst\" of the TypeDailySummary class", false);
                fieldGeneratorSnowDepth = new TypeSnowDepthJSON.HoldingGenerator("field \"SnowDepth\" of the TypeDailySummary class", false);
                fieldGeneratorMaxTemperature = new TypeMaxTemperatureJSON.HoldingGenerator("field \"MaxTemperature\" of the TypeDailySummary class", false);
                fieldGeneratorAvgTemperature = new TypeAvgTemperatureJSON.HoldingGenerator("field \"AvgTemperature\" of the TypeDailySummary class", false);
                fieldGeneratorMinTemperature = new TypeMinTemperatureJSON.HoldingGenerator("field \"MinTemperature\" of the TypeDailySummary class", false);
                fieldGeneratorMaxDewPoint = new TypeMaxDewPointJSON.HoldingGenerator("field \"MaxDewPoint\" of the TypeDailySummary class", false);
                fieldGeneratorAvgDewPoint = new TypeAvgDewPointJSON.HoldingGenerator("field \"AvgDewPoint\" of the TypeDailySummary class", false);
                fieldGeneratorMinDewPoint = new TypeMinDewPointJSON.HoldingGenerator("field \"MinDewPoint\" of the TypeDailySummary class", false);
                fieldGeneratorMaxHumidityPct = new FieldHoldingGeneratorMaxHumidityPct("field \"MaxHumidityPct\" of the TypeDailySummary class");
                fieldGeneratorAvgHumidityPct = new FieldHoldingGeneratorAvgHumidityPct("field \"AvgHumidityPct\" of the TypeDailySummary class");
                fieldGeneratorMinHumidityPct = new FieldHoldingGeneratorMinHumidityPct("field \"MinHumidityPct\" of the TypeDailySummary class");
                fieldGeneratorMaxPressure = new TypeMaxPressureJSON.HoldingGenerator("field \"MaxPressure\" of the TypeDailySummary class", false);
                fieldGeneratorAvgPressure = new TypeAvgPressureJSON.HoldingGenerator("field \"AvgPressure\" of the TypeDailySummary class", false);
                fieldGeneratorMinPressure = new TypeMinPressureJSON.HoldingGenerator("field \"MinPressure\" of the TypeDailySummary class", false);
                fieldGeneratorMaxWind = new TypeMaxWindJSON.HoldingGenerator("field \"MaxWind\" of the TypeDailySummary class", false);
                fieldGeneratorAvgWind = new WindDataJSON.HoldingGenerator("field \"AvgWind\" of the TypeDailySummary class", false);
                fieldGeneratorMinWind = new TypeMinWindJSON.HoldingGenerator("field \"MinWind\" of the TypeDailySummary class", false);
                fieldGeneratorMaxVisibility = new TypeMaxVisibilityJSON.HoldingGenerator("field \"MaxVisibility\" of the TypeDailySummary class", false);
                fieldGeneratorAvgVisibility = new TypeAvgVisibilityJSON.HoldingGenerator("field \"AvgVisibility\" of the TypeDailySummary class", false);
                fieldGeneratorMinVisibility = new TypeMinVisibilityJSON.HoldingGenerator("field \"MinVisibility\" of the TypeDailySummary class", false);
                fieldGeneratorFog = new JSONHoldingBooleanGenerator("field \"Fog\" of the TypeDailySummary class");
                fieldGeneratorRain = new JSONHoldingBooleanGenerator("field \"Rain\" of the TypeDailySummary class");
                fieldGeneratorSnow = new JSONHoldingBooleanGenerator("field \"Snow\" of the TypeDailySummary class");
                fieldGeneratorHail = new JSONHoldingBooleanGenerator("field \"Hail\" of the TypeDailySummary class");
                fieldGeneratorThunder = new JSONHoldingBooleanGenerator("field \"Thunder\" of the TypeDailySummary class");
                fieldGeneratorTornado = new JSONHoldingBooleanGenerator("field \"Tornado\" of the TypeDailySummary class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDailySummary class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorIsObservedConditions.reset();
                fieldGeneratorDateAndTime.reset();
                fieldGeneratorSunriseDateAndTime.reset();
                fieldGeneratorSunsetDateAndTime.reset();
                fieldGeneratorMoonPhaseText.reset();
                fieldGeneratorMoonPhaseTextDisplay.reset();
                fieldGeneratorMoonPhaseTextSpoken.reset();
                fieldGeneratorMoonPhaseTextWritten.reset();
                fieldGeneratorMoonPhasePct.reset();
                fieldGeneratorPrecipitation.reset();
                fieldGeneratorSnowfall.reset();
                fieldGeneratorSnowfallMonthToDate.reset();
                fieldGeneratorSnowfallSinceJulyFirst.reset();
                fieldGeneratorSnowDepth.reset();
                fieldGeneratorMaxTemperature.reset();
                fieldGeneratorAvgTemperature.reset();
                fieldGeneratorMinTemperature.reset();
                fieldGeneratorMaxDewPoint.reset();
                fieldGeneratorAvgDewPoint.reset();
                fieldGeneratorMinDewPoint.reset();
                fieldGeneratorMaxHumidityPct.reset();
                fieldGeneratorAvgHumidityPct.reset();
                fieldGeneratorMinHumidityPct.reset();
                fieldGeneratorMaxPressure.reset();
                fieldGeneratorAvgPressure.reset();
                fieldGeneratorMinPressure.reset();
                fieldGeneratorMaxWind.reset();
                fieldGeneratorAvgWind.reset();
                fieldGeneratorMinWind.reset();
                fieldGeneratorMaxVisibility.reset();
                fieldGeneratorAvgVisibility.reset();
                fieldGeneratorMinVisibility.reset();
                fieldGeneratorFog.reset();
                fieldGeneratorRain.reset();
                fieldGeneratorSnow.reset();
                fieldGeneratorHail.reset();
                fieldGeneratorThunder.reset();
                fieldGeneratorTornado.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorDateAndTime.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSunriseDateAndTime.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSunsetDateAndTime.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMoonPhaseText.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorPrecipitation.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSnowfall.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSnowfallMonthToDate.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSnowfallSinceJulyFirst.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSnowDepth.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMaxTemperature.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAvgTemperature.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMinTemperature.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMaxDewPoint.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAvgDewPoint.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMinDewPoint.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMaxPressure.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAvgPressure.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMinPressure.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMaxWind.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAvgWind.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMinWind.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMaxVisibility.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAvgVisibility.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMinVisibility.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorDateAndTime.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSunriseDateAndTime.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSunsetDateAndTime.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMoonPhaseText.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorPrecipitation.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSnowfall.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSnowfallMonthToDate.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSnowfallSinceJulyFirst.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSnowDepth.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMaxTemperature.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAvgTemperature.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMinTemperature.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMaxDewPoint.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAvgDewPoint.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMinDewPoint.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMaxPressure.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAvgPressure.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMinPressure.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMaxWind.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAvgWind.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMinWind.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMaxVisibility.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAvgVisibility.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMinVisibility.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeDailySummaryJSON  result)
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
            public TypeDailySummaryJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDailySummaryJSON  result)
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
        protected virtual void handle_result(List<TypeDailySummaryJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDailySummaryJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDailySummaryJSON>();
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
        public List<TypeDailySummaryJSON> value;
      };
      };
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasStartDateAndTime;
    private DateAndOrTimeJSON  storeStartDateAndTime;
    private bool flagHasEndDateAndTime;
    private DateAndOrTimeJSON  storeEndDateAndTime;
    private bool flagHasAlerts;
    private List< AlertJSON  > storeAlerts;
    private bool flagHasRequestedAttribute;
    private WeatherAttributeJSON  storeRequestedAttribute;
    private bool flagHasIsYesNoQuery;
    private bool storeIsYesNoQuery;
    private bool flagHasDateAndTime;
    private DateAndOrTimeJSON  storeDateAndTime;
    private bool flagHasObservations;
    private List< HistoryObservationJSON  > storeObservations;
    private bool flagHasDailySummary;
    private TypeDailySummaryJSON  storeDailySummary;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAttributionToJSON()
      {
        JSONValueHandler handler_Attribution = new JSONValueHandler();
        storeAttribution.write_as_json(handler_Attribution);
        return handler_Attribution.result;
      }

    private JSONValue  extraLocationToJSON()
      {
        JSONValueHandler handler_Location = new JSONValueHandler();
        storeLocation.write_as_json(handler_Location);
        return handler_Location.result;
      }

    private JSONValue  extraStartDateAndTimeToJSON()
      {
        JSONValueHandler handler_StartDateAndTime = new JSONValueHandler();
        storeStartDateAndTime.write_as_json(handler_StartDateAndTime);
        return handler_StartDateAndTime.result;
      }

    private JSONValue  extraEndDateAndTimeToJSON()
      {
        JSONValueHandler handler_EndDateAndTime = new JSONValueHandler();
        storeEndDateAndTime.write_as_json(handler_EndDateAndTime);
        return handler_EndDateAndTime.result;
      }

    private JSONValue  extraAlertsToJSON()
      {
        JSONArrayValue generated_array_1_Alerts = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
          {
            JSONValueHandler handler_Alerts = new JSONValueHandler();
            storeAlerts[num1].write_as_json(handler_Alerts);
            generated_array_1_Alerts.appendComponent(handler_Alerts.result);
          }
        return generated_array_1_Alerts;
      }

    private JSONValue  extraRequestedAttributeToJSON()
      {
        JSONValueHandler handler_RequestedAttribute = new JSONValueHandler();
        storeRequestedAttribute.write_as_json(handler_RequestedAttribute);
        return handler_RequestedAttribute.result;
      }

    private JSONValue  extraIsYesNoQueryToJSON()
      {
        JSONValue generated_boolean_IsYesNoQuery = (storeIsYesNoQuery ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsYesNoQuery;
      }

    private JSONValue  extraDateAndTimeToJSON()
      {
        JSONValueHandler handler_DateAndTime = new JSONValueHandler();
        storeDateAndTime.write_as_json(handler_DateAndTime);
        return handler_DateAndTime.result;
      }

    private JSONValue  extraObservationsToJSON()
      {
        JSONArrayValue generated_array_2_Observations = new JSONArrayValue();
        for (int num2 = 0; num2 < storeObservations.Count; ++num2)
          {
            JSONValueHandler handler_Observations = new JSONValueHandler();
            storeObservations[num2].write_as_json(handler_Observations);
            generated_array_2_Observations.appendComponent(handler_Observations.result);
          }
        return generated_array_2_Observations;
      }

    private JSONValue  extraDailySummaryToJSON()
      {
        JSONValueHandler handler_DailySummary = new JSONValueHandler();
        storeDailySummary.write_as_json(handler_DailySummary);
        return handler_DailySummary.result;
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONStartDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartDateAndTime(convert_classy);
      }


    private void  fromJSONEndDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndDateAndTime(convert_classy);
      }


    private void  fromJSONAlerts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Alerts of ShowWeatherHistoryInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AlertJSON  > vector_Alerts1 = new List< AlertJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AlertJSON convert_classy = AlertJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Alerts1.Add(convert_classy);
          }
        initAlerts();
        for (int num1 = 0; num1 < vector_Alerts1.Count; ++num1)
            appendAlerts(vector_Alerts1[num1]);
        for (int num1 = 0; num1 < vector_Alerts1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherAttributeJSON convert_classy = WeatherAttributeJSON.from_json(json_value, ignore_extras, true);
        setRequestedAttribute(convert_classy);
      }


    private void  fromJSONIsYesNoQuery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsYesNoQuery of ShowWeatherHistoryInformationNuggetJSON is not true for false.");
              }
          }
        setIsYesNoQuery(the_bool);
      }


    private void  fromJSONDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setDateAndTime(convert_classy);
      }


    private void  fromJSONObservations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Observations of ShowWeatherHistoryInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HistoryObservationJSON  > vector_Observations1 = new List< HistoryObservationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HistoryObservationJSON convert_classy = HistoryObservationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Observations1.Add(convert_classy);
          }
        initObservations();
        for (int num2 = 0; num2 < vector_Observations1.Count; ++num2)
            appendObservations(vector_Observations1[num2]);
        for (int num1 = 0; num1 < vector_Observations1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDailySummary(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDailySummaryJSON convert_classy = TypeDailySummaryJSON.from_json(json_value, ignore_extras, true);
        setDailySummary(convert_classy);
      }


    public ShowWeatherHistoryInformationNuggetJSON()
      {
        flagHasAttribution = false;
        flagHasLocation = false;
        flagHasStartDateAndTime = false;
        flagHasEndDateAndTime = false;
        flagHasAlerts = false;
        flagHasRequestedAttribute = false;
        flagHasIsYesNoQuery = false;
        flagHasDateAndTime = false;
        flagHasObservations = false;
        flagHasDailySummary = false;
        storeAlerts = new List< AlertJSON  >();
        storeObservations = new List< HistoryObservationJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getWeatherNuggetKind()
      {
        return "ShowWeatherHistory";
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public AttributionJSON   getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasStartDateAndTime()
      {
        return flagHasStartDateAndTime;
      }

    public DateAndOrTimeJSON   getStartDateAndTime()
      {
        Debug.Assert(flagHasStartDateAndTime);
        return storeStartDateAndTime;
      }

    public bool  hasEndDateAndTime()
      {
        return flagHasEndDateAndTime;
      }

    public DateAndOrTimeJSON   getEndDateAndTime()
      {
        Debug.Assert(flagHasEndDateAndTime);
        return storeEndDateAndTime;
      }

    public bool  hasAlerts()
      {
        return flagHasAlerts;
      }

    public int  countOfAlerts()
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts.Count;
      }

    public AlertJSON   elementOfAlerts(int element_num)
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts[element_num];
      }

    public List< AlertJSON  >  getAlerts()
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts;
      }

    public bool  hasRequestedAttribute()
      {
        return flagHasRequestedAttribute;
      }

    public WeatherAttributeJSON   getRequestedAttribute()
      {
        Debug.Assert(flagHasRequestedAttribute);
        return storeRequestedAttribute;
      }

    public WeatherAttributeJSON.TypeValue  getRequestedAttributeValue()
      {
        return getRequestedAttribute().getValue();
      }

    public string  getRequestedAttributeAsString()
      {
        return getRequestedAttribute().getValueAsString();
      }

    public bool  hasIsYesNoQuery()
      {
        return flagHasIsYesNoQuery;
      }

    public bool  getIsYesNoQuery()
      {
        Debug.Assert(flagHasIsYesNoQuery);
        return storeIsYesNoQuery;
      }

    public bool  hasDateAndTime()
      {
        return flagHasDateAndTime;
      }

    public DateAndOrTimeJSON   getDateAndTime()
      {
        Debug.Assert(flagHasDateAndTime);
        return storeDateAndTime;
      }

    public bool  hasObservations()
      {
        return flagHasObservations;
      }

    public int  countOfObservations()
      {
        Debug.Assert(flagHasObservations);
        return storeObservations.Count;
      }

    public HistoryObservationJSON   elementOfObservations(int element_num)
      {
        Debug.Assert(flagHasObservations);
        return storeObservations[element_num];
      }

    public List< HistoryObservationJSON  >  getObservations()
      {
        Debug.Assert(flagHasObservations);
        return storeObservations;
      }

    public bool  hasDailySummary()
      {
        return flagHasDailySummary;
      }

    public TypeDailySummaryJSON   getDailySummary()
      {
        Debug.Assert(flagHasDailySummary);
        return storeDailySummary;
      }


    public virtual int extraShowWeatherHistoryInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraShowWeatherHistoryInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraShowWeatherHistoryInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraShowWeatherHistoryInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraWeatherInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasAttribution)
            ++result;
        if (flagHasLocation)
            ++result;
        if (flagHasStartDateAndTime)
            ++result;
        if (flagHasEndDateAndTime)
            ++result;
        if (flagHasAlerts)
            ++result;
        if (flagHasRequestedAttribute)
            ++result;
        if (flagHasIsYesNoQuery)
            ++result;
        if (flagHasDateAndTime)
            ++result;
        if (flagHasObservations)
            ++result;
        if (flagHasDailySummary)
            ++result;
        result += extraShowWeatherHistoryInformationNuggetComponentCount();
        return result;
      }
    public override string extraWeatherInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return "Attribution";
            --remainder;
          }
        if (flagHasLocation)
          {
            if (remainder == 0)
                return "Location";
            --remainder;
          }
        if (flagHasStartDateAndTime)
          {
            if (remainder == 0)
                return "StartDateAndTime";
            --remainder;
          }
        if (flagHasEndDateAndTime)
          {
            if (remainder == 0)
                return "EndDateAndTime";
            --remainder;
          }
        if (flagHasAlerts)
          {
            if (remainder == 0)
                return "Alerts";
            --remainder;
          }
        if (flagHasRequestedAttribute)
          {
            if (remainder == 0)
                return "RequestedAttribute";
            --remainder;
          }
        if (flagHasIsYesNoQuery)
          {
            if (remainder == 0)
                return "IsYesNoQuery";
            --remainder;
          }
        if (flagHasDateAndTime)
          {
            if (remainder == 0)
                return "DateAndTime";
            --remainder;
          }
        if (flagHasObservations)
          {
            if (remainder == 0)
                return "Observations";
            --remainder;
          }
        if (flagHasDailySummary)
          {
            if (remainder == 0)
                return "DailySummary";
            --remainder;
          }
        return extraShowWeatherHistoryInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraWeatherInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return extraAttributionToJSON();
            --remainder;
          }
        if (flagHasLocation)
          {
            if (remainder == 0)
                return extraLocationToJSON();
            --remainder;
          }
        if (flagHasStartDateAndTime)
          {
            if (remainder == 0)
                return extraStartDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasEndDateAndTime)
          {
            if (remainder == 0)
                return extraEndDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasAlerts)
          {
            if (remainder == 0)
                return extraAlertsToJSON();
            --remainder;
          }
        if (flagHasRequestedAttribute)
          {
            if (remainder == 0)
                return extraRequestedAttributeToJSON();
            --remainder;
          }
        if (flagHasIsYesNoQuery)
          {
            if (remainder == 0)
                return extraIsYesNoQueryToJSON();
            --remainder;
          }
        if (flagHasDateAndTime)
          {
            if (remainder == 0)
                return extraDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasObservations)
          {
            if (remainder == 0)
                return extraObservationsToJSON();
            --remainder;
          }
        if (flagHasDailySummary)
          {
            if (remainder == 0)
                return extraDailySummaryToJSON();
            --remainder;
          }
        return extraShowWeatherHistoryInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraWeatherInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 'l':
                        if ((String.Compare(field_name, 2, "erts", 0, 4, false) == 0) && (field_name.Length == 6))
                            return (flagHasAlerts ? extraAlertsToJSON() : null);
                        break;
                    case 't':
                        if ((String.Compare(field_name, 2, "tribution", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasAttribution ? extraAttributionToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(field_name, 1, "a", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 3, "lySummary", 0, 9, false) == 0) && (field_name.Length == 12))
                                return (flagHasDailySummary ? extraDailySummaryToJSON() : null);
                            break;
                        case 't':
                            if ((String.Compare(field_name, 3, "eAndTime", 0, 8, false) == 0) && (field_name.Length == 11))
                                return (flagHasDateAndTime ? extraDateAndTimeToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "ndDateAndTime", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasEndDateAndTime ? extraEndDateAndTimeToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "sYesNoQuery", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasIsYesNoQuery ? extraIsYesNoQueryToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasLocation ? extraLocationToJSON() : null);
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "bservations", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasObservations ? extraObservationsToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equestedAttribute", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasRequestedAttribute ? extraRequestedAttributeToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tartDateAndTime", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasStartDateAndTime ? extraStartDateAndTimeToJSON() : null);
                break;
            default:
                break;
          }
        return extraShowWeatherHistoryInformationNuggetLookup(field_name);
      }

    public void setAttribution(AttributionJSON  new_value)
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = false;
      }
    public void setLocation(MapLocationJSON  new_value)
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = false;
      }
    public void setStartDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartDateAndTime)
          {
          }
        flagHasStartDateAndTime = true;
        storeStartDateAndTime = new_value;
      }
    public void unsetStartDateAndTime()
      {
        if (flagHasStartDateAndTime)
          {
          }
        flagHasStartDateAndTime = false;
      }
    public void setEndDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndDateAndTime)
          {
          }
        flagHasEndDateAndTime = true;
        storeEndDateAndTime = new_value;
      }
    public void unsetEndDateAndTime()
      {
        if (flagHasEndDateAndTime)
          {
          }
        flagHasEndDateAndTime = false;
      }
    public void initAlerts()
      {
        if (flagHasAlerts)
          {
            for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
              {
              }
          }
        flagHasAlerts = true;
        storeAlerts.Clear();
      }
    public void appendAlerts(AlertJSON  to_append)
      {
        if (!flagHasAlerts)
          {
            flagHasAlerts = true;
            storeAlerts.Clear();
          }
        Debug.Assert(flagHasAlerts);
        storeAlerts.Add(to_append);
      }
    public void unsetAlerts()
      {
        if (flagHasAlerts)
          {
            for (int num2 = 0; num2 < storeAlerts.Count; ++num2)
              {
              }
          }
        flagHasAlerts = false;
        storeAlerts.Clear();
      }
    public void setRequestedAttribute(WeatherAttributeJSON  new_value)
      {
        if (flagHasRequestedAttribute)
          {
          }
        flagHasRequestedAttribute = true;
        storeRequestedAttribute = new_value;
      }
    public void setRequestedAttribute(WeatherAttributeJSON.TypeValue new_value)
      {
        setRequestedAttribute(new WeatherAttributeJSON(new_value));
      }
    public void setRequestedAttribute(string chars)
      {
        WeatherAttributeJSON.TypeValueKnownValues known = WeatherAttributeJSON.stringToValue(chars);
        WeatherAttributeJSON.TypeValue new_value = new WeatherAttributeJSON.TypeValue();
        if (known == WeatherAttributeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRequestedAttribute(new_value);
      }
    public void unsetRequestedAttribute()
      {
        if (flagHasRequestedAttribute)
          {
          }
        flagHasRequestedAttribute = false;
      }
    public void setIsYesNoQuery(bool new_value)
      {
        flagHasIsYesNoQuery = true;
        storeIsYesNoQuery = new_value;
      }
    public void unsetIsYesNoQuery()
      {
        flagHasIsYesNoQuery = false;
      }
    public void setDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasDateAndTime)
          {
          }
        flagHasDateAndTime = true;
        storeDateAndTime = new_value;
      }
    public void unsetDateAndTime()
      {
        if (flagHasDateAndTime)
          {
          }
        flagHasDateAndTime = false;
      }
    public void initObservations()
      {
        if (flagHasObservations)
          {
            for (int num3 = 0; num3 < storeObservations.Count; ++num3)
              {
              }
          }
        flagHasObservations = true;
        storeObservations.Clear();
      }
    public void appendObservations(HistoryObservationJSON  to_append)
      {
        if (!flagHasObservations)
          {
            flagHasObservations = true;
            storeObservations.Clear();
          }
        Debug.Assert(flagHasObservations);
        storeObservations.Add(to_append);
      }
    public void unsetObservations()
      {
        if (flagHasObservations)
          {
            for (int num4 = 0; num4 < storeObservations.Count; ++num4)
              {
              }
          }
        flagHasObservations = false;
        storeObservations.Clear();
      }
    public void setDailySummary(TypeDailySummaryJSON  new_value)
      {
        if (flagHasDailySummary)
          {
          }
        flagHasDailySummary = true;
        storeDailySummary = new_value;
      }
    public void unsetDailySummary()
      {
        if (flagHasDailySummary)
          {
          }
        flagHasDailySummary = false;
      }

    public virtual void extraShowWeatherHistoryInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraShowWeatherHistoryInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraShowWeatherHistoryInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraShowWeatherHistoryInformationNuggetAppendPair(key, new_component);
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
    public override void extraWeatherInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if ((String.Compare(key, 2, "erts", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONAlerts(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "tribution", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONAttribution(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(key, 1, "a", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'i':
                            if ((String.Compare(key, 3, "lySummary", 0, 9, false) == 0) && (key.Length == 12))
                                {
                                fromJSONDailySummary(new_component, false);
                                return;
                                }
                            break;
                        case 't':
                            if ((String.Compare(key, 3, "eAndTime", 0, 8, false) == 0) && (key.Length == 11))
                                {
                                fromJSONDateAndTime(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(key, 1, "ndDateAndTime", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONEndDateAndTime(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "sYesNoQuery", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONIsYesNoQuery(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "bservations", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONObservations(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedAttribute", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONRequestedAttribute(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartDateAndTime", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONStartDateAndTime(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraShowWeatherHistoryInformationNuggetAppendPair(key, new_component);
      }
    public override void extraWeatherInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if ((String.Compare(key, 2, "erts", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONAlerts(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "tribution", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONAttribution(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(key, 1, "a", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'i':
                            if ((String.Compare(key, 3, "lySummary", 0, 9, false) == 0) && (key.Length == 12))
                                {
                                fromJSONDailySummary(new_component, false);
                                return;
                                }
                            break;
                        case 't':
                            if ((String.Compare(key, 3, "eAndTime", 0, 8, false) == 0) && (key.Length == 11))
                                {
                                fromJSONDateAndTime(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(key, 1, "ndDateAndTime", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONEndDateAndTime(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "sYesNoQuery", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONIsYesNoQuery(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "bservations", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONObservations(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedAttribute", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONRequestedAttribute(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartDateAndTime", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONStartDateAndTime(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraShowWeatherHistoryInformationNuggetSetField(key, new_component);
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
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasLocation);
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStartDateAndTime);
        if (flagHasStartDateAndTime)
          {
            handler.start_pair("StartDateAndTime");
            if (partial_allowed)
                storeStartDateAndTime.write_partial_as_json(handler);
            else
                storeStartDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndDateAndTime);
        if (flagHasEndDateAndTime)
          {
            handler.start_pair("EndDateAndTime");
            if (partial_allowed)
                storeEndDateAndTime.write_partial_as_json(handler);
            else
                storeEndDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasAlerts);
        if (flagHasAlerts)
          {
            handler.start_pair("Alerts");
            handler.start_array();
            for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
              {
                if (partial_allowed)
                    storeAlerts[num1].write_partial_as_json(handler);
                else
                    storeAlerts[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasRequestedAttribute);
        if (flagHasRequestedAttribute)
          {
            handler.start_pair("RequestedAttribute");
            if (partial_allowed)
                storeRequestedAttribute.write_partial_as_json(handler);
            else
                storeRequestedAttribute.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasIsYesNoQuery);
        if (flagHasIsYesNoQuery)
          {
            handler.start_pair("IsYesNoQuery");
            handler.boolean_value(storeIsYesNoQuery);
          }
        Debug.Assert(partial_allowed || flagHasDateAndTime);
        if (flagHasDateAndTime)
          {
            handler.start_pair("DateAndTime");
            if (partial_allowed)
                storeDateAndTime.write_partial_as_json(handler);
            else
                storeDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasObservations);
        if (flagHasObservations)
          {
            handler.start_pair("Observations");
            handler.start_array();
            for (int num2 = 0; num2 < storeObservations.Count; ++num2)
              {
                if (partial_allowed)
                    storeObservations[num2].write_partial_as_json(handler);
                else
                    storeObservations[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasDailySummary);
        if (flagHasDailySummary)
          {
            handler.start_pair("DailySummary");
            if (partial_allowed)
                storeDailySummary.write_partial_as_json(handler);
            else
                storeDailySummary.write_as_json(handler);
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
        if (!(hasLocation()))
          {
            return "When parsing the object for %what%, the \"Location\" field was missing.";
          }
        if (!(hasStartDateAndTime()))
          {
            return "When parsing the object for %what%, the \"StartDateAndTime\" field was missing.";
          }
        if (!(hasEndDateAndTime()))
          {
            return "When parsing the object for %what%, the \"EndDateAndTime\" field was missing.";
          }
        if (!(hasAlerts()))
          {
            return "When parsing the object for %what%, the \"Alerts\" field was missing.";
          }
        if (!(hasRequestedAttribute()))
          {
            return "When parsing the object for %what%, the \"RequestedAttribute\" field was missing.";
          }
        if (!(hasIsYesNoQuery()))
          {
            return "When parsing the object for %what%, the \"IsYesNoQuery\" field was missing.";
          }
        if (!(hasDateAndTime()))
          {
            return "When parsing the object for %what%, the \"DateAndTime\" field was missing.";
          }
        if (!(hasObservations()))
          {
            return "When parsing the object for %what%, the \"Observations\" field was missing.";
          }
        if (!(hasDailySummary()))
          {
            return "When parsing the object for %what%, the \"DailySummary\" field was missing.";
          }
        return null;
      }

    public static new ShowWeatherHistoryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWeatherHistoryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherHistoryInformationNugget", ignore_extras);
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
    public static new ShowWeatherHistoryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWeatherHistoryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWeatherHistoryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherHistoryInformationNugget", ignore_extras);
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
    public static new ShowWeatherHistoryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWeatherHistoryInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ShowWeatherHistoryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherHistoryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ShowWeatherHistoryInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ShowWeatherHistoryInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ShowWeatherHistoryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherHistoryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : WeatherInformationNuggetJSON.Generator
      {
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDateAndTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndDateAndTime;
        private AlertJSON.HoldingArrayGenerator fieldGeneratorAlerts;
        private WeatherAttributeJSON.HoldingGenerator fieldGeneratorRequestedAttribute;
        private JSONHoldingBooleanGenerator fieldGeneratorIsYesNoQuery;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDateAndTime;
        private HistoryObservationJSON.HoldingArrayGenerator fieldGeneratorObservations;
        private TypeDailySummaryJSON.HoldingGenerator fieldGeneratorDailySummary;
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
            if (!(getWeatherInformationNuggetJSONKey().Equals("ShowWeatherHistory")))
                throw new Exception("The key field has a value other than `ShowWeatherHistory'.");
            ShowWeatherHistoryInformationNuggetJSON result = new ShowWeatherHistoryInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraShowWeatherHistoryInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(WeatherInformationNuggetJSON new_result)
          {
            handle_result((ShowWeatherHistoryInformationNuggetJSON )new_result);
          }
        protected void finish(ShowWeatherHistoryInformationNuggetJSON result)
          {
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            else if ((!(result.hasLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Location\" field was missing.");
              }
            if (fieldGeneratorStartDateAndTime.have_value)
              {
                result.setStartDateAndTime(fieldGeneratorStartDateAndTime.value);
                fieldGeneratorStartDateAndTime.have_value = false;
              }
            else if ((!(result.hasStartDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDateAndTime\" field was missing.");
              }
            if (fieldGeneratorEndDateAndTime.have_value)
              {
                result.setEndDateAndTime(fieldGeneratorEndDateAndTime.value);
                fieldGeneratorEndDateAndTime.have_value = false;
              }
            else if ((!(result.hasEndDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDateAndTime\" field was missing.");
              }
            if (fieldGeneratorAlerts.have_value)
              {
                result.initAlerts();
                int count = fieldGeneratorAlerts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlerts(fieldGeneratorAlerts.value[num]);
                  }
                fieldGeneratorAlerts.value.Clear();
                fieldGeneratorAlerts.have_value = false;
              }
            else if ((!(result.hasAlerts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Alerts\" field was missing.");
              }
            if (fieldGeneratorRequestedAttribute.have_value)
              {
                result.setRequestedAttribute(fieldGeneratorRequestedAttribute.value);
                fieldGeneratorRequestedAttribute.have_value = false;
              }
            else if ((!(result.hasRequestedAttribute())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedAttribute\" field was missing.");
              }
            if (fieldGeneratorIsYesNoQuery.have_value)
              {
                result.setIsYesNoQuery(fieldGeneratorIsYesNoQuery.value);
                fieldGeneratorIsYesNoQuery.have_value = false;
              }
            else if ((!(result.hasIsYesNoQuery())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsYesNoQuery\" field was missing.");
              }
            if (fieldGeneratorDateAndTime.have_value)
              {
                result.setDateAndTime(fieldGeneratorDateAndTime.value);
                fieldGeneratorDateAndTime.have_value = false;
              }
            else if ((!(result.hasDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndTime\" field was missing.");
              }
            if (fieldGeneratorObservations.have_value)
              {
                result.initObservations();
                int count = fieldGeneratorObservations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendObservations(fieldGeneratorObservations.value[num]);
                  }
                fieldGeneratorObservations.value.Clear();
                fieldGeneratorObservations.have_value = false;
              }
            else if ((!(result.hasObservations())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Observations\" field was missing.");
              }
            if (fieldGeneratorDailySummary.have_value)
              {
                result.setDailySummary(fieldGeneratorDailySummary.value);
                fieldGeneratorDailySummary.have_value = false;
              }
            else if ((!(result.hasDailySummary())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DailySummary\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ShowWeatherHistoryInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "erts", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorAlerts;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "tribution", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAttribution;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "a", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'i':
                                if ((String.Compare(field_name, 3, "lySummary", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorDailySummary;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 3, "eAndTime", 0, 8, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorDateAndTime;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ndDateAndTime", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorEndDateAndTime;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sYesNoQuery", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorIsYesNoQuery;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "bservations", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorObservations;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedAttribute", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorRequestedAttribute;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartDateAndTime", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorStartDateAndTime;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the ShowWeatherHistoryInformationNugget class", ignore_extras);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the ShowWeatherHistoryInformationNugget class", ignore_extras);
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the ShowWeatherHistoryInformationNugget class", ignore_extras);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the ShowWeatherHistoryInformationNugget class", ignore_extras);
            fieldGeneratorAlerts = new AlertJSON.HoldingArrayGenerator("field \"Alerts\" of the ShowWeatherHistoryInformationNugget class", ignore_extras);
            fieldGeneratorRequestedAttribute = new WeatherAttributeJSON.HoldingGenerator("field \"RequestedAttribute\" of the ShowWeatherHistoryInformationNugget class", ignore_extras);
            fieldGeneratorIsYesNoQuery = new JSONHoldingBooleanGenerator("field \"IsYesNoQuery\" of the ShowWeatherHistoryInformationNugget class");
            fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the ShowWeatherHistoryInformationNugget class", ignore_extras);
            fieldGeneratorObservations = new HistoryObservationJSON.HoldingArrayGenerator("field \"Observations\" of the ShowWeatherHistoryInformationNugget class", ignore_extras);
            fieldGeneratorDailySummary = new TypeDailySummaryJSON.HoldingGenerator("field \"DailySummary\" of the ShowWeatherHistoryInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ShowWeatherHistoryInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the ShowWeatherHistoryInformationNugget class", false);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the ShowWeatherHistoryInformationNugget class", false);
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the ShowWeatherHistoryInformationNugget class", false);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the ShowWeatherHistoryInformationNugget class", false);
            fieldGeneratorAlerts = new AlertJSON.HoldingArrayGenerator("field \"Alerts\" of the ShowWeatherHistoryInformationNugget class", false);
            fieldGeneratorRequestedAttribute = new WeatherAttributeJSON.HoldingGenerator("field \"RequestedAttribute\" of the ShowWeatherHistoryInformationNugget class", false);
            fieldGeneratorIsYesNoQuery = new JSONHoldingBooleanGenerator("field \"IsYesNoQuery\" of the ShowWeatherHistoryInformationNugget class");
            fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the ShowWeatherHistoryInformationNugget class", false);
            fieldGeneratorObservations = new HistoryObservationJSON.HoldingArrayGenerator("field \"Observations\" of the ShowWeatherHistoryInformationNugget class", false);
            fieldGeneratorDailySummary = new TypeDailySummaryJSON.HoldingGenerator("field \"DailySummary\" of the ShowWeatherHistoryInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ShowWeatherHistoryInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAttribution.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorStartDateAndTime.reset();
            fieldGeneratorEndDateAndTime.reset();
            fieldGeneratorAlerts.reset();
            fieldGeneratorRequestedAttribute.reset();
            fieldGeneratorIsYesNoQuery.reset();
            fieldGeneratorDateAndTime.reset();
            fieldGeneratorObservations.reset();
            fieldGeneratorDailySummary.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ShowWeatherHistoryInformationNuggetJSON  result)
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
        public ShowWeatherHistoryInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ShowWeatherHistoryInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ShowWeatherHistoryInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ShowWeatherHistoryInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ShowWeatherHistoryInformationNuggetJSON>();
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
    public List<ShowWeatherHistoryInformationNuggetJSON> value;
  };
  };
