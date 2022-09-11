/* file "PersonAttributeSiblingsParametersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PersonAttributeSiblingsParametersJSON : JSONBase
  {
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

    public class TypeRelativeAgeJSON : JSONBase
      {
        public enum TypeDescriptorKnownValues
          {
            Descriptor_Younger,
            Descriptor_Older,
            Descriptor_Twin,
            Descriptor__none
          };
        public struct TypeDescriptor
          {
            public bool in_known_list;
            public string string_value;
            public TypeDescriptorKnownValues list_value;
          };

        public static TypeDescriptorKnownValues  stringToDescriptor(string chars)
          {
            switch (chars[0])
              {
                case 'O':
                    if ((String.Compare(chars, 1, "lder", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeDescriptorKnownValues.Descriptor_Older;
                    break;
                case 'T':
                    if ((String.Compare(chars, 1, "win", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeDescriptorKnownValues.Descriptor_Twin;
                    break;
                case 'Y':
                    if ((String.Compare(chars, 1, "ounger", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeDescriptorKnownValues.Descriptor_Younger;
                    break;
                default:
                    break;
              }
            return TypeDescriptorKnownValues.Descriptor__none;
          }

        public static string  stringFromDescriptor(TypeDescriptorKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeDescriptorKnownValues.Descriptor_Younger:
                    return "Younger";
                case TypeDescriptorKnownValues.Descriptor_Older:
                    return "Older";
                case TypeDescriptorKnownValues.Descriptor_Twin:
                    return "Twin";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasDescriptor;
        private TypeDescriptor storeDescriptor;
        private bool flagHasIsSuperlative;
        private bool storeIsSuperlative;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONDescriptor(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Descriptor of TypeRelativeAgeJSON is not a string.");
            TypeDescriptor the_open_enum = new TypeDescriptor();
            switch (json_string.getData()[0])
              {
                case 'O':
                    if ((String.Compare(json_string.getData(), 1, "lder", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDescriptorKnownValues.Descriptor_Older;
                            goto open_enum_is_done;
                          }
                    break;
                case 'T':
                    if ((String.Compare(json_string.getData(), 1, "win", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDescriptorKnownValues.Descriptor_Twin;
                            goto open_enum_is_done;
                          }
                    break;
                case 'Y':
                    if ((String.Compare(json_string.getData(), 1, "ounger", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDescriptorKnownValues.Descriptor_Younger;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setDescriptor(the_open_enum);
          }


        private void  fromJSONIsSuperlative(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field IsSuperlative of TypeRelativeAgeJSON is not true for false.");
                  }
              }
            setIsSuperlative(the_bool);
          }


        public TypeRelativeAgeJSON()
          {
            flagHasDescriptor = false;
            flagHasIsSuperlative = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasDescriptor()
          {
            return flagHasDescriptor;
          }

        public TypeDescriptor  getDescriptor()
          {
            Debug.Assert(flagHasDescriptor);
            return storeDescriptor;
          }

        public string  getDescriptorAsString()
          {
            TypeDescriptor result = getDescriptor();
            if (result.in_known_list)
                return stringFromDescriptor(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasIsSuperlative()
          {
            return flagHasIsSuperlative;
          }

        public bool  getIsSuperlative()
          {
            Debug.Assert(flagHasIsSuperlative);
            return storeIsSuperlative;
          }


        public virtual int extraTypeRelativeAgeComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeRelativeAgeComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeRelativeAgeComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeRelativeAgeLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setDescriptor(TypeDescriptor new_value)
          {
            flagHasDescriptor = true;
            storeDescriptor = new_value;
          }
        public void setDescriptor(string chars)
          {
            TypeDescriptorKnownValues known = stringToDescriptor(chars);
            TypeDescriptor new_value = new TypeDescriptor();
            if (known == TypeDescriptorKnownValues.Descriptor__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setDescriptor(new_value);
          }
        public void setDescriptor(TypeDescriptorKnownValues new_value)
          {
            TypeDescriptor new_full_value = new TypeDescriptor();
            Debug.Assert(new_value != TypeDescriptorKnownValues.Descriptor__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setDescriptor(new_full_value);
          }
        public void unsetDescriptor()
          {
            flagHasDescriptor = false;
          }
        public void setIsSuperlative(bool new_value)
          {
            flagHasIsSuperlative = true;
            storeIsSuperlative = new_value;
          }
        public void unsetIsSuperlative()
          {
            flagHasIsSuperlative = false;
          }

        public virtual void extraTypeRelativeAgeAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeRelativeAgeSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeRelativeAgeLookup(key);
            if (old_field == null)
              {
                extraTypeRelativeAgeAppendPair(key, new_component);
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
            if (flagHasDescriptor)
              {
                handler.start_pair("Descriptor");
                if (storeDescriptor.in_known_list)
                  {
                    switch (storeDescriptor.list_value)
                      {
                        case TypeDescriptorKnownValues.Descriptor_Younger:
                            handler.string_value("Younger");
                            break;
                        case TypeDescriptorKnownValues.Descriptor_Older:
                            handler.string_value("Older");
                            break;
                        case TypeDescriptorKnownValues.Descriptor_Twin:
                            handler.string_value("Twin");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeDescriptor.string_value);
                  }
              }
            if (flagHasIsSuperlative)
              {
                handler.start_pair("IsSuperlative");
                handler.boolean_value(storeIsSuperlative);
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

        public static TypeRelativeAgeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRelativeAgeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRelativeAge", ignore_extras);
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
        public static TypeRelativeAgeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRelativeAgeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRelativeAgeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRelativeAge", ignore_extras);
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
        public static TypeRelativeAgeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRelativeAgeJSON from_text(string text, bool ignore_extras)
          {
            TypeRelativeAgeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRelativeAge", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeRelativeAgeJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeRelativeAgeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeRelativeAgeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRelativeAge", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorDescriptor : JSONStringGenerator
              {
                protected FieldGeneratorDescriptor(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorDescriptor()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeDescriptorKnownValues known = stringToDescriptor(result);
                    TypeDescriptor new_value = new TypeDescriptor();
                    if (known == TypeDescriptorKnownValues.Descriptor__none)
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
                protected abstract void handle_result(TypeDescriptor result);
              };
        private class FieldHoldingGeneratorDescriptor : FieldGeneratorDescriptor
      {
        protected override void handle_result(TypeDescriptor result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorDescriptor(String what)
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
        public TypeDescriptor value;
      };
        private class FieldHoldingArrayGeneratorDescriptor : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorDescriptor
          {
            private FieldHoldingArrayGeneratorDescriptor top;

            protected override void handle_result(TypeDescriptor result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorDescriptor init_top)
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
        protected virtual void handle_result(List<TypeDescriptor> result)
          {
          }

        public FieldHoldingArrayGeneratorDescriptor(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeDescriptor>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorDescriptor()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeDescriptor>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeDescriptor> value;
      };
            private FieldHoldingGeneratorDescriptor fieldGeneratorDescriptor;
            private JSONHoldingBooleanGenerator fieldGeneratorIsSuperlative;
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
                TypeRelativeAgeJSON result = new TypeRelativeAgeJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeRelativeAgeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeRelativeAgeJSON result)
              {
                if (fieldGeneratorDescriptor.have_value)
                  {
                    result.setDescriptor(fieldGeneratorDescriptor.value);
                    fieldGeneratorDescriptor.have_value = false;
                  }
                if (fieldGeneratorIsSuperlative.have_value)
                  {
                    result.setIsSuperlative(fieldGeneratorIsSuperlative.value);
                    fieldGeneratorIsSuperlative.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeRelativeAgeJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "escriptor", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorDescriptor;
                        break;
                    case 'I':
                        if ((String.Compare(field_name, 1, "sSuperlative", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorIsSuperlative;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorDescriptor = new FieldHoldingGeneratorDescriptor("field \"Descriptor\" of the TypeRelativeAge class");
                fieldGeneratorIsSuperlative = new JSONHoldingBooleanGenerator("field \"IsSuperlative\" of the TypeRelativeAge class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeRelativeAge class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorDescriptor = new FieldHoldingGeneratorDescriptor("field \"Descriptor\" of the TypeRelativeAge class");
                fieldGeneratorIsSuperlative = new JSONHoldingBooleanGenerator("field \"IsSuperlative\" of the TypeRelativeAge class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeRelativeAge class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorDescriptor.reset();
                fieldGeneratorIsSuperlative.reset();
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
            protected override void handle_result(TypeRelativeAgeJSON  result)
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
            public TypeRelativeAgeJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeRelativeAgeJSON  result)
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
        protected virtual void handle_result(List<TypeRelativeAgeJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeRelativeAgeJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeRelativeAgeJSON>();
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
        public List<TypeRelativeAgeJSON> value;
      };
      };
    private bool flagHasSex;
    private TypeSex storeSex;
    private bool flagHasRelativeAge;
    private TypeRelativeAgeJSON  storeRelativeAge;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Sex of PersonAttributeSiblingsParametersJSON is not a string.");
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
        throw new Exception("The value for field Sex of PersonAttributeSiblingsParametersJSON is not one of the legal strings.");
      enum_is_done:;
        setSex(the_enum);
      }


    private void  fromJSONRelativeAge(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeRelativeAgeJSON convert_classy = TypeRelativeAgeJSON.from_json(json_value, ignore_extras, true);
        setRelativeAge(convert_classy);
      }


    public PersonAttributeSiblingsParametersJSON()
      {
        flagHasSex = false;
        flagHasRelativeAge = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasRelativeAge()
      {
        return flagHasRelativeAge;
      }

    public TypeRelativeAgeJSON   getRelativeAge()
      {
        Debug.Assert(flagHasRelativeAge);
        return storeRelativeAge;
      }


    public virtual int extraPersonAttributeSiblingsParametersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPersonAttributeSiblingsParametersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPersonAttributeSiblingsParametersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPersonAttributeSiblingsParametersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setRelativeAge(TypeRelativeAgeJSON  new_value)
      {
        if (flagHasRelativeAge)
          {
          }
        flagHasRelativeAge = true;
        storeRelativeAge = new_value;
      }
    public void unsetRelativeAge()
      {
        if (flagHasRelativeAge)
          {
          }
        flagHasRelativeAge = false;
      }

    public virtual void extraPersonAttributeSiblingsParametersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPersonAttributeSiblingsParametersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPersonAttributeSiblingsParametersLookup(key);
        if (old_field == null)
          {
            extraPersonAttributeSiblingsParametersAppendPair(key, new_component);
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
        if (flagHasRelativeAge)
          {
            handler.start_pair("RelativeAge");
            if (partial_allowed)
                storeRelativeAge.write_partial_as_json(handler);
            else
                storeRelativeAge.write_as_json(handler);
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

    public static PersonAttributeSiblingsParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeSiblingsParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSiblingsParameters", ignore_extras);
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
    public static PersonAttributeSiblingsParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PersonAttributeSiblingsParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonAttributeSiblingsParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSiblingsParameters", ignore_extras);
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
    public static PersonAttributeSiblingsParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PersonAttributeSiblingsParametersJSON from_text(string text, bool ignore_extras)
      {
        PersonAttributeSiblingsParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSiblingsParameters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonAttributeSiblingsParametersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PersonAttributeSiblingsParametersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonAttributeSiblingsParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonAttributeSiblingsParameters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
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
        private TypeRelativeAgeJSON.HoldingGenerator fieldGeneratorRelativeAge;
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
            PersonAttributeSiblingsParametersJSON result = new PersonAttributeSiblingsParametersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonAttributeSiblingsParametersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(PersonAttributeSiblingsParametersJSON result)
          {
            if (fieldGeneratorSex.have_value)
              {
                result.setSex(fieldGeneratorSex.value);
                fieldGeneratorSex.have_value = false;
              }
            if (fieldGeneratorRelativeAge.have_value)
              {
                result.setRelativeAge(fieldGeneratorRelativeAge.value);
                fieldGeneratorRelativeAge.have_value = false;
              }
          }
        protected abstract void handle_result(PersonAttributeSiblingsParametersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'R':
                    if ((String.Compare(field_name, 1, "elativeAge", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorRelativeAge;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ex", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorSex;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSex = new FieldHoldingGeneratorSex("field \"Sex\" of the PersonAttributeSiblingsParameters class");
            fieldGeneratorRelativeAge = new TypeRelativeAgeJSON.HoldingGenerator("field \"RelativeAge\" of the PersonAttributeSiblingsParameters class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PersonAttributeSiblingsParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSex = new FieldHoldingGeneratorSex("field \"Sex\" of the PersonAttributeSiblingsParameters class");
            fieldGeneratorRelativeAge = new TypeRelativeAgeJSON.HoldingGenerator("field \"RelativeAge\" of the PersonAttributeSiblingsParameters class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PersonAttributeSiblingsParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSex.reset();
            fieldGeneratorRelativeAge.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRelativeAge.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRelativeAge.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonAttributeSiblingsParametersJSON  result)
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
        public PersonAttributeSiblingsParametersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonAttributeSiblingsParametersJSON  result)
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
    protected virtual void handle_result(List<PersonAttributeSiblingsParametersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonAttributeSiblingsParametersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonAttributeSiblingsParametersJSON>();
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
    public List<PersonAttributeSiblingsParametersJSON> value;
  };
  };
