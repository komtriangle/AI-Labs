/* file "SportsStandingsArgumentTeamOtherJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStandingsArgumentTeamOtherJSON : SportsStandingsArgumentJSON
  {
    private bool flagHasTeamID;
    private string storeTeamID;
    private bool flagHasTeamLeague;
    private SportsLeagueCodeJSON  storeTeamLeague;
    private bool flagHasResultReference;
    private bool storeResultReference;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraTeamIDToJSON()
      {
        JSONStringValue generated_string_TeamID = new JSONStringValue(storeTeamID);
        return generated_string_TeamID;
      }

    private JSONValue  extraTeamLeagueToJSON()
      {
        JSONValueHandler handler_TeamLeague = new JSONValueHandler();
        storeTeamLeague.write_as_json(handler_TeamLeague);
        return handler_TeamLeague.result;
      }

    private JSONValue  extraResultReferenceToJSON()
      {
        JSONValue generated_boolean_ResultReference = (storeResultReference ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ResultReference;
      }


    private void  fromJSONTeamID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TeamID of SportsStandingsArgumentTeamOtherJSON is not a string.");
        setTeamID(json_string.getData());
      }


    private void  fromJSONTeamLeague(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsLeagueCodeJSON convert_classy = SportsLeagueCodeJSON.from_json(json_value, ignore_extras, true);
        setTeamLeague(convert_classy);
      }


    private void  fromJSONResultReference(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ResultReference of SportsStandingsArgumentTeamOtherJSON is not true for false.");
              }
          }
        setResultReference(the_bool);
      }


    public SportsStandingsArgumentTeamOtherJSON()
      {
        flagHasTeamID = false;
        flagHasTeamLeague = false;
        flagHasResultReference = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsStandingsArgumentKind()
      {
        return "TeamOther";
      }

    public bool  hasTeamID()
      {
        return flagHasTeamID;
      }

    public string  getTeamID()
      {
        Debug.Assert(flagHasTeamID);
        return storeTeamID;
      }

    public bool  hasTeamLeague()
      {
        return flagHasTeamLeague;
      }

    public SportsLeagueCodeJSON   getTeamLeague()
      {
        Debug.Assert(flagHasTeamLeague);
        return storeTeamLeague;
      }

    public SportsLeagueCodeJSON.TypeValue  getTeamLeagueValue()
      {
        return getTeamLeague().getValue();
      }

    public string  getTeamLeagueAsString()
      {
        return getTeamLeague().getValueAsString();
      }

    public bool  hasResultReference()
      {
        return flagHasResultReference;
      }

    public bool  getResultReference()
      {
        Debug.Assert(flagHasResultReference);
        return storeResultReference;
      }


    public virtual int extraSportsStandingsArgumentTeamOtherComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsArgumentTeamOtherComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentTeamOtherComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentTeamOtherLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsStandingsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasTeamID)
            ++result;
        if (flagHasTeamLeague)
            ++result;
        if (flagHasResultReference)
            ++result;
        result += extraSportsStandingsArgumentTeamOtherComponentCount();
        return result;
      }
    public override string extraSportsStandingsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasTeamID)
          {
            if (remainder == 0)
                return "TeamID";
            --remainder;
          }
        if (flagHasTeamLeague)
          {
            if (remainder == 0)
                return "TeamLeague";
            --remainder;
          }
        if (flagHasResultReference)
          {
            if (remainder == 0)
                return "ResultReference";
            --remainder;
          }
        return extraSportsStandingsArgumentTeamOtherComponentKey(remainder);
      }
    public override JSONValue extraSportsStandingsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasTeamID)
          {
            if (remainder == 0)
                return extraTeamIDToJSON();
            --remainder;
          }
        if (flagHasTeamLeague)
          {
            if (remainder == 0)
                return extraTeamLeagueToJSON();
            --remainder;
          }
        if (flagHasResultReference)
          {
            if (remainder == 0)
                return extraResultReferenceToJSON();
            --remainder;
          }
        return extraSportsStandingsArgumentTeamOtherComponentValue(remainder);
      }
    public override JSONValue extraSportsStandingsArgumentLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'R':
                if ((String.Compare(field_name, 1, "esultReference", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasResultReference ? extraResultReferenceToJSON() : null);
                break;
            case 'T':
                if (String.Compare(field_name, 1, "eam", 0, 3, false) == 0)
                  {
                    switch (field_name[4])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 5, "D", 0, 1, false) == 0) && (field_name.Length == 6))
                                return (flagHasTeamID ? extraTeamIDToJSON() : null);
                            break;
                        case 'L':
                            if ((String.Compare(field_name, 5, "eague", 0, 5, false) == 0) && (field_name.Length == 10))
                                return (flagHasTeamLeague ? extraTeamLeagueToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraSportsStandingsArgumentTeamOtherLookup(field_name);
      }

    public void setTeamID(string new_value)
      {
        flagHasTeamID = true;
        storeTeamID = new_value;
      }
    public void unsetTeamID()
      {
        flagHasTeamID = false;
      }
    public void setTeamLeague(SportsLeagueCodeJSON  new_value)
      {
        if (flagHasTeamLeague)
          {
          }
        flagHasTeamLeague = true;
        storeTeamLeague = new_value;
      }
    public void setTeamLeague(SportsLeagueCodeJSON.TypeValue new_value)
      {
        setTeamLeague(new SportsLeagueCodeJSON(new_value));
      }
    public void setTeamLeague(string chars)
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
        setTeamLeague(new_value);
      }
    public void unsetTeamLeague()
      {
        if (flagHasTeamLeague)
          {
          }
        flagHasTeamLeague = false;
      }
    public void setResultReference(bool new_value)
      {
        flagHasResultReference = true;
        storeResultReference = new_value;
      }
    public void unsetResultReference()
      {
        flagHasResultReference = false;
      }

    public virtual void extraSportsStandingsArgumentTeamOtherAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsArgumentTeamOtherSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsArgumentTeamOtherLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsArgumentTeamOtherAppendPair(key, new_component);
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
    public override void extraSportsStandingsArgumentAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'R':
                if ((String.Compare(key, 1, "esultReference", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONResultReference(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if (String.Compare(key, 1, "eam", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'I':
                            if ((String.Compare(key, 5, "D", 0, 1, false) == 0) && (key.Length == 6))
                                {
                                fromJSONTeamID(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 5, "eague", 0, 5, false) == 0) && (key.Length == 10))
                                {
                                fromJSONTeamLeague(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraSportsStandingsArgumentTeamOtherAppendPair(key, new_component);
      }
    public override void extraSportsStandingsArgumentSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'R':
                if ((String.Compare(key, 1, "esultReference", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONResultReference(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if (String.Compare(key, 1, "eam", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'I':
                            if ((String.Compare(key, 5, "D", 0, 1, false) == 0) && (key.Length == 6))
                                {
                                fromJSONTeamID(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 5, "eague", 0, 5, false) == 0) && (key.Length == 10))
                                {
                                fromJSONTeamLeague(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraSportsStandingsArgumentTeamOtherSetField(key, new_component);
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
        if (flagHasTeamID)
          {
            handler.start_pair("TeamID");
            handler.string_value(storeTeamID);
          }
        if (flagHasTeamLeague)
          {
            handler.start_pair("TeamLeague");
            if (partial_allowed)
                storeTeamLeague.write_partial_as_json(handler);
            else
                storeTeamLeague.write_as_json(handler);
          }
        if (flagHasResultReference)
          {
            handler.start_pair("ResultReference");
            handler.boolean_value(storeResultReference);
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

    public static new SportsStandingsArgumentTeamOtherJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentTeamOtherJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentTeamOther", ignore_extras);
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
    public static new SportsStandingsArgumentTeamOtherJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStandingsArgumentTeamOtherJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentTeamOtherJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentTeamOther", ignore_extras);
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
    public static new SportsStandingsArgumentTeamOtherJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStandingsArgumentTeamOtherJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsArgumentTeamOtherJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentTeamOther", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsArgumentTeamOtherJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsStandingsArgumentTeamOtherJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsArgumentTeamOtherJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentTeamOther", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsStandingsArgumentJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorTeamID;
        private SportsLeagueCodeJSON.HoldingGenerator fieldGeneratorTeamLeague;
        private JSONHoldingBooleanGenerator fieldGeneratorResultReference;
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
            if (!(getSportsStandingsArgumentJSONKey().Equals("TeamOther")))
                throw new Exception("The key field has a value other than `TeamOther'.");
            SportsStandingsArgumentTeamOtherJSON result = new SportsStandingsArgumentTeamOtherJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsArgumentTeamOtherAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsStandingsArgumentJSON new_result)
          {
            handle_result((SportsStandingsArgumentTeamOtherJSON )new_result);
          }
        protected void finish(SportsStandingsArgumentTeamOtherJSON result)
          {
            if (fieldGeneratorTeamID.have_value)
              {
                result.setTeamID(fieldGeneratorTeamID.value);
                fieldGeneratorTeamID.have_value = false;
              }
            if (fieldGeneratorTeamLeague.have_value)
              {
                result.setTeamLeague(fieldGeneratorTeamLeague.value);
                fieldGeneratorTeamLeague.have_value = false;
              }
            if (fieldGeneratorResultReference.have_value)
              {
                result.setResultReference(fieldGeneratorResultReference.value);
                fieldGeneratorResultReference.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsStandingsArgumentTeamOtherJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'R':
                    if ((String.Compare(field_name, 1, "esultReference", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorResultReference;
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "eam", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 5, "D", 0, 1, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorTeamID;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 5, "eague", 0, 5, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorTeamLeague;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorTeamID = new JSONHoldingStringGenerator("field \"TeamID\" of the SportsStandingsArgumentTeamOther class");
            fieldGeneratorTeamLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"TeamLeague\" of the SportsStandingsArgumentTeamOther class", ignore_extras);
            fieldGeneratorResultReference = new JSONHoldingBooleanGenerator("field \"ResultReference\" of the SportsStandingsArgumentTeamOther class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandingsArgumentTeamOther class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorTeamID = new JSONHoldingStringGenerator("field \"TeamID\" of the SportsStandingsArgumentTeamOther class");
            fieldGeneratorTeamLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"TeamLeague\" of the SportsStandingsArgumentTeamOther class", false);
            fieldGeneratorResultReference = new JSONHoldingBooleanGenerator("field \"ResultReference\" of the SportsStandingsArgumentTeamOther class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandingsArgumentTeamOther class");
          }

        public override void reset()
          {
            fieldGeneratorTeamID.reset();
            fieldGeneratorTeamLeague.reset();
            fieldGeneratorResultReference.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStandingsArgumentTeamOtherJSON  result)
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
        public SportsStandingsArgumentTeamOtherJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsArgumentTeamOtherJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsArgumentTeamOtherJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsArgumentTeamOtherJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsArgumentTeamOtherJSON>();
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
    public List<SportsStandingsArgumentTeamOtherJSON> value;
  };
  };
