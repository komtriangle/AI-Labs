/* file "NoHistoryConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class NoHistoryConversationStateJSON : JSONBase
  {
    private bool flagHasConversationStateTime;
    private BigInteger storeConversationStateTime;
    private bool flagHasHistory;
    private JSONValue  storeHistory;
    private bool flagHasQueryEntities;
    private SentenceEntitiesJSON  storeQueryEntities;
    private bool flagHasResponseEntities;
    private SentenceEntitiesJSON  storeResponseEntities;
    private bool flagHasMode;
    private string storeMode;
    private bool flagHasVoiceActivityDetectionMinima;
    private VoiceActivityDetectionMinimaJSON  storeVoiceActivityDetectionMinima;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONConversationStateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ConversationStateTime of NoHistoryConversationStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ConversationStateTime of NoHistoryConversationStateJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setConversationStateTime(extracted_integer);
      }


    private void  fromJSONHistory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        setHistory(json_value);
      }


    private void  fromJSONQueryEntities(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SentenceEntitiesJSON convert_classy = SentenceEntitiesJSON.from_json(json_value, ignore_extras, true);
        setQueryEntities(convert_classy);
      }


    private void  fromJSONResponseEntities(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SentenceEntitiesJSON convert_classy = SentenceEntitiesJSON.from_json(json_value, ignore_extras, true);
        setResponseEntities(convert_classy);
      }


    private void  fromJSONMode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Mode of NoHistoryConversationStateJSON is not a string.");
        setMode(json_string.getData());
      }


    private void  fromJSONVoiceActivityDetectionMinima(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        VoiceActivityDetectionMinimaJSON convert_classy = VoiceActivityDetectionMinimaJSON.from_json(json_value, ignore_extras, true);
        setVoiceActivityDetectionMinima(convert_classy);
      }


    public NoHistoryConversationStateJSON()
      {
        flagHasConversationStateTime = false;
        flagHasHistory = false;
        flagHasQueryEntities = false;
        flagHasResponseEntities = false;
        flagHasMode = false;
        flagHasVoiceActivityDetectionMinima = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasConversationStateTime()
      {
        return flagHasConversationStateTime;
      }

    public BigInteger  getConversationStateTime()
      {
        Debug.Assert(flagHasConversationStateTime);
        return storeConversationStateTime;
      }

    public bool  hasHistory()
      {
        return flagHasHistory;
      }

    public JSONValue   getHistory()
      {
        Debug.Assert(flagHasHistory);
        return storeHistory;
      }

    public bool  hasQueryEntities()
      {
        return flagHasQueryEntities;
      }

    public SentenceEntitiesJSON   getQueryEntities()
      {
        Debug.Assert(flagHasQueryEntities);
        return storeQueryEntities;
      }

    public bool  hasResponseEntities()
      {
        return flagHasResponseEntities;
      }

    public SentenceEntitiesJSON   getResponseEntities()
      {
        Debug.Assert(flagHasResponseEntities);
        return storeResponseEntities;
      }

    public bool  hasMode()
      {
        return flagHasMode;
      }

    public string  getMode()
      {
        Debug.Assert(flagHasMode);
        return storeMode;
      }

    public bool  hasVoiceActivityDetectionMinima()
      {
        return flagHasVoiceActivityDetectionMinima;
      }

    public VoiceActivityDetectionMinimaJSON   getVoiceActivityDetectionMinima()
      {
        Debug.Assert(flagHasVoiceActivityDetectionMinima);
        return storeVoiceActivityDetectionMinima;
      }


    public virtual int extraNoHistoryConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraNoHistoryConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraNoHistoryConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraNoHistoryConversationStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setConversationStateTime(BigInteger new_value)
      {
        flagHasConversationStateTime = true;
        storeConversationStateTime = new_value;
      }
    public void unsetConversationStateTime()
      {
        flagHasConversationStateTime = false;
      }
    public void setHistory(JSONValue  new_value)
      {
        if (flagHasHistory)
          {
          }
        flagHasHistory = true;
        storeHistory = new_value;
      }
    public void unsetHistory()
      {
        if (flagHasHistory)
          {
          }
        flagHasHistory = false;
      }
    public void setQueryEntities(SentenceEntitiesJSON  new_value)
      {
        if (flagHasQueryEntities)
          {
          }
        flagHasQueryEntities = true;
        storeQueryEntities = new_value;
      }
    public void unsetQueryEntities()
      {
        if (flagHasQueryEntities)
          {
          }
        flagHasQueryEntities = false;
      }
    public void setResponseEntities(SentenceEntitiesJSON  new_value)
      {
        if (flagHasResponseEntities)
          {
          }
        flagHasResponseEntities = true;
        storeResponseEntities = new_value;
      }
    public void unsetResponseEntities()
      {
        if (flagHasResponseEntities)
          {
          }
        flagHasResponseEntities = false;
      }
    public void setMode(string new_value)
      {
        flagHasMode = true;
        storeMode = new_value;
      }
    public void unsetMode()
      {
        flagHasMode = false;
      }
    public void setVoiceActivityDetectionMinima(VoiceActivityDetectionMinimaJSON  new_value)
      {
        if (flagHasVoiceActivityDetectionMinima)
          {
          }
        flagHasVoiceActivityDetectionMinima = true;
        storeVoiceActivityDetectionMinima = new_value;
      }
    public void unsetVoiceActivityDetectionMinima()
      {
        if (flagHasVoiceActivityDetectionMinima)
          {
          }
        flagHasVoiceActivityDetectionMinima = false;
      }

    public virtual void extraNoHistoryConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraNoHistoryConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraNoHistoryConversationStateLookup(key);
        if (old_field == null)
          {
            extraNoHistoryConversationStateAppendPair(key, new_component);
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
        if (flagHasConversationStateTime)
          {
            handler.start_pair("ConversationStateTime");
            handler.number_value(storeConversationStateTime);
          }
        if (flagHasHistory)
          {
            handler.start_pair("History");
            storeHistory.write(handler);
          }
        if (flagHasQueryEntities)
          {
            handler.start_pair("QueryEntities");
            if (partial_allowed)
                storeQueryEntities.write_partial_as_json(handler);
            else
                storeQueryEntities.write_as_json(handler);
          }
        if (flagHasResponseEntities)
          {
            handler.start_pair("ResponseEntities");
            if (partial_allowed)
                storeResponseEntities.write_partial_as_json(handler);
            else
                storeResponseEntities.write_as_json(handler);
          }
        if (flagHasMode)
          {
            handler.start_pair("Mode");
            handler.string_value(storeMode);
          }
        if (flagHasVoiceActivityDetectionMinima)
          {
            handler.start_pair("VoiceActivityDetectionMinima");
            if (partial_allowed)
                storeVoiceActivityDetectionMinima.write_partial_as_json(handler);
            else
                storeVoiceActivityDetectionMinima.write_as_json(handler);
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

    public static NoHistoryConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NoHistoryConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NoHistoryConversationState", ignore_extras);
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
    public static NoHistoryConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NoHistoryConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NoHistoryConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NoHistoryConversationState", ignore_extras);
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
    public static NoHistoryConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NoHistoryConversationStateJSON from_text(string text, bool ignore_extras)
      {
        NoHistoryConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NoHistoryConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NoHistoryConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static NoHistoryConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NoHistoryConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NoHistoryConversationState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorConversationStateTime : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorConversationStateTime(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorConversationStateTime : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorConversationStateTime(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorConversationStateTime fieldGeneratorConversationStateTime;
        private JSONHoldingValueGenerator fieldGeneratorHistory;
        private SentenceEntitiesJSON.HoldingGenerator fieldGeneratorQueryEntities;
        private SentenceEntitiesJSON.HoldingGenerator fieldGeneratorResponseEntities;
        private JSONHoldingStringGenerator fieldGeneratorMode;
        private VoiceActivityDetectionMinimaJSON.HoldingGenerator fieldGeneratorVoiceActivityDetectionMinima;
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
            NoHistoryConversationStateJSON result = new NoHistoryConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraNoHistoryConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(NoHistoryConversationStateJSON result)
          {
            if (fieldGeneratorConversationStateTime.have_value)
              {
                result.setConversationStateTime(fieldGeneratorConversationStateTime.value);
                fieldGeneratorConversationStateTime.have_value = false;
              }
            if (fieldGeneratorHistory.have_value)
              {
                result.setHistory(fieldGeneratorHistory.value);
                fieldGeneratorHistory.have_value = false;
              }
            if (fieldGeneratorQueryEntities.have_value)
              {
                result.setQueryEntities(fieldGeneratorQueryEntities.value);
                fieldGeneratorQueryEntities.have_value = false;
              }
            if (fieldGeneratorResponseEntities.have_value)
              {
                result.setResponseEntities(fieldGeneratorResponseEntities.value);
                fieldGeneratorResponseEntities.have_value = false;
              }
            if (fieldGeneratorMode.have_value)
              {
                result.setMode(fieldGeneratorMode.value);
                fieldGeneratorMode.have_value = false;
              }
            if (fieldGeneratorVoiceActivityDetectionMinima.have_value)
              {
                result.setVoiceActivityDetectionMinima(fieldGeneratorVoiceActivityDetectionMinima.value);
                fieldGeneratorVoiceActivityDetectionMinima.have_value = false;
              }
          }
        protected abstract void handle_result(NoHistoryConversationStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "onversationStateTime", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorConversationStateTime;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "istory", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorHistory;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "ode", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorMode;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryEntities", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorQueryEntities;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esponseEntities", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorResponseEntities;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "oiceActivityDetectionMinima", 0, 27, false) == 0) && (field_name.Length == 28))
                        return fieldGeneratorVoiceActivityDetectionMinima;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorConversationStateTime = new FieldHoldingGeneratorConversationStateTime("field \"ConversationStateTime\" of the NoHistoryConversationState class");
            fieldGeneratorHistory = new JSONHoldingValueGenerator("field \"History\" of the NoHistoryConversationState class");
            fieldGeneratorQueryEntities = new SentenceEntitiesJSON.HoldingGenerator("field \"QueryEntities\" of the NoHistoryConversationState class", ignore_extras);
            fieldGeneratorResponseEntities = new SentenceEntitiesJSON.HoldingGenerator("field \"ResponseEntities\" of the NoHistoryConversationState class", ignore_extras);
            fieldGeneratorMode = new JSONHoldingStringGenerator("field \"Mode\" of the NoHistoryConversationState class");
            fieldGeneratorVoiceActivityDetectionMinima = new VoiceActivityDetectionMinimaJSON.HoldingGenerator("field \"VoiceActivityDetectionMinima\" of the NoHistoryConversationState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the NoHistoryConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorConversationStateTime = new FieldHoldingGeneratorConversationStateTime("field \"ConversationStateTime\" of the NoHistoryConversationState class");
            fieldGeneratorHistory = new JSONHoldingValueGenerator("field \"History\" of the NoHistoryConversationState class");
            fieldGeneratorQueryEntities = new SentenceEntitiesJSON.HoldingGenerator("field \"QueryEntities\" of the NoHistoryConversationState class", false);
            fieldGeneratorResponseEntities = new SentenceEntitiesJSON.HoldingGenerator("field \"ResponseEntities\" of the NoHistoryConversationState class", false);
            fieldGeneratorMode = new JSONHoldingStringGenerator("field \"Mode\" of the NoHistoryConversationState class");
            fieldGeneratorVoiceActivityDetectionMinima = new VoiceActivityDetectionMinimaJSON.HoldingGenerator("field \"VoiceActivityDetectionMinima\" of the NoHistoryConversationState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the NoHistoryConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorConversationStateTime.reset();
            fieldGeneratorHistory.reset();
            fieldGeneratorQueryEntities.reset();
            fieldGeneratorResponseEntities.reset();
            fieldGeneratorMode.reset();
            fieldGeneratorVoiceActivityDetectionMinima.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorQueryEntities.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorResponseEntities.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorVoiceActivityDetectionMinima.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorQueryEntities.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorResponseEntities.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorVoiceActivityDetectionMinima.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(NoHistoryConversationStateJSON  result)
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
        public NoHistoryConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NoHistoryConversationStateJSON  result)
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
    protected virtual void handle_result(List<NoHistoryConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NoHistoryConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NoHistoryConversationStateJSON>();
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
    public List<NoHistoryConversationStateJSON> value;
  };
  };
