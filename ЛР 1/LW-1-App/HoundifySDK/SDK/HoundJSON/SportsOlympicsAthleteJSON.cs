/* file "SportsOlympicsAthleteJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsAthleteJSON : JSONBase
  {
    private bool flagHasFullName;
    private string storeFullName;
    private bool flagHasOrganization;
    private SportsOlympicsOrganizationJSON  storeOrganization;
    private bool flagHasGender;
    private SportsOlympicsAthleteGenderJSON  storeGender;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFullName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FullName of SportsOlympicsAthleteJSON is not a string.");
        setFullName(json_string.getData());
      }


    private void  fromJSONOrganization(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsOrganizationJSON convert_classy = SportsOlympicsOrganizationJSON.from_json(json_value, ignore_extras, true);
        setOrganization(convert_classy);
      }


    private void  fromJSONGender(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsAthleteGenderJSON convert_classy = SportsOlympicsAthleteGenderJSON.from_json(json_value, ignore_extras, true);
        setGender(convert_classy);
      }


    public SportsOlympicsAthleteJSON()
      {
        flagHasFullName = false;
        flagHasOrganization = false;
        flagHasGender = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFullName()
      {
        return flagHasFullName;
      }

    public string  getFullName()
      {
        Debug.Assert(flagHasFullName);
        return storeFullName;
      }

    public bool  hasOrganization()
      {
        return flagHasOrganization;
      }

    public SportsOlympicsOrganizationJSON   getOrganization()
      {
        Debug.Assert(flagHasOrganization);
        return storeOrganization;
      }

    public bool  hasGender()
      {
        return flagHasGender;
      }

    public SportsOlympicsAthleteGenderJSON   getGender()
      {
        Debug.Assert(flagHasGender);
        return storeGender;
      }

    public SportsOlympicsAthleteGenderJSON.TypeValue  getGenderValue()
      {
        return getGender().getValue();
      }

    public string  getGenderAsString()
      {
        return getGender().getValueAsString();
      }


    public virtual int extraSportsOlympicsAthleteComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsAthleteComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsAthleteComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsAthleteLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFullName(string new_value)
      {
        flagHasFullName = true;
        storeFullName = new_value;
      }
    public void unsetFullName()
      {
        flagHasFullName = false;
      }
    public void setOrganization(SportsOlympicsOrganizationJSON  new_value)
      {
        if (flagHasOrganization)
          {
          }
        flagHasOrganization = true;
        storeOrganization = new_value;
      }
    public void unsetOrganization()
      {
        if (flagHasOrganization)
          {
          }
        flagHasOrganization = false;
      }
    public void setGender(SportsOlympicsAthleteGenderJSON  new_value)
      {
        if (flagHasGender)
          {
          }
        flagHasGender = true;
        storeGender = new_value;
      }
    public void setGender(SportsOlympicsAthleteGenderJSON.TypeValue new_value)
      {
        setGender(new SportsOlympicsAthleteGenderJSON(new_value));
      }
    public void setGender(string chars)
      {
        SportsOlympicsAthleteGenderJSON.TypeValueKnownValues known = SportsOlympicsAthleteGenderJSON.stringToValue(chars);
        SportsOlympicsAthleteGenderJSON.TypeValue new_value = new SportsOlympicsAthleteGenderJSON.TypeValue();
        if (known == SportsOlympicsAthleteGenderJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setGender(new_value);
      }
    public void unsetGender()
      {
        if (flagHasGender)
          {
          }
        flagHasGender = false;
      }

    public virtual void extraSportsOlympicsAthleteAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsAthleteSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsAthleteLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsAthleteAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFullName);
        if (flagHasFullName)
          {
            handler.start_pair("FullName");
            handler.string_value(storeFullName);
          }
        Debug.Assert(partial_allowed || flagHasOrganization);
        if (flagHasOrganization)
          {
            handler.start_pair("Organization");
            if (partial_allowed)
                storeOrganization.write_partial_as_json(handler);
            else
                storeOrganization.write_as_json(handler);
          }
        if (flagHasGender)
          {
            handler.start_pair("Gender");
            if (partial_allowed)
                storeGender.write_partial_as_json(handler);
            else
                storeGender.write_as_json(handler);
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
        if (!(hasFullName()))
          {
            return "When parsing the object for %what%, the \"FullName\" field was missing.";
          }
        if (!(hasOrganization()))
          {
            return "When parsing the object for %what%, the \"Organization\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsAthleteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsAthleteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAthlete", ignore_extras);
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
    public static SportsOlympicsAthleteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsAthleteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsAthleteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAthlete", ignore_extras);
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
    public static SportsOlympicsAthleteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsAthleteJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsAthleteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAthlete", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsAthleteJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsAthleteJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsAthleteJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAthlete", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorFullName;
        private SportsOlympicsOrganizationJSON.HoldingGenerator fieldGeneratorOrganization;
        private SportsOlympicsAthleteGenderJSON.HoldingGenerator fieldGeneratorGender;
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
            SportsOlympicsAthleteJSON result = new SportsOlympicsAthleteJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsAthleteAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsAthleteJSON result)
          {
            if (fieldGeneratorFullName.have_value)
              {
                result.setFullName(fieldGeneratorFullName.value);
                fieldGeneratorFullName.have_value = false;
              }
            else if ((!(result.hasFullName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FullName\" field was missing.");
              }
            if (fieldGeneratorOrganization.have_value)
              {
                result.setOrganization(fieldGeneratorOrganization.value);
                fieldGeneratorOrganization.have_value = false;
              }
            else if ((!(result.hasOrganization())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Organization\" field was missing.");
              }
            if (fieldGeneratorGender.have_value)
              {
                result.setGender(fieldGeneratorGender.value);
                fieldGeneratorGender.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsAthleteJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "ullName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorFullName;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ender", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorGender;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "rganization", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorOrganization;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFullName = new JSONHoldingStringGenerator("field \"FullName\" of the SportsOlympicsAthlete class");
            fieldGeneratorOrganization = new SportsOlympicsOrganizationJSON.HoldingGenerator("field \"Organization\" of the SportsOlympicsAthlete class", ignore_extras);
            fieldGeneratorGender = new SportsOlympicsAthleteGenderJSON.HoldingGenerator("field \"Gender\" of the SportsOlympicsAthlete class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsAthlete class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFullName = new JSONHoldingStringGenerator("field \"FullName\" of the SportsOlympicsAthlete class");
            fieldGeneratorOrganization = new SportsOlympicsOrganizationJSON.HoldingGenerator("field \"Organization\" of the SportsOlympicsAthlete class", false);
            fieldGeneratorGender = new SportsOlympicsAthleteGenderJSON.HoldingGenerator("field \"Gender\" of the SportsOlympicsAthlete class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsAthlete class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFullName.reset();
            fieldGeneratorOrganization.reset();
            fieldGeneratorGender.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorOrganization.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGender.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorOrganization.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGender.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsAthleteJSON  result)
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
        public SportsOlympicsAthleteJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsAthleteJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsAthleteJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsAthleteJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsAthleteJSON>();
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
    public List<SportsOlympicsAthleteJSON> value;
  };
  };
