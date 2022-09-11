/* file "HistoryObservationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HistoryObservationJSON : JSONBase
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
    private bool flagHasObservationDateAndTime;
    private DateAndOrTimeJSON  storeObservationDateAndTime;
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
    private bool flagHasDewPoint;
    private TypeDewPointJSON  storeDewPoint;
    private bool flagHasHumidityPct;
    private sbyte storeHumidityPct;
    private bool flagHasWind;
    private WindDataJSON  storeWind;
    private bool flagHasWindGust;
    private TypeWindGustJSON  storeWindGust;
    private bool flagHasVisibility;
    private TypeVisibilityJSON  storeVisibility;
    private bool flagHasBarometricPressure;
    private BarometricPressureDataJSON  storeBarometricPressure;
    private bool flagHasHeatIndex;
    private TypeHeatIndexJSON  storeHeatIndex;
    private bool flagHasWindchill;
    private TypeWindchillJSON  storeWindchill;
    private bool flagHasPrecipitation;
    private TypePrecipitationJSON  storePrecipitation;
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


    private void  fromJSONObservationDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setObservationDateAndTime(convert_classy);
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
            throw new Exception("The value for field ConditionsShortPhraseDisplay of HistoryObservationJSON is not a string.");
        setConditionsShortPhraseDisplay(json_string.getData());
      }


    private void  fromJSONConditionsShortPhraseSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhraseSpoken of HistoryObservationJSON is not a string.");
        setConditionsShortPhraseSpoken(json_string.getData());
      }


    private void  fromJSONConditionsShortPhraseWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhraseWritten of HistoryObservationJSON is not a string.");
        setConditionsShortPhraseWritten(json_string.getData());
      }


    private void  fromJSONWeatherIconURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WeatherIconURL of HistoryObservationJSON is not a string.");
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


    private void  fromJSONDewPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDewPointJSON convert_classy = TypeDewPointJSON.from_json(json_value, ignore_extras, true);
        setDewPoint(convert_classy);
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
                throw new Exception("The value for field HumidityPct of HistoryObservationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field HumidityPct of HistoryObservationJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setHumidityPct(extracted_integer);
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


    private void  fromJSONVisibility(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeVisibilityJSON convert_classy = TypeVisibilityJSON.from_json(json_value, ignore_extras, true);
        setVisibility(convert_classy);
      }


    private void  fromJSONBarometricPressure(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BarometricPressureDataJSON convert_classy = BarometricPressureDataJSON.from_json(json_value, ignore_extras, true);
        setBarometricPressure(convert_classy);
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


    private void  fromJSONPrecipitation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePrecipitationJSON convert_classy = TypePrecipitationJSON.from_json(json_value, ignore_extras, true);
        setPrecipitation(convert_classy);
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
                throw new Exception("The value for field Fog of HistoryObservationJSON is not true for false.");
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
                throw new Exception("The value for field Rain of HistoryObservationJSON is not true for false.");
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
                throw new Exception("The value for field Snow of HistoryObservationJSON is not true for false.");
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
                throw new Exception("The value for field Hail of HistoryObservationJSON is not true for false.");
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
                throw new Exception("The value for field Thunder of HistoryObservationJSON is not true for false.");
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
                throw new Exception("The value for field Tornado of HistoryObservationJSON is not true for false.");
              }
          }
        setTornado(the_bool);
      }


    public HistoryObservationJSON()
      {
        flagHasObservationDateAndTime = false;
        flagHasConditionsShortPhrase = false;
        flagHasConditionsShortPhraseDisplay = false;
        flagHasConditionsShortPhraseSpoken = false;
        flagHasConditionsShortPhraseWritten = false;
        flagHasWeatherIconURL = false;
        flagHasConditionsImage = false;
        flagHasTemperature = false;
        flagHasDewPoint = false;
        flagHasHumidityPct = false;
        flagHasWind = false;
        flagHasWindGust = false;
        flagHasVisibility = false;
        flagHasBarometricPressure = false;
        flagHasHeatIndex = false;
        flagHasWindchill = false;
        flagHasPrecipitation = false;
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

    public bool  hasDewPoint()
      {
        return flagHasDewPoint;
      }

    public TypeDewPointJSON   getDewPoint()
      {
        Debug.Assert(flagHasDewPoint);
        return storeDewPoint;
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

    public bool  hasVisibility()
      {
        return flagHasVisibility;
      }

    public TypeVisibilityJSON   getVisibility()
      {
        Debug.Assert(flagHasVisibility);
        return storeVisibility;
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

    public bool  hasPrecipitation()
      {
        return flagHasPrecipitation;
      }

    public TypePrecipitationJSON   getPrecipitation()
      {
        Debug.Assert(flagHasPrecipitation);
        return storePrecipitation;
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


    public virtual int extraHistoryObservationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHistoryObservationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHistoryObservationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHistoryObservationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setHumidityPct(sbyte new_value)
      {
        flagHasHumidityPct = true;
        if (new_value < 0)
            throw new Exception("The value for field HumidityPct of HistoryObservationJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field HumidityPct of HistoryObservationJSON is greater than the upper bound (100) for that field.");
        storeHumidityPct = new_value;
      }
    public void unsetHumidityPct()
      {
        flagHasHumidityPct = false;
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

    public virtual void extraHistoryObservationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHistoryObservationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHistoryObservationLookup(key);
        if (old_field == null)
          {
            extraHistoryObservationAppendPair(key, new_component);
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
        if (flagHasDewPoint)
          {
            handler.start_pair("DewPoint");
            if (partial_allowed)
                storeDewPoint.write_partial_as_json(handler);
            else
                storeDewPoint.write_as_json(handler);
          }
        if (flagHasHumidityPct)
          {
            handler.start_pair("HumidityPct");
            handler.number_value(storeHumidityPct);
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
        if (flagHasVisibility)
          {
            handler.start_pair("Visibility");
            if (partial_allowed)
                storeVisibility.write_partial_as_json(handler);
            else
                storeVisibility.write_as_json(handler);
          }
        if (flagHasBarometricPressure)
          {
            handler.start_pair("BarometricPressure");
            if (partial_allowed)
                storeBarometricPressure.write_partial_as_json(handler);
            else
                storeBarometricPressure.write_as_json(handler);
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
        if (flagHasPrecipitation)
          {
            handler.start_pair("Precipitation");
            if (partial_allowed)
                storePrecipitation.write_partial_as_json(handler);
            else
                storePrecipitation.write_as_json(handler);
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
        if (!(hasObservationDateAndTime()))
          {
            return "When parsing the object for %what%, the \"ObservationDateAndTime\" field was missing.";
          }
        return null;
      }

    public static HistoryObservationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HistoryObservationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HistoryObservation", ignore_extras);
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
    public static HistoryObservationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HistoryObservationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HistoryObservationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HistoryObservation", ignore_extras);
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
    public static HistoryObservationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HistoryObservationJSON from_text(string text, bool ignore_extras)
      {
        HistoryObservationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HistoryObservation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HistoryObservationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HistoryObservationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HistoryObservationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HistoryObservation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorObservationDateAndTime;
        private ForecastShortPhraseJSON.HoldingGenerator fieldGeneratorConditionsShortPhrase;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseDisplay;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseSpoken;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhraseWritten;
        private JSONHoldingStringGenerator fieldGeneratorWeatherIconURL;
        private WeatherImageJSON.HoldingGenerator fieldGeneratorConditionsImage;
        private TypeTemperatureJSON.HoldingGenerator fieldGeneratorTemperature;
        private TypeDewPointJSON.HoldingGenerator fieldGeneratorDewPoint;
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
        private WindDataJSON.HoldingGenerator fieldGeneratorWind;
        private TypeWindGustJSON.HoldingGenerator fieldGeneratorWindGust;
        private TypeVisibilityJSON.HoldingGenerator fieldGeneratorVisibility;
        private BarometricPressureDataJSON.HoldingGenerator fieldGeneratorBarometricPressure;
        private TypeHeatIndexJSON.HoldingGenerator fieldGeneratorHeatIndex;
        private TypeWindchillJSON.HoldingGenerator fieldGeneratorWindchill;
        private TypePrecipitationJSON.HoldingGenerator fieldGeneratorPrecipitation;
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
            HistoryObservationJSON result = new HistoryObservationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHistoryObservationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HistoryObservationJSON result)
          {
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
            if (fieldGeneratorDewPoint.have_value)
              {
                result.setDewPoint(fieldGeneratorDewPoint.value);
                fieldGeneratorDewPoint.have_value = false;
              }
            if (fieldGeneratorHumidityPct.have_value)
              {
                result.setHumidityPct((sbyte)(fieldGeneratorHumidityPct.value));
                fieldGeneratorHumidityPct.have_value = false;
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
            if (fieldGeneratorVisibility.have_value)
              {
                result.setVisibility(fieldGeneratorVisibility.value);
                fieldGeneratorVisibility.have_value = false;
              }
            if (fieldGeneratorBarometricPressure.have_value)
              {
                result.setBarometricPressure(fieldGeneratorBarometricPressure.value);
                fieldGeneratorBarometricPressure.have_value = false;
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
            if (fieldGeneratorPrecipitation.have_value)
              {
                result.setPrecipitation(fieldGeneratorPrecipitation.value);
                fieldGeneratorPrecipitation.have_value = false;
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
        protected abstract void handle_result(HistoryObservationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "arometricPressure", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorBarometricPressure;
                    break;
                case 'C':
                    if (String.Compare(field_name, 1, "onditions", 0, 9, false) == 0)
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
                case 'D':
                    if ((String.Compare(field_name, 1, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorDewPoint;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "og", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorFog;
                    break;
                case 'H':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "il", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorHail;
                            break;
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
                case 'O':
                    if ((String.Compare(field_name, 1, "bservationDateAndTime", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorObservationDateAndTime;
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
                    if ((String.Compare(field_name, 1, "now", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorSnow;
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "mperature", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorTemperature;
                            break;
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
            fieldGeneratorObservationDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ObservationDateAndTime\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorConditionsShortPhrase = new ForecastShortPhraseJSON.HoldingGenerator("field \"ConditionsShortPhrase\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorConditionsShortPhraseDisplay = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseDisplay\" of the HistoryObservation class");
            fieldGeneratorConditionsShortPhraseSpoken = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseSpoken\" of the HistoryObservation class");
            fieldGeneratorConditionsShortPhraseWritten = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseWritten\" of the HistoryObservation class");
            fieldGeneratorWeatherIconURL = new JSONHoldingStringGenerator("field \"WeatherIconURL\" of the HistoryObservation class");
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorTemperature = new TypeTemperatureJSON.HoldingGenerator("field \"Temperature\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorDewPoint = new TypeDewPointJSON.HoldingGenerator("field \"DewPoint\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorHumidityPct = new FieldHoldingGeneratorHumidityPct("field \"HumidityPct\" of the HistoryObservation class");
            fieldGeneratorWind = new WindDataJSON.HoldingGenerator("field \"Wind\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorWindGust = new TypeWindGustJSON.HoldingGenerator("field \"WindGust\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorVisibility = new TypeVisibilityJSON.HoldingGenerator("field \"Visibility\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorBarometricPressure = new BarometricPressureDataJSON.HoldingGenerator("field \"BarometricPressure\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorHeatIndex = new TypeHeatIndexJSON.HoldingGenerator("field \"HeatIndex\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorWindchill = new TypeWindchillJSON.HoldingGenerator("field \"Windchill\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorPrecipitation = new TypePrecipitationJSON.HoldingGenerator("field \"Precipitation\" of the HistoryObservation class", ignore_extras);
            fieldGeneratorFog = new JSONHoldingBooleanGenerator("field \"Fog\" of the HistoryObservation class");
            fieldGeneratorRain = new JSONHoldingBooleanGenerator("field \"Rain\" of the HistoryObservation class");
            fieldGeneratorSnow = new JSONHoldingBooleanGenerator("field \"Snow\" of the HistoryObservation class");
            fieldGeneratorHail = new JSONHoldingBooleanGenerator("field \"Hail\" of the HistoryObservation class");
            fieldGeneratorThunder = new JSONHoldingBooleanGenerator("field \"Thunder\" of the HistoryObservation class");
            fieldGeneratorTornado = new JSONHoldingBooleanGenerator("field \"Tornado\" of the HistoryObservation class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HistoryObservation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorObservationDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ObservationDateAndTime\" of the HistoryObservation class", false);
            fieldGeneratorConditionsShortPhrase = new ForecastShortPhraseJSON.HoldingGenerator("field \"ConditionsShortPhrase\" of the HistoryObservation class", false);
            fieldGeneratorConditionsShortPhraseDisplay = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseDisplay\" of the HistoryObservation class");
            fieldGeneratorConditionsShortPhraseSpoken = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseSpoken\" of the HistoryObservation class");
            fieldGeneratorConditionsShortPhraseWritten = new JSONHoldingStringGenerator("field \"ConditionsShortPhraseWritten\" of the HistoryObservation class");
            fieldGeneratorWeatherIconURL = new JSONHoldingStringGenerator("field \"WeatherIconURL\" of the HistoryObservation class");
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the HistoryObservation class", false);
            fieldGeneratorTemperature = new TypeTemperatureJSON.HoldingGenerator("field \"Temperature\" of the HistoryObservation class", false);
            fieldGeneratorDewPoint = new TypeDewPointJSON.HoldingGenerator("field \"DewPoint\" of the HistoryObservation class", false);
            fieldGeneratorHumidityPct = new FieldHoldingGeneratorHumidityPct("field \"HumidityPct\" of the HistoryObservation class");
            fieldGeneratorWind = new WindDataJSON.HoldingGenerator("field \"Wind\" of the HistoryObservation class", false);
            fieldGeneratorWindGust = new TypeWindGustJSON.HoldingGenerator("field \"WindGust\" of the HistoryObservation class", false);
            fieldGeneratorVisibility = new TypeVisibilityJSON.HoldingGenerator("field \"Visibility\" of the HistoryObservation class", false);
            fieldGeneratorBarometricPressure = new BarometricPressureDataJSON.HoldingGenerator("field \"BarometricPressure\" of the HistoryObservation class", false);
            fieldGeneratorHeatIndex = new TypeHeatIndexJSON.HoldingGenerator("field \"HeatIndex\" of the HistoryObservation class", false);
            fieldGeneratorWindchill = new TypeWindchillJSON.HoldingGenerator("field \"Windchill\" of the HistoryObservation class", false);
            fieldGeneratorPrecipitation = new TypePrecipitationJSON.HoldingGenerator("field \"Precipitation\" of the HistoryObservation class", false);
            fieldGeneratorFog = new JSONHoldingBooleanGenerator("field \"Fog\" of the HistoryObservation class");
            fieldGeneratorRain = new JSONHoldingBooleanGenerator("field \"Rain\" of the HistoryObservation class");
            fieldGeneratorSnow = new JSONHoldingBooleanGenerator("field \"Snow\" of the HistoryObservation class");
            fieldGeneratorHail = new JSONHoldingBooleanGenerator("field \"Hail\" of the HistoryObservation class");
            fieldGeneratorThunder = new JSONHoldingBooleanGenerator("field \"Thunder\" of the HistoryObservation class");
            fieldGeneratorTornado = new JSONHoldingBooleanGenerator("field \"Tornado\" of the HistoryObservation class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HistoryObservation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorObservationDateAndTime.reset();
            fieldGeneratorConditionsShortPhrase.reset();
            fieldGeneratorConditionsShortPhraseDisplay.reset();
            fieldGeneratorConditionsShortPhraseSpoken.reset();
            fieldGeneratorConditionsShortPhraseWritten.reset();
            fieldGeneratorWeatherIconURL.reset();
            fieldGeneratorConditionsImage.reset();
            fieldGeneratorTemperature.reset();
            fieldGeneratorDewPoint.reset();
            fieldGeneratorHumidityPct.reset();
            fieldGeneratorWind.reset();
            fieldGeneratorWindGust.reset();
            fieldGeneratorVisibility.reset();
            fieldGeneratorBarometricPressure.reset();
            fieldGeneratorHeatIndex.reset();
            fieldGeneratorWindchill.reset();
            fieldGeneratorPrecipitation.reset();
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
            fieldGeneratorObservationDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConditionsShortPhrase.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConditionsImage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDewPoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWind.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWindGust.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorVisibility.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBarometricPressure.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHeatIndex.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWindchill.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrecipitation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorObservationDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConditionsShortPhrase.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConditionsImage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDewPoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWind.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWindGust.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorVisibility.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBarometricPressure.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHeatIndex.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWindchill.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrecipitation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HistoryObservationJSON  result)
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
        public HistoryObservationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HistoryObservationJSON  result)
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
    protected virtual void handle_result(List<HistoryObservationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HistoryObservationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HistoryObservationJSON>();
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
    public List<HistoryObservationJSON> value;
  };
  };
