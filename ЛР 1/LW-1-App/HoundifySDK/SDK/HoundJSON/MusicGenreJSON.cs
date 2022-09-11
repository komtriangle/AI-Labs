/* file "MusicGenreJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicGenreJSON : JSONBase
  {
    private bool flagHasBaseGenre;
    private string storeBaseGenre;
    private bool flagHasMatchedGenre;
    private string storeMatchedGenre;
    private bool flagHasDateRange;
    private DateTimeRangeSpecJSON  storeDateRange;


    private void  fromJSONBaseGenre(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BaseGenre of MusicGenreJSON is not a string.");
        setBaseGenre(json_string.getData());
      }


    private void  fromJSONMatchedGenre(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MatchedGenre of MusicGenreJSON is not a string.");
        setMatchedGenre(json_string.getData());
      }


    private void  fromJSONDateRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateRange(convert_classy);
      }


    public MusicGenreJSON()
      {
        flagHasBaseGenre = false;
        flagHasMatchedGenre = false;
        flagHasDateRange = false;
      }

    public bool  hasBaseGenre()
      {
        return flagHasBaseGenre;
      }

    public string  getBaseGenre()
      {
        Debug.Assert(flagHasBaseGenre);
        return storeBaseGenre;
      }

    public bool  hasMatchedGenre()
      {
        return flagHasMatchedGenre;
      }

    public string  getMatchedGenre()
      {
        Debug.Assert(flagHasMatchedGenre);
        return storeMatchedGenre;
      }

    public bool  hasDateRange()
      {
        return flagHasDateRange;
      }

    public DateTimeRangeSpecJSON   getDateRange()
      {
        Debug.Assert(flagHasDateRange);
        return storeDateRange;
      }



    public void setBaseGenre(string new_value)
      {
        flagHasBaseGenre = true;
        storeBaseGenre = new_value;
      }
    public void unsetBaseGenre()
      {
        flagHasBaseGenre = false;
      }
    public void setMatchedGenre(string new_value)
      {
        flagHasMatchedGenre = true;
        storeMatchedGenre = new_value;
      }
    public void unsetMatchedGenre()
      {
        flagHasMatchedGenre = false;
      }
    public void setDateRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDateRange)
          {
          }
        flagHasDateRange = true;
        storeDateRange = new_value;
      }
    public void unsetDateRange()
      {
        if (flagHasDateRange)
          {
          }
        flagHasDateRange = false;
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
        Debug.Assert(partial_allowed || flagHasBaseGenre);
        if (flagHasBaseGenre)
          {
            handler.start_pair("BaseGenre");
            handler.string_value(storeBaseGenre);
          }
        Debug.Assert(partial_allowed || flagHasMatchedGenre);
        if (flagHasMatchedGenre)
          {
            handler.start_pair("MatchedGenre");
            handler.string_value(storeMatchedGenre);
          }
        if (flagHasDateRange)
          {
            handler.start_pair("DateRange");
            if (partial_allowed)
                storeDateRange.write_partial_as_json(handler);
            else
                storeDateRange.write_as_json(handler);
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
        if (!(hasBaseGenre()))
          {
            return "When parsing the object for %what%, the \"BaseGenre\" field was missing.";
          }
        if (!(hasMatchedGenre()))
          {
            return "When parsing the object for %what%, the \"MatchedGenre\" field was missing.";
          }
        return null;
      }

    public static MusicGenreJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicGenreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicGenre", ignore_extras);
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
    public static MusicGenreJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicGenreJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicGenreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicGenre", ignore_extras);
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
    public static MusicGenreJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicGenreJSON from_text(string text, bool ignore_extras)
      {
        MusicGenreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicGenre", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicGenreJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicGenreJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicGenreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicGenre", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorBaseGenre;
        private JSONHoldingStringGenerator fieldGeneratorMatchedGenre;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateRange;

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
            MusicGenreJSON result = new MusicGenreJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicGenreJSON result)
          {
            if (fieldGeneratorBaseGenre.have_value)
              {
                result.setBaseGenre(fieldGeneratorBaseGenre.value);
                fieldGeneratorBaseGenre.have_value = false;
              }
            else if ((!(result.hasBaseGenre())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"BaseGenre\" field was missing.");
              }
            if (fieldGeneratorMatchedGenre.have_value)
              {
                result.setMatchedGenre(fieldGeneratorMatchedGenre.value);
                fieldGeneratorMatchedGenre.have_value = false;
              }
            else if ((!(result.hasMatchedGenre())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MatchedGenre\" field was missing.");
              }
            if (fieldGeneratorDateRange.have_value)
              {
                result.setDateRange(fieldGeneratorDateRange.value);
                fieldGeneratorDateRange.have_value = false;
              }
          }
        protected abstract void handle_result(MusicGenreJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "aseGenre", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorBaseGenre;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ateRange", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDateRange;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "atchedGenre", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorMatchedGenre;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorBaseGenre = new JSONHoldingStringGenerator("field \"BaseGenre\" of the MusicGenre class");
            fieldGeneratorMatchedGenre = new JSONHoldingStringGenerator("field \"MatchedGenre\" of the MusicGenre class");
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the MusicGenre class", ignore_extras);
            set_what("the MusicGenre class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorBaseGenre = new JSONHoldingStringGenerator("field \"BaseGenre\" of the MusicGenre class");
            fieldGeneratorMatchedGenre = new JSONHoldingStringGenerator("field \"MatchedGenre\" of the MusicGenre class");
            fieldGeneratorDateRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateRange\" of the MusicGenre class", false);
            set_what("the MusicGenre class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorBaseGenre.reset();
            fieldGeneratorMatchedGenre.reset();
            fieldGeneratorDateRange.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDateRange.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDateRange.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicGenreJSON  result)
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
        public MusicGenreJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicGenreJSON  result)
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
    protected virtual void handle_result(List<MusicGenreJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicGenreJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicGenreJSON>();
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
    public List<MusicGenreJSON> value;
  };
  };
