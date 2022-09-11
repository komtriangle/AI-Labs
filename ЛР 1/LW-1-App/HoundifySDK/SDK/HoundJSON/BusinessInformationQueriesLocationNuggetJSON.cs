/* file "BusinessInformationQueriesLocationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BusinessInformationQueriesLocationNuggetJSON : BusinessInformationQueriesNuggetJSON
  {
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasIntersection;
    private MapLocationJSON  storeIntersection;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraLocationToJSON()
      {
        JSONValueHandler handler_Location = new JSONValueHandler();
        storeLocation.write_as_json(handler_Location);
        return handler_Location.result;
      }

    private JSONValue  extraIntersectionToJSON()
      {
        JSONValueHandler handler_Intersection = new JSONValueHandler();
        storeIntersection.write_as_json(handler_Intersection);
        return handler_Intersection.result;
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONIntersection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setIntersection(convert_classy);
      }


    public BusinessInformationQueriesLocationNuggetJSON()
      {
        flagHasLocation = false;
        flagHasIntersection = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getBusinessInformationQueriesNuggetKind()
      {
        return "Location";
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasIntersection()
      {
        return flagHasIntersection;
      }

    public MapLocationJSON   getIntersection()
      {
        Debug.Assert(flagHasIntersection);
        return storeIntersection;
      }


    public virtual int extraBusinessInformationQueriesLocationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBusinessInformationQueriesLocationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBusinessInformationQueriesLocationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBusinessInformationQueriesLocationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraBusinessInformationQueriesNuggetComponentCount()
      {
        int result = 0;
        if (flagHasLocation)
            ++result;
        if (flagHasIntersection)
            ++result;
        result += extraBusinessInformationQueriesLocationNuggetComponentCount();
        return result;
      }
    public override string extraBusinessInformationQueriesNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasLocation)
          {
            if (remainder == 0)
                return "Location";
            --remainder;
          }
        if (flagHasIntersection)
          {
            if (remainder == 0)
                return "Intersection";
            --remainder;
          }
        return extraBusinessInformationQueriesLocationNuggetComponentKey(remainder);
      }
    public override JSONValue extraBusinessInformationQueriesNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasLocation)
          {
            if (remainder == 0)
                return extraLocationToJSON();
            --remainder;
          }
        if (flagHasIntersection)
          {
            if (remainder == 0)
                return extraIntersectionToJSON();
            --remainder;
          }
        return extraBusinessInformationQueriesLocationNuggetComponentValue(remainder);
      }
    public override JSONValue extraBusinessInformationQueriesNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "ntersection", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasIntersection ? extraIntersectionToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasLocation ? extraLocationToJSON() : null);
                break;
            default:
                break;
          }
        return extraBusinessInformationQueriesLocationNuggetLookup(field_name);
      }

    public void setLocation(MapLocationJSON  new_value)
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = false;
      }
    public void setIntersection(MapLocationJSON  new_value)
      {
        if (flagHasIntersection)
          {
          }
        flagHasIntersection = true;
        storeIntersection = new_value;
      }
    public void unsetIntersection()
      {
        if (flagHasIntersection)
          {
          }
        flagHasIntersection = false;
      }

    public virtual void extraBusinessInformationQueriesLocationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBusinessInformationQueriesLocationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBusinessInformationQueriesLocationNuggetLookup(key);
        if (old_field == null)
          {
            extraBusinessInformationQueriesLocationNuggetAppendPair(key, new_component);
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
    public override void extraBusinessInformationQueriesNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "ntersection", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONIntersection(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBusinessInformationQueriesLocationNuggetAppendPair(key, new_component);
      }
    public override void extraBusinessInformationQueriesNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "ntersection", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONIntersection(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBusinessInformationQueriesLocationNuggetSetField(key, new_component);
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
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
          }
        if (flagHasIntersection)
          {
            handler.start_pair("Intersection");
            if (partial_allowed)
                storeIntersection.write_partial_as_json(handler);
            else
                storeIntersection.write_as_json(handler);
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

    public static new BusinessInformationQueriesLocationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationQueriesLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesLocationNugget", ignore_extras);
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
    public static new BusinessInformationQueriesLocationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BusinessInformationQueriesLocationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationQueriesLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesLocationNugget", ignore_extras);
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
    public static new BusinessInformationQueriesLocationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BusinessInformationQueriesLocationNuggetJSON from_text(string text, bool ignore_extras)
      {
        BusinessInformationQueriesLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesLocationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BusinessInformationQueriesLocationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new BusinessInformationQueriesLocationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BusinessInformationQueriesLocationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesLocationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : BusinessInformationQueriesNuggetJSON.Generator
      {
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
        private MapLocationJSON.HoldingGenerator fieldGeneratorIntersection;
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
            if (!(getBusinessInformationQueriesNuggetJSONKey().Equals("Location")))
                throw new Exception("The key field has a value other than `Location'.");
            BusinessInformationQueriesLocationNuggetJSON result = new BusinessInformationQueriesLocationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBusinessInformationQueriesLocationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(BusinessInformationQueriesNuggetJSON new_result)
          {
            handle_result((BusinessInformationQueriesLocationNuggetJSON )new_result);
          }
        protected void finish(BusinessInformationQueriesLocationNuggetJSON result)
          {
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            if (fieldGeneratorIntersection.have_value)
              {
                result.setIntersection(fieldGeneratorIntersection.value);
                fieldGeneratorIntersection.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(BusinessInformationQueriesLocationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "ntersection", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorIntersection;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the BusinessInformationQueriesLocationNugget class", ignore_extras);
            fieldGeneratorIntersection = new MapLocationJSON.HoldingGenerator("field \"Intersection\" of the BusinessInformationQueriesLocationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BusinessInformationQueriesLocationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the BusinessInformationQueriesLocationNugget class", false);
            fieldGeneratorIntersection = new MapLocationJSON.HoldingGenerator("field \"Intersection\" of the BusinessInformationQueriesLocationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BusinessInformationQueriesLocationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorLocation.reset();
            fieldGeneratorIntersection.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(BusinessInformationQueriesLocationNuggetJSON  result)
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
        public BusinessInformationQueriesLocationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BusinessInformationQueriesLocationNuggetJSON  result)
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
    protected virtual void handle_result(List<BusinessInformationQueriesLocationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BusinessInformationQueriesLocationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BusinessInformationQueriesLocationNuggetJSON>();
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
    public List<BusinessInformationQueriesLocationNuggetJSON> value;
  };
  };
