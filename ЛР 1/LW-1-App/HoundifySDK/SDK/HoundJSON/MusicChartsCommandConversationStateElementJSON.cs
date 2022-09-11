/* file "MusicChartsCommandConversationStateElementJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicChartsCommandConversationStateElementJSON : MusicConversationStateElementJSON
  {
    private bool flagHasMusicChartsSearchCriteria;
    private MusicChartsSearchCriteriaJSON  storeMusicChartsSearchCriteria;
    private bool flagHasMusicChartsSearchCriteriaAdditional;
    private MusicChartsSearchCriteriaAdditionalJSON  storeMusicChartsSearchCriteriaAdditional;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraMusicChartsSearchCriteriaToJSON()
      {
        JSONValueHandler handler_MusicChartsSearchCriteria = new JSONValueHandler();
        storeMusicChartsSearchCriteria.write_as_json(handler_MusicChartsSearchCriteria);
        return handler_MusicChartsSearchCriteria.result;
      }

    private JSONValue  extraMusicChartsSearchCriteriaAdditionalToJSON()
      {
        JSONValueHandler handler_MusicChartsSearchCriteriaAdditional = new JSONValueHandler();
        storeMusicChartsSearchCriteriaAdditional.write_as_json(handler_MusicChartsSearchCriteriaAdditional);
        return handler_MusicChartsSearchCriteriaAdditional.result;
      }


    private void  fromJSONMusicChartsSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicChartsSearchCriteriaJSON convert_classy = MusicChartsSearchCriteriaJSON.from_json(json_value, ignore_extras, true);
        setMusicChartsSearchCriteria(convert_classy);
      }


    private void  fromJSONMusicChartsSearchCriteriaAdditional(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicChartsSearchCriteriaAdditionalJSON convert_classy = MusicChartsSearchCriteriaAdditionalJSON.from_json(json_value, ignore_extras, true);
        setMusicChartsSearchCriteriaAdditional(convert_classy);
      }


    public MusicChartsCommandConversationStateElementJSON()
      {
        flagHasMusicChartsSearchCriteria = false;
        flagHasMusicChartsSearchCriteriaAdditional = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getMusicConversationStateElementKind()
      {
        return "MusicChartsCommandConversationStateElement";
      }

    public bool  hasMusicChartsSearchCriteria()
      {
        return flagHasMusicChartsSearchCriteria;
      }

    public MusicChartsSearchCriteriaJSON   getMusicChartsSearchCriteria()
      {
        Debug.Assert(flagHasMusicChartsSearchCriteria);
        return storeMusicChartsSearchCriteria;
      }

    public bool  hasMusicChartsSearchCriteriaAdditional()
      {
        return flagHasMusicChartsSearchCriteriaAdditional;
      }

    public MusicChartsSearchCriteriaAdditionalJSON   getMusicChartsSearchCriteriaAdditional()
      {
        Debug.Assert(flagHasMusicChartsSearchCriteriaAdditional);
        return storeMusicChartsSearchCriteriaAdditional;
      }


    public virtual int extraMusicChartsCommandConversationStateElementComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMusicChartsCommandConversationStateElementComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMusicChartsCommandConversationStateElementComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMusicChartsCommandConversationStateElementLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMusicConversationStateElementComponentCount()
      {
        int result = 0;
        if (flagHasMusicChartsSearchCriteria)
            ++result;
        if (flagHasMusicChartsSearchCriteriaAdditional)
            ++result;
        result += extraMusicChartsCommandConversationStateElementComponentCount();
        return result;
      }
    public override string extraMusicConversationStateElementComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasMusicChartsSearchCriteria)
          {
            if (remainder == 0)
                return "MusicChartsSearchCriteria";
            --remainder;
          }
        if (flagHasMusicChartsSearchCriteriaAdditional)
          {
            if (remainder == 0)
                return "MusicChartsSearchCriteriaAdditional";
            --remainder;
          }
        return extraMusicChartsCommandConversationStateElementComponentKey(remainder);
      }
    public override JSONValue extraMusicConversationStateElementComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasMusicChartsSearchCriteria)
          {
            if (remainder == 0)
                return extraMusicChartsSearchCriteriaToJSON();
            --remainder;
          }
        if (flagHasMusicChartsSearchCriteriaAdditional)
          {
            if (remainder == 0)
                return extraMusicChartsSearchCriteriaAdditionalToJSON();
            --remainder;
          }
        return extraMusicChartsCommandConversationStateElementComponentValue(remainder);
      }
    public override JSONValue extraMusicConversationStateElementLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "MusicChartsSearchCriteria", 0, 25, false) == 0)
          {
            if (field_name.Length == 25)
              {
                return (flagHasMusicChartsSearchCriteria ? extraMusicChartsSearchCriteriaToJSON() : null);
              }
            switch (field_name[25])
              {
                case 'A':
                    if ((String.Compare(field_name, 26, "dditional", 0, 9, false) == 0) && (field_name.Length == 35))
                        return (flagHasMusicChartsSearchCriteriaAdditional ? extraMusicChartsSearchCriteriaAdditionalToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraMusicChartsCommandConversationStateElementLookup(field_name);
      }

    public void setMusicChartsSearchCriteria(MusicChartsSearchCriteriaJSON  new_value)
      {
        if (flagHasMusicChartsSearchCriteria)
          {
          }
        flagHasMusicChartsSearchCriteria = true;
        storeMusicChartsSearchCriteria = new_value;
      }
    public void unsetMusicChartsSearchCriteria()
      {
        if (flagHasMusicChartsSearchCriteria)
          {
          }
        flagHasMusicChartsSearchCriteria = false;
      }
    public void setMusicChartsSearchCriteriaAdditional(MusicChartsSearchCriteriaAdditionalJSON  new_value)
      {
        if (flagHasMusicChartsSearchCriteriaAdditional)
          {
          }
        flagHasMusicChartsSearchCriteriaAdditional = true;
        storeMusicChartsSearchCriteriaAdditional = new_value;
      }
    public void unsetMusicChartsSearchCriteriaAdditional()
      {
        if (flagHasMusicChartsSearchCriteriaAdditional)
          {
          }
        flagHasMusicChartsSearchCriteriaAdditional = false;
      }

    public virtual void extraMusicChartsCommandConversationStateElementAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMusicChartsCommandConversationStateElementSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMusicChartsCommandConversationStateElementLookup(key);
        if (old_field == null)
          {
            extraMusicChartsCommandConversationStateElementAppendPair(key, new_component);
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
    public override void extraMusicConversationStateElementAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "MusicChartsSearchCriteria", 0, 25, false) == 0)
          {
            if (key.Length == 25)
              {
                {
                fromJSONMusicChartsSearchCriteria(new_component, false);
                return;
                }
              }
            switch (key[25])
              {
                case 'A':
                    if ((String.Compare(key, 26, "dditional", 0, 9, false) == 0) && (key.Length == 35))
                        {
                        fromJSONMusicChartsSearchCriteriaAdditional(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraMusicChartsCommandConversationStateElementAppendPair(key, new_component);
      }
    public override void extraMusicConversationStateElementSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "MusicChartsSearchCriteria", 0, 25, false) == 0)
          {
            if (key.Length == 25)
              {
                {
                fromJSONMusicChartsSearchCriteria(new_component, false);
                return;
                }
              }
            switch (key[25])
              {
                case 'A':
                    if ((String.Compare(key, 26, "dditional", 0, 9, false) == 0) && (key.Length == 35))
                        {
                        fromJSONMusicChartsSearchCriteriaAdditional(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraMusicChartsCommandConversationStateElementSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasMusicChartsSearchCriteria);
        if (flagHasMusicChartsSearchCriteria)
          {
            handler.start_pair("MusicChartsSearchCriteria");
            if (partial_allowed)
                storeMusicChartsSearchCriteria.write_partial_as_json(handler);
            else
                storeMusicChartsSearchCriteria.write_as_json(handler);
          }
        if (flagHasMusicChartsSearchCriteriaAdditional)
          {
            handler.start_pair("MusicChartsSearchCriteriaAdditional");
            if (partial_allowed)
                storeMusicChartsSearchCriteriaAdditional.write_partial_as_json(handler);
            else
                storeMusicChartsSearchCriteriaAdditional.write_as_json(handler);
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
        if (!(hasMusicChartsSearchCriteria()))
          {
            return "When parsing the object for %what%, the \"MusicChartsSearchCriteria\" field was missing.";
          }
        return null;
      }

    public static new MusicChartsCommandConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicChartsCommandConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsCommandConversationStateElement", ignore_extras);
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
    public static new MusicChartsCommandConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicChartsCommandConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicChartsCommandConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsCommandConversationStateElement", ignore_extras);
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
    public static new MusicChartsCommandConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicChartsCommandConversationStateElementJSON from_text(string text, bool ignore_extras)
      {
        MusicChartsCommandConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsCommandConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicChartsCommandConversationStateElementJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicChartsCommandConversationStateElementJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicChartsCommandConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsCommandConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MusicConversationStateElementJSON.Generator
      {
        private MusicChartsSearchCriteriaJSON.HoldingGenerator fieldGeneratorMusicChartsSearchCriteria;
        private MusicChartsSearchCriteriaAdditionalJSON.HoldingGenerator fieldGeneratorMusicChartsSearchCriteriaAdditional;
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
            if (!(getMusicConversationStateElementJSONKey().Equals("MusicChartsCommandConversationStateElement")))
                throw new Exception("The key field has a value other than `MusicChartsCommandConversationStateElement'.");
            MusicChartsCommandConversationStateElementJSON result = new MusicChartsCommandConversationStateElementJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicChartsCommandConversationStateElementAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MusicConversationStateElementJSON new_result)
          {
            handle_result((MusicChartsCommandConversationStateElementJSON )new_result);
          }
        protected void finish(MusicChartsCommandConversationStateElementJSON result)
          {
            if (fieldGeneratorMusicChartsSearchCriteria.have_value)
              {
                result.setMusicChartsSearchCriteria(fieldGeneratorMusicChartsSearchCriteria.value);
                fieldGeneratorMusicChartsSearchCriteria.have_value = false;
              }
            else if ((!(result.hasMusicChartsSearchCriteria())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MusicChartsSearchCriteria\" field was missing.");
              }
            if (fieldGeneratorMusicChartsSearchCriteriaAdditional.have_value)
              {
                result.setMusicChartsSearchCriteriaAdditional(fieldGeneratorMusicChartsSearchCriteriaAdditional.value);
                fieldGeneratorMusicChartsSearchCriteriaAdditional.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MusicChartsCommandConversationStateElementJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "MusicChartsSearchCriteria", 0, 25, false) == 0)
              {
                if (field_name.Length == 25)
                  {
                    return fieldGeneratorMusicChartsSearchCriteria;
                  }
                switch (field_name[25])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 26, "dditional", 0, 9, false) == 0) && (field_name.Length == 35))
                            return fieldGeneratorMusicChartsSearchCriteriaAdditional;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorMusicChartsSearchCriteria = new MusicChartsSearchCriteriaJSON.HoldingGenerator("field \"MusicChartsSearchCriteria\" of the MusicChartsCommandConversationStateElement class", ignore_extras);
            fieldGeneratorMusicChartsSearchCriteriaAdditional = new MusicChartsSearchCriteriaAdditionalJSON.HoldingGenerator("field \"MusicChartsSearchCriteriaAdditional\" of the MusicChartsCommandConversationStateElement class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MusicChartsCommandConversationStateElement class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMusicChartsSearchCriteria = new MusicChartsSearchCriteriaJSON.HoldingGenerator("field \"MusicChartsSearchCriteria\" of the MusicChartsCommandConversationStateElement class", false);
            fieldGeneratorMusicChartsSearchCriteriaAdditional = new MusicChartsSearchCriteriaAdditionalJSON.HoldingGenerator("field \"MusicChartsSearchCriteriaAdditional\" of the MusicChartsCommandConversationStateElement class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MusicChartsCommandConversationStateElement class");
          }

        public override void reset()
          {
            fieldGeneratorMusicChartsSearchCriteria.reset();
            fieldGeneratorMusicChartsSearchCriteriaAdditional.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicChartsCommandConversationStateElementJSON  result)
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
        public MusicChartsCommandConversationStateElementJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicChartsCommandConversationStateElementJSON  result)
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
    protected virtual void handle_result(List<MusicChartsCommandConversationStateElementJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicChartsCommandConversationStateElementJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicChartsCommandConversationStateElementJSON>();
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
    public List<MusicChartsCommandConversationStateElementJSON> value;
  };
  };
