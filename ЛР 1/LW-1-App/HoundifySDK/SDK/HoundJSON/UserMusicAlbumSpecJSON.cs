/* file "UserMusicAlbumSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserMusicAlbumSpecJSON : JSONBase
  {
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasAlbumId;
    private string storeAlbumId;
    private bool flagHasFilePath;
    private string storeFilePath;
    private bool flagHasPrimaryArtistIds;
    private List< string > storePrimaryArtistIds;
    private bool flagHasFeaturedArtistIds;
    private List< string > storeFeaturedArtistIds;
    private bool flagHasArtistName;
    private string storeArtistName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of UserMusicAlbumSpecJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONAlbumId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AlbumId of UserMusicAlbumSpecJSON is not a string.");
        setAlbumId(json_string.getData());
      }


    private void  fromJSONFilePath(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FilePath of UserMusicAlbumSpecJSON is not a string.");
        setFilePath(json_string.getData());
      }


    private void  fromJSONPrimaryArtistIds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PrimaryArtistIds of UserMusicAlbumSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_PrimaryArtistIds1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field PrimaryArtistIds of UserMusicAlbumSpecJSON is not a string.");
            vector_PrimaryArtistIds1.Add(json_string.getData());
          }
        initPrimaryArtistIds();
        for (int num1 = 0; num1 < vector_PrimaryArtistIds1.Count; ++num1)
            appendPrimaryArtistIds(vector_PrimaryArtistIds1[num1]);
        for (int num1 = 0; num1 < vector_PrimaryArtistIds1.Count; ++num1)
          {
          }
      }


    private void  fromJSONFeaturedArtistIds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FeaturedArtistIds of UserMusicAlbumSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_FeaturedArtistIds1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field FeaturedArtistIds of UserMusicAlbumSpecJSON is not a string.");
            vector_FeaturedArtistIds1.Add(json_string.getData());
          }
        initFeaturedArtistIds();
        for (int num2 = 0; num2 < vector_FeaturedArtistIds1.Count; ++num2)
            appendFeaturedArtistIds(vector_FeaturedArtistIds1[num2]);
        for (int num1 = 0; num1 < vector_FeaturedArtistIds1.Count; ++num1)
          {
          }
      }


    private void  fromJSONArtistName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArtistName of UserMusicAlbumSpecJSON is not a string.");
        setArtistName(json_string.getData());
      }


    public UserMusicAlbumSpecJSON()
      {
        flagHasTitle = false;
        flagHasAlbumId = false;
        flagHasFilePath = false;
        flagHasPrimaryArtistIds = false;
        flagHasFeaturedArtistIds = false;
        flagHasArtistName = false;
        storePrimaryArtistIds = new List< string >();
        storeFeaturedArtistIds = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        Debug.Assert(flagHasTitle);
        return storeTitle;
      }

    public bool  hasAlbumId()
      {
        return flagHasAlbumId;
      }

    public string  getAlbumId()
      {
        Debug.Assert(flagHasAlbumId);
        return storeAlbumId;
      }

    public bool  hasFilePath()
      {
        return flagHasFilePath;
      }

    public string  getFilePath()
      {
        Debug.Assert(flagHasFilePath);
        return storeFilePath;
      }

    public bool  hasPrimaryArtistIds()
      {
        return flagHasPrimaryArtistIds;
      }

    public int  countOfPrimaryArtistIds()
      {
        Debug.Assert(flagHasPrimaryArtistIds);
        return storePrimaryArtistIds.Count;
      }

    public string  elementOfPrimaryArtistIds(int element_num)
      {
        Debug.Assert(flagHasPrimaryArtistIds);
        return storePrimaryArtistIds[element_num];
      }

    public List< string >  getPrimaryArtistIds()
      {
        Debug.Assert(flagHasPrimaryArtistIds);
        return storePrimaryArtistIds;
      }

    public bool  hasFeaturedArtistIds()
      {
        return flagHasFeaturedArtistIds;
      }

    public int  countOfFeaturedArtistIds()
      {
        Debug.Assert(flagHasFeaturedArtistIds);
        return storeFeaturedArtistIds.Count;
      }

    public string  elementOfFeaturedArtistIds(int element_num)
      {
        Debug.Assert(flagHasFeaturedArtistIds);
        return storeFeaturedArtistIds[element_num];
      }

    public List< string >  getFeaturedArtistIds()
      {
        Debug.Assert(flagHasFeaturedArtistIds);
        return storeFeaturedArtistIds;
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


    public virtual int extraUserMusicAlbumSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserMusicAlbumSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserMusicAlbumSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserMusicAlbumSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setAlbumId(string new_value)
      {
        flagHasAlbumId = true;
        storeAlbumId = new_value;
      }
    public void unsetAlbumId()
      {
        flagHasAlbumId = false;
      }
    public void setFilePath(string new_value)
      {
        flagHasFilePath = true;
        storeFilePath = new_value;
      }
    public void unsetFilePath()
      {
        flagHasFilePath = false;
      }
    public void initPrimaryArtistIds()
      {
        flagHasPrimaryArtistIds = true;
        storePrimaryArtistIds.Clear();
      }
    public void appendPrimaryArtistIds(string to_append)
      {
        if (!flagHasPrimaryArtistIds)
          {
            flagHasPrimaryArtistIds = true;
            storePrimaryArtistIds.Clear();
          }
        Debug.Assert(flagHasPrimaryArtistIds);
        storePrimaryArtistIds.Add(to_append);
      }
    public void unsetPrimaryArtistIds()
      {
        flagHasPrimaryArtistIds = false;
        storePrimaryArtistIds.Clear();
      }
    public void initFeaturedArtistIds()
      {
        flagHasFeaturedArtistIds = true;
        storeFeaturedArtistIds.Clear();
      }
    public void appendFeaturedArtistIds(string to_append)
      {
        if (!flagHasFeaturedArtistIds)
          {
            flagHasFeaturedArtistIds = true;
            storeFeaturedArtistIds.Clear();
          }
        Debug.Assert(flagHasFeaturedArtistIds);
        storeFeaturedArtistIds.Add(to_append);
      }
    public void unsetFeaturedArtistIds()
      {
        flagHasFeaturedArtistIds = false;
        storeFeaturedArtistIds.Clear();
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

    public virtual void extraUserMusicAlbumSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserMusicAlbumSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserMusicAlbumSpecLookup(key);
        if (old_field == null)
          {
            extraUserMusicAlbumSpecAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTitle);
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasAlbumId)
          {
            handler.start_pair("AlbumId");
            handler.string_value(storeAlbumId);
          }
        if (flagHasFilePath)
          {
            handler.start_pair("FilePath");
            handler.string_value(storeFilePath);
          }
        if (flagHasPrimaryArtistIds)
          {
            handler.start_pair("PrimaryArtistIds");
            handler.start_array();
            for (int num1 = 0; num1 < storePrimaryArtistIds.Count; ++num1)
              {
                handler.string_value(storePrimaryArtistIds[num1]);
              }
            handler.finish_array();
          }
        if (flagHasFeaturedArtistIds)
          {
            handler.start_pair("FeaturedArtistIds");
            handler.start_array();
            for (int num2 = 0; num2 < storeFeaturedArtistIds.Count; ++num2)
              {
                handler.string_value(storeFeaturedArtistIds[num2]);
              }
            handler.finish_array();
          }
        if (flagHasArtistName)
          {
            handler.start_pair("ArtistName");
            handler.string_value(storeArtistName);
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
        if (!(hasTitle()))
          {
            return "When parsing the object for %what%, the \"Title\" field was missing.";
          }
        return null;
      }

    public static UserMusicAlbumSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserMusicAlbumSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMusicAlbumSpec", ignore_extras);
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
    public static UserMusicAlbumSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserMusicAlbumSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserMusicAlbumSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMusicAlbumSpec", ignore_extras);
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
    public static UserMusicAlbumSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserMusicAlbumSpecJSON from_text(string text, bool ignore_extras)
      {
        UserMusicAlbumSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMusicAlbumSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserMusicAlbumSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UserMusicAlbumSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserMusicAlbumSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMusicAlbumSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorAlbumId;
        private JSONHoldingStringGenerator fieldGeneratorFilePath;
        private JSONHoldingStringArrayGenerator fieldGeneratorPrimaryArtistIds;
        private JSONHoldingStringArrayGenerator fieldGeneratorFeaturedArtistIds;
        private JSONHoldingStringGenerator fieldGeneratorArtistName;
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
            UserMusicAlbumSpecJSON result = new UserMusicAlbumSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserMusicAlbumSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UserMusicAlbumSpecJSON result)
          {
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            else if ((!(result.hasTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Title\" field was missing.");
              }
            if (fieldGeneratorAlbumId.have_value)
              {
                result.setAlbumId(fieldGeneratorAlbumId.value);
                fieldGeneratorAlbumId.have_value = false;
              }
            if (fieldGeneratorFilePath.have_value)
              {
                result.setFilePath(fieldGeneratorFilePath.value);
                fieldGeneratorFilePath.have_value = false;
              }
            if (fieldGeneratorPrimaryArtistIds.have_value)
              {
                result.initPrimaryArtistIds();
                int count = fieldGeneratorPrimaryArtistIds.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPrimaryArtistIds(fieldGeneratorPrimaryArtistIds.value[num]);
                  }
                fieldGeneratorPrimaryArtistIds.value.Clear();
                fieldGeneratorPrimaryArtistIds.have_value = false;
              }
            if (fieldGeneratorFeaturedArtistIds.have_value)
              {
                result.initFeaturedArtistIds();
                int count = fieldGeneratorFeaturedArtistIds.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFeaturedArtistIds(fieldGeneratorFeaturedArtistIds.value[num]);
                  }
                fieldGeneratorFeaturedArtistIds.value.Clear();
                fieldGeneratorFeaturedArtistIds.have_value = false;
              }
            if (fieldGeneratorArtistName.have_value)
              {
                result.setArtistName(fieldGeneratorArtistName.value);
                fieldGeneratorArtistName.have_value = false;
              }
          }
        protected abstract void handle_result(UserMusicAlbumSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "bumId", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorAlbumId;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "tistName", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorArtistName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "aturedArtistIds", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorFeaturedArtistIds;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "lePath", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorFilePath;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rimaryArtistIds", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorPrimaryArtistIds;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTitle;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the UserMusicAlbumSpec class");
            fieldGeneratorAlbumId = new JSONHoldingStringGenerator("field \"AlbumId\" of the UserMusicAlbumSpec class");
            fieldGeneratorFilePath = new JSONHoldingStringGenerator("field \"FilePath\" of the UserMusicAlbumSpec class");
            fieldGeneratorPrimaryArtistIds = new JSONHoldingStringArrayGenerator("field \"PrimaryArtistIds\" of the UserMusicAlbumSpec class");
            fieldGeneratorFeaturedArtistIds = new JSONHoldingStringArrayGenerator("field \"FeaturedArtistIds\" of the UserMusicAlbumSpec class");
            fieldGeneratorArtistName = new JSONHoldingStringGenerator("field \"ArtistName\" of the UserMusicAlbumSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserMusicAlbumSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the UserMusicAlbumSpec class");
            fieldGeneratorAlbumId = new JSONHoldingStringGenerator("field \"AlbumId\" of the UserMusicAlbumSpec class");
            fieldGeneratorFilePath = new JSONHoldingStringGenerator("field \"FilePath\" of the UserMusicAlbumSpec class");
            fieldGeneratorPrimaryArtistIds = new JSONHoldingStringArrayGenerator("field \"PrimaryArtistIds\" of the UserMusicAlbumSpec class");
            fieldGeneratorFeaturedArtistIds = new JSONHoldingStringArrayGenerator("field \"FeaturedArtistIds\" of the UserMusicAlbumSpec class");
            fieldGeneratorArtistName = new JSONHoldingStringGenerator("field \"ArtistName\" of the UserMusicAlbumSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserMusicAlbumSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTitle.reset();
            fieldGeneratorAlbumId.reset();
            fieldGeneratorFilePath.reset();
            fieldGeneratorPrimaryArtistIds.reset();
            fieldGeneratorFeaturedArtistIds.reset();
            fieldGeneratorArtistName.reset();
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
        protected override void handle_result(UserMusicAlbumSpecJSON  result)
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
        public UserMusicAlbumSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserMusicAlbumSpecJSON  result)
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
    protected virtual void handle_result(List<UserMusicAlbumSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserMusicAlbumSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserMusicAlbumSpecJSON>();
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
    public List<UserMusicAlbumSpecJSON> value;
  };
  };
