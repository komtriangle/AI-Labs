/* file "MusicBuyLinkJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicBuyLinkJSON : JSONBase
  {
    private bool flagHasStore;
    private string storeStore;
    private bool flagHasURL;
    private string storeURL;


    private void  fromJSONStore(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Store of MusicBuyLinkJSON is not a string.");
        setStore(json_string.getData());
      }


    private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field URL of MusicBuyLinkJSON is not a string.");
        setURL(json_string.getData());
      }


    public MusicBuyLinkJSON()
      {
        flagHasStore = false;
        flagHasURL = false;
      }

    public bool  hasStore()
      {
        return flagHasStore;
      }

    public string  getStore()
      {
        Debug.Assert(flagHasStore);
        return storeStore;
      }

    public bool  hasURL()
      {
        return flagHasURL;
      }

    public string  getURL()
      {
        Debug.Assert(flagHasURL);
        return storeURL;
      }



    public void setStore(string new_value)
      {
        flagHasStore = true;
        storeStore = new_value;
      }
    public void unsetStore()
      {
        flagHasStore = false;
      }
    public void setURL(string new_value)
      {
        flagHasURL = true;
        storeURL = new_value;
      }
    public void unsetURL()
      {
        flagHasURL = false;
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
        Debug.Assert(partial_allowed || flagHasStore);
        if (flagHasStore)
          {
            handler.start_pair("Store");
            handler.string_value(storeStore);
          }
        Debug.Assert(partial_allowed || flagHasURL);
        if (flagHasURL)
          {
            handler.start_pair("URL");
            handler.string_value(storeURL);
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
        if (!(hasStore()))
          {
            return "When parsing the object for %what%, the \"Store\" field was missing.";
          }
        if (!(hasURL()))
          {
            return "When parsing the object for %what%, the \"URL\" field was missing.";
          }
        return null;
      }

    public static MusicBuyLinkJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicBuyLinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicBuyLink", ignore_extras);
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
    public static MusicBuyLinkJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicBuyLinkJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicBuyLinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicBuyLink", ignore_extras);
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
    public static MusicBuyLinkJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicBuyLinkJSON from_text(string text, bool ignore_extras)
      {
        MusicBuyLinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicBuyLink", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicBuyLinkJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicBuyLinkJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicBuyLinkJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicBuyLink", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorStore;
        private JSONHoldingStringGenerator fieldGeneratorURL;

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
            MusicBuyLinkJSON result = new MusicBuyLinkJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicBuyLinkJSON result)
          {
            if (fieldGeneratorStore.have_value)
              {
                result.setStore(fieldGeneratorStore.value);
                fieldGeneratorStore.have_value = false;
              }
            else if ((!(result.hasStore())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Store\" field was missing.");
              }
            if (fieldGeneratorURL.have_value)
              {
                result.setURL(fieldGeneratorURL.value);
                fieldGeneratorURL.have_value = false;
              }
            else if ((!(result.hasURL())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"URL\" field was missing.");
              }
          }
        protected abstract void handle_result(MusicBuyLinkJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if ((String.Compare(field_name, 1, "tore", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorStore;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "RL", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorURL;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStore = new JSONHoldingStringGenerator("field \"Store\" of the MusicBuyLink class");
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the MusicBuyLink class");
            set_what("the MusicBuyLink class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStore = new JSONHoldingStringGenerator("field \"Store\" of the MusicBuyLink class");
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the MusicBuyLink class");
            set_what("the MusicBuyLink class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStore.reset();
            fieldGeneratorURL.reset();
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
        protected override void handle_result(MusicBuyLinkJSON  result)
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
        public MusicBuyLinkJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicBuyLinkJSON  result)
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
    protected virtual void handle_result(List<MusicBuyLinkJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicBuyLinkJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicBuyLinkJSON>();
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
    public List<MusicBuyLinkJSON> value;
  };
  };
