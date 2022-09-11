/* file "LocalPlacesTagJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class LocalPlacesTagJSON : JSONBase
  {
    private bool flagHasSoundHoundKey;
    private string storeSoundHoundKey;
    private bool flagHasSpokenLabel;
    private string storeSpokenLabel;
    private bool flagHasWrittenLabel;
    private string storeWrittenLabel;
    private bool flagHasTagMappings;
    private List< LocalPlacesTagMappingBaseJSON  > storeTagMappings;


    private void  fromJSONSoundHoundKey(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SoundHoundKey of LocalPlacesTagJSON is not a string.");
        setSoundHoundKey(json_string.getData());
      }


    private void  fromJSONSpokenLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenLabel of LocalPlacesTagJSON is not a string.");
        setSpokenLabel(json_string.getData());
      }


    private void  fromJSONWrittenLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenLabel of LocalPlacesTagJSON is not a string.");
        setWrittenLabel(json_string.getData());
      }


    private void  fromJSONTagMappings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TagMappings of LocalPlacesTagJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< LocalPlacesTagMappingBaseJSON  > vector_TagMappings1 = new List< LocalPlacesTagMappingBaseJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            LocalPlacesTagMappingBaseJSON convert_classy = LocalPlacesTagMappingBaseJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_TagMappings1.Add(convert_classy);
          }
        initTagMappings();
        for (int num1 = 0; num1 < vector_TagMappings1.Count; ++num1)
            appendTagMappings(vector_TagMappings1[num1]);
        for (int num1 = 0; num1 < vector_TagMappings1.Count; ++num1)
          {
          }
      }


    public LocalPlacesTagJSON()
      {
        flagHasSoundHoundKey = false;
        flagHasSpokenLabel = false;
        flagHasWrittenLabel = false;
        flagHasTagMappings = false;
        storeTagMappings = new List< LocalPlacesTagMappingBaseJSON  >();
      }

    public abstract string getLocalPlacesTagKind();
    public bool  hasSoundHoundKey()
      {
        return flagHasSoundHoundKey;
      }

    public string  getSoundHoundKey()
      {
        Debug.Assert(flagHasSoundHoundKey);
        return storeSoundHoundKey;
      }

    public bool  hasSpokenLabel()
      {
        return flagHasSpokenLabel;
      }

    public string  getSpokenLabel()
      {
        Debug.Assert(flagHasSpokenLabel);
        return storeSpokenLabel;
      }

    public bool  hasWrittenLabel()
      {
        return flagHasWrittenLabel;
      }

    public string  getWrittenLabel()
      {
        Debug.Assert(flagHasWrittenLabel);
        return storeWrittenLabel;
      }

    public bool  hasTagMappings()
      {
        return flagHasTagMappings;
      }

    public int  countOfTagMappings()
      {
        Debug.Assert(flagHasTagMappings);
        return storeTagMappings.Count;
      }

    public LocalPlacesTagMappingBaseJSON   elementOfTagMappings(int element_num)
      {
        Debug.Assert(flagHasTagMappings);
        return storeTagMappings[element_num];
      }

    public List< LocalPlacesTagMappingBaseJSON  >  getTagMappings()
      {
        Debug.Assert(flagHasTagMappings);
        return storeTagMappings;
      }


    public abstract int extraLocalPlacesTagComponentCount();
    public abstract string extraLocalPlacesTagComponentKey(int component_num);
    public abstract JSONValue extraLocalPlacesTagComponentValue(int component_num);
    public abstract JSONValue extraLocalPlacesTagLookup(string field_name);

    public void setSoundHoundKey(string new_value)
      {
        flagHasSoundHoundKey = true;
        storeSoundHoundKey = new_value;
      }
    public void unsetSoundHoundKey()
      {
        flagHasSoundHoundKey = false;
      }
    public void setSpokenLabel(string new_value)
      {
        flagHasSpokenLabel = true;
        storeSpokenLabel = new_value;
      }
    public void unsetSpokenLabel()
      {
        flagHasSpokenLabel = false;
      }
    public void setWrittenLabel(string new_value)
      {
        flagHasWrittenLabel = true;
        storeWrittenLabel = new_value;
      }
    public void unsetWrittenLabel()
      {
        flagHasWrittenLabel = false;
      }
    public void initTagMappings()
      {
        if (flagHasTagMappings)
          {
            for (int num1 = 0; num1 < storeTagMappings.Count; ++num1)
              {
              }
          }
        flagHasTagMappings = true;
        storeTagMappings.Clear();
      }
    public void appendTagMappings(LocalPlacesTagMappingBaseJSON  to_append)
      {
        if (!flagHasTagMappings)
          {
            flagHasTagMappings = true;
            storeTagMappings.Clear();
          }
        Debug.Assert(flagHasTagMappings);
        storeTagMappings.Add(to_append);
      }
    public void unsetTagMappings()
      {
        if (flagHasTagMappings)
          {
            for (int num2 = 0; num2 < storeTagMappings.Count; ++num2)
              {
              }
          }
        flagHasTagMappings = false;
        storeTagMappings.Clear();
      }

    public abstract void extraLocalPlacesTagAppendPair(string key, JSONValue new_component);
    public abstract void extraLocalPlacesTagSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("LocalPlacesTagKind", getLocalPlacesTagKind());
        Debug.Assert(partial_allowed || flagHasSoundHoundKey);
        if (flagHasSoundHoundKey)
          {
            handler.start_pair("SoundHoundKey");
            handler.string_value(storeSoundHoundKey);
          }
        if (flagHasSpokenLabel)
          {
            handler.start_pair("SpokenLabel");
            handler.string_value(storeSpokenLabel);
          }
        if (flagHasWrittenLabel)
          {
            handler.start_pair("WrittenLabel");
            handler.string_value(storeWrittenLabel);
          }
        if (flagHasTagMappings)
          {
            handler.start_pair("TagMappings");
            handler.start_array();
            for (int num1 = 0; num1 < storeTagMappings.Count; ++num1)
              {
                if (partial_allowed)
                    storeTagMappings[num1].write_partial_as_json(handler);
                else
                    storeTagMappings[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasSoundHoundKey()))
          {
            return "When parsing the object for %what%, the \"SoundHoundKey\" field was missing.";
          }
        return null;
      }

    public static LocalPlacesTagJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalPlacesTagJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalPlacesTag", ignore_extras);
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
    public static LocalPlacesTagJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalPlacesTagJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalPlacesTagJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalPlacesTag", ignore_extras);
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
    public static LocalPlacesTagJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalPlacesTagJSON from_text(string text, bool ignore_extras)
      {
        LocalPlacesTagJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalPlacesTag", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LocalPlacesTagJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static LocalPlacesTagJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LocalPlacesTagJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalPlacesTag", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSoundHoundKey;
        private JSONHoldingStringGenerator fieldGeneratorSpokenLabel;
        private JSONHoldingStringGenerator fieldGeneratorWrittenLabel;
        private LocalPlacesTagMappingBaseJSON.HoldingArrayGenerator fieldGeneratorTagMappings;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `LocalPlacesTagKind' field is missing.");
            LocalPlacesTagJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLocalPlacesTagAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getLocalPlacesTagJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `LocalPlacesTagKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(LocalPlacesTagJSON result)
          {
            if (fieldGeneratorSoundHoundKey.have_value)
              {
                result.setSoundHoundKey(fieldGeneratorSoundHoundKey.value);
                fieldGeneratorSoundHoundKey.have_value = false;
              }
            else if ((!(result.hasSoundHoundKey())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SoundHoundKey\" field was missing.");
              }
            if (fieldGeneratorSpokenLabel.have_value)
              {
                result.setSpokenLabel(fieldGeneratorSpokenLabel.value);
                fieldGeneratorSpokenLabel.have_value = false;
              }
            if (fieldGeneratorWrittenLabel.have_value)
              {
                result.setWrittenLabel(fieldGeneratorWrittenLabel.value);
                fieldGeneratorWrittenLabel.have_value = false;
              }
            if (fieldGeneratorTagMappings.have_value)
              {
                result.initTagMappings();
                int count = fieldGeneratorTagMappings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTagMappings(fieldGeneratorTagMappings.value[num]);
                  }
                fieldGeneratorTagMappings.value.Clear();
                fieldGeneratorTagMappings.have_value = false;
              }
          }
        protected abstract void handle_result(LocalPlacesTagJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "ocalPlacesTagKind", 0, 17, false) == 0) && (field_name.Length == 18))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 2, "undHoundKey", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorSoundHoundKey;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenLabel", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorSpokenLabel;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "agMappings", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorTagMappings;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenLabel", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorWrittenLabel;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSoundHoundKey = new JSONHoldingStringGenerator("field \"SoundHoundKey\" of the LocalPlacesTag class");
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the LocalPlacesTag class");
            fieldGeneratorWrittenLabel = new JSONHoldingStringGenerator("field \"WrittenLabel\" of the LocalPlacesTag class");
            fieldGeneratorTagMappings = new LocalPlacesTagMappingBaseJSON.HoldingArrayGenerator("field \"TagMappings\" of the LocalPlacesTag class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"LocalPlacesTagKind\" of the LocalPlacesTag class");
            set_what("the LocalPlacesTag class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSoundHoundKey = new JSONHoldingStringGenerator("field \"SoundHoundKey\" of the LocalPlacesTag class");
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the LocalPlacesTag class");
            fieldGeneratorWrittenLabel = new JSONHoldingStringGenerator("field \"WrittenLabel\" of the LocalPlacesTag class");
            fieldGeneratorTagMappings = new LocalPlacesTagMappingBaseJSON.HoldingArrayGenerator("field \"TagMappings\" of the LocalPlacesTag class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"LocalPlacesTagKind\" of the LocalPlacesTag class");
            set_what("the LocalPlacesTag class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSoundHoundKey.reset();
            fieldGeneratorSpokenLabel.reset();
            fieldGeneratorWrittenLabel.reset();
            fieldGeneratorTagMappings.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTagMappings.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTagMappings.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(LocalPlacesTagJSON  result)
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
        public LocalPlacesTagJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LocalPlacesTagJSON  result)
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
    protected virtual void handle_result(List<LocalPlacesTagJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LocalPlacesTagJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LocalPlacesTagJSON>();
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
    public List<LocalPlacesTagJSON> value;
  };
    class GenericLocalPlacesTagJSON : LocalPlacesTagJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericLocalPlacesTagJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getLocalPlacesTagKind()  { return key; }
        public override int extraLocalPlacesTagComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraLocalPlacesTagComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraLocalPlacesTagComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraLocalPlacesTagLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraLocalPlacesTagAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraLocalPlacesTagSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraLocalPlacesTagLookup(key);
            if (old_field == null)
              {
                extraLocalPlacesTagAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static LocalPlacesTagJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {

        return new GenericLocalPlacesTagJSON(key);
      }
  };
