/* file "MusicVideoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicVideoJSON : JSONBase
  {
    private bool flagHasVideoID;
    private string storeVideoID;
    private bool flagHasAutoPlayPreview;
    private bool storeAutoPlayPreview;
    private bool flagHasTrack;
    private MusicTrackJSON  storeTrack;


    private void  fromJSONVideoID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field VideoID of MusicVideoJSON is not a string.");
        setVideoID(json_string.getData());
      }


    private void  fromJSONAutoPlayPreview(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field AutoPlayPreview of MusicVideoJSON is not true for false.");
              }
          }
        setAutoPlayPreview(the_bool);
      }


    private void  fromJSONTrack(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicTrackJSON convert_classy = MusicTrackJSON.from_json(json_value, ignore_extras, true);
        setTrack(convert_classy);
      }


    public MusicVideoJSON()
      {
        flagHasVideoID = false;
        flagHasAutoPlayPreview = false;
        flagHasTrack = false;
      }

    public bool  hasVideoID()
      {
        return flagHasVideoID;
      }

    public string  getVideoID()
      {
        Debug.Assert(flagHasVideoID);
        return storeVideoID;
      }

    public bool  hasAutoPlayPreview()
      {
        return flagHasAutoPlayPreview;
      }

    public bool  getAutoPlayPreview()
      {
        Debug.Assert(flagHasAutoPlayPreview);
        return storeAutoPlayPreview;
      }

    public bool  hasTrack()
      {
        return flagHasTrack;
      }

    public MusicTrackJSON   getTrack()
      {
        Debug.Assert(flagHasTrack);
        return storeTrack;
      }



    public void setVideoID(string new_value)
      {
        flagHasVideoID = true;
        storeVideoID = new_value;
      }
    public void unsetVideoID()
      {
        flagHasVideoID = false;
      }
    public void setAutoPlayPreview(bool new_value)
      {
        flagHasAutoPlayPreview = true;
        storeAutoPlayPreview = new_value;
      }
    public void unsetAutoPlayPreview()
      {
        flagHasAutoPlayPreview = false;
      }
    public void setTrack(MusicTrackJSON  new_value)
      {
        if (flagHasTrack)
          {
          }
        flagHasTrack = true;
        storeTrack = new_value;
      }
    public void unsetTrack()
      {
        if (flagHasTrack)
          {
          }
        flagHasTrack = false;
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
        if (flagHasVideoID)
          {
            handler.start_pair("VideoID");
            handler.string_value(storeVideoID);
          }
        if (flagHasAutoPlayPreview)
          {
            handler.start_pair("AutoPlayPreview");
            handler.boolean_value(storeAutoPlayPreview);
          }
        if (flagHasTrack)
          {
            handler.start_pair("Track");
            if (partial_allowed)
                storeTrack.write_partial_as_json(handler);
            else
                storeTrack.write_as_json(handler);
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
        return null;
      }

    public static MusicVideoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicVideoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicVideo", ignore_extras);
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
    public static MusicVideoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicVideoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicVideoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicVideo", ignore_extras);
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
    public static MusicVideoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicVideoJSON from_text(string text, bool ignore_extras)
      {
        MusicVideoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicVideo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicVideoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicVideoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicVideoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicVideo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorVideoID;
        private JSONHoldingBooleanGenerator fieldGeneratorAutoPlayPreview;
        private MusicTrackJSON.HoldingGenerator fieldGeneratorTrack;

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
            MusicVideoJSON result = new MusicVideoJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicVideoJSON result)
          {
            if (fieldGeneratorVideoID.have_value)
              {
                result.setVideoID(fieldGeneratorVideoID.value);
                fieldGeneratorVideoID.have_value = false;
              }
            if (fieldGeneratorAutoPlayPreview.have_value)
              {
                result.setAutoPlayPreview(fieldGeneratorAutoPlayPreview.value);
                fieldGeneratorAutoPlayPreview.have_value = false;
              }
            if (fieldGeneratorTrack.have_value)
              {
                result.setTrack(fieldGeneratorTrack.value);
                fieldGeneratorTrack.have_value = false;
              }
          }
        protected abstract void handle_result(MusicVideoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "utoPlayPreview", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorAutoPlayPreview;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "rack", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTrack;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ideoID", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorVideoID;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorVideoID = new JSONHoldingStringGenerator("field \"VideoID\" of the MusicVideo class");
            fieldGeneratorAutoPlayPreview = new JSONHoldingBooleanGenerator("field \"AutoPlayPreview\" of the MusicVideo class");
            fieldGeneratorTrack = new MusicTrackJSON.HoldingGenerator("field \"Track\" of the MusicVideo class", ignore_extras);
            set_what("the MusicVideo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorVideoID = new JSONHoldingStringGenerator("field \"VideoID\" of the MusicVideo class");
            fieldGeneratorAutoPlayPreview = new JSONHoldingBooleanGenerator("field \"AutoPlayPreview\" of the MusicVideo class");
            fieldGeneratorTrack = new MusicTrackJSON.HoldingGenerator("field \"Track\" of the MusicVideo class", false);
            set_what("the MusicVideo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorVideoID.reset();
            fieldGeneratorAutoPlayPreview.reset();
            fieldGeneratorTrack.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTrack.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTrack.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicVideoJSON  result)
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
        public MusicVideoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicVideoJSON  result)
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
    protected virtual void handle_result(List<MusicVideoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicVideoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicVideoJSON>();
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
    public List<MusicVideoJSON> value;
  };
  };
