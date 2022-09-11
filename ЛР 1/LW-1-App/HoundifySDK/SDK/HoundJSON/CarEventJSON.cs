/* file "CarEventJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarEventJSON : JSONBase
  {
    private bool flagHasEventName;
    private string storeEventName;
    private bool flagHasEventType;
    private string storeEventType;
    private bool flagHasAttribute;
    private string storeAttribute;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEventName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EventName of CarEventJSON is not a string.");
        setEventName(json_string.getData());
      }


    private void  fromJSONEventType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EventType of CarEventJSON is not a string.");
        setEventType(json_string.getData());
      }


    private void  fromJSONAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Attribute of CarEventJSON is not a string.");
        setAttribute(json_string.getData());
      }


    public CarEventJSON()
      {
        flagHasEventName = false;
        flagHasEventType = false;
        flagHasAttribute = false;
        storeAttribute = "unknown";
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEventName()
      {
        return flagHasEventName;
      }

    public string  getEventName()
      {
        Debug.Assert(flagHasEventName);
        return storeEventName;
      }

    public bool  hasEventType()
      {
        return flagHasEventType;
      }

    public string  getEventType()
      {
        Debug.Assert(flagHasEventType);
        return storeEventType;
      }

    public bool  hasAttribute()
      {
        return flagHasAttribute;
      }

    public string  getAttribute()
      {
        return storeAttribute;
      }


    public virtual int extraCarEventComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarEventComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarEventComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarEventLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setEventName(string new_value)
      {
        flagHasEventName = true;
        storeEventName = new_value;
      }
    public void unsetEventName()
      {
        flagHasEventName = false;
      }
    public void setEventType(string new_value)
      {
        flagHasEventType = true;
        storeEventType = new_value;
      }
    public void unsetEventType()
      {
        flagHasEventType = false;
      }
    public void setAttribute(string new_value)
      {
        flagHasAttribute = true;
        storeAttribute = new_value;
      }
    public void unsetAttribute()
      {
        flagHasAttribute = false;
      }

    public virtual void extraCarEventAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarEventSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarEventLookup(key);
        if (old_field == null)
          {
            extraCarEventAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasEventName);
        if (flagHasEventName)
          {
            handler.start_pair("EventName");
            handler.string_value(storeEventName);
          }
        Debug.Assert(partial_allowed || flagHasEventType);
        if (flagHasEventType)
          {
            handler.start_pair("EventType");
            handler.string_value(storeEventType);
          }
        Debug.Assert(partial_allowed || flagHasAttribute);
        if (flagHasAttribute)
          {
            handler.start_pair("Attribute");
            handler.string_value(storeAttribute);
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
        if (!(hasEventName()))
          {
            return "When parsing the object for %what%, the \"EventName\" field was missing.";
          }
        if (!(hasEventType()))
          {
            return "When parsing the object for %what%, the \"EventType\" field was missing.";
          }
        if (!(hasAttribute()))
          {
            return "When parsing the object for %what%, the \"Attribute\" field was missing.";
          }
        return null;
      }

    public static CarEventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarEvent", ignore_extras);
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
    public static CarEventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarEventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarEvent", ignore_extras);
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
    public static CarEventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarEventJSON from_text(string text, bool ignore_extras)
      {
        CarEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarEvent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarEventJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CarEventJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarEvent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorEventName;
        private JSONHoldingStringGenerator fieldGeneratorEventType;
        private JSONHoldingStringGenerator fieldGeneratorAttribute;
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
            CarEventJSON result = new CarEventJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarEventAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CarEventJSON result)
          {
            if (fieldGeneratorEventName.have_value)
              {
                result.setEventName(fieldGeneratorEventName.value);
                fieldGeneratorEventName.have_value = false;
              }
            else if ((!(result.hasEventName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EventName\" field was missing.");
              }
            if (fieldGeneratorEventType.have_value)
              {
                result.setEventType(fieldGeneratorEventType.value);
                fieldGeneratorEventType.have_value = false;
              }
            else if ((!(result.hasEventType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EventType\" field was missing.");
              }
            if (fieldGeneratorAttribute.have_value)
              {
                result.setAttribute(fieldGeneratorAttribute.value);
                fieldGeneratorAttribute.have_value = false;
              }
            else if ((!(result.hasAttribute())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Attribute\" field was missing.");
              }
          }
        protected abstract void handle_result(CarEventJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribute", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorAttribute;
                    break;
                case 'E':
                    if (String.Compare(field_name, 1, "vent", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorEventName;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 6, "ype", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorEventType;
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
            fieldGeneratorEventName = new JSONHoldingStringGenerator("field \"EventName\" of the CarEvent class");
            fieldGeneratorEventType = new JSONHoldingStringGenerator("field \"EventType\" of the CarEvent class");
            fieldGeneratorAttribute = new JSONHoldingStringGenerator("field \"Attribute\" of the CarEvent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarEvent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEventName = new JSONHoldingStringGenerator("field \"EventName\" of the CarEvent class");
            fieldGeneratorEventType = new JSONHoldingStringGenerator("field \"EventType\" of the CarEvent class");
            fieldGeneratorAttribute = new JSONHoldingStringGenerator("field \"Attribute\" of the CarEvent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarEvent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEventName.reset();
            fieldGeneratorEventType.reset();
            fieldGeneratorAttribute.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CarEventJSON  result)
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
        public CarEventJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarEventJSON  result)
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
    protected virtual void handle_result(List<CarEventJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarEventJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarEventJSON>();
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
    public List<CarEventJSON> value;
  };
  };
