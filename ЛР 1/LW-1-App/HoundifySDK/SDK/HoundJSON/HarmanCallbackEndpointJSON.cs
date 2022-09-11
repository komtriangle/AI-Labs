/* file "HarmanCallbackEndpointJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HarmanCallbackEndpointJSON : JSONBase
  {
    private bool flagHasEndPoint;
    private string storeEndPoint;
    private bool flagHasSharedAccessKeyName;
    private string storeSharedAccessKeyName;
    private bool flagHasSharedAccessKey;
    private string storeSharedAccessKey;
    private bool flagHasEntityPath;
    private string storeEntityPath;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEndPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EndPoint of HarmanCallbackEndpointJSON is not a string.");
        setEndPoint(json_string.getData());
      }


    private void  fromJSONSharedAccessKeyName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SharedAccessKeyName of HarmanCallbackEndpointJSON is not a string.");
        setSharedAccessKeyName(json_string.getData());
      }


    private void  fromJSONSharedAccessKey(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SharedAccessKey of HarmanCallbackEndpointJSON is not a string.");
        setSharedAccessKey(json_string.getData());
      }


    private void  fromJSONEntityPath(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EntityPath of HarmanCallbackEndpointJSON is not a string.");
        setEntityPath(json_string.getData());
      }


    public HarmanCallbackEndpointJSON()
      {
        flagHasEndPoint = false;
        flagHasSharedAccessKeyName = false;
        flagHasSharedAccessKey = false;
        flagHasEntityPath = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEndPoint()
      {
        return flagHasEndPoint;
      }

    public string  getEndPoint()
      {
        Debug.Assert(flagHasEndPoint);
        return storeEndPoint;
      }

    public bool  hasSharedAccessKeyName()
      {
        return flagHasSharedAccessKeyName;
      }

    public string  getSharedAccessKeyName()
      {
        Debug.Assert(flagHasSharedAccessKeyName);
        return storeSharedAccessKeyName;
      }

    public bool  hasSharedAccessKey()
      {
        return flagHasSharedAccessKey;
      }

    public string  getSharedAccessKey()
      {
        Debug.Assert(flagHasSharedAccessKey);
        return storeSharedAccessKey;
      }

    public bool  hasEntityPath()
      {
        return flagHasEntityPath;
      }

    public string  getEntityPath()
      {
        Debug.Assert(flagHasEntityPath);
        return storeEntityPath;
      }


    public virtual int extraHarmanCallbackEndpointComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanCallbackEndpointComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanCallbackEndpointComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanCallbackEndpointLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setEndPoint(string new_value)
      {
        flagHasEndPoint = true;
        storeEndPoint = new_value;
      }
    public void unsetEndPoint()
      {
        flagHasEndPoint = false;
      }
    public void setSharedAccessKeyName(string new_value)
      {
        flagHasSharedAccessKeyName = true;
        storeSharedAccessKeyName = new_value;
      }
    public void unsetSharedAccessKeyName()
      {
        flagHasSharedAccessKeyName = false;
      }
    public void setSharedAccessKey(string new_value)
      {
        flagHasSharedAccessKey = true;
        storeSharedAccessKey = new_value;
      }
    public void unsetSharedAccessKey()
      {
        flagHasSharedAccessKey = false;
      }
    public void setEntityPath(string new_value)
      {
        flagHasEntityPath = true;
        storeEntityPath = new_value;
      }
    public void unsetEntityPath()
      {
        flagHasEntityPath = false;
      }

    public virtual void extraHarmanCallbackEndpointAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanCallbackEndpointSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanCallbackEndpointLookup(key);
        if (old_field == null)
          {
            extraHarmanCallbackEndpointAppendPair(key, new_component);
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
        if (flagHasEndPoint)
          {
            handler.start_pair("EndPoint");
            handler.string_value(storeEndPoint);
          }
        if (flagHasSharedAccessKeyName)
          {
            handler.start_pair("SharedAccessKeyName");
            handler.string_value(storeSharedAccessKeyName);
          }
        if (flagHasSharedAccessKey)
          {
            handler.start_pair("SharedAccessKey");
            handler.string_value(storeSharedAccessKey);
          }
        if (flagHasEntityPath)
          {
            handler.start_pair("EntityPath");
            handler.string_value(storeEntityPath);
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

    public static HarmanCallbackEndpointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanCallbackEndpointJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanCallbackEndpoint", ignore_extras);
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
    public static HarmanCallbackEndpointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanCallbackEndpointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanCallbackEndpointJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanCallbackEndpoint", ignore_extras);
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
    public static HarmanCallbackEndpointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanCallbackEndpointJSON from_text(string text, bool ignore_extras)
      {
        HarmanCallbackEndpointJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanCallbackEndpoint", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanCallbackEndpointJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanCallbackEndpointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanCallbackEndpointJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanCallbackEndpoint", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorEndPoint;
        private JSONHoldingStringGenerator fieldGeneratorSharedAccessKeyName;
        private JSONHoldingStringGenerator fieldGeneratorSharedAccessKey;
        private JSONHoldingStringGenerator fieldGeneratorEntityPath;
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
            HarmanCallbackEndpointJSON result = new HarmanCallbackEndpointJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanCallbackEndpointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanCallbackEndpointJSON result)
          {
            if (fieldGeneratorEndPoint.have_value)
              {
                result.setEndPoint(fieldGeneratorEndPoint.value);
                fieldGeneratorEndPoint.have_value = false;
              }
            if (fieldGeneratorSharedAccessKeyName.have_value)
              {
                result.setSharedAccessKeyName(fieldGeneratorSharedAccessKeyName.value);
                fieldGeneratorSharedAccessKeyName.have_value = false;
              }
            if (fieldGeneratorSharedAccessKey.have_value)
              {
                result.setSharedAccessKey(fieldGeneratorSharedAccessKey.value);
                fieldGeneratorSharedAccessKey.have_value = false;
              }
            if (fieldGeneratorEntityPath.have_value)
              {
                result.setEntityPath(fieldGeneratorEntityPath.value);
                fieldGeneratorEntityPath.have_value = false;
              }
          }
        protected abstract void handle_result(HarmanCallbackEndpointJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if (String.Compare(field_name, 1, "n", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 3, "Point", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorEndPoint;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 3, "ityPath", 0, 7, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorEntityPath;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "haredAccessKey", 0, 14, false) == 0)
                      {
                        if (field_name.Length == 15)
                          {
                            return fieldGeneratorSharedAccessKey;
                          }
                        switch (field_name[15])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 16, "ame", 0, 3, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorSharedAccessKeyName;
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
            fieldGeneratorEndPoint = new JSONHoldingStringGenerator("field \"EndPoint\" of the HarmanCallbackEndpoint class");
            fieldGeneratorSharedAccessKeyName = new JSONHoldingStringGenerator("field \"SharedAccessKeyName\" of the HarmanCallbackEndpoint class");
            fieldGeneratorSharedAccessKey = new JSONHoldingStringGenerator("field \"SharedAccessKey\" of the HarmanCallbackEndpoint class");
            fieldGeneratorEntityPath = new JSONHoldingStringGenerator("field \"EntityPath\" of the HarmanCallbackEndpoint class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanCallbackEndpoint class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEndPoint = new JSONHoldingStringGenerator("field \"EndPoint\" of the HarmanCallbackEndpoint class");
            fieldGeneratorSharedAccessKeyName = new JSONHoldingStringGenerator("field \"SharedAccessKeyName\" of the HarmanCallbackEndpoint class");
            fieldGeneratorSharedAccessKey = new JSONHoldingStringGenerator("field \"SharedAccessKey\" of the HarmanCallbackEndpoint class");
            fieldGeneratorEntityPath = new JSONHoldingStringGenerator("field \"EntityPath\" of the HarmanCallbackEndpoint class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanCallbackEndpoint class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEndPoint.reset();
            fieldGeneratorSharedAccessKeyName.reset();
            fieldGeneratorSharedAccessKey.reset();
            fieldGeneratorEntityPath.reset();
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
        protected override void handle_result(HarmanCallbackEndpointJSON  result)
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
        public HarmanCallbackEndpointJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanCallbackEndpointJSON  result)
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
    protected virtual void handle_result(List<HarmanCallbackEndpointJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanCallbackEndpointJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanCallbackEndpointJSON>();
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
    public List<HarmanCallbackEndpointJSON> value;
  };
  };
