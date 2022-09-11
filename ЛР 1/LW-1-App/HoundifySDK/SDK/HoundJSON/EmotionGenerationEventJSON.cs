/* file "EmotionGenerationEventJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EmotionGenerationEventJSON : JSONBase
  {
    private bool flagHasMessageType;
    private string storeMessageType;
    private bool flagHasCarEvent;
    private List< CarEventJSON  > storeCarEvent;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONMessageType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MessageType of EmotionGenerationEventJSON is not a string.");
        setMessageType(json_string.getData());
      }


    private void  fromJSONCarEvent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CarEvent of EmotionGenerationEventJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field CarEvent of EmotionGenerationEventJSON has too few elements.");
        List< CarEventJSON  > vector_CarEvent1 = new List< CarEventJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CarEventJSON convert_classy = CarEventJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_CarEvent1.Add(convert_classy);
          }
        Debug.Assert(vector_CarEvent1.Count >= 1);
        initCarEvent();
        for (int num1 = 0; num1 < vector_CarEvent1.Count; ++num1)
            appendCarEvent(vector_CarEvent1[num1]);
        for (int num1 = 0; num1 < vector_CarEvent1.Count; ++num1)
          {
          }
      }


    public EmotionGenerationEventJSON()
      {
        flagHasMessageType = false;
        flagHasCarEvent = false;
        storeCarEvent = new List< CarEventJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasMessageType()
      {
        return flagHasMessageType;
      }

    public string  getMessageType()
      {
        Debug.Assert(flagHasMessageType);
        return storeMessageType;
      }

    public bool  hasCarEvent()
      {
        return flagHasCarEvent;
      }

    public int  countOfCarEvent()
      {
        Debug.Assert(flagHasCarEvent);
        return storeCarEvent.Count;
      }

    public CarEventJSON   elementOfCarEvent(int element_num)
      {
        Debug.Assert(flagHasCarEvent);
        return storeCarEvent[element_num];
      }

    public List< CarEventJSON  >  getCarEvent()
      {
        Debug.Assert(flagHasCarEvent);
        return storeCarEvent;
      }


    public virtual int extraEmotionGenerationEventComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraEmotionGenerationEventComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraEmotionGenerationEventComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraEmotionGenerationEventLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setMessageType(string new_value)
      {
        flagHasMessageType = true;
        storeMessageType = new_value;
      }
    public void unsetMessageType()
      {
        flagHasMessageType = false;
      }
    public void initCarEvent()
      {
        if (flagHasCarEvent)
          {
            for (int num1 = 0; num1 < storeCarEvent.Count; ++num1)
              {
              }
          }
        flagHasCarEvent = true;
        storeCarEvent.Clear();
      }
    public void appendCarEvent(CarEventJSON  to_append)
      {
        if (!flagHasCarEvent)
          {
            flagHasCarEvent = true;
            storeCarEvent.Clear();
          }
        Debug.Assert(flagHasCarEvent);
        storeCarEvent.Add(to_append);
      }
    public void unsetCarEvent()
      {
        if (flagHasCarEvent)
          {
            for (int num2 = 0; num2 < storeCarEvent.Count; ++num2)
              {
              }
          }
        flagHasCarEvent = false;
        storeCarEvent.Clear();
      }

    public virtual void extraEmotionGenerationEventAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraEmotionGenerationEventSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraEmotionGenerationEventLookup(key);
        if (old_field == null)
          {
            extraEmotionGenerationEventAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasMessageType);
        if (flagHasMessageType)
          {
            handler.start_pair("MessageType");
            handler.string_value(storeMessageType);
          }
        Debug.Assert(partial_allowed || flagHasCarEvent);
        if (flagHasCarEvent)
          {
            handler.start_pair("CarEvent");
            Debug.Assert(storeCarEvent.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeCarEvent.Count; ++num1)
              {
                if (partial_allowed)
                    storeCarEvent[num1].write_partial_as_json(handler);
                else
                    storeCarEvent[num1].write_as_json(handler);
              }
            handler.finish_array();
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
        if (!(hasMessageType()))
          {
            return "When parsing the object for %what%, the \"MessageType\" field was missing.";
          }
        if (!(hasCarEvent()))
          {
            return "When parsing the object for %what%, the \"CarEvent\" field was missing.";
          }
        return null;
      }

    public static EmotionGenerationEventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmotionGenerationEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmotionGenerationEvent", ignore_extras);
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
    public static EmotionGenerationEventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmotionGenerationEventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmotionGenerationEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmotionGenerationEvent", ignore_extras);
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
    public static EmotionGenerationEventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EmotionGenerationEventJSON from_text(string text, bool ignore_extras)
      {
        EmotionGenerationEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmotionGenerationEvent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EmotionGenerationEventJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static EmotionGenerationEventJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EmotionGenerationEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmotionGenerationEvent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorMessageType;
        private CarEventJSON.HoldingArrayGenerator fieldGeneratorCarEvent;
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
            EmotionGenerationEventJSON result = new EmotionGenerationEventJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraEmotionGenerationEventAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(EmotionGenerationEventJSON result)
          {
            if (fieldGeneratorMessageType.have_value)
              {
                result.setMessageType(fieldGeneratorMessageType.value);
                fieldGeneratorMessageType.have_value = false;
              }
            else if ((!(result.hasMessageType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MessageType\" field was missing.");
              }
            if (fieldGeneratorCarEvent.have_value)
              {
                result.initCarEvent();
                int count = fieldGeneratorCarEvent.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCarEvent(fieldGeneratorCarEvent.value[num]);
                  }
                fieldGeneratorCarEvent.value.Clear();
                fieldGeneratorCarEvent.have_value = false;
              }
            else if ((!(result.hasCarEvent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CarEvent\" field was missing.");
              }
          }
        protected abstract void handle_result(EmotionGenerationEventJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "arEvent", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorCarEvent;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "essageType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMessageType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMessageType = new JSONHoldingStringGenerator("field \"MessageType\" of the EmotionGenerationEvent class");
            fieldGeneratorCarEvent = new CarEventJSON.HoldingArrayGenerator("field \"CarEvent\" of the EmotionGenerationEvent class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the EmotionGenerationEvent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMessageType = new JSONHoldingStringGenerator("field \"MessageType\" of the EmotionGenerationEvent class");
            fieldGeneratorCarEvent = new CarEventJSON.HoldingArrayGenerator("field \"CarEvent\" of the EmotionGenerationEvent class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the EmotionGenerationEvent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMessageType.reset();
            fieldGeneratorCarEvent.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCarEvent.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCarEvent.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(EmotionGenerationEventJSON  result)
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
        public EmotionGenerationEventJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EmotionGenerationEventJSON  result)
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
    protected virtual void handle_result(List<EmotionGenerationEventJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EmotionGenerationEventJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EmotionGenerationEventJSON>();
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
    public List<EmotionGenerationEventJSON> value;
  };
  };
