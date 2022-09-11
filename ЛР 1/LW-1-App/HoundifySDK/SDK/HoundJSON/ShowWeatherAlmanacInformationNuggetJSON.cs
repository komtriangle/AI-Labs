/* file "ShowWeatherAlmanacInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ShowWeatherAlmanacInformationNuggetJSON : WeatherInformationNuggetJSON
  {
    public class TypeNormalHighTemperatureJSON : JSONBase
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


        public TypeNormalHighTemperatureJSON()
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


        public virtual int extraTypeNormalHighTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNormalHighTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNormalHighTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNormalHighTemperatureLookup(string field_name)
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

        public virtual void extraTypeNormalHighTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNormalHighTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNormalHighTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeNormalHighTemperatureAppendPair(key, new_component);
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

        public static TypeNormalHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNormalHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNormalHighTemperature", ignore_extras);
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
        public static TypeNormalHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNormalHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNormalHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNormalHighTemperature", ignore_extras);
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
        public static TypeNormalHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNormalHighTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeNormalHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNormalHighTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNormalHighTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNormalHighTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNormalHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNormalHighTemperature", ignore_extras);
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
                TypeNormalHighTemperatureJSON result = new TypeNormalHighTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNormalHighTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNormalHighTemperatureJSON result)
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
            protected abstract void handle_result(TypeNormalHighTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeNormalHighTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNormalHighTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeNormalHighTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNormalHighTemperature class");
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
            protected override void handle_result(TypeNormalHighTemperatureJSON  result)
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
            public TypeNormalHighTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNormalHighTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeNormalHighTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNormalHighTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNormalHighTemperatureJSON>();
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
        public List<TypeNormalHighTemperatureJSON> value;
      };
      };
    public class TypeNormalLowTemperatureJSON : JSONBase
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


        public TypeNormalLowTemperatureJSON()
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


        public virtual int extraTypeNormalLowTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNormalLowTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNormalLowTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNormalLowTemperatureLookup(string field_name)
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

        public virtual void extraTypeNormalLowTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNormalLowTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNormalLowTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeNormalLowTemperatureAppendPair(key, new_component);
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

        public static TypeNormalLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNormalLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNormalLowTemperature", ignore_extras);
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
        public static TypeNormalLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNormalLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNormalLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNormalLowTemperature", ignore_extras);
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
        public static TypeNormalLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNormalLowTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeNormalLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNormalLowTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNormalLowTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNormalLowTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNormalLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNormalLowTemperature", ignore_extras);
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
                TypeNormalLowTemperatureJSON result = new TypeNormalLowTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNormalLowTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNormalLowTemperatureJSON result)
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
            protected abstract void handle_result(TypeNormalLowTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeNormalLowTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNormalLowTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeNormalLowTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNormalLowTemperature class");
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
            protected override void handle_result(TypeNormalLowTemperatureJSON  result)
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
            public TypeNormalLowTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNormalLowTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeNormalLowTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNormalLowTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNormalLowTemperatureJSON>();
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
        public List<TypeNormalLowTemperatureJSON> value;
      };
      };
    public class TypeRecordHighTemperatureJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_TemperatureJSON  storeValue;
        private bool flagHasYear;
        private short storeYear;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            short extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Year of TypeRecordHighTemperatureJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Year of TypeRecordHighTemperatureJSON is not an integer.");
                  }
                extracted_integer = (short)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (short)(json_integer.getLongInt())            ;
              }
            setYear(extracted_integer);
          }


        public TypeRecordHighTemperatureJSON()
          {
            flagHasValue = false;
            flagHasYear = false;
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

        public bool  hasYear()
          {
            return flagHasYear;
          }

        public short  getYear()
          {
            Debug.Assert(flagHasYear);
            return storeYear;
          }


        public virtual int extraTypeRecordHighTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeRecordHighTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeRecordHighTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeRecordHighTemperatureLookup(string field_name)
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
        public void setYear(short new_value)
          {
            flagHasYear = true;
            if (new_value < 1600)
                throw new Exception("The value for field Year of TypeRecordHighTemperatureJSON is less than the lower bound (1600) for that field.");
            if (new_value > 2099)
                throw new Exception("The value for field Year of TypeRecordHighTemperatureJSON is greater than the upper bound (2099) for that field.");
            storeYear = new_value;
          }
        public void unsetYear()
          {
            flagHasYear = false;
          }

        public virtual void extraTypeRecordHighTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeRecordHighTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeRecordHighTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeRecordHighTemperatureAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasYear);
            if (flagHasYear)
              {
                handler.start_pair("Year");
                handler.number_value(storeYear);
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
            if (!(hasYear()))
              {
                return "When parsing the object for %what%, the \"Year\" field was missing.";
              }
            return null;
          }

        public static TypeRecordHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRecordHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRecordHighTemperature", ignore_extras);
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
        public static TypeRecordHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRecordHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRecordHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRecordHighTemperature", ignore_extras);
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
        public static TypeRecordHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRecordHighTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeRecordHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRecordHighTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeRecordHighTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeRecordHighTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeRecordHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRecordHighTemperature", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
        private class FieldHoldingGeneratorYear : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorYear(String what) : base(what, 1600, 2099)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorYear(String what) : base(what, 1600, 2099)
                  {
                  }
              };
            private FieldHoldingGeneratorYear fieldGeneratorYear;
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
                TypeRecordHighTemperatureJSON result = new TypeRecordHighTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeRecordHighTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeRecordHighTemperatureJSON result)
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
                if (fieldGeneratorYear.have_value)
                  {
                    result.setYear((short)(fieldGeneratorYear.value));
                    fieldGeneratorYear.have_value = false;
                  }
                else if ((!(result.hasYear())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Year\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeRecordHighTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    case 'Y':
                        if ((String.Compare(field_name, 1, "ear", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorYear;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeRecordHighTemperature class", ignore_extras);
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeRecordHighTemperature class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeRecordHighTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeRecordHighTemperature class", false);
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeRecordHighTemperature class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeRecordHighTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorYear.reset();
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
            protected override void handle_result(TypeRecordHighTemperatureJSON  result)
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
            public TypeRecordHighTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeRecordHighTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeRecordHighTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeRecordHighTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeRecordHighTemperatureJSON>();
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
        public List<TypeRecordHighTemperatureJSON> value;
      };
      };
    public class TypeRecordLowTemperatureJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_TemperatureJSON  storeValue;
        private bool flagHasYear;
        private short storeYear;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            short extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Year of TypeRecordLowTemperatureJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Year of TypeRecordLowTemperatureJSON is not an integer.");
                  }
                extracted_integer = (short)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (short)(json_integer.getLongInt())            ;
              }
            setYear(extracted_integer);
          }


        public TypeRecordLowTemperatureJSON()
          {
            flagHasValue = false;
            flagHasYear = false;
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

        public bool  hasYear()
          {
            return flagHasYear;
          }

        public short  getYear()
          {
            Debug.Assert(flagHasYear);
            return storeYear;
          }


        public virtual int extraTypeRecordLowTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeRecordLowTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeRecordLowTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeRecordLowTemperatureLookup(string field_name)
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
        public void setYear(short new_value)
          {
            flagHasYear = true;
            if (new_value < 1600)
                throw new Exception("The value for field Year of TypeRecordLowTemperatureJSON is less than the lower bound (1600) for that field.");
            if (new_value > 2099)
                throw new Exception("The value for field Year of TypeRecordLowTemperatureJSON is greater than the upper bound (2099) for that field.");
            storeYear = new_value;
          }
        public void unsetYear()
          {
            flagHasYear = false;
          }

        public virtual void extraTypeRecordLowTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeRecordLowTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeRecordLowTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeRecordLowTemperatureAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasYear);
            if (flagHasYear)
              {
                handler.start_pair("Year");
                handler.number_value(storeYear);
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
            if (!(hasYear()))
              {
                return "When parsing the object for %what%, the \"Year\" field was missing.";
              }
            return null;
          }

        public static TypeRecordLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRecordLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRecordLowTemperature", ignore_extras);
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
        public static TypeRecordLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRecordLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRecordLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRecordLowTemperature", ignore_extras);
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
        public static TypeRecordLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRecordLowTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeRecordLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRecordLowTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeRecordLowTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeRecordLowTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeRecordLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRecordLowTemperature", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
        private class FieldHoldingGeneratorYear : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorYear(String what) : base(what, 1600, 2099)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorYear(String what) : base(what, 1600, 2099)
                  {
                  }
              };
            private FieldHoldingGeneratorYear fieldGeneratorYear;
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
                TypeRecordLowTemperatureJSON result = new TypeRecordLowTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeRecordLowTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeRecordLowTemperatureJSON result)
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
                if (fieldGeneratorYear.have_value)
                  {
                    result.setYear((short)(fieldGeneratorYear.value));
                    fieldGeneratorYear.have_value = false;
                  }
                else if ((!(result.hasYear())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Year\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeRecordLowTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    case 'Y':
                        if ((String.Compare(field_name, 1, "ear", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorYear;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeRecordLowTemperature class", ignore_extras);
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeRecordLowTemperature class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeRecordLowTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeRecordLowTemperature class", false);
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeRecordLowTemperature class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeRecordLowTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorYear.reset();
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
            protected override void handle_result(TypeRecordLowTemperatureJSON  result)
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
            public TypeRecordLowTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeRecordLowTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeRecordLowTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeRecordLowTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeRecordLowTemperatureJSON>();
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
        public List<TypeRecordLowTemperatureJSON> value;
      };
      };
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasAlerts;
    private List< AlertJSON  > storeAlerts;
    private bool flagHasRequestedAlmanacAttribute;
    private WeatherAlmanacAttributeJSON  storeRequestedAlmanacAttribute;
    private bool flagHasAirportCode;
    private string storeAirportCode;
    private bool flagHasNormalHighTemperature;
    private TypeNormalHighTemperatureJSON  storeNormalHighTemperature;
    private bool flagHasNormalLowTemperature;
    private TypeNormalLowTemperatureJSON  storeNormalLowTemperature;
    private bool flagHasRecordHighTemperature;
    private TypeRecordHighTemperatureJSON  storeRecordHighTemperature;
    private bool flagHasRecordLowTemperature;
    private TypeRecordLowTemperatureJSON  storeRecordLowTemperature;
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

    private JSONValue  extraRequestedAlmanacAttributeToJSON()
      {
        JSONValueHandler handler_RequestedAlmanacAttribute = new JSONValueHandler();
        storeRequestedAlmanacAttribute.write_as_json(handler_RequestedAlmanacAttribute);
        return handler_RequestedAlmanacAttribute.result;
      }

    private JSONValue  extraAirportCodeToJSON()
      {
        JSONStringValue generated_string_AirportCode = new JSONStringValue(storeAirportCode);
        return generated_string_AirportCode;
      }

    private JSONValue  extraNormalHighTemperatureToJSON()
      {
        JSONValueHandler handler_NormalHighTemperature = new JSONValueHandler();
        storeNormalHighTemperature.write_as_json(handler_NormalHighTemperature);
        return handler_NormalHighTemperature.result;
      }

    private JSONValue  extraNormalLowTemperatureToJSON()
      {
        JSONValueHandler handler_NormalLowTemperature = new JSONValueHandler();
        storeNormalLowTemperature.write_as_json(handler_NormalLowTemperature);
        return handler_NormalLowTemperature.result;
      }

    private JSONValue  extraRecordHighTemperatureToJSON()
      {
        JSONValueHandler handler_RecordHighTemperature = new JSONValueHandler();
        storeRecordHighTemperature.write_as_json(handler_RecordHighTemperature);
        return handler_RecordHighTemperature.result;
      }

    private JSONValue  extraRecordLowTemperatureToJSON()
      {
        JSONValueHandler handler_RecordLowTemperature = new JSONValueHandler();
        storeRecordLowTemperature.write_as_json(handler_RecordLowTemperature);
        return handler_RecordLowTemperature.result;
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


    private void  fromJSONAlerts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Alerts of ShowWeatherAlmanacInformationNuggetJSON is not an array.");
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


    private void  fromJSONRequestedAlmanacAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherAlmanacAttributeJSON convert_classy = WeatherAlmanacAttributeJSON.from_json(json_value, ignore_extras, true);
        setRequestedAlmanacAttribute(convert_classy);
      }


    private void  fromJSONAirportCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AirportCode of ShowWeatherAlmanacInformationNuggetJSON is not a string.");
        setAirportCode(json_string.getData());
      }


    private void  fromJSONNormalHighTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNormalHighTemperatureJSON convert_classy = TypeNormalHighTemperatureJSON.from_json(json_value, ignore_extras, true);
        setNormalHighTemperature(convert_classy);
      }


    private void  fromJSONNormalLowTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNormalLowTemperatureJSON convert_classy = TypeNormalLowTemperatureJSON.from_json(json_value, ignore_extras, true);
        setNormalLowTemperature(convert_classy);
      }


    private void  fromJSONRecordHighTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeRecordHighTemperatureJSON convert_classy = TypeRecordHighTemperatureJSON.from_json(json_value, ignore_extras, true);
        setRecordHighTemperature(convert_classy);
      }


    private void  fromJSONRecordLowTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeRecordLowTemperatureJSON convert_classy = TypeRecordLowTemperatureJSON.from_json(json_value, ignore_extras, true);
        setRecordLowTemperature(convert_classy);
      }


    public ShowWeatherAlmanacInformationNuggetJSON()
      {
        flagHasAttribution = false;
        flagHasLocation = false;
        flagHasAlerts = false;
        flagHasRequestedAlmanacAttribute = false;
        flagHasAirportCode = false;
        flagHasNormalHighTemperature = false;
        flagHasNormalLowTemperature = false;
        flagHasRecordHighTemperature = false;
        flagHasRecordLowTemperature = false;
        storeAlerts = new List< AlertJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getWeatherNuggetKind()
      {
        return "WeatherAlmanac";
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

    public bool  hasRequestedAlmanacAttribute()
      {
        return flagHasRequestedAlmanacAttribute;
      }

    public WeatherAlmanacAttributeJSON   getRequestedAlmanacAttribute()
      {
        Debug.Assert(flagHasRequestedAlmanacAttribute);
        return storeRequestedAlmanacAttribute;
      }

    public WeatherAlmanacAttributeJSON.TypeValue  getRequestedAlmanacAttributeValue()
      {
        return getRequestedAlmanacAttribute().getValue();
      }

    public string  getRequestedAlmanacAttributeAsString()
      {
        return getRequestedAlmanacAttribute().getValueAsString();
      }

    public bool  hasAirportCode()
      {
        return flagHasAirportCode;
      }

    public string  getAirportCode()
      {
        Debug.Assert(flagHasAirportCode);
        return storeAirportCode;
      }

    public bool  hasNormalHighTemperature()
      {
        return flagHasNormalHighTemperature;
      }

    public TypeNormalHighTemperatureJSON   getNormalHighTemperature()
      {
        Debug.Assert(flagHasNormalHighTemperature);
        return storeNormalHighTemperature;
      }

    public bool  hasNormalLowTemperature()
      {
        return flagHasNormalLowTemperature;
      }

    public TypeNormalLowTemperatureJSON   getNormalLowTemperature()
      {
        Debug.Assert(flagHasNormalLowTemperature);
        return storeNormalLowTemperature;
      }

    public bool  hasRecordHighTemperature()
      {
        return flagHasRecordHighTemperature;
      }

    public TypeRecordHighTemperatureJSON   getRecordHighTemperature()
      {
        Debug.Assert(flagHasRecordHighTemperature);
        return storeRecordHighTemperature;
      }

    public bool  hasRecordLowTemperature()
      {
        return flagHasRecordLowTemperature;
      }

    public TypeRecordLowTemperatureJSON   getRecordLowTemperature()
      {
        Debug.Assert(flagHasRecordLowTemperature);
        return storeRecordLowTemperature;
      }


    public virtual int extraShowWeatherAlmanacInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraShowWeatherAlmanacInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraShowWeatherAlmanacInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraShowWeatherAlmanacInformationNuggetLookup(string field_name)
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
        if (flagHasAlerts)
            ++result;
        if (flagHasRequestedAlmanacAttribute)
            ++result;
        if (flagHasAirportCode)
            ++result;
        if (flagHasNormalHighTemperature)
            ++result;
        if (flagHasNormalLowTemperature)
            ++result;
        if (flagHasRecordHighTemperature)
            ++result;
        if (flagHasRecordLowTemperature)
            ++result;
        result += extraShowWeatherAlmanacInformationNuggetComponentCount();
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
        if (flagHasAlerts)
          {
            if (remainder == 0)
                return "Alerts";
            --remainder;
          }
        if (flagHasRequestedAlmanacAttribute)
          {
            if (remainder == 0)
                return "RequestedAlmanacAttribute";
            --remainder;
          }
        if (flagHasAirportCode)
          {
            if (remainder == 0)
                return "AirportCode";
            --remainder;
          }
        if (flagHasNormalHighTemperature)
          {
            if (remainder == 0)
                return "NormalHighTemperature";
            --remainder;
          }
        if (flagHasNormalLowTemperature)
          {
            if (remainder == 0)
                return "NormalLowTemperature";
            --remainder;
          }
        if (flagHasRecordHighTemperature)
          {
            if (remainder == 0)
                return "RecordHighTemperature";
            --remainder;
          }
        if (flagHasRecordLowTemperature)
          {
            if (remainder == 0)
                return "RecordLowTemperature";
            --remainder;
          }
        return extraShowWeatherAlmanacInformationNuggetComponentKey(remainder);
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
        if (flagHasAlerts)
          {
            if (remainder == 0)
                return extraAlertsToJSON();
            --remainder;
          }
        if (flagHasRequestedAlmanacAttribute)
          {
            if (remainder == 0)
                return extraRequestedAlmanacAttributeToJSON();
            --remainder;
          }
        if (flagHasAirportCode)
          {
            if (remainder == 0)
                return extraAirportCodeToJSON();
            --remainder;
          }
        if (flagHasNormalHighTemperature)
          {
            if (remainder == 0)
                return extraNormalHighTemperatureToJSON();
            --remainder;
          }
        if (flagHasNormalLowTemperature)
          {
            if (remainder == 0)
                return extraNormalLowTemperatureToJSON();
            --remainder;
          }
        if (flagHasRecordHighTemperature)
          {
            if (remainder == 0)
                return extraRecordHighTemperatureToJSON();
            --remainder;
          }
        if (flagHasRecordLowTemperature)
          {
            if (remainder == 0)
                return extraRecordLowTemperatureToJSON();
            --remainder;
          }
        return extraShowWeatherAlmanacInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraWeatherInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 'i':
                        if ((String.Compare(field_name, 2, "rportCode", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasAirportCode ? extraAirportCodeToJSON() : null);
                        break;
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
            case 'L':
                if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasLocation ? extraLocationToJSON() : null);
                break;
            case 'N':
                if (String.Compare(field_name, 1, "ormal", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'H':
                            if ((String.Compare(field_name, 7, "ighTemperature", 0, 14, false) == 0) && (field_name.Length == 21))
                                return (flagHasNormalHighTemperature ? extraNormalHighTemperatureToJSON() : null);
                            break;
                        case 'L':
                            if ((String.Compare(field_name, 7, "owTemperature", 0, 13, false) == 0) && (field_name.Length == 20))
                                return (flagHasNormalLowTemperature ? extraNormalLowTemperatureToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'c':
                            if (String.Compare(field_name, 3, "ord", 0, 3, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'H':
                                        if ((String.Compare(field_name, 7, "ighTemperature", 0, 14, false) == 0) && (field_name.Length == 21))
                                            return (flagHasRecordHighTemperature ? extraRecordHighTemperatureToJSON() : null);
                                        break;
                                    case 'L':
                                        if ((String.Compare(field_name, 7, "owTemperature", 0, 13, false) == 0) && (field_name.Length == 20))
                                            return (flagHasRecordLowTemperature ? extraRecordLowTemperatureToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'q':
                            if ((String.Compare(field_name, 3, "uestedAlmanacAttribute", 0, 22, false) == 0) && (field_name.Length == 25))
                                return (flagHasRequestedAlmanacAttribute ? extraRequestedAlmanacAttributeToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraShowWeatherAlmanacInformationNuggetLookup(field_name);
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
    public void setRequestedAlmanacAttribute(WeatherAlmanacAttributeJSON  new_value)
      {
        if (flagHasRequestedAlmanacAttribute)
          {
          }
        flagHasRequestedAlmanacAttribute = true;
        storeRequestedAlmanacAttribute = new_value;
      }
    public void setRequestedAlmanacAttribute(WeatherAlmanacAttributeJSON.TypeValue new_value)
      {
        setRequestedAlmanacAttribute(new WeatherAlmanacAttributeJSON(new_value));
      }
    public void setRequestedAlmanacAttribute(string chars)
      {
        WeatherAlmanacAttributeJSON.TypeValueKnownValues known = WeatherAlmanacAttributeJSON.stringToValue(chars);
        WeatherAlmanacAttributeJSON.TypeValue new_value = new WeatherAlmanacAttributeJSON.TypeValue();
        if (known == WeatherAlmanacAttributeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRequestedAlmanacAttribute(new_value);
      }
    public void unsetRequestedAlmanacAttribute()
      {
        if (flagHasRequestedAlmanacAttribute)
          {
          }
        flagHasRequestedAlmanacAttribute = false;
      }
    public void setAirportCode(string new_value)
      {
        flagHasAirportCode = true;
        storeAirportCode = new_value;
      }
    public void unsetAirportCode()
      {
        flagHasAirportCode = false;
      }
    public void setNormalHighTemperature(TypeNormalHighTemperatureJSON  new_value)
      {
        if (flagHasNormalHighTemperature)
          {
          }
        flagHasNormalHighTemperature = true;
        storeNormalHighTemperature = new_value;
      }
    public void unsetNormalHighTemperature()
      {
        if (flagHasNormalHighTemperature)
          {
          }
        flagHasNormalHighTemperature = false;
      }
    public void setNormalLowTemperature(TypeNormalLowTemperatureJSON  new_value)
      {
        if (flagHasNormalLowTemperature)
          {
          }
        flagHasNormalLowTemperature = true;
        storeNormalLowTemperature = new_value;
      }
    public void unsetNormalLowTemperature()
      {
        if (flagHasNormalLowTemperature)
          {
          }
        flagHasNormalLowTemperature = false;
      }
    public void setRecordHighTemperature(TypeRecordHighTemperatureJSON  new_value)
      {
        if (flagHasRecordHighTemperature)
          {
          }
        flagHasRecordHighTemperature = true;
        storeRecordHighTemperature = new_value;
      }
    public void unsetRecordHighTemperature()
      {
        if (flagHasRecordHighTemperature)
          {
          }
        flagHasRecordHighTemperature = false;
      }
    public void setRecordLowTemperature(TypeRecordLowTemperatureJSON  new_value)
      {
        if (flagHasRecordLowTemperature)
          {
          }
        flagHasRecordLowTemperature = true;
        storeRecordLowTemperature = new_value;
      }
    public void unsetRecordLowTemperature()
      {
        if (flagHasRecordLowTemperature)
          {
          }
        flagHasRecordLowTemperature = false;
      }

    public virtual void extraShowWeatherAlmanacInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraShowWeatherAlmanacInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraShowWeatherAlmanacInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraShowWeatherAlmanacInformationNuggetAppendPair(key, new_component);
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
                    case 'i':
                        if ((String.Compare(key, 2, "rportCode", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONAirportCode(new_component, false);
                            return;
                            }
                        break;
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
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if (String.Compare(key, 1, "ormal", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'H':
                            if ((String.Compare(key, 7, "ighTemperature", 0, 14, false) == 0) && (key.Length == 21))
                                {
                                fromJSONNormalHighTemperature(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 7, "owTemperature", 0, 13, false) == 0) && (key.Length == 20))
                                {
                                fromJSONNormalLowTemperature(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(key, 1, "e", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'c':
                            if (String.Compare(key, 3, "ord", 0, 3, false) == 0)
                              {
                                switch (key[6])
                                  {
                                    case 'H':
                                        if ((String.Compare(key, 7, "ighTemperature", 0, 14, false) == 0) && (key.Length == 21))
                                            {
                                            fromJSONRecordHighTemperature(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'L':
                                        if ((String.Compare(key, 7, "owTemperature", 0, 13, false) == 0) && (key.Length == 20))
                                            {
                                            fromJSONRecordLowTemperature(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'q':
                            if ((String.Compare(key, 3, "uestedAlmanacAttribute", 0, 22, false) == 0) && (key.Length == 25))
                                {
                                fromJSONRequestedAlmanacAttribute(new_component, false);
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
        extraShowWeatherAlmanacInformationNuggetAppendPair(key, new_component);
      }
    public override void extraWeatherInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'i':
                        if ((String.Compare(key, 2, "rportCode", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONAirportCode(new_component, false);
                            return;
                            }
                        break;
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
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if (String.Compare(key, 1, "ormal", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'H':
                            if ((String.Compare(key, 7, "ighTemperature", 0, 14, false) == 0) && (key.Length == 21))
                                {
                                fromJSONNormalHighTemperature(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 7, "owTemperature", 0, 13, false) == 0) && (key.Length == 20))
                                {
                                fromJSONNormalLowTemperature(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(key, 1, "e", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'c':
                            if (String.Compare(key, 3, "ord", 0, 3, false) == 0)
                              {
                                switch (key[6])
                                  {
                                    case 'H':
                                        if ((String.Compare(key, 7, "ighTemperature", 0, 14, false) == 0) && (key.Length == 21))
                                            {
                                            fromJSONRecordHighTemperature(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'L':
                                        if ((String.Compare(key, 7, "owTemperature", 0, 13, false) == 0) && (key.Length == 20))
                                            {
                                            fromJSONRecordLowTemperature(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'q':
                            if ((String.Compare(key, 3, "uestedAlmanacAttribute", 0, 22, false) == 0) && (key.Length == 25))
                                {
                                fromJSONRequestedAlmanacAttribute(new_component, false);
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
        extraShowWeatherAlmanacInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRequestedAlmanacAttribute);
        if (flagHasRequestedAlmanacAttribute)
          {
            handler.start_pair("RequestedAlmanacAttribute");
            if (partial_allowed)
                storeRequestedAlmanacAttribute.write_partial_as_json(handler);
            else
                storeRequestedAlmanacAttribute.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasAirportCode);
        if (flagHasAirportCode)
          {
            handler.start_pair("AirportCode");
            handler.string_value(storeAirportCode);
          }
        Debug.Assert(partial_allowed || flagHasNormalHighTemperature);
        if (flagHasNormalHighTemperature)
          {
            handler.start_pair("NormalHighTemperature");
            if (partial_allowed)
                storeNormalHighTemperature.write_partial_as_json(handler);
            else
                storeNormalHighTemperature.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasNormalLowTemperature);
        if (flagHasNormalLowTemperature)
          {
            handler.start_pair("NormalLowTemperature");
            if (partial_allowed)
                storeNormalLowTemperature.write_partial_as_json(handler);
            else
                storeNormalLowTemperature.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRecordHighTemperature);
        if (flagHasRecordHighTemperature)
          {
            handler.start_pair("RecordHighTemperature");
            if (partial_allowed)
                storeRecordHighTemperature.write_partial_as_json(handler);
            else
                storeRecordHighTemperature.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRecordLowTemperature);
        if (flagHasRecordLowTemperature)
          {
            handler.start_pair("RecordLowTemperature");
            if (partial_allowed)
                storeRecordLowTemperature.write_partial_as_json(handler);
            else
                storeRecordLowTemperature.write_as_json(handler);
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
        if (!(hasAlerts()))
          {
            return "When parsing the object for %what%, the \"Alerts\" field was missing.";
          }
        if (!(hasRequestedAlmanacAttribute()))
          {
            return "When parsing the object for %what%, the \"RequestedAlmanacAttribute\" field was missing.";
          }
        if (!(hasAirportCode()))
          {
            return "When parsing the object for %what%, the \"AirportCode\" field was missing.";
          }
        if (!(hasNormalHighTemperature()))
          {
            return "When parsing the object for %what%, the \"NormalHighTemperature\" field was missing.";
          }
        if (!(hasNormalLowTemperature()))
          {
            return "When parsing the object for %what%, the \"NormalLowTemperature\" field was missing.";
          }
        if (!(hasRecordHighTemperature()))
          {
            return "When parsing the object for %what%, the \"RecordHighTemperature\" field was missing.";
          }
        if (!(hasRecordLowTemperature()))
          {
            return "When parsing the object for %what%, the \"RecordLowTemperature\" field was missing.";
          }
        return null;
      }

    public static new ShowWeatherAlmanacInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWeatherAlmanacInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherAlmanacInformationNugget", ignore_extras);
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
    public static new ShowWeatherAlmanacInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWeatherAlmanacInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWeatherAlmanacInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherAlmanacInformationNugget", ignore_extras);
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
    public static new ShowWeatherAlmanacInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWeatherAlmanacInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ShowWeatherAlmanacInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherAlmanacInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ShowWeatherAlmanacInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ShowWeatherAlmanacInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ShowWeatherAlmanacInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherAlmanacInformationNugget", ignore_extras);
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
        private AlertJSON.HoldingArrayGenerator fieldGeneratorAlerts;
        private WeatherAlmanacAttributeJSON.HoldingGenerator fieldGeneratorRequestedAlmanacAttribute;
        private JSONHoldingStringGenerator fieldGeneratorAirportCode;
        private TypeNormalHighTemperatureJSON.HoldingGenerator fieldGeneratorNormalHighTemperature;
        private TypeNormalLowTemperatureJSON.HoldingGenerator fieldGeneratorNormalLowTemperature;
        private TypeRecordHighTemperatureJSON.HoldingGenerator fieldGeneratorRecordHighTemperature;
        private TypeRecordLowTemperatureJSON.HoldingGenerator fieldGeneratorRecordLowTemperature;
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
            if (!(getWeatherInformationNuggetJSONKey().Equals("WeatherAlmanac")))
                throw new Exception("The key field has a value other than `WeatherAlmanac'.");
            ShowWeatherAlmanacInformationNuggetJSON result = new ShowWeatherAlmanacInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraShowWeatherAlmanacInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(WeatherInformationNuggetJSON new_result)
          {
            handle_result((ShowWeatherAlmanacInformationNuggetJSON )new_result);
          }
        protected void finish(ShowWeatherAlmanacInformationNuggetJSON result)
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
            if (fieldGeneratorRequestedAlmanacAttribute.have_value)
              {
                result.setRequestedAlmanacAttribute(fieldGeneratorRequestedAlmanacAttribute.value);
                fieldGeneratorRequestedAlmanacAttribute.have_value = false;
              }
            else if ((!(result.hasRequestedAlmanacAttribute())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedAlmanacAttribute\" field was missing.");
              }
            if (fieldGeneratorAirportCode.have_value)
              {
                result.setAirportCode(fieldGeneratorAirportCode.value);
                fieldGeneratorAirportCode.have_value = false;
              }
            else if ((!(result.hasAirportCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AirportCode\" field was missing.");
              }
            if (fieldGeneratorNormalHighTemperature.have_value)
              {
                result.setNormalHighTemperature(fieldGeneratorNormalHighTemperature.value);
                fieldGeneratorNormalHighTemperature.have_value = false;
              }
            else if ((!(result.hasNormalHighTemperature())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NormalHighTemperature\" field was missing.");
              }
            if (fieldGeneratorNormalLowTemperature.have_value)
              {
                result.setNormalLowTemperature(fieldGeneratorNormalLowTemperature.value);
                fieldGeneratorNormalLowTemperature.have_value = false;
              }
            else if ((!(result.hasNormalLowTemperature())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NormalLowTemperature\" field was missing.");
              }
            if (fieldGeneratorRecordHighTemperature.have_value)
              {
                result.setRecordHighTemperature(fieldGeneratorRecordHighTemperature.value);
                fieldGeneratorRecordHighTemperature.have_value = false;
              }
            else if ((!(result.hasRecordHighTemperature())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RecordHighTemperature\" field was missing.");
              }
            if (fieldGeneratorRecordLowTemperature.have_value)
              {
                result.setRecordLowTemperature(fieldGeneratorRecordLowTemperature.value);
                fieldGeneratorRecordLowTemperature.have_value = false;
              }
            else if ((!(result.hasRecordLowTemperature())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RecordLowTemperature\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ShowWeatherAlmanacInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "rportCode", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAirportCode;
                            break;
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
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "ormal", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'H':
                                if ((String.Compare(field_name, 7, "ighTemperature", 0, 14, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorNormalHighTemperature;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 7, "owTemperature", 0, 13, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorNormalLowTemperature;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'c':
                                if (String.Compare(field_name, 3, "ord", 0, 3, false) == 0)
                                  {
                                    switch (field_name[6])
                                      {
                                        case 'H':
                                            if ((String.Compare(field_name, 7, "ighTemperature", 0, 14, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratorRecordHighTemperature;
                                            break;
                                        case 'L':
                                            if ((String.Compare(field_name, 7, "owTemperature", 0, 13, false) == 0) && (field_name.Length == 20))
                                                return fieldGeneratorRecordLowTemperature;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'q':
                                if ((String.Compare(field_name, 3, "uestedAlmanacAttribute", 0, 22, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorRequestedAlmanacAttribute;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the ShowWeatherAlmanacInformationNugget class", ignore_extras);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the ShowWeatherAlmanacInformationNugget class", ignore_extras);
            fieldGeneratorAlerts = new AlertJSON.HoldingArrayGenerator("field \"Alerts\" of the ShowWeatherAlmanacInformationNugget class", ignore_extras);
            fieldGeneratorRequestedAlmanacAttribute = new WeatherAlmanacAttributeJSON.HoldingGenerator("field \"RequestedAlmanacAttribute\" of the ShowWeatherAlmanacInformationNugget class", ignore_extras);
            fieldGeneratorAirportCode = new JSONHoldingStringGenerator("field \"AirportCode\" of the ShowWeatherAlmanacInformationNugget class");
            fieldGeneratorNormalHighTemperature = new TypeNormalHighTemperatureJSON.HoldingGenerator("field \"NormalHighTemperature\" of the ShowWeatherAlmanacInformationNugget class", ignore_extras);
            fieldGeneratorNormalLowTemperature = new TypeNormalLowTemperatureJSON.HoldingGenerator("field \"NormalLowTemperature\" of the ShowWeatherAlmanacInformationNugget class", ignore_extras);
            fieldGeneratorRecordHighTemperature = new TypeRecordHighTemperatureJSON.HoldingGenerator("field \"RecordHighTemperature\" of the ShowWeatherAlmanacInformationNugget class", ignore_extras);
            fieldGeneratorRecordLowTemperature = new TypeRecordLowTemperatureJSON.HoldingGenerator("field \"RecordLowTemperature\" of the ShowWeatherAlmanacInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ShowWeatherAlmanacInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the ShowWeatherAlmanacInformationNugget class", false);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the ShowWeatherAlmanacInformationNugget class", false);
            fieldGeneratorAlerts = new AlertJSON.HoldingArrayGenerator("field \"Alerts\" of the ShowWeatherAlmanacInformationNugget class", false);
            fieldGeneratorRequestedAlmanacAttribute = new WeatherAlmanacAttributeJSON.HoldingGenerator("field \"RequestedAlmanacAttribute\" of the ShowWeatherAlmanacInformationNugget class", false);
            fieldGeneratorAirportCode = new JSONHoldingStringGenerator("field \"AirportCode\" of the ShowWeatherAlmanacInformationNugget class");
            fieldGeneratorNormalHighTemperature = new TypeNormalHighTemperatureJSON.HoldingGenerator("field \"NormalHighTemperature\" of the ShowWeatherAlmanacInformationNugget class", false);
            fieldGeneratorNormalLowTemperature = new TypeNormalLowTemperatureJSON.HoldingGenerator("field \"NormalLowTemperature\" of the ShowWeatherAlmanacInformationNugget class", false);
            fieldGeneratorRecordHighTemperature = new TypeRecordHighTemperatureJSON.HoldingGenerator("field \"RecordHighTemperature\" of the ShowWeatherAlmanacInformationNugget class", false);
            fieldGeneratorRecordLowTemperature = new TypeRecordLowTemperatureJSON.HoldingGenerator("field \"RecordLowTemperature\" of the ShowWeatherAlmanacInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ShowWeatherAlmanacInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAttribution.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorAlerts.reset();
            fieldGeneratorRequestedAlmanacAttribute.reset();
            fieldGeneratorAirportCode.reset();
            fieldGeneratorNormalHighTemperature.reset();
            fieldGeneratorNormalLowTemperature.reset();
            fieldGeneratorRecordHighTemperature.reset();
            fieldGeneratorRecordLowTemperature.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ShowWeatherAlmanacInformationNuggetJSON  result)
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
        public ShowWeatherAlmanacInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ShowWeatherAlmanacInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ShowWeatherAlmanacInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ShowWeatherAlmanacInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ShowWeatherAlmanacInformationNuggetJSON>();
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
    public List<ShowWeatherAlmanacInformationNuggetJSON> value;
  };
  };
