/* file "RadioSuggestionInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RadioSuggestionInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasReasons;
    private List< FulfillmentFailureReasonJSON  > storeReasons;
    private bool flagHasTuningTarget;
    private TuningTargetJSON  storeTuningTarget;
    private bool flagHasSuggestions;
    private SuggestedStationsJSON  storeSuggestions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraReasonsToJSON()
      {
        JSONArrayValue generated_array_1_Reasons = new JSONArrayValue();
        for (int num1 = 0; num1 < storeReasons.Count; ++num1)
          {
            JSONValueHandler handler_Reasons = new JSONValueHandler();
            storeReasons[num1].write_as_json(handler_Reasons);
            generated_array_1_Reasons.appendComponent(handler_Reasons.result);
          }
        return generated_array_1_Reasons;
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


    private void  fromJSONReasons(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Reasons of RadioSuggestionInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Reasons of RadioSuggestionInformationNuggetJSON has too few elements.");
        List< FulfillmentFailureReasonJSON  > vector_Reasons1 = new List< FulfillmentFailureReasonJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FulfillmentFailureReasonJSON convert_classy = FulfillmentFailureReasonJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Reasons1.Add(convert_classy);
          }
        Debug.Assert(vector_Reasons1.Count >= 1);
        initReasons();
        for (int num1 = 0; num1 < vector_Reasons1.Count; ++num1)
            appendReasons(vector_Reasons1[num1]);
        for (int num1 = 0; num1 < vector_Reasons1.Count; ++num1)
          {
          }
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


    public RadioSuggestionInformationNuggetJSON()
      {
        flagHasReasons = false;
        flagHasTuningTarget = false;
        flagHasSuggestions = false;
        storeReasons = new List< FulfillmentFailureReasonJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "SuggestedRadio";
      }

    public bool  hasReasons()
      {
        return flagHasReasons;
      }

    public int  countOfReasons()
      {
        Debug.Assert(flagHasReasons);
        return storeReasons.Count;
      }

    public FulfillmentFailureReasonJSON   elementOfReasons(int element_num)
      {
        Debug.Assert(flagHasReasons);
        return storeReasons[element_num];
      }

    public List< FulfillmentFailureReasonJSON  >  getReasons()
      {
        Debug.Assert(flagHasReasons);
        return storeReasons;
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


    public virtual int extraRadioSuggestionInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRadioSuggestionInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRadioSuggestionInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRadioSuggestionInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasReasons)
            ++result;
        if (flagHasTuningTarget)
            ++result;
        if (flagHasSuggestions)
            ++result;
        result += extraRadioSuggestionInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasReasons)
          {
            if (remainder == 0)
                return "Reasons";
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
        return extraRadioSuggestionInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasReasons)
          {
            if (remainder == 0)
                return extraReasonsToJSON();
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
        return extraRadioSuggestionInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'R':
                if ((String.Compare(field_name, 1, "easons", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasReasons ? extraReasonsToJSON() : null);
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
        return extraRadioSuggestionInformationNuggetLookup(field_name);
      }

    public void initReasons()
      {
        if (flagHasReasons)
          {
            for (int num1 = 0; num1 < storeReasons.Count; ++num1)
              {
              }
          }
        flagHasReasons = true;
        storeReasons.Clear();
      }
    public void appendReasons(FulfillmentFailureReasonJSON  to_append)
      {
        if (!flagHasReasons)
          {
            flagHasReasons = true;
            storeReasons.Clear();
          }
        Debug.Assert(flagHasReasons);
        storeReasons.Add(to_append);
      }
    public void unsetReasons()
      {
        if (flagHasReasons)
          {
            for (int num2 = 0; num2 < storeReasons.Count; ++num2)
              {
              }
          }
        flagHasReasons = false;
        storeReasons.Clear();
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

    public virtual void extraRadioSuggestionInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRadioSuggestionInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRadioSuggestionInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraRadioSuggestionInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'R':
                if ((String.Compare(key, 1, "easons", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONReasons(new_component, false);
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
        extraRadioSuggestionInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'R':
                if ((String.Compare(key, 1, "easons", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONReasons(new_component, false);
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
        extraRadioSuggestionInformationNuggetSetField(key, new_component);
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
        if (flagHasReasons)
          {
            handler.start_pair("Reasons");
            Debug.Assert(storeReasons.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeReasons.Count; ++num1)
              {
                if (partial_allowed)
                    storeReasons[num1].write_partial_as_json(handler);
                else
                    storeReasons[num1].write_as_json(handler);
              }
            handler.finish_array();
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
        return null;
      }

    public static new RadioSuggestionInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioSuggestionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioSuggestionInformationNugget", ignore_extras);
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
    public static new RadioSuggestionInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RadioSuggestionInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioSuggestionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioSuggestionInformationNugget", ignore_extras);
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
    public static new RadioSuggestionInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RadioSuggestionInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        RadioSuggestionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioSuggestionInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RadioSuggestionInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RadioSuggestionInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RadioSuggestionInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioSuggestionInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private FulfillmentFailureReasonJSON.HoldingArrayGenerator fieldGeneratorReasons;
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
            if (!(getInformationNuggetJSONKey().Equals("SuggestedRadio")))
                throw new Exception("The key field has a value other than `SuggestedRadio'.");
            RadioSuggestionInformationNuggetJSON result = new RadioSuggestionInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRadioSuggestionInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((RadioSuggestionInformationNuggetJSON )new_result);
          }
        protected void finish(RadioSuggestionInformationNuggetJSON result)
          {
            if (fieldGeneratorReasons.have_value)
              {
                result.initReasons();
                int count = fieldGeneratorReasons.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendReasons(fieldGeneratorReasons.value[num]);
                  }
                fieldGeneratorReasons.value.Clear();
                fieldGeneratorReasons.have_value = false;
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
        protected abstract void handle_result(RadioSuggestionInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'R':
                    if ((String.Compare(field_name, 1, "easons", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorReasons;
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
            fieldGeneratorReasons = new FulfillmentFailureReasonJSON.HoldingArrayGenerator("field \"Reasons\" of the RadioSuggestionInformationNugget class", ignore_extras);
            fieldGeneratorTuningTarget = new TuningTargetJSON.HoldingGenerator("field \"TuningTarget\" of the RadioSuggestionInformationNugget class", ignore_extras);
            fieldGeneratorSuggestions = new SuggestedStationsJSON.HoldingGenerator("field \"Suggestions\" of the RadioSuggestionInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RadioSuggestionInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorReasons = new FulfillmentFailureReasonJSON.HoldingArrayGenerator("field \"Reasons\" of the RadioSuggestionInformationNugget class", false);
            fieldGeneratorTuningTarget = new TuningTargetJSON.HoldingGenerator("field \"TuningTarget\" of the RadioSuggestionInformationNugget class", false);
            fieldGeneratorSuggestions = new SuggestedStationsJSON.HoldingGenerator("field \"Suggestions\" of the RadioSuggestionInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RadioSuggestionInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorReasons.reset();
            fieldGeneratorTuningTarget.reset();
            fieldGeneratorSuggestions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RadioSuggestionInformationNuggetJSON  result)
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
        public RadioSuggestionInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RadioSuggestionInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<RadioSuggestionInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RadioSuggestionInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RadioSuggestionInformationNuggetJSON>();
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
    public List<RadioSuggestionInformationNuggetJSON> value;
  };
  };
