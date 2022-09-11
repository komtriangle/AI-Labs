/* file "PropertyValueInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class PropertyValueInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasBase;
    private GeneralizedThingJSON  storeBase;
    private bool flagHasProperty;
    private PropertyJSON  storeProperty;
    private bool flagHasValueSpokenLabel;
    private string storeValueSpokenLabel;
    private bool flagHasValueWrittenLabel;
    private string storeValueWrittenLabel;


    private JSONValue  extraBaseToJSON()
      {
        JSONValueHandler handler_Base = new JSONValueHandler();
        storeBase.write_as_json(handler_Base);
        return handler_Base.result;
      }

    private JSONValue  extraPropertyToJSON()
      {
        JSONValueHandler handler_Property = new JSONValueHandler();
        storeProperty.write_as_json(handler_Property);
        return handler_Property.result;
      }

    private JSONValue  extraValueSpokenLabelToJSON()
      {
        JSONStringValue generated_string_ValueSpokenLabel = new JSONStringValue(storeValueSpokenLabel);
        return generated_string_ValueSpokenLabel;
      }

    private JSONValue  extraValueWrittenLabelToJSON()
      {
        JSONStringValue generated_string_ValueWrittenLabel = new JSONStringValue(storeValueWrittenLabel);
        return generated_string_ValueWrittenLabel;
      }


    private void  fromJSONBase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GeneralizedThingJSON convert_classy = GeneralizedThingJSON.from_json(json_value, ignore_extras, true);
        setBase(convert_classy);
      }


    private void  fromJSONProperty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PropertyJSON convert_classy = PropertyJSON.from_json(json_value, ignore_extras, true);
        setProperty(convert_classy);
      }


    private void  fromJSONValueSpokenLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ValueSpokenLabel of PropertyValueInformationNuggetJSON is not a string.");
        setValueSpokenLabel(json_string.getData());
      }


    private void  fromJSONValueWrittenLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ValueWrittenLabel of PropertyValueInformationNuggetJSON is not a string.");
        setValueWrittenLabel(json_string.getData());
      }


    public PropertyValueInformationNuggetJSON()
      {
        flagHasBase = false;
        flagHasProperty = false;
        flagHasValueSpokenLabel = false;
        flagHasValueWrittenLabel = false;
      }

    public override string  getNuggetKind()
      {
        return "PropertyValue";
      }

    public abstract string getPropertyValueKind();
    public bool  hasBase()
      {
        return flagHasBase;
      }

    public GeneralizedThingJSON   getBase()
      {
        Debug.Assert(flagHasBase);
        return storeBase;
      }

    public bool  hasProperty()
      {
        return flagHasProperty;
      }

    public PropertyJSON   getProperty()
      {
        Debug.Assert(flagHasProperty);
        return storeProperty;
      }

    public bool  hasValueSpokenLabel()
      {
        return flagHasValueSpokenLabel;
      }

    public string  getValueSpokenLabel()
      {
        Debug.Assert(flagHasValueSpokenLabel);
        return storeValueSpokenLabel;
      }

    public bool  hasValueWrittenLabel()
      {
        return flagHasValueWrittenLabel;
      }

    public string  getValueWrittenLabel()
      {
        Debug.Assert(flagHasValueWrittenLabel);
        return storeValueWrittenLabel;
      }


    public abstract int extraPropertyValueInformationNuggetComponentCount();
    public abstract string extraPropertyValueInformationNuggetComponentKey(int component_num);
    public abstract JSONValue extraPropertyValueInformationNuggetComponentValue(int component_num);
    public abstract JSONValue extraPropertyValueInformationNuggetLookup(string field_name);
    public override int extraInformationNuggetComponentCount()
      {
        int result = 1;
        if (flagHasBase)
            ++result;
        if (flagHasProperty)
            ++result;
        if (flagHasValueSpokenLabel)
            ++result;
        if (flagHasValueWrittenLabel)
            ++result;
        result += extraPropertyValueInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "PropertyValueKind";
        int remainder = (component_num - 1);
        if (flagHasBase)
          {
            if (remainder == 0)
                return "Base";
            --remainder;
          }
        if (flagHasProperty)
          {
            if (remainder == 0)
                return "Property";
            --remainder;
          }
        if (flagHasValueSpokenLabel)
          {
            if (remainder == 0)
                return "ValueSpokenLabel";
            --remainder;
          }
        if (flagHasValueWrittenLabel)
          {
            if (remainder == 0)
                return "ValueWrittenLabel";
            --remainder;
          }
        return extraPropertyValueInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getPropertyValueKind());
        int remainder = (component_num - 1);
        if (flagHasBase)
          {
            if (remainder == 0)
                return extraBaseToJSON();
            --remainder;
          }
        if (flagHasProperty)
          {
            if (remainder == 0)
                return extraPropertyToJSON();
            --remainder;
          }
        if (flagHasValueSpokenLabel)
          {
            if (remainder == 0)
                return extraValueSpokenLabelToJSON();
            --remainder;
          }
        if (flagHasValueWrittenLabel)
          {
            if (remainder == 0)
                return extraValueWrittenLabelToJSON();
            --remainder;
          }
        return extraPropertyValueInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'B':
                if ((String.Compare(field_name, 1, "ase", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasBase ? extraBaseToJSON() : null);
                break;
            case 'P':
                if (String.Compare(field_name, 1, "roperty", 0, 7, false) == 0)
                  {
                    if (field_name.Length == 8)
                      {
                        return (flagHasProperty ? extraPropertyToJSON() : null);
                      }
                    switch (field_name[8])
                      {
                        case 'V':
                            if ((String.Compare(field_name, 9, "alueKind", 0, 8, false) == 0) && (field_name.Length == 17))
                                return new JSONStringValue(getPropertyValueKind());
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if (String.Compare(field_name, 1, "alue", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'S':
                            if ((String.Compare(field_name, 6, "pokenLabel", 0, 10, false) == 0) && (field_name.Length == 16))
                                return (flagHasValueSpokenLabel ? extraValueSpokenLabelToJSON() : null);
                            break;
                        case 'W':
                            if ((String.Compare(field_name, 6, "rittenLabel", 0, 11, false) == 0) && (field_name.Length == 17))
                                return (flagHasValueWrittenLabel ? extraValueWrittenLabelToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraPropertyValueInformationNuggetLookup(field_name);
      }

    public void setBase(GeneralizedThingJSON  new_value)
      {
        if (flagHasBase)
          {
          }
        flagHasBase = true;
        storeBase = new_value;
      }
    public void unsetBase()
      {
        if (flagHasBase)
          {
          }
        flagHasBase = false;
      }
    public void setProperty(PropertyJSON  new_value)
      {
        if (flagHasProperty)
          {
          }
        flagHasProperty = true;
        storeProperty = new_value;
      }
    public void unsetProperty()
      {
        if (flagHasProperty)
          {
          }
        flagHasProperty = false;
      }
    public void setValueSpokenLabel(string new_value)
      {
        flagHasValueSpokenLabel = true;
        storeValueSpokenLabel = new_value;
      }
    public void unsetValueSpokenLabel()
      {
        flagHasValueSpokenLabel = false;
      }
    public void setValueWrittenLabel(string new_value)
      {
        flagHasValueWrittenLabel = true;
        storeValueWrittenLabel = new_value;
      }
    public void unsetValueWrittenLabel()
      {
        flagHasValueWrittenLabel = false;
      }

    public abstract void extraPropertyValueInformationNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraPropertyValueInformationNuggetSetField(string key, JSONValue new_component);
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "ase", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONBase(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "roperty", 0, 7, false) == 0)
                  {
                    if (key.Length == 8)
                      {
                        {
                        fromJSONProperty(new_component, false);
                        return;
                        }
                      }
                    switch (key[8])
                      {
                        case 'V':
                            if ((String.Compare(key, 9, "alueKind", 0, 8, false) == 0) && (key.Length == 17))
                                return;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if (String.Compare(key, 1, "alue", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'S':
                            if ((String.Compare(key, 6, "pokenLabel", 0, 10, false) == 0) && (key.Length == 16))
                                {
                                fromJSONValueSpokenLabel(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 6, "rittenLabel", 0, 11, false) == 0) && (key.Length == 17))
                                {
                                fromJSONValueWrittenLabel(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraPropertyValueInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "ase", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONBase(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "roperty", 0, 7, false) == 0)
                  {
                    if (key.Length == 8)
                      {
                        {
                        fromJSONProperty(new_component, false);
                        return;
                        }
                      }
                    switch (key[8])
                      {
                        case 'V':
                            if ((String.Compare(key, 9, "alueKind", 0, 8, false) == 0) && (key.Length == 17))
                                return;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if (String.Compare(key, 1, "alue", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'S':
                            if ((String.Compare(key, 6, "pokenLabel", 0, 10, false) == 0) && (key.Length == 16))
                                {
                                fromJSONValueSpokenLabel(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 6, "rittenLabel", 0, 11, false) == 0) && (key.Length == 17))
                                {
                                fromJSONValueWrittenLabel(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraPropertyValueInformationNuggetSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("PropertyValueKind", getPropertyValueKind());
        Debug.Assert(partial_allowed || flagHasBase);
        if (flagHasBase)
          {
            handler.start_pair("Base");
            if (partial_allowed)
                storeBase.write_partial_as_json(handler);
            else
                storeBase.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasProperty);
        if (flagHasProperty)
          {
            handler.start_pair("Property");
            if (partial_allowed)
                storeProperty.write_partial_as_json(handler);
            else
                storeProperty.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasValueSpokenLabel);
        if (flagHasValueSpokenLabel)
          {
            handler.start_pair("ValueSpokenLabel");
            handler.string_value(storeValueSpokenLabel);
          }
        Debug.Assert(partial_allowed || flagHasValueWrittenLabel);
        if (flagHasValueWrittenLabel)
          {
            handler.start_pair("ValueWrittenLabel");
            handler.string_value(storeValueWrittenLabel);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasBase()))
          {
            return "When parsing the object for %what%, the \"Base\" field was missing.";
          }
        if (!(hasProperty()))
          {
            return "When parsing the object for %what%, the \"Property\" field was missing.";
          }
        if (!(hasValueSpokenLabel()))
          {
            return "When parsing the object for %what%, the \"ValueSpokenLabel\" field was missing.";
          }
        if (!(hasValueWrittenLabel()))
          {
            return "When parsing the object for %what%, the \"ValueWrittenLabel\" field was missing.";
          }
        return null;
      }

    public static new PropertyValueInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PropertyValueInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PropertyValueInformationNugget", ignore_extras);
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
    public static new PropertyValueInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PropertyValueInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PropertyValueInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PropertyValueInformationNugget", ignore_extras);
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
    public static new PropertyValueInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PropertyValueInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        PropertyValueInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PropertyValueInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PropertyValueInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PropertyValueInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PropertyValueInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PropertyValueInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private GeneralizedThingJSON.HoldingGenerator fieldGeneratorBase;
        private PropertyJSON.HoldingGenerator fieldGeneratorProperty;
        private JSONHoldingStringGenerator fieldGeneratorValueSpokenLabel;
        private JSONHoldingStringGenerator fieldGeneratorValueWrittenLabel;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `PropertyValueKind' field is missing.");
            if (!(getInformationNuggetJSONKey().Equals("PropertyValue")))
                throw new Exception("The key field has a value other than `PropertyValue'.");
            PropertyValueInformationNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPropertyValueInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getPropertyValueInformationNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `PropertyValueKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((PropertyValueInformationNuggetJSON )new_result);
          }
        protected void finish(PropertyValueInformationNuggetJSON result)
          {
            if (fieldGeneratorBase.have_value)
              {
                result.setBase(fieldGeneratorBase.value);
                fieldGeneratorBase.have_value = false;
              }
            else if ((!(result.hasBase())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Base\" field was missing.");
              }
            if (fieldGeneratorProperty.have_value)
              {
                result.setProperty(fieldGeneratorProperty.value);
                fieldGeneratorProperty.have_value = false;
              }
            else if ((!(result.hasProperty())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Property\" field was missing.");
              }
            if (fieldGeneratorValueSpokenLabel.have_value)
              {
                result.setValueSpokenLabel(fieldGeneratorValueSpokenLabel.value);
                fieldGeneratorValueSpokenLabel.have_value = false;
              }
            else if ((!(result.hasValueSpokenLabel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ValueSpokenLabel\" field was missing.");
              }
            if (fieldGeneratorValueWrittenLabel.have_value)
              {
                result.setValueWrittenLabel(fieldGeneratorValueWrittenLabel.value);
                fieldGeneratorValueWrittenLabel.have_value = false;
              }
            else if ((!(result.hasValueWrittenLabel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ValueWrittenLabel\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(PropertyValueInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "ase", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorBase;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "roperty", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorProperty;
                          }
                        switch (field_name[8])
                          {
                            case 'V':
                                if ((String.Compare(field_name, 9, "alueKind", 0, 8, false) == 0) && (field_name.Length == 17))
                                    {
                                    keyGenerator.reset();
                                    return keyGenerator;
                                    }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'V':
                    if (String.Compare(field_name, 1, "alue", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 6, "pokenLabel", 0, 10, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorValueSpokenLabel;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 6, "rittenLabel", 0, 11, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorValueWrittenLabel;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorBase = new GeneralizedThingJSON.HoldingGenerator("field \"Base\" of the PropertyValueInformationNugget class", ignore_extras);
            fieldGeneratorProperty = new PropertyJSON.HoldingGenerator("field \"Property\" of the PropertyValueInformationNugget class", ignore_extras);
            fieldGeneratorValueSpokenLabel = new JSONHoldingStringGenerator("field \"ValueSpokenLabel\" of the PropertyValueInformationNugget class");
            fieldGeneratorValueWrittenLabel = new JSONHoldingStringGenerator("field \"ValueWrittenLabel\" of the PropertyValueInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"PropertyValueKind\" of the PropertyValueInformationNugget class");
            set_what("the PropertyValueInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorBase = new GeneralizedThingJSON.HoldingGenerator("field \"Base\" of the PropertyValueInformationNugget class", false);
            fieldGeneratorProperty = new PropertyJSON.HoldingGenerator("field \"Property\" of the PropertyValueInformationNugget class", false);
            fieldGeneratorValueSpokenLabel = new JSONHoldingStringGenerator("field \"ValueSpokenLabel\" of the PropertyValueInformationNugget class");
            fieldGeneratorValueWrittenLabel = new JSONHoldingStringGenerator("field \"ValueWrittenLabel\" of the PropertyValueInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"PropertyValueKind\" of the PropertyValueInformationNugget class");
            set_what("the PropertyValueInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorBase.reset();
            fieldGeneratorProperty.reset();
            fieldGeneratorValueSpokenLabel.reset();
            fieldGeneratorValueWrittenLabel.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PropertyValueInformationNuggetJSON  result)
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
        public PropertyValueInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PropertyValueInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<PropertyValueInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PropertyValueInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PropertyValueInformationNuggetJSON>();
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
    public List<PropertyValueInformationNuggetJSON> value;
  };
    class GenericPropertyValueInformationNuggetJSON : PropertyValueInformationNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericPropertyValueInformationNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getPropertyValueKind()  { return key; }
        public override int extraPropertyValueInformationNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraPropertyValueInformationNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraPropertyValueInformationNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraPropertyValueInformationNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraPropertyValueInformationNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraPropertyValueInformationNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraPropertyValueInformationNuggetLookup(key);
            if (old_field == null)
              {
                extraPropertyValueInformationNuggetAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new PropertyValueInformationNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if ((String.Compare(key, 0, "AmountProperty", 0, 14, false) == 0) && (key.Length == 14))
        return new AmountPropertyInformationNuggetJSON();

        return new GenericPropertyValueInformationNuggetJSON(key);
      }
  };
