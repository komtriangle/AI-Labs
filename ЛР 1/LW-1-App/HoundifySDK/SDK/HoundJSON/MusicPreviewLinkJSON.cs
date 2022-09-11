/* file "MusicPreviewLinkJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicPreviewLinkJSON : JSONBase
  {
    private bool flagHasSource;
    private string storeSource;
    private bool flagHasUrl;
    private string storeUrl;


    private void  fromJSONSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Source of MusicPreviewLinkJSON is not a string.");
        setSource(json_string.getData());
      }


    private void  fromJSONUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Url of MusicPreviewLinkJSON is not a string.");
        setUrl(json_string.getData());
      }


    public MusicPreviewLinkJSON()
      {
        flagHasSource = false;
        flagHasUrl = false;
      }

    public bool  hasSource()
      {
        return flagHasSource;
      }

    public string  getSource()
      {
        Debug.Assert(flagHasSource);
        return storeSource;
      }

    public bool  hasUrl()
      {
        return flagHasUrl;
      }

    public string  getUrl()
      {
        Debug.Assert(flagHasUrl);
        return storeUrl;
      }



    public void setSource(string new_value)
      {
        flagHasSource = true;
        storeSource = new_value;
      }
    public void unsetSource()
      {
        flagHasSource = false;
      }
    public void setUrl(string new_value)
      {
        flagHasUrl = true;
        storeUrl = new_value;
      }
    public void unsetUrl()
      {
        flagHasUrl = false;
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
        Debug.Assert(partial_allowed || flagHasSource);
        if (flagHasSource)
          {
            handler.start_pair("Source");
            handler.string_value(storeSource);
          }
        Debug.Assert(partial_allowed || flagHasUrl);
        if (flagHasUrl)
          {
            handler.start_pair("Url");
            handler.string_value(storeUrl);
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
        if (!(hasSource()))
          {
            return "When parsing the object for %what%, the \"Source\" field was missing.";
          }
        if (!(hasUrl()))
          {
            return "When parsing the object for %what%, the \"Url\" field was missing.";
          }
        return null;
      }

    public static MusicPreviewLinkJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicPreviewLinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicPreviewLink", ignore_extras);
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
    public static MusicPreviewLinkJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicPreviewLinkJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicPreviewLinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicPreviewLink", ignore_extras);
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
    public static MusicPreviewLinkJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicPreviewLinkJSON from_text(string text, bool ignore_extras)
      {
        MusicPreviewLinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicPreviewLink", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicPreviewLinkJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicPreviewLinkJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicPreviewLinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicPreviewLink", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSource;
        private JSONHoldingStringGenerator fieldGeneratorUrl;

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
            MusicPreviewLinkJSON result = new MusicPreviewLinkJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicPreviewLinkJSON result)
          {
            if (fieldGeneratorSource.have_value)
              {
                result.setSource(fieldGeneratorSource.value);
                fieldGeneratorSource.have_value = false;
              }
            else if ((!(result.hasSource())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Source\" field was missing.");
              }
            if (fieldGeneratorUrl.have_value)
              {
                result.setUrl(fieldGeneratorUrl.value);
                fieldGeneratorUrl.have_value = false;
              }
            else if ((!(result.hasUrl())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Url\" field was missing.");
              }
          }
        protected abstract void handle_result(MusicPreviewLinkJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if ((String.Compare(field_name, 1, "ource", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSource;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "rl", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorUrl;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSource = new JSONHoldingStringGenerator("field \"Source\" of the MusicPreviewLink class");
            fieldGeneratorUrl = new JSONHoldingStringGenerator("field \"Url\" of the MusicPreviewLink class");
            set_what("the MusicPreviewLink class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSource = new JSONHoldingStringGenerator("field \"Source\" of the MusicPreviewLink class");
            fieldGeneratorUrl = new JSONHoldingStringGenerator("field \"Url\" of the MusicPreviewLink class");
            set_what("the MusicPreviewLink class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSource.reset();
            fieldGeneratorUrl.reset();
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
        protected override void handle_result(MusicPreviewLinkJSON  result)
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
        public MusicPreviewLinkJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicPreviewLinkJSON  result)
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
    protected virtual void handle_result(List<MusicPreviewLinkJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicPreviewLinkJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicPreviewLinkJSON>();
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
    public List<MusicPreviewLinkJSON> value;
  };
  };
