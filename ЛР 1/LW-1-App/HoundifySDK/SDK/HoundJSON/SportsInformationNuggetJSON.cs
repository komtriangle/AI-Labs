/* file "SportsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class SportsInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasUserData;
    private SportsUserDataJSON  storeUserData;


    private JSONValue  extraUserDataToJSON()
      {
        JSONValueHandler handler_UserData = new JSONValueHandler();
        storeUserData.write_as_json(handler_UserData);
        return handler_UserData.result;
      }


    private void  fromJSONUserData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsUserDataJSON convert_classy = SportsUserDataJSON.from_json(json_value, ignore_extras, true);
        setUserData(convert_classy);
      }


    public SportsInformationNuggetJSON()
      {
        flagHasUserData = false;
      }

    public override string  getNuggetKind()
      {
        return "Sports";
      }

    public abstract string getSportsNuggetKind();
    public bool  hasUserData()
      {
        return flagHasUserData;
      }

    public SportsUserDataJSON   getUserData()
      {
        Debug.Assert(flagHasUserData);
        return storeUserData;
      }


    public abstract int extraSportsInformationNuggetComponentCount();
    public abstract string extraSportsInformationNuggetComponentKey(int component_num);
    public abstract JSONValue extraSportsInformationNuggetComponentValue(int component_num);
    public abstract JSONValue extraSportsInformationNuggetLookup(string field_name);
    public override int extraInformationNuggetComponentCount()
      {
        int result = 1;
        if (flagHasUserData)
            ++result;
        result += extraSportsInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "SportsNuggetKind";
        int remainder = (component_num - 1);
        if (flagHasUserData)
          {
            if (remainder == 0)
                return "UserData";
            --remainder;
          }
        return extraSportsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getSportsNuggetKind());
        int remainder = (component_num - 1);
        if (flagHasUserData)
          {
            if (remainder == 0)
                return extraUserDataToJSON();
            --remainder;
          }
        return extraSportsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'S':
                if ((String.Compare(field_name, 1, "portsNuggetKind", 0, 15, false) == 0) && (field_name.Length == 16))
                    return new JSONStringValue(getSportsNuggetKind());
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serData", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasUserData ? extraUserDataToJSON() : null);
                break;
            default:
                break;
          }
        return extraSportsInformationNuggetLookup(field_name);
      }

    public void setUserData(SportsUserDataJSON  new_value)
      {
        if (flagHasUserData)
          {
          }
        flagHasUserData = true;
        storeUserData = new_value;
      }
    public void unsetUserData()
      {
        if (flagHasUserData)
          {
          }
        flagHasUserData = false;
      }

    public abstract void extraSportsInformationNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraSportsInformationNuggetSetField(string key, JSONValue new_component);
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'S':
                if ((String.Compare(key, 1, "portsNuggetKind", 0, 15, false) == 0) && (key.Length == 16))
                    return;
                break;
            case 'U':
                if ((String.Compare(key, 1, "serData", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONUserData(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSportsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'S':
                if ((String.Compare(key, 1, "portsNuggetKind", 0, 15, false) == 0) && (key.Length == 16))
                    return;
                break;
            case 'U':
                if ((String.Compare(key, 1, "serData", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONUserData(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSportsInformationNuggetSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("SportsNuggetKind", getSportsNuggetKind());
        if (flagHasUserData)
          {
            handler.start_pair("UserData");
            if (partial_allowed)
                storeUserData.write_partial_as_json(handler);
            else
                storeUserData.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new SportsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsInformationNugget", ignore_extras);
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
    public static new SportsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsInformationNugget", ignore_extras);
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
    public static new SportsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SportsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private SportsUserDataJSON.HoldingGenerator fieldGeneratorUserData;
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
                throw new Exception("The `SportsNuggetKind' field is missing.");
            if (!(getInformationNuggetJSONKey().Equals("Sports")))
                throw new Exception("The key field has a value other than `Sports'.");
            SportsInformationNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getSportsInformationNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsNuggetKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((SportsInformationNuggetJSON )new_result);
          }
        protected void finish(SportsInformationNuggetJSON result)
          {
            if (fieldGeneratorUserData.have_value)
              {
                result.setUserData(fieldGeneratorUserData.value);
                fieldGeneratorUserData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if ((String.Compare(field_name, 1, "portsNuggetKind", 0, 15, false) == 0) && (field_name.Length == 16))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serData", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorUserData;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUserData = new SportsUserDataJSON.HoldingGenerator("field \"UserData\" of the SportsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsNuggetKind\" of the SportsInformationNugget class");
            set_what("the SportsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUserData = new SportsUserDataJSON.HoldingGenerator("field \"UserData\" of the SportsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsNuggetKind\" of the SportsInformationNugget class");
            set_what("the SportsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorUserData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsInformationNuggetJSON  result)
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
        public SportsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SportsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsInformationNuggetJSON>();
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
    public List<SportsInformationNuggetJSON> value;
  };
    class GenericSportsInformationNuggetJSON : SportsInformationNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericSportsInformationNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getSportsNuggetKind()  { return key; }
        public override int extraSportsInformationNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraSportsInformationNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraSportsInformationNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraSportsInformationNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraSportsInformationNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraSportsInformationNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraSportsInformationNuggetLookup(key);
            if (old_field == null)
              {
                extraSportsInformationNuggetAppendPair(key, new_component);
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
    public static new SportsInformationNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "Sports", 0, 6, false) == 0)
      {
        switch (key[6])
          {
            case 'G':
                if ((String.Compare(key, 7, "ameSchedulesScores", 0, 18, false) == 0) && (key.Length == 25))
                    return new SportsGameSchedulesScoresInformationNuggetJSON();
                break;
            case 'L':
                if ((String.Compare(key, 7, "eagueLeaders", 0, 12, false) == 0) && (key.Length == 19))
                    return new SportsLeagueLeadersInformationNuggetJSON();
                break;
            case 'P':
                if (String.Compare(key, 7, "lay", 0, 3, false) == 0)
                  {
                    switch (key[10])
                      {
                        case 'e':
                            if ((String.Compare(key, 11, "rs", 0, 2, false) == 0) && (key.Length == 13))
                                return new SportsPlayersInformationNuggetJSON();
                            break;
                        case 'o':
                            if ((String.Compare(key, 11, "ffTrivia", 0, 8, false) == 0) && (key.Length == 19))
                                return new SportsPlayoffTriviaInformationNuggetJSON();
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if (String.Compare(key, 7, "ta", 0, 2, false) == 0)
                  {
                    switch (key[9])
                      {
                        case 'n':
                            if ((String.Compare(key, 10, "dings", 0, 5, false) == 0) && (key.Length == 15))
                                return new SportsStandingsInformationNuggetJSON();
                            break;
                        case 't':
                            if ((String.Compare(key, 10, "s", 0, 1, false) == 0) && (key.Length == 11))
                                return new SportsStatsInformationNuggetJSON();
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
      }

        return new GenericSportsInformationNuggetJSON(key);
      }
  };
