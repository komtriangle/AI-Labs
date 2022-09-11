/* file "MusicTheoryNoteJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicTheoryNoteJSON : JSONBase
  {
    private bool flagHasBase;
    private MusicTheoryBaseNamesJSON  storeBase;
    private bool flagHasAccidental;
    private MusicTheoryAccidentalsJSON  storeAccidental;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONBase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicTheoryBaseNamesJSON convert_classy = MusicTheoryBaseNamesJSON.from_json(json_value, ignore_extras, true);
        setBase(convert_classy);
      }


    private void  fromJSONAccidental(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicTheoryAccidentalsJSON convert_classy = MusicTheoryAccidentalsJSON.from_json(json_value, ignore_extras, true);
        setAccidental(convert_classy);
      }


    public MusicTheoryNoteJSON()
      {
        flagHasBase = false;
        flagHasAccidental = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasBase()
      {
        return flagHasBase;
      }

    public MusicTheoryBaseNamesJSON   getBase()
      {
        Debug.Assert(flagHasBase);
        return storeBase;
      }

    public MusicTheoryBaseNamesJSON.TypeValue  getBaseValue()
      {
        return getBase().getValue();
      }

    public string  getBaseAsString()
      {
        return getBase().getValueAsString();
      }

    public bool  hasAccidental()
      {
        return flagHasAccidental;
      }

    public MusicTheoryAccidentalsJSON   getAccidental()
      {
        Debug.Assert(flagHasAccidental);
        return storeAccidental;
      }

    public MusicTheoryAccidentalsJSON.TypeValue  getAccidentalValue()
      {
        return getAccidental().getValue();
      }

    public string  getAccidentalAsString()
      {
        return getAccidental().getValueAsString();
      }


    public virtual int extraMusicTheoryNoteComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMusicTheoryNoteComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMusicTheoryNoteComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMusicTheoryNoteLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setBase(MusicTheoryBaseNamesJSON  new_value)
      {
        if (flagHasBase)
          {
          }
        flagHasBase = true;
        storeBase = new_value;
      }
    public void setBase(MusicTheoryBaseNamesJSON.TypeValue new_value)
      {
        setBase(new MusicTheoryBaseNamesJSON(new_value));
      }
    public void setBase(string chars)
      {
        setBase(new MusicTheoryBaseNamesJSON(chars));
      }
    public void unsetBase()
      {
        if (flagHasBase)
          {
          }
        flagHasBase = false;
      }
    public void setAccidental(MusicTheoryAccidentalsJSON  new_value)
      {
        if (flagHasAccidental)
          {
          }
        flagHasAccidental = true;
        storeAccidental = new_value;
      }
    public void setAccidental(MusicTheoryAccidentalsJSON.TypeValue new_value)
      {
        setAccidental(new MusicTheoryAccidentalsJSON(new_value));
      }
    public void setAccidental(string chars)
      {
        setAccidental(new MusicTheoryAccidentalsJSON(chars));
      }
    public void unsetAccidental()
      {
        if (flagHasAccidental)
          {
          }
        flagHasAccidental = false;
      }

    public virtual void extraMusicTheoryNoteAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMusicTheoryNoteSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMusicTheoryNoteLookup(key);
        if (old_field == null)
          {
            extraMusicTheoryNoteAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasBase);
        if (flagHasBase)
          {
            handler.start_pair("Base");
            if (partial_allowed)
                storeBase.write_partial_as_json(handler);
            else
                storeBase.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasAccidental);
        if (flagHasAccidental)
          {
            handler.start_pair("Accidental");
            if (partial_allowed)
                storeAccidental.write_partial_as_json(handler);
            else
                storeAccidental.write_as_json(handler);
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
        if (!(hasBase()))
          {
            return "When parsing the object for %what%, the \"Base\" field was missing.";
          }
        if (!(hasAccidental()))
          {
            return "When parsing the object for %what%, the \"Accidental\" field was missing.";
          }
        return null;
      }

    public static MusicTheoryNoteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTheoryNoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryNote", ignore_extras);
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
    public static MusicTheoryNoteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicTheoryNoteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTheoryNoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryNote", ignore_extras);
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
    public static MusicTheoryNoteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicTheoryNoteJSON from_text(string text, bool ignore_extras)
      {
        MusicTheoryNoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryNote", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicTheoryNoteJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicTheoryNoteJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicTheoryNoteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryNote", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MusicTheoryBaseNamesJSON.HoldingGenerator fieldGeneratorBase;
        private MusicTheoryAccidentalsJSON.HoldingGenerator fieldGeneratorAccidental;
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
            MusicTheoryNoteJSON result = new MusicTheoryNoteJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicTheoryNoteAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MusicTheoryNoteJSON result)
          {
            if (fieldGeneratorBase.have_value)
              {
                result.setBase(fieldGeneratorBase.value);
                fieldGeneratorBase.have_value = false;
              }
            else if ((!(result.hasBase())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Base\" field was missing.");
              }
            if (fieldGeneratorAccidental.have_value)
              {
                result.setAccidental(fieldGeneratorAccidental.value);
                fieldGeneratorAccidental.have_value = false;
              }
            else if ((!(result.hasAccidental())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Accidental\" field was missing.");
              }
          }
        protected abstract void handle_result(MusicTheoryNoteJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ccidental", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorAccidental;
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "ase", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorBase;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorBase = new MusicTheoryBaseNamesJSON.HoldingGenerator("field \"Base\" of the MusicTheoryNote class", ignore_extras);
            fieldGeneratorAccidental = new MusicTheoryAccidentalsJSON.HoldingGenerator("field \"Accidental\" of the MusicTheoryNote class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MusicTheoryNote class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorBase = new MusicTheoryBaseNamesJSON.HoldingGenerator("field \"Base\" of the MusicTheoryNote class", false);
            fieldGeneratorAccidental = new MusicTheoryAccidentalsJSON.HoldingGenerator("field \"Accidental\" of the MusicTheoryNote class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MusicTheoryNote class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorBase.reset();
            fieldGeneratorAccidental.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorBase.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAccidental.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorBase.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAccidental.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicTheoryNoteJSON  result)
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
        public MusicTheoryNoteJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicTheoryNoteJSON  result)
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
    protected virtual void handle_result(List<MusicTheoryNoteJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicTheoryNoteJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicTheoryNoteJSON>();
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
    public List<MusicTheoryNoteJSON> value;
  };
  };
