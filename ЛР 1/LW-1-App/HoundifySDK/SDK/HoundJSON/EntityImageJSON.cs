/* file "EntityImageJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EntityImageJSON : JSONBase
  {
    private bool flagHasURL;
    private string storeURL;
    private bool flagHasThumbnailURL;
    private string storeThumbnailURL;
    private bool flagHasLabel;
    private string storeLabel;
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field URL of EntityImageJSON is not a string.");
        setURL(json_string.getData());
      }


    private void  fromJSONThumbnailURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ThumbnailURL of EntityImageJSON is not a string.");
        setThumbnailURL(json_string.getData());
      }


    private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Label of EntityImageJSON is not a string.");
        setLabel(json_string.getData());
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    public EntityImageJSON()
      {
        flagHasURL = false;
        flagHasThumbnailURL = false;
        flagHasLabel = false;
        flagHasAttribution = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasURL()
      {
        return flagHasURL;
      }

    public string  getURL()
      {
        Debug.Assert(flagHasURL);
        return storeURL;
      }

    public bool  hasThumbnailURL()
      {
        return flagHasThumbnailURL;
      }

    public string  getThumbnailURL()
      {
        Debug.Assert(flagHasThumbnailURL);
        return storeThumbnailURL;
      }

    public bool  hasLabel()
      {
        return flagHasLabel;
      }

    public string  getLabel()
      {
        Debug.Assert(flagHasLabel);
        return storeLabel;
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public AttributionJSON   getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }


    public virtual int extraEntityImageComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraEntityImageComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraEntityImageComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraEntityImageLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setURL(string new_value)
      {
        flagHasURL = true;
        storeURL = new_value;
      }
    public void unsetURL()
      {
        flagHasURL = false;
      }
    public void setThumbnailURL(string new_value)
      {
        flagHasThumbnailURL = true;
        storeThumbnailURL = new_value;
      }
    public void unsetThumbnailURL()
      {
        flagHasThumbnailURL = false;
      }
    public void setLabel(string new_value)
      {
        flagHasLabel = true;
        storeLabel = new_value;
      }
    public void unsetLabel()
      {
        flagHasLabel = false;
      }
    public void setAttribution(AttributionJSON  new_value)
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = false;
      }

    public virtual void extraEntityImageAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraEntityImageSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraEntityImageLookup(key);
        if (old_field == null)
          {
            extraEntityImageAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasURL);
        if (flagHasURL)
          {
            handler.start_pair("URL");
            handler.string_value(storeURL);
          }
        if (flagHasThumbnailURL)
          {
            handler.start_pair("ThumbnailURL");
            handler.string_value(storeThumbnailURL);
          }
        if (flagHasLabel)
          {
            handler.start_pair("Label");
            handler.string_value(storeLabel);
          }
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
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
        if (!(hasURL()))
          {
            return "When parsing the object for %what%, the \"URL\" field was missing.";
          }
        return null;
      }

    public static EntityImageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EntityImageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntityImage", ignore_extras);
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
    public static EntityImageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EntityImageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EntityImageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntityImage", ignore_extras);
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
    public static EntityImageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EntityImageJSON from_text(string text, bool ignore_extras)
      {
        EntityImageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntityImage", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EntityImageJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static EntityImageJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EntityImageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntityImage", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorURL;
        private JSONHoldingStringGenerator fieldGeneratorThumbnailURL;
        private JSONHoldingStringGenerator fieldGeneratorLabel;
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
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
            EntityImageJSON result = new EntityImageJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraEntityImageAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(EntityImageJSON result)
          {
            if (fieldGeneratorURL.have_value)
              {
                result.setURL(fieldGeneratorURL.value);
                fieldGeneratorURL.have_value = false;
              }
            else if ((!(result.hasURL())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"URL\" field was missing.");
              }
            if (fieldGeneratorThumbnailURL.have_value)
              {
                result.setThumbnailURL(fieldGeneratorThumbnailURL.value);
                fieldGeneratorThumbnailURL.have_value = false;
              }
            if (fieldGeneratorLabel.have_value)
              {
                result.setLabel(fieldGeneratorLabel.value);
                fieldGeneratorLabel.have_value = false;
              }
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
          }
        protected abstract void handle_result(EntityImageJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAttribution;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorLabel;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "humbnailURL", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorThumbnailURL;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "RL", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorURL;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the EntityImage class");
            fieldGeneratorThumbnailURL = new JSONHoldingStringGenerator("field \"ThumbnailURL\" of the EntityImage class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the EntityImage class");
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the EntityImage class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the EntityImage class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the EntityImage class");
            fieldGeneratorThumbnailURL = new JSONHoldingStringGenerator("field \"ThumbnailURL\" of the EntityImage class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the EntityImage class");
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the EntityImage class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the EntityImage class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorURL.reset();
            fieldGeneratorThumbnailURL.reset();
            fieldGeneratorLabel.reset();
            fieldGeneratorAttribution.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAttribution.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAttribution.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(EntityImageJSON  result)
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
        public EntityImageJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EntityImageJSON  result)
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
    protected virtual void handle_result(List<EntityImageJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EntityImageJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EntityImageJSON>();
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
    public List<EntityImageJSON> value;
  };
  };
