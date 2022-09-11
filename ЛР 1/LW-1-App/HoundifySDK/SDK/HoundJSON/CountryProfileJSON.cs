/* file "CountryProfileJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CountryProfileJSON : MapLocationJSON
  {
    private bool flagHasDescription;
    private WrittenSpokenStringJSON  storeDescription;
    private bool flagHasPrimaryImage;
    private EntityImageJSON  storePrimaryImage;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDescriptionToJSON()
      {
        JSONValueHandler handler_Description = new JSONValueHandler();
        storeDescription.write_as_json(handler_Description);
        return handler_Description.result;
      }

    private JSONValue  extraPrimaryImageToJSON()
      {
        JSONValueHandler handler_PrimaryImage = new JSONValueHandler();
        storePrimaryImage.write_as_json(handler_PrimaryImage);
        return handler_PrimaryImage.result;
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WrittenSpokenStringJSON convert_classy = WrittenSpokenStringJSON.from_json(json_value, ignore_extras, true);
        setDescription(convert_classy);
      }


    private void  fromJSONPrimaryImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EntityImageJSON convert_classy = EntityImageJSON.from_json(json_value, ignore_extras, true);
        setPrimaryImage(convert_classy);
      }


    public CountryProfileJSON()
      {
        flagHasDescription = false;
        flagHasPrimaryImage = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDescription()
      {
        return flagHasDescription;
      }

    public WrittenSpokenStringJSON   getDescription()
      {
        Debug.Assert(flagHasDescription);
        return storeDescription;
      }

    public bool  hasPrimaryImage()
      {
        return flagHasPrimaryImage;
      }

    public EntityImageJSON   getPrimaryImage()
      {
        Debug.Assert(flagHasPrimaryImage);
        return storePrimaryImage;
      }


    public virtual int extraCountryProfileComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCountryProfileComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCountryProfileComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCountryProfileLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMapLocationComponentCount()
      {
        int result = 0;
        if (flagHasDescription)
            ++result;
        if (flagHasPrimaryImage)
            ++result;
        result += extraCountryProfileComponentCount();
        return result;
      }
    public override string extraMapLocationComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDescription)
          {
            if (remainder == 0)
                return "Description";
            --remainder;
          }
        if (flagHasPrimaryImage)
          {
            if (remainder == 0)
                return "PrimaryImage";
            --remainder;
          }
        return extraCountryProfileComponentKey(remainder);
      }
    public override JSONValue extraMapLocationComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDescription)
          {
            if (remainder == 0)
                return extraDescriptionToJSON();
            --remainder;
          }
        if (flagHasPrimaryImage)
          {
            if (remainder == 0)
                return extraPrimaryImageToJSON();
            --remainder;
          }
        return extraCountryProfileComponentValue(remainder);
      }
    public override JSONValue extraMapLocationLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasDescription ? extraDescriptionToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "rimaryImage", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasPrimaryImage ? extraPrimaryImageToJSON() : null);
                break;
            default:
                break;
          }
        return extraCountryProfileLookup(field_name);
      }

    public void setDescription(WrittenSpokenStringJSON  new_value)
      {
        if (flagHasDescription)
          {
          }
        flagHasDescription = true;
        storeDescription = new_value;
      }
    public void unsetDescription()
      {
        if (flagHasDescription)
          {
          }
        flagHasDescription = false;
      }
    public void setPrimaryImage(EntityImageJSON  new_value)
      {
        if (flagHasPrimaryImage)
          {
          }
        flagHasPrimaryImage = true;
        storePrimaryImage = new_value;
      }
    public void unsetPrimaryImage()
      {
        if (flagHasPrimaryImage)
          {
          }
        flagHasPrimaryImage = false;
      }

    public virtual void extraCountryProfileAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCountryProfileSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCountryProfileLookup(key);
        if (old_field == null)
          {
            extraCountryProfileAppendPair(key, new_component);
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
            case 'D':
                if ((String.Compare(key, 1, "escription", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONDescription(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rimaryImage", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONPrimaryImage(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCountryProfileAppendPair(key, new_component);
      }
    public override void extraMapLocationSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "escription", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONDescription(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rimaryImage", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONPrimaryImage(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCountryProfileSetField(key, new_component);
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
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            if (partial_allowed)
                storeDescription.write_partial_as_json(handler);
            else
                storeDescription.write_as_json(handler);
          }
        if (flagHasPrimaryImage)
          {
            handler.start_pair("PrimaryImage");
            if (partial_allowed)
                storePrimaryImage.write_partial_as_json(handler);
            else
                storePrimaryImage.write_as_json(handler);
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

    public static new CountryProfileJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CountryProfileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CountryProfile", ignore_extras);
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
    public static new CountryProfileJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CountryProfileJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CountryProfileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CountryProfile", ignore_extras);
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
    public static new CountryProfileJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CountryProfileJSON from_text(string text, bool ignore_extras)
      {
        CountryProfileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CountryProfile", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CountryProfileJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CountryProfileJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CountryProfileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CountryProfile", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MapLocationJSON.Generator
      {
        private WrittenSpokenStringJSON.HoldingGenerator fieldGeneratorDescription;
        private EntityImageJSON.HoldingGenerator fieldGeneratorPrimaryImage;
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
            CountryProfileJSON result = new CountryProfileJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCountryProfileAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MapLocationJSON new_result)
          {
            handle_result((CountryProfileJSON )new_result);
          }
        protected void finish(CountryProfileJSON result)
          {
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorPrimaryImage.have_value)
              {
                result.setPrimaryImage(fieldGeneratorPrimaryImage.value);
                fieldGeneratorPrimaryImage.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CountryProfileJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDescription;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rimaryImage", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorPrimaryImage;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDescription = new WrittenSpokenStringJSON.HoldingGenerator("field \"Description\" of the CountryProfile class", ignore_extras);
            fieldGeneratorPrimaryImage = new EntityImageJSON.HoldingGenerator("field \"PrimaryImage\" of the CountryProfile class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CountryProfile class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDescription = new WrittenSpokenStringJSON.HoldingGenerator("field \"Description\" of the CountryProfile class", false);
            fieldGeneratorPrimaryImage = new EntityImageJSON.HoldingGenerator("field \"PrimaryImage\" of the CountryProfile class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CountryProfile class");
          }

        public override void reset()
          {
            fieldGeneratorDescription.reset();
            fieldGeneratorPrimaryImage.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CountryProfileJSON  result)
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
        public CountryProfileJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CountryProfileJSON  result)
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
    protected virtual void handle_result(List<CountryProfileJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CountryProfileJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CountryProfileJSON>();
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
    public List<CountryProfileJSON> value;
  };
    public static CountryProfileJSON from_MapLocationJSON_json(MapLocationJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        CountryProfileJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type CountryProfile", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
