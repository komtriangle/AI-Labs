/* file "AlbumPandoraEntityJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AlbumPandoraEntityJSON : PandoraEntityJSON
  {
    private bool flagHasArtists;
    private List< ArtistPandoraEntityJSON  > storeArtists;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraArtistsToJSON()
      {
        JSONArrayValue generated_array_1_Artists = new JSONArrayValue();
        for (int num1 = 0; num1 < storeArtists.Count; ++num1)
          {
            JSONValueHandler handler_Artists = new JSONValueHandler();
            storeArtists[num1].write_as_json(handler_Artists);
            generated_array_1_Artists.appendComponent(handler_Artists.result);
          }
        return generated_array_1_Artists;
      }


    private void  fromJSONArtists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Artists of AlbumPandoraEntityJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Artists of AlbumPandoraEntityJSON has too few elements.");
        List< ArtistPandoraEntityJSON  > vector_Artists1 = new List< ArtistPandoraEntityJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ArtistPandoraEntityJSON convert_classy = ArtistPandoraEntityJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Artists1.Add(convert_classy);
          }
        Debug.Assert(vector_Artists1.Count >= 1);
        initArtists();
        for (int num1 = 0; num1 < vector_Artists1.Count; ++num1)
            appendArtists(vector_Artists1[num1]);
        for (int num1 = 0; num1 < vector_Artists1.Count; ++num1)
          {
          }
      }


    public AlbumPandoraEntityJSON()
      {
        flagHasArtists = false;
        storeArtists = new List< ArtistPandoraEntityJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getEntityType()
      {
        return "Album";
      }

    public bool  hasArtists()
      {
        return flagHasArtists;
      }

    public int  countOfArtists()
      {
        Debug.Assert(flagHasArtists);
        return storeArtists.Count;
      }

    public ArtistPandoraEntityJSON   elementOfArtists(int element_num)
      {
        Debug.Assert(flagHasArtists);
        return storeArtists[element_num];
      }

    public List< ArtistPandoraEntityJSON  >  getArtists()
      {
        Debug.Assert(flagHasArtists);
        return storeArtists;
      }


    public virtual int extraAlbumPandoraEntityComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAlbumPandoraEntityComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAlbumPandoraEntityComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAlbumPandoraEntityLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPandoraEntityComponentCount()
      {
        int result = 0;
        if (flagHasArtists)
            ++result;
        result += extraAlbumPandoraEntityComponentCount();
        return result;
      }
    public override string extraPandoraEntityComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasArtists)
          {
            if (remainder == 0)
                return "Artists";
            --remainder;
          }
        return extraAlbumPandoraEntityComponentKey(remainder);
      }
    public override JSONValue extraPandoraEntityComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasArtists)
          {
            if (remainder == 0)
                return extraArtistsToJSON();
            --remainder;
          }
        return extraAlbumPandoraEntityComponentValue(remainder);
      }
    public override JSONValue extraPandoraEntityLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Artists", 0, 7, false) == 0) && (field_name.Length == 7))
            return (flagHasArtists ? extraArtistsToJSON() : null);
        return extraAlbumPandoraEntityLookup(field_name);
      }

    public void initArtists()
      {
        if (flagHasArtists)
          {
            for (int num1 = 0; num1 < storeArtists.Count; ++num1)
              {
              }
          }
        flagHasArtists = true;
        storeArtists.Clear();
      }
    public void appendArtists(ArtistPandoraEntityJSON  to_append)
      {
        if (!flagHasArtists)
          {
            flagHasArtists = true;
            storeArtists.Clear();
          }
        Debug.Assert(flagHasArtists);
        storeArtists.Add(to_append);
      }
    public void unsetArtists()
      {
        if (flagHasArtists)
          {
            for (int num2 = 0; num2 < storeArtists.Count; ++num2)
              {
              }
          }
        flagHasArtists = false;
        storeArtists.Clear();
      }

    public virtual void extraAlbumPandoraEntityAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAlbumPandoraEntitySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAlbumPandoraEntityLookup(key);
        if (old_field == null)
          {
            extraAlbumPandoraEntityAppendPair(key, new_component);
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
    public override void extraPandoraEntityAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Artists", 0, 7, false) == 0) && (key.Length == 7))
            {
            fromJSONArtists(new_component, false);
            return;
            }
        extraAlbumPandoraEntityAppendPair(key, new_component);
      }
    public override void extraPandoraEntitySetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Artists", 0, 7, false) == 0) && (key.Length == 7))
            {
            fromJSONArtists(new_component, false);
            return;
            }
        extraAlbumPandoraEntitySetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasArtists)
          {
            handler.start_pair("Artists");
            Debug.Assert(storeArtists.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeArtists.Count; ++num1)
              {
                if (partial_allowed)
                    storeArtists[num1].write_partial_as_json(handler);
                else
                    storeArtists[num1].write_as_json(handler);
              }
            handler.finish_array();
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new AlbumPandoraEntityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AlbumPandoraEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlbumPandoraEntity", ignore_extras);
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
    public static new AlbumPandoraEntityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AlbumPandoraEntityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AlbumPandoraEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlbumPandoraEntity", ignore_extras);
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
    public static new AlbumPandoraEntityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AlbumPandoraEntityJSON from_text(string text, bool ignore_extras)
      {
        AlbumPandoraEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlbumPandoraEntity", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AlbumPandoraEntityJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AlbumPandoraEntityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AlbumPandoraEntityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlbumPandoraEntity", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PandoraEntityJSON.Generator
      {
        private ArtistPandoraEntityJSON.HoldingArrayGenerator fieldGeneratorArtists;
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
            if (!(getPandoraEntityJSONKey().Equals("Album")))
                throw new Exception("The key field has a value other than `Album'.");
            AlbumPandoraEntityJSON result = new AlbumPandoraEntityJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAlbumPandoraEntityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PandoraEntityJSON new_result)
          {
            handle_result((AlbumPandoraEntityJSON )new_result);
          }
        protected void finish(AlbumPandoraEntityJSON result)
          {
            if (fieldGeneratorArtists.have_value)
              {
                result.initArtists();
                int count = fieldGeneratorArtists.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendArtists(fieldGeneratorArtists.value[num]);
                  }
                fieldGeneratorArtists.value.Clear();
                fieldGeneratorArtists.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(AlbumPandoraEntityJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Artists", 0, 7, false) == 0) && (field_name.Length == 7))
                return fieldGeneratorArtists;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorArtists = new ArtistPandoraEntityJSON.HoldingArrayGenerator("field \"Artists\" of the AlbumPandoraEntity class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AlbumPandoraEntity class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorArtists = new ArtistPandoraEntityJSON.HoldingArrayGenerator("field \"Artists\" of the AlbumPandoraEntity class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AlbumPandoraEntity class");
          }

        public override void reset()
          {
            fieldGeneratorArtists.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AlbumPandoraEntityJSON  result)
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
        public AlbumPandoraEntityJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AlbumPandoraEntityJSON  result)
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
    protected virtual void handle_result(List<AlbumPandoraEntityJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AlbumPandoraEntityJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AlbumPandoraEntityJSON>();
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
    public List<AlbumPandoraEntityJSON> value;
  };
  };
