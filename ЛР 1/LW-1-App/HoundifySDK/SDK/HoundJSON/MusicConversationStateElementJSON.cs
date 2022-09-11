/* file "MusicConversationStateElementJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class MusicConversationStateElementJSON : JSONBase
  {
    private bool flagHasMusicSearchCriteria;
    private MusicSearchCriteriaJSON  storeMusicSearchCriteria;
    private bool flagHasUserRequestedAutoPlay;
    private bool storeUserRequestedAutoPlay;
    private bool flagHasResultIdLists;
    private MusicSearchResultsJSON  storeResultIdLists;
    private bool flagHasLastResultIdLists;
    private MusicSearchResultsJSON  storeLastResultIdLists;


    private void  fromJSONMusicSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicSearchCriteriaJSON convert_classy = MusicSearchCriteriaJSON.from_json(json_value, ignore_extras, true);
        setMusicSearchCriteria(convert_classy);
      }


    private void  fromJSONUserRequestedAutoPlay(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedAutoPlay of MusicConversationStateElementJSON is not true for false.");
              }
          }
        setUserRequestedAutoPlay(the_bool);
      }


    private void  fromJSONResultIdLists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicSearchResultsJSON convert_classy = MusicSearchResultsJSON.from_json(json_value, ignore_extras, true);
        setResultIdLists(convert_classy);
      }


    private void  fromJSONLastResultIdLists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicSearchResultsJSON convert_classy = MusicSearchResultsJSON.from_json(json_value, ignore_extras, true);
        setLastResultIdLists(convert_classy);
      }


    public MusicConversationStateElementJSON()
      {
        flagHasMusicSearchCriteria = false;
        flagHasUserRequestedAutoPlay = false;
        flagHasResultIdLists = false;
        flagHasLastResultIdLists = false;
      }

    public abstract string getMusicConversationStateElementKind();
    public bool  hasMusicSearchCriteria()
      {
        return flagHasMusicSearchCriteria;
      }

    public MusicSearchCriteriaJSON   getMusicSearchCriteria()
      {
        Debug.Assert(flagHasMusicSearchCriteria);
        return storeMusicSearchCriteria;
      }

    public bool  hasUserRequestedAutoPlay()
      {
        return flagHasUserRequestedAutoPlay;
      }

    public bool  getUserRequestedAutoPlay()
      {
        Debug.Assert(flagHasUserRequestedAutoPlay);
        return storeUserRequestedAutoPlay;
      }

    public bool  hasResultIdLists()
      {
        return flagHasResultIdLists;
      }

    public MusicSearchResultsJSON   getResultIdLists()
      {
        Debug.Assert(flagHasResultIdLists);
        return storeResultIdLists;
      }

    public bool  hasLastResultIdLists()
      {
        return flagHasLastResultIdLists;
      }

    public MusicSearchResultsJSON   getLastResultIdLists()
      {
        Debug.Assert(flagHasLastResultIdLists);
        return storeLastResultIdLists;
      }


    public abstract int extraMusicConversationStateElementComponentCount();
    public abstract string extraMusicConversationStateElementComponentKey(int component_num);
    public abstract JSONValue extraMusicConversationStateElementComponentValue(int component_num);
    public abstract JSONValue extraMusicConversationStateElementLookup(string field_name);

    public void setMusicSearchCriteria(MusicSearchCriteriaJSON  new_value)
      {
        if (flagHasMusicSearchCriteria)
          {
          }
        flagHasMusicSearchCriteria = true;
        storeMusicSearchCriteria = new_value;
      }
    public void unsetMusicSearchCriteria()
      {
        if (flagHasMusicSearchCriteria)
          {
          }
        flagHasMusicSearchCriteria = false;
      }
    public void setUserRequestedAutoPlay(bool new_value)
      {
        flagHasUserRequestedAutoPlay = true;
        storeUserRequestedAutoPlay = new_value;
      }
    public void unsetUserRequestedAutoPlay()
      {
        flagHasUserRequestedAutoPlay = false;
      }
    public void setResultIdLists(MusicSearchResultsJSON  new_value)
      {
        if (flagHasResultIdLists)
          {
          }
        flagHasResultIdLists = true;
        storeResultIdLists = new_value;
      }
    public void unsetResultIdLists()
      {
        if (flagHasResultIdLists)
          {
          }
        flagHasResultIdLists = false;
      }
    public void setLastResultIdLists(MusicSearchResultsJSON  new_value)
      {
        if (flagHasLastResultIdLists)
          {
          }
        flagHasLastResultIdLists = true;
        storeLastResultIdLists = new_value;
      }
    public void unsetLastResultIdLists()
      {
        if (flagHasLastResultIdLists)
          {
          }
        flagHasLastResultIdLists = false;
      }

    public abstract void extraMusicConversationStateElementAppendPair(string key, JSONValue new_component);
    public abstract void extraMusicConversationStateElementSetField(string key, JSONValue new_component);

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
        handler.pair("MusicConversationStateElementKind", getMusicConversationStateElementKind());
        if (flagHasMusicSearchCriteria)
          {
            handler.start_pair("MusicSearchCriteria");
            if (partial_allowed)
                storeMusicSearchCriteria.write_partial_as_json(handler);
            else
                storeMusicSearchCriteria.write_as_json(handler);
          }
        if (flagHasUserRequestedAutoPlay)
          {
            handler.start_pair("UserRequestedAutoPlay");
            handler.boolean_value(storeUserRequestedAutoPlay);
          }
        if (flagHasResultIdLists)
          {
            handler.start_pair("ResultIdLists");
            if (partial_allowed)
                storeResultIdLists.write_partial_as_json(handler);
            else
                storeResultIdLists.write_as_json(handler);
          }
        if (flagHasLastResultIdLists)
          {
            handler.start_pair("LastResultIdLists");
            if (partial_allowed)
                storeLastResultIdLists.write_partial_as_json(handler);
            else
                storeLastResultIdLists.write_as_json(handler);
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
        return null;
      }

    public static MusicConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicConversationStateElement", ignore_extras);
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
    public static MusicConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicConversationStateElement", ignore_extras);
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
    public static MusicConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicConversationStateElementJSON from_text(string text, bool ignore_extras)
      {
        MusicConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicConversationStateElementJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicConversationStateElementJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MusicSearchCriteriaJSON.HoldingGenerator fieldGeneratorMusicSearchCriteria;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedAutoPlay;
        private MusicSearchResultsJSON.HoldingGenerator fieldGeneratorResultIdLists;
        private MusicSearchResultsJSON.HoldingGenerator fieldGeneratorLastResultIdLists;
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
                throw new Exception("The `MusicConversationStateElementKind' field is missing.");
            MusicConversationStateElementJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicConversationStateElementAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getMusicConversationStateElementJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `MusicConversationStateElementKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(MusicConversationStateElementJSON result)
          {
            if (fieldGeneratorMusicSearchCriteria.have_value)
              {
                result.setMusicSearchCriteria(fieldGeneratorMusicSearchCriteria.value);
                fieldGeneratorMusicSearchCriteria.have_value = false;
              }
            if (fieldGeneratorUserRequestedAutoPlay.have_value)
              {
                result.setUserRequestedAutoPlay(fieldGeneratorUserRequestedAutoPlay.value);
                fieldGeneratorUserRequestedAutoPlay.have_value = false;
              }
            if (fieldGeneratorResultIdLists.have_value)
              {
                result.setResultIdLists(fieldGeneratorResultIdLists.value);
                fieldGeneratorResultIdLists.have_value = false;
              }
            if (fieldGeneratorLastResultIdLists.have_value)
              {
                result.setLastResultIdLists(fieldGeneratorLastResultIdLists.value);
                fieldGeneratorLastResultIdLists.have_value = false;
              }
          }
        protected abstract void handle_result(MusicConversationStateElementJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "astResultIdLists", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorLastResultIdLists;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "usic", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 6, "onversationStateElementKind", 0, 27, false) == 0) && (field_name.Length == 33))
                                    {
                                    keyGenerator.reset();
                                    return keyGenerator;
                                    }
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 6, "earchCriteria", 0, 13, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorMusicSearchCriteria;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esultIdLists", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorResultIdLists;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serRequestedAutoPlay", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorUserRequestedAutoPlay;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMusicSearchCriteria = new MusicSearchCriteriaJSON.HoldingGenerator("field \"MusicSearchCriteria\" of the MusicConversationStateElement class", ignore_extras);
            fieldGeneratorUserRequestedAutoPlay = new JSONHoldingBooleanGenerator("field \"UserRequestedAutoPlay\" of the MusicConversationStateElement class");
            fieldGeneratorResultIdLists = new MusicSearchResultsJSON.HoldingGenerator("field \"ResultIdLists\" of the MusicConversationStateElement class", ignore_extras);
            fieldGeneratorLastResultIdLists = new MusicSearchResultsJSON.HoldingGenerator("field \"LastResultIdLists\" of the MusicConversationStateElement class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"MusicConversationStateElementKind\" of the MusicConversationStateElement class");
            set_what("the MusicConversationStateElement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMusicSearchCriteria = new MusicSearchCriteriaJSON.HoldingGenerator("field \"MusicSearchCriteria\" of the MusicConversationStateElement class", false);
            fieldGeneratorUserRequestedAutoPlay = new JSONHoldingBooleanGenerator("field \"UserRequestedAutoPlay\" of the MusicConversationStateElement class");
            fieldGeneratorResultIdLists = new MusicSearchResultsJSON.HoldingGenerator("field \"ResultIdLists\" of the MusicConversationStateElement class", false);
            fieldGeneratorLastResultIdLists = new MusicSearchResultsJSON.HoldingGenerator("field \"LastResultIdLists\" of the MusicConversationStateElement class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"MusicConversationStateElementKind\" of the MusicConversationStateElement class");
            set_what("the MusicConversationStateElement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMusicSearchCriteria.reset();
            fieldGeneratorUserRequestedAutoPlay.reset();
            fieldGeneratorResultIdLists.reset();
            fieldGeneratorLastResultIdLists.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMusicSearchCriteria.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorResultIdLists.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLastResultIdLists.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMusicSearchCriteria.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorResultIdLists.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLastResultIdLists.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicConversationStateElementJSON  result)
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
        public MusicConversationStateElementJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicConversationStateElementJSON  result)
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
    protected virtual void handle_result(List<MusicConversationStateElementJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicConversationStateElementJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicConversationStateElementJSON>();
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
    public List<MusicConversationStateElementJSON> value;
  };
    class GenericMusicConversationStateElementJSON : MusicConversationStateElementJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericMusicConversationStateElementJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getMusicConversationStateElementKind()  { return key; }
        public override int extraMusicConversationStateElementComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraMusicConversationStateElementComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraMusicConversationStateElementComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraMusicConversationStateElementLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraMusicConversationStateElementAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraMusicConversationStateElementSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraMusicConversationStateElementLookup(key);
            if (old_field == null)
              {
                extraMusicConversationStateElementAppendPair(key, new_component);
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
    public static MusicConversationStateElementJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'G':
            if ((String.Compare(key, 1, "uessThatLyricConversationStateElement", 0, 37, false) == 0) && (key.Length == 38))
                return new GuessThatLyricConversationStateElementJSON();
            break;
        case 'M':
            if (String.Compare(key, 1, "usic", 0, 4, false) == 0)
              {
                switch (key[5])
                  {
                    case 'C':
                        if ((String.Compare(key, 6, "hartsCommandConversationStateElement", 0, 36, false) == 0) && (key.Length == 42))
                            return new MusicChartsCommandConversationStateElementJSON();
                        break;
                    case 'P':
                        if ((String.Compare(key, 6, "layerCommandConversationStateElement", 0, 36, false) == 0) && (key.Length == 42))
                            return new MusicPlayerCommandConversationStateElementJSON();
                        break;
                    case 'S':
                        if ((String.Compare(key, 6, "earchCommandConversationStateElement", 0, 36, false) == 0) && (key.Length == 42))
                            return new MusicSearchCommandConversationStateElementJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        default:
            break;
      }

        return new GenericMusicConversationStateElementJSON(key);
      }
  };
