/* file "MusicThirdPartyJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicThirdPartyJSON : JSONBase
  {
    public enum TypeNameKnownValues
      {
        Name_SoundHound,
        Name_Pandora,
        Name_Spotify,
        Name_Rdio,
        Name_YouTube,
        Name_SoundCloud,
        Name_AppleMusic,
        Name_GoogleMusic,
        Name_Deezer,
        Name_AmazonPrimeMusic,
        Name_Tidal,
        Name_Default,
        Name_SlackerRadio,
        Name_Vevo,
        Name_iHeartRadio,
        Name__none
      };
    public struct TypeName
      {
        public bool in_known_list;
        public string string_value;
        public TypeNameKnownValues list_value;
      };

    public static TypeNameKnownValues  stringToName(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'm':
                        if ((String.Compare(chars, 2, "azonPrimeMusic", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypeNameKnownValues.Name_AmazonPrimeMusic;
                        break;
                    case 'p':
                        if ((String.Compare(chars, 2, "pleMusic", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeNameKnownValues.Name_AppleMusic;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(chars, 1, "e", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'e':
                            if ((String.Compare(chars, 3, "zer", 0, 3, false) == 0) && (chars.Length == 6))
                                return TypeNameKnownValues.Name_Deezer;
                            break;
                        case 'f':
                            if ((String.Compare(chars, 3, "ault", 0, 4, false) == 0) && (chars.Length == 7))
                                return TypeNameKnownValues.Name_Default;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'G':
                if ((String.Compare(chars, 1, "oogleMusic", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeNameKnownValues.Name_GoogleMusic;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "andora", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNameKnownValues.Name_Pandora;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "dio", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeNameKnownValues.Name_Rdio;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "ackerRadio", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeNameKnownValues.Name_SlackerRadio;
                        break;
                    case 'o':
                        if (String.Compare(chars, 2, "und", 0, 3, false) == 0)
                          {
                            switch (chars[5])
                              {
                                case 'C':
                                    if ((String.Compare(chars, 6, "loud", 0, 4, false) == 0) && (chars.Length == 10))
                                        return TypeNameKnownValues.Name_SoundCloud;
                                    break;
                                case 'H':
                                    if ((String.Compare(chars, 6, "ound", 0, 4, false) == 0) && (chars.Length == 10))
                                        return TypeNameKnownValues.Name_SoundHound;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'p':
                        if ((String.Compare(chars, 2, "otify", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeNameKnownValues.Name_Spotify;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "idal", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeNameKnownValues.Name_Tidal;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "evo", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeNameKnownValues.Name_Vevo;
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "ouTube", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNameKnownValues.Name_YouTube;
                break;
            case 'i':
                if ((String.Compare(chars, 1, "HeartRadio", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeNameKnownValues.Name_iHeartRadio;
                break;
            default:
                break;
          }
        return TypeNameKnownValues.Name__none;
      }

    public static string  stringFromName(TypeNameKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeNameKnownValues.Name_SoundHound:
                return "SoundHound";
            case TypeNameKnownValues.Name_Pandora:
                return "Pandora";
            case TypeNameKnownValues.Name_Spotify:
                return "Spotify";
            case TypeNameKnownValues.Name_Rdio:
                return "Rdio";
            case TypeNameKnownValues.Name_YouTube:
                return "YouTube";
            case TypeNameKnownValues.Name_SoundCloud:
                return "SoundCloud";
            case TypeNameKnownValues.Name_AppleMusic:
                return "AppleMusic";
            case TypeNameKnownValues.Name_GoogleMusic:
                return "GoogleMusic";
            case TypeNameKnownValues.Name_Deezer:
                return "Deezer";
            case TypeNameKnownValues.Name_AmazonPrimeMusic:
                return "AmazonPrimeMusic";
            case TypeNameKnownValues.Name_Tidal:
                return "Tidal";
            case TypeNameKnownValues.Name_Default:
                return "Default";
            case TypeNameKnownValues.Name_SlackerRadio:
                return "SlackerRadio";
            case TypeNameKnownValues.Name_Vevo:
                return "Vevo";
            case TypeNameKnownValues.Name_iHeartRadio:
                return "iHeartRadio";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasName;
    private TypeName storeName;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of MusicThirdPartyJSON is not a string.");
        TypeName the_open_enum = new TypeName();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'm':
                        if ((String.Compare(json_string.getData(), 2, "azonPrimeMusic", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNameKnownValues.Name_AmazonPrimeMusic;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'p':
                        if ((String.Compare(json_string.getData(), 2, "pleMusic", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNameKnownValues.Name_AppleMusic;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(json_string.getData(), 1, "e", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'e':
                            if ((String.Compare(json_string.getData(), 3, "zer", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeNameKnownValues.Name_Deezer;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'f':
                            if ((String.Compare(json_string.getData(), 3, "ault", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeNameKnownValues.Name_Default;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "oogleMusic", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNameKnownValues.Name_GoogleMusic;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "andora", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNameKnownValues.Name_Pandora;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "dio", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNameKnownValues.Name_Rdio;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ackerRadio", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNameKnownValues.Name_SlackerRadio;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "und", 0, 3, false) == 0)
                          {
                            switch (json_string.getData()[5])
                              {
                                case 'C':
                                    if ((String.Compare(json_string.getData(), 6, "loud", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNameKnownValues.Name_SoundCloud;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'H':
                                    if ((String.Compare(json_string.getData(), 6, "ound", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNameKnownValues.Name_SoundHound;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'p':
                        if ((String.Compare(json_string.getData(), 2, "otify", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNameKnownValues.Name_Spotify;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "idal", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNameKnownValues.Name_Tidal;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "evo", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNameKnownValues.Name_Vevo;
                        goto open_enum_is_done;
                      }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "ouTube", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNameKnownValues.Name_YouTube;
                        goto open_enum_is_done;
                      }
                break;
            case 'i':
                if ((String.Compare(json_string.getData(), 1, "HeartRadio", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNameKnownValues.Name_iHeartRadio;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setName(the_open_enum);
      }


    public MusicThirdPartyJSON()
      {
        flagHasName = false;
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public TypeName  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public string  getNameAsString()
      {
        TypeName result = getName();
        if (result.in_known_list)
            return stringFromName(result.list_value);
        else
            return result.string_value;
      }



    public void setName(TypeName new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void setName(string chars)
      {
        TypeNameKnownValues known = stringToName(chars);
        TypeName new_value = new TypeName();
        if (known == TypeNameKnownValues.Name__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setName(new_value);
      }
    public void setName(TypeNameKnownValues new_value)
      {
        TypeName new_full_value = new TypeName();
        Debug.Assert(new_value != TypeNameKnownValues.Name__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setName(new_full_value);
      }
    public void unsetName()
      {
        flagHasName = false;
      }


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
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            if (storeName.in_known_list)
              {
                switch (storeName.list_value)
                  {
                    case TypeNameKnownValues.Name_SoundHound:
                        handler.string_value("SoundHound");
                        break;
                    case TypeNameKnownValues.Name_Pandora:
                        handler.string_value("Pandora");
                        break;
                    case TypeNameKnownValues.Name_Spotify:
                        handler.string_value("Spotify");
                        break;
                    case TypeNameKnownValues.Name_Rdio:
                        handler.string_value("Rdio");
                        break;
                    case TypeNameKnownValues.Name_YouTube:
                        handler.string_value("YouTube");
                        break;
                    case TypeNameKnownValues.Name_SoundCloud:
                        handler.string_value("SoundCloud");
                        break;
                    case TypeNameKnownValues.Name_AppleMusic:
                        handler.string_value("AppleMusic");
                        break;
                    case TypeNameKnownValues.Name_GoogleMusic:
                        handler.string_value("GoogleMusic");
                        break;
                    case TypeNameKnownValues.Name_Deezer:
                        handler.string_value("Deezer");
                        break;
                    case TypeNameKnownValues.Name_AmazonPrimeMusic:
                        handler.string_value("AmazonPrimeMusic");
                        break;
                    case TypeNameKnownValues.Name_Tidal:
                        handler.string_value("Tidal");
                        break;
                    case TypeNameKnownValues.Name_Default:
                        handler.string_value("Default");
                        break;
                    case TypeNameKnownValues.Name_SlackerRadio:
                        handler.string_value("SlackerRadio");
                        break;
                    case TypeNameKnownValues.Name_Vevo:
                        handler.string_value("Vevo");
                        break;
                    case TypeNameKnownValues.Name_iHeartRadio:
                        handler.string_value("iHeartRadio");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeName.string_value);
              }
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        return null;
      }

    public static MusicThirdPartyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicThirdPartyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicThirdParty", ignore_extras);
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
    public static MusicThirdPartyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicThirdPartyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicThirdPartyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicThirdParty", ignore_extras);
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
    public static MusicThirdPartyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicThirdPartyJSON from_text(string text, bool ignore_extras)
      {
        MusicThirdPartyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicThirdParty", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicThirdPartyJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicThirdPartyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicThirdPartyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicThirdParty", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorName : JSONStringGenerator
          {
            protected FieldGeneratorName(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorName()
              {
              }
            protected override void handle_result(string result)
              {
                TypeNameKnownValues known = stringToName(result);
                TypeName new_value = new TypeName();
                if (known == TypeNameKnownValues.Name__none)
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
            protected abstract void handle_result(TypeName result);
          };
    private class FieldHoldingGeneratorName : FieldGeneratorName
  {
    protected override void handle_result(TypeName result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorName(String what)
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
    public TypeName value;
  };
    private class FieldHoldingArrayGeneratorName : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorName
      {
        private FieldHoldingArrayGeneratorName top;

        protected override void handle_result(TypeName result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorName init_top)
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
    protected virtual void handle_result(List<TypeName> result)
      {
      }

    public FieldHoldingArrayGeneratorName(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeName>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorName()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeName>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeName> value;
  };
        private FieldHoldingGeneratorName fieldGeneratorName;

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
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            MusicThirdPartyJSON result = new MusicThirdPartyJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicThirdPartyJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
          }
        protected abstract void handle_result(MusicThirdPartyJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Name", 0, 4, false) == 0) && (field_name.Length == 4))
                return fieldGeneratorName;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new FieldHoldingGeneratorName("field \"Name\" of the MusicThirdParty class");
            set_what("the MusicThirdParty class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new FieldHoldingGeneratorName("field \"Name\" of the MusicThirdParty class");
            set_what("the MusicThirdParty class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            base.reset();
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
        protected override void handle_result(MusicThirdPartyJSON  result)
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
        public MusicThirdPartyJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicThirdPartyJSON  result)
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
    protected virtual void handle_result(List<MusicThirdPartyJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicThirdPartyJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicThirdPartyJSON>();
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
    public List<MusicThirdPartyJSON> value;
  };
  };
