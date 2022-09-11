/* file "UserDataPandoraCustomRequestInfoFieldJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserDataPandoraCustomRequestInfoFieldJSON : JSONBase
  {
    private bool flagHasPlaylists;
    private List< UserPlaylistPandoraCustomRequestInfoFieldJSON  > storePlaylists;
    private bool flagHasStations;
    private List< UserStationPandoraCustomRequestInfoFieldJSON  > storeStations;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPlaylists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Playlists of UserDataPandoraCustomRequestInfoFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UserPlaylistPandoraCustomRequestInfoFieldJSON  > vector_Playlists1 = new List< UserPlaylistPandoraCustomRequestInfoFieldJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UserPlaylistPandoraCustomRequestInfoFieldJSON convert_classy = UserPlaylistPandoraCustomRequestInfoFieldJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Playlists1.Add(convert_classy);
          }
        initPlaylists();
        for (int num1 = 0; num1 < vector_Playlists1.Count; ++num1)
            appendPlaylists(vector_Playlists1[num1]);
        for (int num1 = 0; num1 < vector_Playlists1.Count; ++num1)
          {
          }
      }


    private void  fromJSONStations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Stations of UserDataPandoraCustomRequestInfoFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UserStationPandoraCustomRequestInfoFieldJSON  > vector_Stations1 = new List< UserStationPandoraCustomRequestInfoFieldJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UserStationPandoraCustomRequestInfoFieldJSON convert_classy = UserStationPandoraCustomRequestInfoFieldJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Stations1.Add(convert_classy);
          }
        initStations();
        for (int num2 = 0; num2 < vector_Stations1.Count; ++num2)
            appendStations(vector_Stations1[num2]);
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
          {
          }
      }


    public UserDataPandoraCustomRequestInfoFieldJSON()
      {
        flagHasPlaylists = false;
        flagHasStations = false;
        storePlaylists = new List< UserPlaylistPandoraCustomRequestInfoFieldJSON  >();
        storeStations = new List< UserStationPandoraCustomRequestInfoFieldJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPlaylists()
      {
        return flagHasPlaylists;
      }

    public int  countOfPlaylists()
      {
        Debug.Assert(flagHasPlaylists);
        return storePlaylists.Count;
      }

    public UserPlaylistPandoraCustomRequestInfoFieldJSON   elementOfPlaylists(int element_num)
      {
        Debug.Assert(flagHasPlaylists);
        return storePlaylists[element_num];
      }

    public List< UserPlaylistPandoraCustomRequestInfoFieldJSON  >  getPlaylists()
      {
        Debug.Assert(flagHasPlaylists);
        return storePlaylists;
      }

    public bool  hasStations()
      {
        return flagHasStations;
      }

    public int  countOfStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations.Count;
      }

    public UserStationPandoraCustomRequestInfoFieldJSON   elementOfStations(int element_num)
      {
        Debug.Assert(flagHasStations);
        return storeStations[element_num];
      }

    public List< UserStationPandoraCustomRequestInfoFieldJSON  >  getStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations;
      }


    public virtual int extraUserDataPandoraCustomRequestInfoFieldComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserDataPandoraCustomRequestInfoFieldComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserDataPandoraCustomRequestInfoFieldComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserDataPandoraCustomRequestInfoFieldLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initPlaylists()
      {
        if (flagHasPlaylists)
          {
            for (int num1 = 0; num1 < storePlaylists.Count; ++num1)
              {
              }
          }
        flagHasPlaylists = true;
        storePlaylists.Clear();
      }
    public void appendPlaylists(UserPlaylistPandoraCustomRequestInfoFieldJSON  to_append)
      {
        if (!flagHasPlaylists)
          {
            flagHasPlaylists = true;
            storePlaylists.Clear();
          }
        Debug.Assert(flagHasPlaylists);
        storePlaylists.Add(to_append);
      }
    public void unsetPlaylists()
      {
        if (flagHasPlaylists)
          {
            for (int num2 = 0; num2 < storePlaylists.Count; ++num2)
              {
              }
          }
        flagHasPlaylists = false;
        storePlaylists.Clear();
      }
    public void initStations()
      {
        if (flagHasStations)
          {
            for (int num3 = 0; num3 < storeStations.Count; ++num3)
              {
              }
          }
        flagHasStations = true;
        storeStations.Clear();
      }
    public void appendStations(UserStationPandoraCustomRequestInfoFieldJSON  to_append)
      {
        if (!flagHasStations)
          {
            flagHasStations = true;
            storeStations.Clear();
          }
        Debug.Assert(flagHasStations);
        storeStations.Add(to_append);
      }
    public void unsetStations()
      {
        if (flagHasStations)
          {
            for (int num4 = 0; num4 < storeStations.Count; ++num4)
              {
              }
          }
        flagHasStations = false;
        storeStations.Clear();
      }

    public virtual void extraUserDataPandoraCustomRequestInfoFieldAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserDataPandoraCustomRequestInfoFieldSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserDataPandoraCustomRequestInfoFieldLookup(key);
        if (old_field == null)
          {
            extraUserDataPandoraCustomRequestInfoFieldAppendPair(key, new_component);
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
        if (flagHasPlaylists)
          {
            handler.start_pair("Playlists");
            handler.start_array();
            for (int num1 = 0; num1 < storePlaylists.Count; ++num1)
              {
                if (partial_allowed)
                    storePlaylists[num1].write_partial_as_json(handler);
                else
                    storePlaylists[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasStations)
          {
            handler.start_pair("Stations");
            handler.start_array();
            for (int num2 = 0; num2 < storeStations.Count; ++num2)
              {
                if (partial_allowed)
                    storeStations[num2].write_partial_as_json(handler);
                else
                    storeStations[num2].write_as_json(handler);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static UserDataPandoraCustomRequestInfoFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserDataPandoraCustomRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserDataPandoraCustomRequestInfoField", ignore_extras);
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
    public static UserDataPandoraCustomRequestInfoFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserDataPandoraCustomRequestInfoFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserDataPandoraCustomRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserDataPandoraCustomRequestInfoField", ignore_extras);
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
    public static UserDataPandoraCustomRequestInfoFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserDataPandoraCustomRequestInfoFieldJSON from_text(string text, bool ignore_extras)
      {
        UserDataPandoraCustomRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserDataPandoraCustomRequestInfoField", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserDataPandoraCustomRequestInfoFieldJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UserDataPandoraCustomRequestInfoFieldJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserDataPandoraCustomRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserDataPandoraCustomRequestInfoField", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UserPlaylistPandoraCustomRequestInfoFieldJSON.HoldingArrayGenerator fieldGeneratorPlaylists;
        private UserStationPandoraCustomRequestInfoFieldJSON.HoldingArrayGenerator fieldGeneratorStations;
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
            UserDataPandoraCustomRequestInfoFieldJSON result = new UserDataPandoraCustomRequestInfoFieldJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserDataPandoraCustomRequestInfoFieldAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UserDataPandoraCustomRequestInfoFieldJSON result)
          {
            if (fieldGeneratorPlaylists.have_value)
              {
                result.initPlaylists();
                int count = fieldGeneratorPlaylists.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPlaylists(fieldGeneratorPlaylists.value[num]);
                  }
                fieldGeneratorPlaylists.value.Clear();
                fieldGeneratorPlaylists.have_value = false;
              }
            if (fieldGeneratorStations.have_value)
              {
                result.initStations();
                int count = fieldGeneratorStations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStations(fieldGeneratorStations.value[num]);
                  }
                fieldGeneratorStations.value.Clear();
                fieldGeneratorStations.have_value = false;
              }
          }
        protected abstract void handle_result(UserDataPandoraCustomRequestInfoFieldJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'P':
                    if ((String.Compare(field_name, 1, "laylists", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorPlaylists;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tations", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorStations;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPlaylists = new UserPlaylistPandoraCustomRequestInfoFieldJSON.HoldingArrayGenerator("field \"Playlists\" of the UserDataPandoraCustomRequestInfoField class", ignore_extras);
            fieldGeneratorStations = new UserStationPandoraCustomRequestInfoFieldJSON.HoldingArrayGenerator("field \"Stations\" of the UserDataPandoraCustomRequestInfoField class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserDataPandoraCustomRequestInfoField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPlaylists = new UserPlaylistPandoraCustomRequestInfoFieldJSON.HoldingArrayGenerator("field \"Playlists\" of the UserDataPandoraCustomRequestInfoField class", false);
            fieldGeneratorStations = new UserStationPandoraCustomRequestInfoFieldJSON.HoldingArrayGenerator("field \"Stations\" of the UserDataPandoraCustomRequestInfoField class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserDataPandoraCustomRequestInfoField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPlaylists.reset();
            fieldGeneratorStations.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPlaylists.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStations.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPlaylists.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStations.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UserDataPandoraCustomRequestInfoFieldJSON  result)
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
        public UserDataPandoraCustomRequestInfoFieldJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserDataPandoraCustomRequestInfoFieldJSON  result)
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
    protected virtual void handle_result(List<UserDataPandoraCustomRequestInfoFieldJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserDataPandoraCustomRequestInfoFieldJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserDataPandoraCustomRequestInfoFieldJSON>();
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
    public List<UserDataPandoraCustomRequestInfoFieldJSON> value;
  };
  };
