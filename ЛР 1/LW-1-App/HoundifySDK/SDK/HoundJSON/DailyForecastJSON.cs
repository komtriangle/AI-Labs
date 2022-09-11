/* file "DailyForecastJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DailyForecastJSON : JSONBase
  {
    public class TypeHighTemperatureJSON : JSONBase
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


        public TypeHighTemperatureJSON()
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


        public virtual int extraTypeHighTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeHighTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeHighTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeHighTemperatureLookup(string field_name)
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

        public virtual void extraTypeHighTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeHighTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeHighTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeHighTemperatureAppendPair(key, new_component);
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

        public static TypeHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHighTemperature", ignore_extras);
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
        public static TypeHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHighTemperature", ignore_extras);
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
        public static TypeHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHighTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHighTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeHighTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeHighTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHighTemperature", ignore_extras);
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
                TypeHighTemperatureJSON result = new TypeHighTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeHighTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeHighTemperatureJSON result)
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
            protected abstract void handle_result(TypeHighTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeHighTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeHighTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeHighTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeHighTemperature class");
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
            protected override void handle_result(TypeHighTemperatureJSON  result)
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
            public TypeHighTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeHighTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeHighTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeHighTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeHighTemperatureJSON>();
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
        public List<TypeHighTemperatureJSON> value;
      };
      };
    public class TypeLowTemperatureJSON : JSONBase
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


        public TypeLowTemperatureJSON()
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


        public virtual int extraTypeLowTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeLowTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeLowTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeLowTemperatureLookup(string field_name)
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

        public virtual void extraTypeLowTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeLowTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeLowTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeLowTemperatureAppendPair(key, new_component);
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

        public static TypeLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLowTemperature", ignore_extras);
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
        public static TypeLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLowTemperature", ignore_extras);
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
        public static TypeLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLowTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLowTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeLowTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeLowTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLowTemperature", ignore_extras);
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
                TypeLowTemperatureJSON result = new TypeLowTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeLowTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeLowTemperatureJSON result)
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
            protected abstract void handle_result(TypeLowTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeLowTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeLowTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeLowTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeLowTemperature class");
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
            protected override void handle_result(TypeLowTemperatureJSON  result)
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
            public TypeLowTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeLowTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeLowTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeLowTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeLowTemperatureJSON>();
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
        public List<TypeLowTemperatureJSON> value;
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
    public class TypePrecipitationDayJSON : JSONBase
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


        public TypePrecipitationDayJSON()
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


        public virtual int extraTypePrecipitationDayComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePrecipitationDayComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePrecipitationDayComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePrecipitationDayLookup(string field_name)
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

        public virtual void extraTypePrecipitationDayAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePrecipitationDaySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePrecipitationDayLookup(key);
            if (old_field == null)
              {
                extraTypePrecipitationDayAppendPair(key, new_component);
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

        public static TypePrecipitationDayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitationDayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationDay", ignore_extras);
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
        public static TypePrecipitationDayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitationDayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitationDayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationDay", ignore_extras);
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
        public static TypePrecipitationDayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitationDayJSON from_text(string text, bool ignore_extras)
          {
            TypePrecipitationDayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationDay", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePrecipitationDayJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePrecipitationDayJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePrecipitationDayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationDay", ignore_extras);
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
                TypePrecipitationDayJSON result = new TypePrecipitationDayJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePrecipitationDayAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePrecipitationDayJSON result)
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
            protected abstract void handle_result(TypePrecipitationDayJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitationDay class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePrecipitationDay class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitationDay class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePrecipitationDay class");
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
            protected override void handle_result(TypePrecipitationDayJSON  result)
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
            public TypePrecipitationDayJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePrecipitationDayJSON  result)
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
        protected virtual void handle_result(List<TypePrecipitationDayJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePrecipitationDayJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePrecipitationDayJSON>();
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
        public List<TypePrecipitationDayJSON> value;
      };
      };
    public class TypePrecipitationNightJSON : JSONBase
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


        public TypePrecipitationNightJSON()
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


        public virtual int extraTypePrecipitationNightComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePrecipitationNightComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePrecipitationNightComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePrecipitationNightLookup(string field_name)
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

        public virtual void extraTypePrecipitationNightAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePrecipitationNightSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePrecipitationNightLookup(key);
            if (old_field == null)
              {
                extraTypePrecipitationNightAppendPair(key, new_component);
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

        public static TypePrecipitationNightJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitationNightJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationNight", ignore_extras);
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
        public static TypePrecipitationNightJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitationNightJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitationNightJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationNight", ignore_extras);
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
        public static TypePrecipitationNightJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitationNightJSON from_text(string text, bool ignore_extras)
          {
            TypePrecipitationNightJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationNight", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePrecipitationNightJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePrecipitationNightJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePrecipitationNightJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationNight", ignore_extras);
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
                TypePrecipitationNightJSON result = new TypePrecipitationNightJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePrecipitationNightAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePrecipitationNightJSON result)
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
            protected abstract void handle_result(TypePrecipitationNightJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitationNight class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePrecipitationNight class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitationNight class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePrecipitationNight class");
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
            protected override void handle_result(TypePrecipitationNightJSON  result)
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
            public TypePrecipitationNightJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePrecipitationNightJSON  result)
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
        protected virtual void handle_result(List<TypePrecipitationNightJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePrecipitationNightJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePrecipitationNightJSON>();
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
        public List<TypePrecipitationNightJSON> value;
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
    public class TypeSnowDayJSON : JSONBase
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


        public TypeSnowDayJSON()
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


        public virtual int extraTypeSnowDayComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSnowDayComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSnowDayComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSnowDayLookup(string field_name)
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

        public virtual void extraTypeSnowDayAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSnowDaySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSnowDayLookup(key);
            if (old_field == null)
              {
                extraTypeSnowDayAppendPair(key, new_component);
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

        public static TypeSnowDayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSnowDayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowDay", ignore_extras);
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
        public static TypeSnowDayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSnowDayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSnowDayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowDay", ignore_extras);
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
        public static TypeSnowDayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSnowDayJSON from_text(string text, bool ignore_extras)
          {
            TypeSnowDayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowDay", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSnowDayJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSnowDayJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSnowDayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowDay", ignore_extras);
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
                TypeSnowDayJSON result = new TypeSnowDayJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSnowDayAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSnowDayJSON result)
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
            protected abstract void handle_result(TypeSnowDayJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowDay class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSnowDay class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowDay class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSnowDay class");
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
            protected override void handle_result(TypeSnowDayJSON  result)
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
            public TypeSnowDayJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSnowDayJSON  result)
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
        protected virtual void handle_result(List<TypeSnowDayJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSnowDayJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSnowDayJSON>();
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
        public List<TypeSnowDayJSON> value;
      };
      };
    public class TypeSnowNightJSON : JSONBase
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


        public TypeSnowNightJSON()
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


        public virtual int extraTypeSnowNightComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSnowNightComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSnowNightComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSnowNightLookup(string field_name)
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

        public virtual void extraTypeSnowNightAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSnowNightSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSnowNightLookup(key);
            if (old_field == null)
              {
                extraTypeSnowNightAppendPair(key, new_component);
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

        public static TypeSnowNightJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSnowNightJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowNight", ignore_extras);
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
        public static TypeSnowNightJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSnowNightJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSnowNightJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowNight", ignore_extras);
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
        public static TypeSnowNightJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSnowNightJSON from_text(string text, bool ignore_extras)
          {
            TypeSnowNightJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowNight", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSnowNightJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSnowNightJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSnowNightJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSnowNight", ignore_extras);
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
                TypeSnowNightJSON result = new TypeSnowNightJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSnowNightAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSnowNightJSON result)
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
            protected abstract void handle_result(TypeSnowNightJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowNight class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSnowNight class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_SnowJSON.HoldingGenerator("field \"Value\" of the TypeSnowNight class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSnowNight class");
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
            protected override void handle_result(TypeSnowNightJSON  result)
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
            public TypeSnowNightJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSnowNightJSON  result)
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
        protected virtual void handle_result(List<TypeSnowNightJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSnowNightJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSnowNightJSON>();
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
        public List<TypeSnowNightJSON> value;
      };
      };
    private bool flagHasForecastDateAndTime;
    private DateAndOrTimeJSON  storeForecastDateAndTime;
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
    private bool flagHasForecastShortPhrase;
    private ForecastShortPhraseJSON  storeForecastShortPhrase;
    private bool flagHasForecastShortPhraseDisplay;
    private string storeForecastShortPhraseDisplay;
    private bool flagHasForecastShortPhraseSpoken;
    private string storeForecastShortPhraseSpoken;
    private bool flagHasForecastShortPhraseWritten;
    private string storeForecastShortPhraseWritten;
    private bool flagHasWeatherIconURL;
    private string storeWeatherIconURL;
    private bool flagHasConditionsImage;
    private WeatherImageJSON  storeConditionsImage;
    private bool flagHasHighTemperature;
    private TypeHighTemperatureJSON  storeHighTemperature;
    private bool flagHasLowTemperature;
    private TypeLowTemperatureJSON  storeLowTemperature;
    private bool flagHasProbabilityOfPrecipitationPct;
    private sbyte storeProbabilityOfPrecipitationPct;
    private bool flagHasPrecipitationTotal;
    private TypePrecipitationTotalJSON  storePrecipitationTotal;
    private bool flagHasPrecipitationDay;
    private TypePrecipitationDayJSON  storePrecipitationDay;
    private bool flagHasPrecipitationNight;
    private TypePrecipitationNightJSON  storePrecipitationNight;
    private bool flagHasDay;
    private DailyForecastDayPartJSON  storeDay;
    private bool flagHasNight;
    private DailyForecastDayPartJSON  storeNight;
    private bool flagHasSnowTotal;
    private TypeSnowTotalJSON  storeSnowTotal;
    private bool flagHasSnowDay;
    private TypeSnowDayJSON  storeSnowDay;
    private bool flagHasSnowNight;
    private TypeSnowNightJSON  storeSnowNight;
    private bool flagHasMaxHumidityPct;
    private sbyte storeMaxHumidityPct;
    private bool flagHasAvgHumidityPct;
    private sbyte storeAvgHumidityPct;
    private bool flagHasMinHumidityPct;
    private sbyte storeMinHumidityPct;
    private bool flagHasMaxWind;
    private WindDataJSON  storeMaxWind;
    private bool flagHasAvgWind;
    private WindDataJSON  storeAvgWind;
    private bool flagHasAirQuality;
    private AirQualityDataJSON  storeAirQuality;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONForecastDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setForecastDateAndTime(convert_classy);
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
            throw new Exception("The value for field MoonPhaseTextDisplay of DailyForecastJSON is not a string.");
        setMoonPhaseTextDisplay(json_string.getData());
      }


    private void  fromJSONMoonPhaseTextSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MoonPhaseTextSpoken of DailyForecastJSON is not a string.");
        setMoonPhaseTextSpoken(json_string.getData());
      }


    private void  fromJSONMoonPhaseTextWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MoonPhaseTextWritten of DailyForecastJSON is not a string.");
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
                throw new Exception("The value for field MoonPhasePct of DailyForecastJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MoonPhasePct of DailyForecastJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setMoonPhasePct(extracted_integer);
      }


    private void  fromJSONForecastShortPhrase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ForecastShortPhraseJSON convert_classy = ForecastShortPhraseJSON.from_json(json_value, ignore_extras, true);
        setForecastShortPhrase(convert_classy);
      }


    private void  fromJSONForecastShortPhraseDisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ForecastShortPhraseDisplay of DailyForecastJSON is not a string.");
        setForecastShortPhraseDisplay(json_string.getData());
      }


    private void  fromJSONForecastShortPhraseSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ForecastShortPhraseSpoken of DailyForecastJSON is not a string.");
        setForecastShortPhraseSpoken(json_string.getData());
      }


    private void  fromJSONForecastShortPhraseWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ForecastShortPhraseWritten of DailyForecastJSON is not a string.");
        setForecastShortPhraseWritten(json_string.getData());
      }


    private void  fromJSONWeatherIconURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WeatherIconURL of DailyForecastJSON is not a string.");
        setWeatherIconURL(json_string.getData());
      }


    private void  fromJSONConditionsImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherImageJSON convert_classy = WeatherImageJSON.from_json(json_value, ignore_extras, true);
        setConditionsImage(convert_classy);
      }


    private void  fromJSONHighTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeHighTemperatureJSON convert_classy = TypeHighTemperatureJSON.from_json(json_value, ignore_extras, true);
        setHighTemperature(convert_classy);
      }


    private void  fromJSONLowTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeLowTemperatureJSON convert_classy = TypeLowTemperatureJSON.from_json(json_value, ignore_extras, true);
        setLowTemperature(convert_classy);
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
                throw new Exception("The value for field ProbabilityOfPrecipitationPct of DailyForecastJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProbabilityOfPrecipitationPct of DailyForecastJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setProbabilityOfPrecipitationPct(extracted_integer);
      }


    private void  fromJSONPrecipitationTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePrecipitationTotalJSON convert_classy = TypePrecipitationTotalJSON.from_json(json_value, ignore_extras, true);
        setPrecipitationTotal(convert_classy);
      }


    private void  fromJSONPrecipitationDay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePrecipitationDayJSON convert_classy = TypePrecipitationDayJSON.from_json(json_value, ignore_extras, true);
        setPrecipitationDay(convert_classy);
      }


    private void  fromJSONPrecipitationNight(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePrecipitationNightJSON convert_classy = TypePrecipitationNightJSON.from_json(json_value, ignore_extras, true);
        setPrecipitationNight(convert_classy);
      }


    private void  fromJSONDay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DailyForecastDayPartJSON convert_classy = DailyForecastDayPartJSON.from_json(json_value, ignore_extras, true);
        setDay(convert_classy);
      }


    private void  fromJSONNight(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DailyForecastDayPartJSON convert_classy = DailyForecastDayPartJSON.from_json(json_value, ignore_extras, true);
        setNight(convert_classy);
      }


    private void  fromJSONSnowTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSnowTotalJSON convert_classy = TypeSnowTotalJSON.from_json(json_value, ignore_extras, true);
        setSnowTotal(convert_classy);
      }


    private void  fromJSONSnowDay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSnowDayJSON convert_classy = TypeSnowDayJSON.from_json(json_value, ignore_extras, true);
        setSnowDay(convert_classy);
      }


    private void  fromJSONSnowNight(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSnowNightJSON convert_classy = TypeSnowNightJSON.from_json(json_value, ignore_extras, true);
        setSnowNight(convert_classy);
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
                throw new Exception("The value for field MaxHumidityPct of DailyForecastJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MaxHumidityPct of DailyForecastJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
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
                throw new Exception("The value for field AvgHumidityPct of DailyForecastJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AvgHumidityPct of DailyForecastJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
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
                throw new Exception("The value for field MinHumidityPct of DailyForecastJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MinHumidityPct of DailyForecastJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setMinHumidityPct(extracted_integer);
      }


    private void  fromJSONMaxWind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WindDataJSON convert_classy = WindDataJSON.from_json(json_value, ignore_extras, true);
        setMaxWind(convert_classy);
      }


    private void  fromJSONAvgWind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WindDataJSON convert_classy = WindDataJSON.from_json(json_value, ignore_extras, true);
        setAvgWind(convert_classy);
      }


    private void  fromJSONAirQuality(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AirQualityDataJSON convert_classy = AirQualityDataJSON.from_json(json_value, ignore_extras, true);
        setAirQuality(convert_classy);
      }


    public DailyForecastJSON()
      {
        flagHasForecastDateAndTime = false;
        flagHasSunriseDateAndTime = false;
        flagHasSunsetDateAndTime = false;
        flagHasMoonPhaseText = false;
        flagHasMoonPhaseTextDisplay = false;
        flagHasMoonPhaseTextSpoken = false;
        flagHasMoonPhaseTextWritten = false;
        flagHasMoonPhasePct = false;
        flagHasForecastShortPhrase = false;
        flagHasForecastShortPhraseDisplay = false;
        flagHasForecastShortPhraseSpoken = false;
        flagHasForecastShortPhraseWritten = false;
        flagHasWeatherIconURL = false;
        flagHasConditionsImage = false;
        flagHasHighTemperature = false;
        flagHasLowTemperature = false;
        flagHasProbabilityOfPrecipitationPct = false;
        flagHasPrecipitationTotal = false;
        flagHasPrecipitationDay = false;
        flagHasPrecipitationNight = false;
        flagHasDay = false;
        flagHasNight = false;
        flagHasSnowTotal = false;
        flagHasSnowDay = false;
        flagHasSnowNight = false;
        flagHasMaxHumidityPct = false;
        flagHasAvgHumidityPct = false;
        flagHasMinHumidityPct = false;
        flagHasMaxWind = false;
        flagHasAvgWind = false;
        flagHasAirQuality = false;
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

    public bool  hasForecastShortPhrase()
      {
        return flagHasForecastShortPhrase;
      }

    public ForecastShortPhraseJSON   getForecastShortPhrase()
      {
        Debug.Assert(flagHasForecastShortPhrase);
        return storeForecastShortPhrase;
      }

    public ForecastShortPhraseJSON.TypeValue  getForecastShortPhraseValue()
      {
        return getForecastShortPhrase().getValue();
      }

    public string  getForecastShortPhraseAsString()
      {
        return getForecastShortPhrase().getValueAsString();
      }

    public bool  hasForecastShortPhraseDisplay()
      {
        return flagHasForecastShortPhraseDisplay;
      }

    public string  getForecastShortPhraseDisplay()
      {
        Debug.Assert(flagHasForecastShortPhraseDisplay);
        return storeForecastShortPhraseDisplay;
      }

    public bool  hasForecastShortPhraseSpoken()
      {
        return flagHasForecastShortPhraseSpoken;
      }

    public string  getForecastShortPhraseSpoken()
      {
        Debug.Assert(flagHasForecastShortPhraseSpoken);
        return storeForecastShortPhraseSpoken;
      }

    public bool  hasForecastShortPhraseWritten()
      {
        return flagHasForecastShortPhraseWritten;
      }

    public string  getForecastShortPhraseWritten()
      {
        Debug.Assert(flagHasForecastShortPhraseWritten);
        return storeForecastShortPhraseWritten;
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

    public bool  hasHighTemperature()
      {
        return flagHasHighTemperature;
      }

    public TypeHighTemperatureJSON   getHighTemperature()
      {
        Debug.Assert(flagHasHighTemperature);
        return storeHighTemperature;
      }

    public bool  hasLowTemperature()
      {
        return flagHasLowTemperature;
      }

    public TypeLowTemperatureJSON   getLowTemperature()
      {
        Debug.Assert(flagHasLowTemperature);
        return storeLowTemperature;
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

    public bool  hasPrecipitationTotal()
      {
        return flagHasPrecipitationTotal;
      }

    public TypePrecipitationTotalJSON   getPrecipitationTotal()
      {
        Debug.Assert(flagHasPrecipitationTotal);
        return storePrecipitationTotal;
      }

    public bool  hasPrecipitationDay()
      {
        return flagHasPrecipitationDay;
      }

    public TypePrecipitationDayJSON   getPrecipitationDay()
      {
        Debug.Assert(flagHasPrecipitationDay);
        return storePrecipitationDay;
      }

    public bool  hasPrecipitationNight()
      {
        return flagHasPrecipitationNight;
      }

    public TypePrecipitationNightJSON   getPrecipitationNight()
      {
        Debug.Assert(flagHasPrecipitationNight);
        return storePrecipitationNight;
      }

    public bool  hasDay()
      {
        return flagHasDay;
      }

    public DailyForecastDayPartJSON   getDay()
      {
        Debug.Assert(flagHasDay);
        return storeDay;
      }

    public bool  hasNight()
      {
        return flagHasNight;
      }

    public DailyForecastDayPartJSON   getNight()
      {
        Debug.Assert(flagHasNight);
        return storeNight;
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

    public bool  hasSnowDay()
      {
        return flagHasSnowDay;
      }

    public TypeSnowDayJSON   getSnowDay()
      {
        Debug.Assert(flagHasSnowDay);
        return storeSnowDay;
      }

    public bool  hasSnowNight()
      {
        return flagHasSnowNight;
      }

    public TypeSnowNightJSON   getSnowNight()
      {
        Debug.Assert(flagHasSnowNight);
        return storeSnowNight;
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

    public bool  hasMaxWind()
      {
        return flagHasMaxWind;
      }

    public WindDataJSON   getMaxWind()
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

    public bool  hasAirQuality()
      {
        return flagHasAirQuality;
      }

    public AirQualityDataJSON   getAirQuality()
      {
        Debug.Assert(flagHasAirQuality);
        return storeAirQuality;
      }


    public virtual int extraDailyForecastComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDailyForecastComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDailyForecastComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDailyForecastLookup(string field_name)
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
            throw new Exception("The value for field MoonPhasePct of DailyForecastJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field MoonPhasePct of DailyForecastJSON is greater than the upper bound (100) for that field.");
        storeMoonPhasePct = new_value;
      }
    public void unsetMoonPhasePct()
      {
        flagHasMoonPhasePct = false;
      }
    public void setForecastShortPhrase(ForecastShortPhraseJSON  new_value)
      {
        if (flagHasForecastShortPhrase)
          {
          }
        flagHasForecastShortPhrase = true;
        storeForecastShortPhrase = new_value;
      }
    public void setForecastShortPhrase(ForecastShortPhraseJSON.TypeValue new_value)
      {
        setForecastShortPhrase(new ForecastShortPhraseJSON(new_value));
      }
    public void setForecastShortPhrase(string chars)
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
        setForecastShortPhrase(new_value);
      }
    public void unsetForecastShortPhrase()
      {
        if (flagHasForecastShortPhrase)
          {
          }
        flagHasForecastShortPhrase = false;
      }
    public void setForecastShortPhraseDisplay(string new_value)
      {
        flagHasForecastShortPhraseDisplay = true;
        storeForecastShortPhraseDisplay = new_value;
      }
    public void unsetForecastShortPhraseDisplay()
      {
        flagHasForecastShortPhraseDisplay = false;
      }
    public void setForecastShortPhraseSpoken(string new_value)
      {
        flagHasForecastShortPhraseSpoken = true;
        storeForecastShortPhraseSpoken = new_value;
      }
    public void unsetForecastShortPhraseSpoken()
      {
        flagHasForecastShortPhraseSpoken = false;
      }
    public void setForecastShortPhraseWritten(string new_value)
      {
        flagHasForecastShortPhraseWritten = true;
        storeForecastShortPhraseWritten = new_value;
      }
    public void unsetForecastShortPhraseWritten()
      {
        flagHasForecastShortPhraseWritten = false;
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
    public void setHighTemperature(TypeHighTemperatureJSON  new_value)
      {
        if (flagHasHighTemperature)
          {
          }
        flagHasHighTemperature = true;
        storeHighTemperature = new_value;
      }
    public void unsetHighTemperature()
      {
        if (flagHasHighTemperature)
          {
          }
        flagHasHighTemperature = false;
      }
    public void setLowTemperature(TypeLowTemperatureJSON  new_value)
      {
        if (flagHasLowTemperature)
          {
          }
        flagHasLowTemperature = true;
        storeLowTemperature = new_value;
      }
    public void unsetLowTemperature()
      {
        if (flagHasLowTemperature)
          {
          }
        flagHasLowTemperature = false;
      }
    public void setProbabilityOfPrecipitationPct(sbyte new_value)
      {
        flagHasProbabilityOfPrecipitationPct = true;
        if (new_value < 0)
            throw new Exception("The value for field ProbabilityOfPrecipitationPct of DailyForecastJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field ProbabilityOfPrecipitationPct of DailyForecastJSON is greater than the upper bound (100) for that field.");
        storeProbabilityOfPrecipitationPct = new_value;
      }
    public void unsetProbabilityOfPrecipitationPct()
      {
        flagHasProbabilityOfPrecipitationPct = false;
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
    public void setPrecipitationDay(TypePrecipitationDayJSON  new_value)
      {
        if (flagHasPrecipitationDay)
          {
          }
        flagHasPrecipitationDay = true;
        storePrecipitationDay = new_value;
      }
    public void unsetPrecipitationDay()
      {
        if (flagHasPrecipitationDay)
          {
          }
        flagHasPrecipitationDay = false;
      }
    public void setPrecipitationNight(TypePrecipitationNightJSON  new_value)
      {
        if (flagHasPrecipitationNight)
          {
          }
        flagHasPrecipitationNight = true;
        storePrecipitationNight = new_value;
      }
    public void unsetPrecipitationNight()
      {
        if (flagHasPrecipitationNight)
          {
          }
        flagHasPrecipitationNight = false;
      }
    public void setDay(DailyForecastDayPartJSON  new_value)
      {
        if (flagHasDay)
          {
          }
        flagHasDay = true;
        storeDay = new_value;
      }
    public void unsetDay()
      {
        if (flagHasDay)
          {
          }
        flagHasDay = false;
      }
    public void setNight(DailyForecastDayPartJSON  new_value)
      {
        if (flagHasNight)
          {
          }
        flagHasNight = true;
        storeNight = new_value;
      }
    public void unsetNight()
      {
        if (flagHasNight)
          {
          }
        flagHasNight = false;
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
    public void setSnowDay(TypeSnowDayJSON  new_value)
      {
        if (flagHasSnowDay)
          {
          }
        flagHasSnowDay = true;
        storeSnowDay = new_value;
      }
    public void unsetSnowDay()
      {
        if (flagHasSnowDay)
          {
          }
        flagHasSnowDay = false;
      }
    public void setSnowNight(TypeSnowNightJSON  new_value)
      {
        if (flagHasSnowNight)
          {
          }
        flagHasSnowNight = true;
        storeSnowNight = new_value;
      }
    public void unsetSnowNight()
      {
        if (flagHasSnowNight)
          {
          }
        flagHasSnowNight = false;
      }
    public void setMaxHumidityPct(sbyte new_value)
      {
        flagHasMaxHumidityPct = true;
        if (new_value < 0)
            throw new Exception("The value for field MaxHumidityPct of DailyForecastJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field MaxHumidityPct of DailyForecastJSON is greater than the upper bound (100) for that field.");
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
            throw new Exception("The value for field AvgHumidityPct of DailyForecastJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field AvgHumidityPct of DailyForecastJSON is greater than the upper bound (100) for that field.");
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
            throw new Exception("The value for field MinHumidityPct of DailyForecastJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field MinHumidityPct of DailyForecastJSON is greater than the upper bound (100) for that field.");
        storeMinHumidityPct = new_value;
      }
    public void unsetMinHumidityPct()
      {
        flagHasMinHumidityPct = false;
      }
    public void setMaxWind(WindDataJSON  new_value)
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

    public virtual void extraDailyForecastAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDailyForecastSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDailyForecastLookup(key);
        if (old_field == null)
          {
            extraDailyForecastAppendPair(key, new_component);
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
        if (flagHasForecastShortPhrase)
          {
            handler.start_pair("ForecastShortPhrase");
            if (partial_allowed)
                storeForecastShortPhrase.write_partial_as_json(handler);
            else
                storeForecastShortPhrase.write_as_json(handler);
          }
        if (flagHasForecastShortPhraseDisplay)
          {
            handler.start_pair("ForecastShortPhraseDisplay");
            handler.string_value(storeForecastShortPhraseDisplay);
          }
        if (flagHasForecastShortPhraseSpoken)
          {
            handler.start_pair("ForecastShortPhraseSpoken");
            handler.string_value(storeForecastShortPhraseSpoken);
          }
        if (flagHasForecastShortPhraseWritten)
          {
            handler.start_pair("ForecastShortPhraseWritten");
            handler.string_value(storeForecastShortPhraseWritten);
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
        if (flagHasHighTemperature)
          {
            handler.start_pair("HighTemperature");
            if (partial_allowed)
                storeHighTemperature.write_partial_as_json(handler);
            else
                storeHighTemperature.write_as_json(handler);
          }
        if (flagHasLowTemperature)
          {
            handler.start_pair("LowTemperature");
            if (partial_allowed)
                storeLowTemperature.write_partial_as_json(handler);
            else
                storeLowTemperature.write_as_json(handler);
          }
        if (flagHasProbabilityOfPrecipitationPct)
          {
            handler.start_pair("ProbabilityOfPrecipitationPct");
            handler.number_value(storeProbabilityOfPrecipitationPct);
          }
        if (flagHasPrecipitationTotal)
          {
            handler.start_pair("PrecipitationTotal");
            if (partial_allowed)
                storePrecipitationTotal.write_partial_as_json(handler);
            else
                storePrecipitationTotal.write_as_json(handler);
          }
        if (flagHasPrecipitationDay)
          {
            handler.start_pair("PrecipitationDay");
            if (partial_allowed)
                storePrecipitationDay.write_partial_as_json(handler);
            else
                storePrecipitationDay.write_as_json(handler);
          }
        if (flagHasPrecipitationNight)
          {
            handler.start_pair("PrecipitationNight");
            if (partial_allowed)
                storePrecipitationNight.write_partial_as_json(handler);
            else
                storePrecipitationNight.write_as_json(handler);
          }
        if (flagHasDay)
          {
            handler.start_pair("Day");
            if (partial_allowed)
                storeDay.write_partial_as_json(handler);
            else
                storeDay.write_as_json(handler);
          }
        if (flagHasNight)
          {
            handler.start_pair("Night");
            if (partial_allowed)
                storeNight.write_partial_as_json(handler);
            else
                storeNight.write_as_json(handler);
          }
        if (flagHasSnowTotal)
          {
            handler.start_pair("SnowTotal");
            if (partial_allowed)
                storeSnowTotal.write_partial_as_json(handler);
            else
                storeSnowTotal.write_as_json(handler);
          }
        if (flagHasSnowDay)
          {
            handler.start_pair("SnowDay");
            if (partial_allowed)
                storeSnowDay.write_partial_as_json(handler);
            else
                storeSnowDay.write_as_json(handler);
          }
        if (flagHasSnowNight)
          {
            handler.start_pair("SnowNight");
            if (partial_allowed)
                storeSnowNight.write_partial_as_json(handler);
            else
                storeSnowNight.write_as_json(handler);
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
        if (!(hasForecastDateAndTime()))
          {
            return "When parsing the object for %what%, the \"ForecastDateAndTime\" field was missing.";
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

    public static DailyForecastJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DailyForecastJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyForecast", ignore_extras);
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
    public static DailyForecastJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DailyForecastJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DailyForecastJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyForecast", ignore_extras);
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
    public static DailyForecastJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DailyForecastJSON from_text(string text, bool ignore_extras)
      {
        DailyForecastJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyForecast", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DailyForecastJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DailyForecastJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DailyForecastJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyForecast", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorForecastDateAndTime;
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
        private ForecastShortPhraseJSON.HoldingGenerator fieldGeneratorForecastShortPhrase;
        private JSONHoldingStringGenerator fieldGeneratorForecastShortPhraseDisplay;
        private JSONHoldingStringGenerator fieldGeneratorForecastShortPhraseSpoken;
        private JSONHoldingStringGenerator fieldGeneratorForecastShortPhraseWritten;
        private JSONHoldingStringGenerator fieldGeneratorWeatherIconURL;
        private WeatherImageJSON.HoldingGenerator fieldGeneratorConditionsImage;
        private TypeHighTemperatureJSON.HoldingGenerator fieldGeneratorHighTemperature;
        private TypeLowTemperatureJSON.HoldingGenerator fieldGeneratorLowTemperature;
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
        private TypePrecipitationTotalJSON.HoldingGenerator fieldGeneratorPrecipitationTotal;
        private TypePrecipitationDayJSON.HoldingGenerator fieldGeneratorPrecipitationDay;
        private TypePrecipitationNightJSON.HoldingGenerator fieldGeneratorPrecipitationNight;
        private DailyForecastDayPartJSON.HoldingGenerator fieldGeneratorDay;
        private DailyForecastDayPartJSON.HoldingGenerator fieldGeneratorNight;
        private TypeSnowTotalJSON.HoldingGenerator fieldGeneratorSnowTotal;
        private TypeSnowDayJSON.HoldingGenerator fieldGeneratorSnowDay;
        private TypeSnowNightJSON.HoldingGenerator fieldGeneratorSnowNight;
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
        private WindDataJSON.HoldingGenerator fieldGeneratorMaxWind;
        private WindDataJSON.HoldingGenerator fieldGeneratorAvgWind;
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
            DailyForecastJSON result = new DailyForecastJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDailyForecastAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DailyForecastJSON result)
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
            if (fieldGeneratorForecastShortPhrase.have_value)
              {
                result.setForecastShortPhrase(fieldGeneratorForecastShortPhrase.value);
                fieldGeneratorForecastShortPhrase.have_value = false;
              }
            if (fieldGeneratorForecastShortPhraseDisplay.have_value)
              {
                result.setForecastShortPhraseDisplay(fieldGeneratorForecastShortPhraseDisplay.value);
                fieldGeneratorForecastShortPhraseDisplay.have_value = false;
              }
            if (fieldGeneratorForecastShortPhraseSpoken.have_value)
              {
                result.setForecastShortPhraseSpoken(fieldGeneratorForecastShortPhraseSpoken.value);
                fieldGeneratorForecastShortPhraseSpoken.have_value = false;
              }
            if (fieldGeneratorForecastShortPhraseWritten.have_value)
              {
                result.setForecastShortPhraseWritten(fieldGeneratorForecastShortPhraseWritten.value);
                fieldGeneratorForecastShortPhraseWritten.have_value = false;
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
            if (fieldGeneratorHighTemperature.have_value)
              {
                result.setHighTemperature(fieldGeneratorHighTemperature.value);
                fieldGeneratorHighTemperature.have_value = false;
              }
            if (fieldGeneratorLowTemperature.have_value)
              {
                result.setLowTemperature(fieldGeneratorLowTemperature.value);
                fieldGeneratorLowTemperature.have_value = false;
              }
            if (fieldGeneratorProbabilityOfPrecipitationPct.have_value)
              {
                result.setProbabilityOfPrecipitationPct((sbyte)(fieldGeneratorProbabilityOfPrecipitationPct.value));
                fieldGeneratorProbabilityOfPrecipitationPct.have_value = false;
              }
            if (fieldGeneratorPrecipitationTotal.have_value)
              {
                result.setPrecipitationTotal(fieldGeneratorPrecipitationTotal.value);
                fieldGeneratorPrecipitationTotal.have_value = false;
              }
            if (fieldGeneratorPrecipitationDay.have_value)
              {
                result.setPrecipitationDay(fieldGeneratorPrecipitationDay.value);
                fieldGeneratorPrecipitationDay.have_value = false;
              }
            if (fieldGeneratorPrecipitationNight.have_value)
              {
                result.setPrecipitationNight(fieldGeneratorPrecipitationNight.value);
                fieldGeneratorPrecipitationNight.have_value = false;
              }
            if (fieldGeneratorDay.have_value)
              {
                result.setDay(fieldGeneratorDay.value);
                fieldGeneratorDay.have_value = false;
              }
            if (fieldGeneratorNight.have_value)
              {
                result.setNight(fieldGeneratorNight.value);
                fieldGeneratorNight.have_value = false;
              }
            if (fieldGeneratorSnowTotal.have_value)
              {
                result.setSnowTotal(fieldGeneratorSnowTotal.value);
                fieldGeneratorSnowTotal.have_value = false;
              }
            if (fieldGeneratorSnowDay.have_value)
              {
                result.setSnowDay(fieldGeneratorSnowDay.value);
                fieldGeneratorSnowDay.have_value = false;
              }
            if (fieldGeneratorSnowNight.have_value)
              {
                result.setSnowNight(fieldGeneratorSnowNight.value);
                fieldGeneratorSnowNight.have_value = false;
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
            if (fieldGeneratorAirQuality.have_value)
              {
                result.setAirQuality(fieldGeneratorAirQuality.value);
                fieldGeneratorAirQuality.have_value = false;
              }
          }
        protected abstract void handle_result(DailyForecastJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "rQuality", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorAirQuality;
                            break;
                        case 'v':
                            if (String.Compare(field_name, 2, "g", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'H':
                                        if ((String.Compare(field_name, 4, "umidityPct", 0, 10, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorAvgHumidityPct;
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
                        default:
                            break;
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "onditionsImage", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorConditionsImage;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ay", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorDay;
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "orecast", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "ateAndTime", 0, 10, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorForecastDateAndTime;
                                break;
                            case 'S':
                                if (String.Compare(field_name, 9, "hortPhrase", 0, 10, false) == 0)
                                  {
                                    if (field_name.Length == 19)
                                      {
                                        return fieldGeneratorForecastShortPhrase;
                                      }
                                    switch (field_name[19])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 20, "isplay", 0, 6, false) == 0) && (field_name.Length == 26))
                                                return fieldGeneratorForecastShortPhraseDisplay;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 20, "poken", 0, 5, false) == 0) && (field_name.Length == 25))
                                                return fieldGeneratorForecastShortPhraseSpoken;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 20, "ritten", 0, 6, false) == 0) && (field_name.Length == 26))
                                                return fieldGeneratorForecastShortPhraseWritten;
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
                    if ((String.Compare(field_name, 1, "ighTemperature", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorHighTemperature;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "owTemperature", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorLowTemperature;
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "x", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'H':
                                        if ((String.Compare(field_name, 4, "umidityPct", 0, 10, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorMaxHumidityPct;
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
                            if ((String.Compare(field_name, 2, "nHumidityPct", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorMinHumidityPct;
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
                case 'N':
                    if ((String.Compare(field_name, 1, "ight", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorNight;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "r", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'e':
                                if (String.Compare(field_name, 3, "cipitation", 0, 10, false) == 0)
                                  {
                                    switch (field_name[13])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 14, "ay", 0, 2, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorPrecipitationDay;
                                            break;
                                        case 'N':
                                            if ((String.Compare(field_name, 14, "ight", 0, 4, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorPrecipitationNight;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 14, "otal", 0, 4, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorPrecipitationTotal;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
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
                    switch (field_name[1])
                      {
                        case 'n':
                            if (String.Compare(field_name, 2, "ow", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 5, "ay", 0, 2, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratorSnowDay;
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 5, "ight", 0, 4, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorSnowNight;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 5, "otal", 0, 4, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorSnowTotal;
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
                case 'W':
                    if ((String.Compare(field_name, 1, "eatherIconURL", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorWeatherIconURL;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorForecastDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ForecastDateAndTime\" of the DailyForecast class", ignore_extras);
            fieldGeneratorSunriseDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SunriseDateAndTime\" of the DailyForecast class", ignore_extras);
            fieldGeneratorSunsetDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SunsetDateAndTime\" of the DailyForecast class", ignore_extras);
            fieldGeneratorMoonPhaseText = new MoonPhaseDataJSON.HoldingGenerator("field \"MoonPhaseText\" of the DailyForecast class", ignore_extras);
            fieldGeneratorMoonPhaseTextDisplay = new JSONHoldingStringGenerator("field \"MoonPhaseTextDisplay\" of the DailyForecast class");
            fieldGeneratorMoonPhaseTextSpoken = new JSONHoldingStringGenerator("field \"MoonPhaseTextSpoken\" of the DailyForecast class");
            fieldGeneratorMoonPhaseTextWritten = new JSONHoldingStringGenerator("field \"MoonPhaseTextWritten\" of the DailyForecast class");
            fieldGeneratorMoonPhasePct = new FieldHoldingGeneratorMoonPhasePct("field \"MoonPhasePct\" of the DailyForecast class");
            fieldGeneratorForecastShortPhrase = new ForecastShortPhraseJSON.HoldingGenerator("field \"ForecastShortPhrase\" of the DailyForecast class", ignore_extras);
            fieldGeneratorForecastShortPhraseDisplay = new JSONHoldingStringGenerator("field \"ForecastShortPhraseDisplay\" of the DailyForecast class");
            fieldGeneratorForecastShortPhraseSpoken = new JSONHoldingStringGenerator("field \"ForecastShortPhraseSpoken\" of the DailyForecast class");
            fieldGeneratorForecastShortPhraseWritten = new JSONHoldingStringGenerator("field \"ForecastShortPhraseWritten\" of the DailyForecast class");
            fieldGeneratorWeatherIconURL = new JSONHoldingStringGenerator("field \"WeatherIconURL\" of the DailyForecast class");
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the DailyForecast class", ignore_extras);
            fieldGeneratorHighTemperature = new TypeHighTemperatureJSON.HoldingGenerator("field \"HighTemperature\" of the DailyForecast class", ignore_extras);
            fieldGeneratorLowTemperature = new TypeLowTemperatureJSON.HoldingGenerator("field \"LowTemperature\" of the DailyForecast class", ignore_extras);
            fieldGeneratorProbabilityOfPrecipitationPct = new FieldHoldingGeneratorProbabilityOfPrecipitationPct("field \"ProbabilityOfPrecipitationPct\" of the DailyForecast class");
            fieldGeneratorPrecipitationTotal = new TypePrecipitationTotalJSON.HoldingGenerator("field \"PrecipitationTotal\" of the DailyForecast class", ignore_extras);
            fieldGeneratorPrecipitationDay = new TypePrecipitationDayJSON.HoldingGenerator("field \"PrecipitationDay\" of the DailyForecast class", ignore_extras);
            fieldGeneratorPrecipitationNight = new TypePrecipitationNightJSON.HoldingGenerator("field \"PrecipitationNight\" of the DailyForecast class", ignore_extras);
            fieldGeneratorDay = new DailyForecastDayPartJSON.HoldingGenerator("field \"Day\" of the DailyForecast class", ignore_extras);
            fieldGeneratorNight = new DailyForecastDayPartJSON.HoldingGenerator("field \"Night\" of the DailyForecast class", ignore_extras);
            fieldGeneratorSnowTotal = new TypeSnowTotalJSON.HoldingGenerator("field \"SnowTotal\" of the DailyForecast class", ignore_extras);
            fieldGeneratorSnowDay = new TypeSnowDayJSON.HoldingGenerator("field \"SnowDay\" of the DailyForecast class", ignore_extras);
            fieldGeneratorSnowNight = new TypeSnowNightJSON.HoldingGenerator("field \"SnowNight\" of the DailyForecast class", ignore_extras);
            fieldGeneratorMaxHumidityPct = new FieldHoldingGeneratorMaxHumidityPct("field \"MaxHumidityPct\" of the DailyForecast class");
            fieldGeneratorAvgHumidityPct = new FieldHoldingGeneratorAvgHumidityPct("field \"AvgHumidityPct\" of the DailyForecast class");
            fieldGeneratorMinHumidityPct = new FieldHoldingGeneratorMinHumidityPct("field \"MinHumidityPct\" of the DailyForecast class");
            fieldGeneratorMaxWind = new WindDataJSON.HoldingGenerator("field \"MaxWind\" of the DailyForecast class", ignore_extras);
            fieldGeneratorAvgWind = new WindDataJSON.HoldingGenerator("field \"AvgWind\" of the DailyForecast class", ignore_extras);
            fieldGeneratorAirQuality = new AirQualityDataJSON.HoldingGenerator("field \"AirQuality\" of the DailyForecast class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DailyForecast class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorForecastDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ForecastDateAndTime\" of the DailyForecast class", false);
            fieldGeneratorSunriseDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SunriseDateAndTime\" of the DailyForecast class", false);
            fieldGeneratorSunsetDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SunsetDateAndTime\" of the DailyForecast class", false);
            fieldGeneratorMoonPhaseText = new MoonPhaseDataJSON.HoldingGenerator("field \"MoonPhaseText\" of the DailyForecast class", false);
            fieldGeneratorMoonPhaseTextDisplay = new JSONHoldingStringGenerator("field \"MoonPhaseTextDisplay\" of the DailyForecast class");
            fieldGeneratorMoonPhaseTextSpoken = new JSONHoldingStringGenerator("field \"MoonPhaseTextSpoken\" of the DailyForecast class");
            fieldGeneratorMoonPhaseTextWritten = new JSONHoldingStringGenerator("field \"MoonPhaseTextWritten\" of the DailyForecast class");
            fieldGeneratorMoonPhasePct = new FieldHoldingGeneratorMoonPhasePct("field \"MoonPhasePct\" of the DailyForecast class");
            fieldGeneratorForecastShortPhrase = new ForecastShortPhraseJSON.HoldingGenerator("field \"ForecastShortPhrase\" of the DailyForecast class", false);
            fieldGeneratorForecastShortPhraseDisplay = new JSONHoldingStringGenerator("field \"ForecastShortPhraseDisplay\" of the DailyForecast class");
            fieldGeneratorForecastShortPhraseSpoken = new JSONHoldingStringGenerator("field \"ForecastShortPhraseSpoken\" of the DailyForecast class");
            fieldGeneratorForecastShortPhraseWritten = new JSONHoldingStringGenerator("field \"ForecastShortPhraseWritten\" of the DailyForecast class");
            fieldGeneratorWeatherIconURL = new JSONHoldingStringGenerator("field \"WeatherIconURL\" of the DailyForecast class");
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the DailyForecast class", false);
            fieldGeneratorHighTemperature = new TypeHighTemperatureJSON.HoldingGenerator("field \"HighTemperature\" of the DailyForecast class", false);
            fieldGeneratorLowTemperature = new TypeLowTemperatureJSON.HoldingGenerator("field \"LowTemperature\" of the DailyForecast class", false);
            fieldGeneratorProbabilityOfPrecipitationPct = new FieldHoldingGeneratorProbabilityOfPrecipitationPct("field \"ProbabilityOfPrecipitationPct\" of the DailyForecast class");
            fieldGeneratorPrecipitationTotal = new TypePrecipitationTotalJSON.HoldingGenerator("field \"PrecipitationTotal\" of the DailyForecast class", false);
            fieldGeneratorPrecipitationDay = new TypePrecipitationDayJSON.HoldingGenerator("field \"PrecipitationDay\" of the DailyForecast class", false);
            fieldGeneratorPrecipitationNight = new TypePrecipitationNightJSON.HoldingGenerator("field \"PrecipitationNight\" of the DailyForecast class", false);
            fieldGeneratorDay = new DailyForecastDayPartJSON.HoldingGenerator("field \"Day\" of the DailyForecast class", false);
            fieldGeneratorNight = new DailyForecastDayPartJSON.HoldingGenerator("field \"Night\" of the DailyForecast class", false);
            fieldGeneratorSnowTotal = new TypeSnowTotalJSON.HoldingGenerator("field \"SnowTotal\" of the DailyForecast class", false);
            fieldGeneratorSnowDay = new TypeSnowDayJSON.HoldingGenerator("field \"SnowDay\" of the DailyForecast class", false);
            fieldGeneratorSnowNight = new TypeSnowNightJSON.HoldingGenerator("field \"SnowNight\" of the DailyForecast class", false);
            fieldGeneratorMaxHumidityPct = new FieldHoldingGeneratorMaxHumidityPct("field \"MaxHumidityPct\" of the DailyForecast class");
            fieldGeneratorAvgHumidityPct = new FieldHoldingGeneratorAvgHumidityPct("field \"AvgHumidityPct\" of the DailyForecast class");
            fieldGeneratorMinHumidityPct = new FieldHoldingGeneratorMinHumidityPct("field \"MinHumidityPct\" of the DailyForecast class");
            fieldGeneratorMaxWind = new WindDataJSON.HoldingGenerator("field \"MaxWind\" of the DailyForecast class", false);
            fieldGeneratorAvgWind = new WindDataJSON.HoldingGenerator("field \"AvgWind\" of the DailyForecast class", false);
            fieldGeneratorAirQuality = new AirQualityDataJSON.HoldingGenerator("field \"AirQuality\" of the DailyForecast class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DailyForecast class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorForecastDateAndTime.reset();
            fieldGeneratorSunriseDateAndTime.reset();
            fieldGeneratorSunsetDateAndTime.reset();
            fieldGeneratorMoonPhaseText.reset();
            fieldGeneratorMoonPhaseTextDisplay.reset();
            fieldGeneratorMoonPhaseTextSpoken.reset();
            fieldGeneratorMoonPhaseTextWritten.reset();
            fieldGeneratorMoonPhasePct.reset();
            fieldGeneratorForecastShortPhrase.reset();
            fieldGeneratorForecastShortPhraseDisplay.reset();
            fieldGeneratorForecastShortPhraseSpoken.reset();
            fieldGeneratorForecastShortPhraseWritten.reset();
            fieldGeneratorWeatherIconURL.reset();
            fieldGeneratorConditionsImage.reset();
            fieldGeneratorHighTemperature.reset();
            fieldGeneratorLowTemperature.reset();
            fieldGeneratorProbabilityOfPrecipitationPct.reset();
            fieldGeneratorPrecipitationTotal.reset();
            fieldGeneratorPrecipitationDay.reset();
            fieldGeneratorPrecipitationNight.reset();
            fieldGeneratorDay.reset();
            fieldGeneratorNight.reset();
            fieldGeneratorSnowTotal.reset();
            fieldGeneratorSnowDay.reset();
            fieldGeneratorSnowNight.reset();
            fieldGeneratorMaxHumidityPct.reset();
            fieldGeneratorAvgHumidityPct.reset();
            fieldGeneratorMinHumidityPct.reset();
            fieldGeneratorMaxWind.reset();
            fieldGeneratorAvgWind.reset();
            fieldGeneratorAirQuality.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorForecastDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSunriseDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSunsetDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMoonPhaseText.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorForecastShortPhrase.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConditionsImage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHighTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLowTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrecipitationTotal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrecipitationDay.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPrecipitationNight.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDay.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNight.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSnowTotal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSnowDay.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSnowNight.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMaxWind.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAvgWind.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAirQuality.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorForecastDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSunriseDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSunsetDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMoonPhaseText.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorForecastShortPhrase.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConditionsImage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHighTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLowTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrecipitationTotal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrecipitationDay.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPrecipitationNight.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDay.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNight.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSnowTotal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSnowDay.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSnowNight.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMaxWind.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAvgWind.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAirQuality.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DailyForecastJSON  result)
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
        public DailyForecastJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DailyForecastJSON  result)
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
    protected virtual void handle_result(List<DailyForecastJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DailyForecastJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DailyForecastJSON>();
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
    public List<DailyForecastJSON> value;
  };
  };
