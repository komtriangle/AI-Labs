/* file "MusicTheoryChordInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class MusicTheoryChordInfoNuggetJSON : MusicTheoryInfoNuggetJSON
  {
    private bool flagHasChord;
    private MusicTheoryChordJSON  storeChord;


    private JSONValue  extraChordToJSON()
      {
        JSONValueHandler handler_Chord = new JSONValueHandler();
        storeChord.write_as_json(handler_Chord);
        return handler_Chord.result;
      }


    private void  fromJSONChord(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicTheoryChordJSON convert_classy = MusicTheoryChordJSON.from_json(json_value, ignore_extras, true);
        setChord(convert_classy);
      }


    public MusicTheoryChordInfoNuggetJSON()
      {
        flagHasChord = false;
      }

    public override string  getMusicTheoryInfoNuggetKind()
      {
        return "MusicTheoryChordInfoNugget";
      }

    public abstract string getMusicTheoryChordInfoNuggetKind();
    public bool  hasChord()
      {
        return flagHasChord;
      }

    public MusicTheoryChordJSON   getChord()
      {
        Debug.Assert(flagHasChord);
        return storeChord;
      }


    public abstract int extraMusicTheoryChordInfoNuggetComponentCount();
    public abstract string extraMusicTheoryChordInfoNuggetComponentKey(int component_num);
    public abstract JSONValue extraMusicTheoryChordInfoNuggetComponentValue(int component_num);
    public abstract JSONValue extraMusicTheoryChordInfoNuggetLookup(string field_name);
    public override int extraMusicTheoryInfoNuggetComponentCount()
      {
        int result = 1;
        if (flagHasChord)
            ++result;
        result += extraMusicTheoryChordInfoNuggetComponentCount();
        return result;
      }
    public override string extraMusicTheoryInfoNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "MusicTheoryChordInfoNuggetKind";
        int remainder = (component_num - 1);
        if (flagHasChord)
          {
            if (remainder == 0)
                return "Chord";
            --remainder;
          }
        return extraMusicTheoryChordInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraMusicTheoryInfoNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getMusicTheoryChordInfoNuggetKind());
        int remainder = (component_num - 1);
        if (flagHasChord)
          {
            if (remainder == 0)
                return extraChordToJSON();
            --remainder;
          }
        return extraMusicTheoryChordInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraMusicTheoryInfoNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "hord", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasChord ? extraChordToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "usicTheoryChordInfoNuggetKind", 0, 29, false) == 0) && (field_name.Length == 30))
                    return new JSONStringValue(getMusicTheoryChordInfoNuggetKind());
                break;
            default:
                break;
          }
        return extraMusicTheoryChordInfoNuggetLookup(field_name);
      }

    public void setChord(MusicTheoryChordJSON  new_value)
      {
        if (flagHasChord)
          {
          }
        flagHasChord = true;
        storeChord = new_value;
      }
    public void unsetChord()
      {
        if (flagHasChord)
          {
          }
        flagHasChord = false;
      }

    public abstract void extraMusicTheoryChordInfoNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraMusicTheoryChordInfoNuggetSetField(string key, JSONValue new_component);
    public override void extraMusicTheoryInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hord", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONChord(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "usicTheoryChordInfoNuggetKind", 0, 29, false) == 0) && (key.Length == 30))
                    return;
                break;
            default:
                break;
          }
        extraMusicTheoryChordInfoNuggetAppendPair(key, new_component);
      }
    public override void extraMusicTheoryInfoNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hord", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONChord(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "usicTheoryChordInfoNuggetKind", 0, 29, false) == 0) && (key.Length == 30))
                    return;
                break;
            default:
                break;
          }
        extraMusicTheoryChordInfoNuggetSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("MusicTheoryChordInfoNuggetKind", getMusicTheoryChordInfoNuggetKind());
        Debug.Assert(partial_allowed || flagHasChord);
        if (flagHasChord)
          {
            handler.start_pair("Chord");
            if (partial_allowed)
                storeChord.write_partial_as_json(handler);
            else
                storeChord.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasChord()))
          {
            return "When parsing the object for %what%, the \"Chord\" field was missing.";
          }
        return null;
      }

    public static new MusicTheoryChordInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTheoryChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryChordInfoNugget", ignore_extras);
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
    public static new MusicTheoryChordInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicTheoryChordInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTheoryChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryChordInfoNugget", ignore_extras);
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
    public static new MusicTheoryChordInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicTheoryChordInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        MusicTheoryChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryChordInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicTheoryChordInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicTheoryChordInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicTheoryChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryChordInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MusicTheoryInfoNuggetJSON.Generator
      {
        private MusicTheoryChordJSON.HoldingGenerator fieldGeneratorChord;
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
                throw new Exception("The `MusicTheoryChordInfoNuggetKind' field is missing.");
            if (!(getMusicTheoryInfoNuggetJSONKey().Equals("MusicTheoryChordInfoNugget")))
                throw new Exception("The key field has a value other than `MusicTheoryChordInfoNugget'.");
            MusicTheoryChordInfoNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicTheoryChordInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getMusicTheoryChordInfoNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `MusicTheoryChordInfoNuggetKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(MusicTheoryInfoNuggetJSON new_result)
          {
            handle_result((MusicTheoryChordInfoNuggetJSON )new_result);
          }
        protected void finish(MusicTheoryChordInfoNuggetJSON result)
          {
            if (fieldGeneratorChord.have_value)
              {
                result.setChord(fieldGeneratorChord.value);
                fieldGeneratorChord.have_value = false;
              }
            else if ((!(result.hasChord())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Chord\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MusicTheoryChordInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hord", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorChord;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "usicTheoryChordInfoNuggetKind", 0, 29, false) == 0) && (field_name.Length == 30))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorChord = new MusicTheoryChordJSON.HoldingGenerator("field \"Chord\" of the MusicTheoryChordInfoNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"MusicTheoryChordInfoNuggetKind\" of the MusicTheoryChordInfoNugget class");
            set_what("the MusicTheoryChordInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorChord = new MusicTheoryChordJSON.HoldingGenerator("field \"Chord\" of the MusicTheoryChordInfoNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"MusicTheoryChordInfoNuggetKind\" of the MusicTheoryChordInfoNugget class");
            set_what("the MusicTheoryChordInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorChord.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicTheoryChordInfoNuggetJSON  result)
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
        public MusicTheoryChordInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicTheoryChordInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<MusicTheoryChordInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicTheoryChordInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicTheoryChordInfoNuggetJSON>();
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
    public List<MusicTheoryChordInfoNuggetJSON> value;
  };
    class GenericMusicTheoryChordInfoNuggetJSON : MusicTheoryChordInfoNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericMusicTheoryChordInfoNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getMusicTheoryChordInfoNuggetKind()  { return key; }
        public override int extraMusicTheoryChordInfoNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraMusicTheoryChordInfoNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraMusicTheoryChordInfoNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraMusicTheoryChordInfoNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraMusicTheoryChordInfoNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraMusicTheoryChordInfoNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraMusicTheoryChordInfoNuggetLookup(key);
            if (old_field == null)
              {
                extraMusicTheoryChordInfoNuggetAppendPair(key, new_component);
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
    public static new MusicTheoryChordInfoNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "MusicTheory", 0, 11, false) == 0)
      {
        switch (key[11])
          {
            case 'H':
                if ((String.Compare(key, 12, "owToPlayChordInfoNugget", 0, 23, false) == 0) && (key.Length == 35))
                    return new MusicTheoryHowToPlayChordInfoNuggetJSON();
                break;
            case 'N':
                if ((String.Compare(key, 12, "otesInChordInfoNugget", 0, 21, false) == 0) && (key.Length == 33))
                    return new MusicTheoryNotesInChordInfoNuggetJSON();
                break;
            default:
                break;
          }
      }

        return new GenericMusicTheoryChordInfoNuggetJSON(key);
      }
  };
