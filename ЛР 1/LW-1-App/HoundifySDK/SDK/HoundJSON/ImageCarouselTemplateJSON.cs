/* file "ImageCarouselTemplateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ImageCarouselTemplateJSON : TemplateJSON
  {
    public enum TypeSize
      {
        Size_Small,
        Size_Medium,
        Size_Large
      };

    public static TypeSize  stringToSize(string chars)
      {
        switch (chars[0])
          {
            case 'L':
                if ((String.Compare(chars, 1, "arge", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeSize.Size_Large;
                break;
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
            case TypeSize.Size_Large:
                return "Large";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeSlidesJSON : JSONBase
      {
        private bool flagHasImageURL;
        private string storeImageURL;
        private bool flagHasDescription;
        private string storeDescription;
        private bool flagHasCenterCrop;
        private bool storeCenterCrop;
        private bool flagHasActionAndroidIntent;
        private AndroidIntentJSON  storeActionAndroidIntent;
        private bool flagHasActionURIs;
        private List< string > storeActionURIs;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONImageURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ImageURL of TypeSlidesJSON is not a string.");
            setImageURL(json_string.getData());
          }


        private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Description of TypeSlidesJSON is not a string.");
            setDescription(json_string.getData());
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
                    throw new Exception("The value for field CenterCrop of TypeSlidesJSON is not true for false.");
                  }
              }
            setCenterCrop(the_bool);
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
                throw new Exception("The value for field ActionURIs of TypeSlidesJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field ActionURIs of TypeSlidesJSON has too few elements.");
            List< string > vector_ActionURIs1 = new List< string >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONStringValue json_string = json_array1.component(num1).string_value();
                if (json_string == null)
                    throw new Exception("The value for an element of field ActionURIs of TypeSlidesJSON is not a string.");
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


        public TypeSlidesJSON()
          {
            flagHasImageURL = false;
            flagHasDescription = false;
            flagHasCenterCrop = false;
            flagHasActionAndroidIntent = false;
            flagHasActionURIs = false;
            storeCenterCrop = true;
            storeActionURIs = new List< string >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasImageURL()
          {
            return flagHasImageURL;
          }

        public string  getImageURL()
          {
            Debug.Assert(flagHasImageURL);
            return storeImageURL;
          }

        public bool  hasDescription()
          {
            return flagHasDescription;
          }

        public string  getDescription()
          {
            Debug.Assert(flagHasDescription);
            return storeDescription;
          }

        public bool  hasCenterCrop()
          {
            return flagHasCenterCrop;
          }

        public bool  getCenterCrop()
          {
            return storeCenterCrop;
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


        public virtual int extraTypeSlidesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSlidesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSlidesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSlidesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setImageURL(string new_value)
          {
            flagHasImageURL = true;
            storeImageURL = new_value;
          }
        public void unsetImageURL()
          {
            flagHasImageURL = false;
          }
        public void setDescription(string new_value)
          {
            flagHasDescription = true;
            storeDescription = new_value;
          }
        public void unsetDescription()
          {
            flagHasDescription = false;
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

        public virtual void extraTypeSlidesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSlidesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSlidesLookup(key);
            if (old_field == null)
              {
                extraTypeSlidesAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasImageURL);
            if (flagHasImageURL)
              {
                handler.start_pair("ImageURL");
                handler.string_value(storeImageURL);
              }
            if (flagHasDescription)
              {
                handler.start_pair("Description");
                handler.string_value(storeDescription);
              }
            if (flagHasCenterCrop)
              {
                handler.start_pair("CenterCrop");
                handler.boolean_value(storeCenterCrop);
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
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasImageURL()))
              {
                return "When parsing the object for %what%, the \"ImageURL\" field was missing.";
              }
            return null;
          }

        public static TypeSlidesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSlidesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSlides", ignore_extras);
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
        public static TypeSlidesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSlidesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSlidesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSlides", ignore_extras);
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
        public static TypeSlidesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSlidesJSON from_text(string text, bool ignore_extras)
          {
            TypeSlidesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSlides", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSlidesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSlidesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSlidesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSlides", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorImageURL;
            private JSONHoldingStringGenerator fieldGeneratorDescription;
            private JSONHoldingBooleanGenerator fieldGeneratorCenterCrop;
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
                TypeSlidesJSON result = new TypeSlidesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSlidesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSlidesJSON result)
              {
                if (fieldGeneratorImageURL.have_value)
                  {
                    result.setImageURL(fieldGeneratorImageURL.value);
                    fieldGeneratorImageURL.have_value = false;
                  }
                else if ((!(result.hasImageURL())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ImageURL\" field was missing.");
                  }
                if (fieldGeneratorDescription.have_value)
                  {
                    result.setDescription(fieldGeneratorDescription.value);
                    fieldGeneratorDescription.have_value = false;
                  }
                if (fieldGeneratorCenterCrop.have_value)
                  {
                    result.setCenterCrop(fieldGeneratorCenterCrop.value);
                    fieldGeneratorCenterCrop.have_value = false;
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
              }
            protected abstract void handle_result(TypeSlidesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if (String.Compare(field_name, 1, "ction", 0, 5, false) == 0)
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
                    case 'C':
                        if ((String.Compare(field_name, 1, "enterCrop", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorCenterCrop;
                        break;
                    case 'D':
                        if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorDescription;
                        break;
                    case 'I':
                        if ((String.Compare(field_name, 1, "mageURL", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorImageURL;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the TypeSlides class");
                fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the TypeSlides class");
                fieldGeneratorCenterCrop = new JSONHoldingBooleanGenerator("field \"CenterCrop\" of the TypeSlides class");
                fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the TypeSlides class", ignore_extras);
                fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the TypeSlides class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSlides class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the TypeSlides class");
                fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the TypeSlides class");
                fieldGeneratorCenterCrop = new JSONHoldingBooleanGenerator("field \"CenterCrop\" of the TypeSlides class");
                fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the TypeSlides class", false);
                fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the TypeSlides class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSlides class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorImageURL.reset();
                fieldGeneratorDescription.reset();
                fieldGeneratorCenterCrop.reset();
                fieldGeneratorActionAndroidIntent.reset();
                fieldGeneratorActionURIs.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorActionAndroidIntent.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorActionAndroidIntent.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeSlidesJSON  result)
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
            public TypeSlidesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSlidesJSON  result)
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
        protected virtual void handle_result(List<TypeSlidesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSlidesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSlidesJSON>();
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
        public List<TypeSlidesJSON> value;
      };
      };
    private bool flagHasSize;
    private TypeSize storeSize;
    private bool flagHasAutoScroll;
    private bool storeAutoScroll;
    private bool flagHasSlides;
    private List< TypeSlidesJSON  > storeSlides;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSizeToJSON()
      {
        JSONStringValue generated_string_Size;
        switch (storeSize)
          {
            case TypeSize.Size_Small:
                generated_string_Size = new JSONStringValue("Small");
                break;
            case TypeSize.Size_Medium:
                generated_string_Size = new JSONStringValue("Medium");
                break;
            case TypeSize.Size_Large:
                generated_string_Size = new JSONStringValue("Large");
                break;
            default:
                Debug.Assert(false);
                generated_string_Size = null;
                break;
          }
        return generated_string_Size;
      }

    private JSONValue  extraAutoScrollToJSON()
      {
        JSONValue generated_boolean_AutoScroll = (storeAutoScroll ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_AutoScroll;
      }

    private JSONValue  extraSlidesToJSON()
      {
        JSONArrayValue generated_array_1_Slides = new JSONArrayValue();
        for (int num1 = 0; num1 < storeSlides.Count; ++num1)
          {
            JSONValueHandler handler_Slides = new JSONValueHandler();
            storeSlides[num1].write_as_json(handler_Slides);
            generated_array_1_Slides.appendComponent(handler_Slides.result);
          }
        return generated_array_1_Slides;
      }


    private void  fromJSONSize(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Size of ImageCarouselTemplateJSON is not a string.");
        TypeSize the_enum;
        switch (json_string.getData()[0])
          {
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "arge", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeSize.Size_Large;
                        goto enum_is_done;
                      }
                break;
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
        throw new Exception("The value for field Size of ImageCarouselTemplateJSON is not one of the legal strings.");
      enum_is_done:;
        setSize(the_enum);
      }


    private void  fromJSONAutoScroll(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AutoScroll of ImageCarouselTemplateJSON is not true for false.");
              }
          }
        setAutoScroll(the_bool);
      }


    private void  fromJSONSlides(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Slides of ImageCarouselTemplateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeSlidesJSON  > vector_Slides1 = new List< TypeSlidesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeSlidesJSON convert_classy = TypeSlidesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Slides1.Add(convert_classy);
          }
        initSlides();
        for (int num2 = 0; num2 < vector_Slides1.Count; ++num2)
            appendSlides(vector_Slides1[num2]);
        for (int num1 = 0; num1 < vector_Slides1.Count; ++num1)
          {
          }
      }


    public ImageCarouselTemplateJSON()
      {
        flagHasSize = false;
        flagHasAutoScroll = false;
        flagHasSlides = false;
        storeSize = TypeSize.Size_Medium;
        storeAutoScroll = false;
        storeSlides = new List< TypeSlidesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTemplateName()
      {
        return "ImageCarousel";
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

    public bool  hasAutoScroll()
      {
        return flagHasAutoScroll;
      }

    public bool  getAutoScroll()
      {
        return storeAutoScroll;
      }

    public bool  hasSlides()
      {
        return flagHasSlides;
      }

    public int  countOfSlides()
      {
        return storeSlides.Count;
      }

    public TypeSlidesJSON   elementOfSlides(int element_num)
      {
        return storeSlides[element_num];
      }

    public List< TypeSlidesJSON  >  getSlides()
      {
        return storeSlides;
      }


    public virtual int extraImageCarouselTemplateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraImageCarouselTemplateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraImageCarouselTemplateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraImageCarouselTemplateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTemplateComponentCount()
      {
        int result = 0;
        if (flagHasSize)
            ++result;
        if (flagHasAutoScroll)
            ++result;
        if (flagHasSlides)
            ++result;
        result += extraImageCarouselTemplateComponentCount();
        return result;
      }
    public override string extraTemplateComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSize)
          {
            if (remainder == 0)
                return "Size";
            --remainder;
          }
        if (flagHasAutoScroll)
          {
            if (remainder == 0)
                return "AutoScroll";
            --remainder;
          }
        if (flagHasSlides)
          {
            if (remainder == 0)
                return "Slides";
            --remainder;
          }
        return extraImageCarouselTemplateComponentKey(remainder);
      }
    public override JSONValue extraTemplateComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSize)
          {
            if (remainder == 0)
                return extraSizeToJSON();
            --remainder;
          }
        if (flagHasAutoScroll)
          {
            if (remainder == 0)
                return extraAutoScrollToJSON();
            --remainder;
          }
        if (flagHasSlides)
          {
            if (remainder == 0)
                return extraSlidesToJSON();
            --remainder;
          }
        return extraImageCarouselTemplateComponentValue(remainder);
      }
    public override JSONValue extraTemplateLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "utoScroll", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasAutoScroll ? extraAutoScrollToJSON() : null);
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 'i':
                        if ((String.Compare(field_name, 2, "ze", 0, 2, false) == 0) && (field_name.Length == 4))
                            return (flagHasSize ? extraSizeToJSON() : null);
                        break;
                    case 'l':
                        if ((String.Compare(field_name, 2, "ides", 0, 4, false) == 0) && (field_name.Length == 6))
                            return (flagHasSlides ? extraSlidesToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return extraImageCarouselTemplateLookup(field_name);
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
    public void setAutoScroll(bool new_value)
      {
        flagHasAutoScroll = true;
        storeAutoScroll = new_value;
      }
    public void unsetAutoScroll()
      {
        flagHasAutoScroll = false;
      }
    public void initSlides()
      {
        if (flagHasSlides)
          {
            for (int num1 = 0; num1 < storeSlides.Count; ++num1)
              {
              }
          }
        flagHasSlides = true;
        storeSlides.Clear();
      }
    public void appendSlides(TypeSlidesJSON  to_append)
      {
        if (!flagHasSlides)
          {
            flagHasSlides = true;
            storeSlides.Clear();
          }
        Debug.Assert(flagHasSlides);
        storeSlides.Add(to_append);
      }
    public void unsetSlides()
      {
        if (flagHasSlides)
          {
            for (int num2 = 0; num2 < storeSlides.Count; ++num2)
              {
              }
          }
        flagHasSlides = false;
        storeSlides.Clear();
      }

    public virtual void extraImageCarouselTemplateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraImageCarouselTemplateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraImageCarouselTemplateLookup(key);
        if (old_field == null)
          {
            extraImageCarouselTemplateAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "utoScroll", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONAutoScroll(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'i':
                        if ((String.Compare(key, 2, "ze", 0, 2, false) == 0) && (key.Length == 4))
                            {
                            fromJSONSize(new_component, false);
                            return;
                            }
                        break;
                    case 'l':
                        if ((String.Compare(key, 2, "ides", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONSlides(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraImageCarouselTemplateAppendPair(key, new_component);
      }
    public override void extraTemplateSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "utoScroll", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONAutoScroll(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'i':
                        if ((String.Compare(key, 2, "ze", 0, 2, false) == 0) && (key.Length == 4))
                            {
                            fromJSONSize(new_component, false);
                            return;
                            }
                        break;
                    case 'l':
                        if ((String.Compare(key, 2, "ides", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONSlides(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraImageCarouselTemplateSetField(key, new_component);
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
                case TypeSize.Size_Large:
                    handler.string_value("Large");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasAutoScroll)
          {
            handler.start_pair("AutoScroll");
            handler.boolean_value(storeAutoScroll);
          }
        if (flagHasSlides)
          {
            handler.start_pair("Slides");
            handler.start_array();
            for (int num1 = 0; num1 < storeSlides.Count; ++num1)
              {
                if (partial_allowed)
                    storeSlides[num1].write_partial_as_json(handler);
                else
                    storeSlides[num1].write_as_json(handler);
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
        return null;
      }

    public static new ImageCarouselTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ImageCarouselTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ImageCarouselTemplate", ignore_extras);
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
    public static new ImageCarouselTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ImageCarouselTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ImageCarouselTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ImageCarouselTemplate", ignore_extras);
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
    public static new ImageCarouselTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ImageCarouselTemplateJSON from_text(string text, bool ignore_extras)
      {
        ImageCarouselTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ImageCarouselTemplate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ImageCarouselTemplateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ImageCarouselTemplateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ImageCarouselTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ImageCarouselTemplate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TemplateJSON.Generator
      {
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
        private JSONHoldingBooleanGenerator fieldGeneratorAutoScroll;
        private TypeSlidesJSON.HoldingArrayGenerator fieldGeneratorSlides;
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
            if (!(getTemplateJSONKey().Equals("ImageCarousel")))
                throw new Exception("The key field has a value other than `ImageCarousel'.");
            ImageCarouselTemplateJSON result = new ImageCarouselTemplateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraImageCarouselTemplateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TemplateJSON new_result)
          {
            handle_result((ImageCarouselTemplateJSON )new_result);
          }
        protected void finish(ImageCarouselTemplateJSON result)
          {
            if (fieldGeneratorSize.have_value)
              {
                result.setSize(fieldGeneratorSize.value);
                fieldGeneratorSize.have_value = false;
              }
            if (fieldGeneratorAutoScroll.have_value)
              {
                result.setAutoScroll(fieldGeneratorAutoScroll.value);
                fieldGeneratorAutoScroll.have_value = false;
              }
            if (fieldGeneratorSlides.have_value)
              {
                result.initSlides();
                int count = fieldGeneratorSlides.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSlides(fieldGeneratorSlides.value[num]);
                  }
                fieldGeneratorSlides.value.Clear();
                fieldGeneratorSlides.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ImageCarouselTemplateJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "utoScroll", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorAutoScroll;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "ze", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorSize;
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "ides", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSlides;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSize = new FieldHoldingGeneratorSize("field \"Size\" of the ImageCarouselTemplate class");
            fieldGeneratorAutoScroll = new JSONHoldingBooleanGenerator("field \"AutoScroll\" of the ImageCarouselTemplate class");
            fieldGeneratorSlides = new TypeSlidesJSON.HoldingArrayGenerator("field \"Slides\" of the ImageCarouselTemplate class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ImageCarouselTemplate class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSize = new FieldHoldingGeneratorSize("field \"Size\" of the ImageCarouselTemplate class");
            fieldGeneratorAutoScroll = new JSONHoldingBooleanGenerator("field \"AutoScroll\" of the ImageCarouselTemplate class");
            fieldGeneratorSlides = new TypeSlidesJSON.HoldingArrayGenerator("field \"Slides\" of the ImageCarouselTemplate class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ImageCarouselTemplate class");
          }

        public override void reset()
          {
            fieldGeneratorSize.reset();
            fieldGeneratorAutoScroll.reset();
            fieldGeneratorSlides.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ImageCarouselTemplateJSON  result)
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
        public ImageCarouselTemplateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ImageCarouselTemplateJSON  result)
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
    protected virtual void handle_result(List<ImageCarouselTemplateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ImageCarouselTemplateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ImageCarouselTemplateJSON>();
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
    public List<ImageCarouselTemplateJSON> value;
  };
  };
