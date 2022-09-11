/* file "PlayingCardJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PlayingCardJSON : JSONBase
  {
    public enum TypeWrittenSuitKnownValues
      {
        WrittenSuit__x2663_,
        WrittenSuit__x2666_,
        WrittenSuit__x2665_,
        WrittenSuit__x2660_,
        WrittenSuit__none
      };
    public struct TypeWrittenSuit
      {
        public bool in_known_list;
        public string string_value;
        public TypeWrittenSuitKnownValues list_value;
      };

    public static TypeWrittenSuitKnownValues  stringToWrittenSuit(string chars)
      {
        switch (chars[0])
          {
            case '\x2660':
                if ((String.Compare(chars, 1, "", 0, 0, false) == 0) && (chars.Length == 1))
                    return TypeWrittenSuitKnownValues.WrittenSuit__x2660_;
                break;
            case '\x2663':
                if ((String.Compare(chars, 1, "", 0, 0, false) == 0) && (chars.Length == 1))
                    return TypeWrittenSuitKnownValues.WrittenSuit__x2663_;
                break;
            case '\x2665':
                if ((String.Compare(chars, 1, "", 0, 0, false) == 0) && (chars.Length == 1))
                    return TypeWrittenSuitKnownValues.WrittenSuit__x2665_;
                break;
            case '\x2666':
                if ((String.Compare(chars, 1, "", 0, 0, false) == 0) && (chars.Length == 1))
                    return TypeWrittenSuitKnownValues.WrittenSuit__x2666_;
                break;
            default:
                break;
          }
        return TypeWrittenSuitKnownValues.WrittenSuit__none;
      }

    public static string  stringFromWrittenSuit(TypeWrittenSuitKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeWrittenSuitKnownValues.WrittenSuit__x2663_:
                return "♣";
            case TypeWrittenSuitKnownValues.WrittenSuit__x2666_:
                return "♦";
            case TypeWrittenSuitKnownValues.WrittenSuit__x2665_:
                return "♥";
            case TypeWrittenSuitKnownValues.WrittenSuit__x2660_:
                return "♠";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasWrittenRank;
    private string storeWrittenRank;
    private bool flagHasSpokenRank;
    private string storeSpokenRank;
    private bool flagHasWrittenSuit;
    private TypeWrittenSuit storeWrittenSuit;
    private bool flagHasSpokenSuit;
    private string storeSpokenSuit;
    private bool flagHasIndex;
    private sbyte storeIndex;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONWrittenRank(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenRank of PlayingCardJSON is not a string.");
        setWrittenRank(json_string.getData());
      }


    private void  fromJSONSpokenRank(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenRank of PlayingCardJSON is not a string.");
        setSpokenRank(json_string.getData());
      }


    private void  fromJSONWrittenSuit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenSuit of PlayingCardJSON is not a string.");
        TypeWrittenSuit the_open_enum = new TypeWrittenSuit();
        switch (json_string.getData()[0])
          {
            case '\x2660':
                if ((String.Compare(json_string.getData(), 1, "", 0, 0, false) == 0) && (json_string.getData().Length == 1))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeWrittenSuitKnownValues.WrittenSuit__x2660_;
                        goto open_enum_is_done;
                      }
                break;
            case '\x2663':
                if ((String.Compare(json_string.getData(), 1, "", 0, 0, false) == 0) && (json_string.getData().Length == 1))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeWrittenSuitKnownValues.WrittenSuit__x2663_;
                        goto open_enum_is_done;
                      }
                break;
            case '\x2665':
                if ((String.Compare(json_string.getData(), 1, "", 0, 0, false) == 0) && (json_string.getData().Length == 1))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeWrittenSuitKnownValues.WrittenSuit__x2665_;
                        goto open_enum_is_done;
                      }
                break;
            case '\x2666':
                if ((String.Compare(json_string.getData(), 1, "", 0, 0, false) == 0) && (json_string.getData().Length == 1))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeWrittenSuitKnownValues.WrittenSuit__x2666_;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setWrittenSuit(the_open_enum);
      }


    private void  fromJSONSpokenSuit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenSuit of PlayingCardJSON is not a string.");
        setSpokenSuit(json_string.getData());
      }


    private void  fromJSONIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Index of PlayingCardJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Index of PlayingCardJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setIndex(extracted_integer);
      }


    public PlayingCardJSON()
      {
        flagHasWrittenRank = false;
        flagHasSpokenRank = false;
        flagHasWrittenSuit = false;
        flagHasSpokenSuit = false;
        flagHasIndex = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasWrittenRank()
      {
        return flagHasWrittenRank;
      }

    public string  getWrittenRank()
      {
        Debug.Assert(flagHasWrittenRank);
        return storeWrittenRank;
      }

    public bool  hasSpokenRank()
      {
        return flagHasSpokenRank;
      }

    public string  getSpokenRank()
      {
        Debug.Assert(flagHasSpokenRank);
        return storeSpokenRank;
      }

    public bool  hasWrittenSuit()
      {
        return flagHasWrittenSuit;
      }

    public TypeWrittenSuit  getWrittenSuit()
      {
        Debug.Assert(flagHasWrittenSuit);
        return storeWrittenSuit;
      }

    public string  getWrittenSuitAsString()
      {
        TypeWrittenSuit result = getWrittenSuit();
        if (result.in_known_list)
            return stringFromWrittenSuit(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasSpokenSuit()
      {
        return flagHasSpokenSuit;
      }

    public string  getSpokenSuit()
      {
        Debug.Assert(flagHasSpokenSuit);
        return storeSpokenSuit;
      }

    public bool  hasIndex()
      {
        return flagHasIndex;
      }

    public sbyte  getIndex()
      {
        Debug.Assert(flagHasIndex);
        return storeIndex;
      }


    public virtual int extraPlayingCardComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPlayingCardComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPlayingCardComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPlayingCardLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setWrittenRank(string new_value)
      {
        flagHasWrittenRank = true;
        storeWrittenRank = new_value;
      }
    public void unsetWrittenRank()
      {
        flagHasWrittenRank = false;
      }
    public void setSpokenRank(string new_value)
      {
        flagHasSpokenRank = true;
        storeSpokenRank = new_value;
      }
    public void unsetSpokenRank()
      {
        flagHasSpokenRank = false;
      }
    public void setWrittenSuit(TypeWrittenSuit new_value)
      {
        flagHasWrittenSuit = true;
        storeWrittenSuit = new_value;
      }
    public void setWrittenSuit(string chars)
      {
        TypeWrittenSuitKnownValues known = stringToWrittenSuit(chars);
        TypeWrittenSuit new_value = new TypeWrittenSuit();
        if (known == TypeWrittenSuitKnownValues.WrittenSuit__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setWrittenSuit(new_value);
      }
    public void setWrittenSuit(TypeWrittenSuitKnownValues new_value)
      {
        TypeWrittenSuit new_full_value = new TypeWrittenSuit();
        Debug.Assert(new_value != TypeWrittenSuitKnownValues.WrittenSuit__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setWrittenSuit(new_full_value);
      }
    public void unsetWrittenSuit()
      {
        flagHasWrittenSuit = false;
      }
    public void setSpokenSuit(string new_value)
      {
        flagHasSpokenSuit = true;
        storeSpokenSuit = new_value;
      }
    public void unsetSpokenSuit()
      {
        flagHasSpokenSuit = false;
      }
    public void setIndex(sbyte new_value)
      {
        flagHasIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field Index of PlayingCardJSON is less than the lower bound (0) for that field.");
        if (new_value > 51)
            throw new Exception("The value for field Index of PlayingCardJSON is greater than the upper bound (51) for that field.");
        storeIndex = new_value;
      }
    public void unsetIndex()
      {
        flagHasIndex = false;
      }

    public virtual void extraPlayingCardAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPlayingCardSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPlayingCardLookup(key);
        if (old_field == null)
          {
            extraPlayingCardAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasWrittenRank);
        if (flagHasWrittenRank)
          {
            handler.start_pair("WrittenRank");
            handler.string_value(storeWrittenRank);
          }
        Debug.Assert(partial_allowed || flagHasSpokenRank);
        if (flagHasSpokenRank)
          {
            handler.start_pair("SpokenRank");
            handler.string_value(storeSpokenRank);
          }
        Debug.Assert(partial_allowed || flagHasWrittenSuit);
        if (flagHasWrittenSuit)
          {
            handler.start_pair("WrittenSuit");
            if (storeWrittenSuit.in_known_list)
              {
                switch (storeWrittenSuit.list_value)
                  {
                    case TypeWrittenSuitKnownValues.WrittenSuit__x2663_:
                        handler.string_value("♣");
                        break;
                    case TypeWrittenSuitKnownValues.WrittenSuit__x2666_:
                        handler.string_value("♦");
                        break;
                    case TypeWrittenSuitKnownValues.WrittenSuit__x2665_:
                        handler.string_value("♥");
                        break;
                    case TypeWrittenSuitKnownValues.WrittenSuit__x2660_:
                        handler.string_value("♠");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeWrittenSuit.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasSpokenSuit);
        if (flagHasSpokenSuit)
          {
            handler.start_pair("SpokenSuit");
            handler.string_value(storeSpokenSuit);
          }
        Debug.Assert(partial_allowed || flagHasIndex);
        if (flagHasIndex)
          {
            handler.start_pair("Index");
            handler.number_value(storeIndex);
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
        if (!(hasWrittenRank()))
          {
            return "When parsing the object for %what%, the \"WrittenRank\" field was missing.";
          }
        if (!(hasSpokenRank()))
          {
            return "When parsing the object for %what%, the \"SpokenRank\" field was missing.";
          }
        if (!(hasWrittenSuit()))
          {
            return "When parsing the object for %what%, the \"WrittenSuit\" field was missing.";
          }
        if (!(hasSpokenSuit()))
          {
            return "When parsing the object for %what%, the \"SpokenSuit\" field was missing.";
          }
        if (!(hasIndex()))
          {
            return "When parsing the object for %what%, the \"Index\" field was missing.";
          }
        return null;
      }

    public static PlayingCardJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PlayingCardJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PlayingCard", ignore_extras);
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
    public static PlayingCardJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PlayingCardJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PlayingCardJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PlayingCard", ignore_extras);
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
    public static PlayingCardJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PlayingCardJSON from_text(string text, bool ignore_extras)
      {
        PlayingCardJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PlayingCard", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PlayingCardJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PlayingCardJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PlayingCardJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PlayingCard", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorWrittenRank;
        private JSONHoldingStringGenerator fieldGeneratorSpokenRank;
    private abstract class FieldGeneratorWrittenSuit : JSONStringGenerator
          {
            protected FieldGeneratorWrittenSuit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorWrittenSuit()
              {
              }
            protected override void handle_result(string result)
              {
                TypeWrittenSuitKnownValues known = stringToWrittenSuit(result);
                TypeWrittenSuit new_value = new TypeWrittenSuit();
                if (known == TypeWrittenSuitKnownValues.WrittenSuit__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeWrittenSuit result);
          };
    private class FieldHoldingGeneratorWrittenSuit : FieldGeneratorWrittenSuit
  {
    protected override void handle_result(TypeWrittenSuit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorWrittenSuit(String what)
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
    public TypeWrittenSuit value;
  };
    private class FieldHoldingArrayGeneratorWrittenSuit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorWrittenSuit
      {
        private FieldHoldingArrayGeneratorWrittenSuit top;

        protected override void handle_result(TypeWrittenSuit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorWrittenSuit init_top)
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
    protected virtual void handle_result(List<TypeWrittenSuit> result)
      {
      }

    public FieldHoldingArrayGeneratorWrittenSuit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeWrittenSuit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorWrittenSuit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeWrittenSuit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeWrittenSuit> value;
  };
        private FieldHoldingGeneratorWrittenSuit fieldGeneratorWrittenSuit;
        private JSONHoldingStringGenerator fieldGeneratorSpokenSuit;
    private class FieldHoldingGeneratorIndex : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorIndex(String what) : base(what, 0, 51)
              {
              }
          };
    private class FieldHoldingArrayGeneratorIndex : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorIndex(String what) : base(what, 0, 51)
              {
              }
          };
        private FieldHoldingGeneratorIndex fieldGeneratorIndex;
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
            PlayingCardJSON result = new PlayingCardJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPlayingCardAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(PlayingCardJSON result)
          {
            if (fieldGeneratorWrittenRank.have_value)
              {
                result.setWrittenRank(fieldGeneratorWrittenRank.value);
                fieldGeneratorWrittenRank.have_value = false;
              }
            else if ((!(result.hasWrittenRank())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenRank\" field was missing.");
              }
            if (fieldGeneratorSpokenRank.have_value)
              {
                result.setSpokenRank(fieldGeneratorSpokenRank.value);
                fieldGeneratorSpokenRank.have_value = false;
              }
            else if ((!(result.hasSpokenRank())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenRank\" field was missing.");
              }
            if (fieldGeneratorWrittenSuit.have_value)
              {
                result.setWrittenSuit(fieldGeneratorWrittenSuit.value);
                fieldGeneratorWrittenSuit.have_value = false;
              }
            else if ((!(result.hasWrittenSuit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenSuit\" field was missing.");
              }
            if (fieldGeneratorSpokenSuit.have_value)
              {
                result.setSpokenSuit(fieldGeneratorSpokenSuit.value);
                fieldGeneratorSpokenSuit.have_value = false;
              }
            else if ((!(result.hasSpokenSuit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenSuit\" field was missing.");
              }
            if (fieldGeneratorIndex.have_value)
              {
                result.setIndex((sbyte)(fieldGeneratorIndex.value));
                fieldGeneratorIndex.have_value = false;
              }
            else if ((!(result.hasIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Index\" field was missing.");
              }
          }
        protected abstract void handle_result(PlayingCardJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "ndex", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorIndex;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "poken", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'R':
                                if ((String.Compare(field_name, 7, "ank", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorSpokenRank;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 7, "uit", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorSpokenSuit;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "ritten", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'R':
                                if ((String.Compare(field_name, 8, "ank", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorWrittenRank;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 8, "uit", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorWrittenSuit;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorWrittenRank = new JSONHoldingStringGenerator("field \"WrittenRank\" of the PlayingCard class");
            fieldGeneratorSpokenRank = new JSONHoldingStringGenerator("field \"SpokenRank\" of the PlayingCard class");
            fieldGeneratorWrittenSuit = new FieldHoldingGeneratorWrittenSuit("field \"WrittenSuit\" of the PlayingCard class");
            fieldGeneratorSpokenSuit = new JSONHoldingStringGenerator("field \"SpokenSuit\" of the PlayingCard class");
            fieldGeneratorIndex = new FieldHoldingGeneratorIndex("field \"Index\" of the PlayingCard class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PlayingCard class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorWrittenRank = new JSONHoldingStringGenerator("field \"WrittenRank\" of the PlayingCard class");
            fieldGeneratorSpokenRank = new JSONHoldingStringGenerator("field \"SpokenRank\" of the PlayingCard class");
            fieldGeneratorWrittenSuit = new FieldHoldingGeneratorWrittenSuit("field \"WrittenSuit\" of the PlayingCard class");
            fieldGeneratorSpokenSuit = new JSONHoldingStringGenerator("field \"SpokenSuit\" of the PlayingCard class");
            fieldGeneratorIndex = new FieldHoldingGeneratorIndex("field \"Index\" of the PlayingCard class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PlayingCard class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorWrittenRank.reset();
            fieldGeneratorSpokenRank.reset();
            fieldGeneratorWrittenSuit.reset();
            fieldGeneratorSpokenSuit.reset();
            fieldGeneratorIndex.reset();
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
        protected override void handle_result(PlayingCardJSON  result)
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
        public PlayingCardJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PlayingCardJSON  result)
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
    protected virtual void handle_result(List<PlayingCardJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PlayingCardJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PlayingCardJSON>();
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
    public List<PlayingCardJSON> value;
  };
  };
