/* file "IHeartRadioSearchAllAPIResponseBestMatchJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioSearchAllAPIResponseBestMatchJSON : JSONBase
  {
    public enum TypeformatKnownValues
      {
        format_ALBUM,
        format_ARTIST,
        format_PLAYLIST,
        format_STATION,
        format_TRACK,
        format__none
      };
    public struct Typeformat
      {
        public bool in_known_list;
        public string string_value;
        public TypeformatKnownValues list_value;
      };

    public static TypeformatKnownValues  stringToformat(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'L':
                        if ((String.Compare(chars, 2, "BUM", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeformatKnownValues.format_ALBUM;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 2, "TIST", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeformatKnownValues.format_ARTIST;
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                if ((String.Compare(chars, 1, "LAYLIST", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeformatKnownValues.format_PLAYLIST;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "TATION", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeformatKnownValues.format_STATION;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "RACK", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeformatKnownValues.format_TRACK;
                break;
            default:
                break;
          }
        return TypeformatKnownValues.format__none;
      }

    public static string  stringFromformat(TypeformatKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeformatKnownValues.format_ALBUM:
                return "ALBUM";
            case TypeformatKnownValues.format_ARTIST:
                return "ARTIST";
            case TypeformatKnownValues.format_PLAYLIST:
                return "PLAYLIST";
            case TypeformatKnownValues.format_STATION:
                return "STATION";
            case TypeformatKnownValues.format_TRACK:
                return "TRACK";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasid;
    private BigInteger storeid;
    private bool flagHasformat;
    private Typeformat storeformat;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field id of IHeartRadioSearchAllAPIResponseBestMatchJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field id of IHeartRadioSearchAllAPIResponseBestMatchJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setid(extracted_integer);
      }


    private void  fromJSONformat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field format of IHeartRadioSearchAllAPIResponseBestMatchJSON is not a string.");
        Typeformat the_open_enum = new Typeformat();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'L':
                        if ((String.Compare(json_string.getData(), 2, "BUM", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeformatKnownValues.format_ALBUM;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 2, "TIST", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeformatKnownValues.format_ARTIST;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "LAYLIST", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeformatKnownValues.format_PLAYLIST;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "TATION", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeformatKnownValues.format_STATION;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "RACK", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeformatKnownValues.format_TRACK;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setformat(the_open_enum);
      }


    public IHeartRadioSearchAllAPIResponseBestMatchJSON()
      {
        flagHasid = false;
        flagHasformat = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasid()
      {
        return flagHasid;
      }

    public BigInteger  getid()
      {
        Debug.Assert(flagHasid);
        return storeid;
      }

    public bool  hasformat()
      {
        return flagHasformat;
      }

    public Typeformat  getformat()
      {
        Debug.Assert(flagHasformat);
        return storeformat;
      }

    public string  getformatAsString()
      {
        Typeformat result = getformat();
        if (result.in_known_list)
            return stringFromformat(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraIHeartRadioSearchAllAPIResponseBestMatchComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioSearchAllAPIResponseBestMatchComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponseBestMatchComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponseBestMatchLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setid(BigInteger new_value)
      {
        flagHasid = true;
        storeid = new_value;
      }
    public void unsetid()
      {
        flagHasid = false;
      }
    public void setformat(Typeformat new_value)
      {
        flagHasformat = true;
        storeformat = new_value;
      }
    public void setformat(string chars)
      {
        TypeformatKnownValues known = stringToformat(chars);
        Typeformat new_value = new Typeformat();
        if (known == TypeformatKnownValues.format__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setformat(new_value);
      }
    public void setformat(TypeformatKnownValues new_value)
      {
        Typeformat new_full_value = new Typeformat();
        Debug.Assert(new_value != TypeformatKnownValues.format__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setformat(new_full_value);
      }
    public void unsetformat()
      {
        flagHasformat = false;
      }

    public virtual void extraIHeartRadioSearchAllAPIResponseBestMatchAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioSearchAllAPIResponseBestMatchSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioSearchAllAPIResponseBestMatchLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioSearchAllAPIResponseBestMatchAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasid);
        if (flagHasid)
          {
            handler.start_pair("id");
            handler.number_value(storeid);
          }
        Debug.Assert(partial_allowed || flagHasformat);
        if (flagHasformat)
          {
            handler.start_pair("format");
            if (storeformat.in_known_list)
              {
                switch (storeformat.list_value)
                  {
                    case TypeformatKnownValues.format_ALBUM:
                        handler.string_value("ALBUM");
                        break;
                    case TypeformatKnownValues.format_ARTIST:
                        handler.string_value("ARTIST");
                        break;
                    case TypeformatKnownValues.format_PLAYLIST:
                        handler.string_value("PLAYLIST");
                        break;
                    case TypeformatKnownValues.format_STATION:
                        handler.string_value("STATION");
                        break;
                    case TypeformatKnownValues.format_TRACK:
                        handler.string_value("TRACK");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeformat.string_value);
              }
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
        if (!(hasid()))
          {
            return "When parsing the object for %what%, the \"id\" field was missing.";
          }
        if (!(hasformat()))
          {
            return "When parsing the object for %what%, the \"format\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioSearchAllAPIResponseBestMatchJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponseBestMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseBestMatch", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponseBestMatchJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponseBestMatchJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponseBestMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseBestMatch", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponseBestMatchJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponseBestMatchJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponseBestMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseBestMatch", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioSearchAllAPIResponseBestMatchJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioSearchAllAPIResponseBestMatchJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponseBestMatchJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseBestMatch", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorid : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorid(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorid : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorid(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorid fieldGeneratorid;
    private abstract class FieldGeneratorformat : JSONStringGenerator
          {
            protected FieldGeneratorformat(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorformat()
              {
              }
            protected override void handle_result(string result)
              {
                TypeformatKnownValues known = stringToformat(result);
                Typeformat new_value = new Typeformat();
                if (known == TypeformatKnownValues.format__none)
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
            protected abstract void handle_result(Typeformat result);
          };
    private class FieldHoldingGeneratorformat : FieldGeneratorformat
  {
    protected override void handle_result(Typeformat result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorformat(String what)
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
    public Typeformat value;
  };
    private class FieldHoldingArrayGeneratorformat : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorformat
      {
        private FieldHoldingArrayGeneratorformat top;

        protected override void handle_result(Typeformat result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorformat init_top)
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
    protected virtual void handle_result(List<Typeformat> result)
      {
      }

    public FieldHoldingArrayGeneratorformat(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<Typeformat>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorformat()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<Typeformat>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typeformat> value;
  };
        private FieldHoldingGeneratorformat fieldGeneratorformat;
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
            IHeartRadioSearchAllAPIResponseBestMatchJSON result = new IHeartRadioSearchAllAPIResponseBestMatchJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioSearchAllAPIResponseBestMatchAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioSearchAllAPIResponseBestMatchJSON result)
          {
            if (fieldGeneratorid.have_value)
              {
                result.setid(fieldGeneratorid.value);
                fieldGeneratorid.have_value = false;
              }
            else if ((!(result.hasid())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"id\" field was missing.");
              }
            if (fieldGeneratorformat.have_value)
              {
                result.setformat(fieldGeneratorformat.value);
                fieldGeneratorformat.have_value = false;
              }
            else if ((!(result.hasformat())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"format\" field was missing.");
              }
          }
        protected abstract void handle_result(IHeartRadioSearchAllAPIResponseBestMatchJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'f':
                    if ((String.Compare(field_name, 1, "ormat", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorformat;
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorid;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorid = new FieldHoldingGeneratorid("field \"id\" of the IHeartRadioSearchAllAPIResponseBestMatch class");
            fieldGeneratorformat = new FieldHoldingGeneratorformat("field \"format\" of the IHeartRadioSearchAllAPIResponseBestMatch class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioSearchAllAPIResponseBestMatch class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorid = new FieldHoldingGeneratorid("field \"id\" of the IHeartRadioSearchAllAPIResponseBestMatch class");
            fieldGeneratorformat = new FieldHoldingGeneratorformat("field \"format\" of the IHeartRadioSearchAllAPIResponseBestMatch class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioSearchAllAPIResponseBestMatch class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorid.reset();
            fieldGeneratorformat.reset();
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
        protected override void handle_result(IHeartRadioSearchAllAPIResponseBestMatchJSON  result)
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
        public IHeartRadioSearchAllAPIResponseBestMatchJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioSearchAllAPIResponseBestMatchJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioSearchAllAPIResponseBestMatchJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioSearchAllAPIResponseBestMatchJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioSearchAllAPIResponseBestMatchJSON>();
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
    public List<IHeartRadioSearchAllAPIResponseBestMatchJSON> value;
  };
  };
