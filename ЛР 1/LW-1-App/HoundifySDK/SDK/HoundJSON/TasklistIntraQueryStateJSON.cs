/* file "TasklistIntraQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TasklistIntraQueryStateJSON : JSONBase
  {
    private bool flagHasListName;
    private string storeListName;
    private bool flagHasEntry;
    private string storeEntry;
    private bool flagHasListResult;
    private TasklistListResultJSON  storeListResult;
    private bool flagHasListEntryResult;
    private TasklistListEntryResultJSON  storeListEntryResult;
    private bool flagHasAllListsResult;
    private TasklistAllListsResultJSON  storeAllListsResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONListName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ListName of TasklistIntraQueryStateJSON is not a string.");
        setListName(json_string.getData());
      }


    private void  fromJSONEntry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Entry of TasklistIntraQueryStateJSON is not a string.");
        setEntry(json_string.getData());
      }


    private void  fromJSONListResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TasklistListResultJSON convert_classy = TasklistListResultJSON.from_json(json_value, ignore_extras, true);
        setListResult(convert_classy);
      }


    private void  fromJSONListEntryResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TasklistListEntryResultJSON convert_classy = TasklistListEntryResultJSON.from_json(json_value, ignore_extras, true);
        setListEntryResult(convert_classy);
      }


    private void  fromJSONAllListsResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TasklistAllListsResultJSON convert_classy = TasklistAllListsResultJSON.from_json(json_value, ignore_extras, true);
        setAllListsResult(convert_classy);
      }


    public TasklistIntraQueryStateJSON()
      {
        flagHasListName = false;
        flagHasEntry = false;
        flagHasListResult = false;
        flagHasListEntryResult = false;
        flagHasAllListsResult = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasListName()
      {
        return flagHasListName;
      }

    public string  getListName()
      {
        Debug.Assert(flagHasListName);
        return storeListName;
      }

    public bool  hasEntry()
      {
        return flagHasEntry;
      }

    public string  getEntry()
      {
        Debug.Assert(flagHasEntry);
        return storeEntry;
      }

    public bool  hasListResult()
      {
        return flagHasListResult;
      }

    public TasklistListResultJSON   getListResult()
      {
        Debug.Assert(flagHasListResult);
        return storeListResult;
      }

    public TasklistListResultJSON.TypeValue  getListResultValue()
      {
        return getListResult().getValue();
      }

    public string  getListResultAsString()
      {
        return getListResult().getValueAsString();
      }

    public bool  hasListEntryResult()
      {
        return flagHasListEntryResult;
      }

    public TasklistListEntryResultJSON   getListEntryResult()
      {
        Debug.Assert(flagHasListEntryResult);
        return storeListEntryResult;
      }

    public TasklistListEntryResultJSON.TypeValue  getListEntryResultValue()
      {
        return getListEntryResult().getValue();
      }

    public string  getListEntryResultAsString()
      {
        return getListEntryResult().getValueAsString();
      }

    public bool  hasAllListsResult()
      {
        return flagHasAllListsResult;
      }

    public TasklistAllListsResultJSON   getAllListsResult()
      {
        Debug.Assert(flagHasAllListsResult);
        return storeAllListsResult;
      }

    public TasklistAllListsResultJSON.TypeValue  getAllListsResultValue()
      {
        return getAllListsResult().getValue();
      }

    public string  getAllListsResultAsString()
      {
        return getAllListsResult().getValueAsString();
      }


    public virtual int extraTasklistIntraQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTasklistIntraQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTasklistIntraQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTasklistIntraQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setListName(string new_value)
      {
        flagHasListName = true;
        storeListName = new_value;
      }
    public void unsetListName()
      {
        flagHasListName = false;
      }
    public void setEntry(string new_value)
      {
        flagHasEntry = true;
        storeEntry = new_value;
      }
    public void unsetEntry()
      {
        flagHasEntry = false;
      }
    public void setListResult(TasklistListResultJSON  new_value)
      {
        if (flagHasListResult)
          {
          }
        flagHasListResult = true;
        storeListResult = new_value;
      }
    public void setListResult(TasklistListResultJSON.TypeValue new_value)
      {
        setListResult(new TasklistListResultJSON(new_value));
      }
    public void setListResult(string chars)
      {
        TasklistListResultJSON.TypeValueKnownValues known = TasklistListResultJSON.stringToValue(chars);
        TasklistListResultJSON.TypeValue new_value = new TasklistListResultJSON.TypeValue();
        if (known == TasklistListResultJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setListResult(new_value);
      }
    public void unsetListResult()
      {
        if (flagHasListResult)
          {
          }
        flagHasListResult = false;
      }
    public void setListEntryResult(TasklistListEntryResultJSON  new_value)
      {
        if (flagHasListEntryResult)
          {
          }
        flagHasListEntryResult = true;
        storeListEntryResult = new_value;
      }
    public void setListEntryResult(TasklistListEntryResultJSON.TypeValue new_value)
      {
        setListEntryResult(new TasklistListEntryResultJSON(new_value));
      }
    public void setListEntryResult(string chars)
      {
        TasklistListEntryResultJSON.TypeValueKnownValues known = TasklistListEntryResultJSON.stringToValue(chars);
        TasklistListEntryResultJSON.TypeValue new_value = new TasklistListEntryResultJSON.TypeValue();
        if (known == TasklistListEntryResultJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setListEntryResult(new_value);
      }
    public void unsetListEntryResult()
      {
        if (flagHasListEntryResult)
          {
          }
        flagHasListEntryResult = false;
      }
    public void setAllListsResult(TasklistAllListsResultJSON  new_value)
      {
        if (flagHasAllListsResult)
          {
          }
        flagHasAllListsResult = true;
        storeAllListsResult = new_value;
      }
    public void setAllListsResult(TasklistAllListsResultJSON.TypeValue new_value)
      {
        setAllListsResult(new TasklistAllListsResultJSON(new_value));
      }
    public void setAllListsResult(string chars)
      {
        TasklistAllListsResultJSON.TypeValueKnownValues known = TasklistAllListsResultJSON.stringToValue(chars);
        TasklistAllListsResultJSON.TypeValue new_value = new TasklistAllListsResultJSON.TypeValue();
        if (known == TasklistAllListsResultJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setAllListsResult(new_value);
      }
    public void unsetAllListsResult()
      {
        if (flagHasAllListsResult)
          {
          }
        flagHasAllListsResult = false;
      }

    public virtual void extraTasklistIntraQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTasklistIntraQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTasklistIntraQueryStateLookup(key);
        if (old_field == null)
          {
            extraTasklistIntraQueryStateAppendPair(key, new_component);
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
        if (flagHasListName)
          {
            handler.start_pair("ListName");
            handler.string_value(storeListName);
          }
        if (flagHasEntry)
          {
            handler.start_pair("Entry");
            handler.string_value(storeEntry);
          }
        if (flagHasListResult)
          {
            handler.start_pair("ListResult");
            if (partial_allowed)
                storeListResult.write_partial_as_json(handler);
            else
                storeListResult.write_as_json(handler);
          }
        if (flagHasListEntryResult)
          {
            handler.start_pair("ListEntryResult");
            if (partial_allowed)
                storeListEntryResult.write_partial_as_json(handler);
            else
                storeListEntryResult.write_as_json(handler);
          }
        if (flagHasAllListsResult)
          {
            handler.start_pair("AllListsResult");
            if (partial_allowed)
                storeAllListsResult.write_partial_as_json(handler);
            else
                storeAllListsResult.write_as_json(handler);
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

    public static TasklistIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TasklistIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistIntraQueryState", ignore_extras);
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
    public static TasklistIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TasklistIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TasklistIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistIntraQueryState", ignore_extras);
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
    public static TasklistIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TasklistIntraQueryStateJSON from_text(string text, bool ignore_extras)
      {
        TasklistIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TasklistIntraQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TasklistIntraQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TasklistIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorListName;
        private JSONHoldingStringGenerator fieldGeneratorEntry;
        private TasklistListResultJSON.HoldingGenerator fieldGeneratorListResult;
        private TasklistListEntryResultJSON.HoldingGenerator fieldGeneratorListEntryResult;
        private TasklistAllListsResultJSON.HoldingGenerator fieldGeneratorAllListsResult;
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
            TasklistIntraQueryStateJSON result = new TasklistIntraQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTasklistIntraQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TasklistIntraQueryStateJSON result)
          {
            if (fieldGeneratorListName.have_value)
              {
                result.setListName(fieldGeneratorListName.value);
                fieldGeneratorListName.have_value = false;
              }
            if (fieldGeneratorEntry.have_value)
              {
                result.setEntry(fieldGeneratorEntry.value);
                fieldGeneratorEntry.have_value = false;
              }
            if (fieldGeneratorListResult.have_value)
              {
                result.setListResult(fieldGeneratorListResult.value);
                fieldGeneratorListResult.have_value = false;
              }
            if (fieldGeneratorListEntryResult.have_value)
              {
                result.setListEntryResult(fieldGeneratorListEntryResult.value);
                fieldGeneratorListEntryResult.have_value = false;
              }
            if (fieldGeneratorAllListsResult.have_value)
              {
                result.setAllListsResult(fieldGeneratorAllListsResult.value);
                fieldGeneratorAllListsResult.have_value = false;
              }
          }
        protected abstract void handle_result(TasklistIntraQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "llListsResult", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorAllListsResult;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ntry", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorEntry;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "ist", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 5, "ntryResult", 0, 10, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorListEntryResult;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 5, "ame", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorListName;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 5, "esult", 0, 5, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorListResult;
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
            fieldGeneratorListName = new JSONHoldingStringGenerator("field \"ListName\" of the TasklistIntraQueryState class");
            fieldGeneratorEntry = new JSONHoldingStringGenerator("field \"Entry\" of the TasklistIntraQueryState class");
            fieldGeneratorListResult = new TasklistListResultJSON.HoldingGenerator("field \"ListResult\" of the TasklistIntraQueryState class", ignore_extras);
            fieldGeneratorListEntryResult = new TasklistListEntryResultJSON.HoldingGenerator("field \"ListEntryResult\" of the TasklistIntraQueryState class", ignore_extras);
            fieldGeneratorAllListsResult = new TasklistAllListsResultJSON.HoldingGenerator("field \"AllListsResult\" of the TasklistIntraQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TasklistIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorListName = new JSONHoldingStringGenerator("field \"ListName\" of the TasklistIntraQueryState class");
            fieldGeneratorEntry = new JSONHoldingStringGenerator("field \"Entry\" of the TasklistIntraQueryState class");
            fieldGeneratorListResult = new TasklistListResultJSON.HoldingGenerator("field \"ListResult\" of the TasklistIntraQueryState class", false);
            fieldGeneratorListEntryResult = new TasklistListEntryResultJSON.HoldingGenerator("field \"ListEntryResult\" of the TasklistIntraQueryState class", false);
            fieldGeneratorAllListsResult = new TasklistAllListsResultJSON.HoldingGenerator("field \"AllListsResult\" of the TasklistIntraQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TasklistIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorListName.reset();
            fieldGeneratorEntry.reset();
            fieldGeneratorListResult.reset();
            fieldGeneratorListEntryResult.reset();
            fieldGeneratorAllListsResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorListResult.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorListEntryResult.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAllListsResult.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorListResult.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorListEntryResult.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAllListsResult.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TasklistIntraQueryStateJSON  result)
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
        public TasklistIntraQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TasklistIntraQueryStateJSON  result)
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
    protected virtual void handle_result(List<TasklistIntraQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TasklistIntraQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TasklistIntraQueryStateJSON>();
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
    public List<TasklistIntraQueryStateJSON> value;
  };
  };
