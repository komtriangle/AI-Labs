/* file "SpeechToTextOnlyCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SpeechToTextOnlyCommandJSON : CommandResultJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasRawTranscription;
        private string storeRawTranscription;
        private bool flagHasFormattedTranscription;
        private string storeFormattedTranscription;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONRawTranscription(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field RawTranscription of TypeNativeDataJSON is not a string.");
            setRawTranscription(json_string.getData());
          }


        private void  fromJSONFormattedTranscription(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field FormattedTranscription of TypeNativeDataJSON is not a string.");
            setFormattedTranscription(json_string.getData());
          }


        public TypeNativeDataJSON()
          {
            flagHasRawTranscription = false;
            flagHasFormattedTranscription = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasRawTranscription()
          {
            return flagHasRawTranscription;
          }

        public string  getRawTranscription()
          {
            Debug.Assert(flagHasRawTranscription);
            return storeRawTranscription;
          }

        public bool  hasFormattedTranscription()
          {
            return flagHasFormattedTranscription;
          }

        public string  getFormattedTranscription()
          {
            Debug.Assert(flagHasFormattedTranscription);
            return storeFormattedTranscription;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setRawTranscription(string new_value)
          {
            flagHasRawTranscription = true;
            storeRawTranscription = new_value;
          }
        public void unsetRawTranscription()
          {
            flagHasRawTranscription = false;
          }
        public void setFormattedTranscription(string new_value)
          {
            flagHasFormattedTranscription = true;
            storeFormattedTranscription = new_value;
          }
        public void unsetFormattedTranscription()
          {
            flagHasFormattedTranscription = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasRawTranscription);
            if (flagHasRawTranscription)
              {
                handler.start_pair("RawTranscription");
                handler.string_value(storeRawTranscription);
              }
            Debug.Assert(partial_allowed || flagHasFormattedTranscription);
            if (flagHasFormattedTranscription)
              {
                handler.start_pair("FormattedTranscription");
                handler.string_value(storeFormattedTranscription);
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
            if (!(hasRawTranscription()))
              {
                return "When parsing the object for %what%, the \"RawTranscription\" field was missing.";
              }
            if (!(hasFormattedTranscription()))
              {
                return "When parsing the object for %what%, the \"FormattedTranscription\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorRawTranscription;
            private JSONHoldingStringGenerator fieldGeneratorFormattedTranscription;
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorRawTranscription.have_value)
                  {
                    result.setRawTranscription(fieldGeneratorRawTranscription.value);
                    fieldGeneratorRawTranscription.have_value = false;
                  }
                else if ((!(result.hasRawTranscription())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"RawTranscription\" field was missing.");
                  }
                if (fieldGeneratorFormattedTranscription.have_value)
                  {
                    result.setFormattedTranscription(fieldGeneratorFormattedTranscription.value);
                    fieldGeneratorFormattedTranscription.have_value = false;
                  }
                else if ((!(result.hasFormattedTranscription())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"FormattedTranscription\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'F':
                        if ((String.Compare(field_name, 1, "ormattedTranscription", 0, 21, false) == 0) && (field_name.Length == 22))
                            return fieldGeneratorFormattedTranscription;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "awTranscription", 0, 15, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorRawTranscription;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorRawTranscription = new JSONHoldingStringGenerator("field \"RawTranscription\" of the TypeNativeData class");
                fieldGeneratorFormattedTranscription = new JSONHoldingStringGenerator("field \"FormattedTranscription\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorRawTranscription = new JSONHoldingStringGenerator("field \"RawTranscription\" of the TypeNativeData class");
                fieldGeneratorFormattedTranscription = new JSONHoldingStringGenerator("field \"FormattedTranscription\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorRawTranscription.reset();
                fieldGeneratorFormattedTranscription.reset();
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
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasRawTranscription;
    private string storeRawTranscription;
    private bool flagHasFormattedTranscription;
    private string storeFormattedTranscription;
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRawTranscriptionToJSON()
      {
        JSONStringValue generated_string_RawTranscription = new JSONStringValue(storeRawTranscription);
        return generated_string_RawTranscription;
      }

    private JSONValue  extraFormattedTranscriptionToJSON()
      {
        JSONStringValue generated_string_FormattedTranscription = new JSONStringValue(storeFormattedTranscription);
        return generated_string_FormattedTranscription;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONRawTranscription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RawTranscription of SpeechToTextOnlyCommandJSON is not a string.");
        setRawTranscription(json_string.getData());
      }


    private void  fromJSONFormattedTranscription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FormattedTranscription of SpeechToTextOnlyCommandJSON is not a string.");
        setFormattedTranscription(json_string.getData());
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public SpeechToTextOnlyCommandJSON()
      {
        flagHasRawTranscription = false;
        flagHasFormattedTranscription = false;
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "SpeechToTextOnlyCommand";
      }

    public bool  hasRawTranscription()
      {
        return flagHasRawTranscription;
      }

    public string  getRawTranscription()
      {
        Debug.Assert(flagHasRawTranscription);
        return storeRawTranscription;
      }

    public bool  hasFormattedTranscription()
      {
        return flagHasFormattedTranscription;
      }

    public string  getFormattedTranscription()
      {
        Debug.Assert(flagHasFormattedTranscription);
        return storeFormattedTranscription;
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public virtual int extraSpeechToTextOnlyCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSpeechToTextOnlyCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSpeechToTextOnlyCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSpeechToTextOnlyCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasRawTranscription)
            ++result;
        if (flagHasFormattedTranscription)
            ++result;
        if (flagHasNativeData)
            ++result;
        result += extraSpeechToTextOnlyCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRawTranscription)
          {
            if (remainder == 0)
                return "RawTranscription";
            --remainder;
          }
        if (flagHasFormattedTranscription)
          {
            if (remainder == 0)
                return "FormattedTranscription";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraSpeechToTextOnlyCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRawTranscription)
          {
            if (remainder == 0)
                return extraRawTranscriptionToJSON();
            --remainder;
          }
        if (flagHasFormattedTranscription)
          {
            if (remainder == 0)
                return extraFormattedTranscriptionToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraSpeechToTextOnlyCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'F':
                if ((String.Compare(field_name, 1, "ormattedTranscription", 0, 21, false) == 0) && (field_name.Length == 22))
                    return (flagHasFormattedTranscription ? extraFormattedTranscriptionToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNativeData ? extraNativeDataToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "awTranscription", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasRawTranscription ? extraRawTranscriptionToJSON() : null);
                break;
            default:
                break;
          }
        return extraSpeechToTextOnlyCommandLookup(field_name);
      }

    public void setRawTranscription(string new_value)
      {
        flagHasRawTranscription = true;
        storeRawTranscription = new_value;
      }
    public void unsetRawTranscription()
      {
        flagHasRawTranscription = false;
      }
    public void setFormattedTranscription(string new_value)
      {
        flagHasFormattedTranscription = true;
        storeFormattedTranscription = new_value;
      }
    public void unsetFormattedTranscription()
      {
        flagHasFormattedTranscription = false;
      }
    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public virtual void extraSpeechToTextOnlyCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSpeechToTextOnlyCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSpeechToTextOnlyCommandLookup(key);
        if (old_field == null)
          {
            extraSpeechToTextOnlyCommandAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                if ((String.Compare(key, 1, "ormattedTranscription", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONFormattedTranscription(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "awTranscription", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONRawTranscription(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSpeechToTextOnlyCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                if ((String.Compare(key, 1, "ormattedTranscription", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONFormattedTranscription(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "awTranscription", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONRawTranscription(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSpeechToTextOnlyCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRawTranscription);
        if (flagHasRawTranscription)
          {
            handler.start_pair("RawTranscription");
            handler.string_value(storeRawTranscription);
          }
        Debug.Assert(partial_allowed || flagHasFormattedTranscription);
        if (flagHasFormattedTranscription)
          {
            handler.start_pair("FormattedTranscription");
            handler.string_value(storeFormattedTranscription);
          }
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
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
        if (!(hasRawTranscription()))
          {
            return "When parsing the object for %what%, the \"RawTranscription\" field was missing.";
          }
        if (!(hasFormattedTranscription()))
          {
            return "When parsing the object for %what%, the \"FormattedTranscription\" field was missing.";
          }
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new SpeechToTextOnlyCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SpeechToTextOnlyCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SpeechToTextOnlyCommand", ignore_extras);
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
    public static new SpeechToTextOnlyCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SpeechToTextOnlyCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SpeechToTextOnlyCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SpeechToTextOnlyCommand", ignore_extras);
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
    public static new SpeechToTextOnlyCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SpeechToTextOnlyCommandJSON from_text(string text, bool ignore_extras)
      {
        SpeechToTextOnlyCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SpeechToTextOnlyCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SpeechToTextOnlyCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SpeechToTextOnlyCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SpeechToTextOnlyCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SpeechToTextOnlyCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorRawTranscription;
        private JSONHoldingStringGenerator fieldGeneratorFormattedTranscription;
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
            if (!(getCommandResultJSONKey().Equals("SpeechToTextOnlyCommand")))
                throw new Exception("The key field has a value other than `SpeechToTextOnlyCommand'.");
            SpeechToTextOnlyCommandJSON result = new SpeechToTextOnlyCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSpeechToTextOnlyCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((SpeechToTextOnlyCommandJSON )new_result);
          }
        protected void finish(SpeechToTextOnlyCommandJSON result)
          {
            if (fieldGeneratorRawTranscription.have_value)
              {
                result.setRawTranscription(fieldGeneratorRawTranscription.value);
                fieldGeneratorRawTranscription.have_value = false;
              }
            else if ((!(result.hasRawTranscription())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RawTranscription\" field was missing.");
              }
            if (fieldGeneratorFormattedTranscription.have_value)
              {
                result.setFormattedTranscription(fieldGeneratorFormattedTranscription.value);
                fieldGeneratorFormattedTranscription.have_value = false;
              }
            else if ((!(result.hasFormattedTranscription())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FormattedTranscription\" field was missing.");
              }
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SpeechToTextOnlyCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "ormattedTranscription", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorFormattedTranscription;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNativeData;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "awTranscription", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorRawTranscription;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRawTranscription = new JSONHoldingStringGenerator("field \"RawTranscription\" of the SpeechToTextOnlyCommand class");
            fieldGeneratorFormattedTranscription = new JSONHoldingStringGenerator("field \"FormattedTranscription\" of the SpeechToTextOnlyCommand class");
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the SpeechToTextOnlyCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SpeechToTextOnlyCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRawTranscription = new JSONHoldingStringGenerator("field \"RawTranscription\" of the SpeechToTextOnlyCommand class");
            fieldGeneratorFormattedTranscription = new JSONHoldingStringGenerator("field \"FormattedTranscription\" of the SpeechToTextOnlyCommand class");
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the SpeechToTextOnlyCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SpeechToTextOnlyCommand class");
          }

        public override void reset()
          {
            fieldGeneratorRawTranscription.reset();
            fieldGeneratorFormattedTranscription.reset();
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SpeechToTextOnlyCommandJSON  result)
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
        public SpeechToTextOnlyCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SpeechToTextOnlyCommandJSON  result)
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
    protected virtual void handle_result(List<SpeechToTextOnlyCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SpeechToTextOnlyCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SpeechToTextOnlyCommandJSON>();
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
    public List<SpeechToTextOnlyCommandJSON> value;
  };
  };
