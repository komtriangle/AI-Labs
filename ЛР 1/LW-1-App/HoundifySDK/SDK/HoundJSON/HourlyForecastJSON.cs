/* file "HourlyForecastJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HourlyForecastJSON : JSONBase
  {
    public class TypeTemperatureJSON : JSONBase
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


        public TypeTemperatureJSON()
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


        public virtual int extraTypeTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeTemperatureLookup(string field_name)
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

        public virtual void extraTypeTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeTemperatureAppendPair(key, new_component);
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

        public static TypeTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTemperature", ignore_extras);
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
        public static TypeTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTemperature", ignore_extras);
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
        public static TypeTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTemperature", ignore_extras);
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
                TypeTemperatureJSON result = new TypeTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeTemperatureJSON result)
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
            protected abstract void handle_result(TypeTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeTemperature class");
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
            protected override void handle_result(TypeTemperatureJSON  result)
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
            public TypeTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeTemperatureJSON>();
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
        public List<TypeTemperatureJSON> value;
      };
      };
    public class TypeFeelsLikeTemperatureJSON : JSONBase
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


        public TypeFeelsLikeTemperatureJSON()
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


        public virtual int extraTypeFeelsLikeTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeFeelsLikeTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeFeelsLikeTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeFeelsLikeTemperatureLookup(string field_name)
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

        public virtual void extraTypeFeelsLikeTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeFeelsLikeTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeFeelsLikeTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeFeelsLikeTemperatureAppendPair(key, new_component);
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

        public static TypeFeelsLikeTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeFeelsLikeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFeelsLikeTemperature", ignore_extras);
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
        public static TypeFeelsLikeTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeFeelsLikeTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeFeelsLikeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFeelsLikeTemperature", ignore_extras);
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
        public static TypeFeelsLikeTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeFeelsLikeTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeFeelsLikeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFeelsLikeTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeFeelsLikeTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeFeelsLikeTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeFeelsLikeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFeelsLikeTemperature", ignore_extras);
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
                TypeFeelsLikeTemperatureJSON result = new TypeFeelsLikeTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeFeelsLikeTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeFeelsLikeTemperatureJSON result)
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
            protected abstract void handle_result(TypeFeelsLikeTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeFeelsLikeTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeFeelsLikeTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeFeelsLikeTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeFeelsLikeTemperature class");
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
            protected override void handle_result(TypeFeelsLikeTemperatureJSON  result)
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
            public TypeFeelsLikeTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeFeelsLikeTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeFeelsLikeTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeFeelsLikeTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeFeelsLikeTemperatureJSON>();
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
        public List<TypeFeelsLikeTemperatureJSON> value;
      };
      };
    public class TypeHeatIndexJSON : JSONBase
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


        public TypeHeatIndexJSON()
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


        public virtual int extraTypeHeatIndexComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeHeatIndexComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeHeatIndexComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeHeatIndexLookup(string field_name)
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

        public virtual void extraTypeHeatIndexAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeHeatIndexSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeHeatIndexLookup(key);
            if (old_field == null)
              {
                extraTypeHeatIndexAppendPair(key, new_component);
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

        public static TypeHeatIndexJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHeatIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeatIndex", ignore_extras);
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
        public static TypeHeatIndexJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHeatIndexJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHeatIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeatIndex", ignore_extras);
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
        public static TypeHeatIndexJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHeatIndexJSON from_text(string text, bool ignore_extras)
          {
            TypeHeatIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeatIndex", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeHeatIndexJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeHeatIndexJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeHeatIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeatIndex", ignore_extras);
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
                TypeHeatIndexJSON result = new TypeHeatIndexJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeHeatIndexAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeHeatIndexJSON result)
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
            protected abstract void handle_result(TypeHeatIndexJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeHeatIndex class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeHeatIndex class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeHeatIndex class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeHeatIndex class");
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
            protected override void handle_result(TypeHeatIndexJSON  result)
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
            public TypeHeatIndexJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeHeatIndexJSON  result)
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
        protected virtual void handle_result(List<TypeHeatIndexJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeHeatIndexJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeHeatIndexJSON>();
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
        public List<TypeHeatIndexJSON> value;
      };
      };
    public class TypeWindchillJSON : JSONBase
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


        public TypeWindchillJSON()
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


        public virtual int extraTypeWindchillComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeWindchillComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeWindchillComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeWindchillLookup(string field_name)
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

        public virtual void extraTypeWindchillAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeWindchillSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeWindchillLookup(key);
            if (old_field == null)
              {
                extraTypeWindchillAppendPair(key, new_component);
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

        public static TypeWindchillJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWindchillJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindchill", ignore_extras);
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
        public static TypeWindchillJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWindchillJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWindchillJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindchill", ignore_extras);
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
        public static TypeWindchillJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWindchillJSON from_text(string text, bool ignore_extras)
          {
            TypeWindchillJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindchill", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeWindchillJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeWindchillJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeWindchillJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindchill", ignore_extras);
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
                TypeWindchillJSON result = new TypeWindchillJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeWindchillAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeWindchillJSON result)
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
            protected abstract void handle_result(TypeWindchillJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeWindchill class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeWindchill class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeWindchill class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeWindchill class");
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
            protected override void handle_result(TypeWindchillJSON  result)
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
            public TypeWindchillJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeWindchillJSON  result)
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
        protected virtual void handle_result(List<TypeWindchillJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeWindchillJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeWindchillJSON>();
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
        public List<TypeWindchillJSON> value;
      };
      };
    public class TypeDewPointJSON : JSONBase
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


        public TypeDewPointJSON()
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


        public virtual int extraTypeDewPointComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDewPointComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDewPointComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDewPointLookup(string field_name)
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

        public virtual void extraTypeDewPointAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDewPointSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDewPointLookup(key);
            if (old_field == null)
              {
                extraTypeDewPointAppendPair(key, new_component);
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

        public static TypeDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDewPoint", ignore_extras);
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
        public static TypeDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDewPoint", ignore_extras);
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
        public static TypeDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDewPointJSON from_text(string text, bool ignore_extras)
          {
            TypeDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDewPoint", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDewPointJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDewPoint", ignore_extras);
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
                TypeDewPointJSON result = new TypeDewPointJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDewPointJSON result)
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
            protected abstract void handle_result(TypeDewPointJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeDewPoint class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDewPoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeDewPoint class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDewPoint class");
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
            protected override void handle_result(TypeDewPointJSON  result)
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
            public TypeDewPointJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDewPointJSON  result)
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
        protected virtual void handle_result(List<TypeDewPointJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDewPointJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDewPointJSON>();
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
        public List<TypeDewPointJSON> value;
      };
      };
    public class TypeBarometricPressureJSON : JSONBase
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


        public TypeBarometricPressureJSON()
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


        public virtual int extraTypeBarometricPressureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeBarometricPressureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeBarometricPressureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeBarometricPressureLookup(string field_name)
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

        public virtual void extraTypeBarometricPressureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeBarometricPressureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeBarometricPressureLookup(key);
            if (old_field == null)
              {
                extraTypeBarometricPressureAppendPair(key, new_component);
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

        public static TypeBarometricPressureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeBarometricPressureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBarometricPressure", ignore_extras);
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
        public static TypeBarometricPressureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeBarometricPressureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeBarometricPressureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBarometricPressure", ignore_extras);
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
        public static TypeBarometricPressureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeBarometricPressureJSON from_text(string text, bool ignore_extras)
          {
            TypeBarometricPressureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBarometricPressure", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeBarometricPressureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeBarometricPressureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeBarometricPressureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBarometricPressure", ignore_extras);
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
                TypeBarometricPressureJSON result = new TypeBarometricPressureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeBarometricPressureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeBarometricPressureJSON result)
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
            protected abstract void handle_result(TypeBarometricPressureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the TypeBarometricPressure class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeBarometricPressure class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the TypeBarometricPressure class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeBarometricPressure class");
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
            protected override void handle_result(TypeBarometricPressureJSON  result)
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
            public TypeBarometricPressureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeBarometricPressureJSON  result)
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
        protected virtual void handle_result(List<TypeBarometricPressureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeBarometricPressureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeBarometricPressureJSON>();
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
        public List<TypeBarometricPressureJSON> value;
      };
      };
    public class TypePrecipitationTotalJSON : JSONBase
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


        public TypePrecipitationTotalJSON()
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


        public virtual int extraTypePrecipitationTotalComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePrecipitationTotalComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePrecipitationTotalComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePrecipitationTotalLookup(string field_name)
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

        public virtual void extraTypePrecipitationTotalAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePrecipitationTotalSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePrecipitationTotalLookup(key);
            if (old_field == null)
              {
                extraTypePrecipitationTotalAppendPair(key, new_component);
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

        public static TypePrecipitationTotalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitationTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationTotal", ignore_extras);
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
        public static TypePrecipitationTotalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitationTotalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitationTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationTotal", ignore_extras);
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
        public static TypePrecipitationTotalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitationTotalJSON from_text(string text, bool ignore_extras)
          {
            TypePrecipitationTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationTotal", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePrecipitationTotalJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePrecipitationTotalJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePrecipitationTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationTotal", ignore_extras);
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
                TypePrecipitationTotalJSON result = new TypePrecipitationTotalJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePrecipitationTotalAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePrecipitationTotalJSON result)
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
            protected abstract void handle_result(TypePrecipitationTotalJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitationTotal class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePrecipitationTotal class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitationTotal class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePrecipitationTotal class");
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
            protected override void handle_result(TypePrecipitationTotalJSON  result)
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
            public TypePrecipitationTotalJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePrecipitationTotalJSON  result)
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
        protected virtual void handle_result(List<TypePrecipitationTotalJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePrecipitationTotalJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePrecipitationTotalJSON>();
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
        public List<TypePrecipitationTotalJSON> value;
      };
      };
    public class TypeSnowTotalJSON : JSONBase
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


        public TypeSnowTotalJSON()
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


        public virtual int extraTypeSnowTotalComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSnowTotalComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSnowTotalComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSnowTotalLookup(string field_name)
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

        public virtual void extraTypeSnowTotalAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSnowTotalSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSnowTotalLookup(key);
            if (old_field == null)
              {
                extraTypeSnowTotalAppendPair(key, new_component);
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

        public static TypeSnowTotalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSnowTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowTotal", ignore_extras);
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
        public static TypeSnowTotalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSnowTotalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSnowTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowTotal", ignore_extras);
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
        public static TypeSnowTotalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSnowTotalJSON from_text(string text, bool ignore_extras)
          {
            TypeSnowTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowTotal", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSnowTotalJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSnowTotalJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSnowTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowTotal", ignore_extras);
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
                TypeSnowTotalJSON result = new TypeSnowTotalJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSnowTotalAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSnowTotalJSON result)
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
            protected abstract void handle_result(TypeSnowTotalJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowTotal class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSnowTotal class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowTotal class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSnowTotal class");
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
            protected override void handle_result(TypeSnowTotalJSON  result)
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
            public TypeSnowTotalJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSnowTotalJSON  result)
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
        protected virtual void handle_result(List<TypeSnowTotalJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSnowTotalJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSnowTotalJSON>();
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
        public List<TypeSnowTotalJSON> value;
      };
      };
    private bool flagHasForecastDateAndTime;
    private DateAndOrTimeJSON  storeForecastDateAndTime;
    private bool flagHasConditionsShortPhrase;
    private ForecastShortPhraseJSON  storeConditionsShortPhrase;
    private bool flagHasConditionsShortPhraseDisplay;
    private string storeConditionsShortPhraseDisplay;
    private bool flagHasConditionsShortPhraseSpoken;
    private string storeConditionsShortPhraseSpoken;
    private bool flagHasConditionsShortPhraseWritten;
    private string storeConditionsShortPhraseWritten;
    private bool flagHasWeatherIconURL;
    private string storeWeatherIconURL;
    private bool flagHasConditionsImage;
    private WeatherImageJSON  storeConditionsImage;
    private bool flagHasTemperature;
    private TypeTemperatureJSON  storeTemperature;
    private bool flagHasFeelsLikeTemperature;
    private TypeFeelsLikeTemperatureJSON  storeFeelsLikeTemperature;
    private bool flagHasHeatIndex;
    private TypeHeatIndexJSON  storeHeatIndex;
    private bool flagHasWindchill;
    private TypeWindchillJSON  storeWindchill;
    private bool flagHasDewPoint;
    private TypeDewPointJSON  storeDewPoint;
    private bool flagHasProbabilityOfPrecipitationPct;
    private sbyte storeProbabilityOfPrecipitationPct;
    private bool flagHasHumidityPct;
    private sbyte storeHumidityPct;
    private bool flagHasUVIndex;
    private UVIndexDataJSON  storeUVIndex;
    private bool flagHasWind;
    private WindDataJSON  storeWind;
    private bool flagHasBarometricPressure;
    private TypeBarometricPressureJSON  storeBarometricPressure;
    private bool flagHasPrecipitationTotal;
    private TypePrecipitationTotalJSON  storePrecipitationTotal;
    private bool flagHasSnowTotal;
    private TypeSnowTotalJSON  storeSnowTotal;
    private bool flagHasCloudinessPct;
    private sbyte storeCloudinessPct;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONForecastDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setForecastDateAndTime(convert_classy);
      }


    private void  fromJSONConditionsShortPhrase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ForecastShortPhraseJSON convert_classy = ForecastShortPhraseJSON.from_json(json_value, ignore_extras, true);
        setConditionsShortPhrase(convert_classy);
      }


    private void  fromJSONConditionsShortPhraseDisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhraseDisplay of HourlyForecastJSON is not a string.");
        setConditionsShortPhraseDisplay(json_string.getData());
      }


    private void  fromJSONConditionsShortPhraseSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhraseSpoken of HourlyForecastJSON is not a string.");
        setConditionsShortPhraseSpoken(json_string.getData());
      }


    private void  fromJSONConditionsShortPhraseWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhraseWritten of HourlyForecastJSON is not a string.");
        setConditionsShortPhraseWritten(json_string.getData());
      }


    private void  fromJSONWeatherIconURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WeatherIconURL of HourlyForecastJSON is not a string.");
        setWeatherIconURL(json_string.getData());
      }


    private void  fromJSONConditionsImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherImageJSON convert_classy = WeatherImageJSON.from_json(json_value, ignore_extras, true);
        setConditionsImage(convert_classy);
      }


    private void  fromJSONTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeTemperatureJSON convert_classy = TypeTemperatureJSON.from_json(json_value, ignore_extras, true);
        setTemperature(convert_classy);
      }


    private void  fromJSONFeelsLikeTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeFeelsLikeTemperatureJSON convert_classy = TypeFeelsLikeTemperatureJSON.from_json(json_value, ignore_extras, true);
        setFeelsLikeTemperature(convert_classy);
      }


    private void  fromJSONHeatIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeHeatIndexJSON convert_classy = TypeHeatIndexJSON.from_json(json_value, ignore_extras, true);
        setHeatIndex(convert_classy);
      }


    private void  fromJSONWindchill(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeWindchillJSON convert_classy = TypeWindchillJSON.from_json(json_value, ignore_extras, true);
        setWindchill(convert_classy);
      }


    private void  fromJSONDewPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDewPointJSON convert_classy = TypeDewPointJSON.from_json(json_value, ignore_extras, true);
        setDewPoint(convert_classy);
      }


    private void  fromJSONProbabilityOfPrecipitationPct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ProbabilityOfPrecipitationPct of HourlyForecastJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProbabilityOfPrecipitationPct of HourlyForecastJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setProbabilityOfPrecipitationPct(extracted_integer);
      }


    private void  fromJSONHumidityPct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field HumidityPct of HourlyForecastJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field HumidityPct of HourlyForecastJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setHumidityPct(extracted_integer);
      }


    private void  fromJSONUVIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UVIndexDataJSON convert_classy = UVIndexDataJSON.from_json(json_value, ignore_extras, true);
        setUVIndex(convert_classy);
      }


    private void  fromJSONWind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WindDataJSON convert_classy = WindDataJSON.from_json(json_value, ignore_extras, true);
        setWind(convert_classy);
      }


    private void  fromJSONBarometricPressure(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeBarometricPressureJSON convert_classy = TypeBarometricPressureJSON.from_json(json_value, ignore_extras, true);
        setBarometricPressure(convert_classy);
      }


    private void  fromJSONPrecipitationTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePrecipitationTotalJSON convert_classy = TypePrecipitationTotalJSON.from_json(json_value, ignore_extras, true);
        setPrecipitationTotal(convert_classy);
      }


    private void  fromJSONSnowTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSnowTotalJSON convert_classy = TypeSnowTotalJSON.from_json(json_value, ignore_extras, true);
        setSnowTotal(convert_classy);
      }


    private void  fromJSONCloudinessPct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CloudinessPct of HourlyForecastJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CloudinessPct of HourlyForecastJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setCloudinessPct(extracted_integer);
      }


    public HourlyForecastJSON()
      {
        flagHasForecastDateAndTime = false;
        flagHasConditionsShortPhrase = false;
        flagHasConditionsShortPhraseDisplay = false;
        flagHasConditionsShortPhraseSpoken = false;
        flagHasConditionsShortPhraseWritten = false;
        flagHasWeatherIconURL = false;
        flagHasConditionsImage = false;
        flagHasTemperature = false;
        flagHasFeelsLikeTemperature = false;
        flagHasHeatIndex = false;
        flagHasWindchill = false;
        flagHasDewPoint = false;
        flagHasProbabilityOfPrecipitationPct = false;
        flagHasHumidityPct = false;
        flagHasUVIndex = false;
        flagHasWind = false;
        flagHasBarometricPressure = false;
        flagHasPrecipitationTotal = false;
        flagHasSnowTotal = false;
        flagHasCloudinessPct = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasForecastDateAndTime()
      {
        return flagHasForecastDateAndTime;
      }

    public DateAndOrTimeJSON   getForecastDateAndTime()
      {
        Debug.Assert(flagHasForecastDateAndTime);
        return storeForecastDateAndTime;
      }

    public bool  hasConditionsShortPhrase()
      {
        return flagHasConditionsShortPhrase;
      }

    public ForecastShortPhraseJSON   getConditionsShortPhrase()
      {
        Debug.Assert(flagHasConditionsShortPhrase);
        return storeConditionsShortPhrase;
      }

    public ForecastShortPhraseJSON.TypeValue  getConditionsShortPhraseValue()
      {
        return getConditionsShortPhrase().getValue();
      }

    public string  getConditionsShortPhraseAsString()
      {
        return getConditionsShortPhrase().getValueAsString();
      }

    public bool  hasConditionsShortPhraseDisplay()
      {
        return flagHasConditionsShortPhraseDisplay;
      }

    public string  getConditionsShortPhraseDisplay()
      {
        Debug.Assert(flagHasConditionsShortPhraseDisplay);
        return storeConditionsShortPhraseDisplay;
      }

    public bool  hasConditionsShortPhraseSpoken()
      {
        return flagHasConditionsShortPhraseSpoken;
      }

    public string  getConditionsShortPhraseSpoken()
      {
        Debug.Assert(flagHasConditionsShortPhraseSpoken);
        return storeConditionsShortPhraseSpoken;
      }

    public bool  hasConditionsShortPhraseWritten()
      {
        return flagHasConditionsShortPhraseWritten;
      }

    public string  getConditionsShortPhraseWritten()
      {
        Debug.Assert(flagHasConditionsShortPhraseWritten);
        return storeConditionsShortPhraseWritten;
      }

    public bool  hasWeatherIconURL()
      {
        return flagHasWeatherIconURL;
      }

    public string  getWeatherIconURL()
      {
        Debug.Assert(flagHasWeatherIconURL);
        return storeWeatherIconURL;
      }

    public bool  hasConditionsImage()
      {
        return flagHasConditionsImage;
      }

    public WeatherImageJSON   getConditionsImage()
      {
        Debug.Assert(flagHasConditionsImage);
        return storeConditionsImage;
      }

    public bool  hasTemperature()
      {
        return flagHasTemperature;
      }

    public TypeTemperatureJSON   getTemperature()
      {
        Debug.Assert(flagHasTemperature);
        return storeTemperature;
      }

    public bool  hasFeelsLikeTemperature()
      {
        return flagHasFeelsLikeTemperature;
      }

    public TypeFeelsLikeTemperatureJSON   getFeelsLikeTemperature()
      {
        Debug.Assert(flagHasFeelsLikeTemperature);
        return storeFeelsLikeTemperature;
      }

    public bool  hasHeatIndex()
      {
        return flagHasHeatIndex;
      }

    public TypeHeatIndexJSON   getHeatIndex()
      {
        Debug.Assert(flagHasHeatIndex);
        return storeHeatIndex;
      }

    public bool  hasWindchill()
      {
        return flagHasWindchill;
      }

    public TypeWindchillJSON   getWindchill()
      {
        Debug.Assert(flagHasWindchill);
        return storeWindchill;
      }

    public bool  hasDewPoint()
      {
        return flagHasDewPoint;
      }

    public TypeDewPointJSON   getDewPoint()
      {
        Debug.Assert(flagHasDewPoint);
        return storeDewPoint;
      }

    public bool  hasProbabilityOfPrecipitationPct()
      {
        return flagHasProbabilityOfPrecipitationPct;
      }

    public sbyte  getProbabilityOfPrecipitationPct()
      {
        Debug.Assert(flagHasProbabilityOfPrecipitationPct);
        return storeProbabilityOfPrecipitationPct;
      }

    public bool  hasHumidityPct()
      {
        return flagHasHumidityPct;
      }

    public sbyte  getHumidityPct()
      {
        Debug.Assert(flagHasHumidityPct);
        return storeHumidityPct;
      }

    public bool  hasUVIndex()
      {
        return flagHasUVIndex;
      }

    public UVIndexDataJSON   getUVIndex()
      {
        Debug.Assert(flagHasUVIndex);
        return storeUVIndex;
      }

    public bool  hasWind()
      {
        return flagHasWind;
      }

    public WindDataJSON   getWind()
      {
        Debug.Assert(flagHasWind);
        return storeWind;
      }

    public bool  hasBarometricPressure()
      {
        return flagHasBarometricPressure;
      }

    public TypeBarometricPressureJSON   getBarometricPressure()
      {
        Debug.Assert(flagHasBarometricPressure);
        return storeBarometricPressure;
      }

    public bool  hasPrecipitationTotal()
      {
        return flagHasPrecipitationTotal;
      }

    public TypePrecipitationTotalJSON   getPrecipitationTotal()
      {
        Debug.Assert(flagHasPrecipitationTotal);
        return storePrecipitationTotal;
      }

    public bool  hasSnowTotal()
      {
        return flagHasSnowTotal;
      }

    public TypeSnowTotalJSON   getSnowTotal()
      {
        Debug.Assert(flagHasSnowTotal);
        return storeSnowTotal;
      }

    public bool  hasCloudinessPct()
      {
        return flagHasCloudinessPct;
      }

    public sbyte  getCloudinessPct()
      {
        Debug.Assert(flagHasCloudinessPct);
        return storeCloudinessPct;
      }


    public virtual int extraHourlyForecastComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHourlyForecastComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHourlyForecastComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHourlyForecastLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setForecastDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasForecastDateAndTime)
          {
          }
        flagHasForecastDateAndTime = true;
        storeForecastDateAndTime = new_value;
      }
    public void unsetForecastDateAndTime()
      {
        if (flagHasForecastDateAndTime)
          {
          }
        flagHasForecastDateAndTime = false;
      }
    public void setConditionsShortPhrase(ForecastShortPhraseJSON  new_value)
      {
        if (flagHasConditionsShortPhrase)
          {
          }
        flagHasConditionsShortPhrase = true;
        storeConditionsShortPhrase = new_value;
      }
    public void setConditionsShortPhrase(ForecastShortPhraseJSON.TypeValue new_value)
      {
        setConditionsShortPhrase(new ForecastShortPhraseJSON(new_value));
      }
    public void setConditionsShortPhrase(string chars)
      {
        ForecastShortPhraseJSON.TypeValueKnownValues known = ForecastShortPhraseJSON.stringToValue(chars);
        ForecastShortPhraseJSON.TypeValue new_value = new ForecastShortPhraseJSON.TypeValue();
        if (known == ForecastShortPhraseJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setConditionsShortPhrase(new_value);
      }
    public void unsetConditionsShortPhrase()
      {
        if (flagHasConditionsShortPhrase)
          {
          }
        flagHasConditionsShortPhrase = false;
      }
    public void setConditionsShortPhraseDisplay(string new_value)
      {
        flagHasConditionsShortPhraseDisplay = true;
        storeConditionsShortPhraseDisplay = new_value;
      }
    public void unsetConditionsShortPhraseDisplay()
      {
        flagHasConditionsShortPhraseDisplay = false;
      }
    public void setConditionsShortPhraseSpoken(string new_value)
      {
        flagHasConditionsShortPhraseSpoken = true;
        storeConditionsShortPhraseSpoken = new_value;
      }
    public void unsetConditionsShortPhraseSpoken()
      {
        flagHasConditionsShortPhraseSpoken = false;
      }
    public void setConditionsShortPhraseWritten(string new_value)
      {
        flagHasConditionsShortPhraseWritten = true;
        storeConditionsShortPhraseWritten = new_value;
      }
    public void unsetConditionsShortPhraseWritten()
      {
        flagHasConditionsShortPhraseWritten = false;
      }
    public void setWeatherIconURL(string new_value)
      {
        flagHasWeatherIconURL = true;
        storeWeatherIconURL = new_value;
      }
    public void unsetWeatherIconURL()
      {
        flagHasWeatherIconURL = false;
      }
    public void setConditionsImage(WeatherImageJSON  new_value)
      {
        if (flagHasConditionsImage)
          {
          }
        flagHasConditionsImage = true;
        storeConditionsImage = new_value;
      }
    public void unsetConditionsImage()
      {
        if (flagHasConditionsImage)
          {
          }
        flagHasConditionsImage = false;
      }
    public void setTemperature(TypeTemperatureJSON  new_value)
      {
        if (flagHasTemperature)
          {
          }
        flagHasTemperature = true;
        storeTemperature = new_value;
      }
    public void unsetTemperature()
      {
        if (flagHasTemperature)
          {
          }
        flagHasTemperature = false;
      }
    public void setFeelsLikeTemperature(TypeFeelsLikeTemperatureJSON  new_value)
      {
        if (flagHasFeelsLikeTemperature)
          {
          }
        flagHasFeelsLikeTemperature = true;
        storeFeelsLikeTemperature = new_value;
      }
    public void unsetFeelsLikeTemperature()
      {
        if (flagHasFeelsLikeTemperature)
          {
          }
        flagHasFeelsLikeTemperature = false;
      }
    public void setHeatIndex(TypeHeatIndexJSON  new_value)
      {
        if (flagHasHeatIndex)
          {
          }
        flagHasHeatIndex = true;
        storeHeatIndex = new_value;
      }
    public void unsetHeatIndex()
      {
        if (flagHasHeatIndex)
          {
          }
        flagHasHeatIndex = false;
      }
    public void setWindchill(TypeWindchillJSON  new_value)
      {
        if (flagHasWindchill)
          {
          }
        flagHasWindchill = true;
        storeWindchill = new_value;
      }
    public void unsetWindchill()
      {
        if (flagHasWindchill)
          {
          }
        flagHasWindchill = false;
      }
    public void setDewPoint(TypeDewPointJSON  new_value)
      {
        if (flagHasDewPoint)
          {
          }
        flagHasDewPoint = true;
        storeDewPoint = new_value;
      }
    public void unsetDewPoint()
      {
        if (flagHasDewPoint)
          {
          }
        flagHasDewPoint = false;
      }
    public void setProbabilityOfPrecipitationPct(sbyte new_value)
      {
        flagHasProbabilityOfPrecipitationPct = true;
        if (new_value < 0)
            throw new Exception("The value for field ProbabilityOfPrecipitationPct of HourlyForecastJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field ProbabilityOfPrecipitationPct of HourlyForecastJSON is greater than the upper bound (100) for that field.");
        storeProbabilityOfPrecipitationPct = new_value;
      }
    public void unsetProbabilityOfPrecipitationPct()
      {
        flagHasProbabilityOfPrecipitationPct = false;
      }
    public void setHumidityPct(sbyte new_value)
      {
        flagHasHumidityPct = true;
        if (new_value < 0)
            throw new Exception("The value for field HumidityPct of HourlyForecastJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field HumidityPct of HourlyForecastJSON is greater than the upper bound (100) for that field.");
        storeHumidityPct = new_value;
      }
    public void unsetHumidityPct()
      {
        flagHasHumidityPct = false;
      }
    public void setUVIndex(UVIndexDataJSON  new_value)
      {
        if (flagHasUVIndex)
          {
          }
        flagHasUVIndex = true;
        storeUVIndex = new_value;
      }
    public void unsetUVIndex()
      {
        if (flagHasUVIndex)
          {
          }
        flagHasUVIndex = false;
      }
    public void setWind(WindDataJSON  new_value)
      {
        if (flagHasWind)
          {
          }
        flagHasWind = true;
        storeWind = new_value;
      }
    public void unsetWind()
      {
        if (flagHasWind)
          {
          }
        flagHasWind = false;
      }
    public void setBarometricPressure(TypeBarometricPressureJSON  new_value)
      {
        if (flagHasBarometricPressure)
          {
          }
        flagHasBarometricPressure = true;
        storeBarometricPressure = new_value;
      }
    public void unsetBarometricPressure()
      {
        if (flagHasBarometricPressure)
          {
          }
        flagHasBarometricPressure = false;
      }
    public void setPrecipitationTotal(TypePrecipitationTotalJSON  new_value)
      {
        if (flagHasPrecipitationTotal)
          {
          }
        flagHasPrecipitationTotal = true;
        storePrecipitationTotal = new_value;
      }
    public void unsetPrecipitationTotal()
      {
        if (flagHasPrecipitationTotal)
          {
          }
        flagHasPrecipitationTotal = false;
      }
    public void setSnowTotal(TypeSnowTotalJSON  new_value)
      {
        if (flagHasSnowTotal)
          {
          }
        flagHasSnowTotal = true;
        storeSnowTotal = new_value;
      }
    public void unsetSnowTotal()
      {
        if (flagHasSnowTotal)
          {
          }
        flagHasSnowTotal = false;
      }
    public void setCloudinessPct(sbyte new_value)
      {
        flagHasCloudinessPct = true;
        if (new_value < 0)
            throw new Exception("The value for field CloudinessPct of HourlyForecastJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field CloudinessPct of HourlyForecastJSON is greater than the upper bound (100) for that field.");
        storeCloudinessPct = new_value;
      }
    public void unsetCloudinessPct()
      {
        flagHasCloudinessPct = false;
      }

    public virtual void extraHourlyForecastAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHourlyForecastSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHourlyForecastLookup(key);
        if (old_field == null)
          {
            extraHourlyForecastAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasForecastDateAndTime);
        if (flagHasForecastDateAndTime)
          {
            handler.start_pair("ForecastDateAndTime");
            if (partial_allowed)
                storeForecastDateAndTime.write_partial_as_json(handler);
            else
                storeForecastDateAndTime.write_as_json(handler);
          }
        if (flagHasConditionsShortPhrase)
          {
            handler.start_pair("ConditionsShortPhrase");
            if (partial_allowed)
                storeConditionsShortPhrase.write_partial_as_json(handler);
            else
                storeConditionsShortPhrase.write_as_json(handler);
          }
        if (flagHasConditionsShortPhraseDisplay)
          {
            handler.start_pair("ConditionsShortPhraseDisplay");
            handler.string_value(storeConditionsShortPhraseDisplay);
          }
        if (flagHasConditionsShortPhraseSpoken)
          {
            handler.start_pair("ConditionsShortPhraseSpoken");
            handler.string_value(storeConditionsShortPhraseSpoken);
          }
        if (flagHasConditionsShortPhraseWritten)
          {
            handler.start_pair("ConditionsShortPhraseWritten");
            handler.string_value(storeConditionsShortPhraseWritten);
          }
        if (flagHasWeatherIconURL)
          {
            handler.start_pair("WeatherIconURL");
            handler.string_value(storeWeatherIconURL);
          }
        if (flagHasConditionsImage)
          {
            handler.start_pair("ConditionsImage");
            if (partial_allowed)
                storeConditionsImage.write_partial_as_json(handler);
            else
                storeConditionsImage.write_as_json(handler);
          }
        if (flagHasTemperature)
          {
            handler.start_pair("Temperature");
            if (partial_allowed)
                storeTemperature.write_partial_as_json(handler);
            else
                storeTemperature.write_as_json(handler);
          }
        if (flagHasFeelsLikeTemperature)
          {
            handler.start_pair("FeelsLikeTemperature");
            if (partial_allowed)
                storeFeelsLikeTemperature.write_partial_as_json(handler);
            else
                storeFeelsLikeTemperature.write_as_json(handler);
          }
        if (flagHasHeatIndex)
          {
            handler.start_pair("HeatIndex");
            if (partial_allowed)
                storeHeatIndex.write_partial_as_json(handler);
            else
                storeHeatIndex.write_as_json(handler);
          }
        if (flagHasWindchill)
          {
            handler.start_pair("Windchill");
            if (partial_allowed)
                storeWindchill.write_partial_as_json(handler);
            else
                storeWindchill.write_as_json(handler);
          }
        if (flagHasDewPoint)
          {
            handler.start_pair("DewPoint");
            if (partial_allowed)
                storeDewPoint.write_partial_as_json(handler);
            else
                storeDewPoint.write_as_json(handler);
          }
        if (flagHasProbabilityOfPrecipitationPct)
          {
            handler.start_pair("ProbabilityOfPrecipitationPct");
            handler.number_value(storeProbabilityOfPrecipitationPct);
          }
        if (flagHasHumidityPct)
          {
            handler.start_pair("HumidityPct");
            handler.number_value(storeHumidityPct);
          }
        if (flagHasUVIndex)
          {
            handler.start_pair("UVIndex");
            if (partial_allowed)
                storeUVIndex.write_partial_as_json(handler);
            else
                storeUVIndex.write_as_json(handler);
          }
        if (flagHasWind)
          {
            handler.start_pair("Wind");
            if (partial_allowed)
                storeWind.write_partial_as_json(handler);
            else
                storeWind.write_as_json(handler);
          }
        if (flagHasBarometricPressure)
          {
            handler.start_pair("BarometricPressure");
            if (partial_allowed)
                storeBarometricPressure.write_partial_as_json(handler);
            else
                storeBarometricPressure.write_as_json(handler);
          }
        if (flagHasPrecipitationTotal)
          {
            handler.start_pair("PrecipitationTotal");
            if (partial_allowed)
                storePrecipitationTotal.write_partial_as_json(handler);
            else
                storePrecipitationTotal.write_as_json(handler);
          }
        if (flagHasSnowTotal)
          {
            handler.start_pair("SnowTotal");
            if (partial_allowed)
                storeSnowTotal.write_partial_as_json(handler);
            else
                storeSnowTotal.write_as_json(handler);
          }
        if (flagHasCloudinessPct)
          {
            handler.start_pair("CloudinessPct");
            handler.number_value(storeCloudinessPct);
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
        if (!(hasForecastDateAndTime()))
          {
            return "When parsing the object for %what%, the \"ForecastDateAndTime\" field was missing.";
          }
        return null;
      }

    public static HourlyForecastJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HourlyForecastJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HourlyForecast", ignore_extras);
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
    public static HourlyForecastJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HourlyForecastJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HourlyForecastJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HourlyForecast", ignore_extras);
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
    public static HourlyForecastJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HourlyForecastJSON from_text(string text, bool ignore_extras)
      {
        HourlyForecastJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HourlyForecast", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HourlyForecastJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HourlyForecastJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HourlyForecastJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HourlyForecast", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorForecastDateAndTime;
        private ForecastShortPhraseJSON.HoldingGenerator fieldGeneratorConditionsShortPhrase;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseDisplay;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseSpoken;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseWritten;
        private JSONHoldingStringGenerator fieldGeneratorWeatherIconURL;
        private WeatherImageJSON.HoldingGenerator fieldGeneratorConditionsImage;
        private TypeTemperatureJSON.HoldingGenerator fieldGeneratorTemperature;
        private TypeFeelsLikeTemperatureJSON.HoldingGenerator fieldGeneratorFeelsLikeTemperature;
        private TypeHeatIndexJSON.HoldingGenerator fieldGeneratorHeatIndex;
        private TypeWindchillJSON.HoldingGenerator fieldGeneratorWindchill;
        private TypeDewPointJSON.HoldingGenerator fieldGeneratorDewPoint;
    private class FieldHoldingGeneratorProbabilityOfPrecipitationPct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorProbabilityOfPrecipitationPct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorProbabilityOfPrecipitationPct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorProbabilityOfPrecipitationPct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorProbabilityOfPrecipitationPct fieldGeneratorProbabilityOfPrecipitationPct;
    private class FieldHoldingGeneratorHumidityPct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorHumidityPct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorHumidityPct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorHumidityPct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorHumidityPct fieldGeneratorHumidityPct;
        private UVIndexDataJSON.HoldingGenerator fieldGeneratorUVIndex;
        private WindDataJSON.HoldingGenerator fieldGeneratorWind;
        private TypeBarometricPressureJSON.HoldingGenerator fieldGeneratorBarometricPressure;
        private TypePrecipitationTotalJSON.HoldingGenerator fieldGeneratorPrecipitationTotal;
        private TypeSnowTotalJSON.HoldingGenerator fieldGeneratorSnowTotal;
    private class FieldHoldingGeneratorCloudinessPct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorCloudinessPct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCloudinessPct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCloudinessPct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorCloudinessPct fieldGeneratorCloudinessPct;
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
            HourlyForecastJSON result = new HourlyForecastJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHourlyForecastAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HourlyForecastJSON result)
          {
            if (fieldGeneratorForecastDateAndTime.have_value)
              {
                result.setForecastDateAndTime(fieldGeneratorForecastDateAndTime.value);
                fieldGeneratorForecastDateAndTime.have_value = false;
              }
            else if ((!(result.hasForecastDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ForecastDateAndTime\" field was missing.");
              }
            if (fieldGeneratorConditionsShortPhrase.have_value)
              {
                result.setConditionsShortPhrase(fieldGeneratorConditionsShortPhrase.value);
                fieldGeneratorConditionsShortPhrase.have_value = false;
              }
            if (fieldGeneratorConditionsShortPhraseDisplay.have_value)
              {
                result.setConditionsShortPhraseDisplay(fieldGeneratorConditionsShortPhraseDisplay.value);
                fieldGeneratorConditionsShortPhraseDisplay.have_value = false;
              }
            if (fieldGeneratorConditionsShortPhraseSpoken.have_value)
              {
                result.setConditionsShortPhraseSpoken(fieldGeneratorConditionsShortPhraseSpoken.value);
                fieldGeneratorConditionsShortPhraseSpoken.have_value = false;
              }
            if (fieldGeneratorConditionsShortPhraseWritten.have_value)
              {
                result.setConditionsShortPhraseWritten(fieldGeneratorConditionsShortPhraseWritten.value);
                fieldGeneratorConditionsShortPhraseWritten.have_value = false;
              }
            if (fieldGeneratorWeatherIconURL.have_value)
              {
                result.setWeatherIconURL(fieldGeneratorWeatherIconURL.value);
                fieldGeneratorWeatherIconURL.have_value = false;
              }
            if (fieldGeneratorConditionsImage.have_value)
              {
                result.setConditionsImage(fieldGeneratorConditionsImage.value);
                fieldGeneratorConditionsImage.have_value = false;
              }
            if (fieldGeneratorTemperature.have_value)
              {
                result.setTemperature(fieldGeneratorTemperature.value);
                fieldGeneratorTemperature.have_value = false;
              }
            if (fieldGeneratorFeelsLikeTemperature.have_value)
              {
                result.setFeelsLikeTemperature(fieldGeneratorFeelsLikeTemperature.value);
                fieldGeneratorFeelsLikeTemperature.have_value = false;
              }
            if (fieldGeneratorHeatIndex.have_value)
              {
                result.setHeatIndex(fieldGeneratorHeatIndex.value);
                fieldGeneratorHeatIndex.have_value = false;
              }
            if (fieldGeneratorWindchill.have_value)
              {
                result.setWindchill(fieldGeneratorWindchill.value);
                fieldGeneratorWindchill.have_value = false;
              }
            if (fieldGeneratorDewPoint.have_value)
              {
                result.setDewPoint(fieldGeneratorDewPoint.value);
                fieldGeneratorDewPoint.have_value = false;
              }
            if (fieldGeneratorProbabilityOfPrecipitationPct.have_value)
              {
                result.setProbabilityOfPrecipitationPct((sbyte)(fieldGeneratorProbabilityOfPrecipitationPct.value));
                fieldGeneratorProbabilityOfPrecipitationPct.have_value = false;
              }
            if (fieldGeneratorHumidityPct.have_value)
              {
                result.setHumidityPct((sbyte)(fieldGeneratorHumidityPct.value));
                fieldGeneratorHumidityPct.have_value = false;
              }
            if (fieldGeneratorUVIndex.have_value)
              {
                result.setUVIndex(fieldGeneratorUVIndex.value);
                fieldGeneratorUVIndex.have_value = false;
              }
            if (fieldGeneratorWind.have_value)
              {
                result.setWind(fieldGeneratorWind.value);
                fieldGeneratorWind.have_value = false;
              }
            if (fieldGeneratorBarometricPressure.have_value)
              {
                result.setBarometricPressure(fieldGeneratorBarometricPressure.value);
                fieldGeneratorBarometricPressure.have_value = false;
              }
            if (fieldGeneratorPrecipitationTotal.have_value)
              {
                result.setPrecipitationTotal(fieldGeneratorPrecipitationTotal.value);
                fieldGeneratorPrecipitationTotal.have_value = false;
              }
            if (fieldGeneratorSnowTotal.have_value)
              {
                result.setSnowTotal(fieldGeneratorSnowTotal.value);
                fieldGeneratorSnowTotal.have_value = false;
              }
            if (fieldGeneratorCloudinessPct.have_value)
              {
                result.setCloudinessPct((sbyte)(fieldGeneratorCloudinessPct.value));
                fieldGeneratorCloudinessPct.have_value = false;
              }
          }
        protected abstract void handle_result(HourlyForecastJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "arometricPressure", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorBarometricPressure;
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "oudinessPct", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorCloudinessPct;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "nditions", 0, 8, false) == 0)
                              {
                                switch (field_name[10])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 11, "mage", 0, 4, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorConditionsImage;
                                        break;
                                    case 'S':
                                        if (String.Compare(field_name, 11, "hortPhrase", 0, 10, false) == 0)
                                          {
                                            if (field_name.Length == 21)
                                              {
                                                return fieldGeneratorConditionsShortPhrase;
                                              }
                                            switch (field_name[21])
                                              {
                                                case 'D':
                                                    if ((String.Compare(field_name, 22, "isplay", 0, 6, false) == 0) && (field_name.Length == 28))
                                                        return fieldGeneratorConditionsShortPhraseDisplay;
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(field_name, 22, "poken", 0, 5, false) == 0) && (field_name.Length == 27))
                                                        return fieldGeneratorConditionsShortPhraseSpoken;
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(field_name, 22, "ritten", 0, 6, false) == 0) && (field_name.Length == 28))
                                                        return fieldGeneratorConditionsShortPhraseWritten;
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
                case 'D':
                    if ((String.Compare(field_name, 1, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorDewPoint;
                    break;
                case 'F':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "elsLikeTemperature", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorFeelsLikeTemperature;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "recastDateAndTime", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorForecastDateAndTime;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "atIndex", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorHeatIndex;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "midityPct", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorHumidityPct;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "r", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 3, "cipitationTotal", 0, 15, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorPrecipitationTotal;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 3, "babilityOfPrecipitationPct", 0, 26, false) == 0) && (field_name.Length == 29))
                                    return fieldGeneratorProbabilityOfPrecipitationPct;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "nowTotal", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorSnowTotal;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "emperature", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorTemperature;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "VIndex", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorUVIndex;
                    break;
                case 'W':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "atherIconURL", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorWeatherIconURL;
                            break;
                        case 'i':
                            if (String.Compare(field_name, 2, "nd", 0, 2, false) == 0)
                              {
                                if (field_name.Length == 4)
                                  {
                                    return fieldGeneratorWind;
                                  }
                                switch (field_name[4])
                                  {
                                    case 'c':
                                        if ((String.Compare(field_name, 5, "hill", 0, 4, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorWindchill;
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
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorForecastDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ForecastDateAndTime\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorConditionsShortPhrase = new ForecastShortPhraseJSON.HoldingGenerator("field \"ConditionsShortPhrase\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorConditionsShortPhraseDisplay = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseDisplay\" of the HourlyForecast class");
            fieldGeneratorConditionsShortPhraseSpoken = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseSpoken\" of the HourlyForecast class");
            fieldGeneratorConditionsShortPhraseWritten = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseWritten\" of the HourlyForecast class");
            fieldGeneratorWeatherIconURL = new JSONHoldingStringGenerator("field \"WeatherIconURL\" of the HourlyForecast class");
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorTemperature = new TypeTemperatureJSON.HoldingGenerator("field \"Temperature\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorFeelsLikeTemperature = new TypeFeelsLikeTemperatureJSON.HoldingGenerator("field \"FeelsLikeTemperature\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorHeatIndex = new TypeHeatIndexJSON.HoldingGenerator("field \"HeatIndex\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorWindchill = new TypeWindchillJSON.HoldingGenerator("field \"Windchill\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorDewPoint = new TypeDewPointJSON.HoldingGenerator("field \"DewPoint\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorProbabilityOfPrecipitationPct = new FieldHoldingGeneratorProbabilityOfPrecipitationPct("field \"ProbabilityOfPrecipitationPct\" of the HourlyForecast class");
            fieldGeneratorHumidityPct = new FieldHoldingGeneratorHumidityPct("field \"HumidityPct\" of the HourlyForecast class");
            fieldGeneratorUVIndex = new UVIndexDataJSON.HoldingGenerator("field \"UVIndex\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorWind = new WindDataJSON.HoldingGenerator("field \"Wind\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorBarometricPressure = new TypeBarometricPressureJSON.HoldingGenerator("field \"BarometricPressure\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorPrecipitationTotal = new TypePrecipitationTotalJSON.HoldingGenerator("field \"PrecipitationTotal\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorSnowTotal = new TypeSnowTotalJSON.HoldingGenerator("field \"SnowTotal\" of the HourlyForecast class", ignore_extras);
            fieldGeneratorCloudinessPct = new FieldHoldingGeneratorCloudinessPct("field \"CloudinessPct\" of the HourlyForecast class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HourlyForecast class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorForecastDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ForecastDateAndTime\" of the HourlyForecast class", false);
            fieldGeneratorConditionsShortPhrase = new ForecastShortPhraseJSON.HoldingGenerator("field \"ConditionsShortPhrase\" of the HourlyForecast class", false);
            fieldGeneratorConditionsShortPhraseDisplay = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseDisplay\" of the HourlyForecast class");
            fieldGeneratorConditionsShortPhraseSpoken = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseSpoken\" of the HourlyForecast class");
            fieldGeneratorConditionsShortPhraseWritten = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseWritten\" of the HourlyForecast class");
            fieldGeneratorWeatherIconURL = new JSONHoldingStringGenerator("field \"WeatherIconURL\" of the HourlyForecast class");
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the HourlyForecast class", false);
            fieldGeneratorTemperature = new TypeTemperatureJSON.HoldingGenerator("field \"Temperature\" of the HourlyForecast class", false);
            fieldGeneratorFeelsLikeTemperature = new TypeFeelsLikeTemperatureJSON.HoldingGenerator("field \"FeelsLikeTemperature\" of the HourlyForecast class", false);
            fieldGeneratorHeatIndex = new TypeHeatIndexJSON.HoldingGenerator("field \"HeatIndex\" of the HourlyForecast class", false);
            fieldGeneratorWindchill = new TypeWindchillJSON.HoldingGenerator("field \"Windchill\" of the HourlyForecast class", false);
            fieldGeneratorDewPoint = new TypeDewPointJSON.HoldingGenerator("field \"DewPoint\" of the HourlyForecast class", false);
            fieldGeneratorProbabilityOfPrecipitationPct = new FieldHoldingGeneratorProbabilityOfPrecipitationPct("field \"ProbabilityOfPrecipitationPct\" of the HourlyForecast class");
            fieldGeneratorHumidityPct = new FieldHoldingGeneratorHumidityPct("field \"HumidityPct\" of the HourlyForecast class");
            fieldGeneratorUVIndex = new UVIndexDataJSON.HoldingGenerator("field \"UVIndex\" of the HourlyForecast class", false);
            fieldGeneratorWind = new WindDataJSON.HoldingGenerator("field \"Wind\" of the HourlyForecast class", false);
            fieldGeneratorBarometricPressure = new TypeBarometricPressureJSON.HoldingGenerator("field \"BarometricPressure\" of the HourlyForecast class", false);
            fieldGeneratorPrecipitationTotal = new TypePrecipitationTotalJSON.HoldingGenerator("field \"PrecipitationTotal\" of the HourlyForecast class", false);
            fieldGeneratorSnowTotal = new TypeSnowTotalJSON.HoldingGenerator("field \"SnowTotal\" of the HourlyForecast class", false);
            fieldGeneratorCloudinessPct = new FieldHoldingGeneratorCloudinessPct("field \"CloudinessPct\" of the HourlyForecast class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HourlyForecast class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorForecastDateAndTime.reset();
            fieldGeneratorConditionsShortPhrase.reset();
            fieldGeneratorConditionsShortPhraseDisplay.reset();
            fieldGeneratorConditionsShortPhraseSpoken.reset();
            fieldGeneratorConditionsShortPhraseWritten.reset();
            fieldGeneratorWeatherIconURL.reset();
            fieldGeneratorConditionsImage.reset();
            fieldGeneratorTemperature.reset();
            fieldGeneratorFeelsLikeTemperature.reset();
            fieldGeneratorHeatIndex.reset();
            fieldGeneratorWindchill.reset();
            fieldGeneratorDewPoint.reset();
            fieldGeneratorProbabilityOfPrecipitationPct.reset();
            fieldGeneratorHumidityPct.reset();
            fieldGeneratorUVIndex.reset();
            fieldGeneratorWind.reset();
            fieldGeneratorBarometricPressure.reset();
            fieldGeneratorPrecipitationTotal.reset();
            fieldGeneratorSnowTotal.reset();
            fieldGeneratorCloudinessPct.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorForecastDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConditionsShortPhrase.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConditionsImage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFeelsLikeTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHeatIndex.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWindchill.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDewPoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUVIndex.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWind.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBarometricPressure.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrecipitationTotal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSnowTotal.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorForecastDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConditionsShortPhrase.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConditionsImage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFeelsLikeTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHeatIndex.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWindchill.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDewPoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUVIndex.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWind.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBarometricPressure.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrecipitationTotal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSnowTotal.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HourlyForecastJSON  result)
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
        public HourlyForecastJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HourlyForecastJSON  result)
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
    protected virtual void handle_result(List<HourlyForecastJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HourlyForecastJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HourlyForecastJSON>();
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
    public List<HourlyForecastJSON> value;
  };
  };
