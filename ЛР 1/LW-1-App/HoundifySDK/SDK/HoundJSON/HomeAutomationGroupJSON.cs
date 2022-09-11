/* file "HomeAutomationGroupJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationGroupJSON : JSONBase
  {
    private bool flagHasHomeAutomationSolution;
    private HomeAutomationSolutionJSON  storeHomeAutomationSolution;
    private bool flagHasName;
    private string storeName;
    private bool flagHasID;
    private string storeID;
    private bool flagHasSolutionData;
    private JSONValue  storeSolutionData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONHomeAutomationSolution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationSolutionJSON convert_classy = HomeAutomationSolutionJSON.from_json(json_value, ignore_extras, true);
        setHomeAutomationSolution(convert_classy);
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of HomeAutomationGroupJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ID of HomeAutomationGroupJSON is not a string.");
        setID(json_string.getData());
      }


    private void  fromJSONSolutionData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        setSolutionData(json_value);
      }


    public HomeAutomationGroupJSON()
      {
        flagHasHomeAutomationSolution = false;
        flagHasName = false;
        flagHasID = false;
        flagHasSolutionData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasHomeAutomationSolution()
      {
        return flagHasHomeAutomationSolution;
      }

    public HomeAutomationSolutionJSON   getHomeAutomationSolution()
      {
        Debug.Assert(flagHasHomeAutomationSolution);
        return storeHomeAutomationSolution;
      }

    public HomeAutomationSolutionJSON.TypeValue  getHomeAutomationSolutionValue()
      {
        return getHomeAutomationSolution().getValue();
      }

    public string  getHomeAutomationSolutionAsString()
      {
        return getHomeAutomationSolution().getValueAsString();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasID()
      {
        return flagHasID;
      }

    public string  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }

    public bool  hasSolutionData()
      {
        return flagHasSolutionData;
      }

    public JSONValue   getSolutionData()
      {
        Debug.Assert(flagHasSolutionData);
        return storeSolutionData;
      }


    public virtual int extraHomeAutomationGroupComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationGroupComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationGroupComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationGroupLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setHomeAutomationSolution(HomeAutomationSolutionJSON  new_value)
      {
        if (flagHasHomeAutomationSolution)
          {
          }
        flagHasHomeAutomationSolution = true;
        storeHomeAutomationSolution = new_value;
      }
    public void setHomeAutomationSolution(HomeAutomationSolutionJSON.TypeValue new_value)
      {
        setHomeAutomationSolution(new HomeAutomationSolutionJSON(new_value));
      }
    public void setHomeAutomationSolution(string chars)
      {
        HomeAutomationSolutionJSON.TypeValueKnownValues known = HomeAutomationSolutionJSON.stringToValue(chars);
        HomeAutomationSolutionJSON.TypeValue new_value = new HomeAutomationSolutionJSON.TypeValue();
        if (known == HomeAutomationSolutionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setHomeAutomationSolution(new_value);
      }
    public void unsetHomeAutomationSolution()
      {
        if (flagHasHomeAutomationSolution)
          {
          }
        flagHasHomeAutomationSolution = false;
      }
    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setID(string new_value)
      {
        flagHasID = true;
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void setSolutionData(JSONValue  new_value)
      {
        if (flagHasSolutionData)
          {
          }
        flagHasSolutionData = true;
        storeSolutionData = new_value;
      }
    public void unsetSolutionData()
      {
        if (flagHasSolutionData)
          {
          }
        flagHasSolutionData = false;
      }

    public virtual void extraHomeAutomationGroupAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationGroupSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationGroupLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationGroupAppendPair(key, new_component);
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
        if (flagHasHomeAutomationSolution)
          {
            handler.start_pair("HomeAutomationSolution");
            if (partial_allowed)
                storeHomeAutomationSolution.write_partial_as_json(handler);
            else
                storeHomeAutomationSolution.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        Debug.Assert(partial_allowed || flagHasID);
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.string_value(storeID);
          }
        if (flagHasSolutionData)
          {
            handler.start_pair("SolutionData");
            storeSolutionData.write(handler);
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        if (!(hasID()))
          {
            return "When parsing the object for %what%, the \"ID\" field was missing.";
          }
        return null;
      }

    public static HomeAutomationGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationGroup", ignore_extras);
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
    public static HomeAutomationGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationGroup", ignore_extras);
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
    public static HomeAutomationGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationGroupJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationGroup", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationGroupJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationGroupJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationGroup", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private HomeAutomationSolutionJSON.HoldingGenerator fieldGeneratorHomeAutomationSolution;
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorID;
        private JSONHoldingValueGenerator fieldGeneratorSolutionData;
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
            HomeAutomationGroupJSON result = new HomeAutomationGroupJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationGroupAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationGroupJSON result)
          {
            if (fieldGeneratorHomeAutomationSolution.have_value)
              {
                result.setHomeAutomationSolution(fieldGeneratorHomeAutomationSolution.value);
                fieldGeneratorHomeAutomationSolution.have_value = false;
              }
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            else if ((!(result.hasID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ID\" field was missing.");
              }
            if (fieldGeneratorSolutionData.have_value)
              {
                result.setSolutionData(fieldGeneratorSolutionData.value);
                fieldGeneratorSolutionData.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationGroupJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'H':
                    if ((String.Compare(field_name, 1, "omeAutomationSolution", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorHomeAutomationSolution;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorID;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "olutionData", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorSolutionData;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorHomeAutomationSolution = new HomeAutomationSolutionJSON.HoldingGenerator("field \"HomeAutomationSolution\" of the HomeAutomationGroup class", ignore_extras);
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HomeAutomationGroup class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the HomeAutomationGroup class");
            fieldGeneratorSolutionData = new JSONHoldingValueGenerator("field \"SolutionData\" of the HomeAutomationGroup class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationGroup class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHomeAutomationSolution = new HomeAutomationSolutionJSON.HoldingGenerator("field \"HomeAutomationSolution\" of the HomeAutomationGroup class", false);
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HomeAutomationGroup class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the HomeAutomationGroup class");
            fieldGeneratorSolutionData = new JSONHoldingValueGenerator("field \"SolutionData\" of the HomeAutomationGroup class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationGroup class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHomeAutomationSolution.reset();
            fieldGeneratorName.reset();
            fieldGeneratorID.reset();
            fieldGeneratorSolutionData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorHomeAutomationSolution.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorHomeAutomationSolution.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationGroupJSON  result)
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
        public HomeAutomationGroupJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationGroupJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationGroupJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationGroupJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationGroupJSON>();
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
    public List<HomeAutomationGroupJSON> value;
  };
  };
