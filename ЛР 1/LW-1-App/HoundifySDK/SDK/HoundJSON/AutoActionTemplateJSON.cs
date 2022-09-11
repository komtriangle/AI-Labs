/* file "AutoActionTemplateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AutoActionTemplateJSON : TemplateJSON
  {
    public class TypeItemJSON : JSONBase
      {
        private bool flagHasTemplateName;
        private string storeTemplateName;
        private bool flagHasTemplateData;
        private TemplateJSON  storeTemplateData;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTemplateName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field TemplateName of TypeItemJSON is not a string.");
            setTemplateName(json_string.getData());
          }


        private void  fromJSONTemplateData(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TemplateJSON convert_classy = TemplateJSON.from_json(json_value, ignore_extras, true);
            setTemplateData(convert_classy);
          }


        public TypeItemJSON()
          {
            flagHasTemplateName = false;
            flagHasTemplateData = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTemplateName()
          {
            return flagHasTemplateName;
          }

        public string  getTemplateName()
          {
            Debug.Assert(flagHasTemplateName);
            return storeTemplateName;
          }

        public bool  hasTemplateData()
          {
            return flagHasTemplateData;
          }

        public TemplateJSON   getTemplateData()
          {
            Debug.Assert(flagHasTemplateData);
            return storeTemplateData;
          }


        public virtual int extraTypeItemComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeItemComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeItemComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeItemLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTemplateName(string new_value)
          {
            flagHasTemplateName = true;
            storeTemplateName = new_value;
          }
        public void unsetTemplateName()
          {
            flagHasTemplateName = false;
          }
        public void setTemplateData(TemplateJSON  new_value)
          {
            if (flagHasTemplateData)
              {
              }
            flagHasTemplateData = true;
            storeTemplateData = new_value;
          }
        public void unsetTemplateData()
          {
            if (flagHasTemplateData)
              {
              }
            flagHasTemplateData = false;
          }

        public virtual void extraTypeItemAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeItemSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeItemLookup(key);
            if (old_field == null)
              {
                extraTypeItemAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasTemplateName);
            if (flagHasTemplateName)
              {
                handler.start_pair("TemplateName");
                handler.string_value(storeTemplateName);
              }
            Debug.Assert(partial_allowed || flagHasTemplateData);
            if (flagHasTemplateData)
              {
                handler.start_pair("TemplateData");
                if (partial_allowed)
                    storeTemplateData.write_partial_as_json(handler);
                else
                    storeTemplateData.write_as_json(handler);
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
            if (!(hasTemplateName()))
              {
                return "When parsing the object for %what%, the \"TemplateName\" field was missing.";
              }
            if (!(hasTemplateData()))
              {
                return "When parsing the object for %what%, the \"TemplateData\" field was missing.";
              }
            return null;
          }

        public static TypeItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeItemJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeItem", ignore_extras);
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
        public static TypeItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeItemJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeItem", ignore_extras);
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
        public static TypeItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeItemJSON from_text(string text, bool ignore_extras)
          {
            TypeItemJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeItem", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeItemJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeItemJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeItem", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorTemplateName;
            private TemplateJSON.HoldingGenerator fieldGeneratorTemplateData;
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
                TypeItemJSON result = new TypeItemJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeItemJSON result)
              {
                if (fieldGeneratorTemplateName.have_value)
                  {
                    result.setTemplateName(fieldGeneratorTemplateName.value);
                    fieldGeneratorTemplateName.have_value = false;
                  }
                else if ((!(result.hasTemplateName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TemplateName\" field was missing.");
                  }
                if (fieldGeneratorTemplateData.have_value)
                  {
                    result.setTemplateData(fieldGeneratorTemplateData.value);
                    fieldGeneratorTemplateData.have_value = false;
                  }
                else if ((!(result.hasTemplateData())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TemplateData\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeItemJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "Template", 0, 8, false) == 0)
                  {
                    switch (field_name[8])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 9, "ata", 0, 3, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorTemplateData;
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 9, "ame", 0, 3, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorTemplateName;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTemplateName = new JSONHoldingStringGenerator("field \"TemplateName\" of the TypeItem class");
                fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the TypeItem class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeItem class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTemplateName = new JSONHoldingStringGenerator("field \"TemplateName\" of the TypeItem class");
                fieldGeneratorTemplateData = new TemplateJSON.HoldingGenerator("field \"TemplateData\" of the TypeItem class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeItem class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTemplateName.reset();
                fieldGeneratorTemplateData.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorTemplateData.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorTemplateData.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeItemJSON  result)
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
            public TypeItemJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeItemJSON  result)
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
        protected virtual void handle_result(List<TypeItemJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeItemJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeItemJSON>();
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
        public List<TypeItemJSON> value;
      };
      };
    private bool flagHasActionText;
    private string storeActionText;
    private bool flagHasActionTextInProgress;
    private string storeActionTextInProgress;
    private bool flagHasActionAndroidIntent;
    private AndroidIntentJSON  storeActionAndroidIntent;
    private bool flagHasActionURIs;
    private List< string > storeActionURIs;
    private bool flagHasItem;
    private TypeItemJSON  storeItem;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraActionTextToJSON()
      {
        JSONStringValue generated_string_ActionText = new JSONStringValue(storeActionText);
        return generated_string_ActionText;
      }

    private JSONValue  extraActionTextInProgressToJSON()
      {
        JSONStringValue generated_string_ActionTextInProgress = new JSONStringValue(storeActionTextInProgress);
        return generated_string_ActionTextInProgress;
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

    private JSONValue  extraItemToJSON()
      {
        JSONValueHandler handler_Item = new JSONValueHandler();
        storeItem.write_as_json(handler_Item);
        return handler_Item.result;
      }


    private void  fromJSONActionText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ActionText of AutoActionTemplateJSON is not a string.");
        setActionText(json_string.getData());
      }


    private void  fromJSONActionTextInProgress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ActionTextInProgress of AutoActionTemplateJSON is not a string.");
        setActionTextInProgress(json_string.getData());
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
            throw new Exception("The value for field ActionURIs of AutoActionTemplateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ActionURIs of AutoActionTemplateJSON has too few elements.");
        List< string > vector_ActionURIs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ActionURIs of AutoActionTemplateJSON is not a string.");
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


    private void  fromJSONItem(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeItemJSON convert_classy = TypeItemJSON.from_json(json_value, ignore_extras, true);
        setItem(convert_classy);
      }


    public AutoActionTemplateJSON()
      {
        flagHasActionText = false;
        flagHasActionTextInProgress = false;
        flagHasActionAndroidIntent = false;
        flagHasActionURIs = false;
        flagHasItem = false;
        storeActionURIs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTemplateName()
      {
        return "AutoAction";
      }

    public bool  hasActionText()
      {
        return flagHasActionText;
      }

    public string  getActionText()
      {
        Debug.Assert(flagHasActionText);
        return storeActionText;
      }

    public bool  hasActionTextInProgress()
      {
        return flagHasActionTextInProgress;
      }

    public string  getActionTextInProgress()
      {
        Debug.Assert(flagHasActionTextInProgress);
        return storeActionTextInProgress;
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

    public bool  hasItem()
      {
        return flagHasItem;
      }

    public TypeItemJSON   getItem()
      {
        Debug.Assert(flagHasItem);
        return storeItem;
      }


    public virtual int extraAutoActionTemplateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAutoActionTemplateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAutoActionTemplateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAutoActionTemplateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTemplateComponentCount()
      {
        int result = 0;
        if (flagHasActionText)
            ++result;
        if (flagHasActionTextInProgress)
            ++result;
        if (flagHasActionAndroidIntent)
            ++result;
        if (flagHasActionURIs)
            ++result;
        if (flagHasItem)
            ++result;
        result += extraAutoActionTemplateComponentCount();
        return result;
      }
    public override string extraTemplateComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasActionText)
          {
            if (remainder == 0)
                return "ActionText";
            --remainder;
          }
        if (flagHasActionTextInProgress)
          {
            if (remainder == 0)
                return "ActionTextInProgress";
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
        if (flagHasItem)
          {
            if (remainder == 0)
                return "Item";
            --remainder;
          }
        return extraAutoActionTemplateComponentKey(remainder);
      }
    public override JSONValue extraTemplateComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasActionText)
          {
            if (remainder == 0)
                return extraActionTextToJSON();
            --remainder;
          }
        if (flagHasActionTextInProgress)
          {
            if (remainder == 0)
                return extraActionTextInProgressToJSON();
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
        if (flagHasItem)
          {
            if (remainder == 0)
                return extraItemToJSON();
            --remainder;
          }
        return extraAutoActionTemplateComponentValue(remainder);
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
                        case 'T':
                            if (String.Compare(field_name, 7, "ext", 0, 3, false) == 0)
                              {
                                if (field_name.Length == 10)
                                  {
                                    return (flagHasActionText ? extraActionTextToJSON() : null);
                                  }
                                switch (field_name[10])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 11, "nProgress", 0, 9, false) == 0) && (field_name.Length == 20))
                                            return (flagHasActionTextInProgress ? extraActionTextInProgressToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
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
            case 'I':
                if ((String.Compare(field_name, 1, "tem", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasItem ? extraItemToJSON() : null);
                break;
            default:
                break;
          }
        return extraAutoActionTemplateLookup(field_name);
      }

    public void setActionText(string new_value)
      {
        flagHasActionText = true;
        storeActionText = new_value;
      }
    public void unsetActionText()
      {
        flagHasActionText = false;
      }
    public void setActionTextInProgress(string new_value)
      {
        flagHasActionTextInProgress = true;
        storeActionTextInProgress = new_value;
      }
    public void unsetActionTextInProgress()
      {
        flagHasActionTextInProgress = false;
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
    public void setItem(TypeItemJSON  new_value)
      {
        if (flagHasItem)
          {
          }
        flagHasItem = true;
        storeItem = new_value;
      }
    public void unsetItem()
      {
        if (flagHasItem)
          {
          }
        flagHasItem = false;
      }

    public virtual void extraAutoActionTemplateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAutoActionTemplateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAutoActionTemplateLookup(key);
        if (old_field == null)
          {
            extraAutoActionTemplateAppendPair(key, new_component);
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
                        case 'T':
                            if (String.Compare(key, 7, "ext", 0, 3, false) == 0)
                              {
                                if (key.Length == 10)
                                  {
                                    {
                                    fromJSONActionText(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[10])
                                  {
                                    case 'I':
                                        if ((String.Compare(key, 11, "nProgress", 0, 9, false) == 0) && (key.Length == 20))
                                            {
                                            fromJSONActionTextInProgress(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
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
            case 'I':
                if ((String.Compare(key, 1, "tem", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONItem(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAutoActionTemplateAppendPair(key, new_component);
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
                        case 'T':
                            if (String.Compare(key, 7, "ext", 0, 3, false) == 0)
                              {
                                if (key.Length == 10)
                                  {
                                    {
                                    fromJSONActionText(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[10])
                                  {
                                    case 'I':
                                        if ((String.Compare(key, 11, "nProgress", 0, 9, false) == 0) && (key.Length == 20))
                                            {
                                            fromJSONActionTextInProgress(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
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
            case 'I':
                if ((String.Compare(key, 1, "tem", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONItem(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAutoActionTemplateSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasActionText);
        if (flagHasActionText)
          {
            handler.start_pair("ActionText");
            handler.string_value(storeActionText);
          }
        Debug.Assert(partial_allowed || flagHasActionTextInProgress);
        if (flagHasActionTextInProgress)
          {
            handler.start_pair("ActionTextInProgress");
            handler.string_value(storeActionTextInProgress);
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
        if (flagHasItem)
          {
            handler.start_pair("Item");
            if (partial_allowed)
                storeItem.write_partial_as_json(handler);
            else
                storeItem.write_as_json(handler);
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
        if ((!allow_unpolished) && !(hasActionText()))
          {
            return "When parsing the object for %what%, the \"ActionText\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasActionTextInProgress()))
          {
            return "When parsing the object for %what%, the \"ActionTextInProgress\" field was missing.";
          }
        return null;
      }

    public static new AutoActionTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AutoActionTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AutoActionTemplate", ignore_extras);
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
    public static new AutoActionTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AutoActionTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AutoActionTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AutoActionTemplate", ignore_extras);
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
    public static new AutoActionTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AutoActionTemplateJSON from_text(string text, bool ignore_extras)
      {
        AutoActionTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AutoActionTemplate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AutoActionTemplateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AutoActionTemplateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AutoActionTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AutoActionTemplate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TemplateJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorActionText;
        private JSONHoldingStringGenerator fieldGeneratorActionTextInProgress;
        private AndroidIntentJSON.HoldingGenerator fieldGeneratorActionAndroidIntent;
        private JSONHoldingStringArrayGenerator fieldGeneratorActionURIs;
        private TypeItemJSON.HoldingGenerator fieldGeneratorItem;
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
            if (!(getTemplateJSONKey().Equals("AutoAction")))
                throw new Exception("The key field has a value other than `AutoAction'.");
            AutoActionTemplateJSON result = new AutoActionTemplateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAutoActionTemplateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TemplateJSON new_result)
          {
            handle_result((AutoActionTemplateJSON )new_result);
          }
        protected void finish(AutoActionTemplateJSON result)
          {
            if (fieldGeneratorActionText.have_value)
              {
                result.setActionText(fieldGeneratorActionText.value);
                fieldGeneratorActionText.have_value = false;
              }
            else if ((!(result.hasActionText())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ActionText\" field was missing.");
              }
            if (fieldGeneratorActionTextInProgress.have_value)
              {
                result.setActionTextInProgress(fieldGeneratorActionTextInProgress.value);
                fieldGeneratorActionTextInProgress.have_value = false;
              }
            else if ((!(result.hasActionTextInProgress())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ActionTextInProgress\" field was missing.");
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
            if (fieldGeneratorItem.have_value)
              {
                result.setItem(fieldGeneratorItem.value);
                fieldGeneratorItem.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(AutoActionTemplateJSON new_result);
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
                            case 'T':
                                if (String.Compare(field_name, 7, "ext", 0, 3, false) == 0)
                                  {
                                    if (field_name.Length == 10)
                                      {
                                        return fieldGeneratorActionText;
                                      }
                                    switch (field_name[10])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 11, "nProgress", 0, 9, false) == 0) && (field_name.Length == 20))
                                                return fieldGeneratorActionTextInProgress;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
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
                case 'I':
                    if ((String.Compare(field_name, 1, "tem", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorItem;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorActionText = new JSONHoldingStringGenerator("field \"ActionText\" of the AutoActionTemplate class");
            fieldGeneratorActionTextInProgress = new JSONHoldingStringGenerator("field \"ActionTextInProgress\" of the AutoActionTemplate class");
            fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the AutoActionTemplate class", ignore_extras);
            fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the AutoActionTemplate class");
            fieldGeneratorItem = new TypeItemJSON.HoldingGenerator("field \"Item\" of the AutoActionTemplate class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AutoActionTemplate class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorActionText = new JSONHoldingStringGenerator("field \"ActionText\" of the AutoActionTemplate class");
            fieldGeneratorActionTextInProgress = new JSONHoldingStringGenerator("field \"ActionTextInProgress\" of the AutoActionTemplate class");
            fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the AutoActionTemplate class", false);
            fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the AutoActionTemplate class");
            fieldGeneratorItem = new TypeItemJSON.HoldingGenerator("field \"Item\" of the AutoActionTemplate class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AutoActionTemplate class");
          }

        public override void reset()
          {
            fieldGeneratorActionText.reset();
            fieldGeneratorActionTextInProgress.reset();
            fieldGeneratorActionAndroidIntent.reset();
            fieldGeneratorActionURIs.reset();
            fieldGeneratorItem.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AutoActionTemplateJSON  result)
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
        public AutoActionTemplateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AutoActionTemplateJSON  result)
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
    protected virtual void handle_result(List<AutoActionTemplateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AutoActionTemplateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AutoActionTemplateJSON>();
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
    public List<AutoActionTemplateJSON> value;
  };
  };
