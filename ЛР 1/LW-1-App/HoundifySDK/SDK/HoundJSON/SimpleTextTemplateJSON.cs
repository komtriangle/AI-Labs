/* file "SimpleTextTemplateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SimpleTextTemplateJSON : TemplateJSON
  {
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasSubtitle;
    private string storeSubtitle;
    private bool flagHasFooter;
    private string storeFooter;
    private bool flagHasActionAndroidIntent;
    private AndroidIntentJSON  storeActionAndroidIntent;
    private bool flagHasActionURIs;
    private List< string > storeActionURIs;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraTitleToJSON()
      {
        JSONStringValue generated_string_Title = new JSONStringValue(storeTitle);
        return generated_string_Title;
      }

    private JSONValue  extraSubtitleToJSON()
      {
        JSONStringValue generated_string_Subtitle = new JSONStringValue(storeSubtitle);
        return generated_string_Subtitle;
      }

    private JSONValue  extraFooterToJSON()
      {
        JSONStringValue generated_string_Footer = new JSONStringValue(storeFooter);
        return generated_string_Footer;
      }

    private JSONValue  extraActionAndroidIntentToJSON()
      {
        JSONValueHandler handler_ActionAndroidIntent = new JSONValueHandler();
        storeActionAndroidIntent.write_as_json(handler_ActionAndroidIntent);
        return handler_ActionAndroidIntent.result;
      }

    private JSONValue  extraActionURIsToJSON()
      {
        JSONArrayValue generated_array_1_ActionURIs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeActionURIs.Count; ++num1)
          {
            JSONStringValue generated_string_ActionURIs = new JSONStringValue(storeActionURIs[num1]);
            generated_array_1_ActionURIs.appendComponent(generated_string_ActionURIs);
          }
        return generated_array_1_ActionURIs;
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of SimpleTextTemplateJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONSubtitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Subtitle of SimpleTextTemplateJSON is not a string.");
        setSubtitle(json_string.getData());
      }


    private void  fromJSONFooter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Footer of SimpleTextTemplateJSON is not a string.");
        setFooter(json_string.getData());
      }


    private void  fromJSONActionAndroidIntent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AndroidIntentJSON convert_classy = AndroidIntentJSON.from_json(json_value, ignore_extras, true);
        setActionAndroidIntent(convert_classy);
      }


    private void  fromJSONActionURIs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ActionURIs of SimpleTextTemplateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ActionURIs of SimpleTextTemplateJSON has too few elements.");
        List< string > vector_ActionURIs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ActionURIs of SimpleTextTemplateJSON is not a string.");
            vector_ActionURIs1.Add(json_string.getData());
          }
        Debug.Assert(vector_ActionURIs1.Count >= 1);
        initActionURIs();
        for (int num1 = 0; num1 < vector_ActionURIs1.Count; ++num1)
            appendActionURIs(vector_ActionURIs1[num1]);
        for (int num1 = 0; num1 < vector_ActionURIs1.Count; ++num1)
          {
          }
      }


    public SimpleTextTemplateJSON()
      {
        flagHasTitle = false;
        flagHasSubtitle = false;
        flagHasFooter = false;
        flagHasActionAndroidIntent = false;
        flagHasActionURIs = false;
        storeTitle = "";
        storeSubtitle = "";
        storeFooter = "";
        storeActionURIs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTemplateName()
      {
        return "SimpleText";
      }

    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        return storeTitle;
      }

    public bool  hasSubtitle()
      {
        return flagHasSubtitle;
      }

    public string  getSubtitle()
      {
        return storeSubtitle;
      }

    public bool  hasFooter()
      {
        return flagHasFooter;
      }

    public string  getFooter()
      {
        return storeFooter;
      }

    public bool  hasActionAndroidIntent()
      {
        return flagHasActionAndroidIntent;
      }

    public AndroidIntentJSON   getActionAndroidIntent()
      {
        Debug.Assert(flagHasActionAndroidIntent);
        return storeActionAndroidIntent;
      }

    public bool  hasActionURIs()
      {
        return flagHasActionURIs;
      }

    public int  countOfActionURIs()
      {
        Debug.Assert(flagHasActionURIs);
        return storeActionURIs.Count;
      }

    public string  elementOfActionURIs(int element_num)
      {
        Debug.Assert(flagHasActionURIs);
        return storeActionURIs[element_num];
      }

    public List< string >  getActionURIs()
      {
        Debug.Assert(flagHasActionURIs);
        return storeActionURIs;
      }


    public virtual int extraSimpleTextTemplateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSimpleTextTemplateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSimpleTextTemplateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSimpleTextTemplateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTemplateComponentCount()
      {
        int result = 0;
        if (flagHasTitle)
            ++result;
        if (flagHasSubtitle)
            ++result;
        if (flagHasFooter)
            ++result;
        if (flagHasActionAndroidIntent)
            ++result;
        if (flagHasActionURIs)
            ++result;
        result += extraSimpleTextTemplateComponentCount();
        return result;
      }
    public override string extraTemplateComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasTitle)
          {
            if (remainder == 0)
                return "Title";
            --remainder;
          }
        if (flagHasSubtitle)
          {
            if (remainder == 0)
                return "Subtitle";
            --remainder;
          }
        if (flagHasFooter)
          {
            if (remainder == 0)
                return "Footer";
            --remainder;
          }
        if (flagHasActionAndroidIntent)
          {
            if (remainder == 0)
                return "ActionAndroidIntent";
            --remainder;
          }
        if (flagHasActionURIs)
          {
            if (remainder == 0)
                return "ActionURIs";
            --remainder;
          }
        return extraSimpleTextTemplateComponentKey(remainder);
      }
    public override JSONValue extraTemplateComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasTitle)
          {
            if (remainder == 0)
                return extraTitleToJSON();
            --remainder;
          }
        if (flagHasSubtitle)
          {
            if (remainder == 0)
                return extraSubtitleToJSON();
            --remainder;
          }
        if (flagHasFooter)
          {
            if (remainder == 0)
                return extraFooterToJSON();
            --remainder;
          }
        if (flagHasActionAndroidIntent)
          {
            if (remainder == 0)
                return extraActionAndroidIntentToJSON();
            --remainder;
          }
        if (flagHasActionURIs)
          {
            if (remainder == 0)
                return extraActionURIsToJSON();
            --remainder;
          }
        return extraSimpleTextTemplateComponentValue(remainder);
      }
    public override JSONValue extraTemplateLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if (String.Compare(field_name, 1, "ction", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 7, "ndroidIntent", 0, 12, false) == 0) && (field_name.Length == 19))
                                return (flagHasActionAndroidIntent ? extraActionAndroidIntentToJSON() : null);
                            break;
                        case 'U':
                            if ((String.Compare(field_name, 7, "RIs", 0, 3, false) == 0) && (field_name.Length == 10))
                                return (flagHasActionURIs ? extraActionURIsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "ooter", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasFooter ? extraFooterToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "ubtitle", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasSubtitle ? extraSubtitleToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasTitle ? extraTitleToJSON() : null);
                break;
            default:
                break;
          }
        return extraSimpleTextTemplateLookup(field_name);
      }

    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setSubtitle(string new_value)
      {
        flagHasSubtitle = true;
        storeSubtitle = new_value;
      }
    public void unsetSubtitle()
      {
        flagHasSubtitle = false;
      }
    public void setFooter(string new_value)
      {
        flagHasFooter = true;
        storeFooter = new_value;
      }
    public void unsetFooter()
      {
        flagHasFooter = false;
      }
    public void setActionAndroidIntent(AndroidIntentJSON  new_value)
      {
        if (flagHasActionAndroidIntent)
          {
          }
        flagHasActionAndroidIntent = true;
        storeActionAndroidIntent = new_value;
      }
    public void unsetActionAndroidIntent()
      {
        if (flagHasActionAndroidIntent)
          {
          }
        flagHasActionAndroidIntent = false;
      }
    public void initActionURIs()
      {
        flagHasActionURIs = true;
        storeActionURIs.Clear();
      }
    public void appendActionURIs(string to_append)
      {
        if (!flagHasActionURIs)
          {
            flagHasActionURIs = true;
            storeActionURIs.Clear();
          }
        Debug.Assert(flagHasActionURIs);
        storeActionURIs.Add(to_append);
      }
    public void unsetActionURIs()
      {
        flagHasActionURIs = false;
        storeActionURIs.Clear();
      }

    public virtual void extraSimpleTextTemplateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSimpleTextTemplateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSimpleTextTemplateLookup(key);
        if (old_field == null)
          {
            extraSimpleTextTemplateAppendPair(key, new_component);
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
    public override void extraTemplateAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if (String.Compare(key, 1, "ction", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'A':
                            if ((String.Compare(key, 7, "ndroidIntent", 0, 12, false) == 0) && (key.Length == 19))
                                {
                                fromJSONActionAndroidIntent(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 7, "RIs", 0, 3, false) == 0) && (key.Length == 10))
                                {
                                fromJSONActionURIs(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ooter", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONFooter(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ubtitle", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONSubtitle(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "itle", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONTitle(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSimpleTextTemplateAppendPair(key, new_component);
      }
    public override void extraTemplateSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if (String.Compare(key, 1, "ction", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'A':
                            if ((String.Compare(key, 7, "ndroidIntent", 0, 12, false) == 0) && (key.Length == 19))
                                {
                                fromJSONActionAndroidIntent(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 7, "RIs", 0, 3, false) == 0) && (key.Length == 10))
                                {
                                fromJSONActionURIs(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ooter", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONFooter(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ubtitle", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONSubtitle(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "itle", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONTitle(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSimpleTextTemplateSetField(key, new_component);
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
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasSubtitle)
          {
            handler.start_pair("Subtitle");
            handler.string_value(storeSubtitle);
          }
        if (flagHasFooter)
          {
            handler.start_pair("Footer");
            handler.string_value(storeFooter);
          }
        if (flagHasActionAndroidIntent)
          {
            handler.start_pair("ActionAndroidIntent");
            if (partial_allowed)
                storeActionAndroidIntent.write_partial_as_json(handler);
            else
                storeActionAndroidIntent.write_as_json(handler);
          }
        if (flagHasActionURIs)
          {
            handler.start_pair("ActionURIs");
            Debug.Assert(storeActionURIs.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeActionURIs.Count; ++num1)
              {
                handler.string_value(storeActionURIs[num1]);
              }
            handler.finish_array();
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

    public static new SimpleTextTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SimpleTextTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SimpleTextTemplate", ignore_extras);
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
    public static new SimpleTextTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SimpleTextTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SimpleTextTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SimpleTextTemplate", ignore_extras);
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
    public static new SimpleTextTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SimpleTextTemplateJSON from_text(string text, bool ignore_extras)
      {
        SimpleTextTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SimpleTextTemplate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SimpleTextTemplateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SimpleTextTemplateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SimpleTextTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SimpleTextTemplate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TemplateJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorSubtitle;
        private JSONHoldingStringGenerator fieldGeneratorFooter;
        private AndroidIntentJSON.HoldingGenerator fieldGeneratorActionAndroidIntent;
        private JSONHoldingStringArrayGenerator fieldGeneratorActionURIs;
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
            if (!(getTemplateJSONKey().Equals("SimpleText")))
                throw new Exception("The key field has a value other than `SimpleText'.");
            SimpleTextTemplateJSON result = new SimpleTextTemplateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSimpleTextTemplateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TemplateJSON new_result)
          {
            handle_result((SimpleTextTemplateJSON )new_result);
          }
        protected void finish(SimpleTextTemplateJSON result)
          {
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            if (fieldGeneratorSubtitle.have_value)
              {
                result.setSubtitle(fieldGeneratorSubtitle.value);
                fieldGeneratorSubtitle.have_value = false;
              }
            if (fieldGeneratorFooter.have_value)
              {
                result.setFooter(fieldGeneratorFooter.value);
                fieldGeneratorFooter.have_value = false;
              }
            if (fieldGeneratorActionAndroidIntent.have_value)
              {
                result.setActionAndroidIntent(fieldGeneratorActionAndroidIntent.value);
                fieldGeneratorActionAndroidIntent.have_value = false;
              }
            if (fieldGeneratorActionURIs.have_value)
              {
                result.initActionURIs();
                int count = fieldGeneratorActionURIs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendActionURIs(fieldGeneratorActionURIs.value[num]);
                  }
                fieldGeneratorActionURIs.value.Clear();
                fieldGeneratorActionURIs.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SimpleTextTemplateJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "ction", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 7, "ndroidIntent", 0, 12, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorActionAndroidIntent;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 7, "RIs", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorActionURIs;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ooter", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorFooter;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ubtitle", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorSubtitle;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTitle;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the SimpleTextTemplate class");
            fieldGeneratorSubtitle = new JSONHoldingStringGenerator("field \"Subtitle\" of the SimpleTextTemplate class");
            fieldGeneratorFooter = new JSONHoldingStringGenerator("field \"Footer\" of the SimpleTextTemplate class");
            fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the SimpleTextTemplate class", ignore_extras);
            fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the SimpleTextTemplate class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SimpleTextTemplate class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the SimpleTextTemplate class");
            fieldGeneratorSubtitle = new JSONHoldingStringGenerator("field \"Subtitle\" of the SimpleTextTemplate class");
            fieldGeneratorFooter = new JSONHoldingStringGenerator("field \"Footer\" of the SimpleTextTemplate class");
            fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the SimpleTextTemplate class", false);
            fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the SimpleTextTemplate class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SimpleTextTemplate class");
          }

        public override void reset()
          {
            fieldGeneratorTitle.reset();
            fieldGeneratorSubtitle.reset();
            fieldGeneratorFooter.reset();
            fieldGeneratorActionAndroidIntent.reset();
            fieldGeneratorActionURIs.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SimpleTextTemplateJSON  result)
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
        public SimpleTextTemplateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SimpleTextTemplateJSON  result)
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
    protected virtual void handle_result(List<SimpleTextTemplateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SimpleTextTemplateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SimpleTextTemplateJSON>();
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
    public List<SimpleTextTemplateJSON> value;
  };
  };
