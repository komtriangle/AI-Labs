/* file "PreviousPresetOrChannelCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PreviousPresetOrChannelCommandJSON : RadioCommandJSON
  {
    private bool flagHasPresetResult;
    private DynamicResponseJSON  storePresetResult;
    private bool flagHasChannelResult;
    private DynamicResponseJSON  storeChannelResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPresetResultToJSON()
      {
        JSONValueHandler handler_PresetResult = new JSONValueHandler();
        storePresetResult.write_as_json(handler_PresetResult);
        return handler_PresetResult.result;
      }

    private JSONValue  extraChannelResultToJSON()
      {
        JSONValueHandler handler_ChannelResult = new JSONValueHandler();
        storeChannelResult.write_as_json(handler_ChannelResult);
        return handler_ChannelResult.result;
      }


    private void  fromJSONPresetResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setPresetResult(convert_classy);
      }


    private void  fromJSONChannelResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setChannelResult(convert_classy);
      }


    public PreviousPresetOrChannelCommandJSON()
      {
        flagHasPresetResult = false;
        flagHasChannelResult = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRadioCommandKind()
      {
        return "PreviousPresetOrChannel";
      }

    public bool  hasPresetResult()
      {
        return flagHasPresetResult;
      }

    public DynamicResponseJSON   getPresetResult()
      {
        Debug.Assert(flagHasPresetResult);
        return storePresetResult;
      }

    public bool  hasChannelResult()
      {
        return flagHasChannelResult;
      }

    public DynamicResponseJSON   getChannelResult()
      {
        Debug.Assert(flagHasChannelResult);
        return storeChannelResult;
      }


    public virtual int extraPreviousPresetOrChannelCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPreviousPresetOrChannelCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPreviousPresetOrChannelCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPreviousPresetOrChannelCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRadioCommandComponentCount()
      {
        int result = 0;
        if (flagHasPresetResult)
            ++result;
        if (flagHasChannelResult)
            ++result;
        result += extraPreviousPresetOrChannelCommandComponentCount();
        return result;
      }
    public override string extraRadioCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPresetResult)
          {
            if (remainder == 0)
                return "PresetResult";
            --remainder;
          }
        if (flagHasChannelResult)
          {
            if (remainder == 0)
                return "ChannelResult";
            --remainder;
          }
        return extraPreviousPresetOrChannelCommandComponentKey(remainder);
      }
    public override JSONValue extraRadioCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPresetResult)
          {
            if (remainder == 0)
                return extraPresetResultToJSON();
            --remainder;
          }
        if (flagHasChannelResult)
          {
            if (remainder == 0)
                return extraChannelResultToJSON();
            --remainder;
          }
        return extraPreviousPresetOrChannelCommandComponentValue(remainder);
      }
    public override JSONValue extraRadioCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "hannelResult", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasChannelResult ? extraChannelResultToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "resetResult", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasPresetResult ? extraPresetResultToJSON() : null);
                break;
            default:
                break;
          }
        return extraPreviousPresetOrChannelCommandLookup(field_name);
      }

    public void setPresetResult(DynamicResponseJSON  new_value)
      {
        if (flagHasPresetResult)
          {
          }
        flagHasPresetResult = true;
        storePresetResult = new_value;
      }
    public void unsetPresetResult()
      {
        if (flagHasPresetResult)
          {
          }
        flagHasPresetResult = false;
      }
    public void setChannelResult(DynamicResponseJSON  new_value)
      {
        if (flagHasChannelResult)
          {
          }
        flagHasChannelResult = true;
        storeChannelResult = new_value;
      }
    public void unsetChannelResult()
      {
        if (flagHasChannelResult)
          {
          }
        flagHasChannelResult = false;
      }

    public virtual void extraPreviousPresetOrChannelCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPreviousPresetOrChannelCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPreviousPresetOrChannelCommandLookup(key);
        if (old_field == null)
          {
            extraPreviousPresetOrChannelCommandAppendPair(key, new_component);
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
    public override void extraRadioCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hannelResult", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONChannelResult(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "resetResult", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONPresetResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraPreviousPresetOrChannelCommandAppendPair(key, new_component);
      }
    public override void extraRadioCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hannelResult", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONChannelResult(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "resetResult", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONPresetResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraPreviousPresetOrChannelCommandSetField(key, new_component);
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
        if (flagHasPresetResult)
          {
            handler.start_pair("PresetResult");
            if (partial_allowed)
                storePresetResult.write_partial_as_json(handler);
            else
                storePresetResult.write_as_json(handler);
          }
        if (flagHasChannelResult)
          {
            handler.start_pair("ChannelResult");
            if (partial_allowed)
                storeChannelResult.write_partial_as_json(handler);
            else
                storeChannelResult.write_as_json(handler);
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

    public static new PreviousPresetOrChannelCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PreviousPresetOrChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PreviousPresetOrChannelCommand", ignore_extras);
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
    public static new PreviousPresetOrChannelCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PreviousPresetOrChannelCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PreviousPresetOrChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PreviousPresetOrChannelCommand", ignore_extras);
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
    public static new PreviousPresetOrChannelCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PreviousPresetOrChannelCommandJSON from_text(string text, bool ignore_extras)
      {
        PreviousPresetOrChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PreviousPresetOrChannelCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PreviousPresetOrChannelCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PreviousPresetOrChannelCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PreviousPresetOrChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PreviousPresetOrChannelCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RadioCommandJSON.Generator
      {
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorPresetResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorChannelResult;
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
            if (!(getRadioCommandJSONKey().Equals("PreviousPresetOrChannel")))
                throw new Exception("The key field has a value other than `PreviousPresetOrChannel'.");
            PreviousPresetOrChannelCommandJSON result = new PreviousPresetOrChannelCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPreviousPresetOrChannelCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RadioCommandJSON new_result)
          {
            handle_result((PreviousPresetOrChannelCommandJSON )new_result);
          }
        protected void finish(PreviousPresetOrChannelCommandJSON result)
          {
            if (fieldGeneratorPresetResult.have_value)
              {
                result.setPresetResult(fieldGeneratorPresetResult.value);
                fieldGeneratorPresetResult.have_value = false;
              }
            if (fieldGeneratorChannelResult.have_value)
              {
                result.setChannelResult(fieldGeneratorChannelResult.value);
                fieldGeneratorChannelResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(PreviousPresetOrChannelCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hannelResult", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorChannelResult;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "resetResult", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorPresetResult;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPresetResult = new DynamicResponseJSON.HoldingGenerator("field \"PresetResult\" of the PreviousPresetOrChannelCommand class", ignore_extras);
            fieldGeneratorChannelResult = new DynamicResponseJSON.HoldingGenerator("field \"ChannelResult\" of the PreviousPresetOrChannelCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PreviousPresetOrChannelCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPresetResult = new DynamicResponseJSON.HoldingGenerator("field \"PresetResult\" of the PreviousPresetOrChannelCommand class", false);
            fieldGeneratorChannelResult = new DynamicResponseJSON.HoldingGenerator("field \"ChannelResult\" of the PreviousPresetOrChannelCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PreviousPresetOrChannelCommand class");
          }

        public override void reset()
          {
            fieldGeneratorPresetResult.reset();
            fieldGeneratorChannelResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PreviousPresetOrChannelCommandJSON  result)
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
        public PreviousPresetOrChannelCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PreviousPresetOrChannelCommandJSON  result)
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
    protected virtual void handle_result(List<PreviousPresetOrChannelCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PreviousPresetOrChannelCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PreviousPresetOrChannelCommandJSON>();
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
    public List<PreviousPresetOrChannelCommandJSON> value;
  };
  };
