/* file "SiriusChannelCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SiriusChannelCommandJSON : RadioCommandJSON
  {
    private bool flagHasChannel;
    private byte storeChannel;
    private bool flagHasExtendedChannel;
    private ushort storeExtendedChannel;
    private bool flagHasAlreadyOnResult;
    private DynamicResponseJSON  storeAlreadyOnResult;
    private bool flagHasTuningTarget;
    private TuningTargetJSON  storeTuningTarget;
    private bool flagHasSuggestions;
    private SuggestedStationsJSON  storeSuggestions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraChannelToJSON()
      {
        JSONIntegerValue generated_integer_Channel = new JSONIntegerValue(storeChannel);
        return generated_integer_Channel;
      }

    private JSONValue  extraExtendedChannelToJSON()
      {
        JSONIntegerValue generated_integer_ExtendedChannel = new JSONIntegerValue(storeExtendedChannel);
        return generated_integer_ExtendedChannel;
      }

    private JSONValue  extraAlreadyOnResultToJSON()
      {
        JSONValueHandler handler_AlreadyOnResult = new JSONValueHandler();
        storeAlreadyOnResult.write_as_json(handler_AlreadyOnResult);
        return handler_AlreadyOnResult.result;
      }

    private JSONValue  extraTuningTargetToJSON()
      {
        JSONValueHandler handler_TuningTarget = new JSONValueHandler();
        storeTuningTarget.write_as_json(handler_TuningTarget);
        return handler_TuningTarget.result;
      }

    private JSONValue  extraSuggestionsToJSON()
      {
        JSONValueHandler handler_Suggestions = new JSONValueHandler();
        storeSuggestions.write_as_json(handler_Suggestions);
        return handler_Suggestions.result;
      }


    private void  fromJSONChannel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Channel of SiriusChannelCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Channel of SiriusChannelCommandJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setChannel(extracted_integer);
      }


    private void  fromJSONExtendedChannel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ushort extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ExtendedChannel of SiriusChannelCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ExtendedChannel of SiriusChannelCommandJSON is not an integer.");
              }
            extracted_integer = (ushort)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (ushort)(json_integer.getLongInt())        ;
          }
        setExtendedChannel(extracted_integer);
      }


    private void  fromJSONAlreadyOnResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAlreadyOnResult(convert_classy);
      }


    private void  fromJSONTuningTarget(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TuningTargetJSON convert_classy = TuningTargetJSON.from_json(json_value, ignore_extras, true);
        setTuningTarget(convert_classy);
      }


    private void  fromJSONSuggestions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SuggestedStationsJSON convert_classy = SuggestedStationsJSON.from_json(json_value, ignore_extras, true);
        setSuggestions(convert_classy);
      }


    public SiriusChannelCommandJSON()
      {
        flagHasChannel = false;
        flagHasExtendedChannel = false;
        flagHasAlreadyOnResult = false;
        flagHasTuningTarget = false;
        flagHasSuggestions = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRadioCommandKind()
      {
        return "SiriusChannel";
      }

    public bool  hasChannel()
      {
        return flagHasChannel;
      }

    public byte  getChannel()
      {
        Debug.Assert(flagHasChannel);
        return storeChannel;
      }

    public bool  hasExtendedChannel()
      {
        return flagHasExtendedChannel;
      }

    public ushort  getExtendedChannel()
      {
        Debug.Assert(flagHasExtendedChannel);
        return storeExtendedChannel;
      }

    public bool  hasAlreadyOnResult()
      {
        return flagHasAlreadyOnResult;
      }

    public DynamicResponseJSON   getAlreadyOnResult()
      {
        Debug.Assert(flagHasAlreadyOnResult);
        return storeAlreadyOnResult;
      }

    public bool  hasTuningTarget()
      {
        return flagHasTuningTarget;
      }

    public TuningTargetJSON   getTuningTarget()
      {
        Debug.Assert(flagHasTuningTarget);
        return storeTuningTarget;
      }

    public bool  hasSuggestions()
      {
        return flagHasSuggestions;
      }

    public SuggestedStationsJSON   getSuggestions()
      {
        Debug.Assert(flagHasSuggestions);
        return storeSuggestions;
      }


    public virtual int extraSiriusChannelCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSiriusChannelCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSiriusChannelCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSiriusChannelCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRadioCommandComponentCount()
      {
        int result = 0;
        if (flagHasChannel)
            ++result;
        if (flagHasExtendedChannel)
            ++result;
        if (flagHasAlreadyOnResult)
            ++result;
        if (flagHasTuningTarget)
            ++result;
        if (flagHasSuggestions)
            ++result;
        result += extraSiriusChannelCommandComponentCount();
        return result;
      }
    public override string extraRadioCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannel)
          {
            if (remainder == 0)
                return "Channel";
            --remainder;
          }
        if (flagHasExtendedChannel)
          {
            if (remainder == 0)
                return "ExtendedChannel";
            --remainder;
          }
        if (flagHasAlreadyOnResult)
          {
            if (remainder == 0)
                return "AlreadyOnResult";
            --remainder;
          }
        if (flagHasTuningTarget)
          {
            if (remainder == 0)
                return "TuningTarget";
            --remainder;
          }
        if (flagHasSuggestions)
          {
            if (remainder == 0)
                return "Suggestions";
            --remainder;
          }
        return extraSiriusChannelCommandComponentKey(remainder);
      }
    public override JSONValue extraRadioCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannel)
          {
            if (remainder == 0)
                return extraChannelToJSON();
            --remainder;
          }
        if (flagHasExtendedChannel)
          {
            if (remainder == 0)
                return extraExtendedChannelToJSON();
            --remainder;
          }
        if (flagHasAlreadyOnResult)
          {
            if (remainder == 0)
                return extraAlreadyOnResultToJSON();
            --remainder;
          }
        if (flagHasTuningTarget)
          {
            if (remainder == 0)
                return extraTuningTargetToJSON();
            --remainder;
          }
        if (flagHasSuggestions)
          {
            if (remainder == 0)
                return extraSuggestionsToJSON();
            --remainder;
          }
        return extraSiriusChannelCommandComponentValue(remainder);
      }
    public override JSONValue extraRadioCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "lreadyOnResult", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasAlreadyOnResult ? extraAlreadyOnResultToJSON() : null);
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "hannel", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasChannel ? extraChannelToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "xtendedChannel", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasExtendedChannel ? extraExtendedChannelToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "uggestions", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasSuggestions ? extraSuggestionsToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "uningTarget", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasTuningTarget ? extraTuningTargetToJSON() : null);
                break;
            default:
                break;
          }
        return extraSiriusChannelCommandLookup(field_name);
      }

    public void setChannel(byte new_value)
      {
        flagHasChannel = true;
        if (new_value < 1)
            throw new Exception("The value for field Channel of SiriusChannelCommandJSON is less than the lower bound (1) for that field.");
        if (new_value > 233)
            throw new Exception("The value for field Channel of SiriusChannelCommandJSON is greater than the upper bound (233) for that field.");
        storeChannel = new_value;
      }
    public void unsetChannel()
      {
        flagHasChannel = false;
      }
    public void setExtendedChannel(ushort new_value)
      {
        flagHasExtendedChannel = true;
        if (new_value < 1)
            throw new Exception("The value for field ExtendedChannel of SiriusChannelCommandJSON is less than the lower bound (1) for that field.");
        if (new_value > 65535)
            throw new Exception("The value for field ExtendedChannel of SiriusChannelCommandJSON is greater than the upper bound (65535) for that field.");
        storeExtendedChannel = new_value;
      }
    public void unsetExtendedChannel()
      {
        flagHasExtendedChannel = false;
      }
    public void setAlreadyOnResult(DynamicResponseJSON  new_value)
      {
        if (flagHasAlreadyOnResult)
          {
          }
        flagHasAlreadyOnResult = true;
        storeAlreadyOnResult = new_value;
      }
    public void unsetAlreadyOnResult()
      {
        if (flagHasAlreadyOnResult)
          {
          }
        flagHasAlreadyOnResult = false;
      }
    public void setTuningTarget(TuningTargetJSON  new_value)
      {
        if (flagHasTuningTarget)
          {
          }
        flagHasTuningTarget = true;
        storeTuningTarget = new_value;
      }
    public void unsetTuningTarget()
      {
        if (flagHasTuningTarget)
          {
          }
        flagHasTuningTarget = false;
      }
    public void setSuggestions(SuggestedStationsJSON  new_value)
      {
        if (flagHasSuggestions)
          {
          }
        flagHasSuggestions = true;
        storeSuggestions = new_value;
      }
    public void unsetSuggestions()
      {
        if (flagHasSuggestions)
          {
          }
        flagHasSuggestions = false;
      }

    public virtual void extraSiriusChannelCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSiriusChannelCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSiriusChannelCommandLookup(key);
        if (old_field == null)
          {
            extraSiriusChannelCommandAppendPair(key, new_component);
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
            case 'A':
                if ((String.Compare(key, 1, "lreadyOnResult", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONAlreadyOnResult(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "hannel", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONChannel(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "xtendedChannel", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONExtendedChannel(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "uggestions", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONSuggestions(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "uningTarget", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONTuningTarget(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSiriusChannelCommandAppendPair(key, new_component);
      }
    public override void extraRadioCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "lreadyOnResult", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONAlreadyOnResult(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "hannel", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONChannel(new_component, false);
                    return;
                    }
                break;
            case 'E':
                if ((String.Compare(key, 1, "xtendedChannel", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONExtendedChannel(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "uggestions", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONSuggestions(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "uningTarget", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONTuningTarget(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSiriusChannelCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasChannel);
        if (flagHasChannel)
          {
            handler.start_pair("Channel");
            handler.number_value(storeChannel);
          }
        Debug.Assert(partial_allowed || flagHasExtendedChannel);
        if (flagHasExtendedChannel)
          {
            handler.start_pair("ExtendedChannel");
            handler.number_value(storeExtendedChannel);
          }
        if (flagHasAlreadyOnResult)
          {
            handler.start_pair("AlreadyOnResult");
            if (partial_allowed)
                storeAlreadyOnResult.write_partial_as_json(handler);
            else
                storeAlreadyOnResult.write_as_json(handler);
          }
        if (flagHasTuningTarget)
          {
            handler.start_pair("TuningTarget");
            if (partial_allowed)
                storeTuningTarget.write_partial_as_json(handler);
            else
                storeTuningTarget.write_as_json(handler);
          }
        if (flagHasSuggestions)
          {
            handler.start_pair("Suggestions");
            if (partial_allowed)
                storeSuggestions.write_partial_as_json(handler);
            else
                storeSuggestions.write_as_json(handler);
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
        if (!(hasChannel()))
          {
            return "When parsing the object for %what%, the \"Channel\" field was missing.";
          }
        if (!(hasExtendedChannel()))
          {
            return "When parsing the object for %what%, the \"ExtendedChannel\" field was missing.";
          }
        return null;
      }

    public static new SiriusChannelCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SiriusChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SiriusChannelCommand", ignore_extras);
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
    public static new SiriusChannelCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SiriusChannelCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SiriusChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SiriusChannelCommand", ignore_extras);
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
    public static new SiriusChannelCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SiriusChannelCommandJSON from_text(string text, bool ignore_extras)
      {
        SiriusChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SiriusChannelCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SiriusChannelCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SiriusChannelCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SiriusChannelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SiriusChannelCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RadioCommandJSON.Generator
      {
    private class FieldHoldingGeneratorChannel : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorChannel(String what) : base(what, 1, 233)
              {
              }
          };
    private class FieldHoldingArrayGeneratorChannel : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorChannel(String what) : base(what, 1, 233)
              {
              }
          };
        private FieldHoldingGeneratorChannel fieldGeneratorChannel;
    private class FieldHoldingGeneratorExtendedChannel : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorExtendedChannel(String what) : base(what, 1, 65535)
              {
              }
          };
    private class FieldHoldingArrayGeneratorExtendedChannel : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorExtendedChannel(String what) : base(what, 1, 65535)
              {
              }
          };
        private FieldHoldingGeneratorExtendedChannel fieldGeneratorExtendedChannel;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAlreadyOnResult;
        private TuningTargetJSON.HoldingGenerator fieldGeneratorTuningTarget;
        private SuggestedStationsJSON.HoldingGenerator fieldGeneratorSuggestions;
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
            if (!(getRadioCommandJSONKey().Equals("SiriusChannel")))
                throw new Exception("The key field has a value other than `SiriusChannel'.");
            SiriusChannelCommandJSON result = new SiriusChannelCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSiriusChannelCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RadioCommandJSON new_result)
          {
            handle_result((SiriusChannelCommandJSON )new_result);
          }
        protected void finish(SiriusChannelCommandJSON result)
          {
            if (fieldGeneratorChannel.have_value)
              {
                result.setChannel((byte)(fieldGeneratorChannel.value));
                fieldGeneratorChannel.have_value = false;
              }
            else if ((!(result.hasChannel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Channel\" field was missing.");
              }
            if (fieldGeneratorExtendedChannel.have_value)
              {
                result.setExtendedChannel((ushort)(fieldGeneratorExtendedChannel.value));
                fieldGeneratorExtendedChannel.have_value = false;
              }
            else if ((!(result.hasExtendedChannel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExtendedChannel\" field was missing.");
              }
            if (fieldGeneratorAlreadyOnResult.have_value)
              {
                result.setAlreadyOnResult(fieldGeneratorAlreadyOnResult.value);
                fieldGeneratorAlreadyOnResult.have_value = false;
              }
            if (fieldGeneratorTuningTarget.have_value)
              {
                result.setTuningTarget(fieldGeneratorTuningTarget.value);
                fieldGeneratorTuningTarget.have_value = false;
              }
            if (fieldGeneratorSuggestions.have_value)
              {
                result.setSuggestions(fieldGeneratorSuggestions.value);
                fieldGeneratorSuggestions.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SiriusChannelCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "lreadyOnResult", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorAlreadyOnResult;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "hannel", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorChannel;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xtendedChannel", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorExtendedChannel;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "uggestions", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorSuggestions;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "uningTarget", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorTuningTarget;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorChannel = new FieldHoldingGeneratorChannel("field \"Channel\" of the SiriusChannelCommand class");
            fieldGeneratorExtendedChannel = new FieldHoldingGeneratorExtendedChannel("field \"ExtendedChannel\" of the SiriusChannelCommand class");
            fieldGeneratorAlreadyOnResult = new DynamicResponseJSON.HoldingGenerator("field \"AlreadyOnResult\" of the SiriusChannelCommand class", ignore_extras);
            fieldGeneratorTuningTarget = new TuningTargetJSON.HoldingGenerator("field \"TuningTarget\" of the SiriusChannelCommand class", ignore_extras);
            fieldGeneratorSuggestions = new SuggestedStationsJSON.HoldingGenerator("field \"Suggestions\" of the SiriusChannelCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SiriusChannelCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorChannel = new FieldHoldingGeneratorChannel("field \"Channel\" of the SiriusChannelCommand class");
            fieldGeneratorExtendedChannel = new FieldHoldingGeneratorExtendedChannel("field \"ExtendedChannel\" of the SiriusChannelCommand class");
            fieldGeneratorAlreadyOnResult = new DynamicResponseJSON.HoldingGenerator("field \"AlreadyOnResult\" of the SiriusChannelCommand class", false);
            fieldGeneratorTuningTarget = new TuningTargetJSON.HoldingGenerator("field \"TuningTarget\" of the SiriusChannelCommand class", false);
            fieldGeneratorSuggestions = new SuggestedStationsJSON.HoldingGenerator("field \"Suggestions\" of the SiriusChannelCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SiriusChannelCommand class");
          }

        public override void reset()
          {
            fieldGeneratorChannel.reset();
            fieldGeneratorExtendedChannel.reset();
            fieldGeneratorAlreadyOnResult.reset();
            fieldGeneratorTuningTarget.reset();
            fieldGeneratorSuggestions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SiriusChannelCommandJSON  result)
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
        public SiriusChannelCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SiriusChannelCommandJSON  result)
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
    protected virtual void handle_result(List<SiriusChannelCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SiriusChannelCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SiriusChannelCommandJSON>();
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
    public List<SiriusChannelCommandJSON> value;
  };
  };
