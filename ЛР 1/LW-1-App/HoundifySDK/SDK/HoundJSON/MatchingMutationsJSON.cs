/* file "MatchingMutationsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MatchingMutationsJSON : JSONBase
  {
    public class TypePunctuationJSON : JSONBase
      {
        private bool flagHasRemove;
        private bool storeRemove;
        private bool flagHasMutate;
        private bool storeMutate;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONRemove(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Remove of TypePunctuationJSON is not true for false.");
                  }
              }
            setRemove(the_bool);
          }


        private void  fromJSONMutate(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Mutate of TypePunctuationJSON is not true for false.");
                  }
              }
            setMutate(the_bool);
          }


        public TypePunctuationJSON()
          {
            flagHasRemove = false;
            flagHasMutate = false;
            storeRemove = true;
            storeMutate = true;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasRemove()
          {
            return flagHasRemove;
          }

        public bool  getRemove()
          {
            return storeRemove;
          }

        public bool  hasMutate()
          {
            return flagHasMutate;
          }

        public bool  getMutate()
          {
            return storeMutate;
          }


        public virtual int extraTypePunctuationComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePunctuationComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePunctuationComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePunctuationLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setRemove(bool new_value)
          {
            flagHasRemove = true;
            storeRemove = new_value;
          }
        public void unsetRemove()
          {
            flagHasRemove = false;
          }
        public void setMutate(bool new_value)
          {
            flagHasMutate = true;
            storeMutate = new_value;
          }
        public void unsetMutate()
          {
            flagHasMutate = false;
          }

        public virtual void extraTypePunctuationAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePunctuationSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePunctuationLookup(key);
            if (old_field == null)
              {
                extraTypePunctuationAppendPair(key, new_component);
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
            if (flagHasRemove)
              {
                handler.start_pair("Remove");
                handler.boolean_value(storeRemove);
              }
            if (flagHasMutate)
              {
                handler.start_pair("Mutate");
                handler.boolean_value(storeMutate);
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

        public static TypePunctuationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePunctuationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePunctuation", ignore_extras);
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
        public static TypePunctuationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePunctuationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePunctuationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePunctuation", ignore_extras);
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
        public static TypePunctuationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePunctuationJSON from_text(string text, bool ignore_extras)
          {
            TypePunctuationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePunctuation", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePunctuationJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePunctuationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePunctuationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePunctuation", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorRemove;
            private JSONHoldingBooleanGenerator fieldGeneratorMutate;
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
                TypePunctuationJSON result = new TypePunctuationJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePunctuationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePunctuationJSON result)
              {
                if (fieldGeneratorRemove.have_value)
                  {
                    result.setRemove(fieldGeneratorRemove.value);
                    fieldGeneratorRemove.have_value = false;
                  }
                if (fieldGeneratorMutate.have_value)
                  {
                    result.setMutate(fieldGeneratorMutate.value);
                    fieldGeneratorMutate.have_value = false;
                  }
              }
            protected abstract void handle_result(TypePunctuationJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'M':
                        if ((String.Compare(field_name, 1, "utate", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorMutate;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "emove", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorRemove;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorRemove = new JSONHoldingBooleanGenerator("field \"Remove\" of the TypePunctuation class");
                fieldGeneratorMutate = new JSONHoldingBooleanGenerator("field \"Mutate\" of the TypePunctuation class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePunctuation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorRemove = new JSONHoldingBooleanGenerator("field \"Remove\" of the TypePunctuation class");
                fieldGeneratorMutate = new JSONHoldingBooleanGenerator("field \"Mutate\" of the TypePunctuation class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePunctuation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorRemove.reset();
                fieldGeneratorMutate.reset();
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
            protected override void handle_result(TypePunctuationJSON  result)
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
            public TypePunctuationJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePunctuationJSON  result)
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
        protected virtual void handle_result(List<TypePunctuationJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePunctuationJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePunctuationJSON>();
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
        public List<TypePunctuationJSON> value;
      };
      };
    public class TypeSpellingJSON : JSONBase
      {
        private bool flagHasFix;
        private bool storeFix;
        private bool flagHasMutate;
        private bool storeMutate;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONFix(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Fix of TypeSpellingJSON is not true for false.");
                  }
              }
            setFix(the_bool);
          }


        private void  fromJSONMutate(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Mutate of TypeSpellingJSON is not true for false.");
                  }
              }
            setMutate(the_bool);
          }


        public TypeSpellingJSON()
          {
            flagHasFix = false;
            flagHasMutate = false;
            storeFix = false;
            storeMutate = true;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasFix()
          {
            return flagHasFix;
          }

        public bool  getFix()
          {
            return storeFix;
          }

        public bool  hasMutate()
          {
            return flagHasMutate;
          }

        public bool  getMutate()
          {
            return storeMutate;
          }


        public virtual int extraTypeSpellingComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSpellingComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSpellingComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSpellingLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setFix(bool new_value)
          {
            flagHasFix = true;
            storeFix = new_value;
          }
        public void unsetFix()
          {
            flagHasFix = false;
          }
        public void setMutate(bool new_value)
          {
            flagHasMutate = true;
            storeMutate = new_value;
          }
        public void unsetMutate()
          {
            flagHasMutate = false;
          }

        public virtual void extraTypeSpellingAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSpellingSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSpellingLookup(key);
            if (old_field == null)
              {
                extraTypeSpellingAppendPair(key, new_component);
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
            if (flagHasFix)
              {
                handler.start_pair("Fix");
                handler.boolean_value(storeFix);
              }
            if (flagHasMutate)
              {
                handler.start_pair("Mutate");
                handler.boolean_value(storeMutate);
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

        public static TypeSpellingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSpellingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSpelling", ignore_extras);
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
        public static TypeSpellingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSpellingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSpellingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSpelling", ignore_extras);
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
        public static TypeSpellingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSpellingJSON from_text(string text, bool ignore_extras)
          {
            TypeSpellingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSpelling", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSpellingJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSpellingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSpellingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSpelling", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorFix;
            private JSONHoldingBooleanGenerator fieldGeneratorMutate;
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
                TypeSpellingJSON result = new TypeSpellingJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSpellingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSpellingJSON result)
              {
                if (fieldGeneratorFix.have_value)
                  {
                    result.setFix(fieldGeneratorFix.value);
                    fieldGeneratorFix.have_value = false;
                  }
                if (fieldGeneratorMutate.have_value)
                  {
                    result.setMutate(fieldGeneratorMutate.value);
                    fieldGeneratorMutate.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeSpellingJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'F':
                        if ((String.Compare(field_name, 1, "ix", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorFix;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "utate", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorMutate;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorFix = new JSONHoldingBooleanGenerator("field \"Fix\" of the TypeSpelling class");
                fieldGeneratorMutate = new JSONHoldingBooleanGenerator("field \"Mutate\" of the TypeSpelling class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSpelling class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorFix = new JSONHoldingBooleanGenerator("field \"Fix\" of the TypeSpelling class");
                fieldGeneratorMutate = new JSONHoldingBooleanGenerator("field \"Mutate\" of the TypeSpelling class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSpelling class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorFix.reset();
                fieldGeneratorMutate.reset();
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
            protected override void handle_result(TypeSpellingJSON  result)
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
            public TypeSpellingJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSpellingJSON  result)
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
        protected virtual void handle_result(List<TypeSpellingJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSpellingJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSpellingJSON>();
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
        public List<TypeSpellingJSON> value;
      };
      };
    public class TypeSynonymsJSON : JSONBase
      {
        private bool flagHasReplace;
        private bool storeReplace;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONReplace(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Replace of TypeSynonymsJSON is not true for false.");
                  }
              }
            setReplace(the_bool);
          }


        public TypeSynonymsJSON()
          {
            flagHasReplace = false;
            storeReplace = true;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasReplace()
          {
            return flagHasReplace;
          }

        public bool  getReplace()
          {
            return storeReplace;
          }


        public virtual int extraTypeSynonymsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSynonymsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSynonymsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSynonymsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setReplace(bool new_value)
          {
            flagHasReplace = true;
            storeReplace = new_value;
          }
        public void unsetReplace()
          {
            flagHasReplace = false;
          }

        public virtual void extraTypeSynonymsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSynonymsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSynonymsLookup(key);
            if (old_field == null)
              {
                extraTypeSynonymsAppendPair(key, new_component);
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
            if (flagHasReplace)
              {
                handler.start_pair("Replace");
                handler.boolean_value(storeReplace);
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

        public static TypeSynonymsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSynonymsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSynonyms", ignore_extras);
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
        public static TypeSynonymsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSynonymsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSynonymsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSynonyms", ignore_extras);
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
        public static TypeSynonymsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSynonymsJSON from_text(string text, bool ignore_extras)
          {
            TypeSynonymsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSynonyms", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSynonymsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSynonymsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSynonymsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSynonyms", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorReplace;
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
                TypeSynonymsJSON result = new TypeSynonymsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSynonymsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSynonymsJSON result)
              {
                if (fieldGeneratorReplace.have_value)
                  {
                    result.setReplace(fieldGeneratorReplace.value);
                    fieldGeneratorReplace.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeSynonymsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Replace", 0, 7, false) == 0) && (field_name.Length == 7))
                    return fieldGeneratorReplace;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorReplace = new JSONHoldingBooleanGenerator("field \"Replace\" of the TypeSynonyms class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSynonyms class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorReplace = new JSONHoldingBooleanGenerator("field \"Replace\" of the TypeSynonyms class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSynonyms class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorReplace.reset();
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
            protected override void handle_result(TypeSynonymsJSON  result)
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
            public TypeSynonymsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSynonymsJSON  result)
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
        protected virtual void handle_result(List<TypeSynonymsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSynonymsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSynonymsJSON>();
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
        public List<TypeSynonymsJSON> value;
      };
      };
    public class TypeNumbersJSON : JSONBase
      {
        private bool flagHasSpellOut;
        private bool storeSpellOut;
        private bool flagHasDigitize;
        private bool storeDigitize;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONSpellOut(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field SpellOut of TypeNumbersJSON is not true for false.");
                  }
              }
            setSpellOut(the_bool);
          }


        private void  fromJSONDigitize(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Digitize of TypeNumbersJSON is not true for false.");
                  }
              }
            setDigitize(the_bool);
          }


        public TypeNumbersJSON()
          {
            flagHasSpellOut = false;
            flagHasDigitize = false;
            storeSpellOut = true;
            storeDigitize = true;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasSpellOut()
          {
            return flagHasSpellOut;
          }

        public bool  getSpellOut()
          {
            return storeSpellOut;
          }

        public bool  hasDigitize()
          {
            return flagHasDigitize;
          }

        public bool  getDigitize()
          {
            return storeDigitize;
          }


        public virtual int extraTypeNumbersComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNumbersComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNumbersComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNumbersLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setSpellOut(bool new_value)
          {
            flagHasSpellOut = true;
            storeSpellOut = new_value;
          }
        public void unsetSpellOut()
          {
            flagHasSpellOut = false;
          }
        public void setDigitize(bool new_value)
          {
            flagHasDigitize = true;
            storeDigitize = new_value;
          }
        public void unsetDigitize()
          {
            flagHasDigitize = false;
          }

        public virtual void extraTypeNumbersAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNumbersSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNumbersLookup(key);
            if (old_field == null)
              {
                extraTypeNumbersAppendPair(key, new_component);
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
            if (flagHasSpellOut)
              {
                handler.start_pair("SpellOut");
                handler.boolean_value(storeSpellOut);
              }
            if (flagHasDigitize)
              {
                handler.start_pair("Digitize");
                handler.boolean_value(storeDigitize);
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

        public static TypeNumbersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNumbersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumbers", ignore_extras);
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
        public static TypeNumbersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNumbersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNumbersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumbers", ignore_extras);
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
        public static TypeNumbersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNumbersJSON from_text(string text, bool ignore_extras)
          {
            TypeNumbersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumbers", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNumbersJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNumbersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNumbersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumbers", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorSpellOut;
            private JSONHoldingBooleanGenerator fieldGeneratorDigitize;
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
                TypeNumbersJSON result = new TypeNumbersJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNumbersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNumbersJSON result)
              {
                if (fieldGeneratorSpellOut.have_value)
                  {
                    result.setSpellOut(fieldGeneratorSpellOut.value);
                    fieldGeneratorSpellOut.have_value = false;
                  }
                if (fieldGeneratorDigitize.have_value)
                  {
                    result.setDigitize(fieldGeneratorDigitize.value);
                    fieldGeneratorDigitize.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNumbersJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "igitize", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorDigitize;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "pellOut", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorSpellOut;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorSpellOut = new JSONHoldingBooleanGenerator("field \"SpellOut\" of the TypeNumbers class");
                fieldGeneratorDigitize = new JSONHoldingBooleanGenerator("field \"Digitize\" of the TypeNumbers class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNumbers class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorSpellOut = new JSONHoldingBooleanGenerator("field \"SpellOut\" of the TypeNumbers class");
                fieldGeneratorDigitize = new JSONHoldingBooleanGenerator("field \"Digitize\" of the TypeNumbers class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNumbers class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorSpellOut.reset();
                fieldGeneratorDigitize.reset();
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
            protected override void handle_result(TypeNumbersJSON  result)
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
            public TypeNumbersJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNumbersJSON  result)
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
        protected virtual void handle_result(List<TypeNumbersJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNumbersJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNumbersJSON>();
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
        public List<TypeNumbersJSON> value;
      };
      };
    public class TypePhrasingJSON : JSONBase
      {
        private bool flagHasReorder;
        private bool storeReorder;
        private bool flagHasMergeWords;
        private bool storeMergeWords;
        private bool flagHasDeleteRepetitions;
        private bool storeDeleteRepetitions;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONReorder(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Reorder of TypePhrasingJSON is not true for false.");
                  }
              }
            setReorder(the_bool);
          }


        private void  fromJSONMergeWords(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field MergeWords of TypePhrasingJSON is not true for false.");
                  }
              }
            setMergeWords(the_bool);
          }


        private void  fromJSONDeleteRepetitions(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field DeleteRepetitions of TypePhrasingJSON is not true for false.");
                  }
              }
            setDeleteRepetitions(the_bool);
          }


        public TypePhrasingJSON()
          {
            flagHasReorder = false;
            flagHasMergeWords = false;
            flagHasDeleteRepetitions = false;
            storeReorder = true;
            storeMergeWords = true;
            storeDeleteRepetitions = true;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasReorder()
          {
            return flagHasReorder;
          }

        public bool  getReorder()
          {
            return storeReorder;
          }

        public bool  hasMergeWords()
          {
            return flagHasMergeWords;
          }

        public bool  getMergeWords()
          {
            return storeMergeWords;
          }

        public bool  hasDeleteRepetitions()
          {
            return flagHasDeleteRepetitions;
          }

        public bool  getDeleteRepetitions()
          {
            return storeDeleteRepetitions;
          }


        public virtual int extraTypePhrasingComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePhrasingComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePhrasingComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePhrasingLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setReorder(bool new_value)
          {
            flagHasReorder = true;
            storeReorder = new_value;
          }
        public void unsetReorder()
          {
            flagHasReorder = false;
          }
        public void setMergeWords(bool new_value)
          {
            flagHasMergeWords = true;
            storeMergeWords = new_value;
          }
        public void unsetMergeWords()
          {
            flagHasMergeWords = false;
          }
        public void setDeleteRepetitions(bool new_value)
          {
            flagHasDeleteRepetitions = true;
            storeDeleteRepetitions = new_value;
          }
        public void unsetDeleteRepetitions()
          {
            flagHasDeleteRepetitions = false;
          }

        public virtual void extraTypePhrasingAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePhrasingSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePhrasingLookup(key);
            if (old_field == null)
              {
                extraTypePhrasingAppendPair(key, new_component);
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
            if (flagHasReorder)
              {
                handler.start_pair("Reorder");
                handler.boolean_value(storeReorder);
              }
            if (flagHasMergeWords)
              {
                handler.start_pair("MergeWords");
                handler.boolean_value(storeMergeWords);
              }
            if (flagHasDeleteRepetitions)
              {
                handler.start_pair("DeleteRepetitions");
                handler.boolean_value(storeDeleteRepetitions);
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

        public static TypePhrasingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePhrasingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhrasing", ignore_extras);
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
        public static TypePhrasingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePhrasingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePhrasingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhrasing", ignore_extras);
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
        public static TypePhrasingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePhrasingJSON from_text(string text, bool ignore_extras)
          {
            TypePhrasingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhrasing", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePhrasingJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePhrasingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePhrasingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhrasing", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorReorder;
            private JSONHoldingBooleanGenerator fieldGeneratorMergeWords;
            private JSONHoldingBooleanGenerator fieldGeneratorDeleteRepetitions;
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
                TypePhrasingJSON result = new TypePhrasingJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePhrasingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePhrasingJSON result)
              {
                if (fieldGeneratorReorder.have_value)
                  {
                    result.setReorder(fieldGeneratorReorder.value);
                    fieldGeneratorReorder.have_value = false;
                  }
                if (fieldGeneratorMergeWords.have_value)
                  {
                    result.setMergeWords(fieldGeneratorMergeWords.value);
                    fieldGeneratorMergeWords.have_value = false;
                  }
                if (fieldGeneratorDeleteRepetitions.have_value)
                  {
                    result.setDeleteRepetitions(fieldGeneratorDeleteRepetitions.value);
                    fieldGeneratorDeleteRepetitions.have_value = false;
                  }
              }
            protected abstract void handle_result(TypePhrasingJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "eleteRepetitions", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorDeleteRepetitions;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "ergeWords", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorMergeWords;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "eorder", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorReorder;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorReorder = new JSONHoldingBooleanGenerator("field \"Reorder\" of the TypePhrasing class");
                fieldGeneratorMergeWords = new JSONHoldingBooleanGenerator("field \"MergeWords\" of the TypePhrasing class");
                fieldGeneratorDeleteRepetitions = new JSONHoldingBooleanGenerator("field \"DeleteRepetitions\" of the TypePhrasing class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePhrasing class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorReorder = new JSONHoldingBooleanGenerator("field \"Reorder\" of the TypePhrasing class");
                fieldGeneratorMergeWords = new JSONHoldingBooleanGenerator("field \"MergeWords\" of the TypePhrasing class");
                fieldGeneratorDeleteRepetitions = new JSONHoldingBooleanGenerator("field \"DeleteRepetitions\" of the TypePhrasing class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePhrasing class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorReorder.reset();
                fieldGeneratorMergeWords.reset();
                fieldGeneratorDeleteRepetitions.reset();
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
            protected override void handle_result(TypePhrasingJSON  result)
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
            public TypePhrasingJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePhrasingJSON  result)
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
        protected virtual void handle_result(List<TypePhrasingJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePhrasingJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePhrasingJSON>();
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
        public List<TypePhrasingJSON> value;
      };
      };
    public class TypeDeletionsJSON : JSONBase
      {
        public enum TypeNonFillersKnownValues
          {
            NonFillers_None,
            NonFillers_Safe,
            NonFillers_Medium,
            NonFillers_High,
            NonFillers__none
          };
        public struct TypeNonFillers
          {
            public bool in_known_list;
            public string string_value;
            public TypeNonFillersKnownValues list_value;
          };

        public static TypeNonFillersKnownValues  stringToNonFillers(string chars)
          {
            switch (chars[0])
              {
                case 'H':
                    if ((String.Compare(chars, 1, "igh", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeNonFillersKnownValues.NonFillers_High;
                    break;
                case 'M':
                    if ((String.Compare(chars, 1, "edium", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeNonFillersKnownValues.NonFillers_Medium;
                    break;
                case 'N':
                    if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeNonFillersKnownValues.NonFillers_None;
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "afe", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeNonFillersKnownValues.NonFillers_Safe;
                    break;
                default:
                    break;
              }
            return TypeNonFillersKnownValues.NonFillers__none;
          }

        public static string  stringFromNonFillers(TypeNonFillersKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeNonFillersKnownValues.NonFillers_None:
                    return "None";
                case TypeNonFillersKnownValues.NonFillers_Safe:
                    return "Safe";
                case TypeNonFillersKnownValues.NonFillers_Medium:
                    return "Medium";
                case TypeNonFillersKnownValues.NonFillers_High:
                    return "High";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasFillers;
        private bool storeFillers;
        private bool flagHasNonFillers;
        private TypeNonFillers storeNonFillers;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONFillers(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Fillers of TypeDeletionsJSON is not true for false.");
                  }
              }
            setFillers(the_bool);
          }


        private void  fromJSONNonFillers(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NonFillers of TypeDeletionsJSON is not a string.");
            TypeNonFillers the_open_enum = new TypeNonFillers();
            switch (json_string.getData()[0])
              {
                case 'H':
                    if ((String.Compare(json_string.getData(), 1, "igh", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeNonFillersKnownValues.NonFillers_High;
                            goto open_enum_is_done;
                          }
                    break;
                case 'M':
                    if ((String.Compare(json_string.getData(), 1, "edium", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeNonFillersKnownValues.NonFillers_Medium;
                            goto open_enum_is_done;
                          }
                    break;
                case 'N':
                    if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeNonFillersKnownValues.NonFillers_None;
                            goto open_enum_is_done;
                          }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "afe", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeNonFillersKnownValues.NonFillers_Safe;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setNonFillers(the_open_enum);
          }


        public TypeDeletionsJSON()
          {
            flagHasFillers = false;
            flagHasNonFillers = false;
            storeFillers = true;
            storeNonFillers.in_known_list = true;
            storeNonFillers.list_value = TypeNonFillersKnownValues.NonFillers_High;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasFillers()
          {
            return flagHasFillers;
          }

        public bool  getFillers()
          {
            return storeFillers;
          }

        public bool  hasNonFillers()
          {
            return flagHasNonFillers;
          }

        public TypeNonFillers  getNonFillers()
          {
            return storeNonFillers;
          }

        public string  getNonFillersAsString()
          {
            TypeNonFillers result = getNonFillers();
            if (result.in_known_list)
                return stringFromNonFillers(result.list_value);
            else
                return result.string_value;
          }


        public virtual int extraTypeDeletionsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDeletionsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDeletionsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDeletionsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setFillers(bool new_value)
          {
            flagHasFillers = true;
            storeFillers = new_value;
          }
        public void unsetFillers()
          {
            flagHasFillers = false;
          }
        public void setNonFillers(TypeNonFillers new_value)
          {
            flagHasNonFillers = true;
            storeNonFillers = new_value;
          }
        public void setNonFillers(string chars)
          {
            TypeNonFillersKnownValues known = stringToNonFillers(chars);
            TypeNonFillers new_value = new TypeNonFillers();
            if (known == TypeNonFillersKnownValues.NonFillers__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setNonFillers(new_value);
          }
        public void setNonFillers(TypeNonFillersKnownValues new_value)
          {
            TypeNonFillers new_full_value = new TypeNonFillers();
            Debug.Assert(new_value != TypeNonFillersKnownValues.NonFillers__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setNonFillers(new_full_value);
          }
        public void unsetNonFillers()
          {
            flagHasNonFillers = false;
          }

        public virtual void extraTypeDeletionsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDeletionsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDeletionsLookup(key);
            if (old_field == null)
              {
                extraTypeDeletionsAppendPair(key, new_component);
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
            if (flagHasFillers)
              {
                handler.start_pair("Fillers");
                handler.boolean_value(storeFillers);
              }
            if (flagHasNonFillers)
              {
                handler.start_pair("NonFillers");
                if (storeNonFillers.in_known_list)
                  {
                    switch (storeNonFillers.list_value)
                      {
                        case TypeNonFillersKnownValues.NonFillers_None:
                            handler.string_value("None");
                            break;
                        case TypeNonFillersKnownValues.NonFillers_Safe:
                            handler.string_value("Safe");
                            break;
                        case TypeNonFillersKnownValues.NonFillers_Medium:
                            handler.string_value("Medium");
                            break;
                        case TypeNonFillersKnownValues.NonFillers_High:
                            handler.string_value("High");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeNonFillers.string_value);
                  }
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

        public static TypeDeletionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDeletionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDeletions", ignore_extras);
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
        public static TypeDeletionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDeletionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDeletionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDeletions", ignore_extras);
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
        public static TypeDeletionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDeletionsJSON from_text(string text, bool ignore_extras)
          {
            TypeDeletionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDeletions", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDeletionsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDeletionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDeletionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDeletions", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorFillers;
        private abstract class FieldGeneratorNonFillers : JSONStringGenerator
              {
                protected FieldGeneratorNonFillers(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorNonFillers()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeNonFillersKnownValues known = stringToNonFillers(result);
                    TypeNonFillers new_value = new TypeNonFillers();
                    if (known == TypeNonFillersKnownValues.NonFillers__none)
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
                protected abstract void handle_result(TypeNonFillers result);
              };
        private class FieldHoldingGeneratorNonFillers : FieldGeneratorNonFillers
      {
        protected override void handle_result(TypeNonFillers result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorNonFillers(String what)
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
        public TypeNonFillers value;
      };
        private class FieldHoldingArrayGeneratorNonFillers : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorNonFillers
          {
            private FieldHoldingArrayGeneratorNonFillers top;

            protected override void handle_result(TypeNonFillers result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorNonFillers init_top)
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
        protected virtual void handle_result(List<TypeNonFillers> result)
          {
          }

        public FieldHoldingArrayGeneratorNonFillers(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeNonFillers>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorNonFillers()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeNonFillers>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeNonFillers> value;
      };
            private FieldHoldingGeneratorNonFillers fieldGeneratorNonFillers;
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
                TypeDeletionsJSON result = new TypeDeletionsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDeletionsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDeletionsJSON result)
              {
                if (fieldGeneratorFillers.have_value)
                  {
                    result.setFillers(fieldGeneratorFillers.value);
                    fieldGeneratorFillers.have_value = false;
                  }
                if (fieldGeneratorNonFillers.have_value)
                  {
                    result.setNonFillers(fieldGeneratorNonFillers.value);
                    fieldGeneratorNonFillers.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeDeletionsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'F':
                        if ((String.Compare(field_name, 1, "illers", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorFillers;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "onFillers", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorNonFillers;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorFillers = new JSONHoldingBooleanGenerator("field \"Fillers\" of the TypeDeletions class");
                fieldGeneratorNonFillers = new FieldHoldingGeneratorNonFillers("field \"NonFillers\" of the TypeDeletions class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDeletions class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorFillers = new JSONHoldingBooleanGenerator("field \"Fillers\" of the TypeDeletions class");
                fieldGeneratorNonFillers = new FieldHoldingGeneratorNonFillers("field \"NonFillers\" of the TypeDeletions class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDeletions class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorFillers.reset();
                fieldGeneratorNonFillers.reset();
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
            protected override void handle_result(TypeDeletionsJSON  result)
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
            public TypeDeletionsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDeletionsJSON  result)
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
        protected virtual void handle_result(List<TypeDeletionsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDeletionsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDeletionsJSON>();
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
        public List<TypeDeletionsJSON> value;
      };
      };
    private bool flagHasPunctuation;
    private TypePunctuationJSON  storePunctuation;
    private bool flagHasSpelling;
    private TypeSpellingJSON  storeSpelling;
    private bool flagHasSynonyms;
    private TypeSynonymsJSON  storeSynonyms;
    private bool flagHasNumbers;
    private TypeNumbersJSON  storeNumbers;
    private bool flagHasPhrasing;
    private TypePhrasingJSON  storePhrasing;
    private bool flagHasDeletions;
    private TypeDeletionsJSON  storeDeletions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPunctuation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePunctuationJSON convert_classy = TypePunctuationJSON.from_json(json_value, ignore_extras, true);
        setPunctuation(convert_classy);
      }


    private void  fromJSONSpelling(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSpellingJSON convert_classy = TypeSpellingJSON.from_json(json_value, ignore_extras, true);
        setSpelling(convert_classy);
      }


    private void  fromJSONSynonyms(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSynonymsJSON convert_classy = TypeSynonymsJSON.from_json(json_value, ignore_extras, true);
        setSynonyms(convert_classy);
      }


    private void  fromJSONNumbers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNumbersJSON convert_classy = TypeNumbersJSON.from_json(json_value, ignore_extras, true);
        setNumbers(convert_classy);
      }


    private void  fromJSONPhrasing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePhrasingJSON convert_classy = TypePhrasingJSON.from_json(json_value, ignore_extras, true);
        setPhrasing(convert_classy);
      }


    private void  fromJSONDeletions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDeletionsJSON convert_classy = TypeDeletionsJSON.from_json(json_value, ignore_extras, true);
        setDeletions(convert_classy);
      }


    public MatchingMutationsJSON()
      {
        flagHasPunctuation = false;
        flagHasSpelling = false;
        flagHasSynonyms = false;
        flagHasNumbers = false;
        flagHasPhrasing = false;
        flagHasDeletions = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPunctuation()
      {
        return flagHasPunctuation;
      }

    public TypePunctuationJSON   getPunctuation()
      {
        Debug.Assert(flagHasPunctuation);
        return storePunctuation;
      }

    public bool  hasSpelling()
      {
        return flagHasSpelling;
      }

    public TypeSpellingJSON   getSpelling()
      {
        Debug.Assert(flagHasSpelling);
        return storeSpelling;
      }

    public bool  hasSynonyms()
      {
        return flagHasSynonyms;
      }

    public TypeSynonymsJSON   getSynonyms()
      {
        Debug.Assert(flagHasSynonyms);
        return storeSynonyms;
      }

    public bool  hasNumbers()
      {
        return flagHasNumbers;
      }

    public TypeNumbersJSON   getNumbers()
      {
        Debug.Assert(flagHasNumbers);
        return storeNumbers;
      }

    public bool  hasPhrasing()
      {
        return flagHasPhrasing;
      }

    public TypePhrasingJSON   getPhrasing()
      {
        Debug.Assert(flagHasPhrasing);
        return storePhrasing;
      }

    public bool  hasDeletions()
      {
        return flagHasDeletions;
      }

    public TypeDeletionsJSON   getDeletions()
      {
        Debug.Assert(flagHasDeletions);
        return storeDeletions;
      }


    public virtual int extraMatchingMutationsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMatchingMutationsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMatchingMutationsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMatchingMutationsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPunctuation(TypePunctuationJSON  new_value)
      {
        if (flagHasPunctuation)
          {
          }
        flagHasPunctuation = true;
        storePunctuation = new_value;
      }
    public void unsetPunctuation()
      {
        if (flagHasPunctuation)
          {
          }
        flagHasPunctuation = false;
      }
    public void setSpelling(TypeSpellingJSON  new_value)
      {
        if (flagHasSpelling)
          {
          }
        flagHasSpelling = true;
        storeSpelling = new_value;
      }
    public void unsetSpelling()
      {
        if (flagHasSpelling)
          {
          }
        flagHasSpelling = false;
      }
    public void setSynonyms(TypeSynonymsJSON  new_value)
      {
        if (flagHasSynonyms)
          {
          }
        flagHasSynonyms = true;
        storeSynonyms = new_value;
      }
    public void unsetSynonyms()
      {
        if (flagHasSynonyms)
          {
          }
        flagHasSynonyms = false;
      }
    public void setNumbers(TypeNumbersJSON  new_value)
      {
        if (flagHasNumbers)
          {
          }
        flagHasNumbers = true;
        storeNumbers = new_value;
      }
    public void unsetNumbers()
      {
        if (flagHasNumbers)
          {
          }
        flagHasNumbers = false;
      }
    public void setPhrasing(TypePhrasingJSON  new_value)
      {
        if (flagHasPhrasing)
          {
          }
        flagHasPhrasing = true;
        storePhrasing = new_value;
      }
    public void unsetPhrasing()
      {
        if (flagHasPhrasing)
          {
          }
        flagHasPhrasing = false;
      }
    public void setDeletions(TypeDeletionsJSON  new_value)
      {
        if (flagHasDeletions)
          {
          }
        flagHasDeletions = true;
        storeDeletions = new_value;
      }
    public void unsetDeletions()
      {
        if (flagHasDeletions)
          {
          }
        flagHasDeletions = false;
      }

    public virtual void extraMatchingMutationsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMatchingMutationsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMatchingMutationsLookup(key);
        if (old_field == null)
          {
            extraMatchingMutationsAppendPair(key, new_component);
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
        if (flagHasPunctuation)
          {
            handler.start_pair("Punctuation");
            if (partial_allowed)
                storePunctuation.write_partial_as_json(handler);
            else
                storePunctuation.write_as_json(handler);
          }
        if (flagHasSpelling)
          {
            handler.start_pair("Spelling");
            if (partial_allowed)
                storeSpelling.write_partial_as_json(handler);
            else
                storeSpelling.write_as_json(handler);
          }
        if (flagHasSynonyms)
          {
            handler.start_pair("Synonyms");
            if (partial_allowed)
                storeSynonyms.write_partial_as_json(handler);
            else
                storeSynonyms.write_as_json(handler);
          }
        if (flagHasNumbers)
          {
            handler.start_pair("Numbers");
            if (partial_allowed)
                storeNumbers.write_partial_as_json(handler);
            else
                storeNumbers.write_as_json(handler);
          }
        if (flagHasPhrasing)
          {
            handler.start_pair("Phrasing");
            if (partial_allowed)
                storePhrasing.write_partial_as_json(handler);
            else
                storePhrasing.write_as_json(handler);
          }
        if (flagHasDeletions)
          {
            handler.start_pair("Deletions");
            if (partial_allowed)
                storeDeletions.write_partial_as_json(handler);
            else
                storeDeletions.write_as_json(handler);
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

    public static MatchingMutationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MatchingMutationsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MatchingMutations", ignore_extras);
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
    public static MatchingMutationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MatchingMutationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MatchingMutationsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MatchingMutations", ignore_extras);
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
    public static MatchingMutationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MatchingMutationsJSON from_text(string text, bool ignore_extras)
      {
        MatchingMutationsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MatchingMutations", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MatchingMutationsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MatchingMutationsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MatchingMutationsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MatchingMutations", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypePunctuationJSON.HoldingGenerator fieldGeneratorPunctuation;
        private TypeSpellingJSON.HoldingGenerator fieldGeneratorSpelling;
        private TypeSynonymsJSON.HoldingGenerator fieldGeneratorSynonyms;
        private TypeNumbersJSON.HoldingGenerator fieldGeneratorNumbers;
        private TypePhrasingJSON.HoldingGenerator fieldGeneratorPhrasing;
        private TypeDeletionsJSON.HoldingGenerator fieldGeneratorDeletions;
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
            MatchingMutationsJSON result = new MatchingMutationsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMatchingMutationsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MatchingMutationsJSON result)
          {
            if (fieldGeneratorPunctuation.have_value)
              {
                result.setPunctuation(fieldGeneratorPunctuation.value);
                fieldGeneratorPunctuation.have_value = false;
              }
            if (fieldGeneratorSpelling.have_value)
              {
                result.setSpelling(fieldGeneratorSpelling.value);
                fieldGeneratorSpelling.have_value = false;
              }
            if (fieldGeneratorSynonyms.have_value)
              {
                result.setSynonyms(fieldGeneratorSynonyms.value);
                fieldGeneratorSynonyms.have_value = false;
              }
            if (fieldGeneratorNumbers.have_value)
              {
                result.setNumbers(fieldGeneratorNumbers.value);
                fieldGeneratorNumbers.have_value = false;
              }
            if (fieldGeneratorPhrasing.have_value)
              {
                result.setPhrasing(fieldGeneratorPhrasing.value);
                fieldGeneratorPhrasing.have_value = false;
              }
            if (fieldGeneratorDeletions.have_value)
              {
                result.setDeletions(fieldGeneratorDeletions.value);
                fieldGeneratorDeletions.have_value = false;
              }
          }
        protected abstract void handle_result(MatchingMutationsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "eletions", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDeletions;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umbers", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorNumbers;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "rasing", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPhrasing;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "nctuation", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorPunctuation;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'p':
                            if ((String.Compare(field_name, 2, "elling", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorSpelling;
                            break;
                        case 'y':
                            if ((String.Compare(field_name, 2, "nonyms", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorSynonyms;
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
            fieldGeneratorPunctuation = new TypePunctuationJSON.HoldingGenerator("field \"Punctuation\" of the MatchingMutations class", ignore_extras);
            fieldGeneratorSpelling = new TypeSpellingJSON.HoldingGenerator("field \"Spelling\" of the MatchingMutations class", ignore_extras);
            fieldGeneratorSynonyms = new TypeSynonymsJSON.HoldingGenerator("field \"Synonyms\" of the MatchingMutations class", ignore_extras);
            fieldGeneratorNumbers = new TypeNumbersJSON.HoldingGenerator("field \"Numbers\" of the MatchingMutations class", ignore_extras);
            fieldGeneratorPhrasing = new TypePhrasingJSON.HoldingGenerator("field \"Phrasing\" of the MatchingMutations class", ignore_extras);
            fieldGeneratorDeletions = new TypeDeletionsJSON.HoldingGenerator("field \"Deletions\" of the MatchingMutations class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MatchingMutations class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPunctuation = new TypePunctuationJSON.HoldingGenerator("field \"Punctuation\" of the MatchingMutations class", false);
            fieldGeneratorSpelling = new TypeSpellingJSON.HoldingGenerator("field \"Spelling\" of the MatchingMutations class", false);
            fieldGeneratorSynonyms = new TypeSynonymsJSON.HoldingGenerator("field \"Synonyms\" of the MatchingMutations class", false);
            fieldGeneratorNumbers = new TypeNumbersJSON.HoldingGenerator("field \"Numbers\" of the MatchingMutations class", false);
            fieldGeneratorPhrasing = new TypePhrasingJSON.HoldingGenerator("field \"Phrasing\" of the MatchingMutations class", false);
            fieldGeneratorDeletions = new TypeDeletionsJSON.HoldingGenerator("field \"Deletions\" of the MatchingMutations class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MatchingMutations class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPunctuation.reset();
            fieldGeneratorSpelling.reset();
            fieldGeneratorSynonyms.reset();
            fieldGeneratorNumbers.reset();
            fieldGeneratorPhrasing.reset();
            fieldGeneratorDeletions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPunctuation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSpelling.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSynonyms.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNumbers.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPhrasing.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDeletions.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPunctuation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSpelling.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSynonyms.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNumbers.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPhrasing.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDeletions.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MatchingMutationsJSON  result)
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
        public MatchingMutationsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MatchingMutationsJSON  result)
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
    protected virtual void handle_result(List<MatchingMutationsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MatchingMutationsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MatchingMutationsJSON>();
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
    public List<MatchingMutationsJSON> value;
  };
  };
