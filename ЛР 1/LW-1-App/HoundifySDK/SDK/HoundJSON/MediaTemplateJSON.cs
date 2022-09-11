/* file "MediaTemplateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MediaTemplateJSON : TemplateJSON
  {
    public class TypeImageJSON : JSONBase
      {
        public enum TypeShape
          {
            Shape_Rectangle,
            Shape_Square
          };

        public static TypeShape  stringToShape(string chars)
          {
            switch (chars[0])
              {
                case 'R':
                    if ((String.Compare(chars, 1, "ectangle", 0, 8, false) == 0) && (chars.Length == 9))
                        return TypeShape.Shape_Rectangle;
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "quare", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeShape.Shape_Square;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Shape' is not one of the legal values.");
          }

        public static string  stringFromShape(TypeShape the_enum)
          {
            switch (the_enum)
              {
                case TypeShape.Shape_Rectangle:
                    return "Rectangle";
                case TypeShape.Shape_Square:
                    return "Square";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeSize
          {
            Size_Small,
            Size_Medium
          };

        public static TypeSize  stringToSize(string chars)
          {
            switch (chars[0])
              {
                case 'M':
                    if ((String.Compare(chars, 1, "edium", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeSize.Size_Medium;
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "mall", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeSize.Size_Small;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Size' is not one of the legal values.");
          }

        public static string  stringFromSize(TypeSize the_enum)
          {
            switch (the_enum)
              {
                case TypeSize.Size_Small:
                    return "Small";
                case TypeSize.Size_Medium:
                    return "Medium";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasURL;
        private string storeURL;
        private bool flagHasShape;
        private TypeShape storeShape;
        private bool flagHasSize;
        private TypeSize storeSize;
        private bool flagHasCenterCrop;
        private bool storeCenterCrop;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field URL of TypeImageJSON is not a string.");
            setURL(json_string.getData());
          }


        private void  fromJSONShape(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Shape of TypeImageJSON is not a string.");
            TypeShape the_enum;
            switch (json_string.getData()[0])
              {
                case 'R':
                    if ((String.Compare(json_string.getData(), 1, "ectangle", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_enum = TypeShape.Shape_Rectangle;
                            goto enum_is_done;
                          }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "quare", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypeShape.Shape_Square;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Shape of TypeImageJSON is not one of the legal strings.");
          enum_is_done:;
            setShape(the_enum);
          }


        private void  fromJSONSize(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Size of TypeImageJSON is not a string.");
            TypeSize the_enum;
            switch (json_string.getData()[0])
              {
                case 'M':
                    if ((String.Compare(json_string.getData(), 1, "edium", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypeSize.Size_Medium;
                            goto enum_is_done;
                          }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "mall", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeSize.Size_Small;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Size of TypeImageJSON is not one of the legal strings.");
          enum_is_done:;
            setSize(the_enum);
          }


        private void  fromJSONCenterCrop(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field CenterCrop of TypeImageJSON is not true for false.");
                  }
              }
            setCenterCrop(the_bool);
          }


        public TypeImageJSON()
          {
            flagHasURL = false;
            flagHasShape = false;
            flagHasSize = false;
            flagHasCenterCrop = false;
            storeShape = TypeShape.Shape_Square;
            storeSize = TypeSize.Size_Small;
            storeCenterCrop = true;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasURL()
          {
            return flagHasURL;
          }

        public string  getURL()
          {
            Debug.Assert(flagHasURL);
            return storeURL;
          }

        public bool  hasShape()
          {
            return flagHasShape;
          }

        public TypeShape  getShape()
          {
            return storeShape;
          }

        public string  getShapeAsString()
          {
            return stringFromShape(getShape());
          }

        public bool  hasSize()
          {
            return flagHasSize;
          }

        public TypeSize  getSize()
          {
            return storeSize;
          }

        public string  getSizeAsString()
          {
            return stringFromSize(getSize());
          }

        public bool  hasCenterCrop()
          {
            return flagHasCenterCrop;
          }

        public bool  getCenterCrop()
          {
            return storeCenterCrop;
          }


        public virtual int extraTypeImageComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeImageComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeImageComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeImageLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setURL(string new_value)
          {
            flagHasURL = true;
            storeURL = new_value;
          }
        public void unsetURL()
          {
            flagHasURL = false;
          }
        public void setShape(TypeShape new_value)
          {
            flagHasShape = true;
            storeShape = new_value;
          }
        public void setShape(string chars)
          {
            setShape(stringToShape(chars));
          }
        public void unsetShape()
          {
            flagHasShape = false;
          }
        public void setSize(TypeSize new_value)
          {
            flagHasSize = true;
            storeSize = new_value;
          }
        public void setSize(string chars)
          {
            setSize(stringToSize(chars));
          }
        public void unsetSize()
          {
            flagHasSize = false;
          }
        public void setCenterCrop(bool new_value)
          {
            flagHasCenterCrop = true;
            storeCenterCrop = new_value;
          }
        public void unsetCenterCrop()
          {
            flagHasCenterCrop = false;
          }

        public virtual void extraTypeImageAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeImageSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeImageLookup(key);
            if (old_field == null)
              {
                extraTypeImageAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasURL);
            if (flagHasURL)
              {
                handler.start_pair("URL");
                handler.string_value(storeURL);
              }
            if (flagHasShape)
              {
                handler.start_pair("Shape");
                switch (storeShape)
                  {
                    case TypeShape.Shape_Rectangle:
                        handler.string_value("Rectangle");
                        break;
                    case TypeShape.Shape_Square:
                        handler.string_value("Square");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            if (flagHasSize)
              {
                handler.start_pair("Size");
                switch (storeSize)
                  {
                    case TypeSize.Size_Small:
                        handler.string_value("Small");
                        break;
                    case TypeSize.Size_Medium:
                        handler.string_value("Medium");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            if (flagHasCenterCrop)
              {
                handler.start_pair("CenterCrop");
                handler.boolean_value(storeCenterCrop);
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
            if (!(hasURL()))
              {
                return "When parsing the object for %what%, the \"URL\" field was missing.";
              }
            return null;
          }

        public static TypeImageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeImageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeImage", ignore_extras);
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
        public static TypeImageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeImageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeImageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeImage", ignore_extras);
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
        public static TypeImageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeImageJSON from_text(string text, bool ignore_extras)
          {
            TypeImageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeImage", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeImageJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeImageJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeImageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeImage", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorURL;
        private abstract class FieldGeneratorShape : JSONStringGenerator
              {
                protected FieldGeneratorShape(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorShape()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToShape(result));
                  }
                protected abstract void handle_result(TypeShape result);
              };
        private class FieldHoldingGeneratorShape : FieldGeneratorShape
      {
        protected override void handle_result(TypeShape result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorShape(String what)
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
        public TypeShape value;
      };
        private class FieldHoldingArrayGeneratorShape : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorShape
          {
            private FieldHoldingArrayGeneratorShape top;

            protected override void handle_result(TypeShape result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorShape init_top)
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
        protected virtual void handle_result(List<TypeShape> result)
          {
          }

        public FieldHoldingArrayGeneratorShape(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeShape>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorShape()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeShape>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeShape> value;
      };
            private FieldHoldingGeneratorShape fieldGeneratorShape;
        private abstract class FieldGeneratorSize : JSONStringGenerator
              {
                protected FieldGeneratorSize(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorSize()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToSize(result));
                  }
                protected abstract void handle_result(TypeSize result);
              };
        private class FieldHoldingGeneratorSize : FieldGeneratorSize
      {
        protected override void handle_result(TypeSize result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorSize(String what)
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
        public TypeSize value;
      };
        private class FieldHoldingArrayGeneratorSize : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorSize
          {
            private FieldHoldingArrayGeneratorSize top;

            protected override void handle_result(TypeSize result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorSize init_top)
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
        protected virtual void handle_result(List<TypeSize> result)
          {
          }

        public FieldHoldingArrayGeneratorSize(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeSize>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorSize()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeSize>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeSize> value;
      };
            private FieldHoldingGeneratorSize fieldGeneratorSize;
            private JSONHoldingBooleanGenerator fieldGeneratorCenterCrop;
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
                TypeImageJSON result = new TypeImageJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeImageAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeImageJSON result)
              {
                if (fieldGeneratorURL.have_value)
                  {
                    result.setURL(fieldGeneratorURL.value);
                    fieldGeneratorURL.have_value = false;
                  }
                else if ((!(result.hasURL())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"URL\" field was missing.");
                  }
                if (fieldGeneratorShape.have_value)
                  {
                    result.setShape(fieldGeneratorShape.value);
                    fieldGeneratorShape.have_value = false;
                  }
                if (fieldGeneratorSize.have_value)
                  {
                    result.setSize(fieldGeneratorSize.value);
                    fieldGeneratorSize.have_value = false;
                  }
                if (fieldGeneratorCenterCrop.have_value)
                  {
                    result.setCenterCrop(fieldGeneratorCenterCrop.value);
                    fieldGeneratorCenterCrop.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeImageJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "enterCrop", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorCenterCrop;
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'h':
                                if ((String.Compare(field_name, 2, "ape", 0, 3, false) == 0) && (field_name.Length == 5))
                                    return fieldGeneratorShape;
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 2, "ze", 0, 2, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorSize;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "RL", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorURL;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the TypeImage class");
                fieldGeneratorShape = new FieldHoldingGeneratorShape("field \"Shape\" of the TypeImage class");
                fieldGeneratorSize = new FieldHoldingGeneratorSize("field \"Size\" of the TypeImage class");
                fieldGeneratorCenterCrop = new JSONHoldingBooleanGenerator("field \"CenterCrop\" of the TypeImage class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeImage class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the TypeImage class");
                fieldGeneratorShape = new FieldHoldingGeneratorShape("field \"Shape\" of the TypeImage class");
                fieldGeneratorSize = new FieldHoldingGeneratorSize("field \"Size\" of the TypeImage class");
                fieldGeneratorCenterCrop = new JSONHoldingBooleanGenerator("field \"CenterCrop\" of the TypeImage class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeImage class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorURL.reset();
                fieldGeneratorShape.reset();
                fieldGeneratorSize.reset();
                fieldGeneratorCenterCrop.reset();
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
            protected override void handle_result(TypeImageJSON  result)
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
            public TypeImageJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeImageJSON  result)
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
        protected virtual void handle_result(List<TypeImageJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeImageJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeImageJSON>();
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
        public List<TypeImageJSON> value;
      };
      };
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasSubtitle;
    private string storeSubtitle;
    private bool flagHasRating;
    private sbyte storeRating;
    private bool flagHasBodyText;
    private string storeBodyText;
    private bool flagHasFooter;
    private string storeFooter;
    private bool flagHasAudioPreviewURI;
    private string storeAudioPreviewURI;
    private bool flagHasImage;
    private TypeImageJSON  storeImage;
    private bool flagHasActionAndroidIntent;
    private AndroidIntentJSON  storeActionAndroidIntent;
    private bool flagHasActionURIs;
    private List< string > storeActionURIs;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraTitleToJSON()
      {
        JSONStringValue generated_string_Title = new JSONStringValue(storeTitle);
        return generated_string_Title;
      }

    private JSONValue  extraSubtitleToJSON()
      {
        JSONStringValue generated_string_Subtitle = new JSONStringValue(storeSubtitle);
        return generated_string_Subtitle;
      }

    private JSONValue  extraRatingToJSON()
      {
        JSONIntegerValue generated_integer_Rating = new JSONIntegerValue(storeRating);
        return generated_integer_Rating;
      }

    private JSONValue  extraBodyTextToJSON()
      {
        JSONStringValue generated_string_BodyText = new JSONStringValue(storeBodyText);
        return generated_string_BodyText;
      }

    private JSONValue  extraFooterToJSON()
      {
        JSONStringValue generated_string_Footer = new JSONStringValue(storeFooter);
        return generated_string_Footer;
      }

    private JSONValue  extraAudioPreviewURIToJSON()
      {
        JSONStringValue generated_string_AudioPreviewURI = new JSONStringValue(storeAudioPreviewURI);
        return generated_string_AudioPreviewURI;
      }

    private JSONValue  extraImageToJSON()
      {
        JSONValueHandler handler_Image = new JSONValueHandler();
        storeImage.write_as_json(handler_Image);
        return handler_Image.result;
      }

    private JSONValue  extraActionAndroidIntentToJSON()
      {
        JSONValueHandler handler_ActionAndroidIntent = new JSONValueHandler();
        storeActionAndroidIntent.write_as_json(handler_ActionAndroidIntent);
        return handler_ActionAndroidIntent.result;
      }

    private JSONValue  extraActionURIsToJSON()
      {
        JSONArrayValue generated_array_1_ActionURIs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeActionURIs.Count; ++num1)
          {
            JSONStringValue generated_string_ActionURIs = new JSONStringValue(storeActionURIs[num1]);
            generated_array_1_ActionURIs.appendComponent(generated_string_ActionURIs);
          }
        return generated_array_1_ActionURIs;
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of MediaTemplateJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONSubtitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Subtitle of MediaTemplateJSON is not a string.");
        setSubtitle(json_string.getData());
      }


    private void  fromJSONRating(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Rating of MediaTemplateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Rating of MediaTemplateJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setRating(extracted_integer);
      }


    private void  fromJSONBodyText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BodyText of MediaTemplateJSON is not a string.");
        setBodyText(json_string.getData());
      }


    private void  fromJSONFooter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Footer of MediaTemplateJSON is not a string.");
        setFooter(json_string.getData());
      }


    private void  fromJSONAudioPreviewURI(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AudioPreviewURI of MediaTemplateJSON is not a string.");
        setAudioPreviewURI(json_string.getData());
      }


    private void  fromJSONImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeImageJSON convert_classy = TypeImageJSON.from_json(json_value, ignore_extras, true);
        setImage(convert_classy);
      }


    private void  fromJSONActionAndroidIntent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AndroidIntentJSON convert_classy = AndroidIntentJSON.from_json(json_value, ignore_extras, true);
        setActionAndroidIntent(convert_classy);
      }


    private void  fromJSONActionURIs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ActionURIs of MediaTemplateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ActionURIs of MediaTemplateJSON has too few elements.");
        List< string > vector_ActionURIs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ActionURIs of MediaTemplateJSON is not a string.");
            vector_ActionURIs1.Add(json_string.getData());
          }
        Debug.Assert(vector_ActionURIs1.Count >= 1);
        initActionURIs();
        for (int num1 = 0; num1 < vector_ActionURIs1.Count; ++num1)
            appendActionURIs(vector_ActionURIs1[num1]);
        for (int num1 = 0; num1 < vector_ActionURIs1.Count; ++num1)
          {
          }
      }


    public MediaTemplateJSON()
      {
        flagHasTitle = false;
        flagHasSubtitle = false;
        flagHasRating = false;
        flagHasBodyText = false;
        flagHasFooter = false;
        flagHasAudioPreviewURI = false;
        flagHasImage = false;
        flagHasActionAndroidIntent = false;
        flagHasActionURIs = false;
        storeActionURIs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTemplateName()
      {
        return "Media";
      }

    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        Debug.Assert(flagHasTitle);
        return storeTitle;
      }

    public bool  hasSubtitle()
      {
        return flagHasSubtitle;
      }

    public string  getSubtitle()
      {
        Debug.Assert(flagHasSubtitle);
        return storeSubtitle;
      }

    public bool  hasRating()
      {
        return flagHasRating;
      }

    public sbyte  getRating()
      {
        Debug.Assert(flagHasRating);
        return storeRating;
      }

    public bool  hasBodyText()
      {
        return flagHasBodyText;
      }

    public string  getBodyText()
      {
        Debug.Assert(flagHasBodyText);
        return storeBodyText;
      }

    public bool  hasFooter()
      {
        return flagHasFooter;
      }

    public string  getFooter()
      {
        Debug.Assert(flagHasFooter);
        return storeFooter;
      }

    public bool  hasAudioPreviewURI()
      {
        return flagHasAudioPreviewURI;
      }

    public string  getAudioPreviewURI()
      {
        Debug.Assert(flagHasAudioPreviewURI);
        return storeAudioPreviewURI;
      }

    public bool  hasImage()
      {
        return flagHasImage;
      }

    public TypeImageJSON   getImage()
      {
        Debug.Assert(flagHasImage);
        return storeImage;
      }

    public bool  hasActionAndroidIntent()
      {
        return flagHasActionAndroidIntent;
      }

    public AndroidIntentJSON   getActionAndroidIntent()
      {
        Debug.Assert(flagHasActionAndroidIntent);
        return storeActionAndroidIntent;
      }

    public bool  hasActionURIs()
      {
        return flagHasActionURIs;
      }

    public int  countOfActionURIs()
      {
        Debug.Assert(flagHasActionURIs);
        return storeActionURIs.Count;
      }

    public string  elementOfActionURIs(int element_num)
      {
        Debug.Assert(flagHasActionURIs);
        return storeActionURIs[element_num];
      }

    public List< string >  getActionURIs()
      {
        Debug.Assert(flagHasActionURIs);
        return storeActionURIs;
      }


    public virtual int extraMediaTemplateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMediaTemplateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMediaTemplateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMediaTemplateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTemplateComponentCount()
      {
        int result = 0;
        if (flagHasTitle)
            ++result;
        if (flagHasSubtitle)
            ++result;
        if (flagHasRating)
            ++result;
        if (flagHasBodyText)
            ++result;
        if (flagHasFooter)
            ++result;
        if (flagHasAudioPreviewURI)
            ++result;
        if (flagHasImage)
            ++result;
        if (flagHasActionAndroidIntent)
            ++result;
        if (flagHasActionURIs)
            ++result;
        result += extraMediaTemplateComponentCount();
        return result;
      }
    public override string extraTemplateComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasTitle)
          {
            if (remainder == 0)
                return "Title";
            --remainder;
          }
        if (flagHasSubtitle)
          {
            if (remainder == 0)
                return "Subtitle";
            --remainder;
          }
        if (flagHasRating)
          {
            if (remainder == 0)
                return "Rating";
            --remainder;
          }
        if (flagHasBodyText)
          {
            if (remainder == 0)
                return "BodyText";
            --remainder;
          }
        if (flagHasFooter)
          {
            if (remainder == 0)
                return "Footer";
            --remainder;
          }
        if (flagHasAudioPreviewURI)
          {
            if (remainder == 0)
                return "AudioPreviewURI";
            --remainder;
          }
        if (flagHasImage)
          {
            if (remainder == 0)
                return "Image";
            --remainder;
          }
        if (flagHasActionAndroidIntent)
          {
            if (remainder == 0)
                return "ActionAndroidIntent";
            --remainder;
          }
        if (flagHasActionURIs)
          {
            if (remainder == 0)
                return "ActionURIs";
            --remainder;
          }
        return extraMediaTemplateComponentKey(remainder);
      }
    public override JSONValue extraTemplateComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasTitle)
          {
            if (remainder == 0)
                return extraTitleToJSON();
            --remainder;
          }
        if (flagHasSubtitle)
          {
            if (remainder == 0)
                return extraSubtitleToJSON();
            --remainder;
          }
        if (flagHasRating)
          {
            if (remainder == 0)
                return extraRatingToJSON();
            --remainder;
          }
        if (flagHasBodyText)
          {
            if (remainder == 0)
                return extraBodyTextToJSON();
            --remainder;
          }
        if (flagHasFooter)
          {
            if (remainder == 0)
                return extraFooterToJSON();
            --remainder;
          }
        if (flagHasAudioPreviewURI)
          {
            if (remainder == 0)
                return extraAudioPreviewURIToJSON();
            --remainder;
          }
        if (flagHasImage)
          {
            if (remainder == 0)
                return extraImageToJSON();
            --remainder;
          }
        if (flagHasActionAndroidIntent)
          {
            if (remainder == 0)
                return extraActionAndroidIntentToJSON();
            --remainder;
          }
        if (flagHasActionURIs)
          {
            if (remainder == 0)
                return extraActionURIsToJSON();
            --remainder;
          }
        return extraMediaTemplateComponentValue(remainder);
      }
    public override JSONValue extraTemplateLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 'c':
                        if (String.Compare(field_name, 2, "tion", 0, 4, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 7, "ndroidIntent", 0, 12, false) == 0) && (field_name.Length == 19))
                                        return (flagHasActionAndroidIntent ? extraActionAndroidIntentToJSON() : null);
                                    break;
                                case 'U':
                                    if ((String.Compare(field_name, 7, "RIs", 0, 3, false) == 0) && (field_name.Length == 10))
                                        return (flagHasActionURIs ? extraActionURIsToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 2, "dioPreviewURI", 0, 13, false) == 0) && (field_name.Length == 15))
                            return (flagHasAudioPreviewURI ? extraAudioPreviewURIToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                if ((String.Compare(field_name, 1, "odyText", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasBodyText ? extraBodyTextToJSON() : null);
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "ooter", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasFooter ? extraFooterToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "mage", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasImage ? extraImageToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "ating", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasRating ? extraRatingToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "ubtitle", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasSubtitle ? extraSubtitleToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasTitle ? extraTitleToJSON() : null);
                break;
            default:
                break;
          }
        return extraMediaTemplateLookup(field_name);
      }

    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setSubtitle(string new_value)
      {
        flagHasSubtitle = true;
        storeSubtitle = new_value;
      }
    public void unsetSubtitle()
      {
        flagHasSubtitle = false;
      }
    public void setRating(sbyte new_value)
      {
        flagHasRating = true;
        if (new_value < 0)
            throw new Exception("The value for field Rating of MediaTemplateJSON is less than the lower bound (0) for that field.");
        if (new_value > 5)
            throw new Exception("The value for field Rating of MediaTemplateJSON is greater than the upper bound (5) for that field.");
        storeRating = new_value;
      }
    public void unsetRating()
      {
        flagHasRating = false;
      }
    public void setBodyText(string new_value)
      {
        flagHasBodyText = true;
        storeBodyText = new_value;
      }
    public void unsetBodyText()
      {
        flagHasBodyText = false;
      }
    public void setFooter(string new_value)
      {
        flagHasFooter = true;
        storeFooter = new_value;
      }
    public void unsetFooter()
      {
        flagHasFooter = false;
      }
    public void setAudioPreviewURI(string new_value)
      {
        flagHasAudioPreviewURI = true;
        storeAudioPreviewURI = new_value;
      }
    public void unsetAudioPreviewURI()
      {
        flagHasAudioPreviewURI = false;
      }
    public void setImage(TypeImageJSON  new_value)
      {
        if (flagHasImage)
          {
          }
        flagHasImage = true;
        storeImage = new_value;
      }
    public void unsetImage()
      {
        if (flagHasImage)
          {
          }
        flagHasImage = false;
      }
    public void setActionAndroidIntent(AndroidIntentJSON  new_value)
      {
        if (flagHasActionAndroidIntent)
          {
          }
        flagHasActionAndroidIntent = true;
        storeActionAndroidIntent = new_value;
      }
    public void unsetActionAndroidIntent()
      {
        if (flagHasActionAndroidIntent)
          {
          }
        flagHasActionAndroidIntent = false;
      }
    public void initActionURIs()
      {
        flagHasActionURIs = true;
        storeActionURIs.Clear();
      }
    public void appendActionURIs(string to_append)
      {
        if (!flagHasActionURIs)
          {
            flagHasActionURIs = true;
            storeActionURIs.Clear();
          }
        Debug.Assert(flagHasActionURIs);
        storeActionURIs.Add(to_append);
      }
    public void unsetActionURIs()
      {
        flagHasActionURIs = false;
        storeActionURIs.Clear();
      }

    public virtual void extraMediaTemplateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMediaTemplateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMediaTemplateLookup(key);
        if (old_field == null)
          {
            extraMediaTemplateAppendPair(key, new_component);
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
    public override void extraTemplateAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'c':
                        if (String.Compare(key, 2, "tion", 0, 4, false) == 0)
                          {
                            switch (key[6])
                              {
                                case 'A':
                                    if ((String.Compare(key, 7, "ndroidIntent", 0, 12, false) == 0) && (key.Length == 19))
                                        {
                                        fromJSONActionAndroidIntent(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'U':
                                    if ((String.Compare(key, 7, "RIs", 0, 3, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONActionURIs(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "dioPreviewURI", 0, 13, false) == 0) && (key.Length == 15))
                            {
                            fromJSONAudioPreviewURI(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                if ((String.Compare(key, 1, "odyText", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONBodyText(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ooter", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONFooter(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "mage", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONImage(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "ating", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONRating(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ubtitle", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONSubtitle(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "itle", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONTitle(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMediaTemplateAppendPair(key, new_component);
      }
    public override void extraTemplateSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'c':
                        if (String.Compare(key, 2, "tion", 0, 4, false) == 0)
                          {
                            switch (key[6])
                              {
                                case 'A':
                                    if ((String.Compare(key, 7, "ndroidIntent", 0, 12, false) == 0) && (key.Length == 19))
                                        {
                                        fromJSONActionAndroidIntent(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'U':
                                    if ((String.Compare(key, 7, "RIs", 0, 3, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONActionURIs(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "dioPreviewURI", 0, 13, false) == 0) && (key.Length == 15))
                            {
                            fromJSONAudioPreviewURI(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                if ((String.Compare(key, 1, "odyText", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONBodyText(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ooter", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONFooter(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "mage", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONImage(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "ating", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONRating(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ubtitle", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONSubtitle(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "itle", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONTitle(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMediaTemplateSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTitle);
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasSubtitle)
          {
            handler.start_pair("Subtitle");
            handler.string_value(storeSubtitle);
          }
        if (flagHasRating)
          {
            handler.start_pair("Rating");
            handler.number_value(storeRating);
          }
        if (flagHasBodyText)
          {
            handler.start_pair("BodyText");
            handler.string_value(storeBodyText);
          }
        if (flagHasFooter)
          {
            handler.start_pair("Footer");
            handler.string_value(storeFooter);
          }
        if (flagHasAudioPreviewURI)
          {
            handler.start_pair("AudioPreviewURI");
            handler.string_value(storeAudioPreviewURI);
          }
        if (flagHasImage)
          {
            handler.start_pair("Image");
            if (partial_allowed)
                storeImage.write_partial_as_json(handler);
            else
                storeImage.write_as_json(handler);
          }
        if (flagHasActionAndroidIntent)
          {
            handler.start_pair("ActionAndroidIntent");
            if (partial_allowed)
                storeActionAndroidIntent.write_partial_as_json(handler);
            else
                storeActionAndroidIntent.write_as_json(handler);
          }
        if (flagHasActionURIs)
          {
            handler.start_pair("ActionURIs");
            Debug.Assert(storeActionURIs.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeActionURIs.Count; ++num1)
              {
                handler.string_value(storeActionURIs[num1]);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if ((!allow_unpolished) && !(hasTitle()))
          {
            return "When parsing the object for %what%, the \"Title\" field was missing.";
          }
        return null;
      }

    public static new MediaTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MediaTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MediaTemplate", ignore_extras);
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
    public static new MediaTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MediaTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MediaTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MediaTemplate", ignore_extras);
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
    public static new MediaTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MediaTemplateJSON from_text(string text, bool ignore_extras)
      {
        MediaTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MediaTemplate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MediaTemplateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MediaTemplateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MediaTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MediaTemplate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TemplateJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorSubtitle;
    private class FieldHoldingGeneratorRating : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorRating(String what) : base(what, 0, 5)
              {
              }
          };
    private class FieldHoldingArrayGeneratorRating : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorRating(String what) : base(what, 0, 5)
              {
              }
          };
        private FieldHoldingGeneratorRating fieldGeneratorRating;
        private JSONHoldingStringGenerator fieldGeneratorBodyText;
        private JSONHoldingStringGenerator fieldGeneratorFooter;
        private JSONHoldingStringGenerator fieldGeneratorAudioPreviewURI;
        private TypeImageJSON.HoldingGenerator fieldGeneratorImage;
        private AndroidIntentJSON.HoldingGenerator fieldGeneratorActionAndroidIntent;
        private JSONHoldingStringArrayGenerator fieldGeneratorActionURIs;
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
            if (!(getTemplateJSONKey().Equals("Media")))
                throw new Exception("The key field has a value other than `Media'.");
            MediaTemplateJSON result = new MediaTemplateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMediaTemplateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TemplateJSON new_result)
          {
            handle_result((MediaTemplateJSON )new_result);
          }
        protected void finish(MediaTemplateJSON result)
          {
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            else if ((!(result.hasTitle())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Title\" field was missing.");
              }
            if (fieldGeneratorSubtitle.have_value)
              {
                result.setSubtitle(fieldGeneratorSubtitle.value);
                fieldGeneratorSubtitle.have_value = false;
              }
            if (fieldGeneratorRating.have_value)
              {
                result.setRating((sbyte)(fieldGeneratorRating.value));
                fieldGeneratorRating.have_value = false;
              }
            if (fieldGeneratorBodyText.have_value)
              {
                result.setBodyText(fieldGeneratorBodyText.value);
                fieldGeneratorBodyText.have_value = false;
              }
            if (fieldGeneratorFooter.have_value)
              {
                result.setFooter(fieldGeneratorFooter.value);
                fieldGeneratorFooter.have_value = false;
              }
            if (fieldGeneratorAudioPreviewURI.have_value)
              {
                result.setAudioPreviewURI(fieldGeneratorAudioPreviewURI.value);
                fieldGeneratorAudioPreviewURI.have_value = false;
              }
            if (fieldGeneratorImage.have_value)
              {
                result.setImage(fieldGeneratorImage.value);
                fieldGeneratorImage.have_value = false;
              }
            if (fieldGeneratorActionAndroidIntent.have_value)
              {
                result.setActionAndroidIntent(fieldGeneratorActionAndroidIntent.value);
                fieldGeneratorActionAndroidIntent.have_value = false;
              }
            if (fieldGeneratorActionURIs.have_value)
              {
                result.initActionURIs();
                int count = fieldGeneratorActionURIs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendActionURIs(fieldGeneratorActionURIs.value[num]);
                  }
                fieldGeneratorActionURIs.value.Clear();
                fieldGeneratorActionURIs.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MediaTemplateJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'c':
                            if (String.Compare(field_name, 2, "tion", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 7, "ndroidIntent", 0, 12, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorActionAndroidIntent;
                                        break;
                                    case 'U':
                                        if ((String.Compare(field_name, 7, "RIs", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorActionURIs;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "dioPreviewURI", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorAudioPreviewURI;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "odyText", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorBodyText;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ooter", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorFooter;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "mage", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorImage;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ating", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorRating;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ubtitle", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorSubtitle;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTitle;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the MediaTemplate class");
            fieldGeneratorSubtitle = new JSONHoldingStringGenerator("field \"Subtitle\" of the MediaTemplate class");
            fieldGeneratorRating = new FieldHoldingGeneratorRating("field \"Rating\" of the MediaTemplate class");
            fieldGeneratorBodyText = new JSONHoldingStringGenerator("field \"BodyText\" of the MediaTemplate class");
            fieldGeneratorFooter = new JSONHoldingStringGenerator("field \"Footer\" of the MediaTemplate class");
            fieldGeneratorAudioPreviewURI = new JSONHoldingStringGenerator("field \"AudioPreviewURI\" of the MediaTemplate class");
            fieldGeneratorImage = new TypeImageJSON.HoldingGenerator("field \"Image\" of the MediaTemplate class", ignore_extras);
            fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the MediaTemplate class", ignore_extras);
            fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the MediaTemplate class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MediaTemplate class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the MediaTemplate class");
            fieldGeneratorSubtitle = new JSONHoldingStringGenerator("field \"Subtitle\" of the MediaTemplate class");
            fieldGeneratorRating = new FieldHoldingGeneratorRating("field \"Rating\" of the MediaTemplate class");
            fieldGeneratorBodyText = new JSONHoldingStringGenerator("field \"BodyText\" of the MediaTemplate class");
            fieldGeneratorFooter = new JSONHoldingStringGenerator("field \"Footer\" of the MediaTemplate class");
            fieldGeneratorAudioPreviewURI = new JSONHoldingStringGenerator("field \"AudioPreviewURI\" of the MediaTemplate class");
            fieldGeneratorImage = new TypeImageJSON.HoldingGenerator("field \"Image\" of the MediaTemplate class", false);
            fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the MediaTemplate class", false);
            fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the MediaTemplate class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MediaTemplate class");
          }

        public override void reset()
          {
            fieldGeneratorTitle.reset();
            fieldGeneratorSubtitle.reset();
            fieldGeneratorRating.reset();
            fieldGeneratorBodyText.reset();
            fieldGeneratorFooter.reset();
            fieldGeneratorAudioPreviewURI.reset();
            fieldGeneratorImage.reset();
            fieldGeneratorActionAndroidIntent.reset();
            fieldGeneratorActionURIs.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MediaTemplateJSON  result)
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
        public MediaTemplateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MediaTemplateJSON  result)
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
    protected virtual void handle_result(List<MediaTemplateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MediaTemplateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MediaTemplateJSON>();
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
    public List<MediaTemplateJSON> value;
  };
  };
