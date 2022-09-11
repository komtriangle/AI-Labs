/* file "HintsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HintsJSON : JSONBase
  {
    public class TypeSpokenJSON : JSONBase
      {
        public enum TypePriority
          {
            Priority_Low,
            Priority_Medium,
            Priority_High
          };

        public static TypePriority  stringToPriority(string chars)
          {
            switch (chars[0])
              {
                case 'H':
                    if ((String.Compare(chars, 1, "igh", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypePriority.Priority_High;
                    break;
                case 'L':
                    if ((String.Compare(chars, 1, "ow", 0, 2, false) == 0) && (chars.Length == 3))
                        return TypePriority.Priority_Low;
                    break;
                case 'M':
                    if ((String.Compare(chars, 1, "edium", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypePriority.Priority_Medium;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Priority' is not one of the legal values.");
          }

        public static string  stringFromPriority(TypePriority the_enum)
          {
            switch (the_enum)
              {
                case TypePriority.Priority_Low:
                    return "Low";
                case TypePriority.Priority_Medium:
                    return "Medium";
                case TypePriority.Priority_High:
                    return "High";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasText;
        private string storeText;
        private bool flagHasPriority;
        private TypePriority storePriority;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONText(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Text of TypeSpokenJSON is not a string.");
            setText(json_string.getData());
          }


        private void  fromJSONPriority(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Priority of TypeSpokenJSON is not a string.");
            TypePriority the_enum;
            switch (json_string.getData()[0])
              {
                case 'H':
                    if ((String.Compare(json_string.getData(), 1, "igh", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypePriority.Priority_High;
                            goto enum_is_done;
                          }
                    break;
                case 'L':
                    if ((String.Compare(json_string.getData(), 1, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                          {
                            the_enum = TypePriority.Priority_Low;
                            goto enum_is_done;
                          }
                    break;
                case 'M':
                    if ((String.Compare(json_string.getData(), 1, "edium", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypePriority.Priority_Medium;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Priority of TypeSpokenJSON is not one of the legal strings.");
          enum_is_done:;
            setPriority(the_enum);
          }


        public TypeSpokenJSON()
          {
            flagHasText = false;
            flagHasPriority = false;
            storePriority = TypePriority.Priority_Medium;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasText()
          {
            return flagHasText;
          }

        public string  getText()
          {
            Debug.Assert(flagHasText);
            return storeText;
          }

        public bool  hasPriority()
          {
            return flagHasPriority;
          }

        public TypePriority  getPriority()
          {
            return storePriority;
          }

        public string  getPriorityAsString()
          {
            return stringFromPriority(getPriority());
          }


        public virtual int extraTypeSpokenComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSpokenComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSpokenComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSpokenLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setText(string new_value)
          {
            flagHasText = true;
            storeText = new_value;
          }
        public void unsetText()
          {
            flagHasText = false;
          }
        public void setPriority(TypePriority new_value)
          {
            flagHasPriority = true;
            storePriority = new_value;
          }
        public void setPriority(string chars)
          {
            setPriority(stringToPriority(chars));
          }
        public void unsetPriority()
          {
            flagHasPriority = false;
          }

        public virtual void extraTypeSpokenAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSpokenSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSpokenLookup(key);
            if (old_field == null)
              {
                extraTypeSpokenAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasText);
            if (flagHasText)
              {
                handler.start_pair("Text");
                handler.string_value(storeText);
              }
            if (flagHasPriority)
              {
                handler.start_pair("Priority");
                switch (storePriority)
                  {
                    case TypePriority.Priority_Low:
                        handler.string_value("Low");
                        break;
                    case TypePriority.Priority_Medium:
                        handler.string_value("Medium");
                        break;
                    case TypePriority.Priority_High:
                        handler.string_value("High");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
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
            if (!(hasText()))
              {
                return "When parsing the object for %what%, the \"Text\" field was missing.";
              }
            return null;
          }

        public static TypeSpokenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSpokenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSpoken", ignore_extras);
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
        public static TypeSpokenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSpokenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSpokenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSpoken", ignore_extras);
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
        public static TypeSpokenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSpokenJSON from_text(string text, bool ignore_extras)
          {
            TypeSpokenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSpoken", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSpokenJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSpokenJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSpokenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSpoken", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorText;
        private abstract class FieldGeneratorPriority : JSONStringGenerator
              {
                protected FieldGeneratorPriority(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorPriority()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToPriority(result));
                  }
                protected abstract void handle_result(TypePriority result);
              };
        private class FieldHoldingGeneratorPriority : FieldGeneratorPriority
      {
        protected override void handle_result(TypePriority result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorPriority(String what)
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
        public TypePriority value;
      };
        private class FieldHoldingArrayGeneratorPriority : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorPriority
          {
            private FieldHoldingArrayGeneratorPriority top;

            protected override void handle_result(TypePriority result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorPriority init_top)
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
        protected virtual void handle_result(List<TypePriority> result)
          {
          }

        public FieldHoldingArrayGeneratorPriority(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypePriority>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorPriority()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypePriority>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypePriority> value;
      };
            private FieldHoldingGeneratorPriority fieldGeneratorPriority;
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
                TypeSpokenJSON result = new TypeSpokenJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSpokenAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSpokenJSON result)
              {
                if (fieldGeneratorText.have_value)
                  {
                    result.setText(fieldGeneratorText.value);
                    fieldGeneratorText.have_value = false;
                  }
                else if ((!(result.hasText())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Text\" field was missing.");
                  }
                if (fieldGeneratorPriority.have_value)
                  {
                    result.setPriority(fieldGeneratorPriority.value);
                    fieldGeneratorPriority.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeSpokenJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'P':
                        if ((String.Compare(field_name, 1, "riority", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorPriority;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ext", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorText;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeSpoken class");
                fieldGeneratorPriority = new FieldHoldingGeneratorPriority("field \"Priority\" of the TypeSpoken class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSpoken class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeSpoken class");
                fieldGeneratorPriority = new FieldHoldingGeneratorPriority("field \"Priority\" of the TypeSpoken class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSpoken class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorText.reset();
                fieldGeneratorPriority.reset();
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
            protected override void handle_result(TypeSpokenJSON  result)
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
            public TypeSpokenJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSpokenJSON  result)
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
        protected virtual void handle_result(List<TypeSpokenJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSpokenJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSpokenJSON>();
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
        public List<TypeSpokenJSON> value;
      };
      };
    public class TypeWrittenJSON : JSONBase
      {
        public class TypeHintsJSON : JSONBase
          {
            public enum TypePriority
              {
                Priority_Low,
                Priority_Medium,
                Priority_High
              };

            public static TypePriority  stringToPriority(string chars)
              {
                switch (chars[0])
                  {
                    case 'H':
                        if ((String.Compare(chars, 1, "igh", 0, 3, false) == 0) && (chars.Length == 4))
                            return TypePriority.Priority_High;
                        break;
                    case 'L':
                        if ((String.Compare(chars, 1, "ow", 0, 2, false) == 0) && (chars.Length == 3))
                            return TypePriority.Priority_Low;
                        break;
                    case 'M':
                        if ((String.Compare(chars, 1, "edium", 0, 5, false) == 0) && (chars.Length == 6))
                            return TypePriority.Priority_Medium;
                        break;
                    default:
                        break;
                  }
                throw new Exception("The value for field `Priority' is not one of the legal values.");
              }

            public static string  stringFromPriority(TypePriority the_enum)
              {
                switch (the_enum)
                  {
                    case TypePriority.Priority_Low:
                        return "Low";
                    case TypePriority.Priority_Medium:
                        return "Medium";
                    case TypePriority.Priority_High:
                        return "High";
                    default:
                        Debug.Assert(false);
                        return null;
                  }
              }

            private bool flagHasText;
            private string storeText;
            private bool flagHasPriority;
            private TypePriority storePriority;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONText(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Text of TypeHintsJSON is not a string.");
                setText(json_string.getData());
              }


            private void  fromJSONPriority(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Priority of TypeHintsJSON is not a string.");
                TypePriority the_enum;
                switch (json_string.getData()[0])
                  {
                    case 'H':
                        if ((String.Compare(json_string.getData(), 1, "igh", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_enum = TypePriority.Priority_High;
                                goto enum_is_done;
                              }
                        break;
                    case 'L':
                        if ((String.Compare(json_string.getData(), 1, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_enum = TypePriority.Priority_Low;
                                goto enum_is_done;
                              }
                        break;
                    case 'M':
                        if ((String.Compare(json_string.getData(), 1, "edium", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_enum = TypePriority.Priority_Medium;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                throw new Exception("The value for field Priority of TypeHintsJSON is not one of the legal strings.");
              enum_is_done:;
                setPriority(the_enum);
              }


            public TypeHintsJSON()
              {
                flagHasText = false;
                flagHasPriority = false;
                storePriority = TypePriority.Priority_Medium;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasText()
              {
                return flagHasText;
              }

            public string  getText()
              {
                Debug.Assert(flagHasText);
                return storeText;
              }

            public bool  hasPriority()
              {
                return flagHasPriority;
              }

            public TypePriority  getPriority()
              {
                return storePriority;
              }

            public string  getPriorityAsString()
              {
                return stringFromPriority(getPriority());
              }


            public virtual int extraTypeHintsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeHintsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeHintsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeHintsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setText(string new_value)
              {
                flagHasText = true;
                storeText = new_value;
              }
            public void unsetText()
              {
                flagHasText = false;
              }
            public void setPriority(TypePriority new_value)
              {
                flagHasPriority = true;
                storePriority = new_value;
              }
            public void setPriority(string chars)
              {
                setPriority(stringToPriority(chars));
              }
            public void unsetPriority()
              {
                flagHasPriority = false;
              }

            public virtual void extraTypeHintsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeHintsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeHintsLookup(key);
                if (old_field == null)
                  {
                    extraTypeHintsAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasText);
                if (flagHasText)
                  {
                    handler.start_pair("Text");
                    handler.string_value(storeText);
                  }
                if (flagHasPriority)
                  {
                    handler.start_pair("Priority");
                    switch (storePriority)
                      {
                        case TypePriority.Priority_Low:
                            handler.string_value("Low");
                            break;
                        case TypePriority.Priority_Medium:
                            handler.string_value("Medium");
                            break;
                        case TypePriority.Priority_High:
                            handler.string_value("High");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
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
                if (!(hasText()))
                  {
                    return "When parsing the object for %what%, the \"Text\" field was missing.";
                  }
                return null;
              }

            public static TypeHintsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeHintsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeHints", ignore_extras);
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
            public static TypeHintsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeHintsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeHintsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeHints", ignore_extras);
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
            public static TypeHintsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeHintsJSON from_text(string text, bool ignore_extras)
              {
                TypeHintsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeHints", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeHintsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeHintsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeHintsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeHints", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorText;
            private abstract class FieldGeneratorPriority : JSONStringGenerator
                  {
                    protected FieldGeneratorPriority(string what)
                      {
                        set_what(what);
                      }
                    protected FieldGeneratorPriority()
                      {
                      }
                    protected override void handle_result(string result)
                      {
                        handle_result(stringToPriority(result));
                      }
                    protected abstract void handle_result(TypePriority result);
                  };
            private class FieldHoldingGeneratorPriority : FieldGeneratorPriority
          {
            protected override void handle_result(TypePriority result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = result;
              }

            public FieldHoldingGeneratorPriority(String what)
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
            public TypePriority value;
          };
            private class FieldHoldingArrayGeneratorPriority : JSONArrayGenerator
          {
            protected class ElementHandler : FieldGeneratorPriority
              {
                private FieldHoldingArrayGeneratorPriority top;

                protected override void handle_result(TypePriority result)
                  {
                    top.value.Add(result);
                  }
                protected override string get_what()
                  {
                    return "element " + top.value.Count + " of " + top.get_what();
                  }

                public ElementHandler(FieldHoldingArrayGeneratorPriority init_top)
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
            protected virtual void handle_result(List<TypePriority> result)
              {
              }

            public FieldHoldingArrayGeneratorPriority(string what)
              {
                element_handler = new ElementHandler(this);
                have_value = false;
                value = new List<TypePriority>();
                base.set_what(what);
              }
            public FieldHoldingArrayGeneratorPriority()
              {
                element_handler = new ElementHandler(this);
                have_value = false;
                value = new List<TypePriority>();
              }

            public override void reset()
              {
                element_handler.reset();
                have_value = false;
                value.Clear();
                base.reset();
              }

            public bool have_value;
            public List<TypePriority> value;
          };
                private FieldHoldingGeneratorPriority fieldGeneratorPriority;
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
                    TypeHintsJSON result = new TypeHintsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeHintsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeHintsJSON result)
                  {
                    if (fieldGeneratorText.have_value)
                      {
                        result.setText(fieldGeneratorText.value);
                        fieldGeneratorText.have_value = false;
                      }
                    else if ((!(result.hasText())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Text\" field was missing.");
                      }
                    if (fieldGeneratorPriority.have_value)
                      {
                        result.setPriority(fieldGeneratorPriority.value);
                        fieldGeneratorPriority.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeHintsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'P':
                            if ((String.Compare(field_name, 1, "riority", 0, 7, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPriority;
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 1, "ext", 0, 3, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorText;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeHints class");
                    fieldGeneratorPriority = new FieldHoldingGeneratorPriority("field \"Priority\" of the TypeHints class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeHints class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeHints class");
                    fieldGeneratorPriority = new FieldHoldingGeneratorPriority("field \"Priority\" of the TypeHints class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeHints class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorText.reset();
                    fieldGeneratorPriority.reset();
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
                protected override void handle_result(TypeHintsJSON  result)
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
                public TypeHintsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeHintsJSON  result)
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
            protected virtual void handle_result(List<TypeHintsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeHintsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeHintsJSON>();
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
            public List<TypeHintsJSON> value;
          };
          };
        private bool flagHasHints;
        private List< TypeHintsJSON  > storeHints;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONHints(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Hints of TypeWrittenJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field Hints of TypeWrittenJSON has too few elements.");
            List< TypeHintsJSON  > vector_Hints1 = new List< TypeHintsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeHintsJSON convert_classy = TypeHintsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Hints1.Add(convert_classy);
              }
            Debug.Assert(vector_Hints1.Count >= 1);
            initHints();
            for (int num1 = 0; num1 < vector_Hints1.Count; ++num1)
                appendHints(vector_Hints1[num1]);
            for (int num1 = 0; num1 < vector_Hints1.Count; ++num1)
              {
              }
          }


        public TypeWrittenJSON()
          {
            flagHasHints = false;
            storeHints = new List< TypeHintsJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasHints()
          {
            return flagHasHints;
          }

        public int  countOfHints()
          {
            Debug.Assert(flagHasHints);
            return storeHints.Count;
          }

        public TypeHintsJSON   elementOfHints(int element_num)
          {
            Debug.Assert(flagHasHints);
            return storeHints[element_num];
          }

        public List< TypeHintsJSON  >  getHints()
          {
            Debug.Assert(flagHasHints);
            return storeHints;
          }


        public virtual int extraTypeWrittenComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeWrittenComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeWrittenComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeWrittenLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initHints()
          {
            if (flagHasHints)
              {
                for (int num1 = 0; num1 < storeHints.Count; ++num1)
                  {
                  }
              }
            flagHasHints = true;
            storeHints.Clear();
          }
        public void appendHints(TypeHintsJSON  to_append)
          {
            if (!flagHasHints)
              {
                flagHasHints = true;
                storeHints.Clear();
              }
            Debug.Assert(flagHasHints);
            storeHints.Add(to_append);
          }
        public void unsetHints()
          {
            if (flagHasHints)
              {
                for (int num2 = 0; num2 < storeHints.Count; ++num2)
                  {
                  }
              }
            flagHasHints = false;
            storeHints.Clear();
          }

        public virtual void extraTypeWrittenAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeWrittenSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeWrittenLookup(key);
            if (old_field == null)
              {
                extraTypeWrittenAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasHints);
            if (flagHasHints)
              {
                handler.start_pair("Hints");
                Debug.Assert(storeHints.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeHints.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeHints[num1].write_partial_as_json(handler);
                    else
                        storeHints[num1].write_as_json(handler);
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
            if (!(hasHints()))
              {
                return "When parsing the object for %what%, the \"Hints\" field was missing.";
              }
            return null;
          }

        public static TypeWrittenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWrittenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWritten", ignore_extras);
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
        public static TypeWrittenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWrittenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWrittenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWritten", ignore_extras);
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
        public static TypeWrittenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWrittenJSON from_text(string text, bool ignore_extras)
          {
            TypeWrittenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWritten", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeWrittenJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeWrittenJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeWrittenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWritten", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private TypeHintsJSON.HoldingArrayGenerator fieldGeneratorHints;
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
                TypeWrittenJSON result = new TypeWrittenJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeWrittenAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeWrittenJSON result)
              {
                if (fieldGeneratorHints.have_value)
                  {
                    result.initHints();
                    int count = fieldGeneratorHints.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendHints(fieldGeneratorHints.value[num]);
                      }
                    fieldGeneratorHints.value.Clear();
                    fieldGeneratorHints.have_value = false;
                  }
                else if ((!(result.hasHints())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Hints\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeWrittenJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Hints", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorHints;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorHints = new TypeHintsJSON.HoldingArrayGenerator("field \"Hints\" of the TypeWritten class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeWritten class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorHints = new TypeHintsJSON.HoldingArrayGenerator("field \"Hints\" of the TypeWritten class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeWritten class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorHints.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorHints.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorHints.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeWrittenJSON  result)
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
            public TypeWrittenJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeWrittenJSON  result)
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
        protected virtual void handle_result(List<TypeWrittenJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeWrittenJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeWrittenJSON>();
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
        public List<TypeWrittenJSON> value;
      };
      };
    private bool flagHasSpoken;
    private TypeSpokenJSON  storeSpoken;
    private bool flagHasWritten;
    private TypeWrittenJSON  storeWritten;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSpokenJSON convert_classy = TypeSpokenJSON.from_json(json_value, ignore_extras, true);
        setSpoken(convert_classy);
      }


    private void  fromJSONWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeWrittenJSON convert_classy = TypeWrittenJSON.from_json(json_value, ignore_extras, true);
        setWritten(convert_classy);
      }


    public HintsJSON()
      {
        flagHasSpoken = false;
        flagHasWritten = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSpoken()
      {
        return flagHasSpoken;
      }

    public TypeSpokenJSON   getSpoken()
      {
        Debug.Assert(flagHasSpoken);
        return storeSpoken;
      }

    public bool  hasWritten()
      {
        return flagHasWritten;
      }

    public TypeWrittenJSON   getWritten()
      {
        Debug.Assert(flagHasWritten);
        return storeWritten;
      }


    public virtual int extraHintsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHintsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHintsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHintsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSpoken(TypeSpokenJSON  new_value)
      {
        if (flagHasSpoken)
          {
          }
        flagHasSpoken = true;
        storeSpoken = new_value;
      }
    public void unsetSpoken()
      {
        if (flagHasSpoken)
          {
          }
        flagHasSpoken = false;
      }
    public void setWritten(TypeWrittenJSON  new_value)
      {
        if (flagHasWritten)
          {
          }
        flagHasWritten = true;
        storeWritten = new_value;
      }
    public void unsetWritten()
      {
        if (flagHasWritten)
          {
          }
        flagHasWritten = false;
      }

    public virtual void extraHintsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHintsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHintsLookup(key);
        if (old_field == null)
          {
            extraHintsAppendPair(key, new_component);
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
        if (flagHasSpoken)
          {
            handler.start_pair("Spoken");
            if (partial_allowed)
                storeSpoken.write_partial_as_json(handler);
            else
                storeSpoken.write_as_json(handler);
          }
        if (flagHasWritten)
          {
            handler.start_pair("Written");
            if (partial_allowed)
                storeWritten.write_partial_as_json(handler);
            else
                storeWritten.write_as_json(handler);
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

    public static HintsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HintsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Hints", ignore_extras);
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
    public static HintsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HintsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HintsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Hints", ignore_extras);
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
    public static HintsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HintsJSON from_text(string text, bool ignore_extras)
      {
        HintsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Hints", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HintsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HintsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HintsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Hints", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeSpokenJSON.HoldingGenerator fieldGeneratorSpoken;
        private TypeWrittenJSON.HoldingGenerator fieldGeneratorWritten;
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
            HintsJSON result = new HintsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHintsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HintsJSON result)
          {
            if (fieldGeneratorSpoken.have_value)
              {
                result.setSpoken(fieldGeneratorSpoken.value);
                fieldGeneratorSpoken.have_value = false;
              }
            if (fieldGeneratorWritten.have_value)
              {
                result.setWritten(fieldGeneratorWritten.value);
                fieldGeneratorWritten.have_value = false;
              }
          }
        protected abstract void handle_result(HintsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if ((String.Compare(field_name, 1, "poken", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSpoken;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "ritten", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorWritten;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSpoken = new TypeSpokenJSON.HoldingGenerator("field \"Spoken\" of the Hints class", ignore_extras);
            fieldGeneratorWritten = new TypeWrittenJSON.HoldingGenerator("field \"Written\" of the Hints class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Hints class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpoken = new TypeSpokenJSON.HoldingGenerator("field \"Spoken\" of the Hints class", false);
            fieldGeneratorWritten = new TypeWrittenJSON.HoldingGenerator("field \"Written\" of the Hints class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Hints class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpoken.reset();
            fieldGeneratorWritten.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSpoken.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWritten.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSpoken.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWritten.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HintsJSON  result)
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
        public HintsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HintsJSON  result)
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
    protected virtual void handle_result(List<HintsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HintsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HintsJSON>();
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
    public List<HintsJSON> value;
  };
  };
