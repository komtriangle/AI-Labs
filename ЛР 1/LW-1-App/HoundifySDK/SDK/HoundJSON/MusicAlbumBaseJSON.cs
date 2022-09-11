/* file "MusicAlbumBaseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicAlbumBaseJSON : JSONBase
  {
    private bool flagHasAlbumID;
    private SoundHoundAlbumIDJSON  storeAlbumID;
    private bool flagHasAlbumName;
    private string storeAlbumName;
    private bool flagHasAlbumImageURL;
    private string storeAlbumImageURL;
    private bool flagHasAlbumDate;
    private string storeAlbumDate;
    private bool flagHasAlbumReview;
    private string storeAlbumReview;
    private bool flagHasArtistName;
    private string storeArtistName;
    private bool flagHasArtistID;
    private SoundHoundArtistIDJSON  storeArtistID;
    private bool flagHasArtistImageURL;
    private string storeArtistImageURL;
    private bool flagHasBuyLinks;
    private List< MusicBuyLinkJSON  > storeBuyLinks;
    private bool flagHasMusicThirdPartyIds;
    private List< MusicThirdPartyIdListJSON  > storeMusicThirdPartyIds;


    private void  fromJSONAlbumID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SoundHoundAlbumIDJSON convert_classy = SoundHoundAlbumIDJSON.from_json(json_value, ignore_extras, true);
        setAlbumID(convert_classy);
      }


    private void  fromJSONAlbumName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AlbumName of MusicAlbumBaseJSON is not a string.");
        setAlbumName(json_string.getData());
      }


    private void  fromJSONAlbumImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AlbumImageURL of MusicAlbumBaseJSON is not a string.");
        setAlbumImageURL(json_string.getData());
      }


    private void  fromJSONAlbumDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AlbumDate of MusicAlbumBaseJSON is not a string.");
        setAlbumDate(json_string.getData());
      }


    private void  fromJSONAlbumReview(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AlbumReview of MusicAlbumBaseJSON is not a string.");
        setAlbumReview(json_string.getData());
      }


    private void  fromJSONArtistName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArtistName of MusicAlbumBaseJSON is not a string.");
        setArtistName(json_string.getData());
      }


    private void  fromJSONArtistID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SoundHoundArtistIDJSON convert_classy = SoundHoundArtistIDJSON.from_json(json_value, ignore_extras, true);
        setArtistID(convert_classy);
      }


    private void  fromJSONArtistImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArtistImageURL of MusicAlbumBaseJSON is not a string.");
        setArtistImageURL(json_string.getData());
      }


    private void  fromJSONBuyLinks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field BuyLinks of MusicAlbumBaseJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field BuyLinks of MusicAlbumBaseJSON has too few elements.");
        List< MusicBuyLinkJSON  > vector_BuyLinks1 = new List< MusicBuyLinkJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicBuyLinkJSON convert_classy = MusicBuyLinkJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_BuyLinks1.Add(convert_classy);
          }
        Debug.Assert(vector_BuyLinks1.Count >= 1);
        initBuyLinks();
        for (int num1 = 0; num1 < vector_BuyLinks1.Count; ++num1)
            appendBuyLinks(vector_BuyLinks1[num1]);
        for (int num1 = 0; num1 < vector_BuyLinks1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMusicThirdPartyIds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MusicThirdPartyIds of MusicAlbumBaseJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field MusicThirdPartyIds of MusicAlbumBaseJSON has too few elements.");
        List< MusicThirdPartyIdListJSON  > vector_MusicThirdPartyIds1 = new List< MusicThirdPartyIdListJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicThirdPartyIdListJSON convert_classy = MusicThirdPartyIdListJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_MusicThirdPartyIds1.Add(convert_classy);
          }
        Debug.Assert(vector_MusicThirdPartyIds1.Count >= 1);
        initMusicThirdPartyIds();
        for (int num2 = 0; num2 < vector_MusicThirdPartyIds1.Count; ++num2)
            appendMusicThirdPartyIds(vector_MusicThirdPartyIds1[num2]);
        for (int num1 = 0; num1 < vector_MusicThirdPartyIds1.Count; ++num1)
          {
          }
      }


    public MusicAlbumBaseJSON()
      {
        flagHasAlbumID = false;
        flagHasAlbumName = false;
        flagHasAlbumImageURL = false;
        flagHasAlbumDate = false;
        flagHasAlbumReview = false;
        flagHasArtistName = false;
        flagHasArtistID = false;
        flagHasArtistImageURL = false;
        flagHasBuyLinks = false;
        flagHasMusicThirdPartyIds = false;
        storeBuyLinks = new List< MusicBuyLinkJSON  >();
        storeMusicThirdPartyIds = new List< MusicThirdPartyIdListJSON  >();
      }

    public bool  hasAlbumID()
      {
        return flagHasAlbumID;
      }

    public SoundHoundAlbumIDJSON   getAlbumID()
      {
        Debug.Assert(flagHasAlbumID);
        return storeAlbumID;
      }

    public long  getAlbumIDValue()
      {
        return getAlbumID().getValue();
      }

    public bool  hasAlbumName()
      {
        return flagHasAlbumName;
      }

    public string  getAlbumName()
      {
        Debug.Assert(flagHasAlbumName);
        return storeAlbumName;
      }

    public bool  hasAlbumImageURL()
      {
        return flagHasAlbumImageURL;
      }

    public string  getAlbumImageURL()
      {
        Debug.Assert(flagHasAlbumImageURL);
        return storeAlbumImageURL;
      }

    public bool  hasAlbumDate()
      {
        return flagHasAlbumDate;
      }

    public string  getAlbumDate()
      {
        Debug.Assert(flagHasAlbumDate);
        return storeAlbumDate;
      }

    public bool  hasAlbumReview()
      {
        return flagHasAlbumReview;
      }

    public string  getAlbumReview()
      {
        Debug.Assert(flagHasAlbumReview);
        return storeAlbumReview;
      }

    public bool  hasArtistName()
      {
        return flagHasArtistName;
      }

    public string  getArtistName()
      {
        Debug.Assert(flagHasArtistName);
        return storeArtistName;
      }

    public bool  hasArtistID()
      {
        return flagHasArtistID;
      }

    public SoundHoundArtistIDJSON   getArtistID()
      {
        Debug.Assert(flagHasArtistID);
        return storeArtistID;
      }

    public long  getArtistIDValue()
      {
        return getArtistID().getValue();
      }

    public bool  hasArtistImageURL()
      {
        return flagHasArtistImageURL;
      }

    public string  getArtistImageURL()
      {
        Debug.Assert(flagHasArtistImageURL);
        return storeArtistImageURL;
      }

    public bool  hasBuyLinks()
      {
        return flagHasBuyLinks;
      }

    public int  countOfBuyLinks()
      {
        Debug.Assert(flagHasBuyLinks);
        return storeBuyLinks.Count;
      }

    public MusicBuyLinkJSON   elementOfBuyLinks(int element_num)
      {
        Debug.Assert(flagHasBuyLinks);
        return storeBuyLinks[element_num];
      }

    public List< MusicBuyLinkJSON  >  getBuyLinks()
      {
        Debug.Assert(flagHasBuyLinks);
        return storeBuyLinks;
      }

    public bool  hasMusicThirdPartyIds()
      {
        return flagHasMusicThirdPartyIds;
      }

    public int  countOfMusicThirdPartyIds()
      {
        Debug.Assert(flagHasMusicThirdPartyIds);
        return storeMusicThirdPartyIds.Count;
      }

    public MusicThirdPartyIdListJSON   elementOfMusicThirdPartyIds(int element_num)
      {
        Debug.Assert(flagHasMusicThirdPartyIds);
        return storeMusicThirdPartyIds[element_num];
      }

    public List< MusicThirdPartyIdListJSON  >  getMusicThirdPartyIds()
      {
        Debug.Assert(flagHasMusicThirdPartyIds);
        return storeMusicThirdPartyIds;
      }



    public void setAlbumID(SoundHoundAlbumIDJSON  new_value)
      {
        if (flagHasAlbumID)
          {
          }
        flagHasAlbumID = true;
        storeAlbumID = new_value;
      }
    public void setAlbumID(long new_value)
      {
        setAlbumID(new SoundHoundAlbumIDJSON(new_value));
      }
    public void unsetAlbumID()
      {
        if (flagHasAlbumID)
          {
          }
        flagHasAlbumID = false;
      }
    public void setAlbumName(string new_value)
      {
        flagHasAlbumName = true;
        storeAlbumName = new_value;
      }
    public void unsetAlbumName()
      {
        flagHasAlbumName = false;
      }
    public void setAlbumImageURL(string new_value)
      {
        flagHasAlbumImageURL = true;
        storeAlbumImageURL = new_value;
      }
    public void unsetAlbumImageURL()
      {
        flagHasAlbumImageURL = false;
      }
    public void setAlbumDate(string new_value)
      {
        flagHasAlbumDate = true;
        storeAlbumDate = new_value;
      }
    public void unsetAlbumDate()
      {
        flagHasAlbumDate = false;
      }
    public void setAlbumReview(string new_value)
      {
        flagHasAlbumReview = true;
        storeAlbumReview = new_value;
      }
    public void unsetAlbumReview()
      {
        flagHasAlbumReview = false;
      }
    public void setArtistName(string new_value)
      {
        flagHasArtistName = true;
        storeArtistName = new_value;
      }
    public void unsetArtistName()
      {
        flagHasArtistName = false;
      }
    public void setArtistID(SoundHoundArtistIDJSON  new_value)
      {
        if (flagHasArtistID)
          {
          }
        flagHasArtistID = true;
        storeArtistID = new_value;
      }
    public void setArtistID(long new_value)
      {
        setArtistID(new SoundHoundArtistIDJSON(new_value));
      }
    public void unsetArtistID()
      {
        if (flagHasArtistID)
          {
          }
        flagHasArtistID = false;
      }
    public void setArtistImageURL(string new_value)
      {
        flagHasArtistImageURL = true;
        storeArtistImageURL = new_value;
      }
    public void unsetArtistImageURL()
      {
        flagHasArtistImageURL = false;
      }
    public void initBuyLinks()
      {
        if (flagHasBuyLinks)
          {
            for (int num1 = 0; num1 < storeBuyLinks.Count; ++num1)
              {
              }
          }
        flagHasBuyLinks = true;
        storeBuyLinks.Clear();
      }
    public void appendBuyLinks(MusicBuyLinkJSON  to_append)
      {
        if (!flagHasBuyLinks)
          {
            flagHasBuyLinks = true;
            storeBuyLinks.Clear();
          }
        Debug.Assert(flagHasBuyLinks);
        storeBuyLinks.Add(to_append);
      }
    public void unsetBuyLinks()
      {
        if (flagHasBuyLinks)
          {
            for (int num2 = 0; num2 < storeBuyLinks.Count; ++num2)
              {
              }
          }
        flagHasBuyLinks = false;
        storeBuyLinks.Clear();
      }
    public void initMusicThirdPartyIds()
      {
        if (flagHasMusicThirdPartyIds)
          {
            for (int num3 = 0; num3 < storeMusicThirdPartyIds.Count; ++num3)
              {
              }
          }
        flagHasMusicThirdPartyIds = true;
        storeMusicThirdPartyIds.Clear();
      }
    public void appendMusicThirdPartyIds(MusicThirdPartyIdListJSON  to_append)
      {
        if (!flagHasMusicThirdPartyIds)
          {
            flagHasMusicThirdPartyIds = true;
            storeMusicThirdPartyIds.Clear();
          }
        Debug.Assert(flagHasMusicThirdPartyIds);
        storeMusicThirdPartyIds.Add(to_append);
      }
    public void unsetMusicThirdPartyIds()
      {
        if (flagHasMusicThirdPartyIds)
          {
            for (int num4 = 0; num4 < storeMusicThirdPartyIds.Count; ++num4)
              {
              }
          }
        flagHasMusicThirdPartyIds = false;
        storeMusicThirdPartyIds.Clear();
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
        if (flagHasAlbumID)
          {
            handler.start_pair("AlbumID");
            if (partial_allowed)
                storeAlbumID.write_partial_as_json(handler);
            else
                storeAlbumID.write_as_json(handler);
          }
        if (flagHasAlbumName)
          {
            handler.start_pair("AlbumName");
            handler.string_value(storeAlbumName);
          }
        if (flagHasAlbumImageURL)
          {
            handler.start_pair("AlbumImageURL");
            handler.string_value(storeAlbumImageURL);
          }
        if (flagHasAlbumDate)
          {
            handler.start_pair("AlbumDate");
            handler.string_value(storeAlbumDate);
          }
        if (flagHasAlbumReview)
          {
            handler.start_pair("AlbumReview");
            handler.string_value(storeAlbumReview);
          }
        if (flagHasArtistName)
          {
            handler.start_pair("ArtistName");
            handler.string_value(storeArtistName);
          }
        if (flagHasArtistID)
          {
            handler.start_pair("ArtistID");
            if (partial_allowed)
                storeArtistID.write_partial_as_json(handler);
            else
                storeArtistID.write_as_json(handler);
          }
        if (flagHasArtistImageURL)
          {
            handler.start_pair("ArtistImageURL");
            handler.string_value(storeArtistImageURL);
          }
        if (flagHasBuyLinks)
          {
            handler.start_pair("BuyLinks");
            Debug.Assert(storeBuyLinks.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeBuyLinks.Count; ++num1)
              {
                if (partial_allowed)
                    storeBuyLinks[num1].write_partial_as_json(handler);
                else
                    storeBuyLinks[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMusicThirdPartyIds)
          {
            handler.start_pair("MusicThirdPartyIds");
            Debug.Assert(storeMusicThirdPartyIds.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeMusicThirdPartyIds.Count; ++num2)
              {
                if (partial_allowed)
                    storeMusicThirdPartyIds[num2].write_partial_as_json(handler);
                else
                    storeMusicThirdPartyIds[num2].write_as_json(handler);
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
        return null;
      }

    public static MusicAlbumBaseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicAlbumBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicAlbumBase", ignore_extras);
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
    public static MusicAlbumBaseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicAlbumBaseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicAlbumBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicAlbumBase", ignore_extras);
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
    public static MusicAlbumBaseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicAlbumBaseJSON from_text(string text, bool ignore_extras)
      {
        MusicAlbumBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicAlbumBase", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicAlbumBaseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicAlbumBaseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicAlbumBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicAlbumBase", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SoundHoundAlbumIDJSON.HoldingGenerator fieldGeneratorAlbumID;
        private JSONHoldingStringGenerator fieldGeneratorAlbumName;
        private JSONHoldingStringGenerator fieldGeneratorAlbumImageURL;
        private JSONHoldingStringGenerator fieldGeneratorAlbumDate;
        private JSONHoldingStringGenerator fieldGeneratorAlbumReview;
        private JSONHoldingStringGenerator fieldGeneratorArtistName;
        private SoundHoundArtistIDJSON.HoldingGenerator fieldGeneratorArtistID;
        private JSONHoldingStringGenerator fieldGeneratorArtistImageURL;
        private MusicBuyLinkJSON.HoldingArrayGenerator fieldGeneratorBuyLinks;
        private MusicThirdPartyIdListJSON.HoldingArrayGenerator fieldGeneratorMusicThirdPartyIds;

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
            MusicAlbumBaseJSON result = new MusicAlbumBaseJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicAlbumBaseJSON result)
          {
            if (fieldGeneratorAlbumID.have_value)
              {
                result.setAlbumID(fieldGeneratorAlbumID.value);
                fieldGeneratorAlbumID.have_value = false;
              }
            if (fieldGeneratorAlbumName.have_value)
              {
                result.setAlbumName(fieldGeneratorAlbumName.value);
                fieldGeneratorAlbumName.have_value = false;
              }
            if (fieldGeneratorAlbumImageURL.have_value)
              {
                result.setAlbumImageURL(fieldGeneratorAlbumImageURL.value);
                fieldGeneratorAlbumImageURL.have_value = false;
              }
            if (fieldGeneratorAlbumDate.have_value)
              {
                result.setAlbumDate(fieldGeneratorAlbumDate.value);
                fieldGeneratorAlbumDate.have_value = false;
              }
            if (fieldGeneratorAlbumReview.have_value)
              {
                result.setAlbumReview(fieldGeneratorAlbumReview.value);
                fieldGeneratorAlbumReview.have_value = false;
              }
            if (fieldGeneratorArtistName.have_value)
              {
                result.setArtistName(fieldGeneratorArtistName.value);
                fieldGeneratorArtistName.have_value = false;
              }
            if (fieldGeneratorArtistID.have_value)
              {
                result.setArtistID(fieldGeneratorArtistID.value);
                fieldGeneratorArtistID.have_value = false;
              }
            if (fieldGeneratorArtistImageURL.have_value)
              {
                result.setArtistImageURL(fieldGeneratorArtistImageURL.value);
                fieldGeneratorArtistImageURL.have_value = false;
              }
            if (fieldGeneratorBuyLinks.have_value)
              {
                result.initBuyLinks();
                int count = fieldGeneratorBuyLinks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBuyLinks(fieldGeneratorBuyLinks.value[num]);
                  }
                fieldGeneratorBuyLinks.value.Clear();
                fieldGeneratorBuyLinks.have_value = false;
              }
            if (fieldGeneratorMusicThirdPartyIds.have_value)
              {
                result.initMusicThirdPartyIds();
                int count = fieldGeneratorMusicThirdPartyIds.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMusicThirdPartyIds(fieldGeneratorMusicThirdPartyIds.value[num]);
                  }
                fieldGeneratorMusicThirdPartyIds.value.Clear();
                fieldGeneratorMusicThirdPartyIds.have_value = false;
              }
          }
        protected abstract void handle_result(MusicAlbumBaseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if (String.Compare(field_name, 2, "bum", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 6, "ate", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorAlbumDate;
                                        break;
                                    case 'I':
                                        switch (field_name[6])
                                          {
                                            case 'D':
                                                if (field_name.Length == 7)
                                                    return fieldGeneratorAlbumID;
                                                break;
                                            case 'm':
                                                if ((String.Compare(field_name, 7, "ageURL", 0, 6, false) == 0) && (field_name.Length == 13))
                                                    return fieldGeneratorAlbumImageURL;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorAlbumName;
                                        break;
                                    case 'R':
                                        if ((String.Compare(field_name, 6, "eview", 0, 5, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorAlbumReview;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "tist", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'I':
                                        switch (field_name[7])
                                          {
                                            case 'D':
                                                if (field_name.Length == 8)
                                                    return fieldGeneratorArtistID;
                                                break;
                                            case 'm':
                                                if ((String.Compare(field_name, 8, "ageURL", 0, 6, false) == 0) && (field_name.Length == 14))
                                                    return fieldGeneratorArtistImageURL;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 7, "ame", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorArtistName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "uyLinks", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorBuyLinks;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "usicThirdPartyIds", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorMusicThirdPartyIds;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAlbumID = new SoundHoundAlbumIDJSON.HoldingGenerator("field \"AlbumID\" of the MusicAlbumBase class", ignore_extras);
            fieldGeneratorAlbumName = new JSONHoldingStringGenerator("field \"AlbumName\" of the MusicAlbumBase class");
            fieldGeneratorAlbumImageURL = new JSONHoldingStringGenerator("field \"AlbumImageURL\" of the MusicAlbumBase class");
            fieldGeneratorAlbumDate = new JSONHoldingStringGenerator("field \"AlbumDate\" of the MusicAlbumBase class");
            fieldGeneratorAlbumReview = new JSONHoldingStringGenerator("field \"AlbumReview\" of the MusicAlbumBase class");
            fieldGeneratorArtistName = new JSONHoldingStringGenerator("field \"ArtistName\" of the MusicAlbumBase class");
            fieldGeneratorArtistID = new SoundHoundArtistIDJSON.HoldingGenerator("field \"ArtistID\" of the MusicAlbumBase class", ignore_extras);
            fieldGeneratorArtistImageURL = new JSONHoldingStringGenerator("field \"ArtistImageURL\" of the MusicAlbumBase class");
            fieldGeneratorBuyLinks = new MusicBuyLinkJSON.HoldingArrayGenerator("field \"BuyLinks\" of the MusicAlbumBase class", ignore_extras);
            fieldGeneratorMusicThirdPartyIds = new MusicThirdPartyIdListJSON.HoldingArrayGenerator("field \"MusicThirdPartyIds\" of the MusicAlbumBase class", ignore_extras);
            set_what("the MusicAlbumBase class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAlbumID = new SoundHoundAlbumIDJSON.HoldingGenerator("field \"AlbumID\" of the MusicAlbumBase class", false);
            fieldGeneratorAlbumName = new JSONHoldingStringGenerator("field \"AlbumName\" of the MusicAlbumBase class");
            fieldGeneratorAlbumImageURL = new JSONHoldingStringGenerator("field \"AlbumImageURL\" of the MusicAlbumBase class");
            fieldGeneratorAlbumDate = new JSONHoldingStringGenerator("field \"AlbumDate\" of the MusicAlbumBase class");
            fieldGeneratorAlbumReview = new JSONHoldingStringGenerator("field \"AlbumReview\" of the MusicAlbumBase class");
            fieldGeneratorArtistName = new JSONHoldingStringGenerator("field \"ArtistName\" of the MusicAlbumBase class");
            fieldGeneratorArtistID = new SoundHoundArtistIDJSON.HoldingGenerator("field \"ArtistID\" of the MusicAlbumBase class", false);
            fieldGeneratorArtistImageURL = new JSONHoldingStringGenerator("field \"ArtistImageURL\" of the MusicAlbumBase class");
            fieldGeneratorBuyLinks = new MusicBuyLinkJSON.HoldingArrayGenerator("field \"BuyLinks\" of the MusicAlbumBase class", false);
            fieldGeneratorMusicThirdPartyIds = new MusicThirdPartyIdListJSON.HoldingArrayGenerator("field \"MusicThirdPartyIds\" of the MusicAlbumBase class", false);
            set_what("the MusicAlbumBase class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAlbumID.reset();
            fieldGeneratorAlbumName.reset();
            fieldGeneratorAlbumImageURL.reset();
            fieldGeneratorAlbumDate.reset();
            fieldGeneratorAlbumReview.reset();
            fieldGeneratorArtistName.reset();
            fieldGeneratorArtistID.reset();
            fieldGeneratorArtistImageURL.reset();
            fieldGeneratorBuyLinks.reset();
            fieldGeneratorMusicThirdPartyIds.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAlbumID.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArtistID.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBuyLinks.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMusicThirdPartyIds.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAlbumID.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArtistID.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBuyLinks.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMusicThirdPartyIds.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicAlbumBaseJSON  result)
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
        public MusicAlbumBaseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicAlbumBaseJSON  result)
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
    protected virtual void handle_result(List<MusicAlbumBaseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicAlbumBaseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicAlbumBaseJSON>();
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
    public List<MusicAlbumBaseJSON> value;
  };
  };
