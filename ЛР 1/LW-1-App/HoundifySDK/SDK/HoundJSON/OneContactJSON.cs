/* file "OneContactJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class OneContactJSON : JSONBase
  {
    public class TypePhoneEntriesJSON : JSONBase
      {
        private bool flagHasCategory;
        private string storeCategory;
        private bool flagHasNumber;
        private string storeNumber;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Category of TypePhoneEntriesJSON is not a string.");
            setCategory(json_string.getData());
          }


        private void  fromJSONNumber(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Number of TypePhoneEntriesJSON is not a string.");
            setNumber(json_string.getData());
          }


        public TypePhoneEntriesJSON()
          {
            flagHasCategory = false;
            flagHasNumber = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasCategory()
          {
            return flagHasCategory;
          }

        public string  getCategory()
          {
            Debug.Assert(flagHasCategory);
            return storeCategory;
          }

        public bool  hasNumber()
          {
            return flagHasNumber;
          }

        public string  getNumber()
          {
            Debug.Assert(flagHasNumber);
            return storeNumber;
          }


        public virtual int extraTypePhoneEntriesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePhoneEntriesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePhoneEntriesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePhoneEntriesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setCategory(string new_value)
          {
            flagHasCategory = true;
            storeCategory = new_value;
          }
        public void unsetCategory()
          {
            flagHasCategory = false;
          }
        public void setNumber(string new_value)
          {
            flagHasNumber = true;
            storeNumber = new_value;
          }
        public void unsetNumber()
          {
            flagHasNumber = false;
          }

        public virtual void extraTypePhoneEntriesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePhoneEntriesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePhoneEntriesLookup(key);
            if (old_field == null)
              {
                extraTypePhoneEntriesAppendPair(key, new_component);
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
            if (flagHasCategory)
              {
                handler.start_pair("Category");
                handler.string_value(storeCategory);
              }
            Debug.Assert(partial_allowed || flagHasNumber);
            if (flagHasNumber)
              {
                handler.start_pair("Number");
                handler.string_value(storeNumber);
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
            if (!(hasNumber()))
              {
                return "When parsing the object for %what%, the \"Number\" field was missing.";
              }
            return null;
          }

        public static TypePhoneEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePhoneEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhoneEntries", ignore_extras);
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
        public static TypePhoneEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePhoneEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePhoneEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhoneEntries", ignore_extras);
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
        public static TypePhoneEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePhoneEntriesJSON from_text(string text, bool ignore_extras)
          {
            TypePhoneEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhoneEntries", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePhoneEntriesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePhoneEntriesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePhoneEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhoneEntries", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorCategory;
            private JSONHoldingStringGenerator fieldGeneratorNumber;
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
                TypePhoneEntriesJSON result = new TypePhoneEntriesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePhoneEntriesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePhoneEntriesJSON result)
              {
                if (fieldGeneratorCategory.have_value)
                  {
                    result.setCategory(fieldGeneratorCategory.value);
                    fieldGeneratorCategory.have_value = false;
                  }
                if (fieldGeneratorNumber.have_value)
                  {
                    result.setNumber(fieldGeneratorNumber.value);
                    fieldGeneratorNumber.have_value = false;
                  }
                else if ((!(result.hasNumber())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Number\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypePhoneEntriesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "ategory", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorCategory;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorNumber;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the TypePhoneEntries class");
                fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the TypePhoneEntries class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePhoneEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the TypePhoneEntries class");
                fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the TypePhoneEntries class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePhoneEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorCategory.reset();
                fieldGeneratorNumber.reset();
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
            protected override void handle_result(TypePhoneEntriesJSON  result)
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
            public TypePhoneEntriesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePhoneEntriesJSON  result)
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
        protected virtual void handle_result(List<TypePhoneEntriesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePhoneEntriesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePhoneEntriesJSON>();
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
        public List<TypePhoneEntriesJSON> value;
      };
      };
    public class TypeEmailEntriesJSON : JSONBase
      {
        private bool flagHasCategory;
        private string storeCategory;
        private bool flagHasAddress;
        private string storeAddress;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Category of TypeEmailEntriesJSON is not a string.");
            setCategory(json_string.getData());
          }


        private void  fromJSONAddress(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Address of TypeEmailEntriesJSON is not a string.");
            setAddress(json_string.getData());
          }


        public TypeEmailEntriesJSON()
          {
            flagHasCategory = false;
            flagHasAddress = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasCategory()
          {
            return flagHasCategory;
          }

        public string  getCategory()
          {
            Debug.Assert(flagHasCategory);
            return storeCategory;
          }

        public bool  hasAddress()
          {
            return flagHasAddress;
          }

        public string  getAddress()
          {
            Debug.Assert(flagHasAddress);
            return storeAddress;
          }


        public virtual int extraTypeEmailEntriesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeEmailEntriesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeEmailEntriesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeEmailEntriesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setCategory(string new_value)
          {
            flagHasCategory = true;
            storeCategory = new_value;
          }
        public void unsetCategory()
          {
            flagHasCategory = false;
          }
        public void setAddress(string new_value)
          {
            flagHasAddress = true;
            storeAddress = new_value;
          }
        public void unsetAddress()
          {
            flagHasAddress = false;
          }

        public virtual void extraTypeEmailEntriesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeEmailEntriesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeEmailEntriesLookup(key);
            if (old_field == null)
              {
                extraTypeEmailEntriesAppendPair(key, new_component);
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
            if (flagHasCategory)
              {
                handler.start_pair("Category");
                handler.string_value(storeCategory);
              }
            Debug.Assert(partial_allowed || flagHasAddress);
            if (flagHasAddress)
              {
                handler.start_pair("Address");
                handler.string_value(storeAddress);
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
            if (!(hasAddress()))
              {
                return "When parsing the object for %what%, the \"Address\" field was missing.";
              }
            return null;
          }

        public static TypeEmailEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEmailEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEmailEntries", ignore_extras);
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
        public static TypeEmailEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEmailEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEmailEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEmailEntries", ignore_extras);
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
        public static TypeEmailEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEmailEntriesJSON from_text(string text, bool ignore_extras)
          {
            TypeEmailEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEmailEntries", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeEmailEntriesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeEmailEntriesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeEmailEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEmailEntries", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorCategory;
            private JSONHoldingStringGenerator fieldGeneratorAddress;
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
                TypeEmailEntriesJSON result = new TypeEmailEntriesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeEmailEntriesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeEmailEntriesJSON result)
              {
                if (fieldGeneratorCategory.have_value)
                  {
                    result.setCategory(fieldGeneratorCategory.value);
                    fieldGeneratorCategory.have_value = false;
                  }
                if (fieldGeneratorAddress.have_value)
                  {
                    result.setAddress(fieldGeneratorAddress.value);
                    fieldGeneratorAddress.have_value = false;
                  }
                else if ((!(result.hasAddress())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Address\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeEmailEntriesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "ddress", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorAddress;
                        break;
                    case 'C':
                        if ((String.Compare(field_name, 1, "ategory", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorCategory;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the TypeEmailEntries class");
                fieldGeneratorAddress = new JSONHoldingStringGenerator("field \"Address\" of the TypeEmailEntries class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeEmailEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the TypeEmailEntries class");
                fieldGeneratorAddress = new JSONHoldingStringGenerator("field \"Address\" of the TypeEmailEntries class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeEmailEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorCategory.reset();
                fieldGeneratorAddress.reset();
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
            protected override void handle_result(TypeEmailEntriesJSON  result)
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
            public TypeEmailEntriesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeEmailEntriesJSON  result)
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
        protected virtual void handle_result(List<TypeEmailEntriesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeEmailEntriesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeEmailEntriesJSON>();
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
        public List<TypeEmailEntriesJSON> value;
      };
      };
    public class TypeMapAddressEntriesJSON : JSONBase
      {
        private bool flagHasCategory;
        private string storeCategory;
        private bool flagHasAddress;
        private MapLocationForContactsJSON  storeAddress;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Category of TypeMapAddressEntriesJSON is not a string.");
            setCategory(json_string.getData());
          }


        private void  fromJSONAddress(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MapLocationForContactsJSON convert_classy = MapLocationForContactsJSON.from_json(json_value, ignore_extras, true);
            setAddress(convert_classy);
          }


        public TypeMapAddressEntriesJSON()
          {
            flagHasCategory = false;
            flagHasAddress = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasCategory()
          {
            return flagHasCategory;
          }

        public string  getCategory()
          {
            Debug.Assert(flagHasCategory);
            return storeCategory;
          }

        public bool  hasAddress()
          {
            return flagHasAddress;
          }

        public MapLocationForContactsJSON   getAddress()
          {
            Debug.Assert(flagHasAddress);
            return storeAddress;
          }


        public virtual int extraTypeMapAddressEntriesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMapAddressEntriesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMapAddressEntriesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMapAddressEntriesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setCategory(string new_value)
          {
            flagHasCategory = true;
            storeCategory = new_value;
          }
        public void unsetCategory()
          {
            flagHasCategory = false;
          }
        public void setAddress(MapLocationForContactsJSON  new_value)
          {
            if (flagHasAddress)
              {
              }
            flagHasAddress = true;
            storeAddress = new_value;
          }
        public void unsetAddress()
          {
            if (flagHasAddress)
              {
              }
            flagHasAddress = false;
          }

        public virtual void extraTypeMapAddressEntriesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMapAddressEntriesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMapAddressEntriesLookup(key);
            if (old_field == null)
              {
                extraTypeMapAddressEntriesAppendPair(key, new_component);
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
            if (flagHasCategory)
              {
                handler.start_pair("Category");
                handler.string_value(storeCategory);
              }
            Debug.Assert(partial_allowed || flagHasAddress);
            if (flagHasAddress)
              {
                handler.start_pair("Address");
                if (partial_allowed)
                    storeAddress.write_partial_as_json(handler);
                else
                    storeAddress.write_as_json(handler);
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
            if (!(hasAddress()))
              {
                return "When parsing the object for %what%, the \"Address\" field was missing.";
              }
            return null;
          }

        public static TypeMapAddressEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMapAddressEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMapAddressEntries", ignore_extras);
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
        public static TypeMapAddressEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMapAddressEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMapAddressEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMapAddressEntries", ignore_extras);
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
        public static TypeMapAddressEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMapAddressEntriesJSON from_text(string text, bool ignore_extras)
          {
            TypeMapAddressEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMapAddressEntries", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMapAddressEntriesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMapAddressEntriesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMapAddressEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMapAddressEntries", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorCategory;
            private MapLocationForContactsJSON.HoldingGenerator fieldGeneratorAddress;
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
                TypeMapAddressEntriesJSON result = new TypeMapAddressEntriesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMapAddressEntriesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMapAddressEntriesJSON result)
              {
                if (fieldGeneratorCategory.have_value)
                  {
                    result.setCategory(fieldGeneratorCategory.value);
                    fieldGeneratorCategory.have_value = false;
                  }
                if (fieldGeneratorAddress.have_value)
                  {
                    result.setAddress(fieldGeneratorAddress.value);
                    fieldGeneratorAddress.have_value = false;
                  }
                else if ((!(result.hasAddress())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Address\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeMapAddressEntriesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "ddress", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorAddress;
                        break;
                    case 'C':
                        if ((String.Compare(field_name, 1, "ategory", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorCategory;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the TypeMapAddressEntries class");
                fieldGeneratorAddress = new MapLocationForContactsJSON.HoldingGenerator("field \"Address\" of the TypeMapAddressEntries class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMapAddressEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the TypeMapAddressEntries class");
                fieldGeneratorAddress = new MapLocationForContactsJSON.HoldingGenerator("field \"Address\" of the TypeMapAddressEntries class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMapAddressEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorCategory.reset();
                fieldGeneratorAddress.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorAddress.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorAddress.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeMapAddressEntriesJSON  result)
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
            public TypeMapAddressEntriesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMapAddressEntriesJSON  result)
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
        protected virtual void handle_result(List<TypeMapAddressEntriesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMapAddressEntriesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMapAddressEntriesJSON>();
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
        public List<TypeMapAddressEntriesJSON> value;
      };
      };
    public enum TypeSex
      {
        Sex_Female,
        Sex_Male
      };

    public static TypeSex  stringToSex(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "emale", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeSex.Sex_Female;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "ale", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeSex.Sex_Male;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Sex' is not one of the legal values.");
      }

    public static string  stringFromSex(TypeSex the_enum)
      {
        switch (the_enum)
          {
            case TypeSex.Sex_Female:
                return "Female";
            case TypeSex.Sex_Male:
                return "Male";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFirstName;
    private string storeFirstName;
    private bool flagHasLastName;
    private string storeLastName;
    private bool flagHasSingleName;
    private string storeSingleName;
    private bool flagHasNickNames;
    private List< string > storeNickNames;
    private bool flagHasPhoneEntries;
    private List< TypePhoneEntriesJSON  > storePhoneEntries;
    private bool flagHasDefaultPhone;
    private string storeDefaultPhone;
    private bool flagHasTimesCalled;
    private BigInteger storeTimesCalled;
    private bool flagHasLastCalled;
    private DateAndOrTimeJSON  storeLastCalled;
    private bool flagHasTimesContacted;
    private BigInteger storeTimesContacted;
    private bool flagHasLastContacted;
    private DateAndOrTimeJSON  storeLastContacted;
    private bool flagHasEmailEntries;
    private List< TypeEmailEntriesJSON  > storeEmailEntries;
    private bool flagHasDefaultEmail;
    private string storeDefaultEmail;
    private bool flagHasMapAddressEntries;
    private List< TypeMapAddressEntriesJSON  > storeMapAddressEntries;
    private bool flagHasDefaultMapAddress;
    private string storeDefaultMapAddress;
    private bool flagHasIsFavorite;
    private bool storeIsFavorite;
    private bool flagHasSex;
    private TypeSex storeSex;
    private bool flagHasIsVisible;
    private bool storeIsVisible;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFirstName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FirstName of OneContactJSON is not a string.");
        setFirstName(json_string.getData());
      }


    private void  fromJSONLastName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastName of OneContactJSON is not a string.");
        setLastName(json_string.getData());
      }


    private void  fromJSONSingleName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SingleName of OneContactJSON is not a string.");
        setSingleName(json_string.getData());
      }


    private void  fromJSONNickNames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NickNames of OneContactJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_NickNames1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field NickNames of OneContactJSON is not a string.");
            vector_NickNames1.Add(json_string.getData());
          }
        initNickNames();
        for (int num1 = 0; num1 < vector_NickNames1.Count; ++num1)
            appendNickNames(vector_NickNames1[num1]);
        for (int num1 = 0; num1 < vector_NickNames1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPhoneEntries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PhoneEntries of OneContactJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypePhoneEntriesJSON  > vector_PhoneEntries1 = new List< TypePhoneEntriesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypePhoneEntriesJSON convert_classy = TypePhoneEntriesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_PhoneEntries1.Add(convert_classy);
          }
        initPhoneEntries();
        for (int num2 = 0; num2 < vector_PhoneEntries1.Count; ++num2)
            appendPhoneEntries(vector_PhoneEntries1[num2]);
        for (int num1 = 0; num1 < vector_PhoneEntries1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDefaultPhone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DefaultPhone of OneContactJSON is not a string.");
        setDefaultPhone(json_string.getData());
      }


    private void  fromJSONTimesCalled(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TimesCalled of OneContactJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TimesCalled of OneContactJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTimesCalled(extracted_integer);
      }


    private void  fromJSONLastCalled(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setLastCalled(convert_classy);
      }


    private void  fromJSONTimesContacted(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TimesContacted of OneContactJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TimesContacted of OneContactJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTimesContacted(extracted_integer);
      }


    private void  fromJSONLastContacted(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setLastContacted(convert_classy);
      }


    private void  fromJSONEmailEntries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field EmailEntries of OneContactJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeEmailEntriesJSON  > vector_EmailEntries1 = new List< TypeEmailEntriesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeEmailEntriesJSON convert_classy = TypeEmailEntriesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_EmailEntries1.Add(convert_classy);
          }
        initEmailEntries();
        for (int num3 = 0; num3 < vector_EmailEntries1.Count; ++num3)
            appendEmailEntries(vector_EmailEntries1[num3]);
        for (int num1 = 0; num1 < vector_EmailEntries1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDefaultEmail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DefaultEmail of OneContactJSON is not a string.");
        setDefaultEmail(json_string.getData());
      }


    private void  fromJSONMapAddressEntries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MapAddressEntries of OneContactJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeMapAddressEntriesJSON  > vector_MapAddressEntries1 = new List< TypeMapAddressEntriesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeMapAddressEntriesJSON convert_classy = TypeMapAddressEntriesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_MapAddressEntries1.Add(convert_classy);
          }
        initMapAddressEntries();
        for (int num4 = 0; num4 < vector_MapAddressEntries1.Count; ++num4)
            appendMapAddressEntries(vector_MapAddressEntries1[num4]);
        for (int num1 = 0; num1 < vector_MapAddressEntries1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDefaultMapAddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DefaultMapAddress of OneContactJSON is not a string.");
        setDefaultMapAddress(json_string.getData());
      }


    private void  fromJSONIsFavorite(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsFavorite of OneContactJSON is not true for false.");
              }
          }
        setIsFavorite(the_bool);
      }


    private void  fromJSONSex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Sex of OneContactJSON is not a string.");
        TypeSex the_enum;
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "emale", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeSex.Sex_Female;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ale", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeSex.Sex_Male;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Sex of OneContactJSON is not one of the legal strings.");
      enum_is_done:;
        setSex(the_enum);
      }


    private void  fromJSONIsVisible(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsVisible of OneContactJSON is not true for false.");
              }
          }
        setIsVisible(the_bool);
      }


    public OneContactJSON()
      {
        flagHasFirstName = false;
        flagHasLastName = false;
        flagHasSingleName = false;
        flagHasNickNames = false;
        flagHasPhoneEntries = false;
        flagHasDefaultPhone = false;
        flagHasTimesCalled = false;
        flagHasLastCalled = false;
        flagHasTimesContacted = false;
        flagHasLastContacted = false;
        flagHasEmailEntries = false;
        flagHasDefaultEmail = false;
        flagHasMapAddressEntries = false;
        flagHasDefaultMapAddress = false;
        flagHasIsFavorite = false;
        flagHasSex = false;
        flagHasIsVisible = false;
        storeNickNames = new List< string >();
        storePhoneEntries = new List< TypePhoneEntriesJSON  >();
        storeEmailEntries = new List< TypeEmailEntriesJSON  >();
        storeMapAddressEntries = new List< TypeMapAddressEntriesJSON  >();
        storeIsFavorite = false;
        storeIsVisible = true;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFirstName()
      {
        return flagHasFirstName;
      }

    public string  getFirstName()
      {
        Debug.Assert(flagHasFirstName);
        return storeFirstName;
      }

    public bool  hasLastName()
      {
        return flagHasLastName;
      }

    public string  getLastName()
      {
        Debug.Assert(flagHasLastName);
        return storeLastName;
      }

    public bool  hasSingleName()
      {
        return flagHasSingleName;
      }

    public string  getSingleName()
      {
        Debug.Assert(flagHasSingleName);
        return storeSingleName;
      }

    public bool  hasNickNames()
      {
        return flagHasNickNames;
      }

    public int  countOfNickNames()
      {
        Debug.Assert(flagHasNickNames);
        return storeNickNames.Count;
      }

    public string  elementOfNickNames(int element_num)
      {
        Debug.Assert(flagHasNickNames);
        return storeNickNames[element_num];
      }

    public List< string >  getNickNames()
      {
        Debug.Assert(flagHasNickNames);
        return storeNickNames;
      }

    public bool  hasPhoneEntries()
      {
        return flagHasPhoneEntries;
      }

    public int  countOfPhoneEntries()
      {
        Debug.Assert(flagHasPhoneEntries);
        return storePhoneEntries.Count;
      }

    public TypePhoneEntriesJSON   elementOfPhoneEntries(int element_num)
      {
        Debug.Assert(flagHasPhoneEntries);
        return storePhoneEntries[element_num];
      }

    public List< TypePhoneEntriesJSON  >  getPhoneEntries()
      {
        Debug.Assert(flagHasPhoneEntries);
        return storePhoneEntries;
      }

    public bool  hasDefaultPhone()
      {
        return flagHasDefaultPhone;
      }

    public string  getDefaultPhone()
      {
        Debug.Assert(flagHasDefaultPhone);
        return storeDefaultPhone;
      }

    public bool  hasTimesCalled()
      {
        return flagHasTimesCalled;
      }

    public BigInteger  getTimesCalled()
      {
        Debug.Assert(flagHasTimesCalled);
        return storeTimesCalled;
      }

    public bool  hasLastCalled()
      {
        return flagHasLastCalled;
      }

    public DateAndOrTimeJSON   getLastCalled()
      {
        Debug.Assert(flagHasLastCalled);
        return storeLastCalled;
      }

    public bool  hasTimesContacted()
      {
        return flagHasTimesContacted;
      }

    public BigInteger  getTimesContacted()
      {
        Debug.Assert(flagHasTimesContacted);
        return storeTimesContacted;
      }

    public bool  hasLastContacted()
      {
        return flagHasLastContacted;
      }

    public DateAndOrTimeJSON   getLastContacted()
      {
        Debug.Assert(flagHasLastContacted);
        return storeLastContacted;
      }

    public bool  hasEmailEntries()
      {
        return flagHasEmailEntries;
      }

    public int  countOfEmailEntries()
      {
        Debug.Assert(flagHasEmailEntries);
        return storeEmailEntries.Count;
      }

    public TypeEmailEntriesJSON   elementOfEmailEntries(int element_num)
      {
        Debug.Assert(flagHasEmailEntries);
        return storeEmailEntries[element_num];
      }

    public List< TypeEmailEntriesJSON  >  getEmailEntries()
      {
        Debug.Assert(flagHasEmailEntries);
        return storeEmailEntries;
      }

    public bool  hasDefaultEmail()
      {
        return flagHasDefaultEmail;
      }

    public string  getDefaultEmail()
      {
        Debug.Assert(flagHasDefaultEmail);
        return storeDefaultEmail;
      }

    public bool  hasMapAddressEntries()
      {
        return flagHasMapAddressEntries;
      }

    public int  countOfMapAddressEntries()
      {
        Debug.Assert(flagHasMapAddressEntries);
        return storeMapAddressEntries.Count;
      }

    public TypeMapAddressEntriesJSON   elementOfMapAddressEntries(int element_num)
      {
        Debug.Assert(flagHasMapAddressEntries);
        return storeMapAddressEntries[element_num];
      }

    public List< TypeMapAddressEntriesJSON  >  getMapAddressEntries()
      {
        Debug.Assert(flagHasMapAddressEntries);
        return storeMapAddressEntries;
      }

    public bool  hasDefaultMapAddress()
      {
        return flagHasDefaultMapAddress;
      }

    public string  getDefaultMapAddress()
      {
        Debug.Assert(flagHasDefaultMapAddress);
        return storeDefaultMapAddress;
      }

    public bool  hasIsFavorite()
      {
        return flagHasIsFavorite;
      }

    public bool  getIsFavorite()
      {
        return storeIsFavorite;
      }

    public bool  hasSex()
      {
        return flagHasSex;
      }

    public TypeSex  getSex()
      {
        Debug.Assert(flagHasSex);
        return storeSex;
      }

    public string  getSexAsString()
      {
        return stringFromSex(getSex());
      }

    public bool  hasIsVisible()
      {
        return flagHasIsVisible;
      }

    public bool  getIsVisible()
      {
        return storeIsVisible;
      }


    public virtual int extraOneContactComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOneContactComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOneContactComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOneContactLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFirstName(string new_value)
      {
        flagHasFirstName = true;
        storeFirstName = new_value;
      }
    public void unsetFirstName()
      {
        flagHasFirstName = false;
      }
    public void setLastName(string new_value)
      {
        flagHasLastName = true;
        storeLastName = new_value;
      }
    public void unsetLastName()
      {
        flagHasLastName = false;
      }
    public void setSingleName(string new_value)
      {
        flagHasSingleName = true;
        storeSingleName = new_value;
      }
    public void unsetSingleName()
      {
        flagHasSingleName = false;
      }
    public void initNickNames()
      {
        flagHasNickNames = true;
        storeNickNames.Clear();
      }
    public void appendNickNames(string to_append)
      {
        if (!flagHasNickNames)
          {
            flagHasNickNames = true;
            storeNickNames.Clear();
          }
        Debug.Assert(flagHasNickNames);
        storeNickNames.Add(to_append);
      }
    public void unsetNickNames()
      {
        flagHasNickNames = false;
        storeNickNames.Clear();
      }
    public void initPhoneEntries()
      {
        if (flagHasPhoneEntries)
          {
            for (int num1 = 0; num1 < storePhoneEntries.Count; ++num1)
              {
              }
          }
        flagHasPhoneEntries = true;
        storePhoneEntries.Clear();
      }
    public void appendPhoneEntries(TypePhoneEntriesJSON  to_append)
      {
        if (!flagHasPhoneEntries)
          {
            flagHasPhoneEntries = true;
            storePhoneEntries.Clear();
          }
        Debug.Assert(flagHasPhoneEntries);
        storePhoneEntries.Add(to_append);
      }
    public void unsetPhoneEntries()
      {
        if (flagHasPhoneEntries)
          {
            for (int num2 = 0; num2 < storePhoneEntries.Count; ++num2)
              {
              }
          }
        flagHasPhoneEntries = false;
        storePhoneEntries.Clear();
      }
    public void setDefaultPhone(string new_value)
      {
        flagHasDefaultPhone = true;
        storeDefaultPhone = new_value;
      }
    public void unsetDefaultPhone()
      {
        flagHasDefaultPhone = false;
      }
    public void setTimesCalled(BigInteger new_value)
      {
        flagHasTimesCalled = true;
        if (new_value < 0)
            throw new Exception("The value for field TimesCalled of OneContactJSON is less than the lower bound (0) for that field.");
        storeTimesCalled = new_value;
      }
    public void unsetTimesCalled()
      {
        flagHasTimesCalled = false;
      }
    public void setLastCalled(DateAndOrTimeJSON  new_value)
      {
        if (flagHasLastCalled)
          {
          }
        flagHasLastCalled = true;
        storeLastCalled = new_value;
      }
    public void unsetLastCalled()
      {
        if (flagHasLastCalled)
          {
          }
        flagHasLastCalled = false;
      }
    public void setTimesContacted(BigInteger new_value)
      {
        flagHasTimesContacted = true;
        if (new_value < 0)
            throw new Exception("The value for field TimesContacted of OneContactJSON is less than the lower bound (0) for that field.");
        storeTimesContacted = new_value;
      }
    public void unsetTimesContacted()
      {
        flagHasTimesContacted = false;
      }
    public void setLastContacted(DateAndOrTimeJSON  new_value)
      {
        if (flagHasLastContacted)
          {
          }
        flagHasLastContacted = true;
        storeLastContacted = new_value;
      }
    public void unsetLastContacted()
      {
        if (flagHasLastContacted)
          {
          }
        flagHasLastContacted = false;
      }
    public void initEmailEntries()
      {
        if (flagHasEmailEntries)
          {
            for (int num3 = 0; num3 < storeEmailEntries.Count; ++num3)
              {
              }
          }
        flagHasEmailEntries = true;
        storeEmailEntries.Clear();
      }
    public void appendEmailEntries(TypeEmailEntriesJSON  to_append)
      {
        if (!flagHasEmailEntries)
          {
            flagHasEmailEntries = true;
            storeEmailEntries.Clear();
          }
        Debug.Assert(flagHasEmailEntries);
        storeEmailEntries.Add(to_append);
      }
    public void unsetEmailEntries()
      {
        if (flagHasEmailEntries)
          {
            for (int num4 = 0; num4 < storeEmailEntries.Count; ++num4)
              {
              }
          }
        flagHasEmailEntries = false;
        storeEmailEntries.Clear();
      }
    public void setDefaultEmail(string new_value)
      {
        flagHasDefaultEmail = true;
        storeDefaultEmail = new_value;
      }
    public void unsetDefaultEmail()
      {
        flagHasDefaultEmail = false;
      }
    public void initMapAddressEntries()
      {
        if (flagHasMapAddressEntries)
          {
            for (int num5 = 0; num5 < storeMapAddressEntries.Count; ++num5)
              {
              }
          }
        flagHasMapAddressEntries = true;
        storeMapAddressEntries.Clear();
      }
    public void appendMapAddressEntries(TypeMapAddressEntriesJSON  to_append)
      {
        if (!flagHasMapAddressEntries)
          {
            flagHasMapAddressEntries = true;
            storeMapAddressEntries.Clear();
          }
        Debug.Assert(flagHasMapAddressEntries);
        storeMapAddressEntries.Add(to_append);
      }
    public void unsetMapAddressEntries()
      {
        if (flagHasMapAddressEntries)
          {
            for (int num6 = 0; num6 < storeMapAddressEntries.Count; ++num6)
              {
              }
          }
        flagHasMapAddressEntries = false;
        storeMapAddressEntries.Clear();
      }
    public void setDefaultMapAddress(string new_value)
      {
        flagHasDefaultMapAddress = true;
        storeDefaultMapAddress = new_value;
      }
    public void unsetDefaultMapAddress()
      {
        flagHasDefaultMapAddress = false;
      }
    public void setIsFavorite(bool new_value)
      {
        flagHasIsFavorite = true;
        storeIsFavorite = new_value;
      }
    public void unsetIsFavorite()
      {
        flagHasIsFavorite = false;
      }
    public void setSex(TypeSex new_value)
      {
        flagHasSex = true;
        storeSex = new_value;
      }
    public void setSex(string chars)
      {
        setSex(stringToSex(chars));
      }
    public void unsetSex()
      {
        flagHasSex = false;
      }
    public void setIsVisible(bool new_value)
      {
        flagHasIsVisible = true;
        storeIsVisible = new_value;
      }
    public void unsetIsVisible()
      {
        flagHasIsVisible = false;
      }

    public virtual void extraOneContactAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOneContactSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOneContactLookup(key);
        if (old_field == null)
          {
            extraOneContactAppendPair(key, new_component);
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
        if (flagHasFirstName)
          {
            handler.start_pair("FirstName");
            handler.string_value(storeFirstName);
          }
        if (flagHasLastName)
          {
            handler.start_pair("LastName");
            handler.string_value(storeLastName);
          }
        if (flagHasSingleName)
          {
            handler.start_pair("SingleName");
            handler.string_value(storeSingleName);
          }
        if (flagHasNickNames)
          {
            handler.start_pair("NickNames");
            handler.start_array();
            for (int num1 = 0; num1 < storeNickNames.Count; ++num1)
              {
                handler.string_value(storeNickNames[num1]);
              }
            handler.finish_array();
          }
        if (flagHasPhoneEntries)
          {
            handler.start_pair("PhoneEntries");
            handler.start_array();
            for (int num2 = 0; num2 < storePhoneEntries.Count; ++num2)
              {
                if (partial_allowed)
                    storePhoneEntries[num2].write_partial_as_json(handler);
                else
                    storePhoneEntries[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDefaultPhone)
          {
            handler.start_pair("DefaultPhone");
            handler.string_value(storeDefaultPhone);
          }
        if (flagHasTimesCalled)
          {
            handler.start_pair("TimesCalled");
            handler.number_value(storeTimesCalled);
          }
        if (flagHasLastCalled)
          {
            handler.start_pair("LastCalled");
            if (partial_allowed)
                storeLastCalled.write_partial_as_json(handler);
            else
                storeLastCalled.write_as_json(handler);
          }
        if (flagHasTimesContacted)
          {
            handler.start_pair("TimesContacted");
            handler.number_value(storeTimesContacted);
          }
        if (flagHasLastContacted)
          {
            handler.start_pair("LastContacted");
            if (partial_allowed)
                storeLastContacted.write_partial_as_json(handler);
            else
                storeLastContacted.write_as_json(handler);
          }
        if (flagHasEmailEntries)
          {
            handler.start_pair("EmailEntries");
            handler.start_array();
            for (int num3 = 0; num3 < storeEmailEntries.Count; ++num3)
              {
                if (partial_allowed)
                    storeEmailEntries[num3].write_partial_as_json(handler);
                else
                    storeEmailEntries[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDefaultEmail)
          {
            handler.start_pair("DefaultEmail");
            handler.string_value(storeDefaultEmail);
          }
        if (flagHasMapAddressEntries)
          {
            handler.start_pair("MapAddressEntries");
            handler.start_array();
            for (int num4 = 0; num4 < storeMapAddressEntries.Count; ++num4)
              {
                if (partial_allowed)
                    storeMapAddressEntries[num4].write_partial_as_json(handler);
                else
                    storeMapAddressEntries[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDefaultMapAddress)
          {
            handler.start_pair("DefaultMapAddress");
            handler.string_value(storeDefaultMapAddress);
          }
        if (flagHasIsFavorite)
          {
            handler.start_pair("IsFavorite");
            handler.boolean_value(storeIsFavorite);
          }
        if (flagHasSex)
          {
            handler.start_pair("Sex");
            switch (storeSex)
              {
                case TypeSex.Sex_Female:
                    handler.string_value("Female");
                    break;
                case TypeSex.Sex_Male:
                    handler.string_value("Male");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasIsVisible)
          {
            handler.start_pair("IsVisible");
            handler.boolean_value(storeIsVisible);
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

    public static OneContactJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OneContactJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OneContact", ignore_extras);
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
    public static OneContactJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OneContactJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OneContactJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OneContact", ignore_extras);
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
    public static OneContactJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OneContactJSON from_text(string text, bool ignore_extras)
      {
        OneContactJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OneContact", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OneContactJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OneContactJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OneContactJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OneContact", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorFirstName;
        private JSONHoldingStringGenerator fieldGeneratorLastName;
        private JSONHoldingStringGenerator fieldGeneratorSingleName;
        private JSONHoldingStringArrayGenerator fieldGeneratorNickNames;
        private TypePhoneEntriesJSON.HoldingArrayGenerator fieldGeneratorPhoneEntries;
        private JSONHoldingStringGenerator fieldGeneratorDefaultPhone;
    private class FieldHoldingGeneratorTimesCalled : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTimesCalled(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTimesCalled : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTimesCalled(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTimesCalled fieldGeneratorTimesCalled;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorLastCalled;
    private class FieldHoldingGeneratorTimesContacted : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTimesContacted(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTimesContacted : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTimesContacted(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTimesContacted fieldGeneratorTimesContacted;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorLastContacted;
        private TypeEmailEntriesJSON.HoldingArrayGenerator fieldGeneratorEmailEntries;
        private JSONHoldingStringGenerator fieldGeneratorDefaultEmail;
        private TypeMapAddressEntriesJSON.HoldingArrayGenerator fieldGeneratorMapAddressEntries;
        private JSONHoldingStringGenerator fieldGeneratorDefaultMapAddress;
        private JSONHoldingBooleanGenerator fieldGeneratorIsFavorite;
    private abstract class FieldGeneratorSex : JSONStringGenerator
          {
            protected FieldGeneratorSex(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSex()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSex(result));
              }
            protected abstract void handle_result(TypeSex result);
          };
    private class FieldHoldingGeneratorSex : FieldGeneratorSex
  {
    protected override void handle_result(TypeSex result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSex(String what)
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
    public TypeSex value;
  };
    private class FieldHoldingArrayGeneratorSex : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSex
      {
        private FieldHoldingArrayGeneratorSex top;

        protected override void handle_result(TypeSex result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSex init_top)
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
    protected virtual void handle_result(List<TypeSex> result)
      {
      }

    public FieldHoldingArrayGeneratorSex(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSex>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSex()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSex>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSex> value;
  };
        private FieldHoldingGeneratorSex fieldGeneratorSex;
        private JSONHoldingBooleanGenerator fieldGeneratorIsVisible;
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
            OneContactJSON result = new OneContactJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOneContactAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OneContactJSON result)
          {
            if (fieldGeneratorFirstName.have_value)
              {
                result.setFirstName(fieldGeneratorFirstName.value);
                fieldGeneratorFirstName.have_value = false;
              }
            if (fieldGeneratorLastName.have_value)
              {
                result.setLastName(fieldGeneratorLastName.value);
                fieldGeneratorLastName.have_value = false;
              }
            if (fieldGeneratorSingleName.have_value)
              {
                result.setSingleName(fieldGeneratorSingleName.value);
                fieldGeneratorSingleName.have_value = false;
              }
            if (fieldGeneratorNickNames.have_value)
              {
                result.initNickNames();
                int count = fieldGeneratorNickNames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNickNames(fieldGeneratorNickNames.value[num]);
                  }
                fieldGeneratorNickNames.value.Clear();
                fieldGeneratorNickNames.have_value = false;
              }
            if (fieldGeneratorPhoneEntries.have_value)
              {
                result.initPhoneEntries();
                int count = fieldGeneratorPhoneEntries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPhoneEntries(fieldGeneratorPhoneEntries.value[num]);
                  }
                fieldGeneratorPhoneEntries.value.Clear();
                fieldGeneratorPhoneEntries.have_value = false;
              }
            if (fieldGeneratorDefaultPhone.have_value)
              {
                result.setDefaultPhone(fieldGeneratorDefaultPhone.value);
                fieldGeneratorDefaultPhone.have_value = false;
              }
            if (fieldGeneratorTimesCalled.have_value)
              {
                result.setTimesCalled(fieldGeneratorTimesCalled.value);
                fieldGeneratorTimesCalled.have_value = false;
              }
            if (fieldGeneratorLastCalled.have_value)
              {
                result.setLastCalled(fieldGeneratorLastCalled.value);
                fieldGeneratorLastCalled.have_value = false;
              }
            if (fieldGeneratorTimesContacted.have_value)
              {
                result.setTimesContacted(fieldGeneratorTimesContacted.value);
                fieldGeneratorTimesContacted.have_value = false;
              }
            if (fieldGeneratorLastContacted.have_value)
              {
                result.setLastContacted(fieldGeneratorLastContacted.value);
                fieldGeneratorLastContacted.have_value = false;
              }
            if (fieldGeneratorEmailEntries.have_value)
              {
                result.initEmailEntries();
                int count = fieldGeneratorEmailEntries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEmailEntries(fieldGeneratorEmailEntries.value[num]);
                  }
                fieldGeneratorEmailEntries.value.Clear();
                fieldGeneratorEmailEntries.have_value = false;
              }
            if (fieldGeneratorDefaultEmail.have_value)
              {
                result.setDefaultEmail(fieldGeneratorDefaultEmail.value);
                fieldGeneratorDefaultEmail.have_value = false;
              }
            if (fieldGeneratorMapAddressEntries.have_value)
              {
                result.initMapAddressEntries();
                int count = fieldGeneratorMapAddressEntries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMapAddressEntries(fieldGeneratorMapAddressEntries.value[num]);
                  }
                fieldGeneratorMapAddressEntries.value.Clear();
                fieldGeneratorMapAddressEntries.have_value = false;
              }
            if (fieldGeneratorDefaultMapAddress.have_value)
              {
                result.setDefaultMapAddress(fieldGeneratorDefaultMapAddress.value);
                fieldGeneratorDefaultMapAddress.have_value = false;
              }
            if (fieldGeneratorIsFavorite.have_value)
              {
                result.setIsFavorite(fieldGeneratorIsFavorite.value);
                fieldGeneratorIsFavorite.have_value = false;
              }
            if (fieldGeneratorSex.have_value)
              {
                result.setSex(fieldGeneratorSex.value);
                fieldGeneratorSex.have_value = false;
              }
            if (fieldGeneratorIsVisible.have_value)
              {
                result.setIsVisible(fieldGeneratorIsVisible.value);
                fieldGeneratorIsVisible.have_value = false;
              }
          }
        protected abstract void handle_result(OneContactJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "efault", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 8, "mail", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorDefaultEmail;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 8, "apAddress", 0, 9, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorDefaultMapAddress;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 8, "hone", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorDefaultPhone;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "mailEntries", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorEmailEntries;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "irstName", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorFirstName;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 3, "avorite", 0, 7, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorIsFavorite;
                                break;
                            case 'V':
                                if ((String.Compare(field_name, 3, "isible", 0, 6, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorIsVisible;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "ast", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'C':
                                switch (field_name[5])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 6, "lled", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorLastCalled;
                                        break;
                                    case 'o':
                                        if ((String.Compare(field_name, 6, "ntacted", 0, 7, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorLastContacted;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 5, "ame", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorLastName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "apAddressEntries", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorMapAddressEntries;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ickNames", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorNickNames;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "honeEntries", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorPhoneEntries;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "x", 0, 1, false) == 0) && (field_name.Length == 3))
                                return fieldGeneratorSex;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "ngleName", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSingleName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "imesC", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 7, "lled", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorTimesCalled;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 7, "ntacted", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorTimesContacted;
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
            fieldGeneratorFirstName = new JSONHoldingStringGenerator("field \"FirstName\" of the OneContact class");
            fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the OneContact class");
            fieldGeneratorSingleName = new JSONHoldingStringGenerator("field \"SingleName\" of the OneContact class");
            fieldGeneratorNickNames = new JSONHoldingStringArrayGenerator("field \"NickNames\" of the OneContact class");
            fieldGeneratorPhoneEntries = new TypePhoneEntriesJSON.HoldingArrayGenerator("field \"PhoneEntries\" of the OneContact class", ignore_extras);
            fieldGeneratorDefaultPhone = new JSONHoldingStringGenerator("field \"DefaultPhone\" of the OneContact class");
            fieldGeneratorTimesCalled = new FieldHoldingGeneratorTimesCalled("field \"TimesCalled\" of the OneContact class");
            fieldGeneratorLastCalled = new DateAndOrTimeJSON.HoldingGenerator("field \"LastCalled\" of the OneContact class", ignore_extras);
            fieldGeneratorTimesContacted = new FieldHoldingGeneratorTimesContacted("field \"TimesContacted\" of the OneContact class");
            fieldGeneratorLastContacted = new DateAndOrTimeJSON.HoldingGenerator("field \"LastContacted\" of the OneContact class", ignore_extras);
            fieldGeneratorEmailEntries = new TypeEmailEntriesJSON.HoldingArrayGenerator("field \"EmailEntries\" of the OneContact class", ignore_extras);
            fieldGeneratorDefaultEmail = new JSONHoldingStringGenerator("field \"DefaultEmail\" of the OneContact class");
            fieldGeneratorMapAddressEntries = new TypeMapAddressEntriesJSON.HoldingArrayGenerator("field \"MapAddressEntries\" of the OneContact class", ignore_extras);
            fieldGeneratorDefaultMapAddress = new JSONHoldingStringGenerator("field \"DefaultMapAddress\" of the OneContact class");
            fieldGeneratorIsFavorite = new JSONHoldingBooleanGenerator("field \"IsFavorite\" of the OneContact class");
            fieldGeneratorSex = new FieldHoldingGeneratorSex("field \"Sex\" of the OneContact class");
            fieldGeneratorIsVisible = new JSONHoldingBooleanGenerator("field \"IsVisible\" of the OneContact class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OneContact class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFirstName = new JSONHoldingStringGenerator("field \"FirstName\" of the OneContact class");
            fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the OneContact class");
            fieldGeneratorSingleName = new JSONHoldingStringGenerator("field \"SingleName\" of the OneContact class");
            fieldGeneratorNickNames = new JSONHoldingStringArrayGenerator("field \"NickNames\" of the OneContact class");
            fieldGeneratorPhoneEntries = new TypePhoneEntriesJSON.HoldingArrayGenerator("field \"PhoneEntries\" of the OneContact class", false);
            fieldGeneratorDefaultPhone = new JSONHoldingStringGenerator("field \"DefaultPhone\" of the OneContact class");
            fieldGeneratorTimesCalled = new FieldHoldingGeneratorTimesCalled("field \"TimesCalled\" of the OneContact class");
            fieldGeneratorLastCalled = new DateAndOrTimeJSON.HoldingGenerator("field \"LastCalled\" of the OneContact class", false);
            fieldGeneratorTimesContacted = new FieldHoldingGeneratorTimesContacted("field \"TimesContacted\" of the OneContact class");
            fieldGeneratorLastContacted = new DateAndOrTimeJSON.HoldingGenerator("field \"LastContacted\" of the OneContact class", false);
            fieldGeneratorEmailEntries = new TypeEmailEntriesJSON.HoldingArrayGenerator("field \"EmailEntries\" of the OneContact class", false);
            fieldGeneratorDefaultEmail = new JSONHoldingStringGenerator("field \"DefaultEmail\" of the OneContact class");
            fieldGeneratorMapAddressEntries = new TypeMapAddressEntriesJSON.HoldingArrayGenerator("field \"MapAddressEntries\" of the OneContact class", false);
            fieldGeneratorDefaultMapAddress = new JSONHoldingStringGenerator("field \"DefaultMapAddress\" of the OneContact class");
            fieldGeneratorIsFavorite = new JSONHoldingBooleanGenerator("field \"IsFavorite\" of the OneContact class");
            fieldGeneratorSex = new FieldHoldingGeneratorSex("field \"Sex\" of the OneContact class");
            fieldGeneratorIsVisible = new JSONHoldingBooleanGenerator("field \"IsVisible\" of the OneContact class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OneContact class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFirstName.reset();
            fieldGeneratorLastName.reset();
            fieldGeneratorSingleName.reset();
            fieldGeneratorNickNames.reset();
            fieldGeneratorPhoneEntries.reset();
            fieldGeneratorDefaultPhone.reset();
            fieldGeneratorTimesCalled.reset();
            fieldGeneratorLastCalled.reset();
            fieldGeneratorTimesContacted.reset();
            fieldGeneratorLastContacted.reset();
            fieldGeneratorEmailEntries.reset();
            fieldGeneratorDefaultEmail.reset();
            fieldGeneratorMapAddressEntries.reset();
            fieldGeneratorDefaultMapAddress.reset();
            fieldGeneratorIsFavorite.reset();
            fieldGeneratorSex.reset();
            fieldGeneratorIsVisible.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPhoneEntries.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLastCalled.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLastContacted.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEmailEntries.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMapAddressEntries.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPhoneEntries.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLastCalled.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLastContacted.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEmailEntries.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMapAddressEntries.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(OneContactJSON  result)
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
        public OneContactJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OneContactJSON  result)
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
    protected virtual void handle_result(List<OneContactJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OneContactJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OneContactJSON>();
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
    public List<OneContactJSON> value;
  };
  };
