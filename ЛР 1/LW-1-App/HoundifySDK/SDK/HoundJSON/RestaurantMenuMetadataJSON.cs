/* file "RestaurantMenuMetadataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RestaurantMenuMetadataJSON : JSONBase
  {
    private bool flagHasGet;
    private bool storeGet;
    private bool flagHasMD5;
    private string storeMD5;
    private bool flagHasCommit;
    private string storeCommit;
    private bool flagHasRestaurant;
    private string storeRestaurant;
    private bool flagHasLocation;
    private string storeLocation;
    private bool flagHasVersion;
    private string storeVersion;
    private bool flagHasRawMenuFilename;
    private string storeRawMenuFilename;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONGet(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Get of RestaurantMenuMetadataJSON is not true for false.");
              }
          }
        setGet(the_bool);
      }


    private void  fromJSONMD5(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MD5 of RestaurantMenuMetadataJSON is not a string.");
        setMD5(json_string.getData());
      }


    private void  fromJSONCommit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Commit of RestaurantMenuMetadataJSON is not a string.");
        setCommit(json_string.getData());
      }


    private void  fromJSONRestaurant(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Restaurant of RestaurantMenuMetadataJSON is not a string.");
        setRestaurant(json_string.getData());
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Location of RestaurantMenuMetadataJSON is not a string.");
        setLocation(json_string.getData());
      }


    private void  fromJSONVersion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Version of RestaurantMenuMetadataJSON is not a string.");
        setVersion(json_string.getData());
      }


    private void  fromJSONRawMenuFilename(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RawMenuFilename of RestaurantMenuMetadataJSON is not a string.");
        setRawMenuFilename(json_string.getData());
      }


    public RestaurantMenuMetadataJSON()
      {
        flagHasGet = false;
        flagHasMD5 = false;
        flagHasCommit = false;
        flagHasRestaurant = false;
        flagHasLocation = false;
        flagHasVersion = false;
        flagHasRawMenuFilename = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasGet()
      {
        return flagHasGet;
      }

    public bool  getGet()
      {
        Debug.Assert(flagHasGet);
        return storeGet;
      }

    public bool  hasMD5()
      {
        return flagHasMD5;
      }

    public string  getMD5()
      {
        Debug.Assert(flagHasMD5);
        return storeMD5;
      }

    public bool  hasCommit()
      {
        return flagHasCommit;
      }

    public string  getCommit()
      {
        Debug.Assert(flagHasCommit);
        return storeCommit;
      }

    public bool  hasRestaurant()
      {
        return flagHasRestaurant;
      }

    public string  getRestaurant()
      {
        Debug.Assert(flagHasRestaurant);
        return storeRestaurant;
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public string  getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasVersion()
      {
        return flagHasVersion;
      }

    public string  getVersion()
      {
        Debug.Assert(flagHasVersion);
        return storeVersion;
      }

    public bool  hasRawMenuFilename()
      {
        return flagHasRawMenuFilename;
      }

    public string  getRawMenuFilename()
      {
        Debug.Assert(flagHasRawMenuFilename);
        return storeRawMenuFilename;
      }


    public virtual int extraRestaurantMenuMetadataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantMenuMetadataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantMenuMetadataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantMenuMetadataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setGet(bool new_value)
      {
        flagHasGet = true;
        storeGet = new_value;
      }
    public void unsetGet()
      {
        flagHasGet = false;
      }
    public void setMD5(string new_value)
      {
        flagHasMD5 = true;
        storeMD5 = new_value;
      }
    public void unsetMD5()
      {
        flagHasMD5 = false;
      }
    public void setCommit(string new_value)
      {
        flagHasCommit = true;
        storeCommit = new_value;
      }
    public void unsetCommit()
      {
        flagHasCommit = false;
      }
    public void setRestaurant(string new_value)
      {
        flagHasRestaurant = true;
        storeRestaurant = new_value;
      }
    public void unsetRestaurant()
      {
        flagHasRestaurant = false;
      }
    public void setLocation(string new_value)
      {
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        flagHasLocation = false;
      }
    public void setVersion(string new_value)
      {
        flagHasVersion = true;
        storeVersion = new_value;
      }
    public void unsetVersion()
      {
        flagHasVersion = false;
      }
    public void setRawMenuFilename(string new_value)
      {
        flagHasRawMenuFilename = true;
        storeRawMenuFilename = new_value;
      }
    public void unsetRawMenuFilename()
      {
        flagHasRawMenuFilename = false;
      }

    public virtual void extraRestaurantMenuMetadataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantMenuMetadataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantMenuMetadataLookup(key);
        if (old_field == null)
          {
            extraRestaurantMenuMetadataAppendPair(key, new_component);
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
        if (flagHasGet)
          {
            handler.start_pair("Get");
            handler.boolean_value(storeGet);
          }
        if (flagHasMD5)
          {
            handler.start_pair("MD5");
            handler.string_value(storeMD5);
          }
        if (flagHasCommit)
          {
            handler.start_pair("Commit");
            handler.string_value(storeCommit);
          }
        if (flagHasRestaurant)
          {
            handler.start_pair("Restaurant");
            handler.string_value(storeRestaurant);
          }
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            handler.string_value(storeLocation);
          }
        if (flagHasVersion)
          {
            handler.start_pair("Version");
            handler.string_value(storeVersion);
          }
        if (flagHasRawMenuFilename)
          {
            handler.start_pair("RawMenuFilename");
            handler.string_value(storeRawMenuFilename);
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
        return null;
      }

    public static RestaurantMenuMetadataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuMetadata", ignore_extras);
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
    public static RestaurantMenuMetadataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuMetadataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuMetadata", ignore_extras);
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
    public static RestaurantMenuMetadataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuMetadataJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuMetadata", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuMetadataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuMetadataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuMetadata", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorGet;
        private JSONHoldingStringGenerator fieldGeneratorMD5;
        private JSONHoldingStringGenerator fieldGeneratorCommit;
        private JSONHoldingStringGenerator fieldGeneratorRestaurant;
        private JSONHoldingStringGenerator fieldGeneratorLocation;
        private JSONHoldingStringGenerator fieldGeneratorVersion;
        private JSONHoldingStringGenerator fieldGeneratorRawMenuFilename;
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
            RestaurantMenuMetadataJSON result = new RestaurantMenuMetadataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantMenuMetadataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantMenuMetadataJSON result)
          {
            if (fieldGeneratorGet.have_value)
              {
                result.setGet(fieldGeneratorGet.value);
                fieldGeneratorGet.have_value = false;
              }
            if (fieldGeneratorMD5.have_value)
              {
                result.setMD5(fieldGeneratorMD5.value);
                fieldGeneratorMD5.have_value = false;
              }
            if (fieldGeneratorCommit.have_value)
              {
                result.setCommit(fieldGeneratorCommit.value);
                fieldGeneratorCommit.have_value = false;
              }
            if (fieldGeneratorRestaurant.have_value)
              {
                result.setRestaurant(fieldGeneratorRestaurant.value);
                fieldGeneratorRestaurant.have_value = false;
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            if (fieldGeneratorVersion.have_value)
              {
                result.setVersion(fieldGeneratorVersion.value);
                fieldGeneratorVersion.have_value = false;
              }
            if (fieldGeneratorRawMenuFilename.have_value)
              {
                result.setRawMenuFilename(fieldGeneratorRawMenuFilename.value);
                fieldGeneratorRawMenuFilename.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantMenuMetadataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommit", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorCommit;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "et", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorGet;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "D5", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorMD5;
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "wMenuFilename", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorRawMenuFilename;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "staurant", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorRestaurant;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ersion", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorVersion;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorGet = new JSONHoldingBooleanGenerator("field \"Get\" of the RestaurantMenuMetadata class");
            fieldGeneratorMD5 = new JSONHoldingStringGenerator("field \"MD5\" of the RestaurantMenuMetadata class");
            fieldGeneratorCommit = new JSONHoldingStringGenerator("field \"Commit\" of the RestaurantMenuMetadata class");
            fieldGeneratorRestaurant = new JSONHoldingStringGenerator("field \"Restaurant\" of the RestaurantMenuMetadata class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the RestaurantMenuMetadata class");
            fieldGeneratorVersion = new JSONHoldingStringGenerator("field \"Version\" of the RestaurantMenuMetadata class");
            fieldGeneratorRawMenuFilename = new JSONHoldingStringGenerator("field \"RawMenuFilename\" of the RestaurantMenuMetadata class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantMenuMetadata class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorGet = new JSONHoldingBooleanGenerator("field \"Get\" of the RestaurantMenuMetadata class");
            fieldGeneratorMD5 = new JSONHoldingStringGenerator("field \"MD5\" of the RestaurantMenuMetadata class");
            fieldGeneratorCommit = new JSONHoldingStringGenerator("field \"Commit\" of the RestaurantMenuMetadata class");
            fieldGeneratorRestaurant = new JSONHoldingStringGenerator("field \"Restaurant\" of the RestaurantMenuMetadata class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the RestaurantMenuMetadata class");
            fieldGeneratorVersion = new JSONHoldingStringGenerator("field \"Version\" of the RestaurantMenuMetadata class");
            fieldGeneratorRawMenuFilename = new JSONHoldingStringGenerator("field \"RawMenuFilename\" of the RestaurantMenuMetadata class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantMenuMetadata class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorGet.reset();
            fieldGeneratorMD5.reset();
            fieldGeneratorCommit.reset();
            fieldGeneratorRestaurant.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorVersion.reset();
            fieldGeneratorRawMenuFilename.reset();
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
        protected override void handle_result(RestaurantMenuMetadataJSON  result)
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
        public RestaurantMenuMetadataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuMetadataJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuMetadataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuMetadataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuMetadataJSON>();
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
    public List<RestaurantMenuMetadataJSON> value;
  };
  };
