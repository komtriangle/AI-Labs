/* file "SynchronizedUserDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SynchronizedUserDataJSON : JSONBase
  {
    public class TypeContactsJSON : JSONBase
      {
        private bool flagHasData;
        private List< OneContactJSON  > storeData;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONData(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Data of TypeContactsJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< OneContactJSON  > vector_Data1 = new List< OneContactJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                OneContactJSON convert_classy = OneContactJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Data1.Add(convert_classy);
              }
            initData();
            for (int num1 = 0; num1 < vector_Data1.Count; ++num1)
                appendData(vector_Data1[num1]);
            for (int num1 = 0; num1 < vector_Data1.Count; ++num1)
              {
              }
          }


        public TypeContactsJSON()
          {
            flagHasData = false;
            storeData = new List< OneContactJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasData()
          {
            return flagHasData;
          }

        public int  countOfData()
          {
            Debug.Assert(flagHasData);
            return storeData.Count;
          }

        public OneContactJSON   elementOfData(int element_num)
          {
            Debug.Assert(flagHasData);
            return storeData[element_num];
          }

        public List< OneContactJSON  >  getData()
          {
            Debug.Assert(flagHasData);
            return storeData;
          }


        public virtual int extraTypeContactsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeContactsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeContactsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeContactsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initData()
          {
            if (flagHasData)
              {
                for (int num1 = 0; num1 < storeData.Count; ++num1)
                  {
                  }
              }
            flagHasData = true;
            storeData.Clear();
          }
        public void appendData(OneContactJSON  to_append)
          {
            if (!flagHasData)
              {
                flagHasData = true;
                storeData.Clear();
              }
            Debug.Assert(flagHasData);
            storeData.Add(to_append);
          }
        public void unsetData()
          {
            if (flagHasData)
              {
                for (int num2 = 0; num2 < storeData.Count; ++num2)
                  {
                  }
              }
            flagHasData = false;
            storeData.Clear();
          }

        public virtual void extraTypeContactsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeContactsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeContactsLookup(key);
            if (old_field == null)
              {
                extraTypeContactsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasData);
            if (flagHasData)
              {
                handler.start_pair("Data");
                handler.start_array();
                for (int num1 = 0; num1 < storeData.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeData[num1].write_partial_as_json(handler);
                    else
                        storeData[num1].write_as_json(handler);
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
            if (!(hasData()))
              {
                return "When parsing the object for %what%, the \"Data\" field was missing.";
              }
            return null;
          }

        public static TypeContactsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeContactsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContacts", ignore_extras);
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
        public static TypeContactsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeContactsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeContactsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContacts", ignore_extras);
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
        public static TypeContactsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeContactsJSON from_text(string text, bool ignore_extras)
          {
            TypeContactsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContacts", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeContactsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeContactsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeContactsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeContacts", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private OneContactJSON.HoldingArrayGenerator fieldGeneratorData;
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
                TypeContactsJSON result = new TypeContactsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeContactsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeContactsJSON result)
              {
                if (fieldGeneratorData.have_value)
                  {
                    result.initData();
                    int count = fieldGeneratorData.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendData(fieldGeneratorData.value[num]);
                      }
                    fieldGeneratorData.value.Clear();
                    fieldGeneratorData.have_value = false;
                  }
                else if ((!(result.hasData())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Data\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeContactsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Data", 0, 4, false) == 0) && (field_name.Length == 4))
                    return fieldGeneratorData;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorData = new OneContactJSON.HoldingArrayGenerator("field \"Data\" of the TypeContacts class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeContacts class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorData = new OneContactJSON.HoldingArrayGenerator("field \"Data\" of the TypeContacts class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeContacts class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorData.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorData.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorData.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeContactsJSON  result)
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
            public TypeContactsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeContactsJSON  result)
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
        protected virtual void handle_result(List<TypeContactsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeContactsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeContactsJSON>();
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
        public List<TypeContactsJSON> value;
      };
      };
    public class TypeInstalledAppsJSON : JSONBase
      {
        private bool flagHasData;
        private List< OneInstalledAppJSON  > storeData;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONData(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Data of TypeInstalledAppsJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< OneInstalledAppJSON  > vector_Data1 = new List< OneInstalledAppJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                OneInstalledAppJSON convert_classy = OneInstalledAppJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Data1.Add(convert_classy);
              }
            initData();
            for (int num2 = 0; num2 < vector_Data1.Count; ++num2)
                appendData(vector_Data1[num2]);
            for (int num1 = 0; num1 < vector_Data1.Count; ++num1)
              {
              }
          }


        public TypeInstalledAppsJSON()
          {
            flagHasData = false;
            storeData = new List< OneInstalledAppJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasData()
          {
            return flagHasData;
          }

        public int  countOfData()
          {
            Debug.Assert(flagHasData);
            return storeData.Count;
          }

        public OneInstalledAppJSON   elementOfData(int element_num)
          {
            Debug.Assert(flagHasData);
            return storeData[element_num];
          }

        public List< OneInstalledAppJSON  >  getData()
          {
            Debug.Assert(flagHasData);
            return storeData;
          }


        public virtual int extraTypeInstalledAppsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeInstalledAppsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeInstalledAppsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeInstalledAppsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initData()
          {
            if (flagHasData)
              {
                for (int num3 = 0; num3 < storeData.Count; ++num3)
                  {
                  }
              }
            flagHasData = true;
            storeData.Clear();
          }
        public void appendData(OneInstalledAppJSON  to_append)
          {
            if (!flagHasData)
              {
                flagHasData = true;
                storeData.Clear();
              }
            Debug.Assert(flagHasData);
            storeData.Add(to_append);
          }
        public void unsetData()
          {
            if (flagHasData)
              {
                for (int num4 = 0; num4 < storeData.Count; ++num4)
                  {
                  }
              }
            flagHasData = false;
            storeData.Clear();
          }

        public virtual void extraTypeInstalledAppsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeInstalledAppsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeInstalledAppsLookup(key);
            if (old_field == null)
              {
                extraTypeInstalledAppsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasData);
            if (flagHasData)
              {
                handler.start_pair("Data");
                handler.start_array();
                for (int num1 = 0; num1 < storeData.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeData[num1].write_partial_as_json(handler);
                    else
                        storeData[num1].write_as_json(handler);
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
            if (!(hasData()))
              {
                return "When parsing the object for %what%, the \"Data\" field was missing.";
              }
            return null;
          }

        public static TypeInstalledAppsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeInstalledAppsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeInstalledApps", ignore_extras);
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
        public static TypeInstalledAppsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeInstalledAppsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeInstalledAppsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeInstalledApps", ignore_extras);
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
        public static TypeInstalledAppsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeInstalledAppsJSON from_text(string text, bool ignore_extras)
          {
            TypeInstalledAppsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeInstalledApps", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeInstalledAppsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeInstalledAppsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeInstalledAppsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeInstalledApps", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private OneInstalledAppJSON.HoldingArrayGenerator fieldGeneratorData;
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
                TypeInstalledAppsJSON result = new TypeInstalledAppsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeInstalledAppsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeInstalledAppsJSON result)
              {
                if (fieldGeneratorData.have_value)
                  {
                    result.initData();
                    int count = fieldGeneratorData.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendData(fieldGeneratorData.value[num]);
                      }
                    fieldGeneratorData.value.Clear();
                    fieldGeneratorData.have_value = false;
                  }
                else if ((!(result.hasData())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Data\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeInstalledAppsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Data", 0, 4, false) == 0) && (field_name.Length == 4))
                    return fieldGeneratorData;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorData = new OneInstalledAppJSON.HoldingArrayGenerator("field \"Data\" of the TypeInstalledApps class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeInstalledApps class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorData = new OneInstalledAppJSON.HoldingArrayGenerator("field \"Data\" of the TypeInstalledApps class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeInstalledApps class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorData.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorData.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorData.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeInstalledAppsJSON  result)
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
            public TypeInstalledAppsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeInstalledAppsJSON  result)
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
        protected virtual void handle_result(List<TypeInstalledAppsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeInstalledAppsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeInstalledAppsJSON>();
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
        public List<TypeInstalledAppsJSON> value;
      };
      };
    private bool flagHasContacts;
    private TypeContactsJSON  storeContacts;
    private bool flagHasInstalledApps;
    private TypeInstalledAppsJSON  storeInstalledApps;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONContacts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeContactsJSON convert_classy = TypeContactsJSON.from_json(json_value, ignore_extras, true);
        setContacts(convert_classy);
      }


    private void  fromJSONInstalledApps(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeInstalledAppsJSON convert_classy = TypeInstalledAppsJSON.from_json(json_value, ignore_extras, true);
        setInstalledApps(convert_classy);
      }


    public SynchronizedUserDataJSON()
      {
        flagHasContacts = false;
        flagHasInstalledApps = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasContacts()
      {
        return flagHasContacts;
      }

    public TypeContactsJSON   getContacts()
      {
        Debug.Assert(flagHasContacts);
        return storeContacts;
      }

    public bool  hasInstalledApps()
      {
        return flagHasInstalledApps;
      }

    public TypeInstalledAppsJSON   getInstalledApps()
      {
        Debug.Assert(flagHasInstalledApps);
        return storeInstalledApps;
      }


    public virtual int extraSynchronizedUserDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSynchronizedUserDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSynchronizedUserDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSynchronizedUserDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setContacts(TypeContactsJSON  new_value)
      {
        if (flagHasContacts)
          {
          }
        flagHasContacts = true;
        storeContacts = new_value;
      }
    public void unsetContacts()
      {
        if (flagHasContacts)
          {
          }
        flagHasContacts = false;
      }
    public void setInstalledApps(TypeInstalledAppsJSON  new_value)
      {
        if (flagHasInstalledApps)
          {
          }
        flagHasInstalledApps = true;
        storeInstalledApps = new_value;
      }
    public void unsetInstalledApps()
      {
        if (flagHasInstalledApps)
          {
          }
        flagHasInstalledApps = false;
      }

    public virtual void extraSynchronizedUserDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSynchronizedUserDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSynchronizedUserDataLookup(key);
        if (old_field == null)
          {
            extraSynchronizedUserDataAppendPair(key, new_component);
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
        if (flagHasContacts)
          {
            handler.start_pair("Contacts");
            if (partial_allowed)
                storeContacts.write_partial_as_json(handler);
            else
                storeContacts.write_as_json(handler);
          }
        if (flagHasInstalledApps)
          {
            handler.start_pair("InstalledApps");
            if (partial_allowed)
                storeInstalledApps.write_partial_as_json(handler);
            else
                storeInstalledApps.write_as_json(handler);
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

    public static SynchronizedUserDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SynchronizedUserDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SynchronizedUserData", ignore_extras);
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
    public static SynchronizedUserDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SynchronizedUserDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SynchronizedUserDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SynchronizedUserData", ignore_extras);
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
    public static SynchronizedUserDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SynchronizedUserDataJSON from_text(string text, bool ignore_extras)
      {
        SynchronizedUserDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SynchronizedUserData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SynchronizedUserDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SynchronizedUserDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SynchronizedUserDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SynchronizedUserData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeContactsJSON.HoldingGenerator fieldGeneratorContacts;
        private TypeInstalledAppsJSON.HoldingGenerator fieldGeneratorInstalledApps;
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
            SynchronizedUserDataJSON result = new SynchronizedUserDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSynchronizedUserDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SynchronizedUserDataJSON result)
          {
            if (fieldGeneratorContacts.have_value)
              {
                result.setContacts(fieldGeneratorContacts.value);
                fieldGeneratorContacts.have_value = false;
              }
            if (fieldGeneratorInstalledApps.have_value)
              {
                result.setInstalledApps(fieldGeneratorInstalledApps.value);
                fieldGeneratorInstalledApps.have_value = false;
              }
          }
        protected abstract void handle_result(SynchronizedUserDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontacts", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorContacts;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nstalledApps", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorInstalledApps;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorContacts = new TypeContactsJSON.HoldingGenerator("field \"Contacts\" of the SynchronizedUserData class", ignore_extras);
            fieldGeneratorInstalledApps = new TypeInstalledAppsJSON.HoldingGenerator("field \"InstalledApps\" of the SynchronizedUserData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SynchronizedUserData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorContacts = new TypeContactsJSON.HoldingGenerator("field \"Contacts\" of the SynchronizedUserData class", false);
            fieldGeneratorInstalledApps = new TypeInstalledAppsJSON.HoldingGenerator("field \"InstalledApps\" of the SynchronizedUserData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SynchronizedUserData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorContacts.reset();
            fieldGeneratorInstalledApps.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorContacts.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInstalledApps.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorContacts.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInstalledApps.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SynchronizedUserDataJSON  result)
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
        public SynchronizedUserDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SynchronizedUserDataJSON  result)
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
    protected virtual void handle_result(List<SynchronizedUserDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SynchronizedUserDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SynchronizedUserDataJSON>();
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
    public List<SynchronizedUserDataJSON> value;
  };
  };
