/* file "RepeatedSetOfTimeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RepeatedSetOfTimeJSON : SetOfTimeJSON
  {
    private bool flagHasBase;
    private SetOfTimeJSON  storeBase;
    private bool flagHasRepetitionInterval;
    private AmountJSON  storeRepetitionInterval;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraBaseToJSON()
      {
        JSONValueHandler handler_Base = new JSONValueHandler();
        storeBase.write_as_json(handler_Base);
        return handler_Base.result;
      }

    private JSONValue  extraRepetitionIntervalToJSON()
      {
        JSONValueHandler handler_RepetitionInterval = new JSONValueHandler();
        storeRepetitionInterval.write_as_json(handler_RepetitionInterval);
        return handler_RepetitionInterval.result;
      }


    private void  fromJSONBase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SetOfTimeJSON convert_classy = SetOfTimeJSON.from_json(json_value, ignore_extras, true);
        setBase(convert_classy);
      }


    private void  fromJSONRepetitionInterval(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setRepetitionInterval(convert_classy);
      }


    public RepeatedSetOfTimeJSON()
      {
        flagHasBase = false;
        flagHasRepetitionInterval = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSetOfTimeKind()
      {
        return "Repeated";
      }

    public bool  hasBase()
      {
        return flagHasBase;
      }

    public SetOfTimeJSON   getBase()
      {
        Debug.Assert(flagHasBase);
        return storeBase;
      }

    public bool  hasRepetitionInterval()
      {
        return flagHasRepetitionInterval;
      }

    public AmountJSON   getRepetitionInterval()
      {
        Debug.Assert(flagHasRepetitionInterval);
        return storeRepetitionInterval;
      }


    public virtual int extraRepeatedSetOfTimeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRepeatedSetOfTimeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRepeatedSetOfTimeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRepeatedSetOfTimeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSetOfTimeComponentCount()
      {
        int result = 0;
        if (flagHasBase)
            ++result;
        if (flagHasRepetitionInterval)
            ++result;
        result += extraRepeatedSetOfTimeComponentCount();
        return result;
      }
    public override string extraSetOfTimeComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasBase)
          {
            if (remainder == 0)
                return "Base";
            --remainder;
          }
        if (flagHasRepetitionInterval)
          {
            if (remainder == 0)
                return "RepetitionInterval";
            --remainder;
          }
        return extraRepeatedSetOfTimeComponentKey(remainder);
      }
    public override JSONValue extraSetOfTimeComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasBase)
          {
            if (remainder == 0)
                return extraBaseToJSON();
            --remainder;
          }
        if (flagHasRepetitionInterval)
          {
            if (remainder == 0)
                return extraRepetitionIntervalToJSON();
            --remainder;
          }
        return extraRepeatedSetOfTimeComponentValue(remainder);
      }
    public override JSONValue extraSetOfTimeLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'B':
                if ((String.Compare(field_name, 1, "ase", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasBase ? extraBaseToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "epetitionInterval", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasRepetitionInterval ? extraRepetitionIntervalToJSON() : null);
                break;
            default:
                break;
          }
        return extraRepeatedSetOfTimeLookup(field_name);
      }

    public void setBase(SetOfTimeJSON  new_value)
      {
        if (flagHasBase)
          {
          }
        flagHasBase = true;
        storeBase = new_value;
      }
    public void unsetBase()
      {
        if (flagHasBase)
          {
          }
        flagHasBase = false;
      }
    public void setRepetitionInterval(AmountJSON  new_value)
      {
        if (flagHasRepetitionInterval)
          {
          }
        flagHasRepetitionInterval = true;
        storeRepetitionInterval = new_value;
      }
    public void unsetRepetitionInterval()
      {
        if (flagHasRepetitionInterval)
          {
          }
        flagHasRepetitionInterval = false;
      }

    public virtual void extraRepeatedSetOfTimeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRepeatedSetOfTimeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRepeatedSetOfTimeLookup(key);
        if (old_field == null)
          {
            extraRepeatedSetOfTimeAppendPair(key, new_component);
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
    public override void extraSetOfTimeAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "ase", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONBase(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "epetitionInterval", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONRepetitionInterval(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRepeatedSetOfTimeAppendPair(key, new_component);
      }
    public override void extraSetOfTimeSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "ase", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONBase(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "epetitionInterval", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONRepetitionInterval(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRepeatedSetOfTimeSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasBase);
        if (flagHasBase)
          {
            handler.start_pair("Base");
            if (partial_allowed)
                storeBase.write_partial_as_json(handler);
            else
                storeBase.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRepetitionInterval);
        if (flagHasRepetitionInterval)
          {
            handler.start_pair("RepetitionInterval");
            if (partial_allowed)
                storeRepetitionInterval.write_partial_as_json(handler);
            else
                storeRepetitionInterval.write_as_json(handler);
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
        if (!(hasBase()))
          {
            return "When parsing the object for %what%, the \"Base\" field was missing.";
          }
        if (!(hasRepetitionInterval()))
          {
            return "When parsing the object for %what%, the \"RepetitionInterval\" field was missing.";
          }
        return null;
      }

    public static new RepeatedSetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RepeatedSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RepeatedSetOfTime", ignore_extras);
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
    public static new RepeatedSetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RepeatedSetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RepeatedSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RepeatedSetOfTime", ignore_extras);
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
    public static new RepeatedSetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RepeatedSetOfTimeJSON from_text(string text, bool ignore_extras)
      {
        RepeatedSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RepeatedSetOfTime", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RepeatedSetOfTimeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RepeatedSetOfTimeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RepeatedSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RepeatedSetOfTime", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SetOfTimeJSON.Generator
      {
        private SetOfTimeJSON.HoldingGenerator fieldGeneratorBase;
        private AmountJSON.HoldingGenerator fieldGeneratorRepetitionInterval;
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
            if (!(getSetOfTimeJSONKey().Equals("Repeated")))
                throw new Exception("The key field has a value other than `Repeated'.");
            RepeatedSetOfTimeJSON result = new RepeatedSetOfTimeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRepeatedSetOfTimeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SetOfTimeJSON new_result)
          {
            handle_result((RepeatedSetOfTimeJSON )new_result);
          }
        protected void finish(RepeatedSetOfTimeJSON result)
          {
            if (fieldGeneratorBase.have_value)
              {
                result.setBase(fieldGeneratorBase.value);
                fieldGeneratorBase.have_value = false;
              }
            else if ((!(result.hasBase())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Base\" field was missing.");
              }
            if (fieldGeneratorRepetitionInterval.have_value)
              {
                result.setRepetitionInterval(fieldGeneratorRepetitionInterval.value);
                fieldGeneratorRepetitionInterval.have_value = false;
              }
            else if ((!(result.hasRepetitionInterval())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RepetitionInterval\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RepeatedSetOfTimeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "ase", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorBase;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "epetitionInterval", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorRepetitionInterval;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorBase = new SetOfTimeJSON.HoldingGenerator("field \"Base\" of the RepeatedSetOfTime class", ignore_extras);
            fieldGeneratorRepetitionInterval = new AmountJSON.HoldingGenerator("field \"RepetitionInterval\" of the RepeatedSetOfTime class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RepeatedSetOfTime class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorBase = new SetOfTimeJSON.HoldingGenerator("field \"Base\" of the RepeatedSetOfTime class", false);
            fieldGeneratorRepetitionInterval = new AmountJSON.HoldingGenerator("field \"RepetitionInterval\" of the RepeatedSetOfTime class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RepeatedSetOfTime class");
          }

        public override void reset()
          {
            fieldGeneratorBase.reset();
            fieldGeneratorRepetitionInterval.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RepeatedSetOfTimeJSON  result)
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
        public RepeatedSetOfTimeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RepeatedSetOfTimeJSON  result)
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
    protected virtual void handle_result(List<RepeatedSetOfTimeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RepeatedSetOfTimeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RepeatedSetOfTimeJSON>();
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
    public List<RepeatedSetOfTimeJSON> value;
  };
  };
