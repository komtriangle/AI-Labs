/* file "MapLocationWithDescriptionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MapLocationWithDescriptionJSON : MapLocationJSON
  {
    private bool flagHasWrittenLongDescription;
    private string storeWrittenLongDescription;
    private bool flagHasSpokenLongDescription;
    private string storeSpokenLongDescription;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraWrittenLongDescriptionToJSON()
      {
        JSONStringValue generated_string_WrittenLongDescription = new JSONStringValue(storeWrittenLongDescription);
        return generated_string_WrittenLongDescription;
      }

    private JSONValue  extraSpokenLongDescriptionToJSON()
      {
        JSONStringValue generated_string_SpokenLongDescription = new JSONStringValue(storeSpokenLongDescription);
        return generated_string_SpokenLongDescription;
      }


    private void  fromJSONWrittenLongDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenLongDescription of MapLocationWithDescriptionJSON is not a string.");
        setWrittenLongDescription(json_string.getData());
      }


    private void  fromJSONSpokenLongDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenLongDescription of MapLocationWithDescriptionJSON is not a string.");
        setSpokenLongDescription(json_string.getData());
      }


    public MapLocationWithDescriptionJSON()
      {
        flagHasWrittenLongDescription = false;
        flagHasSpokenLongDescription = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasWrittenLongDescription()
      {
        return flagHasWrittenLongDescription;
      }

    public string  getWrittenLongDescription()
      {
        Debug.Assert(flagHasWrittenLongDescription);
        return storeWrittenLongDescription;
      }

    public bool  hasSpokenLongDescription()
      {
        return flagHasSpokenLongDescription;
      }

    public string  getSpokenLongDescription()
      {
        Debug.Assert(flagHasSpokenLongDescription);
        return storeSpokenLongDescription;
      }


    public virtual int extraMapLocationWithDescriptionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMapLocationWithDescriptionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMapLocationWithDescriptionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMapLocationWithDescriptionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMapLocationComponentCount()
      {
        int result = 0;
        if (flagHasWrittenLongDescription)
            ++result;
        if (flagHasSpokenLongDescription)
            ++result;
        result += extraMapLocationWithDescriptionComponentCount();
        return result;
      }
    public override string extraMapLocationComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasWrittenLongDescription)
          {
            if (remainder == 0)
                return "WrittenLongDescription";
            --remainder;
          }
        if (flagHasSpokenLongDescription)
          {
            if (remainder == 0)
                return "SpokenLongDescription";
            --remainder;
          }
        return extraMapLocationWithDescriptionComponentKey(remainder);
      }
    public override JSONValue extraMapLocationComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasWrittenLongDescription)
          {
            if (remainder == 0)
                return extraWrittenLongDescriptionToJSON();
            --remainder;
          }
        if (flagHasSpokenLongDescription)
          {
            if (remainder == 0)
                return extraSpokenLongDescriptionToJSON();
            --remainder;
          }
        return extraMapLocationWithDescriptionComponentValue(remainder);
      }
    public override JSONValue extraMapLocationLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'S':
                if ((String.Compare(field_name, 1, "pokenLongDescription", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasSpokenLongDescription ? extraSpokenLongDescriptionToJSON() : null);
                break;
            case 'W':
                if ((String.Compare(field_name, 1, "rittenLongDescription", 0, 21, false) == 0) && (field_name.Length == 22))
                    return (flagHasWrittenLongDescription ? extraWrittenLongDescriptionToJSON() : null);
                break;
            default:
                break;
          }
        return extraMapLocationWithDescriptionLookup(field_name);
      }

    public void setWrittenLongDescription(string new_value)
      {
        flagHasWrittenLongDescription = true;
        storeWrittenLongDescription = new_value;
      }
    public void unsetWrittenLongDescription()
      {
        flagHasWrittenLongDescription = false;
      }
    public void setSpokenLongDescription(string new_value)
      {
        flagHasSpokenLongDescription = true;
        storeSpokenLongDescription = new_value;
      }
    public void unsetSpokenLongDescription()
      {
        flagHasSpokenLongDescription = false;
      }

    public virtual void extraMapLocationWithDescriptionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMapLocationWithDescriptionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMapLocationWithDescriptionLookup(key);
        if (old_field == null)
          {
            extraMapLocationWithDescriptionAppendPair(key, new_component);
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
    public override void extraMapLocationAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'S':
                if ((String.Compare(key, 1, "pokenLongDescription", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONSpokenLongDescription(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "rittenLongDescription", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONWrittenLongDescription(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMapLocationWithDescriptionAppendPair(key, new_component);
      }
    public override void extraMapLocationSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'S':
                if ((String.Compare(key, 1, "pokenLongDescription", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONSpokenLongDescription(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "rittenLongDescription", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONWrittenLongDescription(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMapLocationWithDescriptionSetField(key, new_component);
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
        if (flagHasWrittenLongDescription)
          {
            handler.start_pair("WrittenLongDescription");
            handler.string_value(storeWrittenLongDescription);
          }
        if (flagHasSpokenLongDescription)
          {
            handler.start_pair("SpokenLongDescription");
            handler.string_value(storeSpokenLongDescription);
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

    public static new MapLocationWithDescriptionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapLocationWithDescriptionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocationWithDescription", ignore_extras);
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
    public static new MapLocationWithDescriptionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MapLocationWithDescriptionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapLocationWithDescriptionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocationWithDescription", ignore_extras);
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
    public static new MapLocationWithDescriptionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MapLocationWithDescriptionJSON from_text(string text, bool ignore_extras)
      {
        MapLocationWithDescriptionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocationWithDescription", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MapLocationWithDescriptionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MapLocationWithDescriptionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MapLocationWithDescriptionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapLocationWithDescription", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MapLocationJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorWrittenLongDescription;
        private JSONHoldingStringGenerator fieldGeneratorSpokenLongDescription;
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
            MapLocationWithDescriptionJSON result = new MapLocationWithDescriptionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMapLocationWithDescriptionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MapLocationJSON new_result)
          {
            handle_result((MapLocationWithDescriptionJSON )new_result);
          }
        protected void finish(MapLocationWithDescriptionJSON result)
          {
            if (fieldGeneratorWrittenLongDescription.have_value)
              {
                result.setWrittenLongDescription(fieldGeneratorWrittenLongDescription.value);
                fieldGeneratorWrittenLongDescription.have_value = false;
              }
            if (fieldGeneratorSpokenLongDescription.have_value)
              {
                result.setSpokenLongDescription(fieldGeneratorSpokenLongDescription.value);
                fieldGeneratorSpokenLongDescription.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MapLocationWithDescriptionJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenLongDescription", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorSpokenLongDescription;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenLongDescription", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorWrittenLongDescription;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorWrittenLongDescription = new JSONHoldingStringGenerator("field \"WrittenLongDescription\" of the MapLocationWithDescription class");
            fieldGeneratorSpokenLongDescription = new JSONHoldingStringGenerator("field \"SpokenLongDescription\" of the MapLocationWithDescription class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MapLocationWithDescription class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorWrittenLongDescription = new JSONHoldingStringGenerator("field \"WrittenLongDescription\" of the MapLocationWithDescription class");
            fieldGeneratorSpokenLongDescription = new JSONHoldingStringGenerator("field \"SpokenLongDescription\" of the MapLocationWithDescription class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MapLocationWithDescription class");
          }

        public override void reset()
          {
            fieldGeneratorWrittenLongDescription.reset();
            fieldGeneratorSpokenLongDescription.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MapLocationWithDescriptionJSON  result)
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
        public MapLocationWithDescriptionJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MapLocationWithDescriptionJSON  result)
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
    protected virtual void handle_result(List<MapLocationWithDescriptionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MapLocationWithDescriptionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MapLocationWithDescriptionJSON>();
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
    public List<MapLocationWithDescriptionJSON> value;
  };
    public static MapLocationWithDescriptionJSON from_MapLocationJSON_json(MapLocationJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        MapLocationWithDescriptionJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type MapLocationWithDescription", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
