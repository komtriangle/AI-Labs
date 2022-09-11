/* file "SportsPlayoffSpecialGameContainerJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsPlayoffSpecialGameContainerJSON : JSONBase
  {
    private bool flagHasPlayoffsSpecialGameCode;
    private SportsPlayoffSpecialGameJSON  storePlayoffsSpecialGameCode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPlayoffsSpecialGameCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayoffSpecialGameJSON convert_classy = SportsPlayoffSpecialGameJSON.from_json(json_value, ignore_extras, true);
        setPlayoffsSpecialGameCode(convert_classy);
      }


    public SportsPlayoffSpecialGameContainerJSON()
      {
        flagHasPlayoffsSpecialGameCode = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPlayoffsSpecialGameCode()
      {
        return flagHasPlayoffsSpecialGameCode;
      }

    public SportsPlayoffSpecialGameJSON   getPlayoffsSpecialGameCode()
      {
        Debug.Assert(flagHasPlayoffsSpecialGameCode);
        return storePlayoffsSpecialGameCode;
      }

    public SportsPlayoffSpecialGameJSON.TypeValue  getPlayoffsSpecialGameCodeValue()
      {
        return getPlayoffsSpecialGameCode().getValue();
      }

    public string  getPlayoffsSpecialGameCodeAsString()
      {
        return getPlayoffsSpecialGameCode().getValueAsString();
      }


    public virtual int extraSportsPlayoffSpecialGameContainerComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayoffSpecialGameContainerComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayoffSpecialGameContainerComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayoffSpecialGameContainerLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPlayoffsSpecialGameCode(SportsPlayoffSpecialGameJSON  new_value)
      {
        if (flagHasPlayoffsSpecialGameCode)
          {
          }
        flagHasPlayoffsSpecialGameCode = true;
        storePlayoffsSpecialGameCode = new_value;
      }
    public void setPlayoffsSpecialGameCode(SportsPlayoffSpecialGameJSON.TypeValue new_value)
      {
        setPlayoffsSpecialGameCode(new SportsPlayoffSpecialGameJSON(new_value));
      }
    public void setPlayoffsSpecialGameCode(string chars)
      {
        SportsPlayoffSpecialGameJSON.TypeValueKnownValues known = SportsPlayoffSpecialGameJSON.stringToValue(chars);
        SportsPlayoffSpecialGameJSON.TypeValue new_value = new SportsPlayoffSpecialGameJSON.TypeValue();
        if (known == SportsPlayoffSpecialGameJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPlayoffsSpecialGameCode(new_value);
      }
    public void unsetPlayoffsSpecialGameCode()
      {
        if (flagHasPlayoffsSpecialGameCode)
          {
          }
        flagHasPlayoffsSpecialGameCode = false;
      }

    public virtual void extraSportsPlayoffSpecialGameContainerAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayoffSpecialGameContainerSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayoffSpecialGameContainerLookup(key);
        if (old_field == null)
          {
            extraSportsPlayoffSpecialGameContainerAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPlayoffsSpecialGameCode);
        if (flagHasPlayoffsSpecialGameCode)
          {
            handler.start_pair("PlayoffsSpecialGameCode");
            if (partial_allowed)
                storePlayoffsSpecialGameCode.write_partial_as_json(handler);
            else
                storePlayoffsSpecialGameCode.write_as_json(handler);
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
        if (!(hasPlayoffsSpecialGameCode()))
          {
            return "When parsing the object for %what%, the \"PlayoffsSpecialGameCode\" field was missing.";
          }
        return null;
      }

    public static SportsPlayoffSpecialGameContainerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffSpecialGameContainerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffSpecialGameContainer", ignore_extras);
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
    public static SportsPlayoffSpecialGameContainerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffSpecialGameContainerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffSpecialGameContainerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffSpecialGameContainer", ignore_extras);
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
    public static SportsPlayoffSpecialGameContainerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffSpecialGameContainerJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayoffSpecialGameContainerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffSpecialGameContainer", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayoffSpecialGameContainerJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayoffSpecialGameContainerJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayoffSpecialGameContainerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffSpecialGameContainer", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsPlayoffSpecialGameJSON.HoldingGenerator fieldGeneratorPlayoffsSpecialGameCode;
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
            SportsPlayoffSpecialGameContainerJSON result = new SportsPlayoffSpecialGameContainerJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayoffSpecialGameContainerAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsPlayoffSpecialGameContainerJSON result)
          {
            if (fieldGeneratorPlayoffsSpecialGameCode.have_value)
              {
                result.setPlayoffsSpecialGameCode(fieldGeneratorPlayoffsSpecialGameCode.value);
                fieldGeneratorPlayoffsSpecialGameCode.have_value = false;
              }
            else if ((!(result.hasPlayoffsSpecialGameCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PlayoffsSpecialGameCode\" field was missing.");
              }
          }
        protected abstract void handle_result(SportsPlayoffSpecialGameContainerJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "PlayoffsSpecialGameCode", 0, 23, false) == 0) && (field_name.Length == 23))
                return fieldGeneratorPlayoffsSpecialGameCode;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPlayoffsSpecialGameCode = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"PlayoffsSpecialGameCode\" of the SportsPlayoffSpecialGameContainer class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayoffSpecialGameContainer class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPlayoffsSpecialGameCode = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"PlayoffsSpecialGameCode\" of the SportsPlayoffSpecialGameContainer class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayoffSpecialGameContainer class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPlayoffsSpecialGameCode.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPlayoffsSpecialGameCode.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPlayoffsSpecialGameCode.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsPlayoffSpecialGameContainerJSON  result)
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
        public SportsPlayoffSpecialGameContainerJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayoffSpecialGameContainerJSON  result)
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
    protected virtual void handle_result(List<SportsPlayoffSpecialGameContainerJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayoffSpecialGameContainerJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayoffSpecialGameContainerJSON>();
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
    public List<SportsPlayoffSpecialGameContainerJSON> value;
  };
  };
