/* file "IHeartMediaDeviceIdentifiersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class IHeartMediaDeviceIdentifiersJSON : JSONBase
  {
    private bool flagHasDeviceID;
    private string storeDeviceID;
    private bool flagHasDeviceName;
    private string storeDeviceName;
    private bool flagHasOAuthUUID;
    private string storeOAuthUUID;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDeviceID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DeviceID of IHeartMediaDeviceIdentifiersJSON is not a string.");
        setDeviceID(json_string.getData());
      }


    private void  fromJSONDeviceName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DeviceName of IHeartMediaDeviceIdentifiersJSON is not a string.");
        setDeviceName(json_string.getData());
      }


    private void  fromJSONOAuthUUID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OAuthUUID of IHeartMediaDeviceIdentifiersJSON is not a string.");
        setOAuthUUID(json_string.getData());
      }


    public IHeartMediaDeviceIdentifiersJSON()
      {
        flagHasDeviceID = false;
        flagHasDeviceName = false;
        flagHasOAuthUUID = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDeviceID()
      {
        return flagHasDeviceID;
      }

    public string  getDeviceID()
      {
        Debug.Assert(flagHasDeviceID);
        return storeDeviceID;
      }

    public bool  hasDeviceName()
      {
        return flagHasDeviceName;
      }

    public string  getDeviceName()
      {
        Debug.Assert(flagHasDeviceName);
        return storeDeviceName;
      }

    public bool  hasOAuthUUID()
      {
        return flagHasOAuthUUID;
      }

    public string  getOAuthUUID()
      {
        Debug.Assert(flagHasOAuthUUID);
        return storeOAuthUUID;
      }


    public virtual int extraIHeartMediaDeviceIdentifiersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartMediaDeviceIdentifiersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartMediaDeviceIdentifiersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartMediaDeviceIdentifiersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDeviceID(string new_value)
      {
        flagHasDeviceID = true;
        storeDeviceID = new_value;
      }
    public void unsetDeviceID()
      {
        flagHasDeviceID = false;
      }
    public void setDeviceName(string new_value)
      {
        flagHasDeviceName = true;
        storeDeviceName = new_value;
      }
    public void unsetDeviceName()
      {
        flagHasDeviceName = false;
      }
    public void setOAuthUUID(string new_value)
      {
        flagHasOAuthUUID = true;
        storeOAuthUUID = new_value;
      }
    public void unsetOAuthUUID()
      {
        flagHasOAuthUUID = false;
      }

    public virtual void extraIHeartMediaDeviceIdentifiersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartMediaDeviceIdentifiersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartMediaDeviceIdentifiersLookup(key);
        if (old_field == null)
          {
            extraIHeartMediaDeviceIdentifiersAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDeviceID);
        if (flagHasDeviceID)
          {
            handler.start_pair("DeviceID");
            handler.string_value(storeDeviceID);
          }
        Debug.Assert(partial_allowed || flagHasDeviceName);
        if (flagHasDeviceName)
          {
            handler.start_pair("DeviceName");
            handler.string_value(storeDeviceName);
          }
        Debug.Assert(partial_allowed || flagHasOAuthUUID);
        if (flagHasOAuthUUID)
          {
            handler.start_pair("OAuthUUID");
            handler.string_value(storeOAuthUUID);
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
        if (!(hasDeviceID()))
          {
            return "When parsing the object for %what%, the \"DeviceID\" field was missing.";
          }
        if (!(hasDeviceName()))
          {
            return "When parsing the object for %what%, the \"DeviceName\" field was missing.";
          }
        if (!(hasOAuthUUID()))
          {
            return "When parsing the object for %what%, the \"OAuthUUID\" field was missing.";
          }
        return null;
      }

    public static IHeartMediaDeviceIdentifiersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartMediaDeviceIdentifiersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartMediaDeviceIdentifiers", ignore_extras);
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
    public static IHeartMediaDeviceIdentifiersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartMediaDeviceIdentifiersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartMediaDeviceIdentifiersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartMediaDeviceIdentifiers", ignore_extras);
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
    public static IHeartMediaDeviceIdentifiersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartMediaDeviceIdentifiersJSON from_text(string text, bool ignore_extras)
      {
        IHeartMediaDeviceIdentifiersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartMediaDeviceIdentifiers", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartMediaDeviceIdentifiersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartMediaDeviceIdentifiersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartMediaDeviceIdentifiersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartMediaDeviceIdentifiers", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorDeviceID;
        private JSONHoldingStringGenerator fieldGeneratorDeviceName;
        private JSONHoldingStringGenerator fieldGeneratorOAuthUUID;
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
            IHeartMediaDeviceIdentifiersJSON result = new IHeartMediaDeviceIdentifiersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartMediaDeviceIdentifiersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartMediaDeviceIdentifiersJSON result)
          {
            if (fieldGeneratorDeviceID.have_value)
              {
                result.setDeviceID(fieldGeneratorDeviceID.value);
                fieldGeneratorDeviceID.have_value = false;
              }
            else if ((!(result.hasDeviceID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DeviceID\" field was missing.");
              }
            if (fieldGeneratorDeviceName.have_value)
              {
                result.setDeviceName(fieldGeneratorDeviceName.value);
                fieldGeneratorDeviceName.have_value = false;
              }
            else if ((!(result.hasDeviceName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DeviceName\" field was missing.");
              }
            if (fieldGeneratorOAuthUUID.have_value)
              {
                result.setOAuthUUID(fieldGeneratorOAuthUUID.value);
                fieldGeneratorOAuthUUID.have_value = false;
              }
            else if ((!(result.hasOAuthUUID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OAuthUUID\" field was missing.");
              }
          }
        protected abstract void handle_result(IHeartMediaDeviceIdentifiersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "evice", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 7, "D", 0, 1, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorDeviceID;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 7, "ame", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorDeviceName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "AuthUUID", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorOAuthUUID;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDeviceID = new JSONHoldingStringGenerator("field \"DeviceID\" of the IHeartMediaDeviceIdentifiers class");
            fieldGeneratorDeviceName = new JSONHoldingStringGenerator("field \"DeviceName\" of the IHeartMediaDeviceIdentifiers class");
            fieldGeneratorOAuthUUID = new JSONHoldingStringGenerator("field \"OAuthUUID\" of the IHeartMediaDeviceIdentifiers class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartMediaDeviceIdentifiers class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDeviceID = new JSONHoldingStringGenerator("field \"DeviceID\" of the IHeartMediaDeviceIdentifiers class");
            fieldGeneratorDeviceName = new JSONHoldingStringGenerator("field \"DeviceName\" of the IHeartMediaDeviceIdentifiers class");
            fieldGeneratorOAuthUUID = new JSONHoldingStringGenerator("field \"OAuthUUID\" of the IHeartMediaDeviceIdentifiers class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartMediaDeviceIdentifiers class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDeviceID.reset();
            fieldGeneratorDeviceName.reset();
            fieldGeneratorOAuthUUID.reset();
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
        protected override void handle_result(IHeartMediaDeviceIdentifiersJSON  result)
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
        public IHeartMediaDeviceIdentifiersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartMediaDeviceIdentifiersJSON  result)
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
    protected virtual void handle_result(List<IHeartMediaDeviceIdentifiersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartMediaDeviceIdentifiersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartMediaDeviceIdentifiersJSON>();
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
    public List<IHeartMediaDeviceIdentifiersJSON> value;
  };
  };
