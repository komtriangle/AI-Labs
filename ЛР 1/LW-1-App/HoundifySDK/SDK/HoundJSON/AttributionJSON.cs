/* file "AttributionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AttributionJSON : JSONBase
  {
    private bool flagHasLogoImageURL;
    private string storeLogoImageURL;
    private bool flagHasLogoImageGrayURL;
    private string storeLogoImageGrayURL;
    private bool flagHasLogoLabel;
    private string storeLogoLabel;
    private bool flagHasTextOnlyLabel;
    private string storeTextOnlyLabel;
    private bool flagHasProviderURL;
    private string storeProviderURL;
    private bool flagHasRequiredToIncludeInline;
    private bool storeRequiredToIncludeInline;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLogoImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LogoImageURL of AttributionJSON is not a string.");
        setLogoImageURL(json_string.getData());
      }


    private void  fromJSONLogoImageGrayURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LogoImageGrayURL of AttributionJSON is not a string.");
        setLogoImageGrayURL(json_string.getData());
      }


    private void  fromJSONLogoLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LogoLabel of AttributionJSON is not a string.");
        setLogoLabel(json_string.getData());
      }


    private void  fromJSONTextOnlyLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TextOnlyLabel of AttributionJSON is not a string.");
        setTextOnlyLabel(json_string.getData());
      }


    private void  fromJSONProviderURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ProviderURL of AttributionJSON is not a string.");
        setProviderURL(json_string.getData());
      }


    private void  fromJSONRequiredToIncludeInline(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field RequiredToIncludeInline of AttributionJSON is not true for false.");
              }
          }
        setRequiredToIncludeInline(the_bool);
      }


    public AttributionJSON()
      {
        flagHasLogoImageURL = false;
        flagHasLogoImageGrayURL = false;
        flagHasLogoLabel = false;
        flagHasTextOnlyLabel = false;
        flagHasProviderURL = false;
        flagHasRequiredToIncludeInline = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLogoImageURL()
      {
        return flagHasLogoImageURL;
      }

    public string  getLogoImageURL()
      {
        Debug.Assert(flagHasLogoImageURL);
        return storeLogoImageURL;
      }

    public bool  hasLogoImageGrayURL()
      {
        return flagHasLogoImageGrayURL;
      }

    public string  getLogoImageGrayURL()
      {
        Debug.Assert(flagHasLogoImageGrayURL);
        return storeLogoImageGrayURL;
      }

    public bool  hasLogoLabel()
      {
        return flagHasLogoLabel;
      }

    public string  getLogoLabel()
      {
        Debug.Assert(flagHasLogoLabel);
        return storeLogoLabel;
      }

    public bool  hasTextOnlyLabel()
      {
        return flagHasTextOnlyLabel;
      }

    public string  getTextOnlyLabel()
      {
        Debug.Assert(flagHasTextOnlyLabel);
        return storeTextOnlyLabel;
      }

    public bool  hasProviderURL()
      {
        return flagHasProviderURL;
      }

    public string  getProviderURL()
      {
        Debug.Assert(flagHasProviderURL);
        return storeProviderURL;
      }

    public bool  hasRequiredToIncludeInline()
      {
        return flagHasRequiredToIncludeInline;
      }

    public bool  getRequiredToIncludeInline()
      {
        Debug.Assert(flagHasRequiredToIncludeInline);
        return storeRequiredToIncludeInline;
      }


    public virtual int extraAttributionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAttributionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAttributionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAttributionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLogoImageURL(string new_value)
      {
        flagHasLogoImageURL = true;
        storeLogoImageURL = new_value;
      }
    public void unsetLogoImageURL()
      {
        flagHasLogoImageURL = false;
      }
    public void setLogoImageGrayURL(string new_value)
      {
        flagHasLogoImageGrayURL = true;
        storeLogoImageGrayURL = new_value;
      }
    public void unsetLogoImageGrayURL()
      {
        flagHasLogoImageGrayURL = false;
      }
    public void setLogoLabel(string new_value)
      {
        flagHasLogoLabel = true;
        storeLogoLabel = new_value;
      }
    public void unsetLogoLabel()
      {
        flagHasLogoLabel = false;
      }
    public void setTextOnlyLabel(string new_value)
      {
        flagHasTextOnlyLabel = true;
        storeTextOnlyLabel = new_value;
      }
    public void unsetTextOnlyLabel()
      {
        flagHasTextOnlyLabel = false;
      }
    public void setProviderURL(string new_value)
      {
        flagHasProviderURL = true;
        storeProviderURL = new_value;
      }
    public void unsetProviderURL()
      {
        flagHasProviderURL = false;
      }
    public void setRequiredToIncludeInline(bool new_value)
      {
        flagHasRequiredToIncludeInline = true;
        storeRequiredToIncludeInline = new_value;
      }
    public void unsetRequiredToIncludeInline()
      {
        flagHasRequiredToIncludeInline = false;
      }

    public virtual void extraAttributionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAttributionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAttributionLookup(key);
        if (old_field == null)
          {
            extraAttributionAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLogoImageURL);
        if (flagHasLogoImageURL)
          {
            handler.start_pair("LogoImageURL");
            handler.string_value(storeLogoImageURL);
          }
        if (flagHasLogoImageGrayURL)
          {
            handler.start_pair("LogoImageGrayURL");
            handler.string_value(storeLogoImageGrayURL);
          }
        if (flagHasLogoLabel)
          {
            handler.start_pair("LogoLabel");
            handler.string_value(storeLogoLabel);
          }
        if (flagHasTextOnlyLabel)
          {
            handler.start_pair("TextOnlyLabel");
            handler.string_value(storeTextOnlyLabel);
          }
        if (flagHasProviderURL)
          {
            handler.start_pair("ProviderURL");
            handler.string_value(storeProviderURL);
          }
        Debug.Assert(partial_allowed || flagHasRequiredToIncludeInline);
        if (flagHasRequiredToIncludeInline)
          {
            handler.start_pair("RequiredToIncludeInline");
            handler.boolean_value(storeRequiredToIncludeInline);
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
        if (!(hasLogoImageURL()))
          {
            return "When parsing the object for %what%, the \"LogoImageURL\" field was missing.";
          }
        if (!(hasRequiredToIncludeInline()))
          {
            return "When parsing the object for %what%, the \"RequiredToIncludeInline\" field was missing.";
          }
        return null;
      }

    public static AttributionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AttributionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Attribution", ignore_extras);
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
    public static AttributionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AttributionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AttributionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Attribution", ignore_extras);
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
    public static AttributionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AttributionJSON from_text(string text, bool ignore_extras)
      {
        AttributionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Attribution", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AttributionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AttributionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AttributionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Attribution", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorLogoImageURL;
        private JSONHoldingStringGenerator fieldGeneratorLogoImageGrayURL;
        private JSONHoldingStringGenerator fieldGeneratorLogoLabel;
        private JSONHoldingStringGenerator fieldGeneratorTextOnlyLabel;
        private JSONHoldingStringGenerator fieldGeneratorProviderURL;
        private JSONHoldingBooleanGenerator fieldGeneratorRequiredToIncludeInline;
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
            AttributionJSON result = new AttributionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAttributionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AttributionJSON result)
          {
            if (fieldGeneratorLogoImageURL.have_value)
              {
                result.setLogoImageURL(fieldGeneratorLogoImageURL.value);
                fieldGeneratorLogoImageURL.have_value = false;
              }
            else if ((!(result.hasLogoImageURL())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LogoImageURL\" field was missing.");
              }
            if (fieldGeneratorLogoImageGrayURL.have_value)
              {
                result.setLogoImageGrayURL(fieldGeneratorLogoImageGrayURL.value);
                fieldGeneratorLogoImageGrayURL.have_value = false;
              }
            if (fieldGeneratorLogoLabel.have_value)
              {
                result.setLogoLabel(fieldGeneratorLogoLabel.value);
                fieldGeneratorLogoLabel.have_value = false;
              }
            if (fieldGeneratorTextOnlyLabel.have_value)
              {
                result.setTextOnlyLabel(fieldGeneratorTextOnlyLabel.value);
                fieldGeneratorTextOnlyLabel.have_value = false;
              }
            if (fieldGeneratorProviderURL.have_value)
              {
                result.setProviderURL(fieldGeneratorProviderURL.value);
                fieldGeneratorProviderURL.have_value = false;
              }
            if (fieldGeneratorRequiredToIncludeInline.have_value)
              {
                result.setRequiredToIncludeInline(fieldGeneratorRequiredToIncludeInline.value);
                fieldGeneratorRequiredToIncludeInline.have_value = false;
              }
            else if ((!(result.hasRequiredToIncludeInline())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequiredToIncludeInline\" field was missing.");
              }
          }
        protected abstract void handle_result(AttributionJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if (String.Compare(field_name, 1, "ogo", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'I':
                                if (String.Compare(field_name, 5, "mage", 0, 4, false) == 0)
                                  {
                                    switch (field_name[9])
                                      {
                                        case 'G':
                                            if ((String.Compare(field_name, 10, "rayURL", 0, 6, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorLogoImageGrayURL;
                                            break;
                                        case 'U':
                                            if ((String.Compare(field_name, 10, "RL", 0, 2, false) == 0) && (field_name.Length == 12))
                                                return fieldGeneratorLogoImageURL;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 5, "abel", 0, 4, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorLogoLabel;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "roviderURL", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorProviderURL;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equiredToIncludeInline", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorRequiredToIncludeInline;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "extOnlyLabel", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorTextOnlyLabel;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLogoImageURL = new JSONHoldingStringGenerator("field \"LogoImageURL\" of the Attribution class");
            fieldGeneratorLogoImageGrayURL = new JSONHoldingStringGenerator("field \"LogoImageGrayURL\" of the Attribution class");
            fieldGeneratorLogoLabel = new JSONHoldingStringGenerator("field \"LogoLabel\" of the Attribution class");
            fieldGeneratorTextOnlyLabel = new JSONHoldingStringGenerator("field \"TextOnlyLabel\" of the Attribution class");
            fieldGeneratorProviderURL = new JSONHoldingStringGenerator("field \"ProviderURL\" of the Attribution class");
            fieldGeneratorRequiredToIncludeInline = new JSONHoldingBooleanGenerator("field \"RequiredToIncludeInline\" of the Attribution class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Attribution class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLogoImageURL = new JSONHoldingStringGenerator("field \"LogoImageURL\" of the Attribution class");
            fieldGeneratorLogoImageGrayURL = new JSONHoldingStringGenerator("field \"LogoImageGrayURL\" of the Attribution class");
            fieldGeneratorLogoLabel = new JSONHoldingStringGenerator("field \"LogoLabel\" of the Attribution class");
            fieldGeneratorTextOnlyLabel = new JSONHoldingStringGenerator("field \"TextOnlyLabel\" of the Attribution class");
            fieldGeneratorProviderURL = new JSONHoldingStringGenerator("field \"ProviderURL\" of the Attribution class");
            fieldGeneratorRequiredToIncludeInline = new JSONHoldingBooleanGenerator("field \"RequiredToIncludeInline\" of the Attribution class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Attribution class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLogoImageURL.reset();
            fieldGeneratorLogoImageGrayURL.reset();
            fieldGeneratorLogoLabel.reset();
            fieldGeneratorTextOnlyLabel.reset();
            fieldGeneratorProviderURL.reset();
            fieldGeneratorRequiredToIncludeInline.reset();
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
        protected override void handle_result(AttributionJSON  result)
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
        public AttributionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AttributionJSON  result)
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
    protected virtual void handle_result(List<AttributionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AttributionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AttributionJSON>();
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
    public List<AttributionJSON> value;
  };
  };
