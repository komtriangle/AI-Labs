/* file "UploadedTestFileMetadataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UploadedTestFileMetadataJSON : JSONBase
  {
    public class TypeFormatJSON : JSONBase
      {
        private bool flagHasInline;
        private bool storeInline;
        private bool flagHasOutputParamOrderings;
        private JSONObjectValue  storeOutputParamOrderings;
        private bool flagHasVersion;
        private BigInteger storeVersion;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONInline(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Inline of TypeFormatJSON is not true for false.");
                  }
              }
            setInline(the_bool);
          }


        private void  fromJSONOutputParamOrderings(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            if (json_value.object_value() == null)
                throw new Exception("The value for field OutputParamOrderings of TypeFormatJSON is not an object.");
            setOutputParamOrderings(json_value.object_value());
          }


        private void  fromJSONVersion(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Version of TypeFormatJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Version of TypeFormatJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setVersion(extracted_integer);
          }


        public TypeFormatJSON()
          {
            flagHasInline = false;
            flagHasOutputParamOrderings = false;
            flagHasVersion = false;
            storeInline = true;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasInline()
          {
            return flagHasInline;
          }

        public bool  getInline()
          {
            return storeInline;
          }

        public bool  hasOutputParamOrderings()
          {
            return flagHasOutputParamOrderings;
          }

        public JSONObjectValue   getOutputParamOrderings()
          {
            Debug.Assert(flagHasOutputParamOrderings);
            return storeOutputParamOrderings;
          }

        public bool  hasVersion()
          {
            return flagHasVersion;
          }

        public BigInteger  getVersion()
          {
            Debug.Assert(flagHasVersion);
            return storeVersion;
          }


        public virtual int extraTypeFormatComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeFormatComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeFormatComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeFormatLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setInline(bool new_value)
          {
            flagHasInline = true;
            storeInline = new_value;
          }
        public void unsetInline()
          {
            flagHasInline = false;
          }
        public void setOutputParamOrderings(JSONObjectValue  new_value)
          {
            if (flagHasOutputParamOrderings)
              {
              }
            flagHasOutputParamOrderings = true;
            storeOutputParamOrderings = new_value;
          }
        public void unsetOutputParamOrderings()
          {
            if (flagHasOutputParamOrderings)
              {
              }
            flagHasOutputParamOrderings = false;
          }
        public void setVersion(BigInteger new_value)
          {
            flagHasVersion = true;
            if (new_value < 1)
                throw new Exception("The value for field Version of TypeFormatJSON is less than the lower bound (1) for that field.");
            storeVersion = new_value;
          }
        public void unsetVersion()
          {
            flagHasVersion = false;
          }

        public virtual void extraTypeFormatAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeFormatSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeFormatLookup(key);
            if (old_field == null)
              {
                extraTypeFormatAppendPair(key, new_component);
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
            if (flagHasInline)
              {
                handler.start_pair("Inline");
                handler.boolean_value(storeInline);
              }
            if (flagHasOutputParamOrderings)
              {
                handler.start_pair("OutputParamOrderings");
                storeOutputParamOrderings.write(handler);
              }
            if (flagHasVersion)
              {
                handler.start_pair("Version");
                handler.number_value(storeVersion);
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

        public static TypeFormatJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeFormatJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFormat", ignore_extras);
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
        public static TypeFormatJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeFormatJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeFormatJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFormat", ignore_extras);
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
        public static TypeFormatJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeFormatJSON from_text(string text, bool ignore_extras)
          {
            TypeFormatJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFormat", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeFormatJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeFormatJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeFormatJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFormat", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorInline;
            private JSONHoldingObjectValueGenerator fieldGeneratorOutputParamOrderings;
        private class FieldHoldingGeneratorVersion : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorVersion(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorVersion : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorVersion(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
            private FieldHoldingGeneratorVersion fieldGeneratorVersion;
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
                TypeFormatJSON result = new TypeFormatJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeFormatAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeFormatJSON result)
              {
                if (fieldGeneratorInline.have_value)
                  {
                    result.setInline(fieldGeneratorInline.value);
                    fieldGeneratorInline.have_value = false;
                  }
                if (fieldGeneratorOutputParamOrderings.have_value)
                  {
                    result.setOutputParamOrderings(fieldGeneratorOutputParamOrderings.value);
                    fieldGeneratorOutputParamOrderings.have_value = false;
                  }
                if (fieldGeneratorVersion.have_value)
                  {
                    result.setVersion(fieldGeneratorVersion.value);
                    fieldGeneratorVersion.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeFormatJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'I':
                        if ((String.Compare(field_name, 1, "nline", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorInline;
                        break;
                    case 'O':
                        if ((String.Compare(field_name, 1, "utputParamOrderings", 0, 19, false) == 0) && (field_name.Length == 20))
                            return fieldGeneratorOutputParamOrderings;
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "ersion", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorVersion;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorInline = new JSONHoldingBooleanGenerator("field \"Inline\" of the TypeFormat class");
                fieldGeneratorOutputParamOrderings = new JSONHoldingObjectValueGenerator("field \"OutputParamOrderings\" of the TypeFormat class");
                fieldGeneratorVersion = new FieldHoldingGeneratorVersion("field \"Version\" of the TypeFormat class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeFormat class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorInline = new JSONHoldingBooleanGenerator("field \"Inline\" of the TypeFormat class");
                fieldGeneratorOutputParamOrderings = new JSONHoldingObjectValueGenerator("field \"OutputParamOrderings\" of the TypeFormat class");
                fieldGeneratorVersion = new FieldHoldingGeneratorVersion("field \"Version\" of the TypeFormat class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeFormat class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorInline.reset();
                fieldGeneratorOutputParamOrderings.reset();
                fieldGeneratorVersion.reset();
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
            protected override void handle_result(TypeFormatJSON  result)
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
            public TypeFormatJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeFormatJSON  result)
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
        protected virtual void handle_result(List<TypeFormatJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeFormatJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeFormatJSON>();
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
        public List<TypeFormatJSON> value;
      };
      };
    private bool flagHasSource;
    private UploadedCodeSourceJSON  storeSource;
    private bool flagHasFormat;
    private TypeFormatJSON  storeFormat;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeSourceJSON convert_classy = UploadedCodeSourceJSON.from_json(json_value, ignore_extras, true);
        setSource(convert_classy);
      }


    private void  fromJSONFormat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeFormatJSON convert_classy = TypeFormatJSON.from_json(json_value, ignore_extras, true);
        setFormat(convert_classy);
      }


    public UploadedTestFileMetadataJSON()
      {
        flagHasSource = false;
        flagHasFormat = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSource()
      {
        return flagHasSource;
      }

    public UploadedCodeSourceJSON   getSource()
      {
        Debug.Assert(flagHasSource);
        return storeSource;
      }

    public bool  hasFormat()
      {
        return flagHasFormat;
      }

    public TypeFormatJSON   getFormat()
      {
        Debug.Assert(flagHasFormat);
        return storeFormat;
      }


    public virtual int extraUploadedTestFileMetadataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUploadedTestFileMetadataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUploadedTestFileMetadataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUploadedTestFileMetadataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSource(UploadedCodeSourceJSON  new_value)
      {
        if (flagHasSource)
          {
          }
        flagHasSource = true;
        storeSource = new_value;
      }
    public void unsetSource()
      {
        if (flagHasSource)
          {
          }
        flagHasSource = false;
      }
    public void setFormat(TypeFormatJSON  new_value)
      {
        if (flagHasFormat)
          {
          }
        flagHasFormat = true;
        storeFormat = new_value;
      }
    public void unsetFormat()
      {
        if (flagHasFormat)
          {
          }
        flagHasFormat = false;
      }

    public virtual void extraUploadedTestFileMetadataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUploadedTestFileMetadataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUploadedTestFileMetadataLookup(key);
        if (old_field == null)
          {
            extraUploadedTestFileMetadataAppendPair(key, new_component);
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
        if (flagHasSource)
          {
            handler.start_pair("Source");
            if (partial_allowed)
                storeSource.write_partial_as_json(handler);
            else
                storeSource.write_as_json(handler);
          }
        if (flagHasFormat)
          {
            handler.start_pair("Format");
            if (partial_allowed)
                storeFormat.write_partial_as_json(handler);
            else
                storeFormat.write_as_json(handler);
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

    public static UploadedTestFileMetadataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedTestFileMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestFileMetadata", ignore_extras);
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
    public static UploadedTestFileMetadataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedTestFileMetadataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedTestFileMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestFileMetadata", ignore_extras);
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
    public static UploadedTestFileMetadataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedTestFileMetadataJSON from_text(string text, bool ignore_extras)
      {
        UploadedTestFileMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestFileMetadata", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UploadedTestFileMetadataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UploadedTestFileMetadataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UploadedTestFileMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestFileMetadata", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UploadedCodeSourceJSON.HoldingGenerator fieldGeneratorSource;
        private TypeFormatJSON.HoldingGenerator fieldGeneratorFormat;
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
            UploadedTestFileMetadataJSON result = new UploadedTestFileMetadataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUploadedTestFileMetadataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UploadedTestFileMetadataJSON result)
          {
            if (fieldGeneratorSource.have_value)
              {
                result.setSource(fieldGeneratorSource.value);
                fieldGeneratorSource.have_value = false;
              }
            if (fieldGeneratorFormat.have_value)
              {
                result.setFormat(fieldGeneratorFormat.value);
                fieldGeneratorFormat.have_value = false;
              }
          }
        protected abstract void handle_result(UploadedTestFileMetadataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "ormat", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorFormat;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ource", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSource;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"Source\" of the UploadedTestFileMetadata class", ignore_extras);
            fieldGeneratorFormat = new TypeFormatJSON.HoldingGenerator("field \"Format\" of the UploadedTestFileMetadata class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UploadedTestFileMetadata class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"Source\" of the UploadedTestFileMetadata class", false);
            fieldGeneratorFormat = new TypeFormatJSON.HoldingGenerator("field \"Format\" of the UploadedTestFileMetadata class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UploadedTestFileMetadata class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSource.reset();
            fieldGeneratorFormat.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSource.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFormat.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSource.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFormat.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UploadedTestFileMetadataJSON  result)
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
        public UploadedTestFileMetadataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UploadedTestFileMetadataJSON  result)
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
    protected virtual void handle_result(List<UploadedTestFileMetadataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UploadedTestFileMetadataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UploadedTestFileMetadataJSON>();
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
    public List<UploadedTestFileMetadataJSON> value;
  };
  };
