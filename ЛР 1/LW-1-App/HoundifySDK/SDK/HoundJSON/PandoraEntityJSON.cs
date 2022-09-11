/* file "PandoraEntityJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class PandoraEntityJSON : JSONBase
  {
    private bool flagHasEntityName;
    private string storeEntityName;
    private bool flagHasEntityID;
    private string storeEntityID;
    private bool flagHasIsUserOwned;
    private bool storeIsUserOwned;


    private void  fromJSONEntityName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EntityName of PandoraEntityJSON is not a string.");
        setEntityName(json_string.getData());
      }


    private void  fromJSONEntityID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EntityID of PandoraEntityJSON is not a string.");
        setEntityID(json_string.getData());
      }


    private void  fromJSONIsUserOwned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsUserOwned of PandoraEntityJSON is not true for false.");
              }
          }
        setIsUserOwned(the_bool);
      }


    public PandoraEntityJSON()
      {
        flagHasEntityName = false;
        flagHasEntityID = false;
        flagHasIsUserOwned = false;
      }

    public abstract string getEntityType();
    public bool  hasEntityName()
      {
        return flagHasEntityName;
      }

    public string  getEntityName()
      {
        Debug.Assert(flagHasEntityName);
        return storeEntityName;
      }

    public bool  hasEntityID()
      {
        return flagHasEntityID;
      }

    public string  getEntityID()
      {
        Debug.Assert(flagHasEntityID);
        return storeEntityID;
      }

    public bool  hasIsUserOwned()
      {
        return flagHasIsUserOwned;
      }

    public bool  getIsUserOwned()
      {
        Debug.Assert(flagHasIsUserOwned);
        return storeIsUserOwned;
      }


    public abstract int extraPandoraEntityComponentCount();
    public abstract string extraPandoraEntityComponentKey(int component_num);
    public abstract JSONValue extraPandoraEntityComponentValue(int component_num);
    public abstract JSONValue extraPandoraEntityLookup(string field_name);

    public void setEntityName(string new_value)
      {
        flagHasEntityName = true;
        storeEntityName = new_value;
      }
    public void unsetEntityName()
      {
        flagHasEntityName = false;
      }
    public void setEntityID(string new_value)
      {
        flagHasEntityID = true;
        storeEntityID = new_value;
      }
    public void unsetEntityID()
      {
        flagHasEntityID = false;
      }
    public void setIsUserOwned(bool new_value)
      {
        flagHasIsUserOwned = true;
        storeIsUserOwned = new_value;
      }
    public void unsetIsUserOwned()
      {
        flagHasIsUserOwned = false;
      }

    public abstract void extraPandoraEntityAppendPair(string key, JSONValue new_component);
    public abstract void extraPandoraEntitySetField(string key, JSONValue new_component);

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
        handler.pair("EntityType", getEntityType());
        if (flagHasEntityName)
          {
            handler.start_pair("EntityName");
            handler.string_value(storeEntityName);
          }
        if (flagHasEntityID)
          {
            handler.start_pair("EntityID");
            handler.string_value(storeEntityID);
          }
        if (flagHasIsUserOwned)
          {
            handler.start_pair("IsUserOwned");
            handler.boolean_value(storeIsUserOwned);
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

    public static PandoraEntityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PandoraEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PandoraEntity", ignore_extras);
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
    public static PandoraEntityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PandoraEntityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PandoraEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PandoraEntity", ignore_extras);
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
    public static PandoraEntityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PandoraEntityJSON from_text(string text, bool ignore_extras)
      {
        PandoraEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PandoraEntity", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PandoraEntityJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PandoraEntityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PandoraEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PandoraEntity", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorEntityName;
        private JSONHoldingStringGenerator fieldGeneratorEntityID;
        private JSONHoldingBooleanGenerator fieldGeneratorIsUserOwned;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `EntityType' field is missing.");
            PandoraEntityJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPandoraEntityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getPandoraEntityJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `EntityType' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(PandoraEntityJSON result)
          {
            if (fieldGeneratorEntityName.have_value)
              {
                result.setEntityName(fieldGeneratorEntityName.value);
                fieldGeneratorEntityName.have_value = false;
              }
            if (fieldGeneratorEntityID.have_value)
              {
                result.setEntityID(fieldGeneratorEntityID.value);
                fieldGeneratorEntityID.have_value = false;
              }
            if (fieldGeneratorIsUserOwned.have_value)
              {
                result.setIsUserOwned(fieldGeneratorIsUserOwned.value);
                fieldGeneratorIsUserOwned.have_value = false;
              }
          }
        protected abstract void handle_result(PandoraEntityJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if (String.Compare(field_name, 1, "ntity", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 7, "D", 0, 1, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorEntityID;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 7, "ame", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorEntityName;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "ype", 0, 3, false) == 0) && (field_name.Length == 10))
                                    {
                                    keyGenerator.reset();
                                    return keyGenerator;
                                    }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sUserOwned", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorIsUserOwned;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEntityName = new JSONHoldingStringGenerator("field \"EntityName\" of the PandoraEntity class");
            fieldGeneratorEntityID = new JSONHoldingStringGenerator("field \"EntityID\" of the PandoraEntity class");
            fieldGeneratorIsUserOwned = new JSONHoldingBooleanGenerator("field \"IsUserOwned\" of the PandoraEntity class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"EntityType\" of the PandoraEntity class");
            set_what("the PandoraEntity class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEntityName = new JSONHoldingStringGenerator("field \"EntityName\" of the PandoraEntity class");
            fieldGeneratorEntityID = new JSONHoldingStringGenerator("field \"EntityID\" of the PandoraEntity class");
            fieldGeneratorIsUserOwned = new JSONHoldingBooleanGenerator("field \"IsUserOwned\" of the PandoraEntity class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"EntityType\" of the PandoraEntity class");
            set_what("the PandoraEntity class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEntityName.reset();
            fieldGeneratorEntityID.reset();
            fieldGeneratorIsUserOwned.reset();
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
        protected override void handle_result(PandoraEntityJSON  result)
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
        public PandoraEntityJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PandoraEntityJSON  result)
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
    protected virtual void handle_result(List<PandoraEntityJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PandoraEntityJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PandoraEntityJSON>();
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
    public List<PandoraEntityJSON> value;
  };
    class GenericPandoraEntityJSON : PandoraEntityJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericPandoraEntityJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getEntityType()  { return key; }
        public override int extraPandoraEntityComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraPandoraEntityComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraPandoraEntityComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraPandoraEntityLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraPandoraEntityAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraPandoraEntitySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraPandoraEntityLookup(key);
            if (old_field == null)
              {
                extraPandoraEntityAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static PandoraEntityJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'A':
            switch (key[1])
              {
                case 'l':
                    if ((String.Compare(key, 2, "bum", 0, 3, false) == 0) && (key.Length == 5))
                        return new AlbumPandoraEntityJSON();
                    break;
                case 'r':
                    if ((String.Compare(key, 2, "tist", 0, 4, false) == 0) && (key.Length == 6))
                        return new ArtistPandoraEntityJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'P':
            switch (key[1])
              {
                case 'l':
                    if ((String.Compare(key, 2, "aylist", 0, 6, false) == 0) && (key.Length == 8))
                        return new PlaylistPandoraEntityJSON();
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "dcast", 0, 5, false) == 0) && (key.Length == 7))
                        return new PodcastPandoraEntityJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'T':
            if ((String.Compare(key, 1, "rack", 0, 4, false) == 0) && (key.Length == 5))
                return new TrackPandoraEntityJSON();
            break;
        default:
            break;
      }

        return new GenericPandoraEntityJSON(key);
      }
  };
