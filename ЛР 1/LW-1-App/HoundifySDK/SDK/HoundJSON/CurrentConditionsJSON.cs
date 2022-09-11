/* file "CurrentConditionsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CurrentConditionsJSON : JSONBase
  {
    public class TypeCurrentTemperatureJSON : JSONBase
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


        public TypeCurrentTemperatureJSON()
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


        public virtual int extraTypeCurrentTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeCurrentTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeCurrentTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeCurrentTemperatureLookup(string field_name)
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

        public virtual void extraTypeCurrentTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeCurrentTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeCurrentTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeCurrentTemperatureAppendPair(key, new_component);
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

        public static TypeCurrentTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeCurrentTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCurrentTemperature", ignore_extras);
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
        public static TypeCurrentTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeCurrentTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeCurrentTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCurrentTemperature", ignore_extras);
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
        public static TypeCurrentTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeCurrentTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeCurrentTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCurrentTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeCurrentTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeCurrentTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeCurrentTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCurrentTemperature", ignore_extras);
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
                TypeCurrentTemperatureJSON result = new TypeCurrentTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeCurrentTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeCurrentTemperatureJSON result)
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
            protected abstract void handle_result(TypeCurrentTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeCurrentTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeCurrentTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeCurrentTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeCurrentTemperature class");
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
            protected override void handle_result(TypeCurrentTemperatureJSON  result)
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
            public TypeCurrentTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeCurrentTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeCurrentTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeCurrentTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeCurrentTemperatureJSON>();
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
        public List<TypeCurrentTemperatureJSON> value;
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
    public class TypeVisibilityJSON : JSONBase
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


        public TypeVisibilityJSON()
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


        public virtual int extraTypeVisibilityComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeVisibilityComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeVisibilityComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeVisibilityLookup(string field_name)
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

        public virtual void extraTypeVisibilityAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeVisibilitySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeVisibilityLookup(key);
            if (old_field == null)
              {
                extraTypeVisibilityAppendPair(key, new_component);
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

        public static TypeVisibilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeVisibilityJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVisibility", ignore_extras);
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
        public static TypeVisibilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeVisibilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeVisibilityJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVisibility", ignore_extras);
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
        public static TypeVisibilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeVisibilityJSON from_text(string text, bool ignore_extras)
          {
            TypeVisibilityJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVisibility", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeVisibilityJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeVisibilityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeVisibilityJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVisibility", ignore_extras);
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
                TypeVisibilityJSON result = new TypeVisibilityJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeVisibilityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeVisibilityJSON result)
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
            protected abstract void handle_result(TypeVisibilityJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_VisibilityJSON.HoldingGenerator("field \"Value\" of the TypeVisibility class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeVisibility class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_VisibilityJSON.HoldingGenerator("field \"Value\" of the TypeVisibility class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeVisibility class");
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
            protected override void handle_result(TypeVisibilityJSON  result)
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
            public TypeVisibilityJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeVisibilityJSON  result)
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
        protected virtual void handle_result(List<TypeVisibilityJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeVisibilityJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeVisibilityJSON>();
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
        public List<TypeVisibilityJSON> value;
      };
      };
    public class TypePrecipitation1HourJSON : JSONBase
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


        public TypePrecipitation1HourJSON()
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


        public virtual int extraTypePrecipitation1HourComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePrecipitation1HourComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePrecipitation1HourComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePrecipitation1HourLookup(string field_name)
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

        public virtual void extraTypePrecipitation1HourAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePrecipitation1HourSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePrecipitation1HourLookup(key);
            if (old_field == null)
              {
                extraTypePrecipitation1HourAppendPair(key, new_component);
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

        public static TypePrecipitation1HourJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitation1HourJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation1Hour", ignore_extras);
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
        public static TypePrecipitation1HourJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitation1HourJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitation1HourJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation1Hour", ignore_extras);
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
        public static TypePrecipitation1HourJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitation1HourJSON from_text(string text, bool ignore_extras)
          {
            TypePrecipitation1HourJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation1Hour", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePrecipitation1HourJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePrecipitation1HourJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePrecipitation1HourJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation1Hour", ignore_extras);
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
                TypePrecipitation1HourJSON result = new TypePrecipitation1HourJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePrecipitation1HourAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePrecipitation1HourJSON result)
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
            protected abstract void handle_result(TypePrecipitation1HourJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitation1Hour class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePrecipitation1Hour class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitation1Hour class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePrecipitation1Hour class");
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
            protected override void handle_result(TypePrecipitation1HourJSON  result)
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
            public TypePrecipitation1HourJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePrecipitation1HourJSON  result)
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
        protected virtual void handle_result(List<TypePrecipitation1HourJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePrecipitation1HourJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePrecipitation1HourJSON>();
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
        public List<TypePrecipitation1HourJSON> value;
      };
      };
    public class TypePrecipitationTodayJSON : JSONBase
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


        public TypePrecipitationTodayJSON()
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


        public virtual int extraTypePrecipitationTodayComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePrecipitationTodayComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePrecipitationTodayComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePrecipitationTodayLookup(string field_name)
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

        public virtual void extraTypePrecipitationTodayAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePrecipitationTodaySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePrecipitationTodayLookup(key);
            if (old_field == null)
              {
                extraTypePrecipitationTodayAppendPair(key, new_component);
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

        public static TypePrecipitationTodayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitationTodayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationToday", ignore_extras);
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
        public static TypePrecipitationTodayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitationTodayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitationTodayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationToday", ignore_extras);
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
        public static TypePrecipitationTodayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitationTodayJSON from_text(string text, bool ignore_extras)
          {
            TypePrecipitationTodayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationToday", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePrecipitationTodayJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePrecipitationTodayJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePrecipitationTodayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationToday", ignore_extras);
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
                TypePrecipitationTodayJSON result = new TypePrecipitationTodayJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePrecipitationTodayAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePrecipitationTodayJSON result)
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
            protected abstract void handle_result(TypePrecipitationTodayJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitationToday class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePrecipitationToday class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitationToday class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePrecipitationToday class");
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
            protected override void handle_result(TypePrecipitationTodayJSON  result)
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
            public TypePrecipitationTodayJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePrecipitationTodayJSON  result)
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
        protected virtual void handle_result(List<TypePrecipitationTodayJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePrecipitationTodayJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePrecipitationTodayJSON>();
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
        public List<TypePrecipitationTodayJSON> value;
      };
      };
    public class TypeWindGustJSON : JSONBase
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


        public TypeWindGustJSON()
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


        public virtual int extraTypeWindGustComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeWindGustComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeWindGustComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeWindGustLookup(string field_name)
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

        public virtual void extraTypeWindGustAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeWindGustSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeWindGustLookup(key);
            if (old_field == null)
              {
                extraTypeWindGustAppendPair(key, new_component);
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

        public static TypeWindGustJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWindGustJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindGust", ignore_extras);
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
        public static TypeWindGustJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWindGustJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWindGustJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindGust", ignore_extras);
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
        public static TypeWindGustJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWindGustJSON from_text(string text, bool ignore_extras)
          {
            TypeWindGustJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindGust", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeWindGustJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeWindGustJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeWindGustJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindGust", ignore_extras);
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
                TypeWindGustJSON result = new TypeWindGustJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeWindGustAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeWindGustJSON result)
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
            protected abstract void handle_result(TypeWindGustJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the TypeWindGust class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeWindGust class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the TypeWindGust class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeWindGust class");
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
            protected override void handle_result(TypeWindGustJSON  result)
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
            public TypeWindGustJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeWindGustJSON  result)
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
        protected virtual void handle_result(List<TypeWindGustJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeWindGustJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeWindGustJSON>();
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
        public List<TypeWindGustJSON> value;
      };
      };
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasObservationDateAndTime;
    private DateAndOrTimeJSON  storeObservationDateAndTime;
    private bool flagHasConditionsShortPhrase;
    private CurrentConditionsShortPhraseJSON  storeConditionsShortPhrase;
    private bool flagHasConditionsShortPhraseDisplay;
    private string storeConditionsShortPhraseDisplay;
    private bool flagHasConditionsShortPhraseSpoken;
    private string storeConditionsShortPhraseSpoken;
    private bool flagHasConditionsShortPhraseWritten;
    private string storeConditionsShortPhraseWritten;
    private bool flagHasConditionsShortPhraseActionSpoken;
    private string storeConditionsShortPhraseActionSpoken;
    private bool flagHasConditionsShortPhraseActionWritten;
    private string storeConditionsShortPhraseActionWritten;
    private bool flagHasCurrentTemperature;
    private TypeCurrentTemperatureJSON  storeCurrentTemperature;
    private bool flagHasFeelsLikeTemperature;
    private TypeFeelsLikeTemperatureJSON  storeFeelsLikeTemperature;
    private bool flagHasHeatIndex;
    private TypeHeatIndexJSON  storeHeatIndex;
    private bool flagHasWindchill;
    private TypeWindchillJSON  storeWindchill;
    private bool flagHasDewPoint;
    private TypeDewPointJSON  storeDewPoint;
    private bool flagHasWeatherIconURL;
    private string storeWeatherIconURL;
    private bool flagHasConditionsImage;
    private WeatherImageJSON  storeConditionsImage;
    private bool flagHasHumidityPct;
    private sbyte storeHumidityPct;
    private bool flagHasVisibility;
    private TypeVisibilityJSON  storeVisibility;
    private bool flagHasPrecipitation1Hour;
    private TypePrecipitation1HourJSON  storePrecipitation1Hour;
    private bool flagHasPrecipitationToday;
    private TypePrecipitationTodayJSON  storePrecipitationToday;
    private bool flagHasWind;
    private WindDataJSON  storeWind;
    private bool flagHasWindGust;
    private TypeWindGustJSON  storeWindGust;
    private bool flagHasBarometricPressure;
    private BarometricPressureDataJSON  storeBarometricPressure;
    private bool flagHasUVIndex;
    private UVIndexDataJSON  storeUVIndex;
    private bool flagHasCloudinessPct;
    private sbyte storeCloudinessPct;
    private bool flagHasAirQuality;
    private AirQualityDataJSON  storeAirQuality;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONObservationDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setObservationDateAndTime(convert_classy);
      }


    private void  fromJSONConditionsShortPhrase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CurrentConditionsShortPhraseJSON convert_classy = CurrentConditionsShortPhraseJSON.from_json(json_value, ignore_extras, true);
        setConditionsShortPhrase(convert_classy);
      }


    private void  fromJSONConditionsShortPhraseDisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhraseDisplay of CurrentConditionsJSON is not a string.");
        setConditionsShortPhraseDisplay(json_string.getData());
      }


    private void  fromJSONConditionsShortPhraseSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhraseSpoken of CurrentConditionsJSON is not a string.");
        setConditionsShortPhraseSpoken(json_string.getData());
      }


    private void  fromJSONConditionsShortPhraseWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhraseWritten of CurrentConditionsJSON is not a string.");
        setConditionsShortPhraseWritten(json_string.getData());
      }


    private void  fromJSONConditionsShortPhraseActionSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhraseActionSpoken of CurrentConditionsJSON is not a string.");
        setConditionsShortPhraseActionSpoken(json_string.getData());
      }


    private void  fromJSONConditionsShortPhraseActionWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhraseActionWritten of CurrentConditionsJSON is not a string.");
        setConditionsShortPhraseActionWritten(json_string.getData());
      }


    private void  fromJSONCurrentTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeCurrentTemperatureJSON convert_classy = TypeCurrentTemperatureJSON.from_json(json_value, ignore_extras, true);
        setCurrentTemperature(convert_classy);
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


    private void  fromJSONWeatherIconURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WeatherIconURL of CurrentConditionsJSON is not a string.");
        setWeatherIconURL(json_string.getData());
      }


    private void  fromJSONConditionsImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherImageJSON convert_classy = WeatherImageJSON.from_json(json_value, ignore_extras, true);
        setConditionsImage(convert_classy);
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
                throw new Exception("The value for field HumidityPct of CurrentConditionsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field HumidityPct of CurrentConditionsJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setHumidityPct(extracted_integer);
      }


    private void  fromJSONVisibility(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeVisibilityJSON convert_classy = TypeVisibilityJSON.from_json(json_value, ignore_extras, true);
        setVisibility(convert_classy);
      }


    private void  fromJSONPrecipitation1Hour(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePrecipitation1HourJSON convert_classy = TypePrecipitation1HourJSON.from_json(json_value, ignore_extras, true);
        setPrecipitation1Hour(convert_classy);
      }


    private void  fromJSONPrecipitationToday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePrecipitationTodayJSON convert_classy = TypePrecipitationTodayJSON.from_json(json_value, ignore_extras, true);
        setPrecipitationToday(convert_classy);
      }


    private void  fromJSONWind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WindDataJSON convert_classy = WindDataJSON.from_json(json_value, ignore_extras, true);
        setWind(convert_classy);
      }


    private void  fromJSONWindGust(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeWindGustJSON convert_classy = TypeWindGustJSON.from_json(json_value, ignore_extras, true);
        setWindGust(convert_classy);
      }


    private void  fromJSONBarometricPressure(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BarometricPressureDataJSON convert_classy = BarometricPressureDataJSON.from_json(json_value, ignore_extras, true);
        setBarometricPressure(convert_classy);
      }


    private void  fromJSONUVIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UVIndexDataJSON convert_classy = UVIndexDataJSON.from_json(json_value, ignore_extras, true);
        setUVIndex(convert_classy);
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
                throw new Exception("The value for field CloudinessPct of CurrentConditionsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CloudinessPct of CurrentConditionsJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setCloudinessPct(extracted_integer);
      }


    private void  fromJSONAirQuality(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AirQualityDataJSON convert_classy = AirQualityDataJSON.from_json(json_value, ignore_extras, true);
        setAirQuality(convert_classy);
      }


    public CurrentConditionsJSON()
      {
        flagHasLocation = false;
        flagHasObservationDateAndTime = false;
        flagHasConditionsShortPhrase = false;
        flagHasConditionsShortPhraseDisplay = false;
        flagHasConditionsShortPhraseSpoken = false;
        flagHasConditionsShortPhraseWritten = false;
        flagHasConditionsShortPhraseActionSpoken = false;
        flagHasConditionsShortPhraseActionWritten = false;
        flagHasCurrentTemperature = false;
        flagHasFeelsLikeTemperature = false;
        flagHasHeatIndex = false;
        flagHasWindchill = false;
        flagHasDewPoint = false;
        flagHasWeatherIconURL = false;
        flagHasConditionsImage = false;
        flagHasHumidityPct = false;
        flagHasVisibility = false;
        flagHasPrecipitation1Hour = false;
        flagHasPrecipitationToday = false;
        flagHasWind = false;
        flagHasWindGust = false;
        flagHasBarometricPressure = false;
        flagHasUVIndex = false;
        flagHasCloudinessPct = false;
        flagHasAirQuality = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasObservationDateAndTime()
      {
        return flagHasObservationDateAndTime;
      }

    public DateAndOrTimeJSON   getObservationDateAndTime()
      {
        Debug.Assert(flagHasObservationDateAndTime);
        return storeObservationDateAndTime;
      }

    public bool  hasConditionsShortPhrase()
      {
        return flagHasConditionsShortPhrase;
      }

    public CurrentConditionsShortPhraseJSON   getConditionsShortPhrase()
      {
        Debug.Assert(flagHasConditionsShortPhrase);
        return storeConditionsShortPhrase;
      }

    public CurrentConditionsShortPhraseJSON.TypeValue  getConditionsShortPhraseValue()
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

    public bool  hasConditionsShortPhraseActionSpoken()
      {
        return flagHasConditionsShortPhraseActionSpoken;
      }

    public string  getConditionsShortPhraseActionSpoken()
      {
        Debug.Assert(flagHasConditionsShortPhraseActionSpoken);
        return storeConditionsShortPhraseActionSpoken;
      }

    public bool  hasConditionsShortPhraseActionWritten()
      {
        return flagHasConditionsShortPhraseActionWritten;
      }

    public string  getConditionsShortPhraseActionWritten()
      {
        Debug.Assert(flagHasConditionsShortPhraseActionWritten);
        return storeConditionsShortPhraseActionWritten;
      }

    public bool  hasCurrentTemperature()
      {
        return flagHasCurrentTemperature;
      }

    public TypeCurrentTemperatureJSON   getCurrentTemperature()
      {
        Debug.Assert(flagHasCurrentTemperature);
        return storeCurrentTemperature;
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

    public bool  hasHumidityPct()
      {
        return flagHasHumidityPct;
      }

    public sbyte  getHumidityPct()
      {
        Debug.Assert(flagHasHumidityPct);
        return storeHumidityPct;
      }

    public bool  hasVisibility()
      {
        return flagHasVisibility;
      }

    public TypeVisibilityJSON   getVisibility()
      {
        Debug.Assert(flagHasVisibility);
        return storeVisibility;
      }

    public bool  hasPrecipitation1Hour()
      {
        return flagHasPrecipitation1Hour;
      }

    public TypePrecipitation1HourJSON   getPrecipitation1Hour()
      {
        Debug.Assert(flagHasPrecipitation1Hour);
        return storePrecipitation1Hour;
      }

    public bool  hasPrecipitationToday()
      {
        return flagHasPrecipitationToday;
      }

    public TypePrecipitationTodayJSON   getPrecipitationToday()
      {
        Debug.Assert(flagHasPrecipitationToday);
        return storePrecipitationToday;
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

    public bool  hasWindGust()
      {
        return flagHasWindGust;
      }

    public TypeWindGustJSON   getWindGust()
      {
        Debug.Assert(flagHasWindGust);
        return storeWindGust;
      }

    public bool  hasBarometricPressure()
      {
        return flagHasBarometricPressure;
      }

    public BarometricPressureDataJSON   getBarometricPressure()
      {
        Debug.Assert(flagHasBarometricPressure);
        return storeBarometricPressure;
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

    public bool  hasCloudinessPct()
      {
        return flagHasCloudinessPct;
      }

    public sbyte  getCloudinessPct()
      {
        Debug.Assert(flagHasCloudinessPct);
        return storeCloudinessPct;
      }

    public bool  hasAirQuality()
      {
        return flagHasAirQuality;
      }

    public AirQualityDataJSON   getAirQuality()
      {
        Debug.Assert(flagHasAirQuality);
        return storeAirQuality;
      }


    public virtual int extraCurrentConditionsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCurrentConditionsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCurrentConditionsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCurrentConditionsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setObservationDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasObservationDateAndTime)
          {
          }
        flagHasObservationDateAndTime = true;
        storeObservationDateAndTime = new_value;
      }
    public void unsetObservationDateAndTime()
      {
        if (flagHasObservationDateAndTime)
          {
          }
        flagHasObservationDateAndTime = false;
      }
    public void setConditionsShortPhrase(CurrentConditionsShortPhraseJSON  new_value)
      {
        if (flagHasConditionsShortPhrase)
          {
          }
        flagHasConditionsShortPhrase = true;
        storeConditionsShortPhrase = new_value;
      }
    public void setConditionsShortPhrase(CurrentConditionsShortPhraseJSON.TypeValue new_value)
      {
        setConditionsShortPhrase(new CurrentConditionsShortPhraseJSON(new_value));
      }
    public void setConditionsShortPhrase(string chars)
      {
        CurrentConditionsShortPhraseJSON.TypeValueKnownValues known = CurrentConditionsShortPhraseJSON.stringToValue(chars);
        CurrentConditionsShortPhraseJSON.TypeValue new_value = new CurrentConditionsShortPhraseJSON.TypeValue();
        if (known == CurrentConditionsShortPhraseJSON.TypeValueKnownValues.Value__none)
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
    public void setConditionsShortPhraseActionSpoken(string new_value)
      {
        flagHasConditionsShortPhraseActionSpoken = true;
        storeConditionsShortPhraseActionSpoken = new_value;
      }
    public void unsetConditionsShortPhraseActionSpoken()
      {
        flagHasConditionsShortPhraseActionSpoken = false;
      }
    public void setConditionsShortPhraseActionWritten(string new_value)
      {
        flagHasConditionsShortPhraseActionWritten = true;
        storeConditionsShortPhraseActionWritten = new_value;
      }
    public void unsetConditionsShortPhraseActionWritten()
      {
        flagHasConditionsShortPhraseActionWritten = false;
      }
    public void setCurrentTemperature(TypeCurrentTemperatureJSON  new_value)
      {
        if (flagHasCurrentTemperature)
          {
          }
        flagHasCurrentTemperature = true;
        storeCurrentTemperature = new_value;
      }
    public void unsetCurrentTemperature()
      {
        if (flagHasCurrentTemperature)
          {
          }
        flagHasCurrentTemperature = false;
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
    public void setHumidityPct(sbyte new_value)
      {
        flagHasHumidityPct = true;
        if (new_value < 0)
            throw new Exception("The value for field HumidityPct of CurrentConditionsJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field HumidityPct of CurrentConditionsJSON is greater than the upper bound (100) for that field.");
        storeHumidityPct = new_value;
      }
    public void unsetHumidityPct()
      {
        flagHasHumidityPct = false;
      }
    public void setVisibility(TypeVisibilityJSON  new_value)
      {
        if (flagHasVisibility)
          {
          }
        flagHasVisibility = true;
        storeVisibility = new_value;
      }
    public void unsetVisibility()
      {
        if (flagHasVisibility)
          {
          }
        flagHasVisibility = false;
      }
    public void setPrecipitation1Hour(TypePrecipitation1HourJSON  new_value)
      {
        if (flagHasPrecipitation1Hour)
          {
          }
        flagHasPrecipitation1Hour = true;
        storePrecipitation1Hour = new_value;
      }
    public void unsetPrecipitation1Hour()
      {
        if (flagHasPrecipitation1Hour)
          {
          }
        flagHasPrecipitation1Hour = false;
      }
    public void setPrecipitationToday(TypePrecipitationTodayJSON  new_value)
      {
        if (flagHasPrecipitationToday)
          {
          }
        flagHasPrecipitationToday = true;
        storePrecipitationToday = new_value;
      }
    public void unsetPrecipitationToday()
      {
        if (flagHasPrecipitationToday)
          {
          }
        flagHasPrecipitationToday = false;
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
    public void setWindGust(TypeWindGustJSON  new_value)
      {
        if (flagHasWindGust)
          {
          }
        flagHasWindGust = true;
        storeWindGust = new_value;
      }
    public void unsetWindGust()
      {
        if (flagHasWindGust)
          {
          }
        flagHasWindGust = false;
      }
    public void setBarometricPressure(BarometricPressureDataJSON  new_value)
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
    public void setCloudinessPct(sbyte new_value)
      {
        flagHasCloudinessPct = true;
        if (new_value < 0)
            throw new Exception("The value for field CloudinessPct of CurrentConditionsJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field CloudinessPct of CurrentConditionsJSON is greater than the upper bound (100) for that field.");
        storeCloudinessPct = new_value;
      }
    public void unsetCloudinessPct()
      {
        flagHasCloudinessPct = false;
      }
    public void setAirQuality(AirQualityDataJSON  new_value)
      {
        if (flagHasAirQuality)
          {
          }
        flagHasAirQuality = true;
        storeAirQuality = new_value;
      }
    public void unsetAirQuality()
      {
        if (flagHasAirQuality)
          {
          }
        flagHasAirQuality = false;
      }

    public virtual void extraCurrentConditionsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCurrentConditionsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCurrentConditionsLookup(key);
        if (old_field == null)
          {
            extraCurrentConditionsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLocation);
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasObservationDateAndTime);
        if (flagHasObservationDateAndTime)
          {
            handler.start_pair("ObservationDateAndTime");
            if (partial_allowed)
                storeObservationDateAndTime.write_partial_as_json(handler);
            else
                storeObservationDateAndTime.write_as_json(handler);
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
        if (flagHasConditionsShortPhraseActionSpoken)
          {
            handler.start_pair("ConditionsShortPhraseActionSpoken");
            handler.string_value(storeConditionsShortPhraseActionSpoken);
          }
        if (flagHasConditionsShortPhraseActionWritten)
          {
            handler.start_pair("ConditionsShortPhraseActionWritten");
            handler.string_value(storeConditionsShortPhraseActionWritten);
          }
        if (flagHasCurrentTemperature)
          {
            handler.start_pair("CurrentTemperature");
            if (partial_allowed)
                storeCurrentTemperature.write_partial_as_json(handler);
            else
                storeCurrentTemperature.write_as_json(handler);
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
        if (flagHasHumidityPct)
          {
            handler.start_pair("HumidityPct");
            handler.number_value(storeHumidityPct);
          }
        if (flagHasVisibility)
          {
            handler.start_pair("Visibility");
            if (partial_allowed)
                storeVisibility.write_partial_as_json(handler);
            else
                storeVisibility.write_as_json(handler);
          }
        if (flagHasPrecipitation1Hour)
          {
            handler.start_pair("Precipitation1Hour");
            if (partial_allowed)
                storePrecipitation1Hour.write_partial_as_json(handler);
            else
                storePrecipitation1Hour.write_as_json(handler);
          }
        if (flagHasPrecipitationToday)
          {
            handler.start_pair("PrecipitationToday");
            if (partial_allowed)
                storePrecipitationToday.write_partial_as_json(handler);
            else
                storePrecipitationToday.write_as_json(handler);
          }
        if (flagHasWind)
          {
            handler.start_pair("Wind");
            if (partial_allowed)
                storeWind.write_partial_as_json(handler);
            else
                storeWind.write_as_json(handler);
          }
        if (flagHasWindGust)
          {
            handler.start_pair("WindGust");
            if (partial_allowed)
                storeWindGust.write_partial_as_json(handler);
            else
                storeWindGust.write_as_json(handler);
          }
        if (flagHasBarometricPressure)
          {
            handler.start_pair("BarometricPressure");
            if (partial_allowed)
                storeBarometricPressure.write_partial_as_json(handler);
            else
                storeBarometricPressure.write_as_json(handler);
          }
        if (flagHasUVIndex)
          {
            handler.start_pair("UVIndex");
            if (partial_allowed)
                storeUVIndex.write_partial_as_json(handler);
            else
                storeUVIndex.write_as_json(handler);
          }
        if (flagHasCloudinessPct)
          {
            handler.start_pair("CloudinessPct");
            handler.number_value(storeCloudinessPct);
          }
        if (flagHasAirQuality)
          {
            handler.start_pair("AirQuality");
            if (partial_allowed)
                storeAirQuality.write_partial_as_json(handler);
            else
                storeAirQuality.write_as_json(handler);
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
        if (!(hasLocation()))
          {
            return "When parsing the object for %what%, the \"Location\" field was missing.";
          }
        if (!(hasObservationDateAndTime()))
          {
            return "When parsing the object for %what%, the \"ObservationDateAndTime\" field was missing.";
          }
        return null;
      }

    public static CurrentConditionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CurrentConditionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrentConditions", ignore_extras);
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
    public static CurrentConditionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CurrentConditionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CurrentConditionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrentConditions", ignore_extras);
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
    public static CurrentConditionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CurrentConditionsJSON from_text(string text, bool ignore_extras)
      {
        CurrentConditionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrentConditions", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CurrentConditionsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CurrentConditionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CurrentConditionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CurrentConditions", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorObservationDateAndTime;
        private CurrentConditionsShortPhraseJSON.HoldingGenerator fieldGeneratorConditionsShortPhrase;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseDisplay;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseSpoken;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseWritten;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseActionSpoken;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseActionWritten;
        private TypeCurrentTemperatureJSON.HoldingGenerator fieldGeneratorCurrentTemperature;
        private TypeFeelsLikeTemperatureJSON.HoldingGenerator fieldGeneratorFeelsLikeTemperature;
        private TypeHeatIndexJSON.HoldingGenerator fieldGeneratorHeatIndex;
        private TypeWindchillJSON.HoldingGenerator fieldGeneratorWindchill;
        private TypeDewPointJSON.HoldingGenerator fieldGeneratorDewPoint;
        private JSONHoldingStringGenerator fieldGeneratorWeatherIconURL;
        private WeatherImageJSON.HoldingGenerator fieldGeneratorConditionsImage;
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
        private TypeVisibilityJSON.HoldingGenerator fieldGeneratorVisibility;
        private TypePrecipitation1HourJSON.HoldingGenerator fieldGeneratorPrecipitation1Hour;
        private TypePrecipitationTodayJSON.HoldingGenerator fieldGeneratorPrecipitationToday;
        private WindDataJSON.HoldingGenerator fieldGeneratorWind;
        private TypeWindGustJSON.HoldingGenerator fieldGeneratorWindGust;
        private BarometricPressureDataJSON.HoldingGenerator fieldGeneratorBarometricPressure;
        private UVIndexDataJSON.HoldingGenerator fieldGeneratorUVIndex;
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
        private AirQualityDataJSON.HoldingGenerator fieldGeneratorAirQuality;
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
            CurrentConditionsJSON result = new CurrentConditionsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCurrentConditionsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CurrentConditionsJSON result)
          {
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            else if ((!(result.hasLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Location\" field was missing.");
              }
            if (fieldGeneratorObservationDateAndTime.have_value)
              {
                result.setObservationDateAndTime(fieldGeneratorObservationDateAndTime.value);
                fieldGeneratorObservationDateAndTime.have_value = false;
              }
            else if ((!(result.hasObservationDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ObservationDateAndTime\" field was missing.");
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
            if (fieldGeneratorConditionsShortPhraseActionSpoken.have_value)
              {
                result.setConditionsShortPhraseActionSpoken(fieldGeneratorConditionsShortPhraseActionSpoken.value);
                fieldGeneratorConditionsShortPhraseActionSpoken.have_value = false;
              }
            if (fieldGeneratorConditionsShortPhraseActionWritten.have_value)
              {
                result.setConditionsShortPhraseActionWritten(fieldGeneratorConditionsShortPhraseActionWritten.value);
                fieldGeneratorConditionsShortPhraseActionWritten.have_value = false;
              }
            if (fieldGeneratorCurrentTemperature.have_value)
              {
                result.setCurrentTemperature(fieldGeneratorCurrentTemperature.value);
                fieldGeneratorCurrentTemperature.have_value = false;
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
            if (fieldGeneratorHumidityPct.have_value)
              {
                result.setHumidityPct((sbyte)(fieldGeneratorHumidityPct.value));
                fieldGeneratorHumidityPct.have_value = false;
              }
            if (fieldGeneratorVisibility.have_value)
              {
                result.setVisibility(fieldGeneratorVisibility.value);
                fieldGeneratorVisibility.have_value = false;
              }
            if (fieldGeneratorPrecipitation1Hour.have_value)
              {
                result.setPrecipitation1Hour(fieldGeneratorPrecipitation1Hour.value);
                fieldGeneratorPrecipitation1Hour.have_value = false;
              }
            if (fieldGeneratorPrecipitationToday.have_value)
              {
                result.setPrecipitationToday(fieldGeneratorPrecipitationToday.value);
                fieldGeneratorPrecipitationToday.have_value = false;
              }
            if (fieldGeneratorWind.have_value)
              {
                result.setWind(fieldGeneratorWind.value);
                fieldGeneratorWind.have_value = false;
              }
            if (fieldGeneratorWindGust.have_value)
              {
                result.setWindGust(fieldGeneratorWindGust.value);
                fieldGeneratorWindGust.have_value = false;
              }
            if (fieldGeneratorBarometricPressure.have_value)
              {
                result.setBarometricPressure(fieldGeneratorBarometricPressure.value);
                fieldGeneratorBarometricPressure.have_value = false;
              }
            if (fieldGeneratorUVIndex.have_value)
              {
                result.setUVIndex(fieldGeneratorUVIndex.value);
                fieldGeneratorUVIndex.have_value = false;
              }
            if (fieldGeneratorCloudinessPct.have_value)
              {
                result.setCloudinessPct((sbyte)(fieldGeneratorCloudinessPct.value));
                fieldGeneratorCloudinessPct.have_value = false;
              }
            if (fieldGeneratorAirQuality.have_value)
              {
                result.setAirQuality(fieldGeneratorAirQuality.value);
                fieldGeneratorAirQuality.have_value = false;
              }
          }
        protected abstract void handle_result(CurrentConditionsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "irQuality", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorAirQuality;
                    break;
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
                                                case 'A':
                                                    if (String.Compare(field_name, 22, "ction", 0, 5, false) == 0)
                                                      {
                                                        switch (field_name[27])
                                                          {
                                                            case 'S':
                                                                if ((String.Compare(field_name, 28, "poken", 0, 5, false) == 0) && (field_name.Length == 33))
                                                                    return fieldGeneratorConditionsShortPhraseActionSpoken;
                                                                break;
                                                            case 'W':
                                                                if ((String.Compare(field_name, 28, "ritten", 0, 6, false) == 0) && (field_name.Length == 34))
                                                                    return fieldGeneratorConditionsShortPhraseActionWritten;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
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
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrentTemperature", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorCurrentTemperature;
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
                    if ((String.Compare(field_name, 1, "eelsLikeTemperature", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorFeelsLikeTemperature;
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
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "bservationDateAndTime", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorObservationDateAndTime;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "recipitation", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case '1':
                                if ((String.Compare(field_name, 14, "Hour", 0, 4, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorPrecipitation1Hour;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 14, "oday", 0, 4, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorPrecipitationToday;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "VIndex", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorUVIndex;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "isibility", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorVisibility;
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
                                    case 'G':
                                        if ((String.Compare(field_name, 5, "ust", 0, 3, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorWindGust;
                                        break;
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
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorObservationDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ObservationDateAndTime\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorConditionsShortPhrase = new CurrentConditionsShortPhraseJSON.HoldingGenerator("field \"ConditionsShortPhrase\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorConditionsShortPhraseDisplay = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseDisplay\" of the CurrentConditions class");
            fieldGeneratorConditionsShortPhraseSpoken = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseSpoken\" of the CurrentConditions class");
            fieldGeneratorConditionsShortPhraseWritten = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseWritten\" of the CurrentConditions class");
            fieldGeneratorConditionsShortPhraseActionSpoken = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseActionSpoken\" of the CurrentConditions class");
            fieldGeneratorConditionsShortPhraseActionWritten = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseActionWritten\" of the CurrentConditions class");
            fieldGeneratorCurrentTemperature = new TypeCurrentTemperatureJSON.HoldingGenerator("field \"CurrentTemperature\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorFeelsLikeTemperature = new TypeFeelsLikeTemperatureJSON.HoldingGenerator("field \"FeelsLikeTemperature\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorHeatIndex = new TypeHeatIndexJSON.HoldingGenerator("field \"HeatIndex\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorWindchill = new TypeWindchillJSON.HoldingGenerator("field \"Windchill\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorDewPoint = new TypeDewPointJSON.HoldingGenerator("field \"DewPoint\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorWeatherIconURL = new JSONHoldingStringGenerator("field \"WeatherIconURL\" of the CurrentConditions class");
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorHumidityPct = new FieldHoldingGeneratorHumidityPct("field \"HumidityPct\" of the CurrentConditions class");
            fieldGeneratorVisibility = new TypeVisibilityJSON.HoldingGenerator("field \"Visibility\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorPrecipitation1Hour = new TypePrecipitation1HourJSON.HoldingGenerator("field \"Precipitation1Hour\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorPrecipitationToday = new TypePrecipitationTodayJSON.HoldingGenerator("field \"PrecipitationToday\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorWind = new WindDataJSON.HoldingGenerator("field \"Wind\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorWindGust = new TypeWindGustJSON.HoldingGenerator("field \"WindGust\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorBarometricPressure = new BarometricPressureDataJSON.HoldingGenerator("field \"BarometricPressure\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorUVIndex = new UVIndexDataJSON.HoldingGenerator("field \"UVIndex\" of the CurrentConditions class", ignore_extras);
            fieldGeneratorCloudinessPct = new FieldHoldingGeneratorCloudinessPct("field \"CloudinessPct\" of the CurrentConditions class");
            fieldGeneratorAirQuality = new AirQualityDataJSON.HoldingGenerator("field \"AirQuality\" of the CurrentConditions class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CurrentConditions class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the CurrentConditions class", false);
            fieldGeneratorObservationDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ObservationDateAndTime\" of the CurrentConditions class", false);
            fieldGeneratorConditionsShortPhrase = new CurrentConditionsShortPhraseJSON.HoldingGenerator("field \"ConditionsShortPhrase\" of the CurrentConditions class", false);
            fieldGeneratorConditionsShortPhraseDisplay = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseDisplay\" of the CurrentConditions class");
            fieldGeneratorConditionsShortPhraseSpoken = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseSpoken\" of the CurrentConditions class");
            fieldGeneratorConditionsShortPhraseWritten = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseWritten\" of the CurrentConditions class");
            fieldGeneratorConditionsShortPhraseActionSpoken = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseActionSpoken\" of the CurrentConditions class");
            fieldGeneratorConditionsShortPhraseActionWritten = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseActionWritten\" of the CurrentConditions class");
            fieldGeneratorCurrentTemperature = new TypeCurrentTemperatureJSON.HoldingGenerator("field \"CurrentTemperature\" of the CurrentConditions class", false);
            fieldGeneratorFeelsLikeTemperature = new TypeFeelsLikeTemperatureJSON.HoldingGenerator("field \"FeelsLikeTemperature\" of the CurrentConditions class", false);
            fieldGeneratorHeatIndex = new TypeHeatIndexJSON.HoldingGenerator("field \"HeatIndex\" of the CurrentConditions class", false);
            fieldGeneratorWindchill = new TypeWindchillJSON.HoldingGenerator("field \"Windchill\" of the CurrentConditions class", false);
            fieldGeneratorDewPoint = new TypeDewPointJSON.HoldingGenerator("field \"DewPoint\" of the CurrentConditions class", false);
            fieldGeneratorWeatherIconURL = new JSONHoldingStringGenerator("field \"WeatherIconURL\" of the CurrentConditions class");
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the CurrentConditions class", false);
            fieldGeneratorHumidityPct = new FieldHoldingGeneratorHumidityPct("field \"HumidityPct\" of the CurrentConditions class");
            fieldGeneratorVisibility = new TypeVisibilityJSON.HoldingGenerator("field \"Visibility\" of the CurrentConditions class", false);
            fieldGeneratorPrecipitation1Hour = new TypePrecipitation1HourJSON.HoldingGenerator("field \"Precipitation1Hour\" of the CurrentConditions class", false);
            fieldGeneratorPrecipitationToday = new TypePrecipitationTodayJSON.HoldingGenerator("field \"PrecipitationToday\" of the CurrentConditions class", false);
            fieldGeneratorWind = new WindDataJSON.HoldingGenerator("field \"Wind\" of the CurrentConditions class", false);
            fieldGeneratorWindGust = new TypeWindGustJSON.HoldingGenerator("field \"WindGust\" of the CurrentConditions class", false);
            fieldGeneratorBarometricPressure = new BarometricPressureDataJSON.HoldingGenerator("field \"BarometricPressure\" of the CurrentConditions class", false);
            fieldGeneratorUVIndex = new UVIndexDataJSON.HoldingGenerator("field \"UVIndex\" of the CurrentConditions class", false);
            fieldGeneratorCloudinessPct = new FieldHoldingGeneratorCloudinessPct("field \"CloudinessPct\" of the CurrentConditions class");
            fieldGeneratorAirQuality = new AirQualityDataJSON.HoldingGenerator("field \"AirQuality\" of the CurrentConditions class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CurrentConditions class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLocation.reset();
            fieldGeneratorObservationDateAndTime.reset();
            fieldGeneratorConditionsShortPhrase.reset();
            fieldGeneratorConditionsShortPhraseDisplay.reset();
            fieldGeneratorConditionsShortPhraseSpoken.reset();
            fieldGeneratorConditionsShortPhraseWritten.reset();
            fieldGeneratorConditionsShortPhraseActionSpoken.reset();
            fieldGeneratorConditionsShortPhraseActionWritten.reset();
            fieldGeneratorCurrentTemperature.reset();
            fieldGeneratorFeelsLikeTemperature.reset();
            fieldGeneratorHeatIndex.reset();
            fieldGeneratorWindchill.reset();
            fieldGeneratorDewPoint.reset();
            fieldGeneratorWeatherIconURL.reset();
            fieldGeneratorConditionsImage.reset();
            fieldGeneratorHumidityPct.reset();
            fieldGeneratorVisibility.reset();
            fieldGeneratorPrecipitation1Hour.reset();
            fieldGeneratorPrecipitationToday.reset();
            fieldGeneratorWind.reset();
            fieldGeneratorWindGust.reset();
            fieldGeneratorBarometricPressure.reset();
            fieldGeneratorUVIndex.reset();
            fieldGeneratorCloudinessPct.reset();
            fieldGeneratorAirQuality.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorObservationDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConditionsShortPhrase.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCurrentTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFeelsLikeTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHeatIndex.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWindchill.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDewPoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConditionsImage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorVisibility.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrecipitation1Hour.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrecipitationToday.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWind.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWindGust.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBarometricPressure.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUVIndex.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAirQuality.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorObservationDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConditionsShortPhrase.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCurrentTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFeelsLikeTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHeatIndex.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWindchill.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDewPoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConditionsImage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorVisibility.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrecipitation1Hour.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrecipitationToday.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWind.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWindGust.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBarometricPressure.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUVIndex.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAirQuality.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CurrentConditionsJSON  result)
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
        public CurrentConditionsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CurrentConditionsJSON  result)
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
    protected virtual void handle_result(List<CurrentConditionsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CurrentConditionsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CurrentConditionsJSON>();
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
    public List<CurrentConditionsJSON> value;
  };
  };
