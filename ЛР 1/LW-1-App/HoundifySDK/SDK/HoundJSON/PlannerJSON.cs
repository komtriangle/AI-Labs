/* file "PlannerJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PlannerJSON : JSONBase
  {
    public class TypeMinHighTemperatureJSON : JSONBase
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


        public TypeMinHighTemperatureJSON()
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


        public virtual int extraTypeMinHighTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMinHighTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMinHighTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMinHighTemperatureLookup(string field_name)
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

        public virtual void extraTypeMinHighTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMinHighTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMinHighTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeMinHighTemperatureAppendPair(key, new_component);
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

        public static TypeMinHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMinHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinHighTemperature", ignore_extras);
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
        public static TypeMinHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMinHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMinHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinHighTemperature", ignore_extras);
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
        public static TypeMinHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMinHighTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeMinHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinHighTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMinHighTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMinHighTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMinHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinHighTemperature", ignore_extras);
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
                TypeMinHighTemperatureJSON result = new TypeMinHighTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMinHighTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMinHighTemperatureJSON result)
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
            protected abstract void handle_result(TypeMinHighTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinHighTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMinHighTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinHighTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMinHighTemperature class");
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
            protected override void handle_result(TypeMinHighTemperatureJSON  result)
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
            public TypeMinHighTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMinHighTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeMinHighTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMinHighTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMinHighTemperatureJSON>();
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
        public List<TypeMinHighTemperatureJSON> value;
      };
      };
    public class TypeAvgHighTemperatureJSON : JSONBase
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


        public TypeAvgHighTemperatureJSON()
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


        public virtual int extraTypeAvgHighTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAvgHighTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAvgHighTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAvgHighTemperatureLookup(string field_name)
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

        public virtual void extraTypeAvgHighTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAvgHighTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAvgHighTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeAvgHighTemperatureAppendPair(key, new_component);
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

        public static TypeAvgHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAvgHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgHighTemperature", ignore_extras);
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
        public static TypeAvgHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAvgHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAvgHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgHighTemperature", ignore_extras);
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
        public static TypeAvgHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAvgHighTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeAvgHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgHighTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAvgHighTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAvgHighTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAvgHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgHighTemperature", ignore_extras);
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
                TypeAvgHighTemperatureJSON result = new TypeAvgHighTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAvgHighTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAvgHighTemperatureJSON result)
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
            protected abstract void handle_result(TypeAvgHighTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgHighTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAvgHighTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgHighTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAvgHighTemperature class");
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
            protected override void handle_result(TypeAvgHighTemperatureJSON  result)
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
            public TypeAvgHighTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAvgHighTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeAvgHighTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAvgHighTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAvgHighTemperatureJSON>();
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
        public List<TypeAvgHighTemperatureJSON> value;
      };
      };
    public class TypeMaxHighTemperatureJSON : JSONBase
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


        public TypeMaxHighTemperatureJSON()
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


        public virtual int extraTypeMaxHighTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMaxHighTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMaxHighTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMaxHighTemperatureLookup(string field_name)
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

        public virtual void extraTypeMaxHighTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMaxHighTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMaxHighTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeMaxHighTemperatureAppendPair(key, new_component);
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

        public static TypeMaxHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMaxHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxHighTemperature", ignore_extras);
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
        public static TypeMaxHighTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMaxHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMaxHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxHighTemperature", ignore_extras);
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
        public static TypeMaxHighTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMaxHighTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeMaxHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxHighTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMaxHighTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMaxHighTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMaxHighTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxHighTemperature", ignore_extras);
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
                TypeMaxHighTemperatureJSON result = new TypeMaxHighTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMaxHighTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMaxHighTemperatureJSON result)
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
            protected abstract void handle_result(TypeMaxHighTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxHighTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMaxHighTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxHighTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMaxHighTemperature class");
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
            protected override void handle_result(TypeMaxHighTemperatureJSON  result)
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
            public TypeMaxHighTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMaxHighTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeMaxHighTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMaxHighTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMaxHighTemperatureJSON>();
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
        public List<TypeMaxHighTemperatureJSON> value;
      };
      };
    public class TypeMinLowTemperatureJSON : JSONBase
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


        public TypeMinLowTemperatureJSON()
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


        public virtual int extraTypeMinLowTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMinLowTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMinLowTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMinLowTemperatureLookup(string field_name)
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

        public virtual void extraTypeMinLowTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMinLowTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMinLowTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeMinLowTemperatureAppendPair(key, new_component);
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

        public static TypeMinLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMinLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinLowTemperature", ignore_extras);
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
        public static TypeMinLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMinLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMinLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinLowTemperature", ignore_extras);
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
        public static TypeMinLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMinLowTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeMinLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinLowTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMinLowTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMinLowTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMinLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinLowTemperature", ignore_extras);
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
                TypeMinLowTemperatureJSON result = new TypeMinLowTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMinLowTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMinLowTemperatureJSON result)
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
            protected abstract void handle_result(TypeMinLowTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinLowTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMinLowTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinLowTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMinLowTemperature class");
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
            protected override void handle_result(TypeMinLowTemperatureJSON  result)
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
            public TypeMinLowTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMinLowTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeMinLowTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMinLowTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMinLowTemperatureJSON>();
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
        public List<TypeMinLowTemperatureJSON> value;
      };
      };
    public class TypeAvgLowTemperatureJSON : JSONBase
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


        public TypeAvgLowTemperatureJSON()
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


        public virtual int extraTypeAvgLowTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAvgLowTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAvgLowTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAvgLowTemperatureLookup(string field_name)
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

        public virtual void extraTypeAvgLowTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAvgLowTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAvgLowTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeAvgLowTemperatureAppendPair(key, new_component);
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

        public static TypeAvgLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAvgLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgLowTemperature", ignore_extras);
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
        public static TypeAvgLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAvgLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAvgLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgLowTemperature", ignore_extras);
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
        public static TypeAvgLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAvgLowTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeAvgLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgLowTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAvgLowTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAvgLowTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAvgLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgLowTemperature", ignore_extras);
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
                TypeAvgLowTemperatureJSON result = new TypeAvgLowTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAvgLowTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAvgLowTemperatureJSON result)
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
            protected abstract void handle_result(TypeAvgLowTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgLowTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAvgLowTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgLowTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAvgLowTemperature class");
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
            protected override void handle_result(TypeAvgLowTemperatureJSON  result)
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
            public TypeAvgLowTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAvgLowTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeAvgLowTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAvgLowTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAvgLowTemperatureJSON>();
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
        public List<TypeAvgLowTemperatureJSON> value;
      };
      };
    public class TypeMaxLowTemperatureJSON : JSONBase
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


        public TypeMaxLowTemperatureJSON()
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


        public virtual int extraTypeMaxLowTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMaxLowTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMaxLowTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMaxLowTemperatureLookup(string field_name)
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

        public virtual void extraTypeMaxLowTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMaxLowTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMaxLowTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeMaxLowTemperatureAppendPair(key, new_component);
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

        public static TypeMaxLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMaxLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxLowTemperature", ignore_extras);
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
        public static TypeMaxLowTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMaxLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMaxLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxLowTemperature", ignore_extras);
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
        public static TypeMaxLowTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMaxLowTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeMaxLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxLowTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMaxLowTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMaxLowTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMaxLowTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxLowTemperature", ignore_extras);
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
                TypeMaxLowTemperatureJSON result = new TypeMaxLowTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMaxLowTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMaxLowTemperatureJSON result)
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
            protected abstract void handle_result(TypeMaxLowTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxLowTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMaxLowTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxLowTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMaxLowTemperature class");
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
            protected override void handle_result(TypeMaxLowTemperatureJSON  result)
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
            public TypeMaxLowTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMaxLowTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeMaxLowTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMaxLowTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMaxLowTemperatureJSON>();
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
        public List<TypeMaxLowTemperatureJSON> value;
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
    public class TypeMinPrecipitationJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_PlannerPrecipitationJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_PlannerPrecipitationJSON convert_classy = UnitsValue_PlannerPrecipitationJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeMinPrecipitationJSON()
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

        public UnitsValue_PlannerPrecipitationJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeMinPrecipitationComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMinPrecipitationComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMinPrecipitationComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMinPrecipitationLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_PlannerPrecipitationJSON  new_value)
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

        public virtual void extraTypeMinPrecipitationAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMinPrecipitationSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMinPrecipitationLookup(key);
            if (old_field == null)
              {
                extraTypeMinPrecipitationAppendPair(key, new_component);
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

        public static TypeMinPrecipitationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMinPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinPrecipitation", ignore_extras);
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
        public static TypeMinPrecipitationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMinPrecipitationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMinPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinPrecipitation", ignore_extras);
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
        public static TypeMinPrecipitationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMinPrecipitationJSON from_text(string text, bool ignore_extras)
          {
            TypeMinPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinPrecipitation", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMinPrecipitationJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMinPrecipitationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMinPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinPrecipitation", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_PlannerPrecipitationJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeMinPrecipitationJSON result = new TypeMinPrecipitationJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMinPrecipitationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMinPrecipitationJSON result)
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
            protected abstract void handle_result(TypeMinPrecipitationJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PlannerPrecipitationJSON.HoldingGenerator("field \"Value\" of the TypeMinPrecipitation class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMinPrecipitation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PlannerPrecipitationJSON.HoldingGenerator("field \"Value\" of the TypeMinPrecipitation class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMinPrecipitation class");
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
            protected override void handle_result(TypeMinPrecipitationJSON  result)
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
            public TypeMinPrecipitationJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMinPrecipitationJSON  result)
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
        protected virtual void handle_result(List<TypeMinPrecipitationJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMinPrecipitationJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMinPrecipitationJSON>();
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
        public List<TypeMinPrecipitationJSON> value;
      };
      };
    public class TypeAvgPrecipitationJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_PlannerPrecipitationJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_PlannerPrecipitationJSON convert_classy = UnitsValue_PlannerPrecipitationJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeAvgPrecipitationJSON()
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

        public UnitsValue_PlannerPrecipitationJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeAvgPrecipitationComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAvgPrecipitationComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAvgPrecipitationComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAvgPrecipitationLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_PlannerPrecipitationJSON  new_value)
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

        public virtual void extraTypeAvgPrecipitationAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAvgPrecipitationSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAvgPrecipitationLookup(key);
            if (old_field == null)
              {
                extraTypeAvgPrecipitationAppendPair(key, new_component);
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

        public static TypeAvgPrecipitationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAvgPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgPrecipitation", ignore_extras);
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
        public static TypeAvgPrecipitationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAvgPrecipitationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAvgPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgPrecipitation", ignore_extras);
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
        public static TypeAvgPrecipitationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAvgPrecipitationJSON from_text(string text, bool ignore_extras)
          {
            TypeAvgPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgPrecipitation", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAvgPrecipitationJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAvgPrecipitationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAvgPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgPrecipitation", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_PlannerPrecipitationJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeAvgPrecipitationJSON result = new TypeAvgPrecipitationJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAvgPrecipitationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAvgPrecipitationJSON result)
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
            protected abstract void handle_result(TypeAvgPrecipitationJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PlannerPrecipitationJSON.HoldingGenerator("field \"Value\" of the TypeAvgPrecipitation class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAvgPrecipitation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PlannerPrecipitationJSON.HoldingGenerator("field \"Value\" of the TypeAvgPrecipitation class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAvgPrecipitation class");
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
            protected override void handle_result(TypeAvgPrecipitationJSON  result)
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
            public TypeAvgPrecipitationJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAvgPrecipitationJSON  result)
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
        protected virtual void handle_result(List<TypeAvgPrecipitationJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAvgPrecipitationJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAvgPrecipitationJSON>();
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
        public List<TypeAvgPrecipitationJSON> value;
      };
      };
    public class TypeMaxPrecipitationJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_PlannerPrecipitationJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_PlannerPrecipitationJSON convert_classy = UnitsValue_PlannerPrecipitationJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeMaxPrecipitationJSON()
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

        public UnitsValue_PlannerPrecipitationJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeMaxPrecipitationComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMaxPrecipitationComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMaxPrecipitationComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMaxPrecipitationLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_PlannerPrecipitationJSON  new_value)
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

        public virtual void extraTypeMaxPrecipitationAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMaxPrecipitationSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMaxPrecipitationLookup(key);
            if (old_field == null)
              {
                extraTypeMaxPrecipitationAppendPair(key, new_component);
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

        public static TypeMaxPrecipitationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMaxPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxPrecipitation", ignore_extras);
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
        public static TypeMaxPrecipitationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMaxPrecipitationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMaxPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxPrecipitation", ignore_extras);
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
        public static TypeMaxPrecipitationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMaxPrecipitationJSON from_text(string text, bool ignore_extras)
          {
            TypeMaxPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxPrecipitation", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMaxPrecipitationJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMaxPrecipitationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMaxPrecipitationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxPrecipitation", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_PlannerPrecipitationJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeMaxPrecipitationJSON result = new TypeMaxPrecipitationJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMaxPrecipitationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMaxPrecipitationJSON result)
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
            protected abstract void handle_result(TypeMaxPrecipitationJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PlannerPrecipitationJSON.HoldingGenerator("field \"Value\" of the TypeMaxPrecipitation class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMaxPrecipitation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PlannerPrecipitationJSON.HoldingGenerator("field \"Value\" of the TypeMaxPrecipitation class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMaxPrecipitation class");
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
            protected override void handle_result(TypeMaxPrecipitationJSON  result)
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
            public TypeMaxPrecipitationJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMaxPrecipitationJSON  result)
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
        protected virtual void handle_result(List<TypeMaxPrecipitationJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMaxPrecipitationJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMaxPrecipitationJSON>();
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
        public List<TypeMaxPrecipitationJSON> value;
      };
      };
    public class TypeMinHighDewPointJSON : JSONBase
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


        public TypeMinHighDewPointJSON()
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


        public virtual int extraTypeMinHighDewPointComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMinHighDewPointComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMinHighDewPointComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMinHighDewPointLookup(string field_name)
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

        public virtual void extraTypeMinHighDewPointAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMinHighDewPointSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMinHighDewPointLookup(key);
            if (old_field == null)
              {
                extraTypeMinHighDewPointAppendPair(key, new_component);
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

        public static TypeMinHighDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMinHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinHighDewPoint", ignore_extras);
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
        public static TypeMinHighDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMinHighDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMinHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinHighDewPoint", ignore_extras);
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
        public static TypeMinHighDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMinHighDewPointJSON from_text(string text, bool ignore_extras)
          {
            TypeMinHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinHighDewPoint", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMinHighDewPointJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMinHighDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMinHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinHighDewPoint", ignore_extras);
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
                TypeMinHighDewPointJSON result = new TypeMinHighDewPointJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMinHighDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMinHighDewPointJSON result)
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
            protected abstract void handle_result(TypeMinHighDewPointJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinHighDewPoint class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMinHighDewPoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinHighDewPoint class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMinHighDewPoint class");
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
            protected override void handle_result(TypeMinHighDewPointJSON  result)
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
            public TypeMinHighDewPointJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMinHighDewPointJSON  result)
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
        protected virtual void handle_result(List<TypeMinHighDewPointJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMinHighDewPointJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMinHighDewPointJSON>();
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
        public List<TypeMinHighDewPointJSON> value;
      };
      };
    public class TypeAvgHighDewPointJSON : JSONBase
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


        public TypeAvgHighDewPointJSON()
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


        public virtual int extraTypeAvgHighDewPointComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAvgHighDewPointComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAvgHighDewPointComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAvgHighDewPointLookup(string field_name)
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

        public virtual void extraTypeAvgHighDewPointAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAvgHighDewPointSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAvgHighDewPointLookup(key);
            if (old_field == null)
              {
                extraTypeAvgHighDewPointAppendPair(key, new_component);
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

        public static TypeAvgHighDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAvgHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgHighDewPoint", ignore_extras);
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
        public static TypeAvgHighDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAvgHighDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAvgHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgHighDewPoint", ignore_extras);
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
        public static TypeAvgHighDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAvgHighDewPointJSON from_text(string text, bool ignore_extras)
          {
            TypeAvgHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgHighDewPoint", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAvgHighDewPointJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAvgHighDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAvgHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgHighDewPoint", ignore_extras);
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
                TypeAvgHighDewPointJSON result = new TypeAvgHighDewPointJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAvgHighDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAvgHighDewPointJSON result)
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
            protected abstract void handle_result(TypeAvgHighDewPointJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgHighDewPoint class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAvgHighDewPoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgHighDewPoint class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAvgHighDewPoint class");
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
            protected override void handle_result(TypeAvgHighDewPointJSON  result)
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
            public TypeAvgHighDewPointJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAvgHighDewPointJSON  result)
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
        protected virtual void handle_result(List<TypeAvgHighDewPointJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAvgHighDewPointJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAvgHighDewPointJSON>();
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
        public List<TypeAvgHighDewPointJSON> value;
      };
      };
    public class TypeMaxHighDewPointJSON : JSONBase
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


        public TypeMaxHighDewPointJSON()
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


        public virtual int extraTypeMaxHighDewPointComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMaxHighDewPointComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMaxHighDewPointComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMaxHighDewPointLookup(string field_name)
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

        public virtual void extraTypeMaxHighDewPointAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMaxHighDewPointSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMaxHighDewPointLookup(key);
            if (old_field == null)
              {
                extraTypeMaxHighDewPointAppendPair(key, new_component);
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

        public static TypeMaxHighDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMaxHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxHighDewPoint", ignore_extras);
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
        public static TypeMaxHighDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMaxHighDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMaxHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxHighDewPoint", ignore_extras);
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
        public static TypeMaxHighDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMaxHighDewPointJSON from_text(string text, bool ignore_extras)
          {
            TypeMaxHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxHighDewPoint", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMaxHighDewPointJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMaxHighDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMaxHighDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxHighDewPoint", ignore_extras);
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
                TypeMaxHighDewPointJSON result = new TypeMaxHighDewPointJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMaxHighDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMaxHighDewPointJSON result)
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
            protected abstract void handle_result(TypeMaxHighDewPointJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxHighDewPoint class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMaxHighDewPoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxHighDewPoint class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMaxHighDewPoint class");
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
            protected override void handle_result(TypeMaxHighDewPointJSON  result)
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
            public TypeMaxHighDewPointJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMaxHighDewPointJSON  result)
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
        protected virtual void handle_result(List<TypeMaxHighDewPointJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMaxHighDewPointJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMaxHighDewPointJSON>();
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
        public List<TypeMaxHighDewPointJSON> value;
      };
      };
    public class TypeMinLowDewPointJSON : JSONBase
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


        public TypeMinLowDewPointJSON()
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


        public virtual int extraTypeMinLowDewPointComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMinLowDewPointComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMinLowDewPointComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMinLowDewPointLookup(string field_name)
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

        public virtual void extraTypeMinLowDewPointAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMinLowDewPointSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMinLowDewPointLookup(key);
            if (old_field == null)
              {
                extraTypeMinLowDewPointAppendPair(key, new_component);
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

        public static TypeMinLowDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMinLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinLowDewPoint", ignore_extras);
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
        public static TypeMinLowDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMinLowDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMinLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinLowDewPoint", ignore_extras);
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
        public static TypeMinLowDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMinLowDewPointJSON from_text(string text, bool ignore_extras)
          {
            TypeMinLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinLowDewPoint", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMinLowDewPointJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMinLowDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMinLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMinLowDewPoint", ignore_extras);
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
                TypeMinLowDewPointJSON result = new TypeMinLowDewPointJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMinLowDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMinLowDewPointJSON result)
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
            protected abstract void handle_result(TypeMinLowDewPointJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinLowDewPoint class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMinLowDewPoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMinLowDewPoint class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMinLowDewPoint class");
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
            protected override void handle_result(TypeMinLowDewPointJSON  result)
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
            public TypeMinLowDewPointJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMinLowDewPointJSON  result)
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
        protected virtual void handle_result(List<TypeMinLowDewPointJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMinLowDewPointJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMinLowDewPointJSON>();
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
        public List<TypeMinLowDewPointJSON> value;
      };
      };
    public class TypeAvgLowDewPointJSON : JSONBase
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


        public TypeAvgLowDewPointJSON()
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


        public virtual int extraTypeAvgLowDewPointComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAvgLowDewPointComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAvgLowDewPointComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAvgLowDewPointLookup(string field_name)
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

        public virtual void extraTypeAvgLowDewPointAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAvgLowDewPointSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAvgLowDewPointLookup(key);
            if (old_field == null)
              {
                extraTypeAvgLowDewPointAppendPair(key, new_component);
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

        public static TypeAvgLowDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAvgLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgLowDewPoint", ignore_extras);
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
        public static TypeAvgLowDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAvgLowDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAvgLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgLowDewPoint", ignore_extras);
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
        public static TypeAvgLowDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAvgLowDewPointJSON from_text(string text, bool ignore_extras)
          {
            TypeAvgLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgLowDewPoint", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAvgLowDewPointJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAvgLowDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAvgLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAvgLowDewPoint", ignore_extras);
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
                TypeAvgLowDewPointJSON result = new TypeAvgLowDewPointJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAvgLowDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAvgLowDewPointJSON result)
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
            protected abstract void handle_result(TypeAvgLowDewPointJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgLowDewPoint class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAvgLowDewPoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeAvgLowDewPoint class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAvgLowDewPoint class");
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
            protected override void handle_result(TypeAvgLowDewPointJSON  result)
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
            public TypeAvgLowDewPointJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAvgLowDewPointJSON  result)
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
        protected virtual void handle_result(List<TypeAvgLowDewPointJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAvgLowDewPointJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAvgLowDewPointJSON>();
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
        public List<TypeAvgLowDewPointJSON> value;
      };
      };
    public class TypeMaxLowDewPointJSON : JSONBase
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


        public TypeMaxLowDewPointJSON()
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


        public virtual int extraTypeMaxLowDewPointComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMaxLowDewPointComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMaxLowDewPointComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMaxLowDewPointLookup(string field_name)
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

        public virtual void extraTypeMaxLowDewPointAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMaxLowDewPointSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMaxLowDewPointLookup(key);
            if (old_field == null)
              {
                extraTypeMaxLowDewPointAppendPair(key, new_component);
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

        public static TypeMaxLowDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMaxLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxLowDewPoint", ignore_extras);
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
        public static TypeMaxLowDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMaxLowDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMaxLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxLowDewPoint", ignore_extras);
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
        public static TypeMaxLowDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMaxLowDewPointJSON from_text(string text, bool ignore_extras)
          {
            TypeMaxLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxLowDewPoint", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMaxLowDewPointJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMaxLowDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMaxLowDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMaxLowDewPoint", ignore_extras);
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
                TypeMaxLowDewPointJSON result = new TypeMaxLowDewPointJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMaxLowDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMaxLowDewPointJSON result)
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
            protected abstract void handle_result(TypeMaxLowDewPointJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxLowDewPoint class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMaxLowDewPoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeMaxLowDewPoint class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMaxLowDewPoint class");
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
            protected override void handle_result(TypeMaxLowDewPointJSON  result)
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
            public TypeMaxLowDewPointJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMaxLowDewPointJSON  result)
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
        protected virtual void handle_result(List<TypeMaxLowDewPointJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMaxLowDewPointJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMaxLowDewPointJSON>();
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
        public List<TypeMaxLowDewPointJSON> value;
      };
      };
    public enum TypeCloudCoverConditionsKnownValues
      {
        CloudCoverConditions_clear,
        CloudCoverConditions_cloudy,
        CloudCoverConditions_flurries,
        CloudCoverConditions_fog,
        CloudCoverConditions_haze,
        CloudCoverConditions_mostly_x20_cloudy,
        CloudCoverConditions_mostly_x20_sunny,
        CloudCoverConditions_partly_x20_cloudy,
        CloudCoverConditions_partly_x20_sunny,
        CloudCoverConditions_freezing_x20_rain,
        CloudCoverConditions_rain,
        CloudCoverConditions_sleet,
        CloudCoverConditions_snow,
        CloudCoverConditions_sunny,
        CloudCoverConditions_thunderstorms,
        CloudCoverConditions_thunderstorm,
        CloudCoverConditions_overcast,
        CloudCoverConditions_scattered_x20_clouds,
        CloudCoverConditions_unknown,
        CloudCoverConditions__none
      };
    public struct TypeCloudCoverConditions
      {
        public bool in_known_list;
        public string string_value;
        public TypeCloudCoverConditionsKnownValues list_value;
      };

    public static TypeCloudCoverConditionsKnownValues  stringToCloudCoverConditions(string chars)
      {
        switch (chars[0])
          {
            case 'c':
                if (String.Compare(chars, 1, "l", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'e':
                            if ((String.Compare(chars, 3, "ar", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_clear;
                            break;
                        case 'o':
                            if ((String.Compare(chars, 3, "udy", 0, 3, false) == 0) && (chars.Length == 6))
                                return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_cloudy;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'f':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "urries", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_flurries;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "g", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_fog;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "eezing rain", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_freezing_x20_rain;
                        break;
                    default:
                        break;
                  }
                break;
            case 'h':
                if ((String.Compare(chars, 1, "aze", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_haze;
                break;
            case 'm':
                if (String.Compare(chars, 1, "ostly ", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'c':
                            if ((String.Compare(chars, 8, "loudy", 0, 5, false) == 0) && (chars.Length == 13))
                                return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_mostly_x20_cloudy;
                            break;
                        case 's':
                            if ((String.Compare(chars, 8, "unny", 0, 4, false) == 0) && (chars.Length == 12))
                                return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_mostly_x20_sunny;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'o':
                if ((String.Compare(chars, 1, "vercast", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_overcast;
                break;
            case 'p':
                if (String.Compare(chars, 1, "artly ", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'c':
                            if ((String.Compare(chars, 8, "loudy", 0, 5, false) == 0) && (chars.Length == 13))
                                return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_partly_x20_cloudy;
                            break;
                        case 's':
                            if ((String.Compare(chars, 8, "unny", 0, 4, false) == 0) && (chars.Length == 12))
                                return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_partly_x20_sunny;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'r':
                if ((String.Compare(chars, 1, "ain", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_rain;
                break;
            case 's':
                switch (chars[1])
                  {
                    case 'c':
                        if ((String.Compare(chars, 2, "attered clouds", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_scattered_x20_clouds;
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "eet", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_sleet;
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "ow", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_snow;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "nny", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_sunny;
                        break;
                    default:
                        break;
                  }
                break;
            case 't':
                if (String.Compare(chars, 1, "hunderstorm", 0, 11, false) == 0)
                  {
                    if (chars.Length == 12)
                      {
                        return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_thunderstorm;
                      }
                    switch (chars[12])
                      {
                        case 's':
                            if (chars.Length == 13)
                                return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_thunderstorms;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'u':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeCloudCoverConditionsKnownValues.CloudCoverConditions_unknown;
                break;
            default:
                break;
          }
        return TypeCloudCoverConditionsKnownValues.CloudCoverConditions__none;
      }

    public static string  stringFromCloudCoverConditions(TypeCloudCoverConditionsKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_clear:
                return "clear";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_cloudy:
                return "cloudy";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_flurries:
                return "flurries";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_fog:
                return "fog";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_haze:
                return "haze";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_mostly_x20_cloudy:
                return "mostly cloudy";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_mostly_x20_sunny:
                return "mostly sunny";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_partly_x20_cloudy:
                return "partly cloudy";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_partly_x20_sunny:
                return "partly sunny";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_freezing_x20_rain:
                return "freezing rain";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_rain:
                return "rain";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_sleet:
                return "sleet";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_snow:
                return "snow";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_sunny:
                return "sunny";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_thunderstorms:
                return "thunderstorms";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_thunderstorm:
                return "thunderstorm";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_overcast:
                return "overcast";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_scattered_x20_clouds:
                return "scattered clouds";
            case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_unknown:
                return "unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasPlannerStartDateAndTime;
    private DateAndOrTimeJSON  storePlannerStartDateAndTime;
    private bool flagHasPlannerEndDateAndTime;
    private DateAndOrTimeJSON  storePlannerEndDateAndTime;
    private bool flagHasMinHighTemperature;
    private TypeMinHighTemperatureJSON  storeMinHighTemperature;
    private bool flagHasAvgHighTemperature;
    private TypeAvgHighTemperatureJSON  storeAvgHighTemperature;
    private bool flagHasMaxHighTemperature;
    private TypeMaxHighTemperatureJSON  storeMaxHighTemperature;
    private bool flagHasMinLowTemperature;
    private TypeMinLowTemperatureJSON  storeMinLowTemperature;
    private bool flagHasAvgLowTemperature;
    private TypeAvgLowTemperatureJSON  storeAvgLowTemperature;
    private bool flagHasMaxLowTemperature;
    private TypeMaxLowTemperatureJSON  storeMaxLowTemperature;
    private bool flagHasAvgTemperature;
    private TypeAvgTemperatureJSON  storeAvgTemperature;
    private bool flagHasMinPrecipitation;
    private TypeMinPrecipitationJSON  storeMinPrecipitation;
    private bool flagHasAvgPrecipitation;
    private TypeAvgPrecipitationJSON  storeAvgPrecipitation;
    private bool flagHasMaxPrecipitation;
    private TypeMaxPrecipitationJSON  storeMaxPrecipitation;
    private bool flagHasMinHighDewPoint;
    private TypeMinHighDewPointJSON  storeMinHighDewPoint;
    private bool flagHasAvgHighDewPoint;
    private TypeAvgHighDewPointJSON  storeAvgHighDewPoint;
    private bool flagHasMaxHighDewPoint;
    private TypeMaxHighDewPointJSON  storeMaxHighDewPoint;
    private bool flagHasMinLowDewPoint;
    private TypeMinLowDewPointJSON  storeMinLowDewPoint;
    private bool flagHasAvgLowDewPoint;
    private TypeAvgLowDewPointJSON  storeAvgLowDewPoint;
    private bool flagHasMaxLowDewPoint;
    private TypeMaxLowDewPointJSON  storeMaxLowDewPoint;
    private bool flagHasCloudCoverConditions;
    private TypeCloudCoverConditions storeCloudCoverConditions;
    private bool flagHasCloudCoverConditionsDisplay;
    private string storeCloudCoverConditionsDisplay;
    private bool flagHasCloudCoverConditionsSpoken;
    private string storeCloudCoverConditionsSpoken;
    private bool flagHasCloudCoverConditionsWritten;
    private string storeCloudCoverConditionsWritten;
    private bool flagHasChanceOf;
    private List< PercentageBasedWeatherDataJSON  > storeChanceOf;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPlannerStartDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setPlannerStartDateAndTime(convert_classy);
      }


    private void  fromJSONPlannerEndDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setPlannerEndDateAndTime(convert_classy);
      }


    private void  fromJSONMinHighTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMinHighTemperatureJSON convert_classy = TypeMinHighTemperatureJSON.from_json(json_value, ignore_extras, true);
        setMinHighTemperature(convert_classy);
      }


    private void  fromJSONAvgHighTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeAvgHighTemperatureJSON convert_classy = TypeAvgHighTemperatureJSON.from_json(json_value, ignore_extras, true);
        setAvgHighTemperature(convert_classy);
      }


    private void  fromJSONMaxHighTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMaxHighTemperatureJSON convert_classy = TypeMaxHighTemperatureJSON.from_json(json_value, ignore_extras, true);
        setMaxHighTemperature(convert_classy);
      }


    private void  fromJSONMinLowTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMinLowTemperatureJSON convert_classy = TypeMinLowTemperatureJSON.from_json(json_value, ignore_extras, true);
        setMinLowTemperature(convert_classy);
      }


    private void  fromJSONAvgLowTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeAvgLowTemperatureJSON convert_classy = TypeAvgLowTemperatureJSON.from_json(json_value, ignore_extras, true);
        setAvgLowTemperature(convert_classy);
      }


    private void  fromJSONMaxLowTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMaxLowTemperatureJSON convert_classy = TypeMaxLowTemperatureJSON.from_json(json_value, ignore_extras, true);
        setMaxLowTemperature(convert_classy);
      }


    private void  fromJSONAvgTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeAvgTemperatureJSON convert_classy = TypeAvgTemperatureJSON.from_json(json_value, ignore_extras, true);
        setAvgTemperature(convert_classy);
      }


    private void  fromJSONMinPrecipitation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMinPrecipitationJSON convert_classy = TypeMinPrecipitationJSON.from_json(json_value, ignore_extras, true);
        setMinPrecipitation(convert_classy);
      }


    private void  fromJSONAvgPrecipitation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeAvgPrecipitationJSON convert_classy = TypeAvgPrecipitationJSON.from_json(json_value, ignore_extras, true);
        setAvgPrecipitation(convert_classy);
      }


    private void  fromJSONMaxPrecipitation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMaxPrecipitationJSON convert_classy = TypeMaxPrecipitationJSON.from_json(json_value, ignore_extras, true);
        setMaxPrecipitation(convert_classy);
      }


    private void  fromJSONMinHighDewPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMinHighDewPointJSON convert_classy = TypeMinHighDewPointJSON.from_json(json_value, ignore_extras, true);
        setMinHighDewPoint(convert_classy);
      }


    private void  fromJSONAvgHighDewPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeAvgHighDewPointJSON convert_classy = TypeAvgHighDewPointJSON.from_json(json_value, ignore_extras, true);
        setAvgHighDewPoint(convert_classy);
      }


    private void  fromJSONMaxHighDewPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMaxHighDewPointJSON convert_classy = TypeMaxHighDewPointJSON.from_json(json_value, ignore_extras, true);
        setMaxHighDewPoint(convert_classy);
      }


    private void  fromJSONMinLowDewPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMinLowDewPointJSON convert_classy = TypeMinLowDewPointJSON.from_json(json_value, ignore_extras, true);
        setMinLowDewPoint(convert_classy);
      }


    private void  fromJSONAvgLowDewPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeAvgLowDewPointJSON convert_classy = TypeAvgLowDewPointJSON.from_json(json_value, ignore_extras, true);
        setAvgLowDewPoint(convert_classy);
      }


    private void  fromJSONMaxLowDewPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeMaxLowDewPointJSON convert_classy = TypeMaxLowDewPointJSON.from_json(json_value, ignore_extras, true);
        setMaxLowDewPoint(convert_classy);
      }


    private void  fromJSONCloudCoverConditions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CloudCoverConditions of PlannerJSON is not a string.");
        TypeCloudCoverConditions the_open_enum = new TypeCloudCoverConditions();
        switch (json_string.getData()[0])
          {
            case 'c':
                if (String.Compare(json_string.getData(), 1, "l", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'e':
                            if ((String.Compare(json_string.getData(), 3, "ar", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_clear;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'o':
                            if ((String.Compare(json_string.getData(), 3, "udy", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_cloudy;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'f':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "urries", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_flurries;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "g", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_fog;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "eezing rain", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_freezing_x20_rain;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'h':
                if ((String.Compare(json_string.getData(), 1, "aze", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_haze;
                        goto open_enum_is_done;
                      }
                break;
            case 'm':
                if (String.Compare(json_string.getData(), 1, "ostly ", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'c':
                            if ((String.Compare(json_string.getData(), 8, "loudy", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_mostly_x20_cloudy;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 's':
                            if ((String.Compare(json_string.getData(), 8, "unny", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_mostly_x20_sunny;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'o':
                if ((String.Compare(json_string.getData(), 1, "vercast", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_overcast;
                        goto open_enum_is_done;
                      }
                break;
            case 'p':
                if (String.Compare(json_string.getData(), 1, "artly ", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'c':
                            if ((String.Compare(json_string.getData(), 8, "loudy", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_partly_x20_cloudy;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 's':
                            if ((String.Compare(json_string.getData(), 8, "unny", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_partly_x20_sunny;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'r':
                if ((String.Compare(json_string.getData(), 1, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_rain;
                        goto open_enum_is_done;
                      }
                break;
            case 's':
                switch (json_string.getData()[1])
                  {
                    case 'c':
                        if ((String.Compare(json_string.getData(), 2, "attered clouds", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_scattered_x20_clouds;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "eet", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_sleet;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_snow;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "nny", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_sunny;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 't':
                if (String.Compare(json_string.getData(), 1, "hunderstorm", 0, 11, false) == 0)
                  {
                    if (json_string.getData().Length == 12)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_thunderstorm;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[12])
                      {
                        case 's':
                            if (json_string.getData().Length == 13)
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_thunderstorms;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'u':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCloudCoverConditionsKnownValues.CloudCoverConditions_unknown;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setCloudCoverConditions(the_open_enum);
      }


    private void  fromJSONCloudCoverConditionsDisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CloudCoverConditionsDisplay of PlannerJSON is not a string.");
        setCloudCoverConditionsDisplay(json_string.getData());
      }


    private void  fromJSONCloudCoverConditionsSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CloudCoverConditionsSpoken of PlannerJSON is not a string.");
        setCloudCoverConditionsSpoken(json_string.getData());
      }


    private void  fromJSONCloudCoverConditionsWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CloudCoverConditionsWritten of PlannerJSON is not a string.");
        setCloudCoverConditionsWritten(json_string.getData());
      }


    private void  fromJSONChanceOf(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ChanceOf of PlannerJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< PercentageBasedWeatherDataJSON  > vector_ChanceOf1 = new List< PercentageBasedWeatherDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PercentageBasedWeatherDataJSON convert_classy = PercentageBasedWeatherDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ChanceOf1.Add(convert_classy);
          }
        initChanceOf();
        for (int num1 = 0; num1 < vector_ChanceOf1.Count; ++num1)
            appendChanceOf(vector_ChanceOf1[num1]);
        for (int num1 = 0; num1 < vector_ChanceOf1.Count; ++num1)
          {
          }
      }


    public PlannerJSON()
      {
        flagHasPlannerStartDateAndTime = false;
        flagHasPlannerEndDateAndTime = false;
        flagHasMinHighTemperature = false;
        flagHasAvgHighTemperature = false;
        flagHasMaxHighTemperature = false;
        flagHasMinLowTemperature = false;
        flagHasAvgLowTemperature = false;
        flagHasMaxLowTemperature = false;
        flagHasAvgTemperature = false;
        flagHasMinPrecipitation = false;
        flagHasAvgPrecipitation = false;
        flagHasMaxPrecipitation = false;
        flagHasMinHighDewPoint = false;
        flagHasAvgHighDewPoint = false;
        flagHasMaxHighDewPoint = false;
        flagHasMinLowDewPoint = false;
        flagHasAvgLowDewPoint = false;
        flagHasMaxLowDewPoint = false;
        flagHasCloudCoverConditions = false;
        flagHasCloudCoverConditionsDisplay = false;
        flagHasCloudCoverConditionsSpoken = false;
        flagHasCloudCoverConditionsWritten = false;
        flagHasChanceOf = false;
        storeChanceOf = new List< PercentageBasedWeatherDataJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPlannerStartDateAndTime()
      {
        return flagHasPlannerStartDateAndTime;
      }

    public DateAndOrTimeJSON   getPlannerStartDateAndTime()
      {
        Debug.Assert(flagHasPlannerStartDateAndTime);
        return storePlannerStartDateAndTime;
      }

    public bool  hasPlannerEndDateAndTime()
      {
        return flagHasPlannerEndDateAndTime;
      }

    public DateAndOrTimeJSON   getPlannerEndDateAndTime()
      {
        Debug.Assert(flagHasPlannerEndDateAndTime);
        return storePlannerEndDateAndTime;
      }

    public bool  hasMinHighTemperature()
      {
        return flagHasMinHighTemperature;
      }

    public TypeMinHighTemperatureJSON   getMinHighTemperature()
      {
        Debug.Assert(flagHasMinHighTemperature);
        return storeMinHighTemperature;
      }

    public bool  hasAvgHighTemperature()
      {
        return flagHasAvgHighTemperature;
      }

    public TypeAvgHighTemperatureJSON   getAvgHighTemperature()
      {
        Debug.Assert(flagHasAvgHighTemperature);
        return storeAvgHighTemperature;
      }

    public bool  hasMaxHighTemperature()
      {
        return flagHasMaxHighTemperature;
      }

    public TypeMaxHighTemperatureJSON   getMaxHighTemperature()
      {
        Debug.Assert(flagHasMaxHighTemperature);
        return storeMaxHighTemperature;
      }

    public bool  hasMinLowTemperature()
      {
        return flagHasMinLowTemperature;
      }

    public TypeMinLowTemperatureJSON   getMinLowTemperature()
      {
        Debug.Assert(flagHasMinLowTemperature);
        return storeMinLowTemperature;
      }

    public bool  hasAvgLowTemperature()
      {
        return flagHasAvgLowTemperature;
      }

    public TypeAvgLowTemperatureJSON   getAvgLowTemperature()
      {
        Debug.Assert(flagHasAvgLowTemperature);
        return storeAvgLowTemperature;
      }

    public bool  hasMaxLowTemperature()
      {
        return flagHasMaxLowTemperature;
      }

    public TypeMaxLowTemperatureJSON   getMaxLowTemperature()
      {
        Debug.Assert(flagHasMaxLowTemperature);
        return storeMaxLowTemperature;
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

    public bool  hasMinPrecipitation()
      {
        return flagHasMinPrecipitation;
      }

    public TypeMinPrecipitationJSON   getMinPrecipitation()
      {
        Debug.Assert(flagHasMinPrecipitation);
        return storeMinPrecipitation;
      }

    public bool  hasAvgPrecipitation()
      {
        return flagHasAvgPrecipitation;
      }

    public TypeAvgPrecipitationJSON   getAvgPrecipitation()
      {
        Debug.Assert(flagHasAvgPrecipitation);
        return storeAvgPrecipitation;
      }

    public bool  hasMaxPrecipitation()
      {
        return flagHasMaxPrecipitation;
      }

    public TypeMaxPrecipitationJSON   getMaxPrecipitation()
      {
        Debug.Assert(flagHasMaxPrecipitation);
        return storeMaxPrecipitation;
      }

    public bool  hasMinHighDewPoint()
      {
        return flagHasMinHighDewPoint;
      }

    public TypeMinHighDewPointJSON   getMinHighDewPoint()
      {
        Debug.Assert(flagHasMinHighDewPoint);
        return storeMinHighDewPoint;
      }

    public bool  hasAvgHighDewPoint()
      {
        return flagHasAvgHighDewPoint;
      }

    public TypeAvgHighDewPointJSON   getAvgHighDewPoint()
      {
        Debug.Assert(flagHasAvgHighDewPoint);
        return storeAvgHighDewPoint;
      }

    public bool  hasMaxHighDewPoint()
      {
        return flagHasMaxHighDewPoint;
      }

    public TypeMaxHighDewPointJSON   getMaxHighDewPoint()
      {
        Debug.Assert(flagHasMaxHighDewPoint);
        return storeMaxHighDewPoint;
      }

    public bool  hasMinLowDewPoint()
      {
        return flagHasMinLowDewPoint;
      }

    public TypeMinLowDewPointJSON   getMinLowDewPoint()
      {
        Debug.Assert(flagHasMinLowDewPoint);
        return storeMinLowDewPoint;
      }

    public bool  hasAvgLowDewPoint()
      {
        return flagHasAvgLowDewPoint;
      }

    public TypeAvgLowDewPointJSON   getAvgLowDewPoint()
      {
        Debug.Assert(flagHasAvgLowDewPoint);
        return storeAvgLowDewPoint;
      }

    public bool  hasMaxLowDewPoint()
      {
        return flagHasMaxLowDewPoint;
      }

    public TypeMaxLowDewPointJSON   getMaxLowDewPoint()
      {
        Debug.Assert(flagHasMaxLowDewPoint);
        return storeMaxLowDewPoint;
      }

    public bool  hasCloudCoverConditions()
      {
        return flagHasCloudCoverConditions;
      }

    public TypeCloudCoverConditions  getCloudCoverConditions()
      {
        Debug.Assert(flagHasCloudCoverConditions);
        return storeCloudCoverConditions;
      }

    public string  getCloudCoverConditionsAsString()
      {
        TypeCloudCoverConditions result = getCloudCoverConditions();
        if (result.in_known_list)
            return stringFromCloudCoverConditions(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasCloudCoverConditionsDisplay()
      {
        return flagHasCloudCoverConditionsDisplay;
      }

    public string  getCloudCoverConditionsDisplay()
      {
        Debug.Assert(flagHasCloudCoverConditionsDisplay);
        return storeCloudCoverConditionsDisplay;
      }

    public bool  hasCloudCoverConditionsSpoken()
      {
        return flagHasCloudCoverConditionsSpoken;
      }

    public string  getCloudCoverConditionsSpoken()
      {
        Debug.Assert(flagHasCloudCoverConditionsSpoken);
        return storeCloudCoverConditionsSpoken;
      }

    public bool  hasCloudCoverConditionsWritten()
      {
        return flagHasCloudCoverConditionsWritten;
      }

    public string  getCloudCoverConditionsWritten()
      {
        Debug.Assert(flagHasCloudCoverConditionsWritten);
        return storeCloudCoverConditionsWritten;
      }

    public bool  hasChanceOf()
      {
        return flagHasChanceOf;
      }

    public int  countOfChanceOf()
      {
        Debug.Assert(flagHasChanceOf);
        return storeChanceOf.Count;
      }

    public PercentageBasedWeatherDataJSON   elementOfChanceOf(int element_num)
      {
        Debug.Assert(flagHasChanceOf);
        return storeChanceOf[element_num];
      }

    public List< PercentageBasedWeatherDataJSON  >  getChanceOf()
      {
        Debug.Assert(flagHasChanceOf);
        return storeChanceOf;
      }


    public virtual int extraPlannerComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPlannerComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPlannerComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPlannerLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPlannerStartDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasPlannerStartDateAndTime)
          {
          }
        flagHasPlannerStartDateAndTime = true;
        storePlannerStartDateAndTime = new_value;
      }
    public void unsetPlannerStartDateAndTime()
      {
        if (flagHasPlannerStartDateAndTime)
          {
          }
        flagHasPlannerStartDateAndTime = false;
      }
    public void setPlannerEndDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasPlannerEndDateAndTime)
          {
          }
        flagHasPlannerEndDateAndTime = true;
        storePlannerEndDateAndTime = new_value;
      }
    public void unsetPlannerEndDateAndTime()
      {
        if (flagHasPlannerEndDateAndTime)
          {
          }
        flagHasPlannerEndDateAndTime = false;
      }
    public void setMinHighTemperature(TypeMinHighTemperatureJSON  new_value)
      {
        if (flagHasMinHighTemperature)
          {
          }
        flagHasMinHighTemperature = true;
        storeMinHighTemperature = new_value;
      }
    public void unsetMinHighTemperature()
      {
        if (flagHasMinHighTemperature)
          {
          }
        flagHasMinHighTemperature = false;
      }
    public void setAvgHighTemperature(TypeAvgHighTemperatureJSON  new_value)
      {
        if (flagHasAvgHighTemperature)
          {
          }
        flagHasAvgHighTemperature = true;
        storeAvgHighTemperature = new_value;
      }
    public void unsetAvgHighTemperature()
      {
        if (flagHasAvgHighTemperature)
          {
          }
        flagHasAvgHighTemperature = false;
      }
    public void setMaxHighTemperature(TypeMaxHighTemperatureJSON  new_value)
      {
        if (flagHasMaxHighTemperature)
          {
          }
        flagHasMaxHighTemperature = true;
        storeMaxHighTemperature = new_value;
      }
    public void unsetMaxHighTemperature()
      {
        if (flagHasMaxHighTemperature)
          {
          }
        flagHasMaxHighTemperature = false;
      }
    public void setMinLowTemperature(TypeMinLowTemperatureJSON  new_value)
      {
        if (flagHasMinLowTemperature)
          {
          }
        flagHasMinLowTemperature = true;
        storeMinLowTemperature = new_value;
      }
    public void unsetMinLowTemperature()
      {
        if (flagHasMinLowTemperature)
          {
          }
        flagHasMinLowTemperature = false;
      }
    public void setAvgLowTemperature(TypeAvgLowTemperatureJSON  new_value)
      {
        if (flagHasAvgLowTemperature)
          {
          }
        flagHasAvgLowTemperature = true;
        storeAvgLowTemperature = new_value;
      }
    public void unsetAvgLowTemperature()
      {
        if (flagHasAvgLowTemperature)
          {
          }
        flagHasAvgLowTemperature = false;
      }
    public void setMaxLowTemperature(TypeMaxLowTemperatureJSON  new_value)
      {
        if (flagHasMaxLowTemperature)
          {
          }
        flagHasMaxLowTemperature = true;
        storeMaxLowTemperature = new_value;
      }
    public void unsetMaxLowTemperature()
      {
        if (flagHasMaxLowTemperature)
          {
          }
        flagHasMaxLowTemperature = false;
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
    public void setMinPrecipitation(TypeMinPrecipitationJSON  new_value)
      {
        if (flagHasMinPrecipitation)
          {
          }
        flagHasMinPrecipitation = true;
        storeMinPrecipitation = new_value;
      }
    public void unsetMinPrecipitation()
      {
        if (flagHasMinPrecipitation)
          {
          }
        flagHasMinPrecipitation = false;
      }
    public void setAvgPrecipitation(TypeAvgPrecipitationJSON  new_value)
      {
        if (flagHasAvgPrecipitation)
          {
          }
        flagHasAvgPrecipitation = true;
        storeAvgPrecipitation = new_value;
      }
    public void unsetAvgPrecipitation()
      {
        if (flagHasAvgPrecipitation)
          {
          }
        flagHasAvgPrecipitation = false;
      }
    public void setMaxPrecipitation(TypeMaxPrecipitationJSON  new_value)
      {
        if (flagHasMaxPrecipitation)
          {
          }
        flagHasMaxPrecipitation = true;
        storeMaxPrecipitation = new_value;
      }
    public void unsetMaxPrecipitation()
      {
        if (flagHasMaxPrecipitation)
          {
          }
        flagHasMaxPrecipitation = false;
      }
    public void setMinHighDewPoint(TypeMinHighDewPointJSON  new_value)
      {
        if (flagHasMinHighDewPoint)
          {
          }
        flagHasMinHighDewPoint = true;
        storeMinHighDewPoint = new_value;
      }
    public void unsetMinHighDewPoint()
      {
        if (flagHasMinHighDewPoint)
          {
          }
        flagHasMinHighDewPoint = false;
      }
    public void setAvgHighDewPoint(TypeAvgHighDewPointJSON  new_value)
      {
        if (flagHasAvgHighDewPoint)
          {
          }
        flagHasAvgHighDewPoint = true;
        storeAvgHighDewPoint = new_value;
      }
    public void unsetAvgHighDewPoint()
      {
        if (flagHasAvgHighDewPoint)
          {
          }
        flagHasAvgHighDewPoint = false;
      }
    public void setMaxHighDewPoint(TypeMaxHighDewPointJSON  new_value)
      {
        if (flagHasMaxHighDewPoint)
          {
          }
        flagHasMaxHighDewPoint = true;
        storeMaxHighDewPoint = new_value;
      }
    public void unsetMaxHighDewPoint()
      {
        if (flagHasMaxHighDewPoint)
          {
          }
        flagHasMaxHighDewPoint = false;
      }
    public void setMinLowDewPoint(TypeMinLowDewPointJSON  new_value)
      {
        if (flagHasMinLowDewPoint)
          {
          }
        flagHasMinLowDewPoint = true;
        storeMinLowDewPoint = new_value;
      }
    public void unsetMinLowDewPoint()
      {
        if (flagHasMinLowDewPoint)
          {
          }
        flagHasMinLowDewPoint = false;
      }
    public void setAvgLowDewPoint(TypeAvgLowDewPointJSON  new_value)
      {
        if (flagHasAvgLowDewPoint)
          {
          }
        flagHasAvgLowDewPoint = true;
        storeAvgLowDewPoint = new_value;
      }
    public void unsetAvgLowDewPoint()
      {
        if (flagHasAvgLowDewPoint)
          {
          }
        flagHasAvgLowDewPoint = false;
      }
    public void setMaxLowDewPoint(TypeMaxLowDewPointJSON  new_value)
      {
        if (flagHasMaxLowDewPoint)
          {
          }
        flagHasMaxLowDewPoint = true;
        storeMaxLowDewPoint = new_value;
      }
    public void unsetMaxLowDewPoint()
      {
        if (flagHasMaxLowDewPoint)
          {
          }
        flagHasMaxLowDewPoint = false;
      }
    public void setCloudCoverConditions(TypeCloudCoverConditions new_value)
      {
        flagHasCloudCoverConditions = true;
        storeCloudCoverConditions = new_value;
      }
    public void setCloudCoverConditions(string chars)
      {
        TypeCloudCoverConditionsKnownValues known = stringToCloudCoverConditions(chars);
        TypeCloudCoverConditions new_value = new TypeCloudCoverConditions();
        if (known == TypeCloudCoverConditionsKnownValues.CloudCoverConditions__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCloudCoverConditions(new_value);
      }
    public void setCloudCoverConditions(TypeCloudCoverConditionsKnownValues new_value)
      {
        TypeCloudCoverConditions new_full_value = new TypeCloudCoverConditions();
        Debug.Assert(new_value != TypeCloudCoverConditionsKnownValues.CloudCoverConditions__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setCloudCoverConditions(new_full_value);
      }
    public void unsetCloudCoverConditions()
      {
        flagHasCloudCoverConditions = false;
      }
    public void setCloudCoverConditionsDisplay(string new_value)
      {
        flagHasCloudCoverConditionsDisplay = true;
        storeCloudCoverConditionsDisplay = new_value;
      }
    public void unsetCloudCoverConditionsDisplay()
      {
        flagHasCloudCoverConditionsDisplay = false;
      }
    public void setCloudCoverConditionsSpoken(string new_value)
      {
        flagHasCloudCoverConditionsSpoken = true;
        storeCloudCoverConditionsSpoken = new_value;
      }
    public void unsetCloudCoverConditionsSpoken()
      {
        flagHasCloudCoverConditionsSpoken = false;
      }
    public void setCloudCoverConditionsWritten(string new_value)
      {
        flagHasCloudCoverConditionsWritten = true;
        storeCloudCoverConditionsWritten = new_value;
      }
    public void unsetCloudCoverConditionsWritten()
      {
        flagHasCloudCoverConditionsWritten = false;
      }
    public void initChanceOf()
      {
        if (flagHasChanceOf)
          {
            for (int num1 = 0; num1 < storeChanceOf.Count; ++num1)
              {
              }
          }
        flagHasChanceOf = true;
        storeChanceOf.Clear();
      }
    public void appendChanceOf(PercentageBasedWeatherDataJSON  to_append)
      {
        if (!flagHasChanceOf)
          {
            flagHasChanceOf = true;
            storeChanceOf.Clear();
          }
        Debug.Assert(flagHasChanceOf);
        storeChanceOf.Add(to_append);
      }
    public void unsetChanceOf()
      {
        if (flagHasChanceOf)
          {
            for (int num2 = 0; num2 < storeChanceOf.Count; ++num2)
              {
              }
          }
        flagHasChanceOf = false;
        storeChanceOf.Clear();
      }

    public virtual void extraPlannerAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPlannerSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPlannerLookup(key);
        if (old_field == null)
          {
            extraPlannerAppendPair(key, new_component);
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
        if (flagHasPlannerStartDateAndTime)
          {
            handler.start_pair("PlannerStartDateAndTime");
            if (partial_allowed)
                storePlannerStartDateAndTime.write_partial_as_json(handler);
            else
                storePlannerStartDateAndTime.write_as_json(handler);
          }
        if (flagHasPlannerEndDateAndTime)
          {
            handler.start_pair("PlannerEndDateAndTime");
            if (partial_allowed)
                storePlannerEndDateAndTime.write_partial_as_json(handler);
            else
                storePlannerEndDateAndTime.write_as_json(handler);
          }
        if (flagHasMinHighTemperature)
          {
            handler.start_pair("MinHighTemperature");
            if (partial_allowed)
                storeMinHighTemperature.write_partial_as_json(handler);
            else
                storeMinHighTemperature.write_as_json(handler);
          }
        if (flagHasAvgHighTemperature)
          {
            handler.start_pair("AvgHighTemperature");
            if (partial_allowed)
                storeAvgHighTemperature.write_partial_as_json(handler);
            else
                storeAvgHighTemperature.write_as_json(handler);
          }
        if (flagHasMaxHighTemperature)
          {
            handler.start_pair("MaxHighTemperature");
            if (partial_allowed)
                storeMaxHighTemperature.write_partial_as_json(handler);
            else
                storeMaxHighTemperature.write_as_json(handler);
          }
        if (flagHasMinLowTemperature)
          {
            handler.start_pair("MinLowTemperature");
            if (partial_allowed)
                storeMinLowTemperature.write_partial_as_json(handler);
            else
                storeMinLowTemperature.write_as_json(handler);
          }
        if (flagHasAvgLowTemperature)
          {
            handler.start_pair("AvgLowTemperature");
            if (partial_allowed)
                storeAvgLowTemperature.write_partial_as_json(handler);
            else
                storeAvgLowTemperature.write_as_json(handler);
          }
        if (flagHasMaxLowTemperature)
          {
            handler.start_pair("MaxLowTemperature");
            if (partial_allowed)
                storeMaxLowTemperature.write_partial_as_json(handler);
            else
                storeMaxLowTemperature.write_as_json(handler);
          }
        if (flagHasAvgTemperature)
          {
            handler.start_pair("AvgTemperature");
            if (partial_allowed)
                storeAvgTemperature.write_partial_as_json(handler);
            else
                storeAvgTemperature.write_as_json(handler);
          }
        if (flagHasMinPrecipitation)
          {
            handler.start_pair("MinPrecipitation");
            if (partial_allowed)
                storeMinPrecipitation.write_partial_as_json(handler);
            else
                storeMinPrecipitation.write_as_json(handler);
          }
        if (flagHasAvgPrecipitation)
          {
            handler.start_pair("AvgPrecipitation");
            if (partial_allowed)
                storeAvgPrecipitation.write_partial_as_json(handler);
            else
                storeAvgPrecipitation.write_as_json(handler);
          }
        if (flagHasMaxPrecipitation)
          {
            handler.start_pair("MaxPrecipitation");
            if (partial_allowed)
                storeMaxPrecipitation.write_partial_as_json(handler);
            else
                storeMaxPrecipitation.write_as_json(handler);
          }
        if (flagHasMinHighDewPoint)
          {
            handler.start_pair("MinHighDewPoint");
            if (partial_allowed)
                storeMinHighDewPoint.write_partial_as_json(handler);
            else
                storeMinHighDewPoint.write_as_json(handler);
          }
        if (flagHasAvgHighDewPoint)
          {
            handler.start_pair("AvgHighDewPoint");
            if (partial_allowed)
                storeAvgHighDewPoint.write_partial_as_json(handler);
            else
                storeAvgHighDewPoint.write_as_json(handler);
          }
        if (flagHasMaxHighDewPoint)
          {
            handler.start_pair("MaxHighDewPoint");
            if (partial_allowed)
                storeMaxHighDewPoint.write_partial_as_json(handler);
            else
                storeMaxHighDewPoint.write_as_json(handler);
          }
        if (flagHasMinLowDewPoint)
          {
            handler.start_pair("MinLowDewPoint");
            if (partial_allowed)
                storeMinLowDewPoint.write_partial_as_json(handler);
            else
                storeMinLowDewPoint.write_as_json(handler);
          }
        if (flagHasAvgLowDewPoint)
          {
            handler.start_pair("AvgLowDewPoint");
            if (partial_allowed)
                storeAvgLowDewPoint.write_partial_as_json(handler);
            else
                storeAvgLowDewPoint.write_as_json(handler);
          }
        if (flagHasMaxLowDewPoint)
          {
            handler.start_pair("MaxLowDewPoint");
            if (partial_allowed)
                storeMaxLowDewPoint.write_partial_as_json(handler);
            else
                storeMaxLowDewPoint.write_as_json(handler);
          }
        if (flagHasCloudCoverConditions)
          {
            handler.start_pair("CloudCoverConditions");
            if (storeCloudCoverConditions.in_known_list)
              {
                switch (storeCloudCoverConditions.list_value)
                  {
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_clear:
                        handler.string_value("clear");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_cloudy:
                        handler.string_value("cloudy");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_flurries:
                        handler.string_value("flurries");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_fog:
                        handler.string_value("fog");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_haze:
                        handler.string_value("haze");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_mostly_x20_cloudy:
                        handler.string_value("mostly cloudy");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_mostly_x20_sunny:
                        handler.string_value("mostly sunny");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_partly_x20_cloudy:
                        handler.string_value("partly cloudy");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_partly_x20_sunny:
                        handler.string_value("partly sunny");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_freezing_x20_rain:
                        handler.string_value("freezing rain");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_rain:
                        handler.string_value("rain");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_sleet:
                        handler.string_value("sleet");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_snow:
                        handler.string_value("snow");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_sunny:
                        handler.string_value("sunny");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_thunderstorms:
                        handler.string_value("thunderstorms");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_thunderstorm:
                        handler.string_value("thunderstorm");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_overcast:
                        handler.string_value("overcast");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_scattered_x20_clouds:
                        handler.string_value("scattered clouds");
                        break;
                    case TypeCloudCoverConditionsKnownValues.CloudCoverConditions_unknown:
                        handler.string_value("unknown");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeCloudCoverConditions.string_value);
              }
          }
        if (flagHasCloudCoverConditionsDisplay)
          {
            handler.start_pair("CloudCoverConditionsDisplay");
            handler.string_value(storeCloudCoverConditionsDisplay);
          }
        if (flagHasCloudCoverConditionsSpoken)
          {
            handler.start_pair("CloudCoverConditionsSpoken");
            handler.string_value(storeCloudCoverConditionsSpoken);
          }
        if (flagHasCloudCoverConditionsWritten)
          {
            handler.start_pair("CloudCoverConditionsWritten");
            handler.string_value(storeCloudCoverConditionsWritten);
          }
        if (flagHasChanceOf)
          {
            handler.start_pair("ChanceOf");
            handler.start_array();
            for (int num1 = 0; num1 < storeChanceOf.Count; ++num1)
              {
                if (partial_allowed)
                    storeChanceOf[num1].write_partial_as_json(handler);
                else
                    storeChanceOf[num1].write_as_json(handler);
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

    public static PlannerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PlannerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Planner", ignore_extras);
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
    public static PlannerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PlannerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PlannerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Planner", ignore_extras);
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
    public static PlannerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PlannerJSON from_text(string text, bool ignore_extras)
      {
        PlannerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Planner", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PlannerJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PlannerJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PlannerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Planner", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorPlannerStartDateAndTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorPlannerEndDateAndTime;
        private TypeMinHighTemperatureJSON.HoldingGenerator fieldGeneratorMinHighTemperature;
        private TypeAvgHighTemperatureJSON.HoldingGenerator fieldGeneratorAvgHighTemperature;
        private TypeMaxHighTemperatureJSON.HoldingGenerator fieldGeneratorMaxHighTemperature;
        private TypeMinLowTemperatureJSON.HoldingGenerator fieldGeneratorMinLowTemperature;
        private TypeAvgLowTemperatureJSON.HoldingGenerator fieldGeneratorAvgLowTemperature;
        private TypeMaxLowTemperatureJSON.HoldingGenerator fieldGeneratorMaxLowTemperature;
        private TypeAvgTemperatureJSON.HoldingGenerator fieldGeneratorAvgTemperature;
        private TypeMinPrecipitationJSON.HoldingGenerator fieldGeneratorMinPrecipitation;
        private TypeAvgPrecipitationJSON.HoldingGenerator fieldGeneratorAvgPrecipitation;
        private TypeMaxPrecipitationJSON.HoldingGenerator fieldGeneratorMaxPrecipitation;
        private TypeMinHighDewPointJSON.HoldingGenerator fieldGeneratorMinHighDewPoint;
        private TypeAvgHighDewPointJSON.HoldingGenerator fieldGeneratorAvgHighDewPoint;
        private TypeMaxHighDewPointJSON.HoldingGenerator fieldGeneratorMaxHighDewPoint;
        private TypeMinLowDewPointJSON.HoldingGenerator fieldGeneratorMinLowDewPoint;
        private TypeAvgLowDewPointJSON.HoldingGenerator fieldGeneratorAvgLowDewPoint;
        private TypeMaxLowDewPointJSON.HoldingGenerator fieldGeneratorMaxLowDewPoint;
    private abstract class FieldGeneratorCloudCoverConditions : JSONStringGenerator
          {
            protected FieldGeneratorCloudCoverConditions(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCloudCoverConditions()
              {
              }
            protected override void handle_result(string result)
              {
                TypeCloudCoverConditionsKnownValues known = stringToCloudCoverConditions(result);
                TypeCloudCoverConditions new_value = new TypeCloudCoverConditions();
                if (known == TypeCloudCoverConditionsKnownValues.CloudCoverConditions__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeCloudCoverConditions result);
          };
    private class FieldHoldingGeneratorCloudCoverConditions : FieldGeneratorCloudCoverConditions
  {
    protected override void handle_result(TypeCloudCoverConditions result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCloudCoverConditions(String what)
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
    public TypeCloudCoverConditions value;
  };
    private class FieldHoldingArrayGeneratorCloudCoverConditions : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCloudCoverConditions
      {
        private FieldHoldingArrayGeneratorCloudCoverConditions top;

        protected override void handle_result(TypeCloudCoverConditions result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCloudCoverConditions init_top)
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
    protected virtual void handle_result(List<TypeCloudCoverConditions> result)
      {
      }

    public FieldHoldingArrayGeneratorCloudCoverConditions(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCloudCoverConditions>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCloudCoverConditions()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCloudCoverConditions>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCloudCoverConditions> value;
  };
        private FieldHoldingGeneratorCloudCoverConditions fieldGeneratorCloudCoverConditions;
        private JSONHoldingStringGenerator fieldGeneratorCloudCoverConditionsDisplay;
        private JSONHoldingStringGenerator fieldGeneratorCloudCoverConditionsSpoken;
        private JSONHoldingStringGenerator fieldGeneratorCloudCoverConditionsWritten;
        private PercentageBasedWeatherDataJSON.HoldingArrayGenerator fieldGeneratorChanceOf;
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
            PlannerJSON result = new PlannerJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPlannerAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(PlannerJSON result)
          {
            if (fieldGeneratorPlannerStartDateAndTime.have_value)
              {
                result.setPlannerStartDateAndTime(fieldGeneratorPlannerStartDateAndTime.value);
                fieldGeneratorPlannerStartDateAndTime.have_value = false;
              }
            if (fieldGeneratorPlannerEndDateAndTime.have_value)
              {
                result.setPlannerEndDateAndTime(fieldGeneratorPlannerEndDateAndTime.value);
                fieldGeneratorPlannerEndDateAndTime.have_value = false;
              }
            if (fieldGeneratorMinHighTemperature.have_value)
              {
                result.setMinHighTemperature(fieldGeneratorMinHighTemperature.value);
                fieldGeneratorMinHighTemperature.have_value = false;
              }
            if (fieldGeneratorAvgHighTemperature.have_value)
              {
                result.setAvgHighTemperature(fieldGeneratorAvgHighTemperature.value);
                fieldGeneratorAvgHighTemperature.have_value = false;
              }
            if (fieldGeneratorMaxHighTemperature.have_value)
              {
                result.setMaxHighTemperature(fieldGeneratorMaxHighTemperature.value);
                fieldGeneratorMaxHighTemperature.have_value = false;
              }
            if (fieldGeneratorMinLowTemperature.have_value)
              {
                result.setMinLowTemperature(fieldGeneratorMinLowTemperature.value);
                fieldGeneratorMinLowTemperature.have_value = false;
              }
            if (fieldGeneratorAvgLowTemperature.have_value)
              {
                result.setAvgLowTemperature(fieldGeneratorAvgLowTemperature.value);
                fieldGeneratorAvgLowTemperature.have_value = false;
              }
            if (fieldGeneratorMaxLowTemperature.have_value)
              {
                result.setMaxLowTemperature(fieldGeneratorMaxLowTemperature.value);
                fieldGeneratorMaxLowTemperature.have_value = false;
              }
            if (fieldGeneratorAvgTemperature.have_value)
              {
                result.setAvgTemperature(fieldGeneratorAvgTemperature.value);
                fieldGeneratorAvgTemperature.have_value = false;
              }
            if (fieldGeneratorMinPrecipitation.have_value)
              {
                result.setMinPrecipitation(fieldGeneratorMinPrecipitation.value);
                fieldGeneratorMinPrecipitation.have_value = false;
              }
            if (fieldGeneratorAvgPrecipitation.have_value)
              {
                result.setAvgPrecipitation(fieldGeneratorAvgPrecipitation.value);
                fieldGeneratorAvgPrecipitation.have_value = false;
              }
            if (fieldGeneratorMaxPrecipitation.have_value)
              {
                result.setMaxPrecipitation(fieldGeneratorMaxPrecipitation.value);
                fieldGeneratorMaxPrecipitation.have_value = false;
              }
            if (fieldGeneratorMinHighDewPoint.have_value)
              {
                result.setMinHighDewPoint(fieldGeneratorMinHighDewPoint.value);
                fieldGeneratorMinHighDewPoint.have_value = false;
              }
            if (fieldGeneratorAvgHighDewPoint.have_value)
              {
                result.setAvgHighDewPoint(fieldGeneratorAvgHighDewPoint.value);
                fieldGeneratorAvgHighDewPoint.have_value = false;
              }
            if (fieldGeneratorMaxHighDewPoint.have_value)
              {
                result.setMaxHighDewPoint(fieldGeneratorMaxHighDewPoint.value);
                fieldGeneratorMaxHighDewPoint.have_value = false;
              }
            if (fieldGeneratorMinLowDewPoint.have_value)
              {
                result.setMinLowDewPoint(fieldGeneratorMinLowDewPoint.value);
                fieldGeneratorMinLowDewPoint.have_value = false;
              }
            if (fieldGeneratorAvgLowDewPoint.have_value)
              {
                result.setAvgLowDewPoint(fieldGeneratorAvgLowDewPoint.value);
                fieldGeneratorAvgLowDewPoint.have_value = false;
              }
            if (fieldGeneratorMaxLowDewPoint.have_value)
              {
                result.setMaxLowDewPoint(fieldGeneratorMaxLowDewPoint.value);
                fieldGeneratorMaxLowDewPoint.have_value = false;
              }
            if (fieldGeneratorCloudCoverConditions.have_value)
              {
                result.setCloudCoverConditions(fieldGeneratorCloudCoverConditions.value);
                fieldGeneratorCloudCoverConditions.have_value = false;
              }
            if (fieldGeneratorCloudCoverConditionsDisplay.have_value)
              {
                result.setCloudCoverConditionsDisplay(fieldGeneratorCloudCoverConditionsDisplay.value);
                fieldGeneratorCloudCoverConditionsDisplay.have_value = false;
              }
            if (fieldGeneratorCloudCoverConditionsSpoken.have_value)
              {
                result.setCloudCoverConditionsSpoken(fieldGeneratorCloudCoverConditionsSpoken.value);
                fieldGeneratorCloudCoverConditionsSpoken.have_value = false;
              }
            if (fieldGeneratorCloudCoverConditionsWritten.have_value)
              {
                result.setCloudCoverConditionsWritten(fieldGeneratorCloudCoverConditionsWritten.value);
                fieldGeneratorCloudCoverConditionsWritten.have_value = false;
              }
            if (fieldGeneratorChanceOf.have_value)
              {
                result.initChanceOf();
                int count = fieldGeneratorChanceOf.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendChanceOf(fieldGeneratorChanceOf.value[num]);
                  }
                fieldGeneratorChanceOf.value.Clear();
                fieldGeneratorChanceOf.have_value = false;
              }
          }
        protected abstract void handle_result(PlannerJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "vg", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'H':
                                if (String.Compare(field_name, 4, "igh", 0, 3, false) == 0)
                                  {
                                    switch (field_name[7])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 8, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 15))
                                                return fieldGeneratorAvgHighDewPoint;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 8, "emperature", 0, 10, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorAvgHighTemperature;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'L':
                                if (String.Compare(field_name, 4, "ow", 0, 2, false) == 0)
                                  {
                                    switch (field_name[6])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 7, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorAvgLowDewPoint;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 7, "emperature", 0, 10, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorAvgLowTemperature;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 4, "recipitation", 0, 12, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorAvgPrecipitation;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 4, "emperature", 0, 10, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorAvgTemperature;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "anceOf", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorChanceOf;
                            break;
                        case 'l':
                            if (String.Compare(field_name, 2, "oudCoverConditions", 0, 18, false) == 0)
                              {
                                if (field_name.Length == 20)
                                  {
                                    return fieldGeneratorCloudCoverConditions;
                                  }
                                switch (field_name[20])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 21, "isplay", 0, 6, false) == 0) && (field_name.Length == 27))
                                            return fieldGeneratorCloudCoverConditionsDisplay;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 21, "poken", 0, 5, false) == 0) && (field_name.Length == 26))
                                            return fieldGeneratorCloudCoverConditionsSpoken;
                                        break;
                                    case 'W':
                                        if ((String.Compare(field_name, 21, "ritten", 0, 6, false) == 0) && (field_name.Length == 27))
                                            return fieldGeneratorCloudCoverConditionsWritten;
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
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "x", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'H':
                                        if (String.Compare(field_name, 4, "igh", 0, 3, false) == 0)
                                          {
                                            switch (field_name[7])
                                              {
                                                case 'D':
                                                    if ((String.Compare(field_name, 8, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 15))
                                                        return fieldGeneratorMaxHighDewPoint;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(field_name, 8, "emperature", 0, 10, false) == 0) && (field_name.Length == 18))
                                                        return fieldGeneratorMaxHighTemperature;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'L':
                                        if (String.Compare(field_name, 4, "ow", 0, 2, false) == 0)
                                          {
                                            switch (field_name[6])
                                              {
                                                case 'D':
                                                    if ((String.Compare(field_name, 7, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 14))
                                                        return fieldGeneratorMaxLowDewPoint;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(field_name, 7, "emperature", 0, 10, false) == 0) && (field_name.Length == 17))
                                                        return fieldGeneratorMaxLowTemperature;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'P':
                                        if ((String.Compare(field_name, 4, "recipitation", 0, 12, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorMaxPrecipitation;
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
                                    case 'H':
                                        if (String.Compare(field_name, 4, "igh", 0, 3, false) == 0)
                                          {
                                            switch (field_name[7])
                                              {
                                                case 'D':
                                                    if ((String.Compare(field_name, 8, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 15))
                                                        return fieldGeneratorMinHighDewPoint;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(field_name, 8, "emperature", 0, 10, false) == 0) && (field_name.Length == 18))
                                                        return fieldGeneratorMinHighTemperature;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'L':
                                        if (String.Compare(field_name, 4, "ow", 0, 2, false) == 0)
                                          {
                                            switch (field_name[6])
                                              {
                                                case 'D':
                                                    if ((String.Compare(field_name, 7, "ewPoint", 0, 7, false) == 0) && (field_name.Length == 14))
                                                        return fieldGeneratorMinLowDewPoint;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(field_name, 7, "emperature", 0, 10, false) == 0) && (field_name.Length == 17))
                                                        return fieldGeneratorMinLowTemperature;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'P':
                                        if ((String.Compare(field_name, 4, "recipitation", 0, 12, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorMinPrecipitation;
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
                    if (String.Compare(field_name, 1, "lanner", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 8, "ndDateAndTime", 0, 13, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorPlannerEndDateAndTime;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 8, "tartDateAndTime", 0, 15, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorPlannerStartDateAndTime;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPlannerStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"PlannerStartDateAndTime\" of the Planner class", ignore_extras);
            fieldGeneratorPlannerEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"PlannerEndDateAndTime\" of the Planner class", ignore_extras);
            fieldGeneratorMinHighTemperature = new TypeMinHighTemperatureJSON.HoldingGenerator("field \"MinHighTemperature\" of the Planner class", ignore_extras);
            fieldGeneratorAvgHighTemperature = new TypeAvgHighTemperatureJSON.HoldingGenerator("field \"AvgHighTemperature\" of the Planner class", ignore_extras);
            fieldGeneratorMaxHighTemperature = new TypeMaxHighTemperatureJSON.HoldingGenerator("field \"MaxHighTemperature\" of the Planner class", ignore_extras);
            fieldGeneratorMinLowTemperature = new TypeMinLowTemperatureJSON.HoldingGenerator("field \"MinLowTemperature\" of the Planner class", ignore_extras);
            fieldGeneratorAvgLowTemperature = new TypeAvgLowTemperatureJSON.HoldingGenerator("field \"AvgLowTemperature\" of the Planner class", ignore_extras);
            fieldGeneratorMaxLowTemperature = new TypeMaxLowTemperatureJSON.HoldingGenerator("field \"MaxLowTemperature\" of the Planner class", ignore_extras);
            fieldGeneratorAvgTemperature = new TypeAvgTemperatureJSON.HoldingGenerator("field \"AvgTemperature\" of the Planner class", ignore_extras);
            fieldGeneratorMinPrecipitation = new TypeMinPrecipitationJSON.HoldingGenerator("field \"MinPrecipitation\" of the Planner class", ignore_extras);
            fieldGeneratorAvgPrecipitation = new TypeAvgPrecipitationJSON.HoldingGenerator("field \"AvgPrecipitation\" of the Planner class", ignore_extras);
            fieldGeneratorMaxPrecipitation = new TypeMaxPrecipitationJSON.HoldingGenerator("field \"MaxPrecipitation\" of the Planner class", ignore_extras);
            fieldGeneratorMinHighDewPoint = new TypeMinHighDewPointJSON.HoldingGenerator("field \"MinHighDewPoint\" of the Planner class", ignore_extras);
            fieldGeneratorAvgHighDewPoint = new TypeAvgHighDewPointJSON.HoldingGenerator("field \"AvgHighDewPoint\" of the Planner class", ignore_extras);
            fieldGeneratorMaxHighDewPoint = new TypeMaxHighDewPointJSON.HoldingGenerator("field \"MaxHighDewPoint\" of the Planner class", ignore_extras);
            fieldGeneratorMinLowDewPoint = new TypeMinLowDewPointJSON.HoldingGenerator("field \"MinLowDewPoint\" of the Planner class", ignore_extras);
            fieldGeneratorAvgLowDewPoint = new TypeAvgLowDewPointJSON.HoldingGenerator("field \"AvgLowDewPoint\" of the Planner class", ignore_extras);
            fieldGeneratorMaxLowDewPoint = new TypeMaxLowDewPointJSON.HoldingGenerator("field \"MaxLowDewPoint\" of the Planner class", ignore_extras);
            fieldGeneratorCloudCoverConditions = new FieldHoldingGeneratorCloudCoverConditions("field \"CloudCoverConditions\" of the Planner class");
            fieldGeneratorCloudCoverConditionsDisplay = new JSONHoldingStringGenerator("field \"CloudCoverConditionsDisplay\" of the Planner class");
            fieldGeneratorCloudCoverConditionsSpoken = new JSONHoldingStringGenerator("field \"CloudCoverConditionsSpoken\" of the Planner class");
            fieldGeneratorCloudCoverConditionsWritten = new JSONHoldingStringGenerator("field \"CloudCoverConditionsWritten\" of the Planner class");
            fieldGeneratorChanceOf = new PercentageBasedWeatherDataJSON.HoldingArrayGenerator("field \"ChanceOf\" of the Planner class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Planner class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPlannerStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"PlannerStartDateAndTime\" of the Planner class", false);
            fieldGeneratorPlannerEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"PlannerEndDateAndTime\" of the Planner class", false);
            fieldGeneratorMinHighTemperature = new TypeMinHighTemperatureJSON.HoldingGenerator("field \"MinHighTemperature\" of the Planner class", false);
            fieldGeneratorAvgHighTemperature = new TypeAvgHighTemperatureJSON.HoldingGenerator("field \"AvgHighTemperature\" of the Planner class", false);
            fieldGeneratorMaxHighTemperature = new TypeMaxHighTemperatureJSON.HoldingGenerator("field \"MaxHighTemperature\" of the Planner class", false);
            fieldGeneratorMinLowTemperature = new TypeMinLowTemperatureJSON.HoldingGenerator("field \"MinLowTemperature\" of the Planner class", false);
            fieldGeneratorAvgLowTemperature = new TypeAvgLowTemperatureJSON.HoldingGenerator("field \"AvgLowTemperature\" of the Planner class", false);
            fieldGeneratorMaxLowTemperature = new TypeMaxLowTemperatureJSON.HoldingGenerator("field \"MaxLowTemperature\" of the Planner class", false);
            fieldGeneratorAvgTemperature = new TypeAvgTemperatureJSON.HoldingGenerator("field \"AvgTemperature\" of the Planner class", false);
            fieldGeneratorMinPrecipitation = new TypeMinPrecipitationJSON.HoldingGenerator("field \"MinPrecipitation\" of the Planner class", false);
            fieldGeneratorAvgPrecipitation = new TypeAvgPrecipitationJSON.HoldingGenerator("field \"AvgPrecipitation\" of the Planner class", false);
            fieldGeneratorMaxPrecipitation = new TypeMaxPrecipitationJSON.HoldingGenerator("field \"MaxPrecipitation\" of the Planner class", false);
            fieldGeneratorMinHighDewPoint = new TypeMinHighDewPointJSON.HoldingGenerator("field \"MinHighDewPoint\" of the Planner class", false);
            fieldGeneratorAvgHighDewPoint = new TypeAvgHighDewPointJSON.HoldingGenerator("field \"AvgHighDewPoint\" of the Planner class", false);
            fieldGeneratorMaxHighDewPoint = new TypeMaxHighDewPointJSON.HoldingGenerator("field \"MaxHighDewPoint\" of the Planner class", false);
            fieldGeneratorMinLowDewPoint = new TypeMinLowDewPointJSON.HoldingGenerator("field \"MinLowDewPoint\" of the Planner class", false);
            fieldGeneratorAvgLowDewPoint = new TypeAvgLowDewPointJSON.HoldingGenerator("field \"AvgLowDewPoint\" of the Planner class", false);
            fieldGeneratorMaxLowDewPoint = new TypeMaxLowDewPointJSON.HoldingGenerator("field \"MaxLowDewPoint\" of the Planner class", false);
            fieldGeneratorCloudCoverConditions = new FieldHoldingGeneratorCloudCoverConditions("field \"CloudCoverConditions\" of the Planner class");
            fieldGeneratorCloudCoverConditionsDisplay = new JSONHoldingStringGenerator("field \"CloudCoverConditionsDisplay\" of the Planner class");
            fieldGeneratorCloudCoverConditionsSpoken = new JSONHoldingStringGenerator("field \"CloudCoverConditionsSpoken\" of the Planner class");
            fieldGeneratorCloudCoverConditionsWritten = new JSONHoldingStringGenerator("field \"CloudCoverConditionsWritten\" of the Planner class");
            fieldGeneratorChanceOf = new PercentageBasedWeatherDataJSON.HoldingArrayGenerator("field \"ChanceOf\" of the Planner class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Planner class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPlannerStartDateAndTime.reset();
            fieldGeneratorPlannerEndDateAndTime.reset();
            fieldGeneratorMinHighTemperature.reset();
            fieldGeneratorAvgHighTemperature.reset();
            fieldGeneratorMaxHighTemperature.reset();
            fieldGeneratorMinLowTemperature.reset();
            fieldGeneratorAvgLowTemperature.reset();
            fieldGeneratorMaxLowTemperature.reset();
            fieldGeneratorAvgTemperature.reset();
            fieldGeneratorMinPrecipitation.reset();
            fieldGeneratorAvgPrecipitation.reset();
            fieldGeneratorMaxPrecipitation.reset();
            fieldGeneratorMinHighDewPoint.reset();
            fieldGeneratorAvgHighDewPoint.reset();
            fieldGeneratorMaxHighDewPoint.reset();
            fieldGeneratorMinLowDewPoint.reset();
            fieldGeneratorAvgLowDewPoint.reset();
            fieldGeneratorMaxLowDewPoint.reset();
            fieldGeneratorCloudCoverConditions.reset();
            fieldGeneratorCloudCoverConditionsDisplay.reset();
            fieldGeneratorCloudCoverConditionsSpoken.reset();
            fieldGeneratorCloudCoverConditionsWritten.reset();
            fieldGeneratorChanceOf.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPlannerStartDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPlannerEndDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMinHighTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAvgHighTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMaxHighTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMinLowTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAvgLowTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMaxLowTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAvgTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMinPrecipitation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAvgPrecipitation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMaxPrecipitation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMinHighDewPoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAvgHighDewPoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMaxHighDewPoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMinLowDewPoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAvgLowDewPoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMaxLowDewPoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorChanceOf.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPlannerStartDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPlannerEndDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMinHighTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAvgHighTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMaxHighTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMinLowTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAvgLowTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMaxLowTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAvgTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMinPrecipitation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAvgPrecipitation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMaxPrecipitation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMinHighDewPoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAvgHighDewPoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMaxHighDewPoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMinLowDewPoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAvgLowDewPoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMaxLowDewPoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorChanceOf.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(PlannerJSON  result)
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
        public PlannerJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PlannerJSON  result)
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
    protected virtual void handle_result(List<PlannerJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PlannerJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PlannerJSON>();
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
    public List<PlannerJSON> value;
  };
  };
