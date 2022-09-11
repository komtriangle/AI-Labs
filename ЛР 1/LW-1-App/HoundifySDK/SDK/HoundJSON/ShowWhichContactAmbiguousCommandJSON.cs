/* file "ShowWhichContactAmbiguousCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ShowWhichContactAmbiguousCommandJSON : DisambiguateCommandJSON
  {
    private bool flagHasChoices;
    private WhichContactChoicesJSON  storeChoices;
    private bool flagHasUserSpecifiedName;
    private string storeUserSpecifiedName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraChoicesToJSON()
      {
        JSONValueHandler handler_Choices = new JSONValueHandler();
        storeChoices.write_as_json(handler_Choices);
        return handler_Choices.result;
      }

    private JSONValue  extraUserSpecifiedNameToJSON()
      {
        JSONStringValue generated_string_UserSpecifiedName = new JSONStringValue(storeUserSpecifiedName);
        return generated_string_UserSpecifiedName;
      }


    private void  fromJSONChoices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WhichContactChoicesJSON convert_classy = WhichContactChoicesJSON.from_json(json_value, ignore_extras, true);
        setChoices(convert_classy);
      }


    private void  fromJSONUserSpecifiedName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserSpecifiedName of ShowWhichContactAmbiguousCommandJSON is not a string.");
        setUserSpecifiedName(json_string.getData());
      }


    public ShowWhichContactAmbiguousCommandJSON()
      {
        flagHasChoices = false;
        flagHasUserSpecifiedName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDisambiguateCommandKind()
      {
        return "ShowWhichContactAmbiguous";
      }

    public bool  hasChoices()
      {
        return flagHasChoices;
      }

    public WhichContactChoicesJSON   getChoices()
      {
        Debug.Assert(flagHasChoices);
        return storeChoices;
      }

    public bool  hasUserSpecifiedName()
      {
        return flagHasUserSpecifiedName;
      }

    public string  getUserSpecifiedName()
      {
        Debug.Assert(flagHasUserSpecifiedName);
        return storeUserSpecifiedName;
      }


    public virtual int extraShowWhichContactAmbiguousCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraShowWhichContactAmbiguousCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraShowWhichContactAmbiguousCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraShowWhichContactAmbiguousCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDisambiguateCommandComponentCount()
      {
        int result = 0;
        if (flagHasChoices)
            ++result;
        if (flagHasUserSpecifiedName)
            ++result;
        result += extraShowWhichContactAmbiguousCommandComponentCount();
        return result;
      }
    public override string extraDisambiguateCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasChoices)
          {
            if (remainder == 0)
                return "Choices";
            --remainder;
          }
        if (flagHasUserSpecifiedName)
          {
            if (remainder == 0)
                return "UserSpecifiedName";
            --remainder;
          }
        return extraShowWhichContactAmbiguousCommandComponentKey(remainder);
      }
    public override JSONValue extraDisambiguateCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasChoices)
          {
            if (remainder == 0)
                return extraChoicesToJSON();
            --remainder;
          }
        if (flagHasUserSpecifiedName)
          {
            if (remainder == 0)
                return extraUserSpecifiedNameToJSON();
            --remainder;
          }
        return extraShowWhichContactAmbiguousCommandComponentValue(remainder);
      }
    public override JSONValue extraDisambiguateCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "hoices", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasChoices ? extraChoicesToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serSpecifiedName", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasUserSpecifiedName ? extraUserSpecifiedNameToJSON() : null);
                break;
            default:
                break;
          }
        return extraShowWhichContactAmbiguousCommandLookup(field_name);
      }

    public void setChoices(WhichContactChoicesJSON  new_value)
      {
        if (flagHasChoices)
          {
          }
        flagHasChoices = true;
        storeChoices = new_value;
      }
    public void unsetChoices()
      {
        if (flagHasChoices)
          {
          }
        flagHasChoices = false;
      }
    public void setUserSpecifiedName(string new_value)
      {
        flagHasUserSpecifiedName = true;
        storeUserSpecifiedName = new_value;
      }
    public void unsetUserSpecifiedName()
      {
        flagHasUserSpecifiedName = false;
      }

    public virtual void extraShowWhichContactAmbiguousCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraShowWhichContactAmbiguousCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraShowWhichContactAmbiguousCommandLookup(key);
        if (old_field == null)
          {
            extraShowWhichContactAmbiguousCommandAppendPair(key, new_component);
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
    public override void extraDisambiguateCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hoices", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONChoices(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serSpecifiedName", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONUserSpecifiedName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraShowWhichContactAmbiguousCommandAppendPair(key, new_component);
      }
    public override void extraDisambiguateCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hoices", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONChoices(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serSpecifiedName", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONUserSpecifiedName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraShowWhichContactAmbiguousCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasChoices);
        if (flagHasChoices)
          {
            handler.start_pair("Choices");
            if (partial_allowed)
                storeChoices.write_partial_as_json(handler);
            else
                storeChoices.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasUserSpecifiedName);
        if (flagHasUserSpecifiedName)
          {
            handler.start_pair("UserSpecifiedName");
            handler.string_value(storeUserSpecifiedName);
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
        if (!(hasChoices()))
          {
            return "When parsing the object for %what%, the \"Choices\" field was missing.";
          }
        if (!(hasUserSpecifiedName()))
          {
            return "When parsing the object for %what%, the \"UserSpecifiedName\" field was missing.";
          }
        return null;
      }

    public static new ShowWhichContactAmbiguousCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWhichContactAmbiguousCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWhichContactAmbiguousCommand", ignore_extras);
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
    public static new ShowWhichContactAmbiguousCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWhichContactAmbiguousCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWhichContactAmbiguousCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWhichContactAmbiguousCommand", ignore_extras);
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
    public static new ShowWhichContactAmbiguousCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWhichContactAmbiguousCommandJSON from_text(string text, bool ignore_extras)
      {
        ShowWhichContactAmbiguousCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWhichContactAmbiguousCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ShowWhichContactAmbiguousCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ShowWhichContactAmbiguousCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ShowWhichContactAmbiguousCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWhichContactAmbiguousCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DisambiguateCommandJSON.Generator
      {
        private WhichContactChoicesJSON.HoldingGenerator fieldGeneratorChoices;
        private JSONHoldingStringGenerator fieldGeneratorUserSpecifiedName;
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
            if (!(getDisambiguateCommandJSONKey().Equals("ShowWhichContactAmbiguous")))
                throw new Exception("The key field has a value other than `ShowWhichContactAmbiguous'.");
            ShowWhichContactAmbiguousCommandJSON result = new ShowWhichContactAmbiguousCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraShowWhichContactAmbiguousCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DisambiguateCommandJSON new_result)
          {
            handle_result((ShowWhichContactAmbiguousCommandJSON )new_result);
          }
        protected void finish(ShowWhichContactAmbiguousCommandJSON result)
          {
            if (fieldGeneratorChoices.have_value)
              {
                result.setChoices(fieldGeneratorChoices.value);
                fieldGeneratorChoices.have_value = false;
              }
            else if ((!(result.hasChoices())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Choices\" field was missing.");
              }
            if (fieldGeneratorUserSpecifiedName.have_value)
              {
                result.setUserSpecifiedName(fieldGeneratorUserSpecifiedName.value);
                fieldGeneratorUserSpecifiedName.have_value = false;
              }
            else if ((!(result.hasUserSpecifiedName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UserSpecifiedName\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ShowWhichContactAmbiguousCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hoices", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorChoices;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serSpecifiedName", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorUserSpecifiedName;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorChoices = new WhichContactChoicesJSON.HoldingGenerator("field \"Choices\" of the ShowWhichContactAmbiguousCommand class", ignore_extras);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the ShowWhichContactAmbiguousCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ShowWhichContactAmbiguousCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorChoices = new WhichContactChoicesJSON.HoldingGenerator("field \"Choices\" of the ShowWhichContactAmbiguousCommand class", false);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the ShowWhichContactAmbiguousCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ShowWhichContactAmbiguousCommand class");
          }

        public override void reset()
          {
            fieldGeneratorChoices.reset();
            fieldGeneratorUserSpecifiedName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ShowWhichContactAmbiguousCommandJSON  result)
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
        public ShowWhichContactAmbiguousCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ShowWhichContactAmbiguousCommandJSON  result)
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
    protected virtual void handle_result(List<ShowWhichContactAmbiguousCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ShowWhichContactAmbiguousCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ShowWhichContactAmbiguousCommandJSON>();
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
    public List<ShowWhichContactAmbiguousCommandJSON> value;
  };
  };
