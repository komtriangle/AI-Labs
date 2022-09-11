/* file "HueAccountDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HueAccountDataJSON : JSONBase
  {
    private bool flagHasBridgeUserName;
    private string storeBridgeUserName;
    private bool flagHasOAuth2ClientData;
    private OAuth2ClientDataJSON  storeOAuth2ClientData;


    private void  fromJSONBridgeUserName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BridgeUserName of HueAccountDataJSON is not a string.");
        setBridgeUserName(json_string.getData());
      }


    private void  fromJSONOAuth2ClientData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OAuth2ClientDataJSON convert_classy = OAuth2ClientDataJSON.from_json(json_value, ignore_extras, true);
        setOAuth2ClientData(convert_classy);
      }


    public HueAccountDataJSON()
      {
        flagHasBridgeUserName = false;
        flagHasOAuth2ClientData = false;
      }

    public bool  hasBridgeUserName()
      {
        return flagHasBridgeUserName;
      }

    public string  getBridgeUserName()
      {
        Debug.Assert(flagHasBridgeUserName);
        return storeBridgeUserName;
      }

    public bool  hasOAuth2ClientData()
      {
        return flagHasOAuth2ClientData;
      }

    public OAuth2ClientDataJSON   getOAuth2ClientData()
      {
        Debug.Assert(flagHasOAuth2ClientData);
        return storeOAuth2ClientData;
      }



    public void setBridgeUserName(string new_value)
      {
        flagHasBridgeUserName = true;
        storeBridgeUserName = new_value;
      }
    public void unsetBridgeUserName()
      {
        flagHasBridgeUserName = false;
      }
    public void setOAuth2ClientData(OAuth2ClientDataJSON  new_value)
      {
        if (flagHasOAuth2ClientData)
          {
          }
        flagHasOAuth2ClientData = true;
        storeOAuth2ClientData = new_value;
      }
    public void unsetOAuth2ClientData()
      {
        if (flagHasOAuth2ClientData)
          {
          }
        flagHasOAuth2ClientData = false;
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
        Debug.Assert(partial_allowed || flagHasBridgeUserName);
        if (flagHasBridgeUserName)
          {
            handler.start_pair("BridgeUserName");
            handler.string_value(storeBridgeUserName);
          }
        Debug.Assert(partial_allowed || flagHasOAuth2ClientData);
        if (flagHasOAuth2ClientData)
          {
            handler.start_pair("OAuth2ClientData");
            if (partial_allowed)
                storeOAuth2ClientData.write_partial_as_json(handler);
            else
                storeOAuth2ClientData.write_as_json(handler);
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
        if (!(hasBridgeUserName()))
          {
            return "When parsing the object for %what%, the \"BridgeUserName\" field was missing.";
          }
        if (!(hasOAuth2ClientData()))
          {
            return "When parsing the object for %what%, the \"OAuth2ClientData\" field was missing.";
          }
        return null;
      }

    public static HueAccountDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HueAccountDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HueAccountData", ignore_extras);
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
    public static HueAccountDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HueAccountDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HueAccountDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HueAccountData", ignore_extras);
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
    public static HueAccountDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HueAccountDataJSON from_text(string text, bool ignore_extras)
      {
        HueAccountDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HueAccountData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HueAccountDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HueAccountDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HueAccountDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HueAccountData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorBridgeUserName;
        private OAuth2ClientDataJSON.HoldingGenerator fieldGeneratorOAuth2ClientData;

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
            HueAccountDataJSON result = new HueAccountDataJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(HueAccountDataJSON result)
          {
            if (fieldGeneratorBridgeUserName.have_value)
              {
                result.setBridgeUserName(fieldGeneratorBridgeUserName.value);
                fieldGeneratorBridgeUserName.have_value = false;
              }
            else if ((!(result.hasBridgeUserName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"BridgeUserName\" field was missing.");
              }
            if (fieldGeneratorOAuth2ClientData.have_value)
              {
                result.setOAuth2ClientData(fieldGeneratorOAuth2ClientData.value);
                fieldGeneratorOAuth2ClientData.have_value = false;
              }
            else if ((!(result.hasOAuth2ClientData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OAuth2ClientData\" field was missing.");
              }
          }
        protected abstract void handle_result(HueAccountDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "ridgeUserName", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorBridgeUserName;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "Auth2ClientData", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorOAuth2ClientData;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorBridgeUserName = new JSONHoldingStringGenerator("field \"BridgeUserName\" of the HueAccountData class");
            fieldGeneratorOAuth2ClientData = new OAuth2ClientDataJSON.HoldingGenerator("field \"OAuth2ClientData\" of the HueAccountData class", ignore_extras);
            set_what("the HueAccountData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorBridgeUserName = new JSONHoldingStringGenerator("field \"BridgeUserName\" of the HueAccountData class");
            fieldGeneratorOAuth2ClientData = new OAuth2ClientDataJSON.HoldingGenerator("field \"OAuth2ClientData\" of the HueAccountData class", false);
            set_what("the HueAccountData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorBridgeUserName.reset();
            fieldGeneratorOAuth2ClientData.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorOAuth2ClientData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorOAuth2ClientData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HueAccountDataJSON  result)
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
        public HueAccountDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HueAccountDataJSON  result)
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
    protected virtual void handle_result(List<HueAccountDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HueAccountDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HueAccountDataJSON>();
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
    public List<HueAccountDataJSON> value;
  };
  };
