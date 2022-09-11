/* file "HomeAutomationActionResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationActionResultJSON : JSONBase
  {
    private bool flagHasResult;
    private HomeAutomationActionResultTypeJSON  storeResult;
    private bool flagHasServerActionSucceeded;
    private HomeAutomationActionResponseListJSON  storeServerActionSucceeded;
    private bool flagHasServerActionFailed;
    private HomeAutomationActionResponseListJSON  storeServerActionFailed;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationActionResultTypeJSON convert_classy = HomeAutomationActionResultTypeJSON.from_json(json_value, ignore_extras, true);
        setResult(convert_classy);
      }


    private void  fromJSONServerActionSucceeded(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationActionResponseListJSON convert_classy = HomeAutomationActionResponseListJSON.from_json(json_value, ignore_extras, true);
        setServerActionSucceeded(convert_classy);
      }


    private void  fromJSONServerActionFailed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationActionResponseListJSON convert_classy = HomeAutomationActionResponseListJSON.from_json(json_value, ignore_extras, true);
        setServerActionFailed(convert_classy);
      }


    public HomeAutomationActionResultJSON()
      {
        flagHasResult = false;
        flagHasServerActionSucceeded = false;
        flagHasServerActionFailed = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasResult()
      {
        return flagHasResult;
      }

    public HomeAutomationActionResultTypeJSON   getResult()
      {
        Debug.Assert(flagHasResult);
        return storeResult;
      }

    public HomeAutomationActionResultTypeJSON.TypeValue  getResultValue()
      {
        return getResult().getValue();
      }

    public string  getResultAsString()
      {
        return getResult().getValueAsString();
      }

    public bool  hasServerActionSucceeded()
      {
        return flagHasServerActionSucceeded;
      }

    public HomeAutomationActionResponseListJSON   getServerActionSucceeded()
      {
        Debug.Assert(flagHasServerActionSucceeded);
        return storeServerActionSucceeded;
      }

    public bool  hasServerActionFailed()
      {
        return flagHasServerActionFailed;
      }

    public HomeAutomationActionResponseListJSON   getServerActionFailed()
      {
        Debug.Assert(flagHasServerActionFailed);
        return storeServerActionFailed;
      }


    public virtual int extraHomeAutomationActionResultComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationActionResultComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationActionResultComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationActionResultLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setResult(HomeAutomationActionResultTypeJSON  new_value)
      {
        if (flagHasResult)
          {
          }
        flagHasResult = true;
        storeResult = new_value;
      }
    public void setResult(HomeAutomationActionResultTypeJSON.TypeValue new_value)
      {
        setResult(new HomeAutomationActionResultTypeJSON(new_value));
      }
    public void setResult(string chars)
      {
        HomeAutomationActionResultTypeJSON.TypeValueKnownValues known = HomeAutomationActionResultTypeJSON.stringToValue(chars);
        HomeAutomationActionResultTypeJSON.TypeValue new_value = new HomeAutomationActionResultTypeJSON.TypeValue();
        if (known == HomeAutomationActionResultTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setResult(new_value);
      }
    public void unsetResult()
      {
        if (flagHasResult)
          {
          }
        flagHasResult = false;
      }
    public void setServerActionSucceeded(HomeAutomationActionResponseListJSON  new_value)
      {
        if (flagHasServerActionSucceeded)
          {
          }
        flagHasServerActionSucceeded = true;
        storeServerActionSucceeded = new_value;
      }
    public void unsetServerActionSucceeded()
      {
        if (flagHasServerActionSucceeded)
          {
          }
        flagHasServerActionSucceeded = false;
      }
    public void setServerActionFailed(HomeAutomationActionResponseListJSON  new_value)
      {
        if (flagHasServerActionFailed)
          {
          }
        flagHasServerActionFailed = true;
        storeServerActionFailed = new_value;
      }
    public void unsetServerActionFailed()
      {
        if (flagHasServerActionFailed)
          {
          }
        flagHasServerActionFailed = false;
      }

    public virtual void extraHomeAutomationActionResultAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationActionResultSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationActionResultLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationActionResultAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasResult);
        if (flagHasResult)
          {
            handler.start_pair("Result");
            if (partial_allowed)
                storeResult.write_partial_as_json(handler);
            else
                storeResult.write_as_json(handler);
          }
        if (flagHasServerActionSucceeded)
          {
            handler.start_pair("ServerActionSucceeded");
            if (partial_allowed)
                storeServerActionSucceeded.write_partial_as_json(handler);
            else
                storeServerActionSucceeded.write_as_json(handler);
          }
        if (flagHasServerActionFailed)
          {
            handler.start_pair("ServerActionFailed");
            if (partial_allowed)
                storeServerActionFailed.write_partial_as_json(handler);
            else
                storeServerActionFailed.write_as_json(handler);
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
        if (!(hasResult()))
          {
            return "When parsing the object for %what%, the \"Result\" field was missing.";
          }
        return null;
      }

    public static HomeAutomationActionResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationActionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResult", ignore_extras);
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
    public static HomeAutomationActionResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationActionResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationActionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResult", ignore_extras);
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
    public static HomeAutomationActionResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationActionResultJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationActionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationActionResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationActionResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationActionResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private HomeAutomationActionResultTypeJSON.HoldingGenerator fieldGeneratorResult;
        private HomeAutomationActionResponseListJSON.HoldingGenerator fieldGeneratorServerActionSucceeded;
        private HomeAutomationActionResponseListJSON.HoldingGenerator fieldGeneratorServerActionFailed;
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
            HomeAutomationActionResultJSON result = new HomeAutomationActionResultJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationActionResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationActionResultJSON result)
          {
            if (fieldGeneratorResult.have_value)
              {
                result.setResult(fieldGeneratorResult.value);
                fieldGeneratorResult.have_value = false;
              }
            else if ((!(result.hasResult())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Result\" field was missing.");
              }
            if (fieldGeneratorServerActionSucceeded.have_value)
              {
                result.setServerActionSucceeded(fieldGeneratorServerActionSucceeded.value);
                fieldGeneratorServerActionSucceeded.have_value = false;
              }
            if (fieldGeneratorServerActionFailed.have_value)
              {
                result.setServerActionFailed(fieldGeneratorServerActionFailed.value);
                fieldGeneratorServerActionFailed.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationActionResultJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'R':
                    if ((String.Compare(field_name, 1, "esult", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorResult;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "erverAction", 0, 11, false) == 0)
                      {
                        switch (field_name[12])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 13, "ailed", 0, 5, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorServerActionFailed;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 13, "ucceeded", 0, 8, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorServerActionSucceeded;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorResult = new HomeAutomationActionResultTypeJSON.HoldingGenerator("field \"Result\" of the HomeAutomationActionResult class", ignore_extras);
            fieldGeneratorServerActionSucceeded = new HomeAutomationActionResponseListJSON.HoldingGenerator("field \"ServerActionSucceeded\" of the HomeAutomationActionResult class", ignore_extras);
            fieldGeneratorServerActionFailed = new HomeAutomationActionResponseListJSON.HoldingGenerator("field \"ServerActionFailed\" of the HomeAutomationActionResult class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationActionResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorResult = new HomeAutomationActionResultTypeJSON.HoldingGenerator("field \"Result\" of the HomeAutomationActionResult class", false);
            fieldGeneratorServerActionSucceeded = new HomeAutomationActionResponseListJSON.HoldingGenerator("field \"ServerActionSucceeded\" of the HomeAutomationActionResult class", false);
            fieldGeneratorServerActionFailed = new HomeAutomationActionResponseListJSON.HoldingGenerator("field \"ServerActionFailed\" of the HomeAutomationActionResult class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationActionResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorResult.reset();
            fieldGeneratorServerActionSucceeded.reset();
            fieldGeneratorServerActionFailed.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorResult.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorServerActionSucceeded.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorServerActionFailed.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorResult.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorServerActionSucceeded.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorServerActionFailed.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationActionResultJSON  result)
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
        public HomeAutomationActionResultJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationActionResultJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationActionResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationActionResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationActionResultJSON>();
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
    public List<HomeAutomationActionResultJSON> value;
  };
  };
