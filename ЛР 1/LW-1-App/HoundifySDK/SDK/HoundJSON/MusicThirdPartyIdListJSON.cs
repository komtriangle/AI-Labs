/* file "MusicThirdPartyIdListJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicThirdPartyIdListJSON : JSONBase
  {
    private bool flagHasMusicThirdParty;
    private MusicThirdPartyJSON  storeMusicThirdParty;
    private bool flagHasIds;
    private List< string > storeIds;
    private bool flagHasDeepLinks;
    private List< string > storeDeepLinks;


    private void  fromJSONMusicThirdParty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicThirdPartyJSON convert_classy = MusicThirdPartyJSON.from_json(json_value, ignore_extras, true);
        setMusicThirdParty(convert_classy);
      }


    private void  fromJSONIds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Ids of MusicThirdPartyIdListJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Ids1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Ids of MusicThirdPartyIdListJSON is not a string.");
            vector_Ids1.Add(json_string.getData());
          }
        initIds();
        for (int num1 = 0; num1 < vector_Ids1.Count; ++num1)
            appendIds(vector_Ids1[num1]);
        for (int num1 = 0; num1 < vector_Ids1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDeepLinks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DeepLinks of MusicThirdPartyIdListJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_DeepLinks1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field DeepLinks of MusicThirdPartyIdListJSON is not a string.");
            vector_DeepLinks1.Add(json_string.getData());
          }
        initDeepLinks();
        for (int num2 = 0; num2 < vector_DeepLinks1.Count; ++num2)
            appendDeepLinks(vector_DeepLinks1[num2]);
        for (int num1 = 0; num1 < vector_DeepLinks1.Count; ++num1)
          {
          }
      }


    public MusicThirdPartyIdListJSON()
      {
        flagHasMusicThirdParty = false;
        flagHasIds = false;
        flagHasDeepLinks = false;
        storeIds = new List< string >();
        storeDeepLinks = new List< string >();
      }

    public bool  hasMusicThirdParty()
      {
        return flagHasMusicThirdParty;
      }

    public MusicThirdPartyJSON   getMusicThirdParty()
      {
        Debug.Assert(flagHasMusicThirdParty);
        return storeMusicThirdParty;
      }

    public bool  hasIds()
      {
        return flagHasIds;
      }

    public int  countOfIds()
      {
        Debug.Assert(flagHasIds);
        return storeIds.Count;
      }

    public string  elementOfIds(int element_num)
      {
        Debug.Assert(flagHasIds);
        return storeIds[element_num];
      }

    public List< string >  getIds()
      {
        Debug.Assert(flagHasIds);
        return storeIds;
      }

    public bool  hasDeepLinks()
      {
        return flagHasDeepLinks;
      }

    public int  countOfDeepLinks()
      {
        Debug.Assert(flagHasDeepLinks);
        return storeDeepLinks.Count;
      }

    public string  elementOfDeepLinks(int element_num)
      {
        Debug.Assert(flagHasDeepLinks);
        return storeDeepLinks[element_num];
      }

    public List< string >  getDeepLinks()
      {
        Debug.Assert(flagHasDeepLinks);
        return storeDeepLinks;
      }



    public void setMusicThirdParty(MusicThirdPartyJSON  new_value)
      {
        if (flagHasMusicThirdParty)
          {
          }
        flagHasMusicThirdParty = true;
        storeMusicThirdParty = new_value;
      }
    public void unsetMusicThirdParty()
      {
        if (flagHasMusicThirdParty)
          {
          }
        flagHasMusicThirdParty = false;
      }
    public void initIds()
      {
        flagHasIds = true;
        storeIds.Clear();
      }
    public void appendIds(string to_append)
      {
        if (!flagHasIds)
          {
            flagHasIds = true;
            storeIds.Clear();
          }
        Debug.Assert(flagHasIds);
        storeIds.Add(to_append);
      }
    public void unsetIds()
      {
        flagHasIds = false;
        storeIds.Clear();
      }
    public void initDeepLinks()
      {
        flagHasDeepLinks = true;
        storeDeepLinks.Clear();
      }
    public void appendDeepLinks(string to_append)
      {
        if (!flagHasDeepLinks)
          {
            flagHasDeepLinks = true;
            storeDeepLinks.Clear();
          }
        Debug.Assert(flagHasDeepLinks);
        storeDeepLinks.Add(to_append);
      }
    public void unsetDeepLinks()
      {
        flagHasDeepLinks = false;
        storeDeepLinks.Clear();
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
        Debug.Assert(partial_allowed || flagHasMusicThirdParty);
        if (flagHasMusicThirdParty)
          {
            handler.start_pair("MusicThirdParty");
            if (partial_allowed)
                storeMusicThirdParty.write_partial_as_json(handler);
            else
                storeMusicThirdParty.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasIds);
        if (flagHasIds)
          {
            handler.start_pair("Ids");
            handler.start_array();
            for (int num1 = 0; num1 < storeIds.Count; ++num1)
              {
                handler.string_value(storeIds[num1]);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasDeepLinks);
        if (flagHasDeepLinks)
          {
            handler.start_pair("DeepLinks");
            handler.start_array();
            for (int num2 = 0; num2 < storeDeepLinks.Count; ++num2)
              {
                handler.string_value(storeDeepLinks[num2]);
              }
            handler.finish_array();
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
        if (!(hasMusicThirdParty()))
          {
            return "When parsing the object for %what%, the \"MusicThirdParty\" field was missing.";
          }
        if (!(hasIds()))
          {
            return "When parsing the object for %what%, the \"Ids\" field was missing.";
          }
        if (!(hasDeepLinks()))
          {
            return "When parsing the object for %what%, the \"DeepLinks\" field was missing.";
          }
        return null;
      }

    public static MusicThirdPartyIdListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicThirdPartyIdListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicThirdPartyIdList", ignore_extras);
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
    public static MusicThirdPartyIdListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicThirdPartyIdListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicThirdPartyIdListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicThirdPartyIdList", ignore_extras);
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
    public static MusicThirdPartyIdListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicThirdPartyIdListJSON from_text(string text, bool ignore_extras)
      {
        MusicThirdPartyIdListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicThirdPartyIdList", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicThirdPartyIdListJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicThirdPartyIdListJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicThirdPartyIdListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicThirdPartyIdList", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MusicThirdPartyJSON.HoldingGenerator fieldGeneratorMusicThirdParty;
        private JSONHoldingStringArrayGenerator fieldGeneratorIds;
        private JSONHoldingStringArrayGenerator fieldGeneratorDeepLinks;

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
            MusicThirdPartyIdListJSON result = new MusicThirdPartyIdListJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicThirdPartyIdListJSON result)
          {
            if (fieldGeneratorMusicThirdParty.have_value)
              {
                result.setMusicThirdParty(fieldGeneratorMusicThirdParty.value);
                fieldGeneratorMusicThirdParty.have_value = false;
              }
            else if ((!(result.hasMusicThirdParty())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MusicThirdParty\" field was missing.");
              }
            if (fieldGeneratorIds.have_value)
              {
                result.initIds();
                int count = fieldGeneratorIds.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendIds(fieldGeneratorIds.value[num]);
                  }
                fieldGeneratorIds.value.Clear();
                fieldGeneratorIds.have_value = false;
              }
            else if ((!(result.hasIds())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Ids\" field was missing.");
              }
            if (fieldGeneratorDeepLinks.have_value)
              {
                result.initDeepLinks();
                int count = fieldGeneratorDeepLinks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDeepLinks(fieldGeneratorDeepLinks.value[num]);
                  }
                fieldGeneratorDeepLinks.value.Clear();
                fieldGeneratorDeepLinks.have_value = false;
              }
            else if ((!(result.hasDeepLinks())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DeepLinks\" field was missing.");
              }
          }
        protected abstract void handle_result(MusicThirdPartyIdListJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "eepLinks", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDeepLinks;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "ds", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorIds;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "usicThirdParty", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorMusicThirdParty;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMusicThirdParty = new MusicThirdPartyJSON.HoldingGenerator("field \"MusicThirdParty\" of the MusicThirdPartyIdList class", ignore_extras);
            fieldGeneratorIds = new JSONHoldingStringArrayGenerator("field \"Ids\" of the MusicThirdPartyIdList class");
            fieldGeneratorDeepLinks = new JSONHoldingStringArrayGenerator("field \"DeepLinks\" of the MusicThirdPartyIdList class");
            set_what("the MusicThirdPartyIdList class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMusicThirdParty = new MusicThirdPartyJSON.HoldingGenerator("field \"MusicThirdParty\" of the MusicThirdPartyIdList class", false);
            fieldGeneratorIds = new JSONHoldingStringArrayGenerator("field \"Ids\" of the MusicThirdPartyIdList class");
            fieldGeneratorDeepLinks = new JSONHoldingStringArrayGenerator("field \"DeepLinks\" of the MusicThirdPartyIdList class");
            set_what("the MusicThirdPartyIdList class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMusicThirdParty.reset();
            fieldGeneratorIds.reset();
            fieldGeneratorDeepLinks.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMusicThirdParty.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMusicThirdParty.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicThirdPartyIdListJSON  result)
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
        public MusicThirdPartyIdListJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicThirdPartyIdListJSON  result)
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
    protected virtual void handle_result(List<MusicThirdPartyIdListJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicThirdPartyIdListJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicThirdPartyIdListJSON>();
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
    public List<MusicThirdPartyIdListJSON> value;
  };
  };
