/* file "MusicTheoryHowToPlayChordInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicTheoryHowToPlayChordInfoNuggetJSON : MusicTheoryChordInfoNuggetJSON
  {
    private bool flagHasNotesTheory;
    private List< MusicTheoryNoteJSON  > storeNotesTheory;
    private bool flagHasNotesPlayable;
    private List< MusicTheoryNoteJSON  > storeNotesPlayable;
    private bool flagHasInstrumentDisplayURL;
    private string storeInstrumentDisplayURL;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNotesTheoryToJSON()
      {
        JSONArrayValue generated_array_1_NotesTheory = new JSONArrayValue();
        for (int num1 = 0; num1 < storeNotesTheory.Count; ++num1)
          {
            JSONValueHandler handler_NotesTheory = new JSONValueHandler();
            storeNotesTheory[num1].write_as_json(handler_NotesTheory);
            generated_array_1_NotesTheory.appendComponent(handler_NotesTheory.result);
          }
        return generated_array_1_NotesTheory;
      }

    private JSONValue  extraNotesPlayableToJSON()
      {
        JSONArrayValue generated_array_2_NotesPlayable = new JSONArrayValue();
        for (int num2 = 0; num2 < storeNotesPlayable.Count; ++num2)
          {
            JSONValueHandler handler_NotesPlayable = new JSONValueHandler();
            storeNotesPlayable[num2].write_as_json(handler_NotesPlayable);
            generated_array_2_NotesPlayable.appendComponent(handler_NotesPlayable.result);
          }
        return generated_array_2_NotesPlayable;
      }

    private JSONValue  extraInstrumentDisplayURLToJSON()
      {
        JSONStringValue generated_string_InstrumentDisplayURL = new JSONStringValue(storeInstrumentDisplayURL);
        return generated_string_InstrumentDisplayURL;
      }


    private void  fromJSONNotesTheory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NotesTheory of MusicTheoryHowToPlayChordInfoNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 3)
            throw new Exception("The value for field NotesTheory of MusicTheoryHowToPlayChordInfoNuggetJSON has too few elements.");
        List< MusicTheoryNoteJSON  > vector_NotesTheory1 = new List< MusicTheoryNoteJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicTheoryNoteJSON convert_classy = MusicTheoryNoteJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NotesTheory1.Add(convert_classy);
          }
        Debug.Assert(vector_NotesTheory1.Count >= 3);
        initNotesTheory();
        for (int num1 = 0; num1 < vector_NotesTheory1.Count; ++num1)
            appendNotesTheory(vector_NotesTheory1[num1]);
        for (int num1 = 0; num1 < vector_NotesTheory1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNotesPlayable(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NotesPlayable of MusicTheoryHowToPlayChordInfoNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 3)
            throw new Exception("The value for field NotesPlayable of MusicTheoryHowToPlayChordInfoNuggetJSON has too few elements.");
        List< MusicTheoryNoteJSON  > vector_NotesPlayable1 = new List< MusicTheoryNoteJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicTheoryNoteJSON convert_classy = MusicTheoryNoteJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NotesPlayable1.Add(convert_classy);
          }
        Debug.Assert(vector_NotesPlayable1.Count >= 3);
        initNotesPlayable();
        for (int num2 = 0; num2 < vector_NotesPlayable1.Count; ++num2)
            appendNotesPlayable(vector_NotesPlayable1[num2]);
        for (int num1 = 0; num1 < vector_NotesPlayable1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInstrumentDisplayURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InstrumentDisplayURL of MusicTheoryHowToPlayChordInfoNuggetJSON is not a string.");
        setInstrumentDisplayURL(json_string.getData());
      }


    public MusicTheoryHowToPlayChordInfoNuggetJSON()
      {
        flagHasNotesTheory = false;
        flagHasNotesPlayable = false;
        flagHasInstrumentDisplayURL = false;
        storeNotesTheory = new List< MusicTheoryNoteJSON  >();
        storeNotesPlayable = new List< MusicTheoryNoteJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getMusicTheoryChordInfoNuggetKind()
      {
        return "MusicTheoryHowToPlayChordInfoNugget";
      }

    public bool  hasNotesTheory()
      {
        return flagHasNotesTheory;
      }

    public int  countOfNotesTheory()
      {
        Debug.Assert(flagHasNotesTheory);
        return storeNotesTheory.Count;
      }

    public MusicTheoryNoteJSON   elementOfNotesTheory(int element_num)
      {
        Debug.Assert(flagHasNotesTheory);
        return storeNotesTheory[element_num];
      }

    public List< MusicTheoryNoteJSON  >  getNotesTheory()
      {
        Debug.Assert(flagHasNotesTheory);
        return storeNotesTheory;
      }

    public bool  hasNotesPlayable()
      {
        return flagHasNotesPlayable;
      }

    public int  countOfNotesPlayable()
      {
        Debug.Assert(flagHasNotesPlayable);
        return storeNotesPlayable.Count;
      }

    public MusicTheoryNoteJSON   elementOfNotesPlayable(int element_num)
      {
        Debug.Assert(flagHasNotesPlayable);
        return storeNotesPlayable[element_num];
      }

    public List< MusicTheoryNoteJSON  >  getNotesPlayable()
      {
        Debug.Assert(flagHasNotesPlayable);
        return storeNotesPlayable;
      }

    public bool  hasInstrumentDisplayURL()
      {
        return flagHasInstrumentDisplayURL;
      }

    public string  getInstrumentDisplayURL()
      {
        Debug.Assert(flagHasInstrumentDisplayURL);
        return storeInstrumentDisplayURL;
      }


    public virtual int extraMusicTheoryHowToPlayChordInfoNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMusicTheoryHowToPlayChordInfoNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMusicTheoryHowToPlayChordInfoNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMusicTheoryHowToPlayChordInfoNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMusicTheoryChordInfoNuggetComponentCount()
      {
        int result = 0;
        if (flagHasNotesTheory)
            ++result;
        if (flagHasNotesPlayable)
            ++result;
        if (flagHasInstrumentDisplayURL)
            ++result;
        result += extraMusicTheoryHowToPlayChordInfoNuggetComponentCount();
        return result;
      }
    public override string extraMusicTheoryChordInfoNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNotesTheory)
          {
            if (remainder == 0)
                return "NotesTheory";
            --remainder;
          }
        if (flagHasNotesPlayable)
          {
            if (remainder == 0)
                return "NotesPlayable";
            --remainder;
          }
        if (flagHasInstrumentDisplayURL)
          {
            if (remainder == 0)
                return "InstrumentDisplayURL";
            --remainder;
          }
        return extraMusicTheoryHowToPlayChordInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraMusicTheoryChordInfoNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNotesTheory)
          {
            if (remainder == 0)
                return extraNotesTheoryToJSON();
            --remainder;
          }
        if (flagHasNotesPlayable)
          {
            if (remainder == 0)
                return extraNotesPlayableToJSON();
            --remainder;
          }
        if (flagHasInstrumentDisplayURL)
          {
            if (remainder == 0)
                return extraInstrumentDisplayURLToJSON();
            --remainder;
          }
        return extraMusicTheoryHowToPlayChordInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraMusicTheoryChordInfoNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "nstrumentDisplayURL", 0, 19, false) == 0) && (field_name.Length == 20))
                    return (flagHasInstrumentDisplayURL ? extraInstrumentDisplayURLToJSON() : null);
                break;
            case 'N':
                if (String.Compare(field_name, 1, "otes", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'P':
                            if ((String.Compare(field_name, 6, "layable", 0, 7, false) == 0) && (field_name.Length == 13))
                                return (flagHasNotesPlayable ? extraNotesPlayableToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 6, "heory", 0, 5, false) == 0) && (field_name.Length == 11))
                                return (flagHasNotesTheory ? extraNotesTheoryToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraMusicTheoryHowToPlayChordInfoNuggetLookup(field_name);
      }

    public void initNotesTheory()
      {
        if (flagHasNotesTheory)
          {
            for (int num1 = 0; num1 < storeNotesTheory.Count; ++num1)
              {
              }
          }
        flagHasNotesTheory = true;
        storeNotesTheory.Clear();
      }
    public void appendNotesTheory(MusicTheoryNoteJSON  to_append)
      {
        if (!flagHasNotesTheory)
          {
            flagHasNotesTheory = true;
            storeNotesTheory.Clear();
          }
        Debug.Assert(flagHasNotesTheory);
        storeNotesTheory.Add(to_append);
      }
    public void unsetNotesTheory()
      {
        if (flagHasNotesTheory)
          {
            for (int num2 = 0; num2 < storeNotesTheory.Count; ++num2)
              {
              }
          }
        flagHasNotesTheory = false;
        storeNotesTheory.Clear();
      }
    public void initNotesPlayable()
      {
        if (flagHasNotesPlayable)
          {
            for (int num3 = 0; num3 < storeNotesPlayable.Count; ++num3)
              {
              }
          }
        flagHasNotesPlayable = true;
        storeNotesPlayable.Clear();
      }
    public void appendNotesPlayable(MusicTheoryNoteJSON  to_append)
      {
        if (!flagHasNotesPlayable)
          {
            flagHasNotesPlayable = true;
            storeNotesPlayable.Clear();
          }
        Debug.Assert(flagHasNotesPlayable);
        storeNotesPlayable.Add(to_append);
      }
    public void unsetNotesPlayable()
      {
        if (flagHasNotesPlayable)
          {
            for (int num4 = 0; num4 < storeNotesPlayable.Count; ++num4)
              {
              }
          }
        flagHasNotesPlayable = false;
        storeNotesPlayable.Clear();
      }
    public void setInstrumentDisplayURL(string new_value)
      {
        flagHasInstrumentDisplayURL = true;
        storeInstrumentDisplayURL = new_value;
      }
    public void unsetInstrumentDisplayURL()
      {
        flagHasInstrumentDisplayURL = false;
      }

    public virtual void extraMusicTheoryHowToPlayChordInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMusicTheoryHowToPlayChordInfoNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMusicTheoryHowToPlayChordInfoNuggetLookup(key);
        if (old_field == null)
          {
            extraMusicTheoryHowToPlayChordInfoNuggetAppendPair(key, new_component);
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
            case 'I':
                if ((String.Compare(key, 1, "nstrumentDisplayURL", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONInstrumentDisplayURL(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if (String.Compare(key, 1, "otes", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'P':
                            if ((String.Compare(key, 6, "layable", 0, 7, false) == 0) && (key.Length == 13))
                                {
                                fromJSONNotesPlayable(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 6, "heory", 0, 5, false) == 0) && (key.Length == 11))
                                {
                                fromJSONNotesTheory(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraMusicTheoryHowToPlayChordInfoNuggetAppendPair(key, new_component);
      }
    public override void extraMusicTheoryChordInfoNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "nstrumentDisplayURL", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONInstrumentDisplayURL(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if (String.Compare(key, 1, "otes", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'P':
                            if ((String.Compare(key, 6, "layable", 0, 7, false) == 0) && (key.Length == 13))
                                {
                                fromJSONNotesPlayable(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 6, "heory", 0, 5, false) == 0) && (key.Length == 11))
                                {
                                fromJSONNotesTheory(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraMusicTheoryHowToPlayChordInfoNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNotesTheory);
        if (flagHasNotesTheory)
          {
            handler.start_pair("NotesTheory");
            Debug.Assert(storeNotesTheory.Count >= 3);
            handler.start_array();
            for (int num1 = 0; num1 < storeNotesTheory.Count; ++num1)
              {
                if (partial_allowed)
                    storeNotesTheory[num1].write_partial_as_json(handler);
                else
                    storeNotesTheory[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasNotesPlayable);
        if (flagHasNotesPlayable)
          {
            handler.start_pair("NotesPlayable");
            Debug.Assert(storeNotesPlayable.Count >= 3);
            handler.start_array();
            for (int num2 = 0; num2 < storeNotesPlayable.Count; ++num2)
              {
                if (partial_allowed)
                    storeNotesPlayable[num2].write_partial_as_json(handler);
                else
                    storeNotesPlayable[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasInstrumentDisplayURL)
          {
            handler.start_pair("InstrumentDisplayURL");
            handler.string_value(storeInstrumentDisplayURL);
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
        if (!(hasNotesTheory()))
          {
            return "When parsing the object for %what%, the \"NotesTheory\" field was missing.";
          }
        if (!(hasNotesPlayable()))
          {
            return "When parsing the object for %what%, the \"NotesPlayable\" field was missing.";
          }
        return null;
      }

    public static new MusicTheoryHowToPlayChordInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTheoryHowToPlayChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryHowToPlayChordInfoNugget", ignore_extras);
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
    public static new MusicTheoryHowToPlayChordInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicTheoryHowToPlayChordInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTheoryHowToPlayChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryHowToPlayChordInfoNugget", ignore_extras);
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
    public static new MusicTheoryHowToPlayChordInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicTheoryHowToPlayChordInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        MusicTheoryHowToPlayChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryHowToPlayChordInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicTheoryHowToPlayChordInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicTheoryHowToPlayChordInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicTheoryHowToPlayChordInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryHowToPlayChordInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MusicTheoryChordInfoNuggetJSON.Generator
      {
        private MusicTheoryNoteJSON.HoldingArrayGenerator fieldGeneratorNotesTheory;
        private MusicTheoryNoteJSON.HoldingArrayGenerator fieldGeneratorNotesPlayable;
        private JSONHoldingStringGenerator fieldGeneratorInstrumentDisplayURL;
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
            if (!(getMusicTheoryChordInfoNuggetJSONKey().Equals("MusicTheoryHowToPlayChordInfoNugget")))
                throw new Exception("The key field has a value other than `MusicTheoryHowToPlayChordInfoNugget'.");
            MusicTheoryHowToPlayChordInfoNuggetJSON result = new MusicTheoryHowToPlayChordInfoNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicTheoryHowToPlayChordInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MusicTheoryChordInfoNuggetJSON new_result)
          {
            handle_result((MusicTheoryHowToPlayChordInfoNuggetJSON )new_result);
          }
        protected void finish(MusicTheoryHowToPlayChordInfoNuggetJSON result)
          {
            if (fieldGeneratorNotesTheory.have_value)
              {
                result.initNotesTheory();
                int count = fieldGeneratorNotesTheory.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNotesTheory(fieldGeneratorNotesTheory.value[num]);
                  }
                fieldGeneratorNotesTheory.value.Clear();
                fieldGeneratorNotesTheory.have_value = false;
              }
            else if ((!(result.hasNotesTheory())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NotesTheory\" field was missing.");
              }
            if (fieldGeneratorNotesPlayable.have_value)
              {
                result.initNotesPlayable();
                int count = fieldGeneratorNotesPlayable.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNotesPlayable(fieldGeneratorNotesPlayable.value[num]);
                  }
                fieldGeneratorNotesPlayable.value.Clear();
                fieldGeneratorNotesPlayable.have_value = false;
              }
            else if ((!(result.hasNotesPlayable())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NotesPlayable\" field was missing.");
              }
            if (fieldGeneratorInstrumentDisplayURL.have_value)
              {
                result.setInstrumentDisplayURL(fieldGeneratorInstrumentDisplayURL.value);
                fieldGeneratorInstrumentDisplayURL.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MusicTheoryHowToPlayChordInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "nstrumentDisplayURL", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorInstrumentDisplayURL;
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "otes", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 6, "layable", 0, 7, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorNotesPlayable;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 6, "heory", 0, 5, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorNotesTheory;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNotesTheory = new MusicTheoryNoteJSON.HoldingArrayGenerator("field \"NotesTheory\" of the MusicTheoryHowToPlayChordInfoNugget class", ignore_extras);
            fieldGeneratorNotesPlayable = new MusicTheoryNoteJSON.HoldingArrayGenerator("field \"NotesPlayable\" of the MusicTheoryHowToPlayChordInfoNugget class", ignore_extras);
            fieldGeneratorInstrumentDisplayURL = new JSONHoldingStringGenerator("field \"InstrumentDisplayURL\" of the MusicTheoryHowToPlayChordInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MusicTheoryHowToPlayChordInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNotesTheory = new MusicTheoryNoteJSON.HoldingArrayGenerator("field \"NotesTheory\" of the MusicTheoryHowToPlayChordInfoNugget class", false);
            fieldGeneratorNotesPlayable = new MusicTheoryNoteJSON.HoldingArrayGenerator("field \"NotesPlayable\" of the MusicTheoryHowToPlayChordInfoNugget class", false);
            fieldGeneratorInstrumentDisplayURL = new JSONHoldingStringGenerator("field \"InstrumentDisplayURL\" of the MusicTheoryHowToPlayChordInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MusicTheoryHowToPlayChordInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorNotesTheory.reset();
            fieldGeneratorNotesPlayable.reset();
            fieldGeneratorInstrumentDisplayURL.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicTheoryHowToPlayChordInfoNuggetJSON  result)
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
        public MusicTheoryHowToPlayChordInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicTheoryHowToPlayChordInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<MusicTheoryHowToPlayChordInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicTheoryHowToPlayChordInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicTheoryHowToPlayChordInfoNuggetJSON>();
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
    public List<MusicTheoryHowToPlayChordInfoNuggetJSON> value;
  };
  };
