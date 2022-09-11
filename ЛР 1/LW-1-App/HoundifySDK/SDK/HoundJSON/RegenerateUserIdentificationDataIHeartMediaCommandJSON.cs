/* file "RegenerateUserIdentificationDataIHeartMediaCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RegenerateUserIdentificationDataIHeartMediaCommandJSON : UserIdentificationDataIHeartMediaCommandJSON
  {
    private bool flagHasIHeartMediaUserIdentificationData;
    private IHeartMediaUserIdentificationDataJSON  storeIHeartMediaUserIdentificationData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraIHeartMediaUserIdentificationDataToJSON()
      {
        JSONValueHandler handler_IHeartMediaUserIdentificationData = new JSONValueHandler();
        storeIHeartMediaUserIdentificationData.write_as_json(handler_IHeartMediaUserIdentificationData);
        return handler_IHeartMediaUserIdentificationData.result;
      }


    private void  fromJSONIHeartMediaUserIdentificationData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartMediaUserIdentificationDataJSON convert_classy = IHeartMediaUserIdentificationDataJSON.from_json(json_value, ignore_extras, true);
        setIHeartMediaUserIdentificationData(convert_classy);
      }


    public RegenerateUserIdentificationDataIHeartMediaCommandJSON()
      {
        flagHasIHeartMediaUserIdentificationData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUserIdentificationDataIHeartMediaCommandKind()
      {
        return "RegenerateUserIdentificationDataIHeartMediaCommand";
      }

    public bool  hasIHeartMediaUserIdentificationData()
      {
        return flagHasIHeartMediaUserIdentificationData;
      }

    public IHeartMediaUserIdentificationDataJSON   getIHeartMediaUserIdentificationData()
      {
        Debug.Assert(flagHasIHeartMediaUserIdentificationData);
        return storeIHeartMediaUserIdentificationData;
      }


    public virtual int extraRegenerateUserIdentificationDataIHeartMediaCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRegenerateUserIdentificationDataIHeartMediaCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRegenerateUserIdentificationDataIHeartMediaCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRegenerateUserIdentificationDataIHeartMediaCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUserIdentificationDataIHeartMediaCommandComponentCount()
      {
        int result = 0;
        if (flagHasIHeartMediaUserIdentificationData)
            ++result;
        result += extraRegenerateUserIdentificationDataIHeartMediaCommandComponentCount();
        return result;
      }
    public override string extraUserIdentificationDataIHeartMediaCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasIHeartMediaUserIdentificationData)
          {
            if (remainder == 0)
                return "IHeartMediaUserIdentificationData";
            --remainder;
          }
        return extraRegenerateUserIdentificationDataIHeartMediaCommandComponentKey(remainder);
      }
    public override JSONValue extraUserIdentificationDataIHeartMediaCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasIHeartMediaUserIdentificationData)
          {
            if (remainder == 0)
                return extraIHeartMediaUserIdentificationDataToJSON();
            --remainder;
          }
        return extraRegenerateUserIdentificationDataIHeartMediaCommandComponentValue(remainder);
      }
    public override JSONValue extraUserIdentificationDataIHeartMediaCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "IHeartMediaUserIdentificationData", 0, 33, false) == 0) && (field_name.Length == 33))
            return (flagHasIHeartMediaUserIdentificationData ? extraIHeartMediaUserIdentificationDataToJSON() : null);
        return extraRegenerateUserIdentificationDataIHeartMediaCommandLookup(field_name);
      }

    public void setIHeartMediaUserIdentificationData(IHeartMediaUserIdentificationDataJSON  new_value)
      {
        if (flagHasIHeartMediaUserIdentificationData)
          {
          }
        flagHasIHeartMediaUserIdentificationData = true;
        storeIHeartMediaUserIdentificationData = new_value;
      }
    public void unsetIHeartMediaUserIdentificationData()
      {
        if (flagHasIHeartMediaUserIdentificationData)
          {
          }
        flagHasIHeartMediaUserIdentificationData = false;
      }

    public virtual void extraRegenerateUserIdentificationDataIHeartMediaCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRegenerateUserIdentificationDataIHeartMediaCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRegenerateUserIdentificationDataIHeartMediaCommandLookup(key);
        if (old_field == null)
          {
            extraRegenerateUserIdentificationDataIHeartMediaCommandAppendPair(key, new_component);
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
    public override void extraUserIdentificationDataIHeartMediaCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "IHeartMediaUserIdentificationData", 0, 33, false) == 0) && (key.Length == 33))
            {
            fromJSONIHeartMediaUserIdentificationData(new_component, false);
            return;
            }
        extraRegenerateUserIdentificationDataIHeartMediaCommandAppendPair(key, new_component);
      }
    public override void extraUserIdentificationDataIHeartMediaCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "IHeartMediaUserIdentificationData", 0, 33, false) == 0) && (key.Length == 33))
            {
            fromJSONIHeartMediaUserIdentificationData(new_component, false);
            return;
            }
        extraRegenerateUserIdentificationDataIHeartMediaCommandSetField(key, new_component);
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
        if (flagHasIHeartMediaUserIdentificationData)
          {
            handler.start_pair("IHeartMediaUserIdentificationData");
            if (partial_allowed)
                storeIHeartMediaUserIdentificationData.write_partial_as_json(handler);
            else
                storeIHeartMediaUserIdentificationData.write_as_json(handler);
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

    public static new RegenerateUserIdentificationDataIHeartMediaCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RegenerateUserIdentificationDataIHeartMediaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RegenerateUserIdentificationDataIHeartMediaCommand", ignore_extras);
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
    public static new RegenerateUserIdentificationDataIHeartMediaCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RegenerateUserIdentificationDataIHeartMediaCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RegenerateUserIdentificationDataIHeartMediaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RegenerateUserIdentificationDataIHeartMediaCommand", ignore_extras);
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
    public static new RegenerateUserIdentificationDataIHeartMediaCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RegenerateUserIdentificationDataIHeartMediaCommandJSON from_text(string text, bool ignore_extras)
      {
        RegenerateUserIdentificationDataIHeartMediaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RegenerateUserIdentificationDataIHeartMediaCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RegenerateUserIdentificationDataIHeartMediaCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RegenerateUserIdentificationDataIHeartMediaCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RegenerateUserIdentificationDataIHeartMediaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RegenerateUserIdentificationDataIHeartMediaCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UserIdentificationDataIHeartMediaCommandJSON.Generator
      {
        private IHeartMediaUserIdentificationDataJSON.HoldingGenerator fieldGeneratorIHeartMediaUserIdentificationData;
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
            if (!(getUserIdentificationDataIHeartMediaCommandJSONKey().Equals("RegenerateUserIdentificationDataIHeartMediaCommand")))
                throw new Exception("The key field has a value other than `RegenerateUserIdentificationDataIHeartMediaCommand'.");
            RegenerateUserIdentificationDataIHeartMediaCommandJSON result = new RegenerateUserIdentificationDataIHeartMediaCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRegenerateUserIdentificationDataIHeartMediaCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UserIdentificationDataIHeartMediaCommandJSON new_result)
          {
            handle_result((RegenerateUserIdentificationDataIHeartMediaCommandJSON )new_result);
          }
        protected void finish(RegenerateUserIdentificationDataIHeartMediaCommandJSON result)
          {
            if (fieldGeneratorIHeartMediaUserIdentificationData.have_value)
              {
                result.setIHeartMediaUserIdentificationData(fieldGeneratorIHeartMediaUserIdentificationData.value);
                fieldGeneratorIHeartMediaUserIdentificationData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RegenerateUserIdentificationDataIHeartMediaCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "IHeartMediaUserIdentificationData", 0, 33, false) == 0) && (field_name.Length == 33))
                return fieldGeneratorIHeartMediaUserIdentificationData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorIHeartMediaUserIdentificationData = new IHeartMediaUserIdentificationDataJSON.HoldingGenerator("field \"IHeartMediaUserIdentificationData\" of the RegenerateUserIdentificationDataIHeartMediaCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RegenerateUserIdentificationDataIHeartMediaCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorIHeartMediaUserIdentificationData = new IHeartMediaUserIdentificationDataJSON.HoldingGenerator("field \"IHeartMediaUserIdentificationData\" of the RegenerateUserIdentificationDataIHeartMediaCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RegenerateUserIdentificationDataIHeartMediaCommand class");
          }

        public override void reset()
          {
            fieldGeneratorIHeartMediaUserIdentificationData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RegenerateUserIdentificationDataIHeartMediaCommandJSON  result)
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
        public RegenerateUserIdentificationDataIHeartMediaCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RegenerateUserIdentificationDataIHeartMediaCommandJSON  result)
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
    protected virtual void handle_result(List<RegenerateUserIdentificationDataIHeartMediaCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RegenerateUserIdentificationDataIHeartMediaCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RegenerateUserIdentificationDataIHeartMediaCommandJSON>();
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
    public List<RegenerateUserIdentificationDataIHeartMediaCommandJSON> value;
  };
  };
