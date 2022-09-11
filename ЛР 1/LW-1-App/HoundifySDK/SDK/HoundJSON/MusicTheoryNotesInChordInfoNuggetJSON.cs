/* file "MusicTheoryNotesInChordInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicTheoryNotesInChordInfoNuggetJSON : MusicTheoryChordInfoNuggetJSON
  {
    private bool flagHasNotes;
    private List< MusicTheoryNoteJSON  > storeNotes;
    private bool flagHasChordURL;
    private string storeChordURL;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNotesToJSON()
      {
        JSONArrayValue generated_array_1_Notes = new JSONArrayValue();
        for (int num1 = 0; num1 < storeNotes.Count; ++num1)
          {
            JSONValueHandler handler_Notes = new JSONValueHandler();
            storeNotes[num1].write_as_json(handler_Notes);
            generated_array_1_Notes.appendComponent(handler_Notes.result);
          }
        return generated_array_1_Notes;
      }

    private JSONValue  extraChordURLToJSON()
      {
        JSONStringValue generated_string_ChordURL = new JSONStringValue(storeChordURL);
        return generated_string_ChordURL;
      }


    private void  fromJSONNotes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Notes of MusicTheoryNotesInChordInfoNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 3)
            throw new Exception("The value for field Notes of MusicTheoryNotesInChordInfoNuggetJSON has too few elements.");
        List< MusicTheoryNoteJSON  > vector_Notes1 = new List< MusicTheoryNoteJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicTheoryNoteJSON convert_classy = MusicTheoryNoteJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Notes1.Add(convert_classy);
          }
        Debug.Assert(vector_Notes1.Count >= 3);
        initNotes();
        for (int num1 = 0; num1 < vector_Notes1.Count; ++num1)
            appendNotes(vector_Notes1[num1]);
        for (int num1 = 0; num1 < vector_Notes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONChordURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChordURL of MusicTheoryNotesInChordInfoNuggetJSON is not a string.");
        setChordURL(json_string.getData());
      }


    public MusicTheoryNotesInChordInfoNuggetJSON()
      {
        flagHasNotes = false;
        flagHasChordURL = false;
        storeNotes = new List< MusicTheoryNoteJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getMusicTheoryChordInfoNuggetKind()
      {
        return "MusicTheoryNotesInChordInfoNugget";
      }

    public bool  hasNotes()
      {
        return flagHasNotes;
      }

    public int  countOfNotes()
      {
        Debug.Assert(flagHasNotes);
        return storeNotes.Count;
      }

    public MusicTheoryNoteJSON   elementOfNotes(int element_num)
      {
        Debug.Assert(flagHasNotes);
        return storeNotes[element_num];
      }

    public List< MusicTheoryNoteJSON  >  getNotes()
      {
        Debug.Assert(flagHasNotes);
        return storeNotes;
      }

    public bool  hasChordURL()
      {
        return flagHasChordURL;
      }

    public string  getChordURL()
      {
        Debug.Assert(flagHasChordURL);
        return storeChordURL;
      }


    public virtual int extraMusicTheoryNotesInChordInfoNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMusicTheoryNotesInChordInfoNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMusicTheoryNotesInChordInfoNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMusicTheoryNotesInChordInfoNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMusicTheoryChordInfoNuggetComponentCount()
      {
        int result = 0;
        if (flagHasNotes)
            ++result;
        if (flagHasChordURL)
            ++result;
        result += extraMusicTheoryNotesInChordInfoNuggetComponentCount();
        return result;
      }
    public override string extraMusicTheoryChordInfoNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNotes)
          {
            if (remainder == 0)
                return "Notes";
            --remainder;
          }
        if (flagHasChordURL)
          {
            if (remainder == 0)
                return "ChordURL";
            --remainder;
          }
        return extraMusicTheoryNotesInChordInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraMusicTheoryChordInfoNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNotes)
          {
            if (remainder == 0)
                return extraNotesToJSON();
            --remainder;
          }
        if (flagHasChordURL)
          {
            if (remainder == 0)
                return extraChordURLToJSON();
            --remainder;
          }
        return extraMusicTheoryNotesInChordInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraMusicTheoryChordInfoNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "hordURL", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasChordURL ? extraChordURLToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "otes", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasNotes ? extraNotesToJSON() : null);
                break;
            default:
                break;
          }
        return extraMusicTheoryNotesInChordInfoNuggetLookup(field_name);
      }

    public void initNotes()
      {
        if (flagHasNotes)
          {
            for (int num1 = 0; num1 < storeNotes.Count; ++num1)
              {
              }
          }
        flagHasNotes = true;
        storeNotes.Clear();
      }
    public void appendNotes(MusicTheoryNoteJSON  to_append)
      {
        if (!flagHasNotes)
          {
            flagHasNotes = true;
            storeNotes.Clear();
          }
        Debug.Assert(flagHasNotes);
        storeNotes.Add(to_append);
      }
    public void unsetNotes()
      {
        if (flagHasNotes)
          {
            for (int num2 = 0; num2 < storeNotes.Count; ++num2)
              {
              }
          }
        flagHasNotes = false;
        storeNotes.Clear();
      }
    public void setChordURL(string new_value)
      {
        flagHasChordURL = true;
        storeChordURL = new_value;
      }
    public void unsetChordURL()
      {
        flagHasChordURL = false;
      }

    public virtual void extraMusicTheoryNotesInChordInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMusicTheoryNotesInChordInfoNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMusicTheoryNotesInChordInfoNuggetLookup(key);
        if (old_field == null)
          {
            extraMusicTheoryNotesInChordInfoNuggetAppendPair(key, new_component);
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
    public override void extraMusicTheoryChordInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hordURL", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONChordURL(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "otes", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONNotes(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMusicTheoryNotesInChordInfoNuggetAppendPair(key, new_component);
      }
    public override void extraMusicTheoryChordInfoNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hordURL", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONChordURL(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "otes", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONNotes(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMusicTheoryNotesInChordInfoNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNotes);
        if (flagHasNotes)
          {
            handler.start_pair("Notes");
            Debug.Assert(storeNotes.Count >= 3);
            handler.start_array();
            for (int num1 = 0; num1 < storeNotes.Count; ++num1)
              {
                if (partial_allowed)
                    storeNotes[num1].write_partial_as_json(handler);
                else
                    storeNotes[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasChordURL)
          {
            handler.start_pair("ChordURL");
            handler.string_value(storeChordURL);
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
        if (!(hasNotes()))
          {
            return "When parsing the object for %what%, the \"Notes\" field was missing.";
          }
        return null;
      }

    public static new MusicTheoryNotesInChordInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTheoryNotesInChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryNotesInChordInfoNugget", ignore_extras);
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
    public static new MusicTheoryNotesInChordInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicTheoryNotesInChordInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTheoryNotesInChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryNotesInChordInfoNugget", ignore_extras);
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
    public static new MusicTheoryNotesInChordInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicTheoryNotesInChordInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        MusicTheoryNotesInChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryNotesInChordInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicTheoryNotesInChordInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicTheoryNotesInChordInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicTheoryNotesInChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryNotesInChordInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MusicTheoryChordInfoNuggetJSON.Generator
      {
        private MusicTheoryNoteJSON.HoldingArrayGenerator fieldGeneratorNotes;
        private JSONHoldingStringGenerator fieldGeneratorChordURL;
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
            if (!(getMusicTheoryChordInfoNuggetJSONKey().Equals("MusicTheoryNotesInChordInfoNugget")))
                throw new Exception("The key field has a value other than `MusicTheoryNotesInChordInfoNugget'.");
            MusicTheoryNotesInChordInfoNuggetJSON result = new MusicTheoryNotesInChordInfoNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicTheoryNotesInChordInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MusicTheoryChordInfoNuggetJSON new_result)
          {
            handle_result((MusicTheoryNotesInChordInfoNuggetJSON )new_result);
          }
        protected void finish(MusicTheoryNotesInChordInfoNuggetJSON result)
          {
            if (fieldGeneratorNotes.have_value)
              {
                result.initNotes();
                int count = fieldGeneratorNotes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNotes(fieldGeneratorNotes.value[num]);
                  }
                fieldGeneratorNotes.value.Clear();
                fieldGeneratorNotes.have_value = false;
              }
            else if ((!(result.hasNotes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Notes\" field was missing.");
              }
            if (fieldGeneratorChordURL.have_value)
              {
                result.setChordURL(fieldGeneratorChordURL.value);
                fieldGeneratorChordURL.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MusicTheoryNotesInChordInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hordURL", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorChordURL;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "otes", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorNotes;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNotes = new MusicTheoryNoteJSON.HoldingArrayGenerator("field \"Notes\" of the MusicTheoryNotesInChordInfoNugget class", ignore_extras);
            fieldGeneratorChordURL = new JSONHoldingStringGenerator("field \"ChordURL\" of the MusicTheoryNotesInChordInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MusicTheoryNotesInChordInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNotes = new MusicTheoryNoteJSON.HoldingArrayGenerator("field \"Notes\" of the MusicTheoryNotesInChordInfoNugget class", false);
            fieldGeneratorChordURL = new JSONHoldingStringGenerator("field \"ChordURL\" of the MusicTheoryNotesInChordInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MusicTheoryNotesInChordInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorNotes.reset();
            fieldGeneratorChordURL.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicTheoryNotesInChordInfoNuggetJSON  result)
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
        public MusicTheoryNotesInChordInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicTheoryNotesInChordInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<MusicTheoryNotesInChordInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicTheoryNotesInChordInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicTheoryNotesInChordInfoNuggetJSON>();
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
    public List<MusicTheoryNotesInChordInfoNuggetJSON> value;
  };
  };
