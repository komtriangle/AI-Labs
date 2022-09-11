/* file "SportsLeagueControlJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsLeagueControlJSON : JSONBase
  {
    private bool flagHasEnabledLeagues;
    private List< SportsLeagueCodeJSON  > storeEnabledLeagues;
    private bool flagHasPreferredLeagues;
    private List< SportsLeagueCodeJSON  > storePreferredLeagues;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEnabledLeagues(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field EnabledLeagues of SportsLeagueControlJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field EnabledLeagues of SportsLeagueControlJSON has too few elements.");
        List< SportsLeagueCodeJSON  > vector_EnabledLeagues1 = new List< SportsLeagueCodeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsLeagueCodeJSON convert_classy = SportsLeagueCodeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_EnabledLeagues1.Add(convert_classy);
          }
        Debug.Assert(vector_EnabledLeagues1.Count >= 1);
        initEnabledLeagues();
        for (int num1 = 0; num1 < vector_EnabledLeagues1.Count; ++num1)
            appendEnabledLeagues(vector_EnabledLeagues1[num1]);
        for (int num1 = 0; num1 < vector_EnabledLeagues1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPreferredLeagues(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PreferredLeagues of SportsLeagueControlJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field PreferredLeagues of SportsLeagueControlJSON has too few elements.");
        List< SportsLeagueCodeJSON  > vector_PreferredLeagues1 = new List< SportsLeagueCodeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsLeagueCodeJSON convert_classy = SportsLeagueCodeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_PreferredLeagues1.Add(convert_classy);
          }
        Debug.Assert(vector_PreferredLeagues1.Count >= 1);
        initPreferredLeagues();
        for (int num2 = 0; num2 < vector_PreferredLeagues1.Count; ++num2)
            appendPreferredLeagues(vector_PreferredLeagues1[num2]);
        for (int num1 = 0; num1 < vector_PreferredLeagues1.Count; ++num1)
          {
          }
      }


    public SportsLeagueControlJSON()
      {
        flagHasEnabledLeagues = false;
        flagHasPreferredLeagues = false;
        storeEnabledLeagues = new List< SportsLeagueCodeJSON  >();
        storePreferredLeagues = new List< SportsLeagueCodeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEnabledLeagues()
      {
        return flagHasEnabledLeagues;
      }

    public int  countOfEnabledLeagues()
      {
        Debug.Assert(flagHasEnabledLeagues);
        return storeEnabledLeagues.Count;
      }

    public SportsLeagueCodeJSON   elementOfEnabledLeagues(int element_num)
      {
        Debug.Assert(flagHasEnabledLeagues);
        return storeEnabledLeagues[element_num];
      }

    public List< SportsLeagueCodeJSON  >  getEnabledLeagues()
      {
        Debug.Assert(flagHasEnabledLeagues);
        return storeEnabledLeagues;
      }

    public bool  hasPreferredLeagues()
      {
        return flagHasPreferredLeagues;
      }

    public int  countOfPreferredLeagues()
      {
        Debug.Assert(flagHasPreferredLeagues);
        return storePreferredLeagues.Count;
      }

    public SportsLeagueCodeJSON   elementOfPreferredLeagues(int element_num)
      {
        Debug.Assert(flagHasPreferredLeagues);
        return storePreferredLeagues[element_num];
      }

    public List< SportsLeagueCodeJSON  >  getPreferredLeagues()
      {
        Debug.Assert(flagHasPreferredLeagues);
        return storePreferredLeagues;
      }


    public virtual int extraSportsLeagueControlComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsLeagueControlComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsLeagueControlComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsLeagueControlLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initEnabledLeagues()
      {
        if (flagHasEnabledLeagues)
          {
            for (int num1 = 0; num1 < storeEnabledLeagues.Count; ++num1)
              {
              }
          }
        flagHasEnabledLeagues = true;
        storeEnabledLeagues.Clear();
      }
    public void appendEnabledLeagues(SportsLeagueCodeJSON  to_append)
      {
        if (!flagHasEnabledLeagues)
          {
            flagHasEnabledLeagues = true;
            storeEnabledLeagues.Clear();
          }
        Debug.Assert(flagHasEnabledLeagues);
        storeEnabledLeagues.Add(to_append);
      }
    public void appendEnabledLeagues(SportsLeagueCodeJSON.TypeValue new_value)
      {
        appendEnabledLeagues(new SportsLeagueCodeJSON(new_value));
      }
    public void appendEnabledLeagues(string chars)
      {
        SportsLeagueCodeJSON.TypeValueKnownValues known = SportsLeagueCodeJSON.stringToValue(chars);
        SportsLeagueCodeJSON.TypeValue new_value = new SportsLeagueCodeJSON.TypeValue();
        if (known == SportsLeagueCodeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendEnabledLeagues(new_value);
      }
    public void unsetEnabledLeagues()
      {
        if (flagHasEnabledLeagues)
          {
            for (int num2 = 0; num2 < storeEnabledLeagues.Count; ++num2)
              {
              }
          }
        flagHasEnabledLeagues = false;
        storeEnabledLeagues.Clear();
      }
    public void initPreferredLeagues()
      {
        if (flagHasPreferredLeagues)
          {
            for (int num3 = 0; num3 < storePreferredLeagues.Count; ++num3)
              {
              }
          }
        flagHasPreferredLeagues = true;
        storePreferredLeagues.Clear();
      }
    public void appendPreferredLeagues(SportsLeagueCodeJSON  to_append)
      {
        if (!flagHasPreferredLeagues)
          {
            flagHasPreferredLeagues = true;
            storePreferredLeagues.Clear();
          }
        Debug.Assert(flagHasPreferredLeagues);
        storePreferredLeagues.Add(to_append);
      }
    public void appendPreferredLeagues(SportsLeagueCodeJSON.TypeValue new_value)
      {
        appendPreferredLeagues(new SportsLeagueCodeJSON(new_value));
      }
    public void appendPreferredLeagues(string chars)
      {
        SportsLeagueCodeJSON.TypeValueKnownValues known = SportsLeagueCodeJSON.stringToValue(chars);
        SportsLeagueCodeJSON.TypeValue new_value = new SportsLeagueCodeJSON.TypeValue();
        if (known == SportsLeagueCodeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendPreferredLeagues(new_value);
      }
    public void unsetPreferredLeagues()
      {
        if (flagHasPreferredLeagues)
          {
            for (int num4 = 0; num4 < storePreferredLeagues.Count; ++num4)
              {
              }
          }
        flagHasPreferredLeagues = false;
        storePreferredLeagues.Clear();
      }

    public virtual void extraSportsLeagueControlAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsLeagueControlSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsLeagueControlLookup(key);
        if (old_field == null)
          {
            extraSportsLeagueControlAppendPair(key, new_component);
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
        if (flagHasEnabledLeagues)
          {
            handler.start_pair("EnabledLeagues");
            Debug.Assert(storeEnabledLeagues.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeEnabledLeagues.Count; ++num1)
              {
                if (partial_allowed)
                    storeEnabledLeagues[num1].write_partial_as_json(handler);
                else
                    storeEnabledLeagues[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasPreferredLeagues)
          {
            handler.start_pair("PreferredLeagues");
            Debug.Assert(storePreferredLeagues.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storePreferredLeagues.Count; ++num2)
              {
                if (partial_allowed)
                    storePreferredLeagues[num2].write_partial_as_json(handler);
                else
                    storePreferredLeagues[num2].write_as_json(handler);
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

    public static SportsLeagueControlJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueControlJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueControl", ignore_extras);
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
    public static SportsLeagueControlJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueControlJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueControlJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueControl", ignore_extras);
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
    public static SportsLeagueControlJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueControlJSON from_text(string text, bool ignore_extras)
      {
        SportsLeagueControlJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueControl", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsLeagueControlJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsLeagueControlJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsLeagueControlJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueControl", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsLeagueCodeJSON.HoldingArrayGenerator fieldGeneratorEnabledLeagues;
        private SportsLeagueCodeJSON.HoldingArrayGenerator fieldGeneratorPreferredLeagues;
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
            SportsLeagueControlJSON result = new SportsLeagueControlJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsLeagueControlAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsLeagueControlJSON result)
          {
            if (fieldGeneratorEnabledLeagues.have_value)
              {
                result.initEnabledLeagues();
                int count = fieldGeneratorEnabledLeagues.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEnabledLeagues(fieldGeneratorEnabledLeagues.value[num]);
                  }
                fieldGeneratorEnabledLeagues.value.Clear();
                fieldGeneratorEnabledLeagues.have_value = false;
              }
            if (fieldGeneratorPreferredLeagues.have_value)
              {
                result.initPreferredLeagues();
                int count = fieldGeneratorPreferredLeagues.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPreferredLeagues(fieldGeneratorPreferredLeagues.value[num]);
                  }
                fieldGeneratorPreferredLeagues.value.Clear();
                fieldGeneratorPreferredLeagues.have_value = false;
              }
          }
        protected abstract void handle_result(SportsLeagueControlJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "nabledLeagues", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorEnabledLeagues;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "referredLeagues", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorPreferredLeagues;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEnabledLeagues = new SportsLeagueCodeJSON.HoldingArrayGenerator("field \"EnabledLeagues\" of the SportsLeagueControl class", ignore_extras);
            fieldGeneratorPreferredLeagues = new SportsLeagueCodeJSON.HoldingArrayGenerator("field \"PreferredLeagues\" of the SportsLeagueControl class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsLeagueControl class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEnabledLeagues = new SportsLeagueCodeJSON.HoldingArrayGenerator("field \"EnabledLeagues\" of the SportsLeagueControl class", false);
            fieldGeneratorPreferredLeagues = new SportsLeagueCodeJSON.HoldingArrayGenerator("field \"PreferredLeagues\" of the SportsLeagueControl class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsLeagueControl class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEnabledLeagues.reset();
            fieldGeneratorPreferredLeagues.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEnabledLeagues.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPreferredLeagues.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEnabledLeagues.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPreferredLeagues.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsLeagueControlJSON  result)
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
        public SportsLeagueControlJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsLeagueControlJSON  result)
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
    protected virtual void handle_result(List<SportsLeagueControlJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsLeagueControlJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsLeagueControlJSON>();
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
    public List<SportsLeagueControlJSON> value;
  };
  };
