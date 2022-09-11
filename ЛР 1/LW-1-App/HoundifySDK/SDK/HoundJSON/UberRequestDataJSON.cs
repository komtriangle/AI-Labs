/* file "UberRequestDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberRequestDataJSON : JSONBase
  {
    private bool flagHasUberProductId;
    private string storeUberProductId;
    private bool flagHasPickupLocation;
    private MapLocationJSON  storePickupLocation;
    private bool flagHasDropoffLocation;
    private MapLocationJSON  storeDropoffLocation;
    private bool flagHasSurgeConfirmationId;
    private string storeSurgeConfirmationId;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUberProductId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UberProductId of UberRequestDataJSON is not a string.");
        setUberProductId(json_string.getData());
      }


    private void  fromJSONPickupLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setPickupLocation(convert_classy);
      }


    private void  fromJSONDropoffLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setDropoffLocation(convert_classy);
      }


    private void  fromJSONSurgeConfirmationId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SurgeConfirmationId of UberRequestDataJSON is not a string.");
        setSurgeConfirmationId(json_string.getData());
      }


    public UberRequestDataJSON()
      {
        flagHasUberProductId = false;
        flagHasPickupLocation = false;
        flagHasDropoffLocation = false;
        flagHasSurgeConfirmationId = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUberProductId()
      {
        return flagHasUberProductId;
      }

    public string  getUberProductId()
      {
        Debug.Assert(flagHasUberProductId);
        return storeUberProductId;
      }

    public bool  hasPickupLocation()
      {
        return flagHasPickupLocation;
      }

    public MapLocationJSON   getPickupLocation()
      {
        Debug.Assert(flagHasPickupLocation);
        return storePickupLocation;
      }

    public bool  hasDropoffLocation()
      {
        return flagHasDropoffLocation;
      }

    public MapLocationJSON   getDropoffLocation()
      {
        Debug.Assert(flagHasDropoffLocation);
        return storeDropoffLocation;
      }

    public bool  hasSurgeConfirmationId()
      {
        return flagHasSurgeConfirmationId;
      }

    public string  getSurgeConfirmationId()
      {
        Debug.Assert(flagHasSurgeConfirmationId);
        return storeSurgeConfirmationId;
      }


    public virtual int extraUberRequestDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberRequestDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberRequestDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberRequestDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setUberProductId(string new_value)
      {
        flagHasUberProductId = true;
        storeUberProductId = new_value;
      }
    public void unsetUberProductId()
      {
        flagHasUberProductId = false;
      }
    public void setPickupLocation(MapLocationJSON  new_value)
      {
        if (flagHasPickupLocation)
          {
          }
        flagHasPickupLocation = true;
        storePickupLocation = new_value;
      }
    public void unsetPickupLocation()
      {
        if (flagHasPickupLocation)
          {
          }
        flagHasPickupLocation = false;
      }
    public void setDropoffLocation(MapLocationJSON  new_value)
      {
        if (flagHasDropoffLocation)
          {
          }
        flagHasDropoffLocation = true;
        storeDropoffLocation = new_value;
      }
    public void unsetDropoffLocation()
      {
        if (flagHasDropoffLocation)
          {
          }
        flagHasDropoffLocation = false;
      }
    public void setSurgeConfirmationId(string new_value)
      {
        flagHasSurgeConfirmationId = true;
        storeSurgeConfirmationId = new_value;
      }
    public void unsetSurgeConfirmationId()
      {
        flagHasSurgeConfirmationId = false;
      }

    public virtual void extraUberRequestDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberRequestDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberRequestDataLookup(key);
        if (old_field == null)
          {
            extraUberRequestDataAppendPair(key, new_component);
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
        if (flagHasUberProductId)
          {
            handler.start_pair("UberProductId");
            handler.string_value(storeUberProductId);
          }
        if (flagHasPickupLocation)
          {
            handler.start_pair("PickupLocation");
            if (partial_allowed)
                storePickupLocation.write_partial_as_json(handler);
            else
                storePickupLocation.write_as_json(handler);
          }
        if (flagHasDropoffLocation)
          {
            handler.start_pair("DropoffLocation");
            if (partial_allowed)
                storeDropoffLocation.write_partial_as_json(handler);
            else
                storeDropoffLocation.write_as_json(handler);
          }
        if (flagHasSurgeConfirmationId)
          {
            handler.start_pair("SurgeConfirmationId");
            handler.string_value(storeSurgeConfirmationId);
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

    public static UberRequestDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestData", ignore_extras);
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
    public static UberRequestDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestData", ignore_extras);
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
    public static UberRequestDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestDataJSON from_text(string text, bool ignore_extras)
      {
        UberRequestDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberRequestDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberRequestDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberRequestDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorUberProductId;
        private MapLocationJSON.HoldingGenerator fieldGeneratorPickupLocation;
        private MapLocationJSON.HoldingGenerator fieldGeneratorDropoffLocation;
        private JSONHoldingStringGenerator fieldGeneratorSurgeConfirmationId;
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
            UberRequestDataJSON result = new UberRequestDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberRequestDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberRequestDataJSON result)
          {
            if (fieldGeneratorUberProductId.have_value)
              {
                result.setUberProductId(fieldGeneratorUberProductId.value);
                fieldGeneratorUberProductId.have_value = false;
              }
            if (fieldGeneratorPickupLocation.have_value)
              {
                result.setPickupLocation(fieldGeneratorPickupLocation.value);
                fieldGeneratorPickupLocation.have_value = false;
              }
            if (fieldGeneratorDropoffLocation.have_value)
              {
                result.setDropoffLocation(fieldGeneratorDropoffLocation.value);
                fieldGeneratorDropoffLocation.have_value = false;
              }
            if (fieldGeneratorSurgeConfirmationId.have_value)
              {
                result.setSurgeConfirmationId(fieldGeneratorSurgeConfirmationId.value);
                fieldGeneratorSurgeConfirmationId.have_value = false;
              }
          }
        protected abstract void handle_result(UberRequestDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ropoffLocation", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorDropoffLocation;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ickupLocation", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorPickupLocation;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "urgeConfirmationId", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorSurgeConfirmationId;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "berProductId", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorUberProductId;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorUberProductId = new JSONHoldingStringGenerator("field \"UberProductId\" of the UberRequestData class");
            fieldGeneratorPickupLocation = new MapLocationJSON.HoldingGenerator("field \"PickupLocation\" of the UberRequestData class", ignore_extras);
            fieldGeneratorDropoffLocation = new MapLocationJSON.HoldingGenerator("field \"DropoffLocation\" of the UberRequestData class", ignore_extras);
            fieldGeneratorSurgeConfirmationId = new JSONHoldingStringGenerator("field \"SurgeConfirmationId\" of the UberRequestData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberRequestData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUberProductId = new JSONHoldingStringGenerator("field \"UberProductId\" of the UberRequestData class");
            fieldGeneratorPickupLocation = new MapLocationJSON.HoldingGenerator("field \"PickupLocation\" of the UberRequestData class", false);
            fieldGeneratorDropoffLocation = new MapLocationJSON.HoldingGenerator("field \"DropoffLocation\" of the UberRequestData class", false);
            fieldGeneratorSurgeConfirmationId = new JSONHoldingStringGenerator("field \"SurgeConfirmationId\" of the UberRequestData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberRequestData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUberProductId.reset();
            fieldGeneratorPickupLocation.reset();
            fieldGeneratorDropoffLocation.reset();
            fieldGeneratorSurgeConfirmationId.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPickupLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDropoffLocation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPickupLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDropoffLocation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberRequestDataJSON  result)
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
        public UberRequestDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberRequestDataJSON  result)
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
    protected virtual void handle_result(List<UberRequestDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberRequestDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberRequestDataJSON>();
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
    public List<UberRequestDataJSON> value;
  };
  };
