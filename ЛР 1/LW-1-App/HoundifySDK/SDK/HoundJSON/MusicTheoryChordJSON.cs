/* file "MusicTheoryChordJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MusicTheoryChordJSON : JSONBase
  {
    public enum TypeQualityKnownValues
      {
        Quality_Major,
        Quality_Minor,
        Quality_Augmented,
        Quality_Diminished,
        Quality_Seven,
        Quality__none
      };
    public struct TypeQuality
      {
        public bool in_known_list;
        public string string_value;
        public TypeQualityKnownValues list_value;
      };

    public static TypeQualityKnownValues  stringToQuality(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ugmented", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeQualityKnownValues.Quality_Augmented;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "iminished", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeQualityKnownValues.Quality_Diminished;
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "jor", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeQualityKnownValues.Quality_Major;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "nor", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeQualityKnownValues.Quality_Minor;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "even", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeQualityKnownValues.Quality_Seven;
                break;
            default:
                break;
          }
        return TypeQualityKnownValues.Quality__none;
      }

    public static string  stringFromQuality(TypeQualityKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeQualityKnownValues.Quality_Major:
                return "Major";
            case TypeQualityKnownValues.Quality_Minor:
                return "Minor";
            case TypeQualityKnownValues.Quality_Augmented:
                return "Augmented";
            case TypeQualityKnownValues.Quality_Diminished:
                return "Diminished";
            case TypeQualityKnownValues.Quality_Seven:
                return "Seven";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasRoot;
    private MusicTheoryNoteJSON  storeRoot;
    private bool flagHasRootIndex;
    private BigInteger storeRootIndex;
    private bool flagHasQuality;
    private TypeQuality storeQuality;
    private bool flagHasQualityIndex;
    private BigInteger storeQualityIndex;
    private bool flagHasInversion;
    private BigInteger storeInversion;
    private bool flagHasInstrument;
    private string storeInstrument;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRoot(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicTheoryNoteJSON convert_classy = MusicTheoryNoteJSON.from_json(json_value, ignore_extras, true);
        setRoot(convert_classy);
      }


    private void  fromJSONRootIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RootIndex of MusicTheoryChordJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RootIndex of MusicTheoryChordJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRootIndex(extracted_integer);
      }


    private void  fromJSONQuality(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Quality of MusicTheoryChordJSON is not a string.");
        TypeQuality the_open_enum = new TypeQuality();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ugmented", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQualityKnownValues.Quality_Augmented;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "iminished", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQualityKnownValues.Quality_Diminished;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "jor", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeQualityKnownValues.Quality_Major;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "nor", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeQualityKnownValues.Quality_Minor;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "even", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQualityKnownValues.Quality_Seven;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setQuality(the_open_enum);
      }


    private void  fromJSONQualityIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field QualityIndex of MusicTheoryChordJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field QualityIndex of MusicTheoryChordJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setQualityIndex(extracted_integer);
      }


    private void  fromJSONInversion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Inversion of MusicTheoryChordJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Inversion of MusicTheoryChordJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setInversion(extracted_integer);
      }


    private void  fromJSONInstrument(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Instrument of MusicTheoryChordJSON is not a string.");
        setInstrument(json_string.getData());
      }


    public MusicTheoryChordJSON()
      {
        flagHasRoot = false;
        flagHasRootIndex = false;
        flagHasQuality = false;
        flagHasQualityIndex = false;
        flagHasInversion = false;
        flagHasInstrument = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRoot()
      {
        return flagHasRoot;
      }

    public MusicTheoryNoteJSON   getRoot()
      {
        Debug.Assert(flagHasRoot);
        return storeRoot;
      }

    public bool  hasRootIndex()
      {
        return flagHasRootIndex;
      }

    public BigInteger  getRootIndex()
      {
        Debug.Assert(flagHasRootIndex);
        return storeRootIndex;
      }

    public bool  hasQuality()
      {
        return flagHasQuality;
      }

    public TypeQuality  getQuality()
      {
        Debug.Assert(flagHasQuality);
        return storeQuality;
      }

    public string  getQualityAsString()
      {
        TypeQuality result = getQuality();
        if (result.in_known_list)
            return stringFromQuality(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasQualityIndex()
      {
        return flagHasQualityIndex;
      }

    public BigInteger  getQualityIndex()
      {
        Debug.Assert(flagHasQualityIndex);
        return storeQualityIndex;
      }

    public bool  hasInversion()
      {
        return flagHasInversion;
      }

    public BigInteger  getInversion()
      {
        Debug.Assert(flagHasInversion);
        return storeInversion;
      }

    public bool  hasInstrument()
      {
        return flagHasInstrument;
      }

    public string  getInstrument()
      {
        Debug.Assert(flagHasInstrument);
        return storeInstrument;
      }


    public virtual int extraMusicTheoryChordComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMusicTheoryChordComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMusicTheoryChordComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMusicTheoryChordLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRoot(MusicTheoryNoteJSON  new_value)
      {
        if (flagHasRoot)
          {
          }
        flagHasRoot = true;
        storeRoot = new_value;
      }
    public void unsetRoot()
      {
        if (flagHasRoot)
          {
          }
        flagHasRoot = false;
      }
    public void setRootIndex(BigInteger new_value)
      {
        flagHasRootIndex = true;
        storeRootIndex = new_value;
      }
    public void unsetRootIndex()
      {
        flagHasRootIndex = false;
      }
    public void setQuality(TypeQuality new_value)
      {
        flagHasQuality = true;
        storeQuality = new_value;
      }
    public void setQuality(string chars)
      {
        TypeQualityKnownValues known = stringToQuality(chars);
        TypeQuality new_value = new TypeQuality();
        if (known == TypeQualityKnownValues.Quality__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQuality(new_value);
      }
    public void setQuality(TypeQualityKnownValues new_value)
      {
        TypeQuality new_full_value = new TypeQuality();
        Debug.Assert(new_value != TypeQualityKnownValues.Quality__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setQuality(new_full_value);
      }
    public void unsetQuality()
      {
        flagHasQuality = false;
      }
    public void setQualityIndex(BigInteger new_value)
      {
        flagHasQualityIndex = true;
        storeQualityIndex = new_value;
      }
    public void unsetQualityIndex()
      {
        flagHasQualityIndex = false;
      }
    public void setInversion(BigInteger new_value)
      {
        flagHasInversion = true;
        storeInversion = new_value;
      }
    public void unsetInversion()
      {
        flagHasInversion = false;
      }
    public void setInstrument(string new_value)
      {
        flagHasInstrument = true;
        storeInstrument = new_value;
      }
    public void unsetInstrument()
      {
        flagHasInstrument = false;
      }

    public virtual void extraMusicTheoryChordAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMusicTheoryChordSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMusicTheoryChordLookup(key);
        if (old_field == null)
          {
            extraMusicTheoryChordAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRoot);
        if (flagHasRoot)
          {
            handler.start_pair("Root");
            if (partial_allowed)
                storeRoot.write_partial_as_json(handler);
            else
                storeRoot.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRootIndex);
        if (flagHasRootIndex)
          {
            handler.start_pair("RootIndex");
            handler.number_value(storeRootIndex);
          }
        Debug.Assert(partial_allowed || flagHasQuality);
        if (flagHasQuality)
          {
            handler.start_pair("Quality");
            if (storeQuality.in_known_list)
              {
                switch (storeQuality.list_value)
                  {
                    case TypeQualityKnownValues.Quality_Major:
                        handler.string_value("Major");
                        break;
                    case TypeQualityKnownValues.Quality_Minor:
                        handler.string_value("Minor");
                        break;
                    case TypeQualityKnownValues.Quality_Augmented:
                        handler.string_value("Augmented");
                        break;
                    case TypeQualityKnownValues.Quality_Diminished:
                        handler.string_value("Diminished");
                        break;
                    case TypeQualityKnownValues.Quality_Seven:
                        handler.string_value("Seven");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeQuality.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasQualityIndex);
        if (flagHasQualityIndex)
          {
            handler.start_pair("QualityIndex");
            handler.number_value(storeQualityIndex);
          }
        if (flagHasInversion)
          {
            handler.start_pair("Inversion");
            handler.number_value(storeInversion);
          }
        if (flagHasInstrument)
          {
            handler.start_pair("Instrument");
            handler.string_value(storeInstrument);
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
        if (!(hasRoot()))
          {
            return "When parsing the object for %what%, the \"Root\" field was missing.";
          }
        if (!(hasRootIndex()))
          {
            return "When parsing the object for %what%, the \"RootIndex\" field was missing.";
          }
        if (!(hasQuality()))
          {
            return "When parsing the object for %what%, the \"Quality\" field was missing.";
          }
        if (!(hasQualityIndex()))
          {
            return "When parsing the object for %what%, the \"QualityIndex\" field was missing.";
          }
        return null;
      }

    public static MusicTheoryChordJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTheoryChordJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryChord", ignore_extras);
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
    public static MusicTheoryChordJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicTheoryChordJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTheoryChordJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryChord", ignore_extras);
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
    public static MusicTheoryChordJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicTheoryChordJSON from_text(string text, bool ignore_extras)
      {
        MusicTheoryChordJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryChord", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicTheoryChordJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicTheoryChordJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicTheoryChordJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTheoryChord", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MusicTheoryNoteJSON.HoldingGenerator fieldGeneratorRoot;
    private class FieldHoldingGeneratorRootIndex : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorRootIndex(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorRootIndex : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorRootIndex(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorRootIndex fieldGeneratorRootIndex;
    private abstract class FieldGeneratorQuality : JSONStringGenerator
          {
            protected FieldGeneratorQuality(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQuality()
              {
              }
            protected override void handle_result(string result)
              {
                TypeQualityKnownValues known = stringToQuality(result);
                TypeQuality new_value = new TypeQuality();
                if (known == TypeQualityKnownValues.Quality__none)
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
            protected abstract void handle_result(TypeQuality result);
          };
    private class FieldHoldingGeneratorQuality : FieldGeneratorQuality
  {
    protected override void handle_result(TypeQuality result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQuality(String what)
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
    public TypeQuality value;
  };
    private class FieldHoldingArrayGeneratorQuality : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQuality
      {
        private FieldHoldingArrayGeneratorQuality top;

        protected override void handle_result(TypeQuality result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQuality init_top)
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
    protected virtual void handle_result(List<TypeQuality> result)
      {
      }

    public FieldHoldingArrayGeneratorQuality(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQuality>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQuality()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQuality>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQuality> value;
  };
        private FieldHoldingGeneratorQuality fieldGeneratorQuality;
    private class FieldHoldingGeneratorQualityIndex : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorQualityIndex(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorQualityIndex : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorQualityIndex(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorQualityIndex fieldGeneratorQualityIndex;
    private class FieldHoldingGeneratorInversion : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorInversion(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorInversion : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorInversion(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorInversion fieldGeneratorInversion;
        private JSONHoldingStringGenerator fieldGeneratorInstrument;
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
            MusicTheoryChordJSON result = new MusicTheoryChordJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicTheoryChordAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MusicTheoryChordJSON result)
          {
            if (fieldGeneratorRoot.have_value)
              {
                result.setRoot(fieldGeneratorRoot.value);
                fieldGeneratorRoot.have_value = false;
              }
            else if ((!(result.hasRoot())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Root\" field was missing.");
              }
            if (fieldGeneratorRootIndex.have_value)
              {
                result.setRootIndex(fieldGeneratorRootIndex.value);
                fieldGeneratorRootIndex.have_value = false;
              }
            else if ((!(result.hasRootIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RootIndex\" field was missing.");
              }
            if (fieldGeneratorQuality.have_value)
              {
                result.setQuality(fieldGeneratorQuality.value);
                fieldGeneratorQuality.have_value = false;
              }
            else if ((!(result.hasQuality())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Quality\" field was missing.");
              }
            if (fieldGeneratorQualityIndex.have_value)
              {
                result.setQualityIndex(fieldGeneratorQualityIndex.value);
                fieldGeneratorQualityIndex.have_value = false;
              }
            else if ((!(result.hasQualityIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QualityIndex\" field was missing.");
              }
            if (fieldGeneratorInversion.have_value)
              {
                result.setInversion(fieldGeneratorInversion.value);
                fieldGeneratorInversion.have_value = false;
              }
            if (fieldGeneratorInstrument.have_value)
              {
                result.setInstrument(fieldGeneratorInstrument.value);
                fieldGeneratorInstrument.have_value = false;
              }
          }
        protected abstract void handle_result(MusicTheoryChordJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if (String.Compare(field_name, 1, "n", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 's':
                                if ((String.Compare(field_name, 3, "trument", 0, 7, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorInstrument;
                                break;
                            case 'v':
                                if ((String.Compare(field_name, 3, "ersion", 0, 6, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorInversion;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Q':
                    if (String.Compare(field_name, 1, "uality", 0, 6, false) == 0)
                      {
                        if (field_name.Length == 7)
                          {
                            return fieldGeneratorQuality;
                          }
                        switch (field_name[7])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 8, "ndex", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorQualityIndex;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "oot", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorRoot;
                          }
                        switch (field_name[4])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 5, "ndex", 0, 4, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorRootIndex;
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
            fieldGeneratorRoot = new MusicTheoryNoteJSON.HoldingGenerator("field \"Root\" of the MusicTheoryChord class", ignore_extras);
            fieldGeneratorRootIndex = new FieldHoldingGeneratorRootIndex("field \"RootIndex\" of the MusicTheoryChord class");
            fieldGeneratorQuality = new FieldHoldingGeneratorQuality("field \"Quality\" of the MusicTheoryChord class");
            fieldGeneratorQualityIndex = new FieldHoldingGeneratorQualityIndex("field \"QualityIndex\" of the MusicTheoryChord class");
            fieldGeneratorInversion = new FieldHoldingGeneratorInversion("field \"Inversion\" of the MusicTheoryChord class");
            fieldGeneratorInstrument = new JSONHoldingStringGenerator("field \"Instrument\" of the MusicTheoryChord class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MusicTheoryChord class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRoot = new MusicTheoryNoteJSON.HoldingGenerator("field \"Root\" of the MusicTheoryChord class", false);
            fieldGeneratorRootIndex = new FieldHoldingGeneratorRootIndex("field \"RootIndex\" of the MusicTheoryChord class");
            fieldGeneratorQuality = new FieldHoldingGeneratorQuality("field \"Quality\" of the MusicTheoryChord class");
            fieldGeneratorQualityIndex = new FieldHoldingGeneratorQualityIndex("field \"QualityIndex\" of the MusicTheoryChord class");
            fieldGeneratorInversion = new FieldHoldingGeneratorInversion("field \"Inversion\" of the MusicTheoryChord class");
            fieldGeneratorInstrument = new JSONHoldingStringGenerator("field \"Instrument\" of the MusicTheoryChord class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MusicTheoryChord class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRoot.reset();
            fieldGeneratorRootIndex.reset();
            fieldGeneratorQuality.reset();
            fieldGeneratorQualityIndex.reset();
            fieldGeneratorInversion.reset();
            fieldGeneratorInstrument.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRoot.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRoot.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicTheoryChordJSON  result)
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
        public MusicTheoryChordJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicTheoryChordJSON  result)
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
    protected virtual void handle_result(List<MusicTheoryChordJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicTheoryChordJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicTheoryChordJSON>();
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
    public List<MusicTheoryChordJSON> value;
  };
  };
