/* file "DailyForecastDayPartJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DailyForecastDayPartJSON : JSONBase
  {
    public class TypeLiquidTotalJSON : JSONBase
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


        public TypeLiquidTotalJSON()
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


        public virtual int extraTypeLiquidTotalComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeLiquidTotalComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeLiquidTotalComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeLiquidTotalLookup(string field_name)
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

        public virtual void extraTypeLiquidTotalAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeLiquidTotalSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeLiquidTotalLookup(key);
            if (old_field == null)
              {
                extraTypeLiquidTotalAppendPair(key, new_component);
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

        public static TypeLiquidTotalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLiquidTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLiquidTotal", ignore_extras);
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
        public static TypeLiquidTotalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLiquidTotalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLiquidTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLiquidTotal", ignore_extras);
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
        public static TypeLiquidTotalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLiquidTotalJSON from_text(string text, bool ignore_extras)
          {
            TypeLiquidTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLiquidTotal", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeLiquidTotalJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeLiquidTotalJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeLiquidTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLiquidTotal", ignore_extras);
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
                TypeLiquidTotalJSON result = new TypeLiquidTotalJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeLiquidTotalAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeLiquidTotalJSON result)
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
            protected abstract void handle_result(TypeLiquidTotalJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypeLiquidTotal class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeLiquidTotal class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypeLiquidTotal class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeLiquidTotal class");
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
            protected override void handle_result(TypeLiquidTotalJSON  result)
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
            public TypeLiquidTotalJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeLiquidTotalJSON  result)
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
        protected virtual void handle_result(List<TypeLiquidTotalJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeLiquidTotalJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeLiquidTotalJSON>();
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
        public List<TypeLiquidTotalJSON> value;
      };
      };
    public class TypeRainTotalJSON : JSONBase
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


        public TypeRainTotalJSON()
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


        public virtual int extraTypeRainTotalComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeRainTotalComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeRainTotalComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeRainTotalLookup(string field_name)
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

        public virtual void extraTypeRainTotalAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeRainTotalSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeRainTotalLookup(key);
            if (old_field == null)
              {
                extraTypeRainTotalAppendPair(key, new_component);
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

        public static TypeRainTotalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRainTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRainTotal", ignore_extras);
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
        public static TypeRainTotalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRainTotalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRainTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRainTotal", ignore_extras);
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
        public static TypeRainTotalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRainTotalJSON from_text(string text, bool ignore_extras)
          {
            TypeRainTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRainTotal", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeRainTotalJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeRainTotalJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeRainTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRainTotal", ignore_extras);
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
                TypeRainTotalJSON result = new TypeRainTotalJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeRainTotalAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeRainTotalJSON result)
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
            protected abstract void handle_result(TypeRainTotalJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypeRainTotal class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeRainTotal class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypeRainTotal class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeRainTotal class");
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
            protected override void handle_result(TypeRainTotalJSON  result)
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
            public TypeRainTotalJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeRainTotalJSON  result)
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
        protected virtual void handle_result(List<TypeRainTotalJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeRainTotalJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeRainTotalJSON>();
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
        public List<TypeRainTotalJSON> value;
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
    public class TypeIceTotalJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_IceJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_IceJSON convert_classy = UnitsValue_IceJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeIceTotalJSON()
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

        public UnitsValue_IceJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeIceTotalComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeIceTotalComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeIceTotalComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeIceTotalLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_IceJSON  new_value)
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

        public virtual void extraTypeIceTotalAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeIceTotalSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeIceTotalLookup(key);
            if (old_field == null)
              {
                extraTypeIceTotalAppendPair(key, new_component);
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

        public static TypeIceTotalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeIceTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeIceTotal", ignore_extras);
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
        public static TypeIceTotalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeIceTotalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeIceTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeIceTotal", ignore_extras);
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
        public static TypeIceTotalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeIceTotalJSON from_text(string text, bool ignore_extras)
          {
            TypeIceTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeIceTotal", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeIceTotalJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeIceTotalJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeIceTotalJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeIceTotal", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_IceJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeIceTotalJSON result = new TypeIceTotalJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeIceTotalAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeIceTotalJSON result)
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
            protected abstract void handle_result(TypeIceTotalJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_IceJSON.HoldingGenerator("field \"Value\" of the TypeIceTotal class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeIceTotal class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_IceJSON.HoldingGenerator("field \"Value\" of the TypeIceTotal class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeIceTotal class");
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
            protected override void handle_result(TypeIceTotalJSON  result)
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
            public TypeIceTotalJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeIceTotalJSON  result)
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
        protected virtual void handle_result(List<TypeIceTotalJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeIceTotalJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeIceTotalJSON>();
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
        public List<TypeIceTotalJSON> value;
      };
      };
    private bool flagHasConditionsImage;
    private WeatherImageJSON  storeConditionsImage;
    private bool flagHasIconPhrase;
    private ForecastShortPhraseJSON  storeIconPhrase;
    private bool flagHasIconPhraseDisplay;
    private string storeIconPhraseDisplay;
    private bool flagHasIconPhraseSpoken;
    private string storeIconPhraseSpoken;
    private bool flagHasIconPhraseWritten;
    private string storeIconPhraseWritten;
    private bool flagHasShortPhrase;
    private string storeShortPhrase;
    private bool flagHasLongPhrase;
    private string storeLongPhrase;
    private bool flagHasWind;
    private WindDataJSON  storeWind;
    private bool flagHasWindGust;
    private WindDataJSON  storeWindGust;
    private bool flagHasLiquidTotal;
    private TypeLiquidTotalJSON  storeLiquidTotal;
    private bool flagHasRainTotal;
    private TypeRainTotalJSON  storeRainTotal;
    private bool flagHasSnowTotal;
    private TypeSnowTotalJSON  storeSnowTotal;
    private bool flagHasIceTotal;
    private TypeIceTotalJSON  storeIceTotal;
    private bool flagHasProbabilityOfPrecipitationPct;
    private sbyte storeProbabilityOfPrecipitationPct;
    private bool flagHasProbabilityOfThunderstormPct;
    private sbyte storeProbabilityOfThunderstormPct;
    private bool flagHasProbabilityOfRainPct;
    private sbyte storeProbabilityOfRainPct;
    private bool flagHasProbabilityOfSnowPct;
    private sbyte storeProbabilityOfSnowPct;
    private bool flagHasProbabilityOfIcePct;
    private sbyte storeProbabilityOfIcePct;
    private bool flagHasHoursOfPrecipitation;
    private double storeHoursOfPrecipitation;
    private string textStoreHoursOfPrecipitation;
    private bool flagHasHoursOfRain;
    private double storeHoursOfRain;
    private string textStoreHoursOfRain;
    private bool flagHasCloudCoverPct;
    private sbyte storeCloudCoverPct;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONConditionsImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherImageJSON convert_classy = WeatherImageJSON.from_json(json_value, ignore_extras, true);
        setConditionsImage(convert_classy);
      }


    private void  fromJSONIconPhrase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ForecastShortPhraseJSON convert_classy = ForecastShortPhraseJSON.from_json(json_value, ignore_extras, true);
        setIconPhrase(convert_classy);
      }


    private void  fromJSONIconPhraseDisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IconPhraseDisplay of DailyForecastDayPartJSON is not a string.");
        setIconPhraseDisplay(json_string.getData());
      }


    private void  fromJSONIconPhraseSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IconPhraseSpoken of DailyForecastDayPartJSON is not a string.");
        setIconPhraseSpoken(json_string.getData());
      }


    private void  fromJSONIconPhraseWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IconPhraseWritten of DailyForecastDayPartJSON is not a string.");
        setIconPhraseWritten(json_string.getData());
      }


    private void  fromJSONShortPhrase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShortPhrase of DailyForecastDayPartJSON is not a string.");
        setShortPhrase(json_string.getData());
      }


    private void  fromJSONLongPhrase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LongPhrase of DailyForecastDayPartJSON is not a string.");
        setLongPhrase(json_string.getData());
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
        WindDataJSON convert_classy = WindDataJSON.from_json(json_value, ignore_extras, true);
        setWindGust(convert_classy);
      }


    private void  fromJSONLiquidTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeLiquidTotalJSON convert_classy = TypeLiquidTotalJSON.from_json(json_value, ignore_extras, true);
        setLiquidTotal(convert_classy);
      }


    private void  fromJSONRainTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeRainTotalJSON convert_classy = TypeRainTotalJSON.from_json(json_value, ignore_extras, true);
        setRainTotal(convert_classy);
      }


    private void  fromJSONSnowTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSnowTotalJSON convert_classy = TypeSnowTotalJSON.from_json(json_value, ignore_extras, true);
        setSnowTotal(convert_classy);
      }


    private void  fromJSONIceTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeIceTotalJSON convert_classy = TypeIceTotalJSON.from_json(json_value, ignore_extras, true);
        setIceTotal(convert_classy);
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
                throw new Exception("The value for field ProbabilityOfPrecipitationPct of DailyForecastDayPartJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProbabilityOfPrecipitationPct of DailyForecastDayPartJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setProbabilityOfPrecipitationPct(extracted_integer);
      }


    private void  fromJSONProbabilityOfThunderstormPct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ProbabilityOfThunderstormPct of DailyForecastDayPartJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProbabilityOfThunderstormPct of DailyForecastDayPartJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setProbabilityOfThunderstormPct(extracted_integer);
      }


    private void  fromJSONProbabilityOfRainPct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ProbabilityOfRainPct of DailyForecastDayPartJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProbabilityOfRainPct of DailyForecastDayPartJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setProbabilityOfRainPct(extracted_integer);
      }


    private void  fromJSONProbabilityOfSnowPct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ProbabilityOfSnowPct of DailyForecastDayPartJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProbabilityOfSnowPct of DailyForecastDayPartJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setProbabilityOfSnowPct(extracted_integer);
      }


    private void  fromJSONProbabilityOfIcePct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ProbabilityOfIcePct of DailyForecastDayPartJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProbabilityOfIcePct of DailyForecastDayPartJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setProbabilityOfIcePct(extracted_integer);
      }


    private void  fromJSONHoursOfPrecipitation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field HoursOfPrecipitation of DailyForecastDayPartJSON is not a number.");
              }
          }
        setHoursOfPrecipitationText(the_rational_text);
      }


    private void  fromJSONHoursOfRain(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field HoursOfRain of DailyForecastDayPartJSON is not a number.");
              }
          }
        setHoursOfRainText(the_rational_text);
      }


    private void  fromJSONCloudCoverPct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CloudCoverPct of DailyForecastDayPartJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CloudCoverPct of DailyForecastDayPartJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setCloudCoverPct(extracted_integer);
      }


    public DailyForecastDayPartJSON()
      {
        flagHasConditionsImage = false;
        flagHasIconPhrase = false;
        flagHasIconPhraseDisplay = false;
        flagHasIconPhraseSpoken = false;
        flagHasIconPhraseWritten = false;
        flagHasShortPhrase = false;
        flagHasLongPhrase = false;
        flagHasWind = false;
        flagHasWindGust = false;
        flagHasLiquidTotal = false;
        flagHasRainTotal = false;
        flagHasSnowTotal = false;
        flagHasIceTotal = false;
        flagHasProbabilityOfPrecipitationPct = false;
        flagHasProbabilityOfThunderstormPct = false;
        flagHasProbabilityOfRainPct = false;
        flagHasProbabilityOfSnowPct = false;
        flagHasProbabilityOfIcePct = false;
        flagHasHoursOfPrecipitation = false;
        flagHasHoursOfRain = false;
        flagHasCloudCoverPct = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasIconPhrase()
      {
        return flagHasIconPhrase;
      }

    public ForecastShortPhraseJSON   getIconPhrase()
      {
        Debug.Assert(flagHasIconPhrase);
        return storeIconPhrase;
      }

    public ForecastShortPhraseJSON.TypeValue  getIconPhraseValue()
      {
        return getIconPhrase().getValue();
      }

    public string  getIconPhraseAsString()
      {
        return getIconPhrase().getValueAsString();
      }

    public bool  hasIconPhraseDisplay()
      {
        return flagHasIconPhraseDisplay;
      }

    public string  getIconPhraseDisplay()
      {
        Debug.Assert(flagHasIconPhraseDisplay);
        return storeIconPhraseDisplay;
      }

    public bool  hasIconPhraseSpoken()
      {
        return flagHasIconPhraseSpoken;
      }

    public string  getIconPhraseSpoken()
      {
        Debug.Assert(flagHasIconPhraseSpoken);
        return storeIconPhraseSpoken;
      }

    public bool  hasIconPhraseWritten()
      {
        return flagHasIconPhraseWritten;
      }

    public string  getIconPhraseWritten()
      {
        Debug.Assert(flagHasIconPhraseWritten);
        return storeIconPhraseWritten;
      }

    public bool  hasShortPhrase()
      {
        return flagHasShortPhrase;
      }

    public string  getShortPhrase()
      {
        Debug.Assert(flagHasShortPhrase);
        return storeShortPhrase;
      }

    public bool  hasLongPhrase()
      {
        return flagHasLongPhrase;
      }

    public string  getLongPhrase()
      {
        Debug.Assert(flagHasLongPhrase);
        return storeLongPhrase;
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

    public WindDataJSON   getWindGust()
      {
        Debug.Assert(flagHasWindGust);
        return storeWindGust;
      }

    public bool  hasLiquidTotal()
      {
        return flagHasLiquidTotal;
      }

    public TypeLiquidTotalJSON   getLiquidTotal()
      {
        Debug.Assert(flagHasLiquidTotal);
        return storeLiquidTotal;
      }

    public bool  hasRainTotal()
      {
        return flagHasRainTotal;
      }

    public TypeRainTotalJSON   getRainTotal()
      {
        Debug.Assert(flagHasRainTotal);
        return storeRainTotal;
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

    public bool  hasIceTotal()
      {
        return flagHasIceTotal;
      }

    public TypeIceTotalJSON   getIceTotal()
      {
        Debug.Assert(flagHasIceTotal);
        return storeIceTotal;
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

    public bool  hasProbabilityOfThunderstormPct()
      {
        return flagHasProbabilityOfThunderstormPct;
      }

    public sbyte  getProbabilityOfThunderstormPct()
      {
        Debug.Assert(flagHasProbabilityOfThunderstormPct);
        return storeProbabilityOfThunderstormPct;
      }

    public bool  hasProbabilityOfRainPct()
      {
        return flagHasProbabilityOfRainPct;
      }

    public sbyte  getProbabilityOfRainPct()
      {
        Debug.Assert(flagHasProbabilityOfRainPct);
        return storeProbabilityOfRainPct;
      }

    public bool  hasProbabilityOfSnowPct()
      {
        return flagHasProbabilityOfSnowPct;
      }

    public sbyte  getProbabilityOfSnowPct()
      {
        Debug.Assert(flagHasProbabilityOfSnowPct);
        return storeProbabilityOfSnowPct;
      }

    public bool  hasProbabilityOfIcePct()
      {
        return flagHasProbabilityOfIcePct;
      }

    public sbyte  getProbabilityOfIcePct()
      {
        Debug.Assert(flagHasProbabilityOfIcePct);
        return storeProbabilityOfIcePct;
      }

    public bool  hasHoursOfPrecipitation()
      {
        return flagHasHoursOfPrecipitation;
      }

    public double  getHoursOfPrecipitation()
      {
        Debug.Assert(flagHasHoursOfPrecipitation);
        if (textStoreHoursOfPrecipitation != "")
          {
            return Double.Parse(textStoreHoursOfPrecipitation);
          }
        return storeHoursOfPrecipitation;
      }

    public string  getHoursOfPrecipitationAsText()
      {
        Debug.Assert(flagHasHoursOfPrecipitation);
        if (textStoreHoursOfPrecipitation == "")
          {
            return Convert.ToString(storeHoursOfPrecipitation);
          }
        else
          {
            return (textStoreHoursOfPrecipitation);
          }
      }

    public bool  hasHoursOfRain()
      {
        return flagHasHoursOfRain;
      }

    public double  getHoursOfRain()
      {
        Debug.Assert(flagHasHoursOfRain);
        if (textStoreHoursOfRain != "")
          {
            return Double.Parse(textStoreHoursOfRain);
          }
        return storeHoursOfRain;
      }

    public string  getHoursOfRainAsText()
      {
        Debug.Assert(flagHasHoursOfRain);
        if (textStoreHoursOfRain == "")
          {
            return Convert.ToString(storeHoursOfRain);
          }
        else
          {
            return (textStoreHoursOfRain);
          }
      }

    public bool  hasCloudCoverPct()
      {
        return flagHasCloudCoverPct;
      }

    public sbyte  getCloudCoverPct()
      {
        Debug.Assert(flagHasCloudCoverPct);
        return storeCloudCoverPct;
      }


    public virtual int extraDailyForecastDayPartComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDailyForecastDayPartComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDailyForecastDayPartComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDailyForecastDayPartLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setIconPhrase(ForecastShortPhraseJSON  new_value)
      {
        if (flagHasIconPhrase)
          {
          }
        flagHasIconPhrase = true;
        storeIconPhrase = new_value;
      }
    public void setIconPhrase(ForecastShortPhraseJSON.TypeValue new_value)
      {
        setIconPhrase(new ForecastShortPhraseJSON(new_value));
      }
    public void setIconPhrase(string chars)
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
        setIconPhrase(new_value);
      }
    public void unsetIconPhrase()
      {
        if (flagHasIconPhrase)
          {
          }
        flagHasIconPhrase = false;
      }
    public void setIconPhraseDisplay(string new_value)
      {
        flagHasIconPhraseDisplay = true;
        storeIconPhraseDisplay = new_value;
      }
    public void unsetIconPhraseDisplay()
      {
        flagHasIconPhraseDisplay = false;
      }
    public void setIconPhraseSpoken(string new_value)
      {
        flagHasIconPhraseSpoken = true;
        storeIconPhraseSpoken = new_value;
      }
    public void unsetIconPhraseSpoken()
      {
        flagHasIconPhraseSpoken = false;
      }
    public void setIconPhraseWritten(string new_value)
      {
        flagHasIconPhraseWritten = true;
        storeIconPhraseWritten = new_value;
      }
    public void unsetIconPhraseWritten()
      {
        flagHasIconPhraseWritten = false;
      }
    public void setShortPhrase(string new_value)
      {
        flagHasShortPhrase = true;
        storeShortPhrase = new_value;
      }
    public void unsetShortPhrase()
      {
        flagHasShortPhrase = false;
      }
    public void setLongPhrase(string new_value)
      {
        flagHasLongPhrase = true;
        storeLongPhrase = new_value;
      }
    public void unsetLongPhrase()
      {
        flagHasLongPhrase = false;
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
    public void setWindGust(WindDataJSON  new_value)
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
    public void setLiquidTotal(TypeLiquidTotalJSON  new_value)
      {
        if (flagHasLiquidTotal)
          {
          }
        flagHasLiquidTotal = true;
        storeLiquidTotal = new_value;
      }
    public void unsetLiquidTotal()
      {
        if (flagHasLiquidTotal)
          {
          }
        flagHasLiquidTotal = false;
      }
    public void setRainTotal(TypeRainTotalJSON  new_value)
      {
        if (flagHasRainTotal)
          {
          }
        flagHasRainTotal = true;
        storeRainTotal = new_value;
      }
    public void unsetRainTotal()
      {
        if (flagHasRainTotal)
          {
          }
        flagHasRainTotal = false;
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
    public void setIceTotal(TypeIceTotalJSON  new_value)
      {
        if (flagHasIceTotal)
          {
          }
        flagHasIceTotal = true;
        storeIceTotal = new_value;
      }
    public void unsetIceTotal()
      {
        if (flagHasIceTotal)
          {
          }
        flagHasIceTotal = false;
      }
    public void setProbabilityOfPrecipitationPct(sbyte new_value)
      {
        flagHasProbabilityOfPrecipitationPct = true;
        if (new_value < 0)
            throw new Exception("The value for field ProbabilityOfPrecipitationPct of DailyForecastDayPartJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field ProbabilityOfPrecipitationPct of DailyForecastDayPartJSON is greater than the upper bound (100) for that field.");
        storeProbabilityOfPrecipitationPct = new_value;
      }
    public void unsetProbabilityOfPrecipitationPct()
      {
        flagHasProbabilityOfPrecipitationPct = false;
      }
    public void setProbabilityOfThunderstormPct(sbyte new_value)
      {
        flagHasProbabilityOfThunderstormPct = true;
        if (new_value < 0)
            throw new Exception("The value for field ProbabilityOfThunderstormPct of DailyForecastDayPartJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field ProbabilityOfThunderstormPct of DailyForecastDayPartJSON is greater than the upper bound (100) for that field.");
        storeProbabilityOfThunderstormPct = new_value;
      }
    public void unsetProbabilityOfThunderstormPct()
      {
        flagHasProbabilityOfThunderstormPct = false;
      }
    public void setProbabilityOfRainPct(sbyte new_value)
      {
        flagHasProbabilityOfRainPct = true;
        if (new_value < 0)
            throw new Exception("The value for field ProbabilityOfRainPct of DailyForecastDayPartJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field ProbabilityOfRainPct of DailyForecastDayPartJSON is greater than the upper bound (100) for that field.");
        storeProbabilityOfRainPct = new_value;
      }
    public void unsetProbabilityOfRainPct()
      {
        flagHasProbabilityOfRainPct = false;
      }
    public void setProbabilityOfSnowPct(sbyte new_value)
      {
        flagHasProbabilityOfSnowPct = true;
        if (new_value < 0)
            throw new Exception("The value for field ProbabilityOfSnowPct of DailyForecastDayPartJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field ProbabilityOfSnowPct of DailyForecastDayPartJSON is greater than the upper bound (100) for that field.");
        storeProbabilityOfSnowPct = new_value;
      }
    public void unsetProbabilityOfSnowPct()
      {
        flagHasProbabilityOfSnowPct = false;
      }
    public void setProbabilityOfIcePct(sbyte new_value)
      {
        flagHasProbabilityOfIcePct = true;
        if (new_value < 0)
            throw new Exception("The value for field ProbabilityOfIcePct of DailyForecastDayPartJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field ProbabilityOfIcePct of DailyForecastDayPartJSON is greater than the upper bound (100) for that field.");
        storeProbabilityOfIcePct = new_value;
      }
    public void unsetProbabilityOfIcePct()
      {
        flagHasProbabilityOfIcePct = false;
      }
    public void setHoursOfPrecipitation(double new_value)
      {
        flagHasHoursOfPrecipitation = true;
        if (new_value < 0)
            throw new Exception("The value for field HoursOfPrecipitation of DailyForecastDayPartJSON is less than the lower bound (0) for that field.");
        storeHoursOfPrecipitation = new_value;
        textStoreHoursOfPrecipitation = "";
      }
    public void setHoursOfPrecipitationText(string new_value)
      {
        flagHasHoursOfPrecipitation = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HoursOfPrecipitation of DailyForecastDayPartJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HoursOfPrecipitation of DailyForecastDayPartJSON is less than the lower bound (0) for that field.");
        textStoreHoursOfPrecipitation = new_value;
      }
    public void unsetHoursOfPrecipitation()
      {
        flagHasHoursOfPrecipitation = false;
      }
    public void setHoursOfRain(double new_value)
      {
        flagHasHoursOfRain = true;
        if (new_value < 0)
            throw new Exception("The value for field HoursOfRain of DailyForecastDayPartJSON is less than the lower bound (0) for that field.");
        storeHoursOfRain = new_value;
        textStoreHoursOfRain = "";
      }
    public void setHoursOfRainText(string new_value)
      {
        flagHasHoursOfRain = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field HoursOfRain of DailyForecastDayPartJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field HoursOfRain of DailyForecastDayPartJSON is less than the lower bound (0) for that field.");
        textStoreHoursOfRain = new_value;
      }
    public void unsetHoursOfRain()
      {
        flagHasHoursOfRain = false;
      }
    public void setCloudCoverPct(sbyte new_value)
      {
        flagHasCloudCoverPct = true;
        if (new_value < 0)
            throw new Exception("The value for field CloudCoverPct of DailyForecastDayPartJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field CloudCoverPct of DailyForecastDayPartJSON is greater than the upper bound (100) for that field.");
        storeCloudCoverPct = new_value;
      }
    public void unsetCloudCoverPct()
      {
        flagHasCloudCoverPct = false;
      }

    public virtual void extraDailyForecastDayPartAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDailyForecastDayPartSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDailyForecastDayPartLookup(key);
        if (old_field == null)
          {
            extraDailyForecastDayPartAppendPair(key, new_component);
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
        if (flagHasConditionsImage)
          {
            handler.start_pair("ConditionsImage");
            if (partial_allowed)
                storeConditionsImage.write_partial_as_json(handler);
            else
                storeConditionsImage.write_as_json(handler);
          }
        if (flagHasIconPhrase)
          {
            handler.start_pair("IconPhrase");
            if (partial_allowed)
                storeIconPhrase.write_partial_as_json(handler);
            else
                storeIconPhrase.write_as_json(handler);
          }
        if (flagHasIconPhraseDisplay)
          {
            handler.start_pair("IconPhraseDisplay");
            handler.string_value(storeIconPhraseDisplay);
          }
        if (flagHasIconPhraseSpoken)
          {
            handler.start_pair("IconPhraseSpoken");
            handler.string_value(storeIconPhraseSpoken);
          }
        if (flagHasIconPhraseWritten)
          {
            handler.start_pair("IconPhraseWritten");
            handler.string_value(storeIconPhraseWritten);
          }
        if (flagHasShortPhrase)
          {
            handler.start_pair("ShortPhrase");
            handler.string_value(storeShortPhrase);
          }
        if (flagHasLongPhrase)
          {
            handler.start_pair("LongPhrase");
            handler.string_value(storeLongPhrase);
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
        if (flagHasLiquidTotal)
          {
            handler.start_pair("LiquidTotal");
            if (partial_allowed)
                storeLiquidTotal.write_partial_as_json(handler);
            else
                storeLiquidTotal.write_as_json(handler);
          }
        if (flagHasRainTotal)
          {
            handler.start_pair("RainTotal");
            if (partial_allowed)
                storeRainTotal.write_partial_as_json(handler);
            else
                storeRainTotal.write_as_json(handler);
          }
        if (flagHasSnowTotal)
          {
            handler.start_pair("SnowTotal");
            if (partial_allowed)
                storeSnowTotal.write_partial_as_json(handler);
            else
                storeSnowTotal.write_as_json(handler);
          }
        if (flagHasIceTotal)
          {
            handler.start_pair("IceTotal");
            if (partial_allowed)
                storeIceTotal.write_partial_as_json(handler);
            else
                storeIceTotal.write_as_json(handler);
          }
        if (flagHasProbabilityOfPrecipitationPct)
          {
            handler.start_pair("ProbabilityOfPrecipitationPct");
            handler.number_value(storeProbabilityOfPrecipitationPct);
          }
        if (flagHasProbabilityOfThunderstormPct)
          {
            handler.start_pair("ProbabilityOfThunderstormPct");
            handler.number_value(storeProbabilityOfThunderstormPct);
          }
        if (flagHasProbabilityOfRainPct)
          {
            handler.start_pair("ProbabilityOfRainPct");
            handler.number_value(storeProbabilityOfRainPct);
          }
        if (flagHasProbabilityOfSnowPct)
          {
            handler.start_pair("ProbabilityOfSnowPct");
            handler.number_value(storeProbabilityOfSnowPct);
          }
        if (flagHasProbabilityOfIcePct)
          {
            handler.start_pair("ProbabilityOfIcePct");
            handler.number_value(storeProbabilityOfIcePct);
          }
        if (flagHasHoursOfPrecipitation)
          {
            handler.start_pair("HoursOfPrecipitation");
            if (textStoreHoursOfPrecipitation != "")
                handler.number_value(textStoreHoursOfPrecipitation);
            else if (((double)(long)storeHoursOfPrecipitation) == storeHoursOfPrecipitation)
                handler.number_value((long)storeHoursOfPrecipitation);
            else
                handler.number_value(storeHoursOfPrecipitation);
          }
        if (flagHasHoursOfRain)
          {
            handler.start_pair("HoursOfRain");
            if (textStoreHoursOfRain != "")
                handler.number_value(textStoreHoursOfRain);
            else if (((double)(long)storeHoursOfRain) == storeHoursOfRain)
                handler.number_value((long)storeHoursOfRain);
            else
                handler.number_value(storeHoursOfRain);
          }
        if (flagHasCloudCoverPct)
          {
            handler.start_pair("CloudCoverPct");
            handler.number_value(storeCloudCoverPct);
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

    public static DailyForecastDayPartJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DailyForecastDayPartJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyForecastDayPart", ignore_extras);
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
    public static DailyForecastDayPartJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DailyForecastDayPartJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DailyForecastDayPartJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyForecastDayPart", ignore_extras);
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
    public static DailyForecastDayPartJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DailyForecastDayPartJSON from_text(string text, bool ignore_extras)
      {
        DailyForecastDayPartJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyForecastDayPart", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DailyForecastDayPartJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DailyForecastDayPartJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DailyForecastDayPartJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyForecastDayPart", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private WeatherImageJSON.HoldingGenerator fieldGeneratorConditionsImage;
        private ForecastShortPhraseJSON.HoldingGenerator fieldGeneratorIconPhrase;
        private JSONHoldingStringGenerator fieldGeneratorIconPhraseDisplay;
        private JSONHoldingStringGenerator fieldGeneratorIconPhraseSpoken;
        private JSONHoldingStringGenerator fieldGeneratorIconPhraseWritten;
        private JSONHoldingStringGenerator fieldGeneratorShortPhrase;
        private JSONHoldingStringGenerator fieldGeneratorLongPhrase;
        private WindDataJSON.HoldingGenerator fieldGeneratorWind;
        private WindDataJSON.HoldingGenerator fieldGeneratorWindGust;
        private TypeLiquidTotalJSON.HoldingGenerator fieldGeneratorLiquidTotal;
        private TypeRainTotalJSON.HoldingGenerator fieldGeneratorRainTotal;
        private TypeSnowTotalJSON.HoldingGenerator fieldGeneratorSnowTotal;
        private TypeIceTotalJSON.HoldingGenerator fieldGeneratorIceTotal;
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
    private class FieldHoldingGeneratorProbabilityOfThunderstormPct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorProbabilityOfThunderstormPct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorProbabilityOfThunderstormPct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorProbabilityOfThunderstormPct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorProbabilityOfThunderstormPct fieldGeneratorProbabilityOfThunderstormPct;
    private class FieldHoldingGeneratorProbabilityOfRainPct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorProbabilityOfRainPct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorProbabilityOfRainPct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorProbabilityOfRainPct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorProbabilityOfRainPct fieldGeneratorProbabilityOfRainPct;
    private class FieldHoldingGeneratorProbabilityOfSnowPct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorProbabilityOfSnowPct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorProbabilityOfSnowPct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorProbabilityOfSnowPct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorProbabilityOfSnowPct fieldGeneratorProbabilityOfSnowPct;
    private class FieldHoldingGeneratorProbabilityOfIcePct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorProbabilityOfIcePct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorProbabilityOfIcePct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorProbabilityOfIcePct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorProbabilityOfIcePct fieldGeneratorProbabilityOfIcePct;
        private JSONHoldingNumberTextGenerator fieldGeneratorHoursOfPrecipitation;
        private JSONHoldingNumberTextGenerator fieldGeneratorHoursOfRain;
    private class FieldHoldingGeneratorCloudCoverPct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorCloudCoverPct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCloudCoverPct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCloudCoverPct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorCloudCoverPct fieldGeneratorCloudCoverPct;
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
            DailyForecastDayPartJSON result = new DailyForecastDayPartJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDailyForecastDayPartAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DailyForecastDayPartJSON result)
          {
            if (fieldGeneratorConditionsImage.have_value)
              {
                result.setConditionsImage(fieldGeneratorConditionsImage.value);
                fieldGeneratorConditionsImage.have_value = false;
              }
            if (fieldGeneratorIconPhrase.have_value)
              {
                result.setIconPhrase(fieldGeneratorIconPhrase.value);
                fieldGeneratorIconPhrase.have_value = false;
              }
            if (fieldGeneratorIconPhraseDisplay.have_value)
              {
                result.setIconPhraseDisplay(fieldGeneratorIconPhraseDisplay.value);
                fieldGeneratorIconPhraseDisplay.have_value = false;
              }
            if (fieldGeneratorIconPhraseSpoken.have_value)
              {
                result.setIconPhraseSpoken(fieldGeneratorIconPhraseSpoken.value);
                fieldGeneratorIconPhraseSpoken.have_value = false;
              }
            if (fieldGeneratorIconPhraseWritten.have_value)
              {
                result.setIconPhraseWritten(fieldGeneratorIconPhraseWritten.value);
                fieldGeneratorIconPhraseWritten.have_value = false;
              }
            if (fieldGeneratorShortPhrase.have_value)
              {
                result.setShortPhrase(fieldGeneratorShortPhrase.value);
                fieldGeneratorShortPhrase.have_value = false;
              }
            if (fieldGeneratorLongPhrase.have_value)
              {
                result.setLongPhrase(fieldGeneratorLongPhrase.value);
                fieldGeneratorLongPhrase.have_value = false;
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
            if (fieldGeneratorLiquidTotal.have_value)
              {
                result.setLiquidTotal(fieldGeneratorLiquidTotal.value);
                fieldGeneratorLiquidTotal.have_value = false;
              }
            if (fieldGeneratorRainTotal.have_value)
              {
                result.setRainTotal(fieldGeneratorRainTotal.value);
                fieldGeneratorRainTotal.have_value = false;
              }
            if (fieldGeneratorSnowTotal.have_value)
              {
                result.setSnowTotal(fieldGeneratorSnowTotal.value);
                fieldGeneratorSnowTotal.have_value = false;
              }
            if (fieldGeneratorIceTotal.have_value)
              {
                result.setIceTotal(fieldGeneratorIceTotal.value);
                fieldGeneratorIceTotal.have_value = false;
              }
            if (fieldGeneratorProbabilityOfPrecipitationPct.have_value)
              {
                result.setProbabilityOfPrecipitationPct((sbyte)(fieldGeneratorProbabilityOfPrecipitationPct.value));
                fieldGeneratorProbabilityOfPrecipitationPct.have_value = false;
              }
            if (fieldGeneratorProbabilityOfThunderstormPct.have_value)
              {
                result.setProbabilityOfThunderstormPct((sbyte)(fieldGeneratorProbabilityOfThunderstormPct.value));
                fieldGeneratorProbabilityOfThunderstormPct.have_value = false;
              }
            if (fieldGeneratorProbabilityOfRainPct.have_value)
              {
                result.setProbabilityOfRainPct((sbyte)(fieldGeneratorProbabilityOfRainPct.value));
                fieldGeneratorProbabilityOfRainPct.have_value = false;
              }
            if (fieldGeneratorProbabilityOfSnowPct.have_value)
              {
                result.setProbabilityOfSnowPct((sbyte)(fieldGeneratorProbabilityOfSnowPct.value));
                fieldGeneratorProbabilityOfSnowPct.have_value = false;
              }
            if (fieldGeneratorProbabilityOfIcePct.have_value)
              {
                result.setProbabilityOfIcePct((sbyte)(fieldGeneratorProbabilityOfIcePct.value));
                fieldGeneratorProbabilityOfIcePct.have_value = false;
              }
            if (fieldGeneratorHoursOfPrecipitation.have_value)
              {
                result.setHoursOfPrecipitationText(fieldGeneratorHoursOfPrecipitation.value);
                fieldGeneratorHoursOfPrecipitation.have_value = false;
              }
            if (fieldGeneratorHoursOfRain.have_value)
              {
                result.setHoursOfRainText(fieldGeneratorHoursOfRain.value);
                fieldGeneratorHoursOfRain.have_value = false;
              }
            if (fieldGeneratorCloudCoverPct.have_value)
              {
                result.setCloudCoverPct((sbyte)(fieldGeneratorCloudCoverPct.value));
                fieldGeneratorCloudCoverPct.have_value = false;
              }
          }
        protected abstract void handle_result(DailyForecastDayPartJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "oudCoverPct", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorCloudCoverPct;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "nditionsImage", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorConditionsImage;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "oursOf", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 8, "recipitation", 0, 12, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorHoursOfPrecipitation;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 8, "ain", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorHoursOfRain;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "c", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 3, "Total", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorIceTotal;
                                break;
                            case 'o':
                                if (String.Compare(field_name, 3, "nPhrase", 0, 7, false) == 0)
                                  {
                                    if (field_name.Length == 10)
                                      {
                                        return fieldGeneratorIconPhrase;
                                      }
                                    switch (field_name[10])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 11, "isplay", 0, 6, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorIconPhraseDisplay;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 11, "poken", 0, 5, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorIconPhraseSpoken;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 11, "ritten", 0, 6, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorIconPhraseWritten;
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
                case 'L':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "quidTotal", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorLiquidTotal;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ngPhrase", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorLongPhrase;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "robabilityOf", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 14, "cePct", 0, 5, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorProbabilityOfIcePct;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 14, "recipitationPct", 0, 15, false) == 0) && (field_name.Length == 29))
                                    return fieldGeneratorProbabilityOfPrecipitationPct;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 14, "ainPct", 0, 6, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorProbabilityOfRainPct;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 14, "nowPct", 0, 6, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorProbabilityOfSnowPct;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 14, "hunderstormPct", 0, 14, false) == 0) && (field_name.Length == 28))
                                    return fieldGeneratorProbabilityOfThunderstormPct;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ainTotal", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorRainTotal;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "ortPhrase", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorShortPhrase;
                            break;
                        case 'n':
                            if ((String.Compare(field_name, 2, "owTotal", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorSnowTotal;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "ind", 0, 3, false) == 0)
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
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the DailyForecastDayPart class", ignore_extras);
            fieldGeneratorIconPhrase = new ForecastShortPhraseJSON.HoldingGenerator("field \"IconPhrase\" of the DailyForecastDayPart class", ignore_extras);
            fieldGeneratorIconPhraseDisplay = new JSONHoldingStringGenerator("field \"IconPhraseDisplay\" of the DailyForecastDayPart class");
            fieldGeneratorIconPhraseSpoken = new JSONHoldingStringGenerator("field \"IconPhraseSpoken\" of the DailyForecastDayPart class");
            fieldGeneratorIconPhraseWritten = new JSONHoldingStringGenerator("field \"IconPhraseWritten\" of the DailyForecastDayPart class");
            fieldGeneratorShortPhrase = new JSONHoldingStringGenerator("field \"ShortPhrase\" of the DailyForecastDayPart class");
            fieldGeneratorLongPhrase = new JSONHoldingStringGenerator("field \"LongPhrase\" of the DailyForecastDayPart class");
            fieldGeneratorWind = new WindDataJSON.HoldingGenerator("field \"Wind\" of the DailyForecastDayPart class", ignore_extras);
            fieldGeneratorWindGust = new WindDataJSON.HoldingGenerator("field \"WindGust\" of the DailyForecastDayPart class", ignore_extras);
            fieldGeneratorLiquidTotal = new TypeLiquidTotalJSON.HoldingGenerator("field \"LiquidTotal\" of the DailyForecastDayPart class", ignore_extras);
            fieldGeneratorRainTotal = new TypeRainTotalJSON.HoldingGenerator("field \"RainTotal\" of the DailyForecastDayPart class", ignore_extras);
            fieldGeneratorSnowTotal = new TypeSnowTotalJSON.HoldingGenerator("field \"SnowTotal\" of the DailyForecastDayPart class", ignore_extras);
            fieldGeneratorIceTotal = new TypeIceTotalJSON.HoldingGenerator("field \"IceTotal\" of the DailyForecastDayPart class", ignore_extras);
            fieldGeneratorProbabilityOfPrecipitationPct = new FieldHoldingGeneratorProbabilityOfPrecipitationPct("field \"ProbabilityOfPrecipitationPct\" of the DailyForecastDayPart class");
            fieldGeneratorProbabilityOfThunderstormPct = new FieldHoldingGeneratorProbabilityOfThunderstormPct("field \"ProbabilityOfThunderstormPct\" of the DailyForecastDayPart class");
            fieldGeneratorProbabilityOfRainPct = new FieldHoldingGeneratorProbabilityOfRainPct("field \"ProbabilityOfRainPct\" of the DailyForecastDayPart class");
            fieldGeneratorProbabilityOfSnowPct = new FieldHoldingGeneratorProbabilityOfSnowPct("field \"ProbabilityOfSnowPct\" of the DailyForecastDayPart class");
            fieldGeneratorProbabilityOfIcePct = new FieldHoldingGeneratorProbabilityOfIcePct("field \"ProbabilityOfIcePct\" of the DailyForecastDayPart class");
            fieldGeneratorHoursOfPrecipitation = new JSONHoldingNumberTextGenerator("field \"HoursOfPrecipitation\" of the DailyForecastDayPart class");
            fieldGeneratorHoursOfRain = new JSONHoldingNumberTextGenerator("field \"HoursOfRain\" of the DailyForecastDayPart class");
            fieldGeneratorCloudCoverPct = new FieldHoldingGeneratorCloudCoverPct("field \"CloudCoverPct\" of the DailyForecastDayPart class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DailyForecastDayPart class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the DailyForecastDayPart class", false);
            fieldGeneratorIconPhrase = new ForecastShortPhraseJSON.HoldingGenerator("field \"IconPhrase\" of the DailyForecastDayPart class", false);
            fieldGeneratorIconPhraseDisplay = new JSONHoldingStringGenerator("field \"IconPhraseDisplay\" of the DailyForecastDayPart class");
            fieldGeneratorIconPhraseSpoken = new JSONHoldingStringGenerator("field \"IconPhraseSpoken\" of the DailyForecastDayPart class");
            fieldGeneratorIconPhraseWritten = new JSONHoldingStringGenerator("field \"IconPhraseWritten\" of the DailyForecastDayPart class");
            fieldGeneratorShortPhrase = new JSONHoldingStringGenerator("field \"ShortPhrase\" of the DailyForecastDayPart class");
            fieldGeneratorLongPhrase = new JSONHoldingStringGenerator("field \"LongPhrase\" of the DailyForecastDayPart class");
            fieldGeneratorWind = new WindDataJSON.HoldingGenerator("field \"Wind\" of the DailyForecastDayPart class", false);
            fieldGeneratorWindGust = new WindDataJSON.HoldingGenerator("field \"WindGust\" of the DailyForecastDayPart class", false);
            fieldGeneratorLiquidTotal = new TypeLiquidTotalJSON.HoldingGenerator("field \"LiquidTotal\" of the DailyForecastDayPart class", false);
            fieldGeneratorRainTotal = new TypeRainTotalJSON.HoldingGenerator("field \"RainTotal\" of the DailyForecastDayPart class", false);
            fieldGeneratorSnowTotal = new TypeSnowTotalJSON.HoldingGenerator("field \"SnowTotal\" of the DailyForecastDayPart class", false);
            fieldGeneratorIceTotal = new TypeIceTotalJSON.HoldingGenerator("field \"IceTotal\" of the DailyForecastDayPart class", false);
            fieldGeneratorProbabilityOfPrecipitationPct = new FieldHoldingGeneratorProbabilityOfPrecipitationPct("field \"ProbabilityOfPrecipitationPct\" of the DailyForecastDayPart class");
            fieldGeneratorProbabilityOfThunderstormPct = new FieldHoldingGeneratorProbabilityOfThunderstormPct("field \"ProbabilityOfThunderstormPct\" of the DailyForecastDayPart class");
            fieldGeneratorProbabilityOfRainPct = new FieldHoldingGeneratorProbabilityOfRainPct("field \"ProbabilityOfRainPct\" of the DailyForecastDayPart class");
            fieldGeneratorProbabilityOfSnowPct = new FieldHoldingGeneratorProbabilityOfSnowPct("field \"ProbabilityOfSnowPct\" of the DailyForecastDayPart class");
            fieldGeneratorProbabilityOfIcePct = new FieldHoldingGeneratorProbabilityOfIcePct("field \"ProbabilityOfIcePct\" of the DailyForecastDayPart class");
            fieldGeneratorHoursOfPrecipitation = new JSONHoldingNumberTextGenerator("field \"HoursOfPrecipitation\" of the DailyForecastDayPart class");
            fieldGeneratorHoursOfRain = new JSONHoldingNumberTextGenerator("field \"HoursOfRain\" of the DailyForecastDayPart class");
            fieldGeneratorCloudCoverPct = new FieldHoldingGeneratorCloudCoverPct("field \"CloudCoverPct\" of the DailyForecastDayPart class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DailyForecastDayPart class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorConditionsImage.reset();
            fieldGeneratorIconPhrase.reset();
            fieldGeneratorIconPhraseDisplay.reset();
            fieldGeneratorIconPhraseSpoken.reset();
            fieldGeneratorIconPhraseWritten.reset();
            fieldGeneratorShortPhrase.reset();
            fieldGeneratorLongPhrase.reset();
            fieldGeneratorWind.reset();
            fieldGeneratorWindGust.reset();
            fieldGeneratorLiquidTotal.reset();
            fieldGeneratorRainTotal.reset();
            fieldGeneratorSnowTotal.reset();
            fieldGeneratorIceTotal.reset();
            fieldGeneratorProbabilityOfPrecipitationPct.reset();
            fieldGeneratorProbabilityOfThunderstormPct.reset();
            fieldGeneratorProbabilityOfRainPct.reset();
            fieldGeneratorProbabilityOfSnowPct.reset();
            fieldGeneratorProbabilityOfIcePct.reset();
            fieldGeneratorHoursOfPrecipitation.reset();
            fieldGeneratorHoursOfRain.reset();
            fieldGeneratorCloudCoverPct.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorConditionsImage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIconPhrase.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWind.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWindGust.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLiquidTotal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRainTotal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSnowTotal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIceTotal.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorConditionsImage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIconPhrase.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWind.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWindGust.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLiquidTotal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRainTotal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSnowTotal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIceTotal.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DailyForecastDayPartJSON  result)
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
        public DailyForecastDayPartJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DailyForecastDayPartJSON  result)
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
    protected virtual void handle_result(List<DailyForecastDayPartJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DailyForecastDayPartJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DailyForecastDayPartJSON>();
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
    public List<DailyForecastDayPartJSON> value;
  };
  };
